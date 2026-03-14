using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ZLinq;
using ZLinq.Linq;

// Token: 0x02000051 RID: 81
public class RandomPool
{
	// Token: 0x06000219 RID: 537 RVA: 0x00013B84 File Offset: 0x00011D84
	public RandomPool(List<Dictionary<string, string>> datas, Dice fromDice)
	{
		this.dice = fromDice;
		this.datas = (from x in datas.AsValueEnumerable<Dictionary<string, string>>()
		where !Singleton<GameRuntimeData>.Instance.IsLocked(x.GetValueOrDefault("Id", "")) && x.GetValueOrDefault("Rarity", "0") != "7"
		select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00013BD8 File Offset: 0x00011DD8
	public List<Dictionary<string, string>> DrawByProperty(string property, int count, Dictionary<string, float> propertyWeightDic = null)
	{
		List<ValueTuple<Dictionary<string, string>, float>> weightDatas = new List<ValueTuple<Dictionary<string, string>, float>>();
		using (List<Dictionary<string, string>>.Enumerator enumerator = this.datas.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Dictionary<string, string> data = enumerator.Current;
				float weight = 1f;
				bool flag = propertyWeightDic != null;
				if (flag)
				{
					weight = 1000f * propertyWeightDic.GetValueOrDefault(data[property], 1f) / (float)this.datas.FindAll((Dictionary<string, string> x) => x[property] == data[property]).Count;
				}
				weightDatas.Add(new ValueTuple<Dictionary<string, string>, float>(data, weight));
			}
		}
		return this.DrawByWeight(count, weightDatas);
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00013CD0 File Offset: 0x00011ED0
	public List<Dictionary<string, string>> DrawByType(int count, Dictionary<string, float> typeWeightDic = null)
	{
		return this.DrawByProperty("Type", count, typeWeightDic);
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00013CF0 File Offset: 0x00011EF0
	public List<Dictionary<string, string>> DrawByNote(int count, Dictionary<string, float> typeWeightDic = null)
	{
		return this.DrawByProperty("Note", count, typeWeightDic);
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00013D10 File Offset: 0x00011F10
	public List<Dictionary<string, string>> DrawByCount(int count)
	{
		List<ValueTuple<Dictionary<string, string>, float>> weightDatas = new List<ValueTuple<Dictionary<string, string>, float>>();
		foreach (Dictionary<string, string> data in this.datas)
		{
			float weight = 10000f / (float)this.datas.Count;
			weightDatas.Add(new ValueTuple<Dictionary<string, string>, float>(data, weight));
		}
		return this.DrawByWeight(count, weightDatas);
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00013D98 File Offset: 0x00011F98
	public List<Dictionary<string, string>> DrawByRarity(int count)
	{
		List<ValueTuple<Dictionary<string, string>, float>> weightDatas = new List<ValueTuple<Dictionary<string, string>, float>>();
		foreach (Dictionary<string, string> data in this.datas)
		{
			float weight = 9f - 2f * float.Parse(data["Rarity"]);
			weightDatas.Add(new ValueTuple<Dictionary<string, string>, float>(data, weight));
		}
		return this.DrawByWeight(count, weightDatas);
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00013E28 File Offset: 0x00012028
	public List<Dictionary<string, string>> DrawByTag(int count, Dictionary<string, float> tagWeightDic)
	{
		List<ValueTuple<Dictionary<string, string>, float>> weightDatas = new List<ValueTuple<Dictionary<string, string>, float>>();
		foreach (Dictionary<string, string> data in this.datas)
		{
			float weight = 0f;
			foreach (string tag in data["Tag"].Split(',', StringSplitOptions.None))
			{
				weight += tagWeightDic.GetValueOrDefault(tag, 0f);
			}
			weightDatas.Add(new ValueTuple<Dictionary<string, string>, float>(data, weight));
		}
		return this.DrawByWeight(count, weightDatas);
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00013EE4 File Offset: 0x000120E4
	private List<Dictionary<string, string>> DrawByWeight(int count, [TupleElementNames(new string[]
	{
		"data",
		"weight"
	})] List<ValueTuple<Dictionary<string, string>, float>> weightDatas)
	{
		List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
		float totalWeight = weightDatas.AsValueEnumerable<ValueTuple<Dictionary<string, string>, float>>().Sum(([TupleElementNames(new string[]
		{
			"data",
			"weight"
		})] ValueTuple<Dictionary<string, string>, float> x) => x.Item2);
		bool allowDuplicate = count > weightDatas.Count;
		List<ValueTuple<Dictionary<string, string>, float>> availableData = new List<ValueTuple<Dictionary<string, string>, float>>(weightDatas);
		this.dice = this.dice.WithRange(0, (int)totalWeight);
		for (int i = 0; i < count; i++)
		{
			bool flag = availableData.Count == 0 && allowDuplicate;
			if (flag)
			{
				availableData = new List<ValueTuple<Dictionary<string, string>, float>>(weightDatas);
				totalWeight = weightDatas.AsValueEnumerable<ValueTuple<Dictionary<string, string>, float>>().Sum(([TupleElementNames(new string[]
				{
					"data",
					"weight"
				})] ValueTuple<Dictionary<string, string>, float> x) => x.Item2);
				this.dice = this.dice.WithRange(0, (int)totalWeight);
			}
			float random = (float)this.dice.Roll().Value;
			float sum = 0f;
			for (int j = 0; j < availableData.Count; j++)
			{
				ValueTuple<Dictionary<string, string>, float> weightData = availableData[j];
				sum += weightData.Item2;
				bool flag2 = random <= sum;
				if (flag2)
				{
					result.Add(weightData.Item1);
					bool flag3 = !allowDuplicate;
					if (flag3)
					{
						foreach (ValueTuple<Dictionary<string, string>, float> item in availableData)
						{
							bool flag4 = item.Item1 == weightData.Item1;
							if (flag4)
							{
								availableData.Remove(item);
								break;
							}
						}
						totalWeight -= weightData.Item2;
						bool flag5 = totalWeight > 0f;
						if (flag5)
						{
							this.dice = this.dice.WithRange(0, (int)totalWeight);
						}
					}
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x040008E6 RID: 2278
	private List<Dictionary<string, string>> datas;

	// Token: 0x040008E7 RID: 2279
	private Dice dice;
}

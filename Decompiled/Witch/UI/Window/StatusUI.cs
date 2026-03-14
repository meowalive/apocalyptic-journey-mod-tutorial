using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x02000299 RID: 665
	public class StatusUI : MonoBehaviour
	{
		// Token: 0x060014E0 RID: 5344 RVA: 0x000A4F40 File Offset: 0x000A3140
		public void Init(BackpackUI backpackUI)
		{
			this.RewardGenerator(Singleton<GameConfigManager>.Instance.GetTable(DataType.Bless).Getlines());
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x000A4F5C File Offset: 0x000A315C
		public void DataUpdate()
		{
			bool flag = this.statusUIData.VarsMap == null;
			if (!flag)
			{
				foreach (KeyValuePair<string, int> item in this.statusUIData.VarsMap)
				{
					base.transform.Find("Content/Status/VarList/" + item.Key + "/Normal/Name").GetComponent<TMP_Text>().text = item.Key.Localize("TopBarUI");
					base.transform.Find("Content/Status/VarList/" + item.Key + "/Highlighted/Name").GetComponent<TMP_Text>().text = item.Key.Localize("TopBarUI");
				}
				base.transform.Find("Content/BlessTitle").GetComponent<TMP_Text>().text = "Holding blessings".Localize("BackpackUI");
				this.ShowRoleMsg();
			}
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x000A507C File Offset: 0x000A327C
		public void ShowMsg(StatusUIData statusUIData)
		{
			this.statusUIData = statusUIData;
			this.ShowRoleMsg();
			this.ShowVar();
			this.ShowSan();
			this.ShowBless();
			this.ShowMoney();
			this.ShowBuff();
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000A50B0 File Offset: 0x000A32B0
		public void ShowSan()
		{
			base.transform.Find("Content/Status/Health/Val").GetComponent<TMP_Text>().text = this.statusUIData.San.ToString() + "/" + this.statusUIData.MaxSan.ToString();
			base.transform.Find("Content/Status/Health/Bar/Inner").GetComponent<Image>().DOFillAmount((float)this.statusUIData.San / (float)this.statusUIData.MaxSan, 0.3f);
			base.transform.Find("Content/Status/Health/Bar").GetComponent<Image>().DOFillAmount((float)this.statusUIData.San / (float)this.statusUIData.MaxSan, 0.2f).SetDelay(0.3f);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000A5180 File Offset: 0x000A3380
		public void ShowMoney()
		{
			base.transform.Find("Content/WeaList/Money/val").GetComponent<TMP_Text>().text = this.statusUIData.Money.ToString();
			base.transform.Find("Content/WeaList/True/val").GetComponent<TMP_Text>().text = Singleton<GameRuntimeData>.Instance.Truth.ToString();
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000A51EC File Offset: 0x000A33EC
		public void ShowVar()
		{
			foreach (KeyValuePair<string, int> item in this.statusUIData.VarsMap)
			{
				Transform varItem = base.transform.Find("Content/Status/VarList/" + item.Key);
				bool flag = this.statusUIData.ChooseVars.Contains(item.Key);
				string addStr;
				if (flag)
				{
					bool flag2 = this.statusUIData.ChooseVars[0] == item.Key;
					if (flag2)
					{
						addStr = RoleTable.Instance.MainVarUpperBound.ToString();
					}
					else
					{
						addStr = RoleTable.Instance.SecondaryVarUpperBound.ToString();
					}
				}
				else
				{
					addStr = RoleTable.Instance.OtherVarUpperBound.ToString();
				}
				varItem.Find("Normal/Val").GetComponent<TextMeshProUGUI>().text = item.Value.ToString("D2") + "/" + addStr;
				varItem.Find("Normal/Name").GetComponent<TMP_Text>().text = item.Key.Localize("TopBarUI");
				varItem.Find("Highlighted/Val").GetComponent<TextMeshProUGUI>().text = item.Value.ToString("D2") + "/" + addStr;
				varItem.Find("Highlighted/Name").GetComponent<TMP_Text>().text = item.Key.Localize("TopBarUI");
			}
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x000A53BC File Offset: 0x000A35BC
		public void ShowBuff()
		{
			this.ReleaseBuff();
			bool flag = FightManager.Instance == null || FightManager.Instance.fightType == FightType.None;
			if (!flag)
			{
				bool flag2 = FightPlayer.Instance == null || FightPlayer.Instance.Status == null || FightPlayer.Instance.Status.IsNull() || FightPlayer.Instance.Status.GetBuffs() == null;
				if (!flag2)
				{
					Transform prefab = base.transform.Find("Content/BuffList/Scroll Area/List/BuffPrefab");
					foreach (IBuffItem item in FightPlayer.Instance.Status.GetBuffs())
					{
						GameObject buff = Singleton<ObjectPool>.Instance.Get(prefab.gameObject, prefab.parent);
						BuffShowItem buffShowItem = buff.GetComponent<BuffShowItem>();
						bool flag3 = buffShowItem == null;
						if (flag3)
						{
							buffShowItem = buff.AddComponent<BuffShowItem>();
						}
						buffShowItem.Init(item.buffConfig.dataConfig as DataConfig);
						buff.name = item.buffConfig.dataConfig.data["Id"];
						buff.transform.Find("Level").GetComponent<TMP_Text>().text = item.buffConfig.Level.ToString();
					}
				}
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x000A552C File Offset: 0x000A372C
		public void ReleaseBuff()
		{
			foreach (object obj in base.transform.Find("Content/BuffList/Scroll Area/List"))
			{
				Transform child = (Transform)obj;
				bool flag = child.name == "BuffPrefab";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(child.gameObject);
				}
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000A55B4 File Offset: 0x000A37B4
		public void ShowBless()
		{
			foreach (object obj in base.transform.Find("Content/BlessList/Scroll Area/List"))
			{
				Transform list = (Transform)obj;
				bool flag = list.name == "Item";
				if (!flag)
				{
					foreach (object obj2 in list)
					{
						Transform item2 = (Transform)obj2;
						Singleton<ObjectPool>.Instance.Release(item2.gameObject);
						foreach (object obj3 in item2)
						{
							Transform child = (Transform)obj3;
							Singleton<ObjectPool>.Instance.Release(child.gameObject);
						}
					}
				}
			}
			int blessCnt = 0;
			List<DataConfig> uniqueBlessings = (from b in this.statusUIData.blessingConfigs
			group b by b.data["Id"] into g
			select g.First<DataConfig>()).ToList<DataConfig>();
			using (List<DataConfig>.Enumerator enumerator4 = uniqueBlessings.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					DataConfig item = enumerator4.Current;
					Transform prefab = base.transform.Find("Content/BlessList/PositivePrefab");
					int listCount = blessCnt / 5 + 1;
					bool flag2 = base.transform.Find("Content/BlessList/Scroll Area/List/Item" + listCount.ToString()) == null;
					if (flag2)
					{
						Transform itemPrefab = base.transform.Find("Content/BlessList/Scroll Area/List/Item");
						GameObject itemObj = Singleton<ObjectPool>.Instance.Get(itemPrefab.gameObject, itemPrefab.parent);
						itemObj.name = "Item" + listCount.ToString();
					}
					Transform blessList = base.transform.Find("Content/BlessList/Scroll Area/List/Item" + listCount.ToString());
					blessList.gameObject.SetActive(true);
					GameObject bless = Singleton<ObjectPool>.Instance.Get(prefab.gameObject, blessList);
					ItemNonDrag blessItem = bless.GetComponent<ItemNonDrag>();
					bless.transform.Find("Count").GetComponent<TextMeshProUGUI>().text = this.statusUIData.blessingConfigs.Count((DataConfig b) => b.data["Id"] == item.data["Id"]).ToString();
					blessItem.Init(item);
					bless.transform.Find("Icon").GetComponent<Image>().sprite = blessItem.itemIcon;
					bless.name = blessItem.itemName;
					blessCnt++;
				}
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x000A5920 File Offset: 0x000A3B20
		public void ShowRoleMsg()
		{
			bool flag = this.statusUIData.career == null;
			if (flag)
			{
				base.transform.Find("Content/RoleMsg/Name").GetComponent<TextMeshProUGUI>().text = "未知职业".Localize("Glossary");
			}
			else
			{
				base.transform.Find("Content/RoleMsg/Name").GetComponent<TextMeshProUGUI>().text = this.statusUIData.career.data.Localize("Name");
				base.transform.Find("Content/RoleMsg/Avatar").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(this.statusUIData.career.data["DollIcon"], true);
				base.transform.Find("Content/RoleMsg/Avatar").GetComponent<Image>().SetNativeSize();
				base.transform.Find("Background").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(this.statusUIData.career.data["Character"], true);
				base.transform.Find("Background").GetComponent<Image>().SetNativeSize();
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000A5A54 File Offset: 0x000A3C54
		public List<Tuple<List<DataConfig>, List<DataConfig>>> GenerateThreeOptions()
		{
			return new List<Tuple<List<DataConfig>, List<DataConfig>>>
			{
				this.Pure(),
				this.Pure(),
				this.Pure()
			};
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000A5A94 File Offset: 0x000A3C94
		public void RewardGenerator(List<Dictionary<string, string>> blessings)
		{
			this._allBlessings = (from b in blessings.AsValueEnumerable<Dictionary<string, string>>()
			where !Singleton<GameRuntimeData>.Instance.IsLocked(b["Id"]) && int.Parse(b["Weight"]) < 6
			select b).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			this.VarBless = (from b in this._allBlessings.AsValueEnumerable<Dictionary<string, string>>()
			where b["Source"] == "物资"
			select b).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			this.SkillBless = (from b in this._allBlessings.AsValueEnumerable<Dictionary<string, string>>()
			where b["Source"] == "技能"
			select b).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			this._AdvancedBlessings = (from b in blessings.AsValueEnumerable<Dictionary<string, string>>()
			where int.Parse(b["Weight"]) >= 6
			select b).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x000A5B80 File Offset: 0x000A3D80
		public List<Tuple<List<DataConfig>, List<DataConfig>>> GenerateHighOptions()
		{
			List<Dictionary<string, string>> HighReward = new RandomPool((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Bless).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"]) && int.Parse(x["Weight"]) > 5
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), MapManager.Instance.NowDice).DrawByCount(3);
			List<Tuple<List<DataConfig>, List<DataConfig>>> tempList = new List<Tuple<List<DataConfig>, List<DataConfig>>>();
			for (int i = 0; i < 3; i++)
			{
				Tuple<List<DataConfig>, List<DataConfig>> temp = this.Pure();
				tempList.Add(new Tuple<List<DataConfig>, List<DataConfig>>(temp.Item1.Append(new DataConfig(HighReward[i]["Id"], DataType.Bless)).ToList<DataConfig>(), temp.Item2));
			}
			return tempList;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000A5C48 File Offset: 0x000A3E48
		private Tuple<List<DataConfig>, List<DataConfig>> Pure()
		{
			return new Tuple<List<DataConfig>, List<DataConfig>>(this.SelectBlessings(this.SkillBless, this.BaseQuota), this.SelectBlessings(this.VarBless, this.BaseQuota + 1));
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000A5C88 File Offset: 0x000A3E88
		private List<DataConfig> SelectBlessings(List<Dictionary<string, string>> pool, int maxQuota)
		{
			List<DataConfig> result = new List<DataConfig>();
			result.Clear();
			int hasCount = 0;
			int remainingQuota = maxQuota;
			List<Dictionary<string, string>> shuffled = (from x in pool
			orderby Guid.NewGuid()
			select x).ToList<Dictionary<string, string>>();
			foreach (Dictionary<string, string> blessing in shuffled)
			{
				bool flag = int.Parse(blessing["Weight"]) > remainingQuota;
				if (!flag)
				{
					bool flag2 = !this.dataConfigList.ContainsKey(blessing["Id"]);
					if (flag2)
					{
						this.dataConfigList.Add(blessing["Id"], new DataConfig(blessing["Id"], DataType.Bless));
					}
					hasCount++;
					result.Add(this.dataConfigList[blessing["Id"]]);
					remainingQuota -= int.Parse(blessing["Weight"]);
					bool flag3 = remainingQuota <= 0 || hasCount > 2;
					if (flag3)
					{
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000A5DD4 File Offset: 0x000A3FD4
		private List<DataConfig> SelectRandom(List<Dictionary<string, string>> pool, int count)
		{
			List<Dictionary<string, string>> pool2 = (from x in pool
			orderby Guid.NewGuid()
			select x).Take(count).ToList<Dictionary<string, string>>();
			List<DataConfig> result = new List<DataConfig>();
			foreach (Dictionary<string, string> item in pool2)
			{
				bool flag = !this.dataConfigList.ContainsKey(item["Id"]);
				if (flag)
				{
					this.dataConfigList.Add(item["Id"], new DataConfig(item["Id"], DataType.Bless));
				}
				result.Add(this.dataConfigList[item["Id"]]);
			}
			return result;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000A5EC8 File Offset: 0x000A40C8
		private void GetDes(string description, out string name, out string des)
		{
			name = "";
			des = "";
			string namePattern = "<name>(.*?)<\\/name>";
			string desPattern = "<des>(.*?)<\\/des>";
			Match nameMatch = Regex.Match(description, namePattern, RegexOptions.Singleline);
			Match desMatch = Regex.Match(description, desPattern, RegexOptions.Singleline);
			bool success = nameMatch.Success;
			if (success)
			{
				name = nameMatch.Groups[1].Value;
			}
			bool success2 = desMatch.Success;
			if (success2)
			{
				des = desMatch.Groups[1].Value;
			}
		}

		// Token: 0x040010BC RID: 4284
		public StatusUIData statusUIData;

		// Token: 0x040010BD RID: 4285
		private int BaseQuota = 5;

		// Token: 0x040010BE RID: 4286
		private List<Dictionary<string, string>> _allBlessings;

		// Token: 0x040010BF RID: 4287
		private List<Dictionary<string, string>> VarBless;

		// Token: 0x040010C0 RID: 4288
		private List<Dictionary<string, string>> SkillBless;

		// Token: 0x040010C1 RID: 4289
		private List<Dictionary<string, string>> _AdvancedBlessings;

		// Token: 0x040010C2 RID: 4290
		private Dictionary<string, DataConfig> dataConfigList = new Dictionary<string, DataConfig>();
	}
}

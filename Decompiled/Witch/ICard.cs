using System;
using System.Collections.Generic;
using Cysharp.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Witch.UI;

// Token: 0x0200001F RID: 31
public interface ICard
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060000C4 RID: 196
	// (set) Token: 0x060000C5 RID: 197
	int index { get; set; }

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000C6 RID: 198
	// (set) Token: 0x060000C7 RID: 199
	Vector2 initPosition { get; set; }

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000C8 RID: 200
	// (set) Token: 0x060000C9 RID: 201
	Vector3 initAngle { get; set; }

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060000CA RID: 202
	// (set) Token: 0x060000CB RID: 203
	bool draging { get; set; }

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060000CC RID: 204
	float initScale { get; }

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060000CD RID: 205
	float selectScale { get; }

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000CE RID: 206
	// (set) Token: 0x060000CF RID: 207
	bool isReverse { get; set; }

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060000D0 RID: 208
	// (set) Token: 0x060000D1 RID: 209
	bool ignore { get; set; }

	// Token: 0x060000D2 RID: 210
	void SetIndex(int index);

	// Token: 0x060000D3 RID: 211 RVA: 0x0000730C File Offset: 0x0000550C
	public static void SetCardStyle(Transform transform, DataConfig dataConfig)
	{
		bool flag = transform.Find("Front/background").GetComponent<MeshRenderer>() != null;
		if (flag)
		{
			ICard.SetCardStyleMesh(transform, dataConfig);
		}
		else
		{
			ICard.SetCardStyleImage(transform, dataConfig);
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000734C File Offset: 0x0000554C
	private static void SetCardStyleMesh(Transform transform, DataConfig dataConfig)
	{
		string rarity = dataConfig.data["Rarity"];
		string backgroundPath = (rarity == "1") ? "Icon/CardTemplate/NewTemplate/底面一阶" : "Icon/CardTemplate/NewTemplate/底面二三阶";
		Texture cardTexture = ResourceLoader.Load<Texture>(dataConfig.data["Icon"], true);
		bool flag = cardTexture == null;
		if (flag)
		{
			cardTexture = ResourceLoader.Load<Texture>("Icon/Card/卡面占位", true);
		}
		bool flag2 = RoleTable.Instance != null;
		if (flag2)
		{
			DataConfig enchData = RoleTable.Instance.enchasedDict.GetValueOrDefault(dataConfig.InstanceID, null);
			bool flag3 = enchData != null;
			if (flag3)
			{
				transform.Find("Front/Icons/Ench").gameObject.SetActive(true);
				transform.Find("Front/Icons/Ench/Item").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>(enchData.data.GetValueOrDefault("Icon", ""), true);
			}
		}
		transform.Find("Front/icon").GetComponent<MeshRenderer>().material.mainTexture = cardTexture;
		transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>(backgroundPath, true);
		bool flag4 = rarity == "3";
		if (flag4)
		{
			transform.Find("Front/rarity").gameObject.SetActive(true);
			transform.Find("Front/rarity").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/三阶修饰", true);
			transform.Find("Front/titleFrame").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/标题框二三阶", true);
			transform.Find("Front/iconFrame").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/卡面信息框三阶", true);
			transform.Find("Front/cost").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/费用框三阶", true);
		}
		else
		{
			bool flag5 = rarity == "2";
			if (flag5)
			{
				transform.Find("Front/rarity").gameObject.SetActive(true);
				transform.Find("Front/rarity").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/二阶修饰", true);
				transform.Find("Front/titleFrame").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/标题框二三阶", true);
				transform.Find("Front/iconFrame").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/卡面信息框一二阶", true);
				transform.Find("Front/cost").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/费用框一二阶", true);
			}
			else
			{
				transform.Find("Front/rarity").gameObject.SetActive(false);
				transform.Find("Front/titleFrame").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/标题框一阶", true);
				transform.Find("Front/iconFrame").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/卡面信息框一二阶", true);
				transform.Find("Front/cost").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/NewTemplate/费用框一二阶", true);
			}
		}
		transform.Find("Front/cost/cost").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/Template/费用数字/" + dataConfig.data["Expend"], true);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x000076D0 File Offset: 0x000058D0
	private static void SetCardStyleImage(Transform transform, DataConfig dataConfig)
	{
		string rarity = dataConfig.data["Rarity"];
		bool flag = rarity == "3";
		if (flag)
		{
			transform.Find("Front/rarity").gameObject.SetActive(true);
			transform.Find("Front/rarity").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/三阶修饰", true);
			transform.Find("Front/background").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/底面二三阶", true);
			transform.Find("Front/titleFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/标题框一阶", true);
			transform.Find("Front/iconFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/卡面信息框三阶", true);
			transform.Find("Front/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/费用框三阶", true);
		}
		else
		{
			bool flag2 = rarity == "2";
			if (flag2)
			{
				transform.Find("Front/rarity").gameObject.SetActive(true);
				transform.Find("Front/rarity").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/二阶修饰", true);
				transform.Find("Front/background").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/底面二三阶", true);
				transform.Find("Front/titleFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/标题框一阶", true);
				transform.Find("Front/iconFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/卡面信息框一二阶", true);
				transform.Find("Front/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/费用框一二阶", true);
			}
			else
			{
				transform.Find("Front/rarity").gameObject.SetActive(false);
				transform.Find("Front/background").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/底面一阶", true);
				transform.Find("Front/titleFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/标题框一阶", true);
				transform.Find("Front/iconFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/卡面信息框一二阶", true);
				transform.Find("Front/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/费用框一二阶", true);
			}
		}
		Sprite IconSprite = ResourceLoader.Load<Sprite>(dataConfig.data["Icon"], true);
		bool flag3 = IconSprite == null;
		if (flag3)
		{
			IconSprite = ResourceLoader.Load<Sprite>("Icon/Card/卡面占位", true);
		}
		transform.Find("Front/icon").GetComponent<Image>().sprite = IconSprite;
		bool flag4 = transform.Find("Front/cost/cost").GetComponent<Image>().sprite == null;
		if (flag4)
		{
			transform.Find("Front/cost/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/Template/费用数字/" + dataConfig.data["Expend"], true);
		}
		bool flag5 = RoleTable.Instance != null;
		if (flag5)
		{
			DataConfig enchData = RoleTable.Instance.enchasedDict.GetValueOrDefault(dataConfig.InstanceID, null);
			bool flag6 = enchData != null;
			if (flag6)
			{
				transform.Find("Front/Icons/Ench").gameObject.SetActive(true);
				transform.Find("Front/Icons/Ench/Item").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(enchData.data.GetValueOrDefault("Icon", ""), true);
			}
			else
			{
				transform.Find("Front/Icons/Ench").gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00007A74 File Offset: 0x00005C74
	public static void SetCardMsg(Transform transform, DataConfig dataConfig, StatusManager status = null)
	{
		IScriptExecutor scriptExecutor = dataConfig.scriptExecutor;
		IDictionary<string, string> data = dataConfig.data;
		scriptExecutor.RunScript("InitScript");
		DataConfig enchData = null;
		int baseCost = int.Parse(data["Expend"]);
		int exCost = 0;
		bool flag = RoleTable.Instance != null;
		if (flag)
		{
			enchData = RoleTable.Instance.enchasedDict.GetValueOrDefault(dataConfig.InstanceID, null);
			bool flag2 = enchData != null && enchData.Vars["Tag"].Contains("Exhaustion");
			if (flag2)
			{
				exCost = 1;
			}
		}
		bool flag3 = transform.Find("Front/cost/cost").GetComponent<MeshRenderer>() != null;
		if (flag3)
		{
			bool flag4 = status != null;
			if (flag4)
			{
				transform.Find("Front/cost/cost").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/Template/费用数字/" + Mathf.Min((int)Mathf.Abs((float)int.Parse(data["Expend"]) * status.dynamicVariables["CardCost"]) + exCost, 4).ToString(), true);
			}
			else
			{
				transform.Find("Front/cost/cost").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/Template/费用数字/" + (int.Parse(data["Expend"]) + exCost).ToString(), true);
			}
		}
		else
		{
			bool flag5 = transform.Find("Front/cost/cost").GetComponent<Image>() != null;
			if (flag5)
			{
				bool flag6 = status != null;
				if (flag6)
				{
					transform.Find("Front/cost/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/Template/费用数字/" + Mathf.Min((int)Mathf.Abs((float)int.Parse(data["Expend"]) * status.dynamicVariables["CardCost"]) + exCost, 4).ToString(), true);
				}
				else
				{
					transform.Find("Front/cost/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/Template/费用数字/" + (int.Parse(data["Expend"]) + exCost).ToString(), true);
				}
			}
		}
		bool flag7 = transform.Find("Front/字体") == null;
		if (!flag7)
		{
			bool flag8 = transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>() != null;
			if (flag8)
			{
				transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().text = data.Localize("Name");
			}
			List<string> keyWords = new List<string>();
			string tempText = dataConfig.Description().Highlight(keyWords);
			bool flag9 = enchData != null;
			if (flag9)
			{
				keyWords.Add(enchData.data.Localize("Name"));
				tempText = tempText + "<color=yellow>" + enchData.data.Localize("Name") + "</color>";
			}
			bool flag10 = transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>() != null;
			if (flag10)
			{
				transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().text = tempText;
			}
			bool flag11 = transform.GetComponent<KeywordDisplay>() == null;
			if (flag11)
			{
				transform.gameObject.AddComponent<KeywordDisplay>();
			}
			string tooltipText = "";
			tooltipText = string.Concat(new string[]
			{
				tooltipText,
				"<color=",
				Singleton<TempDataManager>.Instance.rareColorMap1[Singleton<TempDataManager>.Instance.RarityMap[dataConfig.data["Rarity"]]],
				">",
				"rarity".Localize("Glossary"),
				": ",
				Singleton<TempDataManager>.Instance.RarityMap[dataConfig.data["Rarity"]].Localize("Tips"),
				"</color>\n"
			});
			bool flag12 = dataConfig.data.ContainsKey("Expend");
			if (flag12)
			{
				tooltipText += ZString.Format<object, object>("<color=white>{0}: {1}</color>\n", "power".Localize("Glossary"), int.Parse(dataConfig.data["Expend"]) + exCost);
			}
			tooltipText = string.Concat(new string[]
			{
				tooltipText,
				"<color=white>",
				"effect".Localize("Glossary"),
				": ",
				tempText,
				"</color>\n"
			});
			Sprite iconSprite = ResourceLoader.Load<Sprite>(dataConfig.data["Icon"], true);
			bool flag13 = iconSprite == null;
			if (flag13)
			{
				iconSprite = ResourceLoader.Load<Sprite>("Icon/Card/卡面占位", true);
			}
			transform.GetComponent<KeywordDisplay>().SetText(data.Localize("Name"), tooltipText, keyWords, null, iconSprite, "card".Localize("Glossary"));
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00007F70 File Offset: 0x00006170
	public static void SetPureMsg(Transform transform, DataConfig dataConfig)
	{
		IDictionary<string, string> data = dataConfig.data;
		bool flag = transform.Find("Front/cost/cost").GetComponent<MeshRenderer>() != null;
		if (flag)
		{
			transform.Find("Front/cost/cost").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/Template/费用数字/" + data["Expend"], true);
		}
		else
		{
			bool flag2 = transform.Find("Front/cost/cost").GetComponent<Image>() != null;
			if (flag2)
			{
				transform.Find("Front/cost/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/Template/费用数字/" + data["Expend"], true);
			}
		}
		bool flag3 = transform.Find("Front/字体") == null;
		if (!flag3)
		{
			bool flag4 = transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>() != null;
			if (flag4)
			{
				transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().text = data.Localize("Name");
			}
			List<string> keyWords = new List<string>();
			bool flag5 = transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>() != null;
			if (flag5)
			{
				transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().text = dataConfig.Description().Highlight(keyWords);
			}
		}
	}
}

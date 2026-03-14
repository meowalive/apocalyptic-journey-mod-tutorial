using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000319 RID: 793
	public class DictItem : DictionaryItem, IPointerEnterHandler, IEventSystemHandler
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x000D024C File Offset: 0x000CE44C
		public override void Init(DataConfig dataConfig)
		{
			this.needSc = true;
			base.Init(dataConfig);
			ICard.SetCardStyle(base.transform, dataConfig);
			bool flag = this.itemIcon == null;
			if (flag)
			{
				this.itemIcon = ResourceLoader.Load<Sprite>("Icon/Card/卡面占位", true);
			}
			base.transform.Find("Front/字体").gameObject.SetActive(true);
			base.transform.Find("Front/background").GetComponent<Image>().color = new Color(1f, 1f, 1f);
			base.transform.Find("Front/icon").gameObject.SetActive(true);
			base.transform.GetComponent<Button>().onClick.RemoveAllListeners();
			base.transform.GetComponent<Button>().onClick.AddListener(delegate
			{
				this.dictionaryUI.ShowInfo(this);
				this.HideFloatingWindow();
			});
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000D0338 File Offset: 0x000CE538
		public override void OnPointerEnter(PointerEventData eventData)
		{
			base.OnPointerEnter(eventData);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000D0344 File Offset: 0x000CE544
		public void SetCardMsg(Transform newTransform)
		{
			IScriptExecutor scriptExecutor = this.dataConfig.scriptExecutor;
			IDictionary<string, string> data = this.dataConfig.data;
			bool flag = newTransform.Find("Front/cost/cost").GetComponent<MeshRenderer>() != null;
			if (flag)
			{
				newTransform.Find("Front/cost/cost").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/Template/费用数字/" + data["Expend"], true);
			}
			else
			{
				bool flag2 = newTransform.Find("Front/cost/cost").GetComponent<Image>() != null;
				if (flag2)
				{
					newTransform.Find("Front/cost/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/Template/费用数字/" + data["Expend"], true);
				}
			}
			bool flag3 = newTransform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>() != null;
			if (flag3)
			{
				newTransform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().text = data.Localize("Name");
			}
			bool flag4 = this.needSc;
			if (flag4)
			{
				bool flag5 = FightManager.Instance != null && FightPlayer.Instance != null && FightPlayer.Instance.Status != null;
				if (flag5)
				{
					scriptExecutor.Self = FightPlayer.Instance.Status;
				}
				else
				{
					scriptExecutor.Self = null;
				}
				this.needSc = false;
				scriptExecutor.RunScript("InitScript");
			}
			bool flag6 = newTransform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>() != null;
			if (flag6)
			{
				newTransform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().text = base.itemDescription;
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000D04F4 File Offset: 0x000CE6F4
		public override void DataUpdate()
		{
			bool flag = this.dataConfig == null || !base.gameObject.activeSelf;
			if (!flag)
			{
				base.itemName = this.dataConfig.data.Localize("Name");
				base.itemDescription = this.dataConfig.Description().Highlight(this.keywords);
				base.itemTip = this.dataConfig.data.Localize("Tips");
				this.keywordDisplay.text = this.CreateTooltipText();
				this.keywordDisplay.title = base.itemName;
				this.keywordDisplay.keyWords = this.keywords;
				bool flag2 = !this.dataConfig.data.ContainsKey("Rarity");
				if (flag2)
				{
					Debug.Log("物品" + base.itemName + "缺少Rarity字段，已设置为默认值0");
				}
				this.keywordDisplay.icon = ResourceLoader.Load<Sprite>("Icon/Item/Rarity" + this.dataConfig.data["Rarity"], true);
				this.SetCardMsg(base.transform);
			}
		}

		// Token: 0x0400134F RID: 4943
		private bool needSc = true;
	}
}

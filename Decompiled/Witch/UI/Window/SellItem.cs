using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000369 RID: 873
	public class SellItem : Item
	{
		// Token: 0x06001B77 RID: 7031 RVA: 0x000EA6FC File Offset: 0x000E88FC
		public void Init(bool equipped, DataConfig dataConfig = null)
		{
			this.ifEquipped = equipped;
			bool flag = dataConfig != null;
			if (flag)
			{
				base.Init(dataConfig);
			}
			base.transform.Find("Cost").GetComponent<TMP_Text>().text = dataConfig.data["Expend"];
			base.transform.Find("Name").GetComponent<TMP_Text>().text = dataConfig.data.Localize("Name");
			Sprite IconSprite = ResourceLoader.Load<Sprite>(dataConfig.data["Icon"], true);
			bool flag2 = IconSprite == null;
			if (flag2)
			{
				IconSprite = ResourceLoader.Load<Sprite>("Icon/Card/卡面占位", true);
			}
			this.CheckEnch();
			base.transform.Find("Mask/CardIcon").GetComponent<Image>().sprite = IconSprite;
			this.keywordDisplay.icon = ResourceLoader.Load<Sprite>("Icon/Item/Rarity" + dataConfig.data["Rarity"], true);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000EA7F8 File Offset: 0x000E89F8
		public void CheckEnch()
		{
			bool flag = RoleTable.Instance.enchasedDict.ContainsKey(this.dataConfig.InstanceID);
			if (flag)
			{
				DataConfig enchData = RoleTable.Instance.enchasedDict[this.dataConfig.InstanceID];
				Sprite enchIcon = ResourceLoader.Load<Sprite>(enchData.data["Icon"], true);
				bool flag2 = enchIcon != null;
				if (flag2)
				{
					base.transform.Find("Ench").gameObject.SetActive(true);
					base.transform.Find("Ench").GetComponent<Image>().sprite = enchIcon;
				}
				this.DataUpdate();
			}
			else
			{
				base.transform.Find("Ench").gameObject.SetActive(false);
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x000EA8C8 File Offset: 0x000E8AC8
		public bool CanSell()
		{
			bool flag = RoleTable.Instance.cardList.Contains(this.dataConfig);
			if (flag)
			{
				this.ifEquipped = true;
			}
			else
			{
				this.ifEquipped = false;
			}
			bool flag2 = this.ifEquipped && RoleTable.Instance.cardList.Count <= RoleTable.Instance.CardBottomCount;
			return !flag2;
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000EA93C File Offset: 0x000E8B3C
		public void TrySell()
		{
			bool flag = this.CanSell();
			if (flag)
			{
				RoleTable.Instance.cardList.Remove(this.dataConfig);
				RoleTable.Instance.UnCardList.Remove(this.dataConfig);
				RoleTable.Instance.Money += 30;
				Singleton<ObjectPool>.Instance.Release(base.gameObject);
			}
			else
			{
				UIManager.Instance.ShowModalWindow("Shop", "The number of cards has reached the lower limit", delegate
				{
				}, 0f, null, true, true, "Yes", "No", true);
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000EA9FC File Offset: 0x000E8BFC
		public override void OnPointerClick(PointerEventData eventData)
		{
			bool flag = eventData.button == PointerEventData.InputButton.Right;
			if (flag)
			{
				this.ShowFloatingWindow();
			}
			bool flag2 = eventData.button == PointerEventData.InputButton.Left;
			if (flag2)
			{
				this.HideFloatingWindow();
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000EAA38 File Offset: 0x000E8C38
		public override void ShowFloatingWindow()
		{
			this.floatingWindow.Clear();
			bool flag = this.CanSell();
			if (flag)
			{
				this.floatingWindow.AddButton("sell".Localize("Button") + ((int)(30f * RoleTable.Instance.MoneyCal)).ToString(), delegate()
				{
					this.TrySell();
					this.HideFloatingWindow();
				}, null);
			}
			else
			{
				this.floatingWindow.AddButton("<color=red>" + "sell".Localize("Button") + ((int)(30f * RoleTable.Instance.MoneyCal)).ToString() + "</color>", delegate()
				{
					this.TrySell();
					this.HideFloatingWindow();
				}, null);
			}
			base.ShowFloatingWindow();
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000EAB00 File Offset: 0x000E8D00
		public override void DataUpdate()
		{
			bool flag = this.dataConfig == null || this.dataConfig.data == null;
			if (!flag)
			{
				base.itemName = this.dataConfig.data.Localize("Name");
				base.itemDescription = this.dataConfig.Description().Highlight(this.keywords);
				base.itemTip = this.dataConfig.data.Localize("Tips");
				base.transform.Find("Name").GetComponent<TMP_Text>().text = base.itemName;
				string tempText = this.CreateTooltipText();
				DataConfig enchData = RoleTable.Instance.enchasedDict.ContainsKey(this.dataConfig.InstanceID) ? RoleTable.Instance.enchasedDict[this.dataConfig.InstanceID] : null;
				bool flag2 = enchData != null;
				if (flag2)
				{
					this.keywords.Add(enchData.data.Localize("Name"));
					tempText = tempText + "<color=yellow>" + enchData.data.Localize("Name") + "</color>";
				}
				this.keywordDisplay.text = tempText;
				this.keywordDisplay.title = base.itemName;
				this.keywordDisplay.keyWords = this.keywords;
				this.keywordDisplay.msg = base.itemTip;
				this.keywordDisplay.type = null;
				this.keywordDisplay.icon = ResourceLoader.Load<Sprite>("Icon/Item/Rarity" + this.dataConfig.data["Rarity"], true);
				this.Rarity = this.dataConfig.data.GetValueOrDefault("Rarity", null);
				bool flag3 = !string.IsNullOrEmpty(this.Rarity);
				if (flag3)
				{
					this.rareLevel = Singleton<TempDataManager>.Instance.RarityMap[this.dataConfig.data["Rarity"]].Localize("Tips");
				}
			}
		}

		// Token: 0x040014B6 RID: 5302
		public ShopUI shop;
	}
}

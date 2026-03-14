using System;
using Network.Command;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000370 RID: 880
	public class WarehouseItem : Item
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x000ED988 File Offset: 0x000EBB88
		public void Init(bool isware, bool equipped, DataConfig dataConfig = null)
		{
			this.Inwarehouse = isware;
			this.ifEquipped = equipped;
			bool flag = dataConfig != null;
			if (flag)
			{
				base.Init(dataConfig);
			}
			bool flag2 = this.ItemType == "Card";
			if (flag2)
			{
				ICard.SetCardStyle(base.transform.Find("CardItem"), dataConfig);
				base.transform.Find("Item").gameObject.SetActive(false);
				base.transform.Find("CardItem").gameObject.SetActive(true);
			}
			else
			{
				base.transform.Find("Item").gameObject.SetActive(true);
				base.transform.Find("CardItem").gameObject.SetActive(false);
			}
			this.DataUpdate();
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000EDA60 File Offset: 0x000EBC60
		public override void DataUpdate()
		{
			base.DataUpdate();
			bool flag = this.ItemType == "Card";
			if (flag)
			{
				ICard.SetCardMsg(base.transform.Find("CardItem"), this.dataConfig, null);
				base.transform.Find("cost/Background/Title").GetComponent<TMP_Text>().text = "Expend:".Localize("ShopUI") + this.dataConfig.data["Expend"];
				base.transform.Find("Des").GetComponent<TMP_Text>().text = base.itemDescription;
			}
			bool flag2 = this.ItemType == "Relic";
			if (flag2)
			{
				base.transform.Find("cost/Background/Title").GetComponent<TMP_Text>().text = "RELIC".Localize("ShopUI");
				base.transform.Find("Des").GetComponent<TMP_Text>().text = base.itemDescription.Replace("\n", "");
				base.transform.Find("Item/Normal/Icon").GetComponent<Image>().sprite = this.itemIcon;
				base.transform.Find("Item/Highlight/Icon").GetComponent<Image>().sprite = this.itemIcon;
			}
			base.transform.Find("rarity/Background/Title").GetComponent<TMP_Text>().text = "Rarity:".Localize("ShopUI") + this.Rarity;
			base.transform.Find("name/Background/Title").GetComponent<TMP_Text>().text = "【" + base.itemName + "】";
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000EDC2C File Offset: 0x000EBE2C
		public void TryMove()
		{
			bool flag = PlayerManager.Instance == null;
			if (!flag)
			{
				bool inwarehouse = this.Inwarehouse;
				if (inwarehouse)
				{
					bool flag2 = this.ItemType == "Card" && RoleTable.Instance.UnCardList.Count < RoleTable.Instance.MaxAlCardCount;
					if (flag2)
					{
						bool flag3 = !this.warehouseUI.MoveCheck("Card", true);
						if (flag3)
						{
							UIManager.Instance.ShowModalWindow("Shop", "This resting place cannot obtain more cards.", null, 0f, null, true, true, "Yes", "No", true);
							return;
						}
						PlayerManager.Instance.SendRpcCommand(new RpcGetItem("Card", this.dataConfig, PlayerManager.Instance.PlayerId));
					}
					else
					{
						bool flag4 = this.ItemType == "Relic";
						if (!flag4)
						{
							UIManager.Instance.ShowModalWindow("Shop", "The number of cards has reached the upper limit", null, 0f, null, true, true, "Yes", "No", true);
							return;
						}
						bool flag5 = !this.warehouseUI.MoveCheck("Relic", true);
						if (flag5)
						{
							UIManager.Instance.ShowModalWindow("Shop", "This resting place cannot obtain more relics.", null, 0f, null, true, true, "Yes", "No", true);
							return;
						}
						PlayerManager.Instance.SendRpcCommand(new RpcGetItem("Relic", this.dataConfig, PlayerManager.Instance.PlayerId));
					}
				}
				else
				{
					bool flag6 = this.ItemType == "Card" && ((this.ifEquipped && RoleTable.Instance.cardList.Count > RoleTable.Instance.CardBottomCount) || !this.ifEquipped);
					if (flag6)
					{
						bool flag7 = !this.warehouseUI.MoveCheck("Card", false);
						if (flag7)
						{
							UIManager.Instance.ShowModalWindow("Shop", "This resting place cannot send out more cards.", null, 0f, null, true, true, "Yes", "No", true);
							return;
						}
						RoleTable.Instance.cardList.Remove(this.dataConfig);
						RoleTable.Instance.UnCardList.Remove(this.dataConfig);
						PlayerManager.Instance.SendRpcCommand(new RpcSendItem("Card", this.dataConfig));
					}
					else
					{
						bool flag8 = this.ItemType == "Relic";
						if (!flag8)
						{
							UIManager.Instance.ShowModalWindow("Shop", "The number of cards has reached the lower limit", null, 0f, null, true, true, "Yes", "No", true);
							return;
						}
						bool flag9 = !this.warehouseUI.MoveCheck("Relic", false);
						if (flag9)
						{
							UIManager.Instance.ShowModalWindow("Shop", "This resting place cannot send out more relics.", null, 0f, null, true, true, "Yes", "No", true);
							return;
						}
						RoleTable.Instance.relicList.Remove(this.dataConfig);
						RoleTable.Instance.WithoutArmedRelicList.Remove(this.dataConfig);
						PlayerManager.Instance.SendRpcCommand(new RpcSendItem("Relic", this.dataConfig));
					}
				}
				this.Inwarehouse = !this.Inwarehouse;
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x040014D7 RID: 5335
		public bool Inwarehouse;

		// Token: 0x040014D8 RID: 5336
		public WarehouseUI warehouseUI;
	}
}

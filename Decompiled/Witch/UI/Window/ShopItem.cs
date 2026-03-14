using System;
using System.Collections.Generic;
using Data.Save;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200036B RID: 875
	public class ShopItem : ItemNonDrag
	{
		// Token: 0x06001B89 RID: 7049 RVA: 0x000EAD30 File Offset: 0x000E8F30
		public override void Init(DataConfig dataConfig = null)
		{
			bool flag = dataConfig != null;
			if (flag)
			{
				base.Init(dataConfig);
			}
			this.dice = MapManager.Instance.NowDice;
			this.canUpdate = true;
			bool flag2 = this.ItemType == "Card";
			if (flag2)
			{
				ICard.SetCardStyle(base.transform.Find("CardItem"), dataConfig);
			}
			this.DataUpdate();
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000EAD9C File Offset: 0x000E8F9C
		public void Init()
		{
			this.keywordDisplay.title = "BLESS".Localize("ShopUI");
			this.keywordDisplay.text = "Buy random blessings".Localize("ShopUI");
			this.keywordDisplay.icon = ResourceLoader.Load<Sprite>("Icon/Item/Rarity3", true);
			this.canUpdate = true;
			this.DataUpdate();
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000EAE04 File Offset: 0x000E9004
		public override void DataUpdate()
		{
			bool flag = !this.canUpdate;
			if (!flag)
			{
				bool flag2 = this.ItemType != "RandomBlessing";
				if (flag2)
				{
					base.DataUpdate();
					bool flag3 = this.ItemType == "EnchTag";
					if (flag3)
					{
						base.itemDescription = this.dataConfig.Description().Highlight(this.keywords);
					}
					this.keywordDisplay.text = this.CreateTooltipText();
					for (int i = 1; i <= Math.Min(int.Parse(this.dataConfig.data["Rarity"]), 3); i++)
					{
						base.transform.Find("Item/RarityList/" + i.ToString()).gameObject.SetActive(true);
					}
					for (int j = int.Parse(this.dataConfig.data["Rarity"]) + 1; j <= 3; j++)
					{
						base.transform.Find("Item/RarityList/" + j.ToString()).gameObject.SetActive(false);
					}
				}
				else
				{
					for (int k = 1; k <= 3; k++)
					{
						base.transform.Find("Item/RarityList/" + k.ToString()).gameObject.SetActive(true);
					}
				}
				bool flag4 = this.ItemType == "Card";
				if (flag4)
				{
					this.keywordDisplay.enabled = false;
					this.keywordDisplay.icon = null;
					ICard.SetCardMsg(base.transform.Find("CardItem"), this.dataConfig, null);
					base.transform.Find("Item").gameObject.SetActive(false);
					base.transform.Find("CardItem").gameObject.SetActive(true);
				}
				else
				{
					base.transform.Find("Item").gameObject.SetActive(true);
					base.transform.Find("CardItem").gameObject.SetActive(false);
					base.transform.Find("Item/Des").GetComponent<TMP_Text>().text = base.itemDescription;
				}
				bool flag5 = this.ItemType == "Relic" || this.ItemType == "Bless" || this.ItemType == "EnchTag";
				if (flag5)
				{
					base.transform.Find("Item/Normal/Icon").GetComponent<Image>().sprite = this.itemIcon;
					base.transform.Find("Item/Highlight/Icon").GetComponent<Image>().sprite = this.itemIcon;
				}
				bool flag6 = this.ItemType == "RandomBlessing";
				if (flag6)
				{
					base.transform.Find("Item/name/Title").GetComponent<TMP_Text>().text = "RandomBlessing".Localize("ShopUI");
				}
				else
				{
					bool flag7 = this.ItemType != "Card";
					if (flag7)
					{
						base.transform.Find("Item/name/Title").GetComponent<TMP_Text>().text = base.itemName;
					}
				}
				this.itemPrice = this.PriceCalculate();
				bool inHighTide = RoleTable.Instance.InHighTide;
				if (inHighTide)
				{
					this.itemPrice = this.itemPrice * 6 / 5;
				}
				this.UpdateItem();
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000EB1A4 File Offset: 0x000E93A4
		public void TryBuy()
		{
			bool flag = RoleTable.Instance.Money >= this.itemPrice;
			if (flag)
			{
				bool flag2 = this.ItemType == "Card";
				if (flag2)
				{
					bool flag3 = RoleTable.Instance.UnCardList.Count < RoleTable.Instance.MaxAlCardCount;
					if (!flag3)
					{
						UIManager.Instance.ShowModalWindow("Tips", "你的卡牌数量已达上限", delegate
						{
							bool flag11 = UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI") != null;
							if (flag11)
							{
								UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI").SetRole(new OutDeckUIData(RoleTable.Instance));
							}
							UIManager.Instance.ShowUI<OutDeckUI>("OutDeckUI", true);
						}, 0f, null, true, true, "Yes", "No", true);
						return;
					}
					bool isNative = this.dataConfig.IsNative;
					if (isNative)
					{
						GameSaveAnalyser.Instance.TryPush(this.dataConfig.data["Name"], OperObj.Cards, OperType.Buy);
					}
					RoleTable.Instance.UnCardList.Add(this.dataConfig);
				}
				else
				{
					bool flag4 = this.ItemType == "Relic";
					if (flag4)
					{
						bool flag5 = ShopItem.firstBuy && RoleTable.Instance.relicList.Count >= 6;
						if (flag5)
						{
							ShopItem.firstBuy = false;
							UIManager.Instance.ShowModalWindow("Tips", "You have reached the maximum number of relics. If you purchase more, they will be automatically stored in the warehouse. Do you want to buy it?".Localize("ShopUI"), delegate
							{
								this.TryBuy();
							}, 0f, null, true, true, "Yes", "No", true);
							return;
						}
						GameSaveAnalyser.Instance.TryPush(this.dataConfig.data["Name"], OperObj.Relics, OperType.Buy);
						RoleTable.Instance.WithoutArmedRelicList.Add(this.dataConfig);
					}
					else
					{
						bool flag6 = this.ItemType == "Bless";
						if (flag6)
						{
							GameSaveAnalyser.Instance.TryPush(this.dataConfig.data["Name"], OperObj.Blessings, OperType.Buy);
							RoleTable.Instance.blessingConfigs.Add(this.dataConfig);
						}
						else
						{
							bool flag7 = this.ItemType == "RandomBlessing";
							if (flag7)
							{
								UIManager.Instance.GetUI<DestinyTreeUI>("DestinyTreeUI").Divination();
							}
							else
							{
								bool flag8 = this.ItemType == "EnchTag";
								if (flag8)
								{
									bool flag9 = UIManager.Instance.GetUI<CardEnchUI>("CardEnchUI") != null;
									if (flag9)
									{
										UIManager.Instance.GetUI<CardEnchUI>("CardEnchUI").ShowCardToEnch(this);
									}
								}
							}
						}
					}
				}
				RoleTable.Instance.Money -= this.itemPrice;
				bool flag10 = this.ItemType != "RandomBlessing";
				if (flag10)
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
				else
				{
					this.itemPrice = UIManager.Instance.GetUI<DestinyTreeUI>("DestinyTreeUI").Cost;
					base.transform.Find("val/Normal/Title").GetComponent<TextMeshProUGUI>().text = (this.itemPrice.ToString() ?? "");
					base.transform.Find("val/Hlight/Title").GetComponent<TextMeshProUGUI>().text = (this.itemPrice.ToString() ?? "");
				}
			}
		}

		/// <summary>
		/// 按照权值生成价格，并随机生成浮动
		/// </summary>
		/// <returns></returns>
		// Token: 0x06001B93 RID: 7059 RVA: 0x000EB500 File Offset: 0x000E9700
		private int PriceCalculate()
		{
			int price = 0;
			bool flag = this.ItemType == "Relic";
			if (flag)
			{
				price = 150;
			}
			else
			{
				bool flag2 = this.ItemType == "Card";
				if (flag2)
				{
					price = 50;
				}
				else
				{
					bool flag3 = this.ItemType == "EnchTag";
					if (flag3)
					{
						price = 60;
					}
					else
					{
						bool flag4 = this.ItemType == "Bless";
						if (flag4)
						{
							return 20 * int.Parse(this.dataConfig.data["Weight"]) - 10;
						}
						bool flag5 = this.ItemType == "RandomBlessing";
						if (flag5)
						{
							return price;
						}
					}
				}
			}
			List<float> priceRate = new List<float>
			{
				1f,
				1.3f,
				1.6f,
				3.5f,
				4.5f,
				6f,
				8f,
				10f
			};
			string text = this.dataConfig.data["Rarity"];
			int rare = (text == null || text == "") ? 1 : int.Parse(this.dataConfig.data["Rarity"]);
			price = (int)((float)price * priceRate[rare]);
			price = (int)((float)(price * GameSaveManager.GetValue<int>(GameVar.PriceMul)) / 100f);
			return price + this.dice.WithRange(-rare * 5, rare * 5).Roll().Value;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000EB6BC File Offset: 0x000E98BC
		public void UpdateItem()
		{
			bool flag = this.itemPrice > RoleTable.Instance.Money;
			if (flag)
			{
				base.transform.Find("val/Normal/Title").GetComponent<TextMeshProUGUI>().text = "<color=red>" + this.itemPrice.ToString() + "</color>";
				base.transform.Find("val/Hlight/Title").GetComponent<TextMeshProUGUI>().text = "<color=red>" + this.itemPrice.ToString() + "</color>";
			}
			else
			{
				base.transform.Find("val/Normal/Title").GetComponent<TextMeshProUGUI>().text = this.itemPrice.ToString();
				base.transform.Find("val/Hlight/Title").GetComponent<TextMeshProUGUI>().text = this.itemPrice.ToString();
			}
		}

		// Token: 0x040014B9 RID: 5305
		public ShopUI shop;

		// Token: 0x040014BA RID: 5306
		public Dice dice;

		// Token: 0x040014BB RID: 5307
		private bool canUpdate = false;

		// Token: 0x040014BC RID: 5308
		private static bool firstBuy = true;
	}
}

using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Data.Save;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000324 RID: 804
	public class ShowCard : Item
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x000D20B9 File Offset: 0x000D02B9
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x000D26F0 File Offset: 0x000D08F0
		private new bool ifEquipped
		{
			get
			{
				return this.ifEquipped;
			}
			set
			{
				bool flag = this.ifEquipped == value;
				if (!flag)
				{
					this.ifEquipped = value;
					bool flag2 = !base.gameObject.activeSelf;
					if (!flag2)
					{
						bool flag3 = !this.ifEquipped;
						if (flag3)
						{
							bool flag4 = !RoleTable.Instance.cardList.Contains(this.dataConfig);
							if (!flag4)
							{
								AudioManager instance = AudioManager.Instance;
								if (instance != null)
								{
									instance.PlayEffect("NewSounds/卡牌与事件/取出卡牌");
								}
								RoleTable.Instance.cardList.Remove(this.dataConfig);
								RoleTable.Instance.UnCardList.Add(this.dataConfig);
							}
						}
						else
						{
							bool flag5 = !RoleTable.Instance.UnCardList.Contains(this.dataConfig);
							if (!flag5)
							{
								AudioManager instance2 = AudioManager.Instance;
								if (instance2 != null)
								{
									instance2.PlayEffect("NewSounds/卡牌与事件/置入卡牌");
								}
								RoleTable.Instance.UnCardList.Remove(this.dataConfig);
								RoleTable.Instance.cardList.Add(this.dataConfig);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000D2808 File Offset: 0x000D0A08
		public void Init(DataConfig dataConfig, bool ifequipped, bool fromSelf)
		{
			this.ifEquipped = ifequipped;
			this.fromSelf = fromSelf;
			this.ItemType = "Card";
			base.Init(dataConfig);
			this.DestroyCost = 20 + GameSaveManager.GetValue<int>(GameVar.ExpensiveCard);
			this.AddToParent();
			bool flag = !ifequipped;
			if (flag)
			{
				ICard.SetCardStyle(base.transform, dataConfig);
			}
			else
			{
				base.transform.Find("Cost").GetComponent<TMP_Text>().text = dataConfig.data["Expend"];
				base.transform.Find("Name").GetComponent<TMP_Text>().text = dataConfig.data.Localize("Name");
				Sprite IconSprite = ResourceLoader.Load<Sprite>(dataConfig.data["Icon"], true);
				bool flag2 = IconSprite == null;
				if (flag2)
				{
					IconSprite = ResourceLoader.Load<Sprite>("Icon/Card/卡面占位", true);
				}
				this.itemIcon = IconSprite;
				bool flag3 = RoleTable.Instance.enchasedDict.ContainsKey(dataConfig.InstanceID);
				if (flag3)
				{
					DataConfig enchData = RoleTable.Instance.enchasedDict[dataConfig.InstanceID];
					Sprite enchIcon = ResourceLoader.Load<Sprite>(enchData.data["Icon"], true);
					bool flag4 = enchIcon != null;
					if (flag4)
					{
						base.transform.Find("Ench").gameObject.SetActive(true);
						base.transform.Find("Ench").GetComponent<Image>().sprite = enchIcon;
					}
				}
				else
				{
					base.transform.Find("Ench").gameObject.SetActive(false);
				}
				base.transform.Find("Mask/CardIcon").GetComponent<Image>().sprite = IconSprite;
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000D01E3 File Offset: 0x000CE3E3
		private void OnEnable()
		{
			this.DataUpdate();
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000D29CC File Offset: 0x000D0BCC
		public override void DataUpdate()
		{
			bool flag = this.dataConfig == null;
			if (!flag)
			{
				bool flag2 = FightManager.Instance != null && FightManager.Instance.fightType == FightType.None;
				if (flag2)
				{
					this.dataConfig.scriptExecutor.Self = null;
				}
				base.itemDescription = this.dataConfig.Description().Highlight(this.keyWords);
				bool flag3 = !this.ifEquipped;
				if (flag3)
				{
					ICard.SetCardMsg(base.transform, this.dataConfig, null);
				}
				else
				{
					string tooltipText = "";
					tooltipText = string.Concat(new string[]
					{
						tooltipText,
						"<color=",
						Singleton<TempDataManager>.Instance.rareColorMap1[Singleton<TempDataManager>.Instance.RarityMap[this.dataConfig.data["Rarity"]]],
						">",
						"rarity".Localize("Glossary"),
						": ",
						Singleton<TempDataManager>.Instance.RarityMap[this.dataConfig.data["Rarity"]].Localize("Tips"),
						"</color>\n"
					});
					bool flag4 = this.dataConfig.data.ContainsKey("Expend");
					if (flag4)
					{
						tooltipText = string.Concat(new string[]
						{
							tooltipText,
							"<color=white>",
							"power".Localize("Glossary"),
							": ",
							this.dataConfig.data["Expend"],
							"</color>\n"
						});
					}
					tooltipText = string.Concat(new string[]
					{
						tooltipText,
						"<color=white>",
						"effect".Localize("Glossary"),
						": ",
						base.itemDescription,
						"</color>\n"
					});
					bool flag5 = RoleTable.Instance != null;
					if (flag5)
					{
						DataConfig enchData = RoleTable.Instance.enchasedDict.GetValueOrDefault(this.dataConfig.InstanceID, null);
						bool flag6 = enchData != null;
						if (flag6)
						{
							this.keyWords.Add(enchData.data.Localize("Name"));
							tooltipText = tooltipText + "<color=yellow>" + enchData.data.Localize("Name") + "</color>";
						}
					}
					base.transform.GetComponent<KeywordDisplay>().SetText(this.dataConfig.data.Localize("Name"), tooltipText, this.keyWords, null, this.keywordDisplay.icon = ResourceLoader.Load<Sprite>("Icon/Item/Rarity" + this.dataConfig.data["Rarity"], true), this.ItemType.Localize("Glossary"));
				}
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000D2CB8 File Offset: 0x000D0EB8
		public void MoveItem()
		{
			bool flag = this.ifEquipped && RoleTable.Instance.UnCardList.Count < RoleTable.Instance.MaxAlCardCount && RoleTable.Instance.cardList.Count > RoleTable.Instance.CardBottomCount;
			if (flag)
			{
				base.AddToList(this.cardShowUI.unequipCardTransform.parent.parent);
			}
			else
			{
				bool flag2 = !this.ifEquipped && RoleTable.Instance.cardList.Count < RoleTable.Instance.CardTopCount;
				if (flag2)
				{
					base.AddToList(this.cardShowUI.equipCardTransform.parent.parent);
				}
				else
				{
					bool flag3 = this.ifEquipped && RoleTable.Instance.cardList.Count <= RoleTable.Instance.CardBottomCount;
					if (flag3)
					{
						UIManager.Instance.ShowModalWindow("Tips", "The number of cards has reached the lower limit", null, 0f, null, true, true, "Yes", "No", true);
					}
					else
					{
						UIManager.Instance.ShowModalWindow("Tips", "The number of cards has reached the upper limit", null, 0f, null, true, true, "Yes", "No", true);
					}
				}
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x000D2E04 File Offset: 0x000D1004
		public override void ShowFloatingWindow()
		{
			bool flag = !this.fromSelf;
			if (!flag)
			{
				this.floatingWindow.Clear();
				this.floatingWindow.AddButton("move", delegate()
				{
					this.MoveItem();
					this.HideFloatingWindow();
				}, null);
				bool flag2 = UIManager.Instance.GetUI<ShopUI>("ShopUI") != null || UIManager.Instance.GetUI<DestinyTreeUI>("DestinyTreeUI") || UIManager.Instance.GetUI<CardEnchUI>("CardEnchUI");
				if (flag2)
				{
					this.floatingWindow.AddButton("sell".Localize("Button") + ((int)(30f * RoleTable.Instance.MoneyCal)).ToString(), delegate()
					{
						this.SellItem();
						this.HideFloatingWindow();
					}, null);
				}
				else
				{
					this.floatingWindow.AddButton("Destroy".Localize("Button") + ZString.Format<object>("(-{0})", this.DestroyCost), delegate()
					{
						this.DecomposeItem();
						this.HideFloatingWindow();
					}, null);
				}
				base.ShowFloatingWindow();
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000D2F2C File Offset: 0x000D112C
		public override void OnBeginDrag(PointerEventData eventData)
		{
			bool flag = !this.fromSelf;
			if (!flag)
			{
				base.OnBeginDrag(eventData);
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000D2F54 File Offset: 0x000D1154
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

		// Token: 0x0600191C RID: 6428 RVA: 0x000D2F8E File Offset: 0x000D118E
		private void OnDisable()
		{
			this.HideFloatingWindow();
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000D2F98 File Offset: 0x000D1198
		public void DecomposeItem()
		{
			bool flag = RoleTable.Instance.Money < this.DestroyCost;
			if (flag)
			{
				UIManager.Instance.ShowModalWindow("Shop", "Currently, there are too few coins to break down cards", null, 0f, null, true, true, "Yes", "No", true);
			}
			else
			{
				bool flag2 = (this.ifEquipped && RoleTable.Instance.cardList.Count > RoleTable.Instance.CardBottomCount) || !this.ifEquipped;
				if (flag2)
				{
					bool flag3 = this.dataConfig.data["Type"] == "诅咒";
					if (flag3)
					{
						bool flag4 = RoleTable.Instance.VarsMap["Wisdom"] < this.DestroyCost;
						if (flag4)
						{
							UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("你目前还没有消除诅咒的能力", CaptionStyle.Top, 1f, 1.5f, 3);
							return;
						}
					}
					RoleTable.Instance.Money -= this.DestroyCost;
					this.ItemCheck();
				}
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000D30C4 File Offset: 0x000D12C4
		public override void OnDrag(PointerEventData eventData)
		{
			bool flag = !this.fromSelf || eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				base.gameObject.GetComponent<LayoutElement>().ignoreLayout = true;
				this.isDrag = true;
				base.transform.GetComponent<RectTransform>().localPosition = base.GetMousePos(eventData);
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x000D3124 File Offset: 0x000D1324
		public void ItemCheck()
		{
			bool ifEquipped = this.ifEquipped;
			if (ifEquipped)
			{
				RoleTable.Instance.cardList.Remove(this.dataConfig);
			}
			else
			{
				RoleTable.Instance.UnCardList.Remove(this.dataConfig);
			}
			bool isNative = this.dataConfig.IsNative;
			if (isNative)
			{
				GameSaveAnalyser.Instance.TryPush(this.dataConfig.data["Name"], OperObj.Cards, OperType.Delete);
			}
			Singleton<ObjectPool>.Instance.Release(base.gameObject);
			foreach (object obj in base.transform.parent)
			{
				Transform item = (Transform)obj;
				bool flag = item.name == "Null" && !item.gameObject.activeSelf && ((this.ifEquipped && RoleTable.Instance.cardList.Count < RoleTable.Instance.CardTopCount) || (!this.ifEquipped && RoleTable.Instance.UnCardList.Count < RoleTable.Instance.MaxAlCardCount));
				if (flag)
				{
					item.gameObject.SetActive(true);
					break;
				}
			}
			this.cardShowUI.ChangeCardShow();
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000D329C File Offset: 0x000D149C
		public void SellItem()
		{
			bool flag = (this.ifEquipped && RoleTable.Instance.cardList.Count > RoleTable.Instance.CardBottomCount) || !this.ifEquipped;
			if (flag)
			{
				bool flag2 = this.dataConfig.data["Type"] == "诅咒";
				if (flag2)
				{
					bool flag3 = RoleTable.Instance.VarsMap["Wisdom"] < 20;
					if (flag3)
					{
						UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("你目前还没有消除诅咒的能力", CaptionStyle.Top, 1f, 1.5f, 3);
						return;
					}
				}
				RoleTable.Instance.Money += 30;
				this.ItemCheck();
			}
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000D3370 File Offset: 0x000D1570
		public override void OnEndDrag(PointerEventData eventData)
		{
			bool flag = !this.fromSelf;
			if (!flag)
			{
				this.isDrag = false;
				PointerEventData pointerEventData = new PointerEventData(EventSystem.current)
				{
					position = KeyManager.playerAction.Main.Point.ReadValue<Vector2>()
				};
				List<RaycastResult> results = new List<RaycastResult>();
				EventSystem.current.RaycastAll(pointerEventData, results);
				SwapContentIdentity item = null;
				foreach (RaycastResult result in results)
				{
					item = result.gameObject.GetComponent<SwapContentIdentity>();
					bool flag2 = item != null && (!item.CheckType || item.ItemName == this.ItemType);
					if (flag2)
					{
						break;
					}
				}
				base.gameObject.GetComponent<LayoutElement>().ignoreLayout = false;
				bool flag3 = base.transform.GetComponent<Canvas>();
				if (flag3)
				{
					base.transform.GetComponent<Canvas>().overrideSorting = false;
					UnityEngine.Object.Destroy(base.transform.GetComponent<Canvas>());
				}
				base.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
				ScrollRect scrollRect = this.lastParent.GetComponentInParent<ScrollRect>();
				bool flag4 = scrollRect != null;
				if (flag4)
				{
					scrollRect.enabled = true;
				}
				else
				{
					bool flag5 = this.lastParent.GetComponentInParent<ScrollRectNonDrag>();
					if (flag5)
					{
						ScrollRectNonDrag scrollRectNonDrag = this.lastParent.GetComponentInParent<ScrollRectNonDrag>();
						scrollRectNonDrag.enabled = true;
					}
				}
				this.AddToList(item);
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000D3514 File Offset: 0x000D1714
		public override void AddToList(SwapContentIdentity content)
		{
			bool flag = content == null || content.transform == base.transform.parent.parent.parent;
			if (!flag)
			{
				bool flag2 = (!this.ifEquipped || RoleTable.Instance.UnCardList.Count >= RoleTable.Instance.MaxAlCardCount || RoleTable.Instance.cardList.Count <= RoleTable.Instance.CardBottomCount) && (this.ifEquipped || RoleTable.Instance.cardList.Count >= RoleTable.Instance.CardTopCount);
				if (flag2)
				{
					base.transform.localPosition = this.lastPos;
					base.GetComponent<CanvasGroup>().blocksRaycasts = true;
					bool flag3 = base.GetComponent<Canvas>();
					if (flag3)
					{
						base.GetComponent<Canvas>().overrideSorting = false;
						UnityEngine.Object.Destroy(base.GetComponent<Canvas>());
					}
					bool flag4 = this.ifEquipped && RoleTable.Instance.cardList.Count <= RoleTable.Instance.CardBottomCount;
					if (flag4)
					{
						UIManager.Instance.ShowModalWindow("Tips", "The number of cards has reached the lower limit", null, 0f, null, true, true, "Yes", "No", true);
					}
					else
					{
						UIManager.Instance.ShowModalWindow("Tips", "The number of cards has reached the upper limit", null, 0f, null, true, true, "Yes", "No", true);
					}
				}
				else
				{
					this.lastParent = base.transform.parent;
					this.isDrag = false;
					Transform nullItem = this.lastParent.GetChild(this.lastParent.childCount - 1);
					UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
					{
						bool flag7 = nullItem == null || nullItem.gameObject == null || nullItem.name != "Null";
						if (!flag7)
						{
							bool flag8 = (this.ifEquipped && RoleTable.Instance.cardList.Count < RoleTable.Instance.CardTopCount) || (!this.ifEquipped && RoleTable.Instance.UnCardList.Count < RoleTable.Instance.MaxAlCardCount);
							if (flag8)
							{
								nullItem.gameObject.SetActive(true);
								int index = nullItem.GetSiblingIndex();
								while (index > 0 && !nullItem.parent.GetChild(index - 1).gameObject.activeSelf)
								{
									index--;
								}
								nullItem.SetSiblingIndex(index);
							}
							bool flag9 = this != null && this.transform.parent != null;
							if (flag9)
							{
								this.lastParent = this.transform.parent;
							}
						}
					}).Forget();
					bool ifEquipped = this.ifEquipped;
					if (ifEquipped)
					{
						bool flag5 = !RoleTable.Instance.cardList.Contains(this.dataConfig);
						if (flag5)
						{
							return;
						}
						AudioManager instance = AudioManager.Instance;
						if (instance != null)
						{
							instance.PlayEffect("NewSounds/卡牌与事件/取出卡牌");
						}
						RoleTable.Instance.cardList.Remove(this.dataConfig);
						RoleTable.Instance.UnCardList.Add(this.dataConfig);
					}
					else
					{
						bool flag6 = !RoleTable.Instance.UnCardList.Contains(this.dataConfig);
						if (flag6)
						{
							return;
						}
						AudioManager instance2 = AudioManager.Instance;
						if (instance2 != null)
						{
							instance2.PlayEffect("NewSounds/卡牌与事件/置入卡牌");
						}
						RoleTable.Instance.UnCardList.Remove(this.dataConfig);
						RoleTable.Instance.cardList.Add(this.dataConfig);
					}
					this.cardShowUI.CreateItem(this.dataConfig, !this.ifEquipped);
					Singleton<ObjectPool>.Instance.Release(base.gameObject);
					this.cardShowUI.ChangeCardShow();
				}
			}
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000D381E File Offset: 0x000D1A1E
		public override void OnPointerEnter(PointerEventData eventData)
		{
			this.isHover = true;
			UniTask.ToCoroutine(delegate
			{
				ShowCard.<<OnPointerEnter>b__22_0>d <<OnPointerEnter>b__22_0>d = new ShowCard.<<OnPointerEnter>b__22_0>d();
				<<OnPointerEnter>b__22_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnPointerEnter>b__22_0>d.<>4__this = this;
				<<OnPointerEnter>b__22_0>d.<>1__state = -1;
				<<OnPointerEnter>b__22_0>d.<>t__builder.Start<ShowCard.<<OnPointerEnter>b__22_0>d>(ref <<OnPointerEnter>b__22_0>d);
				return <<OnPointerEnter>b__22_0>d.<>t__builder.Task;
			});
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000D383C File Offset: 0x000D1A3C
		public override void OnPointerExit(PointerEventData eventData)
		{
			bool isDrag = this.isDrag;
			if (!isDrag)
			{
				base.OnPointerExit(eventData);
			}
		}

		// Token: 0x04001373 RID: 4979
		public OutDeckUI cardShowUI;

		// Token: 0x04001374 RID: 4980
		public int DestroyCost = 20;

		// Token: 0x04001375 RID: 4981
		private bool fromSelf = true;

		// Token: 0x04001376 RID: 4982
		private List<string> keyWords = new List<string>();

		// Token: 0x04001377 RID: 4983
		private bool hasEnch = false;
	}
}

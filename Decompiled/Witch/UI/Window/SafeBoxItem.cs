using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000353 RID: 851
	public class SafeBoxItem : Item
	{
		// Token: 0x06001AA5 RID: 6821 RVA: 0x000E2730 File Offset: 0x000E0930
		public override void Init(DataConfig dataConfig)
		{
			base.Init(dataConfig);
			this.AddToParent();
			bool flag = this.ItemType == "Relic";
			if (flag)
			{
				this.normalCanvasGroup.transform.Find("Icon Parent/Icon").GetComponent<Image>().sprite = this.itemIcon;
				this.highlightCanvasGroup.transform.Find("Icon Parent/Icon").GetComponent<Image>().sprite = this.itemIcon;
			}
			else
			{
				ICard.SetCardStyle(base.transform, dataConfig);
			}
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x000E27C0 File Offset: 0x000E09C0
		public override void OnPointerEnter(PointerEventData eventData)
		{
			base.OnPointerEnter(eventData);
			bool flag = this.ItemType == "Relic";
			if (flag)
			{
				this.normalCanvasGroup.DOFade(0f, 0.2f);
				this.highlightCanvasGroup.DOFade(1f, 0.2f);
			}
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x000E2818 File Offset: 0x000E0A18
		public override void DataUpdate()
		{
			bool flag = this.dataConfig == null;
			if (!flag)
			{
				bool flag2 = this.ItemType != "Card";
				if (flag2)
				{
					base.DataUpdate();
				}
				else
				{
					this.dataConfig.scriptExecutor.Self = null;
					ICard.SetCardMsg(base.transform, this.dataConfig, null);
				}
			}
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000E287C File Offset: 0x000E0A7C
		public override string CreateTooltipText()
		{
			string tooltipText = "";
			bool flag = this.ItemType == "Card";
			string result;
			if (flag)
			{
				tooltipText = tooltipText + "<color=yellow><b>" + this.dataConfig.data.Localize("Name") + "</b></color>\n";
				tooltipText = string.Concat(new string[]
				{
					tooltipText,
					"<color=white>",
					"type".Localize("Glossary"),
					": ",
					"card".Localize("Glossary"),
					"</color>\n"
				});
				tooltipText = string.Concat(new string[]
				{
					tooltipText,
					"<color=white>",
					"power".Localize("Glossary"),
					": ",
					this.dataConfig.data["Expend"],
					"</color>\n"
				});
				tooltipText = string.Concat(new string[]
				{
					tooltipText,
					"<color=white>",
					"effect".Localize("Glossary"),
					": \n",
					this.dataConfig.Description().Highlight(this.keywords),
					"</color>\n"
				});
				result = tooltipText;
			}
			else
			{
				bool flag2 = this.ItemType == "Relic";
				if (flag2)
				{
					this.Rarity = Singleton<TempDataManager>.Instance.RarityMap[this.dataConfig.data["Rarity"]].Localize("Tips");
					this.color = Singleton<TempDataManager>.Instance.rareColorMap1[Singleton<TempDataManager>.Instance.RarityMap[this.dataConfig.data["Rarity"]]];
					tooltipText = tooltipText + "<color=yellow><b>" + this.dataConfig.data.Localize("Name") + "</b></color>\n";
					tooltipText = string.Concat(new string[]
					{
						tooltipText,
						"<color=white>",
						"type".Localize("Glossary"),
						": ",
						"relic".Localize("Glossary"),
						"</color>\n"
					});
					tooltipText = string.Concat(new string[]
					{
						tooltipText,
						"<color=",
						this.color,
						">",
						"rarity".Localize("Glossary"),
						": ",
						this.Rarity,
						"</color>\n"
					});
					tooltipText = string.Concat(new string[]
					{
						tooltipText,
						"<color=white>",
						"effect".Localize("Glossary"),
						": \n",
						this.dataConfig.Description().Highlight(this.keywords),
						"</color>\n"
					});
					result = tooltipText;
				}
				else
				{
					result = tooltipText;
				}
			}
			return result;
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x000E2B70 File Offset: 0x000E0D70
		public override void OnPointerClick(PointerEventData eventData)
		{
			bool flag = eventData.button == PointerEventData.InputButton.Right;
			if (flag)
			{
				this.safeBoxUI.ShowFloatingWindow(this);
			}
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x000D01ED File Offset: 0x000CE3ED
		public override void OnDestroy()
		{
			this.ClearEvent();
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000E2B9C File Offset: 0x000E0D9C
		public override void AddToList(SwapContentIdentity item)
		{
			bool flag = item == null || item.Content == base.transform.parent;
			if (flag)
			{
				base.transform.GetComponent<RectTransform>().localPosition = this.lastPos;
				base.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
			}
			else
			{
				bool flag2 = base.transform.GetComponent<CanvasGroup>();
				if (flag2)
				{
					base.transform.GetComponent<CanvasGroup>().blocksRaycasts = true;
				}
				Transform patent = base.transform.parent;
				bool flag3 = this.ItemType == "Relic" && ((item.name == "Scroll Area" && patent.parent.name == "ButtonScroll Area") || (patent.parent.name == "Scroll Area" && item.name == "ButtonScroll Area") || item.transform == patent.parent);
				if (flag3)
				{
					base.AddToList(item);
				}
				else
				{
					bool inBackPack = this.InBackPack;
					if (inBackPack)
					{
						this.safeBoxUI.PutIntoStore(base.gameObject);
					}
					else
					{
						this.safeBoxUI.PutItBack(base.gameObject);
					}
				}
				bool flag4 = patent == base.transform.parent;
				if (flag4)
				{
					base.transform.GetComponent<RectTransform>().localPosition = this.lastPos;
				}
			}
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x000E2D2C File Offset: 0x000E0F2C
		public override void OnTransformParentChanged()
		{
			bool flag = !base.gameObject.activeSelf || this.ItemType != "Relic";
			if (!flag)
			{
				this.RemoveFromParent();
				this.AddToParent();
				RoleTable.Instance.relicList.Remove(this.dataConfig);
				RoleTable.Instance.WithoutArmedRelicList.Remove(this.dataConfig);
				bool flag2 = base.transform.parent.parent.name == "Scroll Area";
				if (flag2)
				{
					this.ifEquipped = true;
					RoleTable.Instance.relicList.Add(this.dataConfig);
				}
				else
				{
					this.ifEquipped = false;
					bool flag3 = !base.transform.parent.parent.name.Contains("OutScroll Area");
					if (flag3)
					{
						RoleTable.Instance.WithoutArmedRelicList.Add(this.dataConfig);
					}
				}
				bool flag4 = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
				if (flag4)
				{
					UIManager.Instance.GetUI<TopBarUI>("TopBarUI").UpdateRelics();
				}
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000D1797 File Offset: 0x000CF997
		private void OnDisable()
		{
			this.floatingWindow.Hide();
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000E2E5C File Offset: 0x000E105C
		public override void OnPointerExit(PointerEventData eventData)
		{
			this.safeBoxUI.HideTooltip();
			bool flag = this.ItemType == "Relic";
			if (flag)
			{
				this.normalCanvasGroup.DOFade(1f, 0.2f);
				this.highlightCanvasGroup.DOFade(0f, 0.2f);
			}
		}

		// Token: 0x04001474 RID: 5236
		public SafeBoxUI safeBoxUI;

		// Token: 0x04001475 RID: 5237
		public bool InBackPack = true;

		// Token: 0x04001476 RID: 5238
		public bool hasInBack = false;

		// Token: 0x04001477 RID: 5239
		public Tooltip tooltip;

		// Token: 0x04001478 RID: 5240
		public CanvasGroup normalCanvasGroup;

		// Token: 0x04001479 RID: 5241
		public CanvasGroup highlightCanvasGroup;
	}
}

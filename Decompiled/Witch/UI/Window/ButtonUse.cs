using System;
using System.Collections.Generic;
using Michsky.MUIP;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x020002D2 RID: 722
	public class ButtonUse : MonoBehaviour
	{
		// Token: 0x0600164A RID: 5706 RVA: 0x000B4000 File Offset: 0x000B2200
		public void Awake()
		{
			Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
			this.DataUpdate();
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000B4040 File Offset: 0x000B2240
		public void ButtonUseSc()
		{
			int currentIndex = base.transform.GetSiblingIndex();
			bool flag = this.ItemType == "WindowsButton";
			if (flag)
			{
				this.dictionaryUI.nowIndex = currentIndex;
				this.dictionaryUI.SortingBydefault();
			}
			else
			{
				bool flag2 = this.ItemType == "RarityButton" || this.ItemType == "EnemyRarityButton";
				if (flag2)
				{
					this.dictionaryUI.TypeNowRarity[this.belongs] = (base.transform.GetSiblingIndex() + 1).ToString();
					this.dictionaryUI.SortingBydefault();
				}
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x000B40F0 File Offset: 0x000B22F0
		public void DataUpdate()
		{
			bool flag = this.ItemType == "WindowsButton";
			if (flag)
			{
				base.gameObject.GetComponent<ButtonManager>().SetText(ButtonUse.RarityDict[base.gameObject.name].Localize("Glossary"));
			}
			else
			{
				string rarity = "";
				bool flag2 = this.ItemType != "EnemyRarityButton";
				if (flag2)
				{
					rarity = Singleton<TempDataManager>.Instance.RarityMap[(base.transform.GetSiblingIndex() + 1).ToString()].Localize("Tips");
				}
				else
				{
					bool flag3 = this.ItemType == "EnemyRarityButton";
					if (flag3)
					{
						rarity = ButtonUse.RarityDict[(base.transform.GetSiblingIndex() + 1).ToString()].Localize("Dictionary");
					}
				}
				base.transform.Find("Normal/Text").GetComponent<TMP_Text>().text = (base.transform.Find("Highlighted/Text").GetComponent<TMP_Text>().text = (base.transform.Find("Pressed/Text").GetComponent<TMP_Text>().text = rarity));
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00004B9C File Offset: 0x00002D9C
		private void OnDestroy()
		{
			Singleton<EventCenter>.Instance.Clear(this);
		}

		// Token: 0x04001190 RID: 4496
		public DictionaryUI dictionaryUI;

		// Token: 0x04001191 RID: 4497
		public string ItemType = "WindowsButton";

		// Token: 0x04001192 RID: 4498
		public string belongs = "";

		// Token: 0x04001193 RID: 4499
		private static Dictionary<string, string> RarityDict = new Dictionary<string, string>
		{
			{
				"卡牌",
				"card"
			},
			{
				"遗物",
				"relic"
			},
			{
				"祝福",
				"bless"
			},
			{
				"敌人",
				"enemy"
			},
			{
				"1",
				"Common"
			},
			{
				"2",
				"Elite"
			},
			{
				"3",
				"Boss"
			}
		};
	}
}

using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200031B RID: 795
	public class EnchItem : Item
	{
		// Token: 0x060018C2 RID: 6338 RVA: 0x000D0934 File Offset: 0x000CEB34
		public override void Init(DataConfig dataConfig)
		{
			base.Init(dataConfig);
			Color backgroundColor = new Color(0f, 0f, 0f);
			backgroundColor = new Color(0.7137255f, 0.5254902f, 0.23529412f);
			base.transform.Find("Normal/background").GetComponent<Image>().color = backgroundColor;
			base.transform.Find("Highlight/background").GetComponent<Image>().color = backgroundColor;
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x000D09AE File Offset: 0x000CEBAE
		public override void OnPointerEnter(PointerEventData eventData)
		{
			this.isHover = true;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000D09B8 File Offset: 0x000CEBB8
		public override void OnPointerExit(PointerEventData eventData)
		{
			this.isHover = false;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000D09C4 File Offset: 0x000CEBC4
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

		// Token: 0x060018C6 RID: 6342 RVA: 0x000D0A00 File Offset: 0x000CEC00
		public override string CreateTooltipText()
		{
			return base.CreateTooltipText();
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000D0A1A File Offset: 0x000CEC1A
		public override void OnBeginDrag(PointerEventData eventData)
		{
			base.OnBeginDrag(eventData);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000D0A25 File Offset: 0x000CEC25
		public override void OnEndDrag(PointerEventData eventData)
		{
			this.InsertCard(eventData);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000D0A30 File Offset: 0x000CEC30
		public override void AddToParent()
		{
			bool flag = base.transform.parent == null;
			if (!flag)
			{
				Transform newNullItem = base.transform.parent.Find("Null");
				bool flag2 = newNullItem == null;
				if (!flag2)
				{
					base.transform.position = newNullItem.position;
					newNullItem.gameObject.SetActive(false);
					newNullItem.SetAsLastSibling();
				}
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000D0AA0 File Offset: 0x000CECA0
		public void InsertCard(PointerEventData eventData)
		{
			UnityEngine.Object.Destroy(base.transform.GetComponent<Canvas>());
			base.GetComponent<CanvasGroup>().blocksRaycasts = true;
			bool flag = eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				PointerEventData pointerEventData = new PointerEventData(EventSystem.current)
				{
					position = Mouse.current.position.ReadValue()
				};
				List<RaycastResult> results = new List<RaycastResult>();
				EventSystem.current.RaycastAll(pointerEventData, results);
				EnchCardItem item = null;
				foreach (RaycastResult result in results)
				{
					item = result.gameObject.GetComponent<EnchCardItem>();
					bool flag2 = item != null;
					if (flag2)
					{
						break;
					}
				}
				bool flag3 = item == null;
				if (flag3)
				{
					LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.parent.parent.GetComponent<RectTransform>());
				}
				else
				{
					bool flag4 = !this.dataConfig.data.ContainsKey("UseScript") && !this.dataConfig.data.ContainsKey("LoadScript") && !this.dataConfig.data.ContainsKey("DrawScript") && !this.dataConfig.data.ContainsKey("DropScript");
					if (flag4)
					{
						LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.parent.parent.GetComponent<RectTransform>());
						UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("该素材无法被镶嵌", CaptionStyle.Top, 1f, 1.5f, 3);
					}
					else
					{
						bool flag5 = RoleTable.Instance.enchasedDict.ContainsKey(item.dataConfig.InstanceID);
						if (flag5)
						{
							LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.parent.parent.GetComponent<RectTransform>());
							UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("该卡牌已经镶嵌过了", CaptionStyle.Top, 1f, 1.5f, 3);
						}
						else
						{
							RoleTable.Instance.enchasedDict.Add(item.dataConfig.InstanceID, this.dataConfig);
							item.dataConfig.data["LoadScript"] = this.dataConfig.data["LoadScript"];
							item.dataConfig.data["UnloadScript"] = this.dataConfig.data["UnloadScript"];
							bool flag6 = item.dataConfig.Vars.ContainsKey("SpecialTag");
							IDictionary<string, string> dictionary;
							if (flag6)
							{
								dictionary = item.dataConfig.Vars;
								dictionary["SpecialTag"] = dictionary["SpecialTag"] + "," + this.dataConfig.Vars["Tag"];
							}
							else
							{
								item.dataConfig.Vars.Add("SpecialTag", this.dataConfig.Vars["Tag"]);
							}
							dictionary = item.dataConfig.data;
							dictionary["Description"] = dictionary["Description"] + this.dataConfig.data["Description"];
							item.dataConfig.PreCompileScripts();
							item.dataConfig.scriptExecutor.RunScript("LoadScript");
							item.dataConfig.scriptExecutor.RunScript("InitScript");
							item.itemDescription = item.dataConfig.Description().Highlight(this.keywords);
							item.gameObject.GetComponent<KeywordDisplay>().text = item.CreateTooltipText();
							item.transform.Find("Front/icon/Ench").gameObject.SetActive(true);
							item.transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().text = item.itemDescription;
							Singleton<GameRuntimeData>.Instance.Save();
							UnityEngine.Object.Destroy(base.gameObject);
						}
					}
				}
			}
		}

		// Token: 0x04001354 RID: 4948
		public CardEnchUI CardEnchUI;
	}
}

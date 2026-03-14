using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200031D RID: 797
	public class Item : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ILocalize
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x000D11AB File Offset: 0x000CF3AB
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x000D11B3 File Offset: 0x000CF3B3
		public string itemName { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x000D11BC File Offset: 0x000CF3BC
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x000D11C4 File Offset: 0x000CF3C4
		public string itemDescription { get; set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x000D11CD File Offset: 0x000CF3CD
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x000D11D5 File Offset: 0x000CF3D5
		public string itemTip { get; set; }

		// Token: 0x060018D8 RID: 6360 RVA: 0x000D11E0 File Offset: 0x000CF3E0
		public virtual void Awake()
		{
			bool flag = this.keywordDisplay == null;
			if (flag)
			{
				this.keywordDisplay = base.gameObject.AddComponent<KeywordDisplay>();
			}
			this.lastParent = base.transform.parent;
			this.RegisterEvent();
			this.floatingWindow = UIManager.Instance.GetFloatingWindow();
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000D1238 File Offset: 0x000CF438
		public virtual void Init(DataConfig dataConfig)
		{
			bool flag = ((dataConfig != null) ? dataConfig.data : null) == null;
			if (!flag)
			{
				this.dataConfig = dataConfig;
				this.keywords = new List<string>();
				this.itemId = dataConfig.data.GetValueOrDefault("Id", "");
				this.ItemType = dataConfig.Type.ToString();
				this.itemName = dataConfig.data.Localize("Name");
				base.name = this.itemName;
				bool flag2 = dataConfig.data.ContainsKey("InitScript") && dataConfig.scriptExecutor != null;
				if (flag2)
				{
					dataConfig.scriptExecutor.RunScript("InitScript");
				}
				this.Rarity = dataConfig.data.GetValueOrDefault("Rarity", null);
				string rarityEntry;
				bool flag3;
				if (this.Rarity != null)
				{
					TempDataManager instance = Singleton<TempDataManager>.Instance;
					if (((instance != null) ? instance.RarityMap : null) != null)
					{
						flag3 = Singleton<TempDataManager>.Instance.RarityMap.TryGetValue(dataConfig.data["Rarity"], out rarityEntry);
						goto IL_10F;
					}
				}
				flag3 = false;
				IL_10F:
				bool flag4 = flag3;
				if (flag4)
				{
					this.rareLevel = rarityEntry.Localize("Tips");
					string c;
					bool flag5 = Singleton<TempDataManager>.Instance.rareColorMap1 != null && Singleton<TempDataManager>.Instance.rareColorMap1.TryGetValue(rarityEntry, out c);
					if (flag5)
					{
						this.color = c;
					}
				}
				this.itemIcon = ResourceLoader.Load<Sprite>(dataConfig.data.GetValueOrDefault("Icon", null), true);
				this.DataUpdate();
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000D13C0 File Offset: 0x000CF5C0
		public virtual void DataUpdate()
		{
			bool flag = this.dataConfig == null || this.dataConfig.data == null;
			if (!flag)
			{
				bool flag2 = this.keywordDisplay == null;
				if (!flag2)
				{
					this.itemName = this.dataConfig.data.Localize("Name");
					string text = this.dataConfig.Description();
					this.itemDescription = (((text != null) ? text.Highlight(this.keywords) : null) ?? "");
					this.itemTip = this.dataConfig.data.Localize("Tips");
					this.keywordDisplay.text = this.CreateTooltipText();
					this.keywordDisplay.title = this.itemName;
					this.keywordDisplay.keyWords = this.keywords;
					this.keywordDisplay.msg = this.itemTip;
					this.keywordDisplay.type = this.ItemType.Localize("Glossary");
					this.Rarity = this.dataConfig.data.GetValueOrDefault("Rarity", null);
					bool flag3 = !string.IsNullOrEmpty(this.Rarity);
					if (flag3)
					{
						this.keywordDisplay.icon = ResourceLoader.Load<Sprite>("Icon/Item/Rarity" + this.dataConfig.data["Rarity"], true);
						TempDataManager instance = Singleton<TempDataManager>.Instance;
						string rarityLoc;
						bool flag4 = ((instance != null) ? instance.RarityMap : null) != null && Singleton<TempDataManager>.Instance.RarityMap.TryGetValue(this.dataConfig.data["Rarity"], out rarityLoc);
						if (flag4)
						{
							this.rareLevel = rarityLoc.Localize("Tips");
						}
					}
					else
					{
						this.keywordDisplay.icon = this.itemIcon;
					}
				}
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000D1594 File Offset: 0x000CF794
		public virtual void RegisterEvent()
		{
			Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00004B9C File Offset: 0x00002D9C
		public virtual void ClearEvent()
		{
			Singleton<EventCenter>.Instance.Clear(this);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000D15CC File Offset: 0x000CF7CC
		public virtual string CreateTooltipText()
		{
			string tooltipText = "";
			bool flag = !string.IsNullOrEmpty(this.Rarity);
			if (flag)
			{
				this.rareLevel = Singleton<TempDataManager>.Instance.RarityMap[this.dataConfig.data["Rarity"]].Localize("Tips");
				tooltipText = string.Concat(new string[]
				{
					tooltipText,
					"<color=",
					this.color,
					">",
					"rarity".Localize("Glossary"),
					": ",
					this.rareLevel,
					"</color>\n"
				});
			}
			bool flag2 = this.dataConfig != null && this.dataConfig.data.ContainsKey("Expend");
			if (flag2)
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
			return string.Concat(new string[]
			{
				tooltipText,
				"<color=white>",
				"effect".Localize("Glossary"),
				": ",
				this.itemDescription,
				"</color>\n"
			});
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000D1740 File Offset: 0x000CF940
		public virtual void ShowFloatingWindow()
		{
			this.lastPos = base.transform.GetComponent<RectTransform>().localPosition;
			this.floatingWindow.Show(base.transform);
			this.floatingWindow.Clear();
			UIManager.Instance.GetTooltip().Hide();
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000D1797 File Offset: 0x000CF997
		public virtual void HideFloatingWindow()
		{
			this.floatingWindow.Hide();
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000D17A8 File Offset: 0x000CF9A8
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
			this.isHover = true;
			bool flag = this.floatingWindow.showItem != base.transform;
			if (flag)
			{
				this.HideFloatingWindow();
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000D09B8 File Offset: 0x000CEBB8
		public virtual void OnPointerExit(PointerEventData eventData)
		{
			this.isHover = false;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000D17E0 File Offset: 0x000CF9E0
		public virtual void OnDrag(PointerEventData eventData)
		{
			bool flag = eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				this.isDrag = true;
				base.transform.GetComponent<RectTransform>().localPosition = this.GetMousePos(eventData);
			}
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x000D1824 File Offset: 0x000CFA24
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			bool flag = eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				this.HideFloatingWindow();
				this.lastParent = base.transform.parent;
				bool flag2 = base.transform.GetComponent<CanvasGroup>();
				if (flag2)
				{
					base.GetComponent<CanvasGroup>().blocksRaycasts = false;
				}
				bool flag3 = base.transform.GetComponent<ObjectGroup>();
				if (flag3)
				{
					base.GetComponent<ObjectGroup>().blocksRaycasts = false;
				}
				this.lastPos = base.transform.GetComponent<RectTransform>().localPosition;
				Canvas canvas = base.gameObject.AddComponent<Canvas>();
				canvas.overrideSorting = true;
				canvas.sortingOrder = 100;
				ScrollRect scrollRect = base.transform.GetComponentInParent<ScrollRect>();
				bool flag4 = scrollRect != null;
				if (flag4)
				{
					scrollRect.enabled = false;
				}
				else
				{
					bool flag5 = base.transform.GetComponentInParent<ScrollRectNonDrag>();
					if (flag5)
					{
						ScrollRectNonDrag scrollRectNonDrag = base.transform.GetComponentInParent<ScrollRectNonDrag>();
						scrollRectNonDrag.enabled = false;
					}
				}
				TMP_Text[] texts = base.transform.GetComponentsInChildren<TMP_Text>();
				foreach (TMP_Text text in texts)
				{
					text.ForceMeshUpdate(false, false);
				}
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x000D1964 File Offset: 0x000CFB64
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			this.isDrag = false;
			bool flag = eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
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
				this.AddToList(item);
				bool flag3 = base.transform.GetComponent<Canvas>();
				if (flag3)
				{
					base.transform.GetComponent<Canvas>().overrideSorting = false;
					UnityEngine.Object.Destroy(base.transform.GetComponent<Canvas>());
				}
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
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x000D1AE4 File Offset: 0x000CFCE4
		public virtual void AddToList(SwapContentIdentity item)
		{
			bool flag = base.transform.GetComponent<CanvasGroup>();
			if (flag)
			{
				base.transform.GetComponent<CanvasGroup>().blocksRaycasts = true;
			}
			bool flag2 = item == null || item.Content == this.lastParent || !item.Content.Find("Null") || item.Content == base.transform || item.Content == null || (item.CheckType && !Array.Exists<string>(item.ItemName.Replace(" ", "").Split(",", StringSplitOptions.None), (string type) => type == this.ItemType));
			if (flag2)
			{
				bool flag3 = this.lastPos != Vector2.zero;
				if (flag3)
				{
					base.transform.GetComponent<RectTransform>().localPosition = this.lastPos;
				}
			}
			else
			{
				Transform nullItem = item.Content.transform.Find("Null");
				bool flag4 = !nullItem.gameObject.activeSelf;
				if (flag4)
				{
					bool flag5 = this.lastPos != Vector2.zero;
					if (flag5)
					{
						base.transform.GetComponent<RectTransform>().localPosition = this.lastPos;
					}
				}
				else
				{
					base.transform.SetParent(item.Content);
				}
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000D1C59 File Offset: 0x000CFE59
		protected void AddToList(Transform item)
		{
			this.AddToList(item.GetComponent<SwapContentIdentity>());
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x000D1C6C File Offset: 0x000CFE6C
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			bool flag = !this.canClick;
			if (!flag)
			{
				bool flag2 = eventData.button == PointerEventData.InputButton.Right;
				if (flag2)
				{
					this.ShowFloatingWindow();
				}
				bool flag3 = eventData.button == PointerEventData.InputButton.Left;
				if (flag3)
				{
					this.HideFloatingWindow();
				}
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x000D1CB8 File Offset: 0x000CFEB8
		public Vector2 GetMousePos(PointerEventData eventData)
		{
			Vector2 pos;
			bool flag = RectTransformUtility.ScreenPointToLocalPointInRectangle(base.transform.parent.GetComponent<RectTransform>(), eventData.position, eventData.pressEventCamera, out pos);
			Vector2 result;
			if (flag)
			{
				result = pos;
			}
			else
			{
				result = default(Vector2);
			}
			return result;
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000D1D00 File Offset: 0x000CFF00
		public virtual void OnDestroy()
		{
			bool isCancellationRequested = Singleton<GameConfigManager>.Instance.cts.Token.IsCancellationRequested;
			if (!isCancellationRequested)
			{
				this.RemoveFromParent();
				this.ClearEvent();
				DOTween.Kill(base.transform, false);
				this.HideFloatingWindow();
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000D1D50 File Offset: 0x000CFF50
		public virtual void OnTransformParentChanged()
		{
			bool flag = !base.gameObject.activeSelf;
			if (!flag)
			{
				this.RemoveFromParent();
				this.AddToParent();
				base.transform.localEulerAngles = Vector3.zero;
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x000D1D94 File Offset: 0x000CFF94
		public virtual void RemoveFromParent()
		{
			bool isCancellationRequested = Singleton<GameConfigManager>.Instance.cts.Token.IsCancellationRequested;
			if (!isCancellationRequested)
			{
				bool flag = base.transform.parent == null || base.gameObject == null;
				if (!flag)
				{
					bool flag2 = this.lastParent == null || this.lastParent.childCount == 0;
					if (!flag2)
					{
						Transform nullItem = this.lastParent.GetChild(this.lastParent.childCount - 1);
						UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
						{
							bool flag3 = nullItem == null || nullItem.gameObject == null || nullItem.name != "Null";
							if (!flag3)
							{
								nullItem.gameObject.SetActive(true);
								int index = nullItem.GetSiblingIndex();
								while (index > 0 && !nullItem.parent.GetChild(index - 1).gameObject.activeSelf)
								{
									index--;
								}
								nullItem.SetSiblingIndex(index);
								bool flag4 = this != null && this.transform.parent != null;
								if (flag4)
								{
									this.lastParent = this.transform.parent;
								}
							}
						}).Forget();
					}
				}
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x000D1E64 File Offset: 0x000D0064
		public virtual void AddToParent()
		{
			bool flag = base.transform.parent == null;
			if (!flag)
			{
				Transform newNullItem = base.transform.parent.Find("Null");
				bool flag2 = newNullItem == null;
				if (!flag2)
				{
					newNullItem.gameObject.SetActive(false);
					base.transform.SetSiblingIndex(newNullItem.GetSiblingIndex());
					newNullItem.SetAsLastSibling();
				}
			}
		}

		// Token: 0x04001357 RID: 4951
		public string rareLevel;

		// Token: 0x04001358 RID: 4952
		public string itemId;

		// Token: 0x0400135B RID: 4955
		public string Rarity;

		// Token: 0x0400135C RID: 4956
		public bool ifEquipped;

		// Token: 0x0400135D RID: 4957
		public string color;

		// Token: 0x0400135E RID: 4958
		public List<string> keywords = new List<string>();

		// Token: 0x0400135F RID: 4959
		public DataConfig dataConfig;

		// Token: 0x04001360 RID: 4960
		public string ItemType = "Item";

		// Token: 0x04001361 RID: 4961
		public Sprite itemIcon;

		// Token: 0x04001362 RID: 4962
		public int itemPrice;

		// Token: 0x04001363 RID: 4963
		public Vector2 lastPos;

		// Token: 0x04001364 RID: 4964
		public bool canClick = true;

		// Token: 0x04001365 RID: 4965
		public Transform lastParent;

		// Token: 0x04001366 RID: 4966
		public bool isHover;

		// Token: 0x04001367 RID: 4967
		public bool isDrag;

		// Token: 0x04001368 RID: 4968
		[UnityInject(true)]
		public KeywordDisplay keywordDisplay;

		// Token: 0x04001369 RID: 4969
		public FloatingWindow floatingWindow;
	}
}

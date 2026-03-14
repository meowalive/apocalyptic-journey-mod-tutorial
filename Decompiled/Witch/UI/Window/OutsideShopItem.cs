using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000368 RID: 872
	public class OutsideShopItem : ItemNonDrag
	{
		// Token: 0x06001B6D RID: 7021 RVA: 0x000EA174 File Offset: 0x000E8374
		public void ShowTypeChange()
		{
			foreach (object obj in base.transform)
			{
				Transform item = (Transform)obj;
				foreach (object obj2 in item.Find("State"))
				{
					Transform tempItem = (Transform)obj2;
					tempItem.gameObject.SetActive(false);
				}
				string text = this.selfType;
				string a = text;
				if (!(a == "Level"))
				{
					if (!(a == "Lock"))
					{
						if (a == "Key")
						{
							item.Find("State/Key").gameObject.SetActive(true);
						}
					}
					else
					{
						item.Find("State/Lock").gameObject.SetActive(true);
					}
				}
				else
				{
					this.ChangeLevelShow(item.Find("State/Level"));
				}
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000EA2AC File Offset: 0x000E84AC
		private void ChangeLevelShow(Transform item)
		{
			item.gameObject.SetActive(true);
			GameObject HasLevel = item.Find("HasLevel").gameObject;
			GameObject NoLevel = item.Find("NoLevel").gameObject;
			foreach (object obj in item)
			{
				Transform tempItem = (Transform)obj;
				Singleton<ObjectPool>.Instance.Release(tempItem.gameObject);
			}
			int levelCount = Mathf.Min(5, int.Parse(this.dataConfig.data["BuyCount"]) - Singleton<GameRuntimeData>.Instance.BuyedItems.GetValueOrDefault(this.itemId, 0));
			for (int i = 0; i < levelCount; i++)
			{
				Singleton<ObjectPool>.Instance.Get(NoLevel, item);
			}
			for (int j = 0; j < 5 - levelCount; j++)
			{
				Singleton<ObjectPool>.Instance.Get(HasLevel, item);
			}
			HasLevel.SetActive(false);
			NoLevel.SetActive(false);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x000EA3D8 File Offset: 0x000E85D8
		public override void DataUpdate()
		{
			bool flag = this.dataConfig == null;
			if (!flag)
			{
				base.itemName = this.dataConfig.data.Localize("Name");
				base.itemDescription = this.dataConfig.Description().Highlight(this.keywords);
				base.transform.GetComponent<SwitchButton>().SetElement(delegate(Transform group)
				{
					group.Find("Text").GetComponent<TMP_Text>().SetText(base.itemName);
				});
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x000EA44C File Offset: 0x000E864C
		public void Init()
		{
			this.itemId = this.theData["Id"];
			this.itemPrice = int.Parse(this.theData["Price"]);
			this.itemIcon = ResourceLoader.Load<Sprite>(this.theData["Icon"], true);
			base.transform.GetComponent<SwitchButton>().SetElement(delegate(Transform group)
			{
				group.Find("Icon").GetComponent<Image>().sprite = this.itemIcon;
			});
			this.ItemType = this.theData["Type"];
			this.selfType = ((this.theData["BuyCount"] == "1") ? "Lock" : "Level");
			bool flag = this.selfType == "Lock" && Singleton<GameRuntimeData>.Instance.BuyedItems.ContainsKey(this.itemId);
			if (flag)
			{
				this.selfType = "Key";
			}
			this.DataUpdate();
			this.UpdateItem();
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000EA554 File Offset: 0x000E8754
		public void TryBuy()
		{
			bool flag = !Singleton<GameRuntimeData>.Instance.BuyedItems.ContainsKey(this.itemId);
			if (flag)
			{
				Singleton<GameRuntimeData>.Instance.BuyedItems.Add(this.itemId, 1);
			}
			else
			{
				Dictionary<string, int> buyedItems = Singleton<GameRuntimeData>.Instance.BuyedItems;
				string itemId = this.itemId;
				buyedItems[itemId]++;
			}
			bool flag2 = this.selfType == "Lock";
			if (flag2)
			{
				this.selfType = "Key";
			}
			Singleton<GameConfigManager>.Instance.BuySaveByName(this.dataConfig.data);
			this.outsiderShopUI.UpdateAllItems();
			bool flag3 = int.Parse(this.theData["BuyCount"]) <= Singleton<GameRuntimeData>.Instance.BuyedItems[this.itemId];
			if (flag3)
			{
				UIManager.Instance.ShowItemShowUI(this.itemIcon, base.itemName, base.itemDescription, null);
				UniTask.Delay(400, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
				{
					this.dataConfig.scriptExecutor.RunScript("BuyScript");
				}).Forget();
			}
			else
			{
				this.dataConfig.scriptExecutor.RunScript("BuyScript");
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000EA69A File Offset: 0x000E889A
		public void UpdateItem()
		{
			this.ShowTypeChange();
		}

		// Token: 0x040014B3 RID: 5299
		public Dictionary<string, string> theData;

		// Token: 0x040014B4 RID: 5300
		public string selfType;

		// Token: 0x040014B5 RID: 5301
		public OutsiderShopUI outsiderShopUI;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using Cysharp.Threading.Tasks;
using Data.Save;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x0200036D RID: 877
	public class ShopUI : UIBase
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x000EB830 File Offset: 0x000E9A30
		[DebuggerStepThrough]
		public override void DataUpdate()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ShopUI.DataUpdate()).MethodHandle, typeof(ShopUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_DataUpdate();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x000EB92C File Offset: 0x000E9B2C
		[DebuggerStepThrough]
		private void Awake()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ShopUI.Awake()).MethodHandle, typeof(ShopUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_Awake();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000EBA28 File Offset: 0x000E9C28
		public void CreateSellCard()
		{
			UIManager.Instance.GetFloatingWindow().Hide();
			foreach (object obj in this.SellCardPrefab.transform.parent)
			{
				Transform item = (Transform)obj;
				bool flag = item.name == "Item" || item.name == "Title";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			List<DataConfig> TempCardList = (from x in RoleTable.Instance.cardList
			orderby x.data["Expend"], x.data.Localize("Name")
			select x).ToList<DataConfig>();
			this.baseCardList.AddRange(TempCardList);
			foreach (DataConfig item2 in TempCardList)
			{
				GameObject itemObj = Singleton<ObjectPool>.Instance.Get(this.SellCardPrefab, this.SellCardPrefab.transform.parent);
				SellItem sellItem = itemObj.GetComponent<SellItem>();
				sellItem.ItemType = "Card";
				sellItem.Init(true, item2);
				sellItem.shop = this;
				itemObj.SetActive(true);
			}
			TempCardList = (from x in RoleTable.Instance.UnCardList
			orderby x.data["Expend"], x.data.Localize("Name")
			select x).ToList<DataConfig>();
			this.baseCardList.AddRange(TempCardList);
			foreach (DataConfig item3 in TempCardList)
			{
				GameObject itemObj2 = Singleton<ObjectPool>.Instance.Get(this.SellCardPrefab, this.SellCardPrefab.transform.parent);
				SellItem sellItem2 = itemObj2.GetComponent<SellItem>();
				sellItem2.ItemType = "Card";
				sellItem2.Init(false, item3);
				sellItem2.shop = this;
				itemObj2.SetActive(true);
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000EBCC4 File Offset: 0x000E9EC4
		public void UpdateSellRelic()
		{
			UIManager.Instance.GetFloatingWindow().Hide();
			GameObject nullPrefab = this.TopRelicPrefab.transform.parent.Find("NullPrefab").gameObject;
			Transform topRelicList = this.TopRelicPrefab.transform.parent;
			foreach (object obj in topRelicList)
			{
				Transform item = (Transform)obj;
				string name = item.name;
				bool flag = name == "Item" || name == "NullPrefab" || name == "Title";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			foreach (DataConfig item2 in RoleTable.Instance.relicList)
			{
				GameObject TopRelicItem = Singleton<ObjectPool>.Instance.Get(this.TopRelicPrefab, topRelicList);
				RelicItemConfig relicItemConfig = TopRelicItem.GetComponent<RelicItemConfig>();
				relicItemConfig.Init(item2);
				relicItemConfig.ifEquipped = true;
				TopRelicItem.name = item2.data.Localize("Name");
				TopRelicItem.SetActive(true);
			}
			for (int i = 0; i < 6 - RoleTable.Instance.relicList.Count; i++)
			{
				GameObject relicItem = Singleton<ObjectPool>.Instance.Get(nullPrefab, topRelicList);
				relicItem.name = "Null";
				relicItem.SetActive(true);
			}
			this.TopRelicPrefab.SetActive(false);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000EBE98 File Offset: 0x000EA098
		[DebuggerStepThrough]
		public void Flushed()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ShopUI.Flushed()).MethodHandle, typeof(ShopUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_Flushed();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x000EBF94 File Offset: 0x000EA194
		[DebuggerStepThrough]
		public void ChangeFlushShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ShopUI.ChangeFlushShow()).MethodHandle, typeof(ShopUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_ChangeFlushShow();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000EC090 File Offset: 0x000EA290
		public virtual void SetShopItems()
		{
			foreach (object obj in this.ShopTran)
			{
				Transform item = (Transform)obj;
				bool flag = item.name == "Item";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			List<Dictionary<string, string>> relics = (from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Relic).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			where !RoleTable.Instance.relicGets.ContainsKey(x["Id"]) && x["Rarity"] != "4" && !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"])
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			Dice dice = base.dice.WithType("Default");
			int relicCount = Math.Min(3, relics.Count);
			int cardCount = 3;
			List<Dictionary<string, string>> cards = Singleton<GameConfigManager>.Instance.GetTable(DataType.Card).Getlines();
			relics = new RandomPool(relics, dice).DrawByRarity(relicCount);
			cards = new RandomPool((from x in cards.AsValueEnumerable<Dictionary<string, string>>()
			where x["Type"] != "诅咒"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), dice).DrawByRarity(cardCount);
			cardCount = Math.Min(cardCount, cards.Count);
			for (int i = 0; i < relicCount; i++)
			{
				GameObject item2 = Singleton<ObjectPool>.Instance.Get(this.ItemPrefab, this.ItemPrefab.transform.parent);
				ShopItem shopItem = item2.GetComponent<ShopItem>();
				bool flag2 = shopItem == null;
				if (flag2)
				{
					shopItem = item2.AddComponent<ShopItem>();
				}
				shopItem.ItemType = "Relic";
				string id = relics[i]["Id"];
				GameSaveAnalyser.Instance.TryPush(relics[i]["Name"], OperObj.Relics, OperType.ShopShow);
				shopItem.itemId = id;
				shopItem.shop = this;
				shopItem.Init(new DataConfig(id, DataType.Relic));
				item2.SetActive(true);
			}
			for (int j = 0; j < cardCount; j++)
			{
				GameObject item3 = Singleton<ObjectPool>.Instance.Get(this.ItemPrefab, this.ItemPrefab.transform.parent);
				ShopItem shopItem2 = item3.GetComponent<ShopItem>();
				bool flag3 = shopItem2 == null;
				if (flag3)
				{
					shopItem2 = item3.AddComponent<ShopItem>();
				}
				shopItem2.ItemType = "Card";
				string id2 = cards[j]["Id"];
				bool flag4 = Singleton<GameConfigManager>.Instance.NativeIds.Contains(id2);
				if (flag4)
				{
					GameSaveAnalyser.Instance.TryPush(cards[j]["Name"], OperObj.Cards, OperType.ShopShow);
				}
				shopItem2.itemId = id2;
				shopItem2.shop = this;
				shopItem2.Init(new DataConfig(id2, DataType.Card));
				item3.SetActive(true);
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000EC39C File Offset: 0x000EA59C
		[DebuggerStepThrough]
		public void OnRoleTableChanged(object sender, PropertyChangedEventArgs args)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ShopUI.OnRoleTableChanged(object, PropertyChangedEventArgs)).MethodHandle, typeof(ShopUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				sender,
				args
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							sender = null;
						}
						else
						{
							sender = arguments[0];
						}
						if (arguments[1] == null)
						{
							args = null;
						}
						else
						{
							args = (PropertyChangedEventArgs)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_OnRoleTableChanged(sender, args);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_118;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_118:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x000EC4E8 File Offset: 0x000EA6E8
		public void UpdateSellCard()
		{
			List<DataConfig> newList = new List<DataConfig>((from x in RoleTable.Instance.cardList
			orderby x.data["Expend"], x.data.Localize("Name")
			select x).ToList<DataConfig>());
			newList.AddRange((from x in RoleTable.Instance.UnCardList
			orderby x.data["Expend"], x.data.Localize("Name")
			select x).ToList<DataConfig>());
			List<DataConfig> NeedDeleteList = this.baseCardList.Except(newList).ToList<DataConfig>();
			List<DataConfig> NeedAddList = newList.Except(this.baseCardList).ToList<DataConfig>();
			foreach (object obj in this.SellCardPrefab.transform.parent)
			{
				Transform item = (Transform)obj;
				bool flag = item.GetComponent<SellItem>() == null || !item.gameObject.activeSelf || !NeedDeleteList.Contains(item.GetComponent<SellItem>().dataConfig);
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			foreach (DataConfig item2 in NeedAddList)
			{
				GameObject itemObj = Singleton<ObjectPool>.Instance.Get(this.SellCardPrefab, this.SellCardPrefab.transform.parent);
				SellItem sellItem = itemObj.GetComponent<SellItem>();
				sellItem.ItemType = "Card";
				sellItem.Init(false, item2);
				sellItem.shop = this;
				itemObj.SetActive(true);
			}
			this.baseCardList = newList;
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000EC714 File Offset: 0x000EA914
		[DebuggerStepThrough]
		public void AnimationPlay(GameObject obj)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ShopUI.AnimationPlay(GameObject)).MethodHandle, typeof(ShopUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				obj
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							obj = null;
						}
						else
						{
							obj = (GameObject)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_AnimationPlay(obj);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_FD;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_FD:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000EC848 File Offset: 0x000EAA48
		[DebuggerStepThrough]
		public override void OnDestroy()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ShopUI.OnDestroy()).MethodHandle, typeof(ShopUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_OnDestroy();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000EC944 File Offset: 0x000EAB44
		public virtual void UpdateAllItems()
		{
			foreach (object obj in this.ShopTran)
			{
				Transform item = (Transform)obj;
				bool flag = item.GetComponent<ShopItem>() == null;
				if (!flag)
				{
					item.GetComponent<ShopItem>().UpdateItem();
				}
			}
			base.transform.Find("Content/Backpack/Money/text").GetComponent<TMP_Text>().text = RoleTable.Instance.Money.ToString();
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000ECA3C File Offset: 0x000EAC3C
		private void $Rougamo_DataUpdate()
		{
			this.ChangeFlushShow();
			base.transform.Find("Content/List View Custom/Title").GetComponent<TMP_Text>().text = "Shop".Localize("ShopUI");
			base.transform.Find("Content/Backpack/Title").GetComponent<TMP_Text>().text = "Back".Localize("ShopUI");
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000ECAA8 File Offset: 0x000EACA8
		private void $Rougamo_Awake()
		{
			bool flag = UIManager.Instance.GetUI<EventUI>("EventUI") == null;
			if (flag)
			{
				GameApp.Instance.NowBackground.SetActive(true);
			}
			bool flag2 = UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI") != null;
			if (flag2)
			{
				UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI").Hide();
			}
			base.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
			this.flushmoneychange = Math.Max(Singleton<GameRuntimeData>.Instance.Gain["flushmoneychange"], 0);
			this.maxFlushedCount = GameSaveManager.GetValue<int>(GameVar.RefreshCount);
			base.transform.Find("ExitButton").GetComponent<ButtonManager>().onClick.AddListener(delegate
			{
				MapManager.Instance.TryChange();
				this.Close();
			});
			base.transform.Find("Content/Backpack/Money/text").GetComponent<TMP_Text>().text = RoleTable.Instance.Money.ToString();
			bool flag3 = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
			if (flag3)
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").HideLeftUp();
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").transform.SetAsLastSibling();
			}
			((INotifyPropertyChanged)RoleTable.Instance).PropertyChanged += this.OnRoleTableChanged;
			this.SetShopItems();
			this.CreateSellCard();
			this.UpdateSellRelic();
			this.ChangeFlushShow();
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x000ECC38 File Offset: 0x000EAE38
		private void $Rougamo_Flushed()
		{
			bool flag = this.flushedCount < this.maxFlushedCount && RoleTable.Instance.Money > this.flushedCount * this.flushmoneychange + 20;
			if (flag)
			{
				RoleTable.Instance.Money -= this.flushedCount * this.flushmoneychange + 20;
				this.SetShopItems();
				this.flushedCount++;
				this.ChangeFlushShow();
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000ECCC8 File Offset: 0x000EAEC8
		private void $Rougamo_ChangeFlushShow()
		{
			bool flag = base.transform.Find("Content/Refresh") == null;
			if (!flag)
			{
				bool flag2 = this.flushedCount >= this.maxFlushedCount;
				if (flag2)
				{
					base.transform.Find("Content/Refresh").GetComponent<ButtonManager>().SetText("Reached the limit".Localize("ShopUI"));
				}
				else
				{
					base.transform.Find("Content/Refresh").GetComponent<ButtonManager>().SetText("Flush".Localize("ShopUI") + (this.flushedCount * this.flushmoneychange + 20).ToString());
				}
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000ECD84 File Offset: 0x000EAF84
		private void $Rougamo_OnRoleTableChanged(object sender, PropertyChangedEventArgs args)
		{
			UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
			{
				bool flag = this != null;
				if (flag)
				{
					this.UpdateSellCard();
					this.UpdateSellRelic();
					this.UpdateAllItems();
				}
			}).Forget();
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000A1113 File Offset: 0x0009F313
		private void $Rougamo_AnimationPlay(GameObject obj)
		{
			UIManager.Instance.GetAnimationManage().AnimationPlay(obj);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000ECDB8 File Offset: 0x000EAFB8
		private void $Rougamo_OnDestroy()
		{
			base.OnDestroy();
			bool flag = RoleTable.Instance != null;
			if (flag)
			{
				((INotifyPropertyChanged)RoleTable.Instance).PropertyChanged -= this.OnRoleTableChanged;
			}
			bool flag2 = UIManager.Instance.GetUI<EventUI>("EventUI") != null;
			if (flag2)
			{
				UIManager.Instance.GetUI<EventUI>("EventUI").TryChangeMap();
			}
			bool flag3 = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
			if (flag3)
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ShowLeftUp();
			}
		}

		// Token: 0x040014BF RID: 5311
		public ShopItem currentItem;

		// Token: 0x040014C0 RID: 5312
		public GameObject SellCardPrefab;

		// Token: 0x040014C1 RID: 5313
		public GameObject TopRelicPrefab;

		// Token: 0x040014C2 RID: 5314
		public int flushedCount = 0;

		// Token: 0x040014C3 RID: 5315
		public int maxFlushedCount;

		// Token: 0x040014C4 RID: 5316
		public Transform ShopTran;

		// Token: 0x040014C5 RID: 5317
		public int flushmoneychange;

		// Token: 0x040014C6 RID: 5318
		public GameObject ItemPrefab;

		// Token: 0x040014C7 RID: 5319
		private List<DataConfig> baseCardList = new List<DataConfig>();
	}
}

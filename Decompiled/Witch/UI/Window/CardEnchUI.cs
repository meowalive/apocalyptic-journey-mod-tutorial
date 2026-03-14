using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
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
	// Token: 0x02000314 RID: 788
	public class CardEnchUI : ShopUI
	{
		// Token: 0x06001896 RID: 6294 RVA: 0x000CF934 File Offset: 0x000CDB34
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
			methodContext.TargetType = typeof(CardEnchUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEnchUI.Awake()).MethodHandle, typeof(CardEnchUI).TypeHandle);
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

		// Token: 0x06001897 RID: 6295 RVA: 0x000CFA30 File Offset: 0x000CDC30
		[DebuggerStepThrough]
		public override void SetShopItems()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardEnchUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEnchUI.SetShopItems()).MethodHandle, typeof(CardEnchUI).TypeHandle);
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
							this.$Rougamo_SetShopItems();
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

		// Token: 0x06001898 RID: 6296 RVA: 0x000CFB2C File Offset: 0x000CDD2C
		[DebuggerStepThrough]
		public void UpdateEnchShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardEnchUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEnchUI.UpdateEnchShow()).MethodHandle, typeof(CardEnchUI).TypeHandle);
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
							this.$Rougamo_UpdateEnchShow();
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

		// Token: 0x06001899 RID: 6297 RVA: 0x000CFC28 File Offset: 0x000CDE28
		[DebuggerStepThrough]
		public void ShowCardToEnch(ShopItem enchItem)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardEnchUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEnchUI.ShowCardToEnch(ShopItem)).MethodHandle, typeof(CardEnchUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				enchItem
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
							enchItem = null;
						}
						else
						{
							enchItem = (ShopItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowCardToEnch(enchItem);
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

		// Token: 0x0600189C RID: 6300 RVA: 0x000CFD7C File Offset: 0x000CDF7C
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
			this.SetShopItems();
			base.CreateSellCard();
			base.UpdateSellRelic();
			((INotifyPropertyChanged)RoleTable.Instance).PropertyChanged += base.OnRoleTableChanged;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000CFF04 File Offset: 0x000CE104
		private void $Rougamo_SetShopItems()
		{
			List<Dictionary<string, string>> enchList = new RandomPool((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.EnchTag).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"])
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), base.dice).DrawByRarity(6);
			for (int i = this.ShopTran.childCount - 1; i >= 0; i--)
			{
				Transform child = this.ShopTran.GetChild(i);
				bool flag = child == null || child.name == "Item";
				if (!flag)
				{
					UnityEngine.Object.Destroy(child.gameObject);
				}
			}
			for (int j = 0; j < enchList.Count; j++)
			{
				ShopItem enchItem = UnityEngine.Object.Instantiate<GameObject>(this.ItemPrefab, this.ShopTran).GetComponent<ShopItem>();
				enchItem.gameObject.SetActive(true);
				enchItem.ItemType = "EnchTag";
				enchItem.shop = this;
				enchItem.Init(new DataConfig(enchList[j]["Id"], DataType.EnchTag));
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_UpdateEnchShow()
		{
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x000D0038 File Offset: 0x000CE238
		private void $Rougamo_ShowCardToEnch(ShopItem enchItem)
		{
			List<IDataConfig> newList = new List<IDataConfig>(RoleTable.Instance.cardList);
			newList.AddRange(RoleTable.Instance.UnCardList);
			bool flag = newList.Count == 0;
			if (!flag)
			{
				UIManager.Instance.ShowUI<DeckUI>("DeckUI", true);
				List<IDataConfig> cardList = new List<IDataConfig>();
				UIManager.Instance.GetUI<DeckUI>("DeckUI").CreateDeckMenuForSelect(1, cardList, newList);
				Singleton<EventCenter>.Instance.AddEventListener("SelectCardEnd", delegate()
				{
					foreach (IDataConfig dataConfig in cardList)
					{
						RoleTable.Instance.enchasedDict[dataConfig.InstanceID] = enchItem.dataConfig;
					}
					foreach (SellItem item in this.SellCardPrefab.transform.parent.GetComponentsInChildren<SellItem>())
					{
						item.CheckEnch();
					}
					Singleton<EventCenter>.Instance.RemoveEventListener("SelectCardEnd", this);
				}, this, EventDispose.None);
			}
		}
	}
}

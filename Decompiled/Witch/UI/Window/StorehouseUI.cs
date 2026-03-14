using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200036F RID: 879
	public class StorehouseUI : UIBase
	{
		// Token: 0x06001BBD RID: 7101 RVA: 0x000ECED4 File Offset: 0x000EB0D4
		[DebuggerStepThrough]
		public override void OnEnable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StorehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StorehouseUI.OnEnable()).MethodHandle, typeof(StorehouseUI).TypeHandle);
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
							this.$Rougamo_OnEnable();
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

		// Token: 0x06001BBE RID: 7102 RVA: 0x000ECFD0 File Offset: 0x000EB1D0
		public void CreateCardList()
		{
			this.TempItem.SetActive(true);
			foreach (object obj in this.ListTransform)
			{
				Transform child = (Transform)obj;
				bool flag = child.name == "Item";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(child.gameObject);
				}
			}
			foreach (DataConfig item in Singleton<GameRuntimeData>.Instance.CardData)
			{
				this.CreateItem(item, true);
			}
			foreach (DataConfig item2 in Singleton<GameRuntimeData>.Instance.RelicData)
			{
				this.CreateItem(item2, false);
			}
			this.TempItem.SetActive(false);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000ED108 File Offset: 0x000EB308
		[DebuggerStepThrough]
		public void CreateItem(DataConfig Data, bool isCard)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StorehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StorehouseUI.CreateItem(DataConfig, bool)).MethodHandle, typeof(StorehouseUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				Data,
				isCard
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
							Data = null;
						}
						else
						{
							Data = (DataConfig)arguments[0];
						}
						if (arguments[1] == null)
						{
							isCard = default(bool);
						}
						else
						{
							isCard = (bool)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateItem(Data, isCard);
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
								goto IL_125;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_125:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000ED264 File Offset: 0x000EB464
		[DebuggerStepThrough]
		public void SetCurrentItem(StorehouseItem item)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StorehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StorehouseUI.SetCurrentItem(StorehouseItem)).MethodHandle, typeof(StorehouseUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				item
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
							item = null;
						}
						else
						{
							item = (StorehouseItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetCurrentItem(item);
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

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000ED398 File Offset: 0x000EB598
		[DebuggerStepThrough]
		public void ExitCureentItem()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StorehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StorehouseUI.ExitCureentItem()).MethodHandle, typeof(StorehouseUI).TypeHandle);
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
							this.$Rougamo_ExitCureentItem();
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

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000ED494 File Offset: 0x000EB694
		[DebuggerStepThrough]
		public void SetDescription()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StorehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StorehouseUI.SetDescription()).MethodHandle, typeof(StorehouseUI).TypeHandle);
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
							this.$Rougamo_SetDescription();
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

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000ED590 File Offset: 0x000EB790
		[DebuggerStepThrough]
		public void HideDescription()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StorehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StorehouseUI.HideDescription()).MethodHandle, typeof(StorehouseUI).TypeHandle);
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
							this.$Rougamo_HideDescription();
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

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000ED76D File Offset: 0x000EB96D
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.CreateCardList();
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000ED780 File Offset: 0x000EB980
		private void $Rougamo_CreateItem(DataConfig Data, bool isCard)
		{
			bool flag = Data == null;
			if (!flag)
			{
				GameObject obj = Singleton<ObjectPool>.Instance.Get(this.TempItem, this.ListTransform);
				StorehouseItem item = obj.GetComponent<StorehouseItem>() ?? obj.AddComponent<StorehouseItem>();
				if (isCard)
				{
					item.ItemType = "Card";
				}
				else
				{
					item.ItemType = "Relic";
				}
				item.dataConfig = Data;
				item.storehouseUI = this;
				item.Init(Data);
				obj.SetActive(true);
			}
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000ED800 File Offset: 0x000EBA00
		private void $Rougamo_SetCurrentItem(StorehouseItem item)
		{
			this.thiscurrentItem = item;
			this.SetDescription();
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000ED811 File Offset: 0x000EBA11
		private void $Rougamo_ExitCureentItem()
		{
			this.HideDescription();
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x000ED81C File Offset: 0x000EBA1C
		private void $Rougamo_SetDescription()
		{
			base.transform.Find("描述").GetComponent<CanvasGroup>().alpha = 1f;
			bool flag = this.thiscurrentItem != null;
			if (flag)
			{
				StorehouseItem item = this.thiscurrentItem;
				base.transform.Find("描述/Content/description/name/text").GetComponent<TextMeshProUGUI>().text = item.itemName;
				base.transform.Find("描述/Content/value/text").GetComponent<TextMeshProUGUI>().text = ":" + item.itemPrice.ToString();
				base.transform.Find("描述/Content/description/icon/type").GetComponent<TextMeshProUGUI>().text = this.TypeMap[item.ItemType];
				base.transform.Find("描述/Content/description/icon/rare").GetComponent<TextMeshProUGUI>().color = Color.yellow;
				base.transform.Find("描述/Content/description/icon/image").GetComponent<Image>().sprite = item.itemIcon;
				base.transform.Find("描述/Content/entrys/item/text").GetComponent<TextMeshProUGUI>().text = item.itemDescription;
				UniTask.DelayFrame(1, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
				{
					LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.Find("描述/Content").GetComponent<RectTransform>());
					UniTask.DelayFrame(1, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
					{
						LayoutRebuilder.ForceRebuildLayoutImmediate(base.transform.Find("描述/Content").GetComponent<RectTransform>());
					});
				});
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x000ED965 File Offset: 0x000EBB65
		private void $Rougamo_HideDescription()
		{
			base.transform.Find("描述").GetComponent<CanvasGroup>().alpha = 0f;
		}

		// Token: 0x040014D3 RID: 5331
		public GameObject TempItem;

		// Token: 0x040014D4 RID: 5332
		public Transform ListTransform;

		// Token: 0x040014D5 RID: 5333
		public StorehouseItem thiscurrentItem;

		// Token: 0x040014D6 RID: 5334
		public Dictionary<string, string> TypeMap = new Dictionary<string, string>
		{
			{
				"Card",
				"卡牌"
			},
			{
				"Relic",
				"遗物"
			},
			{
				"Item",
				"物品"
			},
			{
				"Blessing",
				"祝福"
			},
			{
				"Career",
				"角色"
			},
			{
				"EX",
				"超凡"
			}
		};
	}
}

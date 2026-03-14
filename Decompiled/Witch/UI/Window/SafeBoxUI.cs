using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000354 RID: 852
	public class SafeBoxUI : UIBase
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x000E2ED0 File Offset: 0x000E10D0
		private GameRuntimeData gameRuntimeData
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(SafeBoxUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.get_gameRuntimeData()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
				methodContext.Arguments = new object[0];
				GameRuntimeData gameRuntimeData;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								gameRuntimeData = this.$Rougamo_get_gameRuntimeData();
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
								if (exceptionHandled)
								{
									gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = gameRuntimeData;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return gameRuntimeData;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x000E3010 File Offset: 0x000E1210
		public Tooltip tooltip
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(SafeBoxUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.get_tooltip()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
				methodContext.Arguments = new object[0];
				Tooltip tooltip;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						tooltip = (Tooltip)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								tooltip = this.$Rougamo_get_tooltip();
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
								if (exceptionHandled)
								{
									tooltip = (Tooltip)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = tooltip;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							tooltip = (Tooltip)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return tooltip;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x000E3150 File Offset: 0x000E1350
		public FloatingWindow floatingWindow
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(SafeBoxUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.get_floatingWindow()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
				methodContext.Arguments = new object[0];
				FloatingWindow floatingWindow;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						floatingWindow = (FloatingWindow)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								floatingWindow = this.$Rougamo_get_floatingWindow();
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
								if (exceptionHandled)
								{
									floatingWindow = (FloatingWindow)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = floatingWindow;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							floatingWindow = (FloatingWindow)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return floatingWindow;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x000E3290 File Offset: 0x000E1490
		private bool GetCard
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(SafeBoxUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.get_GetCard()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
				methodContext.Arguments = new object[0];
				bool flag;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						flag = (bool)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								flag = this.$Rougamo_get_GetCard();
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
								if (exceptionHandled)
								{
									flag = (bool)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_10D;
								}
								throw;
							}
							methodContext.ReturnValue = flag;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							flag = (bool)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_10D:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return flag;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000E33D4 File Offset: 0x000E15D4
		private bool GetRelic
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(SafeBoxUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.get_GetRelic()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
				methodContext.Arguments = new object[0];
				bool flag;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						flag = (bool)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								flag = this.$Rougamo_get_GetRelic();
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
								if (exceptionHandled)
								{
									flag = (bool)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_10D;
								}
								throw;
							}
							methodContext.ReturnValue = flag;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							flag = (bool)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_10D:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return flag;
			}
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000E3518 File Offset: 0x000E1718
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
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.DataUpdate()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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

		// Token: 0x06001AB6 RID: 6838 RVA: 0x000E3614 File Offset: 0x000E1814
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
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.Awake()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000E3710 File Offset: 0x000E1910
		public static void SafeboxSave()
		{
			foreach (DataConfig item in SafeBoxUI.OutCardList)
			{
				Singleton<GameRuntimeData>.Instance.CardData.Remove(item);
			}
			foreach (DataConfig item2 in SafeBoxUI.OutRelicList)
			{
				Singleton<GameRuntimeData>.Instance.RelicData.Remove(item2);
			}
			foreach (DataConfig item3 in SafeBoxUI.InCardList)
			{
				Singleton<GameRuntimeData>.Instance.CardData.Add(item3);
			}
			foreach (DataConfig item4 in SafeBoxUI.InRelicList)
			{
				Singleton<GameRuntimeData>.Instance.RelicData.Add(item4);
			}
			SafeBoxUI.ClearList();
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000E386C File Offset: 0x000E1A6C
		[DebuggerStepThrough]
		public static void ClearList()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.ClearList()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							SafeBoxUI.$Rougamo_ClearList();
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
								goto IL_C0;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C0:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000E3960 File Offset: 0x000E1B60
		[DebuggerStepThrough]
		public static void ResetCount()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.ResetCount()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							SafeBoxUI.$Rougamo_ResetCount();
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
								goto IL_C0;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C0:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x000E3A54 File Offset: 0x000E1C54
		[DebuggerStepThrough]
		public void RetainMoney()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.RetainMoney()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							this.$Rougamo_RetainMoney();
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

		// Token: 0x06001ABB RID: 6843 RVA: 0x000E3B50 File Offset: 0x000E1D50
		[DebuggerStepThrough]
		public void ChangeMoney()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.ChangeMoney()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							this.$Rougamo_ChangeMoney();
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

		// Token: 0x06001ABC RID: 6844 RVA: 0x000E3C4C File Offset: 0x000E1E4C
		[DebuggerStepThrough]
		public void ChangeMoneyShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.ChangeMoneyShow()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							this.$Rougamo_ChangeMoneyShow();
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

		// Token: 0x06001ABD RID: 6845 RVA: 0x000E3D48 File Offset: 0x000E1F48
		[DebuggerStepThrough]
		public void ChangeCountShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.ChangeCountShow()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							this.$Rougamo_ChangeCountShow();
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

		// Token: 0x06001ABE RID: 6846 RVA: 0x000E3E44 File Offset: 0x000E2044
		[DebuggerStepThrough]
		public void ShowBackItem()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.ShowBackItem()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							this.$Rougamo_ShowBackItem();
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

		// Token: 0x06001ABF RID: 6847 RVA: 0x000E3F40 File Offset: 0x000E2140
		public void UpdateBackCard()
		{
			UIManager.Instance.GetFloatingWindow().Hide();
			GameObject nullPrefab = this.cardBack.Find("NullPrefab").gameObject;
			foreach (object obj in this.cardBack)
			{
				Transform item = (Transform)obj;
				bool flag = item.name == "Item" || item.name == "NullPrefab";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			foreach (DataConfig item2 in RoleTable.Instance.cardList)
			{
				GameObject cardItem = Singleton<ObjectPool>.Instance.Get(this.cardBack.Find("Item").gameObject, this.cardBack);
				SafeBoxItem showCard = cardItem.GetComponent<SafeBoxItem>();
				bool flag2 = showCard == null;
				if (flag2)
				{
					showCard = cardItem.AddComponent<SafeBoxItem>();
				}
				showCard.ItemType = "Card";
				showCard.ifEquipped = true;
				showCard.safeBoxUI = this;
				showCard.Init(item2);
				cardItem.name = item2.data.Localize("Name");
				cardItem.SetActive(true);
			}
			foreach (DataConfig item3 in RoleTable.Instance.UnCardList)
			{
				GameObject cardItem2 = Singleton<ObjectPool>.Instance.Get(this.cardBack.Find("Item").gameObject, this.cardBack);
				SafeBoxItem showCard2 = cardItem2.GetComponent<SafeBoxItem>();
				bool flag3 = showCard2 == null;
				if (flag3)
				{
					showCard2 = cardItem2.AddComponent<SafeBoxItem>();
				}
				showCard2.ItemType = "Card";
				showCard2.ifEquipped = false;
				showCard2.safeBoxUI = this;
				showCard2.Init(item3);
				cardItem2.name = item3.data.Localize("Name");
				cardItem2.SetActive(true);
			}
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000E41B0 File Offset: 0x000E23B0
		public void UpdateBackRelic()
		{
			UIManager.Instance.GetFloatingWindow().Hide();
			GameObject nullPrefab = this.TopRelicPrefab.transform.parent.Find("NullPrefab").gameObject;
			Transform topRelicList = this.TopRelicPrefab.transform.parent;
			foreach (object obj in topRelicList)
			{
				Transform item = (Transform)obj;
				string name = item.name;
				bool flag = name == "NullPrefab" || name == "Item";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			foreach (DataConfig item2 in RoleTable.Instance.relicList)
			{
				GameObject TopRelicItem = Singleton<ObjectPool>.Instance.Get(this.TopRelicPrefab, topRelicList);
				SafeBoxItem relicItemConfig = TopRelicItem.GetComponent<SafeBoxItem>();
				bool flag2 = relicItemConfig == null;
				if (flag2)
				{
					relicItemConfig = TopRelicItem.AddComponent<SafeBoxItem>();
				}
				relicItemConfig.ItemType = "Relic";
				relicItemConfig.Init(item2);
				relicItemConfig.ifEquipped = true;
				relicItemConfig.safeBoxUI = this;
				TopRelicItem.name = item2.data.Localize("Name");
				TopRelicItem.SetActive(true);
			}
			for (int i = 0; i < 6; i++)
			{
				GameObject relicItem = Singleton<ObjectPool>.Instance.Get(nullPrefab, topRelicList);
				relicItem.name = "Null";
				relicItem.SetActive(false);
				bool flag3 = i >= RoleTable.Instance.relicList.Count;
				if (flag3)
				{
					relicItem.SetActive(true);
				}
				else
				{
					relicItem.transform.SetAsLastSibling();
				}
			}
			this.TopRelicPrefab.SetActive(false);
			GameObject newNullPrefab = this.BottomRelicPrefab.transform.parent.Find("NullPrefab").gameObject;
			Transform bottomRelicList = this.BottomRelicPrefab.transform.parent;
			foreach (object obj2 in bottomRelicList)
			{
				Transform item3 = (Transform)obj2;
				string name = item3.name;
				bool flag4 = name == "NullPrefab" || name == "Item";
				if (!flag4)
				{
					Singleton<ObjectPool>.Instance.Release(item3.gameObject);
				}
			}
			foreach (DataConfig item4 in RoleTable.Instance.WithoutArmedRelicList)
			{
				GameObject TopRelicItem2 = Singleton<ObjectPool>.Instance.Get(this.BottomRelicPrefab, bottomRelicList);
				SafeBoxItem relicItemConfig2 = TopRelicItem2.GetComponent<SafeBoxItem>();
				bool flag5 = relicItemConfig2 == null;
				if (flag5)
				{
					relicItemConfig2 = TopRelicItem2.AddComponent<SafeBoxItem>();
				}
				relicItemConfig2.ItemType = "Relic";
				relicItemConfig2.ifEquipped = false;
				relicItemConfig2.safeBoxUI = this;
				relicItemConfig2.Init(item4);
				TopRelicItem2.name = item4.data.Localize("Name");
				TopRelicItem2.SetActive(true);
			}
			for (int j = 0; j < 9; j++)
			{
				GameObject relicItem2 = Singleton<ObjectPool>.Instance.Get(newNullPrefab, bottomRelicList);
				relicItem2.name = "Null";
				relicItem2.SetActive(true);
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000E459C File Offset: 0x000E279C
		public void ShowHadItems()
		{
			List<DataConfig> tempList = new List<DataConfig>(this.gameRuntimeData.CardData);
			foreach (DataConfig item in tempList)
			{
				bool flag = !item.data.ContainsKey("Id");
				if (flag)
				{
					this.gameRuntimeData.CardData.Remove(item);
				}
			}
			List<DataConfig> relicTempList = new List<DataConfig>(this.gameRuntimeData.RelicData);
			this.SortList(relicTempList);
			for (int i = 0; i < relicTempList.Count; i++)
			{
				GameObject gameObject = Singleton<ObjectPool>.Instance.Get(this.relicBox.Find("Item").gameObject, this.relicBox);
				SafeBoxItem item2 = gameObject.GetComponent<SafeBoxItem>();
				bool flag2 = item2 == null;
				if (flag2)
				{
					item2 = gameObject.AddComponent<SafeBoxItem>();
				}
				item2.ItemType = "Relic";
				item2.safeBoxUI = this;
				item2.hasInBack = true;
				item2.tooltip = this.tooltip;
				item2.InBackPack = false;
				item2.Init(relicTempList[i]);
			}
			for (int j = 0; j < SafeBoxUI.InRelicList.Count; j++)
			{
				GameObject gameObject2 = Singleton<ObjectPool>.Instance.Get(this.relicBox.Find("Item").gameObject, this.relicBox);
				SafeBoxItem item3 = gameObject2.GetComponent<SafeBoxItem>();
				bool flag3 = item3 == null;
				if (flag3)
				{
					item3 = gameObject2.AddComponent<SafeBoxItem>();
				}
				item3.ItemType = "Relic";
				item3.safeBoxUI = this;
				item3.tooltip = this.tooltip;
				item3.InBackPack = false;
				item3.Init(SafeBoxUI.InRelicList[j]);
			}
			for (int k = 0; k < 10; k++)
			{
				GameObject nullItem = Singleton<ObjectPool>.Instance.Get(this.relicBox.Find("NullPrefab").gameObject, this.relicBox);
				nullItem.name = "Null";
				nullItem.SetActive(true);
			}
			this.SortList(tempList);
			int l = 0;
			while (l < tempList.Count)
			{
				bool flag4 = !tempList[l].Vars.ContainsKey("Tag");
				if (!flag4)
				{
					goto IL_2DC;
				}
				bool flag5 = tempList[l].data.ContainsKey("Tag");
				if (flag5)
				{
					tempList[l].Vars["Tag"] = tempList[l].data["Tag"];
					goto IL_2DC;
				}
				tempList[l].Vars["Tag"] = "";
				IL_36B:
				l++;
				continue;
				IL_2DC:
				GameObject gameObject3 = Singleton<ObjectPool>.Instance.Get(this.cardBox.Find("Item").gameObject, this.cardBox);
				SafeBoxItem item4 = gameObject3.GetComponent<SafeBoxItem>();
				bool flag6 = item4 == null;
				if (flag6)
				{
					item4 = gameObject3.AddComponent<SafeBoxItem>();
				}
				item4.hasInBack = true;
				item4.safeBoxUI = this;
				item4.ItemType = "Card";
				item4.tooltip = UIManager.Instance.GetTooltip();
				item4.InBackPack = false;
				item4.Init(tempList[l]);
				goto IL_36B;
			}
			for (int m = 0; m < SafeBoxUI.InCardList.Count; m++)
			{
				GameObject gameObject4 = Singleton<ObjectPool>.Instance.Get(this.cardBox.Find("Item").gameObject, this.cardBox);
				SafeBoxItem item5 = gameObject4.GetComponent<SafeBoxItem>();
				bool flag7 = item5 == null;
				if (flag7)
				{
					item5 = gameObject4.AddComponent<SafeBoxItem>();
				}
				item5.safeBoxUI = this;
				item5.ItemType = "Card";
				item5.tooltip = UIManager.Instance.GetTooltip();
				item5.InBackPack = false;
				item5.Init(SafeBoxUI.InCardList[m]);
			}
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000E49F0 File Offset: 0x000E2BF0
		[DebuggerStepThrough]
		private void SortList(List<DataConfig> relicList)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.SortList(List<DataConfig>)).MethodHandle, typeof(SafeBoxUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				relicList
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
							relicList = null;
						}
						else
						{
							relicList = (List<DataConfig>)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SortList(relicList);
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

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000E4B24 File Offset: 0x000E2D24
		[DebuggerStepThrough]
		public void LoseItem(SafeBoxItem item)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.LoseItem(SafeBoxItem)).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							item = (SafeBoxItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_LoseItem(item);
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

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000E4C58 File Offset: 0x000E2E58
		[DebuggerStepThrough]
		public void PutIntoStore(GameObject obj)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.PutIntoStore(GameObject)).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							this.$Rougamo_PutIntoStore(obj);
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

		// Token: 0x06001AC5 RID: 6853 RVA: 0x000E4D8C File Offset: 0x000E2F8C
		[DebuggerStepThrough]
		public void HideTooltip()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.HideTooltip()).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							this.$Rougamo_HideTooltip();
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

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000E4E88 File Offset: 0x000E3088
		[DebuggerStepThrough]
		public void ShowFloatingWindow(SafeBoxItem item)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.ShowFloatingWindow(SafeBoxItem)).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							item = (SafeBoxItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowFloatingWindow(item);
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

		// Token: 0x06001AC7 RID: 6855 RVA: 0x000E4FBC File Offset: 0x000E31BC
		[DebuggerStepThrough]
		public void PutItBack(GameObject obj)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SafeBoxUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SafeBoxUI.PutItBack(GameObject)).MethodHandle, typeof(SafeBoxUI).TypeHandle);
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
							this.$Rougamo_PutItBack(obj);
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

		// Token: 0x06001ACA RID: 6858 RVA: 0x0001CB6E File Offset: 0x0001AD6E
		private GameRuntimeData $Rougamo_get_gameRuntimeData()
		{
			return Singleton<GameRuntimeData>.Instance;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0009BE5B File Offset: 0x0009A05B
		private Tooltip $Rougamo_get_tooltip()
		{
			return UIManager.Instance.GetTooltip();
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000E511A File Offset: 0x000E331A
		private FloatingWindow $Rougamo_get_floatingWindow()
		{
			return UIManager.Instance.GetFloatingWindow();
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x000E5126 File Offset: 0x000E3326
		private bool $Rougamo_get_GetCard()
		{
			return RoleTable.Instance.GetCardInBack;
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x000E5132 File Offset: 0x000E3332
		private bool $Rougamo_get_GetRelic()
		{
			return RoleTable.Instance.GetRelic;
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000E5140 File Offset: 0x000E3340
		private void $Rougamo_DataUpdate()
		{
			this.ChangeMoneyShow();
			this.ChangeCountShow();
			base.transform.Find("Content/Backpack/Windows/遗物/Retain").GetComponent<ButtonManager>().SetText("Retain money".Localize("GameEntryUI"));
			base.transform.Find("Content/Backpack/Windows/遗物/Fetched").GetComponent<ButtonManager>().SetText("Withdraw money".Localize("GameEntryUI"));
			base.transform.Find("Content/Backpack/Windows/卡牌/Retain").GetComponent<ButtonManager>().SetText("Retain money".Localize("GameEntryUI"));
			base.transform.Find("Content/Backpack/Windows/卡牌/Fetched").GetComponent<ButtonManager>().SetText("Withdraw money".Localize("GameEntryUI"));
			base.transform.Find("Content/Backpack/Buttons/卡牌").GetComponent<ButtonManager>().SetText("Card Backpack".Localize("ShopUI"));
			base.transform.Find("Content/Backpack/Buttons/遗物").GetComponent<ButtonManager>().SetText("Relic Backpack".Localize("ShopUI"));
			base.transform.Find("Content/Backpack/Windows/遗物/Left/Title").GetComponentInChildren<TMP_Text>().text = "Insurance".Localize("GameEntryUI");
			base.transform.Find("Content/Backpack/Windows/遗物/Right/Title").GetComponentInChildren<TMP_Text>().text = "BackPack".Localize("GameEntryUI");
			base.transform.Find("Content/Backpack/Windows/卡牌/Left/Title").GetComponentInChildren<TMP_Text>().text = "Insurance".Localize("GameEntryUI");
			base.transform.Find("Content/Backpack/Windows/卡牌/Right/Title").GetComponentInChildren<TMP_Text>().text = "BackPack".Localize("GameEntryUI");
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000E5300 File Offset: 0x000E3500
		private void $Rougamo_Awake()
		{
			this.RegisterEvent();
			this.ShowHadItems();
			this.ShowBackItem();
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000E5318 File Offset: 0x000E3518
		private static void $Rougamo_ClearList()
		{
			SafeBoxUI.InRelicList.Clear();
			SafeBoxUI.InCardList.Clear();
			SafeBoxUI.OutCardList.Clear();
			SafeBoxUI.OutRelicList.Clear();
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000E5348 File Offset: 0x000E3548
		private static void $Rougamo_ResetCount()
		{
			bool flag = MapManager.Instance == null || MapManager.Instance.ModeMapManager == null;
			if (!flag)
			{
				IModeManager.ResetCount();
			}
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x000E5380 File Offset: 0x000E3580
		private void $Rougamo_RetainMoney()
		{
			bool flag = RoleTable.Instance.SafeBoxSaveMoneyCount <= 0;
			if (flag)
			{
				UIManager.Instance.ShowModalWindow("Tips", "休息点无法继续存入！", null, 0f, null, true, true, "Yes", "No", true);
			}
			else
			{
				bool flag2 = RoleTable.Instance.Money >= 150;
				if (flag2)
				{
					RoleTable.Instance.SafeBoxSaveMoneyCount--;
					int Count = Mathf.Min(100, RoleTable.Instance.Money / 10);
					RoleTable.Instance.Money -= Count;
					this.gameRuntimeData.Money += Count;
					this.ChangeMoneyShow();
				}
				else
				{
					UIManager.Instance.ShowModalWindow("Tips", "现在钱太少了", null, 0f, null, true, true, "Yes", "No", true);
				}
			}
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x000E548C File Offset: 0x000E368C
		private void $Rougamo_ChangeMoney()
		{
			bool flag = RoleTable.Instance.SafeBoxGetMoneyCount <= 0;
			if (flag)
			{
				UIManager.Instance.ShowModalWindow("Tips", "休息点无法继续取出！", null, 0f, null, true, true, "Yes", "No", true);
			}
			else
			{
				bool flag2 = this.gameRuntimeData.Money >= 20;
				if (flag2)
				{
					RoleTable.Instance.SafeBoxGetMoneyCount--;
					int Count = Mathf.Min(Mathf.Max(20, this.gameRuntimeData.Money / 10), 200);
					this.gameRuntimeData.Money -= Count;
					RoleTable.Instance.Money += Count / 2;
				}
				this.ChangeMoneyShow();
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000E5560 File Offset: 0x000E3760
		private void $Rougamo_ChangeMoneyShow()
		{
			base.transform.Find("Content/Backpack/Windows/卡牌/Left/Money/text").GetComponent<TMP_Text>().text = "Money in the vault".Localize("GameEntryUI") + ": " + this.gameRuntimeData.Money.ToString();
			base.transform.Find("Content/Backpack/Windows/卡牌/Right/Money/text").GetComponent<TMP_Text>().text = "Current money".Localize("GameEntryUI") + ": " + RoleTable.Instance.Money.ToString();
			base.transform.Find("Content/Backpack/Windows/遗物/Left/Money/text").GetComponent<TMP_Text>().text = "Money in the vault".Localize("GameEntryUI") + ": " + this.gameRuntimeData.Money.ToString();
			base.transform.Find("Content/Backpack/Windows/遗物/Right/Money/text").GetComponent<TMP_Text>().text = "Current money".Localize("GameEntryUI") + ": " + RoleTable.Instance.Money.ToString();
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000E5690 File Offset: 0x000E3890
		private void $Rougamo_ChangeCountShow()
		{
			base.transform.Find("Content/Backpack/Windows/卡牌/Right/SafeCount/Title").GetComponent<TMP_Text>().text = "Cards can be stored".Localize("GameEntryUI") + ": " + (3 - RoleTable.Instance.SafeBoxCardCount).ToString();
			base.transform.Find("Content/Backpack/Windows/遗物/Right/SafeCount/Title").GetComponent<TMP_Text>().text = "Relics can be stored".Localize("GameEntryUI") + ": " + (3 - RoleTable.Instance.SafeBoxRelicCount).ToString();
			string cardText = this.GetCard ? "Do not take out".Localize("GameEntryUI") : "Can bring out".Localize("GameEntryUI");
			string relicText = this.GetRelic ? "Do not take out".Localize("GameEntryUI") : "Can bring out".Localize("GameEntryUI");
			base.transform.Find("Content/Backpack/Windows/卡牌/Left/CanOut/text").GetComponent<TMP_Text>().text = cardText;
			base.transform.Find("Content/Backpack/Windows/遗物/Left/CanOut/text").GetComponent<TMP_Text>().text = relicText;
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000E57B8 File Offset: 0x000E39B8
		private void $Rougamo_ShowBackItem()
		{
			this.UpdateBackCard();
			this.UpdateBackRelic();
			this.ChangeMoneyShow();
			this.ChangeCountShow();
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000E57D7 File Offset: 0x000E39D7
		private void $Rougamo_SortList(List<DataConfig> relicList)
		{
			relicList.Sort(delegate(DataConfig left, DataConfig right)
			{
				int leftRarity = 0;
				int rightRarity = 0;
				bool flag = ((left != null) ? left.data : null) != null;
				if (flag)
				{
					int.TryParse(left.data.GetValueOrDefault("Rarity", "0"), out leftRarity);
				}
				bool flag2 = ((right != null) ? right.data : null) != null;
				if (flag2)
				{
					int.TryParse(right.data.GetValueOrDefault("Rarity", "0"), out rightRarity);
				}
				int rarityCompare = rightRarity.CompareTo(leftRarity);
				bool flag3 = rarityCompare != 0;
				int result;
				if (flag3)
				{
					result = rarityCompare;
				}
				else
				{
					string text;
					if (left == null)
					{
						text = null;
					}
					else
					{
						IDictionary<string, string> data = left.data;
						text = ((data != null) ? data.GetValueOrDefault("Id", string.Empty) : null);
					}
					string leftId = text ?? string.Empty;
					string text2;
					if (right == null)
					{
						text2 = null;
					}
					else
					{
						IDictionary<string, string> data2 = right.data;
						text2 = ((data2 != null) ? data2.GetValueOrDefault("Id", string.Empty) : null);
					}
					string rightId = text2 ?? string.Empty;
					result = Comparer<string>.Default.Compare(leftId, rightId);
				}
				return result;
			});
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x000E5800 File Offset: 0x000E3A00
		private void $Rougamo_LoseItem(SafeBoxItem item)
		{
			bool flag = item == null || item.dataConfig == null;
			if (!flag)
			{
				bool flag2 = item.ItemType == "Card";
				if (flag2)
				{
					SafeBoxUI.OutCardList.Add(item.dataConfig);
					SafeBoxUI.InCardList.Remove(item.dataConfig);
				}
				else
				{
					bool flag3 = item.ItemType == "Relic";
					if (flag3)
					{
						SafeBoxUI.OutRelicList.Add(item.dataConfig);
						SafeBoxUI.InRelicList.Remove(item.dataConfig);
					}
				}
				UnityEngine.Object.Destroy(item.gameObject);
			}
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x000E58A8 File Offset: 0x000E3AA8
		private void $Rougamo_PutIntoStore(GameObject obj)
		{
			SafeBoxItem item = obj.GetComponent<SafeBoxItem>();
			bool flag = item.ItemType == "Card";
			if (flag)
			{
				bool flag2 = MapManager.Instance.ModeMapManager.Level > 1 && ((!MapManager.Instance.WinTheGame() && item.ifEquipped && RoleTable.Instance.cardList.Count <= RoleTable.Instance.CardBottomCount) || RoleTable.Instance.SafeBoxCardCount >= 3);
				if (flag2)
				{
					bool flag3 = RoleTable.Instance.SafeBoxCardCount < 3;
					if (flag3)
					{
						UIManager.Instance.ShowModalWindow("Tips", "The number of cards has reached the lower limit", null, 0f, null, true, true, "Yes", "No", true);
						return;
					}
					UIManager.Instance.ShowModalWindow("Tips", "不允许放入更多卡牌！", null, 0f, null, true, true, "Yes", "No", true);
					return;
				}
				else
				{
					bool flag4 = MapManager.Instance.ModeMapManager.Level < 2 && !item.hasInBack;
					if (flag4)
					{
						UIManager.Instance.ShowModalWindow("Tips", "Cannot be placed at the beginning", null, 0f, null, true, true, "Yes", "No", true);
						return;
					}
					SafeBoxUI.OutCardList.Remove(item.dataConfig);
					bool flag5 = !item.hasInBack;
					if (flag5)
					{
						SafeBoxUI.InCardList.Add(item.dataConfig);
					}
					else
					{
						RoleTable.Instance.GetCardInBack = false;
						RoleTable.Instance.SafeBoxCardCount--;
					}
					obj.transform.SetParent(this.cardBox);
					bool ifEquipped = item.ifEquipped;
					if (ifEquipped)
					{
						RoleTable.Instance.cardList.Remove(item.dataConfig);
					}
					else
					{
						RoleTable.Instance.UnCardList.Remove(item.dataConfig);
					}
					RoleTable.Instance.SafeBoxCardCount++;
					item.dataConfig.ReSetVars();
				}
			}
			else
			{
				bool flag6 = RoleTable.Instance.SafeBoxRelicCount >= 3;
				if (flag6)
				{
					UIManager.Instance.ShowModalWindow("Tips", "不允许放入更多遗物！", null, 0f, null, true, true, "Yes", "No", true);
					return;
				}
				bool flag7 = MapManager.Instance.ModeMapManager.Level < 2;
				if (flag7)
				{
					RoleTable.Instance.GetRelic = false;
					RoleTable.Instance.SafeBoxRelicCount--;
				}
				SafeBoxUI.OutRelicList.Remove(item.dataConfig);
				bool flag8 = !item.hasInBack;
				if (flag8)
				{
					SafeBoxUI.InRelicList.Add(item.dataConfig);
				}
				RoleTable.Instance.relicList.Remove(item.dataConfig);
				RoleTable.Instance.WithoutArmedRelicList.Remove(item.dataConfig);
				item.dataConfig.ReSetVars();
				obj.transform.SetParent(this.relicBox);
				RoleTable.Instance.SafeBoxRelicCount++;
			}
			obj.GetComponent<SafeBoxItem>().InBackPack = false;
			this.ChangeCountShow();
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x000E5BDB File Offset: 0x000E3DDB
		private void $Rougamo_HideTooltip()
		{
			this.tooltip.Hide();
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000E5BEC File Offset: 0x000E3DEC
		private void $Rougamo_ShowFloatingWindow(SafeBoxItem item)
		{
			this.HideTooltip();
			this.floatingWindow.Clear();
			this.floatingWindow.AddButton("move", delegate()
			{
				bool inBackPack = item.InBackPack;
				if (inBackPack)
				{
					this.PutIntoStore(item.gameObject);
				}
				else
				{
					this.PutItBack(item.gameObject);
				}
				this.floatingWindow.Hide();
			}, null);
			bool flag = !item.InBackPack;
			if (flag)
			{
				this.floatingWindow.AddButton("throw", delegate()
				{
					this.LoseItem(item);
					this.floatingWindow.Hide();
				}, null);
			}
			this.floatingWindow.Show(item.transform);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x000E5C88 File Offset: 0x000E3E88
		private void $Rougamo_PutItBack(GameObject obj)
		{
			SafeBoxItem item = obj.GetComponent<SafeBoxItem>();
			bool flag = item.ItemType == "Card";
			if (flag)
			{
				bool flag2 = !item.hasInBack;
				if (flag2)
				{
					RoleTable.Instance.SafeBoxCardCount--;
				}
				else
				{
					bool getCardInBack = RoleTable.Instance.GetCardInBack;
					if (getCardInBack)
					{
						UIManager.Instance.ShowModalWindow("Tips", "不允许带入更多卡牌！", null, 0f, null, true, true, "Yes", "No", true);
						return;
					}
					RoleTable.Instance.GetCardInBack = true;
				}
				bool flag3 = RoleTable.Instance.cardList.Count >= RoleTable.Instance.CardTopCount;
				if (flag3)
				{
					bool flag4 = RoleTable.Instance.UnCardList.Count >= RoleTable.Instance.MaxAlCardCount;
					if (flag4)
					{
						UIManager.Instance.ShowModalWindow("Tips", "你的卡牌数量已达上限", null, 0f, null, true, true, "Yes", "No", true);
						return;
					}
					item.ifEquipped = false;
					RoleTable.Instance.UnCardList.Add(item.dataConfig);
				}
				else
				{
					item.ifEquipped = true;
					RoleTable.Instance.cardList.Add(item.dataConfig);
				}
				obj.transform.SetParent(this.cardBack);
				SafeBoxUI.OutCardList.Add(item.dataConfig);
				SafeBoxUI.InCardList.Remove(item.dataConfig);
			}
			else
			{
				bool flag5 = !item.hasInBack;
				if (flag5)
				{
					RoleTable.Instance.SafeBoxRelicCount--;
					Debug.Log("本来就是外面的，数量-1");
				}
				else
				{
					bool getRelic = RoleTable.Instance.GetRelic;
					if (getRelic)
					{
						UIManager.Instance.ShowModalWindow("Tips", "不允许带入更多遗物！", null, 0f, null, true, true, "Yes", "No", true);
						return;
					}
					RoleTable.Instance.GetRelic = true;
				}
				item.ifEquipped = false;
				bool flag6 = RoleTable.Instance.relicList.Count < 6;
				if (flag6)
				{
					obj.transform.SetParent(this.TopRelicPrefab.transform.parent);
				}
				else
				{
					obj.transform.SetParent(this.BottomRelicPrefab.transform.parent);
				}
				SafeBoxUI.OutRelicList.Add(item.dataConfig);
				SafeBoxUI.InRelicList.Remove(item.dataConfig);
			}
			item.InBackPack = true;
			this.ChangeCountShow();
		}

		// Token: 0x0400147A RID: 5242
		public Transform cardBack;

		// Token: 0x0400147B RID: 5243
		public Transform cardBox;

		// Token: 0x0400147C RID: 5244
		public Transform relicBox;

		// Token: 0x0400147D RID: 5245
		public GameObject TopRelicPrefab;

		// Token: 0x0400147E RID: 5246
		public GameObject BottomRelicPrefab;

		// Token: 0x0400147F RID: 5247
		private static List<DataConfig> OutCardList = new List<DataConfig>();

		// Token: 0x04001480 RID: 5248
		private static List<DataConfig> OutRelicList = new List<DataConfig>();

		// Token: 0x04001481 RID: 5249
		private static List<DataConfig> InCardList = new List<DataConfig>();

		// Token: 0x04001482 RID: 5250
		private static List<DataConfig> InRelicList = new List<DataConfig>();
	}
}

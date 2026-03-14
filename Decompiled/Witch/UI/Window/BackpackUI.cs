using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Witch.UI.Window
{
	// Token: 0x02000293 RID: 659
	public class BackpackUI : UIBase
	{
		// Token: 0x060014AB RID: 5291 RVA: 0x000A2DA8 File Offset: 0x000A0FA8
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
			methodContext.TargetType = typeof(BackpackUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BackpackUI.Awake()).MethodHandle, typeof(BackpackUI).TypeHandle);
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

		// Token: 0x060014AC RID: 5292 RVA: 0x000A2EA4 File Offset: 0x000A10A4
		[DebuggerStepThrough]
		public void ShowStatus(StatusUIData statusUIData)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BackpackUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BackpackUI.ShowStatus(StatusUIData)).MethodHandle, typeof(BackpackUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				statusUIData
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
							statusUIData = default(StatusUIData);
						}
						else
						{
							statusUIData = (StatusUIData)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowStatus(statusUIData);
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
								goto IL_105;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_105:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x000A2FE0 File Offset: 0x000A11E0
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
			methodContext.TargetType = typeof(BackpackUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BackpackUI.DataUpdate()).MethodHandle, typeof(BackpackUI).TypeHandle);
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

		// Token: 0x060014AE RID: 5294 RVA: 0x000A30DC File Offset: 0x000A12DC
		[DebuggerStepThrough]
		public void Init()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BackpackUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BackpackUI.Init()).MethodHandle, typeof(BackpackUI).TypeHandle);
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
							this.$Rougamo_Init();
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

		// Token: 0x060014AF RID: 5295 RVA: 0x000A31D8 File Offset: 0x000A13D8
		[DebuggerStepThrough]
		private void Start()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BackpackUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BackpackUI.Start()).MethodHandle, typeof(BackpackUI).TypeHandle);
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
							this.$Rougamo_Start();
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

		// Token: 0x060014B0 RID: 5296 RVA: 0x000A32D4 File Offset: 0x000A14D4
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
			methodContext.TargetType = typeof(BackpackUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BackpackUI.OnEnable()).MethodHandle, typeof(BackpackUI).TypeHandle);
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

		// Token: 0x060014B1 RID: 5297 RVA: 0x000A33D0 File Offset: 0x000A15D0
		[DebuggerStepThrough]
		private void Exit(InputAction.CallbackContext context)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BackpackUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BackpackUI.Exit(InputAction.CallbackContext)).MethodHandle, typeof(BackpackUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				context
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
							context = default(InputAction.CallbackContext);
						}
						else
						{
							context = (InputAction.CallbackContext)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Exit(context);
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
								goto IL_105;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_105:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x000A350C File Offset: 0x000A170C
		[DebuggerStepThrough]
		public override void Close()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BackpackUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BackpackUI.Close()).MethodHandle, typeof(BackpackUI).TypeHandle);
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
							this.$Rougamo_Close();
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

		// Token: 0x060014B5 RID: 5301 RVA: 0x000A3620 File Offset: 0x000A1820
		private void $Rougamo_Awake()
		{
			this.statusUI = base.transform.Find("Content/Window Manager/Windows/状态").gameObject.GetComponent<StatusUI>();
			this.statusUI.ShowMsg(new StatusUIData(RoleTable.Instance));
			base.gameObject.SetActive(false);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000A3671 File Offset: 0x000A1871
		private void $Rougamo_ShowStatus(StatusUIData statusUIData)
		{
			this.statusUI.gameObject.SetActive(true);
			this.statusUI.ShowMsg(statusUIData);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x000A3693 File Offset: 0x000A1893
		private void $Rougamo_DataUpdate()
		{
			this.statusUI.DataUpdate();
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000A36A4 File Offset: 0x000A18A4
		private void $Rougamo_Init()
		{
			this.statusUI.ShowMsg(new StatusUIData(RoleTable.Instance));
			base.transform.Find("Content/Window Manager/Windows/状态").gameObject.GetComponent<StatusUI>().Init(this);
			this.Close();
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000A36F0 File Offset: 0x000A18F0
		private void $Rougamo_Start()
		{
			base.transform.Find("Content").localScale = Vector3.zero;
			base.transform.Find("Content").DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000A3740 File Offset: 0x000A1940
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			base.transform.SetAsLastSibling();
			this.DataUpdate();
			base.transform.Find("Content").localScale = Vector3.zero;
			base.transform.Find("Content").DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000A1CCD File Offset: 0x0009FECD
		private void $Rougamo_Exit(InputAction.CallbackContext context)
		{
			this.Close();
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x000A37AA File Offset: 0x000A19AA
		private void $Rougamo_Close()
		{
			base.transform.GetComponent<CanvasGroup>().DOFade(0f, 0.2f).OnComplete(delegate
			{
				GameObject gameObject = base.gameObject;
				if (gameObject != null)
				{
					gameObject.SetActive(false);
				}
			});
		}

		// Token: 0x0400109C RID: 4252
		[HideInInspector]
		public StatusUI statusUI;
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Witch.UI.Window
{
	// Token: 0x0200028F RID: 655
	public class AcknowledgmentsUI : UIBase
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x000A1EA4 File Offset: 0x000A00A4
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
			methodContext.TargetType = typeof(AcknowledgmentsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AcknowledgmentsUI.Awake()).MethodHandle, typeof(AcknowledgmentsUI).TypeHandle);
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

		// Token: 0x06001497 RID: 5271 RVA: 0x000A1FA0 File Offset: 0x000A01A0
		[DebuggerStepThrough]
		private void Update()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(AcknowledgmentsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AcknowledgmentsUI.Update()).MethodHandle, typeof(AcknowledgmentsUI).TypeHandle);
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
							this.$Rougamo_Update();
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

		// Token: 0x06001498 RID: 5272 RVA: 0x000A209C File Offset: 0x000A029C
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
			methodContext.TargetType = typeof(AcknowledgmentsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AcknowledgmentsUI.Start()).MethodHandle, typeof(AcknowledgmentsUI).TypeHandle);
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

		// Token: 0x0600149B RID: 5275 RVA: 0x000A21B3 File Offset: 0x000A03B3
		private void $Rougamo_Awake()
		{
			base.transform.SetAsLastSibling();
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000A21C4 File Offset: 0x000A03C4
		private void $Rougamo_Update()
		{
			bool flag = Keyboard.current.anyKey.wasPressedThisFrame || KeyManager.playerAction.Main.Click.WasPressedThisFrame();
			if (flag)
			{
				base.transform.DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack).OnComplete(delegate
				{
					this.Close();
					UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
				});
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x000A2234 File Offset: 0x000A0434
		private void $Rougamo_Start()
		{
			base.transform.Find("UI/Acknowledgments").GetComponent<TMP_Text>().alpha = 0f;
			base.transform.Find("UI/Acknowledgments").GetComponent<TMP_Text>().DOFade(1f, 0.3f).SetEase(Ease.InBack);
		}
	}
}

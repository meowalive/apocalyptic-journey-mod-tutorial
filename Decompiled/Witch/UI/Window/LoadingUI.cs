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
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200035C RID: 860
	public class LoadingUI : UIBase
	{
		// Token: 0x06001B08 RID: 6920 RVA: 0x000E7074 File Offset: 0x000E5274
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
			methodContext.TargetType = typeof(LoadingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LoadingUI.Awake()).MethodHandle, typeof(LoadingUI).TypeHandle);
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

		// Token: 0x06001B09 RID: 6921 RVA: 0x000E7170 File Offset: 0x000E5370
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
			methodContext.TargetType = typeof(LoadingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LoadingUI.OnEnable()).MethodHandle, typeof(LoadingUI).TypeHandle);
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

		// Token: 0x06001B0A RID: 6922 RVA: 0x000E726C File Offset: 0x000E546C
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
			methodContext.TargetType = typeof(LoadingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LoadingUI.Close()).MethodHandle, typeof(LoadingUI).TypeHandle);
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

		// Token: 0x06001B0D RID: 6925 RVA: 0x000E7390 File Offset: 0x000E5590
		private void $Rougamo_Awake()
		{
			this.eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
			this.backGround = base.transform.Find("CG_Image").GetComponent<Image>();
			base.gameObject.GetComponent<CanvasGroup>().alpha = 0f;
			this.backGround.color = Color.black;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000E73F5 File Offset: 0x000E55F5
		private void $Rougamo_OnEnable()
		{
			this.eventSystem.enabled = false;
			base.gameObject.GetComponent<CanvasGroup>().alpha = 1f;
			this.backGround.DOColor(Color.white, 1f);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x000E7431 File Offset: 0x000E5631
		private void $Rougamo_Close()
		{
			base.gameObject.GetComponent<CanvasGroup>().DOFade(0f, 1f).OnComplete(delegate
			{
				this.eventSystem.enabled = true;
				this.backGround.color = Color.black;
				base.Close();
			});
		}

		// Token: 0x0400149C RID: 5276
		private EventSystem eventSystem;

		// Token: 0x0400149D RID: 5277
		private Image backGround;
	}
}

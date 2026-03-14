using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200035D RID: 861
	public class SceneTurnUI : UIBase
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x000E7460 File Offset: 0x000E5660
		[DebuggerStepThrough]
		public override void FadeIn()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SceneTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SceneTurnUI.FadeIn()).MethodHandle, typeof(SceneTurnUI).TypeHandle);
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
							this.$Rougamo_FadeIn();
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

		// Token: 0x06001B11 RID: 6929 RVA: 0x000E755C File Offset: 0x000E575C
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
			methodContext.TargetType = typeof(SceneTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SceneTurnUI.Update()).MethodHandle, typeof(SceneTurnUI).TypeHandle);
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

		// Token: 0x06001B12 RID: 6930 RVA: 0x000E7658 File Offset: 0x000E5858
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
			methodContext.TargetType = typeof(SceneTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SceneTurnUI.Close()).MethodHandle, typeof(SceneTurnUI).TypeHandle);
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

		// Token: 0x06001B18 RID: 6936 RVA: 0x000E77F8 File Offset: 0x000E59F8
		private void $Rougamo_FadeIn()
		{
			Color color = this.background.GetComponent<Image>().color;
			this.firstTime = Time.time;
			this.background.GetComponent<Image>().color = new Color(color.r, color.g, color.b, 1f);
			this.loading.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
			this.loading.GetComponent<Image>().DOFade(1f, 0.2f).OnKill(delegate
			{
				this.loading.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
			}).SetDelay(0.4f);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x000A21B3 File Offset: 0x000A03B3
		private void $Rougamo_Update()
		{
			base.transform.SetAsLastSibling();
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000E78B0 File Offset: 0x000E5AB0
		private void $Rougamo_Close()
		{
			UIManager.Instance.RemoveUI(base.gameObject.name);
			UniTask.WaitUntil(() => Time.time - this.firstTime > 5f, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				this.background.GetComponent<Image>().DOFade(0f, 0.5f).SetDelay(1f);
				this.loading.GetComponent<Image>().DOFade(0f, 0.5f).OnComplete(delegate
				{
					UnityEngine.Object.Destroy(base.gameObject);
				});
			}).Forget();
		}

		// Token: 0x0400149E RID: 5278
		[SerializeField]
		private GameObject background;

		// Token: 0x0400149F RID: 5279
		[SerializeField]
		private GameObject loading;

		// Token: 0x040014A0 RID: 5280
		private float firstTime;
	}
}

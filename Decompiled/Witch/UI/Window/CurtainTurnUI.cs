using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000357 RID: 855
	public class CurtainTurnUI : UIBase
	{
		// Token: 0x06001AE4 RID: 6884 RVA: 0x000E60B4 File Offset: 0x000E42B4
		[DebuggerStepThrough]
		public void Play(Action action)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CurtainTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CurtainTurnUI.Play(Action)).MethodHandle, typeof(CurtainTurnUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				action
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
							action = null;
						}
						else
						{
							action = (Action)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Play(action);
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

		// Token: 0x06001AE5 RID: 6885 RVA: 0x000E61E8 File Offset: 0x000E43E8
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
			methodContext.TargetType = typeof(CurtainTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CurtainTurnUI.OnDestroy()).MethodHandle, typeof(CurtainTurnUI).TypeHandle);
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

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000E62E4 File Offset: 0x000E44E4
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
			methodContext.TargetType = typeof(CurtainTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CurtainTurnUI.Update()).MethodHandle, typeof(CurtainTurnUI).TypeHandle);
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

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000E63E0 File Offset: 0x000E45E0
		private void $Rougamo_Play(Action action)
		{
			Stopwatch sr = Stopwatch.StartNew();
			UIManager.Instance.canvasTf.GetComponent<CanvasGroup>().blocksRaycasts = false;
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayEffect("NewSounds/UI与按钮/开拉帘");
			}
			this.CloseAnimation.OnComplete = delegate()
			{
				sr.Stop();
				Action action2 = action;
				if (action2 != null)
				{
					action2();
				}
				this.OpenAnimation.gameObject.SetActive(true);
				this.CloseAnimation.gameObject.SetActive(false);
				this.transform.SetAsLastSibling();
				AudioManager instance2 = AudioManager.Instance;
				if (instance2 != null)
				{
					instance2.PlayEffect("NewSounds/UI与按钮/关拉帘");
				}
			};
			this.OpenAnimation.OnComplete = delegate()
			{
				this.Close();
			};
			this.CloseAnimation.gameObject.SetActive(true);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000E6479 File Offset: 0x000E4679
		private void $Rougamo_OnDestroy()
		{
			this.ClearEvent();
			UIManager.Instance.canvasTf.GetComponent<CanvasGroup>().blocksRaycasts = true;
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x000A21B3 File Offset: 0x000A03B3
		private void $Rougamo_Update()
		{
			base.transform.SetAsLastSibling();
		}

		// Token: 0x04001487 RID: 5255
		public UIAnimation CloseAnimation;

		// Token: 0x04001488 RID: 5256
		public UIAnimation OpenAnimation;
	}
}

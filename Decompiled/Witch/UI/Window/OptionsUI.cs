using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x020002D0 RID: 720
	public class OptionsUI : UIBase
	{
		// Token: 0x0600163D RID: 5693 RVA: 0x000B39EC File Offset: 0x000B1BEC
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
			methodContext.TargetType = typeof(OptionsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OptionsUI.FadeIn()).MethodHandle, typeof(OptionsUI).TypeHandle);
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

		// Token: 0x0600163E RID: 5694 RVA: 0x000B3AE8 File Offset: 0x000B1CE8
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
			methodContext.TargetType = typeof(OptionsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OptionsUI.Update()).MethodHandle, typeof(OptionsUI).TypeHandle);
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

		// Token: 0x0600163F RID: 5695 RVA: 0x000B3BE4 File Offset: 0x000B1DE4
		[DebuggerStepThrough]
		public void AddOption(string text, Action action)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OptionsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OptionsUI.AddOption(string, Action)).MethodHandle, typeof(OptionsUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				text,
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
							text = null;
						}
						else
						{
							text = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							action = null;
						}
						else
						{
							action = (Action)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_AddOption(text, action);
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
								goto IL_11D;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_11D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x000B3D38 File Offset: 0x000B1F38
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
			methodContext.TargetType = typeof(OptionsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OptionsUI.Close()).MethodHandle, typeof(OptionsUI).TypeHandle);
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

		// Token: 0x06001644 RID: 5700 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_FadeIn()
		{
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x000A21B3 File Offset: 0x000A03B3
		private void $Rougamo_Update()
		{
			base.transform.SetAsLastSibling();
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x000B3E4C File Offset: 0x000B204C
		private void $Rougamo_AddOption(string text, Action action)
		{
			Transform content = base.transform.Find("Options");
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(content.Find("Item").gameObject, content);
			obj.GetComponent<CanvasGroup>().alpha = 0f;
			obj.GetComponent<CanvasGroup>().DOFade(1f, 0.5f).SetDelay((float)this.count * 0.2f);
			this.count++;
			ButtonManager button = obj.GetComponent<ButtonManager>();
			button.buttonText = text;
			button.onClick.AddListener(delegate
			{
				bool flag = this.isSelect;
				if (!flag)
				{
					this.isSelect = true;
					button.disabledCG.gameObject.SetActive(true);
					button.Interactable(false);
					this.Close();
					action();
				}
			});
			button.UpdateUI();
			obj.SetActive(true);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000B3F28 File Offset: 0x000B2128
		private void $Rougamo_Close()
		{
			UIManager.Instance.RemoveUI(base.gameObject.name);
			base.transform.DOScale(Vector3.zero, 0.3f).SetEase(Ease.InBack).OnComplete(delegate
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}).OnKill(delegate
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}).SetDelay(1f);
		}

		// Token: 0x0400118B RID: 4491
		private bool isSelect = false;

		// Token: 0x0400118C RID: 4492
		private int count = 5;
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using Witch.Mod;

namespace Witch.UI
{
	// Token: 0x02000276 RID: 630
	public class UIBase : MonoBehaviour, ILocalize, IModifiable, IRougamo<Modifiable>
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0009C398 File Offset: 0x0009A598
		protected Dice dice
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
				methodContext.TargetType = typeof(UIBase);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.get_dice()).MethodHandle, typeof(UIBase).TypeHandle);
				methodContext.Arguments = new object[0];
				Dice dice;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						dice = (Dice)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								dice = this.$Rougamo_get_dice();
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
									dice = (Dice)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = dice;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							dice = (Dice)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return dice;
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0009C4D8 File Offset: 0x0009A6D8
		[DebuggerStepThrough]
		protected UIEventTrigger Register(string name)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.Register(string)).MethodHandle, typeof(UIBase).TypeHandle);
			methodContext.Arguments = new object[]
			{
				name
			};
			UIEventTrigger uieventTrigger;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					uieventTrigger = (UIEventTrigger)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							name = null;
						}
						else
						{
							name = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							uieventTrigger = this.$Rougamo_Register(name);
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
								uieventTrigger = (UIEventTrigger)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_13B;
							}
							throw;
						}
						methodContext.ReturnValue = uieventTrigger;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						uieventTrigger = (UIEventTrigger)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_13B:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return uieventTrigger;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0009C648 File Offset: 0x0009A848
		[DebuggerStepThrough]
		public virtual void Show()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.Show()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_Show();
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

		// Token: 0x06001402 RID: 5122 RVA: 0x0009C744 File Offset: 0x0009A944
		[DebuggerStepThrough]
		public void CheckVideo()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.CheckVideo()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_CheckVideo();
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

		// Token: 0x06001403 RID: 5123 RVA: 0x0009C840 File Offset: 0x0009AA40
		[DebuggerStepThrough]
		public void UpperBlock()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.UpperBlock()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_UpperBlock();
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

		// Token: 0x06001404 RID: 5124 RVA: 0x0009C93C File Offset: 0x0009AB3C
		[DebuggerStepThrough]
		public void CancelUpperBlock()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.CancelUpperBlock()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_CancelUpperBlock();
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

		// Token: 0x06001405 RID: 5125 RVA: 0x0009CA38 File Offset: 0x0009AC38
		[DebuggerStepThrough]
		public virtual void FadeIn()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.FadeIn()).MethodHandle, typeof(UIBase).TypeHandle);
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

		// Token: 0x06001406 RID: 5126 RVA: 0x0009CB34 File Offset: 0x0009AD34
		[DebuggerStepThrough]
		private void PlayCustomFadeIn(GameObject target)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.PlayCustomFadeIn(GameObject)).MethodHandle, typeof(UIBase).TypeHandle);
			methodContext.Arguments = new object[]
			{
				target
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
							target = null;
						}
						else
						{
							target = (GameObject)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_PlayCustomFadeIn(target);
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

		// Token: 0x06001407 RID: 5127 RVA: 0x0009CC68 File Offset: 0x0009AE68
		[DebuggerStepThrough]
		private void PlayCustomFadeOut(GameObject target, Action callback)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.PlayCustomFadeOut(GameObject, Action)).MethodHandle, typeof(UIBase).TypeHandle);
			methodContext.Arguments = new object[]
			{
				target,
				callback
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
							target = null;
						}
						else
						{
							target = (GameObject)arguments[0];
						}
						if (arguments[1] == null)
						{
							callback = null;
						}
						else
						{
							callback = (Action)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_PlayCustomFadeOut(target, callback);
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

		// Token: 0x06001408 RID: 5128 RVA: 0x0009CDBC File Offset: 0x0009AFBC
		[DebuggerStepThrough]
		public virtual void FadeOut(Action callback)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.FadeOut(Action)).MethodHandle, typeof(UIBase).TypeHandle);
			methodContext.Arguments = new object[]
			{
				callback
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
							callback = null;
						}
						else
						{
							callback = (Action)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_FadeOut(callback);
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

		// Token: 0x06001409 RID: 5129 RVA: 0x0009CEF0 File Offset: 0x0009B0F0
		[DebuggerStepThrough]
		public virtual void Hide()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.Hide()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_Hide();
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

		// Token: 0x0600140A RID: 5130 RVA: 0x0009CFEC File Offset: 0x0009B1EC
		[DebuggerStepThrough]
		public virtual void Close()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.Close()).MethodHandle, typeof(UIBase).TypeHandle);
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

		// Token: 0x0600140B RID: 5131 RVA: 0x0009D0E8 File Offset: 0x0009B2E8
		[DebuggerStepThrough]
		public void CloseWithCallback(Action callback)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.CloseWithCallback(Action)).MethodHandle, typeof(UIBase).TypeHandle);
			methodContext.Arguments = new object[]
			{
				callback
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
							callback = null;
						}
						else
						{
							callback = (Action)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CloseWithCallback(callback);
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

		// Token: 0x0600140C RID: 5132 RVA: 0x0009D21C File Offset: 0x0009B41C
		[DebuggerStepThrough]
		public virtual void OnEnable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.OnEnable()).MethodHandle, typeof(UIBase).TypeHandle);
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

		// Token: 0x0600140D RID: 5133 RVA: 0x0009D318 File Offset: 0x0009B518
		[DebuggerStepThrough]
		public void Help()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.Help()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_Help();
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

		// Token: 0x0600140E RID: 5134 RVA: 0x0009D414 File Offset: 0x0009B614
		[DebuggerStepThrough]
		public virtual void DataUpdate()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.DataUpdate()).MethodHandle, typeof(UIBase).TypeHandle);
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

		// Token: 0x0600140F RID: 5135 RVA: 0x0009D510 File Offset: 0x0009B710
		[DebuggerStepThrough]
		public virtual void RegisterEvent()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.RegisterEvent()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_RegisterEvent();
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

		// Token: 0x06001410 RID: 5136 RVA: 0x0009D60C File Offset: 0x0009B80C
		[DebuggerStepThrough]
		public virtual void ClearEvent()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.ClearEvent()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_ClearEvent();
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

		// Token: 0x06001411 RID: 5137 RVA: 0x0009D708 File Offset: 0x0009B908
		[DebuggerStepThrough]
		public virtual void OnDisable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.OnDisable()).MethodHandle, typeof(UIBase).TypeHandle);
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
							this.$Rougamo_OnDisable();
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

		// Token: 0x06001412 RID: 5138 RVA: 0x0009D804 File Offset: 0x0009BA04
		[DebuggerStepThrough]
		public virtual void OnDestroy()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.OnDestroy()).MethodHandle, typeof(UIBase).TypeHandle);
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

		// Token: 0x06001413 RID: 5139 RVA: 0x0009D900 File Offset: 0x0009BB00
		private void OnPlayerLoopA(VideoPlayer vp)
		{
			bool flag = this.videoPlayer2 == null;
			if (!flag)
			{
				try
				{
					bool isPlaying = this.videoPlayer.isPlaying;
					if (isPlaying)
					{
						this.videoPlayer.Stop();
					}
					this.videoPlayer2.time = 0.0;
					bool flag2 = !this.videoPlayer2.isPrepared;
					if (flag2)
					{
						this.videoPlayer2.Prepare();
					}
					else
					{
						this.videoPlayer2.Play();
					}
					this.backgroundRawImage.texture = this.renderTextureB;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0009D9A8 File Offset: 0x0009BBA8
		private void OnPlayerLoopB(VideoPlayer vp)
		{
			bool flag = this.videoPlayer == null;
			if (!flag)
			{
				try
				{
					bool isPlaying = this.videoPlayer2.isPlaying;
					if (isPlaying)
					{
						this.videoPlayer2.Stop();
					}
					this.videoPlayer.time = 0.0;
					bool flag2 = !this.videoPlayer.isPrepared;
					if (flag2)
					{
						this.videoPlayer.Prepare();
					}
					else
					{
						this.videoPlayer.Play();
					}
					this.backgroundRawImage.texture = this.renderTexture;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0009DA50 File Offset: 0x0009BC50
		[DebuggerStepThrough]
		protected void Log(string msg)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(UIBase);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(UIBase.Log(string)).MethodHandle, typeof(UIBase).TypeHandle);
			methodContext.Arguments = new object[]
			{
				msg
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
							msg = null;
						}
						else
						{
							msg = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Log(msg);
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

		// Token: 0x06001416 RID: 5142 RVA: 0x0009DB84 File Offset: 0x0009BD84
		[DebuggerStepThrough]
		private UniTask WaitForAnimationComplete(AnimationState state, Action callback)
		{
			UIBase.<WaitForAnimationComplete>d__38 <WaitForAnimationComplete>d__ = new UIBase.<WaitForAnimationComplete>d__38();
			<WaitForAnimationComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForAnimationComplete>d__.<>4__this = this;
			<WaitForAnimationComplete>d__.state = state;
			<WaitForAnimationComplete>d__.callback = callback;
			<WaitForAnimationComplete>d__.<>1__state = -1;
			<WaitForAnimationComplete>d__.<>t__builder.Start<UIBase.<WaitForAnimationComplete>d__38>(ref <WaitForAnimationComplete>d__);
			return <WaitForAnimationComplete>d__.<>t__builder.Task;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00009305 File Offset: 0x00007505
		private Dice $Rougamo_get_dice()
		{
			return MapManager.Instance.NowDice;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0009DCA8 File Offset: 0x0009BEA8
		private UIEventTrigger $Rougamo_Register(string name)
		{
			Transform tf = base.transform.Find(name);
			return UIEventTrigger.Get(tf.gameObject);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0009DCD4 File Offset: 0x0009BED4
		private void $Rougamo_Show()
		{
			bool isUpperUI = this.IsUpperUI;
			if (isUpperUI)
			{
				base.gameObject.layer = LayerMask.NameToLayer("UpperUI");
				base.transform.SetParent(UIManager.Instance.upperCanvasTf.transform);
				this.UpperBlock();
			}
			else
			{
				bool flag = !this.isScene;
				if (flag)
				{
					base.transform.SetParent(UIManager.Instance.canvasTf.transform);
					base.gameObject.layer = LayerMask.NameToLayer("UI");
				}
			}
			base.transform.localScale = Vector3.one;
			this.FadeIn();
			base.gameObject.SetActive(true);
			this.CheckVideo();
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0009DD94 File Offset: 0x0009BF94
		private void $Rougamo_CheckVideo()
		{
			bool flag = this.NeedVideo && this.videoPlayer != null;
			if (flag)
			{
				bool flag2 = this.videoPlayer2 != null;
				if (flag2)
				{
					bool flag3 = this.renderTexture == null;
					if (flag3)
					{
						this.renderTexture = new RenderTexture(1920, 1080, 0);
						this.renderTexture.Create();
					}
					bool flag4 = this.renderTextureB == null;
					if (flag4)
					{
						this.renderTextureB = new RenderTexture(1920, 1080, 0);
						this.renderTextureB.Create();
					}
					this.videoPlayer.renderMode = VideoRenderMode.RenderTexture;
					this.videoPlayer.targetTexture = this.renderTexture;
					this.videoPlayer2.renderMode = VideoRenderMode.RenderTexture;
					this.videoPlayer2.targetTexture = this.renderTextureB;
					this.backgroundRawImage.texture = this.renderTexture;
					this.videoPlayer.isLooping = false;
					this.videoPlayer2.isLooping = false;
					this.videoPlayer.skipOnDrop = true;
					this.videoPlayer2.skipOnDrop = true;
					bool flag5 = !this.videoDoubleSetup;
					if (flag5)
					{
						this.videoPlayer.loopPointReached += this.OnPlayerLoopA;
						this.videoPlayer2.loopPointReached += this.OnPlayerLoopB;
						this.videoDoubleSetup = true;
					}
					bool flag6 = !this.videoPlayer.isPrepared;
					if (flag6)
					{
						this.videoPlayer.Prepare();
					}
					bool flag7 = !this.videoPlayer2.isPrepared;
					if (flag7)
					{
						this.videoPlayer2.Prepare();
					}
					bool isPrepared = this.videoPlayer.isPrepared;
					if (isPrepared)
					{
						bool flag8 = !this.videoPlayer.isPlaying;
						if (flag8)
						{
							this.videoPlayer.Play();
						}
					}
					else
					{
						this.videoPlayer.Play();
						bool flag9 = !this.videoPlayer.isPlaying && !this.videoPlayer.isPrepared;
						if (flag9)
						{
							this.videoPlayer.Prepare();
						}
					}
				}
				else
				{
					bool flag10 = this.renderTexture == null;
					if (flag10)
					{
						this.renderTexture = new RenderTexture(1920, 1080, 0);
						this.renderTexture.Create();
					}
					this.videoPlayer.renderMode = VideoRenderMode.RenderTexture;
					this.videoPlayer.targetTexture = this.renderTexture;
					this.backgroundRawImage.texture = this.renderTexture;
					this.videoPlayer.isLooping = true;
					this.videoPlayer.skipOnDrop = true;
					this.videoPlayer.Play();
				}
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0009E054 File Offset: 0x0009C254
		private void $Rougamo_UpperBlock()
		{
			GameObject[] roots = SceneManager.GetActiveScene().GetRootGameObjects();
			foreach (GameObject item in roots)
			{
				bool flag = item.name == "Upper Canvas";
				if (!flag)
				{
					CanvasGroup cg;
					bool flag2 = item.TryGetComponent<CanvasGroup>(out cg);
					if (flag2)
					{
						cg.blocksRaycasts = false;
					}
				}
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0009E0BC File Offset: 0x0009C2BC
		private void $Rougamo_CancelUpperBlock()
		{
			GameObject[] roots = SceneManager.GetActiveScene().GetRootGameObjects();
			foreach (GameObject item in roots)
			{
				bool flag = item.name == "Upper Canvas";
				if (!flag)
				{
					CanvasGroup cg;
					bool flag2 = item.TryGetComponent<CanvasGroup>(out cg);
					if (flag2)
					{
						cg.blocksRaycasts = true;
					}
				}
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0009E124 File Offset: 0x0009C324
		private void $Rougamo_FadeIn()
		{
			base.transform.DOKill(false);
			bool flag = this.isScene;
			if (flag)
			{
				bool flag2 = base.transform.Find("Content") == null;
				if (!flag2)
				{
					bool flag3 = base.transform.Find("Content").GetComponent<CanvasGroup>() == null;
					if (flag3)
					{
						base.transform.Find("Content").gameObject.AddComponent<CanvasGroup>();
					}
					base.transform.Find("Content").GetComponent<CanvasGroup>().blocksRaycasts = true;
					bool flag4 = this.animationType == UIBase.AnimationType.Fade;
					if (flag4)
					{
						base.transform.Find("Content").GetComponent<CanvasGroup>().alpha = 0f;
						base.transform.Find("Content").GetComponent<CanvasGroup>().DOFade(1f, 0.3f);
					}
					else
					{
						bool flag5 = this.animationType == UIBase.AnimationType.Custom && this.fadeInAnim != null;
						if (flag5)
						{
							this.PlayCustomFadeIn(base.transform.Find("Content").gameObject);
						}
					}
				}
			}
			else
			{
				bool flag6 = base.GetComponent<CanvasGroup>() == null;
				if (flag6)
				{
					base.gameObject.AddComponent<CanvasGroup>();
				}
				base.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
				bool flag7 = this.animationType == UIBase.AnimationType.None;
				if (!flag7)
				{
					bool flag8 = this.animationType == UIBase.AnimationType.Fade;
					if (flag8)
					{
						base.gameObject.GetComponent<CanvasGroup>().alpha = 0f;
						base.gameObject.GetComponent<CanvasGroup>().DOFade(1f, 0.3f);
					}
					else
					{
						bool flag9 = this.animationType == UIBase.AnimationType.Custom && this.fadeInAnim != null;
						if (flag9)
						{
							this.PlayCustomFadeIn(base.gameObject);
						}
					}
				}
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0009E310 File Offset: 0x0009C510
		private void $Rougamo_PlayCustomFadeIn(GameObject target)
		{
			Animation anim = target.GetComponent<Animation>();
			bool flag = anim == null;
			if (flag)
			{
				anim = target.AddComponent<Animation>();
			}
			anim.Play(this.fadeInAnim.name);
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0009E34C File Offset: 0x0009C54C
		private void $Rougamo_PlayCustomFadeOut(GameObject target, Action callback)
		{
			Animation anim = target.GetComponent<Animation>();
			bool flag = anim == null;
			if (flag)
			{
				anim = target.AddComponent<Animation>();
			}
			anim.Play(this.fadeOutAnim.name);
			AnimationState state = anim[this.fadeOutAnim.name];
			this.WaitForAnimationComplete(state, callback).Forget();
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0009E3A8 File Offset: 0x0009C5A8
		private void $Rougamo_FadeOut(Action callback)
		{
			base.transform.DOKill(false);
			bool flag = this.isScene;
			if (flag)
			{
				bool flag2 = base.transform.Find("Content") == null;
				if (!flag2)
				{
					bool flag3 = base.transform.Find("Content").GetComponent<CanvasGroup>() == null;
					if (flag3)
					{
						base.transform.Find("Content").gameObject.AddComponent<CanvasGroup>();
					}
					bool flag4 = this.animationType == UIBase.AnimationType.None;
					if (flag4)
					{
						callback();
					}
					else
					{
						base.transform.Find("Content").GetComponent<CanvasGroup>().blocksRaycasts = false;
						bool flag5 = this.animationType == UIBase.AnimationType.Fade;
						if (flag5)
						{
							base.transform.Find("Content").GetComponent<CanvasGroup>().DOFade(0f, 0.3f).OnComplete(delegate
							{
								callback();
							}).OnKill(delegate
							{
								callback();
							});
						}
						else
						{
							bool flag6 = this.animationType == UIBase.AnimationType.Custom && this.fadeOutAnim != null;
							if (flag6)
							{
								this.PlayCustomFadeOut(base.transform.Find("Content").gameObject, callback);
							}
							else
							{
								callback();
							}
						}
					}
				}
			}
			else
			{
				bool flag7 = base.GetComponent<CanvasGroup>() == null;
				if (flag7)
				{
					base.gameObject.AddComponent<CanvasGroup>();
				}
				bool flag8 = this.animationType == UIBase.AnimationType.None;
				if (flag8)
				{
					callback();
				}
				else
				{
					base.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
					bool flag9 = this.animationType == UIBase.AnimationType.Fade;
					if (flag9)
					{
						base.gameObject.GetComponent<CanvasGroup>().DOFade(0f, 0.3f).OnComplete(delegate
						{
							callback();
						}).OnKill(delegate
						{
							callback();
						});
					}
					else
					{
						bool flag10 = this.animationType == UIBase.AnimationType.Custom && this.fadeOutAnim != null;
						if (flag10)
						{
							this.PlayCustomFadeOut(base.gameObject, callback);
						}
						else
						{
							base.gameObject.GetComponent<CanvasGroup>().DOFade(0f, 1f).OnComplete(delegate
							{
								callback();
							}).OnKill(delegate
							{
								callback();
							});
						}
					}
				}
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0009E63E File Offset: 0x0009C83E
		private void $Rougamo_Hide()
		{
			this.FadeOut(delegate
			{
				base.gameObject.SetActive(false);
			});
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0009E654 File Offset: 0x0009C854
		private void $Rougamo_Close()
		{
			bool flag = this.isClosed;
			if (!flag)
			{
				this.isClosed = true;
				AudioManager.Instance.PlayEffect("NewSounds/UI与按钮/退出UI");
				UIManager.Instance.GetFloatingWindow().Hide();
				bool flag2 = UIManager.Instance != null && !this.IsNull("Object");
				if (flag2)
				{
					UIManager.Instance.RemoveUI(base.gameObject.name);
				}
				this.FadeOut(delegate
				{
					bool flag3 = this != null && base.gameObject != null;
					if (flag3)
					{
						UnityEngine.Object.Destroy(base.gameObject);
					}
				});
			}
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0009E6E4 File Offset: 0x0009C8E4
		private void $Rougamo_CloseWithCallback(Action callback)
		{
			bool flag = this.isClosed;
			if (!flag)
			{
				this.isClosed = true;
				AudioManager.Instance.PlayEffect("NewSounds/UI与按钮/退出UI");
				UIManager.Instance.GetFloatingWindow().Hide();
				bool flag2 = UIManager.Instance != null && !this.IsNull("Object");
				if (flag2)
				{
					UIManager.Instance.RemoveUI(base.gameObject.name);
				}
				this.FadeOut(delegate
				{
					bool flag3 = this != null && this.gameObject != null;
					if (flag3)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						callback();
					}
				});
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0009E786 File Offset: 0x0009C986
		private void $Rougamo_OnEnable()
		{
			Singleton<EventCenter>.Instance.EventTrigger("UIOpen-" + base.gameObject.name.Replace("(Clone)", ""));
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0009E7B8 File Offset: 0x0009C9B8
		private void $Rougamo_Help()
		{
			Singleton<EventCenter>.Instance.EventTrigger("UIHelp-" + base.gameObject.name.Replace("(Clone)", ""));
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_DataUpdate()
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0009E7EC File Offset: 0x0009C9EC
		private void $Rougamo_RegisterEvent()
		{
			Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
			bool flag = this.isScene;
			if (flag)
			{
				Singleton<EventCenter>.Instance.AddEventListener("ResolutionChanged", delegate()
				{
					bool flag2 = (float)Screen.width / (float)Screen.height != 1.7777778f;
					if (flag2)
					{
						base.transform.GetComponent<RectTransform>().localScale = new Vector3((float)Screen.width * 9f / ((float)Screen.height * 16f) * 1.02f, 1.02f, 1f);
					}
				}, this, EventDispose.None);
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00004B9C File Offset: 0x00002D9C
		private void $Rougamo_ClearEvent()
		{
			Singleton<EventCenter>.Instance.Clear(this);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0009E850 File Offset: 0x0009CA50
		private void $Rougamo_OnDisable()
		{
			bool isUpperUI = this.IsUpperUI;
			if (isUpperUI)
			{
				this.CancelUpperBlock();
			}
			Singleton<EventCenter>.Instance.EventTrigger("UIClose-" + base.gameObject.name.Replace("(Clone)", ""));
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0009E8A0 File Offset: 0x0009CAA0
		private void $Rougamo_OnDestroy()
		{
			bool flag = this.videoDoubleSetup;
			if (flag)
			{
				bool flag2 = this.videoPlayer != null;
				if (flag2)
				{
					this.videoPlayer.loopPointReached -= this.OnPlayerLoopA;
				}
				bool flag3 = this.videoPlayer2 != null;
				if (flag3)
				{
					this.videoPlayer2.loopPointReached -= this.OnPlayerLoopB;
				}
				this.videoDoubleSetup = false;
			}
			bool flag4 = this.renderTexture != null;
			if (flag4)
			{
				this.renderTexture.Release();
				UnityEngine.Object.Destroy(this.renderTexture);
				bool flag5 = this.videoPlayer != null;
				if (flag5)
				{
					this.videoPlayer.targetTexture = null;
				}
				this.renderTexture = null;
			}
			bool flag6 = this.renderTextureB != null;
			if (flag6)
			{
				this.renderTextureB.Release();
				UnityEngine.Object.Destroy(this.renderTextureB);
				bool flag7 = this.videoPlayer2 != null;
				if (flag7)
				{
					this.videoPlayer2.targetTexture = null;
				}
				this.renderTextureB = null;
			}
			this.ClearEvent();
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0009E9BA File Offset: 0x0009CBBA
		private void $Rougamo_Log(string msg)
		{
			Debug.Log("[" + base.GetType().Name + "] " + msg);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0009E9E0 File Offset: 0x0009CBE0
		private UniTask $Rougamo_WaitForAnimationComplete(AnimationState state, Action callback)
		{
			UIBase.<$Rougamo_WaitForAnimationComplete>d__49 <$Rougamo_WaitForAnimationComplete>d__ = new UIBase.<$Rougamo_WaitForAnimationComplete>d__49();
			<$Rougamo_WaitForAnimationComplete>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<$Rougamo_WaitForAnimationComplete>d__.<>4__this = this;
			<$Rougamo_WaitForAnimationComplete>d__.state = state;
			<$Rougamo_WaitForAnimationComplete>d__.callback = callback;
			<$Rougamo_WaitForAnimationComplete>d__.<>1__state = -1;
			<$Rougamo_WaitForAnimationComplete>d__.<>t__builder.Start<UIBase.<$Rougamo_WaitForAnimationComplete>d__49>(ref <$Rougamo_WaitForAnimationComplete>d__);
			return <$Rougamo_WaitForAnimationComplete>d__.<>t__builder.Task;
		}

		// Token: 0x04001039 RID: 4153
		[Header("淡入淡出类型")]
		public UIBase.AnimationType animationType = UIBase.AnimationType.Fade;

		// Token: 0x0400103A RID: 4154
		[UnityInject(false)]
		[ConditionalShow("animationType", 3)]
		[Header("自定义动画")]
		public AnimationClip fadeInAnim;

		// Token: 0x0400103B RID: 4155
		[UnityInject(false)]
		[ConditionalShow("animationType", 3)]
		public AnimationClip fadeOutAnim;

		// Token: 0x0400103C RID: 4156
		[Header("是否为上层UI")]
		public bool IsUpperUI;

		// Token: 0x0400103D RID: 4157
		public bool isScene = false;

		// Token: 0x0400103E RID: 4158
		private bool isClosed = false;

		// Token: 0x0400103F RID: 4159
		public bool NeedVideo = false;

		// Token: 0x04001040 RID: 4160
		public VideoPlayer videoPlayer;

		// Token: 0x04001041 RID: 4161
		public RawImage backgroundRawImage;

		// Token: 0x04001042 RID: 4162
		public VideoPlayer videoPlayer2;

		// Token: 0x04001043 RID: 4163
		private RenderTexture renderTexture;

		// Token: 0x04001044 RID: 4164
		private RenderTexture renderTextureB;

		// Token: 0x04001045 RID: 4165
		private bool videoDoubleSetup = false;

		// Token: 0x02000277 RID: 631
		public enum AnimationType
		{
			// Token: 0x04001047 RID: 4167
			Fade,
			// Token: 0x04001048 RID: 4168
			None,
			// Token: 0x04001049 RID: 4169
			WaitCurtain,
			// Token: 0x0400104A RID: 4170
			Custom
		}
	}
}

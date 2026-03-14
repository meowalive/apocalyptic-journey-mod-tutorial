using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Network.Query;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Witch.UI.Window
{
	// Token: 0x020002D9 RID: 729
	public class EventUI : UIBase
	{
		// Token: 0x0600169B RID: 5787 RVA: 0x000B80D0 File Offset: 0x000B62D0
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
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.Awake()).MethodHandle, typeof(EventUI).TypeHandle);
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

		// Token: 0x0600169C RID: 5788 RVA: 0x000B81CC File Offset: 0x000B63CC
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
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.FadeIn()).MethodHandle, typeof(EventUI).TypeHandle);
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

		// Token: 0x0600169D RID: 5789 RVA: 0x000B82C8 File Offset: 0x000B64C8
		[DebuggerStepThrough]
		private void CreateRole(ValueTuple<string, DataConfig>[] roleList)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.CreateRole(ValueTuple<string, DataConfig>[])).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				roleList
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
							roleList = null;
						}
						else
						{
							roleList = (ValueTuple<string, DataConfig>[])arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateRole(roleList);
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

		// Token: 0x0600169E RID: 5790 RVA: 0x000B83FC File Offset: 0x000B65FC
		public void Init(string id)
		{
			foreach (object obj in base.transform.Find("Windows/Map0/Content/Selector"))
			{
				Transform child = (Transform)obj;
				child.gameObject.SetActive(false);
			}
			this.thisid = id;
			this.dataConfig = new DataConfig(id, DataType.Event);
			this.dataConfig.scriptExecutor.RunScript("InitScript");
			base.transform.Find("Windows/Map0/Content/Title").GetComponent<TMP_Text>().SetLocalizedText(() => this.dataConfig.data.Localize("Name"));
			this.ShowChoices();
			this.ShowStr("Windows/Map0/Content/Description/");
			Singleton<GameRuntimeData>.Instance.MeetEvents.TryAdd(this.dataConfig.data["Id"], true);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000B84F8 File Offset: 0x000B66F8
		[DebuggerStepThrough]
		public void ContinueEvent(string id)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.ContinueEvent(string)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				id
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
							id = null;
						}
						else
						{
							id = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ContinueEvent(id);
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

		// Token: 0x060016A0 RID: 5792 RVA: 0x000B862C File Offset: 0x000B682C
		[DebuggerStepThrough]
		public void Entry()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.Entry()).MethodHandle, typeof(EventUI).TypeHandle);
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
							this.$Rougamo_Entry();
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

		// Token: 0x060016A1 RID: 5793 RVA: 0x000B8728 File Offset: 0x000B6928
		[DebuggerStepThrough]
		public void TryChangeMap()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.TryChangeMap()).MethodHandle, typeof(EventUI).TypeHandle);
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
							this.$Rougamo_TryChangeMap();
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

		// Token: 0x060016A2 RID: 5794 RVA: 0x000B8824 File Offset: 0x000B6A24
		[DebuggerStepThrough]
		public void AnnounceEventDone()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.AnnounceEventDone()).MethodHandle, typeof(EventUI).TypeHandle);
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
							this.$Rougamo_AnnounceEventDone();
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

		// Token: 0x060016A3 RID: 5795 RVA: 0x000B8920 File Offset: 0x000B6B20
		[DebuggerStepThrough]
		private void ShowChoices()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.ShowChoices()).MethodHandle, typeof(EventUI).TypeHandle);
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
							this.$Rougamo_ShowChoices();
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

		// Token: 0x060016A4 RID: 5796 RVA: 0x000B8A1C File Offset: 0x000B6C1C
		[DebuggerStepThrough]
		private void ButtonClickEffect(Transform button)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.ButtonClickEffect(Transform)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				button
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
							button = null;
						}
						else
						{
							button = (Transform)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ButtonClickEffect(button);
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

		// Token: 0x060016A5 RID: 5797 RVA: 0x000B8B50 File Offset: 0x000B6D50
		[DebuggerStepThrough]
		private void SetAllText(Transform option, string type, string value)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.SetAllText(Transform, string, string)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				option,
				type,
				value
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
							option = null;
						}
						else
						{
							option = (Transform)arguments[0];
						}
						if (arguments[1] == null)
						{
							type = null;
						}
						else
						{
							type = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							value = null;
						}
						else
						{
							value = (string)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetAllText(option, type, value);
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
								goto IL_13D;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_13D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000B8CC4 File Offset: 0x000B6EC4
		[DebuggerStepThrough]
		private string ReturnByArbitrary(string compare)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.ReturnByArbitrary(string)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				compare
			};
			string text;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					text = (string)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							compare = null;
						}
						else
						{
							compare = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							text = this.$Rougamo_ReturnByArbitrary(compare);
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
								text = (string)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_13B;
							}
							throw;
						}
						methodContext.ReturnValue = text;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						text = (string)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_13B:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return text;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x000B8E34 File Offset: 0x000B7034
		[DebuggerStepThrough]
		private unsafe void ResolveDescription(string description, out string main, out string tip, out string subtip, out string add, out string Image)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.ResolveDescription(string, string*, string*, string*, string*, string*)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				description,
				main,
				tip,
				subtip,
				add,
				Image
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
							description = null;
						}
						else
						{
							description = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							main = null;
						}
						else
						{
							main = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							tip = null;
						}
						else
						{
							tip = (string)arguments[2];
						}
						if (arguments[3] == null)
						{
							subtip = null;
						}
						else
						{
							subtip = (string)arguments[3];
						}
						if (arguments[4] == null)
						{
							add = null;
						}
						else
						{
							add = (string)arguments[4];
						}
						if (arguments[5] == null)
						{
							Image = null;
						}
						else
						{
							Image = (string)arguments[5];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ResolveDescription(description, out main, out tip, out subtip, out add, out Image);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							object[] arguments2 = methodContext.Arguments;
							arguments2[1] = main;
							arguments2[2] = tip;
							arguments2[3] = subtip;
							arguments2[4] = add;
							arguments2[5] = Image;
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_1F2;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
						object[] arguments3 = methodContext.Arguments;
						arguments3[1] = main;
						arguments3[2] = tip;
						arguments3[3] = subtip;
						arguments3[4] = add;
						arguments3[5] = Image;
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_1F2:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000B9074 File Offset: 0x000B7274
		[DebuggerStepThrough]
		private void Chicked(GameObject tempObj, string index)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.Chicked(GameObject, string)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				tempObj,
				index
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
							tempObj = null;
						}
						else
						{
							tempObj = (GameObject)arguments[0];
						}
						if (arguments[1] == null)
						{
							index = null;
						}
						else
						{
							index = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Chicked(tempObj, index);
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

		// Token: 0x060016A9 RID: 5801 RVA: 0x000B91C8 File Offset: 0x000B73C8
		[DebuggerStepThrough]
		public void LockChoice(string index)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.LockChoice(string)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				index
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
							index = null;
						}
						else
						{
							index = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_LockChoice(index);
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

		// Token: 0x060016AA RID: 5802 RVA: 0x000B92FC File Offset: 0x000B74FC
		[DebuggerStepThrough]
		public void EndEvent()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.EndEvent()).MethodHandle, typeof(EventUI).TypeHandle);
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
							this.$Rougamo_EndEvent();
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

		// Token: 0x060016AB RID: 5803 RVA: 0x000B93F8 File Offset: 0x000B75F8
		[DebuggerStepThrough]
		public void ChangeSubtip(string subtip)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.ChangeSubtip(string)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				subtip
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
							subtip = null;
						}
						else
						{
							subtip = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ChangeSubtip(subtip);
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

		// Token: 0x060016AC RID: 5804 RVA: 0x000B952C File Offset: 0x000B772C
		[DebuggerStepThrough]
		private void ShowStr(string name)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.ShowStr(string)).MethodHandle, typeof(EventUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				name
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
							this.$Rougamo_ShowStr(name);
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

		// Token: 0x060016AD RID: 5805 RVA: 0x000B9660 File Offset: 0x000B7860
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
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.DataUpdate()).MethodHandle, typeof(EventUI).TypeHandle);
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

		// Token: 0x060016AE RID: 5806 RVA: 0x000B975C File Offset: 0x000B795C
		[DebuggerStepThrough]
		public override void RegisterEvent()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.RegisterEvent()).MethodHandle, typeof(EventUI).TypeHandle);
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

		// Token: 0x060016AF RID: 5807 RVA: 0x000B9858 File Offset: 0x000B7A58
		[DebuggerStepThrough]
		public override void ClearEvent()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.ClearEvent()).MethodHandle, typeof(EventUI).TypeHandle);
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

		// Token: 0x060016B0 RID: 5808 RVA: 0x000B9954 File Offset: 0x000B7B54
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
			methodContext.TargetType = typeof(EventUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EventUI.OnDestroy()).MethodHandle, typeof(EventUI).TypeHandle);
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

		// Token: 0x060016B4 RID: 5812 RVA: 0x000B9AB0 File Offset: 0x000B7CB0
		private void $Rougamo_Awake()
		{
			bool flag = GameApp.Instance.NowBackground != null;
			if (flag)
			{
				GameApp.Instance.NowBackground.SetActive(false);
			}
			base.transform.Find("GlobalLight").gameObject.SetActive(true);
			bool flag2 = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
			if (flag2)
			{
				FightManager.Instance.ChangeUnit(FightType.None);
			}
			MapManager.Instance.ResetEvent();
			PlayerManager.Instance.SendQuery<ValueTuple<string, DataConfig>[]>(new QueryCareers(), delegate([TupleElementNames(new string[]
			{
				"instanceId",
				"dataConfig"
			})] ValueTuple<string, DataConfig>[] roles)
			{
				bool flag3 = !this;
				if (!flag3)
				{
					this.CreateRole(roles);
				}
			});
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000B9B58 File Offset: 0x000B7D58
		private void $Rougamo_FadeIn()
		{
			bool flag = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").transform.SetAsLastSibling();
			}
			bool flag2 = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (flag2)
			{
				UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI").transform.SetAsLastSibling();
			}
			UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI").Hide();
			UIManager.Instance.GetUI<DictionaryUI>("DictionaryUI").gameObject.SetActive(false);
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000B9C00 File Offset: 0x000B7E00
		private void $Rougamo_CreateRole(ValueTuple<string, DataConfig>[] roleList)
		{
			bool flag = this == null || base.gameObject == null;
			if (!flag)
			{
				Transform tempParent = base.transform.Find("RoleList/RolePre");
				bool flag2 = tempParent == null;
				if (!flag2)
				{
					Transform roleListParent = base.transform.Find("RoleList");
					bool flag3 = roleListParent == null;
					if (!flag3)
					{
						tempParent.gameObject.SetActive(false);
						foreach (ValueTuple<string, DataConfig> item in roleList)
						{
							string id = item.Item1;
							DataConfig career = item.Item2;
							bool flag4 = id == null || career == null;
							if (!flag4)
							{
								Transform tempItem = UnityEngine.Object.Instantiate<Transform>(tempParent, roleListParent);
								tempItem.gameObject.SetActive(true);
								tempItem.Find("role").GetComponent<AnimatorRole>().Init(career, id, true);
								tempItem.Find("bigrole").GetComponent<AnimatorRole>().Init(career, id, false);
								tempItem.SetAsFirstSibling();
							}
						}
					}
				}
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x000B9D28 File Offset: 0x000B7F28
		private void $Rougamo_ContinueEvent(string id)
		{
			bool flag = !this.thisid.Contains("Sub");
			if (flag)
			{
				this.intid = this.thisid.IndexOf("_") + 1;
				string[] array = new string[5];
				array[0] = this.thisid.Substring(0, this.intid);
				array[1] = "Sub_";
				int num = 2;
				string text = this.thisid;
				int num2 = this.intid;
				array[num] = text.Substring(num2, text.Length - num2);
				array[3] = "_";
				array[4] = id;
				this.Init(string.Concat(array));
			}
			else
			{
				this.intid = this.thisid.IndexOf("_", 3);
				this.Init(this.thisid.Substring(0, this.intid) + "_" + id);
			}
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000B9E04 File Offset: 0x000B8004
		private void $Rougamo_Entry()
		{
			bool flag = this.dataConfig.data["EntryScript"] != "";
			if (flag)
			{
				this.dataConfig.scriptExecutor.RunScript("EntryScript");
				bool flag2 = this.dataConfig.data["EntryScript"].Contains("StartLevel");
				if (flag2)
				{
					return;
				}
			}
			this.TryChangeMap();
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x000B9E7A File Offset: 0x000B807A
		private void $Rougamo_TryChangeMap()
		{
			this.Close();
			MapManager.Instance.CmdEventWait();
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000B9E8F File Offset: 0x000B808F
		private void $Rougamo_AnnounceEventDone()
		{
			MapManager.Instance.CmdAnnounceEventWait();
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x000B9EA0 File Offset: 0x000B80A0
		private void $Rougamo_ShowChoices()
		{
			this.choiceList.Clear();
			for (int i = 0; i < 10; i++)
			{
				bool flag = this.dataConfig.Vars.GetValueOrDefault("Choice" + (i + 1).ToString(), "0") == "0";
				if (!flag)
				{
					this.choiceList.Add(Tuple.Create<string, string>((i + 1).ToString(), this.dataConfig.Vars["Choice" + (i + 1).ToString()]));
					bool flag2 = this.choiceList.Count >= 4;
					if (flag2)
					{
						break;
					}
				}
			}
			bool flag3 = this.choiceList.Count == 0;
			if (flag3)
			{
				Debug.LogError("EventUI: 这里没有选项，报告制作组" + this.dataConfig.data["Id"]);
				this.Entry();
			}
			else
			{
				for (int j = 0; j < this.choiceList.Count; j++)
				{
					string index = this.choiceList[j].Item1;
					string eventName = "Windows/Map0/Content/Selector/option" + (j + 1).ToString();
					ButtonManager button = base.transform.Find(eventName).GetComponent<ButtonManager>();
					bool flag4 = this.choiceList[j].Item2 == "2";
					if (flag4)
					{
						button.onClick.RemoveAllListeners();
						button.Interactable(false);
					}
					else
					{
						button.Interactable(true);
						button.onClick.RemoveAllListeners();
						button.onClick.AddListener(delegate
						{
							this.ButtonClickEffect(button.transform);
							this.Chicked(button.gameObject, index);
						});
					}
					string main;
					string tip;
					string subtip;
					string add;
					string TextImage;
					this.ResolveDescription(this.dataConfig.data.Localize(index + "Describe"), out main, out tip, out subtip, out add, out TextImage);
					bool flag5 = Singleton<GameRuntimeData>.Instance.MeetEvents.ContainsKey(this.dataConfig.data["Id"]);
					if (flag5)
					{
						this.SetAllText(base.transform.Find(eventName), "Description", main);
						KeywordDisplay keywordDisplay = base.transform.Find(eventName).GetComponent<KeywordDisplay>() ?? base.transform.Find(eventName).gameObject.AddComponent<KeywordDisplay>();
						keywordDisplay.SetLocalizedText(() => "option".Localize("EventUI") + index, delegate
						{
							string l;
							string t;
							string s;
							string a;
							string img;
							this.ResolveDescription(this.dataConfig.data.Localize(index + "Describe"), out l, out t, out s, out a, out img);
							return s;
						}, null);
					}
					else
					{
						this.needChangeShow = true;
						this.SetAllText(base.transform.Find(eventName), "Description", main);
					}
					base.transform.Find(eventName).gameObject.SetActive(false);
				}
				for (int k = 0; k < this.choiceList.Count; k++)
				{
					int now = k;
					UniTask.WaitForSeconds(1f + 0.4f * (float)k, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
					{
						string eventName2 = "Windows/Map0/Content/Selector/option" + (now + 1).ToString();
						Transform option = this.transform.Find(eventName2);
						bool flag6 = option == null || this.hasClosed;
						if (!flag6)
						{
							option.gameObject.SetActive(true);
							option.transform.localScale = Vector3.zero;
							option.transform.DOScale(Vector3.one, 1f);
							option.transform.eulerAngles = new Vector3(0f, 0f, 10f);
							option.DORotate(new Vector3(0f, 0f, -10f), 0.5f, RotateMode.Fast).OnComplete(delegate
							{
								bool flag7 = option == null;
								if (!flag7)
								{
									option.DORotate(Vector3.zero, 0.3f, RotateMode.Fast).SetEase(Ease.OutBack);
								}
							}).SetEase(Ease.InSine);
						}
					}).Forget();
				}
			}
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000BA230 File Offset: 0x000B8430
		private void $Rougamo_ButtonClickEffect(Transform button)
		{
			button.DOShakeRotation(0.5f, 10f, 10, 90f, true, ShakeRandomnessMode.Full).OnComplete(delegate
			{
				button.transform.DORotate(Vector3.zero, 0.1f, RotateMode.Fast);
			});
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayEffect(this.ClickClip);
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000BA294 File Offset: 0x000B8494
		private void $Rougamo_SetAllText(Transform option, string type, string value)
		{
			ButtonManager button = option.GetComponent<ButtonManager>();
			button.UpdateUI();
			TMP_Text component = button.normalCG.transform.Find(type).GetComponent<TMP_Text>();
			TMP_Text component2 = button.highlightCG.transform.Find(type).GetComponent<TMP_Text>();
			button.disabledCG.transform.Find(type).GetComponent<TMP_Text>().text = value;
			component2.text = value;
			component.text = value;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000BA30C File Offset: 0x000B850C
		private string $Rougamo_ReturnByArbitrary(string compare)
		{
			string result = "";
			string baseStr = this.dataConfig.data.Localize("CompareUse");
			Match mainMatch = Regex.Match(baseStr, compare, RegexOptions.Singleline);
			bool success = mainMatch.Success;
			if (success)
			{
				result = mainMatch.Groups[1].Value;
			}
			return result;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000BA368 File Offset: 0x000B8568
		private void $Rougamo_ResolveDescription(string description, out string main, out string tip, out string subtip, out string add, out string Image)
		{
			main = "";
			tip = "";
			subtip = "";
			add = "";
			Image = "";
			string mainPattern = "<main>(.*?)<\\/main>";
			string tipPattern = "<tip(?:=(exclaim|question|star))?>(.*?)<\\/tip>";
			string subtipPattern = "<subtip>(.*?)<\\/subtip>";
			string addPattern = "<add>(.*?)<\\/add>";
			Match mainMatch = Regex.Match(description, mainPattern, RegexOptions.Singleline);
			Match tipMatch = Regex.Match(description, tipPattern, RegexOptions.Singleline);
			Match subtipMatch = Regex.Match(description, subtipPattern, RegexOptions.Singleline);
			Match addMatch = Regex.Match(description, addPattern, RegexOptions.Singleline);
			bool success = mainMatch.Success;
			if (success)
			{
				main = mainMatch.Groups[1].Value;
			}
			else
			{
				Commands.LogError("错误！", "EventUI: ResolveDescription failed to find <main> tag in description.");
				main = description;
			}
			bool success2 = tipMatch.Success;
			if (success2)
			{
				Image = tipMatch.Groups[1].Value;
				tip = tipMatch.Groups[2].Value;
			}
			bool success3 = subtipMatch.Success;
			if (success3)
			{
				subtip = subtipMatch.Groups[1].Value;
			}
			bool success4 = addMatch.Success;
			if (success4)
			{
				add = addMatch.Groups[1].Value;
			}
			bool flag = !mainMatch.Success && !tipMatch.Success && !subtipMatch.Success;
			if (flag)
			{
				main = description;
			}
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000BA4C4 File Offset: 0x000B86C4
		private void $Rougamo_Chicked(GameObject tempObj, string index)
		{
			this.ChickObj = tempObj;
			bool flag = this.needChangeShow;
			if (flag)
			{
				string main;
				string tip;
				string subtip;
				string add;
				string TextImage;
				this.ResolveDescription(this.dataConfig.data.Localize(index + "Describe"), out main, out tip, out subtip, out add, out TextImage);
				this.SetAllText(tempObj.transform, "Description", main + "\n" + subtip);
			}
			string ScriptString = index + "Script";
			this.dataConfig.scriptExecutor.RunScript(ScriptString);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000BA550 File Offset: 0x000B8750
		private void $Rougamo_LockChoice(string index)
		{
			for (int i = 0; i < this.choiceList.Count; i++)
			{
				bool flag = this.choiceList[i].Item1 == index;
				if (flag)
				{
					base.transform.Find("Windows/Map0/Content/Selector/option" + (i + 1).ToString()).GetComponent<ButtonManager>().Interactable(false);
				}
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000BA5C4 File Offset: 0x000B87C4
		private void $Rougamo_EndEvent()
		{
			this.hasClosed = true;
			Transform selector = base.transform.Find("Windows/Map0/Content/Selector");
			GameObject exitPrefab = this.ChickObj;
			for (int i = 0; i < this.choiceList.Count; i++)
			{
				GameObject option = selector.Find(ZString.Format<object>("option{0}", i + 1)).gameObject;
				bool flag = option.gameObject != this.ChickObj;
				if (flag)
				{
					option.SetActive(false);
				}
				else
				{
					option.GetComponent<ButtonManager>().Interactable(false);
				}
			}
			Transform exit = UnityEngine.Object.Instantiate<GameObject>(exitPrefab, selector).transform;
			exit.transform.localScale = Vector3.one;
			exit.gameObject.SetActive(true);
			exit.GetComponent<RectTransform>().rotation = Quaternion.Euler(0f, 0f, 0f);
			ButtonManager exitButton = exit.GetComponent<ButtonManager>();
			exitButton.onClick.RemoveAllListeners();
			bool flag2 = exitButton.GetComponent<KeywordDisplay>() == null;
			if (flag2)
			{
				int index = this.ChickObj.transform.GetSiblingIndex() + 1;
				KeywordDisplay keywordDisplay = exitButton.gameObject.AddComponent<KeywordDisplay>();
				keywordDisplay.SetLocalizedText(() => ZString.Format<object, object>("{0}{1}", "option".Localize("EventUI"), index), delegate
				{
					string j;
					string t;
					string s;
					string a;
					string img;
					this.ResolveDescription(this.dataConfig.data.Localize(index.ToString() + "Describe"), out j, out t, out s, out a, out img);
					return s;
				}, null);
			}
			exitButton.onClick.AddListener(new UnityAction(this.Entry));
			exitButton.Interactable(true);
			this.SetAllText(exit, "Description", "exitevent".Localize("EventUI"));
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x000BA770 File Offset: 0x000B8970
		private void $Rougamo_ChangeSubtip(string subtip)
		{
			string wantText = this.ReturnByArbitrary(subtip);
			UIManager.Instance.ShowPopUpText("NormalMsgText", wantText, new Vector2(this.ChickObj.transform.position.x, this.ChickObj.transform.position.y)).Forget<PopUpTextUI>();
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000BA7CC File Offset: 0x000B89CC
		private void $Rougamo_ShowStr(string name)
		{
			TMP_Text mainText = base.transform.Find(name + "Main").GetComponent<TMP_Text>();
			string main;
			string tip;
			string subtip;
			string add;
			string TextImage;
			this.ResolveDescription(this.dataConfig.data.Localize("TotalDescribe"), out main, out tip, out subtip, out add, out TextImage);
			mainText.text = main;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000BA824 File Offset: 0x000B8A24
		private void $Rougamo_DataUpdate()
		{
			this.ShowStr("Windows/Map0/Content/Description/");
			for (int i = 0; i < this.choiceList.Count; i++)
			{
				string index = this.choiceList[i].Item1;
				string EventName = "Windows/Map0/Content/Selector/option" + (i + 1).ToString();
				string main;
				string tip;
				string subtip;
				string add;
				string TextImage;
				this.ResolveDescription(this.dataConfig.data.Localize(index + "Describe"), out main, out tip, out subtip, out add, out TextImage);
				this.SetAllText(base.transform.Find(EventName), "Description", main);
			}
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000BA8D0 File Offset: 0x000B8AD0
		private void $Rougamo_RegisterEvent()
		{
			Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00004B9C File Offset: 0x00002D9C
		private void $Rougamo_ClearEvent()
		{
			Singleton<EventCenter>.Instance.Clear(this);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000BA908 File Offset: 0x000B8B08
		private void $Rougamo_OnDestroy()
		{
			base.OnDestroy();
			UIManager.Instance.EndNotification();
			bool flag = GameApp.Instance.NowBackground != null;
			if (flag)
			{
				GameApp.Instance.NowBackground.SetActive(true);
			}
		}

		// Token: 0x040011BE RID: 4542
		[Header("音效设置")]
		[Tooltip("点击按钮音效")]
		public AudioClip ClickClip;

		// Token: 0x040011BF RID: 4543
		[Tooltip("显示音效")]
		public AudioClip ShowClip;

		// Token: 0x040011C0 RID: 4544
		private string thisid;

		// Token: 0x040011C1 RID: 4545
		private DataConfig dataConfig;

		// Token: 0x040011C2 RID: 4546
		private bool needChangeShow;

		// Token: 0x040011C3 RID: 4547
		private List<Tuple<string, string>> choiceList = new List<Tuple<string, string>>();

		// Token: 0x040011C4 RID: 4548
		private GameObject ChickObj = null;

		// Token: 0x040011C5 RID: 4549
		private bool hasClosed = false;

		// Token: 0x040011C6 RID: 4550
		private int intid;
	}
}

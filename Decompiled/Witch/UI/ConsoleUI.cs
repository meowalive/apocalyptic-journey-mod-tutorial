using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Witch.UI
{
	// Token: 0x02000263 RID: 611
	public class ConsoleUI : UIBase
	{
		// Token: 0x06001380 RID: 4992 RVA: 0x00099410 File Offset: 0x00097610
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
			methodContext.TargetType = typeof(ConsoleUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ConsoleUI.Awake()).MethodHandle, typeof(ConsoleUI).TypeHandle);
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

		// Token: 0x06001381 RID: 4993 RVA: 0x0009950C File Offset: 0x0009770C
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
			methodContext.TargetType = typeof(ConsoleUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ConsoleUI.OnEnable()).MethodHandle, typeof(ConsoleUI).TypeHandle);
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

		// Token: 0x06001382 RID: 4994 RVA: 0x00099608 File Offset: 0x00097808
		[DebuggerStepThrough]
		public override void OnDisable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ConsoleUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ConsoleUI.OnDisable()).MethodHandle, typeof(ConsoleUI).TypeHandle);
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

		// Token: 0x06001383 RID: 4995 RVA: 0x00099704 File Offset: 0x00097904
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
			methodContext.TargetType = typeof(ConsoleUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ConsoleUI.Update()).MethodHandle, typeof(ConsoleUI).TypeHandle);
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

		// Token: 0x06001384 RID: 4996 RVA: 0x00099800 File Offset: 0x00097A00
		[DebuggerStepThrough]
		public void Output(string outputer, string output)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ConsoleUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ConsoleUI.Output(string, string)).MethodHandle, typeof(ConsoleUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				outputer,
				output
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
							outputer = null;
						}
						else
						{
							outputer = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							output = null;
						}
						else
						{
							output = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Output(outputer, output);
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

		// Token: 0x0600138A RID: 5002 RVA: 0x00099A2C File Offset: 0x00097C2C
		private void $Rougamo_Awake()
		{
			this.isInit = true;
			this.inputField = base.transform.Find("Input").GetComponent<TMP_InputField>();
			this.outputText = base.transform.Find("Output/OutputText").GetComponent<TMP_Text>();
			this.scrollbar = base.transform.Find("Output/Scrollbar").GetComponent<Scrollbar>();
			ConsoleUI.Instance = this;
			this.showAction = delegate(InputAction.CallbackContext ctx)
			{
				KeyManager.playerAction.Main.Debug.performed -= this.showAction;
				KeyManager.playerAction.Main.Debug.performed += this.hideAction;
				this.Show();
			};
			this.hideAction = delegate(InputAction.CallbackContext ctx)
			{
				KeyManager.playerAction.Main.Debug.performed -= this.hideAction;
				KeyManager.playerAction.Main.Debug.performed += this.showAction;
				this.Hide();
			};
			KeyManager.playerAction.Main.Debug.performed += this.showAction;
			base.gameObject.SetActive(false);
			Commands.Log("Game", "Version: " + Globals.VersionString);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00099B04 File Offset: 0x00097D04
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			base.transform.SetAsLastSibling();
			bool flag = !this.isInit;
			if (!flag)
			{
				base.transform.SetAsLastSibling();
				UniTask.DelayFrame(1, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
				{
					this.inputField.ActivateInputField();
				});
			}
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00099B60 File Offset: 0x00097D60
		private void $Rougamo_OnDisable()
		{
			base.OnDisable();
			this.inputField.DeactivateInputField(false);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00099B78 File Offset: 0x00097D78
		private void $Rougamo_Update()
		{
			bool wasPressedThisFrame = Keyboard.current.enterKey.wasPressedThisFrame;
			if (wasPressedThisFrame)
			{
				string input = this.inputField.text;
				bool flag = input != "";
				if (flag)
				{
					TMP_Text tmp_Text = this.outputText;
					tmp_Text.text = tmp_Text.text + "<color=white>>>" + input + "</color>\n";
					string output = ConsoleLogic.Input(input);
					bool flag2 = output != null;
					if (flag2)
					{
						bool flag3 = output == "cls";
						if (flag3)
						{
							this.outputText.text = "";
							this.lineCount = 0;
						}
						else
						{
							TMP_Text tmp_Text2 = this.outputText;
							tmp_Text2.text = tmp_Text2.text + "<color=white>" + output + "</color>\n";
						}
					}
				}
				this.inputField.text = "";
				this.inputField.ActivateInputField();
				UniTask.DelayFrame(3, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
				{
					this.scrollbar.value = 0f;
				});
			}
			else
			{
				bool wasPressedThisFrame2 = Keyboard.current.upArrowKey.wasPressedThisFrame;
				if (wasPressedThisFrame2)
				{
					this.inputField.text = ConsoleLogic.LastCommand();
				}
				else
				{
					bool wasPressedThisFrame3 = Keyboard.current.downArrowKey.wasPressedThisFrame;
					if (wasPressedThisFrame3)
					{
						this.inputField.text = ConsoleLogic.NextCommand();
					}
				}
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00099CD8 File Offset: 0x00097ED8
		private void $Rougamo_Output(string outputer, string output)
		{
			TMP_Text tmp_Text = this.outputText;
			tmp_Text.text = string.Concat(new string[]
			{
				tmp_Text.text,
				"<color=yellow>",
				outputer,
				"</color> : <color=white>",
				output,
				"</color>\n"
			});
			this.lineCount++;
			bool flag = this.lineCount > 200;
			if (flag)
			{
				this.outputText.text = this.outputText.text.Substring(this.outputText.text.IndexOf('\n') + 1);
				this.lineCount--;
			}
		}

		// Token: 0x04000FC6 RID: 4038
		public static ConsoleUI Instance;

		// Token: 0x04000FC7 RID: 4039
		private bool isInit;

		// Token: 0x04000FC8 RID: 4040
		[SerializeField]
		private TMP_InputField inputField;

		// Token: 0x04000FC9 RID: 4041
		[SerializeField]
		private TMP_Text outputText;

		// Token: 0x04000FCA RID: 4042
		private Scrollbar scrollbar;

		// Token: 0x04000FCB RID: 4043
		private Action<InputAction.CallbackContext> showAction;

		// Token: 0x04000FCC RID: 4044
		private Action<InputAction.CallbackContext> hideAction;

		// Token: 0x04000FCD RID: 4045
		private int lineCount = 0;
	}
}

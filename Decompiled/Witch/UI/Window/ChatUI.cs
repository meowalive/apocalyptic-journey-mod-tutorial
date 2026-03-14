using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Mirror;
using Network.Command;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x020002BB RID: 699
	public class ChatUI : UIBase
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x000AF92C File Offset: 0x000ADB2C
		private UniTask timerTask
		{
			[DebuggerStepThrough]
			get
			{
				ChatUI.<get_timerTask>r__1 <get_timerTask>r__ = new ChatUI.<get_timerTask>r__1();
				<get_timerTask>r__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				ChatUI.<get_timerTask>r__1 <get_timerTask>r__2 = <get_timerTask>r__;
				<get_timerTask>r__.<>4__this = this;
				<get_timerTask>r__2.<>1__state = -1;
				<get_timerTask>r__.<>t__builder.Start<ChatUI.<get_timerTask>r__1>(ref <get_timerTask>r__);
				return <get_timerTask>r__.<>t__builder.Task;
			}
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000AF988 File Offset: 0x000ADB88
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
			methodContext.TargetType = typeof(ChatUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ChatUI.Awake()).MethodHandle, typeof(ChatUI).TypeHandle);
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

		// Token: 0x060015CF RID: 5583 RVA: 0x000AFA84 File Offset: 0x000ADC84
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
			methodContext.TargetType = typeof(ChatUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ChatUI.Start()).MethodHandle, typeof(ChatUI).TypeHandle);
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

		// Token: 0x060015D0 RID: 5584 RVA: 0x000AFB80 File Offset: 0x000ADD80
		[DebuggerStepThrough]
		public void SendChatMessage(string text)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ChatUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ChatUI.SendChatMessage(string)).MethodHandle, typeof(ChatUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				text
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
					}
					do
					{
						try
						{
							this.$Rougamo_SendChatMessage(text);
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

		// Token: 0x060015D1 RID: 5585 RVA: 0x000AFCB4 File Offset: 0x000ADEB4
		[DebuggerStepThrough]
		public void AddMessage(string text)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ChatUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ChatUI.AddMessage(string)).MethodHandle, typeof(ChatUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				text
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
					}
					do
					{
						try
						{
							this.$Rougamo_AddMessage(text);
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

		// Token: 0x060015D2 RID: 5586 RVA: 0x000AFDE8 File Offset: 0x000ADFE8
		private IEnumerator ScrollToBottom()
		{
			yield return null;
			yield return null;
			this.scrollbar.value = 0f;
			yield break;
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000AFE75 File Offset: 0x000AE075
		private UniTask $Rougamo_get_timerTask()
		{
			return UniTask.Create(delegate()
			{
				ChatUI.<<get_timerTask>b__7_0>d <<get_timerTask>b__7_0>d = new ChatUI.<<get_timerTask>b__7_0>d();
				<<get_timerTask>b__7_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<get_timerTask>b__7_0>d.<>4__this = this;
				<<get_timerTask>b__7_0>d.<>1__state = -1;
				<<get_timerTask>b__7_0>d.<>t__builder.Start<ChatUI.<<get_timerTask>b__7_0>d>(ref <<get_timerTask>b__7_0>d);
				return <<get_timerTask>b__7_0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000AFE88 File Offset: 0x000AE088
		private void $Rougamo_Awake()
		{
			ChatUI.Instance = this;
			this.inputField = base.transform.Find("Input").GetComponent<TMP_InputField>();
			this.output = base.transform.Find("Output/OutputText").GetComponent<TMP_Text>();
			this.scrollbar = base.transform.Find("Output/Scrollbar").GetComponent<Scrollbar>();
			this.inputField.onSubmit.AddListener(new UnityAction<string>(this.SendChatMessage));
			this.inputField.gameObject.SetActive(false);
			KeyManager.playerAction.Main.Submit.performed += delegate(InputAction.CallbackContext ctx)
			{
				this.SendChatMessage(this.inputField.text);
			};
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x000AFF40 File Offset: 0x000AE140
		private void $Rougamo_Start()
		{
			this.inputField.ActivateInputField();
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x000AFF50 File Offset: 0x000AE150
		private void $Rougamo_SendChatMessage(string text)
		{
			bool flag = string.IsNullOrWhiteSpace(text);
			if (flag)
			{
				this.inputField.text = "";
			}
			else
			{
				PlayerManager player = NetworkClient.localPlayer.GetComponent<PlayerManager>();
				bool flag2 = player != null;
				if (flag2)
				{
					player.SendRpcCommand(new RpcSendChat(player.PlayerId, text));
				}
				this.inputField.text = "";
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000AFFB8 File Offset: 0x000AE1B8
		private void $Rougamo_AddMessage(string text)
		{
			TMP_Text tmp_Text = this.output;
			tmp_Text.text = tmp_Text.text + "<color=white>" + text + "</color>\n";
			this.inputField.ActivateInputField();
			base.StartCoroutine(this.ScrollToBottom());
			this.timerTask.Forget();
		}

		// Token: 0x0400113E RID: 4414
		public static ChatUI Instance;

		// Token: 0x0400113F RID: 4415
		[SerializeField]
		private TMP_InputField inputField;

		// Token: 0x04001140 RID: 4416
		[SerializeField]
		private TMP_Text output;

		// Token: 0x04001141 RID: 4417
		[SerializeField]
		private Scrollbar scrollbar;

		// Token: 0x04001142 RID: 4418
		private float nowTime = 0f;

		// Token: 0x04001143 RID: 4419
		private bool isTimerRunning = false;

		// Token: 0x04001144 RID: 4420
		public bool isOpen = false;
	}
}

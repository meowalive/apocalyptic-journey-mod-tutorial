using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Network.Command;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000372 RID: 882
	public class EmojiPanelUI : UIBase
	{
		// Token: 0x06001BE0 RID: 7136 RVA: 0x000EE98C File Offset: 0x000ECB8C
		[DebuggerStepThrough]
		public void CreateEmoji()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EmojiPanelUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EmojiPanelUI.CreateEmoji()).MethodHandle, typeof(EmojiPanelUI).TypeHandle);
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
							this.$Rougamo_CreateEmoji();
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

		// Token: 0x06001BE1 RID: 7137 RVA: 0x000EEA88 File Offset: 0x000ECC88
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
			methodContext.TargetType = typeof(EmojiPanelUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EmojiPanelUI.Awake()).MethodHandle, typeof(EmojiPanelUI).TypeHandle);
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

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000EEB84 File Offset: 0x000ECD84
		[DebuggerStepThrough]
		public void Start()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EmojiPanelUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EmojiPanelUI.Start()).MethodHandle, typeof(EmojiPanelUI).TypeHandle);
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

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000EEC80 File Offset: 0x000ECE80
		private void GenerateEmojiButtons()
		{
			bool flag = this.EmojiPrefab == null;
			if (flag)
			{
				Debug.LogError("EmojiPrefab is not assigned in the inspector.");
			}
			else
			{
				Transform parent = this.EmojiPrefab.parent;
				for (int i = parent.childCount - 1; i >= 0; i--)
				{
					Transform child = parent.GetChild(i);
					bool flag2 = child != this.EmojiPrefab;
					if (flag2)
					{
						UnityEngine.Object.Destroy(child.gameObject);
					}
				}
				this.EmojiPrefab.gameObject.SetActive(false);
				foreach (GifAsset emoji in this.Emojis)
				{
					Transform emojiButton = UnityEngine.Object.Instantiate<Transform>(this.EmojiPrefab, this.EmojiPrefab.parent);
					emojiButton.gameObject.SetActive(true);
					emojiButton.Find("Icon").GetComponent<UIAnimation>().SetGif(emoji);
				}
			}
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000EED98 File Offset: 0x000ECF98
		[DebuggerStepThrough]
		public void ShowEmoji(GifAsset gifAsset)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EmojiPanelUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EmojiPanelUI.ShowEmoji(GifAsset)).MethodHandle, typeof(EmojiPanelUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				gifAsset
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
							gifAsset = null;
						}
						else
						{
							gifAsset = (GifAsset)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowEmoji(gifAsset);
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

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000EEECC File Offset: 0x000ED0CC
		[DebuggerStepThrough]
		public void ShowEmoji(UIAnimation uiAnimation)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(EmojiPanelUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EmojiPanelUI.ShowEmoji(UIAnimation)).MethodHandle, typeof(EmojiPanelUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				uiAnimation
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
							uiAnimation = null;
						}
						else
						{
							uiAnimation = (UIAnimation)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowEmoji(uiAnimation);
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

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000EF014 File Offset: 0x000ED214
		private void $Rougamo_CreateEmoji()
		{
			RoleTable instance = RoleTable.Instance;
			string text;
			if (instance == null)
			{
				text = null;
			}
			else
			{
				DataConfig career = instance.Career;
				if (career == null)
				{
					text = null;
				}
				else
				{
					IDictionary<string, string> data = career.data;
					text = ((data != null) ? data.GetValueOrDefault("EmojiPath", null) : null);
				}
			}
			string path = text;
			bool flag = !string.IsNullOrEmpty(path);
			if (flag)
			{
				this.Emojis = new List<GifAsset>(ResourceLoader.LoadAll<GifAsset>("Images/Emojis/" + path));
			}
			else
			{
				this.Emojis = new List<GifAsset>(ResourceLoader.LoadAll<GifAsset>("Images/Emojis/阿米莉亚表情包"));
			}
			this.GenerateEmojiButtons();
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x000EF09C File Offset: 0x000ED29C
		private void $Rougamo_Awake()
		{
			this.CreateEmoji();
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000A21B3 File Offset: 0x000A03B3
		private void $Rougamo_Start()
		{
			base.transform.SetAsLastSibling();
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000EF0A8 File Offset: 0x000ED2A8
		private void $Rougamo_ShowEmoji(GifAsset gifAsset)
		{
			bool flag = Time.time - this.LastClickTime < 1f || PlayerManager.Instance == null || PlayerManager.Instance.PlayerId == null;
			if (!flag)
			{
				this.LastClickTime = Time.time;
				Singleton<DialogueManager>.Instance.ShowEmoji(PlayerManager.Instance.PlayerId, gifAsset);
				PlayerManager.Instance.SendRpcCommandExcludeOwner(new RpcSendEmoji(PlayerManager.Instance.PlayerId, gifAsset));
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000EF128 File Offset: 0x000ED328
		private void $Rougamo_ShowEmoji(UIAnimation uiAnimation)
		{
			this.ShowEmoji(uiAnimation.GifAsset);
		}

		// Token: 0x040014E0 RID: 5344
		private List<GifAsset> Emojis;

		// Token: 0x040014E1 RID: 5345
		private float LastClickTime = 0f;

		// Token: 0x040014E2 RID: 5346
		[SerializeField]
		public Transform EmojiPrefab;
	}
}

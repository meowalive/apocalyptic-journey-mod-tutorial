using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.UI;
using Witch.UI;

namespace Witch
{
	// Token: 0x0200025A RID: 602
	public class StoryEditorUI : UIBase
	{
		// Token: 0x0600134B RID: 4939 RVA: 0x00097714 File Offset: 0x00095914
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
			methodContext.TargetType = typeof(StoryEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StoryEditorUI.Start()).MethodHandle, typeof(StoryEditorUI).TypeHandle);
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

		// Token: 0x0600134C RID: 4940 RVA: 0x00097810 File Offset: 0x00095A10
		[DebuggerStepThrough]
		private void SetCharacterImage(string imagePath)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StoryEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StoryEditorUI.SetCharacterImage(string)).MethodHandle, typeof(StoryEditorUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				imagePath
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
							imagePath = null;
						}
						else
						{
							imagePath = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetCharacterImage(imagePath);
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

		// Token: 0x0600134D RID: 4941 RVA: 0x00097944 File Offset: 0x00095B44
		[DebuggerStepThrough]
		public void ChangeImageShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StoryEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StoryEditorUI.ChangeImageShow()).MethodHandle, typeof(StoryEditorUI).TypeHandle);
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
							this.$Rougamo_ChangeImageShow();
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

		// Token: 0x0600134E RID: 4942 RVA: 0x00097A40 File Offset: 0x00095C40
		private void GenerateCharacterButtons()
		{
			bool flag = this.ImagePrefab == null;
			if (flag)
			{
				Debug.LogError("ImagePrefab is not assigned in the inspector.");
			}
			else
			{
				Transform parent = this.ImageParent;
				for (int i = parent.childCount - 1; i >= 0; i--)
				{
					Transform child = parent.GetChild(i);
					bool flag2 = child != this.ImagePrefab.transform;
					if (flag2)
					{
						UnityEngine.Object.Destroy(child.gameObject);
					}
				}
				this.ImagePrefab.gameObject.SetActive(false);
				foreach (Sprite emoji in this.CharaImages)
				{
					GameObject emojiButton = UnityEngine.Object.Instantiate<GameObject>(this.ImagePrefab, this.ImagePrefab.transform.parent);
					emojiButton.gameObject.SetActive(true);
					emojiButton.transform.Find("Icon").GetComponent<Image>().sprite = emoji;
				}
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00097B64 File Offset: 0x00095D64
		[DebuggerStepThrough]
		public void SetImage(Image image)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StoryEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StoryEditorUI.SetImage(Image)).MethodHandle, typeof(StoryEditorUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				image
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
							image = null;
						}
						else
						{
							image = (Image)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetImage(image);
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

		// Token: 0x06001350 RID: 4944 RVA: 0x00097C98 File Offset: 0x00095E98
		[DebuggerStepThrough]
		private void SaveImageReference(string path)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StoryEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StoryEditorUI.SaveImageReference(string)).MethodHandle, typeof(StoryEditorUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				path
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
							path = null;
						}
						else
						{
							path = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SaveImageReference(path);
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

		// Token: 0x06001351 RID: 4945 RVA: 0x00097DCC File Offset: 0x00095FCC
		[DebuggerStepThrough]
		private string MakeRelativePath(string fullPath)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StoryEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StoryEditorUI.MakeRelativePath(string)).MethodHandle, typeof(StoryEditorUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				fullPath
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
							fullPath = null;
						}
						else
						{
							fullPath = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							text = this.$Rougamo_MakeRelativePath(fullPath);
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

		// Token: 0x06001353 RID: 4947 RVA: 0x00097F48 File Offset: 0x00096148
		private void $Rougamo_Start()
		{
			this.CharaImages = new List<Sprite>(ResourceLoader.LoadAll<Sprite>("Images/StoryChara"));
			this.roleData = Singleton<GameConfigManager>.Instance.GetTable(DataType.RoleData).Getlines();
			Debug.Log("语言" + Globals.Language);
			this.GenerateCharacterButtons();
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_SetCharacterImage(string imagePath)
		{
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00097F9E File Offset: 0x0009619E
		private void $Rougamo_ChangeImageShow()
		{
			this.ImageParent.gameObject.SetActive(!this.ImageParent.gameObject.activeSelf);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00097FC5 File Offset: 0x000961C5
		private void $Rougamo_SetImage(Image image)
		{
			this.characterImage.sprite = image.sprite;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00097FDC File Offset: 0x000961DC
		private void $Rougamo_SaveImageReference(string path)
		{
			string relativePath = this.MakeRelativePath(path);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00097FF4 File Offset: 0x000961F4
		private string $Rougamo_MakeRelativePath(string fullPath)
		{
			string gameRoot = Application.persistentDataPath + "/..";
			return Path.GetRelativePath(gameRoot, fullPath);
		}

		// Token: 0x04000FA9 RID: 4009
		public Image characterImage;

		// Token: 0x04000FAA RID: 4010
		public Button changeImageButton;

		// Token: 0x04000FAB RID: 4011
		public GameObject ImagePrefab;

		// Token: 0x04000FAC RID: 4012
		public Transform ImageParent;

		// Token: 0x04000FAD RID: 4013
		public string LanguageCode;

		// Token: 0x04000FAE RID: 4014
		private List<Sprite> CharaImages;

		// Token: 0x04000FAF RID: 4015
		private List<Dictionary<string, string>> roleData;
	}
}

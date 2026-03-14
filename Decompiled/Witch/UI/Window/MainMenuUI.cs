using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using Cysharp.Threading.Tasks;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000329 RID: 809
	public class MainMenuUI : UIBase
	{
		// Token: 0x06001939 RID: 6457 RVA: 0x000D3D00 File Offset: 0x000D1F00
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
			methodContext.TargetType = typeof(MainMenuUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MainMenuUI.Awake()).MethodHandle, typeof(MainMenuUI).TypeHandle);
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

		// Token: 0x0600193A RID: 6458 RVA: 0x000D3DFC File Offset: 0x000D1FFC
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
			methodContext.TargetType = typeof(MainMenuUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MainMenuUI.DataUpdate()).MethodHandle, typeof(MainMenuUI).TypeHandle);
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

		// Token: 0x0600193B RID: 6459 RVA: 0x000D3EF8 File Offset: 0x000D20F8
		[DebuggerStepThrough]
		public void StartGame()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MainMenuUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MainMenuUI.StartGame()).MethodHandle, typeof(MainMenuUI).TypeHandle);
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
							this.$Rougamo_StartGame();
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

		// Token: 0x0600193C RID: 6460 RVA: 0x000D3FF4 File Offset: 0x000D21F4
		[DebuggerStepThrough]
		public void CloseTheGame()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MainMenuUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MainMenuUI.CloseTheGame()).MethodHandle, typeof(MainMenuUI).TypeHandle);
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
							this.$Rougamo_CloseTheGame();
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

		// Token: 0x0600193D RID: 6461 RVA: 0x000D40F0 File Offset: 0x000D22F0
		[DebuggerStepThrough]
		public void OpenWebsite(string url)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MainMenuUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MainMenuUI.OpenWebsite(string)).MethodHandle, typeof(MainMenuUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				url
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
							url = null;
						}
						else
						{
							url = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_OpenWebsite(url);
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

		// Token: 0x0600193E RID: 6462 RVA: 0x000D4224 File Offset: 0x000D2424
		[DebuggerStepThrough]
		public void OpenSettings()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MainMenuUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MainMenuUI.OpenSettings()).MethodHandle, typeof(MainMenuUI).TypeHandle);
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
							this.$Rougamo_OpenSettings();
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

		// Token: 0x0600193F RID: 6463 RVA: 0x000D4320 File Offset: 0x000D2520
		[DebuggerStepThrough]
		public void OnClickMod()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MainMenuUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MainMenuUI.OnClickMod()).MethodHandle, typeof(MainMenuUI).TypeHandle);
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
							this.$Rougamo_OnClickMod();
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

		// Token: 0x06001940 RID: 6464 RVA: 0x000D441C File Offset: 0x000D261C
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
			methodContext.TargetType = typeof(MainMenuUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MainMenuUI.OnDisable()).MethodHandle, typeof(MainMenuUI).TypeHandle);
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

		// Token: 0x06001942 RID: 6466 RVA: 0x000D4528 File Offset: 0x000D2728
		private void $Rougamo_Awake()
		{
			AudioManager.Instance.PlayBGMList("HouseBGM", false);
			this.RegisterEvent();
			this.DataUpdate();
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x000D454C File Offset: 0x000D274C
		private void $Rougamo_DataUpdate()
		{
			base.transform.Find("background/TextList/StartGame").GetComponent<ButtonManager>().SetText("StartGame".Localize("MainMenuUI"));
			base.transform.Find("background/TextList/SettingTable").GetComponent<ButtonManager>().SetText("SettingTable".Localize("MainMenuUI"));
			base.transform.Find("background/TextList/ExitGame").GetComponent<ButtonManager>().SetText("ExitGame".Localize("MainMenuUI"));
			base.transform.Find("background/RightTop/Steam").GetComponent<ButtonManager>().SetText("AddWishList".Localize("MainMenuUI"));
			base.transform.Find("background/TextList/ModManager").GetComponent<ButtonManager>().SetText("Mod".Localize("MainMenuUI"));
			base.transform.Find("background/TextList/Credits").GetComponent<ButtonManager>().SetText("Credits".Localize("MainMenuUI"));
			base.transform.Find("background/Version").GetComponent<TMP_Text>().SetText(Globals.VersionString);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000D4678 File Offset: 0x000D2878
		private void $Rougamo_StartGame()
		{
			bool flag = this.hasInit;
			if (!flag)
			{
				this.hasInit = true;
				base.CloseWithCallback(delegate
				{
					SceneTurnUI loadingUI = UIManager.Instance.ShowUI<SceneTurnUI>("SceneTurnUI", true);
					UniTask.WaitForSeconds(1.3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
					{
						GameApp.Instance.StartHouse();
						loadingUI.Close();
					}).Forget();
				});
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000D46C0 File Offset: 0x000D28C0
		private void $Rougamo_CloseTheGame()
		{
			UIManager.Instance.ShowModalWindow("prompt", "Quit the game？", delegate
			{
				EditorApplication.isPlaying = false;
			}, 0f, null, true, true, "Yes", "No", true);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000D4715 File Offset: 0x000D2915
		private void $Rougamo_OpenWebsite(string url)
		{
			Application.OpenURL(url);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000D471F File Offset: 0x000D291F
		private void $Rougamo_OpenSettings()
		{
			UIManager.Instance.ShowUI<SettingUI>("SettingUI", true);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000CDF67 File Offset: 0x000CC167
		private void $Rougamo_OnClickMod()
		{
			UIManager.Instance.ShowUI<ModManagerUI>("ModManagerUI", true);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000D4733 File Offset: 0x000D2933
		private void $Rougamo_OnDisable()
		{
			base.OnDisable();
			base.StopAllCoroutines();
		}

		// Token: 0x04001381 RID: 4993
		private bool hasInit = false;
	}
}

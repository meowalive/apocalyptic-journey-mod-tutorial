using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000359 RID: 857
	public class InkTurnUI : UIBase
	{
		// Token: 0x06001AEE RID: 6894 RVA: 0x000E652C File Offset: 0x000E472C
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
			methodContext.TargetType = typeof(InkTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(InkTurnUI.Awake()).MethodHandle, typeof(InkTurnUI).TypeHandle);
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

		// Token: 0x06001AEF RID: 6895 RVA: 0x000E6628 File Offset: 0x000E4828
		[ContextMenu("Play")]
		[DebuggerStepThrough]
		public void Play()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(InkTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(InkTurnUI.Play()).MethodHandle, typeof(InkTurnUI).TypeHandle);
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
							this.$Rougamo_Play();
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

		// Token: 0x06001AF0 RID: 6896 RVA: 0x000E6724 File Offset: 0x000E4924
		[DebuggerStepThrough]
		public void Play(Action firstUI = null, Action secondUI = null)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(InkTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(InkTurnUI.Play(Action, Action)).MethodHandle, typeof(InkTurnUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				firstUI,
				secondUI
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
							firstUI = null;
						}
						else
						{
							firstUI = (Action)arguments[0];
						}
						if (arguments[1] == null)
						{
							secondUI = null;
						}
						else
						{
							secondUI = (Action)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Play(firstUI, secondUI);
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

		// Token: 0x06001AF1 RID: 6897 RVA: 0x000E6878 File Offset: 0x000E4A78
		private IEnumerator PlayByFrames(Action firstUI = null, Action secondUI = null)
		{
			int num;
			for (int i = 0; i < this.textures.Count; i = num + 1)
			{
				this.SceneTurnMaterial.SetTexture("_MainTex", this.textures[i]);
				yield return new WaitForSecondsRealtime(0.016666668f);
				num = i;
			}
			if (firstUI != null)
			{
				firstUI();
			}
			if (secondUI != null)
			{
				secondUI();
			}
			yield return new WaitForSecondsRealtime(0.3f);
			this.SceneTurnMaterial.SetTexture("_MainTex", this.textures[0]);
			this.SceneTurnMaterial.SetInt("_Mode", 0);
			for (int j = 0; j < this.textures.Count; j = num + 1)
			{
				this.SceneTurnMaterial.SetTexture("_MainTex", this.textures[j]);
				yield return new WaitForSecondsRealtime(0.016666668f);
				yield return new WaitForSecondsRealtime(0.016666668f);
				num = j;
			}
			this.Close();
			yield break;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x000E6898 File Offset: 0x000E4A98
		[DebuggerStepThrough]
		public void FastPlay(Action firstUI = null, Action secondUI = null)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(InkTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(InkTurnUI.FastPlay(Action, Action)).MethodHandle, typeof(InkTurnUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				firstUI,
				secondUI
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
							firstUI = null;
						}
						else
						{
							firstUI = (Action)arguments[0];
						}
						if (arguments[1] == null)
						{
							secondUI = null;
						}
						else
						{
							secondUI = (Action)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_FastPlay(firstUI, secondUI);
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

		// Token: 0x06001AF3 RID: 6899 RVA: 0x000E69EC File Offset: 0x000E4BEC
		private IEnumerator FastPlayByFrames(Action firstUI = null, Action secondUI = null)
		{
			int num;
			for (int i = 0; i < this.textures.Count; i = num + 1)
			{
				this.SceneTurnMaterial.SetTexture("_MainTex", this.textures[i]);
				bool flag = i == this.textures.Count / 2 + 1;
				if (flag)
				{
					this.SafeInvoke(firstUI, "firstUI");
				}
				yield return new WaitForSecondsRealtime(0.016666668f);
				num = i;
			}
			this.SafeInvoke(secondUI, "secondUI");
			yield return new WaitForSecondsRealtime(0.3f);
			this.SceneTurnMaterial.SetTexture("_MainTex", this.textures[0]);
			this.SceneTurnMaterial.SetInt("_Mode", 0);
			for (int j = 0; j < this.textures.Count; j = num + 1)
			{
				this.SceneTurnMaterial.SetTexture("_MainTex", this.textures[j]);
				yield return new WaitForSecondsRealtime(0.016666668f);
				yield return new WaitForSecondsRealtime(0.016666668f);
				num = j;
			}
			this.Close();
			yield break;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000E6A0C File Offset: 0x000E4C0C
		private void SafeInvoke(Action a, string name = null)
		{
			bool flag = a == null;
			if (!flag)
			{
				try
				{
					a();
				}
				catch (Exception e)
				{
					Debug.LogException(new Exception("Exception in callback " + name, e));
				}
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000E6A5C File Offset: 0x000E4C5C
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
			methodContext.TargetType = typeof(InkTurnUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(InkTurnUI.OnDestroy()).MethodHandle, typeof(InkTurnUI).TypeHandle);
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

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000E6B58 File Offset: 0x000E4D58
		private void $Rougamo_Awake()
		{
			this.SceneTurnMaterial = Resources.Load<Material>("Material/PostProcess/SceneTurn");
			this.SceneTurnMaterial.SetTexture("_MainTex", null);
			this.SceneTurnMaterial.SetInt("_Mode", 1);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000E6B8F File Offset: 0x000E4D8F
		private void $Rougamo_Play()
		{
			this.Play(null, null);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000E6B9B File Offset: 0x000E4D9B
		private void $Rougamo_Play([Optional] Action firstUI, [Optional] Action secondUI)
		{
			Debug.Log("播放了一次墨水动画");
			base.StartCoroutine(this.PlayByFrames(firstUI, secondUI));
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000E6BB8 File Offset: 0x000E4DB8
		private void $Rougamo_FastPlay([Optional] Action firstUI, [Optional] Action secondUI)
		{
			base.StartCoroutine(this.FastPlayByFrames(firstUI, secondUI));
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000E6BCA File Offset: 0x000E4DCA
		private void $Rougamo_OnDestroy()
		{
			this.ClearEvent();
			base.StopAllCoroutines();
			this.SceneTurnMaterial.SetTexture("_MainTex", null);
			this.SceneTurnMaterial.SetInt("_Mode", 0);
		}

		// Token: 0x0400148C RID: 5260
		public Material SceneTurnMaterial;

		// Token: 0x0400148D RID: 5261
		public List<Texture2D> textures;
	}
}

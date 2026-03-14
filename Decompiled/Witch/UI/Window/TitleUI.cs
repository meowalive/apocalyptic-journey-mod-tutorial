using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using Cysharp.Threading.Tasks;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000334 RID: 820
	public class TitleUI : UIBase
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x000D9FE8 File Offset: 0x000D81E8
		[DebuggerStepThrough]
		public void ShowTitle(string main, string sub, string type)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TitleUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TitleUI.ShowTitle(string, string, string)).MethodHandle, typeof(TitleUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				main,
				sub,
				type
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
							main = null;
						}
						else
						{
							main = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							sub = null;
						}
						else
						{
							sub = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							type = null;
						}
						else
						{
							type = (string)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowTitle(main, sub, type);
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

		// Token: 0x060019CD RID: 6605 RVA: 0x000DA1A8 File Offset: 0x000D83A8
		private void $Rougamo_ShowTitle(string main, string sub, string type)
		{
			bool flag = type == "3" || type == "4";
			if (flag)
			{
				this.bossImage.gameObject.SetActive(true);
			}
			else
			{
				this.lineImage.gameObject.SetActive(true);
			}
			this.mainTitleTxt.text = main;
			this.subTitleTxt.text = sub;
			UniTask.WaitForSeconds(1.2f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
			{
				this.anim.SetBool("Show", false);
				UniTask.WaitForSeconds(0.7f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(new Action(this.Close));
			});
		}

		// Token: 0x040013B7 RID: 5047
		[SerializeField]
		private TMP_Text mainTitleTxt;

		// Token: 0x040013B8 RID: 5048
		[SerializeField]
		private TMP_Text subTitleTxt;

		// Token: 0x040013B9 RID: 5049
		[SerializeField]
		private Image lineImage;

		// Token: 0x040013BA RID: 5050
		[SerializeField]
		private Image bossImage;

		// Token: 0x040013BB RID: 5051
		[SerializeField]
		private Animator anim;
	}
}

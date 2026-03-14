using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x020002A8 RID: 680
	public class CaptionUI : UIBase
	{
		// Token: 0x06001563 RID: 5475 RVA: 0x000A9F28 File Offset: 0x000A8128
		private void Start()
		{
			this.styleDic.Add(CaptionStyle.Bottom, base.transform.Find("bottomStyle") as RectTransform);
			this.styleDic.Add(CaptionStyle.Top, base.transform.Find("topStyle") as RectTransform);
			this.styleDic.Add(CaptionStyle.Center, base.transform.Find("centerStyle") as RectTransform);
			this.stylePosDic.Add(CaptionStyle.Bottom, base.transform.Find("bottomStyle").localPosition);
			this.stylePosDic.Add(CaptionStyle.Top, base.transform.Find("topStyle").localPosition);
			this.stylePosDic.Add(CaptionStyle.Center, base.transform.Find("centerStyle").localPosition);
			foreach (KeyValuePair<CaptionStyle, RectTransform> item in this.styleDic)
			{
				item.Value.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="text">字幕文本</param>
		/// <param name="style">字幕样式</param>
		/// <param name="animationTime">动画持续时间（渐入，渐出）</param>
		/// <param name="delay">持续字幕时间（不包含渐入渐出）</param>
		/// <param name="animatonType">1.透明度,2.打字机,3向上渐出，4向下渐出</param>
		// Token: 0x06001564 RID: 5476 RVA: 0x000AA05C File Offset: 0x000A825C
		[DebuggerStepThrough]
		public void ShowCaption(string text, CaptionStyle style = CaptionStyle.Center, float animationTime = 1f, float delay = 0f, int animatonType = 0)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CaptionUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CaptionUI.ShowCaption(string, CaptionStyle, float, float, int)).MethodHandle, typeof(CaptionUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				text,
				style,
				animationTime,
				delay,
				animatonType
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
							style = CaptionStyle.Bottom;
						}
						else
						{
							style = (CaptionStyle)arguments[1];
						}
						if (arguments[2] == null)
						{
							animationTime = 0f;
						}
						else
						{
							animationTime = (float)arguments[2];
						}
						if (arguments[3] == null)
						{
							delay = 0f;
						}
						else
						{
							delay = (float)arguments[3];
						}
						if (arguments[4] == null)
						{
							animatonType = 0;
						}
						else
						{
							animatonType = (int)arguments[4];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowCaption(text, style, animationTime, delay, animatonType);
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
								goto IL_1A4;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_1A4:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x000AA26C File Offset: 0x000A846C
		private void $Rougamo_ShowCaption(string text, [Optional] CaptionStyle style, [Optional] float animationTime, [Optional] float delay, [Optional] int animatonType)
		{
			text = text.Localize("Tips");
			base.transform.SetAsLastSibling();
			RectTransform captionStyle = this.styleDic[style];
			TextMeshProUGUI captionText = captionStyle.Find("text").GetComponent<TextMeshProUGUI>();
			captionStyle.localPosition = this.stylePosDic[style];
			bool flag = DOTween.IsTweening(captionText, false) || DOTween.IsTweening(captionStyle.GetComponent<CanvasGroup>(), false);
			if (flag)
			{
				DOTween.Kill(captionText, false);
				DOTween.Kill(captionStyle.GetComponent<CanvasGroup>(), false);
				captionText.text = "";
				captionStyle.GetComponent<CanvasGroup>().alpha = 0f;
			}
			TweenCallback complete = delegate()
			{
				captionText.text = "";
				captionStyle.GetComponent<CanvasGroup>().alpha = 0f;
			};
			switch (animatonType)
			{
			case 0:
				captionText.text = text;
				captionStyle.GetComponent<CanvasGroup>().DOFade(1f, animationTime).OnKill(complete);
				captionText.DOText("", 0f, true, ScrambleMode.None, null).SetDelay(delay).SetEase(Ease.InBack).OnComplete(complete).OnKill(complete);
				break;
			case 1:
				captionText.text = "";
				captionText.DOText(text, animationTime, true, ScrambleMode.None, null);
				captionStyle.GetComponent<CanvasGroup>().DOFade(1f, animationTime).OnKill(complete);
				captionText.DOText("", 0f, true, ScrambleMode.None, null).SetDelay(delay).SetEase(Ease.InBack).OnComplete(complete).OnKill(complete);
				break;
			case 2:
				captionText.text = text;
				captionStyle.GetComponent<CanvasGroup>().DOFade(1f, 0f);
				captionStyle.DOLocalMoveY(captionStyle.GetComponent<RectTransform>().localPosition.y + 10f, animationTime, false).SetEase(Ease.InBack);
				captionStyle.GetComponent<CanvasGroup>().DOFade(0f, animationTime).SetEase(Ease.InBack).OnComplete(complete).OnKill(complete);
				break;
			case 3:
				captionText.text = text;
				captionStyle.GetComponent<CanvasGroup>().DOFade(1f, 0f);
				captionStyle.DOLocalMoveY(captionStyle.GetComponent<RectTransform>().localPosition.y - 10f, animationTime, false).SetEase(Ease.InBack);
				captionStyle.GetComponent<CanvasGroup>().DOFade(0f, animationTime).SetEase(Ease.InBack).OnComplete(complete).OnKill(complete);
				break;
			}
		}

		// Token: 0x040010F6 RID: 4342
		private Dictionary<CaptionStyle, RectTransform> styleDic = new Dictionary<CaptionStyle, RectTransform>();

		// Token: 0x040010F7 RID: 4343
		private Dictionary<CaptionStyle, Vector3> stylePosDic = new Dictionary<CaptionStyle, Vector3>();
	}
}

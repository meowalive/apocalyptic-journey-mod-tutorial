using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Token: 0x020000EF RID: 239
public class AnimatedHorizontalLayout : AnimatedLayout
{
	// Token: 0x06000801 RID: 2049 RVA: 0x0003FCA0 File Offset: 0x0003DEA0
	public override void SetLayout(RectTransform rectTransform, float pos, float duration)
	{
		bool flag = rectTransform == null;
		if (!flag)
		{
			bool flag2 = duration > 0f;
			if (flag2)
			{
				rectTransform.DOAnchorPosX(pos, duration, false).SetEase(this.ease);
			}
			else
			{
				rectTransform.anchoredPosition = new Vector2(pos, 0f);
			}
		}
	}
}

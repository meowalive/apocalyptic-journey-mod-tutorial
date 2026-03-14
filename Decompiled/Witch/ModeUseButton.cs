using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch
{
	// Token: 0x0200024F RID: 591
	public class ModeUseButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06001316 RID: 4886 RVA: 0x000964C8 File Offset: 0x000946C8
		public void OnPointerEnter(PointerEventData eventData)
		{
			this.whiteBack.GetComponent<CanvasGroup>().DOFade(1f, 0.2f);
			this.Hlight.GetComponent<CanvasGroup>().DOFade(1f, 0.2f);
			this.Normal.GetComponent<CanvasGroup>().DOFade(0f, 0.2f);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00096528 File Offset: 0x00094728
		public void OnPointerExit(PointerEventData eventData)
		{
			this.whiteBack.GetComponent<CanvasGroup>().DOFade(0f, 0.2f);
			this.Hlight.GetComponent<CanvasGroup>().DOFade(0f, 0.2f);
			this.Normal.GetComponent<CanvasGroup>().DOFade(1f, 0.2f);
		}

		// Token: 0x04000F7C RID: 3964
		public Transform whiteBack;

		// Token: 0x04000F7D RID: 3965
		public Transform Hlight;

		// Token: 0x04000F7E RID: 3966
		public Transform Normal;
	}
}

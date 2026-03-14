using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI
{
	// Token: 0x0200027D RID: 637
	public class UIEventTrigger : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x06001442 RID: 5186 RVA: 0x0009F034 File Offset: 0x0009D234
		public static UIEventTrigger Get(GameObject obj)
		{
			UIEventTrigger trigger = obj.GetComponent<UIEventTrigger>();
			bool flag = trigger == null;
			if (flag)
			{
				trigger = obj.AddComponent<UIEventTrigger>();
			}
			return trigger;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0009F064 File Offset: 0x0009D264
		public void OnPointerClick(PointerEventData eventData)
		{
			bool flag = this.onClick != null;
			if (flag)
			{
				this.onClick(base.gameObject, eventData);
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0009F094 File Offset: 0x0009D294
		public void OnPointerEnter(PointerEventData eventData)
		{
			bool flag = this.EnterPoint != null;
			if (flag)
			{
				this.EnterPoint(base.gameObject, eventData);
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0009F0C4 File Offset: 0x0009D2C4
		public void OnPointerExit(PointerEventData eventData)
		{
			bool flag = this.ExitPoint != null;
			if (flag)
			{
				this.ExitPoint(base.gameObject, eventData);
			}
		}

		// Token: 0x0400105F RID: 4191
		public Action<GameObject, PointerEventData> onClick;

		// Token: 0x04001060 RID: 4192
		public Action<GameObject, PointerEventData> EnterPoint;

		// Token: 0x04001061 RID: 4193
		public Action<GameObject, PointerEventData> ExitPoint;
	}
}

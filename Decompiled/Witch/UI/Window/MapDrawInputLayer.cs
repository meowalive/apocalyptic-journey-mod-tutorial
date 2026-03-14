using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x0200032C RID: 812
	public sealed class MapDrawInputLayer : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x000D47C1 File Offset: 0x000D29C1
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x000D47C9 File Offset: 0x000D29C9
		public MapSelectUI Owner { get; set; }

		// Token: 0x06001952 RID: 6482 RVA: 0x000D47D2 File Offset: 0x000D29D2
		private void Awake()
		{
			this._rectTransform = (base.transform as RectTransform);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000D47E8 File Offset: 0x000D29E8
		public void OnPointerDown(PointerEventData eventData)
		{
			bool flag = this.Owner == null || eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				Vector2 localPoint;
				bool flag2 = this.TryGetLocalPoint(eventData, out localPoint);
				if (flag2)
				{
					this.Owner.HandleDrawPointerDown(localPoint);
				}
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x000D4834 File Offset: 0x000D2A34
		public void OnDrag(PointerEventData eventData)
		{
			bool flag = this.Owner == null || eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				Vector2 localPoint;
				bool flag2 = this.TryGetLocalPoint(eventData, out localPoint);
				if (flag2)
				{
					this.Owner.HandleDrawPointerDrag(localPoint);
				}
			}
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000D4880 File Offset: 0x000D2A80
		public void OnPointerUp(PointerEventData eventData)
		{
			bool flag = this.Owner == null || eventData.button > PointerEventData.InputButton.Left;
			if (!flag)
			{
				Vector2 localPoint;
				bool flag2 = this.TryGetLocalPoint(eventData, out localPoint);
				if (flag2)
				{
					this.Owner.HandleDrawPointerUp(localPoint);
				}
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000D48CC File Offset: 0x000D2ACC
		private bool TryGetLocalPoint(PointerEventData eventData, out Vector2 localPoint)
		{
			bool flag = this._rectTransform == null;
			if (flag)
			{
				this._rectTransform = (base.transform as RectTransform);
			}
			return RectTransformUtility.ScreenPointToLocalPointInRectangle(this._rectTransform, eventData.position, eventData.pressEventCamera, out localPoint);
		}

		// Token: 0x04001387 RID: 4999
		private RectTransform _rectTransform;
	}
}

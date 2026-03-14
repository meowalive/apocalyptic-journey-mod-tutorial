using System;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x0200031F RID: 799
	public class ItemNonDrag : Item
	{
		// Token: 0x060018F1 RID: 6385 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000D2000 File Offset: 0x000D0200
		public override void OnPointerClick(PointerEventData eventData)
		{
			bool flag = !this.canClick;
			if (!flag)
			{
				bool flag2 = eventData.button == PointerEventData.InputButton.Right;
				if (flag2)
				{
					this.ShowFloatingWindow();
				}
				bool flag3 = eventData.button == PointerEventData.InputButton.Left;
				if (flag3)
				{
					this.HideFloatingWindow();
				}
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000D204C File Offset: 0x000D024C
		public new virtual void OnDestroy()
		{
			bool isCancellationRequested = Singleton<GameConfigManager>.Instance.cts.Token.IsCancellationRequested;
			if (!isCancellationRequested)
			{
				this.ClearEvent();
			}
		}
	}
}

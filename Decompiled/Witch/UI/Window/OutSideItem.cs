using System;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x0200034F RID: 847
	public class OutSideItem : ItemNonDrag
	{
		// Token: 0x06001A73 RID: 6771 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x04001467 RID: 5223
		public bool isgoods;

		// Token: 0x04001468 RID: 5224
		public OutsiderShopUI outsiderShopUI;
	}
}

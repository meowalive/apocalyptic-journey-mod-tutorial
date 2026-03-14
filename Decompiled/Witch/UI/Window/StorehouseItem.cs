using System;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x02000328 RID: 808
	public class StorehouseItem : ItemNonDrag
	{
		// Token: 0x06001934 RID: 6452 RVA: 0x000D3CB8 File Offset: 0x000D1EB8
		public void Start()
		{
			this.itemPrice = int.Parse(this.dataConfig.data["Rarity"]) * 10;
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x000D3CDE File Offset: 0x000D1EDE
		public override void OnPointerEnter(PointerEventData eventData)
		{
			this.storehouseUI.SetCurrentItem(this);
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x000D3CEE File Offset: 0x000D1EEE
		public override void OnPointerExit(PointerEventData eventData)
		{
			this.storehouseUI.ExitCureentItem();
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x04001380 RID: 4992
		public StorehouseUI storehouseUI;
	}
}

using System;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x02000318 RID: 792
	public class DictionaryShowItem : ItemNonDrag
	{
		// Token: 0x060018AD RID: 6317 RVA: 0x000D01F7 File Offset: 0x000CE3F7
		public override void Init(DataConfig dataConfig)
		{
			this.dataConfig = dataConfig;
			ICard.SetCardStyle(base.transform, dataConfig);
			this.DataUpdate();
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000D0218 File Offset: 0x000CE418
		public override void DataUpdate()
		{
			bool flag = this.dataConfig == null;
			if (!flag)
			{
				ICard.SetCardMsg(base.transform, this.dataConfig, null);
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void ShowFloatingWindow()
		{
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0400134D RID: 4941
		public DictionaryUI dictionaryUI;

		// Token: 0x0400134E RID: 4942
		public int defaultCount;
	}
}

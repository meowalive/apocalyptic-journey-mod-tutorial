using System;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x02000317 RID: 791
	public class DictionaryItem : ItemNonDrag
	{
		// Token: 0x060018A5 RID: 6309 RVA: 0x000D01B4 File Offset: 0x000CE3B4
		public override void Init(DataConfig dataConfig)
		{
			base.Init(dataConfig);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000D01BF File Offset: 0x000CE3BF
		public override void Awake()
		{
			this.lastParent = base.transform.parent;
			this.floatingWindow = UIManager.Instance.GetFloatingWindow();
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000D01E3 File Offset: 0x000CE3E3
		private void OnEnable()
		{
			this.DataUpdate();
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000D01ED File Offset: 0x000CE3ED
		private void OnDisable()
		{
			this.ClearEvent();
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void DataUpdate()
		{
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0400134C RID: 4940
		public DictionaryUI dictionaryUI;
	}
}

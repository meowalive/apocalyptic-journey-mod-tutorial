using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x02000320 RID: 800
	public class PageItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x060018F7 RID: 6391 RVA: 0x000D207F File Offset: 0x000D027F
		public void OnPointerClick(PointerEventData pointerEvent)
		{
			this.dictionaryUI.page = base.transform.GetSiblingIndex();
			this.dictionaryUI.SelectCardByPage();
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000D20A4 File Offset: 0x000D02A4
		private void OnDisable()
		{
			base.gameObject.GetComponent<SwitchButton>().isOn = false;
		}

		// Token: 0x0400136C RID: 4972
		public DictionaryUI dictionaryUI;
	}
}

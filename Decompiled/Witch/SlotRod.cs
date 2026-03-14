using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch
{
	// Token: 0x0200024B RID: 587
	public class SlotRod : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x00095C38 File Offset: 0x00093E38
		public void OnPointerClick(PointerEventData eventData)
		{
			this.slotMachUI.RandomAgain();
		}

		// Token: 0x04000F6B RID: 3947
		public SlotMachUI slotMachUI;
	}
}

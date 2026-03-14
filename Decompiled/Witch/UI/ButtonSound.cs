using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI
{
	// Token: 0x02000271 RID: 625
	public class ButtonSound : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler
	{
		// Token: 0x060013E4 RID: 5092 RVA: 0x0009BCA4 File Offset: 0x00099EA4
		public void OnPointerDown(PointerEventData eventData)
		{
			bool flag = !this.useDownSound;
			if (!flag)
			{
				bool flag2 = this.metal;
				if (flag2)
				{
					AudioManager instance = AudioManager.Instance;
					if (instance != null)
					{
						instance.PlayEffect("NewSounds/UI与按钮/金属按钮-点击");
					}
				}
				else
				{
					AudioManager instance2 = AudioManager.Instance;
					if (instance2 != null)
					{
						instance2.PlayEffect("NewSounds/UI与按钮/纯色按钮-点击");
					}
				}
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0009BD00 File Offset: 0x00099F00
		public void OnPointerEnter(PointerEventData eventData)
		{
			bool flag = this.metal;
			if (flag)
			{
				AudioManager instance = AudioManager.Instance;
				if (instance != null)
				{
					instance.PlayEffect("NewSounds/UI与按钮/金属按钮-悬浮");
				}
			}
			else
			{
				AudioManager instance2 = AudioManager.Instance;
				if (instance2 != null)
				{
					instance2.PlayEffect("NewSounds/UI与按钮/纯色按钮-悬浮");
				}
			}
		}

		// Token: 0x04001023 RID: 4131
		public bool metal;

		// Token: 0x04001024 RID: 4132
		public bool useDownSound = true;
	}
}

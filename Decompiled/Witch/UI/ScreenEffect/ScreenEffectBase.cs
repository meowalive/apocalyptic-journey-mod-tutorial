using System;
using UnityEngine;

namespace UI.ScreenEffect
{
	// Token: 0x020001C0 RID: 448
	public abstract class ScreenEffectBase : MonoBehaviour
	{
		// Token: 0x06000FCD RID: 4045 RVA: 0x00083479 File Offset: 0x00081679
		protected void Start()
		{
			this.Play();
		}

		// Token: 0x06000FCE RID: 4046
		public abstract void Play();

		// Token: 0x04000DEF RID: 3567
		public float delay;
	}
}

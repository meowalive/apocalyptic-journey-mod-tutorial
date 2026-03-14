using System;
using DG.Tweening;
using UnityEngine;

namespace UI.ScreenEffect
{
	// Token: 0x020001C1 RID: 449
	public class ShakeScreenEffect : ScreenEffectBase
	{
		// Token: 0x06000FD0 RID: 4048 RVA: 0x00083484 File Offset: 0x00081684
		public override void Play()
		{
			bool flag = this.count <= 0 || this.duration <= 0f || this.intensity <= 0f;
			if (flag)
			{
				Debug.LogWarning("ShakeScreenEffect parameters are not set correctly.");
			}
			else
			{
				bool flag2 = Camera.main != null;
				if (flag2)
				{
					Camera camera = Camera.main;
					Vector3 startpos = new Vector3(camera.transform.localPosition.x, 0f, -5f);
					camera.transform.DOShakePosition(this.duration, this.intensity, this.count, 360f, false, true, ShakeRandomnessMode.Full).SetDelay(this.delay).OnKill(delegate
					{
						Camera.main.transform.localPosition = startpos;
					});
				}
			}
		}

		// Token: 0x04000DF0 RID: 3568
		public int count;

		// Token: 0x04000DF1 RID: 3569
		public float duration;

		// Token: 0x04000DF2 RID: 3570
		public float intensity;
	}
}

using System;
using UnityEngine;
using Witch.UI;

// Token: 0x0200007E RID: 126
public abstract class EffectBase : ScriptableObject
{
	// Token: 0x060003C6 RID: 966 RVA: 0x0001F7F8 File Offset: 0x0001D9F8
	public virtual void Play(IStatusManager status, bool isReverse = false)
	{
		this.effect = UnityEngine.Object.Instantiate<GameObject>(this.effectPrefab, UIManager.Instance.effectContent);
		this.effect.transform.localScale = Vector3.one;
		this.effect.name = base.name;
		this.SetEffectPosition(status);
		if (isReverse)
		{
			this.effect.transform.localScale = new Vector3(-this.effect.transform.localScale.x, this.effect.transform.localScale.y, this.effect.transform.localScale.z);
		}
		UnityEngine.Object.Destroy(this.effect, this.duration);
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
	protected void SetEffectPosition(IStatusManager status)
	{
		bool flag = status.IsNull();
		if (!flag)
		{
			bool flag2 = this.positionType == EffectBase.PositionType.Top;
			if (flag2)
			{
				this.effect.transform.position = status.transform.Find("head").position;
			}
			else
			{
				bool flag3 = this.positionType == EffectBase.PositionType.Bottom;
				if (flag3)
				{
					this.effect.transform.position = status.transform.Find("bottom").position;
				}
				else
				{
					bool flag4 = this.positionType == EffectBase.PositionType.Center;
					if (flag4)
					{
						this.effect.transform.position = status.transform.Find("center").position;
					}
				}
			}
		}
	}

	// Token: 0x04000991 RID: 2449
	public GameObject effectPrefab;

	// Token: 0x04000992 RID: 2450
	public float duration;

	// Token: 0x04000993 RID: 2451
	public EffectBase.Target target;

	// Token: 0x04000994 RID: 2452
	public GameObject effect;

	// Token: 0x04000995 RID: 2453
	public EffectBase.PositionType positionType = EffectBase.PositionType.Center;

	// Token: 0x0200007F RID: 127
	[Flags]
	public enum Target
	{
		// Token: 0x04000997 RID: 2455
		None = 0,
		// Token: 0x04000998 RID: 2456
		Self = 1,
		// Token: 0x04000999 RID: 2457
		Target = 2
	}

	// Token: 0x02000080 RID: 128
	public enum PositionType
	{
		// Token: 0x0400099B RID: 2459
		Center,
		// Token: 0x0400099C RID: 2460
		Top,
		// Token: 0x0400099D RID: 2461
		Bottom
	}
}

using System;
using DG.Tweening;
using UnityEngine;
using Witch.UI;

// Token: 0x02000079 RID: 121
[CreateAssetMenu(fileName = "CardEffectInfo", menuName = "EffectInfo/BulletEffectInfo", order = 0)]
public class BulletEffectInfo : EffectBase
{
	// Token: 0x060003BD RID: 957 RVA: 0x0001F3D0 File Offset: 0x0001D5D0
	public override void Play(IStatusManager status, bool isReverse = false)
	{
		GameObject effect = UnityEngine.Object.Instantiate<GameObject>(this.effectPrefab, UIManager.Instance.effectContent);
		effect.transform.localEulerAngles = this.initAngle;
		effect.name = base.name;
		effect.transform.position = status.transform.position;
		if (isReverse)
		{
			effect.transform.localScale = new Vector3(-effect.transform.localScale.x, effect.transform.localScale.y, effect.transform.localScale.z);
		}
		effect.transform.DOMove(this.speed * Vector3.right, this.duration, false);
		UnityEngine.Object.Destroy(effect, this.duration);
	}

	// Token: 0x04000983 RID: 2435
	public Vector3 initAngle;

	// Token: 0x04000984 RID: 2436
	public float speed;
}

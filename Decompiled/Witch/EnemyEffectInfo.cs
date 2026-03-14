using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using Witch.UI;

// Token: 0x02000086 RID: 134
[CreateAssetMenu(fileName = "EnemyEffectInfo", menuName = "EffectInfo/EnemyEffectInfo", order = 0)]
public class EnemyEffectInfo : EffectBase
{
	// Token: 0x060003DF RID: 991 RVA: 0x000206FC File Offset: 0x0001E8FC
	public override void Play(IStatusManager status, bool isReverse = false)
	{
		EnemyEffectInfo.<>c__DisplayClass3_0 CS$<>8__locals1 = new EnemyEffectInfo.<>c__DisplayClass3_0();
		CS$<>8__locals1.status = status;
		CS$<>8__locals1.<>4__this = this;
		this.effect = UnityEngine.Object.Instantiate<GameObject>(this.effectPrefab, UIManager.Instance.effectContent);
		this.effect.transform.localEulerAngles = this.initAngle;
		this.effect.name = base.name;
		base.SetEffectPosition(CS$<>8__locals1.status);
		CS$<>8__locals1.scale = this.effect.transform.localScale;
		bool flag = !isReverse;
		if (flag)
		{
			CS$<>8__locals1.scale = new Vector3(-CS$<>8__locals1.scale.x, CS$<>8__locals1.scale.y, CS$<>8__locals1.scale.z);
		}
		this.effect.transform.localEulerAngles += new Vector3(0f, 0f, UnityEngine.Random.Range(-10f, 10f));
		UniTask.Create(delegate()
		{
			EnemyEffectInfo.<>c__DisplayClass3_0.<<Play>b__0>d <<Play>b__0>d = new EnemyEffectInfo.<>c__DisplayClass3_0.<<Play>b__0>d();
			<<Play>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<Play>b__0>d.<>4__this = CS$<>8__locals1;
			<<Play>b__0>d.<>1__state = -1;
			<<Play>b__0>d.<>t__builder.Start<EnemyEffectInfo.<>c__DisplayClass3_0.<<Play>b__0>d>(ref <<Play>b__0>d);
			return <<Play>b__0>d.<>t__builder.Task;
		});
		UnityEngine.Object.Destroy(this.effect, this.duration);
	}

	// Token: 0x040009A9 RID: 2473
	public EnemyEffectInfo.Type type;

	// Token: 0x040009AA RID: 2474
	public Vector3 initAngle;

	// Token: 0x02000087 RID: 135
	public enum Type
	{
		// Token: 0x040009AC RID: 2476
		Default,
		// Token: 0x040009AD RID: 2477
		Area
	}
}

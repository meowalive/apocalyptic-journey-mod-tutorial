using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using Witch.UI;

// Token: 0x0200007A RID: 122
[CreateAssetMenu(fileName = "CardEffectInfo", menuName = "EffectInfo/CardEffectInfo", order = 0)]
public class CardEffectInfo : EffectBase
{
	// Token: 0x060003BF RID: 959 RVA: 0x0001F4AC File Offset: 0x0001D6AC
	public override void Play(IStatusManager status, bool isReverse = false)
	{
		CardEffectInfo.<>c__DisplayClass3_0 CS$<>8__locals1 = new CardEffectInfo.<>c__DisplayClass3_0();
		CS$<>8__locals1.status = status;
		CS$<>8__locals1.<>4__this = this;
		this.effect = UnityEngine.Object.Instantiate<GameObject>(this.effectPrefab, UIManager.Instance.effectContent);
		this.effect.transform.localEulerAngles = this.initAngle;
		this.effect.name = base.name;
		base.SetEffectPosition(CS$<>8__locals1.status);
		CS$<>8__locals1.scale = this.effect.transform.localScale;
		if (isReverse)
		{
			CS$<>8__locals1.scale = new Vector3(-CS$<>8__locals1.scale.x, CS$<>8__locals1.scale.y, CS$<>8__locals1.scale.z);
		}
		this.effect.transform.localEulerAngles += new Vector3(0f, 0f, UnityEngine.Random.Range(-10f, 10f));
		UniTask.Create(delegate()
		{
			CardEffectInfo.<>c__DisplayClass3_0.<<Play>b__0>d <<Play>b__0>d = new CardEffectInfo.<>c__DisplayClass3_0.<<Play>b__0>d();
			<<Play>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<Play>b__0>d.<>4__this = CS$<>8__locals1;
			<<Play>b__0>d.<>1__state = -1;
			<<Play>b__0>d.<>t__builder.Start<CardEffectInfo.<>c__DisplayClass3_0.<<Play>b__0>d>(ref <<Play>b__0>d);
			return <<Play>b__0>d.<>t__builder.Task;
		});
		UnityEngine.Object.Destroy(this.effect, this.duration);
	}

	// Token: 0x04000985 RID: 2437
	public CardEffectInfo.Type type;

	// Token: 0x04000986 RID: 2438
	public Vector3 initAngle;

	// Token: 0x0200007B RID: 123
	public enum Type
	{
		// Token: 0x04000988 RID: 2440
		Default,
		// Token: 0x04000989 RID: 2441
		Area
	}
}

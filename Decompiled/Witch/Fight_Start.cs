using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;

// Token: 0x02000095 RID: 149
public class Fight_Start : FightUnit
{
	// Token: 0x06000435 RID: 1077 RVA: 0x000234A8 File Offset: 0x000216A8
	public override void Init()
	{
		UniTask.WaitForSeconds(0.3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			bool flag = FightManager.Instance == null;
			if (!flag)
			{
				foreach (KeyValuePair<string, StatusManager> item in FightManager.Instance.statuses)
				{
					bool flag2 = item.Value != null;
					if (flag2)
					{
						Singleton<EventCenter>.Instance.EventTrigger("FightStart" + item.Key);
						item.Value.PlayVocal(IStatusManager.VocalState.FightStart);
					}
				}
				UniTask.WaitForSeconds(0.3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
				{
					bool flag3 = FightManager.Instance == null;
					if (!flag3)
					{
						FightManager.Instance.StartCoroutine(FightManager.Instance.DOAllAction());
					}
				}).Forget();
			}
		}).Forget();
	}
}

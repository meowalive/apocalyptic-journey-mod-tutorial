using System;
using System.Collections.Generic;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000091 RID: 145
public class Fight_Loss : FightUnit
{
	// Token: 0x0600042B RID: 1067 RVA: 0x00023008 File Offset: 0x00021208
	public override void Init()
	{
		bool flag = FightManager.Instance.fightType == FightType.Win || FightManager.Instance.fightType == FightType.None;
		if (!flag)
		{
			bool flag2 = EnemyManager.Instance.enemyList.Count != 0;
			if (flag2)
			{
				List<Enemy> enemyList = new List<Enemy>(EnemyManager.Instance.enemyList);
				foreach (Enemy item in enemyList)
				{
					bool flag3 = item.gameObject != null;
					if (flag3)
					{
						UnityEngine.Object.Destroy(item.gameObject);
					}
				}
			}
			UIManager.Instance.CloseUI("FightUI");
			UIManager.Instance.CloseUI("PopUpTextUI");
			Singleton<EventCenter>.Instance.Clear(new EventDispose[]
			{
				EventDispose.OnFightEnd,
				EventDispose.OnTrigger
			});
			bool flag4 = PlayerManager.Instance.isServer && FightManager.Instance.fightType > FightType.None;
			if (flag4)
			{
				FightManager.Instance.CmdChangeType(FightType.None);
			}
			FightManager.Instance.ActionQueue.Clear();
			UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
			Singleton<BlessingRelic>.Instance.Clear();
		}
	}
}

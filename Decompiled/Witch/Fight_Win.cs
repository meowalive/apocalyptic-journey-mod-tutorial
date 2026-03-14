using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000097 RID: 151
public class Fight_Win : FightUnit
{
	// Token: 0x0600043B RID: 1083 RVA: 0x00023624 File Offset: 0x00021824
	public override void Init()
	{
		bool flag = FightManager.Instance == null || FightManager.Instance.fightType == FightType.Loss || FightManager.Instance.fightType == FightType.None;
		if (flag)
		{
			Debug.Log("没有实例了" + FightManager.Instance.fightType.ToString());
		}
		else
		{
			FightManager.Instance.ChangeUnit(FightType.None);
			UniTask.WaitUntil(() => UIManager.Instance.GetUI<FightUI>("FightUI") == null || !UIManager.Instance.GetUI<FightUI>("FightUI").NowAnimation, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
			{
				this.WinLogic();
				bool flag2 = FightManager.Instance == null;
				if (flag2)
				{
					Debug.Log("没有实例了");
				}
				else
				{
					bool flag3 = UIManager.Instance.GetUI<FightUI>("FightUI") == null;
					if (!flag3)
					{
						this.ResetStates();
					}
				}
			}).Forget();
		}
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x000236DC File Offset: 0x000218DC
	private void ResetStates()
	{
		Fight_Win.RewardMul = EnemyManager.SettlementMultiplier;
		Singleton<EventCenter>.Instance.EventTrigger("Win");
		RoleTable.Instance.sumFeat += 150 * Fight_Win.RewardMul;
		Singleton<EventCenter>.Instance.Clear(new EventDispose[]
		{
			EventDispose.OnFightEnd,
			EventDispose.OnTrigger
		});
		bool flag = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<TopBarUI>("TopBarUI").FightHide();
			UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeVar();
			UIManager.Instance.GetUI<TopBarUI>("TopBarUI").UpdateRelicCountShow();
		}
		UIManager.Instance.CloseUI("PopUpTextUI");
		bool flag2 = FightManager.Instance == null;
		if (flag2)
		{
			Debug.Log("没有实例了");
		}
		else
		{
			FightManager.Instance.ActionQueue.Clear();
			bool flag3 = FightManager.Instance.level != "level_*0" && FightManager.Instance.level != "level_10046";
			if (flag3)
			{
				bool isWin = Fight_Win.IsWin;
				if (isWin)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").ShowChest();
				}
				else
				{
					bool inHighTide = RoleTable.Instance.InHighTide;
					if (inHighTide)
					{
						RoleTable.Instance.InHighTide = false;
					}
					UIManager.Instance.CloseUI("FightUI");
					MapManager.Instance.TryChange();
				}
			}
			else
			{
				bool flag4 = !Fight_Win.IsWin;
				if (flag4)
				{
					Singleton<EventCenter>.Instance.EventTrigger("Winlevel_*0");
				}
				UIManager.Instance.CloseUI("FightUI");
				RoleTable.Instance.InHighTide = true;
			}
			BlessingRelic instance = Singleton<BlessingRelic>.Instance;
			if (instance != null)
			{
				instance.Clear();
			}
		}
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x000238B8 File Offset: 0x00021AB8
	private void WinLogic()
	{
		List<string> keys = new List<string>(RoleTable.Instance.SkillTime.Keys);
		foreach (string key in keys)
		{
			RoleTable.Instance.SkillTime[key] = 0;
		}
		try
		{
			bool flag = EnemyManager.Instance != null && EnemyManager.Instance.enemyList != null && EnemyManager.Instance.enemyList.Count != 0;
			if (flag)
			{
				List<Enemy> enemyList = new List<Enemy>(EnemyManager.Instance.enemyList);
				foreach (Enemy item in enemyList)
				{
					bool flag2 = item.gameObject != null;
					if (flag2)
					{
						UnityEngine.Object.Destroy(item.gameObject);
					}
				}
			}
		}
		catch (Exception e)
		{
			Debug.LogWarning(e);
		}
		bool isWin = Fight_Win.IsWin;
		if (isWin)
		{
			bool flag3 = FightPlayer.Instance != null && FightManager.Instance != null;
			if (flag3)
			{
				bool flag4 = FightManager.Instance.level != "level_10046";
				if (flag4)
				{
					Singleton<EventCenter>.Instance.EventTrigger("Win" + FightManager.Instance.level);
				}
				else
				{
					Singleton<EventCenter>.Instance.EventTrigger("Winlevel_*0");
				}
				bool flag5 = FightPlayer.Instance.Status != null;
				if (flag5)
				{
					Singleton<EventCenter>.Instance.EventTrigger("Win" + FightPlayer.Instance.Status.InstanceId);
				}
			}
		}
		else
		{
			bool flag6 = FightPlayer.Instance != null && FightPlayer.Instance.Status != null;
			if (flag6)
			{
				Singleton<EventCenter>.Instance.EventTrigger("Escape" + FightPlayer.Instance.Status.InstanceId);
			}
		}
	}

	// Token: 0x040009CE RID: 2510
	public static int RewardMul;

	// Token: 0x040009CF RID: 2511
	public static bool IsWin = true;
}

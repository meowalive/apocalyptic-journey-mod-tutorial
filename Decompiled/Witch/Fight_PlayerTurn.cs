using System;
using Component.UI.Animation;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000094 RID: 148
public class Fight_PlayerTurn : FightUnit
{
	// Token: 0x06000431 RID: 1073 RVA: 0x00023240 File Offset: 0x00021440
	public override void Init()
	{
		bool isReset = FightUI.IsReset;
		if (isReset)
		{
			FightUI.IsReset = false;
		}
		else
		{
			bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<FightUI>("FightUI").transform.Find("ClockBoard").GetComponent<ClockAnimator>().RotateToSelf();
			}
			UIManager.Instance.ShowTip("Your turn".Localize("FightUI"), delegate
			{
				bool flag2 = UIManager.Instance.GetUI<FightUI>("FightUI") == null;
				if (!flag2)
				{
					IStatusManager status = FightPlayer.Instance.Status;
					bool flag3 = status.state > IStatusManager.State.Default;
					if (flag3)
					{
						status.dynamicVariables["thisHP"] = 0f;
						bool flag4 = status.state == IStatusManager.State.NoAction;
						if (flag4)
						{
							status.state = IStatusManager.State.Default;
						}
						FightManager.Instance.TurnEnd();
					}
					else
					{
						bool flag5 = !FightUI.InIEn;
						if (flag5)
						{
							CardItem.canUse = true;
						}
						UIManager.Instance.GetUI<FightUI>("FightUI").turnButton.gameObject.SetActive(true);
						UIManager.Instance.GetUI<FightUI>("FightUI").turnButton.Interactable(true);
						status.dynamicVariables["thisHP"] = 0f;
						bool flag6 = FightPlayer.Instance.CurPowerCount < FightPlayer.Instance.MaxPowerCount;
						if (flag6)
						{
							FightPlayer.Instance.CurPowerCount = FightPlayer.Instance.MaxPowerCount;
						}
						Singleton<EventCenter>.Instance.EventTrigger("StartRound" + FightPlayer.Instance.Status.InstanceId);
						this.ShouldCard = (int)status.dynamicVariables["RoundCard"];
						bool isDead = RoleTable.Instance.isDead;
						if (!isDead)
						{
							status.UpdateStatus(true);
							FightPlayer.Instance.StartBoredTimer();
							UIManager.Instance.GetUI<FightUI>("FightUI").StartClock();
							UIManager.Instance.GetUI<FightUI>("FightUI").CreateCardItem(this.ShouldCard);
							UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardItemPos(null, null);
							UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardMsg();
						}
					}
				}
			});
		}
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x000026D9 File Offset: 0x000008D9
	public override void OnUpdate()
	{
	}

	// Token: 0x040009C9 RID: 2505
	public int ShouldCard;

	// Token: 0x040009CA RID: 2506
	public string NowActionId;
}

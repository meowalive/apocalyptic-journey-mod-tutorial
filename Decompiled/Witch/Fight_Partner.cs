using System;
using Component.UI.Animation;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000093 RID: 147
public class Fight_Partner : FightUnit
{
	// Token: 0x0600042F RID: 1071 RVA: 0x000231DC File Offset: 0x000213DC
	public override void Init()
	{
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
		if (flag)
		{
			FightPlayer.Instance.Status.animatedState = IStatusManager.AnimatedState.Idle;
			UIManager.Instance.GetUI<FightUI>("FightUI").transform.Find("ClockBoard").GetComponent<ClockAnimator>().RotateToFriend();
		}
	}
}

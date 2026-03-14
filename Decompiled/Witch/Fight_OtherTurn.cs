using System;
using Component.UI.Animation;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000092 RID: 146
public class Fight_OtherTurn : FightUnit
{
	// Token: 0x0600042D RID: 1069 RVA: 0x0002315C File Offset: 0x0002135C
	public override void Init()
	{
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").transform.Find("ClockBoard").GetComponent<ClockAnimator>().RotateToFriend();
		}
		UIManager.Instance.ShowTip("开始行动", null);
		UIManager.Instance.GetUI<FightUI>("FightUI").turnButton.Interactable(false);
	}
}

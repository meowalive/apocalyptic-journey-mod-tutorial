using System;
using Component.UI.Animation;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000090 RID: 144
public class Fight_EnemyTurn : FightUnit
{
	// Token: 0x06000429 RID: 1065 RVA: 0x00022FB4 File Offset: 0x000211B4
	public override void Init()
	{
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").transform.Find("ClockBoard").GetComponent<ClockAnimator>().RotateToEnemy();
		}
	}
}

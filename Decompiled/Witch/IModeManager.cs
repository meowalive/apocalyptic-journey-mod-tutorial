using System;
using Data.Save;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x02000230 RID: 560
	public interface IModeManager
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060011DC RID: 4572
		// (set) Token: 0x060011DD RID: 4573
		bool lazyLoad { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060011DE RID: 4574
		// (set) Token: 0x060011DF RID: 4575
		Dice NowDice { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060011E0 RID: 4576
		// (set) Token: 0x060011E1 RID: 4577
		int Level { get; set; }

		// Token: 0x060011E2 RID: 4578 RVA: 0x000026D9 File Offset: 0x000008D9
		void ReadyToChangeMap()
		{
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000026D9 File Offset: 0x000008D9
		void GeneratrMap()
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00038DF2 File Offset: 0x00036FF2
		MapTree MapTree
		{
			get
			{
				return GameSaveManager.MapTree;
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000026D9 File Offset: 0x000008D9
		void ShowMapSelect()
		{
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000026D9 File Offset: 0x000008D9
		void RpcLoadMap(string type, string id)
		{
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000026D9 File Offset: 0x000008D9
		void MapItemInit(MapSelectUI mapSelectUI)
		{
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0008C6B8 File Offset: 0x0008A8B8
		bool WinTheGame()
		{
			return false;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0008C6CC File Offset: 0x0008A8CC
		RoleTable InitRoleTable(RoleTable roleTable)
		{
			return roleTable;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000026D9 File Offset: 0x000008D9
		void SetReward(BattleRewardsUI battleRewardsUI)
		{
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000026D9 File Offset: 0x000008D9
		void MapUIStart(MapSelectUI mapSelectUI)
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x000026D9 File Offset: 0x000008D9
		void CloseMapUI()
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000026D9 File Offset: 0x000008D9
		void SetRewardType(string rewardType)
		{
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000026D9 File Offset: 0x000008D9
		void CardCountSet(RoleTable roleTable)
		{
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0008C6E0 File Offset: 0x0008A8E0
		public static void ResetCount()
		{
			bool flag = RoleTable.Instance == null;
			if (!flag)
			{
				RoleTable.Instance.SafeBoxRelicCount = 1;
				RoleTable.Instance.SafeBoxCardCount = 1;
				RoleTable.Instance.SafeBoxSaveMoneyCount = 5;
				RoleTable.Instance.SafeBoxGetMoneyCount = 5;
			}
		}
	}
}

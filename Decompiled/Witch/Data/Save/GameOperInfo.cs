using System;
using System.Collections.Generic;

namespace Data.Save
{
	// Token: 0x02000223 RID: 547
	public class GameOperInfo
	{
		// Token: 0x04000EA9 RID: 3753
		public string PlayerId;

		// Token: 0x04000EAA RID: 3754
		public GameOperInfo.ItemsInfo HardTags = new GameOperInfo.ItemsInfo();

		// Token: 0x04000EAB RID: 3755
		public GameOperInfo.ItemsInfo Cards = new GameOperInfo.ItemsInfo();

		// Token: 0x04000EAC RID: 3756
		public GameOperInfo.ItemsInfo Relics = new GameOperInfo.ItemsInfo();

		// Token: 0x04000EAD RID: 3757
		public GameOperInfo.ItemsInfo Blessings = new GameOperInfo.ItemsInfo();

		// Token: 0x02000224 RID: 548
		public class ItemsInfo
		{
			/// <summary> 物品出现在BattleRewards的操作 </summary>
			// Token: 0x04000EAE RID: 3758
			public List<GameOperInfo.ItemsInfo.Info> RewardShow = new List<GameOperInfo.ItemsInfo.Info>();

			/// <summary> 物品在BattleRewards选取的操作 </summary>
			// Token: 0x04000EAF RID: 3759
			public List<GameOperInfo.ItemsInfo.Info> Select = new List<GameOperInfo.ItemsInfo.Info>();

			/// <summary> 物品删除 </summary>
			// Token: 0x04000EB0 RID: 3760
			public List<GameOperInfo.ItemsInfo.Info> Delete = new List<GameOperInfo.ItemsInfo.Info>();

			/// <summary> 物品购买的操作 </summary>
			// Token: 0x04000EB1 RID: 3761
			public List<GameOperInfo.ItemsInfo.Info> ShopShow = new List<GameOperInfo.ItemsInfo.Info>();

			/// <summary> 物品购买的操作 </summary>
			// Token: 0x04000EB2 RID: 3762
			public List<GameOperInfo.ItemsInfo.Info> Buy = new List<GameOperInfo.ItemsInfo.Info>();

			// Token: 0x02000225 RID: 549
			public class Info
			{
				// Token: 0x06001195 RID: 4501 RVA: 0x00002540 File Offset: 0x00000740
				public Info()
				{
				}

				// Token: 0x06001196 RID: 4502 RVA: 0x0008B204 File Offset: 0x00089404
				public Info(string name)
				{
					this.Name = name;
					this.Level = ((MapManager.Instance != null) ? MapManager.Instance.Level.ToString() : "1");
				}

				// Token: 0x04000EB3 RID: 3763
				public string Name;

				// Token: 0x04000EB4 RID: 3764
				public string Level;
			}
		}
	}
}

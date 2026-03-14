using System;
using System.Collections.Generic;

namespace Witch.UI.Window
{
	// Token: 0x02000294 RID: 660
	public struct OutDeckUIData
	{
		// Token: 0x060014BD RID: 5309 RVA: 0x000A37DC File Offset: 0x000A19DC
		public OutDeckUIData(RoleTable roleTable)
		{
			this.Id = roleTable.Id;
			this.cardList = roleTable.cardList;
			this.UnCardList = roleTable.UnCardList;
			this.CardBottomCount = roleTable.CardBottomCount;
			this.CardTopCount = roleTable.CardTopCount;
			this.MaxAlCardCount = roleTable.MaxAlCardCount;
		}

		// Token: 0x0400109D RID: 4253
		public string Id;

		// Token: 0x0400109E RID: 4254
		public ICollection<DataConfig> cardList;

		// Token: 0x0400109F RID: 4255
		public ICollection<DataConfig> UnCardList;

		// Token: 0x040010A0 RID: 4256
		public int CardBottomCount;

		// Token: 0x040010A1 RID: 4257
		public int CardTopCount;

		// Token: 0x040010A2 RID: 4258
		public int MaxAlCardCount;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Witch.UI.Window
{
	// Token: 0x02000298 RID: 664
	public struct StatusUIData
	{
		// Token: 0x060014DF RID: 5343 RVA: 0x000A4EC8 File Offset: 0x000A30C8
		public StatusUIData(RoleTable roleTable)
		{
			this.instanceId = roleTable.Id;
			this.VarsMap = roleTable.VarsMap;
			this.blessingConfigs = roleTable.blessingConfigs.ToList<DataConfig>();
			this.career = roleTable.Career;
			this.ChooseVars = roleTable.ChooseVars;
			this.San = roleTable.San;
			this.MaxSan = roleTable.MaxSan;
			this.Money = roleTable.Money;
		}

		// Token: 0x040010B4 RID: 4276
		public string instanceId;

		// Token: 0x040010B5 RID: 4277
		public Dictionary<string, int> VarsMap;

		// Token: 0x040010B6 RID: 4278
		public List<DataConfig> blessingConfigs;

		// Token: 0x040010B7 RID: 4279
		public DataConfig career;

		// Token: 0x040010B8 RID: 4280
		public int San;

		// Token: 0x040010B9 RID: 4281
		public int MaxSan;

		// Token: 0x040010BA RID: 4282
		public int Money;

		// Token: 0x040010BB RID: 4283
		public List<string> ChooseVars;
	}
}

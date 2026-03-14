using System;

namespace Witch.UI.Window
{
	// Token: 0x0200029D RID: 669
	public struct CareerData
	{
		// Token: 0x06001501 RID: 5377 RVA: 0x000A60BE File Offset: 0x000A42BE
		public CareerData(RoleTable roleTable)
		{
			this.instanceId = roleTable.Id;
			this.career = roleTable.Career;
			this.San = roleTable.San;
			this.MaxSan = roleTable.MaxSan;
		}

		// Token: 0x040010CE RID: 4302
		public string instanceId;

		// Token: 0x040010CF RID: 4303
		public DataConfig career;

		// Token: 0x040010D0 RID: 4304
		public int San;

		// Token: 0x040010D1 RID: 4305
		public int MaxSan;
	}
}

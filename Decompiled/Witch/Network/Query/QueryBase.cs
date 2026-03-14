using System;

namespace Network.Query
{
	// Token: 0x020001CB RID: 459
	public abstract class QueryBase
	{
		// Token: 0x0600103F RID: 4159
		public abstract void CmdExecute();

		// Token: 0x06001040 RID: 4160
		public abstract void OnResponse(QueryBase response);

		// Token: 0x04000E32 RID: 3634
		public uint QueryId;
	}
}

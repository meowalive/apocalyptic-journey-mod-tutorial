using System;
using System.Collections.Generic;
using System.Linq;

namespace Network.Query
{
	// Token: 0x020001D1 RID: 465
	public class QueryFood : QueryBase<List<DataConfig>>
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x00085BA9 File Offset: 0x00083DA9
		public override void CmdExecute()
		{
			this.Result = PlayerManager.Instance.ShareFood.ToList<DataConfig>();
		}
	}
}

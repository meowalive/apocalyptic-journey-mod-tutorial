using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Network.Query
{
	// Token: 0x020001CE RID: 462
	[TupleElementNames(new string[]
	{
		"instanceId",
		"dataConfig"
	})]
	public class QueryCareers : QueryBase<ValueTuple<string, DataConfig>[]>
	{
		// Token: 0x06001046 RID: 4166 RVA: 0x00085AC1 File Offset: 0x00083CC1
		public override void CmdExecute()
		{
			this.Result = (from x in GameServer.Instance.RoleTables
			select new ValueTuple<string, DataConfig>(x.Key, x.Value.Career)).ToArray<ValueTuple<string, DataConfig>>();
		}
	}
}

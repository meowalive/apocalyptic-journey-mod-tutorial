using System;
using System.Collections.Generic;
using System.Linq;
using Witch.UI.Window;

namespace Network.Query
{
	// Token: 0x020001D2 RID: 466
	public class QueryStatus : QueryBase<StatusUIData>
	{
		// Token: 0x06001050 RID: 4176 RVA: 0x00085BCA File Offset: 0x00083DCA
		public QueryStatus(string instanceId)
		{
			this.instanceId = instanceId;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00085BDC File Offset: 0x00083DDC
		public override void CmdExecute()
		{
			RoleTable findRoleTable = GameServer.Instance.RoleTables.FirstOrDefault((KeyValuePair<string, RoleTable> x) => x.Key == this.instanceId).Value;
			bool flag = findRoleTable == null;
			if (flag)
			{
				this.Result = default(StatusUIData);
			}
			else
			{
				this.Result = new StatusUIData(findRoleTable);
			}
		}

		// Token: 0x04000E38 RID: 3640
		public string instanceId;
	}
}

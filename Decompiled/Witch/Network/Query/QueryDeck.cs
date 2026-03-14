using System;
using System.Collections.Generic;
using System.Linq;
using Witch.UI.Window;

namespace Network.Query
{
	// Token: 0x020001D0 RID: 464
	public class QueryDeck : QueryBase<OutDeckUIData>
	{
		// Token: 0x0600104B RID: 4171 RVA: 0x00085B2C File Offset: 0x00083D2C
		public QueryDeck(string instanceId)
		{
			this.instanceId = instanceId;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00085B40 File Offset: 0x00083D40
		public override void CmdExecute()
		{
			RoleTable findRoleTable = GameServer.Instance.RoleTables.FirstOrDefault((KeyValuePair<string, RoleTable> x) => x.Key == this.instanceId).Value;
			bool flag = findRoleTable == null;
			if (flag)
			{
				this.Result = default(OutDeckUIData);
			}
			else
			{
				this.Result = new OutDeckUIData(findRoleTable);
			}
		}

		// Token: 0x04000E37 RID: 3639
		public string instanceId;
	}
}

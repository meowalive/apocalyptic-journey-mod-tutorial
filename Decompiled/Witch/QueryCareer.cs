using System;
using System.Collections.Generic;
using System.Linq;
using Network.Query;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x02000242 RID: 578
	public class QueryCareer : QueryBase<CareerData>
	{
		// Token: 0x060012AF RID: 4783 RVA: 0x00092D75 File Offset: 0x00090F75
		public QueryCareer(string instanceId)
		{
			this.instanceId = instanceId;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00092D88 File Offset: 0x00090F88
		public override void CmdExecute()
		{
			RoleTable findRoleTable = GameServer.Instance.RoleTables.FirstOrDefault((KeyValuePair<string, RoleTable> x) => x.Key == this.instanceId).Value;
			bool flag = findRoleTable == null;
			if (flag)
			{
				this.Result = default(CareerData);
			}
			else
			{
				this.Result = new CareerData(findRoleTable);
			}
		}

		// Token: 0x04000F4E RID: 3918
		public string instanceId;
	}
}

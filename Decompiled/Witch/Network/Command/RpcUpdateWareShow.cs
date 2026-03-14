using System;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

namespace Network.Command
{
	// Token: 0x020001DB RID: 475
	public class RpcUpdateWareShow : RpcCommandBase
	{
		// Token: 0x0600106D RID: 4205 RVA: 0x000863B0 File Offset: 0x000845B0
		public override void RpcExecute()
		{
			Debug.Log("更新仓库显示");
			bool flag = UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI") == null;
			if (!flag)
			{
				UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI").ShowCard();
				UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI").ShowRelic();
			}
		}
	}
}

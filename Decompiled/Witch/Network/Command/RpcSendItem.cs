using System;
using Witch.UI;
using Witch.UI.Window;

namespace Network.Command
{
	// Token: 0x020001DA RID: 474
	public class RpcSendItem : RpcCommandBase
	{
		// Token: 0x0600106A RID: 4202 RVA: 0x00086281 File Offset: 0x00084481
		public RpcSendItem(string itemType, DataConfig dataConfig)
		{
			this.itemType = itemType;
			this.dataConfig = dataConfig;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0008629C File Offset: 0x0008449C
		public override void CmdExecute()
		{
			foreach (LobbyInfo.PlayerInfo player in GameServer.Instance.LobbyInfo.AddedPlayers)
			{
				PlayerManager playerManager = player.Connection.identity.GetComponent<PlayerManager>();
				bool flag = this.itemType == "Card";
				if (flag)
				{
					playerManager.ShareCards.Add(this.dataConfig);
				}
				bool flag2 = this.itemType == "Relic";
				if (flag2)
				{
					playerManager.ShareRelics.Add(this.dataConfig);
				}
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0008635C File Offset: 0x0008455C
		public override void RpcExecute()
		{
			bool flag = UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI") == null;
			if (!flag)
			{
				UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI").ShowCard();
				UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI").ShowRelic();
			}
		}

		// Token: 0x04000E47 RID: 3655
		public DataConfig dataConfig;

		// Token: 0x04000E48 RID: 3656
		public string itemType;
	}
}

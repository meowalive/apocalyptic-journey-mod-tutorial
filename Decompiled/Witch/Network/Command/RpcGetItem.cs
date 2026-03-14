using System;
using System.Linq;
using Mirror;
using Witch.UI;
using Witch.UI.Window;

namespace Network.Command
{
	// Token: 0x020001D6 RID: 470
	public class RpcGetItem : RpcCommandBase
	{
		// Token: 0x0600105E RID: 4190 RVA: 0x00085EF6 File Offset: 0x000840F6
		public RpcGetItem(string itemType, DataConfig dataConfig, string getId)
		{
			this.itemType = itemType;
			this.dataConfig = dataConfig;
			this.getId = getId;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00085F18 File Offset: 0x00084118
		public override void CmdExecute()
		{
			DataConfig data = this.dataConfig;
			bool flag = this.itemType == "Card";
			if (flag)
			{
				bool flag2 = !PlayerManager.Instance.ShareCards.ToList<DataConfig>().Exists((DataConfig x) => x.InstanceID == data.InstanceID);
				if (flag2)
				{
					return;
				}
				this.isGet = true;
			}
			else
			{
				bool flag3 = this.itemType == "Relic";
				if (flag3)
				{
					bool flag4 = !PlayerManager.Instance.ShareRelics.ToList<DataConfig>().Exists((DataConfig x) => x.InstanceID == data.InstanceID);
					if (flag4)
					{
						return;
					}
					this.isGet = true;
				}
			}
			Predicate<DataConfig> <>9__2;
			Predicate<DataConfig> <>9__3;
			foreach (LobbyInfo.PlayerInfo player in GameServer.Instance.LobbyInfo.AddedPlayers)
			{
				PlayerManager playerManager = player.Connection.identity.GetComponent<PlayerManager>();
				bool flag5 = this.itemType == "Card";
				if (flag5)
				{
					SyncList<DataConfig> shareCards = playerManager.ShareCards;
					Predicate<DataConfig> match;
					if ((match = <>9__2) == null)
					{
						match = (<>9__2 = ((DataConfig x) => x.InstanceID == data.InstanceID));
					}
					shareCards.RemoveAll(match);
				}
				bool flag6 = this.itemType == "Relic";
				if (flag6)
				{
					SyncList<DataConfig> shareRelics = playerManager.ShareRelics;
					Predicate<DataConfig> match2;
					if ((match2 = <>9__3) == null)
					{
						match2 = (<>9__3 = ((DataConfig x) => x.InstanceID == data.InstanceID));
					}
					shareRelics.RemoveAll(match2);
				}
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x000860C4 File Offset: 0x000842C4
		public override void RpcExecute()
		{
			bool flag = !this.isGet;
			if (!flag)
			{
				DataConfig data = this.dataConfig;
				bool flag2 = this.itemType == "Card";
				if (flag2)
				{
					bool flag3 = PlayerManager.Instance.PlayerId == this.getId;
					if (flag3)
					{
						RoleTable.Instance.UnCardList.Add(data);
					}
				}
				else
				{
					bool flag4 = this.itemType == "Relic";
					if (flag4)
					{
						bool flag5 = PlayerManager.Instance.PlayerId == this.getId;
						if (flag5)
						{
							RoleTable.Instance.WithoutArmedRelicList.Add(data);
						}
					}
				}
				bool flag6 = UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI") == null;
				if (!flag6)
				{
					UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI").ShowCard();
					UIManager.Instance.GetUI<WarehouseUI>("WarehouseUI").ShowRelic();
				}
			}
		}

		// Token: 0x04000E3C RID: 3644
		public string itemType;

		// Token: 0x04000E3D RID: 3645
		public DataConfig dataConfig;

		// Token: 0x04000E3E RID: 3646
		public string getId;

		// Token: 0x04000E3F RID: 3647
		public bool isGet;
	}
}

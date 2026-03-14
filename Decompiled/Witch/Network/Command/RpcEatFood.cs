using System;
using System.Linq;
using UnityEngine;
using Witch;
using Witch.UI.Window;

namespace Network.Command
{
	// Token: 0x020001D5 RID: 469
	public class RpcEatFood : RpcCommandBase
	{
		// Token: 0x06001058 RID: 4184 RVA: 0x00085CA0 File Offset: 0x00083EA0
		public RpcEatFood(DataConfig dataConfig, string getId)
		{
			this.dataConfig = dataConfig;
			this.getId = getId;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00085CB8 File Offset: 0x00083EB8
		public override void CmdExecute()
		{
			bool flag = !PlayerManager.Instance.ShareFood.Any((DataConfig x) => x.InstanceID == this.dataConfig.InstanceID);
			if (flag)
			{
				this.isEat = true;
			}
			foreach (LobbyInfo.PlayerInfo player in GameServer.Instance.LobbyInfo.AddedPlayers)
			{
				PlayerManager playerManager = player.Connection.identity.GetComponent<PlayerManager>();
				playerManager.ShareFood.RemoveAll((DataConfig x) => x.InstanceID == this.dataConfig.InstanceID);
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00085D68 File Offset: 0x00083F68
		public override void RpcExecute()
		{
			bool flag = this.isEat;
			if (!flag)
			{
				bool flag2 = PlayerManager.Instance.PlayerId == this.getId;
				if (flag2)
				{
					bool isDead = RoleTable.Instance.isDead;
					if (isDead)
					{
						RoleTable.Instance.isDead = false;
						RoleTable.Instance.San = 1;
					}
					RoleTable.Instance.San += (int)((float)(int.Parse(this.dataConfig.data["Hp"]) * RoleTable.Instance.San) / 100f) + 5;
					RoleTable.Instance.MaxSan += (int)((float)(int.Parse(this.dataConfig.data["HPPercent"]) * RoleTable.Instance.MaxSan) / 100f);
				}
				bool flag3 = GameObject.Find("Breaks") != null;
				if (flag3)
				{
					GameObject game = GameObject.Find("Breaks").GetComponent<BreaksUI>().foodList.FirstOrDefault((GameObject x) => x.GetComponent<FoodItem>().dataConfig.InstanceID == this.dataConfig.InstanceID);
					bool flag4 = game != null;
					if (flag4)
					{
						UnityEngine.Object.Destroy(game);
						GameObject.Find("Breaks").GetComponent<BreaksUI>().foodList.Remove(game);
					}
				}
			}
		}

		// Token: 0x04000E39 RID: 3641
		public DataConfig dataConfig;

		// Token: 0x04000E3A RID: 3642
		public string getId;

		// Token: 0x04000E3B RID: 3643
		public bool isEat;
	}
}

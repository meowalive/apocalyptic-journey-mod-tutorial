using System;
using System.Collections.Generic;
using Mirror;

// Token: 0x020000D7 RID: 215
public class LobbyInfo
{
	// Token: 0x04000B05 RID: 2821
	public readonly List<LobbyInfo.PlayerInfo> AddedPlayers = new List<LobbyInfo.PlayerInfo>();

	// Token: 0x020000D8 RID: 216
	public class PlayerInfo
	{
		// Token: 0x04000B06 RID: 2822
		public string Name;

		// Token: 0x04000B07 RID: 2823
		public string Id;

		// Token: 0x04000B08 RID: 2824
		public bool IsSyncedRole;

		// Token: 0x04000B09 RID: 2825
		public string Version;

		// Token: 0x04000B0A RID: 2826
		public ModConfig[] Mods;

		// Token: 0x04000B0B RID: 2827
		[NonSerialized]
		public NetworkConnectionToClient Connection;
	}
}

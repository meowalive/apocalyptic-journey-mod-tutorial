using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Data.Save;
using Mirror;
using Mirror.RemoteCalls;
using Network.Command;
using Network.Query;
using Newtonsoft.Json;
using Steamworks;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

/// <summary>
/// 网络中的玩家管理器，用于处理每个客户端的玩家信息和聊天功能，还有信息交互
/// </summary>
// Token: 0x020000DB RID: 219
public class PlayerManager : NetworkBehaviour
{
	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000742 RID: 1858 RVA: 0x0003BAC8 File Offset: 0x00039CC8
	// (set) Token: 0x06000743 RID: 1859 RVA: 0x0003BACF File Offset: 0x00039CCF
	public static PlayerManager Instance { get; private set; }

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000744 RID: 1860 RVA: 0x0003BAD7 File Offset: 0x00039CD7
	public string PlayerId
	{
		get
		{
			LobbyInfo.PlayerInfo playerInfo = this.playerInfo;
			return (playerInfo != null) ? playerInfo.Id : null;
		}
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x0003BAEC File Offset: 0x00039CEC
	private void Awake()
	{
		CallResult<GameLobbyJoinRequested_t> joinRequested = CallResult<GameLobbyJoinRequested_t>.Create(delegate(GameLobbyJoinRequested_t GameRichPresenceJoinRequested_t, bool faliure)
		{
			if (faliure)
			{
				UIManager.Instance.ShowModalWindow("Error", "Failed to join the specified room", null, 0f, null, true, true, "Yes", "No", true);
			}
			else
			{
				NetworkClient.Connect(GameRichPresenceJoinRequested_t.m_steamIDLobby.m_SteamID.ToString());
			}
		});
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x0003BB20 File Offset: 0x00039D20
	public void StartGame()
	{
		bool flag = global::GameServer.Instance == null;
		if (!flag)
		{
			Singleton<TempDataManager>.Instance.GameOver = false;
			global::GameServer.Instance.StartGame();
		}
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x0003BB58 File Offset: 0x00039D58
	[TargetRpc]
	public void ShowMessage(NetworkConnectionToClient conn, string message)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(message);
		this.SendTargetRPCInternal(conn, "System.Void PlayerManager::ShowMessage(Mirror.NetworkConnectionToClient,System.String)", 967284768, writer, 0);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x0003BB94 File Offset: 0x00039D94
	[TargetRpc]
	public void RpcContinueToGame(NetworkConnectionToClient conn, RoleTable roleTable)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteRoleTable(roleTable);
		this.SendTargetRPCInternal(conn, "System.Void PlayerManager::RpcContinueToGame(Mirror.NetworkConnectionToClient,RoleTable)", -1950588015, writer, 0);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x0003BBD0 File Offset: 0x00039DD0
	[Server]
	private void UpdateInfo()
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void PlayerManager::UpdateInfo()' called when server was not active");
			return;
		}
		LobbyInfo info = new LobbyInfo();
		foreach (KeyValuePair<int, NetworkConnectionToClient> player in NetworkServer.connections)
		{
			bool flag = player.Value.identity != null;
			if (flag)
			{
				LobbyInfo.PlayerInfo playerInfo = player.Value.identity.GetComponent<PlayerManager>().playerInfo;
				info.AddedPlayers.Add(playerInfo);
			}
		}
		global::GameServer.Instance.LobbyInfo = info;
		foreach (KeyValuePair<int, NetworkConnectionToClient> player2 in NetworkServer.connections)
		{
			player2.Value.identity.GetComponent<PlayerManager>().NetworkLobbyInfos = info;
		}
		bool flag2 = GameSaveManager.IsSave();
		if (flag2)
		{
			global::GameServer.Instance.StartRole(GameSaveManager.GetRoleTables());
		}
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x0003BCF8 File Offset: 0x00039EF8
	[Command(requiresAuthority = false)]
	public void CmdJoinLobby(LobbyInfo.PlayerInfo info, NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		Mirror.GeneratedNetworkCode._Write_LobbyInfo/PlayerInfo(writer, info);
		base.SendCommandInternal("System.Void PlayerManager::CmdJoinLobby(LobbyInfo/PlayerInfo,Mirror.NetworkConnectionToClient)", -1660634444, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x0003BD34 File Offset: 0x00039F34
	[Server]
	public void LeaveLobby(LobbyInfo.PlayerInfo info)
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void PlayerManager::LeaveLobby(LobbyInfo/PlayerInfo)' called when server was not active");
			return;
		}
		global::GameServer.Instance.LobbyInfo.AddedPlayers.Remove(info);
		this.RpcUpdateLobby(global::GameServer.Instance.LobbyInfo.AddedPlayers);
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x0003BD84 File Offset: 0x00039F84
	[ClientRpc]
	public void RpcUpdateLobby(List<LobbyInfo.PlayerInfo> players)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		Mirror.GeneratedNetworkCode._Write_System.Collections.Generic.List`1<LobbyInfo/PlayerInfo>(writer, players);
		this.SendRPCInternal("System.Void PlayerManager::RpcUpdateLobby(System.Collections.Generic.List`1<LobbyInfo/PlayerInfo>)", 486512041, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x0003BDC0 File Offset: 0x00039FC0
	[Command(requiresAuthority = false)]
	public void CmdReady(bool ready, string playerId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteBool(ready);
		writer.WriteString(playerId);
		base.SendCommandInternal("System.Void PlayerManager::CmdReady(System.Boolean,System.String)", -753145563, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x0003BE04 File Offset: 0x0003A004
	[ClientRpc]
	public void RpcReady(bool ready, string playerId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteBool(ready);
		writer.WriteString(playerId);
		this.SendRPCInternal("System.Void PlayerManager::RpcReady(System.Boolean,System.String)", -1769491488, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x0003BE48 File Offset: 0x0003A048
	[ClientRpc]
	public void RpcSyncRoleTables()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void PlayerManager::RpcSyncRoleTables()", 2033696190, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x0003BE78 File Offset: 0x0003A078
	[Command(requiresAuthority = false)]
	public void CmdChangeHide()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void PlayerManager::CmdChangeHide()", 1795061155, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
	[TargetRpc]
	public void RpcNewGameInit(NetworkConnection target, RoleTable roleTable, string GetSaveType)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteRoleTable(roleTable);
		writer.WriteString(GetSaveType);
		this.SendTargetRPCInternal(target, "System.Void PlayerManager::RpcNewGameInit(Mirror.NetworkConnection,RoleTable,System.String)", -1345116831, writer, 0);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x0003BEEC File Offset: 0x0003A0EC
	[ClientRpc]
	public void ChangeHide()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void PlayerManager::ChangeHide()", -1101251173, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x0003BF1C File Offset: 0x0003A11C
	[Command(requiresAuthority = false)]
	public void CmdSyncRoleTable(RoleTable roleTable)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteRoleTable(roleTable);
		base.SendCommandInternal("System.Void PlayerManager::CmdSyncRoleTable(RoleTable)", -1765215760, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0003BF58 File Offset: 0x0003A158
	[Command(requiresAuthority = false)]
	public void CmdSendSave()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void PlayerManager::CmdSendSave()", 1437383816, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x0003BF88 File Offset: 0x0003A188
	[ClientRpc]
	public void GameOver()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void PlayerManager::GameOver()", 1563984403, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x0003BFB8 File Offset: 0x0003A1B8
	[Command(requiresAuthority = false)]
	public void CmdSendCareer(string dataConfig, string fromId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(dataConfig);
		writer.WriteString(fromId);
		base.SendCommandInternal("System.Void PlayerManager::CmdSendCareer(System.String,System.String)", -115288533, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x0003BFFC File Offset: 0x0003A1FC
	[ClientRpc]
	public void RpcSendCareer(string dataConfig, string fromId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(dataConfig);
		writer.WriteString(fromId);
		this.SendRPCInternal("System.Void PlayerManager::RpcSendCareer(System.String,System.String)", -1491988262, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x0003C040 File Offset: 0x0003A240
	[ClientRpc]
	public void RpcSetMapMode(string mapMode)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(mapMode);
		this.SendRPCInternal("System.Void PlayerManager::RpcSetMapMode(System.String)", -508262107, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x0003C07C File Offset: 0x0003A27C
	public override void OnStartClient()
	{
		base.OnStartClient();
		bool flag = !base.isLocalPlayer;
		if (!flag)
		{
			bool flag2 = !GameApp.STEAMBUILD && Singleton<GameConfigManager>.Instance.PlayerId == "Unknown";
			if (flag2)
			{
				Singleton<GameConfigManager>.Instance.PlayerId = Singleton<GameRuntimeData>.Instance.PlayerId;
				Singleton<GameConfigManager>.Instance.PlayerName = "Player" + base.netId.ToString();
			}
			PlayerManager.Instance = this;
			this.CreateChatPanel();
			this.CmdJoinLobby(new LobbyInfo.PlayerInfo
			{
				Id = Singleton<GameConfigManager>.Instance.PlayerId,
				Name = Singleton<GameConfigManager>.Instance.PlayerName,
				Mods = Singleton<GameConfigManager>.Instance.modConfigs.ToArray(),
				Version = Globals.VersionString
			}, null);
		}
	}

	/// <summary>
	/// 创建聊天窗口
	/// </summary>
	// Token: 0x0600075A RID: 1882 RVA: 0x0003C15C File Offset: 0x0003A35C
	public void CreateChatPanel()
	{
		bool flag = GameObject.Find("Canvas/ChatUI") != null;
		if (!flag)
		{
			ChatUI obj = UIManager.Instance.ShowUI<ChatUI>("ChatUI", true);
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x0003C194 File Offset: 0x0003A394
	[Command(requiresAuthority = false)]
	public void CmdSendRoleTable(string value, string fromId, string type)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(value);
		writer.WriteString(fromId);
		writer.WriteString(type);
		base.SendCommandInternal("System.Void PlayerManager::CmdSendRoleTable(System.String,System.String,System.String)", -891058723, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x0003C1E4 File Offset: 0x0003A3E4
	[ClientRpc]
	public void RpcSendRoleTable(string value, string fromId, string type)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(value);
		writer.WriteString(fromId);
		writer.WriteString(type);
		this.SendRPCInternal("System.Void PlayerManager::RpcSendRoleTable(System.String,System.String,System.String)", 2144880918, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x0003C234 File Offset: 0x0003A434
	[ClientRpc]
	public void RpcGameOver()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void PlayerManager::RpcGameOver()", -1750065992, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x0003C264 File Offset: 0x0003A464
	[Command(requiresAuthority = false)]
	public void CmdSyncHostSave(byte[] saveJson)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteBytesAndSize(saveJson);
		base.SendCommandInternal("System.Void PlayerManager::CmdSyncHostSave(System.Byte[])", 702784318, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x0003C2A0 File Offset: 0x0003A4A0
	[ClientRpc]
	public void RpcHostSave(byte[] compressed)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteBytesAndSize(compressed);
		this.SendRPCInternal("System.Void PlayerManager::RpcHostSave(System.Byte[])", -1432229666, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	/// <summary>
	/// 当有玩家离开房间时触发
	/// </summary>
	// Token: 0x06000760 RID: 1888 RVA: 0x0003C2DC File Offset: 0x0003A4DC
	[ClientRpc]
	public void OnPlayerDisconnected()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void PlayerManager::OnPlayerDisconnected()", 1082008676, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x0003C30C File Offset: 0x0003A50C
	public void SendRpcCommand(RpcCommandBase command)
	{
		this.CmdReceiveRpcCommand(command);
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x0003C317 File Offset: 0x0003A517
	public void SendRpcCommandExcludeOwner(RpcCommandBase command)
	{
		this.CmdReceiveRpcCommandExcludeOwner(command);
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x0003C324 File Offset: 0x0003A524
	[Command(requiresAuthority = false)]
	private void CmdReceiveRpcCommand(RpcCommandBase command)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(command);
		base.SendCommandInternal("System.Void PlayerManager::CmdReceiveRpcCommand(Network.Command.RpcCommandBase)", -55340122, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x0003C360 File Offset: 0x0003A560
	[Command(requiresAuthority = false)]
	private void CmdReceiveRpcCommandExcludeOwner(RpcCommandBase command)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(command);
		base.SendCommandInternal("System.Void PlayerManager::CmdReceiveRpcCommandExcludeOwner(Network.Command.RpcCommandBase)", -1848790669, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x0003C39C File Offset: 0x0003A59C
	[ClientRpc]
	private void RpcReceiveRpcCommand(RpcCommandBase command)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(command);
		this.SendRPCInternal("System.Void PlayerManager::RpcReceiveRpcCommand(Network.Command.RpcCommandBase)", 548236203, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x0003C3D8 File Offset: 0x0003A5D8
	[ClientRpc(includeOwner = false)]
	private void RpcReceiveRpcCommandExcludeOwner(RpcCommandBase command)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(command);
		this.SendRPCInternal("System.Void PlayerManager::RpcReceiveRpcCommandExcludeOwner(Network.Command.RpcCommandBase)", -1192636546, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x0003C414 File Offset: 0x0003A614
	public void SendQuery<T>(QueryBase<T> query, Action<T> callback)
	{
		uint num = this.nextQueryId;
		this.nextQueryId = num + 1U;
		query.QueryId = num;
		query.Callback = callback;
		this.pendingQueries[query.QueryId] = query;
		this.CmdQuery(query, base.connectionToClient);
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x0003C464 File Offset: 0x0003A664
	[Command(requiresAuthority = false)]
	private void CmdQuery(QueryBase query, NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(query);
		base.SendCommandInternal("System.Void PlayerManager::CmdQuery(Network.Query.QueryBase,Mirror.NetworkConnectionToClient)", 347226935, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x0003C4A0 File Offset: 0x0003A6A0
	[TargetRpc]
	private void RpcQuery(NetworkConnection conn, QueryBase query)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(query);
		this.SendTargetRPCInternal(conn, "System.Void PlayerManager::RpcQuery(Mirror.NetworkConnection,Network.Query.QueryBase)", -479222266, writer, 0);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x0003C4DC File Offset: 0x0003A6DC
	public PlayerManager()
	{
		base.InitSyncObject(this.ShareCards);
		base.InitSyncObject(this.ShareRelics);
		base.InitSyncObject(this.ShareFood);
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00022CFE File Offset: 0x00020EFE
	public override bool Weaved()
	{
		return true;
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x0600076C RID: 1900 RVA: 0x0003C548 File Offset: 0x0003A748
	// (set) Token: 0x0600076D RID: 1901 RVA: 0x0003C55B File Offset: 0x0003A75B
	public LobbyInfo.PlayerInfo NetworkplayerInfo
	{
		get
		{
			return this.playerInfo;
		}
		[param: In]
		set
		{
			base.GeneratedSyncVarSetter<LobbyInfo.PlayerInfo>(value, ref this.playerInfo, 1UL, null);
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x0600076E RID: 1902 RVA: 0x0003C578 File Offset: 0x0003A778
	// (set) Token: 0x0600076F RID: 1903 RVA: 0x0003C58B File Offset: 0x0003A78B
	public LobbyInfo NetworkLobbyInfos
	{
		get
		{
			return this.LobbyInfos;
		}
		[param: In]
		set
		{
			base.GeneratedSyncVarSetter<LobbyInfo>(value, ref this.LobbyInfos, 2UL, null);
		}
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x0003C5A8 File Offset: 0x0003A7A8
	protected void UserCode_ShowMessage__NetworkConnectionToClient__String(NetworkConnectionToClient conn, string message)
	{
		UIManager.Instance.ShowModalWindow("Lobby".Localize("Glossary"), message, null, 0f, null, true, true, "Yes", "No", true);
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x0003C5E5 File Offset: 0x0003A7E5
	protected static void InvokeUserCode_ShowMessage__NetworkConnectionToClient__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("TargetRPC ShowMessage called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_ShowMessage__NetworkConnectionToClient__String(null, reader.ReadString());
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x0003C610 File Offset: 0x0003A810
	protected void UserCode_RpcContinueToGame__NetworkConnectionToClient__RoleTable(NetworkConnectionToClient conn, RoleTable roleTable)
	{
		UniTask.DelayFrame(2, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
		{
			GameApp.Instance.ContinueGame(roleTable);
		}).Forget();
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x0003C650 File Offset: 0x0003A850
	protected static void InvokeUserCode_RpcContinueToGame__NetworkConnectionToClient__RoleTable(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("TargetRPC RpcContinueToGame called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcContinueToGame__NetworkConnectionToClient__RoleTable(null, reader.ReadRoleTable());
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x0003C67C File Offset: 0x0003A87C
	protected void UserCode_CmdJoinLobby__PlayerInfo__NetworkConnectionToClient(LobbyInfo.PlayerInfo info, NetworkConnectionToClient conn)
	{
		bool flag = info.Version != Globals.VersionString;
		if (flag)
		{
			this.ShowMessage(conn, ZString.Concat<string, string>("version fail".Localize("Glossary"), Globals.VersionString));
			conn.Disconnect();
		}
		else
		{
			info.Connection = conn;
			this.SendRpcCommand(new RpcSendChat(info.Name, "<color=yellow>加入了游戏</color>"));
			Commands.Log("玩家 " + info.Name + " 加入了房间", "玩家加入");
			conn.identity.GetComponent<PlayerManager>().NetworkplayerInfo = info;
			this.UpdateInfo();
			this.RpcUpdateLobby(global::GameServer.Instance.LobbyInfo.AddedPlayers);
		}
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x0003C735 File Offset: 0x0003A935
	protected static void InvokeUserCode_CmdJoinLobby__PlayerInfo__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdJoinLobby called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdJoinLobby__PlayerInfo__NetworkConnectionToClient(Mirror.GeneratedNetworkCode._Read_LobbyInfo/PlayerInfo(reader), senderConnection);
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x0003C760 File Offset: 0x0003A960
	protected void UserCode_RpcUpdateLobby__List(List<LobbyInfo.PlayerInfo> players)
	{
		bool flag = UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI") == null;
		if (!flag)
		{
			UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI").UpdateLobby(players);
		}
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x0003C7A0 File Offset: 0x0003A9A0
	protected static void InvokeUserCode_RpcUpdateLobby__List(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcUpdateLobby called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcUpdateLobby__List`1(Mirror.GeneratedNetworkCode._Read_System.Collections.Generic.List`1<LobbyInfo/PlayerInfo>(reader));
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x0003C7C9 File Offset: 0x0003A9C9
	protected void UserCode_CmdReady__Boolean__String(bool ready, string playerId)
	{
		this.RpcReady(ready, playerId);
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x0003C7D5 File Offset: 0x0003A9D5
	protected static void InvokeUserCode_CmdReady__Boolean__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdReady called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdReady__Boolean__String(reader.ReadBool(), reader.ReadString());
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x0003C804 File Offset: 0x0003AA04
	protected void UserCode_RpcReady__Boolean__String(bool ready, string playerId)
	{
		bool flag = UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI").SetReady(ready, playerId);
		}
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x0003C844 File Offset: 0x0003AA44
	protected static void InvokeUserCode_RpcReady__Boolean__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcReady called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcReady__Boolean__String(reader.ReadBool(), reader.ReadString());
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x0003C873 File Offset: 0x0003AA73
	protected void UserCode_RpcSyncRoleTables()
	{
		this.CmdSyncRoleTable(RoleTable.Instance);
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x0003C882 File Offset: 0x0003AA82
	protected static void InvokeUserCode_RpcSyncRoleTables(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcSyncRoleTables called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcSyncRoleTables();
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x0003C8A5 File Offset: 0x0003AAA5
	protected void UserCode_CmdChangeHide()
	{
		this.ChangeHide();
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x0003C8AF File Offset: 0x0003AAAF
	protected static void InvokeUserCode_CmdChangeHide(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdChangeHide called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdChangeHide();
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x0003C8D2 File Offset: 0x0003AAD2
	protected void UserCode_RpcNewGameInit__NetworkConnection__RoleTable__String(NetworkConnection target, RoleTable roleTable, string GetSaveType)
	{
		Singleton<GameRuntimeData>.Instance.roleTable = roleTable;
		MapManager.Instance.SetMap(GetSaveType);
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x0003C8EC File Offset: 0x0003AAEC
	protected static void InvokeUserCode_RpcNewGameInit__NetworkConnection__RoleTable__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("TargetRPC RpcNewGameInit called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcNewGameInit__NetworkConnection__RoleTable__String(null, reader.ReadRoleTable(), reader.ReadString());
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x0003C91C File Offset: 0x0003AB1C
	protected void UserCode_ChangeHide()
	{
		RoleTable.Instance.InHighTide = !RoleTable.Instance.InHighTide;
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x0003C937 File Offset: 0x0003AB37
	protected static void InvokeUserCode_ChangeHide(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC ChangeHide called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_ChangeHide();
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x0003C95A File Offset: 0x0003AB5A
	protected void UserCode_CmdSyncRoleTable__RoleTable(RoleTable roleTable)
	{
		global::GameServer.Instance.ReceiveRoleTable(roleTable);
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x0003C969 File Offset: 0x0003AB69
	protected static void InvokeUserCode_CmdSyncRoleTable__RoleTable(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdSyncRoleTable called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdSyncRoleTable__RoleTable(reader.ReadRoleTable());
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x0003C994 File Offset: 0x0003AB94
	protected void UserCode_CmdSendSave()
	{
		SaveInfo hostSave = DeepCopyUtility.DeepCopy<SaveInfo>(GameSaveManager.GetNowSave());
		hostSave.ShareCards = (hostSave.ShareRelics = null);
		hostSave.roleTable = null;
		string saveJson = JsonConvert.SerializeObject(hostSave, Formatting.None);
		byte[] compressed = GZip.CompressString(saveJson);
		bool flag = compressed.Length > 524264;
		if (flag)
		{
			Debug.LogWarning(ZString.Format<object>("存档数据过大（{0}字节），无法同步！", compressed.Length));
			UIManager.Instance.ShowModalWindow("存档同步失败", "存档数据过大，无法同步到其他玩家。", null, 0f, null, true, true, "Yes", "No", true);
		}
		else
		{
			this.CmdSyncHostSave(compressed);
		}
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x0003CA2F File Offset: 0x0003AC2F
	protected static void InvokeUserCode_CmdSendSave(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdSendSave called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdSendSave();
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x0003CA54 File Offset: 0x0003AC54
	protected void UserCode_GameOver()
	{
		Singleton<TempDataManager>.Instance.GameOver = true;
		bool flag = UIManager.Instance.GetUI<BackpackUI>("BackpackUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<BackpackUI>("BackpackUI").Close();
		}
		bool flag2 = GameObject.Find("Breaks") != null;
		if (flag2)
		{
			UnityEngine.Object.Destroy(GameObject.Find("Breaks"));
		}
		bool flag3 = UIManager.Instance.GetUI<EventUI>("EventUI") != null;
		if (flag3)
		{
			UIManager.Instance.GetUI<EventUI>("EventUI").Close();
		}
		bool flag4 = UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI") != null;
		if (flag4)
		{
			UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").Close();
		}
		bool flag5 = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
		if (flag5)
		{
			bool flag6 = FightManager.Instance == null || FightManager.Instance.fightType == FightType.Win || FightManager.Instance.fightType == FightType.Loss || FightManager.Instance.fightType == FightType.None || !PlayerManager.Instance.isServer;
			if (flag6)
			{
				GameExitUI.loss = true;
			}
			else
			{
				GameExitUI.loss = true;
				FightManager.Instance.CmdChangeType(FightType.Loss);
			}
		}
		else
		{
			UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
		}
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x0003CBC1 File Offset: 0x0003ADC1
	protected static void InvokeUserCode_GameOver(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC GameOver called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_GameOver();
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
	protected void UserCode_CmdSendCareer__String__String(string dataConfig, string fromId)
	{
		this.RpcSendCareer(dataConfig, fromId);
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x0003CBF0 File Offset: 0x0003ADF0
	protected static void InvokeUserCode_CmdSendCareer__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdSendCareer called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdSendCareer__String__String(reader.ReadString(), reader.ReadString());
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x0003CC20 File Offset: 0x0003AE20
	protected void UserCode_RpcSendCareer__String__String(string dataConfig, string fromId)
	{
		DataConfig data = JsonConvert.DeserializeObject<DataConfig>(dataConfig);
		bool flag = UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI").ChangeRole(data, fromId);
		}
		else
		{
			Debug.LogWarning("GameEntryUI 不存在，无法更新职业信息");
		}
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x0003CC76 File Offset: 0x0003AE76
	protected static void InvokeUserCode_RpcSendCareer__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcSendCareer called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcSendCareer__String__String(reader.ReadString(), reader.ReadString());
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x0003CCA8 File Offset: 0x0003AEA8
	protected void UserCode_RpcSetMapMode__String(string mapMode)
	{
		bool isServer = base.isServer;
		if (!isServer)
		{
			MapManager.Instance.SetMap(mapMode);
		}
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x0003CCCF File Offset: 0x0003AECF
	protected static void InvokeUserCode_RpcSetMapMode__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcSetMapMode called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcSetMapMode__String(reader.ReadString());
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x0003CCF8 File Offset: 0x0003AEF8
	protected void UserCode_CmdSendRoleTable__String__String__String(string value, string fromId, string type)
	{
		bool flag = type == "San";
		if (flag)
		{
			foreach (KeyValuePair<string, RoleTable> item in global::GameServer.Instance.RoleTables)
			{
				bool flag2 = item.Key == fromId;
				if (flag2)
				{
					item.Value.san = int.Parse(value);
				}
			}
		}
		bool flag3 = type == "MaxSan";
		if (flag3)
		{
			foreach (KeyValuePair<string, RoleTable> item2 in global::GameServer.Instance.RoleTables)
			{
				bool flag4 = item2.Key == fromId;
				if (flag4)
				{
					item2.Value.maxSan = int.Parse(value);
				}
			}
		}
		this.RpcSendRoleTable(value, fromId, type);
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x0003CE0C File Offset: 0x0003B00C
	protected static void InvokeUserCode_CmdSendRoleTable__String__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdSendRoleTable called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdSendRoleTable__String__String__String(reader.ReadString(), reader.ReadString(), reader.ReadString());
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x0003CE44 File Offset: 0x0003B044
	protected void UserCode_RpcSendRoleTable__String__String__String(string value, string fromId, string type)
	{
		bool flag = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<TopBarUI>("TopBarUI").OtherChangeShow(value, fromId, type);
		}
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x0003CE85 File Offset: 0x0003B085
	protected static void InvokeUserCode_RpcSendRoleTable__String__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcSendRoleTable called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcSendRoleTable__String__String__String(reader.ReadString(), reader.ReadString(), reader.ReadString());
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x0003CEBA File Offset: 0x0003B0BA
	protected void UserCode_RpcGameOver()
	{
		GameApp.Instance.GameOver();
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x0003CEC8 File Offset: 0x0003B0C8
	protected static void InvokeUserCode_RpcGameOver(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcGameOver called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcGameOver();
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x0003CEEB File Offset: 0x0003B0EB
	protected void UserCode_CmdSyncHostSave__Byte[](byte[] saveJson)
	{
		this.RpcHostSave(saveJson);
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0003CEF6 File Offset: 0x0003B0F6
	protected static void InvokeUserCode_CmdSyncHostSave__Byte[](NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdSyncHostSave called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdSyncHostSave__Byte[](reader.ReadBytesAndSize());
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0003CF20 File Offset: 0x0003B120
	protected void UserCode_RpcHostSave__Byte[](byte[] compressed)
	{
		bool isServer = base.isServer;
		if (!isServer)
		{
			string saveJson = GZip.DecompressToString(compressed);
			SaveInfo save = JsonConvert.DeserializeObject<SaveInfo>(saveJson);
			GameSaveManager.Select(save);
			Commands.Log("接收到存档", "来自存档保存");
		}
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x0003CF60 File Offset: 0x0003B160
	protected static void InvokeUserCode_RpcHostSave__Byte[](NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcHostSave called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcHostSave__Byte[](reader.ReadBytesAndSize());
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x0003CF8C File Offset: 0x0003B18C
	protected void UserCode_OnPlayerDisconnected()
	{
		bool flag = !base.isClient || !NetworkClient.isConnected;
		if (!flag)
		{
			bool flag2 = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
			if (flag2)
			{
				bool flag3 = EnemyManager.Instance == null;
				if (!flag3)
				{
					UIManager.Instance.ShowModalWindow("警告", "检测到玩家离线，战斗已重置", null, 0f, null, true, true, "Yes", "No", true);
					FightManager.Instance.ReSetFight(EnemyManager.Instance.LevelId);
				}
			}
		}
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x0003D023 File Offset: 0x0003B223
	protected static void InvokeUserCode_OnPlayerDisconnected(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC OnPlayerDisconnected called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_OnPlayerDisconnected();
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x0003D046 File Offset: 0x0003B246
	protected void UserCode_CmdReceiveRpcCommand__RpcCommandBase(RpcCommandBase command)
	{
		command.CmdExecute();
		this.RpcReceiveRpcCommand(command);
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0003D058 File Offset: 0x0003B258
	protected static void InvokeUserCode_CmdReceiveRpcCommand__RpcCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdReceiveRpcCommand called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdReceiveRpcCommand__RpcCommandBase(reader.Read());
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0003D081 File Offset: 0x0003B281
	protected void UserCode_CmdReceiveRpcCommandExcludeOwner__RpcCommandBase(RpcCommandBase command)
	{
		command.CmdExecute();
		this.RpcReceiveRpcCommandExcludeOwner(command);
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x0003D093 File Offset: 0x0003B293
	protected static void InvokeUserCode_CmdReceiveRpcCommandExcludeOwner__RpcCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdReceiveRpcCommandExcludeOwner called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdReceiveRpcCommandExcludeOwner__RpcCommandBase(reader.Read());
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x0003D0BC File Offset: 0x0003B2BC
	protected void UserCode_RpcReceiveRpcCommand__RpcCommandBase(RpcCommandBase command)
	{
		command.RpcExecute();
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x0003D0C6 File Offset: 0x0003B2C6
	protected static void InvokeUserCode_RpcReceiveRpcCommand__RpcCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcReceiveRpcCommand called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcReceiveRpcCommand__RpcCommandBase(reader.Read());
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x0003D0BC File Offset: 0x0003B2BC
	protected void UserCode_RpcReceiveRpcCommandExcludeOwner__RpcCommandBase(RpcCommandBase command)
	{
		command.RpcExecute();
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x0003D0EF File Offset: 0x0003B2EF
	protected static void InvokeUserCode_RpcReceiveRpcCommandExcludeOwner__RpcCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcReceiveRpcCommandExcludeOwner called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcReceiveRpcCommandExcludeOwner__RpcCommandBase(reader.Read());
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x0003D118 File Offset: 0x0003B318
	protected void UserCode_CmdQuery__QueryBase__NetworkConnectionToClient(QueryBase query, NetworkConnectionToClient conn)
	{
		UniTask.WaitUntil(() => global::GameServer.Instance.IsRoleTableSynced, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
		{
			bool flag = this == null;
			if (!flag)
			{
				query.CmdExecute();
				this.RpcQuery(conn, query);
			}
		}).Forget();
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x0003D184 File Offset: 0x0003B384
	protected static void InvokeUserCode_CmdQuery__QueryBase__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdQuery called on client.");
			return;
		}
		((PlayerManager)obj).UserCode_CmdQuery__QueryBase__NetworkConnectionToClient(reader.Read(), senderConnection);
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x0003D1B0 File Offset: 0x0003B3B0
	protected void UserCode_RpcQuery__NetworkConnection__QueryBase(NetworkConnection conn, QueryBase query)
	{
		QueryBase localQuery = this.pendingQueries.GetValueOrDefault(query.QueryId, null);
		bool flag = localQuery == null;
		if (flag)
		{
			Debug.LogWarning("未找到对应的查询对象");
		}
		else
		{
			this.pendingQueries.Remove(localQuery.QueryId);
			localQuery.OnResponse(query);
		}
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x0003D201 File Offset: 0x0003B401
	protected static void InvokeUserCode_RpcQuery__NetworkConnection__QueryBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("TargetRPC RpcQuery called on server.");
			return;
		}
		((PlayerManager)obj).UserCode_RpcQuery__NetworkConnection__QueryBase(null, reader.Read());
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x0003D22C File Offset: 0x0003B42C
	static PlayerManager()
	{
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdJoinLobby(LobbyInfo/PlayerInfo,Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdJoinLobby__PlayerInfo__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdReady(System.Boolean,System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdReady__Boolean__String), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdChangeHide()", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdChangeHide), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdSyncRoleTable(RoleTable)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdSyncRoleTable__RoleTable), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdSendSave()", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdSendSave), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdSendCareer(System.String,System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdSendCareer__String__String), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdSendRoleTable(System.String,System.String,System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdSendRoleTable__String__String__String), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdSyncHostSave(System.Byte[])", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdSyncHostSave__Byte[]), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdReceiveRpcCommand(Network.Command.RpcCommandBase)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdReceiveRpcCommand__RpcCommandBase), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdReceiveRpcCommandExcludeOwner(Network.Command.RpcCommandBase)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdReceiveRpcCommandExcludeOwner__RpcCommandBase), false);
		RemoteProcedureCalls.RegisterCommand(typeof(PlayerManager), "System.Void PlayerManager::CmdQuery(Network.Query.QueryBase,Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_CmdQuery__QueryBase__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcUpdateLobby(System.Collections.Generic.List`1<LobbyInfo/PlayerInfo>)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcUpdateLobby__List`1));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcReady(System.Boolean,System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcReady__Boolean__String));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcSyncRoleTables()", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcSyncRoleTables));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::ChangeHide()", new RemoteCallDelegate(PlayerManager.InvokeUserCode_ChangeHide));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::GameOver()", new RemoteCallDelegate(PlayerManager.InvokeUserCode_GameOver));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcSendCareer(System.String,System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcSendCareer__String__String));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcSetMapMode(System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcSetMapMode__String));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcSendRoleTable(System.String,System.String,System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcSendRoleTable__String__String__String));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcGameOver()", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcGameOver));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcHostSave(System.Byte[])", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcHostSave__Byte[]));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::OnPlayerDisconnected()", new RemoteCallDelegate(PlayerManager.InvokeUserCode_OnPlayerDisconnected));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcReceiveRpcCommand(Network.Command.RpcCommandBase)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcReceiveRpcCommand__RpcCommandBase));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcReceiveRpcCommandExcludeOwner(Network.Command.RpcCommandBase)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcReceiveRpcCommandExcludeOwner__RpcCommandBase));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::ShowMessage(Mirror.NetworkConnectionToClient,System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_ShowMessage__NetworkConnectionToClient__String));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcContinueToGame(Mirror.NetworkConnectionToClient,RoleTable)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcContinueToGame__NetworkConnectionToClient__RoleTable));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcNewGameInit(Mirror.NetworkConnection,RoleTable,System.String)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcNewGameInit__NetworkConnection__RoleTable__String));
		RemoteProcedureCalls.RegisterRpc(typeof(PlayerManager), "System.Void PlayerManager::RpcQuery(Mirror.NetworkConnection,Network.Query.QueryBase)", new RemoteCallDelegate(PlayerManager.InvokeUserCode_RpcQuery__NetworkConnection__QueryBase));
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x0003D5C4 File Offset: 0x0003B7C4
	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
		base.SerializeSyncVars(writer, forceAll);
		if (forceAll)
		{
			Mirror.GeneratedNetworkCode._Write_LobbyInfo/PlayerInfo(writer, this.playerInfo);
			Mirror.GeneratedNetworkCode._Write_LobbyInfo(writer, this.LobbyInfos);
			return;
		}
		writer.WriteVarULong(this.syncVarDirtyBits);
		if ((this.syncVarDirtyBits & 1UL) != 0UL)
		{
			Mirror.GeneratedNetworkCode._Write_LobbyInfo/PlayerInfo(writer, this.playerInfo);
		}
		if ((this.syncVarDirtyBits & 2UL) != 0UL)
		{
			Mirror.GeneratedNetworkCode._Write_LobbyInfo(writer, this.LobbyInfos);
		}
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x0003D64C File Offset: 0x0003B84C
	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
		base.DeserializeSyncVars(reader, initialState);
		if (initialState)
		{
			base.GeneratedSyncVarDeserialize<LobbyInfo.PlayerInfo>(ref this.playerInfo, null, Mirror.GeneratedNetworkCode._Read_LobbyInfo/PlayerInfo(reader));
			base.GeneratedSyncVarDeserialize<LobbyInfo>(ref this.LobbyInfos, null, Mirror.GeneratedNetworkCode._Read_LobbyInfo(reader));
			return;
		}
		long num = (long)reader.ReadVarULong();
		if ((num & 1L) != 0L)
		{
			base.GeneratedSyncVarDeserialize<LobbyInfo.PlayerInfo>(ref this.playerInfo, null, Mirror.GeneratedNetworkCode._Read_LobbyInfo/PlayerInfo(reader));
		}
		if ((num & 2L) != 0L)
		{
			base.GeneratedSyncVarDeserialize<LobbyInfo>(ref this.LobbyInfos, null, Mirror.GeneratedNetworkCode._Read_LobbyInfo(reader));
		}
	}

	// Token: 0x04000B15 RID: 2837
	[SyncVar]
	public LobbyInfo.PlayerInfo playerInfo;

	// Token: 0x04000B16 RID: 2838
	[SyncVar]
	public LobbyInfo LobbyInfos;

	// Token: 0x04000B17 RID: 2839
	public SyncList<DataConfig> ShareCards = new SyncList<DataConfig>();

	// Token: 0x04000B18 RID: 2840
	public SyncList<DataConfig> ShareRelics = new SyncList<DataConfig>();

	// Token: 0x04000B19 RID: 2841
	public SyncList<DataConfig> ShareFood = new SyncList<DataConfig>();

	// Token: 0x04000B1A RID: 2842
	private Dictionary<uint, QueryBase> pendingQueries = new Dictionary<uint, QueryBase>();

	// Token: 0x04000B1B RID: 2843
	private uint nextQueryId = 1U;
}

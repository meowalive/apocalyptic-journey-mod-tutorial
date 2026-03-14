using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Mirror;
using Steamworks;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x020000D9 RID: 217
public class LobbyManager : NetworkManager
{
	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06000732 RID: 1842 RVA: 0x0003B554 File Offset: 0x00039754
	// (set) Token: 0x06000733 RID: 1843 RVA: 0x0003B55B File Offset: 0x0003975B
	public static LobbyManager Instance { get; private set; }

	// Token: 0x06000734 RID: 1844 RVA: 0x0003B564 File Offset: 0x00039764
	public override void Awake()
	{
		base.Awake();
		LobbyManager.Instance = this;
		this.lobbyCreated = Callback<LobbyCreated_t>.Create(new Callback<LobbyCreated_t>.DispatchDelegate(this.OnLobbyCreated));
		this.joinLobbyRequested = Callback<GameLobbyJoinRequested_t>.Create(new Callback<GameLobbyJoinRequested_t>.DispatchDelegate(this.OnGameLobbyJoinRequested));
		this.lobbyEntered = Callback<LobbyEnter_t>.Create(new Callback<LobbyEnter_t>.DispatchDelegate(this.OnLobbyEntered));
	}

	/// <summary>
	/// 玩家断开连接
	/// </summary>
	/// <param name="conn"></param>
	// Token: 0x06000735 RID: 1845 RVA: 0x0003B5C8 File Offset: 0x000397C8
	public override void OnServerDisconnect(NetworkConnectionToClient conn)
	{
		bool flag = conn == null || conn.identity == null;
		if (!flag)
		{
			PlayerManager playerManager;
			bool flag2 = conn.identity.TryGetComponent<PlayerManager>(out playerManager);
			if (flag2)
			{
				playerManager.LeaveLobby(playerManager.playerInfo);
			}
			bool flag3 = MapManager.Instance != null;
			if (flag3)
			{
				MapManager.Instance.RemoveReady(conn.identity);
			}
			UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
			{
				bool flag4 = UIManager.Instance.GetUI<EventUI>("EventUI") != null;
				if (flag4)
				{
					bool flag5 = MapManager.Instance.eventWait >= NetworkServer.connections.Count - 1 && MapManager.Instance.eventDone > 0;
					if (flag5)
					{
						MapManager.Instance.RpcTryChange();
						bool flag6 = FightManager.Instance != null;
						if (flag6)
						{
							FightManager.Instance.ResetWaitCount();
						}
					}
				}
				bool flag7 = FightManager.Instance != null && FightManager.Instance.waitCount > 0;
				if (flag7)
				{
					FightManager.Instance.ReadyToInit(FightManager.Instance.wantLevel);
				}
				bool flag8 = PlayerManager.Instance != null;
				if (flag8)
				{
					PlayerManager.Instance.OnPlayerDisconnected();
				}
			});
			base.OnServerDisconnect(conn);
		}
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x0003B670 File Offset: 0x00039870
	public override void OnClientDisconnect()
	{
		LatencyRecorder instance = LatencyRecorder.Instance;
		if (instance != null)
		{
			instance.StopAndReport();
		}
		base.OnClientDisconnect();
		bool steambuild = GameApp.STEAMBUILD;
		if (steambuild)
		{
			SteamMatchmaking.LeaveLobby(new CSteamID(this.lobbyId));
		}
		bool gameOver = Singleton<TempDataManager>.Instance.GameOver;
		if (!gameOver)
		{
			bool flag = PlayerManager.Instance != null && PlayerManager.Instance.isClientOnly;
			if (flag)
			{
				UIManager.Instance.ShowModalWindow("Lost Connection", "The server is disconnected", null, 0f, null, true, true, "Yes", "No", true);
			}
			GameApp.Instance.ReturnToMenu();
		}
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x0003B718 File Offset: 0x00039918
	public void UpdateSteamLobyState(bool joined)
	{
		bool flag = !GameApp.STEAMBUILD;
		if (!flag)
		{
			if (joined)
			{
				int nPartyMemberCount = SteamMatchmaking.GetNumLobbyMembers(new CSteamID(this.lobbyId));
				SteamFriends.SetRichPresence("steam_player_group", this.lobbyId.ToString());
				SteamFriends.SetRichPresence("steam_player_group_size", nPartyMemberCount.ToString());
			}
			else
			{
				SteamFriends.SetRichPresence("steam_player_group", null);
				SteamFriends.SetRichPresence("steam_player_group_size", null);
			}
		}
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x0003B790 File Offset: 0x00039990
	private void OnLobbyCreated(LobbyCreated_t callback)
	{
		bool flag = callback.m_eResult != EResult.k_EResultOK;
		if (flag)
		{
			UIManager.Instance.ShowModalWindow("Error", "Failed to create room", null, 0f, null, true, true, "Yes", "No", true);
		}
		base.StartHost();
		this.lobbyId = callback.m_ulSteamIDLobby;
		SteamMatchmaking.SetLobbyData(new CSteamID(this.lobbyId), "HostAddress", SteamUser.GetSteamID().ToString());
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x0003B818 File Offset: 0x00039A18
	private void OnGameLobbyJoinRequested(GameLobbyJoinRequested_t callback)
	{
		GameApp.Instance.ChangeTransportToSteam();
		bool active = NetworkServer.active;
		if (active)
		{
			base.StopHost();
		}
		UIManager.Instance.ShowUI<GameEntryUI>("GameEntryUI", true).Init();
		this.lobbyId = callback.m_steamIDLobby.m_SteamID;
		SteamMatchmaking.JoinLobby(callback.m_steamIDLobby);
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x0003B878 File Offset: 0x00039A78
	private void OnLobbyEntered(LobbyEnter_t callback)
	{
		bool active = NetworkServer.active;
		if (!active)
		{
			string hostAddress = SteamMatchmaking.GetLobbyData(new CSteamID(this.lobbyId), "HostAddress");
			Debug.Log("Joining lobby at address: " + hostAddress);
			this.networkAddress = hostAddress;
			this.UpdateSteamLobyState(true);
			base.StartClient();
		}
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x0003B8D0 File Offset: 0x00039AD0
	public void QuitLobby()
	{
		bool flag = global::GameServer.Instance != null;
		if (flag)
		{
			global::GameServer.Instance.LobbyInfo.AddedPlayers.Clear();
		}
		bool steambuild = GameApp.STEAMBUILD;
		if (steambuild)
		{
			SteamMatchmaking.LeaveLobby(new CSteamID(this.lobbyId));
		}
		bool active = NetworkServer.active;
		if (active)
		{
			base.StopHost();
		}
		else
		{
			bool isConnected = NetworkClient.isConnected;
			if (isConnected)
			{
				base.StopClient();
			}
		}
		bool flag2 = UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI") != null;
		if (flag2)
		{
			UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI").Outlobby();
		}
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x0003B978 File Offset: 0x00039B78
	public override void OnApplicationQuit()
	{
		base.OnApplicationQuit();
		this.QuitLobby();
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x0003B98C File Offset: 0x00039B8C
	public override void OnServerConnect(NetworkConnectionToClient conn)
	{
		base.OnServerConnect(conn);
		bool flag = !global::GameServer.Instance.isAcceptJoin;
		if (flag)
		{
			PlayerManager.Instance.ShowMessage(conn, "game has start".Localize("Glossary"));
			conn.Disconnect();
		}
		this.UpdateSteamLobyState(false);
	}

	// Token: 0x04000B0D RID: 2829
	private Callback<LobbyCreated_t> lobbyCreated;

	// Token: 0x04000B0E RID: 2830
	private Callback<GameLobbyJoinRequested_t> joinLobbyRequested;

	// Token: 0x04000B0F RID: 2831
	private Callback<LobbyEnter_t> lobbyEntered;

	// Token: 0x04000B10 RID: 2832
	private const string HostAddress = "HostAddress";

	// Token: 0x04000B11 RID: 2833
	public ulong lobbyId;
}

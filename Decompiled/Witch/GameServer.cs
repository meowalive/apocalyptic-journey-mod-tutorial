using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Data.Save;
using Mirror;
using Newtonsoft.Json;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

/// <summary>
/// 服务器的统一入口，负责处理游戏的开始和结束，以及部分数据的同步。注意，客户端无法访问！
/// </summary>
// Token: 0x020000CF RID: 207
public class GameServer : NetworkBehaviour
{
	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0003A8AF File Offset: 0x00038AAF
	// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0003A8B6 File Offset: 0x00038AB6
	public static GameServer Instance { get; private set; }

	// Token: 0x060006F6 RID: 1782 RVA: 0x0003A8BE File Offset: 0x00038ABE
	private void OnEnable()
	{
		GameServer.Instance = this;
		this.isAcceptJoin = true;
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x0003A8CF File Offset: 0x00038ACF
	private void OnDisable()
	{
		GameServer.Instance = null;
		this.isAcceptJoin = false;
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x0003A8E0 File Offset: 0x00038AE0
	[Server]
	public void StartRole(Dictionary<string, RoleTable> roleTables)
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void GameServer::StartRole(System.Collections.Generic.Dictionary`2<System.String,RoleTable>)' called when server was not active");
			return;
		}
		foreach (LobbyInfo.PlayerInfo player in GameServer.Instance.LobbyInfo.AddedPlayers)
		{
			RoleTable roleTable = roleTables.GetValueOrDefault(player.Id, null);
			bool flag = roleTable == null;
			if (flag)
			{
				roleTable = new RoleTable
				{
					Id = player.Id,
					Career = new DataConfig("career_1", DataType.Career)
				};
				bool flag2 = MapManager.Instance != null;
				if (flag2)
				{
					MapManager.Instance.SetMap(GameSaveManager.GetSaveType());
					MapManager.Instance.ModeMapManager.InitRoleTable(roleTable);
				}
				else
				{
					Debug.LogError("MapManager.Instance is null in StartRole");
				}
				roleTables.Add(player.Id, roleTable);
			}
			bool flag3 = !player.IsSyncedRole;
			if (flag3)
			{
				PlayerManager.Instance.RpcNewGameInit(player.Connection, roleTable, GameSaveManager.GetSaveType());
				player.IsSyncedRole = true;
			}
			bool flag4 = roleTable.Career != null && PlayerManager.Instance != null;
			if (flag4)
			{
				PlayerManager.Instance.RpcSetMapMode(GameSaveManager.GetSaveType());
				PlayerManager.Instance.RpcSendCareer(JsonConvert.SerializeObject(roleTable.Career), player.Id);
			}
		}
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x0003AA68 File Offset: 0x00038C68
	[Server]
	public void StartGame()
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void GameServer::StartGame()' called when server was not active");
			return;
		}
		this.CollectRoleTables(delegate
		{
			foreach (LobbyInfo.PlayerInfo player in GameServer.Instance.LobbyInfo.AddedPlayers)
			{
				RoleTable roleTable = this.RoleTables.GetValueOrDefault(player.Id, null);
				bool flag = roleTable == null;
				if (flag)
				{
					roleTable = new RoleTable
					{
						Id = player.Id
					};
					this.RoleTables.Add(player.Id, roleTable);
				}
				PlayerManager.Instance.RpcContinueToGame(player.Connection, roleTable);
			}
		});
		this.isAcceptJoin = false;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x0003AA9C File Offset: 0x00038C9C
	public void RoleRes()
	{
		bool flag = this.EnemyDone && (this.PatDone || FightManager.Instance.roleQueue.Count >= 2);
		if (flag)
		{
			this.GetRoles(Singleton<TempDataManager>.Instance.RoleStatusMap);
			this.EnemyDone = false;
			this.PatDone = false;
		}
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x0003AAFA File Offset: 0x00038CFA
	[Client]
	public void GetRoles(Dictionary<string, List<string>> tomap)
	{
		if (!NetworkClient.active)
		{
			Debug.LogWarning("[Client] function 'System.Void GameServer::GetRoles(System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.String>>)' called when client was not active");
			return;
		}
		Singleton<TempDataManager>.Instance.RoleStatusMap = tomap;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x0003AB20 File Offset: 0x00038D20
	public void ReceiveRoleTable(RoleTable roleTable)
	{
		this.RoleTables[roleTable.Id] = roleTable;
		GameSaveManager.UpdateRoles(roleTable);
		this.roleCount++;
		bool flag = this.roleCount >= this.LobbyInfo.AddedPlayers.Count;
		if (flag)
		{
			this.onAllRoleReceived();
			this.onAllRoleReceived = delegate()
			{
			};
			this.roleCount = 0;
			this.IsRoleTableSynced = true;
		}
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x0003ABB8 File Offset: 0x00038DB8
	[Server]
	public void CollectRoleTables(Action onAllReceived)
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void GameServer::CollectRoleTables(System.Action)' called when server was not active");
			return;
		}
		this.IsRoleTableSynced = false;
		onAllReceived = (Action)Delegate.Combine(onAllReceived, new Action(delegate()
		{
			bool flag = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeCareerAvator();
			}
		}));
		this.onAllRoleReceived = onAllReceived;
		PlayerManager.Instance.RpcSyncRoleTables();
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x0003AC20 File Offset: 0x00038E20
	[Server]
	public void SaveGame()
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void GameServer::SaveGame()' called when server was not active");
			return;
		}
		Dictionary<string, RoleTable> temp = new Dictionary<string, RoleTable>(this.RoleTables);
		foreach (KeyValuePair<string, RoleTable> role in temp)
		{
			bool flag = !this.CheckOnline(role.Value.Id);
			if (flag)
			{
				this.RoleTables.Remove(role.Key);
			}
		}
		GameSaveManager.SetLevel(MapManager.Instance.Level);
		this.CollectRoleTables(new Action(GameSaveManager.Save));
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x0003ACE0 File Offset: 0x00038EE0
	[DebuggerStepThrough]
	public void EndGame()
	{
		GameServer.<EndGame>d__22 <EndGame>d__ = new GameServer.<EndGame>d__22();
		<EndGame>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		<EndGame>d__.<>4__this = this;
		<EndGame>d__.<>1__state = -1;
		<EndGame>d__.<>t__builder.Start<GameServer.<EndGame>d__22>(ref <EndGame>d__);
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x0003AD1C File Offset: 0x00038F1C
	public bool CheckOnline(string playerId)
	{
		return this.LobbyInfo.AddedPlayers.Any((LobbyInfo.PlayerInfo x) => x.Id == playerId);
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00022CFE File Offset: 0x00020EFE
	public override bool Weaved()
	{
		return true;
	}

	// Token: 0x04000ADE RID: 2782
	public LobbyInfo LobbyInfo;

	// Token: 0x04000ADF RID: 2783
	public Dictionary<string, RoleTable> RoleTables = new Dictionary<string, RoleTable>();

	// Token: 0x04000AE0 RID: 2784
	public bool isAcceptJoin = true;

	// Token: 0x04000AE1 RID: 2785
	public bool IsRoleTableSynced = false;

	// Token: 0x04000AE2 RID: 2786
	public bool EnemyDone;

	// Token: 0x04000AE3 RID: 2787
	public bool PatDone;

	// Token: 0x04000AE4 RID: 2788
	private int roleCount = 0;

	// Token: 0x04000AE5 RID: 2789
	private Action onAllRoleReceived = delegate()
	{
	};

	// Token: 0x04000AE6 RID: 2790
	public static bool EndCommit = true;
}

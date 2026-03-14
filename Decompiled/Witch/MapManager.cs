using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Data.Save;
using Mirror;
using Mirror.RemoteCalls;
using Newtonsoft.Json;
using UnityEngine;
using Witch;
using Witch.UI;
using Witch.UI.Window;

/// <summary>
/// 地图管理器，负责地图的生成和切换，以及多人游戏中的地图同步。
/// </summary>
// Token: 0x020000C5 RID: 197
public class MapManager : NetworkBehaviour
{
	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06000681 RID: 1665 RVA: 0x00038DE3 File Offset: 0x00036FE3
	// (set) Token: 0x06000682 RID: 1666 RVA: 0x00038DEA File Offset: 0x00036FEA
	public static MapManager Instance { get; private set; }

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000683 RID: 1667 RVA: 0x00038DF2 File Offset: 0x00036FF2
	public MapTree MapTree
	{
		get
		{
			return GameSaveManager.MapTree;
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000684 RID: 1668 RVA: 0x00038DF9 File Offset: 0x00036FF9
	public int Level
	{
		get
		{
			return this.ModeMapManager.Level;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x00038E06 File Offset: 0x00037006
	public Dice NowDice
	{
		get
		{
			return this.ModeMapManager.NowDice;
		}
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00038E13 File Offset: 0x00037013
	public void Awake()
	{
		MapManager.Instance = this;
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00038E20 File Offset: 0x00037020
	[ClientRpc]
	public void RpcTryChange()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void MapManager::RpcTryChange()", -1494384958, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00038E50 File Offset: 0x00037050
	public void SetMap(string mapManager)
	{
		this.CurrentMode = mapManager;
		bool flag = mapManager == "Normal";
		if (flag)
		{
			this.ModeMapManager = GameObject.Find("ModeManager").GetComponent<NormalMapManager>();
		}
		else
		{
			bool flag2 = mapManager == "Teach";
			if (flag2)
			{
				this.ModeMapManager = GameObject.Find("ModeManager").GetComponent<TeachMapManager>();
			}
			else
			{
				bool flag3 = mapManager == "Slot";
				if (flag3)
				{
					this.ModeMapManager = GameObject.Find("ModeManager").GetComponent<SlotMachineManager>();
				}
				else
				{
					bool flag4 = mapManager == "Sublimation";
					if (flag4)
					{
						this.ModeMapManager = GameObject.Find("ModeManager").GetComponent<SublimationManager>();
					}
				}
			}
		}
		this.SetLevel(GameSaveManager.GetLevel());
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00038F10 File Offset: 0x00037110
	public void TryChange()
	{
		UniTask.WaitForSeconds(0.3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			bool flag = UIManager.Instance.Find("ShopUI") != null;
			if (!flag)
			{
				bool flag2 = UIManager.Instance.Find("CardEnchUI") != null;
				if (!flag2)
				{
					bool flag3 = UIManager.Instance.Find("DestinyTreeUI") != null;
					if (!flag3)
					{
						bool flag4 = UIManager.Instance.Find("EventUI") != null;
						if (!flag4)
						{
							bool flag5 = base.isClient && NetworkClient.isConnected;
							if (flag5)
							{
								this.ReadyToChangeMap(null);
							}
						}
					}
				}
			}
		}).Forget();
	}

	/// <summary>
	/// 设置玩家准备状态，所有玩家准备后开始地图切换。
	/// </summary>
	// Token: 0x0600068A RID: 1674 RVA: 0x00038F4C File Offset: 0x0003714C
	[Command(requiresAuthority = false)]
	public void ReadyToChangeMap(NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void MapManager::ReadyToChangeMap(Mirror.NetworkConnectionToClient)", -64304223, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00038F7C File Offset: 0x0003717C
	[Command(requiresAuthority = false)]
	public void CmdReadyToNextMap(NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void MapManager::CmdReadyToNextMap(Mirror.NetworkConnectionToClient)", 1747051944, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	/// <summary>
	/// 下一张地图
	/// </summary>
	// Token: 0x0600068C RID: 1676 RVA: 0x00038FAC File Offset: 0x000371AC
	[Command(requiresAuthority = false)]
	public void CmdNextMap()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void MapManager::CmdNextMap()", -1214921593, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00038FDC File Offset: 0x000371DC
	public void MapUIStart(MapSelectUI mapSelectUI)
	{
		IModeManager modeMapManager = this.ModeMapManager;
		if (modeMapManager != null)
		{
			modeMapManager.MapUIStart(mapSelectUI);
		}
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00038FF4 File Offset: 0x000371F4
	[ClientRpc]
	public void RpcNextMap()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void MapManager::RpcNextMap()", 1478551926, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00039024 File Offset: 0x00037224
	[Command(requiresAuthority = false)]
	public void ResetEvent()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void MapManager::ResetEvent()", 421212291, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00039054 File Offset: 0x00037254
	[Command(requiresAuthority = false)]
	public void CmdAnnounceEventWait()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void MapManager::CmdAnnounceEventWait()", -760042022, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00039084 File Offset: 0x00037284
	[Command(requiresAuthority = false)]
	public void CmdEventWait()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void MapManager::CmdEventWait()", -1794861057, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x000390B4 File Offset: 0x000372B4
	[Server]
	public void RpcLoadMap(string type, string id)
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void MapManager::RpcLoadMap(System.String,System.String)' called when server was not active");
			return;
		}
		this.ModeMapManager.RpcLoadMap(type, id);
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x000390DC File Offset: 0x000372DC
	public void CloseMapUI()
	{
		bool flag = this.ModeMapManager == null;
		if (!flag)
		{
			this.ModeMapManager.CloseMapUI();
		}
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00039108 File Offset: 0x00037308
	[ClientRpc]
	public void RpcSyncDice(string diceJSON)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(diceJSON);
		this.SendRPCInternal("System.Void MapManager::RpcSyncDice(System.String)", -1024650833, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00039142 File Offset: 0x00037342
	public void SetLevel(int level)
	{
		this.ModeMapManager.Level = level;
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00039154 File Offset: 0x00037354
	[ClientRpc]
	public void RpcSyncRandom(int seed)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteVarInt(seed);
		this.SendRPCInternal("System.Void MapManager::RpcSyncRandom(System.Int32)", -950097422, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x0003918E File Offset: 0x0003738E
	public void MapItemInit(MapSelectUI mapSelectUI)
	{
		this.ModeMapManager.MapItemInit(mapSelectUI);
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x000391A0 File Offset: 0x000373A0
	[Command(requiresAuthority = false)]
	public void CmdSelectMap(string[] maps, string[] mapdata, NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		Mirror.GeneratedNetworkCode._Write_System.String[](writer, maps);
		Mirror.GeneratedNetworkCode._Write_System.String[](writer, mapdata);
		base.SendCommandInternal("System.Void MapManager::CmdSelectMap(System.String[],System.String[],Mirror.NetworkConnectionToClient)", 317217491, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x000391E4 File Offset: 0x000373E4
	[TargetRpc]
	public void TargetUpdateMap(NetworkConnection conn, string[] maps, string[] mapdata)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		Mirror.GeneratedNetworkCode._Write_System.String[](writer, maps);
		Mirror.GeneratedNetworkCode._Write_System.String[](writer, mapdata);
		this.SendTargetRPCInternal(conn, "System.Void MapManager::TargetUpdateMap(Mirror.NetworkConnection,System.String[],System.String[])", -397516697, writer, 0);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00039228 File Offset: 0x00037428
	[Command(requiresAuthority = false)]
	public void CmdMapDrawBegin(string strokeId, string authorId, Vector2 startPoint, NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(strokeId);
		writer.WriteString(authorId);
		writer.WriteVector2(startPoint);
		base.SendCommandInternal("System.Void MapManager::CmdMapDrawBegin(System.String,System.String,UnityEngine.Vector2,Mirror.NetworkConnectionToClient)", 446628464, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00039278 File Offset: 0x00037478
	[ClientRpc]
	public void RpcMapDrawBegin(string strokeId, string authorId, Vector2 startPoint)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(strokeId);
		writer.WriteString(authorId);
		writer.WriteVector2(startPoint);
		this.SendRPCInternal("System.Void MapManager::RpcMapDrawBegin(System.String,System.String,UnityEngine.Vector2)", -527834074, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x000392C8 File Offset: 0x000374C8
	[Command(requiresAuthority = false)]
	public void CmdMapDrawPoint(string strokeId, string authorId, Vector2 point, NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(strokeId);
		writer.WriteString(authorId);
		writer.WriteVector2(point);
		base.SendCommandInternal("System.Void MapManager::CmdMapDrawPoint(System.String,System.String,UnityEngine.Vector2,Mirror.NetworkConnectionToClient)", 357045691, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00039318 File Offset: 0x00037518
	[ClientRpc]
	public void RpcMapDrawPoint(string strokeId, string authorId, Vector2 point)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(strokeId);
		writer.WriteString(authorId);
		writer.WriteVector2(point);
		this.SendRPCInternal("System.Void MapManager::RpcMapDrawPoint(System.String,System.String,UnityEngine.Vector2)", 554078639, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00039368 File Offset: 0x00037568
	[Command(requiresAuthority = false)]
	public void CmdMapDrawEnd(string strokeId, string authorId, NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(strokeId);
		writer.WriteString(authorId);
		base.SendCommandInternal("System.Void MapManager::CmdMapDrawEnd(System.String,System.String,Mirror.NetworkConnectionToClient)", -13721362, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x000393AC File Offset: 0x000375AC
	[ClientRpc]
	public void RpcMapDrawEnd(string strokeId, string authorId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(strokeId);
		writer.WriteString(authorId);
		this.SendRPCInternal("System.Void MapManager::RpcMapDrawEnd(System.String,System.String)", 1275653076, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x000393F0 File Offset: 0x000375F0
	[Command(requiresAuthority = false)]
	public void CmdMapErase(string authorId, Vector2 point, float radius, NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(authorId);
		writer.WriteVector2(point);
		writer.WriteFloat(radius);
		base.SendCommandInternal("System.Void MapManager::CmdMapErase(System.String,UnityEngine.Vector2,System.Single,Mirror.NetworkConnectionToClient)", -1596859908, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00039440 File Offset: 0x00037640
	[ClientRpc]
	public void RpcMapErase(string authorId, Vector2 point, float radius)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(authorId);
		writer.WriteVector2(point);
		writer.WriteFloat(radius);
		this.SendRPCInternal("System.Void MapManager::RpcMapErase(System.String,UnityEngine.Vector2,System.Single)", 1746219054, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00039490 File Offset: 0x00037690
	[Command(requiresAuthority = false)]
	public void CmdMapClearAll(string authorId, NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(authorId);
		base.SendCommandInternal("System.Void MapManager::CmdMapClearAll(System.String,Mirror.NetworkConnectionToClient)", -187382165, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x000394CC File Offset: 0x000376CC
	[ClientRpc]
	public void RpcMapClearAll(string authorId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(authorId);
		this.SendRPCInternal("System.Void MapManager::RpcMapClearAll(System.String)", 1819330809, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00039508 File Offset: 0x00037708
	public void SetReward(BattleRewardsUI battleRewardsUI)
	{
		bool flag = this.ModeMapManager == null;
		if (!flag)
		{
			this.ModeMapManager.SetReward(battleRewardsUI);
		}
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00039533 File Offset: 0x00037733
	public void RemoveReady(NetworkIdentity identity)
	{
		this.readys.Remove(identity);
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00039544 File Offset: 0x00037744
	private void OnDisable()
	{
		bool flag = this.ModeMapManager != null;
		if (flag)
		{
			this.ModeMapManager.lazyLoad = true;
		}
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00039570 File Offset: 0x00037770
	public bool WinTheGame()
	{
		bool flag = this.ModeMapManager == null;
		return !flag && this.ModeMapManager.WinTheGame();
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00022CFE File Offset: 0x00020EFE
	public override bool Weaved()
	{
		return true;
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060006AB RID: 1707 RVA: 0x000396C8 File Offset: 0x000378C8
	// (set) Token: 0x060006AC RID: 1708 RVA: 0x000396DB File Offset: 0x000378DB
	public float NetworkSumOfEnemyPositive
	{
		get
		{
			return this.SumOfEnemyPositive;
		}
		[param: In]
		set
		{
			base.GeneratedSyncVarSetter<float>(value, ref this.SumOfEnemyPositive, 1UL, null);
		}
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x000396F5 File Offset: 0x000378F5
	protected void UserCode_RpcTryChange()
	{
		this.TryChange();
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x000396FF File Offset: 0x000378FF
	protected static void InvokeUserCode_RpcTryChange(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcTryChange called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcTryChange();
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00039724 File Offset: 0x00037924
	protected void UserCode_ReadyToChangeMap__NetworkConnectionToClient(NetworkConnectionToClient conn)
	{
		this.NetworkSumOfEnemyPositive = Globals.MapEnemyPositiveFunc(this.ModeMapManager.Level, GameSaveManager.GetValue<int>(GameVar.Difficulty));
		bool inHighTide = RoleTable.Instance.InHighTide;
		if (inHighTide)
		{
			this.NetworkSumOfEnemyPositive = this.SumOfEnemyPositive * 1.3f;
		}
		bool flag = !this.readys.Contains(conn.identity);
		if (flag)
		{
			this.readys.Add(conn.identity);
		}
		bool flag2 = this.readys.Count < NetworkServer.connections.Count;
		if (flag2)
		{
			UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("请等待其他人事件完成", CaptionStyle.Top, 1f, 1.5f, 3);
		}
		else
		{
			this.ModeMapManager.ReadyToChangeMap();
			this.readys.Clear();
		}
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x000397FE File Offset: 0x000379FE
	protected static void InvokeUserCode_ReadyToChangeMap__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command ReadyToChangeMap called on client.");
			return;
		}
		((MapManager)obj).UserCode_ReadyToChangeMap__NetworkConnectionToClient(senderConnection);
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00039824 File Offset: 0x00037A24
	protected void UserCode_CmdReadyToNextMap__NetworkConnectionToClient(NetworkConnectionToClient conn)
	{
		this.readys.Add(conn.identity);
		bool flag = this.readys.Count < NetworkServer.connections.Count;
		if (flag)
		{
			UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("请等待其他人准备", CaptionStyle.Top, 1f, 1.5f, 3);
		}
		else
		{
			this.readys.Clear();
			this.CmdNextMap();
		}
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x0003989B File Offset: 0x00037A9B
	protected static void InvokeUserCode_CmdReadyToNextMap__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdReadyToNextMap called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdReadyToNextMap__NetworkConnectionToClient(senderConnection);
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x000398C0 File Offset: 0x00037AC0
	protected void UserCode_CmdNextMap()
	{
		RoleTable.Instance.LevelCount();
		this.ModeMapManager.NowDice = this.MapTree.currentNode.NodeDice;
		this.RpcSyncDice(JsonConvert.SerializeObject(this.ModeMapManager.NowDice));
		bool flag = this.MapTree.currentNode.data == null;
		if (flag)
		{
			Debug.LogError("地图树丢失！");
		}
		this.RpcLoadMap(this.MapTree.currentNode.data["Type"].ToLower(), this.MapTree.currentNode.data.GetValueOrDefault("NodeId", null));
		this.RpcNextMap();
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00039978 File Offset: 0x00037B78
	protected static void InvokeUserCode_CmdNextMap(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdNextMap called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdNextMap();
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x0003999C File Offset: 0x00037B9C
	protected void UserCode_RpcNextMap()
	{
		IModeManager modeMapManager = this.ModeMapManager;
		int level = modeMapManager.Level;
		modeMapManager.Level = level + 1;
		bool flag = RoleTable.Instance == null;
		if (!flag)
		{
			bool flag2 = this.ModeMapManager.Level % 6 != 0;
			if (flag2)
			{
				bool flag3 = Singleton<GameRuntimeData>.Instance == null || this.MapTree == null || this.MapTree.currentNode == null;
				if (flag3)
				{
					Commands.LogError("地图树丢失！", "没当前节点");
				}
				else
				{
					this.MapTree.currentNode = this.MapTree.currentNode.GetChild(0);
				}
			}
		}
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00039A38 File Offset: 0x00037C38
	protected static void InvokeUserCode_RpcNextMap(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcNextMap called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcNextMap();
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00039A5B File Offset: 0x00037C5B
	protected void UserCode_ResetEvent()
	{
		this.eventWait = 0;
		this.eventDone = 0;
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00039A6C File Offset: 0x00037C6C
	protected static void InvokeUserCode_ResetEvent(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command ResetEvent called on client.");
			return;
		}
		((MapManager)obj).UserCode_ResetEvent();
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00039A90 File Offset: 0x00037C90
	protected void UserCode_CmdAnnounceEventWait()
	{
		this.eventWait++;
		bool flag = this.eventWait >= NetworkServer.connections.Count && this.eventDone > 0;
		if (flag)
		{
			this.RpcTryChange();
			bool flag2 = FightManager.Instance != null;
			if (flag2)
			{
				FightManager.Instance.ResetWaitCount();
			}
		}
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00039AF3 File Offset: 0x00037CF3
	protected static void InvokeUserCode_CmdAnnounceEventWait(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdAnnounceEventWait called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdAnnounceEventWait();
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00039B16 File Offset: 0x00037D16
	protected void UserCode_CmdEventWait()
	{
		this.eventDone++;
		this.CmdAnnounceEventWait();
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00039B2E File Offset: 0x00037D2E
	protected static void InvokeUserCode_CmdEventWait(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdEventWait called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdEventWait();
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00039B51 File Offset: 0x00037D51
	protected void UserCode_RpcSyncDice__String(string diceJSON)
	{
		this.ModeMapManager.NowDice = JsonConvert.DeserializeObject<Dice>(diceJSON);
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00039B66 File Offset: 0x00037D66
	protected static void InvokeUserCode_RpcSyncDice__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcSyncDice called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcSyncDice__String(reader.ReadString());
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00039B90 File Offset: 0x00037D90
	protected void UserCode_RpcSyncRandom__Int32(int seed)
	{
		bool flag = !base.isClientOnly;
		if (!flag)
		{
			System.Random random = new System.Random(seed);
			bool flag2 = !PlayerManager.Instance.isClientOnly;
			int realSeed;
			if (flag2)
			{
				realSeed = seed;
			}
			else
			{
				ulong seed2 = ulong.Parse(Singleton<GameConfigManager>.Instance.PlayerId);
				int seed3 = random.Next(0, int.MaxValue);
				realSeed = (int)(seed2 % (ulong)((long)seed3));
			}
			Singleton<TempDataManager>.Instance.Random(realSeed);
		}
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00039C01 File Offset: 0x00037E01
	protected static void InvokeUserCode_RpcSyncRandom__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcSyncRandom called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcSyncRandom__Int32(reader.ReadVarInt());
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00039C2C File Offset: 0x00037E2C
	protected void UserCode_CmdSelectMap__String[]__String[]__NetworkConnectionToClient(string[] maps, string[] mapdata, NetworkConnectionToClient conn)
	{
		this.mapList = maps;
		foreach (KeyValuePair<int, NetworkConnectionToClient> player in NetworkServer.connections)
		{
			bool flag = player.Value.identity == conn.identity;
			if (!flag)
			{
				this.TargetUpdateMap(player.Value, maps, mapdata);
			}
		}
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00039CB0 File Offset: 0x00037EB0
	protected static void InvokeUserCode_CmdSelectMap__String[]__String[]__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdSelectMap called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdSelectMap__String[]__String[]__NetworkConnectionToClient(Mirror.GeneratedNetworkCode._Read_System.String[](reader), Mirror.GeneratedNetworkCode._Read_System.String[](reader), senderConnection);
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00039CE0 File Offset: 0x00037EE0
	protected void UserCode_TargetUpdateMap__NetworkConnection__String[]__String[](NetworkConnection conn, string[] maps, string[] mapdata)
	{
		this.mapList = maps;
		this.mapData = mapdata;
		UniTask.WaitUntil(() => UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI") != null, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").ShowMap();
		}).Forget();
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00039D55 File Offset: 0x00037F55
	protected static void InvokeUserCode_TargetUpdateMap__NetworkConnection__String[]__String[](NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("TargetRPC TargetUpdateMap called on server.");
			return;
		}
		((MapManager)obj).UserCode_TargetUpdateMap__NetworkConnection__String[]__String[](null, Mirror.GeneratedNetworkCode._Read_System.String[](reader), Mirror.GeneratedNetworkCode._Read_System.String[](reader));
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00039D85 File Offset: 0x00037F85
	protected void UserCode_CmdMapDrawBegin__String__String__Vector2__NetworkConnectionToClient(string strokeId, string authorId, Vector2 startPoint, NetworkConnectionToClient conn)
	{
		this.RpcMapDrawBegin(strokeId, authorId, startPoint);
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00039D92 File Offset: 0x00037F92
	protected static void InvokeUserCode_CmdMapDrawBegin__String__String__Vector2__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdMapDrawBegin called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdMapDrawBegin__String__String__Vector2__NetworkConnectionToClient(reader.ReadString(), reader.ReadString(), reader.ReadVector2(), senderConnection);
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00039DC8 File Offset: 0x00037FC8
	protected void UserCode_RpcMapDrawBegin__String__String__Vector2(string strokeId, string authorId, Vector2 startPoint)
	{
		UniTask.WaitUntil(() => UIManager.Instance != null && UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI") != null, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").ReceiveNetworkDrawBegin(strokeId, authorId, startPoint);
		}).Forget();
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00039E37 File Offset: 0x00038037
	protected static void InvokeUserCode_RpcMapDrawBegin__String__String__Vector2(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcMapDrawBegin called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcMapDrawBegin__String__String__Vector2(reader.ReadString(), reader.ReadString(), reader.ReadVector2());
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00039E6C File Offset: 0x0003806C
	protected void UserCode_CmdMapDrawPoint__String__String__Vector2__NetworkConnectionToClient(string strokeId, string authorId, Vector2 point, NetworkConnectionToClient conn)
	{
		this.RpcMapDrawPoint(strokeId, authorId, point);
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00039E79 File Offset: 0x00038079
	protected static void InvokeUserCode_CmdMapDrawPoint__String__String__Vector2__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdMapDrawPoint called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdMapDrawPoint__String__String__Vector2__NetworkConnectionToClient(reader.ReadString(), reader.ReadString(), reader.ReadVector2(), senderConnection);
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00039EB0 File Offset: 0x000380B0
	protected void UserCode_RpcMapDrawPoint__String__String__Vector2(string strokeId, string authorId, Vector2 point)
	{
		UniTask.WaitUntil(() => UIManager.Instance != null && UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI") != null, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").ReceiveNetworkDrawPoint(strokeId, authorId, point);
		}).Forget();
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00039F1F File Offset: 0x0003811F
	protected static void InvokeUserCode_RpcMapDrawPoint__String__String__Vector2(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcMapDrawPoint called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcMapDrawPoint__String__String__Vector2(reader.ReadString(), reader.ReadString(), reader.ReadVector2());
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00039F54 File Offset: 0x00038154
	protected void UserCode_CmdMapDrawEnd__String__String__NetworkConnectionToClient(string strokeId, string authorId, NetworkConnectionToClient conn)
	{
		this.RpcMapDrawEnd(strokeId, authorId);
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00039F60 File Offset: 0x00038160
	protected static void InvokeUserCode_CmdMapDrawEnd__String__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdMapDrawEnd called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdMapDrawEnd__String__String__NetworkConnectionToClient(reader.ReadString(), reader.ReadString(), senderConnection);
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00039F90 File Offset: 0x00038190
	protected void UserCode_RpcMapDrawEnd__String__String(string strokeId, string authorId)
	{
		UniTask.WaitUntil(() => UIManager.Instance != null && UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI") != null, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").ReceiveNetworkDrawEnd(strokeId, authorId);
		}).Forget();
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00039FF8 File Offset: 0x000381F8
	protected static void InvokeUserCode_RpcMapDrawEnd__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcMapDrawEnd called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcMapDrawEnd__String__String(reader.ReadString(), reader.ReadString());
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x0003A027 File Offset: 0x00038227
	protected void UserCode_CmdMapErase__String__Vector2__Single__NetworkConnectionToClient(string authorId, Vector2 point, float radius, NetworkConnectionToClient conn)
	{
		this.RpcMapErase(authorId, point, radius);
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x0003A034 File Offset: 0x00038234
	protected static void InvokeUserCode_CmdMapErase__String__Vector2__Single__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdMapErase called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdMapErase__String__Vector2__Single__NetworkConnectionToClient(reader.ReadString(), reader.ReadVector2(), reader.ReadFloat(), senderConnection);
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x0003A06C File Offset: 0x0003826C
	protected void UserCode_RpcMapErase__String__Vector2__Single(string authorId, Vector2 point, float radius)
	{
		UniTask.WaitUntil(() => UIManager.Instance != null && UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI") != null, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").ReceiveNetworkErase(authorId, point, radius);
		}).Forget();
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x0003A0DB File Offset: 0x000382DB
	protected static void InvokeUserCode_RpcMapErase__String__Vector2__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcMapErase called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcMapErase__String__Vector2__Single(reader.ReadString(), reader.ReadVector2(), reader.ReadFloat());
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x0003A111 File Offset: 0x00038311
	protected void UserCode_CmdMapClearAll__String__NetworkConnectionToClient(string authorId, NetworkConnectionToClient conn)
	{
		this.RpcMapClearAll(authorId);
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x0003A11C File Offset: 0x0003831C
	protected static void InvokeUserCode_CmdMapClearAll__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdMapClearAll called on client.");
			return;
		}
		((MapManager)obj).UserCode_CmdMapClearAll__String__NetworkConnectionToClient(reader.ReadString(), senderConnection);
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x0003A148 File Offset: 0x00038348
	protected void UserCode_RpcMapClearAll__String(string authorId)
	{
		UniTask.WaitUntil(() => UIManager.Instance != null && UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI") != null, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").ReceiveNetworkClearAll(authorId);
		}).Forget();
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x0003A1A9 File Offset: 0x000383A9
	protected static void InvokeUserCode_RpcMapClearAll__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcMapClearAll called on server.");
			return;
		}
		((MapManager)obj).UserCode_RpcMapClearAll__String(reader.ReadString());
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x0003A1D4 File Offset: 0x000383D4
	static MapManager()
	{
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::ReadyToChangeMap(Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(MapManager.InvokeUserCode_ReadyToChangeMap__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdReadyToNextMap(Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdReadyToNextMap__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdNextMap()", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdNextMap), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::ResetEvent()", new RemoteCallDelegate(MapManager.InvokeUserCode_ResetEvent), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdAnnounceEventWait()", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdAnnounceEventWait), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdEventWait()", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdEventWait), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdSelectMap(System.String[],System.String[],Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdSelectMap__String[]__String[]__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdMapDrawBegin(System.String,System.String,UnityEngine.Vector2,Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdMapDrawBegin__String__String__Vector2__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdMapDrawPoint(System.String,System.String,UnityEngine.Vector2,Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdMapDrawPoint__String__String__Vector2__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdMapDrawEnd(System.String,System.String,Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdMapDrawEnd__String__String__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdMapErase(System.String,UnityEngine.Vector2,System.Single,Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdMapErase__String__Vector2__Single__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(MapManager), "System.Void MapManager::CmdMapClearAll(System.String,Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(MapManager.InvokeUserCode_CmdMapClearAll__String__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcTryChange()", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcTryChange));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcNextMap()", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcNextMap));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcSyncDice(System.String)", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcSyncDice__String));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcSyncRandom(System.Int32)", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcSyncRandom__Int32));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcMapDrawBegin(System.String,System.String,UnityEngine.Vector2)", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcMapDrawBegin__String__String__Vector2));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcMapDrawPoint(System.String,System.String,UnityEngine.Vector2)", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcMapDrawPoint__String__String__Vector2));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcMapDrawEnd(System.String,System.String)", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcMapDrawEnd__String__String));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcMapErase(System.String,UnityEngine.Vector2,System.Single)", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcMapErase__String__Vector2__Single));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::RpcMapClearAll(System.String)", new RemoteCallDelegate(MapManager.InvokeUserCode_RpcMapClearAll__String));
		RemoteProcedureCalls.RegisterRpc(typeof(MapManager), "System.Void MapManager::TargetUpdateMap(Mirror.NetworkConnection,System.String[],System.String[])", new RemoteCallDelegate(MapManager.InvokeUserCode_TargetUpdateMap__NetworkConnection__String[]__String[]));
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0003A4B0 File Offset: 0x000386B0
	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
		base.SerializeSyncVars(writer, forceAll);
		if (forceAll)
		{
			writer.WriteFloat(this.SumOfEnemyPositive);
			return;
		}
		writer.WriteVarULong(this.syncVarDirtyBits);
		if ((this.syncVarDirtyBits & 1UL) != 0UL)
		{
			writer.WriteFloat(this.SumOfEnemyPositive);
		}
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x0003A508 File Offset: 0x00038708
	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
		base.DeserializeSyncVars(reader, initialState);
		if (initialState)
		{
			base.GeneratedSyncVarDeserialize<float>(ref this.SumOfEnemyPositive, null, reader.ReadFloat());
			return;
		}
		long num = (long)reader.ReadVarULong();
		if ((num & 1L) != 0L)
		{
			base.GeneratedSyncVarDeserialize<float>(ref this.SumOfEnemyPositive, null, reader.ReadFloat());
		}
	}

	// Token: 0x04000ABE RID: 2750
	public IModeManager ModeMapManager;

	// Token: 0x04000ABF RID: 2751
	private HashSet<NetworkIdentity> readys = new HashSet<NetworkIdentity>();

	// Token: 0x04000AC0 RID: 2752
	public string CurrentMode = "Normal";

	// Token: 0x04000AC1 RID: 2753
	public string[] mapList = new string[]
	{
		"map_0",
		"map_1",
		"map_2",
		"map_3",
		"map_4",
		"map_5"
	};

	// Token: 0x04000AC2 RID: 2754
	public string[] mapData = new string[0];

	// Token: 0x04000AC3 RID: 2755
	[SyncVar]
	public float SumOfEnemyPositive = 1f;

	// Token: 0x04000AC4 RID: 2756
	public int eventWait = 0;

	// Token: 0x04000AC5 RID: 2757
	public int eventDone = 0;
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Data.Save;
using Fight.ActionCommand;
using Fight.ObjTarget;
using Fight.StatusCommand;
using Mirror;
using Mirror.RemoteCalls;
using Network.Command;
using Newtonsoft.Json;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;
using ZLinq;
using ZLinq.Linq;

/// <summary>
/// 战斗管理器
/// </summary>
// Token: 0x020000BF RID: 191
public class FightManager : NetworkBehaviour
{
	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000605 RID: 1541 RVA: 0x00036389 File Offset: 0x00034589
	public string selfIndex
	{
		get
		{
			return PlayerManager.Instance.PlayerId;
		}
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00036398 File Offset: 0x00034598
	[Command(requiresAuthority = false)]
	public void ResetWaitCount()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void FightManager::ResetWaitCount()", -1512883397, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x000363C8 File Offset: 0x000345C8
	[Command(requiresAuthority = false)]
	public void ReadyToInit(string level)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(level);
		base.SendCommandInternal("System.Void FightManager::ReadyToInit(System.String)", -1110607194, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00036404 File Offset: 0x00034604
	[Server]
	public void RpcFightCheck()
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void FightManager::RpcFightCheck()' called when server was not active");
			return;
		}
		bool flag = this.waitCount >= NetworkServer.connections.Count;
		if (flag)
		{
			this.readyCount = 0;
			this.announceCount = 0;
			this.TempRoleList.Clear();
			this.roleQueue.Clear();
			this.statusData.Clear();
			foreach (KeyValuePair<string, RoleTable> item in GameServer.Instance.RoleTables)
			{
				bool flag2 = !GameServer.Instance.CheckOnline(item.Key);
				if (!flag2)
				{
					FightManager.RoleData role = new FightManager.RoleData(item.Key);
					role.MaxHp = item.Value.MaxSan;
					role.CurHp = item.Value.San;
					role.Defend = 0;
					role.career = item.Value.Career;
					role.State = IStatusManager.State.Default;
					this.TempRoleList.Add(item.Key, JsonConvert.SerializeObject(item.Value));
					this.roleQueue.Add(role);
				}
			}
			this.SumOfEnemyPositive = Globals.MapEnemyPositiveFunc(GameSaveManager.GetLevel(), GameSaveManager.GetValue<int>(GameVar.Difficulty));
			bool inHighTide = RoleTable.Instance.InHighTide;
			if (inHighTide)
			{
				this.SumOfEnemyPositive *= 1.3f;
			}
			bool flag3 = this.roleQueue.Count == 0;
			if (flag3)
			{
				Debug.Log("一个角色都没有");
			}
			else
			{
				this.NetworkNowActionRole = this.roleQueue[0].InstanceId;
				this.Init(this.level, GZip.CompressString(JsonConvert.SerializeObject(this.roleQueue)), GZip.CompressString(JsonConvert.SerializeObject(this.TempRoleList)), this.SumOfEnemyPositive);
				this.waitCount = 0;
				this.ReSetCount = 0;
			}
		}
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00036618 File Offset: 0x00034818
	[Command(requiresAuthority = false)]
	public void ReadyToStart()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void FightManager::ReadyToStart()", -180028292, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00036648 File Offset: 0x00034848
	[Command(requiresAuthority = false)]
	public void ReSetFight(string level)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(level);
		base.SendCommandInternal("System.Void FightManager::ReSetFight(System.String)", -1689031735, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00036684 File Offset: 0x00034884
	[ClientRpc]
	public void ClearFightui()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void FightManager::ClearFightui()", -1059741479, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x000366B4 File Offset: 0x000348B4
	[Command(requiresAuthority = false)]
	public void CmdSendEvent(string action, string Id, string fromId, string theData, params string[] Vars)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(action);
		writer.WriteString(Id);
		writer.WriteString(fromId);
		writer.WriteString(theData);
		Mirror.GeneratedNetworkCode._Write_System.String[](writer, Vars);
		base.SendCommandInternal("System.Void FightManager::CmdSendEvent(System.String,System.String,System.String,System.String,System.String[])", 2030457518, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00036718 File Offset: 0x00034918
	[ClientRpc]
	public void Init(string level, byte[] roleQueueStream, byte[] fromtempRoleListStream, float positive)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(level);
		writer.WriteBytesAndSize(roleQueueStream);
		writer.WriteBytesAndSize(fromtempRoleListStream);
		writer.WriteFloat(positive);
		this.SendRPCInternal("System.Void FightManager::Init(System.String,System.Byte[],System.Byte[],System.Single)", 1804390089, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00036770 File Offset: 0x00034970
	[Command(requiresAuthority = false)]
	public void CmdAddEnemy(string enemyId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(enemyId);
		base.SendCommandInternal("System.Void FightManager::CmdAddEnemy(System.String)", 791915405, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x000367AC File Offset: 0x000349AC
	[ClientRpc]
	public void RpcAddEnemy(string enemyId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(enemyId);
		this.SendRPCInternal("System.Void FightManager::RpcAddEnemy(System.String)", 98757360, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x000367E8 File Offset: 0x000349E8
	[ClientRpc]
	public void SyncStatus(StatusDataTransfer statusData)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		Mirror.GeneratedNetworkCode._Write_StatusDataTransfer(writer, statusData);
		this.SendRPCInternal("System.Void FightManager::SyncStatus(StatusDataTransfer)", 2145605892, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00036822 File Offset: 0x00034A22
	private void Awake()
	{
		FightManager.Instance = this;
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0003682C File Offset: 0x00034A2C
	[Command(requiresAuthority = false)]
	public void CmdChangeType(FightType type)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		Mirror.GeneratedNetworkCode._Write_FightType(writer, type);
		base.SendCommandInternal("System.Void FightManager::CmdChangeType(FightType)", -280709600, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00036868 File Offset: 0x00034A68
	[Command(requiresAuthority = false)]
	public void CmdPlayChange(string instanceId)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(instanceId);
		base.SendCommandInternal("System.Void FightManager::CmdPlayChange(System.String)", -924867116, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x000368A4 File Offset: 0x00034AA4
	[Command(requiresAuthority = false)]
	public void CmdAnnounceDone(string instanceId, bool isDead)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(instanceId);
		writer.WriteBool(isDead);
		base.SendCommandInternal("System.Void FightManager::CmdAnnounceDone(System.String,System.Boolean)", 1189196738, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x000368E8 File Offset: 0x00034AE8
	[ClientRpc]
	public void EndPlayerturn()
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		this.SendRPCInternal("System.Void FightManager::EndPlayerturn()", -5690901, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00036918 File Offset: 0x00034B18
	public void TurnEnd()
	{
		FightPlayer instance = FightPlayer.Instance;
		if (instance != null)
		{
			instance.StopBoredTimer();
		}
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").onChangeTurnBtn();
		}
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x00036968 File Offset: 0x00034B68
	[TargetRpc]
	public void TargetChangeUnit(NetworkConnection conn, FightType newType, string nowAction)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		Mirror.GeneratedNetworkCode._Write_FightType(writer, newType);
		writer.WriteString(nowAction);
		this.SendTargetRPCInternal(conn, "System.Void FightManager::TargetChangeUnit(Mirror.NetworkConnection,FightType,System.String)", -1240122374, writer, 0);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x000369AC File Offset: 0x00034BAC
	public void ChangeUnit(FightType newType)
	{
		bool flag = newType == this.fightType || ((this.fightType == FightType.None || this.fightType == FightType.Win) && newType != FightType.Init && newType > FightType.None);
		if (!flag)
		{
			this.fightType = newType;
			switch (this.fightType)
			{
			case FightType.None:
				this.fightUnit = null;
				break;
			case FightType.Init:
				this.fightUnit = new FightInit();
				break;
			case FightType.Start:
				this.fightUnit = new Fight_Start();
				break;
			case FightType.Player:
				this.fightUnit = new Fight_PlayerTurn();
				break;
			case FightType.OtherTurn:
				this.fightUnit = new Fight_OtherTurn();
				break;
			case FightType.Partner:
				this.fightUnit = new Fight_Partner();
				break;
			case FightType.Enemy:
				this.fightUnit = new Fight_EnemyTurn();
				break;
			case FightType.Win:
				this.fightUnit = new Fight_Win();
				break;
			case FightType.Loss:
				this.fightUnit = new Fight_Loss();
				break;
			}
			FightUnit fightUnit = this.fightUnit;
			if (fightUnit != null)
			{
				fightUnit.Init();
			}
		}
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00036AB0 File Offset: 0x00034CB0
	private void Update()
	{
		bool flag = this.fightType == FightType.None;
		if (!flag)
		{
			FightUnit fightUnit = this.fightUnit;
			if (fightUnit != null)
			{
				fightUnit.OnUpdate();
			}
			Queue<ClientCommandBase> tmpList = new Queue<ClientCommandBase>(this.eventList);
			Queue<ObjTargetBase> TargetList = new Queue<ObjTargetBase>(this.targetList);
			this.eventList.Clear();
			this.targetList.Clear();
			while (tmpList.Count > 0)
			{
				ClientCommandBase eventData = tmpList.Dequeue();
				this.RunEvent(eventData);
			}
			while (TargetList.Count > 0)
			{
				ObjTargetBase eventData2 = TargetList.Dequeue();
				this.RunTargetEvent(eventData2);
			}
			bool active = NetworkServer.active;
			if (active)
			{
				foreach (KeyValuePair<string, StatusDataTransfer> status in this.statusData)
				{
					this.SyncStatus(status.Value);
				}
			}
		}
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x00036BB8 File Offset: 0x00034DB8
	private void RunEvent(ClientCommandBase statusCommand)
	{
		bool flag = !this.statuses.ContainsKey(statusCommand.InstanceId);
		if (flag)
		{
			Debug.LogWarning("没有找到对应的角色" + statusCommand.InstanceId);
		}
		else
		{
			statusCommand.Execute();
		}
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00036C00 File Offset: 0x00034E00
	private void RunTargetEvent(ObjTargetBase statusCommand)
	{
		bool flag = !this.statuses.ContainsKey(statusCommand.InstanceId);
		if (flag)
		{
			Debug.LogError("没有找到对应的角色" + statusCommand.InstanceId);
		}
		else
		{
			statusCommand.Execute();
		}
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00036C48 File Offset: 0x00034E48
	public void EnqueueEvent(IStatusCommand statusCommand)
	{
		bool flag = statusCommand == null;
		if (!flag)
		{
			ClientCommandBase clientCommand = statusCommand as ClientCommandBase;
			bool flag2 = clientCommand != null;
			if (flag2)
			{
				this.CmdEnqueueEvent(clientCommand);
			}
			else
			{
				ActionCommandBase actionCommand = statusCommand as ActionCommandBase;
				bool flag3 = actionCommand != null;
				if (flag3)
				{
					bool flag4 = actionCommand is UseCard || actionCommand is ActionAnimation;
					if (flag4)
					{
						FightPlayer instance = FightPlayer.Instance;
						if (instance != null)
						{
							instance.ResetBoredTimer();
						}
					}
					bool reliable = actionCommand.Reliable;
					if (reliable)
					{
						this.CmdEnqueueActionReliable(actionCommand);
					}
					else
					{
						this.CmdEnqueueActionUnreliable(actionCommand);
					}
				}
				else
				{
					Debug.LogError("事件类型错误");
				}
			}
		}
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00036CF0 File Offset: 0x00034EF0
	public void EnqueueEvent(IStatusCommand statusCommand, NetworkConnection conn)
	{
		ObjTargetBase objTarget = statusCommand as ObjTargetBase;
		bool flag = objTarget != null;
		if (flag)
		{
			this.TargetEnqueueEvent(conn, objTarget);
		}
		else
		{
			Debug.LogError("事件类型错误");
		}
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00036D28 File Offset: 0x00034F28
	[TargetRpc]
	public void TargetEnqueueEvent(NetworkConnection target, ObjTargetBase objCommand)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(objCommand);
		this.SendTargetRPCInternal(target, "System.Void FightManager::TargetEnqueueEvent(Mirror.NetworkConnection,Fight.ObjTarget.ObjTargetBase)", 1528257889, writer, 0);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00036D64 File Offset: 0x00034F64
	[Command(requiresAuthority = false, channel = 0)]
	private void CmdEnqueueActionReliable(ActionCommandBase actionCommand)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(actionCommand);
		base.SendCommandInternal("System.Void FightManager::CmdEnqueueActionReliable(Fight.ActionCommand.ActionCommandBase)", 1944151475, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00036DA0 File Offset: 0x00034FA0
	[Command(requiresAuthority = false, channel = 1)]
	private void CmdEnqueueActionUnreliable(ActionCommandBase actionCommand)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(actionCommand);
		base.SendCommandInternal("System.Void FightManager::CmdEnqueueActionUnreliable(Fight.ActionCommand.ActionCommandBase)", -1791305042, writer, 1, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00036DDC File Offset: 0x00034FDC
	[ClientRpc(channel = 0)]
	private void RpcSyncActionReliable(ActionCommandBase actionCommand)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(actionCommand);
		this.SendRPCInternal("System.Void FightManager::RpcSyncActionReliable(Fight.ActionCommand.ActionCommandBase)", -1283119465, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00036E18 File Offset: 0x00035018
	[ClientRpc(channel = 1)]
	private void RpcSyncActionUnreliable(ActionCommandBase actionCommand)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(actionCommand);
		this.SendRPCInternal("System.Void FightManager::RpcSyncActionUnreliable(Fight.ActionCommand.ActionCommandBase)", -698247022, writer, 1, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00036E54 File Offset: 0x00035054
	[Command(requiresAuthority = false)]
	public void CmdEnqueueEvent(ClientCommandBase statusCommand)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.Write(statusCommand);
		base.SendCommandInternal("System.Void FightManager::CmdEnqueueEvent(Fight.StatusCommand.ClientCommandBase)", -1284314344, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x00036E90 File Offset: 0x00035090
	[Command(requiresAuthority = false)]
	public void CmdCheckDead(NetworkConnectionToClient conn = null)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		base.SendCommandInternal("System.Void FightManager::CmdCheckDead(Mirror.NetworkConnectionToClient)", -1204708809, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00036EC0 File Offset: 0x000350C0
	public IEnumerator DOAllAction()
	{
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") == null;
		if (flag)
		{
			yield break;
		}
		bool flag2 = EnemyManager.Instance.enemyList.Count == 0 || EnemyManager.enemyCount == 0;
		if (flag2)
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").CanWin();
		}
		else
		{
			ImmutableList<FightObject> tempList = ImmutableList.CreateRange<FightObject>((from x in this.ActionQueue.AsValueEnumerable<FightObject>()
			where (!(x is FightPlayer) && x.Status.state != IStatusManager.State.Dead) || x is FightPlayer
			select x).ToList<ListWhere<FightObject>, FightObject>());
			foreach (FightObject obj in tempList)
			{
				OtherObj otherObj = obj as OtherObj;
				bool flag3 = otherObj != null;
				if (flag3)
				{
					IStatusManager status = obj.Status;
					bool flag4 = status.state != IStatusManager.State.Dead;
					if (flag4)
					{
						otherObj.ActionCount = otherObj.MaxActionCount;
						obj.Status.ToughCount = obj.Status.ToughOrigin;
						otherObj.SetAction();
					}
					status = null;
				}
				otherObj = null;
				obj = null;
			}
			ImmutableList<FightObject>.Enumerator enumerator = default(ImmutableList<FightObject>.Enumerator);
			this.ActionQueue = tempList.AsValueEnumerable<FightObject>().ToList<FromEnumerable<FightObject>, FightObject>();
			int num;
			for (int i = 0; i < tempList.Count; i = num + 1)
			{
				bool flag5 = tempList[i] == null || (!(tempList[i].Status.fatherObject is FightPlayer) && tempList[i].Status.state == IStatusManager.State.Dead);
				if (!flag5)
				{
					PlayerManager.Instance.SendRpcCommand(new RpcSendChat(tempList[i].Name, tempList[i].Name + "的回合"));
					AudioManager instance = AudioManager.Instance;
					if (instance != null)
					{
						instance.PlayEffect("Effect/行动单位发生变化");
					}
					(tempList[i].Status as StatusManager).statusBarUI.OnSelected();
					yield return UniTask.WaitForSeconds(2f, false, PlayerLoopTiming.Update, default(CancellationToken), false);
					bool flag6 = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
					if (flag6)
					{
						List<FightObject> IndexList = (from x in tempList.AsValueEnumerable<FightObject>()
						where x != null && x.gameObject != null && x.Status.state != IStatusManager.State.Dead
						orderby x.transform.position.x
						select x).ToList<OrderBy<Where<FromEnumerable<FightObject>, FightObject>, FightObject, float>, FightObject>();
						int indexInPos = IndexList.IndexOf(tempList[i]);
						UIManager.Instance.GetUI<FightUI>("FightUI").SetTurn(tempList[i], indexInPos, tempList.Count);
						IndexList = null;
					}
					yield return this.DoAction(tempList[i]);
					FightUI fightUI = UIManager.Instance.GetUI<FightUI>("FightUI");
					bool flag7 = fightUI != null;
					if (flag7)
					{
						CancellationToken token = fightUI.destroyCancellationToken;
						yield return UniTask.WaitUntil(delegate()
						{
							FightUI ui = UIManager.Instance.GetUI<FightUI>("FightUI");
							return ui == null || !ui.NowAnimation;
						}, PlayerLoopTiming.Update, token, false).ToCoroutine(null);
						WaitForSeconds wait = new WaitForSeconds(0.5f);
						yield return wait;
						token = default(CancellationToken);
						wait = null;
					}
					bool flag8 = i < tempList.Count - 1;
					if (flag8)
					{
						(tempList[i].Status as StatusManager).statusBarUI.OnUnSelected();
					}
					fightUI = null;
				}
				num = i;
			}
			this.ActionQueue = (from x in this.ActionQueue.AsValueEnumerable<FightObject>()
			where (!(x is FightPlayer) && x.Status.state != IStatusManager.State.Dead) || x is FightPlayer
			select x).ToList<ListWhere<FightObject>, FightObject>();
			bool flag9 = this.ActionQueue.Count == 0 || EnemyManager.Instance.enemyList.Count == 0 || EnemyManager.enemyCount == 0;
			if (flag9)
			{
				yield break;
			}
			yield return this.DOAllAction();
			tempList = null;
		}
		yield break;
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x00036ED0 File Offset: 0x000350D0
	[Command(requiresAuthority = false)]
	public void CmdChangeCareer(string CareerId, string playerIdentity)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(CareerId);
		writer.WriteString(playerIdentity);
		base.SendCommandInternal("System.Void FightManager::CmdChangeCareer(System.String,System.String)", 1711794052, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00036F14 File Offset: 0x00035114
	[ClientRpc]
	public void RpcChangeCareer(string CareerId, string playerIdentity)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(CareerId);
		writer.WriteString(playerIdentity);
		this.SendRPCInternal("System.Void FightManager::RpcChangeCareer(System.String,System.String)", 1907961097, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00036F58 File Offset: 0x00035158
	[Command(requiresAuthority = false)]
	public void CmdActionChange(string instanceId, string index)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(instanceId);
		writer.WriteString(index);
		base.SendCommandInternal("System.Void FightManager::CmdActionChange(System.String,System.String)", -1746023540, writer, 0, false);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00036F9C File Offset: 0x0003519C
	[ClientRpc]
	public void RpcActionChange(string instanceId, string index)
	{
		NetworkWriterPooled writer = NetworkWriterPool.Get();
		writer.WriteString(instanceId);
		writer.WriteString(index);
		this.SendRPCInternal("System.Void FightManager::RpcActionChange(System.String,System.String)", 1518783869, writer, 0, true);
		NetworkWriterPool.Return(writer);
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00036FE0 File Offset: 0x000351E0
	public IEnumerator DoAction(FightObject fightObject)
	{
		fightObject.Status.dynamicVariables["thisHP"] = 0f;
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") == null;
		if (flag)
		{
			yield break;
		}
		yield return fightObject.DoAction();
		fightObject.EndRound();
		yield break;
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00036822 File Offset: 0x00034A22
	private void OnEnable()
	{
		FightManager.Instance = this;
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x00036FF6 File Offset: 0x000351F6
	private void OnDisable()
	{
		this.fightType = FightType.None;
		this.fightUnit = null;
		FightManager.Instance = null;
		base.StopAllCoroutines();
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00022CFE File Offset: 0x00020EFE
	public override bool Weaved()
	{
		return true;
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x0600062F RID: 1583 RVA: 0x000370FC File Offset: 0x000352FC
	// (set) Token: 0x06000630 RID: 1584 RVA: 0x0003710F File Offset: 0x0003530F
	public string NetworkNowActionRole
	{
		get
		{
			return this.NowActionRole;
		}
		[param: In]
		set
		{
			base.GeneratedSyncVarSetter<string>(value, ref this.NowActionRole, 1UL, null);
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00037129 File Offset: 0x00035329
	protected void UserCode_ResetWaitCount()
	{
		this.waitCount = 0;
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00037133 File Offset: 0x00035333
	protected static void InvokeUserCode_ResetWaitCount(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command ResetWaitCount called on client.");
			return;
		}
		((FightManager)obj).UserCode_ResetWaitCount();
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00037156 File Offset: 0x00035356
	protected void UserCode_ReadyToInit__String(string level)
	{
		this.waitCount++;
		this.IsRet = false;
		this.wantLevel = level;
		this.level = level;
		this.RpcFightCheck();
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00037183 File Offset: 0x00035383
	protected static void InvokeUserCode_ReadyToInit__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command ReadyToInit called on client.");
			return;
		}
		((FightManager)obj).UserCode_ReadyToInit__String(reader.ReadString());
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x000371AC File Offset: 0x000353AC
	protected void UserCode_ReadyToStart()
	{
		this.readyCount++;
		bool flag = this.readyCount == NetworkServer.connections.Count;
		if (flag)
		{
			this.CmdChangeType(FightType.Start);
			this.readyCount = 0;
			this.announceCount = 0;
		}
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x000371F6 File Offset: 0x000353F6
	protected static void InvokeUserCode_ReadyToStart(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command ReadyToStart called on client.");
			return;
		}
		((FightManager)obj).UserCode_ReadyToStart();
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0003721C File Offset: 0x0003541C
	protected void UserCode_ReSetFight__String(string level)
	{
		this.ReSetCount++;
		bool flag = this.ReSetCount == NetworkServer.connections.Count;
		if (flag)
		{
			this.readyCount = 0;
			this.ClearFightui();
		}
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x0003725E File Offset: 0x0003545E
	protected static void InvokeUserCode_ReSetFight__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command ReSetFight called on client.");
			return;
		}
		((FightManager)obj).UserCode_ReSetFight__String(reader.ReadString());
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00037288 File Offset: 0x00035488
	protected void UserCode_ClearFightui()
	{
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") == null;
		if (!flag)
		{
			base.StopAllCoroutines();
			UIManager.Instance.GetUI<FightUI>("FightUI").Reset();
			this.statusData.Clear();
			bool isServer = PlayerManager.Instance.isServer;
			if (isServer)
			{
				this.NetworkNowActionRole = this.roleQueue[0].InstanceId;
				this.SumOfEnemyPositive = Globals.MapEnemyPositiveFunc(GameSaveManager.GetLevel(), GameSaveManager.GetValue<int>(GameVar.Difficulty));
				bool inHighTide = RoleTable.Instance.InHighTide;
				if (inHighTide)
				{
					this.SumOfEnemyPositive *= 1.3f;
				}
				List<FightManager.RoleData> tempRole = new List<FightManager.RoleData>(this.roleQueue);
				foreach (FightManager.RoleData item in tempRole)
				{
					bool flag2 = !GameServer.Instance.RoleTables.ContainsKey(item.InstanceId) || !GameServer.Instance.CheckOnline(item.InstanceId);
					if (flag2)
					{
						this.roleQueue.Remove(item);
						this.TempRoleList.Remove(item.InstanceId);
					}
				}
				this.Init(this.level, GZip.CompressString(JsonConvert.SerializeObject(this.roleQueue)), GZip.CompressString(""), this.SumOfEnemyPositive);
				this.IsRet = true;
				this.ReSetCount = 0;
			}
		}
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00037424 File Offset: 0x00035624
	protected static void InvokeUserCode_ClearFightui(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC ClearFightui called on server.");
			return;
		}
		((FightManager)obj).UserCode_ClearFightui();
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00037448 File Offset: 0x00035648
	protected void UserCode_CmdSendEvent__String__String__String__String__String[](string action, string Id, string fromId, string theData, string[] Vars)
	{
		foreach (LobbyInfo.PlayerInfo player in GameServer.Instance.LobbyInfo.AddedPlayers)
		{
			bool flag = player.Id == Id || Singleton<TempDataManager>.Instance.RoleStatusMap[player.Id].Contains(Id);
			if (flag)
			{
				this.EnqueueEvent(new ObjTargetAction().Create(Id, action, fromId, theData, Vars), player.Connection);
			}
		}
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x000374F4 File Offset: 0x000356F4
	protected static void InvokeUserCode_CmdSendEvent__String__String__String__String__String[](NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdSendEvent called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdSendEvent__String__String__String__String__String[](reader.ReadString(), reader.ReadString(), reader.ReadString(), reader.ReadString(), Mirror.GeneratedNetworkCode._Read_System.String[](reader));
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00037540 File Offset: 0x00035740
	protected void UserCode_Init__String__Byte[]__Byte[]__Single(string level, byte[] roleQueueStream, byte[] fromtempRoleListStream, float positive)
	{
		this.SumOfEnemyPositive = positive;
		this.eventList.Clear();
		this.targetList.Clear();
		this.statusData.Clear();
		this.ActionQueue.Clear();
		this.statuses.Clear();
		string roleQueue = GZip.DecompressToString(roleQueueStream);
		string fromtempRoleList = GZip.DecompressToString(fromtempRoleListStream);
		bool flag = fromtempRoleList != "";
		if (flag)
		{
			this.TempRoleList = JsonConvert.DeserializeObject<Dictionary<string, string>>(fromtempRoleList);
		}
		this.roleQueue = JsonConvert.DeserializeObject<List<FightManager.RoleData>>(roleQueue);
		this.level = level;
		this.ValueDice = new ScriptExecutor.DiceWrapper(Dice.Value.WithCursor(MapManager.Instance.NowDice._cursor.val));
		this.CheckDice = new ScriptExecutor.DiceWrapper(this.ValueDice.dice.WithType("Check"));
		this.DefaultDice = new ScriptExecutor.DiceWrapper(this.ValueDice.dice.WithType("Default"));
		this.TempVarsMap = new Dictionary<string, int>(RoleTable.Instance.VarsMap);
		this.ChangeUnit(FightType.Init);
		base.StopAllCoroutines();
		this.ActionQueue.Add(FightPlayer.Instance);
		foreach (Enemy enemy in this.enemyManager.enemyList)
		{
			this.ActionQueue.Add(this.statuses[enemy.InstanceId].fatherObject);
		}
		UIManager.Instance.GetUI<FightUI>("FightUI").StatusList = (from x in this.statuses.AsValueEnumerable<string, StatusManager>()
		select x.Value).ToList<FromDictionary<string, StatusManager>, KeyValuePair<string, StatusManager>, StatusManager>();
		this.ReadyToStart();
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0003772C File Offset: 0x0003592C
	protected static void InvokeUserCode_Init__String__Byte[]__Byte[]__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC Init called on server.");
			return;
		}
		((FightManager)obj).UserCode_Init__String__Byte[]__Byte[]__Single(reader.ReadString(), reader.ReadBytesAndSize(), reader.ReadBytesAndSize(), reader.ReadFloat());
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00037768 File Offset: 0x00035968
	protected void UserCode_CmdAddEnemy__String(string enemyId)
	{
		this.RpcAddEnemy(enemyId);
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00037773 File Offset: 0x00035973
	protected static void InvokeUserCode_CmdAddEnemy__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdAddEnemy called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdAddEnemy__String(reader.ReadString());
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x0003779C File Offset: 0x0003599C
	protected void UserCode_RpcAddEnemy__String(string enemyId)
	{
		bool flag = !PlayerManager.Instance.isServer;
		if (flag)
		{
			this.enemyManager.AddEnemy(enemyId);
		}
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x000377CA File Offset: 0x000359CA
	protected static void InvokeUserCode_RpcAddEnemy__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcAddEnemy called on server.");
			return;
		}
		((FightManager)obj).UserCode_RpcAddEnemy__String(reader.ReadString());
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x000377F4 File Offset: 0x000359F4
	protected void UserCode_SyncStatus__StatusDataTransfer(StatusDataTransfer statusData)
	{
		bool flag = !this.statuses.ContainsKey(statusData.InstanceId);
		if (!flag)
		{
			statusData.Populate(this.statuses[statusData.InstanceId]);
		}
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00037834 File Offset: 0x00035A34
	protected static void InvokeUserCode_SyncStatus__StatusDataTransfer(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC SyncStatus called on server.");
			return;
		}
		((FightManager)obj).UserCode_SyncStatus__StatusDataTransfer(Mirror.GeneratedNetworkCode._Read_StatusDataTransfer(reader));
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00037860 File Offset: 0x00035A60
	protected void UserCode_CmdChangeType__FightType(FightType type)
	{
		bool flag = this.fightType == FightType.Enemy;
		if (flag)
		{
			this.NetworkNowActionRole = this.roleQueue[0].InstanceId;
		}
		foreach (LobbyInfo.PlayerInfo player in GameServer.Instance.LobbyInfo.AddedPlayers)
		{
			bool flag2 = player.Id != player.Connection.identity.GetComponent<PlayerManager>().PlayerId;
			if (flag2)
			{
				Debug.LogError(player.Connection.identity.name + "的Id记录值与实际值不匹配");
			}
			this.TargetChangeUnit(player.Connection, type, this.NowActionRole);
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x0003793C File Offset: 0x00035B3C
	protected static void InvokeUserCode_CmdChangeType__FightType(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdChangeType called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdChangeType__FightType(Mirror.GeneratedNetworkCode._Read_FightType(reader));
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00037968 File Offset: 0x00035B68
	protected void UserCode_CmdPlayChange__String(string instanceId)
	{
		foreach (LobbyInfo.PlayerInfo item in GameServer.Instance.LobbyInfo.AddedPlayers)
		{
			this.TargetChangeUnit(item.Connection, FightType.Player, instanceId);
		}
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x000379D4 File Offset: 0x00035BD4
	protected static void InvokeUserCode_CmdPlayChange__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdPlayChange called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdPlayChange__String(reader.ReadString());
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00037A00 File Offset: 0x00035C00
	protected void UserCode_CmdAnnounceDone__String__Boolean(string instanceId, bool isDead)
	{
		bool flag = !isDead;
		if (flag)
		{
			this.announceCount++;
		}
		Dictionary<string, RoleTable> roleList = GameServer.Instance.RoleTables;
		int deadCount = 0;
		foreach (KeyValuePair<string, RoleTable> item in roleList)
		{
			bool flag2 = this.statuses.ContainsKey(item.Key) && this.statuses[item.Key].state == IStatusManager.State.Dead;
			if (flag2)
			{
				deadCount++;
			}
		}
		bool flag3 = this.announceCount >= NetworkServer.connections.Count - deadCount;
		if (flag3)
		{
			this.announceCount = 0;
			this.EndPlayerturn();
		}
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00037ADC File Offset: 0x00035CDC
	protected static void InvokeUserCode_CmdAnnounceDone__String__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdAnnounceDone called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdAnnounceDone__String__Boolean(reader.ReadString(), reader.ReadBool());
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00037B0B File Offset: 0x00035D0B
	protected void UserCode_EndPlayerturn()
	{
		FightPlayer.Instance.isEnd = true;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00037B19 File Offset: 0x00035D19
	protected static void InvokeUserCode_EndPlayerturn(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC EndPlayerturn called on server.");
			return;
		}
		((FightManager)obj).UserCode_EndPlayerturn();
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00037B3C File Offset: 0x00035D3C
	protected void UserCode_TargetChangeUnit__NetworkConnection__FightType__String(NetworkConnection conn, FightType newType, string nowAction)
	{
		this.NetworkNowActionRole = nowAction;
		this.ChangeUnit(newType);
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00037B4E File Offset: 0x00035D4E
	protected static void InvokeUserCode_TargetChangeUnit__NetworkConnection__FightType__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("TargetRPC TargetChangeUnit called on server.");
			return;
		}
		((FightManager)obj).UserCode_TargetChangeUnit__NetworkConnection__FightType__String(null, Mirror.GeneratedNetworkCode._Read_FightType(reader), reader.ReadString());
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00037B7E File Offset: 0x00035D7E
	protected void UserCode_TargetEnqueueEvent__NetworkConnection__ObjTargetBase(NetworkConnection target, ObjTargetBase objCommand)
	{
		objCommand.Validate();
		this.targetList.Enqueue(objCommand);
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00037B95 File Offset: 0x00035D95
	protected static void InvokeUserCode_TargetEnqueueEvent__NetworkConnection__ObjTargetBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("TargetRPC TargetEnqueueEvent called on server.");
			return;
		}
		((FightManager)obj).UserCode_TargetEnqueueEvent__NetworkConnection__ObjTargetBase(null, reader.Read());
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00037BBF File Offset: 0x00035DBF
	protected void UserCode_CmdEnqueueActionReliable__ActionCommandBase(ActionCommandBase actionCommand)
	{
		this.RpcSyncActionReliable(actionCommand);
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00037BCA File Offset: 0x00035DCA
	protected static void InvokeUserCode_CmdEnqueueActionReliable__ActionCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdEnqueueActionReliable called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdEnqueueActionReliable__ActionCommandBase(reader.Read());
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00037BF3 File Offset: 0x00035DF3
	protected void UserCode_CmdEnqueueActionUnreliable__ActionCommandBase(ActionCommandBase actionCommand)
	{
		this.RpcSyncActionUnreliable(actionCommand);
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00037BFE File Offset: 0x00035DFE
	protected static void InvokeUserCode_CmdEnqueueActionUnreliable__ActionCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdEnqueueActionUnreliable called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdEnqueueActionUnreliable__ActionCommandBase(reader.Read());
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00037C28 File Offset: 0x00035E28
	protected void UserCode_RpcSyncActionReliable__ActionCommandBase(ActionCommandBase actionCommand)
	{
		bool flag = actionCommand.From == PlayerManager.Instance.PlayerId;
		if (!flag)
		{
			actionCommand.Execute();
		}
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00037C58 File Offset: 0x00035E58
	protected static void InvokeUserCode_RpcSyncActionReliable__ActionCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcSyncActionReliable called on server.");
			return;
		}
		((FightManager)obj).UserCode_RpcSyncActionReliable__ActionCommandBase(reader.Read());
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00037C84 File Offset: 0x00035E84
	protected void UserCode_RpcSyncActionUnreliable__ActionCommandBase(ActionCommandBase actionCommand)
	{
		bool flag = actionCommand.From == PlayerManager.Instance.PlayerId;
		if (!flag)
		{
			actionCommand.Execute();
		}
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00037CB4 File Offset: 0x00035EB4
	protected static void InvokeUserCode_RpcSyncActionUnreliable__ActionCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcSyncActionUnreliable called on server.");
			return;
		}
		((FightManager)obj).UserCode_RpcSyncActionUnreliable__ActionCommandBase(reader.Read());
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00037CDD File Offset: 0x00035EDD
	protected void UserCode_CmdEnqueueEvent__ClientCommandBase(ClientCommandBase statusCommand)
	{
		statusCommand.Validate();
		this.eventList.Enqueue(statusCommand);
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00037CF4 File Offset: 0x00035EF4
	protected static void InvokeUserCode_CmdEnqueueEvent__ClientCommandBase(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdEnqueueEvent called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdEnqueueEvent__ClientCommandBase(reader.Read());
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00037D20 File Offset: 0x00035F20
	protected void UserCode_CmdCheckDead__NetworkConnectionToClient(NetworkConnectionToClient conn)
	{
		Debug.Log("进行了死亡检查");
		Dictionary<string, RoleTable> roleList = GameServer.Instance.RoleTables;
		int deadCount = 0;
		bool flag = this.fightType > FightType.None;
		if (flag)
		{
			foreach (KeyValuePair<string, RoleTable> item in roleList)
			{
				bool flag2 = this.statuses.ContainsKey(item.Key) && this.statuses[item.Key].state == IStatusManager.State.Dead;
				if (flag2)
				{
					deadCount++;
				}
			}
			Debug.Log("当前死亡人数：" + deadCount.ToString());
		}
		else
		{
			roleList[conn.identity.GetComponent<PlayerManager>().PlayerId].isDead = true;
			foreach (KeyValuePair<string, RoleTable> item2 in roleList)
			{
				bool isDead = item2.Value.isDead;
				if (isDead)
				{
					deadCount++;
				}
			}
			Debug.Log("下面死亡人数：" + deadCount.ToString());
		}
		bool flag3 = deadCount == GameEntryUI.playerCount;
		if (flag3)
		{
			GameExitUI.loss = true;
			PlayerManager.Instance.RpcGameOver();
		}
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00037E98 File Offset: 0x00036098
	protected static void InvokeUserCode_CmdCheckDead__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdCheckDead called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdCheckDead__NetworkConnectionToClient(senderConnection);
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00037EBC File Offset: 0x000360BC
	protected void UserCode_CmdChangeCareer__String__String(string CareerId, string playerIdentity)
	{
		this.RpcChangeCareer(CareerId, playerIdentity);
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00037EC8 File Offset: 0x000360C8
	protected static void InvokeUserCode_CmdChangeCareer__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdChangeCareer called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdChangeCareer__String__String(reader.ReadString(), reader.ReadString());
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00037EF8 File Offset: 0x000360F8
	protected void UserCode_RpcChangeCareer__String__String(string CareerId, string playerIdentity)
	{
		bool flag = FightManager.Instance == null || PlayerManager.Instance == null || this.fightType == FightType.None;
		if (!flag)
		{
			bool isPlayer = true;
			bool flag2 = playerIdentity.Contains("e");
			if (flag2)
			{
				isPlayer = false;
			}
			bool flag3 = isPlayer;
			if (flag3)
			{
				DataConfig tempData = new DataConfig(CareerId, DataType.Career);
				bool flag4 = playerIdentity == FightPlayer.Instance.InstanceId;
				if (!flag4)
				{
					bool flag5 = this.roleQueue.Exists((FightManager.RoleData x) => x.InstanceId == playerIdentity);
					if (flag5)
					{
						this.roleQueue.Find((FightManager.RoleData x) => x.InstanceId == playerIdentity).career = tempData;
					}
					foreach (KeyValuePair<string, StatusManager> item in FightManager.Instance.statuses)
					{
						bool flag6 = item.Key == playerIdentity;
						if (flag6)
						{
							bool flag7 = item.Value != null;
							if (flag7)
							{
								item.Value.ResetAnimator(false);
							}
						}
					}
				}
			}
			else
			{
				DataConfig tempData = new DataConfig(CareerId, DataType.Enemy);
				foreach (KeyValuePair<string, StatusManager> item2 in this.statuses)
				{
					bool flag8 = item2.Key == playerIdentity;
					if (flag8)
					{
						bool flag9 = item2.Value != null;
						if (flag9)
						{
							OtherObj otherObj = item2.Value.fatherObject as OtherObj;
							bool flag10 = otherObj != null;
							if (flag10)
							{
								otherObj.dataConfig = tempData;
							}
							item2.Value.ResetAnimator(false);
						}
					}
				}
			}
		}
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00038110 File Offset: 0x00036310
	protected static void InvokeUserCode_RpcChangeCareer__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcChangeCareer called on server.");
			return;
		}
		((FightManager)obj).UserCode_RpcChangeCareer__String__String(reader.ReadString(), reader.ReadString());
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x0003813F File Offset: 0x0003633F
	protected void UserCode_CmdActionChange__String__String(string instanceId, string index)
	{
		this.RpcActionChange(instanceId, index);
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0003814B File Offset: 0x0003634B
	protected static void InvokeUserCode_CmdActionChange__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkServer.active)
		{
			Debug.LogError("Command CmdActionChange called on client.");
			return;
		}
		((FightManager)obj).UserCode_CmdActionChange__String__String(reader.ReadString(), reader.ReadString());
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x0003817C File Offset: 0x0003637C
	protected void UserCode_RpcActionChange__String__String(string instanceId, string index)
	{
		StatusManager status = this.statuses.GetValueOrDefault(instanceId, null);
		bool flag = status == null;
		if (!flag)
		{
			OtherObj otherObj = status.fatherObject as OtherObj;
			bool flag2 = otherObj == null;
			if (!flag2)
			{
				otherObj.DesActionCard(int.Parse(index));
			}
		}
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x000381CD File Offset: 0x000363CD
	protected static void InvokeUserCode_RpcActionChange__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
	{
		if (!NetworkClient.active)
		{
			Debug.LogError("RPC RpcActionChange called on server.");
			return;
		}
		((FightManager)obj).UserCode_RpcActionChange__String__String(reader.ReadString(), reader.ReadString());
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x000381FC File Offset: 0x000363FC
	static FightManager()
	{
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::ResetWaitCount()", new RemoteCallDelegate(FightManager.InvokeUserCode_ResetWaitCount), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::ReadyToInit(System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_ReadyToInit__String), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::ReadyToStart()", new RemoteCallDelegate(FightManager.InvokeUserCode_ReadyToStart), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::ReSetFight(System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_ReSetFight__String), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdSendEvent(System.String,System.String,System.String,System.String,System.String[])", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdSendEvent__String__String__String__String__String[]), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdAddEnemy(System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdAddEnemy__String), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdChangeType(FightType)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdChangeType__FightType), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdPlayChange(System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdPlayChange__String), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdAnnounceDone(System.String,System.Boolean)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdAnnounceDone__String__Boolean), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdEnqueueActionReliable(Fight.ActionCommand.ActionCommandBase)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdEnqueueActionReliable__ActionCommandBase), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdEnqueueActionUnreliable(Fight.ActionCommand.ActionCommandBase)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdEnqueueActionUnreliable__ActionCommandBase), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdEnqueueEvent(Fight.StatusCommand.ClientCommandBase)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdEnqueueEvent__ClientCommandBase), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdCheckDead(Mirror.NetworkConnectionToClient)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdCheckDead__NetworkConnectionToClient), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdChangeCareer(System.String,System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdChangeCareer__String__String), false);
		RemoteProcedureCalls.RegisterCommand(typeof(FightManager), "System.Void FightManager::CmdActionChange(System.String,System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_CmdActionChange__String__String), false);
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::ClearFightui()", new RemoteCallDelegate(FightManager.InvokeUserCode_ClearFightui));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::Init(System.String,System.Byte[],System.Byte[],System.Single)", new RemoteCallDelegate(FightManager.InvokeUserCode_Init__String__Byte[]__Byte[]__Single));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::RpcAddEnemy(System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_RpcAddEnemy__String));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::SyncStatus(StatusDataTransfer)", new RemoteCallDelegate(FightManager.InvokeUserCode_SyncStatus__StatusDataTransfer));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::EndPlayerturn()", new RemoteCallDelegate(FightManager.InvokeUserCode_EndPlayerturn));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::RpcSyncActionReliable(Fight.ActionCommand.ActionCommandBase)", new RemoteCallDelegate(FightManager.InvokeUserCode_RpcSyncActionReliable__ActionCommandBase));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::RpcSyncActionUnreliable(Fight.ActionCommand.ActionCommandBase)", new RemoteCallDelegate(FightManager.InvokeUserCode_RpcSyncActionUnreliable__ActionCommandBase));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::RpcChangeCareer(System.String,System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_RpcChangeCareer__String__String));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::RpcActionChange(System.String,System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_RpcActionChange__String__String));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::TargetChangeUnit(Mirror.NetworkConnection,FightType,System.String)", new RemoteCallDelegate(FightManager.InvokeUserCode_TargetChangeUnit__NetworkConnection__FightType__String));
		RemoteProcedureCalls.RegisterRpc(typeof(FightManager), "System.Void FightManager::TargetEnqueueEvent(Mirror.NetworkConnection,Fight.ObjTarget.ObjTargetBase)", new RemoteCallDelegate(FightManager.InvokeUserCode_TargetEnqueueEvent__NetworkConnection__ObjTargetBase));
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00038558 File Offset: 0x00036758
	public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
	{
		base.SerializeSyncVars(writer, forceAll);
		if (forceAll)
		{
			writer.WriteString(this.NowActionRole);
			return;
		}
		writer.WriteVarULong(this.syncVarDirtyBits);
		if ((this.syncVarDirtyBits & 1UL) != 0UL)
		{
			writer.WriteString(this.NowActionRole);
		}
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x000385B0 File Offset: 0x000367B0
	public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
	{
		base.DeserializeSyncVars(reader, initialState);
		if (initialState)
		{
			base.GeneratedSyncVarDeserialize<string>(ref this.NowActionRole, null, reader.ReadString());
			return;
		}
		long num = (long)reader.ReadVarULong();
		if ((num & 1L) != 0L)
		{
			base.GeneratedSyncVarDeserialize<string>(ref this.NowActionRole, null, reader.ReadString());
		}
	}

	// Token: 0x04000A83 RID: 2691
	public static FightManager Instance;

	// Token: 0x04000A84 RID: 2692
	public bool IsFake = false;

	// Token: 0x04000A85 RID: 2693
	public FightType fightType = FightType.None;

	// Token: 0x04000A86 RID: 2694
	private FightUnit fightUnit;

	// Token: 0x04000A87 RID: 2695
	public string level;

	// Token: 0x04000A88 RID: 2696
	public ScriptExecutor.DiceWrapper ValueDice;

	// Token: 0x04000A89 RID: 2697
	public ScriptExecutor.DiceWrapper CheckDice;

	// Token: 0x04000A8A RID: 2698
	public ScriptExecutor.DiceWrapper DefaultDice;

	// Token: 0x04000A8B RID: 2699
	public List<FightManager.RoleData> roleQueue = new List<FightManager.RoleData>();

	// Token: 0x04000A8C RID: 2700
	public List<FightObject> ActionQueue = new List<FightObject>();

	// Token: 0x04000A8D RID: 2701
	public Dictionary<string, StatusManager> statuses = new Dictionary<string, StatusManager>();

	// Token: 0x04000A8E RID: 2702
	public readonly Dictionary<string, StatusDataTransfer> statusData = new Dictionary<string, StatusDataTransfer>();

	// Token: 0x04000A8F RID: 2703
	public Dictionary<string, int> TempVarsMap = new Dictionary<string, int>
	{
		{
			"Lucky",
			0
		},
		{
			"Wisdom",
			0
		},
		{
			"Perceive",
			0
		},
		{
			"Strength",
			0
		}
	};

	// Token: 0x04000A90 RID: 2704
	public Queue<ClientCommandBase> eventList = new Queue<ClientCommandBase>();

	// Token: 0x04000A91 RID: 2705
	public Queue<ObjTargetBase> targetList = new Queue<ObjTargetBase>();

	// Token: 0x04000A92 RID: 2706
	public EnemyManager enemyManager = new EnemyManager();

	// Token: 0x04000A93 RID: 2707
	public PatternManager patternManager = new PatternManager();

	// Token: 0x04000A94 RID: 2708
	public float SumOfEnemyPositive;

	// Token: 0x04000A95 RID: 2709
	[SyncVar]
	public string NowActionRole;

	// Token: 0x04000A96 RID: 2710
	public int waitCount = 0;

	// Token: 0x04000A97 RID: 2711
	private int readyCount = 0;

	// Token: 0x04000A98 RID: 2712
	public string wantLevel;

	// Token: 0x04000A99 RID: 2713
	public int ReSetCount = 0;

	// Token: 0x04000A9A RID: 2714
	public Dictionary<string, string> TempRoleList = new Dictionary<string, string>();

	// Token: 0x04000A9B RID: 2715
	public bool IsRet = false;

	// Token: 0x04000A9C RID: 2716
	private int announceCount = 0;

	// Token: 0x020000C0 RID: 192
	public class RoleData
	{
		// Token: 0x06000668 RID: 1640 RVA: 0x00002540 File Offset: 0x00000740
		public RoleData()
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0003860B File Offset: 0x0003680B
		public RoleData(string instanceId)
		{
			this.InstanceId = instanceId;
		}

		// Token: 0x04000A9D RID: 2717
		public string InstanceId;

		// Token: 0x04000A9E RID: 2718
		public int MaxHp;

		// Token: 0x04000A9F RID: 2719
		public int CurHp;

		// Token: 0x04000AA0 RID: 2720
		public int Defend;

		// Token: 0x04000AA1 RID: 2721
		public IStatusManager.State State;

		// Token: 0x04000AA2 RID: 2722
		public DataConfig career;
	}
}

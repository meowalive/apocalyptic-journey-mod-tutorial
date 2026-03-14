using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Mirror;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using Witch.Mod;

// Token: 0x0200009D RID: 157
public class EnemyManager : ISingleton<EnemyManager>, IModifiable, IRougamo<Modifiable>
{
	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000471 RID: 1137 RVA: 0x000253AC File Offset: 0x000235AC
	public static EnemyManager Instance
	{
		[DebuggerStepThrough]
		get
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(EnemyManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EnemyManager.get_Instance()).MethodHandle, typeof(EnemyManager).TypeHandle);
			methodContext.Arguments = new object[0];
			EnemyManager enemyManager;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					enemyManager = (EnemyManager)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							enemyManager = EnemyManager.$Rougamo_get_Instance();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							if (exceptionHandled)
							{
								enemyManager = (EnemyManager)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_100;
							}
							throw;
						}
						methodContext.ReturnValue = enemyManager;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						enemyManager = (EnemyManager)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_100:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return enemyManager;
		}
	}

	/// <summary>
	/// 加载敌人资源
	/// </summary>
	/// <param name="id"></param>
	// Token: 0x06000472 RID: 1138 RVA: 0x000254E4 File Offset: 0x000236E4
	public void LoadRes(string id)
	{
		this.InitLoad = true;
		this.LevelId = id;
		EnemyManager.enemyCount = 0;
		this.IndexCount = 0;
		this.enemyList = new List<Enemy>();
		EnemyManager.levelData = Singleton<GameConfigManager>.Instance.GetOne(DataType.Level, id);
		EnemyManager.SettlementMultiplier = 1;
		bool flag = EnemyManager.levelData["Note"].Contains("精英");
		if (flag)
		{
			EnemyManager.SettlementMultiplier = 2;
		}
		bool flag2 = EnemyManager.levelData["Note"].Contains("boss");
		if (flag2)
		{
			EnemyManager.SettlementMultiplier = 3;
		}
		bool flag3 = EnemyManager.levelData["Note"].Contains("无名");
		if (flag3)
		{
			EnemyManager.SettlementMultiplier = 4;
		}
		foreach (string enemyId in EnemyManager.levelData["EnemyIds"].Replace(" ", "").Split(',', StringSplitOptions.None))
		{
			this.AddEnemy(enemyId);
		}
		bool isServer = PlayerManager.Instance.isServer;
		if (isServer)
		{
			this.ResPat();
		}
		foreach (Enemy item in this.enemyList)
		{
			item.dataConfig.scriptExecutor.RunScript("InitScript");
		}
		this.InitLoad = false;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x0002566C File Offset: 0x0002386C
	[DebuggerStepThrough]
	public string AddEnemy(string id)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(EnemyManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EnemyManager.AddEnemy(string)).MethodHandle, typeof(EnemyManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			id
		};
		string text;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				text = (string)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						id = null;
					}
					else
					{
						id = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						text = this.$Rougamo_AddEnemy(id);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						if (exceptionHandled)
						{
							text = (string)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_13B;
						}
						throw;
					}
					methodContext.ReturnValue = text;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					text = (string)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_13B:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return text;
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x000257DC File Offset: 0x000239DC
	[DebuggerStepThrough]
	public void UpdatePos()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(EnemyManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EnemyManager.UpdatePos()).MethodHandle, typeof(EnemyManager).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						this.$Rougamo_UpdatePos();
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_C8;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_C8:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000258D8 File Offset: 0x00023AD8
	[Server]
	[DebuggerStepThrough]
	public void ResPat()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(EnemyManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EnemyManager.ResPat()).MethodHandle, typeof(EnemyManager).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						this.$Rougamo_ResPat();
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_C8;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_C8:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x000259FE File Offset: 0x00023BFE
	private static EnemyManager $Rougamo_get_Instance()
	{
		return FightManager.Instance.enemyManager;
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00025A0C File Offset: 0x00023C0C
	private string $Rougamo_AddEnemy(string id)
	{
		DataConfig enemyData = new DataConfig(id, DataType.Enemy);
		GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("Model/AncientDragonStatue")) as GameObject;
		Enemy enemy = obj.AddComponent<Enemy>();
		enemy.Init(enemyData, FightManager.Instance.SumOfEnemyPositive, this.IndexCount);
		this.enemyList.Add(enemy);
		this.IndexCount++;
		EnemyManager.enemyCount++;
		bool isServer = PlayerManager.Instance.isServer;
		if (isServer)
		{
			bool flag = !Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(RoleTable.Instance.Id);
			if (flag)
			{
				Singleton<TempDataManager>.Instance.RoleStatusMap.Add(RoleTable.Instance.Id, new List<string>());
			}
			Singleton<TempDataManager>.Instance.RoleStatusMap[RoleTable.Instance.Id].Add(enemy.Status.InstanceId);
		}
		this.UpdatePos();
		bool flag2 = !this.InitLoad;
		if (flag2)
		{
			enemy.dataConfig.scriptExecutor.RunScript("InitScript");
			FightManager.Instance.ActionQueue.Add(FightManager.Instance.statuses[enemy.InstanceId].fatherObject);
			bool isServer2 = PlayerManager.Instance.isServer;
			if (isServer2)
			{
				FightManager.Instance.CmdAddEnemy(id);
			}
		}
		return enemy.Status.InstanceId;
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00025B84 File Offset: 0x00023D84
	private void $Rougamo_UpdatePos()
	{
		float centerX = 4f;
		float deltaX = 2.5f;
		float y = GameApp.Instance.NowBackground.transform.Find("com").GetComponent<SceneInfo>().ground_y;
		for (int i = 0; i < EnemyManager.enemyCount; i++)
		{
			float x = centerX + ((float)(EnemyManager.enemyCount - 1 - i) - (float)(EnemyManager.enemyCount - 1) / 2f) * deltaX;
			this.enemyList[i].Status.SetPosition(new Vector3(x, y - this.enemyList[i].transform.Find("bottom").localPosition.y, 0f));
		}
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00025C43 File Offset: 0x00023E43
	private void $Rougamo_ResPat()
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void EnemyManager::ResPat()' called when server was not active");
			return;
		}
		GameServer.Instance.EnemyDone = true;
		GameServer.Instance.RoleRes();
	}

	// Token: 0x040009D8 RID: 2520
	public List<Enemy> enemyList = new List<Enemy>();

	// Token: 0x040009D9 RID: 2521
	public static int SettlementMultiplier = 1;

	// Token: 0x040009DA RID: 2522
	public string LevelId;

	// Token: 0x040009DB RID: 2523
	public static Dictionary<string, string> levelData;

	// Token: 0x040009DC RID: 2524
	public static int enemyCount;

	// Token: 0x040009DD RID: 2525
	public int IndexCount = 0;

	// Token: 0x040009DE RID: 2526
	private bool InitLoad = false;
}

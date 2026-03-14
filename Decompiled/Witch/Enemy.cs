using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Data.Save;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using Witch.UI.Window;

// Token: 0x0200009B RID: 155
public class Enemy : OtherObj
{
	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000461 RID: 1121 RVA: 0x000247B0 File Offset: 0x000229B0
	public override string Type
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
			methodContext.Target = this;
			methodContext.TargetType = typeof(Enemy);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Enemy.get_Type()).MethodHandle, typeof(Enemy).TypeHandle);
			methodContext.Arguments = new object[0];
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
					do
					{
						try
						{
							text = this.$Rougamo_get_Type();
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
								goto IL_108;
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
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return text;
		}
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x000248F0 File Offset: 0x00022AF0
	[DebuggerStepThrough]
	public override void Init(DataConfig dataConfig, float SumOfEnemyPositive, int index)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(Enemy);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Enemy.Init(DataConfig, float, int)).MethodHandle, typeof(Enemy).TypeHandle);
		methodContext.Arguments = new object[]
		{
			dataConfig,
			SumOfEnemyPositive,
			index
		};
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						dataConfig = null;
					}
					else
					{
						dataConfig = (DataConfig)arguments[0];
					}
					if (arguments[1] == null)
					{
						SumOfEnemyPositive = 0f;
					}
					else
					{
						SumOfEnemyPositive = (float)arguments[1];
					}
					if (arguments[2] == null)
					{
						index = 0;
					}
					else
					{
						index = (int)arguments[2];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_Init(dataConfig, SumOfEnemyPositive, index);
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
							goto IL_14D;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_14D:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00024A74 File Offset: 0x00022C74
	[DebuggerStepThrough]
	protected override void SetActionArrow(int index)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(Enemy);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Enemy.SetActionArrow(int)).MethodHandle, typeof(Enemy).TypeHandle);
		methodContext.Arguments = new object[]
		{
			index
		};
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						index = 0;
					}
					else
					{
						index = (int)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_SetActionArrow(index);
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
							goto IL_105;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_105:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00024BB0 File Offset: 0x00022DB0
	[DebuggerStepThrough]
	public override void AddCardList()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(Enemy);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Enemy.AddCardList()).MethodHandle, typeof(Enemy).TypeHandle);
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
						this.$Rougamo_AddCardList();
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

	// Token: 0x06000465 RID: 1125 RVA: 0x00024CAC File Offset: 0x00022EAC
	[DebuggerStepThrough]
	public override IEnumerator DoAction()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(Enemy);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Enemy.DoAction()).MethodHandle, typeof(Enemy).TypeHandle);
		methodContext.Arguments = new object[0];
		IEnumerator enumerator;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				enumerator = (IEnumerator)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						enumerator = this.$Rougamo_DoAction();
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
							enumerator = (IEnumerator)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_108;
						}
						throw;
					}
					methodContext.ReturnValue = enumerator;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					enumerator = (IEnumerator)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_108:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return enumerator;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00024DF8 File Offset: 0x00022FF8
	[DebuggerStepThrough]
	public override bool Weaved()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(Enemy);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Enemy.Weaved()).MethodHandle, typeof(Enemy).TypeHandle);
		methodContext.Arguments = new object[0];
		bool flag;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				flag = (bool)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						flag = this.$Rougamo_Weaved();
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
							flag = (bool)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_10D;
						}
						throw;
					}
					methodContext.ReturnValue = flag;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					flag = (bool)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_10D:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return flag;
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00024F3C File Offset: 0x0002313C
	private string $Rougamo_get_Type()
	{
		return "Enemy";
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00024F44 File Offset: 0x00023144
	private void $Rougamo_Init(DataConfig dataConfig, float SumOfEnemyPositive, int index)
	{
		base.Init(dataConfig, SumOfEnemyPositive, index);
		base.Attack = (int)((float)((int)((float)int.Parse(this.data["Attack"]) * (SumOfEnemyPositive * 0.4f + 0.6f))) * (1f + (float)GameSaveManager.GetValue<int>(GameVar.EXEnemyAtk) / 100f));
		base.Defend = (int)((float)int.Parse(this.data["Defend"]) * (SumOfEnemyPositive * 0.5f + 0.5f) * (float)Mathf.Max(GameEntryUI.playerCount, 1));
		base.MaxHp = (int)((float)int.Parse(this.data["Hp"]) * (SumOfEnemyPositive + 0.2f) * (float)Mathf.Max(GameEntryUI.playerCount, 1) * (1f + (float)GameSaveManager.GetValue<int>(GameVar.EXEnemyHp) / 100f));
		bool flag = base.MaxHp <= 10;
		if (flag)
		{
			base.MaxHp = 10;
		}
		base.InstanceId = "e";
		base.InstanceId += index.ToString();
		base.gameObject.name = this.Name + base.InstanceId;
		base.ActionCount = (base.MaxActionCount = int.Parse(this.data["ActionCount"]));
		base.CurHp = base.MaxHp;
		this.Status = base.transform.gameObject.AddComponent<StatusManager>().Init(this);
		FightManager instance = FightManager.Instance;
		if (instance != null)
		{
			instance.statuses.Add(base.InstanceId, this.Status as StatusManager);
		}
		bool flag2 = FightManager.Instance != null && FightManager.Instance.netIdentity != null && FightManager.Instance.isServer;
		if (flag2)
		{
			FightManager.Instance.statusData.Add(base.InstanceId, new StatusDataTransfer(this.Status as StatusManager));
		}
		dataConfig.scriptExecutor.Self = this.Status;
		dataConfig.scriptExecutor.SetStatus("Self");
		this.AddCardList();
		this.Status.UpdateStatus(true);
		bool flag3 = FightManager.Instance != null && FightManager.Instance.fightType != FightType.Init;
		if (flag3)
		{
			base.ActionCount = base.MaxActionCount;
			this.Status.ToughCount = this.Status.ToughOrigin;
			base.SetAction();
		}
		this.Status.animatedState = IStatusManager.AnimatedState.Idle;
		base.InitBound(null, true);
		bool flag4 = FightManager.Instance != null && FightManager.Instance.fightType != FightType.Init && FightManager.Instance.fightType > FightType.None;
		if (flag4)
		{
			FightManager.Instance.ActionQueue.Add(FightManager.Instance.statuses[base.InstanceId].fatherObject);
		}
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00025248 File Offset: 0x00023448
	private void $Rougamo_SetActionArrow(int index)
	{
		base.SetActionArrow(index);
		(this.Status as StatusManager).actionObj[index].transform.Find("LineUI").GetComponent<FightLine>().curvature = -(0.3f + (float)(this.ActionCards.Count - index - 1) * 0.1f);
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x000252A8 File Offset: 0x000234A8
	private void $Rougamo_AddCardList()
	{
		string[] cards = (from card in this.data["CardList"].Split(',', StringSplitOptions.None)
		select card.Replace(" ", "")).ToArray<string>();
		foreach (string card2 in cards)
		{
			bool flag = card2 != "" && card2 != " ";
			if (flag)
			{
				ObjectCard tmp = new ObjectCard();
				tmp.status = (this.Status as StatusManager);
				tmp.Init(new DataConfig(card2, DataType.EnemyCard));
				this.FightAction.AddCard(tmp);
			}
		}
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00025368 File Offset: 0x00023568
	private IEnumerator $Rougamo_DoAction()
	{
		FightManager.Instance.ChangeUnit(FightType.Enemy);
		return base.DoAction();
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00022CFE File Offset: 0x00020EFE
	private bool $Rougamo_Weaved()
	{
		return true;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

// Token: 0x020000A5 RID: 165
public class Partner : OtherObj
{
	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060004DA RID: 1242 RVA: 0x00029928 File Offset: 0x00027B28
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
			methodContext.TargetType = typeof(Partner);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Partner.get_Type()).MethodHandle, typeof(Partner).TypeHandle);
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

	// Token: 0x060004DB RID: 1243 RVA: 0x00029A68 File Offset: 0x00027C68
	[DebuggerStepThrough]
	public override void Init(DataConfig fromdata, float SumOfEnemyPositive, int index)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(Partner);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Partner.Init(DataConfig, float, int)).MethodHandle, typeof(Partner).TypeHandle);
		methodContext.Arguments = new object[]
		{
			fromdata,
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
						fromdata = null;
					}
					else
					{
						fromdata = (DataConfig)arguments[0];
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
						this.$Rougamo_Init(fromdata, SumOfEnemyPositive, index);
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

	// Token: 0x060004DC RID: 1244 RVA: 0x00029BEC File Offset: 0x00027DEC
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
		methodContext.TargetType = typeof(Partner);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Partner.DoAction()).MethodHandle, typeof(Partner).TypeHandle);
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

	// Token: 0x060004DD RID: 1245 RVA: 0x00029D2C File Offset: 0x00027F2C
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
		methodContext.TargetType = typeof(Partner);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Partner.AddCardList()).MethodHandle, typeof(Partner).TypeHandle);
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

	// Token: 0x060004DF RID: 1247 RVA: 0x00029E28 File Offset: 0x00028028
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
		methodContext.TargetType = typeof(Partner);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(Partner.Weaved()).MethodHandle, typeof(Partner).TypeHandle);
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

	// Token: 0x060004E0 RID: 1248 RVA: 0x00029F6C File Offset: 0x0002816C
	private string $Rougamo_get_Type()
	{
		return "Partner";
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00029F74 File Offset: 0x00028174
	private void $Rougamo_Init(DataConfig fromdata, float SumOfEnemyPositive, int index)
	{
		bool flag = fromdata == null;
		if (!flag)
		{
			base.Init(fromdata, SumOfEnemyPositive, index);
			base.Attack = (int)((float)int.Parse(this.data["Attack"]) * (SumOfEnemyPositive * 0.6f + 0.4f));
			base.Defend = (int)((double)int.Parse(this.data["Defend"]) * ((double)SumOfEnemyPositive * 0.7 + 0.30000001192092896));
			base.MaxHp = (int)((double)int.Parse(this.data["Hp"]) * ((double)SumOfEnemyPositive * 0.9 + 0.10000000149011612));
			bool flag2 = base.MaxHp <= 10;
			if (flag2)
			{
				base.MaxHp = 10;
			}
			base.ActionCount = (base.MaxActionCount = int.Parse(this.data["ActionCount"]));
			base.CurHp = base.MaxHp;
			base.InstanceId = "p";
			base.InstanceId += index.ToString();
			this.Status = (base.transform.gameObject.AddComponent<StatusManager>().Init(this) as StatusManager);
			base.gameObject.name = this.Name + base.InstanceId;
			FightManager.Instance.statuses.Add(base.InstanceId, this.Status as StatusManager);
			bool isServer = FightManager.Instance.isServer;
			if (isServer)
			{
				FightManager.Instance.statusData.Add(base.InstanceId, new StatusDataTransfer(this.Status as StatusManager));
			}
			this.dataConfig.scriptExecutor.Self = this.Status;
			this.dataConfig.scriptExecutor.SetStatus("Self");
			this.AddCardList();
			this.Status.UpdateStatus(true);
			this.Status.animatedState = IStatusManager.AnimatedState.Idle;
			base.InitBound(null, true);
			this.Status.SetPosition(new Vector3((float)(-6 - index), GameApp.Instance.NowBackground.transform.Find("com").GetComponent<SceneInfo>().ground_y - base.gameObject.transform.Find("bottom").localPosition.y, 0f));
			this.dataConfig.scriptExecutor.RunScript("InitScript");
		}
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x0002A208 File Offset: 0x00028408
	private IEnumerator $Rougamo_DoAction()
	{
		FightManager.Instance.ChangeUnit(FightType.Partner);
		return base.DoAction();
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0002A22C File Offset: 0x0002842C
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
				tmp.Init(new DataConfig(card2, DataType.PartnerCard));
				this.FightAction.AddCard(tmp);
			}
		}
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00022CFE File Offset: 0x00020EFE
	private bool $Rougamo_Weaved()
	{
		return true;
	}
}

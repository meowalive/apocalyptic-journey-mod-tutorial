using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

// Token: 0x02000099 RID: 153
public class OtherPlayer : FightObject
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000444 RID: 1092 RVA: 0x00023B90 File Offset: 0x00021D90
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
			methodContext.TargetType = typeof(OtherPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherPlayer.get_Type()).MethodHandle, typeof(OtherPlayer).TypeHandle);
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

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000445 RID: 1093 RVA: 0x00023CD0 File Offset: 0x00021ED0
	public override string Id
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
			methodContext.TargetType = typeof(OtherPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherPlayer.get_Id()).MethodHandle, typeof(OtherPlayer).TypeHandle);
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
							text = this.$Rougamo_get_Id();
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

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000446 RID: 1094 RVA: 0x00023E10 File Offset: 0x00022010
	public override string AnimationLocation
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
			methodContext.TargetType = typeof(OtherPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherPlayer.get_AnimationLocation()).MethodHandle, typeof(OtherPlayer).TypeHandle);
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
							text = this.$Rougamo_get_AnimationLocation();
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

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000447 RID: 1095 RVA: 0x00023F50 File Offset: 0x00022150
	public override string VocalLocation
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
			methodContext.TargetType = typeof(OtherPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherPlayer.get_VocalLocation()).MethodHandle, typeof(OtherPlayer).TypeHandle);
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
							text = this.$Rougamo_get_VocalLocation();
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

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000448 RID: 1096 RVA: 0x00024090 File Offset: 0x00022290
	public override string Name
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
			methodContext.TargetType = typeof(OtherPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherPlayer.get_Name()).MethodHandle, typeof(OtherPlayer).TypeHandle);
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
							text = this.$Rougamo_get_Name();
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

	// Token: 0x06000449 RID: 1097 RVA: 0x000241D0 File Offset: 0x000223D0
	[DebuggerStepThrough]
	public void Init(string Index)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherPlayer.Init(string)).MethodHandle, typeof(OtherPlayer).TypeHandle);
		methodContext.Arguments = new object[]
		{
			Index
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
						Index = null;
					}
					else
					{
						Index = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_Init(Index);
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
							goto IL_FD;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_FD:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00024304 File Offset: 0x00022504
	public override IEnumerator DoAction()
	{
		Debug.Log("OtherPlayer DoAction");
		this.isEnd = false;
		FightManager.Instance.ChangeUnit(FightType.OtherTurn);
		FightManager.Instance.CmdPlayChange(base.InstanceId);
		yield return UniTask.WaitUntil(() => this.isEnd, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ToCoroutine(null);
		yield break;
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00024314 File Offset: 0x00022514
	[DebuggerStepThrough]
	public override void EndRound()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherPlayer.EndRound()).MethodHandle, typeof(OtherPlayer).TypeHandle);
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
						this.$Rougamo_EndRound();
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

	// Token: 0x06000452 RID: 1106 RVA: 0x0002443C File Offset: 0x0002263C
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
		methodContext.TargetType = typeof(OtherPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherPlayer.Weaved()).MethodHandle, typeof(OtherPlayer).TypeHandle);
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

	// Token: 0x06000453 RID: 1107 RVA: 0x00024580 File Offset: 0x00022780
	private string $Rougamo_get_Type()
	{
		return "OtherPlayer";
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00024588 File Offset: 0x00022788
	private string $Rougamo_get_Id()
	{
		return FightManager.Instance.roleQueue.Exists((FightManager.RoleData x) => x.InstanceId == base.InstanceId) ? FightManager.Instance.roleQueue.Find((FightManager.RoleData x) => x.InstanceId == base.InstanceId).career.data["Id"] : RoleTable.Instance.Career.data["Id"];
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x000229BE File Offset: 0x00020BBE
	private string $Rougamo_get_AnimationLocation()
	{
		return Singleton<GameConfigManager>.Instance.GetOne(DataType.Career, this.Id).GetValueOrDefault("Animation", null);
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x000229DD File Offset: 0x00020BDD
	private string $Rougamo_get_VocalLocation()
	{
		return Singleton<GameConfigManager>.Instance.GetOne(DataType.Career, this.Id).GetValueOrDefault("Vocal", null);
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x000245FC File Offset: 0x000227FC
	private string $Rougamo_get_Name()
	{
		FightManager instance = FightManager.Instance;
		string text;
		if (instance == null)
		{
			text = null;
		}
		else
		{
			FightManager.RoleData roleData = instance.roleQueue.Find((FightManager.RoleData x) => x.InstanceId == base.InstanceId);
			if (roleData == null)
			{
				text = null;
			}
			else
			{
				DataConfig career = roleData.career;
				text = ((career != null) ? career.data.Localize("Name") : null);
			}
		}
		return text ?? "";
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00024658 File Offset: 0x00022858
	private void $Rougamo_Init(string Index)
	{
		base.InstanceId = Index;
		FightManager instance = FightManager.Instance;
		FightManager.RoleData roleData;
		if (instance == null)
		{
			roleData = null;
		}
		else
		{
			List<FightManager.RoleData> roleQueue = instance.roleQueue;
			roleData = ((roleQueue != null) ? roleQueue.Find((FightManager.RoleData x) => x.InstanceId == base.InstanceId) : null);
		}
		FightManager.RoleData role = roleData;
		bool flag = role == null;
		if (flag)
		{
			base.MaxHp = 100;
			base.CurHp = 100;
		}
		else
		{
			base.MaxHp = role.MaxHp;
			base.CurHp = role.CurHp;
		}
		this.Status = base.transform.gameObject.AddComponent<StatusManager>().Init(this);
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x000026D9 File Offset: 0x000008D9
	private void $Rougamo_EndRound()
	{
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00022CFE File Offset: 0x00020EFE
	private bool $Rougamo_Weaved()
	{
		return true;
	}

	// Token: 0x040009D2 RID: 2514
	public bool isEnd = false;
}

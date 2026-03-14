using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fight.ActionCommand;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using Witch.Mod;
using Witch.UI;
using Witch.UI.Window;
using ZLinq;

// Token: 0x02000082 RID: 130
public class EffectManager : Singleton<EffectManager>, IEffectManager, ISingleton<IEffectManager>, IModifiable, IRougamo<Modifiable>
{
	// Token: 0x060003CA RID: 970 RVA: 0x0001F990 File Offset: 0x0001DB90
	[DebuggerStepThrough]
	public void Init()
	{
		Modifiable modifiable = new Modifiable();
		Modifiable modifiable2 = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable,
			modifiable2
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(EffectManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EffectManager.Init()).MethodHandle, typeof(EffectManager).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			modifiable.OnEntry(methodContext);
			modifiable2.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						this.$Rougamo_Init();
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable2.OnException(methodContext);
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable2.OnExit(methodContext);
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_101;
						}
						throw;
					}
					modifiable2.OnSuccess(methodContext);
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
				IL_101:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	/// <summary>
	/// 播放特效
	/// </summary>
	/// <param name="scriptExecutor"></param>
	/// <param name="effectName"></param>
	// Token: 0x060003CB RID: 971 RVA: 0x0001FAC8 File Offset: 0x0001DCC8
	[DebuggerStepThrough]
	public void PlayEffect(IScriptExecutor scriptExecutor, string effectName)
	{
		Modifiable modifiable = new Modifiable();
		Modifiable modifiable2 = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable,
			modifiable2
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(EffectManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EffectManager.PlayEffect(IScriptExecutor, string)).MethodHandle, typeof(EffectManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			scriptExecutor,
			effectName
		};
		try
		{
			modifiable.OnEntry(methodContext);
			modifiable2.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						scriptExecutor = null;
					}
					else
					{
						scriptExecutor = (IScriptExecutor)arguments[0];
					}
					if (arguments[1] == null)
					{
						effectName = null;
					}
					else
					{
						effectName = (string)arguments[1];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_PlayEffect(scriptExecutor, effectName);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable2.OnException(methodContext);
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable2.OnExit(methodContext);
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_156;
						}
						throw;
					}
					modifiable2.OnSuccess(methodContext);
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
				IL_156:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060003CC RID: 972 RVA: 0x0001FC54 File Offset: 0x0001DE54
	[DebuggerStepThrough]
	public void PlayEffect(IStatusManager Self, string effectName)
	{
		Modifiable modifiable = new Modifiable();
		Modifiable modifiable2 = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable,
			modifiable2
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(EffectManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EffectManager.PlayEffect(IStatusManager, string)).MethodHandle, typeof(EffectManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			Self,
			effectName
		};
		try
		{
			modifiable.OnEntry(methodContext);
			modifiable2.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						Self = null;
					}
					else
					{
						Self = (IStatusManager)arguments[0];
					}
					if (arguments[1] == null)
					{
						effectName = null;
					}
					else
					{
						effectName = (string)arguments[1];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_PlayEffect(Self, effectName);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable2.OnException(methodContext);
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable2.OnExit(methodContext);
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_156;
						}
						throw;
					}
					modifiable2.OnSuccess(methodContext);
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
				IL_156:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	/// <summary>
	/// 由服务器执行效果
	/// </summary>
	/// <param name="Self">自己</param>
	/// <param name="Object">效果对象</param>
	/// <param name="effectName">特效名</param>
	// Token: 0x060003CD RID: 973 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
	public void InternalPlayEffect(IStatusManager Self, List<IStatusManager> Object, string effectName)
	{
		List<IStatusManager> objectCopy = new List<IStatusManager>(Object);
		string[] effects = effectName.Replace(" ", "").Split(',', StringSplitOptions.None);
		foreach (string effect in effects)
		{
			EffectBase vfx = this.EffectInfos.GetValueOrDefault(effect, null);
			bool flag = vfx == null;
			if (flag)
			{
				break;
			}
			bool flag2 = (vfx.target & EffectBase.Target.Self) != EffectBase.Target.None && !Self.IsNull();
			if (flag2)
			{
				vfx.Play(Self, (Self as StatusManager).initPos.x > 0f);
				bool flag3 = objectCopy.Contains(Self);
				if (flag3)
				{
					objectCopy.Remove(Self);
				}
			}
			bool flag4 = (vfx.target & EffectBase.Target.Target) != EffectBase.Target.None && objectCopy.Count > 0;
			if (flag4)
			{
				bool flag5;
				if (!(vfx is CardEffectInfo))
				{
					EnemyEffectInfo enemyEffectInfo = vfx as EnemyEffectInfo;
					flag5 = (enemyEffectInfo != null);
				}
				else
				{
					flag5 = true;
				}
				bool flag6 = flag5;
				if (flag6)
				{
					CardEffectInfo cardEffectInfo = vfx as CardEffectInfo;
					bool flag7;
					if (cardEffectInfo == null || cardEffectInfo.type != CardEffectInfo.Type.Area)
					{
						EnemyEffectInfo enemyEffectInfo2 = vfx as EnemyEffectInfo;
						flag7 = (enemyEffectInfo2 != null && enemyEffectInfo2.type == EnemyEffectInfo.Type.Area);
					}
					else
					{
						flag7 = true;
					}
					bool isArea = flag7;
					bool flag8 = !isArea;
					if (flag8)
					{
						foreach (IStatusManager target in objectCopy)
						{
							bool flag9 = target.IsNull();
							if (!flag9)
							{
								vfx.Play(target, (Self as StatusManager).initPos.x > 0f);
							}
						}
					}
					else
					{
						vfx.Play(objectCopy[objectCopy.Count / 2], (Self as StatusManager).initPos.x > 0f);
					}
				}
			}
		}
	}

	// Token: 0x060003CE RID: 974 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
	[DebuggerStepThrough]
	public void PlayActionEffect(IScriptExecutor scriptExecutor, string effectName, float delay)
	{
		Modifiable modifiable = new Modifiable();
		Modifiable modifiable2 = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable,
			modifiable2
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(EffectManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EffectManager.PlayActionEffect(IScriptExecutor, string, float)).MethodHandle, typeof(EffectManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			scriptExecutor,
			effectName,
			delay
		};
		try
		{
			modifiable.OnEntry(methodContext);
			modifiable2.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						scriptExecutor = null;
					}
					else
					{
						scriptExecutor = (IScriptExecutor)arguments[0];
					}
					if (arguments[1] == null)
					{
						effectName = null;
					}
					else
					{
						effectName = (string)arguments[1];
					}
					if (arguments[2] == null)
					{
						delay = 0f;
					}
					else
					{
						delay = (float)arguments[2];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_PlayActionEffect(scriptExecutor, effectName, delay);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable2.OnException(methodContext);
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable2.OnExit(methodContext);
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_180;
						}
						throw;
					}
					modifiable2.OnSuccess(methodContext);
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
				IL_180:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060003CF RID: 975 RVA: 0x000201A0 File Offset: 0x0001E3A0
	[DebuggerStepThrough]
	public void PlayScreenEffect(string effectName)
	{
		Modifiable modifiable = new Modifiable();
		Modifiable modifiable2 = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable,
			modifiable2
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(EffectManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(EffectManager.PlayScreenEffect(string)).MethodHandle, typeof(EffectManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			effectName
		};
		try
		{
			modifiable.OnEntry(methodContext);
			modifiable2.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						effectName = null;
					}
					else
					{
						effectName = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_PlayScreenEffect(effectName);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable2.OnException(methodContext);
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable2.OnExit(methodContext);
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_134;
						}
						throw;
					}
					modifiable2.OnSuccess(methodContext);
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable2.OnExit(methodContext);
				modifiable.OnExit(methodContext);
				IL_134:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x0002031C File Offset: 0x0001E51C
	private void $Rougamo_Init()
	{
		EffectBase[] effects = ResourceLoader.LoadAll<EffectBase>("Configs/Effects");
		foreach (EffectBase effect in effects)
		{
			this.EffectInfos.Add(effect.name, effect);
		}
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00020360 File Offset: 0x0001E560
	private void $Rougamo_PlayEffect(IScriptExecutor scriptExecutor, string effectName)
	{
		bool flag = FightManager.Instance == null;
		if (!flag)
		{
			FightManager instance = FightManager.Instance;
			Effect effect = new Effect();
			Effect.EffectData value = default(Effect.EffectData);
			value.effectName = effectName;
			value.Self = scriptExecutor.Self.InstanceId;
			value.Object = (from x in scriptExecutor.Object.AsValueEnumerable<IStatusManager>()
			select x.InstanceId).ToList<IStatusManager, string>();
			instance.EnqueueEvent(effect.Create(value));
			this.InternalPlayEffect(scriptExecutor.Self, scriptExecutor.Object, effectName);
		}
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x0002040C File Offset: 0x0001E60C
	private void $Rougamo_PlayEffect(IStatusManager Self, string effectName)
	{
		FightManager.Instance.EnqueueEvent(new Effect().Create(new Effect.EffectData
		{
			effectName = effectName,
			Self = Self.InstanceId,
			Object = new List<string>
			{
				Self.InstanceId
			}
		}));
		this.InternalPlayEffect(Self, new List<IStatusManager>(), effectName);
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00020474 File Offset: 0x0001E674
	private void $Rougamo_PlayActionEffect(IScriptExecutor scriptExecutor, string effectName, float delay)
	{
		bool flag = FightManager.Instance == null || effectName == null;
		if (!flag)
		{
			UniTask.WaitForSeconds(delay, false, PlayerLoopTiming.Update, UIManager.Instance.GetUI<FightUI>("FightUI").destroyCancellationToken, false).ContinueWith(delegate()
			{
				this.InternalPlayEffect(scriptExecutor.Self, scriptExecutor.Object, effectName);
			}).Forget();
		}
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x000204F4 File Offset: 0x0001E6F4
	private void $Rougamo_PlayScreenEffect(string effectName)
	{
		bool flag = FightManager.Instance == null || effectName == null || UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
		if (!flag)
		{
			bool flag2 = effectName == "TimeStop";
			if (flag2)
			{
				Time.timeScale = 0.1f;
				UniTask.Void(delegate()
				{
					EffectManager.<>c.<<PlayScreenEffect>b__6_0>d <<PlayScreenEffect>b__6_0>d = new EffectManager.<>c.<<PlayScreenEffect>b__6_0>d();
					<<PlayScreenEffect>b__6_0>d.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
					<<PlayScreenEffect>b__6_0>d.<>4__this = EffectManager.<>c.<>9;
					<<PlayScreenEffect>b__6_0>d.<>1__state = -1;
					<<PlayScreenEffect>b__6_0>d.<>t__builder.Start<EffectManager.<>c.<<PlayScreenEffect>b__6_0>d>(ref <<PlayScreenEffect>b__6_0>d);
					return <<PlayScreenEffect>b__6_0>d.<>t__builder.Task;
				});
			}
		}
	}

	// Token: 0x0400099E RID: 2462
	private Dictionary<string, EffectBase> EffectInfos = new Dictionary<string, EffectBase>();
}

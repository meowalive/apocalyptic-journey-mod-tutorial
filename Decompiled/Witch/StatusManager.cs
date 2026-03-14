using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Data.Save;
using DG.Tweening;
using Fight.ActionCommand;
using Fight.StatusCommand;
using MemoryPack;
using Newtonsoft.Json;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Witch.Core;
using Witch.Mod;
using Witch.UI;
using Witch.UI.Window;
using XLua;
using ZLinq;
using ZLinq.Linq;

/// <summary>
/// 状态管理器
/// </summary>
// Token: 0x020000AA RID: 170
[JsonConverter(typeof(StatusManagerConverter))]
[LuaCallCSharp(GenFlag.No)]
public class StatusManager : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IStatusManager, IModifiable, IRougamo<Modifiable>
{
	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000504 RID: 1284 RVA: 0x0002AEDC File Offset: 0x000290DC
	// (set) Token: 0x06000505 RID: 1285 RVA: 0x0002B020 File Offset: 0x00029220
	public IStatusManager.AnimatedState animatedState
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_animatedState()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			IStatusManager.AnimatedState animatedState;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					animatedState = (IStatusManager.AnimatedState)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							animatedState = this.$Rougamo_get_animatedState();
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
								animatedState = (IStatusManager.AnimatedState)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_10D;
							}
							throw;
						}
						methodContext.ReturnValue = animatedState;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						animatedState = (IStatusManager.AnimatedState)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return animatedState;
		}
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_animatedState(IStatusManager.AnimatedState)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = IStatusManager.AnimatedState.Idle;
						}
						else
						{
							value = (IStatusManager.AnimatedState)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_animatedState(value);
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
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000506 RID: 1286 RVA: 0x0002B15C File Offset: 0x0002935C
	// (set) Token: 0x06000507 RID: 1287 RVA: 0x0002B2A0 File Offset: 0x000294A0
	public IStatusManager.State state
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_state()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			IStatusManager.State state;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					state = (IStatusManager.State)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							state = this.$Rougamo_get_state();
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
								state = (IStatusManager.State)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_10D;
							}
							throw;
						}
						methodContext.ReturnValue = state;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						state = (IStatusManager.State)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return state;
		}
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_state(IStatusManager.State)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = IStatusManager.State.Default;
						}
						else
						{
							value = (IStatusManager.State)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_state(value);
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
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000508 RID: 1288 RVA: 0x0002B3DC File Offset: 0x000295DC
	public string Name
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_Name()).MethodHandle, typeof(StatusManager).TypeHandle);
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

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000509 RID: 1289 RVA: 0x0002B51C File Offset: 0x0002971C
	// (set) Token: 0x0600050A RID: 1290 RVA: 0x0002B65C File Offset: 0x0002985C
	public FightObject fatherObject
	{
		[CompilerGenerated]
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_fatherObject()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			FightObject fightObject;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					fightObject = (FightObject)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							fightObject = this.$Rougamo_get_fatherObject();
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
								fightObject = (FightObject)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = fightObject;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						fightObject = (FightObject)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return fightObject;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_fatherObject(FightObject)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = null;
						}
						else
						{
							value = (FightObject)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_fatherObject(value);
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
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x0600050B RID: 1291 RVA: 0x0002B790 File Offset: 0x00029990
	// (set) Token: 0x0600050C RID: 1292 RVA: 0x0002B8D0 File Offset: 0x00029AD0
	public GameObject[] actionObj
	{
		[CompilerGenerated]
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_actionObj()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			GameObject[] array;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					array = (GameObject[])methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							array = this.$Rougamo_get_actionObj();
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
								array = (GameObject[])methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = array;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						array = (GameObject[])methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return array;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_actionObj(GameObject[])).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = null;
						}
						else
						{
							value = (GameObject[])arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_actionObj(value);
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
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600050D RID: 1293 RVA: 0x0002BA04 File Offset: 0x00029C04
	// (set) Token: 0x0600050E RID: 1294 RVA: 0x0002BB44 File Offset: 0x00029D44
	public Dictionary<string, float> DamageFilter
	{
		[CompilerGenerated]
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_DamageFilter()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			Dictionary<string, float> dictionary;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					dictionary = (Dictionary<string, float>)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							dictionary = this.$Rougamo_get_DamageFilter();
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
								dictionary = (Dictionary<string, float>)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = dictionary;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						dictionary = (Dictionary<string, float>)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return dictionary;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_DamageFilter(Dictionary<string, float>)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = null;
						}
						else
						{
							value = (Dictionary<string, float>)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_DamageFilter(value);
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
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x0600050F RID: 1295 RVA: 0x0002BC78 File Offset: 0x00029E78
	// (set) Token: 0x06000510 RID: 1296 RVA: 0x0002BDB8 File Offset: 0x00029FB8
	public List<IDataConfig> effectList
	{
		[CompilerGenerated]
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_effectList()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			List<IDataConfig> list;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					list = (List<IDataConfig>)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							list = this.$Rougamo_get_effectList();
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
								list = (List<IDataConfig>)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = list;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						list = (List<IDataConfig>)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return list;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_effectList(List<IDataConfig>)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = null;
						}
						else
						{
							value = (List<IDataConfig>)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_effectList(value);
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
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000511 RID: 1297 RVA: 0x0002BEEC File Offset: 0x0002A0EC
	public string InstanceId
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_InstanceId()).MethodHandle, typeof(StatusManager).TypeHandle);
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
							text = this.$Rougamo_get_InstanceId();
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

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000512 RID: 1298 RVA: 0x0002C02C File Offset: 0x0002A22C
	public IScriptExecutor MirrorSc
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_MirrorSc()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			IScriptExecutor scriptExecutor;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					scriptExecutor = (IScriptExecutor)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							scriptExecutor = this.$Rougamo_get_MirrorSc();
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
								scriptExecutor = (IScriptExecutor)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = scriptExecutor;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						scriptExecutor = (IScriptExecutor)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return scriptExecutor;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000513 RID: 1299 RVA: 0x0002C16C File Offset: 0x0002A36C
	// (set) Token: 0x06000514 RID: 1300 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
	[MemoryPackIgnore]
	public int MaxHp
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_MaxHp()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			int num;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					num = (int)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							num = this.$Rougamo_get_MaxHp();
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
								num = (int)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_10D;
							}
							throw;
						}
						methodContext.ReturnValue = num;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						num = (int)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_MaxHp(int)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = 0;
						}
						else
						{
							value = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_MaxHp(value);
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
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000515 RID: 1301 RVA: 0x0002C3EC File Offset: 0x0002A5EC
	// (set) Token: 0x06000516 RID: 1302 RVA: 0x0002C530 File Offset: 0x0002A730
	public int ToughOrigin
	{
		[CompilerGenerated]
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_ToughOrigin()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			int num;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					num = (int)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							num = this.$Rougamo_get_ToughOrigin();
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
								num = (int)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_10D;
							}
							throw;
						}
						methodContext.ReturnValue = num;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						num = (int)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_ToughOrigin(int)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = 0;
						}
						else
						{
							value = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_ToughOrigin(value);
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
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000517 RID: 1303 RVA: 0x0002C66C File Offset: 0x0002A86C
	// (set) Token: 0x06000518 RID: 1304 RVA: 0x0002C7B0 File Offset: 0x0002A9B0
	[MemoryPackIgnore]
	public int ToughCount
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_ToughCount()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			int num;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					num = (int)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							num = this.$Rougamo_get_ToughCount();
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
								num = (int)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_10D;
							}
							throw;
						}
						methodContext.ReturnValue = num;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						num = (int)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_ToughCount(int)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = 0;
						}
						else
						{
							value = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_ToughCount(value);
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
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000519 RID: 1305 RVA: 0x0002C8EC File Offset: 0x0002AAEC
	// (set) Token: 0x0600051A RID: 1306 RVA: 0x0002CA30 File Offset: 0x0002AC30
	[MemoryPackIgnore]
	public int CurHp
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_CurHp()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			int num;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					num = (int)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							num = this.$Rougamo_get_CurHp();
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
								num = (int)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_10D;
							}
							throw;
						}
						methodContext.ReturnValue = num;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						num = (int)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_CurHp(int)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = 0;
						}
						else
						{
							value = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_CurHp(value);
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
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x0600051B RID: 1307 RVA: 0x0002CB6C File Offset: 0x0002AD6C
	// (set) Token: 0x0600051C RID: 1308 RVA: 0x0002CCB0 File Offset: 0x0002AEB0
	[MemoryPackIgnore]
	public int Defend
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_Defend()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			int num;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					num = (int)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							num = this.$Rougamo_get_Defend();
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
								num = (int)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_10D;
							}
							throw;
						}
						methodContext.ReturnValue = num;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						num = (int)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_Defend(int)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = 0;
						}
						else
						{
							value = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_Defend(value);
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
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x0600051D RID: 1309 RVA: 0x0002CDEC File Offset: 0x0002AFEC
	// (set) Token: 0x0600051E RID: 1310 RVA: 0x0002CF2C File Offset: 0x0002B12C
	[MemoryPackIgnore]
	public Dictionary<string, float> dynamicVariables
	{
		[CompilerGenerated]
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_dynamicVariables()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			Dictionary<string, float> dictionary;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					dictionary = (Dictionary<string, float>)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							dictionary = this.$Rougamo_get_dynamicVariables();
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
								dictionary = (Dictionary<string, float>)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = dictionary;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						dictionary = (Dictionary<string, float>)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return dictionary;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.set_dynamicVariables(Dictionary<string, float>)).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
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
							value = null;
						}
						else
						{
							value = (Dictionary<string, float>)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_set_dynamicVariables(value);
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
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x0600051F RID: 1311 RVA: 0x0002D060 File Offset: 0x0002B260
	public Dictionary<string, Dictionary<string, float>> dynamicVariablesLog
	{
		[CompilerGenerated]
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
			methodContext.TargetType = typeof(StatusManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.get_dynamicVariablesLog()).MethodHandle, typeof(StatusManager).TypeHandle);
			methodContext.Arguments = new object[0];
			Dictionary<string, Dictionary<string, float>> dictionary;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					dictionary = (Dictionary<string, Dictionary<string, float>>)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							dictionary = this.$Rougamo_get_dynamicVariablesLog();
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
								dictionary = (Dictionary<string, Dictionary<string, float>>)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = dictionary;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						dictionary = (Dictionary<string, Dictionary<string, float>>)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return dictionary;
		}
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
	public void SetSprite(Sprite sprite)
	{
		bool flag = this.IsNull();
		if (!flag)
		{
			bool flag2 = !this.hasDestroyed;
			if (flag2)
			{
				try
				{
					Transform body = base.transform.Find("body");
					bool flag3 = body == null;
					if (!flag3)
					{
						SpriteRenderer sr = body.GetComponent<SpriteRenderer>();
						bool flag4 = sr == null;
						if (!flag4)
						{
							sr.sprite = sprite;
						}
					}
				}
				catch (MissingReferenceException)
				{
				}
			}
		}
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0002D220 File Offset: 0x0002B420
	[DebuggerStepThrough]
	public void AddSummon(string path, string name)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.AddSummon(string, string)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			path,
			name
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
						path = null;
					}
					else
					{
						path = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						name = null;
					}
					else
					{
						name = (string)arguments[1];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_AddSummon(path, name);
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
							goto IL_11D;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_11D:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0002D374 File Offset: 0x0002B574
	[DebuggerStepThrough]
	public void RemoveSummon(string name)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.RemoveSummon(string)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			name
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
						name = null;
					}
					else
					{
						name = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_RemoveSummon(name);
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

	// Token: 0x06000523 RID: 1315 RVA: 0x0002D4A8 File Offset: 0x0002B6A8
	[DebuggerStepThrough]
	public void OnSelect()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.OnSelect()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_OnSelect();
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

	// Token: 0x06000524 RID: 1316 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
	[DebuggerStepThrough]
	public void OnUnSelect()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.OnUnSelect()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_OnUnSelect();
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

	// Token: 0x06000525 RID: 1317 RVA: 0x0002D6A0 File Offset: 0x0002B8A0
	[DebuggerStepThrough]
	private void OnEnable()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.OnEnable()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_OnEnable();
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

	// Token: 0x06000526 RID: 1318 RVA: 0x0002D79C File Offset: 0x0002B99C
	[DebuggerStepThrough]
	private void OnDisable()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.OnDisable()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_OnDisable();
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

	// Token: 0x06000527 RID: 1319 RVA: 0x0002D898 File Offset: 0x0002BA98
	[DebuggerStepThrough]
	public void ResetAnimator(bool replaceImmediate = true)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.ResetAnimator(bool)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			replaceImmediate
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
						replaceImmediate = default(bool);
					}
					else
					{
						replaceImmediate = (bool)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_ResetAnimator(replaceImmediate);
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

	// Token: 0x06000528 RID: 1320 RVA: 0x0002D9D4 File Offset: 0x0002BBD4
	public Sprite InitAnimator(bool replaceImmediate = true)
	{
		this.fatherObject.AnimatedStateSprites = new Dictionary<IStatusManager.AnimatedState, Sprite[]>();
		bool flag = this.fatherObject.AnimationLocation != null;
		if (flag)
		{
			foreach (object state in Enum.GetValues(typeof(IStatusManager.AnimatedState)))
			{
				Sprite[] sprites = ResourceLoader.LoadAll<Sprite>(Path.Combine(this.fatherObject.AnimationLocation, state.ToString()));
				bool flag2 = sprites == null || sprites.Length == 0;
				if (!flag2)
				{
					Array.Sort<Sprite>(sprites, (Sprite a, Sprite b) => new NaturalStringComparer().Compare(a.name, b.name));
					this.fatherObject.AnimatedStateSprites.Add((IStatusManager.AnimatedState)state, sprites);
				}
			}
			bool flag3 = this.fatherObject.AnimatedStateSprites.ContainsKey(IStatusManager.AnimatedState.Idle) && this.fatherObject.AnimatedStateSprites[IStatusManager.AnimatedState.Idle].AsValueEnumerable<Sprite>().Count<FromArray<Sprite>, Sprite>() > 0;
			if (flag3)
			{
				bool flag4 = replaceImmediate && base.transform.Find("body");
				if (flag4)
				{
					base.transform.Find("body").GetComponent<SpriteRenderer>().sprite = this.fatherObject.AnimatedStateSprites[IStatusManager.AnimatedState.Idle][0];
				}
				return this.fatherObject.AnimatedStateSprites[IStatusManager.AnimatedState.Idle][0];
			}
		}
		return null;
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0002DB74 File Offset: 0x0002BD74
	public void InitVocal()
	{
		this.fatherObject.VocalClipsCache = new Dictionary<IStatusManager.VocalState, AudioClip[]>();
		bool flag = string.IsNullOrEmpty(this.fatherObject.VocalLocation);
		if (!flag)
		{
			foreach (object state in Enum.GetValues(typeof(IStatusManager.VocalState)))
			{
				AudioClip[] clips = ResourceLoader.LoadAll<AudioClip>(Path.Combine(this.fatherObject.VocalLocation, state.ToString()));
				bool flag2 = clips == null || clips.Length == 0;
				if (!flag2)
				{
					Array.Sort<AudioClip>(clips, (AudioClip a, AudioClip b) => new NaturalStringComparer().Compare(a.name, b.name));
					this.fatherObject.VocalClipsCache.Add((IStatusManager.VocalState)state, clips);
				}
			}
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0002DC6C File Offset: 0x0002BE6C
	[DebuggerStepThrough]
	public void ResetVocal()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.ResetVocal()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_ResetVocal();
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

	// Token: 0x0600052B RID: 1323 RVA: 0x0002DD68 File Offset: 0x0002BF68
	[DebuggerStepThrough]
	public IStatusManager Init(FightObject father)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.Init(FightObject)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			father
		};
		IStatusManager statusManager;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				statusManager = (IStatusManager)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						father = null;
					}
					else
					{
						father = (FightObject)arguments[0];
					}
				}
				do
				{
					try
					{
						statusManager = this.$Rougamo_Init(father);
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
							statusManager = (IStatusManager)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_13B;
						}
						throw;
					}
					methodContext.ReturnValue = statusManager;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					statusManager = (IStatusManager)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_13B:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return statusManager;
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0002DED8 File Offset: 0x0002C0D8
	[DebuggerStepThrough]
	private void CreateActionContent()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.CreateActionContent()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_CreateActionContent();
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

	// Token: 0x0600052D RID: 1325 RVA: 0x0002DFD4 File Offset: 0x0002C1D4
	[DebuggerStepThrough]
	public void SetPosition(Vector3 pos)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.SetPosition(Vector3)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			pos
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
						pos = default(Vector3);
					}
					else
					{
						pos = (Vector3)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_SetPosition(pos);
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

	// Token: 0x0600052E RID: 1326 RVA: 0x0002E110 File Offset: 0x0002C310
	public void UpdateDisplay()
	{
		bool flag = this.fatherObject.IsNull("Object") || this.statusBarUI.IsNull("Object") || FightManager.Instance.IsNull("Object");
		if (!flag)
		{
			StringBuilder textBuilder = new StringBuilder();
			textBuilder.AppendLine(ZString.Format<object, object, object>("<color=red>{0}/{1}</color><color=blue>({2})</color>", this.CurHp, this.MaxHp, this.Defend));
			Enemy enemy = this.fatherObject as Enemy;
			bool flag2 = enemy != null;
			if (flag2)
			{
				textBuilder.AppendLine(ZString.Format<object, object>("{0} {1}", "Attack".Localize("FightUI"), enemy.Attack));
				textBuilder.AppendLine(ZString.Format<object, object>("{0} {1}", "Defend".Localize("FightUI"), enemy.Defend));
			}
			textBuilder.AppendLine();
			int nowi = 0;
			foreach (KeyValuePair<string, BuffItem> buff in this.buffBarUI.BuffDic)
			{
				nowi++;
				StringBuilder stringBuilder = textBuilder;
				BuffItem value = buff.Value;
				StringBuilder stringBuilder2 = stringBuilder.Append((value != null) ? value.buffConfig.BuffName : null).Append(" ");
				BuffItem value2 = buff.Value;
				stringBuilder2.Append((value2 != null) ? new int?(value2.buffConfig.Level) : null).Append("\t");
				bool flag3 = nowi % 4 == 0;
				if (flag3)
				{
					textBuilder.AppendLine();
				}
			}
			List<string> keywords = new List<string>();
			string highlightText = textBuilder.ToString().Highlight(keywords);
			this.keywordDisplay.SetText(this.Name, highlightText, keywords, null, null, "Status");
		}
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0002E30C File Offset: 0x0002C50C
	[DebuggerStepThrough]
	public void UpdateObjPos()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.UpdateObjPos()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_UpdateObjPos();
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

	/// <summary>
	/// 更新状态显示
	/// </summary>
	// Token: 0x06000530 RID: 1328 RVA: 0x0002E408 File Offset: 0x0002C608
	[DebuggerStepThrough]
	public void UpdateStatus(bool NeedEffect = true)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.UpdateStatus(bool)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			NeedEffect
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
						NeedEffect = default(bool);
					}
					else
					{
						NeedEffect = (bool)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_UpdateStatus(NeedEffect);
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

	/// <summary>
	/// 重置伤害计算的中间
	/// </summary>
	// Token: 0x06000531 RID: 1329 RVA: 0x0002E544 File Offset: 0x0002C744
	[DebuggerStepThrough]
	public void ResetDamageStatus()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.ResetDamageStatus()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_ResetDamageStatus();
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

	/// <summary>
	/// 受击判定
	/// </summary>
	/// <param name="val"></param>
	/// <param name="damageType">伤害类型</param>
	// Token: 0x06000532 RID: 1330 RVA: 0x0002E640 File Offset: 0x0002C840
	[DebuggerStepThrough]
	public void Hit(int val, string damageType, string fromDataId, string fromInstanceId)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.Hit(int, string, string, string)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val,
			damageType,
			fromDataId,
			fromInstanceId
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
						val = 0;
					}
					else
					{
						val = (int)arguments[0];
					}
					if (arguments[1] == null)
					{
						damageType = null;
					}
					else
					{
						damageType = (string)arguments[1];
					}
					if (arguments[2] == null)
					{
						fromDataId = null;
					}
					else
					{
						fromDataId = (string)arguments[2];
					}
					if (arguments[3] == null)
					{
						fromInstanceId = null;
					}
					else
					{
						fromInstanceId = (string)arguments[3];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_Hit(val, damageType, fromDataId, fromInstanceId);
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
							goto IL_16A;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_16A:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0002E7E0 File Offset: 0x0002C9E0
	[DebuggerStepThrough]
	public void Heal(int val, string damageType)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.Heal(int, string)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val,
			damageType
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
						val = 0;
					}
					else
					{
						val = (int)arguments[0];
					}
					if (arguments[1] == null)
					{
						damageType = null;
					}
					else
					{
						damageType = (string)arguments[1];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_Heal(val, damageType);
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
							goto IL_125;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_125:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0002E93C File Offset: 0x0002CB3C
	[DebuggerStepThrough]
	public void PlayVocal(IStatusManager.VocalState state)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.PlayVocal(IStatusManager.VocalState)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			state
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
						state = IStatusManager.VocalState.FightStart;
					}
					else
					{
						state = (IStatusManager.VocalState)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_PlayVocal(state);
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

	// Token: 0x06000535 RID: 1333 RVA: 0x0002EA78 File Offset: 0x0002CC78
	[DebuggerStepThrough]
	public void EnemyDead(float Delay = 0f)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.EnemyDead(float)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			Delay
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
						Delay = 0f;
					}
					else
					{
						Delay = (float)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_EnemyDead(Delay);
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

	// Token: 0x06000536 RID: 1334 RVA: 0x0002EBB4 File Offset: 0x0002CDB4
	public void UpdateEffectList()
	{
		bool flag = this.effectListObj == null;
		if (!flag)
		{
			this.effectListObj.SetActive(this.effectList.Count > 0);
			Transform content = this.effectListObj.transform.Find("ViewPort/List");
			GameObject itemPrefab = content.Find("Item").gameObject;
			foreach (object obj2 in content)
			{
				Transform obj = (Transform)obj2;
				bool flag2 = obj.name != "Item";
				if (flag2)
				{
					bool flag3 = Application.isEditor && !Application.isPlaying;
					if (flag3)
					{
						UnityEngine.Object.DestroyImmediate(obj.gameObject);
					}
					else
					{
						UnityEngine.Object.Destroy(obj.gameObject);
					}
				}
			}
			foreach (IDataConfig item in this.effectList)
			{
				GameObject effectItem = UnityEngine.Object.Instantiate<GameObject>(itemPrefab, content);
				effectItem.SetActive(true);
				List<string> keyWords = new List<string>();
				effectItem.GetComponent<KeywordDisplay>().SetText(item.data["Name"], item.Description().Highlight(keyWords), keyWords, null, null, "Status");
				effectItem.transform.Find("Icon").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/Item/Rarity" + item.data["Rarity"], true);
				effectItem.GetComponent<Image>().color = Singleton<TempDataManager>.Instance.rareColorMap[item.data["Rarity"]];
			}
		}
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
	[DebuggerStepThrough]
	public void UpdateTough()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.UpdateTough()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_UpdateTough();
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

	// Token: 0x06000538 RID: 1336 RVA: 0x0002EEAC File Offset: 0x0002D0AC
	[DebuggerStepThrough]
	public void ChangeState(IStatusManager.State state)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.ChangeState(IStatusManager.State)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			state
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
						state = IStatusManager.State.Default;
					}
					else
					{
						state = (IStatusManager.State)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_ChangeState(state);
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

	// Token: 0x06000539 RID: 1337 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
	private void OnDestroy()
	{
		this.hasDestroyed = true;
		Singleton<EventCenter>.Instance.Clear(this);
		bool flag = this.selfUI != null;
		if (flag)
		{
			UnityEngine.Object.Destroy(this.selfUI);
		}
		bool flag2 = this.statusBarObj != null;
		if (flag2)
		{
			UnityEngine.Object.Destroy(this.statusBarObj);
		}
		bool flag3 = this.actionContent != null;
		if (flag3)
		{
			UnityEngine.Object.Destroy(this.actionContent);
		}
		bool flag4 = this.effectListObj != null;
		if (flag4)
		{
			UnityEngine.Object.Destroy(this.effectListObj);
		}
		foreach (SummonObject item in this.Summon)
		{
			bool flag5 = item.gameObject != null;
			if (flag5)
			{
				UnityEngine.Object.Destroy(item.gameObject);
			}
		}
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
	public int DamageCalculate(int BaseDamage)
	{
		int result;
		try
		{
			bool flag = FightManager.Instance.IsNull("Object");
			if (flag)
			{
				result = BaseDamage;
			}
			else
			{
				bool flag2 = this.fatherObject is FightPlayer;
				float damage;
				if (flag2)
				{
					damage = ((float)BaseDamage * this.dynamicVariables.GetValueOrDefault("PercentDamage", 1f) + this.dynamicVariables.GetValueOrDefault("DefaultDamage", 0f)) * ((float)FightManager.Instance.TempVarsMap["Strength"] * 0.03f + 1f);
				}
				else
				{
					damage = (float)BaseDamage * this.dynamicVariables.GetValueOrDefault("PercentDamage", 1f) + this.dynamicVariables.GetValueOrDefault("DefaultDamage", 0f);
				}
				bool flag3 = Math.Ceiling((double)damage) - (double)damage <= 0.01;
				checked
				{
					if (flag3)
					{
						damage = (float)((int)Math.Ceiling((double)damage));
					}
					else
					{
						damage = (float)((int)Math.Floor((double)damage));
					}
					result = (int)damage;
				}
			}
		}
		catch (OverflowException e)
		{
			result = int.MaxValue;
		}
		return result;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0002F204 File Offset: 0x0002D404
	public int DefenceCalculate(int BaseDefence)
	{
		int result;
		try
		{
			float perceiveBonus = 1f;
			bool flag = FightManager.Instance.IsNull("Object");
			if (flag)
			{
				result = BaseDefence;
			}
			else
			{
				bool flag2 = FightManager.Instance.TempVarsMap != null;
				if (flag2)
				{
					perceiveBonus = (float)FightManager.Instance.TempVarsMap["Perceive"] * 0.04f + 1f;
				}
				float defence = (float)BaseDefence * this.dynamicVariables.GetValueOrDefault("DefendPercent", 1f) * perceiveBonus;
				bool flag3 = Math.Ceiling((double)defence) - (double)defence <= 0.01;
				checked
				{
					if (flag3)
					{
						defence = (float)((int)Math.Ceiling((double)defence));
					}
					else
					{
						defence = (float)((int)Math.Floor((double)defence));
					}
					result = defence.ToInt();
				}
			}
		}
		catch (OverflowException e)
		{
			result = int.MaxValue;
		}
		return result;
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0002F2EC File Offset: 0x0002D4EC
	public int UnDamageCalucate(int BaseDamage)
	{
		int result;
		try
		{
			int damage = checked((int)(unchecked(((float)BaseDamage + this.dynamicVariables.GetValueOrDefault("AttackedDefaultDamage", 0f)) * this.dynamicVariables.GetValueOrDefault("AttackedPercentDamage", 1f))));
			result = damage;
		}
		catch (OverflowException e)
		{
			result = int.MaxValue;
		}
		return result;
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0002F34C File Offset: 0x0002D54C
	[DebuggerStepThrough]
	public void Resurrection(int value = 100)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.Resurrection(int)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			value
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
						value = 0;
					}
					else
					{
						value = (int)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_Resurrection(value);
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

	// Token: 0x0600053E RID: 1342 RVA: 0x0002F488 File Offset: 0x0002D688
	[DebuggerStepThrough]
	public void CheckDead()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.CheckDead()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_CheckDead();
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

	// Token: 0x0600053F RID: 1343 RVA: 0x0002F584 File Offset: 0x0002D784
	[DebuggerStepThrough]
	public IStatusManager CheckAllBuff(string way)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.CheckAllBuff(string)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			way
		};
		IStatusManager statusManager;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				statusManager = (IStatusManager)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						way = null;
					}
					else
					{
						way = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						statusManager = this.$Rougamo_CheckAllBuff(way);
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
							statusManager = (IStatusManager)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_13B;
						}
						throw;
					}
					methodContext.ReturnValue = statusManager;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					statusManager = (IStatusManager)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_13B:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return statusManager;
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0002F6F4 File Offset: 0x0002D8F4
	[DebuggerStepThrough]
	public IStatusManager UpdateBuff()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.UpdateBuff()).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[0];
		IStatusManager statusManager;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				statusManager = (IStatusManager)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						statusManager = this.$Rougamo_UpdateBuff();
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
							statusManager = (IStatusManager)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_108;
						}
						throw;
					}
					methodContext.ReturnValue = statusManager;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					statusManager = (IStatusManager)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_108:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return statusManager;
	}

	/// <summary>
	/// 清空所有Buff
	/// </summary>
	// Token: 0x06000541 RID: 1345 RVA: 0x0002F834 File Offset: 0x0002DA34
	[DebuggerStepThrough]
	public IStatusManager ClearAllBuff()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.ClearAllBuff()).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[0];
		IStatusManager statusManager;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				statusManager = (IStatusManager)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						statusManager = this.$Rougamo_ClearAllBuff();
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
							statusManager = (IStatusManager)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_108;
						}
						throw;
					}
					methodContext.ReturnValue = statusManager;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					statusManager = (IStatusManager)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_108:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return statusManager;
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0002F974 File Offset: 0x0002DB74
	[DebuggerStepThrough]
	public IStatusManager RemoveBuff(string buffId)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.RemoveBuff(string)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			buffId
		};
		IStatusManager statusManager;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				statusManager = (IStatusManager)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						buffId = null;
					}
					else
					{
						buffId = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						statusManager = this.$Rougamo_RemoveBuff(buffId);
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
							statusManager = (IStatusManager)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_13B;
						}
						throw;
					}
					methodContext.ReturnValue = statusManager;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					statusManager = (IStatusManager)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_13B:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return statusManager;
	}

	/// <summary>
	/// Add方式更新buff，持续时间直接增加，等级直接增加（多用于毒，等可叠层buff）
	/// </summary>
	/// <param name="buffId"></param>
	/// <param name="duration"></param>
	/// <param name="level"></param>
	// Token: 0x06000543 RID: 1347 RVA: 0x0002FAE4 File Offset: 0x0002DCE4
	[DebuggerStepThrough]
	public IStatusManager AddBuff(string buffId, int level)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.AddBuff(string, int)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			buffId,
			level
		};
		IStatusManager statusManager;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				statusManager = (IStatusManager)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						buffId = null;
					}
					else
					{
						buffId = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						level = 0;
					}
					else
					{
						level = (int)arguments[1];
					}
				}
				do
				{
					try
					{
						statusManager = this.$Rougamo_AddBuff(buffId, level);
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
							statusManager = (IStatusManager)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_165;
						}
						throw;
					}
					methodContext.ReturnValue = statusManager;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					statusManager = (IStatusManager)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_165:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return statusManager;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0002FC98 File Offset: 0x0002DE98
	[DebuggerStepThrough]
	public IStatusManager AddBuff(IBuffItemConfig buffConfig)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.AddBuff(IBuffItemConfig)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			buffConfig
		};
		IStatusManager statusManager;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				statusManager = (IStatusManager)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						buffConfig = null;
					}
					else
					{
						buffConfig = (IBuffItemConfig)arguments[0];
					}
				}
				do
				{
					try
					{
						statusManager = this.$Rougamo_AddBuff(buffConfig);
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
							statusManager = (IStatusManager)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_13B;
						}
						throw;
					}
					methodContext.ReturnValue = statusManager;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					statusManager = (IStatusManager)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_13B:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return statusManager;
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0002FE08 File Offset: 0x0002E008
	[DebuggerStepThrough]
	public IBuffItem GetBuff(string buffId)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.GetBuff(string)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			buffId
		};
		IBuffItem buffItem;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				buffItem = (IBuffItem)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						buffId = null;
					}
					else
					{
						buffId = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						buffItem = this.$Rougamo_GetBuff(buffId);
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
							buffItem = (IBuffItem)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_13B;
						}
						throw;
					}
					methodContext.ReturnValue = buffItem;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					buffItem = (IBuffItem)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_13B:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return buffItem;
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0002FF78 File Offset: 0x0002E178
	[DebuggerStepThrough]
	public IBuffItem[] GetBuffs()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.GetBuffs()).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[0];
		IBuffItem[] array;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				array = (IBuffItem[])methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						array = this.$Rougamo_GetBuffs();
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
							array = (IBuffItem[])methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_108;
						}
						throw;
					}
					methodContext.ReturnValue = array;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					array = (IBuffItem[])methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_108:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return array;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x000300B8 File Offset: 0x0002E2B8
	[DebuggerStepThrough]
	private void Update()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.Update()).MethodHandle, typeof(StatusManager).TypeHandle);
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
						this.$Rougamo_Update();
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

	// Token: 0x06000548 RID: 1352 RVA: 0x000301B4 File Offset: 0x0002E3B4
	[DebuggerStepThrough]
	public void OnPointerEnter(PointerEventData eventData)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.OnPointerEnter(PointerEventData)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			eventData
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
						eventData = null;
					}
					else
					{
						eventData = (PointerEventData)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_OnPointerEnter(eventData);
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

	// Token: 0x06000549 RID: 1353 RVA: 0x000302E8 File Offset: 0x0002E4E8
	[DebuggerStepThrough]
	public void OnPointerExit(PointerEventData eventData)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.OnPointerExit(PointerEventData)).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			eventData
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
						eventData = null;
					}
					else
					{
						eventData = (PointerEventData)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_OnPointerExit(eventData);
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

	// Token: 0x0600054A RID: 1354 RVA: 0x0003041C File Offset: 0x0002E61C
	public StatusManager()
	{
		this.<actionObj>k__BackingField = new GameObject[4];
		this.<DamageFilter>k__BackingField = new Dictionary<string, float>();
		this.actionText = new KeywordDisplay[4];
		this.<effectList>k__BackingField = new List<IDataConfig>();
		this.<dynamicVariables>k__BackingField = new Dictionary<string, float>
		{
			{
				"DefaultDamage",
				0f
			},
			{
				"PercentDamage",
				1f
			},
			{
				"AttackedPercentDamage",
				1f
			},
			{
				"AttackedDefaultDamage",
				0f
			},
			{
				"CardCost",
				1f
			},
			{
				"DefendPercent",
				1f
			},
			{
				"RoundCard",
				4f
			},
			{
				"UseCount",
				1f
			},
			{
				"RetainCard",
				0f
			},
			{
				"MaxChangeHp",
				1f
			},
			{
				"thisHP",
				0f
			},
			{
				"liveCount",
				0f
			},
			{
				"HealMultiplier",
				1f
			},
			{
				"ConversionRate",
				0f
			}
		};
		this.<dynamicVariablesLog>k__BackingField = new Dictionary<string, Dictionary<string, float>>();
		this.hasDestroyed = false;
		this.hasDead = false;
		this.isResurrecting = false;
		base..ctor();
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00030598 File Offset: 0x0002E798
	[DebuggerStepThrough]
	Transform IStatusManager.get_transform()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(StatusManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(StatusManager.IStatusManager.get_transform()).MethodHandle, typeof(StatusManager).TypeHandle);
		methodContext.Arguments = new object[0];
		Transform transform;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				transform = (Transform)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						transform = this.$Rougamo_IStatusManager.get_transform();
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
							transform = (Transform)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_108;
						}
						throw;
					}
					methodContext.ReturnValue = transform;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					transform = (Transform)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_108:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return transform;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00030729 File Offset: 0x0002E929
	private IStatusManager.AnimatedState $Rougamo_get_animatedState()
	{
		return this._animatedState;
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00030734 File Offset: 0x0002E934
	private void $Rougamo_set_animatedState(IStatusManager.AnimatedState value)
	{
		bool flag = value == this._animatedState;
		if (!flag)
		{
			this._animatedState = value;
			bool flag2 = FightManager.Instance == null;
			if (!flag2)
			{
				this.fatherObject.OnAnimatedStateChange(this._animatedState);
			}
		}
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0003077D File Offset: 0x0002E97D
	private IStatusManager.State $Rougamo_get_state()
	{
		return this._state;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00030788 File Offset: 0x0002E988
	private void $Rougamo_set_state(IStatusManager.State value)
	{
		bool flag = this._state == value;
		if (!flag)
		{
			this._state = value;
			bool flag2 = this._state == IStatusManager.State.Dead;
			if (flag2)
			{
				this.PlayVocal(IStatusManager.VocalState.Dead);
				Singleton<EventCenter>.Instance.EventTrigger("Dead" + this.InstanceId);
				this.CheckDead();
			}
			bool flag3 = !this._NetEnqueue;
			if (flag3)
			{
				FightManager.Instance.EnqueueEvent(new State().Create(this.InstanceId, this._state));
			}
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00030815 File Offset: 0x0002EA15
	private string $Rougamo_get_Name()
	{
		return (!this.fatherObject.IsNull("Object")) ? this.fatherObject.Name : "";
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0003083B File Offset: 0x0002EA3B
	private FightObject $Rougamo_get_fatherObject()
	{
		return this.<fatherObject>k__BackingField;
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x00030843 File Offset: 0x0002EA43
	private void $Rougamo_set_fatherObject(FightObject value)
	{
		this.<fatherObject>k__BackingField = value;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0003084C File Offset: 0x0002EA4C
	private GameObject[] $Rougamo_get_actionObj()
	{
		return this.<actionObj>k__BackingField;
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00030854 File Offset: 0x0002EA54
	private void $Rougamo_set_actionObj(GameObject[] value)
	{
		this.<actionObj>k__BackingField = value;
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0003085D File Offset: 0x0002EA5D
	private Dictionary<string, float> $Rougamo_get_DamageFilter()
	{
		return this.<DamageFilter>k__BackingField;
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00030865 File Offset: 0x0002EA65
	private void $Rougamo_set_DamageFilter(Dictionary<string, float> value)
	{
		this.<DamageFilter>k__BackingField = value;
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0003086E File Offset: 0x0002EA6E
	private List<IDataConfig> $Rougamo_get_effectList()
	{
		return this.<effectList>k__BackingField;
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00030876 File Offset: 0x0002EA76
	private void $Rougamo_set_effectList(List<IDataConfig> value)
	{
		this.<effectList>k__BackingField = value;
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x0003087F File Offset: 0x0002EA7F
	private string $Rougamo_get_InstanceId()
	{
		return this.fatherObject.InstanceId;
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x0003088C File Offset: 0x0002EA8C
	private IScriptExecutor $Rougamo_get_MirrorSc()
	{
		return this.MiDataConfig.scriptExecutor;
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0003089C File Offset: 0x0002EA9C
	private int $Rougamo_get_MaxHp()
	{
		return this.maxHp;
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x000308B4 File Offset: 0x0002EAB4
	private void $Rougamo_set_MaxHp(int value)
	{
		bool flag = value == this.maxHp;
		if (!flag)
		{
			bool flag2 = value < this.CurHp;
			if (flag2)
			{
				this.CurHp = value;
			}
			int change = value - this.maxHp;
			this.maxHp = value;
			bool flag3 = this != null;
			if (flag3)
			{
				FightManager instance = FightManager.Instance;
				if (instance != null)
				{
					instance.EnqueueEvent(new MaxHp().Create(change, this.InstanceId));
				}
			}
			bool flag4 = change > 0;
			if (flag4)
			{
				this.CurHp += change;
			}
			bool flag5 = this.fatherObject is FightPlayer;
			if (flag5)
			{
				RoleTable.Instance.MaxSan = value;
			}
		}
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00030965 File Offset: 0x0002EB65
	private int $Rougamo_get_ToughOrigin()
	{
		return this.<ToughOrigin>k__BackingField;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x0003096D File Offset: 0x0002EB6D
	private void $Rougamo_set_ToughOrigin(int value)
	{
		this.<ToughOrigin>k__BackingField = value;
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00030976 File Offset: 0x0002EB76
	private int $Rougamo_get_ToughCount()
	{
		return this._toughCount;
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00030980 File Offset: 0x0002EB80
	private void $Rougamo_set_ToughCount(int value)
	{
		bool flag = value == this._toughCount;
		if (!flag)
		{
			bool flag2 = value < 0;
			if (flag2)
			{
				value = 0;
			}
			bool flag3 = value > this.ToughOrigin;
			if (flag3)
			{
				value = this.ToughOrigin;
			}
			int change = value - this._toughCount;
			this._toughCount = value;
			bool flag4 = this != null;
			if (flag4)
			{
				FightManager instance = FightManager.Instance;
				if (instance != null)
				{
					instance.EnqueueEvent(new ToughCount().Create(change, this.InstanceId));
				}
			}
			this.UpdateTough();
		}
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00030A07 File Offset: 0x0002EC07
	private int $Rougamo_get_CurHp()
	{
		return this.curHp;
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00030A10 File Offset: 0x0002EC10
	private void $Rougamo_set_CurHp(int value)
	{
		bool flag = value == this.curHp;
		if (!flag)
		{
			bool flag2 = value > this.maxHp;
			if (flag2)
			{
				bool flag3 = this.dynamicVariables["ConversionRate"] > 0f;
				if (flag3)
				{
					this.Defend += this.DefenceCalculate((int)((float)(value - this.maxHp) * this.dynamicVariables["ConversionRate"]));
				}
				value = this.maxHp;
			}
			int change = value - this.curHp;
			this.curHp = value;
			change = Math.Max(change, -this.MaxHp);
			bool flag4 = this.fatherObject is FightPlayer && this.MaxHp > 0;
			if (flag4)
			{
				RoleTable.Instance.San = value;
			}
			bool flag5 = this.fatherObject is FightPlayer && change < 0 && (float)this.curHp < (float)this.MaxHp * 0.2f && (float)(this.curHp - change) >= (float)this.MaxHp * 0.2f;
			if (flag5)
			{
				this.PlayVocal(IStatusManager.VocalState.Dying);
			}
			bool flag6 = this.buffBarUI != null;
			if (flag6)
			{
				FightManager instance = FightManager.Instance;
				if (instance != null)
				{
					instance.EnqueueEvent(new CurHp().Create(change, this.InstanceId));
				}
			}
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00030B67 File Offset: 0x0002ED67
	private int $Rougamo_get_Defend()
	{
		return this.defend;
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00030B70 File Offset: 0x0002ED70
	private void $Rougamo_set_Defend(int value)
	{
		bool flag = value < 0;
		if (flag)
		{
			this.CurHp += value;
			value = 0;
		}
		bool flag2 = value == this.defend;
		if (!flag2)
		{
			int change = value - this.defend;
			this.defend = value;
			bool flag3 = this.buffBarUI != null;
			if (flag3)
			{
				FightManager instance = FightManager.Instance;
				if (instance != null)
				{
					instance.EnqueueEvent(new Defend().Create(change, this.InstanceId));
				}
			}
			else
			{
				Debug.Log("buffBarUI为空");
			}
		}
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00030BFC File Offset: 0x0002EDFC
	private Dictionary<string, float> $Rougamo_get_dynamicVariables()
	{
		return this.<dynamicVariables>k__BackingField;
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00030C04 File Offset: 0x0002EE04
	private void $Rougamo_set_dynamicVariables(Dictionary<string, float> value)
	{
		this.<dynamicVariables>k__BackingField = value;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00030C0D File Offset: 0x0002EE0D
	private Dictionary<string, Dictionary<string, float>> $Rougamo_get_dynamicVariablesLog()
	{
		return this.<dynamicVariablesLog>k__BackingField;
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00030C18 File Offset: 0x0002EE18
	private void $Rougamo_AddSummon(string path, string name)
	{
		SummonObject summon = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load<GameObject>("Model/Summon", true)).AddComponent<SummonObject>();
		StatusManager status = summon.gameObject.AddComponent<StatusManager>();
		status.fatherObject = summon;
		summon.transform.SetParent(base.transform);
		summon.transform.localPosition = Vector3.zero;
		summon.Init(path, name);
		this.Summon.Add(summon);
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00030C8C File Offset: 0x0002EE8C
	private void $Rougamo_RemoveSummon(string name)
	{
		SummonObject summon = this.Summon.FirstOrDefault((SummonObject x) => x.Name == name);
		bool flag = summon == null;
		if (!flag)
		{
			this.Summon.Remove(summon);
			UnityEngine.Object.Destroy(summon.gameObject);
		}
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00030CE5 File Offset: 0x0002EEE5
	private void $Rougamo_OnSelect()
	{
		this.SelectIcon.GetComponent<SpriteRenderer>().DOFade(0.5f, 0.5f);
		this.statusBarUI.OnSelected();
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00030D10 File Offset: 0x0002EF10
	private void $Rougamo_OnUnSelect()
	{
		GameObject selectIcon = this.SelectIcon;
		SpriteRenderer sr = (selectIcon != null) ? selectIcon.GetComponent<SpriteRenderer>() : null;
		bool flag = sr != null;
		if (flag)
		{
			sr.DOFade(0f, 0.5f);
		}
		StatusBarUI statusBarUI = this.statusBarUI;
		if (statusBarUI != null)
		{
			statusBarUI.OnUnSelected();
		}
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00030D60 File Offset: 0x0002EF60
	private void $Rougamo_OnEnable()
	{
		this.UpdateObjPos();
		bool flag = this.selfUI != null;
		if (flag)
		{
			this.selfUI.SetActive(true);
		}
		bool flag2 = this.statusBarObj != null;
		if (flag2)
		{
			this.statusBarObj.SetActive(true);
		}
		bool flag3 = this.effectList.Count > 0;
		if (flag3)
		{
			bool flag4 = this.effectListObj != null;
			if (flag4)
			{
				this.effectListObj.SetActive(true);
			}
		}
		bool flag5 = this.actionContent != null;
		if (flag5)
		{
			this.actionContent.SetActive(true);
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00030E08 File Offset: 0x0002F008
	private void $Rougamo_OnDisable()
	{
		bool flag = this.selfUI != null;
		if (flag)
		{
			this.selfUI.SetActive(false);
		}
		bool flag2 = this.statusBarObj != null;
		if (flag2)
		{
			this.statusBarObj.SetActive(false);
		}
		bool flag3 = this.effectListObj != null;
		if (flag3)
		{
			this.effectListObj.SetActive(false);
		}
		bool flag4 = this.actionContent != null;
		if (flag4)
		{
			this.actionContent.SetActive(false);
		}
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00030E94 File Offset: 0x0002F094
	private void $Rougamo_ResetAnimator([Optional] bool replaceImmediate)
	{
		float x = base.transform.position.x;
		Sprite sprite = this.InitAnimator(replaceImmediate);
		this.ResetVocal();
		this.fatherObject.InitBound(sprite, replaceImmediate);
		UniTask.DelayFrame(1, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			bool flag = this.IsNull();
			if (!flag)
			{
				this.transform.GetComponent<StatusManager>().SetPosition(new Vector3(x, GameApp.Instance.NowBackground.transform.Find("com").GetComponent<SceneInfo>().ground_y - this.transform.Find("bottom").localPosition.y, 0f));
			}
		}).Forget();
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00030F0A File Offset: 0x0002F10A
	private void $Rougamo_ResetVocal()
	{
		this.InitVocal();
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00030F14 File Offset: 0x0002F114
	private IStatusManager $Rougamo_Init(FightObject father)
	{
		this.fatherObject = father;
		this.InitAnimator(true);
		this.InitVocal();
		this.SelectIcon = (UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/SelectedIcon"), base.transform) as GameObject);
		this.keywordDisplay = base.gameObject.AddComponent<KeywordDisplay>();
		this.ResetDamageStatus();
		this.MiDataConfig = new DataConfig();
		this.MiDataConfig.Vars.TryAdd("Online", this.InstanceId);
		this.MiDataConfig.scriptExecutor.Self = this;
		this.MiDataConfig.scriptExecutor.Target = this;
		this.MiDataConfig.scriptExecutor.SetStatus("Self");
		this.maxHp = this.fatherObject.MaxHp;
		this.curHp = this.fatherObject.CurHp;
		this.statusBarObj = UIManager.Instance.CreateStatusBarItem();
		this.statusBarObj.transform.SetParent(UIManager.Instance.GetUI<FightUI>("FightUI").transform);
		this.statusBarObj.AddComponent<StatusBarUI>().Init(this);
		this.statusBarObj.transform.SetAsFirstSibling();
		this.statusBarUI = this.statusBarObj.GetComponent<StatusBarUI>();
		this.statusBarUI.OnUnSelected();
		this.statusBarObj.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(base.transform.Find("bottom").position));
		this.effectListObj = UIManager.Instance.CreateEffectList();
		this.effectListObj.transform.SetParent(UIManager.Instance.GetUI<FightUI>("FightUI").transform);
		this.effectListObj.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(base.transform.Find("head").position));
		this.effectListObj.SetActive(false);
		this.effectListObj.transform.localScale = new Vector3(1f, 1f, 1f);
		this.CreateActionContent();
		this.buffBarUI = this.statusBarUI.buffBarObj.GetComponent<BuffBarUI>();
		this.UpdateStatus(false);
		base.gameObject.AddComponent<DialogueBoxIdentity>().SetInstanceId(this.InstanceId);
		return this;
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x000311B0 File Offset: 0x0002F3B0
	private void $Rougamo_CreateActionContent()
	{
		this.actionContent = UIManager.Instance.CreateActionContent();
		this.actionContent.transform.SetParent(UIManager.Instance.GetUI<FightUI>("FightUI").transform);
		this.actionContent.transform.localScale = new Vector3(1f, 1f, 1f);
		this.actionContent.transform.Find("content").GetComponent<AnimatedHorizontalLayout>().spacing = 0f;
		this.actionContent.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(base.transform.Find("head").position));
		this.selfUI = new GameObject(base.gameObject.name);
		this.selfUI.transform.SetParent(UIManager.Instance.GetUI<FightUI>("FightUI").transform);
		this.selfUI.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(base.transform.Find("body").position));
		bool flag = this.fatherObject is FightPlayer;
		if (flag)
		{
			FightPlayer.Instance.diceIconList = this.actionContent.transform.Find("content");
			GameObject diceIcon = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/DiceIcon"), FightPlayer.Instance.diceIconList) as GameObject;
			diceIcon.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			diceIcon.SetActive(false);
			diceIcon.name = "DiceIconPrefab";
		}
		else
		{
			bool flag2 = this.fatherObject is Enemy || this.fatherObject is Partner;
			if (flag2)
			{
				for (int i = 0; i < 4; i++)
				{
					this.actionObj[i] = UIManager.Instance.CreateActionIcon();
					this.actionObj[i].transform.SetParent(this.actionContent.transform.Find("content"));
					bool flag3 = Application.isEditor && !Application.isPlaying;
					if (!flag3)
					{
						this.actionObj[i].transform.Find("Icon").GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						this.actionText[i] = this.actionObj[i].AddComponent<KeywordDisplay>();
						this.actionText[i].type = "Action";
						this.actionObj[i].SetActive(false);
						this.actionObj[i].transform.localPosition = new Vector3(0f, 0f, 0f);
					}
				}
				Enemy enemy = this.fatherObject as Enemy;
				bool flag4 = enemy != null;
				if (flag4)
				{
					this.ToughOrigin = int.Parse(enemy.data["Tough"]) + GameSaveManager.GetValue<int>(GameVar.ExTough);
					this.ToughCount = this.ToughOrigin;
				}
			}
		}
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00031524 File Offset: 0x0002F724
	private void $Rougamo_SetPosition(Vector3 pos)
	{
		base.transform.position = pos;
		this.initPos = pos;
		Singleton<EventCenter>.Instance.RemoveEventListener("OnCameraMove", this);
		this.UpdateObjPos();
		Singleton<EventCenter>.Instance.AddEventListener("OnCameraMove", new Action(this.UpdateObjPos), this, EventDispose.None);
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x0003157C File Offset: 0x0002F77C
	private void $Rougamo_UpdateObjPos()
	{
		bool flag = this.statusBarObj != null;
		if (flag)
		{
			this.statusBarObj.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(base.transform.Find("bottom").position));
		}
		bool flag2 = this.selfUI != null;
		if (flag2)
		{
			this.selfUI.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(base.transform.Find("body").position));
		}
		bool flag3 = this.actionContent != null;
		if (flag3)
		{
			Vector3 tempPos = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(base.transform.Find("head").position));
			bool flag4 = tempPos.y > 400f;
			if (flag4)
			{
				tempPos = new Vector3(tempPos.x, 400f, tempPos.z);
			}
			this.actionContent.transform.localPosition = tempPos;
		}
		bool flag5 = this.effectListObj != null;
		if (flag5)
		{
			this.effectListObj.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(base.transform.Find("head").position));
		}
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0003173C File Offset: 0x0002F93C
	private void $Rougamo_UpdateStatus([Optional] bool NeedEffect)
	{
		bool flag = this.statusBarUI != null;
		if (flag)
		{
			this.statusBarUI.UpdateHealthBar(this.Defend, Math.Max(this.CurHp, 0), this.MaxHp, NeedEffect);
			this.UpdateDisplay();
			this.UpdateTough();
			bool flag2 = this.fatherObject is FightPlayer;
			if (flag2)
			{
				bool flag3 = GameEntryUI.playerCount > 1;
				if (flag3)
				{
					PlayerManager.Instance.CmdSendRoleTable(this.Defend.ToString(), this.InstanceId, "Defend");
				}
				else
				{
					TopBarUI ui = UIManager.Instance.GetUI<TopBarUI>("TopBarUI");
					if (ui != null)
					{
						ui.UpdateDefend(this.Defend.ToString());
					}
				}
			}
		}
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00031808 File Offset: 0x0002FA08
	private void $Rougamo_ResetDamageStatus()
	{
		this.dynamicVariables["DefaultDamage"] = 0f;
		this.dynamicVariables["PercentDamage"] = 1f;
		this.dynamicVariables["AttackedPercentDamage"] = 1f;
		this.dynamicVariables["AttackedDefaultDamage"] = 0f;
		this.dynamicVariables["CardCost"] = 1f;
		this.dynamicVariables["DefendPercent"] = 1f;
		this.dynamicVariables["UseCount"] = 1f;
		this.dynamicVariables["RetainCard"] = 0f;
		this.dynamicVariables["MaxChangeHp"] = 1f;
		this.dynamicVariables["thisHP"] = 0f;
		this.dynamicVariables["liveCount"] = 0f;
		this.dynamicVariables["HealMultiplier"] = 1f;
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00031920 File Offset: 0x0002FB20
	private void $Rougamo_Hit(int val, string damageType, string fromDataId, string fromInstanceId)
	{
		bool flag = this.state == IStatusManager.State.Dead;
		if (!flag)
		{
			bool flag2 = this.IsNull() || this.statusBarObj == null;
			if (!flag2)
			{
				int originalVal = val;
				Vector3 pos = this.statusBarObj.transform.localPosition;
				bool flag3 = this.DamageFilter.ContainsKey(fromDataId);
				if (flag3)
				{
					originalVal = (int)((float)originalVal * (100f - this.DamageFilter[fromDataId]) / 100f);
				}
				bool flag4 = originalVal <= 0 || FightManager.Instance.fightType == FightType.None;
				if (flag4)
				{
					UIManager.Instance.ShowPopUpText("NormalMsgText", "免疫", pos).Forget<PopUpTextUI>();
				}
				else
				{
					CustomDamageType customDamageType = ResourceLoader.Load<CustomDamageType>("Configs/DamageType/" + damageType, true);
					int hit = (damageType == "True") ? val : this.UnDamageCalucate(val);
					bool flag5 = hit < 0;
					if (flag5)
					{
						UIManager.Instance.ShowPopUpText("NormalMsgText", "抵抗", pos).Forget<PopUpTextUI>();
					}
					else
					{
						Enemy enemy = this.fatherObject as Enemy;
						bool flag6 = enemy != null;
						if (flag6)
						{
							bool canUseTough = customDamageType.CanUseTough;
							if (canUseTough)
							{
								bool flag7 = this.ToughCount > 0;
								if (flag7)
								{
									this.ToughCount--;
									bool flag8 = this.ToughCount == 0;
									if (flag8)
									{
										Singleton<EventCenter>.Instance.EventTrigger("ToughCountZero");
										Singleton<EffectManager>.Instance.PlayEffect(this.MirrorSc, "破韧");
									}
								}
								else
								{
									hit = hit * 3 / 2;
								}
							}
						}
						FightManager.Instance.EnqueueEvent(new DamageText().Create(new DamageText.DamageTextData
						{
							hit = customDamageType.ApplyDamage(this, hit, pos, FightManager.Instance.statuses[fromInstanceId], originalVal, damageType, fromDataId),
							x = pos.x,
							y = pos.y,
							from = fromInstanceId,
							to = this.InstanceId,
							originalVal = originalVal,
							damageType = damageType
						}));
						UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
						{
							bool flag9 = this.state != IStatusManager.State.Dead;
							if (flag9)
							{
								this.CheckAllBuff("ReducePerAttacked");
							}
						}).Forget();
					}
				}
			}
		}
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00031B78 File Offset: 0x0002FD78
	private void $Rougamo_Heal(int val, string damageType)
	{
		int hit = 0;
		bool flag = this.IsNull() || this.statusBarObj == null;
		if (!flag)
		{
			CustomDamageType customDamageType = ResourceLoader.Load<CustomDamageType>("Configs/DamageType/" + damageType, true);
			bool flag2 = damageType != "True";
			if (flag2)
			{
				hit = (int)((float)val * this.dynamicVariables.GetValueOrDefault("HealMultiplier", 1f));
			}
			Singleton<EffectManager>.Instance.PlayEffect(this.MirrorSc, "heal");
			FightManager.Instance.EnqueueEvent(new DamageText().Create(new DamageText.DamageTextData
			{
				hit = val,
				x = this.statusBarObj.transform.localPosition.x,
				y = this.statusBarObj.transform.localPosition.y,
				from = null,
				to = this.InstanceId,
				originalVal = val,
				damageType = damageType
			}));
			customDamageType.ApplyHeal(this, hit);
		}
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x000026D9 File Offset: 0x000008D9
	private void $Rougamo_PlayVocal(IStatusManager.VocalState state)
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00031C8C File Offset: 0x0002FE8C
	private void $Rougamo_EnemyDead([Optional] float Delay)
	{
		bool flag = this.hasDead;
		if (!flag)
		{
			base.gameObject.GetComponent<BoxCollider>().enabled = false;
			this.hasDead = true;
			EnemyManager.enemyCount--;
			EnemyManager.Instance.enemyList.Remove(this.fatherObject as Enemy);
			bool flag2 = FightPlayer.Instance != null && FightPlayer.Instance.Status != null;
			if (flag2)
			{
				Singleton<EventCenter>.Instance.EventTrigger("OnEnemyDead" + FightPlayer.Instance.Status.InstanceId);
			}
			Singleton<EventCenter>.Instance.Clear(this);
			FightPlayer instance = FightPlayer.Instance;
			if (instance != null)
			{
				IStatusManager status = instance.Status;
				if (status != null)
				{
					status.PlayVocal(IStatusManager.VocalState.Kill);
				}
			}
			Enemy enemy = (Enemy)this.fatherObject;
			enemy.DeadEffect();
			AudioManager instance2 = AudioManager.Instance;
			if (instance2 != null)
			{
				instance2.PlayEffect("NewSounds/战斗中/死亡");
			}
			bool flag3 = EnemyManager.enemyCount == 0;
			if (flag3)
			{
				bool flag4 = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
				if (flag4)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").CanWin();
				}
			}
		}
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00031DC4 File Offset: 0x0002FFC4
	private void $Rougamo_UpdateTough()
	{
		bool flag = this.IsNull() || this.statusBarObj == null || this.statusBarUI.hpItemObj == null;
		if (!flag)
		{
			this.statusBarUI.UpdateTough();
		}
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00031E0F File Offset: 0x0003000F
	private void $Rougamo_ChangeState(IStatusManager.State state)
	{
		this.state = state;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00031E1C File Offset: 0x0003001C
	private void $Rougamo_Resurrection([Optional] int value)
	{
		bool flag = this.state != IStatusManager.State.Dead;
		if (!flag)
		{
			this.isResurrecting = true;
			this.state = IStatusManager.State.Default;
			this.CurHp = this.MaxHp;
			this.Heal(this.MaxHp, "True");
			bool flag2 = this.fatherObject is FightPlayer;
			if (flag2)
			{
				RoleTable.Instance.san = this.MaxHp;
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeSan(RoleTable.Instance.Id);
			}
			UniTask.Delay(300, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
			{
				this.isResurrecting = false;
				Singleton<EventCenter>.Instance.EventTrigger("Resurrection" + this.InstanceId);
			}).Forget();
			this.UpdateStatus(true);
		}
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00031EE8 File Offset: 0x000300E8
	private void $Rougamo_CheckDead()
	{
		bool flag = this.fatherObject == null || PlayerManager.Instance == null || FightManager.Instance == null || Singleton<TempDataManager>.Instance.RoleStatusMap == null || !Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(PlayerManager.Instance.PlayerId);
		if (!flag)
		{
			bool isNeedDead = this.fatherObject is Enemy || this.fatherObject is Partner || Singleton<TempDataManager>.Instance.RoleStatusMap[PlayerManager.Instance.PlayerId].Contains(this.InstanceId);
			bool flag2 = !isNeedDead || this.isResurrecting;
			if (!flag2)
			{
				bool flag3 = (this.curHp <= 0 || this.maxHp <= 0) && this.state != IStatusManager.State.Dead && !this.isResurrecting;
				if (flag3)
				{
					this.state = IStatusManager.State.Dead;
				}
				bool flag4 = this.dynamicVariables["liveCount"] > 0f;
				if (flag4)
				{
					this.CurHp = this.MaxHp;
					this.curHp = this.MaxHp;
					Dictionary<string, float> dynamicVariables = this.dynamicVariables;
					dynamicVariables["liveCount"] = dynamicVariables["liveCount"] - 1f;
					this.Resurrection(100);
				}
				else
				{
					Enemy enemy = this.fatherObject as Enemy;
					bool flag5 = enemy != null;
					if (flag5)
					{
						bool flag6 = enemy != null;
						if (flag6)
						{
							enemy.enabled = false;
						}
						this.EnemyDead(0f);
					}
					else
					{
						RoleTable.Instance.isDead = true;
						bool isFake = FightManager.Instance.IsFake;
						if (isFake)
						{
							string tempRole = FightManager.Instance.TempRoleList.GetValueOrDefault(RoleTable.Instance.Id, null);
							bool flag7 = tempRole == null;
							if (!flag7)
							{
								this.CurHp = this.MaxHp;
								this.curHp = this.MaxHp;
								RoleTable role = JsonConvert.DeserializeObject<RoleTable>(tempRole);
								RoleTable.Instance.ResetFight(role);
								Fight_Win.IsWin = false;
								RoleTable.Instance.isDead = false;
								UniTask.WaitForSeconds(0.3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
								{
									bool flag10 = FightManager.Instance != null;
									if (flag10)
									{
										FightManager.Instance.CmdChangeType(FightType.Win);
									}
								}).Forget();
							}
						}
						else
						{
							bool flag8 = this.fatherObject is FightPlayer && FightManager.Instance.fightType == FightType.Player;
							if (flag8)
							{
								FightManager.Instance.TurnEnd();
							}
							bool flag9 = FightPlayer.Instance != null;
							if (flag9)
							{
								FightPlayer.Instance.DeadEffect();
							}
							UniTask.WaitForSeconds(2f, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
							{
								bool flag10 = FightManager.Instance != null;
								if (flag10)
								{
									FightManager.Instance.CmdCheckDead(null);
								}
							}).Forget();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x000321F4 File Offset: 0x000303F4
	private IStatusManager $Rougamo_CheckAllBuff(string way)
	{
		BuffBarUI buffBarUI = this.buffBarUI;
		if (buffBarUI != null)
		{
			buffBarUI.CheckAllBuff(way);
		}
		return this;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0003221C File Offset: 0x0003041C
	private IStatusManager $Rougamo_UpdateBuff()
	{
		BuffBarUI buffBarUI = this.buffBarUI;
		if (buffBarUI != null)
		{
			buffBarUI.UpdateAllBuff();
		}
		return this;
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00032244 File Offset: 0x00030444
	private IStatusManager $Rougamo_ClearAllBuff()
	{
		BuffBarUI buffBarUI = this.buffBarUI;
		if (buffBarUI != null)
		{
			buffBarUI.ClearAllBuff();
		}
		return this;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0003226C File Offset: 0x0003046C
	private IStatusManager $Rougamo_RemoveBuff(string buffId)
	{
		BuffBarUI buffBarUI = this.buffBarUI;
		if (buffBarUI != null)
		{
			buffBarUI.RemoveBuff(buffId);
		}
		return this;
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00032294 File Offset: 0x00030494
	private IStatusManager $Rougamo_AddBuff(string buffId, int level)
	{
		bool flag = this.buffBarUI == null || this.buffBarUI.gameObject == null || this.fatherObject == null || this.fatherObject.IsNull("Object");
		IStatusManager result;
		if (flag)
		{
			result = null;
		}
		else
		{
			bool flag2 = level == 0;
			if (flag2)
			{
				result = this;
			}
			else
			{
				this.buffBarUI.AddBuff(buffId, level);
				result = this;
			}
		}
		return result;
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00032310 File Offset: 0x00030510
	private IStatusManager $Rougamo_AddBuff(IBuffItemConfig buffConfig)
	{
		bool flag = this.buffBarUI == null || this.buffBarUI.gameObject == null;
		if (flag)
		{
			Debug.Log("buffBarUI为空");
		}
		this.buffBarUI.AddBuff(buffConfig);
		return this;
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00032364 File Offset: 0x00030564
	private IBuffItem $Rougamo_GetBuff(string buffId)
	{
		bool flag = this.buffBarUI == null || this.buffBarUI.gameObject == null;
		IBuffItem result;
		if (flag)
		{
			Debug.Log("buffBarUI为空");
			result = null;
		}
		else
		{
			BuffItem buffItem;
			this.buffBarUI.BuffDic.TryGetValue(buffId, out buffItem);
			result = buffItem;
		}
		return result;
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x000323C4 File Offset: 0x000305C4
	private IBuffItem[] $Rougamo_GetBuffs()
	{
		bool flag = this.buffBarUI == null || this.buffBarUI.gameObject == null;
		IBuffItem[] result;
		if (flag)
		{
			Debug.Log("buffBarUI为空");
			result = null;
		}
		else
		{
			IBuffItem[] buffs = this.buffBarUI.GetBuffs();
			result = buffs;
		}
		return result;
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0003241C File Offset: 0x0003061C
	private void $Rougamo_Update()
	{
		FightObject fatherObject = this.fatherObject;
		if (fatherObject != null)
		{
			fatherObject.PlayAnimatedPerFrame();
		}
		for (int i = 0; i < this.Summon.Count; i++)
		{
			SummonObject summonObject = this.Summon[i];
			if (summonObject != null)
			{
				summonObject.PlayAnimatedPerFrame();
			}
		}
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00032470 File Offset: 0x00030670
	private void $Rougamo_OnPointerEnter(PointerEventData eventData)
	{
		bool flag = this.statusBarUI != null;
		if (flag)
		{
			this.statusBarUI.OnSelected();
		}
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0003249C File Offset: 0x0003069C
	private void $Rougamo_OnPointerExit(PointerEventData eventData)
	{
		bool flag = this.statusBarUI != null;
		if (flag)
		{
			this.statusBarUI.OnUnSelected();
		}
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x000324C8 File Offset: 0x000306C8
	private Transform get_transform()
	{
		return base.transform;
	}

	// Token: 0x04000A0A RID: 2570
	private IStatusManager.State _state = IStatusManager.State.Default;

	// Token: 0x04000A0B RID: 2571
	public IStatusManager.AnimatedState _animatedState = IStatusManager.AnimatedState.Idle;

	// Token: 0x04000A0C RID: 2572
	public List<SummonObject> Summon = new List<SummonObject>();

	// Token: 0x04000A0D RID: 2573
	public bool _NetEnqueue = false;

	// Token: 0x04000A0F RID: 2575
	public GameObject selfUI;

	// Token: 0x04000A11 RID: 2577
	public GameObject statusBarObj;

	// Token: 0x04000A13 RID: 2579
	public KeywordDisplay[] actionText;

	// Token: 0x04000A14 RID: 2580
	public StatusBarUI statusBarUI;

	// Token: 0x04000A15 RID: 2581
	private BuffBarUI buffBarUI;

	// Token: 0x04000A16 RID: 2582
	private KeywordDisplay keywordDisplay;

	// Token: 0x04000A17 RID: 2583
	public GameObject actionContent;

	// Token: 0x04000A18 RID: 2584
	public GameObject effectListObj;

	// Token: 0x04000A1A RID: 2586
	public Vector3 initPos;

	// Token: 0x04000A1B RID: 2587
	public DataConfig MiDataConfig;

	// Token: 0x04000A1C RID: 2588
	public int maxHp;

	// Token: 0x04000A1E RID: 2590
	public int _toughCount;

	// Token: 0x04000A1F RID: 2591
	public int curHp;

	// Token: 0x04000A20 RID: 2592
	public int defend;

	// Token: 0x04000A23 RID: 2595
	private GameObject SelectIcon;

	// Token: 0x04000A24 RID: 2596
	private bool hasDestroyed;

	// Token: 0x04000A25 RID: 2597
	private bool hasDead;

	// Token: 0x04000A26 RID: 2598
	public bool isResurrecting;
}

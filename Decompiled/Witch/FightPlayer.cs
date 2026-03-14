using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x0200008C RID: 140
public class FightPlayer : FightObject
{
	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060003EF RID: 1007 RVA: 0x000210A4 File Offset: 0x0001F2A4
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_Type()).MethodHandle, typeof(FightPlayer).TypeHandle);
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

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000211E4 File Offset: 0x0001F3E4
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_Id()).MethodHandle, typeof(FightPlayer).TypeHandle);
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

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00021324 File Offset: 0x0001F524
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_AnimationLocation()).MethodHandle, typeof(FightPlayer).TypeHandle);
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

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00021464 File Offset: 0x0001F664
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_VocalLocation()).MethodHandle, typeof(FightPlayer).TypeHandle);
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

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000215A4 File Offset: 0x0001F7A4
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_Name()).MethodHandle, typeof(FightPlayer).TypeHandle);
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

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000216E4 File Offset: 0x0001F8E4
	public override IStatusManager Status
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_Status()).MethodHandle, typeof(FightPlayer).TypeHandle);
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
							statusManager = this.$Rougamo_get_Status();
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
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00021824 File Offset: 0x0001FA24
	// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00021968 File Offset: 0x0001FB68
	public int MaxPowerCount
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_MaxPowerCount()).MethodHandle, typeof(FightPlayer).TypeHandle);
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
							num = this.$Rougamo_get_MaxPowerCount();
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.set_MaxPowerCount(int)).MethodHandle, typeof(FightPlayer).TypeHandle);
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
							this.$Rougamo_set_MaxPowerCount(value);
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

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00021AA4 File Offset: 0x0001FCA4
	// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00021BE8 File Offset: 0x0001FDE8
	public int CurPowerCount
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_CurPowerCount()).MethodHandle, typeof(FightPlayer).TypeHandle);
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
							num = this.$Rougamo_get_CurPowerCount();
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.set_CurPowerCount(int)).MethodHandle, typeof(FightPlayer).TypeHandle);
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
							this.$Rougamo_set_CurPowerCount(value);
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

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00021D24 File Offset: 0x0001FF24
	public DiceIcon diceIcon
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_diceIcon()).MethodHandle, typeof(FightPlayer).TypeHandle);
			methodContext.Arguments = new object[0];
			DiceIcon diceIcon;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					diceIcon = (DiceIcon)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							diceIcon = this.$Rougamo_get_diceIcon();
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
								diceIcon = (DiceIcon)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = diceIcon;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						diceIcon = (DiceIcon)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return diceIcon;
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060003FA RID: 1018 RVA: 0x00021E64 File Offset: 0x00020064
	// (set) Token: 0x060003FB RID: 1019 RVA: 0x00021F9C File Offset: 0x0002019C
	public static FightPlayer Instance
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
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.get_Instance()).MethodHandle, typeof(FightPlayer).TypeHandle);
			methodContext.Arguments = new object[0];
			FightPlayer fightPlayer;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					fightPlayer = (FightPlayer)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							fightPlayer = FightPlayer.$Rougamo_get_Instance();
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
								fightPlayer = (FightPlayer)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_100;
							}
							throw;
						}
						methodContext.ReturnValue = fightPlayer;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						fightPlayer = (FightPlayer)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_100:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return fightPlayer;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		private set
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(FightPlayer);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.set_Instance(FightPlayer)).MethodHandle, typeof(FightPlayer).TypeHandle);
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
							value = (FightPlayer)arguments[0];
						}
					}
					do
					{
						try
						{
							FightPlayer.$Rougamo_set_Instance(value);
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
								goto IL_F5;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_F5:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}
	}

	/// <summary>己方回合开始时调用，启动空闲(Bored)计时。会取消并重启之前的计时。</summary>
	// Token: 0x060003FC RID: 1020 RVA: 0x000220C8 File Offset: 0x000202C8
	[DebuggerStepThrough]
	public void StartBoredTimer()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(FightPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.StartBoredTimer()).MethodHandle, typeof(FightPlayer).TypeHandle);
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
						this.$Rougamo_StartBoredTimer();
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

	// Token: 0x060003FD RID: 1021 RVA: 0x000221C4 File Offset: 0x000203C4
	[DebuggerStepThrough]
	private UniTaskVoid BoredIdleLoop(CancellationToken token)
	{
		FightPlayer.<BoredIdleLoop>d__31 <BoredIdleLoop>d__ = new FightPlayer.<BoredIdleLoop>d__31();
		<BoredIdleLoop>d__.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
		<BoredIdleLoop>d__.<>4__this = this;
		<BoredIdleLoop>d__.token = token;
		<BoredIdleLoop>d__.<>1__state = -1;
		<BoredIdleLoop>d__.<>t__builder.Start<FightPlayer.<BoredIdleLoop>d__31>(ref <BoredIdleLoop>d__);
		return <BoredIdleLoop>d__.<>t__builder.Task;
	}

	/// <summary>有操作时调用，重新开始空闲计时。</summary>
	// Token: 0x060003FE RID: 1022 RVA: 0x00022210 File Offset: 0x00020410
	[DebuggerStepThrough]
	public void ResetBoredTimer()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(FightPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.ResetBoredTimer()).MethodHandle, typeof(FightPlayer).TypeHandle);
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
						this.$Rougamo_ResetBoredTimer();
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

	/// <summary>回合结束时调用，取消空闲计时。</summary>
	// Token: 0x060003FF RID: 1023 RVA: 0x0002230C File Offset: 0x0002050C
	[DebuggerStepThrough]
	public void StopBoredTimer()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(FightPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.StopBoredTimer()).MethodHandle, typeof(FightPlayer).TypeHandle);
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
						this.$Rougamo_StopBoredTimer();
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

	// Token: 0x06000400 RID: 1024 RVA: 0x00022408 File Offset: 0x00020608
	[DebuggerStepThrough]
	public void Init(string instanceId)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(FightPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.Init(string)).MethodHandle, typeof(FightPlayer).TypeHandle);
		methodContext.Arguments = new object[]
		{
			instanceId
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
						instanceId = null;
					}
					else
					{
						instanceId = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_Init(instanceId);
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

	// Token: 0x06000401 RID: 1025 RVA: 0x0002253C File Offset: 0x0002073C
	public override IEnumerator DoAction()
	{
		this.isEnd = false;
		FightManager.Instance.ChangeUnit(FightType.Player);
		bool flag = RoleTable.Instance.isDead && UIManager.Instance.GetUI<FightUI>("FightUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").onChangeTurnBtn();
		}
		yield return UniTask.WaitUntil(() => this.isEnd, PlayerLoopTiming.Update, UIManager.Instance.GetUI<FightUI>("FightUI").destroyCancellationToken, false).ToCoroutine(null);
		yield break;
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x0002254C File Offset: 0x0002074C
	[DebuggerStepThrough]
	public override void OnDestroy()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(FightPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.OnDestroy()).MethodHandle, typeof(FightPlayer).TypeHandle);
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
						this.$Rougamo_OnDestroy();
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

	// Token: 0x06000403 RID: 1027 RVA: 0x00022648 File Offset: 0x00020848
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
		methodContext.TargetType = typeof(FightPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.EndRound()).MethodHandle, typeof(FightPlayer).TypeHandle);
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

	// Token: 0x06000404 RID: 1028 RVA: 0x00022744 File Offset: 0x00020944
	[DebuggerStepThrough]
	public void DeadEffect()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(FightPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.DeadEffect()).MethodHandle, typeof(FightPlayer).TypeHandle);
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
						this.$Rougamo_DeadEffect();
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

	// Token: 0x06000407 RID: 1031 RVA: 0x00022858 File Offset: 0x00020A58
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
		methodContext.TargetType = typeof(FightPlayer);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightPlayer.Weaved()).MethodHandle, typeof(FightPlayer).TypeHandle);
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

	// Token: 0x06000408 RID: 1032 RVA: 0x0002299C File Offset: 0x00020B9C
	private string $Rougamo_get_Type()
	{
		return "FightPlayer";
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x000229A3 File Offset: 0x00020BA3
	private string $Rougamo_get_Id()
	{
		return RoleTable.Instance.Career.data["Id"];
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x000229BE File Offset: 0x00020BBE
	private string $Rougamo_get_AnimationLocation()
	{
		return Singleton<GameConfigManager>.Instance.GetOne(DataType.Career, this.Id).GetValueOrDefault("Animation", null);
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x000229DD File Offset: 0x00020BDD
	private string $Rougamo_get_VocalLocation()
	{
		return Singleton<GameConfigManager>.Instance.GetOne(DataType.Career, this.Id).GetValueOrDefault("Vocal", null);
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x000229FC File Offset: 0x00020BFC
	private string $Rougamo_get_Name()
	{
		return RoleTable.Instance.Career.data.Localize("Name");
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00022A18 File Offset: 0x00020C18
	private IStatusManager $Rougamo_get_Status()
	{
		bool flag = FightManager.Instance == null || FightManager.Instance.statuses == null || !FightManager.Instance.statuses.ContainsKey(base.InstanceId);
		IStatusManager result;
		if (flag)
		{
			result = null;
		}
		else
		{
			result = FightManager.Instance.statuses[base.InstanceId];
		}
		return result;
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00022A80 File Offset: 0x00020C80
	private int $Rougamo_get_MaxPowerCount()
	{
		return this.maxPowerCount;
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00022A98 File Offset: 0x00020C98
	private void $Rougamo_set_MaxPowerCount(int value)
	{
		this.maxPowerCount = ((value > 0) ? value : 0);
		FightUI ui = UIManager.Instance.GetUI<FightUI>("FightUI");
		if (ui != null)
		{
			ui.UpdatePower();
		}
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00022AC4 File Offset: 0x00020CC4
	private int $Rougamo_get_CurPowerCount()
	{
		return this.curPowerCount;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00022ADC File Offset: 0x00020CDC
	private void $Rougamo_set_CurPowerCount(int value)
	{
		this.curPowerCount = ((value > 0) ? value : 0);
		FightUI ui = UIManager.Instance.GetUI<FightUI>("FightUI");
		if (ui != null)
		{
			ui.UpdatePower();
		}
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00022B08 File Offset: 0x00020D08
	private DiceIcon $Rougamo_get_diceIcon()
	{
		bool flag = this.diceIconList == null;
		DiceIcon result;
		if (flag)
		{
			result = null;
		}
		else
		{
			DiceIcon diceicon = Singleton<ObjectPool>.Instance.Get(this.diceIconList.Find("DiceIconPrefab").gameObject, this.diceIconList).GetComponent<DiceIcon>();
			diceicon.gameObject.SetActive(true);
			result = diceicon;
		}
		return result;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00022B68 File Offset: 0x00020D68
	private static FightPlayer $Rougamo_get_Instance()
	{
		return FightPlayer.<Instance>k__BackingField;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00022B6F File Offset: 0x00020D6F
	private static void $Rougamo_set_Instance(FightPlayer value)
	{
		FightPlayer.<Instance>k__BackingField = value;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00022B78 File Offset: 0x00020D78
	private void $Rougamo_StartBoredTimer()
	{
		CancellationTokenSource boredCts = this._boredCts;
		if (boredCts != null)
		{
			boredCts.Cancel();
		}
		CancellationTokenSource boredCts2 = this._boredCts;
		if (boredCts2 != null)
		{
			boredCts2.Dispose();
		}
		this._boredCts = new CancellationTokenSource();
		this._boredLastActionTime = Time.time;
		this.BoredIdleLoop(this._boredCts.Token).Forget();
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00022BDA File Offset: 0x00020DDA
	private void $Rougamo_ResetBoredTimer()
	{
		this._boredLastActionTime = Time.time;
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00022BE7 File Offset: 0x00020DE7
	private void $Rougamo_StopBoredTimer()
	{
		CancellationTokenSource boredCts = this._boredCts;
		if (boredCts != null)
		{
			boredCts.Cancel();
		}
		CancellationTokenSource boredCts2 = this._boredCts;
		if (boredCts2 != null)
		{
			boredCts2.Dispose();
		}
		this._boredCts = null;
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00022C18 File Offset: 0x00020E18
	private void $Rougamo_Init(string instanceId)
	{
		FightPlayer.Instance = this;
		this.isEnd = false;
		base.MaxHp = RoleTable.Instance.MaxSan;
		base.CurHp = RoleTable.Instance.San;
		bool flag = GameEntryUI.playerCount > 1;
		if (flag)
		{
			PlayerManager.Instance.CmdSendRoleTable(base.MaxHp.ToString(), instanceId, "MaxSan");
			PlayerManager.Instance.CmdSendRoleTable(base.CurHp.ToString(), instanceId, "San");
		}
		this.MaxPowerCount = 3;
		this.CurPowerCount = this.MaxPowerCount;
		base.InstanceId = instanceId;
		Singleton<TempDataManager>.Instance.RoleStatusMap[instanceId].Add(instanceId);
		base.transform.gameObject.AddComponent<StatusManager>().Init(this);
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00022CED File Offset: 0x00020EED
	private void $Rougamo_OnDestroy()
	{
		base.OnDestroy();
		FightPlayer.Instance = null;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x000026D9 File Offset: 0x000008D9
	private void $Rougamo_EndRound()
	{
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x000026D9 File Offset: 0x000008D9
	private void $Rougamo_DeadEffect()
	{
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00022CFE File Offset: 0x00020EFE
	private bool $Rougamo_Weaved()
	{
		return true;
	}

	// Token: 0x040009B9 RID: 2489
	public Transform diceIconList;

	// Token: 0x040009BA RID: 2490
	private int maxPowerCount;

	// Token: 0x040009BB RID: 2491
	private int curPowerCount;

	// Token: 0x040009BD RID: 2493
	private const float BoredIdleSeconds = 20f;

	// Token: 0x040009BE RID: 2494
	private float _boredLastActionTime;

	// Token: 0x040009BF RID: 2495
	private CancellationTokenSource _boredCts;

	// Token: 0x040009C0 RID: 2496
	public bool isEnd = false;
}

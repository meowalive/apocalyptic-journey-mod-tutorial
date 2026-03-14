using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;
using Witch.UI;
using Witch.UI.Component;

// Token: 0x020000A1 RID: 161
public abstract class OtherObj : FightObject
{
	// Token: 0x1700009C RID: 156
	// (get) Token: 0x0600048D RID: 1165
	public abstract override string Type { get; }

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x0600048E RID: 1166 RVA: 0x00026220 File Offset: 0x00024420
	// (set) Token: 0x0600048F RID: 1167 RVA: 0x00026364 File Offset: 0x00024564
	public int Attack
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.get_Attack()).MethodHandle, typeof(OtherObj).TypeHandle);
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
							num = this.$Rougamo_get_Attack();
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.set_Attack(int)).MethodHandle, typeof(OtherObj).TypeHandle);
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
							this.$Rougamo_set_Attack(value);
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

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000490 RID: 1168 RVA: 0x000264A0 File Offset: 0x000246A0
	// (set) Token: 0x06000491 RID: 1169 RVA: 0x000265E4 File Offset: 0x000247E4
	public int Defend
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.get_Defend()).MethodHandle, typeof(OtherObj).TypeHandle);
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.set_Defend(int)).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000492 RID: 1170 RVA: 0x00026720 File Offset: 0x00024920
	// (set) Token: 0x06000493 RID: 1171 RVA: 0x00026864 File Offset: 0x00024A64
	public int ActionCount
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.get_ActionCount()).MethodHandle, typeof(OtherObj).TypeHandle);
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
							num = this.$Rougamo_get_ActionCount();
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.set_ActionCount(int)).MethodHandle, typeof(OtherObj).TypeHandle);
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
							this.$Rougamo_set_ActionCount(value);
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

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000494 RID: 1172 RVA: 0x000269A0 File Offset: 0x00024BA0
	// (set) Token: 0x06000495 RID: 1173 RVA: 0x00026AE4 File Offset: 0x00024CE4
	public int MaxActionCount
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.get_MaxActionCount()).MethodHandle, typeof(OtherObj).TypeHandle);
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
							num = this.$Rougamo_get_MaxActionCount();
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.set_MaxActionCount(int)).MethodHandle, typeof(OtherObj).TypeHandle);
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
							this.$Rougamo_set_MaxActionCount(value);
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

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000496 RID: 1174 RVA: 0x00026C20 File Offset: 0x00024E20
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.get_Id()).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000497 RID: 1175 RVA: 0x00026D60 File Offset: 0x00024F60
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.get_Name()).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000498 RID: 1176 RVA: 0x00026EA0 File Offset: 0x000250A0
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.get_AnimationLocation()).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000499 RID: 1177 RVA: 0x00026FE0 File Offset: 0x000251E0
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
			methodContext.TargetType = typeof(OtherObj);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.get_VocalLocation()).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x0600049A RID: 1178 RVA: 0x00027120 File Offset: 0x00025320
	[DebuggerStepThrough]
	public virtual void Init(DataConfig fromdata, float SumOfEnemyPositive, int index)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.Init(DataConfig, float, int)).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x0600049B RID: 1179 RVA: 0x000272A4 File Offset: 0x000254A4
	[DebuggerStepThrough]
	private void SetActionObj()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.SetActionObj()).MethodHandle, typeof(OtherObj).TypeHandle);
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
						this.$Rougamo_SetActionObj();
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

	// Token: 0x0600049C RID: 1180 RVA: 0x000273A0 File Offset: 0x000255A0
	[DebuggerStepThrough]
	protected virtual void SetActionArrow(int index)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.SetActionArrow(int)).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x0600049D RID: 1181 RVA: 0x000274DC File Offset: 0x000256DC
	public override IEnumerator DoAction()
	{
		bool flag = this.Status.state == IStatusManager.State.Dead;
		if (flag)
		{
			yield break;
		}
		Singleton<EventCenter>.Instance.EventTrigger("StartRound" + this.Status.InstanceId);
		yield return new WaitForSeconds(0.5f);
		bool flag2 = this.Status.state == IStatusManager.State.Dead;
		if (flag2)
		{
			yield break;
		}
		bool flag3 = this.Status.state == IStatusManager.State.NoAction;
		if (flag3)
		{
			this.Status.ChangeState(IStatusManager.State.Default);
			yield break;
		}
		this.SetActionObj();
		int i = 0;
		while (this.ActionCards != null && i < this.ActionCards.Count)
		{
			bool flag4 = this == null;
			if (flag4)
			{
				yield break;
			}
			bool flag5 = !this.DoOneAction(i, false) || this.Status.state == IStatusManager.State.NoAction || this.Status.state == IStatusManager.State.Dead;
			if (flag5)
			{
				yield break;
			}
			yield return new WaitForSeconds(1f);
			int num = i;
			i = num + 1;
		}
		bool flag6 = this.Status.CurHp > 0 && this.Status.state != IStatusManager.State.Dead && FightManager.Instance.fightType != FightType.Loss;
		if (flag6)
		{
			this.FightAction.CardUpdate();
		}
		yield break;
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x000274EC File Offset: 0x000256EC
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
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.EndRound()).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x0600049F RID: 1183 RVA: 0x000275E8 File Offset: 0x000257E8
	[DebuggerStepThrough]
	public void AnnounceDesAction(int index)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.AnnounceDesAction(int)).MethodHandle, typeof(OtherObj).TypeHandle);
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
						this.$Rougamo_AnnounceDesAction(index);
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

	// Token: 0x060004A0 RID: 1184 RVA: 0x00027724 File Offset: 0x00025924
	[DebuggerStepThrough]
	public void DesActionCard(int index)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.DesActionCard(int)).MethodHandle, typeof(OtherObj).TypeHandle);
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
						this.$Rougamo_DesActionCard(index);
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

	// Token: 0x060004A1 RID: 1185 RVA: 0x00027860 File Offset: 0x00025A60
	[DebuggerStepThrough]
	public void ResetActionObj()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.ResetActionObj()).MethodHandle, typeof(OtherObj).TypeHandle);
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
						this.$Rougamo_ResetActionObj();
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

	// Token: 0x060004A2 RID: 1186 RVA: 0x0002795C File Offset: 0x00025B5C
	[DebuggerStepThrough]
	public void SetAction()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.SetAction()).MethodHandle, typeof(OtherObj).TypeHandle);
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
						this.$Rougamo_SetAction();
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

	// Token: 0x060004A3 RID: 1187 RVA: 0x00027A58 File Offset: 0x00025C58
	[DebuggerStepThrough]
	public void UpdataActionShow()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.UpdataActionShow()).MethodHandle, typeof(OtherObj).TypeHandle);
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
						this.$Rougamo_UpdataActionShow();
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

	// Token: 0x060004A4 RID: 1188 RVA: 0x00027B54 File Offset: 0x00025D54
	[DebuggerStepThrough]
	public void UpdateText(Transform tempPar, string text)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.UpdateText(Transform, string)).MethodHandle, typeof(OtherObj).TypeHandle);
		methodContext.Arguments = new object[]
		{
			tempPar,
			text
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
						tempPar = null;
					}
					else
					{
						tempPar = (Transform)arguments[0];
					}
					if (arguments[1] == null)
					{
						text = null;
					}
					else
					{
						text = (string)arguments[1];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_UpdateText(tempPar, text);
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

	// Token: 0x060004A5 RID: 1189 RVA: 0x00027CA8 File Offset: 0x00025EA8
	[DebuggerStepThrough]
	public bool DoOneAction(int i, bool isSingle = false)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.DoOneAction(int, bool)).MethodHandle, typeof(OtherObj).TypeHandle);
		methodContext.Arguments = new object[]
		{
			i,
			isSingle
		};
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
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						i = 0;
					}
					else
					{
						i = (int)arguments[0];
					}
					if (arguments[1] == null)
					{
						isSingle = default(bool);
					}
					else
					{
						isSingle = (bool)arguments[1];
					}
				}
				do
				{
					try
					{
						flag = this.$Rougamo_DoOneAction(i, isSingle);
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
							goto IL_172;
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
				IL_172:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return flag;
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00027E68 File Offset: 0x00026068
	[DebuggerStepThrough]
	public void HideAction()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.HideAction()).MethodHandle, typeof(OtherObj).TypeHandle);
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
						this.$Rougamo_HideAction();
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

	// Token: 0x060004A7 RID: 1191 RVA: 0x00027F64 File Offset: 0x00026164
	[DebuggerStepThrough]
	public void ShowAction()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.ShowAction()).MethodHandle, typeof(OtherObj).TypeHandle);
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
						this.$Rougamo_ShowAction();
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

	// Token: 0x060004A8 RID: 1192 RVA: 0x00028060 File Offset: 0x00026260
	[DebuggerStepThrough]
	public bool ActionJudge()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.ActionJudge()).MethodHandle, typeof(OtherObj).TypeHandle);
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
						flag = this.$Rougamo_ActionJudge();
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

	// Token: 0x060004A9 RID: 1193 RVA: 0x000281A4 File Offset: 0x000263A4
	[DebuggerStepThrough]
	public virtual void AddCardList()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.AddCardList()).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x060004AA RID: 1194 RVA: 0x000282A0 File Offset: 0x000264A0
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
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.DeadEffect()).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x060004AE RID: 1198 RVA: 0x00028408 File Offset: 0x00026608
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
		methodContext.TargetType = typeof(OtherObj);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OtherObj.Weaved()).MethodHandle, typeof(OtherObj).TypeHandle);
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

	// Token: 0x060004AF RID: 1199 RVA: 0x0002854C File Offset: 0x0002674C
	private int $Rougamo_get_Attack()
	{
		return this.<Attack>k__BackingField;
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00028554 File Offset: 0x00026754
	private void $Rougamo_set_Attack(int value)
	{
		this.<Attack>k__BackingField = value;
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x0002855D File Offset: 0x0002675D
	private int $Rougamo_get_Defend()
	{
		return this.<Defend>k__BackingField;
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00028565 File Offset: 0x00026765
	private void $Rougamo_set_Defend(int value)
	{
		this.<Defend>k__BackingField = value;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x0002856E File Offset: 0x0002676E
	private int $Rougamo_get_ActionCount()
	{
		return this.<ActionCount>k__BackingField;
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00028576 File Offset: 0x00026776
	private void $Rougamo_set_ActionCount(int value)
	{
		this.<ActionCount>k__BackingField = value;
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x0002857F File Offset: 0x0002677F
	private int $Rougamo_get_MaxActionCount()
	{
		return this.<MaxActionCount>k__BackingField;
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00028587 File Offset: 0x00026787
	private void $Rougamo_set_MaxActionCount(int value)
	{
		this.<MaxActionCount>k__BackingField = value;
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00028590 File Offset: 0x00026790
	private string $Rougamo_get_Id()
	{
		return this.dataConfig.data["Id"];
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x000285A7 File Offset: 0x000267A7
	private string $Rougamo_get_Name()
	{
		return this.data.Localize("Name");
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x000285BC File Offset: 0x000267BC
	private string $Rougamo_get_AnimationLocation()
	{
		bool flag = !string.IsNullOrEmpty(this.dataConfig.data["Animation"]);
		string result;
		if (flag)
		{
			result = this.dataConfig.data["Animation"];
		}
		else
		{
			result = "AnimationLib/无形象敌人";
		}
		return result;
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00028610 File Offset: 0x00026810
	private string $Rougamo_get_VocalLocation()
	{
		string vocal;
		bool flag = this.dataConfig.data.TryGetValue("Vocal", out vocal) && !string.IsNullOrEmpty(vocal);
		string result;
		if (flag)
		{
			result = vocal;
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00028650 File Offset: 0x00026850
	private void $Rougamo_Init(DataConfig fromdata, float SumOfEnemyPositive, int index)
	{
		this.dataConfig = fromdata;
		this.data = this.dataConfig.data;
		this.FightAction = new ObjectAction(this);
		bool flag = this != null && base.gameObject != null;
		if (flag)
		{
			base.transform.Find("body").GetComponent<SpriteRenderer>().material = UnityEngine.Object.Instantiate<Material>(ResourceLoader.Load<Material>("Material/EnemyMaterial", true));
		}
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x000286CC File Offset: 0x000268CC
	private void $Rougamo_SetActionObj()
	{
		int i = 0;
		while (i < 4)
		{
			bool flag = (this.Status as StatusManager).actionText[i].text == "";
			if (flag)
			{
				bool flag2 = this.Status.actionObj[i] == null;
				if (!flag2)
				{
					this.Status.actionObj[i].SetActive(false);
				}
			}
			else
			{
				bool flag3 = this.Status.actionObj[i] == null;
				if (!flag3)
				{
					this.Status.actionObj[i].SetActive(true);
					this.SetActionArrow(i);
				}
			}
			IL_99:
			i++;
			continue;
			goto IL_99;
		}
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00028784 File Offset: 0x00026984
	private void $Rougamo_SetActionArrow(int index)
	{
		bool flag = index >= this.ActionCards.Count;
		if (!flag)
		{
			FightLine lineUI = this.Status.actionObj[index].transform.Find("LineUI").GetComponent<FightLine>();
			lineUI.SetStartPos(new Vector3(0f, 0f, 0f));
			bool flag2;
			if (this.ActionCards[index].dataConfig.scriptExecutor.Object.Count != 0)
			{
				IStatusManager statusManager = this.ActionCards[index].dataConfig.scriptExecutor.Object[0];
				flag2 = (statusManager == null || statusManager.IsNull());
			}
			else
			{
				flag2 = true;
			}
			bool flag3 = flag2;
			if (!flag3)
			{
				lineUI.Combine((this.ActionCards[index].dataConfig.scriptExecutor.Object[0] as StatusManager).selfUI.transform);
				bool flag4 = this.ActionCards[index].dataConfig.scriptExecutor.Object[0] == this.Status;
				if (flag4)
				{
					lineUI.show = false;
				}
				else
				{
					lineUI.show = true;
					lineUI.curvature = 0.3f + (float)index * 0.1f;
				}
			}
		}
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x000288D4 File Offset: 0x00026AD4
	private void $Rougamo_EndRound()
	{
		bool flag = this.Status.state != IStatusManager.State.Dead;
		if (flag)
		{
			Singleton<EventCenter>.Instance.EventTrigger("EndRound" + this.Status.InstanceId);
			bool flag2 = this.Status.CurHp > 0;
			if (flag2)
			{
				this.Status.CheckAllBuff("ReducePerTurn");
			}
		}
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x0002893E File Offset: 0x00026B3E
	private void $Rougamo_AnnounceDesAction(int index)
	{
		FightManager.Instance.CmdActionChange(this.Status.InstanceId, index.ToString());
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00028960 File Offset: 0x00026B60
	private void $Rougamo_DesActionCard(int index)
	{
		bool flag = index >= this.Status.actionObj.Length;
		if (!flag)
		{
			GameObject temp = this.Status.actionObj[index];
			temp.SetActive(false);
			this.FightAction.DesActionCard(index);
		}
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x000289AC File Offset: 0x00026BAC
	private void $Rougamo_ResetActionObj()
	{
		bool flag = !Application.isPlaying;
		if (!flag)
		{
			for (int i = 0; i < 4; i++)
			{
				(this.Status as StatusManager).actionText[i].text = "";
				bool flag2 = this.Status.actionObj[i] == null;
				if (!flag2)
				{
					this.Status.actionObj[i].SetActive(false);
					this.Status.actionObj[i].transform.Find("Icon").GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					this.Status.actionObj[i].transform.Find("Icon").localScale = new Vector3(1f, 1f, 1f);
					this.Status.actionObj[i].transform.Find("Icon/val").localScale = new Vector3(1f, 1f, 1f);
				}
			}
		}
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00028AE0 File Offset: 0x00026CE0
	private void $Rougamo_SetAction()
	{
		bool flag = !Application.isPlaying;
		if (!flag)
		{
			bool flag2 = this.Status.state == IStatusManager.State.NoAction;
			if (!flag2)
			{
				this.ResetActionObj();
				this.ActionCards = this.FightAction.ActionShow((this.ActionCount > 0) ? this.ActionCount : 0);
				this.UpdataActionShow();
				this.SetActionObj();
			}
		}
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00028B4C File Offset: 0x00026D4C
	private void $Rougamo_UpdataActionShow()
	{
		for (int i = 0; i < this.ActionCards.Count; i++)
		{
			int index = i;
			this.ActionCards[i].dataConfig.scriptExecutor.RunScript("InitScript");
			(this.Status as StatusManager).actionText[i].SetLocalizedText(() => this.ActionCards[index].dataConfig.data.Localize("Name"), () => this.ActionCards[index].dataConfig.Description().Highlight(this.ActionCards[index].keyWords), this.ActionCards[index].keyWords);
			(this.Status as StatusManager).actionText[i].keyWords = this.ActionCards[index].keyWords;
			(this.Status as StatusManager).actionText[i].type = "Action";
			bool flag = this.Status.actionObj[i] == null;
			if (!flag)
			{
				Sprite iconSprite = ResourceLoader.Load<Sprite>(this.ActionCards[i].dataConfig.data["Icon"], true);
				bool flag2 = iconSprite == null;
				if (flag2)
				{
					iconSprite = ResourceLoader.Load<Sprite>("Icon/ActionIcon/蓄力", true);
				}
				Sprite backSprite = ResourceLoader.Load<Sprite>(this.ActionCards[i].dataConfig.data["BackIcon"], true);
				bool flag3 = backSprite == null;
				if (flag3)
				{
					backSprite = ResourceLoader.Load<Sprite>("Icon/ActionIcon/攻击底", true);
				}
				this.Status.actionObj[i].transform.Find("Icon").GetComponent<Image>().sprite = backSprite;
				this.Status.actionObj[i].transform.Find("Icon/child").GetComponent<Image>().sprite = iconSprite;
				string desVal = this.ActionCards[i].dataConfig.Vars.GetValueOrDefault("DesVal1", "");
				this.UpdateText(this.Status.actionObj[i].transform.Find("Icon/val"), Regex.Replace(desVal, "</?color[^>]*>", ""));
				this.Status.actionObj[i].transform.Find("Icon").GetComponent<Image>().color = Color.white * new Color(1f, 1f, 1f);
			}
		}
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00028DD8 File Offset: 0x00026FD8
	private void $Rougamo_UpdateText(Transform tempPar, string text)
	{
		TMP_Text tmp = tempPar.GetComponent<TMP_Text>();
		bool flag = tmp == null;
		if (!flag)
		{
			tmp.SetDigitText(text);
		}
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00028E04 File Offset: 0x00027004
	private bool $Rougamo_DoOneAction(int i, [Optional] bool isSingle)
	{
		bool flag = !this.ActionJudge();
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			bool flag2 = this.IsNull("Object");
			if (flag2)
			{
				result = false;
			}
			else
			{
				bool flag3 = this.Status.actionObj.Count<GameObject>() < i;
				if (flag3)
				{
					this.SetAction();
				}
				GameObject actionShow = base.gameObject.transform.Find("head/Msg").gameObject;
				bool flag4 = this.FightAction.TryGetCard() != null;
				if (flag4)
				{
					bool flag5 = this.FightAction.TryGetCard().dataConfig.data["Action"] == "";
					if (flag5)
					{
						actionShow.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -0.4f);
					}
					else
					{
						actionShow.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
					}
				}
				actionShow.GetComponent<SpriteRenderer>().DOFade(1f, 0.3f);
				actionShow.transform.Find("val").GetComponent<TMP_Text>().DOFade(1f, 0.3f);
				actionShow.transform.Find("val").GetComponent<TMP_Text>().SetLocalizedText(() => this.ActionCards[i].dataConfig.data.Localize("Name"));
				bool flag6 = base.transform.localScale.x < 0f;
				if (flag6)
				{
					actionShow.transform.Find("val").localScale = new Vector3(-0.05f, 0.05f, 1f);
				}
				UniTask.WaitForSeconds(0.6f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
				{
					bool flag9 = this.Status == null || this.Status.IsNull();
					if (!flag9)
					{
						bool flag10 = actionShow != null;
						if (flag10)
						{
							actionShow.GetComponent<SpriteRenderer>().DOFade(0f, 0.3f);
							actionShow.transform.Find("val").GetComponent<TMP_Text>().DOFade(0f, 0.3f);
						}
					}
				}).Forget();
				GameObject obj = this.Status.actionObj[i];
				bool flag7 = obj == null;
				if (flag7)
				{
					result = false;
				}
				else
				{
					this.HideAction();
					bool flag8 = !isSingle;
					if (flag8)
					{
						TweenCallback <>9__3;
						obj.transform.Find("Icon").GetComponent<Image>().DOColor(new Color(2f, 2f, 2f) * obj.transform.Find("Icon").GetComponent<Image>().color, 1f).OnComplete(delegate
						{
							obj.transform.Find("Icon/val").DOScale(Vector3.zero, 0.5f);
							this.transform.DOShakePosition(0.5f, 0.1f, 10, 90f, false, true, ShakeRandomnessMode.Full);
							TweenerCore<Color, Color, ColorOptions> t = obj.transform.Find("Icon").GetComponent<Image>().DOFade(0f, 0.5f);
							TweenCallback action;
							if ((action = <>9__3) == null)
							{
								action = (<>9__3 = delegate()
								{
									obj.GetComponent<KeywordDisplay>().text = "";
								});
							}
							t.OnComplete(action);
							obj.transform.Find("Icon").GetComponent<Image>().DOColor(new Color(0.5f, 0.5f, 0.5f) * obj.transform.Find("Icon").GetComponent<Image>().color, 0.5f);
							bool flag9 = this.FightAction.TryGetCard() != null && this.FightAction.TryGetCard().dataConfig.data["Action"] == "Attack";
							if (flag9)
							{
								AudioManager instance = AudioManager.Instance;
								if (instance != null)
								{
									instance.PlayEffect("NewSounds/战斗中/近战打击2/GORE - WEAP - Axe_Large_Whoosh_1");
								}
							}
							else
							{
								AudioManager instance2 = AudioManager.Instance;
								if (instance2 != null)
								{
									instance2.PlayEffect("NewSounds/战斗中/格挡/GORE - WEAP - CrowBar_Whoosh_2");
								}
							}
						});
					}
					this.FightAction.ActionExecute();
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x000290D8 File Offset: 0x000272D8
	private void $Rougamo_HideAction()
	{
		foreach (GameObject item in this.Status.actionObj)
		{
			bool flag = item == null;
			if (!flag)
			{
				item.SetActive(false);
			}
		}
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00029120 File Offset: 0x00027320
	private void $Rougamo_ShowAction()
	{
		foreach (GameObject item in this.Status.actionObj)
		{
			bool flag = item == null || item.GetComponent<KeywordDisplay>().text == "";
			if (!flag)
			{
				item.SetActive(true);
			}
		}
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00029180 File Offset: 0x00027380
	private bool $Rougamo_ActionJudge()
	{
		bool flag = this.Status.state == IStatusManager.State.NoAction;
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			bool flag2 = this.Status.state == IStatusManager.State.Dead || this.Status.CurHp <= 0 || FightManager.Instance.fightType == FightType.Loss;
			result = !flag2;
		}
		return result;
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x000026D9 File Offset: 0x000008D9
	private void $Rougamo_AddCardList()
	{
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x000291E0 File Offset: 0x000273E0
	private void $Rougamo_DeadEffect()
	{
		bool flag = (this.Status as StatusManager).statusBarObj != null;
		if (flag)
		{
			(this.Status as StatusManager).statusBarObj.SetActive(false);
		}
		bool flag2 = (this.Status as StatusManager).actionContent != null;
		if (flag2)
		{
			(this.Status as StatusManager).actionContent.SetActive(false);
		}
		bool flag3 = base.transform == null;
		if (!flag3)
		{
			TweenCallback destroy = delegate()
			{
				bool flag6 = this != null && base.gameObject != null;
				if (flag6)
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			};
			base.transform.Find("body").GetComponent<SpriteRenderer>().material.DOKill(false);
			this.dataConfig.scriptExecutor.Clear();
			base.transform.Find("body").GetComponent<SpriteRenderer>().DOFade(0f, 3.5f).OnComplete(destroy).OnKill(destroy).OnStart(delegate
			{
				base.transform.Find("body").GetComponent<SpriteRenderer>().enabled = false;
			}).SetDelay(0.3f);
			VisualEffect vfx = base.transform.Find("死亡特效").GetComponent<VisualEffect>();
			bool flag4 = vfx == null;
			if (flag4)
			{
				Debug.LogError("死亡特效未找到");
			}
			else
			{
				int vram = Globals.VRam;
				if (!true)
				{
				}
				int num;
				if (vram < 1024)
				{
					if (vram >= 256)
					{
						if (vram >= 512)
						{
							num = 4;
						}
						else
						{
							num = 6;
						}
					}
					else
					{
						num = 9;
					}
				}
				else if (vram >= 2048)
				{
					num = 1;
				}
				else
				{
					num = 2;
				}
				if (!true)
				{
				}
				int Downscale = num;
				vfx.transform.localPosition = base.transform.Find("body").localPosition;
				Texture2D texture = base.transform.Find("body").GetComponent<SpriteRenderer>().sprite.texture;
				vfx.SetTexture("MainTex", texture);
				vfx.SetVector2("Grid Resolution", new Vector2((float)texture.width, (float)texture.height));
				bool flag5 = Downscale < 9;
				if (flag5)
				{
					vfx.SetInt("DownScale", Downscale);
					base.transform.Find("死亡特效").gameObject.SetActive(true);
				}
				Singleton<EffectManager>.Instance.PlayScreenEffect("TimeStop");
			}
		}
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00022CFE File Offset: 0x00020EFE
	private bool $Rougamo_Weaved()
	{
		return true;
	}

	// Token: 0x040009ED RID: 2541
	public DataConfig dataConfig;

	// Token: 0x040009EE RID: 2542
	public ObjectAction FightAction;

	// Token: 0x040009EF RID: 2543
	public List<ObjectCard> ActionCards = new List<ObjectCard>();

	// Token: 0x040009F0 RID: 2544
	public IDictionary<string, string> data;
}

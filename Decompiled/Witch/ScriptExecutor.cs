using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Data.Save;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Newtonsoft.Json;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Witch.UI;
using Witch.UI.Window;
using XLua;
using ZLinq;
using ZLinq.Linq;

// Token: 0x02000059 RID: 89
[IgnoreMo(MoTypes = new Type[]
{
	typeof(Modifiable)
})]
[ReflectionUse]
[LuaCallCSharp(GenFlag.No)]
public class ScriptExecutor : IScriptExecutor
{
	// Token: 0x06000244 RID: 580 RVA: 0x00014D28 File Offset: 0x00012F28
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void SetHp(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.SetHp(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_SetHp(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00014E00 File Offset: 0x00013000
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void SetMaxHp(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.SetMaxHp(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_SetMaxHp(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00014ED8 File Offset: 0x000130D8
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeHp(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeHp(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_ChangeHp(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00014FB0 File Offset: 0x000131B0
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeMaxHp(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeMaxHp(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_ChangeMaxHp(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00015088 File Offset: 0x00013288
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void AddBuff(string buffId, string level)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddBuff(string, string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			buffId,
			level
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
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
						level = null;
					}
					else
					{
						level = (string)arguments[1];
					}
				}
				this.$Rougamo_AddBuff(buffId, level);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000249 RID: 585 RVA: 0x00015180 File Offset: 0x00013380
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void RemoveBuff(string buffId)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.RemoveBuff(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			buffId
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
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
				this.$Rougamo_RemoveBuff(buffId);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00015258 File Offset: 0x00013458
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void RunImmediately(string buffId, string eventName)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.RunImmediately(string, string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			buffId,
			eventName
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
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
						eventName = null;
					}
					else
					{
						eventName = (string)arguments[1];
					}
				}
				this.$Rougamo_RunImmediately(buffId, eventName);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00015350 File Offset: 0x00013550
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void Resurrection(string value)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.Resurrection(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			value
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
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
						value = (string)arguments[0];
					}
				}
				this.$Rougamo_Resurrection(value);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00015428 File Offset: 0x00013628
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeDefence(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeDefence(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_ChangeDefence(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00015500 File Offset: 0x00013700
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void SetPower(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.SetPower(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_SetPower(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600024E RID: 590 RVA: 0x000155D8 File Offset: 0x000137D8
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void DrawCount(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.DrawCount(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_DrawCount(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600024F RID: 591 RVA: 0x000156B0 File Offset: 0x000138B0
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangePower(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangePower(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_ChangePower(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00015788 File Offset: 0x00013988
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeMaxPower(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeMaxPower(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_ChangeMaxPower(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00015860 File Offset: 0x00013A60
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeRound()
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeRound()).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				this.$Rougamo_ChangeRound();
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00015908 File Offset: 0x00013B08
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void DoAction(string index)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.DoAction(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			index
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						index = null;
					}
					else
					{
						index = (string)arguments[0];
					}
				}
				this.$Rougamo_DoAction(index);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x000159E0 File Offset: 0x00013BE0
	[Rougamo(typeof(ForEachObject))]
	public void RemoveBadBuff(string val, string good = "false")
	{
		int count = val.ToInt();
		IBuffItem[] buffs = this.status.GetBuffs();
		List<IBuffItem> removed = new List<IBuffItem>();
		int i = 0;
		while (i < buffs.Length && count > 0)
		{
			bool flag = (buffs[i].buffConfig.Type == "负面" && good == "false") || (buffs[i].buffConfig.Type == "正面" && good == "true");
			if (flag)
			{
				removed.Add(buffs[i]);
				count--;
			}
			i++;
		}
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", this.status.Name + "移除了 <color=yellow>" + string.Join(",", from x in removed
		select x.buffConfig.BuffName) + "</color> buff");
		foreach (IBuffItem item in removed)
		{
			item.ClearBuff();
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00015B48 File Offset: 0x00013D48
	[Rougamo(typeof(ForEachObject))]
	public void RemoveAllBadBuff(string obj)
	{
		obj = ((obj == "1") ? "正面" : "负面");
		IBuffItem[] buffs = this.status.GetBuffs();
		List<IBuffItem> removed = new List<IBuffItem>();
		for (int i = 0; i < buffs.Length; i++)
		{
			bool flag = buffs[i] == null;
			if (!flag)
			{
				bool flag2 = buffs[i].buffConfig.dataConfig.data["Type"] == obj;
				if (flag2)
				{
					removed.Add(buffs[i]);
				}
			}
		}
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", this.status.Name + "移除了 <color=yellow>" + string.Join(",", (from x in removed
		select x.buffConfig.BuffName).ToArray<string>()) + "</color> buff");
		foreach (IBuffItem item in removed)
		{
			item.ClearBuff();
		}
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00015C9C File Offset: 0x00013E9C
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void RemoveAllBuff()
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.RemoveAllBuff()).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				this.$Rougamo_RemoveAllBuff();
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00015D44 File Offset: 0x00013F44
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void AddCardByCardList(string count, string tag = "all")
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddCardByCardList(string, string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			count,
			tag
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						count = null;
					}
					else
					{
						count = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						tag = null;
					}
					else
					{
						tag = (string)arguments[1];
					}
				}
				this.$Rougamo_AddCardByCardList(count, tag);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00015E3C File Offset: 0x0001403C
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void AddCardByUsedCardList(string count, string tag = "all")
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddCardByUsedCardList(string, string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			count,
			tag
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						count = null;
					}
					else
					{
						count = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						tag = null;
					}
					else
					{
						tag = (string)arguments[1];
					}
				}
				this.$Rougamo_AddCardByUsedCardList(count, tag);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00015F34 File Offset: 0x00014134
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void RandomAddCard(string id)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.RandomAddCard(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			id
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
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
				this.$Rougamo_RandomAddCard(id);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0001600C File Offset: 0x0001420C
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeMoney(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeMoney(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_ChangeMoney(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600025A RID: 602 RVA: 0x000160E4 File Offset: 0x000142E4
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void AddAction(string count)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddAction(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			count
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						count = null;
					}
					else
					{
						count = (string)arguments[0];
					}
				}
				this.$Rougamo_AddAction(count);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600025B RID: 603 RVA: 0x000161BC File Offset: 0x000143BC
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ShuffleDeck()
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ShuffleDeck()).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				this.$Rougamo_ShuffleDeck();
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00016264 File Offset: 0x00014464
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeCardTop(string val)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeCardTop(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			val
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						val = null;
					}
					else
					{
						val = (string)arguments[0];
					}
				}
				this.$Rougamo_ChangeCardTop(val);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0001633C File Offset: 0x0001453C
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void GetCardByTag(string count, string tag = "all")
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.GetCardByTag(string, string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			count,
			tag
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						count = null;
					}
					else
					{
						count = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						tag = null;
					}
					else
					{
						tag = (string)arguments[1];
					}
				}
				this.$Rougamo_GetCardByTag(count, tag);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00016434 File Offset: 0x00014634
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void AddCard(string id)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddCard(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			id
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
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
				this.$Rougamo_AddCard(id);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0001650C File Offset: 0x0001470C
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeCareer(string Id)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeCareer(string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			Id
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						Id = null;
					}
					else
					{
						Id = (string)arguments[0];
					}
				}
				this.$Rougamo_ChangeCareer(Id);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x000165E4 File Offset: 0x000147E4
	[Rougamo(typeof(ForEachObjectNative))]
	[DebuggerStepThrough]
	public void AddEvent(string eventName, Action script)
	{
		ForEachObjectNative forEachObjectNative = default(ForEachObjectNative);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObjectNative
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddEvent(string, Action)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			eventName,
			script
		};
		try
		{
			forEachObjectNative.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						eventName = null;
					}
					else
					{
						eventName = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						script = null;
					}
					else
					{
						script = (Action)arguments[1];
					}
				}
				this.$Rougamo_AddEvent(eventName, script);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000261 RID: 609 RVA: 0x000166DC File Offset: 0x000148DC
	[Rougamo(typeof(ForEachObjectNative))]
	[DebuggerStepThrough]
	public void AddTempEvent(string eventName, Action script)
	{
		ForEachObjectNative forEachObjectNative = default(ForEachObjectNative);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObjectNative
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddTempEvent(string, Action)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			eventName,
			script
		};
		try
		{
			forEachObjectNative.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						eventName = null;
					}
					else
					{
						eventName = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						script = null;
					}
					else
					{
						script = (Action)arguments[1];
					}
				}
				this.$Rougamo_AddTempEvent(eventName, script);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000262 RID: 610 RVA: 0x000167D4 File Offset: 0x000149D4
	[Rougamo(typeof(ForEachObjectNative))]
	[DebuggerStepThrough]
	public void AddEvent<T>(string eventName, Action<T> datafrom) where T : ISourceData
	{
		ForEachObjectNative forEachObjectNative = default(ForEachObjectNative);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObjectNative
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddEvent(string, Action<T>)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			eventName,
			datafrom
		};
		try
		{
			forEachObjectNative.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						eventName = null;
					}
					else
					{
						eventName = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						datafrom = null;
					}
					else
					{
						datafrom = (Action<T>)arguments[1];
					}
				}
				this.$Rougamo_AddEvent<T>(eventName, datafrom);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000263 RID: 611 RVA: 0x000168CC File Offset: 0x00014ACC
	[Rougamo(typeof(ForEachObjectNative))]
	[DebuggerStepThrough]
	public void AddTempEvent<T>(string eventName, Action<T> datafrom) where T : ISourceData
	{
		ForEachObjectNative forEachObjectNative = default(ForEachObjectNative);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObjectNative
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.AddTempEvent(string, Action<T>)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			eventName,
			datafrom
		};
		try
		{
			forEachObjectNative.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						eventName = null;
					}
					else
					{
						eventName = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						datafrom = null;
					}
					else
					{
						datafrom = (Action<T>)arguments[1];
					}
				}
				this.$Rougamo_AddTempEvent<T>(eventName, datafrom);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000264 RID: 612 RVA: 0x000169C4 File Offset: 0x00014BC4
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeDynamicVar(string varName, string value)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeDynamicVar(string, string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			varName,
			value
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						varName = null;
					}
					else
					{
						varName = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						value = null;
					}
					else
					{
						value = (string)arguments[1];
					}
				}
				this.$Rougamo_ChangeDynamicVar(varName, value);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00016ABC File Offset: 0x00014CBC
	[Rougamo(typeof(ForEachObject))]
	[DebuggerStepThrough]
	public void ChangeDynamicVarPercent(string varName, string value)
	{
		ForEachObject forEachObject = default(ForEachObject);
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			forEachObject
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ScriptExecutor);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ScriptExecutor.ChangeDynamicVarPercent(string, string)).MethodHandle, typeof(ScriptExecutor).TypeHandle);
		methodContext.Arguments = new object[]
		{
			varName,
			value
		};
		try
		{
			forEachObject.OnEntry(methodContext);
			if (!methodContext.ReturnValueReplaced)
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						varName = null;
					}
					else
					{
						varName = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						value = null;
					}
					else
					{
						value = (string)arguments[1];
					}
				}
				this.$Rougamo_ChangeDynamicVarPercent(varName, value);
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	/// <summary>
	/// 未完成的效果占位
	/// </summary>
	// Token: 0x06000266 RID: 614 RVA: 0x000026D9 File Offset: 0x000008D9
	public void Undone(params object[] args)
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00016BB4 File Offset: 0x00014DB4
	public void DesEnemyAction()
	{
		List<IStatusManager> targetList = this.Object.ToList<IStatusManager>();
		for (int i = 0; i < targetList.Count; i++)
		{
			Enemy enemy = this.GetEnemy(targetList[i]);
			bool flag = enemy == null;
			if (!flag)
			{
				List<ObjectCard> tempList = enemy.ActionCards.ToList<ObjectCard>();
				int index = 0;
				foreach (ObjectCard item in tempList)
				{
					bool flag2 = item.dataConfig.data["Action"] == "Skill" || item.dataConfig.data["Action"] == "Attack";
					if (flag2)
					{
						enemy.AnnounceDesAction(index);
						break;
					}
					index++;
				}
			}
		}
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00016CBC File Offset: 0x00014EBC
	public FightType returnFightType()
	{
		FightManager instance = FightManager.Instance;
		return (instance != null) ? instance.fightType : FightType.None;
	}

	/// <summary>
	/// 焚毁某卡牌
	/// </summary>
	/// <param name="fromdata">该卡牌的数据配置</param>
	// Token: 0x06000269 RID: 617 RVA: 0x00016CE0 File Offset: 0x00014EE0
	public void BurnCardByData(IDataConfig fromdata)
	{
		List<IDataConfig> tempList = new List<IDataConfig>(FightCardManager.Instance.cardList);
		foreach (IDataConfig item in tempList)
		{
			bool flag = item == fromdata;
			if (flag)
			{
				FightCardManager.Instance.cardList.Remove(item as DataConfig);
			}
		}
		tempList = new List<IDataConfig>(FightCardManager.Instance.usedCardList);
		foreach (IDataConfig item2 in tempList)
		{
			bool flag2 = item2 == fromdata;
			if (flag2)
			{
				FightCardManager.Instance.usedCardList.Remove(item2 as DataConfig);
			}
		}
		foreach (CardItem item3 in this.HandCard)
		{
			bool flag3 = item3.dataConfig == fromdata;
			if (flag3)
			{
				item3.Burning(0f);
				break;
			}
		}
	}

	/// <summary>
	/// 更新遗物显示
	/// </summary>
	// Token: 0x0600026A RID: 618 RVA: 0x00016E30 File Offset: 0x00015030
	public void UpdateRelicShow()
	{
		bool flag = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<TopBarUI>("TopBarUI").UpdateRelicCountShow();
		}
	}

	/// <summary>
	/// 神启判定
	/// </summary>
	/// <param name="lastDataconfig">打出的牌</param>
	/// <returns></returns>
	// Token: 0x0600026B RID: 619 RVA: 0x00016E70 File Offset: 0x00015070
	public bool ComboCheck()
	{
		bool flag = this.Self == null;
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			IDataConfig lastDataconfig = ScriptExecutor.PlayerInfo.LastCard;
			int index = 0;
			bool hasCombo = false;
			foreach (DataConfig item in FightCardManager.Instance.cardList)
			{
				bool flag2 = FightCardManager.Instance.CardTags[item].Contains("Combo");
				if (flag2)
				{
					hasCombo = true;
					break;
				}
				index++;
			}
			bool flag3 = hasCombo;
			if (flag3)
			{
				DataConfig tempCard = FightCardManager.Instance.cardList[FightCardManager.Instance.cardList.Count - 1];
				FightCardManager.Instance.cardList[FightCardManager.Instance.cardList.Count - 1] = FightCardManager.Instance.cardList[index];
				FightCardManager.Instance.cardList[index] = tempCard;
				bool flag4 = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
				if (flag4)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").CreateCardItem(1);
				}
			}
			bool flag5 = lastDataconfig == null || FightCardManager.Instance.CardTags[lastDataconfig as DataConfig].Contains("Combo");
			if (flag5)
			{
				this.Self.AddBuff("buff_revelation", 1);
				result = true;
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00017000 File Offset: 0x00015200
	public void EndTheGame()
	{
		bool flag = UIManager.Instance.GetUI<EventUI>("EventUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<EventUI>("EventUI").Close();
		}
		UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00017050 File Offset: 0x00015250
	public void EscapeFight()
	{
		Fight_Win.IsWin = false;
		UniTask.WaitForSeconds(0.3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			this.ChangeType(ScriptExecutor.PlayerInfo.Win);
		}).Forget();
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00017091 File Offset: 0x00015291
	public void WinTheFight()
	{
		Fight_Win.IsWin = true;
		this.ChangeType(ScriptExecutor.PlayerInfo.Win);
	}

	// Token: 0x0600026F RID: 623 RVA: 0x000170A8 File Offset: 0x000152A8
	public void ChangeType(FightType type)
	{
		bool flag = FightManager.Instance == null;
		if (!flag)
		{
			FightManager.Instance.CmdChangeType(type);
		}
	}

	// Token: 0x06000270 RID: 624 RVA: 0x000170D4 File Offset: 0x000152D4
	public void RandomAddBuff(string count)
	{
		List<Dictionary<string, string>> buff = Singleton<GameConfigManager>.Instance.GetTable(DataType.Buff).Getlines().AsValueEnumerable<Dictionary<string, string>>().Where(delegate(Dictionary<string, string> x)
		{
			bool result2;
			if (!x["Id"].Contains("SpecialBuff_"))
			{
				string a = x["Type"];
				result2 = (a == "正面" || a == "负面");
			}
			else
			{
				result2 = false;
			}
			return result2;
		}).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
		int c = count.ToInt();
		bool flag = this.Object.Exists((IStatusManager item) => item.fatherObject is FightPlayer && ScriptExecutor.PlayerInfo.TempLucky >= 20);
		if (flag)
		{
			buff = (from x in buff.AsValueEnumerable<Dictionary<string, string>>()
			where x["Type"] != "负面"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
		}
		for (int i = 0; i < c; i++)
		{
			List<Dictionary<string, string>> result = new RandomPool(buff, this.DefaultDice.dice).DrawByCount(1);
			bool flag2 = result.Count > 0;
			if (flag2)
			{
				this.AddBuff(result[0]["Id"], "1");
			}
		}
	}

	// Token: 0x06000271 RID: 625 RVA: 0x000171E8 File Offset: 0x000153E8
	public void RandomAddBuffAndAbility(string count)
	{
		List<Dictionary<string, string>> buff = Singleton<GameConfigManager>.Instance.GetTable(DataType.Buff).Getlines().AsValueEnumerable<Dictionary<string, string>>().Where(delegate(Dictionary<string, string> x)
		{
			bool result2;
			if (!x["Id"].Contains("SpecialBuff_"))
			{
				string a = x["Type"];
				result2 = (a == "正面" || a == "负面" || a == "能力");
			}
			else
			{
				result2 = false;
			}
			return result2;
		}).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
		int c = count.ToInt();
		bool flag = this.Object.Exists((IStatusManager item) => item.fatherObject is FightPlayer && ScriptExecutor.PlayerInfo.TempLucky >= 20);
		if (flag)
		{
			buff = (from x in buff.AsValueEnumerable<Dictionary<string, string>>()
			where x["Type"] != "负面"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
		}
		for (int i = 0; i < c; i++)
		{
			List<Dictionary<string, string>> result = new RandomPool(buff, this.DefaultDice.dice).DrawByCount(1);
			bool flag2 = result.Count > 0;
			if (flag2)
			{
				this.AddBuff(result[0]["Id"], "1");
			}
		}
	}

	// Token: 0x06000272 RID: 626 RVA: 0x000172FC File Offset: 0x000154FC
	public void RandomAddGoodBuff()
	{
		List<Dictionary<string, string>> buff = new RandomPool((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Buff).Getlines().AsValueEnumerable<Dictionary<string, string>>()
		where !x["Id"].Contains("SpecialBuff_") && x["Type"] == "正面"
		select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), this.DefaultDice.dice).DrawByCount(1);
		this.AddBuff(buff[0]["Id"], "1");
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00017380 File Offset: 0x00015580
	public void AddEnemy(string id)
	{
		string InId = EnemyManager.Instance.AddEnemy(id);
		Singleton<EventCenter>.Instance.EventTrigger<NewEnemyData>("AddEnemy" + this.Self.InstanceId, new NewEnemyData(InId));
	}

	// Token: 0x06000274 RID: 628 RVA: 0x000173C0 File Offset: 0x000155C0
	public string atk()
	{
		string enemyAtk = "0";
		bool flag = this.Self == null;
		string result;
		if (flag)
		{
			result = "0";
		}
		else
		{
			bool flag2 = this.Self.fatherObject is Enemy;
			if (flag2)
			{
				Enemy enemy = this.Self.fatherObject as Enemy;
				bool flag3 = enemy != null;
				if (flag3)
				{
					enemyAtk = enemy.Attack.ToString();
					result = enemyAtk;
				}
				else
				{
					result = "0";
				}
			}
			else
			{
				bool flag4 = this.Self.fatherObject is Partner;
				if (flag4)
				{
					Partner partner = this.Self.fatherObject as Partner;
					bool flag5 = partner != null;
					if (flag5)
					{
						enemyAtk = partner.Attack.ToString();
						result = enemyAtk;
					}
					else
					{
						result = "0";
					}
				}
				else
				{
					result = enemyAtk;
				}
			}
		}
		return result;
	}

	// Token: 0x06000275 RID: 629 RVA: 0x000174A4 File Offset: 0x000156A4
	public void AddBaseEvent(string eventName, Action action)
	{
		Singleton<EventCenter>.Instance.AddEventListener(eventName, delegate()
		{
			action();
		}, this, EventDispose.OnFightEnd);
		bool flag = this.Self != null && !this.Self.IsNull();
		if (flag)
		{
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
			{
				"<color=grey>",
				this.Self.Name,
				"具体对象添加了事件监听",
				eventName,
				"</color>"
			}));
		}
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00017558 File Offset: 0x00015758
	public Enemy GetEnemy(IStatusManager status)
	{
		return status.fatherObject as Enemy;
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00017578 File Offset: 0x00015778
	public string def()
	{
		string enemyDef = "0";
		bool flag = this.Self.fatherObject is Enemy;
		string result;
		if (flag)
		{
			Enemy enemy = this.Self.fatherObject as Enemy;
			bool flag2 = enemy != null;
			if (flag2)
			{
				enemyDef = enemy.Defend.ToString();
				result = enemyDef;
			}
			else
			{
				result = "0";
			}
		}
		else
		{
			bool flag3 = this.Self.fatherObject is Partner;
			if (flag3)
			{
				Partner partner = this.Self.fatherObject as Partner;
				bool flag4 = partner != null;
				if (flag4)
				{
					enemyDef = partner.Defend.ToString();
					result = enemyDef;
				}
				else
				{
					result = "0";
				}
			}
			else
			{
				result = enemyDef;
			}
		}
		return result;
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00017644 File Offset: 0x00015844
	public void CallEffect()
	{
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
		if (flag)
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").CallActionAnimation(this);
		}
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00017684 File Offset: 0x00015884
	public void OnlineDamage(string val, string fromDataId, string fromId, string damagetype = "Normal")
	{
		bool flag = this.Self == null;
		if (!flag)
		{
			this.Self.Hit(val.ToInt(), damagetype, fromDataId, fromId);
			bool flag2 = this.Self != null && !this.Self.IsNull();
			if (flag2)
			{
				Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
				{
					fromId,
					"通过",
					fromDataId,
					"对",
					this.Self.Name,
					"造成了 <color=green>",
					val,
					"</color> 基础值点伤害"
				}));
			}
		}
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0001774C File Offset: 0x0001594C
	public void Damage(string val, string damagetype = "Normal")
	{
		List<IStatusManager> tempList = new List<IStatusManager>(this.Object);
		foreach (IStatusManager status in tempList)
		{
			int lastval = status.CurHp;
			Singleton<EventCenter>.Instance.EventTrigger("Attack" + this.Self.InstanceId);
			bool flag = damagetype != "True";
			if (flag)
			{
				bool flag2 = PlayerManager.Instance != null && (!Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(RoleTable.Instance.Id) || !Singleton<TempDataManager>.Instance.RoleStatusMap[RoleTable.Instance.Id].Contains(status.InstanceId)) && !this.Vars.ContainsKey("Online");
				if (flag2)
				{
					string conJosn = Singleton<GameConfigManager>.Instance.NativeIds.Contains(this.dataConfig.data["Id"]) ? "" : JsonConvert.SerializeObject(this.dataConfig.data);
					FightManager.Instance.CmdSendEvent("OnlineDamage", status.InstanceId, this.dataConfig.data["Id"], conJosn, new string[]
					{
						this.Self.DamageCalculate(val.ToInt()).ToString(),
						this.dataConfig.data["Id"],
						this.Self.InstanceId,
						damagetype
					});
					continue;
				}
				string val2 = this.Self.DamageCalculate(val.ToInt()).ToString();
				status.Hit(val2.ToInt(), damagetype, this.dataConfig.data["Id"], this.Self.InstanceId);
			}
			else
			{
				bool flag3 = PlayerManager.Instance != null && (!Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(RoleTable.Instance.Id) || !Singleton<TempDataManager>.Instance.RoleStatusMap[RoleTable.Instance.Id].Contains(status.InstanceId)) && !this.Vars.ContainsKey("Online");
				if (flag3)
				{
					string conJosn2 = Singleton<GameConfigManager>.Instance.NativeIds.Contains(this.dataConfig.data["Id"]) ? "" : JsonConvert.SerializeObject(this.dataConfig.data);
					FightManager.Instance.CmdSendEvent("OnlineDamage", status.InstanceId, this.dataConfig.data["Id"], conJosn2, new string[]
					{
						val,
						this.dataConfig.data["Id"],
						this.Self.InstanceId,
						damagetype
					});
					continue;
				}
				status.Hit(val.ToInt(), damagetype, this.dataConfig.data["Id"], this.Self.InstanceId);
			}
			int value = lastval - status.CurHp;
			bool flag4 = this.Self != null && !this.Self.IsNull();
			if (flag4)
			{
				Commands.Log(string.Concat(new string[]
				{
					"id为",
					this.Self.InstanceId,
					"<color=grey>",
					this.dataConfig.data.Localize("Name"),
					"</color>效果"
				}), string.Format("{0}对{1}造成了 <color=red>{2}</color> 点{3}", new object[]
				{
					this.Self.Name,
					status.Name,
					value,
					(damagetype + "Damage").Localize("Glossary")
				}));
			}
		}
		bool flag5 = damagetype != "True";
		if (flag5)
		{
			Singleton<EventCenter>.Instance.EventTrigger("AttackDone" + this.Self.InstanceId);
		}
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00017BB0 File Offset: 0x00015DB0
	public void ChangeVars(string type, string val)
	{
		List<IStatusManager> tempList = new List<IStatusManager>(this.Object);
		int val2 = val.ToInt();
		foreach (IStatusManager status in tempList)
		{
			bool flag = PlayerManager.Instance != null && (!Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(RoleTable.Instance.Id) || !Singleton<TempDataManager>.Instance.RoleStatusMap[RoleTable.Instance.Id].Contains(status.InstanceId)) && !this.Vars.ContainsKey("Online");
			if (flag)
			{
				string conJosn = Singleton<GameConfigManager>.Instance.NativeIds.Contains(this.dataConfig.data["Id"]) ? "" : JsonConvert.SerializeObject(this.dataConfig.data);
				FightManager.Instance.CmdSendEvent("ChangeVars", status.InstanceId, this.dataConfig.data["Id"], conJosn, new string[]
				{
					type,
					val
				});
				Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
				{
					status.InstanceId,
					"玩家增加了 <color=purple>",
					val,
					"</color> 点",
					type,
					"属性"
				}));
			}
			else
			{
				Enemy enemy = status.fatherObject as Enemy;
				bool flag2 = enemy != null;
				if (flag2)
				{
					status.ToughCount += val2;
				}
				FightPlayer player = status.fatherObject as FightPlayer;
				bool flag3 = player != null;
				if (flag3)
				{
					bool flag4 = !FightManager.Instance.TempVarsMap.ContainsKey(type);
					if (flag4)
					{
						break;
					}
					Dictionary<string, int> tempVarsMap = FightManager.Instance.TempVarsMap;
					tempVarsMap[type] += val2;
					UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeVar();
					Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
					{
						status.InstanceId,
						"玩家增加了 <color=purple>",
						val,
						"</color> 点",
						type,
						"属性"
					}));
				}
			}
		}
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00017E6C File Offset: 0x0001606C
	public void ThrowCard(string val, string type = "1")
	{
		List<IStatusManager> tempList = new List<IStatusManager>(this.Object);
		foreach (IStatusManager status in tempList)
		{
			bool flag = PlayerManager.Instance != null && (!Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(RoleTable.Instance.Id) || !Singleton<TempDataManager>.Instance.RoleStatusMap[RoleTable.Instance.Id].Contains(status.InstanceId)) && !this.Vars.ContainsKey("Online");
			if (flag)
			{
				string conJosn = Singleton<GameConfigManager>.Instance.NativeIds.Contains(this.dataConfig.data["Id"]) ? "" : JsonConvert.SerializeObject(this.dataConfig.data);
				FightManager.Instance.CmdSendEvent("ThrowCard", status.InstanceId, this.dataConfig.data["Id"], conJosn, new string[]
				{
					val,
					type
				});
				Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家丢弃了 <color=purple>" + val + "</color> 张卡牌");
			}
			else
			{
				FightPlayer player = status.fatherObject as FightPlayer;
				bool flag2 = player != null;
				if (flag2)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").ThrowCardScript(val, type);
					Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家丢弃了 <color=purple>" + val + "</color> 张卡牌");
				}
				else
				{
					Enemy enemy = status.fatherObject as Enemy;
					bool flag3 = enemy != null;
					if (flag3)
					{
						status.ToughCount -= val.ToInt();
					}
					else
					{
						Partner partner = status.fatherObject as Partner;
						bool flag4 = partner != null;
						if (flag4)
						{
							status.ToughCount -= val.ToInt();
						}
					}
				}
			}
		}
	}

	// Token: 0x0600027D RID: 637 RVA: 0x000180C8 File Offset: 0x000162C8
	public void BurnCard(string val, string type = "1")
	{
		List<IStatusManager> tempList = new List<IStatusManager>(this.Object);
		foreach (IStatusManager status in tempList)
		{
			bool flag = PlayerManager.Instance != null && (!Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(RoleTable.Instance.Id) || !Singleton<TempDataManager>.Instance.RoleStatusMap[RoleTable.Instance.Id].Contains(status.InstanceId)) && !this.Vars.ContainsKey("Online");
			if (flag)
			{
				string conJosn = Singleton<GameConfigManager>.Instance.NativeIds.Contains(this.dataConfig.data["Id"]) ? "" : JsonConvert.SerializeObject(this.dataConfig.data);
				FightManager.Instance.CmdSendEvent("BurnCard", status.InstanceId, this.dataConfig.data["Id"], conJosn, new string[]
				{
					val,
					type
				});
				Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家焚毁了 <color=purple>" + val + "</color> 张卡牌");
			}
			else
			{
				FightPlayer player = status.fatherObject as FightPlayer;
				bool flag2 = player != null;
				if (flag2)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").Burning(val, type);
					Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家焚毁了 <color=purple>" + val + "</color> 张卡牌");
				}
			}
		}
	}

	// Token: 0x0600027E RID: 638 RVA: 0x000182C4 File Offset: 0x000164C4
	public List<Dictionary<string, string>> GetcardsByRarity(string Minrarity, string Maxrairty)
	{
		return (from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Card).Getlines().AsValueEnumerable<Dictionary<string, string>>()
		where x["Rarity"].ToInt() >= Minrarity.ToInt() && x["Rarity"].ToInt() <= Maxrairty.ToInt() && !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"])
		select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00018318 File Offset: 0x00016518
	public DataConfig EnchGetCard()
	{
		using (Dictionary<string, DataConfig>.Enumerator enumerator = RoleTable.Instance.enchasedDict.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, DataConfig> item = enumerator.Current;
				bool flag = item.Value == this.dataConfig;
				if (flag)
				{
					bool flag2 = RoleTable.Instance.cardList.Any((DataConfig x) => x.InstanceID == item.Key);
					if (flag2)
					{
						return RoleTable.Instance.cardList.First((DataConfig x) => x.InstanceID == item.Key);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x000183D8 File Offset: 0x000165D8
	public DataConfig CardGetEnch(IDataConfig card)
	{
		bool flag = card == null;
		DataConfig result;
		if (flag)
		{
			result = null;
		}
		else
		{
			bool flag2 = RoleTable.Instance.enchasedDict.ContainsKey(card.InstanceID);
			if (flag2)
			{
				result = RoleTable.Instance.enchasedDict[card.InstanceID];
			}
			else
			{
				result = null;
			}
		}
		return result;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0001842C File Offset: 0x0001662C
	[DebuggerStepThrough]
	public UniTask AddCardByDeck(string count, List<IDataConfig> source, string tag = "all")
	{
		ScriptExecutor.<AddCardByDeck>d__62 <AddCardByDeck>d__ = new ScriptExecutor.<AddCardByDeck>d__62();
		<AddCardByDeck>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddCardByDeck>d__.<>4__this = this;
		<AddCardByDeck>d__.count = count;
		<AddCardByDeck>d__.source = source;
		<AddCardByDeck>d__.tag = tag;
		<AddCardByDeck>d__.<>1__state = -1;
		<AddCardByDeck>d__.<>t__builder.Start<ScriptExecutor.<AddCardByDeck>d__62>(ref <AddCardByDeck>d__);
		return <AddCardByDeck>d__.<>t__builder.Task;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00018488 File Offset: 0x00016688
	[DebuggerStepThrough]
	public void SelectCardAndAddTag(string count, List<IDataConfig> source)
	{
		ScriptExecutor.<SelectCardAndAddTag>d__63 <SelectCardAndAddTag>d__ = new ScriptExecutor.<SelectCardAndAddTag>d__63();
		<SelectCardAndAddTag>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		<SelectCardAndAddTag>d__.<>4__this = this;
		<SelectCardAndAddTag>d__.count = count;
		<SelectCardAndAddTag>d__.source = source;
		<SelectCardAndAddTag>d__.<>1__state = -1;
		<SelectCardAndAddTag>d__.<>t__builder.Start<ScriptExecutor.<SelectCardAndAddTag>d__63>(ref <SelectCardAndAddTag>d__);
	}

	// Token: 0x06000283 RID: 643 RVA: 0x000184D0 File Offset: 0x000166D0
	public void AddCardById(string id)
	{
		DataConfig dataConfig = new DataConfig(id, DataType.Card);
		FightCardManager.Instance.cardList.Add(dataConfig);
		FightCardManager.Instance.CardTags.Add(dataConfig, new HashSet<string>());
		dataConfig.Vars["Tag"].Replace(" ", "");
		foreach (string item in dataConfig.Vars["Tag"].Split(new char[]
		{
			'|',
			',',
			'，',
			' ',
			';',
			'；'
		}))
		{
			FightCardManager.Instance.CardTags[dataConfig].Add(item);
		}
		UIManager.Instance.GetUI<FightUI>("FightUI").CreateCardItem(1);
		Commands.Log("<color=grey>" + dataConfig.data.Localize("Name") + "</color>效果", "玩家添加了一张卡牌" + this.dataConfig.data.Localize("Name"));
	}

	// Token: 0x06000284 RID: 644 RVA: 0x000185DC File Offset: 0x000167DC
	public void SetStatusById(string searchId)
	{
		StatusManager target;
		bool flag = FightManager.Instance.statuses.TryGetValue(searchId, out target);
		if (flag)
		{
			this.Object.Clear();
			this.Object.Add(target);
		}
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0001861C File Offset: 0x0001681C
	public List<IStatusManager> SetStatus(string filter)
	{
		List<IStatusManager> result = new List<IStatusManager>();
		this.Object.Clear();
		bool exSelf = filter.Contains("ExSelf");
		filter = filter.Replace("ExSelf", "");
		bool isRandom = filter.StartsWith("AllRandom");
		bool flag = isRandom;
		if (flag)
		{
			filter = filter.Replace("AllRandom", "");
		}
		int count = 1;
		string numberStr = new string(filter.AsValueEnumerable<char>().Where(new Func<char, bool>(char.IsDigit)).ToArray<FromEnumerable<char>, char>());
		bool flag2 = !string.IsNullOrEmpty(numberStr);
		if (flag2)
		{
			count = numberStr.ToInt();
			filter = filter.Replace(numberStr, "");
		}
		bool flag3 = filter.StartsWith("All");
		string range;
		string type;
		if (flag3)
		{
			range = "All";
			type = filter.Substring(3);
		}
		else
		{
			range = filter;
			type = filter;
		}
		bool flag4 = !isRandom;
		if (flag4)
		{
			bool flag5 = range == "Self";
			if (flag5)
			{
				result.Add(this.Self);
				this.Object.Clear();
				this.Object.AddRange(result);
				return this.Object;
			}
			bool flag6 = range == "Target";
			if (flag6)
			{
				bool flag7 = this.Self.fatherObject is Enemy;
				if (flag7)
				{
					FightPlayer instance = FightPlayer.Instance;
					this.Target = ((instance != null) ? instance.Status : null);
					result.AddRange((from r in FightManager.Instance.roleQueue
					select FightManager.Instance.statuses[r.InstanceId]).ToArray<StatusManager>());
					this.Object.Clear();
					this.Object.AddRange(result);
					return this.Object;
				}
				bool flag8 = !(this.Self.fatherObject is Enemy) && (EnemyManager.Instance == null || EnemyManager.Instance.enemyList.Count == 0);
				if (flag8)
				{
					return this.Object;
				}
				bool flag9 = (this.Self.fatherObject is FightPlayer || this.Self.fatherObject is Partner) && this.Target == null;
				if (flag9)
				{
					this.Target = EnemyManager.Instance.enemyList[0].Status;
				}
				bool flag10 = this.Target != null;
				if (flag10)
				{
					result.Add(this.Target);
					this.Object.Clear();
					this.Object.AddRange(result);
				}
				return this.Object;
			}
			else
			{
				bool flag11;
				if (range == "Player")
				{
					FightPlayer instance2 = FightPlayer.Instance;
					flag11 = (((instance2 != null) ? instance2.Status : null) != null);
				}
				else
				{
					flag11 = false;
				}
				bool flag12 = flag11;
				if (flag12)
				{
					result.Add(FightPlayer.Instance.Status);
					this.Object.Clear();
					this.Object.AddRange(result);
					return this.Object;
				}
			}
		}
		List<IStatusManager> candidates = new List<IStatusManager>();
		bool isFriend = type.Contains("Friends");
		bool isTarget = type.Contains("Target");
		bool flag13 = isTarget;
		if (flag13)
		{
			bool flag14 = this.Self.fatherObject is Enemy && FightPlayer.Instance != null && FightPlayer.Instance.Status != null;
			if (flag14)
			{
				candidates.Add(FightPlayer.Instance.Status);
			}
			else
			{
				candidates.AddRange((from e in EnemyManager.Instance.enemyList.AsValueEnumerable<Enemy>()
				where e != null && e.enabled && e.Status != null && e.Status.state != IStatusManager.State.Dead
				select e.Status).ToArray<Enemy, IStatusManager>());
			}
		}
		else
		{
			bool flag15 = isFriend;
			if (flag15)
			{
				bool flag16 = this.Self.fatherObject is Enemy;
				if (flag16)
				{
					candidates.AddRange((from e in EnemyManager.Instance.enemyList.AsValueEnumerable<Enemy>()
					where e != null && e.enabled && e.Status != null && e.Status.state != IStatusManager.State.Dead
					select e.Status).ToArray<Enemy, IStatusManager>());
				}
				else
				{
					candidates.AddRange((from r in FightManager.Instance.roleQueue
					select FightManager.Instance.statuses[r.InstanceId]).ToArray<StatusManager>());
				}
			}
			else
			{
				bool flag17 = range == "All";
				if (flag17)
				{
					candidates.AddRange((from e in EnemyManager.Instance.enemyList.AsValueEnumerable<Enemy>()
					where e != null && e.enabled && e.Status.state != IStatusManager.State.Dead
					select e.Status).ToArray<Enemy, IStatusManager>());
					candidates.AddRange((from r in FightManager.Instance.roleQueue
					select FightManager.Instance.statuses[r.InstanceId]).ToArray<StatusManager>());
				}
			}
		}
		bool flag18 = exSelf;
		if (flag18)
		{
			candidates = (from c in candidates.AsValueEnumerable<IStatusManager>()
			where c != this.Self
			select c).ToList<ListWhere<IStatusManager>, IStatusManager>();
		}
		bool flag19 = isRandom;
		if (flag19)
		{
			ValueEnumerable<OrderBySkipTake<FromList<IStatusManager>, IStatusManager, int>, IStatusManager> randomList = (from _ in candidates.AsValueEnumerable<IStatusManager>()
			orderby this.DefaultDice.Roll(null).Value
			select _).Take(Math.Min(count, candidates.Count));
			using (ValueEnumerator<OrderBySkipTake<FromList<IStatusManager>, IStatusManager, int>, IStatusManager> enumerator = randomList.GetEnumerator<OrderBySkipTake<FromList<IStatusManager>, IStatusManager, int>, IStatusManager>())
			{
				while (enumerator.MoveNext())
				{
					IStatusManager obj = enumerator.Current;
					result.Add(obj);
				}
			}
		}
		else
		{
			foreach (IStatusManager obj2 in candidates)
			{
				result.Add(obj2);
			}
		}
		this.Object.Clear();
		this.Object.AddRange(result);
		return this.Object;
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00018CC8 File Offset: 0x00016EC8
	public List<IStatusManager> SetStatus(IEnumerable<IStatusManager> statuses)
	{
		List<IStatusManager> tempList = new List<IStatusManager>(statuses);
		this.Object.Clear();
		this.Object.AddRange(tempList);
		return this.Object;
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00018D00 File Offset: 0x00016F00
	public List<IStatusManager> SetStatus(ValueEnumerable<FromEnumerable<IStatusManager>, IStatusManager> statuses)
	{
		this.Object.Clear();
		this.Object.AddRange(statuses.ToList<FromEnumerable<IStatusManager>, IStatusManager>());
		return this.Object;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00018D36 File Offset: 0x00016F36
	public void ProcessEffect(IStatusManager status, string effectName)
	{
		Singleton<EffectManager>.Instance.PlayEffect(status, effectName);
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00018D48 File Offset: 0x00016F48
	public void DiceCheck(int percent, Action<bool> action)
	{
		int value = this.CheckDice.Roll(null).Value;
		action(value <= percent);
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00018D80 File Offset: 0x00016F80
	public void ForAllStatus(Action<IStatusManager> action)
	{
		List<IStatusManager> tmpObject = this.Object.ToList<IStatusManager>();
		foreach (IStatusManager status in tmpObject)
		{
			this.Object.Clear();
			this.Object.Add(status);
			action(status);
		}
		this.Object.Clear();
		this.Object.AddRange(tmpObject);
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00018E14 File Offset: 0x00017014
	public void Log(string content)
	{
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>日志", content);
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00018E42 File Offset: 0x00017042
	public void WatchRoleTable(string propertyName, Action action)
	{
		this.handlers.Add(Singleton<PropertyWatcher>.Instance.AddListener(RoleTable.Instance, propertyName, action));
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00018E61 File Offset: 0x00017061
	public void WatchRoleTable(string propertyName, Action<int> action)
	{
		this.handlers.Add(Singleton<PropertyWatcher>.Instance.AddListener(RoleTable.Instance, propertyName, action));
	}

	/// <summary>
	/// 添加新DesVal
	/// </summary>
	/// <param name="index">下标</param>
	/// <param name="type">类型</param>
	/// <param name="value">原始值</param>
	// Token: 0x0600028E RID: 654 RVA: 0x00018E80 File Offset: 0x00017080
	public void AddDescription(string index, string type, string value)
	{
		int indexInt;
		int.TryParse(index, out indexInt);
		bool flag = indexInt == 0 && index != "0";
		if (flag)
		{
			Commands.Log("<color=red>错误</color>", "无法添加描述值，索引 " + index + " 不是有效的数字。");
		}
		else
		{
			string key = "DesVal" + index;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(type);
			if (num <= 1357586565U)
			{
				if (num <= 484614851U)
				{
					if (num != 258809395U)
					{
						if (num == 484614851U)
						{
							if (type == "Defence")
							{
								value = ((this.Self != null) ? this.Self.DefenceCalculate(value.ToInt()).ToString() : value.ToInt().ToString());
							}
						}
					}
					else if (type == "Draw")
					{
						value = ScriptExecutor.<AddDescription>g__WrapByColor|76_0(value.ToInt().ToString(), "white");
					}
				}
				else if (num != 771216480U)
				{
					if (num != 1092211647U)
					{
						if (num == 1357586565U)
						{
							if (type == "Hp")
							{
								value = ScriptExecutor.<AddDescription>g__WrapByColor|76_0(value.ToInt().ToString(), "white");
							}
						}
					}
					else if (type == "MultiDamage")
					{
						value = ((this.Self != null) ? (this.Self.DamageCalculate(value.Split("*", StringSplitOptions.None)[0].ToInt().ToInt()).ToString() + "*" + value.Split("*", StringSplitOptions.None)[1]) : (value.Split("*", StringSplitOptions.None)[0].ToInt().ToString() + "*" + value.Split("*", StringSplitOptions.None)[1]));
						bool flag2 = !this.Target.IsNull();
						if (flag2)
						{
							int trueValue = this.Target.UnDamageCalucate(value.Split("*", StringSplitOptions.None)[0].ToInt());
							bool flag3 = this.Target.fatherObject is Enemy && this.Target.ToughCount == 0;
							if (flag3)
							{
								trueValue = (int)((float)trueValue * 1.5f);
							}
							bool flag4 = trueValue < 0;
							if (flag4)
							{
								trueValue = 0;
							}
							value = trueValue.ToString() + "*" + value.Split("*", StringSplitOptions.None)[1];
						}
					}
				}
				else if (type == "Damage")
				{
					value = ((this.Self != null) ? this.Self.DamageCalculate(value.ToInt()).ToString() : value.ToInt().ToString());
					bool flag5 = !this.Target.IsNull();
					if (flag5)
					{
						int trueValue2 = this.Target.UnDamageCalucate(value.ToInt());
						bool flag6 = this.Target.fatherObject is Enemy && this.Target.ToughCount == 0;
						if (flag6)
						{
							trueValue2 = (int)((float)trueValue2 * 1.5f);
						}
						bool flag7 = trueValue2 < 0;
						if (flag7)
						{
							trueValue2 = 0;
						}
						int num2 = trueValue2 - value.ToInt();
						if (!true)
						{
						}
						string text;
						if (num2 <= 0)
						{
							if (num2 >= 0)
							{
								text = "white";
							}
							else
							{
								text = "red";
							}
						}
						else
						{
							text = "green";
						}
						if (!true)
						{
						}
						string color = text;
						value = ScriptExecutor.<AddDescription>g__WrapByColor|76_0(trueValue2.ToString(), color);
					}
				}
			}
			else if (num <= 3008056303U)
			{
				if (num != 2500535712U)
				{
					if (num != 2970340076U)
					{
						if (num == 3008056303U)
						{
							if (type == "Money")
							{
								value = ScriptExecutor.<AddDescription>g__WrapByColor|76_0(value.ToInt().ToString(), "white");
							}
						}
					}
					else if (type == "Buff")
					{
						value = ScriptExecutor.<AddDescription>g__WrapByColor|76_0(value.ToInt().ToString(), "white");
					}
				}
				else if (type == "TrueDamage")
				{
					value = value.ToInt().ToString();
				}
			}
			else if (num != 3343492582U)
			{
				if (num != 3511155050U)
				{
					if (num == 4279580666U)
					{
						if (type == "Percent")
						{
							value = ScriptExecutor.<AddDescription>g__WrapByColor|76_0(float.Parse(value).ToString("P0"), "white");
						}
					}
				}
				else if (type == "Value")
				{
					value = ScriptExecutor.<AddDescription>g__WrapByColor|76_0(value.ToInt().ToString(), "white");
				}
			}
			else if (type == "Power")
			{
				value = ScriptExecutor.<AddDescription>g__WrapByColor|76_0(value.ToInt().ToString(), "white");
			}
			this.Vars[key] = value;
		}
	}

	// Token: 0x0600028F RID: 655 RVA: 0x000193F0 File Offset: 0x000175F0
	public string GetDesValue(string index)
	{
		int indexInt;
		int.TryParse(index, out indexInt);
		bool flag = indexInt == 0 && index != "0";
		string result;
		if (flag)
		{
			Commands.Log("<color=red>错误</color>", "无法获取描述值，索引 " + index + " 不是有效的数字。");
			result = "";
		}
		else
		{
			string key = "DesVal" + index;
			bool flag2 = this.Vars.ContainsKey(key);
			if (flag2)
			{
				string rawValue = this.Vars[key];
				result = Regex.Replace(rawValue, "<.*?>", "");
			}
			else
			{
				result = "0";
			}
		}
		return result;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0001948B File Offset: 0x0001768B
	public void AddDescription(string index, string type, int value)
	{
		this.AddDescription(index, type, value.ToString());
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0001949D File Offset: 0x0001769D
	public void AddDescription(string index, string type, float value)
	{
		this.AddDescription(index, type, value.ToString());
	}

	// Token: 0x06000292 RID: 658 RVA: 0x000194AF File Offset: 0x000176AF
	public void AddDescription(string index, string type, double value)
	{
		this.AddDescription(index, type, value.ToString());
	}

	// Token: 0x06000293 RID: 659 RVA: 0x000194C4 File Offset: 0x000176C4
	public void CallScript(string scriptId, string scriptName)
	{
		DataConfig script = new DataConfig(Singleton<GameConfigManager>.Instance.DataConfigCache[scriptId].data, this.dataConfig.Vars, true)
		{
			scriptExecutor = 
			{
				Self = this.Self
			}
		};
		script.scriptExecutor.Object.Clear();
		script.scriptExecutor.Object.AddRange(this.Object);
		script.scriptExecutor.Target = this.Target;
		script.scriptExecutor.RunScript(scriptName);
	}

	/// <summary>
	/// 正在执行的对象
	/// </summary>
	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000294 RID: 660 RVA: 0x00019552 File Offset: 0x00017752
	// (set) Token: 0x06000295 RID: 661 RVA: 0x0001955A File Offset: 0x0001775A
	public IStatusManager status { get; set; }

	/// <summary>效果施放者</summary>
	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000296 RID: 662 RVA: 0x00019563 File Offset: 0x00017763
	// (set) Token: 0x06000297 RID: 663 RVA: 0x0001956B File Offset: 0x0001776B
	public IStatusManager Self { get; set; }

	/// <summary>效果对象</summary>
	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000298 RID: 664 RVA: 0x00019574 File Offset: 0x00017774
	// (set) Token: 0x06000299 RID: 665 RVA: 0x0001957C File Offset: 0x0001777C
	public List<IStatusManager> Object { get; set; } = new List<IStatusManager>();

	/// <summary>效果数据配置</summary>
	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600029A RID: 666 RVA: 0x00019585 File Offset: 0x00017785
	// (set) Token: 0x0600029B RID: 667 RVA: 0x0001958D File Offset: 0x0001778D
	public IDataConfig dataConfig { get; set; }

	/// <summary>效果目标（如有）</summary>
	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600029C RID: 668 RVA: 0x00019596 File Offset: 0x00017796
	// (set) Token: 0x0600029D RID: 669 RVA: 0x0001959E File Offset: 0x0001779E
	public IStatusManager Target { get; set; }

	/// <summary>所有脚本字典</summary>
	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600029E RID: 670 RVA: 0x000195A7 File Offset: 0x000177A7
	// (set) Token: 0x0600029F RID: 671 RVA: 0x000195AF File Offset: 0x000177AF
	public Dictionary<string, Delegate> ScriptDict { get; set; } = new Dictionary<string, Delegate>();

	/// <summary> 自己的Id </summary>
	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060002A0 RID: 672 RVA: 0x000195B8 File Offset: 0x000177B8
	public string Id
	{
		get
		{
			return this.Vars["Id"];
		}
	}

	/// <summary>骰子包装器</summary>
	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060002A1 RID: 673 RVA: 0x000195CA File Offset: 0x000177CA
	public ScriptExecutor.DiceWrapper ValueDice
	{
		get
		{
			return (FightManager.Instance != null) ? FightManager.Instance.ValueDice : null;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060002A2 RID: 674 RVA: 0x000195E6 File Offset: 0x000177E6
	public ScriptExecutor.DiceWrapper CheckDice
	{
		get
		{
			return (FightManager.Instance != null) ? FightManager.Instance.CheckDice : null;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060002A3 RID: 675 RVA: 0x00019602 File Offset: 0x00017802
	public ScriptExecutor.DiceWrapper DefaultDice
	{
		get
		{
			return (FightManager.Instance != null) ? FightManager.Instance.DefaultDice : null;
		}
	}

	/// <summary>持久化变量字典</summary>
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060002A4 RID: 676 RVA: 0x0001961E File Offset: 0x0001781E
	public IDictionary<string, string> Vars
	{
		get
		{
			return this.dataConfig.Vars;
		}
	}

	/// <summary>手牌列表</summary>
	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060002A5 RID: 677 RVA: 0x0001962B File Offset: 0x0001782B
	public List<CardItem> HandCard
	{
		get
		{
			return FightUI.cardItemList ?? new List<CardItem>();
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060002A6 RID: 678 RVA: 0x0001963B File Offset: 0x0001783B
	// (set) Token: 0x060002A7 RID: 679 RVA: 0x00019643 File Offset: 0x00017843
	public bool CompiledSuccessfully { get; private set; } = true;

	// Token: 0x060002A8 RID: 680 RVA: 0x0001964C File Offset: 0x0001784C
	static ScriptExecutor()
	{
		List<MetadataReference> assemblys = new List<MetadataReference>();
		assemblys.AddRange(ScriptExecutor.LoadMetadataFromName("PE"));
		ScriptExecutor.options = ScriptOptions.Default.AddReferences(assemblys).AddImports(new string[]
		{
			"System",
			"System.Collections.Generic",
			"System.Linq",
			"UnityEngine"
		}).WithMetadataResolver(new LockedMetadataResolver(ScriptMetadataResolver.Default));
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x000196C8 File Offset: 0x000178C8
	private static PortableExecutableReference[] LoadMetadataFromName(string assemblyName)
	{
		List<byte[]> bytes = (from b in Addressables.LoadAssetsAsync<TextAsset>(assemblyName ?? "", null).WaitForCompletion()
		select b.bytes).ToList<byte[]>();
		List<PortableExecutableReference> references = new List<PortableExecutableReference>();
		foreach (byte[] byteArray in bytes)
		{
			references.Add(MetadataReference.CreateFromImage(byteArray, default(MetadataReferenceProperties), null, null));
		}
		return references.ToArray();
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00019784 File Offset: 0x00017984
	private static void InitLuaEnv()
	{
		ScriptExecutor.luaEnv = new LuaEnv();
		ScriptExecutor.luaTable = ScriptExecutor.luaEnv.NewTable();
		LuaTable meta = ScriptExecutor.luaEnv.NewTable();
		meta.Set<string, LuaTable>("__index", ScriptExecutor.luaEnv.Global);
		ScriptExecutor.luaTable.SetMetaTable(meta);
		ScriptExecutor.luaEnv.Global.Set<string, LuaTable>("self", ScriptExecutor.luaTable);
		ScriptExecutor.luaTable.Set<string, Type>("ScriptExecutor", typeof(ScriptExecutor));
		ScriptExecutor.luaTable.Set<string, Type>("PlayerInfo", typeof(ScriptExecutor.PlayerInfo));
		ScriptExecutor.luaEnv.AddLoader(delegate(ref string path)
		{
			bool flag = !path.StartsWith("Mods");
			byte[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				path = ResourceLoader.ResolveModPath(path);
				result = File.ReadAllBytes(path);
			}
			return result;
		});
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00019850 File Offset: 0x00017A50
	private void InitLuaEnvInstance(string luaScript = null)
	{
		this.scriptExecutorEnv = ScriptExecutor.luaEnv.NewTable();
		LuaTable meta = ScriptExecutor.luaEnv.NewTable();
		meta.Set<string, LuaTable>("__index", ScriptExecutor.luaTable);
		this.scriptExecutorEnv.SetMetaTable(meta);
		meta.Dispose();
		this.scriptExecutorEnv.Set<string, ScriptExecutor>("self", this);
		this.scriptExecutorEnv.Set<string, Type>("PlayerInfo", typeof(ScriptExecutor.PlayerInfo));
		string luaPath = Application.streamingAssetsPath + " /LuaSource/" + this.dataConfig.data["Id"];
		bool flag = luaScript == null && File.Exists(luaPath + ".lua");
		if (flag)
		{
			ScriptExecutor.luaEnv.DoString(File.ReadAllText(luaPath + ".lua"), this.dataConfig.data["Id"], this.scriptExecutorEnv);
			foreach (string key in this.dataConfig.data.Keys)
			{
				bool flag2 = !key.Contains("Script");
				if (!flag2)
				{
					LuaFunction func = this.scriptExecutorEnv.Get<LuaFunction>(key);
					bool flag3 = func != null;
					if (flag3)
					{
						this.ScriptDict[key] = new Action<ScriptExecutor>(delegate(ScriptExecutor executor)
						{
							executor.CallLuaFunc(func);
						});
					}
				}
			}
		}
		else
		{
			bool flag4 = !string.IsNullOrEmpty(luaScript);
			if (flag4)
			{
				ScriptExecutor.luaEnv.DoString(luaScript, this.dataConfig.data["Id"], this.scriptExecutorEnv);
				foreach (string key2 in this.dataConfig.data.Keys)
				{
					bool flag5 = !key2.Contains("Script");
					if (!flag5)
					{
						LuaFunction func = this.scriptExecutorEnv.Get<LuaFunction>(key2);
						bool flag6 = func != null;
						if (flag6)
						{
							this.ScriptDict[key2] = new Action<ScriptExecutor>(delegate(ScriptExecutor executor)
							{
								executor.CallLuaFunc(func);
							});
						}
					}
				}
			}
		}
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00019AD4 File Offset: 0x00017CD4
	internal object[] CallLuaFunc(LuaFunction func)
	{
		object[] result;
		try
		{
			bool flag = func == null;
			if (flag)
			{
				Debug.LogError(this.dataConfig.data["Id"] + " 的 Lua 脚本执行时发生错误！函数为空\n");
				result = null;
			}
			else
			{
				bool flag2 = this.scriptExecutorEnv == null;
				if (flag2)
				{
					this.InitLuaEnvInstance(null);
					bool flag3 = this.scriptExecutorEnv == null;
					if (flag3)
					{
						Debug.LogError(this.dataConfig.data["Id"] + " 的 Lua 脚本执行时发生错误！环境为空\n");
						return null;
					}
				}
				func.SetEnv(this.scriptExecutorEnv);
				result = func.Call(Array.Empty<object>());
			}
		}
		catch (Exception e)
		{
			this.CompiledSuccessfully = false;
			string str = this.dataConfig.data["Id"];
			string str2 = " 的 Lua 脚本执行时发生错误！\n";
			Exception ex = e;
			Debug.LogError(str + str2 + ((ex != null) ? ex.ToString() : null) + "\n");
			result = null;
		}
		return result;
	}

	/// <summary>
	/// 初始化脚本执行器，加载预编译脚本
	/// </summary>
	// Token: 0x060002AD RID: 685 RVA: 0x00019BDC File Offset: 0x00017DDC
	internal static void Init()
	{
		ScriptExecutor.InitLuaEnv();
		Assembly assembly = Assembly.LoadFile(Path.Combine(Application.dataPath, "AssemblyCache/AllScripts.dll"));
		bool flag = assembly == null;
		if (flag)
		{
			Debug.LogError("AllScripts.cache未加载，请检查资源是否正确加载");
		}
		else
		{
			FieldInfo totalScriptsField = assembly.GetType("AllScripts.AllScripts").GetField("totalScripts", BindingFlags.Static | BindingFlags.Public);
			bool flag2 = totalScriptsField == null;
			if (flag2)
			{
				Debug.LogError("AllScripts.cache中未找到totalScripts字段");
			}
			else
			{
				ScriptExecutor.AllScriptDict = (totalScriptsField.GetValue(null) as Dictionary<string, Action<ScriptExecutor>>);
				bool flag3 = ScriptExecutor.AllScriptDict == null;
				if (flag3)
				{
					Debug.LogError("AllScripts.cache中的totalScripts字段值为null");
				}
			}
		}
	}

	/// <summary>
	/// 构造函数
	/// </summary>
	/// <param name="status">战斗状态管理器</param>
	/// <param name="dataConfig">数据配置</param>
	// Token: 0x060002AE RID: 686 RVA: 0x00019C80 File Offset: 0x00017E80
	internal ScriptExecutor(StatusManager status, DataConfig dataConfig)
	{
		this.Self = status;
		this.Object.Add(this.Self);
		this.dataConfig = dataConfig;
	}

	/// <summary>
	/// 构造函数
	/// </summary>
	/// <param name="dataConfig">数据配置</param>
	// Token: 0x060002AF RID: 687 RVA: 0x00019CEC File Offset: 0x00017EEC
	internal ScriptExecutor(DataConfig dataConfig)
	{
		this.dataConfig = dataConfig;
	}

	/// <summary>
	/// 创建委托
	/// </summary>
	/// <param name="Id">脚本ID</param>
	/// <param name="scriptType">脚本类型</param>
	/// <returns></returns>
	// Token: 0x060002B0 RID: 688 RVA: 0x00019D3C File Offset: 0x00017F3C
	private Delegate CreateDelegate(string Id, string scriptType)
	{
		string safeId = ScriptExecutor.<CreateDelegate>g__MakeSafeIdentifier|138_0(Id);
		string safeScriptType = ScriptExecutor.<CreateDelegate>g__MakeSafeIdentifier|138_0(scriptType);
		string key = safeId + "_" + safeScriptType;
		return (ScriptExecutor.AllScriptDict != null && ScriptExecutor.AllScriptDict.ContainsKey(key)) ? ScriptExecutor.AllScriptDict[key] : null;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00019D8C File Offset: 0x00017F8C
	private Delegate CreateDelegateFromLua(string ScriptName)
	{
		string Script = this.dataConfig.data[ScriptName];
		return new Action<ScriptExecutor>(delegate(ScriptExecutor executor)
		{
			executor.CallLuaFunc(ScriptExecutor.luaEnv.LoadString(Script, ScriptName, null));
		});
	}

	/// <summary>
	/// 预编译脚本
	/// </summary>
	/// <param name="ScriptName">脚本名</param>
	/// <param name="options">编译设置</param>
	// Token: 0x060002B2 RID: 690 RVA: 0x00019DD4 File Offset: 0x00017FD4
	public void PreCompileScripts(string ScriptName, ScriptOptions options = null)
	{
		bool flag = !this.dataConfig.data.ContainsKey(ScriptName);
		if (flag)
		{
			Debug.LogError(this.dataConfig.data["Id"] + "找不到脚本" + ScriptName);
		}
		else
		{
			string Scripts = this.dataConfig.data[ScriptName];
			bool flag2 = string.IsNullOrEmpty(Scripts);
			if (!flag2)
			{
				Delegate action = null;
				action = this.CreateDelegate(this.dataConfig.data["Id"], ScriptName);
				bool flag3 = action == null;
				if (flag3)
				{
					bool flag4 = this.scriptExecutorEnv == null;
					if (flag4)
					{
						this.InitLuaEnvInstance(null);
					}
					action = this.CreateDelegateFromLua(ScriptName);
				}
				bool flag5 = action == null;
				if (flag5)
				{
					try
					{
						action = CSharpScript.Create(Scripts, ScriptExecutor.options ?? ScriptExecutor.options, typeof(ScriptExecutor), null).CreateDelegate(Singleton<GameConfigManager>.Instance.cts.Token);
					}
					catch (Exception e)
					{
						string[] array = new string[5];
						int num = 0;
						Exception ex = e;
						array[num] = ((ex != null) ? ex.ToString() : null);
						array[1] = "编译失败！";
						array[2] = ScriptName;
						array[3] = "脚本内容为";
						array[4] = Scripts;
						Debug.LogError(string.Concat(array));
					}
				}
				bool flag6 = action != null;
				if (flag6)
				{
					this.ScriptDict[ScriptName] = action;
				}
			}
		}
	}

	/// <summary>
	/// 执行脚本
	/// </summary>
	/// <param name="ScriptsName">脚本名</param>
	// Token: 0x060002B3 RID: 691 RVA: 0x00019F44 File Offset: 0x00018144
	public void RunScript(string ScriptsName)
	{
		bool flag = FightManager.Instance != null && FightManager.Instance.fightType != FightType.None && ScriptsName != "InitScript";
		if (flag)
		{
			bool flag2 = this.Self == null;
			if (flag2)
			{
				Debug.LogError(FightManager.Instance.fightType.ToString() + "Self is null");
				return;
			}
		}
		try
		{
			bool flag3 = !this.ScriptDict.ContainsKey(ScriptsName);
			if (flag3)
			{
				this.PreCompileScripts(ScriptsName, null);
			}
			bool flag4 = this.ScriptDict.ContainsKey(ScriptsName);
			if (flag4)
			{
				ScriptRunner<object> scriptRunner = this.ScriptDict[ScriptsName] as ScriptRunner<object>;
				bool flag5 = scriptRunner != null;
				if (flag5)
				{
					scriptRunner(this, default(CancellationToken)).Wait(Singleton<GameConfigManager>.Instance.cts.Token);
				}
				else
				{
					Action action = this.ScriptDict[ScriptsName] as Action;
					bool flag6 = action != null;
					if (flag6)
					{
						action();
					}
					else
					{
						Action<ScriptExecutor> cache = this.ScriptDict[ScriptsName] as Action<ScriptExecutor>;
						bool flag7 = cache != null;
						if (flag7)
						{
							cache(this);
						}
					}
				}
			}
		}
		catch (Exception e)
		{
			string[] array = new string[6];
			array[0] = this.dataConfig.data["Id"];
			array[1] = " 的 ";
			array[2] = ScriptsName;
			array[3] = " 脚本执行时发生错误！\n";
			int num = 4;
			Exception ex = e;
			array[num] = ((ex != null) ? ex.ToString() : null);
			array[5] = "\n";
			Debug.LogError(string.Concat(array));
			throw;
		}
	}

	/// <summary>
	/// 清理脚本执行器
	/// </summary>
	// Token: 0x060002B4 RID: 692 RVA: 0x0001A0F8 File Offset: 0x000182F8
	public void Clear()
	{
		Singleton<EventCenter>.Instance.Clear(this);
		foreach (PropertyChangedEventHandler handler in this.handlers)
		{
			Singleton<PropertyWatcher>.Instance.RemoveListener(RoleTable.Instance, handler);
		}
		this.handlers.Clear();
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0001A174 File Offset: 0x00018374
	~ScriptExecutor()
	{
		this.Clear();
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0001A1A4 File Offset: 0x000183A4
	public bool TrySendOnlineEvent(string eventName, string[] parameters)
	{
		bool flag = this.status == null;
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			bool flag2 = PlayerManager.Instance != null && (!Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(RoleTable.Instance.Id) || !Singleton<TempDataManager>.Instance.RoleStatusMap[RoleTable.Instance.Id].Contains(this.status.InstanceId)) && !this.Vars.ContainsKey("Online");
			if (flag2)
			{
				string conJson = Singleton<GameConfigManager>.Instance.NativeIds.Contains(this.dataConfig.data["Id"]) ? "" : JsonConvert.SerializeObject(this.dataConfig.data);
				FightManager.Instance.CmdSendEvent(eventName, this.status.InstanceId, this.dataConfig.data["Id"], conJson, parameters);
				result = true;
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x0001A2A9 File Offset: 0x000184A9
	public void AddEvent_HurtData(string eventName, Action<HurtData> datafrom)
	{
		this.AddEvent<HurtData>(eventName, datafrom);
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x0001A2B4 File Offset: 0x000184B4
	public void AddTempEvent_HurtData(string eventName, Action<HurtData> datafrom)
	{
		this.AddTempEvent<HurtData>(eventName, datafrom);
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0001A2BF File Offset: 0x000184BF
	public void AddEvent_ActionData(string eventName, Action<ActionData> datafrom)
	{
		this.AddEvent<ActionData>(eventName, datafrom);
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0001A2CA File Offset: 0x000184CA
	public void AddTempEvent_ActionData(string eventName, Action<ActionData> datafrom)
	{
		this.AddTempEvent<ActionData>(eventName, datafrom);
	}

	// Token: 0x060002BB RID: 699 RVA: 0x0001A2D5 File Offset: 0x000184D5
	public void AddEvent_DamageData(string eventName, Action<DamageData> datafrom)
	{
		this.AddEvent<DamageData>(eventName, datafrom);
	}

	// Token: 0x060002BC RID: 700 RVA: 0x0001A2E0 File Offset: 0x000184E0
	public void AddTempEvent_DamageData(string eventName, Action<DamageData> datafrom)
	{
		this.AddTempEvent<DamageData>(eventName, datafrom);
	}

	// Token: 0x060002BD RID: 701 RVA: 0x0001A2EB File Offset: 0x000184EB
	public void AddEvent_NewEnemyData(string eventName, Action<NewEnemyData> datafrom)
	{
		this.AddEvent<NewEnemyData>(eventName, datafrom);
	}

	// Token: 0x060002BE RID: 702 RVA: 0x0001A2F6 File Offset: 0x000184F6
	public void AddTempEvent_NewEnemyData(string eventName, Action<NewEnemyData> datafrom)
	{
		this.AddTempEvent<NewEnemyData>(eventName, datafrom);
	}

	// Token: 0x060002BF RID: 703 RVA: 0x0001A301 File Offset: 0x00018501
	public void AddEvent_ScriptExecuteData(string eventName, Action<ScriptExecuteData> datafrom)
	{
		this.AddEvent<ScriptExecuteData>(eventName, datafrom);
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x0001A30C File Offset: 0x0001850C
	public void AddTempEvent_ScriptExecuteData(string eventName, Action<ScriptExecuteData> datafrom)
	{
		this.AddTempEvent<ScriptExecuteData>(eventName, datafrom);
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0001A35C File Offset: 0x0001855C
	[CompilerGenerated]
	internal static string <AddDescription>g__WrapByColor|76_0(string val, string color)
	{
		return string.Concat(new string[]
		{
			"<color=",
			color,
			">",
			val,
			"</color>"
		});
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0001A39C File Offset: 0x0001859C
	[CompilerGenerated]
	internal static string <CreateDelegate>g__MakeSafeIdentifier|138_0(string input)
	{
		string result = Regex.Replace(input, "[^\\w_]", "_");
		bool flag = char.IsDigit(result[0]);
		if (flag)
		{
			result = "_" + result;
		}
		return result;
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x0001A3DC File Offset: 0x000185DC
	private void $Rougamo_SetHp(string val)
	{
		this.status.CurHp = val.ToInt();
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
		{
			this.Self.Name,
			"将",
			this.status.Name,
			"的理智值变更为 <color=green>",
			val,
			"</color>"
		}));
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0001A46C File Offset: 0x0001866C
	private void $Rougamo_SetMaxHp(string val)
	{
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
		{
			this.Self.Name,
			"将",
			this.status.Name,
			"的最大理智值变更为 <color=green>",
			val,
			"</color>"
		}));
		this.status.MaxHp = val.ToInt();
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0001A4FC File Offset: 0x000186FC
	private void $Rougamo_ChangeHp(string val)
	{
		int lastval = this.status.CurHp;
		bool flag = val.ToInt() < 0;
		if (flag)
		{
			this.status.Hit(-val.ToInt(), "True", this.dataConfig.data["Id"], this.Self.InstanceId);
			int value = lastval - this.status.CurHp;
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Format("{0}对{1}造成了 <color=red>{2}</color>点{3}", new object[]
			{
				this.Self.Name,
				this.status.Name,
				value,
				"TrueDamage".Localize("Glossary")
			}));
		}
		else
		{
			this.status.Heal(val.ToInt(), "Heal");
			int value2 = this.status.CurHp - lastval;
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", ZString.Format<object, object, object>("{0}对{1}恢复了 <color=green>{2}</color> 点血量", this.Self.Name, this.status.Name, value2));
		}
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0001A658 File Offset: 0x00018858
	private void $Rougamo_ChangeMaxHp(string val)
	{
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
		{
			this.Self.Name,
			"将",
			this.status.Name,
			"的最大理智值增加了 <color=green>",
			val,
			"</color>"
		}));
		this.status.MaxHp += val.ToInt();
	}

	// Token: 0x060002CA RID: 714 RVA: 0x0001A6EC File Offset: 0x000188EC
	private void $Rougamo_AddBuff(string buffId, string level)
	{
		this.status.AddBuff(buffId, level.ToInt());
		bool flag = Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, buffId) != null;
		if (flag)
		{
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
			{
				this.Self.Name,
				"对",
				this.status.Name,
				"施加了 <color=yellow>",
				level,
				"</color> 层  无限  ) 回合的 <color=yellow>",
				Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, buffId)["Name"],
				"</color> 状态"
			}));
		}
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0001A7B8 File Offset: 0x000189B8
	private void $Rougamo_RemoveBuff(string buffId)
	{
		this.status.RemoveBuff(buffId);
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
		{
			this.Self.Name,
			"对",
			this.status.Name,
			"移除了 <color=yellow>",
			Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, buffId)["Name"],
			"</color> 状态"
		}));
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0001A858 File Offset: 0x00018A58
	private void $Rougamo_RunImmediately(string buffId, string eventName)
	{
		IBuffItem buff = this.status.GetBuff(buffId);
		bool flag = buff == null;
		if (!flag)
		{
			Singleton<EventCenter>.Instance.EventTrigger(eventName + this.status.InstanceId, buff.scriptExecutor);
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
			{
				this.Self.Name,
				"对",
				this.status.Name,
				"立即触发了 <color=yellow>",
				Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, buffId)["Name"],
				"</color> 状态"
			}));
		}
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0001A926 File Offset: 0x00018B26
	private void $Rougamo_Resurrection(string value)
	{
		this.status.Resurrection(value.ToInt());
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0001A93C File Offset: 0x00018B3C
	private void $Rougamo_ChangeDefence(string val)
	{
		int lastval = this.status.Defend;
		bool flag = this.status.fatherObject is OtherObj;
		if (flag)
		{
			this.status.Defend += (int)((float)val.ToInt() * this.status.dynamicVariables.GetValueOrDefault("DefendPercent", 1f));
		}
		else
		{
			bool flag2 = this.Self.fatherObject is FightPlayer;
			if (flag2)
			{
				this.status.Defend += this.Self.DefenceCalculate(val.ToInt());
			}
		}
		int value = this.status.Defend - lastval;
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", ZString.Format<object, object, object>("{0}对{1}增加了 <color=blue>{2}</color> 点护盾", this.Self.Name, this.status.Name, value));
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0001AA44 File Offset: 0x00018C44
	private void $Rougamo_SetPower(string val)
	{
		FightPlayer player = this.status.fatherObject as FightPlayer;
		bool flag = player != null;
		if (flag)
		{
			FightPlayer.Instance.CurPowerCount = val.ToInt();
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家的能量变更为 <color=blue>" + val + "</color>");
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0001AAB8 File Offset: 0x00018CB8
	private void $Rougamo_DrawCount(string val)
	{
		List<IStatusManager> tempList = new List<IStatusManager>(this.Object);
		int val2 = val.ToInt();
		bool flag = val2 == 0;
		if (!flag)
		{
			bool flag2 = val2 < 0;
			if (!flag2)
			{
				Enemy enemy = this.status.fatherObject as Enemy;
				bool flag3 = enemy != null;
				if (flag3)
				{
					this.status.ToughCount += val2;
				}
				FightPlayer player = this.status.fatherObject as FightPlayer;
				bool flag4 = player != null;
				if (flag4)
				{
					int count = FightCardManager.Instance.cardList.Count;
					int drawCount = val2;
					bool flag5 = !FightCardManager.Instance.HasCard() || count < drawCount;
					if (flag5)
					{
						FightCardManager.Instance.RandomIndex();
					}
					UIManager.Instance.GetUI<FightUI>("FightUI").CreateCardItem(drawCount);
					Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", ZString.Format<object, object>("{0}玩家抽取了 <color=purple>{1}</color> 张卡牌", this.status.InstanceId, drawCount));
				}
			}
		}
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0001ABE4 File Offset: 0x00018DE4
	private void $Rougamo_ChangePower(string val)
	{
		List<IStatusManager> tempList = new List<IStatusManager>(this.Object);
		Enemy enemy = this.status.fatherObject as Enemy;
		bool flag = enemy != null;
		if (flag)
		{
			this.Self.ToughOrigin += val.ToInt();
		}
		FightPlayer player = this.status.fatherObject as FightPlayer;
		bool flag2 = player != null;
		if (flag2)
		{
			FightPlayer.Instance.CurPowerCount += val.ToInt();
			bool flag3 = val.ToInt() < 0;
			if (flag3)
			{
				EventCenter instance = Singleton<EventCenter>.Instance;
				string str = "CostPower";
				IStatusManager status = FightPlayer.Instance.Status;
				instance.EventTrigger(str + ((status != null) ? status.InstanceId : null));
				bool flag4 = FightPlayer.Instance.CurPowerCount <= 0;
				if (flag4)
				{
					FightPlayer.Instance.CurPowerCount = 0;
					EventCenter instance2 = Singleton<EventCenter>.Instance;
					string str2 = "NoPower";
					IStatusManager status2 = FightPlayer.Instance.Status;
					instance2.EventTrigger(str2 + ((status2 != null) ? status2.InstanceId : null));
				}
			}
			else
			{
				AudioManager instance3 = AudioManager.Instance;
				if (instance3 != null)
				{
					instance3.PlayEffect("NewSounds/战斗中/恢复魔能");
				}
				EventCenter instance4 = Singleton<EventCenter>.Instance;
				string str3 = "AddPower";
				IStatusManager status3 = FightPlayer.Instance.Status;
				instance4.EventTrigger(str3 + ((status3 != null) ? status3.InstanceId : null));
			}
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
			{
				this.status.InstanceId,
				"玩家的能量",
				(val.ToInt() > 0) ? "增加" : "减少",
				"了 <color=blue>",
				val,
				"</color>"
			}));
		}
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0001ADB4 File Offset: 0x00018FB4
	private void $Rougamo_ChangeMaxPower(string val)
	{
		FightPlayer player = this.status.fatherObject as FightPlayer;
		bool flag = player != null;
		if (flag)
		{
			FightPlayer.Instance.MaxPowerCount += val.ToInt();
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
			{
				"玩家的最大能量",
				(val.ToInt() > 0) ? "增加" : "减少",
				"了 <color=blue>",
				val,
				"</color>"
			}));
		}
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0001AE64 File Offset: 0x00019064
	private void $Rougamo_ChangeRound()
	{
		bool flag = this.status.fatherObject is FightPlayer;
		if (flag)
		{
			FightManager.Instance.TurnEnd();
		}
		this.status.ChangeState(IStatusManager.State.NoAction);
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", this.status.Name + "的回合被跳过");
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0001AEE4 File Offset: 0x000190E4
	private void $Rougamo_DoAction(string index)
	{
		bool flag = this.status.fatherObject is Enemy;
		if (flag)
		{
			Enemy enemy = this.status.fatherObject as Enemy;
			enemy.DoOneAction(index.ToInt(), true);
			enemy.ShowAction();
		}
		else
		{
			bool flag2 = this.status.fatherObject is Partner;
			if (flag2)
			{
				Partner partner = this.status.fatherObject as Partner;
				partner.DoOneAction(index.ToInt(), true);
				partner.ShowAction();
			}
			else
			{
				bool flag3 = this.HandCard.Count > index.ToInt();
				if (flag3)
				{
					this.HandCard[index.ToInt()].dataConfig.scriptExecutor.RunScript("UseScript");
				}
			}
		}
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0001AFBC File Offset: 0x000191BC
	private void $Rougamo_RemoveAllBuff()
	{
		this.status.ClearAllBuff();
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", this.Self.Name + "对" + this.status.Name + "移除了所有状态");
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0001B028 File Offset: 0x00019228
	private void $Rougamo_AddCardByCardList(string count, [Optional] string tag)
	{
		bool flag = this.status.fatherObject is FightPlayer;
		if (flag)
		{
			this.AddCardByDeck(count, FightCardManager.Instance.cardList.Cast<IDataConfig>().ToList<IDataConfig>(), tag);
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家从抽牌堆检索了 <color=purple>" + count + "</color> 张卡牌");
		}
		else
		{
			this.status.ToughCount += count.ToInt();
		}
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0001B0C4 File Offset: 0x000192C4
	private void $Rougamo_AddCardByUsedCardList(string count, [Optional] string tag)
	{
		bool flag = this.status.fatherObject is FightPlayer;
		if (flag)
		{
			this.AddCardByDeck(count, FightCardManager.Instance.usedCardList.Cast<IDataConfig>().ToList<IDataConfig>(), tag);
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家从弃牌堆检索了 <color=purple>" + count + "</color> 张卡牌");
		}
		else
		{
			this.status.ToughCount += count.ToInt();
		}
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0001B160 File Offset: 0x00019360
	private void $Rougamo_RandomAddCard(string id)
	{
		bool flag = this.status.fatherObject is FightPlayer;
		if (flag)
		{
			DataConfig dataConfig = new DataConfig(id, DataType.Card);
			FightCardManager.Instance.cardList.Add(dataConfig);
			FightCardManager.Instance.CardTags.Add(dataConfig, new HashSet<string>());
			dataConfig.Vars["Tag"].Replace(" ", "");
			foreach (string item in dataConfig.Vars["Tag"].Split(new char[]
			{
				'|',
				',',
				'，',
				' ',
				';',
				'；'
			}))
			{
				FightCardManager.Instance.CardTags[dataConfig].Add(item);
			}
			int count = this.DefaultDice.WithRange(0, FightCardManager.Instance.cardList.Count - 1).Roll().Value;
			ObservableCollection<DataConfig> cardList;
			int index = (cardList = FightCardManager.Instance.cardList).Count - 1;
			Collection<DataConfig> cardList2 = FightCardManager.Instance.cardList;
			int index2 = count;
			DataConfig value = FightCardManager.Instance.cardList[count];
			ObservableCollection<DataConfig> cardList3 = FightCardManager.Instance.cardList;
			DataConfig value2 = cardList3[cardList3.Count - 1];
			cardList[index] = value;
			cardList2[index2] = value2;
		}
		else
		{
			this.status.ToughCount++;
		}
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家随机添加了一张卡牌" + this.dataConfig.data.Localize("Name"));
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0001B328 File Offset: 0x00019528
	private void $Rougamo_ChangeMoney(string val)
	{
		bool flag = this.status.fatherObject is FightPlayer;
		if (flag)
		{
			RoleTable.Instance.Money += val.ToInt();
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
			{
				"玩家的金钱",
				(val.ToInt() > 0) ? "增加" : "减少",
				"了 <color=yellow>",
				val,
				"</color>"
			}));
		}
		else
		{
			this.ChangeHp(val);
		}
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0001B3E8 File Offset: 0x000195E8
	private void $Rougamo_AddAction(string count)
	{
		int val = count.ToInt();
		bool flag = this.status.fatherObject is OtherObj;
		if (flag)
		{
			OtherObj otherObj = this.status.fatherObject as OtherObj;
			otherObj.MaxActionCount += val;
		}
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0001B438 File Offset: 0x00019638
	private void $Rougamo_ShuffleDeck()
	{
		bool flag = this.status.fatherObject is FightPlayer;
		if (flag)
		{
			FightCardManager.Instance.RandomIndex();
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家的卡组被重新洗牌了");
		}
		else
		{
			this.status.ToughCount++;
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", this.status.Name + "的韧性增加了 <color=purple>1</color> 点");
		}
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0001B4F0 File Offset: 0x000196F0
	private void $Rougamo_ChangeCardTop(string val)
	{
		bool flag = this.status.fatherObject is Enemy;
		if (flag)
		{
			this.status.ToughCount += val.ToInt();
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "敌人的韧性增加了 <color=purple>" + val + "</color> 点");
		}
		else
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").CardTopCount += val.ToInt();
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家的手牌上限增加了 <color=purple>" + val + "</color> 张卡牌");
		}
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0001B5CC File Offset: 0x000197CC
	private void $Rougamo_GetCardByTag(string count, [Optional] string tag)
	{
		bool flag = this.status.fatherObject is FightPlayer;
		if (flag)
		{
			bool flag2 = tag != "all";
			List<DataConfig> cards;
			if (flag2)
			{
				cards = (from x in FightCardManager.Instance.cardList.AsValueEnumerable<DataConfig>()
				where x.Vars["Tag"].Contains(tag)
				select x).ToList<Where<FromEnumerable<DataConfig>, DataConfig>, DataConfig>();
			}
			else
			{
				cards = FightCardManager.Instance.cardList.ToList<DataConfig>();
			}
			bool flag3 = cards.Count == 0;
			if (flag3)
			{
				Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "没有找到符合条件的卡牌");
			}
			else
			{
				int val = Math.Min(count.ToInt(), cards.Count);
				for (int i = 0; i < val; i++)
				{
					DataConfig card = cards[i];
					UIManager.Instance.GetUI<FightUI>("FightUI").CreateCardItem(card);
					FightCardManager.Instance.cardList.Remove(card);
				}
			}
		}
		else
		{
			this.status.ToughCount += count.ToInt();
		}
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0001B714 File Offset: 0x00019914
	private void $Rougamo_AddCard(string id)
	{
		Enemy enemy = this.status.fatherObject as Enemy;
		bool flag = enemy != null;
		if (flag)
		{
			this.status.ToughCount++;
		}
		FightPlayer player = this.status.fatherObject as FightPlayer;
		bool flag2 = player != null;
		if (flag2)
		{
			DataConfig dataConfigs = new DataConfig(id, DataType.Card);
			FightCardManager.Instance.cardList.Add(dataConfigs);
			FightCardManager.Instance.CardTags.Add(dataConfigs, new HashSet<string>());
			dataConfigs.Vars["Tag"] = dataConfigs.Vars["Tag"].Replace(" ", "");
			foreach (string item in dataConfigs.Vars["Tag"].Split(new char[]
			{
				'|',
				',',
				'，',
				' ',
				';',
				'；'
			}))
			{
				FightCardManager.Instance.CardTags[dataConfigs].Add(item);
			}
		}
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0001B834 File Offset: 0x00019A34
	private void $Rougamo_ChangeCareer(string Id)
	{
		bool flag = this.status.fatherObject is FightPlayer;
		if (flag)
		{
			RoleTable.Instance.Career = new DataConfig(Id, DataType.Career);
			FightPlayer.Instance.Status.ResetAnimator(false);
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", "玩家的职业变更为 <color=yellow>" + RoleTable.Instance.Career.data["Id"] + "</color>");
		}
		else
		{
			bool flag2 = this.status.fatherObject is OtherObj;
			if (flag2)
			{
				OtherObj other = this.status.fatherObject as OtherObj;
				other.dataConfig = new DataConfig(Id, DataType.Enemy);
				this.status.ResetAnimator(false);
				Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", other.Name + "的职业变更为 <color=yellow>" + other.dataConfig.data["Id"] + "</color>");
			}
		}
		bool flag3 = Application.isEditor && !Application.isPlaying;
		if (!flag3)
		{
			FightManager.Instance.CmdChangeCareer(Id, this.status.InstanceId);
		}
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0001B9A0 File Offset: 0x00019BA0
	private void $Rougamo_AddEvent(string eventName, Action script)
	{
		Singleton<EventCenter>.Instance.AddEventListener(eventName + this.status.InstanceId, delegate()
		{
			script();
		}, this, EventDispose.OnFightEnd);
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
		{
			"<color=grey>",
			this.Self.Name,
			"具体对象",
			this.Self.InstanceId,
			"对",
			this.status.Name,
			"具体对象",
			this.status.InstanceId,
			"添加了事件监听",
			eventName,
			"</color>"
		}));
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0001BA8C File Offset: 0x00019C8C
	private void $Rougamo_AddTempEvent(string eventName, Action script)
	{
		Singleton<EventCenter>.Instance.AddEventListener(eventName + this.status.InstanceId, delegate()
		{
			script();
		}, this, EventDispose.OnTrigger);
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
		{
			"<color=grey>",
			this.Self.Name,
			"具体对象",
			this.Self.InstanceId,
			"对",
			this.status.Name,
			"具体对象",
			this.status.InstanceId,
			"添加了一次性事件监听",
			eventName,
			"</color>"
		}));
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0001BB78 File Offset: 0x00019D78
	private void $Rougamo_AddEvent<T>(string eventName, Action<T> datafrom) where T : ISourceData
	{
		Singleton<EventCenter>.Instance.AddEventListener<T>(eventName + this.status.InstanceId, datafrom, this, EventDispose.OnFightEnd);
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", string.Concat(new string[]
		{
			"<color=grey>",
			this.Self.Name,
			"具体对象",
			this.Self.InstanceId,
			"对",
			this.status.Name,
			"具体对象",
			this.status.InstanceId,
			"添加了事件监听",
			eventName,
			"</color>"
		}));
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0001BC49 File Offset: 0x00019E49
	private void $Rougamo_AddTempEvent<T>(string eventName, Action<T> datafrom) where T : ISourceData
	{
		Singleton<EventCenter>.Instance.AddEventListener<T>(eventName + this.status.InstanceId, datafrom, this, EventDispose.OnTrigger);
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0001BC6C File Offset: 0x00019E6C
	private void $Rougamo_ChangeDynamicVar(string varName, string value)
	{
		this.status.dynamicVariables[varName] = this.status.dynamicVariables.GetValueOrDefault(varName) + float.Parse(value);
		bool flag = !this.status.dynamicVariablesLog.ContainsKey(this.dataConfig.data["Id"]);
		if (flag)
		{
			this.status.dynamicVariablesLog[this.dataConfig.data["Id"]] = new Dictionary<string, float>();
		}
		bool flag2 = !this.status.dynamicVariablesLog[this.dataConfig.data["Id"]].ContainsKey(varName);
		if (flag2)
		{
			this.status.dynamicVariablesLog[this.dataConfig.data["Id"]][varName] = 0f;
		}
		Dictionary<string, float> dictionary = this.status.dynamicVariablesLog[this.dataConfig.data["Id"]];
		dictionary[varName] += float.Parse(value);
		Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", ZString.Format<object, object, object>("{0}的{1}变更为 <color=green>{2}</color>", this.status.Name, varName, this.status.dynamicVariables[varName]));
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0001BDF8 File Offset: 0x00019FF8
	private void $Rougamo_ChangeDynamicVarPercent(string varName, string value)
	{
		this.status.dynamicVariables[varName] = this.status.dynamicVariables.GetValueOrDefault(varName) + float.Parse(value) / 100f;
		bool flag = !this.status.dynamicVariablesLog.ContainsKey(this.dataConfig.data["Id"]);
		if (flag)
		{
			this.status.dynamicVariablesLog[this.dataConfig.data["Id"]] = new Dictionary<string, float>();
		}
		bool flag2 = !this.status.dynamicVariablesLog[this.dataConfig.data["Id"]].ContainsKey(varName);
		if (flag2)
		{
			this.status.dynamicVariablesLog[this.dataConfig.data["Id"]][varName] = 0f;
		}
		Dictionary<string, float> dictionary = this.status.dynamicVariablesLog[this.dataConfig.data["Id"]];
		dictionary[varName] += float.Parse(value) / 100f;
		bool flag3 = this.status.fatherObject != null && !string.IsNullOrEmpty(this.status.Name);
		if (flag3)
		{
			Commands.Log("<color=grey>" + this.dataConfig.data.Localize("Name") + "</color>效果", ZString.Format<object, object, object>("{0}的{1}变更为 <color=green>{2}</color>", this.status.Name, varName, this.status.dynamicVariables[varName]));
		}
	}

	// Token: 0x0400090D RID: 2317
	public Dictionary<IStatusManager, Dictionary<string, int>> GetStatus = new Dictionary<IStatusManager, Dictionary<string, int>>();

	/// <summary>属性监听器列表</summary>
	// Token: 0x04000913 RID: 2323
	public List<PropertyChangedEventHandler> handlers = new List<PropertyChangedEventHandler>();

	/// <summary>预编译的所有脚本字典</summary>
	// Token: 0x04000916 RID: 2326
	private static Dictionary<string, Action<ScriptExecutor>> AllScriptDict;

	// Token: 0x04000917 RID: 2327
	public static LuaEnv luaEnv;

	// Token: 0x04000918 RID: 2328
	public static LuaTable luaTable;

	// Token: 0x04000919 RID: 2329
	private LuaTable scriptExecutorEnv;

	// Token: 0x0400091A RID: 2330
	private static readonly List<Func<ScriptExecutor, Delegate>> DynamicMethodDelegates = new List<Func<ScriptExecutor, Delegate>>();

	// Token: 0x0400091B RID: 2331
	private static ScriptOptions options;

	// Token: 0x0200005A RID: 90
	public class DiceWrapper
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x0001BFBF File Offset: 0x0001A1BF
		public DiceWrapper(Dice dice)
		{
			this.dice = dice;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
		public Dice.State InternalRoll(int? Target = null)
		{
			Dice.State state = this.dice.Roll();
			bool flag = FightPlayer.Instance == null;
			Dice.State state2;
			if (flag)
			{
				state2 = state;
			}
			else
			{
				DiceIcon diceIcon = FightPlayer.Instance.diceIcon;
				diceIcon.rangeValue = new ValueTuple<int, int>?(new ValueTuple<int, int>(this.dice.Range.Item1, this.dice.Range.Item2));
				diceIcon.value = state.Value;
				diceIcon.bonus = state.Bonus;
				bool flag2 = Target != null;
				if (flag2)
				{
					diceIcon.Target = Target.ToString();
				}
				bool flag3 = this.dice.Type == "Check";
				if (flag3)
				{
					diceIcon.Roll("检定骰");
				}
				bool flag4 = this.dice.Type == "Value";
				if (flag4)
				{
					diceIcon.Roll("数值骰");
				}
				state2 = state;
			}
			return state2;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
		public Dice.State Roll(int? Target = null)
		{
			FightPlayer instance = FightPlayer.Instance;
			bool flag = ((instance != null) ? instance.Status : null) != null;
			if (flag)
			{
				bool flag2 = this.dice.Type == "Check";
				if (flag2)
				{
					Singleton<EventCenter>.Instance.EventTrigger("OnDiceCheck" + FightPlayer.Instance.Status.InstanceId);
				}
				else
				{
					bool flag3 = this.dice.Type == "Roll";
					if (flag3)
					{
						Singleton<EventCenter>.Instance.EventTrigger("OnDiceValue" + FightPlayer.Instance.Status.InstanceId);
					}
				}
			}
			Action<Dice.State> TempResult = (Action<Dice.State>)Delegate.Combine(this.OnRoll, new Action<Dice.State>(delegate(Dice.State result)
			{
			}));
			bool flag4 = this.dice.Type == "Default";
			if (flag4)
			{
				this.result = this.dice.Roll();
			}
			else
			{
				this.result = this.InternalRoll(Target);
			}
			if (TempResult != null)
			{
				TempResult(this.result);
			}
			this.OnRoll = delegate(Dice.State result)
			{
			};
			return this.result;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001C254 File Offset: 0x0001A454
		public Dice WithRange(int min, int max)
		{
			return this.dice.WithRange(min, max);
		}

		// Token: 0x0400091C RID: 2332
		public Action<Dice.State> OnRoll = delegate(Dice.State result)
		{
		};

		// Token: 0x0400091D RID: 2333
		internal Dice dice;

		// Token: 0x0400091E RID: 2334
		public Dice.State result;
	}

	// Token: 0x0200005C RID: 92
	public static class PlayerInfo
	{
		// Token: 0x060002EF RID: 751 RVA: 0x0001C280 File Offset: 0x0001A480
		public static string GetTagDiff()
		{
			return GameSaveManager.GetHardLevel().ToString();
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0001C29F File Offset: 0x0001A49F
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
		public static int TrueCount
		{
			get
			{
				return Singleton<GameRuntimeData>.Instance.Truth;
			}
			set
			{
				Singleton<GameRuntimeData>.Instance.Truth = value;
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeTrue();
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0001C2D9 File Offset: 0x0001A4D9
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0001C2E5 File Offset: 0x0001A4E5
		public static int MaxHp
		{
			get
			{
				return RoleTable.Instance.MaxSan;
			}
			set
			{
				RoleTable.Instance.MaxSan = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0001C2F3 File Offset: 0x0001A4F3
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0001C2FF File Offset: 0x0001A4FF
		public static int Hp
		{
			get
			{
				return RoleTable.Instance.San;
			}
			set
			{
				RoleTable.Instance.San = value;
			}
		}

		/// <summary>
		/// 玩家当前能量
		/// </summary>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0001C30D File Offset: 0x0001A50D
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0001C320 File Offset: 0x0001A520
		public static int Power
		{
			get
			{
				FightPlayer instance = FightPlayer.Instance;
				return (instance != null) ? instance.CurPowerCount : 0;
			}
			set
			{
				FightPlayer player = FightPlayer.Instance;
				bool flag = player != null;
				if (flag)
				{
					player.CurPowerCount = value;
				}
			}
		}

		/// <summary>
		/// 玩家最大能量
		/// </summary>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0001C347 File Offset: 0x0001A547
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0001C35C File Offset: 0x0001A55C
		public static int MaxPower
		{
			get
			{
				FightPlayer instance = FightPlayer.Instance;
				return (instance != null) ? instance.MaxPowerCount : 0;
			}
			set
			{
				FightPlayer player = FightPlayer.Instance;
				bool flag = player != null;
				if (flag)
				{
					player.MaxPowerCount = value;
				}
			}
		}

		/// <summary>
		/// 手牌数
		/// </summary>
		/// <summary>
		/// 玩家遗物数
		/// </summary>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0001C383 File Offset: 0x0001A583
		public static int RelicCount
		{
			get
			{
				return RoleTable.Instance.relicList.Count;
			}
		}

		/// <summary>
		/// 玩家卡牌上限
		/// </summary>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0001C394 File Offset: 0x0001A594
		public static int CardTopCount
		{
			get
			{
				FightUI ui = UIManager.Instance.GetUI<FightUI>("FightUI");
				return (ui != null) ? ui.CardTopCount : 0;
			}
		}

		/// <summary>
		/// 敌人难度等级
		/// </summary>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0001C3B1 File Offset: 0x0001A5B1
		public static int enemylevel
		{
			get
			{
				return EnemyManager.SettlementMultiplier;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0001C3B8 File Offset: 0x0001A5B8
		public static int enemyCount
		{
			get
			{
				return EnemyManager.enemyCount;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0001C3BF File Offset: 0x0001A5BF
		public static int usedCardListCount
		{
			get
			{
				return FightCardManager.Instance.usedCardList.Count;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
		public static int CardTotalCount
		{
			get
			{
				return RoleTable.Instance.cardList.Count;
			}
		}

		/// <summary>
		/// 玩家卡牌数
		/// </summary>
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001C3E1 File Offset: 0x0001A5E1
		public static int CardCount
		{
			get
			{
				return FightCardManager.Instance.cardList.Count;
			}
		}

		/// <summary>
		/// 玩家祝福数
		/// </summary>
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0001C3F2 File Offset: 0x0001A5F2
		public static int BlessingCount
		{
			get
			{
				return RoleTable.Instance.blessingConfigs.Count;
			}
		}

		/// <summary>
		/// 玩家金币数
		/// </summary>
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001C403 File Offset: 0x0001A603
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0001C414 File Offset: 0x0001A614
		public static int Money
		{
			get
			{
				return RoleTable.Instance.Money;
			}
			set
			{
				RoleTable.Instance.Money = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001C427 File Offset: 0x0001A627
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0001C433 File Offset: 0x0001A633
		public static int MoneyMultiplier
		{
			get
			{
				return RoleTable.Instance.MoneyMultiplier;
			}
			set
			{
				RoleTable.Instance.MoneyMultiplier = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0001C440 File Offset: 0x0001A640
		public static int Level
		{
			get
			{
				return MapManager.Instance.Level;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0001C44C File Offset: 0x0001A64C
		public static IDataConfig LastCard
		{
			get
			{
				return FightUI.LastCard;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0001C453 File Offset: 0x0001A653
		public static FightType Win
		{
			get
			{
				return FightType.Win;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0001C456 File Offset: 0x0001A656
		public static FightType Loss
		{
			get
			{
				return FightType.Loss;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0001C459 File Offset: 0x0001A659
		public static FightType Enemy
		{
			get
			{
				return FightType.Enemy;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0001C45C File Offset: 0x0001A65C
		public static FightType Pattern
		{
			get
			{
				return FightType.Partner;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0001C45F File Offset: 0x0001A65F
		public static FightType Player
		{
			get
			{
				return FightType.Player;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0001C462 File Offset: 0x0001A662
		public static List<IDataConfig> CardList
		{
			get
			{
				return RoleTable.Instance.cardList.ToList<DataConfig>().Cast<IDataConfig>().ToList<IDataConfig>();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0001C47D File Offset: 0x0001A67D
		public static List<IDataConfig> BlessingList
		{
			get
			{
				return RoleTable.Instance.blessingConfigs.ToList<DataConfig>().Cast<IDataConfig>().ToList<IDataConfig>();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0001C498 File Offset: 0x0001A698
		public static List<IDataConfig> RelicList
		{
			get
			{
				return RoleTable.Instance.relicList.ToList<DataConfig>().Cast<IDataConfig>().ToList<IDataConfig>();
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0001C4B4 File Offset: 0x0001A6B4
		public static void ChangeEventSubtip(string text)
		{
			bool flag = UIManager.Instance.GetUI<EventUI>("EventUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<EventUI>("EventUI").ChangeSubtip(text);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0001C4F3 File Offset: 0x0001A6F3
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0001C4FF File Offset: 0x0001A6FF
		public static int Reward
		{
			get
			{
				return RoleTable.Instance.Reward;
			}
			set
			{
				RoleTable.Instance.Reward = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0001C50D File Offset: 0x0001A70D
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0001C523 File Offset: 0x0001A723
		public static int Strength
		{
			get
			{
				return RoleTable.Instance.VarsMap["Strength"];
			}
			set
			{
				RoleTable.Instance.VarsMap["Strength"] = value;
				RoleTable.Instance.VarsCheck("Strength");
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0001C54C File Offset: 0x0001A74C
		public static int DefaultRoll
		{
			get
			{
				return MapManager.Instance.NowDice.WithRange(0, 99).Roll().Value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0001C56A File Offset: 0x0001A76A
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0001C580 File Offset: 0x0001A780
		public static int Lucky
		{
			get
			{
				return RoleTable.Instance.VarsMap["Lucky"];
			}
			set
			{
				RoleTable.Instance.VarsMap["Lucky"] = value;
				RoleTable.Instance.VarsCheck("Lucky");
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0001C5A9 File Offset: 0x0001A7A9
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0001C5BF File Offset: 0x0001A7BF
		public static int Wisdom
		{
			get
			{
				return RoleTable.Instance.VarsMap["Wisdom"];
			}
			set
			{
				RoleTable.Instance.VarsMap["Wisdom"] = value;
				RoleTable.Instance.VarsCheck("Wisdom");
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001C5E8 File Offset: 0x0001A7E8
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0001C5FE File Offset: 0x0001A7FE
		public static int Perceive
		{
			get
			{
				return RoleTable.Instance.VarsMap["Perceive"];
			}
			set
			{
				RoleTable.Instance.VarsMap["Perceive"] = value;
				RoleTable.Instance.VarsCheck("Perceive");
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0001C627 File Offset: 0x0001A827
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0001C644 File Offset: 0x0001A844
		public static int TempStrength
		{
			get
			{
				FightManager instance = FightManager.Instance;
				return (instance != null) ? instance.TempVarsMap["Strength"] : 0;
			}
			set
			{
				bool flag = FightManager.Instance == null;
				if (!flag)
				{
					FightManager.Instance.TempVarsMap["Strength"] = value;
					TopBarUI ui = UIManager.Instance.GetUI<TopBarUI>("TopBarUI");
					if (ui != null)
					{
						ui.ChangeVar();
					}
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001C695 File Offset: 0x0001A895
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0001C6B4 File Offset: 0x0001A8B4
		public static int TempLucky
		{
			get
			{
				FightManager instance = FightManager.Instance;
				return (instance != null) ? instance.TempVarsMap["Lucky"] : 0;
			}
			set
			{
				bool flag = FightManager.Instance == null;
				if (!flag)
				{
					FightManager.Instance.TempVarsMap["Lucky"] = value;
					TopBarUI ui = UIManager.Instance.GetUI<TopBarUI>("TopBarUI");
					if (ui != null)
					{
						ui.ChangeVar();
					}
				}
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001C705 File Offset: 0x0001A905
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0001C724 File Offset: 0x0001A924
		public static int TempWisdom
		{
			get
			{
				FightManager instance = FightManager.Instance;
				return (instance != null) ? instance.TempVarsMap["Wisdom"] : 0;
			}
			set
			{
				bool flag = FightManager.Instance == null;
				if (!flag)
				{
					FightManager.Instance.TempVarsMap["Wisdom"] = value;
					TopBarUI ui = UIManager.Instance.GetUI<TopBarUI>("TopBarUI");
					if (ui != null)
					{
						ui.ChangeVar();
					}
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001C775 File Offset: 0x0001A975
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0001C788 File Offset: 0x0001A988
		public static Dictionary<string, int> SkillTime
		{
			get
			{
				RoleTable instance = RoleTable.Instance;
				return (instance != null) ? instance.SkillTime : null;
			}
			set
			{
				RoleTable.Instance.SkillTime = value;
				bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
				if (flag)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").UpdateSkill();
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001C7D1 File Offset: 0x0001A9D1
		// (set) Token: 0x06000325 RID: 805 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
		public static int TempPerceive
		{
			get
			{
				FightManager instance = FightManager.Instance;
				return (instance != null) ? instance.TempVarsMap["Perceive"] : 0;
			}
			set
			{
				bool flag = FightManager.Instance == null;
				if (!flag)
				{
					FightManager.Instance.TempVarsMap["Perceive"] = value;
					TopBarUI ui = UIManager.Instance.GetUI<TopBarUI>("TopBarUI");
					if (ui != null)
					{
						ui.ChangeVar();
					}
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001C841 File Offset: 0x0001AA41
		public static string PlayerName
		{
			get
			{
				return Singleton<GameConfigManager>.Instance.PlayerName;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0001C84D File Offset: 0x0001AA4D
		public static Dictionary<string, string> SpecialVars
		{
			get
			{
				RoleTable instance = RoleTable.Instance;
				return ((instance != null) ? instance.SpecialVarMap : null) ?? null;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0001C865 File Offset: 0x0001AA65
		public static void GiveWin()
		{
			Commands.Log("", Commands.give("win", "1"));
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0001C881 File Offset: 0x0001AA81
		public static void CopyCard(string instanceId)
		{
			Commands.Log("", Commands.copy("card", instanceId));
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0001C899 File Offset: 0x0001AA99
		public static void CopyBless(string instanceId)
		{
			Commands.Log("", Commands.copy("bless", instanceId));
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0001C8B1 File Offset: 0x0001AAB1
		public static void CopyRelic(string instanceId)
		{
			Commands.Log("", Commands.copy("relic", instanceId));
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0001C8C9 File Offset: 0x0001AAC9
		public static void AddCard(string id)
		{
			Commands.Log("", Commands.give("card", id));
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0001C8E1 File Offset: 0x0001AAE1
		public static void RemoveCard(string id)
		{
			Commands.Log("", Commands.remove("card", id));
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001C8F9 File Offset: 0x0001AAF9
		public static void AddRelic(string id)
		{
			Commands.Log("", Commands.give("relic", id));
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001C911 File Offset: 0x0001AB11
		public static void RemoveRelic(string id)
		{
			Commands.Log("", Commands.remove("relic", id));
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001C929 File Offset: 0x0001AB29
		public static void AddBless(string id)
		{
			Commands.Log("", Commands.give("bless", id));
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001C941 File Offset: 0x0001AB41
		public static void RemoveBless(string id)
		{
			Commands.Log("", Commands.remove("bless", id));
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001C959 File Offset: 0x0001AB59
		public static void RandomAddBless(string count)
		{
			Commands.Log("", Commands.give("randombless", count));
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001C971 File Offset: 0x0001AB71
		public static void RandomAddRelic(string count)
		{
			Commands.Log("", Commands.give("randomrelic", count));
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001C989 File Offset: 0x0001AB89
		public static void Goodbless(string count)
		{
			Commands.Log("", Commands.give("goodbless", count));
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0001C9A1 File Offset: 0x0001ABA1
		public static void RandomAddCard(string count)
		{
			Commands.Log("", Commands.give("randomcard", count));
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001C9B9 File Offset: 0x0001ABB9
		public static void RandomAddCardByDeck(string count)
		{
			Commands.Log("", Commands.give("randomcardbydeck", count));
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001C9D1 File Offset: 0x0001ABD1
		public static void RandomRemoveCard(string count)
		{
			Commands.Log("", Commands.remove("randomcard", count));
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0001C9E9 File Offset: 0x0001ABE9
		public static void RandomRemoveBless(string count)
		{
			Commands.Log("", Commands.remove("randombless", count));
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001CA01 File Offset: 0x0001AC01
		public static void RandomRemoveRelic(string count)
		{
			Commands.Log("", Commands.remove("randomrelic", count));
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0001CA19 File Offset: 0x0001AC19
		public static void StartLevel(string type, string id2 = null)
		{
			Commands.Log("", Commands.load(type, id2));
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001CA2D File Offset: 0x0001AC2D
		public static void ShowReward()
		{
			Commands.ShowReward("1", null);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001CA3B File Offset: 0x0001AC3B
		public static string SetGameVar(string key, string value)
		{
			return GameSaveManager.SetValue(key, value);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001CA44 File Offset: 0x0001AC44
		public static string GetGameVar(string key)
		{
			return GameSaveManager.GetValue<string>(key) ?? "0";
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001CA55 File Offset: 0x0001AC55
		public static void ContinueEvent(string id)
		{
			UIManager.Instance.GetUI<EventUI>("EventUI").ContinueEvent(id);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001CA6D File Offset: 0x0001AC6D
		public static void GameOver()
		{
			UIManager.Instance.ShowUIAsync<AcknowledgmentsUI>("AcknowledgmentsUI", true).Forget<AcknowledgmentsUI>();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001CA85 File Offset: 0x0001AC85
		public static void ShowDialogue(string id)
		{
			Singleton<DialogueManager>.Instance.ShowDialogue(id);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001CA93 File Offset: 0x0001AC93
		public static void AddEvent(string name, Action action, object obj)
		{
			Singleton<EventCenter>.Instance.AddEventListener(name, action, obj, EventDispose.None);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001CAA4 File Offset: 0x0001ACA4
		public static void EndDialogue()
		{
			Singleton<DialogueManager>.Instance.EndDialogue();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001CAB1 File Offset: 0x0001ACB1
		public static void ShowDialogueBox(string id)
		{
			Singleton<DialogueManager>.Instance.ShowDialogueBox(id);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001CABF File Offset: 0x0001ACBF
		public static void ShowOptions([TupleElementNames(new string[]
		{
			"text",
			"action"
		})] params ValueTuple<string, Action>[] options)
		{
			Singleton<DialogueManager>.Instance.ShowOptions(options);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001CACD File Offset: 0x0001ACCD
		public static void EventTrigger(string name)
		{
			EventCenter instance = Singleton<EventCenter>.Instance;
			if (instance != null)
			{
				instance.EventTrigger(name);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001CAE1 File Offset: 0x0001ACE1
		public static string RandomSelect(params string[] lists)
		{
			return lists[UnityEngine.Random.Range(0, lists.Length)];
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
		public static void EventTryChangeMap()
		{
			bool flag = UIManager.Instance.GetUI<EventUI>("EventUI") == null;
			if (!flag)
			{
				UIManager.Instance.GetUI<EventUI>("EventUI").TryChangeMap();
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001CB30 File Offset: 0x0001AD30
		public static void AnnounceEventDone()
		{
			bool flag = UIManager.Instance.GetUI<EventUI>("EventUI") == null;
			if (!flag)
			{
				UIManager.Instance.GetUI<EventUI>("EventUI").AnnounceEventDone();
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001CB6E File Offset: 0x0001AD6E
		public static GameRuntimeData Getsave()
		{
			return Singleton<GameRuntimeData>.Instance;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001CB75 File Offset: 0x0001AD75
		public static void AddItem(string itemId, string type)
		{
			Singleton<GameRuntimeData>.Instance.AddItem(itemId, type);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0001CB84 File Offset: 0x0001AD84
		public static void EndEvent()
		{
			bool flag = UIManager.Instance.GetUI<EventUI>("EventUI") == null;
			if (!flag)
			{
				UIManager.Instance.GetUI<EventUI>("EventUI").EndEvent();
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001CBC4 File Offset: 0x0001ADC4
		public static void LockChoice(string index)
		{
			bool flag = UIManager.Instance.GetUI<EventUI>("EventUI") == null;
			if (!flag)
			{
				UIManager.Instance.GetUI<EventUI>("EventUI").LockChoice(index);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001CC04 File Offset: 0x0001AE04
		public static IDictionary<string, string> GetCareer()
		{
			return RoleTable.Instance.Career.data;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001CC28 File Offset: 0x0001AE28
		public static void ChangeSelected(string value)
		{
			List<string> temp = new List<string>(RoleTable.Instance.ChooseVars);
			foreach (string item in temp)
			{
				Dictionary<string, int> varsMap = RoleTable.Instance.VarsMap;
				string key = item;
				varsMap[key] += value.ToInt();
				RoleTable.Instance.VarsCheck(item);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
		public static void ChangeAllVars(string value)
		{
			ScriptExecutor.PlayerInfo.Strength += value.ToInt();
			RoleTable.Instance.VarsCheck("Strength");
			ScriptExecutor.PlayerInfo.Lucky += value.ToInt();
			RoleTable.Instance.VarsCheck("Lucky");
			ScriptExecutor.PlayerInfo.Wisdom += value.ToInt();
			RoleTable.Instance.VarsCheck("Wisdom");
			ScriptExecutor.PlayerInfo.Perceive += value.ToInt();
			RoleTable.Instance.VarsCheck("Perceive");
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001CD4E File Offset: 0x0001AF4E
		public static void UnlockItem(string id)
		{
			Commands.unlock(id);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0001CD57 File Offset: 0x0001AF57
		public static void ShowCaption(string text)
		{
			UIManager.Instance.ShowTip(text, null);
		}

		/// <summary>删档并退出游戏（如我拒绝分支结束后调用）</summary>
		// Token: 0x06000352 RID: 850 RVA: 0x0001CD68 File Offset: 0x0001AF68
		public static void QuitAndDeleteSave()
		{
			UIManager.Instance.CloseUI("DialogueUI");
			bool flag = GameObject.Find("House") != null;
			if (flag)
			{
				UnityEngine.Object.Destroy(GameObject.Find("House"));
			}
			UIManager.Instance.ShowUI<MainMenuUI>("MainMenuUI", true);
		}
	}
}

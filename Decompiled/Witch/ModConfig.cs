using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using Witch.Core;
using Witch.Mod;
using XLua;

// Token: 0x0200004B RID: 75
[LuaCallCSharp(GenFlag.No)]
public class ModConfig
{
	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x000123B4 File Offset: 0x000105B4
	[JsonIgnore]
	public string ModId
	{
		get
		{
			return this.ModName + "." + this.ModAuthor;
		}
	}

	/// <summary>
	/// 读取Mod初始化代码
	/// </summary>
	/// <returns></returns>
	// Token: 0x060001F9 RID: 505 RVA: 0x000123CC File Offset: 0x000105CC
	internal bool Setup()
	{
		this.modLuaTable = ScriptExecutor.luaEnv.NewTable();
		LuaTable meta = ScriptExecutor.luaEnv.NewTable();
		meta.Set<string, LuaTable>("__index", ScriptExecutor.luaEnv.Global);
		this.modLuaTable.SetMetaTable(meta);
		meta.Dispose();
		this.modLuaTable.Set<string, ModConfig>("self", this);
		this.modLuaTable.Set<string, Type>("ScriptExecutor", typeof(ScriptExecutor));
		ScriptExecutor.luaEnv.DoString("\r\nlocal __cs = self\r\nModConfig = setmetatable({}, {\r\n    __index = function(_, k)\r\n        local v = __cs[k]\r\n        if type(v) == 'function' then\r\n            return function(_, ...)\r\n                return v(__cs, ...)\r\n            end\r\n        end\r\n        return v\r\n    end\r\n})\r\n", this.ModName + ".Bootstrap", this.modLuaTable);
		string path = Path.Combine(this.DirectoryName, "Scripts/Entry.lua");
		bool flag = File.Exists(path);
		if (flag)
		{
			string luaCode = File.ReadAllText(path);
			ScriptExecutor.luaEnv.DoString(luaCode, this.ModName + ".Entry", this.modLuaTable);
			LuaFunction setupFunc = this.modLuaTable.Get<LuaFunction>("Setup");
			bool flag2 = setupFunc != null;
			if (flag2)
			{
				setupFunc.Call(new object[]
				{
					this
				});
			}
			else
			{
				LuaTable modConfigApi = this.modLuaTable.Get<LuaTable>("ModConfig");
				bool flag3 = modConfigApi != null;
				if (flag3)
				{
					setupFunc = modConfigApi.Get<LuaFunction>("Setup");
					bool flag4 = setupFunc != null;
					if (flag4)
					{
						setupFunc.Call(new object[]
						{
							modConfigApi
						});
					}
					modConfigApi.Dispose();
				}
			}
		}
		else
		{
			Debug.LogWarning("[Mod]" + this.ModName + "不存在Entry.lua！");
		}
		return true;
	}

	/// <summary>
	/// 覆盖一个物品配置
	/// </summary>
	/// <param name="id"></param>
	/// <param name="newData"></param>
	// Token: 0x060001FA RID: 506 RVA: 0x0001256C File Offset: 0x0001076C
	public void SetDataConfig(string id, Dictionary<string, string> newData)
	{
		Dictionary<string, string> dic = Singleton<GameConfigManager>.Instance.GetOneById(id);
		foreach (KeyValuePair<string, string> kv in newData)
		{
			bool flag = kv.Key == "Id";
			if (!flag)
			{
				dic[kv.Key] = kv.Value;
			}
		}
	}

	/// <summary>
	/// 修改原有的物品配置
	/// </summary>
	/// <param name="id"></param>
	/// <param name="key"></param>
	/// <param name="value"></param>
	// Token: 0x060001FB RID: 507 RVA: 0x000125F0 File Offset: 0x000107F0
	public void ModifyDataConfig(string id, string key, string value)
	{
		Dictionary<string, string> dic = Singleton<GameConfigManager>.Instance.GetOneById(id);
		dic[key] = value;
	}

	/// <summary>
	/// 将source合并至target，常用于本地化。
	/// </summary>
	/// <param name="source"></param>
	/// <param name="target"></param>
	// Token: 0x060001FC RID: 508 RVA: 0x00012614 File Offset: 0x00010814
	public void MergeDataConfig(string source, string target)
	{
		Dictionary<string, Dictionary<string, string>> sources = Singleton<GameConfigManager>.Instance.GetDataByPrefix(source);
		Dictionary<string, Dictionary<string, string>> targets = Singleton<GameConfigManager>.Instance.GetDataByPrefix(target);
		foreach (KeyValuePair<string, Dictionary<string, string>> kv in sources)
		{
			bool flag = !targets.ContainsKey(kv.Key);
			if (!flag)
			{
				foreach (KeyValuePair<string, string> v in kv.Value)
				{
					targets[kv.Key].Add(v.Key, v.Value);
				}
			}
		}
	}

	// Token: 0x060001FD RID: 509 RVA: 0x000126F8 File Offset: 0x000108F8
	public void RedirectSourcePath(string originalPath, string newPath)
	{
		ResourceLoader.RedirectPath(originalPath, newPath);
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00012703 File Offset: 0x00010903
	public void AddDynamicMethod(string methodName, LuaFunction function)
	{
		ScriptExecutor.luaEnv.Global.Set<string, LuaFunction>(methodName, function);
	}

	/// <summary>
	/// 在 IModifiable 方法执行前注入。typeDotMethod 为 "类型全名.方法名"。fn(ctx) 的 ctx：TypeName, MethodName, Target, Arguments, ReturnValue 为 nil。
	/// </summary>
	// Token: 0x060001FF RID: 511 RVA: 0x00012718 File Offset: 0x00010918
	public void AddMethodHookBefore(string typeDotMethod, LuaFunction function)
	{
		bool flag = string.IsNullOrEmpty(typeDotMethod) || function == null;
		if (!flag)
		{
			Action<ModHookContext> action = LuaModHookAdapter.ToBeforeAction(function);
			bool flag2 = action != null;
			if (flag2)
			{
				ModHookRegistry.AddBefore(typeDotMethod, action);
			}
		}
	}

	/// <summary>
	/// 在 IModifiable 方法执行后注入。typeDotMethod 为 "类型全名.方法名"。fn(ctx) 的 ctx.ReturnValue 为方法返回值。
	/// </summary>
	// Token: 0x06000200 RID: 512 RVA: 0x00012754 File Offset: 0x00010954
	public void AddMethodHookAfter(string typeDotMethod, LuaFunction function)
	{
		bool flag = string.IsNullOrEmpty(typeDotMethod) || function == null;
		if (!flag)
		{
			Action<ModHookContext> action = LuaModHookAdapter.ToAfterAction(function);
			bool flag2 = action != null;
			if (flag2)
			{
				ModHookRegistry.AddAfter(typeDotMethod, action);
			}
		}
	}

	// Token: 0x040008B4 RID: 2228
	[JsonIgnore]
	public string DirectoryName;

	// Token: 0x040008B5 RID: 2229
	[JsonIgnore]
	private LuaTable modLuaTable;

	// Token: 0x040008B6 RID: 2230
	public string ModName;

	// Token: 0x040008B7 RID: 2231
	public string ModVersion;

	// Token: 0x040008B8 RID: 2232
	public string ModAuthor;

	// Token: 0x040008B9 RID: 2233
	public string ModDescription;

	// Token: 0x040008BA RID: 2234
	public string IconPath;

	// Token: 0x040008BB RID: 2235
	public bool Enabled;

	// Token: 0x040008BC RID: 2236
	public List<string> Dependencies;
}

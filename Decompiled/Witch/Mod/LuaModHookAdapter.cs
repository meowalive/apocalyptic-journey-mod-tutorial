using System;
using Witch.Core;
using XLua;

namespace Witch.Mod
{
	/// <summary>
	/// 将 LuaFunction 适配为 ModHookRegistry 可用的 Action&lt;ModHookContext&gt;，
	/// 在 Modifiable 切面中调用时把上下文转为 Lua table 再调用 Lua。
	/// </summary>
	// Token: 0x02000260 RID: 608
	[LuaCallCSharp(GenFlag.No)]
	public static class LuaModHookAdapter
	{
		/// <summary>
		/// 返回可在 ModHookRegistry 中注册的 Before 回调。Lua 侧函数签名为 fn(ctx)，
		/// ctx 为 table：TypeName, MethodName, Target, Arguments (table), ReturnValue (before 时为 nil)。
		/// </summary>
		// Token: 0x0600137A RID: 4986 RVA: 0x00099338 File Offset: 0x00097538
		public static Action<ModHookContext> ToBeforeAction(LuaFunction fn)
		{
			bool flag = fn == null;
			Action<ModHookContext> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = delegate(ModHookContext ctx)
				{
					LuaEnv env = ScriptExecutor.luaEnv;
					bool flag2 = env == null;
					if (!flag2)
					{
						fn.Call(ctx.Arguments);
					}
				};
			}
			return result;
		}

		/// <summary>
		/// 返回可在 ModHookRegistry 中注册的 After 回调。Lua 侧 ctx.ReturnValue 为方法返回值。
		/// </summary>
		// Token: 0x0600137B RID: 4987 RVA: 0x00099374 File Offset: 0x00097574
		public static Action<ModHookContext> ToAfterAction(LuaFunction fn)
		{
			bool flag = fn == null;
			Action<ModHookContext> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = delegate(ModHookContext ctx)
				{
					LuaEnv env = ScriptExecutor.luaEnv;
					bool flag2 = env == null;
					if (!flag2)
					{
						fn.Call(ctx.Arguments);
					}
				};
			}
			return result;
		}
	}
}

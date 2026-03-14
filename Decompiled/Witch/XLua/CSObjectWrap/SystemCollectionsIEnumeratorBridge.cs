using System;
using System.Collections;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001AA RID: 426
	public class SystemCollectionsIEnumeratorBridge : LuaBase, IEnumerator
	{
		// Token: 0x06000DB4 RID: 3508 RVA: 0x0006B2F4 File Offset: 0x000694F4
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return new SystemCollectionsIEnumeratorBridge(reference, luaenv);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0005673B File Offset: 0x0005493B
		public SystemCollectionsIEnumeratorBridge(int reference, LuaEnv luaenv) : base(reference, luaenv)
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0006B310 File Offset: 0x00069510
		bool IEnumerator.MoveNext()
		{
			IntPtr L = this.luaEnv.L;
			int err_func = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			Lua.xlua_pushasciistring(L, "MoveNext");
			bool flag = Lua.xlua_pgettable(L, -2) != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			bool flag2 = !Lua.lua_isfunction(L, -1);
			if (flag2)
			{
				Lua.xlua_pushasciistring(L, "no such function MoveNext");
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			Lua.lua_pushvalue(L, -2);
			Lua.lua_remove(L, -3);
			int __gen_error = Lua.lua_pcall(L, 1, 1, err_func);
			bool flag3 = __gen_error != 0;
			if (flag3)
			{
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			bool __gen_ret = Lua.lua_toboolean(L, err_func + 1);
			Lua.lua_settop(L, err_func - 1);
			return __gen_ret;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0006B3F4 File Offset: 0x000695F4
		void IEnumerator.Reset()
		{
			IntPtr L = this.luaEnv.L;
			int err_func = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			Lua.xlua_pushasciistring(L, "Reset");
			bool flag = Lua.xlua_pgettable(L, -2) != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			bool flag2 = !Lua.lua_isfunction(L, -1);
			if (flag2)
			{
				Lua.xlua_pushasciistring(L, "no such function Reset");
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			Lua.lua_pushvalue(L, -2);
			Lua.lua_remove(L, -3);
			int __gen_error = Lua.lua_pcall(L, 1, 0, err_func);
			bool flag3 = __gen_error != 0;
			if (flag3)
			{
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			Lua.lua_settop(L, err_func - 1);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0006B4C8 File Offset: 0x000696C8
		object IEnumerator.Current
		{
			get
			{
				IntPtr L = this.luaEnv.L;
				int oldTop = Lua.lua_gettop(L);
				ObjectTranslator translator = this.luaEnv.translator;
				Lua.lua_getref(L, this.luaReference);
				Lua.xlua_pushasciistring(L, "Current");
				bool flag = Lua.xlua_pgettable(L, -2) != 0;
				if (flag)
				{
					this.luaEnv.ThrowExceptionFromError(oldTop);
				}
				object __gen_ret = translator.GetObject(L, -1, typeof(object));
				Lua.lua_pop(L, 2);
				return __gen_ret;
			}
		}
	}
}

using System;
using Tutorial;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001AD RID: 429
	public class TutorialCSCallLuaItfDBridge : LuaBase, CSCallLua.ItfD
	{
		// Token: 0x06000DCC RID: 3532 RVA: 0x0006BE20 File Offset: 0x0006A020
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return new TutorialCSCallLuaItfDBridge(reference, luaenv);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0005673B File Offset: 0x0005493B
		public TutorialCSCallLuaItfDBridge(int reference, LuaEnv luaenv) : base(reference, luaenv)
		{
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0006BE3C File Offset: 0x0006A03C
		int CSCallLua.ItfD.add(int a, int b)
		{
			IntPtr L = this.luaEnv.L;
			int err_func = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			Lua.xlua_pushasciistring(L, "add");
			bool flag = Lua.xlua_pgettable(L, -2) != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			bool flag2 = !Lua.lua_isfunction(L, -1);
			if (flag2)
			{
				Lua.xlua_pushasciistring(L, "no such function add");
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			Lua.lua_pushvalue(L, -2);
			Lua.lua_remove(L, -3);
			Lua.xlua_pushinteger(L, a);
			Lua.xlua_pushinteger(L, b);
			int __gen_error = Lua.lua_pcall(L, 3, 1, err_func);
			bool flag3 = __gen_error != 0;
			if (flag3)
			{
				this.luaEnv.ThrowExceptionFromError(err_func - 1);
			}
			int __gen_ret = Lua.xlua_tointeger(L, err_func + 1);
			Lua.lua_settop(L, err_func - 1);
			return __gen_ret;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0006BF30 File Offset: 0x0006A130
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x0006BFA0 File Offset: 0x0006A1A0
		int CSCallLua.ItfD.f1
		{
			get
			{
				IntPtr L = this.luaEnv.L;
				int oldTop = Lua.lua_gettop(L);
				Lua.lua_getref(L, this.luaReference);
				Lua.xlua_pushasciistring(L, "f1");
				bool flag = Lua.xlua_pgettable(L, -2) != 0;
				if (flag)
				{
					this.luaEnv.ThrowExceptionFromError(oldTop);
				}
				int __gen_ret = Lua.xlua_tointeger(L, -1);
				Lua.lua_pop(L, 2);
				return __gen_ret;
			}
			set
			{
				IntPtr L = this.luaEnv.L;
				int oldTop = Lua.lua_gettop(L);
				Lua.lua_getref(L, this.luaReference);
				Lua.xlua_pushasciistring(L, "f1");
				Lua.xlua_pushinteger(L, value);
				bool flag = Lua.xlua_psettable(L, -3) != 0;
				if (flag)
				{
					this.luaEnv.ThrowExceptionFromError(oldTop);
				}
				Lua.lua_pop(L, 1);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0006C008 File Offset: 0x0006A208
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x0006C078 File Offset: 0x0006A278
		int CSCallLua.ItfD.f2
		{
			get
			{
				IntPtr L = this.luaEnv.L;
				int oldTop = Lua.lua_gettop(L);
				Lua.lua_getref(L, this.luaReference);
				Lua.xlua_pushasciistring(L, "f2");
				bool flag = Lua.xlua_pgettable(L, -2) != 0;
				if (flag)
				{
					this.luaEnv.ThrowExceptionFromError(oldTop);
				}
				int __gen_ret = Lua.xlua_tointeger(L, -1);
				Lua.lua_pop(L, 2);
				return __gen_ret;
			}
			set
			{
				IntPtr L = this.luaEnv.L;
				int oldTop = Lua.lua_gettop(L);
				Lua.lua_getref(L, this.luaReference);
				Lua.xlua_pushasciistring(L, "f2");
				Lua.xlua_pushinteger(L, value);
				bool flag = Lua.xlua_psettable(L, -3) != 0;
				if (flag)
				{
					this.luaEnv.ThrowExceptionFromError(oldTop);
				}
				Lua.lua_pop(L, 1);
			}
		}
	}
}

using System;
using Tutorial;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001AC RID: 428
	public class TutorialBaseClassWrap
	{
		// Token: 0x06000DC2 RID: 3522 RVA: 0x0006B9C4 File Offset: 0x00069BC4
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(BaseClass);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 1, 1, -1);
			Utils.RegisterFunc(L, -3, "BMFunc", new lua_CSFunction(TutorialBaseClassWrap._m_BMFunc));
			Utils.RegisterFunc(L, -3, "GetSomeBaseData", new lua_CSFunction(TutorialBaseClassWrap._m_GetSomeBaseData));
			Utils.RegisterFunc(L, -2, "BMF", new lua_CSFunction(TutorialBaseClassWrap._g_get_BMF));
			Utils.RegisterFunc(L, -1, "BMF", new lua_CSFunction(TutorialBaseClassWrap._s_set_BMF));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(TutorialBaseClassWrap.__CreateInstance), 2, 1, 1);
			Utils.RegisterFunc(L, -4, "BSFunc", new lua_CSFunction(TutorialBaseClassWrap._m_BSFunc_xlua_st_));
			Utils.RegisterFunc(L, -2, "BSF", new lua_CSFunction(TutorialBaseClassWrap._g_get_BSF));
			Utils.RegisterFunc(L, -1, "BSF", new lua_CSFunction(TutorialBaseClassWrap._s_set_BSF));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0006BADC File Offset: 0x00069CDC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					BaseClass gen_ret = new BaseClass();
					translator.Push(L, gen_ret);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to Tutorial.BaseClass constructor!");
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0006BB60 File Offset: 0x00069D60
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_BSFunc_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				BaseClass.BSFunc();
				result = 0;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0006BBB0 File Offset: 0x00069DB0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_BMFunc(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				BaseClass gen_to_be_invoked = (BaseClass)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.BMFunc();
				result = 0;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0006BC18 File Offset: 0x00069E18
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetSomeBaseData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				BaseClass gen_to_be_invoked = (BaseClass)translator.FastGetCSObj(L, 1);
				int gen_ret = gen_to_be_invoked.GetSomeBaseData();
				Lua.xlua_pushinteger(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0006BC8C File Offset: 0x00069E8C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_BMF(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				BaseClass gen_to_be_invoked = (BaseClass)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.BMF);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0006BCFC File Offset: 0x00069EFC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_BSF(IntPtr L)
		{
			try
			{
				Lua.xlua_pushinteger(L, BaseClass.BSF);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0006BD54 File Offset: 0x00069F54
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_BMF(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				BaseClass gen_to_be_invoked = (BaseClass)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.BMF = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0006BDC8 File Offset: 0x00069FC8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_BSF(IntPtr L)
		{
			try
			{
				BaseClass.BSF = Lua.xlua_tointeger(L, 1);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}
	}
}

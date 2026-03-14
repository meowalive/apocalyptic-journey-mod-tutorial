using System;
using Witch.Core;
using Witch.Mod;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001BE RID: 446
	public class WitchModLuaModHookAdapterWrap
	{
		// Token: 0x06000FC4 RID: 4036 RVA: 0x00082F3C File Offset: 0x0008113C
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(LuaModHookAdapter);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0, -1);
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(WitchModLuaModHookAdapterWrap.__CreateInstance), 3, 0, 0);
			Utils.RegisterFunc(L, -4, "ToBeforeAction", new lua_CSFunction(WitchModLuaModHookAdapterWrap._m_ToBeforeAction_xlua_st_));
			Utils.RegisterFunc(L, -4, "ToAfterAction", new lua_CSFunction(WitchModLuaModHookAdapterWrap._m_ToAfterAction_xlua_st_));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00082FD4 File Offset: 0x000811D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return Lua.luaL_error(L, "Witch.Mod.LuaModHookAdapter does not have a constructor!");
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00082FF4 File Offset: 0x000811F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToBeforeAction_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				LuaFunction _fn = (LuaFunction)translator.GetObject(L, 1, typeof(LuaFunction));
				Action<ModHookContext> gen_ret = LuaModHookAdapter.ToBeforeAction(_fn);
				translator.Push(L, gen_ret);
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

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00083074 File Offset: 0x00081274
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToAfterAction_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				LuaFunction _fn = (LuaFunction)translator.GetObject(L, 1, typeof(LuaFunction));
				Action<ModHookContext> gen_ret = LuaModHookAdapter.ToAfterAction(_fn);
				translator.Push(L, gen_ret);
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
	}
}

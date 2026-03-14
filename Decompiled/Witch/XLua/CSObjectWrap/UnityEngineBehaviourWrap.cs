using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B1 RID: 433
	public class UnityEngineBehaviourWrap
	{
		// Token: 0x06000DEE RID: 3566 RVA: 0x0006CF88 File Offset: 0x0006B188
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Behaviour);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 2, 1, -1);
			Utils.RegisterFunc(L, -2, "enabled", new lua_CSFunction(UnityEngineBehaviourWrap._g_get_enabled));
			Utils.RegisterFunc(L, -2, "isActiveAndEnabled", new lua_CSFunction(UnityEngineBehaviourWrap._g_get_isActiveAndEnabled));
			Utils.RegisterFunc(L, -1, "enabled", new lua_CSFunction(UnityEngineBehaviourWrap._s_set_enabled));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineBehaviourWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0006D038 File Offset: 0x0006B238
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					Behaviour gen_ret = new Behaviour();
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Behaviour constructor!");
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0006D0BC File Offset: 0x0006B2BC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_enabled(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Behaviour gen_to_be_invoked = (Behaviour)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.enabled);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0006D12C File Offset: 0x0006B32C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_isActiveAndEnabled(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Behaviour gen_to_be_invoked = (Behaviour)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.isActiveAndEnabled);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0006D19C File Offset: 0x0006B39C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_enabled(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Behaviour gen_to_be_invoked = (Behaviour)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.enabled = Lua.lua_toboolean(L, 2);
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

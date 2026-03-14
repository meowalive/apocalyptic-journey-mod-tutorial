using System;
using Tutorial;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B0 RID: 432
	public class TutorialICalcWrap
	{
		// Token: 0x06000DEA RID: 3562 RVA: 0x0006CE60 File Offset: 0x0006B060
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(ICalc);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0, -1);
			Utils.RegisterFunc(L, -3, "add", new lua_CSFunction(TutorialICalcWrap._m_add));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(TutorialICalcWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0006CEDC File Offset: 0x0006B0DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return Lua.luaL_error(L, "Tutorial.ICalc does not have a constructor!");
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0006CEFC File Offset: 0x0006B0FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_add(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ICalc gen_to_be_invoked = (ICalc)translator.FastGetCSObj(L, 1);
				int _a = Lua.xlua_tointeger(L, 2);
				int _b = Lua.xlua_tointeger(L, 3);
				int gen_ret = gen_to_be_invoked.add(_a, _b);
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
	}
}

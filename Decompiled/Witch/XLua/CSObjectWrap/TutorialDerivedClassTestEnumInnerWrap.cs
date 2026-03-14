using System;
using Tutorial;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001A3 RID: 419
	public class TutorialDerivedClassTestEnumInnerWrap
	{
		// Token: 0x06000C7C RID: 3196 RVA: 0x0005ED3C File Offset: 0x0005CF3C
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(DerivedClass.TestEnumInner), L, translator, 0, 0, 0, 0, -1);
			Utils.EndObjectRegister(typeof(DerivedClass.TestEnumInner), L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(typeof(DerivedClass.TestEnumInner), L, null, 3, 0, 0);
			Utils.RegisterObject(L, translator, -4, "E3", DerivedClass.TestEnumInner.E3);
			Utils.RegisterObject(L, translator, -4, "E4", DerivedClass.TestEnumInner.E4);
			Utils.RegisterFunc(L, -4, "__CastFrom", new lua_CSFunction(TutorialDerivedClassTestEnumInnerWrap.__CastFrom));
			Utils.EndClassRegister(typeof(DerivedClass.TestEnumInner), L, translator);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0005EDF0 File Offset: 0x0005CFF0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CastFrom(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = Lua.lua_type(L, 1);
			bool flag = lua_type == LuaTypes.LUA_TNUMBER;
			if (flag)
			{
				translator.PushTutorialDerivedClassTestEnumInner(L, (DerivedClass.TestEnumInner)Lua.xlua_tointeger(L, 1));
			}
			else
			{
				bool flag2 = lua_type == LuaTypes.LUA_TSTRING;
				if (!flag2)
				{
					return Lua.luaL_error(L, "invalid lua type for Tutorial.DerivedClass.TestEnumInner! Expect number or string, got + " + lua_type.ToString());
				}
				bool flag3 = Lua.xlua_is_eq_str(L, 1, "E3");
				if (flag3)
				{
					translator.PushTutorialDerivedClassTestEnumInner(L, DerivedClass.TestEnumInner.E3);
				}
				else
				{
					bool flag4 = Lua.xlua_is_eq_str(L, 1, "E4");
					if (!flag4)
					{
						return Lua.luaL_error(L, "invalid string for Tutorial.DerivedClass.TestEnumInner!");
					}
					translator.PushTutorialDerivedClassTestEnumInner(L, DerivedClass.TestEnumInner.E4);
				}
			}
			return 1;
		}
	}
}

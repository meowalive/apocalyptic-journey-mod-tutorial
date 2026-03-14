using System;
using Tutorial;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001A2 RID: 418
	public class TutorialTestEnumWrap
	{
		// Token: 0x06000C79 RID: 3193 RVA: 0x0005EBC8 File Offset: 0x0005CDC8
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(TestEnum), L, translator, 0, 0, 0, 0, -1);
			Utils.EndObjectRegister(typeof(TestEnum), L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(typeof(TestEnum), L, null, 3, 0, 0);
			Utils.RegisterObject(L, translator, -4, "E1", TestEnum.E1);
			Utils.RegisterObject(L, translator, -4, "E2", TestEnum.E2);
			Utils.RegisterFunc(L, -4, "__CastFrom", new lua_CSFunction(TutorialTestEnumWrap.__CastFrom));
			Utils.EndClassRegister(typeof(TestEnum), L, translator);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0005EC7C File Offset: 0x0005CE7C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CastFrom(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = Lua.lua_type(L, 1);
			bool flag = lua_type == LuaTypes.LUA_TNUMBER;
			if (flag)
			{
				translator.PushTutorialTestEnum(L, (TestEnum)Lua.xlua_tointeger(L, 1));
			}
			else
			{
				bool flag2 = lua_type == LuaTypes.LUA_TSTRING;
				if (!flag2)
				{
					return Lua.luaL_error(L, "invalid lua type for Tutorial.TestEnum! Expect number or string, got + " + lua_type.ToString());
				}
				bool flag3 = Lua.xlua_is_eq_str(L, 1, "E1");
				if (flag3)
				{
					translator.PushTutorialTestEnum(L, TestEnum.E1);
				}
				else
				{
					bool flag4 = Lua.xlua_is_eq_str(L, 1, "E2");
					if (!flag4)
					{
						return Lua.luaL_error(L, "invalid string for Tutorial.TestEnum!");
					}
					translator.PushTutorialTestEnum(L, TestEnum.E2);
				}
			}
			return 1;
		}
	}
}

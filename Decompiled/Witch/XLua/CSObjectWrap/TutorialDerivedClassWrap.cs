using System;
using Tutorial;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001AF RID: 431
	public class TutorialDerivedClassWrap
	{
		// Token: 0x06000DD6 RID: 3542 RVA: 0x0006C164 File Offset: 0x0006A364
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(DerivedClass);
			Utils.BeginObjectRegister(type, L, translator, 1, 12, 2, 2, -1);
			Utils.RegisterFunc(L, -4, "__add", new lua_CSFunction(TutorialDerivedClassWrap.__AddMeta));
			Utils.RegisterFunc(L, -3, "DMFunc", new lua_CSFunction(TutorialDerivedClassWrap._m_DMFunc));
			Utils.RegisterFunc(L, -3, "ComplexFunc", new lua_CSFunction(TutorialDerivedClassWrap._m_ComplexFunc));
			Utils.RegisterFunc(L, -3, "TestFunc", new lua_CSFunction(TutorialDerivedClassWrap._m_TestFunc));
			Utils.RegisterFunc(L, -3, "DefaultValueFunc", new lua_CSFunction(TutorialDerivedClassWrap._m_DefaultValueFunc));
			Utils.RegisterFunc(L, -3, "VariableParamsFunc", new lua_CSFunction(TutorialDerivedClassWrap._m_VariableParamsFunc));
			Utils.RegisterFunc(L, -3, "EnumTestFunc", new lua_CSFunction(TutorialDerivedClassWrap._m_EnumTestFunc));
			Utils.RegisterFunc(L, -3, "CallEvent", new lua_CSFunction(TutorialDerivedClassWrap._m_CallEvent));
			Utils.RegisterFunc(L, -3, "TestLong", new lua_CSFunction(TutorialDerivedClassWrap._m_TestLong));
			Utils.RegisterFunc(L, -3, "GetCalc", new lua_CSFunction(TutorialDerivedClassWrap._m_GetCalc));
			Utils.RegisterFunc(L, -3, "GetSomeData", new lua_CSFunction(TutorialDerivedClassWrap._m_GetSomeData));
			Utils.RegisterFunc(L, -3, "GenericMethodOfString", new lua_CSFunction(TutorialDerivedClassWrap._m_GenericMethodOfString));
			Utils.RegisterFunc(L, -3, "TestEvent", new lua_CSFunction(TutorialDerivedClassWrap._e_TestEvent));
			Utils.RegisterFunc(L, -2, "DMF", new lua_CSFunction(TutorialDerivedClassWrap._g_get_DMF));
			Utils.RegisterFunc(L, -2, "TestDelegate", new lua_CSFunction(TutorialDerivedClassWrap._g_get_TestDelegate));
			Utils.RegisterFunc(L, -1, "DMF", new lua_CSFunction(TutorialDerivedClassWrap._s_set_DMF));
			Utils.RegisterFunc(L, -1, "TestDelegate", new lua_CSFunction(TutorialDerivedClassWrap._s_set_TestDelegate));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(TutorialDerivedClassWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0006C380 File Offset: 0x0006A580
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					DerivedClass gen_ret = new DerivedClass();
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
			return Lua.luaL_error(L, "invalid arguments to Tutorial.DerivedClass constructor!");
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0006C404 File Offset: 0x0006A604
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __AddMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<DerivedClass>(L, 1) && translator.Assignable<DerivedClass>(L, 2);
				if (flag)
				{
					DerivedClass leftside = (DerivedClass)translator.GetObject(L, 1, typeof(DerivedClass));
					DerivedClass rightside = (DerivedClass)translator.GetObject(L, 2, typeof(DerivedClass));
					translator.Push(L, leftside + rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of + operator, need Tutorial.DerivedClass!");
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0006C4C8 File Offset: 0x0006A6C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DMFunc(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.DMFunc();
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

		// Token: 0x06000DDA RID: 3546 RVA: 0x0006C530 File Offset: 0x0006A730
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ComplexFunc(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				Param1 _p;
				translator.Get<Param1>(L, 2, out _p);
				int _p2 = Lua.xlua_tointeger(L, 3);
				Action _luafunc = translator.GetDelegate<Action>(L, 4);
				string _p3;
				Action _csfunc;
				double gen_ret = gen_to_be_invoked.ComplexFunc(_p, ref _p2, out _p3, _luafunc, out _csfunc);
				Lua.lua_pushnumber(L, gen_ret);
				Lua.xlua_pushinteger(L, _p2);
				Lua.lua_pushstring(L, _p3);
				translator.Push(L, _csfunc);
				result = 4;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0006C5E8 File Offset: 0x0006A7E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TestFunc(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					int _i = Lua.xlua_tointeger(L, 2);
					gen_to_be_invoked.TestFunc(_i);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _i2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.TestFunc(_i2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to Tutorial.DerivedClass.TestFunc!");
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0006C6CC File Offset: 0x0006A8CC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DefaultValueFunc(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 4) || Lua.lua_type(L, 4) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					int _a = Lua.xlua_tointeger(L, 2);
					string _b = Lua.lua_tostring(L, 3);
					string _c = Lua.lua_tostring(L, 4);
					gen_to_be_invoked.DefaultValueFunc(_a, _b, _c);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					int _a2 = Lua.xlua_tointeger(L, 2);
					string _b2 = Lua.lua_tostring(L, 3);
					gen_to_be_invoked.DefaultValueFunc(_a2, _b2, null);
					return 0;
				}
				bool flag3 = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag3)
				{
					int _a3 = Lua.xlua_tointeger(L, 2);
					gen_to_be_invoked.DefaultValueFunc(_a3, "cccc", null);
					return 0;
				}
				bool flag4 = gen_param_count == 1;
				if (flag4)
				{
					gen_to_be_invoked.DefaultValueFunc(100, "cccc", null);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to Tutorial.DerivedClass.DefaultValueFunc!");
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0006C868 File Offset: 0x0006AA68
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_VariableParamsFunc(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				int _a = Lua.xlua_tointeger(L, 2);
				string[] _strs = translator.GetParams<string>(L, 3);
				gen_to_be_invoked.VariableParamsFunc(_a, _strs);
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

		// Token: 0x06000DDE RID: 3550 RVA: 0x0006C8E8 File Offset: 0x0006AAE8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_EnumTestFunc(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				TestEnum _e;
				translator.Get(L, 2, out _e);
				TestEnum gen_ret = gen_to_be_invoked.EnumTestFunc(_e);
				translator.PushTutorialTestEnum(L, gen_ret);
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

		// Token: 0x06000DDF RID: 3551 RVA: 0x0006C96C File Offset: 0x0006AB6C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CallEvent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.CallEvent();
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

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0006C9D4 File Offset: 0x0006ABD4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TestLong(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				long _n = Lua.lua_toint64(L, 2);
				ulong gen_ret = gen_to_be_invoked.TestLong(_n);
				Lua.lua_pushuint64(L, gen_ret);
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

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0006CA54 File Offset: 0x0006AC54
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetCalc(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				ICalc gen_ret = gen_to_be_invoked.GetCalc();
				translator.PushAny(L, gen_ret);
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

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0006CAC8 File Offset: 0x0006ACC8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetSomeData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				int gen_ret = gen_to_be_invoked.GetSomeData();
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

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0006CB3C File Offset: 0x0006AD3C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GenericMethodOfString(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.GenericMethodOfString();
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

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0006CBA4 File Offset: 0x0006ADA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_DMF(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.DMF);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0006CC14 File Offset: 0x0006AE14
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_TestDelegate(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.TestDelegate);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0006CC88 File Offset: 0x0006AE88
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_DMF(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.DMF = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0006CCFC File Offset: 0x0006AEFC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_TestDelegate(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.TestDelegate = translator.GetDelegate<Action<string>>(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0006CD70 File Offset: 0x0006AF70
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _e_TestEvent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				DerivedClass gen_to_be_invoked = (DerivedClass)translator.FastGetCSObj(L, 1);
				Action gen_delegate = translator.GetDelegate<Action>(L, 3);
				bool flag = gen_delegate == null;
				if (flag)
				{
					return Lua.luaL_error(L, "#3 need System.Action!");
				}
				bool flag2 = gen_param_count == 3;
				if (flag2)
				{
					bool flag3 = Lua.xlua_is_eq_str(L, 2, "+");
					if (flag3)
					{
						gen_to_be_invoked.TestEvent += gen_delegate;
						return 0;
					}
					bool flag4 = Lua.xlua_is_eq_str(L, 2, "-");
					if (flag4)
					{
						gen_to_be_invoked.TestEvent -= gen_delegate;
						return 0;
					}
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			Lua.luaL_error(L, "invalid arguments to Tutorial.DerivedClass.TestEvent!");
			return 0;
		}
	}
}

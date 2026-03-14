using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001AB RID: 427
	public class SystemObjectWrap
	{
		// Token: 0x06000DB9 RID: 3513 RVA: 0x0006B550 File Offset: 0x00069750
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(object);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 0, 0, -1);
			Utils.RegisterFunc(L, -3, "Equals", new lua_CSFunction(SystemObjectWrap._m_Equals));
			Utils.RegisterFunc(L, -3, "GetHashCode", new lua_CSFunction(SystemObjectWrap._m_GetHashCode));
			Utils.RegisterFunc(L, -3, "GetType", new lua_CSFunction(SystemObjectWrap._m_GetType));
			Utils.RegisterFunc(L, -3, "ToString", new lua_CSFunction(SystemObjectWrap._m_ToString));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(SystemObjectWrap.__CreateInstance), 3, 0, 0);
			Utils.RegisterFunc(L, -4, "Equals", new lua_CSFunction(SystemObjectWrap._m_Equals_xlua_st_));
			Utils.RegisterFunc(L, -4, "ReferenceEquals", new lua_CSFunction(SystemObjectWrap._m_ReferenceEquals_xlua_st_));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0006B650 File Offset: 0x00069850
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					object gen_ret = new object();
					translator.PushAny(L, gen_ret);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to object constructor!");
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0006B6D4 File Offset: 0x000698D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Equals(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
				object _obj = translator.GetObject(L, 2, typeof(object));
				bool gen_ret = gen_to_be_invoked.Equals(_obj);
				Lua.lua_pushboolean(L, gen_ret);
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

		// Token: 0x06000DBC RID: 3516 RVA: 0x0006B758 File Offset: 0x00069958
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Equals_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object _objA = translator.GetObject(L, 1, typeof(object));
				object _objB = translator.GetObject(L, 2, typeof(object));
				bool gen_ret = object.Equals(_objA, _objB);
				Lua.lua_pushboolean(L, gen_ret);
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

		// Token: 0x06000DBD RID: 3517 RVA: 0x0006B7E8 File Offset: 0x000699E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetHashCode(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
				int gen_ret = gen_to_be_invoked.GetHashCode();
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

		// Token: 0x06000DBE RID: 3518 RVA: 0x0006B858 File Offset: 0x00069A58
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetType(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
				Type gen_ret = gen_to_be_invoked.GetType();
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

		// Token: 0x06000DBF RID: 3519 RVA: 0x0006B8C8 File Offset: 0x00069AC8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToString(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
				string gen_ret = gen_to_be_invoked.ToString();
				Lua.lua_pushstring(L, gen_ret);
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

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0006B938 File Offset: 0x00069B38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ReferenceEquals_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object _objA = translator.GetObject(L, 1, typeof(object));
				object _objB = translator.GetObject(L, 2, typeof(object));
				bool gen_ret = _objA == _objB;
				Lua.lua_pushboolean(L, gen_ret);
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

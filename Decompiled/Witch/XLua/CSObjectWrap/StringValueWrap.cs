using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001A7 RID: 423
	public class StringValueWrap
	{
		// Token: 0x06000D70 RID: 3440 RVA: 0x000680F8 File Offset: 0x000662F8
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(StringValue);
			Utils.BeginObjectRegister(type, L, translator, 1, 7, 0, 0, -1);
			Utils.RegisterFunc(L, -4, "__eq", new lua_CSFunction(StringValueWrap.__EqMeta));
			Utils.RegisterFunc(L, -3, "ToString", new lua_CSFunction(StringValueWrap._m_ToString));
			Utils.RegisterFunc(L, -3, "GetString", new lua_CSFunction(StringValueWrap._m_GetString));
			Utils.RegisterFunc(L, -3, "TryGetInt", new lua_CSFunction(StringValueWrap._m_TryGetInt));
			Utils.RegisterFunc(L, -3, "TryGetFloat", new lua_CSFunction(StringValueWrap._m_TryGetFloat));
			Utils.RegisterFunc(L, -3, "TryGetString", new lua_CSFunction(StringValueWrap._m_TryGetString));
			Utils.RegisterFunc(L, -3, "ToInt", new lua_CSFunction(StringValueWrap._m_ToInt));
			Utils.RegisterFunc(L, -3, "ToFloat", new lua_CSFunction(StringValueWrap._m_ToFloat));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(StringValueWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0006822C File Offset: 0x0006642C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					int _v = Lua.xlua_tointeger(L, 2);
					StringValue gen_ret = new StringValue(_v);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					float _v2 = (float)Lua.lua_tonumber(L, 2);
					StringValue gen_ret2 = new StringValue(_v2);
					translator.Push(L, gen_ret2);
					return 1;
				}
				bool flag3 = Lua.lua_gettop(L) == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag3)
				{
					string _s = Lua.lua_tostring(L, 2);
					StringValue gen_ret3 = new StringValue(_s);
					translator.Push(L, gen_ret3);
					return 1;
				}
				bool flag4 = Lua.lua_gettop(L) == 1;
				if (flag4)
				{
					translator.Push(L, default(StringValue));
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to StringValue constructor!");
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000683A0 File Offset: 0x000665A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __EqMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<StringValue>(L, 1) && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					StringValue leftside;
					translator.Get<StringValue>(L, 1, out leftside);
					string rightside = Lua.lua_tostring(L, 2);
					Lua.lua_pushboolean(L, leftside == rightside);
					return 1;
				}
				bool flag2 = (Lua.lua_isnil(L, 1) || Lua.lua_type(L, 1) == LuaTypes.LUA_TSTRING) && translator.Assignable<StringValue>(L, 2);
				if (flag2)
				{
					string leftside2 = Lua.lua_tostring(L, 1);
					StringValue rightside2;
					translator.Get<StringValue>(L, 2, out rightside2);
					Lua.lua_pushboolean(L, leftside2 == rightside2);
					return 1;
				}
				bool flag3 = translator.Assignable<StringValue>(L, 1) && translator.Assignable<StringValue>(L, 2);
				if (flag3)
				{
					StringValue leftside3;
					translator.Get<StringValue>(L, 1, out leftside3);
					StringValue rightside3;
					translator.Get<StringValue>(L, 2, out rightside3);
					Lua.lua_pushboolean(L, leftside3 == rightside3);
					return 1;
				}
				bool flag4 = translator.Assignable<StringValue>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag4)
				{
					StringValue leftside4;
					translator.Get<StringValue>(L, 1, out leftside4);
					int rightside4 = Lua.xlua_tointeger(L, 2);
					Lua.lua_pushboolean(L, leftside4 == rightside4);
					return 1;
				}
				bool flag5 = LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && translator.Assignable<StringValue>(L, 2);
				if (flag5)
				{
					int leftside5 = Lua.xlua_tointeger(L, 1);
					StringValue rightside5;
					translator.Get<StringValue>(L, 2, out rightside5);
					Lua.lua_pushboolean(L, leftside5 == rightside5);
					return 1;
				}
				bool flag6 = translator.Assignable<StringValue>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag6)
				{
					StringValue leftside6;
					translator.Get<StringValue>(L, 1, out leftside6);
					float rightside6 = (float)Lua.lua_tonumber(L, 2);
					Lua.lua_pushboolean(L, leftside6 == rightside6);
					return 1;
				}
				bool flag7 = LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && translator.Assignable<StringValue>(L, 2);
				if (flag7)
				{
					float leftside7 = (float)Lua.lua_tonumber(L, 1);
					StringValue rightside7;
					translator.Get<StringValue>(L, 2, out rightside7);
					Lua.lua_pushboolean(L, leftside7 == rightside7);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of == operator, need StringValue!");
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0006861C File Offset: 0x0006681C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToString(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StringValue gen_to_be_invoked;
				translator.Get<StringValue>(L, 1, out gen_to_be_invoked);
				string gen_ret = gen_to_be_invoked.ToString();
				Lua.lua_pushstring(L, gen_ret);
				translator.Update(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000D74 RID: 3444 RVA: 0x000686A4 File Offset: 0x000668A4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetString(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StringValue gen_to_be_invoked;
				translator.Get<StringValue>(L, 1, out gen_to_be_invoked);
				string gen_ret = gen_to_be_invoked.GetString();
				Lua.lua_pushstring(L, gen_ret);
				translator.Update(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000D75 RID: 3445 RVA: 0x00068724 File Offset: 0x00066924
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetInt(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StringValue gen_to_be_invoked;
				translator.Get<StringValue>(L, 1, out gen_to_be_invoked);
				int _v;
				bool gen_ret = gen_to_be_invoked.TryGetInt(out _v);
				Lua.lua_pushboolean(L, gen_ret);
				Lua.xlua_pushinteger(L, _v);
				translator.Update(L, 1, gen_to_be_invoked);
				result = 2;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000687B0 File Offset: 0x000669B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetFloat(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StringValue gen_to_be_invoked;
				translator.Get<StringValue>(L, 1, out gen_to_be_invoked);
				float _v;
				bool gen_ret = gen_to_be_invoked.TryGetFloat(out _v);
				Lua.lua_pushboolean(L, gen_ret);
				Lua.lua_pushnumber(L, (double)_v);
				translator.Update(L, 1, gen_to_be_invoked);
				result = 2;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00068840 File Offset: 0x00066A40
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetString(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StringValue gen_to_be_invoked;
				translator.Get<StringValue>(L, 1, out gen_to_be_invoked);
				string _v;
				bool gen_ret = gen_to_be_invoked.TryGetString(out _v);
				Lua.lua_pushboolean(L, gen_ret);
				Lua.lua_pushstring(L, _v);
				translator.Update(L, 1, gen_to_be_invoked);
				result = 2;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000688CC File Offset: 0x00066ACC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToInt(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StringValue gen_to_be_invoked;
				translator.Get<StringValue>(L, 1, out gen_to_be_invoked);
				int gen_ret = gen_to_be_invoked.ToInt();
				Lua.xlua_pushinteger(L, gen_ret);
				translator.Update(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000D79 RID: 3449 RVA: 0x0006894C File Offset: 0x00066B4C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToFloat(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StringValue gen_to_be_invoked;
				translator.Get<StringValue>(L, 1, out gen_to_be_invoked);
				float gen_ret = gen_to_be_invoked.ToFloat();
				Lua.lua_pushnumber(L, (double)gen_ret);
				translator.Update(L, 1, gen_to_be_invoked);
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

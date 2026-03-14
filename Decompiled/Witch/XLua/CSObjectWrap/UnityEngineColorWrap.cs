using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B2 RID: 434
	public class UnityEngineColorWrap
	{
		// Token: 0x06000DF4 RID: 3572 RVA: 0x0006D210 File Offset: 0x0006B410
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Color);
			Utils.BeginObjectRegister(type, L, translator, 5, 3, 8, 4, -1);
			Utils.RegisterFunc(L, -4, "__add", new lua_CSFunction(UnityEngineColorWrap.__AddMeta));
			Utils.RegisterFunc(L, -4, "__sub", new lua_CSFunction(UnityEngineColorWrap.__SubMeta));
			Utils.RegisterFunc(L, -4, "__mul", new lua_CSFunction(UnityEngineColorWrap.__MulMeta));
			Utils.RegisterFunc(L, -4, "__div", new lua_CSFunction(UnityEngineColorWrap.__DivMeta));
			Utils.RegisterFunc(L, -4, "__eq", new lua_CSFunction(UnityEngineColorWrap.__EqMeta));
			Utils.RegisterFunc(L, -3, "ToString", new lua_CSFunction(UnityEngineColorWrap._m_ToString));
			Utils.RegisterFunc(L, -3, "GetHashCode", new lua_CSFunction(UnityEngineColorWrap._m_GetHashCode));
			Utils.RegisterFunc(L, -3, "Equals", new lua_CSFunction(UnityEngineColorWrap._m_Equals));
			Utils.RegisterFunc(L, -2, "grayscale", new lua_CSFunction(UnityEngineColorWrap._g_get_grayscale));
			Utils.RegisterFunc(L, -2, "linear", new lua_CSFunction(UnityEngineColorWrap._g_get_linear));
			Utils.RegisterFunc(L, -2, "gamma", new lua_CSFunction(UnityEngineColorWrap._g_get_gamma));
			Utils.RegisterFunc(L, -2, "maxColorComponent", new lua_CSFunction(UnityEngineColorWrap._g_get_maxColorComponent));
			Utils.RegisterFunc(L, -2, "r", new lua_CSFunction(UnityEngineColorWrap._g_get_r));
			Utils.RegisterFunc(L, -2, "g", new lua_CSFunction(UnityEngineColorWrap._g_get_g));
			Utils.RegisterFunc(L, -2, "b", new lua_CSFunction(UnityEngineColorWrap._g_get_b));
			Utils.RegisterFunc(L, -2, "a", new lua_CSFunction(UnityEngineColorWrap._g_get_a));
			Utils.RegisterFunc(L, -1, "r", new lua_CSFunction(UnityEngineColorWrap._s_set_r));
			Utils.RegisterFunc(L, -1, "g", new lua_CSFunction(UnityEngineColorWrap._s_set_g));
			Utils.RegisterFunc(L, -1, "b", new lua_CSFunction(UnityEngineColorWrap._s_set_b));
			Utils.RegisterFunc(L, -1, "a", new lua_CSFunction(UnityEngineColorWrap._s_set_a));
			Utils.EndObjectRegister(type, L, translator, new lua_CSFunction(UnityEngineColorWrap.__CSIndexer), new lua_CSFunction(UnityEngineColorWrap.__NewIndexer), null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineColorWrap.__CreateInstance), 5, 11, 0);
			Utils.RegisterFunc(L, -4, "Lerp", new lua_CSFunction(UnityEngineColorWrap._m_Lerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "LerpUnclamped", new lua_CSFunction(UnityEngineColorWrap._m_LerpUnclamped_xlua_st_));
			Utils.RegisterFunc(L, -4, "RGBToHSV", new lua_CSFunction(UnityEngineColorWrap._m_RGBToHSV_xlua_st_));
			Utils.RegisterFunc(L, -4, "HSVToRGB", new lua_CSFunction(UnityEngineColorWrap._m_HSVToRGB_xlua_st_));
			Utils.RegisterFunc(L, -2, "red", new lua_CSFunction(UnityEngineColorWrap._g_get_red));
			Utils.RegisterFunc(L, -2, "green", new lua_CSFunction(UnityEngineColorWrap._g_get_green));
			Utils.RegisterFunc(L, -2, "blue", new lua_CSFunction(UnityEngineColorWrap._g_get_blue));
			Utils.RegisterFunc(L, -2, "white", new lua_CSFunction(UnityEngineColorWrap._g_get_white));
			Utils.RegisterFunc(L, -2, "black", new lua_CSFunction(UnityEngineColorWrap._g_get_black));
			Utils.RegisterFunc(L, -2, "yellow", new lua_CSFunction(UnityEngineColorWrap._g_get_yellow));
			Utils.RegisterFunc(L, -2, "cyan", new lua_CSFunction(UnityEngineColorWrap._g_get_cyan));
			Utils.RegisterFunc(L, -2, "magenta", new lua_CSFunction(UnityEngineColorWrap._g_get_magenta));
			Utils.RegisterFunc(L, -2, "gray", new lua_CSFunction(UnityEngineColorWrap._g_get_gray));
			Utils.RegisterFunc(L, -2, "grey", new lua_CSFunction(UnityEngineColorWrap._g_get_grey));
			Utils.RegisterFunc(L, -2, "clear", new lua_CSFunction(UnityEngineColorWrap._g_get_clear));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0006D614 File Offset: 0x0006B814
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5);
				if (flag)
				{
					float _r = (float)Lua.lua_tonumber(L, 2);
					float _g = (float)Lua.lua_tonumber(L, 3);
					float _b = (float)Lua.lua_tonumber(L, 4);
					float _a = (float)Lua.lua_tonumber(L, 5);
					Color gen_ret = new Color(_r, _g, _b, _a);
					translator.PushUnityEngineColor(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag2)
				{
					float _r2 = (float)Lua.lua_tonumber(L, 2);
					float _g2 = (float)Lua.lua_tonumber(L, 3);
					float _b2 = (float)Lua.lua_tonumber(L, 4);
					Color gen_ret2 = new Color(_r2, _g2, _b2);
					translator.PushUnityEngineColor(L, gen_ret2);
					return 1;
				}
				bool flag3 = Lua.lua_gettop(L) == 1;
				if (flag3)
				{
					translator.PushUnityEngineColor(L, default(Color));
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Color constructor!");
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0006D794 File Offset: 0x0006B994
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __CSIndexer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Color>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Color gen_to_be_invoked;
					translator.Get(L, 1, out gen_to_be_invoked);
					int index = Lua.xlua_tointeger(L, 2);
					Lua.lua_pushboolean(L, true);
					Lua.lua_pushnumber(L, (double)gen_to_be_invoked[index]);
					return 2;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			Lua.lua_pushboolean(L, false);
			return 1;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0006D844 File Offset: 0x0006BA44
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __NewIndexer(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				bool flag = translator.Assignable<Color>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					Color gen_to_be_invoked;
					translator.Get(L, 1, out gen_to_be_invoked);
					int key = Lua.xlua_tointeger(L, 2);
					gen_to_be_invoked[key] = (float)Lua.lua_tonumber(L, 3);
					Lua.lua_pushboolean(L, true);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			Lua.lua_pushboolean(L, false);
			return 1;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0006D900 File Offset: 0x0006BB00
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __AddMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Color>(L, 1) && translator.Assignable<Color>(L, 2);
				if (flag)
				{
					Color leftside;
					translator.Get(L, 1, out leftside);
					Color rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineColor(L, leftside + rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Color!");
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0006D9A8 File Offset: 0x0006BBA8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __SubMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Color>(L, 1) && translator.Assignable<Color>(L, 2);
				if (flag)
				{
					Color leftside;
					translator.Get(L, 1, out leftside);
					Color rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineColor(L, leftside - rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Color!");
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0006DA50 File Offset: 0x0006BC50
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __MulMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Color>(L, 1) && translator.Assignable<Color>(L, 2);
				if (flag)
				{
					Color leftside;
					translator.Get(L, 1, out leftside);
					Color rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineColor(L, leftside * rightside);
					return 1;
				}
				bool flag2 = translator.Assignable<Color>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					Color leftside2;
					translator.Get(L, 1, out leftside2);
					float rightside2 = (float)Lua.lua_tonumber(L, 2);
					translator.PushUnityEngineColor(L, leftside2 * rightside2);
					return 1;
				}
				bool flag3 = LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && translator.Assignable<Color>(L, 2);
				if (flag3)
				{
					float leftside3 = (float)Lua.lua_tonumber(L, 1);
					Color rightside3;
					translator.Get(L, 2, out rightside3);
					translator.PushUnityEngineColor(L, leftside3 * rightside3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Color!");
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0006DB8C File Offset: 0x0006BD8C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __DivMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Color>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Color leftside;
					translator.Get(L, 1, out leftside);
					float rightside = (float)Lua.lua_tonumber(L, 2);
					translator.PushUnityEngineColor(L, leftside / rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Color!");
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0006DC34 File Offset: 0x0006BE34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __EqMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Color>(L, 1) && translator.Assignable<Color>(L, 2);
				if (flag)
				{
					Color leftside;
					translator.Get(L, 1, out leftside);
					Color rightside;
					translator.Get(L, 2, out rightside);
					Lua.lua_pushboolean(L, leftside == rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Color!");
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0006DCDC File Offset: 0x0006BEDC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToString(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					string gen_ret = gen_to_be_invoked.ToString();
					Lua.lua_pushstring(L, gen_ret);
					translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _format = Lua.lua_tostring(L, 2);
					string gen_ret2 = gen_to_be_invoked.ToString(_format);
					Lua.lua_pushstring(L, gen_ret2);
					translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<IFormatProvider>(L, 3);
				if (flag3)
				{
					string _format2 = Lua.lua_tostring(L, 2);
					IFormatProvider _formatProvider = (IFormatProvider)translator.GetObject(L, 3, typeof(IFormatProvider));
					string gen_ret3 = gen_to_be_invoked.ToString(_format2, _formatProvider);
					Lua.lua_pushstring(L, gen_ret3);
					translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Color.ToString!");
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0006DE54 File Offset: 0x0006C054
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetHashCode(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_ret = gen_to_be_invoked.GetHashCode();
				Lua.xlua_pushinteger(L, gen_ret);
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000DFF RID: 3583 RVA: 0x0006DED4 File Offset: 0x0006C0D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Equals(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<object>(L, 2);
				if (flag)
				{
					object _other = translator.GetObject(L, 2, typeof(object));
					bool gen_ret = gen_to_be_invoked.Equals(_other);
					Lua.lua_pushboolean(L, gen_ret);
					translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Color>(L, 2);
				if (flag2)
				{
					Color _other2;
					translator.Get(L, 2, out _other2);
					bool gen_ret2 = gen_to_be_invoked.Equals(_other2);
					Lua.lua_pushboolean(L, gen_ret2);
					translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Color.Equals!");
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0006DFE0 File Offset: 0x0006C1E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Lerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color _a;
				translator.Get(L, 1, out _a);
				Color _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Color gen_ret = Color.Lerp(_a, _b, _t);
				translator.PushUnityEngineColor(L, gen_ret);
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

		// Token: 0x06000E01 RID: 3585 RVA: 0x0006E06C File Offset: 0x0006C26C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LerpUnclamped_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color _a;
				translator.Get(L, 1, out _a);
				Color _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Color gen_ret = Color.LerpUnclamped(_a, _b, _t);
				translator.PushUnityEngineColor(L, gen_ret);
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

		// Token: 0x06000E02 RID: 3586 RVA: 0x0006E0F8 File Offset: 0x0006C2F8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RGBToHSV_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color _rgbColor;
				translator.Get(L, 1, out _rgbColor);
				float _H;
				float _S;
				float _V;
				Color.RGBToHSV(_rgbColor, out _H, out _S, out _V);
				Lua.lua_pushnumber(L, (double)_H);
				Lua.lua_pushnumber(L, (double)_S);
				Lua.lua_pushnumber(L, (double)_V);
				result = 3;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0006E184 File Offset: 0x0006C384
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_HSVToRGB_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					float _H = (float)Lua.lua_tonumber(L, 1);
					float _S = (float)Lua.lua_tonumber(L, 2);
					float _V = (float)Lua.lua_tonumber(L, 3);
					Color gen_ret = Color.HSVToRGB(_H, _S, _V);
					translator.PushUnityEngineColor(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 4);
				if (flag2)
				{
					float _H2 = (float)Lua.lua_tonumber(L, 1);
					float _S2 = (float)Lua.lua_tonumber(L, 2);
					float _V2 = (float)Lua.lua_tonumber(L, 3);
					bool _hdr = Lua.lua_toboolean(L, 4);
					Color gen_ret2 = Color.HSVToRGB(_H2, _S2, _V2, _hdr);
					translator.PushUnityEngineColor(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Color.HSVToRGB!");
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0006E2D0 File Offset: 0x0006C4D0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_red(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.red);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0006E334 File Offset: 0x0006C534
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_green(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.green);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0006E398 File Offset: 0x0006C598
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_blue(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.blue);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0006E3FC File Offset: 0x0006C5FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_white(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.white);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0006E460 File Offset: 0x0006C660
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_black(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.black);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0006E4C4 File Offset: 0x0006C6C4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_yellow(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.yellow);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0006E528 File Offset: 0x0006C728
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_cyan(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.cyan);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0006E58C File Offset: 0x0006C78C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_magenta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.magenta);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0006E5F0 File Offset: 0x0006C7F0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_gray(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.gray);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0006E654 File Offset: 0x0006C854
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_grey(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.grey);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0006E6B8 File Offset: 0x0006C8B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_clear(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineColor(L, Color.clear);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0006E71C File Offset: 0x0006C91C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_grayscale(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.grayscale);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0006E78C File Offset: 0x0006C98C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_linear(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				translator.PushUnityEngineColor(L, gen_to_be_invoked.linear);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0006E7FC File Offset: 0x0006C9FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_gamma(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				translator.PushUnityEngineColor(L, gen_to_be_invoked.gamma);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0006E86C File Offset: 0x0006CA6C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_maxColorComponent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.maxColorComponent);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0006E8DC File Offset: 0x0006CADC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_r(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.r);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0006E94C File Offset: 0x0006CB4C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_g(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.g);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0006E9BC File Offset: 0x0006CBBC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_b(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.b);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0006EA2C File Offset: 0x0006CC2C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_a(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.a);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0006EA9C File Offset: 0x0006CC9C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_r(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.r = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0006EB18 File Offset: 0x0006CD18
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_g(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.g = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0006EB94 File Offset: 0x0006CD94
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_b(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.b = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0006EC10 File Offset: 0x0006CE10
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_a(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Color gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.a = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineColor(L, 1, gen_to_be_invoked);
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

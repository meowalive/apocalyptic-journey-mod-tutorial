using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001BB RID: 443
	public class UnityEngineVector2Wrap
	{
		// Token: 0x06000F2C RID: 3884 RVA: 0x0007C90C File Offset: 0x0007AB0C
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Vector2);
			Utils.BeginObjectRegister(type, L, translator, 6, 7, 5, 2, -1);
			Utils.RegisterFunc(L, -4, "__add", new lua_CSFunction(UnityEngineVector2Wrap.__AddMeta));
			Utils.RegisterFunc(L, -4, "__sub", new lua_CSFunction(UnityEngineVector2Wrap.__SubMeta));
			Utils.RegisterFunc(L, -4, "__mul", new lua_CSFunction(UnityEngineVector2Wrap.__MulMeta));
			Utils.RegisterFunc(L, -4, "__div", new lua_CSFunction(UnityEngineVector2Wrap.__DivMeta));
			Utils.RegisterFunc(L, -4, "__unm", new lua_CSFunction(UnityEngineVector2Wrap.__UnmMeta));
			Utils.RegisterFunc(L, -4, "__eq", new lua_CSFunction(UnityEngineVector2Wrap.__EqMeta));
			Utils.RegisterFunc(L, -3, "Set", new lua_CSFunction(UnityEngineVector2Wrap._m_Set));
			Utils.RegisterFunc(L, -3, "Scale", new lua_CSFunction(UnityEngineVector2Wrap._m_Scale));
			Utils.RegisterFunc(L, -3, "Normalize", new lua_CSFunction(UnityEngineVector2Wrap._m_Normalize));
			Utils.RegisterFunc(L, -3, "ToString", new lua_CSFunction(UnityEngineVector2Wrap._m_ToString));
			Utils.RegisterFunc(L, -3, "GetHashCode", new lua_CSFunction(UnityEngineVector2Wrap._m_GetHashCode));
			Utils.RegisterFunc(L, -3, "Equals", new lua_CSFunction(UnityEngineVector2Wrap._m_Equals));
			Utils.RegisterFunc(L, -3, "SqrMagnitude", new lua_CSFunction(UnityEngineVector2Wrap._m_SqrMagnitude));
			Utils.RegisterFunc(L, -2, "normalized", new lua_CSFunction(UnityEngineVector2Wrap._g_get_normalized));
			Utils.RegisterFunc(L, -2, "magnitude", new lua_CSFunction(UnityEngineVector2Wrap._g_get_magnitude));
			Utils.RegisterFunc(L, -2, "sqrMagnitude", new lua_CSFunction(UnityEngineVector2Wrap._g_get_sqrMagnitude));
			Utils.RegisterFunc(L, -2, "x", new lua_CSFunction(UnityEngineVector2Wrap._g_get_x));
			Utils.RegisterFunc(L, -2, "y", new lua_CSFunction(UnityEngineVector2Wrap._g_get_y));
			Utils.RegisterFunc(L, -1, "x", new lua_CSFunction(UnityEngineVector2Wrap._s_set_x));
			Utils.RegisterFunc(L, -1, "y", new lua_CSFunction(UnityEngineVector2Wrap._s_set_y));
			Utils.EndObjectRegister(type, L, translator, new lua_CSFunction(UnityEngineVector2Wrap.__CSIndexer), new lua_CSFunction(UnityEngineVector2Wrap.__NewIndexer), null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineVector2Wrap.__CreateInstance), 18, 8, 0);
			Utils.RegisterFunc(L, -4, "Lerp", new lua_CSFunction(UnityEngineVector2Wrap._m_Lerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "LerpUnclamped", new lua_CSFunction(UnityEngineVector2Wrap._m_LerpUnclamped_xlua_st_));
			Utils.RegisterFunc(L, -4, "MoveTowards", new lua_CSFunction(UnityEngineVector2Wrap._m_MoveTowards_xlua_st_));
			Utils.RegisterFunc(L, -4, "Scale", new lua_CSFunction(UnityEngineVector2Wrap._m_Scale_xlua_st_));
			Utils.RegisterFunc(L, -4, "Reflect", new lua_CSFunction(UnityEngineVector2Wrap._m_Reflect_xlua_st_));
			Utils.RegisterFunc(L, -4, "Perpendicular", new lua_CSFunction(UnityEngineVector2Wrap._m_Perpendicular_xlua_st_));
			Utils.RegisterFunc(L, -4, "Dot", new lua_CSFunction(UnityEngineVector2Wrap._m_Dot_xlua_st_));
			Utils.RegisterFunc(L, -4, "Angle", new lua_CSFunction(UnityEngineVector2Wrap._m_Angle_xlua_st_));
			Utils.RegisterFunc(L, -4, "SignedAngle", new lua_CSFunction(UnityEngineVector2Wrap._m_SignedAngle_xlua_st_));
			Utils.RegisterFunc(L, -4, "Distance", new lua_CSFunction(UnityEngineVector2Wrap._m_Distance_xlua_st_));
			Utils.RegisterFunc(L, -4, "ClampMagnitude", new lua_CSFunction(UnityEngineVector2Wrap._m_ClampMagnitude_xlua_st_));
			Utils.RegisterFunc(L, -4, "SqrMagnitude", new lua_CSFunction(UnityEngineVector2Wrap._m_SqrMagnitude_xlua_st_));
			Utils.RegisterFunc(L, -4, "Min", new lua_CSFunction(UnityEngineVector2Wrap._m_Min_xlua_st_));
			Utils.RegisterFunc(L, -4, "Max", new lua_CSFunction(UnityEngineVector2Wrap._m_Max_xlua_st_));
			Utils.RegisterFunc(L, -4, "SmoothDamp", new lua_CSFunction(UnityEngineVector2Wrap._m_SmoothDamp_xlua_st_));
			Utils.RegisterObject(L, translator, -4, "kEpsilon", 1E-05f);
			Utils.RegisterObject(L, translator, -4, "kEpsilonNormalSqrt", 1E-15f);
			Utils.RegisterFunc(L, -2, "zero", new lua_CSFunction(UnityEngineVector2Wrap._g_get_zero));
			Utils.RegisterFunc(L, -2, "one", new lua_CSFunction(UnityEngineVector2Wrap._g_get_one));
			Utils.RegisterFunc(L, -2, "up", new lua_CSFunction(UnityEngineVector2Wrap._g_get_up));
			Utils.RegisterFunc(L, -2, "down", new lua_CSFunction(UnityEngineVector2Wrap._g_get_down));
			Utils.RegisterFunc(L, -2, "left", new lua_CSFunction(UnityEngineVector2Wrap._g_get_left));
			Utils.RegisterFunc(L, -2, "right", new lua_CSFunction(UnityEngineVector2Wrap._g_get_right));
			Utils.RegisterFunc(L, -2, "positiveInfinity", new lua_CSFunction(UnityEngineVector2Wrap._g_get_positiveInfinity));
			Utils.RegisterFunc(L, -2, "negativeInfinity", new lua_CSFunction(UnityEngineVector2Wrap._g_get_negativeInfinity));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0007CE14 File Offset: 0x0007B014
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					Vector2 gen_ret = new Vector2(_x, _y);
					translator.PushUnityEngineVector2(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 1;
				if (flag2)
				{
					translator.PushUnityEngineVector2(L, default(Vector2));
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector2 constructor!");
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0007CEF0 File Offset: 0x0007B0F0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __CSIndexer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector2>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Vector2 gen_to_be_invoked;
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

		// Token: 0x06000F2F RID: 3887 RVA: 0x0007CFA0 File Offset: 0x0007B1A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __NewIndexer(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				bool flag = translator.Assignable<Vector2>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					Vector2 gen_to_be_invoked;
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

		// Token: 0x06000F30 RID: 3888 RVA: 0x0007D05C File Offset: 0x0007B25C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __AddMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector2>(L, 1) && translator.Assignable<Vector2>(L, 2);
				if (flag)
				{
					Vector2 leftside;
					translator.Get(L, 1, out leftside);
					Vector2 rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineVector2(L, leftside + rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Vector2!");
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0007D104 File Offset: 0x0007B304
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __SubMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector2>(L, 1) && translator.Assignable<Vector2>(L, 2);
				if (flag)
				{
					Vector2 leftside;
					translator.Get(L, 1, out leftside);
					Vector2 rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineVector2(L, leftside - rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Vector2!");
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0007D1AC File Offset: 0x0007B3AC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __MulMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector2>(L, 1) && translator.Assignable<Vector2>(L, 2);
				if (flag)
				{
					Vector2 leftside;
					translator.Get(L, 1, out leftside);
					Vector2 rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineVector2(L, leftside * rightside);
					return 1;
				}
				bool flag2 = translator.Assignable<Vector2>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					Vector2 leftside2;
					translator.Get(L, 1, out leftside2);
					float rightside2 = (float)Lua.lua_tonumber(L, 2);
					translator.PushUnityEngineVector2(L, leftside2 * rightside2);
					return 1;
				}
				bool flag3 = LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && translator.Assignable<Vector2>(L, 2);
				if (flag3)
				{
					float leftside3 = (float)Lua.lua_tonumber(L, 1);
					Vector2 rightside3;
					translator.Get(L, 2, out rightside3);
					translator.PushUnityEngineVector2(L, leftside3 * rightside3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Vector2!");
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0007D2E8 File Offset: 0x0007B4E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __DivMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector2>(L, 1) && translator.Assignable<Vector2>(L, 2);
				if (flag)
				{
					Vector2 leftside;
					translator.Get(L, 1, out leftside);
					Vector2 rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineVector2(L, leftside / rightside);
					return 1;
				}
				bool flag2 = translator.Assignable<Vector2>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					Vector2 leftside2;
					translator.Get(L, 1, out leftside2);
					float rightside2 = (float)Lua.lua_tonumber(L, 2);
					translator.PushUnityEngineVector2(L, leftside2 / rightside2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Vector2!");
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0007D3DC File Offset: 0x0007B5DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __UnmMeta(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				Vector2 rightside;
				translator.Get(L, 1, out rightside);
				translator.PushUnityEngineVector2(L, -rightside);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0007D44C File Offset: 0x0007B64C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __EqMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector2>(L, 1) && translator.Assignable<Vector2>(L, 2);
				if (flag)
				{
					Vector2 leftside;
					translator.Get(L, 1, out leftside);
					Vector2 rightside;
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
			return Lua.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Vector2!");
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0007D4F4 File Offset: 0x0007B6F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Set(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				float _newX = (float)Lua.lua_tonumber(L, 2);
				float _newY = (float)Lua.lua_tonumber(L, 3);
				gen_to_be_invoked.Set(_newX, _newY);
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F37 RID: 3895 RVA: 0x0007D580 File Offset: 0x0007B780
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Lerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _a;
				translator.Get(L, 1, out _a);
				Vector2 _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Vector2 gen_ret = Vector2.Lerp(_a, _b, _t);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F38 RID: 3896 RVA: 0x0007D60C File Offset: 0x0007B80C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LerpUnclamped_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _a;
				translator.Get(L, 1, out _a);
				Vector2 _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Vector2 gen_ret = Vector2.LerpUnclamped(_a, _b, _t);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F39 RID: 3897 RVA: 0x0007D698 File Offset: 0x0007B898
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_MoveTowards_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _current;
				translator.Get(L, 1, out _current);
				Vector2 _target;
				translator.Get(L, 2, out _target);
				float _maxDistanceDelta = (float)Lua.lua_tonumber(L, 3);
				Vector2 gen_ret = Vector2.MoveTowards(_current, _target, _maxDistanceDelta);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F3A RID: 3898 RVA: 0x0007D724 File Offset: 0x0007B924
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Scale_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _a;
				translator.Get(L, 1, out _a);
				Vector2 _b;
				translator.Get(L, 2, out _b);
				Vector2 gen_ret = Vector2.Scale(_a, _b);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F3B RID: 3899 RVA: 0x0007D7A4 File Offset: 0x0007B9A4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Scale(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Vector2 _scale;
				translator.Get(L, 2, out _scale);
				gen_to_be_invoked.Scale(_scale);
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F3C RID: 3900 RVA: 0x0007D824 File Offset: 0x0007BA24
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Normalize(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.Normalize();
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F3D RID: 3901 RVA: 0x0007D894 File Offset: 0x0007BA94
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToString(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					string gen_ret = gen_to_be_invoked.ToString();
					Lua.lua_pushstring(L, gen_ret);
					translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _format = Lua.lua_tostring(L, 2);
					string gen_ret2 = gen_to_be_invoked.ToString(_format);
					Lua.lua_pushstring(L, gen_ret2);
					translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<IFormatProvider>(L, 3);
				if (flag3)
				{
					string _format2 = Lua.lua_tostring(L, 2);
					IFormatProvider _formatProvider = (IFormatProvider)translator.GetObject(L, 3, typeof(IFormatProvider));
					string gen_ret3 = gen_to_be_invoked.ToString(_format2, _formatProvider);
					Lua.lua_pushstring(L, gen_ret3);
					translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector2.ToString!");
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0007DA0C File Offset: 0x0007BC0C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetHashCode(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_ret = gen_to_be_invoked.GetHashCode();
				Lua.xlua_pushinteger(L, gen_ret);
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F3F RID: 3903 RVA: 0x0007DA8C File Offset: 0x0007BC8C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Equals(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<object>(L, 2);
				if (flag)
				{
					object _other = translator.GetObject(L, 2, typeof(object));
					bool gen_ret = gen_to_be_invoked.Equals(_other);
					Lua.lua_pushboolean(L, gen_ret);
					translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector2>(L, 2);
				if (flag2)
				{
					Vector2 _other2;
					translator.Get(L, 2, out _other2);
					bool gen_ret2 = gen_to_be_invoked.Equals(_other2);
					Lua.lua_pushboolean(L, gen_ret2);
					translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector2.Equals!");
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0007DB98 File Offset: 0x0007BD98
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Reflect_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _inDirection;
				translator.Get(L, 1, out _inDirection);
				Vector2 _inNormal;
				translator.Get(L, 2, out _inNormal);
				Vector2 gen_ret = Vector2.Reflect(_inDirection, _inNormal);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F41 RID: 3905 RVA: 0x0007DC18 File Offset: 0x0007BE18
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Perpendicular_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _inDirection;
				translator.Get(L, 1, out _inDirection);
				Vector2 gen_ret = Vector2.Perpendicular(_inDirection);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F42 RID: 3906 RVA: 0x0007DC88 File Offset: 0x0007BE88
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Dot_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector2 _rhs;
				translator.Get(L, 2, out _rhs);
				float gen_ret = Vector2.Dot(_lhs, _rhs);
				Lua.lua_pushnumber(L, (double)gen_ret);
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

		// Token: 0x06000F43 RID: 3907 RVA: 0x0007DD08 File Offset: 0x0007BF08
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Angle_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _from;
				translator.Get(L, 1, out _from);
				Vector2 _to;
				translator.Get(L, 2, out _to);
				float gen_ret = Vector2.Angle(_from, _to);
				Lua.lua_pushnumber(L, (double)gen_ret);
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

		// Token: 0x06000F44 RID: 3908 RVA: 0x0007DD88 File Offset: 0x0007BF88
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SignedAngle_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _from;
				translator.Get(L, 1, out _from);
				Vector2 _to;
				translator.Get(L, 2, out _to);
				float gen_ret = Vector2.SignedAngle(_from, _to);
				Lua.lua_pushnumber(L, (double)gen_ret);
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

		// Token: 0x06000F45 RID: 3909 RVA: 0x0007DE08 File Offset: 0x0007C008
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Distance_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _a;
				translator.Get(L, 1, out _a);
				Vector2 _b;
				translator.Get(L, 2, out _b);
				float gen_ret = Vector2.Distance(_a, _b);
				Lua.lua_pushnumber(L, (double)gen_ret);
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

		// Token: 0x06000F46 RID: 3910 RVA: 0x0007DE88 File Offset: 0x0007C088
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ClampMagnitude_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _vector;
				translator.Get(L, 1, out _vector);
				float _maxLength = (float)Lua.lua_tonumber(L, 2);
				Vector2 gen_ret = Vector2.ClampMagnitude(_vector, _maxLength);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F47 RID: 3911 RVA: 0x0007DF08 File Offset: 0x0007C108
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SqrMagnitude_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _a;
				translator.Get(L, 1, out _a);
				float gen_ret = Vector2.SqrMagnitude(_a);
				Lua.lua_pushnumber(L, (double)gen_ret);
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

		// Token: 0x06000F48 RID: 3912 RVA: 0x0007DF78 File Offset: 0x0007C178
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SqrMagnitude(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				float gen_ret = gen_to_be_invoked.SqrMagnitude();
				Lua.lua_pushnumber(L, (double)gen_ret);
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F49 RID: 3913 RVA: 0x0007DFF4 File Offset: 0x0007C1F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Min_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector2 _rhs;
				translator.Get(L, 2, out _rhs);
				Vector2 gen_ret = Vector2.Min(_lhs, _rhs);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F4A RID: 3914 RVA: 0x0007E074 File Offset: 0x0007C274
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Max_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector2 _rhs;
				translator.Get(L, 2, out _rhs);
				Vector2 gen_ret = Vector2.Max(_lhs, _rhs);
				translator.PushUnityEngineVector2(L, gen_ret);
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

		// Token: 0x06000F4B RID: 3915 RVA: 0x0007E0F4 File Offset: 0x0007C2F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SmoothDamp_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && translator.Assignable<Vector2>(L, 1) && translator.Assignable<Vector2>(L, 2) && translator.Assignable<Vector2>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					Vector2 _current;
					translator.Get(L, 1, out _current);
					Vector2 _target;
					translator.Get(L, 2, out _target);
					Vector2 _currentVelocity;
					translator.Get(L, 3, out _currentVelocity);
					float _smoothTime = (float)Lua.lua_tonumber(L, 4);
					Vector2 gen_ret = Vector2.SmoothDamp(_current, _target, ref _currentVelocity, _smoothTime);
					translator.PushUnityEngineVector2(L, gen_ret);
					translator.PushUnityEngineVector2(L, _currentVelocity);
					translator.UpdateUnityEngineVector2(L, 3, _currentVelocity);
					return 2;
				}
				bool flag2 = gen_param_count == 5 && translator.Assignable<Vector2>(L, 1) && translator.Assignable<Vector2>(L, 2) && translator.Assignable<Vector2>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5);
				if (flag2)
				{
					Vector2 _current2;
					translator.Get(L, 1, out _current2);
					Vector2 _target2;
					translator.Get(L, 2, out _target2);
					Vector2 _currentVelocity2;
					translator.Get(L, 3, out _currentVelocity2);
					float _smoothTime2 = (float)Lua.lua_tonumber(L, 4);
					float _maxSpeed = (float)Lua.lua_tonumber(L, 5);
					Vector2 gen_ret2 = Vector2.SmoothDamp(_current2, _target2, ref _currentVelocity2, _smoothTime2, _maxSpeed);
					translator.PushUnityEngineVector2(L, gen_ret2);
					translator.PushUnityEngineVector2(L, _currentVelocity2);
					translator.UpdateUnityEngineVector2(L, 3, _currentVelocity2);
					return 2;
				}
				bool flag3 = gen_param_count == 6 && translator.Assignable<Vector2>(L, 1) && translator.Assignable<Vector2>(L, 2) && translator.Assignable<Vector2>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 6);
				if (flag3)
				{
					Vector2 _current3;
					translator.Get(L, 1, out _current3);
					Vector2 _target3;
					translator.Get(L, 2, out _target3);
					Vector2 _currentVelocity3;
					translator.Get(L, 3, out _currentVelocity3);
					float _smoothTime3 = (float)Lua.lua_tonumber(L, 4);
					float _maxSpeed2 = (float)Lua.lua_tonumber(L, 5);
					float _deltaTime = (float)Lua.lua_tonumber(L, 6);
					Vector2 gen_ret3 = Vector2.SmoothDamp(_current3, _target3, ref _currentVelocity3, _smoothTime3, _maxSpeed2, _deltaTime);
					translator.PushUnityEngineVector2(L, gen_ret3);
					translator.PushUnityEngineVector2(L, _currentVelocity3);
					translator.UpdateUnityEngineVector2(L, 3, _currentVelocity3);
					return 2;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector2.SmoothDamp!");
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0007E36C File Offset: 0x0007C56C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_normalized(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				translator.PushUnityEngineVector2(L, gen_to_be_invoked.normalized);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0007E3DC File Offset: 0x0007C5DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_magnitude(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.magnitude);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0007E44C File Offset: 0x0007C64C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_sqrMagnitude(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.sqrMagnitude);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0007E4BC File Offset: 0x0007C6BC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_zero(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector2(L, Vector2.zero);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0007E520 File Offset: 0x0007C720
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_one(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector2(L, Vector2.one);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0007E584 File Offset: 0x0007C784
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_up(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector2(L, Vector2.up);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0007E5E8 File Offset: 0x0007C7E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_down(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector2(L, Vector2.down);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0007E64C File Offset: 0x0007C84C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_left(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector2(L, Vector2.left);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0007E6B0 File Offset: 0x0007C8B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_right(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector2(L, Vector2.right);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0007E714 File Offset: 0x0007C914
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_positiveInfinity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector2(L, Vector2.positiveInfinity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0007E778 File Offset: 0x0007C978
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_negativeInfinity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector2(L, Vector2.negativeInfinity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0007E7DC File Offset: 0x0007C9DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_x(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.x);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0007E84C File Offset: 0x0007CA4C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_y(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.y);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0007E8BC File Offset: 0x0007CABC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_x(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.x = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0007E938 File Offset: 0x0007CB38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_y(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector2 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.y = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector2(L, 1, gen_to_be_invoked);
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

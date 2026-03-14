using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B9 RID: 441
	public class UnityEngineQuaternionWrap
	{
		// Token: 0x06000EC9 RID: 3785 RVA: 0x00078380 File Offset: 0x00076580
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Quaternion);
			Utils.BeginObjectRegister(type, L, translator, 2, 8, 6, 5, -1);
			Utils.RegisterFunc(L, -4, "__mul", new lua_CSFunction(UnityEngineQuaternionWrap.__MulMeta));
			Utils.RegisterFunc(L, -4, "__eq", new lua_CSFunction(UnityEngineQuaternionWrap.__EqMeta));
			Utils.RegisterFunc(L, -3, "Set", new lua_CSFunction(UnityEngineQuaternionWrap._m_Set));
			Utils.RegisterFunc(L, -3, "SetLookRotation", new lua_CSFunction(UnityEngineQuaternionWrap._m_SetLookRotation));
			Utils.RegisterFunc(L, -3, "ToAngleAxis", new lua_CSFunction(UnityEngineQuaternionWrap._m_ToAngleAxis));
			Utils.RegisterFunc(L, -3, "SetFromToRotation", new lua_CSFunction(UnityEngineQuaternionWrap._m_SetFromToRotation));
			Utils.RegisterFunc(L, -3, "Normalize", new lua_CSFunction(UnityEngineQuaternionWrap._m_Normalize));
			Utils.RegisterFunc(L, -3, "GetHashCode", new lua_CSFunction(UnityEngineQuaternionWrap._m_GetHashCode));
			Utils.RegisterFunc(L, -3, "Equals", new lua_CSFunction(UnityEngineQuaternionWrap._m_Equals));
			Utils.RegisterFunc(L, -3, "ToString", new lua_CSFunction(UnityEngineQuaternionWrap._m_ToString));
			Utils.RegisterFunc(L, -2, "eulerAngles", new lua_CSFunction(UnityEngineQuaternionWrap._g_get_eulerAngles));
			Utils.RegisterFunc(L, -2, "normalized", new lua_CSFunction(UnityEngineQuaternionWrap._g_get_normalized));
			Utils.RegisterFunc(L, -2, "x", new lua_CSFunction(UnityEngineQuaternionWrap._g_get_x));
			Utils.RegisterFunc(L, -2, "y", new lua_CSFunction(UnityEngineQuaternionWrap._g_get_y));
			Utils.RegisterFunc(L, -2, "z", new lua_CSFunction(UnityEngineQuaternionWrap._g_get_z));
			Utils.RegisterFunc(L, -2, "w", new lua_CSFunction(UnityEngineQuaternionWrap._g_get_w));
			Utils.RegisterFunc(L, -1, "eulerAngles", new lua_CSFunction(UnityEngineQuaternionWrap._s_set_eulerAngles));
			Utils.RegisterFunc(L, -1, "x", new lua_CSFunction(UnityEngineQuaternionWrap._s_set_x));
			Utils.RegisterFunc(L, -1, "y", new lua_CSFunction(UnityEngineQuaternionWrap._s_set_y));
			Utils.RegisterFunc(L, -1, "z", new lua_CSFunction(UnityEngineQuaternionWrap._s_set_z));
			Utils.RegisterFunc(L, -1, "w", new lua_CSFunction(UnityEngineQuaternionWrap._s_set_w));
			Utils.EndObjectRegister(type, L, translator, new lua_CSFunction(UnityEngineQuaternionWrap.__CSIndexer), new lua_CSFunction(UnityEngineQuaternionWrap.__NewIndexer), null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineQuaternionWrap.__CreateInstance), 15, 1, 0);
			Utils.RegisterFunc(L, -4, "FromToRotation", new lua_CSFunction(UnityEngineQuaternionWrap._m_FromToRotation_xlua_st_));
			Utils.RegisterFunc(L, -4, "Inverse", new lua_CSFunction(UnityEngineQuaternionWrap._m_Inverse_xlua_st_));
			Utils.RegisterFunc(L, -4, "Slerp", new lua_CSFunction(UnityEngineQuaternionWrap._m_Slerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "SlerpUnclamped", new lua_CSFunction(UnityEngineQuaternionWrap._m_SlerpUnclamped_xlua_st_));
			Utils.RegisterFunc(L, -4, "Lerp", new lua_CSFunction(UnityEngineQuaternionWrap._m_Lerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "LerpUnclamped", new lua_CSFunction(UnityEngineQuaternionWrap._m_LerpUnclamped_xlua_st_));
			Utils.RegisterFunc(L, -4, "AngleAxis", new lua_CSFunction(UnityEngineQuaternionWrap._m_AngleAxis_xlua_st_));
			Utils.RegisterFunc(L, -4, "LookRotation", new lua_CSFunction(UnityEngineQuaternionWrap._m_LookRotation_xlua_st_));
			Utils.RegisterFunc(L, -4, "Dot", new lua_CSFunction(UnityEngineQuaternionWrap._m_Dot_xlua_st_));
			Utils.RegisterFunc(L, -4, "Angle", new lua_CSFunction(UnityEngineQuaternionWrap._m_Angle_xlua_st_));
			Utils.RegisterFunc(L, -4, "Euler", new lua_CSFunction(UnityEngineQuaternionWrap._m_Euler_xlua_st_));
			Utils.RegisterFunc(L, -4, "RotateTowards", new lua_CSFunction(UnityEngineQuaternionWrap._m_RotateTowards_xlua_st_));
			Utils.RegisterFunc(L, -4, "Normalize", new lua_CSFunction(UnityEngineQuaternionWrap._m_Normalize_xlua_st_));
			Utils.RegisterObject(L, translator, -4, "kEpsilon", 1E-06f);
			Utils.RegisterFunc(L, -2, "identity", new lua_CSFunction(UnityEngineQuaternionWrap._g_get_identity));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0007879C File Offset: 0x0007699C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					float _w = (float)Lua.lua_tonumber(L, 5);
					Quaternion gen_ret = new Quaternion(_x, _y, _z, _w);
					translator.PushUnityEngineQuaternion(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 1;
				if (flag2)
				{
					translator.PushUnityEngineQuaternion(L, default(Quaternion));
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Quaternion constructor!");
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000788A4 File Offset: 0x00076AA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __CSIndexer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Quaternion>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Quaternion gen_to_be_invoked;
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

		// Token: 0x06000ECC RID: 3788 RVA: 0x00078954 File Offset: 0x00076B54
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __NewIndexer(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				bool flag = translator.Assignable<Quaternion>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					Quaternion gen_to_be_invoked;
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

		// Token: 0x06000ECD RID: 3789 RVA: 0x00078A10 File Offset: 0x00076C10
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __MulMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Quaternion>(L, 1) && translator.Assignable<Quaternion>(L, 2);
				if (flag)
				{
					Quaternion leftside;
					translator.Get(L, 1, out leftside);
					Quaternion rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineQuaternion(L, leftside * rightside);
					return 1;
				}
				bool flag2 = translator.Assignable<Quaternion>(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Quaternion leftside2;
					translator.Get(L, 1, out leftside2);
					Vector3 rightside2;
					translator.Get(L, 2, out rightside2);
					translator.PushUnityEngineVector3(L, leftside2 * rightside2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Quaternion!");
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00078B00 File Offset: 0x00076D00
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __EqMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Quaternion>(L, 1) && translator.Assignable<Quaternion>(L, 2);
				if (flag)
				{
					Quaternion leftside;
					translator.Get(L, 1, out leftside);
					Quaternion rightside;
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
			return Lua.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Quaternion!");
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00078BA8 File Offset: 0x00076DA8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FromToRotation_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _fromDirection;
				translator.Get(L, 1, out _fromDirection);
				Vector3 _toDirection;
				translator.Get(L, 2, out _toDirection);
				Quaternion gen_ret = Quaternion.FromToRotation(_fromDirection, _toDirection);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00078C28 File Offset: 0x00076E28
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Inverse_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _rotation;
				translator.Get(L, 1, out _rotation);
				Quaternion gen_ret = Quaternion.Inverse(_rotation);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00078C98 File Offset: 0x00076E98
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Slerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _a;
				translator.Get(L, 1, out _a);
				Quaternion _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Quaternion gen_ret = Quaternion.Slerp(_a, _b, _t);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00078D24 File Offset: 0x00076F24
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SlerpUnclamped_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _a;
				translator.Get(L, 1, out _a);
				Quaternion _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Quaternion gen_ret = Quaternion.SlerpUnclamped(_a, _b, _t);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00078DB0 File Offset: 0x00076FB0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Lerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _a;
				translator.Get(L, 1, out _a);
				Quaternion _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Quaternion gen_ret = Quaternion.Lerp(_a, _b, _t);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00078E3C File Offset: 0x0007703C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LerpUnclamped_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _a;
				translator.Get(L, 1, out _a);
				Quaternion _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Quaternion gen_ret = Quaternion.LerpUnclamped(_a, _b, _t);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00078EC8 File Offset: 0x000770C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AngleAxis_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				float _angle = (float)Lua.lua_tonumber(L, 1);
				Vector3 _axis;
				translator.Get(L, 2, out _axis);
				Quaternion gen_ret = Quaternion.AngleAxis(_angle, _axis);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00078F48 File Offset: 0x00077148
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LookRotation_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<Vector3>(L, 1);
				if (flag)
				{
					Vector3 _forward;
					translator.Get(L, 1, out _forward);
					Quaternion gen_ret = Quaternion.LookRotation(_forward);
					translator.PushUnityEngineQuaternion(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _forward2;
					translator.Get(L, 1, out _forward2);
					Vector3 _upwards;
					translator.Get(L, 2, out _upwards);
					Quaternion gen_ret2 = Quaternion.LookRotation(_forward2, _upwards);
					translator.PushUnityEngineQuaternion(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.LookRotation!");
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0007903C File Offset: 0x0007723C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Set(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				float _newX = (float)Lua.lua_tonumber(L, 2);
				float _newY = (float)Lua.lua_tonumber(L, 3);
				float _newZ = (float)Lua.lua_tonumber(L, 4);
				float _newW = (float)Lua.lua_tonumber(L, 5);
				gen_to_be_invoked.Set(_newX, _newY, _newZ, _newW);
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000790E0 File Offset: 0x000772E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Dot_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _a;
				translator.Get(L, 1, out _a);
				Quaternion _b;
				translator.Get(L, 2, out _b);
				float gen_ret = Quaternion.Dot(_a, _b);
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

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00079160 File Offset: 0x00077360
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetLookRotation(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag)
				{
					Vector3 _view;
					translator.Get(L, 2, out _view);
					gen_to_be_invoked.SetLookRotation(_view);
					translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Vector3>(L, 3);
				if (flag2)
				{
					Vector3 _view2;
					translator.Get(L, 2, out _view2);
					Vector3 _up;
					translator.Get(L, 3, out _up);
					gen_to_be_invoked.SetLookRotation(_view2, _up);
					translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.SetLookRotation!");
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00079264 File Offset: 0x00077464
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Angle_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _a;
				translator.Get(L, 1, out _a);
				Quaternion _b;
				translator.Get(L, 2, out _b);
				float gen_ret = Quaternion.Angle(_a, _b);
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

		// Token: 0x06000EDB RID: 3803 RVA: 0x000792E4 File Offset: 0x000774E4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Euler_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 1);
					float _y = (float)Lua.lua_tonumber(L, 2);
					float _z = (float)Lua.lua_tonumber(L, 3);
					Quaternion gen_ret = Quaternion.Euler(_x, _y, _z);
					translator.PushUnityEngineQuaternion(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 1 && translator.Assignable<Vector3>(L, 1);
				if (flag2)
				{
					Vector3 _euler;
					translator.Get(L, 1, out _euler);
					Quaternion gen_ret2 = Quaternion.Euler(_euler);
					translator.PushUnityEngineQuaternion(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.Euler!");
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x000793EC File Offset: 0x000775EC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToAngleAxis(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				float _angle;
				Vector3 _axis;
				gen_to_be_invoked.ToAngleAxis(out _angle, out _axis);
				Lua.lua_pushnumber(L, (double)_angle);
				translator.PushUnityEngineVector3(L, _axis);
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000EDD RID: 3805 RVA: 0x00079478 File Offset: 0x00077678
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetFromToRotation(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Vector3 _fromDirection;
				translator.Get(L, 2, out _fromDirection);
				Vector3 _toDirection;
				translator.Get(L, 3, out _toDirection);
				gen_to_be_invoked.SetFromToRotation(_fromDirection, _toDirection);
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000EDE RID: 3806 RVA: 0x00079508 File Offset: 0x00077708
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RotateTowards_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _from;
				translator.Get(L, 1, out _from);
				Quaternion _to;
				translator.Get(L, 2, out _to);
				float _maxDegreesDelta = (float)Lua.lua_tonumber(L, 3);
				Quaternion gen_ret = Quaternion.RotateTowards(_from, _to, _maxDegreesDelta);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000EDF RID: 3807 RVA: 0x00079594 File Offset: 0x00077794
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Normalize_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion _q;
				translator.Get(L, 1, out _q);
				Quaternion gen_ret = Quaternion.Normalize(_q);
				translator.PushUnityEngineQuaternion(L, gen_ret);
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

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00079604 File Offset: 0x00077804
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Normalize(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.Normalize();
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00079674 File Offset: 0x00077874
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetHashCode(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_ret = gen_to_be_invoked.GetHashCode();
				Lua.xlua_pushinteger(L, gen_ret);
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000796F4 File Offset: 0x000778F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Equals(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<object>(L, 2);
				if (flag)
				{
					object _other = translator.GetObject(L, 2, typeof(object));
					bool gen_ret = gen_to_be_invoked.Equals(_other);
					Lua.lua_pushboolean(L, gen_ret);
					translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Quaternion>(L, 2);
				if (flag2)
				{
					Quaternion _other2;
					translator.Get(L, 2, out _other2);
					bool gen_ret2 = gen_to_be_invoked.Equals(_other2);
					Lua.lua_pushboolean(L, gen_ret2);
					translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.Equals!");
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00079800 File Offset: 0x00077A00
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToString(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					string gen_ret = gen_to_be_invoked.ToString();
					Lua.lua_pushstring(L, gen_ret);
					translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _format = Lua.lua_tostring(L, 2);
					string gen_ret2 = gen_to_be_invoked.ToString(_format);
					Lua.lua_pushstring(L, gen_ret2);
					translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<IFormatProvider>(L, 3);
				if (flag3)
				{
					string _format2 = Lua.lua_tostring(L, 2);
					IFormatProvider _formatProvider = (IFormatProvider)translator.GetObject(L, 3, typeof(IFormatProvider));
					string gen_ret3 = gen_to_be_invoked.ToString(_format2, _formatProvider);
					Lua.lua_pushstring(L, gen_ret3);
					translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.ToString!");
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00079978 File Offset: 0x00077B78
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_identity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineQuaternion(L, Quaternion.identity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000799DC File Offset: 0x00077BDC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_eulerAngles(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.eulerAngles);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00079A4C File Offset: 0x00077C4C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_normalized(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.normalized);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00079ABC File Offset: 0x00077CBC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_x(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
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

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00079B2C File Offset: 0x00077D2C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_y(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
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

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00079B9C File Offset: 0x00077D9C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_z(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.z);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00079C0C File Offset: 0x00077E0C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_w(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Lua.lua_pushnumber(L, (double)gen_to_be_invoked.w);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00079C7C File Offset: 0x00077E7C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_eulerAngles(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.eulerAngles = gen_value;
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00079D00 File Offset: 0x00077F00
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_x(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.x = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00079D7C File Offset: 0x00077F7C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_y(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.y = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00079DF8 File Offset: 0x00077FF8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_z(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.z = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00079E74 File Offset: 0x00078074
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_w(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Quaternion gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.w = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineQuaternion(L, 1, gen_to_be_invoked);
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

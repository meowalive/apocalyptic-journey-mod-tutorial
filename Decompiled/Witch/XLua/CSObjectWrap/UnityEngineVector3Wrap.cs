using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001BC RID: 444
	public class UnityEngineVector3Wrap
	{
		// Token: 0x06000F5C RID: 3932 RVA: 0x0007E9B4 File Offset: 0x0007CBB4
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Vector3);
			Utils.BeginObjectRegister(type, L, translator, 6, 6, 6, 3, -1);
			Utils.RegisterFunc(L, -4, "__add", new lua_CSFunction(UnityEngineVector3Wrap.__AddMeta));
			Utils.RegisterFunc(L, -4, "__sub", new lua_CSFunction(UnityEngineVector3Wrap.__SubMeta));
			Utils.RegisterFunc(L, -4, "__unm", new lua_CSFunction(UnityEngineVector3Wrap.__UnmMeta));
			Utils.RegisterFunc(L, -4, "__mul", new lua_CSFunction(UnityEngineVector3Wrap.__MulMeta));
			Utils.RegisterFunc(L, -4, "__div", new lua_CSFunction(UnityEngineVector3Wrap.__DivMeta));
			Utils.RegisterFunc(L, -4, "__eq", new lua_CSFunction(UnityEngineVector3Wrap.__EqMeta));
			Utils.RegisterFunc(L, -3, "Set", new lua_CSFunction(UnityEngineVector3Wrap._m_Set));
			Utils.RegisterFunc(L, -3, "Scale", new lua_CSFunction(UnityEngineVector3Wrap._m_Scale));
			Utils.RegisterFunc(L, -3, "GetHashCode", new lua_CSFunction(UnityEngineVector3Wrap._m_GetHashCode));
			Utils.RegisterFunc(L, -3, "Equals", new lua_CSFunction(UnityEngineVector3Wrap._m_Equals));
			Utils.RegisterFunc(L, -3, "Normalize", new lua_CSFunction(UnityEngineVector3Wrap._m_Normalize));
			Utils.RegisterFunc(L, -3, "ToString", new lua_CSFunction(UnityEngineVector3Wrap._m_ToString));
			Utils.RegisterFunc(L, -2, "normalized", new lua_CSFunction(UnityEngineVector3Wrap._g_get_normalized));
			Utils.RegisterFunc(L, -2, "magnitude", new lua_CSFunction(UnityEngineVector3Wrap._g_get_magnitude));
			Utils.RegisterFunc(L, -2, "sqrMagnitude", new lua_CSFunction(UnityEngineVector3Wrap._g_get_sqrMagnitude));
			Utils.RegisterFunc(L, -2, "x", new lua_CSFunction(UnityEngineVector3Wrap._g_get_x));
			Utils.RegisterFunc(L, -2, "y", new lua_CSFunction(UnityEngineVector3Wrap._g_get_y));
			Utils.RegisterFunc(L, -2, "z", new lua_CSFunction(UnityEngineVector3Wrap._g_get_z));
			Utils.RegisterFunc(L, -1, "x", new lua_CSFunction(UnityEngineVector3Wrap._s_set_x));
			Utils.RegisterFunc(L, -1, "y", new lua_CSFunction(UnityEngineVector3Wrap._s_set_y));
			Utils.RegisterFunc(L, -1, "z", new lua_CSFunction(UnityEngineVector3Wrap._s_set_z));
			Utils.EndObjectRegister(type, L, translator, new lua_CSFunction(UnityEngineVector3Wrap.__CSIndexer), new lua_CSFunction(UnityEngineVector3Wrap.__NewIndexer), null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineVector3Wrap.__CreateInstance), 26, 10, 0);
			Utils.RegisterFunc(L, -4, "Slerp", new lua_CSFunction(UnityEngineVector3Wrap._m_Slerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "SlerpUnclamped", new lua_CSFunction(UnityEngineVector3Wrap._m_SlerpUnclamped_xlua_st_));
			Utils.RegisterFunc(L, -4, "OrthoNormalize", new lua_CSFunction(UnityEngineVector3Wrap._m_OrthoNormalize_xlua_st_));
			Utils.RegisterFunc(L, -4, "RotateTowards", new lua_CSFunction(UnityEngineVector3Wrap._m_RotateTowards_xlua_st_));
			Utils.RegisterFunc(L, -4, "Lerp", new lua_CSFunction(UnityEngineVector3Wrap._m_Lerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "LerpUnclamped", new lua_CSFunction(UnityEngineVector3Wrap._m_LerpUnclamped_xlua_st_));
			Utils.RegisterFunc(L, -4, "MoveTowards", new lua_CSFunction(UnityEngineVector3Wrap._m_MoveTowards_xlua_st_));
			Utils.RegisterFunc(L, -4, "SmoothDamp", new lua_CSFunction(UnityEngineVector3Wrap._m_SmoothDamp_xlua_st_));
			Utils.RegisterFunc(L, -4, "Scale", new lua_CSFunction(UnityEngineVector3Wrap._m_Scale_xlua_st_));
			Utils.RegisterFunc(L, -4, "Cross", new lua_CSFunction(UnityEngineVector3Wrap._m_Cross_xlua_st_));
			Utils.RegisterFunc(L, -4, "Reflect", new lua_CSFunction(UnityEngineVector3Wrap._m_Reflect_xlua_st_));
			Utils.RegisterFunc(L, -4, "Normalize", new lua_CSFunction(UnityEngineVector3Wrap._m_Normalize_xlua_st_));
			Utils.RegisterFunc(L, -4, "Dot", new lua_CSFunction(UnityEngineVector3Wrap._m_Dot_xlua_st_));
			Utils.RegisterFunc(L, -4, "Project", new lua_CSFunction(UnityEngineVector3Wrap._m_Project_xlua_st_));
			Utils.RegisterFunc(L, -4, "ProjectOnPlane", new lua_CSFunction(UnityEngineVector3Wrap._m_ProjectOnPlane_xlua_st_));
			Utils.RegisterFunc(L, -4, "Angle", new lua_CSFunction(UnityEngineVector3Wrap._m_Angle_xlua_st_));
			Utils.RegisterFunc(L, -4, "SignedAngle", new lua_CSFunction(UnityEngineVector3Wrap._m_SignedAngle_xlua_st_));
			Utils.RegisterFunc(L, -4, "Distance", new lua_CSFunction(UnityEngineVector3Wrap._m_Distance_xlua_st_));
			Utils.RegisterFunc(L, -4, "ClampMagnitude", new lua_CSFunction(UnityEngineVector3Wrap._m_ClampMagnitude_xlua_st_));
			Utils.RegisterFunc(L, -4, "Magnitude", new lua_CSFunction(UnityEngineVector3Wrap._m_Magnitude_xlua_st_));
			Utils.RegisterFunc(L, -4, "SqrMagnitude", new lua_CSFunction(UnityEngineVector3Wrap._m_SqrMagnitude_xlua_st_));
			Utils.RegisterFunc(L, -4, "Min", new lua_CSFunction(UnityEngineVector3Wrap._m_Min_xlua_st_));
			Utils.RegisterFunc(L, -4, "Max", new lua_CSFunction(UnityEngineVector3Wrap._m_Max_xlua_st_));
			Utils.RegisterObject(L, translator, -4, "kEpsilon", 1E-05f);
			Utils.RegisterObject(L, translator, -4, "kEpsilonNormalSqrt", 1E-15f);
			Utils.RegisterFunc(L, -2, "zero", new lua_CSFunction(UnityEngineVector3Wrap._g_get_zero));
			Utils.RegisterFunc(L, -2, "one", new lua_CSFunction(UnityEngineVector3Wrap._g_get_one));
			Utils.RegisterFunc(L, -2, "forward", new lua_CSFunction(UnityEngineVector3Wrap._g_get_forward));
			Utils.RegisterFunc(L, -2, "back", new lua_CSFunction(UnityEngineVector3Wrap._g_get_back));
			Utils.RegisterFunc(L, -2, "up", new lua_CSFunction(UnityEngineVector3Wrap._g_get_up));
			Utils.RegisterFunc(L, -2, "down", new lua_CSFunction(UnityEngineVector3Wrap._g_get_down));
			Utils.RegisterFunc(L, -2, "left", new lua_CSFunction(UnityEngineVector3Wrap._g_get_left));
			Utils.RegisterFunc(L, -2, "right", new lua_CSFunction(UnityEngineVector3Wrap._g_get_right));
			Utils.RegisterFunc(L, -2, "positiveInfinity", new lua_CSFunction(UnityEngineVector3Wrap._g_get_positiveInfinity));
			Utils.RegisterFunc(L, -2, "negativeInfinity", new lua_CSFunction(UnityEngineVector3Wrap._g_get_negativeInfinity));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0007EFD8 File Offset: 0x0007D1D8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					Vector3 gen_ret = new Vector3(_x, _y, _z);
					translator.PushUnityEngineVector3(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag2)
				{
					float _x2 = (float)Lua.lua_tonumber(L, 2);
					float _y2 = (float)Lua.lua_tonumber(L, 3);
					Vector3 gen_ret2 = new Vector3(_x2, _y2);
					translator.PushUnityEngineVector3(L, gen_ret2);
					return 1;
				}
				bool flag3 = Lua.lua_gettop(L) == 1;
				if (flag3)
				{
					translator.PushUnityEngineVector3(L, default(Vector3));
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector3 constructor!");
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0007F120 File Offset: 0x0007D320
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __CSIndexer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector3>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Vector3 gen_to_be_invoked;
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

		// Token: 0x06000F5F RID: 3935 RVA: 0x0007F1D0 File Offset: 0x0007D3D0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __NewIndexer(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				bool flag = translator.Assignable<Vector3>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					Vector3 gen_to_be_invoked;
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

		// Token: 0x06000F60 RID: 3936 RVA: 0x0007F28C File Offset: 0x0007D48C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __AddMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag)
				{
					Vector3 leftside;
					translator.Get(L, 1, out leftside);
					Vector3 rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineVector3(L, leftside + rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Vector3!");
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0007F334 File Offset: 0x0007D534
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __SubMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag)
				{
					Vector3 leftside;
					translator.Get(L, 1, out leftside);
					Vector3 rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineVector3(L, leftside - rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Vector3!");
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0007F3DC File Offset: 0x0007D5DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __UnmMeta(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				Vector3 rightside;
				translator.Get(L, 1, out rightside);
				translator.PushUnityEngineVector3(L, -rightside);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0007F44C File Offset: 0x0007D64C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __MulMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector3>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Vector3 leftside;
					translator.Get(L, 1, out leftside);
					float rightside = (float)Lua.lua_tonumber(L, 2);
					translator.PushUnityEngineVector3(L, leftside * rightside);
					return 1;
				}
				bool flag2 = LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					float leftside2 = (float)Lua.lua_tonumber(L, 1);
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
			return Lua.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Vector3!");
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0007F53C File Offset: 0x0007D73C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __DivMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector3>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Vector3 leftside;
					translator.Get(L, 1, out leftside);
					float rightside = (float)Lua.lua_tonumber(L, 2);
					translator.PushUnityEngineVector3(L, leftside / rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Vector3!");
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0007F5E4 File Offset: 0x0007D7E4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __EqMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag)
				{
					Vector3 leftside;
					translator.Get(L, 1, out leftside);
					Vector3 rightside;
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
			return Lua.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Vector3!");
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0007F68C File Offset: 0x0007D88C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Slerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _a;
				translator.Get(L, 1, out _a);
				Vector3 _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Vector3 gen_ret = Vector3.Slerp(_a, _b, _t);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F67 RID: 3943 RVA: 0x0007F718 File Offset: 0x0007D918
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SlerpUnclamped_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _a;
				translator.Get(L, 1, out _a);
				Vector3 _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Vector3 gen_ret = Vector3.SlerpUnclamped(_a, _b, _t);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F68 RID: 3944 RVA: 0x0007F7A4 File Offset: 0x0007D9A4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OrthoNormalize_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag)
				{
					Vector3 _normal;
					translator.Get(L, 1, out _normal);
					Vector3 _tangent;
					translator.Get(L, 2, out _tangent);
					Vector3.OrthoNormalize(ref _normal, ref _tangent);
					translator.PushUnityEngineVector3(L, _normal);
					translator.UpdateUnityEngineVector3(L, 1, _normal);
					translator.PushUnityEngineVector3(L, _tangent);
					translator.UpdateUnityEngineVector3(L, 2, _tangent);
					return 2;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Vector3>(L, 3);
				if (flag2)
				{
					Vector3 _normal2;
					translator.Get(L, 1, out _normal2);
					Vector3 _tangent2;
					translator.Get(L, 2, out _tangent2);
					Vector3 _binormal;
					translator.Get(L, 3, out _binormal);
					Vector3.OrthoNormalize(ref _normal2, ref _tangent2, ref _binormal);
					translator.PushUnityEngineVector3(L, _normal2);
					translator.UpdateUnityEngineVector3(L, 1, _normal2);
					translator.PushUnityEngineVector3(L, _tangent2);
					translator.UpdateUnityEngineVector3(L, 2, _tangent2);
					translator.PushUnityEngineVector3(L, _binormal);
					translator.UpdateUnityEngineVector3(L, 3, _binormal);
					return 3;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector3.OrthoNormalize!");
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0007F924 File Offset: 0x0007DB24
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RotateTowards_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _current;
				translator.Get(L, 1, out _current);
				Vector3 _target;
				translator.Get(L, 2, out _target);
				float _maxRadiansDelta = (float)Lua.lua_tonumber(L, 3);
				float _maxMagnitudeDelta = (float)Lua.lua_tonumber(L, 4);
				Vector3 gen_ret = Vector3.RotateTowards(_current, _target, _maxRadiansDelta, _maxMagnitudeDelta);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F6A RID: 3946 RVA: 0x0007F9BC File Offset: 0x0007DBBC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Lerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _a;
				translator.Get(L, 1, out _a);
				Vector3 _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Vector3 gen_ret = Vector3.Lerp(_a, _b, _t);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F6B RID: 3947 RVA: 0x0007FA48 File Offset: 0x0007DC48
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LerpUnclamped_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _a;
				translator.Get(L, 1, out _a);
				Vector3 _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Vector3 gen_ret = Vector3.LerpUnclamped(_a, _b, _t);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F6C RID: 3948 RVA: 0x0007FAD4 File Offset: 0x0007DCD4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_MoveTowards_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _current;
				translator.Get(L, 1, out _current);
				Vector3 _target;
				translator.Get(L, 2, out _target);
				float _maxDistanceDelta = (float)Lua.lua_tonumber(L, 3);
				Vector3 gen_ret = Vector3.MoveTowards(_current, _target, _maxDistanceDelta);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F6D RID: 3949 RVA: 0x0007FB60 File Offset: 0x0007DD60
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SmoothDamp_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Vector3>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					Vector3 _current;
					translator.Get(L, 1, out _current);
					Vector3 _target;
					translator.Get(L, 2, out _target);
					Vector3 _currentVelocity;
					translator.Get(L, 3, out _currentVelocity);
					float _smoothTime = (float)Lua.lua_tonumber(L, 4);
					Vector3 gen_ret = Vector3.SmoothDamp(_current, _target, ref _currentVelocity, _smoothTime);
					translator.PushUnityEngineVector3(L, gen_ret);
					translator.PushUnityEngineVector3(L, _currentVelocity);
					translator.UpdateUnityEngineVector3(L, 3, _currentVelocity);
					return 2;
				}
				bool flag2 = gen_param_count == 5 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Vector3>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5);
				if (flag2)
				{
					Vector3 _current2;
					translator.Get(L, 1, out _current2);
					Vector3 _target2;
					translator.Get(L, 2, out _target2);
					Vector3 _currentVelocity2;
					translator.Get(L, 3, out _currentVelocity2);
					float _smoothTime2 = (float)Lua.lua_tonumber(L, 4);
					float _maxSpeed = (float)Lua.lua_tonumber(L, 5);
					Vector3 gen_ret2 = Vector3.SmoothDamp(_current2, _target2, ref _currentVelocity2, _smoothTime2, _maxSpeed);
					translator.PushUnityEngineVector3(L, gen_ret2);
					translator.PushUnityEngineVector3(L, _currentVelocity2);
					translator.UpdateUnityEngineVector3(L, 3, _currentVelocity2);
					return 2;
				}
				bool flag3 = gen_param_count == 6 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Vector3>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 6);
				if (flag3)
				{
					Vector3 _current3;
					translator.Get(L, 1, out _current3);
					Vector3 _target3;
					translator.Get(L, 2, out _target3);
					Vector3 _currentVelocity3;
					translator.Get(L, 3, out _currentVelocity3);
					float _smoothTime3 = (float)Lua.lua_tonumber(L, 4);
					float _maxSpeed2 = (float)Lua.lua_tonumber(L, 5);
					float _deltaTime = (float)Lua.lua_tonumber(L, 6);
					Vector3 gen_ret3 = Vector3.SmoothDamp(_current3, _target3, ref _currentVelocity3, _smoothTime3, _maxSpeed2, _deltaTime);
					translator.PushUnityEngineVector3(L, gen_ret3);
					translator.PushUnityEngineVector3(L, _currentVelocity3);
					translator.UpdateUnityEngineVector3(L, 3, _currentVelocity3);
					return 2;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector3.SmoothDamp!");
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0007FDD8 File Offset: 0x0007DFD8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Set(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				float _newX = (float)Lua.lua_tonumber(L, 2);
				float _newY = (float)Lua.lua_tonumber(L, 3);
				float _newZ = (float)Lua.lua_tonumber(L, 4);
				gen_to_be_invoked.Set(_newX, _newY, _newZ);
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F6F RID: 3951 RVA: 0x0007FE70 File Offset: 0x0007E070
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Scale_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _a;
				translator.Get(L, 1, out _a);
				Vector3 _b;
				translator.Get(L, 2, out _b);
				Vector3 gen_ret = Vector3.Scale(_a, _b);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F70 RID: 3952 RVA: 0x0007FEF0 File Offset: 0x0007E0F0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Scale(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Vector3 _scale;
				translator.Get(L, 2, out _scale);
				gen_to_be_invoked.Scale(_scale);
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F71 RID: 3953 RVA: 0x0007FF70 File Offset: 0x0007E170
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Cross_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector3 _rhs;
				translator.Get(L, 2, out _rhs);
				Vector3 gen_ret = Vector3.Cross(_lhs, _rhs);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F72 RID: 3954 RVA: 0x0007FFF0 File Offset: 0x0007E1F0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetHashCode(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_ret = gen_to_be_invoked.GetHashCode();
				Lua.xlua_pushinteger(L, gen_ret);
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F73 RID: 3955 RVA: 0x00080070 File Offset: 0x0007E270
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Equals(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<object>(L, 2);
				if (flag)
				{
					object _other = translator.GetObject(L, 2, typeof(object));
					bool gen_ret = gen_to_be_invoked.Equals(_other);
					Lua.lua_pushboolean(L, gen_ret);
					translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _other2;
					translator.Get(L, 2, out _other2);
					bool gen_ret2 = gen_to_be_invoked.Equals(_other2);
					Lua.lua_pushboolean(L, gen_ret2);
					translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector3.Equals!");
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0008017C File Offset: 0x0007E37C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Reflect_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _inDirection;
				translator.Get(L, 1, out _inDirection);
				Vector3 _inNormal;
				translator.Get(L, 2, out _inNormal);
				Vector3 gen_ret = Vector3.Reflect(_inDirection, _inNormal);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F75 RID: 3957 RVA: 0x000801FC File Offset: 0x0007E3FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Normalize_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _value;
				translator.Get(L, 1, out _value);
				Vector3 gen_ret = Vector3.Normalize(_value);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F76 RID: 3958 RVA: 0x0008026C File Offset: 0x0007E46C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Normalize(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.Normalize();
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000F77 RID: 3959 RVA: 0x000802DC File Offset: 0x0007E4DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Dot_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector3 _rhs;
				translator.Get(L, 2, out _rhs);
				float gen_ret = Vector3.Dot(_lhs, _rhs);
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

		// Token: 0x06000F78 RID: 3960 RVA: 0x0008035C File Offset: 0x0007E55C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Project_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _vector;
				translator.Get(L, 1, out _vector);
				Vector3 _onNormal;
				translator.Get(L, 2, out _onNormal);
				Vector3 gen_ret = Vector3.Project(_vector, _onNormal);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F79 RID: 3961 RVA: 0x000803DC File Offset: 0x0007E5DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ProjectOnPlane_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _vector;
				translator.Get(L, 1, out _vector);
				Vector3 _planeNormal;
				translator.Get(L, 2, out _planeNormal);
				Vector3 gen_ret = Vector3.ProjectOnPlane(_vector, _planeNormal);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F7A RID: 3962 RVA: 0x0008045C File Offset: 0x0007E65C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Angle_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _from;
				translator.Get(L, 1, out _from);
				Vector3 _to;
				translator.Get(L, 2, out _to);
				float gen_ret = Vector3.Angle(_from, _to);
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

		// Token: 0x06000F7B RID: 3963 RVA: 0x000804DC File Offset: 0x0007E6DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SignedAngle_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _from;
				translator.Get(L, 1, out _from);
				Vector3 _to;
				translator.Get(L, 2, out _to);
				Vector3 _axis;
				translator.Get(L, 3, out _axis);
				float gen_ret = Vector3.SignedAngle(_from, _to, _axis);
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

		// Token: 0x06000F7C RID: 3964 RVA: 0x0008056C File Offset: 0x0007E76C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Distance_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _a;
				translator.Get(L, 1, out _a);
				Vector3 _b;
				translator.Get(L, 2, out _b);
				float gen_ret = Vector3.Distance(_a, _b);
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

		// Token: 0x06000F7D RID: 3965 RVA: 0x000805EC File Offset: 0x0007E7EC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ClampMagnitude_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _vector;
				translator.Get(L, 1, out _vector);
				float _maxLength = (float)Lua.lua_tonumber(L, 2);
				Vector3 gen_ret = Vector3.ClampMagnitude(_vector, _maxLength);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F7E RID: 3966 RVA: 0x0008066C File Offset: 0x0007E86C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Magnitude_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _vector;
				translator.Get(L, 1, out _vector);
				float gen_ret = Vector3.Magnitude(_vector);
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

		// Token: 0x06000F7F RID: 3967 RVA: 0x000806DC File Offset: 0x0007E8DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SqrMagnitude_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _vector;
				translator.Get(L, 1, out _vector);
				float gen_ret = Vector3.SqrMagnitude(_vector);
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

		// Token: 0x06000F80 RID: 3968 RVA: 0x0008074C File Offset: 0x0007E94C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Min_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector3 _rhs;
				translator.Get(L, 2, out _rhs);
				Vector3 gen_ret = Vector3.Min(_lhs, _rhs);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F81 RID: 3969 RVA: 0x000807CC File Offset: 0x0007E9CC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Max_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector3 _rhs;
				translator.Get(L, 2, out _rhs);
				Vector3 gen_ret = Vector3.Max(_lhs, _rhs);
				translator.PushUnityEngineVector3(L, gen_ret);
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

		// Token: 0x06000F82 RID: 3970 RVA: 0x0008084C File Offset: 0x0007EA4C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToString(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					string gen_ret = gen_to_be_invoked.ToString();
					Lua.lua_pushstring(L, gen_ret);
					translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _format = Lua.lua_tostring(L, 2);
					string gen_ret2 = gen_to_be_invoked.ToString(_format);
					Lua.lua_pushstring(L, gen_ret2);
					translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<IFormatProvider>(L, 3);
				if (flag3)
				{
					string _format2 = Lua.lua_tostring(L, 2);
					IFormatProvider _formatProvider = (IFormatProvider)translator.GetObject(L, 3, typeof(IFormatProvider));
					string gen_ret3 = gen_to_be_invoked.ToString(_format2, _formatProvider);
					Lua.lua_pushstring(L, gen_ret3);
					translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector3.ToString!");
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000809C4 File Offset: 0x0007EBC4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_normalized(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.normalized);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00080A34 File Offset: 0x0007EC34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_magnitude(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
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

		// Token: 0x06000F85 RID: 3973 RVA: 0x00080AA4 File Offset: 0x0007ECA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_sqrMagnitude(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
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

		// Token: 0x06000F86 RID: 3974 RVA: 0x00080B14 File Offset: 0x0007ED14
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_zero(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.zero);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00080B78 File Offset: 0x0007ED78
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_one(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.one);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00080BDC File Offset: 0x0007EDDC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_forward(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.forward);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00080C40 File Offset: 0x0007EE40
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_back(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.back);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00080CA4 File Offset: 0x0007EEA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_up(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.up);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00080D08 File Offset: 0x0007EF08
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_down(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.down);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00080D6C File Offset: 0x0007EF6C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_left(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.left);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00080DD0 File Offset: 0x0007EFD0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_right(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.right);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00080E34 File Offset: 0x0007F034
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_positiveInfinity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.positiveInfinity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00080E98 File Offset: 0x0007F098
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_negativeInfinity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector3(L, Vector3.negativeInfinity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00080EFC File Offset: 0x0007F0FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_x(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
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

		// Token: 0x06000F91 RID: 3985 RVA: 0x00080F6C File Offset: 0x0007F16C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_y(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
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

		// Token: 0x06000F92 RID: 3986 RVA: 0x00080FDC File Offset: 0x0007F1DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_z(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
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

		// Token: 0x06000F93 RID: 3987 RVA: 0x0008104C File Offset: 0x0007F24C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_x(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.x = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000810C8 File Offset: 0x0007F2C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_y(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.y = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00081144 File Offset: 0x0007F344
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_z(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector3 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.z = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector3(L, 1, gen_to_be_invoked);
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

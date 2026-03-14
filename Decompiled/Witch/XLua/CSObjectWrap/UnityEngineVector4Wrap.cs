using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001BD RID: 445
	public class UnityEngineVector4Wrap
	{
		// Token: 0x06000F97 RID: 3991 RVA: 0x000811C0 File Offset: 0x0007F3C0
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Vector4);
			Utils.BeginObjectRegister(type, L, translator, 6, 7, 7, 4, -1);
			Utils.RegisterFunc(L, -4, "__add", new lua_CSFunction(UnityEngineVector4Wrap.__AddMeta));
			Utils.RegisterFunc(L, -4, "__sub", new lua_CSFunction(UnityEngineVector4Wrap.__SubMeta));
			Utils.RegisterFunc(L, -4, "__unm", new lua_CSFunction(UnityEngineVector4Wrap.__UnmMeta));
			Utils.RegisterFunc(L, -4, "__mul", new lua_CSFunction(UnityEngineVector4Wrap.__MulMeta));
			Utils.RegisterFunc(L, -4, "__div", new lua_CSFunction(UnityEngineVector4Wrap.__DivMeta));
			Utils.RegisterFunc(L, -4, "__eq", new lua_CSFunction(UnityEngineVector4Wrap.__EqMeta));
			Utils.RegisterFunc(L, -3, "Set", new lua_CSFunction(UnityEngineVector4Wrap._m_Set));
			Utils.RegisterFunc(L, -3, "Scale", new lua_CSFunction(UnityEngineVector4Wrap._m_Scale));
			Utils.RegisterFunc(L, -3, "GetHashCode", new lua_CSFunction(UnityEngineVector4Wrap._m_GetHashCode));
			Utils.RegisterFunc(L, -3, "Equals", new lua_CSFunction(UnityEngineVector4Wrap._m_Equals));
			Utils.RegisterFunc(L, -3, "Normalize", new lua_CSFunction(UnityEngineVector4Wrap._m_Normalize));
			Utils.RegisterFunc(L, -3, "ToString", new lua_CSFunction(UnityEngineVector4Wrap._m_ToString));
			Utils.RegisterFunc(L, -3, "SqrMagnitude", new lua_CSFunction(UnityEngineVector4Wrap._m_SqrMagnitude));
			Utils.RegisterFunc(L, -2, "normalized", new lua_CSFunction(UnityEngineVector4Wrap._g_get_normalized));
			Utils.RegisterFunc(L, -2, "magnitude", new lua_CSFunction(UnityEngineVector4Wrap._g_get_magnitude));
			Utils.RegisterFunc(L, -2, "sqrMagnitude", new lua_CSFunction(UnityEngineVector4Wrap._g_get_sqrMagnitude));
			Utils.RegisterFunc(L, -2, "x", new lua_CSFunction(UnityEngineVector4Wrap._g_get_x));
			Utils.RegisterFunc(L, -2, "y", new lua_CSFunction(UnityEngineVector4Wrap._g_get_y));
			Utils.RegisterFunc(L, -2, "z", new lua_CSFunction(UnityEngineVector4Wrap._g_get_z));
			Utils.RegisterFunc(L, -2, "w", new lua_CSFunction(UnityEngineVector4Wrap._g_get_w));
			Utils.RegisterFunc(L, -1, "x", new lua_CSFunction(UnityEngineVector4Wrap._s_set_x));
			Utils.RegisterFunc(L, -1, "y", new lua_CSFunction(UnityEngineVector4Wrap._s_set_y));
			Utils.RegisterFunc(L, -1, "z", new lua_CSFunction(UnityEngineVector4Wrap._s_set_z));
			Utils.RegisterFunc(L, -1, "w", new lua_CSFunction(UnityEngineVector4Wrap._s_set_w));
			Utils.EndObjectRegister(type, L, translator, new lua_CSFunction(UnityEngineVector4Wrap.__CSIndexer), new lua_CSFunction(UnityEngineVector4Wrap.__NewIndexer), null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineVector4Wrap.__CreateInstance), 14, 4, 0);
			Utils.RegisterFunc(L, -4, "Lerp", new lua_CSFunction(UnityEngineVector4Wrap._m_Lerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "LerpUnclamped", new lua_CSFunction(UnityEngineVector4Wrap._m_LerpUnclamped_xlua_st_));
			Utils.RegisterFunc(L, -4, "MoveTowards", new lua_CSFunction(UnityEngineVector4Wrap._m_MoveTowards_xlua_st_));
			Utils.RegisterFunc(L, -4, "Scale", new lua_CSFunction(UnityEngineVector4Wrap._m_Scale_xlua_st_));
			Utils.RegisterFunc(L, -4, "Normalize", new lua_CSFunction(UnityEngineVector4Wrap._m_Normalize_xlua_st_));
			Utils.RegisterFunc(L, -4, "Dot", new lua_CSFunction(UnityEngineVector4Wrap._m_Dot_xlua_st_));
			Utils.RegisterFunc(L, -4, "Project", new lua_CSFunction(UnityEngineVector4Wrap._m_Project_xlua_st_));
			Utils.RegisterFunc(L, -4, "Distance", new lua_CSFunction(UnityEngineVector4Wrap._m_Distance_xlua_st_));
			Utils.RegisterFunc(L, -4, "Magnitude", new lua_CSFunction(UnityEngineVector4Wrap._m_Magnitude_xlua_st_));
			Utils.RegisterFunc(L, -4, "Min", new lua_CSFunction(UnityEngineVector4Wrap._m_Min_xlua_st_));
			Utils.RegisterFunc(L, -4, "Max", new lua_CSFunction(UnityEngineVector4Wrap._m_Max_xlua_st_));
			Utils.RegisterFunc(L, -4, "SqrMagnitude", new lua_CSFunction(UnityEngineVector4Wrap._m_SqrMagnitude_xlua_st_));
			Utils.RegisterObject(L, translator, -4, "kEpsilon", 1E-05f);
			Utils.RegisterFunc(L, -2, "zero", new lua_CSFunction(UnityEngineVector4Wrap._g_get_zero));
			Utils.RegisterFunc(L, -2, "one", new lua_CSFunction(UnityEngineVector4Wrap._g_get_one));
			Utils.RegisterFunc(L, -2, "positiveInfinity", new lua_CSFunction(UnityEngineVector4Wrap._g_get_positiveInfinity));
			Utils.RegisterFunc(L, -2, "negativeInfinity", new lua_CSFunction(UnityEngineVector4Wrap._g_get_negativeInfinity));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00081660 File Offset: 0x0007F860
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
					Vector4 gen_ret = new Vector4(_x, _y, _z, _w);
					translator.PushUnityEngineVector4(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag2)
				{
					float _x2 = (float)Lua.lua_tonumber(L, 2);
					float _y2 = (float)Lua.lua_tonumber(L, 3);
					float _z2 = (float)Lua.lua_tonumber(L, 4);
					Vector4 gen_ret2 = new Vector4(_x2, _y2, _z2);
					translator.PushUnityEngineVector4(L, gen_ret2);
					return 1;
				}
				bool flag3 = Lua.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag3)
				{
					float _x3 = (float)Lua.lua_tonumber(L, 2);
					float _y3 = (float)Lua.lua_tonumber(L, 3);
					Vector4 gen_ret3 = new Vector4(_x3, _y3);
					translator.PushUnityEngineVector4(L, gen_ret3);
					return 1;
				}
				bool flag4 = Lua.lua_gettop(L) == 1;
				if (flag4)
				{
					translator.PushUnityEngineVector4(L, default(Vector4));
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector4 constructor!");
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00081838 File Offset: 0x0007FA38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __CSIndexer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Vector4 gen_to_be_invoked;
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

		// Token: 0x06000F9A RID: 3994 RVA: 0x000818E8 File Offset: 0x0007FAE8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __NewIndexer(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				bool flag = translator.Assignable<Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					Vector4 gen_to_be_invoked;
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

		// Token: 0x06000F9B RID: 3995 RVA: 0x000819A4 File Offset: 0x0007FBA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __AddMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector4>(L, 1) && translator.Assignable<Vector4>(L, 2);
				if (flag)
				{
					Vector4 leftside;
					translator.Get(L, 1, out leftside);
					Vector4 rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineVector4(L, leftside + rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Vector4!");
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00081A4C File Offset: 0x0007FC4C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __SubMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector4>(L, 1) && translator.Assignable<Vector4>(L, 2);
				if (flag)
				{
					Vector4 leftside;
					translator.Get(L, 1, out leftside);
					Vector4 rightside;
					translator.Get(L, 2, out rightside);
					translator.PushUnityEngineVector4(L, leftside - rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Vector4!");
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00081AF4 File Offset: 0x0007FCF4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __UnmMeta(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				Vector4 rightside;
				translator.Get(L, 1, out rightside);
				translator.PushUnityEngineVector4(L, -rightside);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00081B64 File Offset: 0x0007FD64
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __MulMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Vector4 leftside;
					translator.Get(L, 1, out leftside);
					float rightside = (float)Lua.lua_tonumber(L, 2);
					translator.PushUnityEngineVector4(L, leftside * rightside);
					return 1;
				}
				bool flag2 = LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && translator.Assignable<Vector4>(L, 2);
				if (flag2)
				{
					float leftside2 = (float)Lua.lua_tonumber(L, 1);
					Vector4 rightside2;
					translator.Get(L, 2, out rightside2);
					translator.PushUnityEngineVector4(L, leftside2 * rightside2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Vector4!");
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00081C54 File Offset: 0x0007FE54
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __DivMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					Vector4 leftside;
					translator.Get(L, 1, out leftside);
					float rightside = (float)Lua.lua_tonumber(L, 2);
					translator.PushUnityEngineVector4(L, leftside / rightside);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Vector4!");
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00081CFC File Offset: 0x0007FEFC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __EqMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<Vector4>(L, 1) && translator.Assignable<Vector4>(L, 2);
				if (flag)
				{
					Vector4 leftside;
					translator.Get(L, 1, out leftside);
					Vector4 rightside;
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
			return Lua.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Vector4!");
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00081DA4 File Offset: 0x0007FFA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Set(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				float _newX = (float)Lua.lua_tonumber(L, 2);
				float _newY = (float)Lua.lua_tonumber(L, 3);
				float _newZ = (float)Lua.lua_tonumber(L, 4);
				float _newW = (float)Lua.lua_tonumber(L, 5);
				gen_to_be_invoked.Set(_newX, _newY, _newZ, _newW);
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00081E48 File Offset: 0x00080048
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Lerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				Vector4 _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Vector4 gen_ret = Vector4.Lerp(_a, _b, _t);
				translator.PushUnityEngineVector4(L, gen_ret);
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

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00081ED4 File Offset: 0x000800D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LerpUnclamped_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				Vector4 _b;
				translator.Get(L, 2, out _b);
				float _t = (float)Lua.lua_tonumber(L, 3);
				Vector4 gen_ret = Vector4.LerpUnclamped(_a, _b, _t);
				translator.PushUnityEngineVector4(L, gen_ret);
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

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00081F60 File Offset: 0x00080160
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_MoveTowards_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _current;
				translator.Get(L, 1, out _current);
				Vector4 _target;
				translator.Get(L, 2, out _target);
				float _maxDistanceDelta = (float)Lua.lua_tonumber(L, 3);
				Vector4 gen_ret = Vector4.MoveTowards(_current, _target, _maxDistanceDelta);
				translator.PushUnityEngineVector4(L, gen_ret);
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

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00081FEC File Offset: 0x000801EC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Scale_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				Vector4 _b;
				translator.Get(L, 2, out _b);
				Vector4 gen_ret = Vector4.Scale(_a, _b);
				translator.PushUnityEngineVector4(L, gen_ret);
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

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0008206C File Offset: 0x0008026C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Scale(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				Vector4 _scale;
				translator.Get(L, 2, out _scale);
				gen_to_be_invoked.Scale(_scale);
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000820EC File Offset: 0x000802EC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetHashCode(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_ret = gen_to_be_invoked.GetHashCode();
				Lua.xlua_pushinteger(L, gen_ret);
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0008216C File Offset: 0x0008036C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Equals(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<object>(L, 2);
				if (flag)
				{
					object _other = translator.GetObject(L, 2, typeof(object));
					bool gen_ret = gen_to_be_invoked.Equals(_other);
					Lua.lua_pushboolean(L, gen_ret);
					translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector4>(L, 2);
				if (flag2)
				{
					Vector4 _other2;
					translator.Get(L, 2, out _other2);
					bool gen_ret2 = gen_to_be_invoked.Equals(_other2);
					Lua.lua_pushboolean(L, gen_ret2);
					translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector4.Equals!");
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00082278 File Offset: 0x00080478
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Normalize_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				Vector4 gen_ret = Vector4.Normalize(_a);
				translator.PushUnityEngineVector4(L, gen_ret);
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

		// Token: 0x06000FAA RID: 4010 RVA: 0x000822E8 File Offset: 0x000804E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Normalize(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.Normalize();
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000FAB RID: 4011 RVA: 0x00082358 File Offset: 0x00080558
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Dot_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				Vector4 _b;
				translator.Get(L, 2, out _b);
				float gen_ret = Vector4.Dot(_a, _b);
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

		// Token: 0x06000FAC RID: 4012 RVA: 0x000823D8 File Offset: 0x000805D8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Project_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				Vector4 _b;
				translator.Get(L, 2, out _b);
				Vector4 gen_ret = Vector4.Project(_a, _b);
				translator.PushUnityEngineVector4(L, gen_ret);
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

		// Token: 0x06000FAD RID: 4013 RVA: 0x00082458 File Offset: 0x00080658
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Distance_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				Vector4 _b;
				translator.Get(L, 2, out _b);
				float gen_ret = Vector4.Distance(_a, _b);
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

		// Token: 0x06000FAE RID: 4014 RVA: 0x000824D8 File Offset: 0x000806D8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Magnitude_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				float gen_ret = Vector4.Magnitude(_a);
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

		// Token: 0x06000FAF RID: 4015 RVA: 0x00082548 File Offset: 0x00080748
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Min_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector4 _rhs;
				translator.Get(L, 2, out _rhs);
				Vector4 gen_ret = Vector4.Min(_lhs, _rhs);
				translator.PushUnityEngineVector4(L, gen_ret);
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

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000825C8 File Offset: 0x000807C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Max_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _lhs;
				translator.Get(L, 1, out _lhs);
				Vector4 _rhs;
				translator.Get(L, 2, out _rhs);
				Vector4 gen_ret = Vector4.Max(_lhs, _rhs);
				translator.PushUnityEngineVector4(L, gen_ret);
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

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00082648 File Offset: 0x00080848
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToString(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					string gen_ret = gen_to_be_invoked.ToString();
					Lua.lua_pushstring(L, gen_ret);
					translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _format = Lua.lua_tostring(L, 2);
					string gen_ret2 = gen_to_be_invoked.ToString(_format);
					Lua.lua_pushstring(L, gen_ret2);
					translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
					return 1;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<IFormatProvider>(L, 3);
				if (flag3)
				{
					string _format2 = Lua.lua_tostring(L, 2);
					IFormatProvider _formatProvider = (IFormatProvider)translator.GetObject(L, 3, typeof(IFormatProvider));
					string gen_ret3 = gen_to_be_invoked.ToString(_format2, _formatProvider);
					Lua.lua_pushstring(L, gen_ret3);
					translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Vector4.ToString!");
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x000827C0 File Offset: 0x000809C0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SqrMagnitude_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 _a;
				translator.Get(L, 1, out _a);
				float gen_ret = Vector4.SqrMagnitude(_a);
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

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00082830 File Offset: 0x00080A30
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SqrMagnitude(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				float gen_ret = gen_to_be_invoked.SqrMagnitude();
				Lua.lua_pushnumber(L, (double)gen_ret);
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
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

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000828AC File Offset: 0x00080AAC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_normalized(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				translator.PushUnityEngineVector4(L, gen_to_be_invoked.normalized);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0008291C File Offset: 0x00080B1C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_magnitude(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
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

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0008298C File Offset: 0x00080B8C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_sqrMagnitude(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
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

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000829FC File Offset: 0x00080BFC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_zero(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector4(L, Vector4.zero);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00082A60 File Offset: 0x00080C60
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_one(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector4(L, Vector4.one);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00082AC4 File Offset: 0x00080CC4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_positiveInfinity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector4(L, Vector4.positiveInfinity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00082B28 File Offset: 0x00080D28
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_negativeInfinity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushUnityEngineVector4(L, Vector4.negativeInfinity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00082B8C File Offset: 0x00080D8C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_x(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
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

		// Token: 0x06000FBC RID: 4028 RVA: 0x00082BFC File Offset: 0x00080DFC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_y(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
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

		// Token: 0x06000FBD RID: 4029 RVA: 0x00082C6C File Offset: 0x00080E6C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_z(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
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

		// Token: 0x06000FBE RID: 4030 RVA: 0x00082CDC File Offset: 0x00080EDC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_w(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
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

		// Token: 0x06000FBF RID: 4031 RVA: 0x00082D4C File Offset: 0x00080F4C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_x(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.x = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00082DC8 File Offset: 0x00080FC8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_y(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.y = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00082E44 File Offset: 0x00081044
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_z(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.z = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00082EC0 File Offset: 0x000810C0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_w(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Vector4 gen_to_be_invoked;
				translator.Get(L, 1, out gen_to_be_invoked);
				gen_to_be_invoked.w = (float)Lua.lua_tonumber(L, 2);
				translator.UpdateUnityEngineVector4(L, 1, gen_to_be_invoked);
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

using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B4 RID: 436
	public class UnityEngineDebugWrap
	{
		// Token: 0x06000E2F RID: 3631 RVA: 0x0006FF2C File Offset: 0x0006E12C
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Debug);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0, -1);
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineDebugWrap.__CreateInstance), 20, 4, 2);
			Utils.RegisterFunc(L, -4, "DrawLine", new lua_CSFunction(UnityEngineDebugWrap._m_DrawLine_xlua_st_));
			Utils.RegisterFunc(L, -4, "DrawRay", new lua_CSFunction(UnityEngineDebugWrap._m_DrawRay_xlua_st_));
			Utils.RegisterFunc(L, -4, "Break", new lua_CSFunction(UnityEngineDebugWrap._m_Break_xlua_st_));
			Utils.RegisterFunc(L, -4, "DebugBreak", new lua_CSFunction(UnityEngineDebugWrap._m_DebugBreak_xlua_st_));
			Utils.RegisterFunc(L, -4, "Log", new lua_CSFunction(UnityEngineDebugWrap._m_Log_xlua_st_));
			Utils.RegisterFunc(L, -4, "LogFormat", new lua_CSFunction(UnityEngineDebugWrap._m_LogFormat_xlua_st_));
			Utils.RegisterFunc(L, -4, "LogError", new lua_CSFunction(UnityEngineDebugWrap._m_LogError_xlua_st_));
			Utils.RegisterFunc(L, -4, "LogErrorFormat", new lua_CSFunction(UnityEngineDebugWrap._m_LogErrorFormat_xlua_st_));
			Utils.RegisterFunc(L, -4, "ClearDeveloperConsole", new lua_CSFunction(UnityEngineDebugWrap._m_ClearDeveloperConsole_xlua_st_));
			Utils.RegisterFunc(L, -4, "LogException", new lua_CSFunction(UnityEngineDebugWrap._m_LogException_xlua_st_));
			Utils.RegisterFunc(L, -4, "LogWarning", new lua_CSFunction(UnityEngineDebugWrap._m_LogWarning_xlua_st_));
			Utils.RegisterFunc(L, -4, "LogWarningFormat", new lua_CSFunction(UnityEngineDebugWrap._m_LogWarningFormat_xlua_st_));
			Utils.RegisterFunc(L, -4, "Assert", new lua_CSFunction(UnityEngineDebugWrap._m_Assert_xlua_st_));
			Utils.RegisterFunc(L, -4, "AssertFormat", new lua_CSFunction(UnityEngineDebugWrap._m_AssertFormat_xlua_st_));
			Utils.RegisterFunc(L, -4, "LogAssertion", new lua_CSFunction(UnityEngineDebugWrap._m_LogAssertion_xlua_st_));
			Utils.RegisterFunc(L, -4, "LogAssertionFormat", new lua_CSFunction(UnityEngineDebugWrap._m_LogAssertionFormat_xlua_st_));
			Utils.RegisterFunc(L, -4, "RetrieveStartupLogs", new lua_CSFunction(UnityEngineDebugWrap._m_RetrieveStartupLogs_xlua_st_));
			Utils.RegisterFunc(L, -4, "CheckIntegrity", new lua_CSFunction(UnityEngineDebugWrap._m_CheckIntegrity_xlua_st_));
			Utils.RegisterFunc(L, -4, "IsValidationLevelEnabled", new lua_CSFunction(UnityEngineDebugWrap._m_IsValidationLevelEnabled_xlua_st_));
			Utils.RegisterFunc(L, -2, "unityLogger", new lua_CSFunction(UnityEngineDebugWrap._g_get_unityLogger));
			Utils.RegisterFunc(L, -2, "developerConsoleEnabled", new lua_CSFunction(UnityEngineDebugWrap._g_get_developerConsoleEnabled));
			Utils.RegisterFunc(L, -2, "developerConsoleVisible", new lua_CSFunction(UnityEngineDebugWrap._g_get_developerConsoleVisible));
			Utils.RegisterFunc(L, -2, "isDebugBuild", new lua_CSFunction(UnityEngineDebugWrap._g_get_isDebugBuild));
			Utils.RegisterFunc(L, -1, "developerConsoleEnabled", new lua_CSFunction(UnityEngineDebugWrap._s_set_developerConsoleEnabled));
			Utils.RegisterFunc(L, -1, "developerConsoleVisible", new lua_CSFunction(UnityEngineDebugWrap._s_set_developerConsoleVisible));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00070218 File Offset: 0x0006E418
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					Debug gen_ret = new Debug();
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug constructor!");
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0007029C File Offset: 0x0006E49C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DrawLine_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag)
				{
					Vector3 _start;
					translator.Get(L, 1, out _start);
					Vector3 _end;
					translator.Get(L, 2, out _end);
					Debug.DrawLine(_start, _end);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Color>(L, 3);
				if (flag2)
				{
					Vector3 _start2;
					translator.Get(L, 1, out _start2);
					Vector3 _end2;
					translator.Get(L, 2, out _end2);
					Color _color;
					translator.Get(L, 3, out _color);
					Debug.DrawLine(_start2, _end2, _color);
					return 0;
				}
				bool flag3 = gen_param_count == 4 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Color>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag3)
				{
					Vector3 _start3;
					translator.Get(L, 1, out _start3);
					Vector3 _end3;
					translator.Get(L, 2, out _end3);
					Color _color2;
					translator.Get(L, 3, out _color2);
					float _duration = (float)Lua.lua_tonumber(L, 4);
					Debug.DrawLine(_start3, _end3, _color2, _duration);
					return 0;
				}
				bool flag4 = gen_param_count == 5 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Color>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 5);
				if (flag4)
				{
					Vector3 _start4;
					translator.Get(L, 1, out _start4);
					Vector3 _end4;
					translator.Get(L, 2, out _end4);
					Color _color3;
					translator.Get(L, 3, out _color3);
					float _duration2 = (float)Lua.lua_tonumber(L, 4);
					bool _depthTest = Lua.lua_toboolean(L, 5);
					Debug.DrawLine(_start4, _end4, _color3, _duration2, _depthTest);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.DrawLine!");
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000704B8 File Offset: 0x0006E6B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DrawRay_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2);
				if (flag)
				{
					Vector3 _start;
					translator.Get(L, 1, out _start);
					Vector3 _dir;
					translator.Get(L, 2, out _dir);
					Debug.DrawRay(_start, _dir);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Color>(L, 3);
				if (flag2)
				{
					Vector3 _start2;
					translator.Get(L, 1, out _start2);
					Vector3 _dir2;
					translator.Get(L, 2, out _dir2);
					Color _color;
					translator.Get(L, 3, out _color);
					Debug.DrawRay(_start2, _dir2, _color);
					return 0;
				}
				bool flag3 = gen_param_count == 4 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Color>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag3)
				{
					Vector3 _start3;
					translator.Get(L, 1, out _start3);
					Vector3 _dir3;
					translator.Get(L, 2, out _dir3);
					Color _color2;
					translator.Get(L, 3, out _color2);
					float _duration = (float)Lua.lua_tonumber(L, 4);
					Debug.DrawRay(_start3, _dir3, _color2, _duration);
					return 0;
				}
				bool flag4 = gen_param_count == 5 && translator.Assignable<Vector3>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Color>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 5);
				if (flag4)
				{
					Vector3 _start4;
					translator.Get(L, 1, out _start4);
					Vector3 _dir4;
					translator.Get(L, 2, out _dir4);
					Color _color3;
					translator.Get(L, 3, out _color3);
					float _duration2 = (float)Lua.lua_tonumber(L, 4);
					bool _depthTest = Lua.lua_toboolean(L, 5);
					Debug.DrawRay(_start4, _dir4, _color3, _duration2, _depthTest);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.DrawRay!");
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x000706D4 File Offset: 0x0006E8D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Break_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				Debug.Break();
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

		// Token: 0x06000E34 RID: 3636 RVA: 0x00070724 File Offset: 0x0006E924
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DebugBreak_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				Debug.DebugBreak();
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

		// Token: 0x06000E35 RID: 3637 RVA: 0x00070774 File Offset: 0x0006E974
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Log_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<object>(L, 1);
				if (flag)
				{
					object _message = translator.GetObject(L, 1, typeof(object));
					Debug.Log(_message);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<object>(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2);
				if (flag2)
				{
					object _message2 = translator.GetObject(L, 1, typeof(object));
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					Debug.Log(_message2, _context);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.Log!");
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00070874 File Offset: 0x0006EA74
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LogFormat_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count >= 1 && (Lua.lua_isnil(L, 1) || Lua.lua_type(L, 1) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 2) || translator.Assignable<object>(L, 2));
				if (flag)
				{
					string _format = Lua.lua_tostring(L, 1);
					object[] _args = translator.GetParams<object>(L, 2);
					Debug.LogFormat(_format, _args);
					return 0;
				}
				bool flag2 = gen_param_count >= 2 && translator.Assignable<UnityEngine.Object>(L, 1) && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 3) || translator.Assignable<object>(L, 3));
				if (flag2)
				{
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					string _format2 = Lua.lua_tostring(L, 2);
					object[] _args2 = translator.GetParams<object>(L, 3);
					Debug.LogFormat(_context, _format2, _args2);
					return 0;
				}
				bool flag3 = gen_param_count >= 4 && translator.Assignable<LogType>(L, 1) && translator.Assignable<LogOption>(L, 2) && translator.Assignable<UnityEngine.Object>(L, 3) && (Lua.lua_isnil(L, 4) || Lua.lua_type(L, 4) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 5) || translator.Assignable<object>(L, 5));
				if (flag3)
				{
					LogType _logType;
					translator.Get<LogType>(L, 1, out _logType);
					LogOption _logOptions;
					translator.Get<LogOption>(L, 2, out _logOptions);
					UnityEngine.Object _context2 = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
					string _format3 = Lua.lua_tostring(L, 4);
					object[] _args3 = translator.GetParams<object>(L, 5);
					Debug.LogFormat(_logType, _logOptions, _context2, _format3, _args3);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogFormat!");
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00070A70 File Offset: 0x0006EC70
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LogError_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<object>(L, 1);
				if (flag)
				{
					object _message = translator.GetObject(L, 1, typeof(object));
					Debug.LogError(_message);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<object>(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2);
				if (flag2)
				{
					object _message2 = translator.GetObject(L, 1, typeof(object));
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					Debug.LogError(_message2, _context);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogError!");
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00070B70 File Offset: 0x0006ED70
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LogErrorFormat_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count >= 1 && (Lua.lua_isnil(L, 1) || Lua.lua_type(L, 1) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 2) || translator.Assignable<object>(L, 2));
				if (flag)
				{
					string _format = Lua.lua_tostring(L, 1);
					object[] _args = translator.GetParams<object>(L, 2);
					Debug.LogErrorFormat(_format, _args);
					return 0;
				}
				bool flag2 = gen_param_count >= 2 && translator.Assignable<UnityEngine.Object>(L, 1) && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 3) || translator.Assignable<object>(L, 3));
				if (flag2)
				{
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					string _format2 = Lua.lua_tostring(L, 2);
					object[] _args2 = translator.GetParams<object>(L, 3);
					Debug.LogErrorFormat(_context, _format2, _args2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogErrorFormat!");
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00070CB0 File Offset: 0x0006EEB0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ClearDeveloperConsole_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				Debug.ClearDeveloperConsole();
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

		// Token: 0x06000E3A RID: 3642 RVA: 0x00070D00 File Offset: 0x0006EF00
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LogException_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<Exception>(L, 1);
				if (flag)
				{
					Exception _exception = (Exception)translator.GetObject(L, 1, typeof(Exception));
					Debug.LogException(_exception);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Exception>(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2);
				if (flag2)
				{
					Exception _exception2 = (Exception)translator.GetObject(L, 1, typeof(Exception));
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					Debug.LogException(_exception2, _context);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogException!");
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00070E08 File Offset: 0x0006F008
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LogWarning_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<object>(L, 1);
				if (flag)
				{
					object _message = translator.GetObject(L, 1, typeof(object));
					Debug.LogWarning(_message);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<object>(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2);
				if (flag2)
				{
					object _message2 = translator.GetObject(L, 1, typeof(object));
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					Debug.LogWarning(_message2, _context);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogWarning!");
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00070F08 File Offset: 0x0006F108
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LogWarningFormat_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count >= 1 && (Lua.lua_isnil(L, 1) || Lua.lua_type(L, 1) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 2) || translator.Assignable<object>(L, 2));
				if (flag)
				{
					string _format = Lua.lua_tostring(L, 1);
					object[] _args = translator.GetParams<object>(L, 2);
					Debug.LogWarningFormat(_format, _args);
					return 0;
				}
				bool flag2 = gen_param_count >= 2 && translator.Assignable<UnityEngine.Object>(L, 1) && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 3) || translator.Assignable<object>(L, 3));
				if (flag2)
				{
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					string _format2 = Lua.lua_tostring(L, 2);
					object[] _args2 = translator.GetParams<object>(L, 3);
					Debug.LogWarningFormat(_context, _format2, _args2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogWarningFormat!");
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00071048 File Offset: 0x0006F248
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Assert_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 1);
				if (flag)
				{
					bool _condition = Lua.lua_toboolean(L, 1);
					Debug.Assert(_condition);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2);
				if (flag2)
				{
					bool _condition2 = Lua.lua_toboolean(L, 1);
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					Debug.Assert(_condition2, _context);
					return 0;
				}
				bool flag3 = gen_param_count == 2 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 1) && translator.Assignable<object>(L, 2);
				if (flag3)
				{
					bool _condition3 = Lua.lua_toboolean(L, 1);
					object _message = translator.GetObject(L, 2, typeof(object));
					Debug.Assert(_condition3, _message);
					return 0;
				}
				bool flag4 = gen_param_count == 2 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 1) && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag4)
				{
					bool _condition4 = Lua.lua_toboolean(L, 1);
					string _message2 = Lua.lua_tostring(L, 2);
					Debug.Assert(_condition4, _message2);
					return 0;
				}
				bool flag5 = gen_param_count == 3 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 1) && translator.Assignable<object>(L, 2) && translator.Assignable<UnityEngine.Object>(L, 3);
				if (flag5)
				{
					bool _condition5 = Lua.lua_toboolean(L, 1);
					object _message3 = translator.GetObject(L, 2, typeof(object));
					UnityEngine.Object _context2 = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
					Debug.Assert(_condition5, _message3, _context2);
					return 0;
				}
				bool flag6 = gen_param_count == 3 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 1) && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.Object>(L, 3);
				if (flag6)
				{
					bool _condition6 = Lua.lua_toboolean(L, 1);
					string _message4 = Lua.lua_tostring(L, 2);
					UnityEngine.Object _context3 = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
					Debug.Assert(_condition6, _message4, _context3);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.Assert!");
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x000712C4 File Offset: 0x0006F4C4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AssertFormat_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count >= 2 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 1) && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 3) || translator.Assignable<object>(L, 3));
				if (flag)
				{
					bool _condition = Lua.lua_toboolean(L, 1);
					string _format = Lua.lua_tostring(L, 2);
					object[] _args = translator.GetParams<object>(L, 3);
					Debug.AssertFormat(_condition, _format, _args);
					return 0;
				}
				bool flag2 = gen_param_count >= 3 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 4) || translator.Assignable<object>(L, 4));
				if (flag2)
				{
					bool _condition2 = Lua.lua_toboolean(L, 1);
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					string _format2 = Lua.lua_tostring(L, 3);
					object[] _args2 = translator.GetParams<object>(L, 4);
					Debug.AssertFormat(_condition2, _context, _format2, _args2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.AssertFormat!");
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0007143C File Offset: 0x0006F63C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LogAssertion_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<object>(L, 1);
				if (flag)
				{
					object _message = translator.GetObject(L, 1, typeof(object));
					Debug.LogAssertion(_message);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<object>(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2);
				if (flag2)
				{
					object _message2 = translator.GetObject(L, 1, typeof(object));
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
					Debug.LogAssertion(_message2, _context);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogAssertion!");
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0007153C File Offset: 0x0006F73C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LogAssertionFormat_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count >= 1 && (Lua.lua_isnil(L, 1) || Lua.lua_type(L, 1) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 2) || translator.Assignable<object>(L, 2));
				if (flag)
				{
					string _format = Lua.lua_tostring(L, 1);
					object[] _args = translator.GetParams<object>(L, 2);
					Debug.LogAssertionFormat(_format, _args);
					return 0;
				}
				bool flag2 = gen_param_count >= 2 && translator.Assignable<UnityEngine.Object>(L, 1) && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 3) || translator.Assignable<object>(L, 3));
				if (flag2)
				{
					UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					string _format2 = Lua.lua_tostring(L, 2);
					object[] _args2 = translator.GetParams<object>(L, 3);
					Debug.LogAssertionFormat(_context, _format2, _args2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogAssertionFormat!");
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0007167C File Offset: 0x0006F87C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RetrieveStartupLogs_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Debug.StartupLog[] gen_ret = Debug.RetrieveStartupLogs();
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

		// Token: 0x06000E42 RID: 3650 RVA: 0x000716E0 File Offset: 0x0006F8E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CheckIntegrity_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				IntegrityCheckLevel _level;
				translator.Get<IntegrityCheckLevel>(L, 1, out _level);
				string gen_ret = Debug.CheckIntegrity(_level);
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

		// Token: 0x06000E43 RID: 3651 RVA: 0x00071750 File Offset: 0x0006F950
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_IsValidationLevelEnabled_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ValidationLevel _level;
				translator.Get<ValidationLevel>(L, 1, out _level);
				bool gen_ret = Debug.IsValidationLevelEnabled(_level);
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

		// Token: 0x06000E44 RID: 3652 RVA: 0x000717C0 File Offset: 0x0006F9C0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_unityLogger(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.PushAny(L, Debug.unityLogger);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00071824 File Offset: 0x0006FA24
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_developerConsoleEnabled(IntPtr L)
		{
			try
			{
				Lua.lua_pushboolean(L, Debug.developerConsoleEnabled);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0007187C File Offset: 0x0006FA7C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_developerConsoleVisible(IntPtr L)
		{
			try
			{
				Lua.lua_pushboolean(L, Debug.developerConsoleVisible);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x000718D4 File Offset: 0x0006FAD4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_isDebugBuild(IntPtr L)
		{
			try
			{
				Lua.lua_pushboolean(L, Debug.isDebugBuild);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0007192C File Offset: 0x0006FB2C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_developerConsoleEnabled(IntPtr L)
		{
			try
			{
				Debug.developerConsoleEnabled = Lua.lua_toboolean(L, 1);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00071984 File Offset: 0x0006FB84
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_developerConsoleVisible(IntPtr L)
		{
			try
			{
				Debug.developerConsoleVisible = Lua.lua_toboolean(L, 1);
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

using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B8 RID: 440
	public class UnityEngineObjectWrap
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x0007665C File Offset: 0x0007485C
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(UnityEngine.Object);
			Utils.BeginObjectRegister(type, L, translator, 1, 4, 2, 2, -1);
			Utils.RegisterFunc(L, -4, "__eq", new lua_CSFunction(UnityEngineObjectWrap.__EqMeta));
			Utils.RegisterFunc(L, -3, "GetInstanceID", new lua_CSFunction(UnityEngineObjectWrap._m_GetInstanceID));
			Utils.RegisterFunc(L, -3, "GetHashCode", new lua_CSFunction(UnityEngineObjectWrap._m_GetHashCode));
			Utils.RegisterFunc(L, -3, "Equals", new lua_CSFunction(UnityEngineObjectWrap._m_Equals));
			Utils.RegisterFunc(L, -3, "ToString", new lua_CSFunction(UnityEngineObjectWrap._m_ToString));
			Utils.RegisterFunc(L, -2, "name", new lua_CSFunction(UnityEngineObjectWrap._g_get_name));
			Utils.RegisterFunc(L, -2, "hideFlags", new lua_CSFunction(UnityEngineObjectWrap._g_get_hideFlags));
			Utils.RegisterFunc(L, -1, "name", new lua_CSFunction(UnityEngineObjectWrap._s_set_name));
			Utils.RegisterFunc(L, -1, "hideFlags", new lua_CSFunction(UnityEngineObjectWrap._s_set_hideFlags));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineObjectWrap.__CreateInstance), 9, 0, 0);
			Utils.RegisterFunc(L, -4, "InstantiateAsync", new lua_CSFunction(UnityEngineObjectWrap._m_InstantiateAsync_xlua_st_));
			Utils.RegisterFunc(L, -4, "Instantiate", new lua_CSFunction(UnityEngineObjectWrap._m_Instantiate_xlua_st_));
			Utils.RegisterFunc(L, -4, "Destroy", new lua_CSFunction(UnityEngineObjectWrap._m_Destroy_xlua_st_));
			Utils.RegisterFunc(L, -4, "DestroyImmediate", new lua_CSFunction(UnityEngineObjectWrap._m_DestroyImmediate_xlua_st_));
			Utils.RegisterFunc(L, -4, "FindObjectsByType", new lua_CSFunction(UnityEngineObjectWrap._m_FindObjectsByType_xlua_st_));
			Utils.RegisterFunc(L, -4, "DontDestroyOnLoad", new lua_CSFunction(UnityEngineObjectWrap._m_DontDestroyOnLoad_xlua_st_));
			Utils.RegisterFunc(L, -4, "FindFirstObjectByType", new lua_CSFunction(UnityEngineObjectWrap._m_FindFirstObjectByType_xlua_st_));
			Utils.RegisterFunc(L, -4, "FindAnyObjectByType", new lua_CSFunction(UnityEngineObjectWrap._m_FindAnyObjectByType_xlua_st_));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00076878 File Offset: 0x00074A78
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					UnityEngine.Object gen_ret = new UnityEngine.Object();
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Object constructor!");
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000768FC File Offset: 0x00074AFC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __EqMeta(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<UnityEngine.Object>(L, 2);
				if (flag)
				{
					UnityEngine.Object leftside = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					UnityEngine.Object rightside = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
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
			return Lua.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Object!");
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000769C0 File Offset: 0x00074BC0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetInstanceID(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
				int gen_ret = gen_to_be_invoked.GetInstanceID();
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

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00076A34 File Offset: 0x00074C34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetHashCode(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
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

		// Token: 0x06000EBA RID: 3770 RVA: 0x00076AA8 File Offset: 0x00074CA8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Equals(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
				object _other = translator.GetObject(L, 2, typeof(object));
				bool gen_ret = gen_to_be_invoked.Equals(_other);
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

		// Token: 0x06000EBB RID: 3771 RVA: 0x00076B34 File Offset: 0x00074D34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InstantiateAsync_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<UnityEngine.Object>(L, 1);
				if (flag)
				{
					UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					UnityEngine.Object _original2 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count = Lua.xlua_tointeger(L, 2);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret2 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original2, _count);
					translator.Push(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Transform>(L, 2);
				if (flag3)
				{
					UnityEngine.Object _original3 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Transform _parent = (Transform)translator.GetObject(L, 2, typeof(Transform));
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret3 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original3, _parent);
					translator.Push(L, gen_ret3);
					return 1;
				}
				bool flag4 = gen_param_count == 3 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<Transform>(L, 3);
				if (flag4)
				{
					UnityEngine.Object _original4 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count2 = Lua.xlua_tointeger(L, 2);
					Transform _parent2 = (Transform)translator.GetObject(L, 3, typeof(Transform));
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret4 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original4, _count2, _parent2);
					translator.Push(L, gen_ret4);
					return 1;
				}
				bool flag5 = gen_param_count == 3 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Quaternion>(L, 3);
				if (flag5)
				{
					UnityEngine.Object _original5 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Vector3 _position;
					translator.Get(L, 2, out _position);
					Quaternion _rotation;
					translator.Get(L, 3, out _rotation);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret5 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original5, _position, _rotation);
					translator.Push(L, gen_ret5);
					return 1;
				}
				bool flag6 = gen_param_count == 3 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<InstantiateParameters>(L, 2) && translator.Assignable<CancellationToken>(L, 3);
				if (flag6)
				{
					UnityEngine.Object _original6 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					InstantiateParameters _parameters;
					translator.Get<InstantiateParameters>(L, 2, out _parameters);
					CancellationToken _cancellationToken;
					translator.Get<CancellationToken>(L, 3, out _cancellationToken);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret6 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original6, _parameters, _cancellationToken);
					translator.Push(L, gen_ret6);
					return 1;
				}
				bool flag7 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<InstantiateParameters>(L, 2);
				if (flag7)
				{
					UnityEngine.Object _original7 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					InstantiateParameters _parameters2;
					translator.Get<InstantiateParameters>(L, 2, out _parameters2);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret7 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original7, _parameters2, default(CancellationToken));
					translator.Push(L, gen_ret7);
					return 1;
				}
				bool flag8 = gen_param_count == 4 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<Vector3>(L, 3) && translator.Assignable<Quaternion>(L, 4);
				if (flag8)
				{
					UnityEngine.Object _original8 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count3 = Lua.xlua_tointeger(L, 2);
					Vector3 _position2;
					translator.Get(L, 3, out _position2);
					Quaternion _rotation2;
					translator.Get(L, 4, out _rotation2);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret8 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original8, _count3, _position2, _rotation2);
					translator.Push(L, gen_ret8);
					return 1;
				}
				bool flag9 = gen_param_count == 4 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<InstantiateParameters>(L, 3) && translator.Assignable<CancellationToken>(L, 4);
				if (flag9)
				{
					UnityEngine.Object _original9 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count4 = Lua.xlua_tointeger(L, 2);
					InstantiateParameters _parameters3;
					translator.Get<InstantiateParameters>(L, 3, out _parameters3);
					CancellationToken _cancellationToken2;
					translator.Get<CancellationToken>(L, 4, out _cancellationToken2);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret9 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original9, _count4, _parameters3, _cancellationToken2);
					translator.Push(L, gen_ret9);
					return 1;
				}
				bool flag10 = gen_param_count == 3 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<InstantiateParameters>(L, 3);
				if (flag10)
				{
					UnityEngine.Object _original10 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count5 = Lua.xlua_tointeger(L, 2);
					InstantiateParameters _parameters4;
					translator.Get<InstantiateParameters>(L, 3, out _parameters4);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret10 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original10, _count5, _parameters4, default(CancellationToken));
					translator.Push(L, gen_ret10);
					return 1;
				}
				bool flag11 = gen_param_count == 4 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Transform>(L, 2) && translator.Assignable<Vector3>(L, 3) && translator.Assignable<Quaternion>(L, 4);
				if (flag11)
				{
					UnityEngine.Object _original11 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Transform _parent3 = (Transform)translator.GetObject(L, 2, typeof(Transform));
					Vector3 _position3;
					translator.Get(L, 3, out _position3);
					Quaternion _rotation3;
					translator.Get(L, 4, out _rotation3);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret11 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original11, _parent3, _position3, _rotation3);
					translator.Push(L, gen_ret11);
					return 1;
				}
				bool flag12 = gen_param_count == 5 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<Transform>(L, 3) && translator.Assignable<Vector3>(L, 4) && translator.Assignable<Quaternion>(L, 5);
				if (flag12)
				{
					UnityEngine.Object _original12 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count6 = Lua.xlua_tointeger(L, 2);
					Transform _parent4 = (Transform)translator.GetObject(L, 3, typeof(Transform));
					Vector3 _position4;
					translator.Get(L, 4, out _position4);
					Quaternion _rotation4;
					translator.Get(L, 5, out _rotation4);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret12 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original12, _count6, _parent4, _position4, _rotation4);
					translator.Push(L, gen_ret12);
					return 1;
				}
				bool flag13 = gen_param_count == 5 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Quaternion>(L, 3) && translator.Assignable<InstantiateParameters>(L, 4) && translator.Assignable<CancellationToken>(L, 5);
				if (flag13)
				{
					UnityEngine.Object _original13 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Vector3 _position5;
					translator.Get(L, 2, out _position5);
					Quaternion _rotation5;
					translator.Get(L, 3, out _rotation5);
					InstantiateParameters _parameters5;
					translator.Get<InstantiateParameters>(L, 4, out _parameters5);
					CancellationToken _cancellationToken3;
					translator.Get<CancellationToken>(L, 5, out _cancellationToken3);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret13 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original13, _position5, _rotation5, _parameters5, _cancellationToken3);
					translator.Push(L, gen_ret13);
					return 1;
				}
				bool flag14 = gen_param_count == 4 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Quaternion>(L, 3) && translator.Assignable<InstantiateParameters>(L, 4);
				if (flag14)
				{
					UnityEngine.Object _original14 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Vector3 _position6;
					translator.Get(L, 2, out _position6);
					Quaternion _rotation6;
					translator.Get(L, 3, out _rotation6);
					InstantiateParameters _parameters6;
					translator.Get<InstantiateParameters>(L, 4, out _parameters6);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret14 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original14, _position6, _rotation6, _parameters6, default(CancellationToken));
					translator.Push(L, gen_ret14);
					return 1;
				}
				bool flag15 = gen_param_count == 6 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<Transform>(L, 3) && translator.Assignable<Vector3>(L, 4) && translator.Assignable<Quaternion>(L, 5) && translator.Assignable<CancellationToken>(L, 6);
				if (flag15)
				{
					UnityEngine.Object _original15 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count7 = Lua.xlua_tointeger(L, 2);
					Transform _parent5 = (Transform)translator.GetObject(L, 3, typeof(Transform));
					Vector3 _position7;
					translator.Get(L, 4, out _position7);
					Quaternion _rotation7;
					translator.Get(L, 5, out _rotation7);
					CancellationToken _cancellationToken4;
					translator.Get<CancellationToken>(L, 6, out _cancellationToken4);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret15 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original15, _count7, _parent5, _position7, _rotation7, _cancellationToken4);
					translator.Push(L, gen_ret15);
					return 1;
				}
				bool flag16 = gen_param_count == 6 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<Vector3>(L, 3) && translator.Assignable<Quaternion>(L, 4) && translator.Assignable<InstantiateParameters>(L, 5) && translator.Assignable<CancellationToken>(L, 6);
				if (flag16)
				{
					UnityEngine.Object _original16 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count8 = Lua.xlua_tointeger(L, 2);
					Vector3 _position8;
					translator.Get(L, 3, out _position8);
					Quaternion _rotation8;
					translator.Get(L, 4, out _rotation8);
					InstantiateParameters _parameters7;
					translator.Get<InstantiateParameters>(L, 5, out _parameters7);
					CancellationToken _cancellationToken5;
					translator.Get<CancellationToken>(L, 6, out _cancellationToken5);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret16 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original16, _count8, _position8, _rotation8, _parameters7, _cancellationToken5);
					translator.Push(L, gen_ret16);
					return 1;
				}
				bool flag17 = gen_param_count == 5 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<Vector3>(L, 3) && translator.Assignable<Quaternion>(L, 4) && translator.Assignable<InstantiateParameters>(L, 5);
				if (flag17)
				{
					UnityEngine.Object _original17 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					int _count9 = Lua.xlua_tointeger(L, 2);
					Vector3 _position9;
					translator.Get(L, 3, out _position9);
					Quaternion _rotation9;
					translator.Get(L, 4, out _rotation9);
					InstantiateParameters _parameters8;
					translator.Get<InstantiateParameters>(L, 5, out _parameters8);
					AsyncInstantiateOperation<UnityEngine.Object> gen_ret17 = UnityEngine.Object.InstantiateAsync<UnityEngine.Object>(_original17, _count9, _position9, _rotation9, _parameters8, default(CancellationToken));
					translator.Push(L, gen_ret17);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Object.InstantiateAsync!");
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x000774FC File Offset: 0x000756FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Instantiate_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<UnityEngine.Object>(L, 1);
				if (flag)
				{
					UnityEngine.Object _original = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					UnityEngine.Object gen_ret = UnityEngine.Object.Instantiate(_original);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 1 && translator.Assignable<UnityEngine.Object>(L, 1);
				if (flag2)
				{
					UnityEngine.Object _original2 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					UnityEngine.Object gen_ret2 = UnityEngine.Object.Instantiate(_original2);
					translator.Push(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Scene>(L, 2);
				if (flag3)
				{
					UnityEngine.Object _original3 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Scene _scene;
					translator.Get<Scene>(L, 2, out _scene);
					UnityEngine.Object gen_ret3 = UnityEngine.Object.Instantiate(_original3, _scene);
					translator.Push(L, gen_ret3);
					return 1;
				}
				bool flag4 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<InstantiateParameters>(L, 2);
				if (flag4)
				{
					UnityEngine.Object _original4 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					InstantiateParameters _parameters;
					translator.Get<InstantiateParameters>(L, 2, out _parameters);
					UnityEngine.Object gen_ret4 = UnityEngine.Object.Instantiate<UnityEngine.Object>(_original4, _parameters);
					translator.Push(L, gen_ret4);
					return 1;
				}
				bool flag5 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Transform>(L, 2);
				if (flag5)
				{
					UnityEngine.Object _original5 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Transform _parent = (Transform)translator.GetObject(L, 2, typeof(Transform));
					UnityEngine.Object gen_ret5 = UnityEngine.Object.Instantiate(_original5, _parent);
					translator.Push(L, gen_ret5);
					return 1;
				}
				bool flag6 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Transform>(L, 2);
				if (flag6)
				{
					UnityEngine.Object _original6 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Transform _parent2 = (Transform)translator.GetObject(L, 2, typeof(Transform));
					UnityEngine.Object gen_ret6 = UnityEngine.Object.Instantiate(_original6, _parent2);
					translator.Push(L, gen_ret6);
					return 1;
				}
				bool flag7 = gen_param_count == 3 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Transform>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag7)
				{
					UnityEngine.Object _original7 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Transform _parent3 = (Transform)translator.GetObject(L, 2, typeof(Transform));
					bool _instantiateInWorldSpace = Lua.lua_toboolean(L, 3);
					UnityEngine.Object gen_ret7 = UnityEngine.Object.Instantiate(_original7, _parent3, _instantiateInWorldSpace);
					translator.Push(L, gen_ret7);
					return 1;
				}
				bool flag8 = gen_param_count == 3 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Transform>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag8)
				{
					UnityEngine.Object _original8 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Transform _parent4 = (Transform)translator.GetObject(L, 2, typeof(Transform));
					bool _worldPositionStays = Lua.lua_toboolean(L, 3);
					UnityEngine.Object gen_ret8 = UnityEngine.Object.Instantiate(_original8, _parent4, _worldPositionStays);
					translator.Push(L, gen_ret8);
					return 1;
				}
				bool flag9 = gen_param_count == 3 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Quaternion>(L, 3);
				if (flag9)
				{
					UnityEngine.Object _original9 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Vector3 _position;
					translator.Get(L, 2, out _position);
					Quaternion _rotation;
					translator.Get(L, 3, out _rotation);
					UnityEngine.Object gen_ret9 = UnityEngine.Object.Instantiate(_original9, _position, _rotation);
					translator.Push(L, gen_ret9);
					return 1;
				}
				bool flag10 = gen_param_count == 3 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Quaternion>(L, 3);
				if (flag10)
				{
					UnityEngine.Object _original10 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Vector3 _position2;
					translator.Get(L, 2, out _position2);
					Quaternion _rotation2;
					translator.Get(L, 3, out _rotation2);
					UnityEngine.Object gen_ret10 = UnityEngine.Object.Instantiate(_original10, _position2, _rotation2);
					translator.Push(L, gen_ret10);
					return 1;
				}
				bool flag11 = gen_param_count == 4 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Quaternion>(L, 3) && translator.Assignable<Transform>(L, 4);
				if (flag11)
				{
					UnityEngine.Object _original11 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Vector3 _position3;
					translator.Get(L, 2, out _position3);
					Quaternion _rotation3;
					translator.Get(L, 3, out _rotation3);
					Transform _parent5 = (Transform)translator.GetObject(L, 4, typeof(Transform));
					UnityEngine.Object gen_ret11 = UnityEngine.Object.Instantiate(_original11, _position3, _rotation3, _parent5);
					translator.Push(L, gen_ret11);
					return 1;
				}
				bool flag12 = gen_param_count == 4 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Quaternion>(L, 3) && translator.Assignable<InstantiateParameters>(L, 4);
				if (flag12)
				{
					UnityEngine.Object _original12 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Vector3 _position4;
					translator.Get(L, 2, out _position4);
					Quaternion _rotation4;
					translator.Get(L, 3, out _rotation4);
					InstantiateParameters _parameters2;
					translator.Get<InstantiateParameters>(L, 4, out _parameters2);
					UnityEngine.Object gen_ret12 = UnityEngine.Object.Instantiate<UnityEngine.Object>(_original12, _position4, _rotation4, _parameters2);
					translator.Push(L, gen_ret12);
					return 1;
				}
				bool flag13 = gen_param_count == 4 && translator.Assignable<UnityEngine.Object>(L, 1) && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Quaternion>(L, 3) && translator.Assignable<Transform>(L, 4);
				if (flag13)
				{
					UnityEngine.Object _original13 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					Vector3 _position5;
					translator.Get(L, 2, out _position5);
					Quaternion _rotation5;
					translator.Get(L, 3, out _rotation5);
					Transform _parent6 = (Transform)translator.GetObject(L, 4, typeof(Transform));
					UnityEngine.Object gen_ret13 = UnityEngine.Object.Instantiate(_original13, _position5, _rotation5, _parent6);
					translator.Push(L, gen_ret13);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Object.Instantiate!");
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00077B68 File Offset: 0x00075D68
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Destroy_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<UnityEngine.Object>(L, 1);
				if (flag)
				{
					UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					UnityEngine.Object.Destroy(_obj);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					UnityEngine.Object _obj2 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					float _t = (float)Lua.lua_tonumber(L, 2);
					UnityEngine.Object.Destroy(_obj2, _t);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Object.Destroy!");
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00077C64 File Offset: 0x00075E64
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DestroyImmediate_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<UnityEngine.Object>(L, 1);
				if (flag)
				{
					UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					UnityEngine.Object.DestroyImmediate(_obj);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<UnityEngine.Object>(L, 1) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 2);
				if (flag2)
				{
					UnityEngine.Object _obj2 = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
					bool _allowDestroyingAssets = Lua.lua_toboolean(L, 2);
					UnityEngine.Object.DestroyImmediate(_obj2, _allowDestroyingAssets);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Object.DestroyImmediate!");
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00077D60 File Offset: 0x00075F60
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindObjectsByType_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 1) && translator.Assignable<FindObjectsSortMode>(L, 2);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 1, typeof(Type));
					FindObjectsSortMode _sortMode;
					translator.Get<FindObjectsSortMode>(L, 2, out _sortMode);
					UnityEngine.Object[] gen_ret = UnityEngine.Object.FindObjectsByType(_type, _sortMode);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 1) && translator.Assignable<FindObjectsInactive>(L, 2) && translator.Assignable<FindObjectsSortMode>(L, 3);
				if (flag2)
				{
					Type _type2 = (Type)translator.GetObject(L, 1, typeof(Type));
					FindObjectsInactive _findObjectsInactive;
					translator.Get<FindObjectsInactive>(L, 2, out _findObjectsInactive);
					FindObjectsSortMode _sortMode2;
					translator.Get<FindObjectsSortMode>(L, 3, out _sortMode2);
					UnityEngine.Object[] gen_ret2 = UnityEngine.Object.FindObjectsByType(_type2, _findObjectsInactive, _sortMode2);
					translator.Push(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Object.FindObjectsByType!");
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00077EA0 File Offset: 0x000760A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DontDestroyOnLoad_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object _target = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
				UnityEngine.Object.DontDestroyOnLoad(_target);
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

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00077F14 File Offset: 0x00076114
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindFirstObjectByType_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<Type>(L, 1);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 1, typeof(Type));
					UnityEngine.Object gen_ret = UnityEngine.Object.FindFirstObjectByType(_type);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Type>(L, 1) && translator.Assignable<FindObjectsInactive>(L, 2);
				if (flag2)
				{
					Type _type2 = (Type)translator.GetObject(L, 1, typeof(Type));
					FindObjectsInactive _findObjectsInactive;
					translator.Get<FindObjectsInactive>(L, 2, out _findObjectsInactive);
					UnityEngine.Object gen_ret2 = UnityEngine.Object.FindFirstObjectByType(_type2, _findObjectsInactive);
					translator.Push(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Object.FindFirstObjectByType!");
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00078024 File Offset: 0x00076224
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindAnyObjectByType_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && translator.Assignable<Type>(L, 1);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 1, typeof(Type));
					UnityEngine.Object gen_ret = UnityEngine.Object.FindAnyObjectByType(_type);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Type>(L, 1) && translator.Assignable<FindObjectsInactive>(L, 2);
				if (flag2)
				{
					Type _type2 = (Type)translator.GetObject(L, 1, typeof(Type));
					FindObjectsInactive _findObjectsInactive;
					translator.Get<FindObjectsInactive>(L, 2, out _findObjectsInactive);
					UnityEngine.Object gen_ret2 = UnityEngine.Object.FindAnyObjectByType(_type2, _findObjectsInactive);
					translator.Push(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Object.FindAnyObjectByType!");
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00078134 File Offset: 0x00076334
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToString(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
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

		// Token: 0x06000EC4 RID: 3780 RVA: 0x000781A8 File Offset: 0x000763A8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_name(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.name);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00078218 File Offset: 0x00076418
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_hideFlags(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.hideFlags);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00078290 File Offset: 0x00076490
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_name(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.name = Lua.lua_tostring(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00078304 File Offset: 0x00076504
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_hideFlags(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				UnityEngine.Object gen_to_be_invoked = (UnityEngine.Object)translator.FastGetCSObj(L, 1);
				HideFlags gen_value;
				translator.Get<HideFlags>(L, 2, out gen_value);
				gen_to_be_invoked.hideFlags = gen_value;
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

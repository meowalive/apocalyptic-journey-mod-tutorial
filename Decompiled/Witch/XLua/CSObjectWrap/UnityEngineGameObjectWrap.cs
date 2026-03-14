using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B5 RID: 437
	public class UnityEngineGameObjectWrap
	{
		// Token: 0x06000E4B RID: 3659 RVA: 0x000719DC File Offset: 0x0006FBDC
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(GameObject);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 9, 3, -1);
			Utils.RegisterFunc(L, -3, "GetComponent", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponent));
			Utils.RegisterFunc(L, -3, "GetComponentInChildren", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponentInChildren));
			Utils.RegisterFunc(L, -3, "GetComponentInParent", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponentInParent));
			Utils.RegisterFunc(L, -3, "GetComponents", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponents));
			Utils.RegisterFunc(L, -3, "GetComponentsInChildren", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponentsInChildren));
			Utils.RegisterFunc(L, -3, "GetComponentsInParent", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponentsInParent));
			Utils.RegisterFunc(L, -3, "TryGetComponent", new lua_CSFunction(UnityEngineGameObjectWrap._m_TryGetComponent));
			Utils.RegisterFunc(L, -3, "SendMessageUpwards", new lua_CSFunction(UnityEngineGameObjectWrap._m_SendMessageUpwards));
			Utils.RegisterFunc(L, -3, "SendMessage", new lua_CSFunction(UnityEngineGameObjectWrap._m_SendMessage));
			Utils.RegisterFunc(L, -3, "BroadcastMessage", new lua_CSFunction(UnityEngineGameObjectWrap._m_BroadcastMessage));
			Utils.RegisterFunc(L, -3, "AddComponent", new lua_CSFunction(UnityEngineGameObjectWrap._m_AddComponent));
			Utils.RegisterFunc(L, -3, "GetComponentCount", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponentCount));
			Utils.RegisterFunc(L, -3, "GetComponentAtIndex", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponentAtIndex));
			Utils.RegisterFunc(L, -3, "GetComponentIndex", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetComponentIndex));
			Utils.RegisterFunc(L, -3, "SetActive", new lua_CSFunction(UnityEngineGameObjectWrap._m_SetActive));
			Utils.RegisterFunc(L, -3, "CompareTag", new lua_CSFunction(UnityEngineGameObjectWrap._m_CompareTag));
			Utils.RegisterFunc(L, -2, "transform", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_transform));
			Utils.RegisterFunc(L, -2, "layer", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_layer));
			Utils.RegisterFunc(L, -2, "activeSelf", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_activeSelf));
			Utils.RegisterFunc(L, -2, "activeInHierarchy", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_activeInHierarchy));
			Utils.RegisterFunc(L, -2, "isStatic", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_isStatic));
			Utils.RegisterFunc(L, -2, "tag", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_tag));
			Utils.RegisterFunc(L, -2, "scene", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_scene));
			Utils.RegisterFunc(L, -2, "sceneCullingMask", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_sceneCullingMask));
			Utils.RegisterFunc(L, -2, "gameObject", new lua_CSFunction(UnityEngineGameObjectWrap._g_get_gameObject));
			Utils.RegisterFunc(L, -1, "layer", new lua_CSFunction(UnityEngineGameObjectWrap._s_set_layer));
			Utils.RegisterFunc(L, -1, "isStatic", new lua_CSFunction(UnityEngineGameObjectWrap._s_set_isStatic));
			Utils.RegisterFunc(L, -1, "tag", new lua_CSFunction(UnityEngineGameObjectWrap._s_set_tag));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineGameObjectWrap.__CreateInstance), 9, 0, 0);
			Utils.RegisterFunc(L, -4, "CreatePrimitive", new lua_CSFunction(UnityEngineGameObjectWrap._m_CreatePrimitive_xlua_st_));
			Utils.RegisterFunc(L, -4, "FindWithTag", new lua_CSFunction(UnityEngineGameObjectWrap._m_FindWithTag_xlua_st_));
			Utils.RegisterFunc(L, -4, "FindGameObjectsWithTag", new lua_CSFunction(UnityEngineGameObjectWrap._m_FindGameObjectsWithTag_xlua_st_));
			Utils.RegisterFunc(L, -4, "FindGameObjectWithTag", new lua_CSFunction(UnityEngineGameObjectWrap._m_FindGameObjectWithTag_xlua_st_));
			Utils.RegisterFunc(L, -4, "Find", new lua_CSFunction(UnityEngineGameObjectWrap._m_Find_xlua_st_));
			Utils.RegisterFunc(L, -4, "SetGameObjectsActive", new lua_CSFunction(UnityEngineGameObjectWrap._m_SetGameObjectsActive_xlua_st_));
			Utils.RegisterFunc(L, -4, "InstantiateGameObjects", new lua_CSFunction(UnityEngineGameObjectWrap._m_InstantiateGameObjects_xlua_st_));
			Utils.RegisterFunc(L, -4, "GetScene", new lua_CSFunction(UnityEngineGameObjectWrap._m_GetScene_xlua_st_));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00071DE8 File Offset: 0x0006FFE8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _name = Lua.lua_tostring(L, 2);
					GameObject gen_ret = new GameObject(_name);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 1;
				if (flag2)
				{
					GameObject gen_ret2 = new GameObject();
					translator.Push(L, gen_ret2);
					return 1;
				}
				bool flag3 = Lua.lua_gettop(L) >= 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 3) || translator.Assignable<Type>(L, 3));
				if (flag3)
				{
					string _name2 = Lua.lua_tostring(L, 2);
					Type[] _components = translator.GetParams<Type>(L, 3);
					GameObject gen_ret3 = new GameObject(_name2, _components);
					translator.Push(L, gen_ret3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject constructor!");
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00071F24 File Offset: 0x00070124
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CreatePrimitive_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				PrimitiveType _type;
				translator.Get<PrimitiveType>(L, 1, out _type);
				GameObject gen_ret = GameObject.CreatePrimitive(_type);
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

		// Token: 0x06000E4E RID: 3662 RVA: 0x00071F94 File Offset: 0x00070194
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 2, typeof(Type));
					Component gen_ret = gen_to_be_invoked.GetComponent(_type);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _type2 = Lua.lua_tostring(L, 2);
					Component gen_ret2 = gen_to_be_invoked.GetComponent(_type2);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponent!");
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0007209C File Offset: 0x0007029C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentInChildren(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 2, typeof(Type));
					Component gen_ret = gen_to_be_invoked.GetComponentInChildren(_type);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Type _type2 = (Type)translator.GetObject(L, 2, typeof(Type));
					bool _includeInactive = Lua.lua_toboolean(L, 3);
					Component gen_ret2 = gen_to_be_invoked.GetComponentInChildren(_type2, _includeInactive);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentInChildren!");
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x000721C0 File Offset: 0x000703C0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentInParent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 2, typeof(Type));
					Component gen_ret = gen_to_be_invoked.GetComponentInParent(_type);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Type _type2 = (Type)translator.GetObject(L, 2, typeof(Type));
					bool _includeInactive = Lua.lua_toboolean(L, 3);
					Component gen_ret2 = gen_to_be_invoked.GetComponentInParent(_type2, _includeInactive);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentInParent!");
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000722E4 File Offset: 0x000704E4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponents(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 2, typeof(Type));
					Component[] gen_ret = gen_to_be_invoked.GetComponents(_type);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && translator.Assignable<List<Component>>(L, 3);
				if (flag2)
				{
					Type _type2 = (Type)translator.GetObject(L, 2, typeof(Type));
					List<Component> _results = (List<Component>)translator.GetObject(L, 3, typeof(List<Component>));
					gen_to_be_invoked.GetComponents(_type2, _results);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponents!");
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00072408 File Offset: 0x00070608
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentsInChildren(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 2, typeof(Type));
					Component[] gen_ret = gen_to_be_invoked.GetComponentsInChildren(_type);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Type _type2 = (Type)translator.GetObject(L, 2, typeof(Type));
					bool _includeInactive = Lua.lua_toboolean(L, 3);
					Component[] gen_ret2 = gen_to_be_invoked.GetComponentsInChildren(_type2, _includeInactive);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentsInChildren!");
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0007252C File Offset: 0x0007072C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentsInParent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _type = (Type)translator.GetObject(L, 2, typeof(Type));
					Component[] gen_ret = gen_to_be_invoked.GetComponentsInParent(_type);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Type _type2 = (Type)translator.GetObject(L, 2, typeof(Type));
					bool _includeInactive = Lua.lua_toboolean(L, 3);
					Component[] gen_ret2 = gen_to_be_invoked.GetComponentsInParent(_type2, _includeInactive);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentsInParent!");
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00072650 File Offset: 0x00070850
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetComponent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Type _type = (Type)translator.GetObject(L, 2, typeof(Type));
				Component _component;
				bool gen_ret = gen_to_be_invoked.TryGetComponent(_type, out _component);
				Lua.lua_pushboolean(L, gen_ret);
				translator.Push(L, _component);
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

		// Token: 0x06000E55 RID: 3669 RVA: 0x000726EC File Offset: 0x000708EC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindWithTag_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				string _tag = Lua.lua_tostring(L, 1);
				GameObject gen_ret = GameObject.FindWithTag(_tag);
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

		// Token: 0x06000E56 RID: 3670 RVA: 0x0007275C File Offset: 0x0007095C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindGameObjectsWithTag_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && (Lua.lua_isnil(L, 1) || Lua.lua_type(L, 1) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _tag = Lua.lua_tostring(L, 1);
					GameObject[] gen_ret = GameObject.FindGameObjectsWithTag(_tag);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 1) || Lua.lua_type(L, 1) == LuaTypes.LUA_TSTRING) && translator.Assignable<List<GameObject>>(L, 2);
				if (flag2)
				{
					string _tag2 = Lua.lua_tostring(L, 1);
					List<GameObject> _results = (List<GameObject>)translator.GetObject(L, 2, typeof(List<GameObject>));
					GameObject.FindGameObjectsWithTag(_tag2, _results);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.FindGameObjectsWithTag!");
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00072868 File Offset: 0x00070A68
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SendMessageUpwards(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.SendMessageUpwards(_methodName);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<SendMessageOptions>(L, 3);
				if (flag2)
				{
					string _methodName2 = Lua.lua_tostring(L, 2);
					SendMessageOptions _options;
					translator.Get<SendMessageOptions>(L, 3, out _options);
					gen_to_be_invoked.SendMessageUpwards(_methodName2, _options);
					return 0;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3);
				if (flag3)
				{
					string _methodName3 = Lua.lua_tostring(L, 2);
					object _value = translator.GetObject(L, 3, typeof(object));
					gen_to_be_invoked.SendMessageUpwards(_methodName3, _value);
					return 0;
				}
				bool flag4 = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3) && translator.Assignable<SendMessageOptions>(L, 4);
				if (flag4)
				{
					string _methodName4 = Lua.lua_tostring(L, 2);
					object _value2 = translator.GetObject(L, 3, typeof(object));
					SendMessageOptions _options2;
					translator.Get<SendMessageOptions>(L, 4, out _options2);
					gen_to_be_invoked.SendMessageUpwards(_methodName4, _value2, _options2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.SendMessageUpwards!");
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00072A40 File Offset: 0x00070C40
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SendMessage(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.SendMessage(_methodName);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<SendMessageOptions>(L, 3);
				if (flag2)
				{
					string _methodName2 = Lua.lua_tostring(L, 2);
					SendMessageOptions _options;
					translator.Get<SendMessageOptions>(L, 3, out _options);
					gen_to_be_invoked.SendMessage(_methodName2, _options);
					return 0;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3);
				if (flag3)
				{
					string _methodName3 = Lua.lua_tostring(L, 2);
					object _value = translator.GetObject(L, 3, typeof(object));
					gen_to_be_invoked.SendMessage(_methodName3, _value);
					return 0;
				}
				bool flag4 = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3) && translator.Assignable<SendMessageOptions>(L, 4);
				if (flag4)
				{
					string _methodName4 = Lua.lua_tostring(L, 2);
					object _value2 = translator.GetObject(L, 3, typeof(object));
					SendMessageOptions _options2;
					translator.Get<SendMessageOptions>(L, 4, out _options2);
					gen_to_be_invoked.SendMessage(_methodName4, _value2, _options2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.SendMessage!");
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00072C18 File Offset: 0x00070E18
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_BroadcastMessage(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.BroadcastMessage(_methodName);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<SendMessageOptions>(L, 3);
				if (flag2)
				{
					string _methodName2 = Lua.lua_tostring(L, 2);
					SendMessageOptions _options;
					translator.Get<SendMessageOptions>(L, 3, out _options);
					gen_to_be_invoked.BroadcastMessage(_methodName2, _options);
					return 0;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3);
				if (flag3)
				{
					string _methodName3 = Lua.lua_tostring(L, 2);
					object _parameter = translator.GetObject(L, 3, typeof(object));
					gen_to_be_invoked.BroadcastMessage(_methodName3, _parameter);
					return 0;
				}
				bool flag4 = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3) && translator.Assignable<SendMessageOptions>(L, 4);
				if (flag4)
				{
					string _methodName4 = Lua.lua_tostring(L, 2);
					object _parameter2 = translator.GetObject(L, 3, typeof(object));
					SendMessageOptions _options2;
					translator.Get<SendMessageOptions>(L, 4, out _options2);
					gen_to_be_invoked.BroadcastMessage(_methodName4, _parameter2, _options2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.BroadcastMessage!");
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00072DF0 File Offset: 0x00070FF0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddComponent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Type _componentType = (Type)translator.GetObject(L, 2, typeof(Type));
				Component gen_ret = gen_to_be_invoked.AddComponent(_componentType);
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

		// Token: 0x06000E5B RID: 3675 RVA: 0x00072E80 File Offset: 0x00071080
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentCount(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_ret = gen_to_be_invoked.GetComponentCount();
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

		// Token: 0x06000E5C RID: 3676 RVA: 0x00072EF4 File Offset: 0x000710F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentAtIndex(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int _index = Lua.xlua_tointeger(L, 2);
				Component gen_ret = gen_to_be_invoked.GetComponentAtIndex(_index);
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

		// Token: 0x06000E5D RID: 3677 RVA: 0x00072F74 File Offset: 0x00071174
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentIndex(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Component _component = (Component)translator.GetObject(L, 2, typeof(Component));
				int gen_ret = gen_to_be_invoked.GetComponentIndex(_component);
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

		// Token: 0x06000E5E RID: 3678 RVA: 0x00073004 File Offset: 0x00071204
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetActive(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				bool _value = Lua.lua_toboolean(L, 2);
				gen_to_be_invoked.SetActive(_value);
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

		// Token: 0x06000E5F RID: 3679 RVA: 0x00073078 File Offset: 0x00071278
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CompareTag(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _tag = Lua.lua_tostring(L, 2);
					bool gen_ret = gen_to_be_invoked.CompareTag(_tag);
					Lua.lua_pushboolean(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<TagHandle>(L, 2);
				if (flag2)
				{
					TagHandle _tag2;
					translator.Get<TagHandle>(L, 2, out _tag2);
					bool gen_ret2 = gen_to_be_invoked.CompareTag(_tag2);
					Lua.lua_pushboolean(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.CompareTag!");
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00073170 File Offset: 0x00071370
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindGameObjectWithTag_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				string _tag = Lua.lua_tostring(L, 1);
				GameObject gen_ret = GameObject.FindGameObjectWithTag(_tag);
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

		// Token: 0x06000E61 RID: 3681 RVA: 0x000731E0 File Offset: 0x000713E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Find_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				string _name = Lua.lua_tostring(L, 1);
				GameObject gen_ret = GameObject.Find(_name);
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

		// Token: 0x06000E62 RID: 3682 RVA: 0x00073250 File Offset: 0x00071450
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetGameObjectsActive_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				NativeArray<int> _instanceIDs;
				translator.Get<NativeArray<int>>(L, 1, out _instanceIDs);
				bool _active = Lua.lua_toboolean(L, 2);
				GameObject.SetGameObjectsActive(_instanceIDs, _active);
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

		// Token: 0x06000E63 RID: 3683 RVA: 0x000732C0 File Offset: 0x000714C0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InstantiateGameObjects_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<NativeArray<int>>(L, 3) && translator.Assignable<NativeArray<int>>(L, 4) && translator.Assignable<Scene>(L, 5);
				if (flag)
				{
					int _sourceInstanceID = Lua.xlua_tointeger(L, 1);
					int _count = Lua.xlua_tointeger(L, 2);
					NativeArray<int> _newInstanceIDs;
					translator.Get<NativeArray<int>>(L, 3, out _newInstanceIDs);
					NativeArray<int> _newTransformInstanceIDs;
					translator.Get<NativeArray<int>>(L, 4, out _newTransformInstanceIDs);
					Scene _destinationScene;
					translator.Get<Scene>(L, 5, out _destinationScene);
					GameObject.InstantiateGameObjects(_sourceInstanceID, _count, _newInstanceIDs, _newTransformInstanceIDs, _destinationScene);
					return 0;
				}
				bool flag2 = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<NativeArray<int>>(L, 3) && translator.Assignable<NativeArray<int>>(L, 4);
				if (flag2)
				{
					int _sourceInstanceID2 = Lua.xlua_tointeger(L, 1);
					int _count2 = Lua.xlua_tointeger(L, 2);
					NativeArray<int> _newInstanceIDs2;
					translator.Get<NativeArray<int>>(L, 3, out _newInstanceIDs2);
					NativeArray<int> _newTransformInstanceIDs2;
					translator.Get<NativeArray<int>>(L, 4, out _newTransformInstanceIDs2);
					GameObject.InstantiateGameObjects(_sourceInstanceID2, _count2, _newInstanceIDs2, _newTransformInstanceIDs2, default(Scene));
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.GameObject.InstantiateGameObjects!");
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00073438 File Offset: 0x00071638
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetScene_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int _instanceID = Lua.xlua_tointeger(L, 1);
				Scene gen_ret = GameObject.GetScene(_instanceID);
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

		// Token: 0x06000E65 RID: 3685 RVA: 0x000734AC File Offset: 0x000716AC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_transform(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.transform);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00073520 File Offset: 0x00071720
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_layer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.layer);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00073590 File Offset: 0x00071790
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_activeSelf(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.activeSelf);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00073600 File Offset: 0x00071800
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_activeInHierarchy(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.activeInHierarchy);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00073670 File Offset: 0x00071870
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_isStatic(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.isStatic);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000736E0 File Offset: 0x000718E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_tag(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.tag);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00073750 File Offset: 0x00071950
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_scene(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.scene);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000737C8 File Offset: 0x000719C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_sceneCullingMask(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				Lua.lua_pushuint64(L, gen_to_be_invoked.sceneCullingMask);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00073838 File Offset: 0x00071A38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_gameObject(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.gameObject);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x000738AC File Offset: 0x00071AAC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_layer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.layer = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00073920 File Offset: 0x00071B20
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_isStatic(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.isStatic = Lua.lua_toboolean(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00073994 File Offset: 0x00071B94
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_tag(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				GameObject gen_to_be_invoked = (GameObject)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.tag = Lua.lua_tostring(L, 2);
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

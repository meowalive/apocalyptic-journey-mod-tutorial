using System;
using System.Collections.Generic;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B3 RID: 435
	public class UnityEngineComponentWrap
	{
		// Token: 0x06000E1C RID: 3612 RVA: 0x0006EC8C File Offset: 0x0006CE8C
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Component);
			Utils.BeginObjectRegister(type, L, translator, 0, 12, 3, 1, -1);
			Utils.RegisterFunc(L, -3, "GetComponent", new lua_CSFunction(UnityEngineComponentWrap._m_GetComponent));
			Utils.RegisterFunc(L, -3, "TryGetComponent", new lua_CSFunction(UnityEngineComponentWrap._m_TryGetComponent));
			Utils.RegisterFunc(L, -3, "GetComponentInChildren", new lua_CSFunction(UnityEngineComponentWrap._m_GetComponentInChildren));
			Utils.RegisterFunc(L, -3, "GetComponentsInChildren", new lua_CSFunction(UnityEngineComponentWrap._m_GetComponentsInChildren));
			Utils.RegisterFunc(L, -3, "GetComponentInParent", new lua_CSFunction(UnityEngineComponentWrap._m_GetComponentInParent));
			Utils.RegisterFunc(L, -3, "GetComponentsInParent", new lua_CSFunction(UnityEngineComponentWrap._m_GetComponentsInParent));
			Utils.RegisterFunc(L, -3, "GetComponents", new lua_CSFunction(UnityEngineComponentWrap._m_GetComponents));
			Utils.RegisterFunc(L, -3, "GetComponentIndex", new lua_CSFunction(UnityEngineComponentWrap._m_GetComponentIndex));
			Utils.RegisterFunc(L, -3, "CompareTag", new lua_CSFunction(UnityEngineComponentWrap._m_CompareTag));
			Utils.RegisterFunc(L, -3, "SendMessageUpwards", new lua_CSFunction(UnityEngineComponentWrap._m_SendMessageUpwards));
			Utils.RegisterFunc(L, -3, "SendMessage", new lua_CSFunction(UnityEngineComponentWrap._m_SendMessage));
			Utils.RegisterFunc(L, -3, "BroadcastMessage", new lua_CSFunction(UnityEngineComponentWrap._m_BroadcastMessage));
			Utils.RegisterFunc(L, -2, "transform", new lua_CSFunction(UnityEngineComponentWrap._g_get_transform));
			Utils.RegisterFunc(L, -2, "gameObject", new lua_CSFunction(UnityEngineComponentWrap._g_get_gameObject));
			Utils.RegisterFunc(L, -2, "tag", new lua_CSFunction(UnityEngineComponentWrap._g_get_tag));
			Utils.RegisterFunc(L, -1, "tag", new lua_CSFunction(UnityEngineComponentWrap._s_set_tag));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineComponentWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0006EE90 File Offset: 0x0006D090
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					Component gen_ret = new Component();
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component constructor!");
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0006EF14 File Offset: 0x0006D114
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponent!");
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0006F01C File Offset: 0x0006D21C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetComponent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
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

		// Token: 0x06000E20 RID: 3616 RVA: 0x0006F0B8 File Offset: 0x0006D2B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentInChildren(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _t = (Type)translator.GetObject(L, 2, typeof(Type));
					Component gen_ret = gen_to_be_invoked.GetComponentInChildren(_t);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Type _t2 = (Type)translator.GetObject(L, 2, typeof(Type));
					bool _includeInactive = Lua.lua_toboolean(L, 3);
					Component gen_ret2 = gen_to_be_invoked.GetComponentInChildren(_t2, _includeInactive);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentInChildren!");
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0006F1DC File Offset: 0x0006D3DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentsInChildren(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _t = (Type)translator.GetObject(L, 2, typeof(Type));
					Component[] gen_ret = gen_to_be_invoked.GetComponentsInChildren(_t);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Type _t2 = (Type)translator.GetObject(L, 2, typeof(Type));
					bool _includeInactive = Lua.lua_toboolean(L, 3);
					Component[] gen_ret2 = gen_to_be_invoked.GetComponentsInChildren(_t2, _includeInactive);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentsInChildren!");
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0006F300 File Offset: 0x0006D500
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentInParent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _t = (Type)translator.GetObject(L, 2, typeof(Type));
					Component gen_ret = gen_to_be_invoked.GetComponentInParent(_t);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Type _t2 = (Type)translator.GetObject(L, 2, typeof(Type));
					bool _includeInactive = Lua.lua_toboolean(L, 3);
					Component gen_ret2 = gen_to_be_invoked.GetComponentInParent(_t2, _includeInactive);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentInParent!");
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0006F424 File Offset: 0x0006D624
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentsInParent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Type>(L, 2);
				if (flag)
				{
					Type _t = (Type)translator.GetObject(L, 2, typeof(Type));
					Component[] gen_ret = gen_to_be_invoked.GetComponentsInParent(_t);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Type>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Type _t2 = (Type)translator.GetObject(L, 2, typeof(Type));
					bool _includeInactive = Lua.lua_toboolean(L, 3);
					Component[] gen_ret2 = gen_to_be_invoked.GetComponentsInParent(_t2, _includeInactive);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponentsInParent!");
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0006F548 File Offset: 0x0006D748
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponents(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.GetComponents!");
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0006F66C File Offset: 0x0006D86C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetComponentIndex(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
				int gen_ret = gen_to_be_invoked.GetComponentIndex();
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

		// Token: 0x06000E26 RID: 3622 RVA: 0x0006F6E0 File Offset: 0x0006D8E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CompareTag(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.CompareTag!");
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0006F7D8 File Offset: 0x0006D9D8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SendMessageUpwards(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.SendMessageUpwards(_methodName);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3);
				if (flag2)
				{
					string _methodName2 = Lua.lua_tostring(L, 2);
					object _value = translator.GetObject(L, 3, typeof(object));
					gen_to_be_invoked.SendMessageUpwards(_methodName2, _value);
					return 0;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<SendMessageOptions>(L, 3);
				if (flag3)
				{
					string _methodName3 = Lua.lua_tostring(L, 2);
					SendMessageOptions _options;
					translator.Get<SendMessageOptions>(L, 3, out _options);
					gen_to_be_invoked.SendMessageUpwards(_methodName3, _options);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.SendMessageUpwards!");
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0006F9B0 File Offset: 0x0006DBB0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SendMessage(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.SendMessage(_methodName);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3);
				if (flag2)
				{
					string _methodName2 = Lua.lua_tostring(L, 2);
					object _value = translator.GetObject(L, 3, typeof(object));
					gen_to_be_invoked.SendMessage(_methodName2, _value);
					return 0;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<SendMessageOptions>(L, 3);
				if (flag3)
				{
					string _methodName3 = Lua.lua_tostring(L, 2);
					SendMessageOptions _options;
					translator.Get<SendMessageOptions>(L, 3, out _options);
					gen_to_be_invoked.SendMessage(_methodName3, _options);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.SendMessage!");
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0006FB88 File Offset: 0x0006DD88
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_BroadcastMessage(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.BroadcastMessage(_methodName);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3);
				if (flag2)
				{
					string _methodName2 = Lua.lua_tostring(L, 2);
					object _parameter = translator.GetObject(L, 3, typeof(object));
					gen_to_be_invoked.BroadcastMessage(_methodName2, _parameter);
					return 0;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<SendMessageOptions>(L, 3);
				if (flag3)
				{
					string _methodName3 = Lua.lua_tostring(L, 2);
					SendMessageOptions _options;
					translator.Get<SendMessageOptions>(L, 3, out _options);
					gen_to_be_invoked.BroadcastMessage(_methodName3, _options);
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Component.BroadcastMessage!");
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0006FD60 File Offset: 0x0006DF60
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_transform(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
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

		// Token: 0x06000E2B RID: 3627 RVA: 0x0006FDD4 File Offset: 0x0006DFD4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_gameObject(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
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

		// Token: 0x06000E2C RID: 3628 RVA: 0x0006FE48 File Offset: 0x0006E048
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_tag(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
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

		// Token: 0x06000E2D RID: 3629 RVA: 0x0006FEB8 File Offset: 0x0006E0B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_tag(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Component gen_to_be_invoked = (Component)translator.FastGetCSObj(L, 1);
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

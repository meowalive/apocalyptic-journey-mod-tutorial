using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001A8 RID: 424
	public class SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x000689CC File Offset: 0x00066BCC
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Dictionary<string, string>);
			Utils.BeginObjectRegister(type, L, translator, 0, 13, 4, 0, -1);
			Utils.RegisterFunc(L, -3, "get_Item", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_get_Item));
			Utils.RegisterFunc(L, -3, "set_Item", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_set_Item));
			Utils.RegisterFunc(L, -3, "Add", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_Add));
			Utils.RegisterFunc(L, -3, "Clear", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_Clear));
			Utils.RegisterFunc(L, -3, "ContainsKey", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_ContainsKey));
			Utils.RegisterFunc(L, -3, "ContainsValue", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_ContainsValue));
			Utils.RegisterFunc(L, -3, "GetEnumerator", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_GetEnumerator));
			Utils.RegisterFunc(L, -3, "GetObjectData", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_GetObjectData));
			Utils.RegisterFunc(L, -3, "OnDeserialization", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_OnDeserialization));
			Utils.RegisterFunc(L, -3, "Remove", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_Remove));
			Utils.RegisterFunc(L, -3, "TryGetValue", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_TryGetValue));
			Utils.RegisterFunc(L, -3, "EnsureCapacity", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_EnsureCapacity));
			Utils.RegisterFunc(L, -3, "TrimExcess", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._m_TrimExcess));
			Utils.RegisterFunc(L, -2, "Comparer", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._g_get_Comparer));
			Utils.RegisterFunc(L, -2, "Count", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._g_get_Count));
			Utils.RegisterFunc(L, -2, "Keys", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._g_get_Keys));
			Utils.RegisterFunc(L, -2, "Values", new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap._g_get_Values));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00068BE8 File Offset: 0x00066DE8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					Dictionary<string, string> gen_ret = new Dictionary<string, string>();
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					int _capacity = Lua.xlua_tointeger(L, 2);
					Dictionary<string, string> gen_ret2 = new Dictionary<string, string>(_capacity);
					translator.Push(L, gen_ret2);
					return 1;
				}
				bool flag3 = Lua.lua_gettop(L) == 2 && translator.Assignable<IEqualityComparer<string>>(L, 2);
				if (flag3)
				{
					IEqualityComparer<string> _comparer = (IEqualityComparer<string>)translator.GetObject(L, 2, typeof(IEqualityComparer<string>));
					Dictionary<string, string> gen_ret3 = new Dictionary<string, string>(_comparer);
					translator.Push(L, gen_ret3);
					return 1;
				}
				bool flag4 = Lua.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<IEqualityComparer<string>>(L, 3);
				if (flag4)
				{
					int _capacity2 = Lua.xlua_tointeger(L, 2);
					IEqualityComparer<string> _comparer2 = (IEqualityComparer<string>)translator.GetObject(L, 3, typeof(IEqualityComparer<string>));
					Dictionary<string, string> gen_ret4 = new Dictionary<string, string>(_capacity2, _comparer2);
					translator.Push(L, gen_ret4);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.Dictionary<string, string> constructor!");
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00068D68 File Offset: 0x00066F68
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_get_Item(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				string key = Lua.lua_tostring(L, 2);
				Lua.lua_pushstring(L, gen_to_be_invoked[key]);
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

		// Token: 0x06000D7E RID: 3454 RVA: 0x00068DE4 File Offset: 0x00066FE4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_set_Item(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				string key = Lua.lua_tostring(L, 2);
				string gen_value = Lua.lua_tostring(L, 3);
				gen_to_be_invoked[key] = gen_value;
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

		// Token: 0x06000D7F RID: 3455 RVA: 0x00068E64 File Offset: 0x00067064
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Add(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				string _key = Lua.lua_tostring(L, 2);
				string _value = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.Add(_key, _value);
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

		// Token: 0x06000D80 RID: 3456 RVA: 0x00068EE4 File Offset: 0x000670E4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Clear(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Clear();
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

		// Token: 0x06000D81 RID: 3457 RVA: 0x00068F4C File Offset: 0x0006714C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ContainsKey(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				string _key = Lua.lua_tostring(L, 2);
				bool gen_ret = gen_to_be_invoked.ContainsKey(_key);
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

		// Token: 0x06000D82 RID: 3458 RVA: 0x00068FCC File Offset: 0x000671CC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ContainsValue(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				string _value = Lua.lua_tostring(L, 2);
				bool gen_ret = gen_to_be_invoked.ContainsValue(_value);
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

		// Token: 0x06000D83 RID: 3459 RVA: 0x0006904C File Offset: 0x0006724C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetEnumerator(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				Dictionary<string, string>.Enumerator gen_ret = gen_to_be_invoked.GetEnumerator();
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

		// Token: 0x06000D84 RID: 3460 RVA: 0x000690C4 File Offset: 0x000672C4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetObjectData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				SerializationInfo _info = (SerializationInfo)translator.GetObject(L, 2, typeof(SerializationInfo));
				StreamingContext _context;
				translator.Get<StreamingContext>(L, 3, out _context);
				gen_to_be_invoked.GetObjectData(_info, _context);
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

		// Token: 0x06000D85 RID: 3461 RVA: 0x00069158 File Offset: 0x00067358
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnDeserialization(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				object _sender = translator.GetObject(L, 2, typeof(object));
				gen_to_be_invoked.OnDeserialization(_sender);
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

		// Token: 0x06000D86 RID: 3462 RVA: 0x000691D8 File Offset: 0x000673D8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Remove(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				string _key = Lua.lua_tostring(L, 2);
				bool gen_ret = gen_to_be_invoked.Remove(_key);
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

		// Token: 0x06000D87 RID: 3463 RVA: 0x00069258 File Offset: 0x00067458
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetValue(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				string _key = Lua.lua_tostring(L, 2);
				string _value;
				bool gen_ret = gen_to_be_invoked.TryGetValue(_key, out _value);
				Lua.lua_pushboolean(L, gen_ret);
				Lua.lua_pushstring(L, _value);
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

		// Token: 0x06000D88 RID: 3464 RVA: 0x000692E4 File Offset: 0x000674E4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_EnsureCapacity(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				int _capacity = Lua.xlua_tointeger(L, 2);
				int gen_ret = gen_to_be_invoked.EnsureCapacity(_capacity);
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

		// Token: 0x06000D89 RID: 3465 RVA: 0x00069364 File Offset: 0x00067564
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TrimExcess(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					gen_to_be_invoked.TrimExcess();
					return 0;
				}
				bool flag2 = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					int _capacity = Lua.xlua_tointeger(L, 2);
					gen_to_be_invoked.TrimExcess(_capacity);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.Dictionary<string, string>.TrimExcess!");
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00069424 File Offset: 0x00067624
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Comparer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				translator.PushAny(L, gen_to_be_invoked.Comparer);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00069498 File Offset: 0x00067698
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Count(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.Count);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00069508 File Offset: 0x00067708
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Keys(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.Keys);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0006957C File Offset: 0x0006777C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Values(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Dictionary<string, string> gen_to_be_invoked = (Dictionary<string, string>)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.Values);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}
	}
}

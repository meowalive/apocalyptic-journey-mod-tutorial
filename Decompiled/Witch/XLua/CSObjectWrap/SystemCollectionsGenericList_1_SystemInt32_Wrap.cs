using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001A9 RID: 425
	public class SystemCollectionsGenericList_1_SystemInt32_Wrap
	{
		// Token: 0x06000D8F RID: 3471 RVA: 0x000695F0 File Offset: 0x000677F0
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(List<int>);
			Utils.BeginObjectRegister(type, L, translator, 0, 29, 2, 1, -1);
			Utils.RegisterFunc(L, -3, "Add", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Add));
			Utils.RegisterFunc(L, -3, "AddRange", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_AddRange));
			Utils.RegisterFunc(L, -3, "AsReadOnly", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_AsReadOnly));
			Utils.RegisterFunc(L, -3, "BinarySearch", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_BinarySearch));
			Utils.RegisterFunc(L, -3, "Clear", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Clear));
			Utils.RegisterFunc(L, -3, "Contains", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Contains));
			Utils.RegisterFunc(L, -3, "CopyTo", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_CopyTo));
			Utils.RegisterFunc(L, -3, "Exists", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Exists));
			Utils.RegisterFunc(L, -3, "Find", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Find));
			Utils.RegisterFunc(L, -3, "FindAll", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_FindAll));
			Utils.RegisterFunc(L, -3, "FindIndex", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_FindIndex));
			Utils.RegisterFunc(L, -3, "FindLast", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_FindLast));
			Utils.RegisterFunc(L, -3, "FindLastIndex", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_FindLastIndex));
			Utils.RegisterFunc(L, -3, "ForEach", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_ForEach));
			Utils.RegisterFunc(L, -3, "GetEnumerator", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_GetEnumerator));
			Utils.RegisterFunc(L, -3, "GetRange", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_GetRange));
			Utils.RegisterFunc(L, -3, "IndexOf", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_IndexOf));
			Utils.RegisterFunc(L, -3, "Insert", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Insert));
			Utils.RegisterFunc(L, -3, "InsertRange", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_InsertRange));
			Utils.RegisterFunc(L, -3, "LastIndexOf", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_LastIndexOf));
			Utils.RegisterFunc(L, -3, "Remove", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Remove));
			Utils.RegisterFunc(L, -3, "RemoveAll", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_RemoveAll));
			Utils.RegisterFunc(L, -3, "RemoveAt", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_RemoveAt));
			Utils.RegisterFunc(L, -3, "RemoveRange", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_RemoveRange));
			Utils.RegisterFunc(L, -3, "Reverse", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Reverse));
			Utils.RegisterFunc(L, -3, "Sort", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_Sort));
			Utils.RegisterFunc(L, -3, "ToArray", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_ToArray));
			Utils.RegisterFunc(L, -3, "TrimExcess", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_TrimExcess));
			Utils.RegisterFunc(L, -3, "TrueForAll", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._m_TrueForAll));
			Utils.RegisterFunc(L, -2, "Capacity", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._g_get_Capacity));
			Utils.RegisterFunc(L, -2, "Count", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._g_get_Count));
			Utils.RegisterFunc(L, -1, "Capacity", new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap._s_set_Capacity));
			Utils.EndObjectRegister(type, L, translator, new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap.__CSIndexer), new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap.__NewIndexer), null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(SystemCollectionsGenericList_1_SystemInt32_Wrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000699A8 File Offset: 0x00067BA8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					List<int> gen_ret = new List<int>();
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = Lua.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					int _capacity = Lua.xlua_tointeger(L, 2);
					List<int> gen_ret2 = new List<int>(_capacity);
					translator.Push(L, gen_ret2);
					return 1;
				}
				bool flag3 = Lua.lua_gettop(L) == 2 && translator.Assignable<IEnumerable<int>>(L, 2);
				if (flag3)
				{
					IEnumerable<int> _collection = (IEnumerable<int>)translator.GetObject(L, 2, typeof(IEnumerable<int>));
					List<int> gen_ret3 = new List<int>(_collection);
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
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int> constructor!");
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00069AB8 File Offset: 0x00067CB8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __CSIndexer(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = translator.Assignable<List<int>>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
					int index = Lua.xlua_tointeger(L, 2);
					Lua.lua_pushboolean(L, true);
					Lua.xlua_pushinteger(L, gen_to_be_invoked[index]);
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

		// Token: 0x06000D92 RID: 3474 RVA: 0x00069B68 File Offset: 0x00067D68
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int __NewIndexer(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try
			{
				bool flag = translator.Assignable<List<int>>(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
					int key = Lua.xlua_tointeger(L, 2);
					gen_to_be_invoked[key] = Lua.xlua_tointeger(L, 3);
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

		// Token: 0x06000D93 RID: 3475 RVA: 0x00069C24 File Offset: 0x00067E24
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Add(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int _item = Lua.xlua_tointeger(L, 2);
				gen_to_be_invoked.Add(_item);
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

		// Token: 0x06000D94 RID: 3476 RVA: 0x00069C98 File Offset: 0x00067E98
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddRange(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				IEnumerable<int> _collection = (IEnumerable<int>)translator.GetObject(L, 2, typeof(IEnumerable<int>));
				gen_to_be_invoked.AddRange(_collection);
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

		// Token: 0x06000D95 RID: 3477 RVA: 0x00069D1C File Offset: 0x00067F1C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AsReadOnly(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				ReadOnlyCollection<int> gen_ret = gen_to_be_invoked.AsReadOnly();
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

		// Token: 0x06000D96 RID: 3478 RVA: 0x00069D90 File Offset: 0x00067F90
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_BinarySearch(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					int _item = Lua.xlua_tointeger(L, 2);
					int gen_ret = gen_to_be_invoked.BinarySearch(_item);
					Lua.xlua_pushinteger(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<IComparer<int>>(L, 3);
				if (flag2)
				{
					int _item2 = Lua.xlua_tointeger(L, 2);
					IComparer<int> _comparer = (IComparer<int>)translator.GetObject(L, 3, typeof(IComparer<int>));
					int gen_ret2 = gen_to_be_invoked.BinarySearch(_item2, _comparer);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && translator.Assignable<IComparer<int>>(L, 5);
				if (flag3)
				{
					int _index = Lua.xlua_tointeger(L, 2);
					int _count = Lua.xlua_tointeger(L, 3);
					int _item3 = Lua.xlua_tointeger(L, 4);
					IComparer<int> _comparer2 = (IComparer<int>)translator.GetObject(L, 5, typeof(IComparer<int>));
					int gen_ret3 = gen_to_be_invoked.BinarySearch(_index, _count, _item3, _comparer2);
					Lua.xlua_pushinteger(L, gen_ret3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.BinarySearch!");
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00069F34 File Offset: 0x00068134
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Clear(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
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

		// Token: 0x06000D98 RID: 3480 RVA: 0x00069F9C File Offset: 0x0006819C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Contains(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int _item = Lua.xlua_tointeger(L, 2);
				bool gen_ret = gen_to_be_invoked.Contains(_item);
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

		// Token: 0x06000D99 RID: 3481 RVA: 0x0006A01C File Offset: 0x0006821C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CopyTo(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<int[]>(L, 2);
				if (flag)
				{
					int[] _array = (int[])translator.GetObject(L, 2, typeof(int[]));
					gen_to_be_invoked.CopyTo(_array);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<int[]>(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag2)
				{
					int[] _array2 = (int[])translator.GetObject(L, 2, typeof(int[]));
					int _arrayIndex = Lua.xlua_tointeger(L, 3);
					gen_to_be_invoked.CopyTo(_array2, _arrayIndex);
					return 0;
				}
				bool flag3 = gen_param_count == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<int[]>(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5);
				if (flag3)
				{
					int _index = Lua.xlua_tointeger(L, 2);
					int[] _array3 = (int[])translator.GetObject(L, 3, typeof(int[]));
					int _arrayIndex2 = Lua.xlua_tointeger(L, 4);
					int _count = Lua.xlua_tointeger(L, 5);
					gen_to_be_invoked.CopyTo(_index, _array3, _arrayIndex2, _count);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.CopyTo!");
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0006A1B4 File Offset: 0x000683B4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Exists(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				Predicate<int> _match = translator.GetDelegate<Predicate<int>>(L, 2);
				bool gen_ret = gen_to_be_invoked.Exists(_match);
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

		// Token: 0x06000D9B RID: 3483 RVA: 0x0006A234 File Offset: 0x00068434
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Find(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				Predicate<int> _match = translator.GetDelegate<Predicate<int>>(L, 2);
				int gen_ret = gen_to_be_invoked.Find(_match);
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

		// Token: 0x06000D9C RID: 3484 RVA: 0x0006A2B4 File Offset: 0x000684B4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindAll(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				Predicate<int> _match = translator.GetDelegate<Predicate<int>>(L, 2);
				List<int> gen_ret = gen_to_be_invoked.FindAll(_match);
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

		// Token: 0x06000D9D RID: 3485 RVA: 0x0006A334 File Offset: 0x00068534
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindIndex(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Predicate<int>>(L, 2);
				if (flag)
				{
					Predicate<int> _match = translator.GetDelegate<Predicate<int>>(L, 2);
					int gen_ret = gen_to_be_invoked.FindIndex(_match);
					Lua.xlua_pushinteger(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<Predicate<int>>(L, 3);
				if (flag2)
				{
					int _startIndex = Lua.xlua_tointeger(L, 2);
					Predicate<int> _match2 = translator.GetDelegate<Predicate<int>>(L, 3);
					int gen_ret2 = gen_to_be_invoked.FindIndex(_startIndex, _match2);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && translator.Assignable<Predicate<int>>(L, 4);
				if (flag3)
				{
					int _startIndex2 = Lua.xlua_tointeger(L, 2);
					int _count = Lua.xlua_tointeger(L, 3);
					Predicate<int> _match3 = translator.GetDelegate<Predicate<int>>(L, 4);
					int gen_ret3 = gen_to_be_invoked.FindIndex(_startIndex2, _count, _match3);
					Lua.xlua_pushinteger(L, gen_ret3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.FindIndex!");
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0006A4A4 File Offset: 0x000686A4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindLast(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				Predicate<int> _match = translator.GetDelegate<Predicate<int>>(L, 2);
				int gen_ret = gen_to_be_invoked.FindLast(_match);
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

		// Token: 0x06000D9F RID: 3487 RVA: 0x0006A524 File Offset: 0x00068724
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FindLastIndex(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Predicate<int>>(L, 2);
				if (flag)
				{
					Predicate<int> _match = translator.GetDelegate<Predicate<int>>(L, 2);
					int gen_ret = gen_to_be_invoked.FindLastIndex(_match);
					Lua.xlua_pushinteger(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && translator.Assignable<Predicate<int>>(L, 3);
				if (flag2)
				{
					int _startIndex = Lua.xlua_tointeger(L, 2);
					Predicate<int> _match2 = translator.GetDelegate<Predicate<int>>(L, 3);
					int gen_ret2 = gen_to_be_invoked.FindLastIndex(_startIndex, _match2);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && translator.Assignable<Predicate<int>>(L, 4);
				if (flag3)
				{
					int _startIndex2 = Lua.xlua_tointeger(L, 2);
					int _count = Lua.xlua_tointeger(L, 3);
					Predicate<int> _match3 = translator.GetDelegate<Predicate<int>>(L, 4);
					int gen_ret3 = gen_to_be_invoked.FindLastIndex(_startIndex2, _count, _match3);
					Lua.xlua_pushinteger(L, gen_ret3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.FindLastIndex!");
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0006A694 File Offset: 0x00068894
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ForEach(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				Action<int> _action = translator.GetDelegate<Action<int>>(L, 2);
				gen_to_be_invoked.ForEach(_action);
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

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0006A708 File Offset: 0x00068908
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetEnumerator(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				List<int>.Enumerator gen_ret = gen_to_be_invoked.GetEnumerator();
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

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0006A780 File Offset: 0x00068980
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetRange(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int _index = Lua.xlua_tointeger(L, 2);
				int _count = Lua.xlua_tointeger(L, 3);
				List<int> gen_ret = gen_to_be_invoked.GetRange(_index, _count);
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

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0006A80C File Offset: 0x00068A0C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_IndexOf(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					int _item = Lua.xlua_tointeger(L, 2);
					int gen_ret = gen_to_be_invoked.IndexOf(_item);
					Lua.xlua_pushinteger(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag2)
				{
					int _item2 = Lua.xlua_tointeger(L, 2);
					int _index = Lua.xlua_tointeger(L, 3);
					int gen_ret2 = gen_to_be_invoked.IndexOf(_item2, _index);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag3)
				{
					int _item3 = Lua.xlua_tointeger(L, 2);
					int _index2 = Lua.xlua_tointeger(L, 3);
					int _count = Lua.xlua_tointeger(L, 4);
					int gen_ret3 = gen_to_be_invoked.IndexOf(_item3, _index2, _count);
					Lua.xlua_pushinteger(L, gen_ret3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.IndexOf!");
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0006A980 File Offset: 0x00068B80
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Insert(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int _index = Lua.xlua_tointeger(L, 2);
				int _item = Lua.xlua_tointeger(L, 3);
				gen_to_be_invoked.Insert(_index, _item);
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

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0006AA00 File Offset: 0x00068C00
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InsertRange(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int _index = Lua.xlua_tointeger(L, 2);
				IEnumerable<int> _collection = (IEnumerable<int>)translator.GetObject(L, 3, typeof(IEnumerable<int>));
				gen_to_be_invoked.InsertRange(_index, _collection);
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

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0006AA90 File Offset: 0x00068C90
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LastIndexOf(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					int _item = Lua.xlua_tointeger(L, 2);
					int gen_ret = gen_to_be_invoked.LastIndexOf(_item);
					Lua.xlua_pushinteger(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag2)
				{
					int _item2 = Lua.xlua_tointeger(L, 2);
					int _index = Lua.xlua_tointeger(L, 3);
					int gen_ret2 = gen_to_be_invoked.LastIndexOf(_item2, _index);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag3)
				{
					int _item3 = Lua.xlua_tointeger(L, 2);
					int _index2 = Lua.xlua_tointeger(L, 3);
					int _count = Lua.xlua_tointeger(L, 4);
					int gen_ret3 = gen_to_be_invoked.LastIndexOf(_item3, _index2, _count);
					Lua.xlua_pushinteger(L, gen_ret3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.LastIndexOf!");
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0006AC04 File Offset: 0x00068E04
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Remove(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int _item = Lua.xlua_tointeger(L, 2);
				bool gen_ret = gen_to_be_invoked.Remove(_item);
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

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0006AC84 File Offset: 0x00068E84
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveAll(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				Predicate<int> _match = translator.GetDelegate<Predicate<int>>(L, 2);
				int gen_ret = gen_to_be_invoked.RemoveAll(_match);
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

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0006AD04 File Offset: 0x00068F04
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveAt(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int _index = Lua.xlua_tointeger(L, 2);
				gen_to_be_invoked.RemoveAt(_index);
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

		// Token: 0x06000DAA RID: 3498 RVA: 0x0006AD78 File Offset: 0x00068F78
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveRange(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int _index = Lua.xlua_tointeger(L, 2);
				int _count = Lua.xlua_tointeger(L, 3);
				gen_to_be_invoked.RemoveRange(_index, _count);
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

		// Token: 0x06000DAB RID: 3499 RVA: 0x0006ADF8 File Offset: 0x00068FF8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Reverse(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					gen_to_be_invoked.Reverse();
					return 0;
				}
				bool flag2 = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag2)
				{
					int _index = Lua.xlua_tointeger(L, 2);
					int _count = Lua.xlua_tointeger(L, 3);
					gen_to_be_invoked.Reverse(_index, _count);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.Reverse!");
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0006AECC File Offset: 0x000690CC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Sort(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					gen_to_be_invoked.Sort();
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<IComparer<int>>(L, 2);
				if (flag2)
				{
					IComparer<int> _comparer = (IComparer<int>)translator.GetObject(L, 2, typeof(IComparer<int>));
					gen_to_be_invoked.Sort(_comparer);
					return 0;
				}
				bool flag3 = gen_param_count == 2 && translator.Assignable<Comparison<int>>(L, 2);
				if (flag3)
				{
					Comparison<int> _comparison = translator.GetDelegate<Comparison<int>>(L, 2);
					gen_to_be_invoked.Sort(_comparison);
					return 0;
				}
				bool flag4 = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && translator.Assignable<IComparer<int>>(L, 4);
				if (flag4)
				{
					int _index = Lua.xlua_tointeger(L, 2);
					int _count = Lua.xlua_tointeger(L, 3);
					IComparer<int> _comparer2 = (IComparer<int>)translator.GetObject(L, 4, typeof(IComparer<int>));
					gen_to_be_invoked.Sort(_index, _count, _comparer2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.Sort!");
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0006B044 File Offset: 0x00069244
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ToArray(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				int[] gen_ret = gen_to_be_invoked.ToArray();
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

		// Token: 0x06000DAE RID: 3502 RVA: 0x0006B0B8 File Offset: 0x000692B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TrimExcess(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.TrimExcess();
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

		// Token: 0x06000DAF RID: 3503 RVA: 0x0006B120 File Offset: 0x00069320
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TrueForAll(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				Predicate<int> _match = translator.GetDelegate<Predicate<int>>(L, 2);
				bool gen_ret = gen_to_be_invoked.TrueForAll(_match);
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

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0006B1A0 File Offset: 0x000693A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Capacity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.Capacity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0006B210 File Offset: 0x00069410
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Count(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
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

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0006B280 File Offset: 0x00069480
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Capacity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				List<int> gen_to_be_invoked = (List<int>)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Capacity = Lua.xlua_tointeger(L, 2);
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

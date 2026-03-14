using System;
using System.Collections.Generic;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200016D RID: 365
	public class ObjectCheckers
	{
		// Token: 0x06000B13 RID: 2835 RVA: 0x000589EC File Offset: 0x00056BEC
		public ObjectCheckers(ObjectTranslator translator)
		{
			this.translator = translator;
			this.checkersMap[typeof(sbyte)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(byte)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(short)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(ushort)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(int)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(uint)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(long)] = new ObjectCheck(this.int64Check);
			this.checkersMap[typeof(ulong)] = new ObjectCheck(this.uint64Check);
			this.checkersMap[typeof(double)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(char)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(float)] = new ObjectCheck(this.numberCheck);
			this.checkersMap[typeof(decimal)] = new ObjectCheck(this.decimalCheck);
			this.checkersMap[typeof(bool)] = new ObjectCheck(this.boolCheck);
			this.checkersMap[typeof(string)] = new ObjectCheck(this.strCheck);
			this.checkersMap[typeof(object)] = new ObjectCheck(ObjectCheckers.objectCheck);
			this.checkersMap[typeof(byte[])] = new ObjectCheck(this.bytesCheck);
			this.checkersMap[typeof(IntPtr)] = new ObjectCheck(this.intptrCheck);
			this.checkersMap[typeof(LuaTable)] = new ObjectCheck(this.luaTableCheck);
			this.checkersMap[typeof(LuaFunction)] = new ObjectCheck(this.luaFunctionCheck);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00058C9C File Offset: 0x00056E9C
		private static bool objectCheck(IntPtr L, int idx)
		{
			return true;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00058CB0 File Offset: 0x00056EB0
		private bool luaTableCheck(IntPtr L, int idx)
		{
			return Lua.lua_isnil(L, idx) || Lua.lua_istable(L, idx) || (Lua.lua_type(L, idx) == LuaTypes.LUA_TUSERDATA && this.translator.SafeGetCSObj(L, idx) is LuaTable);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00058CFC File Offset: 0x00056EFC
		private bool numberCheck(IntPtr L, int idx)
		{
			return Lua.lua_type(L, idx) == LuaTypes.LUA_TNUMBER;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00058D18 File Offset: 0x00056F18
		private bool decimalCheck(IntPtr L, int idx)
		{
			return Lua.lua_type(L, idx) == LuaTypes.LUA_TNUMBER || this.translator.IsDecimal(L, idx);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00058D44 File Offset: 0x00056F44
		private bool strCheck(IntPtr L, int idx)
		{
			return Lua.lua_type(L, idx) == LuaTypes.LUA_TSTRING || Lua.lua_isnil(L, idx);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00058D6C File Offset: 0x00056F6C
		private bool bytesCheck(IntPtr L, int idx)
		{
			return Lua.lua_type(L, idx) == LuaTypes.LUA_TSTRING || Lua.lua_isnil(L, idx) || (Lua.lua_type(L, idx) == LuaTypes.LUA_TUSERDATA && this.translator.SafeGetCSObj(L, idx) is byte[]);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00058DB8 File Offset: 0x00056FB8
		private bool boolCheck(IntPtr L, int idx)
		{
			return Lua.lua_type(L, idx) == LuaTypes.LUA_TBOOLEAN;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00058DD4 File Offset: 0x00056FD4
		private bool int64Check(IntPtr L, int idx)
		{
			return Lua.lua_type(L, idx) == LuaTypes.LUA_TNUMBER || Lua.lua_isint64(L, idx);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00058DFC File Offset: 0x00056FFC
		private bool uint64Check(IntPtr L, int idx)
		{
			return Lua.lua_type(L, idx) == LuaTypes.LUA_TNUMBER || Lua.lua_isuint64(L, idx);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00058E24 File Offset: 0x00057024
		private bool luaFunctionCheck(IntPtr L, int idx)
		{
			return Lua.lua_isnil(L, idx) || Lua.lua_isfunction(L, idx) || (Lua.lua_type(L, idx) == LuaTypes.LUA_TUSERDATA && this.translator.SafeGetCSObj(L, idx) is LuaFunction);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00058E70 File Offset: 0x00057070
		private bool intptrCheck(IntPtr L, int idx)
		{
			return Lua.lua_type(L, idx) == LuaTypes.LUA_TLIGHTUSERDATA;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00058E8C File Offset: 0x0005708C
		private ObjectCheck genChecker(Type type)
		{
			ObjectCheck fixTypeCheck = delegate(IntPtr L, int idx)
			{
				bool flag6 = Lua.lua_type(L, idx) == LuaTypes.LUA_TUSERDATA;
				if (flag6)
				{
					object obj = this.translator.SafeGetCSObj(L, idx);
					bool flag7 = obj != null;
					if (flag7)
					{
						return type.IsAssignableFrom(obj.GetType());
					}
					Type type_of_obj = this.translator.GetTypeOf(L, idx);
					bool flag8 = type_of_obj != null;
					if (flag8)
					{
						return type.IsAssignableFrom(type_of_obj);
					}
				}
				return false;
			};
			bool flag = !type.IsAbstract() && typeof(Delegate).IsAssignableFrom(type);
			ObjectCheck result;
			if (flag)
			{
				result = ((IntPtr L, int idx) => Lua.lua_isnil(L, idx) || Lua.lua_isfunction(L, idx) || fixTypeCheck(L, idx));
			}
			else
			{
				bool flag2 = type.IsEnum();
				if (flag2)
				{
					result = fixTypeCheck;
				}
				else
				{
					bool flag3 = type.IsInterface();
					if (flag3)
					{
						result = ((IntPtr L, int idx) => Lua.lua_isnil(L, idx) || Lua.lua_istable(L, idx) || fixTypeCheck(L, idx));
					}
					else
					{
						bool flag4 = type.IsClass() && type.GetConstructor(Type.EmptyTypes) != null;
						if (flag4)
						{
							result = ((IntPtr L, int idx) => Lua.lua_isnil(L, idx) || Lua.lua_istable(L, idx) || fixTypeCheck(L, idx));
						}
						else
						{
							bool flag5 = type.IsValueType();
							if (flag5)
							{
								result = ((IntPtr L, int idx) => Lua.lua_istable(L, idx) || fixTypeCheck(L, idx));
							}
							else
							{
								bool isArray = type.IsArray;
								if (isArray)
								{
									result = ((IntPtr L, int idx) => Lua.lua_isnil(L, idx) || Lua.lua_istable(L, idx) || fixTypeCheck(L, idx));
								}
								else
								{
									result = ((IntPtr L, int idx) => Lua.lua_isnil(L, idx) || fixTypeCheck(L, idx));
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00058FCC File Offset: 0x000571CC
		public ObjectCheck genNullableChecker(ObjectCheck oc)
		{
			return (IntPtr L, int idx) => Lua.lua_isnil(L, idx) || oc(L, idx);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00058FF7 File Offset: 0x000571F7
		public void AddChecker(Type type, ObjectCheck oc)
		{
			this.checkersMap[type] = oc;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00059008 File Offset: 0x00057208
		public ObjectCheck GetChecker(Type type)
		{
			bool isByRef = type.IsByRef;
			if (isByRef)
			{
				type = type.GetElementType();
			}
			Type underlyingType = Nullable.GetUnderlyingType(type);
			bool flag = underlyingType != null;
			ObjectCheck result;
			if (flag)
			{
				result = this.genNullableChecker(this.GetChecker(underlyingType));
			}
			else
			{
				ObjectCheck oc;
				bool flag2 = !this.checkersMap.TryGetValue(type, out oc);
				if (flag2)
				{
					oc = this.genChecker(type);
					this.checkersMap.Add(type, oc);
				}
				result = oc;
			}
			return result;
		}

		// Token: 0x04000D68 RID: 3432
		private Dictionary<Type, ObjectCheck> checkersMap = new Dictionary<Type, ObjectCheck>();

		// Token: 0x04000D69 RID: 3433
		private ObjectTranslator translator;
	}
}

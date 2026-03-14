using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000170 RID: 368
	public class ObjectCasters
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x00059260 File Offset: 0x00057460
		public ObjectCasters(ObjectTranslator translator)
		{
			this.translator = translator;
			this.castersMap[typeof(char)] = new ObjectCast(ObjectCasters.charCaster);
			this.castersMap[typeof(sbyte)] = new ObjectCast(ObjectCasters.sbyteCaster);
			this.castersMap[typeof(byte)] = new ObjectCast(ObjectCasters.byteCaster);
			this.castersMap[typeof(short)] = new ObjectCast(ObjectCasters.shortCaster);
			this.castersMap[typeof(ushort)] = new ObjectCast(ObjectCasters.ushortCaster);
			this.castersMap[typeof(int)] = new ObjectCast(ObjectCasters.intCaster);
			this.castersMap[typeof(uint)] = new ObjectCast(ObjectCasters.uintCaster);
			this.castersMap[typeof(long)] = new ObjectCast(ObjectCasters.longCaster);
			this.castersMap[typeof(ulong)] = new ObjectCast(ObjectCasters.ulongCaster);
			this.castersMap[typeof(double)] = new ObjectCast(ObjectCasters.getDouble);
			this.castersMap[typeof(float)] = new ObjectCast(ObjectCasters.floatCaster);
			this.castersMap[typeof(decimal)] = new ObjectCast(this.decimalCaster);
			this.castersMap[typeof(bool)] = new ObjectCast(ObjectCasters.getBoolean);
			this.castersMap[typeof(string)] = new ObjectCast(ObjectCasters.getString);
			this.castersMap[typeof(object)] = new ObjectCast(this.getObject);
			this.castersMap[typeof(byte[])] = new ObjectCast(this.getBytes);
			this.castersMap[typeof(IntPtr)] = new ObjectCast(this.getIntptr);
			this.castersMap[typeof(LuaTable)] = new ObjectCast(this.getLuaTable);
			this.castersMap[typeof(LuaFunction)] = new ObjectCast(this.getLuaFunction);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00059510 File Offset: 0x00057710
		private static object charCaster(IntPtr L, int idx, object target)
		{
			return (char)Lua.xlua_tointeger(L, idx);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00059530 File Offset: 0x00057730
		private static object sbyteCaster(IntPtr L, int idx, object target)
		{
			return (sbyte)Lua.xlua_tointeger(L, idx);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00059550 File Offset: 0x00057750
		private static object byteCaster(IntPtr L, int idx, object target)
		{
			return (byte)Lua.xlua_tointeger(L, idx);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00059570 File Offset: 0x00057770
		private static object shortCaster(IntPtr L, int idx, object target)
		{
			return (short)Lua.xlua_tointeger(L, idx);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00059590 File Offset: 0x00057790
		private static object ushortCaster(IntPtr L, int idx, object target)
		{
			return (ushort)Lua.xlua_tointeger(L, idx);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000595B0 File Offset: 0x000577B0
		private static object intCaster(IntPtr L, int idx, object target)
		{
			return Lua.xlua_tointeger(L, idx);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x000595D0 File Offset: 0x000577D0
		private static object uintCaster(IntPtr L, int idx, object target)
		{
			return Lua.xlua_touint(L, idx);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x000595F0 File Offset: 0x000577F0
		private static object longCaster(IntPtr L, int idx, object target)
		{
			return Lua.lua_toint64(L, idx);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00059610 File Offset: 0x00057810
		private static object ulongCaster(IntPtr L, int idx, object target)
		{
			return Lua.lua_touint64(L, idx);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00059630 File Offset: 0x00057830
		private static object getDouble(IntPtr L, int idx, object target)
		{
			return Lua.lua_tonumber(L, idx);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00059650 File Offset: 0x00057850
		private static object floatCaster(IntPtr L, int idx, object target)
		{
			return (float)Lua.lua_tonumber(L, idx);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00059670 File Offset: 0x00057870
		private object decimalCaster(IntPtr L, int idx, object target)
		{
			decimal ret;
			this.translator.Get(L, idx, out ret);
			return ret;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00059698 File Offset: 0x00057898
		private static object getBoolean(IntPtr L, int idx, object target)
		{
			return Lua.lua_toboolean(L, idx);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000596B8 File Offset: 0x000578B8
		private static object getString(IntPtr L, int idx, object target)
		{
			return Lua.lua_tostring(L, idx);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000596D4 File Offset: 0x000578D4
		private object getBytes(IntPtr L, int idx, object target)
		{
			bool flag = Lua.lua_type(L, idx) == LuaTypes.LUA_TSTRING;
			object result;
			if (flag)
			{
				result = Lua.lua_tobytes(L, idx);
			}
			else
			{
				object obj = this.translator.SafeGetCSObj(L, idx);
				result = ((obj is RawObject) ? (obj as RawObject).Target : (obj as byte[]));
			}
			return result;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00059728 File Offset: 0x00057928
		private object getIntptr(IntPtr L, int idx, object target)
		{
			return Lua.lua_touserdata(L, idx);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00059748 File Offset: 0x00057948
		private object getObject(IntPtr L, int idx, object target)
		{
			switch (Lua.lua_type(L, idx))
			{
			case LuaTypes.LUA_TBOOLEAN:
				return Lua.lua_toboolean(L, idx);
			case LuaTypes.LUA_TNUMBER:
			{
				bool flag = Lua.lua_isint64(L, idx);
				if (flag)
				{
					return Lua.lua_toint64(L, idx);
				}
				bool flag2 = Lua.lua_isinteger(L, idx);
				if (flag2)
				{
					return Lua.xlua_tointeger(L, idx);
				}
				return Lua.lua_tonumber(L, idx);
			}
			case LuaTypes.LUA_TSTRING:
				return Lua.lua_tostring(L, idx);
			case LuaTypes.LUA_TTABLE:
				return this.getLuaTable(L, idx, null);
			case LuaTypes.LUA_TFUNCTION:
				return this.getLuaFunction(L, idx, null);
			case LuaTypes.LUA_TUSERDATA:
			{
				bool flag3 = Lua.lua_isint64(L, idx);
				if (flag3)
				{
					return Lua.lua_toint64(L, idx);
				}
				bool flag4 = Lua.lua_isuint64(L, idx);
				if (flag4)
				{
					return Lua.lua_touint64(L, idx);
				}
				object obj = this.translator.SafeGetCSObj(L, idx);
				return (obj is RawObject) ? (obj as RawObject).Target : obj;
			}
			}
			return null;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00059890 File Offset: 0x00057A90
		private object getLuaTable(IntPtr L, int idx, object target)
		{
			bool flag = Lua.lua_type(L, idx) == LuaTypes.LUA_TUSERDATA;
			object result;
			if (flag)
			{
				object obj = this.translator.SafeGetCSObj(L, idx);
				result = ((obj != null && obj is LuaTable) ? obj : null);
			}
			else
			{
				bool flag2 = !Lua.lua_istable(L, idx);
				if (flag2)
				{
					result = null;
				}
				else
				{
					Lua.lua_pushvalue(L, idx);
					result = new LuaTable(Lua.luaL_ref(L), this.translator.luaEnv);
				}
			}
			return result;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00059904 File Offset: 0x00057B04
		private object getLuaFunction(IntPtr L, int idx, object target)
		{
			bool flag = Lua.lua_type(L, idx) == LuaTypes.LUA_TUSERDATA;
			object result;
			if (flag)
			{
				object obj = this.translator.SafeGetCSObj(L, idx);
				result = ((obj != null && obj is LuaFunction) ? obj : null);
			}
			else
			{
				bool flag2 = !Lua.lua_isfunction(L, idx);
				if (flag2)
				{
					result = null;
				}
				else
				{
					Lua.lua_pushvalue(L, idx);
					result = new LuaFunction(Lua.luaL_ref(L), this.translator.luaEnv);
				}
			}
			return result;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00059976 File Offset: 0x00057B76
		public void AddCaster(Type type, ObjectCast oc)
		{
			this.castersMap[type] = oc;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00059988 File Offset: 0x00057B88
		private ObjectCast genCaster(Type type)
		{
			ObjectCast fixTypeGetter = delegate(IntPtr L, int idx, object target)
			{
				bool flag8 = Lua.lua_type(L, idx) == LuaTypes.LUA_TUSERDATA;
				object result2;
				if (flag8)
				{
					object obj = this.translator.SafeGetCSObj(L, idx);
					result2 = ((obj != null && type.IsAssignableFrom(obj.GetType())) ? obj : null);
				}
				else
				{
					result2 = null;
				}
				return result2;
			};
			bool flag = typeof(Delegate).IsAssignableFrom(type);
			ObjectCast result;
			if (flag)
			{
				result = delegate(IntPtr L, int idx, object target)
				{
					object obj = fixTypeGetter(L, idx, target);
					bool flag8 = obj != null;
					object result2;
					if (flag8)
					{
						result2 = obj;
					}
					else
					{
						bool flag9 = !Lua.lua_isfunction(L, idx);
						if (flag9)
						{
							result2 = null;
						}
						else
						{
							result2 = this.translator.CreateDelegateBridge(L, type, idx);
						}
					}
					return result2;
				};
			}
			else
			{
				bool flag2 = typeof(DelegateBridgeBase).IsAssignableFrom(type);
				if (flag2)
				{
					result = delegate(IntPtr L, int idx, object target)
					{
						object obj = fixTypeGetter(L, idx, target);
						bool flag8 = obj != null;
						object result2;
						if (flag8)
						{
							result2 = obj;
						}
						else
						{
							bool flag9 = !Lua.lua_isfunction(L, idx);
							if (flag9)
							{
								result2 = null;
							}
							else
							{
								result2 = this.translator.CreateDelegateBridge(L, null, idx);
							}
						}
						return result2;
					};
				}
				else
				{
					bool flag3 = type.IsInterface();
					if (flag3)
					{
						result = delegate(IntPtr L, int idx, object target)
						{
							object obj = fixTypeGetter(L, idx, target);
							bool flag8 = obj != null;
							object result2;
							if (flag8)
							{
								result2 = obj;
							}
							else
							{
								bool flag9 = !Lua.lua_istable(L, idx);
								if (flag9)
								{
									result2 = null;
								}
								else
								{
									result2 = this.translator.CreateInterfaceBridge(L, type, idx);
								}
							}
							return result2;
						};
					}
					else
					{
						bool flag4 = type.IsEnum();
						if (flag4)
						{
							result = delegate(IntPtr L, int idx, object target)
							{
								object obj = fixTypeGetter(L, idx, target);
								bool flag8 = obj != null;
								object result2;
								if (flag8)
								{
									result2 = obj;
								}
								else
								{
									LuaTypes lua_type = Lua.lua_type(L, idx);
									bool flag9 = lua_type == LuaTypes.LUA_TSTRING;
									if (flag9)
									{
										result2 = Enum.Parse(type, Lua.lua_tostring(L, idx));
									}
									else
									{
										bool flag10 = lua_type == LuaTypes.LUA_TNUMBER;
										if (!flag10)
										{
											string str = "invalid value for enum ";
											Type type2 = type;
											throw new InvalidCastException(str + ((type2 != null) ? type2.ToString() : null));
										}
										result2 = Enum.ToObject(type, Lua.xlua_tointeger(L, idx));
									}
								}
								return result2;
							};
						}
						else
						{
							bool isArray = type.IsArray;
							if (isArray)
							{
								result = delegate(IntPtr L, int idx, object target)
								{
									object obj = fixTypeGetter(L, idx, target);
									bool flag8 = obj != null;
									object result2;
									if (flag8)
									{
										result2 = obj;
									}
									else
									{
										bool flag9 = !Lua.lua_istable(L, idx);
										if (flag9)
										{
											result2 = null;
										}
										else
										{
											uint len = Lua.xlua_objlen(L, idx);
											int i = Lua.lua_gettop(L);
											idx = ((idx > 0) ? idx : (Lua.lua_gettop(L) + idx + 1));
											Type et = type.GetElementType();
											ObjectCast elementCaster = this.GetCaster(et);
											Array ary = (target == null) ? Array.CreateInstance(et, (int)len) : (target as Array);
											bool flag10 = !Lua.lua_checkstack(L, 1);
											if (flag10)
											{
												throw new Exception("stack overflow while cast to Array");
											}
											int j = 0;
											while ((long)j < (long)((ulong)len))
											{
												Lua.lua_pushnumber(L, (double)(j + 1));
												Lua.lua_rawget(L, idx);
												bool flag11 = et.IsPrimitive();
												if (flag11)
												{
													bool flag12 = !StaticLuaCallbacks.TryPrimitiveArraySet(type, L, ary, j, i + 1);
													if (flag12)
													{
														ary.SetValue(elementCaster(L, i + 1, null), j);
													}
												}
												else
												{
													bool flag13 = InternalGlobals.genTryArraySetPtr == null || !InternalGlobals.genTryArraySetPtr(type, L, this.translator, ary, j, i + 1);
													if (flag13)
													{
														ary.SetValue(elementCaster(L, i + 1, null), j);
													}
												}
												Lua.lua_pop(L, 1);
												j++;
											}
											result2 = ary;
										}
									}
									return result2;
								};
							}
							else
							{
								bool flag5 = typeof(IList).IsAssignableFrom(type) && type.IsGenericType();
								if (flag5)
								{
									Type elementType = type.GetGenericArguments()[0];
									ObjectCast elementCaster = this.GetCaster(elementType);
									result = delegate(IntPtr L, int idx, object target)
									{
										object obj = fixTypeGetter(L, idx, target);
										bool flag8 = obj != null;
										object result2;
										if (flag8)
										{
											result2 = obj;
										}
										else
										{
											bool flag9 = !Lua.lua_istable(L, idx);
											if (flag9)
											{
												result2 = null;
											}
											else
											{
												obj = ((target == null) ? Activator.CreateInstance(type) : target);
												int i = Lua.lua_gettop(L);
												idx = ((idx > 0) ? idx : (Lua.lua_gettop(L) + idx + 1));
												IList list = obj as IList;
												uint len = Lua.xlua_objlen(L, idx);
												bool flag10 = !Lua.lua_checkstack(L, 1);
												if (flag10)
												{
													throw new Exception("stack overflow while cast to IList");
												}
												int j = 0;
												while ((long)j < (long)((ulong)len))
												{
													Lua.lua_pushnumber(L, (double)(j + 1));
													Lua.lua_rawget(L, idx);
													bool flag11 = j < list.Count && target != null;
													if (flag11)
													{
														bool flag12 = this.translator.Assignable(L, i + 1, elementType);
														if (flag12)
														{
															list[j] = elementCaster(L, i + 1, list[j]);
														}
													}
													else
													{
														bool flag13 = this.translator.Assignable(L, i + 1, elementType);
														if (flag13)
														{
															list.Add(elementCaster(L, i + 1, null));
														}
													}
													Lua.lua_pop(L, 1);
													j++;
												}
												result2 = obj;
											}
										}
										return result2;
									};
								}
								else
								{
									bool flag6 = typeof(IDictionary).IsAssignableFrom(type) && type.IsGenericType();
									if (flag6)
									{
										Type keyType = type.GetGenericArguments()[0];
										ObjectCast keyCaster = this.GetCaster(keyType);
										Type valueType = type.GetGenericArguments()[1];
										ObjectCast valueCaster = this.GetCaster(valueType);
										result = delegate(IntPtr L, int idx, object target)
										{
											object obj = fixTypeGetter(L, idx, target);
											bool flag8 = obj != null;
											object result2;
											if (flag8)
											{
												result2 = obj;
											}
											else
											{
												bool flag9 = !Lua.lua_istable(L, idx);
												if (flag9)
												{
													result2 = null;
												}
												else
												{
													IDictionary dic = ((target == null) ? Activator.CreateInstance(type) : target) as IDictionary;
													int i = Lua.lua_gettop(L);
													idx = ((idx > 0) ? idx : (Lua.lua_gettop(L) + idx + 1));
													Lua.lua_pushnil(L);
													bool flag10 = !Lua.lua_checkstack(L, 1);
													if (flag10)
													{
														throw new Exception("stack overflow while cast to IDictionary");
													}
													while (Lua.lua_next(L, idx) != 0)
													{
														bool flag11 = this.translator.Assignable(L, i + 1, keyType) && this.translator.Assignable(L, i + 2, valueType);
														if (flag11)
														{
															object j = keyCaster(L, i + 1, null);
															dic[j] = valueCaster(L, i + 2, (!dic.Contains(j)) ? null : dic[j]);
														}
														Lua.lua_pop(L, 1);
													}
													result2 = dic;
												}
											}
											return result2;
										};
									}
									else
									{
										bool flag7 = (type.IsClass() && type.GetConstructor(Type.EmptyTypes) != null) || (type.IsValueType() && !type.IsEnum());
										if (flag7)
										{
											result = delegate(IntPtr L, int idx, object target)
											{
												object obj = fixTypeGetter(L, idx, target);
												bool flag8 = obj != null;
												object result2;
												if (flag8)
												{
													result2 = obj;
												}
												else
												{
													bool flag9 = !Lua.lua_istable(L, idx);
													if (flag9)
													{
														result2 = null;
													}
													else
													{
														obj = ((target == null) ? Activator.CreateInstance(type) : target);
														int i = Lua.lua_gettop(L);
														idx = ((idx > 0) ? idx : (Lua.lua_gettop(L) + idx + 1));
														bool flag10 = !Lua.lua_checkstack(L, 1);
														if (flag10)
														{
															string str = "stack overflow while cast to ";
															Type type2 = type;
															throw new Exception(str + ((type2 != null) ? type2.ToString() : null));
														}
														foreach (FieldInfo field in type.GetFields())
														{
															Lua.xlua_pushasciistring(L, field.Name);
															Lua.lua_rawget(L, idx);
															bool flag11 = !Lua.lua_isnil(L, -1);
															if (flag11)
															{
																try
																{
																	field.SetValue(obj, this.GetCaster(field.FieldType)(L, i + 1, (target == null || field.FieldType.IsPrimitive() || field.FieldType == typeof(string)) ? null : field.GetValue(obj)));
																}
																catch (Exception e)
																{
																	throw new Exception("exception in tran " + field.Name + ", msg=" + e.Message);
																}
															}
															Lua.lua_pop(L, 1);
														}
														result2 = obj;
													}
												}
												return result2;
											};
										}
										else
										{
											result = fixTypeGetter;
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00059C0C File Offset: 0x00057E0C
		private ObjectCast genNullableCaster(ObjectCast oc)
		{
			return delegate(IntPtr L, int idx, object target)
			{
				bool flag = Lua.lua_isnil(L, idx);
				object result;
				if (flag)
				{
					result = null;
				}
				else
				{
					result = oc(L, idx, target);
				}
				return result;
			};
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00059C38 File Offset: 0x00057E38
		public ObjectCast GetCaster(Type type)
		{
			bool isByRef = type.IsByRef;
			if (isByRef)
			{
				type = type.GetElementType();
			}
			Type underlyingType = Nullable.GetUnderlyingType(type);
			bool flag = underlyingType != null;
			ObjectCast result;
			if (flag)
			{
				result = this.genNullableCaster(this.GetCaster(underlyingType));
			}
			else
			{
				ObjectCast oc;
				bool flag2 = !this.castersMap.TryGetValue(type, out oc);
				if (flag2)
				{
					oc = this.genCaster(type);
					this.castersMap.Add(type, oc);
				}
				result = oc;
			}
			return result;
		}

		// Token: 0x04000D6E RID: 3438
		private Dictionary<Type, ObjectCast> castersMap = new Dictionary<Type, ObjectCast>();

		// Token: 0x04000D6F RID: 3439
		private ObjectTranslator translator;
	}
}

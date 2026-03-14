using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Cysharp.Text;
using Tutorial;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000146 RID: 326
	public class StaticLuaCallbacks
	{
		// Token: 0x06000A1D RID: 2589 RVA: 0x0004DB0C File Offset: 0x0004BD0C
		internal static bool __tryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index)
		{
			bool flag = type == typeof(Vector2[]);
			bool result;
			if (flag)
			{
				Vector2[] array = obj as Vector2[];
				translator.PushUnityEngineVector2(L, array[index]);
				result = true;
			}
			else
			{
				bool flag2 = type == typeof(Vector3[]);
				if (flag2)
				{
					Vector3[] array2 = obj as Vector3[];
					translator.PushUnityEngineVector3(L, array2[index]);
					result = true;
				}
				else
				{
					bool flag3 = type == typeof(Vector4[]);
					if (flag3)
					{
						Vector4[] array3 = obj as Vector4[];
						translator.PushUnityEngineVector4(L, array3[index]);
						result = true;
					}
					else
					{
						bool flag4 = type == typeof(Color[]);
						if (flag4)
						{
							Color[] array4 = obj as Color[];
							translator.PushUnityEngineColor(L, array4[index]);
							result = true;
						}
						else
						{
							bool flag5 = type == typeof(Quaternion[]);
							if (flag5)
							{
								Quaternion[] array5 = obj as Quaternion[];
								translator.PushUnityEngineQuaternion(L, array5[index]);
								result = true;
							}
							else
							{
								bool flag6 = type == typeof(Ray[]);
								if (flag6)
								{
									Ray[] array6 = obj as Ray[];
									translator.PushUnityEngineRay(L, array6[index]);
									result = true;
								}
								else
								{
									bool flag7 = type == typeof(Bounds[]);
									if (flag7)
									{
										Bounds[] array7 = obj as Bounds[];
										translator.PushUnityEngineBounds(L, array7[index]);
										result = true;
									}
									else
									{
										bool flag8 = type == typeof(Ray2D[]);
										if (flag8)
										{
											Ray2D[] array8 = obj as Ray2D[];
											translator.PushUnityEngineRay2D(L, array8[index]);
											result = true;
										}
										else
										{
											bool flag9 = type == typeof(TestEnum[]);
											if (flag9)
											{
												TestEnum[] array9 = obj as TestEnum[];
												translator.PushTutorialTestEnum(L, array9[index]);
												result = true;
											}
											else
											{
												bool flag10 = type == typeof(DerivedClass.TestEnumInner[]);
												if (flag10)
												{
													DerivedClass.TestEnumInner[] array10 = obj as DerivedClass.TestEnumInner[];
													translator.PushTutorialDerivedClassTestEnumInner(L, array10[index]);
													result = true;
												}
												else
												{
													result = false;
												}
											}
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

		// Token: 0x06000A1E RID: 2590 RVA: 0x0004DD30 File Offset: 0x0004BF30
		internal static bool __tryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx)
		{
			bool flag = type == typeof(Vector2[]);
			bool result;
			if (flag)
			{
				Vector2[] array = obj as Vector2[];
				translator.Get(L, obj_idx, out array[array_idx]);
				result = true;
			}
			else
			{
				bool flag2 = type == typeof(Vector3[]);
				if (flag2)
				{
					Vector3[] array2 = obj as Vector3[];
					translator.Get(L, obj_idx, out array2[array_idx]);
					result = true;
				}
				else
				{
					bool flag3 = type == typeof(Vector4[]);
					if (flag3)
					{
						Vector4[] array3 = obj as Vector4[];
						translator.Get(L, obj_idx, out array3[array_idx]);
						result = true;
					}
					else
					{
						bool flag4 = type == typeof(Color[]);
						if (flag4)
						{
							Color[] array4 = obj as Color[];
							translator.Get(L, obj_idx, out array4[array_idx]);
							result = true;
						}
						else
						{
							bool flag5 = type == typeof(Quaternion[]);
							if (flag5)
							{
								Quaternion[] array5 = obj as Quaternion[];
								translator.Get(L, obj_idx, out array5[array_idx]);
								result = true;
							}
							else
							{
								bool flag6 = type == typeof(Ray[]);
								if (flag6)
								{
									Ray[] array6 = obj as Ray[];
									translator.Get(L, obj_idx, out array6[array_idx]);
									result = true;
								}
								else
								{
									bool flag7 = type == typeof(Bounds[]);
									if (flag7)
									{
										Bounds[] array7 = obj as Bounds[];
										translator.Get(L, obj_idx, out array7[array_idx]);
										result = true;
									}
									else
									{
										bool flag8 = type == typeof(Ray2D[]);
										if (flag8)
										{
											Ray2D[] array8 = obj as Ray2D[];
											translator.Get(L, obj_idx, out array8[array_idx]);
											result = true;
										}
										else
										{
											bool flag9 = type == typeof(TestEnum[]);
											if (flag9)
											{
												TestEnum[] array9 = obj as TestEnum[];
												translator.Get(L, obj_idx, out array9[array_idx]);
												result = true;
											}
											else
											{
												bool flag10 = type == typeof(DerivedClass.TestEnumInner[]);
												if (flag10)
												{
													DerivedClass.TestEnumInner[] array10 = obj as DerivedClass.TestEnumInner[];
													translator.Get(L, obj_idx, out array10[array_idx]);
													result = true;
												}
												else
												{
													result = false;
												}
											}
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

		// Token: 0x06000A1F RID: 2591 RVA: 0x0004DF70 File Offset: 0x0004C170
		public StaticLuaCallbacks()
		{
			this.GcMeta = new lua_CSFunction(StaticLuaCallbacks.LuaGC);
			this.ToStringMeta = new lua_CSFunction(StaticLuaCallbacks.ToString);
			this.EnumAndMeta = new lua_CSFunction(StaticLuaCallbacks.EnumAnd);
			this.EnumOrMeta = new lua_CSFunction(StaticLuaCallbacks.EnumOr);
			this.StaticCSFunctionWraper = new lua_CSFunction(StaticLuaCallbacks.StaticCSFunction);
			this.FixCSFunctionWraper = new lua_CSFunction(StaticLuaCallbacks.FixCSFunction);
			this.DelegateCtor = new lua_CSFunction(StaticLuaCallbacks.DelegateConstructor);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0004E004 File Offset: 0x0004C204
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumAnd(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object left = translator.FastGetCSObj(L, 1);
				object right = translator.FastGetCSObj(L, 2);
				Type typeOfLeft = left.GetType();
				bool flag = !typeOfLeft.IsEnum() || typeOfLeft != right.GetType();
				if (flag)
				{
					result = Lua.luaL_error(L, "invalid argument for Enum BitwiseAnd");
				}
				else
				{
					translator.PushAny(L, Enum.ToObject(typeOfLeft, Convert.ToInt64(left) & Convert.ToInt64(right)));
					result = 1;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in Enum BitwiseAnd:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0004E0BC File Offset: 0x0004C2BC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumOr(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object left = translator.FastGetCSObj(L, 1);
				object right = translator.FastGetCSObj(L, 2);
				Type typeOfLeft = left.GetType();
				bool flag = !typeOfLeft.IsEnum() || typeOfLeft != right.GetType();
				if (flag)
				{
					result = Lua.luaL_error(L, "invalid argument for Enum BitwiseOr");
				}
				else
				{
					translator.PushAny(L, Enum.ToObject(typeOfLeft, Convert.ToInt64(left) | Convert.ToInt64(right)));
					result = 1;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in Enum BitwiseOr:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0004E174 File Offset: 0x0004C374
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int StaticCSFunction(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				lua_CSFunction func = (lua_CSFunction)translator.FastGetCSObj(L, Lua.xlua_upvalueindex(1));
				result = func(L);
			}
			catch (Exception e)
			{
				string str = "c# exception in StaticCSFunction:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0004E1E0 File Offset: 0x0004C3E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int FixCSFunction(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int idx = Lua.xlua_tointeger(L, Lua.xlua_upvalueindex(1));
				lua_CSFunction func = translator.GetFixCSFunction(idx);
				result = func(L);
			}
			catch (Exception e)
			{
				string str = "c# exception in FixCSFunction:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0004E250 File Offset: 0x0004C450
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCall(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object objDelegate = translator.FastGetCSObj(L, 1);
				bool flag = objDelegate == null || !(objDelegate is Delegate);
				if (flag)
				{
					result = Lua.luaL_error(L, "trying to invoke a value that is not delegate nor callable");
				}
				else
				{
					result = translator.methodWrapsCache.GetDelegateWrap(objDelegate.GetType())(L);
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in DelegateCall:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0004E2E8 File Offset: 0x0004C4E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaGC(IntPtr L)
		{
			int result;
			try
			{
				int udata = Lua.xlua_tocsobj_safe(L, 1);
				bool flag = udata != -1;
				if (flag)
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					bool flag2 = translator != null;
					if (flag2)
					{
						translator.collectObject(udata);
					}
				}
				result = 0;
			}
			catch (Exception e)
			{
				string str = "c# exception in LuaGC:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0004E368 File Offset: 0x0004C568
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToString(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object obj = translator.FastGetCSObj(L, 1);
				translator.PushAny(L, (obj != null) ? (obj.ToString() + ": " + obj.GetHashCode().ToString()) : "<invalid c# object>");
				result = 1;
			}
			catch (Exception e)
			{
				string str = "c# exception in ToString:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0004E3F8 File Offset: 0x0004C5F8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCombine(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type = translator.FastGetCSObj(L, (Lua.lua_type(L, 1) == LuaTypes.LUA_TUSERDATA) ? 1 : 2).GetType();
				Delegate d = translator.GetObject(L, 1, type) as Delegate;
				Delegate d2 = translator.GetObject(L, 2, type) as Delegate;
				bool flag = d == null || d2 == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "one parameter must be a delegate, other one must be delegate or function");
				}
				else
				{
					translator.PushAny(L, Delegate.Combine(d, d2));
					result = 1;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in DelegateCombine:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0004E4B8 File Offset: 0x0004C6B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateRemove(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Delegate d = translator.FastGetCSObj(L, 1) as Delegate;
				bool flag = d == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "#1 parameter must be a delegate");
				}
				else
				{
					Delegate d2 = translator.GetObject(L, 2, d.GetType()) as Delegate;
					bool flag2 = d2 == null;
					if (flag2)
					{
						result = Lua.luaL_error(L, "#2 parameter must be a delegate or a function ");
					}
					else
					{
						translator.PushAny(L, Delegate.Remove(d, d2));
						result = 1;
					}
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in DelegateRemove:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0004E574 File Offset: 0x0004C774
		private static bool tryPrimitiveArrayGet(Type type, IntPtr L, object obj, int index)
		{
			bool ok = true;
			bool flag = type == typeof(int[]);
			if (flag)
			{
				int[] array = obj as int[];
				Lua.xlua_pushinteger(L, array[index]);
			}
			else
			{
				bool flag2 = type == typeof(float[]);
				if (flag2)
				{
					float[] array2 = obj as float[];
					Lua.lua_pushnumber(L, (double)array2[index]);
				}
				else
				{
					bool flag3 = type == typeof(double[]);
					if (flag3)
					{
						double[] array3 = obj as double[];
						Lua.lua_pushnumber(L, array3[index]);
					}
					else
					{
						bool flag4 = type == typeof(bool[]);
						if (flag4)
						{
							bool[] array4 = obj as bool[];
							Lua.lua_pushboolean(L, array4[index]);
						}
						else
						{
							bool flag5 = type == typeof(long[]);
							if (flag5)
							{
								long[] array5 = obj as long[];
								Lua.lua_pushint64(L, array5[index]);
							}
							else
							{
								bool flag6 = type == typeof(ulong[]);
								if (flag6)
								{
									ulong[] array6 = obj as ulong[];
									Lua.lua_pushuint64(L, array6[index]);
								}
								else
								{
									bool flag7 = type == typeof(sbyte[]);
									if (flag7)
									{
										sbyte[] array7 = obj as sbyte[];
										Lua.xlua_pushinteger(L, (int)array7[index]);
									}
									else
									{
										bool flag8 = type == typeof(short[]);
										if (flag8)
										{
											short[] array8 = obj as short[];
											Lua.xlua_pushinteger(L, (int)array8[index]);
										}
										else
										{
											bool flag9 = type == typeof(ushort[]);
											if (flag9)
											{
												ushort[] array9 = obj as ushort[];
												Lua.xlua_pushinteger(L, (int)array9[index]);
											}
											else
											{
												bool flag10 = type == typeof(char[]);
												if (flag10)
												{
													char[] array10 = obj as char[];
													Lua.xlua_pushinteger(L, (int)array10[index]);
												}
												else
												{
													bool flag11 = type == typeof(uint[]);
													if (flag11)
													{
														uint[] array11 = obj as uint[];
														Lua.xlua_pushuint(L, array11[index]);
													}
													else
													{
														bool flag12 = type == typeof(IntPtr[]);
														if (flag12)
														{
															IntPtr[] array12 = obj as IntPtr[];
															Lua.lua_pushlightuserdata(L, array12[index]);
														}
														else
														{
															bool flag13 = type == typeof(decimal[]);
															if (flag13)
															{
																decimal[] array13 = obj as decimal[];
																ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
																translator.PushDecimal(L, array13[index]);
															}
															else
															{
																bool flag14 = type == typeof(string[]);
																if (flag14)
																{
																	string[] array14 = obj as string[];
																	Lua.lua_pushstring(L, array14[index]);
																}
																else
																{
																	ok = false;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return ok;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0004E834 File Offset: 0x0004CA34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayIndexer(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Array array = (Array)translator.FastGetCSObj(L, 1);
				bool flag = array == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "#1 parameter is not a array!");
				}
				else
				{
					int i = Lua.xlua_tointeger(L, 2);
					bool flag2 = i >= array.Length;
					if (flag2)
					{
						result = Lua.luaL_error(L, "index out of range! i =" + i.ToString() + ", array.Length=" + array.Length.ToString());
					}
					else
					{
						Type type = array.GetType();
						bool flag3 = StaticLuaCallbacks.tryPrimitiveArrayGet(type, L, array, i);
						if (flag3)
						{
							result = 1;
						}
						else
						{
							bool flag4 = InternalGlobals.genTryArrayGetPtr != null;
							if (flag4)
							{
								try
								{
									bool flag5 = InternalGlobals.genTryArrayGetPtr(type, L, translator, array, i);
									if (flag5)
									{
										return 1;
									}
								}
								catch (Exception e)
								{
									return Lua.luaL_error(L, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
								}
							}
							object ret = array.GetValue(i);
							translator.PushAny(L, ret);
							result = 1;
						}
					}
				}
			}
			catch (Exception e2)
			{
				string str = "c# exception in ArrayIndexer:";
				Exception ex = e2;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0004E9B8 File Offset: 0x0004CBB8
		public static bool TryPrimitiveArraySet(Type type, IntPtr L, object obj, int array_idx, int obj_idx)
		{
			bool ok = true;
			LuaTypes lua_type = Lua.lua_type(L, obj_idx);
			bool flag = type == typeof(int[]) && lua_type == LuaTypes.LUA_TNUMBER;
			if (flag)
			{
				int[] array = obj as int[];
				array[array_idx] = Lua.xlua_tointeger(L, obj_idx);
			}
			else
			{
				bool flag2 = type == typeof(float[]) && lua_type == LuaTypes.LUA_TNUMBER;
				if (flag2)
				{
					float[] array2 = obj as float[];
					array2[array_idx] = (float)Lua.lua_tonumber(L, obj_idx);
				}
				else
				{
					bool flag3 = type == typeof(double[]) && lua_type == LuaTypes.LUA_TNUMBER;
					if (flag3)
					{
						double[] array3 = obj as double[];
						array3[array_idx] = Lua.lua_tonumber(L, obj_idx);
					}
					else
					{
						bool flag4 = type == typeof(bool[]) && lua_type == LuaTypes.LUA_TBOOLEAN;
						if (flag4)
						{
							bool[] array4 = obj as bool[];
							array4[array_idx] = Lua.lua_toboolean(L, obj_idx);
						}
						else
						{
							bool flag5 = type == typeof(long[]) && Lua.lua_isint64(L, obj_idx);
							if (flag5)
							{
								long[] array5 = obj as long[];
								array5[array_idx] = Lua.lua_toint64(L, obj_idx);
							}
							else
							{
								bool flag6 = type == typeof(ulong[]) && Lua.lua_isuint64(L, obj_idx);
								if (flag6)
								{
									ulong[] array6 = obj as ulong[];
									array6[array_idx] = Lua.lua_touint64(L, obj_idx);
								}
								else
								{
									bool flag7 = type == typeof(sbyte[]) && lua_type == LuaTypes.LUA_TNUMBER;
									if (flag7)
									{
										sbyte[] array7 = obj as sbyte[];
										array7[array_idx] = (sbyte)Lua.xlua_tointeger(L, obj_idx);
									}
									else
									{
										bool flag8 = type == typeof(short[]) && lua_type == LuaTypes.LUA_TNUMBER;
										if (flag8)
										{
											short[] array8 = obj as short[];
											array8[array_idx] = (short)Lua.xlua_tointeger(L, obj_idx);
										}
										else
										{
											bool flag9 = type == typeof(ushort[]) && lua_type == LuaTypes.LUA_TNUMBER;
											if (flag9)
											{
												ushort[] array9 = obj as ushort[];
												array9[array_idx] = (ushort)Lua.xlua_tointeger(L, obj_idx);
											}
											else
											{
												bool flag10 = type == typeof(char[]) && lua_type == LuaTypes.LUA_TNUMBER;
												if (flag10)
												{
													char[] array10 = obj as char[];
													array10[array_idx] = (char)Lua.xlua_tointeger(L, obj_idx);
												}
												else
												{
													bool flag11 = type == typeof(uint[]) && lua_type == LuaTypes.LUA_TNUMBER;
													if (flag11)
													{
														uint[] array11 = obj as uint[];
														array11[array_idx] = Lua.xlua_touint(L, obj_idx);
													}
													else
													{
														bool flag12 = type == typeof(IntPtr[]) && lua_type == LuaTypes.LUA_TLIGHTUSERDATA;
														if (flag12)
														{
															IntPtr[] array12 = obj as IntPtr[];
															array12[array_idx] = Lua.lua_touserdata(L, obj_idx);
														}
														else
														{
															bool flag13 = type == typeof(decimal[]);
															if (flag13)
															{
																decimal[] array13 = obj as decimal[];
																bool flag14 = lua_type == LuaTypes.LUA_TNUMBER;
																if (flag14)
																{
																	array13[array_idx] = (decimal)Lua.lua_tonumber(L, obj_idx);
																}
																bool flag15 = lua_type == LuaTypes.LUA_TUSERDATA;
																if (flag15)
																{
																	ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
																	bool flag16 = translator.IsDecimal(L, obj_idx);
																	if (flag16)
																	{
																		translator.Get(L, obj_idx, out array13[array_idx]);
																	}
																	else
																	{
																		ok = false;
																	}
																}
																else
																{
																	ok = false;
																}
															}
															else
															{
																bool flag17 = type == typeof(string[]) && lua_type == LuaTypes.LUA_TSTRING;
																if (flag17)
																{
																	string[] array14 = obj as string[];
																	array14[array_idx] = Lua.lua_tostring(L, obj_idx);
																}
																else
																{
																	ok = false;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return ok;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0004ED64 File Offset: 0x0004CF64
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayNewIndexer(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Array array = (Array)translator.FastGetCSObj(L, 1);
				bool flag = array == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "#1 parameter is not a array!");
				}
				else
				{
					int i = Lua.xlua_tointeger(L, 2);
					bool flag2 = i >= array.Length;
					if (flag2)
					{
						result = Lua.luaL_error(L, "index out of range! i =" + i.ToString() + ", array.Length=" + array.Length.ToString());
					}
					else
					{
						Type type = array.GetType();
						bool flag3 = StaticLuaCallbacks.TryPrimitiveArraySet(type, L, array, i, 3);
						if (flag3)
						{
							result = 0;
						}
						else
						{
							bool flag4 = InternalGlobals.genTryArraySetPtr != null;
							if (flag4)
							{
								try
								{
									bool flag5 = InternalGlobals.genTryArraySetPtr(type, L, translator, array, i, 3);
									if (flag5)
									{
										return 0;
									}
								}
								catch (Exception e)
								{
									return Lua.luaL_error(L, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
								}
							}
							object val = translator.GetObject(L, 3, type.GetElementType());
							array.SetValue(val, i);
							result = 0;
						}
					}
				}
			}
			catch (Exception e2)
			{
				string str = "c# exception in ArrayNewIndexer:";
				Exception ex = e2;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0004EEF0 File Offset: 0x0004D0F0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayLength(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Array array = (Array)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, array.Length);
				result = 1;
			}
			catch (Exception e)
			{
				string str = "c# exception in ArrayLength:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0004EF60 File Offset: 0x0004D160
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int MetaFuncIndex(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type = translator.FastGetCSObj(L, 2) as Type;
				bool flag = type == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "#2 param need a System.Type!");
				}
				else
				{
					translator.GetTypeId(L, type);
					Lua.lua_pushvalue(L, 2);
					Lua.lua_rawget(L, 1);
					result = 1;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in MetaFuncIndex:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Panic(IntPtr L)
		{
			string reason = ZString.Format<object>("unprotected error in call to Lua API ({0})", Lua.lua_tostring(L, -1));
			throw new LuaException(reason);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0004F020 File Offset: 0x0004D220
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Print(IntPtr L)
		{
			int result;
			try
			{
				int i = Lua.lua_gettop(L);
				string s = string.Empty;
				bool flag = Lua.xlua_getglobal(L, "tostring") != 0;
				if (flag)
				{
					result = Lua.luaL_error(L, "can not get tostring in print:");
				}
				else
				{
					for (int j = 1; j <= i; j++)
					{
						Lua.lua_pushvalue(L, -1);
						Lua.lua_pushvalue(L, j);
						bool flag2 = Lua.lua_pcall(L, 1, 1, 0) != 0;
						if (flag2)
						{
							return Lua.lua_error(L);
						}
						s += Lua.lua_tostring(L, -1);
						bool flag3 = j != i;
						if (flag3)
						{
							s += "\t";
						}
						Lua.lua_pop(L, 1);
					}
					Debug.Log("LUA: " + s);
					result = 0;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in print:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0004F124 File Offset: 0x0004D324
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadSocketCore(IntPtr L)
		{
			return Lua.luaopen_socket_core(L);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0004F13C File Offset: 0x0004D33C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadCS(IntPtr L)
		{
			Lua.xlua_pushasciistring(L, "xlua_csharp_namespace");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			return 1;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0004F168 File Offset: 0x0004D368
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadBuiltinLib(IntPtr L)
		{
			int result;
			try
			{
				string builtin_lib = Lua.lua_tostring(L, 1);
				LuaEnv self = ObjectTranslatorPool.Instance.Find(L).luaEnv;
				lua_CSFunction initer;
				bool flag = self.buildin_initer.TryGetValue(builtin_lib, out initer);
				if (flag)
				{
					Lua.lua_pushstdcallcfunction(L, initer, 0);
				}
				else
				{
					Lua.lua_pushstring(L, ZString.Format<object>("\n\tno such builtin lib '{0}'", builtin_lib));
				}
				result = 1;
			}
			catch (Exception e)
			{
				string str = "c# exception in LoadBuiltinLib:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0004F200 File Offset: 0x0004D400
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromResource(IntPtr L)
		{
			int result;
			try
			{
				string filename = Lua.lua_tostring(L, 1).Replace('.', '/') + ".lua";
				TextAsset file = (TextAsset)Resources.Load(filename);
				bool flag = file == null;
				if (flag)
				{
					Lua.lua_pushstring(L, ZString.Format<object>("\n\tno such resource '{0}'", filename));
				}
				else
				{
					bool flag2 = Lua.xluaL_loadbuffer(L, file.bytes, file.bytes.Length, "@" + filename) != 0;
					if (flag2)
					{
						return Lua.luaL_error(L, ZString.Format<object, object>("error loading module {0} from resource, {1}", Lua.lua_tostring(L, 1), Lua.lua_tostring(L, -1)));
					}
				}
				result = 1;
			}
			catch (Exception e)
			{
				string str = "c# exception in LoadFromResource:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0004F2E0 File Offset: 0x0004D4E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromStreamingAssetsPath(IntPtr L)
		{
			int result;
			try
			{
				string filename = Lua.lua_tostring(L, 1).Replace('.', '/') + ".lua";
				string filepath = Application.streamingAssetsPath + "/" + filename;
				bool flag = File.Exists(filepath);
				if (flag)
				{
					byte[] bytes = File.ReadAllBytes(filepath);
					Debug.LogWarning("load lua file from StreamingAssets is obsolete, filename:" + filename);
					bool flag2 = Lua.xluaL_loadbuffer(L, bytes, bytes.Length, "@" + filename) != 0;
					if (flag2)
					{
						return Lua.luaL_error(L, ZString.Format<object, object>("error loading module {0} from streamingAssetsPath, {1}", Lua.lua_tostring(L, 1), Lua.lua_tostring(L, -1)));
					}
				}
				else
				{
					Lua.lua_pushstring(L, ZString.Format<object>("\n\tno such file '{0}' in streamingAssetsPath!", filename));
				}
				result = 1;
			}
			catch (Exception e)
			{
				string str = "c# exception in LoadFromStreamingAssetsPath:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0004F3D4 File Offset: 0x0004D5D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromCustomLoaders(IntPtr L)
		{
			int result;
			try
			{
				string filename = Lua.lua_tostring(L, 1);
				LuaEnv self = ObjectTranslatorPool.Instance.Find(L).luaEnv;
				foreach (LuaEnv.CustomLoader loader in self.customLoaders)
				{
					string real_file_path = filename;
					byte[] bytes = loader(ref real_file_path);
					bool flag = bytes != null;
					if (flag)
					{
						bool flag2 = Lua.xluaL_loadbuffer(L, bytes, bytes.Length, "@" + real_file_path) != 0;
						if (flag2)
						{
							return Lua.luaL_error(L, ZString.Format<object, object>("error loading module {0} from CustomLoader, {1}", Lua.lua_tostring(L, 1), Lua.lua_tostring(L, -1)));
						}
						return 1;
					}
				}
				Lua.lua_pushstring(L, ZString.Format<object>("\n\tno such file '{0}' in CustomLoaders!", filename));
				result = 1;
			}
			catch (Exception e)
			{
				string str = "c# exception in LoadFromCustomLoaders:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0004F4EC File Offset: 0x0004D6EC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadAssembly(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				string assemblyName = Lua.lua_tostring(L, 1);
				Assembly assembly = null;
				try
				{
					assembly = Assembly.Load(assemblyName);
				}
				catch (BadImageFormatException)
				{
				}
				bool flag = assembly == null;
				if (flag)
				{
					assembly = Assembly.Load(AssemblyName.GetAssemblyName(assemblyName));
				}
				bool flag2 = assembly != null && !translator.assemblies.Contains(assembly);
				if (flag2)
				{
					translator.assemblies.Add(assembly);
				}
				result = 0;
			}
			catch (Exception e)
			{
				string str = "c# exception in xlua.load_assembly:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0004F5B4 File Offset: 0x0004D7B4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportType(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				string className = Lua.lua_tostring(L, 1);
				Type type = translator.FindType(className, false);
				bool flag = type != null;
				if (flag)
				{
					bool flag2 = translator.GetTypeId(L, type) >= 0;
					if (!flag2)
					{
						string str = "can not load type ";
						Type type2 = type;
						return Lua.luaL_error(L, str + ((type2 != null) ? type2.ToString() : null));
					}
					Lua.lua_pushboolean(L, true);
				}
				else
				{
					Lua.lua_pushnil(L);
				}
				result = 1;
			}
			catch (Exception e)
			{
				string str2 = "c# exception in xlua.import_type:";
				Exception ex = e;
				result = Lua.luaL_error(L, str2 + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0004F678 File Offset: 0x0004D878
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportGenericType(IntPtr L)
		{
			int result;
			try
			{
				int top = Lua.lua_gettop(L);
				bool flag = top < 2;
				if (flag)
				{
					result = Lua.luaL_error(L, "import generic type need at lease 2 arguments");
				}
				else
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					string className = Lua.lua_tostring(L, 1);
					bool flag2 = className.EndsWith("<>");
					if (flag2)
					{
						className = className.Substring(0, className.Length - 2);
					}
					Type genericDef = translator.FindType(className + "`" + (top - 1).ToString(), false);
					bool flag3 = genericDef == null || !genericDef.IsGenericTypeDefinition();
					if (flag3)
					{
						Lua.lua_pushnil(L);
					}
					else
					{
						Type[] typeArguments = new Type[top - 1];
						for (int i = 2; i <= top; i++)
						{
							typeArguments[i - 2] = StaticLuaCallbacks.getType(L, translator, i);
							bool flag4 = typeArguments[i - 2] == null;
							if (flag4)
							{
								return Lua.luaL_error(L, "param need a type");
							}
						}
						Type genericInc = genericDef.MakeGenericType(typeArguments);
						translator.GetTypeId(L, genericInc);
						translator.PushAny(L, genericInc);
					}
					result = 1;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in xlua.import_type:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0004F7E4 File Offset: 0x0004D9E4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Cast(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type;
				translator.Get<Type>(L, 2, out type);
				bool flag = type == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "#2 param[" + Lua.lua_tostring(L, 2) + "]is not valid type indicator");
				}
				else
				{
					Lua.luaL_getmetatable(L, type.FullName);
					bool flag2 = Lua.lua_isnil(L, -1);
					if (flag2)
					{
						result = Lua.luaL_error(L, "no gen code for " + Lua.lua_tostring(L, 2));
					}
					else
					{
						Lua.lua_setmetatable(L, 1);
						result = 0;
					}
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in xlua.cast:";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0004F8AC File Offset: 0x0004DAAC
		private static Type getType(IntPtr L, ObjectTranslator translator, int idx)
		{
			bool flag = Lua.lua_type(L, idx) == LuaTypes.LUA_TTABLE;
			Type result;
			if (flag)
			{
				LuaTable tbl;
				translator.Get<LuaTable>(L, idx, out tbl);
				result = tbl.Get<Type>("UnderlyingSystemType");
			}
			else
			{
				bool flag2 = Lua.lua_type(L, idx) == LuaTypes.LUA_TSTRING;
				if (flag2)
				{
					string className = Lua.lua_tostring(L, idx);
					result = translator.FindType(className, false);
				}
				else
				{
					bool flag3 = translator.GetObject(L, idx) is Type;
					if (flag3)
					{
						result = (translator.GetObject(L, idx) as Type);
					}
					else
					{
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0004F934 File Offset: 0x0004DB34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaAccess(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type = StaticLuaCallbacks.getType(L, translator, 1);
				object obj = null;
				bool flag = type == null && Lua.lua_type(L, 1) == LuaTypes.LUA_TUSERDATA;
				if (flag)
				{
					obj = translator.SafeGetCSObj(L, 1);
					bool flag2 = obj == null;
					if (flag2)
					{
						return Lua.luaL_error(L, "xlua.access, #1 parameter must a type/c# object/string");
					}
					type = obj.GetType();
				}
				bool flag3 = type == null;
				if (flag3)
				{
					result = Lua.luaL_error(L, "xlua.access, can not find c# type");
				}
				else
				{
					string fieldName = Lua.lua_tostring(L, 2);
					BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
					bool flag4 = Lua.lua_gettop(L) > 2;
					if (flag4)
					{
						FieldInfo field = type.GetField(fieldName, bindingFlags);
						bool flag5 = field != null;
						if (flag5)
						{
							field.SetValue(obj, translator.GetObject(L, 3, field.FieldType));
							return 0;
						}
						PropertyInfo prop = type.GetProperty(fieldName, bindingFlags);
						bool flag6 = prop != null;
						if (flag6)
						{
							prop.SetValue(obj, translator.GetObject(L, 3, prop.PropertyType), null);
							return 0;
						}
					}
					else
					{
						FieldInfo field2 = type.GetField(fieldName, bindingFlags);
						bool flag7 = field2 != null;
						if (flag7)
						{
							translator.PushAny(L, field2.GetValue(obj));
							return 1;
						}
						PropertyInfo prop2 = type.GetProperty(fieldName, bindingFlags);
						bool flag8 = prop2 != null;
						if (flag8)
						{
							translator.PushAny(L, prop2.GetValue(obj, null));
							return 1;
						}
					}
					result = Lua.luaL_error(L, "xlua.access, no field " + fieldName);
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in xlua.access: ";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0004FB14 File Offset: 0x0004DD14
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaPrivateAccessible(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type = StaticLuaCallbacks.getType(L, translator, 1);
				bool flag = type == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "xlua.private_accessible, can not find c# type");
				}
				else
				{
					while (type != null)
					{
						translator.PrivateAccessible(L, type);
						type = type.BaseType();
					}
					result = 0;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in xlua.private_accessible: ";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0004FBB0 File Offset: 0x0004DDB0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaMetatableOperation(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type = StaticLuaCallbacks.getType(L, translator, 1);
				bool flag = type == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "xlua.metatable_operation, can not find c# type");
				}
				else
				{
					bool is_first = false;
					int type_id = translator.getTypeId(L, type, out is_first, ObjectTranslator.LOGLEVEL.WARN);
					int param_num = Lua.lua_gettop(L);
					bool flag2 = param_num == 1;
					if (flag2)
					{
						Lua.xlua_rawgeti(L, LuaIndexes.LUA_REGISTRYINDEX, (long)type_id);
						result = 1;
					}
					else
					{
						bool flag3 = param_num == 2;
						if (flag3)
						{
							bool flag4 = Lua.lua_type(L, 2) != LuaTypes.LUA_TTABLE;
							if (flag4)
							{
								result = Lua.luaL_error(L, "argument #2 must be a table");
							}
							else
							{
								Lua.lua_pushnumber(L, (double)type_id);
								Lua.xlua_rawseti(L, 2, 1L);
								Lua.xlua_rawseti(L, LuaIndexes.LUA_REGISTRYINDEX, (long)type_id);
								result = 0;
							}
						}
						else
						{
							result = Lua.luaL_error(L, "invalid argument num for xlua.metatable_operation: " + param_num.ToString());
						}
					}
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in xlua.metatable_operation: ";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0004FCD4 File Offset: 0x0004DED4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateConstructor(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type = StaticLuaCallbacks.getType(L, translator, 1);
				bool flag = type == null || !typeof(Delegate).IsAssignableFrom(type);
				if (flag)
				{
					result = Lua.luaL_error(L, "delegate constructor: #1 argument must be a Delegate's type");
				}
				else
				{
					translator.PushAny(L, translator.GetObject(L, 2, type));
					result = 1;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in delegate constructor: ";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0004FD74 File Offset: 0x0004DF74
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToFunction(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MethodBase i;
				translator.Get<MethodBase>(L, 1, out i);
				bool flag = i == null;
				if (flag)
				{
					result = Lua.luaL_error(L, "ToFunction: #1 argument must be a MethodBase");
				}
				else
				{
					translator.PushFixCSFunction(L, new lua_CSFunction(translator.methodWrapsCache._GenMethodWrap(i.DeclaringType, i.Name, new MethodBase[]
					{
						i
					}, false).Call));
					result = 1;
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in ToFunction: ";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0004FE24 File Offset: 0x0004E024
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GenericMethodWraper(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MethodInfo genericMethod;
				translator.Get<MethodInfo>(L, Lua.xlua_upvalueindex(1), out genericMethod);
				int i = Lua.lua_gettop(L);
				Type[] typeArguments = new Type[i];
				for (int j = 0; j < i; j++)
				{
					Type type = StaticLuaCallbacks.getType(L, translator, j + 1);
					bool flag = type == null;
					if (flag)
					{
						return Lua.luaL_error(L, "param #" + (j + 1).ToString() + " is not a type");
					}
					typeArguments[j] = type;
				}
				MethodInfo method = genericMethod.MakeGenericMethod(typeArguments);
				translator.PushFixCSFunction(L, new lua_CSFunction(translator.methodWrapsCache._GenMethodWrap(method.DeclaringType, method.Name, new MethodBase[]
				{
					method
				}, false).Call));
				result = 1;
			}
			catch (Exception e)
			{
				string str = "c# exception in GenericMethodWraper: ";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0004FF40 File Offset: 0x0004E140
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GetGenericMethod(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type = StaticLuaCallbacks.getType(L, translator, 1);
				bool flag = type == null;
				if (flag)
				{
					return Lua.luaL_error(L, "xlua.get_generic_method, can not find c# type");
				}
				string methodName = Lua.lua_tostring(L, 2);
				bool flag2 = string.IsNullOrEmpty(methodName);
				if (flag2)
				{
					return Lua.luaL_error(L, "xlua.get_generic_method, #2 param need a string");
				}
				List<MethodInfo> matchMethods = new List<MethodInfo>();
				foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
				{
					bool flag3 = method.Name == methodName && method.IsGenericMethodDefinition;
					if (flag3)
					{
						matchMethods.Add(method);
					}
				}
				int methodIdx = 0;
				bool flag4 = matchMethods.Count == 0;
				if (flag4)
				{
					Lua.lua_pushnil(L);
				}
				else
				{
					bool flag5 = Lua.lua_isinteger(L, 3);
					if (flag5)
					{
						methodIdx = Lua.xlua_tointeger(L, 3);
					}
					translator.PushAny(L, matchMethods[methodIdx]);
					Lua.lua_pushstdcallcfunction(L, new lua_CSFunction(StaticLuaCallbacks.GenericMethodWraper), 1);
				}
			}
			catch (Exception e)
			{
				string str = "c# exception in xlua.get_generic_method: ";
				Exception ex = e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000500B0 File Offset: 0x0004E2B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ReleaseCsObject(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.ReleaseCSObj(L, 1);
				result = 0;
			}
			catch (Exception e)
			{
				string str = "c# exception in ReleaseCsObject: ";
				Exception ex = e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x04000CA1 RID: 3233
		internal lua_CSFunction GcMeta;

		// Token: 0x04000CA2 RID: 3234
		internal lua_CSFunction ToStringMeta;

		// Token: 0x04000CA3 RID: 3235
		internal lua_CSFunction EnumAndMeta;

		// Token: 0x04000CA4 RID: 3236
		internal lua_CSFunction EnumOrMeta;

		// Token: 0x04000CA5 RID: 3237
		internal lua_CSFunction StaticCSFunctionWraper;

		// Token: 0x04000CA6 RID: 3238
		internal lua_CSFunction FixCSFunctionWraper;

		// Token: 0x04000CA7 RID: 3239
		internal lua_CSFunction DelegateCtor;
	}
}

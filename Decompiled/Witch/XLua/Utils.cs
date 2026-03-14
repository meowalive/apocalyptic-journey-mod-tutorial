using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000183 RID: 387
	public static class Utils
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x0005AEA0 File Offset: 0x000590A0
		public static bool LoadField(IntPtr L, int idx, string field_name)
		{
			idx = ((idx > 0) ? idx : (Lua.lua_gettop(L) + idx + 1));
			Lua.xlua_pushasciistring(L, field_name);
			Lua.lua_rawget(L, idx);
			return !Lua.lua_isnil(L, -1);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0005AEE0 File Offset: 0x000590E0
		public static IntPtr GetMainState(IntPtr L)
		{
			IntPtr ret = 0;
			Lua.xlua_pushasciistring(L, "xlua_main_thread");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			bool flag = Lua.lua_isthread(L, -1);
			if (flag)
			{
				ret = Lua.lua_tothread(L, -1);
			}
			Lua.lua_pop(L, 1);
			return ret;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0005AF30 File Offset: 0x00059130
		public static List<Type> GetAllTypes(bool exclude_generic_definition = true)
		{
			List<Type> allTypes = new List<Type>();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			Func<Type, bool> <>9__0;
			for (int i = 0; i < assemblies.Length; i++)
			{
				try
				{
					bool flag = !(assemblies[i].ManifestModule is ModuleBuilder);
					if (flag)
					{
						List<Type> list = allTypes;
						IEnumerable<Type> types = assemblies[i].GetTypes();
						Func<Type, bool> predicate;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = ((Type type) => !exclude_generic_definition || !type.IsGenericTypeDefinition()));
						}
						list.AddRange(types.Where(predicate));
					}
				}
				catch (Exception)
				{
				}
			}
			return allTypes;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0005AFE4 File Offset: 0x000591E4
		private static lua_CSFunction genFieldGetter(Type type, FieldInfo field)
		{
			bool isStatic = field.IsStatic;
			lua_CSFunction result;
			if (isStatic)
			{
				result = delegate(IntPtr L)
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					translator.PushAny(L, field.GetValue(null));
					return 1;
				};
			}
			else
			{
				result = delegate(IntPtr L)
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					object obj = translator.FastGetCSObj(L, 1);
					bool flag = obj == null || !type.IsInstanceOfType(obj);
					int result2;
					if (flag)
					{
						string[] array = new string[6];
						array[0] = "Expected type ";
						int num = 1;
						Type type2 = type;
						array[num] = ((type2 != null) ? type2.ToString() : null);
						array[2] = ", but got ";
						array[3] = ((obj == null) ? "null" : obj.GetType().ToString());
						array[4] = ", while get field ";
						int num2 = 5;
						FieldInfo field2 = field;
						array[num2] = ((field2 != null) ? field2.ToString() : null);
						result2 = Lua.luaL_error(L, string.Concat(array));
					}
					else
					{
						translator.PushAny(L, field.GetValue(obj));
						result2 = 1;
					}
					return result2;
				};
			}
			return result;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0005B038 File Offset: 0x00059238
		private static lua_CSFunction genFieldSetter(Type type, FieldInfo field)
		{
			bool isStatic = field.IsStatic;
			lua_CSFunction result;
			if (isStatic)
			{
				result = delegate(IntPtr L)
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					object val = translator.GetObject(L, 1, field.FieldType);
					bool flag = field.FieldType.IsValueType() && Nullable.GetUnderlyingType(field.FieldType) == null && val == null;
					int result2;
					if (flag)
					{
						string[] array = new string[5];
						array[0] = type.Name;
						array[1] = ".";
						array[2] = field.Name;
						array[3] = " Expected type ";
						int num = 4;
						Type fieldType = field.FieldType;
						array[num] = ((fieldType != null) ? fieldType.ToString() : null);
						result2 = Lua.luaL_error(L, string.Concat(array));
					}
					else
					{
						field.SetValue(null, val);
						result2 = 0;
					}
					return result2;
				};
			}
			else
			{
				result = delegate(IntPtr L)
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					object obj = translator.FastGetCSObj(L, 1);
					bool flag = obj == null || !type.IsInstanceOfType(obj);
					int result2;
					if (flag)
					{
						string[] array = new string[6];
						array[0] = "Expected type ";
						int num = 1;
						Type type2 = type;
						array[num] = ((type2 != null) ? type2.ToString() : null);
						array[2] = ", but got ";
						array[3] = ((obj == null) ? "null" : obj.GetType().ToString());
						array[4] = ", while set field ";
						int num2 = 5;
						FieldInfo field2 = field;
						array[num2] = ((field2 != null) ? field2.ToString() : null);
						result2 = Lua.luaL_error(L, string.Concat(array));
					}
					else
					{
						object val = translator.GetObject(L, 2, field.FieldType);
						bool flag2 = field.FieldType.IsValueType() && Nullable.GetUnderlyingType(field.FieldType) == null && val == null;
						if (flag2)
						{
							string[] array2 = new string[5];
							array2[0] = type.Name;
							array2[1] = ".";
							array2[2] = field.Name;
							array2[3] = " Expected type ";
							int num3 = 4;
							Type fieldType = field.FieldType;
							array2[num3] = ((fieldType != null) ? fieldType.ToString() : null);
							result2 = Lua.luaL_error(L, string.Concat(array2));
						}
						else
						{
							field.SetValue(obj, val);
							bool flag3 = type.IsValueType();
							if (flag3)
							{
								translator.Update(L, 1, obj);
							}
							result2 = 0;
						}
					}
					return result2;
				};
			}
			return result;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0005B08C File Offset: 0x0005928C
		private static lua_CSFunction genItemGetter(Type type, PropertyInfo[] props)
		{
			props = (from prop in props
			where !prop.GetIndexParameters()[0].ParameterType.IsAssignableFrom(typeof(string))
			select prop).ToArray<PropertyInfo>();
			bool flag = props.Length == 0;
			lua_CSFunction result;
			if (flag)
			{
				result = null;
			}
			else
			{
				Type[] params_type = new Type[props.Length];
				for (int i = 0; i < props.Length; i++)
				{
					params_type[i] = props[i].GetIndexParameters()[0].ParameterType;
				}
				object[] arg = new object[1];
				result = delegate(IntPtr L)
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					object obj = translator.FastGetCSObj(L, 1);
					bool flag2 = obj == null || !type.IsInstanceOfType(obj);
					int result2;
					if (flag2)
					{
						string[] array = new string[6];
						array[0] = "Expected type ";
						int num = 1;
						Type type2 = type;
						array[num] = ((type2 != null) ? type2.ToString() : null);
						array[2] = ", but got ";
						array[3] = ((obj == null) ? "null" : obj.GetType().ToString());
						array[4] = ", while get prop ";
						array[5] = props[0].Name;
						result2 = Lua.luaL_error(L, string.Concat(array));
					}
					else
					{
						for (int j = 0; j < props.Length; j++)
						{
							bool flag3 = !translator.Assignable(L, 2, params_type[j]);
							if (!flag3)
							{
								PropertyInfo prop = props[j];
								try
								{
									object index = translator.GetObject(L, 2, params_type[j]);
									arg[0] = index;
									object ret = prop.GetValue(obj, arg);
									Lua.lua_pushboolean(L, true);
									translator.PushAny(L, ret);
									return 2;
								}
								catch (Exception e)
								{
									string[] array2 = new string[8];
									array2[0] = "try to get ";
									int num2 = 1;
									Type type3 = type;
									array2[num2] = ((type3 != null) ? type3.ToString() : null);
									array2[2] = ".";
									array2[3] = prop.Name;
									array2[4] = " throw a exception:";
									int num3 = 5;
									Exception ex = e;
									array2[num3] = ((ex != null) ? ex.ToString() : null);
									array2[6] = ",stack:";
									array2[7] = e.StackTrace;
									return Lua.luaL_error(L, string.Concat(array2));
								}
							}
						}
						Lua.lua_pushboolean(L, false);
						result2 = 1;
					}
					return result2;
				};
			}
			return result;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0005B15C File Offset: 0x0005935C
		private static lua_CSFunction genItemSetter(Type type, PropertyInfo[] props)
		{
			props = (from prop in props
			where !prop.GetIndexParameters()[0].ParameterType.IsAssignableFrom(typeof(string))
			select prop).ToArray<PropertyInfo>();
			bool flag = props.Length == 0;
			lua_CSFunction result;
			if (flag)
			{
				result = null;
			}
			else
			{
				Type[] params_type = new Type[props.Length];
				for (int i = 0; i < props.Length; i++)
				{
					params_type[i] = props[i].GetIndexParameters()[0].ParameterType;
				}
				object[] arg = new object[1];
				result = delegate(IntPtr L)
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					object obj = translator.FastGetCSObj(L, 1);
					bool flag2 = obj == null || !type.IsInstanceOfType(obj);
					int result2;
					if (flag2)
					{
						string[] array = new string[6];
						array[0] = "Expected type ";
						int num = 1;
						Type type2 = type;
						array[num] = ((type2 != null) ? type2.ToString() : null);
						array[2] = ", but got ";
						array[3] = ((obj == null) ? "null" : obj.GetType().ToString());
						array[4] = ", while set prop ";
						array[5] = props[0].Name;
						result2 = Lua.luaL_error(L, string.Concat(array));
					}
					else
					{
						for (int j = 0; j < props.Length; j++)
						{
							bool flag3 = !translator.Assignable(L, 2, params_type[j]);
							if (!flag3)
							{
								PropertyInfo prop = props[j];
								try
								{
									arg[0] = translator.GetObject(L, 2, params_type[j]);
									object val = translator.GetObject(L, 3, prop.PropertyType);
									bool flag4 = val == null;
									if (flag4)
									{
										string[] array2 = new string[5];
										array2[0] = type.Name;
										array2[1] = ".";
										array2[2] = prop.Name;
										array2[3] = " Expected type ";
										int num2 = 4;
										Type propertyType = prop.PropertyType;
										array2[num2] = ((propertyType != null) ? propertyType.ToString() : null);
										return Lua.luaL_error(L, string.Concat(array2));
									}
									prop.SetValue(obj, val, arg);
									Lua.lua_pushboolean(L, true);
									return 1;
								}
								catch (Exception e)
								{
									string[] array3 = new string[8];
									array3[0] = "try to set ";
									int num3 = 1;
									Type type3 = type;
									array3[num3] = ((type3 != null) ? type3.ToString() : null);
									array3[2] = ".";
									array3[3] = prop.Name;
									array3[4] = " throw a exception:";
									int num4 = 5;
									Exception ex = e;
									array3[num4] = ((ex != null) ? ex.ToString() : null);
									array3[6] = ",stack:";
									array3[7] = e.StackTrace;
									return Lua.luaL_error(L, string.Concat(array3));
								}
							}
						}
						Lua.lua_pushboolean(L, false);
						result2 = 1;
					}
					return result2;
				};
			}
			return result;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0005B22C File Offset: 0x0005942C
		private static lua_CSFunction genEnumCastFrom(Type type)
		{
			return delegate(IntPtr L)
			{
				int result;
				try
				{
					ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
					result = translator.TranslateToEnumToTop(L, type, 1);
				}
				catch (Exception e)
				{
					string str = "cast to ";
					Type type2 = type;
					string str2 = (type2 != null) ? type2.ToString() : null;
					string str3 = " exception:";
					Exception ex = e;
					result = Lua.luaL_error(L, str + str2 + str3 + ((ex != null) ? ex.ToString() : null));
				}
				return result;
			};
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0005B258 File Offset: 0x00059458
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(Type type_to_be_extend)
		{
			bool flag = InternalGlobals.extensionMethodMap == null;
			if (flag)
			{
				List<Type> type_def_extention_method = new List<Type>();
				IEnumerator<Type> enumerator = Utils.GetAllTypes(true).GetEnumerator();
				while (enumerator.MoveNext())
				{
					Type type2 = enumerator.Current;
					bool flag2 = type2.IsDefined(typeof(ExtensionAttribute), false) && (type2.IsDefined(typeof(ReflectionUseAttribute), false) || type2.IsDefined(typeof(LuaCallCSharpAttribute), false));
					if (flag2)
					{
						type_def_extention_method.Add(type2);
					}
					bool flag3 = !type2.IsAbstract() || !type2.IsSealed();
					if (!flag3)
					{
						foreach (FieldInfo field in type2.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
						{
							bool flag4 = (field.IsDefined(typeof(ReflectionUseAttribute), false) || field.IsDefined(typeof(LuaCallCSharpAttribute), false)) && typeof(IEnumerable<Type>).IsAssignableFrom(field.FieldType);
							if (flag4)
							{
								type_def_extention_method.AddRange(from t in field.GetValue(null) as IEnumerable<Type>
								where t.IsDefined(typeof(ExtensionAttribute), false)
								select t);
							}
						}
						foreach (PropertyInfo prop in type2.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
						{
							bool flag5 = (prop.IsDefined(typeof(ReflectionUseAttribute), false) || prop.IsDefined(typeof(LuaCallCSharpAttribute), false)) && typeof(IEnumerable<Type>).IsAssignableFrom(prop.PropertyType);
							if (flag5)
							{
								type_def_extention_method.AddRange(from t in prop.GetValue(null, null) as IEnumerable<Type>
								where t.IsDefined(typeof(ExtensionAttribute), false)
								select t);
							}
						}
					}
				}
				enumerator.Dispose();
				InternalGlobals.extensionMethodMap = (from type in type_def_extention_method
				from method in type.GetMethods(BindingFlags.Static | BindingFlags.Public)
				where method.IsDefined(typeof(ExtensionAttribute), false) && Utils.IsSupportedMethod(method)
				group method by Utils.getExtendedType(method)).ToDictionary((IGrouping<Type, MethodInfo> g) => g.Key, (IGrouping<Type, MethodInfo> g) => g);
			}
			IEnumerable<MethodInfo> ret = null;
			InternalGlobals.extensionMethodMap.TryGetValue(type_to_be_extend, out ret);
			return ret;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0005B5A0 File Offset: 0x000597A0
		private static void makeReflectionWrap(IntPtr L, Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, BindingFlags access)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			BindingFlags flag = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | access;
			FieldInfo[] fields = type.GetFields(flag);
			EventInfo[] all_events = type.GetEvents(flag | BindingFlags.Public | BindingFlags.NonPublic);
			Lua.lua_checkstack(L, 2);
			for (int i = 0; i < fields.Length; i++)
			{
				FieldInfo field = fields[i];
				string fieldName = field.Name;
				bool flag2 = field.IsStatic && (field.Name.StartsWith("__Hotfix") || field.Name.StartsWith("_c__Hotfix")) && typeof(Delegate).IsAssignableFrom(field.FieldType);
				if (!flag2)
				{
					bool flag3 = all_events.Any((EventInfo e) => e.Name == fieldName);
					if (flag3)
					{
						fieldName = "&" + fieldName;
					}
					bool flag4 = field.IsStatic && (field.IsInitOnly || field.IsLiteral);
					if (flag4)
					{
						Lua.xlua_pushasciistring(L, fieldName);
						translator.PushAny(L, field.GetValue(null));
						Lua.lua_rawset(L, cls_field);
					}
					else
					{
						Lua.xlua_pushasciistring(L, fieldName);
						translator.PushFixCSFunction(L, Utils.genFieldGetter(type, field));
						Lua.lua_rawset(L, field.IsStatic ? cls_getter : obj_getter);
						Lua.xlua_pushasciistring(L, fieldName);
						translator.PushFixCSFunction(L, Utils.genFieldSetter(type, field));
						Lua.lua_rawset(L, field.IsStatic ? cls_setter : obj_setter);
					}
				}
			}
			foreach (EventInfo eventInfo in type.GetEvents(flag))
			{
				Lua.xlua_pushasciistring(L, eventInfo.Name);
				translator.PushFixCSFunction(L, translator.methodWrapsCache.GetEventWrap(type, eventInfo.Name));
				Lua.lua_rawset(L, ((eventInfo.GetAddMethod(true) != null) ? eventInfo.GetAddMethod(true).IsStatic : eventInfo.GetRemoveMethod(true).IsStatic) ? cls_field : obj_field);
			}
			List<PropertyInfo> items = new List<PropertyInfo>();
			foreach (PropertyInfo prop in type.GetProperties(flag))
			{
				bool flag5 = prop.GetIndexParameters().Length != 0;
				if (flag5)
				{
					items.Add(prop);
				}
			}
			PropertyInfo[] item_array = items.ToArray();
			item_getter = ((item_array.Length != 0) ? Utils.genItemGetter(type, item_array) : null);
			item_setter = ((item_array.Length != 0) ? Utils.genItemSetter(type, item_array) : null);
			MethodInfo[] methods = type.GetMethods(flag);
			bool flag6 = access == BindingFlags.NonPublic;
			if (flag6)
			{
				methods = (from p in type.GetMethods(flag | BindingFlags.Public)
				join q in methods on p.Name equals q.Name
				select p).ToArray<MethodInfo>();
			}
			Dictionary<Utils.MethodKey, List<MemberInfo>> pending_methods = new Dictionary<Utils.MethodKey, List<MemberInfo>>();
			foreach (MethodInfo method in methods)
			{
				string method_name = method.Name;
				Utils.MethodKey method_key = new Utils.MethodKey
				{
					Name = method_name,
					IsStatic = method.IsStatic
				};
				List<MemberInfo> overloads;
				bool flag7 = pending_methods.TryGetValue(method_key, out overloads);
				if (flag7)
				{
					overloads.Add(method);
				}
				else
				{
					bool flag8 = method.IsSpecialName && ((method.Name == "get_Item" && method.GetParameters().Length == 1) || (method.Name == "set_Item" && method.GetParameters().Length == 2));
					if (flag8)
					{
						bool flag9 = !method.GetParameters()[0].ParameterType.IsAssignableFrom(typeof(string));
						if (flag9)
						{
							goto IL_640;
						}
					}
					bool flag10 = (method_name.StartsWith("add_") || method_name.StartsWith("remove_")) && method.IsSpecialName;
					if (!flag10)
					{
						bool flag11 = method_name.StartsWith("op_") && method.IsSpecialName;
						if (flag11)
						{
							bool flag12 = InternalGlobals.supportOp.ContainsKey(method_name);
							if (flag12)
							{
								bool flag13 = overloads == null;
								if (flag13)
								{
									overloads = new List<MemberInfo>();
									pending_methods.Add(method_key, overloads);
								}
								overloads.Add(method);
							}
						}
						else
						{
							bool flag14 = method_name.StartsWith("get_") && method.IsSpecialName && method.GetParameters().Length != 1;
							if (flag14)
							{
								string prop_name = method.Name.Substring(4);
								Lua.xlua_pushasciistring(L, prop_name);
								translator.PushFixCSFunction(L, new lua_CSFunction(translator.methodWrapsCache._GenMethodWrap(method.DeclaringType, prop_name, new MethodBase[]
								{
									method
								}, false).Call));
								Lua.lua_rawset(L, method.IsStatic ? cls_getter : obj_getter);
							}
							else
							{
								bool flag15 = method_name.StartsWith("set_") && method.IsSpecialName && method.GetParameters().Length != 2;
								if (flag15)
								{
									string prop_name2 = method.Name.Substring(4);
									Lua.xlua_pushasciistring(L, prop_name2);
									translator.PushFixCSFunction(L, new lua_CSFunction(translator.methodWrapsCache._GenMethodWrap(method.DeclaringType, prop_name2, new MethodBase[]
									{
										method
									}, false).Call));
									Lua.lua_rawset(L, method.IsStatic ? cls_setter : obj_setter);
								}
								else
								{
									bool flag16 = method_name == ".ctor" && method.IsConstructor;
									if (!flag16)
									{
										bool flag17 = overloads == null;
										if (flag17)
										{
											overloads = new List<MemberInfo>();
											pending_methods.Add(method_key, overloads);
										}
										overloads.Add(method);
									}
								}
							}
						}
					}
				}
				IL_640:;
			}
			IEnumerable<MethodInfo> extend_methods = Utils.GetExtensionMethodsOf(type);
			bool flag18 = extend_methods != null;
			if (flag18)
			{
				foreach (MethodInfo extend_method in extend_methods)
				{
					Utils.MethodKey method_key2 = new Utils.MethodKey
					{
						Name = extend_method.Name,
						IsStatic = false
					};
					List<MemberInfo> overloads2;
					bool flag19 = pending_methods.TryGetValue(method_key2, out overloads2);
					if (flag19)
					{
						overloads2.Add(extend_method);
					}
					else
					{
						overloads2 = new List<MemberInfo>
						{
							extend_method
						};
						pending_methods.Add(method_key2, overloads2);
					}
				}
			}
			foreach (KeyValuePair<Utils.MethodKey, List<MemberInfo>> kv in pending_methods)
			{
				bool flag20 = kv.Key.Name.StartsWith("op_");
				if (flag20)
				{
					Lua.xlua_pushasciistring(L, InternalGlobals.supportOp[kv.Key.Name]);
					translator.PushFixCSFunction(L, new lua_CSFunction(translator.methodWrapsCache._GenMethodWrap(type, kv.Key.Name, kv.Value.ToArray(), false).Call));
					Lua.lua_rawset(L, obj_meta);
				}
				else
				{
					Lua.xlua_pushasciistring(L, kv.Key.Name);
					translator.PushFixCSFunction(L, new lua_CSFunction(translator.methodWrapsCache._GenMethodWrap(type, kv.Key.Name, kv.Value.ToArray(), false).Call));
					Lua.lua_rawset(L, kv.Key.IsStatic ? cls_field : obj_field);
				}
			}
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0005BDFC File Offset: 0x00059FFC
		public static void loadUpvalue(IntPtr L, Type type, string metafunc, int index)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Lua.xlua_pushasciistring(L, metafunc);
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			translator.Push(L, type);
			Lua.lua_rawget(L, -2);
			Lua.lua_remove(L, -2);
			for (int i = 1; i <= index; i++)
			{
				Lua.lua_getupvalue(L, -i, i);
				bool flag = Lua.lua_isnil(L, -1);
				if (flag)
				{
					Lua.lua_pop(L, 1);
					Lua.lua_newtable(L);
					Lua.lua_pushvalue(L, -1);
					Lua.lua_setupvalue(L, -i - 2, i);
				}
			}
			for (int j = 0; j < index; j++)
			{
				Lua.lua_remove(L, -2);
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0005BEB8 File Offset: 0x0005A0B8
		public static void RegisterEnumType(IntPtr L, Type type)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			foreach (string name in Enum.GetNames(type))
			{
				Utils.RegisterObject(L, translator, -4, name, Enum.Parse(type, name));
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0005BF00 File Offset: 0x0005A100
		public static void MakePrivateAccessible(IntPtr L, Type type)
		{
			Lua.lua_checkstack(L, 20);
			int oldTop = Lua.lua_gettop(L);
			Lua.luaL_getmetatable(L, type.FullName);
			bool flag = Lua.lua_isnil(L, -1);
			if (flag)
			{
				Lua.lua_settop(L, oldTop);
				throw new Exception("can not find the metatable for " + ((type != null) ? type.ToString() : null));
			}
			int obj_meta = Lua.lua_gettop(L);
			Utils.LoadCSTable(L, type);
			bool flag2 = Lua.lua_isnil(L, -1);
			if (flag2)
			{
				Lua.lua_settop(L, oldTop);
				throw new Exception("can not find the class for " + ((type != null) ? type.ToString() : null));
			}
			int cls_field = Lua.lua_gettop(L);
			Utils.loadUpvalue(L, type, "LuaIndexs", 2);
			int obj_getter = Lua.lua_gettop(L);
			Utils.loadUpvalue(L, type, "LuaIndexs", 1);
			int obj_field = Lua.lua_gettop(L);
			Utils.loadUpvalue(L, type, "LuaNewIndexs", 1);
			int obj_setter = Lua.lua_gettop(L);
			Utils.loadUpvalue(L, type, "LuaClassIndexs", 1);
			int cls_getter = Lua.lua_gettop(L);
			Utils.loadUpvalue(L, type, "LuaClassNewIndexs", 1);
			int cls_setter = Lua.lua_gettop(L);
			lua_CSFunction item_getter;
			lua_CSFunction item_setter;
			Utils.makeReflectionWrap(L, type, cls_field, cls_getter, cls_setter, obj_field, obj_getter, obj_setter, obj_meta, out item_getter, out item_setter, BindingFlags.NonPublic);
			Lua.lua_settop(L, oldTop);
			foreach (Type nested_type in type.GetNestedTypes(BindingFlags.NonPublic))
			{
				bool flag3 = (!nested_type.IsAbstract() && typeof(Delegate).IsAssignableFrom(nested_type)) || nested_type.IsGenericTypeDefinition();
				if (!flag3)
				{
					ObjectTranslatorPool.Instance.Find(L).TryDelayWrapLoader(L, nested_type);
					Utils.MakePrivateAccessible(L, nested_type);
				}
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0005C0A8 File Offset: 0x0005A2A8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LazyReflectionCall(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Type type;
				translator.Get<Type>(L, Lua.xlua_upvalueindex(1), out type);
				LazyMemberTypes memberType = (LazyMemberTypes)Lua.xlua_tointeger(L, Lua.xlua_upvalueindex(2));
				string memberName = Lua.lua_tostring(L, Lua.xlua_upvalueindex(3));
				bool isStatic = Lua.lua_toboolean(L, Lua.xlua_upvalueindex(4));
				lua_CSFunction wrap;
				switch (memberType)
				{
				case LazyMemberTypes.Method:
				{
					MemberInfo[] members = type.GetMember(memberName);
					bool flag = members == null || members.Length == 0;
					if (flag)
					{
						string str = "can not find ";
						string memberName5 = memberName;
						string str2 = " for ";
						Type type2 = type;
						return Lua.luaL_error(L, str + memberName5 + str2 + ((type2 != null) ? type2.ToString() : null));
					}
					IEnumerable<MemberInfo> methods = members;
					bool flag2 = !isStatic;
					if (flag2)
					{
						IEnumerable<MethodInfo> extensionMethods = Utils.GetExtensionMethodsOf(type);
						bool flag3 = extensionMethods != null;
						if (flag3)
						{
							methods = methods.Concat((from m in extensionMethods
							where m.Name == memberName
							select m).Cast<MemberInfo>());
						}
					}
					wrap = new lua_CSFunction(translator.methodWrapsCache._GenMethodWrap(type, memberName, methods.ToArray<MemberInfo>(), false).Call);
					bool flag4 = isStatic;
					if (flag4)
					{
						Utils.LoadCSTable(L, type);
					}
					else
					{
						Utils.loadUpvalue(L, type, "LuaIndexs", 1);
					}
					bool flag5 = Lua.lua_isnil(L, -1);
					if (flag5)
					{
						string str3 = "can not find the meta info for ";
						Type type3 = type;
						return Lua.luaL_error(L, str3 + ((type3 != null) ? type3.ToString() : null));
					}
					break;
				}
				case LazyMemberTypes.FieldGet:
				case LazyMemberTypes.FieldSet:
				{
					FieldInfo field = type.GetField(memberName);
					bool flag6 = field == null;
					if (flag6)
					{
						string str4 = "can not find ";
						string memberName2 = memberName;
						string str5 = " for ";
						Type type4 = type;
						return Lua.luaL_error(L, str4 + memberName2 + str5 + ((type4 != null) ? type4.ToString() : null));
					}
					bool flag7 = isStatic;
					if (flag7)
					{
						bool flag8 = memberType == LazyMemberTypes.FieldGet;
						if (flag8)
						{
							Utils.loadUpvalue(L, type, "LuaClassIndexs", 1);
						}
						else
						{
							Utils.loadUpvalue(L, type, "LuaClassNewIndexs", 1);
						}
					}
					else
					{
						bool flag9 = memberType == LazyMemberTypes.FieldGet;
						if (flag9)
						{
							Utils.loadUpvalue(L, type, "LuaIndexs", 2);
						}
						else
						{
							Utils.loadUpvalue(L, type, "LuaNewIndexs", 1);
						}
					}
					wrap = ((memberType == LazyMemberTypes.FieldGet) ? Utils.genFieldGetter(type, field) : Utils.genFieldSetter(type, field));
					break;
				}
				case LazyMemberTypes.PropertyGet:
				case LazyMemberTypes.PropertySet:
				{
					PropertyInfo prop = type.GetProperty(memberName);
					bool flag10 = prop == null;
					if (flag10)
					{
						string str6 = "can not find ";
						string memberName3 = memberName;
						string str7 = " for ";
						Type type5 = type;
						return Lua.luaL_error(L, str6 + memberName3 + str7 + ((type5 != null) ? type5.ToString() : null));
					}
					bool flag11 = isStatic;
					if (flag11)
					{
						bool flag12 = memberType == LazyMemberTypes.PropertyGet;
						if (flag12)
						{
							Utils.loadUpvalue(L, type, "LuaClassIndexs", 1);
						}
						else
						{
							Utils.loadUpvalue(L, type, "LuaClassNewIndexs", 1);
						}
					}
					else
					{
						bool flag13 = memberType == LazyMemberTypes.PropertyGet;
						if (flag13)
						{
							Utils.loadUpvalue(L, type, "LuaIndexs", 2);
						}
						else
						{
							Utils.loadUpvalue(L, type, "LuaNewIndexs", 1);
						}
					}
					bool flag14 = Lua.lua_isnil(L, -1);
					if (flag14)
					{
						string str8 = "can not find the meta info for ";
						Type type6 = type;
						return Lua.luaL_error(L, str8 + ((type6 != null) ? type6.ToString() : null));
					}
					wrap = new lua_CSFunction(translator.methodWrapsCache._GenMethodWrap(prop.DeclaringType, prop.Name, new MethodBase[]
					{
						(memberType == LazyMemberTypes.PropertyGet) ? prop.GetGetMethod() : prop.GetSetMethod()
					}, false).Call);
					break;
				}
				case LazyMemberTypes.Event:
				{
					EventInfo eventInfo = type.GetEvent(memberName);
					bool flag15 = eventInfo == null;
					if (flag15)
					{
						string str9 = "can not find ";
						string memberName4 = memberName;
						string str10 = " for ";
						Type type7 = type;
						return Lua.luaL_error(L, str9 + memberName4 + str10 + ((type7 != null) ? type7.ToString() : null));
					}
					bool flag16 = isStatic;
					if (flag16)
					{
						Utils.LoadCSTable(L, type);
					}
					else
					{
						Utils.loadUpvalue(L, type, "LuaIndexs", 1);
					}
					bool flag17 = Lua.lua_isnil(L, -1);
					if (flag17)
					{
						string str11 = "can not find the meta info for ";
						Type type8 = type;
						return Lua.luaL_error(L, str11 + ((type8 != null) ? type8.ToString() : null));
					}
					wrap = translator.methodWrapsCache.GetEventWrap(type, eventInfo.Name);
					break;
				}
				default:
					return Lua.luaL_error(L, "unsupport member type" + memberType.ToString());
				}
				Lua.xlua_pushasciistring(L, memberName);
				translator.PushFixCSFunction(L, wrap);
				Lua.lua_rawset(L, -3);
				Lua.lua_pop(L, 1);
				result = wrap(L);
			}
			catch (Exception e)
			{
				string str12 = "c# exception in LazyReflectionCall:";
				Exception ex = e;
				result = Lua.luaL_error(L, str12 + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0005C59C File Offset: 0x0005A79C
		public static void ReflectionWrap(IntPtr L, Type type, bool privateAccessible)
		{
			Lua.lua_checkstack(L, 20);
			int top_enter = Lua.lua_gettop(L);
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Lua.luaL_getmetatable(L, type.FullName);
			bool flag = Lua.lua_isnil(L, -1);
			if (flag)
			{
				Lua.lua_pop(L, 1);
				Lua.luaL_newmetatable(L, type.FullName);
			}
			Lua.lua_pushlightuserdata(L, Lua.xlua_tag());
			Lua.lua_pushnumber(L, 1.0);
			Lua.lua_rawset(L, -3);
			int obj_meta = Lua.lua_gettop(L);
			Lua.lua_newtable(L);
			int cls_meta = Lua.lua_gettop(L);
			Lua.lua_newtable(L);
			int obj_field = Lua.lua_gettop(L);
			Lua.lua_newtable(L);
			int obj_getter = Lua.lua_gettop(L);
			Lua.lua_newtable(L);
			int obj_setter = Lua.lua_gettop(L);
			Lua.lua_newtable(L);
			int cls_field = Lua.lua_gettop(L);
			Utils.SetCSTable(L, type, cls_field);
			Lua.lua_newtable(L);
			int cls_getter = Lua.lua_gettop(L);
			Lua.lua_newtable(L);
			int cls_setter = Lua.lua_gettop(L);
			lua_CSFunction item_getter;
			lua_CSFunction item_setter;
			Utils.makeReflectionWrap(L, type, cls_field, cls_getter, cls_setter, obj_field, obj_getter, obj_setter, obj_meta, out item_getter, out item_setter, privateAccessible ? (BindingFlags.Public | BindingFlags.NonPublic) : BindingFlags.Public);
			Lua.xlua_pushasciistring(L, "__gc");
			Lua.lua_pushstdcallcfunction(L, translator.metaFunctions.GcMeta, 0);
			Lua.lua_rawset(L, obj_meta);
			Lua.xlua_pushasciistring(L, "__tostring");
			Lua.lua_pushstdcallcfunction(L, translator.metaFunctions.ToStringMeta, 0);
			Lua.lua_rawset(L, obj_meta);
			Lua.xlua_pushasciistring(L, "__index");
			Lua.lua_pushvalue(L, obj_field);
			Lua.lua_pushvalue(L, obj_getter);
			translator.PushFixCSFunction(L, item_getter);
			translator.PushAny(L, type.BaseType());
			Lua.xlua_pushasciistring(L, "LuaIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.lua_pushnil(L);
			Lua.gen_obj_indexer(L);
			Lua.xlua_pushasciistring(L, "LuaIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			translator.Push(L, type);
			Lua.lua_pushvalue(L, -3);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
			Lua.lua_rawset(L, obj_meta);
			Lua.xlua_pushasciistring(L, "__newindex");
			Lua.lua_pushvalue(L, obj_setter);
			translator.PushFixCSFunction(L, item_setter);
			translator.Push(L, type.BaseType());
			Lua.xlua_pushasciistring(L, "LuaNewIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.lua_pushnil(L);
			Lua.gen_obj_newindexer(L);
			Lua.xlua_pushasciistring(L, "LuaNewIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			translator.Push(L, type);
			Lua.lua_pushvalue(L, -3);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
			Lua.lua_rawset(L, obj_meta);
			Lua.xlua_pushasciistring(L, "UnderlyingSystemType");
			translator.PushAny(L, type);
			Lua.lua_rawset(L, cls_field);
			bool flag2 = type != null && type.IsEnum();
			if (flag2)
			{
				Lua.xlua_pushasciistring(L, "__CastFrom");
				translator.PushFixCSFunction(L, Utils.genEnumCastFrom(type));
				Lua.lua_rawset(L, cls_field);
			}
			Lua.xlua_pushasciistring(L, "__index");
			Lua.lua_pushvalue(L, cls_getter);
			Lua.lua_pushvalue(L, cls_field);
			translator.Push(L, type.BaseType());
			Lua.xlua_pushasciistring(L, "LuaClassIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.gen_cls_indexer(L);
			Lua.xlua_pushasciistring(L, "LuaClassIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			translator.Push(L, type);
			Lua.lua_pushvalue(L, -3);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
			Lua.lua_rawset(L, cls_meta);
			Lua.xlua_pushasciistring(L, "__newindex");
			Lua.lua_pushvalue(L, cls_setter);
			translator.Push(L, type.BaseType());
			Lua.xlua_pushasciistring(L, "LuaClassNewIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.gen_cls_newindexer(L);
			Lua.xlua_pushasciistring(L, "LuaClassNewIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			translator.Push(L, type);
			Lua.lua_pushvalue(L, -3);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
			Lua.lua_rawset(L, cls_meta);
			lua_CSFunction constructor = typeof(Delegate).IsAssignableFrom(type) ? translator.metaFunctions.DelegateCtor : translator.methodWrapsCache.GetConstructorWrap(type);
			bool flag3 = constructor == null;
			if (flag3)
			{
				constructor = delegate(IntPtr LL)
				{
					string str = "No constructor for ";
					Type type2 = type;
					return Lua.luaL_error(LL, str + ((type2 != null) ? type2.ToString() : null));
				};
			}
			Lua.xlua_pushasciistring(L, "__call");
			translator.PushFixCSFunction(L, constructor);
			Lua.lua_rawset(L, cls_meta);
			Lua.lua_pushvalue(L, cls_meta);
			Lua.lua_setmetatable(L, cls_field);
			Lua.lua_pop(L, 8);
			Debug.Assert(top_enter == Lua.lua_gettop(L));
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0005CAA4 File Offset: 0x0005ACA4
		public static void BeginObjectRegister(Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1)
		{
			bool flag = type == null;
			if (flag)
			{
				bool flag2 = type_id == -1;
				if (flag2)
				{
					throw new Exception("Fatal: must provide a type of type_id");
				}
				Lua.xlua_rawgeti(L, LuaIndexes.LUA_REGISTRYINDEX, (long)type_id);
			}
			else
			{
				Lua.luaL_getmetatable(L, type.FullName);
				bool flag3 = Lua.lua_isnil(L, -1);
				if (flag3)
				{
					Lua.lua_pop(L, 1);
					Lua.luaL_newmetatable(L, type.FullName);
				}
			}
			Lua.lua_pushlightuserdata(L, Lua.xlua_tag());
			Lua.lua_pushnumber(L, 1.0);
			Lua.lua_rawset(L, -3);
			bool flag4 = (type == null || !translator.HasCustomOp(type)) && type != typeof(decimal);
			if (flag4)
			{
				Lua.xlua_pushasciistring(L, "__gc");
				Lua.lua_pushstdcallcfunction(L, translator.metaFunctions.GcMeta, 0);
				Lua.lua_rawset(L, -3);
			}
			Lua.xlua_pushasciistring(L, "__tostring");
			Lua.lua_pushstdcallcfunction(L, translator.metaFunctions.ToStringMeta, 0);
			Lua.lua_rawset(L, -3);
			bool flag5 = method_count == 0;
			if (flag5)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_createtable(L, 0, method_count);
			}
			bool flag6 = getter_count == 0;
			if (flag6)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_createtable(L, 0, getter_count);
			}
			bool flag7 = setter_count == 0;
			if (flag7)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_createtable(L, 0, setter_count);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0005CC1C File Offset: 0x0005AE1C
		private static int abs_idx(int top, int idx)
		{
			return (idx > 0) ? idx : (top + idx + 1);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0005CC3C File Offset: 0x0005AE3C
		public static void EndObjectRegister(Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer)
		{
			int top = Lua.lua_gettop(L);
			int meta_idx = Utils.abs_idx(top, -4);
			int method_idx = Utils.abs_idx(top, -3);
			int getter_idx = Utils.abs_idx(top, -2);
			int setter_idx = Utils.abs_idx(top, -1);
			Lua.xlua_pushasciistring(L, "__index");
			Lua.lua_pushvalue(L, method_idx);
			Lua.lua_pushvalue(L, getter_idx);
			bool flag = csIndexer == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_pushstdcallcfunction(L, csIndexer, 0);
			}
			translator.Push(L, (type == null) ? base_type : type.BaseType());
			Lua.xlua_pushasciistring(L, "LuaIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			bool flag2 = arrayIndexer == null;
			if (flag2)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_pushstdcallcfunction(L, arrayIndexer, 0);
			}
			Lua.gen_obj_indexer(L);
			bool flag3 = type != null;
			if (flag3)
			{
				Lua.xlua_pushasciistring(L, "LuaIndexs");
				Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
				translator.Push(L, type);
				Lua.lua_pushvalue(L, -3);
				Lua.lua_rawset(L, -3);
				Lua.lua_pop(L, 1);
			}
			Lua.lua_rawset(L, meta_idx);
			Lua.xlua_pushasciistring(L, "__newindex");
			Lua.lua_pushvalue(L, setter_idx);
			bool flag4 = csNewIndexer == null;
			if (flag4)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_pushstdcallcfunction(L, csNewIndexer, 0);
			}
			translator.Push(L, (type == null) ? base_type : type.BaseType());
			Lua.xlua_pushasciistring(L, "LuaNewIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			bool flag5 = arrayNewIndexer == null;
			if (flag5)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_pushstdcallcfunction(L, arrayNewIndexer, 0);
			}
			Lua.gen_obj_newindexer(L);
			bool flag6 = type != null;
			if (flag6)
			{
				Lua.xlua_pushasciistring(L, "LuaNewIndexs");
				Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
				translator.Push(L, type);
				Lua.lua_pushvalue(L, -3);
				Lua.lua_rawset(L, -3);
				Lua.lua_pop(L, 1);
			}
			Lua.lua_rawset(L, meta_idx);
			Lua.lua_pop(L, 4);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0005CE4C File Offset: 0x0005B04C
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func)
		{
			idx = Utils.abs_idx(Lua.lua_gettop(L), idx);
			Lua.xlua_pushasciistring(L, name);
			Lua.lua_pushstdcallcfunction(L, func, 0);
			Lua.lua_rawset(L, idx);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0005CE78 File Offset: 0x0005B078
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, Type type, LazyMemberTypes memberType, bool isStatic)
		{
			idx = Utils.abs_idx(Lua.lua_gettop(L), idx);
			Lua.xlua_pushasciistring(L, name);
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			translator.PushAny(L, type);
			Lua.xlua_pushinteger(L, (int)memberType);
			Lua.lua_pushstring(L, name);
			Lua.lua_pushboolean(L, isStatic);
			Lua.lua_pushstdcallcfunction(L, InternalGlobals.LazyReflectionWrap, 4);
			Lua.lua_rawset(L, idx);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0005CEE2 File Offset: 0x0005B0E2
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj)
		{
			idx = Utils.abs_idx(Lua.lua_gettop(L), idx);
			Lua.xlua_pushasciistring(L, name);
			translator.PushAny(L, obj);
			Lua.lua_rawset(L, idx);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0005CF10 File Offset: 0x0005B110
		public static void BeginClassRegister(Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Lua.lua_createtable(L, 0, class_field_count);
			Lua.xlua_pushasciistring(L, "UnderlyingSystemType");
			translator.PushAny(L, type);
			Lua.lua_rawset(L, -3);
			int cls_table = Lua.lua_gettop(L);
			Utils.SetCSTable(L, type, cls_table);
			Lua.lua_createtable(L, 0, 3);
			int meta_table = Lua.lua_gettop(L);
			bool flag = creator != null;
			if (flag)
			{
				Lua.xlua_pushasciistring(L, "__call");
				Lua.lua_pushstdcallcfunction(L, creator, 0);
				Lua.lua_rawset(L, -3);
			}
			bool flag2 = static_getter_count == 0;
			if (flag2)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_createtable(L, 0, static_getter_count);
			}
			bool flag3 = static_setter_count == 0;
			if (flag3)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.lua_createtable(L, 0, static_setter_count);
			}
			Lua.lua_pushvalue(L, meta_table);
			Lua.lua_setmetatable(L, cls_table);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0005CFF0 File Offset: 0x0005B1F0
		public static void EndClassRegister(Type type, IntPtr L, ObjectTranslator translator)
		{
			int top = Lua.lua_gettop(L);
			int cls_idx = Utils.abs_idx(top, -4);
			int cls_getter_idx = Utils.abs_idx(top, -2);
			int cls_setter_idx = Utils.abs_idx(top, -1);
			int cls_meta_idx = Utils.abs_idx(top, -3);
			Lua.xlua_pushasciistring(L, "__index");
			Lua.lua_pushvalue(L, cls_getter_idx);
			Lua.lua_pushvalue(L, cls_idx);
			translator.Push(L, type.BaseType());
			Lua.xlua_pushasciistring(L, "LuaClassIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.gen_cls_indexer(L);
			Lua.xlua_pushasciistring(L, "LuaClassIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			translator.Push(L, type);
			Lua.lua_pushvalue(L, -3);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
			Lua.lua_rawset(L, cls_meta_idx);
			Lua.xlua_pushasciistring(L, "__newindex");
			Lua.lua_pushvalue(L, cls_setter_idx);
			translator.Push(L, type.BaseType());
			Lua.xlua_pushasciistring(L, "LuaClassNewIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.gen_cls_newindexer(L);
			Lua.xlua_pushasciistring(L, "LuaClassNewIndexs");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			translator.Push(L, type);
			Lua.lua_pushvalue(L, -3);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
			Lua.lua_rawset(L, cls_meta_idx);
			Lua.lua_pop(L, 4);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0005D144 File Offset: 0x0005B344
		private static List<string> getPathOfType(Type type)
		{
			List<string> path = new List<string>();
			bool flag = type.Namespace != null;
			if (flag)
			{
				path.AddRange(type.Namespace.Split(new char[]
				{
					'.'
				}));
			}
			string class_name = type.ToString().Substring((type.Namespace == null) ? 0 : (type.Namespace.Length + 1));
			bool isNested = type.IsNested;
			if (isNested)
			{
				path.AddRange(class_name.Split(new char[]
				{
					'+'
				}));
			}
			else
			{
				path.Add(class_name);
			}
			return path;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0005D1E0 File Offset: 0x0005B3E0
		public static void LoadCSTable(IntPtr L, Type type)
		{
			int oldTop = Lua.lua_gettop(L);
			Lua.xlua_pushasciistring(L, "xlua_csharp_namespace");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			List<string> path = Utils.getPathOfType(type);
			for (int i = 0; i < path.Count; i++)
			{
				Lua.xlua_pushasciistring(L, path[i]);
				bool flag = Lua.xlua_pgettable(L, -2) != 0;
				if (flag)
				{
					Lua.lua_settop(L, oldTop);
					Lua.lua_pushnil(L);
					break;
				}
				bool flag2 = !Lua.lua_istable(L, -1) && i < path.Count - 1;
				if (flag2)
				{
					Lua.lua_settop(L, oldTop);
					Lua.lua_pushnil(L);
					break;
				}
				Lua.lua_remove(L, -2);
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0005D294 File Offset: 0x0005B494
		public static void SetCSTable(IntPtr L, Type type, int cls_table)
		{
			int oldTop = Lua.lua_gettop(L);
			cls_table = Utils.abs_idx(oldTop, cls_table);
			Lua.xlua_pushasciistring(L, "xlua_csharp_namespace");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			List<string> path = Utils.getPathOfType(type);
			for (int i = 0; i < path.Count - 1; i++)
			{
				Lua.xlua_pushasciistring(L, path[i]);
				bool flag = Lua.xlua_pgettable(L, -2) != 0;
				if (flag)
				{
					string err = Lua.lua_tostring(L, -1);
					Lua.lua_settop(L, oldTop);
					throw new Exception("SetCSTable for [" + ((type != null) ? type.ToString() : null) + "] error: " + err);
				}
				bool flag2 = Lua.lua_isnil(L, -1);
				if (flag2)
				{
					Lua.lua_pop(L, 1);
					Lua.lua_createtable(L, 0, 0);
					Lua.xlua_pushasciistring(L, path[i]);
					Lua.lua_pushvalue(L, -2);
					Lua.lua_rawset(L, -4);
				}
				else
				{
					bool flag3 = !Lua.lua_istable(L, -1);
					if (flag3)
					{
						Lua.lua_settop(L, oldTop);
						throw new Exception("SetCSTable for [" + ((type != null) ? type.ToString() : null) + "] error: ancestors is not a table!");
					}
				}
				Lua.lua_remove(L, -2);
			}
			Lua.xlua_pushasciistring(L, path[path.Count - 1]);
			Lua.lua_pushvalue(L, cls_table);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
			Lua.xlua_pushasciistring(L, "xlua_csharp_namespace");
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			ObjectTranslatorPool.Instance.Find(L).PushAny(L, type);
			Lua.lua_pushvalue(L, cls_table);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0005D440 File Offset: 0x0005B640
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod)
		{
			bool flag = delegateMethod == null || bridgeMethod == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = delegateMethod.ReturnType != bridgeMethod.ReturnType;
				if (flag2)
				{
					result = false;
				}
				else
				{
					ParameterInfo[] delegateParams = delegateMethod.GetParameters();
					ParameterInfo[] bridgeParams = bridgeMethod.GetParameters();
					bool flag3 = delegateParams.Length != bridgeParams.Length;
					if (flag3)
					{
						result = false;
					}
					else
					{
						for (int i = 0; i < delegateParams.Length; i++)
						{
							bool flag4 = delegateParams[i].ParameterType != bridgeParams[i].ParameterType || delegateParams[i].IsOut != bridgeParams[i].IsOut;
							if (flag4)
							{
								return false;
							}
						}
						int lastPos = delegateParams.Length - 1;
						result = (lastPos < 0 || delegateParams[lastPos].IsDefined(typeof(ParamArrayAttribute), false) == bridgeParams[lastPos].IsDefined(typeof(ParamArrayAttribute), false));
					}
				}
			}
			return result;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0005D54C File Offset: 0x0005B74C
		public static bool IsSupportedMethod(MethodInfo method)
		{
			bool flag = !method.ContainsGenericParameters;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				ParameterInfo[] methodParameters = method.GetParameters();
				Type returnType = method.ReturnType;
				bool hasValidGenericParameter = false;
				bool returnTypeValid = !returnType.IsGenericParameter;
				for (int i = 0; i < methodParameters.Length; i++)
				{
					Type parameterType = methodParameters[i].ParameterType;
					bool isGenericParameter = parameterType.IsGenericParameter;
					if (isGenericParameter)
					{
						Type[] parameterConstraints = parameterType.GetGenericParameterConstraints();
						bool flag2 = parameterConstraints.Length == 0;
						if (flag2)
						{
							return false;
						}
						foreach (Type parameterConstraint in parameterConstraints)
						{
							bool flag3 = !parameterConstraint.IsClass() || parameterConstraint == typeof(ValueType);
							if (flag3)
							{
								return false;
							}
						}
						hasValidGenericParameter = true;
						bool flag4 = !returnTypeValid;
						if (flag4)
						{
							bool flag5 = parameterType == returnType;
							if (flag5)
							{
								returnTypeValid = true;
							}
						}
					}
				}
				result = (hasValidGenericParameter && returnTypeValid);
			}
			return result;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0005D658 File Offset: 0x0005B858
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method)
		{
			MethodInfo result;
			try
			{
				Type[] genericArguments = method.GetGenericArguments();
				Type[] constraintedArgumentTypes = new Type[genericArguments.Length];
				for (int i = 0; i < genericArguments.Length; i++)
				{
					Type argumentType = genericArguments[i];
					Type[] parameterConstraints = argumentType.GetGenericParameterConstraints();
					constraintedArgumentTypes[i] = parameterConstraints[0];
				}
				result = method.MakeGenericMethod(constraintedArgumentTypes);
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0005D6C4 File Offset: 0x0005B8C4
		private static Type getExtendedType(MethodInfo method)
		{
			Type type = method.GetParameters()[0].ParameterType;
			bool flag = !type.IsGenericParameter;
			Type result;
			if (flag)
			{
				result = type;
			}
			else
			{
				Type[] parameterConstraints = type.GetGenericParameterConstraints();
				bool flag2 = parameterConstraints.Length == 0;
				if (flag2)
				{
					throw new InvalidOperationException();
				}
				Type firstParameterConstraint = parameterConstraints[0];
				bool flag3 = !firstParameterConstraint.IsClass();
				if (flag3)
				{
					throw new InvalidOperationException();
				}
				result = firstParameterConstraint;
			}
			return result;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0005D72C File Offset: 0x0005B92C
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction)
		{
			return csFunction.Method.IsStatic && Attribute.IsDefined(csFunction.Method, typeof(MonoPInvokeCallbackAttribute));
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0005D764 File Offset: 0x0005B964
		public static bool IsPublic(Type type)
		{
			bool isNested = type.IsNested;
			bool result;
			if (isNested)
			{
				bool flag = !type.IsNestedPublic();
				result = (!flag && Utils.IsPublic(type.DeclaringType));
			}
			else
			{
				bool flag2 = type.IsGenericType();
				if (flag2)
				{
					Type[] gas = type.GetGenericArguments();
					for (int i = 0; i < gas.Length; i++)
					{
						bool flag3 = !Utils.IsPublic(gas[i]);
						if (flag3)
						{
							return false;
						}
					}
				}
				result = type.IsPublic();
			}
			return result;
		}

		// Token: 0x04000DAF RID: 3503
		public const int OBJ_META_IDX = -4;

		// Token: 0x04000DB0 RID: 3504
		public const int METHOD_IDX = -3;

		// Token: 0x04000DB1 RID: 3505
		public const int GETTER_IDX = -2;

		// Token: 0x04000DB2 RID: 3506
		public const int SETTER_IDX = -1;

		// Token: 0x04000DB3 RID: 3507
		public const int CLS_IDX = -4;

		// Token: 0x04000DB4 RID: 3508
		public const int CLS_META_IDX = -3;

		// Token: 0x04000DB5 RID: 3509
		public const int CLS_GETTER_IDX = -2;

		// Token: 0x04000DB6 RID: 3510
		public const int CLS_SETTER_IDX = -1;

		// Token: 0x04000DB7 RID: 3511
		public const string LuaIndexsFieldName = "LuaIndexs";

		// Token: 0x04000DB8 RID: 3512
		public const string LuaNewIndexsFieldName = "LuaNewIndexs";

		// Token: 0x04000DB9 RID: 3513
		public const string LuaClassIndexsFieldName = "LuaClassIndexs";

		// Token: 0x04000DBA RID: 3514
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs";

		// Token: 0x02000184 RID: 388
		private struct MethodKey
		{
			// Token: 0x04000DBB RID: 3515
			public string Name;

			// Token: 0x04000DBC RID: 3516
			public bool IsStatic;
		}
	}
}

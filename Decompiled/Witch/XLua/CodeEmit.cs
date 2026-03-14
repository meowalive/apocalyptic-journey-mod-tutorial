using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Cysharp.Text;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200014A RID: 330
	public class CodeEmit
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x000502AC File Offset: 0x0004E4AC
		public CodeEmit()
		{
			this.fixPush = new Dictionary<Type, MethodInfo>
			{
				{
					typeof(byte),
					this.LuaAPI_xlua_pushinteger
				},
				{
					typeof(char),
					this.LuaAPI_xlua_pushinteger
				},
				{
					typeof(short),
					this.LuaAPI_xlua_pushinteger
				},
				{
					typeof(int),
					this.LuaAPI_xlua_pushinteger
				},
				{
					typeof(long),
					this.LuaAPI_lua_pushint64
				},
				{
					typeof(sbyte),
					this.LuaAPI_xlua_pushinteger
				},
				{
					typeof(float),
					this.LuaAPI_lua_pushnumber
				},
				{
					typeof(ushort),
					this.LuaAPI_xlua_pushinteger
				},
				{
					typeof(uint),
					this.LuaAPI_xlua_pushuint
				},
				{
					typeof(ulong),
					this.LuaAPI_lua_pushuint64
				},
				{
					typeof(double),
					this.LuaAPI_lua_pushnumber
				},
				{
					typeof(string),
					this.LuaAPI_lua_pushstring
				},
				{
					typeof(byte[]),
					this.LuaAPI_lua_pushbytes
				},
				{
					typeof(bool),
					this.LuaAPI_lua_pushboolean
				},
				{
					typeof(IntPtr),
					this.LuaAPI_lua_pushlightuserdata
				}
			};
			this.fixCaster = new Dictionary<Type, MethodInfo>
			{
				{
					typeof(double),
					this.LuaAPI_lua_tonumber
				},
				{
					typeof(string),
					this.LuaAPI_lua_tostring
				},
				{
					typeof(bool),
					this.LuaAPI_lua_toboolean
				},
				{
					typeof(byte[]),
					this.LuaAPI_lua_tobytes
				},
				{
					typeof(IntPtr),
					this.LuaAPI_lua_touserdata
				},
				{
					typeof(uint),
					this.LuaAPI_xlua_touint
				},
				{
					typeof(ulong),
					this.LuaAPI_lua_touint64
				},
				{
					typeof(int),
					this.LuaAPI_xlua_tointeger
				},
				{
					typeof(long),
					this.LuaAPI_lua_toint64
				}
			};
			this.typedCaster = new Dictionary<Type, MethodInfo>
			{
				{
					typeof(byte),
					this.LuaAPI_xlua_tointeger
				},
				{
					typeof(char),
					this.LuaAPI_xlua_tointeger
				},
				{
					typeof(short),
					this.LuaAPI_xlua_tointeger
				},
				{
					typeof(sbyte),
					this.LuaAPI_xlua_tointeger
				},
				{
					typeof(float),
					this.LuaAPI_lua_tonumber
				},
				{
					typeof(ushort),
					this.LuaAPI_xlua_tointeger
				}
			};
			CodeEmit.initBlackList();
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00050D18 File Offset: 0x0004EF18
		private void emitPush(ILGenerator il, Type type, short dataPos, bool isParam, LocalBuilder L, LocalBuilder translator, bool isArg)
		{
			Type paramElemType = type.IsByRef ? type.GetElementType() : type;
			OpCode ldd = isArg ? OpCodes.Ldarg : OpCodes.Ldloc;
			MethodInfo pusher;
			bool flag = this.fixPush.TryGetValue(paramElemType, out pusher);
			if (flag)
			{
				il.Emit(OpCodes.Ldloc, L);
				il.Emit(ldd, dataPos);
				bool isByRef = type.IsByRef;
				if (isByRef)
				{
					bool isValueType = paramElemType.IsValueType;
					if (isValueType)
					{
						il.Emit(OpCodes.Ldobj, paramElemType);
					}
					else
					{
						il.Emit(OpCodes.Ldind_Ref);
					}
				}
				il.Emit(OpCodes.Call, pusher);
			}
			else
			{
				bool flag2 = paramElemType == typeof(decimal);
				if (flag2)
				{
					il.Emit(OpCodes.Ldloc, translator);
					il.Emit(OpCodes.Ldloc, L);
					il.Emit(ldd, dataPos);
					bool isByRef2 = type.IsByRef;
					if (isByRef2)
					{
						il.Emit(OpCodes.Ldobj, paramElemType);
					}
					il.Emit(OpCodes.Callvirt, this.ObjectTranslator_PushDecimal);
				}
				else
				{
					il.Emit(OpCodes.Ldloc, translator);
					il.Emit(OpCodes.Ldloc, L);
					il.Emit(ldd, dataPos);
					bool isByRef3 = type.IsByRef;
					if (isByRef3)
					{
						bool isValueType2 = paramElemType.IsValueType;
						if (isValueType2)
						{
							il.Emit(OpCodes.Ldobj, paramElemType);
							il.Emit(OpCodes.Box, paramElemType);
						}
						else
						{
							il.Emit(OpCodes.Ldind_Ref);
						}
					}
					else
					{
						bool isValueType3 = type.IsValueType;
						if (isValueType3)
						{
							il.Emit(OpCodes.Box, type);
						}
					}
					if (isParam)
					{
						il.Emit(OpCodes.Callvirt, this.ObjectTranslator_PushParams);
					}
					else
					{
						il.Emit(OpCodes.Callvirt, this.ObjectTranslator_PushAny);
					}
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00050EEC File Offset: 0x0004F0EC
		private ModuleBuilder CodeEmitModule
		{
			get
			{
				bool flag = this.codeEmitModule == null;
				if (flag)
				{
					AssemblyName assemblyName = new AssemblyName();
					assemblyName.Name = "XLuaCodeEmit";
					this.codeEmitModule = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run).DefineDynamicModule("XLuaCodeEmit");
				}
				return this.codeEmitModule;
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00050F44 File Offset: 0x0004F144
		public Type EmitDelegateImpl(IEnumerable<IGrouping<MethodInfo, Type>> groups)
		{
			ModuleBuilder moduleBuilder = this.CodeEmitModule;
			string str = "XLuaGenDelegateImpl";
			ulong num = this.genID;
			this.genID = num + 1UL;
			TypeBuilder impl_type_builder = moduleBuilder.DefineType(str + num.ToString(), TypeAttributes.Public, typeof(DelegateBridge));
			MethodBuilder get_deleate_by_type = impl_type_builder.DefineMethod("GetDelegateByType", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Final | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, typeof(Delegate), new Type[]
			{
				typeof(Type)
			});
			ILGenerator get_deleate_by_type_il = get_deleate_by_type.GetILGenerator();
			foreach (IGrouping<MethodInfo, Type> group in groups)
			{
				MethodInfo to_be_impl = group.Key;
				TypeBuilder type_builder = impl_type_builder;
				MethodInfo to_be_impl2 = to_be_impl;
				MethodAttributes attributes = to_be_impl.Attributes;
				string str2 = "__Gen_Delegate_Imp";
				num = this.genID;
				this.genID = num + 1UL;
				MethodBuilder method_builder = this.defineImplementMethod(type_builder, to_be_impl2, attributes, str2 + num.ToString());
				this.emitMethodImpl(to_be_impl, method_builder.GetILGenerator(), false);
				foreach (Type dt in group)
				{
					Label end_of_if = get_deleate_by_type_il.DefineLabel();
					get_deleate_by_type_il.Emit(OpCodes.Ldarg_1);
					get_deleate_by_type_il.Emit(OpCodes.Ldtoken, dt);
					get_deleate_by_type_il.Emit(OpCodes.Call, this.Type_GetTypeFromHandle);
					get_deleate_by_type_il.Emit(OpCodes.Bne_Un, end_of_if);
					get_deleate_by_type_il.Emit(OpCodes.Ldarg_0);
					get_deleate_by_type_il.Emit(OpCodes.Ldftn, method_builder);
					get_deleate_by_type_il.Emit(OpCodes.Newobj, dt.GetConstructor(new Type[]
					{
						typeof(object),
						typeof(IntPtr)
					}));
					get_deleate_by_type_il.Emit(OpCodes.Ret);
					get_deleate_by_type_il.MarkLabel(end_of_if);
				}
			}
			Type[] ctor_param_types = new Type[]
			{
				typeof(int),
				typeof(LuaEnv)
			};
			ConstructorInfo parent_ctor = typeof(DelegateBridge).GetConstructor(ctor_param_types);
			ConstructorBuilder ctor_builder = impl_type_builder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, ctor_param_types);
			ILGenerator ctor_il = ctor_builder.GetILGenerator();
			ctor_il.Emit(OpCodes.Ldarg_0);
			ctor_il.Emit(OpCodes.Ldarg_1);
			ctor_il.Emit(OpCodes.Ldarg_2);
			ctor_il.Emit(OpCodes.Call, parent_ctor);
			ctor_il.Emit(OpCodes.Ret);
			get_deleate_by_type_il.Emit(OpCodes.Ldnull);
			get_deleate_by_type_il.Emit(OpCodes.Ret);
			impl_type_builder.DefineMethodOverride(get_deleate_by_type, typeof(DelegateBridgeBase).GetMethod("GetDelegateByType"));
			return impl_type_builder.CreateType();
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00051220 File Offset: 0x0004F420
		private void EmitGetObject(ILGenerator il, int offset, Type type, LocalBuilder L, LocalBuilder translator, LocalBuilder offsetBase, bool isParam = false)
		{
			bool flag = !this.fixCaster.ContainsKey(type) && !this.typedCaster.ContainsKey(type);
			if (flag)
			{
				il.Emit(OpCodes.Ldloc, translator);
			}
			il.Emit(OpCodes.Ldloc, L);
			bool flag2 = offsetBase != null;
			if (flag2)
			{
				il.Emit(OpCodes.Ldloc, offsetBase);
				il.Emit(OpCodes.Ldc_I4, offset);
				il.Emit(OpCodes.Add);
			}
			else
			{
				il.Emit(OpCodes.Ldc_I4, offset);
			}
			MethodInfo caster;
			bool flag3 = this.fixCaster.TryGetValue(type, out caster);
			if (flag3)
			{
				il.Emit(OpCodes.Call, caster);
			}
			else
			{
				bool flag4 = this.typedCaster.TryGetValue(type, out caster);
				if (flag4)
				{
					il.Emit(OpCodes.Call, caster);
					bool flag5 = type == typeof(byte);
					if (flag5)
					{
						il.Emit(OpCodes.Conv_U1);
					}
					else
					{
						bool flag6 = type == typeof(char);
						if (flag6)
						{
							il.Emit(OpCodes.Conv_U2);
						}
						else
						{
							bool flag7 = type == typeof(short);
							if (flag7)
							{
								il.Emit(OpCodes.Conv_I2);
							}
							else
							{
								bool flag8 = type == typeof(sbyte);
								if (flag8)
								{
									il.Emit(OpCodes.Conv_I1);
								}
								else
								{
									bool flag9 = type == typeof(ushort);
									if (flag9)
									{
										il.Emit(OpCodes.Conv_U2);
									}
									else
									{
										bool flag10 = type == typeof(float);
										if (!flag10)
										{
											throw new InvalidProgramException(((type != null) ? type.ToString() : null) + " is not a type need cast");
										}
										il.Emit(OpCodes.Conv_R4);
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag11 = type == typeof(decimal);
					if (flag11)
					{
						il.Emit(OpCodes.Callvirt, this.ObjectTranslator_GetDecimal);
					}
					else
					{
						if (isParam)
						{
							il.Emit(OpCodes.Callvirt, this.ObjectTranslator_GetParams.MakeGenericMethod(new Type[]
							{
								type.GetElementType()
							}));
						}
						else
						{
							il.Emit(OpCodes.Ldtoken, type);
							il.Emit(OpCodes.Call, this.Type_GetTypeFromHandle);
							il.Emit(OpCodes.Callvirt, this.ObjectTranslator_GetObject);
						}
						bool isValueType = type.IsValueType;
						if (isValueType)
						{
							Label not_null = il.DefineLabel();
							Label null_done = il.DefineLabel();
							LocalBuilder local_new = il.DeclareLocal(type);
							il.Emit(OpCodes.Dup);
							il.Emit(OpCodes.Brtrue_S, not_null);
							il.Emit(OpCodes.Pop);
							il.Emit(OpCodes.Ldloca, local_new);
							il.Emit(OpCodes.Initobj, type);
							il.Emit(OpCodes.Ldloc, local_new);
							il.Emit(OpCodes.Br_S, null_done);
							il.MarkLabel(not_null);
							il.Emit(OpCodes.Unbox_Any, type);
							il.MarkLabel(null_done);
						}
						else
						{
							bool flag12 = type != typeof(object);
							if (flag12)
							{
								il.Emit(OpCodes.Castclass, type);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00051572 File Offset: 0x0004F772
		public void SetGenInterfaces(List<Type> gen_interfaces)
		{
			gen_interfaces.ForEach(delegate(Type item)
			{
				bool flag = !this.gen_interfaces.Contains(item);
				if (flag)
				{
					this.gen_interfaces.Add(item);
				}
			});
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00051588 File Offset: 0x0004F788
		public Type EmitInterfaceImpl(Type to_be_impl)
		{
			bool flag = !to_be_impl.IsInterface;
			if (flag)
			{
				throw new InvalidOperationException("interface expected, but got " + ((to_be_impl != null) ? to_be_impl.ToString() : null));
			}
			bool flag2 = !this.gen_interfaces.Contains(to_be_impl);
			if (flag2)
			{
				throw new InvalidCastException("This type must add to CSharpCallLua: " + to_be_impl.GetFriendlyName());
			}
			ModuleBuilder moduleBuilder = this.CodeEmitModule;
			string str = "XLuaGenInterfaceImpl";
			ulong num = this.genID;
			this.genID = num + 1UL;
			TypeBuilder impl_type_builder = moduleBuilder.DefineType(str + num.ToString(), TypeAttributes.Public, typeof(LuaBase), new Type[]
			{
				to_be_impl
			});
			foreach (MemberInfo member in new Type[]
			{
				to_be_impl
			}.Concat(to_be_impl.GetInterfaces()).SelectMany((Type i) => i.GetMembers()))
			{
				bool flag3 = member.MemberType == MemberTypes.Method;
				if (flag3)
				{
					MethodInfo method = member as MethodInfo;
					bool flag4 = method.Name.StartsWith("get_") || method.Name.StartsWith("set_") || method.Name.StartsWith("add_") || method.Name.StartsWith("remove_");
					if (!flag4)
					{
						MethodBuilder method_builder = this.defineImplementMethod(impl_type_builder, method, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Final | MethodAttributes.Virtual, null);
						this.emitMethodImpl(method, method_builder.GetILGenerator(), true);
					}
				}
				else
				{
					bool flag5 = member.MemberType == MemberTypes.Property;
					if (flag5)
					{
						PropertyInfo property = member as PropertyInfo;
						PropertyBuilder prop_builder = impl_type_builder.DefineProperty(property.Name, property.Attributes, property.PropertyType, Type.EmptyTypes);
						bool flag6 = property.Name == "Item";
						if (flag6)
						{
							bool canRead = property.CanRead;
							if (canRead)
							{
								MethodBuilder getter_buildler = this.defineImplementMethod(impl_type_builder, property.GetGetMethod(), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName, null);
								this.emitMethodImpl(property.GetGetMethod(), getter_buildler.GetILGenerator(), true);
								prop_builder.SetGetMethod(getter_buildler);
							}
							bool canWrite = property.CanWrite;
							if (canWrite)
							{
								MethodBuilder setter_buildler = this.defineImplementMethod(impl_type_builder, property.GetSetMethod(), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName, null);
								this.emitMethodImpl(property.GetSetMethod(), setter_buildler.GetILGenerator(), true);
								prop_builder.SetSetMethod(setter_buildler);
							}
						}
						else
						{
							bool canRead2 = property.CanRead;
							if (canRead2)
							{
								MethodBuilder getter_buildler2 = impl_type_builder.DefineMethod("get_" + property.Name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName, property.PropertyType, Type.EmptyTypes);
								ILGenerator il = getter_buildler2.GetILGenerator();
								LocalBuilder L = il.DeclareLocal(typeof(IntPtr));
								LocalBuilder oldTop = il.DeclareLocal(typeof(int));
								LocalBuilder translator = il.DeclareLocal(typeof(ObjectTranslator));
								LocalBuilder ret = il.DeclareLocal(property.PropertyType);
								il.Emit(OpCodes.Ldarg_0);
								il.Emit(OpCodes.Callvirt, this.LuaBase_L_getter);
								il.Emit(OpCodes.Stloc, L);
								il.Emit(OpCodes.Ldloc, L);
								il.Emit(OpCodes.Call, this.LuaAPI_lua_gettop);
								il.Emit(OpCodes.Stloc, oldTop);
								il.Emit(OpCodes.Ldarg_0);
								il.Emit(OpCodes.Callvirt, this.LuaBase_translator_getter);
								il.Emit(OpCodes.Stloc, translator);
								il.Emit(OpCodes.Ldloc, L);
								il.Emit(OpCodes.Ldarg_0);
								il.Emit(OpCodes.Ldfld, this.LuaBase_luaReference);
								il.Emit(OpCodes.Call, this.LuaAPI_lua_getref);
								il.Emit(OpCodes.Ldloc, L);
								il.Emit(OpCodes.Ldstr, property.Name);
								il.Emit(OpCodes.Call, this.LuaAPI_lua_pushstring);
								il.Emit(OpCodes.Ldloc, L);
								il.Emit(OpCodes.Ldc_I4_S, -2);
								il.Emit(OpCodes.Call, this.LuaAPI_xlua_pgettable);
								Label gettable_no_exception = il.DefineLabel();
								il.Emit(OpCodes.Brfalse, gettable_no_exception);
								il.Emit(OpCodes.Ldarg_0);
								il.Emit(OpCodes.Ldfld, this.LuaBase_luaEnv);
								il.Emit(OpCodes.Ldloc, oldTop);
								il.Emit(OpCodes.Callvirt, this.LuaEnv_ThrowExceptionFromError);
								il.MarkLabel(gettable_no_exception);
								this.EmitGetObject(il, -1, property.PropertyType, L, translator, null, false);
								il.Emit(OpCodes.Stloc, ret);
								il.Emit(OpCodes.Ldloc, L);
								il.Emit(OpCodes.Ldc_I4_S, 2);
								il.Emit(OpCodes.Call, this.LuaAPI_lua_pop);
								il.Emit(OpCodes.Ldloc, ret);
								il.Emit(OpCodes.Ret);
								prop_builder.SetGetMethod(getter_buildler2);
							}
							bool canWrite2 = property.CanWrite;
							if (canWrite2)
							{
								MethodBuilder setter_builder = impl_type_builder.DefineMethod("set_" + property.Name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName, null, new Type[]
								{
									property.PropertyType
								});
								ILGenerator il2 = setter_builder.GetILGenerator();
								LocalBuilder L2 = il2.DeclareLocal(typeof(IntPtr));
								LocalBuilder oldTop2 = il2.DeclareLocal(typeof(int));
								LocalBuilder translator2 = il2.DeclareLocal(typeof(ObjectTranslator));
								il2.Emit(OpCodes.Ldarg_0);
								il2.Emit(OpCodes.Callvirt, this.LuaBase_L_getter);
								il2.Emit(OpCodes.Stloc, L2);
								il2.Emit(OpCodes.Ldloc, L2);
								il2.Emit(OpCodes.Call, this.LuaAPI_lua_gettop);
								il2.Emit(OpCodes.Stloc, oldTop2);
								il2.Emit(OpCodes.Ldarg_0);
								il2.Emit(OpCodes.Callvirt, this.LuaBase_translator_getter);
								il2.Emit(OpCodes.Stloc, translator2);
								il2.Emit(OpCodes.Ldloc, L2);
								il2.Emit(OpCodes.Ldarg_0);
								il2.Emit(OpCodes.Ldfld, this.LuaBase_luaReference);
								il2.Emit(OpCodes.Call, this.LuaAPI_lua_getref);
								il2.Emit(OpCodes.Ldloc, L2);
								il2.Emit(OpCodes.Ldstr, property.Name);
								il2.Emit(OpCodes.Call, this.LuaAPI_lua_pushstring);
								this.emitPush(il2, property.PropertyType, 1, false, L2, translator2, true);
								il2.Emit(OpCodes.Ldloc, L2);
								il2.Emit(OpCodes.Ldc_I4_S, -3);
								il2.Emit(OpCodes.Call, this.LuaAPI_xlua_psettable);
								Label settable_no_exception = il2.DefineLabel();
								il2.Emit(OpCodes.Brfalse, settable_no_exception);
								il2.Emit(OpCodes.Ldarg_0);
								il2.Emit(OpCodes.Ldfld, this.LuaBase_luaEnv);
								il2.Emit(OpCodes.Ldloc, oldTop2);
								il2.Emit(OpCodes.Callvirt, this.LuaEnv_ThrowExceptionFromError);
								il2.MarkLabel(settable_no_exception);
								il2.Emit(OpCodes.Ldloc, L2);
								il2.Emit(OpCodes.Ldc_I4_S, 1);
								il2.Emit(OpCodes.Call, this.LuaAPI_lua_pop);
								il2.Emit(OpCodes.Ret);
								prop_builder.SetSetMethod(setter_builder);
							}
						}
					}
					else
					{
						bool flag7 = member.MemberType == MemberTypes.Event;
						if (flag7)
						{
							EventInfo event_info = member as EventInfo;
							EventBuilder event_builder = impl_type_builder.DefineEvent(event_info.Name, event_info.Attributes, event_info.EventHandlerType);
							bool flag8 = event_info.GetAddMethod() != null;
							if (flag8)
							{
								MethodBuilder add_buildler = this.defineImplementMethod(impl_type_builder, event_info.GetAddMethod(), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName, null);
								this.emitMethodImpl(event_info.GetAddMethod(), add_buildler.GetILGenerator(), true);
								event_builder.SetAddOnMethod(add_buildler);
							}
							bool flag9 = event_info.GetRemoveMethod() != null;
							if (flag9)
							{
								MethodBuilder remove_buildler = this.defineImplementMethod(impl_type_builder, event_info.GetRemoveMethod(), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.SpecialName, null);
								this.emitMethodImpl(event_info.GetRemoveMethod(), remove_buildler.GetILGenerator(), true);
								event_builder.SetRemoveOnMethod(remove_buildler);
							}
						}
					}
				}
			}
			Type[] ctor_param_types = new Type[]
			{
				typeof(int),
				typeof(LuaEnv)
			};
			ConstructorInfo parent_ctor = typeof(LuaBase).GetConstructor(ctor_param_types);
			ConstructorBuilder ctor_builder = impl_type_builder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, ctor_param_types);
			ILGenerator ctor_il = ctor_builder.GetILGenerator();
			ctor_il.Emit(OpCodes.Ldarg_0);
			ctor_il.Emit(OpCodes.Ldarg_1);
			ctor_il.Emit(OpCodes.Ldarg_2);
			ctor_il.Emit(OpCodes.Call, parent_ctor);
			ctor_il.Emit(OpCodes.Ret);
			return impl_type_builder.CreateType();
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00051ED0 File Offset: 0x000500D0
		private void emitEmptyMethod(ILGenerator il, Type returnType)
		{
			bool flag = returnType != typeof(void);
			if (flag)
			{
				bool isValueType = returnType.IsValueType;
				if (isValueType)
				{
					LocalBuilder local_new = il.DeclareLocal(returnType);
					il.Emit(OpCodes.Ldloca, local_new);
					il.Emit(OpCodes.Initobj, returnType);
					il.Emit(OpCodes.Ldloc, local_new);
				}
				else
				{
					il.Emit(OpCodes.Ldnull);
				}
			}
			il.Emit(OpCodes.Ret);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00051F4C File Offset: 0x0005014C
		private MethodBuilder defineImplementMethod(TypeBuilder type_builder, MethodInfo to_be_impl, MethodAttributes attributes, string methodName = null)
		{
			ParameterInfo[] parameters = to_be_impl.GetParameters();
			Type[] param_types = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				param_types[i] = parameters[i].ParameterType;
			}
			MethodBuilder method_builder = type_builder.DefineMethod((methodName == null) ? to_be_impl.Name : methodName, attributes, to_be_impl.ReturnType, param_types);
			for (int j = 0; j < parameters.Length; j++)
			{
				method_builder.DefineParameter(j + 1, parameters[j].Attributes, parameters[j].Name);
			}
			return method_builder;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00051FE8 File Offset: 0x000501E8
		private void emitLiteralLoad(ILGenerator il, Type type, object obj, int localIndex)
		{
			bool flag = !type.IsValueType && obj == null;
			if (flag)
			{
				il.Emit(OpCodes.Ldnull);
			}
			else
			{
				bool flag2 = type.IsPrimitive || type.IsEnum();
				if (flag2)
				{
					bool flag3 = type.IsEnum();
					if (flag3)
					{
						type = Enum.GetUnderlyingType(type);
					}
					bool flag4 = typeof(bool) == type;
					if (flag4)
					{
						bool flag5 = (bool)obj;
						if (flag5)
						{
							il.Emit(OpCodes.Ldc_I4_1);
						}
						else
						{
							il.Emit(OpCodes.Ldc_I4_0);
						}
					}
					else
					{
						bool flag6 = typeof(uint) == type;
						if (flag6)
						{
							il.Emit(OpCodes.Ldc_I4, (int)Convert.ToUInt32(obj));
						}
						else
						{
							bool flag7 = typeof(byte) == type || typeof(sbyte) == type || typeof(short) == type || typeof(ushort) == type || typeof(int) == type || typeof(char) == type;
							if (flag7)
							{
								il.Emit(OpCodes.Ldc_I4, Convert.ToInt32(obj));
							}
							else
							{
								bool flag8 = typeof(long) == type;
								if (flag8)
								{
									il.Emit(OpCodes.Ldc_I8, Convert.ToInt64(obj));
								}
								else
								{
									bool flag9 = typeof(ulong) == type;
									if (flag9)
									{
										il.Emit(OpCodes.Ldc_I8, (long)Convert.ToUInt64(obj));
									}
									else
									{
										bool flag10 = typeof(IntPtr) == type || typeof(UIntPtr) == type;
										if (flag10)
										{
											il.Emit(OpCodes.Ldloca, localIndex);
											il.Emit(OpCodes.Initobj, type);
											il.Emit(OpCodes.Ldloc, localIndex);
										}
										else
										{
											bool flag11 = typeof(float) == type;
											if (flag11)
											{
												il.Emit(OpCodes.Ldc_R4, Convert.ToSingle(obj));
											}
											else
											{
												bool flag12 = typeof(double) == type;
												if (!flag12)
												{
													Type type2 = type;
													throw new Exception(((type2 != null) ? type2.ToString() : null) + " is not primitive or enum!");
												}
												il.Emit(OpCodes.Ldc_R8, Convert.ToDouble(obj));
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag13 = type == typeof(string);
					if (flag13)
					{
						il.Emit(OpCodes.Ldstr, obj as string);
					}
					else
					{
						bool flag14 = type == typeof(decimal);
						if (flag14)
						{
							int[] buffer = decimal.GetBits(Convert.ToDecimal(obj));
							il.Emit(OpCodes.Ldc_I4, buffer[0]);
							il.Emit(OpCodes.Ldc_I4, buffer[1]);
							il.Emit(OpCodes.Ldc_I4, buffer[2]);
							il.Emit(OpCodes.Ldc_I4, (((long)buffer[3] & (long)((ulong)int.MinValue)) == 0L) ? 0 : 1);
							il.Emit(OpCodes.Ldc_I4, buffer[3] >> 16 & 255);
							il.Emit(OpCodes.Newobj, this.decimalConstructor);
						}
						else
						{
							bool isValueType = type.IsValueType;
							if (isValueType)
							{
								il.Emit(OpCodes.Ldloca, localIndex);
								il.Emit(OpCodes.Initobj, type);
								il.Emit(OpCodes.Ldloc, localIndex);
							}
							else
							{
								il.Emit(OpCodes.Ldnull);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00052394 File Offset: 0x00050594
		private void emitMethodImpl(MethodInfo to_be_impl, ILGenerator il, bool isObj)
		{
			ParameterInfo[] parameters = to_be_impl.GetParameters();
			LocalBuilder L = il.DeclareLocal(typeof(IntPtr));
			LocalBuilder err_func = il.DeclareLocal(typeof(int));
			LocalBuilder translator = il.DeclareLocal(typeof(ObjectTranslator));
			LocalBuilder ret = null;
			bool has_return = to_be_impl.ReturnType != typeof(void);
			bool flag = has_return;
			if (flag)
			{
				ret = il.DeclareLocal(to_be_impl.ReturnType);
			}
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Callvirt, this.LuaBase_L_getter);
			il.Emit(OpCodes.Stloc, L);
			il.Emit(OpCodes.Ldloc, L);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Callvirt, this.DelegateBridgeBase_errorFuncRef_getter);
			il.Emit(OpCodes.Call, this.LuaAPI_load_error_func);
			il.Emit(OpCodes.Stloc, err_func);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Callvirt, this.LuaBase_translator_getter);
			il.Emit(OpCodes.Stloc, translator);
			il.Emit(OpCodes.Ldloc, L);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldfld, this.LuaBase_luaReference);
			il.Emit(OpCodes.Call, this.LuaAPI_lua_getref);
			if (isObj)
			{
				il.Emit(OpCodes.Ldloc, L);
				il.Emit(OpCodes.Ldstr, to_be_impl.Name);
				il.Emit(OpCodes.Call, this.LuaAPI_lua_pushstring);
				il.Emit(OpCodes.Ldloc, L);
				il.Emit(OpCodes.Ldc_I4_S, -2);
				il.Emit(OpCodes.Call, this.LuaAPI_xlua_pgettable);
				Label gettable_no_exception = il.DefineLabel();
				il.Emit(OpCodes.Brfalse, gettable_no_exception);
				il.Emit(OpCodes.Ldarg_0);
				il.Emit(OpCodes.Ldfld, this.LuaBase_luaEnv);
				il.Emit(OpCodes.Ldloc, err_func);
				il.Emit(OpCodes.Ldc_I4_1);
				il.Emit(OpCodes.Sub);
				il.Emit(OpCodes.Callvirt, this.LuaEnv_ThrowExceptionFromError);
				il.MarkLabel(gettable_no_exception);
				il.Emit(OpCodes.Ldloc, L);
				il.Emit(OpCodes.Ldc_I4_S, -2);
				il.Emit(OpCodes.Call, this.LuaAPI_lua_pushvalue);
				il.Emit(OpCodes.Ldloc, L);
				il.Emit(OpCodes.Ldc_I4_S, -3);
				il.Emit(OpCodes.Call, this.LuaAPI_lua_remove);
			}
			int in_param_count = 0;
			int out_param_count = 0;
			bool has_params = false;
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo pinfo = parameters[i];
				bool flag2 = !pinfo.IsOut;
				if (flag2)
				{
					Type ptype = pinfo.ParameterType;
					bool isParam = pinfo.IsDefined(typeof(ParamArrayAttribute), false);
					this.emitPush(il, ptype, (short)(i + 1), isParam, L, translator, true);
					bool flag3 = isParam;
					if (flag3)
					{
						has_params = true;
					}
					else
					{
						in_param_count++;
					}
				}
				bool isByRef = pinfo.ParameterType.IsByRef;
				if (isByRef)
				{
					out_param_count++;
				}
			}
			il.Emit(OpCodes.Ldloc, L);
			il.Emit(OpCodes.Ldc_I4, in_param_count + (isObj ? 1 : 0));
			bool flag4 = has_params;
			if (flag4)
			{
				Label l = il.DefineLabel();
				il.Emit(OpCodes.Ldarg, (short)parameters.Length);
				il.Emit(OpCodes.Brfalse, l);
				il.Emit(OpCodes.Ldarg, (short)parameters.Length);
				il.Emit(OpCodes.Ldlen);
				il.Emit(OpCodes.Add);
				il.MarkLabel(l);
			}
			il.Emit(OpCodes.Ldc_I4, out_param_count + (has_return ? 1 : 0));
			il.Emit(OpCodes.Ldloc, err_func);
			il.Emit(OpCodes.Call, this.LuaAPI_lua_pcall);
			Label no_exception = il.DefineLabel();
			il.Emit(OpCodes.Brfalse, no_exception);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldfld, this.LuaBase_luaEnv);
			il.Emit(OpCodes.Ldloc, err_func);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Sub);
			il.Emit(OpCodes.Callvirt, this.LuaEnv_ThrowExceptionFromError);
			il.MarkLabel(no_exception);
			int offset = 1;
			bool flag5 = has_return;
			if (flag5)
			{
				this.EmitGetObject(il, offset++, to_be_impl.ReturnType, L, translator, err_func, false);
				il.Emit(OpCodes.Stloc, ret);
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				ParameterInfo pinfo2 = parameters[j];
				Type ptype2 = pinfo2.ParameterType;
				bool isByRef2 = ptype2.IsByRef;
				if (isByRef2)
				{
					il.Emit(OpCodes.Ldarg, (short)(j + 1));
					Type pelemtype = ptype2.GetElementType();
					this.EmitGetObject(il, offset++, pelemtype, L, translator, err_func, false);
					bool isValueType = pelemtype.IsValueType;
					if (isValueType)
					{
						il.Emit(OpCodes.Stobj, pelemtype);
					}
					else
					{
						il.Emit(OpCodes.Stind_Ref);
					}
				}
			}
			bool flag6 = has_return;
			if (flag6)
			{
				il.Emit(OpCodes.Ldloc, ret);
			}
			il.Emit(OpCodes.Ldloc, L);
			il.Emit(OpCodes.Ldloc, err_func);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Sub);
			il.Emit(OpCodes.Call, this.LuaAPI_lua_settop);
			il.Emit(OpCodes.Ret);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0005292C File Offset: 0x00050B2C
		private void checkType(ILGenerator il, Type type, LocalBuilder translator, int argPos, Label endOfBlock, bool isVParam, bool isDefault)
		{
			Label endOfCheckType = il.DefineLabel();
			bool flag = isVParam || isDefault;
			if (flag)
			{
				il.Emit(OpCodes.Ldarg_0);
				il.Emit(OpCodes.Ldc_I4, argPos);
				il.Emit(OpCodes.Call, this.LuaAPI_lua_type);
				il.Emit(OpCodes.Ldc_I4_M1);
				il.Emit(OpCodes.Beq, endOfCheckType);
			}
			il.Emit(OpCodes.Ldloc, translator);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldc_I4, argPos);
			il.Emit(OpCodes.Ldtoken, isVParam ? type.GetElementType() : type);
			il.Emit(OpCodes.Call, this.Type_GetTypeFromHandle);
			il.Emit(OpCodes.Callvirt, this.ObjectTranslator_Assignable);
			il.Emit(OpCodes.Brfalse, endOfBlock);
			il.MarkLabel(endOfCheckType);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00052A0C File Offset: 0x00050C0C
		private void emitRegisterFunc(ILGenerator il, MethodBuilder method, int index, string name)
		{
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldc_I4, index);
			il.Emit(OpCodes.Ldstr, name);
			il.Emit(OpCodes.Ldnull);
			il.Emit(OpCodes.Ldftn, method);
			il.Emit(OpCodes.Newobj, this.LuaCSFunction_Constructor);
			il.Emit(OpCodes.Call, this.Utils_RegisterFunc);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00052A80 File Offset: 0x00050C80
		private void emitCatchBlock(ILGenerator il, LocalBuilder ex, LocalBuilder wrapRet, Label retPoint, Label exceptionBlock)
		{
			il.BeginCatchBlock(typeof(Exception));
			il.Emit(OpCodes.Stloc, ex);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldstr, "c# exception:");
			il.Emit(OpCodes.Ldloc, ex);
			il.Emit(OpCodes.Call, this.String_Concat);
			il.Emit(OpCodes.Call, this.LuaAPI_luaL_error);
			il.Emit(OpCodes.Stloc, wrapRet);
			il.Emit(OpCodes.Leave, retPoint);
			il.Emit(OpCodes.Leave, exceptionBlock);
			il.EndExceptionBlock();
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00052B2C File Offset: 0x00050D2C
		public MethodBuilder emitFieldWrap(TypeBuilder typeBuilder, FieldInfo field, bool genGetter)
		{
			string name = field.Name;
			ulong num = this.genID;
			this.genID = num + 1UL;
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(name + num.ToString(), MethodAttributes.Static, typeof(int), this.parameterTypeOfWrap);
			methodBuilder.DefineParameter(1, ParameterAttributes.None, "L");
			ILGenerator il = methodBuilder.GetILGenerator();
			LocalBuilder L = il.DeclareLocal(typeof(IntPtr));
			LocalBuilder translator = il.DeclareLocal(typeof(ObjectTranslator));
			LocalBuilder fieldStore = il.DeclareLocal(field.FieldType);
			LocalBuilder wrapRet = il.DeclareLocal(typeof(int));
			LocalBuilder ex = il.DeclareLocal(typeof(Exception));
			Label exceptionBlock = il.BeginExceptionBlock();
			Label retPoint = il.DefineLabel();
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Stloc, L);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Call, this.ObjectTranslatorPool_FindTranslator);
			il.Emit(OpCodes.Stloc, translator);
			if (genGetter)
			{
				bool flag = !field.IsStatic;
				if (flag)
				{
					this.EmitGetObject(il, 1, field.DeclaringType, L, translator, null, false);
					il.Emit(OpCodes.Ldfld, field);
				}
				else
				{
					il.Emit(OpCodes.Ldsfld, field);
				}
				il.Emit(OpCodes.Stloc, fieldStore);
				this.emitPush(il, field.FieldType, 2, false, L, translator, false);
			}
			else
			{
				bool flag2 = !field.IsStatic;
				if (flag2)
				{
					this.EmitGetObject(il, 1, field.DeclaringType, L, translator, null, false);
					LocalBuilder self = null;
					bool isValueType = field.DeclaringType.IsValueType;
					if (isValueType)
					{
						self = il.DeclareLocal(field.DeclaringType);
						il.Emit(OpCodes.Stloc, self);
						il.Emit(OpCodes.Ldloca, self);
					}
					this.EmitGetObject(il, 2, field.FieldType, L, translator, null, false);
					il.Emit(OpCodes.Stfld, field);
					bool flag3 = self != null;
					if (flag3)
					{
						this.emitUpdateIfNeeded(il, L, translator, field.DeclaringType, 1, self.LocalIndex);
					}
				}
				else
				{
					this.EmitGetObject(il, 1, field.FieldType, L, translator, null, false);
					il.Emit(OpCodes.Stsfld, field);
				}
			}
			il.Emit(OpCodes.Leave, exceptionBlock);
			this.emitCatchBlock(il, ex, wrapRet, retPoint, exceptionBlock);
			il.Emit(genGetter ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0);
			il.Emit(OpCodes.Ret);
			il.MarkLabel(retPoint);
			il.Emit(OpCodes.Ldloc, wrapRet);
			il.Emit(OpCodes.Ret);
			return methodBuilder;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00052DE4 File Offset: 0x00050FE4
		public MethodBuilder emitPropertyWrap(TypeBuilder typeBuilder, PropertyInfo prop, MethodInfo op, bool genGetter)
		{
			string name = prop.Name;
			ulong num = this.genID;
			this.genID = num + 1UL;
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(name + num.ToString(), MethodAttributes.Static, typeof(int), this.parameterTypeOfWrap);
			methodBuilder.DefineParameter(1, ParameterAttributes.None, "L");
			ILGenerator il = methodBuilder.GetILGenerator();
			LocalBuilder L = il.DeclareLocal(typeof(IntPtr));
			LocalBuilder translator = il.DeclareLocal(typeof(ObjectTranslator));
			LocalBuilder propStore = il.DeclareLocal(prop.PropertyType);
			LocalBuilder wrapRet = il.DeclareLocal(typeof(int));
			LocalBuilder ex = il.DeclareLocal(typeof(Exception));
			Label exceptionBlock = il.BeginExceptionBlock();
			Label retPoint = il.DefineLabel();
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Stloc, L);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Call, this.ObjectTranslatorPool_FindTranslator);
			il.Emit(OpCodes.Stloc, translator);
			if (genGetter)
			{
				bool flag = !op.IsStatic;
				if (flag)
				{
					this.EmitGetObject(il, 1, prop.DeclaringType, L, translator, null, false);
					bool isValueType = prop.DeclaringType.IsValueType;
					if (isValueType)
					{
						LocalBuilder self = il.DeclareLocal(prop.DeclaringType);
						il.Emit(OpCodes.Stloc, self);
						il.Emit(OpCodes.Ldloca, self);
						il.Emit(OpCodes.Call, op);
						this.emitUpdateIfNeeded(il, L, translator, prop.DeclaringType, 1, self.LocalIndex);
					}
					else
					{
						il.Emit(OpCodes.Callvirt, op);
					}
				}
				else
				{
					il.Emit(OpCodes.Call, op);
				}
				il.Emit(OpCodes.Stloc, propStore);
				this.emitPush(il, prop.PropertyType, (short)propStore.LocalIndex, false, L, translator, false);
			}
			else
			{
				bool flag2 = !op.IsStatic;
				if (flag2)
				{
					this.EmitGetObject(il, 1, prop.DeclaringType, L, translator, null, false);
					LocalBuilder self2 = null;
					bool isValueType2 = prop.DeclaringType.IsValueType;
					if (isValueType2)
					{
						self2 = il.DeclareLocal(prop.DeclaringType);
						il.Emit(OpCodes.Stloc, self2);
						il.Emit(OpCodes.Ldloca, self2);
					}
					this.EmitGetObject(il, 2, prop.PropertyType, L, translator, null, false);
					il.Emit(prop.DeclaringType.IsValueType ? OpCodes.Call : OpCodes.Callvirt, op);
					bool flag3 = self2 != null;
					if (flag3)
					{
						this.emitUpdateIfNeeded(il, L, translator, prop.DeclaringType, 1, self2.LocalIndex);
					}
				}
				else
				{
					this.EmitGetObject(il, 1, prop.PropertyType, L, translator, null, false);
					il.Emit(OpCodes.Call, op);
				}
			}
			il.Emit(OpCodes.Leave, exceptionBlock);
			this.emitCatchBlock(il, ex, wrapRet, retPoint, exceptionBlock);
			il.Emit(genGetter ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0);
			il.Emit(OpCodes.Ret);
			il.MarkLabel(retPoint);
			il.Emit(OpCodes.Ldloc, wrapRet);
			il.Emit(OpCodes.Ret);
			return methodBuilder;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00053124 File Offset: 0x00051324
		private static void addToBlackList(List<string> info)
		{
			try
			{
				Type type = Type.GetType(info[0], true);
				MemberInfo[] members = type.GetMember(info[1], BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
				MemberInfo[] array = members;
				int j = 0;
				while (j < array.Length)
				{
					MemberInfo member = array[j];
					bool flag = member.MemberType == MemberTypes.Method;
					if (flag)
					{
						MethodBase mb = member as MethodBase;
						ParameterInfo[] parameters = mb.GetParameters();
						bool flag2 = parameters.Length != info.Count - 2;
						if (!flag2)
						{
							bool paramsMatch = true;
							for (int i = 0; i < parameters.Length; i++)
							{
								bool flag3 = parameters[i].ParameterType.FullName != info[i + 2];
								if (flag3)
								{
									paramsMatch = false;
									break;
								}
							}
							bool flag4 = paramsMatch;
							if (flag4)
							{
								CodeEmit.BlackList.Add(member);
							}
						}
					}
					else
					{
						bool flag5 = info.Count == 2;
						if (flag5)
						{
							CodeEmit.BlackList.Add(member);
						}
					}
					IL_F4:
					j++;
					continue;
					goto IL_F4;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00053258 File Offset: 0x00051458
		private static void initBlackList()
		{
			foreach (Type t in Utils.GetAllTypes(true))
			{
				bool flag = !t.IsAbstract || !t.IsSealed;
				if (!flag)
				{
					foreach (FieldInfo field in t.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
					{
						bool flag2 = field.IsDefined(typeof(BlackListAttribute), false) && typeof(List<List<string>>).IsAssignableFrom(field.FieldType);
						if (flag2)
						{
							foreach (List<string> info in (field.GetValue(null) as List<List<string>>))
							{
								CodeEmit.addToBlackList(info);
							}
						}
					}
					foreach (PropertyInfo prop in t.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
					{
						bool flag3 = prop.IsDefined(typeof(BlackListAttribute), false) && typeof(List<List<string>>).IsAssignableFrom(prop.PropertyType);
						if (flag3)
						{
							foreach (List<string> info2 in (prop.GetValue(null, null) as List<List<string>>))
							{
								CodeEmit.addToBlackList(info2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0005345C File Offset: 0x0005165C
		private static bool isMemberInBlackList(MemberInfo mb)
		{
			bool flag = mb is FieldInfo && (mb as FieldInfo).FieldType.IsPointer;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				bool flag2 = mb is PropertyInfo && (mb as PropertyInfo).PropertyType.IsPointer;
				if (flag2)
				{
					result = true;
				}
				else
				{
					bool flag3 = mb.IsDefined(typeof(BlackListAttribute), false) || mb.IsDefined(typeof(ObsoleteAttribute), false);
					result = (flag3 || CodeEmit.BlackList.Contains(mb));
				}
			}
			return result;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000534F0 File Offset: 0x000516F0
		private static bool isMethodInBlackList(MethodBase mb)
		{
			bool flag = mb.GetParameters().Any((ParameterInfo pInfo) => pInfo.ParameterType.IsPointer);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				bool flag2 = mb is MethodInfo && (mb as MethodInfo).ReturnType.IsPointer;
				if (flag2)
				{
					result = false;
				}
				else
				{
					bool flag3 = mb.IsDefined(typeof(BlackListAttribute), false) || mb.IsDefined(typeof(ObsoleteAttribute), false);
					result = (flag3 || CodeEmit.BlackList.Contains(mb));
				}
			}
			return result;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00053594 File Offset: 0x00051794
		public Type EmitTypeWrap(Type toBeWrap)
		{
			ModuleBuilder moduleBuilder = this.CodeEmitModule;
			string name = toBeWrap.Name;
			string str = "Wrap";
			ulong num = this.genID;
			this.genID = num + 1UL;
			TypeBuilder wrapTypeBuilder = moduleBuilder.DefineType(name + str + num.ToString(), TypeAttributes.Public | TypeAttributes.Abstract | TypeAttributes.Sealed);
			MethodBuilder methodBuilder = wrapTypeBuilder.DefineMethod("__Register", MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, null, this.parameterTypeOfWrap);
			methodBuilder.DefineParameter(1, ParameterAttributes.None, "L");
			ILGenerator il = methodBuilder.GetILGenerator();
			LocalBuilder translator = il.DeclareLocal(typeof(ObjectTranslator));
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Call, this.ObjectTranslatorPool_FindTranslator);
			il.Emit(OpCodes.Stloc, translator);
			BindingFlags instanceFlag = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
			BindingFlags staticFlag = BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public;
			IEnumerable<FieldInfo> instanceFields = from m in toBeWrap.GetFields(instanceFlag).AsEnumerable<FieldInfo>()
			where !CodeEmit.isMemberInBlackList(m)
			select m;
			IEnumerable<PropertyInfo> instanceProperties = from m in toBeWrap.GetProperties(instanceFlag).AsEnumerable<PropertyInfo>()
			where !CodeEmit.isMemberInBlackList(m)
			select m;
			IEnumerable<MethodInfo> extensionMethods = Utils.GetExtensionMethodsOf(toBeWrap);
			IEnumerable<MethodInfo> enumerable;
			if (extensionMethods != null)
			{
				enumerable = from m in extensionMethods.AsEnumerable<MethodInfo>()
				where !CodeEmit.isMemberInBlackList(m)
				select m;
			}
			else
			{
				enumerable = Enumerable.Empty<MethodInfo>();
			}
			extensionMethods = enumerable;
			List<IGrouping<string, MethodInfo>> instanceMethods = (from m in (from m in toBeWrap.GetMethods(instanceFlag).AsEnumerable<MethodInfo>()
			where !CodeEmit.isMethodInBlackList(m)
			select m).Concat(extensionMethods).AsEnumerable<MethodInfo>()
			where Utils.IsSupportedMethod(m)
			where !m.IsSpecialName || (((m.Name == "get_Item" && m.GetParameters().Length == 1) || (m.Name == "set_Item" && m.GetParameters().Length == 2)) && m.GetParameters()[0].ParameterType.IsAssignableFrom(typeof(string)))
			group m by m.Name).ToList<IGrouping<string, MethodInfo>>();
			IEnumerable<IGrouping<string, MethodInfo>> supportOperators = from m in toBeWrap.GetMethods(staticFlag)
			where !CodeEmit.isMethodInBlackList(m)
			where m.IsSpecialName && InternalGlobals.supportOp.ContainsKey(m.Name)
			group m by m.Name;
			il.Emit(OpCodes.Ldtoken, toBeWrap);
			il.Emit(OpCodes.Call, this.Type_GetTypeFromHandle);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldloc, translator);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Ldc_I4_M1);
			il.Emit(OpCodes.Call, this.Utils_BeginObjectRegister);
			foreach (FieldInfo field in instanceFields)
			{
				this.emitRegisterFunc(il, this.emitFieldWrap(wrapTypeBuilder, field, true), -2, field.Name);
				this.emitRegisterFunc(il, this.emitFieldWrap(wrapTypeBuilder, field, false), -1, field.Name);
			}
			List<MethodBase> itemGetter = new List<MethodBase>();
			List<MethodBase> itemSetter = new List<MethodBase>();
			foreach (PropertyInfo prop in instanceProperties)
			{
				MethodInfo getter = prop.GetGetMethod();
				bool flag = getter != null && getter.IsPublic;
				if (flag)
				{
					bool flag2 = prop.GetIndexParameters().Length != 0;
					if (flag2)
					{
						bool flag3 = !prop.GetIndexParameters()[0].ParameterType.IsAssignableFrom(typeof(string));
						if (flag3)
						{
							itemGetter.Add(getter);
						}
					}
					else
					{
						this.emitRegisterFunc(il, this.emitPropertyWrap(wrapTypeBuilder, prop, getter, true), -2, prop.Name);
					}
				}
				MethodInfo setter = prop.GetSetMethod();
				bool flag4 = setter != null && setter.IsPublic;
				if (flag4)
				{
					bool flag5 = prop.GetIndexParameters().Length != 0;
					if (flag5)
					{
						bool flag6 = !prop.GetIndexParameters()[0].ParameterType.IsAssignableFrom(typeof(string));
						if (flag6)
						{
							itemSetter.Add(setter);
						}
					}
					else
					{
						this.emitRegisterFunc(il, this.emitPropertyWrap(wrapTypeBuilder, prop, setter, false), -1, prop.Name);
					}
				}
			}
			foreach (IGrouping<string, MethodInfo> group in instanceMethods)
			{
				this.emitRegisterFunc(il, this.emitMethodWrap(wrapTypeBuilder, group.Cast<MethodBase>().ToList<MethodBase>(), false, toBeWrap, null), -3, group.Key);
			}
			foreach (IGrouping<string, MethodInfo> group2 in supportOperators)
			{
				this.emitRegisterFunc(il, this.emitMethodWrap(wrapTypeBuilder, group2.Cast<MethodBase>().ToList<MethodBase>(), false, toBeWrap, null), -4, InternalGlobals.supportOp[group2.Key]);
			}
			foreach (EventInfo ev in from m in toBeWrap.GetEvents(instanceFlag)
			where !CodeEmit.isMemberInBlackList(m)
			select m)
			{
				this.emitRegisterFunc(il, this.emitEventWrap(wrapTypeBuilder, ev), -3, ev.Name);
			}
			il.Emit(OpCodes.Ldtoken, toBeWrap);
			il.Emit(OpCodes.Call, this.Type_GetTypeFromHandle);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldloc, translator);
			il.Emit(OpCodes.Ldnull);
			bool flag7 = itemGetter.Count > 0;
			if (flag7)
			{
				il.Emit(OpCodes.Ldftn, this.emitMethodWrap(wrapTypeBuilder, itemGetter, true, toBeWrap, null));
				il.Emit(OpCodes.Newobj, this.LuaCSFunction_Constructor);
			}
			il.Emit(OpCodes.Ldnull);
			bool flag8 = itemSetter.Count > 0;
			if (flag8)
			{
				il.Emit(OpCodes.Ldftn, this.emitMethodWrap(wrapTypeBuilder, itemSetter, true, toBeWrap, null));
				il.Emit(OpCodes.Newobj, this.LuaCSFunction_Constructor);
			}
			il.Emit(OpCodes.Ldnull);
			il.Emit(OpCodes.Ldnull);
			il.Emit(OpCodes.Ldnull);
			il.Emit(OpCodes.Call, this.Utils_EndObjectRegister);
			il.Emit(OpCodes.Ldtoken, toBeWrap);
			il.Emit(OpCodes.Call, this.Type_GetTypeFromHandle);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldnull);
			il.Emit(OpCodes.Ldftn, this.emitMethodWrap(wrapTypeBuilder, (from m in toBeWrap.GetConstructors(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public)
			where !CodeEmit.isMethodInBlackList(m)
			select m).Cast<MethodBase>().ToList<MethodBase>(), false, toBeWrap, toBeWrap.ToString() + " constructor"));
			il.Emit(OpCodes.Newobj, this.LuaCSFunction_Constructor);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Ldc_I4_1);
			il.Emit(OpCodes.Call, this.Utils_BeginClassRegister);
			IEnumerable<IGrouping<string, MethodInfo>> staticMethods = from m in toBeWrap.GetMethods(staticFlag)
			where !CodeEmit.isMethodInBlackList(m)
			where Utils.IsSupportedMethod(m)
			where !m.IsSpecialName
			group m by m.Name;
			IEnumerable<FieldInfo> staticFields = from m in toBeWrap.GetFields(staticFlag)
			where !CodeEmit.isMemberInBlackList(m)
			select m;
			IEnumerable<PropertyInfo> staticProperties = from m in toBeWrap.GetProperties(staticFlag)
			where !CodeEmit.isMemberInBlackList(m)
			select m;
			foreach (IGrouping<string, MethodInfo> group3 in staticMethods)
			{
				this.emitRegisterFunc(il, this.emitMethodWrap(wrapTypeBuilder, group3.Cast<MethodBase>().ToList<MethodBase>(), false, toBeWrap, null), -4, group3.Key);
			}
			foreach (EventInfo ev2 in from m in toBeWrap.GetEvents(staticFlag)
			where !CodeEmit.isMemberInBlackList(m)
			select m)
			{
				this.emitRegisterFunc(il, this.emitEventWrap(wrapTypeBuilder, ev2), -4, ev2.Name);
			}
			foreach (PropertyInfo prop2 in staticProperties)
			{
				MethodInfo getter2 = prop2.GetGetMethod();
				bool flag9 = getter2 != null && getter2.IsPublic;
				if (flag9)
				{
					this.emitRegisterFunc(il, this.emitPropertyWrap(wrapTypeBuilder, prop2, getter2, true), -2, prop2.Name);
				}
				MethodInfo setter2 = prop2.GetSetMethod();
				bool flag10 = setter2 != null && setter2.IsPublic;
				if (flag10)
				{
					this.emitRegisterFunc(il, this.emitPropertyWrap(wrapTypeBuilder, prop2, setter2, false), -1, prop2.Name);
				}
			}
			foreach (FieldInfo field2 in staticFields)
			{
				bool flag11 = field2.IsInitOnly || field2.IsLiteral;
				if (flag11)
				{
					il.Emit(OpCodes.Ldarg_0);
					il.Emit(OpCodes.Ldloc, translator);
					il.Emit(OpCodes.Ldc_I4, -4);
					il.Emit(OpCodes.Ldstr, field2.Name);
					bool isLiteral = field2.IsLiteral;
					if (isLiteral)
					{
						LocalBuilder literalStore = il.DeclareLocal(field2.FieldType);
						this.emitLiteralLoad(il, field2.FieldType, field2.GetValue(null), literalStore.LocalIndex);
						il.Emit(OpCodes.Stloc, literalStore);
						il.Emit(OpCodes.Ldloc, literalStore);
					}
					else
					{
						il.Emit(OpCodes.Ldsfld, field2);
					}
					bool isValueType = field2.FieldType.IsValueType;
					if (isValueType)
					{
						il.Emit(OpCodes.Box, field2.FieldType);
					}
					il.Emit(OpCodes.Call, this.Utils_RegisterObject);
				}
				else
				{
					this.emitRegisterFunc(il, this.emitFieldWrap(wrapTypeBuilder, field2, true), -2, field2.Name);
					this.emitRegisterFunc(il, this.emitFieldWrap(wrapTypeBuilder, field2, false), -1, field2.Name);
				}
			}
			il.Emit(OpCodes.Ldtoken, toBeWrap);
			il.Emit(OpCodes.Call, this.Type_GetTypeFromHandle);
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Ldloc, translator);
			il.Emit(OpCodes.Call, this.Utils_EndClassRegister);
			il.Emit(OpCodes.Ret);
			return wrapTypeBuilder.CreateType();
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0005427C File Offset: 0x0005247C
		private MethodBuilder emitEventWrap(TypeBuilder typeBuilder, EventInfo ev)
		{
			MethodInfo addEvent = ev.GetAddMethod();
			MethodInfo removeEvent = ev.GetRemoveMethod();
			bool flag = addEvent == null && removeEvent == null;
			MethodBuilder result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool isStatic = (addEvent != null) ? addEvent.IsStatic : removeEvent.IsStatic;
				string name = ev.Name;
				ulong num = this.genID;
				this.genID = num + 1UL;
				MethodBuilder methodBuilder = typeBuilder.DefineMethod(name + num.ToString(), MethodAttributes.Static, typeof(int), this.parameterTypeOfWrap);
				methodBuilder.DefineParameter(1, ParameterAttributes.None, "L");
				ILGenerator il = methodBuilder.GetILGenerator();
				LocalBuilder wrapRet = il.DeclareLocal(typeof(int));
				LocalBuilder ex = il.DeclareLocal(typeof(Exception));
				LocalBuilder L = il.DeclareLocal(typeof(IntPtr));
				LocalBuilder translator = il.DeclareLocal(typeof(ObjectTranslator));
				LocalBuilder callback = il.DeclareLocal(ev.EventHandlerType);
				il.Emit(OpCodes.Ldarg_0);
				il.Emit(OpCodes.Stloc, L);
				Label exceptionBlock = il.BeginExceptionBlock();
				Label retPoint = il.DefineLabel();
				il.Emit(OpCodes.Ldarg_0);
				il.Emit(OpCodes.Call, this.ObjectTranslatorPool_FindTranslator);
				il.Emit(OpCodes.Stloc, translator);
				this.EmitGetObject(il, isStatic ? 2 : 3, ev.EventHandlerType, L, translator, null, false);
				il.Emit(OpCodes.Stloc, callback);
				il.Emit(OpCodes.Ldloc, callback);
				Label ifBlock = il.DefineLabel();
				il.Emit(OpCodes.Brtrue, ifBlock);
				il.Emit(OpCodes.Ldarg_0);
				il.Emit(OpCodes.Ldstr, ZString.Format<object, object>("#{0}, need {1}", isStatic ? 2 : 3, ev.EventHandlerType));
				il.Emit(OpCodes.Call, this.LuaAPI_luaL_error);
				il.Emit(OpCodes.Stloc, wrapRet);
				il.Emit(OpCodes.Leave, retPoint);
				il.MarkLabel(ifBlock);
				bool flag2 = addEvent != null;
				if (flag2)
				{
					il.Emit(OpCodes.Ldarg_0);
					il.Emit(isStatic ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_2);
					il.Emit(OpCodes.Ldstr, "+");
					il.Emit(OpCodes.Call, this.LuaAPI_xlua_is_eq_str);
					ifBlock = il.DefineLabel();
					il.Emit(OpCodes.Brfalse, ifBlock);
					bool flag3 = !isStatic;
					if (flag3)
					{
						this.EmitGetObject(il, 1, ev.DeclaringType, L, translator, null, false);
						bool isValueType = ev.DeclaringType.IsValueType;
						if (isValueType)
						{
							LocalBuilder self = il.DeclareLocal(ev.DeclaringType);
							il.Emit(OpCodes.Stloc, self);
							il.Emit(OpCodes.Ldloca, self);
						}
					}
					il.Emit(OpCodes.Ldloc, callback);
					il.Emit(OpCodes.Call, addEvent);
					il.Emit(OpCodes.Ldc_I4_0);
					il.Emit(OpCodes.Leave, retPoint);
					il.MarkLabel(ifBlock);
				}
				bool flag4 = removeEvent != null;
				if (flag4)
				{
					il.Emit(OpCodes.Ldarg_0);
					il.Emit(isStatic ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_2);
					il.Emit(OpCodes.Ldstr, "-");
					il.Emit(OpCodes.Call, this.LuaAPI_xlua_is_eq_str);
					ifBlock = il.DefineLabel();
					il.Emit(OpCodes.Brfalse, ifBlock);
					bool flag5 = !isStatic;
					if (flag5)
					{
						this.EmitGetObject(il, 1, ev.DeclaringType, L, translator, null, false);
						bool isValueType2 = ev.DeclaringType.IsValueType;
						if (isValueType2)
						{
							LocalBuilder self2 = il.DeclareLocal(ev.DeclaringType);
							il.Emit(OpCodes.Stloc, self2);
							il.Emit(OpCodes.Ldloca, self2);
						}
					}
					il.Emit(OpCodes.Ldloc, callback);
					il.Emit(OpCodes.Call, removeEvent);
					il.Emit(OpCodes.Ldc_I4_0);
					il.Emit(OpCodes.Leave, retPoint);
					il.MarkLabel(ifBlock);
				}
				il.Emit(OpCodes.Leave, exceptionBlock);
				this.emitCatchBlock(il, ex, wrapRet, retPoint, exceptionBlock);
				il.Emit(OpCodes.Ldarg_0);
				ILGenerator ilgenerator = il;
				OpCode ldstr = OpCodes.Ldstr;
				string[] array = new string[5];
				array[0] = "invalid arguments to ";
				int num2 = 1;
				Type declaringType = ev.DeclaringType;
				array[num2] = ((declaringType != null) ? declaringType.ToString() : null);
				array[2] = ".";
				array[3] = ev.Name;
				array[4] = "!";
				ilgenerator.Emit(ldstr, string.Concat(array));
				il.Emit(OpCodes.Call, this.LuaAPI_luaL_error);
				il.Emit(OpCodes.Ret);
				il.MarkLabel(retPoint);
				il.Emit(OpCodes.Ldloc, wrapRet);
				il.Emit(OpCodes.Ret);
				result = methodBuilder;
			}
			return result;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0005479C File Offset: 0x0005299C
		private void emitUpdateIfNeeded(ILGenerator il, LocalBuilder L, LocalBuilder translator, Type type, int luaIndex, int localIndex)
		{
			bool flag = type.IsValueType && !type.IsPrimitive && !type.IsEnum() && type != typeof(decimal);
			if (flag)
			{
				il.Emit(OpCodes.Ldloc, translator);
				il.Emit(OpCodes.Ldloc, L);
				il.Emit(OpCodes.Ldc_I4, luaIndex);
				il.Emit(OpCodes.Ldloc, localIndex);
				il.Emit(OpCodes.Box, type);
				il.Emit(OpCodes.Callvirt, this.ObjectTranslator_Update);
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00054838 File Offset: 0x00052A38
		private int firstDefaultValue(MethodBase method)
		{
			ParameterInfo[] parameters = method.GetParameters();
			for (int i = 0; i < parameters.Length; i++)
			{
				bool isOptional = parameters[i].IsOptional;
				if (isOptional)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00054878 File Offset: 0x00052A78
		private MethodBuilder emitMethodWrap(TypeBuilder typeBuilder, List<MethodBase> methodsToCall, bool isIndexer, Type declaringType, string methodDesciption = null)
		{
			string wrapName = (methodsToCall.Count > 0) ? methodsToCall[0].Name : "Constructor";
			string str = wrapName;
			ulong num = this.genID;
			this.genID = num + 1UL;
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(str + num.ToString(), MethodAttributes.Static, typeof(int), this.parameterTypeOfWrap);
			methodBuilder.DefineParameter(1, ParameterAttributes.None, "L");
			bool needCheckParameterType = methodsToCall.Count > 1 || isIndexer;
			bool flag = methodsToCall.Count == 0 || methodsToCall[0].IsConstructor;
			if (flag)
			{
				needCheckParameterType = true;
			}
			bool flag2 = methodsToCall.Count == 1 && this.firstDefaultValue(methodsToCall[0]) != -1;
			if (flag2)
			{
				needCheckParameterType = true;
			}
			ILGenerator il = methodBuilder.GetILGenerator();
			LocalBuilder wrapRet = il.DeclareLocal(typeof(int));
			LocalBuilder ex = il.DeclareLocal(typeof(Exception));
			LocalBuilder L = il.DeclareLocal(typeof(IntPtr));
			LocalBuilder translator = il.DeclareLocal(typeof(ObjectTranslator));
			LocalBuilder top = il.DeclareLocal(typeof(int));
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Stloc, L);
			Label exceptionBlock = il.BeginExceptionBlock();
			Label retPoint = il.DefineLabel();
			il.Emit(OpCodes.Ldarg_0);
			il.Emit(OpCodes.Call, this.ObjectTranslatorPool_FindTranslator);
			il.Emit(OpCodes.Stloc, translator);
			bool flag3 = needCheckParameterType;
			if (flag3)
			{
				il.Emit(OpCodes.Ldarg_0);
				il.Emit(OpCodes.Call, this.LuaAPI_lua_gettop);
				il.Emit(OpCodes.Stloc, top);
			}
			for (int i = 0; i < methodsToCall.Count; i++)
			{
				MethodBase method = methodsToCall[i];
				bool flag4 = method is MethodInfo && method.ContainsGenericParameters;
				if (flag4)
				{
					method = Utils.MakeGenericMethodWithConstraints(method as MethodInfo);
				}
				bool isStatic = method.IsStatic;
				ParameterInfo[] paramInfos = method.GetParameters();
				int minInParamCount = 0;
				int maxInParamCount = 0;
				int outParamCount = 0;
				bool hasParams = paramInfos.Length != 0 && paramInfos[paramInfos.Length - 1].IsDefined(typeof(ParamArrayAttribute), false);
				bool hasOptional = false;
				LocalBuilder methodReturn = null;
				for (int j = 0; j < paramInfos.Length; j++)
				{
					bool flag5 = !paramInfos[j].IsOut;
					if (flag5)
					{
						bool flag6 = !paramInfos[j].IsOptional && (!hasParams || j != paramInfos.Length - 1);
						if (flag6)
						{
							minInParamCount++;
						}
						maxInParamCount++;
					}
					bool isOptional = paramInfos[j].IsOptional;
					if (isOptional)
					{
						hasOptional = true;
					}
					bool isByRef = paramInfos[j].ParameterType.IsByRef;
					if (isByRef)
					{
						outParamCount++;
					}
				}
				Label endOfBlock = il.DefineLabel();
				bool flag7 = needCheckParameterType;
				if (flag7)
				{
					il.Emit(OpCodes.Ldloc, top);
					il.Emit(OpCodes.Ldc_I4, minInParamCount + (isStatic ? 0 : 1));
					il.Emit((hasParams || hasOptional) ? OpCodes.Blt : OpCodes.Bne_Un, endOfBlock);
					bool flag8 = hasOptional && !hasParams;
					if (flag8)
					{
						il.Emit(OpCodes.Ldloc, top);
						il.Emit(OpCodes.Ldc_I4, maxInParamCount + (isStatic ? 0 : 1));
						il.Emit(OpCodes.Bgt, endOfBlock);
					}
					bool flag9 = !isStatic && !method.IsConstructor;
					if (flag9)
					{
						this.checkType(il, method.DeclaringType, translator, 1, endOfBlock, false, false);
					}
					int argPos = isStatic ? 1 : 2;
					for (int k = 0; k < paramInfos.Length; k++)
					{
						ParameterInfo paramInfo = paramInfos[k];
						bool flag10 = !paramInfo.IsOut;
						if (flag10)
						{
							Type rawParamType = paramInfo.ParameterType;
							bool isByRef2 = rawParamType.IsByRef;
							if (isByRef2)
							{
								rawParamType = rawParamType.GetElementType();
							}
							this.checkType(il, rawParamType, translator, argPos++, endOfBlock, hasParams && k == paramInfos.Length - 1, paramInfo.IsOptional);
						}
					}
				}
				int luaPos = isStatic ? 1 : 2;
				int argStoreStart = -1;
				foreach (ParameterInfo paramInfo2 in paramInfos)
				{
					Type paramRawType = paramInfo2.ParameterType.IsByRef ? paramInfo2.ParameterType.GetElementType() : paramInfo2.ParameterType;
					LocalBuilder argStore = il.DeclareLocal(paramRawType);
					bool isOptional2 = paramInfo2.IsOptional;
					if (isOptional2)
					{
						this.emitLiteralLoad(il, paramRawType, paramInfo2.DefaultValue, argStore.LocalIndex);
						il.Emit(OpCodes.Stloc, argStore);
					}
					bool flag11 = argStoreStart == -1;
					if (flag11)
					{
						argStoreStart = argStore.LocalIndex;
					}
				}
				for (int m = 0; m < paramInfos.Length; m++)
				{
					ParameterInfo paramInfo3 = paramInfos[m];
					Type paramRawType2 = paramInfo3.ParameterType.IsByRef ? paramInfo3.ParameterType.GetElementType() : paramInfo3.ParameterType;
					bool flag12 = !paramInfo3.IsOut;
					if (flag12)
					{
						Label endOfGetValue = il.DefineLabel();
						bool isOptional3 = paramInfo3.IsOptional;
						if (isOptional3)
						{
							il.Emit(OpCodes.Ldarg_0);
							il.Emit(OpCodes.Ldc_I4, luaPos);
							il.Emit(OpCodes.Call, this.LuaAPI_lua_type);
							il.Emit(OpCodes.Ldc_I4_M1);
							il.Emit(OpCodes.Beq, endOfGetValue);
						}
						this.EmitGetObject(il, luaPos++, paramRawType2, L, translator, null, hasParams && m == paramInfos.Length - 1);
						il.Emit(OpCodes.Stloc, argStoreStart + m);
						il.MarkLabel(endOfGetValue);
					}
				}
				LocalBuilder valueTypeTmp = null;
				bool flag13 = !isStatic && (!method.IsConstructor || method.DeclaringType.IsValueType);
				if (flag13)
				{
					bool flag14 = !method.IsConstructor;
					if (flag14)
					{
						this.EmitGetObject(il, 1, method.DeclaringType, L, translator, null, false);
					}
					bool isValueType = method.DeclaringType.IsValueType;
					if (isValueType)
					{
						bool isConstructor = method.IsConstructor;
						if (isConstructor)
						{
							methodReturn = il.DeclareLocal(method.DeclaringType);
							il.Emit(OpCodes.Ldloca, methodReturn);
						}
						else
						{
							valueTypeTmp = il.DeclareLocal(method.DeclaringType);
							il.Emit(OpCodes.Stloc, valueTypeTmp);
							il.Emit(OpCodes.Ldloca, valueTypeTmp);
						}
					}
				}
				for (int n = 0; n < paramInfos.Length; n++)
				{
					il.Emit(paramInfos[n].ParameterType.IsByRef ? OpCodes.Ldloca : OpCodes.Ldloc, argStoreStart + n);
				}
				bool isConstructor2 = method.IsConstructor;
				if (isConstructor2)
				{
					bool isValueType2 = method.DeclaringType.IsValueType;
					if (isValueType2)
					{
						il.Emit(OpCodes.Call, method as ConstructorInfo);
					}
					else
					{
						il.Emit(OpCodes.Newobj, method as ConstructorInfo);
					}
				}
				else
				{
					il.Emit(isStatic ? OpCodes.Call : OpCodes.Callvirt, method as MethodInfo);
				}
				bool flag15 = valueTypeTmp != null;
				if (flag15)
				{
					this.emitUpdateIfNeeded(il, L, translator, method.DeclaringType, 1, valueTypeTmp.LocalIndex);
				}
				if (isIndexer)
				{
					il.Emit(OpCodes.Ldarg_0);
					il.Emit(OpCodes.Ldc_I4_1);
					il.Emit(OpCodes.Call, this.LuaAPI_lua_pushboolean);
				}
				bool hasReturn = false;
				MethodInfo methodInfo = method as MethodInfo;
				bool flag16 = methodInfo == null || methodInfo.ReturnType != typeof(void);
				if (flag16)
				{
					hasReturn = true;
					Type returnType = (methodInfo == null) ? method.DeclaringType : methodInfo.ReturnType;
					bool flag17 = methodReturn == null;
					if (flag17)
					{
						methodReturn = il.DeclareLocal(returnType);
						il.Emit(OpCodes.Stloc, methodReturn);
					}
					this.emitPush(il, returnType, (short)methodReturn.LocalIndex, false, L, translator, false);
				}
				int luaIndex = isStatic ? 1 : 2;
				for (int j2 = 0; j2 < paramInfos.Length; j2++)
				{
					bool isByRef3 = paramInfos[j2].ParameterType.IsByRef;
					if (isByRef3)
					{
						Type rawParamType2 = paramInfos[j2].ParameterType.GetElementType();
						this.emitPush(il, rawParamType2, (short)(argStoreStart + j2), false, L, translator, false);
						bool flag18 = !paramInfos[j2].IsOut;
						if (flag18)
						{
							this.emitUpdateIfNeeded(il, L, translator, rawParamType2, luaIndex, argStoreStart + j2);
						}
					}
					bool flag19 = !paramInfos[j2].IsOut;
					if (flag19)
					{
						luaIndex++;
					}
				}
				il.Emit(OpCodes.Ldc_I4, outParamCount + (hasReturn ? 1 : 0) + (isIndexer ? 1 : 0));
				il.Emit(OpCodes.Stloc, wrapRet);
				il.Emit(OpCodes.Leave, retPoint);
				bool flag20 = needCheckParameterType;
				if (flag20)
				{
					il.MarkLabel(endOfBlock);
				}
			}
			bool flag21 = declaringType.IsValueType && (methodsToCall.Count == 0 || methodsToCall[0].IsConstructor);
			if (flag21)
			{
				Label endOfBlock2 = il.DefineLabel();
				il.Emit(OpCodes.Ldloc, top);
				il.Emit(OpCodes.Ldc_I4_1);
				il.Emit(OpCodes.Bne_Un, endOfBlock2);
				LocalBuilder methodReturn2 = il.DeclareLocal(declaringType);
				il.Emit(OpCodes.Ldloca, methodReturn2);
				il.Emit(OpCodes.Initobj, declaringType);
				this.emitPush(il, declaringType, (short)methodReturn2.LocalIndex, false, L, translator, false);
				il.Emit(OpCodes.Ldc_I4_1);
				il.Emit(OpCodes.Stloc, wrapRet);
				il.Emit(OpCodes.Leave_S, retPoint);
				il.MarkLabel(endOfBlock2);
			}
			il.Emit(OpCodes.Leave, exceptionBlock);
			this.emitCatchBlock(il, ex, wrapRet, retPoint, exceptionBlock);
			bool flag22 = needCheckParameterType;
			if (flag22)
			{
				if (isIndexer)
				{
					il.Emit(OpCodes.Ldarg_0);
					il.Emit(OpCodes.Ldc_I4_0);
					il.Emit(OpCodes.Call, this.LuaAPI_lua_pushboolean);
					il.Emit(OpCodes.Ldc_I4_1);
					il.Emit(OpCodes.Ret);
				}
				else
				{
					il.Emit(OpCodes.Ldarg_0);
					bool flag23 = methodDesciption == null;
					if (flag23)
					{
						bool flag24 = methodsToCall.Count > 0;
						if (flag24)
						{
							methodDesciption = ((declaringType != null) ? declaringType.ToString() : null) + "." + methodsToCall[0].Name;
						}
						else
						{
							methodDesciption = "unknow method in " + ((declaringType != null) ? declaringType.ToString() : null);
						}
					}
					il.Emit(OpCodes.Ldstr, "invalid arguments to " + methodDesciption + "!");
					il.Emit(OpCodes.Call, this.LuaAPI_luaL_error);
					il.Emit(OpCodes.Ret);
				}
			}
			il.MarkLabel(retPoint);
			il.Emit(OpCodes.Ldloc, wrapRet);
			il.Emit(OpCodes.Ret);
			return methodBuilder;
		}

		// Token: 0x04000CB0 RID: 3248
		private ModuleBuilder codeEmitModule = null;

		// Token: 0x04000CB1 RID: 3249
		private ulong genID = 0UL;

		// Token: 0x04000CB2 RID: 3250
		private MethodInfo LuaEnv_ThrowExceptionFromError = typeof(LuaEnv).GetMethod("ThrowExceptionFromError");

		// Token: 0x04000CB3 RID: 3251
		private FieldInfo LuaBase_luaEnv = typeof(LuaBase).GetField("luaEnv", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000CB4 RID: 3252
		private MethodInfo DelegateBridgeBase_errorFuncRef_getter = typeof(LuaBase).GetProperty("_errorFuncRef", BindingFlags.Instance | BindingFlags.NonPublic).GetGetMethod(true);

		// Token: 0x04000CB5 RID: 3253
		private MethodInfo LuaAPI_load_error_func = typeof(Lua).GetMethod("load_error_func");

		// Token: 0x04000CB6 RID: 3254
		private MethodInfo LuaBase_translator_getter = typeof(LuaBase).GetProperty("_translator", BindingFlags.Instance | BindingFlags.NonPublic).GetGetMethod(true);

		// Token: 0x04000CB7 RID: 3255
		private FieldInfo LuaBase_luaReference = typeof(LuaBase).GetField("luaReference", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000CB8 RID: 3256
		private MethodInfo LuaAPI_lua_getref = typeof(Lua).GetMethod("lua_getref");

		// Token: 0x04000CB9 RID: 3257
		private MethodInfo Type_GetTypeFromHandle = typeof(Type).GetMethod("GetTypeFromHandle", new Type[]
		{
			typeof(RuntimeTypeHandle)
		});

		// Token: 0x04000CBA RID: 3258
		private MethodInfo ObjectTranslator_PushAny = typeof(ObjectTranslator).GetMethod("PushAny");

		// Token: 0x04000CBB RID: 3259
		private MethodInfo ObjectTranslator_PushParams = typeof(ObjectTranslator).GetMethod("PushParams");

		// Token: 0x04000CBC RID: 3260
		private MethodInfo LuaBase_L_getter = typeof(LuaBase).GetProperty("_L", BindingFlags.Instance | BindingFlags.NonPublic).GetGetMethod(true);

		// Token: 0x04000CBD RID: 3261
		private MethodInfo LuaAPI_lua_pcall = typeof(Lua).GetMethod("lua_pcall");

		// Token: 0x04000CBE RID: 3262
		private MethodInfo LuaAPI_lua_type = typeof(Lua).GetMethod("lua_type");

		// Token: 0x04000CBF RID: 3263
		private MethodInfo ObjectTranslator_GetObject = typeof(ObjectTranslator).GetMethod("GetObject", new Type[]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(Type)
		});

		// Token: 0x04000CC0 RID: 3264
		private MethodInfo ObjectTranslator_GetParams = typeof(ObjectTranslator).GetMethod("GetParams", new Type[]
		{
			typeof(IntPtr),
			typeof(int)
		});

		// Token: 0x04000CC1 RID: 3265
		private MethodInfo ObjectTranslator_Update = typeof(ObjectTranslator).GetMethod("Update");

		// Token: 0x04000CC2 RID: 3266
		private MethodInfo LuaAPI_lua_pushvalue = typeof(Lua).GetMethod("lua_pushvalue");

		// Token: 0x04000CC3 RID: 3267
		private MethodInfo LuaAPI_lua_remove = typeof(Lua).GetMethod("lua_remove");

		// Token: 0x04000CC4 RID: 3268
		private MethodInfo LuaAPI_lua_pushstring = typeof(Lua).GetMethod("lua_pushstring", new Type[]
		{
			typeof(IntPtr),
			typeof(string)
		});

		// Token: 0x04000CC5 RID: 3269
		private MethodInfo LuaAPI_lua_gettop = typeof(Lua).GetMethod("lua_gettop");

		// Token: 0x04000CC6 RID: 3270
		private MethodInfo LuaAPI_xlua_pgettable = typeof(Lua).GetMethod("xlua_pgettable");

		// Token: 0x04000CC7 RID: 3271
		private MethodInfo LuaAPI_xlua_psettable = typeof(Lua).GetMethod("xlua_psettable");

		// Token: 0x04000CC8 RID: 3272
		private MethodInfo LuaAPI_lua_pop = typeof(Lua).GetMethod("lua_pop");

		// Token: 0x04000CC9 RID: 3273
		private MethodInfo LuaAPI_lua_settop = typeof(Lua).GetMethod("lua_settop");

		// Token: 0x04000CCA RID: 3274
		private MethodInfo LuaAPI_luaL_error = typeof(Lua).GetMethod("luaL_error");

		// Token: 0x04000CCB RID: 3275
		private MethodInfo LuaAPI_xlua_is_eq_str = typeof(Lua).GetMethod("xlua_is_eq_str", new Type[]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(string)
		});

		// Token: 0x04000CCC RID: 3276
		private MethodInfo LuaAPI_xlua_pushinteger = typeof(Lua).GetMethod("xlua_pushinteger");

		// Token: 0x04000CCD RID: 3277
		private MethodInfo LuaAPI_lua_pushint64 = typeof(Lua).GetMethod("lua_pushint64");

		// Token: 0x04000CCE RID: 3278
		private MethodInfo LuaAPI_lua_pushnumber = typeof(Lua).GetMethod("lua_pushnumber");

		// Token: 0x04000CCF RID: 3279
		private MethodInfo LuaAPI_xlua_pushuint = typeof(Lua).GetMethod("xlua_pushuint");

		// Token: 0x04000CD0 RID: 3280
		private MethodInfo LuaAPI_lua_pushuint64 = typeof(Lua).GetMethod("lua_pushuint64");

		// Token: 0x04000CD1 RID: 3281
		private MethodInfo LuaAPI_lua_pushboolean = typeof(Lua).GetMethod("lua_pushboolean");

		// Token: 0x04000CD2 RID: 3282
		private MethodInfo LuaAPI_lua_pushbytes = typeof(Lua).GetMethod("lua_pushstring", new Type[]
		{
			typeof(IntPtr),
			typeof(byte[])
		});

		// Token: 0x04000CD3 RID: 3283
		private MethodInfo LuaAPI_lua_pushlightuserdata = typeof(Lua).GetMethod("lua_pushlightuserdata");

		// Token: 0x04000CD4 RID: 3284
		private MethodInfo ObjectTranslator_PushDecimal = typeof(ObjectTranslator).GetMethod("PushDecimal");

		// Token: 0x04000CD5 RID: 3285
		private MethodInfo ObjectTranslator_GetDecimal = typeof(ObjectTranslator).GetMethod("GetDecimal");

		// Token: 0x04000CD6 RID: 3286
		private Dictionary<Type, MethodInfo> fixPush;

		// Token: 0x04000CD7 RID: 3287
		private MethodInfo LuaAPI_xlua_tointeger = typeof(Lua).GetMethod("xlua_tointeger");

		// Token: 0x04000CD8 RID: 3288
		private MethodInfo LuaAPI_lua_tonumber = typeof(Lua).GetMethod("lua_tonumber");

		// Token: 0x04000CD9 RID: 3289
		private MethodInfo LuaAPI_lua_tostring = typeof(Lua).GetMethod("lua_tostring");

		// Token: 0x04000CDA RID: 3290
		private MethodInfo LuaAPI_lua_toboolean = typeof(Lua).GetMethod("lua_toboolean");

		// Token: 0x04000CDB RID: 3291
		private MethodInfo LuaAPI_lua_tobytes = typeof(Lua).GetMethod("lua_tobytes");

		// Token: 0x04000CDC RID: 3292
		private MethodInfo LuaAPI_lua_touserdata = typeof(Lua).GetMethod("lua_touserdata");

		// Token: 0x04000CDD RID: 3293
		private MethodInfo LuaAPI_xlua_touint = typeof(Lua).GetMethod("xlua_touint");

		// Token: 0x04000CDE RID: 3294
		private MethodInfo LuaAPI_lua_touint64 = typeof(Lua).GetMethod("lua_touint64");

		// Token: 0x04000CDF RID: 3295
		private MethodInfo LuaAPI_lua_toint64 = typeof(Lua).GetMethod("lua_toint64");

		// Token: 0x04000CE0 RID: 3296
		private Dictionary<Type, MethodInfo> typedCaster;

		// Token: 0x04000CE1 RID: 3297
		private Dictionary<Type, MethodInfo> fixCaster;

		// Token: 0x04000CE2 RID: 3298
		private HashSet<Type> gen_interfaces = new HashSet<Type>();

		// Token: 0x04000CE3 RID: 3299
		private ConstructorInfo decimalConstructor = typeof(decimal).GetConstructor(new Type[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		});

		// Token: 0x04000CE4 RID: 3300
		private MethodInfo ObjectTranslatorPool_FindTranslator = typeof(ObjectTranslatorPool).GetMethod("FindTranslator");

		// Token: 0x04000CE5 RID: 3301
		private Type[] parameterTypeOfWrap = new Type[]
		{
			typeof(IntPtr)
		};

		// Token: 0x04000CE6 RID: 3302
		private MethodInfo ObjectTranslator_Assignable = typeof(ObjectTranslator).GetMethod("Assignable", new Type[]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(Type)
		});

		// Token: 0x04000CE7 RID: 3303
		private MethodInfo Utils_BeginObjectRegister = typeof(Utils).GetMethod("BeginObjectRegister");

		// Token: 0x04000CE8 RID: 3304
		private MethodInfo Utils_EndObjectRegister = typeof(Utils).GetMethod("EndObjectRegister");

		// Token: 0x04000CE9 RID: 3305
		private MethodInfo Utils_BeginClassRegister = typeof(Utils).GetMethod("BeginClassRegister");

		// Token: 0x04000CEA RID: 3306
		private MethodInfo Utils_EndClassRegister = typeof(Utils).GetMethod("EndClassRegister");

		// Token: 0x04000CEB RID: 3307
		private MethodInfo Utils_RegisterFunc = typeof(Utils).GetMethod("RegisterFunc");

		// Token: 0x04000CEC RID: 3308
		private MethodInfo Utils_RegisterObject = typeof(Utils).GetMethod("RegisterObject");

		// Token: 0x04000CED RID: 3309
		private ConstructorInfo LuaCSFunction_Constructor = typeof(lua_CSFunction).GetConstructor(new Type[]
		{
			typeof(object),
			typeof(IntPtr)
		});

		// Token: 0x04000CEE RID: 3310
		private MethodInfo String_Concat = typeof(string).GetMethod("Concat", new Type[]
		{
			typeof(object),
			typeof(object)
		});

		// Token: 0x04000CEF RID: 3311
		private static HashSet<MemberInfo> BlackList = new HashSet<MemberInfo>();
	}
}

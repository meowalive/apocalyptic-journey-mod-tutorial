using System;
using System.Collections.Generic;
using System.Reflection;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000166 RID: 358
	public class MethodWrapsCache
	{
		// Token: 0x06000AFC RID: 2812 RVA: 0x00058014 File Offset: 0x00056214
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters)
		{
			this.translator = translator;
			this.objCheckers = objCheckers;
			this.objCasters = objCasters;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00058054 File Offset: 0x00056254
		public lua_CSFunction GetConstructorWrap(Type type)
		{
			bool flag = !this.constructorCache.ContainsKey(type);
			if (flag)
			{
				ConstructorInfo[] constructors = type.GetConstructors();
				bool flag2 = type.IsAbstract() || constructors == null || constructors.Length == 0;
				if (flag2)
				{
					bool flag3 = type.IsValueType();
					if (!flag3)
					{
						return null;
					}
					this.constructorCache[type] = delegate(IntPtr L)
					{
						this.translator.PushAny(L, Activator.CreateInstance(type));
						return 1;
					};
				}
				else
				{
					lua_CSFunction ctor = new lua_CSFunction(this._GenMethodWrap(type, ".ctor", constructors, true).Call);
					bool flag4 = type.IsValueType();
					if (flag4)
					{
						bool hasZeroParamsCtor = false;
						for (int i = 0; i < constructors.Length; i++)
						{
							bool flag5 = constructors[i].GetParameters().Length == 0;
							if (flag5)
							{
								hasZeroParamsCtor = true;
								break;
							}
						}
						bool flag6 = hasZeroParamsCtor;
						if (flag6)
						{
							this.constructorCache[type] = ctor;
						}
						else
						{
							this.constructorCache[type] = delegate(IntPtr L)
							{
								bool flag7 = Lua.lua_gettop(L) == 1;
								int result;
								if (flag7)
								{
									this.translator.PushAny(L, Activator.CreateInstance(type));
									result = 1;
								}
								else
								{
									result = ctor(L);
								}
								return result;
							};
						}
					}
					else
					{
						this.constructorCache[type] = ctor;
					}
				}
			}
			return this.constructorCache[type];
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00058218 File Offset: 0x00056418
		public lua_CSFunction GetMethodWrap(Type type, string methodName)
		{
			bool flag = !this.methodsCache.ContainsKey(type);
			if (flag)
			{
				this.methodsCache[type] = new Dictionary<string, lua_CSFunction>();
			}
			Dictionary<string, lua_CSFunction> methodsOfType = this.methodsCache[type];
			bool flag2 = !methodsOfType.ContainsKey(methodName);
			if (flag2)
			{
				MemberInfo[] methods = type.GetMember(methodName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
				bool flag3 = methods == null || methods.Length == 0 || methods[0].MemberType != MemberTypes.Method;
				if (flag3)
				{
					return null;
				}
				methodsOfType[methodName] = new lua_CSFunction(this._GenMethodWrap(type, methodName, methods, false).Call);
			}
			return methodsOfType[methodName];
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000582C4 File Offset: 0x000564C4
		public lua_CSFunction GetMethodWrapInCache(Type type, string methodName)
		{
			bool flag = !this.methodsCache.ContainsKey(type);
			if (flag)
			{
				this.methodsCache[type] = new Dictionary<string, lua_CSFunction>();
			}
			Dictionary<string, lua_CSFunction> methodsOfType = this.methodsCache[type];
			return methodsOfType.ContainsKey(methodName) ? methodsOfType[methodName] : null;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00058320 File Offset: 0x00056520
		public lua_CSFunction GetDelegateWrap(Type type)
		{
			bool flag = !typeof(Delegate).IsAssignableFrom(type);
			lua_CSFunction result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = !this.delegateCache.ContainsKey(type);
				if (flag2)
				{
					this.delegateCache[type] = new lua_CSFunction(this._GenMethodWrap(type, type.ToString(), new MethodBase[]
					{
						type.GetMethod("Invoke")
					}, false).Call);
				}
				result = this.delegateCache[type];
			}
			return result;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000583AC File Offset: 0x000565AC
		public lua_CSFunction GetEventWrap(Type type, string eventName)
		{
			bool flag = !this.methodsCache.ContainsKey(type);
			if (flag)
			{
				this.methodsCache[type] = new Dictionary<string, lua_CSFunction>();
			}
			Dictionary<string, lua_CSFunction> methodsOfType = this.methodsCache[type];
			bool flag2 = !methodsOfType.ContainsKey(eventName);
			if (flag2)
			{
				EventInfo eventInfo = type.GetEvent(eventName, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				bool flag3 = eventInfo == null;
				if (flag3)
				{
					throw new Exception(type.Name + " has no event named: " + eventName);
				}
				int start_idx = 0;
				MethodInfo add = eventInfo.GetAddMethod(true);
				MethodInfo remove = eventInfo.GetRemoveMethod(true);
				bool flag4 = add == null && remove == null;
				if (flag4)
				{
					throw new Exception(type.Name + "'s " + eventName + " has either add nor remove");
				}
				bool is_static = (add != null) ? add.IsStatic : remove.IsStatic;
				bool flag5 = !is_static;
				if (flag5)
				{
					start_idx = 1;
				}
				methodsOfType[eventName] = delegate(IntPtr L)
				{
					object obj = null;
					bool flag6 = !is_static;
					if (flag6)
					{
						obj = this.translator.GetObject(L, 1, type);
						bool flag7 = obj == null;
						if (flag7)
						{
							string str = "invalid #1, needed:";
							Type type2 = type;
							return Lua.luaL_error(L, str + ((type2 != null) ? type2.ToString() : null));
						}
					}
					try
					{
						object handlerDelegate = this.translator.CreateDelegateBridge(L, eventInfo.EventHandlerType, start_idx + 2);
						bool flag8 = handlerDelegate == null;
						if (flag8)
						{
							string str2 = "invalid #";
							string str3 = (start_idx + 2).ToString();
							string str4 = ", needed:";
							Type eventHandlerType = eventInfo.EventHandlerType;
							return Lua.luaL_error(L, str2 + str3 + str4 + ((eventHandlerType != null) ? eventHandlerType.ToString() : null));
						}
						string text = Lua.lua_tostring(L, start_idx + 1);
						string a = text;
						if (!(a == "+"))
						{
							if (!(a == "-"))
							{
								string str5 = "invalid #";
								string str6 = (start_idx + 1).ToString();
								string str7 = ", needed: '+' or '-'";
								Type eventHandlerType2 = eventInfo.EventHandlerType;
								return Lua.luaL_error(L, str5 + str6 + str7 + ((eventHandlerType2 != null) ? eventHandlerType2.ToString() : null));
							}
							bool flag9 = remove == null;
							if (flag9)
							{
								return Lua.luaL_error(L, "no remove for event " + eventName);
							}
							remove.Invoke(obj, new object[]
							{
								handlerDelegate
							});
						}
						else
						{
							bool flag10 = add == null;
							if (flag10)
							{
								return Lua.luaL_error(L, "no add for event " + eventName);
							}
							add.Invoke(obj, new object[]
							{
								handlerDelegate
							});
						}
					}
					catch (Exception e)
					{
						string str8 = "c# exception:";
						Exception ex = e;
						return Lua.luaL_error(L, str8 + ((ex != null) ? ex.ToString() : null) + ",stack:" + e.StackTrace);
					}
					return 0;
				};
			}
			return methodsOfType[eventName];
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000585AC File Offset: 0x000567AC
		public MethodWrap _GenMethodWrap(Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false)
		{
			List<OverloadMethodWrap> overloads = new List<OverloadMethodWrap>();
			foreach (MemberInfo methodBase in methodBases)
			{
				MethodBase mb = methodBase as MethodBase;
				bool flag = mb == null;
				if (!flag)
				{
					bool flag2 = mb.IsGenericMethodDefinition && !MethodWrapsCache.tryMakeGenericMethod(ref mb);
					if (!flag2)
					{
						OverloadMethodWrap overload = new OverloadMethodWrap(this.translator, type, mb);
						overload.Init(this.objCheckers, this.objCasters);
						overloads.Add(overload);
					}
				}
			}
			return new MethodWrap(methodName, overloads, forceCheck);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00058668 File Offset: 0x00056868
		private static bool tryMakeGenericMethod(ref MethodBase method)
		{
			bool result;
			try
			{
				bool flag = !(method is MethodInfo) || !Utils.IsSupportedMethod(method as MethodInfo);
				if (flag)
				{
					result = false;
				}
				else
				{
					Type[] genericArguments = method.GetGenericArguments();
					Type[] constraintedArgumentTypes = new Type[genericArguments.Length];
					for (int i = 0; i < genericArguments.Length; i++)
					{
						Type argumentType = genericArguments[i];
						Type[] parameterConstraints = argumentType.GetGenericParameterConstraints();
						constraintedArgumentTypes[i] = parameterConstraints[0];
					}
					method = ((MethodInfo)method).MakeGenericMethod(constraintedArgumentTypes);
					result = true;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000D55 RID: 3413
		private ObjectTranslator translator;

		// Token: 0x04000D56 RID: 3414
		private ObjectCheckers objCheckers;

		// Token: 0x04000D57 RID: 3415
		private ObjectCasters objCasters;

		// Token: 0x04000D58 RID: 3416
		private Dictionary<Type, lua_CSFunction> constructorCache = new Dictionary<Type, lua_CSFunction>();

		// Token: 0x04000D59 RID: 3417
		private Dictionary<Type, Dictionary<string, lua_CSFunction>> methodsCache = new Dictionary<Type, Dictionary<string, lua_CSFunction>>();

		// Token: 0x04000D5A RID: 3418
		private Dictionary<Type, lua_CSFunction> delegateCache = new Dictionary<Type, lua_CSFunction>();
	}
}

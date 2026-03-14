using System;
using Tutorial;
using UnityEngine.Events;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200012F RID: 303
	public class DelegateBridge : DelegateBridgeBase
	{
		// Token: 0x06000928 RID: 2344 RVA: 0x00047A7C File Offset: 0x00045C7C
		public void __Gen_Delegate_Imp0(ActionData p0)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			ObjectTranslator translator = this.luaEnv.translator;
			translator.Push(L, p0);
			this.PCall(L, 1, 0, errFunc);
			Lua.lua_settop(L, errFunc - 1);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00047AD8 File Offset: 0x00045CD8
		public void __Gen_Delegate_Imp1(HurtData p0)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			ObjectTranslator translator = this.luaEnv.translator;
			translator.Push(L, p0);
			this.PCall(L, 1, 0, errFunc);
			Lua.lua_settop(L, errFunc - 1);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00047B34 File Offset: 0x00045D34
		public void __Gen_Delegate_Imp2(DamageData p0)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			ObjectTranslator translator = this.luaEnv.translator;
			translator.Push(L, p0);
			this.PCall(L, 1, 0, errFunc);
			Lua.lua_settop(L, errFunc - 1);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00047B90 File Offset: 0x00045D90
		public void __Gen_Delegate_Imp3(NewEnemyData p0)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			ObjectTranslator translator = this.luaEnv.translator;
			translator.Push(L, p0);
			this.PCall(L, 1, 0, errFunc);
			Lua.lua_settop(L, errFunc - 1);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00047BEC File Offset: 0x00045DEC
		public void __Gen_Delegate_Imp4(ScriptExecuteData p0)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			ObjectTranslator translator = this.luaEnv.translator;
			translator.Push(L, p0);
			this.PCall(L, 1, 0, errFunc);
			Lua.lua_settop(L, errFunc - 1);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00047C48 File Offset: 0x00045E48
		public void __Gen_Delegate_Imp5()
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			this.PCall(L, 0, 0, errFunc);
			Lua.lua_settop(L, errFunc - 1);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00047C8C File Offset: 0x00045E8C
		public double __Gen_Delegate_Imp6(double p0, double p1)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			Lua.lua_pushnumber(L, p0);
			Lua.lua_pushnumber(L, p1);
			this.PCall(L, 2, 1, errFunc);
			double __gen_ret = Lua.lua_tonumber(L, errFunc + 1);
			Lua.lua_settop(L, errFunc - 1);
			return __gen_ret;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00047CF0 File Offset: 0x00045EF0
		public void __Gen_Delegate_Imp7(string p0)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			Lua.lua_pushstring(L, p0);
			this.PCall(L, 1, 0, errFunc);
			Lua.lua_settop(L, errFunc - 1);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00047D3C File Offset: 0x00045F3C
		public void __Gen_Delegate_Imp8(double p0)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			Lua.lua_pushnumber(L, p0);
			this.PCall(L, 1, 0, errFunc);
			Lua.lua_settop(L, errFunc - 1);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00047D88 File Offset: 0x00045F88
		public int __Gen_Delegate_Imp9(int p0, string p1, out CSCallLua.DClass p2)
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			ObjectTranslator translator = this.luaEnv.translator;
			Lua.xlua_pushinteger(L, p0);
			Lua.lua_pushstring(L, p1);
			this.PCall(L, 2, 2, errFunc);
			p2 = (CSCallLua.DClass)translator.GetObject(L, errFunc + 2, typeof(CSCallLua.DClass));
			int __gen_ret = Lua.xlua_tointeger(L, errFunc + 1);
			Lua.lua_settop(L, errFunc - 1);
			return __gen_ret;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00047E14 File Offset: 0x00046014
		public Action __Gen_Delegate_Imp10()
		{
			IntPtr L = this.luaEnv.rawL;
			int errFunc = Lua.pcall_prepare(L, this.errorFuncRef, this.luaReference);
			ObjectTranslator translator = this.luaEnv.translator;
			this.PCall(L, 0, 1, errFunc);
			Action __gen_ret = translator.GetDelegate<Action>(L, errFunc + 1);
			Lua.lua_settop(L, errFunc - 1);
			return __gen_ret;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00047E74 File Offset: 0x00046074
		static DelegateBridge()
		{
			DelegateBridge.Gen_Flag = true;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00047E90 File Offset: 0x00046090
		public override Delegate GetDelegateByType(Type type)
		{
			bool flag = type == typeof(Action<ActionData>);
			Delegate result;
			if (flag)
			{
				result = new Action<ActionData>(this.__Gen_Delegate_Imp0);
			}
			else
			{
				bool flag2 = type == typeof(Action<HurtData>);
				if (flag2)
				{
					result = new Action<HurtData>(this.__Gen_Delegate_Imp1);
				}
				else
				{
					bool flag3 = type == typeof(Action<DamageData>);
					if (flag3)
					{
						result = new Action<DamageData>(this.__Gen_Delegate_Imp2);
					}
					else
					{
						bool flag4 = type == typeof(Action<NewEnemyData>);
						if (flag4)
						{
							result = new Action<NewEnemyData>(this.__Gen_Delegate_Imp3);
						}
						else
						{
							bool flag5 = type == typeof(Action<ScriptExecuteData>);
							if (flag5)
							{
								result = new Action<ScriptExecuteData>(this.__Gen_Delegate_Imp4);
							}
							else
							{
								bool flag6 = type == typeof(Action);
								if (flag6)
								{
									result = new Action(this.__Gen_Delegate_Imp5);
								}
								else
								{
									bool flag7 = type == typeof(UnityAction);
									if (flag7)
									{
										result = new UnityAction(this.__Gen_Delegate_Imp5);
									}
									else
									{
										bool flag8 = type == typeof(Func<double, double, double>);
										if (flag8)
										{
											result = new Func<double, double, double>(this.__Gen_Delegate_Imp6);
										}
										else
										{
											bool flag9 = type == typeof(Action<string>);
											if (flag9)
											{
												result = new Action<string>(this.__Gen_Delegate_Imp7);
											}
											else
											{
												bool flag10 = type == typeof(Action<double>);
												if (flag10)
												{
													result = new Action<double>(this.__Gen_Delegate_Imp8);
												}
												else
												{
													bool flag11 = type == typeof(CSCallLua.FDelegate);
													if (flag11)
													{
														result = new CSCallLua.FDelegate(this.__Gen_Delegate_Imp9);
													}
													else
													{
														bool flag12 = type == typeof(CSCallLua.GetE);
														if (flag12)
														{
															result = new CSCallLua.GetE(this.__Gen_Delegate_Imp10);
														}
														else
														{
															result = null;
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
			return result;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0004807D File Offset: 0x0004627D
		public DelegateBridge(int reference, LuaEnv luaenv) : base(reference, luaenv)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0004808C File Offset: 0x0004628C
		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc)
		{
			bool flag = Lua.lua_pcall(L, nArgs, nResults, errFunc) != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(errFunc - 1);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000480BC File Offset: 0x000462BC
		public void Action()
		{
			IntPtr L = this.luaEnv.L;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			int error = Lua.lua_pcall(L, 0, 0, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00048128 File Offset: 0x00046328
		public void Action<T1>(T1 p1)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, p1);
			int error = Lua.lua_pcall(L, 1, 0, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000481A8 File Offset: 0x000463A8
		public void Action<T1, T2>(T1 p1, T2 p2)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, p1);
			translator.PushByType<T2>(L, p2);
			int error = Lua.lua_pcall(L, 2, 0, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00048234 File Offset: 0x00046434
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, p1);
			translator.PushByType<T2>(L, p2);
			translator.PushByType<T3>(L, p3);
			int error = Lua.lua_pcall(L, 3, 0, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000482C8 File Offset: 0x000464C8
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, p1);
			translator.PushByType<T2>(L, p2);
			translator.PushByType<T3>(L, p3);
			translator.PushByType<T4>(L, p4);
			int error = Lua.lua_pcall(L, 4, 0, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00048364 File Offset: 0x00046564
		public TResult Func<TResult>()
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			int error = Lua.lua_pcall(L, 0, 1, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			TResult ret;
			try
			{
				translator.Get<TResult>(L, -1, out ret);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
			return ret;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0004841C File Offset: 0x0004661C
		public TResult Func<T1, TResult>(T1 p1)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, p1);
			int error = Lua.lua_pcall(L, 1, 1, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			TResult ret;
			try
			{
				translator.Get<TResult>(L, -1, out ret);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
			return ret;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000484DC File Offset: 0x000466DC
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, p1);
			translator.PushByType<T2>(L, p2);
			int error = Lua.lua_pcall(L, 2, 1, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			TResult ret;
			try
			{
				translator.Get<TResult>(L, -1, out ret);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
			return ret;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000485A4 File Offset: 0x000467A4
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, p1);
			translator.PushByType<T2>(L, p2);
			translator.PushByType<T3>(L, p3);
			int error = Lua.lua_pcall(L, 3, 1, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			TResult ret;
			try
			{
				translator.Get<TResult>(L, -1, out ret);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
			return ret;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00048678 File Offset: 0x00046878
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, p1);
			translator.PushByType<T2>(L, p2);
			translator.PushByType<T3>(L, p3);
			translator.PushByType<T4>(L, p4);
			int error = Lua.lua_pcall(L, 4, 1, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			TResult ret;
			try
			{
				translator.Get<TResult>(L, -1, out ret);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
			return ret;
		}

		// Token: 0x04000C3D RID: 3133
		internal static DelegateBridge[] DelegateBridgeList = new DelegateBridge[0];

		// Token: 0x04000C3E RID: 3134
		public static bool Gen_Flag = false;
	}
}

using System;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000160 RID: 352
	public class LuaFunction : LuaBase
	{
		// Token: 0x06000AC2 RID: 2754 RVA: 0x0005673B File Offset: 0x0005493B
		public LuaFunction(int reference, LuaEnv luaenv) : base(reference, luaenv)
		{
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00056748 File Offset: 0x00054948
		public void Action<T>(T a)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T>(L, a);
			int error = Lua.lua_pcall(L, 1, 0, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x000567C8 File Offset: 0x000549C8
		public TResult Func<T, TResult>(T a)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T>(L, a);
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

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00056888 File Offset: 0x00054A88
		public void Action<T1, T2>(T1 a1, T2 a2)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, a1);
			translator.PushByType<T2>(L, a2);
			int error = Lua.lua_pcall(L, 2, 0, errFunc);
			bool flag = error != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00056914 File Offset: 0x00054B14
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<T1>(L, a1);
			translator.PushByType<T2>(L, a2);
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

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000569DC File Offset: 0x00054BDC
		public object[] Call(object[] args, Type[] returnTypes)
		{
			int nArgs = 0;
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			int errFunc = Lua.load_error_func(L, this.luaEnv.errorFuncRef);
			Lua.lua_getref(L, this.luaReference);
			bool flag = args != null;
			if (flag)
			{
				nArgs = args.Length;
				for (int i = 0; i < args.Length; i++)
				{
					translator.PushAny(L, args[i]);
				}
			}
			int error = Lua.lua_pcall(L, nArgs, -1, errFunc);
			bool flag2 = error != 0;
			if (flag2)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_remove(L, errFunc);
			bool flag3 = returnTypes != null;
			object[] result;
			if (flag3)
			{
				result = translator.popValues(L, oldTop, returnTypes);
			}
			else
			{
				result = translator.popValues(L, oldTop);
			}
			return result;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00056AB4 File Offset: 0x00054CB4
		public object[] Call(params object[] args)
		{
			return this.Call(args, null);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00056AD0 File Offset: 0x00054CD0
		public T Cast<T>()
		{
			bool flag = !typeof(T).IsSubclassOf(typeof(Delegate));
			if (flag)
			{
				throw new InvalidOperationException(typeof(T).Name + " is not a delegate type");
			}
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			this.push(L);
			T ret = (T)((object)translator.GetObject(L, -1, typeof(T)));
			Lua.lua_pop(this.luaEnv.L, 1);
			return ret;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00056B70 File Offset: 0x00054D70
		public void SetEnv(LuaTable env)
		{
			IntPtr L = this.luaEnv.L;
			int oldTop = Lua.lua_gettop(L);
			this.push(L);
			env.push(L);
			Lua.lua_setfenv(L, -2);
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00055B24 File Offset: 0x00053D24
		internal override void push(IntPtr L)
		{
			Lua.lua_getref(L, this.luaReference);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00056BB4 File Offset: 0x00054DB4
		public override string ToString()
		{
			return "function :" + this.luaReference.ToString();
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000161 RID: 353
	public class LuaTable : LuaBase
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x0005673B File Offset: 0x0005493B
		public LuaTable(int reference, LuaEnv luaenv) : base(reference, luaenv)
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00056BE0 File Offset: 0x00054DE0
		public void Get<TKey, TValue>(TKey key, out TValue value)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<TKey>(L, key);
			bool flag = Lua.xlua_pgettable(L, -2) != 0;
			if (flag)
			{
				string err = Lua.lua_tostring(L, -1);
				Lua.lua_settop(L, oldTop);
				string str = "get field [";
				TKey tkey = key;
				throw new Exception(str + ((tkey != null) ? tkey.ToString() : null) + "] error:" + err);
			}
			LuaTypes lua_type = Lua.lua_type(L, -1);
			Type type_of_value = typeof(TValue);
			bool flag2 = lua_type == LuaTypes.LUA_TNIL && type_of_value.IsValueType();
			if (flag2)
			{
				throw new InvalidCastException("can not assign nil to " + type_of_value.GetFriendlyName());
			}
			try
			{
				translator.Get<TValue>(L, -1, out value);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00056CF8 File Offset: 0x00054EF8
		public bool ContainsKey<TKey>(TKey key)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<TKey>(L, key);
			bool flag = Lua.xlua_pgettable(L, -2) != 0;
			if (flag)
			{
				string err = Lua.lua_tostring(L, -1);
				Lua.lua_settop(L, oldTop);
				string str = "get field [";
				TKey tkey = key;
				throw new Exception(str + ((tkey != null) ? tkey.ToString() : null) + "] error:" + err);
			}
			bool ret = Lua.lua_type(L, -1) > LuaTypes.LUA_TNIL;
			Lua.lua_settop(L, oldTop);
			return ret;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00056DAC File Offset: 0x00054FAC
		public void Set<TKey, TValue>(TKey key, TValue value)
		{
			IntPtr L = this.luaEnv.L;
			int oldTop = Lua.lua_gettop(L);
			ObjectTranslator translator = this.luaEnv.translator;
			Lua.lua_getref(L, this.luaReference);
			translator.PushByType<TKey>(L, key);
			translator.PushByType<TValue>(L, value);
			bool flag = Lua.xlua_psettable(L, -3) != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00056E20 File Offset: 0x00055020
		public T GetInPath<T>(string path)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			Lua.lua_getref(L, this.luaReference);
			bool flag = Lua.xlua_pgettable_bypath(L, -1, path) != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			bool flag2 = Lua.lua_type(L, -1) == LuaTypes.LUA_TNIL && typeof(T).IsValueType();
			if (flag2)
			{
				throw new InvalidCastException("can not assign nil to " + typeof(T).GetFriendlyName());
			}
			T value;
			try
			{
				translator.Get<T>(L, -1, out value);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
			return value;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00056F04 File Offset: 0x00055104
		public void SetInPath<T>(string path, T val)
		{
			IntPtr L = this.luaEnv.L;
			int oldTop = Lua.lua_gettop(L);
			Lua.lua_getref(L, this.luaReference);
			this.luaEnv.translator.PushByType<T>(L, val);
			bool flag = Lua.xlua_psettable_bypath(L, -2, path) != 0;
			if (flag)
			{
				this.luaEnv.ThrowExceptionFromError(oldTop);
			}
			Lua.lua_settop(L, oldTop);
		}

		// Token: 0x17000100 RID: 256
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[string field]
		{
			get
			{
				return this.GetInPath<object>(field);
			}
			set
			{
				this.SetInPath<object>(field, value);
			}
		}

		// Token: 0x17000101 RID: 257
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[object field]
		{
			get
			{
				return this.Get<object>(field);
			}
			set
			{
				this.Set<object, object>(field, value);
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00056FBC File Offset: 0x000551BC
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action)
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			try
			{
				Lua.lua_getref(L, this.luaReference);
				Lua.lua_pushnil(L);
				while (Lua.lua_next(L, -2) != 0)
				{
					bool flag = translator.Assignable<TKey>(L, -2);
					if (flag)
					{
						TKey key;
						translator.Get<TKey>(L, -2, out key);
						TValue val;
						translator.Get<TValue>(L, -1, out val);
						action(key, val);
					}
					Lua.lua_pop(L, 1);
				}
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0005706C File Offset: 0x0005526C
		public int Length
		{
			get
			{
				IntPtr L = this.luaEnv.L;
				int oldTop = Lua.lua_gettop(L);
				Lua.lua_getref(L, this.luaReference);
				int len = (int)Lua.xlua_objlen(L, -1);
				Lua.lua_settop(L, oldTop);
				return len;
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000570AF File Offset: 0x000552AF
		public IEnumerable GetKeys()
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			try
			{
				Lua.lua_getref(L, this.luaReference);
				Lua.lua_pushnil(L);
				while (Lua.lua_next(L, -2) != 0)
				{
					yield return translator.GetObject(L, -2);
					Lua.lua_pop(L, 1);
				}
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
			yield break;
			yield break;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000570BF File Offset: 0x000552BF
		public IEnumerable<T> GetKeys<T>()
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			int oldTop = Lua.lua_gettop(L);
			try
			{
				Lua.lua_getref(L, this.luaReference);
				Lua.lua_pushnil(L);
				while (Lua.lua_next(L, -2) != 0)
				{
					bool flag = translator.Assignable<T>(L, -2);
					if (flag)
					{
						T v;
						translator.Get<T>(L, -2, out v);
						yield return v;
						v = default(T);
					}
					Lua.lua_pop(L, 1);
				}
			}
			finally
			{
				Lua.lua_settop(L, oldTop);
			}
			yield break;
			yield break;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000570D0 File Offset: 0x000552D0
		[Obsolete("use no boxing version: Get<TKey, TValue> !")]
		public T Get<T>(object key)
		{
			T ret;
			this.Get<object, T>(key, out ret);
			return ret;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000570F0 File Offset: 0x000552F0
		public TValue Get<TKey, TValue>(TKey key)
		{
			TValue ret;
			this.Get<TKey, TValue>(key, out ret);
			return ret;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00057110 File Offset: 0x00055310
		public TValue Get<TValue>(string key)
		{
			TValue ret;
			this.Get<string, TValue>(key, out ret);
			return ret;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00057130 File Offset: 0x00055330
		public void SetMetaTable(LuaTable metaTable)
		{
			this.push(this.luaEnv.L);
			metaTable.push(this.luaEnv.L);
			Lua.lua_setmetatable(this.luaEnv.L, -2);
			Lua.lua_pop(this.luaEnv.L, 1);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00057188 File Offset: 0x00055388
		public T Cast<T>()
		{
			IntPtr L = this.luaEnv.L;
			ObjectTranslator translator = this.luaEnv.translator;
			this.push(L);
			T ret = (T)((object)translator.GetObject(L, -1, typeof(T)));
			Lua.lua_pop(this.luaEnv.L, 1);
			return ret;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00055B24 File Offset: 0x00053D24
		internal override void push(IntPtr L)
		{
			Lua.lua_getref(L, this.luaReference);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000571E8 File Offset: 0x000553E8
		public override string ToString()
		{
			return "table :" + this.luaReference.ToString();
		}
	}
}

using System;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200015B RID: 347
	public abstract class LuaBase : IDisposable
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000558D8 File Offset: 0x00053AD8
		protected int _errorFuncRef
		{
			get
			{
				return this.luaEnv.errorFuncRef;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x000558F8 File Offset: 0x00053AF8
		protected IntPtr _L
		{
			get
			{
				return this.luaEnv.L;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00055918 File Offset: 0x00053B18
		protected ObjectTranslator _translator
		{
			get
			{
				return this.luaEnv.translator;
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00055935 File Offset: 0x00053B35
		public LuaBase(int reference, LuaEnv luaenv)
		{
			this.luaReference = reference;
			this.luaEnv = luaenv;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00055950 File Offset: 0x00053B50
		~LuaBase()
		{
			this.Dispose(false);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00055984 File Offset: 0x00053B84
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00055998 File Offset: 0x00053B98
		public virtual void Dispose(bool disposeManagedResources)
		{
			bool flag = !this.disposed;
			if (flag)
			{
				bool flag2 = this.luaReference != 0;
				if (flag2)
				{
					bool is_delegate = this is DelegateBridgeBase;
					if (disposeManagedResources)
					{
						this.luaEnv.translator.ReleaseLuaBase(this.luaEnv.L, this.luaReference, is_delegate);
					}
					else
					{
						this.luaEnv.equeueGCAction(new LuaEnv.GCAction
						{
							Reference = this.luaReference,
							IsDelegate = is_delegate
						});
					}
				}
				this.disposed = true;
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00055A30 File Offset: 0x00053C30
		public override bool Equals(object o)
		{
			bool flag = o != null && base.GetType() == o.GetType();
			bool result;
			if (flag)
			{
				LuaBase rhs = (LuaBase)o;
				IntPtr L = this.luaEnv.L;
				bool flag2 = L != rhs.luaEnv.L;
				if (flag2)
				{
					result = false;
				}
				else
				{
					int top = Lua.lua_gettop(L);
					Lua.lua_getref(L, rhs.luaReference);
					Lua.lua_getref(L, this.luaReference);
					int equal = Lua.lua_rawequal(L, -1, -2);
					Lua.lua_settop(L, top);
					result = (equal != 0);
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00055AD0 File Offset: 0x00053CD0
		public override int GetHashCode()
		{
			Lua.lua_getref(this.luaEnv.L, this.luaReference);
			IntPtr pointer = Lua.lua_topointer(this.luaEnv.L, -1);
			Lua.lua_pop(this.luaEnv.L, 1);
			return pointer.ToInt32();
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00055B24 File Offset: 0x00053D24
		internal virtual void push(IntPtr L)
		{
			Lua.lua_getref(L, this.luaReference);
		}

		// Token: 0x04000D1E RID: 3358
		protected bool disposed;

		// Token: 0x04000D1F RID: 3359
		protected readonly int luaReference;

		// Token: 0x04000D20 RID: 3360
		protected readonly LuaEnv luaEnv;
	}
}

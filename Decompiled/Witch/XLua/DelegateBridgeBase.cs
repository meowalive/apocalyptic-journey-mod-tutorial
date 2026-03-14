using System;
using System.Collections.Generic;

namespace XLua
{
	// Token: 0x0200014C RID: 332
	public abstract class DelegateBridgeBase : LuaBase
	{
		// Token: 0x06000A80 RID: 2688 RVA: 0x00055507 File Offset: 0x00053707
		public DelegateBridgeBase(int reference, LuaEnv luaenv) : base(reference, luaenv)
		{
			this.errorFuncRef = luaenv.errorFuncRef;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00055534 File Offset: 0x00053734
		public bool TryGetDelegate(Type key, out Delegate value)
		{
			bool flag = key == this.firstKey;
			bool result;
			if (flag)
			{
				value = this.firstValue;
				result = true;
			}
			else
			{
				bool flag2 = this.bindTo != null;
				if (flag2)
				{
					result = this.bindTo.TryGetValue(key, out value);
				}
				else
				{
					value = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00055588 File Offset: 0x00053788
		public void AddDelegate(Type key, Delegate value)
		{
			bool flag = key == this.firstKey;
			if (flag)
			{
				throw new ArgumentException("An element with the same key already exists in the dictionary.");
			}
			bool flag2 = this.firstKey == null && this.bindTo == null;
			if (flag2)
			{
				this.firstKey = key;
				this.firstValue = value;
			}
			else
			{
				bool flag3 = this.firstKey != null && this.bindTo == null;
				if (flag3)
				{
					this.bindTo = new Dictionary<Type, Delegate>();
					this.bindTo.Add(this.firstKey, this.firstValue);
					this.firstKey = null;
					this.firstValue = null;
					this.bindTo.Add(key, value);
				}
				else
				{
					this.bindTo.Add(key, value);
				}
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00055654 File Offset: 0x00053854
		public virtual Delegate GetDelegateByType(Type type)
		{
			return null;
		}

		// Token: 0x04000D06 RID: 3334
		private Type firstKey = null;

		// Token: 0x04000D07 RID: 3335
		private Delegate firstValue = null;

		// Token: 0x04000D08 RID: 3336
		private Dictionary<Type, Delegate> bindTo = null;

		// Token: 0x04000D09 RID: 3337
		protected int errorFuncRef;
	}
}

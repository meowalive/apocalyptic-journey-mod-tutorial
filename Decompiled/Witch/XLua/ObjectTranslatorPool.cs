using System;
using System.Collections.Generic;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200017D RID: 381
	public class ObjectTranslatorPool
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0005A944 File Offset: 0x00058B44
		public static ObjectTranslatorPool Instance
		{
			get
			{
				return InternalGlobals.objectTranslatorPool;
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0005A960 File Offset: 0x00058B60
		public static ObjectTranslator FindTranslator(IntPtr L)
		{
			return InternalGlobals.objectTranslatorPool.Find(L);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0005A9A8 File Offset: 0x00058BA8
		public void Add(IntPtr L, ObjectTranslator translator)
		{
			this.lastTranslator = translator;
			IntPtr ptr = Lua.xlua_gl(L);
			this.lastPtr = ptr;
			this.translators.Add(ptr, new WeakReference(translator));
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0005A9E0 File Offset: 0x00058BE0
		public ObjectTranslator Find(IntPtr L)
		{
			IntPtr ptr = Lua.xlua_gl(L);
			bool flag = this.lastPtr == ptr;
			ObjectTranslator result;
			if (flag)
			{
				result = this.lastTranslator;
			}
			else
			{
				bool flag2 = this.translators.ContainsKey(ptr);
				if (flag2)
				{
					this.lastPtr = ptr;
					this.lastTranslator = (this.translators[ptr].Target as ObjectTranslator);
					result = this.lastTranslator;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0005AA54 File Offset: 0x00058C54
		public void Remove(IntPtr L)
		{
			IntPtr ptr = Lua.xlua_gl(L);
			bool flag = !this.translators.ContainsKey(ptr);
			if (!flag)
			{
				bool flag2 = this.lastPtr == ptr;
				if (flag2)
				{
					this.lastPtr = 0;
					this.lastTranslator = null;
				}
				this.translators.Remove(ptr);
			}
		}

		// Token: 0x04000DA0 RID: 3488
		private Dictionary<IntPtr, WeakReference> translators = new Dictionary<IntPtr, WeakReference>();

		// Token: 0x04000DA1 RID: 3489
		private IntPtr lastPtr = 0;

		// Token: 0x04000DA2 RID: 3490
		private ObjectTranslator lastTranslator = null;
	}
}

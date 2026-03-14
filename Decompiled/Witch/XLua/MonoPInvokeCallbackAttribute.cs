using System;

namespace XLua
{
	// Token: 0x02000178 RID: 376
	public class MonoPInvokeCallbackAttribute : Attribute
	{
		// Token: 0x06000B61 RID: 2913 RVA: 0x0005A90C File Offset: 0x00058B0C
		public MonoPInvokeCallbackAttribute(Type t)
		{
			this.type = t;
		}

		// Token: 0x04000D83 RID: 3459
		private Type type;
	}
}

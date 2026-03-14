using System;

namespace XLua
{
	// Token: 0x0200014F RID: 335
	public class LuaCallCSharpAttribute : Attribute
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0005570C File Offset: 0x0005390C
		public GenFlag Flag
		{
			get
			{
				return this.flag;
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00055724 File Offset: 0x00053924
		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No)
		{
			this.flag = flag;
		}

		// Token: 0x04000D0D RID: 3341
		private GenFlag flag;
	}
}

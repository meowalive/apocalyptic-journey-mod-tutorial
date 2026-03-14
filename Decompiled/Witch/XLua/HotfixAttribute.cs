using System;

namespace XLua
{
	// Token: 0x02000158 RID: 344
	public class HotfixAttribute : Attribute
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00055764 File Offset: 0x00053964
		public HotfixFlag Flag
		{
			get
			{
				return this.flag;
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0005577C File Offset: 0x0005397C
		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless)
		{
			this.flag = e;
		}

		// Token: 0x04000D1D RID: 3357
		private HotfixFlag flag;
	}
}

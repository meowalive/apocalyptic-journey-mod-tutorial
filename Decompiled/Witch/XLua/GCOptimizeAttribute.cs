using System;

namespace XLua
{
	// Token: 0x02000153 RID: 339
	public class GCOptimizeAttribute : Attribute
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00055738 File Offset: 0x00053938
		public OptimizeFlag Flag
		{
			get
			{
				return this.flag;
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00055750 File Offset: 0x00053950
		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default)
		{
			this.flag = flag;
		}

		// Token: 0x04000D11 RID: 3345
		private OptimizeFlag flag;
	}
}

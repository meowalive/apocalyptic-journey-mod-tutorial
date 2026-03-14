using System;

namespace XLua.Cast
{
	// Token: 0x02000195 RID: 405
	public class Any<T> : RawObject
	{
		// Token: 0x06000BE0 RID: 3040 RVA: 0x0005E773 File Offset: 0x0005C973
		public Any(T i)
		{
			this.mTarget = i;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0005E784 File Offset: 0x0005C984
		public object Target
		{
			get
			{
				return this.mTarget;
			}
		}

		// Token: 0x04000DED RID: 3565
		private T mTarget;
	}
}

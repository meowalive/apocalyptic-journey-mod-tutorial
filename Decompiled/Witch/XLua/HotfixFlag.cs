using System;

namespace XLua
{
	// Token: 0x02000157 RID: 343
	[Flags]
	public enum HotfixFlag
	{
		// Token: 0x04000D13 RID: 3347
		Stateless = 0,
		// Token: 0x04000D14 RID: 3348
		[Obsolete("use xlua.util.state instead!", true)]
		Stateful = 1,
		// Token: 0x04000D15 RID: 3349
		ValueTypeBoxing = 2,
		// Token: 0x04000D16 RID: 3350
		IgnoreProperty = 4,
		// Token: 0x04000D17 RID: 3351
		IgnoreNotPublic = 8,
		// Token: 0x04000D18 RID: 3352
		Inline = 16,
		// Token: 0x04000D19 RID: 3353
		IntKey = 32,
		// Token: 0x04000D1A RID: 3354
		AdaptByDelegate = 64,
		// Token: 0x04000D1B RID: 3355
		IgnoreCompilerGenerated = 128,
		// Token: 0x04000D1C RID: 3356
		NoBaseProxy = 256
	}
}

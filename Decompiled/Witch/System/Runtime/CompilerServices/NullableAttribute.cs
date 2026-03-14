using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000005 RID: 5
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000022FF File Offset: 0x000004FF
		public NullableAttribute(byte A_1)
		{
			this.NullableFlags = new byte[]
			{
				A_1
			};
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002318 File Offset: 0x00000518
		public NullableAttribute(byte[] A_1)
		{
			this.NullableFlags = A_1;
		}

		// Token: 0x04000006 RID: 6
		public readonly byte[] NullableFlags;
	}
}

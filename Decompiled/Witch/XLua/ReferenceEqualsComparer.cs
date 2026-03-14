using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace XLua
{
	// Token: 0x02000177 RID: 375
	internal class ReferenceEqualsComparer : IEqualityComparer<object>
	{
		// Token: 0x06000B5E RID: 2910 RVA: 0x0005A8DC File Offset: 0x00058ADC
		public bool Equals(object o1, object o2)
		{
			return o1 == o2;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0005A8F4 File Offset: 0x00058AF4
		public int GetHashCode(object obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}
	}
}

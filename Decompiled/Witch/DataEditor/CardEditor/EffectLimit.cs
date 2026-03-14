using System;

namespace DataEditor.CardEditor
{
	// Token: 0x02000213 RID: 531
	public sealed class EffectLimit : Attribute
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0008AC6F File Offset: 0x00088E6F
		public int limit { get; }

		// Token: 0x06001173 RID: 4467 RVA: 0x0008AC77 File Offset: 0x00088E77
		public EffectLimit(int limit)
		{
			this.limit = limit;
		}
	}
}

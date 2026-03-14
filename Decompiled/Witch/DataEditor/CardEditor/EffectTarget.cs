using System;

namespace DataEditor.CardEditor
{
	// Token: 0x02000214 RID: 532
	public sealed class EffectTarget : Attribute
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0008AC88 File Offset: 0x00088E88
		public float weight { get; }

		// Token: 0x06001175 RID: 4469 RVA: 0x0008AC90 File Offset: 0x00088E90
		public EffectTarget(float target)
		{
			this.weight = target;
		}
	}
}

using System;

namespace DataEditor.CardEditor
{
	// Token: 0x02000211 RID: 529
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	public sealed class EffectName : Attribute
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0008AC3D File Offset: 0x00088E3D
		public string text { get; }

		// Token: 0x0600116F RID: 4463 RVA: 0x0008AC45 File Offset: 0x00088E45
		public EffectName(string name)
		{
			this.text = name;
		}
	}
}

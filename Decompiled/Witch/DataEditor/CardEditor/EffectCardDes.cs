using System;

namespace DataEditor.CardEditor
{
	// Token: 0x02000215 RID: 533
	public sealed class EffectCardDes : Attribute
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x0008ACA1 File Offset: 0x00088EA1
		public string text { get; }

		// Token: 0x06001177 RID: 4471 RVA: 0x0008ACA9 File Offset: 0x00088EA9
		public EffectCardDes(string des)
		{
			this.text = des;
		}
	}
}

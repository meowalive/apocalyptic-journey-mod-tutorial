using System;

namespace DataEditor.CardEditor
{
	// Token: 0x02000212 RID: 530
	public sealed class EffectDes : Attribute
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x0008AC56 File Offset: 0x00088E56
		public string text { get; }

		// Token: 0x06001171 RID: 4465 RVA: 0x0008AC5E File Offset: 0x00088E5E
		public EffectDes(string des)
		{
			this.text = des;
		}
	}
}

using System;

namespace DataEditor.CardEditor
{
	// Token: 0x02000216 RID: 534
	public sealed class AddDesVal : Attribute
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0008ACBA File Offset: 0x00088EBA
		public string text { get; }

		// Token: 0x06001179 RID: 4473 RVA: 0x0008ACC2 File Offset: 0x00088EC2
		public AddDesVal(string des)
		{
			this.text = des;
		}
	}
}

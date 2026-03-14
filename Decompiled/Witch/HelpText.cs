using System;

// Token: 0x0200002B RID: 43
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public sealed class HelpText : Attribute
{
	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000109 RID: 265 RVA: 0x000092EC File Offset: 0x000074EC
	public string text { get; }

	// Token: 0x0600010A RID: 266 RVA: 0x000092F4 File Offset: 0x000074F4
	public HelpText(string description)
	{
		this.text = description;
	}
}

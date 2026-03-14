using System;

// Token: 0x02000038 RID: 56
public class DataConfigIdNotFoundException : DataConfigException
{
	// Token: 0x1700003B RID: 59
	// (get) Token: 0x0600017A RID: 378 RVA: 0x0000D993 File Offset: 0x0000BB93
	public string Id { get; }

	// Token: 0x0600017B RID: 379 RVA: 0x0000D99B File Offset: 0x0000BB9B
	public DataConfigIdNotFoundException(string id) : base("DataConfig with ID '" + id + "' not found.")
	{
		this.Id = id;
	}
}

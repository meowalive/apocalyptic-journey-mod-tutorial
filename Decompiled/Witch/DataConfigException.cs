using System;

// Token: 0x02000037 RID: 55
public class DataConfigException : Exception
{
	// Token: 0x06000178 RID: 376 RVA: 0x0000D97C File Offset: 0x0000BB7C
	public DataConfigException(string message) : base(message)
	{
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0000D987 File Offset: 0x0000BB87
	public DataConfigException(string message, Exception innerException) : base(message, innerException)
	{
	}
}

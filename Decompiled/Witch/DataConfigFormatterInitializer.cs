using System;
using MemoryPack;

// Token: 0x0200011A RID: 282
public static class DataConfigFormatterInitializer
{
	// Token: 0x060008E3 RID: 2275 RVA: 0x00046FF0 File Offset: 0x000451F0
	public static void RegisterFormatter()
	{
		bool flag = !MemoryPackFormatterProvider.IsRegistered<IDataConfig>();
		if (flag)
		{
			MemoryPackFormatterProvider.Register<IDataConfig>(new DataConfigFormatter());
		}
	}
}

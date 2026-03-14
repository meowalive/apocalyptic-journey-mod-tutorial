using System;
using MemoryPack;
using Mirror;

// Token: 0x02000039 RID: 57
public static class DataConfigSerializer
{
	// Token: 0x0600017C RID: 380 RVA: 0x0000D9BC File Offset: 0x0000BBBC
	public static void WriteDataConfig(this NetworkWriter writer, DataConfig dataConfig)
	{
		writer.WriteBytesAndSize(MemoryPackSerializer.Serialize<DataConfig>(dataConfig, null));
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
	public static DataConfig ReadDataConfig(this NetworkReader reader)
	{
		return MemoryPackSerializer.Deserialize<DataConfig>(reader.ReadBytesAndSize(), null);
	}
}

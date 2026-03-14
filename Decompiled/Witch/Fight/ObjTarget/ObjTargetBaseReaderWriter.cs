using System;
using MemoryPack;
using Mirror;

namespace Fight.ObjTarget
{
	// Token: 0x020001EB RID: 491
	public static class ObjTargetBaseReaderWriter
	{
		// Token: 0x060010C8 RID: 4296 RVA: 0x00088040 File Offset: 0x00086240
		public static void Write(this NetworkWriter writer, ObjTargetBase command)
		{
			writer.WriteBytesAndSize(MemoryPackSerializer.Serialize<ObjTargetBase>(command, null));
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00088054 File Offset: 0x00086254
		public static ObjTargetBase Read(this NetworkReader reader)
		{
			return MemoryPackSerializer.Deserialize<ObjTargetBase>(reader.ReadBytesAndSize(), null);
		}
	}
}

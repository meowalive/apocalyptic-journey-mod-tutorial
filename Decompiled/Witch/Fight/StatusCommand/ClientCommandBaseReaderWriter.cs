using System;
using MemoryPack;
using Mirror;

namespace Fight.StatusCommand
{
	// Token: 0x020001DE RID: 478
	public static class ClientCommandBaseReaderWriter
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x0008685A File Offset: 0x00084A5A
		public static void Write(this NetworkWriter writer, ClientCommandBase command)
		{
			writer.WriteBytesAndSize(MemoryPackSerializer.Serialize<ClientCommandBase>(command, null));
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0008686C File Offset: 0x00084A6C
		public static ClientCommandBase Read(this NetworkReader reader)
		{
			byte[] data = reader.ReadBytesAndSize();
			return MemoryPackSerializer.Deserialize<ClientCommandBase>(data, null);
		}
	}
}

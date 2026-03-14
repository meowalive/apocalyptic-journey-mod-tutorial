using System;
using MemoryPack;
using Mirror;

namespace Fight.ActionCommand
{
	// Token: 0x020001F3 RID: 499
	public static class ActionCommandBaseReaderWriter
	{
		// Token: 0x060010EF RID: 4335 RVA: 0x00088A9E File Offset: 0x00086C9E
		public static void Write(this NetworkWriter writer, ActionCommandBase command)
		{
			writer.WriteBytesAndSize(MemoryPackSerializer.Serialize<ActionCommandBase>(command, null));
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00088AB0 File Offset: 0x00086CB0
		public static ActionCommandBase Read(this NetworkReader reader)
		{
			byte[] data = reader.ReadBytesAndSize();
			return MemoryPackSerializer.Deserialize<ActionCommandBase>(data, null);
		}
	}
}

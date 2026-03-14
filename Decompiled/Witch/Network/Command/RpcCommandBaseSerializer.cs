using System;
using Mirror;
using Newtonsoft.Json;

namespace Network.Command
{
	// Token: 0x020001D4 RID: 468
	public static class RpcCommandBaseSerializer
	{
		// Token: 0x06001056 RID: 4182 RVA: 0x00085C48 File Offset: 0x00083E48
		public static void Write(this NetworkWriter writer, RpcCommandBase value)
		{
			string json = JsonConvert.SerializeObject(value, new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.All
			});
			writer.WriteString(json);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00085C74 File Offset: 0x00083E74
		public static RpcCommandBase Read(this NetworkReader reader)
		{
			string json = reader.ReadString();
			return JsonConvert.DeserializeObject<RpcCommandBase>(json, new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.All
			});
		}
	}
}

using System;
using Mirror;
using Newtonsoft.Json;

namespace Network.Query
{
	// Token: 0x020001CD RID: 461
	public static class QueryBaseSerializer
	{
		// Token: 0x06001044 RID: 4164 RVA: 0x00085A60 File Offset: 0x00083C60
		public static void Write(this NetworkWriter writer, QueryBase value)
		{
			byte[] compressed = GZip.CompressString(JsonConvert.SerializeObject(value, new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.All
			}));
			writer.WriteBytesAndSize(compressed);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00085A90 File Offset: 0x00083C90
		public static QueryBase Read(this NetworkReader reader)
		{
			string json = GZip.DecompressToString(reader.ReadBytesAndSize());
			return JsonConvert.DeserializeObject<QueryBase>(json, new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.All
			});
		}
	}
}

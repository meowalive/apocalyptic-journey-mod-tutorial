using System;
using System.IO;
using System.IO.Compression;
using Mirror;
using Newtonsoft.Json;

// Token: 0x0200003F RID: 63
public static class CustomRoleTableReaderWriter
{
	// Token: 0x060001B5 RID: 437 RVA: 0x0000F898 File Offset: 0x0000DA98
	public static void WriteRoleTable(this NetworkWriter writer, RoleTable roleTable)
	{
		using (MemoryStream ms = new MemoryStream())
		{
			GZipStream gzip = new GZipStream(ms, CompressionMode.Compress);
			using (StreamWriter streamWriter = new StreamWriter(gzip))
			{
				string json = JsonConvert.SerializeObject(roleTable);
				streamWriter.Write(json);
			}
			gzip.Close();
			writer.WriteBytesAndSize(ms.ToArray());
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0000F918 File Offset: 0x0000DB18
	public static RoleTable ReadRoleTable(this NetworkReader reader)
	{
		byte[] compressedData = reader.ReadBytesAndSize();
		RoleTable result;
		using (MemoryStream ms = new MemoryStream(compressedData))
		{
			GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress);
			using (StreamReader streamReader = new StreamReader(gzip))
			{
				string json = streamReader.ReadToEnd();
				result = JsonConvert.DeserializeObject<RoleTable>(json);
			}
		}
		return result;
	}
}

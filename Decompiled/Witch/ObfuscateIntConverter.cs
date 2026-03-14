using System;
using Loxodon.Framework.Obfuscation;
using Newtonsoft.Json;

// Token: 0x02000057 RID: 87
public class ObfuscateIntConverter : JsonConverter<ObfuscatedInt>
{
	// Token: 0x0600023D RID: 573 RVA: 0x00014CB7 File Offset: 0x00012EB7
	public override void WriteJson(JsonWriter writer, ObfuscatedInt value, JsonSerializer serializer)
	{
		writer.WriteValue(value);
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00014CC8 File Offset: 0x00012EC8
	public override ObfuscatedInt ReadJson(JsonReader reader, Type objectType, ObfuscatedInt existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		int intValue = Convert.ToInt32(reader.Value);
		return new ObfuscatedInt(intValue);
	}
}

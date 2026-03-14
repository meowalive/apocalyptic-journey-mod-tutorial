using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020000AF RID: 175
public class StatusManagerConverter : JsonConverter<StatusManager>
{
	// Token: 0x0600059B RID: 1435 RVA: 0x00032834 File Offset: 0x00030A34
	public override void WriteJson(JsonWriter writer, StatusManager value, JsonSerializer serializer)
	{
		string statusData = value.InstanceId;
		writer.WriteValue(statusData);
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00032854 File Offset: 0x00030A54
	public override StatusManager ReadJson(JsonReader reader, Type objectType, StatusManager existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		object value = reader.Value;
		string instanceid = (value != null) ? value.ToString() : null;
		bool flag = string.IsNullOrEmpty(instanceid);
		StatusManager result;
		if (flag)
		{
			result = null;
		}
		else
		{
			StatusManager statusManager = FightManager.Instance.statuses.GetValueOrDefault(instanceid, null);
			result = statusManager;
		}
		return result;
	}
}

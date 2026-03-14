using System;
using System.Collections.Generic;

namespace DataEditor.CardEditor
{
	// Token: 0x02000218 RID: 536
	public sealed class BuffData : ScriptData
	{
		// Token: 0x06001180 RID: 4480 RVA: 0x0008ACF8 File Offset: 0x00088EF8
		public new static List<string> GetValues()
		{
			List<string> values = new List<string>();
			foreach (Dictionary<string, string> value in Singleton<GameConfigManager>.Instance.GetTable(DataType.Buff).Getlines())
			{
				bool flag;
				if (!Singleton<GameRuntimeData>.Instance.IsLocked(value["Id"]) && !value["Id"].Contains("SpecialBuff"))
				{
					string a = value["Type"];
					flag = (a == "技能" || a == "能力");
				}
				else
				{
					flag = true;
				}
				bool flag2 = flag;
				if (!flag2)
				{
					values.Add(value.Localize("Name") + "<size=0>^^" + value["Id"] + "</size>");
				}
			}
			return values;
		}
	}
}

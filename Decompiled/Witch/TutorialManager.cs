using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000CC RID: 204
public class TutorialManager : Singleton<TutorialManager>
{
	// Token: 0x060006EF RID: 1775 RVA: 0x0003A688 File Offset: 0x00038888
	public void Init()
	{
		List<Dictionary<string, string>> list = Singleton<GameConfigManager>.Instance.GetTable(DataType.Tutorial).Getlines();
		foreach (Dictionary<string, string> item in Singleton<GameConfigManager>.Instance.GetTable(DataType.Tutorial).Getlines())
		{
			bool flag = !Singleton<GameRuntimeData>.Instance.TutorialData.ContainsKey(item["Id"]);
			if (flag)
			{
				Singleton<GameRuntimeData>.Instance.TutorialData.TryAdd(item["Id"], item["Initial"]);
			}
		}
		foreach (Dictionary<string, string> item2 in list)
		{
			string[] eventName = item2.GetValueOrDefault("EventName", "").Split(',', StringSplitOptions.None);
			Dictionary<string, string> tempItem = item2;
			bool flag2 = eventName.Length == 0;
			if (!flag2)
			{
				string[] array = eventName;
				for (int i = 0; i < array.Length; i++)
				{
					string thisname = array[i];
					string nowname = thisname;
					bool flag3 = nowname == "";
					if (!flag3)
					{
						Singleton<EventCenter>.Instance.AddEventListener(nowname, delegate()
						{
							bool flag4 = Singleton<GameRuntimeData>.Instance.TutorialData[tempItem["Id"]] == "TRUE";
							if (!flag4)
							{
								Debug.Log("触发教程事件" + nowname + " 显示教程 " + tempItem["Id"]);
							}
						}, this, EventDispose.None);
					}
				}
			}
		}
	}
}

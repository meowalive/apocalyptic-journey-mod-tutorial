using System;
using System.Collections.Generic;
using Data.Save;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x020000DF RID: 223
public class BlessingRelic : Singleton<BlessingRelic>
{
	// Token: 0x060007B3 RID: 1971 RVA: 0x0003D7AC File Offset: 0x0003B9AC
	public BlessingRelic Init()
	{
		this.DataConfigs.Clear();
		foreach (DataConfig relic in RoleTable.Instance.relicList)
		{
			this.DataConfigs.Add(relic);
		}
		bool isServer = PlayerManager.Instance.isServer;
		if (isServer)
		{
			foreach (DataConfig item in GameSaveManager.GetHardTags())
			{
				bool flag = item.data["FightScript"] != "";
				if (flag)
				{
					this.DataConfigs.Add(item);
				}
			}
		}
		int basecount = this.DataConfigs.Count;
		foreach (DataConfig blessing in RoleTable.Instance.blessingConfigs)
		{
			bool flag2 = blessing.data["FightScript"] != "";
			if (flag2)
			{
				this.DataConfigs.Add(blessing);
			}
		}
		TopBarUI ui = UIManager.Instance.GetUI<TopBarUI>("TopBarUI");
		if (ui != null)
		{
			ui.SetRelicGlowEvent();
		}
		return this;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0003D938 File Offset: 0x0003BB38
	public BlessingRelic Apply(StatusManager status)
	{
		foreach (DataConfig kvp in this.DataConfigs)
		{
			bool flag = status != null;
			if (flag)
			{
				kvp.scriptExecutor.Self = status;
				kvp.scriptExecutor.Object.Clear();
				kvp.scriptExecutor.Object.Add(status);
				kvp.scriptExecutor.RunScript("FightScript");
			}
		}
		return this;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0003D9DC File Offset: 0x0003BBDC
	public BlessingRelic Clear()
	{
		foreach (DataConfig kvp in this.DataConfigs)
		{
			bool flag = kvp.scriptExecutor != null;
			if (flag)
			{
				kvp.scriptExecutor.Clear();
			}
		}
		return this;
	}

	// Token: 0x04000B23 RID: 2851
	private List<DataConfig> DataConfigs = new List<DataConfig>();
}

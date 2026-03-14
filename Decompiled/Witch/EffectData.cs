using System;

// Token: 0x0200006F RID: 111
public class EffectData
{
	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000397 RID: 919 RVA: 0x0001E35E File Offset: 0x0001C55E
	public string Name
	{
		get
		{
			return this.dataConfig.data.Localize("Name");
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000398 RID: 920 RVA: 0x0001E375 File Offset: 0x0001C575
	public string Description
	{
		get
		{
			return this.dataConfig.data.Localize("Description");
		}
	}

	// Token: 0x06000399 RID: 921 RVA: 0x0001E38C File Offset: 0x0001C58C
	public void Init(DataConfig dataconfig)
	{
		this.dataConfig = dataconfig;
		this.InitScript = this.dataConfig.data["InitScript"];
		this.Timepoint = this.dataConfig.data["Timepoint"];
		this.Cost = int.Parse(this.dataConfig.data["Cost"]);
	}

	// Token: 0x0400096D RID: 2413
	public string InitScript;

	// Token: 0x0400096E RID: 2414
	public string Timepoint;

	// Token: 0x0400096F RID: 2415
	public int Cost;

	// Token: 0x04000970 RID: 2416
	private DataConfig dataConfig;
}

using System;

// Token: 0x020000F3 RID: 243
public class AchievementBase
{
	// Token: 0x06000814 RID: 2068 RVA: 0x000404D8 File Offset: 0x0003E6D8
	public AchievementBase()
	{
		this.info.name = "空成就";
		this.info.description = "无";
		this.info.tip = "";
		this.info.level = "铜";
		this.info.status = "0";
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0004053D File Offset: 0x0003E73D
	public AchievementBase(AchievementBase.AchievementInfo info)
	{
		this.info = info;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0004054E File Offset: 0x0003E74E
	public void SetStatus(string status)
	{
		this.info.status = status;
	}

	// Token: 0x04000B86 RID: 2950
	public AchievementBase.AchievementInfo info;

	// Token: 0x020000F4 RID: 244
	public struct AchievementInfo
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x0004055D File Offset: 0x0003E75D
		public AchievementInfo(string name, string description, string tip, string level, string status)
		{
			this.name = name;
			this.description = description;
			this.tip = tip;
			this.level = level;
			this.status = status;
		}

		// Token: 0x04000B87 RID: 2951
		public string name;

		// Token: 0x04000B88 RID: 2952
		public string description;

		// Token: 0x04000B89 RID: 2953
		public string tip;

		// Token: 0x04000B8A RID: 2954
		public string level;

		// Token: 0x04000B8B RID: 2955
		public string status;
	}
}

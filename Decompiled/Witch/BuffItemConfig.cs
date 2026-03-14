using System;
using Fight.ActionCommand;
using TMPro;
using Witch.UI.Component;
using Witch.UI.Window;

/// <summary>
/// 通用的Buff数据交换类
/// </summary>
// Token: 0x02000009 RID: 9
public class BuffItemConfig : IBuffItemConfig
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000015 RID: 21 RVA: 0x00002369 File Offset: 0x00000569
	// (set) Token: 0x06000016 RID: 22 RVA: 0x00002374 File Offset: 0x00000574
	public int Level
	{
		get
		{
			return this.level;
		}
		set
		{
			bool flag = value > this.UpperBound;
			if (flag)
			{
				value = this.UpperBound;
			}
			bool flag2 = value == this.level;
			if (!flag2)
			{
				this.level = value;
				bool flag3 = this.level < 0;
				if (flag3)
				{
					this.level = 0;
				}
				bool flag4 = this.buffItem == null;
				if (!flag4)
				{
					bool flag5 = this.level == 0;
					if (flag5)
					{
						this.buffItem.ClearBuff();
					}
					else
					{
						this.buffItem.UpdateMsg();
						Singleton<EventCenter>.Instance.EventTrigger(this.BuffId + "OnLevelChange" + this.status.InstanceId);
						bool isDisplay = this.buffBarUI.isDisplay;
						if (!isDisplay)
						{
							FightManager.Instance.EnqueueEvent(new UpdateBuff().Create(this));
							this.buffItem.transform.Find("Content/Level").GetComponent<TMP_Text>().SetDigitText(this.Level.ToString());
						}
					}
				}
			}
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000017 RID: 23 RVA: 0x00002483 File Offset: 0x00000683
	// (set) Token: 0x06000018 RID: 24 RVA: 0x0000248B File Offset: 0x0000068B
	public int UpperBound { get; set; }

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000019 RID: 25 RVA: 0x00002494 File Offset: 0x00000694
	// (set) Token: 0x0600001A RID: 26 RVA: 0x0000249C File Offset: 0x0000069C
	public int ReducePerTurn { get; set; }

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600001B RID: 27 RVA: 0x000024A5 File Offset: 0x000006A5
	// (set) Token: 0x0600001C RID: 28 RVA: 0x000024AD File Offset: 0x000006AD
	public int ReducePerUse { get; set; }

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600001D RID: 29 RVA: 0x000024B6 File Offset: 0x000006B6
	// (set) Token: 0x0600001E RID: 30 RVA: 0x000024BE File Offset: 0x000006BE
	public int ReducePerAttacked { get; set; }

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600001F RID: 31 RVA: 0x000024C7 File Offset: 0x000006C7
	// (set) Token: 0x06000020 RID: 32 RVA: 0x000024CF File Offset: 0x000006CF
	public IBuffItem buffItem { get; set; }

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000021 RID: 33 RVA: 0x000024D8 File Offset: 0x000006D8
	// (set) Token: 0x06000022 RID: 34 RVA: 0x000024E0 File Offset: 0x000006E0
	public IStatusManager status { get; set; }

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000023 RID: 35 RVA: 0x000024E9 File Offset: 0x000006E9
	// (set) Token: 0x06000024 RID: 36 RVA: 0x000024F1 File Offset: 0x000006F1
	public string BuffId { get; set; }

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000025 RID: 37 RVA: 0x000024FA File Offset: 0x000006FA
	public string BuffName
	{
		get
		{
			return this.dataConfig.data.Localize("Name");
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000026 RID: 38 RVA: 0x00002511 File Offset: 0x00000711
	public string Description
	{
		get
		{
			return this.dataConfig.Description();
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000027 RID: 39 RVA: 0x0000251E File Offset: 0x0000071E
	// (set) Token: 0x06000028 RID: 40 RVA: 0x00002526 File Offset: 0x00000726
	public string Type { get; set; }

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000029 RID: 41 RVA: 0x0000252F File Offset: 0x0000072F
	// (set) Token: 0x0600002A RID: 42 RVA: 0x00002537 File Offset: 0x00000737
	public IDataConfig dataConfig { get; set; }

	// Token: 0x0600002B RID: 43 RVA: 0x00002540 File Offset: 0x00000740
	public BuffItemConfig()
	{
	}

	/// <summary>
	/// 持续时间的自减及边界判定
	/// </summary>
	/// <returns></returns>
	// Token: 0x0600002C RID: 44 RVA: 0x0000254C File Offset: 0x0000074C
	public bool DurationCheck(string way)
	{
		bool isDisplay = this.buffBarUI.isDisplay;
		bool result;
		if (isDisplay)
		{
			result = false;
		}
		else
		{
			bool flag = way == "ReducePerTurn";
			if (flag)
			{
				this.Level -= this.ReducePerTurn;
			}
			else
			{
				bool flag2 = way == "ReducePerUse";
				if (flag2)
				{
					this.Level -= this.ReducePerUse;
				}
				else
				{
					bool flag3 = way == "ReducePerAttacked";
					if (flag3)
					{
						this.Level -= this.ReducePerAttacked;
					}
				}
			}
			result = false;
		}
		return result;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000025E8 File Offset: 0x000007E8
	public BuffItemConfig(DataConfig dataConfig, StatusManager Status, BuffBarUI buffBarUI)
	{
		this.dataConfig = dataConfig;
		this.buffBarUI = buffBarUI;
		this.BuffId = dataConfig.data["Id"];
		this.status = Status;
		this.ReducePerTurn = int.Parse(dataConfig.data["ReducePerTurn"]);
		this.ReducePerUse = int.Parse(dataConfig.data["ReducePerUse"]);
		this.ReducePerAttacked = int.Parse(dataConfig.data["ReducePerAttacked"]);
		this.UpperBound = int.Parse(dataConfig.data["UpperBound"]);
		this.Icon = dataConfig.data["Icon"];
		this.Type = dataConfig.data.Localize("Type");
	}

	// Token: 0x0400000B RID: 11
	[NonSerialized]
	public string Icon;

	// Token: 0x0400000C RID: 12
	public int level;

	// Token: 0x04000013 RID: 19
	[NonSerialized]
	public BuffBarUI buffBarUI;
}

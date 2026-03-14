using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000A0 RID: 160
public class ObjectCard
{
	// Token: 0x06000486 RID: 1158 RVA: 0x00025FFC File Offset: 0x000241FC
	public void Init(DataConfig dataConfig)
	{
		this.dataConfig = dataConfig;
		dataConfig.scriptExecutor.Self = this.status;
		this.DataUpdate();
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x0002601F File Offset: 0x0002421F
	public void DataUpdate()
	{
		this.dataConfig.scriptExecutor.RunScript("InitScript");
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00026038 File Offset: 0x00024238
	public void UseCard(StatusManager target)
	{
		this.dataConfig.scriptExecutor.Self = this.status;
		bool flag = EnemyManager.Instance.enemyList.Count == 0;
		if (!flag)
		{
			this.SetStatus();
			this.dataConfig.scriptExecutor.Target = target;
			this.dataConfig.scriptExecutor.RunScript("UseScript");
			Singleton<EventCenter>.Instance.EventTrigger<ActionData>("Action" + this.dataConfig.scriptExecutor.Self.InstanceId, new ActionData(this.dataConfig, this.status.InstanceId));
			this.status.CheckAllBuff("ReducePerUse");
			this.DataUpdate();
		}
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00026100 File Offset: 0x00024300
	public void SetStatus()
	{
		this.dataConfig.scriptExecutor.RunScript("TargetScript");
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x0002611C File Offset: 0x0002431C
	public int GetPriority()
	{
		bool flag = this.nowCD > 0 || this.isIgnored;
		int result;
		if (flag)
		{
			result = -1;
		}
		else
		{
			bool flag2 = !this.dataConfig.Vars.ContainsKey("priority");
			if (flag2)
			{
				Debug.LogError("没有稀有度" + this.dataConfig.data["Id"]);
				result = 0;
			}
			else
			{
				result = ((this.dataConfig.Vars["priority"].ToInt() > 0) ? this.dataConfig.Vars["priority"] : "0").ToInt();
			}
		}
		return result;
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x000261D0 File Offset: 0x000243D0
	public void UpdateMsg()
	{
		bool flag = this.nowCD > 0;
		if (flag)
		{
			this.nowCD--;
		}
		this.DataUpdate();
	}

	// Token: 0x040009E4 RID: 2532
	public int nowCD;

	// Token: 0x040009E5 RID: 2533
	public bool isIgnored = false;

	// Token: 0x040009E6 RID: 2534
	public StatusManager status;

	// Token: 0x040009E7 RID: 2535
	public DataConfig dataConfig;

	// Token: 0x040009E8 RID: 2536
	public List<string> keyWords = new List<string>();
}

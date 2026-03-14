using System;
using System.Reflection;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x020000AE RID: 174
public class StatusDataTransfer
{
	// Token: 0x06000596 RID: 1430 RVA: 0x000325E8 File Offset: 0x000307E8
	public StatusDataTransfer(StatusManager status)
	{
		this.maxHp = status.MaxHp;
		this.curHp = status.CurHp;
		this.defend = status.Defend;
		this.ToughOrigin = status.ToughOrigin;
		this._toughCount = status.ToughCount;
		this.InstanceId = status.InstanceId;
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00032648 File Offset: 0x00030848
	public StatusDataTransfer(StatusDataTransfer status)
	{
		this.maxHp = status.maxHp;
		this.curHp = status.curHp;
		this.defend = status.defend;
		this.ToughOrigin = status.ToughOrigin;
		this._toughCount = status._toughCount;
		this.InstanceId = status.InstanceId;
	}

	/// <summary>
	/// 返回的是一个新的StatusDataTransfer对象，修改了属性值
	/// </summary>
	/// <param name="propertyName"></param>
	/// <param name="value"></param>
	/// <returns></returns>
	// Token: 0x06000598 RID: 1432 RVA: 0x000326A8 File Offset: 0x000308A8
	public StatusDataTransfer WithPropertys(string propertyName, object value)
	{
		StatusDataTransfer status = new StatusDataTransfer(this);
		FieldInfo property = status.GetType().GetField(propertyName);
		bool flag = property != null;
		if (flag)
		{
			property.SetValue(status, value);
		}
		return status;
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00002540 File Offset: 0x00000740
	public StatusDataTransfer()
	{
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x000326E8 File Offset: 0x000308E8
	public void Populate(StatusManager status)
	{
		status.maxHp = this.maxHp;
		status.curHp = this.curHp;
		status.defend = this.defend;
		status.ToughOrigin = this.ToughOrigin;
		status._toughCount = this._toughCount;
		bool flag = this.InstanceId == PlayerManager.Instance.PlayerId;
		if (flag)
		{
			RoleTable.Instance.maxSan = status.maxHp;
			RoleTable.Instance.san = status.curHp;
			bool flag2 = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
			if (flag2)
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeSan(RoleTable.Instance.Id);
			}
		}
		bool flag3 = status.curHp > 0 && status.state == IStatusManager.State.Dead;
		if (flag3)
		{
			status.state = IStatusManager.State.Default;
			bool flag4 = status.fatherObject is FightPlayer;
			if (flag4)
			{
				RoleTable.Instance.isDead = false;
			}
			status.isResurrecting = false;
		}
		else
		{
			bool flag5 = (status.curHp <= 0 || status.maxHp <= 0) && status.state != IStatusManager.State.Dead && !status.isResurrecting;
			if (flag5)
			{
				status.state = IStatusManager.State.Dead;
			}
		}
		status.UpdateStatus(true);
	}

	// Token: 0x04000A2F RID: 2607
	public readonly int maxHp;

	// Token: 0x04000A30 RID: 2608
	public readonly int curHp;

	// Token: 0x04000A31 RID: 2609
	public readonly int defend;

	// Token: 0x04000A32 RID: 2610
	public readonly int _toughCount;

	// Token: 0x04000A33 RID: 2611
	public readonly int ToughOrigin;

	// Token: 0x04000A34 RID: 2612
	public readonly string InstanceId;
}

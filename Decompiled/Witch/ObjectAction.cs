using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x0200009E RID: 158
public class ObjectAction
{
	// Token: 0x0600047C RID: 1148 RVA: 0x00025C74 File Offset: 0x00023E74
	public ObjectAction(OtherObj father)
	{
		this.fatherObj = father;
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00025CC5 File Offset: 0x00023EC5
	public void AddCard(ObjectCard enemyCard)
	{
		this.ObjectCards.Push(enemyCard);
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00025CD8 File Offset: 0x00023ED8
	public virtual void ActionExecute()
	{
		bool flag = this.CardList.Count == 0;
		if (!flag)
		{
			bool flag2 = this.fatherObj == null;
			if (!flag2)
			{
				bool flag3 = EnemyManager.Instance.enemyList.Count == 0;
				if (!flag3)
				{
					IStatusManager target = (this.fatherObj is Enemy) ? FightPlayer.Instance.Status : EnemyManager.Instance.enemyList[0].Status;
					bool flag4 = Singleton<TempDataManager>.Instance.RoleStatusMap.ContainsKey(RoleTable.Instance.Id) && Singleton<TempDataManager>.Instance.RoleStatusMap[RoleTable.Instance.Id].Contains(this.fatherObj.Status.InstanceId);
					if (flag4)
					{
						this.CardList[0].UseCard(target as StatusManager);
						UIManager.Instance.GetUI<FightUI>("FightUI").CallActionAnimation(this.CardList[0].dataConfig.scriptExecutor);
					}
					this.CardList.RemoveAt(0);
				}
			}
		}
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00025E04 File Offset: 0x00024004
	public void DesActionCard(int index)
	{
		bool flag = index >= this.CardList.Count;
		if (!flag)
		{
			this.CardList.RemoveAt(index);
		}
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00025E38 File Offset: 0x00024038
	public ObjectCard TryGetCard()
	{
		bool flag = this.CardList.Count == 0;
		ObjectCard result;
		if (flag)
		{
			Debug.LogWarning("CardList is empty, cannot get card.");
			result = null;
		}
		else
		{
			result = this.CardList[0];
		}
		return result;
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00025E78 File Offset: 0x00024078
	public virtual List<ObjectCard> ActionShow(int count)
	{
		this.CardList.Clear();
		for (int i = 0; i < count; i++)
		{
			ObjectCard tmp = this.ObjectCards.Pop();
			bool flag = tmp.nowCD == 0;
			if (flag)
			{
				tmp.nowCD = tmp.dataConfig.Vars["CD"].ToInt();
				this.CardList.Add(tmp);
			}
			this.AddCard(tmp);
		}
		for (int j = 0; j < this.CardList.Count; j++)
		{
			this.CardList[j].SetStatus();
		}
		return this.CardList.ToList<ObjectCard>();
	}

	/// <summary>
	/// 从优先队列中依次取出卡牌，更新卡牌信息
	/// </summary>
	// Token: 0x06000482 RID: 1154 RVA: 0x00025F3C File Offset: 0x0002413C
	public void CardUpdate()
	{
		List<ObjectCard> temp = new List<ObjectCard>();
		while (!this.ObjectCards.IsEmpty())
		{
			ObjectCard objCard = this.ObjectCards.Pop();
			objCard.UpdateMsg();
			temp.Add(objCard);
		}
		foreach (ObjectCard enemyCard in temp)
		{
			this.ObjectCards.Push(enemyCard);
		}
	}

	// Token: 0x040009DF RID: 2527
	private OtherObj fatherObj;

	// Token: 0x040009E0 RID: 2528
	private Priority_Queue<ObjectCard> ObjectCards = new Priority_Queue<ObjectCard>((ObjectCard a, ObjectCard b) => -(a.GetPriority() - b.GetPriority()));

	// Token: 0x040009E1 RID: 2529
	private List<ObjectCard> CardList = new List<ObjectCard>();
}

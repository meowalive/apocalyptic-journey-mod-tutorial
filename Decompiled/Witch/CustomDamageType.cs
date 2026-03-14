using System;
using System.Collections.Generic;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000077 RID: 119
[CreateAssetMenu(fileName = "NewDamageType", menuName = "战斗/新建伤害类型", order = 52)]
public class CustomDamageType : ScriptableObject
{
	// Token: 0x060003B5 RID: 949 RVA: 0x0001EED0 File Offset: 0x0001D0D0
	public int ApplyDamage(StatusManager status, int damage, Vector3 vector, StatusManager from, int originalVal, string damageType, string fromDataId)
	{
		int realDamage = 0;
		bool flag = this.ignoreDefend;
		if (flag)
		{
			bool flag2 = status.dynamicVariables["MaxChangeHp"] < 1f;
			if (flag2)
			{
				bool flag3 = status.dynamicVariables["thisHP"] + (float)damage > (float)status.MaxHp * status.dynamicVariables["MaxChangeHp"];
				if (flag3)
				{
					damage = (int)((float)status.MaxHp * status.dynamicVariables["MaxChangeHp"] - status.dynamicVariables["thisHP"]);
				}
				Dictionary<string, float> dynamicVariables = status.dynamicVariables;
				dynamicVariables["thisHP"] = dynamicVariables["thisHP"] + (float)damage;
			}
			status.CurHp -= damage;
			realDamage += damage;
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayEffect("Effect/01角色斩击");
			}
			Singleton<EventCenter>.Instance.EventTrigger<HurtData>("Hurt" + status.InstanceId, new HurtData(damageType, damage.ToString(), from.InstanceId, fromDataId));
		}
		else
		{
			bool flag4 = status.Defend >= damage;
			if (flag4)
			{
				AudioManager instance2 = AudioManager.Instance;
				if (instance2 != null)
				{
					instance2.PlayEffect("Effect/01角色斩击");
				}
				status.Defend -= damage;
				realDamage += damage;
			}
			else
			{
				AudioManager instance3 = AudioManager.Instance;
				if (instance3 != null)
				{
					instance3.PlayEffect("Effect/01角色斩击");
				}
				damage -= status.Defend;
				bool flag5 = status.dynamicVariables["MaxChangeHp"] < 1f;
				if (flag5)
				{
					bool flag6 = status.dynamicVariables["thisHP"] + (float)damage > (float)status.MaxHp * status.dynamicVariables["MaxChangeHp"];
					if (flag6)
					{
						damage = (int)((float)status.MaxHp * status.dynamicVariables["MaxChangeHp"] - status.dynamicVariables["thisHP"]);
					}
					Dictionary<string, float> dynamicVariables = status.dynamicVariables;
					dynamicVariables["thisHP"] = dynamicVariables["thisHP"] + (float)damage;
				}
				realDamage += status.Defend;
				status.Defend = 0;
				status.CurHp -= damage;
				realDamage += damage;
				Singleton<EventCenter>.Instance.EventTrigger<HurtData>("Hurt" + status.InstanceId, new HurtData(damageType, damage.ToString(), from.InstanceId, fromDataId));
			}
		}
		this.ShowDamage(status, realDamage, vector, from, originalVal);
		return realDamage;
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x0001F16C File Offset: 0x0001D36C
	public void ShowDamage(StatusManager status, int damage, Vector3 vector, StatusManager from, int originalVal)
	{
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null && FightManager.Instance.fightType != FightType.Loss;
		if (flag)
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").EnqueueDamageText(originalVal.ToString(), vector, this.popUpType, from, status, damage.ToString());
		}
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x0001F1D8 File Offset: 0x0001D3D8
	public void ApplyHeal(StatusManager status, int heal)
	{
		status.CurHp += heal;
		bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null && FightManager.Instance.fightType != FightType.Loss && status.gameObject != null;
		if (flag)
		{
			bool flag2 = status.statusBarObj != null;
			if (flag2)
			{
				Singleton<EventCenter>.Instance.EventTrigger("Heal" + status.InstanceId);
				UIManager.Instance.GetUI<FightUI>("FightUI").EnqueueDamageText(heal.ToString(), status.statusBarObj.transform.localPosition, this.popUpType, null, status, heal.ToString());
			}
		}
	}

	// Token: 0x0400097E RID: 2430
	public string popUpType;

	// Token: 0x0400097F RID: 2431
	public bool ignoreDefend;

	// Token: 0x04000980 RID: 2432
	public bool CanUseTough;
}

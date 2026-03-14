using System;
using Cysharp.Text;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Network.Query;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Witch.UI;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x02000244 RID: 580
	public class TopStatusItem : MonoBehaviour
	{
		// Token: 0x060012B8 RID: 4792 RVA: 0x00093005 File Offset: 0x00091205
		public void Init(RoleTable roleTable)
		{
			this.roleTable = roleTable;
			this.UpdateStatus();
			this.ShowCareer();
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00093020 File Offset: 0x00091220
		public void ShowCareer()
		{
			bool flag = this.roleTable.Career != null;
			if (flag)
			{
				base.transform.Find("Avatar").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(this.roleTable.Career.data["Avatar"], true);
			}
			this.UpdateStatus();
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00093084 File Offset: 0x00091284
		public void UpdateStatus()
		{
			base.transform.Find("FightStatus/Health/HealthBar/val").GetComponent<TMP_Text>().text = ZString.Format<object, object>("{0}/{1}", this.roleTable.San, this.roleTable.MaxSan);
			bool flag = this.roleTable.MaxSan == 0;
			if (!flag)
			{
				base.transform.Find("FightStatus/Health/HealthBar/Bar").GetComponent<Image>().DOFillAmount((float)this.roleTable.San / (float)this.roleTable.MaxSan, 0.3f);
				base.transform.Find("FightStatus/Health/HealthBar").GetComponent<Image>().DOFillAmount((float)this.roleTable.San / (float)this.roleTable.MaxSan, 0.2f).SetDelay(0.3f);
				bool flag2 = FightManager.Instance != null && FightPlayer.Instance != null && FightManager.Instance.statuses.ContainsKey(this.roleTable.Id) && FightManager.Instance.statuses[this.roleTable.Id] != null;
				if (flag2)
				{
					this.UpdateDefend(FightManager.Instance.statuses[this.roleTable.Id].Defend.ToString());
				}
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000931F8 File Offset: 0x000913F8
		public void UpdateDefend(string Defend)
		{
			base.transform.Find("FightStatus/Health/HealthBar/DefendBar").gameObject.SetActive(true);
			base.transform.Find("FightStatus/Health/HealthBar/val").GetComponent<TMP_Text>().text = string.Concat(new string[]
			{
				this.roleTable.San.ToString(),
				"/",
				this.roleTable.MaxSan.ToString(),
				"  (",
				Defend,
				")"
			});
			bool flag = this.roleTable.MaxSan == 0;
			if (!flag)
			{
				base.transform.Find("FightStatus/Health/HealthBar/DefendBar").GetComponent<Image>().DOFillAmount(float.Parse(Defend) / (float)this.roleTable.MaxSan, 0.3f);
			}
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000932D8 File Offset: 0x000914D8
		public void OpenBack()
		{
			bool flag = this.isRequesting;
			if (!flag)
			{
				this.isRequesting = true;
				PlayerManager.Instance.SendQuery<StatusUIData>(new QueryStatus(this.roleTable.Id), delegate(StatusUIData result)
				{
					this.isRequesting = false;
					this.CareerInit(result);
					UIManager.Instance.GetUI<BackpackUI>("BackpackUI").ShowStatus(result);
					UIManager.Instance.ShowUI<BackpackUI>("BackpackUI", true);
				});
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00093320 File Offset: 0x00091520
		public void CareerInit(StatusUIData careerData)
		{
			this.roleTable.San = careerData.San;
			this.roleTable.MaxSan = careerData.MaxSan;
			base.transform.Find("Avatar").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(Singleton<GameConfigManager>.Instance.GetOneById(careerData.career.Vars["Id"])["Avatar"], true);
			this.UpdateStatus();
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000933A4 File Offset: 0x000915A4
		public void OpenDeck()
		{
			bool flag = this.isRequesting;
			if (!flag)
			{
				this.isRequesting = true;
				PlayerManager.Instance.SendQuery<OutDeckUIData>(new QueryDeck(this.roleTable.Id), delegate(OutDeckUIData result)
				{
					this.isRequesting = false;
					UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI").SetRole(result);
					UIManager.Instance.ShowUI<OutDeckUI>("OutDeckUI", true);
				});
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000933EC File Offset: 0x000915EC
		public void HideDefend()
		{
			this.Defend = 0;
			base.transform.Find("FightStatus/Health/HealthBar/DefendBar").gameObject.SetActive(false);
			base.transform.Find("FightStatus/Health/HealthBar/val").GetComponent<TMP_Text>().text = this.roleTable.San.ToString() + "/" + this.roleTable.MaxSan.ToString();
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00093468 File Offset: 0x00091668
		public void OtherChangeShow(string value, string type)
		{
			bool flag = type == "San";
			if (flag)
			{
				this.roleTable.san = int.Parse(value);
			}
			bool flag2 = type == "MaxSan";
			if (flag2)
			{
				this.roleTable.maxSan = int.Parse(value);
			}
			bool flag3 = type == "Defend";
			if (flag3)
			{
				this.Defend = int.Parse(value);
			}
			this.UpdateStatus();
		}

		// Token: 0x04000F53 RID: 3923
		public RoleTable roleTable;

		// Token: 0x04000F54 RID: 3924
		private int Defend = 0;

		// Token: 0x04000F55 RID: 3925
		private bool isRequesting = false;
	}
}

using System;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x020002BA RID: 698
	public class ShowCareer : ItemNonDrag
	{
		// Token: 0x060015C6 RID: 5574 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void Init(DataConfig dataConfig)
		{
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void DataUpdate()
		{
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x000AF878 File Offset: 0x000ADA78
		public override void OnPointerClick(PointerEventData eventData)
		{
			this.gameEntryUI.ShowDetail(this, this.belong, true);
			bool flag = this.belong == "Partner";
			if (flag)
			{
				this.gameEntryUI.partnerIndex = this.gameEntryUI.showPartners.FindIndex((ShowCareer x) => x == this);
			}
			else
			{
				bool flag2 = RoleTable.Instance != null;
				if (flag2)
				{
					RoleTable.Instance.Career = this.dataConfig;
				}
				this.gameEntryUI.careerIndex = this.gameEntryUI.showCareers.FindIndex((ShowCareer x) => x == this);
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0400113B RID: 4411
		public bool isSelected;

		// Token: 0x0400113C RID: 4412
		public string belong;

		// Token: 0x0400113D RID: 4413
		public GameEntryUI gameEntryUI;
	}
}

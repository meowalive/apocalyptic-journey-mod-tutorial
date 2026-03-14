using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x02000243 RID: 579
	public class AffectionItem : MonoBehaviour
	{
		// Token: 0x060012B2 RID: 4786 RVA: 0x00092DF4 File Offset: 0x00090FF4
		private void Awake()
		{
			Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00092E2C File Offset: 0x0009102C
		public void Init(DataConfig dataConfig)
		{
			this.dataConfig = dataConfig;
			this.DataUpdate();
			bool flag = this.affectionUI.firstShow && Singleton<GameRuntimeData>.Instance.Gain[dataConfig.data["Id"]] != -999 && this.dataConfig.data.ContainsKey("InitScript");
			if (flag)
			{
				this.dataConfig.scriptExecutor.RunScript("InitScript");
			}
			base.transform.Find("Reward/Text").GetComponent<TMP_Text>().text = dataConfig.data["Reward"];
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00092EDC File Offset: 0x000910DC
		public void OnPointerClick(PointerEventData eventData)
		{
			bool flag = Singleton<GameRuntimeData>.Instance.Gain[this.dataConfig.data["Id"]] < int.Parse(this.dataConfig.data["Target"]);
			if (!flag)
			{
				this.affectionUI.AddReward(this.dataConfig);
				Singleton<ObjectPool>.Instance.Release(base.gameObject);
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00092F54 File Offset: 0x00091154
		public void DataUpdate()
		{
			this.itemName = this.dataConfig.data.Localize("Name");
			this.itemDes = this.dataConfig.data.Localize("NeedDes");
			base.transform.Find("Des/Name").GetComponent<TMP_Text>().text = this.itemName;
			base.transform.Find("Des/Way").GetComponent<TMP_Text>().text = this.itemDes;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00092FDC File Offset: 0x000911DC
		private void OnDestroy()
		{
			Singleton<EventCenter>.Instance.RemoveEventListener(LanguageEvent.LanguageChange.ToString(), this);
		}

		// Token: 0x04000F4F RID: 3919
		public DataConfig dataConfig;

		// Token: 0x04000F50 RID: 3920
		private string itemName;

		// Token: 0x04000F51 RID: 3921
		private string itemDes;

		// Token: 0x04000F52 RID: 3922
		public AffectionUI affectionUI;
	}
}

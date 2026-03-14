using System;
using TMPro;
using UnityEngine.EventSystems;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x0200025C RID: 604
	public class TaskItem : ItemNonDrag
	{
		// Token: 0x06001362 RID: 4962 RVA: 0x000982A0 File Offset: 0x000964A0
		public override void Init(DataConfig dataConfig)
		{
			this.dataConfig = dataConfig;
			this.itemId = dataConfig.data["Id"];
			base.itemName = dataConfig.data.Localize("Name");
			base.name = base.itemName;
			bool flag = this.taskUI.firstShow && Singleton<GameRuntimeData>.Instance.Gain[dataConfig.data["Id"]] != -999 && this.dataConfig.data.ContainsKey("InitScript");
			if (flag)
			{
				this.dataConfig.scriptExecutor.RunScript("InitScript");
			}
			this.DataUpdate();
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0009835D File Offset: 0x0009655D
		public override void OnPointerClick(PointerEventData eventData)
		{
			this.taskUI.ShowTaskDetail(this.dataConfig);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00098372 File Offset: 0x00096572
		public override void DataUpdate()
		{
			base.transform.Find("Text").GetComponent<TMP_Text>().text = base.itemName;
		}

		// Token: 0x04000FBA RID: 4026
		public TaskUI taskUI;
	}
}

using System;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000310 RID: 784
	public class BlessItem : DictionaryItem
	{
		// Token: 0x0600187D RID: 6269 RVA: 0x000CEB80 File Offset: 0x000CCD80
		public override void DataUpdate()
		{
			bool flag = this.dataConfig == null || !base.gameObject.activeSelf;
			if (!flag)
			{
				base.itemName = this.dataConfig.data.Localize("Name");
				this.SetName();
			}
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x000CEBD4 File Offset: 0x000CCDD4
		public override void Init(DataConfig dataConfig)
		{
			base.Init(dataConfig);
			base.transform.Find("Normal/Icon").GetComponent<Image>().sprite = this.itemIcon;
			base.transform.Find("Highlighted/Icon").GetComponent<Image>().sprite = this.itemIcon;
			base.transform.Find("Pressed/Icon").GetComponent<Image>().sprite = this.itemIcon;
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x000CEC4D File Offset: 0x000CCE4D
		public override void OnPointerClick(PointerEventData eventData)
		{
			this.dictionaryUI.SetRelicDes(this, this.ItemType);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000CEC64 File Offset: 0x000CCE64
		public void SetName()
		{
			base.transform.Find("Normal/Text").GetComponent<TMP_Text>().text = base.itemName;
			base.transform.Find("Highlighted/Text").GetComponent<TMP_Text>().text = base.itemName;
			base.transform.Find("Pressed/Text").GetComponent<TMP_Text>().text = base.itemName;
		}
	}
}

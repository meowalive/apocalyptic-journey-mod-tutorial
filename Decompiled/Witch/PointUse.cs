using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x0200022F RID: 559
	public class PointUse : ItemNonDrag
	{
		// Token: 0x060011D9 RID: 4569 RVA: 0x0008C494 File Offset: 0x0008A694
		public override void Init(DataConfig dataConfig1)
		{
			base.Init(dataConfig1);
			base.gameObject.transform.Find("Highlighted/texts/Icon").GetComponent<Image>().sprite = (base.gameObject.transform.Find("Normal/texts/Icon").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(this.dataConfig.data["Icon"], true));
			base.gameObject.transform.Find("Highlighted/texts/title").GetComponent<TMP_Text>().text = (base.gameObject.transform.Find("Normal/texts/title").GetComponent<TMP_Text>().text = this.RewardType.Localize("BattleRewardUI") + "：");
			base.gameObject.transform.Find("Highlighted/texts/description").GetComponent<TMP_Text>().text = (base.gameObject.transform.Find("Normal/texts/description").GetComponent<TMP_Text>().text = this.dataConfig.data.Localize("Name"));
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0008C5C0 File Offset: 0x0008A7C0
		public void Init(string Name, string Description, Sprite Icon)
		{
			Image component = base.gameObject.transform.Find("Highlighted/texts/Icon").GetComponent<Image>();
			base.gameObject.transform.Find("Normal/texts/Icon").GetComponent<Image>().sprite = Icon;
			component.sprite = Icon;
			base.gameObject.transform.Find("Highlighted/texts/title").GetComponent<TMP_Text>().text = (base.gameObject.transform.Find("Normal/texts/title").GetComponent<TMP_Text>().text = Name.Localize("BattleRewardUI"));
			TMP_Text component2 = base.gameObject.transform.Find("Highlighted/texts/description").GetComponent<TMP_Text>();
			base.gameObject.transform.Find("Normal/texts/description").GetComponent<TMP_Text>().text = Description;
			component2.text = Description;
			base.itemDescription = Description;
		}

		// Token: 0x04000EFB RID: 3835
		public string RewardType;

		// Token: 0x04000EFC RID: 3836
		public string DesList;
	}
}

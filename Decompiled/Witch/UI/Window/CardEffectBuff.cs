using System;
using System.Collections.Generic;
using DataEditor.CardEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x020002B0 RID: 688
	public class CardEffectBuff : MonoBehaviour
	{
		// Token: 0x06001593 RID: 5523 RVA: 0x000AC89C File Offset: 0x000AAA9C
		private void Start()
		{
			this.buffdata = new BuffData();
			this.buffdata.Id = this.data["Id"];
			this.buffdata.Name = this.data["Name"];
			bool flag = base.GetComponent<KeywordDisplay>() == null;
			if (flag)
			{
				base.gameObject.AddComponent<KeywordDisplay>();
			}
			KeywordDisplay keywordDisplay = base.GetComponent<KeywordDisplay>();
			DataConfig config = new DataConfig(this.data["Id"], DataType.Buff);
			List<string> keyWords = new List<string>();
			keywordDisplay.SetText(this.buffdata.Name, config.Description().Highlight(keyWords), keyWords, null, null, null);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x000AC954 File Offset: 0x000AAB54
		public void SetData()
		{
			bool flag = CardEffectBuff.NowItem == null;
			if (!flag)
			{
				Sprite icon = ResourceLoader.Load<Sprite>(this.data["Icon"], true);
				bool flag2 = icon == null;
				if (flag2)
				{
					icon = ResourceLoader.Load<Sprite>("Icon/Buff/占位符", true);
				}
				CardEffectBuff.NowItem.transform.Find("Content/Icon").GetComponent<Image>().sprite = icon;
				CardEffectBuff.NowItem.followEffectName = this.data.Localize("Name") + "<size=0>^^" + this.data["Id"] + "</size>";
				CardEffectBuff.NowItem.transform.Find("Content/texts/description/buffInput").GetComponent<TMP_InputField>().text = this.data.Localize("Name");
				base.transform.parent.parent.gameObject.SetActive(false);
				CardEffectBuff.NowItem.UpdateAll();
			}
		}

		// Token: 0x04001116 RID: 4374
		public static CardEffectItem NowItem;

		// Token: 0x04001117 RID: 4375
		public Dictionary<string, string> data;

		// Token: 0x04001118 RID: 4376
		public BuffData buffdata;
	}
}

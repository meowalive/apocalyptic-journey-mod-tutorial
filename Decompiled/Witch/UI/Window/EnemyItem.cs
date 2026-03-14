using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200031C RID: 796
	public class EnemyItem : DictionaryItem
	{
		// Token: 0x060018CC RID: 6348 RVA: 0x000D0EBC File Offset: 0x000CF0BC
		public override void DataUpdate()
		{
			bool flag = this.dataConfig == null || !base.gameObject.activeSelf;
			if (!flag)
			{
				base.itemName = this.dataConfig.data.Localize("Name");
				this.SetName();
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000D0F10 File Offset: 0x000CF110
		public override void Init(DataConfig dataConfig)
		{
			this.dataConfig = dataConfig;
			this.keywords = new List<string>();
			this.itemId = dataConfig.data["Id"];
			base.itemName = dataConfig.data.Localize("Name");
			base.name = base.itemName;
			this.Rarity = dataConfig.data.GetValueOrDefault("Rarity", null);
			this.itemIcon = ResourceLoader.LoadAll<Sprite>(dataConfig.data["Animation"] + "/Idle")[0];
			Transform role = base.transform.Find("Normal/Left/Rect/Rect/Role");
			Transform role2 = base.transform.Find("Highlighted/Left/Rect/Rect/Role");
			Transform role3 = base.transform.Find("Pressed/Left/Rect/Rect/Role");
			role.GetComponent<Image>().sprite = this.itemIcon;
			role.GetComponent<Image>().SetNativeSize();
			role2.GetComponent<Image>().sprite = this.itemIcon;
			role2.GetComponent<Image>().SetNativeSize();
			role3.GetComponent<Image>().sprite = this.itemIcon;
			role3.GetComponent<Image>().SetNativeSize();
			TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(this.itemIcon.texture, 0.1f);
			Vector2 offset = new Vector2((float)(realBounds.leftTransparentWidth - realBounds.rightTransparentWidth) / 2f, (float)(realBounds.bottomTransparentHeight - realBounds.topTransparentHeight) / 2f);
			role.GetComponent<Image>().rectTransform.anchoredPosition = -offset;
			role2.GetComponent<Image>().rectTransform.anchoredPosition = -offset;
			role3.GetComponent<Image>().rectTransform.anchoredPosition = -offset;
			this.DataUpdate();
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x000D10CC File Offset: 0x000CF2CC
		public void SetName()
		{
			base.transform.Find("Normal/Right/Back/Text").GetComponent<TMP_Text>().text = base.itemName;
			base.transform.Find("Highlighted/Right/Back/Text").GetComponent<TMP_Text>().text = base.itemName;
			base.transform.Find("Pressed/Right/Back/Text").GetComponent<TMP_Text>().text = base.itemName;
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000D113D File Offset: 0x000CF33D
		public override void OnPointerClick(PointerEventData eventData)
		{
			this.dictionaryUI.SetEnemyDes(this);
		}

		// Token: 0x04001355 RID: 4949
		public static Dictionary<string, string> MapName = new Dictionary<string, string>
		{
			{
				"0",
				"奥尔德林"
			},
			{
				"1",
				"奥克维西亚"
			},
			{
				"2",
				"失乐园"
			},
			{
				"3",
				"魔王城"
			}
		};
	}
}

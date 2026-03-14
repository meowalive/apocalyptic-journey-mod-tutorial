using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000323 RID: 803
	public class ResultItem : ItemNonDrag
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x000D25F0 File Offset: 0x000D07F0
		public override void Init(DataConfig dataConfig)
		{
			base.Init(dataConfig);
			Color backgroundColor = new Color(0f, 0f, 0f);
			backgroundColor = new Color(0.7137255f, 0.5254902f, 0.23529412f);
			base.transform.Find("Normal/background").GetComponent<Image>().color = backgroundColor;
			base.transform.Find("Highlight/background").GetComponent<Image>().color = backgroundColor;
			this.KeyworsDis();
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x000D2674 File Offset: 0x000D0874
		public void KeyworsDis()
		{
			this.keywordDisplay = (base.gameObject.GetComponent<KeywordDisplay>() ?? base.gameObject.AddComponent<KeywordDisplay>());
			this.keywordDisplay.text = this.CreateTooltipText();
			this.keywordDisplay.keyWords = this.keywords;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void HideFloatingWindow()
		{
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000D26C4 File Offset: 0x000D08C4
		public override string CreateTooltipText()
		{
			return base.CreateTooltipText();
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x04001371 RID: 4977
		public bool canright = true;

		// Token: 0x04001372 RID: 4978
		public bool outside;
	}
}

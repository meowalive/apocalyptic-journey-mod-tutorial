using System;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200029C RID: 668
	public class BuffShowItem : ItemNonDrag
	{
		// Token: 0x060014FF RID: 5375 RVA: 0x000A6060 File Offset: 0x000A4260
		public override void Init(DataConfig dataConfig)
		{
			this.keywordDisplay = ((base.gameObject.GetComponent<KeywordDisplay>() != null) ? base.gameObject.GetComponent<KeywordDisplay>() : base.gameObject.AddComponent<KeywordDisplay>());
			base.Init(dataConfig);
			base.transform.GetComponent<Image>().sprite = this.itemIcon;
		}
	}
}

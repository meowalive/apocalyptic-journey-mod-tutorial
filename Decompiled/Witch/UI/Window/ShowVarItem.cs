using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x02000327 RID: 807
	public class ShowVarItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600192F RID: 6447 RVA: 0x000D3BA4 File Offset: 0x000D1DA4
		public void Start()
		{
			string name = base.transform.name;
			if (!true)
			{
			}
			string text;
			if (!(name == "Strength"))
			{
				if (!(name == "Lucky"))
				{
					if (!(name == "Perceive"))
					{
						if (!(name == "Wisdom"))
						{
							text = "未知";
						}
						else
						{
							text = "WisdomMsg".Localize("Tips");
						}
					}
					else
					{
						text = "PerceiveMsg".Localize("Tips");
					}
				}
				else
				{
					text = "LuckyMsg".Localize("Tips");
				}
			}
			else
			{
				text = "StrengthMsg".Localize("Tips");
			}
			if (!true)
			{
			}
			this.text = text;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x000D3C53 File Offset: 0x000D1E53
		public void OnPointerClick(PointerEventData eventData)
		{
			this.Show();
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x000D3C60 File Offset: 0x000D1E60
		public void Show()
		{
			UIManager.Instance.GetTooltip().Show(base.transform, base.transform.name.Localize("TopBarUI"), this.text, null, null, null, null, true, true);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000D3CA5 File Offset: 0x000D1EA5
		public void OnPointerExit(PointerEventData eventData)
		{
			UIManager.Instance.GetTooltip().Hide();
		}

		// Token: 0x0400137F RID: 4991
		public string text;
	}
}

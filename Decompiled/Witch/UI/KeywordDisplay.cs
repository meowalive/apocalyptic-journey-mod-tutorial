using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI
{
	// Token: 0x02000273 RID: 627
	public class KeywordDisplay : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0009BE5B File Offset: 0x0009A05B
		private Tooltip tooltip
		{
			get
			{
				return UIManager.Instance.GetTooltip();
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060013EE RID: 5102 RVA: 0x0009BE68 File Offset: 0x0009A068
		// (remove) Token: 0x060013EF RID: 5103 RVA: 0x0009BEA0 File Offset: 0x0009A0A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action OnShow;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060013F0 RID: 5104 RVA: 0x0009BED8 File Offset: 0x0009A0D8
		// (remove) Token: 0x060013F1 RID: 5105 RVA: 0x0009BF10 File Offset: 0x0009A110
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action OnHide;

		// Token: 0x060013F2 RID: 5106 RVA: 0x0009BF45 File Offset: 0x0009A145
		public void SetText(string title, string text, List<string> keyWords, string msg = null, Sprite icon = null, string type = null)
		{
			this.text = text;
			this.title = title;
			this.keyWords = keyWords;
			this.msg = msg;
			this.icon = icon;
			this.type = type;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0009BF78 File Offset: 0x0009A178
		public void OnPointerEnter(PointerEventData eventData)
		{
			bool flag = this.IsNull("Object");
			if (!flag)
			{
				this.isHover = true;
				UniTask.Create(delegate()
				{
					KeywordDisplay.<<OnPointerEnter>b__16_0>d <<OnPointerEnter>b__16_0>d = new KeywordDisplay.<<OnPointerEnter>b__16_0>d();
					<<OnPointerEnter>b__16_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
					<<OnPointerEnter>b__16_0>d.<>4__this = this;
					<<OnPointerEnter>b__16_0>d.<>1__state = -1;
					<<OnPointerEnter>b__16_0>d.<>t__builder.Start<KeywordDisplay.<<OnPointerEnter>b__16_0>d>(ref <<OnPointerEnter>b__16_0>d);
					return <<OnPointerEnter>b__16_0>d.<>t__builder.Task;
				});
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0009BFB0 File Offset: 0x0009A1B0
		public void OnPointerExit(PointerEventData eventData)
		{
			this.isHover = false;
			Action onHide = this.OnHide;
			if (onHide != null)
			{
				onHide();
			}
			this.tooltip.Hide();
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0009BFD8 File Offset: 0x0009A1D8
		private void OnDisable()
		{
			bool flag = this.isHover;
			if (flag)
			{
				this.tooltip.Hide();
			}
			this.isHover = false;
			base.StopAllCoroutines();
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0009C00C File Offset: 0x0009A20C
		public void OnDestroy()
		{
			bool flag = this.isHover;
			if (flag)
			{
				this.tooltip.Hide();
			}
			base.StopAllCoroutines();
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0009C03C File Offset: 0x0009A23C
		public void SetLocalizedText(Func<string> localiedTitle, Func<string> localizedContent, List<string> keywords)
		{
			bool flag = this == null;
			if (!flag)
			{
				this.SetText(localiedTitle(), localizedContent(), keywords, null, null, null);
				Singleton<EventCenter>.Instance.RemoveEventListener(LanguageEvent.LanguageChange.ToString(), this.tooltip);
				Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), delegate()
				{
					bool flag2 = this == null;
					if (!flag2)
					{
						this.SetText(localiedTitle(), localizedContent(), keywords, null, null, null);
					}
				}, this, EventDispose.None);
			}
		}

		// Token: 0x04001027 RID: 4135
		public List<string> keyWords = new List<string>();

		// Token: 0x04001028 RID: 4136
		public string text;

		// Token: 0x04001029 RID: 4137
		public string title;

		// Token: 0x0400102A RID: 4138
		public string msg;

		// Token: 0x0400102B RID: 4139
		public Sprite icon = null;

		// Token: 0x0400102C RID: 4140
		public string type;

		// Token: 0x0400102D RID: 4141
		public bool isHover = false;
	}
}

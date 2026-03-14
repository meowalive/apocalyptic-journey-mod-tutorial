using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Witch
{
	// Token: 0x02000257 RID: 599
	public class StoryDetailPanel : MonoBehaviour
	{
		// Token: 0x0600133A RID: 4922 RVA: 0x00097084 File Offset: 0x00095284
		private void Awake()
		{
			bool flag = this.closeButton != null;
			if (flag)
			{
				this.closeButton.onClick.AddListener(new UnityAction(this.Hide));
			}
			bool flag2 = this.applyButton != null;
			if (flag2)
			{
				this.applyButton.onClick.AddListener(new UnityAction(this.Apply));
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000970EC File Offset: 0x000952EC
		public void Show(StoryLine line)
		{
			this.current = line;
			bool flag = this.panelRoot != null;
			if (flag)
			{
				this.panelRoot.SetActive(true);
			}
			bool flag2 = this.current != null;
			if (flag2)
			{
				bool flag3 = this.actorField != null;
				if (flag3)
				{
					this.actorField.text = this.current.actor;
				}
				bool flag4 = this.textField != null;
				if (flag4)
				{
					this.textField.text = this.current.text;
				}
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0009717C File Offset: 0x0009537C
		public void Hide()
		{
			bool flag = this.panelRoot != null;
			if (flag)
			{
				this.panelRoot.SetActive(false);
			}
			this.current = null;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000971B0 File Offset: 0x000953B0
		private void Apply()
		{
			bool flag = this.current == null;
			if (!flag)
			{
				bool flag2 = this.actorField != null;
				if (flag2)
				{
					this.current.actor = this.actorField.text;
				}
				bool flag3 = this.textField != null;
				if (flag3)
				{
					this.current.text = this.textField.text;
				}
				this.Hide();
			}
		}

		// Token: 0x04000F95 RID: 3989
		public GameObject panelRoot;

		// Token: 0x04000F96 RID: 3990
		public InputField actorField;

		// Token: 0x04000F97 RID: 3991
		public InputField textField;

		// Token: 0x04000F98 RID: 3992
		public InputField backgroundField;

		// Token: 0x04000F99 RID: 3993
		public InputField sfxField;

		// Token: 0x04000F9A RID: 3994
		public Button closeButton;

		// Token: 0x04000F9B RID: 3995
		public Button applyButton;

		// Token: 0x04000F9C RID: 3996
		private StoryLine current;
	}
}

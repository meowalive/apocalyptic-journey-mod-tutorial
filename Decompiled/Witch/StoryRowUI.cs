using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Witch
{
	// Token: 0x0200025B RID: 603
	public class StoryRowUI : MonoBehaviour
	{
		// Token: 0x06001359 RID: 4953 RVA: 0x00098020 File Offset: 0x00096220
		public void Initialize(StoryLine line, StoryEditorManager mgr)
		{
			this.boundLine = line;
			this.manager = mgr;
			this.Refresh();
			bool flag = this.actorField != null;
			if (flag)
			{
				this.actorField.onEndEdit.AddListener(new UnityAction<string>(this.OnActorEdited));
			}
			bool flag2 = this.textField != null;
			if (flag2)
			{
				this.textField.onEndEdit.AddListener(new UnityAction<string>(this.OnTextEdited));
			}
			bool flag3 = this.upButton != null;
			if (flag3)
			{
				this.upButton.onClick.AddListener(new UnityAction(this.OnMoveUp));
			}
			bool flag4 = this.downButton != null;
			if (flag4)
			{
				this.downButton.onClick.AddListener(new UnityAction(this.OnMoveDown));
			}
			bool flag5 = this.deleteButton != null;
			if (flag5)
			{
				this.deleteButton.onClick.AddListener(new UnityAction(this.OnDelete));
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00098128 File Offset: 0x00096328
		private void Refresh()
		{
			bool flag = this.boundLine == null;
			if (!flag)
			{
				bool flag2 = this.indexText != null;
				if (flag2)
				{
					this.indexText.text = this.boundLine.id.ToString();
				}
				bool flag3 = this.actorField != null;
				if (flag3)
				{
					this.actorField.text = this.boundLine.actor;
				}
				bool flag4 = this.textField != null;
				if (flag4)
				{
					this.textField.text = this.boundLine.text;
				}
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000026D9 File Offset: 0x000008D9
		private void Update()
		{
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000981C0 File Offset: 0x000963C0
		private void OnActorEdited(string v)
		{
			bool flag = this.boundLine != null;
			if (flag)
			{
				this.boundLine.actor = v;
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000981E8 File Offset: 0x000963E8
		private void OnTextEdited(string v)
		{
			bool flag = this.boundLine != null;
			if (flag)
			{
				this.boundLine.text = v;
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00098210 File Offset: 0x00096410
		private void OnMoveUp()
		{
			bool flag = this.manager != null;
			if (flag)
			{
				this.manager.MoveLineUp(this.boundLine);
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00098240 File Offset: 0x00096440
		private void OnMoveDown()
		{
			bool flag = this.manager != null;
			if (flag)
			{
				this.manager.MoveLineDown(this.boundLine);
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00098270 File Offset: 0x00096470
		private void OnDelete()
		{
			bool flag = this.manager != null;
			if (flag)
			{
				this.manager.RemoveLine(this.boundLine);
			}
		}

		// Token: 0x04000FB0 RID: 4016
		public TMP_Text indexText;

		// Token: 0x04000FB1 RID: 4017
		public TMP_InputField actorField;

		// Token: 0x04000FB2 RID: 4018
		public TMP_InputField textField;

		// Token: 0x04000FB3 RID: 4019
		public Button upButton;

		// Token: 0x04000FB4 RID: 4020
		public Button downButton;

		// Token: 0x04000FB5 RID: 4021
		public Button deleteButton;

		// Token: 0x04000FB6 RID: 4022
		public Toggle enableToggle;

		// Token: 0x04000FB7 RID: 4023
		public StoryEditorUI storyEditorUI;

		// Token: 0x04000FB8 RID: 4024
		private StoryLine boundLine;

		// Token: 0x04000FB9 RID: 4025
		private StoryEditorManager manager;
	}
}

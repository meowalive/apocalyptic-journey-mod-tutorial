using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Witch
{
	// Token: 0x02000255 RID: 597
	public class ImageSelectorWindow : MonoBehaviour
	{
		// Token: 0x06001331 RID: 4913 RVA: 0x00096E68 File Offset: 0x00095068
		private void Awake()
		{
			ImageSelectorWindow.instance = this;
			bool flag = this.closeButton != null;
			if (flag)
			{
				this.closeButton.onClick.AddListener(new UnityAction(this.Hide));
			}
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00096EAC File Offset: 0x000950AC
		private void OnDestroy()
		{
			bool flag = ImageSelectorWindow.instance == this;
			if (flag)
			{
				ImageSelectorWindow.instance = null;
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00096ED0 File Offset: 0x000950D0
		public static void Show(Action<Sprite, string> callback)
		{
			bool flag = ImageSelectorWindow.instance == null;
			if (flag)
			{
				Debug.LogError("ImageSelectorWindow instance not found in scene. Create one and assign prefab/grid.");
			}
			else
			{
				ImageSelectorWindow.instance.onSelect = callback;
				ImageSelectorWindow.instance.gameObject.SetActive(true);
				ImageSelectorWindow.instance.Populate();
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00044F44 File Offset: 0x00043144
		public void Hide()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00096F24 File Offset: 0x00095124
		private void Populate()
		{
			bool flag = this.gridParent == null || this.prefabItem == null;
			if (!flag)
			{
				for (int i = this.gridParent.childCount - 1; i >= 0; i--)
				{
					UnityEngine.Object.Destroy(this.gridParent.GetChild(i).gameObject);
				}
				Sprite[] sprites = ResourceLoader.LoadAll<Sprite>("Images/StoryChara");
				foreach (Sprite s in sprites)
				{
					GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.prefabItem, this.gridParent);
					Image img = go.GetComponentInChildren<Image>();
					Button btn = go.GetComponentInChildren<Button>();
					bool flag2 = img != null;
					if (flag2)
					{
						img.sprite = s;
					}
					bool flag3 = btn != null;
					if (flag3)
					{
						Sprite localS = s;
						btn.onClick.AddListener(delegate
						{
							this.OnItemClicked(localS);
						});
					}
				}
			}
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00097040 File Offset: 0x00095240
		private void OnItemClicked(Sprite s)
		{
			string path = "";
			Action<Sprite, string> action = this.onSelect;
			if (action != null)
			{
				action(s, path);
			}
			this.Hide();
		}

		// Token: 0x04000F8E RID: 3982
		public GameObject prefabItem;

		// Token: 0x04000F8F RID: 3983
		public Transform gridParent;

		// Token: 0x04000F90 RID: 3984
		public Button closeButton;

		// Token: 0x04000F91 RID: 3985
		private static ImageSelectorWindow instance;

		// Token: 0x04000F92 RID: 3986
		private Action<Sprite, string> onSelect;
	}
}

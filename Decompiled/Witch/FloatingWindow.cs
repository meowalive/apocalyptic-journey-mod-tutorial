using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200010E RID: 270
public class FloatingWindow : MonoBehaviour
{
	// Token: 0x060008B0 RID: 2224 RVA: 0x00044C10 File Offset: 0x00042E10
	public void Show(Transform obj)
	{
		bool flag = obj == null;
		if (!flag)
		{
			this.showItem = obj;
			this.Show(obj.transform.position);
		}
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x00044C44 File Offset: 0x00042E44
	public void Show(Vector3 pos)
	{
		base.gameObject.SetActive(false);
		this.ResetWindow();
		bool flag = this.buttons.Count == 0;
		if (!flag)
		{
			this.CreateButton(this.buttons, base.transform.Find("content"));
			base.gameObject.SetActive(true);
			base.transform.DOKill(false);
			base.transform.localScale = Vector3.zero;
			base.transform.DOScale(Vector3.one, 0.2f).SetEase(Ease.OutBack).SetDelay(0.05f);
			base.transform.position = pos;
			base.transform.SetAsLastSibling();
			UniTask.DelayFrame(1, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				this.EnableLayoutGroup(base.transform.Find("content"));
			}).Forget();
		}
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x00044D2C File Offset: 0x00042F2C
	private void CreateButton(List<FloatingWindow.button> buttons, Transform content)
	{
		content.GetComponent<VerticalLayoutGroup>().enabled = false;
		foreach (FloatingWindow.button button in buttons)
		{
			Transform go = UnityEngine.Object.Instantiate<Transform>(base.transform.Find("content/Item"), content);
			go.Find("SubItem").gameObject.SetActive(false);
			go.gameObject.SetActive(true);
			go.GetComponent<ButtonManager>().buttonText = button.name;
			go.GetComponent<ButtonManager>().onClick.AddListener(button.action);
			bool flag = button.subButtons.Count > 0;
			if (flag)
			{
				go.GetComponent<ButtonManager>().onClick.AddListener(delegate
				{
					bool activeSelf = go.Find("SubItem").gameObject.activeSelf;
					if (activeSelf)
					{
						go.Find("SubItem").gameObject.SetActive(false);
						this.subitemContent = null;
					}
					else
					{
						go.Find("SubItem").gameObject.SetActive(true);
						bool flag2 = this.subitemContent != null;
						if (flag2)
						{
							this.subitemContent.gameObject.SetActive(false);
						}
						this.subitemContent = go.Find("SubItem");
					}
				});
				this.CreateButton(button.subButtons, go.Find("SubItem"));
			}
			else
			{
				go.GetComponent<ButtonManager>().onClick.AddListener(new UnityAction(this.Hide));
			}
			go.GetComponent<ButtonManager>().UpdateUI();
		}
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x00044EAC File Offset: 0x000430AC
	private void EnableLayoutGroup(Transform content)
	{
		VerticalLayoutGroup layoutGroup = content.GetComponent<VerticalLayoutGroup>();
		bool flag = layoutGroup != null;
		if (flag)
		{
			layoutGroup.enabled = true;
		}
		foreach (object obj in content)
		{
			Transform child = (Transform)obj;
			Transform contentChild = child.Find("SubItem");
			bool flag2 = contentChild != null;
			if (flag2)
			{
				this.EnableLayoutGroup(contentChild);
			}
		}
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x00044F44 File Offset: 0x00043144
	public void Hide()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00044F54 File Offset: 0x00043154
	public FloatingWindow AddButton(string basename, UnityAction action, List<FloatingWindow.button> subItems = null)
	{
		this.buttons.Add(new FloatingWindow.button
		{
			name = basename.Localize("Button"),
			action = action,
			subButtons = (subItems ?? new List<FloatingWindow.button>())
		});
		return this;
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00044FA0 File Offset: 0x000431A0
	public void AddButton(FloatingWindow.button button1)
	{
		this.buttons.Add(button1);
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00044FB0 File Offset: 0x000431B0
	private void OnDisable()
	{
		this.ResetWindow();
		this.Clear();
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00044FC4 File Offset: 0x000431C4
	public FloatingWindow Clear()
	{
		this.buttons.Clear();
		return this;
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00044FE4 File Offset: 0x000431E4
	public FloatingWindow ResetWindow()
	{
		foreach (object obj in base.transform.Find("content"))
		{
			Transform item = (Transform)obj;
			bool flag = item.name == "Item";
			if (!flag)
			{
				UnityEngine.Object.Destroy(item.gameObject);
			}
		}
		return this;
	}

	// Token: 0x04000BED RID: 3053
	public List<FloatingWindow.button> buttons = new List<FloatingWindow.button>();

	// Token: 0x04000BEE RID: 3054
	public Transform showItem;

	// Token: 0x04000BEF RID: 3055
	public Transform subitemContent;

	// Token: 0x0200010F RID: 271
	public class button
	{
		// Token: 0x04000BF0 RID: 3056
		public string name;

		// Token: 0x04000BF1 RID: 3057
		public UnityAction action;

		// Token: 0x04000BF2 RID: 3058
		public List<FloatingWindow.button> subButtons = new List<FloatingWindow.button>();
	}
}

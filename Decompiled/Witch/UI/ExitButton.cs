using System;
using Michsky.MUIP;
using UnityEngine;
using UnityEngine.Events;

namespace Witch.UI
{
	// Token: 0x02000272 RID: 626
	public class ExitButton : MonoBehaviour
	{
		// Token: 0x060013E7 RID: 5095 RVA: 0x0009BD5A File Offset: 0x00099F5A
		private void Awake()
		{
			this.parent = base.GetComponentInParent<UIBase>();
			this.buttonManager = base.GetComponent<ButtonManager>();
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0009BD78 File Offset: 0x00099F78
		private void OnEnable()
		{
			bool flag = this == null || this.parent == null;
			if (!flag)
			{
				UIManager.Instance.RegisterExitButton(this);
			}
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0009BDB0 File Offset: 0x00099FB0
		private void OnDisable()
		{
			bool flag = this == null;
			if (!flag)
			{
				UIManager.Instance.UnregisterExitButton(this);
			}
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0009BDD7 File Offset: 0x00099FD7
		private void OnClick()
		{
			ButtonManager buttonManager = this.buttonManager;
			if (buttonManager != null)
			{
				UnityEvent onClick = buttonManager.onClick;
				if (onClick != null)
				{
					onClick.Invoke();
				}
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0009BDF8 File Offset: 0x00099FF8
		public bool OnCancelKey()
		{
			bool flag = this.IsNull("Object");
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = this.parent == null;
				if (flag2)
				{
					UIManager.Instance.UnregisterExitButton(this);
					result = false;
				}
				else
				{
					bool clickable = UIUtil.CheckClickable(base.transform);
					bool flag3 = clickable;
					if (flag3)
					{
						this.OnClick();
					}
					result = clickable;
				}
			}
			return result;
		}

		// Token: 0x04001025 RID: 4133
		private UIBase parent;

		// Token: 0x04001026 RID: 4134
		private ButtonManager buttonManager;
	}
}

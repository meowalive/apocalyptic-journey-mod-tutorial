using System;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI
{
	// Token: 0x0200027E RID: 638
	public class UpperCanvasController : MonoBehaviour
	{
		// Token: 0x06001447 RID: 5191 RVA: 0x0009F0F4 File Offset: 0x0009D2F4
		private void TryTurnOn()
		{
			bool flag;
			if (base.transform.childCount != 0)
			{
				flag = base.transform.GetComponentsInChildren<UpperCanvasController.ChildMonitor>().All((UpperCanvasController.ChildMonitor x) => !x.gameObject.activeSelf || x == null);
			}
			else
			{
				flag = true;
			}
			bool flag2 = flag;
			if (flag2)
			{
				this.ChangeRaycaster(true);
			}
			else
			{
				this.ChangeRaycaster(false);
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0009F15C File Offset: 0x0009D35C
		private void ChangeRaycaster(bool isOn)
		{
			bool flag = UIManager.Instance == null;
			if (!flag)
			{
				UIManager.Instance.canvasTf.GetComponent<GraphicRaycaster>().enabled = isOn;
				bool flag2 = Camera.main == null;
				if (!flag2)
				{
					Camera.main.GetComponent<PhysicsRaycaster>().enabled = isOn;
					Camera.main.GetComponent<Physics2DRaycaster>().enabled = isOn;
				}
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0009F1C4 File Offset: 0x0009D3C4
		private void OnTransformChildrenChanged()
		{
			foreach (object obj in base.transform)
			{
				Transform child = (Transform)obj;
				bool flag = child.GetComponent<UpperCanvasController.ChildMonitor>() != null;
				if (!flag)
				{
					child.gameObject.AddComponent<UpperCanvasController.ChildMonitor>().Init(this);
				}
			}
		}

		// Token: 0x0200027F RID: 639
		private class ChildMonitor : MonoBehaviour
		{
			// Token: 0x0600144B RID: 5195 RVA: 0x0009F240 File Offset: 0x0009D440
			public void Init(UpperCanvasController controller)
			{
				this.controller = controller;
				if (controller != null)
				{
					controller.ChangeRaycaster(false);
				}
			}

			// Token: 0x0600144C RID: 5196 RVA: 0x0009F257 File Offset: 0x0009D457
			private void OnEnable()
			{
				UpperCanvasController upperCanvasController = this.controller;
				if (upperCanvasController != null)
				{
					upperCanvasController.ChangeRaycaster(false);
				}
			}

			// Token: 0x0600144D RID: 5197 RVA: 0x0009F26D File Offset: 0x0009D46D
			private void OnDisable()
			{
				UpperCanvasController upperCanvasController = this.controller;
				if (upperCanvasController != null)
				{
					upperCanvasController.TryTurnOn();
				}
			}

			// Token: 0x0600144E RID: 5198 RVA: 0x0009F26D File Offset: 0x0009D46D
			private void OnDestroy()
			{
				UpperCanvasController upperCanvasController = this.controller;
				if (upperCanvasController != null)
				{
					upperCanvasController.TryTurnOn();
				}
			}

			// Token: 0x04001062 RID: 4194
			private UpperCanvasController controller;
		}
	}
}

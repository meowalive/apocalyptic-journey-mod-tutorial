using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x020002AF RID: 687
	public class ChangeFloatWindow : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06001591 RID: 5521 RVA: 0x000AC780 File Offset: 0x000AA980
		public void OnPointerClick(PointerEventData eventData)
		{
			bool flag = eventData.button == PointerEventData.InputButton.Right;
			if (flag)
			{
				eventData.Use();
				UIManager.Instance.GetUI<CardEditorUI>("CardEditorUI").InitTimeAgain();
				UIManager.Instance.GetFloatingWindow().Show(Camera.main.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, 95f)));
			}
			else
			{
				bool flag2 = eventData.button == PointerEventData.InputButton.Left;
				if (flag2)
				{
					List<RaycastResult> results = new List<RaycastResult>();
					EventSystem.current.RaycastAll(eventData, results);
					bool hitFloatingWindow = false;
					foreach (RaycastResult result in results)
					{
						bool flag3 = result.gameObject.name == "Floating Window";
						if (flag3)
						{
							hitFloatingWindow = true;
							break;
						}
					}
					bool flag4 = !hitFloatingWindow;
					if (flag4)
					{
						UIManager.Instance.GetFloatingWindow().Hide();
					}
				}
			}
		}
	}
}

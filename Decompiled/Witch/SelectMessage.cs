using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000111 RID: 273
public class SelectMessage : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	// Token: 0x060008BF RID: 2239 RVA: 0x000026D9 File Offset: 0x000008D9
	private void Start()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00045174 File Offset: 0x00043374
	public void OnPointerEnter(PointerEventData eventData)
	{
		bool flag = string.IsNullOrEmpty(this.msg);
		if (!flag)
		{
			this.tempObj = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load<GameObject>("UI/SelectedMessage", true), base.transform);
			this.tempObj.transform.Find("text").GetComponent<TMP_Text>().text = this.msg.Localize("Tips");
			bool flag2 = base.transform.GetComponent<SpriteRenderer>() != null;
			if (flag2)
			{
				this.tempObj.GetComponent<RectTransform>().localScale = new Vector3(0.01f, 0.01f, 1f);
				Vector2 tempVec = new Vector2(1f, 1.2f);
				bool flag3 = base.transform.position.x > 20f;
				if (flag3)
				{
					tempVec.x = -1f;
				}
				else
				{
					tempVec.x = 1f;
				}
				bool flag4 = base.transform.position.y > 400f;
				if (flag4)
				{
					tempVec.y = -1.2f;
				}
				else
				{
					tempVec.y = 1.2f;
				}
				this.tempObj.GetComponent<RectTransform>().anchoredPosition = tempVec;
			}
			else
			{
				Vector2 tempVec2 = new Vector2(1f, 1.2f);
				bool flag5 = base.transform.position.x > -20f;
				if (flag5)
				{
					tempVec2.x = -100f;
				}
				else
				{
					tempVec2.x = 100f;
				}
				bool flag6 = base.transform.position.y > 80f;
				if (flag6)
				{
					tempVec2.y = -120f;
				}
				else
				{
					tempVec2.y = 120f;
				}
				this.tempObj.GetComponent<RectTransform>().anchoredPosition = tempVec2;
			}
		}
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x0004535C File Offset: 0x0004355C
	public void OnPointerExit(PointerEventData eventData)
	{
		bool flag = this.tempObj != null;
		if (flag)
		{
			UnityEngine.Object.Destroy(this.tempObj);
		}
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00045388 File Offset: 0x00043588
	public void OnPointerClick(PointerEventData eventData)
	{
		Action clickAction = this.ClickAction;
		if (clickAction != null)
		{
			clickAction();
		}
	}

	// Token: 0x04000BF5 RID: 3061
	public string msg;

	// Token: 0x04000BF6 RID: 3062
	private GameObject tempObj;

	// Token: 0x04000BF7 RID: 3063
	public Action ClickAction;
}

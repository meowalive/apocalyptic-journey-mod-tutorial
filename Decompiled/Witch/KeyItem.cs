using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch
{
	// Token: 0x02000247 RID: 583
	public class KeyItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x060012CE RID: 4814 RVA: 0x000938C8 File Offset: 0x00091AC8
		public void OnPointerEnter(PointerEventData eventData)
		{
			bool flag = this.tempObj == null;
			if (flag)
			{
				this.tempObj = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load<GameObject>("UI/SelectedMessage", true), base.transform);
				this.tempObj.transform.Find("text").GetComponent<TMP_Text>().text = (this.msg + "Msg").Localize("Tips");
				bool flag2 = this.islow;
				if (flag2)
				{
					this.tempObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -100f);
				}
				else
				{
					this.tempObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 100f);
				}
				bool flag3 = base.transform.GetComponent<SpriteRenderer>() != null;
				if (flag3)
				{
					this.tempObj.GetComponent<RectTransform>().localScale = new Vector3(0.01f, 0.01f, 1f);
					this.tempObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 1f);
				}
			}
			else
			{
				this.tempObj.SetActive(true);
				this.tempObj.transform.Find("text").GetComponent<TMP_Text>().text = (this.msg + "Msg").Localize("Tips");
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00093A38 File Offset: 0x00091C38
		public void OnPointerExit(PointerEventData eventData)
		{
			bool flag = this.tempObj != null;
			if (flag)
			{
				this.tempObj.SetActive(false);
			}
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00093A68 File Offset: 0x00091C68
		private void OnDestroy()
		{
			bool flag = this.tempObj != null;
			if (flag)
			{
				UnityEngine.Object.Destroy(this.tempObj);
			}
		}

		// Token: 0x04000F63 RID: 3939
		private GameObject tempObj;

		// Token: 0x04000F64 RID: 3940
		public string msg;

		// Token: 0x04000F65 RID: 3941
		public bool islow = true;
	}
}

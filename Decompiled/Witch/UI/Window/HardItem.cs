using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Witch.UI.Component;

namespace Witch.UI.Window
{
	// Token: 0x0200035E RID: 862
	public class HardItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x06001B1B RID: 6939 RVA: 0x000E7904 File Offset: 0x000E5B04
		public void Init(Dictionary<string, string> hardData)
		{
			this.Data = hardData;
			this.ChangeShow();
			base.gameObject.name = hardData.Localize("Name");
			base.transform.Find("Left/Name").GetComponent<TMP_Text>().text = hardData.Localize("Name");
			base.transform.Find("Left/Level").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/UI_Icons/Native/难度选择/新ui/难度词条散件/" + hardData["Level"] + "格", true);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x000E7998 File Offset: 0x000E5B98
		public void AddSc()
		{
			this.selectHardUI.AddSc(this);
			this.ChangeShow();
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000E79AF File Offset: 0x000E5BAF
		public void RemoveSc()
		{
			this.selectHardUI.DeleteSc(this);
			this.ChangeShow();
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000E79C8 File Offset: 0x000E5BC8
		public void ChangeShow()
		{
			bool flag = this.Data == null;
			if (!flag)
			{
				int count = 0;
				int index = SelectHardUI.UseSc.FindIndex((HardTagEntry x) => x.Data["Id"] == this.Data["Id"]);
				bool flag2 = index != -1;
				if (flag2)
				{
					count = SelectHardUI.UseSc[index].DynamicValue;
				}
				bool flag3 = count == 0;
				if (flag3)
				{
					base.transform.Find("Left").GetComponent<Image>().color = new Color32(181, 175, 175, byte.MaxValue);
					base.transform.Find("Left/Icon").GetComponent<Image>().color = new Color32(181, 175, 175, byte.MaxValue);
					base.transform.Find("Left/Name").GetComponent<TMP_Text>().color = new Color32(181, 175, 175, byte.MaxValue);
					base.transform.Find("Left/SingleLevel").gameObject.SetActive(false);
					base.transform.Find("Left/Level").GetComponent<Image>().color = new Color32(181, 175, 175, byte.MaxValue);
					base.transform.Find("Left/Level/Has").GetComponent<Image>().color = new Color32(181, 175, 175, byte.MaxValue);
				}
				else
				{
					base.transform.Find("Left").GetComponent<Image>().color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
					base.transform.Find("Left/Icon").GetComponent<Image>().color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
					base.transform.Find("Left/Name").GetComponent<TMP_Text>().color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
					base.transform.Find("Left/SingleLevel").gameObject.SetActive(true);
					base.transform.Find("Left/SingleLevel").GetComponent<TMP_Text>().SetDigitText("+" + (count * int.Parse(this.Data["Level"])).ToString());
					base.transform.Find("Left/Level").GetComponent<Image>().color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
					base.transform.Find("Left/Level/Has").GetComponent<Image>().color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				}
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000E7CF0 File Offset: 0x000E5EF0
		public void OnPointerClick(PointerEventData eventData)
		{
			bool flag = eventData.button == PointerEventData.InputButton.Right;
			if (flag)
			{
				this.AddSc();
			}
			else
			{
				this.RemoveSc();
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000E7D1F File Offset: 0x000E5F1F
		public void OnPointerEnter(PointerEventData eventData)
		{
			this.selectHardUI.ChangeDesShow(this.Data);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000E7D34 File Offset: 0x000E5F34
		public void OnPointerExit(PointerEventData eventData)
		{
			this.selectHardUI.CloseDes();
		}

		// Token: 0x040014A1 RID: 5281
		public SelectHardUI selectHardUI;

		// Token: 0x040014A2 RID: 5282
		public Dictionary<string, string> Data;
	}
}

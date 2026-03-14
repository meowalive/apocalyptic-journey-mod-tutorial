using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch
{
	// Token: 0x0200025F RID: 607
	public class TypeItem : MonoBehaviour
	{
		// Token: 0x06001376 RID: 4982 RVA: 0x00099254 File Offset: 0x00097454
		public void OnPointerClick(PointerEventData eventData)
		{
			bool isOpen = this.IsOpen;
			if (isOpen)
			{
				base.transform.Find("TaskList").gameObject.SetActive(false);
			}
			else
			{
				base.transform.Find("TaskList").gameObject.SetActive(true);
			}
			this.IsOpen = !this.IsOpen;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000992BC File Offset: 0x000974BC
		private void OnEnable()
		{
			Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
			this.DataUpdate();
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000992F9 File Offset: 0x000974F9
		private void DataUpdate()
		{
			base.transform.Find("Title/Text").GetComponent<TMP_Text>().text = this.TypeName.Localize("TaskUI");
		}

		// Token: 0x04000FC2 RID: 4034
		public bool IsOpen = false;

		// Token: 0x04000FC3 RID: 4035
		public string TypeName;
	}
}

using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x0200031A RID: 794
	public class DictTagItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x060018B9 RID: 6329 RVA: 0x000D064A File Offset: 0x000CE84A
		public void Init(string name, DictionaryUI dictionaryUI)
		{
			this.tagName = name;
			this.dictionaryUI = dictionaryUI;
			this.DataUpdate();
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000D0662 File Offset: 0x000CE862
		private void OnEnable()
		{
			this.DataUpdate();
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000D066C File Offset: 0x000CE86C
		public void Init(DictionaryUI dictionaryUI)
		{
			this.dictionaryUI = dictionaryUI;
			this.DataUpdate();
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000D0680 File Offset: 0x000CE880
		public void OnPointerClick(PointerEventData eventData)
		{
			bool flag = this.isSelected;
			if (flag)
			{
				bool flag2 = this.TagType != "rarity";
				if (flag2)
				{
					this.dictionaryUI.ChooseTags[this.TagType].Remove(this.tagName.Localize("Glossary"));
				}
				else
				{
					this.dictionaryUI.ChooseTags[this.TagType].Remove((base.transform.GetSiblingIndex() + 1).ToString());
				}
			}
			else
			{
				bool flag3 = this.TagType != "rarity";
				if (flag3)
				{
					this.dictionaryUI.ChooseTags[this.TagType].Add(this.tagName.Localize("Glossary"));
				}
				else
				{
					this.dictionaryUI.ChooseTags[this.TagType].Add((base.transform.GetSiblingIndex() + 1).ToString());
				}
			}
			this.isSelected = !this.isSelected;
			this.dictionaryUI.Selected();
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x000D07A8 File Offset: 0x000CE9A8
		public void ReturnNormal()
		{
			bool flag = this.dictionaryUI == null;
			if (!flag)
			{
				this.isSelected = false;
				bool flag2 = this.TagType != "rarity";
				if (flag2)
				{
					this.dictionaryUI.ChooseTags[this.TagType].Remove(this.tagName.Localize("Glossary"));
				}
				else
				{
					this.dictionaryUI.ChooseTags[this.TagType].Remove((base.transform.GetSiblingIndex() + 1).ToString());
				}
				base.gameObject.GetComponent<SwitchButton>().isOn = false;
			}
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000D085C File Offset: 0x000CEA5C
		public virtual void RegisterEvent()
		{
			Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x000D0894 File Offset: 0x000CEA94
		public void DataUpdate()
		{
			base.transform.Find("Normal/Text").GetComponent<TMP_Text>().text = this.tagName.Localize("Glossary");
			base.transform.Find("Highlighted/Text").GetComponent<TMP_Text>().text = this.tagName.Localize("Glossary");
			base.transform.Find("Pressed/Text").GetComponent<TMP_Text>().text = this.tagName.Localize("Glossary");
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00004B9C File Offset: 0x00002D9C
		public virtual void ClearEvent()
		{
			Singleton<EventCenter>.Instance.Clear(this);
		}

		// Token: 0x04001350 RID: 4944
		private DictionaryUI dictionaryUI;

		// Token: 0x04001351 RID: 4945
		private bool isSelected = false;

		// Token: 0x04001352 RID: 4946
		public string TagType;

		// Token: 0x04001353 RID: 4947
		public string tagName;
	}
}

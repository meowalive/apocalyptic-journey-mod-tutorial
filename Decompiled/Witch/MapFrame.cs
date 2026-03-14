using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using Witch.UI;

// Token: 0x020000FD RID: 253
public class MapFrame : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x06000849 RID: 2121 RVA: 0x00041C60 File Offset: 0x0003FE60
	public void OnPointerEnter(PointerEventData eventData)
	{
		base.transform.Find("Highlight/Icon").GetComponent<SpriteRenderer>().DOFade(1f, 0.3f);
		base.transform.Find("Normal/Icon").GetComponent<SpriteRenderer>().DOFade(0f, 0.3f);
		Transform tempTransform = base.transform.parent.Find("Content").GetChild(base.transform.parent.Find("Content").childCount - 1);
		bool flag = tempTransform != null && tempTransform.name != "Null" && tempTransform.GetComponent<KeywordDisplay>() != null;
		if (flag)
		{
			tempTransform.GetComponent<KeywordDisplay>().OnPointerEnter(eventData);
		}
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00041D2C File Offset: 0x0003FF2C
	public void OnPointerExit(PointerEventData eventData)
	{
		base.transform.Find("Highlight/Icon").GetComponent<SpriteRenderer>().DOFade(0f, 0.3f);
		base.transform.Find("Normal/Icon").GetComponent<SpriteRenderer>().DOFade(1f, 0.3f);
		Transform tempTransform = base.transform.parent.Find("Content").GetChild(base.transform.parent.Find("Content").childCount - 1);
		bool flag = tempTransform != null && tempTransform.name != "Null" && tempTransform.GetComponent<KeywordDisplay>() != null;
		if (flag)
		{
			tempTransform.GetComponent<KeywordDisplay>().OnPointerExit(eventData);
		}
	}
}

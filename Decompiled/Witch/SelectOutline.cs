using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000112 RID: 274
public class SelectOutline : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	// Token: 0x060008C4 RID: 2244 RVA: 0x000453A0 File Offset: 0x000435A0
	private void Awake()
	{
		this.mat = UnityEngine.Object.Instantiate<Material>(ResourceLoader.Load<Material>("Material/Outline", true));
		bool flag = base.transform.GetComponent<SpriteRenderer>() != null;
		if (flag)
		{
			base.transform.GetComponent<SpriteRenderer>().material = this.mat;
		}
		else
		{
			bool flag2 = base.transform.GetComponent<Image>() != null;
			if (flag2)
			{
				base.transform.GetComponent<Image>().material = this.mat;
			}
		}
		this.mat.SetFloat("_OutlineAlpha", 0f);
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00045438 File Offset: 0x00043638
	public void OnPointerEnter(PointerEventData eventData)
	{
		this.mat.SetFloat("_OutlineAlpha", 1f);
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00045451 File Offset: 0x00043651
	public void OnPointerExit(PointerEventData eventData)
	{
		this.mat.SetFloat("_OutlineAlpha", 0f);
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00045451 File Offset: 0x00043651
	public void OnPointerClick(PointerEventData eventData)
	{
		this.mat.SetFloat("_OutlineAlpha", 0f);
	}

	// Token: 0x04000BF8 RID: 3064
	private Material mat;
}

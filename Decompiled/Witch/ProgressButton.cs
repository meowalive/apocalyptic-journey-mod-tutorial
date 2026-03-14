using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000E9 RID: 233
public class ProgressButton : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler
{
	// Token: 0x060007EA RID: 2026 RVA: 0x0003F398 File Offset: 0x0003D598
	public void Awake()
	{
		this.text = base.transform.Find("text").GetComponent<TMP_Text>();
		base.transform.Find("fill").GetComponent<Image>().fillAmount = 0f;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x0003F3D6 File Offset: 0x0003D5D6
	public void OnPointerDown(PointerEventData eventData)
	{
		this.isLongPress = true;
		UniTask.Create(delegate()
		{
			ProgressButton.<<OnPointerDown>b__8_0>d <<OnPointerDown>b__8_0>d = new ProgressButton.<<OnPointerDown>b__8_0>d();
			<<OnPointerDown>b__8_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnPointerDown>b__8_0>d.<>4__this = this;
			<<OnPointerDown>b__8_0>d.<>1__state = -1;
			<<OnPointerDown>b__8_0>d.<>t__builder.Start<ProgressButton.<<OnPointerDown>b__8_0>d>(ref <<OnPointerDown>b__8_0>d);
			return <<OnPointerDown>b__8_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0003F3F2 File Offset: 0x0003D5F2
	public void OnPointerUp(PointerEventData eventData)
	{
		this.pressTime = 0f;
		this.isLongPress = false;
	}

	// Token: 0x04000B5C RID: 2908
	public bool isLongPress = false;

	// Token: 0x04000B5D RID: 2909
	public Action OnPress;

	// Token: 0x04000B5E RID: 2910
	public float progress = 0f;

	// Token: 0x04000B5F RID: 2911
	public float pressTime = 0f;

	// Token: 0x04000B60 RID: 2912
	public float maxA = 8f;

	// Token: 0x04000B61 RID: 2913
	public float acc = 2f;

	// Token: 0x04000B62 RID: 2914
	public TMP_Text text;
}

using System;
using UnityEngine;
using UnityEngine.InputSystem;

// Token: 0x020000E6 RID: 230
public class UIParallax : MonoBehaviour
{
	// Token: 0x060007DF RID: 2015 RVA: 0x0003EDE8 File Offset: 0x0003CFE8
	private void Update()
	{
		Vector3 mousePosition = Mouse.current.position.ReadValue();
		Vector3 viewportPosition = Camera.main.ScreenToViewportPoint(mousePosition);
		for (int i = 0; i < this.uiElements.Length; i++)
		{
			Vector3 targetPosition = new Vector3(viewportPosition.x * this.parallaxSpeeds[i], viewportPosition.y * this.parallaxSpeeds[i], 0f);
			targetPosition.x = Mathf.Clamp(targetPosition.x, this.minPositions[i].x, this.maxPositions[i].x);
			targetPosition.y = Mathf.Clamp(targetPosition.y, this.minPositions[i].y, this.maxPositions[i].y);
			this.uiElements[i].anchoredPosition = Vector2.Lerp(this.uiElements[i].anchoredPosition, targetPosition, Time.deltaTime * 10f);
		}
	}

	// Token: 0x04000B54 RID: 2900
	public RectTransform[] uiElements;

	// Token: 0x04000B55 RID: 2901
	public float[] parallaxSpeeds;

	// Token: 0x04000B56 RID: 2902
	public Vector2[] minPositions;

	// Token: 0x04000B57 RID: 2903
	public Vector2[] maxPositions;
}

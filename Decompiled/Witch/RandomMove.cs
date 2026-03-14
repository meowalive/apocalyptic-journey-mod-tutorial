using System;
using System.Diagnostics;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000E2 RID: 226
public class RandomMove : MonoBehaviour
{
	// Token: 0x060007C7 RID: 1991 RVA: 0x0003E2C0 File Offset: 0x0003C4C0
	private void OnEnable()
	{
		base.transform.GetComponent<Image>().material = new Material(base.transform.GetComponent<Image>().material);
		base.transform.GetComponent<Image>().material.renderQueue = 2700;
		this.rt = base.gameObject.GetComponent<RectTransform>();
		this.prt = (this.rt.parent as RectTransform);
		float leftX;
		float rightX;
		this.ComputeEdgeAnchoredX(out leftX, out rightX);
		float range = Mathf.Abs(rightX - leftX);
		bool flag = range <= 0.0001f;
		if (!flag)
		{
			float p = Mathf.InverseLerp(leftX, rightX, this.rt.anchoredPosition.x);
			float freq = Mathf.Max(1E-06f, this.speed / range);
			float t0 = this.isLeft ? (2f - p) : p;
			this.startTime = Time.unscaledTime - t0 / freq;
			CancellationToken token = this.GetCancellationTokenOnDestroy();
			this.MoveLoop(token).Forget();
		}
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
	[DebuggerStepThrough]
	private UniTaskVoid MoveLoop(CancellationToken token)
	{
		RandomMove.<MoveLoop>d__7 <MoveLoop>d__ = new RandomMove.<MoveLoop>d__7();
		<MoveLoop>d__.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
		<MoveLoop>d__.<>4__this = this;
		<MoveLoop>d__.token = token;
		<MoveLoop>d__.<>1__state = -1;
		<MoveLoop>d__.<>t__builder.Start<RandomMove.<MoveLoop>d__7>(ref <MoveLoop>d__);
		return <MoveLoop>d__.<>t__builder.Task;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x0003E414 File Offset: 0x0003C614
	private void ComputeEdgeAnchoredX(out float leftX, out float rightX)
	{
		float pW = this.prt.rect.width;
		float pPivot = this.prt.pivot.x;
		float cW = this.rt.rect.width;
		float cPivot = this.rt.pivot.x;
		float parentLeft = -pPivot * pW;
		float parentRight = (1f - pPivot) * pW;
		float anchorX = this.rt.anchorMin.x;
		float anchorRef = Mathf.Lerp(parentLeft, parentRight, anchorX);
		float childPivotAtLeft = parentLeft + cPivot * cW;
		float childPivotAtRight = parentRight - (1f - cPivot) * cW;
		leftX = childPivotAtLeft - anchorRef;
		rightX = childPivotAtRight - anchorRef;
		bool flag = leftX > rightX;
		if (flag)
		{
			float num = rightX;
			float num2 = leftX;
			leftX = num;
			rightX = num2;
		}
	}

	// Token: 0x04000B32 RID: 2866
	[SerializeField]
	private float speed = 20f;

	// Token: 0x04000B33 RID: 2867
	[SerializeField]
	private bool isLeft = true;

	// Token: 0x04000B34 RID: 2868
	private RectTransform rt;

	// Token: 0x04000B35 RID: 2869
	private RectTransform prt;

	// Token: 0x04000B36 RID: 2870
	private float startTime;

	// Token: 0x04000B37 RID: 2871
	private float lastX;
}

using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Token: 0x0200010D RID: 269
public class FightLine : MonoBehaviour
{
	/// <summary>
	/// 设置起始位置
	/// </summary>
	/// <param name="localPos">UI物体的世界坐标</param>
	// Token: 0x060008A6 RID: 2214 RVA: 0x00044806 File Offset: 0x00042A06
	public void SetStartPos(Vector3 localPos)
	{
		base.transform.GetChild(0).GetComponent<RectTransform>().localPosition = new Vector3(localPos.x, localPos.y, 0f);
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x00044838 File Offset: 0x00042A38
	public void OnEnable()
	{
		bool flag = !this.show;
		if (flag)
		{
			base.gameObject.SetActive(false);
		}
		else
		{
			for (int i = 0; i < base.transform.childCount; i++)
			{
				Transform child = base.transform.GetChild(i);
				child.DOKill(false);
				child.localScale = Vector3.zero;
				child.DOScale(Vector3.one * 100f, 0.1f).SetDelay(0f);
			}
		}
	}

	/// <summary>
	/// 设置结束位置
	/// </summary>
	/// <param name="uiObject">UI物体</param>
	// Token: 0x060008A8 RID: 2216 RVA: 0x000448C5 File Offset: 0x00042AC5
	public void Combine(Transform uiObject)
	{
		this.combineObject = uiObject;
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x000448D0 File Offset: 0x00042AD0
	private void Update()
	{
		bool flag = this.combineObject == null;
		if (!flag)
		{
			this.SetEndPos(this.combineObject.position);
		}
	}

	/// <summary>
	/// 设置结束位置
	/// </summary>
	/// <param name="uiWorldPos">UI物体的transform.position</param>
	// Token: 0x060008AA RID: 2218 RVA: 0x00044904 File Offset: 0x00042B04
	public void SetEndPos(Vector3 uiWorldPos)
	{
		bool flag = base.transform.childCount == 0;
		if (!flag)
		{
			Vector2 localEndPoint = this.UIWorldToCanvasLocal(uiWorldPos);
			Vector3 startPos = base.transform.GetChild(0).GetComponent<RectTransform>().localPosition;
			Vector3 targetPos = new Vector3(localEndPoint.x, localEndPoint.y, startPos.z);
			Vector3 controlPoint = this.CalculateControlPoint(startPos, targetPos);
			int lastIndex = base.transform.childCount - 1;
			Vector3 endTangent = this.GetBezierTangent(startPos, controlPoint, targetPos, 1f).normalized;
			Vector3 arrowPos = targetPos - endTangent * (this.arrowLength * 0.5f);
			for (int i = 1; i < lastIndex; i++)
			{
				float t = (float)i / (float)lastIndex;
				Vector3 bezierPos = this.GetBezier(startPos, controlPoint, arrowPos, t);
				base.transform.GetChild(i).GetComponent<RectTransform>().localPosition = bezierPos;
				Vector3 tangent = this.GetBezierTangent(startPos, controlPoint, arrowPos, t);
				float nodeAngle = Mathf.Atan2(tangent.y, tangent.x) * 57.29578f;
				base.transform.GetChild(i).eulerAngles = new Vector3(0f, 0f, nodeAngle - 90f);
			}
			base.transform.GetChild(lastIndex).GetComponent<RectTransform>().localPosition = arrowPos;
			float endAngle = Mathf.Atan2(endTangent.y, endTangent.x) * 57.29578f;
			base.transform.GetChild(lastIndex).eulerAngles = new Vector3(0f, 0f, endAngle - 90f);
		}
	}

	/// <summary>
	/// UI物体世界坐标转Canvas局部坐标
	/// </summary>
	/// <param name="uiWorldPos">UI物体的世界坐标</param>
	/// <returns>Canvas局部坐标</returns>
	// Token: 0x060008AB RID: 2219 RVA: 0x00044AB4 File Offset: 0x00042CB4
	private Vector2 UIWorldToCanvasLocal(Vector3 uiWorldPos)
	{
		return base.transform.InverseTransformPoint(uiWorldPos);
	}

	/// <summary>
	/// 计算控制点
	/// </summary>
	/// <param name="start">起始点</param>
	/// <param name="end">结束点</param>
	/// <returns>控制点坐标</returns>
	// Token: 0x060008AC RID: 2220 RVA: 0x00044ADC File Offset: 0x00042CDC
	private Vector3 CalculateControlPoint(Vector3 start, Vector3 end)
	{
		Vector3 midPoint = (start + end) * 0.5f;
		Vector3 direction = (end - start).normalized;
		Vector3 perpendicular = new Vector3(-direction.y, direction.x, 0f);
		float distance = Vector3.Distance(start, end);
		return midPoint + perpendicular * distance * this.curvature;
	}

	/// <summary>
	/// 二次贝塞尔曲线计算
	/// </summary>
	/// <param name="start">起始点</param>
	/// <param name="control">控制点</param>
	/// <param name="end">结束点</param>
	/// <param name="t">参数t (0-1)</param>
	/// <returns>曲线上的点</returns>
	// Token: 0x060008AD RID: 2221 RVA: 0x00044B4C File Offset: 0x00042D4C
	public Vector3 GetBezier(Vector3 start, Vector3 control, Vector3 end, float t)
	{
		return (1f - t) * (1f - t) * start + 2f * t * (1f - t) * control + t * t * end;
	}

	/// <summary>
	/// 计算贝塞尔曲线在指定点的切线方向
	/// </summary>
	/// <param name="start">起始点</param>
	/// <param name="control">控制点</param>
	/// <param name="end">结束点</param>
	/// <param name="t">参数t (0-1)</param>
	/// <returns>切线方向向量</returns>
	// Token: 0x060008AE RID: 2222 RVA: 0x00044BA4 File Offset: 0x00042DA4
	private Vector3 GetBezierTangent(Vector3 start, Vector3 control, Vector3 end, float t)
	{
		return 2f * (1f - t) * (control - start) + 2f * t * (end - control);
	}

	// Token: 0x04000BE9 RID: 3049
	[Header("曲线参数")]
	[Range(-2f, 2f)]
	public float curvature = 0.5f;

	// Token: 0x04000BEA RID: 3050
	[Header("箭头参数")]
	public float arrowLength = 100f;

	// Token: 0x04000BEB RID: 3051
	public bool show = true;

	// Token: 0x04000BEC RID: 3052
	private Transform combineObject;
}

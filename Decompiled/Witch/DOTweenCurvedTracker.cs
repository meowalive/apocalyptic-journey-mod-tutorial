using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Token: 0x02000026 RID: 38
[ExecuteInEditMode]
public class DOTweenCurvedTracker : MonoBehaviour
{
	// Token: 0x060000E7 RID: 231 RVA: 0x0000843C File Offset: 0x0000663C
	public DOTweenCurvedTracker Play()
	{
		this.originalPosition = base.transform.position;
		bool isPlaying = Application.isPlaying;
		if (isPlaying)
		{
			this.StartCurvedMovement();
		}
		return this;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00008474 File Offset: 0x00006674
	private void Update()
	{
		bool flag = !Application.isPlaying;
		if (flag)
		{
			bool flag2 = Time.realtimeSinceStartup - this.lastEditorUpdateTime < 0.1f;
			if (!flag2)
			{
				this.lastEditorUpdateTime = Time.realtimeSinceStartup;
				this.GenerateSpiralPath();
			}
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x000084BC File Offset: 0x000066BC
	public DOTweenCurvedTracker OnCompletePathGeneration(Action callback)
	{
		this.onPathGenerated = callback;
		return this;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x000084D8 File Offset: 0x000066D8
	public void StartCurvedMovement()
	{
		this.StopMovement();
		this.GenerateSpiralPath();
		bool flag = this.pathPoints != null && this.pathPoints.Length > 1;
		if (flag)
		{
			this.moveTween = base.transform.DOPath(this.pathPoints, this.MoveDuration, this.PathType, PathMode.Full3D, 10, null).SetEase(this.MoveEase);
			bool isPlaying = Application.isPlaying;
			if (isPlaying)
			{
				this.moveTween.OnComplete(delegate
				{
					UnityEngine.Object.Destroy(base.gameObject);
					this.onPathGenerated();
				});
			}
			else
			{
				this.moveTween.OnComplete(delegate
				{
					base.transform.position = this.originalPosition;
				});
			}
		}
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0000858C File Offset: 0x0000678C
	public void StartPreviewAnimation()
	{
		bool flag = !Application.isPlaying;
		if (flag)
		{
			this.originalPosition = base.transform.position;
			this.StartCurvedMovement();
		}
	}

	// Token: 0x060000EC RID: 236 RVA: 0x000085C0 File Offset: 0x000067C0
	public void ResetToOriginalPosition()
	{
		bool flag = !Application.isPlaying;
		if (flag)
		{
			this.StopMovement();
			base.transform.position = this.originalPosition;
		}
	}

	// Token: 0x060000ED RID: 237 RVA: 0x000085F8 File Offset: 0x000067F8
	private void GenerateSpiralPath()
	{
		Vector3 startPos = base.transform.position;
		Vector3 targetPos = new Vector3(this.TargetPosition.x, this.TargetPosition.y, startPos.z);
		bool flag = this.pathPoints == null || this.pathPoints.Length != this.PathResolution;
		if (flag)
		{
			this.pathPoints = new Vector3[this.PathResolution];
		}
		Vector3 toTarget = (targetPos - startPos).normalized;
		Vector3 perpendicular = new Vector3(-toTarget.y, toTarget.x, 0f).normalized;
		Vector3 initialCenter = startPos - perpendicular * this.OrbitRadius;
		Vector3 fromCenter = startPos - initialCenter;
		float startAngle = Mathf.Atan2(fromCenter.y, fromCenter.x);
		float angleStep = (float)this.SpiralTurns * 2f * 3.1415927f;
		float invPathResolution = 1f / (float)(this.PathResolution - 1);
		for (int i = 0; i < this.PathResolution; i++)
		{
			float t = (float)i * invPathResolution;
			Vector3 currentCenter = Vector3.Lerp(initialCenter, targetPos, t);
			float radiusT = this.RadiusDecayCurve.Evaluate(t);
			float currentRadius = Mathf.Lerp(this.MinOrbitRadius, this.OrbitRadius, radiusT);
			float angle = startAngle + t * angleStep;
			this.pathPoints[i] = currentCenter + new Vector3(Mathf.Cos(angle) * currentRadius, Mathf.Sin(angle) * currentRadius, 0f);
		}
		this.pathPoints[this.PathResolution - 1] = targetPos;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x000087A0 File Offset: 0x000069A0
	public void StopMovement()
	{
		bool flag = this.moveTween != null;
		if (flag)
		{
			this.moveTween.Kill(false);
			this.moveTween = null;
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x000087D1 File Offset: 0x000069D1
	public void RestartMovement()
	{
		this.StopMovement();
		this.StartCurvedMovement();
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x000087E2 File Offset: 0x000069E2
	private void OnDestroy()
	{
		this.StopMovement();
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x000087EC File Offset: 0x000069EC
	private void OnDrawGizmos()
	{
		bool flag = !this.ShowPath;
		if (!flag)
		{
			Gizmos.color = Color.red;
			Gizmos.DrawSphere(this.TargetPosition, 0.15f);
			bool flag2 = this.pathPoints != null && this.pathPoints.Length > 1;
			if (flag2)
			{
				Gizmos.color = this.PathColor;
				int step = Mathf.Max(1, this.pathPoints.Length / 20);
				for (int i = 0; i < this.pathPoints.Length - step; i += step)
				{
					int nextIndex = Mathf.Min(i + step, this.pathPoints.Length - 1);
					Gizmos.DrawLine(this.pathPoints[i], this.pathPoints[nextIndex]);
				}
				Gizmos.color = new Color(this.PathColor.r, this.PathColor.g, this.PathColor.b, 0.8f);
				bool flag3 = this.pathPoints.Length != 0;
				if (flag3)
				{
					Gizmos.DrawSphere(this.pathPoints[0], 0.08f);
					Gizmos.DrawSphere(this.pathPoints[this.pathPoints.Length - 1], 0.08f);
				}
			}
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 0.1f);
			bool flag4 = !Application.isPlaying;
			if (flag4)
			{
				Gizmos.color = new Color(0f, 1f, 1f, 0.3f);
				this.DrawSimpleCircle(base.transform.position, this.OrbitRadius);
				Vector3 targetPos = new Vector3(this.TargetPosition.x, this.TargetPosition.y, base.transform.position.z);
				Gizmos.color = new Color(1f, 0f, 1f, 0.3f);
				this.DrawSimpleCircle(targetPos, this.MinOrbitRadius);
			}
		}
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000089F8 File Offset: 0x00006BF8
	private void DrawSimpleCircle(Vector3 center, float radius)
	{
		Vector3 lastPoint = center + Vector3.right * radius;
		float angleStep = 6.2831855f / (float)this.CircleSegments;
		for (int i = 1; i <= this.CircleSegments; i++)
		{
			float angle = (float)i * angleStep;
			Vector3 point = center + new Vector3(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius, 0f);
			Gizmos.DrawLine(lastPoint, point);
			lastPoint = point;
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00008A75 File Offset: 0x00006C75
	public void ForceUpdatePath()
	{
		this.GenerateSpiralPath();
	}

	// Token: 0x04000081 RID: 129
	[Header("Target Settings")]
	public Vector3 TargetPosition;

	// Token: 0x04000082 RID: 130
	[Header("Path Settings")]
	public int SpiralTurns = 2;

	// Token: 0x04000083 RID: 131
	public float OrbitRadius = 2f;

	// Token: 0x04000084 RID: 132
	public float MinOrbitRadius = 0.5f;

	// Token: 0x04000085 RID: 133
	[Range(10f, 50f)]
	public int PathResolution = 30;

	// Token: 0x04000086 RID: 134
	public AnimationCurve RadiusDecayCurve = new AnimationCurve(new Keyframe[]
	{
		new Keyframe(0f, 1f, 0f, 0f),
		new Keyframe(0.7f, 0.8f, -0.5f, -0.5f),
		new Keyframe(1f, 0f, -2f, 0f)
	});

	// Token: 0x04000087 RID: 135
	[Header("Movement Settings")]
	public float MoveDuration = 3f;

	// Token: 0x04000088 RID: 136
	public Ease MoveEase = Ease.InOutQuad;

	// Token: 0x04000089 RID: 137
	public PathType PathType = PathType.Linear;

	// Token: 0x0400008A RID: 138
	[Header("Debug")]
	public bool ShowPath = true;

	// Token: 0x0400008B RID: 139
	public Color PathColor = Color.yellow;

	// Token: 0x0400008C RID: 140
	[Range(5f, 16f)]
	public int CircleSegments = 8;

	// Token: 0x0400008D RID: 141
	private Tween moveTween;

	// Token: 0x0400008E RID: 142
	private Vector3[] pathPoints;

	// Token: 0x0400008F RID: 143
	private Vector3 originalPosition;

	// Token: 0x04000090 RID: 144
	private float lastEditorUpdateTime;

	// Token: 0x04000091 RID: 145
	private const float EDITOR_UPDATE_INTERVAL = 0.1f;

	// Token: 0x04000092 RID: 146
	private Action onPathGenerated;
}

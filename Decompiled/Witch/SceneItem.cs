using System;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class SceneItem : MonoBehaviour
{
	// Token: 0x06000107 RID: 263 RVA: 0x000092C4 File Offset: 0x000074C4
	private void Awake()
	{
		this.initWorldPosition = base.transform.position;
	}

	// Token: 0x040000A1 RID: 161
	[Tooltip("视差因子 (0 = 无限远背景, 1 = 参考平面（道路)。值越大，物体感觉越近，移动越快")]
	[Range(0f, 2f)]
	public float parallaxFactor = 0.5f;

	// Token: 0x040000A2 RID: 162
	[HideInInspector]
	public Vector3 initWorldPosition;
}

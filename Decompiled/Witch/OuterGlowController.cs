using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000025 RID: 37
public class OuterGlowController : MonoBehaviour
{
	// Token: 0x060000E4 RID: 228 RVA: 0x0000837C File Offset: 0x0000657C
	private void Awake()
	{
		this.material = ((base.GetComponent<Image>() != null) ? base.GetComponent<Image>().material : base.GetComponent<SpriteRenderer>().material);
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x000083AC File Offset: 0x000065AC
	private void Update()
	{
		float glowSize = Mathf.Lerp(this.Range.x, this.Range.y, (Mathf.Sin(Time.time * 3.1415927f * 2f / this.LoopTime) + 1f) / 2f);
		bool flag = !this.Enabled;
		if (flag)
		{
			glowSize = 0f;
		}
		this.material.SetFloat("_GlowSize", glowSize);
	}

	// Token: 0x0400007D RID: 125
	public Vector2 Range;

	// Token: 0x0400007E RID: 126
	[Range(0.1f, 10f)]
	public float LoopTime = 4f;

	// Token: 0x0400007F RID: 127
	public bool Enabled;

	// Token: 0x04000080 RID: 128
	private Material material;
}

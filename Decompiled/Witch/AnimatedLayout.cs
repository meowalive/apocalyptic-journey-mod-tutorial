using System;
using DG.Tweening;
using UnityEngine;

// Token: 0x020000F0 RID: 240
[ExecuteInEditMode]
public abstract class AnimatedLayout : MonoBehaviour
{
	/// <summary>
	/// 本类用于替代Horizontal Layout，用于特定场合的排列动画效果。
	/// </summary>
	// Token: 0x06000803 RID: 2051 RVA: 0x0003FCFE File Offset: 0x0003DEFE
	public void Start()
	{
		this.LayoutChildren(0f);
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x0003FD0D File Offset: 0x0003DF0D
	public void OnTransformChildrenChanged()
	{
		this.LayoutChildren(this.duration);
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x0003FD20 File Offset: 0x0003DF20
	public void LayoutChildren(float duration)
	{
		float totalWidth = 0f;
		int childCount = 0;
		foreach (object obj in base.transform)
		{
			Transform child = (Transform)obj;
			bool flag = !child.gameObject.activeSelf;
			if (!flag)
			{
				childCount++;
				RectTransform rectT = child.GetComponent<RectTransform>();
				bool flag2 = rectT != null;
				if (flag2)
				{
					totalWidth += rectT.sizeDelta.x * (this.useScaleX ? child.localScale.x : 1f) + this.spacing;
				}
				else
				{
					SpriteRenderer spriteR = child.GetComponent<SpriteRenderer>();
					bool flag3 = spriteR != null && spriteR.sprite != null;
					if (flag3)
					{
						totalWidth += spriteR.sprite.bounds.size.x * (this.useScaleX ? child.localScale.x : 1f) + this.spacing;
					}
				}
			}
		}
		float cur = -totalWidth / 2f;
		foreach (object obj2 in base.transform)
		{
			Transform child2 = (Transform)obj2;
			bool flag4 = !child2.gameObject.activeSelf;
			if (!flag4)
			{
				RectTransform rectT2 = child2.GetComponent<RectTransform>();
				bool flag5 = rectT2 != null;
				float childWidth;
				if (flag5)
				{
					childWidth = rectT2.sizeDelta.x * (this.useScaleX ? child2.localScale.x : 1f) + this.spacing;
				}
				else
				{
					SpriteRenderer spriteR2 = child2.GetComponent<SpriteRenderer>();
					bool flag6 = spriteR2 != null && spriteR2.sprite != null;
					if (!flag6)
					{
						Debug.Log("这里continue");
						continue;
					}
					childWidth = spriteR2.sprite.bounds.size.x * (this.useScaleX ? child2.localScale.x : 1f) + this.spacing;
				}
				bool flag7 = child2.GetComponent<AnimatedLayout.EnableListener>() == null;
				if (flag7)
				{
					child2.gameObject.AddComponent<AnimatedLayout.EnableListener>().layout = this;
				}
				this.SetLayout(child2 as RectTransform, cur + childWidth / 2f, duration);
				cur += childWidth;
			}
		}
	}

	// Token: 0x06000806 RID: 2054
	public abstract void SetLayout(RectTransform rectTransform, float pos, float duration);

	// Token: 0x06000807 RID: 2055 RVA: 0x00040008 File Offset: 0x0003E208
	public void Update()
	{
		bool isPlaying = Application.isPlaying;
		if (!isPlaying)
		{
			this.LayoutChildren(0f);
		}
	}

	// Token: 0x04000B77 RID: 2935
	public float duration = 0.5f;

	// Token: 0x04000B78 RID: 2936
	public Ease ease;

	// Token: 0x04000B79 RID: 2937
	public float spacing = 0f;

	// Token: 0x04000B7A RID: 2938
	public bool useScaleX = false;

	// Token: 0x04000B7B RID: 2939
	public bool useScaleY = false;

	// Token: 0x020000F1 RID: 241
	public class EnableListener : MonoBehaviour
	{
		// Token: 0x06000809 RID: 2057 RVA: 0x0004005B File Offset: 0x0003E25B
		public void OnEnable()
		{
			AnimatedLayout animatedLayout = this.layout;
			if (animatedLayout != null)
			{
				animatedLayout.LayoutChildren(this.layout.duration);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0004005B File Offset: 0x0003E25B
		public void OnDisable()
		{
			AnimatedLayout animatedLayout = this.layout;
			if (animatedLayout != null)
			{
				animatedLayout.LayoutChildren(this.layout.duration);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0004007B File Offset: 0x0003E27B
		public void OnDestroy()
		{
			RectTransform rectTransform = base.transform as RectTransform;
			if (rectTransform != null)
			{
				rectTransform.DOKill(false);
			}
		}

		// Token: 0x04000B7C RID: 2940
		public AnimatedLayout layout;
	}
}

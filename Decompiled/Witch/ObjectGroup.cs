using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.VFX;

// Token: 0x02000028 RID: 40
public class ObjectGroup : MonoBehaviour
{
	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x00008D22 File Offset: 0x00006F22
	// (set) Token: 0x060000FA RID: 250 RVA: 0x00008D2A File Offset: 0x00006F2A
	public float alpha
	{
		get
		{
			return this._alpha;
		}
		set
		{
			this._alpha = value;
			this.OnAlphaChanged(value);
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000FB RID: 251 RVA: 0x00008D3C File Offset: 0x00006F3C
	// (set) Token: 0x060000FC RID: 252 RVA: 0x00008D44 File Offset: 0x00006F44
	public bool blocksRaycasts
	{
		get
		{
			return this._blocksRaycasts;
		}
		set
		{
			bool flag = this == null;
			if (!flag)
			{
				this._blocksRaycasts = value;
				Collider[] colliders = base.GetComponentsInChildren<Collider>();
				TextMeshPro[] textMeshes = base.GetComponentsInChildren<TextMeshPro>();
				foreach (TextMeshPro textMesh in textMeshes)
				{
					textMesh.raycastTarget = false;
				}
				foreach (Collider collider in colliders)
				{
					collider.enabled = value;
				}
			}
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00008DC4 File Offset: 0x00006FC4
	private void Awake()
	{
		this.OnAlphaChanged(this.alpha);
		this.blocksRaycasts = this._blocksRaycasts;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00008DE1 File Offset: 0x00006FE1
	public void SetAlpha(float alpha)
	{
		this.alpha = alpha;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00008DEC File Offset: 0x00006FEC
	private void OnAlphaChanged(float alpha)
	{
		bool flag = this == null;
		if (!flag)
		{
			SpriteRenderer[] spriteRenderers = base.GetComponentsInChildren<SpriteRenderer>();
			Renderer[] renderers = base.GetComponentsInChildren<Renderer>();
			TextMeshPro[] textMeshes = base.GetComponentsInChildren<TextMeshPro>();
			foreach (SpriteRenderer spriteRenderer in spriteRenderers)
			{
				Color color = spriteRenderer.color;
				color.a = alpha;
				spriteRenderer.color = color;
			}
			foreach (TextMeshPro textMesh in textMeshes)
			{
				Color color2 = textMesh.color;
				color2.a = alpha;
				textMesh.color = color2;
			}
			bool isPlaying = EditorApplication.isPlaying;
			if (isPlaying)
			{
				bool flag2 = PrefabUtility.IsPartOfPrefabAsset(base.gameObject);
				if (!flag2)
				{
					foreach (Renderer renderer in renderers)
					{
						bool flag3 = renderer is VFXRenderer || !renderer.material.HasColor("_Color");
						if (!flag3)
						{
							bool flag4 = renderer.material.name.Contains("(Instance)");
							if (flag4)
							{
								Color color3 = renderer.material.color;
								color3.a = alpha;
								renderer.material.color = color3;
							}
							else
							{
								Material material = UnityEngine.Object.Instantiate<Material>(renderer.material);
								Color color4 = material.color;
								color4.a = alpha;
								material.color = color4;
								renderer.material = material;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00008F88 File Offset: 0x00007188
	public TweenerCore<float, float, FloatOptions> DOFade(float endValue, float duration)
	{
		TweenerCore<float, float, FloatOptions> t = DOTween.To(() => this.alpha, delegate(float x)
		{
			this.alpha = x;
		}, endValue, duration);
		t.SetTarget(this);
		return t;
	}

	// Token: 0x04000094 RID: 148
	[SerializeField]
	private float _alpha = 1f;

	// Token: 0x04000095 RID: 149
	[SerializeField]
	private bool _blocksRaycasts = true;
}

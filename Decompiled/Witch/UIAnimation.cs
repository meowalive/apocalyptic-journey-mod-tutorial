using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

// Token: 0x020000E5 RID: 229
[RequireComponent(typeof(Image))]
public class UIAnimation : MonoBehaviour
{
	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0003E7B8 File Offset: 0x0003C9B8
	public int FrameCount
	{
		get
		{
			return this.SpriteFrames.Count;
		}
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x0003E7D5 File Offset: 0x0003C9D5
	private void Awake()
	{
		this.ImageSource = base.GetComponent<Image>();
		this.originalPos = this.ImageSource.rectTransform.anchoredPosition;
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x0003E7FC File Offset: 0x0003C9FC
	private void Start()
	{
		bool autoPlay = this.AutoPlay;
		if (autoPlay)
		{
			this.Play();
		}
		else
		{
			this.IsPlaying = false;
		}
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x0003E828 File Offset: 0x0003CA28
	public void SetSprite(int idx)
	{
		bool flag = idx < 0 || idx >= this.FrameCount;
		if (!flag)
		{
			this.ImageSource.sprite = this.SpriteFrames[idx];
			bool sourceSize = this.SourceSize;
			if (sourceSize)
			{
				this.ImageSource.SetNativeSize();
			}
		}
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x0003E880 File Offset: 0x0003CA80
	public void SetGif(GifAsset gif)
	{
		this.ImageSource = base.GetComponent<Image>();
		this.Pause();
		this.GifAsset = gif;
		bool flag = this.GifAsset != null && this.GifAsset.frames.Count > 0;
		if (flag)
		{
			this.SpriteFrames = this.GifAsset.frames.AsValueEnumerable<Sprite>().ToList<FromList<Sprite>, Sprite>();
			this.FrameDurations = this.GifAsset.frameDelays.AsValueEnumerable<float>().ToList<FromList<float>, float>();
			this.SetSprite(0);
		}
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x0003E910 File Offset: 0x0003CB10
	public void Play()
	{
		bool flag = this.FrameDurations == null;
		if (flag)
		{
			this.FrameDurations = new List<float>();
		}
		bool flag2 = this.FrameDurations.Count != this.FrameCount;
		if (flag2)
		{
			this.FrameDurations.Clear();
			for (int i = 0; i < this.FrameCount; i++)
			{
				this.FrameDurations.Add(1f / this.FPS);
			}
		}
		bool flag3 = this.GifAsset != null && this.GifAsset.frames.Count > 0;
		if (flag3)
		{
			this.SpriteFrames = this.GifAsset.frames.AsValueEnumerable<Sprite>().ToList<FromList<Sprite>, Sprite>();
			this.FrameDurations = this.GifAsset.frameDelays.AsValueEnumerable<float>().ToList<FromList<float>, float>();
		}
		bool flag4 = this.SliceImage && this.SpriteFrames.Count > 0;
		if (flag4)
		{
			TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(this.SpriteFrames[0].texture, 0.1f);
			Vector2 offset = new Vector2((float)(realBounds.leftTransparentWidth - realBounds.rightTransparentWidth) / 2f, (float)(realBounds.bottomTransparentHeight - realBounds.topTransparentHeight) / 2f);
			this.ImageSource.rectTransform.anchoredPosition = this.originalPos + offset;
		}
		this.mDelta = 0f;
		this.mCurFrame = 0;
		this.IsPlaying = true;
		this.Foward = true;
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x0003EA9E File Offset: 0x0003CC9E
	public void PlayReverse()
	{
		this.IsPlaying = true;
		this.Foward = false;
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x0003EAB0 File Offset: 0x0003CCB0
	private void Update()
	{
		bool flag = !this.IsPlaying || this.FrameCount == 0;
		if (!flag)
		{
			bool flag2 = (this.mCurFrame == 0 && this.Foward) || (this.mCurFrame == this.FrameCount && !this.Foward) || this.mDelta > this.FrameDurations[this.mCurFrame - 1];
			if (flag2)
			{
				this.mDelta = 0f;
				bool flag3 = this.mCurFrame >= this.FrameCount;
				if (flag3)
				{
					bool loop = this.Loop;
					if (!loop)
					{
						this.IsPlaying = false;
						Action onComplete = this.OnComplete;
						if (onComplete != null)
						{
							onComplete();
						}
						return;
					}
					this.mCurFrame = 0;
				}
				else
				{
					bool flag4 = this.mCurFrame < 0;
					if (flag4)
					{
						bool loop2 = this.Loop;
						if (!loop2)
						{
							this.IsPlaying = false;
							return;
						}
						this.mCurFrame = this.FrameCount - 1;
					}
				}
				this.SetSprite(this.mCurFrame);
				bool foward = this.Foward;
				if (foward)
				{
					this.mCurFrame++;
				}
				else
				{
					this.mCurFrame--;
				}
			}
			this.mDelta += Time.deltaTime;
		}
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x0003EC07 File Offset: 0x0003CE07
	public void Pause()
	{
		this.IsPlaying = false;
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0003EC14 File Offset: 0x0003CE14
	public void Resume()
	{
		bool flag = !this.IsPlaying;
		if (flag)
		{
			this.IsPlaying = true;
		}
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x0003EC38 File Offset: 0x0003CE38
	public void Stop()
	{
		this.mCurFrame = 0;
		this.SetSprite(this.mCurFrame);
		this.IsPlaying = false;
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x0003EC56 File Offset: 0x0003CE56
	public void Rewind()
	{
		this.mCurFrame = 0;
		this.SetSprite(this.mCurFrame);
		this.Play();
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x0003EC74 File Offset: 0x0003CE74
	private void OnDestroy()
	{
		bool flag = this.ImageSource != null;
		if (flag)
		{
			this.ImageSource.sprite = null;
		}
		bool flag2 = this.SpriteFrames != null;
		if (flag2)
		{
			this.SpriteFrames.Clear();
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x0003ECC0 File Offset: 0x0003CEC0
	private void OnValidate()
	{
		bool flag = this.ImageSource == null;
		if (flag)
		{
			this.ImageSource = base.GetComponent<Image>();
		}
		bool flag2 = this.SpriteFrames == null;
		if (flag2)
		{
			this.SpriteFrames = new List<Sprite>();
		}
		bool flag3 = this.FrameDurations == null;
		if (flag3)
		{
			this.FrameDurations = new List<float>();
		}
		bool flag4 = this.GifAsset != null;
		if (flag4)
		{
			this.SpriteFrames = this.GifAsset.frames.AsValueEnumerable<Sprite>().ToList<FromList<Sprite>, Sprite>();
			this.FrameDurations = this.GifAsset.frameDelays.AsValueEnumerable<float>().ToList<FromList<float>, float>();
			this.ImageSource.sprite = ((this.SpriteFrames.Count > 0) ? this.SpriteFrames[0] : null);
		}
	}

	// Token: 0x04000B45 RID: 2885
	private Image ImageSource;

	// Token: 0x04000B46 RID: 2886
	private int mCurFrame = 0;

	// Token: 0x04000B47 RID: 2887
	private float mDelta = 0f;

	// Token: 0x04000B48 RID: 2888
	public float FPS = 5f;

	// Token: 0x04000B49 RID: 2889
	public List<Sprite> SpriteFrames;

	// Token: 0x04000B4A RID: 2890
	public List<float> FrameDurations;

	// Token: 0x04000B4B RID: 2891
	public GifAsset GifAsset;

	// Token: 0x04000B4C RID: 2892
	public bool IsPlaying = false;

	// Token: 0x04000B4D RID: 2893
	public bool Foward = true;

	// Token: 0x04000B4E RID: 2894
	public bool AutoPlay = false;

	// Token: 0x04000B4F RID: 2895
	public bool Loop = false;

	// Token: 0x04000B50 RID: 2896
	public Action OnComplete;

	// Token: 0x04000B51 RID: 2897
	public bool SourceSize = true;

	// Token: 0x04000B52 RID: 2898
	[Header("切割透明边缘")]
	public bool SliceImage = false;

	// Token: 0x04000B53 RID: 2899
	private Vector2 originalPos;
}

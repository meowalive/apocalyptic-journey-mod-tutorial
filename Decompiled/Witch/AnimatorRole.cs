using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000E0 RID: 224
public class AnimatorRole : MonoBehaviour
{
	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0003DA64 File Offset: 0x0003BC64
	// (set) Token: 0x060007B8 RID: 1976 RVA: 0x0003DA6C File Offset: 0x0003BC6C
	public float animationTimeCounter { get; set; }

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0003DA75 File Offset: 0x0003BC75
	// (set) Token: 0x060007BA RID: 1978 RVA: 0x0003DA7D File Offset: 0x0003BC7D
	public float BottomDistance { get; set; } = 0f;

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060007BB RID: 1979 RVA: 0x0003DA86 File Offset: 0x0003BC86
	// (set) Token: 0x060007BC RID: 1980 RVA: 0x0003DA8E File Offset: 0x0003BC8E
	public float TopDistance { get; set; } = 0f;

	// Token: 0x060007BD RID: 1981 RVA: 0x0003DA98 File Offset: 0x0003BC98
	private void Awake()
	{
		this.OriPos = base.transform.GetComponent<RectTransform>().anchoredPosition;
		bool flag = base.transform.GetComponent<Image>() != null;
		if (flag)
		{
			this.baseHeight = base.transform.GetComponent<RectTransform>().sizeDelta.y;
		}
		else
		{
			this.baseHeight = base.transform.GetComponent<SpriteRenderer>().bounds.size.y;
		}
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x0003DB18 File Offset: 0x0003BD18
	public virtual void Init(DataConfig fromData, string instanceId, bool needDialogueBox = true)
	{
		bool flag = fromData == null;
		if (!flag)
		{
			this.dataConfig = fromData;
			this.InstanceId = instanceId;
			this.GetConfig();
			Sprite[] sprites = ResourceLoader.LoadAll<Sprite>(this.dataConfig.data["Animation"] + "/Idle");
			Array.Sort<Sprite>(sprites, (Sprite a, Sprite b) => new NaturalStringComparer().Compare(a.name, b.name));
			this.AnimatedStateSprites = sprites.ToList<Sprite>();
			bool flag2 = base.transform.GetComponent<Image>() != null;
			if (flag2)
			{
				base.transform.GetComponent<Image>().sprite = this.AnimatedStateSprites[0];
				TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(this.AnimatedStateSprites[0].texture, 0.1f);
				this.BottomDistance = (float)realBounds.bottomTransparentHeight;
				base.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(this.AnimatedStateSprites[0].rect.width, this.AnimatedStateSprites[0].rect.height);
			}
			else
			{
				base.transform.GetComponent<SpriteRenderer>().sprite = this.AnimatedStateSprites[0];
				TextureTransparencyAnalyzer.TransparencyData realBounds2 = TextureTransparencyAnalyzer.AnalyzeAllEdges(this.AnimatedStateSprites[0].texture, 0.1f);
				this.BottomDistance = (float)realBounds2.bottomTransparentHeight;
			}
			bool flag3 = !this.SpecialScale;
			if (flag3)
			{
				bool flag4 = base.transform.GetComponent<Image>() != null && base.transform.GetComponent<RectTransform>().sizeDelta.y != this.baseHeight;
				if (flag4)
				{
					base.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.OriPos.x, this.OriPos.y + ((base.transform.GetComponent<RectTransform>().sizeDelta.y - this.baseHeight) / 2f - this.BottomDistance) * base.transform.localScale.y);
				}
				else
				{
					bool flag5 = base.transform.GetComponent<SpriteRenderer>() != null && base.transform.GetComponent<SpriteRenderer>().bounds.size.y != this.baseHeight;
					if (flag5)
					{
						base.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.OriPos.x, (this.AnimatedStateSprites[0].bounds.size.y - this.baseHeight) / 2f + this.OriPos.y - this.BottomDistance);
					}
					else
					{
						base.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.OriPos.x, this.OriPos.y - this.BottomDistance);
					}
				}
			}
			if (needDialogueBox)
			{
				bool flag6 = base.gameObject.GetComponent<DialogueBoxIdentity>() == null;
				if (flag6)
				{
					base.gameObject.AddComponent<DialogueBoxIdentity>().SetInstanceId(instanceId);
				}
				else
				{
					base.gameObject.GetComponent<DialogueBoxIdentity>().SetInstanceId(instanceId);
				}
			}
			string config = this.TryGetAnimationConfig(this.dataConfig.data["Animation"] + "/Idle");
			bool flag7 = config == "Left";
			if (flag7)
			{
				base.transform.localScale = new Vector3(-Mathf.Abs(base.transform.localScale.x), base.transform.localScale.y, base.transform.localScale.z);
			}
			else
			{
				base.transform.localScale = new Vector3(Mathf.Abs(base.transform.localScale.x), base.transform.localScale.y, base.transform.localScale.z);
			}
		}
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x0003DF4C File Offset: 0x0003C14C
	public string TryGetAnimationConfig(string path)
	{
		TextAsset configFile = ResourceLoader.Load<TextAsset>(path + "/config", true);
		bool flag = configFile == null;
		string result;
		if (flag)
		{
			result = "Left";
		}
		else
		{
			IRole.AnimationConfig configJson = JsonUtility.FromJson<IRole.AnimationConfig>(configFile.text);
			bool flag2 = configJson == null || configJson.AnimationPerFrame <= 0f;
			if (flag2)
			{
				result = "Left";
			}
			else
			{
				result = configJson.Direction;
			}
		}
		return result;
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x0003DFBC File Offset: 0x0003C1BC
	public void InitSprite(Sprite sprite, string instanceId)
	{
		this.InstanceId = instanceId;
		bool flag = base.transform.GetComponent<Image>() != null;
		if (flag)
		{
			base.transform.GetComponent<Image>().sprite = sprite;
			TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(sprite.texture, 0.1f);
			this.BottomDistance = (float)realBounds.bottomTransparentHeight;
			base.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(sprite.rect.width, sprite.rect.height);
		}
		else
		{
			base.transform.GetComponent<SpriteRenderer>().sprite = this.AnimatedStateSprites[0];
			TextureTransparencyAnalyzer.TransparencyData realBounds2 = TextureTransparencyAnalyzer.AnalyzeAllEdges(this.AnimatedStateSprites[0].texture, 0.1f);
			this.BottomDistance = (float)realBounds2.bottomTransparentHeight;
		}
		bool flag2 = !this.SpecialScale;
		if (flag2)
		{
			base.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.OriPos.x, this.OriPos.y - this.BottomDistance);
		}
		bool flag3 = base.gameObject.GetComponent<DialogueBoxIdentity>() == null;
		if (flag3)
		{
			base.gameObject.AddComponent<DialogueBoxIdentity>().SetInstanceId(instanceId);
		}
		else
		{
			base.gameObject.GetComponent<DialogueBoxIdentity>().SetInstanceId(instanceId);
		}
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x0003E11C File Offset: 0x0003C31C
	private void Update()
	{
		bool flag = this.AnimatedStateSprites.Count <= 1;
		if (!flag)
		{
			this.animationTimeCounter += Time.deltaTime;
			bool flag2 = this.animationTimeCounter < this.animationPerFrame;
			if (!flag2)
			{
				this.animationTimeCounter = 0f;
				bool flag3 = this.animaIndex >= this.AnimatedStateSprites.Count;
				if (flag3)
				{
					this.animaIndex = 0;
				}
				Sprite sprite = this.AnimatedStateSprites[this.animaIndex];
				bool flag4 = base.transform.GetComponent<Image>() != null;
				if (flag4)
				{
					base.transform.GetComponent<Image>().sprite = sprite;
				}
				else
				{
					base.transform.GetComponent<SpriteRenderer>().sprite = sprite;
				}
				this.animaIndex++;
			}
		}
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x0003E200 File Offset: 0x0003C400
	public void GetConfig()
	{
		TextAsset configFile = ResourceLoader.Load<TextAsset>(this.dataConfig.data["Animation"] + "/Idle/config", true);
		bool flag = configFile == null;
		if (!flag)
		{
			this.roleConfig = JsonUtility.FromJson<IRole.AnimationConfig>(configFile.text);
			this.animationPerFrame = this.roleConfig.AnimationPerFrame;
		}
	}

	// Token: 0x04000B24 RID: 2852
	protected int animaIndex = 0;

	// Token: 0x04000B25 RID: 2853
	protected List<Sprite> AnimatedStateSprites = new List<Sprite>();

	// Token: 0x04000B26 RID: 2854
	public float animationPerFrame;

	// Token: 0x04000B28 RID: 2856
	public DataConfig dataConfig;

	// Token: 0x04000B2B RID: 2859
	public bool SpecialScale = false;

	// Token: 0x04000B2C RID: 2860
	public Vector2 OriPos;

	// Token: 0x04000B2D RID: 2861
	protected float baseHeight = 0f;

	// Token: 0x04000B2E RID: 2862
	public string InstanceId;

	// Token: 0x04000B2F RID: 2863
	private IRole.AnimationConfig roleConfig;
}

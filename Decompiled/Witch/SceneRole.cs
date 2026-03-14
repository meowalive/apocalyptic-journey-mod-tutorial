using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Witch
{
	// Token: 0x02000253 RID: 595
	public class SceneRole : AnimatorRole
	{
		// Token: 0x06001329 RID: 4905 RVA: 0x00096AE1 File Offset: 0x00094CE1
		private void Awake()
		{
			this.y = this.SceneItem.GetComponent<SceneInfo>().ground_y * 100f;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00096B00 File Offset: 0x00094D00
		public void Init(int index, DataConfig fromData, string instanceId, bool needDialogueBox = true)
		{
			bool flag = fromData == null;
			if (!flag)
			{
				this.dataConfig = fromData;
				this.InstanceId = instanceId;
				base.GetConfig();
				Sprite[] sprites = ResourceLoader.LoadAll<Sprite>(this.dataConfig.data["Animation"] + "/Idle");
				Array.Sort<Sprite>(sprites, (Sprite a, Sprite b) => new NaturalStringComparer().Compare(a.name, b.name));
				this.AnimatedStateSprites = sprites.ToList<Sprite>();
				base.transform.GetComponent<SpriteRenderer>().sprite = this.AnimatedStateSprites[0];
				TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(this.AnimatedStateSprites[0].texture, 0.1f);
				base.BottomDistance = (float)realBounds.bottomTransparentHeight;
				base.TopDistance = (float)realBounds.topTransparentHeight;
				float centerOffsetY = -(base.TopDistance - base.BottomDistance) / 2f;
				float temp = this.y * 100f + this.AnimatedStateSprites[0].bounds.size.y * 50f - base.BottomDistance;
				this.Setposition(new Vector3((float)(-400 - 120 * index), temp, base.transform.position.z) / 100f);
				if (needDialogueBox)
				{
					bool flag2 = base.gameObject.GetComponent<DialogueBoxIdentity>() == null;
					if (flag2)
					{
						base.gameObject.AddComponent<DialogueBoxIdentity>().SetInstanceId(instanceId);
					}
					else
					{
						base.gameObject.GetComponent<DialogueBoxIdentity>().SetInstanceId(instanceId);
					}
				}
				string config = base.TryGetAnimationConfig(this.dataConfig.data["Animation"] + "/Idle");
				bool flag3 = config == "Left";
				if (flag3)
				{
					base.transform.localScale = new Vector3(-Mathf.Abs(base.transform.localScale.x), base.transform.localScale.y, base.transform.localScale.z);
				}
				else
				{
					base.transform.localScale = new Vector3(Mathf.Abs(base.transform.localScale.x), base.transform.localScale.y, base.transform.localScale.z);
				}
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00096D78 File Offset: 0x00094F78
		private void Update()
		{
			bool flag = this.AnimatedStateSprites.Count <= 1;
			if (!flag)
			{
				base.animationTimeCounter += Time.deltaTime;
				bool flag2 = base.animationTimeCounter < this.animationPerFrame;
				if (!flag2)
				{
					base.animationTimeCounter = 0f;
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

		// Token: 0x0600132C RID: 4908 RVA: 0x000966DB File Offset: 0x000948DB
		public void Setposition(Vector3 pos)
		{
			base.transform.position = pos;
		}

		// Token: 0x04000F8A RID: 3978
		public GameObject SceneItem;

		// Token: 0x04000F8B RID: 3979
		private float y;
	}
}

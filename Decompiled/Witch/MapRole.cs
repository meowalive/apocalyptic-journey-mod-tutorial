using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x02000251 RID: 593
	public class MapRole : AnimatorRole
	{
		// Token: 0x06001321 RID: 4897 RVA: 0x0009674A File Offset: 0x0009494A
		private void Awake()
		{
			this.y = this.SceneItem.GetComponent<MapSelectUI>().ground_y;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00096764 File Offset: 0x00094964
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
				float sceneItemWorldY = this.SceneItem.transform.position.y;
				float temp = this.y + this.AnimatedStateSprites[0].bounds.size.y * 10f - base.BottomDistance / 5f;
				this.Setposition(new Vector3((float)(-80 - 24 * index), temp, base.transform.position.z));
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

		// Token: 0x06001323 RID: 4899 RVA: 0x000969E8 File Offset: 0x00094BE8
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

		// Token: 0x06001324 RID: 4900 RVA: 0x000966DB File Offset: 0x000948DB
		public void Setposition(Vector3 pos)
		{
			base.transform.position = pos;
		}

		// Token: 0x04000F86 RID: 3974
		public GameObject SceneItem;

		// Token: 0x04000F87 RID: 3975
		private float y;
	}
}

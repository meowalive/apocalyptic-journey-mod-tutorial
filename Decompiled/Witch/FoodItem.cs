using System;
using Network.Command;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Witch
{
	// Token: 0x02000250 RID: 592
	public class FoodItem : MonoBehaviour
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x00096587 File Offset: 0x00094787
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0009658F File Offset: 0x0009478F
		private float BottomDistance { get; set; } = 0f;

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00096598 File Offset: 0x00094798
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x000965A0 File Offset: 0x000947A0
		private float TopDistance { get; set; } = 0f;

		// Token: 0x0600131D RID: 4893 RVA: 0x000965AC File Offset: 0x000947AC
		public void Init(DataConfig fromData)
		{
			this.y = this.SceneItem.transform.localPosition.y;
			bool flag = fromData == null;
			if (!flag)
			{
				this.dataConfig = fromData;
				Sprite sprites = ResourceLoader.Load<Sprite>(this.dataConfig.data["Icon"], true);
				this.spriteRenderer.sprite = sprites;
				TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(sprites.texture, 0.1f);
				this.BottomDistance = (float)realBounds.bottomTransparentHeight;
				this.TopDistance = (float)realBounds.topTransparentHeight;
				float centerOffsetY = -(this.TopDistance - this.BottomDistance) / 2f;
				float temp = this.y * 100f + sprites.bounds.size.y * 50f - this.BottomDistance;
				this.Setposition(new Vector3(0f, temp, base.transform.position.z) / 100f);
				base.gameObject.AddComponent<PolygonCollider2D>();
				this.button.onClick.AddListener(new UnityAction(this.EatFood));
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x000966DB File Offset: 0x000948DB
		public void Setposition(Vector3 pos)
		{
			base.transform.position = pos;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x000966EC File Offset: 0x000948EC
		public void EatFood()
		{
			bool flag = PlayerManager.Instance == null;
			if (!flag)
			{
				PlayerManager.Instance.SendRpcCommand(new RpcEatFood(this.dataConfig, PlayerManager.Instance.PlayerId));
			}
		}

		// Token: 0x04000F7F RID: 3967
		[UnityInject(false)]
		public SpriteRenderer spriteRenderer;

		// Token: 0x04000F80 RID: 3968
		[UnityInject(false)]
		public Button button;

		// Token: 0x04000F81 RID: 3969
		public GameObject SceneItem;

		// Token: 0x04000F82 RID: 3970
		private float y;

		// Token: 0x04000F83 RID: 3971
		public DataConfig dataConfig;
	}
}

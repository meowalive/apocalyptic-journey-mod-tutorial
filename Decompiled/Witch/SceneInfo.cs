using System;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class SceneInfo : MonoBehaviour
{
	// Token: 0x06000104 RID: 260 RVA: 0x00008FF0 File Offset: 0x000071F0
	private void Awake()
	{
		this.cameraTransform = Camera.main.transform;
		this.initialCameraPosition = this.cameraTransform.position;
		this.lastCameraPosition = this.cameraTransform.position;
		this.sceneItems = base.GetComponentsInChildren<SceneItem>();
		this.isInCanvas = base.transform.GetComponentInParent<Canvas>();
		this.isInCanvas = (base.GetComponentInParent<Canvas>() != null);
		this.ground_y = this.groundPos.localPosition.y * (this.isInCanvas ? 0.01f : 1f);
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00009090 File Offset: 0x00007290
	private void LateUpdate()
	{
		bool flag = this.cameraTransform == null;
		if (!flag)
		{
			this.cameraTransform.position = new Vector3(Mathf.Clamp(this.cameraTransform.position.x, this.boundaryX.x, this.boundaryX.y), Mathf.Clamp(this.cameraTransform.position.y, this.boundaryY.x, this.boundaryY.y), this.cameraTransform.position.z);
			Vector3 cameraDisplacement = this.cameraTransform.position - this.initialCameraPosition;
			bool flag2 = this.cameraTransform.position != this.lastCameraPosition;
			if (flag2)
			{
				this.lastCameraPosition = this.cameraTransform.position;
				Singleton<EventCenter>.Instance.EventTrigger("OnCameraMove");
			}
			foreach (SceneItem layer in this.sceneItems)
			{
				Vector3 positionForFactorZero = layer.initWorldPosition + cameraDisplacement;
				Vector3 virtualBackgroundPoint = new Vector3(layer.initWorldPosition.x, layer.initWorldPosition.y, this.backgroundPlaneZ);
				Vector3 direction = virtualBackgroundPoint - this.cameraTransform.position;
				bool flag3 = Mathf.Approximately(direction.z, 0f);
				if (!flag3)
				{
					float t = (layer.initWorldPosition.z - this.cameraTransform.position.z) / direction.z;
					Vector3 positionForFactorOne = this.cameraTransform.position + direction * t;
					bool flag4 = this.isInCanvas;
					float interpolationFactor;
					if (flag4)
					{
						interpolationFactor = layer.parallaxFactor;
					}
					else
					{
						interpolationFactor = layer.parallaxFactor;
					}
					layer.transform.position = Vector3.Lerp(positionForFactorZero, positionForFactorOne, interpolationFactor);
				}
			}
		}
	}

	// Token: 0x04000096 RID: 150
	public float ground_y;

	// Token: 0x04000097 RID: 151
	[UnityInject(false)]
	public BGMList bgmList;

	// Token: 0x04000098 RID: 152
	[Tooltip("参照平面")]
	public float backgroundPlaneZ = 0f;

	// Token: 0x04000099 RID: 153
	[Tooltip("X边界范围")]
	public Vector2 boundaryX = new Vector2(-1f, 1f);

	// Token: 0x0400009A RID: 154
	[Tooltip("Y边界范围")]
	public Vector2 boundaryY = new Vector2(-1f, 1f);

	// Token: 0x0400009B RID: 155
	[SerializeField]
	private Transform groundPos;

	// Token: 0x0400009C RID: 156
	private Transform cameraTransform;

	// Token: 0x0400009D RID: 157
	private Vector3 initialCameraPosition;

	// Token: 0x0400009E RID: 158
	private SceneItem[] sceneItems;

	// Token: 0x0400009F RID: 159
	private bool isInCanvas;

	// Token: 0x040000A0 RID: 160
	private Vector3 lastCameraPosition;
}

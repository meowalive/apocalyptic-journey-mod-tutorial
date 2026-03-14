using System;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Component.UI.Animation
{
	// Token: 0x020001C7 RID: 455
	[ExecuteInEditMode]
	public class ClockAnimator : MonoBehaviour
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x00085734 File Offset: 0x00083934
		public void Awake()
		{
			this.clockBoard.eulerAngles = (this.clockHand.eulerAngles = Vector3.zero);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00085764 File Offset: 0x00083964
		public void RotateToAngle(ClockAnimator.RotatePos rotateType)
		{
			float angle = (float)rotateType;
			bool flag = this.clockHand == null || this.clockBoard == null;
			if (flag)
			{
				Debug.LogWarning("时钟组件未设置！");
			}
			else
			{
				Action action = delegate()
				{
					this.Rotate(this.clockHand, angle, true);
					this.Rotate(this.clockBoard, angle, false);
				};
				bool flag2 = DOTween.IsTweening(this.clockBoard, false) || DOTween.IsTweening(this.clockHand, false);
				if (flag2)
				{
					this.rotateQueue.Enqueue(action);
				}
				else
				{
					action();
				}
			}
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00085800 File Offset: 0x00083A00
		private void Rotate(Transform obj, float targetAngle, bool clockwise)
		{
			float fullRotation = (clockwise ? 360f : -360f) * this.rotateCount;
			float currentAngle = this.NormalizeAngle(obj.eulerAngles.z);
			float normalizedTarget = this.NormalizeAngle(targetAngle);
			float angleDiff = this.CalculateAngle(currentAngle, normalizedTarget, clockwise);
			obj.DORotate(new Vector3(0f, 0f, fullRotation + angleDiff), this.rotationDuration, RotateMode.LocalAxisAdd).SetEase(this.fullRotationEase).OnComplete(delegate
			{
				obj.eulerAngles = Vector3.forward * this.NormalizeAngle(obj.eulerAngles.z);
				bool flag = this.rotateQueue.Count > 0;
				if (flag)
				{
					this.rotateQueue.Dequeue()();
				}
			});
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000858A8 File Offset: 0x00083AA8
		private float NormalizeAngle(float angle)
		{
			return (angle % 360f + 360f) % 360f;
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000858D0 File Offset: 0x00083AD0
		private float CalculateAngle(float from, float to, bool clockwise)
		{
			float angle = this.NormalizeAngle(to - from);
			float result;
			if (clockwise)
			{
				result = angle;
			}
			else
			{
				result = 360f - angle;
			}
			return result;
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000858FE File Offset: 0x00083AFE
		[ContextMenu("旋转到自己")]
		public void RotateToSelf()
		{
			this.RotateToAngle(ClockAnimator.RotatePos.Self);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00085909 File Offset: 0x00083B09
		[ContextMenu("旋转到队友")]
		public void RotateToFriend()
		{
			this.RotateToAngle(ClockAnimator.RotatePos.Friend);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00085917 File Offset: 0x00083B17
		[ContextMenu("旋转到敌人")]
		public void RotateToEnemy()
		{
			this.RotateToAngle(ClockAnimator.RotatePos.Enemy);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00085925 File Offset: 0x00083B25
		[ContextMenu("旋转到中立")]
		public void RotateToNeutral()
		{
			this.RotateToAngle(ClockAnimator.RotatePos.Neutral);
		}

		// Token: 0x04000E21 RID: 3617
		[Header("时钟组件")]
		public Transform clockHand;

		// Token: 0x04000E22 RID: 3618
		public Transform clockBoard;

		// Token: 0x04000E23 RID: 3619
		public AudioClip rotateSound;

		// Token: 0x04000E24 RID: 3620
		[Header("动画设置")]
		public float rotationDuration = 2f;

		// Token: 0x04000E25 RID: 3621
		public Ease fullRotationEase = Ease.InOutQuad;

		// Token: 0x04000E26 RID: 3622
		public float rotateCount = 1f;

		// Token: 0x04000E27 RID: 3623
		private Queue<Action> rotateQueue = new Queue<Action>();

		// Token: 0x020001C8 RID: 456
		public enum RotatePos
		{
			// Token: 0x04000E29 RID: 3625
			Default,
			// Token: 0x04000E2A RID: 3626
			Self = 45,
			// Token: 0x04000E2B RID: 3627
			Enemy = 135,
			// Token: 0x04000E2C RID: 3628
			Friend = 225,
			// Token: 0x04000E2D RID: 3629
			Neutral = 315
		}
	}
}

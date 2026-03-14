using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Witch
{
	// Token: 0x02000245 RID: 581
	public class DollItem : MonoBehaviour
	{
		// Token: 0x060012C4 RID: 4804 RVA: 0x00093560 File Offset: 0x00091760
		private void Start()
		{
			this.animator = base.gameObject.GetComponent<Animator>();
			this.originalX = base.gameObject.GetComponent<RectTransform>().anchoredPosition.x;
			AnimationClip[] clips = this.animator.runtimeAnimatorController.animationClips;
			this.runninglength = Array.Find<AnimationClip>(clips, (AnimationClip c) => c.name == "跑步").length;
			this.waitLength = Array.Find<AnimationClip>(clips, (AnimationClip c) => c.name == "待机").length;
			this.isRight = (this.random.Next(0, 2) == 0);
			this.Running();
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00093628 File Offset: 0x00091828
		public void Running()
		{
			this.isRunning = true;
			this.animator.Play("跑步");
			this.mul = (float)this.random.Next(1, 5);
			float dollTargetX = this.isRight ? (this.originalX - this.mul) : (this.originalX + this.mul);
			float dollDeltaX = base.gameObject.GetComponent<RectTransform>().anchoredPosition.x - dollTargetX;
			bool flag = dollDeltaX / 50f > 0f;
			if (flag)
			{
				this.mul = (float)Mathf.Max(1, (int)dollDeltaX / 50);
			}
			else
			{
				this.mul = (float)Mathf.Min(-1, (int)dollDeltaX / 50);
			}
			dollTargetX = base.gameObject.GetComponent<RectTransform>().anchoredPosition.x - this.mul;
			bool flag2 = dollDeltaX < 0f;
			if (flag2)
			{
				Vector3 newEulerAngles = base.transform.eulerAngles;
				newEulerAngles.y = 180f;
				base.transform.eulerAngles = newEulerAngles;
			}
			else
			{
				bool flag3 = dollDeltaX > 0f;
				if (flag3)
				{
					Vector3 newEulerAngles2 = base.transform.eulerAngles;
					newEulerAngles2.y = 0f;
					base.transform.eulerAngles = newEulerAngles2;
				}
			}
			base.gameObject.GetComponent<RectTransform>().DOAnchorPos(new Vector2(dollTargetX, base.gameObject.GetComponent<RectTransform>().anchoredPosition.y), Mathf.Abs(this.runninglength * this.mul), false).OnComplete(delegate
			{
				this.isRight = !this.isRight;
				this.EndRunning();
			}).SetEase(Ease.InOutSine);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000937BC File Offset: 0x000919BC
		private void Update()
		{
			bool flag = this.isRunning;
			if (!flag)
			{
				bool flag2 = Time.time - this.lasttime > this.waitTime;
				if (flag2)
				{
					this.Running();
				}
			}
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000937F8 File Offset: 0x000919F8
		public void EndRunning()
		{
			this.lasttime = Time.time;
			Animator animator = base.gameObject.GetComponent<Animator>();
			animator.Play("待机");
			this.isRunning = false;
			this.waitTime = (float)(2 * this.random.Next(1, 4)) * this.waitLength;
		}

		// Token: 0x04000F56 RID: 3926
		public float waitTime = 0f;

		// Token: 0x04000F57 RID: 3927
		private float originalX;

		// Token: 0x04000F58 RID: 3928
		private System.Random random = new System.Random();

		// Token: 0x04000F59 RID: 3929
		private float lasttime;

		// Token: 0x04000F5A RID: 3930
		private bool isRunning = false;

		// Token: 0x04000F5B RID: 3931
		private float runninglength;

		// Token: 0x04000F5C RID: 3932
		private float waitLength = 2f;

		// Token: 0x04000F5D RID: 3933
		public float mul;

		// Token: 0x04000F5E RID: 3934
		public bool isRight;

		// Token: 0x04000F5F RID: 3935
		private Animator animator;
	}
}

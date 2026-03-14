using System;
using System.Diagnostics;
using System.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x020002F6 RID: 758
	public class PopUpTextUI : MonoBehaviour
	{
		// Token: 0x060017CA RID: 6090 RVA: 0x000C62E4 File Offset: 0x000C44E4
		public void SetDisplayInt(int value)
		{
			this._displayInt = value;
			this._textDirty = true;
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x000C62F5 File Offset: 0x000C44F5
		public int GetDisplayInt()
		{
			return this._displayInt;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x000C62FD File Offset: 0x000C44FD
		private void Start()
		{
			this.time = 0f;
			this.existTime = 0f;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000C6318 File Offset: 0x000C4518
		public void InitChange()
		{
			base.StopAllCoroutines();
			this.time = 0f;
			this.existTime = 0f;
			this.GetCurves().Forget();
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000C6354 File Offset: 0x000C4554
		[DebuggerStepThrough]
		private UniTaskVoid GetCurves()
		{
			PopUpTextUI.<GetCurves>d__30 <GetCurves>d__ = new PopUpTextUI.<GetCurves>d__30();
			<GetCurves>d__.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
			<GetCurves>d__.<>4__this = this;
			<GetCurves>d__.<>1__state = -1;
			<GetCurves>d__.<>t__builder.Start<PopUpTextUI.<GetCurves>d__30>(ref <GetCurves>d__);
			return <GetCurves>d__.<>t__builder.Task;
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x000C6398 File Offset: 0x000C4598
		public void SetTextFont(float val)
		{
			this.text.fontSize += val;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x000C63B0 File Offset: 0x000C45B0
		public void Update()
		{
			bool flag = this.time >= this.TotalTime;
			if (!flag)
			{
				this._updateAccumulator += Time.unscaledDeltaTime;
				bool flag2 = this._updateAccumulator < 0.033333335f;
				if (!flag2)
				{
					this._updateAccumulator = 0f;
					float normalized = Mathf.Clamp01(this.time / this.TotalTime);
					bool textDirty = this._textDirty;
					if (textDirty)
					{
						PopUpTextUI._sharedSb.Clear();
						PopUpTextUI._sharedSb.Append(this._displayInt);
						this.text.SetText(PopUpTextUI._sharedSb);
						this._textDirty = false;
						this._lastVal = this.val;
					}
					else
					{
						bool flag3 = this._lastVal != this.val;
						if (flag3)
						{
							this.text.SetText(this.val);
							this._lastVal = this.val;
						}
					}
					bool flag4 = Mathf.Abs(this._lastNormalized - normalized) > 0.01f;
					if (flag4)
					{
						this.text.color = this.colors.Evaluate(normalized);
						this._lastNormalized = normalized;
					}
				}
			}
		}

		// Token: 0x04001282 RID: 4738
		public AnimationCurve x_position_curve;

		// Token: 0x04001283 RID: 4739
		public AnimationCurve y_position_curve;

		// Token: 0x04001284 RID: 4740
		public AnimationCurve fontsize_curve;

		// Token: 0x04001285 RID: 4741
		public Gradient colors;

		// Token: 0x04001286 RID: 4742
		public string val;

		// Token: 0x04001287 RID: 4743
		public bool isDestroy;

		// Token: 0x04001288 RID: 4744
		public float TotalTime;

		// Token: 0x04001289 RID: 4745
		public float maxHeight;

		// Token: 0x0400128A RID: 4746
		public float maxLength;

		// Token: 0x0400128B RID: 4747
		public float maxFontSize;

		// Token: 0x0400128C RID: 4748
		public Vector2 nowPos;

		// Token: 0x0400128D RID: 4749
		private float x_position_offset;

		// Token: 0x0400128E RID: 4750
		private float y_position_offset;

		// Token: 0x0400128F RID: 4751
		[UnityInject(false)]
		[SerializeField]
		private TMP_Text text;

		// Token: 0x04001290 RID: 4752
		private float _updateAccumulator = 0f;

		// Token: 0x04001291 RID: 4753
		private const float UPDATE_INTERVAL = 0.033333335f;

		// Token: 0x04001292 RID: 4754
		private string _lastVal;

		// Token: 0x04001293 RID: 4755
		private float _lastNormalized = -1f;

		// Token: 0x04001294 RID: 4756
		public Vector2 start_position;

		// Token: 0x04001295 RID: 4757
		public float time;

		// Token: 0x04001296 RID: 4758
		public float existTime;

		// Token: 0x04001297 RID: 4759
		public string target;

		// Token: 0x04001298 RID: 4760
		public bool pause = false;

		// Token: 0x04001299 RID: 4761
		private int _displayInt;

		// Token: 0x0400129A RID: 4762
		private bool _textDirty;

		// Token: 0x0400129B RID: 4763
		private static readonly StringBuilder _sharedSb = new StringBuilder(16);
	}
}

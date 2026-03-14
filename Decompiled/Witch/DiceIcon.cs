using System;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;

// Token: 0x0200010B RID: 267
public class DiceIcon : MonoBehaviour
{
	// Token: 0x0600089D RID: 2205 RVA: 0x00044394 File Offset: 0x00042594
	private void Awake()
	{
		this.result = base.transform.Find("Dice/result").GetComponent<TextMeshProUGUI>();
		this.range = base.transform.Find("Dice/range").GetComponent<TextMeshProUGUI>();
		this.bonusText = base.transform.Find("Dice/result/val/bonus").GetComponent<TextMeshProUGUI>();
		this.canvasGroup = base.GetComponent<CanvasGroup>();
		this.canvasGroup.alpha = 0f;
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00044410 File Offset: 0x00042610
	public void Roll(string title)
	{
		AudioManager instance = AudioManager.Instance;
		if (instance != null)
		{
			instance.PlayEffect("Effect/dice_roll");
		}
		bool flag = this.rangeValue != null;
		if (flag)
		{
			bool flag2 = this.range == null;
			if (flag2)
			{
				Debug.LogError("Range TextMeshProUGUI is null, please check the hierarchy.");
				UniTask.WaitForSeconds(0.4f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
				{
					Singleton<ObjectPool>.Instance.Release(this.gameObject);
				}).Forget();
				return;
			}
			this.range.text = ZString.Format<object, object, object>("<color=yellow>{0}</color>\n{1} ~ {2}", title, this.rangeValue.Value.Item1, this.rangeValue.Value.Item2);
			bool flag3 = !string.IsNullOrEmpty(this.Target);
			if (flag3)
			{
				TextMeshProUGUI textMeshProUGUI = this.range;
				textMeshProUGUI.text = textMeshProUGUI.text + "/<color=yellow>" + this.Target + "</color>";
			}
		}
		else
		{
			this.range.text = "";
		}
		this.canvasGroup.DOFade(1f, 0.1f).OnStart(delegate
		{
			this.gameObject.SetActive(true);
		});
		this.result.text = "";
		float delay = 0f;
		bool flag4 = this.bonus != 0;
		if (flag4)
		{
			this.bonusText.transform.parent.GetComponent<CanvasGroup>().DOFade(1f, 0.6f);
			this.bonusText.transform.parent.Find("oper").GetComponent<TMP_Text>().text = ((this.bonus > 0) ? "+" : "-");
			this.bonusText.DOText("0", 0.2f, true, ScrambleMode.Numerals, null).SetDelay(0.6f);
			this.result.DOText(this.value.ToString(), 0.1f, true, ScrambleMode.Numerals, null).SetDelay(0.8f);
			this.bonusText.transform.parent.GetComponent<CanvasGroup>().DOFade(0f, 0.2f).SetDelay(1f);
			delay = 0.5f;
		}
		this.result.DOText((this.value - this.bonus).ToString(), this.rollDuration, true, ScrambleMode.Numerals, null).SetDelay(0.2f).OnComplete(delegate
		{
			bool flag5 = !string.IsNullOrEmpty(this.Target) && this.Target.ToInt() >= this.result.text.ToInt();
			if (flag5)
			{
				AudioManager instance2 = AudioManager.Instance;
				if (instance2 != null)
				{
					instance2.PlayEffect("Effect/success");
				}
				this.transform.DOPunchScale(1.2f * this.transform.localScale, 0.5f, 2, 1f).SetDelay(delay);
			}
		});
		this.canvasGroup.DOFade(0f, 0.1f).SetDelay(0.5f + delay + 0.2f + this.rollDuration).OnComplete(delegate
		{
			Singleton<ObjectPool>.Instance.Release(this.gameObject);
		});
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x000446FD File Offset: 0x000428FD
	private void OnDisable()
	{
		this.rangeValue = null;
	}

	// Token: 0x04000BDE RID: 3038
	public TextMeshProUGUI result;

	// Token: 0x04000BDF RID: 3039
	public TextMeshProUGUI bonusText;

	// Token: 0x04000BE0 RID: 3040
	public TextMeshProUGUI range;

	// Token: 0x04000BE1 RID: 3041
	public string Target;

	// Token: 0x04000BE2 RID: 3042
	public CanvasGroup canvasGroup;

	// Token: 0x04000BE3 RID: 3043
	public float rollDuration = 0.5f;

	// Token: 0x04000BE4 RID: 3044
	public int value;

	// Token: 0x04000BE5 RID: 3045
	public int bonus;

	// Token: 0x04000BE6 RID: 3046
	public ValueTuple<int, int>? rangeValue = null;
}

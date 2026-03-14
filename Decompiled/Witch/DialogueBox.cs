using System;
using System.Text.RegularExpressions;
using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000108 RID: 264
public class DialogueBox : MonoBehaviour
{
	// Token: 0x0600088A RID: 2186 RVA: 0x00043B3A File Offset: 0x00041D3A
	private void OnEnable()
	{
		base.transform.localScale = 0.2f * Vector3.one;
		base.transform.DOScale(1f, 0.5f).SetEase(Ease.OutBack);
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00043B78 File Offset: 0x00041D78
	public void ShowDialogue(DataConfig dataConfig)
	{
		base.transform.Find("Content").gameObject.SetActive(true);
		base.transform.Find("Emoji").gameObject.SetActive(false);
		this.dataConfig = dataConfig;
		string pureText = dataConfig.data["Text"];
		dataConfig.scriptExecutor.RunScript("StartScript");
		pureText = Regex.Replace(pureText, "<.*?>", "");
		base.transform.Find("Content").GetComponent<RectTransform>().sizeDelta = new Vector2((float)pureText.Length * base.transform.Find("Content/text").GetComponent<TMP_Text>().fontSize / 1.4f, 120f);
		base.transform.Find("Content/text").GetComponent<TMP_Text>().SetText(dataConfig.data["Text"]);
		base.transform.Find("Content/progress").GetComponent<Image>().DOFillAmount(1f, 0.1f * (float)pureText.Length + 2.5f).OnKill(delegate
		{
			this.transform.Find("Content/progress").GetComponent<Image>().DOFillAmount(1f, 0.1f);
		});
		dataConfig.scriptExecutor.Vars["ChatState"] = "Chatting";
		UniTask.WaitForSeconds(0.1f * (float)pureText.Length, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
		{
			bool flag = this.isClosed;
			if (!flag)
			{
				dataConfig.scriptExecutor.Vars["ChatState"] = "Chatted";
			}
		});
		UniTask.WaitForSeconds(0.1f * (float)pureText.Length + 2.5f, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
		{
			bool flag = this.isClosed;
			if (!flag)
			{
				dataConfig.scriptExecutor.Vars["ChatState"] = "Waiting";
				bool flag2 = dataConfig.Vars.GetValueOrDefault("Waiting", "false") != "true";
				if (flag2)
				{
					this.Close();
				}
			}
		}).Forget();
		base.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(Singleton<DialogueManager>.Instance.Identity[dataConfig.data["RoleId"]].transform.position));
		this.parent = Singleton<DialogueManager>.Instance.Identity[dataConfig.data["RoleId"]].transform;
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00043E00 File Offset: 0x00042000
	public void ShowEmoji(string id, GifAsset emoji)
	{
		base.transform.Find("Content").gameObject.SetActive(false);
		base.transform.Find("Emoji").gameObject.SetActive(true);
		base.transform.Find("Emoji/Icon").GetComponent<UIAnimation>().GifAsset = emoji;
		base.transform.Find("Emoji/Icon").GetComponent<UIAnimation>().Play();
		base.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(Singleton<DialogueManager>.Instance.Identity[id].transform.position)) + new Vector2(0f, 100f);
		UniTask.WaitForSeconds(2, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			bool flag = this.isClosed;
			if (!flag)
			{
				this.Close();
			}
		});
		this.parent = Singleton<DialogueManager>.Instance.Identity[id].transform;
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00043F2C File Offset: 0x0004212C
	private void Update()
	{
		bool flag = this.parent != null;
		if (flag)
		{
			base.transform.localPosition = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), Camera.main.WorldToScreenPoint(this.parent.position)) + (base.transform.Find("Emoji").gameObject.activeSelf ? new Vector2(0f, 100f) : Vector2.zero);
		}
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00043FC4 File Offset: 0x000421C4
	public void Close()
	{
		bool flag = this.isClosed;
		if (!flag)
		{
			this.isClosed = true;
			base.transform.Find("Content/progress").GetComponent<Image>().DOKill(false);
			UniTask.WaitForSeconds(0.5f, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				bool flag2 = this.dataConfig == null;
				if (!flag2)
				{
					bool flag3 = string.IsNullOrEmpty(this.dataConfig.data["EndScript"]);
					if (flag3)
					{
						Singleton<DialogueManager>.Instance.NextDialogueBox();
					}
					else
					{
						this.dataConfig.scriptExecutor.RunScript("EndScript");
					}
				}
			}).Forget();
			base.transform.DOScale(0f, 0.3f).SetEase(Ease.InBack).OnComplete(delegate
			{
				bool flag2 = this != null && base.gameObject != null;
				if (flag2)
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}).OnKill(delegate
			{
				bool flag2 = this != null && base.gameObject != null;
				if (flag2)
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			});
		}
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x0004406D File Offset: 0x0004226D
	public void PlayTalkEffect()
	{
		AudioManager instance = AudioManager.Instance;
		if (instance != null)
		{
			instance.PlayEffect("Effect/pop");
		}
	}

	// Token: 0x04000BD7 RID: 3031
	private bool isClosed = false;

	// Token: 0x04000BD8 RID: 3032
	private DataConfig dataConfig;

	// Token: 0x04000BD9 RID: 3033
	private Transform parent;
}

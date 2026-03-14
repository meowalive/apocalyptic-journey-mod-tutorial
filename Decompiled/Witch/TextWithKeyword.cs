using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;

// Token: 0x020000F2 RID: 242
public class TextWithKeyword : MonoBehaviour
{
	// Token: 0x0600080D RID: 2061 RVA: 0x00040096 File Offset: 0x0003E296
	private void Awake()
	{
		this.mainText = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x000400A8 File Offset: 0x0003E2A8
	public void Init()
	{
		this.isInit = true;
		this.keywords = new List<string>();
		this.keywordPosDic = new Dictionary<int, string>();
		string text = Singleton<TextTranslator>.Instance.Translate(this.mainText.text, this.keywords);
		this.mainText.text = text;
		this.textWithoutTag = Regex.Replace(this.mainText.text, "<[^>]+>", "");
		foreach (string keyword in this.keywords)
		{
			for (int index = this.textWithoutTag.IndexOf(keyword); index != -1; index = this.textWithoutTag.IndexOf(keyword, index + 1))
			{
				for (int i = 0; i < keyword.Length; i++)
				{
					this.keywordPosDic.Add(index + i, keyword);
				}
			}
		}
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x000401BC File Offset: 0x0003E3BC
	private void Update()
	{
		bool flag = !this.isInit;
		if (!flag)
		{
			Vector2 mousePos = KeyManager.playerAction.Main.Point.ReadValue<Vector2>();
			int index = TMP_TextUtilities.FindNearestCharacter(this.mainText, mousePos, Camera.main, true);
			int cast = TMP_TextUtilities.FindIntersectingCharacter(this.mainText, mousePos, Camera.main, true);
			bool flag2 = cast != -1 && this.keywordPosDic.ContainsKey(cast);
			if (flag2)
			{
				this.lastPos = mousePos;
			}
			bool flag3 = Vector2.Distance(this.lastPos, mousePos) <= this.maxDistance && this.keywordPosDic.ContainsKey(index) && Singleton<TempDataManager>.Instance.keyWordsDic[Globals.Language].ContainsKey(this.keywordPosDic[index]);
			if (flag3)
			{
				Vector2 pos;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(this.tooltip.parent.GetComponent<RectTransform>(), mousePos, Camera.main, out pos);
				this.ShowTooltip(pos, Singleton<TempDataManager>.Instance.keyWordsDic[Globals.Language][this.keywordPosDic[index]]);
			}
			else
			{
				bool flag4 = Vector2.Distance(this.lastPos, mousePos) <= this.maxDistance && this.keywordPosDic.ContainsKey(index) && Singleton<TempDataManager>.Instance.keyWordsDic["Default"].ContainsKey(this.keywordPosDic[index]);
				if (flag4)
				{
					Vector2 pos2;
					RectTransformUtility.ScreenPointToLocalPointInRectangle(this.tooltip.parent.GetComponent<RectTransform>(), mousePos, Camera.main, out pos2);
					this.ShowTooltip(pos2, Singleton<TempDataManager>.Instance.keyWordsDic["Default"][this.keywordPosDic[index]]);
				}
				else
				{
					bool flag5 = index == -1 || Vector2.Distance(this.lastPos, mousePos) > this.maxDistance;
					if (flag5)
					{
						this.HideTooltip();
					}
				}
			}
		}
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x000403B8 File Offset: 0x0003E5B8
	public void ShowTooltip(Vector2 pos, string text)
	{
		bool flag = this.isShow;
		if (!flag)
		{
			this.isShow = true;
			this.tooltip.localPosition = pos;
			this.tooltip.DOKill(false);
			this.tooltip.Find("content/text").GetComponent<TextMeshProUGUI>().SetText(text);
			this.tooltip.localScale = Vector3.zero;
			this.tooltip.DOScale(Vector3.one, 0.2f);
		}
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x0004043C File Offset: 0x0003E63C
	public void HideTooltip()
	{
		bool flag = !this.isShow;
		if (!flag)
		{
			this.isShow = false;
			this.tooltip.DOKill(false);
			this.tooltip.DOScale(Vector3.zero, 0.2f).OnComplete(delegate
			{
				this.tooltip.Find("content/text").GetComponent<TextMeshProUGUI>().text = "";
			});
		}
	}

	// Token: 0x04000B7D RID: 2941
	[SerializeField]
	private RectTransform tooltip;

	// Token: 0x04000B7E RID: 2942
	private TextMeshProUGUI mainText;

	// Token: 0x04000B7F RID: 2943
	private List<string> keywords;

	// Token: 0x04000B80 RID: 2944
	private string textWithoutTag;

	// Token: 0x04000B81 RID: 2945
	private Dictionary<int, string> keywordPosDic;

	// Token: 0x04000B82 RID: 2946
	private Vector2 lastPos = Vector2.zero;

	// Token: 0x04000B83 RID: 2947
	public float maxDistance = 100f;

	// Token: 0x04000B84 RID: 2948
	private bool isShow;

	// Token: 0x04000B85 RID: 2949
	private bool isInit;
}

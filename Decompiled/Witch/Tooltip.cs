using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000114 RID: 276
public class Tooltip : MonoBehaviour
{
	// Token: 0x060008CA RID: 2250 RVA: 0x0004547A File Offset: 0x0004367A
	private void Awake()
	{
		this.canvasTf = GameObject.Find("Canvas").GetComponent<RectTransform>();
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00045494 File Offset: 0x00043694
	private void Show(Transform trans, bool Main = true, bool Sub = true, float maxWidth = 360f)
	{
		this.obj = trans;
		base.StopAllCoroutines();
		bool flag = string.IsNullOrEmpty(this.text);
		if (flag)
		{
			Main = false;
		}
		bool flag2 = this.keywords == null || this.keywords.Count == 0;
		if (flag2)
		{
			Sub = false;
		}
		bool flag3 = !Main && !Sub;
		if (!flag3)
		{
			this.subWidth = 0f;
			this.subHeight = 0f;
			base.transform.SetAsLastSibling();
			foreach (object obj in base.transform.Find("Sub"))
			{
				Transform subitem = (Transform)obj;
				bool flag4 = subitem.name == "List" || subitem.name == "Item";
				if (!flag4)
				{
					UnityEngine.Object.Destroy(subitem.gameObject);
				}
			}
			bool flag5 = Main;
			if (flag5)
			{
				base.transform.Find("Main/TooltipItem/content/title/text").GetComponent<TMP_Text>().SetText(this.title);
				base.transform.Find("Main/TooltipItem/content/text").GetComponent<TMP_Text>().SetText(this.text);
				bool flag6 = string.IsNullOrEmpty(this.msg);
				if (flag6)
				{
					base.transform.Find("Main/Description").gameObject.SetActive(false);
				}
				else
				{
					base.transform.Find("Main/Description").gameObject.SetActive(true);
					base.transform.Find("Main/Description/content/text").GetComponent<TMP_Text>().SetText(this.msg);
				}
				bool flag7 = this.icon == null || this.icon.texture == null;
				if (flag7)
				{
					bool flag8 = string.IsNullOrEmpty(this.type);
					if (flag8)
					{
						base.transform.Find("Main/TooltipItem/content/title/icon").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/Item/占位符", true);
					}
					else
					{
						base.transform.Find("Main/TooltipItem/content/title/icon").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/Item/" + this.type, true);
					}
				}
				else
				{
					base.transform.Find("Main/TooltipItem/content/title/icon").GetComponent<Image>().sprite = this.icon;
				}
				bool flag9 = string.IsNullOrEmpty(this.type);
				if (flag9)
				{
					base.transform.Find("Main/TooltipItem/content/title/type").gameObject.SetActive(false);
				}
				else
				{
					base.transform.Find("Main/TooltipItem/content/title/type").gameObject.SetActive(true);
					base.transform.Find("Main/TooltipItem/content/title/type").GetComponent<TMP_Text>().text = this.type.Localize("Tips");
				}
				Image component = base.transform.Find("Main/TooltipItem/frame").GetComponent<Image>();
				string a = this.type;
				if (!true)
				{
				}
				Sprite sprite;
				if (!(a == "Buff"))
				{
					if (!(a == "Item"))
					{
						if (!(a == "Tag"))
						{
							sprite = this.itemFrame;
						}
						else
						{
							sprite = this.tagFrame;
						}
					}
					else
					{
						sprite = this.itemFrame;
					}
				}
				else
				{
					sprite = this.buffFrame;
				}
				if (!true)
				{
				}
				component.sprite = sprite;
				float textWidth = base.transform.Find("Main/TooltipItem/content/text").GetComponent<TMP_Text>().preferredWidth;
				bool flag10 = textWidth > maxWidth;
				if (flag10)
				{
					string[] lines = this.text.Split('\n', StringSplitOptions.None);
					string newText = "";
					foreach (string line in lines)
					{
						bool flag11 = string.IsNullOrEmpty(line);
						if (flag11)
						{
							newText += "\n";
						}
						else
						{
							newText = newText + this.WrapLine(line, maxWidth, base.transform.Find("Main/TooltipItem/content/text").GetComponent<TMP_Text>()) + "\n";
						}
					}
					newText = newText.TrimEnd('\n');
					base.transform.Find("Main/TooltipItem/content/text").GetComponent<TMP_Text>().SetText(newText);
				}
			}
			bool flag12 = Sub;
			if (flag12)
			{
				Dictionary<string, Dictionary<string, string>> dic = Singleton<TempDataManager>.Instance.keyWordsDic;
				int index = 0;
				List<GameObject> storedObj = new List<GameObject>();
				List<string> distinctKeywords = this.keywords.Distinct<string>().ToList<string>();
				HashSet<string> expanded = new HashSet<string>(distinctKeywords);
				foreach (string keyword in distinctKeywords)
				{
					string rawDesc = (dic[Globals.Language].GetValueOrDefault(keyword, null) ?? dic["Default"].GetValueOrDefault(keyword, "")) + "\n";
					List<string> keywords = new List<string>();
					rawDesc.Description().Highlight(keywords);
					foreach (string i in keywords)
					{
						expanded.Add(i);
					}
				}
				distinctKeywords = expanded.ToList<string>();
				foreach (string keyword2 in distinctKeywords)
				{
					GameObject keywordObj = Singleton<ObjectPool>.Instance.Get(base.transform.Find("Sub/Item").gameObject, base.transform.Find("Sub"));
					string tempText = (dic[Globals.Language].GetValueOrDefault(keyword2, null) ?? dic["Default"].GetValueOrDefault(keyword2, "Text Missing")) + "\n";
					string keywordId = Singleton<TempDataManager>.Instance.keyWordIds.GetValueOrDefault(keyword2);
					string subtype = null;
					Sprite subicon = null;
					bool flag13 = !string.IsNullOrEmpty(keywordId);
					if (flag13)
					{
						Dictionary<string, string> one = Singleton<GameConfigManager>.Instance.GetOne(DataType.KeyWords, keywordId);
						string subiconPath = (one != null) ? one.GetValueOrDefault("Icon") : null;
						Dictionary<string, string> one2 = Singleton<GameConfigManager>.Instance.GetOne(DataType.KeyWords, keywordId);
						subtype = ((one2 != null) ? one2.GetValueOrDefault("Type") : null);
						bool flag14 = !string.IsNullOrEmpty(subiconPath);
						if (flag14)
						{
							subicon = ResourceLoader.Load<Sprite>(subiconPath, true);
						}
					}
					bool flag15 = subicon == null;
					if (flag15)
					{
						keywordObj.transform.Find("content/title/icon").gameObject.SetActive(false);
					}
					else
					{
						keywordObj.transform.Find("content/title/icon").gameObject.SetActive(true);
						keywordObj.transform.Find("content/title/icon").GetComponent<Image>().sprite = subicon;
					}
					List<string> subKw = new List<string>();
					tempText = tempText.Description().Highlight(subKw);
					keywordObj.GetComponent<RectTransform>().pivot = new Vector2((float)((this.state == 1) ? 0 : 1), 0.5f);
					keywordObj.transform.Find("content/text").GetComponent<TMP_Text>().text = tempText;
					keywordObj.transform.Find("content/title/text").GetComponent<TMP_Text>().text = keyword2;
					keywordObj.transform.Find("content/title/").gameObject.SetActive(this.title != "");
					Image component2 = keywordObj.transform.Find("frame").GetComponent<Image>();
					if (!true)
					{
					}
					Sprite sprite;
					if (!(subtype == "Buff"))
					{
						if (!(subtype == "Tag"))
						{
							sprite = this.tagFrame;
						}
						else
						{
							sprite = this.tagFrame;
						}
					}
					else
					{
						sprite = this.buffFrame;
					}
					if (!true)
					{
					}
					component2.sprite = sprite;
					storedObj.Add(keywordObj);
					bool flag16 = storedObj.Count >= 4;
					if (flag16)
					{
						float total = 0f;
						foreach (GameObject item in storedObj)
						{
							bool flag17 = item == null;
							if (!flag17)
							{
								total += item.GetComponent<RectTransform>().sizeDelta.y;
							}
						}
						int j = index;
						this.UpdateLayout(storedObj, j);
						storedObj.Clear();
						index++;
					}
				}
				bool flag18 = storedObj.Count > 0;
				if (flag18)
				{
					this.UpdateLayout(storedObj, index);
					index++;
				}
				this.subWidth = (float)index * this.width + (float)((index - 1) * this.spacingX);
			}
			base.transform.Find("Main").gameObject.SetActive(Main);
			base.transform.Find("Sub").gameObject.SetActive(Sub);
			base.transform.gameObject.SetActive(true);
			UniTask.DelayFrame(2, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				bool activeSelf = base.gameObject.activeSelf;
				if (activeSelf)
				{
					base.transform.GetComponent<CanvasGroup>().DOKill(false);
					base.transform.GetComponent<CanvasGroup>().DOFade(1f, this.transitionTime);
				}
			}).Forget();
		}
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00045E5C File Offset: 0x0004405C
	private void UpdateLayout(List<GameObject> list, int index)
	{
		List<GameObject> storedObj = list.ToList<GameObject>();
		float totalHeight = (float)((storedObj.Count - 1) * this.spacingY);
		UniTask.DelayFrame(1, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
		{
			bool flag = this.obj == null;
			if (!flag)
			{
				foreach (GameObject item in storedObj)
				{
					bool flag2 = item == null;
					if (!flag2)
					{
						totalHeight += item.GetComponent<RectTransform>().sizeDelta.y;
					}
				}
				this.subHeight = Mathf.Max(this.subHeight, totalHeight + (float)(this.spacingY * (storedObj.Count - 1)));
				float nowHeight = totalHeight / 2f;
				foreach (GameObject item2 in storedObj)
				{
					bool flag3 = item2 == null;
					if (!flag3)
					{
						float nowY = nowHeight - item2.GetComponent<RectTransform>().sizeDelta.y / 2f;
						item2.GetComponent<RectTransform>().localPosition = new Vector2((float)index * (this.width + (float)this.spacingX) * (float)this.state, nowY);
						nowHeight = nowY - item2.GetComponent<RectTransform>().sizeDelta.y / 2f - (float)this.spacingY;
					}
				}
			}
		}).Forget();
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00045ECC File Offset: 0x000440CC
	private void LateUpdate()
	{
		bool flag = base.gameObject.activeSelf && this.obj != null;
		if (flag)
		{
			base.transform.localPosition = this.CalculatePosition(this.obj);
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y, 0f);
		}
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00045F4C File Offset: 0x0004414C
	public void Show(Transform obj, string title, string text, List<string> keywords = null, string msg = null, Sprite icon = null, string type = null, bool Main = true, bool Sub = true)
	{
		bool flag = Main && !Sub && string.IsNullOrEmpty(text);
		if (!flag)
		{
			this.title = title;
			this.text = text;
			this.keywords = keywords;
			this.msg = msg;
			this.icon = icon;
			this.type = type;
			this.Show(obj, Main, Sub, 360f);
		}
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00045FB4 File Offset: 0x000441B4
	public void Hide()
	{
		bool flag = this == null;
		if (!flag)
		{
			base.transform.gameObject.SetActive(false);
			CanvasGroup canvasGroup = base.transform.GetComponent<CanvasGroup>();
			bool flag2 = canvasGroup != null;
			if (flag2)
			{
				canvasGroup.DOKill(false);
				canvasGroup.DOFade(0f, 0.5f);
			}
			this.obj = null;
		}
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x0004601C File Offset: 0x0004421C
	private Vector3 CalculatePosition(Transform obj)
	{
		RectTransform rectTransform = base.GetComponent<RectTransform>();
		bool flag = obj.position.x < 0f;
		if (flag)
		{
			rectTransform.pivot = new Vector2(0f, rectTransform.pivot.y);
			base.transform.Find("Main").SetAsFirstSibling();
			this.state = 1;
			foreach (object obj2 in base.transform.Find("Sub"))
			{
				Transform item = (Transform)obj2;
				item.GetComponent<RectTransform>().pivot = new Vector2(0f, 0.5f);
			}
		}
		else
		{
			rectTransform.pivot = new Vector2(1f, rectTransform.pivot.y);
			base.transform.Find("Main").SetAsLastSibling();
			this.state = -1;
			foreach (object obj3 in base.transform.Find("Sub"))
			{
				Transform item2 = (Transform)obj3;
				item2.GetComponent<RectTransform>().pivot = new Vector2(1f, 0.5f);
			}
		}
		Vector2 showPos = obj.position;
		Vector3 screenPoint = Camera.main.WorldToScreenPoint(obj.position);
		Vector2 pos = PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), screenPoint);
		showPos = pos;
		bool flag2 = rectTransform.sizeDelta.x + showPos.x + this.subWidth + (float)(this.spacingX * 2) > this.canvasTf.sizeDelta.x / 2f && this.state == 1;
		if (flag2)
		{
			showPos = new Vector2(-this.canvasTf.sizeDelta.x / 2f, showPos.y);
		}
		else
		{
			bool flag3 = showPos.x - rectTransform.sizeDelta.x - this.subWidth - (float)(this.spacingX * 2) < -this.canvasTf.sizeDelta.x / 2f && this.state == -1;
			if (flag3)
			{
				showPos = new Vector2(this.canvasTf.sizeDelta.x / 2f, showPos.y);
			}
		}
		float maxHeight = Mathf.Max(rectTransform.sizeDelta.y, this.subHeight) / 2f;
		bool flag4 = showPos.y + maxHeight + (float)(this.spacingY * 2) > this.canvasTf.sizeDelta.y / 2f;
		if (flag4)
		{
			showPos = new Vector2(showPos.x, this.canvasTf.sizeDelta.y / 2f - maxHeight);
		}
		else
		{
			bool flag5 = showPos.y - maxHeight - (float)(this.spacingY * 2) < -this.canvasTf.sizeDelta.y / 2f;
			if (flag5)
			{
				showPos = new Vector2(showPos.x, -this.canvasTf.sizeDelta.y / 2f + maxHeight);
			}
		}
		bool flag6 = obj.GetComponent<CardItem>() != null || obj.GetComponent<MapItem>() != null;
		if (flag6)
		{
			RectTransform rect = (RectTransform)obj;
			Vector2 centerInCanvas = PositionUtility.ScreenPointToCanvasPoint(this.canvasTf, Camera.main.WorldToScreenPoint(obj.position));
			Vector2 rightInCanvas = PositionUtility.ScreenPointToCanvasPoint(this.canvasTf, Camera.main.WorldToScreenPoint(rect.TransformPoint(new Vector3(rect.rect.width * 0.5f, 0f, 0f))));
			float halfWidthInCanvas = Mathf.Abs(rightInCanvas.x - centerInCanvas.x);
			showPos.x += (halfWidthInCanvas + (float)this.spacingX) * (float)this.state;
		}
		return new Vector3(showPos.x, showPos.y, 0f);
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00046490 File Offset: 0x00044690
	private string WrapLine(string line, float maxWidth, TMP_Text tmpText)
	{
		tmpText.SetText(line);
		tmpText.ForceMeshUpdate(false, false);
		bool flag = tmpText.preferredWidth <= maxWidth;
		string result2;
		if (flag)
		{
			result2 = line;
		}
		else
		{
			string result = "";
			string currentLine = "";
			int i = 0;
			while (i < line.Length)
			{
				char c = line[i];
				bool flag2 = c == '<';
				string addition;
				if (flag2)
				{
					int tagEnd = line.IndexOf('>', i);
					bool flag3 = tagEnd != -1;
					if (flag3)
					{
						addition = line.Substring(i, tagEnd - i + 1);
						i = tagEnd + 1;
					}
					else
					{
						addition = c.ToString();
						i++;
					}
				}
				else
				{
					addition = c.ToString();
					i++;
				}
				string testLine = currentLine + addition;
				tmpText.SetText(testLine);
				tmpText.ForceMeshUpdate(false, false);
				bool flag4 = tmpText.preferredWidth <= maxWidth;
				if (flag4)
				{
					currentLine = testLine;
				}
				else
				{
					bool flag5 = !string.IsNullOrEmpty(currentLine);
					if (flag5)
					{
						result = result + currentLine + "\n";
					}
					currentLine = addition;
				}
			}
			bool flag6 = !string.IsNullOrEmpty(currentLine);
			if (flag6)
			{
				result += currentLine;
			}
			result2 = result.TrimEnd('\n');
		}
		return result2;
	}

	// Token: 0x04000BFC RID: 3068
	private string text;

	// Token: 0x04000BFD RID: 3069
	private string title;

	// Token: 0x04000BFE RID: 3070
	private string type;

	// Token: 0x04000BFF RID: 3071
	private Sprite icon;

	// Token: 0x04000C00 RID: 3072
	private List<string> keywords;

	// Token: 0x04000C01 RID: 3073
	private Transform obj;

	// Token: 0x04000C02 RID: 3074
	private float width = 300f;

	// Token: 0x04000C03 RID: 3075
	private string msg;

	// Token: 0x04000C04 RID: 3076
	public int spacingX = 10;

	// Token: 0x04000C05 RID: 3077
	public int spacingY = 10;

	// Token: 0x04000C06 RID: 3078
	private int state = 1;

	// Token: 0x04000C07 RID: 3079
	public float subWidth = 0f;

	// Token: 0x04000C08 RID: 3080
	public float subHeight = 0f;

	// Token: 0x04000C09 RID: 3081
	public float transitionTime = 0.15f;

	// Token: 0x04000C0A RID: 3082
	private RectTransform canvasTf;

	// Token: 0x04000C0B RID: 3083
	private static readonly Regex RemoveBraceRegex = new Regex("\\{.*?\\}", RegexOptions.Compiled | RegexOptions.Singleline);

	// Token: 0x04000C0C RID: 3084
	[SerializeField]
	private Sprite buffFrame;

	// Token: 0x04000C0D RID: 3085
	[SerializeField]
	private Sprite tagFrame;

	// Token: 0x04000C0E RID: 3086
	[SerializeField]
	private Sprite itemFrame;
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Witch
{
	// Token: 0x02000258 RID: 600
	public class StoryEditorManager : MonoBehaviour
	{
		// Token: 0x0600133F RID: 4927 RVA: 0x00097220 File Offset: 0x00095420
		private void Awake()
		{
			bool flag = this.addButton != null;
			if (flag)
			{
				this.addButton.onClick.AddListener(new UnityAction(this.OnAddClicked));
			}
			bool flag2 = this.saveButton != null;
			if (flag2)
			{
				this.saveButton.onClick.AddListener(new UnityAction(this.OnSaveClicked));
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00097288 File Offset: 0x00095488
		private void Start()
		{
			bool flag = this.lines.Count == 0;
			if (flag)
			{
				this.AddLine();
			}
			this.RefreshUI();
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000972B6 File Offset: 0x000954B6
		public void OnAddClicked()
		{
			this.AddLine();
			this.RefreshUI();
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000972C8 File Offset: 0x000954C8
		public void AddLine()
		{
			StoryLine line = new StoryLine
			{
				id = this.lines.Count + 1,
				actor = "Actor",
				text = "新台词"
			};
			this.lines.Add(line);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00097312 File Offset: 0x00095512
		public void RemoveLine(StoryLine line)
		{
			this.lines.Remove(line);
			this.RefreshUI();
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0009732C File Offset: 0x0009552C
		private void RefreshUI()
		{
			foreach (StoryRowUI r in this.rowUIs)
			{
				bool flag = r != null;
				if (flag)
				{
					UnityEngine.Object.Destroy(r.gameObject);
				}
			}
			this.rowUIs.Clear();
			for (int i = 0; i < this.lines.Count; i++)
			{
				GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.rowPrefab, this.contentParent);
				go.SetActive(true);
				StoryRowUI row = go.GetComponent<StoryRowUI>();
				bool flag2 = row != null;
				if (flag2)
				{
					row.Initialize(this.lines[i], this);
					this.rowUIs.Add(row);
				}
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00097418 File Offset: 0x00095618
		public void MoveLineUp(StoryLine line)
		{
			int idx = this.lines.IndexOf(line);
			bool flag = idx > 0;
			if (flag)
			{
				StoryLine tmp = this.lines[idx - 1];
				this.lines[idx - 1] = this.lines[idx];
				this.lines[idx] = tmp;
				this.RefreshUI();
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0009747C File Offset: 0x0009567C
		public void MoveLineDown(StoryLine line)
		{
			int idx = this.lines.IndexOf(line);
			bool flag = idx >= 0 && idx < this.lines.Count - 1;
			if (flag)
			{
				StoryLine tmp = this.lines[idx + 1];
				this.lines[idx].id++;
				this.lines[idx + 1].id--;
				this.lines[idx + 1] = this.lines[idx];
				this.lines[idx] = tmp;
				this.RefreshUI();
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00097528 File Offset: 0x00095728
		private void OnSaveClicked()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("id,actor,text,endTime,triTime");
			foreach (StoryLine i in this.lines)
			{
				string actor = this.EscapeCsv(i.actor);
				string text = this.EscapeCsv(i.text);
				string endTime = this.EscapeCsv(i.endTime);
				string triTime = this.EscapeCsv(i.triTime);
				sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", new object[]
				{
					i.id,
					actor,
					text,
					endTime,
					triTime
				}));
			}
			string fileName = this.nameInputField.text + ".csv";
			string path = Path.Combine(Application.persistentDataPath, fileName);
			Debug.Log("Saving CSV to: " + path);
			File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
			Debug.Log("Saved CSV to: " + path);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00097660 File Offset: 0x00095860
		private string EscapeCsv(string s)
		{
			bool flag = string.IsNullOrEmpty(s);
			string result;
			if (flag)
			{
				result = "";
			}
			else
			{
				bool flag2 = s.Contains("\"");
				if (flag2)
				{
					s = s.Replace("\"", "\"\"");
				}
				bool flag3 = s.Contains(",") || s.Contains("\n") || s.Contains("\r") || s.Contains("\"");
				if (flag3)
				{
					result = "\"" + s + "\"";
				}
				else
				{
					result = s;
				}
			}
			return result;
		}

		// Token: 0x04000F9D RID: 3997
		[Header("References")]
		public RectTransform contentParent;

		// Token: 0x04000F9E RID: 3998
		public GameObject rowPrefab;

		// Token: 0x04000F9F RID: 3999
		public Button addButton;

		// Token: 0x04000FA0 RID: 4000
		public Button saveButton;

		// Token: 0x04000FA1 RID: 4001
		private List<StoryLine> lines = new List<StoryLine>();

		// Token: 0x04000FA2 RID: 4002
		private List<StoryRowUI> rowUIs = new List<StoryRowUI>();

		// Token: 0x04000FA3 RID: 4003
		public TMP_InputField nameInputField;
	}
}

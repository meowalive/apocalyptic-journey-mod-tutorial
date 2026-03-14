using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x0200030E RID: 782
	public class IllustratedBookUI : UIBase
	{
		// Token: 0x06001872 RID: 6258 RVA: 0x000CE288 File Offset: 0x000CC488
		[DebuggerStepThrough]
		private void Awake()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(IllustratedBookUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(IllustratedBookUI.Awake()).MethodHandle, typeof(IllustratedBookUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_Awake();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000CE384 File Offset: 0x000CC584
		private void Start()
		{
			this.HidePage();
			foreach (KeyValuePair<string, Dictionary<string, string>> item in this.book)
			{
				string chapter = item.Value["Chapter"];
				bool flag = !this.pageLsit.ContainsKey(chapter);
				if (flag)
				{
					this.pageLsit.Add(chapter, new List<string>());
				}
				this.pageLsit[chapter].Add(item.Value["Id"]);
			}
			foreach (KeyValuePair<string, List<string>> item2 in this.pageLsit)
			{
				GameObject chapterObj = UnityEngine.Object.Instantiate<GameObject>(this.chapterPrefab, base.transform.Find("Window Manager/Windows"));
				GameObject buttonObj = UnityEngine.Object.Instantiate<GameObject>(this.buttonPrefab, base.transform.Find("Window Manager/Buttons"));
				GameObject itemPrefab = chapterObj.transform.Find("Content/ItemList/Scroll Area/List/Item").gameObject;
				chapterObj.name = item2.Key;
				buttonObj.name = item2.Key;
				buttonObj.GetComponent<ButtonManager>().buttonText = item2.Key;
				base.transform.Find("Window Manager").GetComponent<WindowManager>().AddNewItemForEvent(item2.Key, chapterObj, buttonObj);
				using (List<string>.Enumerator enumerator3 = item2.Value.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						string page = enumerator3.Current;
						GameObject itemObj = UnityEngine.Object.Instantiate<GameObject>(itemPrefab, chapterObj.transform.Find("Content/ItemList/Scroll Area/List"));
						itemObj.name = this.book[page]["Name"];
						itemObj.transform.Find("Normal/texts/title").GetComponent<TextMeshProUGUI>().text = this.book[page]["Name"];
						itemObj.transform.Find("Highlight/texts/title").GetComponent<TextMeshProUGUI>().text = this.book[page]["Name"];
						itemObj.transform.Find("Normal/texts/description").GetComponent<TextMeshProUGUI>().text = this.book[page]["Description"];
						itemObj.transform.Find("Highlight/texts/description").GetComponent<TextMeshProUGUI>().text = this.book[page]["Description"];
						itemObj.GetComponent<ButtonManager>().onClick.AddListener(delegate
						{
							this.ShowPage(page);
						});
						itemObj.SetActive(true);
					}
				}
				chapterObj.SetActive(true);
				buttonObj.SetActive(true);
				UnityEngine.Object.Destroy(itemPrefab);
			}
			UnityEngine.Object.Destroy(this.chapterPrefab);
			UnityEngine.Object.Destroy(this.buttonPrefab);
			base.transform.Find("Window Manager").GetComponent<WindowManager>().windows.RemoveAt(0);
			base.transform.Find("Window Manager").GetComponent<WindowManager>().InitializeWindows();
			base.transform.Find("Window Manager").GetComponent<WindowManager>().OpenWindowByIndex(0);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000CE778 File Offset: 0x000CC978
		[DebuggerStepThrough]
		private void ShowPage(string page)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(IllustratedBookUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(IllustratedBookUI.ShowPage(string)).MethodHandle, typeof(IllustratedBookUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				page
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							page = null;
						}
						else
						{
							page = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowPage(page);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_FD;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_FD:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000CE8AC File Offset: 0x000CCAAC
		[DebuggerStepThrough]
		private void HidePage()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(IllustratedBookUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(IllustratedBookUI.HidePage()).MethodHandle, typeof(IllustratedBookUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_HidePage();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000CE9C8 File Offset: 0x000CCBC8
		private void $Rougamo_Awake()
		{
			base.transform.Find("Close").GetComponent<ButtonManager>().onClick.AddListener(delegate
			{
				this.Close();
			});
			this.book = Singleton<GameConfigManager>.Instance.GetDataByPrefix(Singleton<GameConfigManager>.Instance.GetTable(DataType.IllustraedBook).Getlines(), "gameguide");
			this.chapterPrefab = base.transform.Find("Window Manager/Windows/章节").gameObject;
			this.buttonPrefab = base.transform.Find("Window Manager/Buttons/章节").gameObject;
			this.MsgContent = base.transform.Find("Window Manager/MsgContent").GetComponent<RectTransform>();
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000CEA7C File Offset: 0x000CCC7C
		private void $Rougamo_ShowPage(string page)
		{
			this.MsgContent.Find("title").GetComponent<TextMeshProUGUI>().text = this.book[page]["Name"];
			this.MsgContent.Find("tip").GetComponent<TextMeshProUGUI>().text = this.book[page]["Tip"];
			this.MsgContent.Find("text").GetComponent<TextMeshProUGUI>().text = this.book[page]["Text"];
			TextWithKeyword tmp = this.MsgContent.Find("text").GetComponent<TextWithKeyword>();
			tmp.Init();
			this.MsgContent.gameObject.SetActive(true);
			this.lastPage = page;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000CEB53 File Offset: 0x000CCD53
		private void $Rougamo_HidePage()
		{
			this.MsgContent.gameObject.SetActive(false);
		}

		// Token: 0x0400132C RID: 4908
		private Dictionary<string, Dictionary<string, string>> book;

		// Token: 0x0400132D RID: 4909
		private Dictionary<string, List<string>> pageLsit = new Dictionary<string, List<string>>();

		// Token: 0x0400132E RID: 4910
		private GameObject chapterPrefab;

		// Token: 0x0400132F RID: 4911
		private GameObject buttonPrefab;

		// Token: 0x04001330 RID: 4912
		public RectTransform MsgContent;

		// Token: 0x04001331 RID: 4913
		private string lastPage = "invalid";
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000291 RID: 657
	public class AnnouncementUI : TutorialUI
	{
		// Token: 0x060014A6 RID: 5286 RVA: 0x000A29AC File Offset: 0x000A0BAC
		[DebuggerStepThrough]
		public void ShowAnnouncement()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(AnnouncementUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AnnouncementUI.ShowAnnouncement()).MethodHandle, typeof(AnnouncementUI).TypeHandle);
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
							this.$Rougamo_ShowAnnouncement();
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

		// Token: 0x060014A8 RID: 5288 RVA: 0x000A2AB4 File Offset: 0x000A0CB4
		private void $Rougamo_ShowAnnouncement()
		{
			List<Dictionary<string, string>> TempList = new List<Dictionary<string, string>>(Singleton<GameConfigManager>.Instance.GetTable(DataType.Announcement).Getlines());
			for (int i = 0; i < TempList.Count; i++)
			{
				Dictionary<string, string> tutorial = TempList[i];
				Dictionary<string, string> tempData = tutorial;
				GameObject item = UnityEngine.Object.Instantiate<GameObject>(this.ItemPrefab, this.ItemPrefab.transform.parent);
				item.SetActive(true);
				item.GetComponent<ButtonManager>().SetText(tutorial["Name"]);
				bool flag = i == TempList.Count - 1;
				if (flag)
				{
					item.GetComponent<ButtonManager>().SetIcon(this.SelectSprite);
					this.windowPrefab.transform.Find("Description/ScrollRect/Content/text").GetComponent<TMP_Text>().text = tempData["Description"];
					this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(tempData["Image"], true);
					this.LastWindow = item;
				}
				item.GetComponent<ButtonManager>().onClick.AddListener(delegate
				{
					bool flag3 = this.LastWindow != null;
					if (flag3)
					{
						this.LastWindow.GetComponent<ButtonManager>().SetIcon(this.UnselectSprite);
					}
					this.windowPrefab.transform.Find("Description/ScrollRect/Content/text").GetComponent<TMP_Text>().text = tempData["Description"];
					this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(tempData["Image"], true);
					this.windowPrefab.transform.Find("Description/image").GetComponent<RectTransform>().sizeDelta = new Vector2((float)this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite.texture.width, (float)this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite.texture.height);
					this.LastWindow = item;
					this.LastWindow.GetComponent<ButtonManager>().SetIcon(this.SelectSprite);
				});
			}
			bool flag2 = TempList.Count == 0;
			if (flag2)
			{
				this.Close();
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x02000335 RID: 821
	public class TutorialUI : UIBase
	{
		// Token: 0x060019CE RID: 6606 RVA: 0x000DA244 File Offset: 0x000D8444
		[DebuggerStepThrough]
		public void Awake()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TutorialUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TutorialUI.Awake()).MethodHandle, typeof(TutorialUI).TypeHandle);
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

		// Token: 0x060019CF RID: 6607 RVA: 0x000DA340 File Offset: 0x000D8540
		public void ShowTutorial(string id = "")
		{
			bool flag = id != "";
			if (flag)
			{
				Singleton<GameRuntimeData>.Instance.TutorialData[id] = "TRUE";
			}
			List<Dictionary<string, string>> TempList = new List<Dictionary<string, string>>((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Tutorial).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			where Singleton<GameRuntimeData>.Instance.TutorialData[x["Id"]] == "TRUE"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>());
			using (List<Dictionary<string, string>>.Enumerator enumerator = TempList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TutorialUI.<>c__DisplayClass6_0 CS$<>8__locals1 = new TutorialUI.<>c__DisplayClass6_0();
					CS$<>8__locals1.<>4__this = this;
					CS$<>8__locals1.tutorial = enumerator.Current;
					Dictionary<string, string> tempData = CS$<>8__locals1.tutorial;
					GameObject item = UnityEngine.Object.Instantiate<GameObject>(this.ItemPrefab, this.ItemPrefab.transform.parent);
					item.SetActive(true);
					item.GetComponent<ButtonManager>().SetLocalizedText(() => CS$<>8__locals1.tutorial.Localize("Name"));
					bool flag2 = CS$<>8__locals1.tutorial["Id"] == id;
					if (flag2)
					{
						item.GetComponent<ButtonManager>().SetIcon(this.SelectSprite);
						this.windowPrefab.transform.Find("Description/ScrollRect/Content/text").GetComponent<TMP_Text>().SetLocalizedText(() => tempData.Localize("Description"));
						this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(tempData["Image"], true);
						this.windowPrefab.transform.Find("Description/image").GetComponent<RectTransform>().sizeDelta = new Vector2((float)this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite.texture.width, (float)this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite.texture.height);
						this.LastWindow = item;
						UniTask.DelayFrame(3, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
						{
							this.windowPrefab.transform.Find("Description/Scrollbar").GetComponent<Scrollbar>().value = 1f;
						}).Forget();
					}
					Func<string> <>9__5;
					item.GetComponent<ButtonManager>().onClick.AddListener(delegate
					{
						bool flag3 = CS$<>8__locals1.<>4__this.LastWindow != null;
						if (flag3)
						{
							CS$<>8__locals1.<>4__this.LastWindow.GetComponent<ButtonManager>().SetIcon(CS$<>8__locals1.<>4__this.UnselectSprite);
						}
						TMP_Text component = CS$<>8__locals1.<>4__this.windowPrefab.transform.Find("Description/ScrollRect/Content/text").GetComponent<TMP_Text>();
						Func<string> localized;
						if ((localized = <>9__5) == null)
						{
							localized = (<>9__5 = (() => tempData.Localize("Description")));
						}
						component.SetLocalizedText(localized);
						CS$<>8__locals1.<>4__this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(tempData["Image"], true);
						CS$<>8__locals1.<>4__this.windowPrefab.transform.Find("Description/image").GetComponent<RectTransform>().sizeDelta = new Vector2((float)CS$<>8__locals1.<>4__this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite.texture.width, (float)CS$<>8__locals1.<>4__this.windowPrefab.transform.Find("Description/image").GetComponent<Image>().sprite.texture.height);
						CS$<>8__locals1.<>4__this.LastWindow = item;
						CS$<>8__locals1.<>4__this.LastWindow.GetComponent<ButtonManager>().SetIcon(CS$<>8__locals1.<>4__this.SelectSprite);
						UniTask.DelayFrame(3, PlayerLoopTiming.Update, CS$<>8__locals1.<>4__this.destroyCancellationToken, false).ContinueWith(delegate()
						{
							CS$<>8__locals1.<>4__this.windowPrefab.transform.Find("Description/Scrollbar").GetComponent<Scrollbar>().value = 1f;
						}).Forget();
					});
				}
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x000DA604 File Offset: 0x000D8804
		[DebuggerStepThrough]
		private void Update()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TutorialUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TutorialUI.Update()).MethodHandle, typeof(TutorialUI).TypeHandle);
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
							this.$Rougamo_Update();
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

		// Token: 0x060019D4 RID: 6612 RVA: 0x000DA728 File Offset: 0x000D8928
		private void $Rougamo_Awake()
		{
			this.windowPrefab = base.transform.Find("Windows/WindowPrefab").gameObject;
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x000A21B3 File Offset: 0x000A03B3
		private void $Rougamo_Update()
		{
			base.transform.SetAsLastSibling();
		}

		// Token: 0x040013BC RID: 5052
		protected GameObject windowPrefab;

		// Token: 0x040013BD RID: 5053
		public GameObject ItemPrefab;

		// Token: 0x040013BE RID: 5054
		protected GameObject LastWindow;

		// Token: 0x040013BF RID: 5055
		public Sprite SelectSprite;

		// Token: 0x040013C0 RID: 5056
		public Sprite UnselectSprite;
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization.Components;
using UnityEngine.SceneManagement;
using Witch.UI.Window;

namespace Witch.UI
{
	// Token: 0x02000264 RID: 612
	public class UIManager : MonoBehaviour
	{
		// Token: 0x0600138F RID: 5007 RVA: 0x00099D88 File Offset: 0x00097F88
		public void Awake()
		{
			UIManager.Instance = this;
			this.canvasTf = GameObject.Find("Canvas").transform;
			this.upperCanvasTf = GameObject.Find("Upper Canvas").transform;
			this.effectContent = GameObject.Find("effect").transform;
			this.tooltip = this.canvasTf.transform.Find("Tooltip").GetComponent<Tooltip>();
			this.progressBar = this.canvasTf.transform.Find("ProgressBar").GetComponent<ProgressBar>();
			this.floatingWindow = this.canvasTf.transform.Find("Floating Window").GetComponent<FloatingWindow>();
			this.animationManager = AnimationManager.Instance;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00099E48 File Offset: 0x00098048
		[DebuggerStepThrough]
		public UniTask<T> ShowUIAsync<T>(string uiName, bool pureUI = true) where T : UIBase
		{
			UIManager.<ShowUIAsync>d__13<T> <ShowUIAsync>d__ = new UIManager.<ShowUIAsync>d__13<T>();
			<ShowUIAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<ShowUIAsync>d__.<>4__this = this;
			<ShowUIAsync>d__.uiName = uiName;
			<ShowUIAsync>d__.pureUI = pureUI;
			<ShowUIAsync>d__.<>1__state = -1;
			<ShowUIAsync>d__.<>t__builder.Start<UIManager.<ShowUIAsync>d__13<T>>(ref <ShowUIAsync>d__);
			return <ShowUIAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00099E9C File Offset: 0x0009809C
		public T ShowUI<T>(string uiName, bool pureUI = true) where T : UIBase
		{
			T ui = this.GetUI<T>(uiName);
			bool flag = !pureUI;
			if (flag)
			{
				GameApp.Instance.NowBackground.SetActive(false);
			}
			bool flag2 = ui == null;
			if (flag2)
			{
				GameObject obj = pureUI ? (UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/" + uiName), this.canvasTf) as GameObject) : (UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/Scene/" + uiName)) as GameObject);
				obj.name = uiName;
				bool flag3 = obj.GetComponent<T>() == null;
				if (flag3)
				{
					ui = obj.AddComponent<T>();
				}
				else
				{
					ui = obj.GetComponent<T>();
				}
				ui.isScene = !pureUI;
				ui.FadeIn();
				this.uiList.Add(uiName, ui);
				ui.RegisterEvent();
			}
			else
			{
				ui.Show();
			}
			return ui;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00099FA8 File Offset: 0x000981A8
		public void HideUI(string uiName)
		{
			UIBase ui = this.Find(uiName);
			bool flag = ui != null;
			if (flag)
			{
				ui.Hide();
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00099FD4 File Offset: 0x000981D4
		public void CloseAllUI()
		{
			foreach (KeyValuePair<string, UIBase> ui in this.uiList)
			{
				UnityEngine.Object.Destroy(ui.Value.gameObject);
			}
			this.uiList.Clear();
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0009A044 File Offset: 0x00098244
		public void CloseUI(string uiName)
		{
			UIBase ui = this.Find(uiName);
			bool flag = ui != null;
			if (flag)
			{
				ui.Close();
				ui.StopAllCoroutines();
			}
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0009A078 File Offset: 0x00098278
		public UIBase Find(string uiName)
		{
			UIBase ui;
			return this.uiList.TryGetValue(uiName, out ui) ? ui : null;
		}

		/// <summary> 从列表中移除指定 UI（由 UI 在 Close 等时调用，不销毁 GameObject） </summary>
		// Token: 0x06001396 RID: 5014 RVA: 0x0009A09E File Offset: 0x0009829E
		public void RemoveUI(string uiName)
		{
			this.uiList.Remove(uiName);
		}

		/// <summary> 获取当前已加载的所有 UI（只读遍历） </summary>
		// Token: 0x06001397 RID: 5015 RVA: 0x0009A0AE File Offset: 0x000982AE
		public IEnumerable<UIBase> GetAllUI()
		{
			return this.uiList.Values;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0009A0BC File Offset: 0x000982BC
		public T GetUI<T>(string uiName) where T : UIBase
		{
			UIBase ui = this.Find(uiName);
			bool flag = ui != null;
			T result;
			if (flag)
			{
				result = ui.GetComponent<T>();
			}
			else
			{
				result = default(T);
			}
			return result;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0009A0F4 File Offset: 0x000982F4
		public void RegisterExitButton(ExitButton button)
		{
			bool flag = !this.exitButtons.Contains(button);
			if (flag)
			{
				this.exitButtons.Add(button);
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0009A124 File Offset: 0x00098324
		public void UnregisterExitButton(ExitButton button)
		{
			bool flag = this.exitButtons.Contains(button);
			if (flag)
			{
				this.exitButtons.Remove(button);
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0009A154 File Offset: 0x00098354
		public List<ExitButton> GetAllExitButtons()
		{
			return (from button in this.exitButtons
			where !button.IsNull("Object")
			select button).ToList<ExitButton>();
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0009A198 File Offset: 0x00098398
		private static int NormalizePopupDamage(string damageText)
		{
			return Math.Max(1, damageText.ToInt());
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0009A1B8 File Offset: 0x000983B8
		private static int GetNextPopupDamageValue(int current, int target, float animationTime)
		{
			bool flag = current == target;
			int result;
			if (flag)
			{
				result = current;
			}
			else
			{
				double safeAnimationTime = (double)Math.Max(0.0001f, animationTime);
				long delta = (long)target - (long)current;
				long step = Math.Max(1L, (long)Math.Floor((double)Math.Abs(delta) / safeAnimationTime * (double)Time.deltaTime));
				long nextValue = (long)current + (long)Math.Sign(delta) * step;
				result = ((delta > 0L) ? ((int)Math.Min(nextValue, (long)target)) : ((int)Math.Max(nextValue, (long)target)));
			}
			return result;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0009A234 File Offset: 0x00098434
		public GameObject CreateActionIcon()
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/ActionMsg"), this.canvasTf) as GameObject;
			obj.transform.SetAsFirstSibling();
			return obj;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0009A270 File Offset: 0x00098470
		public GameObject CreateActionContent()
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/ActionContent"), this.canvasTf) as GameObject;
			obj.transform.SetAsFirstSibling();
			return obj;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0009A2AC File Offset: 0x000984AC
		public GameObject CreateEffectList()
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/EffectList"), this.canvasTf) as GameObject;
			obj.transform.SetAsFirstSibling();
			return obj;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0009A2E8 File Offset: 0x000984E8
		public GameObject CreateHPItem()
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/HpItem"), this.canvasTf) as GameObject;
			obj.transform.SetAsFirstSibling();
			return obj;
		}

		/// <summary>
		/// 创建一个buff栏
		/// </summary>
		/// <returns></returns>
		// Token: 0x060013A2 RID: 5026 RVA: 0x0009A324 File Offset: 0x00098524
		public GameObject CreateBuffBarItem()
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/BuffBarUI"), this.canvasTf) as GameObject;
			obj.AddComponent<BuffBarUI>();
			obj.transform.SetAsFirstSibling();
			return obj;
		}

		/// <summary>
		/// 创建一个状态栏
		/// </summary>
		/// <param name="Status">当前状态栏要绑定的StatusManager</param>
		/// <returns></returns>
		// Token: 0x060013A3 RID: 5027 RVA: 0x0009A368 File Offset: 0x00098568
		public GameObject CreateStatusBarItem()
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/StatusBarUI"), this.canvasTf) as GameObject;
			obj.transform.SetAsFirstSibling();
			return obj;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0009A3A4 File Offset: 0x000985A4
		public DialogueBox CreateDialogueBox()
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/Widget/DialogueBox"), this.canvasTf) as GameObject;
			obj.transform.SetAsLastSibling();
			obj.name = "DialogueBox";
			return obj.GetComponent<DialogueBox>();
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0009A3F0 File Offset: 0x000985F0
		public void CheckUI()
		{
			bool flag = this.GetUI<SettingUI>("SettingUI") != null;
			if (flag)
			{
				this.GetUI<SettingUI>("SettingUI").transform.SetAsLastSibling();
			}
			bool flag2 = this.GetUI<OutDeckUI>("OutDeckUI") != null;
			if (flag2)
			{
				this.GetUI<OutDeckUI>("OutDeckUI").transform.SetAsLastSibling();
			}
			bool flag3 = this.GetUI<BackpackUI>("BackpackUI") != null;
			if (flag3)
			{
				this.GetUI<BackpackUI>("BackpackUI").transform.SetAsLastSibling();
			}
			bool flag4 = this.GetUI<DictionaryUI>("DictionaryUI") != null;
			if (flag4)
			{
				this.GetUI<DictionaryUI>("DictionaryUI").transform.SetAsLastSibling();
			}
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0009A4B4 File Offset: 0x000986B4
		public void ShowTip(string msg, Action callback = null)
		{
			CaptionUI caption = this.GetUI<CaptionUI>("CaptionUI");
			bool flag = caption != null;
			if (flag)
			{
				caption.ShowCaption(msg, CaptionStyle.Top, 3f, 1.5f, 3);
			}
			if (callback != null)
			{
				callback();
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0009A4FC File Offset: 0x000986FC
		public void PopUpTextInit()
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/PopUpTextUI"), this.canvasTf) as GameObject;
			foreach (object obj2 in obj.transform)
			{
				Transform childs = (Transform)obj2;
				childs.GetComponent<PopUpTextUI>().isDestroy = false;
				childs.transform.position = new Vector2(100f, 100f);
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0009A59C File Offset: 0x0009879C
		[DebuggerStepThrough]
		public UniTask<PopUpTextUI> ShowPopUpText(string TextType, string val, Vector2 pos)
		{
			UIManager.<ShowPopUpText>d__37 <ShowPopUpText>d__ = new UIManager.<ShowPopUpText>d__37();
			<ShowPopUpText>d__.<>t__builder = AsyncUniTaskMethodBuilder<PopUpTextUI>.Create();
			<ShowPopUpText>d__.<>4__this = this;
			<ShowPopUpText>d__.TextType = TextType;
			<ShowPopUpText>d__.val = val;
			<ShowPopUpText>d__.pos = pos;
			<ShowPopUpText>d__.<>1__state = -1;
			<ShowPopUpText>d__.<>t__builder.Start<UIManager.<ShowPopUpText>d__37>(ref <ShowPopUpText>d__);
			return <ShowPopUpText>d__.<>t__builder.Task;
		}

		/// <summary>
		/// 显示伤害数字
		/// </summary>
		/// <param name="TextType"></param>
		/// <param name="baseDamage"></param>
		/// <param name="status"></param>
		/// <param name="pos"></param>
		// Token: 0x060013A9 RID: 5033 RVA: 0x0009A5F8 File Offset: 0x000987F8
		[DebuggerStepThrough]
		public UniTask ShowPopUpDamage(string TextType, string baseDamage, StatusManager status, Vector2 pos, string realDamage)
		{
			UIManager.<ShowPopUpDamage>d__38 <ShowPopUpDamage>d__ = new UIManager.<ShowPopUpDamage>d__38();
			<ShowPopUpDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowPopUpDamage>d__.<>4__this = this;
			<ShowPopUpDamage>d__.TextType = TextType;
			<ShowPopUpDamage>d__.baseDamage = baseDamage;
			<ShowPopUpDamage>d__.status = status;
			<ShowPopUpDamage>d__.pos = pos;
			<ShowPopUpDamage>d__.realDamage = realDamage;
			<ShowPopUpDamage>d__.<>1__state = -1;
			<ShowPopUpDamage>d__.<>t__builder.Start<UIManager.<ShowPopUpDamage>d__38>(ref <ShowPopUpDamage>d__);
			return <ShowPopUpDamage>d__.<>t__builder.Task;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0009A664 File Offset: 0x00098864
		public void ShowEventUI(string id)
		{
			GameApp.Instance.NowBackground.SetActive(false);
			EventUI eventUI = this.ShowUI<EventUI>("EventUI", true);
			eventUI.FadeIn();
			eventUI.Init(id);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0009A6A0 File Offset: 0x000988A0
		public void ShowEventUIWithTurn<T>(string firstUI, string id) where T : UIBase
		{
			InkTurnUI ui = this.ShowUI<InkTurnUI>("InkTurnUI", true);
			ui.Play(delegate()
			{
				this.CloseUI(firstUI);
			}, delegate()
			{
				this.ShowEventUI(id);
			});
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0009A6F8 File Offset: 0x000988F8
		public void ShowUIWithLoading<T>(string uiName) where T : UIBase
		{
			SceneTurnUI ui = this.ShowUI<SceneTurnUI>("SceneTurnUI", true);
			this.ShowUI<T>(uiName, true);
			ui.Close();
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0009A724 File Offset: 0x00098924
		public void ShowUIWithTurn<T>(string firstUI, string secondUI) where T : UIBase
		{
			InkTurnUI ui = this.ShowUI<InkTurnUI>("InkTurnUI", true);
			ui.Play(delegate()
			{
				this.CloseUI(firstUI);
			}, delegate()
			{
				this.ShowUI<T>(secondUI, true);
			});
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0009A77C File Offset: 0x0009897C
		public void DoWithTurn(Action action)
		{
			InkTurnUI ui = this.ShowUI<InkTurnUI>("InkTurnUI", true);
			ui.FastPlay(delegate
			{
				action();
			}, null);
		}

		/// <summary>
		/// 显示弹窗
		/// </summary>
		/// <param name="title">标题</param>
		/// <param name="text">文本</param>
		/// <param name="onConfirm">确定键的回调</param>
		/// <param name="typeSpeed">打字机速度</param>
		/// <param name="onCancel">取消时的回调</param>
		/// <param name="hasConfirm">是否存在确认按钮？</param>
		/// <param name="hasCancel">是否存在取消按钮？</param>
		// Token: 0x060013AF RID: 5039 RVA: 0x0009A7B8 File Offset: 0x000989B8
		public ModalWindowManager ShowModalWindow(string title, string text, UnityAction onConfirm = null, float typeSpeed = 0f, UnityAction onCancel = null, bool hasConfirm = true, bool hasCancel = true, string confirmText = "Yes", string cancelText = "No", bool mustChoose = true)
		{
			bool flag = onConfirm == null && onCancel == null;
			if (flag)
			{
				hasCancel = false;
			}
			bool flag2 = this.WindowObj != null;
			ModalWindowManager result;
			if (flag2)
			{
				result = this.WindowObj.GetComponent<ModalWindowManager>();
			}
			else
			{
				bool flag3 = UIManager.Instance.GetUI<ConsoleUI>("ConsoleUI") != null;
				if (flag3)
				{
					UIManager.Instance.GetUI<ConsoleUI>("ConsoleUI").Hide();
				}
				GameObject[] roots = SceneManager.GetActiveScene().GetRootGameObjects();
				foreach (GameObject item in roots)
				{
					bool flag4 = item.name == "Upper Canvas";
					if (!flag4)
					{
						CanvasGroup cg;
						bool flag5 = item.TryGetComponent<CanvasGroup>(out cg);
						if (flag5)
						{
							cg.blocksRaycasts = false;
						}
					}
				}
				GameObject modalWindowObj = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load<GameObject>("UI/ModalWindow", true), this.upperCanvasTf);
				ModalWindowManager modalWindow = modalWindowObj.GetComponent<ModalWindowManager>();
				text = text.Localize("Tips");
				title = title.Localize("Tips");
				modalWindow.descriptionText = "";
				modalWindow.titleText = title;
				LocalizeStringEvent Localize = modalWindow.gameObject.AddComponent<LocalizeStringEvent>();
				LocalizeStringEvent Localize2 = modalWindow.gameObject.AddComponent<LocalizeStringEvent>();
				Localize.SetEntry(text);
				Localize2.SetEntry(title);
				Localize.SetTable("Tips");
				Localize2.SetTable("Tips");
				Localize.OnUpdateString.AddListener(delegate(string value)
				{
					text = value;
				});
				Localize2.OnUpdateString.AddListener(delegate(string value)
				{
					modalWindow.titleText = value;
				});
				DOTween.To(() => modalWindow.descriptionText, delegate(string x)
				{
					modalWindow.descriptionText = x;
				}, text, typeSpeed).OnUpdate(delegate
				{
					modalWindow.UpdateUI();
				}).OnComplete(delegate
				{
					modalWindow.descriptionText = text;
				});
				bool flag6 = !hasConfirm;
				if (flag6)
				{
					modalWindow.confirmButton.gameObject.SetActive(false);
					modalWindow.confirmButton = null;
					modalWindow.onConfirm = new UnityEvent();
					modalWindow.cancelButton.gameObject.SetActive(true);
				}
				else
				{
					modalWindow.confirmButton.GetComponent<ButtonManager>().SetText(confirmText.Localize("Tips"));
				}
				bool flag7 = !hasCancel;
				if (flag7)
				{
					modalWindow.cancelButton.gameObject.SetActive(false);
					modalWindow.cancelButton = null;
					modalWindow.onCancel = new UnityEvent();
				}
				else
				{
					modalWindow.cancelButton.GetComponent<ButtonManager>().SetText(cancelText.Localize("Tips"));
				}
				bool flag8 = onConfirm != null;
				if (flag8)
				{
					modalWindow.onConfirm.AddListener(onConfirm);
				}
				bool flag9 = onCancel != null;
				if (flag9)
				{
					modalWindow.onCancel.AddListener(onCancel);
				}
				modalWindow.mustChoose = mustChoose;
				modalWindow.onConfirm.AddListener(delegate
				{
					GameObject[] roots2 = SceneManager.GetActiveScene().GetRootGameObjects();
					foreach (GameObject item2 in roots2)
					{
						bool flag10 = item2.name == "Upper Canvas";
						if (!flag10)
						{
							CanvasGroup cg2;
							bool flag11 = item2.TryGetComponent<CanvasGroup>(out cg2);
							if (flag11)
							{
								cg2.blocksRaycasts = true;
							}
						}
					}
				});
				this.WindowObj = modalWindowObj;
				modalWindow.UpdateUI();
				result = modalWindow;
			}
			return result;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0009AB48 File Offset: 0x00098D48
		[DebuggerStepThrough]
		public UniTask ShowWaitingUI(string title, string text, Func<bool> cancelCondition)
		{
			UIManager.<ShowWaitingUI>d__45 <ShowWaitingUI>d__ = new UIManager.<ShowWaitingUI>d__45();
			<ShowWaitingUI>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowWaitingUI>d__.<>4__this = this;
			<ShowWaitingUI>d__.title = title;
			<ShowWaitingUI>d__.text = text;
			<ShowWaitingUI>d__.cancelCondition = cancelCondition;
			<ShowWaitingUI>d__.<>1__state = -1;
			<ShowWaitingUI>d__.<>t__builder.Start<UIManager.<ShowWaitingUI>d__45>(ref <ShowWaitingUI>d__);
			return <ShowWaitingUI>d__.<>t__builder.Task;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0009ABA4 File Offset: 0x00098DA4
		public void ShowItemShowUI(Sprite icon, string title, string description, string tips = null)
		{
			bool flag = !this.waitingQueue.ContainsKey("ItemShowUI");
			int index;
			if (flag)
			{
				this.waitingQueue.Add("ItemShowUI", new Queue<string>());
				index = 1;
			}
			else
			{
				index = ((this.waitingQueue["ItemShowUI"].Count > 0) ? (this.waitingQueue["ItemShowUI"].Last<string>().ToInt() + 1) : 1);
			}
			this.waitingQueue["ItemShowUI"].Enqueue(index.ToString());
			UniTask.WaitUntil(() => this.waitingQueue["ItemShowUI"].First<string>() == index.ToString() && this.Find("ItemShowUI") == null, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				this.ShowUI<ItemShowUI>("ItemShowUI", true).ShowItem(icon, title, description, tips);
				this.waitingQueue["ItemShowUI"].Dequeue();
				this.GetUI<ItemShowUI>("ItemShowUI").transform.SetAsLastSibling();
			}).Forget();
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0009ACA4 File Offset: 0x00098EA4
		public Tooltip GetTooltip()
		{
			return this.tooltip;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0009ACBC File Offset: 0x00098EBC
		public ProgressBar GetProgressBar()
		{
			return this.progressBar;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0009ACD4 File Offset: 0x00098ED4
		public void ShowNotification(string Title, string Description, float delay = 2f)
		{
			NotificationManager notification = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load<GameObject>("UI/Widget/Notification", true), this.canvasTf).GetComponent<NotificationManager>();
			notification.title = Title;
			notification.description = Description;
			notification.timer = delay;
			notification.UpdateUI();
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0009AD1A File Offset: 0x00098F1A
		public void EndNotification()
		{
			this.canvasTf.GetComponent<NotificationStacking>().ClearStack();
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0009AD2E File Offset: 0x00098F2E
		public void HideFloatingWindow()
		{
			this.floatingWindow.Hide();
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0009AD40 File Offset: 0x00098F40
		public FloatingWindow GetFloatingWindow()
		{
			return this.floatingWindow;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0009AD58 File Offset: 0x00098F58
		public AnimationManager GetAnimationManage()
		{
			return this.animationManager;
		}

		// Token: 0x04000FCE RID: 4046
		public static UIManager Instance;

		// Token: 0x04000FCF RID: 4047
		public Transform canvasTf;

		// Token: 0x04000FD0 RID: 4048
		public Transform upperCanvasTf;

		// Token: 0x04000FD1 RID: 4049
		public Transform effectContent;

		// Token: 0x04000FD2 RID: 4050
		public GameObject WindowObj;

		// Token: 0x04000FD3 RID: 4051
		private Dictionary<string, UIBase> uiList = new Dictionary<string, UIBase>();

		// Token: 0x04000FD4 RID: 4052
		private Tooltip tooltip;

		// Token: 0x04000FD5 RID: 4053
		private ProgressBar progressBar;

		// Token: 0x04000FD6 RID: 4054
		private FloatingWindow floatingWindow;

		// Token: 0x04000FD7 RID: 4055
		private AnimationManager animationManager;

		// Token: 0x04000FD8 RID: 4056
		private Dictionary<string, Queue<string>> waitingQueue = new Dictionary<string, Queue<string>>();

		// Token: 0x04000FD9 RID: 4057
		private List<ExitButton> exitButtons = new List<ExitButton>();
	}
}

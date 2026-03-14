using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.VFX;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000013 RID: 19
public class CardItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, ICard, ILocalize
{
	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000068 RID: 104 RVA: 0x00004653 File Offset: 0x00002853
	// (set) Token: 0x06000069 RID: 105 RVA: 0x0000465B File Offset: 0x0000285B
	public Vector3 initAngle { get; set; }

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600006A RID: 106 RVA: 0x00004664 File Offset: 0x00002864
	// (set) Token: 0x0600006B RID: 107 RVA: 0x0000466C File Offset: 0x0000286C
	public Vector2 initPosition { get; set; }

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600006C RID: 108 RVA: 0x00004675 File Offset: 0x00002875
	// (set) Token: 0x0600006D RID: 109 RVA: 0x0000467D File Offset: 0x0000287D
	public bool draging { get; set; }

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600006E RID: 110 RVA: 0x00004686 File Offset: 0x00002886
	// (set) Token: 0x0600006F RID: 111 RVA: 0x0000468E File Offset: 0x0000288E
	public bool ignore { get; set; }

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000070 RID: 112 RVA: 0x00004697 File Offset: 0x00002897
	public float initScale
	{
		get
		{
			return 0.6f;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000071 RID: 113 RVA: 0x0000469E File Offset: 0x0000289E
	public float selectScale
	{
		get
		{
			return 0.85f;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000072 RID: 114 RVA: 0x000046A5 File Offset: 0x000028A5
	// (set) Token: 0x06000073 RID: 115 RVA: 0x000046B0 File Offset: 0x000028B0
	public bool isReverse
	{
		get
		{
			return this._reverse;
		}
		set
		{
			bool flag = value == this._reverse;
			if (!flag)
			{
				this._reverse = value;
				if (value)
				{
					this.initAngle = new Vector3(this.initAngle.x, 180f, this.initAngle.z);
				}
				else
				{
					this.initAngle = new Vector3(this.initAngle.x, 0f, this.initAngle.z);
				}
				base.transform.Find("Front/字体").gameObject.SetActive(!value);
				base.gameObject.GetComponent<KeywordDisplay>().enabled = !value;
				base.transform.DORotate(this.initAngle, 0.4f, RotateMode.Fast);
			}
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000074 RID: 116 RVA: 0x0000477C File Offset: 0x0000297C
	public IScriptExecutor scriptExecutor
	{
		get
		{
			return this.dataConfig.scriptExecutor;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000075 RID: 117 RVA: 0x00004789 File Offset: 0x00002989
	public HashSet<string> Tags
	{
		get
		{
			return FightCardManager.Instance.CardTags.ContainsKey(this.dataConfig) ? FightCardManager.Instance.CardTags[this.dataConfig] : new HashSet<string>();
		}
	}

	/// <summary>
	/// 运行卡牌脚本
	/// </summary>
	/// <param name="ScriptName">Excel中的Script列名</param>
	// Token: 0x06000076 RID: 118 RVA: 0x000047C0 File Offset: 0x000029C0
	public void RunScript(string ScriptName)
	{
		bool flag = this.enchScriptExecutor != null;
		if (flag)
		{
			this.enchScriptExecutor.Object = new List<IStatusManager>(this.scriptExecutor.Object);
			this.enchScriptExecutor.Target = this.scriptExecutor.Target;
			this.enchScriptExecutor.RunScript(ScriptName);
		}
		this.scriptExecutor.RunScript(ScriptName);
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0000482C File Offset: 0x00002A2C
	public virtual void Init(DataConfig dataConfig)
	{
		bool flag = FightPlayer.Instance == null;
		if (!flag)
		{
			this.status = (FightPlayer.Instance.Status as StatusManager);
			bool flag2 = FightPlayer.Instance.Status.IsNull();
			if (!flag2)
			{
				bool flag3 = RoleTable.Instance.enchasedDict.ContainsKey(dataConfig.InstanceID);
				if (flag3)
				{
					this.enchScriptExecutor = RoleTable.Instance.enchasedDict[dataConfig.InstanceID].scriptExecutor;
					this.enchScriptExecutor.Self = this.status;
				}
				this.dataConfig = dataConfig;
				this.data = dataConfig.data;
				this.Vars = dataConfig.Vars;
				this.scriptExecutor.Self = this.status;
				this.scriptExecutor.Object.Clear();
				this.scriptExecutor.Object.Add(FightPlayer.Instance.Status);
				this.scriptExecutor.dataConfig.Vars["Usable"] = "1";
				ICard.SetCardStyle(base.transform, dataConfig);
				this.DataUpdate();
				this.DrawEffect();
				bool flag4 = EnemyManager.Instance != null && EnemyManager.Instance.enemyList.Count > 0;
				if (flag4)
				{
					this.scriptExecutor.Target = EnemyManager.Instance.enemyList[0].Status;
				}
			}
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000078 RID: 120 RVA: 0x000049A5 File Offset: 0x00002BA5
	// (set) Token: 0x06000079 RID: 121 RVA: 0x000049AD File Offset: 0x00002BAD
	public int index { get; set; }

	// Token: 0x0600007A RID: 122 RVA: 0x000049B6 File Offset: 0x00002BB6
	public void SetIndex(int Index)
	{
		this.index = Index;
		base.transform.SetSiblingIndex(this.index);
		base.transform.GetComponent<SortingGroup>().sortingOrder = this.index - 13;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000026D9 File Offset: 0x000008D9
	public virtual void DrawEffect()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000049F0 File Offset: 0x00002BF0
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
		bool flag = this.draging || !base.enabled || !CardItem.canUse || this.hasUse;
		if (!flag)
		{
			bool flag2 = FightUI.SelectedCard.Contains(this);
			if (!flag2)
			{
				this.index = base.transform.GetSiblingIndex();
				this.animationController.PlayEnterAnimation(new Vector2(this.initPosition.x, -30f), this.selectScale);
				this.animationController.RotateWithMouse().Forget();
			}
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00004A84 File Offset: 0x00002C84
	public virtual void OnPointerExit(PointerEventData eventData)
	{
		bool draging = this.draging;
		if (!draging)
		{
			bool flag = FightUI.SelectedCard.Contains(this);
			if (!flag)
			{
				base.gameObject.GetComponent<EventTrigger>().enabled = false;
				this.animationController.PlayExitAnimation(this.initPosition, this.initScale).OnComplete(delegate
				{
					base.gameObject.GetComponent<EventTrigger>().enabled = true;
				});
			}
		}
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00004AEC File Offset: 0x00002CEC
	public virtual void Awake()
	{
		this.animationController = new CardAnimationController();
		this.animationController.Initialize(base.transform, this);
		this._mainThreadContext = SynchronizationContext.Current;
		base.gameObject.AddComponent<KeywordDisplay>();
		base.transform.localScale = this.initScale * Vector3.one;
		this.uiElement = base.GetComponent<RectTransform>();
		this.RegisterEvent();
		EventTrigger trigger = base.gameObject.AddComponent<EventTrigger>();
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerDown;
		entry.callback.AddListener(delegate(BaseEventData data)
		{
			this.OnRightClick((PointerEventData)data);
		});
		trigger.triggers.Add(entry);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000026D9 File Offset: 0x000008D9
	public virtual void Start()
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00004B9C File Offset: 0x00002D9C
	public void ClearEvent()
	{
		Singleton<EventCenter>.Instance.Clear(this);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00004BAC File Offset: 0x00002DAC
	public void RegisterEvent()
	{
		Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00004BE4 File Offset: 0x00002DE4
	public void OnRightClick(PointerEventData eventData)
	{
		bool flag = this.data == null;
		if (!flag)
		{
			bool flag2 = CardItem.canUse;
			if (flag2)
			{
				bool flag3 = eventData.button == PointerEventData.InputButton.Right;
				if (flag3)
				{
					this.draging = false;
					base.enabled = false;
					this.animationController.enddrag();
					this.animationController.PlayExitAnimation(this.initPosition, this.initScale).OnComplete(delegate
					{
						base.enabled = true;
					});
					base.transform.SetSiblingIndex(this.index);
					bool flag4 = this.data["InitScript"].Contains("Damage");
					if (flag4)
					{
						this.scriptExecutor.Target = null;
						this.DataUpdate();
					}
				}
			}
			else
			{
				bool flag5 = FightManager.Instance == null || FightManager.Instance.fightType != FightType.Player || this.hasUse || !base.enabled;
				if (!flag5)
				{
					bool flag6 = eventData.button == PointerEventData.InputButton.Left;
					if (flag6)
					{
						bool flag7 = !FightUI.InIEn;
						if (!flag7)
						{
							bool flag8 = this.Tags.Contains("Froze") && (FightUI.SelectType == "Burn" || FightUI.SelectType == "Throw");
							if (!flag8)
							{
								bool flag9 = FightUI.SelectedCard.Contains(this);
								if (flag9)
								{
									this.OnPointerExit(eventData);
									base.gameObject.transform.SetParent(this.cardcontainer.transform);
									base.enabled = false;
									Tween tween;
									this.cardcontainer.cardTweenDict.TryGetValue(this, out tween);
									bool flag10 = tween != null && tween.IsPlaying();
									if (flag10)
									{
										tween.Kill(true);
									}
									UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardItemPos(delegate
									{
										bool flag13 = UIManager.Instance.GetUI<FightUI>("FightUI") == null;
										if (!flag13)
										{
											base.enabled = true;
										}
									}, null);
									FightUI.SelectedCard.Remove(this);
									FightUI.SpecialCount++;
								}
								else
								{
									bool flag11 = this.selectContainer == null || FightUI.SpecialCount <= 0;
									if (!flag11)
									{
										FightUI.SelectedCard.Add(this);
										base.gameObject.transform.SetParent(this.selectContainer.transform);
										base.enabled = false;
										Tween tween2;
										this.cardcontainer.cardTweenDict.TryGetValue(this, out tween2);
										bool flag12 = tween2 != null && tween2.IsPlaying();
										if (flag12)
										{
											tween2.Kill(true);
										}
										UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardItemPos(delegate
										{
											bool flag13 = UIManager.Instance.GetUI<FightUI>("FightUI") == null;
											if (!flag13)
											{
												base.enabled = true;
											}
										}, this.selectContainer);
										FightUI.SpecialCount--;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00004ECC File Offset: 0x000030CC
	public virtual void DataUpdate()
	{
		bool flag = this.IsNull("Object");
		if (!flag)
		{
			ICard.SetCardMsg(base.transform, this.dataConfig, this.status);
		}
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00004F04 File Offset: 0x00003104
	public virtual void OnBeginDrag(PointerEventData eventData)
	{
		bool flag = FightUI.SelectedCard.Contains(this);
		if (!flag)
		{
			this.draging = true;
			CardAnimationController cardAnimationController = this.animationController;
			if (cardAnimationController != null)
			{
				cardAnimationController.StopMove();
			}
			base.transform.DOKill(false);
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00004F4C File Offset: 0x0000314C
	public Vector2 GetMousePos(PointerEventData eventData)
	{
		Vector2 pos;
		bool flag = RectTransformUtility.ScreenPointToLocalPointInRectangle(base.transform.parent.GetComponent<RectTransform>(), eventData.position, eventData.pressEventCamera, out pos);
		Vector2 result;
		if (flag)
		{
			result = pos;
		}
		else
		{
			result = default(Vector2);
		}
		return result;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00004F94 File Offset: 0x00003194
	public virtual void OnDrag(PointerEventData eventData)
	{
		bool flag = FightUI.SelectedCard.Contains(this);
		if (!flag)
		{
			this.TargetPos = this.GetMousePos(eventData);
		}
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00004FC4 File Offset: 0x000031C4
	private void Update()
	{
		bool draging = this.draging;
		if (draging)
		{
			Vector2 newpos = (this.TargetPos - base.transform.GetComponent<RectTransform>().anchoredPosition) * 20f * Time.deltaTime + base.transform.GetComponent<RectTransform>().anchoredPosition;
			bool flag = (double)newpos.magnitude > 0.1;
			if (flag)
			{
				base.transform.GetComponent<RectTransform>().anchoredPosition = newpos;
			}
			else
			{
				base.transform.GetComponent<RectTransform>().anchoredPosition = this.TargetPos;
			}
		}
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000506C File Offset: 0x0000326C
	public virtual void OnEndDrag(PointerEventData eventData)
	{
		this.draging = false;
		base.enabled = false;
		this.animationController.enddrag();
		base.enabled = true;
		this.OnPointerExit(eventData);
		base.transform.SetSiblingIndex(this.index);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000050B8 File Offset: 0x000032B8
	public void Burning(float animationDelay = 0f)
	{
		bool flag = this.Tags.Contains("Froze");
		if (!flag)
		{
			this.InternalBurning(animationDelay);
		}
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000050E4 File Offset: 0x000032E4
	public void InternalBurning(float animationDelay = 0f)
	{
		bool flag = this.hasDone || this == null || base.transform == null || base.gameObject == null;
		if (!flag)
		{
			Singleton<EventCenter>.Instance.EventTrigger("BurnCard" + this.status.InstanceId);
			base.transform.Find("Front/字体").gameObject.SetActive(true);
			this.ignore = true;
			this.hasDone = true;
			base.enabled = false;
			FightCardManager.Instance.FightcardList.Remove(this.dataConfig);
			FightUI.cardItemList.Remove(this);
			UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardItemPos(null, null);
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayEffect("NewSounds/卡牌与事件/卡牌焚毁");
			}
			this.DataUpdate();
			UniTask.WaitForSeconds(animationDelay, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				this.EffectOfBurnCard();
			}).Forget();
		}
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000051F8 File Offset: 0x000033F8
	public void Reverse()
	{
		this.isReverse = !this.isReverse;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0000520C File Offset: 0x0000340C
	public void EffectOfBurnCard()
	{
		base.gameObject.GetComponent<ObjectGroup>().blocksRaycasts = false;
		base.transform.Find("Trigger").gameObject.SetActive(false);
		Tween tween;
		this.cardcontainer.cardTweenDict.TryGetValue(this, out tween);
		bool flag = tween != null && tween.IsPlaying();
		if (flag)
		{
			tween.Kill(false);
		}
		this.animationController.StopMove();
		AudioManager instance = AudioManager.Instance;
		if (instance != null)
		{
			instance.PlayEffect("Effect/burn");
		}
		Material burn = ResourceLoader.Load<Material>("Material/CardBurn", true);
		Material burn2 = UnityEngine.Object.Instantiate<Material>(burn);
		burn2.SetFloat("_Fade", 50f);
		burn2.SetFloat("_canvasScale", GameObject.Find("Canvas").GetComponent<RectTransform>().localScale.x);
		bool flag2 = base.transform == null || base.transform.gameObject == null;
		if (!flag2)
		{
			burn2.SetFloat("_startY", base.transform.position.y);
			Sequence sequence = DOTween.Sequence();
			burn2.mainTexture = base.transform.Find("Front/icon").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn3 = new Material(burn2);
			burn3.mainTexture = base.transform.Find("Back/background").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn4 = UnityEngine.Object.Instantiate<Material>(burn2);
			burn4.mainTexture = base.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn5 = UnityEngine.Object.Instantiate<Material>(burn2);
			burn5.mainTexture = base.transform.Find("Front/msgFrame").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn6 = UnityEngine.Object.Instantiate<Material>(burn2);
			burn6.mainTexture = base.transform.Find("Front/cost/cost").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn7 = UnityEngine.Object.Instantiate<Material>(burn2);
			burn7.mainTexture = base.transform.Find("Front/cost").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn8 = UnityEngine.Object.Instantiate<Material>(burn2);
			burn8.mainTexture = base.transform.Find("Front/rarity").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn9 = UnityEngine.Object.Instantiate<Material>(burn2);
			burn9.mainTexture = base.transform.Find("Front/titleFrame").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn10 = UnityEngine.Object.Instantiate<Material>(burn2);
			burn10.mainTexture = base.transform.Find("Front/iconFrame").GetComponent<MeshRenderer>().material.mainTexture;
			Material burn11 = UnityEngine.Object.Instantiate<Material>(burn2);
			burn11.mainTexture = base.transform.Find("Front/baseFrame").GetComponent<MeshRenderer>().material.mainTexture;
			base.transform.Find("Front/icon").GetComponent<MeshRenderer>().material = burn2;
			base.transform.Find("Back/background").GetComponent<MeshRenderer>().material = burn3;
			base.transform.Find("Front/background").GetComponent<MeshRenderer>().material = burn4;
			base.transform.Find("Front/msgFrame").GetComponent<MeshRenderer>().material = burn5;
			base.transform.Find("Front/cost/cost").GetComponent<MeshRenderer>().material = burn6;
			base.transform.Find("Front/cost").GetComponent<MeshRenderer>().material = burn7;
			base.transform.Find("Front/rarity").GetComponent<MeshRenderer>().material = burn8;
			base.transform.Find("Front/titleFrame").GetComponent<MeshRenderer>().material = burn9;
			base.transform.Find("Front/iconFrame").GetComponent<MeshRenderer>().material = burn10;
			base.transform.Find("Front/baseFrame").GetComponent<MeshRenderer>().material = burn11;
			sequence.Insert(0f, base.transform.Find("Front/background").GetComponent<Image>().DOFade(0f, 0.1f));
			bool flag3 = this.selectContainer != null && base.transform.parent != this.selectContainer.transform;
			if (flag3)
			{
				sequence.Insert(0f, this.uiElement.DOAnchorPos(new Vector3(0f, 600f, 0f), 0.3f, false));
			}
			sequence.Insert(0f, base.transform.DORotate(new Vector3(0f, 0f, 0f), 0.1f, RotateMode.Fast));
			sequence.Insert(0f, base.transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().DOFade(0f, 0.6f));
			sequence.Insert(0.3f, burn2.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn3.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn4.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn6.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn8.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn9.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn10.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn11.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn7.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, burn5.DOFloat(-90f, "_Fade", 1.5f));
			sequence.Insert(0.3f, base.transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().DOFade(0f, 0.3f));
			sequence.OnComplete(delegate
			{
				UnityEngine.Object.Destroy(base.gameObject);
			});
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000058B0 File Offset: 0x00003AB0
	public void ThrowCard()
	{
		bool flag = this.Tags.Contains("Froze");
		if (!flag)
		{
			this.InternalThrow();
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000058DC File Offset: 0x00003ADC
	public void InternalThrow()
	{
		FightUI.cardItemList.Remove(this);
		FightCardManager.Instance.usedCardList.Add(this.dataConfig);
		bool flag = FightManager.Instance.fightType > FightType.None;
		if (flag)
		{
			this.RunScript("DropScript");
		}
		this.DataUpdate();
		this.EffectOfThrowCard("Canvas/FightUI/ClockBoard/弃牌堆");
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00005940 File Offset: 0x00003B40
	public void EffectOfThrowCard(string targetPath)
	{
		bool flag = this.hasDone || this == null || base.transform == null || base.gameObject == null;
		if (!flag)
		{
			base.transform.Find("Front/字体").gameObject.SetActive(true);
			Transform target = GameObject.Find(targetPath).transform;
			Tween tween;
			this.cardcontainer.cardTweenDict.TryGetValue(this, out tween);
			bool flag2 = tween != null && tween.IsPlaying();
			if (flag2)
			{
				tween.Kill(false);
			}
			this.animationController.StopMove();
			this.ignore = true;
			this.hasDone = true;
			base.enabled = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayEffect("Cards/cardShove");
			}
			base.transform.Find("Trigger").gameObject.SetActive(false);
			FightUI fightUI = UIManager.Instance.GetUI<FightUI>("FightUI");
			bool flag3 = fightUI != null;
			if (flag3)
			{
				GameObject trail = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/Trail"), GameObject.Find("Canvas/FightUI").transform) as GameObject;
				Transform vfx = trail.transform.Find("geometryBursts");
				Transform child;
				foreach (object obj in vfx.transform)
				{
					child = (Transform)obj;
					VisualEffect subVfx = child.GetComponent<VisualEffect>();
					subVfx.SetInt("count", 0);
				}
				UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardItemPos(null, null);
				bool flag4 = this.selectContainer != null && base.transform.parent != this.selectContainer.transform;
				if (flag4)
				{
					this.uiElement.DOAnchorPos(new Vector3(0f, 600f, 0f), 0.3f, false);
				}
				this.uiElement.DORotate(new Vector3(0f, 0f, 0f), 0.3f, RotateMode.Fast);
				base.transform.DOMove(target.position, 1f, false).OnComplete(delegate
				{
					foreach (object obj2 in vfx.transform)
					{
						Transform child2 = (Transform)obj2;
						VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
						subVfx2.SetInt("count", 0);
					}
					using (IEnumerator enumerator3 = target.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							Transform child = (Transform)enumerator3.Current;
							bool flag5 = child.localScale == Vector3.one;
							if (flag5)
							{
								child.DOPunchScale(Vector3.one * 0.2f, 0.3f, 2, 1f).OnKill(delegate
								{
									child.localScale = Vector3.one;
								});
							}
						}
					}
					UnityEngine.Object.Destroy(trail, 5f);
					UnityEngine.Object.Destroy(this.gameObject);
				}).OnStart(delegate
				{
					foreach (object obj2 in vfx.transform)
					{
						Transform child4 = (Transform)obj2;
						VisualEffect subVfx2 = child4.GetComponent<VisualEffect>();
						subVfx2.SetInt("count", 1);
					}
					Vector3 direction = GameObject.Find(targetPath).transform.position - this.transform.position;
					float angle = Mathf.Atan2(direction.y, direction.x) * 57.29578f;
					this.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, angle)), 0.5f);
					this.transform.DOScale(0f, 0.7f);
				}).OnUpdate(delegate
				{
					foreach (object obj2 in vfx.transform)
					{
						Transform child4 = (Transform)obj2;
						VisualEffect subVfx2 = child4.GetComponent<VisualEffect>();
						Vector3 pos = PositionUtility.CameraSpaceToZeroPlane(this.uiElement, null);
						subVfx2.SetVector3("startPos", pos);
						subVfx2.SetFloat("direction", this.transform.rotation.eulerAngles.z * 0.017453292f);
					}
				}).OnKill(delegate
				{
					foreach (object obj2 in vfx.transform)
					{
						Transform child4 = (Transform)obj2;
						VisualEffect subVfx2 = child4.GetComponent<VisualEffect>();
						subVfx2.SetInt("count", 0);
					}
					using (IEnumerator enumerator3 = target.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							Transform child = (Transform)enumerator3.Current;
							child.DOPunchScale(Vector3.one * 0.2f, 0.3f, 2, 1f).OnKill(delegate
							{
								child.localScale = Vector3.one;
							});
						}
					}
					UnityEngine.Object.Destroy(trail, 5f);
					stopwatch.Stop();
					UnityEngine.Object.Destroy(this.gameObject);
				}).SetDelay(0.8f);
			}
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00005C5C File Offset: 0x00003E5C
	private void OnDestroy()
	{
		FightUI.SelectedCard.Remove(this);
		this.ClearEvent();
	}

	// Token: 0x0400004A RID: 74
	public CardContainer cardcontainer;

	// Token: 0x0400004B RID: 75
	public bool hasUse;

	// Token: 0x0400004C RID: 76
	public CardContainer selectContainer;

	// Token: 0x0400004D RID: 77
	private bool _reverse;

	// Token: 0x0400004E RID: 78
	public DataConfig dataConfig;

	// Token: 0x0400004F RID: 79
	public IDictionary<string, string> data;

	// Token: 0x04000050 RID: 80
	public IDictionary<string, string> Vars;

	// Token: 0x04000051 RID: 81
	public StatusManager status;

	// Token: 0x04000052 RID: 82
	public bool hasDone;

	// Token: 0x04000053 RID: 83
	public SynchronizationContext _mainThreadContext;

	// Token: 0x04000054 RID: 84
	public IScriptExecutor enchScriptExecutor = null;

	// Token: 0x04000056 RID: 86
	public CardAnimationController animationController;

	// Token: 0x04000057 RID: 87
	public RectTransform uiElement;

	// Token: 0x04000058 RID: 88
	private Vector2 TargetPos;

	// Token: 0x04000059 RID: 89
	public static bool canUse = true;

	// Token: 0x0400005A RID: 90
	public static int UseCount = 0;
}

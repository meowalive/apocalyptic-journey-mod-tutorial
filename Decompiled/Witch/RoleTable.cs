using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Data.Save;
using Loxodon.Framework.Obfuscation;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x0200003B RID: 59
public class RoleTable : INotifyPropertyChanged
{
	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000182 RID: 386 RVA: 0x0000DB14 File Offset: 0x0000BD14
	public static RoleTable Instance
	{
		get
		{
			return Singleton<GameRuntimeData>.Instance.roleTable;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000183 RID: 387 RVA: 0x0000DB20 File Offset: 0x0000BD20
	// (set) Token: 0x06000184 RID: 388 RVA: 0x0000DB28 File Offset: 0x0000BD28
	public bool InHighTide
	{
		[CompilerGenerated]
		get
		{
			return this.<InHighTide>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<InHighTide>k__BackingField == value)
			{
				return;
			}
			this.<InHighTide>k__BackingField = value;
			this.OnPropertyChanged("InHighTide");
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000185 RID: 389 RVA: 0x0000DB55 File Offset: 0x0000BD55
	// (set) Token: 0x06000186 RID: 390 RVA: 0x0000DB60 File Offset: 0x0000BD60
	public int Reward
	{
		[CompilerGenerated]
		get
		{
			return this.<Reward>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<Reward>k__BackingField == value)
			{
				return;
			}
			this.<Reward>k__BackingField = value;
			this.OnPropertyChanged("Reward");
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000187 RID: 391 RVA: 0x0000DB8D File Offset: 0x0000BD8D
	// (set) Token: 0x06000188 RID: 392 RVA: 0x0000DB98 File Offset: 0x0000BD98
	public int sumFeat
	{
		[CompilerGenerated]
		get
		{
			return this.<sumFeat>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<sumFeat>k__BackingField == value)
			{
				return;
			}
			this.<sumFeat>k__BackingField = value;
			this.OnPropertyChanged("sumFeat");
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000189 RID: 393 RVA: 0x0000DBC5 File Offset: 0x0000BDC5
	// (set) Token: 0x0600018A RID: 394 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
	public int CardCount
	{
		[CompilerGenerated]
		get
		{
			return this.<CardCount>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<CardCount>k__BackingField == value)
			{
				return;
			}
			this.<CardCount>k__BackingField = value;
			this.OnPropertyChanged("CardCount");
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600018B RID: 395 RVA: 0x0000DBFD File Offset: 0x0000BDFD
	// (set) Token: 0x0600018C RID: 396 RVA: 0x0000DC08 File Offset: 0x0000BE08
	public int CardBottomCount
	{
		[CompilerGenerated]
		get
		{
			return this.<CardBottomCount>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<CardBottomCount>k__BackingField == value)
			{
				return;
			}
			this.<CardBottomCount>k__BackingField = value;
			this.OnPropertyChanged("CardBottomCount");
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x0600018D RID: 397 RVA: 0x0000DC35 File Offset: 0x0000BE35
	// (set) Token: 0x0600018E RID: 398 RVA: 0x0000DC40 File Offset: 0x0000BE40
	public int CardTopCount
	{
		[CompilerGenerated]
		get
		{
			return this.<CardTopCount>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<CardTopCount>k__BackingField == value)
			{
				return;
			}
			this.<CardTopCount>k__BackingField = value;
			this.OnPropertyChanged("CardTopCount");
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x0600018F RID: 399 RVA: 0x0000DC6D File Offset: 0x0000BE6D
	// (set) Token: 0x06000190 RID: 400 RVA: 0x0000DC78 File Offset: 0x0000BE78
	public int MainVarUpperBound
	{
		[CompilerGenerated]
		get
		{
			return this.<MainVarUpperBound>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<MainVarUpperBound>k__BackingField == value)
			{
				return;
			}
			this.<MainVarUpperBound>k__BackingField = value;
			this.OnPropertyChanged("MainVarUpperBound");
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000191 RID: 401 RVA: 0x0000DCA5 File Offset: 0x0000BEA5
	// (set) Token: 0x06000192 RID: 402 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
	public int SecondaryVarUpperBound
	{
		[CompilerGenerated]
		get
		{
			return this.<SecondaryVarUpperBound>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<SecondaryVarUpperBound>k__BackingField == value)
			{
				return;
			}
			this.<SecondaryVarUpperBound>k__BackingField = value;
			this.OnPropertyChanged("SecondaryVarUpperBound");
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000193 RID: 403 RVA: 0x0000DCDD File Offset: 0x0000BEDD
	// (set) Token: 0x06000194 RID: 404 RVA: 0x0000DCE8 File Offset: 0x0000BEE8
	public int OtherVarUpperBound
	{
		[CompilerGenerated]
		get
		{
			return this.<OtherVarUpperBound>k__BackingField;
		}
		[CompilerGenerated]
		set
		{
			if (this.<OtherVarUpperBound>k__BackingField == value)
			{
				return;
			}
			this.<OtherVarUpperBound>k__BackingField = value;
			this.OnPropertyChanged("OtherVarUpperBound");
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000195 RID: 405 RVA: 0x0000DD15 File Offset: 0x0000BF15
	// (set) Token: 0x06000196 RID: 406 RVA: 0x0000DD20 File Offset: 0x0000BF20
	public int San
	{
		get
		{
			return this.san;
		}
		set
		{
			if (this.san == value)
			{
				return;
			}
			bool flag = this.isDead;
			if (!flag)
			{
				int change = this.san;
				this.san = value;
				this.OnPropertyChanged("San");
				bool flag2 = this.san > this.maxSan;
				if (flag2)
				{
					this.san = this.maxSan;
					this.OnPropertyChanged("San");
				}
				change = this.san - change;
				bool flag3 = this.san <= 0;
				if (flag3)
				{
					bool flag4 = FightPlayer.Instance == null;
					if (flag4)
					{
						this.isDead = true;
						FightManager.Instance.CmdCheckDead(null);
					}
				}
				bool flag5 = FightPlayer.Instance != null && FightPlayer.Instance.Status != null && FightPlayer.Instance.Status.CurHp != this.san;
				if (flag5)
				{
					FightPlayer.Instance.Status.CurHp = this.san;
					FightPlayer.Instance.Status.UpdateStatus(true);
				}
				string sanValue = this.san.ToString();
				bool flag6 = this.san < 0;
				if (flag6)
				{
					sanValue = "0";
				}
				PlayerManager instance = PlayerManager.Instance;
				if (instance != null)
				{
					instance.CmdSendRoleTable(sanValue, this.Id, "San");
				}
				bool flag7 = PlayerManager.Instance == null || FightManager.Instance.fightType > FightType.None;
				if (!flag7)
				{
					GameObject role;
					Singleton<DialogueManager>.Instance.Identity.TryGetValue(PlayerManager.Instance.PlayerId, out role);
					bool flag8 = role == null;
					if (!flag8)
					{
						Vector2 screenPos = Camera.main.WorldToScreenPoint(role.transform.position);
						Vector2 pos;
						RectTransformUtility.ScreenPointToLocalPointInRectangle(UIManager.Instance.canvasTf as RectTransform, screenPos, UIManager.Instance.canvasTf.GetComponent<Canvas>().worldCamera, out pos);
						bool flag9 = change < 0;
						if (flag9)
						{
							UIManager.Instance.ShowPopUpText("NormalDamageText", (-change).ToString(), pos).Forget<PopUpTextUI>();
						}
						else
						{
							bool flag10 = change > 0;
							if (flag10)
							{
								UIManager.Instance.ShowPopUpText("HealDamageText", change.ToString(), pos).Forget<PopUpTextUI>();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000197 RID: 407 RVA: 0x0000DF70 File Offset: 0x0000C170
	// (set) Token: 0x06000198 RID: 408 RVA: 0x0000DF78 File Offset: 0x0000C178
	public int MaxSan
	{
		get
		{
			return this.maxSan;
		}
		set
		{
			if (this.maxSan == value)
			{
				return;
			}
			int maxsan = this.maxSan;
			this.maxSan = value;
			this.OnPropertyChanged("MaxSan");
			this.San += Math.Max(0, value - maxsan);
			bool flag = this.San > this.maxSan;
			if (flag)
			{
				this.San = this.maxSan;
			}
			bool flag2 = FightPlayer.Instance != null && FightPlayer.Instance.Status.MaxHp != this.maxSan;
			if (flag2)
			{
				FightPlayer.Instance.Status.MaxHp = this.maxSan;
				FightPlayer.Instance.Status.UpdateStatus(true);
			}
			PlayerManager instance = PlayerManager.Instance;
			if (instance != null)
			{
				instance.CmdSendRoleTable(this.maxSan.ToString(), this.Id, "MaxSan");
			}
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06000199 RID: 409 RVA: 0x0000E05F File Offset: 0x0000C25F
	// (set) Token: 0x0600019A RID: 410 RVA: 0x0000E068 File Offset: 0x0000C268
	public ObfuscatedInt Money
	{
		get
		{
			return this.money;
		}
		set
		{
			if (this.money == value)
			{
				return;
			}
			bool flag = value > this.money;
			if (flag)
			{
				this.money = (int)((float)((value - this.money) * (long)this.MoneyMultiplier * (long)(100 + this.VarsMap["Lucky"] * 2)) / 10000f) + this.money;
				this.OnPropertyChanged("Money");
				bool flag2 = AudioManager.Instance != null;
				if (flag2)
				{
					AudioManager instance = AudioManager.Instance;
					if (instance != null)
					{
						instance.PlayEffect("NewSounds/特效/金币");
					}
				}
			}
			else
			{
				this.money = value;
				this.OnPropertyChanged("Money");
			}
			bool flag3 = this.money < 0;
			if (flag3)
			{
				this.money = 0;
				this.OnPropertyChanged("Money");
			}
		}
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0000E160 File Offset: 0x0000C360
	public int ReturnMoneyCal(int baseMoney)
	{
		return (int)((float)((long)baseMoney * (long)this.MoneyMultiplier * (long)(100 + this.VarsMap["Lucky"] * 2)) / 10000f);
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600019C RID: 412 RVA: 0x0000E19B File Offset: 0x0000C39B
	public float MoneyCal
	{
		get
		{
			return (float)(this.MoneyMultiplier * (100 + this.VarsMap["Lucky"] * 2)) / 10000f;
		}
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
	public void Listen()
	{
		bool flag = this.relicAddListener != null;
		if (!flag)
		{
			this.relicAddListener = delegate(object sender, NotifyCollectionChangedEventArgs args)
			{
				bool flag2 = args.Action == NotifyCollectionChangedAction.Add;
				if (flag2)
				{
					Singleton<EventCenter>.Instance.EventTrigger("RelicAdd");
					foreach (object obj in args.NewItems)
					{
						DataConfig dataConfig = (DataConfig)obj;
						string id = dataConfig.data["Id"];
						this.relicGets.TryAdd(id, true);
						bool flag3 = !Singleton<GameRuntimeData>.Instance.achivementTable.ItemDic["Relic"].Contains(id);
						if (flag3)
						{
							Singleton<GameRuntimeData>.Instance.achivementTable.ItemDic["Relic"].Add(id);
						}
						bool flag4 = this.relicList.Count > 6;
						if (flag4)
						{
							this.relicList.Remove(dataConfig);
							this.WithoutArmedRelicList.Add(dataConfig);
						}
						else
						{
							bool flag5 = GameObject.Find("Breaks") != null || UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI") != null;
							if (flag5)
							{
								return;
							}
							UIManager.Instance.ShowNotification("GetNewItem".Localize("Tips"), string.Concat(new string[]
							{
								"NewRelic".Localize("Tips"),
								"<color=#",
								ColorUtility.ToHtmlStringRGBA(Singleton<TempDataManager>.Instance.rareColorMap[dataConfig.data["Rarity"]]),
								">",
								dataConfig.data.Localize("Name"),
								"</color>.",
								"AutoEquip".Localize("Tips")
							}), 2f);
						}
					}
				}
				this.OnPropertyChanged("relicList");
			};
			NotifyCollectionChangedEventHandler WithOutrelicListener = delegate(object sender, NotifyCollectionChangedEventArgs args)
			{
				bool flag2 = args.Action == NotifyCollectionChangedAction.Add;
				if (flag2)
				{
					foreach (object obj in args.NewItems)
					{
						DataConfig dataConfig = (DataConfig)obj;
						string id = dataConfig.data["Id"];
						this.relicGets.TryAdd(id, true);
						bool flag3 = !Singleton<GameRuntimeData>.Instance.achivementTable.ItemDic["Relic"].Contains(id);
						if (flag3)
						{
							Singleton<GameRuntimeData>.Instance.achivementTable.ItemDic["Relic"].Add(id);
						}
						bool flag4 = this.relicList.Count >= 6;
						if (flag4)
						{
							bool flag5 = UIManager.Instance.GetUI<SafeBoxUI>("SafeBoxUI") != null;
							if (flag5)
							{
								return;
							}
							UIManager.Instance.ShowNotification("GetNewItem".Localize("Tips"), string.Concat(new string[]
							{
								"NewRelic".Localize("Tips"),
								"<color=#",
								ColorUtility.ToHtmlStringRGBA(Singleton<TempDataManager>.Instance.rareColorMap[dataConfig.data["Rarity"]]),
								">",
								dataConfig.data.Localize("Name"),
								"</color>.",
								"FullItem".Localize("Tips")
							}), 2f);
						}
						else
						{
							bool flag6 = GameObject.Find("Breaks") == null && GameObject.Find("Canvas/GameEntryUI") == null && !this.IsMoveOn;
							if (flag6)
							{
								this.WithoutArmedRelicList.Remove(dataConfig);
								this.relicList.Add(dataConfig);
							}
						}
					}
				}
				this.OnPropertyChanged("WithoutArmedRelicList");
			};
			NotifyCollectionChangedEventHandler newCardAddListener = delegate(object sender, NotifyCollectionChangedEventArgs args)
			{
				bool flag2 = args.Action == NotifyCollectionChangedAction.Add;
				if (flag2)
				{
					foreach (object obj in args.NewItems)
					{
						DataConfig dataConfig = (DataConfig)obj;
						string id = dataConfig.data["Id"];
						bool flag3 = !Singleton<GameRuntimeData>.Instance.achivementTable.ItemDic["Card"].Contains(id);
						if (flag3)
						{
							Singleton<GameRuntimeData>.Instance.achivementTable.ItemDic["Card"].Add(id);
						}
						bool flag4 = !this.GetCard.ContainsKey(id);
						if (flag4)
						{
							this.GetCard[id] = dataConfig.data["Name"];
							Dictionary<string, int> getCardReward = this.GetCardReward;
							string key = dataConfig.data["Rarity"];
							getCardReward[key]++;
						}
						bool flag5 = UIManager.Instance.GetUI<EventUI>("EventUI") != null && (!(UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI") != null) || !UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI").gameObject.activeSelf);
						if (flag5)
						{
							UIManager.Instance.ShowNotification("GetNewItem".Localize("Tips"), string.Concat(new string[]
							{
								"NewCard".Localize("Tips"),
								"<color=#",
								ColorUtility.ToHtmlStringRGBA(Singleton<TempDataManager>.Instance.rareColorMap[dataConfig.data["Rarity"]]),
								">",
								dataConfig.data.Localize("Name"),
								"</color>"
							}), 2f);
						}
					}
				}
			};
			this.blessAddListener = delegate(object sender, NotifyCollectionChangedEventArgs args)
			{
				bool flag2 = args.Action == NotifyCollectionChangedAction.Add;
				if (flag2)
				{
					foreach (object obj in args.NewItems)
					{
						DataConfig dataConfig = (DataConfig)obj;
						string id = dataConfig.data["Id"];
						bool flag3 = !Singleton<GameRuntimeData>.Instance.achivementTable.ItemDic["Bless"].Contains(id);
						if (flag3)
						{
							Singleton<GameRuntimeData>.Instance.achivementTable.ItemDic["Bless"].Add(id);
						}
						bool flag4 = dataConfig.scriptExecutor.Self == null && FightManager.Instance.fightType != FightType.None && FightPlayer.Instance != null;
						if (flag4)
						{
							dataConfig.scriptExecutor.Self = FightPlayer.Instance.Status;
						}
						dataConfig.scriptExecutor.RunScript("OwnScript");
						bool flag5 = UIManager.Instance.GetUI<EventUI>("EventUI") != null;
						if (flag5)
						{
							UIManager.Instance.ShowNotification("GetNewItem".Localize("Tips"), string.Concat(new string[]
							{
								"NewBless".Localize("Tips"),
								"<color=#",
								ColorUtility.ToHtmlStringRGBA(Singleton<TempDataManager>.Instance.rareColorMap[dataConfig.data["Rarity"]]),
								">",
								dataConfig.data.Localize("Name"),
								"</color>.",
								"AutoEquip".Localize("Tips")
							}), 2f);
						}
					}
				}
			};
			NotifyCollectionChangedEventHandler VarBlessAddListener = delegate(object sender, NotifyCollectionChangedEventArgs args)
			{
				bool flag2 = args.Action == NotifyCollectionChangedAction.Add;
				if (flag2)
				{
					foreach (object obj in args.NewItems)
					{
						string id = (string)obj;
						Dictionary<string, string> data = Singleton<GameConfigManager>.Instance.GetOne(DataType.Bless, id);
						DataConfig config = new DataConfig(id, DataType.Bless);
						List<string> kw = new List<string>();
						string desc = config.Description().Highlight(kw);
						UIManager.Instance.ShowItemShowUI(ResourceLoader.Load<Sprite>(data["Icon"], true), data.Localize("Name"), desc, data.Localize("Tips"));
						UIManager.Instance.ShowNotification("属性超凡", string.Concat(new string[]
						{
							"获得<color=#",
							ColorUtility.ToHtmlStringRGBA(Singleton<TempDataManager>.Instance.rareColorMap["三阶"]),
							">",
							data.Localize("Name"),
							"</color>专长。"
						}), 2f);
					}
				}
			};
			this.ExtraordinaryBlessings.CollectionChanged += VarBlessAddListener;
			this.relicList.CollectionChanged += this.relicAddListener;
			this.WithoutArmedRelicList.CollectionChanged += WithOutrelicListener;
			this.cardList.CollectionChanged += newCardAddListener;
			this.UnCardList.CollectionChanged += newCardAddListener;
			this.blessingConfigs.CollectionChanged += this.blessAddListener;
		}
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0000E2AC File Offset: 0x0000C4AC
	public void ResetFight(RoleTable role)
	{
		this.Reward = 0;
		this.Career = role.Career;
		this.money = role.money;
		this.VarsMap = new Dictionary<string, int>(role.VarsMap);
		this.isDead = false;
		this.San = role.San;
		this.MaxSan = role.MaxSan;
		Debug.Log("重置后MaxSan" + this.MaxSan.ToString());
		this.cardList = new ObservableCollection<DataConfig>(role.cardList);
		this.UnCardList = new ObservableCollection<DataConfig>(role.UnCardList);
		this.SkillTime = new Dictionary<string, int>(role.SkillTime);
		this.blessingConfigs = new ObservableCollection<DataConfig>(role.blessingConfigs);
		this.blessingConfigs.CollectionChanged += this.blessAddListener;
		this.relicList = new ObservableCollection<DataConfig>(role.relicList);
		this.relicList.CollectionChanged += this.relicAddListener;
		this.SpecialVarMap = new Dictionary<string, string>(role.SpecialVarMap);
		this.OnPropertyChanged("relicList");
		this.OnPropertyChanged("WithoutArmedRelicList");
		this.OnPropertyChanged("cardList");
		this.OnPropertyChanged("UnCardList");
		this.OnPropertyChanged("San");
		this.OnPropertyChanged("Money");
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000E3FC File Offset: 0x0000C5FC
	public void TryAddBless(string blessid)
	{
		this.ExtraordinaryBlessings.Add(blessid);
		UniTask.DelayFrame(1, PlayerLoopTiming.Update, Singleton<GameConfigManager>.Instance.cts.Token, false).ContinueWith(delegate()
		{
			this.blessingConfigs.Add(new DataConfig(blessid, DataType.Bless));
		}).Forget();
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0000E460 File Offset: 0x0000C660
	public void VarsCheck(string key)
	{
		bool flag = !this.ChooseVars.Contains(key);
		if (flag)
		{
			bool flag2 = this.VarsMap[key] > this.OtherVarUpperBound;
			if (flag2)
			{
				this.VarsMap[key] = this.OtherVarUpperBound;
			}
		}
		else
		{
			int a = this.ChooseVars.FindIndex((string x) => x == key);
			bool flag3 = a == 0;
			if (flag3)
			{
				bool flag4 = this.VarsMap[key] >= this.MainVarUpperBound;
				if (flag4)
				{
					this.VarsMap[key] = this.MainVarUpperBound;
				}
			}
			else
			{
				bool flag5 = this.VarsMap[key] >= this.SecondaryVarUpperBound;
				if (flag5)
				{
					this.VarsMap[key] = this.SecondaryVarUpperBound;
				}
			}
		}
		bool flag6 = key == "Strength";
		if (flag6)
		{
			this.SpecialCount = 1;
		}
		else
		{
			bool flag7 = key == "Lucky";
			if (flag7)
			{
				this.SpecialCount = 2;
			}
			else
			{
				bool flag8 = key == "Perceive";
				if (flag8)
				{
					this.SpecialCount = 4;
				}
				else
				{
					bool flag9 = key == "Wisdom";
					if (flag9)
					{
						MapManager.Instance.ModeMapManager.CardCountSet(this);
						this.SpecialCount = 3;
					}
				}
			}
		}
		this.OnPropertyChanged("VarsMap");
		bool flag10 = this.VarsMap[key] >= 10;
		if (flag10)
		{
			bool flag11 = !this.ExtraordinaryBlessings.Contains("blessing_" + (100 + this.SpecialCount).ToString());
			if (flag11)
			{
				this.TryAddBless("blessing_" + (100 + this.SpecialCount).ToString());
			}
			bool flag12 = this.VarsMap[key] >= 20;
			if (flag12)
			{
				bool flag13 = !this.ExtraordinaryBlessings.Contains("blessing_" + (104 + this.SpecialCount).ToString());
				if (flag13)
				{
					this.TryAddBless("blessing_" + (104 + this.SpecialCount).ToString());
				}
				bool flag14 = this.VarsMap[key] >= 30;
				if (flag14)
				{
					bool flag15 = !this.ExtraordinaryBlessings.Contains("blessing_" + (108 + this.SpecialCount).ToString());
					if (flag15)
					{
						this.TryAddBless("blessing_" + (108 + this.SpecialCount).ToString());
					}
					bool flag16 = this.VarsMap[key] >= 40;
					if (flag16)
					{
						bool flag17 = !this.ExtraordinaryBlessings.Contains("blessing_" + (112 + this.SpecialCount).ToString());
						if (flag17)
						{
							this.TryAddBless("blessing_" + (112 + this.SpecialCount).ToString());
						}
					}
				}
			}
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
	public void UseVarsChanges(string key, int value)
	{
		Dictionary<string, int> varsMap = this.VarsMap;
		varsMap[key] += value;
		this.VarsCheck(key);
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0000E820 File Offset: 0x0000CA20
	public void LevelCount()
	{
		bool flag = this.relicList.Count != 0;
		if (flag)
		{
			foreach (DataConfig item in this.relicList)
			{
				item.Vars["layersExperienced"] = (item.Vars["layersExperienced"].ToInt() + 1).ToString();
			}
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
	public void Init()
	{
		this.GetCardReward = new Dictionary<string, int>
		{
			{
				"0",
				0
			},
			{
				"1",
				0
			},
			{
				"2",
				0
			},
			{
				"3",
				0
			},
			{
				"4",
				0
			},
			{
				"5",
				0
			},
			{
				"6",
				0
			}
		};
		this.cardList = new ObservableCollection<DataConfig>();
		this.UnCardList = new ObservableCollection<DataConfig>();
		this.relicList = new ObservableCollection<DataConfig>();
		this.WithoutArmedRelicList = new ObservableCollection<DataConfig>();
		this.blessingConfigs = new ObservableCollection<DataConfig>();
		this.Listen();
		this.Money += Singleton<GameRuntimeData>.Instance.Gain["firstMoney"];
		this.CardBottomCount = 13 - this.VarsMap["Wisdom"] / 5;
		this.CardTopCount = Math.Max(this.VarsMap["Wisdom"] + 18, this.CardBottomCount);
		bool flag = !GameSaveManager.GetValue<bool>(GameVar.UselessWis);
		if (flag)
		{
			this.MaxAlCardCount = this.VarsMap["Wisdom"] / 2 + 2;
		}
		else
		{
			this.MaxAlCardCount = 5;
		}
		this.cardList.Add(new DataConfig("card_1", DataType.Card));
		this.cardList.Add(new DataConfig("card_2", DataType.Card));
		this.cardList.Add(new DataConfig("card_1", DataType.Card));
		this.cardList.Add(new DataConfig("card_2", DataType.Card));
		this.cardList.Add(new DataConfig("card_1", DataType.Card));
		this.cardList.Add(new DataConfig("card_2", DataType.Card));
		this.cardList.Add(new DataConfig("burningcard_2", DataType.Card));
		this.cardList.Add(new DataConfig("burningcard_1", DataType.Card));
		this.cardList.Add(new DataConfig("card_4", DataType.Card));
		this.cardList.Add(new DataConfig("card_3", DataType.Card));
		this.cardList.Add(new DataConfig("burningcard_1", DataType.Card));
		bool flag2 = Singleton<GameRuntimeData>.Instance.BuyedItems.ContainsKey("outsideshop_10");
		if (flag2)
		{
			this.blessingConfigs.Add(new DataConfig("blessing_35", DataType.Bless));
		}
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0000EB34 File Offset: 0x0000CD34
	public void ResetBackCard()
	{
		bool flag = !GameSaveManager.GetValue<bool>(GameVar.UselessWis);
		if (flag)
		{
			this.MaxAlCardCount = this.VarsMap["Wisdom"] / 2 + 2;
		}
		else
		{
			this.MaxAlCardCount = 5;
		}
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060001A5 RID: 421 RVA: 0x0000EB78 File Offset: 0x0000CD78
	// (remove) Token: 0x060001A6 RID: 422 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event PropertyChangedEventHandler PropertyChanged;

	// Token: 0x060001A7 RID: 423 RVA: 0x0000EBE5 File Offset: 0x0000CDE5
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x0000EC04 File Offset: 0x0000CE04
	protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		bool flag = EqualityComparer<T>.Default.Equals(field, value);
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			field = value;
			this.OnPropertyChanged(propertyName);
			result = true;
		}
		return result;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x0000EC40 File Offset: 0x0000CE40
	public RoleTable()
	{
		this.<InHighTide>k__BackingField = false;
		this.<Reward>k__BackingField = 0;
		this.enchasedDict = new Dictionary<string, DataConfig>();
		this.GetCardReward = new Dictionary<string, int>
		{
			{
				"0",
				0
			},
			{
				"1",
				0
			},
			{
				"2",
				0
			},
			{
				"3",
				0
			},
			{
				"4",
				0
			},
			{
				"5",
				0
			},
			{
				"6",
				0
			}
		};
		this.GetCard = new Dictionary<string, string>();
		this.MoneyMultiplier = 100;
		this.<sumFeat>k__BackingField = 0;
		this.WithoutArmedRelicList = new ObservableCollection<DataConfig>();
		this.blessingConfigs = new ObservableCollection<DataConfig>();
		this.relicGets = new Dictionary<string, bool>();
		this.<CardCount>k__BackingField = 10;
		this.<CardBottomCount>k__BackingField = 13;
		this.SkillTime = new Dictionary<string, int>();
		this.BuyBlessCount = 0;
		this.<CardTopCount>k__BackingField = 18;
		this.MaxAlCardCount = 5;
		this.SpecialVarMap = new Dictionary<string, string>
		{
			{
				"DoomPower",
				"0"
			},
			{
				"HasGive1",
				"True"
			}
		};
		this.<MainVarUpperBound>k__BackingField = 40;
		this.<SecondaryVarUpperBound>k__BackingField = 39;
		this.<OtherVarUpperBound>k__BackingField = 20;
		this.san = 100 + Singleton<GameRuntimeData>.Instance.Gain["exMaxHp"];
		this.IsMoveOn = false;
		this.SafeBoxRelicCount = 1;
		this.SafeBoxCardCount = 1;
		this.SafeBoxGetMoneyCount = 5;
		this.SafeBoxSaveMoneyCount = 5;
		this.GetRelic = false;
		this.GetCardInBack = false;
		this.IsStarted = false;
		this.maxSan = 100 + Singleton<GameRuntimeData>.Instance.Gain["exMaxHp"];
		this.Career = null;
		this.ExtraordinaryBlessings = new ObservableCollection<string>();
		this.ChooseVars = new List<string>();
		this.money = 100;
		this.VarsMap = new Dictionary<string, int>
		{
			{
				"Strength",
				Singleton<GameRuntimeData>.Instance.Gain["Strength"]
			},
			{
				"Lucky",
				Singleton<GameRuntimeData>.Instance.Gain["Lucky"]
			},
			{
				"Perceive",
				Singleton<GameRuntimeData>.Instance.Gain["Perceive"]
			},
			{
				"Wisdom",
				Singleton<GameRuntimeData>.Instance.Gain["Wisdom"]
			}
		};
		this.relicAddListener = null;
		base..ctor();
	}

	// Token: 0x040000CE RID: 206
	public ObservableCollection<DataConfig> cardList = new ObservableCollection<DataConfig>();

	// Token: 0x040000CF RID: 207
	public ObservableCollection<DataConfig> UnCardList = new ObservableCollection<DataConfig>();

	// Token: 0x040000D0 RID: 208
	public ObservableCollection<DataConfig> relicList = new ObservableCollection<DataConfig>();

	// Token: 0x040000D3 RID: 211
	public Dictionary<string, DataConfig> enchasedDict;

	// Token: 0x040000D4 RID: 212
	public Dictionary<string, int> GetCardReward;

	// Token: 0x040000D5 RID: 213
	public Dictionary<string, string> GetCard;

	// Token: 0x040000D6 RID: 214
	public int MoneyMultiplier;

	// Token: 0x040000D8 RID: 216
	public ObservableCollection<DataConfig> WithoutArmedRelicList;

	// Token: 0x040000D9 RID: 217
	public ObservableCollection<DataConfig> blessingConfigs;

	// Token: 0x040000DA RID: 218
	public Dictionary<string, bool> relicGets;

	// Token: 0x040000DD RID: 221
	public Dictionary<string, int> SkillTime;

	// Token: 0x040000DE RID: 222
	public int BuyBlessCount;

	// Token: 0x040000E0 RID: 224
	public int MaxAlCardCount;

	// Token: 0x040000E1 RID: 225
	public Dictionary<string, string> SpecialVarMap;

	// Token: 0x040000E5 RID: 229
	public int san;

	// Token: 0x040000E6 RID: 230
	public bool isDead;

	// Token: 0x040000E7 RID: 231
	public bool IsMoveOn;

	// Token: 0x040000E8 RID: 232
	public string Id;

	// Token: 0x040000E9 RID: 233
	public int SafeBoxRelicCount;

	// Token: 0x040000EA RID: 234
	public int SafeBoxCardCount;

	// Token: 0x040000EB RID: 235
	public int SafeBoxGetMoneyCount;

	// Token: 0x040000EC RID: 236
	public int SafeBoxSaveMoneyCount;

	// Token: 0x040000ED RID: 237
	public bool GetRelic;

	// Token: 0x040000EE RID: 238
	public bool GetCardInBack;

	// Token: 0x040000EF RID: 239
	public bool IsStarted;

	// Token: 0x040000F0 RID: 240
	public int maxSan;

	// Token: 0x040000F1 RID: 241
	public DataConfig Career;

	// Token: 0x040000F2 RID: 242
	public ObservableCollection<string> ExtraordinaryBlessings;

	// Token: 0x040000F3 RID: 243
	public List<string> ChooseVars;

	// Token: 0x040000F4 RID: 244
	public ObfuscatedInt money;

	// Token: 0x040000F5 RID: 245
	public Dictionary<string, int> VarsMap;

	// Token: 0x040000F6 RID: 246
	private NotifyCollectionChangedEventHandler relicAddListener;

	// Token: 0x040000F7 RID: 247
	private NotifyCollectionChangedEventHandler blessAddListener;

	// Token: 0x040000F8 RID: 248
	public int SpecialCount;
}

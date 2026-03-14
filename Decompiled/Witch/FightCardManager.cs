using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x020000BD RID: 189
public class FightCardManager : INotifyPropertyChanged
{
	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00035D24 File Offset: 0x00033F24
	public static FightCardManager Instance
	{
		get
		{
			return FightCardManager._lazyInstance.Value;
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x060005F5 RID: 1525 RVA: 0x00035D30 File Offset: 0x00033F30
	// (remove) Token: 0x060005F6 RID: 1526 RVA: 0x00035D68 File Offset: 0x00033F68
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event PropertyChangedEventHandler PropertyChanged;

	// Token: 0x060005F7 RID: 1527 RVA: 0x00035DA0 File Offset: 0x00033FA0
	public void Init()
	{
		this.FightcardList = new List<DataConfig>(RoleTable.Instance.cardList);
		this.CardTags = new Dictionary<DataConfig, HashSet<string>>();
		this.cardList = new ObservableCollection<DataConfig>();
		this.usedCardList = new ObservableCollection<DataConfig>();
		this.tempList = new List<DataConfig>();
		this.tempList.AddRange(this.FightcardList);
		foreach (DataConfig dataConfig in this.tempList)
		{
			this.CardTags.TryAdd(dataConfig, new HashSet<string>());
			string tags = dataConfig.Vars["Tag"].Replace(" ", "");
			foreach (string item in tags.Split(new char[]
			{
				'|',
				',',
				'，',
				' ',
				';',
				'；'
			}))
			{
				this.CardTags[dataConfig].Add(item);
			}
			bool flag = dataConfig.Vars.ContainsKey("SpecialTag");
			if (flag)
			{
				foreach (string item2 in dataConfig.Vars["SpecialTag"].Split(new char[]
				{
					'|',
					',',
					'，',
					' ',
					';',
					'；'
				}))
				{
					this.CardTags[dataConfig].Add(item2);
				}
			}
			bool flag2 = RoleTable.Instance.enchasedDict.ContainsKey(dataConfig.InstanceID);
			if (flag2)
			{
				DataConfig ench = RoleTable.Instance.enchasedDict[dataConfig.InstanceID];
				string enchtags = ench.Vars["Tag"].Replace(" ", "");
				foreach (string item3 in enchtags.Split(new char[]
				{
					'|',
					',',
					'，',
					' ',
					';',
					'；'
				}))
				{
					this.CardTags[dataConfig].Add(item3);
				}
			}
		}
		this.cardList = new ObservableCollection<DataConfig>(from x in this.tempList
		orderby FightManager.Instance.DefaultDice.Roll(null).Value
		select x);
		bool flag3 = !this.isInit;
		if (flag3)
		{
			this.isInit = true;
			NotifyCollectionChangedEventHandler usedCardChange = delegate(object sender, NotifyCollectionChangedEventArgs args)
			{
				bool flag4 = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
				if (flag4)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardsShow();
				}
				this.OnPropertyChanged("usedCardList");
			};
			this.cardChange = delegate(object sender, NotifyCollectionChangedEventArgs args)
			{
				bool flag4 = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
				if (flag4)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardsShow();
				}
				this.OnPropertyChanged("cardList");
			};
			this.cardList.CollectionChanged += this.cardChange;
			this.usedCardList.CollectionChanged += usedCardChange;
		}
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x00036074 File Offset: 0x00034274
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00036090 File Offset: 0x00034290
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

	// Token: 0x060005FA RID: 1530 RVA: 0x000360CC File Offset: 0x000342CC
	public void RandomIndex()
	{
		bool flag = this.usedCardList.Count > 0;
		if (flag)
		{
			Singleton<EventCenter>.Instance.EventTrigger("Shuffle" + FightPlayer.Instance.Status.InstanceId);
		}
		bool flag2 = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
		if (flag2)
		{
			UIManager.Instance.GetUI<FightUI>("FightUI").ShuffleCardItems();
		}
		this.tempList = this.usedCardList.ToList<DataConfig>();
		List<DataConfig> cardContainer = new List<DataConfig>();
		while (this.tempList.Count > 0)
		{
			int tempIndex = FightManager.Instance.DefaultDice.WithRange(0, this.tempList.Count - 1).Roll().Value;
			cardContainer.Add(this.tempList[tempIndex]);
			this.tempList.RemoveAt(tempIndex);
		}
		cardContainer.AddRange(this.cardList);
		this.cardList = new ObservableCollection<DataConfig>(cardContainer);
		this.cardList.CollectionChanged += this.cardChange;
		this.usedCardList.Clear();
	}

	/// <summary>
	/// 是否有卡
	/// </summary>
	/// <returns></returns>
	// Token: 0x060005FB RID: 1531 RVA: 0x000361F0 File Offset: 0x000343F0
	public bool HasCard()
	{
		return this.cardList.Count > 0;
	}

	/// <summary>
	/// 抽一张卡
	/// </summary>
	/// <returns></returns>
	// Token: 0x060005FC RID: 1532 RVA: 0x00036210 File Offset: 0x00034410
	public DataConfig DrawCard()
	{
		ObservableCollection<DataConfig> observableCollection = this.cardList;
		DataConfig r = observableCollection[observableCollection.Count - 1];
		this.cardList.Remove(r);
		return r;
	}

	// Token: 0x04000A77 RID: 2679
	private static readonly Lazy<FightCardManager> _lazyInstance = new Lazy<FightCardManager>(() => new FightCardManager());

	// Token: 0x04000A78 RID: 2680
	public ObservableCollection<DataConfig> cardList = new ObservableCollection<DataConfig>();

	// Token: 0x04000A79 RID: 2681
	public List<DataConfig> tempList = new List<DataConfig>();

	// Token: 0x04000A7A RID: 2682
	public ObservableCollection<DataConfig> usedCardList = new ObservableCollection<DataConfig>();

	// Token: 0x04000A7B RID: 2683
	public List<DataConfig> FightcardList = new List<DataConfig>();

	// Token: 0x04000A7C RID: 2684
	public Dictionary<DataConfig, HashSet<string>> CardTags = new Dictionary<DataConfig, HashSet<string>>();

	// Token: 0x04000A7D RID: 2685
	private bool isInit = false;

	// Token: 0x04000A7F RID: 2687
	private NotifyCollectionChangedEventHandler cardChange;

	// Token: 0x04000A80 RID: 2688
	private NotifyCollectionChangedEventHandler usedCardChange;
}

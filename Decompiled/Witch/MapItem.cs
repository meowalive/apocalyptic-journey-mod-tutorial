using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Data.Save;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x020000FE RID: 254
public class MapItem : Item, ICard, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x0600084C RID: 2124 RVA: 0x00041DF8 File Offset: 0x0003FFF8
	// (set) Token: 0x0600084D RID: 2125 RVA: 0x00041E00 File Offset: 0x00040000
	public bool ignore { get; set; }

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x0600084E RID: 2126 RVA: 0x00041E09 File Offset: 0x00040009
	// (set) Token: 0x0600084F RID: 2127 RVA: 0x00041E14 File Offset: 0x00040014
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
			}
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000850 RID: 2128 RVA: 0x00041E38 File Offset: 0x00040038
	// (set) Token: 0x06000851 RID: 2129 RVA: 0x00041E40 File Offset: 0x00040040
	public Vector2 initPosition
	{
		get
		{
			return this._initPosition;
		}
		set
		{
			this._initPosition = value;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06000852 RID: 2130 RVA: 0x00041E49 File Offset: 0x00040049
	// (set) Token: 0x06000853 RID: 2131 RVA: 0x00041E51 File Offset: 0x00040051
	public Vector3 initAngle { get; set; }

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000854 RID: 2132 RVA: 0x00041E5A File Offset: 0x0004005A
	// (set) Token: 0x06000855 RID: 2133 RVA: 0x00041E62 File Offset: 0x00040062
	public bool draging { get; set; }

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000856 RID: 2134 RVA: 0x00041E6B File Offset: 0x0004006B
	// (set) Token: 0x06000857 RID: 2135 RVA: 0x00041E73 File Offset: 0x00040073
	public int index { get; set; }

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000858 RID: 2136 RVA: 0x00041E7C File Offset: 0x0004007C
	public float initScale
	{
		get
		{
			return this.hasSelected ? 1f : 0.6f;
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000859 RID: 2137 RVA: 0x00041E92 File Offset: 0x00040092
	public float selectScale
	{
		get
		{
			return this.hasSelected ? 1.05f : 0.7f;
		}
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00041EA8 File Offset: 0x000400A8
	public override void Awake()
	{
		base.Awake();
		bool flag = !MapItem.uniTaskPrewarmed;
		if (flag)
		{
			MapItem.uniTaskPrewarmed = true;
			MapItem.PrewarmUniTask().Forget();
		}
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00041EE0 File Offset: 0x000400E0
	[DebuggerStepThrough]
	private static UniTaskVoid PrewarmUniTask()
	{
		MapItem.<PrewarmUniTask>d__33 <PrewarmUniTask>d__ = new MapItem.<PrewarmUniTask>d__33();
		<PrewarmUniTask>d__.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
		<PrewarmUniTask>d__.<>1__state = -1;
		<PrewarmUniTask>d__.<>t__builder.Start<MapItem.<PrewarmUniTask>d__33>(ref <PrewarmUniTask>d__);
		return <PrewarmUniTask>d__.<>t__builder.Task;
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00041F20 File Offset: 0x00040120
	public virtual void Init(MapTree.Node node1)
	{
		bool NeedResetPos = true;
		this.currentSystem = EventSystem.current;
		this.lastParent = base.transform.parent;
		Texture2D sprite = null;
		this.node = node1;
		this.keywordDisplay = (base.gameObject.GetComponent<KeywordDisplay>() ?? base.gameObject.AddComponent<KeywordDisplay>());
		this.ItemType = "Map";
		bool flag = this.node.data["Type"] == "Fight";
		Texture2D raritySprite;
		if (flag)
		{
			Dictionary<string, string> levelData = Singleton<GameConfigManager>.Instance.GetOne(DataType.Level, this.node.data["NodeId"]);
			string[] enemys = levelData["EnemyIds"].Replace(" ", "").Split(',', StringSplitOptions.None);
			int maxEnemyHp = 0;
			DataConfig enemyData = null;
			foreach (string item in enemys)
			{
				DataConfig tempData = new DataConfig(item, DataType.Enemy);
				bool flag2 = int.Parse(tempData.data["Hp"]) > maxEnemyHp;
				if (flag2)
				{
					maxEnemyHp = int.Parse(tempData.data["Hp"]);
					enemyData = tempData;
				}
			}
			int Attack = (int)((float)int.Parse(enemyData.data["Attack"]) * (1f + (float)GameSaveManager.GetValue<int>(GameVar.EXEnemyAtk) / 100f) * (MapManager.Instance.SumOfEnemyPositive * 0.4f + 0.6f));
			int MaxHp = (int)((float)int.Parse(enemyData.data["Hp"]) * (MapManager.Instance.SumOfEnemyPositive + 0.2f) * (1f + (float)GameSaveManager.GetValue<int>(GameVar.EXEnemyHp) / 100f) * (float)GameEntryUI.playerCount);
			base.transform.Find("Front/Attribute/Attack/text").GetComponent<TMP_Text>().text = Attack.ToString();
			base.transform.Find("Front/Attribute/Health/text").GetComponent<TMP_Text>().text = MaxHp.ToString();
			Texture2D[] sprites = ResourceLoader.LoadAll<Texture2D>(enemyData.data["Animation"] + "/Map");
			bool flag3 = sprites.Length != 0;
			if (flag3)
			{
				sprite = sprites[0];
			}
			bool flag4 = sprite == null;
			if (flag4)
			{
				sprite = ResourceLoader.LoadAll<Texture2D>(enemyData.data["Animation"] + "/Idle")[0];
			}
			else
			{
				NeedResetPos = false;
			}
			bool flag5 = levelData["Note"].Contains("精英");
			if (flag5)
			{
				raritySprite = ResourceLoader.Load<Texture2D>("Icon/CardTemplate/Template/稀有度/2", true);
			}
			else
			{
				bool flag6 = levelData["Note"].Contains("boss");
				if (flag6)
				{
					raritySprite = ResourceLoader.Load<Texture2D>("Icon/CardTemplate/Template/稀有度/3", true);
				}
				else
				{
					bool flag7 = levelData["Note"].Contains("无名");
					if (flag7)
					{
						raritySprite = ResourceLoader.Load<Texture2D>("Icon/CardTemplate/Template/稀有度/3", true);
					}
					else
					{
						raritySprite = ResourceLoader.Load<Texture2D>("Icon/CardTemplate/Template/稀有度/1", true);
					}
				}
			}
			int count = RoleTable.Instance.ReturnMoneyCal(int.Parse(this.node.data.GetValueOrDefault("Money", "0")));
		}
		else
		{
			bool flag8 = this.node.data["Type"] == "Build";
			if (flag8)
			{
				bool flag9 = this.node.data["NodeId"] == "Breaks";
				if (flag9)
				{
					sprite = ResourceLoader.Load<Texture2D>("Icon/Map/建筑  一息安隅", true);
				}
				else
				{
					bool flag10 = this.node.data["NodeId"] == "shop";
					if (flag10)
					{
						sprite = ResourceLoader.Load<Texture2D>("Icon/Map/旅行商人", true);
					}
					else
					{
						bool flag11 = this.node.data["NodeId"] == "tree";
						if (flag11)
						{
							sprite = ResourceLoader.Load<Texture2D>("Icon/Map/天界赐福", true);
						}
						else
						{
							bool flag12 = this.node.data["NodeId"] == "ench";
							if (flag12)
							{
								sprite = ResourceLoader.Load<Texture2D>("Icon/Map/血脉铭刻", true);
							}
							else
							{
								sprite = ResourceLoader.Load<Texture2D>("Icon/Map/建筑  新的起点", true);
							}
						}
					}
				}
			}
			else
			{
				sprite = ResourceLoader.Load<Texture2D>("Icon/Map/事件  新的故事", true);
			}
			raritySprite = ResourceLoader.Load<Texture2D>("Icon/CardTemplate/Template/稀有度/2", true);
		}
		base.transform.Find("Front/rarity").GetComponent<MeshRenderer>().material.mainTexture = raritySprite;
		base.transform.Find("Front/icon").GetComponent<MeshRenderer>().material.mainTexture = sprite;
		bool flag13 = NeedResetPos;
		if (flag13)
		{
			Vector2 size = new Vector2((float)sprite.width, (float)sprite.height);
			TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(sprite, 0.1f);
			Vector2 realSize = new Vector2(size.x - (float)realBounds.leftTransparentWidth - (float)realBounds.rightTransparentWidth, size.y - (float)realBounds.topTransparentHeight - (float)realBounds.bottomTransparentHeight);
			Vector2 offset = new Vector2((float)(realBounds.rightTransparentWidth - realBounds.leftTransparentWidth), (float)(realBounds.topTransparentHeight - realBounds.bottomTransparentHeight)) / 2f;
			bool flag14 = this.node.data["Type"] == "Fight";
			if (flag14)
			{
				bool flag15 = realSize.x > 160f;
				if (flag15)
				{
					float scaleFactor = 160f / realSize.x;
					size *= scaleFactor;
					realSize *= scaleFactor;
					offset *= scaleFactor;
				}
				bool flag16 = realSize.y > 238f;
				if (flag16)
				{
					float scaleFactor2 = 238f / realSize.y;
					size *= scaleFactor2;
					offset *= scaleFactor2;
				}
			}
			base.transform.Find("Front/icon").localScale = size;
			base.transform.Find("Front/icon").GetComponent<RectTransform>().anchoredPosition += offset;
		}
		this.DataUpdate();
		this.animationController = new CardAnimationController();
		this.animationController.Initialize(base.transform, this);
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0004257C File Offset: 0x0004077C
	public override void DataUpdate()
	{
		bool flag = this.node == null;
		if (!flag)
		{
			bool flag2 = this.node.data["Type"] == "Fight";
			if (flag2)
			{
				base.transform.Find("Front/Attribute/Name").GetComponent<TMP_Text>().text = this.node.data.Localize("Name");
				Dictionary<string, string> levelData = Singleton<GameConfigManager>.Instance.GetOne(DataType.Level, this.node.data["NodeId"]);
				string[] enemys = levelData["EnemyIds"].Replace(" ", "").Split(',', StringSplitOptions.None);
				string attributeText = "";
				List<string> keywords = new List<string>();
				int i = 1;
				foreach (string item in enemys)
				{
					Dictionary<string, string> data = Singleton<GameConfigManager>.Instance.GetOne(DataType.Enemy, item);
					foreach (string item2 in data["AttributeText"].Split(";", StringSplitOptions.None))
					{
						bool flag3 = item2 == "" || item2 == " ";
						if (!flag3)
						{
							attributeText = string.Concat(new string[]
							{
								attributeText,
								data.Localize("Name"),
								"  ",
								"characteristic".Localize("MapSelectUI"),
								"  ",
								Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, item2).Localize("Name"),
								"\n"
							});
							bool flag4 = i <= 4;
							if (flag4)
							{
								base.transform.Find("Front/Attribute/Attr" + i.ToString() + "/text").GetComponent<TMP_Text>().text = Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, item2).Localize("Name") + "\n";
								i++;
							}
						}
					}
				}
				bool flag5 = enemys.Length > 1 && i <= 4;
				if (flag5)
				{
					base.transform.Find("Front/Attribute/Attr" + i.ToString() + "/text").GetComponent<TMP_Text>().text = "成群结队".Localize("MapSelectUI") + "\n";
				}
				this.keywordDisplay.title = "characteristic".Localize("MapSelectUI");
				this.keywordDisplay.text = this.node.data.Localize("Description") + "\n" + Singleton<TextTranslator>.Instance.Translate(attributeText, keywords) + "\n";
				this.keywordDisplay.keyWords = keywords;
				this.keywordDisplay.type = "DesMap";
			}
			else
			{
				base.transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().text = this.node.data.Localize("Name");
				this.keywordDisplay.title = "Map contents".Localize("MapSelectUI");
				this.keywordDisplay.text = this.node.data.Localize("Description");
				this.keywordDisplay.type = "DesMap";
				base.transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().text = this.node.data.Localize("Description");
			}
		}
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00042930 File Offset: 0x00040B30
	public override void OnPointerEnter(PointerEventData eventData)
	{
		bool flag = UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI") != null && UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").IsAnimating;
		if (!flag)
		{
			bool flag2 = base.name == "Null" || base.transform.parent.name == "Content";
			if (!flag2)
			{
				this.index = base.transform.GetSiblingIndex();
				this.animationController.PlayEnterAnimation(new Vector2(this.initPosition.x, 10f), this.selectScale);
				this.animationController.StartRandomRotation();
			}
		}
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x000429F0 File Offset: 0x00040BF0
	public override void OnPointerExit(PointerEventData eventData)
	{
		bool flag = base.name == "Null" || base.transform.parent.name == "Content";
		if (!flag)
		{
			this.animationController.PlayExitAnimation(this.initPosition, this.initScale);
		}
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x000026D9 File Offset: 0x000008D9
	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00042A4C File Offset: 0x00040C4C
	public virtual void OnPointerDown(PointerEventData eventData)
	{
		bool flag = base.name == "Null";
		if (!flag)
		{
			Transform nullItem = base.transform.parent.GetChild(base.transform.parent.childCount - 1);
			bool flag2 = nullItem.name != "Null" && base.transform.parent.name == "Content";
			if (!flag2)
			{
				bool flag3 = this.isLine || eventData.button == PointerEventData.InputButton.Right;
				if (!flag3)
				{
					this.currentSystem.enabled = false;
					this.StartLine().Forget();
				}
			}
		}
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00042B00 File Offset: 0x00040D00
	[DebuggerStepThrough]
	public virtual UniTask StartLine()
	{
		MapItem.<StartLine>d__42 <StartLine>d__ = new MapItem.<StartLine>d__42();
		<StartLine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartLine>d__.<>4__this = this;
		<StartLine>d__.<>1__state = -1;
		<StartLine>d__.<>t__builder.Start<MapItem.<StartLine>d__42>(ref <StartLine>d__);
		return <StartLine>d__.<>t__builder.Task;
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x000026D9 File Offset: 0x000008D9
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00042B44 File Offset: 0x00040D44
	public override void OnDestroy()
	{
		this.des = true;
		this.RemoveFromParent();
		this.ClearEvent();
		DOTween.Kill(base.transform, false);
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x000026D9 File Offset: 0x000008D9
	public override void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00042B6C File Offset: 0x00040D6C
	public virtual void RayCheck()
	{
		bool flag = !this.isLine || UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").IsAnimating;
		if (!flag)
		{
			bool flag2 = KeyManager.playerAction.Main.Click.WasReleasedThisFrame();
			if (flag2)
			{
				this.isLine = false;
				this.currentSystem.enabled = true;
				base.gameObject.GetComponent<ObjectGroup>().blocksRaycasts = false;
				Cursor.visible = true;
				bool flag3 = UIManager.Instance.GetUI<LineUI>("LineUI") != null;
				if (flag3)
				{
					UIManager.Instance.GetUI<LineUI>("LineUI").Hide();
				}
				PointerEventData pointerEventData = new PointerEventData(EventSystem.current)
				{
					position = KeyManager.playerAction.Main.Point.ReadValue<Vector2>(),
					button = PointerEventData.InputButton.Left
				};
				bool flag4 = this.hasSelected;
				if (flag4)
				{
					this.lastPos = base.transform.GetComponent<RectTransform>().localPosition;
				}
				else
				{
					this.lastPos = this.initPosition;
				}
				Transform tempParent = base.transform.parent;
				base.OnEndDrag(pointerEventData);
				this.animationController.StopRotation();
				this.animationController.moveTween.Kill(false);
				this.animationController.scaleTween.Kill(false);
				base.transform.DOKill(false);
				bool flag5 = base.transform.parent == tempParent;
				if (flag5)
				{
					base.gameObject.GetComponent<ObjectGroup>().blocksRaycasts = true;
				}
				else
				{
					UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").SetNodes();
					bool flag6 = !this.hasSelected;
					if (flag6)
					{
						this.hasSelected = true;
						this.initAngle = new Vector3(0f, 0f, 0f);
						UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
						{
							UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").UpdateCardItemPos();
						}).Forget();
						base.transform.DOScale(this.initScale, 0.3f).OnComplete(delegate
						{
							base.gameObject.GetComponent<ObjectGroup>().blocksRaycasts = true;
							base.gameObject.GetComponent<SortingGroup>().sortingOrder = 6;
						});
					}
					else
					{
						bool flag7 = base.transform.parent.name == "MapSelect";
						if (flag7)
						{
							this.hasSelected = false;
							RectTransform rectTransform = base.GetComponent<RectTransform>();
							rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
							rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
							base.transform.DOScale(this.initScale, 0.3f).OnComplete(delegate
							{
								base.gameObject.GetComponent<ObjectGroup>().blocksRaycasts = true;
							});
							UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
							{
								UIManager.Instance.GetUI<MapSelectUI>("MapSelectUI").UpdateCardItemPos();
							}).Forget();
						}
						else
						{
							base.gameObject.GetComponent<ObjectGroup>().blocksRaycasts = true;
							base.transform.parent.GetComponent<VerticalLayoutGroup>().CalculateLayoutInputHorizontal();
						}
					}
				}
			}
		}
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00042EB0 File Offset: 0x000410B0
	public override void RemoveFromParent()
	{
		base.RemoveFromParent();
		bool flag = base.transform.parent.parent.Find("Frame") != null;
		if (flag)
		{
			base.transform.parent.parent.Find("Frame").GetComponent<Image>().enabled = true;
		}
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00042F14 File Offset: 0x00041114
	public override void OnTransformParentChanged()
	{
		base.OnTransformParentChanged();
		bool flag = base.transform.parent.parent.Find("Frame") != null;
		if (flag)
		{
			base.transform.parent.parent.Find("Frame").GetComponent<Image>().enabled = false;
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00042F78 File Offset: 0x00041178
	public override void AddToList(SwapContentIdentity item)
	{
		bool flag = base.transform.GetComponent<CanvasGroup>();
		if (flag)
		{
			base.transform.GetComponent<CanvasGroup>().blocksRaycasts = true;
		}
		bool flag2 = base.transform.GetComponent<ObjectGroup>();
		if (flag2)
		{
			base.transform.GetComponent<ObjectGroup>().blocksRaycasts = true;
		}
		bool flag3 = item == null || item.Content == this.lastParent || !item.Content.Find("Null") || item.Content == base.transform.parent || item.Content == null;
		if (flag3)
		{
			bool flag4 = this.lastPos != Vector2.zero;
			if (flag4)
			{
				base.transform.GetComponent<RectTransform>().localPosition = this.lastPos;
			}
		}
		else
		{
			Transform nullItem = item.Content.transform.Find("Null");
			bool flag5 = !nullItem.gameObject.activeSelf;
			if (flag5)
			{
				bool flag6 = this.lastPos != Vector2.zero;
				if (flag6)
				{
					base.transform.GetComponent<RectTransform>().localPosition = this.lastPos;
				}
			}
			else
			{
				base.transform.SetParent(item.Content);
			}
		}
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x000026D9 File Offset: 0x000008D9
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x000430D6 File Offset: 0x000412D6
	public void SetIndex(int Index)
	{
		this.index = Index;
		base.transform.SetSiblingIndex(this.index);
	}

	// Token: 0x04000BB0 RID: 2992
	private bool _reverse;

	// Token: 0x04000BB1 RID: 2993
	public MapTree.Node node;

	// Token: 0x04000BB2 RID: 2994
	public CardAnimationController animationController;

	// Token: 0x04000BB3 RID: 2995
	[SerializeField]
	private Vector2 _initPosition;

	// Token: 0x04000BB4 RID: 2996
	public bool hasSelected;

	// Token: 0x04000BB8 RID: 3000
	private static bool uniTaskPrewarmed;

	// Token: 0x04000BB9 RID: 3001
	protected bool isLine;

	// Token: 0x04000BBA RID: 3002
	protected EventSystem currentSystem;

	// Token: 0x04000BBB RID: 3003
	public bool des;
}

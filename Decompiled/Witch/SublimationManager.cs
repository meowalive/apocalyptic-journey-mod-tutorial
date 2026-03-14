using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Data.Save;
using Mirror;
using Mirror.RemoteCalls;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;
using ZLinq;
using ZLinq.Linq;

namespace Witch
{
	// Token: 0x0200023A RID: 570
	public class SublimationManager : NetworkBehaviour, IModeManager
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0008FC71 File Offset: 0x0008DE71
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x0008FC79 File Offset: 0x0008DE79
		public bool lazyLoad { get; set; } = true;

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0008FC82 File Offset: 0x0008DE82
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x0008FC8A File Offset: 0x0008DE8A
		public Dice NowDice { get; set; } = Dice.Default;

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0008FC93 File Offset: 0x0008DE93
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x0008FC9B File Offset: 0x0008DE9B
		public int Level { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00038DF2 File Offset: 0x00036FF2
		public MapTree MapTree
		{
			get
			{
				return GameSaveManager.MapTree;
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0008FCA4 File Offset: 0x0008DEA4
		public void ReadyToChangeMap()
		{
			bool flag = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
			if (flag)
			{
				FightManager.Instance.ChangeUnit(FightType.None);
			}
			bool flag2 = this.Level >= 30;
			if (flag2)
			{
				UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
			}
			else
			{
				bool flag3 = this.Level % 6 == 0;
				if (flag3)
				{
					this.GeneratrMap();
				}
				bool inHighTide = RoleTable.Instance.InHighTide;
				if (inHighTide)
				{
					this.ShowMapSelect();
				}
				else
				{
					bool flag4 = this.Level % 12 == 11;
					if (flag4)
					{
						PlayerManager.Instance.CmdChangeHide();
						this.RpcLoadMap("event", "event_999");
					}
					else
					{
						bool flag5 = this.Level == 29;
						if (flag5)
						{
							PlayerManager.Instance.CmdChangeHide();
							this.RpcLoadMap("event", "event_1000");
						}
						else
						{
							this.ShowMapSelect();
						}
					}
				}
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0008FDA8 File Offset: 0x0008DFA8
		public void GeneratrMap()
		{
			bool flag = this.MapTree.hasUsed.Contains(this.Level / 6);
			if (!flag)
			{
				this.MapTree.hasUsed.Add(this.Level / 6);
				List<Dictionary<string, string>> eventData = Singleton<GameConfigManager>.Instance.GetTable(DataType.Event).Getlines();
				eventData = (from x in eventData.AsValueEnumerable<Dictionary<string, string>>()
				where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"]) && !x["Id"].Contains("Sub")
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				this.RandomGenerate();
				switch (this.Level / 6)
				{
				case 0:
				case 2:
				{
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("普通事件"));
					List<MapTree.Node> defaultNode = this.MapTree.DefaultNode;
					defaultNode[defaultNode.Count - 1].data["NodeId"] = eventData[this.MapTree.treedice.WithRange(0, eventData.Count - 1).Roll().Value]["Id"];
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
					bool flag2 = GameSaveManager.GetValue<int>(GameVar.ExLockDes) > 0;
					if (flag2)
					{
						for (int i = 0; i < GameSaveManager.GetValue<int>(GameVar.ExLockDes); i++)
						{
							this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
						}
					}
					break;
				}
				case 1:
				case 3:
				{
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("普通事件"));
					List<MapTree.Node> defaultNode2 = this.MapTree.DefaultNode;
					defaultNode2[defaultNode2.Count - 1].data["NodeId"] = eventData[this.MapTree.treedice.WithRange(0, eventData.Count - 1).Roll().Value]["Id"];
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("首领"));
					bool flag3 = GameSaveManager.GetValue<int>(GameVar.ExLockDes) > 0;
					if (flag3)
					{
						for (int j = 0; j < GameSaveManager.GetValue<int>(GameVar.ExLockDes); j++)
						{
							this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
						}
					}
					break;
				}
				case 4:
				{
					MapTree.Node node;
					bool flag4;
					do
					{
						node = this.MapTree.TypeGenerate("建筑");
						flag4 = (node.data["NodeId"] == "Breaks");
					}
					while (!flag4);
					this.MapTree.DefaultNode.Add(node);
					this.MapTree.DefaultNode.Add(new MapTree.Node("首领")
					{
						data = Singleton<GameConfigManager>.Instance.GetOne(DataType.Map, "map_0"),
						NodeDice = this.MapTree.treedice.WithCursor(this.MapTree.treedice.Roll().Value)
					});
					bool flag5 = GameSaveManager.GetValue<int>(GameVar.ExLockDes) > 0;
					if (flag5)
					{
						for (int k = 0; k < GameSaveManager.GetValue<int>(GameVar.ExLockDes); k++)
						{
							this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
						}
					}
					break;
				}
				}
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00090148 File Offset: 0x0008E348
		public void RandomGenerate()
		{
			float decay = 0.1f;
			int tempcount = 8 - GameSaveManager.GetValue<int>(GameVar.ExDeleteDes);
			Dictionary<string, float> typeWeightDic;
			switch (this.Level / 6)
			{
			case 0:
			case 1:
				typeWeightDic = new Dictionary<string, float>
				{
					{
						"首领",
						0f
					},
					{
						"精英",
						0.25f
					},
					{
						"普通",
						0.3f
					},
					{
						"普通事件",
						0.1f
					},
					{
						"建筑",
						0.35f
					}
				};
				break;
			case 2:
			case 3:
				typeWeightDic = new Dictionary<string, float>
				{
					{
						"首领",
						0f
					},
					{
						"精英",
						0.25f
					},
					{
						"普通",
						0.3f
					},
					{
						"普通事件",
						0.15f
					},
					{
						"建筑",
						0.3f
					}
				};
				break;
			case 4:
				typeWeightDic = new Dictionary<string, float>
				{
					{
						"首领",
						0f
					},
					{
						"精英",
						0.25f
					},
					{
						"普通",
						0.2f
					},
					{
						"普通事件",
						0.2f
					},
					{
						"建筑",
						0.35f
					}
				};
				break;
			default:
				typeWeightDic = null;
				break;
			}
			Dictionary<string, float> tempType = new Dictionary<string, float>(typeWeightDic);
			foreach (KeyValuePair<string, float> item in tempType)
			{
				typeWeightDic[item.Key] = item.Value + float.Parse(GameSaveManager.GetValue<string>(item.Key));
			}
			List<Dictionary<string, string>> mapList = Singleton<GameConfigManager>.Instance.GetTable(DataType.Map).Getlines();
			List<Dictionary<string, string>> mapTypes = new List<Dictionary<string, string>>();
			while (tempcount > 0)
			{
				List<Dictionary<string, string>> mapType = new RandomPool(mapList, this.MapTree.treedice).DrawByNote(1, typeWeightDic);
				bool flag = mapType.Count == 0;
				if (flag)
				{
					Debug.LogWarning("没有符合条件的地点");
				}
				else
				{
					mapTypes.Add(mapType[0]);
					tempcount--;
					Dictionary<string, float> dictionary = typeWeightDic;
					string key = mapType[0]["Note"];
					dictionary[key] *= decay;
				}
			}
			List<string> types = (from x in mapTypes
			select x["Note"]).Distinct<string>().ToList<string>();
			List<Dictionary<string, string>> maps = new List<Dictionary<string, string>>();
			using (List<string>.Enumerator enumerator2 = types.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					string type = enumerator2.Current;
					int typeCount = 0;
					foreach (Dictionary<string, string> item2 in mapTypes)
					{
						bool flag2 = item2["Note"] == type;
						if (flag2)
						{
							typeCount++;
						}
					}
					List<Dictionary<string, string>> tempList = new List<Dictionary<string, string>>(mapList);
					bool flag3 = type == "首领" || type == "精英" || type == "普通";
					if (flag3)
					{
						foreach (Dictionary<string, string> child in tempList)
						{
							bool flag4 = !child.ContainsKey("Level");
							if (flag4)
							{
								foreach (KeyValuePair<string, string> item3 in child)
								{
									Debug.LogError("地图数据缺少Level字段: " + item3.Key + " - " + item3.Value);
								}
							}
						}
						tempList = (from x in tempList.AsValueEnumerable<Dictionary<string, string>>()
						where int.Parse(x["Level"]) == MapManager.Instance.ModeMapManager.Level / 12 || x["Level"] == "-1"
						select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
					}
					maps = maps.Concat(new RandomPool((from x in tempList
					where x["Note"] == type
					select x).ToList<Dictionary<string, string>>(), this.MapTree.treedice).DrawByCount(typeCount)).ToList<Dictionary<string, string>>();
				}
			}
			List<Dictionary<string, string>> eventData = Singleton<GameConfigManager>.Instance.GetTable(DataType.Event).Getlines();
			eventData = (from x in eventData.AsValueEnumerable<Dictionary<string, string>>()
			where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"]) && !x["Id"].Contains("Sub")
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			for (int i = 0; i < maps.Count; i++)
			{
				Dictionary<string, string> dataCopy = new Dictionary<string, string>(maps[i]);
				MapTree.Node node = new MapTree.Node(maps[i]["Note"])
				{
					data = dataCopy
				};
				bool flag5 = node.data["Type"] == "Event";
				if (flag5)
				{
					node.data["NodeId"] = eventData[this.MapTree.treedice.WithRange(0, eventData.Count - 1).Roll().Value]["Id"];
				}
				node.NodeDice = this.MapTree.treedice.WithCursor(this.MapTree.treedice.Roll().Value);
				this.MapTree.SelectNode.Add(node);
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0008D67C File Offset: 0x0008B87C
		public void CloseMapUI()
		{
			UIManager.Instance.CloseUI("MapSelectUI");
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000907A4 File Offset: 0x0008E9A4
		[ClientRpc]
		public void ShowMapSelect()
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			this.SendRPCInternal("System.Void Witch.SublimationManager::ShowMapSelect()", -2064462849, writer, 0, true);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000907D4 File Offset: 0x0008E9D4
		[ClientRpc]
		public void RpcLoadMap(string type, string id)
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			writer.WriteString(type);
			writer.WriteString(id);
			this.SendRPCInternal("System.Void Witch.SublimationManager::RpcLoadMap(System.String,System.String)", -1625249749, writer, 0, true);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00090818 File Offset: 0x0008EA18
		public void MapItemInit(MapSelectUI mapSelectUI)
		{
			bool flag = this.MapTree.currentNode.depth == 0;
			if (flag)
			{
				this.MapTree.currentNode.depth = -1;
			}
			mapSelectUI.CreateNodes(6);
			this.MapTree.currentNode = this.MapTree.currentNode.GetChild(0);
			GameSaveManager.UpdateNode(this.MapTree.currentNode);
			MapTree.Node[] MapNodes = mapSelectUI.GetNodes();
			mapSelectUI.transform.Find("Map").GetComponent<CanvasGroup>().blocksRaycasts = true;
			int oneLevelCount = 2 + GameSaveManager.GetValue<int>(GameVar.ExLockDes);
			MapTree.Node node0 = this.MapTree.DefaultNode[oneLevelCount * MapManager.Instance.Level / 6];
			MapNodes[0].data = node0.data;
			MapNodes[0].NodeDice = node0.NodeDice;
			MapTree.Node node = this.MapTree.DefaultNode[oneLevelCount * MapManager.Instance.Level / 6 + 1];
			MapTree.Node[] array = MapNodes;
			array[array.Length - 1].data = node.data;
			MapTree.Node[] array2 = MapNodes;
			array2[array2.Length - 1].NodeDice = node.NodeDice;
			GameObject newGame = UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("MapSelect/EventPrefab").gameObject, mapSelectUI.transform.Find("Map/NodeContent/Start/Content"));
			newGame.SetActive(true);
			newGame.transform.localScale = Vector3.one;
			newGame.name = "EventPrefab";
			bool flag2 = node0.data["Type"] == "Build";
			if (flag2)
			{
				newGame.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/建筑牌", true);
			}
			else
			{
				bool flag3 = node0.data["Type"] == "Event";
				if (flag3)
				{
					newGame.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/故事牌", true);
				}
			}
			GameObject fightObj = UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("MapSelect/FightPrefab").gameObject, mapSelectUI.transform.Find("Map/NodeContent/End/Content"));
			fightObj.transform.localScale = Vector3.one;
			fightObj.name = "FightPrefab";
			fightObj.SetActive(true);
			MapItem mapItem = fightObj.AddComponent<MapItem>();
			MapTree.Node[] array3 = MapNodes;
			mapItem.Init(array3[array3.Length - 1]);
			mapSelectUI.transform.Find("Map/NodeContent/End/Content/FightPrefab").GetComponent<ObjectGroup>().blocksRaycasts = false;
			UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("Chain").gameObject, mapSelectUI.transform.Find("Map/NodeContent/End/Frame")).SetActive(true);
			for (int i = 2; i <= Mathf.Min(oneLevelCount - 1, 5); i++)
			{
				bool flag4 = oneLevelCount * MapManager.Instance.Level / 6 + i > this.MapTree.DefaultNode.Count - 1;
				if (flag4)
				{
					break;
				}
				MapTree.Node[] array4 = MapNodes;
				array4[array4.Length - i].data = this.MapTree.DefaultNode[oneLevelCount * MapManager.Instance.Level / 6 + i].data;
				MapTree.Node[] array5 = MapNodes;
				array5[array5.Length - i].NodeDice = this.MapTree.DefaultNode[oneLevelCount * MapManager.Instance.Level / 6 + i].NodeDice;
				mapSelectUI.transform.Find("Map/NodeContent/Node" + (6 - i).ToString()).Find("Content/Null").gameObject.gameObject.SetActive(false);
				GameObject tempGame = UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("MapSelect/FightPrefab").gameObject, mapSelectUI.transform.Find("Map/NodeContent/Node" + (6 - i).ToString()).Find("Content"));
				tempGame.transform.localScale = Vector3.one;
				MapItem mapItem2 = tempGame.AddComponent<MapItem>();
				MapTree.Node[] array6 = MapNodes;
				mapItem2.Init(array6[array6.Length - i]);
				tempGame.SetActive(true);
				tempGame.GetComponent<ObjectGroup>().blocksRaycasts = false;
				UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("Chain").gameObject, mapSelectUI.transform.Find("Map/NodeContent/Node" + (6 - i).ToString()).Find("Frame")).SetActive(true);
			}
			mapSelectUI.transform.Find("Map/NodeContent/Start/Content/EventPrefab").gameObject.AddComponent<MapItem>().Init(MapNodes[0]);
			mapSelectUI.transform.Find("Map/NodeContent/Start/Content/EventPrefab").GetComponent<ObjectGroup>().blocksRaycasts = false;
			UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("Chain").gameObject, mapSelectUI.transform.Find("Map/NodeContent/Start/Frame")).SetActive(true);
			mapSelectUI.SendNode();
			mapSelectUI.ReadyToSelect();
			for (int j = 0; j < 6 - oneLevelCount; j++)
			{
				GameObject tempGame2 = UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("MapSelect/NullPrefab").gameObject, mapSelectUI.transform.Find("MapSelect"));
				tempGame2.AddComponent<MapItem>();
				tempGame2.name = "Null";
				tempGame2.GetComponent<ObjectGroup>().blocksRaycasts = true;
				tempGame2.SetActive(false);
				tempGame2.transform.SetAsLastSibling();
			}
			bool isServer = PlayerManager.Instance.isServer;
			if (isServer)
			{
				GameServer.Instance.SaveGame();
			}
			SafeBoxUI.SafeboxSave();
			Singleton<GameRuntimeData>.Instance.Save();
			mapSelectUI.MapAnimation();
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00090DDC File Offset: 0x0008EFDC
		public void SetReward(BattleRewardsUI battleRewardsUI)
		{
			int count = 1;
			this.hasBless = false;
			int LastFeat = Fight_Win.RewardMul;
			bool flag = RoleTable.Instance.Reward != 0;
			if (flag)
			{
				count += RoleTable.Instance.Reward;
				RoleTable.Instance.Reward = 0;
			}
			battleRewardsUI.SetMoney(LastFeat * 35 + 10 + this.NowDice.WithRange(-10, 10).Roll().Value + int.Parse(GameSaveManager.GetValue<string>("Difficulty")) * 2);
			for (int i = 0; i < count; i++)
			{
				this.RandomSetReward(battleRewardsUI);
			}
			List<Dictionary<string, string>> relics = Singleton<GameConfigManager>.Instance.GetTable(DataType.Relic).Getlines();
			bool inHighTide = RoleTable.Instance.InHighTide;
			if (inHighTide)
			{
				List<Dictionary<string, string>> newRelics = (from x in relics.AsValueEnumerable<Dictionary<string, string>>()
				where x["Rarity"] == "4" && !RoleTable.Instance.relicGets.ContainsKey(x["Id"])
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				bool flag2 = RoleTable.Instance.relicGets.Count == relics.Count;
				if (flag2)
				{
					newRelics = (from x in relics.AsValueEnumerable<Dictionary<string, string>>()
					where x["Rarity"] == "4"
					select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				}
				battleRewardsUI.RandomSetRelic(newRelics);
				battleRewardsUI.RandomAddBless();
			}
			bool flag3 = EnemyManager.levelData["Note"] == "精英" || (EnemyManager.levelData["Note"] == "boss" && !RoleTable.Instance.InHighTide);
			if (flag3)
			{
				List<Dictionary<string, string>> newRelics2 = (from x in relics.AsValueEnumerable<Dictionary<string, string>>()
				where x["Rarity"] != "4" && !RoleTable.Instance.relicGets.ContainsKey(x["Id"])
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				bool flag4 = RoleTable.Instance.relicGets.Count == relics.Count;
				if (flag4)
				{
					newRelics2 = (from x in relics.AsValueEnumerable<Dictionary<string, string>>()
					where x["Rarity"] != "4"
					select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				}
				battleRewardsUI.RandomSetRelic(newRelics2);
			}
			battleRewardsUI.item1.SetActive(false);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00091022 File Offset: 0x0008F222
		public void RandomSetReward(BattleRewardsUI battleRewardsUI)
		{
			battleRewardsUI.RandomAddBless();
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0009102C File Offset: 0x0008F22C
		public bool CanResetSafeBox()
		{
			return false;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00091040 File Offset: 0x0008F240
		public bool WinTheGame()
		{
			return this.Level >= 30;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0009106C File Offset: 0x0008F26C
		public RoleTable InitRoleTable(RoleTable roleTable)
		{
			roleTable.GetCardReward = new Dictionary<string, int>
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
			roleTable.cardList = new ObservableCollection<DataConfig>();
			roleTable.UnCardList = new ObservableCollection<DataConfig>();
			roleTable.relicList = new ObservableCollection<DataConfig>();
			roleTable.WithoutArmedRelicList = new ObservableCollection<DataConfig>();
			roleTable.blessingConfigs = new ObservableCollection<DataConfig>();
			roleTable.Listen();
			roleTable.Money += Singleton<GameRuntimeData>.Instance.Gain["firstMoney"];
			roleTable.CardBottomCount = 0;
			roleTable.CardTopCount = 30;
			bool flag = Singleton<GameRuntimeData>.Instance.BuyedItems.ContainsKey("outsideshop_10");
			if (flag)
			{
				roleTable.blessingConfigs.Add(new DataConfig("blessing_35", DataType.Bless));
			}
			return roleTable;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00091191 File Offset: 0x0008F391
		public void CardCountSet(RoleTable roleTable)
		{
			roleTable.CardBottomCount = 0;
			roleTable.CardTopCount = 30;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000911A8 File Offset: 0x0008F3A8
		public static void ResetCount()
		{
			bool flag = RoleTable.Instance == null;
			if (!flag)
			{
				RoleTable.Instance.SafeBoxRelicCount = 999;
				RoleTable.Instance.SafeBoxCardCount = 999;
				RoleTable.Instance.SafeBoxSaveMoneyCount = 50;
				RoleTable.Instance.SafeBoxGetMoneyCount = 50;
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00022CFE File Offset: 0x00020EFE
		public override bool Weaved()
		{
			return true;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00091220 File Offset: 0x0008F420
		protected void UserCode_ShowMapSelect()
		{
			bool flag = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (flag)
			{
				UIManager.Instance.ShowUI<MapSelectUI>("MapSelectUI", true);
			}
			else
			{
				UIManager.Instance.ShowUI<CurtainTurnUI>("CurtainTurnUI", true).Play(delegate
				{
					UIManager.Instance.ShowUI<MapSelectUI>("MapSelectUI", true);
				});
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00091293 File Offset: 0x0008F493
		protected static void InvokeUserCode_ShowMapSelect(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkClient.active)
			{
				Debug.LogError("RPC ShowMapSelect called on server.");
				return;
			}
			((SublimationManager)obj).UserCode_ShowMapSelect();
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000912B8 File Offset: 0x0008F4B8
		protected void UserCode_RpcLoadMap__String__String(string type, string id)
		{
			bool flag = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") == null;
			if (flag)
			{
				UIManager.Instance.ShowUI<CurtainTurnUI>("CurtainTurnUI", true).Play(delegate
				{
					Commands.load(type, id);
				});
			}
			else
			{
				Commands.load(type, id);
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0009132D File Offset: 0x0008F52D
		protected static void InvokeUserCode_RpcLoadMap__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkClient.active)
			{
				Debug.LogError("RPC RpcLoadMap called on server.");
				return;
			}
			((SublimationManager)obj).UserCode_RpcLoadMap__String__String(reader.ReadString(), reader.ReadString());
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0009135C File Offset: 0x0008F55C
		static SublimationManager()
		{
			RemoteProcedureCalls.RegisterRpc(typeof(SublimationManager), "System.Void Witch.SublimationManager::ShowMapSelect()", new RemoteCallDelegate(SublimationManager.InvokeUserCode_ShowMapSelect));
			RemoteProcedureCalls.RegisterRpc(typeof(SublimationManager), "System.Void Witch.SublimationManager::RpcLoadMap(System.String,System.String)", new RemoteCallDelegate(SublimationManager.InvokeUserCode_RpcLoadMap__String__String));
		}

		// Token: 0x04000F2E RID: 3886
		private bool hasBless = false;
	}
}

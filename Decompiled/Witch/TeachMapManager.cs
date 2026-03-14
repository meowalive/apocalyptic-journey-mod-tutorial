using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Data.Save;
using Michsky.MUIP;
using Mirror;
using Mirror.RemoteCalls;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;
using ZLinq;
using ZLinq.Linq;

namespace Witch
{
	// Token: 0x0200023E RID: 574
	public class TeachMapManager : NetworkBehaviour, IModeManager
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000913E2 File Offset: 0x0008F5E2
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x000913EA File Offset: 0x0008F5EA
		public bool lazyLoad { get; set; } = true;

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x000913F3 File Offset: 0x0008F5F3
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x000913FB File Offset: 0x0008F5FB
		public Dice NowDice { get; set; } = Dice.Default;

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00091404 File Offset: 0x0008F604
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0009140C File Offset: 0x0008F60C
		public int Level { get; set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00038DF2 File Offset: 0x00036FF2
		public MapTree MapTree
		{
			get
			{
				return GameSaveManager.MapTree;
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00091418 File Offset: 0x0008F618
		[Command(requiresAuthority = false)]
		public void ReadyToChangeMap()
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			base.SendCommandInternal("System.Void Witch.TeachMapManager::ReadyToChangeMap()", 316548234, writer, 0, false);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00091448 File Offset: 0x0008F648
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
				int num = this.Level / 6;
				int num2 = num;
				if (num2 != 0)
				{
					if (num2 == 1)
					{
						MapTree.Node node;
						bool flag2;
						do
						{
							node = this.MapTree.TypeGenerate("建筑");
							flag2 = (node.data["NodeId"] == "Breaks");
						}
						while (!flag2);
						this.MapTree.DefaultNode.Add(node);
						this.MapTree.DefaultNode.Add(new MapTree.Node("首领")
						{
							data = Singleton<GameConfigManager>.Instance.GetOne(DataType.Map, "map_1000"),
							NodeDice = this.MapTree.treedice.WithCursor(this.MapTree.treedice.Roll().Value)
						});
					}
				}
				else
				{
					this.MapTree.DefaultNode.Add(this.MapTree.GetNodeByNodeId("level_10044"));
					this.MapTree.DefaultNode.Add(this.MapTree.GetNodeByNodeId("level_10045"));
					this.MapTree.DefaultNode.Add(this.MapTree.GetNodeByNodeId("level_10005"));
					this.MapTree.DefaultNode.Add(this.MapTree.GetNodeByNodeId("tree"));
					this.MapTree.DefaultNode.Add(this.MapTree.GetNodeByNodeId("shop"));
					this.MapTree.DefaultNode.Add(this.MapTree.GetNodeByNodeId("level_10039"));
				}
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00091674 File Offset: 0x0008F874
		[ClientRpc]
		public void ShowMapSelect()
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			this.SendRPCInternal("System.Void Witch.TeachMapManager::ShowMapSelect()", -2129136335, writer, 0, true);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000916A4 File Offset: 0x0008F8A4
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

		// Token: 0x0600128C RID: 4748 RVA: 0x0008D67C File Offset: 0x0008B87C
		public void CloseMapUI()
		{
			Witch.UI.UIManager.Instance.CloseUI("MapSelectUI");
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00091D00 File Offset: 0x0008FF00
		private void LevelEvent(string id)
		{
			bool flag = this.Level > 7;
			if (!flag)
			{
				bool flag2 = this.Level == 7;
				if (flag2)
				{
					Singleton<EventCenter>.Instance.EventTrigger("7Node");
				}
				else
				{
					bool flag3 = id == "level_10044";
					if (flag3)
					{
						Singleton<EventCenter>.Instance.EventTrigger("FirstFight");
					}
					else
					{
						bool flag4 = id == "level_10045";
						if (flag4)
						{
							Singleton<EventCenter>.Instance.EventTrigger("2Fight");
						}
						else
						{
							bool flag5 = id == "level_10005";
							if (flag5)
							{
								Singleton<EventCenter>.Instance.EventTrigger("3Fight");
							}
							else
							{
								bool flag6 = id == "tree";
								if (flag6)
								{
									Singleton<EventCenter>.Instance.EventTrigger("FirstBless");
								}
								else
								{
									bool flag7 = id == "shop";
									if (flag7)
									{
										Singleton<EventCenter>.Instance.EventTrigger("FirstShop");
									}
									else
									{
										bool flag8 = id == "level_10039";
										if (flag8)
										{
											Singleton<EventCenter>.Instance.EventTrigger("4Fight");
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00091E1C File Offset: 0x0009001C
		[ClientRpc]
		public void RpcLoadMap(string type, string id)
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			writer.WriteString(type);
			writer.WriteString(id);
			this.SendRPCInternal("System.Void Witch.TeachMapManager::RpcLoadMap(System.String,System.String)", 1072688669, writer, 0, true);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00091E60 File Offset: 0x00090060
		public void MapUIStart(MapSelectUI mapSelectUI)
		{
			bool flag = this.Level < 6;
			if (flag)
			{
				mapSelectUI.transform.Find("Next").GetComponent<ButtonManager>().onClick.Invoke();
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00091EA0 File Offset: 0x000900A0
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
			bool flag2 = this.Level >= 6;
			if (flag2)
			{
				this.SetNormalMap(mapSelectUI);
			}
			else
			{
				this.SetTeachMap(mapSelectUI);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00091F34 File Offset: 0x00090134
		public void SetTeachMap(MapSelectUI mapSelectUI)
		{
			MapTree.Node[] MapNodes = mapSelectUI.GetNodes();
			Transform NodeParent = mapSelectUI.transform.Find("Map/NodeContent");
			mapSelectUI.transform.Find("Map").GetComponent<CanvasGroup>().blocksRaycasts = true;
			for (int i = 0; i < 6; i++)
			{
				MapTree.Node node0 = this.MapTree.DefaultNode[i];
				MapNodes[i].data = node0.data;
				MapNodes[i].NodeDice = node0.NodeDice;
				GameObject tempGame = UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("MapSelect/" + node0.data["Type"] + "Prefab").gameObject, NodeParent.GetChild(i).Find("Content"));
				bool flag = NodeParent.GetChild(i).Find("Content/Null") != null;
				if (flag)
				{
					NodeParent.GetChild(i).Find("Content/Null").gameObject.SetActive(false);
				}
				tempGame.transform.localScale = Vector3.one;
				tempGame.SetActive(true);
				bool flag2 = node0.data["Type"] == "Event";
				if (flag2)
				{
					tempGame.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/故事牌", true);
				}
				else
				{
					bool flag3 = node0.data["Type"] == "Build";
					if (flag3)
					{
						tempGame.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/建筑牌", true);
					}
				}
				tempGame.AddComponent<MapItem>().Init(MapNodes[i]);
				UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("Chain").gameObject, NodeParent.GetChild(i).Find("Frame")).SetActive(true);
			}
			mapSelectUI.SendNode();
			bool isServer = PlayerManager.Instance.isServer;
			if (isServer)
			{
				GameServer.Instance.SaveGame();
			}
			SafeBoxUI.SafeboxSave();
			Singleton<GameRuntimeData>.Instance.Save();
			mapSelectUI.MapAnimation();
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00092178 File Offset: 0x00090378
		public void SetNormalMap(MapSelectUI mapSelectUI)
		{
			MapTree.Node[] MapNodes = mapSelectUI.GetNodes();
			mapSelectUI.transform.Find("Map").GetComponent<CanvasGroup>().blocksRaycasts = true;
			MapTree.Node node0 = this.MapTree.DefaultNode[6 * MapManager.Instance.Level / 6];
			MapNodes[0].data = node0.data;
			MapNodes[0].NodeDice = node0.NodeDice;
			MapTree.Node node = this.MapTree.DefaultNode[6 * MapManager.Instance.Level / 6 + 1];
			MapTree.Node[] array = MapNodes;
			array[array.Length - 1].data = node.data;
			MapTree.Node[] array2 = MapNodes;
			array2[array2.Length - 1].NodeDice = node.NodeDice;
			GameObject newGame = UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("MapSelect/EventPrefab").gameObject, mapSelectUI.transform.Find("Map/NodeContent/Start/Content"));
			newGame.transform.localScale = Vector3.one;
			newGame.SetActive(true);
			newGame.name = "EventPrefab";
			bool flag = node0.data["Type"] == "Build";
			if (flag)
			{
				newGame.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/建筑牌", true);
			}
			else
			{
				bool flag2 = node0.data["Type"] == "Event";
				if (flag2)
				{
					newGame.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/故事牌", true);
				}
			}
			GameObject fightGame = UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("MapSelect/FightPrefab").gameObject, mapSelectUI.transform.Find("Map/NodeContent/End/Content"));
			fightGame.transform.localScale = Vector3.one;
			fightGame.name = "FightPrefab";
			fightGame.SetActive(true);
			MapItem mapItem = fightGame.AddComponent<MapItem>();
			MapTree.Node[] array3 = MapNodes;
			mapItem.Init(array3[array3.Length - 1]);
			mapSelectUI.transform.Find("Map/NodeContent/End/Content/FightPrefab").GetComponent<ObjectGroup>().blocksRaycasts = false;
			UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("Chain").gameObject, mapSelectUI.transform.Find("Map/NodeContent/End/Frame")).SetActive(true);
			mapSelectUI.transform.Find("Map/NodeContent/Start/Content/EventPrefab").gameObject.AddComponent<MapItem>().Init(MapNodes[0]);
			mapSelectUI.transform.Find("Map/NodeContent/Start/Content/EventPrefab").GetComponent<ObjectGroup>().blocksRaycasts = false;
			UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("Chain").gameObject, mapSelectUI.transform.Find("Map/NodeContent/Start/Frame")).SetActive(true);
			mapSelectUI.SendNode();
			mapSelectUI.ReadyToSelect();
			for (int i = 0; i < 4; i++)
			{
				GameObject tempGame = UnityEngine.Object.Instantiate<GameObject>(mapSelectUI.transform.Find("MapSelect/NullPrefab").gameObject, mapSelectUI.transform.Find("MapSelect"));
				tempGame.AddComponent<MapItem>();
				tempGame.name = "Null";
				tempGame.GetComponent<ObjectGroup>().blocksRaycasts = true;
				tempGame.SetActive(false);
				tempGame.transform.SetAsLastSibling();
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

		// Token: 0x06001293 RID: 4755 RVA: 0x000924FC File Offset: 0x000906FC
		public void SetReward(BattleRewardsUI battleRewardsUI)
		{
			int count = 2;
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

		// Token: 0x06001294 RID: 4756 RVA: 0x00092744 File Offset: 0x00090944
		public void RandomSetReward(BattleRewardsUI battleRewardsUI)
		{
			int CardCount = 7;
			int BlessCount = 2;
			int random = this.NowDice.WithRange(0, BlessCount + CardCount).Roll().Value;
			bool flag = random < CardCount;
			if (flag)
			{
				battleRewardsUI.RandomSetCard();
			}
			else
			{
				bool flag2 = random <= CardCount + BlessCount;
				if (flag2)
				{
					bool flag3 = !this.hasBless && !RoleTable.Instance.InHighTide;
					if (flag3)
					{
						this.hasBless = true;
						battleRewardsUI.RandomAddBless();
					}
					else
					{
						battleRewardsUI.RandomSetCard();
					}
				}
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x000927D0 File Offset: 0x000909D0
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
			roleTable.Money += Singleton<GameRuntimeData>.Instance.Gain["firstMoney"] + 300;
			roleTable.CardBottomCount = 13 - roleTable.VarsMap["Wisdom"] / 5;
			roleTable.CardTopCount = Math.Max(roleTable.VarsMap["Wisdom"] + 18, roleTable.CardBottomCount);
			roleTable.cardList.Add(new DataConfig("card_1", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_1", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_1", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_2", DataType.Card));
			bool flag = Singleton<GameRuntimeData>.Instance.BuyedItems.ContainsKey("outsideshop_10");
			if (flag)
			{
				roleTable.blessingConfigs.Add(new DataConfig("blessing_35", DataType.Bless));
			}
			roleTable.blessingConfigs.Add(new DataConfig("blessing_37", DataType.Bless));
			return roleTable;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000929A0 File Offset: 0x00090BA0
		public void CardCountSet(RoleTable roleTable)
		{
			roleTable.CardBottomCount = 13 - roleTable.VarsMap["Wisdom"] / 5;
			roleTable.CardTopCount = Math.Max(roleTable.VarsMap["Wisdom"] + 18, roleTable.CardBottomCount);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00022CFE File Offset: 0x00020EFE
		public override bool Weaved()
		{
			return true;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00092A14 File Offset: 0x00090C14
		protected void UserCode_ReadyToChangeMap()
		{
			bool flag = this.Level >= 12;
			if (flag)
			{
				Witch.UI.UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
			}
			else
			{
				bool flag2 = this.Level % 6 == 0;
				if (flag2)
				{
					this.GeneratrMap();
					bool flag3 = this.Level == 6 && !Singleton<GameRuntimeData>.Instance.IsTutorialCompleted.ContainsKey("Mapselect");
					if (flag3)
					{
						Singleton<EventCenter>.Instance.EventTrigger("Mapselect");
					}
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
						this.RpcLoadMap("event", "event_1001");
					}
					else
					{
						this.ShowMapSelect();
					}
				}
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00092AF0 File Offset: 0x00090CF0
		protected static void InvokeUserCode_ReadyToChangeMap(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkServer.active)
			{
				Debug.LogError("Command ReadyToChangeMap called on client.");
				return;
			}
			((TeachMapManager)obj).UserCode_ReadyToChangeMap();
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00092B14 File Offset: 0x00090D14
		protected void UserCode_ShowMapSelect()
		{
			bool flag = Witch.UI.UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (flag)
			{
				Witch.UI.UIManager.Instance.ShowUI<MapSelectUI>("MapSelectUI", true);
			}
			else
			{
				Witch.UI.UIManager.Instance.ShowUI<CurtainTurnUI>("CurtainTurnUI", true).Play(delegate
				{
					Witch.UI.UIManager.Instance.ShowUI<MapSelectUI>("MapSelectUI", true);
				});
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00092B87 File Offset: 0x00090D87
		protected static void InvokeUserCode_ShowMapSelect(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkClient.active)
			{
				Debug.LogError("RPC ShowMapSelect called on server.");
				return;
			}
			((TeachMapManager)obj).UserCode_ShowMapSelect();
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00092BAC File Offset: 0x00090DAC
		protected void UserCode_RpcLoadMap__String__String(string type, string id)
		{
			bool flag = this.Level < 6 && id == "level_10005";
			if (flag)
			{
				RoleTable.Instance.cardList.Add(new DataConfig("blood_1", DataType.Card));
				RoleTable.Instance.cardList.Add(new DataConfig("blood_1", DataType.Card));
			}
			bool flag2 = Witch.UI.UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") == null;
			if (flag2)
			{
				Witch.UI.UIManager.Instance.ShowUI<CurtainTurnUI>("CurtainTurnUI", true).Play(delegate
				{
					Commands.load(type, id);
					this.LevelEvent(id);
				});
			}
			else
			{
				Commands.load(type, id);
				this.LevelEvent(id);
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00092C8D File Offset: 0x00090E8D
		protected static void InvokeUserCode_RpcLoadMap__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkClient.active)
			{
				Debug.LogError("RPC RpcLoadMap called on server.");
				return;
			}
			((TeachMapManager)obj).UserCode_RpcLoadMap__String__String(reader.ReadString(), reader.ReadString());
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00092CBC File Offset: 0x00090EBC
		static TeachMapManager()
		{
			RemoteProcedureCalls.RegisterCommand(typeof(TeachMapManager), "System.Void Witch.TeachMapManager::ReadyToChangeMap()", new RemoteCallDelegate(TeachMapManager.InvokeUserCode_ReadyToChangeMap), false);
			RemoteProcedureCalls.RegisterRpc(typeof(TeachMapManager), "System.Void Witch.TeachMapManager::ShowMapSelect()", new RemoteCallDelegate(TeachMapManager.InvokeUserCode_ShowMapSelect));
			RemoteProcedureCalls.RegisterRpc(typeof(TeachMapManager), "System.Void Witch.TeachMapManager::RpcLoadMap(System.String,System.String)", new RemoteCallDelegate(TeachMapManager.InvokeUserCode_RpcLoadMap__String__String));
		}

		// Token: 0x04000F3F RID: 3903
		private bool hasBless = false;
	}
}

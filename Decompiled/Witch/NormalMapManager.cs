using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
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
	// Token: 0x02000231 RID: 561
	public class NormalMapManager : NetworkBehaviour, IModeManager
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0008C729 File Offset: 0x0008A929
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0008C731 File Offset: 0x0008A931
		public bool lazyLoad { get; set; } = true;

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0008C73A File Offset: 0x0008A93A
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0008C742 File Offset: 0x0008A942
		public Dice NowDice { get; set; } = Dice.Default;

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0008C74B File Offset: 0x0008A94B
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0008C753 File Offset: 0x0008A953
		public int Level
		{
			get
			{
				return this._level;
			}
			set
			{
				this.Network_level = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00038DF2 File Offset: 0x00036FF2
		public MapTree MapTree
		{
			get
			{
				return GameSaveManager.MapTree;
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0008C75C File Offset: 0x0008A95C
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

		// Token: 0x060011F8 RID: 4600 RVA: 0x0008C860 File Offset: 0x0008AA60
		public void GeneratrMap()
		{
			bool flag = this.MapTree.hasUsed.Contains(this.Level / 6);
			if (!flag)
			{
				this.MapTree.hasUsed.Add(this.Level / 6);
				List<Dictionary<string, string>> eventData = Singleton<GameConfigManager>.Instance.GetTable(DataType.Event).Getlines();
				eventData = (from x in eventData.AsValueEnumerable<Dictionary<string, string>>()
				where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"]) && !x["Id"].Contains("Sub") && x["EntryScript"] == ""
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				bool flag2 = GameSaveManager.GetEventRecord() != null && eventData.Count > GameSaveManager.GetEventRecordCount();
				if (flag2)
				{
					eventData = (from x in eventData.AsValueEnumerable<Dictionary<string, string>>()
					where !GameSaveManager.GetEventRecord().Contains(x["Id"])
					select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				}
				this.RandomGenerate();
				switch (this.Level / 6)
				{
				case 0:
				{
					MapTree.Node node;
					bool flag3;
					do
					{
						node = this.MapTree.TypeGenerate("建筑");
						flag3 = (node.data["NodeId"] == "Breaks");
					}
					while (!flag3);
					this.MapTree.DefaultNode.Add(node);
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
					bool flag4 = GameSaveManager.GetValue<int>(GameVar.ExLockDes) > 0;
					if (flag4)
					{
						for (int i = 0; i < GameSaveManager.GetValue<int>(GameVar.ExLockDes); i++)
						{
							this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
						}
					}
					break;
				}
				case 1:
				{
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("普通事件"));
					eventData = (from x in eventData.AsValueEnumerable<Dictionary<string, string>>()
					where x["EntryScript"] == ""
					select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
					string NewId = eventData[this.MapTree.treedice.WithRange(0, eventData.Count - 1).Roll().Value]["Id"];
					List<MapTree.Node> defaultNode = this.MapTree.DefaultNode;
					defaultNode[defaultNode.Count - 1].data["NodeId"] = NewId;
					GameSaveManager.AddEventRecord(NewId);
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("首领"));
					bool flag5 = GameSaveManager.GetValue<int>(GameVar.ExLockDes) > 0;
					if (flag5)
					{
						for (int j = 0; j < GameSaveManager.GetValue<int>(GameVar.ExLockDes); j++)
						{
							this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
						}
					}
					break;
				}
				case 2:
				{
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("普通事件"));
					string NewId2 = eventData[this.MapTree.treedice.WithRange(0, eventData.Count - 1).Roll().Value]["Id"];
					List<MapTree.Node> defaultNode2 = this.MapTree.DefaultNode;
					defaultNode2[defaultNode2.Count - 1].data["NodeId"] = NewId2;
					GameSaveManager.AddEventRecord(NewId2);
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
					bool flag6 = GameSaveManager.GetValue<int>(GameVar.ExLockDes) > 0;
					if (flag6)
					{
						for (int k = 0; k < GameSaveManager.GetValue<int>(GameVar.ExLockDes); k++)
						{
							this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
						}
					}
					break;
				}
				case 3:
				{
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("普通事件"));
					string NewId3 = "event_1002";
					bool flag7 = GameSaveManager.GetHardLevel() < 20;
					if (flag7)
					{
						NewId3 = eventData[this.MapTree.treedice.WithRange(0, eventData.Count - 1).Roll().Value]["Id"];
					}
					List<MapTree.Node> defaultNode3 = this.MapTree.DefaultNode;
					defaultNode3[defaultNode3.Count - 1].data["NodeId"] = NewId3;
					GameSaveManager.AddEventRecord(NewId3);
					this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("首领"));
					bool flag8 = GameSaveManager.GetValue<int>(GameVar.ExLockDes) > 0;
					if (flag8)
					{
						for (int l = 0; l < GameSaveManager.GetValue<int>(GameVar.ExLockDes); l++)
						{
							this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
						}
					}
					break;
				}
				case 4:
				{
					MapTree.Node node2;
					bool flag9;
					do
					{
						node2 = this.MapTree.TypeGenerate("建筑");
						flag9 = (node2.data["NodeId"] == "Breaks");
					}
					while (!flag9);
					this.MapTree.DefaultNode.Add(node2);
					bool flag10 = GameSaveManager.GetValue<string>(GameVar.IsKing) == "True";
					if (flag10)
					{
						this.MapTree.DefaultNode.Add(new MapTree.Node("首领")
						{
							data = Singleton<GameConfigManager>.Instance.GetOne(DataType.Map, "map_999"),
							NodeDice = this.MapTree.treedice.WithCursor(this.MapTree.treedice.Roll().Value)
						});
					}
					else
					{
						this.MapTree.DefaultNode.Add(new MapTree.Node("首领")
						{
							data = Singleton<GameConfigManager>.Instance.GetOne(DataType.Map, "map_0"),
							NodeDice = this.MapTree.treedice.WithCursor(this.MapTree.treedice.Roll().Value)
						});
					}
					bool flag11 = GameSaveManager.GetValue<int>(GameVar.ExLockDes) > 0;
					if (flag11)
					{
						for (int m = 0; m < GameSaveManager.GetValue<int>(GameVar.ExLockDes); m++)
						{
							this.MapTree.DefaultNode.Add(this.MapTree.TypeGenerate("精英"));
						}
					}
					break;
				}
				}
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0008CEEC File Offset: 0x0008B0EC
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
					int eventCount = eventData.Count;
					bool flag6 = GameSaveManager.GetEventRecord() != null && eventData.Count > GameSaveManager.GetEventRecordCount();
					if (flag6)
					{
						eventData = (from x in eventData.AsValueEnumerable<Dictionary<string, string>>()
						where !GameSaveManager.GetEventRecord().Contains(x["Id"])
						select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
					}
					string NewId = eventData[this.MapTree.treedice.WithRange(0, eventData.Count - 1).Roll().Value]["Id"];
					node.data["NodeId"] = NewId;
					GameSaveManager.AddEventRecord(NewId);
				}
				node.NodeDice = this.MapTree.treedice.WithCursor(this.MapTree.treedice.Roll().Value);
				string type2 = node.data["Note"];
				bool flag7 = type2 == "首领" || type2 == "精英" || type2 == "普通";
				if (flag7)
				{
					int LastFeat = 1;
					bool flag8 = type2 == "精英";
					if (flag8)
					{
						LastFeat = 2;
					}
					bool flag9 = type2 == "首领";
					if (flag9)
					{
						LastFeat = 3;
					}
					node.data["Money"] = (LastFeat * 35 + 10 + node.NodeDice.WithRange(-10, 10).Roll().Value + int.Parse(GameSaveManager.GetValue<string>("Difficulty")) * 2).ToString();
				}
				this.MapTree.SelectNode.Add(node);
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0008D67C File Offset: 0x0008B87C
		public void CloseMapUI()
		{
			UIManager.Instance.CloseUI("MapSelectUI");
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0008D690 File Offset: 0x0008B890
		[ClientRpc]
		public void ShowMapSelect()
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			this.SendRPCInternal("System.Void Witch.NormalMapManager::ShowMapSelect()", 432731381, writer, 0, true);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0008D6C0 File Offset: 0x0008B8C0
		[ClientRpc]
		public void RpcLoadMap(string type, string id)
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			writer.WriteString(type);
			writer.WriteString(id);
			this.SendRPCInternal("System.Void Witch.NormalMapManager::RpcLoadMap(System.String,System.String)", 1696886081, writer, 0, true);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0008D704 File Offset: 0x0008B904
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

		// Token: 0x060011FE RID: 4606 RVA: 0x0008DCC8 File Offset: 0x0008BEC8
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
			int money = LastFeat * 35 + 10 + this.NowDice.WithRange(-10, 10).Roll().Value + int.Parse(GameSaveManager.GetValue<string>("Difficulty")) * 2;
			battleRewardsUI.SetMoney(money);
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

		// Token: 0x060011FF RID: 4607 RVA: 0x0008DF14 File Offset: 0x0008C114
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

		// Token: 0x06001200 RID: 4608 RVA: 0x0008DFA0 File Offset: 0x0008C1A0
		public bool CanResetSafeBox()
		{
			return false;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0008DFB4 File Offset: 0x0008C1B4
		public bool WinTheGame()
		{
			return this.Level >= 30;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0008DFE0 File Offset: 0x0008C1E0
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
			roleTable.CardBottomCount = 13 - roleTable.VarsMap["Wisdom"] / 5;
			roleTable.CardTopCount = Math.Max(roleTable.VarsMap["Wisdom"] + 18, roleTable.CardBottomCount);
			roleTable.MaxAlCardCount = roleTable.VarsMap["Wisdom"] / 2 + 2;
			roleTable.cardList.Add(new DataConfig("card_1", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_2", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_1", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_2", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_1", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_2", DataType.Card));
			roleTable.cardList.Add(new DataConfig("burningcard_2", DataType.Card));
			roleTable.cardList.Add(new DataConfig("burningcard_1", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_4", DataType.Card));
			roleTable.cardList.Add(new DataConfig("card_3", DataType.Card));
			roleTable.cardList.Add(new DataConfig("burningcard_1", DataType.Card));
			bool flag = Singleton<GameRuntimeData>.Instance.BuyedItems.ContainsKey("outsideshop_10");
			if (flag)
			{
				roleTable.blessingConfigs.Add(new DataConfig("blessing_35", DataType.Bless));
			}
			return roleTable;
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0008E24C File Offset: 0x0008C44C
		public void CardCountSet(RoleTable roleTable)
		{
			roleTable.CardBottomCount = 13 - roleTable.VarsMap["Wisdom"] / 5;
			roleTable.CardTopCount = Math.Max(roleTable.VarsMap["Wisdom"] + 18, roleTable.CardBottomCount);
			roleTable.ResetBackCard();
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00022CFE File Offset: 0x00020EFE
		public override bool Weaved()
		{
			return true;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x0008E2C4 File Offset: 0x0008C4C4
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x0008E2D7 File Offset: 0x0008C4D7
		public int Network_level
		{
			get
			{
				return this._level;
			}
			[param: In]
			set
			{
				base.GeneratedSyncVarSetter<int>(value, ref this._level, 1UL, null);
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0008E2F4 File Offset: 0x0008C4F4
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

		// Token: 0x06001209 RID: 4617 RVA: 0x0008E367 File Offset: 0x0008C567
		protected static void InvokeUserCode_ShowMapSelect(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkClient.active)
			{
				Debug.LogError("RPC ShowMapSelect called on server.");
				return;
			}
			((NormalMapManager)obj).UserCode_ShowMapSelect();
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0008E38C File Offset: 0x0008C58C
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

		// Token: 0x0600120B RID: 4619 RVA: 0x0008E401 File Offset: 0x0008C601
		protected static void InvokeUserCode_RpcLoadMap__String__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkClient.active)
			{
				Debug.LogError("RPC RpcLoadMap called on server.");
				return;
			}
			((NormalMapManager)obj).UserCode_RpcLoadMap__String__String(reader.ReadString(), reader.ReadString());
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0008E430 File Offset: 0x0008C630
		static NormalMapManager()
		{
			RemoteProcedureCalls.RegisterRpc(typeof(NormalMapManager), "System.Void Witch.NormalMapManager::ShowMapSelect()", new RemoteCallDelegate(NormalMapManager.InvokeUserCode_ShowMapSelect));
			RemoteProcedureCalls.RegisterRpc(typeof(NormalMapManager), "System.Void Witch.NormalMapManager::RpcLoadMap(System.String,System.String)", new RemoteCallDelegate(NormalMapManager.InvokeUserCode_RpcLoadMap__String__String));
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0008E480 File Offset: 0x0008C680
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			base.SerializeSyncVars(writer, forceAll);
			if (forceAll)
			{
				writer.WriteVarInt(this._level);
				return;
			}
			writer.WriteVarULong(this.syncVarDirtyBits);
			if ((this.syncVarDirtyBits & 1UL) != 0UL)
			{
				writer.WriteVarInt(this._level);
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0008E4D8 File Offset: 0x0008C6D8
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			base.DeserializeSyncVars(reader, initialState);
			if (initialState)
			{
				base.GeneratedSyncVarDeserialize<int>(ref this._level, null, reader.ReadVarInt());
				return;
			}
			long num = (long)reader.ReadVarULong();
			if ((num & 1L) != 0L)
			{
				base.GeneratedSyncVarDeserialize<int>(ref this._level, null, reader.ReadVarInt());
			}
		}

		// Token: 0x04000EFF RID: 3839
		[SyncVar]
		private int _level;

		// Token: 0x04000F00 RID: 3840
		private bool hasBless = false;
	}
}

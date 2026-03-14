using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using Cysharp.Threading.Tasks;
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
	// Token: 0x02000235 RID: 565
	public class SlotMachineManager : NetworkBehaviour, IModeManager
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x0008E6B2 File Offset: 0x0008C8B2
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x0008E6BA File Offset: 0x0008C8BA
		public bool lazyLoad { get; set; } = true;

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x0008E6C3 File Offset: 0x0008C8C3
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x0008E6CB File Offset: 0x0008C8CB
		public Dice NowDice { get; set; } = Dice.Default;

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0008E6D4 File Offset: 0x0008C8D4
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x0008E6DC File Offset: 0x0008C8DC
		public int Level { get; set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00038DF2 File Offset: 0x00036FF2
		public MapTree MapTree
		{
			get
			{
				return GameSaveManager.MapTree;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0008E6E5 File Offset: 0x0008C8E5
		public void SetRewardType(string rewardType)
		{
			this.nowRewardType = rewardType;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0008E6F0 File Offset: 0x0008C8F0
		public void ReadyToChangeMap()
		{
			bool flag = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
			if (flag)
			{
				Debug.Log("战斗回合没结束");
				FightManager.Instance.ChangeUnit(FightType.None);
			}
			bool flag2 = this.Level >= 30;
			if (flag2)
			{
				UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
			}
			else
			{
				this.ShowMapSelect();
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0008E764 File Offset: 0x0008C964
		public List<MapTree.Node> GeneratrMap()
		{
			return this.RandomGenerate();
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0008E77C File Offset: 0x0008C97C
		public List<MapTree.Node> RandomGenerate()
		{
			List<MapTree.Node> ReturnNode = new List<MapTree.Node>();
			float decay = 0.1f;
			int tempcount = 6;
			Dictionary<string, float> typeWeightDic = new Dictionary<string, float>
			{
				{
					"Normal",
					0.35f
				},
				{
					"Good",
					0.35f
				},
				{
					"Bad",
					0.3f
				}
			};
			List<Dictionary<string, string>> mapList = Singleton<GameConfigManager>.Instance.GetTable(DataType.Coin).Getlines();
			List<Dictionary<string, string>> mapTypes = new List<Dictionary<string, string>>();
			bool flag = this.MapTree.treedice == null;
			if (flag)
			{
				Debug.LogError("treedice未初始化");
			}
			while (tempcount > 0)
			{
				List<Dictionary<string, string>> mapType = new RandomPool(mapList, this.MapTree.treedice).DrawByNote(1, typeWeightDic);
				bool flag2 = mapType.Count == 0;
				if (flag2)
				{
					Debug.LogWarning("没有符合条件的地点");
				}
				else
				{
					mapTypes.Add(mapType[0]);
					tempcount--;
					Dictionary<string, float> dictionary = typeWeightDic;
					string key = mapType[0]["Type"];
					dictionary[key] *= decay;
				}
			}
			List<string> types = (from x in mapTypes
			select x["Note"]).Distinct<string>().ToList<string>();
			List<Dictionary<string, string>> maps = new List<Dictionary<string, string>>();
			using (List<string>.Enumerator enumerator = types.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string type = enumerator.Current;
					int typeCount = 0;
					foreach (Dictionary<string, string> item in mapTypes)
					{
						bool flag3 = item["Note"] == type;
						if (flag3)
						{
							typeCount++;
						}
					}
					List<Dictionary<string, string>> tempList = new List<Dictionary<string, string>>(mapList);
					maps = maps.Concat(new RandomPool((from x in tempList
					where x["Note"] == type
					select x).ToList<Dictionary<string, string>>(), this.MapTree.treedice).DrawByCount(typeCount)).ToList<Dictionary<string, string>>();
				}
			}
			for (int i = 0; i < maps.Count; i++)
			{
				Dictionary<string, string> dataCopy = new Dictionary<string, string>(maps[i]);
				MapTree.Node node = new MapTree.Node(maps[i]["Note"])
				{
					data = dataCopy
				};
				node.NodeDice = this.MapTree.treedice.WithCursor(this.MapTree.treedice.Roll().Value);
				this.MapTree.SelectNode.Add(node);
				ReturnNode.Add(node);
			}
			Debug.Log("生成地图节点完成，共" + maps.Count.ToString() + "个节点");
			return ReturnNode;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0008EA9C File Offset: 0x0008CC9C
		[ClientRpc]
		public void ShowMapSelect()
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			this.SendRPCInternal("System.Void Witch.SlotMachineManager::ShowMapSelect()", -1168850169, writer, 0, true);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0008EACC File Offset: 0x0008CCCC
		public void RpcLoadMap(string type, string id)
		{
			bool flag = type != "Reward";
			if (flag)
			{
				bool flag2 = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") == null;
				if (flag2)
				{
					UIManager.Instance.ShowUI<CurtainTurnUI>("CurtainTurnUI", true).Play(delegate
					{
						Commands.load(type, id);
						bool flag5 = UIManager.Instance.GetUI<SlotMachUI>("SlotMachUI") != null;
						if (flag5)
						{
							UIManager.Instance.GetUI<SlotMachUI>("SlotMachUI").Hide();
						}
					});
				}
				else
				{
					Commands.load(type, id);
					bool flag3 = UIManager.Instance.GetUI<SlotMachUI>("SlotMachUI") != null;
					if (flag3)
					{
						UIManager.Instance.GetUI<SlotMachUI>("SlotMachUI").Hide();
					}
				}
			}
			else
			{
				bool flag4 = type == "";
				if (flag4)
				{
				}
				Commands.load(type, id);
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0008EBB8 File Offset: 0x0008CDB8
		public void MapItemInit(SlotMachUI slotMachUI)
		{
			bool flag = this.MapTree.currentNode.depth == 0;
			if (flag)
			{
				this.MapTree.currentNode.depth = -1;
			}
			this.MapTree.currentNode = this.MapTree.currentNode.GetChild(0);
			GameSaveManager.UpdateNode(this.MapTree.currentNode);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0008EC20 File Offset: 0x0008CE20
		public void SetReward(BattleRewardsUI battleRewardsUI)
		{
			bool flag = this.relics.Count == 0;
			if (flag)
			{
				this.relics = Singleton<GameConfigManager>.Instance.GetTable(DataType.Relic).Getlines();
			}
			string text = this.nowRewardType;
			string a = text;
			if (!(a == "normal"))
			{
				if (!(a == "low"))
				{
					if (!(a == "high"))
					{
						if (a == "relic")
						{
							this.relicReward(battleRewardsUI);
						}
					}
					else
					{
						this.HighReward(battleRewardsUI);
					}
				}
				else
				{
					this.LowReward(battleRewardsUI);
				}
			}
			else
			{
				this.NormalReward(battleRewardsUI);
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0008ECC4 File Offset: 0x0008CEC4
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

		// Token: 0x06001231 RID: 4657 RVA: 0x0008ED4E File Offset: 0x0008CF4E
		public void CloseMapUI()
		{
			UIManager.Instance.CloseUI("SlotMachUI");
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0008ED64 File Offset: 0x0008CF64
		[Command(requiresAuthority = false)]
		public void ResultUse(List<string> result, int count)
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			Mirror.GeneratedNetworkCode._Write_System.Collections.Generic.List`1<System.String>(writer, result);
			writer.WriteVarInt(count);
			base.SendCommandInternal("System.Void Witch.SlotMachineManager::ResultUse(System.Collections.Generic.List`1<System.String>,System.Int32)", 852089413, writer, 0, false);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0008EDA8 File Offset: 0x0008CFA8
		[ClientRpc]
		public void RpcUse(List<string> result, int count)
		{
			NetworkWriterPooled writer = NetworkWriterPool.Get();
			Mirror.GeneratedNetworkCode._Write_System.Collections.Generic.List`1<System.String>(writer, result);
			writer.WriteVarInt(count);
			this.SendRPCInternal("System.Void Witch.SlotMachineManager::RpcUse(System.Collections.Generic.List`1<System.String>,System.Int32)", 939078761, writer, 0, true);
			NetworkWriterPool.Return(writer);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0008EDEC File Offset: 0x0008CFEC
		public void LowReward(BattleRewardsUI battleRewardsUI)
		{
			int count = 2;
			bool flag = RoleTable.Instance.Reward != 0;
			if (flag)
			{
				count += RoleTable.Instance.Reward;
				RoleTable.Instance.Reward = 0;
			}
			for (int i = 0; i < count; i++)
			{
				battleRewardsUI.RandomSetCard();
			}
			battleRewardsUI.RandomAddBless();
			battleRewardsUI.item1.SetActive(false);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0008EE58 File Offset: 0x0008D058
		public void NormalReward(BattleRewardsUI battleRewardsUI)
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
			bool inHighTide = RoleTable.Instance.InHighTide;
			if (inHighTide)
			{
				List<Dictionary<string, string>> newRelics = (from x in this.relics.AsValueEnumerable<Dictionary<string, string>>()
				where x["Rarity"] == "4" && !RoleTable.Instance.relicGets.ContainsKey(x["Id"])
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				bool flag2 = RoleTable.Instance.relicGets.Count == this.relics.Count;
				if (flag2)
				{
					newRelics = (from x in this.relics.AsValueEnumerable<Dictionary<string, string>>()
					where x["Rarity"] == "4"
					select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				}
				battleRewardsUI.RandomSetRelic(newRelics);
				battleRewardsUI.RandomAddBless();
			}
			bool flag3 = EnemyManager.levelData != null && (EnemyManager.levelData["Note"] == "精英" || (EnemyManager.levelData["Note"] == "boss" && !RoleTable.Instance.InHighTide));
			if (flag3)
			{
				List<Dictionary<string, string>> newRelics2 = (from x in this.relics.AsValueEnumerable<Dictionary<string, string>>()
				where x["Rarity"] != "4" && !RoleTable.Instance.relicGets.ContainsKey(x["Id"])
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				bool flag4 = RoleTable.Instance.relicGets.Count == this.relics.Count;
				if (flag4)
				{
					newRelics2 = (from x in this.relics.AsValueEnumerable<Dictionary<string, string>>()
					where x["Rarity"] != "4"
					select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				}
				battleRewardsUI.RandomSetRelic(newRelics2);
			}
			battleRewardsUI.item1.SetActive(false);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0008F0B0 File Offset: 0x0008D2B0
		public void HighReward(BattleRewardsUI battleRewardsUI)
		{
			int count = 1;
			bool flag = RoleTable.Instance.Reward != 0;
			if (flag)
			{
				count += RoleTable.Instance.Reward;
				RoleTable.Instance.Reward = 0;
			}
			for (int i = 0; i < count; i++)
			{
				battleRewardsUI.RandomSetCard();
			}
			battleRewardsUI.RandomAddBless();
			battleRewardsUI.RandomSetRelic((from x in this.relics.AsValueEnumerable<Dictionary<string, string>>()
			where x["Rarity"] != "4"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>());
			battleRewardsUI.item1.SetActive(false);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0008F154 File Offset: 0x0008D354
		public void relicReward(BattleRewardsUI battleRewardsUI)
		{
			battleRewardsUI.RandomAddBless();
			battleRewardsUI.RandomSetRelic((from x in this.relics.AsValueEnumerable<Dictionary<string, string>>()
			where x["Rarity"] == "4"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>());
			battleRewardsUI.item1.SetActive(false);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0008F1B4 File Offset: 0x0008D3B4
		public bool CanResetSafeBox()
		{
			return false;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0008F1C8 File Offset: 0x0008D3C8
		public bool WinTheGame()
		{
			return this.Level >= 30;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0008F1F1 File Offset: 0x0008D3F1
		public void CmdLoadMap(string type, string id)
		{
			this.RpcLoadMap(type, id);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0008F200 File Offset: 0x0008D400
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

		// Token: 0x0600123C RID: 4668 RVA: 0x0008F454 File Offset: 0x0008D654
		public void CardCountSet(RoleTable roleTable)
		{
			roleTable.CardBottomCount = 13 - roleTable.VarsMap["Wisdom"] / 5;
			roleTable.CardTopCount = Math.Max(roleTable.VarsMap["Wisdom"] + 18, roleTable.CardBottomCount);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0008F504 File Offset: 0x0008D704
		static SlotMachineManager()
		{
			RemoteProcedureCalls.RegisterCommand(typeof(SlotMachineManager), "System.Void Witch.SlotMachineManager::ResultUse(System.Collections.Generic.List`1<System.String>,System.Int32)", new RemoteCallDelegate(SlotMachineManager.InvokeUserCode_ResultUse__List`1__Int32), false);
			RemoteProcedureCalls.RegisterRpc(typeof(SlotMachineManager), "System.Void Witch.SlotMachineManager::ShowMapSelect()", new RemoteCallDelegate(SlotMachineManager.InvokeUserCode_ShowMapSelect));
			RemoteProcedureCalls.RegisterRpc(typeof(SlotMachineManager), "System.Void Witch.SlotMachineManager::RpcUse(System.Collections.Generic.List`1<System.String>,System.Int32)", new RemoteCallDelegate(SlotMachineManager.InvokeUserCode_RpcUse__List`1__Int32));
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00022CFE File Offset: 0x00020EFE
		public override bool Weaved()
		{
			return true;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0008F578 File Offset: 0x0008D778
		protected void UserCode_ShowMapSelect()
		{
			bool flag = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (flag)
			{
				UIManager.Instance.ShowUI<SlotMachUI>("SlotMachUI", false);
			}
			else
			{
				UIManager.Instance.ShowUI<CurtainTurnUI>("CurtainTurnUI", true).Play(delegate
				{
					UIManager.Instance.ShowUI<SlotMachUI>("SlotMachUI", false);
				});
			}
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0008F5EB File Offset: 0x0008D7EB
		protected static void InvokeUserCode_ShowMapSelect(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkClient.active)
			{
				Debug.LogError("RPC ShowMapSelect called on server.");
				return;
			}
			((SlotMachineManager)obj).UserCode_ShowMapSelect();
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0008F60E File Offset: 0x0008D80E
		protected void UserCode_ResultUse__List(List<string> result, int count)
		{
			this.RpcUse(result, count);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0008F61A File Offset: 0x0008D81A
		protected static void InvokeUserCode_ResultUse__List(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkServer.active)
			{
				Debug.LogError("Command ResultUse called on client.");
				return;
			}
			((SlotMachineManager)obj).UserCode_ResultUse__List`1__Int32(Mirror.GeneratedNetworkCode._Read_System.Collections.Generic.List`1<System.String>(reader), reader.ReadVarInt());
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0008F64C File Offset: 0x0008D84C
		protected void UserCode_RpcUse__List(List<string> result, int count)
		{
			SlotMachUI ui = UIManager.Instance.GetUI<SlotMachUI>("SlotMachUI");
			Transform slotTransform = (ui != null) ? ui.transform : null;
			bool flag = slotTransform == null;
			if (!flag)
			{
				this.CoinUseCount++;
				this.Level = this.CoinUseCount / 5;
				for (int i = 0; i < 3; i++)
				{
					Transform tempParent = slotTransform.Find("Content/List/ItemList" + (i + 1).ToString());
					foreach (object obj in tempParent)
					{
						Transform item = (Transform)obj;
						item.gameObject.SetActive(false);
					}
					slotTransform.Find("Content/List/ItemList" + (i + 1).ToString() + "/" + result[i]).gameObject.SetActive(true);
				}
				UniTask.WaitForSeconds(1f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
				{
					bool flag2 = result[0] == result[1] && result[0] == result[2];
					if (flag2)
					{
						string text = result[0];
						string a = text;
						if (!(a == "Heart"))
						{
							if (!(a == "Qus"))
							{
								if (!(a == "Seven"))
								{
									if (!(a == "Gem"))
									{
										if (!(a == "Crystal"))
										{
											if (a == "Skull")
											{
												SlotMachineManager.canuse = false;
												this.RpcLoadMap("Fight", "boss");
											}
										}
										else
										{
											Singleton<GameRuntimeData>.Instance.Truth += 30;
										}
									}
									else
									{
										SlotMachineManager.canuse = false;
										this.RpcLoadMap("Reward", "relic");
										this.RpcLoadMap("build", "ench");
									}
								}
								else
								{
									RoleTable.Instance.Money += 500;
									SlotMachineManager.canuse = false;
									this.RpcLoadMap("Reward", "high");
									this.RpcLoadMap("build", "shop");
								}
							}
							else
							{
								SlotMachineManager.canuse = false;
								this.RpcLoadMap("event", null);
							}
						}
						else
						{
							SlotMachineManager.canuse = false;
							this.RpcLoadMap("build", "break");
						}
					}
					else
					{
						bool flag3 = result[0] == result[1] || result[0] == result[2] || result[1] == result[2];
						if (flag3)
						{
							bool flag4 = result[0] == result[1];
							string t;
							if (flag4)
							{
								t = result[0];
							}
							else
							{
								bool flag5 = result[0] == result[2];
								if (flag5)
								{
									t = result[0];
								}
								else
								{
									t = result[1];
								}
							}
							string text2 = t;
							string a2 = text2;
							if (!(a2 == "Heart"))
							{
								if (!(a2 == "Qus"))
								{
									if (!(a2 == "Seven"))
									{
										if (!(a2 == "Gem"))
										{
											if (!(a2 == "Crystal"))
											{
												if (a2 == "Skull")
												{
													SlotMachineManager.canuse = false;
													bool flag6 = count > 50;
													if (flag6)
													{
														this.RpcLoadMap("Fight", "elite");
													}
													else
													{
														this.RpcLoadMap("Fight", "common");
													}
												}
											}
											else
											{
												Singleton<GameRuntimeData>.Instance.Truth += 10;
											}
										}
										else
										{
											RoleTable.Instance.Money += 100;
										}
									}
									else
									{
										this.RpcLoadMap("Reward", "normal");
									}
								}
								else
								{
									SlotMachineManager.canuse = false;
									this.RpcLoadMap("event", null);
								}
							}
							else
							{
								this.RpcLoadMap("Reward", "low");
							}
							GameSaveManager.Save();
						}
					}
				}).Forget();
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0008F7BC File Offset: 0x0008D9BC
		protected static void InvokeUserCode_RpcUse__List(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			if (!NetworkClient.active)
			{
				Debug.LogError("RPC RpcUse called on server.");
				return;
			}
			((SlotMachineManager)obj).UserCode_RpcUse__List`1__Int32(Mirror.GeneratedNetworkCode._Read_System.Collections.Generic.List`1<System.String>(reader), reader.ReadVarInt());
		}

		// Token: 0x04000F14 RID: 3860
		public int LuckyCoin = 0;

		// Token: 0x04000F15 RID: 3861
		public int MisfortuneCoin = 0;

		// Token: 0x04000F16 RID: 3862
		public int NormalCoin = 0;

		// Token: 0x04000F17 RID: 3863
		public int CoinUseCount = 0;

		// Token: 0x04000F18 RID: 3864
		private bool hasBless = false;

		// Token: 0x04000F19 RID: 3865
		public string nowRewardType = "normal";

		// Token: 0x04000F1A RID: 3866
		private List<Dictionary<string, string>> relics = new List<Dictionary<string, string>>();

		// Token: 0x04000F1B RID: 3867
		public static bool canuse = true;
	}
}

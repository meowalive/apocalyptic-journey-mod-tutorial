using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Data.Save;
using Mirror;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;
using ZLinq;
using ZLinq.Linq;

// Token: 0x0200002C RID: 44
public static class Commands
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600010B RID: 267 RVA: 0x00009305 File Offset: 0x00007505
	private static Dice dice
	{
		get
		{
			return MapManager.Instance.NowDice;
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00009314 File Offset: 0x00007514
	[HelpText("获取某命令的帮助文本。")]
	public static string help(string arg = "null")
	{
		string output = "";
		bool flag = arg == "all";
		string result;
		if (flag)
		{
			result = "获取所有指令的帮助";
		}
		else
		{
			bool flag2 = arg == "null";
			if (flag2)
			{
				result = "<color=red>错误：参数缺失！</color>";
			}
			else
			{
				MethodInfo method = typeof(Commands).GetMethod(arg);
				bool flag3 = method == null || method.GetCustomAttribute<HelpText>() == null;
				if (flag3)
				{
					result = "<color=red>错误：参数异常。</color>";
				}
				else
				{
					string text = ((HelpText)method.GetCustomAttribute(typeof(HelpText))).text;
					output = string.Concat(new string[]
					{
						output,
						"<color=orange>",
						arg,
						"</color>      <color=white>",
						text,
						"</color>"
					});
					result = output;
				}
			}
		}
		return result;
	}

	// Token: 0x0600010D RID: 269 RVA: 0x000093E8 File Offset: 0x000075E8
	[HelpText("清空控制台输出。")]
	public static string cls()
	{
		return "cls";
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00009400 File Offset: 0x00007600
	[HelpText("给予玩家物品。")]
	public static string give(string arg1 = "null", string arg2 = "null")
	{
		bool flag = arg1 == "null" || arg2 == "null";
		string result;
		if (flag)
		{
			result = "<color=red>错误：参数缺失！</color>";
		}
		else
		{
			try
			{
				uint num = <PrivateImplementationDetails>.ComputeStringHash(arg1);
				if (num <= 2283561935U)
				{
					if (num <= 772700646U)
					{
						if (num <= 208253325U)
						{
							if (num != 133175215U)
							{
								if (num != 200788825U)
								{
									if (num != 208253325U)
									{
										goto IL_194E;
									}
									if (!(arg1 == "AllBuff"))
									{
										goto IL_194E;
									}
									bool flag2 = FightPlayer.Instance != null;
									if (flag2)
									{
										foreach (Dictionary<string, string> item in Singleton<GameConfigManager>.Instance.GetTable(DataType.Buff).Getlines())
										{
											FightPlayer.Instance.Status.AddBuff(item["Id"], 1);
										}
									}
									return "给予所有Buff成功！";
								}
								else
								{
									if (!(arg1 == "win"))
									{
										goto IL_194E;
									}
									bool flag3 = UIManager.Instance.GetUI<FightUI>("FightUI") == null;
									if (flag3)
									{
										return "<color=red>错误：战斗界面未加载！</color>";
									}
									UIManager.Instance.GetUI<FightUI>("FightUI").CanWin();
									return "设置胜利成功！";
								}
							}
							else if (!(arg1 == "live"))
							{
								goto IL_194E;
							}
						}
						else if (num <= 451949528U)
						{
							if (num != 405194007U)
							{
								if (num != 451949528U)
								{
									goto IL_194E;
								}
								if (!(arg1 == "bless"))
								{
									goto IL_194E;
								}
								bool flag4 = RoleTable.Instance == null;
								if (flag4)
								{
									return "<color=red>错误：角色数据未加载！</color>";
								}
								bool flag5 = arg2 == "all";
								if (flag5)
								{
									foreach (Dictionary<string, string> item2 in Singleton<GameConfigManager>.Instance.GetTable(DataType.Bless).Getlines())
									{
										DataConfig dataConfigs = new DataConfig(item2["Id"], DataType.Bless);
										RoleTable.Instance.blessingConfigs.Add(dataConfigs);
									}
									return "给予所有祝福成功！共计 <color=yellow>" + Singleton<GameConfigManager>.Instance.GetTable(DataType.Bless).Getlines().Count.ToString() + "</color> 个祝福！";
								}
								DataConfig blessConfig = new DataConfig(arg2, DataType.Bless);
								RoleTable.Instance.blessingConfigs.Add(blessConfig);
								return "给予<color=yellow>" + blessConfig.data.Localize("Name") + "</color>祝福成功！";
							}
							else
							{
								if (!(arg1 == "goodbless"))
								{
									goto IL_194E;
								}
								bool flag6 = RoleTable.Instance == null;
								if (flag6)
								{
									return "<color=red>错误：角色数据未加载！</color>";
								}
								List<Dictionary<string, string>> goodBlesses = new RandomPool((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Bless).Getlines().AsValueEnumerable<Dictionary<string, string>>()
								where x["Type"] == "正面" && !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"]) && int.Parse(x["Weight"]) <= 5
								select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), Commands.dice).DrawByCount(int.Parse(arg2));
								string getGoodBless = "";
								for (int i = 0; i < int.Parse(arg2); i++)
								{
									DataConfig dataConfig = new DataConfig(goodBlesses[i]["Id"], DataType.Bless);
									RoleTable.Instance.blessingConfigs.Add(dataConfig);
									getGoodBless = getGoodBless + "<color=yellow>" + dataConfig.data.Localize("Name") + "</color> ";
								}
								return "给予<color=yellow>" + arg2 + "</color>个随机祝福成功！" + getGoodBless;
							}
						}
						else
						{
							if (num != 653784538U)
							{
								if (num != 772700646U)
								{
									goto IL_194E;
								}
								if (!(arg1 == "wisdom"))
								{
									goto IL_194E;
								}
							}
							else if (!(arg1 == "wis"))
							{
								goto IL_194E;
							}
							bool flag7 = RoleTable.Instance == null;
							if (flag7)
							{
								return "<color=red>错误：角色数据未加载！</color>";
							}
							bool flag8 = FightManager.Instance != null && FightManager.Instance.TempVarsMap.ContainsKey("Wisdom");
							if (flag8)
							{
								Dictionary<string, int> dictionary = FightManager.Instance.TempVarsMap;
								dictionary["Wisdom"] = dictionary["Wisdom"] + int.Parse(arg2);
							}
							RoleTable.Instance.UseVarsChanges("Wisdom", int.Parse(arg2));
							return "给予<color=yellow>" + arg2 + "</color>精神成功！";
						}
					}
					else if (num <= 1536304315U)
					{
						if (num <= 1303515621U)
						{
							if (num != 932468937U)
							{
								if (num != 1303515621U)
								{
									goto IL_194E;
								}
								if (!(arg1 == "true"))
								{
									goto IL_194E;
								}
								goto IL_C70;
							}
							else
							{
								if (!(arg1 == "randomrelic"))
								{
									goto IL_194E;
								}
								bool flag9 = RoleTable.Instance == null;
								if (flag9)
								{
									return "<color=red>错误：角色数据未加载！</color>";
								}
								List<Dictionary<string, string>> relics = new RandomPool((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Relic).Getlines().AsValueEnumerable<Dictionary<string, string>>()
								where int.Parse(x["Rarity"]) <= 5
								select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), Commands.dice).DrawByRarity(int.Parse(arg2));
								string getRelic = "";
								for (int j = 0; j < int.Parse(arg2); j++)
								{
									DataConfig dataConfig2 = new DataConfig(relics[j]["Id"], DataType.Relic);
									RoleTable.Instance.WithoutArmedRelicList.Add(dataConfig2);
									getRelic = getRelic + "<color=yellow>" + dataConfig2.data.Localize("Name") + "</color> ";
								}
								return "给予<color=yellow>" + arg2 + "</color>个随机遗物成功！" + getRelic;
							}
						}
						else if (num != 1530380502U)
						{
							if (num != 1536304315U)
							{
								goto IL_194E;
							}
							if (!(arg1 == "luc"))
							{
								goto IL_194E;
							}
							goto IL_DC0;
						}
						else
						{
							if (!(arg1 == "dice"))
							{
								goto IL_194E;
							}
							Dictionary<int, int> temp = new Dictionary<int, int>();
							Commands.dice.WithRange(1, 100);
							for (int k = 0; k < int.Parse(arg2); k++)
							{
								int a = Commands.dice.Roll().Value;
								bool flag10 = temp.ContainsKey(a);
								if (flag10)
								{
									Dictionary<int, int> dictionary2 = temp;
									int num2 = a;
									int num3 = dictionary2[num2];
									dictionary2[num2] = num3 + 1;
								}
								else
								{
									temp.Add(a, 1);
								}
							}
							temp = (from x in temp
							orderby x.Value descending
							select x).ToDictionary((KeyValuePair<int, int> x) => x.Key, (KeyValuePair<int, int> x) => x.Value);
							foreach (KeyValuePair<int, int> item3 in temp)
							{
								Debug.Log(ZString.Format<object, object>("掷骰结果：{0} 出现 {1} 次", item3.Key, item3.Value));
							}
							temp.Clear();
							System.Random tempRandom = new System.Random();
							for (int l = 0; l < int.Parse(arg2); l++)
							{
								int a2 = tempRandom.Next(1, 100);
								bool flag11 = temp.ContainsKey(a2);
								if (flag11)
								{
									Dictionary<int, int> dictionary3 = temp;
									int num3 = a2;
									int num2 = dictionary3[num3];
									dictionary3[num3] = num2 + 1;
								}
								else
								{
									temp.Add(a2, 1);
								}
							}
							temp = (from x in temp
							orderby x.Value descending
							select x).ToDictionary((KeyValuePair<int, int> x) => x.Key, (KeyValuePair<int, int> x) => x.Value);
							foreach (KeyValuePair<int, int> item4 in temp)
							{
								Debug.LogWarning(ZString.Format<object, object>("掷骰结果：{0} 出现 {1} 次", item4.Key, item4.Value));
							}
							return "";
						}
					}
					else if (num <= 1800113572U)
					{
						if (num != 1564253156U)
						{
							if (num != 1800113572U)
							{
								goto IL_194E;
							}
							if (!(arg1 == "per"))
							{
								goto IL_194E;
							}
							goto IL_E5E;
						}
						else
						{
							if (!(arg1 == "time"))
							{
								goto IL_194E;
							}
							bool flag12 = RoleTable.Instance == null;
							if (flag12)
							{
								return "<color=red>错误：角色数据未加载！</color>";
							}
							foreach (KeyValuePair<string, int> item5 in RoleTable.Instance.SkillTime)
							{
								Dictionary<string, int> dictionary = RoleTable.Instance.SkillTime;
								string key = item5.Key;
								dictionary[key] += int.Parse(arg2);
							}
							return "给予<color=yellow>" + arg2 + "</color>时间成功！";
						}
					}
					else if (num != 1944180856U)
					{
						if (num != 2283561935U)
						{
							goto IL_194E;
						}
						if (!(arg1 == "Live"))
						{
							goto IL_194E;
						}
					}
					else
					{
						if (!(arg1 == "randomcard"))
						{
							goto IL_194E;
						}
						bool flag13 = RoleTable.Instance == null;
						if (flag13)
						{
							return "<color=red>错误：角色数据未加载！</color>";
						}
						List<Dictionary<string, string>> cards = new RandomPool((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Card).Getlines()
						where !x["Tag"].Contains("Curse")
						select x).ToList<Dictionary<string, string>>(), Commands.dice).DrawByRarity(int.Parse(arg2));
						string getCard = "";
						for (int m = 0; m < int.Parse(arg2); m++)
						{
							DataConfig dataConfig3 = new DataConfig(cards[m]["Id"], DataType.Card);
							bool flag14 = RoleTable.Instance.UnCardList.Count < RoleTable.Instance.MaxAlCardCount;
							if (flag14)
							{
								RoleTable.Instance.UnCardList.Add(dataConfig3);
							}
							bool flag15 = FightManager.Instance.fightType > FightType.None;
							if (flag15)
							{
								FightCardManager.Instance.cardList.Add(dataConfig3);
							}
							getCard = getCard + "<color=yellow>" + dataConfig3.data.Localize("Name") + "</color> ";
						}
						return "给予<color=yellow>" + arg2 + "</color>张随机卡牌成功！" + getCard;
					}
					RoleTable.Instance.isDead = false;
					RoleTable.Instance.San = 10;
					return "复活成功！";
				}
				if (num <= 3324249161U)
				{
					if (num <= 2791271718U)
					{
						if (num <= 2326466041U)
						{
							if (num != 2284280159U)
							{
								if (num != 2326466041U)
								{
									goto IL_194E;
								}
								if (!(arg1 == "maxsan"))
								{
									goto IL_194E;
								}
								bool flag16 = RoleTable.Instance == null;
								if (flag16)
								{
									return "<color=red>错误：角色数据未加载！</color>";
								}
								RoleTable.Instance.MaxSan += int.Parse(arg2);
								return "给予<color=yellow>" + arg2 + "</color>最大理智成功！";
							}
							else
							{
								if (!(arg1 == "card"))
								{
									goto IL_194E;
								}
								bool flag17 = RoleTable.Instance == null;
								if (flag17)
								{
									return "<color=red>错误：角色数据未加载！</color>";
								}
								bool flag18 = arg2 == "all";
								if (flag18)
								{
									foreach (Dictionary<string, string> item6 in Singleton<GameConfigManager>.Instance.GetTable(DataType.Card).Getlines())
									{
										DataConfig dataConfigs2 = new DataConfig(item6["Id"], DataType.Card);
										RoleTable.Instance.cardList.Add(dataConfigs2);
										bool flag19 = FightManager.Instance.fightType > FightType.None;
										if (flag19)
										{
											FightCardManager.Instance.cardList.Add(dataConfigs2);
											FightCardManager.Instance.CardTags.Add(dataConfigs2, new HashSet<string>());
											foreach (string item7 in dataConfigs2.Vars["Tag"].Split(new char[]
											{
												'|',
												',',
												'，',
												' ',
												';',
												'；'
											}))
											{
												FightCardManager.Instance.CardTags[dataConfigs2].Add(item7);
											}
										}
									}
									return "给予所有卡牌成功！共计 <color=yellow>" + Singleton<GameConfigManager>.Instance.GetTable(DataType.Card).Getlines().Count.ToString() + "</color> 张卡牌！";
								}
								DataConfig cardConfig = new DataConfig(arg2, DataType.Card);
								bool flag20 = RoleTable.Instance.cardList.Count < RoleTable.Instance.CardTopCount;
								if (flag20)
								{
									RoleTable.Instance.cardList.Add(cardConfig);
								}
								else
								{
									bool flag21 = RoleTable.Instance.UnCardList.Count < RoleTable.Instance.VarsMap["Wisdom"] / 2 + 2;
									if (flag21)
									{
										RoleTable.Instance.UnCardList.Add(cardConfig);
									}
									else
									{
										UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("你的卡牌数量已达上限", CaptionStyle.Center, 3f, 1.5f, 3);
									}
								}
								bool flag22 = FightManager.Instance.fightType > FightType.None;
								if (flag22)
								{
									FightCardManager.Instance.cardList.Add(cardConfig);
									FightCardManager.Instance.CardTags.Add(cardConfig, new HashSet<string>());
									foreach (string item8 in cardConfig.Vars["Tag"].Split(new char[]
									{
										'|',
										',',
										'，',
										' ',
										';',
										'；'
									}))
									{
										FightCardManager.Instance.CardTags[cardConfig].Add(item8);
									}
								}
								string cardName = Singleton<GameConfigManager>.Instance.GetOne(DataType.Card, arg2)["Name"];
								bool flag23 = cardName == "null";
								if (flag23)
								{
									return "<color=red>错误：参数异常。</color>";
								}
								return "给予<color=yellow>1</color>张" + cardName + "卡牌成功！";
							}
						}
						else if (num != 2610554845U)
						{
							if (num != 2791271718U)
							{
								goto IL_194E;
							}
							if (!(arg1 == "perceive"))
							{
								goto IL_194E;
							}
							goto IL_E5E;
						}
						else
						{
							if (!(arg1 == "level"))
							{
								goto IL_194E;
							}
							bool flag24 = RoleTable.Instance == null;
							if (flag24)
							{
								return "<color=red>错误：角色数据未加载！</color>";
							}
							MapManager.Instance.SetLevel(GameSaveManager.GetLevel() + int.Parse(arg2));
							return "给予<color=yellow>" + arg2 + "</color>层数成功！";
						}
					}
					else if (num <= 3259748752U)
					{
						if (num != 2827744275U)
						{
							if (num != 3259748752U)
							{
								goto IL_194E;
							}
							if (!(arg1 == "str"))
							{
								goto IL_194E;
							}
						}
						else
						{
							if (!(arg1 == "draw"))
							{
								goto IL_194E;
							}
							bool flag25 = RoleTable.Instance == null;
							if (flag25)
							{
								return "<color=red>错误：角色数据未加载！</color>";
							}
							bool flag26 = !FightCardManager.Instance.HasCard() || FightCardManager.Instance.cardList.Count < int.Parse(arg2);
							if (flag26)
							{
								FightCardManager.Instance.RandomIndex();
							}
							UIManager.Instance.GetUI<FightUI>("FightUI").CreateCardItem(int.Parse(arg2));
							UIManager.Instance.GetUI<FightUI>("FightUI").UpdateCardItemPos(null, null);
							return "给予<color=yellow>" + arg2 + "</color>抽牌成功！";
						}
					}
					else if (num != 3310976652U)
					{
						if (num != 3324249161U)
						{
							goto IL_194E;
						}
						if (!(arg1 == "randombless"))
						{
							goto IL_194E;
						}
						bool flag27 = RoleTable.Instance == null;
						if (flag27)
						{
							return "<color=red>错误：角色数据未加载！</color>";
						}
						List<Dictionary<string, string>> blesses = new RandomPool((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Bless).Getlines().AsValueEnumerable<Dictionary<string, string>>()
						where int.Parse(x["Weight"]) <= 5
						select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), Commands.dice).DrawByCount(int.Parse(arg2));
						string getBless = "";
						for (int n = 0; n < int.Parse(arg2); n++)
						{
							DataConfig dataConfig4 = new DataConfig(blesses[n]["Id"], DataType.Bless);
							RoleTable.Instance.blessingConfigs.Add(dataConfig4);
							getBless = getBless + "<color=yellow>" + dataConfig4.data.Localize("Name") + "</color> ";
						}
						return "给予<color=yellow>" + arg2 + "</color>个随机祝福成功！" + getBless;
					}
					else
					{
						if (!(arg1 == "def"))
						{
							goto IL_194E;
						}
						bool flag28 = FightPlayer.Instance != null;
						if (flag28)
						{
							FightPlayer.Instance.Status.Defend += int.Parse(arg2);
						}
						return "给予<color=yellow>" + arg2 + "</color>防御成功！";
					}
				}
				else if (num <= 3766098096U)
				{
					if (num <= 3598187358U)
					{
						if (num != 3421371800U)
						{
							if (num != 3598187358U)
							{
								goto IL_194E;
							}
							if (!(arg1 == "truth"))
							{
								goto IL_194E;
							}
							goto IL_C70;
						}
						else
						{
							if (!(arg1 == "randomcardbydeck"))
							{
								goto IL_194E;
							}
							bool flag29 = RoleTable.Instance == null;
							if (flag29)
							{
								return "<color=red>错误：角色数据未加载！</color>";
							}
							List<Dictionary<string, string>> allcards = new RandomPool(Singleton<GameConfigManager>.Instance.GetTable(DataType.Card).Getlines(), Commands.dice).DrawByRarity(int.Parse(arg2));
							for (int i2 = 0; i2 < int.Parse(arg2); i2++)
							{
								DataConfig dataConfig5 = new DataConfig(allcards[i2]["Id"], DataType.Card);
								bool flag30 = RoleTable.Instance.cardList.Count < RoleTable.Instance.CardTopCount;
								if (flag30)
								{
									RoleTable.Instance.cardList.Add(dataConfig5);
								}
								else
								{
									bool flag31 = RoleTable.Instance.UnCardList.Count < RoleTable.Instance.MaxAlCardCount;
									if (flag31)
									{
										RoleTable.Instance.UnCardList.Add(dataConfig5);
									}
								}
								bool flag32 = FightManager.Instance.fightType > FightType.None;
								if (flag32)
								{
									FightCardManager.Instance.cardList.Add(dataConfig5);
								}
							}
							return "给予<color=yellow>" + arg2 + "</color>张随机卡牌成功！";
						}
					}
					else if (num != 3759973013U)
					{
						if (num != 3766098096U)
						{
							goto IL_194E;
						}
						if (!(arg1 == "strength"))
						{
							goto IL_194E;
						}
					}
					else
					{
						if (!(arg1 == "san"))
						{
							goto IL_194E;
						}
						bool flag33 = RoleTable.Instance == null;
						if (flag33)
						{
							return "<color=red>错误：角色数据未加载！</color>";
						}
						RoleTable.Instance.San += int.Parse(arg2);
						return "给予<color=yellow>" + arg2 + "</color>理智成功！";
					}
				}
				else if (num <= 4115604294U)
				{
					if (num != 3780168015U)
					{
						if (num != 4115604294U)
						{
							goto IL_194E;
						}
						if (!(arg1 == "power"))
						{
							goto IL_194E;
						}
						bool flag34 = RoleTable.Instance == null;
						if (flag34)
						{
							return "<color=red>错误：角色数据未加载！</color>";
						}
						bool flag35 = FightManager.Instance.fightType == FightType.None;
						if (flag35)
						{
							return "<color=yellow>警告：战斗未开始！</color>";
						}
						FightPlayer.Instance.CurPowerCount += int.Parse(arg2);
						return string.Concat(new string[]
						{
							"给予<color=yellow>",
							arg2,
							"</color>能量成功！,加后有",
							FightPlayer.Instance.CurPowerCount.ToString(),
							"点能量"
						});
					}
					else
					{
						if (!(arg1 == "money"))
						{
							goto IL_194E;
						}
						bool flag36 = RoleTable.Instance == null;
						if (flag36)
						{
							return "<color=red>错误：角色数据未加载！</color>";
						}
						RoleTable.Instance.Money += int.Parse(arg2);
						return "给予<color=yellow>" + arg2 + "</color>金币成功！";
					}
				}
				else if (num != 4145780523U)
				{
					if (num != 4240957580U)
					{
						goto IL_194E;
					}
					if (!(arg1 == "relic"))
					{
						goto IL_194E;
					}
					bool flag37 = RoleTable.Instance == null;
					if (flag37)
					{
						return "<color=red>错误：角色数据未加载！</color>";
					}
					bool flag38 = arg2 == "all";
					if (flag38)
					{
						foreach (Dictionary<string, string> item9 in Singleton<GameConfigManager>.Instance.GetTable(DataType.Relic).Getlines())
						{
							DataConfig relicconfig = new DataConfig(item9["Id"], DataType.Relic);
							RoleTable.Instance.relicList.Add(relicconfig);
						}
						return "给予所有遗物成功！共计 <color=yellow>" + Singleton<GameConfigManager>.Instance.GetTable(DataType.Relic).Getlines().Count.ToString() + "</color> 张遗物！";
					}
					DataConfig relicConfig = new DataConfig(arg2, DataType.Relic);
					RoleTable.Instance.WithoutArmedRelicList.Add(relicConfig);
					return "给予<color=yellow>1</color>个" + Singleton<GameConfigManager>.Instance.GetOne(DataType.Relic, arg2)["Name"] + "遗物成功！";
				}
				else
				{
					if (!(arg1 == "lucky"))
					{
						goto IL_194E;
					}
					goto IL_DC0;
				}
				bool flag39 = RoleTable.Instance == null;
				if (flag39)
				{
					return "<color=red>错误：角色数据未加载！</color>";
				}
				RoleTable.Instance.UseVarsChanges("Strength", int.Parse(arg2));
				bool flag40 = FightManager.Instance != null && FightManager.Instance.TempVarsMap.ContainsKey("Strength");
				if (flag40)
				{
					Dictionary<string, int> dictionary = FightManager.Instance.TempVarsMap;
					dictionary["Strength"] = dictionary["Strength"] + int.Parse(arg2);
				}
				return "给予<color=yellow>" + arg2 + "</color>力量成功！";
				IL_C70:
				Singleton<GameRuntimeData>.Instance.Truth += int.Parse(arg2);
				bool flag41 = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
				if (flag41)
				{
					UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeTrue();
				}
				return "给予<color=yellow>" + arg2 + "</color>真理之晶成功！";
				IL_DC0:
				bool flag42 = RoleTable.Instance == null;
				if (flag42)
				{
					return "<color=red>错误：角色数据未加载！</color>";
				}
				bool flag43 = FightManager.Instance != null && FightManager.Instance.TempVarsMap.ContainsKey("Lucky");
				if (flag43)
				{
					Dictionary<string, int> dictionary = FightManager.Instance.TempVarsMap;
					dictionary["Lucky"] = dictionary["Lucky"] + int.Parse(arg2);
				}
				RoleTable.Instance.UseVarsChanges("Lucky", int.Parse(arg2));
				return "给予<color=yellow>" + arg2 + "</color>幸运成功！";
				IL_E5E:
				bool flag44 = RoleTable.Instance == null;
				if (flag44)
				{
					return "<color=red>错误：角色数据未加载！</color>";
				}
				bool flag45 = FightManager.Instance != null && FightManager.Instance.TempVarsMap.ContainsKey("Perceive");
				if (flag45)
				{
					Dictionary<string, int> dictionary = FightManager.Instance.TempVarsMap;
					dictionary["Perceive"] = dictionary["Perceive"] + int.Parse(arg2);
				}
				RoleTable.Instance.UseVarsChanges("Perceive", int.Parse(arg2));
				return "给予<color=yellow>" + arg2 + "</color>感知成功！";
				IL_194E:
				result = "<color=red>错误：参数异常。</color>";
			}
			catch (DataConfigIdNotFoundException e)
			{
				Debug.LogError("DataConfigIdNotFoundException: " + e.Message);
				result = "<color=red>错误：未找到对应参数！</color>";
			}
			catch (Exception e2)
			{
				Debug.LogError("Error in give command: " + e2.Message);
				result = "<color=red>错误：给与物品失败！</color>";
			}
		}
		return result;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x0000AE84 File Offset: 0x00009084
	[HelpText("复制某物品")]
	public static string copy(string arg1 = "null", string arg2 = "null")
	{
		bool flag = RoleTable.Instance == null;
		string result;
		if (flag)
		{
			result = "<color=red>错误：角色数据未加载！</color>";
		}
		else
		{
			bool flag2 = arg1 == "null" || arg2 == "null";
			if (flag2)
			{
				result = "<color=red>错误：参数缺失！</color>";
			}
			else
			{
				try
				{
					if (!(arg1 == "card"))
					{
						if (!(arg1 == "bless"))
						{
							if (!(arg1 == "relic"))
							{
								if (!(arg1 == "item"))
								{
									result = "<color=red>错误：参数异常。</color>";
								}
								else
								{
									result = "未实现的方法！";
								}
							}
							else
							{
								DataConfig relicConfig = RoleTable.Instance.relicList.FirstOrDefault((DataConfig x) => x.Vars["InstanceID"] == arg2);
								bool flag3 = relicConfig == null;
								if (flag3)
								{
									result = "<color=red>错误：参数异常。</color>";
								}
								else
								{
									RoleTable.Instance.relicList.Add(relicConfig.Clone() as DataConfig);
									result = "复制遗物成功！";
								}
							}
						}
						else
						{
							DataConfig blessConfig = RoleTable.Instance.blessingConfigs.FirstOrDefault((DataConfig x) => x.Vars["InstanceID"] == arg2);
							bool flag4 = blessConfig == null;
							if (flag4)
							{
								result = "<color=red>错误：参数异常。</color>";
							}
							else
							{
								RoleTable.Instance.blessingConfigs.Add(blessConfig.Clone() as DataConfig);
								result = "复制祝福成功！";
							}
						}
					}
					else
					{
						DataConfig cardConfig = RoleTable.Instance.cardList.FirstOrDefault((DataConfig x) => x.Vars["InstanceID"] == arg2);
						bool flag5 = cardConfig == null;
						if (flag5)
						{
							result = "<color=red>错误：参数异常。</color>";
						}
						else
						{
							RoleTable.Instance.cardList.Add(cardConfig.Clone() as DataConfig);
							result = "复制卡牌成功！";
						}
					}
				}
				catch (DataConfigIdNotFoundException e)
				{
					Debug.LogError("DataConfigIdNotFoundException: " + e.Message);
					result = "<color=red>错误：未找到对应参数！</color>";
				}
				catch (Exception e2)
				{
					Debug.LogError("Error in copy command: " + e2.Message);
					result = "<color=red>错误：复制物品失败！</color>";
				}
			}
		}
		return result;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000B0C8 File Offset: 0x000092C8
	[HelpText("清除某物体")]
	public static string remove(string arg1 = "null", string arg2 = "null")
	{
		bool flag = arg1 == "null" || arg2 == "null";
		string result;
		if (flag)
		{
			result = "<color=red>错误：参数缺失！</color>";
		}
		else
		{
			try
			{
				uint num = <PrivateImplementationDetails>.ComputeStringHash(arg1);
				if (num <= 1944180856U)
				{
					if (num != 451949528U)
					{
						if (num != 932468937U)
						{
							if (num == 1944180856U)
							{
								if (arg1 == "randomcard")
								{
									List<DataConfig> cardDatas = RoleTable.Instance.cardList.ToList<DataConfig>();
									string delCard = "";
									for (int i = 0; i < int.Parse(arg2); i++)
									{
										DataConfig dataConfig = cardDatas[Commands.dice.WithRange(0, cardDatas.Count - 1).Roll().Value];
										RoleTable.Instance.cardList.Remove(dataConfig);
										bool flag2 = FightManager.Instance.fightType > FightType.None;
										if (flag2)
										{
											FightCardManager.Instance.cardList.Remove(dataConfig);
										}
										delCard = delCard + "<color=yellow>" + dataConfig.data.Localize("Name") + "</color> ";
									}
									return "清除<color=yellow>" + arg2 + "</color>张随机卡牌成功！" + delCard;
								}
							}
						}
						else if (arg1 == "randomrelic")
						{
							List<DataConfig> relicDatas = RoleTable.Instance.relicList.ToList<DataConfig>();
							string delRelic = "";
							for (int j = 0; j < int.Parse(arg2); j++)
							{
								DataConfig dataConfig2 = relicDatas[Commands.dice.WithRange(0, relicDatas.Count - 1).Roll().Value];
								RoleTable.Instance.relicList.Remove(dataConfig2);
								delRelic = delRelic + "<color=yellow>" + dataConfig2.data.Localize("Name") + "</color> ";
							}
							return "清除<color=yellow>" + arg2 + "</color>个随机遗物成功！" + delRelic;
						}
					}
					else if (arg1 == "bless")
					{
						bool flag3 = arg2 == "all" || arg2 == "All";
						if (flag3)
						{
							RoleTable.Instance.blessingConfigs.Clear();
							return "清除所有祝福成功！";
						}
						DataConfig blessConfig = RoleTable.Instance.blessingConfigs.FirstOrDefault((DataConfig x) => x.data["Id"] == arg2);
						bool flag4 = blessConfig == null;
						if (flag4)
						{
							return "<color=red>错误：参数异常。</color>";
						}
						RoleTable.Instance.blessingConfigs.Remove(blessConfig);
						return "清除<color=yellow>1</color>个" + Singleton<GameConfigManager>.Instance.GetOne(DataType.Bless, arg2)["Name"] + "祝福成功！";
					}
				}
				else if (num <= 2671260646U)
				{
					if (num != 2284280159U)
					{
						if (num == 2671260646U)
						{
							if (arg1 == "item")
							{
								return "未实现的方法！";
							}
						}
					}
					else if (arg1 == "card")
					{
						bool flag5 = arg2 == "all" || arg2 == "All";
						if (flag5)
						{
							RoleTable.Instance.cardList.Clear();
							bool flag6 = FightManager.Instance.fightType > FightType.None;
							if (flag6)
							{
								FightCardManager.Instance.cardList.Clear();
							}
							return "清除所有卡牌成功！";
						}
						bool flag7 = RoleTable.Instance.cardList.Count <= RoleTable.Instance.CardBottomCount;
						if (flag7)
						{
							return "卡牌数已达下限！";
						}
						DataConfig cardConfig = RoleTable.Instance.cardList.FirstOrDefault((DataConfig x) => x.data["Id"] == arg2);
						bool flag8 = cardConfig == null;
						if (flag8)
						{
							return "<color=red>错误：参数异常。</color>";
						}
						RoleTable.Instance.cardList.Remove(cardConfig);
						return "清除<color=yellow>1</color>张" + Singleton<GameConfigManager>.Instance.GetOne(DataType.Card, arg2)["Name"] + "卡牌成功！";
					}
				}
				else if (num != 3324249161U)
				{
					if (num == 4240957580U)
					{
						if (arg1 == "relic")
						{
							bool flag9 = arg2 == "all" || arg2 == "All";
							if (flag9)
							{
								Debug.Log("这里清了所有遗物");
								RoleTable.Instance.relicList.Clear();
								return "清除所有遗物成功！";
							}
							DataConfig relicConfig = RoleTable.Instance.relicList.ToList<DataConfig>().Find((DataConfig x) => x.data["Id"] == arg2);
							bool flag10 = relicConfig == null;
							if (flag10)
							{
								return "<color=red>错误：参数异常。</color>";
							}
							RoleTable.Instance.relicList.Remove(relicConfig);
							return "清除<color=yellow>1</color>张" + Singleton<GameConfigManager>.Instance.GetOne(DataType.Relic, arg2)["Name"] + "遗物成功！";
						}
					}
				}
				else if (arg1 == "randombless")
				{
					List<DataConfig> blessDatas = RoleTable.Instance.blessingConfigs.ToList<DataConfig>();
					string delBless = "";
					for (int k = 0; k < int.Parse(arg2); k++)
					{
						DataConfig dataConfig3 = blessDatas[Commands.dice.WithRange(0, blessDatas.Count - 1).Roll().Value];
						RoleTable.Instance.blessingConfigs.Remove(dataConfig3);
						delBless = delBless + "<color=yellow>" + dataConfig3.data.Localize("Name") + "</color> ";
					}
					return "清除<color=yellow>" + arg2 + "</color>个随机祝福成功！" + delBless;
				}
				result = "<color=red>错误：参数异常。</color>";
			}
			catch (DataConfigIdNotFoundException e)
			{
				Debug.LogError("DataConfigIdNotFoundException: " + e.Message);
				result = "<color=red>错误：未找到对应参数！</color>";
			}
			catch (Exception e2)
			{
				Debug.LogError("Error in remove command: " + e2.Message);
				result = "<color=red>错误：清除物品失败！</color>";
			}
		}
		return result;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0000B798 File Offset: 0x00009998
	[HelpText("立即加载地图。")]
	public static string load(string type, string id2 = null)
	{
		string result;
		try
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(type);
			if (num <= 2690589178U)
			{
				if (num <= 1939365082U)
				{
					if (num != 660393929U)
					{
						if (num != 1939365082U)
						{
							goto IL_943;
						}
						if (!(type == "reward"))
						{
							goto IL_943;
						}
					}
					else
					{
						if (!(type == "fight"))
						{
							goto IL_943;
						}
						goto IL_24F;
					}
				}
				else if (num != 2230030402U)
				{
					if (num != 2690589178U)
					{
						goto IL_943;
					}
					if (!(type == "Reward"))
					{
						goto IL_943;
					}
				}
				else
				{
					if (!(type == "FakeFight"))
					{
						goto IL_943;
					}
					goto IL_455;
				}
				MapManager.Instance.ModeMapManager.SetRewardType(id2);
				UIManager.Instance.ShowUIAsync<BattleRewardsUI>("BattleRewardsUI", true).Forget<BattleRewardsUI>();
				return "开启奖励界面成功！";
			}
			if (num <= 3281777315U)
			{
				if (num != 2965156162U)
				{
					if (num != 3281777315U)
					{
						goto IL_943;
					}
					if (!(type == "build"))
					{
						goto IL_943;
					}
					num = <PrivateImplementationDetails>.ComputeStringHash(id2);
					if (num <= 2184615833U)
					{
						if (num <= 340724834U)
						{
							if (num != 339158097U)
							{
								if (num != 340724834U)
								{
									goto IL_90A;
								}
								if (!(id2 == "random"))
								{
									goto IL_90A;
								}
								int count = MapManager.Instance.NowDice.WithRange(1, 3).Roll().Value;
								bool flag = count == 1;
								if (flag)
								{
									UIManager.Instance.ShowUIAsync<ShopUI>("ShopUI", true).Forget<ShopUI>();
									MapManager.Instance.CloseMapUI();
									return "开始商店成功！";
								}
								bool flag2 = count == 2;
								if (flag2)
								{
									UIManager.Instance.ShowUIAsync<DestinyTreeUI>("DestinyTreeUI", true).Forget<DestinyTreeUI>();
									MapManager.Instance.CloseMapUI();
									return "开始休息成功！";
								}
								GameApp.Instance.StartBreaks();
								MapManager.Instance.CloseMapUI();
								return "开启休息点成功！";
							}
							else
							{
								if (!(id2 == "breaks"))
								{
									goto IL_90A;
								}
								goto IL_809;
							}
						}
						else if (num != 1837839573U)
						{
							if (num != 2184615833U)
							{
								goto IL_90A;
							}
							if (!(id2 == "ench"))
							{
								goto IL_90A;
							}
							UIManager.Instance.ShowUIAsync<CardEnchUI>("CardEnchUI", true).Forget<CardEnchUI>();
							MapManager.Instance.CloseMapUI();
							return "开启卡牌附魔成功！";
						}
						else if (!(id2 == "tree"))
						{
							goto IL_90A;
						}
					}
					else if (num <= 3007971253U)
					{
						if (num != 2823282857U)
						{
							if (num != 3007971253U)
							{
								goto IL_90A;
							}
							if (!(id2 == "destiny"))
							{
								goto IL_90A;
							}
						}
						else
						{
							if (!(id2 == "shop"))
							{
								goto IL_90A;
							}
							UIManager.Instance.ShowUIAsync<ShopUI>("ShopUI", true).Forget<ShopUI>();
							MapManager.Instance.CloseMapUI();
							return "开始商店成功！";
						}
					}
					else if (num != 3378807160U)
					{
						if (num != 3896983409U)
						{
							goto IL_90A;
						}
						if (!(id2 == "Breaks"))
						{
							goto IL_90A;
						}
						goto IL_809;
					}
					else
					{
						if (!(id2 == "break"))
						{
							goto IL_90A;
						}
						goto IL_809;
					}
					UIManager.Instance.ShowUIAsync<DestinyTreeUI>("DestinyTreeUI", true).Forget<DestinyTreeUI>();
					MapManager.Instance.CloseMapUI();
					return "开启命运树成功";
					IL_809:
					GameApp.Instance.StartBreaks();
					MapManager.Instance.CloseMapUI();
					return "开始休息成功！";
					IL_90A:
					return "错误：参数异常！";
				}
				else
				{
					if (!(type == "fakefight"))
					{
						goto IL_943;
					}
					goto IL_455;
				}
			}
			else if (num != 3440918889U)
			{
				if (num != 4264611999U)
				{
					goto IL_943;
				}
				if (!(type == "event"))
				{
					goto IL_943;
				}
				List<Dictionary<string, string>> eventData = Singleton<GameConfigManager>.Instance.GetTable(DataType.Event).Getlines();
				eventData = (from x in eventData.AsValueEnumerable<Dictionary<string, string>>()
				where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"]) && !x["Id"].Contains("Sub")
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
				int id3 = MapManager.Instance.NowDice.WithRange(0, eventData.Count - 1).Roll().Value;
				string id = eventData[id3]["Id"];
				bool flag3 = !string.IsNullOrEmpty(id2);
				if (flag3)
				{
					id = id2;
				}
				else
				{
					bool flag4 = eventData.FindIndex((Dictionary<string, string> x) => x["Id"] == id) == -1;
					if (flag4)
					{
						return "错误：事件ID不存在！";
					}
				}
				UIManager.Instance.CloseUI("EventUI");
				MapManager.Instance.CloseMapUI();
				UIManager.Instance.ShowEventUI(id);
				return "开始事件成功！";
			}
			else if (!(type == "Fight"))
			{
				goto IL_943;
			}
			IL_24F:
			List<Dictionary<string, string>> fightData = Singleton<GameConfigManager>.Instance.GetTable(DataType.Level).Getlines();
			bool flag5 = id2 == "boss";
			if (flag5)
			{
				fightData = (from x in fightData.AsValueEnumerable<Dictionary<string, string>>()
				where x["Note"].Contains("boss")
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			}
			bool flag6 = id2 == "common";
			if (flag6)
			{
				fightData = (from x in fightData.AsValueEnumerable<Dictionary<string, string>>()
				where x["Note"].Contains("普通")
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			}
			bool flag7 = id2 == "elite";
			if (flag7)
			{
				fightData = (from x in fightData.AsValueEnumerable<Dictionary<string, string>>()
				where x["Note"].Contains("精英")
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			}
			fightData = (from x in fightData.AsValueEnumerable<Dictionary<string, string>>()
			where int.Parse(x["Level"]) == MapManager.Instance.Level / 12 || x["Level"] == "-1"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			bool flag8 = id2 == null || id2 == "common" || id2 == "elite" || id2 == "boss";
			string realId;
			if (flag8)
			{
				int id3 = MapManager.Instance.NowDice.WithRange(0, fightData.Count - 1).Roll().Value;
				realId = fightData[id3]["Id"];
				bool flag9 = Singleton<GameRuntimeData>.Instance.IsLocked(fightData[id3]["Id"]);
				if (flag9)
				{
					realId = "level_10001";
				}
			}
			else
			{
				realId = id2;
				bool flag10 = Singleton<GameConfigManager>.Instance.GetOne(DataType.Level, id2) == null;
				if (flag10)
				{
					return "错误：战斗ID不存在！";
				}
			}
			GameApp.Instance.StartFight(realId).Forget();
			MapManager.Instance.CloseMapUI();
			UIManager.Instance.CloseUI("EventUI");
			return "开始战斗成功！";
			IL_455:
			List<Dictionary<string, string>> tempData = Singleton<GameConfigManager>.Instance.GetTable(DataType.Level).Getlines();
			bool flag11 = id2 == "boss";
			if (flag11)
			{
				tempData = (from x in tempData.AsValueEnumerable<Dictionary<string, string>>()
				where x["Note"].Contains("boss")
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			}
			bool flag12 = id2 == "common";
			if (flag12)
			{
				tempData = (from x in tempData.AsValueEnumerable<Dictionary<string, string>>()
				where x["Note"].Contains("普通")
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			}
			bool flag13 = id2 == "elite";
			if (flag13)
			{
				tempData = (from x in tempData.AsValueEnumerable<Dictionary<string, string>>()
				where x["Note"].Contains("精英")
				select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			}
			tempData = (from x in tempData.AsValueEnumerable<Dictionary<string, string>>()
			where int.Parse(x["Level"]) == MapManager.Instance.Level / 12 || x["Level"] == "-1"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			bool flag14 = id2 == null || id2 == "common" || id2 == "elite" || id2 == "boss";
			string thisId;
			if (flag14)
			{
				int id3 = MapManager.Instance.NowDice.WithRange(0, tempData.Count - 1).Roll().Value;
				thisId = tempData[id3]["Id"];
				bool flag15 = Singleton<GameRuntimeData>.Instance.IsLocked(tempData[id3]["Id"]);
				if (flag15)
				{
					thisId = "level_10001";
				}
			}
			else
			{
				thisId = id2;
				bool flag16 = Singleton<GameConfigManager>.Instance.GetOne(DataType.Level, id2) == null;
				if (flag16)
				{
					return "错误：战斗ID不存在！";
				}
			}
			GameApp.Instance.StartFakeFight(thisId).Forget();
			MapManager.Instance.CloseMapUI();
			UIManager.Instance.CloseUI("EventUI");
			return "开始虚拟战斗成功！";
			IL_943:
			result = "错误：参数异常！";
		}
		catch (DataConfigIdNotFoundException e)
		{
			Debug.LogError("DataConfigIdNotFoundException: " + e.Message);
			result = "<color=red>错误：未找到对应参数！</color>";
		}
		catch (Exception e2)
		{
			Debug.LogError("Error in load command: " + e2.Message);
			result = "<color=red>错误：加载地图失败！</color>";
		}
		return result;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0000C170 File Offset: 0x0000A370
	[HelpText("对话相关指令。")]
	public static string dialogue(string arg1, string arg2 = null)
	{
		bool flag = string.IsNullOrEmpty(arg1);
		string result;
		if (flag)
		{
			result = "<color=red>错误：参数缺失！</color>";
		}
		else
		{
			try
			{
				if (!(arg1 == "show"))
				{
					if (!(arg1 == "end"))
					{
						if (!(arg1 == "next"))
						{
							return "<color=red>错误：参数异常。</color>";
						}
						Singleton<DialogueManager>.Instance.NextDialogue();
					}
					else
					{
						Singleton<DialogueManager>.Instance.EndDialogue();
					}
				}
				else
				{
					bool flag2 = string.IsNullOrEmpty(arg2);
					if (flag2)
					{
						return "<color=red>错误：参数缺失！</color>";
					}
					Singleton<DialogueManager>.Instance.ShowDialogue(arg2);
				}
				result = "加载对话成功！";
			}
			catch (DataConfigIdNotFoundException e)
			{
				Debug.LogError("DataConfigIdNotFoundException: " + e.Message);
				result = "<color=red>错误：未找到对应参数！</color>";
			}
			catch (Exception e2)
			{
				Debug.LogError("Error in dialogue command: " + e2.Message);
				result = "<color=red>错误：对话加载失败！</color>";
			}
		}
		return result;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000C274 File Offset: 0x0000A474
	public static string setId(string arg1)
	{
		Singleton<GameConfigManager>.Instance.PlayerId = arg1;
		bool flag = PlayerManager.Instance != null;
		if (flag)
		{
			PlayerManager.Instance.playerInfo.Id = arg1;
		}
		return "设置ID成功！";
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
	[HelpText("查看某个ID的源数据。用法：check <id>")]
	public static string check(string arg1 = "null")
	{
		bool flag = arg1 == "null";
		string result;
		if (flag)
		{
			result = "<color=red>错误：参数缺失！</color>";
		}
		else
		{
			string id = arg1.Replace("*", "");
			Dictionary<string, string> data = Singleton<GameConfigManager>.Instance.GetOneById(id);
			bool flag2 = data == null;
			if (flag2)
			{
				result = "<color=red>错误：未找到对应参数！</color>";
			}
			else
			{
				string output = "<color=orange>" + id + "</color>\n";
				foreach (KeyValuePair<string, string> kv in data)
				{
					output = string.Concat(new string[]
					{
						output,
						kv.Key,
						": ",
						kv.Value,
						"\n"
					});
				}
				result = output.TrimEnd('\n');
			}
		}
		return result;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
	public static void Log(string arg1, string arg2)
	{
		ConsoleUI ui = UIManager.Instance.GetUI<ConsoleUI>("ConsoleUI");
		if (ui != null)
		{
			ui.Output(arg1, arg2);
		}
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0000C3C8 File Offset: 0x0000A5C8
	public static void LogWarning(string arg1, string arg2)
	{
		ConsoleUI ui = UIManager.Instance.GetUI<ConsoleUI>("ConsoleUI");
		if (ui != null)
		{
			ui.Output(arg1, "<color=yellow>Warning:" + arg2 + "</color>");
		}
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000C3F7 File Offset: 0x0000A5F7
	public static void LogError(string arg1, string arg2)
	{
		ConsoleUI ui = UIManager.Instance.GetUI<ConsoleUI>("ConsoleUI");
		if (ui != null)
		{
			ui.Output(arg1, "<color=red>Error:" + arg2 + "</color>");
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0000C426 File Offset: 0x0000A626
	public static void ShowReward(string arg1, string arg2 = null)
	{
		UIManager.Instance.ShowUIAsync<BattleRewardsUI>("BattleRewardsUI", true).Forget<BattleRewardsUI>();
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0000C440 File Offset: 0x0000A640
	[HelpText("请在游戏开始前使用，除非你知道你在做什么")]
	public static void connect(string arg1)
	{
		bool flag = arg1 == "null";
		if (flag)
		{
			Debug.LogError("connect命令缺少参数！");
		}
		else
		{
			bool active = NetworkServer.active;
			if (active)
			{
				LobbyManager.Instance.StopHost();
			}
			GameApp.Instance.ChangeTransportToKCP();
			LobbyManager.Instance.networkAddress = arg1;
			LobbyManager.Instance.StartClient();
			UIManager.Instance.ShowUI<GameEntryUI>("GameEntryUI", true).Init();
		}
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
	[HelpText("锁定物品")]
	public static void lockitem(string arg1)
	{
		arg1 = arg1.Replace("*", "");
		bool flag = Singleton<GameConfigManager>.Instance.LockedIds.Contains(arg1) && Singleton<GameRuntimeData>.Instance.UnLockDataConfigs.Contains(arg1);
		if (flag)
		{
			Singleton<GameRuntimeData>.Instance.UnLockDataConfigs.Remove(arg1);
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0000C514 File Offset: 0x0000A714
	[HelpText("解锁物品")]
	public static void unlock(string arg1)
	{
		arg1 = arg1.Replace("*", "");
		bool flag = Singleton<GameConfigManager>.Instance.LockedIds.Contains(arg1) && !Singleton<GameRuntimeData>.Instance.UnLockDataConfigs.Contains(arg1);
		if (flag)
		{
			Singleton<GameRuntimeData>.Instance.UnLockDataConfigs.Add(arg1);
		}
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0000C573 File Offset: 0x0000A773
	public static void eventtrigger(string arg1)
	{
		Singleton<EventCenter>.Instance.EventTrigger(arg1);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0000C584 File Offset: 0x0000A784
	[HelpText("自动打出卡牌")]
	public static void auto(string arg1)
	{
		bool flag = FightManager.Instance == null || FightManager.Instance.fightType == FightType.None;
		if (flag)
		{
			Debug.LogError("auto命令只能在战斗中使用！");
		}
		else
		{
			bool flag2 = arg1 == "on";
			if (flag2)
			{
				Commands.give("power", "999");
				Commands.give("draw", "10");
				bool flag3 = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
				if (flag3)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").autoCard = true;
				}
				Debug.Log("自动打牌已开启！");
			}
			else
			{
				bool flag4 = arg1 == "off";
				if (flag4)
				{
					bool flag5 = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
					if (flag5)
					{
						UIManager.Instance.GetUI<FightUI>("FightUI").autoCard = false;
					}
					Debug.Log("自动打牌已关闭！");
				}
				else
				{
					Debug.LogError("auto命令参数错误！请使用auto on或auto off");
				}
			}
		}
	}

	// Token: 0x040000A4 RID: 164
	private const string ArgsMissing = "<color=red>错误：参数缺失！</color>";

	// Token: 0x040000A5 RID: 165
	private const string ArgsError = "<color=red>错误：参数异常。</color>";

	// Token: 0x040000A6 RID: 166
	private const string ArgsNotFound = "<color=red>错误：未找到对应参数！</color>";
}

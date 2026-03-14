using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Data.Save;
using Fight.ActionCommand;
using UnityEngine;
using UnityEngine.EventSystems;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x02000018 RID: 24
public class CommonCardItem : CardItem, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x060000A4 RID: 164 RVA: 0x000061C4 File Offset: 0x000043C4
	public override void OnEndDrag(PointerEventData eventData)
	{
		bool flag = !base.draging;
		if (!flag)
		{
			bool flag2 = base.transform.localPosition.y > 100f;
			if (flag2)
			{
				this.TrueUse();
			}
			else
			{
				bool flag3 = base.Tags.Contains("Instant") && this.hasDone;
				if (flag3)
				{
					Debug.Log("触发瞬发牌回手逻辑");
				}
				else
				{
					DataConfig dataConfig = this.dataConfig;
					bool flag4 = ((dataConfig != null) ? dataConfig.scriptExecutor : null) != null;
					if (flag4)
					{
						this.dataConfig.scriptExecutor.Target = null;
					}
					string endInit;
					bool flag5 = this.data != null && this.data.TryGetValue("InitScript", out endInit) && endInit != null && endInit.Contains("Damage");
					if (flag5)
					{
						this.DataUpdate();
					}
					base.OnEndDrag(eventData);
				}
			}
		}
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x000062B0 File Offset: 0x000044B0
	public override void OnBeginDrag(PointerEventData eventData)
	{
		base.OnBeginDrag(eventData);
		DataConfig dataConfig = this.dataConfig;
		bool flag = ((dataConfig != null) ? dataConfig.scriptExecutor : null) == null;
		if (!flag)
		{
			bool flag2 = EnemyManager.Instance == null || EnemyManager.Instance.enemyList.Count == 0;
			if (!flag2)
			{
				Enemy firstEnemy = EnemyManager.Instance.enemyList[0];
				bool flag3 = ((firstEnemy != null) ? firstEnemy.Status : null) == null;
				if (!flag3)
				{
					this.dataConfig.scriptExecutor.Target = firstEnemy.Status;
					string initScript;
					bool flag4 = this.data != null && this.data.TryGetValue("InitScript", out initScript) && initScript != null && initScript.Contains("Damage");
					if (flag4)
					{
						this.DataUpdate();
					}
				}
			}
		}
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00006384 File Offset: 0x00004584
	private void TrueUse()
	{
		bool hasUse = this.hasUse;
		if (!hasUse)
		{
			this.hasUse = true;
			bool flag = base.Tags.Contains("Recycle");
			if (flag)
			{
				this.hasUse = false;
			}
			else
			{
				base.transform.GetComponent<ObjectGroup>().blocksRaycasts = false;
			}
			ValueTuple<bool, Action> result = this.TryUse();
			bool flag2 = result.Item2 != null && !GameSaveManager.GetValue<bool>(GameVar.LateThrow);
			if (flag2)
			{
				result.Item2();
			}
			bool item = result.Item1;
			if (item)
			{
				CardItem.UseCount = (int)this.status.dynamicVariables.GetValueOrDefault("UseCount", 1f) + CommonCardItem.ExUseCount;
				this.status.dynamicVariables["UseCount"] = 1f;
				for (int i = 0; i < CardItem.UseCount; i++)
				{
					base.RunScript("UseScript");
				}
				UIManager.Instance.GetUI<FightUI>("FightUI").CallActionAnimation(base.scriptExecutor);
			}
			else
			{
				this.hasUse = false;
			}
			bool flag3 = base.Tags.Contains("Recycle");
			if (flag3)
			{
				this.hasUse = false;
			}
			CommonCardItem.ExUseCount = 0;
			bool flag4 = result.Item2 != null && GameSaveManager.GetValue<bool>(GameVar.LateThrow);
			if (flag4)
			{
				result.Item2();
			}
			base.draging = false;
			FightUI fightUI = UIManager.Instance.GetUI<FightUI>("FightUI");
			bool flag5 = fightUI != null;
			if (flag5)
			{
				fightUI.UpdateCardItemPos(null, null);
			}
			FightUI.LastCard = this.dataConfig;
		}
	}

	/// <summary> 键盘按下数字键时直接打出（非目标型牌）。 </summary>
	// Token: 0x060000A7 RID: 167 RVA: 0x00006534 File Offset: 0x00004734
	public void UseCardDirectly()
	{
		bool flag = !CardItem.canUse || !UIUtil.CheckClickable(base.transform);
		if (!flag)
		{
			DataConfig dataConfig = this.dataConfig;
			bool flag2 = ((dataConfig != null) ? dataConfig.scriptExecutor : null) != null && EnemyManager.Instance != null && EnemyManager.Instance.enemyList.Count > 0;
			if (flag2)
			{
				this.dataConfig.scriptExecutor.Target = EnemyManager.Instance.enemyList[0].Status;
			}
			string init;
			bool flag3 = this.data != null && this.data.TryGetValue("InitScript", out init) && init != null && init.Contains("Damage");
			if (flag3)
			{
				this.DataUpdate();
			}
			this.TrueUse();
			DataConfig dataConfig2 = this.dataConfig;
			bool flag4 = ((dataConfig2 != null) ? dataConfig2.scriptExecutor : null) != null;
			if (flag4)
			{
				this.dataConfig.scriptExecutor.Target = null;
			}
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0000662C File Offset: 0x0000482C
	public void OnPointerDown(PointerEventData eventData)
	{
		bool flag = !base.enabled;
		if (!flag)
		{
			bool flag2 = CardItem.canUse && eventData.button == PointerEventData.InputButton.Left;
			if (flag2)
			{
				bool flag3 = Time.time - this.lasttime < 0.25f;
				if (flag3)
				{
					this.TrueUse();
				}
				else
				{
					this.lasttime = Time.time;
				}
			}
		}
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00006690 File Offset: 0x00004890
	[DebuggerStepThrough]
	public override void DrawEffect()
	{
		CommonCardItem.<DrawEffect>d__9 <DrawEffect>d__ = new CommonCardItem.<DrawEffect>d__9();
		<DrawEffect>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		<DrawEffect>d__.<>4__this = this;
		<DrawEffect>d__.<>1__state = -1;
		<DrawEffect>d__.<>t__builder.Start<CommonCardItem.<DrawEffect>d__9>(ref <DrawEffect>d__);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000066CC File Offset: 0x000048CC
	protected ValueTuple<bool, Action> TryUse()
	{
		bool flag = this.status.IsNull();
		ValueTuple<bool, Action> result2;
		if (flag)
		{
			result2 = new ValueTuple<bool, Action>(false, null);
		}
		else
		{
			bool flag2 = this.status.state == IStatusManager.State.Dead || this.status.state == IStatusManager.State.NoAction;
			if (flag2)
			{
				result2 = new ValueTuple<bool, Action>(false, null);
			}
			else
			{
				bool flag3 = FightManager.Instance == null || FightManager.Instance.fightType != FightType.Player;
				if (flag3)
				{
					result2 = new ValueTuple<bool, Action>(false, null);
				}
				else
				{
					bool flag4 = this.data == null || this.dataConfig == null;
					if (flag4)
					{
						result2 = new ValueTuple<bool, Action>(false, null);
					}
					else
					{
						bool canUse = CardItem.canUse;
						if (canUse)
						{
							bool success = true;
							foreach (Func<CommonCardItem, bool> check in CommonCardItem.UseChecker)
							{
								success &= check(this);
							}
							bool flag5 = !success;
							if (flag5)
							{
								result2 = new ValueTuple<bool, Action>(false, null);
							}
							else
							{
								FightPlayer instance = FightPlayer.Instance;
								bool flag6 = ((instance != null) ? instance.Status : null) == null;
								if (flag6)
								{
									result2 = new ValueTuple<bool, Action>(false, null);
								}
								else
								{
									string expendStr;
									int expendVal;
									bool flag7 = !this.data.TryGetValue("Expend", out expendStr) || !int.TryParse(expendStr, out expendVal);
									if (flag7)
									{
										result2 = new ValueTuple<bool, Action>(false, null);
									}
									else
									{
										int cost = Math.Min((int)((float)expendVal * FightPlayer.Instance.Status.dynamicVariables.GetValueOrDefault("CardCost", 1f)), 4);
										bool flag8 = base.Tags.Contains("Exhaustion");
										if (flag8)
										{
											cost++;
										}
										EventCenter instance2 = Singleton<EventCenter>.Instance;
										if (instance2 != null)
										{
											string eventName = "Action" + this.status.InstanceId;
											IDataConfig dataConfig = this.dataConfig;
											RoleTable instance3 = RoleTable.Instance;
											instance2.EventTrigger<ActionData>(eventName, new ActionData(dataConfig, (instance3 != null) ? instance3.Id : null));
										}
										Commands.Log("<color=grey>" + this.data.Localize("Name") + "</color>使用了", "能量从" + FightPlayer.Instance.CurPowerCount.ToString() + "减少到" + (FightPlayer.Instance.CurPowerCount - cost).ToString());
										FightPlayer.Instance.CurPowerCount -= cost;
										bool flag9 = cost > 0;
										if (flag9)
										{
											EventCenter instance4 = Singleton<EventCenter>.Instance;
											if (instance4 != null)
											{
												instance4.EventTrigger("CostPower" + this.status.InstanceId);
											}
										}
										bool flag10 = FightPlayer.Instance.CurPowerCount <= 0;
										if (flag10)
										{
											EventCenter instance5 = Singleton<EventCenter>.Instance;
											if (instance5 != null)
											{
												instance5.EventTrigger("NoPower" + this.status.InstanceId);
											}
										}
										this.status.CheckAllBuff("ReducePerUse");
										bool blockUse = false;
										bool blockThrow = false;
										Action onUse = null;
										foreach (Func<CommonCardItem, ValueTuple<bool, bool, Action>> callback in CommonCardItem.UseCallback)
										{
											ValueTuple<bool, bool, Action> result = callback(this);
											blockUse |= result.Item2;
											blockThrow |= result.Item1;
											onUse = (Action)Delegate.Combine(onUse, result.Item3);
										}
										bool flag11 = !blockThrow;
										if (flag11)
										{
											onUse = (Action)Delegate.Combine(onUse, new Action(base.InternalThrow));
										}
										bool flag12 = !blockUse;
										if (flag12)
										{
											FightManager instance6 = FightManager.Instance;
											if (instance6 != null)
											{
												instance6.EnqueueEvent(new UseCard().Create(new UseCard.CardUseData
												{
													cardData = this.dataConfig,
													isBurning = base.Tags.Contains("Burnout")
												}));
											}
										}
										result2 = new ValueTuple<bool, Action>(!blockUse, onUse);
									}
								}
							}
						}
						else
						{
							result2 = new ValueTuple<bool, Action>(false, null);
						}
					}
				}
			}
		}
		return result2;
	}

	// Token: 0x04000064 RID: 100
	public static List<Func<CommonCardItem, bool>> UseChecker = new List<Func<CommonCardItem, bool>>
	{
		delegate(CommonCardItem card)
		{
			string value;
			bool flag = (card.scriptExecutor.dataConfig.Vars.TryGetValue("Usable", out value) && value == "0") || card.Tags.Contains("Unusable");
			bool result;
			if (flag)
			{
				UIManager.Instance.ShowTip("无法被打出", null);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		},
		delegate(CommonCardItem card)
		{
			int cost = Math.Min((int)((float)int.Parse(card.data["Expend"]) * FightPlayer.Instance.Status.dynamicVariables.GetValueOrDefault("CardCost", 1f)), 4);
			bool flag = card.Tags.Contains("Exhaustion");
			if (flag)
			{
				cost++;
			}
			bool flag2 = cost > FightPlayer.Instance.CurPowerCount;
			bool result;
			if (flag2)
			{
				AudioManager instance = AudioManager.Instance;
				if (instance != null)
				{
					instance.PlayEffect("Effect/lose");
				}
				UIManager.Instance.ShowTip("费用不足", null);
				Singleton<EventCenter>.Instance.EventTrigger("NoPowerWhenTry" + card.status.InstanceId);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		},
		delegate(CommonCardItem card)
		{
			bool flag = RoleTable.Instance == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = RoleTable.Instance.enchasedDict.ContainsKey(card.dataConfig.InstanceID);
				if (flag2)
				{
					DataConfig ench = RoleTable.Instance.enchasedDict[card.dataConfig.InstanceID];
					bool flag3 = ench.data["Id"] == "enchtag_2";
					if (flag3)
					{
						CommonCardItem.ExUseCount = 5;
					}
					else
					{
						bool flag4 = ench.data["Id"] == "enchtag_3";
						if (flag4)
						{
							CommonCardItem.ExUseCount = 1;
						}
					}
				}
				result = true;
			}
			return result;
		}
	};

	// Token: 0x04000065 RID: 101
	public static int ExUseCount = 0;

	// Token: 0x04000066 RID: 102
	[TupleElementNames(new string[]
	{
		"blockThrow",
		"blockUse",
		"onUse"
	})]
	public static List<Func<CommonCardItem, ValueTuple<bool, bool, Action>>> UseCallback = new List<Func<CommonCardItem, ValueTuple<bool, bool, Action>>>
	{
		delegate(CommonCardItem card)
		{
			bool flag = card.Tags.Contains("Burnout");
			ValueTuple<bool, bool, Action> result;
			if (flag)
			{
				FightUI.cardItemList.Remove(card);
				result = new ValueTuple<bool, bool, Action>(true, false, delegate()
				{
					card.InternalBurning(0f);
					FightManager instance = FightManager.Instance;
					if (instance != null)
					{
						instance.EnqueueEvent(new UseCard().Create(new UseCard.CardUseData
						{
							cardData = card.dataConfig,
							isBurning = true
						}));
					}
				});
			}
			else
			{
				result = new ValueTuple<bool, bool, Action>(false, false, null);
			}
			return result;
		},
		delegate(CommonCardItem card)
		{
			bool flag = card.Tags.Contains("Fragmented") || (card.Vars.ContainsKey("NeedRemove") && card.Vars["NeedRemove"] == "True");
			ValueTuple<bool, bool, Action> result;
			if (flag)
			{
				result = new ValueTuple<bool, bool, Action>(true, false, delegate()
				{
					card.InternalBurning(0f);
					RoleTable.Instance.cardList.Remove(card.dataConfig);
					RoleTable.Instance.UnCardList.Remove(card.dataConfig);
				});
			}
			else
			{
				result = new ValueTuple<bool, bool, Action>(false, false, null);
			}
			return result;
		},
		delegate(CommonCardItem card)
		{
			bool flag = card.Tags.Contains("Instant");
			ValueTuple<bool, bool, Action> result;
			if (flag)
			{
				Action <>9__11;
				result = new ValueTuple<bool, bool, Action>(false, true, delegate()
				{
					card.status.AddBuff("buff_timelock", 1);
					Collection<ValueTuple<IDataConfig, Action>> effectList = card.status.GetBuff("buff_timelock").effectList;
					IDataConfig dataConfig = card.dataConfig;
					Action item;
					if ((item = <>9__11) == null)
					{
						item = (<>9__11 = delegate()
						{
							card.scriptExecutor.RunScript("UseScript");
							IScriptExecutor enchScriptExecutor = card.enchScriptExecutor;
							if (enchScriptExecutor != null)
							{
								enchScriptExecutor.RunScript("UseScript");
							}
						});
					}
					effectList.Add(new ValueTuple<IDataConfig, Action>(dataConfig, item));
				});
			}
			else
			{
				result = new ValueTuple<bool, bool, Action>(false, false, null);
			}
			return result;
		},
		delegate(CommonCardItem card)
		{
			bool flag = card.Tags.Contains("Recycle");
			ValueTuple<bool, bool, Action> result;
			if (flag)
			{
				result = new ValueTuple<bool, bool, Action>(true, false, null);
			}
			else
			{
				result = new ValueTuple<bool, bool, Action>(false, false, null);
			}
			return result;
		},
		delegate(CommonCardItem card)
		{
			bool flag = card.Tags.Contains("Ouroboros");
			ValueTuple<bool, bool, Action> result;
			if (flag)
			{
				bool flag2 = !FightUI.cardItemList.Remove(card);
				if (flag2)
				{
					result = new ValueTuple<bool, bool, Action>(false, false, null);
				}
				else
				{
					result = new ValueTuple<bool, bool, Action>(true, false, delegate()
					{
						FightCardManager.Instance.cardList.Add(card.dataConfig);
						card.DataUpdate();
						card.EffectOfThrowCard("Canvas/FightUI/Left/Card");
					});
				}
			}
			else
			{
				result = new ValueTuple<bool, bool, Action>(false, false, null);
			}
			return result;
		}
	};

	// Token: 0x04000067 RID: 103
	public float lasttime = 0f;
}

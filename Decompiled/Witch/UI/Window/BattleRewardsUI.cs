using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Data.Save;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000284 RID: 644
	public class BattleRewardsUI : UIBase
	{
		// Token: 0x06001462 RID: 5218 RVA: 0x0009F6EC File Offset: 0x0009D8EC
		[DebuggerStepThrough]
		private void Awake()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.Awake()).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_Awake();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0009F7E8 File Offset: 0x0009D9E8
		[DebuggerStepThrough]
		public override void DataUpdate()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.DataUpdate()).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_DataUpdate();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0009F8E4 File Offset: 0x0009DAE4
		[DebuggerStepThrough]
		private void Start()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.Start()).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_Start();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0009F9E0 File Offset: 0x0009DBE0
		[DebuggerStepThrough]
		public void ModeSetReward()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.ModeSetReward()).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_ModeSetReward();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0009FADC File Offset: 0x0009DCDC
		[DebuggerStepThrough]
		public void SetMoney(int count)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.SetMoney(int)).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				count
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							count = 0;
						}
						else
						{
							count = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetMoney(count);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_105;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_105:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0009FC18 File Offset: 0x0009DE18
		public override void OnDestroy()
		{
			base.OnDestroy();
			foreach (DataConfig item in this.RelicRewardList)
			{
				RoleTable.Instance.Money += 70 * int.Parse(item.data.GetValueOrDefault("Rarity", null));
			}
			bool inHighTide = RoleTable.Instance.InHighTide;
			if (inHighTide)
			{
				RoleTable.Instance.InHighTide = false;
			}
			RoleTable.Instance.Money += this.Money + this.CardCount * 10;
			this.RelicRewardList.Clear();
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0009FCF8 File Offset: 0x0009DEF8
		[DebuggerStepThrough]
		public void RandomSetRelic(List<Dictionary<string, string>> lists)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.RandomSetRelic(List<Dictionary<string, string>>)).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				lists
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							lists = null;
						}
						else
						{
							lists = (List<Dictionary<string, string>>)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_RandomSetRelic(lists);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_FD;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_FD:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0009FE2C File Offset: 0x0009E02C
		[DebuggerStepThrough]
		public void RandomSetCard()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.RandomSetCard()).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_RandomSetCard();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0009FF28 File Offset: 0x0009E128
		[DebuggerStepThrough]
		public void RandomAddBless()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.RandomAddBless()).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_RandomAddBless();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000A0024 File Offset: 0x0009E224
		[DebuggerStepThrough]
		public void GenerBlessing()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.GenerBlessing()).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_GenerBlessing();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000A0120 File Offset: 0x0009E320
		[DebuggerStepThrough]
		private void Entry()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.Entry()).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_Entry();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000A021C File Offset: 0x0009E41C
		[DebuggerStepThrough]
		public void AnimationPlay(GameObject obj)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BattleRewardsUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BattleRewardsUI.AnimationPlay(GameObject)).MethodHandle, typeof(BattleRewardsUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				obj
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							obj = null;
						}
						else
						{
							obj = (GameObject)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_AnimationPlay(obj);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_FD;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_FD:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x000A04C4 File Offset: 0x0009E6C4
		private void $Rougamo_Awake()
		{
			this.itemList = base.transform.Find("Window Manager/Windows/奖励选择/Content/List View Custom/Scroll Area/List");
			Transform transform = this.itemList;
			Transform itemTran = (transform != null) ? transform.Find("Item") : null;
			bool flag = itemTran != null;
			if (flag)
			{
				this.item1 = itemTran.gameObject;
			}
			UIManager instance = UIManager.Instance;
			BackpackUI backpackUI = (instance != null) ? instance.GetUI<BackpackUI>("BackpackUI") : null;
			bool flag2 = backpackUI != null;
			if (flag2)
			{
				this.blessingUI = backpackUI.statusUI;
			}
			this.Money = 0;
			UIManager instance2 = UIManager.Instance;
			OutDeckUI outDeckUI = (instance2 != null) ? instance2.GetUI<OutDeckUI>("OutDeckUI") : null;
			bool flag3 = outDeckUI != null && outDeckUI.gameObject.activeSelf;
			if (flag3)
			{
				outDeckUI.Hide();
			}
			this.DataUpdate();
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000A0592 File Offset: 0x0009E792
		private void $Rougamo_DataUpdate()
		{
			this.itemList.Find("Text").GetComponent<TMP_Text>().text = "Unclaimed rewards will be automatically converted.".Localize("BattleRewardUI");
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000A05C0 File Offset: 0x0009E7C0
		private void $Rougamo_Start()
		{
			bool flag = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
			if (flag)
			{
				Debug.Log("战斗回合没结束");
				FightManager.Instance.ChangeUnit(FightType.None);
			}
			bool flag2 = UIManager.Instance.GetUI<BackpackUI>("BackpackUI") != null && UIManager.Instance.GetUI<BackpackUI>("BackpackUI").gameObject.activeSelf;
			if (flag2)
			{
				UIManager.Instance.GetUI<BackpackUI>("BackpackUI").Close();
			}
			bool flag3 = UIManager.Instance.GetUI<DictionaryUI>("DictionaryUI") != null && UIManager.Instance.GetUI<DictionaryUI>("DictionaryUI").gameObject.activeSelf;
			if (flag3)
			{
				UIManager.Instance.GetUI<DictionaryUI>("DictionaryUI").Hide();
			}
			bool flag4 = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") == null;
			if (flag4)
			{
				this.Close();
			}
			else
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").transform.SetAsLastSibling();
				bool flag5 = UIManager.Instance.GetUI<ItemShowUI>("ItemShowUI") != null;
				if (flag5)
				{
					UIManager.Instance.GetUI<ItemShowUI>("ItemShowUI").transform.SetAsLastSibling();
				}
				base.transform.Find("Window Manager/Close").GetComponent<ButtonManager>().onClick.AddListener(delegate
				{
					this.Entry();
					this.Close();
					int count = UnityEngine.Random.Range(0, 100);
					bool flag6 = MapManager.Instance.Level >= 24;
					if (flag6)
					{
						bool flag7 = !string.IsNullOrEmpty(GameSaveManager.GetValue<string>(GameVar.MapScene3));
						if (flag7)
						{
							GameApp.Instance.UpdateBack((SceneType)Enum.Parse(typeof(SceneType), GameSaveManager.GetValue<string>(GameVar.MapScene3)));
						}
						else
						{
							bool flag8 = count < 50;
							if (flag8)
							{
								GameSaveManager.SetValue(GameVar.MapScene3, SceneType.Chessboard.ToString());
								GameApp.Instance.UpdateBack(SceneType.Chessboard);
							}
							else
							{
								GameSaveManager.SetValue(GameVar.MapScene3, SceneType.Castle.ToString());
								GameApp.Instance.UpdateBack(SceneType.Castle);
							}
						}
					}
					else
					{
						bool flag9 = MapManager.Instance.Level >= 12;
						if (flag9)
						{
							bool flag10 = !string.IsNullOrEmpty(GameSaveManager.GetValue<string>(GameVar.MapScene2));
							if (flag10)
							{
								GameApp.Instance.UpdateBack((SceneType)Enum.Parse(typeof(SceneType), GameSaveManager.GetValue<string>(GameVar.MapScene2)));
							}
							else
							{
								GameSaveManager.SetValue(GameVar.MapScene2, SceneType.PuppetTheater.ToString());
								GameApp.Instance.UpdateBack(SceneType.PuppetTheater);
							}
						}
					}
				});
				base.transform.Find("Window Manager").localScale = Vector3.zero;
				base.transform.Find("Window Manager").DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
				this.ModeSetReward();
			}
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000A0790 File Offset: 0x0009E990
		private void $Rougamo_ModeSetReward()
		{
			MapManager.Instance.SetReward(this);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x000A07A0 File Offset: 0x0009E9A0
		private void $Rougamo_SetMoney(int count)
		{
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.item1, this.itemList);
			PointUse pointUse = obj.GetComponent<PointUse>();
			this.Money += count;
			obj.GetComponent<PointUse>().RewardType = "Money";
			string description = RoleTable.Instance.ReturnMoneyCal(count).ToString();
			pointUse.Init("Money".Localize("TopBarUI"), description, this.moneyIcon);
			obj.SetActive(true);
			obj.GetComponent<ButtonManager>().onClick.AddListener(delegate
			{
				RoleTable.Instance.Money += count;
				this.Money -= count;
				this.AnimationPlay(obj);
			});
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x000A0874 File Offset: 0x0009EA74
		private void $Rougamo_RandomSetRelic(List<Dictionary<string, string>> lists)
		{
			bool flag = lists.Count == 0;
			if (flag)
			{
				this.RandomSetCard();
			}
			else
			{
				lists = new RandomPool(lists, MapManager.Instance.NowDice).DrawByRarity(3);
				bool flag2 = lists.Count == 0;
				if (flag2)
				{
					this.RandomSetCard();
				}
				else
				{
					GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.item1, this.itemList);
					obj.SetActive(true);
					DataConfig dataConfig = new DataConfig(lists[0]["Id"], DataType.Relic);
					GameSaveAnalyser.Instance.TryPush(dataConfig.data["Name"], OperObj.Relics, OperType.RewardShow);
					obj.GetComponent<PointUse>().RewardType = "Relic";
					obj.GetComponent<PointUse>().Init(dataConfig);
					this.RelicRewardList.Add(dataConfig);
					obj.GetComponent<ButtonManager>().onClick.AddListener(delegate
					{
						GameSaveAnalyser.Instance.TryPush(dataConfig.data["Name"], OperObj.Relics, OperType.Select);
						this.RelicRewardList.Remove(dataConfig);
						bool flag3 = RoleTable.Instance.relicList.Count > 6;
						if (flag3)
						{
							RoleTable.Instance.WithoutArmedRelicList.Add(dataConfig);
						}
						else
						{
							RoleTable.Instance.relicList.Add(dataConfig);
						}
						this.AnimationPlay(obj);
					});
				}
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000A09A0 File Offset: 0x0009EBA0
		private void $Rougamo_RandomSetCard()
		{
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.item1, this.itemList);
			bool flag = this.blessingUI == null;
			if (flag)
			{
				this.blessingUI = UIManager.Instance.GetUI<BackpackUI>("BackpackUI").statusUI;
			}
			obj.SetActive(true);
			this.CardCount++;
			obj.GetComponent<PointUse>().RewardType = "Bless";
			obj.GetComponent<PointUse>().Init("Card".Localize("BattleRewardUI"), "Select a card".Localize("BattleRewardUI"), this.cardIcon);
			obj.GetComponent<ButtonManager>().onClick.AddListener(delegate
			{
				this.CardCount--;
				obj.GetComponent<ButtonManager>().Interactable(false);
				UnityEngine.Object.Destroy(obj);
				this.Hide();
				UIManager.Instance.ShowUI<CardChoiceUI>("CardChoiceUI", true);
			});
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x000A0A88 File Offset: 0x0009EC88
		private void $Rougamo_RandomAddBless()
		{
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.item1, this.itemList);
			bool flag = this.blessingUI == null;
			if (flag)
			{
				this.blessingUI = UIManager.Instance.GetUI<BackpackUI>("BackpackUI").statusUI;
			}
			obj.SetActive(true);
			obj.GetComponent<PointUse>().RewardType = "Bless";
			obj.GetComponent<PointUse>().Init("Bless".Localize("BattleRewardUI"), "Choose way".Localize("BattleRewardUI"), this.blessIcon);
			obj.GetComponent<ButtonManager>().onClick.AddListener(delegate
			{
				obj.GetComponent<ButtonManager>().Interactable(false);
				UnityEngine.Object.Destroy(obj);
				this.GenerBlessing();
			});
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000A0B60 File Offset: 0x0009ED60
		private void $Rougamo_GenerBlessing()
		{
			bool canget = true;
			base.transform.Find("Window Manager").gameObject.SetActive(false);
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load("UI/BlessChoice") as GameObject, base.transform);
			Transform Tran = obj.transform.Find("Window Manager/Windows/牌堆/Content/List View Custom/List");
			bool flag = !RoleTable.Instance.InHighTide;
			List<Tuple<List<DataConfig>, List<DataConfig>>> List1;
			if (flag)
			{
				List1 = this.blessingUI.GenerateThreeOptions();
			}
			else
			{
				List1 = this.blessingUI.GenerateHighOptions();
			}
			for (int i = 0; i < 3; i++)
			{
				int index = i;
				GameObject Thisobj = Tran.Find("Blessing" + (i + 1).ToString()).gameObject;
				GameObject Sample = Thisobj.transform.Find("BlessingList/SampleItem").gameObject;
				GameObject TextItem = Thisobj.transform.Find("BlessingList/TextItem").gameObject;
				GameObject NullItem = Thisobj.transform.Find("BlessingList/Null").gameObject;
				Sample.SetActive(true);
				TextItem.SetActive(true);
				NullItem.SetActive(true);
				PointUse p = Thisobj.GetComponent<PointUse>();
				p.RewardType = "Bless";
				List<string> keywords = new List<string>();
				KeywordDisplay keywordDisplay = Thisobj.GetComponent<KeywordDisplay>();
				for (int j = 0; j < List1[i].Item1.Count; j++)
				{
					GameSaveAnalyser.Instance.TryPush(List1[i].Item1[j].data["Name"], OperObj.Blessings, OperType.RewardShow);
					GameObject child = UnityEngine.Object.Instantiate<GameObject>(Sample, Sample.transform.parent);
					DataConfig cfg = List1[i].Item1[j];
					PointUse pointUse = p;
					pointUse.DesList = pointUse.DesList + cfg.Description() + "\n";
					List<string> kwItem = new List<string>();
					string descParsed = cfg.Description().Highlight(kwItem);
					child.transform.Find("text/text").GetComponent<TMP_Text>().text = cfg.data.Localize("Name") + ":" + descParsed;
					child.transform.Find("Icon/Icon").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(cfg.data["Icon"], true);
				}
				for (int k = 0; k < List1[i].Item2.Count - 1; k += 2)
				{
					GameSaveAnalyser.Instance.TryPush(List1[i].Item2[k].data["Name"], OperObj.Blessings, OperType.RewardShow);
					GameObject child2 = UnityEngine.Object.Instantiate<GameObject>(TextItem, TextItem.transform.parent);
					DataConfig c = List1[i].Item2[k];
					DataConfig c2 = List1[i].Item2[k + 1];
					PointUse pointUse2 = p;
					pointUse2.DesList = string.Concat(new string[]
					{
						pointUse2.DesList,
						c.Description(),
						"\n",
						c2.Description(),
						"\n"
					});
					List<string> kw = new List<string>();
					List<string> kw2 = new List<string>();
					child2.transform.Find("text/text").GetComponent<TMP_Text>().text = c.Description().Highlight(kw) + "    " + c2.Description().Highlight(kw2);
				}
				bool flag2 = List1[i].Item2.Count % 2 == 1;
				if (flag2)
				{
					GameSaveAnalyser instance = GameSaveAnalyser.Instance;
					List<DataConfig> item = List1[i].Item2;
					instance.TryPush(item[item.Count - 1].data["Name"], OperObj.Blessings, OperType.RewardShow);
					GameObject child3 = UnityEngine.Object.Instantiate<GameObject>(TextItem, TextItem.transform.parent);
					List<DataConfig> item2 = List1[i].Item2;
					DataConfig cfg2 = item2[item2.Count - 1];
					PointUse pointUse3 = p;
					pointUse3.DesList += cfg2.Description();
					List<string> kwOdd = new List<string>();
					child3.transform.Find("text/text").GetComponent<TMP_Text>().text = cfg2.Description().Highlight(kwOdd);
				}
				Sample.SetActive(false);
				TextItem.SetActive(false);
				NullItem.SetActive(false);
				keywordDisplay.title = "Destiny".Localize("BattleRewardUI");
				keywordDisplay.text = Singleton<TextTranslator>.Instance.Translate(p.DesList, keywords);
				keywordDisplay.keyWords = keywords;
				Thisobj.transform.Find("button").GetComponent<ButtonManager>().onClick.AddListener(delegate
				{
					bool flag3 = !canget;
					if (!flag3)
					{
						canget = false;
						foreach (DataConfig item3 in List1[index].Item1)
						{
							GameSaveAnalyser.Instance.TryPush(item3.data["Name"], OperObj.Blessings, OperType.Select);
							RoleTable.Instance.blessingConfigs.Add(item3);
						}
						foreach (DataConfig item4 in List1[index].Item2)
						{
							GameSaveAnalyser.Instance.TryPush(item4.data["Name"], OperObj.Blessings, OperType.Select);
							RoleTable.Instance.blessingConfigs.Add(item4);
						}
						this.transform.Find("Window Manager").gameObject.SetActive(true);
						this.AnimationPlay(obj);
						UnityEngine.Object.Destroy(obj, 5.1f);
					}
				});
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000A1105 File Offset: 0x0009F305
		private void $Rougamo_Entry()
		{
			MapManager.Instance.TryChange();
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000A1113 File Offset: 0x0009F313
		private void $Rougamo_AnimationPlay(GameObject obj)
		{
			UIManager.Instance.GetAnimationManage().AnimationPlay(obj);
		}

		// Token: 0x04001070 RID: 4208
		private WindowManager windowManager;

		// Token: 0x04001071 RID: 4209
		public Transform itemList;

		// Token: 0x04001072 RID: 4210
		public List<DataConfig> RelicRewardList = new List<DataConfig>();

		// Token: 0x04001073 RID: 4211
		public Sprite cardIcon;

		// Token: 0x04001074 RID: 4212
		public Sprite moneyIcon;

		// Token: 0x04001075 RID: 4213
		public Sprite blessIcon;

		// Token: 0x04001076 RID: 4214
		public Sprite relicIcon;

		// Token: 0x04001077 RID: 4215
		private int Money;

		// Token: 0x04001078 RID: 4216
		public int CardCount = 0;

		// Token: 0x04001079 RID: 4217
		public GameObject item1;

		// Token: 0x0400107A RID: 4218
		private StatusUI blessingUI;
	}
}

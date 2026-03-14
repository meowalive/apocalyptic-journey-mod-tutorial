using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Data.Save;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

namespace Witch.UI.Window
{
	// Token: 0x02000306 RID: 774
	public class GameExitUI : UIBase
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x000CBB90 File Offset: 0x000C9D90
		public GameRuntimeData gameRuntimeData
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(GameExitUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameExitUI.get_gameRuntimeData()).MethodHandle, typeof(GameExitUI).TypeHandle);
				methodContext.Arguments = new object[0];
				GameRuntimeData gameRuntimeData;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								gameRuntimeData = this.$Rougamo_get_gameRuntimeData();
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
								if (exceptionHandled)
								{
									gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = gameRuntimeData;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return gameRuntimeData;
			}
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x000CBCD0 File Offset: 0x000C9ED0
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
			methodContext.TargetType = typeof(GameExitUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameExitUI.Start()).MethodHandle, typeof(GameExitUI).TypeHandle);
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

		// Token: 0x0600183B RID: 6203 RVA: 0x000CBDCC File Offset: 0x000C9FCC
		[DebuggerStepThrough]
		public void NextShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameExitUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameExitUI.NextShow()).MethodHandle, typeof(GameExitUI).TypeHandle);
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
							this.$Rougamo_NextShow();
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

		// Token: 0x0600183C RID: 6204 RVA: 0x000CBEC8 File Offset: 0x000CA0C8
		[DebuggerStepThrough]
		public override void OnDestroy()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameExitUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameExitUI.OnDestroy()).MethodHandle, typeof(GameExitUI).TypeHandle);
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
							this.$Rougamo_OnDestroy();
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

		// Token: 0x0600183D RID: 6205 RVA: 0x000CBFC4 File Offset: 0x000CA1C4
		private void EvalutaeAnimation()
		{
			this.totalScoreVal = 0;
			int relicScoreVal = 0;
			foreach (DataConfig item in RoleTable.Instance.relicList)
			{
				relicScoreVal += (int)(350f * Mathf.Pow(2f, (float)int.Parse(item.data["Rarity"])));
			}
			foreach (DataConfig item2 in RoleTable.Instance.WithoutArmedRelicList)
			{
				relicScoreVal += (int)(100f * Mathf.Pow(2f, (float)int.Parse(item2.data["Rarity"])));
			}
			this.rewardDict["遗物"] = relicScoreVal;
			this.rewardDict["战斗"] = RoleTable.Instance.sumFeat;
			int blessingsScoreVal = 0;
			foreach (DataConfig item3 in RoleTable.Instance.blessingConfigs)
			{
				blessingsScoreVal += 60 * item3.data["Weight"].ToInt();
			}
			this.rewardDict["祝福"] = blessingsScoreVal;
			int cardScoreVal = 0;
			foreach (KeyValuePair<string, int> item4 in RoleTable.Instance.GetCardReward)
			{
				cardScoreVal += (int)(30f * Mathf.Pow(2f, (float)int.Parse(item4.Key))) * item4.Value;
			}
			this.rewardDict["卡牌"] = cardScoreVal;
			this.rewardDict["金币"] = Math.Min(RoleTable.Instance.Money / 2, 40000);
			bool flag = GameExitUI.loss;
			if (flag)
			{
				RoleTable.Instance.Money = 0;
			}
			int VarVal = 0;
			foreach (KeyValuePair<string, int> item5 in RoleTable.Instance.VarsMap)
			{
				VarVal += item5.Value * 20;
			}
			this.rewardDict["属性"] = VarVal;
			this.totalScoreVal = this.rewardDict.Values.Sum();
			int baseScore = this.totalScoreVal;
			this.rewardDict["关卡"] = Math.Max((int)(((RoleTable.Instance.isDead ? 0.75f : 1f) * ((float)MapManager.Instance.Level / 100f + 1f) - 1f) * (float)this.totalScoreVal), 0);
			this.totalScoreVal += this.rewardDict["关卡"];
			this.rewardDict["深渊"] = (int)(((1f + float.Parse(GameSaveManager.GetValue<string>("Difficulty")) / 5f) * (float)(1 + GameSaveManager.GetEXHard() / 100) - 1f) * (float)this.totalScoreVal);
			bool flag2 = GameSaveManager.GetValue<string>(GameVar.IsKing) == "True";
			if (flag2)
			{
				this.rewardDict["深渊"] = (int)((float)this.rewardDict["深渊"] * 1.5f);
			}
			this.totalScoreVal = this.rewardDict.Values.Sum();
			int totalExp = this.RewardCal(baseScore);
			this.TrueCount = this.RewardCal(this.totalScoreVal);
			this.ExExp = this.TrueCount - totalExp;
			this.AnimationShow(totalExp, 3f, base.destroyCancellationToken);
			this.gameRuntimeData.Level += (this.TrueCount + this.gameRuntimeData.Exp) / 100;
			this.gameRuntimeData.Exp = (this.TrueCount + this.gameRuntimeData.Exp) % 100;
			foreach (object obj in this.BaseTran)
			{
				Transform item6 = (Transform)obj;
				this.OneVarShow(item6);
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000CC4CC File Offset: 0x000CA6CC
		[DebuggerStepThrough]
		private void AnimationShow(int Exp, float delay, CancellationToken token)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameExitUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameExitUI.AnimationShow(int, float, CancellationToken)).MethodHandle, typeof(GameExitUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				Exp,
				delay,
				token
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
							Exp = 0;
						}
						else
						{
							Exp = (int)arguments[0];
						}
						if (arguments[1] == null)
						{
							delay = 0f;
						}
						else
						{
							delay = (float)arguments[1];
						}
						if (arguments[2] == null)
						{
							token = default(CancellationToken);
						}
						else
						{
							token = (CancellationToken)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_AnimationShow(Exp, delay, token);
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
								goto IL_155;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_155:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x000CC658 File Offset: 0x000CA858
		[DebuggerStepThrough]
		private UniTask AnimateFillAmount(SpriteRenderer sr, float duration, CancellationToken token)
		{
			GameExitUI.<AnimateFillAmount>d__20 <AnimateFillAmount>d__ = new GameExitUI.<AnimateFillAmount>d__20();
			<AnimateFillAmount>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AnimateFillAmount>d__.<>4__this = this;
			<AnimateFillAmount>d__.sr = sr;
			<AnimateFillAmount>d__.duration = duration;
			<AnimateFillAmount>d__.token = token;
			<AnimateFillAmount>d__.<>1__state = -1;
			<AnimateFillAmount>d__.<>t__builder.Start<GameExitUI.<AnimateFillAmount>d__20>(ref <AnimateFillAmount>d__);
			return <AnimateFillAmount>d__.<>t__builder.Task;
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x000CC6B4 File Offset: 0x000CA8B4
		[DebuggerStepThrough]
		private void OneVarShow(Transform trans)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameExitUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameExitUI.OneVarShow(Transform)).MethodHandle, typeof(GameExitUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				trans
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
							trans = null;
						}
						else
						{
							trans = (Transform)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_OneVarShow(trans);
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

		// Token: 0x06001841 RID: 6209 RVA: 0x000CC7E8 File Offset: 0x000CA9E8
		[DebuggerStepThrough]
		private int RewardCal(int value)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameExitUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameExitUI.RewardCal(int)).MethodHandle, typeof(GameExitUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value
			};
			int num;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					num = (int)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							value = 0;
						}
						else
						{
							value = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							num = this.$Rougamo_RewardCal(value);
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
							if (exceptionHandled)
							{
								num = (int)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_148;
							}
							throw;
						}
						methodContext.ReturnValue = num;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						num = (int)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_148:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x000CC968 File Offset: 0x000CAB68
		[DebuggerStepThrough]
		public void ReturnAsync()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameExitUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameExitUI.ReturnAsync()).MethodHandle, typeof(GameExitUI).TypeHandle);
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
							this.$Rougamo_ReturnAsync();
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

		// Token: 0x06001847 RID: 6215 RVA: 0x0001CB6E File Offset: 0x0001AD6E
		private GameRuntimeData $Rougamo_get_gameRuntimeData()
		{
			return Singleton<GameRuntimeData>.Instance;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x000CCB18 File Offset: 0x000CAD18
		private void $Rougamo_Start()
		{
			bool flag = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").Close();
			}
			ResourceLoader.Load<Material>("Material/PostProcess/ScreenLight", true).SetInt("_Enabled", 0);
			this.originExp = this.gameRuntimeData.Exp;
			this.originLevel = this.gameRuntimeData.Level;
			this.sr.material.SetFloat("_FillAmount", (float)this.originExp / 100f);
			this.ExpLevel.text = this.originLevel.ToString();
			this.BlackMask.DOFade(1f, 1f).OnComplete(delegate
			{
				UnityEngine.Object.Destroy(GameApp.Instance.NowBackground);
			});
			this.BlackMask.DOFade(0f, 1f).OnComplete(delegate
			{
				this.EvalutaeAnimation();
				this.BlackMask.gameObject.SetActive(false);
			}).OnStart(delegate
			{
				this.MainContent.gameObject.SetActive(true);
			}).SetDelay(1f);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000CCC50 File Offset: 0x000CAE50
		private void $Rougamo_NextShow()
		{
			bool flag = this.firstClicek;
			if (flag)
			{
				this.firstClicek = false;
				this.AnimationShow(this.ExExp, 4.7f, base.destroyCancellationToken);
				(this.BaseTran as RectTransform).DOAnchorPosY(780f, 1f, false);
				(this.MulTran as RectTransform).DOAnchorPosY(180f, 1f, false).OnComplete(delegate
				{
					foreach (object obj in this.MulTran)
					{
						Transform item = (Transform)obj;
						this.OneVarShow(item);
					}
				});
			}
			else
			{
				this.ReturnAsync();
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000CCCE0 File Offset: 0x000CAEE0
		private void $Rougamo_OnDestroy()
		{
			base.OnDestroy();
			bool isServer = PlayerManager.Instance.isServer;
			if (isServer)
			{
				bool flag = GameServer.Instance != null;
				if (flag)
				{
					GameServer.Instance.EndGame();
					GameApp.Instance.ReturnToMenu();
					bool flag2 = GameServer.Instance != null;
					if (flag2)
					{
						GameServer.Instance.LobbyInfo.AddedPlayers.Clear();
					}
				}
			}
			SafeBoxUI.SafeboxSave();
			this.gameRuntimeData.playCount++;
			GameExitUI.loss = false;
			this.gameRuntimeData.Save();
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000CCD80 File Offset: 0x000CAF80
		private void $Rougamo_AnimationShow(int Exp, float delay, CancellationToken token)
		{
			GameExitUI.<AnimationShow>d__19 <AnimationShow>d__ = new GameExitUI.<AnimationShow>d__19();
			<AnimationShow>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<AnimationShow>d__.<>4__this = this;
			<AnimationShow>d__.Exp = Exp;
			<AnimationShow>d__.delay = delay;
			<AnimationShow>d__.token = token;
			<AnimationShow>d__.<>1__state = -1;
			<AnimationShow>d__.<>t__builder.Start<GameExitUI.<AnimationShow>d__19>(ref <AnimationShow>d__);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000CCDD0 File Offset: 0x000CAFD0
		private UniTask $Rougamo_AnimateFillAmount(SpriteRenderer sr, float duration, CancellationToken token)
		{
			GameExitUI.<$Rougamo_AnimateFillAmount>d__19 <$Rougamo_AnimateFillAmount>d__ = new GameExitUI.<$Rougamo_AnimateFillAmount>d__19();
			<$Rougamo_AnimateFillAmount>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<$Rougamo_AnimateFillAmount>d__.<>4__this = this;
			<$Rougamo_AnimateFillAmount>d__.sr = sr;
			<$Rougamo_AnimateFillAmount>d__.duration = duration;
			<$Rougamo_AnimateFillAmount>d__.token = token;
			<$Rougamo_AnimateFillAmount>d__.<>1__state = -1;
			<$Rougamo_AnimateFillAmount>d__.<>t__builder.Start<GameExitUI.<$Rougamo_AnimateFillAmount>d__19>(ref <$Rougamo_AnimateFillAmount>d__);
			return <$Rougamo_AnimateFillAmount>d__.<>t__builder.Task;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x000CCE2C File Offset: 0x000CB02C
		private void $Rougamo_OneVarShow(Transform trans)
		{
			TMP_Text tempText = trans.Find("Val").GetComponent<TMP_Text>();
			float val = (float)this.rewardDict[trans.name];
			trans.Find("粒子-汇聚").gameObject.SetActive(true);
			tempText.text = "0";
			DOTween.To(delegate(float value)
			{
				tempText.text = ((int)value).ToString();
			}, 0f, val, 3f).SetEase(Ease.OutSine).OnComplete(delegate
			{
				trans.Find("粒子-汇聚").GetComponent<VisualEffect>().SetBool("Loop", false);
				trans.Find("粒子-汇聚").GetComponent<VisualEffect>().SetBool("开始汇聚", true);
			});
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x000CCEDC File Offset: 0x000CB0DC
		private int $Rougamo_RewardCal(int value)
		{
			int reward = 0;
			bool flag = value > 0;
			if (flag)
			{
				reward += Math.Min(value / 150, 30);
			}
			else
			{
				reward = 0;
			}
			value -= 4500;
			bool flag2 = value > 0;
			if (flag2)
			{
				reward += Math.Min(value / 300, 30);
			}
			value -= 9000;
			bool flag3 = value > 0;
			if (flag3)
			{
				reward += value / 500;
			}
			return Math.Min(reward, 500);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x000CCF64 File Offset: 0x000CB164
		private void $Rougamo_ReturnAsync()
		{
			bool flag = this.hasClosed;
			if (!flag)
			{
				this.hasClosed = true;
				Singleton<GameRuntimeData>.Instance.Money += Math.Min(RoleTable.Instance.Money, 1000);
				Singleton<GameRuntimeData>.Instance.Truth += this.TrueCount;
				GameApp.Instance.ReturnToMenu();
				this.Close();
			}
		}

		// Token: 0x040012EA RID: 4842
		public static bool loss;

		// Token: 0x040012EB RID: 4843
		[Tooltip("黑色背景")]
		public Image BlackMask;

		// Token: 0x040012EC RID: 4844
		[Tooltip("主内容")]
		public Transform MainContent;

		// Token: 0x040012ED RID: 4845
		public SpriteRenderer sr;

		// Token: 0x040012EE RID: 4846
		public TMP_Text ExpLevel;

		// Token: 0x040012EF RID: 4847
		private bool firstClicek = true;

		// Token: 0x040012F0 RID: 4848
		private int originExp;

		// Token: 0x040012F1 RID: 4849
		private int originLevel;

		// Token: 0x040012F2 RID: 4850
		private int ExExp;

		// Token: 0x040012F3 RID: 4851
		private int totalScoreVal;

		// Token: 0x040012F4 RID: 4852
		private Dictionary<string, int> rewardDict = new Dictionary<string, int>();

		// Token: 0x040012F5 RID: 4853
		public Transform BaseTran;

		// Token: 0x040012F6 RID: 4854
		public Transform MulTran;

		// Token: 0x040012F7 RID: 4855
		private bool hasClosed = false;

		// Token: 0x040012F8 RID: 4856
		public int TrueCount;
	}
}

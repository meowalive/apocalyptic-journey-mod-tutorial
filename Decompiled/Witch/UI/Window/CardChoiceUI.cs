using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x020002A2 RID: 674
	public class CardChoiceUI : UIBase
	{
		// Token: 0x06001545 RID: 5445 RVA: 0x000A8FAC File Offset: 0x000A71AC
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
			methodContext.TargetType = typeof(CardChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardChoiceUI.Start()).MethodHandle, typeof(CardChoiceUI).TypeHandle);
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

		// Token: 0x06001546 RID: 5446 RVA: 0x000A90A8 File Offset: 0x000A72A8
		[DebuggerStepThrough]
		public void Select(GameObject obj, DataConfig dataConfig)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardChoiceUI.Select(GameObject, DataConfig)).MethodHandle, typeof(CardChoiceUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				obj,
				dataConfig
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
						if (arguments[1] == null)
						{
							dataConfig = null;
						}
						else
						{
							dataConfig = (DataConfig)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Select(obj, dataConfig);
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
								goto IL_11D;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_11D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000A91FC File Offset: 0x000A73FC
		[DebuggerStepThrough]
		public override void Close()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardChoiceUI.Close()).MethodHandle, typeof(CardChoiceUI).TypeHandle);
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
							this.$Rougamo_Close();
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

		// Token: 0x0600154A RID: 5450 RVA: 0x000A934C File Offset: 0x000A754C
		private void $Rougamo_Start()
		{
			base.FadeIn();
			this.Item1 = base.transform.Find("Content/Item1").gameObject;
			this.Item2 = base.transform.Find("Content/Item2").gameObject;
			this.Item3 = base.transform.Find("Content/Item3").gameObject;
			this.Item1.GetComponent<CardChoiceItem>().FadeIn(0.5f);
			this.Item2.GetComponent<CardChoiceItem>().FadeIn(0.5f);
			this.Item3.GetComponent<CardChoiceItem>().FadeIn(0.5f);
			List<Dictionary<string, string>> cards = Singleton<GameConfigManager>.Instance.GetTable(DataType.Card).Getlines();
			cards = new RandomPool((from x in cards.AsValueEnumerable<Dictionary<string, string>>()
			where x["Type"] != "诅咒" && !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"])
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), MapManager.Instance.NowDice).DrawByRarity(3);
			this.Item1.GetComponent<CardChoiceItem>().Initialize(this, cards[0]["Id"]);
			this.Item2.GetComponent<CardChoiceItem>().Initialize(this, cards[1]["Id"]);
			this.Item3.GetComponent<CardChoiceItem>().Initialize(this, cards[2]["Id"]);
			UIManager.Instance.GetUI<TopBarUI>("TopBarUI").transform.SetAsLastSibling();
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000A94D0 File Offset: 0x000A76D0
		private void $Rougamo_Select(GameObject obj, DataConfig dataConfig)
		{
			bool flag = this.isSelected;
			if (!flag)
			{
				this.isSelected = true;
				RoleTable.Instance.UnCardList.Add(dataConfig);
				bool flag2 = obj == null;
				if (flag2)
				{
					Debug.LogError("CardChoiceUI: Select called with null object.");
				}
				else
				{
					base.transform.Find("Button").gameObject.SetActive(false);
					bool flag3 = this.Item1 != obj;
					if (flag3)
					{
						this.Item1.GetComponent<CardChoiceItem>().FadeOut(0f);
					}
					bool flag4 = this.Item2 != obj;
					if (flag4)
					{
						this.Item2.GetComponent<CardChoiceItem>().FadeOut(0f);
					}
					bool flag5 = this.Item3 != obj;
					if (flag5)
					{
						this.Item3.GetComponent<CardChoiceItem>().FadeOut(0f);
					}
					obj.GetComponent<CardChoiceItem>().MoveToDeck();
					bool flag6 = !Singleton<GameRuntimeData>.Instance.TutorialData.ContainsKey("GetNewCard");
					if (flag6)
					{
						Singleton<GameRuntimeData>.Instance.TutorialData["GetNewCard"] = "1";
						UIManager.Instance.ShowNotification("GetNewItem".Localize("Tips"), string.Concat(new string[]
						{
							"NewRelic".Localize("Tips"),
							"<color=#",
							ColorUtility.ToHtmlStringRGBA(Singleton<TempDataManager>.Instance.rareColorMap[dataConfig.data["Rarity"]]),
							">",
							dataConfig.data.Localize("Name"),
							"</color>.",
							"Card Need Equip".Localize("BackpackUI")
						}), 2f);
					}
					UniTask.WaitForSeconds(1.75f, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
					{
						CardChoiceUI.<<Select>b__5_0>d <<Select>b__5_0>d = new CardChoiceUI.<<Select>b__5_0>d();
						<<Select>b__5_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<Select>b__5_0>d.<>4__this = this;
						<<Select>b__5_0>d.<>1__state = -1;
						<<Select>b__5_0>d.<>t__builder.Start<CardChoiceUI.<<Select>b__5_0>d>(ref <<Select>b__5_0>d);
						return <<Select>b__5_0>d.<>t__builder.Task;
					}).Forget();
				}
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000A96C9 File Offset: 0x000A78C9
		private void $Rougamo_Close()
		{
			base.Close();
			UIManager.Instance.ShowUI<BattleRewardsUI>("BattleRewardsUI", true);
		}

		// Token: 0x040010E2 RID: 4322
		private GameObject Item1;

		// Token: 0x040010E3 RID: 4323
		private GameObject Item2;

		// Token: 0x040010E4 RID: 4324
		private GameObject Item3;

		// Token: 0x040010E5 RID: 4325
		private bool isSelected = false;
	}
}

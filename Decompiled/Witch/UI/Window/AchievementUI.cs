using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200028B RID: 651
	public class AchievementUI : UIBase
	{
		// Token: 0x06001486 RID: 5254 RVA: 0x000A1454 File Offset: 0x0009F654
		private void Awake()
		{
			this.achievements.Init();
			this.achievements.CountCalculate();
			this.achievementCount = base.transform.Find("Window Manager/progress/ValTxt").GetComponent<TextMeshProUGUI>();
			base.Register("Window Manager/Close").onClick = delegate(GameObject obj, PointerEventData pData)
			{
				this.Close();
			};
			using (Dictionary<string, List<AchievementBase>>.KeyCollection.Enumerator enumerator = this.achievements.table.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					AchievementUI.<>c__DisplayClass5_0 CS$<>8__locals1 = new AchievementUI.<>c__DisplayClass5_0();
					CS$<>8__locals1.<>4__this = this;
					CS$<>8__locals1.type = enumerator.Current;
					this.achievements.SortByStatus(CS$<>8__locals1.type);
					Transform viewContent = base.transform.Find("Window Manager/Windows/" + CS$<>8__locals1.type + "/Content/List View Custom/Scroll Area/List");
					base.transform.Find("Window Manager/Buttons/" + CS$<>8__locals1.type).GetComponent<ButtonManager>().onClick.AddListener(delegate
					{
						CS$<>8__locals1.<>4__this.SelectWindow(CS$<>8__locals1.type);
					});
					using (List<AchievementBase>.Enumerator enumerator2 = this.achievements.table[CS$<>8__locals1.type].GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							AchievementUI.<>c__DisplayClass5_1 CS$<>8__locals2 = new AchievementUI.<>c__DisplayClass5_1();
							CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
							CS$<>8__locals2.achievement = enumerator2.Current;
							Transform item = UnityEngine.Object.Instantiate<Transform>(viewContent.Find("Item"), viewContent);
							item.Find("texts/title").GetComponent<TextMeshProUGUI>().text = CS$<>8__locals2.achievement.info.name;
							item.Find("texts/description").GetComponent<TextMeshProUGUI>().text = CS$<>8__locals2.achievement.info.description;
							item.Find("texts/tip").GetComponent<TextMeshProUGUI>().text = CS$<>8__locals2.achievement.info.tip;
							item.Find("Icon").GetComponent<Image>().color = AchievementUI.levelColor[CS$<>8__locals2.achievement.info.level];
							item.Find("status/text").GetComponent<TextMeshProUGUI>().text = AchievementUI.statusMap[CS$<>8__locals2.achievement.info.status];
							item.Find("status/Button").GetComponent<ButtonManager>().onClick.AddListener(delegate
							{
								CS$<>8__locals2.CS$<>8__locals1.<>4__this.achievements.SetAchievementStatus(CS$<>8__locals2.CS$<>8__locals1.type, CS$<>8__locals2.achievement.info.name, "2");
								item.transform.Find("status/text").GetComponent<TextMeshProUGUI>().text = "已领取";
								item.transform.Find("status/text").gameObject.SetActive(true);
								item.transform.Find("status/Button").gameObject.SetActive(false);
								CS$<>8__locals2.CS$<>8__locals1.<>4__this.UpdateCount(CS$<>8__locals2.CS$<>8__locals1.type);
							});
							bool flag = CS$<>8__locals2.achievement.info.status == "0";
							if (flag)
							{
								item.Find("status/text").gameObject.SetActive(false);
								item.Find("status/Button").gameObject.SetActive(true);
							}
							else
							{
								item.Find("status/text").gameObject.SetActive(true);
								item.Find("status/Button").gameObject.SetActive(false);
							}
							item.name = CS$<>8__locals2.achievement.info.name;
							item.gameObject.SetActive(true);
						}
					}
				}
			}
			this.SelectWindow("剧情");
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x000A1848 File Offset: 0x0009FA48
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
			methodContext.TargetType = typeof(AchievementUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AchievementUI.Close()).MethodHandle, typeof(AchievementUI).TypeHandle);
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

		// Token: 0x06001488 RID: 5256 RVA: 0x000A1944 File Offset: 0x0009FB44
		[DebuggerStepThrough]
		public void SelectWindow(string type)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(AchievementUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AchievementUI.SelectWindow(string)).MethodHandle, typeof(AchievementUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				type
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
							type = null;
						}
						else
						{
							type = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SelectWindow(type);
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

		// Token: 0x06001489 RID: 5257 RVA: 0x000A1A78 File Offset: 0x0009FC78
		[DebuggerStepThrough]
		public void UpdateCount(string type)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(AchievementUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AchievementUI.UpdateCount(string)).MethodHandle, typeof(AchievementUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				type
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
							type = null;
						}
						else
						{
							type = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_UpdateCount(type);
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

		// Token: 0x0600148E RID: 5262 RVA: 0x000A1CE1 File Offset: 0x0009FEE1
		private void $Rougamo_Close()
		{
			base.transform.Find("Window Manager").DOScale(Vector3.zero, 0.2f).SetEase(Ease.InBack).OnComplete(delegate
			{
				base.Close();
			});
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x000A1D1C File Offset: 0x0009FF1C
		private void $Rougamo_SelectWindow(string type)
		{
			this.UpdateCount(type);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000A1D28 File Offset: 0x0009FF28
		private void $Rougamo_UpdateCount(string type)
		{
			this.tween.Kill(false);
			this.achievementCount.text = "";
			this.tween = this.achievementCount.DOText(this.achievements.count[type].ToString() + "/" + this.achievements.table[type].Count.ToString(), 0.5f, true, ScrambleMode.None, null);
		}

		// Token: 0x0400108B RID: 4235
		public static Dictionary<string, Color> levelColor = new Dictionary<string, Color>
		{
			{
				"铜",
				new Color(0.8f, 0.5f, 0.2f)
			},
			{
				"银",
				new Color(0.8f, 0.8f, 0.8f)
			},
			{
				"金",
				new Color(1f, 0.8f, 0f)
			},
			{
				"钻",
				new Color(0.5f, 0.8f, 1f)
			},
			{
				"王",
				new Color(1f, 0.5f, 0.5f)
			}
		};

		// Token: 0x0400108C RID: 4236
		public static Dictionary<string, string> statusMap = new Dictionary<string, string>
		{
			{
				"0",
				"已完成"
			},
			{
				"1",
				"未完成"
			},
			{
				"2",
				"已领取"
			},
			{
				"3",
				"未解锁"
			}
		};

		// Token: 0x0400108D RID: 4237
		private AchivementTable achievements = Singleton<GameRuntimeData>.Instance.achivementTable;

		// Token: 0x0400108E RID: 4238
		private TextMeshProUGUI achievementCount;

		// Token: 0x0400108F RID: 4239
		private Tween tween;
	}
}

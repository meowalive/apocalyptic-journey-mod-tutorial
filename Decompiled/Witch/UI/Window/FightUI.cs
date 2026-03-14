using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Data.Save;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Fight.ActionCommand;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.VFX;
using ZLinq;

namespace Witch.UI.Window
{
	// Token: 0x020002E1 RID: 737
	public class FightUI : UIBase
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x000BBE7C File Offset: 0x000BA07C
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x000BBFC0 File Offset: 0x000BA1C0
		public int CardTopCount
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
				methodContext.TargetType = typeof(FightUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.get_CardTopCount()).MethodHandle, typeof(FightUI).TypeHandle);
				methodContext.Arguments = new object[0];
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
						do
						{
							try
							{
								num = this.$Rougamo_get_CardTopCount();
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
									goto IL_10D;
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
						IL_10D:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return num;
			}
			[DebuggerStepThrough]
			set
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(FightUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.set_CardTopCount(int)).MethodHandle, typeof(FightUI).TypeHandle);
				methodContext.Arguments = new object[]
				{
					value
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
								this.$Rougamo_set_CardTopCount(value);
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
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000BC0FC File Offset: 0x000BA2FC
		public override void OnDestroy()
		{
			FightUI.InIEn = false;
			Singleton<EventCenter>.Instance.Clear(this);
			bool flag = FightUI.cardItemList != null;
			if (flag)
			{
				List<CardItem> tempList = new List<CardItem>(FightUI.cardItemList);
				foreach (CardItem item in tempList)
				{
					bool flag2 = item == null || item.gameObject == null;
					if (!flag2)
					{
						UnityEngine.Object.Destroy(item.gameObject);
					}
				}
			}
			List<CardItem> list = FightUI.cardItemList;
			if (list != null)
			{
				list.Clear();
			}
			List<SkillItem> list2 = this.skillItems;
			if (list2 != null)
			{
				list2.Clear();
			}
			List<CardItem> selectedCard = FightUI.SelectedCard;
			if (selectedCard != null)
			{
				selectedCard.Clear();
			}
			foreach (KeyValuePair<StatusManager, ValueTuple<PopUpTextUI, float>> item2 in this.totalDamageText)
			{
				bool flag3 = item2.Value.Item1 == null || item2.Value.Item1.gameObject == null;
				if (!flag3)
				{
					UnityEngine.Object.Destroy(item2.Value.Item1.gameObject);
				}
			}
			foreach (StatusManager item3 in this.StatusList)
			{
				bool flag4 = item3 == null;
				if (!flag4)
				{
					bool flag5 = item3.gameObject != null;
					if (flag5)
					{
						UnityEngine.Object.Destroy(item3.gameObject);
					}
				}
			}
			this.totalDamageText.Clear();
			this.activeDamagePopupTimes.Clear();
			UIManager.Instance.CloseUI("DeckUI");
			bool flag6 = this.chest != null;
			if (flag6)
			{
				UnityEngine.Object.Destroy(this.chest);
			}
			UIManager.Instance.HideUI("LineUI");
			Material material = Resources.Load<Material>("Material/PostProcess/Blur");
			if (material != null)
			{
				material.DisableKeyword("_BLUR_ON");
			}
			Camera.main.transform.position = new Vector3(0f, 0f, -5f);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x000BC370 File Offset: 0x000BA570
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
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.Close()).MethodHandle, typeof(FightUI).TypeHandle);
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

		// Token: 0x060016F4 RID: 5876 RVA: 0x000BC46C File Offset: 0x000BA66C
		[DebuggerStepThrough]
		public void EnqueueDamageText(string text, Vector3 position, string popUpType1, StatusManager status, StatusManager to, string realDamage)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.EnqueueDamageText(string, Vector3, string, StatusManager, StatusManager, string)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				text,
				position,
				popUpType1,
				status,
				to,
				realDamage
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
							text = null;
						}
						else
						{
							text = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							position = default(Vector3);
						}
						else
						{
							position = (Vector3)arguments[1];
						}
						if (arguments[2] == null)
						{
							popUpType1 = null;
						}
						else
						{
							popUpType1 = (string)arguments[2];
						}
						if (arguments[3] == null)
						{
							status = null;
						}
						else
						{
							status = (StatusManager)arguments[3];
						}
						if (arguments[4] == null)
						{
							to = null;
						}
						else
						{
							to = (StatusManager)arguments[4];
						}
						if (arguments[5] == null)
						{
							realDamage = null;
						}
						else
						{
							realDamage = (string)arguments[5];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_EnqueueDamageText(text, position, popUpType1, status, to, realDamage);
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
								goto IL_1AE;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_1AE:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x000BC668 File Offset: 0x000BA868
		[DebuggerStepThrough]
		public void StartClock()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.StartClock()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_StartClock();
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

		// Token: 0x060016F6 RID: 5878 RVA: 0x000BC764 File Offset: 0x000BA964
		[DebuggerStepThrough]
		public void StopClock()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.StopClock()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_StopClock();
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

		// Token: 0x060016F7 RID: 5879 RVA: 0x000BC860 File Offset: 0x000BAA60
		[DebuggerStepThrough]
		private void SetClockName(string name)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.SetClockName(string)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				name
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
							name = null;
						}
						else
						{
							name = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetClockName(name);
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

		// Token: 0x060016F8 RID: 5880 RVA: 0x000BC994 File Offset: 0x000BAB94
		[DebuggerStepThrough]
		private void DoTurnAnimation(float movement, float duration = 0.5f)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.DoTurnAnimation(float, float)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				movement,
				duration
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
							movement = 0f;
						}
						else
						{
							movement = (float)arguments[0];
						}
						if (arguments[1] == null)
						{
							duration = 0f;
						}
						else
						{
							duration = (float)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_DoTurnAnimation(movement, duration);
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
								goto IL_12D;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_12D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x000BCAF8 File Offset: 0x000BACF8
		[DebuggerStepThrough]
		public void SetTurn(FightObject obj, int index, int count)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.SetTurn(FightObject, int, int)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				obj,
				index,
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
							obj = null;
						}
						else
						{
							obj = (FightObject)arguments[0];
						}
						if (arguments[1] == null)
						{
							index = 0;
						}
						else
						{
							index = (int)arguments[1];
						}
						if (arguments[2] == null)
						{
							count = 0;
						}
						else
						{
							count = (int)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetTurn(obj, index, count);
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
								goto IL_14D;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_14D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000BCC7C File Offset: 0x000BAE7C
		[DebuggerStepThrough]
		public void ShowChest()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.ShowChest()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_ShowChest();
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

		// Token: 0x060016FB RID: 5883 RVA: 0x000BCD78 File Offset: 0x000BAF78
		private IEnumerator SetTime()
		{
			for (;;)
			{
				bool flag = GameEntryUI.playerCount == 1 && UIManager.Instance.GetUI<SettingUI>("SettingUI").gameObject.activeSelf;
				if (flag)
				{
					base.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
					yield return UniTask.WaitForSeconds(0.2f, false, PlayerLoopTiming.Update, default(CancellationToken), false);
				}
				else
				{
					this.hasTime--;
					base.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
					this.process.Find("Bar/Outer").GetComponent<Image>().fillAmount = (float)this.hasTime / 60f;
					this.process.Find("Bar/Text").GetComponent<TMP_Text>().text = this.hasTime.ToString() + "s";
					bool flag2 = this.isWin;
					if (flag2)
					{
						break;
					}
					bool flag3 = this.hasTime == 0;
					if (flag3)
					{
						goto Block_4;
					}
				}
				yield return FightUI._waitForSeconds1;
			}
			yield break;
			Block_4:
			this.onChangeTurnBtn();
			yield break;
			yield break;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x000BCD88 File Offset: 0x000BAF88
		[DebuggerStepThrough]
		private void Update()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.Update()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_Update();
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

		// Token: 0x060016FD RID: 5885 RVA: 0x000BCE84 File Offset: 0x000BB084
		public void AutoUseCard()
		{
			bool flag = this.autoCard;
			if (flag)
			{
				foreach (CardItem card in FightUI.cardItemList)
				{
					CommonCardItem common;
					bool flag2;
					if (card != null && !card.hasUse)
					{
						common = (card as CommonCardItem);
						flag2 = (common != null);
					}
					else
					{
						flag2 = false;
					}
					bool flag3 = flag2;
					if (flag3)
					{
						common.UseCardDirectly();
						break;
					}
				}
				bool flag4 = FightUI.cardItemList.Count<CardItem>() == 0;
				if (flag4)
				{
					this.CreateCardItem(10);
				}
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x000BCF30 File Offset: 0x000BB130
		[DebuggerStepThrough]
		private void UpdateCardKeyboardShortcut()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.UpdateCardKeyboardShortcut()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_UpdateCardKeyboardShortcut();
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

		/// <summary>
		/// 显示总伤害。伤害过多时，同目标合并为一次跳字。
		/// </summary>
		// Token: 0x060016FF RID: 5887 RVA: 0x000BD02C File Offset: 0x000BB22C
		[DebuggerStepThrough]
		private void ShowDamageText()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.ShowDamageText()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_ShowDamageText();
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

		// Token: 0x06001700 RID: 5888 RVA: 0x000BD128 File Offset: 0x000BB328
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
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.Awake()).MethodHandle, typeof(FightUI).TypeHandle);
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

		// Token: 0x06001701 RID: 5889 RVA: 0x000BD224 File Offset: 0x000BB424
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
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.Start()).MethodHandle, typeof(FightUI).TypeHandle);
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

		// Token: 0x06001702 RID: 5890 RVA: 0x000BD320 File Offset: 0x000BB520
		[DebuggerStepThrough]
		public void ShowTitle()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.ShowTitle()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_ShowTitle();
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

		// Token: 0x06001703 RID: 5891 RVA: 0x000BD41C File Offset: 0x000BB61C
		[DebuggerStepThrough]
		public void Init()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.Init()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_Init();
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

		// Token: 0x06001704 RID: 5892 RVA: 0x000BD518 File Offset: 0x000BB718
		[DebuggerStepThrough]
		public void InitSkill()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.InitSkill()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_InitSkill();
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

		// Token: 0x06001705 RID: 5893 RVA: 0x000BD614 File Offset: 0x000BB814
		[DebuggerStepThrough]
		public void CreateSkillItem(Transform tempItem, int index)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.CreateSkillItem(Transform, int)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				tempItem,
				index
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
							tempItem = null;
						}
						else
						{
							tempItem = (Transform)arguments[0];
						}
						if (arguments[1] == null)
						{
							index = 0;
						}
						else
						{
							index = (int)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateSkillItem(tempItem, index);
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
								goto IL_125;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_125:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000BD770 File Offset: 0x000BB970
		public void UpdateSkill()
		{
			foreach (SkillItem item in this.skillItems)
			{
				item.UpdateSkillTime();
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000BD7C8 File Offset: 0x000BB9C8
		[DebuggerStepThrough]
		public void CreateDeckMenu()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.CreateDeckMenu()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_CreateDeckMenu();
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

		// Token: 0x06001708 RID: 5896 RVA: 0x000BD8C4 File Offset: 0x000BBAC4
		[DebuggerStepThrough]
		public void CreateUsedCardList()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.CreateUsedCardList()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_CreateUsedCardList();
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

		// Token: 0x06001709 RID: 5897 RVA: 0x000BD9C0 File Offset: 0x000BBBC0
		[DebuggerStepThrough]
		public void UpdatePower()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.UpdatePower()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_UpdatePower();
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

		// Token: 0x0600170A RID: 5898 RVA: 0x000BDABC File Offset: 0x000BBCBC
		[DebuggerStepThrough]
		public void FightAgainBtn()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.FightAgainBtn()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_FightAgainBtn();
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

		// Token: 0x0600170B RID: 5899 RVA: 0x000BDBB8 File Offset: 0x000BBDB8
		public void Reset()
		{
			base.StopAllCoroutines();
			UIManager.Instance.CloseUI("DeckUI");
			Singleton<EventCenter>.Instance.Clear(new EventDispose[]
			{
				EventDispose.OnFightEnd,
				EventDispose.OnTrigger
			});
			foreach (KeyValuePair<string, StatusManager> role in FightManager.Instance.statuses)
			{
				bool flag = role.Value != null && role.Value.gameObject != null;
				if (flag)
				{
					UnityEngine.Object.DestroyImmediate(role.Value.gameObject);
				}
			}
			foreach (CardItem item in FightUI.cardItemList)
			{
				bool flag2 = item != null && item.gameObject != null;
				if (flag2)
				{
					UnityEngine.Object.DestroyImmediate(item.gameObject);
				}
			}
			FightUI.cardItemList.Clear();
			this.skillItems.Clear();
			foreach (CardItem item2 in FightUI.SelectedCard)
			{
				bool flag3 = item2 != null && item2.gameObject != null;
				if (flag3)
				{
					UnityEngine.Object.DestroyImmediate(item2.gameObject);
				}
			}
			bool inIEn = FightUI.InIEn;
			if (inIEn)
			{
				FightUI.InIEn = false;
				base.StopAllCoroutines();
				bool flag4 = this.instance != null;
				if (flag4)
				{
					UnityEngine.Object.DestroyImmediate(this.instance);
				}
			}
			FightManager.Instance.statuses.Clear();
			RoleTable.Instance.isDead = false;
			FightManager.Instance.ActionQueue.Clear();
			FightUI.SpecialCount = 0;
			this.Init();
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000BDDE0 File Offset: 0x000BBFE0
		[DebuggerStepThrough]
		public void onChangeTurnBtn()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.onChangeTurnBtn()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_onChangeTurnBtn();
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

		// Token: 0x0600170D RID: 5901 RVA: 0x000BDEDC File Offset: 0x000BC0DC
		private IEnumerator TurnBtn()
		{
			CardItem.canUse = false;
			yield return new WaitForSeconds(0.5f);
			while (FightUI.InIEn || this.createCardQueue.Count > 0)
			{
				yield return null;
			}
			bool flag = FightPlayer.Instance.Status.state != IStatusManager.State.Dead;
			if (flag)
			{
				IStatusManager status = FightPlayer.Instance.Status;
				Singleton<EventCenter>.Instance.EventTrigger("EndRound" + status.InstanceId);
				this.RemoveAllCards();
				status.ChangeState(IStatusManager.State.Default);
				status.CheckAllBuff("ReducePerTurn");
				status = null;
			}
			else
			{
				FightManager.Instance.CmdAnnounceDone(FightPlayer.Instance.InstanceId, FightPlayer.Instance.Status.state == IStatusManager.State.Dead);
			}
			yield break;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x000BDEEC File Offset: 0x000BC0EC
		[DebuggerStepThrough]
		public void CreateCardItem(int Count)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.CreateCardItem(int)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				Count
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
							Count = 0;
						}
						else
						{
							Count = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateCardItem(Count);
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

		// Token: 0x0600170F RID: 5903 RVA: 0x000BE028 File Offset: 0x000BC228
		[DebuggerStepThrough]
		public void CreateCardItem(DataConfig dataConfig)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.CreateCardItem(DataConfig)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
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
							dataConfig = null;
						}
						else
						{
							dataConfig = (DataConfig)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateCardItem(dataConfig);
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

		// Token: 0x06001710 RID: 5904 RVA: 0x000BE15C File Offset: 0x000BC35C
		[DebuggerStepThrough]
		private void CreateCardItemInternal(DataConfig dataConfig)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.CreateCardItemInternal(DataConfig)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
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
							dataConfig = null;
						}
						else
						{
							dataConfig = (DataConfig)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateCardItemInternal(dataConfig);
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

		// Token: 0x06001711 RID: 5905 RVA: 0x000BE290 File Offset: 0x000BC490
		[DebuggerStepThrough]
		public void UpdateCardItemPos(TweenCallback OnComplete = null, CardContainer from = null)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.UpdateCardItemPos(TweenCallback, CardContainer)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				OnComplete,
				from
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
							OnComplete = null;
						}
						else
						{
							OnComplete = (TweenCallback)arguments[0];
						}
						if (arguments[1] == null)
						{
							from = null;
						}
						else
						{
							from = (CardContainer)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_UpdateCardItemPos(OnComplete, from);
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

		// Token: 0x06001712 RID: 5906 RVA: 0x000BE3E4 File Offset: 0x000BC5E4
		public void ShuffleCardItems()
		{
			bool flag = this.IsNull("Object");
			if (!flag)
			{
				GameObject tempItem = UnityEngine.Object.Instantiate<GameObject>(base.transform.Find("ClockBoard/弃牌堆").gameObject, base.transform.Find("ClockBoard"));
				tempItem.SetActive(false);
				RectTransform uiElement = tempItem.GetComponent<RectTransform>();
				GameObject trail = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/Trail"), base.transform) as GameObject;
				Transform vfx = trail.transform.Find("geometryBursts");
				Transform child;
				foreach (object obj in vfx.transform)
				{
					child = (Transform)obj;
					VisualEffect subVfx = child.GetComponent<VisualEffect>();
					subVfx.SetInt("count", 0);
				}
				tempItem.transform.DOMove(base.transform.Find("Left/Card").transform.position, 1f, false).OnComplete(delegate
				{
					bool flag2 = tempItem == null;
					if (!flag2)
					{
						UnityEngine.Object.Destroy(tempItem);
						foreach (object obj2 in vfx.transform)
						{
							Transform child2 = (Transform)obj2;
							VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
							subVfx2.SetInt("count", 0);
						}
						bool flag3 = this.IsNull("Object");
						if (flag3)
						{
							UnityEngine.Object.Destroy(trail, 4f);
						}
						else
						{
							using (IEnumerator enumerator3 = this.transform.Find("Left/Card").transform.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									Transform child = (Transform)enumerator3.Current;
									child.DOKill(false);
									child.DOPunchScale(Vector3.one * 0.2f, 0.3f, 2, 1f).OnKill(delegate
									{
										child.localScale = Vector3.one;
									});
								}
							}
							UnityEngine.Object.Destroy(trail, 5f);
						}
					}
				}).OnStart(delegate
				{
					foreach (object obj2 in vfx.transform)
					{
						Transform child4 = (Transform)obj2;
						VisualEffect subVfx2 = child4.GetComponent<VisualEffect>();
						subVfx2.SetInt("count", 1);
					}
				}).OnUpdate(delegate
				{
					foreach (object obj2 in vfx.transform)
					{
						Transform child4 = (Transform)obj2;
						VisualEffect subVfx2 = child4.GetComponent<VisualEffect>();
						Vector3 pos = PositionUtility.CameraSpaceToZeroPlane(uiElement, null);
						subVfx2.SetVector3("startPos", pos);
						subVfx2.SetFloat("direction", 160f);
					}
				}).OnKill(delegate
				{
					bool flag2 = tempItem == null;
					if (!flag2)
					{
						UnityEngine.Object.Destroy(tempItem);
						foreach (object obj2 in vfx.transform)
						{
							Transform child4 = (Transform)obj2;
							VisualEffect subVfx2 = child4.GetComponent<VisualEffect>();
							subVfx2.SetInt("count", 0);
						}
						bool flag3 = this.IsNull("Object");
						if (flag3)
						{
							UnityEngine.Object.Destroy(trail, 4f);
						}
						else
						{
							using (IEnumerator enumerator3 = this.transform.Find("Left/Card").transform.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									Transform child = (Transform)enumerator3.Current;
									child.DOKill(false);
									child.DOPunchScale(Vector3.one * 0.2f, 0.3f, 2, 1f).OnKill(delegate
									{
										child.localScale = Vector3.one;
									});
								}
							}
							UnityEngine.Object.Destroy(trail, 4f);
						}
					}
				});
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x000BE57C File Offset: 0x000BC77C
		public void UpdateCardMsg()
		{
			for (int i = 0; i < FightUI.cardItemList.Count; i++)
			{
				FightUI.cardItemList[i].DataUpdate();
			}
			foreach (SkillItem item in this.skillItems)
			{
				item.DataUpdate();
			}
			this.UpdateCardsShow();
			foreach (Enemy item2 in EnemyManager.Instance.enemyList)
			{
				item2.UpdataActionShow();
			}
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000BE654 File Offset: 0x000BC854
		[DebuggerStepThrough]
		public void UpdateCardsShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.UpdateCardsShow()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_UpdateCardsShow();
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

		// Token: 0x06001715 RID: 5909 RVA: 0x000BE750 File Offset: 0x000BC950
		[DebuggerStepThrough]
		public int RemoveAllCards()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.RemoveAllCards()).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[0];
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
					do
					{
						try
						{
							num = this.$Rougamo_RemoveAllCards();
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
								goto IL_10D;
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
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000BE894 File Offset: 0x000BCA94
		private IEnumerator Wait()
		{
			while (FightUI.InIEn || this.createCardQueue.Count > 0)
			{
				Debug.Log("等待中");
				yield return null;
			}
			FightUI obj = this;
			lock (obj)
			{
				this.SelectInit("2");
				bool flag2 = this.ShouldCard > FightUI.cardItemList.Count;
				if (flag2)
				{
					this.ShouldCard = FightUI.cardItemList.Count;
				}
				FightUI.SelectType = "Retain";
				FightUI.SpecialCount += this.ShouldCard;
				this.Title = this.instance.transform.Find("Title").GetComponent<TMP_Text>();
				this.Title.text = "choose".Localize("FightUI") + this.ShouldCard.ToString() + "cards".Localize("FightUI") + "retain".Localize("FightUI");
				for (;;)
				{
					bool flag3;
					if (FightUI.SpecialCount <= 0)
					{
						flag3 = FightUI.SelectedCard.Any((CardItem x) => !x.enabled);
					}
					else
					{
						flag3 = true;
					}
					if (!flag3)
					{
						break;
					}
					bool flag4 = FightUI.cardItemList.Count == 0;
					if (flag4)
					{
						break;
					}
					yield return null;
				}
				List<CardItem> list = new List<CardItem>(FightUI.cardItemList);
				int num;
				for (int i = list.Count - 1; i >= 0; i = num - 1)
				{
					bool flag5 = !FightUI.SelectedCard.Contains(list[i]);
					if (flag5)
					{
						bool shouldRemove = !FightUI.cardItemList[i].Tags.Contains("Retain");
						bool flag6 = shouldRemove;
						if (flag6)
						{
							list[i].ThrowCard();
						}
					}
					else
					{
						FightUI.SelectedCard.Remove(list[i]);
						list[i].transform.SetParent(this.cardContainer.transform);
					}
					num = i;
				}
				this.UpdateCardItemPos(null, null);
				FightUI.SelectedCard.Clear();
				base.transform.Find("ClockBoard/结束回合").gameObject.SetActive(true);
				CardItem.canUse = true;
				UnityEngine.Object.Destroy(this.instance);
				this.transform1.gameObject.SetActive(false);
				FightUI.InIEn = false;
				this.UpdateCardsShow();
				FightManager.Instance.CmdAnnounceDone(FightPlayer.Instance.InstanceId, FightPlayer.Instance.Status.state == IStatusManager.State.Dead);
				list = null;
			}
			obj = null;
			yield break;
			yield break;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x000BE8A4 File Offset: 0x000BCAA4
		[DebuggerStepThrough]
		public void ThrowCardScript(string val, string Type)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.ThrowCardScript(string, string)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				val,
				Type
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
							val = null;
						}
						else
						{
							val = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							Type = null;
						}
						else
						{
							Type = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ThrowCardScript(val, Type);
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

		// Token: 0x06001718 RID: 5912 RVA: 0x000BE9F8 File Offset: 0x000BCBF8
		[DebuggerStepThrough]
		public void Burning(string val, string Type)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.Burning(string, string)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				val,
				Type
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
							val = null;
						}
						else
						{
							val = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							Type = null;
						}
						else
						{
							Type = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Burning(val, Type);
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

		// Token: 0x06001719 RID: 5913 RVA: 0x000BEB4C File Offset: 0x000BCD4C
		private IEnumerator Burn(string val, string Type)
		{
			while (FightUI.InIEn || this.createCardQueue.Count > 0)
			{
				yield return null;
			}
			FightUI obj = this;
			lock (obj)
			{
				this.SelectInit(Type);
				FightUI.SelectType = "Burn";
				FightUI.SpecialCount += int.Parse(val);
				bool flag2 = FightUI.SpecialCount >= FightUI.cardItemList.Count;
				if (flag2)
				{
					List<CardItem> list = new List<CardItem>(FightUI.cardItemList);
					foreach (CardItem item in list)
					{
						bool flag3 = !item.Tags.Contains("Froze");
						if (flag3)
						{
							item.InternalBurning(0f);
						}
						item = null;
					}
					List<CardItem>.Enumerator enumerator = default(List<CardItem>.Enumerator);
					FightUI.SpecialCount = 0;
					list = null;
				}
				else
				{
					FightUI.SpecialCount = Math.Min(this.BurnAndThrowCheck(), FightUI.SpecialCount);
					this.Title = this.instance.transform.Find("Title").GetComponent<TMP_Text>();
					this.Title.text = "choose".Localize("FightUI") + FightUI.SpecialCount.ToString() + "cards".Localize("FightUI") + "burnout".Localize("FightUI");
					for (;;)
					{
						bool flag4;
						if (FightUI.SpecialCount <= 0)
						{
							flag4 = FightUI.SelectedCard.Any((CardItem x) => !x.enabled);
						}
						else
						{
							flag4 = true;
						}
						if (!flag4)
						{
							break;
						}
						bool flag5 = FightUI.cardItemList.Count == 0 || this.AllCannotUse();
						if (flag5)
						{
							break;
						}
						yield return null;
					}
					List<CardItem> list2 = new List<CardItem>(FightUI.cardItemList);
					int num;
					for (int i = list2.Count - 1; i >= 0; i = num - 1)
					{
						bool flag6 = FightUI.SelectedCard.Contains(list2[i]);
						if (flag6)
						{
							this.BurnCard(list2[i]);
						}
						else
						{
							list2[i].transform.SetParent(this.cardContainer.transform);
						}
						num = i;
					}
					list2 = null;
				}
				FightUI.SelectedCard.Clear();
				this.UpdateCardItemPos(null, null);
				UnityEngine.Object.Destroy(this.instance);
				base.transform.Find("ClockBoard/结束回合").gameObject.SetActive(true);
				this.transform1.gameObject.SetActive(false);
				CardItem.canUse = true;
				FightUI.InIEn = false;
			}
			obj = null;
			yield break;
			yield break;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000BEB6C File Offset: 0x000BCD6C
		public int BurnAndThrowCheck()
		{
			int burnCount = 0;
			foreach (CardItem item in FightUI.cardItemList)
			{
				bool flag = !item.Tags.Contains("Froze");
				if (flag)
				{
					burnCount++;
				}
			}
			return burnCount;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000BEBE4 File Offset: 0x000BCDE4
		[DebuggerStepThrough]
		public void BurnCard(CardItem cardItem)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.BurnCard(CardItem)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				cardItem
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
							cardItem = null;
						}
						else
						{
							cardItem = (CardItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_BurnCard(cardItem);
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

		// Token: 0x0600171C RID: 5916 RVA: 0x000BED18 File Offset: 0x000BCF18
		[DebuggerStepThrough]
		public void SelectInit(string uitype)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.SelectInit(string)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				uitype
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
							uitype = null;
						}
						else
						{
							uitype = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SelectInit(uitype);
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

		// Token: 0x0600171D RID: 5917 RVA: 0x000BEE4C File Offset: 0x000BD04C
		[DebuggerStepThrough]
		public void ShowBattleReward()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.ShowBattleReward()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_ShowBattleReward();
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

		// Token: 0x0600171E RID: 5918 RVA: 0x000BEF48 File Offset: 0x000BD148
		public void CanWin()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			base.transform.Find("ClockBoard/结束回合").gameObject.SetActive(false);
			this.EndInstance();
			UIManager.Instance.CloseUI("DeckUI");
			bool flag = EnemyManager.Instance.enemyList.Count != 0;
			if (flag)
			{
				List<Enemy> enemyList = new List<Enemy>(EnemyManager.Instance.enemyList);
				foreach (Enemy item in enemyList)
				{
					item.Status.EnemyDead(0f);
				}
			}
			this.FightAgain.gameObject.SetActive(false);
			this.endfight.gameObject.SetActive(true);
			bool flag2 = EventSystem.current != null;
			if (flag2)
			{
				EventSystem.current.enabled = true;
			}
			bool flag3 = !this.isWin;
			if (flag3)
			{
				this.isWin = true;
				bool flag4 = FightManager.Instance == null || FightManager.Instance.fightType == FightType.Loss || FightManager.Instance.fightType == FightType.Win;
				if (flag4)
				{
					return;
				}
				FightManager.Instance.CmdChangeType(FightType.Win);
				FightPlayer fightPlayer = FightPlayer.Instance;
				if (fightPlayer != null)
				{
					IStatusManager status = fightPlayer.Status;
					if (status != null)
					{
						status.PlayVocal(IStatusManager.VocalState.Win);
					}
				}
				UIManager.Instance.CloseUI("DeckUI");
			}
			this.transform1.gameObject.SetActive(false);
			FightUI.SpecialCount = 0;
			this.DoTurnAnimation(0f, 0.5f);
			stopwatch.Stop();
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000BF108 File Offset: 0x000BD308
		[DebuggerStepThrough]
		public void EndInstance()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.EndInstance()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_EndInstance();
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

		// Token: 0x06001720 RID: 5920 RVA: 0x000BF204 File Offset: 0x000BD404
		[DebuggerStepThrough]
		public void Yes()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.Yes()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_Yes();
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

		// Token: 0x06001721 RID: 5921 RVA: 0x000BF300 File Offset: 0x000BD500
		public bool AllCannotUse()
		{
			foreach (CardItem item in FightUI.cardItemList)
			{
				bool flag = !item.Tags.Contains("Froze");
				if (flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000BF374 File Offset: 0x000BD574
		private IEnumerator Throw(string val, string Type)
		{
			while (FightUI.InIEn || this.createCardQueue.Count > 0)
			{
				yield return null;
			}
			FightUI obj = this;
			lock (obj)
			{
				this.SelectInit(Type);
				FightUI.SelectType = "Throw";
				FightUI.SpecialCount += int.Parse(val);
				bool flag2 = FightUI.SpecialCount >= FightUI.cardItemList.Count;
				if (flag2)
				{
					List<CardItem> tempList = new List<CardItem>(FightUI.cardItemList);
					foreach (CardItem item in tempList)
					{
						item.ThrowCard();
						item = null;
					}
					List<CardItem>.Enumerator enumerator = default(List<CardItem>.Enumerator);
					FightUI.SpecialCount = 0;
					tempList = null;
				}
				else
				{
					FightUI.SpecialCount = Math.Min(this.BurnAndThrowCheck(), FightUI.SpecialCount);
					this.Title = this.instance.transform.Find("Title").GetComponent<TMP_Text>();
					this.Title.text = "choose".Localize("FightUI") + FightUI.SpecialCount.ToString() + "cards".Localize("FightUI") + "throw".Localize("FightUI");
					for (;;)
					{
						bool flag3;
						if (FightUI.SpecialCount <= 0)
						{
							flag3 = FightUI.SelectedCard.Any((CardItem x) => !x.enabled);
						}
						else
						{
							flag3 = true;
						}
						if (!flag3)
						{
							break;
						}
						bool flag4 = FightUI.cardItemList.Count == 0 || this.AllCannotUse();
						if (flag4)
						{
							break;
						}
						yield return null;
					}
					int num;
					for (int i = FightUI.cardItemList.Count - 1; i >= 0; i = num - 1)
					{
						bool flag5 = FightUI.SelectedCard.Contains(FightUI.cardItemList[i]);
						if (flag5)
						{
							FightUI.cardItemList[i].ThrowCard();
						}
						else
						{
							FightUI.SelectedCard.Remove(FightUI.cardItemList[i]);
							FightUI.cardItemList[i].transform.SetParent(this.cardContainer.transform);
						}
						num = i;
					}
				}
				FightUI.SelectedCard.Clear();
				CardItem.canUse = true;
				this.transform1.gameObject.SetActive(false);
				base.transform.Find("ClockBoard/结束回合").gameObject.SetActive(true);
				UnityEngine.Object.Destroy(this.instance);
				this.UpdateCardItemPos(null, null);
				FightUI.InIEn = false;
				this.UpdateCardsShow();
			}
			obj = null;
			yield break;
			yield break;
		}

		/// <summary>
		/// 加入动画队列动画
		/// </summary>
		/// <param name="status"></param>
		// Token: 0x06001723 RID: 5923 RVA: 0x000BF394 File Offset: 0x000BD594
		[DebuggerStepThrough]
		public void CallActionAnimation(IScriptExecutor scriptExecutor)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.CallActionAnimation(IScriptExecutor)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				scriptExecutor
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
							scriptExecutor = null;
						}
						else
						{
							scriptExecutor = (IScriptExecutor)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CallActionAnimation(scriptExecutor);
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

		/// <summary>
		/// 实际执行队列动画
		/// </summary>
		// Token: 0x06001724 RID: 5924 RVA: 0x000BF4C8 File Offset: 0x000BD6C8
		[DebuggerStepThrough]
		public void DOActionAnimation()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.DOActionAnimation()).MethodHandle, typeof(FightUI).TypeHandle);
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
							this.$Rougamo_DOActionAnimation();
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

		// Token: 0x06001725 RID: 5925 RVA: 0x000BF5C4 File Offset: 0x000BD7C4
		[DebuggerStepThrough]
		public void DoCardUseAnimation(UseCard.CardUseData cardUseData)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(FightUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(FightUI.DoCardUseAnimation(UseCard.CardUseData)).MethodHandle, typeof(FightUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				cardUseData
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
							cardUseData = default(UseCard.CardUseData);
						}
						else
						{
							cardUseData = (UseCard.CardUseData)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_DoCardUseAnimation(cardUseData);
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

		// Token: 0x0600172D RID: 5933 RVA: 0x000BF874 File Offset: 0x000BDA74
		private int $Rougamo_get_CardTopCount()
		{
			return this._cardTopCount;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x000BF88C File Offset: 0x000BDA8C
		private void $Rougamo_set_CardTopCount(int value)
		{
			bool flag = value > 20;
			if (flag)
			{
				this._cardTopCount = 20;
			}
			else
			{
				bool flag2 = value < 5;
				if (flag2)
				{
					this._cardTopCount = 5;
				}
				else
				{
					this._cardTopCount = value;
				}
			}
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x000BF8CC File Offset: 0x000BDACC
		private void $Rougamo_Close()
		{
			bool flag = UIManager.Instance != null && this != null && base.gameObject != null;
			if (flag)
			{
				UIManager.Instance.RemoveUI(base.gameObject.name);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000BF928 File Offset: 0x000BDB28
		private void $Rougamo_EnqueueDamageText(string text, Vector3 position, string popUpType1, StatusManager status, StatusManager to, string realDamage)
		{
			FightUI.DamageTextInfo damageTextInfo = new FightUI.DamageTextInfo
			{
				text = text,
				position = position + new Vector3((float)this.random.Next(-200, 100), (float)this.random.Next(-100, 150), 0f),
				popUpType = popUpType1,
				status = status,
				realDamage = realDamage,
				to = to
			};
			this.damageTextQueue.Enqueue(damageTextInfo);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000BF9B0 File Offset: 0x000BDBB0
		private void $Rougamo_StartClock()
		{
			bool flag = GameSaveManager.GetValue<string>("LimitTime") == "False";
			if (flag)
			{
				this.process.Find("Bar").gameObject.SetActive(false);
			}
			else
			{
				this.process.gameObject.SetActive(true);
				this.process.Find("Bar").gameObject.SetActive(true);
				this.hasTime = 60;
				this.process.Find("Bar/Outer").GetComponent<Image>().fillAmount = 1f;
				base.StartCoroutine(this.SetTime());
			}
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x000BFA58 File Offset: 0x000BDC58
		private void $Rougamo_StopClock()
		{
			this.process.Find("Bar").gameObject.SetActive(false);
			this.hasTime = 0;
			base.StopAllCoroutines();
			FightUI.SpecialCount = 0;
			FightUI.SelectedCard.Clear();
			UnityEngine.Object.Destroy(this.instance);
			base.transform.Find("ClockBoard/结束回合").gameObject.SetActive(true);
			this.transform1.gameObject.SetActive(false);
			CardItem.canUse = true;
			FightUI.InIEn = false;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000BFAE8 File Offset: 0x000BDCE8
		private void $Rougamo_SetClockName(string name)
		{
			bool flag = this.processTween != null && this.processTween.IsActive() && this.processTween.IsPlaying();
			if (flag)
			{
				this.processTween.Kill(false);
			}
			this.processTween = DOTween.Sequence();
			this.process.GetComponent<CanvasGroup>().alpha = 0f;
			this.processTween.Append(this.process.GetComponent<CanvasGroup>().DOFade(1f, 0.5f));
			TweenCallback <>9__2;
			this.processTween.Append(this.process.Find("Tip").DORotate(new Vector3(360f, 0f, 0f), 1f, RotateMode.LocalAxisAdd).OnStart(delegate
			{
				TweenerCore<Color, Color, ColorOptions> t = this.process.Find("Tip/Text").GetComponent<TMP_Text>().DOFade(0f, 0.5f);
				TweenCallback action;
				if ((action = <>9__2) == null)
				{
					action = (<>9__2 = delegate()
					{
						this.process.Find("Tip/Text").GetComponent<TMP_Text>().text = "";
						this.process.Find("Tip/Text").GetComponent<TMP_Text>().DOFade(1f, 0.5f);
						this.process.Find("Tip/Text").GetComponent<TMP_Text>().text = "<color=red>" + name + "</color> " + "的回合".Localize("FightUI");
					});
				}
				t.OnComplete(action);
			}).OnComplete(delegate
			{
				this.process.Find("Tip").eulerAngles = new Vector3(0f, 0f, 0f);
			}));
			bool flag2 = FightManager.Instance.roleQueue.Count == 1 && GameSaveManager.GetValue<string>("LimitTime") == "False";
			if (flag2)
			{
				this.processTween.Append(this.process.GetComponent<CanvasGroup>().DOFade(0f, 0.5f).SetDelay(2f));
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000BFC43 File Offset: 0x000BDE43
		private void $Rougamo_DoTurnAnimation(float movement, [Optional] float duration)
		{
			Camera main = Camera.main;
			if (main != null)
			{
				main.transform.DOMoveX(movement, duration, false);
			}
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x000BFC60 File Offset: 0x000BDE60
		private void $Rougamo_SetTurn(FightObject obj, int index, int count)
		{
			this.SetClockName(obj.Name);
			bool flag = count == 1;
			if (!flag)
			{
				float movement = Mathf.Lerp(-1f, 1f, (float)index / (float)(count - 1));
				this.DoTurnAnimation(movement, 1.5f / (float)count);
			}
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x000BFCB0 File Offset: 0x000BDEB0
		private void $Rougamo_ShowChest()
		{
			this.chest.transform.SetAsLastSibling();
			this.chest.SetActive(true);
			this.EndInstance();
			TweenerCore<float, float, FloatOptions> tweenerCore = base.transform.Find("Left").GetComponent<CanvasGroup>().DOFade(0f, 0.5f);
			tweenerCore.onComplete = (TweenCallback)Delegate.Combine(tweenerCore.onComplete, new TweenCallback(delegate()
			{
				bool flag = UIManager.Instance.GetUI<FightUI>("FightUI") != null;
				if (flag)
				{
					UIManager.Instance.GetUI<FightUI>("FightUI").transform.Find("Left").gameObject.SetActive(false);
				}
			}));
			UniTask.WaitForSeconds(3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
			{
				bool flag = this != null && base.gameObject != null;
				if (flag)
				{
					this.ShowBattleReward();
				}
			}).Forget();
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000BFD68 File Offset: 0x000BDF68
		private void $Rougamo_Update()
		{
			this.UpdateCardKeyboardShortcut();
			this.ShowDamageText();
			this.AutoUseCard();
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x000BFD80 File Offset: 0x000BDF80
		private void $Rougamo_UpdateCardKeyboardShortcut()
		{
			bool flag = FightManager.Instance == null || FightManager.Instance.fightType != FightType.Player || FightUI.cardItemList == null;
			if (!flag)
			{
				Keyboard i = Keyboard.current;
				bool flag2 = i == null;
				if (!flag2)
				{
					bool anyDragOrLine = false;
					for (int j = 0; j < FightUI.cardItemList.Count; j++)
					{
						CardItem c = FightUI.cardItemList[j];
						bool flag3 = c == null || c.hasUse;
						if (!flag3)
						{
							bool draging = c.draging;
							if (draging)
							{
								anyDragOrLine = true;
								break;
							}
							AttackCardItem ac = c as AttackCardItem;
							bool flag4 = ac != null && ac.isLine;
							if (flag4)
							{
								anyDragOrLine = true;
								break;
							}
						}
					}
					bool flag5 = this._keyboardSelectedCard != null && this._keyboardSelectedCard.hasUse;
					if (flag5)
					{
						this._keyboardSelectedCard = null;
						this._keyboardSelectedIndex = -1;
					}
					bool flag6 = !anyDragOrLine && this._keyboardSelectedCard == null;
					if (flag6)
					{
						int idx = -1;
						bool wasPressedThisFrame = i.digit1Key.wasPressedThisFrame;
						if (wasPressedThisFrame)
						{
							idx = 0;
						}
						else
						{
							bool wasPressedThisFrame2 = i.digit2Key.wasPressedThisFrame;
							if (wasPressedThisFrame2)
							{
								idx = 1;
							}
							else
							{
								bool wasPressedThisFrame3 = i.digit3Key.wasPressedThisFrame;
								if (wasPressedThisFrame3)
								{
									idx = 2;
								}
								else
								{
									bool wasPressedThisFrame4 = i.digit4Key.wasPressedThisFrame;
									if (wasPressedThisFrame4)
									{
										idx = 3;
									}
									else
									{
										bool wasPressedThisFrame5 = i.digit5Key.wasPressedThisFrame;
										if (wasPressedThisFrame5)
										{
											idx = 4;
										}
										else
										{
											bool wasPressedThisFrame6 = i.digit6Key.wasPressedThisFrame;
											if (wasPressedThisFrame6)
											{
												idx = 5;
											}
											else
											{
												bool wasPressedThisFrame7 = i.digit7Key.wasPressedThisFrame;
												if (wasPressedThisFrame7)
												{
													idx = 6;
												}
												else
												{
													bool wasPressedThisFrame8 = i.digit8Key.wasPressedThisFrame;
													if (wasPressedThisFrame8)
													{
														idx = 7;
													}
													else
													{
														bool wasPressedThisFrame9 = i.digit9Key.wasPressedThisFrame;
														if (wasPressedThisFrame9)
														{
															idx = 8;
														}
														else
														{
															bool wasPressedThisFrame10 = i.digit0Key.wasPressedThisFrame;
															if (wasPressedThisFrame10)
															{
																idx = 9;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						bool flag7 = idx >= 0 && idx < FightUI.cardItemList.Count;
						if (flag7)
						{
							CardItem card = FightUI.cardItemList[idx];
							bool flag8 = !FightUI.InIEn && CardItem.canUse;
							if (flag8)
							{
								bool flag9 = card != null && !card.hasUse;
								if (flag9)
								{
									AttackCardItem attack = card as AttackCardItem;
									bool flag10 = attack != null;
									if (flag10)
									{
										attack.BeginLineMode();
										this._keyboardSelectedCard = attack;
										this._keyboardSelectedIndex = idx;
									}
									else
									{
										CommonCardItem common = card as CommonCardItem;
										bool flag11 = common != null;
										if (flag11)
										{
											common.UseCardDirectly();
											this.UpdateCardItemPos(null, null);
										}
									}
								}
							}
							else
							{
								bool inIEn = FightUI.InIEn;
								if (inIEn)
								{
									card.OnRightClick(new PointerEventData(EventSystem.current)
									{
										button = PointerEventData.InputButton.Left
									});
								}
							}
						}
					}
					bool flag12 = this._keyboardSelectedCard != null;
					if (flag12)
					{
						bool flag13 = (i.digit1Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 0) || (i.digit2Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 1) || (i.digit3Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 2) || (i.digit4Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 3) || (i.digit5Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 4) || (i.digit6Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 5) || (i.digit7Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 6) || (i.digit8Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 7) || (i.digit9Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 8) || (i.digit0Key.wasReleasedThisFrame && this._keyboardSelectedIndex == 9);
						if (flag13)
						{
							AttackCardItem attack2 = this._keyboardSelectedCard as AttackCardItem;
							bool flag14 = attack2 != null;
							if (flag14)
							{
								attack2.CommitOrCancelFromKeyboard();
							}
							this._keyboardSelectedCard = null;
							this._keyboardSelectedIndex = -1;
						}
					}
				}
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000C01B0 File Offset: 0x000BE3B0
		private void $Rougamo_ShowDamageText()
		{
			FightUI.<ShowDamageText>d__44 <ShowDamageText>d__ = new FightUI.<ShowDamageText>d__44();
			<ShowDamageText>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ShowDamageText>d__.<>4__this = this;
			<ShowDamageText>d__.<>1__state = -1;
			<ShowDamageText>d__.<>t__builder.Start<FightUI.<ShowDamageText>d__44>(ref <ShowDamageText>d__);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000C01EC File Offset: 0x000BE3EC
		private void $Rougamo_Awake()
		{
			GameApp.Instance.NowBackground.gameObject.SetActive(true);
			this.chest = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load<GameObject>("Model/Chest", true));
			Sprite sprite = this.chest.transform.Find("body/Close").GetComponent<SpriteRenderer>().sprite;
			this.chest.transform.position = new Vector3(6f, GameApp.Instance.NowBackground.transform.Find("com").GetComponent<SceneInfo>().ground_y + sprite.bounds.size.y / 2f, 0f);
			this.chest.SetActive(false);
			this.chest.GetComponent<Button>().onClick.RemoveAllListeners();
			this.chest.GetComponent<Button>().onClick.AddListener(new UnityAction(this.ShowBattleReward));
			UniTask.Create(delegate()
			{
				FightUI.<<Awake>b__52_0>d <<Awake>b__52_0>d = new FightUI.<<Awake>b__52_0>d();
				<<Awake>b__52_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Awake>b__52_0>d.<>4__this = this;
				<<Awake>b__52_0>d.<>1__state = -1;
				<<Awake>b__52_0>d.<>t__builder.Start<FightUI.<<Awake>b__52_0>d>(ref <<Awake>b__52_0>d);
				return <<Awake>b__52_0>d.<>t__builder.Task;
			});
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x000C02FC File Offset: 0x000BE4FC
		private void $Rougamo_Start()
		{
			bool flag = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (flag)
			{
				Singleton<EventCenter>.Instance.AddEventListener("UIClose-CurtainTurnUI", delegate()
				{
					this.ShowTitle();
				}, this, EventDispose.None);
			}
			else
			{
				this.ShowTitle();
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x000C0350 File Offset: 0x000BE550
		private void $Rougamo_ShowTitle()
		{
			UIManager.Instance.ShowUI<TitleUI>("TitleUI", true).ShowTitle(GameApp.Instance.NowBackground.name.Localize("MapSelectUI"), "Encounter Enemy".Localize("FightUI"), EnemyManager.SettlementMultiplier.ToString());
			AudioManager audioManager = AudioManager.Instance;
			if (audioManager != null)
			{
				audioManager.PlayEffect("Effect/行动单位发生变化");
			}
			this.started = true;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x000C03C4 File Offset: 0x000BE5C4
		private void $Rougamo_Init()
		{
			this.createCardQueue.Clear();
			this.process = base.transform.Find("Process");
			FightUI.LastCard = null;
			FightUI.SelectedCard.Clear();
			this.CardTopCount = RoleTable.Instance.CardCount;
			base.transform.SetAsFirstSibling();
			FightUI.cardItemList = new List<CardItem>();
			this.turnButton = base.transform.Find("ClockBoard/结束回合").GetComponent<ButtonManager>();
			this.turnButton.onClick.RemoveAllListeners();
			this.turnButton.onClick.AddListener(new UnityAction(FightManager.Instance.TurnEnd));
			this.cardContainer = base.transform.Find("container").GetComponent<CardContainer>();
			this.selectCardContainer = base.transform.Find("Selectcontainer").GetComponent<CardContainer>();
			this.transform1 = base.transform.Find("ClockBoard/确定");
			this.endfight = base.transform.Find("ClockBoard/结束战斗");
			this.FightAgain = base.transform.Find("ClockBoard/重开战斗");
			this.UsedCardList = base.transform.Find("ClockBoard/弃牌堆");
			this.Card_y_position = this.cardContainer.transform.position.y;
			CardItem.canUse = true;
			FightUI.IsReset = true;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x000C0530 File Offset: 0x000BE730
		private void $Rougamo_InitSkill()
		{
			bool flag = RoleTable.Instance.Career.data["ActionImage2"] != "";
			if (flag)
			{
				base.transform.Find("Left/Skill2").gameObject.SetActive(true);
				base.transform.Find("Left/Skill1").gameObject.SetActive(false);
				this.CreateSkillItem(base.transform.Find("Left/Skill2/Skill1"), 1);
				this.CreateSkillItem(base.transform.Find("Left/Skill2/Skill2"), 2);
			}
			else
			{
				bool flag2 = RoleTable.Instance.Career.data["ActionImage1"] != "";
				if (flag2)
				{
					Transform tempItem = base.transform.Find("Left/Skill1");
					this.CreateSkillItem(tempItem, 1);
				}
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x000C0614 File Offset: 0x000BE814
		private void $Rougamo_CreateSkillItem(Transform tempItem, int index)
		{
			string skill;
			bool flag = !RoleTable.Instance.Career.data.TryGetValue("Skill" + index.ToString(), out skill);
			if (!flag)
			{
				tempItem.Find("Icon").gameObject.SetActive(true);
				tempItem.GetComponent<SkillItem>().enabled = true;
				tempItem.GetComponent<SkillItem>().Init(new DataConfig(skill, DataType.Card));
				tempItem.Find("Icon").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(RoleTable.Instance.Career.data["ActionImage" + index.ToString()], true);
				tempItem.Find("Icon").GetComponent<Image>().enabled = true;
				this.skillItems.Add(tempItem.GetComponent<SkillItem>());
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x000C06F6 File Offset: 0x000BE8F6
		private void $Rougamo_CreateDeckMenu()
		{
			UIManager.Instance.ShowUI<DeckUI>("DeckUI", true).CreateDeckMenu();
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x000C070F File Offset: 0x000BE90F
		private void $Rougamo_CreateUsedCardList()
		{
			UIManager.Instance.ShowUI<DeckUI>("DeckUI", true).CreateUsedDeckMenu();
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000C0728 File Offset: 0x000BE928
		private void $Rougamo_UpdatePower()
		{
			base.transform.Find("Left/Time/total/val").GetComponent<TMP_Text>().text = FightPlayer.Instance.CurPowerCount.ToString() + "/" + FightPlayer.Instance.MaxPowerCount.ToString();
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x000C0780 File Offset: 0x000BE980
		private void $Rougamo_FightAgainBtn()
		{
			bool flag = FightUI.IsReset || this.quickReset;
			if (!flag)
			{
				FightUI.IsReset = true;
				this.quickReset = true;
				UniTask.WaitForSeconds(1, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
				{
					this.quickReset = false;
				}).Forget();
				base.StopAllCoroutines();
				this.chest.SetActive(false);
				base.transform.Find("Left").GetComponent<CanvasGroup>().alpha = 1f;
				FightManager.Instance.ReSetFight(EnemyManager.Instance.LevelId);
				this.turnButton.gameObject.SetActive(true);
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x000C083C File Offset: 0x000BEA3C
		private void $Rougamo_onChangeTurnBtn()
		{
			bool flag = FightManager.Instance == null;
			if (!flag)
			{
				AudioManager audioManager = AudioManager.Instance;
				if (audioManager != null)
				{
					audioManager.PlayEffect("NewSounds/战斗中/切换回合/切换回合");
				}
				this.StopClock();
				bool flag2 = UIManager.Instance != null && UIManager.Instance.GetUI<LineUI>("LineUI");
				if (flag2)
				{
					UIManager.Instance.GetUI<LineUI>("LineUI").Hide();
				}
				bool flag3 = FightManager.Instance.fightType == FightType.Player;
				if (flag3)
				{
					bool flag4 = this.turnButton != null;
					if (flag4)
					{
						this.turnButton.Interactable(false);
					}
					base.StartCoroutine(this.TurnBtn());
				}
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x000C08F8 File Offset: 0x000BEAF8
		private void $Rougamo_CreateCardItem(int Count)
		{
			for (int i = 0; i < Count; i++)
			{
				Singleton<EventCenter>.Instance.EventTrigger("ICreateCardItem" + FightPlayer.Instance.Status.InstanceId);
			}
			Singleton<EventCenter>.Instance.EventTrigger("CreateCardItem" + FightPlayer.Instance.Status.InstanceId);
			for (int j = 0; j < Count; j++)
			{
				bool flag = FightUI.cardItemList.Count + this.createCardQueue.Count < this.CardTopCount;
				if (flag)
				{
					bool flag2 = !FightCardManager.Instance.HasCard() || FightCardManager.Instance.cardList.Count < this.ShouldCard;
					if (flag2)
					{
						FightCardManager.Instance.RandomIndex();
					}
					bool flag3 = FightCardManager.Instance.HasCard();
					if (!flag3)
					{
						break;
					}
					DataConfig cardDataConfig = FightCardManager.Instance.DrawCard();
					this.CreateCardItem(cardDataConfig);
				}
				else
				{
					UIManager.Instance.ShowTip("手牌满了", null);
				}
			}
			Singleton<EventCenter>.Instance.EventTrigger("EndCreateCardItem" + FightPlayer.Instance.Status.InstanceId);
			base.transform.SetAsFirstSibling();
			this.UpdateCardItemPos(null, null);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x000C0A54 File Offset: 0x000BEC54
		private void $Rougamo_CreateCardItem(DataConfig dataConfig)
		{
			bool flag = dataConfig == null;
			if (!flag)
			{
				bool flag2 = FightUI.cardItemList.Count + this.createCardQueue.Count >= this.CardTopCount;
				if (!flag2)
				{
					this.createCardQueue.Enqueue(dataConfig);
				}
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x000C0AA4 File Offset: 0x000BECA4
		private void $Rougamo_CreateCardItemInternal(DataConfig dataConfig)
		{
			AudioManager audioManager = AudioManager.Instance;
			if (audioManager != null)
			{
				audioManager.PlayEffect("NewSounds/卡牌与事件/抽牌");
			}
			dataConfig.scriptExecutor.Self = FightPlayer.Instance.Status;
			dataConfig.scriptExecutor.RunScript("InitScript");
			bool flag = this.cardContainer == null;
			if (!flag)
			{
				GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/CardItem"), this.cardContainer.transform) as GameObject;
				obj.GetComponent<RectTransform>().anchoredPosition = new Vector2(-1500f, this.Card_y_position);
				CardItem item = obj.AddComponent(Type.GetType(dataConfig.Vars["BaseScript"])) as CardItem;
				item.selectContainer = this.selectCardContainer;
				item.cardcontainer = this.cardContainer;
				item.Init(dataConfig);
				FightUI.cardItemList.Add(item);
				base.transform.SetAsFirstSibling();
				this.UpdateCardItemPos(null, null);
				Singleton<EventCenter>.Instance.EventTrigger("EndCreateCardItem" + FightPlayer.Instance.Status.InstanceId);
			}
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000C0BC8 File Offset: 0x000BEDC8
		private void $Rougamo_UpdateCardItemPos([Optional] TweenCallback OnComplete, [Optional] CardContainer from)
		{
			List<CardItem> tempList = new List<CardItem>();
			bool flag = from == null;
			if (flag)
			{
				tempList = FightUI.cardItemList;
				this.cardContainer.UpdateCardItemPos<CardItem>(tempList, OnComplete, false);
			}
			else
			{
				tempList = FightUI.SelectedCard;
				this.selectCardContainer.UpdateCardItemPos<CardItem>(tempList, OnComplete, false);
			}
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000C0C18 File Offset: 0x000BEE18
		private void $Rougamo_UpdateCardsShow()
		{
			base.transform.Find("Left/Card/val").GetComponent<TMP_Text>().text = FightCardManager.Instance.cardList.Count<DataConfig>().ToString();
			base.transform.Find("ClockBoard/弃牌堆/val").GetComponent<TMP_Text>().text = FightCardManager.Instance.usedCardList.Count<DataConfig>().ToString();
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000C0C8C File Offset: 0x000BEE8C
		private int $Rougamo_RemoveAllCards()
		{
			this.ShouldCard = (int)FightPlayer.Instance.Status.dynamicVariables.GetValueOrDefault("RetainCard", 0f);
			int totalCount = FightUI.cardItemList.Count;
			bool flag = this.ShouldCard != 0;
			if (flag)
			{
				base.StartCoroutine(this.Wait());
			}
			else
			{
				CardItem.canUse = false;
				for (int i = 0; i < FightUI.cardItemList.Count; i++)
				{
					bool shouldRemove = !FightUI.cardItemList[i].Tags.Contains("Retain");
					bool flag2 = shouldRemove;
					if (flag2)
					{
						FightUI.cardItemList[i].ignore = true;
					}
				}
				for (int j = FightUI.cardItemList.Count - 1; j >= 0; j--)
				{
					bool shouldRemove2 = !FightUI.cardItemList[j].Tags.Contains("Retain");
					CardItem item = FightUI.cardItemList[j];
					bool flag3 = shouldRemove2;
					if (flag3)
					{
						Stopwatch stopwatch = new Stopwatch();
						stopwatch.Start();
						item.InternalThrow();
					}
				}
				FightManager.Instance.CmdAnnounceDone(FightPlayer.Instance.InstanceId, FightPlayer.Instance.Status.state == IStatusManager.State.Dead);
			}
			return totalCount - this.ShouldCard;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000C0DF3 File Offset: 0x000BEFF3
		private void $Rougamo_ThrowCardScript(string val, string Type)
		{
			base.StartCoroutine(this.Throw(val, Type));
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000C0E05 File Offset: 0x000BF005
		private void $Rougamo_Burning(string val, string Type)
		{
			base.StartCoroutine(this.Burn(val, Type));
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000C0E17 File Offset: 0x000BF017
		private void $Rougamo_BurnCard(CardItem cardItem)
		{
			cardItem.Burning(0f);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x000C0E28 File Offset: 0x000BF028
		private void $Rougamo_SelectInit(string uitype)
		{
			base.transform.Find("ClockBoard/结束回合").gameObject.SetActive(false);
			CardItem.canUse = false;
			string prefabName = "UI/FightCardUI1";
			bool flag = !FightUI.InIEn;
			if (flag)
			{
				FightUI.InIEn = true;
				bool flag2 = this.prefabA == null;
				if (flag2)
				{
					this.prefabA = (ResourceLoader.Load(prefabName) as GameObject);
					this.prefabA.name = "prefabA";
				}
			}
			bool flag3 = this.prefabA != null;
			if (flag3)
			{
				this.instance = UnityEngine.Object.Instantiate<GameObject>(this.prefabA, base.transform);
				this.instance.name = "SelectCard";
				this.instance.transform.localPosition = new Vector3(0f, 0f, 0f);
				this.instance.transform.SetAsFirstSibling();
				bool flag4 = uitype == "2";
				if (flag4)
				{
					this.transform1.gameObject.SetActive(true);
				}
				base.transform.Find("ClockBoard/确定").GetComponent<ButtonManager>().onClick.RemoveAllListeners();
				base.transform.Find("ClockBoard/确定").GetComponent<ButtonManager>().onClick.AddListener(new UnityAction(this.Yes));
				this.Title = this.instance.transform.Find("Title").GetComponent<TMP_Text>();
			}
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x000C0FAC File Offset: 0x000BF1AC
		private void $Rougamo_ShowBattleReward()
		{
			bool flag = !this.ShowReward;
			if (!flag)
			{
				this.ShowReward = false;
				this.chest.transform.Find("body/Close").gameObject.SetActive(false);
				this.chest.transform.Find("body/Open").gameObject.SetActive(true);
				MapManager.Instance.ModeMapManager.SetRewardType("normal");
				UIManager.Instance.ShowUI<BattleRewardsUI>("BattleRewardsUI", true);
				this.Close();
			}
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x000C1040 File Offset: 0x000BF240
		private void $Rougamo_EndInstance()
		{
			bool inIEn = FightUI.InIEn;
			if (inIEn)
			{
				FightUI.InIEn = false;
				base.StopAllCoroutines();
				bool flag = this.instance != null;
				if (flag)
				{
					UnityEngine.Object.Destroy(this.instance);
				}
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x000C1084 File Offset: 0x000BF284
		private void $Rougamo_Yes()
		{
			FightUI.SpecialCount = 0;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x000C1090 File Offset: 0x000BF290
		private void $Rougamo_CallActionAnimation(IScriptExecutor scriptExecutor)
		{
			FightUI.AnimationData animationData = new FightUI.AnimationData
			{
				effectName = scriptExecutor.dataConfig.data.GetValueOrDefault("Effects", null),
				status = new StatusManager[scriptExecutor.Object.Count + 1]
			};
			animationData.status[0] = (scriptExecutor.Self as StatusManager);
			for (int i = 0; i < scriptExecutor.Object.Count; i++)
			{
				animationData.status[i + 1] = (scriptExecutor.Object[i] as StatusManager);
			}
			animationData.status = animationData.status.Distinct<StatusManager>().ToArray<StatusManager>();
			animationData.animationState = new IStatusManager.AnimatedState[animationData.status.Length];
			IStatusManager.AnimatedState animatedState;
			bool flag = scriptExecutor.dataConfig.data.ContainsKey("Action") && Enum.TryParse<IStatusManager.AnimatedState>(scriptExecutor.dataConfig.data["Action"], out animatedState);
			if (flag)
			{
				animationData.animationState[0] = animatedState;
			}
			else
			{
				animationData.animationState[0] = IStatusManager.AnimatedState.Idle;
			}
			for (int j = 1; j < animationData.status.Length; j++)
			{
				bool flag2 = animationData.status[j] != scriptExecutor.Self;
				if (flag2)
				{
					animationData.animationState[j] = IStatusManager.AnimatedState.Hit;
				}
			}
			bool flag3 = animationData.animationState[0] == IStatusManager.AnimatedState.Attack && string.IsNullOrEmpty(animationData.effectName);
			if (flag3)
			{
				animationData.effectName = "slash";
			}
			this.animationQueue.Enqueue(animationData);
			this.DOActionAnimation();
			Singleton<EffectManager>.Instance.PlayActionEffect(scriptExecutor, animationData.effectName, 0.05f);
			FightManager.Instance.EnqueueEvent(new ActionAnimation().Create(animationData));
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x000C125C File Offset: 0x000BF45C
		private void $Rougamo_DOActionAnimation()
		{
			FightUI.<>c__DisplayClass105_0 CS$<>8__locals1 = new FightUI.<>c__DisplayClass105_0();
			CS$<>8__locals1.<>4__this = this;
			bool flag = this.animationQueue.Count <= 0;
			if (!flag)
			{
				this.NowAnimation = true;
				FightUI.AnimationData animationData = this.animationQueue.Dequeue();
				bool flag2 = animationData.status == null || animationData.status.Length == 0;
				if (flag2)
				{
					this.NowAnimation = false;
				}
				else
				{
					CS$<>8__locals1.speedMultiplier = 1f;
					bool flag3 = this.animationQueue.Count > 0;
					if (flag3)
					{
						CS$<>8__locals1.speedMultiplier = 1.5f;
					}
					CS$<>8__locals1.leftCount = 0;
					CS$<>8__locals1.rightCount = 0;
					Vector3[] positions = (from x in animationData.status
					where x != null
					select x).Select(delegate(StatusManager x)
					{
						bool flag23 = x.initPos.x < 0f;
						if (flag23)
						{
							int num2 = CS$<>8__locals1.leftCount;
							CS$<>8__locals1.leftCount = num2 + 1;
						}
						else
						{
							int num2 = CS$<>8__locals1.rightCount;
							CS$<>8__locals1.rightCount = num2 + 1;
						}
						return x.initPos;
					}).ToArray<Vector3>();
					bool flag4 = positions.Length == 0;
					if (flag4)
					{
						this.NowAnimation = false;
					}
					else
					{
						Vector3[] tempPositions = new Vector3[positions.Length];
						positions.CopyTo(tempPositions, 0);
						bool attackFromLeft = positions[0].x < 0f;
						bool flag5 = attackFromLeft;
						if (flag5)
						{
							for (int i = 0; i < positions.Length; i++)
							{
								int index = Array.IndexOf<Vector3>(positions, (from p in positions
								orderby p.x
								select p).ElementAt(i));
								bool flag6 = i < CS$<>8__locals1.leftCount;
								if (flag6)
								{
									tempPositions[i].x = Mathf.Lerp(-1f, -5f, (float)(index + 1) / (float)(CS$<>8__locals1.leftCount + 1));
								}
								else
								{
									tempPositions[i].x = Mathf.Lerp(1f, 5f, (float)(1 + index - CS$<>8__locals1.leftCount) / (float)(CS$<>8__locals1.leftCount + 1));
								}
								tempPositions[i] += Camera.main.transform.position;
							}
						}
						else
						{
							for (int j = positions.Length - 1; j >= 0; j--)
							{
								int index2 = Array.IndexOf<Vector3>(positions, (from p in positions
								orderby p.x
								select p).ElementAt(j));
								bool flag7 = j < CS$<>8__locals1.rightCount;
								if (flag7)
								{
									tempPositions[j].x = Mathf.Lerp(1f, 5f, (float)(index2 + 1) / (float)(CS$<>8__locals1.rightCount + 1));
								}
								else
								{
									tempPositions[j].x = Mathf.Lerp(-1f, -5f, (float)(3 - index2 - CS$<>8__locals1.rightCount) / (float)(CS$<>8__locals1.rightCount + 1));
								}
								tempPositions[j] += Camera.main.transform.position;
							}
						}
						tempPositions.CopyTo(positions, 0);
						this.waitingTime = 0f;
						bool isAnimated = (animationData.animationState[0] == IStatusManager.AnimatedState.Attack || animationData.animationState[0] == IStatusManager.AnimatedState.Special || animationData.animationState[0] == IStatusManager.AnimatedState.Special1 || animationData.animationState[0] == IStatusManager.AnimatedState.Special2 || animationData.animationState[0] == IStatusManager.AnimatedState.Skill) && Singleton<GameRuntimeData>.Instance.settingTable.GetValue("镜头移动动画") == "开启";
						CS$<>8__locals1.originalScales = new Dictionary<StatusManager, Vector3>();
						for (int k = 0; k < animationData.status.Length; k++)
						{
							StatusManager status = animationData.status[k];
							status.transform.Find("body").GetComponent<SortingGroup>().sortingLayerName = "Default";
							bool flag8 = status.IsNull();
							if (!flag8)
							{
								int tempCount = this.activeTweens.GetValueOrDefault(status, 0);
								bool flag9 = isAnimated;
								if (flag9)
								{
									bool flag10 = !this.activeTweens.ContainsKey(status);
									if (flag10)
									{
										this.activeTweens[status] = 0;
									}
									Dictionary<StatusManager, int> dictionary = this.activeTweens;
									StatusManager status2 = status;
									int num = dictionary[status2];
									dictionary[status2] = num + 1;
									num = tempCount;
									tempCount = num + 1;
									status.transform.DOKill(false);
								}
								bool flag11 = animationData.status.Length == 1;
								if (flag11)
								{
									bool flag12 = animationData.animationState[k] != IStatusManager.AnimatedState.Attack && animationData.animationState[k] != IStatusManager.AnimatedState.Skill;
									if (flag12)
									{
										status.animatedState = animationData.animationState[k];
									}
									this.NowAnimation = false;
								}
								else
								{
									bool flag13 = isAnimated;
									if (flag13)
									{
										status.animatedState = animationData.animationState[k];
										CS$<>8__locals1.originalScales[status] = status.transform.localScale;
										IRole.AnimationConfig config = ((IRole)status.fatherObject).TryGetAnimationConfig(status.animatedState);
										bool flag14 = config != null;
										if (flag14)
										{
											bool flag15 = config.Direction == "Left";
											if (flag15)
											{
												status.transform.localScale = new Vector3((float)((status.fatherObject.Type == "Enemy") ? 1 : -1), 1f, 1f);
											}
											else
											{
												bool flag16 = config.Direction == "Right";
												if (flag16)
												{
													status.transform.localScale = new Vector3((float)(-1 * ((status.fatherObject.Type == "Enemy") ? 1 : -1)), 1f, 1f);
												}
											}
										}
										int count = animationData.status.Length;
										float y = Mathf.Lerp(0.5f, -0.5f, (float)k / (float)(count - 1)) * (float)((positions[0].x > 0f) ? -1 : 1) * 0.3f;
										bool flag17 = k == 0;
										if (flag17)
										{
											status.transform.position = new Vector3(-7f * (float)((positions[0].x > 0f) ? 1 : -1), 0f, 0f);
										}
										status.transform.Find("body").GetComponent<SortingGroup>().sortingOrder = 13;
										status.GetComponent<KeywordDisplay>().enabled = false;
										status.transform.DOMoveX(positions[k].x + 1f * (float)((positions[0].x > 0f) ? 1 : -1), 0.05f / CS$<>8__locals1.speedMultiplier, false).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										});
										status.transform.DOMoveX(positions[k].x, 0.3f, false).SetEase(Ease.OutSine).SetDelay(0.05f / CS$<>8__locals1.speedMultiplier).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										});
										status.transform.DOMoveX(positions[k].x + 1f * (float)((positions[0].x > 0f) ? -1 : 1), 0.45f / CS$<>8__locals1.speedMultiplier, false).SetEase(Ease.OutSine).SetDelay(0.35f / CS$<>8__locals1.speedMultiplier).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										});
										status.transform.DOMoveY(y, 0.05f / CS$<>8__locals1.speedMultiplier, false).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										});
										status.transform.DOMoveY(-0.1f * (float)((positions[0].x > 0f) ? -1 : 1) + y, 0.35f / CS$<>8__locals1.speedMultiplier, false).SetEase(Ease.OutSine).SetDelay(0.05f / CS$<>8__locals1.speedMultiplier).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										});
										status.transform.DOMoveY(-0.2f * (float)((positions[0].x > 0f) ? -1 : 1) + y, 0.45f / CS$<>8__locals1.speedMultiplier, false).SetEase(Ease.OutSine).SetDelay(0.35f / CS$<>8__locals1.speedMultiplier).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										});
										status.transform.DOMove(status.initPos, 0.24f / CS$<>8__locals1.speedMultiplier, false).OnKill(delegate
										{
											bool flag23 = status.IsNull();
											if (!flag23)
											{
												status.SetPosition(status.initPos);
											}
										}).SetDelay(0.8f / CS$<>8__locals1.speedMultiplier).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										});
										int targetPos = (CS$<>8__locals1.originalScales[status].x / status.transform.localScale.x > 0f) ? 1 : -1;
										status.transform.DOScale(new Vector3(CS$<>8__locals1.originalScales[status].x * (float)targetPos, CS$<>8__locals1.originalScales[status].y, CS$<>8__locals1.originalScales[status].z), 0.24f / CS$<>8__locals1.speedMultiplier).OnComplete(delegate
										{
											CS$<>8__locals1.<>4__this.NowAnimation = false;
											bool flag23 = status.IsNull();
											if (!flag23)
											{
												status.transform.Find("body").GetComponent<SortingGroup>().sortingOrder = ((IRole)status.fatherObject).GetAnimationLayer(status.animatedState);
												status.transform.Find("body").GetComponent<SortingGroup>().sortingLayerName = "role";
												status.animatedState = IStatusManager.AnimatedState.Idle;
												status.GetComponent<KeywordDisplay>().enabled = true;
											}
										}).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										}).OnKill(delegate
										{
											CS$<>8__locals1.<>4__this.NowAnimation = false;
											bool flag23 = status.IsNull();
											if (!flag23)
											{
												status.transform.Find("body").GetComponent<SortingGroup>().sortingOrder = ((IRole)status.fatherObject).GetAnimationLayer(status.animatedState);
												status.transform.localScale = CS$<>8__locals1.originalScales[status];
												bool flag24 = tempCount == CS$<>8__locals1.<>4__this.activeTweens.GetValueOrDefault(status, 0);
												if (flag24)
												{
													status.transform.Find("body").GetComponent<SortingGroup>().sortingLayerName = "role";
												}
												status.animatedState = IStatusManager.AnimatedState.Idle;
												status.GetComponent<KeywordDisplay>().enabled = true;
											}
										}).SetDelay(0.8f / CS$<>8__locals1.speedMultiplier);
										status.transform.DOScale(status.transform.localScale * 2f, 0.05f / CS$<>8__locals1.speedMultiplier).OnUpdate(delegate
										{
											bool flag23 = !status.IsNull();
											if (flag23)
											{
												status.UpdateObjPos();
											}
										});
									}
									else
									{
										bool flag18 = animationData.animationState[k] == IStatusManager.AnimatedState.Hit;
										if (flag18)
										{
											status.animatedState = animationData.animationState[k];
											status.transform.Find("body").GetComponent<SortingGroup>().sortingOrder = 13;
											status.transform.DOShakePosition(0.3f / CS$<>8__locals1.speedMultiplier, new Vector3(0.8f, 0.1f, 0f), 10, 90f, false, true, ShakeRandomnessMode.Full).OnUpdate(delegate
											{
												bool flag23 = !status.IsNull();
												if (flag23)
												{
													status.UpdateObjPos();
												}
											}).OnKill(delegate
											{
												bool flag23 = tempCount == CS$<>8__locals1.<>4__this.activeTweens.GetValueOrDefault(status, 0);
												if (flag23)
												{
													status.transform.Find("body").GetComponent<SortingGroup>().sortingLayerName = "role";
												}
												CS$<>8__locals1.<>4__this.NowAnimation = false;
												bool flag24 = status.IsNull();
												if (!flag24)
												{
													status.SetPosition(status.initPos);
													status.transform.Find("body").GetComponent<SortingGroup>().sortingOrder = ((IRole)status.fatherObject).GetAnimationLayer(status.animatedState);
													status.animatedState = IStatusManager.AnimatedState.Idle;
												}
											}).OnComplete(delegate
											{
												status.transform.Find("body").GetComponent<SortingGroup>().sortingLayerName = "role";
												CS$<>8__locals1.<>4__this.NowAnimation = false;
												status.SetPosition(status.initPos);
												status.transform.Find("body").GetComponent<SortingGroup>().sortingOrder = ((IRole)status.fatherObject).GetAnimationLayer(status.animatedState);
												status.animatedState = IStatusManager.AnimatedState.Idle;
											});
										}
										else
										{
											bool flag19 = animationData.animationState[k] != IStatusManager.AnimatedState.Attack && animationData.animationState[k] != IStatusManager.AnimatedState.Skill;
											if (flag19)
											{
												this.NowAnimation = false;
												status.animatedState = animationData.animationState[k];
												status.transform.Find("body").GetComponent<SortingGroup>().sortingLayerName = "role";
											}
											else
											{
												this.NowAnimation = false;
												status.transform.Find("body").GetComponent<SortingGroup>().sortingLayerName = "role";
											}
										}
									}
								}
							}
						}
						bool flag20 = !isAnimated;
						if (!flag20)
						{
							Material material = Resources.Load<Material>("Material/PostProcess/Blur");
							if (material != null)
							{
								material.EnableKeyword("_BLUR_ON");
							}
							bool flag21 = this.waitingTime > 0f;
							if (flag21)
							{
								this.waitingTime = 0f;
							}
							else
							{
								bool flag22 = !this.blurReturn;
								if (flag22)
								{
									UniTask.Create(delegate()
									{
										FightUI.<>c__DisplayClass105_0.<<DOActionAnimation>b__2>d <<DOActionAnimation>b__2>d = new FightUI.<>c__DisplayClass105_0.<<DOActionAnimation>b__2>d();
										<<DOActionAnimation>b__2>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
										<<DOActionAnimation>b__2>d.<>4__this = CS$<>8__locals1;
										<<DOActionAnimation>b__2>d.<>1__state = -1;
										<<DOActionAnimation>b__2>d.<>t__builder.Start<FightUI.<>c__DisplayClass105_0.<<DOActionAnimation>b__2>d>(ref <<DOActionAnimation>b__2>d);
										return <<DOActionAnimation>b__2>d.<>t__builder.Task;
									}).Forget();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x000C1F7C File Offset: 0x000C017C
		private void $Rougamo_DoCardUseAnimation(UseCard.CardUseData cardUseData)
		{
			CardItem cardItem = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load<GameObject>("UI/CardItem", true), base.transform.Find("CenterCardContainer")).AddComponent<CardItem>();
			cardItem.enabled = false;
			cardItem.GetComponent<ObjectGroup>().blocksRaycasts = false;
			cardItem.transform.Find("Trigger").gameObject.SetActive(false);
			cardItem.GetComponent<SortingGroup>().sortingOrder = -13;
			cardItem.cardcontainer = this.cardContainer;
			ICard.SetCardStyle(cardItem.transform, cardUseData.cardData);
			ICard.SetPureMsg(cardItem.transform, cardUseData.cardData);
			bool isBurning = cardUseData.isBurning;
			if (isBurning)
			{
				cardItem.EffectOfBurnCard();
			}
			else
			{
				cardItem.EffectOfThrowCard("Canvas/FightUI/ClockBoard/弃牌堆");
			}
		}

		// Token: 0x040011D6 RID: 4566
		private static WaitForSeconds _waitForSeconds1 = new WaitForSeconds(1f);

		// Token: 0x040011D7 RID: 4567
		public float Card_y_position;

		// Token: 0x040011D8 RID: 4568
		public static DataConfig LastCard;

		// Token: 0x040011D9 RID: 4569
		public bool started = false;

		// Token: 0x040011DA RID: 4570
		private int _cardTopCount;

		// Token: 0x040011DB RID: 4571
		public GameObject chest = null;

		// Token: 0x040011DC RID: 4572
		private System.Random random = new System.Random();

		// Token: 0x040011DD RID: 4573
		private Transform process;

		// Token: 0x040011DE RID: 4574
		public static List<CardItem> cardItemList = new List<CardItem>();

		// Token: 0x040011DF RID: 4575
		public static List<CardItem> SelectedCard = new List<CardItem>();

		/// <summary> 数字键选中的卡牌（按下视为拖动，松开或点击目标后打出）。 </summary>
		// Token: 0x040011E0 RID: 4576
		private CardItem _keyboardSelectedCard;

		// Token: 0x040011E1 RID: 4577
		private int _keyboardSelectedIndex = -1;

		// Token: 0x040011E2 RID: 4578
		public int ShouldCard;

		// Token: 0x040011E3 RID: 4579
		public CardContainer cardContainer;

		// Token: 0x040011E4 RID: 4580
		public CardContainer selectCardContainer;

		// Token: 0x040011E5 RID: 4581
		public List<StatusManager> StatusList = new List<StatusManager>();

		// Token: 0x040011E6 RID: 4582
		private float lastDisplayTime;

		// Token: 0x040011E7 RID: 4583
		private int maxDisplayPerSecond = 8;

		// Token: 0x040011E8 RID: 4584
		private const int DamageMergeThreshold = 8;

		// Token: 0x040011E9 RID: 4585
		private const int MaxDamagePopupsOnScreen = 20;

		// Token: 0x040011EA RID: 4586
		private const float DamagePopupLifetime = 2.5f;

		// Token: 0x040011EB RID: 4587
		private List<float> activeDamagePopupTimes = new List<float>();

		// Token: 0x040011EC RID: 4588
		private Queue<FightUI.DamageTextInfo> damageTextQueue = new Queue<FightUI.DamageTextInfo>();

		// Token: 0x040011ED RID: 4589
		[TupleElementNames(new string[]
		{
			"text",
			"time"
		})]
		public Dictionary<StatusManager, ValueTuple<PopUpTextUI, float>> totalDamageText = new Dictionary<StatusManager, ValueTuple<PopUpTextUI, float>>();

		// Token: 0x040011EE RID: 4590
		[TupleElementNames(new string[]
		{
			"text",
			"time"
		})]
		private List<KeyValuePair<StatusManager, ValueTuple<PopUpTextUI, float>>> _totalDamageSnapshot = new List<KeyValuePair<StatusManager, ValueTuple<PopUpTextUI, float>>>();

		// Token: 0x040011EF RID: 4591
		public int hasTime;

		// Token: 0x040011F0 RID: 4592
		private Sequence processTween;

		// Token: 0x040011F1 RID: 4593
		public bool autoCard = false;

		// Token: 0x040011F2 RID: 4594
		public Transform transform1;

		// Token: 0x040011F3 RID: 4595
		public Transform endfight;

		// Token: 0x040011F4 RID: 4596
		public Transform FightAgain;

		// Token: 0x040011F5 RID: 4597
		public Transform UsedCardList;

		// Token: 0x040011F6 RID: 4598
		public ButtonManager turnButton;

		// Token: 0x040011F7 RID: 4599
		public static bool IsReset = false;

		// Token: 0x040011F8 RID: 4600
		private List<SkillItem> skillItems = new List<SkillItem>();

		// Token: 0x040011F9 RID: 4601
		private bool quickReset = false;

		// Token: 0x040011FA RID: 4602
		private Queue<DataConfig> createCardQueue = new Queue<DataConfig>();

		// Token: 0x040011FB RID: 4603
		private TMP_Text Title;

		// Token: 0x040011FC RID: 4604
		public static int SpecialCount;

		// Token: 0x040011FD RID: 4605
		public GameObject instance;

		// Token: 0x040011FE RID: 4606
		private GameObject prefabA;

		// Token: 0x040011FF RID: 4607
		public static bool InIEn;

		// Token: 0x04001200 RID: 4608
		public static string SelectType;

		// Token: 0x04001201 RID: 4609
		private bool isWin;

		// Token: 0x04001202 RID: 4610
		private bool ShowReward = true;

		// Token: 0x04001203 RID: 4611
		public Queue<FightUI.AnimationData> animationQueue = new Queue<FightUI.AnimationData>();

		// Token: 0x04001204 RID: 4612
		private float waitingTime;

		// Token: 0x04001205 RID: 4613
		public bool blurReturn;

		// Token: 0x04001206 RID: 4614
		public bool NowAnimation;

		// Token: 0x04001207 RID: 4615
		private Dictionary<StatusManager, int> activeTweens = new Dictionary<StatusManager, int>();

		// Token: 0x020002E2 RID: 738
		private class DamageTextInfo
		{
			// Token: 0x04001208 RID: 4616
			public string text;

			// Token: 0x04001209 RID: 4617
			public Vector2 position;

			// Token: 0x0400120A RID: 4618
			public string popUpType;

			// Token: 0x0400120B RID: 4619
			public StatusManager status;

			// Token: 0x0400120C RID: 4620
			public StatusManager to;

			// Token: 0x0400120D RID: 4621
			public string realDamage;
		}

		// Token: 0x020002E3 RID: 739
		public struct AnimationData
		{
			// Token: 0x06001756 RID: 5974 RVA: 0x000C2044 File Offset: 0x000C0244
			public AnimationData(ActionAnimation.AnimationData data)
			{
				this.status = data.status.AsValueEnumerable<string>().Select(delegate(string x)
				{
					FightManager instance = FightManager.Instance;
					return (instance != null) ? instance.statuses.GetValueOrDefault(x, null) : null;
				}).ToArray<string, StatusManager>();
				this.animationState = data.animationState;
				this.effectName = data.effectName;
			}

			// Token: 0x0400120E RID: 4622
			public StatusManager[] status;

			// Token: 0x0400120F RID: 4623
			public IStatusManager.AnimatedState[] animationState;

			// Token: 0x04001210 RID: 4624
			public string effectName;
		}
	}
}

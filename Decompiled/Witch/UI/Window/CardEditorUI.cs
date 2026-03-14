using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using DataEditor.CardEditor;
using Michsky.MUIP;
using Newtonsoft.Json;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x020002AA RID: 682
	public class CardEditorUI : UIBase
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x000AA58C File Offset: 0x000A878C
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x000AA6D0 File Offset: 0x000A88D0
		public int cost
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
				methodContext.TargetType = typeof(CardEditorUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.get_cost()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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
								num = this.$Rougamo_get_cost();
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
				methodContext.TargetType = typeof(CardEditorUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.set_cost(int)).MethodHandle, typeof(CardEditorUI).TypeHandle);
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
								this.$Rougamo_set_cost(value);
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

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x000AA80C File Offset: 0x000A8A0C
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x000AA950 File Offset: 0x000A8B50
		public int total
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
				methodContext.TargetType = typeof(CardEditorUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.get_total()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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
								num = this.$Rougamo_get_total();
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
				methodContext.TargetType = typeof(CardEditorUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.set_total(int)).MethodHandle, typeof(CardEditorUI).TypeHandle);
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
								this.$Rougamo_set_total(value);
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

		// Token: 0x0600156D RID: 5485 RVA: 0x000AAA8C File Offset: 0x000A8C8C
		public void UpdateTotal()
		{
			Transform content = base.transform.Find("MsgContent");
			this.thisRatity = int.Parse(content.Find("rarityContent/Toggle Group").GetComponent<ToggleGroup>().GetFirstActiveToggle().name);
			Transform ModalCard = content.Find("ModalCard");
			try
			{
				int power = int.Parse(content.Find("powerContent/Toggle Group").GetComponent<ToggleGroup>().GetFirstActiveToggle().name);
				this.isBurnout = content.Find("isBurnout/Switch").GetComponent<SwitchManager>().isOn;
				this.isTarget = content.Find("isTarget/Switch").GetComponent<SwitchManager>().isOn;
				this.total = Mathf.CeilToInt((float)(70 + 50 * ((power > 4) ? 3 : (power - 1)) + this.thisRatity * 40) * (this.isBurnout ? 1.3f : 1f));
				this.rarity = content.Find("rarityContent/Toggle Group").GetComponent<ToggleGroup>().GetFirstActiveToggle().name;
				bool flag = this.rarity == "3";
				if (flag)
				{
					ModalCard.Find("Front/rarity").gameObject.SetActive(true);
					ModalCard.Find("Front/rarity").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/三阶修饰", true);
					ModalCard.Find("Front/background").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/底面二三阶", true);
					ModalCard.Find("Front/titleFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/标题框二三阶", true);
					ModalCard.Find("Front/iconFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/卡面信息框三阶", true);
					ModalCard.Find("Front/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/费用框三阶", true);
				}
				else
				{
					bool flag2 = this.rarity == "2";
					if (flag2)
					{
						ModalCard.Find("Front/rarity").gameObject.SetActive(true);
						ModalCard.Find("Front/rarity").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/二阶修饰", true);
						ModalCard.Find("Front/background").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/底面二三阶", true);
						ModalCard.Find("Front/titleFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/标题框二三阶", true);
						ModalCard.Find("Front/iconFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/卡面信息框一二阶", true);
						ModalCard.Find("Front/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/费用框一二阶", true);
					}
					else
					{
						ModalCard.Find("Front/rarity").gameObject.SetActive(false);
						ModalCard.Find("Front/background").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/底面一阶", true);
						ModalCard.Find("Front/titleFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/标题框一阶", true);
						ModalCard.Find("Front/iconFrame").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/卡面信息框一二阶", true);
						ModalCard.Find("Front/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/NewTemplate/费用框一二阶", true);
					}
				}
				ModalCard.Find("Front/cost/cost").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>("Icon/CardTemplate/Template/费用数字/" + power.ToString(), true);
				ModalCard.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().text = content.Find("nameContent/InputField").GetComponent<TMP_InputField>().text;
			}
			catch (Exception e)
			{
				bool flag3 = content.Find("rarityContent/Toggle Group").GetComponent<ToggleGroup>().GetFirstActiveToggle() == null;
				if (flag3)
				{
					Debug.LogError("请先选择卡牌稀有度！");
				}
				else
				{
					Debug.Log(content.Find("rarityContent/Toggle Group").GetComponent<ToggleGroup>().GetFirstActiveToggle().name);
					Debug.Log(e);
				}
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000AAEB8 File Offset: 0x000A90B8
		[DebuggerStepThrough]
		public void UpdateSprite()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.UpdateSprite()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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
							this.$Rougamo_UpdateSprite();
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

		// Token: 0x0600156F RID: 5487 RVA: 0x000AAFB4 File Offset: 0x000A91B4
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
			methodContext.TargetType = typeof(CardEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.Awake()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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

		// Token: 0x06001570 RID: 5488 RVA: 0x000AB0B0 File Offset: 0x000A92B0
		[DebuggerStepThrough]
		public override void OnEnable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.OnEnable()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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
							this.$Rougamo_OnEnable();
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

		// Token: 0x06001571 RID: 5489 RVA: 0x000AB1AC File Offset: 0x000A93AC
		public void UpdateBuff()
		{
			RectTransform BuffList = base.transform.Find("EffectList/buffList") as RectTransform;
			this.collection = (from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Buff).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"]) && !x["Id"].Contains("SpecialBuff_") && x["Type"] != "指示物" && x["Type"] != "技能"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			this.onepageCount = 24;
			for (int i = 0; i < 2; i++)
			{
				List<Dictionary<string, string>> list = new List<Dictionary<string, string>>(this.collection);
				int startIndex = i * this.onepageCount;
				list = list.GetRange(startIndex, Math.Min(this.onepageCount, list.Count - startIndex));
				foreach (Dictionary<string, string> item in list)
				{
					GameObject obj = Singleton<ObjectPool>.Instance.Get(BuffList.GetChild(i).Find("tempitem").gameObject, BuffList.GetChild(i));
					obj.SetActive(true);
					Sprite icon = ResourceLoader.Load<Sprite>(item["Icon"], true);
					bool flag = icon == null;
					if (flag)
					{
						icon = ResourceLoader.Load<Sprite>("Icon/Buff/占位符", true);
					}
					obj.GetComponent<Image>().sprite = icon;
					obj.GetComponent<CardEffectBuff>().data = item;
					obj.transform.Find("text").GetComponent<TextMeshProUGUI>().text = item["Name"].Substring(0, 2);
					bool flag2 = this.baseBuff == null;
					if (flag2)
					{
						this.baseBuff = obj.GetComponent<CardEffectBuff>();
					}
				}
			}
			BuffList.GetComponent<Image>().SetNativeSize();
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x000AB38C File Offset: 0x000A958C
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
			methodContext.TargetType = typeof(CardEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.Start()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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

		// Token: 0x06001573 RID: 5491 RVA: 0x000AB488 File Offset: 0x000A9688
		[DebuggerStepThrough]
		public void InitTime()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.InitTime()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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
							this.$Rougamo_InitTime();
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

		// Token: 0x06001574 RID: 5492 RVA: 0x000AB584 File Offset: 0x000A9784
		[DebuggerStepThrough]
		public void InitTimeAgain()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.InitTimeAgain()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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
							this.$Rougamo_InitTimeAgain();
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

		// Token: 0x06001575 RID: 5493 RVA: 0x000AB680 File Offset: 0x000A9880
		private void Init(FloatingWindow.button fatherButton, string scriptName)
		{
			CardEditorUI.<>c__DisplayClass30_0 CS$<>8__locals1 = new CardEditorUI.<>c__DisplayClass30_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.scriptName = scriptName;
			MethodInfo[] methodInfo = typeof(CardEditorBase).GetMethods(BindingFlags.Static | BindingFlags.Public);
			MethodInfo[] array = methodInfo;
			for (int i = 0; i < array.Length; i++)
			{
				CardEditorUI.<>c__DisplayClass30_1 CS$<>8__locals2 = new CardEditorUI.<>c__DisplayClass30_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.info = array[i];
				CardEditorUI.<>c__DisplayClass30_2 CS$<>8__locals3 = new CardEditorUI.<>c__DisplayClass30_2();
				CS$<>8__locals3.CS$<>8__locals2 = CS$<>8__locals2;
				bool isSpecialName = CS$<>8__locals3.CS$<>8__locals2.info.IsSpecialName;
				if (!isSpecialName)
				{
					CS$<>8__locals3.effectName = "";
					CS$<>8__locals3.effectDes = "";
					CardEditorUI.<>c__DisplayClass30_2 CS$<>8__locals4 = CS$<>8__locals3;
					EffectLimit customAttribute = CS$<>8__locals3.CS$<>8__locals2.info.GetCustomAttribute<EffectLimit>();
					CS$<>8__locals4.limit = ((customAttribute != null) ? customAttribute.limit : -1);
					bool flag = CS$<>8__locals3.CS$<>8__locals2.info.GetCustomAttribute<EffectName>() == null || CS$<>8__locals3.CS$<>8__locals2.info.GetCustomAttribute<EffectDes>() == null;
					if (!flag)
					{
						try
						{
							CS$<>8__locals3.effectName = CS$<>8__locals3.CS$<>8__locals2.info.GetCustomAttribute<EffectName>().text;
							CS$<>8__locals3.effectDes = CS$<>8__locals3.CS$<>8__locals2.info.GetCustomAttribute<EffectDes>().text;
						}
						catch (Exception e)
						{
							Debug.Log(e);
							goto IL_230;
						}
						bool flag2 = CS$<>8__locals3.CS$<>8__locals2.info.Name == "GetTime" || (CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.scriptName != "InitScript" && CS$<>8__locals3.CS$<>8__locals2.info.Name == "SetCardType");
						if (!flag2)
						{
							FloatingWindow.button subMenuItem = new FloatingWindow.button
							{
								name = CS$<>8__locals3.effectName,
								subButtons = new List<FloatingWindow.button>()
							};
							subMenuItem.action = delegate()
							{
								bool flag4 = !CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.MethodCount.ContainsKey(CS$<>8__locals3.CS$<>8__locals2.info.Name);
								if (flag4)
								{
									CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.MethodCount.Add(CS$<>8__locals3.CS$<>8__locals2.info.Name, 0);
								}
								bool flag5 = CS$<>8__locals3.limit != -1 && CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.MethodCount[CS$<>8__locals3.CS$<>8__locals2.info.Name] >= CS$<>8__locals3.limit;
								if (flag5)
								{
									UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("该效果已达到上限！", CaptionStyle.Top, 1f, 3f, 3);
								}
								else
								{
									bool flag6 = CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.lastFrom != CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.scriptName;
									if (flag6)
									{
										CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.lastFrom = CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.scriptName;
										CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.CreateTimeItem(CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.scriptName);
									}
									GameObject item = UnityEngine.Object.Instantiate<GameObject>(CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.itemPrefab1, CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.itemPrefab1.transform.parent);
									item.AddComponent<CardEffectItem>();
									CardEffectItem effectItem = item.GetComponent<CardEffectItem>();
									effectItem.sourceName = CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.scriptName;
									effectItem.effectName = CS$<>8__locals3.effectName;
									effectItem.effectDes = CS$<>8__locals3.effectDes;
									effectItem.methodName = CS$<>8__locals3.CS$<>8__locals2.info.Name;
									effectItem.cardEditorUI = CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this;
									effectItem.costMultiplier = ((CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.scriptName == "UseScript") ? 1f : 2f);
									effectItem.CreateDescription();
									Dictionary<string, int> methodCount = CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.MethodCount;
									string name = CS$<>8__locals3.CS$<>8__locals2.info.Name;
									int num = methodCount[name];
									methodCount[name] = num + 1;
									item.SetActive(true);
									bool flag7 = CS$<>8__locals3.effectName.Contains("buff");
									if (flag7)
									{
										CardEffectBuff.NowItem = item.GetComponent<CardEffectItem>();
										item.GetComponent<CardEffectItem>().IsBuff();
										CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.<>4__this.baseBuff.SetData();
									}
								}
							};
							fatherButton.subButtons.Add(subMenuItem);
							bool flag3 = CS$<>8__locals3.CS$<>8__locals2.CS$<>8__locals1.scriptName == "UseScript" && CS$<>8__locals3.CS$<>8__locals2.info.Name == "SetStatus";
							if (flag3)
							{
								subMenuItem.action();
							}
						}
					}
				}
				IL_230:;
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000AB8DC File Offset: 0x000A9ADC
		[DebuggerStepThrough]
		public void CreateTimeItem(string InitTime)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CardEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.CreateTimeItem(string)).MethodHandle, typeof(CardEditorUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				InitTime
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
							InitTime = null;
						}
						else
						{
							InitTime = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateTimeItem(InitTime);
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
		/// 生成卡牌，并进行预编译
		/// </summary>
		/// <returns></returns>
		// Token: 0x06001577 RID: 5495 RVA: 0x000ABA10 File Offset: 0x000A9C10
		private DataConfig GenerateCard()
		{
			Dictionary<string, string> scripts = new Dictionary<string, string>();
			Dictionary<string, string> data = new Dictionary<string, string>();
			Dictionary<string, string> Vars = new Dictionary<string, string>();
			Transform content = base.transform.Find("MsgContent");
			scripts.Add("InitScript", "");
			scripts.Add("UseScript", "");
			scripts.Add("DrawScript", "");
			scripts.Add("DropScript", "");
			int i = 1;
			data["Id"] = i.ToString();
			Vars["Id"] = i.ToString();
			data["Name"] = content.Find("nameContent/InputField").GetComponent<TMP_InputField>().text;
			bool flag = this.isTarget;
			if (flag)
			{
				scripts["InitScript"] = "self.Vars:set_Item(\"BaseScript\", \"AttackCardItem\");";
			}
			else
			{
				scripts["InitScript"] = "self.Vars:set_Item(\"BaseScript\", \"CommonCardItem\");";
			}
			CardEffectItem[] items = this.itemPrefab1.transform.parent.GetComponentsInChildren<CardEffectItem>();
			foreach (CardEffectItem item in items)
			{
				string script = item.RunMethod().Item1;
				Dictionary<string, string> dictionary = scripts;
				string sourceName = item.sourceName;
				dictionary[sourceName] += script;
				MethodInfo method = typeof(CardEditorBase).GetMethod(item.methodName);
				bool flag2 = ((method != null) ? method.GetCustomAttribute<AddDesVal>() : null) == null;
				if (!flag2)
				{
					MethodInfo method2 = typeof(CardEditorBase).GetMethod(item.methodName);
					string desval = (method2 != null) ? method2.GetCustomAttribute<AddDesVal>().text : null;
					foreach (KeyValuePair<string, string> var in item.vars)
					{
						desval = desval.Replace("{" + var.Key + "}", var.Value);
					}
					dictionary = scripts;
					dictionary["InitScript"] = string.Concat(new string[]
					{
						dictionary["InitScript"],
						"self.Vars:set_Item(\"DesVal",
						(item.desValIndex + 1).ToString(),
						"\", ",
						desval,
						");"
					});
				}
			}
			for (int j = 0; j < 3; j++)
			{
				data[this.names[j]] = scripts[this.names[j]];
			}
			data["InitScript"] = scripts["InitScript"];
			data["Expend"] = content.Find("powerContent/Toggle Group").GetComponent<ToggleGroup>().GetFirstActiveToggle().transform.name;
			data["Tag"] = "";
			bool flag3 = this.isBurnout;
			if (flag3)
			{
				data["Tag"] = "Burnout, ";
			}
			Vars["Tag"] = data["Tag"];
			data["Rarity"] = this.rarity;
			data["Note"] = "";
			data["Icon"] = CardEditorUI.IndexSprite[content.Find("styleContent/Horizontal Selector").GetComponent<HorizontalSelector>().label.text];
			data["Type"] = content.Find("typeContent/Horizontal Selector").GetComponent<HorizontalSelector>().label.text;
			data["Description"] = content.Find("descriptionContent/InputField").GetComponent<TMP_InputField>().text;
			data["Effects"] = "";
			Vars["RawData"] = Convert.ToBase64String(GZip.CompressString(JsonConvert.SerializeObject(data)));
			return new DataConfig(data, Vars, true);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000ABE2C File Offset: 0x000AA02C
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
			methodContext.TargetType = typeof(CardEditorUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CardEditorUI.OnDestroy()).MethodHandle, typeof(CardEditorUI).TypeHandle);
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

		// Token: 0x0600157D RID: 5501 RVA: 0x000AC05A File Offset: 0x000AA25A
		private int $Rougamo_get_cost()
		{
			return this._cost;
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x000AC064 File Offset: 0x000AA264
		private void $Rougamo_set_cost(int value)
		{
			bool isEditor = Application.isEditor;
			if (isEditor)
			{
				value = 0;
			}
			this._cost = value;
			base.transform.Find("Cost/cost").GetComponent<TextMeshProUGUI>().text = value.ToString();
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000AC0A9 File Offset: 0x000AA2A9
		private int $Rougamo_get_total()
		{
			return this._total;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000AC0B1 File Offset: 0x000AA2B1
		private void $Rougamo_set_total(int value)
		{
			this._total = value;
			base.transform.Find("Cost/total").GetComponent<TextMeshProUGUI>().text = value.ToString();
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000AC0E0 File Offset: 0x000AA2E0
		private void $Rougamo_UpdateSprite()
		{
			base.transform.Find("MsgContent/ModalCard/Front/icon").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(CardEditorUI.IndexSprite[base.transform.Find("MsgContent/styleContent/Horizontal Selector").GetComponent<HorizontalSelector>().label.text], true);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000AC138 File Offset: 0x000AA338
		private void $Rougamo_Awake()
		{
			base.transform.Find("EffectList").gameObject.AddComponent<ChangeFloatWindow>();
			base.transform.Find("Confirm").GetComponent<ButtonManager>().onClick.AddListener(delegate
			{
				bool flag = this.cost > this.total;
				if (flag)
				{
					UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("卡牌效果花费超过总花费！", CaptionStyle.Top, 1f, 3f, 3);
				}
				else
				{
					DataConfig dataConfig = this.GenerateCard();
					this.onEdited(dataConfig);
					UIManager.Instance.GetFloatingWindow().Hide();
					this.Close();
				}
			});
			this.itemPrefab1 = base.transform.Find("EffectList/Scroll Area/List/Item1").gameObject;
			this.InitTime();
			TMP_InputField msg = base.transform.Find("MsgContent/descriptionContent/InputField").GetComponent<TMP_InputField>();
			msg.onValueChanged.AddListener(delegate(string value)
			{
				base.transform.Find("MsgContent/ModalCard/Front/字体/msgTxt").GetComponent<TMP_Text>().text = Singleton<TextTranslator>.Instance.Translate(value, new List<string>());
			});
			CardEditorUI.IndexSprite.TryAdd("样式1", "Icon/Card/法杖敲头");
			CardEditorUI.IndexSprite.TryAdd("样式2", "Icon/Card/双刃剑盾");
			CardEditorUI.IndexSprite.TryAdd("样式3", "Icon/Card/禁果");
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x000AC21C File Offset: 0x000AA41C
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.UpdateBuff();
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000AC22D File Offset: 0x000AA42D
		private void $Rougamo_Start()
		{
			this.UpdateTotal();
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000AC238 File Offset: 0x000AA438
		private void $Rougamo_InitTime()
		{
			FloatingWindow floatingWindow = UIManager.Instance.GetFloatingWindow();
			floatingWindow.Clear();
			for (int i = 0; i < 3; i++)
			{
				floatingWindow.AddButton(this.des[i], delegate()
				{
				}, null);
				List<FloatingWindow.button> list = floatingWindow.buttons;
				this.Init(list[list.Count - 1], this.names[i]);
				List<FloatingWindow.button> list2 = this.buttons;
				List<FloatingWindow.button> list3 = floatingWindow.buttons;
				list2.Add(list3[list3.Count - 1]);
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000AC2DC File Offset: 0x000AA4DC
		private void $Rougamo_InitTimeAgain()
		{
			FloatingWindow floatingWindow = UIManager.Instance.GetFloatingWindow();
			floatingWindow.Clear();
			for (int i = 0; i < 3; i++)
			{
				floatingWindow.AddButton(this.buttons[i]);
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000AC324 File Offset: 0x000AA524
		private void $Rougamo_CreateTimeItem(string InitTime)
		{
			MethodInfo info = typeof(CardEditorBase).GetMethod("GetTime", BindingFlags.Static | BindingFlags.Public);
			string effectName = info.GetCustomAttribute<EffectName>().text;
			string effectDes = info.GetCustomAttribute<EffectDes>().text;
			GameObject item = UnityEngine.Object.Instantiate<GameObject>(this.itemPrefab1, this.itemPrefab1.transform.parent);
			item.transform.Find("Content/texts/description/Toggle Group/Prefab").GetComponent<Toggle>().interactable = false;
			item.AddComponent<CardEffectItem>();
			CardEffectItem effectItem = item.GetComponent<CardEffectItem>();
			effectItem.sourceName = InitTime;
			effectItem.effectName = effectName;
			effectItem.effectDes = effectDes;
			effectItem.methodName = info.Name;
			effectItem.cardEditorUI = this;
			effectItem.costMultiplier = ((InitTime == "UseScript") ? 1f : 2f);
			effectItem.CreateTimeDes();
			item.SetActive(true);
			item.transform.Find("Delete").gameObject.SetActive(false);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000AC421 File Offset: 0x000AA621
		private void $Rougamo_OnDestroy()
		{
			base.OnDestroy();
			UIManager.Instance.GetFloatingWindow().Clear();
			HouseUI.CanScroll = true;
		}

		// Token: 0x040010FA RID: 4346
		public Dictionary<string, int> MethodCount = new Dictionary<string, int>();

		// Token: 0x040010FB RID: 4347
		private string[] names = new string[]
		{
			"DrawScript",
			"UseScript",
			"DropScript"
		};

		// Token: 0x040010FC RID: 4348
		private string[] des = new string[]
		{
			"抽牌时",
			"使用时",
			"弃牌时"
		};

		// Token: 0x040010FD RID: 4349
		private bool isTarget;

		// Token: 0x040010FE RID: 4350
		private int _cost;

		// Token: 0x040010FF RID: 4351
		private int _total;

		// Token: 0x04001100 RID: 4352
		private bool isBurnout;

		// Token: 0x04001101 RID: 4353
		public Action<DataConfig> onEdited;

		// Token: 0x04001102 RID: 4354
		public int onepageCount;

		// Token: 0x04001103 RID: 4355
		public static Dictionary<string, string> IndexSprite = new Dictionary<string, string>();

		// Token: 0x04001104 RID: 4356
		public int thisRatity;

		// Token: 0x04001105 RID: 4357
		public List<Dictionary<string, string>> collection;

		// Token: 0x04001106 RID: 4358
		public GameObject itemPrefab1;

		// Token: 0x04001107 RID: 4359
		private CardEffectBuff baseBuff = null;

		// Token: 0x04001108 RID: 4360
		public List<FloatingWindow.button> buttons = new List<FloatingWindow.button>();

		// Token: 0x04001109 RID: 4361
		private string lastFrom = "";

		// Token: 0x0400110A RID: 4362
		public string rarity;
	}
}

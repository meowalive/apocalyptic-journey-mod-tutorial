using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x020002BF RID: 703
	public class DeckUI : UIBase
	{
		// Token: 0x060015E7 RID: 5607 RVA: 0x000B0648 File Offset: 0x000AE848
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
			methodContext.TargetType = typeof(DeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DeckUI.Awake()).MethodHandle, typeof(DeckUI).TypeHandle);
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

		// Token: 0x060015E8 RID: 5608 RVA: 0x000B0744 File Offset: 0x000AE944
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
			methodContext.TargetType = typeof(DeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DeckUI.OnEnable()).MethodHandle, typeof(DeckUI).TypeHandle);
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

		// Token: 0x060015E9 RID: 5609 RVA: 0x000B0840 File Offset: 0x000AEA40
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
			methodContext.TargetType = typeof(DeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DeckUI.CreateDeckMenu()).MethodHandle, typeof(DeckUI).TypeHandle);
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

		// Token: 0x060015EA RID: 5610 RVA: 0x000B093C File Offset: 0x000AEB3C
		[DebuggerStepThrough]
		public void CreateUsedDeckMenu()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DeckUI.CreateUsedDeckMenu()).MethodHandle, typeof(DeckUI).TypeHandle);
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
							this.$Rougamo_CreateUsedDeckMenu();
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

		// Token: 0x060015EB RID: 5611 RVA: 0x000B0A38 File Offset: 0x000AEC38
		[DebuggerStepThrough]
		public void CreateDeckMenuForSelect(int count, List<IDataConfig> DataConfigList, List<IDataConfig> SourceList)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DeckUI.CreateDeckMenuForSelect(int, List<IDataConfig>, List<IDataConfig>)).MethodHandle, typeof(DeckUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				count,
				DataConfigList,
				SourceList
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
						if (arguments[1] == null)
						{
							DataConfigList = null;
						}
						else
						{
							DataConfigList = (List<IDataConfig>)arguments[1];
						}
						if (arguments[2] == null)
						{
							SourceList = null;
						}
						else
						{
							SourceList = (List<IDataConfig>)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateDeckMenuForSelect(count, DataConfigList, SourceList);
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
								goto IL_145;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_145:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000B0BB4 File Offset: 0x000AEDB4
		private void $Rougamo_Awake()
		{
			this.windowManager = base.transform.Find("Window Manager").GetComponent<WindowManager>();
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_OnEnable()
		{
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000B0BD4 File Offset: 0x000AEDD4
		private void $Rougamo_CreateDeckMenu()
		{
			this.windowManager.OpenWindowByIndex(0);
			this.Description = base.transform.Find("Window Manager/Windows/抽牌堆/Content/Description").GetComponent<TMP_Text>();
			this.cardList = base.transform.Find("Window Manager/Windows/抽牌堆/Content/List View Custom/Scroll Area/List").GetComponent<RectTransform>();
			this.Description.text = "The cards that will be drawn are here".Localize("DeckUI");
			for (int i = 0; i < FightCardManager.Instance.cardList.Count; i++)
			{
				Transform content = UnityEngine.Object.Instantiate<Transform>(this.cardList.Find("card"), this.cardList);
				content.gameObject.SetActive(true);
				GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/DisplayCard"), content) as GameObject;
				obj.transform.Find("Front").localScale = Vector3.one * 2f;
				DataConfig dataConfig = FightCardManager.Instance.cardList[i];
				DisplayCard item = obj.AddComponent<DisplayCard>();
				item.NormalScale = 0.6f;
				item.CurrentScale = 0.7f;
				item.Init(dataConfig);
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000B0D08 File Offset: 0x000AEF08
		private void $Rougamo_CreateUsedDeckMenu()
		{
			this.windowManager.OpenWindowByIndex(1);
			this.Description = base.transform.Find("Window Manager/Windows/弃牌堆/Content/Description").GetComponent<TMP_Text>();
			this.cardList = base.transform.Find("Window Manager/Windows/弃牌堆/Content/List View Custom/Scroll Area/List").GetComponent<RectTransform>();
			this.Description.text = "Cards that have been discarded are here".Localize("DeckUI");
			for (int i = 0; i < FightCardManager.Instance.usedCardList.Count; i++)
			{
				Transform content = UnityEngine.Object.Instantiate<Transform>(this.cardList.Find("card"), this.cardList);
				content.gameObject.SetActive(true);
				GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/DisplayCard"), content) as GameObject;
				DataConfig dataConfig = FightCardManager.Instance.usedCardList[i];
				obj.transform.Find("Front").localScale = Vector3.one * 2f;
				DisplayCard item = obj.AddComponent<DisplayCard>();
				item.NormalScale = 0.6f;
				item.CurrentScale = 0.7f;
				item.Init(dataConfig);
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000B0E3C File Offset: 0x000AF03C
		private void $Rougamo_CreateDeckMenuForSelect(int count, List<IDataConfig> DataConfigList, List<IDataConfig> SourceList)
		{
			base.transform.Find("Window Manager/Buttons/抽牌堆").gameObject.SetActive(false);
			base.transform.Find("Window Manager/Buttons/弃牌堆").gameObject.SetActive(false);
			base.transform.Find("Window Manager/Buttons/新牌堆").gameObject.SetActive(true);
			this.windowManager.OpenWindowByIndex(2);
			this.Description = base.transform.Find("Window Manager/Windows/新牌堆/Content/Description").GetComponent<TMP_Text>();
			this.cardList = base.transform.Find("Window Manager/Windows/新牌堆/Content/List View Custom/Scroll Area/List").GetComponent<RectTransform>();
			base.transform.Find("Window Manager/Close").gameObject.SetActive(false);
			this.Description.text = "Please Choose".Localize("DeckUI") + count.ToString() + "X Cards".Localize("DeckUI");
			for (int i = 0; i < SourceList.Count; i++)
			{
				Transform content = UnityEngine.Object.Instantiate<Transform>(this.cardList.Find("card"), this.cardList);
				content.gameObject.SetActive(true);
				GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/DisplayCard"), content) as GameObject;
				obj.transform.Find("Front").localScale = Vector3.one * 2f;
				obj.name = "DisplayCard";
				IDataConfig dataConfig = SourceList[i];
				DisplayCard item = obj.AddComponent<DisplayCard>();
				item.NormalScale = 0.6f;
				item.CurrentScale = 0.7f;
				item.Init(dataConfig as DataConfig);
				content.GetComponent<ButtonManager>().onClick.AddListener(delegate
				{
					bool isSelect = item.isSelect;
					if (isSelect)
					{
						DataConfigList.Remove(dataConfig);
						item.OnUnSelect();
					}
					else
					{
						item.OnSelect();
						DataConfigList.Add(dataConfig);
						bool flag = DataConfigList.Count == count;
						if (flag)
						{
							this.Close();
							Singleton<EventCenter>.Instance.EventTrigger("SelectCardEnd");
						}
					}
					this.Description.text = "请选择" + (count - DataConfigList.Count).ToString() + "张牌";
				});
			}
		}

		// Token: 0x04001153 RID: 4435
		private TMP_Text Description;

		// Token: 0x04001154 RID: 4436
		private RectTransform cardList;

		// Token: 0x04001155 RID: 4437
		private WindowManager windowManager;
	}
}

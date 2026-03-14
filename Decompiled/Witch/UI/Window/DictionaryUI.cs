using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Michsky.MUIP;
using Microsoft.IdentityModel.Tokens;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x020002D3 RID: 723
	public class DictionaryUI : UIBase
	{
		// Token: 0x06001650 RID: 5712 RVA: 0x000B42E8 File Offset: 0x000B24E8
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
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.DataUpdate()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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

		// Token: 0x06001651 RID: 5713 RVA: 0x000B43E4 File Offset: 0x000B25E4
		[DebuggerStepThrough]
		public void Retrieve()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.Retrieve()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_Retrieve();
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

		// Token: 0x06001652 RID: 5714 RVA: 0x000B44E0 File Offset: 0x000B26E0
		private void Update()
		{
			bool wasPressedThisFrame = Keyboard.current.enterKey.wasPressedThisFrame;
			if (wasPressedThisFrame)
			{
				this.Retrieve();
			}
			else
			{
				bool wasPressedThisFrame2 = Keyboard.current.upArrowKey.wasPressedThisFrame;
				if (wasPressedThisFrame2)
				{
					this.inputField.text = this.LastCommand();
				}
				else
				{
					bool wasPressedThisFrame3 = Keyboard.current.downArrowKey.wasPressedThisFrame;
					if (wasPressedThisFrame3)
					{
						this.inputField.text = this.NextCommand();
					}
					else
					{
						bool flag = this.searchEd && this.inputField.text == "";
						if (flag)
						{
							this.searchEd = false;
							foreach (object obj in this.CardList)
							{
								Transform item = (Transform)obj;
								bool flag2 = item.name == "Item";
								if (!flag2)
								{
									item.gameObject.SetActive(true);
								}
							}
							this.ReturnList();
						}
					}
				}
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000B4614 File Offset: 0x000B2814
		[DebuggerStepThrough]
		public void ReturnList()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.ReturnList()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_ReturnList();
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

		// Token: 0x06001654 RID: 5716 RVA: 0x000B4710 File Offset: 0x000B2910
		[DebuggerStepThrough]
		public string LastCommand()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.LastCommand()).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[0];
			string text;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					text = (string)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							text = this.$Rougamo_LastCommand();
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
								text = (string)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = text;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						text = (string)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return text;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000B4850 File Offset: 0x000B2A50
		[DebuggerStepThrough]
		public string NextCommand()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.NextCommand()).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[0];
			string text;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					text = (string)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							text = this.$Rougamo_NextCommand();
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
								text = (string)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = text;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						text = (string)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return text;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000B4990 File Offset: 0x000B2B90
		public void Selected()
		{
			Transform temp = this.CardList;
			List<DictionaryItem> list = new List<DictionaryItem>();
			this.ReleaseCardItem(temp);
			bool flag = this.ChooseTags["des"].Count != 0 || this.inputField.text != "";
			if (flag)
			{
				foreach (DictionaryItem item in this.CardItems)
				{
					bool hasadd = false;
					foreach (string text in this.ChooseTags["des"])
					{
						bool flag2 = item.itemName.Contains(text) || item.itemDescription.Contains(text);
						if (flag2)
						{
							hasadd = true;
							list.Add(item);
							break;
						}
					}
					bool flag3 = !hasadd && this.inputField.text != "" && (item.dataConfig.data.Localize("Name").Contains(this.inputField.text) || item.dataConfig.data.Localize("Description").Contains(this.inputField.text));
					if (flag3)
					{
						list.Add(item);
					}
				}
			}
			else
			{
				list = new List<DictionaryItem>(this.CardItems);
			}
			List<DictionaryItem> TempList = new List<DictionaryItem>(list);
			bool flag4 = this.ChooseTags["rarity"].Count != 0;
			if (flag4)
			{
				foreach (DictionaryItem item2 in TempList)
				{
					bool TarCost = false;
					foreach (string text2 in this.ChooseTags["rarity"])
					{
						bool flag5 = item2.dataConfig.data["Rarity"].Contains(text2[0]);
						if (flag5)
						{
							TarCost = true;
							break;
						}
					}
					bool flag6 = !TarCost;
					if (flag6)
					{
						list.Remove(item2);
					}
				}
			}
			bool flag7 = this.ChooseTags["cost"].Count != 0;
			if (flag7)
			{
				foreach (DictionaryItem item3 in TempList)
				{
					bool TarCost2 = false;
					foreach (string text3 in this.ChooseTags["cost"])
					{
						bool flag8 = item3.dataConfig.data["Expend"].Contains(text3[0]);
						if (flag8)
						{
							TarCost2 = true;
							break;
						}
					}
					bool flag9 = !TarCost2;
					if (flag9)
					{
						list.Remove(item3);
					}
				}
			}
			this.ChooseCardItems = new List<DictionaryItem>(list);
			this.ResetPage(list);
			this.SelectCardByPage();
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000B4DA4 File Offset: 0x000B2FA4
		[DebuggerStepThrough]
		public void ReleaseCardItem(Transform formList)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.ReleaseCardItem(Transform)).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				formList
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
							formList = null;
						}
						else
						{
							formList = (Transform)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ReleaseCardItem(formList);
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

		// Token: 0x06001658 RID: 5720 RVA: 0x000B4ED8 File Offset: 0x000B30D8
		[DebuggerStepThrough]
		public UniTask PreLoad()
		{
			DictionaryUI.<PreLoad>d__26 <PreLoad>d__ = new DictionaryUI.<PreLoad>d__26();
			<PreLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreLoad>d__.<>4__this = this;
			<PreLoad>d__.<>1__state = -1;
			<PreLoad>d__.<>t__builder.Start<DictionaryUI.<PreLoad>d__26>(ref <PreLoad>d__);
			return <PreLoad>d__.<>t__builder.Task;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000B4F1C File Offset: 0x000B311C
		public void ResetPage(List<DictionaryItem> datas)
		{
			this.page = 0;
			GameObject pageObject = base.transform.Find("Content/Window Manager/Windows/卡牌/Content/pages/pagePre").gameObject;
			Transform pageParent = pageObject.transform.parent;
			foreach (object obj in pageParent)
			{
				Transform item = (Transform)obj;
				item.GetComponent<SwitchButton>().isOn = false;
			}
			foreach (object obj2 in pageParent)
			{
				Transform item2 = (Transform)obj2;
				Singleton<ObjectPool>.Instance.Release(item2.gameObject);
			}
			int maxPage = datas.Count / 10;
			bool flag = datas.Count % 10 != 0;
			if (flag)
			{
				maxPage++;
			}
			for (int i = 1; i <= maxPage; i++)
			{
				Transform pageItem = Singleton<ObjectPool>.Instance.Get(pageObject, pageParent).transform;
				pageItem.Find("Normal/text").GetComponent<TMP_Text>().text = i.ToString();
				pageItem.Find("Highlighted/text").GetComponent<TMP_Text>().text = i.ToString();
				pageItem.Find("Pressed/text").GetComponent<TMP_Text>().text = i.ToString();
				pageItem.SetSiblingIndex(i - 1);
			}
			pageParent.GetChild(0).GetComponent<SwitchButton>().isOn = true;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000B50D4 File Offset: 0x000B32D4
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
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.Init()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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

		// Token: 0x0600165B RID: 5723 RVA: 0x000B51D0 File Offset: 0x000B33D0
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
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.OnEnable()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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

		// Token: 0x0600165C RID: 5724 RVA: 0x000B52CC File Offset: 0x000B34CC
		[DebuggerStepThrough]
		public override void Hide()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.Hide()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_Hide();
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

		// Token: 0x0600165D RID: 5725 RVA: 0x000B53C8 File Offset: 0x000B35C8
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
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.Close()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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

		// Token: 0x0600165E RID: 5726 RVA: 0x000B54C4 File Offset: 0x000B36C4
		[DebuggerStepThrough]
		public void ReleaseItem()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.ReleaseItem()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_ReleaseItem();
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

		// Token: 0x0600165F RID: 5727 RVA: 0x000B55C0 File Offset: 0x000B37C0
		[DebuggerStepThrough]
		public void SortingBydefault()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.SortingBydefault()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_SortingBydefault();
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

		// Token: 0x06001660 RID: 5728 RVA: 0x000B56BC File Offset: 0x000B38BC
		[DebuggerStepThrough]
		public void SelectCardByPage()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.SelectCardByPage()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_SelectCardByPage();
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

		// Token: 0x06001661 RID: 5729 RVA: 0x000B57B8 File Offset: 0x000B39B8
		[DebuggerStepThrough]
		public void TotalCreateItem()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.TotalCreateItem()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_TotalCreateItem();
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

		// Token: 0x06001662 RID: 5730 RVA: 0x000B58B4 File Offset: 0x000B3AB4
		[DebuggerStepThrough]
		public void ShowInfo(DictionaryItem dictionaryItem)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.ShowInfo(DictionaryItem)).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				dictionaryItem
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
							dictionaryItem = null;
						}
						else
						{
							dictionaryItem = (DictionaryItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowInfo(dictionaryItem);
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

		// Token: 0x06001663 RID: 5731 RVA: 0x000B59E8 File Offset: 0x000B3BE8
		[DebuggerStepThrough]
		public void CloseInfo()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.CloseInfo()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_CloseInfo();
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

		// Token: 0x06001664 RID: 5732 RVA: 0x000B5AE4 File Offset: 0x000B3CE4
		[DebuggerStepThrough]
		private void CreateData(List<Dictionary<string, string>> datas, string type)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.CreateData(List<Dictionary<string, string>>, string)).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				datas,
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
							datas = null;
						}
						else
						{
							datas = (List<Dictionary<string, string>>)arguments[0];
						}
						if (arguments[1] == null)
						{
							type = null;
						}
						else
						{
							type = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateData(datas, type);
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

		// Token: 0x06001665 RID: 5733 RVA: 0x000B5C38 File Offset: 0x000B3E38
		[DebuggerStepThrough]
		private void CreateItem(List<DataConfig> datas, string type, Transform tempParent)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.CreateItem(List<DataConfig>, string, Transform)).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				datas,
				type,
				tempParent
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
							datas = null;
						}
						else
						{
							datas = (List<DataConfig>)arguments[0];
						}
						if (arguments[1] == null)
						{
							type = null;
						}
						else
						{
							type = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							tempParent = null;
						}
						else
						{
							tempParent = (Transform)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateItem(datas, type, tempParent);
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
								goto IL_13D;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_13D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000B5DAC File Offset: 0x000B3FAC
		[DebuggerStepThrough]
		public void MoveItem(List<DictionaryItem> datas, Transform temp)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.MoveItem(List<DictionaryItem>, Transform)).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				datas,
				temp
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
							datas = null;
						}
						else
						{
							datas = (List<DictionaryItem>)arguments[0];
						}
						if (arguments[1] == null)
						{
							temp = null;
						}
						else
						{
							temp = (Transform)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_MoveItem(datas, temp);
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

		// Token: 0x06001667 RID: 5735 RVA: 0x000B5F00 File Offset: 0x000B4100
		[DebuggerStepThrough]
		public void SetRelicDes(BlessItem item, string type)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.SetRelicDes(BlessItem, string)).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				item,
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
							item = null;
						}
						else
						{
							item = (BlessItem)arguments[0];
						}
						if (arguments[1] == null)
						{
							type = null;
						}
						else
						{
							type = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetRelicDes(item, type);
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

		// Token: 0x06001668 RID: 5736 RVA: 0x000B6054 File Offset: 0x000B4254
		[DebuggerStepThrough]
		public void SetEnemyDes(EnemyItem item)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.SetEnemyDes(EnemyItem)).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				item
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
							item = null;
						}
						else
						{
							item = (EnemyItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetEnemyDes(item);
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

		// Token: 0x06001669 RID: 5737 RVA: 0x000B6188 File Offset: 0x000B4388
		public void CreateCardTag()
		{
			Transform TotalTag = base.transform.Find("Content/Window Manager/Windows/卡牌/Content/RightSide");
			foreach (object obj in TotalTag.Find("CostSearch"))
			{
				Transform item5 = (Transform)obj;
				item5.GetComponent<DictTagItem>().Init(this);
			}
			foreach (object obj2 in TotalTag.Find("PrefixSearch"))
			{
				Transform item2 = (Transform)obj2;
				item2.GetComponent<DictTagItem>().Init(this);
			}
			foreach (object obj3 in TotalTag.Find("RaritySearch"))
			{
				Transform item3 = (Transform)obj3;
				item3.GetComponent<DictTagItem>().Init(this);
			}
			List<Dictionary<string, string>> tags = (from item in Singleton<GameConfigManager>.Instance.GetTable(DataType.KeyWords).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			where !item["Id"].Contains("enchtag") && !item["Id"].Contains("Buff") && !item["Id"].Contains("buff")
			select item).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			Transform tempPre = TotalTag.Find("TagSearch/TextPre");
			foreach (Dictionary<string, string> item4 in tags)
			{
				Transform tagItem = Singleton<ObjectPool>.Instance.Get(tempPre.gameObject, tempPre.parent).transform;
				tagItem.name = item4["Id"];
				tagItem.GetComponent<DictTagItem>().TagType = "des";
				tagItem.GetComponent<DictTagItem>().Init(item4["Id"], this);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000B63AC File Offset: 0x000B45AC
		[DebuggerStepThrough]
		private unsafe void ResolveDescription(string description, out string title, out string main)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.ResolveDescription(string, string*, string*)).MethodHandle, typeof(DictionaryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				description,
				title,
				main
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
							description = null;
						}
						else
						{
							description = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							title = null;
						}
						else
						{
							title = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							main = null;
						}
						else
						{
							main = (string)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ResolveDescription(description, out title, out main);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							object[] arguments2 = methodContext.Arguments;
							arguments2[1] = title;
							arguments2[2] = main;
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_15F;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
						object[] arguments3 = methodContext.Arguments;
						arguments3[1] = title;
						arguments3[2] = main;
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_15F:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000B6540 File Offset: 0x000B4740
		public void ResetTag()
		{
			Transform tempParent = base.transform.Find("Content/Window Manager/Windows/卡牌/Content/RightSide");
			foreach (object obj in tempParent)
			{
				Transform item = (Transform)obj;
				bool flag = item.name.Contains("Search");
				if (flag)
				{
					foreach (object obj2 in item)
					{
						Transform child = (Transform)obj2;
						child.GetComponent<DictTagItem>().ReturnNormal();
					}
				}
			}
			this.inputField.text = "";
			this.Selected();
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000B662C File Offset: 0x000B482C
		[DebuggerStepThrough]
		public override void OnDisable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DictionaryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DictionaryUI.OnDisable()).MethodHandle, typeof(DictionaryUI).TypeHandle);
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
							this.$Rougamo_OnDisable();
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

		// Token: 0x0600166E RID: 5742 RVA: 0x000B6824 File Offset: 0x000B4A24
		private void $Rougamo_DataUpdate()
		{
			base.transform.Find("Content/Window Manager/Windows/卡牌/Content/RightSide/Input/Retrieve/Title").GetComponent<TMP_Text>().SetLocalizedText(() => "Retrieve".Localize("Tips"));
			base.transform.Find("Content/Window Manager/Windows/卡牌/Content/RightSide/Input/Reset/Title").GetComponent<TMP_Text>().SetLocalizedText(() => "Reset Search".Localize("Tips"));
			Transform ItemTran = base.transform.Find("Content/Window Manager/Windows/敌人/Content/TextArea");
			ItemTran.Find("Status/Hp/Name").GetComponent<TMP_Text>().text = "Basic Hp".Localize("Dictionary");
			ItemTran.Find("Status/Attack/Name").GetComponent<TMP_Text>().text = "Basic Attack".Localize("Dictionary");
			ItemTran.Find("Belongs/Belong/Name/Text").GetComponent<TMP_Text>().text = "Disaster Card".Localize("Dictionary");
			ItemTran.Find("Belongs/Area/Name/Text").GetComponent<TMP_Text>().text = "Habitat".Localize("Dictionary");
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000B694C File Offset: 0x000B4B4C
		private void $Rougamo_Retrieve()
		{
			string input = this.inputField.text;
			bool flag = input != "";
			if (flag)
			{
				this.searchEd = true;
				this.commandHistory.Add(input);
				this.pos = this.commandHistory.Count;
				this.Selected();
			}
			this.inputField.ActivateInputField();
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000B69AF File Offset: 0x000B4BAF
		private void $Rougamo_ReturnList()
		{
			this.SortingBydefault();
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x000B69BC File Offset: 0x000B4BBC
		private string $Rougamo_LastCommand()
		{
			bool flag = this.pos == -1;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				this.pos--;
				bool flag2 = this.pos < 0;
				if (flag2)
				{
					this.pos = 0;
				}
				result = this.commandHistory[this.pos];
			}
			return result;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000B6A14 File Offset: 0x000B4C14
		private string $Rougamo_NextCommand()
		{
			bool flag = this.pos == -1;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				this.pos++;
				bool flag2 = this.pos >= this.commandHistory.Count;
				if (flag2)
				{
					this.pos = this.commandHistory.Count - 1;
				}
				result = this.commandHistory[this.pos];
			}
			return result;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000B6A88 File Offset: 0x000B4C88
		private void $Rougamo_ReleaseCardItem(Transform formList)
		{
			for (int i = formList.childCount - 1; i >= 0; i--)
			{
				Transform child = formList.GetChild(i);
				Singleton<ObjectPool>.Instance.Release(child.gameObject);
				child.SetParent(formList.parent.parent.Find("UnShowList"));
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000B6AE8 File Offset: 0x000B4CE8
		private UniTask $Rougamo_PreLoad()
		{
			DictionaryUI.<$Rougamo_PreLoad>d__36 <$Rougamo_PreLoad>d__ = new DictionaryUI.<$Rougamo_PreLoad>d__36();
			<$Rougamo_PreLoad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<$Rougamo_PreLoad>d__.<>4__this = this;
			<$Rougamo_PreLoad>d__.<>1__state = -1;
			<$Rougamo_PreLoad>d__.<>t__builder.Start<DictionaryUI.<$Rougamo_PreLoad>d__36>(ref <$Rougamo_PreLoad>d__);
			return <$Rougamo_PreLoad>d__.<>t__builder.Task;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x000B6B2C File Offset: 0x000B4D2C
		private void $Rougamo_Init()
		{
			this.page = 0;
			this.ReleaseItem();
			this.CreateCardTag();
			this.TotalCreateItem();
			this.DataUpdate();
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000B6B54 File Offset: 0x000B4D54
		private void $Rougamo_OnEnable()
		{
			this.page = 0;
			this.nowIndex = 0;
			base.OnEnable();
			base.transform.Find("Content/Window Manager").GetComponent<WindowManager>().OpenWindowByIndex(0);
			base.transform.Find("Content/Window Manager/Buttons").gameObject.SetActive(true);
			base.transform.SetAsLastSibling();
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x000B6BBB File Offset: 0x000B4DBB
		private void $Rougamo_Hide()
		{
			base.Hide();
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000A1CD7 File Offset: 0x0009FED7
		private void $Rougamo_Close()
		{
			base.Close();
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000B6BC5 File Offset: 0x000B4DC5
		private void $Rougamo_ReleaseItem()
		{
			this.ReleaseCardItem(this.CardList);
			this.ReleaseCardItem(this.RelicList);
			this.ReleaseCardItem(this.EnemyList);
			this.ReleaseCardItem(this.BlessList);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000B6BFC File Offset: 0x000B4DFC
		private void $Rougamo_SortingBydefault()
		{
			string type = "";
			Transform temp = null;
			List<DictionaryItem> list = new List<DictionaryItem>();
			switch (this.nowIndex)
			{
			case 0:
				this.SelectCardByPage();
				return;
			case 1:
				temp = this.RelicList;
				type = "Relic";
				list = new List<DictionaryItem>(this.RelicItems);
				break;
			case 2:
				temp = this.BlessList;
				type = "Bless";
				list = new List<DictionaryItem>(this.BlessItems);
				break;
			case 3:
				temp = this.EnemyList;
				type = "Enemy";
				list = new List<DictionaryItem>(this.EnemyItems);
				break;
			}
			this.ReleaseCardItem(temp);
			list = (from x in list.AsValueEnumerable<DictionaryItem>()
			where x.dataConfig.data["Rarity"] == this.TypeNowRarity[type]
			select x).ToList<ListWhere<DictionaryItem>, DictionaryItem>();
			this.MoveItem(list, temp);
			bool flag = list.Count > 0;
			if (flag)
			{
				list[0].GetComponent<DictionaryItem>().OnPointerClick(null);
				list[0].GetComponent<SwitchButton>().isOn = true;
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x000B6D20 File Offset: 0x000B4F20
		private void $Rougamo_SelectCardByPage()
		{
			this.ReleaseCardItem(this.CardList);
			List<DictionaryItem> list = new List<DictionaryItem>(this.ChooseCardItems);
			int startIndex = this.page * 10;
			int remain = list.Count - startIndex;
			int actual = Math.Min(10, remain);
			bool flag = actual <= 0;
			if (!flag)
			{
				list = list.GetRange(startIndex, actual);
				this.MoveItem(list, this.CardList);
			}
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000B6D8C File Offset: 0x000B4F8C
		private void $Rougamo_TotalCreateItem()
		{
			this.CreateData(Singleton<GameConfigManager>.Instance.GetTable(DataType.Card).Getlines(), "Card");
			this.CreateData(Singleton<GameConfigManager>.Instance.GetTable(DataType.Bless).Getlines(), "Bless");
			this.CreateData(Singleton<GameConfigManager>.Instance.GetTable(DataType.Relic).Getlines(), "Relic");
			this.CreateData((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Enemy).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"])
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>(), "Enemy");
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000B6E3C File Offset: 0x000B503C
		private void $Rougamo_ShowInfo(DictionaryItem dictionaryItem)
		{
			Transform tempTran = this.CardList.transform.parent.parent.Find("TempList");
			tempTran.gameObject.SetActive(true);
			tempTran.GetChild(0).GetComponent<DictionaryShowItem>().ItemType = "Card";
			tempTran.GetChild(0).GetComponent<DictionaryShowItem>().dictionaryUI = this;
			tempTran.GetChild(0).GetComponent<DictionaryShowItem>().Init(dictionaryItem.dataConfig);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000B6EB8 File Offset: 0x000B50B8
		private void $Rougamo_CloseInfo()
		{
			Transform tempTran = this.CardList.transform.parent.parent.Find("TempList");
			tempTran.gameObject.SetActive(false);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x000B6EF4 File Offset: 0x000B50F4
		private void $Rougamo_CreateData(List<Dictionary<string, string>> datas, string type)
		{
			Transform tempParent = null;
			datas = (from x in datas.AsValueEnumerable<Dictionary<string, string>>()
			where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"])
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			if (!(type == "Bless"))
			{
				if (!(type == "Relic"))
				{
					if (!(type == "Card"))
					{
						if (type == "Enemy")
						{
							tempParent = this.EnemyList.parent.parent.Find("UnShowList");
						}
					}
					else
					{
						tempParent = this.CardList.parent.parent.Find("UnShowList");
					}
				}
				else
				{
					tempParent = this.RelicList.parent.parent.Find("UnShowList");
				}
			}
			else
			{
				tempParent = this.BlessList.parent.parent.Find("UnShowList");
			}
			List<DataConfig> list = new List<DataConfig>();
			for (int i = 0; i < datas.Count; i++)
			{
				Dictionary<string, string> item = datas[i];
				list.Add(new DataConfig(item["Id"], DataType.IllustraedBook));
			}
			this.CreateItem(list, type, tempParent);
			bool flag = type == "Card";
			if (flag)
			{
				this.SelectCardByPage();
				this.ResetPage(this.CardItems);
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x000B7060 File Offset: 0x000B5260
		private void $Rougamo_CreateItem(List<DataConfig> datas, string type, Transform tempParent)
		{
			GameObject TempItem = tempParent.Find("Item").gameObject;
			TempItem.SetActive(true);
			for (int i = 0; i < datas.Count; i++)
			{
				DataConfig item = datas[i];
				GameObject childItem = Singleton<ObjectPool>.Instance.Get(TempItem, tempParent);
				DictionaryItem item2 = childItem.GetComponent<DictionaryItem>();
				item2.dictionaryUI = this;
				item2.Init(item);
				item2.ItemType = type;
				bool flag = type == "Card";
				if (flag)
				{
					this.CardItems.Add(item2);
					this.ChooseCardItems.Add(item2);
				}
				else
				{
					bool flag2 = type == "Bless";
					if (flag2)
					{
						this.BlessItems.Add(item2);
					}
					else
					{
						bool flag3 = type == "Relic";
						if (flag3)
						{
							this.RelicItems.Add(item2);
						}
						else
						{
							bool flag4 = type == "Enemy";
							if (flag4)
							{
								this.EnemyItems.Add(item2);
							}
						}
					}
				}
			}
			TempItem.SetActive(false);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x000B717C File Offset: 0x000B537C
		private void $Rougamo_MoveItem(List<DictionaryItem> datas, Transform temp)
		{
			this.CloseInfo();
			for (int i = 0; i < datas.Count; i++)
			{
				DictionaryItem item = datas[i];
				bool flag = item.name == "Item";
				if (!flag)
				{
					bool flag2 = item.transform.parent != temp;
					if (flag2)
					{
						item.transform.SetParent(temp);
					}
					item.transform.SetSiblingIndex(i);
					item.gameObject.SetActive(true);
				}
			}
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x000B7208 File Offset: 0x000B5408
		private void $Rougamo_SetRelicDes(BlessItem item, string type)
		{
			bool flag = type == "Relic";
			Transform ItemTran;
			if (flag)
			{
				this.nowIndex = 1;
				ItemTran = base.transform.Find("Content/Window Manager/Windows/遗物/Content/Des");
			}
			else
			{
				this.nowIndex = 2;
				ItemTran = base.transform.Find("Content/Window Manager/Windows/祝福/Content/Des");
			}
			this.CurrentItem[this.nowIndex] = item;
			ItemTran.Find("Icon/Icon").GetComponent<Image>().sprite = item.itemIcon;
			ItemTran.Find("Text/Title/text").GetComponent<TMP_Text>().text = item.itemName;
			KeywordDisplay keywordDisplay = ItemTran.Find("Text/Des").GetComponent<KeywordDisplay>() ? ItemTran.Find("Text/Des").GetComponent<KeywordDisplay>() : ItemTran.Find("Text/Des").gameObject.AddComponent<KeywordDisplay>();
			keywordDisplay.text = item.dataConfig.Description().Highlight(item.keywords);
			keywordDisplay.keyWords = item.keywords;
			keywordDisplay.title = item.itemName;
			keywordDisplay.icon = ResourceLoader.Load<Sprite>("Icon/Item/Rarity" + item.dataConfig.data["Rarity"], true);
			ItemTran.Find("Text/Des/text").GetComponent<TMP_Text>().text = keywordDisplay.text;
			ItemTran.Find("Text/Tip/text").GetComponent<TMP_Text>().text = item.dataConfig.data.Localize("Tips");
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000B738C File Offset: 0x000B558C
		private void $Rougamo_SetEnemyDes(EnemyItem item)
		{
			this.nowIndex = 3;
			this.CurrentItem[this.nowIndex] = item;
			Transform ItemTran = base.transform.Find("Content/Window Manager/Windows/敌人/Content/TextArea");
			ItemTran.Find("Icon/role").GetComponent<Image>().sprite = item.itemIcon;
			TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(item.itemIcon.texture, 0.1f);
			Vector2 offset = new Vector2((float)(realBounds.leftTransparentWidth - realBounds.rightTransparentWidth) / 2f, (float)(realBounds.bottomTransparentHeight - realBounds.topTransparentHeight) / 2f);
			ItemTran.Find("Icon/role").GetComponent<Image>().rectTransform.anchoredPosition = -offset;
			ItemTran.Find("Icon/role").GetComponent<Image>().SetNativeSize();
			ItemTran.Find("Status/Hp/Val").GetComponent<TMP_Text>().text = item.dataConfig.data["Hp"];
			ItemTran.Find("Status/Attack/Val").GetComponent<TMP_Text>().text = item.dataConfig.data["Attack"];
			bool flag = item.dataConfig.data["Description1"] != null;
			if (flag)
			{
				string title;
				string main;
				this.ResolveDescription(item.dataConfig.data.Localize("Description1"), out title, out main);
				ItemTran.Find("SkillList/Skill1/Name").GetComponent<TMP_Text>().text = title;
				ItemTran.Find("SkillList/Skill1/Des").GetComponent<TMP_Text>().text = main;
			}
			bool flag2 = !item.dataConfig.data["Description2"].IsNullOrEmpty<char>();
			if (flag2)
			{
				ItemTran.Find("SkillList/Skill2/").gameObject.SetActive(true);
				string title2;
				string main2;
				this.ResolveDescription(item.dataConfig.data.Localize("Description2"), out title2, out main2);
				ItemTran.Find("SkillList/Skill2/Name").GetComponent<TMP_Text>().text = title2;
				ItemTran.Find("SkillList/Skill2/Des").GetComponent<TMP_Text>().text = main2;
			}
			else
			{
				ItemTran.Find("SkillList/Skill2").gameObject.SetActive(false);
			}
			ItemTran.Find("Belongs/Belong/Text/Text").GetComponent<TMP_Text>().text = item.itemName;
			string lv;
			string levelKey = item.dataConfig.data.TryGetValue("Level", out lv) ? (lv ?? "") : "";
			string mapName;
			ItemTran.Find("Belongs/Area/Text/Text").GetComponent<TMP_Text>().text = ((!string.IsNullOrEmpty(levelKey) && EnemyItem.MapName.TryGetValue(levelKey, out mapName)) ? mapName.Localize("Dictionary") : "");
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x000B7654 File Offset: 0x000B5854
		private void $Rougamo_ResolveDescription(string description, out string title, out string main)
		{
			main = "";
			title = "";
			string mainPattern = "<main>(.*?)<\\/main>";
			string titlePattern = "<title>(.*?)<\\/title>";
			Match mainMatch = Regex.Match(description, mainPattern, RegexOptions.Singleline);
			Match titleMatch = Regex.Match(description, titlePattern, RegexOptions.Singleline);
			bool success = mainMatch.Success;
			if (success)
			{
				main = mainMatch.Groups[1].Value;
			}
			else
			{
				main = description;
			}
			bool success2 = titleMatch.Success;
			if (success2)
			{
				title = "[" + titleMatch.Groups[1].Value + "]";
			}
			bool flag = !mainMatch.Success && !titleMatch.Success;
			if (flag)
			{
				main = description;
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000B7707 File Offset: 0x000B5907
		private void $Rougamo_OnDisable()
		{
			base.OnDisable();
			HouseUI.CanScroll = true;
		}

		// Token: 0x04001194 RID: 4500
		public Transform BlessList;

		// Token: 0x04001195 RID: 4501
		public Transform RelicList;

		// Token: 0x04001196 RID: 4502
		public Transform CardList;

		// Token: 0x04001197 RID: 4503
		public Transform EnemyList;

		// Token: 0x04001198 RID: 4504
		public int nowIndex;

		// Token: 0x04001199 RID: 4505
		public int page = 0;

		// Token: 0x0400119A RID: 4506
		private List<string> commandHistory = new List<string>();

		// Token: 0x0400119B RID: 4507
		public Dictionary<string, List<string>> ChooseTags = new Dictionary<string, List<string>>
		{
			{
				"des",
				new List<string>()
			},
			{
				"cost",
				new List<string>()
			},
			{
				"rarity",
				new List<string>()
			}
		};

		// Token: 0x0400119C RID: 4508
		private int pos = -1;

		// Token: 0x0400119D RID: 4509
		public List<DictionaryItem> CardItems = new List<DictionaryItem>();

		// Token: 0x0400119E RID: 4510
		public List<DictionaryItem> ChooseCardItems = new List<DictionaryItem>();

		// Token: 0x0400119F RID: 4511
		public List<DictionaryItem> BlessItems = new List<DictionaryItem>();

		// Token: 0x040011A0 RID: 4512
		public List<DictionaryItem> RelicItems = new List<DictionaryItem>();

		// Token: 0x040011A1 RID: 4513
		public List<DictionaryItem> EnemyItems = new List<DictionaryItem>();

		// Token: 0x040011A2 RID: 4514
		[SerializeField]
		private TMP_InputField inputField;

		// Token: 0x040011A3 RID: 4515
		private bool searchEd;

		// Token: 0x040011A4 RID: 4516
		private Dictionary<int, DictionaryItem> CurrentItem = new Dictionary<int, DictionaryItem>();

		// Token: 0x040011A5 RID: 4517
		public Dictionary<string, string> TypeNowRarity = new Dictionary<string, string>
		{
			{
				"Card",
				"1"
			},
			{
				"Relic",
				"1"
			},
			{
				"Bless",
				"1"
			},
			{
				"Enemy",
				"1"
			}
		};
	}
}

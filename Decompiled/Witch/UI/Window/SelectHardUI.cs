using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x0200035F RID: 863
	public class SelectHardUI : UIBase
	{
		// Token: 0x06001B24 RID: 6948 RVA: 0x000E7D6C File Offset: 0x000E5F6C
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
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.DataUpdate()).MethodHandle, typeof(SelectHardUI).TypeHandle);
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

		// Token: 0x06001B25 RID: 6949 RVA: 0x000E7E68 File Offset: 0x000E6068
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
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.Init()).MethodHandle, typeof(SelectHardUI).TypeHandle);
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

		// Token: 0x06001B26 RID: 6950 RVA: 0x000E7F64 File Offset: 0x000E6164
		[DebuggerStepThrough]
		public void UpdataReward()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.UpdataReward()).MethodHandle, typeof(SelectHardUI).TypeHandle);
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
							this.$Rougamo_UpdataReward();
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

		// Token: 0x06001B27 RID: 6951 RVA: 0x000E8060 File Offset: 0x000E6260
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
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.Hide()).MethodHandle, typeof(SelectHardUI).TypeHandle);
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

		// Token: 0x06001B28 RID: 6952 RVA: 0x000E815C File Offset: 0x000E635C
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
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.OnDisable()).MethodHandle, typeof(SelectHardUI).TypeHandle);
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

		// Token: 0x06001B29 RID: 6953 RVA: 0x000E8258 File Offset: 0x000E6458
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
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.Awake()).MethodHandle, typeof(SelectHardUI).TypeHandle);
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

		// Token: 0x06001B2A RID: 6954 RVA: 0x000E8354 File Offset: 0x000E6554
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
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.OnEnable()).MethodHandle, typeof(SelectHardUI).TypeHandle);
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

		// Token: 0x06001B2B RID: 6955 RVA: 0x000E8450 File Offset: 0x000E6650
		public void CalCulateReward()
		{
			SelectHardUI.AddReward = 0;
			foreach (HardTagEntry item in SelectHardUI.UseSc)
			{
				SelectHardUI.AddReward += item.Data["Level"].ToInt() * 5 * item.DynamicValue;
			}
			this.UpdataReward();
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000E84D8 File Offset: 0x000E66D8
		[DebuggerStepThrough]
		public void AddSc(HardItem hardItem)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.AddSc(HardItem)).MethodHandle, typeof(SelectHardUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				hardItem
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
							hardItem = null;
						}
						else
						{
							hardItem = (HardItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_AddSc(hardItem);
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

		// Token: 0x06001B2D RID: 6957 RVA: 0x000E860C File Offset: 0x000E680C
		[DebuggerStepThrough]
		public void DeleteSc(HardItem hardItem)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.DeleteSc(HardItem)).MethodHandle, typeof(SelectHardUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				hardItem
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
							hardItem = null;
						}
						else
						{
							hardItem = (HardItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_DeleteSc(hardItem);
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

		// Token: 0x06001B2E RID: 6958 RVA: 0x000E8740 File Offset: 0x000E6940
		[DebuggerStepThrough]
		public void ChangeDesShow(Dictionary<string, string> data)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.ChangeDesShow(Dictionary<string, string>)).MethodHandle, typeof(SelectHardUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				data
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
							data = null;
						}
						else
						{
							data = (Dictionary<string, string>)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ChangeDesShow(data);
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

		// Token: 0x06001B2F RID: 6959 RVA: 0x000E8874 File Offset: 0x000E6A74
		[DebuggerStepThrough]
		public void CloseDes()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SelectHardUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SelectHardUI.CloseDes()).MethodHandle, typeof(SelectHardUI).TypeHandle);
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
							this.$Rougamo_CloseDes();
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

		// Token: 0x06001B30 RID: 6960 RVA: 0x000E8970 File Offset: 0x000E6B70
		public void ReSetHard()
		{
			Transform tempTran = this.NormalLevelItem.transform.parent;
			foreach (object obj in tempTran)
			{
				Transform item = (Transform)obj;
				item.GetComponent<HardItem>().ChangeShow();
			}
			tempTran = this.TestLevelItem.transform.parent;
			foreach (object obj2 in tempTran)
			{
				Transform item2 = (Transform)obj2;
				item2.GetComponent<HardItem>().ChangeShow();
			}
			SelectHardUI.UseSc.Clear();
			this.CalCulateReward();
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x000E8A54 File Offset: 0x000E6C54
		public void CreateItem()
		{
			foreach (Dictionary<string, string> hard in this.allHardList)
			{
				string text = hard["Type"];
				string a = text;
				GameObject tempItem;
				if (!(a == "Normal"))
				{
					if (!(a == "Test"))
					{
						tempItem = this.TestLevelItem;
					}
					else
					{
						tempItem = this.TestLevelItem;
					}
				}
				else
				{
					tempItem = this.NormalLevelItem;
				}
				GameObject g = Singleton<ObjectPool>.Instance.Get(tempItem, tempItem.transform.parent);
				g.gameObject.SetActive(true);
				g.GetComponent<HardItem>().selectHardUI = this;
				g.GetComponent<HardItem>().Init(hard);
			}
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000E8B90 File Offset: 0x000E6D90
		private void $Rougamo_DataUpdate()
		{
			base.transform.Find("Content/WindowManager/Buttons/难度").GetComponent<ButtonManager>().SetText("深渊难度".Localize("GameEntryUI"));
			base.transform.Find("Content/WindowManager/Buttons/测试").GetComponent<ButtonManager>().SetText("测试词条".Localize("GameEntryUI"));
			base.transform.Find("Content/SaveButton").GetComponent<ButtonManager>().SetText("确定保存".Localize("GameEntryUI"));
			base.transform.Find("Content/ResetButton").GetComponent<ButtonManager>().SetText("一键重置".Localize("GameEntryUI"));
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000E8C48 File Offset: 0x000E6E48
		private void $Rougamo_Init()
		{
			SelectHardUI.UseSc = Singleton<GameRuntimeData>.Instance.HardTags;
			this.allHardList = (from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Hard).Getlines()
			where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"])
			select x).ToList<Dictionary<string, string>>();
			SelectHardUI.UseSc = (from x in SelectHardUI.UseSc
			where this.allHardList.Exists((Dictionary<string, string> y) => y["Id"] == x.Data["Id"])
			select x).ToList<HardTagEntry>();
			this.CreateItem();
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000E8CCC File Offset: 0x000E6ECC
		private void $Rougamo_UpdataReward()
		{
			base.transform.Find("Content/Level/value").GetComponent<TMP_Text>().text = (SelectHardUI.AddReward / 5).ToString();
			bool flag = SelectHardUI.AddReward < 100;
			if (flag)
			{
				base.transform.Find("Content/Bonus/value").GetComponent<TMP_Text>().text = (100 + SelectHardUI.AddReward).ToString() + "%";
			}
			else
			{
				base.transform.Find("Content/Bonus/value").GetComponent<TMP_Text>().text = "200%";
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00044F44 File Offset: 0x00043144
		private void $Rougamo_Hide()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000E8D6C File Offset: 0x000E6F6C
		private void $Rougamo_OnDisable()
		{
			base.OnDisable();
			Singleton<GameRuntimeData>.Instance.HardTags = SelectHardUI.UseSc;
			Singleton<GameRuntimeData>.Instance.Save();
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_Awake()
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000E8D90 File Offset: 0x000E6F90
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.CalCulateReward();
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000E8DA4 File Offset: 0x000E6FA4
		private void $Rougamo_AddSc(HardItem hardItem)
		{
			Dictionary<string, string> data = hardItem.Data;
			int index = SelectHardUI.UseSc.FindIndex((HardTagEntry x) => x.Data["Id"] == data["Id"]);
			bool flag = index != -1;
			if (flag)
			{
				HardTagEntry hardTagEntry = SelectHardUI.UseSc[index];
				int dynamicValue = hardTagEntry.DynamicValue;
				hardTagEntry.DynamicValue = dynamicValue + 1;
				bool flag2 = SelectHardUI.UseSc[index].DynamicValue > int.Parse(data["MaxCount"]);
				if (flag2)
				{
					SelectHardUI.UseSc[index].DynamicValue = 0;
				}
				this.CalCulateReward();
			}
			else
			{
				SelectHardUI.UseSc.Add(new HardTagEntry(data, 1));
				this.CalCulateReward();
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000E8E6C File Offset: 0x000E706C
		private void $Rougamo_DeleteSc(HardItem hardItem)
		{
			Dictionary<string, string> data = hardItem.Data;
			int index = SelectHardUI.UseSc.FindIndex((HardTagEntry x) => x.Data["Id"] == data["Id"]);
			bool flag = index == -1;
			if (flag)
			{
				SelectHardUI.UseSc.Add(new HardTagEntry(data, int.Parse(data["MaxCount"])));
				this.CalCulateReward();
			}
			else
			{
				bool flag2 = SelectHardUI.UseSc[index].DynamicValue == 0;
				if (flag2)
				{
					SelectHardUI.UseSc[index].DynamicValue = int.Parse(data["MaxCount"]);
				}
				else
				{
					HardTagEntry hardTagEntry = SelectHardUI.UseSc[index];
					int dynamicValue = hardTagEntry.DynamicValue;
					hardTagEntry.DynamicValue = dynamicValue - 1;
				}
				this.CalCulateReward();
			}
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000E8F47 File Offset: 0x000E7147
		private void $Rougamo_ChangeDesShow(Dictionary<string, string> data)
		{
			this.DesItem.SetActive(true);
			this.DesItem.transform.Find("Text").GetComponent<TMP_Text>().SetText(data.Localize("Description"));
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000E8F82 File Offset: 0x000E7182
		private void $Rougamo_CloseDes()
		{
			this.DesItem.SetActive(false);
		}

		// Token: 0x040014A3 RID: 5283
		public GameObject NormalLevelItem;

		// Token: 0x040014A4 RID: 5284
		public GameObject TestLevelItem;

		// Token: 0x040014A5 RID: 5285
		public GameObject DesItem;

		// Token: 0x040014A6 RID: 5286
		public static List<HardTagEntry> UseSc = new List<HardTagEntry>();

		// Token: 0x040014A7 RID: 5287
		private List<Dictionary<string, string>> allHardList = new List<Dictionary<string, string>>();

		// Token: 0x040014A8 RID: 5288
		public static int AddReward = 0;
	}
}

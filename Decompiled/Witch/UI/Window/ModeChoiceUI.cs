using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Data.Save;
using Rougamo;
using Rougamo.Context;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000339 RID: 825
	public class ModeChoiceUI : UIBase
	{
		// Token: 0x060019DF RID: 6623 RVA: 0x000DA98C File Offset: 0x000D8B8C
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
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.DataUpdate()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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

		// Token: 0x060019E0 RID: 6624 RVA: 0x000DAA88 File Offset: 0x000D8C88
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
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.Init()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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

		// Token: 0x060019E1 RID: 6625 RVA: 0x000DAB84 File Offset: 0x000D8D84
		[DebuggerStepThrough]
		public void CreateNewSave(string modeType = "Normal")
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.CreateNewSave(string)).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				modeType
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
							modeType = null;
						}
						else
						{
							modeType = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateNewSave(modeType);
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

		// Token: 0x060019E2 RID: 6626 RVA: 0x000DACB8 File Offset: 0x000D8EB8
		[DebuggerStepThrough]
		private void StartLobby()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.StartLobby()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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
							this.$Rougamo_StartLobby();
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

		// Token: 0x060019E3 RID: 6627 RVA: 0x000DADB4 File Offset: 0x000D8FB4
		[DebuggerStepThrough]
		public void TeachMode()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.TeachMode()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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
							this.$Rougamo_TeachMode();
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

		// Token: 0x060019E4 RID: 6628 RVA: 0x000DAEB0 File Offset: 0x000D90B0
		public bool CheckSave(SaveInfo saveInfo)
		{
			bool flag = saveInfo == null || saveInfo.roleTable == null || saveInfo.roleTable.Count == 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				List<DataConfig> tempList = new List<DataConfig>(saveInfo.roleTable.First<KeyValuePair<string, RoleTable>>().Value.cardList);
				foreach (DataConfig item in tempList)
				{
					bool flag2 = !item.data.ContainsKey("Expend") || !item.data.ContainsKey("Tag");
					if (flag2)
					{
						return false;
					}
				}
				tempList = new List<DataConfig>(saveInfo.roleTable.First<KeyValuePair<string, RoleTable>>().Value.UnCardList);
				foreach (DataConfig item2 in tempList)
				{
					bool flag3 = !item2.data.ContainsKey("Expend") || !item2.data.ContainsKey("Tag");
					if (flag3)
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x000DB010 File Offset: 0x000D9210
		[DebuggerStepThrough]
		public void NormalMode()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.NormalMode()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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
							this.$Rougamo_NormalMode();
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

		// Token: 0x060019E6 RID: 6630 RVA: 0x000DB10C File Offset: 0x000D930C
		[DebuggerStepThrough]
		public void SlotMode()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.SlotMode()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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
							this.$Rougamo_SlotMode();
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

		// Token: 0x060019E7 RID: 6631 RVA: 0x000DB208 File Offset: 0x000D9408
		[DebuggerStepThrough]
		public void SublimationMode()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.SublimationMode()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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
							this.$Rougamo_SublimationMode();
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

		// Token: 0x060019E8 RID: 6632 RVA: 0x000DB304 File Offset: 0x000D9504
		[DebuggerStepThrough]
		public void ShowUnDone()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.ShowUnDone()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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
							this.$Rougamo_ShowUnDone();
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

		// Token: 0x060019E9 RID: 6633 RVA: 0x000DB400 File Offset: 0x000D9600
		[DebuggerStepThrough]
		public void ReturnGame(string modeType)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.ReturnGame(string)).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				modeType
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
							modeType = null;
						}
						else
						{
							modeType = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ReturnGame(modeType);
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

		// Token: 0x060019EA RID: 6634 RVA: 0x000DB534 File Offset: 0x000D9734
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
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.Close()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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

		// Token: 0x060019EB RID: 6635 RVA: 0x000DB630 File Offset: 0x000D9830
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
			methodContext.TargetType = typeof(ModeChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModeChoiceUI.OnDisable()).MethodHandle, typeof(ModeChoiceUI).TypeHandle);
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

		// Token: 0x060019F4 RID: 6644 RVA: 0x000DB7EC File Offset: 0x000D99EC
		private void $Rougamo_DataUpdate()
		{
			GameObject obj = base.transform.Find("ModeList/NormalMode").gameObject;
			obj.transform.Find("Text/Text").GetComponent<TMP_Text>().text = "Classic mode".Localize("GameEntryUI");
			obj.transform.Find("Normal/Title").GetComponent<Image>().sprite = LocalizeEx.Localize("Icon/UI_Icons/Native/模式选择/worl");
			obj.transform.Find("HighLighted/Title").GetComponent<Image>().sprite = LocalizeEx.Localize("Icon/UI_Icons/Native/模式选择/world");
			GameObject obj2 = base.transform.Find("ModeList/SublimationMode").gameObject;
			obj2.transform.Find("Text/Text").GetComponent<TMP_Text>().text = "The Path of Sublimation".Localize("GameEntryUI");
			obj2.transform.Find("Normal/Title").GetComponent<Image>().sprite = LocalizeEx.Localize("Icon/UI_Icons/Native/模式选择/godsla");
			obj2.transform.Find("HighLighted/Title").GetComponent<Image>().sprite = LocalizeEx.Localize("Icon/UI_Icons/Native/模式选择/godslayh");
			GameObject obj3 = base.transform.Find("ModeList/SlotMode").gameObject;
			obj3.transform.Find("Text/Text").GetComponent<TMP_Text>().text = "Random Mode".Localize("GameEntryUI");
			obj3.transform.Find("Normal/Title").GetComponent<Image>().sprite = LocalizeEx.Localize("Icon/UI_Icons/Native/模式选择/chao");
			obj3.transform.Find("HighLighted/Title").GetComponent<Image>().sprite = LocalizeEx.Localize("Icon/UI_Icons/Native/模式选择/chaosh");
			GameObject obj4 = base.transform.Find("ModeList/StoryMode").gameObject;
			obj4.transform.Find("Text/Text").GetComponent<TMP_Text>().text = "Story Mode".Localize("GameEntryUI");
			obj4.transform.Find("Normal/Title").GetComponent<Image>().sprite = LocalizeEx.Localize("Icon/UI_Icons/Native/模式选择/en");
			obj4.transform.Find("HighLighted/Title").GetComponent<Image>().sprite = LocalizeEx.Localize("Icon/UI_Icons/Native/模式选择/end");
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000DBA24 File Offset: 0x000D9C24
		private void $Rougamo_Init()
		{
			ModeChoiceUI.beforeSave["Normal"] = Singleton<GameRuntimeData>.Instance.Saves.FirstOrDefault((SaveInfo s) => s.modeType == "Normal");
			ModeChoiceUI.beforeSave["Sublimation"] = Singleton<GameRuntimeData>.Instance.Saves.FirstOrDefault((SaveInfo s) => s.modeType == "Sublimation");
			ModeChoiceUI.beforeSave["Slot"] = Singleton<GameRuntimeData>.Instance.Saves.FirstOrDefault((SaveInfo s) => s.modeType == "Slot");
			ModeChoiceUI.beforeSave["Teach"] = Singleton<GameRuntimeData>.Instance.Saves.FirstOrDefault((SaveInfo s) => s.modeType == "Teach");
			ModeChoiceUI.beforeSave["Story"] = Singleton<GameRuntimeData>.Instance.Saves.FirstOrDefault((SaveInfo s) => s.modeType == "Story");
			this.RegisterEvent();
			this.DataUpdate();
			bool flag = Singleton<GameRuntimeData>.Instance.playCount == 0;
			if (flag)
			{
				this.TeachMode();
			}
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x000DBB90 File Offset: 0x000D9D90
		private void $Rougamo_CreateNewSave([Optional] string modeType)
		{
			SaveInfo save = new SaveInfo
			{
				CreatedTime = DateTime.Now.ToString("yyyy-MM-dd,HH:mm"),
				Version = GameConfigManager.Version,
				isCheat = false,
				Name = modeType + UnityEngine.Random.Range(0, 100000).ToString(),
				roleTable = new Dictionary<string, RoleTable>(),
				mapTree = new MapTree(),
				HardTags = new List<DataConfig>(),
				startTime = DateTime.Now
			};
			GameSaveManager.Select(save);
			save.ItemOpers.PlayerId = Singleton<GameConfigManager>.Instance.PlayerId;
			System.Random random = new System.Random((int)DateTime.Now.Ticks);
			save.Seed = random.Next(0, (int)Math.Pow(10.0, 16.0) - 1).ToString();
			save.modeType = modeType;
			int baseCount = random.Next(0, 100);
			bool flag = baseCount < 50;
			if (flag)
			{
				save.GameVars["MapScene1"] = SceneType.Courtyard.ToString();
			}
			else
			{
				save.GameVars["MapScene1"] = SceneType.Forest.ToString();
			}
			save.GameVars["MapScene2"] = SceneType.PuppetTheater.ToString();
			baseCount = random.Next(0, 100);
			bool flag2 = baseCount < 50;
			if (flag2)
			{
				save.GameVars["MapScene3"] = SceneType.Castle.ToString();
			}
			else
			{
				save.GameVars["MapScene3"] = SceneType.Chessboard.ToString();
			}
			GameEntryUI.selectedSave = save;
			SaveInfo saveInfo = ModeChoiceUI.beforeSave[modeType];
			if (saveInfo != null)
			{
				saveInfo.Delete();
			}
			ModeChoiceUI.beforeSave[modeType] = save;
			bool flag3 = PlayerManager.Instance == null;
			if (flag3)
			{
				this.StartLobby();
			}
			else
			{
				bool flag4 = !PlayerManager.Instance.isServer;
				if (flag4)
				{
					this.Close();
					UIManager.Instance.ShowUI<GameEntryUI>("GameEntryUI", true).Init();
					UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("Only the host can start the game".Localize("GameEntryUI"), CaptionStyle.Top, 1f, 1.5f, 3);
					return;
				}
			}
			this.Close();
			UIManager.Instance.ShowUI<GameEntryUI>("GameEntryUI", true).Init();
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000DBE28 File Offset: 0x000DA028
		private void $Rougamo_StartLobby()
		{
			bool steambuild = GameApp.STEAMBUILD;
			if (steambuild)
			{
				SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, 4);
			}
			else
			{
				LobbyManager.Instance.StartHost();
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000DBE58 File Offset: 0x000DA058
		private void $Rougamo_TeachMode()
		{
			bool flag = !this.canClick;
			if (!flag)
			{
				bool flag2 = ModeChoiceUI.beforeSave["Teach"] != null && this.CheckSave(ModeChoiceUI.beforeSave["Teach"]);
				if (flag2)
				{
					GameEntryUI.selectedSave = ModeChoiceUI.beforeSave["Teach"];
					GameSaveManager.Select(ModeChoiceUI.beforeSave["Teach"]);
				}
				else
				{
					this.CreateNewSave("Teach");
				}
				bool flag3 = PlayerManager.Instance == null;
				if (flag3)
				{
					this.StartLobby();
				}
				else
				{
					bool flag4 = !PlayerManager.Instance.isServer;
					if (flag4)
					{
						this.Close();
						UIManager.Instance.ShowUI<GameEntryUI>("GameEntryUI", true).Init();
						UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("Only the host can start the game".Localize("GameEntryUI"), CaptionStyle.Top, 1f, 1.5f, 3);
						return;
					}
				}
				this.Close();
				UIManager.Instance.ShowUI<GameEntryUI>("GameEntryUI", true).Init();
			}
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000DBF7C File Offset: 0x000DA17C
		private void $Rougamo_NormalMode()
		{
			bool flag = !this.canClick;
			if (!flag)
			{
				bool flag2 = ModeChoiceUI.beforeSave["Normal"] != null;
				if (flag2)
				{
					UIManager.Instance.ShowModalWindow("Tips", "A save file already exists for this mode. Do you want to load it and continue the game?", delegate
					{
						this.ReturnGame("Normal");
					}, 0f, delegate
					{
						this.CreateNewSave("Normal");
					}, true, true, "Continue Game", "New Game", false);
				}
				else
				{
					this.CreateNewSave("Normal");
				}
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000DC000 File Offset: 0x000DA200
		private void $Rougamo_SlotMode()
		{
			bool flag = !this.canClick;
			if (!flag)
			{
				bool flag2 = ModeChoiceUI.beforeSave["Slot"] != null;
				if (flag2)
				{
					UIManager.Instance.ShowModalWindow("Tips", "A save file already exists for this mode. Do you want to load it and continue the game?", delegate
					{
						this.ReturnGame("Slot");
					}, 0f, delegate
					{
						this.CreateNewSave("Slot");
					}, true, true, "Continue Game", "New Game", false);
				}
				else
				{
					this.CreateNewSave("Slot");
				}
			}
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000DC084 File Offset: 0x000DA284
		private void $Rougamo_SublimationMode()
		{
			bool flag = !this.canClick;
			if (!flag)
			{
				bool flag2 = ModeChoiceUI.beforeSave["SublimationMode"] != null;
				if (flag2)
				{
					UIManager.Instance.ShowModalWindow("Tips", "A save file already exists for this mode. Do you want to load it and continue the game?", delegate
					{
						this.ReturnGame("SublimationMode");
					}, 0f, delegate
					{
						this.CreateNewSave("SublimationMode");
					}, true, true, "Continue Game", "New Game", false);
				}
				else
				{
					this.CreateNewSave("SublimationMode");
				}
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_ShowUnDone()
		{
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000DC108 File Offset: 0x000DA308
		private void $Rougamo_ReturnGame(string modeType)
		{
			bool flag = Singleton<GameRuntimeData>.Instance.Saves.Count == 0 || !this.canClick;
			if (!flag)
			{
				GameEntryUI.selectedSave = ModeChoiceUI.beforeSave[modeType];
				GameSaveManager.Select(ModeChoiceUI.beforeSave[modeType]);
				bool flag2 = PlayerManager.Instance == null;
				if (flag2)
				{
					this.StartLobby();
				}
				else
				{
					bool flag3 = !PlayerManager.Instance.isServer;
					if (flag3)
					{
						this.Close();
						UIManager.Instance.ShowUI<GameEntryUI>("GameEntryUI", true).Init();
						UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("Only the host can start the game".Localize("GameEntryUI"), CaptionStyle.Top, 1f, 1.5f, 3);
						return;
					}
				}
				this.Close();
				UIManager.Instance.ShowUI<GameEntryUI>("GameEntryUI", true).Init();
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000DC1F8 File Offset: 0x000DA3F8
		private void $Rougamo_Close()
		{
			this.canClick = false;
			base.Close();
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000B7707 File Offset: 0x000B5907
		private void $Rougamo_OnDisable()
		{
			base.OnDisable();
			HouseUI.CanScroll = true;
		}

		// Token: 0x040013C9 RID: 5065
		public GameEntryUI gameEntryUI;

		// Token: 0x040013CA RID: 5066
		public static Dictionary<string, SaveInfo> beforeSave = new Dictionary<string, SaveInfo>
		{
			{
				"Normal",
				null
			},
			{
				"Sublimation",
				null
			},
			{
				"Slot",
				null
			},
			{
				"Teach",
				null
			},
			{
				"Story",
				null
			}
		};

		// Token: 0x040013CB RID: 5067
		public bool canClick = true;
	}
}

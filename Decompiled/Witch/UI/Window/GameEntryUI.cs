using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Cysharp.Threading.Tasks;
using Data.Save;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Mirror;
using Newtonsoft.Json;
using Rougamo;
using Rougamo.Context;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x020002FA RID: 762
	public class GameEntryUI : UIBase
	{
		// Token: 0x060017E2 RID: 6114 RVA: 0x000C712C File Offset: 0x000C532C
		public void Init()
		{
			AudioManager.Instance.PlayBGMList("FightPrepareBGM", false);
			GameEntryUI.career = null;
			GameEntryUI.partner = null;
			UnityEngine.Object.Destroy(GameObject.Find("House"));
			bool flag = UIManager.Instance.GetUI<MainMenuUI>("MainMenuUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<MainMenuUI>("MainMenuUI").Close();
			}
			bool flag2 = UIManager.Instance.GetUI<OutsiderShopUI>("OutsiderShopUI") != null && UIManager.Instance.GetUI<OutsiderShopUI>("OutsiderShopUI").gameObject.activeSelf;
			if (flag2)
			{
				UIManager.Instance.GetUI<OutsiderShopUI>("OutsiderShopUI").Hide();
			}
			this.careerChoiceParent = base.transform.Find("Window Manager/Windows/道途");
			this.MainParent = base.transform.Find("Window Manager/Windows/道途/Content/MainChoice");
			this.SecondParent = base.transform.Find("Window Manager/Windows/道途/Content/SecondChoice");
			for (int i = 1; i <= 4; i++)
			{
				Transform Tp = base.transform.Find("Content/" + i.ToString() + "P");
				bool flag3 = Tp.GetComponent<SelectMessage>() == null;
				if (flag3)
				{
					Tp.gameObject.AddComponent<SelectMessage>().msg = "Career choice".Localize("GameEntryUI");
				}
				Tp.GetComponent<ButtonManager>().onClick.RemoveAllListeners();
				Tp.GetComponent<ButtonManager>().onClick.AddListener(delegate
				{
					bool flag4 = PlayerManager.Instance != null && Tp.Find("RoleParent/role").GetComponent<AnimatorRole>().InstanceId == PlayerManager.Instance.PlayerId;
					if (flag4)
					{
						this.OpenChoice();
					}
				});
			}
			this.CloseAllWindows();
			this.selectHardUI.Init();
			UniTask.WaitUntil(() => PlayerManager.Instance != null, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				bool isServer = PlayerManager.Instance.isServer;
				if (!isServer)
				{
					base.transform.Find("ForeBack/Statue").GetComponent<ButtonManager>().isInteractable = false;
				}
			}).Forget();
			using (IEnumerator enumerator = this.MainParent.Find("VarsList").GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Transform item = (Transform)enumerator.Current;
					item.GetComponent<SwitchButton>().isOn = false;
					item.GetComponent<SwitchButton>().onValueChanged.AddListener(delegate(bool isOn)
					{
						if (isOn)
						{
							bool flag4 = this.SecondVar != null && item.name == this.SecondVar.name;
							if (flag4)
							{
								this.SecondVar.GetComponent<SwitchButton>().isOn = false;
							}
							this.MainVar = item;
						}
						else
						{
							bool flag5 = this.MainVar == item;
							if (flag5)
							{
								this.MainVar = null;
							}
						}
					});
				}
			}
			using (IEnumerator enumerator2 = this.SecondParent.Find("VarsList").GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Transform item = (Transform)enumerator2.Current;
					item.GetComponent<SwitchButton>().isOn = false;
					item.GetComponent<SwitchButton>().onValueChanged.AddListener(delegate(bool isOn)
					{
						if (isOn)
						{
							bool flag4 = this.MainVar != null && item.name == this.MainVar.name;
							if (flag4)
							{
								this.MainVar.GetComponent<SwitchButton>().isOn = false;
							}
							this.SecondVar = item;
						}
						else
						{
							bool flag5 = this.SecondVar == item;
							if (flag5)
							{
								this.SecondVar = null;
							}
						}
					});
				}
			}
			this.DataUpdate();
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x000C7494 File Offset: 0x000C5694
		[DebuggerStepThrough]
		public void CloseAllWindows()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.CloseAllWindows()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
							this.$Rougamo_CloseAllWindows();
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

		// Token: 0x060017E4 RID: 6116 RVA: 0x000C7590 File Offset: 0x000C5790
		public override void DataUpdate()
		{
			base.transform.Find("Window Manager/Windows/道途/Content/Title/Back/Text").GetComponent<TMP_Text>().text = "Pre-war preparation".Localize("GameEntryUI");
			base.transform.Find("Window Manager/Windows/道途/Content/Bottom/Back/Text").GetComponent<TMP_Text>().text = "Save Configuration".Localize("GameEntryUI");
			base.transform.Find("Window Manager/Windows/道途/Content/CareerChoice").GetComponent<ButtonManager>().SetText("Witch's Selection".Localize("GameEntryUI"));
			base.transform.Find("Window Manager/Windows/道途/Content/PartnerChoice").GetComponent<ButtonManager>().SetText("Partner selection".Localize("GameEntryUI"));
			this.MainParent.Find("Text/text").GetComponent<TMP_Text>().text = "Core Origin".Localize("GameEntryUI");
			this.SecondParent.Find("Text/text").GetComponent<TMP_Text>().text = "Secondary Origin".Localize("GameEntryUI");
			foreach (object obj in this.MainParent.Find("VarsList"))
			{
				Transform item = (Transform)obj;
				SwitchButton button = item.GetComponent<SwitchButton>();
				button.Normal.transform.Find("text").GetComponent<TMP_Text>().text = (button.Highlighted.transform.Find("text").GetComponent<TMP_Text>().text = (button.Pressed.transform.Find("text").GetComponent<TMP_Text>().text = item.name.Localize("TopBarUI")));
			}
			foreach (object obj2 in this.SecondParent.Find("VarsList"))
			{
				Transform item2 = (Transform)obj2;
				SwitchButton button2 = item2.GetComponent<SwitchButton>();
				button2.Normal.transform.Find("text").GetComponent<TMP_Text>().text = (button2.Highlighted.transform.Find("text").GetComponent<TMP_Text>().text = (button2.Pressed.transform.Find("text").GetComponent<TMP_Text>().text = item2.name.Localize("TopBarUI")));
			}
			base.transform.Find("Content/1P/Bottom/Done/text").GetComponent<TMP_Text>().text = "Prepared".Localize("GameEntryUI");
			UniTask.WaitUntil(() => PlayerManager.Instance != null, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				bool isServer = PlayerManager.Instance.isServer;
				if (isServer)
				{
					bool flag3 = this.waitCount >= NetworkServer.connections.Count;
					if (flag3)
					{
						base.transform.Find("ForeBack/Button/Text").GetComponent<TMP_Text>().SetText("Start".Localize("GameEntryUI"));
					}
					else
					{
						base.transform.Find("ForeBack/Button/Text").GetComponent<TMP_Text>().SetText("Wait".Localize("GameEntryUI") + this.waitCount.ToString() + "/" + NetworkServer.connections.Count.ToString());
					}
					for (int i = 1; i <= 4; i++)
					{
						bool flag4 = i > GameEntryUI.playerCount;
						if (flag4)
						{
							base.transform.Find("Content/" + i.ToString() + "P/").GetComponent<SelectMessage>().msg = "Invite Player".Localize("GameEntryUI");
							base.transform.Find("Content/" + i.ToString() + "P/Bottom/Name/text").GetComponent<TMP_Text>().text = "Invite Player".Localize("GameEntryUI");
						}
						else
						{
							base.transform.Find("Content/" + i.ToString() + "P/").GetComponent<SelectMessage>().msg = "";
						}
						bool flag5 = base.transform.Find("Content/" + i.ToString() + "P/RoleParent/role").GetComponent<AnimatorRole>().InstanceId == PlayerManager.Instance.PlayerId;
						if (flag5)
						{
							base.transform.Find("Content/" + i.ToString() + "P").GetComponent<SelectMessage>().msg = "Career choice".Localize("GameEntryUI");
						}
					}
				}
				else
				{
					bool flag6 = this.selfReady;
					if (flag6)
					{
						base.transform.Find("ForeBack/Button/Text").GetComponent<TMP_Text>().SetText("Prepared".Localize("GameEntryUI"));
					}
					else
					{
						base.transform.Find("ForeBack/Button/Text").GetComponent<TMP_Text>().SetText("Not ready".Localize("GameEntryUI"));
					}
				}
			}).Forget();
			bool flag = GameEntryUI.career != null;
			if (flag)
			{
				this.ChangeCareerDesShow(GameEntryUI.career, base.transform.Find("Window Manager/Windows/道途/Content/CareerChoice"));
			}
			bool flag2 = GameEntryUI.partner != null;
			if (flag2)
			{
				this.ChangeCareerDesShow(GameEntryUI.partner, base.transform.Find("Window Manager/Windows/道途/Content/PartnerChoice"));
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x000C791C File Offset: 0x000C5B1C
		[DebuggerStepThrough]
		public void Outlobby()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.Outlobby()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
							this.$Rougamo_Outlobby();
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

		// Token: 0x060017E6 RID: 6118 RVA: 0x000C7A18 File Offset: 0x000C5C18
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
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.Start()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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

		// Token: 0x060017E7 RID: 6119 RVA: 0x000C7B14 File Offset: 0x000C5D14
		[DebuggerStepThrough]
		public void ReturnHouse()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.ReturnHouse()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
							this.$Rougamo_ReturnHouse();
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

		// Token: 0x060017E8 RID: 6120 RVA: 0x000C7C10 File Offset: 0x000C5E10
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
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.Close()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x000C7D0C File Offset: 0x000C5F0C
		public bool isHost
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
				methodContext.TargetType = typeof(GameEntryUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.get_isHost()).MethodHandle, typeof(GameEntryUI).TypeHandle);
				methodContext.Arguments = new object[0];
				bool flag;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						flag = (bool)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								flag = this.$Rougamo_get_isHost();
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
									flag = (bool)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_10D;
								}
								throw;
							}
							methodContext.ReturnValue = flag;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							flag = (bool)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_10D:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return flag;
			}
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000C7E50 File Offset: 0x000C6050
		[DebuggerStepThrough]
		public void ChangeReady(bool ready)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.ChangeReady(bool)).MethodHandle, typeof(GameEntryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				ready
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
							ready = default(bool);
						}
						else
						{
							ready = (bool)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ChangeReady(ready);
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

		// Token: 0x060017EB RID: 6123 RVA: 0x000C7F8C File Offset: 0x000C618C
		[DebuggerStepThrough]
		public void SetReady(bool ready, string playerId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.SetReady(bool, string)).MethodHandle, typeof(GameEntryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				ready,
				playerId
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
							ready = default(bool);
						}
						else
						{
							ready = (bool)arguments[0];
						}
						if (arguments[1] == null)
						{
							playerId = null;
						}
						else
						{
							playerId = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetReady(ready, playerId);
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

		// Token: 0x060017EC RID: 6124 RVA: 0x000C80E8 File Offset: 0x000C62E8
		public void StartGame()
		{
			List<DataConfig> tempList = new List<DataConfig>(RoleTable.Instance.cardList);
			foreach (DataConfig item in tempList)
			{
				bool flag = !item.data.ContainsKey("Expend") || !item.data.ContainsKey("Tag");
				if (flag)
				{
					RoleTable.Instance.cardList.Remove(item);
				}
			}
			tempList = new List<DataConfig>(RoleTable.Instance.UnCardList);
			foreach (DataConfig item2 in tempList)
			{
				bool flag2 = !item2.data.ContainsKey("Expend") || !item2.data.ContainsKey("Tag");
				if (flag2)
				{
					RoleTable.Instance.UnCardList.Remove(item2);
				}
			}
			bool flag3 = this.waitCount >= NetworkServer.connections.Count;
			if (flag3)
			{
				bool flag4 = GameEntryUI.selectedSave != null;
				if (flag4)
				{
					bool flag5 = !this.isHost && NetworkClient.connection != null;
					if (flag5)
					{
						UIManager.Instance.ShowModalWindow("Error", "You are not the host!", null, 1f, null, true, true, "Yes", "No", true);
					}
					else
					{
						GameEntryUI.selectedSave.HardTags = new List<DataConfig>();
						List<Dictionary<string, string>> allHardList = (from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Hard).Getlines()
						where !Singleton<GameRuntimeData>.Instance.IsLocked(x["Id"])
						select x into d
						orderby d["Level"].ToInt()
						select d).ToList<Dictionary<string, string>>();
						GameEntryUI.selectedSave.HardLevel = 0;
						SelectHardUI.UseSc = (from x in SelectHardUI.UseSc
						where allHardList.Exists((Dictionary<string, string> y) => y["Id"] == x.Data["Id"])
						select x).ToList<HardTagEntry>();
						foreach (HardTagEntry item3 in SelectHardUI.UseSc)
						{
							GameEntryUI.selectedSave.HardTags.Add(new DataConfig(item3.Data["Id"], DataType.Hard));
							GameEntryUI.selectedSave.HardLevel += item3.Data["Level"].ToInt();
						}
						bool flag6 = !NetworkServer.active;
						if (flag6)
						{
							LobbyManager.Instance.StartHost();
						}
						bool flag7 = RoleTable.Instance.Career == null;
						if (flag7)
						{
							GameEntryUI.CheckCareer();
						}
						bool flag8 = PlayerManager.Instance != null && PlayerManager.Instance.isServer;
						if (flag8)
						{
							PlayerManager.Instance.CmdSendSave();
							PlayerManager.Instance.RpcSyncRoleTables();
							bool lazyLoad = MapManager.Instance.ModeMapManager.lazyLoad;
							if (lazyLoad)
							{
								MapManager.Instance.ModeMapManager.lazyLoad = false;
								MapManager.Instance.RpcSyncRandom(GameSaveManager.GetSeed());
								Singleton<TempDataManager>.Instance.Random(GameSaveManager.GetSeed());
							}
						}
						bool waitTarget = false;
						UniTask.WaitForSeconds(1f, false, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
						{
							waitTarget = true;
						}).Forget();
						UIManager.Instance.ShowWaitingUI("Game Title", "Creating game...", delegate
						{
							if (waitTarget && NetworkServer.active)
							{
								if (NetworkServer.connections.ToList<KeyValuePair<int, NetworkConnectionToClient>>().All((KeyValuePair<int, NetworkConnectionToClient> x) => x.Value.isReady))
								{
									return global::GameServer.Instance.IsRoleTableSynced;
								}
							}
							return false;
						}).ContinueWith(delegate()
						{
							PlayerManager.Instance.StartGame();
						}).Forget();
					}
				}
			}
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000C84F8 File Offset: 0x000C66F8
		[DebuggerStepThrough]
		private static void CheckCareer()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.CheckCareer()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
							GameEntryUI.$Rougamo_CheckCareer();
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
								goto IL_C0;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C0:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x000C85EC File Offset: 0x000C67EC
		public void NormalGame()
		{
			List<string> TempVar = new List<string>();
			bool flag = this.MainVar != null;
			if (flag)
			{
				TempVar.Add(this.MainVar.name);
			}
			bool flag2 = this.SecondVar != null;
			if (flag2)
			{
				TempVar.Add(this.SecondVar.name);
			}
			bool flag3 = MapManager.Instance.ModeMapManager is TeachMapManager;
			if (flag3)
			{
				TempVar = new List<string>
				{
					"Strength",
					"Perceive"
				};
			}
			GameEntryUI.CheckCareer();
			RoleTable.Instance.ChooseVars = TempVar;
			foreach (string item in TempVar)
			{
				Dictionary<string, int> varsMap = RoleTable.Instance.VarsMap;
				string key = item;
				varsMap[key] += 2;
			}
			bool flag4 = TempVar.Contains("Strength");
			if (flag4)
			{
				RoleTable.Instance.cardList.Add(new DataConfig("burningcard_2", DataType.Card));
				RoleTable.Instance.cardList.Add(new DataConfig("card_1", DataType.Card));
			}
			bool flag5 = TempVar.Contains("Lucky");
			if (flag5)
			{
				RoleTable.Instance.cardList.Add(new DataConfig("card_5", DataType.Card));
				RoleTable.Instance.cardList.Add(new DataConfig("card_9", DataType.Card));
			}
			bool flag6 = TempVar.Contains("Perceive");
			if (flag6)
			{
				RoleTable.Instance.cardList.Add(new DataConfig("card_2", DataType.Card));
				RoleTable.Instance.cardList.Add(new DataConfig("card_6", DataType.Card));
			}
			bool flag7 = TempVar.Contains("Wisdom");
			if (flag7)
			{
				RoleTable.Instance.cardList.Add(new DataConfig("card_3", DataType.Card));
				RoleTable.Instance.cardList.Add(new DataConfig("elementscard_1", DataType.Card));
			}
			bool flag8 = RoleTable.Instance.cardList.Count < 12;
			if (flag8)
			{
				RoleTable.Instance.cardList.Add(new DataConfig("card_1", DataType.Card));
				RoleTable.Instance.cardList.Add(new DataConfig("card_2", DataType.Card));
			}
			bool flag9 = TempVar.Count == 0;
			if (flag9)
			{
				RoleTable.Instance.cardList.Add(new DataConfig("card_1", DataType.Card));
				RoleTable.Instance.cardList.Add(new DataConfig("elementscard_2", DataType.Card));
			}
			bool flag10 = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
			if (flag10)
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeVar();
			}
			this.Close();
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x000C88EC File Offset: 0x000C6AEC
		[DebuggerStepThrough]
		public void OpenChoice()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.OpenChoice()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
							this.$Rougamo_OpenChoice();
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

		// Token: 0x060017F0 RID: 6128 RVA: 0x000C89E8 File Offset: 0x000C6BE8
		[DebuggerStepThrough]
		public void OpenWindow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.OpenWindow()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
							this.$Rougamo_OpenWindow();
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

		// Token: 0x060017F1 RID: 6129 RVA: 0x000C8AE4 File Offset: 0x000C6CE4
		[DebuggerStepThrough]
		public void CloseWindow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.CloseWindow()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
							this.$Rougamo_CloseWindow();
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

		// Token: 0x060017F2 RID: 6130 RVA: 0x000C8BE0 File Offset: 0x000C6DE0
		[DebuggerStepThrough]
		public void OpenSelectHard()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.OpenSelectHard()).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
							this.$Rougamo_OpenSelectHard();
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

		// Token: 0x060017F3 RID: 6131 RVA: 0x000C8CDC File Offset: 0x000C6EDC
		[DebuggerStepThrough]
		public void UpdateLobby(List<LobbyInfo.PlayerInfo> players)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.UpdateLobby(List<LobbyInfo.PlayerInfo>)).MethodHandle, typeof(GameEntryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				players
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
							players = null;
						}
						else
						{
							players = (List<LobbyInfo.PlayerInfo>)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_UpdateLobby(players);
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

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x000C8E10 File Offset: 0x000C7010
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x000C8F48 File Offset: 0x000C7148
		public static DataConfig career
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.TargetType = typeof(GameEntryUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.get_career()).MethodHandle, typeof(GameEntryUI).TypeHandle);
				methodContext.Arguments = new object[0];
				DataConfig dataConfig;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						dataConfig = (DataConfig)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								dataConfig = GameEntryUI.$Rougamo_get_career();
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
									dataConfig = (DataConfig)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_100;
								}
								throw;
							}
							methodContext.ReturnValue = dataConfig;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							dataConfig = (DataConfig)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_100:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return dataConfig;
			}
			[CompilerGenerated]
			[DebuggerStepThrough]
			set
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.TargetType = typeof(GameEntryUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.set_career(DataConfig)).MethodHandle, typeof(GameEntryUI).TypeHandle);
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
								value = null;
							}
							else
							{
								value = (DataConfig)arguments[0];
							}
						}
						do
						{
							try
							{
								GameEntryUI.$Rougamo_set_career(value);
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
									goto IL_F5;
								}
								throw;
							}
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						modifiable.OnExit(methodContext);
						IL_F5:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000C9074 File Offset: 0x000C7274
		public void ShowCareer()
		{
			List<Dictionary<string, string>> tempList = new List<Dictionary<string, string>>();
			List<string> tempUse = new List<string>
			{
				"Career",
				"Partner"
			};
			using (List<string>.Enumerator enumerator = tempUse.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string choiceWay = enumerator.Current;
					Transform tempParent = base.transform.Find("Window Manager/Windows/道途/Content/" + choiceWay + "Choice");
					Transform itemPre = tempParent.Find("DollList/ItemPre");
					bool flag = choiceWay == "Career";
					if (flag)
					{
						tempList = (from b in Singleton<GameConfigManager>.Instance.GetTable(DataType.Career).Getlines().AsValueEnumerable<Dictionary<string, string>>()
						where !Singleton<GameRuntimeData>.Instance.IsLocked(b["Id"])
						select b).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
						bool flag2 = Singleton<GameRuntimeData>.Instance.playCount == 0 && tempList.Count > 0;
						if (flag2)
						{
							tempList = new List<Dictionary<string, string>>
							{
								tempList[0]
							};
						}
					}
					else
					{
						bool flag3 = choiceWay == "Partner";
						if (flag3)
						{
							tempList = Singleton<GameConfigManager>.Instance.GetTable(DataType.Partner).Getlines().ToList<Dictionary<string, string>>();
						}
					}
					UnityAction <>9__1;
					UnityAction <>9__2;
					for (int i = 0; i < tempList.Count; i++)
					{
						bool flag4 = choiceWay == "Career";
						DataConfig item;
						if (flag4)
						{
							item = new DataConfig(tempList[i]["Id"], DataType.Career);
						}
						else
						{
							item = new DataConfig(tempList[i]["Id"], DataType.Partner);
						}
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(itemPre.gameObject, itemPre.parent);
						gameObject.SetActive(true);
						gameObject.GetComponent<ShowCareer>().dataConfig = item;
						gameObject.GetComponent<ShowCareer>().belong = choiceWay;
						gameObject.GetComponent<ShowCareer>().gameEntryUI = this;
						Sprite newSprite = ResourceLoader.Load<Sprite>(tempList[i]["DollIcon"], true);
						TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(newSprite.texture, 0.1f);
						gameObject.transform.Find("role").GetComponent<Image>().sprite = newSprite;
						bool flag5 = choiceWay == "Career";
						if (flag5)
						{
							this.showCareers.Add(gameObject.GetComponent<ShowCareer>());
							gameObject.transform.Find("role").GetComponent<Image>().SetNativeSize();
						}
						else
						{
							bool flag6 = choiceWay == "Partner";
							if (flag6)
							{
								this.showPartners.Add(gameObject.GetComponent<ShowCareer>());
							}
						}
						tempParent.Find("CareerShow/CareerChoice/Left").GetComponent<ButtonManager>().onClick.RemoveAllListeners();
						UnityEvent onClick = tempParent.Find("CareerShow/CareerChoice/Left").GetComponent<ButtonManager>().onClick;
						UnityAction call;
						if ((call = <>9__1) == null)
						{
							call = (<>9__1 = delegate()
							{
								bool flag7 = choiceWay == "Career";
								if (flag7)
								{
									this.careerIndex--;
									bool flag8 = this.careerIndex < 0;
									if (flag8)
									{
										this.careerIndex = this.showCareers.Count - 1;
									}
									this.ShowDetail(this.showCareers[this.careerIndex], "Career", true);
								}
								else
								{
									bool flag9 = choiceWay == "Partner";
									if (flag9)
									{
										this.partnerIndex--;
										bool flag10 = this.partnerIndex < 0;
										if (flag10)
										{
											this.partnerIndex = this.showPartners.Count - 1;
										}
										this.ShowDetail(this.showPartners[this.partnerIndex], "Partner", true);
									}
								}
							});
						}
						onClick.AddListener(call);
						tempParent.Find("CareerShow/CareerChoice/Right").GetComponent<ButtonManager>().onClick.RemoveAllListeners();
						UnityEvent onClick2 = tempParent.Find("CareerShow/CareerChoice/Right").GetComponent<ButtonManager>().onClick;
						UnityAction call2;
						if ((call2 = <>9__2) == null)
						{
							call2 = (<>9__2 = delegate()
							{
								bool flag7 = choiceWay == "Career";
								if (flag7)
								{
									this.careerIndex++;
									bool flag8 = this.careerIndex >= this.showCareers.Count;
									if (flag8)
									{
										this.careerIndex = 0;
									}
									this.ShowDetail(this.showCareers[this.careerIndex], "Career", true);
								}
								else
								{
									bool flag9 = choiceWay == "Partner";
									if (flag9)
									{
										this.partnerIndex++;
										bool flag10 = this.partnerIndex >= this.showPartners.Count;
										if (flag10)
										{
											this.partnerIndex = 0;
										}
										this.ShowDetail(this.showPartners[this.partnerIndex], "Partner", true);
									}
								}
							});
						}
						onClick2.AddListener(call2);
					}
				}
			}
			this.ShowDetail(this.showPartners[0], "Partner", true);
			this.ShowDetail(this.showCareers[0], "Career", false);
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x000C9458 File Offset: 0x000C7658
		[DebuggerStepThrough]
		public void ShowDetail(ShowCareer thiscareer, string way, bool ischangeRole = true)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.ShowDetail(Witch.UI.Window.ShowCareer, string, bool)).MethodHandle, typeof(GameEntryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				thiscareer,
				way,
				ischangeRole
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
							thiscareer = null;
						}
						else
						{
							thiscareer = (ShowCareer)arguments[0];
						}
						if (arguments[1] == null)
						{
							way = null;
						}
						else
						{
							way = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							ischangeRole = default(bool);
						}
						else
						{
							ischangeRole = (bool)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowDetail(thiscareer, way, ischangeRole);
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

		// Token: 0x060017F8 RID: 6136 RVA: 0x000C95D4 File Offset: 0x000C77D4
		[DebuggerStepThrough]
		public void ChangeCareerDesShow(DataConfig thiscareer, Transform tempParent)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.ChangeCareerDesShow(DataConfig, Transform)).MethodHandle, typeof(GameEntryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				thiscareer,
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
							thiscareer = null;
						}
						else
						{
							thiscareer = (DataConfig)arguments[0];
						}
						if (arguments[1] == null)
						{
							tempParent = null;
						}
						else
						{
							tempParent = (Transform)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ChangeCareerDesShow(thiscareer, tempParent);
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

		// Token: 0x060017F9 RID: 6137 RVA: 0x000C9728 File Offset: 0x000C7928
		[DebuggerStepThrough]
		public void ChangeRole(DataConfig dataConfig, string fromId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.ChangeRole(DataConfig, string)).MethodHandle, typeof(GameEntryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				dataConfig,
				fromId
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
						if (arguments[1] == null)
						{
							fromId = null;
						}
						else
						{
							fromId = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ChangeRole(dataConfig, fromId);
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

		// Token: 0x060017FA RID: 6138 RVA: 0x000C987C File Offset: 0x000C7A7C
		[DebuggerStepThrough]
		private unsafe void GetDes(string description, out string name, out string des)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(GameEntryUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(GameEntryUI.GetDes(string, string*, string*)).MethodHandle, typeof(GameEntryUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				description,
				name,
				des
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
							name = null;
						}
						else
						{
							name = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							des = null;
						}
						else
						{
							des = (string)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_GetDes(description, out name, out des);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							object[] arguments2 = methodContext.Arguments;
							arguments2[1] = name;
							arguments2[2] = des;
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
						arguments3[1] = name;
						arguments3[2] = des;
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

		// Token: 0x060017FE RID: 6142 RVA: 0x000C9D37 File Offset: 0x000C7F37
		private void $Rougamo_CloseAllWindows()
		{
			this.careerChoiceParent.gameObject.SetActive(false);
			this.selectHardUI.gameObject.SetActive(false);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000C9D60 File Offset: 0x000C7F60
		private void $Rougamo_Outlobby()
		{
			bool flag = global::GameServer.Instance != null;
			if (flag)
			{
				global::GameServer.Instance.LobbyInfo.AddedPlayers.Clear();
			}
			this.UpdateLobby(new List<LobbyInfo.PlayerInfo>());
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000C9DA0 File Offset: 0x000C7FA0
		private void $Rougamo_Start()
		{
			this.ShowCareer();
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000C9DAC File Offset: 0x000C7FAC
		private void $Rougamo_ReturnHouse()
		{
			GameEntryUI.career = null;
			GameEntryUI.partner = null;
			bool flag = this.hasReturned || UIManager.Instance.GetUI<InkTurnUI>("InkTurnUI") != null || UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (!flag)
			{
				this.hasReturned = true;
				UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
				{
					GameApp.Instance.ReturnToMenu();
					LobbyManager.Instance.QuitLobby();
				}).Forget();
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000C9E44 File Offset: 0x000C8044
		private void $Rougamo_Close()
		{
			bool flag = UIManager.Instance != null && this != null && base.gameObject != null;
			if (flag)
			{
				UIManager.Instance.RemoveUI(base.gameObject.name);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000C9E9F File Offset: 0x000C809F
		private bool $Rougamo_get_isHost()
		{
			return NetworkServer.active;
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000C9EA8 File Offset: 0x000C80A8
		private void $Rougamo_ChangeReady(bool ready)
		{
			GameEntryUI.<>c__DisplayClass22_0 CS$<>8__locals1 = new GameEntryUI.<>c__DisplayClass22_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.readyButton = base.transform.Find("ForeBack/Button");
			Transform readyButton = CS$<>8__locals1.readyButton;
			SwitchButton switchBtn = (readyButton != null) ? readyButton.GetComponent<SwitchButton>() : null;
			bool flag = PlayerManager.Instance == null;
			if (flag)
			{
				bool flag2 = switchBtn != null && switchBtn.isOn;
				if (flag2)
				{
					switchBtn.isOn = false;
				}
			}
			else
			{
				bool flag3 = (!(MapManager.Instance != null) || !(MapManager.Instance.ModeMapManager is TeachMapManager)) && !this.HasPrepared && (RoleTable.Instance == null || !RoleTable.Instance.IsStarted);
				if (flag3)
				{
					UIManager.Instance.ShowModalWindow("Tips", "Before setting out, you should make adventure preparations.".Localize("GameEntryUI"), delegate
					{
						CS$<>8__locals1.<>4__this.OpenChoice();
					}, 0f, delegate
					{
						CS$<>8__locals1.<>4__this.ChangeReady(false);
					}, true, true, "Yes", "No", true);
					this.HasPrepared = true;
				}
				else
				{
					Dictionary<int, NetworkConnectionToClient> connections = NetworkServer.connections;
					int connCount = (connections != null) ? connections.Count : 0;
					Commands.Log("人数", this.waitCount.ToString() + "准备" + connCount.ToString() + "人");
					bool flag4 = PlayerManager.Instance.isServer && this.waitCount >= connCount;
					if (flag4)
					{
						bool hasStartGame = this.HasStartGame;
						if (!hasStartGame)
						{
							this.HasStartGame = true;
							this.StartGame();
						}
					}
					else
					{
						bool isServer = PlayerManager.Instance.isServer;
						if (isServer)
						{
							UIManager.Instance.ShowModalWindow("Tips", "Please wait until everyone is ready before setting off.", null, 1f, null, true, true, "Yes", "No", true);
						}
						else
						{
							GameEntryUI.<>c__DisplayClass22_1 CS$<>8__locals2 = new GameEntryUI.<>c__DisplayClass22_1();
							CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
							bool flag5 = this.selfReady == ready;
							if (!flag5)
							{
								bool flag6 = switchBtn == null;
								if (!flag6)
								{
									this.selfReady = ready;
									switchBtn.isOn = this.selfReady;
									PlayerManager.Instance.CmdReady(this.selfReady, PlayerManager.Instance.PlayerId);
									GameEntryUI.<>c__DisplayClass22_1 CS$<>8__locals3 = CS$<>8__locals2;
									Transform readyButton2 = CS$<>8__locals2.CS$<>8__locals1.readyButton;
									CS$<>8__locals3.maskImage = ((readyButton2 != null) ? readyButton2.GetComponent<Image>() : null);
									bool flag7 = CS$<>8__locals2.maskImage == null || DOTween.IsTweening(CS$<>8__locals2.maskImage, false);
									if (!flag7)
									{
										CS$<>8__locals2.maskImage.DOFillAmount(0f, 0.2f).OnComplete(delegate
										{
											Transform transform = CS$<>8__locals2.CS$<>8__locals1.readyButton.Find("Text");
											TMP_Text btnText = (transform != null) ? transform.GetComponent<TMP_Text>() : null;
											TMP_Text doneText = null;
											for (int i = 2; i <= 4; i++)
											{
												bool flag8 = CS$<>8__locals2.CS$<>8__locals1.<>4__this.transform.Find("Content/" + i.ToString() + "P/RoleParent/role").GetComponent<AnimatorRole>().InstanceId == PlayerManager.Instance.PlayerId;
												if (flag8)
												{
													doneText = CS$<>8__locals2.CS$<>8__locals1.<>4__this.transform.Find("Content/" + i.ToString() + "P/Bottom/Done/text").GetComponent<TMP_Text>();
												}
											}
											string loc = CS$<>8__locals2.CS$<>8__locals1.<>4__this.selfReady ? "Prepared" : "Not ready";
											bool flag9 = btnText != null;
											if (flag9)
											{
												btnText.SetLocalizedText(() => loc.Localize("GameEntryUI"));
											}
											bool flag10 = doneText != null;
											if (flag10)
											{
												doneText.text = loc.Localize("GameEntryUI");
											}
											CS$<>8__locals2.maskImage.DOFillAmount(1f, 0.2f);
										});
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000CA158 File Offset: 0x000C8358
		private void $Rougamo_SetReady(bool ready, string playerId)
		{
			this.waitCount = 1;
			bool flag = !this.Ready.ContainsKey(playerId);
			if (flag)
			{
				this.Ready.Add(playerId, ready);
			}
			else
			{
				this.Ready[playerId] = ready;
			}
			for (int i = 2; i <= 4; i++)
			{
				Transform temp = base.transform.Find("Content/" + i.ToString() + "P");
				AnimatorRole role = temp.Find("RoleParent/role").GetComponent<AnimatorRole>();
				bool flag2 = !string.IsNullOrEmpty(role.InstanceId) && this.Ready.ContainsKey(role.InstanceId) && this.Ready[temp.Find("RoleParent/role").GetComponent<AnimatorRole>().InstanceId];
				if (flag2)
				{
					temp.Find("Bottom/Done/text").GetComponent<TMP_Text>().text = "Prepared".Localize("GameEntryUI");
					this.waitCount++;
				}
				else
				{
					bool flag3 = string.IsNullOrEmpty(role.InstanceId);
					if (flag3)
					{
						temp.Find("Bottom/Done/text").GetComponent<TMP_Text>().text = "";
					}
					else
					{
						temp.Find("Bottom/Done/text").GetComponent<TMP_Text>().text = "Not ready".Localize("GameEntryUI");
					}
				}
			}
			bool isServer = PlayerManager.Instance.isServer;
			if (isServer)
			{
				bool flag4 = this.waitCount >= NetworkServer.connections.Count;
				if (flag4)
				{
					base.transform.Find("ForeBack/Button/Text").GetComponent<TMP_Text>().SetText("Start".Localize("GameEntryUI"));
				}
				else
				{
					base.transform.Find("ForeBack/Button/Text").GetComponent<TMP_Text>().SetText("Wait".Localize("GameEntryUI") + this.waitCount.ToString() + "/" + NetworkServer.connections.Count.ToString());
				}
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000CA37C File Offset: 0x000C857C
		private static void $Rougamo_CheckCareer()
		{
			if (GameEntryUI.career == null)
			{
				GameEntryUI.career = new DataConfig(Singleton<GameConfigManager>.Instance.GetTable(DataType.Career).Getlines()[0]["Id"], DataType.Career);
			}
			RoleTable.Instance.Career = GameEntryUI.career;
			if (GameEntryUI.partner == null)
			{
				GameEntryUI.partner = new DataConfig(Singleton<GameConfigManager>.Instance.GetTable(DataType.Partner).Getlines()[1]["Id"], DataType.Partner);
			}
			bool flag = !RoleTable.Instance.blessingConfigs.Any((DataConfig x) => x.data["Id"] == GameEntryUI.partner.data["Bless"]);
			if (flag)
			{
				RoleTable.Instance.blessingConfigs.Add(new DataConfig(GameEntryUI.partner.data["Bless"], DataType.Bless));
			}
			RoleTable.Instance.MaxSan = int.Parse(GameEntryUI.career.data["SanMax"]) + Singleton<GameRuntimeData>.Instance.Gain["exMaxHp"];
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000CA4A0 File Offset: 0x000C86A0
		private void $Rougamo_OpenChoice()
		{
			bool isStarted = RoleTable.Instance.IsStarted;
			if (!isStarted)
			{
				this.HasPrepared = true;
				bool flag = PlayerManager.Instance != null && NetworkClient.active && NetworkClient.isConnected && NetworkClient.connection != null && NetworkClient.connection.identity != null;
				if (flag)
				{
					PlayerManager.Instance.CmdSendCareer(JsonConvert.SerializeObject(GameEntryUI.career), RoleTable.Instance.Id);
				}
				this.OpenWindow();
				this.careerChoiceParent.GetComponent<CanvasGroup>().alpha = 0f;
				this.careerChoiceParent.GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
				this.careerChoiceParent.gameObject.SetActive(true);
				bool flag2 = !Singleton<GameRuntimeData>.Instance.IsTutorialCompleted.ContainsKey("SecondAD");
				if (flag2)
				{
					Singleton<EventCenter>.Instance.EventTrigger("SecondAD");
				}
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000CA59C File Offset: 0x000C879C
		private void $Rougamo_OpenWindow()
		{
			base.transform.Find("Window Manager").gameObject.SetActive(true);
			this.CloseAllWindows();
			base.transform.Find("ForeBack/Button").gameObject.SetActive(false);
			base.transform.Find("ExitGame").gameObject.SetActive(false);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000CA608 File Offset: 0x000C8808
		private void $Rougamo_CloseWindow()
		{
			base.transform.Find("Window Manager").gameObject.SetActive(false);
			base.transform.Find("ForeBack/Button").gameObject.SetActive(true);
			base.transform.Find("ExitGame").gameObject.SetActive(true);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000CA66C File Offset: 0x000C886C
		private void $Rougamo_OpenSelectHard()
		{
			bool flag = Singleton<GameRuntimeData>.Instance.playCount < 1;
			if (flag)
			{
				UIManager.Instance.ShowModalWindow("Tips", "Go through more adventures to unlock", null, 0f, null, true, true, "Yes", "No", true);
			}
			else
			{
				bool flag2 = RoleTable.Instance == null || RoleTable.Instance.IsStarted;
				if (!flag2)
				{
					this.OpenWindow();
					this.selectHardUI.gameObject.SetActive(true);
					this.selectHardUI.FadeIn();
				}
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000CA6F8 File Offset: 0x000C88F8
		private void $Rougamo_UpdateLobby(List<LobbyInfo.PlayerInfo> players)
		{
			bool flag = this == null || base.gameObject == null;
			if (!flag)
			{
				bool flag2 = players == null;
				if (!flag2)
				{
					GameEntryUI.playerCount = players.Count;
					for (int i = 0; i < players.Count; i++)
					{
						LobbyInfo.PlayerInfo player = players[i];
						bool flag3 = player == null;
						if (!flag3)
						{
							bool steambuild = GameApp.STEAMBUILD;
							if (steambuild)
							{
								int AvatarInt = SteamFriends.GetMediumFriendAvatar(new CSteamID(ulong.Parse(player.Id)));
								bool flag4 = AvatarInt == -1;
								if (flag4)
								{
									return;
								}
								bool flag5 = AvatarInt > 0;
								if (flag5)
								{
									uint width;
									uint height;
									SteamUtils.GetImageSize(AvatarInt, out width, out height);
									bool flag6 = width > 0U && height > 0U;
									if (flag6)
									{
										byte[] avatarStream = new byte[4U * width * height];
										SteamUtils.GetImageRGBA(AvatarInt, avatarStream, (int)(4U * width * height));
										Texture2D avatarTex = new Texture2D((int)width, (int)height, TextureFormat.RGBA32, false);
										avatarTex.LoadRawTextureData(avatarStream);
										avatarTex.Apply();
									}
								}
							}
							this.Ready[player.Id] = false;
							bool flag7 = i == 0;
							if (flag7)
							{
								Transform transform = base.transform.Find("Content/1P/Bottom/Name/text");
								TMP_Text name = (transform != null) ? transform.GetComponent<TMP_Text>() : null;
								bool flag8 = name != null;
								if (flag8)
								{
									name.text = player.Name;
								}
								Transform role = base.transform.Find("Content/1P/RoleParent/role");
								AnimatorRole ar = (role != null) ? role.GetComponent<AnimatorRole>() : null;
								Image img;
								bool flag9;
								if (ar != null)
								{
									img = role.GetComponent<Image>();
									flag9 = (img != null);
								}
								else
								{
									flag9 = false;
								}
								bool flag10 = flag9;
								if (flag10)
								{
									ar.InitSprite(img.sprite, player.Id);
								}
								Transform transform2 = base.transform.Find("Content/1P");
								if (transform2 != null)
								{
									transform2.gameObject.SetActive(true);
								}
							}
							else
							{
								base.transform.Find("Content/" + (i + 1).ToString() + "P").gameObject.SetActive(true);
								TMP_Text name2;
								bool flag11 = base.transform.Find("Content/" + (i + 1).ToString() + "P/Bottom/Name/text").TryGetComponent<TMP_Text>(out name2);
								if (flag11)
								{
									name2.text = player.Name;
								}
								Transform temp = base.transform.Find("Content/" + (i + 1).ToString() + "P");
								Transform role2 = base.transform.Find("Content/" + (i + 1).ToString() + "P/RoleParent/role");
								AnimatorRole ar2;
								Image img2;
								bool flag12 = role2.TryGetComponent<AnimatorRole>(out ar2) && role2.TryGetComponent<Image>(out img2);
								if (flag12)
								{
									ar2.InitSprite(img2.sprite, player.Id);
								}
								bool flag13 = string.IsNullOrEmpty(role2.GetComponent<AnimatorRole>().InstanceId);
								if (flag13)
								{
									temp.Find("Bottom/Done/text").GetComponent<TMP_Text>().text = "";
								}
								else
								{
									temp.Find("Bottom/Done/text").GetComponent<TMP_Text>().text = "Not ready".Localize("GameEntryUI");
								}
								bool flag14 = players[i].Id == PlayerManager.Instance.PlayerId;
								if (flag14)
								{
									base.transform.Find("Content/" + i.ToString() + "P").GetComponent<SelectMessage>().msg = "Career choice".Localize("GameEntryUI");
								}
							}
						}
					}
					bool flag15 = PlayerManager.Instance != null && PlayerManager.Instance.isServer;
					if (flag15)
					{
						PlayerManager.Instance.CmdSendSave();
						for (int j = 2; j < 5; j++)
						{
							Transform transform3 = base.transform.Find("Content/" + j.ToString() + "P");
							ButtonManager content2P = (transform3 != null) ? transform3.GetComponent<ButtonManager>() : null;
							bool flag16 = content2P != null;
							if (flag16)
							{
								bool flag17 = players.Count < j && (!(MapManager.Instance != null) || !(MapManager.Instance.ModeMapManager is TeachMapManager));
								if (flag17)
								{
									content2P.onClick.AddListener(delegate
									{
										bool steambuild2 = GameApp.STEAMBUILD;
										if (steambuild2)
										{
											SteamFriends.ActivateGameOverlayInviteDialog(new CSteamID(LobbyManager.Instance.lobbyId));
										}
									});
								}
								else
								{
									content2P.onClick.RemoveAllListeners();
								}
							}
						}
					}
					Dictionary<int, NetworkConnectionToClient> connections = NetworkServer.connections;
					int connCount = (connections != null) ? connections.Count : 0;
					Transform transform4 = base.transform.Find("ForeBack/Button/Text");
					TMP_Text btnText = (transform4 != null) ? transform4.GetComponent<TMP_Text>() : null;
					bool flag18 = PlayerManager.Instance != null && btnText != null;
					if (flag18)
					{
						bool isServer = PlayerManager.Instance.isServer;
						if (isServer)
						{
							bool flag19 = this.waitCount >= connCount;
							if (flag19)
							{
								btnText.SetText("Start".Localize("GameEntryUI"));
							}
							else
							{
								btnText.SetText("Wait".Localize("GameEntryUI") + this.waitCount.ToString() + "/" + connCount.ToString());
							}
						}
						else
						{
							bool flag20 = this.selfReady;
							if (flag20)
							{
								btnText.SetText("Prepared".Localize("GameEntryUI"));
							}
							else
							{
								btnText.SetText("Not ready".Localize("GameEntryUI"));
							}
						}
					}
					RoleTable instance = RoleTable.Instance;
					bool flag21 = ((instance != null) ? instance.Career : null) != null;
					if (flag21)
					{
						UniTask.WaitUntil(() => PlayerManager.Instance != null && NetworkClient.active && NetworkClient.isConnected && NetworkClient.connection != null && NetworkClient.connection.identity != null, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
						{
							PlayerManager.Instance.CmdSendCareer(JsonConvert.SerializeObject(RoleTable.Instance.Career), PlayerManager.Instance.PlayerId);
						}).Forget();
					}
					GameApp instance2 = GameApp.Instance;
					if (instance2 != null)
					{
						instance2.SetSteamRichState("InLobby");
					}
				}
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000CAD3E File Offset: 0x000C8F3E
		private static DataConfig $Rougamo_get_career()
		{
			return GameEntryUI.<career>k__BackingField;
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x000CAD45 File Offset: 0x000C8F45
		private static void $Rougamo_set_career(DataConfig value)
		{
			GameEntryUI.<career>k__BackingField = value;
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000CAD50 File Offset: 0x000C8F50
		private void $Rougamo_ShowDetail(ShowCareer thiscareer, string way, [Optional] bool ischangeRole)
		{
			Transform tempParent = base.transform.Find("Window Manager/Windows/道途/Content/" + way + "Choice");
			bool flag = way == "Career";
			if (flag)
			{
				bool flag2 = GameEntryUI.career == thiscareer.dataConfig;
				if (flag2)
				{
					return;
				}
				Sprite sprite = ResourceLoader.Load<Sprite>(thiscareer.dataConfig.data["CareerImage"], true);
				bool flag3 = sprite != null;
				if (flag3)
				{
					tempParent.Find("CareerShow/CareerChoice/Image").GetComponent<Image>().sprite = sprite;
				}
				tempParent.Find("RoleParent/Role").GetComponent<AnimatorRole>().Init(thiscareer.dataConfig, "", true);
				GameEntryUI.career = thiscareer.dataConfig;
				bool flag4 = RoleTable.Instance != null;
				if (flag4)
				{
					RoleTable.Instance.Career = GameEntryUI.career;
				}
				bool flag5 = this.lastcareer == null || this.lastcareer != GameEntryUI.career;
				if (flag5)
				{
					base.transform.Find("Content/EmojiPanelUI").GetComponent<EmojiPanelUI>().CreateEmoji();
					this.lastcareer = GameEntryUI.career;
				}
				bool flag6 = PlayerManager.Instance != null && NetworkClient.active && NetworkClient.isConnected && NetworkClient.connection != null && NetworkClient.connection.identity != null;
				if (flag6)
				{
					PlayerManager.Instance.CmdSendCareer(JsonConvert.SerializeObject(GameEntryUI.career), PlayerManager.Instance.PlayerId);
				}
			}
			else
			{
				bool flag7 = GameEntryUI.partner == thiscareer.dataConfig;
				if (flag7)
				{
					return;
				}
				GameEntryUI.partner = thiscareer.dataConfig;
				tempParent.Find("RoleParent/Role").GetComponent<AnimatorRole>().Init(GameEntryUI.partner, "", true);
			}
			this.ChangeCareerDesShow(thiscareer.dataConfig, tempParent);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000CAF30 File Offset: 0x000C9130
		private void $Rougamo_ChangeCareerDesShow(DataConfig thiscareer, Transform tempParent)
		{
			bool flag = thiscareer != null;
			if (flag)
			{
				int i = 0;
				for (int j = 1; j < 4; j++)
				{
					tempParent.Find("tags/Item" + j.ToString()).gameObject.SetActive(false);
				}
				for (int k = 1; k <= 3; k++)
				{
					string temp = thiscareer.data.Localize("Action" + k.ToString());
					bool flag2 = string.IsNullOrEmpty(temp);
					if (flag2)
					{
						break;
					}
					string name;
					string des;
					this.GetDes(temp, out name, out des);
					i++;
					Transform tagItem = tempParent.Find("tags/Item" + k.ToString());
					tagItem.gameObject.SetActive(true);
					tagItem.Find("text").GetComponent<TextMeshProUGUI>().text = "Active skill".Localize("Tips") + ":" + name;
					List<string> keyWords = new List<string>();
					des = des.Highlight(keyWords);
					tagItem.GetComponent<KeywordDisplay>().SetText(name, des, keyWords, null, null, "Skill");
					tagItem.Find("background").GetComponent<Image>().sprite = ResourceLoader.LoadAll<Sprite>("Icon/UI_Icons/Native/状态/技能框")[0];
					bool flag3 = i == 3;
					if (flag3)
					{
						return;
					}
				}
				for (int l = 1; l <= 3; l++)
				{
					string temp2 = thiscareer.data.Localize("Passive" + l.ToString());
					bool flag4 = string.IsNullOrEmpty(temp2);
					if (flag4)
					{
						break;
					}
					string name2;
					string des2;
					this.GetDes(temp2, out name2, out des2);
					i++;
					Transform tagItem2 = tempParent.Find("tags/Item" + i.ToString());
					tagItem2.gameObject.SetActive(true);
					tagItem2.Find("text").GetComponent<TextMeshProUGUI>().text = "Passive skill".Localize("Tips") + ":" + name2;
					List<string> keyWords2 = new List<string>();
					des2 = des2.Highlight(keyWords2);
					tagItem2.GetComponent<KeywordDisplay>().SetText(name2, des2, keyWords2, null, null, "Skill");
					tagItem2.Find("background").GetComponent<Image>().sprite = ResourceLoader.LoadAll<Sprite>("Icon/UI_Icons/Native/状态/技能框")[1];
					bool flag5 = i == 3;
					if (flag5)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000CB1B8 File Offset: 0x000C93B8
		private void $Rougamo_ChangeRole(DataConfig dataConfig, string fromId)
		{
			UniTask.WaitUntil(() => PlayerManager.Instance != null && PlayerManager.Instance.playerInfo != null, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				bool flag = PlayerManager.Instance.isServer && global::GameServer.Instance.RoleTables.ContainsKey(fromId);
				if (flag)
				{
					global::GameServer.Instance.RoleTables[fromId].Career = dataConfig;
				}
				AnimatorRole p = this.transform.Find("Content/1P/RoleParent/role").GetComponent<AnimatorRole>();
				AnimatorRole p2 = this.transform.Find("Content/2P/RoleParent/role").GetComponent<AnimatorRole>();
				AnimatorRole p3 = this.transform.Find("Content/3P/RoleParent/role").GetComponent<AnimatorRole>();
				AnimatorRole p4 = this.transform.Find("Content/4P/RoleParent/role").GetComponent<AnimatorRole>();
				bool flag2 = p.InstanceId == fromId;
				AnimatorRole temp;
				if (flag2)
				{
					temp = p;
				}
				else
				{
					bool flag3 = p2.InstanceId == fromId;
					if (flag3)
					{
						temp = p2;
					}
					else
					{
						bool flag4 = p3.InstanceId == fromId;
						if (flag4)
						{
							temp = p3;
						}
						else
						{
							temp = p4;
						}
					}
				}
				temp.Init(dataConfig, fromId, true);
				bool flag5 = temp.InstanceId == PlayerManager.Instance.PlayerId;
				if (flag5)
				{
					temp.transform.parent.parent.GetComponent<SelectMessage>().msg = "Career choice".Localize("GameEntryUI");
				}
			}).Forget();
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000CB224 File Offset: 0x000C9424
		private void $Rougamo_GetDes(string description, out string name, out string des)
		{
			name = "";
			des = "";
			string namePattern = "<name>(.*?)<\\/name>";
			string desPattern = "<des>(.*?)<\\/des>";
			Match nameMatch = Regex.Match(description, namePattern, RegexOptions.Singleline);
			Match desMatch = Regex.Match(description, desPattern, RegexOptions.Singleline);
			bool success = nameMatch.Success;
			if (success)
			{
				name = nameMatch.Groups[1].Value;
			}
			bool success2 = desMatch.Success;
			if (success2)
			{
				des = desMatch.Groups[1].Value;
			}
		}

		// Token: 0x040012B2 RID: 4786
		private Transform MainVar;

		// Token: 0x040012B3 RID: 4787
		private Transform SecondVar;

		// Token: 0x040012B4 RID: 4788
		public Transform MainParent;

		// Token: 0x040012B5 RID: 4789
		public Transform SecondParent;

		// Token: 0x040012B6 RID: 4790
		public SelectHardUI selectHardUI;

		// Token: 0x040012B7 RID: 4791
		public Transform careerChoiceParent;

		// Token: 0x040012B8 RID: 4792
		private Dictionary<string, bool> Ready = new Dictionary<string, bool>();

		// Token: 0x040012B9 RID: 4793
		private bool selfReady = false;

		// Token: 0x040012BA RID: 4794
		private bool hasReturned = false;

		// Token: 0x040012BB RID: 4795
		public static SaveInfo selectedSave;

		// Token: 0x040012BC RID: 4796
		public int waitCount = 1;

		// Token: 0x040012BD RID: 4797
		private bool HasPrepared = false;

		// Token: 0x040012BE RID: 4798
		private bool HasStartGame = false;

		// Token: 0x040012BF RID: 4799
		public static int playerCount;

		// Token: 0x040012C0 RID: 4800
		public int careerIndex = 0;

		// Token: 0x040012C1 RID: 4801
		public int partnerIndex = 0;

		// Token: 0x040012C2 RID: 4802
		public List<ShowCareer> showCareers = new List<ShowCareer>();

		// Token: 0x040012C3 RID: 4803
		public List<ShowCareer> showPartners = new List<ShowCareer>();

		// Token: 0x040012C4 RID: 4804
		public DataConfig lastcareer = null;

		// Token: 0x040012C6 RID: 4806
		public static DataConfig partner;
	}
}

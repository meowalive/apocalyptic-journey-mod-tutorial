using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Network.Query;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200029E RID: 670
	public class TopBarUI : UIBase
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x000A60F4 File Offset: 0x000A42F4
		public RoleTable roleTable
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
				methodContext.TargetType = typeof(TopBarUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.get_roleTable()).MethodHandle, typeof(TopBarUI).TypeHandle);
				methodContext.Arguments = new object[0];
				RoleTable roleTable;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						roleTable = (RoleTable)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								roleTable = this.$Rougamo_get_roleTable();
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
									roleTable = (RoleTable)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = roleTable;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							roleTable = (RoleTable)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return roleTable;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000A6234 File Offset: 0x000A4434
		private bool isMultiplayer
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
				methodContext.TargetType = typeof(TopBarUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.get_isMultiplayer()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
								flag = this.$Rougamo_get_isMultiplayer();
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

		// Token: 0x06001504 RID: 5380 RVA: 0x000A6378 File Offset: 0x000A4578
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
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.Awake()).MethodHandle, typeof(TopBarUI).TypeHandle);
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

		// Token: 0x06001505 RID: 5381 RVA: 0x000A6474 File Offset: 0x000A4674
		public void CreateConnectPlayerStatus(List<string> players)
		{
			bool flag = !this.isMultiplayer || players == null;
			if (!flag)
			{
				Transform listRoot = base.transform.Find("Content/PlayerStatusList");
				bool flag2 = listRoot == null;
				if (!flag2)
				{
					foreach (object obj in listRoot)
					{
						Transform item = (Transform)obj;
						bool flag3 = item.gameObject != this.mainStatus;
						if (flag3)
						{
							Singleton<ObjectPool>.Instance.Release(item.gameObject);
						}
					}
					foreach (string item2 in players)
					{
						GameObject playerStatus = null;
						string a = item2;
						RoleTable instance = RoleTable.Instance;
						bool flag4 = a == ((instance != null) ? instance.Id : null) && this.mainStatus != null;
						if (flag4)
						{
							playerStatus = this.mainStatus;
							Transform avatar = playerStatus.transform.Find("Avatar");
							if (!(avatar != null))
							{
								goto IL_14D;
							}
							RoleTable instance2 = RoleTable.Instance;
							bool flag5;
							if (instance2 == null)
							{
								flag5 = (null != null);
							}
							else
							{
								DataConfig career = instance2.Career;
								flag5 = (((career != null) ? career.data : null) != null);
							}
							if (!flag5)
							{
								goto IL_14D;
							}
							string avatarPath;
							bool flag6 = RoleTable.Instance.Career.data.TryGetValue("Avatar", out avatarPath);
							IL_14E:
							bool flag7 = flag6;
							if (flag7)
							{
								avatar.GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(avatarPath, true);
							}
							goto IL_193;
							IL_14D:
							flag6 = false;
							goto IL_14E;
						}
						bool flag8 = this.statusPrefab != null;
						if (flag8)
						{
							playerStatus = Singleton<ObjectPool>.Instance.Get(this.statusPrefab, listRoot);
						}
						IL_193:
						bool flag9 = playerStatus == null;
						if (!flag9)
						{
							TopStatusItem statusItem = playerStatus.GetComponent<TopStatusItem>();
							bool flag10 = statusItem != null;
							if (flag10)
							{
								statusItem.Init(new RoleTable
								{
									Id = item2
								});
								this.IdToStatusItem[item2] = statusItem;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x000A66B4 File Offset: 0x000A48B4
		public void ChangeCareerAvator()
		{
			this.hasCareer = true;
			List<string> players = (from x in PlayerManager.Instance.LobbyInfos.AddedPlayers
			select x.Id).ToList<string>();
			using (List<string>.Enumerator enumerator = players.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string item = enumerator.Current;
					bool flag = !this.IdToStatusItem.ContainsKey(item);
					if (flag)
					{
						break;
					}
					bool flag2 = item != RoleTable.Instance.Id;
					if (flag2)
					{
						PlayerManager.Instance.SendQuery<StatusUIData>(new QueryStatus(item), delegate(StatusUIData result)
						{
							this.IdToStatusItem[item].CareerInit(result);
						});
					}
					else
					{
						this.IdToStatusItem[item].CareerInit(new StatusUIData(this.roleTable));
					}
				}
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x000A67D8 File Offset: 0x000A49D8
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
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.OnDestroy()).MethodHandle, typeof(TopBarUI).TypeHandle);
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

		// Token: 0x06001508 RID: 5384 RVA: 0x000A68D4 File Offset: 0x000A4AD4
		[DebuggerStepThrough]
		public override void FadeIn()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.FadeIn()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_FadeIn();
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

		// Token: 0x06001509 RID: 5385 RVA: 0x000A69D0 File Offset: 0x000A4BD0
		[DebuggerStepThrough]
		public void FightHide()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.FightHide()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_FightHide();
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

		// Token: 0x0600150A RID: 5386 RVA: 0x000A6ACC File Offset: 0x000A4CCC
		[DebuggerStepThrough]
		public void HideLeftUp()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.HideLeftUp()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_HideLeftUp();
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

		// Token: 0x0600150B RID: 5387 RVA: 0x000A6BC8 File Offset: 0x000A4DC8
		[DebuggerStepThrough]
		public void ShowLeftUp()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.ShowLeftUp()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_ShowLeftUp();
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

		// Token: 0x0600150C RID: 5388 RVA: 0x000A6CC4 File Offset: 0x000A4EC4
		[DebuggerStepThrough]
		public void OnGameRuntimeDataChanged(object sender, PropertyChangedEventArgs args)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.OnGameRuntimeDataChanged(object, PropertyChangedEventArgs)).MethodHandle, typeof(TopBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				sender,
				args
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
							sender = null;
						}
						else
						{
							sender = arguments[0];
						}
						if (arguments[1] == null)
						{
							args = null;
						}
						else
						{
							args = (PropertyChangedEventArgs)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_OnGameRuntimeDataChanged(sender, args);
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
								goto IL_118;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_118:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000A6E10 File Offset: 0x000A5010
		[DebuggerStepThrough]
		public void OnRoleTableChanged(object sender, PropertyChangedEventArgs args)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.OnRoleTableChanged(object, PropertyChangedEventArgs)).MethodHandle, typeof(TopBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				sender,
				args
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
							sender = null;
						}
						else
						{
							sender = arguments[0];
						}
						if (arguments[1] == null)
						{
							args = null;
						}
						else
						{
							args = (PropertyChangedEventArgs)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_OnRoleTableChanged(sender, args);
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
								goto IL_118;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_118:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000A6F5C File Offset: 0x000A515C
		public void ChangeVar()
		{
			bool connectMode = this.ConnectMode;
			if (!connectMode)
			{
				bool flag = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
				if (flag)
				{
					foreach (KeyValuePair<string, int> item in FightManager.Instance.TempVarsMap)
					{
						Transform varItem = this.varList.Find(item.Key);
						bool flag2 = varItem != null;
						if (flag2)
						{
							varItem.Find("Val").GetComponent<TextMeshProUGUI>().text = item.Value.ToString("D2");
						}
					}
				}
				else
				{
					foreach (KeyValuePair<string, int> item2 in RoleTable.Instance.VarsMap)
					{
						Transform varItem2 = this.varList.Find(item2.Key);
						varItem2.Find("Val").GetComponent<TextMeshProUGUI>().text = item2.Value.ToString("D2");
					}
				}
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000A70C0 File Offset: 0x000A52C0
		[DebuggerStepThrough]
		public void ShowSetting()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.ShowSetting()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_ShowSetting();
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

		// Token: 0x06001510 RID: 5392 RVA: 0x000A71BC File Offset: 0x000A53BC
		[DebuggerStepThrough]
		public void ShowDict()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.ShowDict()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_ShowDict();
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

		// Token: 0x06001511 RID: 5393 RVA: 0x000A72B8 File Offset: 0x000A54B8
		private void Start()
		{
			bool isMultiplayer = this.isMultiplayer;
			if (isMultiplayer)
			{
				this.ConnectMode = true;
				base.transform.Find("Content/PlayerStatus").gameObject.SetActive(false);
				base.transform.Find("Content/PlayerStatusList").gameObject.SetActive(true);
				this.RelicList = base.transform.Find("Content/PlayerStatusList/PlayerStatus/Relic/Scroll Area/List");
			}
			else
			{
				this.ConnectMode = false;
				base.transform.Find("Content/PlayerStatus").gameObject.SetActive(true);
				base.transform.Find("Content/PlayerStatusList").gameObject.SetActive(false);
			}
			this.ChangeTrue();
			this.ChangeVar();
			foreach (object obj in base.transform.Find("Content/Buttons"))
			{
				Transform child = (Transform)obj;
				KeyItem key = child.gameObject.AddComponent<KeyItem>();
				key.msg = child.name;
			}
			this.ChangeSan(this.roleTable.Id);
			this.UpdateRelics();
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000A7400 File Offset: 0x000A5600
		[DebuggerStepThrough]
		public void OtherChangeShow(string value, string fromId, string type)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.OtherChangeShow(string, string, string)).MethodHandle, typeof(TopBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				value,
				fromId,
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
							value = null;
						}
						else
						{
							value = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							fromId = null;
						}
						else
						{
							fromId = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							type = null;
						}
						else
						{
							type = (string)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_OtherChangeShow(value, fromId, type);
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

		// Token: 0x06001513 RID: 5395 RVA: 0x000A7574 File Offset: 0x000A5774
		[DebuggerStepThrough]
		public void TryReturn()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.TryReturn()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_TryReturn();
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

		// Token: 0x06001514 RID: 5396 RVA: 0x000A7670 File Offset: 0x000A5870
		[DebuggerStepThrough]
		public void ReturnToMenu()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.ReturnToMenu()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_ReturnToMenu();
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

		// Token: 0x06001515 RID: 5397 RVA: 0x000A776C File Offset: 0x000A596C
		[DebuggerStepThrough]
		public void OpenBackpack()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.OpenBackpack()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_OpenBackpack();
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

		// Token: 0x06001516 RID: 5398 RVA: 0x000A7868 File Offset: 0x000A5A68
		public void ChangeCareer()
		{
			RoleTable instance = RoleTable.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				DataConfig career = instance.Career;
				obj = ((career != null) ? career.data : null);
			}
			bool flag = obj == null;
			if (!flag)
			{
				bool flag2 = !this.ConnectMode;
				if (flag2)
				{
					Transform avatarTf = base.transform.Find("Content/PlayerStatus/Avatar");
					string avatarPath;
					bool flag3 = avatarTf != null && avatarTf.GetComponent<Image>() != null && RoleTable.Instance.Career.data.TryGetValue("Avatar", out avatarPath);
					if (flag3)
					{
						avatarTf.GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(avatarPath, true);
					}
				}
				else
				{
					GameServer instance2 = GameServer.Instance;
					bool flag4 = ((instance2 != null) ? instance2.RoleTables : null) == null || this.IdToStatusItem == null || !PlayerManager.Instance.isServer;
					if (!flag4)
					{
						foreach (KeyValuePair<string, TopStatusItem> item in this.IdToStatusItem)
						{
							bool flag5 = GameServer.Instance.RoleTables.ContainsKey(item.Key) && item.Value != null;
							if (flag5)
							{
								item.Value.ShowCareer();
							}
						}
					}
				}
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000A79CC File Offset: 0x000A5BCC
		[DebuggerStepThrough]
		public void ChangeSan(string roleid = null)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.ChangeSan(string)).MethodHandle, typeof(TopBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				roleid
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
							roleid = null;
						}
						else
						{
							roleid = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ChangeSan(roleid);
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

		// Token: 0x06001518 RID: 5400 RVA: 0x000A7B00 File Offset: 0x000A5D00
		[DebuggerStepThrough]
		public void UpdateDefend(string Defend)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.UpdateDefend(string)).MethodHandle, typeof(TopBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				Defend
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
							Defend = null;
						}
						else
						{
							Defend = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_UpdateDefend(Defend);
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

		// Token: 0x06001519 RID: 5401 RVA: 0x000A7C34 File Offset: 0x000A5E34
		public void HideDefend()
		{
			bool flag = !this.ConnectMode;
			if (flag)
			{
				base.transform.Find("Content/PlayerStatus/FightStatus/Health/HealthBar/DefendBar").gameObject.SetActive(false);
				base.transform.Find("Content/PlayerStatus/FightStatus/Health/HealthBar/val").GetComponent<TMP_Text>().text = this.roleTable.San.ToString() + "/" + this.roleTable.MaxSan.ToString();
			}
			else
			{
				foreach (KeyValuePair<string, TopStatusItem> item in this.IdToStatusItem)
				{
					item.Value.HideDefend();
				}
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000A7D0C File Offset: 0x000A5F0C
		[DebuggerStepThrough]
		public void ChangeMoney()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.ChangeMoney()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_ChangeMoney();
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

		// Token: 0x0600151B RID: 5403 RVA: 0x000A7E08 File Offset: 0x000A6008
		[DebuggerStepThrough]
		public void ChangeTrue()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.ChangeTrue()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_ChangeTrue();
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

		// Token: 0x0600151C RID: 5404 RVA: 0x000A7F04 File Offset: 0x000A6104
		public void UpdateRelics()
		{
			GameObject relicPrefab = this.RelicList.Find("Item0").gameObject;
			GameObject nullPrefab = this.RelicList.Find("NullPrefab").gameObject;
			for (int i = this.RelicList.childCount - 1; i >= 0; i--)
			{
				Transform child = this.RelicList.GetChild(i);
				bool flag = child == null || child.name == "Item0" || child.name == "NullPrefab";
				if (!flag)
				{
					UnityEngine.Object.Destroy(child.gameObject);
				}
			}
			foreach (DataConfig item in this.roleTable.relicList)
			{
				GameObject TopRelicItem = UnityEngine.Object.Instantiate<GameObject>(relicPrefab, this.RelicList);
				RelicItemConfig relicItemConfig = TopRelicItem.GetComponent<RelicItemConfig>();
				relicItemConfig.Init(item);
				relicItemConfig.ifEquipped = true;
				TopRelicItem.name = item.data.Localize("Name");
				TopRelicItem.SetActive(true);
				relicItemConfig.relicSelectUI = this.relicSelectUI;
			}
			for (int j = 0; j < 6 - this.roleTable.relicList.Count; j++)
			{
				GameObject relicItem = UnityEngine.Object.Instantiate<GameObject>(nullPrefab, this.RelicList);
				relicItem.name = "Null";
				relicItem.SetActive(true);
			}
			this.UpdateRelicCountShow();
			this.ChangeMoney();
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000A80AC File Offset: 0x000A62AC
		[DebuggerStepThrough]
		public void SetRelicGlowEvent()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.SetRelicGlowEvent()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_SetRelicGlowEvent();
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

		// Token: 0x0600151E RID: 5406 RVA: 0x000A81A8 File Offset: 0x000A63A8
		public void UpdateRelicCountShow()
		{
			foreach (object obj in this.RelicList)
			{
				Transform item = (Transform)obj;
				string name = item.name;
				bool flag = name == "Item0" || name == "NullPrefab" || name == "Null";
				if (!flag)
				{
					RelicItemConfig relicItemConfig = item.GetComponent<RelicItemConfig>();
					int count = int.Parse(relicItemConfig.dataConfig.Vars["ThisCount"]);
					bool flag2 = count > 0;
					if (flag2)
					{
						item.Find("Normal/Icon Parent/Count").gameObject.SetActive(true);
						item.Find("Highlighted/Icon Parent/Count").gameObject.SetActive(true);
						item.Find("Normal/Icon Parent/Count").GetComponent<TMP_Text>().text = relicItemConfig.dataConfig.Vars["ThisCount"];
						item.Find("Highlighted/Icon Parent/Count").GetComponent<TMP_Text>().text = relicItemConfig.dataConfig.Vars["ThisCount"];
					}
					else
					{
						item.Find("Normal/Icon Parent/Count").gameObject.SetActive(false);
						item.Find("Highlighted/Icon Parent/Count").gameObject.SetActive(false);
					}
				}
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000A8340 File Offset: 0x000A6540
		[DebuggerStepThrough]
		private void OnhasCardDeckBtn()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.OnhasCardDeckBtn()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_OnhasCardDeckBtn();
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

		// Token: 0x06001520 RID: 5408 RVA: 0x000A843C File Offset: 0x000A663C
		[DebuggerStepThrough]
		public void ListenVars()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TopBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TopBarUI.ListenVars()).MethodHandle, typeof(TopBarUI).TypeHandle);
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
							this.$Rougamo_ListenVars();
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

		// Token: 0x06001525 RID: 5413 RVA: 0x000A4E4A File Offset: 0x000A304A
		private RoleTable $Rougamo_get_roleTable()
		{
			return RoleTable.Instance;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000A8630 File Offset: 0x000A6830
		private bool $Rougamo_get_isMultiplayer()
		{
			return GameEntryUI.playerCount > 1;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000A863C File Offset: 0x000A683C
		private void $Rougamo_Awake()
		{
			base.transform.Find("Content/Buttons/CardBack").GetComponent<ButtonManager>().onClick.AddListener(new UnityAction(this.OnhasCardDeckBtn));
			Singleton<GameRuntimeData>.Instance.PropertyChanged += this.OnGameRuntimeDataChanged;
			((INotifyPropertyChanged)RoleTable.Instance).PropertyChanged += this.OnRoleTableChanged;
			PlayerManager instance = PlayerManager.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				LobbyInfo lobbyInfos = instance.LobbyInfos;
				obj = ((lobbyInfos != null) ? lobbyInfos.AddedPlayers : null);
			}
			bool flag = obj != null;
			if (flag)
			{
				this.CreateConnectPlayerStatus((from x in PlayerManager.Instance.LobbyInfos.AddedPlayers
				select x.Id).ToList<string>());
			}
			UniTask.WaitForSeconds(3f, false, PlayerLoopTiming.Update, this.GetCancellationTokenOnDestroy(), false).ContinueWith(delegate()
			{
				bool flag2 = !this.hasCareer;
				if (flag2)
				{
					this.ChangeCareerAvator();
				}
			}).Forget();
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000A8734 File Offset: 0x000A6934
		private void $Rougamo_OnDestroy()
		{
			Singleton<GameRuntimeData>.Instance.PropertyChanged -= this.OnGameRuntimeDataChanged;
			bool flag = RoleTable.Instance != null;
			if (flag)
			{
				((INotifyPropertyChanged)RoleTable.Instance).PropertyChanged -= this.OnRoleTableChanged;
			}
			base.OnDestroy();
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_FadeIn()
		{
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000A8785 File Offset: 0x000A6985
		private void $Rougamo_FightHide()
		{
			this.HideDefend();
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000A8790 File Offset: 0x000A6990
		private void $Rougamo_HideLeftUp()
		{
			base.transform.Find("Content/PlayerStatus").gameObject.SetActive(false);
			base.transform.Find("Content/PlayerStatusList").gameObject.SetActive(false);
			base.transform.Find("Content/Wealth").gameObject.SetActive(false);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000A87F4 File Offset: 0x000A69F4
		private void $Rougamo_ShowLeftUp()
		{
			bool connectMode = this.ConnectMode;
			if (connectMode)
			{
				base.transform.Find("Content/PlayerStatusList").gameObject.SetActive(true);
			}
			else
			{
				base.transform.Find("Content/PlayerStatus").gameObject.SetActive(true);
			}
			base.transform.Find("Content/Wealth").gameObject.SetActive(true);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x000A8868 File Offset: 0x000A6A68
		private void $Rougamo_OnGameRuntimeDataChanged(object sender, PropertyChangedEventArgs args)
		{
			bool flag = args.PropertyName == "Truth";
			if (flag)
			{
				this.ChangeTrue();
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000A8894 File Offset: 0x000A6A94
		private void $Rougamo_OnRoleTableChanged(object sender, PropertyChangedEventArgs args)
		{
			string propertyName = args.PropertyName;
			string a = propertyName;
			if (!(a == "San") && !(a == "MaxSan"))
			{
				if (!(a == "relicList"))
				{
					if (!(a == "Money"))
					{
						if (a == "VarsMap")
						{
							this.ChangeVar();
						}
					}
					else
					{
						this.ChangeMoney();
					}
				}
				else
				{
					this.UpdateRelics();
				}
			}
			else
			{
				this.ChangeSan(RoleTable.Instance.Id);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000A891C File Offset: 0x000A6B1C
		private void $Rougamo_ShowSetting()
		{
			UIManager.Instance.ShowUI<SettingUI>("SettingUI", true);
			UIManager.Instance.GetUI<SettingUI>("SettingUI").transform.SetAsLastSibling();
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000A894A File Offset: 0x000A6B4A
		private void $Rougamo_ShowDict()
		{
			UIManager.Instance.ShowUI<DictionaryUI>("DictionaryUI", true);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000A8960 File Offset: 0x000A6B60
		private void $Rougamo_OtherChangeShow(string value, string fromId, string type)
		{
			bool flag = this.IdToStatusItem.ContainsKey(fromId);
			if (flag)
			{
				this.IdToStatusItem[fromId].OtherChangeShow(value, type);
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000A8994 File Offset: 0x000A6B94
		private void $Rougamo_TryReturn()
		{
			UIManager.Instance.ShowModalWindow("Tips", "Return to the main menu?".Localize("TopBarUI"), delegate
			{
				this.ReturnToMenu();
			}, 0f, null, true, true, "Yes", "No", true);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000A89E0 File Offset: 0x000A6BE0
		private void $Rougamo_ReturnToMenu()
		{
			bool flag = this.hasReturned || UIManager.Instance.GetUI<InkTurnUI>("InkTurnUI") != null || UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (!flag)
			{
				this.hasReturned = true;
				SafeBoxUI.ClearList();
				bool flag2 = GameObject.Find("Breaks") != null;
				if (flag2)
				{
					UnityEngine.Object.Destroy(GameObject.Find("Breaks"));
				}
				UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
				{
					GameApp.Instance.ReturnToMenu();
					LobbyManager.Instance.QuitLobby();
				}).Forget();
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000A8A98 File Offset: 0x000A6C98
		private void $Rougamo_OpenBackpack()
		{
			BackpackUI backpackUI = UIManager.Instance.GetUI<BackpackUI>("BackpackUI");
			backpackUI.ShowStatus(new StatusUIData(RoleTable.Instance));
			backpackUI.gameObject.SetActive(true);
			backpackUI.gameObject.GetComponent<CanvasGroup>().DOFade(1f, 0.2f).OnComplete(delegate
			{
				backpackUI.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
			});
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000A8B1C File Offset: 0x000A6D1C
		private void $Rougamo_ChangeSan([Optional] string roleid)
		{
			bool flag = roleid == null;
			if (!flag)
			{
				bool flag2 = !this.ConnectMode;
				if (flag2)
				{
					ResourceLoader.Load<Material>("Material/PostProcess/ScreenLight", true).SetInt("_Enabled", ((float)this.roleTable.san < (float)this.roleTable.maxSan * 0.2f) ? 1 : 0);
					base.transform.Find("Content/PlayerStatus/FightStatus/Health/HealthBar/val").GetComponent<TMP_Text>().text = this.roleTable.San.ToString() + "/" + this.roleTable.MaxSan.ToString();
					bool flag3 = this.roleTable.MaxSan == 0;
					if (!flag3)
					{
						base.transform.Find("Content/PlayerStatus/FightStatus/Health/HealthBar/Bar").GetComponent<Image>().DOFillAmount((float)this.roleTable.San / (float)this.roleTable.MaxSan, 0.3f);
						base.transform.Find("Content/PlayerStatus/FightStatus/Health/HealthBar").GetComponent<Image>().DOFillAmount((float)this.roleTable.San / (float)this.roleTable.MaxSan, 0.2f).SetDelay(0.3f);
						bool flag4 = FightManager.Instance != null && FightPlayer.Instance != null;
						if (flag4)
						{
							this.UpdateDefend(FightPlayer.Instance.Status.Defend.ToString());
						}
					}
				}
				else
				{
					bool flag5 = this.IdToStatusItem.ContainsKey(roleid);
					if (flag5)
					{
						this.IdToStatusItem[roleid].UpdateStatus();
					}
				}
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000A8CCC File Offset: 0x000A6ECC
		private void $Rougamo_UpdateDefend(string Defend)
		{
			base.transform.Find("Content/PlayerStatus/FightStatus/Health/HealthBar/DefendBar").gameObject.SetActive(true);
			base.transform.Find("Content/PlayerStatus/FightStatus/Health/HealthBar/val").GetComponent<TMP_Text>().text = string.Concat(new string[]
			{
				this.roleTable.San.ToString(),
				"/",
				this.roleTable.MaxSan.ToString(),
				"  (",
				Defend,
				")"
			});
			bool flag = this.roleTable.MaxSan == 0;
			if (!flag)
			{
				base.transform.Find("Content/PlayerStatus/FightStatus/Health/HealthBar/DefendBar").GetComponent<Image>().DOFillAmount(float.Parse(Defend) / (float)this.roleTable.MaxSan, 0.3f);
			}
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000A8DAC File Offset: 0x000A6FAC
		private void $Rougamo_ChangeMoney()
		{
			base.transform.Find("Content/Wealth/Money/val").GetComponent<TMP_Text>().text = this.roleTable.Money.ToString();
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000A8DF0 File Offset: 0x000A6FF0
		private void $Rougamo_ChangeTrue()
		{
			base.transform.Find("Content/Wealth/True/val").GetComponent<TMP_Text>().text = Singleton<GameRuntimeData>.Instance.Truth.ToString();
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000A8E34 File Offset: 0x000A7034
		private void $Rougamo_SetRelicGlowEvent()
		{
			foreach (RelicItemConfig item in this.RelicList.GetComponentsInChildren<RelicItemConfig>())
			{
				string name = item.name;
				bool flag = name == "Item0" || name == "NullPrefab" || name == "Null";
				if (!flag)
				{
					item.SetGlowEvent(item.ifEquipped);
				}
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000A8EB0 File Offset: 0x000A70B0
		private void $Rougamo_OnhasCardDeckBtn()
		{
			bool flag = UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI").SetRole(new OutDeckUIData(this.roleTable));
			}
			UIManager.Instance.ShowUI<OutDeckUI>("OutDeckUI", true);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000A8F0C File Offset: 0x000A710C
		private void $Rougamo_ListenVars()
		{
			Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), delegate()
			{
				foreach (KeyValuePair<string, int> item in FightManager.Instance.TempVarsMap)
				{
					Transform varItem = this.varList.Find(item.Key);
					bool flag = varItem != null;
					if (flag)
					{
						varItem.Find("Name").GetComponent<TextMeshProUGUI>().text = item.Key.Localize("TopBarUI");
					}
				}
			}, this, EventDispose.None);
		}

		// Token: 0x040010D2 RID: 4306
		public Transform RelicList;

		// Token: 0x040010D3 RID: 4307
		public Transform varList;

		// Token: 0x040010D4 RID: 4308
		public RelicSelectUI relicSelectUI;

		// Token: 0x040010D5 RID: 4309
		public bool ConnectMode = false;

		// Token: 0x040010D6 RID: 4310
		public GameObject statusPrefab;

		// Token: 0x040010D7 RID: 4311
		public GameObject mainStatus;

		// Token: 0x040010D8 RID: 4312
		public Dictionary<string, TopStatusItem> IdToStatusItem = new Dictionary<string, TopStatusItem>();

		// Token: 0x040010D9 RID: 4313
		private bool hasCareer = false;

		// Token: 0x040010DA RID: 4314
		private bool hasReturned = false;
	}
}

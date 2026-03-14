using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200033B RID: 827
	public class ModManagerUI : UIBase
	{
		// Token: 0x06001A07 RID: 6663 RVA: 0x000DC270 File Offset: 0x000DA470
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
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.Awake()).MethodHandle, typeof(ModManagerUI).TypeHandle);
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

		// Token: 0x06001A08 RID: 6664 RVA: 0x000DC36C File Offset: 0x000DA56C
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
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.OnEnable()).MethodHandle, typeof(ModManagerUI).TypeHandle);
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

		// Token: 0x06001A09 RID: 6665 RVA: 0x000DC468 File Offset: 0x000DA668
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
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.OnDestroy()).MethodHandle, typeof(ModManagerUI).TypeHandle);
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

		// Token: 0x06001A0A RID: 6666 RVA: 0x000DC564 File Offset: 0x000DA764
		[DebuggerStepThrough]
		public void RefreshFromUI()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.RefreshFromUI()).MethodHandle, typeof(ModManagerUI).TypeHandle);
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
							this.$Rougamo_RefreshFromUI();
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

		// Token: 0x06001A0B RID: 6667 RVA: 0x000DC660 File Offset: 0x000DA860
		public void ToggleLocalMod(SteamWorkshopModInfo info)
		{
			bool flag = info == null || !info.IsLocalMod;
			if (!flag)
			{
				try
				{
					bool nextEnabled = !info.LocalEnabled;
					ModConfig config;
					bool changed;
					bool flag2 = !ModManagerUI.TrySaveLocalModEnabledState(info.LocalDirectory, nextEnabled, out config, out changed);
					if (flag2)
					{
						UIManager instance = UIManager.Instance;
						if (instance != null)
						{
							instance.ShowNotification("Mod", info.Title + " 状态保存失败", 2f);
						}
					}
					else
					{
						info.LocalEnabled = config.Enabled;
						ModManagerUI.UpdateRuntimeModState(info.LocalDirectory, config.Enabled);
						bool flag3 = changed;
						if (flag3)
						{
							this.HasChangeMod = true;
						}
						this.RefreshLocalModList();
					}
				}
				catch (Exception exception)
				{
					Debug.LogException(exception);
					UIManager instance2 = UIManager.Instance;
					if (instance2 != null)
					{
						instance2.ShowNotification("Mod", info.Title + " 状态切换失败", 2f);
					}
				}
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000DC75C File Offset: 0x000DA95C
		[DebuggerStepThrough]
		private void BindUI()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.BindUI()).MethodHandle, typeof(ModManagerUI).TypeHandle);
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
							this.$Rougamo_BindUI();
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

		// Token: 0x06001A0D RID: 6669 RVA: 0x000DC858 File Offset: 0x000DAA58
		[DebuggerStepThrough]
		private UniTaskVoid RefreshSteamWorkshopList()
		{
			ModManagerUI.<RefreshSteamWorkshopList>d__16 <RefreshSteamWorkshopList>d__ = new ModManagerUI.<RefreshSteamWorkshopList>d__16();
			<RefreshSteamWorkshopList>d__.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
			<RefreshSteamWorkshopList>d__.<>4__this = this;
			<RefreshSteamWorkshopList>d__.<>1__state = -1;
			<RefreshSteamWorkshopList>d__.<>t__builder.Start<ModManagerUI.<RefreshSteamWorkshopList>d__16>(ref <RefreshSteamWorkshopList>d__);
			return <RefreshSteamWorkshopList>d__.<>t__builder.Task;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000DC89C File Offset: 0x000DAA9C
		[DebuggerStepThrough]
		public void RefreshLocalModList()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.RefreshLocalModList()).MethodHandle, typeof(ModManagerUI).TypeHandle);
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
							this.$Rougamo_RefreshLocalModList();
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

		// Token: 0x06001A0F RID: 6671 RVA: 0x000DC998 File Offset: 0x000DAB98
		[DebuggerStepThrough]
		private void PrepareItemTemplate(Transform content)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.PrepareItemTemplate(Transform)).MethodHandle, typeof(ModManagerUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				content
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
							content = null;
						}
						else
						{
							content = (Transform)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_PrepareItemTemplate(content);
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

		// Token: 0x06001A10 RID: 6672 RVA: 0x000DCACC File Offset: 0x000DACCC
		private void CreateModList(Transform content, IEnumerable<SteamWorkshopModInfo> items, bool inShopList = false)
		{
			bool flag = content == null;
			if (!flag)
			{
				Transform itemPrefab = content.Find("Item");
				foreach (object obj in content)
				{
					Transform item = (Transform)obj;
					bool flag2 = item != itemPrefab;
					if (flag2)
					{
						Singleton<ObjectPool>.Instance.Release(item.gameObject);
					}
				}
				for (int i = 0; i < items.Count<SteamWorkshopModInfo>(); i++)
				{
					SteamWorkshopModInfo item2 = items.ElementAt(i);
					Transform gameobj = Singleton<ObjectPool>.Instance.Get(itemPrefab.gameObject, content).transform;
					gameobj.gameObject.SetActive(true);
					ModItem modItem = gameobj.GetComponent<ModItem>();
					modItem.modManager = this;
					modItem.Init(item2, inShopList);
					bool flag3 = i == 0;
					if (flag3)
					{
						this.InitDes(modItem);
					}
				}
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x000DCBE0 File Offset: 0x000DADE0
		private List<SteamWorkshopModInfo> QueryLocalMods(string searchText)
		{
			List<SteamWorkshopModInfo> result = new List<SteamWorkshopModInfo>();
			bool flag = !Directory.Exists(Globals.ModsPath);
			List<SteamWorkshopModInfo> result2;
			if (flag)
			{
				result2 = result;
			}
			else
			{
				foreach (string directory in Directory.GetDirectories(Globals.ModsPath))
				{
					string configPath = Path.Combine(directory, "ModConfig.json");
					bool flag2 = !File.Exists(configPath);
					if (!flag2)
					{
						try
						{
							ModConfig config = JsonConvert.DeserializeObject<ModConfig>(File.ReadAllText(configPath));
							bool flag3 = config == null;
							if (!flag3)
							{
								config.DirectoryName = directory;
								SteamWorkshopModInfo localInfo = this.BuildLocalModInfo(config);
								bool flag4 = ModManagerUI.MatchesSearch(localInfo, searchText);
								if (flag4)
								{
									result.Add(localInfo);
								}
							}
						}
						catch (Exception exception)
						{
							Debug.LogWarning("读取本地 Mod 失败: " + directory + ", " + exception.Message);
						}
					}
				}
				result2 = (from item in result
				orderby item.LocalEnabled descending, item.Title
				select item).ToList<SteamWorkshopModInfo>();
			}
			return result2;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000DCD30 File Offset: 0x000DAF30
		[DebuggerStepThrough]
		private SteamWorkshopModInfo BuildLocalModInfo(ModConfig config)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.BuildLocalModInfo(ModConfig)).MethodHandle, typeof(ModManagerUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				config
			};
			SteamWorkshopModInfo steamWorkshopModInfo;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					steamWorkshopModInfo = (SteamWorkshopModInfo)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							config = null;
						}
						else
						{
							config = (ModConfig)arguments[0];
						}
					}
					do
					{
						try
						{
							steamWorkshopModInfo = this.$Rougamo_BuildLocalModInfo(config);
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
								steamWorkshopModInfo = (SteamWorkshopModInfo)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_13B;
							}
							throw;
						}
						methodContext.ReturnValue = steamWorkshopModInfo;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						steamWorkshopModInfo = (SteamWorkshopModInfo)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_13B:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return steamWorkshopModInfo;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000DCEA0 File Offset: 0x000DB0A0
		[DebuggerStepThrough]
		private static string ResolveLocalIconPath(string folderName, string iconPath)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.ResolveLocalIconPath(string, string)).MethodHandle, typeof(ModManagerUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				folderName,
				iconPath
			};
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
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							folderName = null;
						}
						else
						{
							folderName = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							iconPath = null;
						}
						else
						{
							iconPath = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							text = ModManagerUI.$Rougamo_ResolveLocalIconPath(folderName, iconPath);
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
								goto IL_155;
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
					IL_155:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return text;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x000DD02C File Offset: 0x000DB22C
		[DebuggerStepThrough]
		private static bool MatchesSearch(SteamWorkshopModInfo item, string searchText)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.MatchesSearch(SteamWorkshopModInfo, string)).MethodHandle, typeof(ModManagerUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				item,
				searchText
			};
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
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							item = null;
						}
						else
						{
							item = (SteamWorkshopModInfo)arguments[0];
						}
						if (arguments[1] == null)
						{
							searchText = null;
						}
						else
						{
							searchText = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							flag = ModManagerUI.$Rougamo_MatchesSearch(item, searchText);
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
								goto IL_15A;
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
					IL_15A:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return flag;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000DD1D4 File Offset: 0x000DB3D4
		[DebuggerStepThrough]
		private static bool ContainsIgnoreCase(string source, string searchText)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.ContainsIgnoreCase(string, string)).MethodHandle, typeof(ModManagerUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				source,
				searchText
			};
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
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							source = null;
						}
						else
						{
							source = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							searchText = null;
						}
						else
						{
							searchText = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							flag = ModManagerUI.$Rougamo_ContainsIgnoreCase(source, searchText);
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
								goto IL_15A;
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
					IL_15A:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return flag;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000DD37C File Offset: 0x000DB57C
		[DebuggerStepThrough]
		private unsafe static bool TrySaveLocalModEnabledState(string localDirectory, bool enabled, out ModConfig config, out bool changed)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.TrySaveLocalModEnabledState(string, bool, ModConfig*, bool*)).MethodHandle, typeof(ModManagerUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				localDirectory,
				enabled,
				config,
				changed
			};
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
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							localDirectory = null;
						}
						else
						{
							localDirectory = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							enabled = default(bool);
						}
						else
						{
							enabled = (bool)arguments[1];
						}
						if (arguments[2] == null)
						{
							config = null;
						}
						else
						{
							config = (ModConfig)arguments[2];
						}
						if (arguments[3] == null)
						{
							changed = default(bool);
						}
						else
						{
							changed = (bool)arguments[3];
						}
					}
					do
					{
						try
						{
							flag = ModManagerUI.$Rougamo_TrySaveLocalModEnabledState(localDirectory, enabled, out config, out changed);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							object[] arguments2 = methodContext.Arguments;
							arguments2[2] = config;
							arguments2[3] = changed;
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
								goto IL_1F1;
							}
							throw;
						}
						methodContext.ReturnValue = flag;
						modifiable.OnSuccess(methodContext);
						object[] arguments3 = methodContext.Arguments;
						arguments3[2] = config;
						arguments3[3] = changed;
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						flag = (bool)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_1F1:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return flag;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x000DD5BC File Offset: 0x000DB7BC
		private static void UpdateRuntimeModState(string localDirectory, bool enabled)
		{
			bool flag = Singleton<GameConfigManager>.Instance == null;
			if (!flag)
			{
				string normalizedDirectory = ModManagerUI.NormalizePath(localDirectory);
				foreach (ModConfig config in Singleton<GameConfigManager>.Instance.modConfigs)
				{
					bool flag2 = ModManagerUI.NormalizePath(config.DirectoryName) == normalizedDirectory;
					if (flag2)
					{
						config.Enabled = enabled;
					}
				}
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000DD648 File Offset: 0x000DB848
		[DebuggerStepThrough]
		private static bool IsLoadedLocalMod(string localDirectory)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.IsLoadedLocalMod(string)).MethodHandle, typeof(ModManagerUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				localDirectory
			};
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
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							localDirectory = null;
						}
						else
						{
							localDirectory = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							flag = ModManagerUI.$Rougamo_IsLoadedLocalMod(localDirectory);
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
								goto IL_138;
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
					IL_138:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return flag;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x000DD7B8 File Offset: 0x000DB9B8
		[DebuggerStepThrough]
		private static string NormalizePath(string path)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.NormalizePath(string)).MethodHandle, typeof(ModManagerUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				path
			};
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
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							path = null;
						}
						else
						{
							path = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							text = ModManagerUI.$Rougamo_NormalizePath(path);
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
								goto IL_133;
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
					IL_133:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return text;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000DD920 File Offset: 0x000DBB20
		[DebuggerStepThrough]
		public void InitDes(ModItem item)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.InitDes(ModItem)).MethodHandle, typeof(ModManagerUI).TypeHandle);
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
							item = (ModItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_InitDes(item);
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

		// Token: 0x06001A1B RID: 6683 RVA: 0x000DDA54 File Offset: 0x000DBC54
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
			methodContext.TargetType = typeof(ModManagerUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ModManagerUI.Close()).MethodHandle, typeof(ModManagerUI).TypeHandle);
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

		// Token: 0x06001A1D RID: 6685 RVA: 0x000DDB81 File Offset: 0x000DBD81
		private void $Rougamo_Awake()
		{
			this.BindUI();
			this.PrepareItemTemplate(this.UgcModContent);
			this.PrepareItemTemplate(this.LocalModContent);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000DDBA8 File Offset: 0x000DBDA8
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.BindUI();
			this.RefreshLocalModList();
			this.RefreshSteamWorkshopList().Forget();
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000DDBDA File Offset: 0x000DBDDA
		private void $Rougamo_OnDestroy()
		{
			CancellationTokenSource cancellationTokenSource = this.refreshCancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
			CancellationTokenSource cancellationTokenSource2 = this.refreshCancellationTokenSource;
			if (cancellationTokenSource2 != null)
			{
				cancellationTokenSource2.Dispose();
			}
			base.OnDestroy();
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x000DDC08 File Offset: 0x000DBE08
		private void $Rougamo_RefreshFromUI()
		{
			this.RefreshLocalModList();
			this.RefreshSteamWorkshopList().Forget();
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000DDC2C File Offset: 0x000DBE2C
		private void $Rougamo_BindUI()
		{
			bool flag = this.uiBound;
			if (!flag)
			{
				this.uiBound = true;
				bool flag2 = this.RefreshButton != null;
				if (flag2)
				{
					this.RefreshButton.onClick.RemoveListener(new UnityAction(this.RefreshFromUI));
					this.RefreshButton.onClick.AddListener(new UnityAction(this.RefreshFromUI));
				}
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000DDC9C File Offset: 0x000DBE9C
		private void $Rougamo_RefreshLocalModList()
		{
			this.LocalModList = this.QueryLocalMods((this.SearchInput != null) ? this.SearchInput.text : string.Empty);
			this.CreateModList(this.LocalModContent, this.LocalModList, false);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000DDCEC File Offset: 0x000DBEEC
		private void $Rougamo_PrepareItemTemplate(Transform content)
		{
			Transform itemPrefab = (content != null) ? content.Find("Item") : null;
			bool flag = itemPrefab != null;
			if (flag)
			{
				itemPrefab.gameObject.SetActive(false);
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000DDD2C File Offset: 0x000DBF2C
		private SteamWorkshopModInfo $Rougamo_BuildLocalModInfo(ModConfig config)
		{
			string localDirectory = ModManagerUI.NormalizePath(config.DirectoryName);
			string folderName = Path.GetFileName(localDirectory.TrimEnd('/'));
			string title = string.IsNullOrWhiteSpace(config.ModName) ? folderName : config.ModName;
			string description = string.IsNullOrWhiteSpace(config.ModDescription) ? "暂无描述" : config.ModDescription;
			string author = string.IsNullOrWhiteSpace(config.ModAuthor) ? "未知作者" : config.ModAuthor;
			string version = string.IsNullOrWhiteSpace(config.ModVersion) ? "未知版本" : config.ModVersion;
			return new SteamWorkshopModInfo
			{
				IsLocalMod = true,
				LocalEnabled = config.Enabled,
				LocalDirectory = localDirectory,
				LocalIconPath = ModManagerUI.ResolveLocalIconPath(folderName, config.IconPath),
				Title = title,
				Description = string.Concat(new string[]
				{
					description,
					"\n\n作者: ",
					author,
					"\n版本: ",
					version,
					"\n状态: ",
					config.Enabled ? "已启用" : "已禁用"
				}),
				OwnerName = author,
				UpdatedAt = (Directory.Exists(localDirectory) ? Directory.GetLastWriteTime(localDirectory) : DateTime.MinValue),
				IsLoadedInGame = ModManagerUI.IsLoadedLocalMod(localDirectory)
			};
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000DDE88 File Offset: 0x000DC088
		private static string $Rougamo_ResolveLocalIconPath(string folderName, string iconPath)
		{
			bool flag = string.IsNullOrWhiteSpace(iconPath);
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = Path.IsPathRooted(iconPath);
				if (flag2)
				{
					result = iconPath;
				}
				else
				{
					string normalizedPath = iconPath.Replace('\\', '/').TrimStart('/');
					bool flag3 = normalizedPath.StartsWith("Mods/", StringComparison.OrdinalIgnoreCase);
					if (flag3)
					{
						result = normalizedPath;
					}
					else
					{
						result = "Mods/" + folderName + "/" + normalizedPath;
					}
				}
			}
			return result;
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x000DDEF4 File Offset: 0x000DC0F4
		private static bool $Rougamo_MatchesSearch(SteamWorkshopModInfo item, string searchText)
		{
			bool flag = string.IsNullOrWhiteSpace(searchText);
			return flag || ModManagerUI.ContainsIgnoreCase(item.Title, searchText) || ModManagerUI.ContainsIgnoreCase(item.Description, searchText) || ModManagerUI.ContainsIgnoreCase(item.OwnerName, searchText);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000DDF40 File Offset: 0x000DC140
		private static bool $Rougamo_ContainsIgnoreCase(string source, string searchText)
		{
			return !string.IsNullOrWhiteSpace(source) && source.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000DDF6C File Offset: 0x000DC16C
		private static bool $Rougamo_TrySaveLocalModEnabledState(string localDirectory, bool enabled, out ModConfig config, out bool changed)
		{
			config = null;
			changed = false;
			bool flag = string.IsNullOrWhiteSpace(localDirectory);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string configPath = Path.Combine(localDirectory, "ModConfig.json");
				bool flag2 = !File.Exists(configPath);
				if (flag2)
				{
					result = false;
				}
				else
				{
					config = JsonConvert.DeserializeObject<ModConfig>(File.ReadAllText(configPath));
					bool flag3 = config == null;
					if (flag3)
					{
						result = false;
					}
					else
					{
						changed = (config.Enabled != enabled);
						config.Enabled = enabled;
						config.DirectoryName = localDirectory;
						string json = JsonConvert.SerializeObject(config, Formatting.Indented);
						File.WriteAllText(configPath, json);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000DE004 File Offset: 0x000DC204
		private static bool $Rougamo_IsLoadedLocalMod(string localDirectory)
		{
			bool flag = Singleton<GameConfigManager>.Instance == null || string.IsNullOrWhiteSpace(localDirectory);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string normalizedDirectory = ModManagerUI.NormalizePath(localDirectory);
				result = Singleton<GameConfigManager>.Instance.modConfigs.Any((ModConfig config) => ModManagerUI.NormalizePath(config.DirectoryName) == normalizedDirectory && config.Enabled);
			}
			return result;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000DE05C File Offset: 0x000DC25C
		private static string $Rougamo_NormalizePath(string path)
		{
			return string.IsNullOrWhiteSpace(path) ? string.Empty : path.Replace('\\', '/').TrimEnd('/');
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000DE090 File Offset: 0x000DC290
		private void $Rougamo_InitDes(ModItem item)
		{
			bool inShopList = item.InShopList;
			if (inShopList)
			{
				this.ShopModDesContent.Find("Top/Name").GetComponent<TMP_Text>().SetText(item.data.Title);
				this.ShopModDesContent.Find("Top/Author").GetComponent<TMP_Text>().SetText(item.data.OwnerName);
				this.ShopModDesContent.Find("Top/Image").GetComponent<Image>().sprite = item.mainSprite;
				this.ShopModDesContent.Find("Text/Text").GetComponent<TMP_Text>().SetText(item.data.Description);
			}
			else
			{
				this.LocalModDesContent.Find("Top/Name").GetComponent<TMP_Text>().SetText(item.data.Title);
				this.LocalModDesContent.Find("Top/Author").GetComponent<TMP_Text>().SetText(item.data.OwnerName);
				this.LocalModDesContent.Find("Top/Image").GetComponent<Image>().sprite = item.mainSprite;
				this.LocalModDesContent.Find("Text/Text").GetComponent<TMP_Text>().SetText(item.data.Description);
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x000DE1DC File Offset: 0x000DC3DC
		private void $Rougamo_Close()
		{
			bool hasChangeMod = this.HasChangeMod;
			if (hasChangeMod)
			{
				UIManager.Instance.ShowModalWindow("Tips", "是否要重启游戏以让mod更改生效?", delegate
				{
					EditorApplication.isPlaying = false;
				}, 0f, null, true, true, "Yes", "No", true);
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x040013D2 RID: 5074
		public Transform UgcModContent;

		// Token: 0x040013D3 RID: 5075
		public Transform LocalModContent;

		// Token: 0x040013D4 RID: 5076
		public TMP_InputField SearchInput;

		// Token: 0x040013D5 RID: 5077
		public Button RefreshButton;

		// Token: 0x040013D6 RID: 5078
		public bool HasChangeMod = false;

		// Token: 0x040013D7 RID: 5079
		public List<SteamWorkshopModInfo> TotalModList = new List<SteamWorkshopModInfo>();

		// Token: 0x040013D8 RID: 5080
		public List<SteamWorkshopModInfo> LocalModList = new List<SteamWorkshopModInfo>();

		// Token: 0x040013D9 RID: 5081
		private readonly SteamWorkshopBrowser workshopBrowser = new SteamWorkshopBrowser();

		// Token: 0x040013DA RID: 5082
		private CancellationTokenSource refreshCancellationTokenSource;

		// Token: 0x040013DB RID: 5083
		private bool uiBound;

		// Token: 0x040013DC RID: 5084
		public Transform ShopModDesContent;

		// Token: 0x040013DD RID: 5085
		public Transform LocalModDesContent;
	}
}

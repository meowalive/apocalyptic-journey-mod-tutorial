using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Network.Query;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.Rendering;
using Witch.UI;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x0200024A RID: 586
	public class SlotMachUI : MapSelectUI
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00094120 File Offset: 0x00092320
		private MapTree mapTree
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
				methodContext.TargetType = typeof(SlotMachUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.get_mapTree()).MethodHandle, typeof(SlotMachUI).TypeHandle);
				methodContext.Arguments = new object[0];
				MapTree mapTree;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						mapTree = (MapTree)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								mapTree = this.$Rougamo_get_mapTree();
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
									mapTree = (MapTree)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = mapTree;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							mapTree = (MapTree)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return mapTree;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00094260 File Offset: 0x00092460
		private SlotMachineManager slotMachineManager
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
				methodContext.TargetType = typeof(SlotMachUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.get_slotMachineManager()).MethodHandle, typeof(SlotMachUI).TypeHandle);
				methodContext.Arguments = new object[0];
				SlotMachineManager slotMachineManager;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						slotMachineManager = (SlotMachineManager)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								slotMachineManager = this.$Rougamo_get_slotMachineManager();
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
									slotMachineManager = (SlotMachineManager)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = slotMachineManager;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							slotMachineManager = (SlotMachineManager)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return slotMachineManager;
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x000943A0 File Offset: 0x000925A0
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
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.FadeIn()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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

		// Token: 0x060012DE RID: 4830 RVA: 0x0009449C File Offset: 0x0009269C
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
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.Awake()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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

		// Token: 0x060012DF RID: 4831 RVA: 0x00094598 File Offset: 0x00092798
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
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.DataUpdate()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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

		// Token: 0x060012E0 RID: 4832 RVA: 0x00094694 File Offset: 0x00092894
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
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.Start()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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

		// Token: 0x060012E1 RID: 4833 RVA: 0x00094790 File Offset: 0x00092990
		[DebuggerStepThrough]
		public override void ReadyToSelect()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.ReadyToSelect()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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
							this.$Rougamo_ReadyToSelect();
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

		// Token: 0x060012E2 RID: 4834 RVA: 0x0009488C File Offset: 0x00092A8C
		public override void CreateMapItem(List<MapTree.Node> nodes)
		{
			int i = 0;
			foreach (MapTree.Node node in nodes)
			{
				Transform prefab = base.transform.Find("MapSelect/CoinPrefab");
				Transform item = UnityEngine.Object.Instantiate<Transform>(prefab, prefab.parent);
				item.transform.Find("Front/background").GetComponent<MeshRenderer>().material = new Material(item.transform.Find("Front/background").GetComponent<MeshRenderer>().material);
				string text = node.data["Type"];
				string a = text;
				if (!(a == "Bad"))
				{
					if (!(a == "Normal"))
					{
						if (a == "Good")
						{
							item.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/Map/老虎机/Good", true);
						}
					}
					else
					{
						item.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/Map/老虎机/Normal", true);
					}
				}
				else
				{
					item.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/Map/老虎机/Bad", true);
				}
				item.gameObject.SetActive(true);
				item.gameObject.AddComponent<CoinItem>().Init(node);
				item.GetComponent<ObjectGroup>().blocksRaycasts = true;
				item.GetComponent<SortingGroup>().sortingOrder = i + 3;
				i++;
			}
			base.UpdateCardItemPos();
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00094A64 File Offset: 0x00092C64
		[DebuggerStepThrough]
		public void RandomAgain()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.RandomAgain()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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
							this.$Rougamo_RandomAgain();
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

		// Token: 0x060012E4 RID: 4836 RVA: 0x00094B60 File Offset: 0x00092D60
		[DebuggerStepThrough]
		public void GenerateCoinItem()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.GenerateCoinItem()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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
							this.$Rougamo_GenerateCoinItem();
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

		// Token: 0x060012E5 RID: 4837 RVA: 0x00094C5C File Offset: 0x00092E5C
		[DebuggerStepThrough]
		private string GetPrefabName(MapTree.Node node)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.GetPrefabName(MapTree.Node)).MethodHandle, typeof(SlotMachUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				node
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
							node = null;
						}
						else
						{
							node = (MapTree.Node)arguments[0];
						}
					}
					do
					{
						try
						{
							text = this.$Rougamo_GetPrefabName(node);
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
								goto IL_13B;
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
					IL_13B:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return text;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00094DCC File Offset: 0x00092FCC
		[DebuggerStepThrough]
		public override void MapAnimation()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.MapAnimation()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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
							this.$Rougamo_MapAnimation();
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

		// Token: 0x060012E7 RID: 4839 RVA: 0x00094EC8 File Offset: 0x000930C8
		[DebuggerStepThrough]
		public override void SendNode()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.SendNode()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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
							this.$Rougamo_SendNode();
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

		// Token: 0x060012E8 RID: 4840 RVA: 0x00094FC4 File Offset: 0x000931C4
		[DebuggerStepThrough]
		public void SaveMap()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.SaveMap()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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
							this.$Rougamo_SaveMap();
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

		// Token: 0x060012E9 RID: 4841 RVA: 0x000950C0 File Offset: 0x000932C0
		[DebuggerStepThrough]
		private void CreateRole(ValueTuple<string, DataConfig>[] roleList)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.CreateRole(ValueTuple<string, DataConfig>[])).MethodHandle, typeof(SlotMachUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				roleList
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
							roleList = null;
						}
						else
						{
							roleList = (ValueTuple<string, DataConfig>[])arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateRole(roleList);
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

		// Token: 0x060012EA RID: 4842 RVA: 0x000951F4 File Offset: 0x000933F4
		[DebuggerStepThrough]
		private void SelectMap()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.SelectMap()).MethodHandle, typeof(SlotMachUI).TypeHandle);
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
							this.$Rougamo_SelectMap();
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

		// Token: 0x060012EB RID: 4843 RVA: 0x000952F0 File Offset: 0x000934F0
		[DebuggerStepThrough]
		public void CoinUse(MapTree.Node useCard)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.CoinUse(MapTree.Node)).MethodHandle, typeof(SlotMachUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				useCard
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
							useCard = null;
						}
						else
						{
							useCard = (MapTree.Node)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CoinUse(useCard);
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

		// Token: 0x060012EC RID: 4844 RVA: 0x00095424 File Offset: 0x00093624
		[DebuggerStepThrough]
		public void SlotUse(MapTree.Node useCard)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SlotMachUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SlotMachUI.SlotUse(MapTree.Node)).MethodHandle, typeof(SlotMachUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				useCard
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
							useCard = null;
						}
						else
						{
							useCard = (MapTree.Node)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SlotUse(useCard);
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

		// Token: 0x060012F0 RID: 4848 RVA: 0x000955BC File Offset: 0x000937BC
		private MapTree $Rougamo_get_mapTree()
		{
			return MapManager.Instance.MapTree;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000955C8 File Offset: 0x000937C8
		private SlotMachineManager $Rougamo_get_slotMachineManager()
		{
			return MapManager.Instance.ModeMapManager as SlotMachineManager;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000955D9 File Offset: 0x000937D9
		private void $Rougamo_FadeIn()
		{
			this.animationType = UIBase.AnimationType.None;
			base.FadeIn();
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x000955EC File Offset: 0x000937EC
		private void $Rougamo_Awake()
		{
			base.gameObject.GetComponent<Canvas>().worldCamera = Camera.main;
			bool flag = (float)Screen.width / (float)Screen.height != 1.7777778f;
			if (flag)
			{
				base.transform.GetComponent<RectTransform>().localScale = new Vector3((float)Screen.width / (float)Screen.height / 1.7777778f, 1f, 1f);
			}
			SlotMachineManager.canuse = true;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_DataUpdate()
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00095668 File Offset: 0x00093868
		private void $Rougamo_Start()
		{
			this.cardContainer = base.transform.Find("MapSelect").GetComponent<CardContainer>();
			this.DataUpdate();
			bool flag = FightManager.Instance != null && (RoleTable.Instance.San <= 0 || RoleTable.Instance.MaxSan <= 0);
			if (flag)
			{
				RoleTable.Instance.isDead = true;
				FightManager.Instance.CmdCheckDead(null);
			}
			this.IsAnimating = false;
			bool flag2 = base.gameObject == null || base.transform == null;
			if (!flag2)
			{
				AudioManager instance = AudioManager.Instance;
				string name = "MapBGM";
				string nowBGMName = AudioManager.Instance.NowBGMName;
				instance.PlayBGMList(name, !(nowBGMName == "HouseBGM") && !(nowBGMName == "FightPrepareBGM") && !(nowBGMName == "EventBGM"));
				bool flag3 = UIManager.Instance.GetUI<SceneTurnUI>("SceneTurnUI") == null;
				if (flag3)
				{
					bool flag4 = GameApp.Instance.NowBackground != null;
					if (flag4)
					{
						GameApp.Instance.NowBackground.transform.SetAsLastSibling();
					}
				}
				else
				{
					bool flag5 = GameApp.Instance.NowBackground != null;
					if (flag5)
					{
						GameApp.Instance.NowBackground.transform.SetSiblingIndex(-1);
					}
				}
				this.CreateMapItem(this.mapTree.SelectNode);
				bool isServer = PlayerManager.Instance.isServer;
				if (isServer)
				{
					this.SaveMap();
				}
				PlayerManager.Instance.SendQuery<ValueTuple<string, DataConfig>[]>(new QueryCareers(), new Action<ValueTuple<string, DataConfig>[]>(this.CreateRole));
				UIManager.Instance.CheckUI();
				GameApp.Instance.SetSteamRichState("Adventure");
				MapManager.Instance.MapUIStart(this);
			}
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00095844 File Offset: 0x00093A44
		private void $Rougamo_ReadyToSelect()
		{
			List<MapTree.Node> nodes = this.mapTree.SelectNode;
			this.CreateMapItem(nodes);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00095868 File Offset: 0x00093A68
		private void $Rougamo_RandomAgain()
		{
			bool flag = this.mapTree.SelectNode.Count >= 9;
			if (!flag)
			{
				SlotMachineManager slotMachineManager = this.slotMachineManager;
				int level = slotMachineManager.Level;
				slotMachineManager.Level = level + 1;
				this.CreateMapItem(this.slotMachineManager.GeneratrMap());
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000958BC File Offset: 0x00093ABC
		private void $Rougamo_GenerateCoinItem()
		{
			this.CreateMapItem(this.mapTree.SelectNode);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000958D4 File Offset: 0x00093AD4
		private string $Rougamo_GetPrefabName(MapTree.Node node)
		{
			return node.data["Type"] + "Prefab";
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_MapAnimation()
		{
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_SendNode()
		{
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00095900 File Offset: 0x00093B00
		private void $Rougamo_SaveMap()
		{
			bool isServer = PlayerManager.Instance.isServer;
			if (isServer)
			{
				GameServer.Instance.SaveGame();
			}
			SafeBoxUI.SafeboxSave();
			Singleton<GameRuntimeData>.Instance.Save();
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0009593C File Offset: 0x00093B3C
		private void $Rougamo_CreateRole(ValueTuple<string, DataConfig>[] roleList)
		{
			bool flag = this == null || base.gameObject == null;
			if (!flag)
			{
				Transform tempParent = base.transform.Find("Content/RoleList/RolePre");
				tempParent.gameObject.SetActive(false);
				for (int i = 0; i < roleList.Count<ValueTuple<string, DataConfig>>(); i++)
				{
					string id = roleList[i].Item1;
					DataConfig career = roleList[i].Item2;
					bool flag2 = id == null || career == null;
					if (!flag2)
					{
						Transform tempItem = UnityEngine.Object.Instantiate<Transform>(tempParent, base.transform.Find("Content/RoleList"));
						tempItem.gameObject.SetActive(true);
						tempItem.Find("role").GetComponent<SceneRole>().Init(i, career, id, true);
						tempItem.SetAsFirstSibling();
					}
				}
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00095A20 File Offset: 0x00093C20
		private void $Rougamo_SelectMap()
		{
			bool flag = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (!flag)
			{
				bool isCloseing = this.isCloseing;
				if (!isCloseing)
				{
					this.isCloseing = true;
					UniTask.WaitWhile(() => this.isTweening, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
					{
						Animator animator = base.gameObject.GetComponent<Animator>();
						bool flag2 = animator != null;
						if (flag2)
						{
							animator.SetTrigger("Exit");
							bool flag3 = MapManager.Instance != null;
							if (flag3)
							{
								MapManager.Instance.CmdReadyToNextMap(null);
							}
						}
					}).Forget();
				}
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00095A8D File Offset: 0x00093C8D
		private void $Rougamo_CoinUse(MapTree.Node useCard)
		{
			this.mapTree.SelectNode.Remove(useCard);
			this.SlotUse(useCard);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00095AAC File Offset: 0x00093CAC
		private void $Rougamo_SlotUse(MapTree.Node useCard)
		{
			List<string> types = new List<string>
			{
				"Heart",
				"Qus",
				"Seven",
				"Gem",
				"Crystal"
			};
			bool flag = useCard.data["Type"] == "Normal";
			if (flag)
			{
				types.Add("Skull");
			}
			else
			{
				bool flag2 = useCard.data["Type"] == "Bad";
				if (flag2)
				{
					types = new List<string>
					{
						"Skull"
					};
				}
			}
			List<string> result = new List<string>();
			bool flag3;
			do
			{
				result.Clear();
				int Length = types.Count;
				for (int i = 1; i <= 3; i++)
				{
					string t = types[useCard.NodeDice.WithRange(0, Length - 1).Roll().Value];
					result.Add(t);
				}
				flag3 = (result[0] == result[1] || result[0] == result[2] || result[1] == result[2]);
			}
			while (!flag3);
			int count = useCard.NodeDice.WithRange(0, 100).Roll().Value;
			this.slotMachineManager.ResultUse(result, count);
		}
	}
}

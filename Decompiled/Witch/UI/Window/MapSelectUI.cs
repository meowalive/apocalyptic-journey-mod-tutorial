using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Data.Save;
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
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x0200032D RID: 813
	public class MapSelectUI : UIBase
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x000D491C File Offset: 0x000D2B1C
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
				methodContext.TargetType = typeof(MapSelectUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.get_mapTree()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x06001959 RID: 6489 RVA: 0x000D4A5C File Offset: 0x000D2C5C
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
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.FadeIn()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x0600195A RID: 6490 RVA: 0x000D4B58 File Offset: 0x000D2D58
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
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.Awake()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x0600195B RID: 6491 RVA: 0x000D4C54 File Offset: 0x000D2E54
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
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.DataUpdate()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x0600195C RID: 6492 RVA: 0x000D4D50 File Offset: 0x000D2F50
		[DebuggerStepThrough]
		public void ResetBackCard()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ResetBackCard()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							this.$Rougamo_ResetBackCard();
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

		// Token: 0x0600195D RID: 6493 RVA: 0x000D4E4C File Offset: 0x000D304C
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
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.Start()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x0600195E RID: 6494 RVA: 0x000D4F48 File Offset: 0x000D3148
		[DebuggerStepThrough]
		public void TryContinue()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.TryContinue()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							this.$Rougamo_TryContinue();
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

		// Token: 0x0600195F RID: 6495 RVA: 0x000D5044 File Offset: 0x000D3244
		[DebuggerStepThrough]
		public void UpdateCardItemPos()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.UpdateCardItemPos()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							this.$Rougamo_UpdateCardItemPos();
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

		// Token: 0x06001960 RID: 6496 RVA: 0x000D5140 File Offset: 0x000D3340
		[DebuggerStepThrough]
		public virtual void ReadyToSelect()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ReadyToSelect()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x06001961 RID: 6497 RVA: 0x000D523C File Offset: 0x000D343C
		public virtual void CreateMapItem(List<MapTree.Node> nodes)
		{
			int i = 0;
			foreach (MapTree.Node node in nodes)
			{
				string prefabName = this.GetPrefabName(node);
				Transform prefab = base.transform.Find("MapSelect/" + prefabName);
				Transform item = UnityEngine.Object.Instantiate<Transform>(prefab, prefab.parent);
				item.transform.Find("Front/background").GetComponent<MeshRenderer>().material = new Material(item.transform.Find("Front/background").GetComponent<MeshRenderer>().material);
				string text = node.data["Type"];
				string a = text;
				if (!(a == "Event"))
				{
					if (!(a == "Fight"))
					{
						if (a == "Build")
						{
							item.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/建筑牌", true);
						}
					}
				}
				else
				{
					item.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/故事牌", true);
				}
				item.gameObject.SetActive(true);
				item.gameObject.AddComponent<MapItem>().Init(node);
				item.GetComponent<ObjectGroup>().blocksRaycasts = true;
				item.GetComponent<SortingGroup>().sortingOrder = i - 13;
				i++;
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000D53F0 File Offset: 0x000D35F0
		public virtual void MapAnimation()
		{
			using (IEnumerator enumerator = base.transform.Find("Map/NodeContent").GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Transform child = (Transform)enumerator.Current;
					child.DOLocalMoveY(child.localPosition.y + (float)UnityEngine.Random.Range(-20, 20), 3f, false).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).OnUpdate(delegate
					{
						child.localPosition = new Vector3(Mathf.Round(child.localPosition.x - 0.5f) + 0.5f, Mathf.Round(child.localPosition.y - 0.5f) + 0.5f, 0f);
					});
				}
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000D54A8 File Offset: 0x000D36A8
		[DebuggerStepThrough]
		public virtual void SendNode()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.SendNode()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x06001964 RID: 6500 RVA: 0x000D55A4 File Offset: 0x000D37A4
		[DebuggerStepThrough]
		public void ShowMap()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ShowMap()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							this.$Rougamo_ShowMap();
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

		// Token: 0x06001965 RID: 6501 RVA: 0x000D56A0 File Offset: 0x000D38A0
		[DebuggerStepThrough]
		private void CreateRole([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] ValueTuple<string, DataConfig>[] roleList)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.CreateRole(ValueTuple<string, DataConfig>[])).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x06001966 RID: 6502 RVA: 0x000D57D4 File Offset: 0x000D39D4
		[NullableContext(1)]
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
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.GetPrefabName(MapTree.Node)).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x06001967 RID: 6503 RVA: 0x000D5944 File Offset: 0x000D3B44
		[DebuggerStepThrough]
		public virtual void CreateNodes(int count)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.CreateNodes(int)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
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
							count = 0;
						}
						else
						{
							count = (int)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateNodes(count);
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

		// Token: 0x06001968 RID: 6504 RVA: 0x000D5A80 File Offset: 0x000D3C80
		[NullableContext(1)]
		[DebuggerStepThrough]
		public virtual MapTree.Node[] GetNodes()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.GetNodes()).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[0];
			MapTree.Node[] array;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					array = (MapTree.Node[])methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							array = this.$Rougamo_GetNodes();
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
								array = (MapTree.Node[])methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = array;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						array = (MapTree.Node[])methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return array;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000D5BC0 File Offset: 0x000D3DC0
		[DebuggerStepThrough]
		public void SetNodes()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.SetNodes()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							this.$Rougamo_SetNodes();
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

		// Token: 0x0600196A RID: 6506 RVA: 0x000D5CBC File Offset: 0x000D3EBC
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
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.OnDestroy()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x0600196B RID: 6507 RVA: 0x000D5DB8 File Offset: 0x000D3FB8
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
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.SelectMap()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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

		// Token: 0x0600196C RID: 6508 RVA: 0x000D5EB4 File Offset: 0x000D40B4
		[DebuggerStepThrough]
		public void HandleDrawPointerDown(Vector2 localPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.HandleDrawPointerDown(Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				localPoint
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
							localPoint = default(Vector2);
						}
						else
						{
							localPoint = (Vector2)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_HandleDrawPointerDown(localPoint);
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

		// Token: 0x0600196D RID: 6509 RVA: 0x000D5FF0 File Offset: 0x000D41F0
		[DebuggerStepThrough]
		public void HandleDrawPointerDrag(Vector2 localPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.HandleDrawPointerDrag(Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				localPoint
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
							localPoint = default(Vector2);
						}
						else
						{
							localPoint = (Vector2)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_HandleDrawPointerDrag(localPoint);
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

		// Token: 0x0600196E RID: 6510 RVA: 0x000D612C File Offset: 0x000D432C
		[DebuggerStepThrough]
		public void HandleDrawPointerUp(Vector2 localPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.HandleDrawPointerUp(Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				localPoint
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
							localPoint = default(Vector2);
						}
						else
						{
							localPoint = (Vector2)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_HandleDrawPointerUp(localPoint);
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

		// Token: 0x0600196F RID: 6511 RVA: 0x000D6268 File Offset: 0x000D4468
		[NullableContext(1)]
		[DebuggerStepThrough]
		public void ReceiveNetworkDrawBegin(string strokeId, string authorId, Vector2 localPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ReceiveNetworkDrawBegin(string, string, Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				strokeId,
				authorId,
				localPoint
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
							strokeId = null;
						}
						else
						{
							strokeId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							localPoint = default(Vector2);
						}
						else
						{
							localPoint = (Vector2)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ReceiveNetworkDrawBegin(strokeId, authorId, localPoint);
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

		// Token: 0x06001970 RID: 6512 RVA: 0x000D63E4 File Offset: 0x000D45E4
		[NullableContext(1)]
		[DebuggerStepThrough]
		public void ReceiveNetworkDrawPoint(string strokeId, string authorId, Vector2 localPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ReceiveNetworkDrawPoint(string, string, Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				strokeId,
				authorId,
				localPoint
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
							strokeId = null;
						}
						else
						{
							strokeId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							localPoint = default(Vector2);
						}
						else
						{
							localPoint = (Vector2)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ReceiveNetworkDrawPoint(strokeId, authorId, localPoint);
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

		// Token: 0x06001971 RID: 6513 RVA: 0x000D6560 File Offset: 0x000D4760
		[NullableContext(1)]
		[DebuggerStepThrough]
		public void ReceiveNetworkDrawEnd(string strokeId, string authorId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ReceiveNetworkDrawEnd(string, string)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				strokeId,
				authorId
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
							strokeId = null;
						}
						else
						{
							strokeId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ReceiveNetworkDrawEnd(strokeId, authorId);
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

		// Token: 0x06001972 RID: 6514 RVA: 0x000D66B4 File Offset: 0x000D48B4
		[NullableContext(1)]
		[DebuggerStepThrough]
		public void ReceiveNetworkErase(string authorId, Vector2 localPoint, float radius)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ReceiveNetworkErase(string, Vector2, float)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				authorId,
				localPoint,
				radius
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
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							localPoint = default(Vector2);
						}
						else
						{
							localPoint = (Vector2)arguments[1];
						}
						if (arguments[2] == null)
						{
							radius = 0f;
						}
						else
						{
							radius = (float)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ReceiveNetworkErase(authorId, localPoint, radius);
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

		// Token: 0x06001973 RID: 6515 RVA: 0x000D6838 File Offset: 0x000D4A38
		[NullableContext(1)]
		[DebuggerStepThrough]
		public void ReceiveNetworkClearAll(string authorId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ReceiveNetworkClearAll(string)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				authorId
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
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ReceiveNetworkClearAll(authorId);
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

		// Token: 0x06001974 RID: 6516 RVA: 0x000D696C File Offset: 0x000D4B6C
		[DebuggerStepThrough]
		private void InitializeDrawLayer()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.InitializeDrawLayer()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							this.$Rougamo_InitializeDrawLayer();
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

		// Token: 0x06001975 RID: 6517 RVA: 0x000D6A68 File Offset: 0x000D4C68
		[NullableContext(1)]
		[DebuggerStepThrough]
		private static RectTransform CreateStretchChild(string objectName, Transform parent)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.CreateStretchChild(string, Transform)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				objectName,
				parent
			};
			RectTransform rectTransform;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					rectTransform = (RectTransform)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							objectName = null;
						}
						else
						{
							objectName = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							parent = null;
						}
						else
						{
							parent = (Transform)arguments[1];
						}
					}
					do
					{
						try
						{
							rectTransform = MapSelectUI.$Rougamo_CreateStretchChild(objectName, parent);
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
								rectTransform = (RectTransform)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_155;
							}
							throw;
						}
						methodContext.ReturnValue = rectTransform;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						rectTransform = (RectTransform)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_155:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return rectTransform;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000D6BF4 File Offset: 0x000D4DF4
		[DebuggerStepThrough]
		private void ToggleDrawTool(MapSelectUI.DrawToolMode drawToolMode)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ToggleDrawTool(MapSelectUI.DrawToolMode)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				drawToolMode
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
							drawToolMode = MapSelectUI.DrawToolMode.None;
						}
						else
						{
							drawToolMode = (MapSelectUI.DrawToolMode)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ToggleDrawTool(drawToolMode);
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

		// Token: 0x06001977 RID: 6519 RVA: 0x000D6D30 File Offset: 0x000D4F30
		[DebuggerStepThrough]
		private void ClearAllDrawingsAndSync()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ClearAllDrawingsAndSync()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							this.$Rougamo_ClearAllDrawingsAndSync();
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

		// Token: 0x06001978 RID: 6520 RVA: 0x000D6E2C File Offset: 0x000D502C
		[NullableContext(1)]
		[DebuggerStepThrough]
		private string CreateStrokeId()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.CreateStrokeId()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							text = this.$Rougamo_CreateStrokeId();
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

		// Token: 0x06001979 RID: 6521 RVA: 0x000D6F6C File Offset: 0x000D516C
		[NullableContext(1)]
		[DebuggerStepThrough]
		private string GetLocalPlayerId()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.GetLocalPlayerId()).MethodHandle, typeof(MapSelectUI).TypeHandle);
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
							text = this.$Rougamo_GetLocalPlayerId();
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

		// Token: 0x0600197A RID: 6522 RVA: 0x000D70AC File Offset: 0x000D52AC
		[NullableContext(1)]
		[DebuggerStepThrough]
		private void CacheAuthorColorIndex(string authorId, int playerIndex)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.CacheAuthorColorIndex(string, int)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				authorId,
				playerIndex
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
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							playerIndex = 0;
						}
						else
						{
							playerIndex = (int)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CacheAuthorColorIndex(authorId, playerIndex);
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

		// Token: 0x0600197B RID: 6523 RVA: 0x000D7208 File Offset: 0x000D5408
		[NullableContext(1)]
		[DebuggerStepThrough]
		private Color GetStrokeColor(string authorId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.GetStrokeColor(string)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				authorId
			};
			Color color;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					color = (Color)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							color = this.$Rougamo_GetStrokeColor(authorId);
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
								color = (Color)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_140;
							}
							throw;
						}
						methodContext.ReturnValue = color;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						color = (Color)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_140:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return color;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000D7380 File Offset: 0x000D5580
		[NullableContext(1)]
		[DebuggerStepThrough]
		private int ResolveAuthorColorIndex(string authorId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.ResolveAuthorColorIndex(string)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				authorId
			};
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
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							num = this.$Rougamo_ResolveAuthorColorIndex(authorId);
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
								goto IL_140;
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
					IL_140:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000D74F8 File Offset: 0x000D56F8
		[NullableContext(1)]
		[DebuggerStepThrough]
		private static int GetStableColorIndex(string authorId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.GetStableColorIndex(string)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				authorId
			};
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
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							num = MapSelectUI.$Rougamo_GetStableColorIndex(authorId);
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
								goto IL_138;
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
					IL_138:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000D7668 File Offset: 0x000D5868
		[NullableContext(1)]
		[DebuggerStepThrough]
		private void BeginStroke(string strokeId, string authorId, Vector2 startPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.BeginStroke(string, string, Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				strokeId,
				authorId,
				startPoint
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
							strokeId = null;
						}
						else
						{
							strokeId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							authorId = null;
						}
						else
						{
							authorId = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							startPoint = default(Vector2);
						}
						else
						{
							startPoint = (Vector2)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_BeginStroke(strokeId, authorId, startPoint);
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

		// Token: 0x0600197F RID: 6527 RVA: 0x000D77E4 File Offset: 0x000D59E4
		[NullableContext(1)]
		[DebuggerStepThrough]
		private bool AppendStrokePoint(string strokeId, Vector2 nextPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.AppendStrokePoint(string, Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				strokeId,
				nextPoint
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
							strokeId = null;
						}
						else
						{
							strokeId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							nextPoint = default(Vector2);
						}
						else
						{
							nextPoint = (Vector2)arguments[1];
						}
					}
					do
					{
						try
						{
							flag = this.$Rougamo_AppendStrokePoint(strokeId, nextPoint);
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
								goto IL_16A;
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
					IL_16A:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return flag;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000D799C File Offset: 0x000D5B9C
		[NullableContext(1)]
		[DebuggerStepThrough]
		private void CreateSegment(MapSelectUI.MapDrawStroke stroke, Vector2 startPoint, Vector2 endPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.CreateSegment(MapSelectUI.MapDrawStroke, Vector2, Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				stroke,
				startPoint,
				endPoint
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
							stroke = null;
						}
						else
						{
							stroke = (MapSelectUI.MapDrawStroke)arguments[0];
						}
						if (arguments[1] == null)
						{
							startPoint = default(Vector2);
						}
						else
						{
							startPoint = (Vector2)arguments[1];
						}
						if (arguments[2] == null)
						{
							endPoint = default(Vector2);
						}
						else
						{
							endPoint = (Vector2)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateSegment(stroke, startPoint, endPoint);
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

		// Token: 0x06001981 RID: 6529 RVA: 0x000D7B20 File Offset: 0x000D5D20
		[NullableContext(1)]
		[DebuggerStepThrough]
		private Sprite GetStrokeSprite()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.GetStrokeSprite()).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[0];
			Sprite sprite;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					sprite = (Sprite)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							sprite = this.$Rougamo_GetStrokeSprite();
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
								sprite = (Sprite)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_108;
							}
							throw;
						}
						methodContext.ReturnValue = sprite;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						sprite = (Sprite)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_108:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return sprite;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000D7C60 File Offset: 0x000D5E60
		[NullableContext(1)]
		private void EraseAt(Vector2 erasePoint, string authorId, float radius = 28f)
		{
			bool flag = this._strokes.Count == 0;
			if (!flag)
			{
				List<string> removeStrokeIds = new List<string>();
				foreach (KeyValuePair<string, MapSelectUI.MapDrawStroke> pair in this._strokes)
				{
					MapSelectUI.MapDrawStroke stroke = pair.Value;
					bool flag2 = stroke.AuthorId != authorId;
					if (!flag2)
					{
						for (int index = stroke.Segments.Count - 1; index >= 0; index--)
						{
							MapSelectUI.MapDrawSegment segment = stroke.Segments[index];
							bool flag3 = MapSelectUI.DistanceToSegment(erasePoint, segment.Start, segment.End) > radius;
							if (!flag3)
							{
								bool flag4 = segment.RectTransform != null;
								if (flag4)
								{
									UnityEngine.Object.Destroy(segment.RectTransform.gameObject);
								}
								stroke.Segments.RemoveAt(index);
							}
						}
						bool flag5 = stroke.Segments.Count == 0 && stroke.Root != null;
						if (flag5)
						{
							UnityEngine.Object.Destroy(stroke.Root.gameObject);
							removeStrokeIds.Add(pair.Key);
						}
					}
				}
				foreach (string strokeId in removeStrokeIds)
				{
					this._strokes.Remove(strokeId);
				}
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000D7E30 File Offset: 0x000D6030
		[DebuggerStepThrough]
		private static float DistanceToSegment(Vector2 point, Vector2 startPoint, Vector2 endPoint)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(MapSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(MapSelectUI.DistanceToSegment(Vector2, Vector2, Vector2)).MethodHandle, typeof(MapSelectUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				point,
				startPoint,
				endPoint
			};
			float num;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					num = (float)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							point = default(Vector2);
						}
						else
						{
							point = (Vector2)arguments[0];
						}
						if (arguments[1] == null)
						{
							startPoint = default(Vector2);
						}
						else
						{
							startPoint = (Vector2)arguments[1];
						}
						if (arguments[2] == null)
						{
							endPoint = default(Vector2);
						}
						else
						{
							endPoint = (Vector2)arguments[2];
						}
					}
					do
					{
						try
						{
							num = MapSelectUI.$Rougamo_DistanceToSegment(point, startPoint, endPoint);
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
								num = (float)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_194;
							}
							throw;
						}
						methodContext.ReturnValue = num;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						num = (float)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_194:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000D8014 File Offset: 0x000D6214
		[NullableContext(1)]
		private void ClearDrawings(string authorId = null)
		{
			bool flag = !string.IsNullOrWhiteSpace(authorId);
			if (flag)
			{
				List<string> removeStrokeIds = new List<string>();
				foreach (KeyValuePair<string, MapSelectUI.MapDrawStroke> pair in this._strokes)
				{
					bool flag2 = pair.Value.AuthorId != authorId;
					if (!flag2)
					{
						bool flag3 = pair.Value.Root != null;
						if (flag3)
						{
							UnityEngine.Object.Destroy(pair.Value.Root.gameObject);
						}
						removeStrokeIds.Add(pair.Key);
					}
				}
				foreach (string strokeId in removeStrokeIds)
				{
					this._strokes.Remove(strokeId);
				}
				MapSelectUI.MapDrawStroke activeStroke;
				bool flag4 = !string.IsNullOrWhiteSpace(this._activeStrokeId) && this._strokes.TryGetValue(this._activeStrokeId, out activeStroke) && activeStroke.AuthorId == authorId;
				if (flag4)
				{
					this._activeStrokeId = null;
				}
			}
			else
			{
				foreach (KeyValuePair<string, MapSelectUI.MapDrawStroke> pair2 in this._strokes)
				{
					bool flag5 = pair2.Value.Root != null;
					if (flag5)
					{
						UnityEngine.Object.Destroy(pair2.Value.Root.gameObject);
					}
				}
				this._strokes.Clear();
				this._authorColorIndices.Clear();
				this._activeStrokeId = null;
			}
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x000955BC File Offset: 0x000937BC
		private MapTree $Rougamo_get_mapTree()
		{
			return MapManager.Instance.MapTree;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x000D8338 File Offset: 0x000D6538
		private void $Rougamo_FadeIn()
		{
			this.animationType = UIBase.AnimationType.None;
			base.FadeIn();
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000D834C File Offset: 0x000D654C
		private void $Rougamo_Awake()
		{
			bool flag = GameObject.Find("House") != null;
			if (flag)
			{
				UnityEngine.Object.Destroy(GameObject.Find("House"));
			}
			Material material = Resources.Load<Material>("Material/PostProcess/Blur");
			if (material != null)
			{
				material.DisableKeyword("_BLUR_ON");
			}
			this.ground_y = this.groundPos.position.y;
			this.InitializeDrawLayer();
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000D83B8 File Offset: 0x000D65B8
		private void $Rougamo_DataUpdate()
		{
			base.transform.Find("Title/Text/text").GetComponent<TMP_Text>().text = GameApp.Instance.NowBackground.name.Localize("MapSelectUI");
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x000D83EF File Offset: 0x000D65EF
		private void $Rougamo_ResetBackCard()
		{
			RoleTable.Instance.ResetBackCard();
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000D8400 File Offset: 0x000D6600
		private void $Rougamo_Start()
		{
			this.DataUpdate();
			bool flag = FightManager.Instance != null && (RoleTable.Instance.San <= 0 || RoleTable.Instance.MaxSan <= 0);
			if (flag)
			{
				RoleTable.Instance.isDead = true;
				Debug.Log("检查死亡");
				FightManager.Instance.CmdCheckDead(null);
			}
			this.ResetBackCard();
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
				base.transform.Find("Next").gameObject.SetActive(true);
				this.cardContainer = base.transform.Find("MapSelect").GetComponent<CardContainer>();
				ButtonManager quillBtn = this.QuillBtn;
				if (quillBtn != null)
				{
					quillBtn.onClick.AddListener(delegate
					{
						this.ToggleDrawTool(MapSelectUI.DrawToolMode.Quill);
					});
				}
				ButtonManager ereaseBtn = this.EreaseBtn;
				if (ereaseBtn != null)
				{
					ereaseBtn.onClick.AddListener(delegate
					{
						this.ToggleDrawTool(MapSelectUI.DrawToolMode.Eraser);
					});
				}
				ButtonManager garbageBtn = this.GarbageBtn;
				if (garbageBtn != null)
				{
					garbageBtn.onClick.AddListener(new UnityAction(this.ClearAllDrawingsAndSync));
				}
				base.transform.Find("Next").GetComponent<ButtonManager>().onClick.AddListener(delegate
				{
					this.TryContinue();
				});
				RoleTable.Instance.LevelCount();
				bool flag6 = MapManager.Instance.Level % 6 == 0 && PlayerManager.Instance.isServer;
				if (flag6)
				{
					MapManager.Instance.MapItemInit(this);
				}
				else
				{
					bool isServer = PlayerManager.Instance.isServer;
					if (isServer)
					{
						MapManager.Instance.mapList = this.GetNodes().Select(delegate(MapTree.Node x)
						{
							Dictionary<string, string> data = x.data;
							return (data != null) ? data.GetValueOrDefault("Id", null) : null;
						}).ToArray<string>();
						MapManager.Instance.CmdSelectMap(MapManager.Instance.mapList, this.GetNodes().Select(delegate(MapTree.Node x)
						{
							Dictionary<string, string> data = x.data;
							return (data != null) ? data.GetValueOrDefault("NodeId", null) : null;
						}).ToArray<string>(), null);
						this.ShowMap();
					}
				}
				PlayerManager.Instance.SendQuery<ValueTuple<string, DataConfig>[]>(new QueryCareers(), new Action<ValueTuple<string, DataConfig>[]>(this.CreateRole));
				UIManager.Instance.CheckUI();
				GameApp.Instance.SetSteamRichState("Adventure");
				MapManager.Instance.MapUIStart(this);
			}
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000D874C File Offset: 0x000D694C
		private void $Rougamo_TryContinue()
		{
			bool flag = !PlayerManager.Instance.isServer;
			if (flag)
			{
				bool flag2;
				if (MapManager.Instance.mapList.Length == 6)
				{
					if (MapManager.Instance.mapList.All((string x) => x != null) && MapManager.Instance.mapData.Length == 6)
					{
						flag2 = !MapManager.Instance.mapData.All((string x) => x != null);
						goto IL_98;
					}
				}
				flag2 = true;
				IL_98:
				bool flag3 = flag2;
				if (flag3)
				{
					UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("等待房主选择地图", CaptionStyle.Top, 1f, 1.5f, 3);
					return;
				}
			}
			else
			{
				bool flag4 = this.GetNodes().Any((MapTree.Node x) => x.data == null);
				if (flag4)
				{
					UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("请填满所有节点", CaptionStyle.Top, 1f, 1.5f, 3);
					return;
				}
			}
			this.SelectMap();
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000D8881 File Offset: 0x000D6A81
		private void $Rougamo_UpdateCardItemPos()
		{
			this.IsAnimating = true;
			this.cardContainer.UpdateCardItemPos<MapItem>(base.transform.Find("MapSelect").GetComponentsInChildren<MapItem>().ToList<MapItem>(), delegate
			{
				this.IsAnimating = false;
			}, true);
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x000D88C0 File Offset: 0x000D6AC0
		private void $Rougamo_ReadyToSelect()
		{
			List<MapTree.Node> nodes = this.mapTree.SelectNode.GetRange((8 - GameSaveManager.GetValue<int>(GameVar.ExDeleteDes)) * (MapManager.Instance.Level / 6), 8 - GameSaveManager.GetValue<int>(GameVar.ExDeleteDes));
			this.CreateMapItem(nodes);
			this.UpdateCardItemPos();
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000D890C File Offset: 0x000D6B0C
		private void $Rougamo_SendNode()
		{
			MapManager.Instance.CmdSelectMap(this.GetNodes().Select(delegate(MapTree.Node x)
			{
				Dictionary<string, string> data = x.data;
				return (data != null) ? data.GetValueOrDefault("Id", null) : null;
			}).ToArray<string>(), this.GetNodes().Select(delegate(MapTree.Node x)
			{
				Dictionary<string, string> data = x.data;
				return (data != null) ? data.GetValueOrDefault("NodeId", null) : null;
			}).ToArray<string>(), null);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000D8984 File Offset: 0x000D6B84
		private void $Rougamo_ShowMap()
		{
			this.ClearDrawings(null);
			string[] nodes = MapManager.Instance.mapList;
			Sprite NormalIcon = ResourceLoader.Load<Sprite>("Icon/Map/未完成节点", true);
			Sprite HighlightIcon = ResourceLoader.Load<Sprite>("Icon/Map/已完成", true);
			MapItem[] mapitems = base.transform.Find("Map/NodeContent").GetComponentsInChildren<MapItem>();
			bool flag = base.transform.Find("Map/NodeContent/Start/Content/EventPrefab") != null;
			if (flag)
			{
				UnityEngine.Object.Destroy(base.transform.Find("Map/NodeContent/Start/Content/EventPrefab").gameObject);
				UnityEngine.Object.Destroy(base.transform.Find("Map/NodeContent/End/Content/FightPrefab").gameObject);
			}
			foreach (MapItem mapitem in mapitems)
			{
				UnityEngine.Object.Destroy(mapitem.gameObject);
			}
			base.transform.Find("Map").GetComponent<CanvasGroup>().blocksRaycasts = true;
			for (int i = 0; i < nodes.Length; i++)
			{
				bool flag2 = nodes[i] == null;
				if (!flag2)
				{
					MapTree.Node nowNode = new MapTree.Node("地图")
					{
						data = Singleton<GameConfigManager>.Instance.GetOne(DataType.Map, nodes[i])
					};
					bool flag3 = !PlayerManager.Instance.isServer;
					if (flag3)
					{
						nowNode.data["NodeId"] = MapManager.Instance.mapData[i];
					}
					string prefabName = this.GetPrefabName(nowNode);
					Transform item = UnityEngine.Object.Instantiate<Transform>(base.transform.Find("MapSelect/" + prefabName), base.transform.Find("Map/NodeContent").GetChild(i).Find("Content"));
					string text = prefabName;
					string a = text;
					if (!(a == "EventPrefab"))
					{
						if (!(a == "FightPrefab"))
						{
							if (a == "BuildPrefab")
							{
								item.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/建筑牌", true);
							}
						}
					}
					else
					{
						item.transform.Find("Front/background").GetComponent<MeshRenderer>().material.mainTexture = ResourceLoader.Load<Texture>("Icon/CardTemplate/故事牌", true);
					}
					item.localScale = Vector3.one;
					item.gameObject.AddComponent<MapItem>().Init(nowNode);
					bool flag4 = i < MapManager.Instance.Level % 6;
					if (flag4)
					{
						item.parent.parent.Find("Frame/Normal/Icon").GetComponent<SpriteRenderer>().sprite = HighlightIcon;
						item.parent.parent.Find("Frame/finish").gameObject.SetActive(true);
					}
					else
					{
						item.parent.parent.Find("Frame/Normal/Icon").GetComponent<SpriteRenderer>().sprite = NormalIcon;
					}
					Transform transform = item.parent.Find("Null");
					if (transform != null)
					{
						transform.gameObject.SetActive(false);
					}
					item.gameObject.SetActive(true);
				}
			}
			bool isServer = PlayerManager.Instance.isServer;
			if (isServer)
			{
				GameServer.Instance.SaveGame();
			}
			SafeBoxUI.SafeboxSave();
			Singleton<GameRuntimeData>.Instance.Save();
			this.MapAnimation();
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000D8CE0 File Offset: 0x000D6EE0
		private void $Rougamo_CreateRole(ValueTuple<string, DataConfig>[] roleList)
		{
			bool flag = this == null || base.gameObject == null;
			if (!flag)
			{
				Transform tempParent = base.transform.Find("RoleList/RolePre");
				tempParent.gameObject.SetActive(false);
				for (int i = 0; i < roleList.Count<ValueTuple<string, DataConfig>>(); i++)
				{
					string id = roleList[i].Item1;
					DataConfig career = roleList[i].Item2;
					bool flag2 = id == null || career == null;
					if (!flag2)
					{
						this.CacheAuthorColorIndex(id, i);
						Transform tempItem = UnityEngine.Object.Instantiate<Transform>(tempParent, base.transform.Find("RoleList"));
						tempItem.gameObject.SetActive(true);
						tempItem.Find("role").GetComponent<MapRole>().Init(i, career, id, true);
						tempItem.SetAsFirstSibling();
					}
				}
			}
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000D8DD0 File Offset: 0x000D6FD0
		private string $Rougamo_GetPrefabName(MapTree.Node node)
		{
			return node.data["Type"] + "Prefab";
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000D8DFC File Offset: 0x000D6FFC
		private void $Rougamo_CreateNodes(int count)
		{
			MapTree.Node nowNode = this.mapTree.currentNode;
			for (int i = 0; i < count; i++)
			{
				MapTree.Node node = new MapTree.Node("null");
				nowNode.SetChild(0, node);
				nowNode = node;
			}
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000D8E40 File Offset: 0x000D7040
		private MapTree.Node[] $Rougamo_GetNodes()
		{
			MapTree.Node nowNode = GameSaveManager.GetNode();
			List<MapTree.Node> nodes = new List<MapTree.Node>();
			while (nowNode.childrens != null)
			{
				nodes.Add(nowNode);
				nowNode = nowNode.childrens[0];
			}
			nodes.Add(nowNode);
			return nodes.ToArray();
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000D8E90 File Offset: 0x000D7090
		private void $Rougamo_SetNodes()
		{
			bool flag = this.isCloseing;
			if (!flag)
			{
				MapTree.Node[] nodes = this.GetNodes();
				for (int i = 0; i < base.transform.Find("Map/NodeContent").childCount; i++)
				{
					Transform mapnode = base.transform.Find("Map/NodeContent").GetChild(i);
					MapItem mapItem = mapnode.GetComponentInChildren<MapItem>();
					bool flag2 = mapItem == null;
					if (flag2)
					{
						nodes[i].data = null;
					}
					else
					{
						nodes[i].data = mapItem.node.data;
						nodes[i].NodeDice = mapItem.node.NodeDice;
					}
				}
				MapManager.Instance.CmdSelectMap(nodes.Select(delegate(MapTree.Node x)
				{
					Dictionary<string, string> data = x.data;
					return (data != null) ? data.GetValueOrDefault("Id", null) : null;
				}).ToArray<string>(), nodes.Select(delegate(MapTree.Node x)
				{
					Dictionary<string, string> data = x.data;
					return (data != null) ? data.GetValueOrDefault("NodeId", null) : null;
				}).ToArray<string>(), null);
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000D8FA4 File Offset: 0x000D71A4
		private void $Rougamo_OnDestroy()
		{
			base.transform.Find("GlobalLight").gameObject.SetActive(false);
			base.OnDestroy();
			this.ClearDrawings(null);
			bool flag = UIManager.Instance.GetUI<LineUI>("LineUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<LineUI>("LineUI").Close();
			}
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000D9010 File Offset: 0x000D7210
		private void $Rougamo_SelectMap()
		{
			bool flag = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null;
			if (!flag)
			{
				bool flag2 = this.isCloseing;
				if (!flag2)
				{
					this.isCloseing = true;
					UniTask.WaitWhile(() => this.isTweening, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
					{
						Animator animator = base.gameObject.GetComponent<Animator>();
						bool flag3 = animator != null;
						if (flag3)
						{
							animator.SetTrigger("Exit");
							bool flag4 = MapManager.Instance != null;
							if (flag4)
							{
								MapManager.Instance.CmdReadyToNextMap(null);
							}
						}
					}).Forget();
				}
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000D9080 File Offset: 0x000D7280
		private void $Rougamo_HandleDrawPointerDown(Vector2 localPoint)
		{
			bool flag = this.isCloseing || this._drawLayer == null;
			if (!flag)
			{
				bool flag2 = this._drawToolMode == MapSelectUI.DrawToolMode.Quill;
				if (flag2)
				{
					this._activeStrokeId = this.CreateStrokeId();
					this.BeginStroke(this._activeStrokeId, this.GetLocalPlayerId(), localPoint);
					MapManager instance = MapManager.Instance;
					if (instance != null)
					{
						instance.CmdMapDrawBegin(this._activeStrokeId, this.GetLocalPlayerId(), localPoint, null);
					}
				}
				else
				{
					bool flag3 = this._drawToolMode == MapSelectUI.DrawToolMode.Eraser;
					if (flag3)
					{
						this.EraseAt(localPoint, this.GetLocalPlayerId(), 28f);
						MapManager instance2 = MapManager.Instance;
						if (instance2 != null)
						{
							instance2.CmdMapErase(this.GetLocalPlayerId(), localPoint, 28f, null);
						}
					}
				}
			}
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x000D9140 File Offset: 0x000D7340
		private void $Rougamo_HandleDrawPointerDrag(Vector2 localPoint)
		{
			bool flag = this.isCloseing || this._drawLayer == null;
			if (!flag)
			{
				bool flag2 = this._drawToolMode == MapSelectUI.DrawToolMode.Quill;
				if (flag2)
				{
					bool flag3 = string.IsNullOrWhiteSpace(this._activeStrokeId);
					if (!flag3)
					{
						bool flag4 = this.AppendStrokePoint(this._activeStrokeId, localPoint);
						if (flag4)
						{
							MapManager instance = MapManager.Instance;
							if (instance != null)
							{
								instance.CmdMapDrawPoint(this._activeStrokeId, this.GetLocalPlayerId(), localPoint, null);
							}
						}
					}
				}
				else
				{
					bool flag5 = this._drawToolMode == MapSelectUI.DrawToolMode.Eraser;
					if (flag5)
					{
						this.EraseAt(localPoint, this.GetLocalPlayerId(), 28f);
						MapManager instance2 = MapManager.Instance;
						if (instance2 != null)
						{
							instance2.CmdMapErase(this.GetLocalPlayerId(), localPoint, 28f, null);
						}
					}
				}
			}
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000D9208 File Offset: 0x000D7408
		private void $Rougamo_HandleDrawPointerUp(Vector2 localPoint)
		{
			bool flag = this._drawToolMode == MapSelectUI.DrawToolMode.Quill && !string.IsNullOrWhiteSpace(this._activeStrokeId);
			if (flag)
			{
				MapManager instance = MapManager.Instance;
				if (instance != null)
				{
					instance.CmdMapDrawEnd(this._activeStrokeId, this.GetLocalPlayerId(), null);
				}
				this._activeStrokeId = null;
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x000D925B File Offset: 0x000D745B
		private void $Rougamo_ReceiveNetworkDrawBegin(string strokeId, string authorId, Vector2 localPoint)
		{
			this.BeginStroke(strokeId, authorId, localPoint);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x000D9268 File Offset: 0x000D7468
		private void $Rougamo_ReceiveNetworkDrawPoint(string strokeId, string authorId, Vector2 localPoint)
		{
			this.AppendStrokePoint(strokeId, localPoint);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000D9274 File Offset: 0x000D7474
		private void $Rougamo_ReceiveNetworkDrawEnd(string strokeId, string authorId)
		{
			bool flag = this._activeStrokeId == strokeId;
			if (flag)
			{
				this._activeStrokeId = null;
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000D929B File Offset: 0x000D749B
		private void $Rougamo_ReceiveNetworkErase(string authorId, Vector2 localPoint, float radius)
		{
			this.EraseAt(localPoint, authorId, radius);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x000D92A8 File Offset: 0x000D74A8
		private void $Rougamo_ReceiveNetworkClearAll(string authorId)
		{
			this.ClearDrawings(authorId);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000D92B4 File Offset: 0x000D74B4
		private void $Rougamo_InitializeDrawLayer()
		{
			bool flag = this._drawLayer != null;
			if (!flag)
			{
				Transform transform = base.transform.Find("Map");
				this._mapRect = ((transform != null) ? transform.GetComponent<RectTransform>() : null);
				bool flag2 = this._mapRect == null;
				if (!flag2)
				{
					this._drawLayer = MapSelectUI.CreateStretchChild("DrawLayer", this._mapRect);
					this._drawLayer.SetAsLastSibling();
					RectTransform inputRect = MapSelectUI.CreateStretchChild("DrawInput", this._mapRect);
					inputRect.SetAsLastSibling();
					this._drawInputImage = inputRect.gameObject.AddComponent<Image>();
					this._drawInputImage.color = new Color(0f, 0f, 0f, 0f);
					this._drawInputImage.raycastTarget = false;
					this._drawInputLayer = inputRect.gameObject.AddComponent<MapDrawInputLayer>();
					this._drawInputLayer.Owner = this;
				}
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000D93AC File Offset: 0x000D75AC
		private static RectTransform $Rougamo_CreateStretchChild(string objectName, Transform parent)
		{
			GameObject gameObject = new GameObject(objectName, new Type[]
			{
				typeof(RectTransform)
			});
			RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
			rectTransform.SetParent(parent, false);
			rectTransform.anchorMin = Vector2.zero;
			rectTransform.anchorMax = Vector2.one;
			rectTransform.offsetMin = Vector2.zero;
			rectTransform.offsetMax = Vector2.zero;
			rectTransform.localScale = Vector3.one;
			rectTransform.localPosition = Vector3.zero;
			return rectTransform;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x000D9434 File Offset: 0x000D7634
		private void $Rougamo_ToggleDrawTool(MapSelectUI.DrawToolMode drawToolMode)
		{
			this.InitializeDrawLayer();
			bool flag = this._drawLayer == null || this._drawInputImage == null;
			if (!flag)
			{
				this._drawToolMode = ((this._drawToolMode == drawToolMode) ? MapSelectUI.DrawToolMode.None : drawToolMode);
				this._drawInputImage.raycastTarget = (this._drawToolMode > MapSelectUI.DrawToolMode.None);
				MapSelectUI.DrawToolMode drawToolMode2 = this._drawToolMode;
				if (!true)
				{
				}
				string text;
				if (drawToolMode2 != MapSelectUI.DrawToolMode.Quill)
				{
					if (drawToolMode2 != MapSelectUI.DrawToolMode.Eraser)
					{
						text = "关闭绘制";
					}
					else
					{
						text = "橡皮";
					}
				}
				else
				{
					text = "羽毛笔";
				}
				if (!true)
				{
				}
				string toolName = text;
				CaptionUI ui = UIManager.Instance.GetUI<CaptionUI>("CaptionUI");
				if (ui != null)
				{
					ui.ShowCaption(toolName, CaptionStyle.Top, 0.5f, 1f, 2);
				}
			}
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x000D94F8 File Offset: 0x000D76F8
		private void $Rougamo_ClearAllDrawingsAndSync()
		{
			this._drawToolMode = MapSelectUI.DrawToolMode.None;
			bool flag = this._drawInputImage != null;
			if (flag)
			{
				this._drawInputImage.raycastTarget = false;
			}
			string localPlayerId = this.GetLocalPlayerId();
			this.ClearDrawings(localPlayerId);
			MapManager instance = MapManager.Instance;
			if (instance != null)
			{
				instance.CmdMapClearAll(localPlayerId, null);
			}
			CaptionUI ui = UIManager.Instance.GetUI<CaptionUI>("CaptionUI");
			if (ui != null)
			{
				ui.ShowCaption("已清空自己的画笔痕迹", CaptionStyle.Top, 0.5f, 1f, 2);
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000D957C File Offset: 0x000D777C
		private string $Rougamo_CreateStrokeId()
		{
			this._strokeCounter++;
			return ZString.Format<object, object>("{0}_{1}", this.GetLocalPlayerId(), this._strokeCounter);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x000D95B8 File Offset: 0x000D77B8
		private string $Rougamo_GetLocalPlayerId()
		{
			bool flag = PlayerManager.Instance != null && !string.IsNullOrWhiteSpace(PlayerManager.Instance.PlayerId);
			string result;
			if (flag)
			{
				result = PlayerManager.Instance.PlayerId;
			}
			else
			{
				result = (Singleton<GameConfigManager>.Instance.PlayerId ?? "Unknown");
			}
			return result;
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x000D9614 File Offset: 0x000D7814
		private void $Rougamo_CacheAuthorColorIndex(string authorId, int playerIndex)
		{
			bool flag = string.IsNullOrWhiteSpace(authorId);
			if (!flag)
			{
				this._authorColorIndices[authorId] = Mathf.Abs(playerIndex) % MapSelectUI.StrokeColors.Length;
			}
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x000D964C File Offset: 0x000D784C
		private Color $Rougamo_GetStrokeColor(string authorId)
		{
			return MapSelectUI.StrokeColors[this.ResolveAuthorColorIndex(authorId)];
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x000D9670 File Offset: 0x000D7870
		private int $Rougamo_ResolveAuthorColorIndex(string authorId)
		{
			bool flag = string.IsNullOrWhiteSpace(authorId);
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int colorIndex;
				bool flag2 = this._authorColorIndices.TryGetValue(authorId, out colorIndex);
				if (flag2)
				{
					result = colorIndex;
				}
				else
				{
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
					bool flag3 = obj != null;
					if (flag3)
					{
						for (int index = 0; index < PlayerManager.Instance.LobbyInfos.AddedPlayers.Count; index++)
						{
							bool flag4 = PlayerManager.Instance.LobbyInfos.AddedPlayers[index].Id != authorId;
							if (!flag4)
							{
								this.CacheAuthorColorIndex(authorId, index);
								return this._authorColorIndices[authorId];
							}
						}
					}
					colorIndex = MapSelectUI.GetStableColorIndex(authorId);
					this._authorColorIndices[authorId] = colorIndex;
					result = colorIndex;
				}
			}
			return result;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000D975C File Offset: 0x000D795C
		private static int $Rougamo_GetStableColorIndex(string authorId)
		{
			int hash = 17;
			foreach (char character in authorId)
			{
				hash = hash * 31 + (int)character;
			}
			bool flag = hash == int.MinValue;
			if (flag)
			{
				hash = 0;
			}
			return Mathf.Abs(hash) % MapSelectUI.StrokeColors.Length;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000D97BC File Offset: 0x000D79BC
		private void $Rougamo_BeginStroke(string strokeId, string authorId, Vector2 startPoint)
		{
			this.InitializeDrawLayer();
			bool flag = this._drawLayer == null;
			if (!flag)
			{
				bool flag2 = this._strokes.ContainsKey(strokeId);
				if (!flag2)
				{
					RectTransform strokeRoot = MapSelectUI.CreateStretchChild("Stroke_" + strokeId, this._drawLayer);
					strokeRoot.SetAsLastSibling();
					MapSelectUI.MapDrawStroke stroke = new MapSelectUI.MapDrawStroke
					{
						StrokeId = strokeId,
						AuthorId = authorId,
						Root = strokeRoot
					};
					stroke.Points.Add(startPoint);
					this._strokes.Add(strokeId, stroke);
				}
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000D984C File Offset: 0x000D7A4C
		private bool $Rougamo_AppendStrokePoint(string strokeId, Vector2 nextPoint)
		{
			MapSelectUI.MapDrawStroke stroke;
			bool flag = !this._strokes.TryGetValue(strokeId, out stroke);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				List<Vector2> points = stroke.Points;
				Vector2 previousPoint = points[points.Count - 1];
				bool flag2 = Vector2.Distance(previousPoint, nextPoint) < 6f;
				if (flag2)
				{
					result = false;
				}
				else
				{
					stroke.Points.Add(nextPoint);
					this.CreateSegment(stroke, previousPoint, nextPoint);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000D98C0 File Offset: 0x000D7AC0
		private void $Rougamo_CreateSegment(MapSelectUI.MapDrawStroke stroke, Vector2 startPoint, Vector2 endPoint)
		{
			GameObject segmentObject = new GameObject(ZString.Format<object>("Segment_{0}", stroke.Segments.Count), new Type[]
			{
				typeof(RectTransform),
				typeof(CanvasRenderer),
				typeof(Image)
			});
			RectTransform segmentTransform = segmentObject.GetComponent<RectTransform>();
			segmentTransform.SetParent(stroke.Root, false);
			segmentTransform.anchorMin = new Vector2(0.5f, 0.5f);
			segmentTransform.anchorMax = new Vector2(0.5f, 0.5f);
			segmentTransform.pivot = new Vector2(0.5f, 0.5f);
			Image segmentImage = segmentObject.GetComponent<Image>();
			segmentImage.sprite = this.GetStrokeSprite();
			segmentImage.type = Image.Type.Simple;
			segmentImage.color = this.GetStrokeColor(stroke.AuthorId);
			segmentImage.raycastTarget = false;
			Vector2 direction = endPoint - startPoint;
			float distance = direction.magnitude;
			segmentTransform.sizeDelta = new Vector2(distance, 10f);
			segmentTransform.anchoredPosition = (startPoint + endPoint) * 0.5f;
			float angle = Mathf.Atan2(direction.y, direction.x) * 57.29578f;
			segmentTransform.localRotation = Quaternion.Euler(0f, 0f, angle);
			stroke.Segments.Add(new MapSelectUI.MapDrawSegment
			{
				RectTransform = segmentTransform,
				Start = startPoint,
				End = endPoint
			});
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000D9A3C File Offset: 0x000D7C3C
		private Sprite $Rougamo_GetStrokeSprite()
		{
			bool flag = this._strokeSprite != null;
			Sprite strokeSprite;
			if (flag)
			{
				strokeSprite = this._strokeSprite;
			}
			else
			{
				this._strokeTexture = new Texture2D(1, 1, TextureFormat.RGBA32, false);
				this._strokeTexture.SetPixel(0, 0, Color.white);
				this._strokeTexture.Apply();
				this._strokeSprite = Sprite.Create(this._strokeTexture, new Rect(0f, 0f, 1f, 1f), new Vector2(0.5f, 0.5f));
				strokeSprite = this._strokeSprite;
			}
			return strokeSprite;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000D9AD8 File Offset: 0x000D7CD8
		private static float $Rougamo_DistanceToSegment(Vector2 point, Vector2 startPoint, Vector2 endPoint)
		{
			Vector2 segment = endPoint - startPoint;
			float segmentLengthSquared = segment.sqrMagnitude;
			bool flag = segmentLengthSquared <= Mathf.Epsilon;
			float result;
			if (flag)
			{
				result = Vector2.Distance(point, startPoint);
			}
			else
			{
				float projection = Mathf.Clamp01(Vector2.Dot(point - startPoint, segment) / segmentLengthSquared);
				Vector2 closestPoint = startPoint + projection * segment;
				result = Vector2.Distance(point, closestPoint);
			}
			return result;
		}

		// Token: 0x04001388 RID: 5000
		private const float StrokeThickness = 10f;

		// Token: 0x04001389 RID: 5001
		private const float MinPointDistance = 6f;

		// Token: 0x0400138A RID: 5002
		private const float EraserRadius = 28f;

		// Token: 0x0400138B RID: 5003
		private static readonly Color[] StrokeColors = new Color[]
		{
			new Color(0.86f, 0.25f, 0.22f, 0.92f),
			new Color(0.16f, 0.58f, 0.88f, 0.92f),
			new Color(0.23f, 0.72f, 0.43f, 0.92f),
			new Color(0.96f, 0.67f, 0.18f, 0.92f)
		};

		// Token: 0x0400138C RID: 5004
		public CardContainer cardContainer;

		// Token: 0x0400138D RID: 5005
		protected bool isCloseing = false;

		// Token: 0x0400138E RID: 5006
		protected bool isTweening = false;

		// Token: 0x0400138F RID: 5007
		public float ground_y;

		// Token: 0x04001390 RID: 5008
		public Transform groundPos;

		// Token: 0x04001391 RID: 5009
		public ButtonManager EreaseBtn;

		// Token: 0x04001392 RID: 5010
		public ButtonManager QuillBtn;

		// Token: 0x04001393 RID: 5011
		public ButtonManager GarbageBtn;

		// Token: 0x04001394 RID: 5012
		private RectTransform _mapRect;

		// Token: 0x04001395 RID: 5013
		private RectTransform _drawLayer;

		// Token: 0x04001396 RID: 5014
		private Image _drawInputImage;

		// Token: 0x04001397 RID: 5015
		private MapDrawInputLayer _drawInputLayer;

		// Token: 0x04001398 RID: 5016
		private Sprite _strokeSprite;

		// Token: 0x04001399 RID: 5017
		private Texture2D _strokeTexture;

		// Token: 0x0400139A RID: 5018
		private MapSelectUI.DrawToolMode _drawToolMode;

		// Token: 0x0400139B RID: 5019
		private readonly Dictionary<string, MapSelectUI.MapDrawStroke> _strokes = new Dictionary<string, MapSelectUI.MapDrawStroke>();

		// Token: 0x0400139C RID: 5020
		private readonly Dictionary<string, int> _authorColorIndices = new Dictionary<string, int>();

		// Token: 0x0400139D RID: 5021
		private string _activeStrokeId;

		// Token: 0x0400139E RID: 5022
		private int _strokeCounter;

		// Token: 0x0400139F RID: 5023
		public bool IsAnimating;

		// Token: 0x0200032E RID: 814
		private enum DrawToolMode
		{
			// Token: 0x040013A1 RID: 5025
			None,
			// Token: 0x040013A2 RID: 5026
			Quill,
			// Token: 0x040013A3 RID: 5027
			Eraser
		}

		// Token: 0x0200032F RID: 815
		private sealed class MapDrawStroke
		{
			// Token: 0x040013A4 RID: 5028
			public string StrokeId;

			// Token: 0x040013A5 RID: 5029
			public string AuthorId;

			// Token: 0x040013A6 RID: 5030
			public RectTransform Root;

			// Token: 0x040013A7 RID: 5031
			public readonly List<Vector2> Points = new List<Vector2>();

			// Token: 0x040013A8 RID: 5032
			public readonly List<MapSelectUI.MapDrawSegment> Segments = new List<MapSelectUI.MapDrawSegment>();
		}

		// Token: 0x02000330 RID: 816
		private sealed class MapDrawSegment
		{
			// Token: 0x040013A9 RID: 5033
			public RectTransform RectTransform;

			// Token: 0x040013AA RID: 5034
			public Vector2 Start;

			// Token: 0x040013AB RID: 5035
			public Vector2 End;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000297 RID: 663
	public class RelicSelectUI : UIBase
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x000A44C4 File Offset: 0x000A26C4
		public Transform List1
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
				methodContext.TargetType = typeof(RelicSelectUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(RelicSelectUI.get_List1()).MethodHandle, typeof(RelicSelectUI).TypeHandle);
				methodContext.Arguments = new object[0];
				Transform transform;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						transform = (Transform)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								transform = this.$Rougamo_get_List1();
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
									transform = (Transform)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = transform;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							transform = (Transform)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return transform;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x000A4604 File Offset: 0x000A2804
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
				methodContext.TargetType = typeof(RelicSelectUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(RelicSelectUI.get_roleTable()).MethodHandle, typeof(RelicSelectUI).TypeHandle);
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

		// Token: 0x060014D3 RID: 5331 RVA: 0x000A4744 File Offset: 0x000A2944
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
			methodContext.TargetType = typeof(RelicSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(RelicSelectUI.Awake()).MethodHandle, typeof(RelicSelectUI).TypeHandle);
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

		// Token: 0x060014D4 RID: 5332 RVA: 0x000A4840 File Offset: 0x000A2A40
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
			methodContext.TargetType = typeof(RelicSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(RelicSelectUI.Init()).MethodHandle, typeof(RelicSelectUI).TypeHandle);
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

		// Token: 0x060014D5 RID: 5333 RVA: 0x000A493C File Offset: 0x000A2B3C
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
			methodContext.TargetType = typeof(RelicSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(RelicSelectUI.OnEnable()).MethodHandle, typeof(RelicSelectUI).TypeHandle);
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

		// Token: 0x060014D6 RID: 5334 RVA: 0x000A4A38 File Offset: 0x000A2C38
		[DebuggerStepThrough]
		protected void ShowMsg()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(RelicSelectUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(RelicSelectUI.ShowMsg()).MethodHandle, typeof(RelicSelectUI).TypeHandle);
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
							this.$Rougamo_ShowMsg();
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

		// Token: 0x060014D7 RID: 5335 RVA: 0x000A4B34 File Offset: 0x000A2D34
		private void CreatePossessedRelic()
		{
			UIManager.Instance.GetUI<TopBarUI>("TopBarUI").relicSelectUI = this;
			UIManager.Instance.GetUI<TopBarUI>("TopBarUI").UpdateRelics();
			this.ignoreSet.Clear();
			this.relicList = new List<DataConfig>(RoleTable.Instance.WithoutArmedRelicList);
			GameObject nullItemPrefab = this.List2.Find("NullPrefab").gameObject;
			foreach (object obj in this.List2)
			{
				Transform item = (Transform)obj;
				bool flag = item.name == "NullPrefab" || item.name == "Item0";
				if (!flag)
				{
					bool flag2 = item.name == "Null";
					if (flag2)
					{
						Singleton<ObjectPool>.Instance.Release(item.gameObject);
					}
					else
					{
						DataConfig dataConfig = item.GetComponent<RelicItemConfig>().dataConfig;
						bool flag3 = this.unRelicset.Contains(dataConfig);
						if (flag3)
						{
							this.ignoreSet.Add(dataConfig);
						}
						else
						{
							Singleton<ObjectPool>.Instance.Release(item.gameObject);
						}
					}
				}
			}
			for (int i = 0; i < this.unRelicset.Count; i++)
			{
				bool flag4 = this.ignoreSet.Contains(this.relicList[i]);
				if (!flag4)
				{
					GameObject relicItem = Singleton<ObjectPool>.Instance.Get(this.UnArmeditem, this.List2.transform);
					DataConfig dataConfig2 = this.relicList[i];
					RelicItemConfig relicItemConfig = relicItem.GetComponent<RelicItemConfig>();
					relicItemConfig.relicSelectUI = this;
					relicItemConfig.Init(dataConfig2);
					relicItemConfig.ifEquipped = false;
					relicItem.name = dataConfig2.data.Localize("Name");
					relicItem.SetActive(true);
				}
			}
			foreach (object obj2 in this.List1)
			{
				Transform item2 = (Transform)obj2;
				bool flag5 = item2.name == "NullPrefab" || item2.name == "Item0" || item2.name == "Null";
				if (!flag5)
				{
					item2.GetComponent<RelicItemConfig>().relicSelectUI = this;
				}
			}
			for (int j = 0; j < 6; j++)
			{
				GameObject relicItem2 = Singleton<ObjectPool>.Instance.Get(nullItemPrefab, this.List2.transform);
				relicItem2.name = "Null";
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000A4E34 File Offset: 0x000A3034
		private Transform $Rougamo_get_List1()
		{
			return UIManager.Instance.GetUI<TopBarUI>("TopBarUI").RelicList;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000A4E4A File Offset: 0x000A304A
		private RoleTable $Rougamo_get_roleTable()
		{
			return RoleTable.Instance;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000A4E51 File Offset: 0x000A3051
		private void $Rougamo_Awake()
		{
			this.Init();
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000A4E5B File Offset: 0x000A305B
		private void $Rougamo_Init()
		{
			this.List2 = base.transform.Find("Content/PossessedContent/List View Custom/Scroll Area/List");
			this.UnArmeditem = this.List2.transform.Find("Item0").gameObject;
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000A4E94 File Offset: 0x000A3094
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.ShowMsg();
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000A4EA5 File Offset: 0x000A30A5
		private void $Rougamo_ShowMsg()
		{
			this.unRelicset = new HashSet<DataConfig>(this.roleTable.WithoutArmedRelicList);
			this.CreatePossessedRelic();
		}

		// Token: 0x040010AF RID: 4271
		public Transform List2;

		// Token: 0x040010B0 RID: 4272
		public GameObject UnArmeditem;

		// Token: 0x040010B1 RID: 4273
		public List<DataConfig> relicList;

		// Token: 0x040010B2 RID: 4274
		private HashSet<DataConfig> unRelicset;

		// Token: 0x040010B3 RID: 4275
		private HashSet<DataConfig> ignoreSet = new HashSet<DataConfig>();
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000350 RID: 848
	public class OutsiderShopUI : ShopUI
	{
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x000E0510 File Offset: 0x000DE710
		private GameRuntimeData gameRuntimeData
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
				methodContext.TargetType = typeof(OutsiderShopUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.get_gameRuntimeData()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
				methodContext.Arguments = new object[0];
				GameRuntimeData gameRuntimeData;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								gameRuntimeData = this.$Rougamo_get_gameRuntimeData();
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
									gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = gameRuntimeData;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							gameRuntimeData = (GameRuntimeData)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return gameRuntimeData;
			}
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000E0650 File Offset: 0x000DE850
		[DebuggerStepThrough]
		public void Awake()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.Awake()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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

		// Token: 0x06001A78 RID: 6776 RVA: 0x000E074C File Offset: 0x000DE94C
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
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.Start()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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

		// Token: 0x06001A79 RID: 6777 RVA: 0x000E0848 File Offset: 0x000DEA48
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
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.DataUpdate()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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

		// Token: 0x06001A7A RID: 6778 RVA: 0x000E0944 File Offset: 0x000DEB44
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
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.Init()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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

		// Token: 0x06001A7B RID: 6779 RVA: 0x000E0A40 File Offset: 0x000DEC40
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
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.Hide()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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

		// Token: 0x06001A7C RID: 6780 RVA: 0x000E0B3C File Offset: 0x000DED3C
		[DebuggerStepThrough]
		private void Update()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.Update()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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
							this.$Rougamo_Update();
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

		// Token: 0x06001A7D RID: 6781 RVA: 0x000E0C38 File Offset: 0x000DEE38
		[DebuggerStepThrough]
		public void SetCurrentItem(OutsideShopItem item)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.SetCurrentItem(OutsideShopItem)).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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
							item = (OutsideShopItem)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetCurrentItem(item);
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

		// Token: 0x06001A7E RID: 6782 RVA: 0x000E0D6C File Offset: 0x000DEF6C
		[DebuggerStepThrough]
		private void ChangeStarShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.ChangeStarShow()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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
							this.$Rougamo_ChangeStarShow();
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

		// Token: 0x06001A7F RID: 6783 RVA: 0x000E0E68 File Offset: 0x000DF068
		[DebuggerStepThrough]
		private void ShowAnimatedIcon(Transform iconTransform, float animationPerFrame, string path)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.ShowAnimatedIcon(Transform, float, string)).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				iconTransform,
				animationPerFrame,
				path
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
							iconTransform = null;
						}
						else
						{
							iconTransform = (Transform)arguments[0];
						}
						if (arguments[1] == null)
						{
							animationPerFrame = 0f;
						}
						else
						{
							animationPerFrame = (float)arguments[1];
						}
						if (arguments[2] == null)
						{
							path = null;
						}
						else
						{
							path = (string)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowAnimatedIcon(iconTransform, animationPerFrame, path);
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

		// Token: 0x06001A80 RID: 6784 RVA: 0x000E0FE4 File Offset: 0x000DF1E4
		[DebuggerStepThrough]
		private void ChangeCostShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.ChangeCostShow()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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
							this.$Rougamo_ChangeCostShow();
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

		// Token: 0x06001A81 RID: 6785 RVA: 0x000E10E0 File Offset: 0x000DF2E0
		private void SetDescription()
		{
			bool flag = this.thiscurrentItem != null;
			if (flag)
			{
				OutsideShopItem item = this.thiscurrentItem;
				base.transform.Find("Content/描述/Content/name/text").GetComponent<TextMeshProUGUI>().text = item.itemName;
				base.transform.Find("Content/描述/Content/description/description").GetComponent<TextMeshProUGUI>().text = item.itemDescription;
				foreach (Transform fadeTransform in this.fadeTransforms)
				{
					fadeTransform.GetComponent<CanvasGroup>().DOKill(false);
					fadeTransform.GetComponent<CanvasGroup>().alpha = 0f;
					fadeTransform.GetComponent<CanvasGroup>().DOFade(1f, this.transitionTime).SetEase(Ease.OutQuad);
				}
				this.ChangeCostShow();
				this.ChangeStarShow();
				for (int i = 1; i < 4; i++)
				{
					bool flag2 = item.dataConfig.data["Tag" + i.ToString()] != "";
					if (flag2)
					{
						Transform tempTran = base.transform.Find("Content/描述/Content/tags/Item" + i.ToString());
						tempTran.gameObject.SetActive(true);
						string main;
						string des;
						this.ResolveDescription(item.dataConfig.data["Tag" + i.ToString()], out main, out des);
						List<string> keyWords = new List<string>();
						tempTran.Find("text").GetComponent<TextMeshProUGUI>().text = main;
						des = des.Highlight(keyWords);
						tempTran.GetComponent<KeywordDisplay>().SetText(main, des, keyWords, null, null, null);
					}
					else
					{
						base.transform.Find("Content/描述/Content/tags/Item" + i.ToString()).gameObject.SetActive(false);
					}
				}
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000E12F4 File Offset: 0x000DF4F4
		[DebuggerStepThrough]
		private unsafe void ResolveDescription(string description, out string main, out string des)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.ResolveDescription(string, string*, string*)).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				description,
				main,
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
							main = null;
						}
						else
						{
							main = (string)arguments[1];
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
							this.$Rougamo_ResolveDescription(description, out main, out des);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							object[] arguments2 = methodContext.Arguments;
							arguments2[1] = main;
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
						arguments3[1] = main;
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

		// Token: 0x06001A83 RID: 6787 RVA: 0x000E1488 File Offset: 0x000DF688
		[DebuggerStepThrough]
		public override void SetShopItems()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.SetShopItems()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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
							this.$Rougamo_SetShopItems();
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

		// Token: 0x06001A84 RID: 6788 RVA: 0x000E1584 File Offset: 0x000DF784
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
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.OnEnable()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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

		// Token: 0x06001A85 RID: 6789 RVA: 0x000E1680 File Offset: 0x000DF880
		[DebuggerStepThrough]
		public void TryBuy()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.TryBuy()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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
							this.$Rougamo_TryBuy();
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

		// Token: 0x06001A86 RID: 6790 RVA: 0x000E177C File Offset: 0x000DF97C
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
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.ChangeTrue()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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

		// Token: 0x06001A87 RID: 6791 RVA: 0x000E1878 File Offset: 0x000DFA78
		public override void UpdateAllItems()
		{
			this.ChangeCostShow();
			foreach (OutsideShopItem item in this.TotalItems)
			{
				item.UpdateItem();
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x000E18D8 File Offset: 0x000DFAD8
		public void UpdateItemDes()
		{
			foreach (OutsideShopItem item in this.TotalItems)
			{
				item.DataUpdate();
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000E1930 File Offset: 0x000DFB30
		[DebuggerStepThrough]
		public void TriggerCalled()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.TriggerCalled()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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
							this.$Rougamo_TriggerCalled();
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

		// Token: 0x06001A8A RID: 6794 RVA: 0x000E1A2C File Offset: 0x000DFC2C
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
			methodContext.TargetType = typeof(OutsiderShopUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutsiderShopUI.OnDisable()).MethodHandle, typeof(OutsiderShopUI).TypeHandle);
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

		// Token: 0x06001A8C RID: 6796 RVA: 0x0001CB6E File Offset: 0x0001AD6E
		private GameRuntimeData $Rougamo_get_gameRuntimeData()
		{
			return Singleton<GameRuntimeData>.Instance;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000E1BE6 File Offset: 0x000DFDE6
		private void $Rougamo_Awake()
		{
			this.anim = base.GetComponent<Animator>();
			this.SetDescription();
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_Start()
		{
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000E1BFC File Offset: 0x000DFDFC
		private void $Rougamo_DataUpdate()
		{
			this.UpdateItemDes();
			this.SetDescription();
			base.transform.Find("Title/Text").GetComponent<TMP_Text>().text = "Statue blessings".Localize("ShopUI");
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x000E1C38 File Offset: 0x000DFE38
		private void $Rougamo_Init()
		{
			base.transform.Find("Title/Text").GetComponent<TMP_Text>().text = "Statue blessings".Localize("ShopUI");
			this.ChangeTrue();
			this.SetShopItems();
			base.gameObject.SetActive(false);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000E1C8B File Offset: 0x000DFE8B
		private void $Rougamo_Hide()
		{
			this.anim.SetTrigger("isClosed");
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000E1CA0 File Offset: 0x000DFEA0
		private void $Rougamo_Update()
		{
			bool flag = this.triggerCalled;
			if (flag)
			{
				this.triggerCalled = false;
				base.gameObject.SetActive(false);
				this.gameRuntimeData.Save();
			}
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000E1CDA File Offset: 0x000DFEDA
		private void $Rougamo_SetCurrentItem(OutsideShopItem item)
		{
			this.thiscurrentItem = item;
			this.SetDescription();
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x000E1CEC File Offset: 0x000DFEEC
		private void $Rougamo_ChangeStarShow()
		{
			Transform IconParent = base.transform.Find("Content/描述/Content/Icon");
			Transform LevelParent = base.transform.Find("Content/描述/Content/Level/5Level");
			bool showIcon = this.thiscurrentItem.dataConfig.data["BuyCount"] == "1";
			LevelParent.gameObject.SetActive(!showIcon);
			IconParent.gameObject.SetActive(showIcon);
			bool flag = showIcon;
			if (flag)
			{
				bool flag2 = this.thiscurrentItem.dataConfig.data["Type"] == "career";
				if (flag2)
				{
					string id = this.thiscurrentItem.dataConfig.data["Toid"];
					string path;
					Singleton<GameConfigManager>.Instance.GetOne(DataType.Career, id).TryGetValue("Animation", out path);
					IRole.AnimationConfig config = IRole.TryGetAnimationConfig(path, IStatusManager.AnimatedState.Idle);
					this.ShowAnimatedIcon(IconParent, config.AnimationPerFrame, path + "/Idle");
				}
				else
				{
					this.ShowAnimatedIcon(IconParent, 1f, this.thiscurrentItem.dataConfig.data["Icon"]);
				}
			}
			else
			{
				bool flag3 = Singleton<GameRuntimeData>.Instance.BuyedItems.GetValueOrDefault(this.thiscurrentItem.itemId, 0) != 0;
				if (flag3)
				{
					int buyedCount = (this.thiscurrentItem.dataConfig.data["BuyCount"] == "1") ? 5 : Singleton<GameRuntimeData>.Instance.BuyedItems[this.thiscurrentItem.itemId];
					for (int i = 0; i < 5; i++)
					{
						bool flag4 = i < buyedCount;
						if (flag4)
						{
							LevelParent.GetChild(i + 1).Find("已升级").GetComponent<CanvasGroup>().alpha = 1f;
							LevelParent.GetChild(i + 1).Find("未升级").GetComponent<CanvasGroup>().alpha = 0f;
						}
						else
						{
							LevelParent.GetChild(i + 1).Find("已升级").GetComponent<CanvasGroup>().alpha = 0f;
							LevelParent.GetChild(i + 1).Find("未升级").GetComponent<CanvasGroup>().alpha = 1f;
						}
					}
				}
				else
				{
					for (int j = 0; j < 5; j++)
					{
						LevelParent.GetChild(j + 1).Find("已升级").GetComponent<CanvasGroup>().alpha = 0f;
						LevelParent.GetChild(j + 1).Find("未升级").GetComponent<CanvasGroup>().alpha = 1f;
					}
				}
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000E1FB4 File Offset: 0x000E01B4
		private void $Rougamo_ShowAnimatedIcon(Transform iconTransform, float animationPerFrame, string path)
		{
			UIAnimation role = iconTransform.Find("Icon").GetComponent<UIAnimation>();
			role.Stop();
			role.SpriteFrames = ResourceLoader.LoadAll<Sprite>(path).OrderBy((Sprite x) => x.name, new NaturalStringComparer()).ToList<Sprite>();
			role.FrameDurations = null;
			role.FPS = 1f / animationPerFrame;
			bool flag = role.SpriteFrames.Count > 1;
			if (flag)
			{
				role.Play();
			}
			else
			{
				bool flag2 = role.SpriteFrames.Count == 1;
				if (flag2)
				{
					role.SetSprite(0);
				}
			}
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000E2064 File Offset: 0x000E0264
		private void $Rougamo_ChangeCostShow()
		{
			bool flag = Singleton<GameRuntimeData>.Instance.BuyedItems.GetValueOrDefault(this.thiscurrentItem.itemId, 0) < int.Parse(this.thiscurrentItem.dataConfig.data["BuyCount"]);
			if (flag)
			{
				base.transform.Find("Content/描述/Content/Buy").GetComponent<ButtonManager>().SetText("Buy Item".Localize("ShopUI") + ": " + this.thiscurrentItem.itemPrice.ToString());
			}
			else
			{
				bool flag2 = this.thiscurrentItem.dataConfig.data["BuyCount"] == "1";
				if (flag2)
				{
					base.transform.Find("Content/描述/Content/Buy").GetComponent<ButtonManager>().SetText("Unlocked".Localize("ShopUI"));
				}
				else
				{
					base.transform.Find("Content/描述/Content/Buy").GetComponent<ButtonManager>().SetText("Max Level Reached".Localize("ShopUI"));
				}
			}
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x000E2180 File Offset: 0x000E0380
		private void $Rougamo_ResolveDescription(string description, out string main, out string des)
		{
			des = "";
			string mainPattern = "<main>(.*?)<\\/main>";
			string desPattern = "<des>(.*?)<\\/des>";
			Match mainMatch = Regex.Match(description, mainPattern, RegexOptions.Singleline);
			Match desMatch = Regex.Match(description, desPattern, RegexOptions.Singleline);
			bool success = mainMatch.Success;
			if (success)
			{
				main = mainMatch.Groups[1].Value;
			}
			else
			{
				Debug.LogError("EventUI: ResolveDescription failed to find <main> tag in description.");
				main = description;
			}
			bool success2 = desMatch.Success;
			if (success2)
			{
				des = desMatch.Groups[1].Value;
			}
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x000E220C File Offset: 0x000E040C
		private void $Rougamo_SetShopItems()
		{
			this.ShopItems = Singleton<GameConfigManager>.Instance.GetTable(DataType.BuyItems).Getlines();
			int totalCount = this.ShopItems.Count;
			GameObject itemPrefab = base.transform.Find("Content/商店/Content/List View Custom/Scroll Area/List/Item").gameObject;
			for (int i = 0; i < totalCount; i++)
			{
				GameObject item = UnityEngine.Object.Instantiate<GameObject>(itemPrefab, itemPrefab.transform.parent);
				item.SetActive(true);
				item.GetComponent<OutsideShopItem>().dataConfig = new DataConfig(this.ShopItems[i]["Id"], DataType.BuyItems);
				item.GetComponent<OutsideShopItem>().theData = this.ShopItems[i];
				item.GetComponent<OutsideShopItem>().outsiderShopUI = this;
				item.GetComponent<OutsideShopItem>().Init();
				this.TotalItems.Add(item.GetComponent<OutsideShopItem>());
			}
			bool flag = this.TotalItems.Count > 0;
			if (flag)
			{
				this.SetCurrentItem(this.TotalItems[0]);
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000E2319 File Offset: 0x000E0519
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.ChangeTrue();
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000E232C File Offset: 0x000E052C
		private void $Rougamo_TryBuy()
		{
			bool flag = Singleton<GameRuntimeData>.Instance.Truth > this.thiscurrentItem.itemPrice && Singleton<GameRuntimeData>.Instance.BuyedItems.GetValueOrDefault(this.thiscurrentItem.itemId, 0) < int.Parse(this.thiscurrentItem.dataConfig.data["BuyCount"]);
			if (flag)
			{
				Singleton<GameRuntimeData>.Instance.Truth -= this.thiscurrentItem.itemPrice;
				this.ChangeTrue();
				this.thiscurrentItem.TryBuy();
				this.ChangeStarShow();
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000E23E0 File Offset: 0x000E05E0
		private void $Rougamo_ChangeTrue()
		{
			base.transform.Find("Content/描述/Content/Truth/val").GetComponent<TextMeshProUGUI>().text = this.gameRuntimeData.Truth.ToString();
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x000E2422 File Offset: 0x000E0622
		private void $Rougamo_TriggerCalled()
		{
			this.triggerCalled = true;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x000B7707 File Offset: 0x000B5907
		private void $Rougamo_OnDisable()
		{
			base.OnDisable();
			HouseUI.CanScroll = true;
		}

		// Token: 0x04001469 RID: 5225
		public OutsideShopItem thiscurrentItem;

		// Token: 0x0400146A RID: 5226
		private List<OutsideShopItem> TotalItems = new List<OutsideShopItem>();

		// Token: 0x0400146B RID: 5227
		public List<Transform> fadeTransforms = new List<Transform>();

		// Token: 0x0400146C RID: 5228
		public float transitionTime;

		// Token: 0x0400146D RID: 5229
		private Animator anim;

		// Token: 0x0400146E RID: 5230
		private bool triggerCalled = false;

		// Token: 0x0400146F RID: 5231
		public Dictionary<string, string> TypeMap = new Dictionary<string, string>
		{
			{
				"Card",
				"卡牌"
			},
			{
				"Relic",
				"遗物"
			},
			{
				"Item",
				"物品"
			},
			{
				"Blessing",
				"祝福"
			},
			{
				"Career",
				"角色"
			},
			{
				"EX",
				"超凡"
			},
			{
				"Var",
				"属性物品"
			}
		};

		// Token: 0x04001470 RID: 5232
		public List<Dictionary<string, string>> ShopItems = new List<Dictionary<string, string>>();
	}
}

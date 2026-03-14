using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000333 RID: 819
	public class ItemShowUI : UIBase
	{
		// Token: 0x060019C5 RID: 6597 RVA: 0x000D9C1C File Offset: 0x000D7E1C
		[DebuggerStepThrough]
		public void ShowItem(DataConfig dataConfig)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ItemShowUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ItemShowUI.ShowItem(DataConfig)).MethodHandle, typeof(ItemShowUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				dataConfig
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
					}
					do
					{
						try
						{
							this.$Rougamo_ShowItem(dataConfig);
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

		// Token: 0x060019C6 RID: 6598 RVA: 0x000D9D50 File Offset: 0x000D7F50
		[DebuggerStepThrough]
		public void ShowItem(Sprite icon, string title, string description, string tips = null)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(ItemShowUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ItemShowUI.ShowItem(Sprite, string, string, string)).MethodHandle, typeof(ItemShowUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				icon,
				title,
				description,
				tips
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
							icon = null;
						}
						else
						{
							icon = (Sprite)arguments[0];
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
							description = null;
						}
						else
						{
							description = (string)arguments[2];
						}
						if (arguments[3] == null)
						{
							tips = null;
						}
						else
						{
							tips = (string)arguments[3];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowItem(icon, title, description, tips);
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
								goto IL_162;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_162:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x000D9EE8 File Offset: 0x000D80E8
		private void $Rougamo_ShowItem(DataConfig dataConfig)
		{
			Item item = base.transform.Find("Content/Item").gameObject.AddComponent<Item>();
			item.Init(dataConfig);
			this.ShowItem(item.itemIcon, item.name, item.itemDescription, item.itemTip);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000D9F38 File Offset: 0x000D8138
		private void $Rougamo_ShowItem(Sprite icon, string title, string description, [Optional] string tips)
		{
			base.transform.Find("Content/Item/Icon").GetComponent<Image>().sprite = icon;
			base.transform.Find("Content/Item/Name").GetComponent<TMP_Text>().text = title;
			base.transform.Find("Content/Item/Description").GetComponent<TMP_Text>().text = description;
			bool flag = tips == null;
			if (flag)
			{
				base.transform.Find("Content/Item/Tip").GetComponent<TMP_Text>().text = "";
			}
			else
			{
				base.transform.Find("Content/Item/Tip").GetComponent<TMP_Text>().text = tips;
			}
		}
	}
}

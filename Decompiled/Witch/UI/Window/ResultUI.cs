using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000352 RID: 850
	public class ResultUI : UIBase
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x000E2440 File Offset: 0x000E0640
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
			methodContext.TargetType = typeof(ResultUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ResultUI.Start()).MethodHandle, typeof(ResultUI).TypeHandle);
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

		// Token: 0x06001AA2 RID: 6818 RVA: 0x000E253C File Offset: 0x000E073C
		public void CreateResultItem(List<DataConfig> datas)
		{
			this.GetItemList = base.transform.Find("Result/List");
			foreach (object obj in this.GetItemList)
			{
				Transform item = (Transform)obj;
				bool flag = item.name == "Item";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			foreach (DataConfig item2 in datas)
			{
				DataConfig dataConfig = item2;
				Transform TempTran = Singleton<ObjectPool>.Instance.Get(this.GetItemList.Find("Item").gameObject, this.GetItemList).transform;
				TempTran.gameObject.SetActive(true);
				TempTran.transform.Find("Normal/rarity").GetComponent<Image>().color = Singleton<TempDataManager>.Instance.rareColorMap[dataConfig.data["Rarity"]];
				TempTran.transform.Find("Highlight/rarity").GetComponent<Image>().color = Singleton<TempDataManager>.Instance.rareColorMap[dataConfig.data["Rarity"]];
				ResultItem ResultItem = TempTran.GetComponent<ResultItem>() ?? TempTran.gameObject.AddComponent<ResultItem>();
				ResultItem.Init(dataConfig);
				ResultItem.canright = false;
				ResultItem.KeyworsDis();
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x000E2714 File Offset: 0x000E0914
		private void $Rougamo_Start()
		{
			this.GetItemList = base.transform.Find("Result/List");
		}

		// Token: 0x04001473 RID: 5235
		public Transform GetItemList;
	}
}

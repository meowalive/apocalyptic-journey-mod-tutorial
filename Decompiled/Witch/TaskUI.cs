using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using Witch.UI;

namespace Witch
{
	// Token: 0x0200025D RID: 605
	public class TaskUI : UIBase
	{
		// Token: 0x06001366 RID: 4966 RVA: 0x00098398 File Offset: 0x00096598
		private void Awake()
		{
			List<Dictionary<string, string>> taskLines = Singleton<GameConfigManager>.Instance.GetTable(DataType.Task).Getlines();
			foreach (Dictionary<string, string> line in taskLines)
			{
				string taskType = line["Belong"];
				bool flag = !this.taskDict.ContainsKey(taskType);
				if (flag)
				{
					this.taskDict[taskType] = new List<DataConfig>();
				}
				this.taskDict[taskType].Add(new DataConfig(line["Id"], DataType.Task));
				bool flag2 = !Singleton<GameRuntimeData>.Instance.Gain.ContainsKey(line["Id"]);
				if (flag2)
				{
					Singleton<GameRuntimeData>.Instance.Gain[line["Id"]] = 0;
				}
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00098498 File Offset: 0x00096698
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
			methodContext.TargetType = typeof(TaskUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TaskUI.OnEnable()).MethodHandle, typeof(TaskUI).TypeHandle);
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

		// Token: 0x06001368 RID: 4968 RVA: 0x00098594 File Offset: 0x00096794
		public void Init()
		{
			Transform contentTransform = base.transform.Find("Left/Scroll/TypeList");
			contentTransform.Find("TypePre").gameObject.SetActive(true);
			foreach (object obj in contentTransform)
			{
				Transform item = (Transform)obj;
				bool flag = item.name == "TypePre";
				if (!flag)
				{
					foreach (object obj2 in item.Find("TaskList"))
					{
						Transform tempitem = (Transform)obj2;
						bool flag2 = tempitem.name == "TaskPre";
						if (!flag2)
						{
							Singleton<ObjectPool>.Instance.Release(tempitem.gameObject);
						}
					}
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			foreach (KeyValuePair<string, List<DataConfig>> item2 in this.taskDict)
			{
				List<DataConfig> DoneList = new List<DataConfig>(from t in item2.Value
				where Singleton<GameRuntimeData>.Instance.Gain[t.data["Id"]] >= int.Parse(t.data["Target"])
				select t);
				List<DataConfig> UnDoneList = new List<DataConfig>(from t in item2.Value
				where Singleton<GameRuntimeData>.Instance.Gain[t.data["Id"]] != -999 && Singleton<GameRuntimeData>.Instance.Gain[t.data["Id"]] < int.Parse(t.data["Target"])
				select t);
				List<DataConfig> WaitList = new List<DataConfig>(from t in item2.Value
				where Singleton<GameRuntimeData>.Instance.Gain[t.data["Id"]] == -999
				select t);
				Transform TypeItem = Singleton<ObjectPool>.Instance.Get(contentTransform.Find("TypePre").gameObject, contentTransform).transform;
				TypeItem.GetComponent<TypeItem>().TypeName = item2.Key;
				TypeItem.GetComponent<TypeItem>().IsOpen = true;
				TypeItem.transform.Find("TaskList").gameObject.SetActive(true);
				TypeItem.Find("TaskList/TaskPre").gameObject.SetActive(true);
				foreach (DataConfig tempData in DoneList)
				{
					Transform tempItem = Singleton<ObjectPool>.Instance.Get(TypeItem.Find("TaskList/TaskPre").gameObject, TypeItem.Find("TaskList")).transform;
					tempItem.GetComponent<TaskItem>().taskUI = this;
					tempItem.GetComponent<TaskItem>().Init(tempData);
				}
				foreach (DataConfig tempData2 in UnDoneList)
				{
					Transform tempItem2 = Singleton<ObjectPool>.Instance.Get(TypeItem.Find("TaskList/TaskPre").gameObject, TypeItem.Find("TaskList")).transform;
					tempItem2.GetComponent<TaskItem>().taskUI = this;
					tempItem2.GetComponent<TaskItem>().Init(tempData2);
				}
				foreach (DataConfig tempData3 in WaitList)
				{
					Transform tempItem3 = Singleton<ObjectPool>.Instance.Get(TypeItem.Find("TaskList/TaskPre").gameObject, TypeItem.Find("TaskList")).transform;
					tempItem3.GetComponent<TaskItem>().taskUI = this;
					tempItem3.GetComponent<TaskItem>().Init(tempData3);
				}
				bool flag3 = DoneList.Count > 0;
				if (flag3)
				{
					this.ShowTaskDetail(DoneList[0]);
				}
				else
				{
					bool flag4 = UnDoneList.Count > 0;
					if (flag4)
					{
						this.ShowTaskDetail(UnDoneList[0]);
					}
					else
					{
						this.ShowTaskDetail(WaitList[0]);
					}
				}
				TypeItem.Find("TaskList/TaskPre").gameObject.SetActive(false);
			}
			contentTransform.Find("TypePre").gameObject.SetActive(false);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00098A78 File Offset: 0x00096C78
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
			methodContext.TargetType = typeof(TaskUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TaskUI.DataUpdate()).MethodHandle, typeof(TaskUI).TypeHandle);
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

		// Token: 0x0600136A RID: 4970 RVA: 0x00098B74 File Offset: 0x00096D74
		[DebuggerStepThrough]
		public void ShowTaskDetail(DataConfig dataConfig)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TaskUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TaskUI.ShowTaskDetail(DataConfig)).MethodHandle, typeof(TaskUI).TypeHandle);
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
							this.$Rougamo_ShowTaskDetail(dataConfig);
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

		// Token: 0x0600136B RID: 4971 RVA: 0x00098CA8 File Offset: 0x00096EA8
		[DebuggerStepThrough]
		public void ClaimReward()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(TaskUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TaskUI.ClaimReward()).MethodHandle, typeof(TaskUI).TypeHandle);
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
							this.$Rougamo_ClaimReward();
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

		// Token: 0x0600136D RID: 4973 RVA: 0x00098DC6 File Offset: 0x00096FC6
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.Init();
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00098DD8 File Offset: 0x00096FD8
		private void $Rougamo_DataUpdate()
		{
			base.transform.Find("Left/Title/Text").GetComponent<TMP_Text>().text = "Field work".Localize("TaskUI");
			base.transform.Find("Right/Title/Way/Text").GetComponent<TMP_Text>().text = "Completion conditions".Localize("TaskUI");
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00098E3C File Offset: 0x0009703C
		private void $Rougamo_ShowTaskDetail(DataConfig dataConfig)
		{
			this.NowDataConfig = dataConfig;
			base.transform.Find("Right/Title/Name/Text").GetComponent<TMP_Text>().text = dataConfig.data.Localize("Name");
			base.transform.Find("Right/Title/Way/Way").GetComponent<TMP_Text>().text = dataConfig.data.Localize("NeedDes");
			base.transform.Find("Right/Des/Text").GetComponent<TMP_Text>().text = dataConfig.data.Localize("Des");
			base.transform.Find("Right/Reward/Reward/Text").GetComponent<TMP_Text>().text = dataConfig.data.Localize("Reward");
			bool flag = Singleton<GameRuntimeData>.Instance.Gain[dataConfig.data["Id"]] >= int.Parse(dataConfig.data["Target"]);
			if (flag)
			{
				base.transform.Find("Right/Reward/Button").GetComponent<ButtonManager>().Interactable(true);
				base.transform.Find("Right/Reward/Button").GetComponent<ButtonManager>().SetText("Receive".Localize("TaskUI"));
			}
			else
			{
				bool flag2 = Singleton<GameRuntimeData>.Instance.Gain[dataConfig.data["Id"]] == -999;
				if (flag2)
				{
					base.transform.Find("Right/Reward/Button").GetComponent<ButtonManager>().Interactable(false);
					base.transform.Find("Right/Reward/Button").GetComponent<ButtonManager>().SetText("Received".Localize("TaskUI"));
				}
				else
				{
					base.transform.Find("Right/Reward/Button").GetComponent<ButtonManager>().Interactable(false);
					base.transform.Find("Right/Reward/Button").GetComponent<ButtonManager>().SetText(Singleton<GameRuntimeData>.Instance.Gain[dataConfig.data["Id"]].ToString() + "/" + dataConfig.data["Target"]);
				}
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00099078 File Offset: 0x00097278
		private void $Rougamo_ClaimReward()
		{
			bool flag = Singleton<GameRuntimeData>.Instance.Gain[this.NowDataConfig.data["Id"]] >= int.Parse(this.NowDataConfig.data["Target"]);
			if (flag)
			{
				Singleton<GameRuntimeData>.Instance.Gain[this.NowDataConfig.data["Id"]] = -999;
				Singleton<GameRuntimeData>.Instance.Truth += int.Parse(this.NowDataConfig.data["Reward"]);
				base.transform.Find("Right/Reward/Button").GetComponent<ButtonManager>().Interactable(false);
				base.transform.Find("Right/Reward/Button").GetComponent<ButtonManager>().SetText("Received".Localize("TaskUI"));
			}
		}

		// Token: 0x04000FBB RID: 4027
		private Dictionary<string, List<DataConfig>> taskDict = new Dictionary<string, List<DataConfig>>();

		// Token: 0x04000FBC RID: 4028
		public bool firstShow = true;

		// Token: 0x04000FBD RID: 4029
		private DataConfig NowDataConfig = null;
	}
}

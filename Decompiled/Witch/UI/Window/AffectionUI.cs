using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000290 RID: 656
	public class AffectionUI : UIBase
	{
		// Token: 0x0600149E RID: 5278 RVA: 0x000A2290 File Offset: 0x000A0490
		private void Awake()
		{
			List<Dictionary<string, string>> affectionLines = Singleton<GameConfigManager>.Instance.GetTable(DataType.Affection).Getlines();
			foreach (Dictionary<string, string> line in affectionLines)
			{
				string charName = line["Character"];
				bool flag = !this.affectionDict.ContainsKey(charName);
				if (flag)
				{
					this.affectionDict[charName] = new List<DataConfig>();
					bool flag2 = !Singleton<GameRuntimeData>.Instance.Gain.ContainsKey(line["Character"]);
					if (flag2)
					{
						Singleton<GameRuntimeData>.Instance.Gain[line["Character"]] = 0;
						Singleton<GameRuntimeData>.Instance.Gain[line["Character"] + "_AffectionPoint"] = 0;
					}
				}
				bool flag3 = !Singleton<GameRuntimeData>.Instance.Gain.ContainsKey(line["Id"]);
				if (flag3)
				{
					Singleton<GameRuntimeData>.Instance.Gain[line["Id"]] = 0;
				}
				this.affectionDict[charName].Add(new DataConfig(line["Id"], DataType.Affection));
			}
			this.NowCharacter = affectionLines[0]["Character"];
			this.RegisterEvent();
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000A2420 File Offset: 0x000A0620
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
			methodContext.TargetType = typeof(AffectionUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AffectionUI.OnEnable()).MethodHandle, typeof(AffectionUI).TypeHandle);
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

		// Token: 0x060014A0 RID: 5280 RVA: 0x000A251C File Offset: 0x000A071C
		[DebuggerStepThrough]
		public void AddReward(DataConfig dataConfig)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(AffectionUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(AffectionUI.AddReward(DataConfig)).MethodHandle, typeof(AffectionUI).TypeHandle);
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
							this.$Rougamo_AddReward(dataConfig);
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

		// Token: 0x060014A1 RID: 5281 RVA: 0x000A2650 File Offset: 0x000A0850
		public void ShowNowLevel()
		{
			Transform taskParent = base.transform.Find("Window Manager/Content/TaskList");
			foreach (object obj in taskParent)
			{
				Transform item = (Transform)obj;
				Singleton<ObjectPool>.Instance.Release(item.gameObject);
			}
			List<DataConfig> UnDoneList = new List<DataConfig>(from t in this.affectionDict[this.NowCharacter]
			where int.Parse(t.data["Belong"]) == Singleton<GameRuntimeData>.Instance.Gain[this.NowCharacter] && Singleton<GameRuntimeData>.Instance.Gain[t.data["Id"]] != -999
			select t);
			taskParent.Find("TaskPre").gameObject.SetActive(true);
			foreach (DataConfig item2 in UnDoneList)
			{
				Transform taskItem = Singleton<ObjectPool>.Instance.Get(taskParent.Find("TaskPre").gameObject, taskParent).transform;
				AffectionItem affectionItem = taskItem.GetComponent<AffectionItem>();
				affectionItem.affectionUI = this;
				affectionItem.Init(item2);
			}
			taskParent.Find("TaskPre").gameObject.SetActive(false);
			base.transform.Find("Window Manager/Content/Right/BigIcon/Text").GetComponent<TMP_Text>().text = "Lv." + Singleton<GameRuntimeData>.Instance.Gain[this.NowCharacter].ToString();
			base.transform.Find("Window Manager/Content/Right/BigIcon").SetSiblingIndex(Singleton<GameRuntimeData>.Instance.Gain[this.NowCharacter]);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x000A2891 File Offset: 0x000A0A91
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.ShowNowLevel();
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000A28A4 File Offset: 0x000A0AA4
		private void $Rougamo_AddReward(DataConfig dataConfig)
		{
			Singleton<GameRuntimeData>.Instance.Truth += int.Parse(dataConfig.data["Reward"]);
			Singleton<GameRuntimeData>.Instance.Gain[dataConfig.data["Id"]] = -999;
			Dictionary<string, int> gain = Singleton<GameRuntimeData>.Instance.Gain;
			string key = this.NowCharacter + "_AffectionPoint";
			gain[key]++;
			bool flag = Singleton<GameRuntimeData>.Instance.Gain[this.NowCharacter + "_AffectionPoint"] >= 4;
			if (flag)
			{
				Singleton<GameRuntimeData>.Instance.Gain[this.NowCharacter + "_AffectionPoint"] = 0;
				gain = Singleton<GameRuntimeData>.Instance.Gain;
				key = this.NowCharacter;
				gain[key]++;
				this.ShowNowLevel();
			}
		}

		// Token: 0x04001096 RID: 4246
		private Dictionary<string, List<DataConfig>> affectionDict = new Dictionary<string, List<DataConfig>>();

		// Token: 0x04001097 RID: 4247
		public bool firstShow = true;

		// Token: 0x04001098 RID: 4248
		private string NowCharacter = "";
	}
}

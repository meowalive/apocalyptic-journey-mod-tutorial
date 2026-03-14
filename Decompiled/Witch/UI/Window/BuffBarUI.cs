using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using Cysharp.Threading.Tasks;
using Fight.ActionCommand;
using Newtonsoft.Json;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x020002DF RID: 735
	public class BuffBarUI : UIBase
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x000BABE0 File Offset: 0x000B8DE0
		[JsonIgnore]
		public bool isDisplay
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
				methodContext.TargetType = typeof(BuffBarUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.get_isDisplay()).MethodHandle, typeof(BuffBarUI).TypeHandle);
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
								flag = this.$Rougamo_get_isDisplay();
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

		// Token: 0x060016D7 RID: 5847 RVA: 0x000BAD24 File Offset: 0x000B8F24
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
			methodContext.TargetType = typeof(BuffBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.Awake()).MethodHandle, typeof(BuffBarUI).TypeHandle);
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

		/// <summary>
		/// 呼叫服务器创建一个新buff对象
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="duration"></param>
		/// <param name="level"></param>
		// Token: 0x060016D8 RID: 5848 RVA: 0x000BAE20 File Offset: 0x000B9020
		[DebuggerStepThrough]
		public void CreateNewBuff(string buffId, int level)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BuffBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.CreateNewBuff(string, int)).MethodHandle, typeof(BuffBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				buffId,
				level
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
							buffId = null;
						}
						else
						{
							buffId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							level = 0;
						}
						else
						{
							level = (int)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateNewBuff(buffId, level);
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

		/// <summary>
		/// 根据BuffId删除同id的Buff
		/// </summary>
		/// <param name="buffId"></param>
		// Token: 0x060016D9 RID: 5849 RVA: 0x000BAF7C File Offset: 0x000B917C
		[DebuggerStepThrough]
		public BuffBarUI RemoveBuff(string buffId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BuffBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.RemoveBuff(string)).MethodHandle, typeof(BuffBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				buffId
			};
			BuffBarUI buffBarUI;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					buffBarUI = (BuffBarUI)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							buffId = null;
						}
						else
						{
							buffId = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							buffBarUI = this.$Rougamo_RemoveBuff(buffId);
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
								buffBarUI = (BuffBarUI)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_13B;
							}
							throw;
						}
						methodContext.ReturnValue = buffBarUI;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						buffBarUI = (BuffBarUI)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_13B:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return buffBarUI;
		}

		/// <summary>
		/// Add方式更新buff，持续时间直接增加，等级直接增加（多用于毒，等可叠层buff）
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="Duration"></param>
		/// <param name="level"></param>
		// Token: 0x060016DA RID: 5850 RVA: 0x000BB0EC File Offset: 0x000B92EC
		[DebuggerStepThrough]
		public BuffBarUI AddBuff(string buffId, int level)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BuffBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.AddBuff(string, int)).MethodHandle, typeof(BuffBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				buffId,
				level
			};
			BuffBarUI buffBarUI;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					buffBarUI = (BuffBarUI)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							buffId = null;
						}
						else
						{
							buffId = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							level = 0;
						}
						else
						{
							level = (int)arguments[1];
						}
					}
					do
					{
						try
						{
							buffBarUI = this.$Rougamo_AddBuff(buffId, level);
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
								buffBarUI = (BuffBarUI)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_165;
							}
							throw;
						}
						methodContext.ReturnValue = buffBarUI;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						buffBarUI = (BuffBarUI)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_165:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return buffBarUI;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x000BB2A0 File Offset: 0x000B94A0
		[DebuggerStepThrough]
		public BuffBarUI AddBuff(IBuffItemConfig buffConfig)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BuffBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.AddBuff(IBuffItemConfig)).MethodHandle, typeof(BuffBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				buffConfig
			};
			BuffBarUI buffBarUI;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					buffBarUI = (BuffBarUI)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							buffConfig = null;
						}
						else
						{
							buffConfig = (IBuffItemConfig)arguments[0];
						}
					}
					do
					{
						try
						{
							buffBarUI = this.$Rougamo_AddBuff(buffConfig);
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
								buffBarUI = (BuffBarUI)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_13B;
							}
							throw;
						}
						methodContext.ReturnValue = buffBarUI;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						buffBarUI = (BuffBarUI)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_13B:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return buffBarUI;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x000BB410 File Offset: 0x000B9610
		[DebuggerStepThrough]
		public BuffItem GetBuff(string buffId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BuffBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.GetBuff(string)).MethodHandle, typeof(BuffBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				buffId
			};
			BuffItem buffItem;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					buffItem = (BuffItem)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							buffId = null;
						}
						else
						{
							buffId = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							buffItem = this.$Rougamo_GetBuff(buffId);
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
								buffItem = (BuffItem)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_13B;
							}
							throw;
						}
						methodContext.ReturnValue = buffItem;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						buffItem = (BuffItem)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_13B:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return buffItem;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x000BB580 File Offset: 0x000B9780
		[DebuggerStepThrough]
		public BuffItem[] GetBuffs()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BuffBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.GetBuffs()).MethodHandle, typeof(BuffBarUI).TypeHandle);
			methodContext.Arguments = new object[0];
			BuffItem[] array;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					array = (BuffItem[])methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							array = this.$Rougamo_GetBuffs();
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
								array = (BuffItem[])methodContext.ReturnValue;
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
						array = (BuffItem[])methodContext.ReturnValue;
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

		// Token: 0x060016DE RID: 5854 RVA: 0x000BB6C0 File Offset: 0x000B98C0
		[Obsolete("Use GetBuff instead")]
		[DebuggerStepThrough]
		public int FindBuff(string buffId)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(BuffBarUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(BuffBarUI.FindBuff(string)).MethodHandle, typeof(BuffBarUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				buffId
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
							buffId = null;
						}
						else
						{
							buffId = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							num = this.$Rougamo_FindBuff(buffId);
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

		// Token: 0x060016DF RID: 5855 RVA: 0x000BB838 File Offset: 0x000B9A38
		private void Update()
		{
			bool flag = this.isDirty;
			if (flag)
			{
				int count = 0;
				foreach (KeyValuePair<string, BuffItem> item in this.BuffDic)
				{
					bool flag2 = item.Value != null;
					if (flag2)
					{
						item.Value.UpdateSorting(count);
						count++;
					}
				}
				this.isDirty = false;
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x000BB8C8 File Offset: 0x000B9AC8
		public BuffBarUI CheckAllBuff(string way)
		{
			bool flag = this.content == null;
			BuffBarUI result;
			if (flag)
			{
				result = this;
			}
			else
			{
				foreach (object obj in this.content)
				{
					Transform buff = (Transform)obj;
					BuffItem component = buff.GetComponent<BuffItem>();
					if (component != null)
					{
						component.DurationCheck(way);
					}
					BuffItem component2 = buff.GetComponent<BuffItem>();
					if (component2 != null)
					{
						component2.UpdateMsg();
					}
				}
				UniTask.WaitForSeconds(0.05f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
				{
					FightUI fightUI = UIManager.Instance.GetUI<FightUI>("FightUI");
					bool flag2 = fightUI != null;
					if (flag2)
					{
						fightUI.UpdateCardMsg();
					}
				}).Forget();
				result = this;
			}
			return result;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x000BB9A4 File Offset: 0x000B9BA4
		public void UpdateAllBuff()
		{
			bool flag = this.content == null;
			if (!flag)
			{
				foreach (object obj in this.content)
				{
					Transform buff = (Transform)obj;
					BuffItem component = buff.GetComponent<BuffItem>();
					if (component != null)
					{
						component.UpdateMsg();
					}
				}
			}
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x000BBA20 File Offset: 0x000B9C20
		public void ClearAllBuff()
		{
			foreach (object obj in this.content)
			{
				Transform buff = (Transform)obj;
				UnityEngine.Object.Destroy(buff);
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x000BBA9C File Offset: 0x000B9C9C
		private bool $Rougamo_get_isDisplay()
		{
			return ((PlayerManager.Instance == null || PlayerManager.Instance.PlayerId != this.status.InstanceId) && this.status.fatherObject is OtherPlayer) || ((PlayerManager.Instance == null || !PlayerManager.Instance.isServer) && this.status.fatherObject is OtherObj);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x000BBB16 File Offset: 0x000B9D16
		private void $Rougamo_Awake()
		{
			this.content = base.transform.Find("Content");
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x000BBB30 File Offset: 0x000B9D30
		private void $Rougamo_CreateNewBuff(string buffId, int level)
		{
			bool flag = level <= 0;
			if (!flag)
			{
				bool flag2 = Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, buffId) == null;
				if (!flag2)
				{
					GameObject buffitem = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/BuffItem"), this.content) as GameObject;
					BuffItemConfig buffConfig = new BuffItemConfig(new DataConfig(buffId, DataType.Buff), this.status, this)
					{
						level = level
					};
					bool flag3 = buffConfig.UpperBound < buffConfig.level;
					if (flag3)
					{
						buffConfig.level = buffConfig.UpperBound;
					}
					buffitem.AddComponent<BuffItem>().Init(buffConfig, this.status, this);
					Singleton<EventCenter>.Instance.EventTrigger(buffConfig.BuffId + "OnLevelChange" + this.status.InstanceId);
					this.status.UpdateDisplay();
					bool flag4 = !this.isDisplay;
					if (flag4)
					{
						FightManager.Instance.EnqueueEvent(new UpdateBuff().Create(buffConfig));
					}
				}
			}
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x000BBC30 File Offset: 0x000B9E30
		private BuffBarUI $Rougamo_RemoveBuff(string buffId)
		{
			bool flag = this.BuffDic.ContainsKey(buffId);
			if (flag)
			{
				this.BuffDic[buffId].ClearBuff();
			}
			return this;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x000BBC68 File Offset: 0x000B9E68
		private BuffBarUI $Rougamo_AddBuff(string buffId, int level)
		{
			bool flag = !this.BuffDic.ContainsKey(buffId);
			BuffBarUI result;
			if (flag)
			{
				this.CreateNewBuff(buffId, level);
				result = this;
			}
			else
			{
				BuffItem buff = this.GetBuff(buffId);
				bool flag2 = buff != null;
				if (flag2)
				{
					BuffItemConfig buffConfig = buff.buffConfig as BuffItemConfig;
					buffConfig.Level += level;
					result = this;
				}
				else
				{
					result = this;
				}
			}
			return result;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x000BBCD4 File Offset: 0x000B9ED4
		private BuffBarUI $Rougamo_AddBuff(IBuffItemConfig buffConfig)
		{
			bool flag = !this.BuffDic.ContainsKey(buffConfig.BuffId);
			BuffBarUI result;
			if (flag)
			{
				this.CreateNewBuff(buffConfig.BuffId, buffConfig.Level);
				result = this;
			}
			else
			{
				BuffItem buff = this.GetBuff(buffConfig.BuffId);
				bool flag2 = buff != null;
				if (flag2)
				{
					BuffItemConfig existingBuffConfig = buff.buffConfig as BuffItemConfig;
					existingBuffConfig.Level += buffConfig.Level;
					result = this;
				}
				else
				{
					result = this;
				}
			}
			return result;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x000BBD58 File Offset: 0x000B9F58
		private BuffItem $Rougamo_GetBuff(string buffId)
		{
			bool flag = this.BuffDic.ContainsKey(buffId);
			BuffItem result;
			if (flag)
			{
				result = this.BuffDic[buffId];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x000BBD8C File Offset: 0x000B9F8C
		private BuffItem[] $Rougamo_GetBuffs()
		{
			bool flag = this.content == null;
			BuffItem[] result;
			if (flag)
			{
				result = Array.Empty<BuffItem>();
			}
			else
			{
				BuffItem[] buffs = new BuffItem[this.content.childCount];
				for (int i = 0; i < this.content.childCount; i++)
				{
					buffs[i] = this.content.GetChild(i).GetComponent<BuffItem>();
				}
				result = buffs;
			}
			return result;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x000BBDFC File Offset: 0x000B9FFC
		private int $Rougamo_FindBuff(string buffId)
		{
			bool flag = this.BuffDic.ContainsKey(buffId);
			int result;
			if (flag)
			{
				result = this.BuffDic[buffId].transform.GetSiblingIndex();
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x040011D0 RID: 4560
		[JsonIgnore]
		public Transform content;

		// Token: 0x040011D1 RID: 4561
		[JsonIgnore]
		public StatusManager status;

		// Token: 0x040011D2 RID: 4562
		[JsonIgnore]
		public Dictionary<string, BuffItem> BuffDic = new Dictionary<string, BuffItem>();

		// Token: 0x040011D3 RID: 4563
		public bool isDirty = false;
	}
}

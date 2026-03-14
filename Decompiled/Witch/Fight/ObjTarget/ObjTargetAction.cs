using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cysharp.Text;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using Newtonsoft.Json;
using UnityEngine;

namespace Fight.ObjTarget
{
	/// <remarks>
	/// MemoryPack GenerateType: Object<br />
	/// <code>
	/// <b>string</b> Type<br />
	/// <b>string</b> Value<br />
	/// <b>string</b> InstanceId<br />
	/// <b>string</b> From<br />
	/// <b>string</b> FromDataConfigId<br />
	/// <b>string</b> ToAction<br />
	/// <b>string</b> theData<br />
	/// <b>string[]</b> ThisVars<br />
	/// </code>
	/// </remarks>
	// Token: 0x020001E7 RID: 487
	[MemoryPackable(GenerateType.Object)]
	public sealed class ObjTargetAction : ObjTargetBase, IMemoryPackable<ObjTargetAction>, IMemoryPackFormatterRegister
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x0008746C File Offset: 0x0008566C
		protected override void InternalExecute()
		{
			bool flag = FightManager.Instance == null || FightManager.Instance.statuses == null || FightManager.Instance.statuses.GetValueOrDefault(base.InstanceId) == null || FightManager.Instance.statuses.GetValueOrDefault(base.InstanceId).gameObject == null;
			if (!flag)
			{
				IScriptExecutor target = FightManager.Instance.statuses.GetValueOrDefault(base.InstanceId).MirrorSc;
				bool flag2 = target == null;
				if (flag2)
				{
					Debug.LogError("Target with InstanceId " + base.InstanceId + " not found in FightManager status.");
				}
				else
				{
					bool flag3 = Singleton<GameConfigManager>.Instance.NativeIds.Contains(this.FromDataConfigId);
					if (flag3)
					{
						target.dataConfig.data = DeepCopyUtility.DeepCopy<IDictionary<string, string>>(Singleton<GameConfigManager>.Instance.DataConfigCache[this.FromDataConfigId].data);
					}
					else
					{
						target.dataConfig.data = JsonConvert.DeserializeObject<Dictionary<string, string>>(this.theData);
					}
					MethodInfo method = target.GetType().GetMethod(this.ToAction, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					bool flag4 = method != null;
					if (flag4)
					{
						ParameterInfo[] parameters = method.GetParameters();
						string[] thisVars = this.ThisVars;
						int varsCount = (thisVars != null) ? thisVars.Length : 0;
						bool flag5 = varsCount > parameters.Length;
						if (flag5)
						{
							throw new ArgumentException(ZString.Format<object, object, object>("参数数量不匹配: {0}方法需要{1}个参数，但传入的是{2}个", this.ToAction, parameters.Length, varsCount));
						}
						object[] args = new object[parameters.Length];
						for (int i = 0; i < parameters.Length; i++)
						{
							bool flag6 = i < varsCount && this.ThisVars != null;
							if (flag6)
							{
								try
								{
									args[i] = Convert.ChangeType(this.ThisVars[i], parameters[i].ParameterType);
								}
								catch (Exception e)
								{
									Debug.LogError(string.Concat(new string[]
									{
										ZString.Format<object, object, object>("参数类型不匹配: {0}方法的第{1}个参数需要{2}类型，", this.ToAction, i + 1, parameters[i].ParameterType.Name),
										"但传入的是",
										(this.ThisVars[i] == null) ? "null" : this.ThisVars[i].GetType().Name,
										"，值为",
										this.ThisVars[i],
										"。异常信息：",
										e.Message
									}));
									throw;
								}
							}
							else
							{
								bool hasDefaultValue = parameters[i].HasDefaultValue;
								if (!hasDefaultValue)
								{
									throw new ArgumentException(string.Format("参数数量不匹配: {0}方法需要{1}个参数，但传入的是{2}个，且第{3}个参数无默认值", new object[]
									{
										this.ToAction,
										parameters.Length,
										varsCount,
										i + 1
									}));
								}
								object def = parameters[i].DefaultValue;
								args[i] = ((def != null && def != DBNull.Value) ? def : (parameters[i].ParameterType.IsValueType ? Activator.CreateInstance(parameters[i].ParameterType) : null));
							}
						}
						try
						{
							method.Invoke(target, args);
						}
						catch (TargetParameterCountException ex)
						{
							Debug.LogError("参数数量错误: " + ex.Message);
						}
						catch (ArgumentException ex2)
						{
							Debug.LogError("参数错误: " + ex2.Message);
						}
						catch (TargetInvocationException ex3)
						{
							throw ex3.InnerException;
						}
						catch (MethodAccessException ex4)
						{
							Debug.LogError("方法访问权限错误: " + ex4.Message);
						}
						catch (InvalidOperationException ex5)
						{
							Debug.LogError("无效操作: " + ex5.Message);
						}
						catch (NotSupportedException ex6)
						{
							Debug.LogError("不支持的操作: " + ex6.Message);
						}
						catch (Exception ex7)
						{
							Debug.LogError("未知异常: " + ex7.Message);
						}
					}
					else
					{
						Debug.LogError("没有找到方法:" + this.ToAction + " 在对象: " + base.InstanceId);
					}
				}
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000878F8 File Offset: 0x00085AF8
		static ObjTargetAction()
		{
			ObjTargetAction.RegisterFormatter();
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00087904 File Offset: 0x00085B04
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<ObjTargetAction>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<ObjTargetAction>(new ObjTargetAction.ObjTargetActionFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<ObjTargetAction[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<ObjTargetAction[]>(new ArrayFormatter<ObjTargetAction>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<string[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<string[]>(new ArrayFormatter<string>());
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00087960 File Offset: 0x00085B60
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref ObjTargetAction value) where TBufferWriter : class, IBufferWriter<byte>
		{
			bool flag = value == null;
			if (flag)
			{
				writer.WriteNullObjectHeader();
			}
			else
			{
				writer.WriteObjectHeader(8);
				writer.WriteString(value.Type);
				writer.WriteString(value.Value);
				writer.WriteString(value.InstanceId);
				writer.WriteString(value.From);
				writer.WriteString(value.FromDataConfigId);
				writer.WriteString(value.ToAction);
				writer.WriteString(value.theData);
				writer.WriteArray<string>(value.ThisVars);
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000879FC File Offset: 0x00085BFC
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref ObjTargetAction value)
		{
			byte count;
			bool flag = !reader.TryReadObjectHeader(out count);
			if (flag)
			{
				value = null;
			}
			else
			{
				bool flag2 = count == 8;
				string __Type;
				string __Value;
				string __InstanceId;
				string __From;
				string __FromDataConfigId;
				string __ToAction;
				string __theData;
				string[] __ThisVars;
				if (flag2)
				{
					bool flag3 = value == null;
					if (flag3)
					{
						__Type = reader.ReadString();
						__Value = reader.ReadString();
						__InstanceId = reader.ReadString();
						__From = reader.ReadString();
						__FromDataConfigId = reader.ReadString();
						__ToAction = reader.ReadString();
						__theData = reader.ReadString();
						__ThisVars = reader.ReadArray<string>();
						goto IL_29B;
					}
					__Type = value.Type;
					__Value = value.Value;
					__InstanceId = value.InstanceId;
					__From = value.From;
					__FromDataConfigId = value.FromDataConfigId;
					__ToAction = value.ToAction;
					__theData = value.theData;
					__ThisVars = value.ThisVars;
					__Type = reader.ReadString();
					__Value = reader.ReadString();
					__InstanceId = reader.ReadString();
					__From = reader.ReadString();
					__FromDataConfigId = reader.ReadString();
					__ToAction = reader.ReadString();
					__theData = reader.ReadString();
					reader.ReadArray<string>(ref __ThisVars);
				}
				else
				{
					bool flag4 = count > 8;
					if (flag4)
					{
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(ObjTargetAction), 8, count);
						goto IL_2E3;
					}
					bool flag5 = value == null;
					if (flag5)
					{
						__Type = null;
						__Value = null;
						__InstanceId = null;
						__From = null;
						__FromDataConfigId = null;
						__ToAction = null;
						__theData = null;
						__ThisVars = null;
					}
					else
					{
						__Type = value.Type;
						__Value = value.Value;
						__InstanceId = value.InstanceId;
						__From = value.From;
						__FromDataConfigId = value.FromDataConfigId;
						__ToAction = value.ToAction;
						__theData = value.theData;
						__ThisVars = value.ThisVars;
					}
					bool flag6 = count == 0;
					if (!flag6)
					{
						__Type = reader.ReadString();
						bool flag7 = count == 1;
						if (!flag7)
						{
							__Value = reader.ReadString();
							bool flag8 = count == 2;
							if (!flag8)
							{
								__InstanceId = reader.ReadString();
								bool flag9 = count == 3;
								if (!flag9)
								{
									__From = reader.ReadString();
									bool flag10 = count == 4;
									if (!flag10)
									{
										__FromDataConfigId = reader.ReadString();
										bool flag11 = count == 5;
										if (!flag11)
										{
											__ToAction = reader.ReadString();
											bool flag12 = count == 6;
											if (!flag12)
											{
												__theData = reader.ReadString();
												bool flag13 = count == 7;
												if (!flag13)
												{
													reader.ReadArray<string>(ref __ThisVars);
													bool flag14 = count == 8;
													if (flag14)
													{
													}
												}
											}
										}
									}
								}
							}
						}
					}
					bool flag15 = value == null;
					if (flag15)
					{
						goto IL_29B;
					}
				}
				value.Type = __Type;
				value.Value = __Value;
				value.InstanceId = __InstanceId;
				value.From = __From;
				value.FromDataConfigId = __FromDataConfigId;
				value.ToAction = __ToAction;
				value.theData = __theData;
				value.ThisVars = __ThisVars;
				goto IL_2E3;
				IL_29B:
				value = new ObjTargetAction
				{
					Type = __Type,
					Value = __Value,
					InstanceId = __InstanceId,
					From = __From,
					FromDataConfigId = __FromDataConfigId,
					ToAction = __ToAction,
					theData = __theData,
					ThisVars = __ThisVars
				};
				IL_2E3:;
			}
		}

		// Token: 0x020001E8 RID: 488
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class ObjTargetActionFormatter : MemoryPackFormatter<ObjTargetAction>
		{
			// Token: 0x060010B0 RID: 4272 RVA: 0x00087CF9 File Offset: 0x00085EF9
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref ObjTargetAction value)
			{
				ObjTargetAction.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x060010B1 RID: 4273 RVA: 0x00087D04 File Offset: 0x00085F04
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref ObjTargetAction value)
			{
				ObjTargetAction.Deserialize(ref reader, ref value);
			}
		}
	}
}

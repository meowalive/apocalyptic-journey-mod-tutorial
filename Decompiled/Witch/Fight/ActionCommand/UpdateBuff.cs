using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;

namespace Fight.ActionCommand
{
	/// <remarks>
	/// MemoryPack GenerateType: Object<br />
	/// <code>
	/// <b>string</b> Type<br />
	/// <b>byte[]</b> Value<br />
	/// <b>string</b> From<br />
	/// </code>
	/// </remarks>
	/// <remarks>
	/// MemoryPack GenerateType: Object<br />
	/// <code>
	/// <b>string</b> InstanceId<br />
	/// <b>int</b> Level<br />
	/// <b>string</b> BuffId<br />
	/// </code>
	/// </remarks>
	// Token: 0x02000205 RID: 517
	[MemoryPackable(GenerateType.Object)]
	public sealed class UpdateBuff : ActionCommandBase, IMemoryPackable<UpdateBuff>, IMemoryPackFormatterRegister
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00022CFE File Offset: 0x00020EFE
		public override bool Reliable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00089EAC File Offset: 0x000880AC
		public ActionCommandBase Create(BuffItemConfig buffItemConfig)
		{
			UpdateBuff.UpdateBuffData config = new UpdateBuff.UpdateBuffData
			{
				InstanceId = buffItemConfig.status.InstanceId,
				Level = buffItemConfig.Level,
				BuffId = buffItemConfig.BuffId
			};
			return base.Create(MemoryPackSerializer.Serialize<UpdateBuff.UpdateBuffData>(config, null));
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00089F04 File Offset: 0x00088104
		protected override void InternalExecute()
		{
			UpdateBuff.UpdateBuffData data = MemoryPackSerializer.Deserialize<UpdateBuff.UpdateBuffData>(base.Value, null);
			StatusManager status;
			bool flag = !FightManager.Instance.statuses.TryGetValue(data.InstanceId, out status);
			if (!flag)
			{
				bool flag2 = status.GetBuff(data.BuffId) != null;
				if (flag2)
				{
					IBuffItem buffItem = status.GetBuff(data.BuffId);
					(buffItem.buffConfig as BuffItemConfig).level = data.Level;
					buffItem.UpdateMsg();
				}
				else
				{
					status.AddBuff(data.BuffId, data.Level);
				}
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00089F9D File Offset: 0x0008819D
		static UpdateBuff()
		{
			UpdateBuff.RegisterFormatter();
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00089FA8 File Offset: 0x000881A8
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<UpdateBuff>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<UpdateBuff>(new UpdateBuff.UpdateBuffFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<UpdateBuff[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<UpdateBuff[]>(new ArrayFormatter<UpdateBuff>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<byte[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<byte[]>(new ArrayFormatter<byte>());
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0008A004 File Offset: 0x00088204
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref UpdateBuff value) where TBufferWriter : class, IBufferWriter<byte>
		{
			bool flag = value == null;
			if (flag)
			{
				writer.WriteNullObjectHeader();
			}
			else
			{
				writer.WriteObjectHeader(3);
				writer.WriteString(value.Type);
				writer.WriteUnmanagedArray<byte>(value.Value);
				writer.WriteString(value.From);
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0008A05C File Offset: 0x0008825C
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref UpdateBuff value)
		{
			byte count;
			bool flag = !reader.TryReadObjectHeader(out count);
			if (flag)
			{
				value = null;
			}
			else
			{
				bool flag2 = count == 3;
				string __Type;
				byte[] __Value;
				string __From;
				if (flag2)
				{
					bool flag3 = value == null;
					if (flag3)
					{
						__Type = reader.ReadString();
						__Value = reader.ReadUnmanagedArray<byte>();
						__From = reader.ReadString();
						goto IL_149;
					}
					__Type = value.Type;
					__Value = value.Value;
					__From = value.From;
					__Type = reader.ReadString();
					reader.ReadUnmanagedArray<byte>(ref __Value);
					__From = reader.ReadString();
				}
				else
				{
					bool flag4 = count > 3;
					if (flag4)
					{
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(UpdateBuff), 3, count);
						goto IL_168;
					}
					bool flag5 = value == null;
					if (flag5)
					{
						__Type = null;
						__Value = null;
						__From = null;
					}
					else
					{
						__Type = value.Type;
						__Value = value.Value;
						__From = value.From;
					}
					bool flag6 = count == 0;
					if (!flag6)
					{
						__Type = reader.ReadString();
						bool flag7 = count == 1;
						if (!flag7)
						{
							reader.ReadUnmanagedArray<byte>(ref __Value);
							bool flag8 = count == 2;
							if (!flag8)
							{
								__From = reader.ReadString();
								bool flag9 = count == 3;
								if (flag9)
								{
								}
							}
						}
					}
					bool flag10 = value == null;
					if (flag10)
					{
						goto IL_149;
					}
				}
				value.Type = __Type;
				value.Value = __Value;
				value.From = __From;
				goto IL_168;
				IL_149:
				value = new UpdateBuff
				{
					Type = __Type,
					Value = __Value,
					From = __From
				};
				IL_168:;
			}
		}

		// Token: 0x02000206 RID: 518
		[MemoryPackable(GenerateType.Object)]
		public struct UpdateBuffData : IMemoryPackable<UpdateBuff.UpdateBuffData>, IMemoryPackFormatterRegister
		{
			// Token: 0x06001142 RID: 4418 RVA: 0x0008A1D5 File Offset: 0x000883D5
			static UpdateBuffData()
			{
				UpdateBuff.UpdateBuffData.RegisterFormatter();
			}

			// Token: 0x06001143 RID: 4419 RVA: 0x0008A1E0 File Offset: 0x000883E0
			[Preserve]
			public static void RegisterFormatter()
			{
				bool flag = !MemoryPackFormatterProvider.IsRegistered<UpdateBuff.UpdateBuffData>();
				if (flag)
				{
					MemoryPackFormatterProvider.Register<UpdateBuff.UpdateBuffData>(new UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter());
				}
				bool flag2 = !MemoryPackFormatterProvider.IsRegistered<UpdateBuff.UpdateBuffData[]>();
				if (flag2)
				{
					MemoryPackFormatterProvider.Register<UpdateBuff.UpdateBuffData[]>(new ArrayFormatter<UpdateBuff.UpdateBuffData>());
				}
			}

			// Token: 0x06001144 RID: 4420 RVA: 0x0008A220 File Offset: 0x00088420
			[NullableContext(1)]
			[Preserve]
			public static void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref UpdateBuff.UpdateBuffData value) where TBufferWriter : class, IBufferWriter<byte>
			{
				writer.WriteObjectHeader(3);
				writer.WriteString(value.InstanceId);
				writer.WriteUnmanaged<int>(value.Level);
				writer.WriteString(value.BuffId);
			}

			// Token: 0x06001145 RID: 4421 RVA: 0x0008A258 File Offset: 0x00088458
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref UpdateBuff.UpdateBuffData value)
			{
				byte count;
				bool flag = !reader.TryReadObjectHeader(out count);
				if (flag)
				{
					value = default(UpdateBuff.UpdateBuffData);
				}
				else
				{
					bool flag2 = count == 3;
					string __InstanceId;
					int __Level;
					string __BuffId;
					if (flag2)
					{
						__InstanceId = reader.ReadString();
						reader.ReadUnmanaged<int>(out __Level);
						__BuffId = reader.ReadString();
					}
					else
					{
						bool flag3 = count > 3;
						if (flag3)
						{
							MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(UpdateBuff.UpdateBuffData), 3, count);
							goto IL_E0;
						}
						__InstanceId = null;
						__Level = 0;
						__BuffId = null;
						bool flag4 = count == 0;
						if (!flag4)
						{
							__InstanceId = reader.ReadString();
							bool flag5 = count == 1;
							if (!flag5)
							{
								reader.ReadUnmanaged<int>(out __Level);
								bool flag6 = count == 2;
								if (!flag6)
								{
									__BuffId = reader.ReadString();
									bool flag7 = count == 3;
									if (flag7)
									{
									}
								}
							}
						}
					}
					value = new UpdateBuff.UpdateBuffData
					{
						InstanceId = __InstanceId,
						Level = __Level,
						BuffId = __BuffId
					};
					IL_E0:;
				}
			}

			// Token: 0x04000E76 RID: 3702
			public string InstanceId;

			// Token: 0x04000E77 RID: 3703
			public int Level;

			// Token: 0x04000E78 RID: 3704
			public string BuffId;

			// Token: 0x02000207 RID: 519
			[Preserve]
			private sealed class UpdateBuffDataFormatter : MemoryPackFormatter<UpdateBuff.UpdateBuffData>
			{
				// Token: 0x06001146 RID: 4422 RVA: 0x0008A349 File Offset: 0x00088549
				[NullableContext(1)]
				[Preserve]
				public override void Serialize<TBufferWriter>([Nullable(new byte[]
				{
					0,
					1
				})] ref MemoryPackWriter<TBufferWriter> writer, ref UpdateBuff.UpdateBuffData value)
				{
					UpdateBuff.UpdateBuffData.Serialize<TBufferWriter>(ref writer, ref value);
				}

				// Token: 0x06001147 RID: 4423 RVA: 0x0008A354 File Offset: 0x00088554
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref UpdateBuff.UpdateBuffData value)
				{
					UpdateBuff.UpdateBuffData.Deserialize(ref reader, ref value);
				}
			}
		}

		// Token: 0x02000208 RID: 520
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class UpdateBuffFormatter : MemoryPackFormatter<UpdateBuff>
		{
			// Token: 0x06001149 RID: 4425 RVA: 0x0008A368 File Offset: 0x00088568
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref UpdateBuff value)
			{
				UpdateBuff.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x0600114A RID: 4426 RVA: 0x0008A373 File Offset: 0x00088573
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref UpdateBuff value)
			{
				UpdateBuff.Deserialize(ref reader, ref value);
			}
		}
	}
}

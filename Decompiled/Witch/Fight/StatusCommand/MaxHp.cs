using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;

namespace Fight.StatusCommand
{
	/// <remarks>
	/// MemoryPack GenerateType: Object<br />
	/// <code>
	/// <b>string</b> Type<br />
	/// <b>int</b> Value<br />
	/// <b>string</b> InstanceId<br />
	/// <b>string</b> From<br />
	/// </code>
	/// </remarks>
	// Token: 0x020001E3 RID: 483
	[MemoryPackable(GenerateType.Object)]
	public sealed class MaxHp : ClientCommandBase, IMemoryPackable<MaxHp>, IMemoryPackFormatterRegister
	{
		// Token: 0x06001098 RID: 4248 RVA: 0x00086E6C File Offset: 0x0008506C
		protected override void InternalExecute()
		{
			StatusDataTransfer status = FightManager.Instance.statusData[base.InstanceId];
			base.Replace(status.WithPropertys("maxHp", status.maxHp + base.Value));
			bool flag = status.curHp > status.maxHp;
			if (flag)
			{
				base.Replace(status.WithPropertys("curHp", status.maxHp));
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00086EE5 File Offset: 0x000850E5
		static MaxHp()
		{
			MaxHp.RegisterFormatter();
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00086EF0 File Offset: 0x000850F0
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<MaxHp>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<MaxHp>(new MaxHp.MaxHpFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<MaxHp[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<MaxHp[]>(new ArrayFormatter<MaxHp>());
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00086F30 File Offset: 0x00085130
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref MaxHp value) where TBufferWriter : class, IBufferWriter<byte>
		{
			bool flag = value == null;
			if (flag)
			{
				writer.WriteNullObjectHeader();
			}
			else
			{
				writer.WriteObjectHeader(4);
				writer.WriteString(value.Type);
				int value2 = value.Value;
				writer.WriteUnmanaged<int>(value2);
				writer.WriteString(value.InstanceId);
				writer.WriteString(value.From);
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00086F98 File Offset: 0x00085198
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref MaxHp value)
		{
			byte count;
			bool flag = !reader.TryReadObjectHeader(out count);
			if (flag)
			{
				value = null;
			}
			else
			{
				bool flag2 = count == 4;
				string __Type;
				int __Value;
				string __InstanceId;
				string __From;
				if (flag2)
				{
					bool flag3 = value == null;
					if (flag3)
					{
						__Type = reader.ReadString();
						reader.ReadUnmanaged<int>(out __Value);
						__InstanceId = reader.ReadString();
						__From = reader.ReadString();
						goto IL_18E;
					}
					__Type = value.Type;
					__Value = value.Value;
					__InstanceId = value.InstanceId;
					__From = value.From;
					__Type = reader.ReadString();
					reader.ReadUnmanaged<int>(out __Value);
					__InstanceId = reader.ReadString();
					__From = reader.ReadString();
				}
				else
				{
					bool flag4 = count > 4;
					if (flag4)
					{
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(MaxHp), 4, count);
						goto IL_1B6;
					}
					bool flag5 = value == null;
					if (flag5)
					{
						__Type = null;
						__Value = 0;
						__InstanceId = null;
						__From = null;
					}
					else
					{
						__Type = value.Type;
						__Value = value.Value;
						__InstanceId = value.InstanceId;
						__From = value.From;
					}
					bool flag6 = count == 0;
					if (!flag6)
					{
						__Type = reader.ReadString();
						bool flag7 = count == 1;
						if (!flag7)
						{
							reader.ReadUnmanaged<int>(out __Value);
							bool flag8 = count == 2;
							if (!flag8)
							{
								__InstanceId = reader.ReadString();
								bool flag9 = count == 3;
								if (!flag9)
								{
									__From = reader.ReadString();
									bool flag10 = count == 4;
									if (flag10)
									{
									}
								}
							}
						}
					}
					bool flag11 = value == null;
					if (flag11)
					{
						goto IL_18E;
					}
				}
				value.Type = __Type;
				value.Value = __Value;
				value.InstanceId = __InstanceId;
				value.From = __From;
				goto IL_1B6;
				IL_18E:
				value = new MaxHp
				{
					Type = __Type,
					Value = __Value,
					InstanceId = __InstanceId,
					From = __From
				};
				IL_1B6:;
			}
		}

		// Token: 0x020001E4 RID: 484
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class MaxHpFormatter : MemoryPackFormatter<MaxHp>
		{
			// Token: 0x0600109E RID: 4254 RVA: 0x0008715F File Offset: 0x0008535F
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref MaxHp value)
			{
				MaxHp.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x0600109F RID: 4255 RVA: 0x0008716A File Offset: 0x0008536A
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref MaxHp value)
			{
				MaxHp.Deserialize(ref reader, ref value);
			}
		}
	}
}

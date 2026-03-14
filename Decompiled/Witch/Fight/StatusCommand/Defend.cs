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
	// Token: 0x020001E1 RID: 481
	[MemoryPackable(GenerateType.Object)]
	public sealed class Defend : ClientCommandBase, IMemoryPackable<Defend>, IMemoryPackFormatterRegister
	{
		// Token: 0x0600108F RID: 4239 RVA: 0x00086B88 File Offset: 0x00084D88
		protected override void InternalExecute()
		{
			StatusDataTransfer status = FightManager.Instance.statusData[base.InstanceId];
			base.Replace(status.WithPropertys("defend", status.defend + base.Value));
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00086BD0 File Offset: 0x00084DD0
		static Defend()
		{
			Defend.RegisterFormatter();
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00086BDC File Offset: 0x00084DDC
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<Defend>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<Defend>(new Defend.DefendFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<Defend[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<Defend[]>(new ArrayFormatter<Defend>());
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00086C1C File Offset: 0x00084E1C
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref Defend value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x06001093 RID: 4243 RVA: 0x00086C84 File Offset: 0x00084E84
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref Defend value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(Defend), 4, count);
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
				value = new Defend
				{
					Type = __Type,
					Value = __Value,
					InstanceId = __InstanceId,
					From = __From
				};
				IL_1B6:;
			}
		}

		// Token: 0x020001E2 RID: 482
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class DefendFormatter : MemoryPackFormatter<Defend>
		{
			// Token: 0x06001095 RID: 4245 RVA: 0x00086E4B File Offset: 0x0008504B
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref Defend value)
			{
				Defend.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x06001096 RID: 4246 RVA: 0x00086E56 File Offset: 0x00085056
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref Defend value)
			{
				Defend.Deserialize(ref reader, ref value);
			}
		}
	}
}

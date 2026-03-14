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
	// Token: 0x020001E5 RID: 485
	[MemoryPackable(GenerateType.Object)]
	public sealed class ToughCount : ClientCommandBase, IMemoryPackable<ToughCount>, IMemoryPackFormatterRegister
	{
		// Token: 0x060010A1 RID: 4257 RVA: 0x00087180 File Offset: 0x00085380
		protected override void InternalExecute()
		{
			StatusDataTransfer status = FightManager.Instance.statusData[base.InstanceId];
			base.Replace(status.WithPropertys("_toughCount", Math.Min(status.ToughOrigin, status._toughCount + base.Value)));
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x000871D3 File Offset: 0x000853D3
		static ToughCount()
		{
			ToughCount.RegisterFormatter();
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x000871DC File Offset: 0x000853DC
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<ToughCount>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<ToughCount>(new ToughCount.ToughCountFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<ToughCount[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<ToughCount[]>(new ArrayFormatter<ToughCount>());
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0008721C File Offset: 0x0008541C
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref ToughCount value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x060010A5 RID: 4261 RVA: 0x00087284 File Offset: 0x00085484
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref ToughCount value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(ToughCount), 4, count);
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
				value = new ToughCount
				{
					Type = __Type,
					Value = __Value,
					InstanceId = __InstanceId,
					From = __From
				};
				IL_1B6:;
			}
		}

		// Token: 0x020001E6 RID: 486
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class ToughCountFormatter : MemoryPackFormatter<ToughCount>
		{
			// Token: 0x060010A7 RID: 4263 RVA: 0x0008744B File Offset: 0x0008564B
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref ToughCount value)
			{
				ToughCount.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x060010A8 RID: 4264 RVA: 0x00087456 File Offset: 0x00085656
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref ToughCount value)
			{
				ToughCount.Deserialize(ref reader, ref value);
			}
		}
	}
}

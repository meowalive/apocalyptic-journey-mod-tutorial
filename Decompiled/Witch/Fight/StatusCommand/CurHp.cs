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
	// Token: 0x020001DF RID: 479
	[MemoryPackable(GenerateType.Object)]
	public sealed class CurHp : ClientCommandBase, IMemoryPackable<CurHp>, IMemoryPackFormatterRegister
	{
		// Token: 0x06001086 RID: 4230 RVA: 0x00086894 File Offset: 0x00084A94
		protected override void InternalExecute()
		{
			StatusDataTransfer status = FightManager.Instance.statusData[base.InstanceId];
			base.Replace(status.WithPropertys("curHp", Math.Min(status.maxHp, status.curHp + base.Value)));
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x000868E7 File Offset: 0x00084AE7
		static CurHp()
		{
			CurHp.RegisterFormatter();
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x000868F0 File Offset: 0x00084AF0
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<CurHp>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<CurHp>(new CurHp.CurHpFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<CurHp[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<CurHp[]>(new ArrayFormatter<CurHp>());
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00086930 File Offset: 0x00084B30
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref CurHp value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x0600108A RID: 4234 RVA: 0x00086998 File Offset: 0x00084B98
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref CurHp value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(CurHp), 4, count);
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
				value = new CurHp
				{
					Type = __Type,
					Value = __Value,
					InstanceId = __InstanceId,
					From = __From
				};
				IL_1B6:;
			}
		}

		// Token: 0x020001E0 RID: 480
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class CurHpFormatter : MemoryPackFormatter<CurHp>
		{
			// Token: 0x0600108C RID: 4236 RVA: 0x00086B68 File Offset: 0x00084D68
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref CurHp value)
			{
				CurHp.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x0600108D RID: 4237 RVA: 0x00086B73 File Offset: 0x00084D73
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref CurHp value)
			{
				CurHp.Deserialize(ref reader, ref value);
			}
		}
	}
}

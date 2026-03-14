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
	/// <b>string</b> To<br />
	/// <b>int</b> State<br />
	/// </code>
	/// </remarks>
	// Token: 0x0200020D RID: 525
	[MemoryPackable(GenerateType.Object)]
	public sealed class Vocal : ActionCommandBase, IMemoryPackable<Vocal>, IMemoryPackFormatterRegister
	{
		// Token: 0x0600115D RID: 4445 RVA: 0x0008A7F0 File Offset: 0x000889F0
		public ActionCommandBase Create(string instanceId, IStatusManager.VocalState state)
		{
			Vocal.VocalData data = new Vocal.VocalData
			{
				To = instanceId,
				State = (int)state
			};
			return base.Create(MemoryPackSerializer.Serialize<Vocal.VocalData>(data, null));
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0008A82C File Offset: 0x00088A2C
		protected override void InternalExecute()
		{
			Vocal.VocalData data = MemoryPackSerializer.Deserialize<Vocal.VocalData>(base.Value, null);
			StatusManager status;
			bool flag = string.IsNullOrEmpty(data.To) || !FightManager.Instance.statuses.TryGetValue(data.To, out status);
			if (!flag)
			{
				status.PlayVocal((IStatusManager.VocalState)data.State);
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0008A889 File Offset: 0x00088A89
		static Vocal()
		{
			Vocal.RegisterFormatter();
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0008A894 File Offset: 0x00088A94
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<Vocal>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<Vocal>(new Vocal.VocalFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<Vocal[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<Vocal[]>(new ArrayFormatter<Vocal>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<byte[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<byte[]>(new ArrayFormatter<byte>());
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0008A8F0 File Offset: 0x00088AF0
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref Vocal value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x06001162 RID: 4450 RVA: 0x0008A948 File Offset: 0x00088B48
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref Vocal value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(Vocal), 3, count);
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
				value = new Vocal
				{
					Type = __Type,
					Value = __Value,
					From = __From
				};
				IL_168:;
			}
		}

		// Token: 0x0200020E RID: 526
		[MemoryPackable(GenerateType.Object)]
		public struct VocalData : IMemoryPackable<Vocal.VocalData>, IMemoryPackFormatterRegister
		{
			// Token: 0x06001164 RID: 4452 RVA: 0x0008AAC1 File Offset: 0x00088CC1
			static VocalData()
			{
				Vocal.VocalData.RegisterFormatter();
			}

			// Token: 0x06001165 RID: 4453 RVA: 0x0008AACC File Offset: 0x00088CCC
			[Preserve]
			public static void RegisterFormatter()
			{
				bool flag = !MemoryPackFormatterProvider.IsRegistered<Vocal.VocalData>();
				if (flag)
				{
					MemoryPackFormatterProvider.Register<Vocal.VocalData>(new Vocal.VocalData.VocalDataFormatter());
				}
				bool flag2 = !MemoryPackFormatterProvider.IsRegistered<Vocal.VocalData[]>();
				if (flag2)
				{
					MemoryPackFormatterProvider.Register<Vocal.VocalData[]>(new ArrayFormatter<Vocal.VocalData>());
				}
			}

			// Token: 0x06001166 RID: 4454 RVA: 0x0008AB0C File Offset: 0x00088D0C
			[NullableContext(1)]
			[Preserve]
			public static void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref Vocal.VocalData value) where TBufferWriter : class, IBufferWriter<byte>
			{
				writer.WriteObjectHeader(2);
				writer.WriteString(value.To);
				writer.WriteUnmanaged<int>(value.State);
			}

			// Token: 0x06001167 RID: 4455 RVA: 0x0008AB34 File Offset: 0x00088D34
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref Vocal.VocalData value)
			{
				byte count;
				bool flag = !reader.TryReadObjectHeader(out count);
				if (flag)
				{
					value = default(Vocal.VocalData);
				}
				else
				{
					bool flag2 = count == 2;
					string __To;
					int __State;
					if (flag2)
					{
						__To = reader.ReadString();
						reader.ReadUnmanaged<int>(out __State);
					}
					else
					{
						bool flag3 = count > 2;
						if (flag3)
						{
							MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(Vocal.VocalData), 2, count);
							goto IL_BA;
						}
						__To = null;
						__State = 0;
						bool flag4 = count == 0;
						if (!flag4)
						{
							__To = reader.ReadString();
							bool flag5 = count == 1;
							if (!flag5)
							{
								reader.ReadUnmanaged<int>(out __State);
								bool flag6 = count == 2;
								if (flag6)
								{
								}
							}
						}
					}
					value = new Vocal.VocalData
					{
						To = __To,
						State = __State
					};
					IL_BA:;
				}
			}

			// Token: 0x04000E7B RID: 3707
			public string To;

			// Token: 0x04000E7C RID: 3708
			public int State;

			// Token: 0x0200020F RID: 527
			[Preserve]
			private sealed class VocalDataFormatter : MemoryPackFormatter<Vocal.VocalData>
			{
				// Token: 0x06001168 RID: 4456 RVA: 0x0008ABFF File Offset: 0x00088DFF
				[NullableContext(1)]
				[Preserve]
				public override void Serialize<TBufferWriter>([Nullable(new byte[]
				{
					0,
					1
				})] ref MemoryPackWriter<TBufferWriter> writer, ref Vocal.VocalData value)
				{
					Vocal.VocalData.Serialize<TBufferWriter>(ref writer, ref value);
				}

				// Token: 0x06001169 RID: 4457 RVA: 0x0008AC0A File Offset: 0x00088E0A
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref Vocal.VocalData value)
				{
					Vocal.VocalData.Deserialize(ref reader, ref value);
				}
			}
		}

		// Token: 0x02000210 RID: 528
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class VocalFormatter : MemoryPackFormatter<Vocal>
		{
			// Token: 0x0600116B RID: 4459 RVA: 0x0008AC1E File Offset: 0x00088E1E
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref Vocal value)
			{
				Vocal.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x0600116C RID: 4460 RVA: 0x0008AC29 File Offset: 0x00088E29
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref Vocal value)
			{
				Vocal.Deserialize(ref reader, ref value);
			}
		}
	}
}

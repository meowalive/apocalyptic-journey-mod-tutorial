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
	/// <b>string</b> BuffId<br />
	/// </code>
	/// </remarks>
	// Token: 0x020001FD RID: 509
	[MemoryPackable(GenerateType.Object)]
	public sealed class RemoveBuff : ActionCommandBase, IMemoryPackable<RemoveBuff>, IMemoryPackFormatterRegister
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x00022CFE File Offset: 0x00020EFE
		public override bool Reliable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000895D8 File Offset: 0x000877D8
		public ActionCommandBase Create(BuffItemConfig buffItemConfig)
		{
			RemoveBuff.RemoveBuffData config = new RemoveBuff.RemoveBuffData
			{
				InstanceId = buffItemConfig.status.InstanceId,
				BuffId = buffItemConfig.BuffId
			};
			return base.Create(MemoryPackSerializer.Serialize<RemoveBuff.RemoveBuffData>(config, null));
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00089624 File Offset: 0x00087824
		protected override void InternalExecute()
		{
			RemoveBuff.RemoveBuffData data = MemoryPackSerializer.Deserialize<RemoveBuff.RemoveBuffData>(base.Value, null);
			StatusManager status;
			bool flag = !FightManager.Instance.statuses.TryGetValue(data.InstanceId, out status);
			if (!flag)
			{
				bool flag2 = status.GetBuff(data.BuffId) != null;
				if (flag2)
				{
					IBuffItem buffItem = status.GetBuff(data.BuffId);
					buffItem.ClearBuff();
				}
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0008968F File Offset: 0x0008788F
		static RemoveBuff()
		{
			RemoveBuff.RegisterFormatter();
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00089698 File Offset: 0x00087898
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<RemoveBuff>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<RemoveBuff>(new RemoveBuff.RemoveBuffFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<RemoveBuff[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<RemoveBuff[]>(new ArrayFormatter<RemoveBuff>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<byte[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<byte[]>(new ArrayFormatter<byte>());
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000896F4 File Offset: 0x000878F4
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref RemoveBuff value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x0600111D RID: 4381 RVA: 0x0008974C File Offset: 0x0008794C
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref RemoveBuff value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(RemoveBuff), 3, count);
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
				value = new RemoveBuff
				{
					Type = __Type,
					Value = __Value,
					From = __From
				};
				IL_168:;
			}
		}

		// Token: 0x020001FE RID: 510
		[MemoryPackable(GenerateType.Object)]
		public struct RemoveBuffData : IMemoryPackable<RemoveBuff.RemoveBuffData>, IMemoryPackFormatterRegister
		{
			// Token: 0x0600111F RID: 4383 RVA: 0x000898C5 File Offset: 0x00087AC5
			static RemoveBuffData()
			{
				RemoveBuff.RemoveBuffData.RegisterFormatter();
			}

			// Token: 0x06001120 RID: 4384 RVA: 0x000898D0 File Offset: 0x00087AD0
			[Preserve]
			public static void RegisterFormatter()
			{
				bool flag = !MemoryPackFormatterProvider.IsRegistered<RemoveBuff.RemoveBuffData>();
				if (flag)
				{
					MemoryPackFormatterProvider.Register<RemoveBuff.RemoveBuffData>(new RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter());
				}
				bool flag2 = !MemoryPackFormatterProvider.IsRegistered<RemoveBuff.RemoveBuffData[]>();
				if (flag2)
				{
					MemoryPackFormatterProvider.Register<RemoveBuff.RemoveBuffData[]>(new ArrayFormatter<RemoveBuff.RemoveBuffData>());
				}
			}

			// Token: 0x06001121 RID: 4385 RVA: 0x00089910 File Offset: 0x00087B10
			[NullableContext(1)]
			[Preserve]
			public static void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref RemoveBuff.RemoveBuffData value) where TBufferWriter : class, IBufferWriter<byte>
			{
				writer.WriteObjectHeader(2);
				writer.WriteString(value.InstanceId);
				writer.WriteString(value.BuffId);
			}

			// Token: 0x06001122 RID: 4386 RVA: 0x00089938 File Offset: 0x00087B38
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref RemoveBuff.RemoveBuffData value)
			{
				byte count;
				bool flag = !reader.TryReadObjectHeader(out count);
				if (flag)
				{
					value = default(RemoveBuff.RemoveBuffData);
				}
				else
				{
					bool flag2 = count == 2;
					string __InstanceId;
					string __BuffId;
					if (flag2)
					{
						__InstanceId = reader.ReadString();
						__BuffId = reader.ReadString();
					}
					else
					{
						bool flag3 = count > 2;
						if (flag3)
						{
							MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(RemoveBuff.RemoveBuffData), 2, count);
							goto IL_B6;
						}
						__InstanceId = null;
						__BuffId = null;
						bool flag4 = count == 0;
						if (!flag4)
						{
							__InstanceId = reader.ReadString();
							bool flag5 = count == 1;
							if (!flag5)
							{
								__BuffId = reader.ReadString();
								bool flag6 = count == 2;
								if (flag6)
								{
								}
							}
						}
					}
					value = new RemoveBuff.RemoveBuffData
					{
						InstanceId = __InstanceId,
						BuffId = __BuffId
					};
					IL_B6:;
				}
			}

			// Token: 0x04000E72 RID: 3698
			public string InstanceId;

			// Token: 0x04000E73 RID: 3699
			public string BuffId;

			// Token: 0x020001FF RID: 511
			[Preserve]
			private sealed class RemoveBuffDataFormatter : MemoryPackFormatter<RemoveBuff.RemoveBuffData>
			{
				// Token: 0x06001123 RID: 4387 RVA: 0x000899FF File Offset: 0x00087BFF
				[NullableContext(1)]
				[Preserve]
				public override void Serialize<TBufferWriter>([Nullable(new byte[]
				{
					0,
					1
				})] ref MemoryPackWriter<TBufferWriter> writer, ref RemoveBuff.RemoveBuffData value)
				{
					RemoveBuff.RemoveBuffData.Serialize<TBufferWriter>(ref writer, ref value);
				}

				// Token: 0x06001124 RID: 4388 RVA: 0x00089A0A File Offset: 0x00087C0A
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref RemoveBuff.RemoveBuffData value)
				{
					RemoveBuff.RemoveBuffData.Deserialize(ref reader, ref value);
				}
			}
		}

		// Token: 0x02000200 RID: 512
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class RemoveBuffFormatter : MemoryPackFormatter<RemoveBuff>
		{
			// Token: 0x06001126 RID: 4390 RVA: 0x00089A1E File Offset: 0x00087C1E
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref RemoveBuff value)
			{
				RemoveBuff.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x06001127 RID: 4391 RVA: 0x00089A29 File Offset: 0x00087C29
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref RemoveBuff value)
			{
				RemoveBuff.Deserialize(ref reader, ref value);
			}
		}
	}
}

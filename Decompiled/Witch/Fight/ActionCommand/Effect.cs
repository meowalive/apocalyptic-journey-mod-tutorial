using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using ZLinq;
using ZLinq.Linq;

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
	/// <b>string</b> effectName<br />
	/// <b>string</b> Self<br />
	/// <b>System.Collections.Generic.List&lt;string&gt;</b> Object<br />
	/// </code>
	/// </remarks>
	// Token: 0x020001F8 RID: 504
	[MemoryPackable(GenerateType.Object)]
	public sealed class Effect : ActionCommandBase, IMemoryPackable<Effect>, IMemoryPackFormatterRegister
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x00089090 File Offset: 0x00087290
		protected override void InternalExecute()
		{
			Effect.EffectData data = MemoryPackSerializer.Deserialize<Effect.EffectData>(base.Value, null);
			bool flag = string.IsNullOrEmpty(data.Self) || !FightManager.Instance.statuses.ContainsKey(data.Self) || Singleton<EffectManager>.Instance == null;
			if (!flag)
			{
				bool flag2 = data.Object == null;
				if (!flag2)
				{
					List<IStatusManager> objects = (from x in data.Object.AsValueEnumerable<string>()
					where !string.IsNullOrEmpty(x) && FightManager.Instance.statuses.ContainsKey(x)
					select FightManager.Instance.statuses[x]).ToList<ListWhereSelect<string, IStatusManager>, IStatusManager>();
					Singleton<EffectManager>.Instance.InternalPlayEffect(FightManager.Instance.statuses[data.Self], objects, data.effectName);
				}
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0008917C File Offset: 0x0008737C
		public ActionCommandBase Create(Effect.EffectData value)
		{
			base.Create(MemoryPackSerializer.Serialize<Effect.EffectData>(value, null));
			return this;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0008919E File Offset: 0x0008739E
		static Effect()
		{
			Effect.RegisterFormatter();
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x000891A8 File Offset: 0x000873A8
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<Effect>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<Effect>(new Effect.EffectFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<Effect[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<Effect[]>(new ArrayFormatter<Effect>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<byte[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<byte[]>(new ArrayFormatter<byte>());
			}
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00089204 File Offset: 0x00087404
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref Effect value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x06001107 RID: 4359 RVA: 0x0008925C File Offset: 0x0008745C
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref Effect value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(Effect), 3, count);
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
				value = new Effect
				{
					Type = __Type,
					Value = __Value,
					From = __From
				};
				IL_168:;
			}
		}

		// Token: 0x020001F9 RID: 505
		[MemoryPackable(GenerateType.Object)]
		public struct EffectData : IMemoryPackable<Effect.EffectData>, IMemoryPackFormatterRegister
		{
			// Token: 0x06001109 RID: 4361 RVA: 0x000893D5 File Offset: 0x000875D5
			static EffectData()
			{
				Effect.EffectData.RegisterFormatter();
			}

			// Token: 0x0600110A RID: 4362 RVA: 0x000893E0 File Offset: 0x000875E0
			[Preserve]
			public static void RegisterFormatter()
			{
				bool flag = !MemoryPackFormatterProvider.IsRegistered<Effect.EffectData>();
				if (flag)
				{
					MemoryPackFormatterProvider.Register<Effect.EffectData>(new Effect.EffectData.EffectDataFormatter());
				}
				bool flag2 = !MemoryPackFormatterProvider.IsRegistered<Effect.EffectData[]>();
				if (flag2)
				{
					MemoryPackFormatterProvider.Register<Effect.EffectData[]>(new ArrayFormatter<Effect.EffectData>());
				}
				bool flag3 = !MemoryPackFormatterProvider.IsRegistered<List<string>>();
				if (flag3)
				{
					MemoryPackFormatterProvider.Register<List<string>>(new ListFormatter<string>());
				}
			}

			// Token: 0x0600110B RID: 4363 RVA: 0x00089439 File Offset: 0x00087639
			[NullableContext(1)]
			[Preserve]
			public static void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref Effect.EffectData value) where TBufferWriter : class, IBufferWriter<byte>
			{
				writer.WriteObjectHeader(3);
				writer.WriteString(value.effectName);
				writer.WriteString(value.Self);
				writer.WriteValue<List<string>>(value.Object);
			}

			// Token: 0x0600110C RID: 4364 RVA: 0x00089470 File Offset: 0x00087670
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref Effect.EffectData value)
			{
				byte count;
				bool flag = !reader.TryReadObjectHeader(out count);
				if (flag)
				{
					value = default(Effect.EffectData);
				}
				else
				{
					bool flag2 = count == 3;
					string __effectName;
					string __Self;
					List<string> __Object;
					if (flag2)
					{
						__effectName = reader.ReadString();
						__Self = reader.ReadString();
						__Object = reader.ReadValue<List<string>>();
					}
					else
					{
						bool flag3 = count > 3;
						if (flag3)
						{
							MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(Effect.EffectData), 3, count);
							goto IL_DE;
						}
						__effectName = null;
						__Self = null;
						__Object = null;
						bool flag4 = count == 0;
						if (!flag4)
						{
							__effectName = reader.ReadString();
							bool flag5 = count == 1;
							if (!flag5)
							{
								__Self = reader.ReadString();
								bool flag6 = count == 2;
								if (!flag6)
								{
									reader.ReadValue<List<string>>(ref __Object);
									bool flag7 = count == 3;
									if (flag7)
									{
									}
								}
							}
						}
					}
					value = new Effect.EffectData
					{
						effectName = __effectName,
						Self = __Self,
						Object = __Object
					};
					IL_DE:;
				}
			}

			// Token: 0x04000E6C RID: 3692
			public string effectName;

			// Token: 0x04000E6D RID: 3693
			public string Self;

			// Token: 0x04000E6E RID: 3694
			public List<string> Object;

			// Token: 0x020001FA RID: 506
			[Preserve]
			private sealed class EffectDataFormatter : MemoryPackFormatter<Effect.EffectData>
			{
				// Token: 0x0600110D RID: 4365 RVA: 0x0008955F File Offset: 0x0008775F
				[NullableContext(1)]
				[Preserve]
				public override void Serialize<TBufferWriter>([Nullable(new byte[]
				{
					0,
					1
				})] ref MemoryPackWriter<TBufferWriter> writer, ref Effect.EffectData value)
				{
					Effect.EffectData.Serialize<TBufferWriter>(ref writer, ref value);
				}

				// Token: 0x0600110E RID: 4366 RVA: 0x0008956A File Offset: 0x0008776A
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref Effect.EffectData value)
				{
					Effect.EffectData.Deserialize(ref reader, ref value);
				}
			}
		}

		// Token: 0x020001FB RID: 507
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class EffectFormatter : MemoryPackFormatter<Effect>
		{
			// Token: 0x06001110 RID: 4368 RVA: 0x0008957E File Offset: 0x0008777E
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref Effect value)
			{
				Effect.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x06001111 RID: 4369 RVA: 0x00089589 File Offset: 0x00087789
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref Effect value)
			{
				Effect.Deserialize(ref reader, ref value);
			}
		}
	}
}

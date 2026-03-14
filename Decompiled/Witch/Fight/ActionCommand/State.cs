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
	/// <b>string</b> Value<br />
	/// </code>
	/// </remarks>
	// Token: 0x02000201 RID: 513
	[MemoryPackable(GenerateType.Object)]
	public sealed class State : ActionCommandBase, IMemoryPackable<State>, IMemoryPackFormatterRegister
	{
		// Token: 0x06001129 RID: 4393 RVA: 0x00089A40 File Offset: 0x00087C40
		public ActionCommandBase Create(string InstanceId, IStatusManager.State State)
		{
			State.StateData stateData = new State.StateData
			{
				To = InstanceId,
				Value = State.ToString()
			};
			return base.Create(MemoryPackSerializer.Serialize<State.StateData>(stateData, null));
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00089A88 File Offset: 0x00087C88
		protected override void InternalExecute()
		{
			State.StateData data = MemoryPackSerializer.Deserialize<State.StateData>(base.Value, null);
			StatusManager status;
			bool flag = string.IsNullOrEmpty(data.To) || !FightManager.Instance.statuses.TryGetValue(data.To, out status);
			if (!flag)
			{
				status._NetEnqueue = true;
				status.state = Enum.Parse<IStatusManager.State>(data.Value);
				status._NetEnqueue = false;
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00089AF8 File Offset: 0x00087CF8
		static State()
		{
			State.RegisterFormatter();
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00089B04 File Offset: 0x00087D04
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<State>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<State>(new State.StateFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<State[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<State[]>(new ArrayFormatter<State>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<byte[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<byte[]>(new ArrayFormatter<byte>());
			}
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00089B60 File Offset: 0x00087D60
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref State value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x0600112E RID: 4398 RVA: 0x00089BB8 File Offset: 0x00087DB8
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref State value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(State), 3, count);
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
				value = new State
				{
					Type = __Type,
					Value = __Value,
					From = __From
				};
				IL_168:;
			}
		}

		// Token: 0x02000202 RID: 514
		[MemoryPackable(GenerateType.Object)]
		public struct StateData : IMemoryPackable<State.StateData>, IMemoryPackFormatterRegister
		{
			// Token: 0x06001130 RID: 4400 RVA: 0x00089D31 File Offset: 0x00087F31
			static StateData()
			{
				State.StateData.RegisterFormatter();
			}

			// Token: 0x06001131 RID: 4401 RVA: 0x00089D3C File Offset: 0x00087F3C
			[Preserve]
			public static void RegisterFormatter()
			{
				bool flag = !MemoryPackFormatterProvider.IsRegistered<State.StateData>();
				if (flag)
				{
					MemoryPackFormatterProvider.Register<State.StateData>(new State.StateData.StateDataFormatter());
				}
				bool flag2 = !MemoryPackFormatterProvider.IsRegistered<State.StateData[]>();
				if (flag2)
				{
					MemoryPackFormatterProvider.Register<State.StateData[]>(new ArrayFormatter<State.StateData>());
				}
			}

			// Token: 0x06001132 RID: 4402 RVA: 0x00089D7C File Offset: 0x00087F7C
			[NullableContext(1)]
			[Preserve]
			public static void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref State.StateData value) where TBufferWriter : class, IBufferWriter<byte>
			{
				writer.WriteObjectHeader(2);
				writer.WriteString(value.To);
				writer.WriteString(value.Value);
			}

			// Token: 0x06001133 RID: 4403 RVA: 0x00089DA4 File Offset: 0x00087FA4
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref State.StateData value)
			{
				byte count;
				bool flag = !reader.TryReadObjectHeader(out count);
				if (flag)
				{
					value = default(State.StateData);
				}
				else
				{
					bool flag2 = count == 2;
					string __To;
					string __Value;
					if (flag2)
					{
						__To = reader.ReadString();
						__Value = reader.ReadString();
					}
					else
					{
						bool flag3 = count > 2;
						if (flag3)
						{
							MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(State.StateData), 2, count);
							goto IL_B6;
						}
						__To = null;
						__Value = null;
						bool flag4 = count == 0;
						if (!flag4)
						{
							__To = reader.ReadString();
							bool flag5 = count == 1;
							if (!flag5)
							{
								__Value = reader.ReadString();
								bool flag6 = count == 2;
								if (flag6)
								{
								}
							}
						}
					}
					value = new State.StateData
					{
						To = __To,
						Value = __Value
					};
					IL_B6:;
				}
			}

			// Token: 0x04000E74 RID: 3700
			public string To;

			// Token: 0x04000E75 RID: 3701
			public string Value;

			// Token: 0x02000203 RID: 515
			[Preserve]
			private sealed class StateDataFormatter : MemoryPackFormatter<State.StateData>
			{
				// Token: 0x06001134 RID: 4404 RVA: 0x00089E6B File Offset: 0x0008806B
				[NullableContext(1)]
				[Preserve]
				public override void Serialize<TBufferWriter>([Nullable(new byte[]
				{
					0,
					1
				})] ref MemoryPackWriter<TBufferWriter> writer, ref State.StateData value)
				{
					State.StateData.Serialize<TBufferWriter>(ref writer, ref value);
				}

				// Token: 0x06001135 RID: 4405 RVA: 0x00089E76 File Offset: 0x00088076
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref State.StateData value)
				{
					State.StateData.Deserialize(ref reader, ref value);
				}
			}
		}

		// Token: 0x02000204 RID: 516
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class StateFormatter : MemoryPackFormatter<State>
		{
			// Token: 0x06001137 RID: 4407 RVA: 0x00089E8A File Offset: 0x0008808A
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref State value)
			{
				State.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x06001138 RID: 4408 RVA: 0x00089E95 File Offset: 0x00088095
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref State value)
			{
				State.Deserialize(ref reader, ref value);
			}
		}
	}
}

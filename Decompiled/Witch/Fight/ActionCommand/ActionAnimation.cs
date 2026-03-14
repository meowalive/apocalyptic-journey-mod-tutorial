using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using Witch.UI;
using Witch.UI.Window;
using ZLinq;

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
	/// <b>string[]</b> status<br />
	/// <b>IStatusManager.AnimatedState[]</b> animationState<br />
	/// <b>string</b> effectName<br />
	/// </code>
	/// </remarks>
	// Token: 0x020001EC RID: 492
	[MemoryPackable(GenerateType.Object)]
	public sealed class ActionAnimation : ActionCommandBase, IMemoryPackable<ActionAnimation>, IMemoryPackFormatterRegister
	{
		// Token: 0x060010CA RID: 4298 RVA: 0x0008807C File Offset: 0x0008627C
		public ActionCommandBase Create(FightUI.AnimationData State)
		{
			ActionAnimation.AnimationData animationData = default(ActionAnimation.AnimationData);
			animationData.status = (from x in State.status.AsValueEnumerable<StatusManager>()
			select x.InstanceId).ToArray<StatusManager, string>();
			animationData.animationState = State.animationState;
			animationData.effectName = State.effectName;
			ActionAnimation.AnimationData StateData = animationData;
			return base.Create(MemoryPackSerializer.Serialize<ActionAnimation.AnimationData>(StateData, null));
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000880FC File Offset: 0x000862FC
		protected override void InternalExecute()
		{
			ActionAnimation.AnimationData data = MemoryPackSerializer.Deserialize<ActionAnimation.AnimationData>(base.Value, null);
			bool flag = data.status == null || data.status.Length == 0;
			if (!flag)
			{
				UIManager instance = UIManager.Instance;
				FightUI ui = (instance != null) ? instance.GetUI<FightUI>("FightUI") : null;
				bool flag2 = ui == null;
				if (!flag2)
				{
					ui.animationQueue.Enqueue(new FightUI.AnimationData(data));
					ui.DOActionAnimation();
				}
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00088174 File Offset: 0x00086374
		static ActionAnimation()
		{
			ActionAnimation.RegisterFormatter();
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00088180 File Offset: 0x00086380
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<ActionAnimation>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<ActionAnimation>(new ActionAnimation.ActionAnimationFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<ActionAnimation[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<ActionAnimation[]>(new ArrayFormatter<ActionAnimation>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<byte[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<byte[]>(new ArrayFormatter<byte>());
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000881DC File Offset: 0x000863DC
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref ActionAnimation value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x060010CF RID: 4303 RVA: 0x00088234 File Offset: 0x00086434
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref ActionAnimation value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(ActionAnimation), 3, count);
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
				value = new ActionAnimation
				{
					Type = __Type,
					Value = __Value,
					From = __From
				};
				IL_168:;
			}
		}

		/// <summary>
		/// 一组动作包含的数据
		/// </summary>
		// Token: 0x020001ED RID: 493
		[MemoryPackable(GenerateType.Object)]
		public struct AnimationData : IMemoryPackable<ActionAnimation.AnimationData>, IMemoryPackFormatterRegister
		{
			// Token: 0x060010D1 RID: 4305 RVA: 0x000883B6 File Offset: 0x000865B6
			static AnimationData()
			{
				ActionAnimation.AnimationData.RegisterFormatter();
			}

			// Token: 0x060010D2 RID: 4306 RVA: 0x000883C0 File Offset: 0x000865C0
			[Preserve]
			public static void RegisterFormatter()
			{
				bool flag = !MemoryPackFormatterProvider.IsRegistered<ActionAnimation.AnimationData>();
				if (flag)
				{
					MemoryPackFormatterProvider.Register<ActionAnimation.AnimationData>(new ActionAnimation.AnimationData.AnimationDataFormatter());
				}
				bool flag2 = !MemoryPackFormatterProvider.IsRegistered<ActionAnimation.AnimationData[]>();
				if (flag2)
				{
					MemoryPackFormatterProvider.Register<ActionAnimation.AnimationData[]>(new ArrayFormatter<ActionAnimation.AnimationData>());
				}
				bool flag3 = !MemoryPackFormatterProvider.IsRegistered<string[]>();
				if (flag3)
				{
					MemoryPackFormatterProvider.Register<string[]>(new ArrayFormatter<string>());
				}
				bool flag4 = !MemoryPackFormatterProvider.IsRegistered<IStatusManager.AnimatedState[]>();
				if (flag4)
				{
					MemoryPackFormatterProvider.Register<IStatusManager.AnimatedState[]>(new ArrayFormatter<IStatusManager.AnimatedState>());
				}
				bool flag5 = !MemoryPackFormatterProvider.IsRegistered<IStatusManager.AnimatedState>();
				if (flag5)
				{
					MemoryPackFormatterProvider.Register<IStatusManager.AnimatedState>(new UnmanagedFormatter<IStatusManager.AnimatedState>());
				}
			}

			// Token: 0x060010D3 RID: 4307 RVA: 0x0008844D File Offset: 0x0008664D
			[NullableContext(1)]
			[Preserve]
			public static void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref ActionAnimation.AnimationData value) where TBufferWriter : class, IBufferWriter<byte>
			{
				writer.WriteObjectHeader(3);
				writer.WriteArray<string>(value.status);
				writer.WriteUnmanagedArray<IStatusManager.AnimatedState>(value.animationState);
				writer.WriteString(value.effectName);
			}

			// Token: 0x060010D4 RID: 4308 RVA: 0x00088484 File Offset: 0x00086684
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref ActionAnimation.AnimationData value)
			{
				byte count;
				bool flag = !reader.TryReadObjectHeader(out count);
				if (flag)
				{
					value = default(ActionAnimation.AnimationData);
				}
				else
				{
					bool flag2 = count == 3;
					string[] __status;
					IStatusManager.AnimatedState[] __animationState;
					string __effectName;
					if (flag2)
					{
						__status = reader.ReadArray<string>();
						__animationState = reader.ReadUnmanagedArray<IStatusManager.AnimatedState>();
						__effectName = reader.ReadString();
					}
					else
					{
						bool flag3 = count > 3;
						if (flag3)
						{
							MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(ActionAnimation.AnimationData), 3, count);
							goto IL_E0;
						}
						__status = null;
						__animationState = null;
						__effectName = null;
						bool flag4 = count == 0;
						if (!flag4)
						{
							reader.ReadArray<string>(ref __status);
							bool flag5 = count == 1;
							if (!flag5)
							{
								reader.ReadUnmanagedArray<IStatusManager.AnimatedState>(ref __animationState);
								bool flag6 = count == 2;
								if (!flag6)
								{
									__effectName = reader.ReadString();
									bool flag7 = count == 3;
									if (flag7)
									{
									}
								}
							}
						}
					}
					value = new ActionAnimation.AnimationData
					{
						status = __status,
						animationState = __animationState,
						effectName = __effectName
					};
					IL_E0:;
				}
			}

			// Token: 0x04000E5B RID: 3675
			public string[] status;

			// Token: 0x04000E5C RID: 3676
			public IStatusManager.AnimatedState[] animationState;

			// Token: 0x04000E5D RID: 3677
			public string effectName;

			// Token: 0x020001EE RID: 494
			[Preserve]
			private sealed class AnimationDataFormatter : MemoryPackFormatter<ActionAnimation.AnimationData>
			{
				// Token: 0x060010D5 RID: 4309 RVA: 0x00088575 File Offset: 0x00086775
				[NullableContext(1)]
				[Preserve]
				public override void Serialize<TBufferWriter>([Nullable(new byte[]
				{
					0,
					1
				})] ref MemoryPackWriter<TBufferWriter> writer, ref ActionAnimation.AnimationData value)
				{
					ActionAnimation.AnimationData.Serialize<TBufferWriter>(ref writer, ref value);
				}

				// Token: 0x060010D6 RID: 4310 RVA: 0x00088580 File Offset: 0x00086780
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref ActionAnimation.AnimationData value)
				{
					ActionAnimation.AnimationData.Deserialize(ref reader, ref value);
				}
			}
		}

		// Token: 0x020001EF RID: 495
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class ActionAnimationFormatter : MemoryPackFormatter<ActionAnimation>
		{
			// Token: 0x060010D8 RID: 4312 RVA: 0x00088594 File Offset: 0x00086794
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref ActionAnimation value)
			{
				ActionAnimation.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x060010D9 RID: 4313 RVA: 0x0008859F File Offset: 0x0008679F
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref ActionAnimation value)
			{
				ActionAnimation.Deserialize(ref reader, ref value);
			}
		}
	}
}

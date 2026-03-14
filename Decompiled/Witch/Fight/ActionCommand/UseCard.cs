using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using Witch.UI;
using Witch.UI.Window;

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
	/// <b>DataConfig</b> cardData<br />
	/// <b>bool</b> isBurning<br />
	/// </code>
	/// </remarks>
	// Token: 0x02000209 RID: 521
	[MemoryPackable(GenerateType.Object)]
	public sealed class UseCard : ActionCommandBase, IMemoryPackable<UseCard>, IMemoryPackFormatterRegister
	{
		// Token: 0x0600114C RID: 4428 RVA: 0x0008A388 File Offset: 0x00088588
		public ActionCommandBase Create(UseCard.CardUseData cardData)
		{
			byte[] bytes = MemoryPackSerializer.Serialize<UseCard.CardUseData>(cardData, null);
			bool flag = bytes.Length >= 960;
			if (flag)
			{
				this.Reliable = true;
			}
			else
			{
				this.Reliable = false;
			}
			return base.Create(bytes);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0008A3D4 File Offset: 0x000885D4
		protected override void InternalExecute()
		{
			bool flag = base.Value == null || base.Value.Length == 0;
			if (!flag)
			{
				UseCard.CardUseData cardData = MemoryPackSerializer.Deserialize<UseCard.CardUseData>(base.Value, null);
				UIManager instance = UIManager.Instance;
				FightUI fightUI = (instance != null) ? instance.GetUI<FightUI>("FightUI") : null;
				bool flag2 = fightUI == null;
				if (!flag2)
				{
					fightUI.DoCardUseAnimation(cardData);
				}
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0008A43B File Offset: 0x0008863B
		static UseCard()
		{
			UseCard.RegisterFormatter();
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0008A444 File Offset: 0x00088644
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<UseCard>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<UseCard>(new UseCard.UseCardFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<UseCard[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<UseCard[]>(new ArrayFormatter<UseCard>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<byte[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<byte[]>(new ArrayFormatter<byte>());
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0008A4A0 File Offset: 0x000886A0
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref UseCard value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x06001151 RID: 4433 RVA: 0x0008A4F8 File Offset: 0x000886F8
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref UseCard value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(UseCard), 3, count);
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
				value = new UseCard
				{
					Type = __Type,
					Value = __Value,
					From = __From
				};
				IL_168:;
			}
		}

		// Token: 0x0200020A RID: 522
		[MemoryPackable(GenerateType.Object)]
		public struct CardUseData : IMemoryPackable<UseCard.CardUseData>, IMemoryPackFormatterRegister
		{
			// Token: 0x06001153 RID: 4435 RVA: 0x0008A671 File Offset: 0x00088871
			static CardUseData()
			{
				UseCard.CardUseData.RegisterFormatter();
			}

			// Token: 0x06001154 RID: 4436 RVA: 0x0008A67C File Offset: 0x0008887C
			[Preserve]
			public static void RegisterFormatter()
			{
				bool flag = !MemoryPackFormatterProvider.IsRegistered<UseCard.CardUseData>();
				if (flag)
				{
					MemoryPackFormatterProvider.Register<UseCard.CardUseData>(new UseCard.CardUseData.CardUseDataFormatter());
				}
				bool flag2 = !MemoryPackFormatterProvider.IsRegistered<UseCard.CardUseData[]>();
				if (flag2)
				{
					MemoryPackFormatterProvider.Register<UseCard.CardUseData[]>(new ArrayFormatter<UseCard.CardUseData>());
				}
			}

			// Token: 0x06001155 RID: 4437 RVA: 0x0008A6BC File Offset: 0x000888BC
			[NullableContext(1)]
			[Preserve]
			public static void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref UseCard.CardUseData value) where TBufferWriter : class, IBufferWriter<byte>
			{
				writer.WriteObjectHeader(2);
				writer.WritePackable<DataConfig>(value.cardData);
				writer.WriteUnmanaged<bool>(value.isBurning);
			}

			// Token: 0x06001156 RID: 4438 RVA: 0x0008A6E4 File Offset: 0x000888E4
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref UseCard.CardUseData value)
			{
				byte count;
				bool flag = !reader.TryReadObjectHeader(out count);
				if (flag)
				{
					value = default(UseCard.CardUseData);
				}
				else
				{
					bool flag2 = count == 2;
					DataConfig __cardData;
					bool __isBurning;
					if (flag2)
					{
						__cardData = reader.ReadPackable<DataConfig>();
						reader.ReadUnmanaged<bool>(out __isBurning);
					}
					else
					{
						bool flag3 = count > 2;
						if (flag3)
						{
							MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(UseCard.CardUseData), 2, count);
							goto IL_BC;
						}
						__cardData = null;
						__isBurning = false;
						bool flag4 = count == 0;
						if (!flag4)
						{
							reader.ReadPackable<DataConfig>(ref __cardData);
							bool flag5 = count == 1;
							if (!flag5)
							{
								reader.ReadUnmanaged<bool>(out __isBurning);
								bool flag6 = count == 2;
								if (flag6)
								{
								}
							}
						}
					}
					value = new UseCard.CardUseData
					{
						cardData = __cardData,
						isBurning = __isBurning
					};
					IL_BC:;
				}
			}

			// Token: 0x04000E79 RID: 3705
			public DataConfig cardData;

			// Token: 0x04000E7A RID: 3706
			public bool isBurning;

			// Token: 0x0200020B RID: 523
			[Preserve]
			private sealed class CardUseDataFormatter : MemoryPackFormatter<UseCard.CardUseData>
			{
				// Token: 0x06001157 RID: 4439 RVA: 0x0008A7B1 File Offset: 0x000889B1
				[NullableContext(1)]
				[Preserve]
				public override void Serialize<TBufferWriter>([Nullable(new byte[]
				{
					0,
					1
				})] ref MemoryPackWriter<TBufferWriter> writer, ref UseCard.CardUseData value)
				{
					UseCard.CardUseData.Serialize<TBufferWriter>(ref writer, ref value);
				}

				// Token: 0x06001158 RID: 4440 RVA: 0x0008A7BC File Offset: 0x000889BC
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref UseCard.CardUseData value)
				{
					UseCard.CardUseData.Deserialize(ref reader, ref value);
				}
			}
		}

		// Token: 0x0200020C RID: 524
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class UseCardFormatter : MemoryPackFormatter<UseCard>
		{
			// Token: 0x0600115A RID: 4442 RVA: 0x0008A7D0 File Offset: 0x000889D0
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref UseCard value)
			{
				UseCard.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x0600115B RID: 4443 RVA: 0x0008A7DB File Offset: 0x000889DB
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref UseCard value)
			{
				UseCard.Deserialize(ref reader, ref value);
			}
		}
	}
}

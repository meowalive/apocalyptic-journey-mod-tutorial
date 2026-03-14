using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using UnityEngine;

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
	/// <b>string</b> from<br />
	/// <b>string</b> to<br />
	/// <b>int</b> hit<br />
	/// <b>int</b> originalVal<br />
	/// <b>float</b> x<br />
	/// <b>float</b> y<br />
	/// <b>string</b> damageType<br />
	/// </code>
	/// </remarks>
	// Token: 0x020001F4 RID: 500
	[MemoryPackable(GenerateType.Object)]
	public sealed class DamageText : ActionCommandBase, IMemoryPackable<DamageText>, IMemoryPackFormatterRegister
	{
		// Token: 0x060010F1 RID: 4337 RVA: 0x00088AD8 File Offset: 0x00086CD8
		protected override void InternalExecute()
		{
			DamageText.DamageTextData data = MemoryPackSerializer.Deserialize<DamageText.DamageTextData>(base.Value, null);
			StatusManager toStatus;
			bool flag = string.IsNullOrEmpty(data.to) || !FightManager.Instance.statuses.TryGetValue(data.to, out toStatus);
			if (!flag)
			{
				CustomDamageType customDamageType = string.IsNullOrEmpty(data.damageType) ? null : ResourceLoader.Load<CustomDamageType>("Configs/DamageType/" + data.damageType, true);
				bool flag2 = customDamageType == null;
				if (!flag2)
				{
					StatusManager fromStatus = null;
					bool flag3 = !string.IsNullOrEmpty(data.from);
					if (flag3)
					{
						FightManager.Instance.statuses.TryGetValue(data.from, out fromStatus);
					}
					customDamageType.ShowDamage(toStatus, data.hit, new Vector3(data.x, data.y), fromStatus, data.originalVal);
				}
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00088BB8 File Offset: 0x00086DB8
		public ActionCommandBase Create(DamageText.DamageTextData value)
		{
			return base.Create(MemoryPackSerializer.Serialize<DamageText.DamageTextData>(value, null));
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00088BD8 File Offset: 0x00086DD8
		static DamageText()
		{
			DamageText.RegisterFormatter();
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00088BE4 File Offset: 0x00086DE4
		[Preserve]
		public new static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<DamageText>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<DamageText>(new DamageText.DamageTextFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<DamageText[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<DamageText[]>(new ArrayFormatter<DamageText>());
			}
			bool flag3 = !MemoryPackFormatterProvider.IsRegistered<byte[]>();
			if (flag3)
			{
				MemoryPackFormatterProvider.Register<byte[]>(new ArrayFormatter<byte>());
			}
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00088C40 File Offset: 0x00086E40
		[NullableContext(1)]
		[Preserve]
		public static void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref DamageText value) where TBufferWriter : class, IBufferWriter<byte>
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

		// Token: 0x060010F6 RID: 4342 RVA: 0x00088C98 File Offset: 0x00086E98
		[NullableContext(2)]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref DamageText value)
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
						MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(DamageText), 3, count);
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
				value = new DamageText
				{
					Type = __Type,
					Value = __Value,
					From = __From
				};
				IL_168:;
			}
		}

		// Token: 0x020001F5 RID: 501
		[MemoryPackable(GenerateType.Object)]
		public struct DamageTextData : IMemoryPackable<DamageText.DamageTextData>, IMemoryPackFormatterRegister
		{
			// Token: 0x060010F8 RID: 4344 RVA: 0x00088E11 File Offset: 0x00087011
			static DamageTextData()
			{
				DamageText.DamageTextData.RegisterFormatter();
			}

			// Token: 0x060010F9 RID: 4345 RVA: 0x00088E1C File Offset: 0x0008701C
			[Preserve]
			public static void RegisterFormatter()
			{
				bool flag = !MemoryPackFormatterProvider.IsRegistered<DamageText.DamageTextData>();
				if (flag)
				{
					MemoryPackFormatterProvider.Register<DamageText.DamageTextData>(new DamageText.DamageTextData.DamageTextDataFormatter());
				}
				bool flag2 = !MemoryPackFormatterProvider.IsRegistered<DamageText.DamageTextData[]>();
				if (flag2)
				{
					MemoryPackFormatterProvider.Register<DamageText.DamageTextData[]>(new ArrayFormatter<DamageText.DamageTextData>());
				}
			}

			// Token: 0x060010FA RID: 4346 RVA: 0x00088E5C File Offset: 0x0008705C
			[NullableContext(1)]
			[Preserve]
			public static void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref DamageText.DamageTextData value) where TBufferWriter : class, IBufferWriter<byte>
			{
				writer.WriteObjectHeader(7);
				writer.WriteString(value.from);
				writer.WriteString(value.to);
				writer.WriteUnmanaged<int, int, float, float>(value.hit, value.originalVal, value.x, value.y);
				writer.WriteString(value.damageType);
			}

			// Token: 0x060010FB RID: 4347 RVA: 0x00088EBC File Offset: 0x000870BC
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref DamageText.DamageTextData value)
			{
				byte count;
				bool flag = !reader.TryReadObjectHeader(out count);
				if (flag)
				{
					value = default(DamageText.DamageTextData);
				}
				else
				{
					bool flag2 = count == 7;
					string __from;
					string __to;
					int __hit;
					int __originalVal;
					float __x;
					float __y;
					string __damageType;
					if (flag2)
					{
						__from = reader.ReadString();
						__to = reader.ReadString();
						reader.ReadUnmanaged<int, int, float, float>(out __hit, out __originalVal, out __x, out __y);
						__damageType = reader.ReadString();
					}
					else
					{
						bool flag3 = count > 7;
						if (flag3)
						{
							MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(DamageText.DamageTextData), 7, count);
							goto IL_182;
						}
						__from = null;
						__to = null;
						__hit = 0;
						__originalVal = 0;
						__x = 0f;
						__y = 0f;
						__damageType = null;
						bool flag4 = count == 0;
						if (!flag4)
						{
							__from = reader.ReadString();
							bool flag5 = count == 1;
							if (!flag5)
							{
								__to = reader.ReadString();
								bool flag6 = count == 2;
								if (!flag6)
								{
									reader.ReadUnmanaged<int>(out __hit);
									bool flag7 = count == 3;
									if (!flag7)
									{
										reader.ReadUnmanaged<int>(out __originalVal);
										bool flag8 = count == 4;
										if (!flag8)
										{
											reader.ReadUnmanaged<float>(out __x);
											bool flag9 = count == 5;
											if (!flag9)
											{
												reader.ReadUnmanaged<float>(out __y);
												bool flag10 = count == 6;
												if (!flag10)
												{
													__damageType = reader.ReadString();
													bool flag11 = count == 7;
													if (flag11)
													{
													}
												}
											}
										}
									}
								}
							}
						}
					}
					value = new DamageText.DamageTextData
					{
						from = __from,
						to = __to,
						hit = __hit,
						originalVal = __originalVal,
						x = __x,
						y = __y,
						damageType = __damageType
					};
					IL_182:;
				}
			}

			// Token: 0x04000E65 RID: 3685
			public string from;

			// Token: 0x04000E66 RID: 3686
			public string to;

			// Token: 0x04000E67 RID: 3687
			public int hit;

			// Token: 0x04000E68 RID: 3688
			public int originalVal;

			// Token: 0x04000E69 RID: 3689
			public float x;

			// Token: 0x04000E6A RID: 3690
			public float y;

			// Token: 0x04000E6B RID: 3691
			public string damageType;

			// Token: 0x020001F6 RID: 502
			[Preserve]
			private sealed class DamageTextDataFormatter : MemoryPackFormatter<DamageText.DamageTextData>
			{
				// Token: 0x060010FC RID: 4348 RVA: 0x0008904F File Offset: 0x0008724F
				[NullableContext(1)]
				[Preserve]
				public override void Serialize<TBufferWriter>([Nullable(new byte[]
				{
					0,
					1
				})] ref MemoryPackWriter<TBufferWriter> writer, ref DamageText.DamageTextData value)
				{
					DamageText.DamageTextData.Serialize<TBufferWriter>(ref writer, ref value);
				}

				// Token: 0x060010FD RID: 4349 RVA: 0x0008905A File Offset: 0x0008725A
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref DamageText.DamageTextData value)
				{
					DamageText.DamageTextData.Deserialize(ref reader, ref value);
				}
			}
		}

		// Token: 0x020001F7 RID: 503
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class DamageTextFormatter : MemoryPackFormatter<DamageText>
		{
			// Token: 0x060010FF RID: 4351 RVA: 0x0008906E File Offset: 0x0008726E
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, ref DamageText value)
			{
				DamageText.Serialize<TBufferWriter>(ref writer, ref value);
			}

			// Token: 0x06001100 RID: 4352 RVA: 0x00089079 File Offset: 0x00087279
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref DamageText value)
			{
				DamageText.Deserialize(ref reader, ref value);
			}
		}
	}
}

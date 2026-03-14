using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Internal;

// Token: 0x0200003A RID: 58
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
[MemoryPackUnionFormatter(typeof(IDataConfig))]
[MemoryPackUnion(0, typeof(DataConfig))]
[Preserve]
public class DataConfigFormatter : MemoryPackFormatter<IDataConfig>
{
	// Token: 0x0600017E RID: 382 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
	[Preserve]
	public override void Serialize<TBufferWriter>([Nullable(new byte[]
	{
		0,
		1
	})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref IDataConfig value)
	{
		bool flag = value == null;
		if (flag)
		{
			writer.WriteNullUnionHeader();
		}
		else
		{
			ushort tag;
			bool flag2 = DataConfigFormatter.__typeToTag.TryGetValue(value.GetType(), out tag);
			if (flag2)
			{
				writer.WriteUnionHeader(tag);
				ushort num = tag;
				ushort num2 = num;
				if (num2 == 0)
				{
					writer.WritePackable<DataConfig>(Unsafe.As<IDataConfig, DataConfig>(ref value));
				}
			}
			else
			{
				MemoryPackSerializationException.ThrowNotFoundInUnionType(value.GetType(), typeof(IDataConfig));
			}
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x0000DA70 File Offset: 0x0000BC70
	[NullableContext(2)]
	[Preserve]
	public override void Deserialize(ref MemoryPackReader reader, ref IDataConfig value)
	{
		ushort tag;
		bool flag = !reader.TryReadUnionHeader(out tag);
		if (flag)
		{
			value = null;
		}
		else
		{
			ushort num = tag;
			ushort num2 = num;
			if (num2 != 0)
			{
				MemoryPackSerializationException.ThrowInvalidTag(tag, typeof(IDataConfig));
			}
			else
			{
				bool flag2 = value is DataConfig;
				if (flag2)
				{
					reader.ReadPackable<DataConfig>(Unsafe.As<IDataConfig, DataConfig>(ref value));
				}
				else
				{
					value = reader.ReadPackable<DataConfig>();
				}
			}
		}
	}

	// Token: 0x040000CD RID: 205
	private static readonly Dictionary<Type, ushort> __typeToTag = new Dictionary<Type, ushort>(1)
	{
		{
			typeof(DataConfig),
			0
		}
	};
}

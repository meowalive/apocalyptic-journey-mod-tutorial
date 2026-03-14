using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using Mirror;
using UnityEngine;

namespace Fight.ActionCommand
{
	/// <summary>
	/// 对战斗中行动状态的更新，通常不需要保证可靠性，仅做动画的同步。
	/// </summary>
	// Token: 0x020001F1 RID: 497
	[MemoryPackable(GenerateType.Object)]
	[MemoryPackUnion(0, typeof(ActionAnimation))]
	[MemoryPackUnion(1, typeof(DamageText))]
	[MemoryPackUnion(2, typeof(Effect))]
	[MemoryPackUnion(3, typeof(RemoveBuff))]
	[MemoryPackUnion(4, typeof(State))]
	[MemoryPackUnion(5, typeof(UpdateBuff))]
	[MemoryPackUnion(6, typeof(UseCard))]
	[MemoryPackUnion(7, typeof(Vocal))]
	public abstract class ActionCommandBase : IStatusCommand, IMemoryPackFormatterRegister
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x000885C7 File Offset: 0x000867C7
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x000885CF File Offset: 0x000867CF
		public byte[] Value { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x000885D8 File Offset: 0x000867D8
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x000885E0 File Offset: 0x000867E0
		public string From { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x000885E9 File Offset: 0x000867E9
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x000885F1 File Offset: 0x000867F1
		[MemoryPackIgnore]
		public virtual bool Reliable { get; set; }

		// Token: 0x060010E4 RID: 4324 RVA: 0x000026D9 File Offset: 0x000008D9
		protected virtual void InternalExecute()
		{
		}

		/// <summary>
		/// 在客户端中创建
		/// </summary>
		/// <param name="value"></param>
		// Token: 0x060010E5 RID: 4325 RVA: 0x000885FC File Offset: 0x000867FC
		[Client]
		protected ActionCommandBase Create(byte[] value)
		{
			if (!NetworkClient.active)
			{
				Debug.LogWarning("[Client] function 'Fight.ActionCommand.ActionCommandBase Fight.ActionCommand.ActionCommandBase::Create(System.Byte[])' called when client was not active");
				return null;
			}
			this.Value = value;
			this.From = PlayerManager.Instance.PlayerId;
			this.Type = base.GetType().FullName;
			return this;
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0008865A File Offset: 0x0008685A
		[Client]
		public void Execute()
		{
			if (!NetworkClient.active)
			{
				Debug.LogWarning("[Client] function 'System.Void Fight.ActionCommand.ActionCommandBase::Execute()' called when client was not active");
				return;
			}
			this.InternalExecute();
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0008867C File Offset: 0x0008687C
		public ActionCommandBase CopyFrom(ActionCommandBase origin)
		{
			this.From = origin.From;
			this.Type = origin.Type;
			this.Value = origin.Value;
			return this;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x000886B5 File Offset: 0x000868B5
		static ActionCommandBase()
		{
			ActionCommandBase.RegisterFormatter();
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x000886C0 File Offset: 0x000868C0
		[Preserve]
		public static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<ActionCommandBase>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<ActionCommandBase>(new ActionCommandBase.ActionCommandBaseFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<ActionCommandBase[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<ActionCommandBase[]>(new ArrayFormatter<ActionCommandBase>());
			}
		}

		// Token: 0x04000E60 RID: 3680
		public string Type;

		// Token: 0x020001F2 RID: 498
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class ActionCommandBaseFormatter : MemoryPackFormatter<ActionCommandBase>
		{
			// Token: 0x060010EB RID: 4331 RVA: 0x00088700 File Offset: 0x00086900
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref ActionCommandBase value)
			{
				bool flag = value == null;
				if (flag)
				{
					writer.WriteNullUnionHeader();
				}
				else
				{
					ushort tag;
					bool flag2 = ActionCommandBase.ActionCommandBaseFormatter.__typeToTag.TryGetValue(value.GetType(), out tag);
					if (flag2)
					{
						writer.WriteUnionHeader(tag);
						switch (tag)
						{
						case 0:
							writer.WritePackable<ActionAnimation>(Unsafe.As<ActionCommandBase, ActionAnimation>(ref value));
							break;
						case 1:
							writer.WritePackable<DamageText>(Unsafe.As<ActionCommandBase, DamageText>(ref value));
							break;
						case 2:
							writer.WritePackable<Effect>(Unsafe.As<ActionCommandBase, Effect>(ref value));
							break;
						case 3:
							writer.WritePackable<RemoveBuff>(Unsafe.As<ActionCommandBase, RemoveBuff>(ref value));
							break;
						case 4:
							writer.WritePackable<State>(Unsafe.As<ActionCommandBase, State>(ref value));
							break;
						case 5:
							writer.WritePackable<UpdateBuff>(Unsafe.As<ActionCommandBase, UpdateBuff>(ref value));
							break;
						case 6:
							writer.WritePackable<UseCard>(Unsafe.As<ActionCommandBase, UseCard>(ref value));
							break;
						case 7:
							writer.WritePackable<Vocal>(Unsafe.As<ActionCommandBase, Vocal>(ref value));
							break;
						}
					}
					else
					{
						MemoryPackSerializationException.ThrowNotFoundInUnionType(value.GetType(), typeof(ActionCommandBase));
					}
				}
			}

			// Token: 0x060010EC RID: 4332 RVA: 0x0008880C File Offset: 0x00086A0C
			[NullableContext(2)]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref ActionCommandBase value)
			{
				ushort tag;
				bool flag = !reader.TryReadUnionHeader(out tag);
				if (flag)
				{
					value = null;
				}
				else
				{
					switch (tag)
					{
					case 0:
					{
						bool flag2 = value is ActionAnimation;
						if (flag2)
						{
							reader.ReadPackable<ActionAnimation>(Unsafe.As<ActionCommandBase, ActionAnimation>(ref value));
						}
						else
						{
							value = reader.ReadPackable<ActionAnimation>();
						}
						break;
					}
					case 1:
					{
						bool flag3 = value is DamageText;
						if (flag3)
						{
							reader.ReadPackable<DamageText>(Unsafe.As<ActionCommandBase, DamageText>(ref value));
						}
						else
						{
							value = reader.ReadPackable<DamageText>();
						}
						break;
					}
					case 2:
					{
						bool flag4 = value is Effect;
						if (flag4)
						{
							reader.ReadPackable<Effect>(Unsafe.As<ActionCommandBase, Effect>(ref value));
						}
						else
						{
							value = reader.ReadPackable<Effect>();
						}
						break;
					}
					case 3:
					{
						bool flag5 = value is RemoveBuff;
						if (flag5)
						{
							reader.ReadPackable<RemoveBuff>(Unsafe.As<ActionCommandBase, RemoveBuff>(ref value));
						}
						else
						{
							value = reader.ReadPackable<RemoveBuff>();
						}
						break;
					}
					case 4:
					{
						bool flag6 = value is State;
						if (flag6)
						{
							reader.ReadPackable<State>(Unsafe.As<ActionCommandBase, State>(ref value));
						}
						else
						{
							value = reader.ReadPackable<State>();
						}
						break;
					}
					case 5:
					{
						bool flag7 = value is UpdateBuff;
						if (flag7)
						{
							reader.ReadPackable<UpdateBuff>(Unsafe.As<ActionCommandBase, UpdateBuff>(ref value));
						}
						else
						{
							value = reader.ReadPackable<UpdateBuff>();
						}
						break;
					}
					case 6:
					{
						bool flag8 = value is UseCard;
						if (flag8)
						{
							reader.ReadPackable<UseCard>(Unsafe.As<ActionCommandBase, UseCard>(ref value));
						}
						else
						{
							value = reader.ReadPackable<UseCard>();
						}
						break;
					}
					case 7:
					{
						bool flag9 = value is Vocal;
						if (flag9)
						{
							reader.ReadPackable<Vocal>(Unsafe.As<ActionCommandBase, Vocal>(ref value));
						}
						else
						{
							value = reader.ReadPackable<Vocal>();
						}
						break;
					}
					default:
						MemoryPackSerializationException.ThrowInvalidTag(tag, typeof(ActionCommandBase));
						break;
					}
				}
			}

			// Token: 0x04000E64 RID: 3684
			private static readonly Dictionary<Type, ushort> __typeToTag = new Dictionary<Type, ushort>(8)
			{
				{
					typeof(ActionAnimation),
					0
				},
				{
					typeof(DamageText),
					1
				},
				{
					typeof(Effect),
					2
				},
				{
					typeof(RemoveBuff),
					3
				},
				{
					typeof(State),
					4
				},
				{
					typeof(UpdateBuff),
					5
				},
				{
					typeof(UseCard),
					6
				},
				{
					typeof(Vocal),
					7
				}
			};
		}
	}
}

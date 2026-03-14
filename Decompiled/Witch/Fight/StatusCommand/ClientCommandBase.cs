using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using Mirror;
using Newtonsoft.Json;
using UnityEngine;

namespace Fight.StatusCommand
{
	// Token: 0x020001DC RID: 476
	[MemoryPackable(GenerateType.Object)]
	[MemoryPackUnion(0, typeof(CurHp))]
	[MemoryPackUnion(1, typeof(Defend))]
	[MemoryPackUnion(2, typeof(MaxHp))]
	[MemoryPackUnion(3, typeof(ToughCount))]
	public abstract class ClientCommandBase : IStatusCommand, IMemoryPackFormatterRegister
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x00086418 File Offset: 0x00084618
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x00086420 File Offset: 0x00084620
		public int Value { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00086429 File Offset: 0x00084629
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x00086431 File Offset: 0x00084631
		public string InstanceId { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0008643A File Offset: 0x0008463A
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00086442 File Offset: 0x00084642
		public string From { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0008644B File Offset: 0x0008464B
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x00086453 File Offset: 0x00084653
		[JsonRequired]
		protected bool Identity { get; set; }

		// Token: 0x06001077 RID: 4215 RVA: 0x000026D9 File Offset: 0x000008D9
		protected virtual void InternalExecute()
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0008645C File Offset: 0x0008465C
		[Server]
		public void Validate()
		{
			if (!NetworkServer.active)
			{
				Debug.LogWarning("[Server] function 'System.Void Fight.StatusCommand.ClientCommandBase::Validate()' called when server was not active");
				return;
			}
			this.Identity = true;
		}

		/// <summary>
		/// 在客户端中创建
		/// </summary>
		/// <param name="value"></param>
		/// <param name="instanceId"></param>
		// Token: 0x06001079 RID: 4217 RVA: 0x0008647C File Offset: 0x0008467C
		[Client]
		public ClientCommandBase Create(int value, string instanceId)
		{
			if (!NetworkClient.active)
			{
				Debug.LogWarning("[Client] function 'Fight.StatusCommand.ClientCommandBase Fight.StatusCommand.ClientCommandBase::Create(System.Int32,System.String)' called when client was not active");
				return null;
			}
			this.Value = value;
			this.InstanceId = instanceId;
			this.From = PlayerManager.Instance.PlayerId;
			this.Type = base.GetType().FullName;
			return this;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x000864E4 File Offset: 0x000846E4
		[Client]
		public void Execute()
		{
			if (!NetworkClient.active)
			{
				Debug.LogWarning("[Client] function 'System.Void Fight.StatusCommand.ClientCommandBase::Execute()' called when client was not active");
				return;
			}
			bool flag = this.isExecuted;
			if (flag)
			{
				Debug.LogError("Command already executed.");
			}
			else
			{
				this.isExecuted = true;
				bool identity = this.Identity;
				if (identity)
				{
					this.InternalExecute();
				}
				else
				{
					Debug.LogError("Not authorized to execute this command.");
				}
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00086548 File Offset: 0x00084748
		public ClientCommandBase CopyFrom(ClientCommandBase origin)
		{
			this.From = origin.From;
			this.InstanceId = origin.InstanceId;
			this.Type = origin.Type;
			this.Identity = origin.Identity;
			this.Value = origin.Value;
			return this;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0008659B File Offset: 0x0008479B
		protected void Replace(StatusDataTransfer value)
		{
			FightManager.Instance.statusData.Remove(this.InstanceId);
			FightManager.Instance.statusData.Add(this.InstanceId, value);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000865CB File Offset: 0x000847CB
		static ClientCommandBase()
		{
			ClientCommandBase.RegisterFormatter();
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x000865D4 File Offset: 0x000847D4
		[Preserve]
		public static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<ClientCommandBase>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<ClientCommandBase>(new ClientCommandBase.ClientCommandBaseFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<ClientCommandBase[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<ClientCommandBase[]>(new ArrayFormatter<ClientCommandBase>());
			}
		}

		// Token: 0x04000E49 RID: 3657
		public string Type;

		// Token: 0x04000E4E RID: 3662
		private bool isExecuted = false;

		// Token: 0x020001DD RID: 477
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class ClientCommandBaseFormatter : MemoryPackFormatter<ClientCommandBase>
		{
			// Token: 0x06001080 RID: 4224 RVA: 0x00086624 File Offset: 0x00084824
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref ClientCommandBase value)
			{
				bool flag = value == null;
				if (flag)
				{
					writer.WriteNullUnionHeader();
				}
				else
				{
					ushort tag;
					bool flag2 = ClientCommandBase.ClientCommandBaseFormatter.__typeToTag.TryGetValue(value.GetType(), out tag);
					if (flag2)
					{
						writer.WriteUnionHeader(tag);
						switch (tag)
						{
						case 0:
							writer.WritePackable<CurHp>(Unsafe.As<ClientCommandBase, CurHp>(ref value));
							break;
						case 1:
							writer.WritePackable<Defend>(Unsafe.As<ClientCommandBase, Defend>(ref value));
							break;
						case 2:
							writer.WritePackable<MaxHp>(Unsafe.As<ClientCommandBase, MaxHp>(ref value));
							break;
						case 3:
							writer.WritePackable<ToughCount>(Unsafe.As<ClientCommandBase, ToughCount>(ref value));
							break;
						}
					}
					else
					{
						MemoryPackSerializationException.ThrowNotFoundInUnionType(value.GetType(), typeof(ClientCommandBase));
					}
				}
			}

			// Token: 0x06001081 RID: 4225 RVA: 0x000866E0 File Offset: 0x000848E0
			[NullableContext(2)]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref ClientCommandBase value)
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
						bool flag2 = value is CurHp;
						if (flag2)
						{
							reader.ReadPackable<CurHp>(Unsafe.As<ClientCommandBase, CurHp>(ref value));
						}
						else
						{
							value = reader.ReadPackable<CurHp>();
						}
						break;
					}
					case 1:
					{
						bool flag3 = value is Defend;
						if (flag3)
						{
							reader.ReadPackable<Defend>(Unsafe.As<ClientCommandBase, Defend>(ref value));
						}
						else
						{
							value = reader.ReadPackable<Defend>();
						}
						break;
					}
					case 2:
					{
						bool flag4 = value is MaxHp;
						if (flag4)
						{
							reader.ReadPackable<MaxHp>(Unsafe.As<ClientCommandBase, MaxHp>(ref value));
						}
						else
						{
							value = reader.ReadPackable<MaxHp>();
						}
						break;
					}
					case 3:
					{
						bool flag5 = value is ToughCount;
						if (flag5)
						{
							reader.ReadPackable<ToughCount>(Unsafe.As<ClientCommandBase, ToughCount>(ref value));
						}
						else
						{
							value = reader.ReadPackable<ToughCount>();
						}
						break;
					}
					default:
						MemoryPackSerializationException.ThrowInvalidTag(tag, typeof(ClientCommandBase));
						break;
					}
				}
			}

			// Token: 0x04000E4F RID: 3663
			private static readonly Dictionary<Type, ushort> __typeToTag = new Dictionary<Type, ushort>(4)
			{
				{
					typeof(CurHp),
					0
				},
				{
					typeof(Defend),
					1
				},
				{
					typeof(MaxHp),
					2
				},
				{
					typeof(ToughCount),
					3
				}
			};
		}
	}
}

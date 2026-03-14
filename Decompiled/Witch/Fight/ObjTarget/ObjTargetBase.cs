using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using Mirror;
using Newtonsoft.Json;
using UnityEngine;

namespace Fight.ObjTarget
{
	// Token: 0x020001E9 RID: 489
	[MemoryPackable(GenerateType.Object)]
	[MemoryPackUnion(0, typeof(ObjTargetAction))]
	public abstract class ObjTargetBase : IStatusCommand, IMemoryPackFormatterRegister
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00087D18 File Offset: 0x00085F18
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x00087D20 File Offset: 0x00085F20
		public string Value { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00087D29 File Offset: 0x00085F29
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00087D31 File Offset: 0x00085F31
		public string InstanceId { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00087D3A File Offset: 0x00085F3A
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00087D42 File Offset: 0x00085F42
		public string From { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00087D4B File Offset: 0x00085F4B
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x00087D53 File Offset: 0x00085F53
		[JsonProperty]
		protected bool Identity { get; set; }

		// Token: 0x060010BB RID: 4283 RVA: 0x000026D9 File Offset: 0x000008D9
		protected virtual void InternalExecute()
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00087D5C File Offset: 0x00085F5C
		public void Validate()
		{
			this.Identity = true;
		}

		/// <summary>
		/// 在客户端中创建
		/// </summary>
		/// <param name="value"></param>
		/// <param name="instanceId"></param>
		// Token: 0x060010BD RID: 4285 RVA: 0x00087D68 File Offset: 0x00085F68
		[TargetRpc]
		public ObjTargetBase Create(string instanceId, string ObjAction, string fromId, string theData, params string[] Vars)
		{
			this.ThisVars = Vars;
			this.InstanceId = instanceId;
			this.From = PlayerManager.Instance.PlayerId;
			this.Type = base.GetType().FullName;
			this.ToAction = ObjAction;
			this.FromDataConfigId = fromId;
			this.theData = theData;
			return this;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00087DC4 File Offset: 0x00085FC4
		[TargetRpc]
		public void Execute()
		{
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

		// Token: 0x060010BF RID: 4287 RVA: 0x00087E14 File Offset: 0x00086014
		public ObjTargetBase CopyFrom(ObjTargetBase origin)
		{
			this.From = origin.From;
			this.InstanceId = origin.InstanceId;
			this.Type = origin.Type;
			this.Identity = origin.Identity;
			this.ToAction = origin.ToAction;
			this.Value = origin.Value;
			this.ThisVars = origin.ThisVars;
			this.theData = origin.theData;
			this.FromDataConfigId = origin.FromDataConfigId;
			return this;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00087E97 File Offset: 0x00086097
		protected void Replace(StatusDataTransfer value)
		{
			FightManager.Instance.statusData.Remove(this.InstanceId);
			FightManager.Instance.statusData.Add(this.InstanceId, value);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00087EC7 File Offset: 0x000860C7
		static ObjTargetBase()
		{
			ObjTargetBase.RegisterFormatter();
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00087ED0 File Offset: 0x000860D0
		[Preserve]
		public static void RegisterFormatter()
		{
			bool flag = !MemoryPackFormatterProvider.IsRegistered<ObjTargetBase>();
			if (flag)
			{
				MemoryPackFormatterProvider.Register<ObjTargetBase>(new ObjTargetBase.ObjTargetBaseFormatter());
			}
			bool flag2 = !MemoryPackFormatterProvider.IsRegistered<ObjTargetBase[]>();
			if (flag2)
			{
				MemoryPackFormatterProvider.Register<ObjTargetBase[]>(new ArrayFormatter<ObjTargetBase>());
			}
		}

		// Token: 0x04000E50 RID: 3664
		public string Type;

		// Token: 0x04000E54 RID: 3668
		public string FromDataConfigId;

		// Token: 0x04000E55 RID: 3669
		public string ToAction;

		// Token: 0x04000E56 RID: 3670
		public string theData;

		// Token: 0x04000E58 RID: 3672
		private bool isExecuted = false;

		// Token: 0x04000E59 RID: 3673
		public string[] ThisVars;

		// Token: 0x020001EA RID: 490
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Preserve]
		private sealed class ObjTargetBaseFormatter : MemoryPackFormatter<ObjTargetBase>
		{
			// Token: 0x060010C4 RID: 4292 RVA: 0x00087F20 File Offset: 0x00086120
			[Preserve]
			public override void Serialize<TBufferWriter>([Nullable(new byte[]
			{
				0,
				1
			})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref ObjTargetBase value)
			{
				bool flag = value == null;
				if (flag)
				{
					writer.WriteNullUnionHeader();
				}
				else
				{
					ushort tag;
					bool flag2 = ObjTargetBase.ObjTargetBaseFormatter.__typeToTag.TryGetValue(value.GetType(), out tag);
					if (flag2)
					{
						writer.WriteUnionHeader(tag);
						ushort num = tag;
						ushort num2 = num;
						if (num2 == 0)
						{
							writer.WritePackable<ObjTargetAction>(Unsafe.As<ObjTargetBase, ObjTargetAction>(ref value));
						}
					}
					else
					{
						MemoryPackSerializationException.ThrowNotFoundInUnionType(value.GetType(), typeof(ObjTargetBase));
					}
				}
			}

			// Token: 0x060010C5 RID: 4293 RVA: 0x00087F9C File Offset: 0x0008619C
			[NullableContext(2)]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref ObjTargetBase value)
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
						MemoryPackSerializationException.ThrowInvalidTag(tag, typeof(ObjTargetBase));
					}
					else
					{
						bool flag2 = value is ObjTargetAction;
						if (flag2)
						{
							reader.ReadPackable<ObjTargetAction>(Unsafe.As<ObjTargetBase, ObjTargetAction>(ref value));
						}
						else
						{
							value = reader.ReadPackable<ObjTargetAction>();
						}
					}
				}
			}

			// Token: 0x04000E5A RID: 3674
			private static readonly Dictionary<Type, ushort> __typeToTag = new Dictionary<Type, ushort>(1)
			{
				{
					typeof(ObjTargetAction),
					0
				}
			};
		}
	}
}

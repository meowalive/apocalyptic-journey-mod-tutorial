using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Fight.ActionCommand;
using Fight.ObjTarget;
using Fight.StatusCommand;
using Network.Command;
using Network.Query;
using UnityEditor;
using UnityEngine;

namespace Mirror
{
	// Token: 0x0200037D RID: 893
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	public static class GeneratedNetworkCode
	{
		// Token: 0x06001BFC RID: 7164 RVA: 0x000EF7A8 File Offset: 0x000ED9A8
		public static TimeSnapshotMessage TimeSnapshotMessage(NetworkReader reader)
		{
			return default(TimeSnapshotMessage);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000EF7C0 File Offset: 0x000ED9C0
		public static void TimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value)
		{
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000EF7D0 File Offset: 0x000ED9D0
		public static ReadyMessage ReadyMessage(NetworkReader reader)
		{
			return default(ReadyMessage);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x000EF7E8 File Offset: 0x000ED9E8
		public static void ReadyMessage(NetworkWriter writer, ReadyMessage value)
		{
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000EF7F8 File Offset: 0x000ED9F8
		public static NotReadyMessage NotReadyMessage(NetworkReader reader)
		{
			return default(NotReadyMessage);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x000EF810 File Offset: 0x000EDA10
		public static void NotReadyMessage(NetworkWriter writer, NotReadyMessage value)
		{
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000EF820 File Offset: 0x000EDA20
		public static AddPlayerMessage AddPlayerMessage(NetworkReader reader)
		{
			return default(AddPlayerMessage);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000EF838 File Offset: 0x000EDA38
		public static void AddPlayerMessage(NetworkWriter writer, AddPlayerMessage value)
		{
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000EF848 File Offset: 0x000EDA48
		public static SceneMessage SceneMessage(NetworkReader reader)
		{
			return new SceneMessage
			{
				sceneName = reader.ReadString(),
				sceneOperation = GeneratedNetworkCode._Read_Mirror.SceneOperation(reader),
				customHandling = reader.ReadBool()
			};
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000EF890 File Offset: 0x000EDA90
		public static SceneOperation SceneOperation(NetworkReader reader)
		{
			return (SceneOperation)reader.ReadByte();
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x000EF8A4 File Offset: 0x000EDAA4
		public static void SceneMessage(NetworkWriter writer, SceneMessage value)
		{
			writer.WriteString(value.sceneName);
			GeneratedNetworkCode._Write_Mirror.SceneOperation(writer, value.sceneOperation);
			writer.WriteBool(value.customHandling);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x000EF8D8 File Offset: 0x000EDAD8
		public static void SceneOperation(NetworkWriter writer, SceneOperation value)
		{
			writer.WriteByte((byte)value);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x000EF8EC File Offset: 0x000EDAEC
		public static CommandMessage CommandMessage(NetworkReader reader)
		{
			return new CommandMessage
			{
				netId = reader.ReadVarUInt(),
				componentIndex = reader.ReadByte(),
				functionHash = reader.ReadUShort(),
				payload = reader.ReadArraySegmentAndSize()
			};
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x000EF940 File Offset: 0x000EDB40
		public static void CommandMessage(NetworkWriter writer, CommandMessage value)
		{
			writer.WriteVarUInt(value.netId);
			writer.WriteByte(value.componentIndex);
			writer.WriteUShort(value.functionHash);
			writer.WriteArraySegmentAndSize(value.payload);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x000EF980 File Offset: 0x000EDB80
		public static RpcMessage RpcMessage(NetworkReader reader)
		{
			return new RpcMessage
			{
				netId = reader.ReadVarUInt(),
				componentIndex = reader.ReadByte(),
				functionHash = reader.ReadUShort(),
				payload = reader.ReadArraySegmentAndSize()
			};
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000EF9D4 File Offset: 0x000EDBD4
		public static void RpcMessage(NetworkWriter writer, RpcMessage value)
		{
			writer.WriteVarUInt(value.netId);
			writer.WriteByte(value.componentIndex);
			writer.WriteUShort(value.functionHash);
			writer.WriteArraySegmentAndSize(value.payload);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x000EFA14 File Offset: 0x000EDC14
		public static SpawnMessage SpawnMessage(NetworkReader reader)
		{
			return new SpawnMessage
			{
				netId = reader.ReadVarUInt(),
				spawnFlags = GeneratedNetworkCode._Read_Mirror.SpawnFlags(reader),
				sceneId = reader.ReadVarULong(),
				assetId = reader.ReadVarUInt(),
				position = reader.ReadVector3(),
				rotation = reader.ReadQuaternion(),
				scale = reader.ReadVector3(),
				payload = reader.ReadArraySegmentAndSize()
			};
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000EFAA4 File Offset: 0x000EDCA4
		public static SpawnFlags SpawnFlags(NetworkReader reader)
		{
			return (SpawnFlags)reader.ReadByte();
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000EFAB8 File Offset: 0x000EDCB8
		public static void SpawnMessage(NetworkWriter writer, SpawnMessage value)
		{
			writer.WriteVarUInt(value.netId);
			GeneratedNetworkCode._Write_Mirror.SpawnFlags(writer, value.spawnFlags);
			writer.WriteVarULong(value.sceneId);
			writer.WriteVarUInt(value.assetId);
			writer.WriteVector3(value.position);
			writer.WriteQuaternion(value.rotation);
			writer.WriteVector3(value.scale);
			writer.WriteArraySegmentAndSize(value.payload);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000EFB28 File Offset: 0x000EDD28
		public static void SpawnFlags(NetworkWriter writer, SpawnFlags value)
		{
			writer.WriteByte((byte)value);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000EFB3C File Offset: 0x000EDD3C
		public static ChangeOwnerMessage ChangeOwnerMessage(NetworkReader reader)
		{
			return new ChangeOwnerMessage
			{
				netId = reader.ReadVarUInt(),
				spawnFlags = GeneratedNetworkCode._Read_Mirror.SpawnFlags(reader)
			};
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000EFB74 File Offset: 0x000EDD74
		public static void ChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value)
		{
			writer.WriteVarUInt(value.netId);
			GeneratedNetworkCode._Write_Mirror.SpawnFlags(writer, value.spawnFlags);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000EFB9C File Offset: 0x000EDD9C
		public static ObjectSpawnStartedMessage ObjectSpawnStartedMessage(NetworkReader reader)
		{
			return default(ObjectSpawnStartedMessage);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000EFBB4 File Offset: 0x000EDDB4
		public static void ObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value)
		{
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000EFBC4 File Offset: 0x000EDDC4
		public static ObjectSpawnFinishedMessage ObjectSpawnFinishedMessage(NetworkReader reader)
		{
			return default(ObjectSpawnFinishedMessage);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000EFBDC File Offset: 0x000EDDDC
		public static void ObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value)
		{
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000EFBEC File Offset: 0x000EDDEC
		public static ObjectDestroyMessage ObjectDestroyMessage(NetworkReader reader)
		{
			return new ObjectDestroyMessage
			{
				netId = reader.ReadVarUInt()
			};
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000EFC14 File Offset: 0x000EDE14
		public static void ObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value)
		{
			writer.WriteVarUInt(value.netId);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000EFC30 File Offset: 0x000EDE30
		public static ObjectHideMessage ObjectHideMessage(NetworkReader reader)
		{
			return new ObjectHideMessage
			{
				netId = reader.ReadVarUInt()
			};
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000EFC58 File Offset: 0x000EDE58
		public static void ObjectHideMessage(NetworkWriter writer, ObjectHideMessage value)
		{
			writer.WriteVarUInt(value.netId);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000EFC74 File Offset: 0x000EDE74
		public static EntityStateMessage EntityStateMessage(NetworkReader reader)
		{
			return new EntityStateMessage
			{
				netId = reader.ReadVarUInt(),
				payload = reader.ReadArraySegmentAndSize()
			};
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000EFCAC File Offset: 0x000EDEAC
		public static void EntityStateMessage(NetworkWriter writer, EntityStateMessage value)
		{
			writer.WriteVarUInt(value.netId);
			writer.WriteArraySegmentAndSize(value.payload);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000EFCD4 File Offset: 0x000EDED4
		public static NetworkPingMessage NetworkPingMessage(NetworkReader reader)
		{
			return new NetworkPingMessage
			{
				localTime = reader.ReadDouble(),
				predictedTimeAdjusted = reader.ReadDouble()
			};
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000EFD0C File Offset: 0x000EDF0C
		public static void NetworkPingMessage(NetworkWriter writer, NetworkPingMessage value)
		{
			writer.WriteDouble(value.localTime);
			writer.WriteDouble(value.predictedTimeAdjusted);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000EFD34 File Offset: 0x000EDF34
		public static NetworkPongMessage NetworkPongMessage(NetworkReader reader)
		{
			return new NetworkPongMessage
			{
				localTime = reader.ReadDouble(),
				predictionErrorUnadjusted = reader.ReadDouble(),
				predictionErrorAdjusted = reader.ReadDouble()
			};
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000EFD7C File Offset: 0x000EDF7C
		public static void NetworkPongMessage(NetworkWriter writer, NetworkPongMessage value)
		{
			writer.WriteDouble(value.localTime);
			writer.WriteDouble(value.predictionErrorUnadjusted);
			writer.WriteDouble(value.predictionErrorAdjusted);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000EFDB0 File Offset: 0x000EDFB0
		public static void String[](NetworkWriter writer, string[] value)
		{
			writer.WriteArray(value);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x000EFDC4 File Offset: 0x000EDFC4
		public static string[] String[](NetworkReader reader)
		{
			return reader.ReadArray<string>();
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000EFDD8 File Offset: 0x000EDFD8
		public static void _Write_StatusDataTransfer(NetworkWriter writer, StatusDataTransfer value)
		{
			if (value == null)
			{
				writer.WriteBool(false);
				return;
			}
			writer.WriteBool(true);
			writer.WriteVarInt(value.maxHp);
			writer.WriteVarInt(value.curHp);
			writer.WriteVarInt(value.defend);
			writer.WriteVarInt(value._toughCount);
			writer.WriteVarInt(value.ToughOrigin);
			writer.WriteString(value.InstanceId);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000EFE44 File Offset: 0x000EE044
		public static StatusDataTransfer _Read_StatusDataTransfer(NetworkReader reader)
		{
			if (!reader.ReadBool())
			{
				return null;
			}
			return new StatusDataTransfer
			{
				maxHp = reader.ReadVarInt(),
				curHp = reader.ReadVarInt(),
				defend = reader.ReadVarInt(),
				_toughCount = reader.ReadVarInt(),
				ToughOrigin = reader.ReadVarInt(),
				InstanceId = reader.ReadString()
			};
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000EFEC0 File Offset: 0x000EE0C0
		public static void _Write_FightType(NetworkWriter writer, FightType value)
		{
			writer.WriteVarInt((int)value);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000EFED4 File Offset: 0x000EE0D4
		public static FightType _Read_FightType(NetworkReader reader)
		{
			return (FightType)reader.ReadVarInt();
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000EFEE8 File Offset: 0x000EE0E8
		public static void _Write_LobbyInfo/PlayerInfo(NetworkWriter writer, LobbyInfo.PlayerInfo value)
		{
			if (value == null)
			{
				writer.WriteBool(false);
				return;
			}
			writer.WriteBool(true);
			writer.WriteString(value.Name);
			writer.WriteString(value.Id);
			writer.WriteBool(value.IsSyncedRole);
			writer.WriteString(value.Version);
			GeneratedNetworkCode._Write_ModConfig[](writer, value.Mods);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000EFF48 File Offset: 0x000EE148
		public static void _Write_ModConfig[](NetworkWriter writer, ModConfig[] value)
		{
			writer.WriteArray(value);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000EFF5C File Offset: 0x000EE15C
		public static void _Write_ModConfig(NetworkWriter writer, ModConfig value)
		{
			if (value == null)
			{
				writer.WriteBool(false);
				return;
			}
			writer.WriteBool(true);
			writer.WriteString(value.DirectoryName);
			writer.WriteString(value.ModName);
			writer.WriteString(value.ModVersion);
			writer.WriteString(value.ModAuthor);
			writer.WriteString(value.ModDescription);
			writer.WriteString(value.IconPath);
			writer.WriteBool(value.Enabled);
			GeneratedNetworkCode._Write_System.Collections.Generic.List`1<System.String>(writer, value.Dependencies);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000EFFE0 File Offset: 0x000EE1E0
		public static void List(NetworkWriter writer, List<string> value)
		{
			writer.WriteList(value);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000EFFF4 File Offset: 0x000EE1F4
		public static LobbyInfo.PlayerInfo _Read_LobbyInfo/PlayerInfo(NetworkReader reader)
		{
			if (!reader.ReadBool())
			{
				return null;
			}
			return new LobbyInfo.PlayerInfo
			{
				Name = reader.ReadString(),
				Id = reader.ReadString(),
				IsSyncedRole = reader.ReadBool(),
				Version = reader.ReadString(),
				Mods = GeneratedNetworkCode._Read_ModConfig[](reader)
			};
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x000F0064 File Offset: 0x000EE264
		public static ModConfig[] _Read_ModConfig[](NetworkReader reader)
		{
			return reader.ReadArray<ModConfig>();
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000F0078 File Offset: 0x000EE278
		public static ModConfig _Read_ModConfig(NetworkReader reader)
		{
			if (!reader.ReadBool())
			{
				return null;
			}
			return new ModConfig
			{
				DirectoryName = reader.ReadString(),
				ModName = reader.ReadString(),
				ModVersion = reader.ReadString(),
				ModAuthor = reader.ReadString(),
				ModDescription = reader.ReadString(),
				IconPath = reader.ReadString(),
				Enabled = reader.ReadBool(),
				Dependencies = GeneratedNetworkCode._Read_System.Collections.Generic.List`1<System.String>(reader)
			};
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x000F0114 File Offset: 0x000EE314
		public static List<string> List(NetworkReader reader)
		{
			return reader.ReadList<string>();
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x000F0128 File Offset: 0x000EE328
		public static void List(NetworkWriter writer, List<LobbyInfo.PlayerInfo> value)
		{
			writer.WriteList(value);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x000F013C File Offset: 0x000EE33C
		public static List<LobbyInfo.PlayerInfo> List(NetworkReader reader)
		{
			return reader.ReadList<LobbyInfo.PlayerInfo>();
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x000F0150 File Offset: 0x000EE350
		public static void _Write_LobbyInfo(NetworkWriter writer, LobbyInfo value)
		{
			if (value == null)
			{
				writer.WriteBool(false);
				return;
			}
			writer.WriteBool(true);
			GeneratedNetworkCode._Write_System.Collections.Generic.List`1<LobbyInfo/PlayerInfo>(writer, value.AddedPlayers);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000F0180 File Offset: 0x000EE380
		public static LobbyInfo _Read_LobbyInfo(NetworkReader reader)
		{
			if (!reader.ReadBool())
			{
				return null;
			}
			return new LobbyInfo
			{
				AddedPlayers = GeneratedNetworkCode._Read_System.Collections.Generic.List`1<LobbyInfo/PlayerInfo>(reader)
			};
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000F01B4 File Offset: 0x000EE3B4
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		[InitializeOnLoadMethod]
		public static void InitReadWriters()
		{
			Writer<byte>.write = new Action<NetworkWriter, byte>(NetworkWriterExtensions.WriteByte);
			Writer<byte?>.write = new Action<NetworkWriter, byte?>(NetworkWriterExtensions.WriteByteNullable);
			Writer<sbyte>.write = new Action<NetworkWriter, sbyte>(NetworkWriterExtensions.WriteSByte);
			Writer<sbyte?>.write = new Action<NetworkWriter, sbyte?>(NetworkWriterExtensions.WriteSByteNullable);
			Writer<char>.write = new Action<NetworkWriter, char>(NetworkWriterExtensions.WriteChar);
			Writer<char?>.write = new Action<NetworkWriter, char?>(NetworkWriterExtensions.WriteCharNullable);
			Writer<bool>.write = new Action<NetworkWriter, bool>(NetworkWriterExtensions.WriteBool);
			Writer<bool?>.write = new Action<NetworkWriter, bool?>(NetworkWriterExtensions.WriteBoolNullable);
			Writer<short>.write = new Action<NetworkWriter, short>(NetworkWriterExtensions.WriteShort);
			Writer<short?>.write = new Action<NetworkWriter, short?>(NetworkWriterExtensions.WriteShortNullable);
			Writer<ushort>.write = new Action<NetworkWriter, ushort>(NetworkWriterExtensions.WriteUShort);
			Writer<ushort?>.write = new Action<NetworkWriter, ushort?>(NetworkWriterExtensions.WriteUShortNullable);
			Writer<int>.write = new Action<NetworkWriter, int>(NetworkWriterExtensions.WriteVarInt);
			Writer<int?>.write = new Action<NetworkWriter, int?>(NetworkWriterExtensions.WriteIntNullable);
			Writer<uint>.write = new Action<NetworkWriter, uint>(NetworkWriterExtensions.WriteVarUInt);
			Writer<uint?>.write = new Action<NetworkWriter, uint?>(NetworkWriterExtensions.WriteUIntNullable);
			Writer<long>.write = new Action<NetworkWriter, long>(NetworkWriterExtensions.WriteVarLong);
			Writer<long?>.write = new Action<NetworkWriter, long?>(NetworkWriterExtensions.WriteLongNullable);
			Writer<ulong>.write = new Action<NetworkWriter, ulong>(NetworkWriterExtensions.WriteVarULong);
			Writer<ulong?>.write = new Action<NetworkWriter, ulong?>(NetworkWriterExtensions.WriteULongNullable);
			Writer<float>.write = new Action<NetworkWriter, float>(NetworkWriterExtensions.WriteFloat);
			Writer<float?>.write = new Action<NetworkWriter, float?>(NetworkWriterExtensions.WriteFloatNullable);
			Writer<double>.write = new Action<NetworkWriter, double>(NetworkWriterExtensions.WriteDouble);
			Writer<double?>.write = new Action<NetworkWriter, double?>(NetworkWriterExtensions.WriteDoubleNullable);
			Writer<decimal>.write = new Action<NetworkWriter, decimal>(NetworkWriterExtensions.WriteDecimal);
			Writer<decimal?>.write = new Action<NetworkWriter, decimal?>(NetworkWriterExtensions.WriteDecimalNullable);
			Writer<Half>.write = new Action<NetworkWriter, Half>(NetworkWriterExtensions.WriteHalf);
			Writer<string>.write = new Action<NetworkWriter, string>(NetworkWriterExtensions.WriteString);
			Writer<byte[]>.write = new Action<NetworkWriter, byte[]>(NetworkWriterExtensions.WriteBytesAndSize);
			Writer<ArraySegment<byte>>.write = new Action<NetworkWriter, ArraySegment<byte>>(NetworkWriterExtensions.WriteArraySegmentAndSize);
			Writer<Vector2>.write = new Action<NetworkWriter, Vector2>(NetworkWriterExtensions.WriteVector2);
			Writer<Vector2?>.write = new Action<NetworkWriter, Vector2?>(NetworkWriterExtensions.WriteVector2Nullable);
			Writer<Vector3>.write = new Action<NetworkWriter, Vector3>(NetworkWriterExtensions.WriteVector3);
			Writer<Vector3?>.write = new Action<NetworkWriter, Vector3?>(NetworkWriterExtensions.WriteVector3Nullable);
			Writer<Vector4>.write = new Action<NetworkWriter, Vector4>(NetworkWriterExtensions.WriteVector4);
			Writer<Vector4?>.write = new Action<NetworkWriter, Vector4?>(NetworkWriterExtensions.WriteVector4Nullable);
			Writer<Vector2Int>.write = new Action<NetworkWriter, Vector2Int>(NetworkWriterExtensions.WriteVector2Int);
			Writer<Vector2Int?>.write = new Action<NetworkWriter, Vector2Int?>(NetworkWriterExtensions.WriteVector2IntNullable);
			Writer<Vector3Int>.write = new Action<NetworkWriter, Vector3Int>(NetworkWriterExtensions.WriteVector3Int);
			Writer<Vector3Int?>.write = new Action<NetworkWriter, Vector3Int?>(NetworkWriterExtensions.WriteVector3IntNullable);
			Writer<Color>.write = new Action<NetworkWriter, Color>(NetworkWriterExtensions.WriteColor);
			Writer<Color?>.write = new Action<NetworkWriter, Color?>(NetworkWriterExtensions.WriteColorNullable);
			Writer<Color32>.write = new Action<NetworkWriter, Color32>(NetworkWriterExtensions.WriteColor32);
			Writer<Color32?>.write = new Action<NetworkWriter, Color32?>(NetworkWriterExtensions.WriteColor32Nullable);
			Writer<Quaternion>.write = new Action<NetworkWriter, Quaternion>(NetworkWriterExtensions.WriteQuaternion);
			Writer<Quaternion?>.write = new Action<NetworkWriter, Quaternion?>(NetworkWriterExtensions.WriteQuaternionNullable);
			Writer<Rect>.write = new Action<NetworkWriter, Rect>(NetworkWriterExtensions.WriteRect);
			Writer<Rect?>.write = new Action<NetworkWriter, Rect?>(NetworkWriterExtensions.WriteRectNullable);
			Writer<Plane>.write = new Action<NetworkWriter, Plane>(NetworkWriterExtensions.WritePlane);
			Writer<Plane?>.write = new Action<NetworkWriter, Plane?>(NetworkWriterExtensions.WritePlaneNullable);
			Writer<Ray>.write = new Action<NetworkWriter, Ray>(NetworkWriterExtensions.WriteRay);
			Writer<Ray?>.write = new Action<NetworkWriter, Ray?>(NetworkWriterExtensions.WriteRayNullable);
			Writer<LayerMask>.write = new Action<NetworkWriter, LayerMask>(NetworkWriterExtensions.WriteLayerMask);
			Writer<LayerMask?>.write = new Action<NetworkWriter, LayerMask?>(NetworkWriterExtensions.WriteLayerMaskNullable);
			Writer<Matrix4x4>.write = new Action<NetworkWriter, Matrix4x4>(NetworkWriterExtensions.WriteMatrix4x4);
			Writer<Matrix4x4?>.write = new Action<NetworkWriter, Matrix4x4?>(NetworkWriterExtensions.WriteMatrix4x4Nullable);
			Writer<Guid>.write = new Action<NetworkWriter, Guid>(NetworkWriterExtensions.WriteGuid);
			Writer<Guid?>.write = new Action<NetworkWriter, Guid?>(NetworkWriterExtensions.WriteGuidNullable);
			Writer<NetworkIdentity>.write = new Action<NetworkWriter, NetworkIdentity>(NetworkWriterExtensions.WriteNetworkIdentity);
			Writer<NetworkBehaviour>.write = new Action<NetworkWriter, NetworkBehaviour>(NetworkWriterExtensions.WriteNetworkBehaviour);
			Writer<Transform>.write = new Action<NetworkWriter, Transform>(NetworkWriterExtensions.WriteTransform);
			Writer<GameObject>.write = new Action<NetworkWriter, GameObject>(NetworkWriterExtensions.WriteGameObject);
			Writer<Uri>.write = new Action<NetworkWriter, Uri>(NetworkWriterExtensions.WriteUri);
			Writer<Texture2D>.write = new Action<NetworkWriter, Texture2D>(NetworkWriterExtensions.WriteTexture2D);
			Writer<Sprite>.write = new Action<NetworkWriter, Sprite>(NetworkWriterExtensions.WriteSprite);
			Writer<DateTime>.write = new Action<NetworkWriter, DateTime>(NetworkWriterExtensions.WriteDateTime);
			Writer<DateTime?>.write = new Action<NetworkWriter, DateTime?>(NetworkWriterExtensions.WriteDateTimeNullable);
			Writer<TimeSnapshotMessage>.write = new Action<NetworkWriter, TimeSnapshotMessage>(GeneratedNetworkCode._Write_Mirror.TimeSnapshotMessage);
			Writer<ReadyMessage>.write = new Action<NetworkWriter, ReadyMessage>(GeneratedNetworkCode._Write_Mirror.ReadyMessage);
			Writer<NotReadyMessage>.write = new Action<NetworkWriter, NotReadyMessage>(GeneratedNetworkCode._Write_Mirror.NotReadyMessage);
			Writer<AddPlayerMessage>.write = new Action<NetworkWriter, AddPlayerMessage>(GeneratedNetworkCode._Write_Mirror.AddPlayerMessage);
			Writer<SceneMessage>.write = new Action<NetworkWriter, SceneMessage>(GeneratedNetworkCode._Write_Mirror.SceneMessage);
			Writer<SceneOperation>.write = new Action<NetworkWriter, SceneOperation>(GeneratedNetworkCode._Write_Mirror.SceneOperation);
			Writer<CommandMessage>.write = new Action<NetworkWriter, CommandMessage>(GeneratedNetworkCode._Write_Mirror.CommandMessage);
			Writer<RpcMessage>.write = new Action<NetworkWriter, RpcMessage>(GeneratedNetworkCode._Write_Mirror.RpcMessage);
			Writer<SpawnMessage>.write = new Action<NetworkWriter, SpawnMessage>(GeneratedNetworkCode._Write_Mirror.SpawnMessage);
			Writer<SpawnFlags>.write = new Action<NetworkWriter, SpawnFlags>(GeneratedNetworkCode._Write_Mirror.SpawnFlags);
			Writer<ChangeOwnerMessage>.write = new Action<NetworkWriter, ChangeOwnerMessage>(GeneratedNetworkCode._Write_Mirror.ChangeOwnerMessage);
			Writer<ObjectSpawnStartedMessage>.write = new Action<NetworkWriter, ObjectSpawnStartedMessage>(GeneratedNetworkCode._Write_Mirror.ObjectSpawnStartedMessage);
			Writer<ObjectSpawnFinishedMessage>.write = new Action<NetworkWriter, ObjectSpawnFinishedMessage>(GeneratedNetworkCode._Write_Mirror.ObjectSpawnFinishedMessage);
			Writer<ObjectDestroyMessage>.write = new Action<NetworkWriter, ObjectDestroyMessage>(GeneratedNetworkCode._Write_Mirror.ObjectDestroyMessage);
			Writer<ObjectHideMessage>.write = new Action<NetworkWriter, ObjectHideMessage>(GeneratedNetworkCode._Write_Mirror.ObjectHideMessage);
			Writer<EntityStateMessage>.write = new Action<NetworkWriter, EntityStateMessage>(GeneratedNetworkCode._Write_Mirror.EntityStateMessage);
			Writer<NetworkPingMessage>.write = new Action<NetworkWriter, NetworkPingMessage>(GeneratedNetworkCode._Write_Mirror.NetworkPingMessage);
			Writer<NetworkPongMessage>.write = new Action<NetworkWriter, NetworkPongMessage>(GeneratedNetworkCode._Write_Mirror.NetworkPongMessage);
			Writer<GifAsset>.write = new Action<NetworkWriter, GifAsset>(GifAssetSerializer.Write);
			Writer<DataConfig>.write = new Action<NetworkWriter, DataConfig>(DataConfigSerializer.WriteDataConfig);
			Writer<RoleTable>.write = new Action<NetworkWriter, RoleTable>(CustomRoleTableReaderWriter.WriteRoleTable);
			Writer<QueryBase>.write = new Action<NetworkWriter, QueryBase>(QueryBaseSerializer.Write);
			Writer<RpcCommandBase>.write = new Action<NetworkWriter, RpcCommandBase>(RpcCommandBaseSerializer.Write);
			Writer<ClientCommandBase>.write = new Action<NetworkWriter, ClientCommandBase>(ClientCommandBaseReaderWriter.Write);
			Writer<ObjTargetBase>.write = new Action<NetworkWriter, ObjTargetBase>(ObjTargetBaseReaderWriter.Write);
			Writer<ActionCommandBase>.write = new Action<NetworkWriter, ActionCommandBase>(ActionCommandBaseReaderWriter.Write);
			Writer<string[]>.write = new Action<NetworkWriter, string[]>(GeneratedNetworkCode._Write_System.String[]);
			Writer<StatusDataTransfer>.write = new Action<NetworkWriter, StatusDataTransfer>(GeneratedNetworkCode._Write_StatusDataTransfer);
			Writer<FightType>.write = new Action<NetworkWriter, FightType>(GeneratedNetworkCode._Write_FightType);
			Writer<LobbyInfo.PlayerInfo>.write = new Action<NetworkWriter, LobbyInfo.PlayerInfo>(GeneratedNetworkCode._Write_LobbyInfo/PlayerInfo);
			Writer<ModConfig[]>.write = new Action<NetworkWriter, ModConfig[]>(GeneratedNetworkCode._Write_ModConfig[]);
			Writer<ModConfig>.write = new Action<NetworkWriter, ModConfig>(GeneratedNetworkCode._Write_ModConfig);
			Writer<List<string>>.write = new Action<NetworkWriter, List<string>>(GeneratedNetworkCode._Write_System.Collections.Generic.List`1<System.String>);
			Writer<List<LobbyInfo.PlayerInfo>>.write = new Action<NetworkWriter, List<LobbyInfo.PlayerInfo>>(GeneratedNetworkCode._Write_System.Collections.Generic.List`1<LobbyInfo/PlayerInfo>);
			Writer<LobbyInfo>.write = new Action<NetworkWriter, LobbyInfo>(GeneratedNetworkCode._Write_LobbyInfo);
			Reader<byte>.read = new Func<NetworkReader, byte>(NetworkReaderExtensions.ReadByte);
			Reader<byte?>.read = new Func<NetworkReader, byte?>(NetworkReaderExtensions.ReadByteNullable);
			Reader<sbyte>.read = new Func<NetworkReader, sbyte>(NetworkReaderExtensions.ReadSByte);
			Reader<sbyte?>.read = new Func<NetworkReader, sbyte?>(NetworkReaderExtensions.ReadSByteNullable);
			Reader<char>.read = new Func<NetworkReader, char>(NetworkReaderExtensions.ReadChar);
			Reader<char?>.read = new Func<NetworkReader, char?>(NetworkReaderExtensions.ReadCharNullable);
			Reader<bool>.read = new Func<NetworkReader, bool>(NetworkReaderExtensions.ReadBool);
			Reader<bool?>.read = new Func<NetworkReader, bool?>(NetworkReaderExtensions.ReadBoolNullable);
			Reader<short>.read = new Func<NetworkReader, short>(NetworkReaderExtensions.ReadShort);
			Reader<short?>.read = new Func<NetworkReader, short?>(NetworkReaderExtensions.ReadShortNullable);
			Reader<ushort>.read = new Func<NetworkReader, ushort>(NetworkReaderExtensions.ReadUShort);
			Reader<ushort?>.read = new Func<NetworkReader, ushort?>(NetworkReaderExtensions.ReadUShortNullable);
			Reader<int>.read = new Func<NetworkReader, int>(NetworkReaderExtensions.ReadVarInt);
			Reader<int?>.read = new Func<NetworkReader, int?>(NetworkReaderExtensions.ReadIntNullable);
			Reader<uint>.read = new Func<NetworkReader, uint>(NetworkReaderExtensions.ReadVarUInt);
			Reader<uint?>.read = new Func<NetworkReader, uint?>(NetworkReaderExtensions.ReadUIntNullable);
			Reader<long>.read = new Func<NetworkReader, long>(NetworkReaderExtensions.ReadVarLong);
			Reader<long?>.read = new Func<NetworkReader, long?>(NetworkReaderExtensions.ReadLongNullable);
			Reader<ulong>.read = new Func<NetworkReader, ulong>(NetworkReaderExtensions.ReadVarULong);
			Reader<ulong?>.read = new Func<NetworkReader, ulong?>(NetworkReaderExtensions.ReadULongNullable);
			Reader<float>.read = new Func<NetworkReader, float>(NetworkReaderExtensions.ReadFloat);
			Reader<float?>.read = new Func<NetworkReader, float?>(NetworkReaderExtensions.ReadFloatNullable);
			Reader<double>.read = new Func<NetworkReader, double>(NetworkReaderExtensions.ReadDouble);
			Reader<double?>.read = new Func<NetworkReader, double?>(NetworkReaderExtensions.ReadDoubleNullable);
			Reader<decimal>.read = new Func<NetworkReader, decimal>(NetworkReaderExtensions.ReadDecimal);
			Reader<decimal?>.read = new Func<NetworkReader, decimal?>(NetworkReaderExtensions.ReadDecimalNullable);
			Reader<Half>.read = new Func<NetworkReader, Half>(NetworkReaderExtensions.ReadHalf);
			Reader<string>.read = new Func<NetworkReader, string>(NetworkReaderExtensions.ReadString);
			Reader<byte[]>.read = new Func<NetworkReader, byte[]>(NetworkReaderExtensions.ReadBytesAndSize);
			Reader<ArraySegment<byte>>.read = new Func<NetworkReader, ArraySegment<byte>>(NetworkReaderExtensions.ReadArraySegmentAndSize);
			Reader<Vector2>.read = new Func<NetworkReader, Vector2>(NetworkReaderExtensions.ReadVector2);
			Reader<Vector2?>.read = new Func<NetworkReader, Vector2?>(NetworkReaderExtensions.ReadVector2Nullable);
			Reader<Vector3>.read = new Func<NetworkReader, Vector3>(NetworkReaderExtensions.ReadVector3);
			Reader<Vector3?>.read = new Func<NetworkReader, Vector3?>(NetworkReaderExtensions.ReadVector3Nullable);
			Reader<Vector4>.read = new Func<NetworkReader, Vector4>(NetworkReaderExtensions.ReadVector4);
			Reader<Vector4?>.read = new Func<NetworkReader, Vector4?>(NetworkReaderExtensions.ReadVector4Nullable);
			Reader<Vector2Int>.read = new Func<NetworkReader, Vector2Int>(NetworkReaderExtensions.ReadVector2Int);
			Reader<Vector2Int?>.read = new Func<NetworkReader, Vector2Int?>(NetworkReaderExtensions.ReadVector2IntNullable);
			Reader<Vector3Int>.read = new Func<NetworkReader, Vector3Int>(NetworkReaderExtensions.ReadVector3Int);
			Reader<Vector3Int?>.read = new Func<NetworkReader, Vector3Int?>(NetworkReaderExtensions.ReadVector3IntNullable);
			Reader<Color>.read = new Func<NetworkReader, Color>(NetworkReaderExtensions.ReadColor);
			Reader<Color?>.read = new Func<NetworkReader, Color?>(NetworkReaderExtensions.ReadColorNullable);
			Reader<Color32>.read = new Func<NetworkReader, Color32>(NetworkReaderExtensions.ReadColor32);
			Reader<Color32?>.read = new Func<NetworkReader, Color32?>(NetworkReaderExtensions.ReadColor32Nullable);
			Reader<Quaternion>.read = new Func<NetworkReader, Quaternion>(NetworkReaderExtensions.ReadQuaternion);
			Reader<Quaternion?>.read = new Func<NetworkReader, Quaternion?>(NetworkReaderExtensions.ReadQuaternionNullable);
			Reader<Rect>.read = new Func<NetworkReader, Rect>(NetworkReaderExtensions.ReadRect);
			Reader<Rect?>.read = new Func<NetworkReader, Rect?>(NetworkReaderExtensions.ReadRectNullable);
			Reader<Plane>.read = new Func<NetworkReader, Plane>(NetworkReaderExtensions.ReadPlane);
			Reader<Plane?>.read = new Func<NetworkReader, Plane?>(NetworkReaderExtensions.ReadPlaneNullable);
			Reader<Ray>.read = new Func<NetworkReader, Ray>(NetworkReaderExtensions.ReadRay);
			Reader<Ray?>.read = new Func<NetworkReader, Ray?>(NetworkReaderExtensions.ReadRayNullable);
			Reader<LayerMask>.read = new Func<NetworkReader, LayerMask>(NetworkReaderExtensions.ReadLayerMask);
			Reader<LayerMask?>.read = new Func<NetworkReader, LayerMask?>(NetworkReaderExtensions.ReadLayerMaskNullable);
			Reader<Matrix4x4>.read = new Func<NetworkReader, Matrix4x4>(NetworkReaderExtensions.ReadMatrix4x4);
			Reader<Matrix4x4?>.read = new Func<NetworkReader, Matrix4x4?>(NetworkReaderExtensions.ReadMatrix4x4Nullable);
			Reader<Guid>.read = new Func<NetworkReader, Guid>(NetworkReaderExtensions.ReadGuid);
			Reader<Guid?>.read = new Func<NetworkReader, Guid?>(NetworkReaderExtensions.ReadGuidNullable);
			Reader<NetworkIdentity>.read = new Func<NetworkReader, NetworkIdentity>(NetworkReaderExtensions.ReadNetworkIdentity);
			Reader<NetworkBehaviour>.read = new Func<NetworkReader, NetworkBehaviour>(NetworkReaderExtensions.ReadNetworkBehaviour);
			Reader<NetworkBehaviourSyncVar>.read = new Func<NetworkReader, NetworkBehaviourSyncVar>(NetworkReaderExtensions.ReadNetworkBehaviourSyncVar);
			Reader<Transform>.read = new Func<NetworkReader, Transform>(NetworkReaderExtensions.ReadTransform);
			Reader<GameObject>.read = new Func<NetworkReader, GameObject>(NetworkReaderExtensions.ReadGameObject);
			Reader<Uri>.read = new Func<NetworkReader, Uri>(NetworkReaderExtensions.ReadUri);
			Reader<Texture2D>.read = new Func<NetworkReader, Texture2D>(NetworkReaderExtensions.ReadTexture2D);
			Reader<Sprite>.read = new Func<NetworkReader, Sprite>(NetworkReaderExtensions.ReadSprite);
			Reader<DateTime>.read = new Func<NetworkReader, DateTime>(NetworkReaderExtensions.ReadDateTime);
			Reader<DateTime?>.read = new Func<NetworkReader, DateTime?>(NetworkReaderExtensions.ReadDateTimeNullable);
			Reader<TimeSnapshotMessage>.read = new Func<NetworkReader, TimeSnapshotMessage>(GeneratedNetworkCode._Read_Mirror.TimeSnapshotMessage);
			Reader<ReadyMessage>.read = new Func<NetworkReader, ReadyMessage>(GeneratedNetworkCode._Read_Mirror.ReadyMessage);
			Reader<NotReadyMessage>.read = new Func<NetworkReader, NotReadyMessage>(GeneratedNetworkCode._Read_Mirror.NotReadyMessage);
			Reader<AddPlayerMessage>.read = new Func<NetworkReader, AddPlayerMessage>(GeneratedNetworkCode._Read_Mirror.AddPlayerMessage);
			Reader<SceneMessage>.read = new Func<NetworkReader, SceneMessage>(GeneratedNetworkCode._Read_Mirror.SceneMessage);
			Reader<SceneOperation>.read = new Func<NetworkReader, SceneOperation>(GeneratedNetworkCode._Read_Mirror.SceneOperation);
			Reader<CommandMessage>.read = new Func<NetworkReader, CommandMessage>(GeneratedNetworkCode._Read_Mirror.CommandMessage);
			Reader<RpcMessage>.read = new Func<NetworkReader, RpcMessage>(GeneratedNetworkCode._Read_Mirror.RpcMessage);
			Reader<SpawnMessage>.read = new Func<NetworkReader, SpawnMessage>(GeneratedNetworkCode._Read_Mirror.SpawnMessage);
			Reader<SpawnFlags>.read = new Func<NetworkReader, SpawnFlags>(GeneratedNetworkCode._Read_Mirror.SpawnFlags);
			Reader<ChangeOwnerMessage>.read = new Func<NetworkReader, ChangeOwnerMessage>(GeneratedNetworkCode._Read_Mirror.ChangeOwnerMessage);
			Reader<ObjectSpawnStartedMessage>.read = new Func<NetworkReader, ObjectSpawnStartedMessage>(GeneratedNetworkCode._Read_Mirror.ObjectSpawnStartedMessage);
			Reader<ObjectSpawnFinishedMessage>.read = new Func<NetworkReader, ObjectSpawnFinishedMessage>(GeneratedNetworkCode._Read_Mirror.ObjectSpawnFinishedMessage);
			Reader<ObjectDestroyMessage>.read = new Func<NetworkReader, ObjectDestroyMessage>(GeneratedNetworkCode._Read_Mirror.ObjectDestroyMessage);
			Reader<ObjectHideMessage>.read = new Func<NetworkReader, ObjectHideMessage>(GeneratedNetworkCode._Read_Mirror.ObjectHideMessage);
			Reader<EntityStateMessage>.read = new Func<NetworkReader, EntityStateMessage>(GeneratedNetworkCode._Read_Mirror.EntityStateMessage);
			Reader<NetworkPingMessage>.read = new Func<NetworkReader, NetworkPingMessage>(GeneratedNetworkCode._Read_Mirror.NetworkPingMessage);
			Reader<NetworkPongMessage>.read = new Func<NetworkReader, NetworkPongMessage>(GeneratedNetworkCode._Read_Mirror.NetworkPongMessage);
			Reader<GifAsset>.read = new Func<NetworkReader, GifAsset>(GifAssetSerializer.Read);
			Reader<DataConfig>.read = new Func<NetworkReader, DataConfig>(DataConfigSerializer.ReadDataConfig);
			Reader<RoleTable>.read = new Func<NetworkReader, RoleTable>(CustomRoleTableReaderWriter.ReadRoleTable);
			Reader<QueryBase>.read = new Func<NetworkReader, QueryBase>(QueryBaseSerializer.Read);
			Reader<RpcCommandBase>.read = new Func<NetworkReader, RpcCommandBase>(RpcCommandBaseSerializer.Read);
			Reader<ClientCommandBase>.read = new Func<NetworkReader, ClientCommandBase>(ClientCommandBaseReaderWriter.Read);
			Reader<ObjTargetBase>.read = new Func<NetworkReader, ObjTargetBase>(ObjTargetBaseReaderWriter.Read);
			Reader<ActionCommandBase>.read = new Func<NetworkReader, ActionCommandBase>(ActionCommandBaseReaderWriter.Read);
			Reader<string[]>.read = new Func<NetworkReader, string[]>(GeneratedNetworkCode._Read_System.String[]);
			Reader<StatusDataTransfer>.read = new Func<NetworkReader, StatusDataTransfer>(GeneratedNetworkCode._Read_StatusDataTransfer);
			Reader<FightType>.read = new Func<NetworkReader, FightType>(GeneratedNetworkCode._Read_FightType);
			Reader<LobbyInfo.PlayerInfo>.read = new Func<NetworkReader, LobbyInfo.PlayerInfo>(GeneratedNetworkCode._Read_LobbyInfo/PlayerInfo);
			Reader<ModConfig[]>.read = new Func<NetworkReader, ModConfig[]>(GeneratedNetworkCode._Read_ModConfig[]);
			Reader<ModConfig>.read = new Func<NetworkReader, ModConfig>(GeneratedNetworkCode._Read_ModConfig);
			Reader<List<string>>.read = new Func<NetworkReader, List<string>>(GeneratedNetworkCode._Read_System.Collections.Generic.List`1<System.String>);
			Reader<List<LobbyInfo.PlayerInfo>>.read = new Func<NetworkReader, List<LobbyInfo.PlayerInfo>>(GeneratedNetworkCode._Read_System.Collections.Generic.List`1<LobbyInfo/PlayerInfo>);
			Reader<LobbyInfo>.read = new Func<NetworkReader, LobbyInfo>(GeneratedNetworkCode._Read_LobbyInfo);
		}
	}
}

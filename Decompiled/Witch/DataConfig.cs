using System;
using System.Buffers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using MemoryPack;
using MemoryPack.Formatters;
using MemoryPack.Internal;
using Newtonsoft.Json;
using UnityEngine;

/// <remarks>
/// MemoryPack GenerateType: Object<br />
/// <code>
/// <b>DataType</b> Type<br />
/// <b>System.Collections.Generic.IDictionary&lt;string, string&gt;</b> Vars<br />
/// </code>
/// </remarks>
// Token: 0x02000035 RID: 53
[MemoryPackable(GenerateType.Object)]
public class DataConfig : ICloneable, IDataConfig, IMemoryPackable<DataConfig>, IMemoryPackFormatterRegister
{
	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000159 RID: 345 RVA: 0x0000CEDE File Offset: 0x0000B0DE
	// (set) Token: 0x0600015A RID: 346 RVA: 0x0000CEE6 File Offset: 0x0000B0E6
	[JsonProperty]
	public DataType Type { get; private set; }

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x0600015B RID: 347 RVA: 0x0000CEEF File Offset: 0x0000B0EF
	// (set) Token: 0x0600015C RID: 348 RVA: 0x0000CEF7 File Offset: 0x0000B0F7
	[JsonIgnore]
	[MemoryPackIgnore]
	public IDictionary<string, string> data
	{
		get
		{
			return this._data;
		}
		set
		{
			this._data = new ReadOnlyDictionary<string, string>(value);
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x0600015D RID: 349 RVA: 0x0000CF05 File Offset: 0x0000B105
	// (set) Token: 0x0600015E RID: 350 RVA: 0x0000CF0D File Offset: 0x0000B10D
	public IDictionary<string, string> Vars
	{
		get
		{
			return this._Vars;
		}
		set
		{
			this._Vars = new Dictionary<string, string>(value);
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x0600015F RID: 351 RVA: 0x0000CF1B File Offset: 0x0000B11B
	[JsonIgnore]
	[MemoryPackIgnore]
	public bool IsNative
	{
		get
		{
			return Singleton<GameConfigManager>.Instance.NativeIds.Contains(this.Vars["Id"]);
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000160 RID: 352 RVA: 0x0000CF3C File Offset: 0x0000B13C
	[JsonIgnore]
	[MemoryPackIgnore]
	public string InstanceID
	{
		get
		{
			string value;
			return this.Vars.TryGetValue("InstanceID", out value) ? value : "";
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000161 RID: 353 RVA: 0x0000CF65 File Offset: 0x0000B165
	// (set) Token: 0x06000162 RID: 354 RVA: 0x0000CF6D File Offset: 0x0000B16D
	[JsonIgnore]
	[MemoryPackIgnore]
	public IScriptExecutor scriptExecutor { get; private set; }

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000163 RID: 355 RVA: 0x0000CF76 File Offset: 0x0000B176
	// (set) Token: 0x06000164 RID: 356 RVA: 0x0000CF7E File Offset: 0x0000B17E
	[JsonIgnore]
	[MemoryPackIgnore]
	public bool isCompiling { get; private set; }

	/// <summary>
	/// 根据id创建一个DataConfig，不会影响原数据
	/// </summary>
	/// <param name="id"></param>
	/// <param name="type"></param>
	// Token: 0x06000165 RID: 357 RVA: 0x0000CF88 File Offset: 0x0000B188
	public DataConfig(string id, DataType type)
	{
		id = id.Replace("*", "");
		try
		{
			this.data = Singleton<GameConfigManager>.Instance.DataConfigCache[id].data;
		}
		catch (Exception e)
		{
			Debug.LogError("Error in " + id + ": " + e.Message);
			throw new DataConfigIdNotFoundException(id);
		}
		this.ReSetVars();
		this.scriptExecutor = new ScriptExecutor(this);
		bool flag = !Singleton<GameConfigManager>.Instance.DataConfigCache[id].isCompiling;
		if (flag)
		{
			this.scriptExecutor.ScriptDict = new Dictionary<string, Delegate>(Singleton<GameConfigManager>.Instance.DataConfigCache[id].scriptExecutor.ScriptDict);
		}
		else
		{
			this.scriptExecutor.ScriptDict = new Dictionary<string, Delegate>();
		}
		this.Type = type;
	}

	/// <summary>
	/// 根据data和Vars创建一个DataConfig，会影响原数据
	/// </summary>
	/// <param name="data"></param>
	/// <param name="Vars"></param>
	/// /// <param name="ifPreCompile">是否立即编译</param>
	// Token: 0x06000166 RID: 358 RVA: 0x0000D08C File Offset: 0x0000B28C
	public DataConfig(IDictionary<string, string> data, IDictionary<string, string> Vars, bool ifPreCompile = true)
	{
		this.data = data;
		this.Vars = DeepCopyUtility.DeepCopy<IDictionary<string, string>>(Vars);
		this.Vars["InstanceID"] = Guid.NewGuid().ToString();
		bool flag = !this.Vars.ContainsKey("Id");
		if (flag)
		{
			this.Vars["Id"] = data["Id"];
		}
		this.RestoreVars();
		this.RegisterDefaultKeys();
		this.scriptExecutor = new ScriptExecutor(this);
		if (ifPreCompile)
		{
			this.PreCompileScripts();
		}
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000D144 File Offset: 0x0000B344
	[MemoryPackConstructor]
	public DataConfig()
	{
		this.Vars = new Dictionary<string, string>();
		this.data = new Dictionary<string, string>();
		this.scriptExecutor = new ScriptExecutor(this);
		this.RegisterDefaultKeys();
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0000D190 File Offset: 0x0000B390
	public void PreCompileScripts()
	{
		lock (this)
		{
			this.isCompiling = true;
			foreach (KeyValuePair<string, string> item in this.data)
			{
				bool isCancellationRequested = Singleton<GameConfigManager>.Instance.cts.Token.IsCancellationRequested;
				if (isCancellationRequested)
				{
					return;
				}
				bool flag2 = item.Key.Contains("Script");
				if (flag2)
				{
					try
					{
						this.scriptExecutor.PreCompileScripts(item.Key, null);
					}
					catch (Exception e)
					{
						Debug.Log(string.Concat(new string[]
						{
							"报错名为",
							this.data["Id"],
							"的",
							item.Key,
							"脚本"
						}));
						Debug.LogError("Script error in " + item.Key + ": " + e.Message);
					}
				}
			}
			this.isCompiling = false;
		}
	}

	// Token: 0x06000169 RID: 361 RVA: 0x0000D310 File Offset: 0x0000B510
	[OnDeserialized]
	internal void OnDeserializedMethod(StreamingContext context)
	{
		this.RestoreData();
		this.RestoreVars();
	}

	// Token: 0x0600016A RID: 362 RVA: 0x0000D310 File Offset: 0x0000B510
	[MemoryPackOnDeserialized]
	internal void OnDeserialized()
	{
		this.RestoreData();
		this.RestoreVars();
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0000D324 File Offset: 0x0000B524
	private void RestoreData()
	{
		bool flag = this.Vars == null;
		if (!flag)
		{
			string rawData;
			bool flag2 = this.Vars.TryGetValue("RawData", out rawData);
			if (flag2)
			{
				byte[] raw = Convert.FromBase64String(rawData);
				this.data = JsonConvert.DeserializeObject<IDictionary<string, string>>(GZip.DecompressToString(raw));
			}
			else
			{
				string id;
				bool flag3 = this.Vars.TryGetValue("Id", out id) && Singleton<GameConfigManager>.Instance != null && Singleton<GameConfigManager>.Instance.DataConfigCache.ContainsKey(id);
				if (flag3)
				{
					id = id.Replace("*", "");
					this.Vars["Id"] = id;
					IDataConfig value;
					bool flag4 = Singleton<GameConfigManager>.Instance.DataConfigCache.TryGetValue(id, out value);
					if (flag4)
					{
						this.data = value.data;
					}
					else
					{
						this.PreCompileScripts();
					}
					bool flag5 = !this.Vars.ContainsKey("InstanceID");
					if (flag5)
					{
						this.Vars["InstanceID"] = Guid.NewGuid().ToString();
					}
				}
			}
		}
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0000D450 File Offset: 0x0000B650
	private void RegisterDefaultKeys()
	{
		this.Vars.TryAdd("DesVal1", "");
		this.Vars.TryAdd("DesVal2", "");
		this.Vars.TryAdd("DesVal3", "");
		this.Vars.TryAdd("DesVal4", "");
		this.Vars.TryAdd("ThisCount", "0");
		this.Vars.TryAdd("layersExperienced", "0");
	}

	// Token: 0x0600016D RID: 365 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
	public void ReSetVars()
	{
		bool flag = this.Vars == null || this.data == null;
		if (!flag)
		{
			bool hasRawData = this.Vars.ContainsKey("RawData");
			string rawData;
			bool flag2 = this.Vars.TryGetValue("RawData", out rawData);
			if (flag2)
			{
				byte[] raw = Convert.FromBase64String(rawData);
				this.data = JsonConvert.DeserializeObject<IDictionary<string, string>>(GZip.DecompressToString(raw));
			}
			this.Vars.Clear();
			this.Vars["InstanceID"] = Guid.NewGuid().ToString();
			this.Vars["Id"] = this.data["Id"].Replace("*", "");
			bool flag3 = hasRawData;
			if (flag3)
			{
				this.Vars["RawData"] = rawData;
			}
			this.RestoreVars();
			this.RegisterDefaultKeys();
		}
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
	private void RestoreVars()
	{
		bool flag = this.Vars == null || this.data == null;
		if (!flag)
		{
			this.RegisterDefaultKeys();
			this.RestoreOneVar("Tag");
		}
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0000D61C File Offset: 0x0000B81C
	private void RestoreOneVar(string key)
	{
		bool flag = this.Vars == null || this.data == null;
		if (!flag)
		{
			bool flag2 = !this.Vars.ContainsKey(key) && this.data.ContainsKey(key);
			if (flag2)
			{
				this.Vars[key] = this.data[key];
			}
		}
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0000D680 File Offset: 0x0000B880
	public object Clone()
	{
		bool flag = Singleton<GameConfigManager>.Instance.DataConfigCache.ContainsKey(this.data["Id"]);
		DataConfig dataConfig;
		if (flag)
		{
			dataConfig = new DataConfig(this.data, DeepCopyUtility.DeepCopy<IDictionary<string, string>>(this.Vars), false);
			dataConfig.scriptExecutor = new ScriptExecutor(null, dataConfig);
			dataConfig.scriptExecutor.ScriptDict = new Dictionary<string, Delegate>(this.scriptExecutor.ScriptDict);
		}
		else
		{
			dataConfig = new DataConfig(DeepCopyUtility.DeepCopy<IDictionary<string, string>>(this.data), DeepCopyUtility.DeepCopy<IDictionary<string, string>>(this.Vars), true);
		}
		dataConfig.Vars["InstanceID"] = Guid.NewGuid().ToString();
		dataConfig.Type = this.Type;
		return dataConfig;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0000D74C File Offset: 0x0000B94C
	static DataConfig()
	{
		DataConfig.RegisterFormatter();
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0000D758 File Offset: 0x0000B958
	[Preserve]
	public static void RegisterFormatter()
	{
		bool flag = !MemoryPackFormatterProvider.IsRegistered<DataConfig>();
		if (flag)
		{
			MemoryPackFormatterProvider.Register<DataConfig>(new DataConfig.DataConfigFormatter());
		}
		bool flag2 = !MemoryPackFormatterProvider.IsRegistered<DataConfig[]>();
		if (flag2)
		{
			MemoryPackFormatterProvider.Register<DataConfig[]>(new ArrayFormatter<DataConfig>());
		}
		bool flag3 = !MemoryPackFormatterProvider.IsRegistered<DataType>();
		if (flag3)
		{
			MemoryPackFormatterProvider.Register<DataType>(new UnmanagedFormatter<DataType>());
		}
		bool flag4 = !MemoryPackFormatterProvider.IsRegistered<IDictionary<string, string>>();
		if (flag4)
		{
			MemoryPackFormatterProvider.Register<IDictionary<string, string>>(new InterfaceDictionaryFormatter<string, string>());
		}
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0000D7CC File Offset: 0x0000B9CC
	[NullableContext(1)]
	[Preserve]
	public static void Serialize<TBufferWriter>([Nullable(new byte[]
	{
		0,
		1
	})] ref MemoryPackWriter<TBufferWriter> writer, [Nullable(2)] ref DataConfig value) where TBufferWriter : class, IBufferWriter<byte>
	{
		bool flag = value == null;
		if (flag)
		{
			writer.WriteNullObjectHeader();
		}
		else
		{
			byte propertyCount = 2;
			DataType type = value.Type;
			writer.WriteUnmanagedWithObjectHeader<DataType>(propertyCount, type);
			IDictionary<string, string> vars = value.Vars;
			writer.WriteValue<IDictionary<string, string>>(vars);
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0000D814 File Offset: 0x0000BA14
	[NullableContext(2)]
	[Preserve]
	public static void Deserialize(ref MemoryPackReader reader, ref DataConfig value)
	{
		byte count;
		bool flag = !reader.TryReadObjectHeader(out count);
		if (flag)
		{
			value = null;
		}
		else
		{
			bool flag2 = count == 2;
			DataType __Type;
			IDictionary<string, string> __Vars;
			if (flag2)
			{
				bool flag3 = value == null;
				if (flag3)
				{
					reader.ReadUnmanaged<DataType>(out __Type);
					__Vars = reader.ReadValue<IDictionary<string, string>>();
					goto IL_112;
				}
				__Type = value.Type;
				__Vars = value.Vars;
				reader.ReadUnmanaged<DataType>(out __Type);
				reader.ReadValue<IDictionary<string, string>>(ref __Vars);
			}
			else
			{
				bool flag4 = count > 2;
				if (flag4)
				{
					MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(DataConfig), 2, count);
					goto IL_12A;
				}
				bool flag5 = value == null;
				if (flag5)
				{
					__Type = DataType.Card;
					__Vars = null;
				}
				else
				{
					__Type = value.Type;
					__Vars = value.Vars;
				}
				bool flag6 = count == 0;
				if (!flag6)
				{
					reader.ReadUnmanaged<DataType>(out __Type);
					bool flag7 = count == 1;
					if (!flag7)
					{
						reader.ReadValue<IDictionary<string, string>>(ref __Vars);
						bool flag8 = count == 2;
						if (flag8)
						{
						}
					}
				}
				bool flag9 = value == null;
				if (flag9)
				{
					goto IL_112;
				}
			}
			value.Type = __Type;
			value.Vars = __Vars;
			goto IL_12A;
			IL_112:
			value = new DataConfig
			{
				Type = __Type,
				Vars = __Vars
			};
			IL_12A:;
		}
		DataConfig dataConfig = value;
		if (dataConfig != null)
		{
			dataConfig.OnDeserialized();
		}
	}

	// Token: 0x040000C7 RID: 199
	private ReadOnlyDictionary<string, string> _data;

	// Token: 0x040000C8 RID: 200
	private Dictionary<string, string> _Vars = new Dictionary<string, string>();

	// Token: 0x02000036 RID: 54
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[Preserve]
	private sealed class DataConfigFormatter : MemoryPackFormatter<DataConfig>
	{
		// Token: 0x06000175 RID: 373 RVA: 0x0000D95D File Offset: 0x0000BB5D
		[Preserve]
		public override void Serialize<TBufferWriter>([Nullable(new byte[]
		{
			0,
			1
		})] ref MemoryPackWriter<TBufferWriter> writer, ref DataConfig value)
		{
			DataConfig.Serialize<TBufferWriter>(ref writer, ref value);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000D968 File Offset: 0x0000BB68
		[Preserve]
		public override void Deserialize(ref MemoryPackReader reader, ref DataConfig value)
		{
			DataConfig.Deserialize(ref reader, ref value);
		}
	}
}

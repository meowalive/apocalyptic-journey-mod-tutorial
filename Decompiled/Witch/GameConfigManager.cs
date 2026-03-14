using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Mirror;
using Rougamo;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using Witch.UI;
using ZLinq;
using ZLinq.Linq;

// Token: 0x02000043 RID: 67
[IgnoreMo]
public class GameConfigManager : Singleton<GameConfigManager>
{
	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060001CF RID: 463 RVA: 0x00010234 File Offset: 0x0000E434
	public static string Version
	{
		get
		{
			return Globals.VersionString;
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0001023C File Offset: 0x0000E43C
	public GameConfigData GetTable(DataType type)
	{
		GameConfigData d;
		return this._tables.TryGetValue(type, out d) ? d : null;
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001025D File Offset: 0x0000E45D
	public ConcurrentDictionary<string, IDataConfig> DataConfigCache
	{
		get
		{
			return Globals.DataConfigCache;
		}
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x00010264 File Offset: 0x0000E464
	public void Init()
	{
		Globals.GetDataBydId = new Func<string, Dictionary<string, string>>(this.GetOneById);
		UniTask.WaitUntil(() => this.cts.Token.IsCancellationRequested, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
		{
			Debug.Log("游戏结束");
		}).Forget();
		this.current = 0;
		this.totalCount = 0;
		ScriptExecutor.Init();
		this.LoadResource("Addressables/DataConfigs/Data/");
		this.LoadResource("Addressables/DataConfigs/Text/");
		this.datas = (from t in GameConfigManager.DatasOrder
		select this.GetTable(t)).ToList<GameConfigData>();
		this.AddNativeIds();
		bool flag = !Directory.Exists(Globals.ModsPath);
		if (flag)
		{
			Directory.CreateDirectory(Globals.ModsPath);
		}
		string[] dics = Directory.GetDirectories(Globals.ModsPath);
		List<ModConfig> enabledMods = new List<ModConfig>();
		foreach (string item in dics)
		{
			bool flag2 = File.Exists(item + "/ModConfig.json");
			if (flag2)
			{
				string json = File.ReadAllText(item + "/ModConfig.json");
				ModConfig modConfig = JsonUtility.FromJson<ModConfig>(json);
				modConfig.DirectoryName = item;
				this.modConfigs.Add(modConfig);
				string msg = string.Concat(new string[]
				{
					modConfig.ModId,
					" v",
					modConfig.ModVersion,
					" (",
					modConfig.Enabled ? "已启用" : "未启用",
					")"
				});
				Debug.Log("[Mod] 发现: " + msg);
				bool flag3 = UIManager.Instance != null;
				if (flag3)
				{
					Commands.Log("Mod", "发现: " + msg);
				}
				bool enabled = modConfig.Enabled;
				if (enabled)
				{
					enabledMods.Add(modConfig);
				}
			}
			else
			{
				Debug.LogError("ModConfig.json not found in " + item);
				bool flag4 = UIManager.Instance != null;
				if (flag4)
				{
					Commands.LogError("Mod", "ModConfig.json not found in " + item);
				}
			}
		}
		this.LoadModWithDependencies(enabledMods);
		this.datas = (from t in GameConfigManager.DatasOrder
		select this.GetTable(t)).ToList<GameConfigData>();
		foreach (GameConfigData data in this.datas)
		{
			this.LockedIds.UnionWith(data.LockedIds);
		}
		GameConfigData keyWordsData = this.GetTable(DataType.KeyWords);
		foreach (Dictionary<string, string> item2 in this.GetTable(DataType.Buff).Getlines())
		{
			Dictionary<string, string> buff = new Dictionary<string, string>
			{
				{
					"Id",
					item2["Id"]
				}
			};
			foreach (KeyValuePair<string, string> kvp in item2)
			{
				bool flag5 = kvp.Key.StartsWith("Name");
				if (flag5)
				{
					buff.Add(kvp.Key.Replace("Name", "Keywords"), kvp.Value);
				}
				bool flag6 = kvp.Key.StartsWith("Description");
				if (flag6)
				{
					string desc = kvp.Value;
					Regex regex = new Regex("\\(\\{.*?\\}\\)");
					desc = regex.Replace(desc, "");
					buff.Add(kvp.Key, desc);
				}
				bool flag7 = kvp.Key == "Icon";
				if (flag7)
				{
					buff.Add(kvp.Key, kvp.Value);
				}
			}
			buff["Type"] = "Buff";
			buff["Id"] = "BuffKeyword_" + item2["Id"];
			keyWordsData.dataDic["BuffKeyword_" + item2["Id"]] = buff;
		}
		foreach (Dictionary<string, string> item3 in this.GetTable(DataType.EnchTag).Getlines())
		{
			Dictionary<string, string> ench = new Dictionary<string, string>();
			ench.Add("Id", item3["Id"]);
			foreach (KeyValuePair<string, string> kvp2 in item3)
			{
				bool flag8 = kvp2.Key.StartsWith("Name");
				if (flag8)
				{
					ench.Add(kvp2.Key.Replace("Name", "Keywords"), kvp2.Value);
				}
				bool flag9 = kvp2.Key.StartsWith("Description");
				if (flag9)
				{
					string desc2 = kvp2.Value;
					Regex regex2 = new Regex("\\(\\{.*?\\}\\)");
					desc2 = regex2.Replace(desc2, "");
					ench.Add(kvp2.Key, desc2);
				}
			}
			keyWordsData.dataDic["EnchTag_" + item3["Id"]] = ench;
		}
		EditorApplication.playModeStateChanged += delegate(PlayModeStateChange state)
		{
			bool flag11 = state == 3;
			if (flag11)
			{
				this.OnApplicationQuit();
			}
		};
		this.PreCompileScripts();
		bool flag10 = this.ifCompileImmidiate;
		if (flag10)
		{
			this.ShowProgress();
		}
		Singleton<DialogueManager>.Instance.Init();
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x000108C8 File Offset: 0x0000EAC8
	private void LoadModWithDependencies(List<ModConfig> enabledMods)
	{
		string startMsg = ZString.Format<object>("开始加载 {0} 个已启用 Mod", enabledMods.Count);
		Debug.Log("[Mod] " + startMsg);
		bool flag = UIManager.Instance != null;
		if (flag)
		{
			Commands.Log("Mod", startMsg);
		}
		Dictionary<string, ModConfig> modIdMap = Enumerable.ToDictionary<ModConfig, string>(enabledMods, (ModConfig mod) => mod.ModId);
		Dictionary<string, List<string>> adjacency = new Dictionary<string, List<string>>();
		Dictionary<string, int> inDegree = new Dictionary<string, int>();
		foreach (ModConfig mod3 in enabledMods)
		{
			adjacency[mod3.ModId] = new List<string>();
			inDegree[mod3.ModId] = 0;
		}
		foreach (ModConfig mod2 in enabledMods)
		{
			bool flag2 = mod2.Dependencies == null;
			if (!flag2)
			{
				foreach (string dependency in mod2.Dependencies)
				{
					bool flag3 = !modIdMap.ContainsKey(dependency);
					if (flag3)
					{
						string depMsg = mod2.ModName + " 的依赖 " + dependency + " 不存在";
						Debug.LogError("Mod " + depMsg);
						bool flag4 = UIManager.Instance != null;
						if (flag4)
						{
							Commands.LogError("Mod", depMsg);
						}
					}
					else
					{
						adjacency[dependency].Add(mod2.ModId);
						Dictionary<string, int> dictionary = inDegree;
						string key = mod2.ModId;
						int num = dictionary[key];
						dictionary[key] = num + 1;
					}
				}
			}
		}
		Queue<string> queue = new Queue<string>();
		foreach (string modId in inDegree.Keys)
		{
			bool flag5 = inDegree[modId] == 0;
			if (flag5)
			{
				queue.Enqueue(modId);
			}
		}
		List<ModConfig> loadedMods = new List<ModConfig>();
		while (queue.Count > 0)
		{
			string currentModId = queue.Dequeue();
			ModConfig currentMod = modIdMap[currentModId];
			try
			{
				bool flag6 = Directory.Exists(currentMod.DirectoryName + "/Data/");
				if (flag6)
				{
					this.LoadResource("Mods/" + currentMod.DirectoryName + "/Data/");
				}
				bool flag7 = Directory.Exists(currentMod.DirectoryName + "/Text/");
				if (flag7)
				{
					this.LoadResource("Mods/" + currentMod.DirectoryName + "/Text/");
				}
				currentMod.Setup();
				string loadedMsg = "已加载: " + currentMod.ModId + " v" + currentMod.ModVersion;
				Debug.Log("[Mod] " + loadedMsg);
				bool flag8 = UIManager.Instance != null;
				if (flag8)
				{
					Commands.Log("Mod", loadedMsg);
				}
				loadedMods.Add(currentMod);
				foreach (string dependentModId in adjacency[currentModId])
				{
					Dictionary<string, int> dictionary2 = inDegree;
					string key = dependentModId;
					int num = dictionary2[key];
					dictionary2[key] = num - 1;
					bool flag9 = inDegree[dependentModId] == 0;
					if (flag9)
					{
						queue.Enqueue(dependentModId);
					}
				}
			}
			catch (Exception e)
			{
				string errMsg = ZString.Format<object, object>("{0} 加载失败: {1}", currentMod.ModName, e);
				Debug.LogError("Mod " + errMsg);
				bool flag10 = UIManager.Instance != null;
				if (flag10)
				{
					Commands.LogError("Mod", errMsg);
				}
			}
		}
		bool flag11 = loadedMods.Count != enabledMods.Count;
		if (flag11)
		{
			List<ModConfig> unloadedMods = (from mod in enabledMods.AsValueEnumerable<ModConfig>()
			where !loadedMods.Contains(mod)
			select mod).ToList<ListWhere<ModConfig>, ModConfig>();
			string cycleMsg = "存在循环依赖或不可解析的依赖，未加载的 Mod: " + string.Join(", ", from m in unloadedMods
			select m.ModId);
			Debug.LogError(cycleMsg);
			bool flag12 = UIManager.Instance != null;
			if (flag12)
			{
				Commands.LogError("Mod", cycleMsg);
			}
		}
		this.WarmUpDynamicFonts();
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00010E28 File Offset: 0x0000F028
	private void ShowProgress()
	{
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00010E30 File Offset: 0x0000F030
	private void OnApplicationQuit()
	{
		Action onAppicationQuit = this.OnAppicationQuit;
		if (onAppicationQuit != null)
		{
			onAppicationQuit();
		}
		ResourceLoader.ReleaseAllCachedAAHandles();
		Resources.Load<Material>("Material/PostProcess/SceneTurn").mainTexture = null;
		Resources.Load<Material>("Material/PostProcess/ScreenLight").SetInt("_Enabled", 0);
		Material material = Resources.Load<Material>("Material/PostProcess/Blur");
		if (material != null)
		{
			material.DisableKeyword("_BLUR_ON");
		}
		this.cts.Cancel();
		GC.Collect();
		GC.WaitForPendingFinalizers();
		KeyManager.playerAction.RemoveAllBindingOverrides();
		NetworkManager.singleton.StopClient();
		NetworkManager.singleton.StopHost();
		NetworkManager.singleton.StopServer();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00010EE4 File Offset: 0x0000F0E4
	public void LoadResource(string path)
	{
		this._tables[DataType.Event] = GameConfigData.Concat(this.GetTable(DataType.Event), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "EventList"));
		this._tables[DataType.Map] = GameConfigData.Concat(this.GetTable(DataType.Map), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Map"));
		this._tables[DataType.Card] = GameConfigData.Concat(this.GetTable(DataType.Card), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Card"));
		this._tables[DataType.Enemy] = GameConfigData.Concat(this.GetTable(DataType.Enemy), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Enemy"));
		this._tables[DataType.EnemyCard] = GameConfigData.Concat(this.GetTable(DataType.EnemyCard), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "EnemyCard"));
		this._tables[DataType.Level] = GameConfigData.Concat(this.GetTable(DataType.Level), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Level"));
		this._tables[DataType.Partner] = GameConfigData.Concat(this.GetTable(DataType.Partner), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Partner"));
		this._tables[DataType.PartnerCard] = GameConfigData.Concat(this.GetTable(DataType.PartnerCard), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "PartnerCard"));
		this._tables[DataType.BuyItems] = GameConfigData.Concat(this.GetTable(DataType.BuyItems), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "OutSideShop"));
		this._tables[DataType.Hard] = GameConfigData.Concat(this.GetTable(DataType.Hard), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Hard"));
		this._tables[DataType.Item] = GameConfigData.Concat(this.GetTable(DataType.Item), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Item"));
		this._tables[DataType.Bless] = GameConfigData.Concat(this.GetTable(DataType.Bless), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Blessing"));
		this._tables[DataType.Food] = GameConfigData.Concat(this.GetTable(DataType.Food), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Food"));
		this._tables[DataType.Coin] = GameConfigData.Concat(this.GetTable(DataType.Coin), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Coin"));
		this._tables[DataType.EnchTag] = GameConfigData.Concat(this.GetTable(DataType.EnchTag), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "EnchTag"));
		this._tables[DataType.Career] = GameConfigData.Concat(this.GetTable(DataType.Career), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Career"));
		this._tables[DataType.Buff] = GameConfigData.Concat(this.GetTable(DataType.Buff), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Buff"));
		this._tables[DataType.DesList] = GameConfigData.Concat(this.GetTable(DataType.DesList), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Destiny"));
		this._tables[DataType.Relic] = GameConfigData.Concat(this.GetTable(DataType.Relic), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Relic"));
		this._tables[DataType.KeyWords] = GameConfigData.Concat(this.GetTable(DataType.KeyWords), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "KeyWordsDic"));
		this._tables[DataType.IllustraedBook] = GameConfigData.Concat(this.GetTable(DataType.IllustraedBook), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "IllustratedBook"));
		this._tables[DataType.Tutorial] = GameConfigData.Concat(this.GetTable(DataType.Tutorial), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Tutorial"));
		this._tables[DataType.Announcement] = GameConfigData.Concat(this.GetTable(DataType.Announcement), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Announcement"));
		this._tables[DataType.Dialogue] = GameConfigData.Concat(this.GetTable(DataType.Dialogue), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Dialogue"));
		this._tables[DataType.DialogueBox] = GameConfigData.Concat(this.GetTable(DataType.DialogueBox), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "DialogueBox"));
		this._tables[DataType.Effect] = GameConfigData.Concat(this.GetTable(DataType.Effect), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Effect"));
		this._tables[DataType.RoleData] = GameConfigData.Concat(this.GetTable(DataType.RoleData), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "RoleData"));
		this._tables[DataType.Task] = GameConfigData.Concat(this.GetTable(DataType.Task), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Task"));
		this._tables[DataType.Affection] = GameConfigData.Concat(this.GetTable(DataType.Affection), Singleton<ExcelTableReader>.Instance.ReadByFolder(path + "Affection"));
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00011450 File Offset: 0x0000F650
	private void WarmUpDynamicFonts()
	{
		GameConfigManager.<>c__DisplayClass21_0 CS$<>8__locals1 = new GameConfigManager.<>c__DisplayClass21_0();
		CS$<>8__locals1.<>4__this = this;
		bool flag = this.isFontWarmup;
		if (!flag)
		{
			List<GameConfigData> tmpdata = this.datas.ToList<GameConfigData>();
			CS$<>8__locals1.snapshot = new List<Dictionary<string, string>[]>();
			foreach (GameConfigData d in tmpdata)
			{
				bool flag2 = d == null;
				if (flag2)
				{
					CS$<>8__locals1.snapshot.Add(Array.Empty<Dictionary<string, string>>());
				}
				else
				{
					Dictionary<string, string>[] valuesArr = null;
					for (int t = 0; t < 5; t++)
					{
						try
						{
							valuesArr = d.dataDic.Values.ToArray<Dictionary<string, string>>();
							break;
						}
						catch (InvalidOperationException)
						{
							Thread.Yield();
						}
					}
					CS$<>8__locals1.snapshot.Add(valuesArr ?? Array.Empty<Dictionary<string, string>>());
				}
			}
			UniTask.RunOnThreadPool(delegate()
			{
				GameConfigManager.<>c__DisplayClass21_0.<<WarmUpDynamicFonts>b__0>d <<WarmUpDynamicFonts>b__0>d = new GameConfigManager.<>c__DisplayClass21_0.<<WarmUpDynamicFonts>b__0>d();
				<<WarmUpDynamicFonts>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<WarmUpDynamicFonts>b__0>d.<>4__this = CS$<>8__locals1;
				<<WarmUpDynamicFonts>b__0>d.<>1__state = -1;
				<<WarmUpDynamicFonts>b__0>d.<>t__builder.Start<GameConfigManager.<>c__DisplayClass21_0.<<WarmUpDynamicFonts>b__0>d>(ref <<WarmUpDynamicFonts>b__0>d);
				return <<WarmUpDynamicFonts>b__0>d.<>t__builder.Task;
			}, true, default(CancellationToken)).Forget();
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060001D8 RID: 472 RVA: 0x00011574 File Offset: 0x0000F774
	public bool isLoading
	{
		get
		{
			return this.current < this.totalCount && this.isFontWarmup;
		}
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00011590 File Offset: 0x0000F790
	public void AddNativeIds()
	{
		foreach (GameConfigData data in this.datas)
		{
			foreach (KeyValuePair<string, Dictionary<string, string>> item in data.dataDic)
			{
				this.NativeIds.Add(item.Key);
			}
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00011634 File Offset: 0x0000F834
	private void PreCompileScripts()
	{
		this.datas = (from t in GameConfigManager.DatasOrder
		select this.GetTable(t)).ToList<GameConfigData>();
		foreach (GameConfigData data in this.datas)
		{
			this.totalCount += data.dataDic.Count;
		}
		foreach (GameConfigData data2 in this.datas)
		{
			bool flag = data2 == null || this.cts.Token.IsCancellationRequested;
			if (flag)
			{
				break;
			}
			try
			{
				foreach (KeyValuePair<string, Dictionary<string, string>> item in data2.dataDic)
				{
					bool isCancellationRequested = this.cts.Token.IsCancellationRequested;
					if (isCancellationRequested)
					{
						return;
					}
					Interlocked.Add(ref this.current, 1);
					try
					{
						this.DataConfigCache.TryAdd(item.Key, new DataConfig(item.Value, new Dictionary<string, string>(), this.ifCompileImmidiate));
					}
					catch (Exception e)
					{
						string str = "脚本";
						string key = item.Key;
						string str2 = "预编译失败";
						Exception ex = e;
						Debug.LogError(str + key + str2 + ((ex != null) ? ex.ToString() : null));
					}
				}
			}
			catch (Exception e2)
			{
				string str3 = "脚本";
				string str4 = this.datas.IndexOf(data2).ToString();
				string str5 = "预编译失败";
				Exception ex2 = e2;
				Debug.LogError(str3 + str4 + str5 + ((ex2 != null) ? ex2.ToString() : null));
			}
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00011894 File Offset: 0x0000FA94
	public void BuySave()
	{
		Dictionary<string, Dictionary<string, string>> temp = new Dictionary<string, Dictionary<string, string>>(this.GetTable(DataType.BuyItems).dataDic);
		foreach (KeyValuePair<string, Dictionary<string, string>> item in temp)
		{
			this.BuySaveByName(item.Value);
		}
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00011904 File Offset: 0x0000FB04
	public void BuySaveByName(IDictionary<string, string> item)
	{
		bool flag = Singleton<GameRuntimeData>.Instance.BuyedItems.ContainsKey(item["Id"]);
		if (flag)
		{
			string[] ids = item["Toid"].Split(';', StringSplitOptions.None);
			foreach (string id in ids)
			{
				Commands.unlock(id);
			}
		}
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00011968 File Offset: 0x0000FB68
	public List<Dictionary<string, string>> GetByNote(List<Dictionary<string, string>> TheList)
	{
		List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
		foreach (Dictionary<string, string> item in TheList)
		{
			bool flag = item.Keys.Contains("Note");
			if (flag)
			{
				string[] ItsBias = item["Note"].Split(',', StringSplitOptions.None);
				foreach (string item2 in ItsBias)
				{
					list.Add(item);
				}
			}
			list.Add(item);
		}
		return list;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00011A20 File Offset: 0x0000FC20
	public Dictionary<string, Dictionary<string, string>> GetDataByPrefix(string prefix)
	{
		Dictionary<string, Dictionary<string, string>> tmp = new Dictionary<string, Dictionary<string, string>>();
		Func<KeyValuePair<string, Dictionary<string, string>>, bool> <>9__0;
		foreach (GameConfigData data in this.datas)
		{
			IEnumerable<KeyValuePair<string, Dictionary<string, string>>> dataDic = data.dataDic;
			Func<KeyValuePair<string, Dictionary<string, string>>, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((KeyValuePair<string, Dictionary<string, string>> x) => x.Key.StartsWith(prefix)));
			}
			IEnumerable<KeyValuePair<string, Dictionary<string, string>>> finded = dataDic.Where(predicate);
			foreach (KeyValuePair<string, Dictionary<string, string>> item in finded)
			{
				tmp.TryAdd(item.Key, item.Value);
			}
		}
		return tmp;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00011B0C File Offset: 0x0000FD0C
	public Dictionary<string, Dictionary<string, string>> GetDataByPrefix(List<Dictionary<string, string>> list, string prefix)
	{
		Dictionary<string, Dictionary<string, string>> tmp = new Dictionary<string, Dictionary<string, string>>();
		foreach (Dictionary<string, string> item in list)
		{
			bool flag = item["Id"].StartsWith(prefix);
			if (flag)
			{
				tmp.Add(item["Id"], item);
			}
		}
		return tmp;
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00011B90 File Offset: 0x0000FD90
	public Dictionary<string, string> GetOne(DataType type, string id)
	{
		GameConfigData data = this.GetTable(type);
		return (data == null) ? null : (data.GetOneById(id) ?? data.GetOneById(id.Replace("*", "")));
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00011BD4 File Offset: 0x0000FDD4
	public Dictionary<string, string> GetOne(GameConfigData data, string id)
	{
		return ((data != null) ? data.GetOneById(id) : null) ?? ((data != null) ? data.GetOneById(id.Replace("*", "")) : null);
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00011C14 File Offset: 0x0000FE14
	public Dictionary<string, string> GetOneById(string id)
	{
		foreach (GameConfigData data in this.datas)
		{
			Dictionary<string, string> result = data.GetOneById(id);
			bool flag = result != null;
			if (flag)
			{
				return result;
			}
		}
		return null;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00011CF3 File Offset: 0x0000FEF3
	// Note: this type is marked as 'beforefieldinit'.
	static GameConfigManager()
	{
		DataType[] array = new DataType[27];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.CB9AD30823C5F289E838D2322E90523DCD9F902B2141FB19691E389FD9A15737).FieldHandle);
		GameConfigManager.DatasOrder = array;
	}

	// Token: 0x04000116 RID: 278
	public string PlayerId = "Unknown";

	// Token: 0x04000117 RID: 279
	public string PlayerName = "Player";

	// Token: 0x04000118 RID: 280
	public List<ModConfig> modConfigs = new List<ModConfig>();

	// Token: 0x04000119 RID: 281
	public Action OnAppicationQuit;

	// Token: 0x0400011A RID: 282
	private Dictionary<DataType, GameConfigData> _tables = new Dictionary<DataType, GameConfigData>();

	/// <summary> 参与脚本编译与 GetOneById 全局搜索的表（不含 Tutorial/Announcement） </summary>
	// Token: 0x0400011B RID: 283
	private static readonly DataType[] DatasOrder;

	// Token: 0x0400011C RID: 284
	public bool ifCompileImmidiate = false;

	// Token: 0x0400011D RID: 285
	public CancellationTokenSource cts = new CancellationTokenSource();

	// Token: 0x0400011E RID: 286
	public HashSet<string> NativeIds = new HashSet<string>();

	// Token: 0x0400011F RID: 287
	public HashSet<string> LockedIds = new HashSet<string>();

	// Token: 0x04000120 RID: 288
	public bool isFontWarmup = false;

	// Token: 0x04000121 RID: 289
	public int totalCount;

	// Token: 0x04000122 RID: 290
	public int current;

	// Token: 0x04000123 RID: 291
	private List<GameConfigData> datas;
}

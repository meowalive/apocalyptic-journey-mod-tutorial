using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Data.Save;
using Loxodon.Framework.Obfuscation;
using Newtonsoft.Json;
using Rougamo;
using Steamworks;
using UnityEngine;

// Token: 0x02000055 RID: 85
[IgnoreMo]
public class GameRuntimeData : Singleton<GameRuntimeData>, INotifyPropertyChanged
{
	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000229 RID: 553 RVA: 0x00014159 File Offset: 0x00012359
	public List<SaveInfo> Saves
	{
		get
		{
			return GameSaveManager.LoadAll();
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x0600022A RID: 554 RVA: 0x00014160 File Offset: 0x00012360
	// (set) Token: 0x0600022B RID: 555 RVA: 0x00014168 File Offset: 0x00012368
	public ObfuscatedInt Truth
	{
		get
		{
			return this.truth;
		}
		set
		{
			if (this.truth == value)
			{
				return;
			}
			this.truth = value;
			this.OnPropertyChanged("Truth");
			this.Save();
		}
	}

	// Token: 0x0600022C RID: 556 RVA: 0x000141A0 File Offset: 0x000123A0
	public void Init()
	{
		JsonConvert.DefaultSettings = (() => new JsonSerializerSettings
		{
			MaxDepth = null,
			Converters = 
			{
				new ObfuscateIntConverter()
			}
		});
		this.Load();
		bool flag = this.PlayerId == null;
		if (flag)
		{
			this.PlayerId = BitConverter.ToUInt64(Guid.NewGuid().ToByteArray(), 0).ToString();
			bool steambuild = GameApp.STEAMBUILD;
			if (steambuild)
			{
				string language = SteamUtils.GetSteamUILanguage();
				if (!true)
				{
				}
				uint num = <PrivateImplementationDetails>.ComputeStringHash(language);
				string text;
				if (num <= 2805355685U)
				{
					if (num <= 599131013U)
					{
						if (num != 380651494U)
						{
							if (num == 599131013U)
							{
								if (language == "french")
								{
									text = "fr-FR";
									goto IL_1E5;
								}
							}
						}
						else if (language == "russian")
						{
							text = "ru-RU";
							goto IL_1E5;
						}
					}
					else if (num != 1901528810U)
					{
						if (num == 2805355685U)
						{
							if (language == "schinese")
							{
								text = "zh-CN";
								goto IL_1E5;
							}
						}
					}
					else if (language == "japanese")
					{
						text = "ja-JP";
						goto IL_1E5;
					}
				}
				else if (num <= 3264533134U)
				{
					if (num != 3222531841U)
					{
						if (num == 3264533134U)
						{
							if (language == "tchinese")
							{
								text = "zh-TW";
								goto IL_1E5;
							}
						}
					}
					else if (language == "korean")
					{
						text = "ko-KR";
						goto IL_1E5;
					}
				}
				else if (num != 3405445907U)
				{
					if (num == 3719199419U)
					{
						if (language == "spanish")
						{
							text = "es-ES";
							goto IL_1E5;
						}
					}
				}
				else if (language == "german")
				{
					text = "de-DE";
					goto IL_1E5;
				}
				text = "en-US";
				IL_1E5:
				if (!true)
				{
				}
				Globals.Language = text;
				string language2 = Globals.Language;
				if (!true)
				{
				}
				num = <PrivateImplementationDetails>.ComputeStringHash(language2);
				if (num <= 2194893224U)
				{
					if (num <= 376747596U)
					{
						if (num != 83303646U)
						{
							if (num == 376747596U)
							{
								if (language2 == "fr-FR")
								{
									text = "French";
									goto IL_36C;
								}
							}
						}
						else if (language2 == "ru-RU")
						{
							text = "Russian";
							goto IL_36C;
						}
					}
					else if (num != 637978675U)
					{
						if (num == 2194893224U)
						{
							if (language2 == "es-ES")
							{
								text = "Spanish";
								goto IL_36C;
							}
						}
					}
					else if (language2 == "zh-CN")
					{
						text = "简体中文";
						goto IL_36C;
					}
				}
				else if (num <= 2328506441U)
				{
					if (num != 2196609786U)
					{
						if (num == 2328506441U)
						{
							if (language2 == "ja-JP")
							{
								text = "Japanese";
								goto IL_36C;
							}
						}
					}
					else if (language2 == "de-DE")
					{
						text = "German";
						goto IL_36C;
					}
				}
				else if (num != 2586248143U)
				{
					if (num == 3973517379U)
					{
						if (language2 == "zh-TW")
						{
							text = "繁体中文";
							goto IL_36C;
						}
					}
				}
				else if (language2 == "ko-KR")
				{
					text = "Korean";
					goto IL_36C;
				}
				text = "English";
				IL_36C:
				if (!true)
				{
				}
				string LanguageName = text;
				this.settingTable.SetValue("语言", LanguageName);
			}
		}
		this.Save();
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00014540 File Offset: 0x00012740
	public void AddItem(string id, string type)
	{
		bool flag = type == "card";
		if (flag)
		{
			this.CardData.Add(new DataConfig(id, DataType.Card));
		}
		else
		{
			bool flag2 = type == "relic";
			if (flag2)
			{
				this.RelicData.Add(new DataConfig(id, DataType.Relic));
			}
		}
	}

	/// <summary>
	/// 保存存档
	/// </summary>
	// Token: 0x0600022E RID: 558 RVA: 0x0001459C File Offset: 0x0001279C
	public void Save()
	{
		bool flag = !Directory.Exists(Globals.SavePath);
		if (flag)
		{
			Directory.CreateDirectory(Globals.SavePath);
		}
		this.md5 = "Invalid";
		string json = JsonConvert.SerializeObject(this, Formatting.Indented);
		this.md5 = GameRuntimeData.Md5(json);
		json = JsonConvert.SerializeObject(this, Formatting.Indented);
		bool flag2 = GameRuntimeData.isEncrypted;
		if (flag2)
		{
			using (Aes aes = Aes.Create())
			{
				aes.Key = Encoding.UTF8.GetBytes(GameRuntimeData.key);
				aes.IV = Encoding.UTF8.GetBytes(GameRuntimeData.iv);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
					{
						using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
						{
							streamWriter.Write(json);
						}
					}
					File.WriteAllBytes(GameRuntimeData.savePath, memoryStream.ToArray());
				}
			}
		}
		else
		{
			File.WriteAllText(GameRuntimeData.savePath, json);
		}
	}

	/// <summary>
	/// 读取存档
	/// </summary>
	// Token: 0x0600022F RID: 559 RVA: 0x000146F0 File Offset: 0x000128F0
	public void Load()
	{
		bool flag = !File.Exists(GameRuntimeData.savePath);
		if (!flag)
		{
			bool flag2 = GameRuntimeData.isEncrypted;
			string json;
			if (flag2)
			{
				using (Aes aes = Aes.Create())
				{
					aes.Key = Encoding.UTF8.GetBytes(GameRuntimeData.key);
					aes.IV = Encoding.UTF8.GetBytes(GameRuntimeData.iv);
					byte[] encryptedData = File.ReadAllBytes(GameRuntimeData.savePath);
					try
					{
						using (MemoryStream memoryStream = new MemoryStream(encryptedData))
						{
							using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
							{
								using (StreamReader streamReader = new StreamReader(cryptoStream))
								{
									json = streamReader.ReadToEnd();
								}
							}
						}
					}
					catch (ArgumentException e)
					{
						Debug.LogError("存档损坏！" + e.Message);
						return;
					}
				}
			}
			else
			{
				json = File.ReadAllText(GameRuntimeData.savePath);
			}
			JsonConvert.PopulateObject(json, this);
		}
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00014844 File Offset: 0x00012A44
	public static GameRuntimeData Load(string path)
	{
		bool flag = !File.Exists(path);
		GameRuntimeData result;
		if (flag)
		{
			result = null;
		}
		else
		{
			bool flag2 = GameRuntimeData.isEncrypted;
			string json;
			if (flag2)
			{
				using (Aes aes = Aes.Create())
				{
					aes.Key = Encoding.UTF8.GetBytes(GameRuntimeData.key);
					aes.IV = Encoding.UTF8.GetBytes(GameRuntimeData.iv);
					byte[] encryptedData = File.ReadAllBytes(path);
					try
					{
						using (MemoryStream memoryStream = new MemoryStream(encryptedData))
						{
							using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
							{
								using (StreamReader streamReader = new StreamReader(cryptoStream))
								{
									json = streamReader.ReadToEnd();
								}
							}
						}
					}
					catch (ArgumentException e)
					{
						Debug.LogError("存档损坏！" + e.Message);
						return null;
					}
				}
			}
			else
			{
				json = File.ReadAllText(path);
			}
			GameRuntimeData runtimeData = new GameRuntimeData();
			JsonConvert.PopulateObject(json, runtimeData);
			result = runtimeData;
		}
		return result;
	}

	/// <summary>
	/// 存档有效性校验
	/// </summary>
	/// <param name="data"></param>
	/// <returns></returns>
	// Token: 0x06000231 RID: 561 RVA: 0x000149A0 File Offset: 0x00012BA0
	public bool SaveDataCheck(GameRuntimeData data)
	{
		string tmpMD5 = data.md5;
		data.md5 = "Invalid";
		string MD5 = GameRuntimeData.Md5(JsonConvert.SerializeObject(data, Formatting.Indented));
		data.md5 = tmpMD5;
		bool flag = tmpMD5 != MD5;
		return !flag;
	}

	/// <summary>
	/// 进行MD5加密
	/// </summary>
	/// <param name="str"></param>
	/// <returns></returns>
	// Token: 0x06000232 RID: 562 RVA: 0x000149EC File Offset: 0x00012BEC
	public static string Md5(string str)
	{
		MD5 md5 = MD5.Create();
		byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
		return Convert.ToBase64String(s);
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00014A1C File Offset: 0x00012C1C
	public bool IsLocked(string Id)
	{
		return Singleton<GameConfigManager>.Instance.LockedIds.Contains(Id) && !this.UnLockDataConfigs.Contains(Id);
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000234 RID: 564 RVA: 0x00014A54 File Offset: 0x00012C54
	// (remove) Token: 0x06000235 RID: 565 RVA: 0x00014A8C File Offset: 0x00012C8C
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event PropertyChangedEventHandler PropertyChanged;

	// Token: 0x06000236 RID: 566 RVA: 0x00014AC1 File Offset: 0x00012CC1
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00014AE0 File Offset: 0x00012CE0
	protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		bool flag = EqualityComparer<T>.Default.Equals(field, value);
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			field = value;
			this.OnPropertyChanged(propertyName);
			result = true;
		}
		return result;
	}

	// Token: 0x040008EF RID: 2287
	public string md5 = "Invalid";

	// Token: 0x040008F0 RID: 2288
	public static readonly string savePath = Globals.SavePath + "/SaveData.sav";

	// Token: 0x040008F1 RID: 2289
	public static readonly string key = "yuanshenqidongyuanshenqidong1111";

	// Token: 0x040008F2 RID: 2290
	public static readonly string iv = "yuanshenqidongle";

	// Token: 0x040008F3 RID: 2291
	public static bool isEncrypted = true;

	// Token: 0x040008F4 RID: 2292
	public int playCount = 0;

	// Token: 0x040008F5 RID: 2293
	public ObfuscatedInt Level = 1;

	// Token: 0x040008F6 RID: 2294
	public ObfuscatedInt Exp = 0;

	// Token: 0x040008F7 RID: 2295
	public const int MaxExp = 100;

	// Token: 0x040008F8 RID: 2296
	public Dictionary<string, int> Gain = new Dictionary<string, int>
	{
		{
			"flushmoneychange",
			40
		},
		{
			"firstMoney",
			0
		},
		{
			"exMaxHp",
			0
		},
		{
			"Strength",
			0
		},
		{
			"Lucky",
			0
		},
		{
			"Perceive",
			0
		},
		{
			"Wisdom",
			0
		}
	};

	// Token: 0x040008F9 RID: 2297
	[JsonIgnore]
	public RoleTable roleTable;

	// Token: 0x040008FA RID: 2298
	public Dictionary<string, string> TutorialData = new Dictionary<string, string>();

	// Token: 0x040008FB RID: 2299
	public Dictionary<string, bool> IsTutorialCompleted = new Dictionary<string, bool>();

	// Token: 0x040008FC RID: 2300
	public ObfuscatedInt truth;

	// Token: 0x040008FD RID: 2301
	public string PlayerId = null;

	// Token: 0x040008FE RID: 2302
	public int Money = 0;

	// Token: 0x040008FF RID: 2303
	public List<HardTagEntry> HardTags = new List<HardTagEntry>();

	// Token: 0x04000900 RID: 2304
	public HashSet<string> UnLockDataConfigs = new HashSet<string>();

	// Token: 0x04000901 RID: 2305
	public readonly AchivementTable achivementTable = new AchivementTable();

	// Token: 0x04000902 RID: 2306
	public readonly Dictionary<string, int> BuyedItems = new Dictionary<string, int>();

	// Token: 0x04000903 RID: 2307
	public readonly ObservableCollection<DataConfig> Items = new ObservableCollection<DataConfig>();

	// Token: 0x04000904 RID: 2308
	public readonly List<DataConfig> CardData = new List<DataConfig>();

	// Token: 0x04000905 RID: 2309
	public readonly List<DataConfig> RelicData = new List<DataConfig>();

	// Token: 0x04000906 RID: 2310
	public readonly Dictionary<string, bool> MeetEvents = new Dictionary<string, bool>();

	// Token: 0x04000907 RID: 2311
	public readonly SettingTable settingTable = new SettingTable();
}

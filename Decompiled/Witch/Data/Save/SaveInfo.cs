using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Rougamo;
using UnityEditor;
using UnityEngine;

namespace Data.Save
{
	// Token: 0x0200022D RID: 557
	public class SaveInfo
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0008BCD8 File Offset: 0x00089ED8
		public static string SavePath
		{
			get
			{
				return Globals.SavePath + "/Saves";
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0008BCE9 File Offset: 0x00089EE9
		private string savePath
		{
			get
			{
				return SaveInfo.SavePath + "/" + this.Name + ".sav";
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0008BD05 File Offset: 0x00089F05
		private static bool isEncrypted
		{
			get
			{
				return GameRuntimeData.isEncrypted;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0008BD0C File Offset: 0x00089F0C
		private static string key
		{
			get
			{
				return GameRuntimeData.key;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0008BD13 File Offset: 0x00089F13
		private static string iv
		{
			get
			{
				return GameRuntimeData.iv;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x0008BD1C File Offset: 0x00089F1C
		public int EXHard
		{
			get
			{
				int AddReward = 0;
				foreach (DataConfig item in this.HardTags)
				{
					bool flag = !item.data.ContainsKey("Level");
					if (flag)
					{
						this.HardTags = new List<DataConfig>();
						return 0;
					}
					AddReward += item.data["Level"].ToInt() * 5;
				}
				return Math.Min(AddReward, 100);
			}
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0008BDC0 File Offset: 0x00089FC0
		public static SaveInfo Load(string name)
		{
			string savePath = SaveInfo.SavePath + "/" + name + ".sav";
			bool flag = !File.Exists(SaveInfo.SavePath + "/" + name + ".sav");
			SaveInfo result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool isEncrypted = SaveInfo.isEncrypted;
				string json;
				if (isEncrypted)
				{
					using (Aes aes = Aes.Create())
					{
						aes.Key = Encoding.UTF8.GetBytes(SaveInfo.key);
						aes.IV = Encoding.UTF8.GetBytes(SaveInfo.iv);
						byte[] encryptedData = File.ReadAllBytes(savePath);
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
					json = File.ReadAllText(savePath);
				}
				result = JsonConvert.DeserializeObject<SaveInfo>(json);
			}
			return result;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0008BF40 File Offset: 0x0008A140
		[IgnoreMo]
		public void Save()
		{
			bool flag = !Directory.Exists(SaveInfo.SavePath);
			if (flag)
			{
				Directory.CreateDirectory(SaveInfo.SavePath);
			}
			string json = JsonConvert.SerializeObject(this, Formatting.Indented);
			bool isEncrypted = SaveInfo.isEncrypted;
			if (isEncrypted)
			{
				using (Aes aes = Aes.Create())
				{
					aes.Key = Encoding.UTF8.GetBytes(SaveInfo.key);
					aes.IV = Encoding.UTF8.GetBytes(SaveInfo.iv);
					using (MemoryStream memoryStream = new MemoryStream())
					{
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
						{
							using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
							{
								streamWriter.Write(json);
							}
						}
						File.WriteAllBytes(this.savePath, memoryStream.ToArray());
					}
				}
			}
			else
			{
				File.WriteAllText(this.savePath, json);
			}
			AssetDatabase.Refresh();
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0008C080 File Offset: 0x0008A280
		public void Delete()
		{
			bool flag = File.Exists(this.savePath);
			if (flag)
			{
				File.Delete(this.savePath);
			}
			AssetDatabase.Refresh();
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0008C0B4 File Offset: 0x0008A2B4
		public T GetValue<T>(string key)
		{
			bool flag = this.GameVars.ContainsKey(key);
			if (flag)
			{
				try
				{
					return (T)((object)Convert.ChangeType(this.GameVars[key], typeof(T)));
				}
				catch
				{
					return default(T);
				}
			}
			return default(T);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0008C124 File Offset: 0x0008A324
		public T GetValue<T>(GameVar key)
		{
			bool flag = this.GameVars.ContainsKey(key.ToString());
			if (flag)
			{
				try
				{
					return (T)((object)Convert.ChangeType(this.GameVars[key.ToString()], typeof(T)));
				}
				catch
				{
					return default(T);
				}
			}
			return default(T);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0008C1AC File Offset: 0x0008A3AC
		public void SetValue(string key, string value)
		{
			this.GameVars[key] = value;
		}

		// Token: 0x04000EE5 RID: 3813
		public string Name;

		// Token: 0x04000EE6 RID: 3814
		public string CreatedTime;

		// Token: 0x04000EE7 RID: 3815
		public string Version;

		// Token: 0x04000EE8 RID: 3816
		public int HardLevel;

		// Token: 0x04000EE9 RID: 3817
		public bool isCheat;

		// Token: 0x04000EEA RID: 3818
		public MapTree mapTree;

		// Token: 0x04000EEB RID: 3819
		public string modeType = "Normal";

		// Token: 0x04000EEC RID: 3820
		public Dictionary<string, RoleTable> roleTable = new Dictionary<string, RoleTable>();

		// Token: 0x04000EED RID: 3821
		public MapTree.Node LastNode;

		// Token: 0x04000EEE RID: 3822
		public int Level = 0;

		// Token: 0x04000EEF RID: 3823
		public string Seed = "";

		// Token: 0x04000EF0 RID: 3824
		private bool aaa = false;

		// Token: 0x04000EF1 RID: 3825
		public Dictionary<string, string> GameVars = new Dictionary<string, string>
		{
			{
				"ExDeleteCard",
				"0"
			},
			{
				"ExLockDes",
				"0"
			},
			{
				"ExTough",
				"0"
			},
			{
				"RefreshCount",
				"999"
			},
			{
				"PriceMul",
				"100"
			},
			{
				"EXEnemyHp",
				"0"
			},
			{
				"EXEnemyAtk",
				"0"
			},
			{
				"ExDeleteDes",
				"0"
			},
			{
				"LimitTime",
				"False"
			},
			{
				"Difficulty",
				"1"
			},
			{
				"ToughMul",
				"1.5"
			},
			{
				"首领",
				"0"
			},
			{
				"精英",
				"0"
			},
			{
				"普通",
				"0"
			},
			{
				"普通事件",
				"0"
			},
			{
				"建筑",
				"0"
			},
			{
				"奖励",
				"0"
			},
			{
				"IsKing",
				"False"
			},
			{
				"LateThrow",
				"False"
			},
			{
				"UselessWis",
				"False"
			},
			{
				"ExpensiveCard",
				"0"
			}
		};

		// Token: 0x04000EF2 RID: 3826
		public DateTime startTime;

		// Token: 0x04000EF3 RID: 3827
		public DateTime endTime;

		// Token: 0x04000EF4 RID: 3828
		public List<string> EventRecord = new List<string>();

		// Token: 0x04000EF5 RID: 3829
		public GameOperInfo ItemOpers = new GameOperInfo();

		// Token: 0x04000EF6 RID: 3830
		public List<DataConfig> HardTags = new List<DataConfig>();

		// Token: 0x04000EF7 RID: 3831
		public List<DataConfig> ShareCards = new List<DataConfig>();

		// Token: 0x04000EF8 RID: 3832
		public List<DataConfig> ShareRelics = new List<DataConfig>();
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using Mirror;
using UnityEngine;

namespace Data.Save
{
	// Token: 0x0200022B RID: 555
	public static class GameSaveManager
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0008B764 File Offset: 0x00089964
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x0008B76B File Offset: 0x0008996B
		private static SaveInfo NowSave { get; set; }

		// Token: 0x060011A4 RID: 4516 RVA: 0x0008B774 File Offset: 0x00089974
		public static List<SaveInfo> LoadAll()
		{
			List<SaveInfo> saves = new List<SaveInfo>();
			bool flag = !Directory.Exists(SaveInfo.SavePath);
			List<SaveInfo> result;
			if (flag)
			{
				result = new List<SaveInfo>();
			}
			else
			{
				string[] files = Directory.GetFiles(SaveInfo.SavePath, "*.sav");
				foreach (string file in files)
				{
					string name = Path.GetFileNameWithoutExtension(file);
					SaveInfo saveInfo = SaveInfo.Load(name);
					bool flag2 = saveInfo != null;
					if (flag2)
					{
						saves.Add(saveInfo);
					}
				}
				result = saves;
			}
			return result;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0008B800 File Offset: 0x00089A00
		public static SaveInfo GetNowSave()
		{
			return GameSaveManager.NowSave;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0008B817 File Offset: 0x00089A17
		public static void Select(SaveInfo saveInfo)
		{
			GameSaveManager.NowSave = saveInfo;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0008B821 File Offset: 0x00089A21
		[Server]
		public static void Save()
		{
			if (!NetworkServer.active)
			{
				Debug.LogWarning("[Server] function 'System.Void Data.Save.GameSaveManager::Save()' called when server was not active");
				return;
			}
			SaveInfo nowSave = GameSaveManager.NowSave;
			if (nowSave != null)
			{
				nowSave.Save();
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0008B84A File Offset: 0x00089A4A
		public static void Delete()
		{
			SaveInfo nowSave = GameSaveManager.NowSave;
			if (nowSave != null)
			{
				nowSave.Delete();
			}
			GameSaveManager.NowSave = null;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0008B868 File Offset: 0x00089A68
		[Server]
		public static bool IsSave()
		{
			if (!NetworkServer.active)
			{
				Debug.LogWarning("[Server] function 'System.Boolean Data.Save.GameSaveManager::IsSave()' called when server was not active");
				return default(bool);
			}
			return GameSaveManager.NowSave != null;
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0008B8A4 File Offset: 0x00089AA4
		public static string GetSaveType()
		{
			bool flag = GameSaveManager.NowSave == null;
			string result;
			if (flag)
			{
				result = "Normal";
			}
			else
			{
				result = GameSaveManager.NowSave.modeType;
			}
			return result;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x0008B8D4 File Offset: 0x00089AD4
		public static MapTree MapTree
		{
			get
			{
				SaveInfo nowSave = GameSaveManager.NowSave;
				return (nowSave != null) ? nowSave.mapTree : null;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0008B8E8 File Offset: 0x00089AE8
		public static void UpdateRoles(RoleTable roleTable)
		{
			bool flag = GameSaveManager.NowSave == null;
			if (!flag)
			{
				GameSaveManager.NowSave.roleTable[roleTable.Id] = roleTable;
			}
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0008B91C File Offset: 0x00089B1C
		public static List<DataConfig> GetHardTags()
		{
			bool flag = GameSaveManager.NowSave == null;
			List<DataConfig> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = GameSaveManager.NowSave.HardTags;
			}
			return result;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0008B948 File Offset: 0x00089B48
		public static void AddEventRecord(string eventId)
		{
			bool flag = GameSaveManager.NowSave == null;
			if (!flag)
			{
				GameSaveManager.NowSave.EventRecord.Add(eventId);
			}
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0008B978 File Offset: 0x00089B78
		public static int GetEventRecordCount()
		{
			bool flag = GameSaveManager.NowSave == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = GameSaveManager.NowSave.EventRecord.Count;
			}
			return result;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0008B9AC File Offset: 0x00089BAC
		public static List<string> GetEventRecord()
		{
			bool flag = GameSaveManager.NowSave == null;
			List<string> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = GameSaveManager.NowSave.EventRecord;
			}
			return result;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0008B9D8 File Offset: 0x00089BD8
		public static void UpdateNode(MapTree.Node node)
		{
			bool flag = GameSaveManager.NowSave == null;
			if (!flag)
			{
				GameSaveManager.NowSave.LastNode = node;
			}
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0008BA00 File Offset: 0x00089C00
		public static MapTree.Node GetNode()
		{
			bool flag = GameSaveManager.NowSave == null;
			MapTree.Node result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = GameSaveManager.NowSave.LastNode;
			}
			return result;
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0008BA2C File Offset: 0x00089C2C
		public static void ApplySaveSc()
		{
			bool flag = GameSaveManager.NowSave == null;
			if (!flag)
			{
				foreach (DataConfig item in GameSaveManager.NowSave.HardTags)
				{
					item.scriptExecutor.RunScript("UseScript");
				}
			}
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0008BAA0 File Offset: 0x00089CA0
		public static Dictionary<string, RoleTable> GetRoleTables()
		{
			bool flag = GameSaveManager.NowSave == null;
			if (flag)
			{
				throw new Exception("No save data loaded.");
			}
			return GameSaveManager.NowSave.roleTable;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0008BAD4 File Offset: 0x00089CD4
		public static bool CheckCheat()
		{
			bool flag = GameSaveManager.NowSave == null;
			return flag || GameSaveManager.NowSave.isCheat;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0008BB00 File Offset: 0x00089D00
		public static int GetHardLevel()
		{
			bool flag = GameSaveManager.NowSave == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = GameSaveManager.NowSave.HardLevel;
			}
			return result;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0008BB2C File Offset: 0x00089D2C
		public static int GetEXHard()
		{
			bool flag = GameSaveManager.NowSave == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = GameSaveManager.NowSave.EXHard.ToInt();
			}
			return result;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0008BB64 File Offset: 0x00089D64
		public static int GetLevel()
		{
			bool flag = GameSaveManager.NowSave == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = GameSaveManager.NowSave.Level;
			}
			return result;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0008BB90 File Offset: 0x00089D90
		public static void SetLevel(int value)
		{
			bool flag = GameSaveManager.NowSave == null;
			if (!flag)
			{
				GameSaveManager.NowSave.Level = value;
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0008BBB8 File Offset: 0x00089DB8
		public static int GetSeed()
		{
			bool flag = GameSaveManager.NowSave == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = GameSaveManager.NowSave.Seed.ToInt();
			}
			return result;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0008BBEC File Offset: 0x00089DEC
		public static GameOperInfo GetItemOpers()
		{
			bool flag = GameSaveManager.NowSave == null;
			GameOperInfo result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = GameSaveManager.NowSave.ItemOpers;
			}
			return result;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0008BC18 File Offset: 0x00089E18
		public static T GetValue<T>(GameVar key)
		{
			bool flag = GameSaveManager.NowSave == null;
			T result;
			if (flag)
			{
				result = default(T);
			}
			else
			{
				result = GameSaveManager.NowSave.GetValue<T>(key);
			}
			return result;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0008BC50 File Offset: 0x00089E50
		public static T GetValue<T>(string key)
		{
			bool flag = GameSaveManager.NowSave == null;
			T result;
			if (flag)
			{
				result = default(T);
			}
			else
			{
				result = GameSaveManager.NowSave.GetValue<T>(key);
			}
			return result;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0008BC88 File Offset: 0x00089E88
		public static string SetValue(string key, object value)
		{
			bool flag = GameSaveManager.NowSave == null;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				GameSaveManager.NowSave.SetValue(key, value.ToString());
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0008BCC2 File Offset: 0x00089EC2
		public static void SetValue(GameVar key, object value)
		{
			GameSaveManager.SetValue(key.ToString(), value);
		}
	}
}

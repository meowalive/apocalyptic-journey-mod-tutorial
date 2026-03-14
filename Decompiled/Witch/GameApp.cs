using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Data.Save;
using kcp2k;
using Michsky.MUIP;
using Mirror;
using Mirror.FizzySteam;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Witch;
using Witch.UI;
using Witch.UI.Window;
using ZLinq;

// Token: 0x020000B0 RID: 176
public class GameApp : MonoBehaviour
{
	// Token: 0x0600059E RID: 1438 RVA: 0x000328A4 File Offset: 0x00030AA4
	private void Awake()
	{
		Application.targetFrameRate = 160;
		Camera.main.rect = new Rect(0f, 0f, 1f, 1f);
		bool flag = NetworkServer.active || NetworkClient.isConnected;
		if (flag)
		{
			LobbyManager.Instance.StopHost();
		}
		GameObject onlineManager = GameObject.Find("Network Manager");
		GameApp.STEAMBUILD = SteamManager.Initialized;
		bool flag2 = GameApp.STEAMBUILD && Application.internetReachability > NetworkReachability.NotReachable;
		if (flag2)
		{
			Singleton<GameConfigManager>.Instance.PlayerId = SteamUser.GetSteamID().ToString();
			Singleton<GameConfigManager>.Instance.PlayerName = SteamFriends.GetPersonaName();
			this.ChangeTransportToSteam();
		}
		else
		{
			this.ChangeTransportToKCP();
		}
		GameApp.Instance = this;
		KeyManager.playerAction.Main.Cancel.performed += delegate(InputAction.CallbackContext ctx)
		{
			bool flag3 = Witch.UI.UIManager.Instance.WindowObj != null;
			if (flag3)
			{
				Witch.UI.UIManager.Instance.WindowObj.GetComponent<ModalWindowManager>().TryClose();
			}
			else
			{
				ChatUI chatUI = Witch.UI.UIManager.Instance.GetUI<ChatUI>("ChatUI");
				bool flag4 = chatUI != null && chatUI.isOpen;
				if (!flag4)
				{
					List<ExitButton> exitbuttons = Witch.UI.UIManager.Instance.GetAllExitButtons();
					bool flag5 = exitbuttons.Count > 0;
					if (flag5)
					{
						for (int i = exitbuttons.Count - 1; i >= 0; i--)
						{
							bool activeInHierarchy = exitbuttons[i].gameObject.activeInHierarchy;
							if (activeInHierarchy)
							{
								bool flag6 = exitbuttons[i].OnCancelKey();
								if (flag6)
								{
									return;
								}
							}
						}
					}
					bool flag7 = Witch.UI.UIManager.Instance.GetUI<GameExitUI>("GameExitUI") != null;
					if (flag7)
					{
						Witch.UI.UIManager.Instance.GetUI<GameExitUI>("GameExitUI").ReturnAsync();
					}
					else
					{
						bool flag8 = Witch.UI.UIManager.Instance.GetUI<SettingUI>("SettingUI") != null && Witch.UI.UIManager.Instance.GetUI<SettingUI>("SettingUI").Active;
						if (flag8)
						{
							Witch.UI.UIManager.Instance.GetUI<SettingUI>("SettingUI").Hide();
						}
						else
						{
							Witch.UI.UIManager.Instance.ShowUI<SettingUI>("SettingUI", true);
							Witch.UI.UIManager.Instance.GetUI<SettingUI>("SettingUI").transform.SetAsLastSibling();
						}
					}
				}
			}
		};
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x000329AC File Offset: 0x00030BAC
	public void ChangeTransportToSteam()
	{
		GameObject onlineManager = GameObject.Find("Network Manager");
		onlineManager.GetComponent<MultiplexTransport>().transports = new Transport[2];
		onlineManager.GetComponent<MultiplexTransport>().transports[0] = (onlineManager.GetComponent<FizzySteamworks>() ?? onlineManager.gameObject.AddComponent<FizzySteamworks>());
		onlineManager.GetComponent<MultiplexTransport>().transports[1] = onlineManager.GetComponent<KcpTransport>();
		Transport.active = onlineManager.GetComponent<FizzySteamworks>();
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00032A18 File Offset: 0x00030C18
	public void ChangeTransportToKCP()
	{
		GameObject onlineManager = GameObject.Find("Network Manager");
		onlineManager.GetComponent<MultiplexTransport>().transports = new Transport[2];
		onlineManager.GetComponent<MultiplexTransport>().transports[0] = onlineManager.GetComponent<KcpTransport>();
		onlineManager.GetComponent<MultiplexTransport>().transports[1] = (onlineManager.GetComponent<FizzySteamworks>() ?? onlineManager.gameObject.AddComponent<FizzySteamworks>());
		Transport.active = onlineManager.GetComponent<KcpTransport>();
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00032A82 File Offset: 0x00030C82
	public void StartMenu()
	{
		AudioManager instance = AudioManager.Instance;
		if (instance != null)
		{
			instance.PlayBGMList("HouseBGM", false);
		}
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00032A9C File Offset: 0x00030C9C
	public void StartHouse()
	{
		bool flag = GameObject.Find("House") != null;
		if (!flag)
		{
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/House")) as GameObject;
			obj.transform.SetAsFirstSibling();
			obj.name = "House";
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayBGMList("HouseBGM", false);
			}
			bool flag2 = Singleton<GameRuntimeData>.Instance.IsTutorialCompleted.Count == 0;
			if (flag2)
			{
				Singleton<EventCenter>.Instance.EventTrigger("StartTutorial");
			}
		}
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00032B2C File Offset: 0x00030D2C
	public void StartBreaks()
	{
		bool flag = GameObject.Find("Breaks") != null;
		if (!flag)
		{
			this.NowBackground.SetActive(false);
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/Breaks")) as GameObject;
			obj.name = "Breaks";
		}
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00032B80 File Offset: 0x00030D80
	public void StartGame()
	{
		TMP_Text tmp_Text = this.debugText;
		if (tmp_Text != null)
		{
			tmp_Text.gameObject.SetActive(false);
		}
		try
		{
			Addressables.InitializeAsync().WaitForCompletion();
			Bloom bloom;
			GameObject.Find("Postprocess").GetComponent<Volume>().profile.TryGet<Bloom>(out bloom);
			bloom.downscale = new DownscaleParameter(BloomDownscaleMode.Quarter, false);
			Singleton<EffectManager>.Instance.Init();
			Witch.UI.UIManager.Instance.CloseAllUI();
			Witch.UI.UIManager.Instance.ShowUIAsync<ConsoleUI>("ConsoleUI", true).Forget<ConsoleUI>();
			Singleton<GameConfigManager>.Instance.Init();
			Singleton<GameRuntimeData>.Instance.Init();
			bool flag = !GameApp.STEAMBUILD;
			if (flag)
			{
				Singleton<GameConfigManager>.Instance.PlayerId = Singleton<GameRuntimeData>.Instance.PlayerId;
			}
			else
			{
				Singleton<GameRuntimeData>.Instance.PlayerId = Singleton<GameConfigManager>.Instance.PlayerId;
			}
			Singleton<GameConfigManager>.Instance.BuySave();
			Singleton<GameRuntimeData>.Instance.settingTable.Apply();
			this.SetTextFont(Singleton<GameRuntimeData>.Instance.settingTable.GetValue("字体"));
			SettingUI settingUI = Witch.UI.UIManager.Instance.ShowUI<SettingUI>("SettingUI", true);
			if (settingUI != null)
			{
				settingUI.Hide();
			}
			Witch.UI.UIManager.Instance.ShowUI<MainMenuUI>("MainMenuUI", true);
			Witch.UI.UIManager.Instance.PopUpTextInit();
			Witch.UI.UIManager.Instance.ShowUIAsync<CaptionUI>("CaptionUI", true).Forget<CaptionUI>();
			this.PreLoadUI();
			LocalizationSettings.SelectedLocaleChanged += delegate(Locale locale)
			{
				bool flag2 = locale.Identifier.Code == "zh-CN";
				if (flag2)
				{
					Singleton<GameRuntimeData>.Instance.settingTable.SetValue("Language", "简体中文");
				}
				else
				{
					bool flag3 = locale.Identifier.Code == "en";
					if (flag3)
					{
						Singleton<GameRuntimeData>.Instance.settingTable.SetValue("Language", "English");
					}
					else
					{
						bool flag4 = locale.Identifier.Code == "ja";
						if (flag4)
						{
							Singleton<GameRuntimeData>.Instance.settingTable.SetValue("Language", "Japanese");
						}
						else
						{
							bool flag5 = locale.Identifier.Code == "zh-Hant";
							if (flag5)
							{
								Singleton<GameRuntimeData>.Instance.settingTable.SetValue("Language", "繁体中文");
							}
						}
					}
				}
				Globals.Language = locale.Identifier.Code;
				Singleton<EventCenter>.Instance.EventTrigger(LanguageEvent.LanguageChange.ToString());
			};
			Singleton<TutorialManager>.Instance.Init();
			Singleton<TextTranslator>.Instance.Init((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.KeyWords).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			select x.ContainsKey("Keywords_" + Globals.Language) ? x["Keywords_" + Globals.Language] : x["Keywords"]).ToList<Dictionary<string, string>, string>());
		}
		catch (Exception e)
		{
			TMP_Text tmp_Text2 = this.debugText;
			if (tmp_Text2 != null)
			{
				tmp_Text2.SetText(e.Message);
			}
			throw;
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00032D9C File Offset: 0x00030F9C
	private void SetTextFont(string value)
	{
		bool flag = value == "SourceHanSerif";
		TMP_FontAsset target;
		if (flag)
		{
			target = ResourceLoader.Load<TMP_FontAsset>("Fonts/SourceFont/SourceHanSerif-Regular Fallback", true);
		}
		else
		{
			target = ResourceLoader.Load<TMP_FontAsset>("Fonts/SourceFont/HarmonyOS_Sans_Medium SDF", true);
		}
		bool flag2 = GameApp.Instance.MainFontAsset.fallbackFontAssetTable.Count > 0 && GameApp.Instance.MainFontAsset.fallbackFontAssetTable[0] == target;
		if (!flag2)
		{
			GameApp.Instance.MainFontAsset.fallbackFontAssetTable.Clear();
			GameApp.Instance.MainFontAsset.fallbackFontAssetTable.Add(target);
			target.ClearFontAssetData(false);
			target.ReadFontAssetDefinition();
			UniTask.DelayFrame(1, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
			{
				TMP_Text[] texts = UnityEngine.Object.FindObjectsOfType<TMP_Text>(false);
				foreach (TMP_Text text in texts)
				{
					text.ForceMeshUpdate(true, true);
				}
			}).Forget();
		}
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00032E90 File Offset: 0x00031090
	private void PreLoadUI()
	{
		DictionaryUI ui = Witch.UI.UIManager.Instance.ShowUI<DictionaryUI>("DictionaryUI", true);
		Witch.UI.UIManager.Instance.ShowUI<OutsiderShopUI>("OutsiderShopUI", true).Init();
		ui.gameObject.SetActive(false);
		ui.PreLoad().ContinueWith(delegate()
		{
			this.destroyCancellationToken.ThrowIfCancellationRequested();
			AffectionUI ui = Witch.UI.UIManager.Instance.ShowUI<AffectionUI>("AffectionUI", true);
			TaskUI ui2 = Witch.UI.UIManager.Instance.ShowUI<TaskUI>("TaskUI", true);
			ui.gameObject.SetActive(false);
			ui2.gameObject.SetActive(false);
			ui.Init();
		}).Forget();
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00032F0C File Offset: 0x0003110C
	public void ContinueGame(RoleTable roleTable)
	{
		int count = 0;
		bool flag = MapManager.Instance != null && MapManager.Instance.NowDice != null;
		if (flag)
		{
			count = MapManager.Instance.NowDice.WithRange(0, 100).Roll().Value;
		}
		else
		{
			count = UnityEngine.Random.Range(0, 100);
		}
		Witch.UI.UIManager.Instance.DoWithTurn(delegate
		{
			Singleton<GameRuntimeData>.Instance.roleTable = roleTable;
			bool flag2 = MapManager.Instance.Level >= 24;
			if (flag2)
			{
				bool flag3 = !string.IsNullOrEmpty(GameSaveManager.GetValue<string>(GameVar.MapScene3));
				if (flag3)
				{
					this.UpdateBack((SceneType)Enum.Parse(typeof(SceneType), GameSaveManager.GetValue<string>(GameVar.MapScene3)));
				}
				else
				{
					bool flag4 = count < 50;
					if (flag4)
					{
						GameSaveManager.SetValue(GameVar.MapScene3, SceneType.Chessboard.ToString());
						this.UpdateBack(SceneType.Chessboard);
					}
					else
					{
						GameSaveManager.SetValue(GameVar.MapScene3, SceneType.Castle.ToString());
						this.UpdateBack(SceneType.Castle);
					}
				}
			}
			else
			{
				bool flag5 = MapManager.Instance.Level >= 12;
				if (flag5)
				{
					bool flag6 = !string.IsNullOrEmpty(GameSaveManager.GetValue<string>(GameVar.MapScene2));
					if (flag6)
					{
						this.UpdateBack((SceneType)Enum.Parse(typeof(SceneType), GameSaveManager.GetValue<string>(GameVar.MapScene2)));
					}
					else
					{
						GameSaveManager.SetValue(GameVar.MapScene2, SceneType.PuppetTheater.ToString());
						this.UpdateBack(SceneType.PuppetTheater);
					}
				}
				else
				{
					bool flag7 = !string.IsNullOrEmpty(GameSaveManager.GetValue<string>(GameVar.MapScene1));
					if (flag7)
					{
						this.UpdateBack((SceneType)Enum.Parse(typeof(SceneType), GameSaveManager.GetValue<string>(GameVar.MapScene1)));
					}
					else
					{
						bool flag8 = count < 50;
						if (flag8)
						{
							GameSaveManager.SetValue(GameVar.MapScene1, SceneType.Courtyard.ToString());
							this.UpdateBack(SceneType.Courtyard);
						}
						else
						{
							GameSaveManager.SetValue(GameVar.MapScene1, SceneType.Forest.ToString());
							this.UpdateBack(SceneType.Forest);
						}
					}
				}
			}
			bool flag9 = RoleTable.Instance.IsStarted || (MapManager.Instance != null && MapManager.Instance.Level > 0);
			if (flag9)
			{
				bool flag10 = roleTable.Career == null && MapManager.Instance.ModeMapManager != null;
				if (flag10)
				{
					MapManager.Instance.ModeMapManager.InitRoleTable(roleTable);
				}
				bool flag11 = Witch.UI.UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI") != null;
				if (flag11)
				{
					bool flag12 = !RoleTable.Instance.IsStarted;
					if (flag12)
					{
						Witch.UI.UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI").NormalGame();
					}
					else
					{
						Witch.UI.UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI").Close();
					}
				}
				RoleTable.Instance.Listen();
				Witch.UI.UIManager.Instance.ShowUI<TopBarUI>("TopBarUI", true);
				Witch.UI.UIManager.Instance.ShowUI<BackpackUI>("BackpackUI", true);
				Witch.UI.UIManager.Instance.GetUI<BackpackUI>("BackpackUI").Init();
				Witch.UI.UIManager.Instance.ShowUI<TopBarUI>("TopBarUI", true);
				Witch.UI.UIManager.Instance.ShowUI<OutDeckUI>("OutDeckUI", true).Hide();
				Witch.UI.UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeCareer();
			}
			else
			{
				RoleTable.Instance.IsStarted = true;
				bool flag13 = !roleTable.VarsMap.ContainsKey("Wisdom");
				if (flag13)
				{
					bool flag14 = MapManager.Instance.ModeMapManager == null;
					if (flag14)
					{
						RoleTable.Instance.Init();
					}
					else
					{
						MapManager.Instance.ModeMapManager.InitRoleTable(roleTable);
					}
				}
				roleTable.Listen();
				Witch.UI.UIManager.Instance.ShowUI<TopBarUI>("TopBarUI", true);
				Witch.UI.UIManager.Instance.ShowUI<BackpackUI>("BackpackUI", true);
				Witch.UI.UIManager.Instance.GetUI<BackpackUI>("BackpackUI").Init();
				bool flag15 = Witch.UI.UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI") != null;
				if (flag15)
				{
					Witch.UI.UIManager.Instance.GetUI<GameEntryUI>("GameEntryUI").NormalGame();
				}
				bool flag16 = this.NowBackground != null;
				if (flag16)
				{
					this.NowBackground.transform.SetAsLastSibling();
				}
				Witch.UI.UIManager.Instance.ShowUI<OutDeckUI>("OutDeckUI", true).Hide();
				bool flag17 = roleTable.Career == null;
				if (flag17)
				{
					RoleTable.Instance.Career = new DataConfig(Singleton<GameConfigManager>.Instance.GetTable(DataType.Career).Getlines()[0]["Id"], DataType.Career);
				}
				GameSaveManager.ApplySaveSc();
				Witch.UI.UIManager.Instance.GetUI<TopBarUI>("TopBarUI").ChangeCareer();
			}
			bool flag18 = NetworkServer.active && NetworkClient.isConnected;
			if (flag18)
			{
				MapManager.Instance.RpcTryChange();
			}
		});
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00032FA4 File Offset: 0x000311A4
	public void UpdateBack(SceneType belong)
	{
		bool flag = this.NowBackground != null;
		if (flag)
		{
			this.NowBackground.SetActive(false);
			UnityEngine.Object.Destroy(this.NowBackground);
		}
		this.NowBackground = (UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/Scene/" + belong.ToString())) as GameObject);
		this.NowBackground.name = belong.ToString();
		bool steambuild = GameApp.STEAMBUILD;
		if (steambuild)
		{
			SteamFriends.SetRichPresence("now_map", belong.ToString());
		}
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00033048 File Offset: 0x00031248
	public void GameOver()
	{
		bool flag = !NetworkServer.active;
		if (flag)
		{
			Witch.UI.UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
		}
		else
		{
			PlayerManager.Instance.GameOver();
		}
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00033084 File Offset: 0x00031284
	[DebuggerStepThrough]
	public UniTask StartFight(string level)
	{
		GameApp.<StartFight>d__19 <StartFight>d__ = new GameApp.<StartFight>d__19();
		<StartFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartFight>d__.<>4__this = this;
		<StartFight>d__.level = level;
		<StartFight>d__.<>1__state = -1;
		<StartFight>d__.<>t__builder.Start<GameApp.<StartFight>d__19>(ref <StartFight>d__);
		return <StartFight>d__.<>t__builder.Task;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x000330D0 File Offset: 0x000312D0
	[DebuggerStepThrough]
	public UniTask StartFakeFight(string level)
	{
		GameApp.<StartFakeFight>d__20 <StartFakeFight>d__ = new GameApp.<StartFakeFight>d__20();
		<StartFakeFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartFakeFight>d__.<>4__this = this;
		<StartFakeFight>d__.level = level;
		<StartFakeFight>d__.<>1__state = -1;
		<StartFakeFight>d__.<>t__builder.Start<GameApp.<StartFakeFight>d__20>(ref <StartFakeFight>d__);
		return <StartFakeFight>d__.<>t__builder.Task;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x0003311C File Offset: 0x0003131C
	[DebuggerStepThrough]
	public void OpenBackpack(InputAction.CallbackContext context)
	{
		GameApp.<OpenBackpack>d__21 <OpenBackpack>d__ = new GameApp.<OpenBackpack>d__21();
		<OpenBackpack>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		<OpenBackpack>d__.<>4__this = this;
		<OpenBackpack>d__.context = context;
		<OpenBackpack>d__.<>1__state = -1;
		<OpenBackpack>d__.<>t__builder.Start<GameApp.<OpenBackpack>d__21>(ref <OpenBackpack>d__);
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x0003315C File Offset: 0x0003135C
	public void ReturnToMenu()
	{
		Resources.Load<Material>("Material/PostProcess/ScreenLight").SetInt("_Enabled", 0);
		Material material = Resources.Load<Material>("Material/PostProcess/Blur");
		if (material != null)
		{
			material.DisableKeyword("_BLUR_ON");
		}
		bool flag = GameObject.Find("House") != null;
		if (!flag)
		{
			UnityEngine.Object.Destroy(this.NowBackground);
			bool flag2 = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
			if (flag2)
			{
				foreach (KeyValuePair<string, StatusManager> role in FightManager.Instance.statuses)
				{
					bool flag3 = role.Value != null && role.Value.fatherObject != null;
					if (flag3)
					{
						UnityEngine.Object.Destroy(role.Value.fatherObject.gameObject);
					}
				}
				Witch.UI.UIManager.Instance.CloseUI("FightUI");
				FightManager.Instance.ChangeUnit(FightType.None);
				FightManager.Instance.ActionQueue.Clear();
				Singleton<EventCenter>.Instance.Clear(new EventDispose[]
				{
					EventDispose.OnFightEnd,
					EventDispose.OnTrigger
				});
			}
			EventUI ui = Witch.UI.UIManager.Instance.GetUI<EventUI>("EventUI");
			if (ui != null)
			{
				ui.Close();
			}
			Witch.UI.UIManager.Instance.CloseUI("GameEntryUI");
			Witch.UI.UIManager.Instance.CloseUI("GameExitUI");
			Witch.UI.UIManager.Instance.CloseUI("TopBarUI");
			Witch.UI.UIManager.Instance.CloseUI("OutDeckUI");
			Witch.UI.UIManager.Instance.CloseUI("CardChoiceUI");
			Witch.UI.UIManager.Instance.CloseUI("WarehouseUI");
			Witch.UI.UIManager.Instance.CloseUI("BackpackUI");
			Witch.UI.UIManager.Instance.CloseUI("SafeBoxUI");
			Witch.UI.UIManager.Instance.CloseUI("DestinyTreeUI");
			Witch.UI.UIManager.Instance.CloseUI("CardEnchUI");
			UniTask.WaitForSeconds(0.4f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
			{
				Witch.UI.UIManager.Instance.CloseUI("FightUI");
			}).Forget();
			Witch.UI.UIManager.Instance.CloseUI("ShopUI");
			Witch.UI.UIManager.Instance.CloseUI("BattleRewardsUI");
			bool flag4 = MapManager.Instance != null;
			if (flag4)
			{
				MapManager.Instance.CloseMapUI();
			}
			bool flag5 = GameObject.Find("Breaks") != null;
			if (!flag5)
			{
				Witch.UI.UIManager.Instance.CloseUI("DialogueUI");
				UniTask.WaitForSeconds(0.4f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
				{
					Singleton<GameRuntimeData>.Instance.roleTable = null;
					this.StartHouse();
				}).Forget();
			}
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x00033448 File Offset: 0x00031648
	public void SetSteamRichState(string state)
	{
		bool flag = !GameApp.STEAMBUILD;
		if (!flag)
		{
			bool flag2 = string.IsNullOrEmpty(state);
			if (flag2)
			{
				SteamFriends.ClearRichPresence();
			}
			else
			{
				SteamFriends.SetRichPresence("gamestatus", state);
				bool flag3 = PlayerManager.Instance != null && PlayerManager.Instance.LobbyInfos != null && PlayerManager.Instance.LobbyInfos.AddedPlayers != null;
				if (flag3)
				{
					SteamFriends.SetRichPresence("team_state", PlayerManager.Instance.LobbyInfos.AddedPlayers.Count.ToString() + "/" + 2.ToString());
				}
				RoleTable instance = RoleTable.Instance;
				bool flag4 = ((instance != null) ? instance.Career : null) != null && MapManager.Instance != null;
				if (flag4)
				{
					SteamFriends.SetRichPresence("now_career", RoleTable.Instance.Career.data["Id"]);
					SteamFriends.SetRichPresence("now_level", MapManager.Instance.Level.ToString());
				}
				SteamFriends.SetRichPresence("steam_display", "#Status");
			}
		}
	}

	// Token: 0x04000A35 RID: 2613
	public static GameApp Instance;

	// Token: 0x04000A36 RID: 2614
	public TMP_Text debugText;

	// Token: 0x04000A37 RID: 2615
	public GameObject NowBackground;

	// Token: 0x04000A38 RID: 2616
	public List<AddressableReference<TMP_FontAsset>> WarmupFontAssets;

	// Token: 0x04000A39 RID: 2617
	public static bool STEAMBUILD;

	// Token: 0x04000A3A RID: 2618
	public static bool OFFLINE;

	// Token: 0x04000A3B RID: 2619
	public TMP_FontAsset MainFontAsset;
}

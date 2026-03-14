using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;
using ZLinq;
using ZLinq.Linq;

// Token: 0x0200008A RID: 138
public class FightInit : FightUnit
{
	// Token: 0x060003E6 RID: 998 RVA: 0x00020A4C File Offset: 0x0001EC4C
	public override void Init()
	{
		FightUI fightUI = UIManager.Instance.ShowUI<FightUI>("FightUI", true);
		fightUI.gameObject.SetActive(false);
		foreach (DataConfig item in RoleTable.Instance.cardList)
		{
			item.Vars["ThisCount"] = "0";
		}
		fightUI.Init();
		Fight_Win.IsWin = true;
		FightManager.Instance.ResetWaitCount();
		FightCardManager.Instance.Init();
		this.RpcLoadRoles();
		Dictionary<string, string> levelData = Singleton<GameConfigManager>.Instance.GetOne(DataType.Level, FightManager.Instance.level);
		List<AudioClip> musicList = (from s in (from s in levelData["BGM"].Replace(" ", "").Split(',', StringSplitOptions.None).AsValueEnumerable<string>()
		select ResourceLoader.LoadAll<AudioClip>("Musics/" + s)).SelectMany((AudioClip[] x) => x)
		where s != null
		select s).ToList<Where<SelectMany<ArraySelect<string, AudioClip[]>, AudioClip[], AudioClip>, AudioClip>, AudioClip>();
		bool flag = musicList != null && musicList.Count > 0;
		if (flag)
		{
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayBGMList(musicList, levelData["BGM"].Replace(" ", ""), false);
			}
		}
		else
		{
			bool inHighTide = RoleTable.Instance.InHighTide;
			if (inHighTide)
			{
				AudioManager instance2 = AudioManager.Instance;
				if (instance2 != null)
				{
					instance2.PlayBGMList("BOSSBGM", false);
				}
			}
			else
			{
				BGMList bgmList = GameApp.Instance.NowBackground.transform.Find("com").GetComponent<SceneInfo>().bgmList;
				AudioManager instance3 = AudioManager.Instance;
				if (instance3 != null)
				{
					instance3.PlayBGMList(bgmList, false);
				}
			}
		}
		GameApp.Instance.NowBackground.transform.SetAsLastSibling();
		EnemyManager.Instance.LoadRes(FightManager.Instance.level);
		UIManager.Instance.GetUI<FightUI>("FightUI").gameObject.SetActive(true);
		fightUI.gameObject.SetActive(true);
		FightUI.IsReset = false;
		this.ApplyBlessingRelic();
		UIManager.Instance.GetUI<FightUI>("FightUI").InitSkill();
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00020CCC File Offset: 0x0001EECC
	public void ApplyBlessingRelic()
	{
		Singleton<BlessingRelic>.Instance.Clear();
		RoleTable.Instance.Career.scriptExecutor.Clear();
		RoleTable.Instance.Career.scriptExecutor.Self = FightPlayer.Instance.Status;
		RoleTable.Instance.Career.scriptExecutor.Object.Clear();
		RoleTable.Instance.Career.scriptExecutor.Object.Add(FightPlayer.Instance.Status);
		RoleTable.Instance.Career.scriptExecutor.RunScript("SkillScript");
		Singleton<BlessingRelic>.Instance.Init().Apply(FightManager.Instance.statuses[FightPlayer.Instance.InstanceId]);
		foreach (KeyValuePair<string, StatusManager> item in FightManager.Instance.statuses)
		{
			bool flag = item.Value != null;
			if (flag)
			{
				Singleton<EventCenter>.Instance.EventTrigger("Init" + item.Key);
			}
		}
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00020E10 File Offset: 0x0001F010
	public void RpcLoadRoles()
	{
		int i = FightManager.Instance.TempRoleList.Count;
		float deltaX = (i > 1) ? 2.5f : 3.5f;
		float centerX = -3.5f;
		Singleton<TempDataManager>.Instance.RoleStatusMap.Clear();
		float y = GameApp.Instance.NowBackground.transform.Find("com").GetComponent<SceneInfo>().ground_y;
		int j = 0;
		foreach (KeyValuePair<string, string> item in FightManager.Instance.TempRoleList)
		{
			RoleTable role = JsonConvert.DeserializeObject<RoleTable>(item.Value);
			GameObject obj = UnityEngine.Object.Instantiate(ResourceLoader.Load("Model/player")) as GameObject;
			Singleton<TempDataManager>.Instance.RoleStatusMap.TryAdd(item.Key, new List<string>());
			obj.transform.localScale = new Vector3(1f, 1f, 1f);
			bool flag = item.Key != FightManager.Instance.selfIndex;
			if (flag)
			{
				obj.AddComponent<OtherPlayer>().Init(item.Key);
			}
			else
			{
				bool isRet = FightManager.Instance.IsRet;
				if (isRet)
				{
					RoleTable.Instance.ResetFight(role);
				}
				obj.AddComponent<FightPlayer>().Init(FightManager.Instance.selfIndex);
			}
			FightManager.Instance.statuses[item.Key] = obj.GetComponent<StatusManager>();
			bool isServer = FightManager.Instance.isServer;
			if (isServer)
			{
				FightManager.Instance.statusData.Add(item.Key, new StatusDataTransfer(obj.GetComponent<StatusManager>()));
			}
			obj.GetComponent<FightObject>().Status.animatedState = IStatusManager.AnimatedState.Idle;
			obj.GetComponent<FightObject>().InitBound(null, true);
			float x = centerX + ((float)(i - 1 - j) - (float)(i - 1) / 2f) * deltaX;
			obj.GetComponent<StatusManager>().SetPosition(new Vector3(x, y - obj.transform.Find("bottom").localPosition.y, 0f));
			j++;
		}
	}
}

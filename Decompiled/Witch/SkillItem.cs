using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Witch.UI;
using Witch.UI.Component;
using Witch.UI.Window;

// Token: 0x020000A8 RID: 168
public class SkillItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060004EC RID: 1260 RVA: 0x0002A346 File Offset: 0x00028546
	public IScriptExecutor scriptExecutor
	{
		get
		{
			return this.dataConfig.scriptExecutor;
		}
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x0002A353 File Offset: 0x00028553
	public void RunScript(string ScriptName)
	{
		this.scriptExecutor.RunScript(ScriptName);
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0002A364 File Offset: 0x00028564
	public virtual void Init(IDataConfig dataConfig)
	{
		base.transform.Find("Icon").GetComponent<Image>().DOColor(new Color(0.85f, 0.85f, 0.85f), 0f);
		bool flag = FightPlayer.Instance == null;
		if (!flag)
		{
			this.status = FightPlayer.Instance.Status;
			bool flag2 = this.status.IsNull();
			if (!flag2)
			{
				this.dataConfig = dataConfig;
				this.data = dataConfig.data;
				this.Vars = dataConfig.Vars;
				this.Vars["ThisCount"] = "0";
				this.scriptExecutor.Self = this.status;
				bool flag3 = this.scriptExecutor.Self.IsNull();
				if (flag3)
				{
					Debug.LogError("卡牌" + this.data["Id"] + "脚本执行者为空");
				}
				this.scriptExecutor.Object.Clear();
				this.scriptExecutor.Object.Add(FightPlayer.Instance.Status);
				bool flag4 = EnemyManager.Instance != null && EnemyManager.Instance.enemyList.Count > 0;
				if (flag4)
				{
					this.scriptExecutor.Target = EnemyManager.Instance.enemyList[0].Status;
				}
				this.scriptExecutor.dataConfig.Vars["Usable"] = "1";
				this.RegisterEvent();
				this.DataUpdate();
			}
		}
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0002A500 File Offset: 0x00028700
	public void Awake()
	{
		base.gameObject.AddComponent<KeywordDisplay>();
		EventTrigger trigger = base.gameObject.AddComponent<EventTrigger>();
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerDown;
		entry.callback.AddListener(delegate(BaseEventData data)
		{
			this.OnPointerDown((PointerEventData)data);
		});
		trigger.triggers.Add(entry);
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x0002A558 File Offset: 0x00028758
	public virtual void DataUpdate()
	{
		bool flag = this == null || base.transform == null || base.transform.gameObject == null;
		if (!flag)
		{
			this.RunScript("InitScript");
			List<string> keyWords = new List<string>();
			string tooltipText = "";
			tooltipText = string.Concat(new string[]
			{
				tooltipText,
				"<color=",
				Singleton<TempDataManager>.Instance.rareColorMap1[Singleton<TempDataManager>.Instance.RarityMap[this.dataConfig.data["Rarity"]]],
				">",
				"rarity".Localize("Glossary"),
				": ",
				Singleton<TempDataManager>.Instance.RarityMap[this.dataConfig.data["Rarity"]].Localize("Tips"),
				"</color>\n"
			});
			tooltipText = string.Concat(new string[]
			{
				tooltipText,
				"<color=white>",
				"effect".Localize("Glossary"),
				": ",
				this.dataConfig.Description().Highlight(keyWords),
				"</color>\n"
			});
			base.transform.GetComponent<KeywordDisplay>().SetText(this.data.Localize("Name"), tooltipText, keyWords, null, null, "Skill");
			this.UpdateSkillTime();
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0002A6DC File Offset: 0x000288DC
	public void UpdateSkillTime()
	{
		bool flag = RoleTable.Instance.SkillTime.ContainsKey(this.dataConfig.data["Id"]);
		if (flag)
		{
			bool flag2 = RoleTable.Instance.SkillTime[this.dataConfig.data["Id"]] > 0;
			if (flag2)
			{
				base.transform.Find("CD").gameObject.SetActive(true);
				base.transform.Find("CD/val").GetComponent<TMP_Text>().SetDigitText(RoleTable.Instance.SkillTime[this.dataConfig.data["Id"]].ToString());
			}
			else
			{
				base.transform.Find("CD").gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0002A7C8 File Offset: 0x000289C8
	public void RegisterEvent()
	{
		Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), delegate()
		{
			this.DataUpdate();
		}, this, EventDispose.None);
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0002A800 File Offset: 0x00028A00
	public void OnDisable()
	{
		Singleton<EventCenter>.Instance.Clear(this);
		base.StopAllCoroutines();
		UIManager.Instance.HideUI("LineUI");
		bool flag = this.isLine;
		if (flag)
		{
			this.isLine = false;
			Cursor.visible = true;
			this.currentSystem.enabled = true;
		}
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0002A858 File Offset: 0x00028A58
	public virtual bool TryUse()
	{
		bool flag = this.status.IsNull() || this.status.state == IStatusManager.State.Dead || this.status.state == IStatusManager.State.NoAction || FightManager.Instance.fightType != FightType.Player;
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			bool flag2 = CardItem.canUse && RoleTable.Instance.SkillTime.ContainsKey(this.dataConfig.data["Id"]) && RoleTable.Instance.SkillTime[this.dataConfig.data["Id"]] == 0;
			result = flag2;
		}
		return result;
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x0002A914 File Offset: 0x00028B14
	public void OnPointerDown(PointerEventData eventData)
	{
		bool flag = this.isLine || this.Vars == null;
		if (!flag)
		{
			bool flag2 = Time.time - this.lasttime < 0.1f;
			if (!flag2)
			{
				bool flag3 = this.Vars["BaseScript"] == "CommonCardItem";
				if (flag3)
				{
					this.TrueUse();
				}
				else
				{
					bool canUse = CardItem.canUse;
					if (canUse)
					{
						bool flag4 = !this.TryUse();
						if (!flag4)
						{
							this.isLine = true;
							LineUI lineui = UIManager.Instance.ShowUI<LineUI>("LineUI", true);
							lineui.SetStartPos(base.transform.position);
							Cursor.visible = false;
							base.StopAllCoroutines();
							base.StartCoroutine(this.OnMouseDownRight());
							this.lasttime = Time.time;
						}
					}
				}
			}
		}
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x0002A9F4 File Offset: 0x00028BF4
	private IEnumerator OnMouseDownRight()
	{
		this.currentSystem = EventSystem.current;
		this.currentSystem.enabled = false;
		for (;;)
		{
			bool flag = KeyManager.playerAction.Main.RightClick.WasPressedThisFrame();
			if (flag)
			{
				break;
			}
			bool flag2 = UIManager.Instance.GetUI<LineUI>("LineUI") != null;
			if (flag2)
			{
				UIManager.Instance.GetUI<LineUI>("LineUI").SetEndPos(null);
			}
			this.CheckRayToEnemy();
			yield return null;
		}
		this.currentSystem.enabled = true;
		bool flag3 = this.hitEnemy != null;
		if (flag3)
		{
			this.hitEnemy.OnUnSelect();
			this.hitEnemy = null;
		}
		bool flag4 = UIManager.Instance.GetUI<LineUI>("LineUI") != null;
		if (flag4)
		{
			UIManager.Instance.GetUI<LineUI>("LineUI").Hide();
		}
		this.isLine = false;
		Cursor.visible = true;
		yield break;
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0002AA04 File Offset: 0x00028C04
	private void CheckRayToEnemy()
	{
		Ray ray = Camera.main.ScreenPointToRay(KeyManager.playerAction.Main.Point.ReadValue<Vector2>());
		RaycastHit hit;
		bool flag = Physics.Raycast(ray, out hit, 10000f, LayerMask.GetMask(new string[]
		{
			"Enemy",
			"Player"
		}));
		if (flag)
		{
			StatusManager nowEnemy = hit.transform.GetComponent<StatusManager>();
			bool flag2 = nowEnemy != null && nowEnemy != this.hitEnemy;
			if (flag2)
			{
				bool flag3 = this.hitEnemy != null;
				if (flag3)
				{
					this.hitEnemy.OnUnSelect();
				}
				this.hitEnemy = nowEnemy;
			}
			else
			{
				bool flag4 = nowEnemy == null;
				if (flag4)
				{
					bool flag5 = this.hitEnemy != null;
					if (flag5)
					{
						this.hitEnemy.OnUnSelect();
						this.hitEnemy = null;
						this.scriptExecutor.Target = null;
					}
				}
			}
			bool flag6 = this.hitEnemy != null && this.hitEnemy.CurHp > 0 && this.hitEnemy.enabled;
			if (flag6)
			{
				this.hitEnemy.OnSelect();
			}
			else
			{
				bool flag7 = this.hitEnemy != null;
				if (flag7)
				{
					this.hitEnemy.OnUnSelect();
					this.hitEnemy = null;
					this.scriptExecutor.Target = null;
				}
			}
			bool flag8 = (KeyManager.playerAction.Main.Click.WasPressedThisFrame() || KeyManager.playerAction.Main.Click.WasReleasedThisFrame()) && this.hitEnemy != null && this.hitEnemy.CurHp != 0 && this.hitEnemy.enabled;
			if (flag8)
			{
				this.currentSystem.enabled = true;
				base.StopAllCoroutines();
				Cursor.visible = true;
				this.isLine = false;
				UIManager.Instance.HideUI("LineUI");
				this.TrueUse();
				this.hitEnemy.OnUnSelect();
				this.hitEnemy = null;
				this.scriptExecutor.Target = null;
			}
		}
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0002AC38 File Offset: 0x00028E38
	public void TrueUse()
	{
		bool flag = this.TryUse();
		if (flag)
		{
			this.scriptExecutor.Target = this.hitEnemy;
			this.RunScript("UseScript");
			IStatusManager self = this.scriptExecutor.Self;
			if (self != null)
			{
				self.PlayVocal(IStatusManager.VocalState.Skill);
			}
			this.RunScript("InitScript");
			this.DataUpdate();
			FightPlayer.Instance.Status.UpdateBuff();
			FightUI ui = UIManager.Instance.GetUI<FightUI>("FightUI");
			if (ui != null)
			{
				ui.CallActionAnimation(this.scriptExecutor);
			}
		}
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x0002ACCC File Offset: 0x00028ECC
	public void OnPointerEnter(PointerEventData eventData)
	{
		base.transform.Find("Icon").GetComponent<Image>().DOColor(Color.white, 0.2f);
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x0002ACF4 File Offset: 0x00028EF4
	public void OnPointerExit(PointerEventData eventData)
	{
		base.transform.Find("Icon").GetComponent<Image>().DOColor(new Color(0.85f, 0.85f, 0.85f), 0.2f);
	}

	// Token: 0x040009FF RID: 2559
	public IDataConfig dataConfig;

	// Token: 0x04000A00 RID: 2560
	public IDictionary<string, string> data;

	// Token: 0x04000A01 RID: 2561
	public IDictionary<string, string> Vars;

	// Token: 0x04000A02 RID: 2562
	public IStatusManager status;

	// Token: 0x04000A03 RID: 2563
	private EventSystem currentSystem;

	// Token: 0x04000A04 RID: 2564
	private bool isLine = false;

	// Token: 0x04000A05 RID: 2565
	public float lasttime;

	// Token: 0x04000A06 RID: 2566
	private StatusManager hitEnemy;
}

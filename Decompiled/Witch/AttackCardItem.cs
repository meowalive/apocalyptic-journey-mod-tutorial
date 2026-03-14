using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Data.Save;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x0200000A RID: 10
public class AttackCardItem : CommonCardItem, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600002E RID: 46 RVA: 0x000026C8 File Offset: 0x000008C8
	// (set) Token: 0x0600002F RID: 47 RVA: 0x000026D0 File Offset: 0x000008D0
	public bool isLine { get; private set; }

	// Token: 0x06000030 RID: 48 RVA: 0x000026D9 File Offset: 0x000008D9
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000026D9 File Offset: 0x000008D9
	public override void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x000026DC File Offset: 0x000008DC
	public override void Init(DataConfig dataConfig)
	{
		bool flag = dataConfig == null;
		if (!flag)
		{
			bool flag2 = FightPlayer.Instance == null;
			if (!flag2)
			{
				this.status = (FightPlayer.Instance.Status as StatusManager);
				bool flag3 = FightPlayer.Instance.Status.IsNull();
				if (!flag3)
				{
					this.dataConfig = dataConfig;
					this.data = dataConfig.data;
					this.Vars = dataConfig.Vars;
					base.scriptExecutor.Self = this.status;
					bool flag4 = RoleTable.Instance.enchasedDict.ContainsKey(dataConfig.InstanceID);
					if (flag4)
					{
						this.enchScriptExecutor = RoleTable.Instance.enchasedDict[dataConfig.InstanceID].scriptExecutor;
						this.enchScriptExecutor.Self = this.status;
						this.enchScriptExecutor.Object.Clear();
					}
					base.scriptExecutor.Object.Clear();
					base.scriptExecutor.dataConfig.Vars["Usable"] = "1";
					ICard.SetCardStyle(base.transform, dataConfig);
					this.DataUpdate();
					this.DrawEffect();
				}
			}
		}
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000026D9 File Offset: 0x000008D9
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002818 File Offset: 0x00000A18
	public new void OnPointerDown(PointerEventData eventData)
	{
		bool isLine = this.isLine;
		if (!isLine)
		{
			bool flag = FightManager.Instance == null || FightManager.Instance.fightType != FightType.Player;
			if (!flag)
			{
				bool canUse = CardItem.canUse;
				if (canUse)
				{
					this.BeginLineMode();
				}
			}
		}
	}

	/// <summary> 键盘快捷键选牌时调用，进入箭头选目标模式。 </summary>
	// Token: 0x06000035 RID: 53 RVA: 0x0000286C File Offset: 0x00000A6C
	public void BeginLineMode()
	{
		bool isLine = this.isLine;
		if (!isLine)
		{
			bool flag = !UIUtil.CheckClickable(base.transform);
			if (!flag)
			{
				this.isLine = true;
				this.currentSystem = EventSystem.current;
				LineUI lineui = UIManager.Instance.ShowUI<LineUI>("LineUI", true);
				lineui.SetStartPos(base.transform.position);
				Cursor.visible = false;
				base.StopAllCoroutines();
				base.StartCoroutine(this.OnMouseDownRight());
			}
		}
	}

	/// <summary> 键盘松开数字键取消选牌时调用。 </summary>
	// Token: 0x06000036 RID: 54 RVA: 0x000028EC File Offset: 0x00000AEC
	public void CancelLineMode()
	{
		bool flag = !this.isLine;
		if (!flag)
		{
			base.StopAllCoroutines();
			this.isLine = false;
			Cursor.visible = true;
			bool flag2 = this.hitEnemy != null;
			if (flag2)
			{
				this.hitEnemy.OnUnSelect();
				this.hitEnemy = null;
			}
			base.scriptExecutor.Target = null;
			string init;
			bool flag3 = this.data != null && this.data.TryGetValue("InitScript", out init) && init != null && init.Contains("Damage");
			if (flag3)
			{
				this.DataUpdate();
			}
			bool flag4 = UIManager.Instance.GetUI<LineUI>("LineUI") != null;
			if (flag4)
			{
				UIManager.Instance.GetUI<LineUI>("LineUI").Hide();
			}
			bool flag5 = this.currentSystem != null;
			if (flag5)
			{
				this.currentSystem.enabled = true;
			}
		}
	}

	/// <summary> 键盘松开数字键时调用：有目标则打出，无目标则取消。 </summary>
	// Token: 0x06000037 RID: 55 RVA: 0x000029DC File Offset: 0x00000BDC
	public void CommitOrCancelFromKeyboard()
	{
		bool flag = !this.isLine;
		if (!flag)
		{
			bool flag2 = !UIUtil.CheckClickable(base.transform);
			if (!flag2)
			{
				base.StopAllCoroutines();
				this.isLine = false;
				Cursor.visible = true;
				bool flag3 = UIManager.Instance.GetUI<LineUI>("LineUI") != null;
				if (flag3)
				{
					UIManager.Instance.GetUI<LineUI>("LineUI").Hide();
				}
				bool flag4 = this.currentSystem != null;
				if (flag4)
				{
					this.currentSystem.enabled = true;
				}
				bool flag5 = this.hitEnemy != null && this.hitEnemy.CurHp > 0 && this.hitEnemy.enabled;
				if (flag5)
				{
					this.TrueUse();
					this.hitEnemy.OnUnSelect();
					this.hitEnemy = null;
					base.scriptExecutor.Target = null;
				}
				else
				{
					bool flag6 = this.hitEnemy != null;
					if (flag6)
					{
						this.hitEnemy.OnUnSelect();
						this.hitEnemy = null;
					}
					base.scriptExecutor.Target = null;
					string init;
					bool flag7 = this.data != null && this.data.TryGetValue("InitScript", out init) && init != null && init.Contains("Damage");
					if (flag7)
					{
						this.DataUpdate();
					}
				}
			}
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002B44 File Offset: 0x00000D44
	[DebuggerStepThrough]
	public override void DrawEffect()
	{
		AttackCardItem.<DrawEffect>d__12 <DrawEffect>d__ = new AttackCardItem.<DrawEffect>d__12();
		<DrawEffect>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		<DrawEffect>d__.<>4__this = this;
		<DrawEffect>d__.<>1__state = -1;
		<DrawEffect>d__.<>t__builder.Start<AttackCardItem.<DrawEffect>d__12>(ref <DrawEffect>d__);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002B7D File Offset: 0x00000D7D
	private IEnumerator OnMouseDownRight()
	{
		this.currentSystem = EventSystem.current;
		this.currentSystem.enabled = false;
		for (;;)
		{
			bool flag = KeyManager.playerAction.Main.RightClick.WasPressedThisFrame() || this.hasUse;
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
		this.hitEnemy = null;
		bool flag5 = this.data["InitScript"].Contains("Damage");
		if (flag5)
		{
			base.scriptExecutor.Target = null;
			this.DataUpdate();
		}
		this.isLine = false;
		Cursor.visible = true;
		yield break;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002B8C File Offset: 0x00000D8C
	private void TrueUse()
	{
		bool hasUse = this.hasUse;
		if (!hasUse)
		{
			ValueTuple<bool, Action> valueTuple = base.TryUse();
			bool success = valueTuple.Item1;
			Action onUse = valueTuple.Item2;
			bool flag = success;
			if (flag)
			{
				bool flag2 = !GameSaveManager.GetValue<bool>(GameVar.LateThrow);
				if (flag2)
				{
					if (onUse != null)
					{
						onUse();
					}
				}
				bool flag3 = base.scriptExecutor.Target.IsNull() && EnemyManager.Instance != null && EnemyManager.Instance.enemyList.Count > 0;
				if (flag3)
				{
					base.scriptExecutor.Target = EnemyManager.Instance.enemyList[0].Status;
				}
				this.hasUse = true;
				bool flag4 = base.Tags.Contains("Recycle");
				if (flag4)
				{
					this.hasUse = false;
				}
				else
				{
					base.transform.GetComponent<ObjectGroup>().blocksRaycasts = false;
				}
				bool flag5 = this.hitEnemy != null;
				if (flag5)
				{
					base.scriptExecutor.Target = this.hitEnemy;
				}
				else
				{
					bool flag6 = EnemyManager.Instance != null && EnemyManager.Instance.enemyList.Count > 0;
					if (flag6)
					{
						base.scriptExecutor.Target = EnemyManager.Instance.enemyList[0].Status;
					}
				}
				CardItem.UseCount = (int)this.status.dynamicVariables.GetValueOrDefault("UseCount", 1f) + CommonCardItem.ExUseCount;
				CommonCardItem.ExUseCount = 0;
				this.status.dynamicVariables["UseCount"] = 1f;
				for (int i = 0; i < CardItem.UseCount; i++)
				{
					base.RunScript("UseScript");
				}
				UIManager.Instance.GetUI<FightUI>("FightUI").CallActionAnimation(base.scriptExecutor);
				FightUI.LastCard = this.dataConfig;
			}
			else
			{
				CommonCardItem.ExUseCount = 0;
				this.hasUse = false;
			}
			bool value = GameSaveManager.GetValue<bool>(GameVar.LateThrow);
			if (value)
			{
				if (onUse != null)
				{
					onUse();
				}
			}
			bool flag7 = base.Tags.Contains("Recycle");
			if (flag7)
			{
				this.hasUse = false;
			}
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002DC8 File Offset: 0x00000FC8
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
			StatusManager nowEnemy = null;
			bool flag2 = (this.Vars.ContainsKey("Obj") && this.Vars["Obj"] == "Friends") || hit.transform.GetComponent<Enemy>() != null;
			if (flag2)
			{
				nowEnemy = hit.transform.GetComponent<StatusManager>();
			}
			bool flag3 = nowEnemy != null && nowEnemy.CurHp > 0 && nowEnemy.enabled && nowEnemy != this.hitEnemy;
			if (flag3)
			{
				bool flag4 = this.hitEnemy != null;
				if (flag4)
				{
					this.hitEnemy.OnUnSelect();
				}
				this.hitEnemy = nowEnemy;
				base.scriptExecutor.Target = this.hitEnemy;
				base.scriptExecutor.Object.Clear();
				base.scriptExecutor.Object.Add(base.scriptExecutor.Target);
				bool flag5 = this.data["InitScript"].Contains("Damage");
				if (flag5)
				{
					this.DataUpdate();
				}
			}
			else
			{
				bool flag6 = nowEnemy == null;
				if (flag6)
				{
					bool flag7 = this.hitEnemy != null;
					if (flag7)
					{
						this.hitEnemy.OnUnSelect();
						this.hitEnemy = null;
						base.scriptExecutor.Target = null;
						bool flag8 = this.data["InitScript"].Contains("Damage");
						if (flag8)
						{
							this.DataUpdate();
						}
					}
				}
			}
			bool flag9 = this.hitEnemy != null && this.hitEnemy.CurHp > 0 && this.hitEnemy.enabled;
			if (flag9)
			{
				this.hitEnemy.OnSelect();
			}
			else
			{
				bool flag10 = this.hitEnemy != null;
				if (flag10)
				{
					this.hitEnemy.OnUnSelect();
					this.hitEnemy = null;
					base.scriptExecutor.Target = null;
					bool flag11 = this.data["InitScript"].Contains("Damage");
					if (flag11)
					{
						this.DataUpdate();
					}
				}
			}
			bool flag12 = (KeyManager.playerAction.Main.Click.WasPressedThisFrame() || KeyManager.playerAction.Main.Click.WasReleasedThisFrame()) && this.hitEnemy != null && this.hitEnemy.CurHp != 0 && this.hitEnemy.enabled;
			if (flag12)
			{
				this.currentSystem.enabled = true;
				base.StopAllCoroutines();
				Cursor.visible = true;
				this.isLine = false;
				UIManager.Instance.HideUI("LineUI");
				this.TrueUse();
				this.hitEnemy.OnUnSelect();
				this.hitEnemy = null;
				base.scriptExecutor.Target = null;
			}
		}
		else
		{
			bool flag13 = KeyManager.playerAction.Main.Click.WasReleasedThisFrame();
			if (flag13)
			{
				bool flag14 = Time.time - this.lasttime < 0.25f;
				if (flag14)
				{
					bool flag15 = EnemyManager.Instance == null || EnemyManager.Instance.enemyList.Count == 0 || EnemyManager.enemyCount == 0;
					if (flag15)
					{
						return;
					}
					base.scriptExecutor.Target = EnemyManager.Instance.enemyList[0].Status;
					this.TrueUse();
					this.currentSystem.enabled = true;
					base.StopAllCoroutines();
					Cursor.visible = true;
					this.isLine = false;
					UIManager.Instance.HideUI("LineUI");
					bool flag16 = this.hitEnemy != null;
					if (flag16)
					{
						this.hitEnemy.OnUnSelect();
						this.hitEnemy = null;
					}
					return;
				}
				else
				{
					bool flag17 = Touchscreen.current != null;
					if (flag17)
					{
						this.currentSystem.enabled = true;
						base.StopAllCoroutines();
						Cursor.visible = true;
						this.isLine = false;
						UIManager.Instance.HideUI("LineUI");
						return;
					}
					this.lasttime = Time.time;
				}
			}
			bool flag18 = this.hitEnemy != null;
			if (flag18)
			{
				this.hitEnemy.OnUnSelect();
			}
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00003288 File Offset: 0x00001488
	private void OnDestroy()
	{
		base.ClearEvent();
		base.StopAllCoroutines();
		bool isLine = this.isLine;
		if (isLine)
		{
			this.isLine = false;
			Cursor.visible = true;
			this.currentSystem.enabled = true;
		}
	}

	// Token: 0x04000018 RID: 24
	private StatusManager hitEnemy;

	// Token: 0x04000019 RID: 25
	private EventSystem currentSystem;
}

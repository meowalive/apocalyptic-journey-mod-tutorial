using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Text;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Fight.ActionCommand;
using TMPro;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using Witch.UI;
using Witch.UI.Component;
using Witch.UI.Window;

/// <summary>
/// BuffItem作为存放数值的容器，挂载到BuffItem预制体上，实现自动更新数值的显示
/// </summary>
// Token: 0x020000F9 RID: 249
public class BuffItem : MonoBehaviour, IBuffItem
{
	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000826 RID: 2086 RVA: 0x00040BE2 File Offset: 0x0003EDE2
	// (set) Token: 0x06000827 RID: 2087 RVA: 0x00040BEA File Offset: 0x0003EDEA
	public IBuffItemConfig buffConfig { get; set; }

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000828 RID: 2088 RVA: 0x00040BF3 File Offset: 0x0003EDF3
	// (set) Token: 0x06000829 RID: 2089 RVA: 0x00040BFB File Offset: 0x0003EDFB
	public IStatusManager status { get; set; }

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x0600082A RID: 2090 RVA: 0x00040C04 File Offset: 0x0003EE04
	// (set) Token: 0x0600082B RID: 2091 RVA: 0x00040C0C File Offset: 0x0003EE0C
	[TupleElementNames(new string[]
	{
		"dataConfig",
		"action"
	})]
	public ObservableCollection<ValueTuple<IDataConfig, Action>> effectList { [return: TupleElementNames(new string[]
	{
		"dataConfig",
		"action"
	})] get; [param: TupleElementNames(new string[]
	{
		"dataConfig",
		"action"
	})] set; } = new ObservableCollection<ValueTuple<IDataConfig, Action>>();

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x0600082C RID: 2092 RVA: 0x00040C15 File Offset: 0x0003EE15
	public IScriptExecutor scriptExecutor
	{
		get
		{
			return this.buffConfig.dataConfig.scriptExecutor;
		}
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x00040C28 File Offset: 0x0003EE28
	public void Init(BuffItemConfig config, StatusManager Status, BuffBarUI buffBarUI)
	{
		this.keywordDisplay = base.gameObject.AddComponent<KeywordDisplay>();
		Profiler.BeginSample("BuffItem.Init");
		this.iconRenderer = base.transform.Find("Content/Image").GetComponent<SpriteRenderer>();
		ResourceLoader.LoadAsync<Sprite>(config.Icon, base.destroyCancellationToken).ContinueWith(delegate(Sprite sprite)
		{
			bool flag4 = this.iconRenderer == null;
			if (!flag4)
			{
				this.iconRenderer.sprite = sprite;
			}
		}).Forget();
		this.glowPropertyBlock = new MaterialPropertyBlock();
		this.iconRenderer.material = ResourceLoader.Load<Material>("Material/BuffIcon", true);
		this.status = Status;
		buffBarUI.BuffDic.Add(config.BuffId, this);
		this.buffConfig = config;
		this.buffConfig.buffItem = this;
		this.buffBarUI = buffBarUI;
		this.scriptExecutor.Self = this.status;
		this.scriptExecutor.Object.Clear();
		this.scriptExecutor.Object.Add(this.status);
		this.scriptExecutor.SetStatus("Self");
		base.transform.Find("Content/Level").GetComponent<TMP_Text>().SetDigitText(this.buffConfig.Level.ToString());
		this.buffConfig.dataConfig.Vars["stack"] = this.buffConfig.Level.ToString();
		this.UpdateMsg();
		this.ApplyBuff();
		this.BuffProcess(true);
		this.effectList.CollectionChanged += delegate(object sender, NotifyCollectionChangedEventArgs args)
		{
			bool flag4 = args.Action == NotifyCollectionChangedAction.Remove;
			if (flag4)
			{
				foreach (object item in args.OldItems)
				{
					ValueTuple<IDataConfig, Action> effect2 = (ValueTuple<IDataConfig, Action>)item;
					this.status.effectList.Remove(effect2.Item1);
				}
			}
			else
			{
				bool flag5 = args.Action == NotifyCollectionChangedAction.Add;
				if (flag5)
				{
					foreach (object item2 in args.NewItems)
					{
						ValueTuple<IDataConfig, Action> effect = (ValueTuple<IDataConfig, Action>)item2;
						this.status.effectList.Add(effect.Item1);
						Action action = effect.Item2;
						action = (Action)Delegate.Combine(action, new Action(delegate()
						{
							bool flag7 = effect.Item1.data.ContainsKey("Effect") && effect.Item1.data["Effect"] != "";
							if (flag7)
							{
								Singleton<EffectManager>.Instance.PlayEffect(effect.Item1.scriptExecutor, effect.Item1.data["Effect"]);
							}
						}));
						ValueTuple<IDataConfig, Action> newEffect = new ValueTuple<IDataConfig, Action>(effect.Item1, action);
						int index = this.effectList.IndexOf(effect);
						bool flag6 = index >= 0;
						if (flag6)
						{
							this.effectList[index] = newEffect;
						}
					}
				}
			}
			this.status.UpdateEffectList();
		};
		bool flag = config.dataConfig.data["Effects"] != "";
		if (flag)
		{
			Singleton<EffectManager>.Instance.PlayEffect(config.dataConfig.scriptExecutor, config.dataConfig.data["Effects"]);
		}
		base.transform.Find("Content").localScale = Vector3.zero;
		base.transform.Find("Content").DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);
		bool flag2 = config.Type == "正面" || config.Type == "能力";
		if (flag2)
		{
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayEffect("NewSounds/战斗中/获得增益");
			}
		}
		else
		{
			AudioManager instance2 = AudioManager.Instance;
			if (instance2 != null)
			{
				instance2.PlayEffect("NewSounds/战斗中/获得负面");
			}
		}
		bool flag3 = !string.IsNullOrEmpty(config.dataConfig.data["SoundEffects"]);
		if (flag3)
		{
			AudioManager instance3 = AudioManager.Instance;
			if (instance3 != null)
			{
				instance3.PlayEffect(config.dataConfig.data["SoundEffects"]);
			}
		}
		this.keywordDisplay.OnShow += this.UpdateTooltip;
		Profiler.EndSample();
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00040F18 File Offset: 0x0003F118
	public void BuffProcess(bool isacting)
	{
		bool isDisplay = this.buffBarUI.isDisplay;
		if (!isDisplay)
		{
			if (isacting)
			{
				this.scriptExecutor.AddEvent(this.buffConfig.BuffId + "OnLevelChange", delegate
				{
					this.ClearDynamicVar(this.buffConfig.dataConfig.data["Id"]);
				});
				this.scriptExecutor.RunScript("ApplyScript");
				Singleton<EventCenter>.Instance.AddEventListener(this.buffConfig.BuffId + "_OnTriggerEffect" + this.status.InstanceId, new Action(this.EffectAnimation), this.scriptExecutor, EventDispose.None);
			}
			else
			{
				this.scriptExecutor.Clear();
			}
		}
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00040FD4 File Offset: 0x0003F1D4
	public void EffectAnimation()
	{
		bool flag = this.iconRenderer == null || this.iconRenderer.material == null;
		if (!flag)
		{
			DOTween.Kill(this.glowPropertyBlock, false);
			this.glowPropertyBlock.SetFloat(BuffItem.GlowIntensity, 0.5f);
			this.iconRenderer.SetPropertyBlock(this.glowPropertyBlock);
			DOTween.To(() => this.glowPropertyBlock.GetFloat(BuffItem.GlowIntensity), delegate(float x)
			{
				this.glowPropertyBlock.SetFloat(BuffItem.GlowIntensity, x);
			}, 0.5f, 0.3f).OnUpdate(delegate
			{
				this.iconRenderer.SetPropertyBlock(this.glowPropertyBlock);
			});
		}
	}

	/// <summary>
	/// 更新buff信息展示
	/// </summary>
	// Token: 0x06000830 RID: 2096 RVA: 0x00041078 File Offset: 0x0003F278
	public void UpdateMsg()
	{
		Profiler.BeginSample("BuffItem.UpdateMsg");
		this.buffBarUI.isDirty = true;
		bool flag = this.IsNull("Object") || base.transform == null || this.buffConfig == null;
		if (flag)
		{
			Profiler.EndSample();
		}
		else
		{
			Transform transform = base.transform.Find("Content/Level");
			TMP_Text levelText = (transform != null) ? transform.GetComponent<TMP_Text>() : null;
			bool flag2 = levelText == null;
			if (flag2)
			{
				Debug.LogError("Content/Level 节点未挂载 TMP_Text 组件！");
				Profiler.EndSample();
			}
			else
			{
				levelText.SetDigitText(this.buffConfig.Level.ToString());
				this.isDirty = true;
				Profiler.EndSample();
			}
		}
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00041134 File Offset: 0x0003F334
	public void UpdateSorting(int index)
	{
		base.transform.GetComponent<SortingGroup>().sortingOrder = -index;
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x0004114C File Offset: 0x0003F34C
	public void UpdateTooltip()
	{
		bool flag = !this.isDirty;
		if (!flag)
		{
			this.isDirty = false;
			BuffItem.tipBuilder.Clear();
			BuffItem.finalText.Clear();
			this.buffConfig.dataConfig.Vars["stack"] = this.buffConfig.Level.ToString();
			this.buffConfig.dataConfig.scriptExecutor.RunScript("InitScript");
			BuffItem.tipBuilder.Append('—', 21);
			bool flag2 = this.buffConfig.UpperBound > 0;
			if (flag2)
			{
				BuffItem.tipBuilder.Append("\n<color=yellow>>>  ").Append("上限").Append(this.buffConfig.UpperBound).Append("layer".Localize("FightUI")).Append("</color>");
			}
			bool flag3 = this.buffConfig.ReducePerAttacked > 0;
			if (flag3)
			{
				BuffItem.tipBuilder.Append("\n>>  ").Append("ReducePerDamage".Localize("FightUI")).Append(this.buffConfig.ReducePerAttacked).Append("layer".Localize("FightUI"));
			}
			bool flag4 = this.buffConfig.ReducePerTurn > 0;
			if (flag4)
			{
				BuffItem.tipBuilder.Append("\n>>  ").Append("ReducePerTurn".Localize("FightUI")).Append(this.buffConfig.ReducePerTurn).Append("layer".Localize("FightUI"));
			}
			bool flag5 = this.buffConfig.ReducePerUse > 0;
			if (flag5)
			{
				BuffItem.tipBuilder.Append("\n>>  ").Append("ReducePerAction".Localize("FightUI")).Append(this.buffConfig.ReducePerUse).Append("layer".Localize("FightUI"));
			}
			BuffItem.finalText.Append(this.buffConfig.Level).Append("layer".Localize("FightUI")).Append("\n").Append(this.buffConfig.Description).Append("</size>\n").Append("<size=16><color=grey>").Append(BuffItem.tipBuilder).Append("</color></size>\n");
			this.keywordDisplay.SetText(this.buffConfig.BuffName, BuffItem.finalText.ToString(), null, null, this.iconRenderer.sprite, "Buff");
		}
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x000413F8 File Offset: 0x0003F5F8
	public void ApplyBuff()
	{
		bool flag = this.status == null || this.status.IsNull() || this.buffBarUI == null;
		if (!flag)
		{
			System.Random random = new System.Random();
			UIManager.Instance.ShowPopUpText("BuffMsgText", "+ " + this.buffConfig.BuffName, new Vector2((this.status as StatusManager).selfUI.transform.localPosition.x + (float)random.Next(-5, 5), (this.status as StatusManager).selfUI.transform.localPosition.y + (float)random.Next(-5, 5))).Forget<PopUpTextUI>();
		}
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x000414BC File Offset: 0x0003F6BC
	public void DurationCheck(string way)
	{
		bool flag = !this.HasClear;
		if (flag)
		{
			bool flag2 = this.buffConfig.DurationCheck(way);
			if (flag2)
			{
				this.ClearBuff();
			}
		}
	}

	/// <summary>
	/// Buff清除阶段，并造成一定影响
	/// </summary>
	// Token: 0x06000835 RID: 2101 RVA: 0x000414F4 File Offset: 0x0003F6F4
	public void ClearBuff()
	{
		bool hasClear = this.HasClear;
		if (!hasClear)
		{
			bool flag = this.buffConfig.Type == "负面";
			if (flag)
			{
				Singleton<EffectManager>.Instance.PlayEffect(this.status, "净化");
			}
			bool isDisplay = this.buffBarUI.isDisplay;
			if (isDisplay)
			{
				this.buffBarUI.BuffDic.Remove(this.buffConfig.BuffId);
				UnityEngine.Object.Destroy(base.gameObject);
			}
			else
			{
				this.keywordDisplay.OnShow -= this.UpdateTooltip;
				UnityEngine.Object.Destroy(base.gameObject);
				this.HasClear = true;
				this.BuffProcess(false);
				bool flag2 = this.buffConfig.dataConfig.data["ClearScript"] != "";
				if (flag2)
				{
					this.scriptExecutor.RunScript("ClearScript");
				}
				this.buffBarUI.BuffDic.Remove(this.buffConfig.BuffId);
				FightManager.Instance.EnqueueEvent(new RemoveBuff().Create(this.buffConfig as BuffItemConfig));
				UIManager.Instance.ShowPopUpText("BuffNegativeMsgText", "<color=red>- " + this.buffConfig.BuffName + "</color>", (this.status as StatusManager).statusBarObj.transform.localPosition).Forget<PopUpTextUI>();
				this.ClearDynamicVar(this.buffConfig.dataConfig.data["Id"]);
				bool flag3 = this.buffConfig.BuffId == "buff_timelock";
				if (flag3)
				{
					Singleton<EffectManager>.Instance.PlayEffect(this.scriptExecutor, "slashBullet");
				}
				bool flag4 = this.effectList.Count > 0;
				if (flag4)
				{
					foreach (ValueTuple<IDataConfig, Action> item in this.effectList)
					{
						ValueTuple<IDataConfig, Action> effect = item;
						this.status.effectList.Remove(effect.Item1);
					}
					this.effectList.Clear();
					this.status.UpdateEffectList();
				}
			}
		}
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00041758 File Offset: 0x0003F958
	public void ClearDynamicVar(string fromId)
	{
		bool flag = this.status.dynamicVariablesLog.ContainsKey(fromId);
		if (flag)
		{
			foreach (KeyValuePair<string, float> item in this.status.dynamicVariablesLog[fromId])
			{
				Dictionary<string, float> dynamicVariables = this.status.dynamicVariables;
				string key = item.Key;
				dynamicVariables[key] -= item.Value;
			}
			this.status.dynamicVariablesLog[fromId].Clear();
		}
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00041814 File Offset: 0x0003FA14
	private void OnDestroy()
	{
		this.scriptExecutor.Clear();
		this.status.UpdateDisplay();
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x000324C8 File Offset: 0x000306C8
	Transform IBuffItem.get_transform()
	{
		return base.transform;
	}

	// Token: 0x04000B93 RID: 2963
	private static readonly int GlowIntensity = Shader.PropertyToID("_GlowIntensity");

	// Token: 0x04000B94 RID: 2964
	private MaterialPropertyBlock glowPropertyBlock;

	// Token: 0x04000B95 RID: 2965
	private static StringBuilder tipBuilder = new StringBuilder(256);

	// Token: 0x04000B96 RID: 2966
	private static StringBuilder finalText = new StringBuilder(512);

	// Token: 0x04000B99 RID: 2969
	public BuffBarUI buffBarUI;

	// Token: 0x04000B9B RID: 2971
	public KeywordDisplay keywordDisplay;

	// Token: 0x04000B9C RID: 2972
	private SpriteRenderer iconRenderer;

	// Token: 0x04000B9D RID: 2973
	private bool isDirty = true;

	// Token: 0x04000B9E RID: 2974
	public bool HasClear;
}

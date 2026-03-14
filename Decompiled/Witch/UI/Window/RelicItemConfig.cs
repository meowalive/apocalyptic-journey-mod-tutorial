using System;
using Cysharp.Text;
using Data.Save;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000321 RID: 801
	public class RelicItemConfig : Item
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x000D20B9 File Offset: 0x000D02B9
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x000D20C4 File Offset: 0x000D02C4
		private new bool ifEquipped
		{
			get
			{
				return this.ifEquipped;
			}
			set
			{
				bool flag = this.ifEquipped == value;
				if (!flag)
				{
					this.ifEquipped = value;
					bool flag2 = GameObject.Find("Breaks") != null;
					if (!flag2)
					{
						bool ifEquipped = this.ifEquipped;
						if (ifEquipped)
						{
							bool flag3 = RoleTable.Instance.WithoutArmedRelicList.IndexOf(this.dataConfig) == -1;
							if (!flag3)
							{
								RoleTable.Instance.relicList.Add(this.dataConfig);
								RoleTable.Instance.WithoutArmedRelicList.Remove(this.dataConfig);
							}
						}
						else
						{
							bool flag4 = RoleTable.Instance.relicList.IndexOf(this.dataConfig) == -1;
							if (!flag4)
							{
								RoleTable.Instance.WithoutArmedRelicList.Add(this.dataConfig);
								RoleTable.Instance.relicList.Remove(this.dataConfig);
							}
						}
					}
				}
			}
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x000D21AC File Offset: 0x000D03AC
		public override void ShowFloatingWindow()
		{
			this.floatingWindow.Clear();
			bool flag = GameObject.Find("Breaks") != null;
			if (!flag)
			{
				this.floatingWindow.AddButton("sell".Localize("Button") + ZString.Format<object>("({0})", (int)((float)(70 * int.Parse(this.Rarity)) * RoleTable.Instance.MoneyCal)), delegate()
				{
					GameSaveAnalyser.Instance.TryPush(this.dataConfig.data["Name"], OperObj.Relics, OperType.Delete);
					RoleTable.Instance.Money += 70 * int.Parse(this.Rarity);
					RoleTable.Instance.relicList.Remove(this.dataConfig);
					RoleTable.Instance.WithoutArmedRelicList.Remove(this.dataConfig);
					this.floatingWindow.Hide();
				}, null);
				bool ifEquipped = this.ifEquipped;
				if (ifEquipped)
				{
					this.floatingWindow.AddButton("Take off".Localize("Button"), delegate()
					{
						bool flag2 = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
						if (flag2)
						{
							UIManager.Instance.ShowModalWindow("Tips", "This action cannot be performed during battle", delegate
							{
							}, 0f, null, true, true, "Yes", "No", true);
						}
						else
						{
							bool ifEquipped2 = this.ifEquipped;
							if (ifEquipped2)
							{
								RoleTable.Instance.IsMoveOn = true;
								this.ifEquipped = false;
								RoleTable.Instance.IsMoveOn = false;
							}
							this.floatingWindow.Hide();
						}
					}, null);
				}
				base.ShowFloatingWindow();
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00010E28 File Offset: 0x0000F028
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000D2274 File Offset: 0x000D0474
		public override void Init(DataConfig dataConfig)
		{
			this.glowMaterial = UnityEngine.Object.Instantiate<Material>(ResourceLoader.Load<Material>("Material/BuffIcon", true));
			base.Init(dataConfig);
			base.transform.GetComponent<ButtonManager>().buttonIcon = this.itemIcon;
			base.transform.GetComponent<ButtonManager>().UpdateUI();
			this.AddToParent();
			this.ItemType = "Relic";
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00010E28 File Offset: 0x0000F028
		public override void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00010E28 File Offset: 0x0000F028
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x000D22DC File Offset: 0x000D04DC
		public override void OnTransformParentChanged()
		{
			bool flag = !base.gameObject.activeSelf;
			if (!flag)
			{
				this.RemoveFromParent();
				this.AddToParent();
				this.ifEquipped = !this.ifEquipped;
			}
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x000D2320 File Offset: 0x000D0520
		public void SetGlowEvent(bool enable)
		{
			if (enable)
			{
				base.transform.Find("Normal/Icon Parent/Icon").GetComponent<Image>().material = this.glowMaterial;
				base.transform.Find("Highlighted/Icon Parent/Icon").GetComponent<Image>().material = this.glowMaterial;
				Singleton<EventCenter>.Instance.AddEventListener(this.dataConfig.data["Id"] + "_OnTriggerEffect" + PlayerManager.Instance.PlayerId, delegate()
				{
					this.EffectAnimation();
				}, this, EventDispose.OnFightEnd);
			}
			else
			{
				base.transform.Find("Normal/Icon Panel/Icon").GetComponent<Image>().material = null;
				base.transform.Find("Highlighted/Icon Panel/Icon").GetComponent<Image>().material = null;
				Singleton<EventCenter>.Instance.Clear(Array.Empty<EventDispose>());
			}
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x000D2408 File Offset: 0x000D0608
		public void EffectAnimation()
		{
			bool flag = this.glowMaterial == null;
			if (!flag)
			{
				this.glowMaterial.DOKill(false);
				this.glowMaterial.SetFloat("_GlowIntensity", 1f);
				this.glowMaterial.DOFloat(3f, "_GlowIntensity", 0.3f).OnComplete(delegate
				{
					this.glowMaterial.DOFloat(0.5f, "_GlowIntensity", 0.3f);
				});
			}
		}

		// Token: 0x0400136D RID: 4973
		public RelicSelectUI relicSelectUI;

		// Token: 0x0400136E RID: 4974
		public Material glowMaterial;
	}
}

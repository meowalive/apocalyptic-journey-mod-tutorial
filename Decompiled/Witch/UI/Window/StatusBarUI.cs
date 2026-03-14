using System;
using Cysharp.Text;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x020002F8 RID: 760
	public class StatusBarUI : MonoBehaviour
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x000C6838 File Offset: 0x000C4A38
		public void Init(StatusManager status)
		{
			this.Status = status;
			this.hpItemObj = UIManager.Instance.CreateHPItem();
			this.buffBarObj = UIManager.Instance.CreateBuffBarItem();
			this.nameObj = base.transform.Find("Name").gameObject;
			this.nameObj.transform.Find("Selected/Name").GetComponent<TMP_Text>().SetLocalizedText(() => status.Name);
			this.nameObj.transform.Find("UnSelected/Name").GetComponent<TMP_Text>().SetLocalizedText(() => status.Name);
			this.backgroundObj = base.transform.Find("Name/Selected/Name/Background").gameObject;
			this.defendImg = this.hpItemObj.transform.Find("bluefill").GetComponent<SpriteRenderer>();
			this.hpTxt = this.hpItemObj.transform.Find("hpTxt").GetComponent<TMP_Text>();
			this.hpImg = this.hpItemObj.transform.Find("fill").GetComponent<SpriteRenderer>();
			this.hpRedImg = this.hpItemObj.transform.Find("redfill").GetComponent<SpriteRenderer>();
			this.toughObj = this.hpItemObj.transform.Find("Tough").gameObject;
			this.hpItemObj.transform.SetParent(base.transform);
			this.buffBarObj.transform.SetParent(base.transform);
			this.buffBarObj.GetComponent<BuffBarUI>().status = this.Status;
			base.transform.localScale = Vector3.one;
		}

		/// <summary>
		/// 更新防御显示
		/// </summary>
		// Token: 0x060017D7 RID: 6103 RVA: 0x000C6A04 File Offset: 0x000C4C04
		public void UpdateHealthBar(int Defend, int CurHp, int MaxHp, bool NeedEffect = true)
		{
			bool flag = Application.isEditor && !Application.isPlaying;
			if (!flag)
			{
				bool flag2 = this.lastDefend != Defend || this.lastHp != CurHp;
				if (flag2)
				{
					if (NeedEffect)
					{
						bool flag3 = this.lastDefend < Defend;
						if (flag3)
						{
							Singleton<EffectManager>.Instance.PlayEffect(this.Status, "护盾");
						}
						bool flag4 = this.lastHp < CurHp;
						if (flag4)
						{
							Singleton<EffectManager>.Instance.PlayEffect(this.Status, "治疗");
						}
					}
					this.lastDefend = Defend;
					this.lastHp = CurHp;
				}
				bool flag5 = this.hpTxt == null || this.hpTxt.gameObject == null;
				if (!flag5)
				{
					string display = CurHp.ToString();
					bool flag6 = this.hpImg == null;
					if (!flag6)
					{
						bool flag7 = this.hpRedImg == null;
						if (!flag7)
						{
							bool flag8 = MaxHp != 0;
							if (flag8)
							{
								this.hpRedImg.material.DOFloat((float)CurHp / (float)MaxHp, "_FillAmount", 0.2f);
								this.hpImg.material.DOFloat((float)CurHp / (float)MaxHp, "_FillAmount", 0.5f).SetDelay(0.2f);
							}
							this.hpTxt.gameObject.SetActive(true);
							bool flag9 = Defend <= 0;
							if (flag9)
							{
								bool flag10 = this.defendImg.material.GetFloat("_FillAmount") != 0f;
								if (flag10)
								{
									this.defendImg.material.DOFloat(0f, "_FillAmount", 0.5f).OnComplete(delegate
									{
										this.defendImg.enabled = false;
									});
								}
							}
							else
							{
								this.defendImg.enabled = true;
								bool flag11 = MaxHp != 0;
								if (flag11)
								{
									this.defendImg.material.DOFloat((float)Defend / (float)MaxHp, "_FillAmount", 0.5f);
								}
								display += ZString.Format<object, object>("<color=#{0}>+{1}</color>", ColorUtility.ToHtmlStringRGB(Color.cyan), Defend);
							}
							this.hpTxt.SetText(display);
							this.hpTxt.ForceMeshUpdate(false, false);
						}
					}
				}
			}
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x000C6C58 File Offset: 0x000C4E58
		private void Update()
		{
			bool flag = StatusBarUI._currentFocusVocalTarget != this || this._focusVocalSelectTime < 0f;
			if (!flag)
			{
				bool flag2 = Time.time - this._focusVocalSelectTime < 10f;
				if (!flag2)
				{
					bool flag3 = this.Status != null && this.Status.fatherObject is FightPlayer;
					if (flag3)
					{
						this.Status.PlayVocal(IStatusManager.VocalState.Focus);
					}
					this._focusVocalSelectTime = Time.time;
				}
			}
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x000C6CE4 File Offset: 0x000C4EE4
		public void UpdateTough()
		{
			bool flag = this.toughObj == null;
			if (!flag)
			{
				bool flag2 = !(this.Status.fatherObject is Enemy);
				if (flag2)
				{
					this.toughObj.SetActive(false);
				}
				else
				{
					this.toughObj.SetActive(true);
					this.toughObj.transform.Find("val").GetComponent<TMP_Text>().text = this.Status.ToughCount.ToString();
					bool flag3 = this.Status.ToughCount <= 0;
					if (flag3)
					{
						this.toughObj.transform.Find("val").gameObject.SetActive(false);
						this.toughObj.transform.Find("fill").gameObject.SetActive(true);
					}
					else
					{
						this.toughObj.transform.Find("val").gameObject.SetActive(true);
						this.toughObj.transform.Find("fill").gameObject.SetActive(false);
					}
				}
			}
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x000C6E18 File Offset: 0x000C5018
		public void OnSelected()
		{
			bool flag = Application.isEditor && !Application.isPlaying;
			if (!flag)
			{
				bool flag2 = this.nameObj == null;
				if (!flag2)
				{
					bool flag3 = StatusBarUI._currentFocusVocalTarget != null && StatusBarUI._currentFocusVocalTarget != this;
					if (flag3)
					{
						StatusBarUI._currentFocusVocalTarget.ClearFocusVocalState();
					}
					StatusBarUI._currentFocusVocalTarget = this;
					this._focusVocalSelectTime = Time.time;
					bool flag4 = this.nameObj.transform.Find("Selected") != null;
					if (flag4)
					{
						this.nameObj.transform.Find("Selected").GetComponent<ObjectGroup>().SetAlpha(1f);
					}
					bool flag5 = this.nameObj.transform.Find("UnSelected") != null;
					if (flag5)
					{
						this.nameObj.transform.Find("UnSelected").GetComponent<ObjectGroup>().SetAlpha(0f);
					}
					bool flag6 = this.nameObj.transform.Find("Selected/Name") == null;
					if (!flag6)
					{
						this.backgroundObj.transform.localScale = new Vector3(this.backgroundObj.transform.parent.GetComponent<RectTransform>().sizeDelta.x + 50f, this.backgroundObj.transform.localScale.y, this.backgroundObj.transform.localScale.z);
					}
				}
			}
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x000C6FA7 File Offset: 0x000C51A7
		private void ClearFocusVocalState()
		{
			this._focusVocalSelectTime = -1f;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x000C6FB8 File Offset: 0x000C51B8
		public void OnUnSelected()
		{
			bool flag = Application.isEditor && !Application.isPlaying;
			if (!flag)
			{
				bool flag2 = this.nameObj == null;
				if (!flag2)
				{
					this.ClearFocusVocalState();
					bool flag3 = StatusBarUI._currentFocusVocalTarget == this;
					if (flag3)
					{
						StatusBarUI._currentFocusVocalTarget = null;
					}
					bool flag4 = this.nameObj.transform.Find("Selected") != null && this.nameObj.transform.Find("Selected").GetComponent<ObjectGroup>() != null;
					if (flag4)
					{
						this.nameObj.transform.Find("Selected").GetComponent<ObjectGroup>().SetAlpha(0f);
					}
					bool flag5 = this.nameObj.transform.Find("UnSelected") != null && this.nameObj.transform.Find("UnSelected").GetComponent<ObjectGroup>() != null;
					if (flag5)
					{
						this.nameObj.transform.Find("UnSelected").GetComponent<ObjectGroup>().SetAlpha(1f);
					}
				}
			}
		}

		// Token: 0x040012A2 RID: 4770
		public StatusManager Status;

		// Token: 0x040012A3 RID: 4771
		private static StatusBarUI _currentFocusVocalTarget;

		// Token: 0x040012A4 RID: 4772
		private const float FocusVocalDelaySeconds = 10f;

		// Token: 0x040012A5 RID: 4773
		private float _focusVocalSelectTime = -1f;

		// Token: 0x040012A6 RID: 4774
		public GameObject hpItemObj;

		// Token: 0x040012A7 RID: 4775
		public GameObject buffBarObj;

		// Token: 0x040012A8 RID: 4776
		public TMP_Text hpTxt;

		// Token: 0x040012A9 RID: 4777
		public SpriteRenderer hpRedImg;

		// Token: 0x040012AA RID: 4778
		public SpriteRenderer hpImg;

		// Token: 0x040012AB RID: 4779
		public SpriteRenderer defendImg;

		// Token: 0x040012AC RID: 4780
		public GameObject nameObj;

		// Token: 0x040012AD RID: 4781
		public GameObject toughObj;

		// Token: 0x040012AE RID: 4782
		public GameObject backgroundObj;

		// Token: 0x040012AF RID: 4783
		private int lastDefend = 0;

		// Token: 0x040012B0 RID: 4784
		private int lastHp = 0;
	}
}

using System;
using System.Collections.Generic;
using Data.Save;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

namespace Witch.UI.Window
{
	// Token: 0x02000311 RID: 785
	public class CardChoiceItem : MonoBehaviour
	{
		// Token: 0x06001882 RID: 6274 RVA: 0x000CECE0 File Offset: 0x000CCEE0
		private void Awake()
		{
			this.background = base.transform.Find("Front/background");
			this.light = base.transform.Find("Front/Light");
			this.icon = base.transform.Find("Front/icon");
			this.msgFrame = base.transform.Find("Front/msgFrame");
			this.Icons = base.transform.Find("Front/Icons");
			this.Texts = base.transform.Find("Front/字体");
			this.objectGroup.alpha = 1f;
			base.transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().DOFade(0f, 0f);
			base.transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().DOFade(0f, 0f);
			this.icon.GetComponent<MeshRenderer>().material = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Material/CardChoiceItem"));
			this.backgroundMat = this.icon.GetComponent<MeshRenderer>().material;
			this.backgroundMat.SetFloat("_Dissolve", 1f);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000CEE1C File Offset: 0x000CD01C
		public void Initialize(CardChoiceUI UI, string fromId)
		{
			this.cardChoiceUI = UI;
			this.dataConfig = new DataConfig(fromId, DataType.Card);
			bool isNative = this.dataConfig.IsNative;
			if (isNative)
			{
				GameSaveAnalyser.Instance.TryPush(this.dataConfig.data["Name"], OperObj.Cards, OperType.RewardShow);
			}
			ICard.SetCardStyle(base.transform, this.dataConfig);
			ICard.SetCardMsg(base.transform, this.dataConfig, null);
			this.DataUpdate();
			base.gameObject.GetComponent<Button>().onClick.AddListener(delegate
			{
				bool flag = !this.canClick;
				if (!flag)
				{
					bool flag2 = RoleTable.Instance.UnCardList.Count < RoleTable.Instance.MaxAlCardCount;
					if (flag2)
					{
						bool isNative2 = this.dataConfig.IsNative;
						if (isNative2)
						{
							GameSaveAnalyser.Instance.TryPush(this.dataConfig.data["Name"], OperObj.Cards, OperType.Select);
						}
						this.cardChoiceUI.Select(base.gameObject, this.dataConfig);
					}
					else
					{
						UIManager.Instance.ShowModalWindow("Tips", "你的卡牌数量已达上限", delegate
						{
							bool flag3 = UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI") != null;
							if (flag3)
							{
								UIManager.Instance.GetUI<OutDeckUI>("OutDeckUI").SetRole(new OutDeckUIData(RoleTable.Instance));
							}
							UIManager.Instance.ShowUI<OutDeckUI>("OutDeckUI", true);
						}, 0f, null, true, true, "Yes", "No", true);
						base.gameObject.GetComponent<Button>().interactable = true;
					}
				}
			});
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x000CEEC0 File Offset: 0x000CD0C0
		public void FadeIn(float delay = 0f)
		{
			this.objectGroup.blocksRaycasts = false;
			base.gameObject.SetActive(true);
			base.transform.DOScale(Vector3.one * 0.8f, 0.1f).SetDelay(delay);
			base.transform.DORotate(Vector3.zero, 0.5f, RotateMode.Fast).SetDelay(delay + 0.2f).OnComplete(delegate
			{
				AudioManager instance2 = AudioManager.Instance;
				if (instance2 != null)
				{
					instance2.PlayEffect("Cards/smash");
				}
				base.transform.DOScale(Vector3.one * 0.75f, 0.1f);
			});
			AudioManager instance = AudioManager.Instance;
			if (instance != null)
			{
				instance.PlayEffect("Cards/draw");
			}
			this.backgroundMat.DOFloat(0f, "_Dissolve", 1f).SetDelay(delay + 0.5f).OnComplete(delegate
			{
				this.canClick = true;
				this.Texts.GetComponent<ObjectGroup>().DOFade(1f, 0.5f);
				base.transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().DOFade(1f, 0.9f);
				base.transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().DOFade(1f, 0.9f);
				this.light.gameObject.SetActive(true);
				this.light.GetComponent<SpriteRenderer>().DOColor(this.rarityColors[this.dataConfig.data["Rarity"].ToInt() - 1], 0.2f);
				bool flag = this.dataConfig.data["Rarity"] == "3";
				if (flag)
				{
					this.light.Find("粒子").gameObject.SetActive(true);
				}
				this.Icons.gameObject.SetActive(true);
				this.objectGroup.blocksRaycasts = true;
			});
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000CEF90 File Offset: 0x000CD190
		public void DataUpdate()
		{
			bool flag = this == null;
			if (!flag)
			{
				base.transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().text = this.dataConfig.data.Localize("Name");
				this.dataConfig.scriptExecutor.RunScript("InitScript");
				List<string> keyWords = new List<string>();
				base.transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().text = this.dataConfig.Description().Highlight(keyWords);
				bool flag2 = base.transform.GetComponent<KeywordDisplay>() == null;
				if (flag2)
				{
					base.transform.gameObject.AddComponent<KeywordDisplay>();
				}
				base.transform.GetComponent<KeywordDisplay>().keyWords = keyWords;
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000CF060 File Offset: 0x000CD260
		public void FadeOut(float delay = 0f)
		{
			this.canClick = false;
			this.objectGroup.blocksRaycasts = false;
			this.light.GetComponent<SpriteRenderer>().DOFade(0f, 0f);
			this.light.Find("粒子").GetComponent<VisualEffect>().SetFloat("Lifetime", 0f);
			this.Texts.GetComponent<ObjectGroup>().DOKill(false);
			this.Texts.GetComponent<ObjectGroup>().DOFade(0f, 0.5f).SetDelay(delay).OnStart(delegate
			{
				this.Icons.gameObject.SetActive(false);
			});
			this.objectGroup.DOFade(0f, 0.5f).SetDelay(delay).OnComplete(delegate
			{
				base.gameObject.SetActive(false);
			});
			base.transform.Find("Front/字体/nameTxt").GetComponent<TMP_Text>().DOFade(0f, 0.5f);
			base.transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().DOFade(0f, 0.5f);
			base.transform.Find("Front/icon").GetComponent<MeshRenderer>().material.DOFloat(1f, "_Dissolve", 0.5f);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000CF1AC File Offset: 0x000CD3AC
		public void MoveToDeck()
		{
			this.canClick = false;
			base.transform.DOLocalMove(Vector3.zero, 0.5f, false);
			GameObject target = UIManager.Instance.GetUI<TopBarUI>("TopBarUI").transform.Find("Content/Buttons/CardBack").gameObject;
			Vector3 direction = target.transform.position - base.transform.position;
			float angle = Mathf.Atan2(direction.y, direction.x) * 57.29578f;
			base.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, angle)), 0.5f).SetDelay(0.5f);
			base.transform.DOScale(0f, 0.5f).SetDelay(0.5f);
			GameObject trail = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/Trail"), base.transform.parent) as GameObject;
			Transform vfx = trail.transform.Find("geometryBursts");
			foreach (object obj in vfx.transform)
			{
				Transform child = (Transform)obj;
				VisualEffect subVfx = child.GetComponent<VisualEffect>();
				subVfx.SetInt("count", 0);
			}
			TweenCallback <>9__3;
			base.transform.DOMove(target.GetComponent<RectTransform>().position, 1f, false).OnStart(delegate
			{
				foreach (object obj2 in vfx.transform)
				{
					Transform child2 = (Transform)obj2;
					VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
					subVfx2.SetInt("count", 1);
				}
			}).OnUpdate(delegate
			{
				Vector3 pos = PositionUtility.CameraSpaceToZeroPlane(this.transform.GetComponent<RectTransform>(), null);
				foreach (object obj2 in vfx.transform)
				{
					Transform child2 = (Transform)obj2;
					VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
					subVfx2.SetVector3("startPos", pos);
					subVfx2.SetFloat("direction", this.transform.rotation.eulerAngles.z * 0.017453292f);
				}
			}).OnComplete(delegate
			{
				foreach (object obj2 in vfx.transform)
				{
					Transform child2 = (Transform)obj2;
					VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
					subVfx2.SetInt("count", 0);
				}
				UnityEngine.Object.Destroy(trail, 5f);
				bool flag = target != null;
				if (flag)
				{
					target.transform.DOKill(false);
					Tweener t = target.transform.DOPunchScale(Vector3.one * 0.2f, 0.3f, 2, 1f);
					TweenCallback action;
					if ((action = <>9__3) == null)
					{
						action = (<>9__3 = delegate()
						{
							target.transform.localScale = Vector3.one;
						});
					}
					t.OnKill(action);
				}
			}).SetDelay(0.5f);
		}

		// Token: 0x04001334 RID: 4916
		private Transform background;

		// Token: 0x04001335 RID: 4917
		private Transform icon;

		// Token: 0x04001336 RID: 4918
		private Transform msgFrame;

		// Token: 0x04001337 RID: 4919
		private Transform Icons;

		// Token: 0x04001338 RID: 4920
		private Transform Texts;

		// Token: 0x04001339 RID: 4921
		private DataConfig dataConfig;

		// Token: 0x0400133A RID: 4922
		[UnityInject(false)]
		public ObjectGroup objectGroup;

		// Token: 0x0400133B RID: 4923
		private Transform light;

		// Token: 0x0400133C RID: 4924
		private readonly List<Color> rarityColors = new List<Color>
		{
			new Color(0.8f, 0.8f, 0.8f, 0.5f),
			new Color(0.1f, 0.6f, 0.8f, 0.5f),
			new Color(1f, 0.8f, 0f, 0.5f)
		};

		// Token: 0x0400133D RID: 4925
		private bool canClick = false;

		// Token: 0x0400133E RID: 4926
		private Material backgroundMat;

		// Token: 0x0400133F RID: 4927
		private CardChoiceUI cardChoiceUI;
	}
}

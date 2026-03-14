using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x02000283 RID: 643
	public class DisplayCard : CardItem, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06001455 RID: 5205 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x000026D9 File Offset: 0x000008D9
		public override void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0009F383 File Offset: 0x0009D583
		public override void OnPointerEnter(PointerEventData eventData)
		{
			this.OnHover();
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0009F390 File Offset: 0x0009D590
		public override void Init(DataConfig dataConfig)
		{
			bool flag = FightPlayer.Instance != null;
			if (flag)
			{
				this.status = (FightPlayer.Instance.Status as StatusManager);
			}
			else
			{
				this.status = null;
			}
			this.dataConfig = dataConfig;
			this.data = dataConfig.data;
			this.Vars = dataConfig.Vars;
			bool flag2 = FightPlayer.Instance != null;
			if (flag2)
			{
				base.scriptExecutor.Self = FightPlayer.Instance.Status;
				base.scriptExecutor.Object.Clear();
				bool flag3 = dataConfig.data["InitScript"].Contains("Vars[\"BaseScript\"]=\"AttackCardItem\";");
				if (flag3)
				{
					bool flag4 = EnemyManager.Instance != null && EnemyManager.Instance.enemyList.Count > 0;
					if (flag4)
					{
						base.scriptExecutor.Target = EnemyManager.Instance.enemyList[0].Status;
					}
				}
				else
				{
					base.scriptExecutor.Object.Add(FightPlayer.Instance.Status);
				}
			}
			else
			{
				base.scriptExecutor.Self = null;
			}
			Singleton<EventCenter>.Instance.AddEventListener("LanguageChange", new Action(this.DataUpdate), this, EventDispose.None);
			base.scriptExecutor.dataConfig.Vars["Usable"] = "1";
			ICard.SetCardStyle(base.transform, dataConfig);
			this.DataUpdate();
			base.transform.localScale = new Vector3(this.NormalScale, this.NormalScale, 1f);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0009F534 File Offset: 0x0009D734
		public override void DataUpdate()
		{
			bool flag = this == null;
			if (!flag)
			{
				Transform transform = base.transform;
				DataConfig dataConfig = this.dataConfig;
				FightPlayer instance = FightPlayer.Instance;
				ICard.SetCardMsg(transform, dataConfig, ((instance != null) ? instance.Status : null) as StatusManager);
				bool flag2 = base.transform.parent != null;
				if (flag2)
				{
					KeywordDisplay keywordDisplay = base.transform.parent.GetComponent<KeywordDisplay>() ?? base.transform.parent.gameObject.AddComponent<KeywordDisplay>();
					keywordDisplay.SetText(base.GetComponent<KeywordDisplay>().title, base.GetComponent<KeywordDisplay>().text, base.GetComponent<KeywordDisplay>().keyWords, null, ResourceLoader.Load<Sprite>(this.data.GetValueOrDefault("Icon", ""), true), "card".Localize("Glossary"));
				}
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0009F60F File Offset: 0x0009D80F
		public override void OnPointerExit(PointerEventData eventData)
		{
			this.OnExit();
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0009F619 File Offset: 0x0009D819
		public void OnHover()
		{
			base.transform.DOScale(this.CurrentScale, 0.25f);
			base.index = base.transform.GetSiblingIndex();
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0009F648 File Offset: 0x0009D848
		public void OnExit()
		{
			bool flag = this.isSelect;
			if (!flag)
			{
				base.transform.DOScale(this.NormalScale, 0.25f);
				base.transform.SetSiblingIndex(base.index);
			}
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0009F68B File Offset: 0x0009D88B
		public void OnPointerClick(PointerEventData eventData)
		{
			UnityEvent unityEvent = this.onClick;
			if (unityEvent != null)
			{
				unityEvent.Invoke();
			}
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0009F6A0 File Offset: 0x0009D8A0
		public void OnSelect()
		{
			this.isSelect = true;
			this.OnHover();
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0009F6B1 File Offset: 0x0009D8B1
		public void OnUnSelect()
		{
			this.isSelect = false;
			this.OnExit();
		}

		// Token: 0x0400106C RID: 4204
		public float CurrentScale = 1.2f;

		// Token: 0x0400106D RID: 4205
		public float NormalScale = 0.8f;

		// Token: 0x0400106E RID: 4206
		public bool isSelect;

		// Token: 0x0400106F RID: 4207
		public UnityEvent onClick = new UnityEvent();
	}
}

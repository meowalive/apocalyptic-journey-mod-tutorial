using System;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.EventSystems;
using ZLinq;
using ZLinq.Linq;

// Token: 0x0200000F RID: 15
public class CardContainer : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x06000057 RID: 87 RVA: 0x00003EB4 File Offset: 0x000020B4
	private void Awake()
	{
		this.originY = base.transform.localPosition.y;
		this.VarList = (from x in ValueEnumerable.Range(0, 9)
		select (float)(x * x)).ToList<float>();
		for (int i = 1; i < this.VarList.Count; i++)
		{
			this.VarList[i] = this.VarList[i] + 5f;
			bool flag = this.VarList[i] > 75f;
			if (flag)
			{
				this.VarList[i] = 75f;
			}
		}
		for (int j = 0; j < 2; j++)
		{
			this.sinList.Add(Mathf.Clamp(Mathf.Sin((float)(1.5707963705062866 - (double)(j % 2) / 1.1)), -1f, 1f) / 2f);
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00003FC8 File Offset: 0x000021C8
	public void ResetTimer()
	{
		this.AFKTimer = 1f;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00003FD8 File Offset: 0x000021D8
	private void Update()
	{
		bool flag = !this.AFKAnimation;
		if (!flag)
		{
			bool flag2 = !this.OnEnter;
			if (flag2)
			{
				this.AFKTimer -= Time.deltaTime;
			}
			bool flag3 = this.AFKTimer <= 0f && !this.OnEnter;
			if (flag3)
			{
				this.AFKTimer = 0f;
				base.transform.DOLocalMoveY(this.originY, 0.5f, false).SetEase(Ease.OutSine);
			}
			else
			{
				bool flag4 = base.transform.localPosition.y != this.originY + 100f;
				if (flag4)
				{
					base.transform.DOLocalMoveY(this.originY + 100f, 0.5f, false).SetEase(Ease.OutSine);
				}
			}
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000040B0 File Offset: 0x000022B0
	public void UpdateCardItemPos<T>(List<T> cardItemList, TweenCallback OnComplete = null, bool isShort = false) where T : MonoBehaviour, ICard
	{
		this.lastqueue.Kill(false);
		cardItemList = (from x in cardItemList.AsValueEnumerable<T>()
		where x != null && !x.ignore
		select x).ToList<ListWhere<T>, T>();
		int count = cardItemList.Count;
		int number = count - 1;
		float Card_y_position = base.transform.position.y - 40f;
		this.UpdateIndex<T>(cardItemList);
		float offset = 1200f / (float)count + 10f;
		Vector3 zAxis = new Vector3(0f, 0f, 1f);
		Sequence moveSequence = DOTween.Sequence().Pause<Sequence>();
		Vector3 startPos = new Vector3((float)(-(float)count) / 2f * offset + offset * 0.5f, Card_y_position, 0f);
		for (int i = 0; i < count; i++)
		{
			RectTransform rectTransform = cardItemList[i].GetComponent<RectTransform>();
			bool flag = count >= 6;
			if (flag)
			{
				float step = startPos.x / 1200f;
				float yPos = this.anim.Evaluate(step) * 250f;
				bool flag2 = number > 0;
				if (flag2)
				{
					bool flag3 = number < 9;
					if (flag3)
					{
						this.Vars = this.VarList[number];
					}
					else
					{
						this.Vars = this.VarList[8];
					}
				}
				else
				{
					bool flag4 = number > -9;
					if (flag4)
					{
						this.Vars = -this.VarList[-number];
					}
					else
					{
						this.Vars = -this.VarList[8];
					}
				}
				float sin = this.sinList[Math.Abs(number % 2)];
				Vector3 startPos2 = new Vector3(startPos.x, yPos + Card_y_position - (float)(15 * (cardItemList.Count - 4)), 0f);
				cardItemList[i].initAngle = this.Vars * sin * zAxis;
				cardItemList[i].initPosition = startPos2;
				number -= 2;
			}
			else
			{
				cardItemList[i].initAngle = Vector3.zero;
				cardItemList[i].initPosition = startPos;
			}
			cardItemList[i].initAngle = new Vector3(0f, (float)(cardItemList[i].isReverse ? 180 : 0), cardItemList[i].initAngle.z * (float)(cardItemList[i].isReverse ? -1 : 1));
			bool flag5 = !cardItemList[i].draging;
			if (flag5)
			{
				if (isShort)
				{
					moveSequence.Insert(0f, rectTransform.DOAnchorPos(cardItemList[i].initPosition, 0.4f, false).SetEase(Ease.OutSine));
					this.cardTweenDict[cardItemList[i]] = rectTransform.DOAnchorPos(cardItemList[i].initPosition, 0.4f, false).SetEase(Ease.OutSine);
					moveSequence.Insert(0f, rectTransform.DOLocalRotate(cardItemList[i].initAngle, 0.4f, RotateMode.Fast));
				}
				else
				{
					moveSequence.Insert(0f, rectTransform.DOAnchorPos(cardItemList[i].initPosition, 0.6f, false).SetEase(Ease.OutSine));
					this.cardTweenDict[cardItemList[i]] = rectTransform.DOAnchorPos(cardItemList[i].initPosition, 0.6f, false).SetEase(Ease.OutSine);
					moveSequence.Insert(0f, rectTransform.DOLocalRotate(cardItemList[i].initAngle, 0.8f, RotateMode.Fast));
				}
			}
			startPos.x += offset;
		}
		bool flag6 = OnComplete != null;
		if (flag6)
		{
			moveSequence.OnComplete(OnComplete).OnKill(OnComplete).Play<Sequence>();
		}
		else
		{
			this.lastqueue = moveSequence;
			moveSequence.Play<Sequence>();
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00004528 File Offset: 0x00002728
	public void UpdateIndex<T>(List<T> cardItemList) where T : MonoBehaviour, ICard
	{
		List<T> cardList = (from x in cardItemList.AsValueEnumerable<T>()
		where x != null
		select x).ToList<ListWhere<T>, T>();
		for (int Index = 0; Index < cardList.Count; Index++)
		{
			cardList[Index].SetIndex(Index);
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00004590 File Offset: 0x00002790
	public void OnPointerEnter(PointerEventData eventData)
	{
		this.ResetTimer();
		this.OnEnter = true;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000045A1 File Offset: 0x000027A1
	public void OnPointerExit(PointerEventData eventData)
	{
		this.OnEnter = false;
	}

	// Token: 0x04000035 RID: 53
	public bool AFKAnimation = true;

	// Token: 0x04000036 RID: 54
	private float AFKTimer = 3f;

	// Token: 0x04000037 RID: 55
	private bool OnEnter = false;

	// Token: 0x04000038 RID: 56
	private float originY;

	// Token: 0x04000039 RID: 57
	public AnimationCurve anim;

	// Token: 0x0400003A RID: 58
	public Dictionary<ICard, Tween> cardTweenDict = new Dictionary<ICard, Tween>();

	// Token: 0x0400003B RID: 59
	private float Vars;

	// Token: 0x0400003C RID: 60
	private List<float> VarList = new List<float>();

	// Token: 0x0400003D RID: 61
	private List<float> sinList = new List<float>();

	// Token: 0x0400003E RID: 62
	private bool isHover;

	// Token: 0x0400003F RID: 63
	private Sequence lastqueue;
}

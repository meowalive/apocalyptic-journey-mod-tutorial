using System;
using System.Diagnostics;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200000D RID: 13
public class CardAnimationController
{
	// Token: 0x06000047 RID: 71 RVA: 0x000035F3 File Offset: 0x000017F3
	public void Initialize(Transform trans, ICard component)
	{
		this.card = component;
		this.transform = trans;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003604 File Offset: 0x00001804
	public void PlayEnterAnimation(Vector2 newPosition, float scale)
	{
		this.isSelect = true;
		this.transform.DOKill(false);
		this.scaleTween.Kill(false);
		this.moveTween.Kill(false);
		this.moveTween = this.transform.GetComponent<RectTransform>().DOAnchorPos(newPosition, 0.5f, false);
		float nowscale = this.transform.localScale.x;
		this.scaleTween = this.transform.DOScale(new Vector3((nowscale + scale) / 2f, (nowscale + scale) / 2f, (nowscale + scale) / 2f), 0.25f).OnComplete(delegate
		{
			this.transform.SetAsLastSibling();
			this.transform.GetComponent<SortingGroup>().sortingOrder = this.transform.GetSiblingIndex() + 13;
		});
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000036B8 File Offset: 0x000018B8
	public Tween PlayExitAnimation(Vector2 initPosition, float scale = 0.8f)
	{
		this.isSelect = false;
		this.StopRotation();
		this.moveTween.Kill(false);
		this.scaleTween.Kill(false);
		bool flag = this.transform == null;
		Tween result;
		if (flag)
		{
			result = null;
		}
		else
		{
			this.moveTween = this.transform.GetComponent<RectTransform>().DOAnchorPos(initPosition, 0.5f, false);
			this.transform.SetSiblingIndex(this.card.index);
			this.transform.GetComponent<SortingGroup>().sortingOrder = this.card.index - 13;
			this.scaleTween = this.transform.DOScale(new Vector3(scale, scale, scale), 0.3f);
			result = this.scaleTween;
		}
		return result;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00003780 File Offset: 0x00001980
	[DebuggerStepThrough]
	public UniTaskVoid RotateWithMouse()
	{
		CardAnimationController.<RotateWithMouse>d__10 <RotateWithMouse>d__ = new CardAnimationController.<RotateWithMouse>d__10();
		<RotateWithMouse>d__.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
		<RotateWithMouse>d__.<>4__this = this;
		<RotateWithMouse>d__.<>1__state = -1;
		<RotateWithMouse>d__.<>t__builder.Start<CardAnimationController.<RotateWithMouse>d__10>(ref <RotateWithMouse>d__);
		return <RotateWithMouse>d__.<>t__builder.Task;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000037C4 File Offset: 0x000019C4
	public Vector2 GetMousePos()
	{
		Vector2 screenPoint = KeyManager.playerAction.Main.Point.ReadValue<Vector2>();
		return PositionUtility.ScreenPointToCanvasPoint(GameObject.Find("Canvas").GetComponent<RectTransform>(), screenPoint);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003808 File Offset: 0x00001A08
	public void StartRandomRotation()
	{
		this.rotationTween.Kill(false);
		this.rotationTween.OnKill(delegate
		{
			this.rotationTween = this.transform.DORotate(this.card.initAngle, 0.5f, RotateMode.Fast);
		});
		this.rotationTween = this.transform.DOLocalRotate(new Vector3(0f, this.card.initAngle.y, 0f), 0.5f, RotateMode.Fast);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00003871 File Offset: 0x00001A71
	public void enddrag()
	{
		this.rotationTween.Kill(false);
		DOTween.Kill(this.transform, false);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003890 File Offset: 0x00001A90
	public void StopRotation()
	{
		bool flag = this.rotationTween.IsActive();
		if (flag)
		{
			this.rotationTween.Kill(false);
		}
		bool flag2 = this.transform != null;
		if (flag2)
		{
			Vector3 angle = this.card.initAngle;
			this.rotationTween = this.transform.DORotate(angle, 0.5f, RotateMode.Fast);
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x000038F4 File Offset: 0x00001AF4
	public void StopMove()
	{
		bool flag = this.moveTween.IsActive();
		if (flag)
		{
			this.moveTween.Kill(false);
		}
	}

	// Token: 0x04000021 RID: 33
	private Transform transform;

	// Token: 0x04000022 RID: 34
	private Tween rotationTween;

	// Token: 0x04000023 RID: 35
	public Tween moveTween;

	// Token: 0x04000024 RID: 36
	public Tween scaleTween;

	// Token: 0x04000025 RID: 37
	public ICard card;

	// Token: 0x04000026 RID: 38
	public static float maxAngle = 10f;

	// Token: 0x04000027 RID: 39
	public bool isSelect = false;
}

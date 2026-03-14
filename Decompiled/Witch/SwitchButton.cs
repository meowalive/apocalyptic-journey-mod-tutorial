using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x020000EC RID: 236
public class SwitchButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	// Token: 0x060007F5 RID: 2037 RVA: 0x0003F6A4 File Offset: 0x0003D8A4
	public void Awake()
	{
		bool flag = this.Normal == null;
		if (flag)
		{
			Transform transform = base.transform.Find("Normal");
			if (transform != null)
			{
				transform.TryGetComponent<CanvasGroup>(out this.Normal);
			}
		}
		bool flag2 = this.Pressed == null;
		if (flag2)
		{
			Transform transform2 = base.transform.Find("Pressed");
			if (transform2 != null)
			{
				transform2.TryGetComponent<CanvasGroup>(out this.Pressed);
			}
		}
		bool flag3 = this.Highlighted == null;
		if (flag3)
		{
			Transform transform3 = base.transform.Find("Highlighted");
			if (transform3 != null)
			{
				transform3.TryGetComponent<CanvasGroup>(out this.Highlighted);
			}
		}
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x0003F750 File Offset: 0x0003D950
	private void Start()
	{
		bool flag = !base.gameObject.activeSelf;
		if (!flag)
		{
			bool flag2 = this.isSingle && !this.allowSwitchOff;
			if (flag2)
			{
				bool flag3 = !base.transform.parent.GetComponent<SwitchButtonGroup>();
				if (flag3)
				{
					base.transform.parent.gameObject.AddComponent<SwitchButtonGroup>();
					this._isOn = true;
					this.SetState(this.Pressed);
				}
			}
			else
			{
				this.SetState(this.Normal);
			}
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0003F7E5 File Offset: 0x0003D9E5
	// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0003F7F0 File Offset: 0x0003D9F0
	public bool isOn
	{
		get
		{
			return this._isOn;
		}
		set
		{
			bool flag = this._isOn != value;
			if (flag)
			{
				this._isOn = value;
				bool isOn = this._isOn;
				if (isOn)
				{
					this.SetState(this.Pressed);
					bool flag2 = this.isSingle;
					if (flag2)
					{
						foreach (object obj in base.transform.parent)
						{
							Transform child = (Transform)obj;
							bool flag3 = !child.gameObject.activeSelf;
							if (!flag3)
							{
								bool flag4 = child != base.transform;
								if (flag4)
								{
									child.GetComponent<SwitchButton>().isOn = false;
								}
							}
						}
					}
				}
				else
				{
					bool flag5 = !this.isSingle;
					if (flag5)
					{
						this.SetState(this.Normal);
					}
					else
					{
						bool flag6 = this.allowSwitchOff;
						if (flag6)
						{
							this.SetState(this.Normal);
							return;
						}
						foreach (object obj2 in base.transform.parent)
						{
							Transform child2 = (Transform)obj2;
							bool flag7 = !child2.gameObject.activeSelf;
							if (!flag7)
							{
								bool isOn2 = child2.GetComponent<SwitchButton>().isOn;
								if (isOn2)
								{
									this.SetState(this.Normal);
									return;
								}
							}
						}
						this._isOn = true;
					}
				}
				this.onValueChanged.Invoke(this._isOn);
				bool isOn3 = this._isOn;
				if (isOn3)
				{
					this.onClick.Invoke();
				}
			}
		}
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0003F9D8 File Offset: 0x0003DBD8
	public void OnPointerEnter(PointerEventData eventData)
	{
		bool flag = this.interactable;
		if (flag)
		{
			bool flag2 = !this.isOn;
			if (flag2)
			{
				this.SetState(this.Highlighted);
			}
		}
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x0003FA10 File Offset: 0x0003DC10
	public void OnPointerExit(PointerEventData eventData)
	{
		bool flag = this.interactable;
		if (flag)
		{
			bool flag2 = !this.isOn;
			if (flag2)
			{
				this.SetState(this.Normal);
			}
		}
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x0003FA48 File Offset: 0x0003DC48
	public void OnPointerClick(PointerEventData eventData)
	{
		bool flag = this.interactable;
		if (flag)
		{
			this.isOn = !this.isOn;
		}
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x0003FA74 File Offset: 0x0003DC74
	private void ResetAll()
	{
		bool flag = this.Normal != null;
		if (flag)
		{
			this.Normal.DOKill(false);
			this.Normal.alpha = 0f;
			this.Normal.blocksRaycasts = false;
		}
		bool flag2 = this.Pressed != null;
		if (flag2)
		{
			this.Pressed.DOKill(false);
			this.Pressed.alpha = 0f;
			this.Pressed.blocksRaycasts = false;
		}
		bool flag3 = this.Highlighted != null;
		if (flag3)
		{
			this.Highlighted.DOKill(false);
			this.Highlighted.alpha = 0f;
			this.Highlighted.blocksRaycasts = false;
		}
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x0003FB3C File Offset: 0x0003DD3C
	private void SetState(CanvasGroup cg)
	{
		bool flag = cg == null;
		if (!flag)
		{
			this.ResetAll();
			bool flag2 = this.isAnimated;
			if (flag2)
			{
				SwitchButton.AnimationType animationType = this.animationType;
				SwitchButton.AnimationType animationType2 = animationType;
				if (animationType2 != SwitchButton.AnimationType.None)
				{
					if (animationType2 == SwitchButton.AnimationType.Fade)
					{
						cg.DOFade(1f, this.transitionTime).SetEase(Ease.OutQuad);
					}
				}
				else
				{
					cg.alpha = 1f;
				}
			}
			else
			{
				cg.alpha = 1f;
			}
			cg.blocksRaycasts = true;
		}
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x0003FBC0 File Offset: 0x0003DDC0
	public void SetElement(Action<Transform> action)
	{
		bool flag = this.Normal != null;
		if (flag)
		{
			if (action != null)
			{
				action(this.Normal.transform);
			}
		}
		bool flag2 = this.Highlighted != null;
		if (flag2)
		{
			if (action != null)
			{
				action(this.Highlighted.transform);
			}
		}
		bool flag3 = this.Pressed != null;
		if (flag3)
		{
			if (action != null)
			{
				action(this.Pressed.transform);
			}
		}
	}

	// Token: 0x04000B68 RID: 2920
	public CanvasGroup Normal;

	// Token: 0x04000B69 RID: 2921
	public CanvasGroup Pressed;

	// Token: 0x04000B6A RID: 2922
	public CanvasGroup Highlighted;

	// Token: 0x04000B6B RID: 2923
	private bool _isOn = false;

	// Token: 0x04000B6C RID: 2924
	public bool isSingle;

	// Token: 0x04000B6D RID: 2925
	public bool allowSwitchOff;

	// Token: 0x04000B6E RID: 2926
	public SwitchButton.AnimationType animationType = SwitchButton.AnimationType.None;

	// Token: 0x04000B6F RID: 2927
	public float transitionTime = 0.5f;

	// Token: 0x04000B70 RID: 2928
	public bool isAnimated = false;

	// Token: 0x04000B71 RID: 2929
	public bool interactable = true;

	// Token: 0x04000B72 RID: 2930
	public UnityEvent<bool> onValueChanged = new UnityEvent<bool>();

	// Token: 0x04000B73 RID: 2931
	public UnityEvent onClick = new UnityEvent();

	// Token: 0x020000ED RID: 237
	public enum AnimationType
	{
		// Token: 0x04000B75 RID: 2933
		None,
		// Token: 0x04000B76 RID: 2934
		Fade
	}
}

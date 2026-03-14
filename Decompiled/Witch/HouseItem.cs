using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x020000FB RID: 251
public class HouseItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	// Token: 0x06000843 RID: 2115 RVA: 0x00041B34 File Offset: 0x0003FD34
	private void Awake()
	{
		base.gameObject.AddComponent<SelectOutline>();
		this.RegisterEvent();
		this.DataUpdate();
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00041B51 File Offset: 0x0003FD51
	private void DataUpdate()
	{
		base.transform.Find("Name/text").GetComponent<TMP_Text>().text = this.oriStr.Localize("Tips");
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00041B80 File Offset: 0x0003FD80
	public virtual void RegisterEvent()
	{
		Singleton<EventCenter>.Instance.AddEventListener(LanguageEvent.LanguageChange.ToString(), new Action(this.DataUpdate), this, EventDispose.None);
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00041BB8 File Offset: 0x0003FDB8
	public void OnPointerClick(PointerEventData eventData)
	{
		bool flag = Singleton<GameRuntimeData>.Instance.playCount < this.TargetCount;
		if (flag)
		{
			UIManager.Instance.ShowModalWindow("Tips", "Go through more adventures to unlock", null, 0f, null, true, true, "Yes", "No", true);
		}
		else
		{
			this.houseUI.ClickItem(this.houseItemType);
		}
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00041C1C File Offset: 0x0003FE1C
	private void OnDestroy()
	{
		Singleton<EventCenter>.Instance.RemoveEventListener(LanguageEvent.LanguageChange.ToString(), this);
	}

	// Token: 0x04000BA0 RID: 2976
	public HouseUI houseUI;

	// Token: 0x04000BA1 RID: 2977
	public int TargetCount = 0;

	// Token: 0x04000BA2 RID: 2978
	public string oriStr = "";

	// Token: 0x04000BA3 RID: 2979
	public HouseItem.HouseItemType houseItemType;

	// Token: 0x020000FC RID: 252
	public enum HouseItemType
	{
		// Token: 0x04000BA5 RID: 2981
		CardEditor,
		// Token: 0x04000BA6 RID: 2982
		OutsiderShop,
		// Token: 0x04000BA7 RID: 2983
		ModManager,
		// Token: 0x04000BA8 RID: 2984
		GameMenu,
		// Token: 0x04000BA9 RID: 2985
		crystalBall,
		// Token: 0x04000BAA RID: 2986
		store,
		// Token: 0x04000BAB RID: 2987
		Dictionary,
		// Token: 0x04000BAC RID: 2988
		shadow,
		// Token: 0x04000BAD RID: 2989
		announcement,
		// Token: 0x04000BAE RID: 2990
		task
	}
}

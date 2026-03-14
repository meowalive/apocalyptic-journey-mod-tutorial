using System;
using TMPro;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x020002D8 RID: 728
	public class EnchCardItem : ItemNonDrag
	{
		// Token: 0x06001695 RID: 5781 RVA: 0x000B7E6C File Offset: 0x000B606C
		public override void OnPointerClick(PointerEventData eventData)
		{
			bool flag = eventData.button == PointerEventData.InputButton.Right;
			if (flag)
			{
				this.ShowFloatingWindow();
			}
			bool flag2 = eventData.button == PointerEventData.InputButton.Left;
			if (flag2)
			{
				this.HideFloatingWindow();
			}
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000B7EA6 File Offset: 0x000B60A6
		public override void ShowFloatingWindow()
		{
			this.floatingWindow.Clear();
			this.floatingWindow.AddButton("unmount", delegate()
			{
				this.Unload();
				this.HideFloatingWindow();
			}, null);
			base.ShowFloatingWindow();
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000B7EDA File Offset: 0x000B60DA
		public override void Init(DataConfig dataConfig)
		{
			base.Init(dataConfig);
			ICard.SetCardStyle(base.transform, dataConfig);
			this.ItemType = "Card";
			ICard.SetCardMsg(base.transform, dataConfig, null);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x000B7F0C File Offset: 0x000B610C
		public void Unload()
		{
			bool flag = !RoleTable.Instance.enchasedDict.ContainsKey(this.dataConfig.InstanceID);
			if (flag)
			{
				UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("该卡牌尚未被镶嵌", CaptionStyle.Top, 1f, 1.5f, 3);
			}
			else
			{
				DataConfig item = RoleTable.Instance.enchasedDict[this.dataConfig.InstanceID];
				this.dataConfig.data["Description"].Remove(this.dataConfig.data["Description"].LastIndexOf(item.data["Description"]), item.data["Description"].Length);
				this.dataConfig.scriptExecutor.RunScript("UnloadScript");
				this.dataConfig.PreCompileScripts();
				this.dataConfig.scriptExecutor.RunScript("InitScript");
				base.itemDescription = this.dataConfig.Description().Highlight(this.keywords);
				base.gameObject.GetComponent<KeywordDisplay>().SetText(base.itemName, this.CreateTooltipText(), this.keywords, null, null, null);
				base.transform.Find("Front/字体/msgTxt").GetComponent<TMP_Text>().text = base.itemDescription;
				Singleton<GameRuntimeData>.Instance.Save();
				RoleTable.Instance.enchasedDict.Remove(this.dataConfig.InstanceID);
				base.transform.Find("Front/icon/Ench").gameObject.SetActive(false);
			}
		}

		// Token: 0x040011BD RID: 4541
		public CardEnchUI CardEnchUI;
	}
}

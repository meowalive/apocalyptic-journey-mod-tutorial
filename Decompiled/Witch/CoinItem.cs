using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Witch.UI;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x02000248 RID: 584
	public class CoinItem : MapItem
	{
		// Token: 0x060012D2 RID: 4818 RVA: 0x00093AA4 File Offset: 0x00091CA4
		public override void OnPointerDown(PointerEventData eventData)
		{
			bool flag = base.name == "Null";
			if (!flag)
			{
				Transform nullItem = base.transform.parent.GetChild(base.transform.parent.childCount - 1);
				bool flag2 = nullItem.name != "Null" && base.transform.parent.name == "Content";
				if (!flag2)
				{
					bool flag3 = this.isLine || eventData.button == PointerEventData.InputButton.Right;
					if (!flag3)
					{
						this.currentSystem.enabled = false;
						this.StartLine().Forget();
					}
				}
			}
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00093B58 File Offset: 0x00091D58
		[DebuggerStepThrough]
		public override UniTask StartLine()
		{
			CoinItem.<StartLine>d__1 <StartLine>d__ = new CoinItem.<StartLine>d__1();
			<StartLine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartLine>d__.<>4__this = this;
			<StartLine>d__.<>1__state = -1;
			<StartLine>d__.<>t__builder.Start<CoinItem.<StartLine>d__1>(ref <StartLine>d__);
			return <StartLine>d__.<>t__builder.Task;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00093B9C File Offset: 0x00091D9C
		public override void Init(MapTree.Node node1)
		{
			this.currentSystem = EventSystem.current;
			this.lastParent = base.transform.parent;
			this.node = node1;
			this.keywordDisplay = base.gameObject.AddComponent<KeywordDisplay>();
			this.ItemType = "Map";
			this.DataUpdate();
			this.animationController = new CardAnimationController();
			this.animationController.Initialize(base.transform, this);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00093C10 File Offset: 0x00091E10
		public override void DataUpdate()
		{
			bool flag = this.node == null;
			if (!flag)
			{
				this.keywordDisplay.SetText(this.node.data.Localize("Name"), this.node.data.Localize("Description"), this.keywords, null, null, null);
				base.transform.Find("Front/字体/Text").gameObject.GetComponent<TMP_Text>().text = this.node.data["Type"].Localize("MapSelectUI");
			}
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00093CAC File Offset: 0x00091EAC
		public override void RayCheck()
		{
			bool flag = !this.isLine || UIManager.Instance.GetUI<SlotMachUI>("SlotMachUI").IsAnimating;
			if (!flag)
			{
				bool flag2 = KeyManager.playerAction.Main.Click.WasReleasedThisFrame();
				if (flag2)
				{
					this.isLine = false;
					this.currentSystem.enabled = true;
					base.gameObject.GetComponent<ObjectGroup>().blocksRaycasts = false;
					Cursor.visible = true;
					bool flag3 = UIManager.Instance.GetUI<LineUI>("LineUI") != null;
					if (flag3)
					{
						UIManager.Instance.GetUI<LineUI>("LineUI").Hide();
					}
					PointerEventData pointerEventData = new PointerEventData(EventSystem.current)
					{
						position = KeyManager.playerAction.Main.Point.ReadValue<Vector2>(),
						button = PointerEventData.InputButton.Left
					};
					bool hasSelected = this.hasSelected;
					if (hasSelected)
					{
						this.lastPos = base.transform.GetComponent<RectTransform>().localPosition;
					}
					else
					{
						this.lastPos = base.initPosition;
					}
					bool InMachine = false;
					List<RaycastResult> results = new List<RaycastResult>();
					EventSystem.current.RaycastAll(pointerEventData, results);
					foreach (RaycastResult result in results)
					{
						bool flag4 = result.gameObject.name == "SlotMachine";
						if (flag4)
						{
							InMachine = true;
							break;
						}
					}
					this.animationController.StopRotation();
					this.animationController.moveTween.Kill(false);
					this.animationController.scaleTween.Kill(false);
					base.transform.DOKill(false);
					bool flag5 = InMachine && SlotMachineManager.canuse;
					if (flag5)
					{
						UIManager.Instance.GetUI<SlotMachUI>("SlotMachUI").CoinUse(this.node);
						UnityEngine.Object.Destroy(base.gameObject);
					}
				}
			}
		}
	}
}

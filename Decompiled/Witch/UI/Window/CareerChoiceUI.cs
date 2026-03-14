using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x020002B8 RID: 696
	public class CareerChoiceUI : UIBase
	{
		// Token: 0x060015B4 RID: 5556 RVA: 0x000AE540 File Offset: 0x000AC740
		[DebuggerStepThrough]
		public void Init(string way)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CareerChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CareerChoiceUI.Init(string)).MethodHandle, typeof(CareerChoiceUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				way
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							way = null;
						}
						else
						{
							way = (string)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_Init(way);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_FD;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_FD:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000AE674 File Offset: 0x000AC874
		[DebuggerStepThrough]
		public void ChangeShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CareerChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CareerChoiceUI.ChangeShow()).MethodHandle, typeof(CareerChoiceUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_ChangeShow();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000AE770 File Offset: 0x000AC970
		public void UpdateCareer()
		{
			Transform itemPre = base.transform.Find("Content/ItemList/ItemPre");
			foreach (object obj in base.transform.Find("Content/ItemList"))
			{
				Transform child = (Transform)obj;
				bool flag = child == itemPre;
				if (!flag)
				{
					child.transform.Find("pillar").DOKill(false);
					bool flag2 = child.GetComponent<ShowCareer>() != null && child.GetComponent<ShowCareer>().isSelected;
					if (flag2)
					{
						child.transform.Find("pillar").GetComponent<RectTransform>().DOAnchorPosY(itemPre.transform.Find("pillar").GetComponent<RectTransform>().anchoredPosition.y, 1.5f, false);
					}
					else
					{
						child.transform.Find("pillar").GetComponent<RectTransform>().DOAnchorPosY(itemPre.transform.Find("pillar").GetComponent<RectTransform>().anchoredPosition.y - 200f, 1.5f, false);
					}
				}
			}
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000AE8C4 File Offset: 0x000ACAC4
		public void ShowCareer()
		{
			Transform itemPre = base.transform.Find("Content/ItemList/ItemPre");
			Transform tempParent = itemPre.parent;
			List<Dictionary<string, string>> tempList = new List<Dictionary<string, string>>();
			bool flag = this.choiceWay == "Career";
			if (flag)
			{
				base.transform.Find("Content/Title/text").GetComponent<TextMeshProUGUI>().text = "选择魔女";
				tempList = (from b in Singleton<GameConfigManager>.Instance.GetTable(DataType.Career).Getlines().AsValueEnumerable<Dictionary<string, string>>()
				where !Singleton<GameRuntimeData>.Instance.IsLocked(b["Id"])
				select b).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			}
			else
			{
				bool flag2 = this.choiceWay == "Partner";
				if (flag2)
				{
					base.transform.Find("Content/Title/text").GetComponent<TextMeshProUGUI>().text = "选择伙伴";
					tempList = Singleton<GameConfigManager>.Instance.GetTable(DataType.Partner).Getlines().ToList<Dictionary<string, string>>();
				}
			}
			for (int i = 0; i < tempList.Count; i++)
			{
				bool flag3 = this.choiceWay == "Career";
				DataConfig item;
				if (flag3)
				{
					item = new DataConfig(tempList[i]["Id"], DataType.Career);
				}
				else
				{
					bool flag4 = this.choiceWay == "Partner";
					if (!flag4)
					{
						Debug.LogError("Unknown choice way: " + this.choiceWay);
						return;
					}
					item = new DataConfig(tempList[i]["Id"], DataType.Partner);
				}
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(itemPre.gameObject, tempParent);
				gameObject.SetActive(true);
				gameObject.GetComponent<ShowCareer>().dataConfig = item;
				Sprite newSprite = ResourceLoader.Load<Sprite>(tempList[i]["DollIcon"], true);
				TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(newSprite.texture, 0.1f);
				gameObject.transform.Find("pillar/Doll").GetComponent<Image>().sprite = newSprite;
				gameObject.transform.Find("pillar/Doll").GetComponent<RectTransform>().sizeDelta = new Vector2(newSprite.bounds.size.x * 100f, newSprite.bounds.size.y * 100f);
				gameObject.transform.Find("pillar/Doll").GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, (float)(-(float)realBounds.bottomTransparentHeight), 0f);
				gameObject.GetComponent<ShowCareer>().Init(item);
			}
			foreach (object obj in tempParent)
			{
				Transform child = (Transform)obj;
				child.transform.Find("pillar").DOKill(false);
			}
			ShowCareer temp = null;
			foreach (object obj2 in tempParent)
			{
				Transform child2 = (Transform)obj2;
				bool flag5 = child2 != itemPre;
				if (flag5)
				{
					child2.transform.Find("pillar").GetComponent<RectTransform>().anchoredPosition = new Vector3(child2.transform.Find("pillar").GetComponent<RectTransform>().anchoredPosition.x, itemPre.transform.Find("pillar").GetComponent<RectTransform>().anchoredPosition.y - 500f, 0f);
					bool flag6 = temp == null;
					if (flag6)
					{
						temp = child2.GetComponent<ShowCareer>();
						bool flag7 = temp != null;
						if (flag7)
						{
							temp.isSelected = true;
							child2.transform.Find("pillar").GetComponent<RectTransform>().DOAnchorPosY(500f, 3f, false).SetRelative(true);
						}
					}
					else
					{
						child2.transform.Find("pillar").GetComponent<RectTransform>().DOAnchorPosY(300f, 1.5f, false).SetRelative(true);
					}
				}
			}
			this.ShowDetail(temp);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000AED54 File Offset: 0x000ACF54
		public override void Hide()
		{
			this.ChangeShow();
			Transform itemPre = base.transform.Find("Content/ItemList/ItemPre");
			foreach (object obj in itemPre.parent)
			{
				Transform child = (Transform)obj;
				bool flag = child != itemPre && child.gameObject != null;
				if (flag)
				{
					UnityEngine.Object.Destroy(child.gameObject);
				}
			}
			base.gameObject.SetActive(false);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000AEE00 File Offset: 0x000AD000
		public override void OnDisable()
		{
			base.OnDisable();
			Transform itemPre = base.transform.Find("Content/ItemList/ItemPre");
			foreach (object obj in itemPre.parent)
			{
				Transform child = (Transform)obj;
				child.transform.Find("pillar").DOKill(false);
				child.transform.Find("pillar").GetComponent<RectTransform>().anchoredPosition = new Vector3(child.transform.Find("pillar").GetComponent<RectTransform>().anchoredPosition.x, itemPre.transform.Find("pillar").GetComponent<RectTransform>().anchoredPosition.y, 0f);
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000AEEF4 File Offset: 0x000AD0F4
		[DebuggerStepThrough]
		public void CancelCareer()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CareerChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CareerChoiceUI.CancelCareer()).MethodHandle, typeof(CareerChoiceUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_CancelCareer();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		[DebuggerStepThrough]
		public void ShowDetail(ShowCareer career)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CareerChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CareerChoiceUI.ShowDetail(Witch.UI.Window.ShowCareer)).MethodHandle, typeof(CareerChoiceUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				career
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							career = null;
						}
						else
						{
							career = (ShowCareer)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_ShowDetail(career);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_FD;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_FD:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000AF124 File Offset: 0x000AD324
		[DebuggerStepThrough]
		private unsafe void GetDes(string description, out string name, out string des)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(CareerChoiceUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(CareerChoiceUI.GetDes(string, string*, string*)).MethodHandle, typeof(CareerChoiceUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				description,
				name,
				des
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							description = null;
						}
						else
						{
							description = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							name = null;
						}
						else
						{
							name = (string)arguments[1];
						}
						if (arguments[2] == null)
						{
							des = null;
						}
						else
						{
							des = (string)arguments[2];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_GetDes(description, out name, out des);
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							object[] arguments2 = methodContext.Arguments;
							arguments2[1] = name;
							arguments2[2] = des;
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_15F;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
						object[] arguments3 = methodContext.Arguments;
						arguments3[1] = name;
						arguments3[2] = des;
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_15F:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000AF2CC File Offset: 0x000AD4CC
		private void $Rougamo_Init(string way)
		{
			this.choiceWay = way;
			bool flag = this.choiceWay == "Career";
			if (flag)
			{
				base.transform.Find("Content/RightDes").GetComponent<CanvasGroup>().alpha = 1f;
			}
			else
			{
				bool flag2 = this.choiceWay == "Partner";
				if (flag2)
				{
					base.transform.Find("Content/RightDes").GetComponent<CanvasGroup>().alpha = 0f;
				}
			}
			base.transform.Find("Content/描述").GetComponent<CanvasGroup>().alpha = 0f;
			this.ShowCareer();
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000AF378 File Offset: 0x000AD578
		private void $Rougamo_ChangeShow()
		{
			bool flag = CareerChoiceUI.Partner == null;
			if (flag)
			{
				CareerChoiceUI.Partner = new DataConfig(Singleton<GameConfigManager>.Instance.GetTable(DataType.Partner).Getlines()[0]["Id"], DataType.Partner);
			}
			Sprite newSprite = ResourceLoader.Load<Sprite>(CareerChoiceUI.Partner.data["DollIcon"], true);
			TextureTransparencyAnalyzer.TransparencyData realBounds = TextureTransparencyAnalyzer.AnalyzeAllEdges(newSprite.texture, 0.1f);
			GameObject tempObj = this.houseUI.transform.Find("House/tree/birdcage/base/obj").gameObject;
			tempObj.GetComponent<SpriteRenderer>().sprite = newSprite;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_CancelCareer()
		{
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000AF414 File Offset: 0x000AD614
		private void $Rougamo_ShowDetail(ShowCareer career)
		{
			base.transform.Find("Content/描述").GetComponent<CanvasGroup>().alpha = 1f;
			base.transform.Find("Content/RightDes/MainTitle/text").GetComponent<TMP_Text>().text = career.dataConfig.data.Localize("Title");
			bool flag = this.choiceWay == "Career";
			if (flag)
			{
				Sprite sprite = ResourceLoader.Load<Sprite>(career.dataConfig.data["CareerImage"], true);
				bool flag2 = sprite != null;
				if (flag2)
				{
					base.transform.Find("Content/RightDes").GetComponent<Image>().sprite = sprite;
				}
			}
			bool flag3 = career != null;
			if (flag3)
			{
				base.transform.Find("Content/描述/Content/name/text").GetComponent<TextMeshProUGUI>().text = career.itemName;
				base.transform.Find("Content/描述/Content/description/Scroll Area/List/description").GetComponent<TextMeshProUGUI>().text = career.itemDescription;
				int i = 0;
				for (int j = 1; j < 4; j++)
				{
					base.transform.Find("Content/描述/Content/description/tags/Item" + j.ToString()).gameObject.SetActive(false);
				}
				for (int k = 1; k <= 3; k++)
				{
					string temp = career.dataConfig.data.Localize("Action" + k.ToString());
					bool flag4 = temp == null || temp == "";
					if (flag4)
					{
						break;
					}
					string name;
					string des;
					this.GetDes(temp, out name, out des);
					i++;
					Transform tagItem = base.transform.Find("Content/描述/Content/description/tags/Item" + i.ToString());
					tagItem.gameObject.SetActive(true);
					tagItem.Find("text").GetComponent<TextMeshProUGUI>().text = "Active skill".Localize("Tips") + ":" + name;
					List<string> keyWords = new List<string>();
					des = des.Highlight(keyWords);
					tagItem.GetComponent<KeywordDisplay>().SetText(name, des, new List<string>(), null, null, "Skill");
					tagItem.Find("background").GetComponent<Image>().sprite = ResourceLoader.LoadAll<Sprite>("Icon/UI_Icons/Native/状态/技能框")[0];
					bool flag5 = i == 3;
					if (flag5)
					{
						return;
					}
				}
				for (int l = 1; l <= 3; l++)
				{
					string temp2 = career.dataConfig.data.Localize("Passive" + l.ToString());
					bool flag6 = temp2 == null || temp2 == "";
					if (flag6)
					{
						break;
					}
					string name2;
					string des2;
					this.GetDes(temp2, out name2, out des2);
					i++;
					Transform tagItem2 = base.transform.Find("Content/描述/Content/description/tags/Item" + i.ToString());
					tagItem2.gameObject.SetActive(true);
					tagItem2.Find("text").GetComponent<TextMeshProUGUI>().text = "Passive skill".Localize("Tips") + ":" + name2;
					List<string> keyWords2 = new List<string>();
					des2 = des2.Highlight(keyWords2);
					tagItem2.GetComponent<KeywordDisplay>().SetText(name2, des2, new List<string>(), null, null, "Skill");
					tagItem2.Find("background").GetComponent<Image>().sprite = ResourceLoader.LoadAll<Sprite>("Icon/UI_Icons/Native/状态/技能框")[1];
					bool flag7 = i == 3;
					if (flag7)
					{
						break;
					}
				}
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000AF7D4 File Offset: 0x000AD9D4
		private void $Rougamo_GetDes(string description, out string name, out string des)
		{
			name = "";
			des = "";
			string namePattern = "<name>(.*?)<\\/name>";
			string desPattern = "<des>(.*?)<\\/des>";
			Match nameMatch = Regex.Match(description, namePattern, RegexOptions.Singleline);
			Match desMatch = Regex.Match(description, desPattern, RegexOptions.Singleline);
			bool success = nameMatch.Success;
			if (success)
			{
				name = nameMatch.Groups[1].Value;
			}
			bool success2 = desMatch.Success;
			if (success2)
			{
				des = desMatch.Groups[1].Value;
			}
		}

		// Token: 0x04001135 RID: 4405
		public static DataConfig career;

		// Token: 0x04001136 RID: 4406
		public static DataConfig Partner;

		// Token: 0x04001137 RID: 4407
		public HouseUI houseUI;

		// Token: 0x04001138 RID: 4408
		public string choiceWay = "Career";
	}
}

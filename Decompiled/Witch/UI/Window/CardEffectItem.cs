using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Cysharp.Text;
using DataEditor.CardEditor;
using Michsky.MUIP;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x020002B1 RID: 689
	public class CardEffectItem : MonoBehaviour
	{
		// Token: 0x06001596 RID: 5526 RVA: 0x000ACA56 File Offset: 0x000AAC56
		private void Awake()
		{
			CardEffectItem.cardEffectItems.Add(this);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x000ACA65 File Offset: 0x000AAC65
		public void IsBuff()
		{
			this.isBuff = true;
			base.transform.Find("Content/Icon").GetComponent<Button>().onClick.AddListener(delegate
			{
				this.ShowChangeBuff();
			});
		}

		/// <summary>
		/// 重新计算效果花费
		/// </summary>
		// Token: 0x06001598 RID: 5528 RVA: 0x000ACA9C File Offset: 0x000AAC9C
		public void CalculateCost()
		{
			int index = base.transform.GetSiblingIndex();
			this.effectCost = this.RunMethod().Item2;
			CardEffectItem item = null;
			while (--index >= 0)
			{
				CardEffectItem cardEffectItem = base.transform.parent.GetChild(index).GetComponent<CardEffectItem>();
				bool flag = cardEffectItem == null || cardEffectItem.isMarkedForDestruction || cardEffectItem.methodName != "SetStatus";
				if (!flag)
				{
					item = cardEffectItem;
					break;
				}
			}
			bool flag2 = item != null;
			if (flag2)
			{
				bool flag3 = !(item.vars["filter"] == "自己");
				if (flag3)
				{
					float weight = typeof(CardEditorBase).GetMethod(this.methodName).GetCustomAttribute<EffectTarget>().weight;
					this.effectCost = (int)((float)this.effectCost * weight);
				}
				bool flag4 = item.vars["filter"] == "所有敌人";
				if (flag4)
				{
					this.effectCost = (int)((double)this.effectCost * 1.5);
				}
				bool flag5 = item.vars["filter"] == "所有";
				if (flag5)
				{
					this.effectCost = (int)((double)Mathf.Abs(this.effectCost) * 0.8);
				}
			}
			bool flag6 = this.effectCost > int.MaxValue;
			if (flag6)
			{
				this.effectCost = int.MaxValue;
			}
			else
			{
				bool flag7 = this.effectCost < int.MinValue;
				if (flag7)
				{
					this.effectCost = int.MinValue;
				}
			}
			bool flag8 = this.effectCost < -100;
			if (flag8)
			{
				this.effectCost = -100;
			}
			bool flag9 = this.effectCost < 0;
			if (flag9)
			{
				bool flag10 = CardEffectItem.negativeCosts < -100;
				if (flag10)
				{
					this.effectCost = 0;
				}
				else
				{
					bool flag11 = (float)CardEffectItem.negativeCosts + (float)this.effectCost * this.costMultiplier < -100f;
					if (flag11)
					{
						this.effectCost = (int)((float)(-100 - CardEffectItem.negativeCosts) / this.costMultiplier);
					}
				}
				CardEffectItem.negativeCosts += (int)((float)this.effectCost * this.costMultiplier);
			}
			this.cardEditorUI.cost += (int)((float)this.effectCost * this.costMultiplier);
			bool flag12 = this.cardEditorUI.cost < int.MinValue;
			if (flag12)
			{
				this.cardEditorUI.cost = int.MinValue;
			}
			bool flag13 = this.cardEditorUI.cost > int.MaxValue;
			if (flag13)
			{
				this.cardEditorUI.cost = int.MaxValue;
			}
			base.transform.Find("Cost/val").GetComponent<TMP_Text>().text = ZString.Format<object>("(<color=orange>{0}</color>)", (float)this.effectCost * this.costMultiplier);
			bool flag14 = typeof(CardEditorBase).GetMethod(this.methodName).GetCustomAttribute<AddDesVal>() == null;
			if (!flag14)
			{
				this.desValIndex = CardEffectItem.desValCount;
				CardEffectItem.desValCount++;
			}
		}

		/// <summary>
		/// 生成描述
		/// </summary>
		// Token: 0x06001599 RID: 5529 RVA: 0x000ACDCC File Offset: 0x000AAFCC
		public void CreateDescription()
		{
			base.transform.Find("Delete").GetComponent<ButtonManager>().onClick.AddListener(delegate
			{
				UnityEngine.Object.Destroy(base.gameObject);
			});
			GameObject desPrefab = base.transform.Find("Content/texts/description/des").gameObject;
			GameObject inputFieldPrefab = base.transform.Find("Content/texts/description/InputField").gameObject;
			GameObject toggleGroupPrefab = base.transform.Find("Content/texts/description/Toggle Group").gameObject;
			string tmp = this.effectDes;
			while (tmp.IndexOf("{") != -1)
			{
				int pos = tmp.IndexOf("{");
				int pos2 = tmp.IndexOf("}");
				string des = tmp.Substring(0, pos);
				string varName = tmp.Substring(pos + 1, pos2 - pos - 1);
				tmp = tmp.Substring(pos2 + 1);
				GameObject desObj = UnityEngine.Object.Instantiate<GameObject>(desPrefab, desPrefab.transform.parent);
				desObj.GetComponent<TextMeshProUGUI>().text = des;
				GameObject inputFieldObj = UnityEngine.Object.Instantiate<GameObject>(inputFieldPrefab, inputFieldPrefab.transform.parent);
				this.vars[varName] = "";
				inputFieldObj.GetComponent<TMP_InputField>().onValueChanged.AddListener(delegate(string value)
				{
					this.vars[varName] = value;
				});
				inputFieldObj.GetComponent<TMP_InputField>().onEndEdit.AddListener(delegate(string value)
				{
					this.UpdateAll();
				});
				desObj.SetActive(true);
				inputFieldObj.SetActive(true);
				MethodInfo methodInfo = typeof(CardEditorBase).GetMethod(this.methodName);
				ParameterInfo[] parameterInfos = methodInfo.GetParameters();
				foreach (ParameterInfo parameterInfo in parameterInfos)
				{
					bool flag = parameterInfo.Name != varName;
					if (!flag)
					{
						bool flag2 = parameterInfo.ParameterType == typeof(int);
						if (flag2)
						{
							this.vars[varName] = "0";
							TMP_InputField inputField = inputFieldObj.GetComponent<TMP_InputField>();
							inputField.contentType = TMP_InputField.ContentType.IntegerNumber;
							inputField.onEndEdit.AddListener(delegate(string value)
							{
								int result;
								bool flag11 = int.TryParse(value, out result);
								if (flag11)
								{
									this.vars[varName] = result.ToString();
								}
								else
								{
									this.vars[varName] = "0";
									inputField.text = "0";
								}
							});
						}
						else
						{
							bool flag3 = parameterInfo.ParameterType == typeof(float);
							if (flag3)
							{
								this.vars[varName] = "0";
								TMP_InputField inputField = inputFieldObj.GetComponent<TMP_InputField>();
								inputField.contentType = TMP_InputField.ContentType.DecimalNumber;
								inputField.onEndEdit.AddListener(delegate(string value)
								{
									float result;
									bool flag11 = float.TryParse(value, out result);
									if (flag11)
									{
										this.vars[varName] = result.ToString();
									}
									else
									{
										this.vars[varName] = "0";
										inputField.text = "0";
									}
								});
							}
							else
							{
								bool flag4 = parameterInfo.ParameterType == typeof(string);
								if (flag4)
								{
									inputFieldObj.GetComponent<TMP_InputField>().contentType = TMP_InputField.ContentType.Standard;
								}
								else
								{
									bool isEnum = parameterInfo.ParameterType.IsEnum;
									if (isEnum)
									{
										this.vars[varName] = "0";
										inputFieldObj.SetActive(false);
										GameObject toggleGroupObj = UnityEngine.Object.Instantiate<GameObject>(toggleGroupPrefab, toggleGroupPrefab.transform.parent);
										ToggleGroup toggleGroup = toggleGroupObj.GetComponent<ToggleGroup>();
										this.vars[varName] = Enum.GetValues(parameterInfo.ParameterType).GetValue(0).ToString();
										foreach (object obj3 in toggleGroup.transform)
										{
											Transform item = (Transform)obj3;
											bool flag5 = item.name == "Prefab";
											if (!flag5)
											{
												UnityEngine.Object.Destroy(item.gameObject);
											}
										}
										using (IEnumerator enumerator2 = Enum.GetValues(parameterInfo.ParameterType).GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												object value = enumerator2.Current;
												Transform obj = UnityEngine.Object.Instantiate<Transform>(toggleGroupObj.transform.Find("Prefab"), toggleGroup.transform);
												obj.name = (obj.Find("Val").GetComponent<TMP_Text>().text = value.ToString());
												obj.GetComponent<Toggle>().onValueChanged.AddListener(delegate(bool isOn)
												{
													if (isOn)
													{
														this.vars[varName] = value.ToString();
														this.UpdateAll();
													}
												});
												obj.gameObject.SetActive(true);
											}
										}
										toggleGroupObj.GetComponent<RectTransform>().sizeDelta = new Vector2(toggleGroupObj.GetComponent<RectTransform>().sizeDelta.x, (float)((toggleGroup.transform.childCount - 1) * 80));
										toggleGroupObj.SetActive(true);
									}
									else
									{
										bool flag6 = parameterInfo.ParameterType == typeof(BuffData);
										if (flag6)
										{
											bool flag7 = this.followEffectName == "";
											if (flag7)
											{
												Dictionary<string, string> data = UIManager.Instance.GetUI<CardEditorUI>("CardEditorUI").collection[0];
												inputFieldObj.name = "buffInput";
												inputFieldObj.GetComponent<TMP_InputField>().text = data.Localize("Name") + "<size=0>^^" + data["Id"] + "</size>";
												inputFieldObj.GetComponent<TMP_InputField>().interactable = false;
												this.followEffectName = data.Localize("Name") + "<size=0>^^" + data["Id"] + "</size>";
											}
											this.vars[varName] = this.followEffectName;
											this.UpdateAll();
										}
										else
										{
											bool flag8 = parameterInfo.ParameterType.IsSubclassOf(typeof(ScriptData));
											if (flag8)
											{
												this.vars[varName] = "";
												inputFieldObj.SetActive(false);
												GameObject toggleGroupObj2 = UnityEngine.Object.Instantiate<GameObject>(toggleGroupPrefab, toggleGroupPrefab.transform.parent);
												toggleGroupObj2.SetActive(true);
												ToggleGroup toggleGroup2 = toggleGroupObj2.GetComponent<ToggleGroup>();
												List<string> list = parameterInfo.ParameterType.GetMethod("GetValues").Invoke(new ScriptData(), null) as List<string>;
												this.vars[varName] = list[0];
												foreach (object obj4 in toggleGroup2.transform)
												{
													Transform item2 = (Transform)obj4;
													UnityEngine.Object.Destroy(item2.gameObject);
												}
												this.UpdateAll();
												using (List<string>.Enumerator enumerator4 = list.GetEnumerator())
												{
													while (enumerator4.MoveNext())
													{
														string value = enumerator4.Current;
														Transform obj2 = UnityEngine.Object.Instantiate<Transform>(toggleGroupObj2.transform.Find("Prefab"), toggleGroup2.transform);
														obj2.name = (obj2.Find("Val").GetComponent<TMP_Text>().text = value);
														obj2.GetComponent<Toggle>().onValueChanged.AddListener(delegate(bool isOn)
														{
															if (isOn)
															{
																this.vars[varName] = value;
																this.UpdateAll();
															}
														});
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			bool flag9 = tmp.EndsWith("，");
			if (flag9)
			{
				tmp = tmp.Substring(0, tmp.Length - 1) + "。";
			}
			bool flag10 = tmp.EndsWith(",");
			if (flag10)
			{
				tmp = tmp.Substring(0, tmp.Length - 1) + "。";
			}
			GameObject lastDes = UnityEngine.Object.Instantiate<GameObject>(desPrefab, desPrefab.transform.parent);
			lastDes.GetComponent<TextMeshProUGUI>().text = tmp;
			lastDes.SetActive(true);
			this.CalculateCost();
		}

		/// <summary>
		/// 从CardEditorBase中反射执行脚本
		/// </summary>
		/// <returns></returns>
		// Token: 0x0600159A RID: 5530 RVA: 0x000AD678 File Offset: 0x000AB878
		public void CreateTimeDes()
		{
			base.transform.Find("Delete").GetComponent<ButtonManager>().onClick.AddListener(delegate
			{
				UnityEngine.Object.Destroy(base.gameObject);
			});
			GameObject desPrefab = base.transform.Find("Content/texts/description/des").gameObject;
			GameObject toggleGroupPrefab = base.transform.Find("Content/texts/description/Toggle Group").gameObject;
			string tmp = this.effectDes;
			while (tmp.IndexOf("{") != -1)
			{
				int pos = tmp.IndexOf("{");
				int pos2 = tmp.IndexOf("}");
				string des = tmp.Substring(0, pos);
				string varName = tmp.Substring(pos + 1, pos2 - pos - 1);
				tmp = tmp.Substring(pos2 + 1);
				GameObject desObj = UnityEngine.Object.Instantiate<GameObject>(desPrefab, desPrefab.transform.parent);
				desObj.GetComponent<TextMeshProUGUI>().text = des;
				this.vars[varName] = "";
				desObj.SetActive(true);
				MethodInfo methodInfo = typeof(CardEditorBase).GetMethod(this.methodName);
				ParameterInfo parameterInfo = methodInfo.GetParameters()[0];
				bool flag = parameterInfo.Name != varName;
				if (!flag)
				{
					bool isEnum = parameterInfo.ParameterType.IsEnum;
					if (isEnum)
					{
						this.vars[varName] = "0";
						GameObject toggleGroupObj = UnityEngine.Object.Instantiate<GameObject>(toggleGroupPrefab, toggleGroupPrefab.transform.parent);
						ToggleGroup toggleGroup = toggleGroupObj.GetComponent<ToggleGroup>();
						this.vars[varName] = Enum.GetValues(parameterInfo.ParameterType).GetValue(0).ToString();
						foreach (object obj2 in toggleGroup.transform)
						{
							Transform item = (Transform)obj2;
							bool flag2 = item.name == "Prefab";
							if (!flag2)
							{
								UnityEngine.Object.Destroy(item.gameObject);
							}
						}
						Transform obj = UnityEngine.Object.Instantiate<Transform>(toggleGroupObj.transform.Find("Prefab"), toggleGroup.transform);
						obj.name = (obj.Find("Val").GetComponent<TMP_Text>().text = this.sourceName.Localize("Tips"));
						obj.GetComponent<Toggle>().onValueChanged.RemoveAllListeners();
						obj.gameObject.SetActive(true);
						toggleGroupObj.GetComponent<RectTransform>().sizeDelta = new Vector2(toggleGroupObj.GetComponent<RectTransform>().sizeDelta.x, (float)((toggleGroup.transform.childCount - 1) * 80));
						toggleGroupObj.SetActive(true);
					}
				}
			}
			bool flag3 = tmp.EndsWith("，");
			if (flag3)
			{
				string text = tmp;
				tmp = text.Substring(0, text.Length - 1) + "。";
			}
			bool flag4 = tmp.EndsWith(",");
			if (flag4)
			{
				string text = tmp;
				tmp = text.Substring(0, text.Length - 1) + "。";
			}
			GameObject lastDes = UnityEngine.Object.Instantiate<GameObject>(desPrefab, desPrefab.transform.parent);
			lastDes.GetComponent<TextMeshProUGUI>().text = tmp;
			lastDes.SetActive(true);
			this.CalculateCost();
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000AD9E4 File Offset: 0x000ABBE4
		public ValueTuple<string, int> RunMethod()
		{
			MethodInfo methodInfo = typeof(CardEditorBase).GetMethod(this.methodName);
			ParameterInfo[] parameterInfos = methodInfo.GetParameters();
			object[] parameters = new object[parameterInfos.Length];
			int i = 0;
			while (i < parameterInfos.Length)
			{
				bool flag = this.vars.ContainsKey(parameterInfos[i].Name);
				if (flag)
				{
					string value = this.vars[parameterInfos[i].Name];
					bool flag2 = value == "" || value == " ";
					if (!flag2)
					{
						bool flag3 = parameterInfos[i].ParameterType == typeof(int);
						if (flag3)
						{
							int result;
							parameters[i] = (int.TryParse(value, out result) ? result : 999999);
						}
						else
						{
							bool flag4 = parameterInfos[i].ParameterType == typeof(float);
							if (flag4)
							{
								float result2;
								parameters[i] = (float.TryParse(value, out result2) ? result2 : 999999f);
							}
							else
							{
								bool flag5 = parameterInfos[i].ParameterType == typeof(string);
								if (flag5)
								{
									parameters[i] = value;
								}
								else
								{
									bool isEnum = parameterInfos[i].ParameterType.IsEnum;
									if (!isEnum)
									{
										bool flag6 = parameterInfos[i].ParameterType == typeof(BuffData);
										ValueTuple<string, int> result3;
										if (flag6)
										{
											Type type = parameterInfos[i].ParameterType;
											BuffData instance = Activator.CreateInstance(type) as BuffData;
											bool flag7 = instance == null;
											if (!flag7)
											{
												value = this.followEffectName.Replace("<size=0>^^", "^^").Replace("</size>", "");
												instance.Id = value.Split("^^", StringSplitOptions.None)[1];
												instance.Name = value.Split("^^", StringSplitOptions.None)[0];
												parameters[i] = instance;
												goto IL_2CF;
											}
											Debug.LogError("无法创建实例");
											result3 = new ValueTuple<string, int>("", 0);
										}
										else
										{
											bool flag8 = parameterInfos[i].ParameterType.IsSubclassOf(typeof(ScriptData));
											if (!flag8)
											{
												parameters[i] = null;
												goto IL_2CF;
											}
											Debug.Log("value" + value);
											Type type2 = parameterInfos[i].ParameterType;
											ScriptData instance2 = Activator.CreateInstance(type2) as ScriptData;
											bool flag9 = instance2 == null;
											if (!flag9)
											{
												instance2.Id = value.Split("^^", StringSplitOptions.None)[1];
												instance2.Name = value.Split("^^", StringSplitOptions.None)[0];
												parameters[i] = instance2;
												goto IL_2CF;
											}
											Debug.LogError("无法创建实例");
											result3 = new ValueTuple<string, int>("", 0);
										}
										return result3;
									}
									parameters[i] = Enum.Parse(parameterInfos[i].ParameterType, value);
								}
							}
						}
						IL_2CF:;
					}
				}
				else
				{
					parameters[i] = parameterInfos[i].DefaultValue;
				}
				IL_2E0:
				i++;
				continue;
				goto IL_2E0;
			}
			return (ValueTuple<string, int>)methodInfo.Invoke(null, parameters);
		}

		/// <summary>
		/// 更新所有效果描述的状态
		/// </summary>
		// Token: 0x0600159C RID: 5532 RVA: 0x000ADCF8 File Offset: 0x000ABEF8
		public void UpdateAll()
		{
			this.cardEditorUI.cost = 0;
			CardEffectItem.negativeCosts = 0;
			CardEffectItem.desValCount = 0;
			CardEffectItem.cardEffectItems.Sort((CardEffectItem a, CardEffectItem b) => (a.transform.parent.parent.parent.parent.parent.name + a.transform.GetSiblingIndex().ToString()).CompareTo(b.transform.parent.parent.parent.parent.parent.name + b.transform.GetSiblingIndex().ToString()));
			for (int i = 0; i < CardEffectItem.cardEffectItems.Count; i++)
			{
				CardEffectItem.cardEffectItems[i].CalculateCost();
			}
			bool flag = this.cardEditorUI.transform.Find("MsgContent/descriptionContent/Title/Switch").GetComponent<SwitchManager>().isOn;
			bool flag2 = flag;
			if (!flag2)
			{
				TMP_InputField msg = this.cardEditorUI.transform.Find("MsgContent/descriptionContent/InputField").GetComponent<TMP_InputField>();
				msg.text = "";
				Dictionary<string, string> TimeTotag = new Dictionary<string, string>
				{
					{
						"UseScript",
						"使用后:"
					},
					{
						"DrawScript",
						"抽到后:"
					},
					{
						"DropScript",
						"弃置后:"
					}
				};
				int count = CardEffectItem.cardEffectItems.Count;
				for (int j = 0; j < count; j++)
				{
					CardEffectItem item = CardEffectItem.cardEffectItems[j];
					string parentName = item.sourceName;
					MethodInfo methodInfo = typeof(CardEditorBase).GetMethod(item.methodName);
					string description = methodInfo.GetCustomAttribute<EffectDes>().text;
					bool flag3 = methodInfo.GetCustomAttribute<EffectCardDes>() != null;
					if (flag3)
					{
						description = methodInfo.GetCustomAttribute<EffectCardDes>().text;
					}
					bool flag4 = description == "";
					if (!flag4)
					{
						foreach (KeyValuePair<string, string> var in item.vars)
						{
							bool flag5 = var.Key == "data";
							if (flag5)
							{
								description = description.Replace("{" + var.Key + "}", var.Value.Split("^^", StringSplitOptions.None)[0]);
							}
							else
							{
								description = description.Replace("{" + var.Key + "}", var.Value);
							}
						}
						description = description.Replace("{desValIndex}", item.desValIndex.ToString());
						bool flag6 = j != count - 1;
						if (flag6)
						{
							Dictionary<string, string> dictionary = TimeTotag;
							string key = parentName;
							dictionary[key] = dictionary[key] + description + ",";
						}
						else
						{
							Dictionary<string, string> dictionary = TimeTotag;
							string key = parentName;
							dictionary[key] = dictionary[key] + description + "。";
						}
					}
				}
				foreach (KeyValuePair<string, string> item2 in TimeTotag)
				{
					bool flag7 = item2.Value.Length > 4;
					if (flag7)
					{
						TMP_InputField tmp_InputField = msg;
						tmp_InputField.text = tmp_InputField.text + item2.Value + "\n";
					}
				}
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000AE054 File Offset: 0x000AC254
		public void ShowChangeBuff()
		{
			CardEffectBuff.NowItem = this;
			Transform bufflist = UIManager.Instance.GetUI<CardEditorUI>("CardEditorUI").transform.Find("EffectList/buffList");
			bool flag = !bufflist.gameObject.activeSelf;
			if (flag)
			{
				bufflist.position = base.transform.Find("Content/Icon").position + new Vector3(0f, 20f, 0f);
				bufflist.gameObject.SetActive(true);
			}
			else
			{
				bufflist.gameObject.SetActive(false);
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000AE0F0 File Offset: 0x000AC2F0
		public void HideBuffList()
		{
			bool flag = UIManager.Instance.GetUI<CardEditorUI>("CardEditorUI") == null;
			if (!flag)
			{
				Transform bufflist = UIManager.Instance.GetUI<CardEditorUI>("CardEditorUI").transform.Find("EffectList/buffList");
				bool flag2 = bufflist == null;
				if (!flag2)
				{
					bufflist.gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000AE154 File Offset: 0x000AC354
		public void ChangeBuff(string buffName)
		{
			this.effectName = buffName;
			this.methodName = "SetStatus";
			this.vars.Clear();
			this.vars["status"] = buffName;
			this.vars["filter"] = "自己";
			this.CalculateCost();
			this.CreateDescription();
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000AE1B8 File Offset: 0x000AC3B8
		private void OnDestroy()
		{
			this.isMarkedForDestruction = true;
			bool flag = this.methodName == "GetTime";
			if (flag)
			{
				CardEffectItem.cardEffectItems.Remove(this);
			}
			else
			{
				this.cardEditorUI.cost -= (int)((float)this.effectCost * this.costMultiplier);
				bool flag2 = this.effectCost < 0;
				if (flag2)
				{
					CardEffectItem.negativeCosts -= (int)((float)this.effectCost * this.costMultiplier);
				}
				bool flag3 = this.isBuff;
				if (flag3)
				{
					this.HideBuffList();
				}
				Dictionary<string, int> methodCount = this.cardEditorUI.MethodCount;
				string key = this.methodName;
				int num = methodCount[key];
				methodCount[key] = num - 1;
				this.effectCost = 0;
				CardEffectItem.cardEffectItems.Remove(this);
				this.UpdateAll();
			}
		}

		// Token: 0x04001119 RID: 4377
		public string effectName;

		// Token: 0x0400111A RID: 4378
		public string effectDes;

		// Token: 0x0400111B RID: 4379
		public bool isBuff;

		// Token: 0x0400111C RID: 4380
		public string followEffectName = "";

		// Token: 0x0400111D RID: 4381
		public string sourceName;

		// Token: 0x0400111E RID: 4382
		public string methodName;

		// Token: 0x0400111F RID: 4383
		public int effectCost;

		// Token: 0x04001120 RID: 4384
		public float costMultiplier = 1f;

		// Token: 0x04001121 RID: 4385
		public CardEditorUI cardEditorUI;

		// Token: 0x04001122 RID: 4386
		public Dictionary<string, string> vars = new Dictionary<string, string>();

		// Token: 0x04001123 RID: 4387
		public int desValIndex;

		// Token: 0x04001124 RID: 4388
		private static int negativeCosts = 0;

		// Token: 0x04001125 RID: 4389
		private static int desValCount;

		// Token: 0x04001126 RID: 4390
		private static List<CardEffectItem> cardEffectItems = new List<CardEffectItem>();

		// Token: 0x04001127 RID: 4391
		private string description;

		// Token: 0x04001128 RID: 4392
		public bool isMarkedForDestruction = false;
	}
}

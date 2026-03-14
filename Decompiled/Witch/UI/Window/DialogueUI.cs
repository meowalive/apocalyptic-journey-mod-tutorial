using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x020002C7 RID: 711
	public class DialogueUI : UIBase
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x000B2268 File Offset: 0x000B0468
		[DebuggerStepThrough]
		public void Awake()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DialogueUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueUI.Awake()).MethodHandle, typeof(DialogueUI).TypeHandle);
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
							this.$Rougamo_Awake();
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

		// Token: 0x0600160A RID: 5642 RVA: 0x000B2364 File Offset: 0x000B0564
		public void ShowDialogue(DataConfig dataConfig)
		{
			this.canChoice = true;
			this.dataConfig = dataConfig;
			base.transform.Find("Content/text").DOKill(false);
			bool flag = FightPlayer.Instance != null;
			if (flag)
			{
				dataConfig.scriptExecutor.Self = FightPlayer.Instance.Status;
			}
			else
			{
				dataConfig.scriptExecutor.Self = null;
			}
			IDictionary<string, string> data = dataConfig.data;
			bool flag2 = data["BaseScript"] != "";
			if (flag2)
			{
				dataConfig.scriptExecutor.RunScript("BaseScript");
			}
			base.transform.Find("Content/text").GetComponent<TextMeshProUGUI>().DOKill(false);
			base.transform.Find("Content/text").GetComponent<TextMeshProUGUI>().text = "";
			Dictionary<string, string> roleData = Singleton<GameConfigManager>.Instance.GetOne(DataType.RoleData, data["Roles"]);
			bool flag3 = roleData != null;
			if (flag3)
			{
				base.transform.Find("Content/rolemsg/name/text").GetComponent<TextMeshProUGUI>().SetLocalizedText(() => roleData.Localize("Name"));
			}
			else
			{
				base.transform.Find("Content/rolemsg/name/text").GetComponent<TextMeshProUGUI>().SetLocalizedText(() => "narrator".Localize("Tips"));
			}
			bool flag4 = data["Roles"] == "role_narrator" || base.transform.Find("Content/rolemsg/name/text").GetComponent<TextMeshProUGUI>().text == "";
			if (flag4)
			{
				base.transform.Find("Content/rolemsg/name").gameObject.SetActive(false);
			}
			else
			{
				base.transform.Find("Content/rolemsg/name").gameObject.SetActive(true);
			}
			string text = this.GetText(dataConfig);
			float time = (float)text.Length * (this.NormalSpeed ? 0.05f : 0.01f);
			Func<string> <>9__3;
			base.transform.Find("Content/text").GetComponent<TextMeshProUGUI>().DOText(text, time, true, ScrambleMode.None, null).OnKill(delegate
			{
				TMP_Text component = this.transform.Find("Content/text").GetComponent<TextMeshProUGUI>();
				Func<string> localized;
				if ((localized = <>9__3) == null)
				{
					localized = (<>9__3 = (() => this.GetText(dataConfig)));
				}
				component.SetLocalizedText(localized);
				this.ShowChoice();
			}).OnComplete(new TweenCallback(this.ShowChoice));
			bool HasSelf = false;
			foreach (GameObject item in this.roles)
			{
				bool flag5 = item.name == dataConfig.data["Roles"];
				if (flag5)
				{
					HasSelf = true;
					break;
				}
			}
			bool flag6 = !HasSelf;
			if (flag6)
			{
				bool flag7 = dataConfig.data["Roles"] != "" && roleData["CharacterImage"] != "";
				if (flag7)
				{
					GameObject role = UnityEngine.Object.Instantiate<GameObject>(this.rolePre, base.transform.Find("Content/RoleList"));
					role.name = dataConfig.data["Roles"];
					Sprite sprite = ResourceLoader.Load<Sprite>(roleData["CharacterImage"], true);
					role.gameObject.SetActive(true);
					role.GetComponent<Image>().sprite = sprite;
					role.GetComponent<RectTransform>().sizeDelta = new Vector2(sprite.rect.width, sprite.rect.height);
					this.roles.Add(role);
					bool flag8 = this.roles.Count > 2;
					if (flag8)
					{
						UnityEngine.Object.Destroy(this.roles[0]);
						this.roles.RemoveAt(0);
					}
				}
			}
			foreach (GameObject item2 in this.roles)
			{
				bool flag9 = item2.name == dataConfig.data["Roles"];
				if (flag9)
				{
					item2.GetComponent<Image>().color = Color.white;
				}
				else
				{
					item2.GetComponent<Image>().color = new Color(0.8f, 0.8f, 0.8f, 1f);
				}
			}
			int choiceCount = int.Parse(data["ChoiceCount"]);
			bool flag10 = choiceCount > 0;
			if (flag10)
			{
				this.hasChoice = true;
			}
			else
			{
				this.hasChoice = false;
			}
			this.history.Add(dataConfig);
			bool flag11 = data["Notification"] != "";
			if (flag11)
			{
				UIManager.Instance.ShowNotification("Tips".Localize("Tips"), data.Localize("Notification"), 2f);
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000B28D8 File Offset: 0x000B0AD8
		[DebuggerStepThrough]
		public void ShowChoice()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DialogueUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueUI.ShowChoice()).MethodHandle, typeof(DialogueUI).TypeHandle);
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
							this.$Rougamo_ShowChoice();
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

		// Token: 0x0600160C RID: 5644 RVA: 0x000B29D4 File Offset: 0x000B0BD4
		public string GetText(DataConfig thisData)
		{
			string text = thisData.data.Localize("Text");
			string pattern = "\\{(.*?)\\}";
			bool flag = text == null;
			if (flag)
			{
				Debug.LogError("Dialogue text is null for id: " + thisData.data["Id"]);
				foreach (KeyValuePair<string, string> item in thisData.data)
				{
					Debug.LogError(item.Key + ": " + item.Value);
				}
			}
			text = Regex.Replace(text, pattern, delegate(Match match)
			{
				string key = match.Groups[1].Value;
				bool flag2 = key.StartsWith("DesVal") || Regex.IsMatch(key, "^\\d+$");
				string result;
				if (flag2)
				{
					result = match.Value;
				}
				else
				{
					IDataConfig valueOrDefault = Singleton<GameConfigManager>.Instance.DataConfigCache.GetValueOrDefault(key, null);
					string value = (valueOrDefault != null) ? valueOrDefault.data.Localize("Name") : null;
					bool flag3 = value == null;
					if (flag3)
					{
						result = "[" + key + "]";
					}
					else
					{
						result = value;
					}
				}
				return result;
			});
			text = string.Format(text, (from x in thisData.Vars.AsValueEnumerable<KeyValuePair<string, string>>()
			where x.Key.Contains("DesVal")
			orderby x.Key
			select x.Value).ToArray<OrderBy<Where<FromEnumerable<KeyValuePair<string, string>>, KeyValuePair<string, string>>, KeyValuePair<string, string>, string>, KeyValuePair<string, string>, object>());
			return text;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x000B2B30 File Offset: 0x000B0D30
		[DebuggerStepThrough]
		public void EndDialogue()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DialogueUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueUI.EndDialogue()).MethodHandle, typeof(DialogueUI).TypeHandle);
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
							this.$Rougamo_EndDialogue();
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

		// Token: 0x0600160E RID: 5646 RVA: 0x000B2C2C File Offset: 0x000B0E2C
		public IEnumerator StartDia()
		{
			for (;;)
			{
				yield return new WaitForSeconds(this.waitTime);
				this.EndDialogue();
			}
			yield break;
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000B2C3B File Offset: 0x000B0E3B
		public IEnumerator Skip()
		{
			for (;;)
			{
				yield return new WaitForSeconds(0.01f);
				this.EndDialogue();
			}
			yield break;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000B2C4C File Offset: 0x000B0E4C
		public void ShowHistory()
		{
			GameObject myItem = base.transform.Find("History/Scroll View/Viewport/Content/MyItem").gameObject;
			GameObject OtherItem = base.transform.Find("History/Scroll View/Viewport/Content/OtherItem").gameObject;
			base.transform.Find("History").gameObject.SetActive(true);
			base.transform.Find("History").DOScale(Vector3.one, 0.5f);
			string lastName = "";
			bool isMy = true;
			Transform content = base.transform.Find("History/Scroll View/Viewport/Content");
			foreach (object obj2 in content)
			{
				Transform item2 = (Transform)obj2;
				bool flag = item2.name == "MyItem" || item2.name == "OtherItem";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item2.gameObject);
				}
			}
			using (List<DataConfig>.Enumerator enumerator2 = this.history.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					DataConfig item = enumerator2.Current;
					bool flag2 = lastName == "" || (lastName == item.data["Roles"] && isMy) || (lastName != item.data["Roles"] && !isMy);
					GameObject obj;
					if (flag2)
					{
						obj = Singleton<ObjectPool>.Instance.Get(myItem, content);
						isMy = true;
					}
					else
					{
						obj = Singleton<ObjectPool>.Instance.Get(OtherItem, content);
						isMy = false;
					}
					lastName = item.data["Roles"];
					Dictionary<string, string> roleData = Singleton<GameConfigManager>.Instance.GetOne(DataType.RoleData, item.data["Roles"]);
					string rolesKey = item.data["Roles"];
					obj.transform.Find("Texts/Name").GetComponent<TextMeshProUGUI>().SetLocalizedText(delegate()
					{
						Dictionary<string, string> roleData2 = roleData;
						string name = (roleData2 != null) ? roleData2.Localize("Name") : null;
						bool flag3 = !string.IsNullOrEmpty(name);
						string result;
						if (flag3)
						{
							result = name;
						}
						else
						{
							string roleId = rolesKey.StartsWith("role_") ? rolesKey.Substring(5) : rolesKey;
							result = (roleId ?? "narrator").Localize("Tips");
						}
						return result;
					});
					obj.transform.Find("Texts/Text").GetComponent<TextMeshProUGUI>().SetLocalizedText(() => this.GetText(item));
					Image component = obj.transform.Find("Avatar").GetComponent<Image>();
					Dictionary<string, string> roleData3 = roleData;
					component.sprite = ResourceLoader.Load<Sprite>(((roleData3 != null) ? roleData3["Avatar"] : null) ?? "Images/Dialogue/Avatar/空白", true);
					obj.SetActive(true);
				}
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000B2F64 File Offset: 0x000B1164
		[DebuggerStepThrough]
		private void Update()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DialogueUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueUI.Update()).MethodHandle, typeof(DialogueUI).TypeHandle);
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
							this.$Rougamo_Update();
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

		// Token: 0x06001612 RID: 5650 RVA: 0x000B3060 File Offset: 0x000B1260
		[DebuggerStepThrough]
		public override void OnDestroy()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DialogueUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueUI.OnDestroy()).MethodHandle, typeof(DialogueUI).TypeHandle);
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
							this.$Rougamo_OnDestroy();
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

		// Token: 0x06001619 RID: 5657 RVA: 0x000B32A4 File Offset: 0x000B14A4
		private void $Rougamo_Awake()
		{
			this.rolePre = base.transform.Find("Content/RoleList/Item1").gameObject;
			base.transform.Find("buttons/Play").GetComponent<SwitchButton>().onValueChanged.AddListener(delegate(bool state)
			{
				if (state)
				{
					base.StartCoroutine("StartDia");
				}
				else
				{
					base.StopCoroutine("StartDia");
				}
			});
			base.transform.Find("buttons/Skip").GetComponent<SwitchButton>().onValueChanged.AddListener(delegate(bool state)
			{
				if (state)
				{
					this.NormalSpeed = false;
					base.StartCoroutine("Skip");
				}
				else
				{
					this.NormalSpeed = true;
					base.StopCoroutine("Skip");
				}
			});
			base.transform.Find("HistoryButton").GetComponent<SwitchButton>().onValueChanged.AddListener(delegate(bool state)
			{
				if (state)
				{
					this.ShowHistory();
				}
				else
				{
					base.transform.Find("History").DOScale(Vector3.zero, 0.5f).OnComplete(delegate
					{
						base.transform.Find("History").gameObject.SetActive(false);
					});
				}
			});
			base.transform.Find("Content/trigger").GetComponent<Button>().onClick.AddListener(delegate
			{
				this.EndDialogue();
			});
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x000B3380 File Offset: 0x000B1580
		private void $Rougamo_ShowChoice()
		{
			bool flag = !this.canChoice;
			if (!flag)
			{
				this.canChoice = false;
				GameObject ItemPre = base.transform.Find("Options/ItemPre").gameObject;
				IDictionary<string, string> data = this.dataConfig.data;
				int choiceCount = int.Parse(data["ChoiceCount"]);
				for (int i = 0; i < choiceCount; i++)
				{
					int tempCount = i + 1;
					GameObject item = UnityEngine.Object.Instantiate<GameObject>(ItemPre, base.transform.Find("Options"));
					item.name = "Item_" + i.ToString();
					item.SetActive(true);
					int index = i;
					item.GetComponent<ButtonManager>().SetLocalizedText(() => data.Localize("ChoiceText" + (index + 1).ToString()));
					this.optionItems.Add(item);
					item.GetComponent<ButtonManager>().onClick.RemoveAllListeners();
					item.GetComponent<ButtonManager>().onClick.AddListener(delegate
					{
						item.GetComponent<ButtonManager>().onClick.RemoveAllListeners();
						this._ignoreTriggerUntil = Time.unscaledTime + 0.25f;
						this.dataConfig.scriptExecutor.RunScript("ChoiceScript" + tempCount.ToString());
						for (int j = this.optionItems.Count - 1; j >= 0; j--)
						{
							UnityEngine.Object.Destroy(this.optionItems[j]);
						}
						this.optionItems.Clear();
					});
				}
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000B34EC File Offset: 0x000B16EC
		private void $Rougamo_EndDialogue()
		{
			bool flag = Time.unscaledTime < this._ignoreTriggerUntil;
			if (!flag)
			{
				string text = this.GetText(this.dataConfig);
				bool flag2 = base.transform.Find("Content/text").GetComponent<TextMeshProUGUI>().text != text;
				if (flag2)
				{
					base.transform.Find("Content/text").GetComponent<TextMeshProUGUI>().DOKill(false);
				}
				else
				{
					bool flag3 = this.hasChoice;
					if (!flag3)
					{
						string endScript = this.dataConfig.data["EndScript"];
						bool flag4 = string.IsNullOrEmpty(endScript);
						if (flag4)
						{
							Singleton<DialogueManager>.Instance.NextDialogue();
						}
						else
						{
							bool flag5 = FightPlayer.Instance != null;
							if (flag5)
							{
								this.dataConfig.scriptExecutor.Self = FightPlayer.Instance.Status;
							}
							else
							{
								this.dataConfig.scriptExecutor.Self = null;
							}
							this.dataConfig.scriptExecutor.RunScript("EndScript");
						}
					}
				}
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000A21B3 File Offset: 0x000A03B3
		private void $Rougamo_Update()
		{
			base.transform.SetAsLastSibling();
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000B35FF File Offset: 0x000B17FF
		private void $Rougamo_OnDestroy()
		{
			base.OnDestroy();
			base.StopAllCoroutines();
		}

		// Token: 0x04001167 RID: 4455
		private List<DataConfig> history = new List<DataConfig>();

		// Token: 0x04001168 RID: 4456
		private DataConfig dataConfig;

		// Token: 0x04001169 RID: 4457
		private List<GameObject> roles = new List<GameObject>();

		// Token: 0x0400116A RID: 4458
		private GameObject rolePre;

		// Token: 0x0400116B RID: 4459
		private bool NormalSpeed = true;

		/// <summary>
		/// 显示对话
		/// </summary>
		/// <param name="id"></param>
		/// <returns>对话结束时的脚本</returns>
		// Token: 0x0400116C RID: 4460
		private bool canChoice = true;

		// Token: 0x0400116D RID: 4461
		private float _ignoreTriggerUntil;

		// Token: 0x0400116E RID: 4462
		private bool hasChoice = false;

		// Token: 0x0400116F RID: 4463
		private List<GameObject> optionItems = new List<GameObject>();

		// Token: 0x04001170 RID: 4464
		public float waitTime = 1f;
	}
}

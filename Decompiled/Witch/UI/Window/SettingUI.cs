using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Michsky.MUIP;
using Rougamo;
using Rougamo.Context;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Witch.UI.Window
{
	// Token: 0x02000364 RID: 868
	public class SettingUI : UIBase
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x000E9014 File Offset: 0x000E7214
		private SettingTable setting
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(SettingUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SettingUI.get_setting()).MethodHandle, typeof(SettingUI).TypeHandle);
				methodContext.Arguments = new object[0];
				SettingTable settingTable;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						settingTable = (SettingTable)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								settingTable = this.$Rougamo_get_setting();
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
								if (exceptionHandled)
								{
									settingTable = (SettingTable)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_108;
								}
								throw;
							}
							methodContext.ReturnValue = settingTable;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							settingTable = (SettingTable)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_108:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return settingTable;
			}
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000E9154 File Offset: 0x000E7354
		[DebuggerStepThrough]
		public override void Close()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SettingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SettingUI.Close()).MethodHandle, typeof(SettingUI).TypeHandle);
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
							this.$Rougamo_Close();
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

		// Token: 0x06001B4B RID: 6987 RVA: 0x000E9250 File Offset: 0x000E7450
		[DebuggerStepThrough]
		public override void DataUpdate()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SettingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SettingUI.DataUpdate()).MethodHandle, typeof(SettingUI).TypeHandle);
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
							this.$Rougamo_DataUpdate();
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

		// Token: 0x06001B4C RID: 6988 RVA: 0x000E934C File Offset: 0x000E754C
		[DebuggerStepThrough]
		public override void Hide()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SettingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SettingUI.Hide()).MethodHandle, typeof(SettingUI).TypeHandle);
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
							this.$Rougamo_Hide();
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

		// Token: 0x06001B4D RID: 6989 RVA: 0x000E9448 File Offset: 0x000E7648
		[DebuggerStepThrough]
		public override void OnEnable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SettingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SettingUI.OnEnable()).MethodHandle, typeof(SettingUI).TypeHandle);
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
							this.$Rougamo_OnEnable();
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000E9544 File Offset: 0x000E7744
		public bool Active
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(SettingUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SettingUI.get_Active()).MethodHandle, typeof(SettingUI).TypeHandle);
				methodContext.Arguments = new object[0];
				bool flag;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						flag = (bool)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								flag = this.$Rougamo_get_Active();
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
								if (exceptionHandled)
								{
									flag = (bool)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_10D;
								}
								throw;
							}
							methodContext.ReturnValue = flag;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							flag = (bool)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_10D:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return flag;
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x000E9688 File Offset: 0x000E7888
		private void Start()
		{
			this.Load();
			foreach (KeyValuePair<string, Transform> item in Singleton<TempDataManager>.Instance.SettingTransformMap)
			{
				bool flag = item.Value.Find("dropdown") != null;
				if (flag)
				{
					item.Value.Find("dropdown").GetComponent<CustomDropdown>().onValueChanged.AddListener(delegate(int value)
					{
						this.Apply();
					});
				}
				else
				{
					bool flag2 = item.Value.Find("slider") != null;
					if (flag2)
					{
						item.Value.Find("slider").GetComponent<Slider>().onValueChanged.AddListener(delegate(float value)
						{
							this.Apply();
						});
					}
					else
					{
						bool flag3 = item.Value.Find("toggle") != null;
						if (flag3)
						{
							item.Value.Find("toggle").GetComponent<Toggle>().onValueChanged.AddListener(delegate(bool value)
							{
								this.Apply();
							});
						}
						else
						{
							bool flag4 = item.Value.Find("selector") != null;
							if (flag4)
							{
								item.Value.Find("selector").GetComponent<HorizontalSelector>().onValueChanged.AddListener(delegate(int value)
								{
									this.Apply();
								});
							}
							else
							{
								bool flag5 = item.Value.Find("togglegroup") != null;
								if (flag5)
								{
									item.Value.Find("togglegroup").GetComponentsInChildren<Toggle>().ToList<Toggle>().ForEach(delegate(Toggle toggle)
									{
										toggle.onValueChanged.AddListener(delegate(bool value)
										{
											this.Apply();
										});
									});
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x000E9880 File Offset: 0x000E7A80
		private void Load()
		{
			foreach (KeyValuePair<string, Transform> item in Singleton<TempDataManager>.Instance.SettingTransformMap)
			{
				string value = this.setting.GetValue(item.Key);
				bool flag = value == null;
				if (!flag)
				{
					bool flag2 = item.Value.Find("dropdown") != null;
					if (flag2)
					{
						item.Value.Find("dropdown").GetComponent<CustomDropdown>().SetDropdownIndexByName(value);
					}
					else
					{
						bool flag3 = item.Value.Find("slider") != null;
						if (flag3)
						{
							item.Value.Find("slider").GetComponent<Slider>().value = float.Parse(value);
							item.Value.Find("slider").GetComponent<SliderManager>().valueText.text = value + ".0%";
						}
						else
						{
							bool flag4 = item.Value.Find("toggle") != null;
							if (flag4)
							{
								item.Value.Find("toggle").GetComponent<Toggle>().isOn = bool.Parse(value);
							}
							else
							{
								bool flag5 = item.Value.Find("selector") != null;
								if (flag5)
								{
									HorizontalSelector selector = item.Value.Find("selector").GetComponent<HorizontalSelector>();
									List<string> titles = (from x in selector.items
									select x.itemTitle).ToList<string>();
									int idx = titles.IndexOf(value);
									bool flag6 = idx < 0 || idx >= selector.items.Count;
									if (flag6)
									{
										idx = 0;
									}
									selector.index = idx;
									selector.UpdateUI();
								}
								else
								{
									bool flag7 = item.Value.Find("togglegroup") != null;
									if (flag7)
									{
										item.Value.Find("togglegroup").GetComponentsInChildren<Toggle>().ToList<Toggle>().ForEach(delegate(Toggle toggle)
										{
											toggle.isOn = (toggle.name == value);
										});
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x000E9B24 File Offset: 0x000E7D24
		[DebuggerStepThrough]
		public void CloseTheGame()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SettingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SettingUI.CloseTheGame()).MethodHandle, typeof(SettingUI).TypeHandle);
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
							this.$Rougamo_CloseTheGame();
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

		// Token: 0x06001B52 RID: 6994 RVA: 0x000E9C20 File Offset: 0x000E7E20
		public void Save()
		{
			foreach (KeyValuePair<string, Transform> item in Singleton<TempDataManager>.Instance.SettingTransformMap)
			{
				string value = "";
				bool flag = item.Value.Find("dropdown") != null;
				if (flag)
				{
					value = item.Value.Find("dropdown").GetComponent<CustomDropdown>().selectedText.text;
				}
				else
				{
					bool flag2 = item.Value.Find("slider") != null;
					if (flag2)
					{
						value = item.Value.Find("slider").GetComponent<Slider>().value.ToString();
					}
					else
					{
						bool flag3 = item.Value.Find("toggle") != null;
						if (flag3)
						{
							value = item.Value.Find("toggle").GetComponent<Toggle>().isOn.ToString();
						}
						else
						{
							bool flag4 = item.Value.Find("selector") != null;
							if (flag4)
							{
								value = item.Value.Find("selector").GetComponent<HorizontalSelector>().label.text;
							}
							else
							{
								bool flag5 = item.Value.Find("togglegroup") != null;
								if (flag5)
								{
									item.Value.Find("togglegroup").GetComponentsInChildren<Toggle>().ToList<Toggle>().ForEach(delegate(Toggle toggle)
									{
										bool isOn = toggle.isOn;
										if (isOn)
										{
											value = toggle.name;
										}
									});
								}
							}
						}
					}
				}
				bool flag6 = this.setting.GetValue(item.Key) == value;
				if (!flag6)
				{
					this.setting.SetValue(item.Key, value);
				}
			}
			Singleton<GameRuntimeData>.Instance.Save();
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x000E9E5C File Offset: 0x000E805C
		[DebuggerStepThrough]
		public void Apply()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(SettingUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(SettingUI.Apply()).MethodHandle, typeof(SettingUI).TypeHandle);
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
							this.$Rougamo_Apply();
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

		// Token: 0x06001B5D RID: 7005 RVA: 0x000EA005 File Offset: 0x000E8205
		private SettingTable $Rougamo_get_setting()
		{
			return Singleton<GameRuntimeData>.Instance.settingTable;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x000A1CD7 File Offset: 0x0009FED7
		private void $Rougamo_Close()
		{
			base.Close();
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x000EA011 File Offset: 0x000E8211
		private void $Rougamo_DataUpdate()
		{
			base.transform.Find("Windows/Button").GetComponent<ButtonManager>().SetText("closegame".Localize("SettingUI"));
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x000B6BBB File Offset: 0x000B4DBB
		private void $Rougamo_Hide()
		{
			base.Hide();
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x000EA040 File Offset: 0x000E8240
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			bool flag = UIManager.Instance.GetUI<ConsoleUI>("ConsoleUI") != null;
			if (flag)
			{
				UIManager.Instance.GetUI<ConsoleUI>("ConsoleUI").Hide();
			}
			this.DataUpdate();
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000EA08C File Offset: 0x000E828C
		private bool $Rougamo_get_Active()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000EA09C File Offset: 0x000E829C
		private void $Rougamo_CloseTheGame()
		{
			UIManager.Instance.ShowModalWindow("prompt", "Quit the game？", delegate
			{
				EditorApplication.isPlaying = false;
			}, 0f, null, true, true, "Yes", "No", true);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000EA0F1 File Offset: 0x000E82F1
		private void $Rougamo_Apply()
		{
			UniTask.DelayFrame(1, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
			{
				this.Save();
				this.setting.Apply();
				UniTask.DelayFrame(1, PlayerLoopTiming.Update, base.destroyCancellationToken, false).ContinueWith(delegate()
				{
					LayoutGroup[] layouts = base.transform.GetComponentsInChildren<LayoutGroup>();
					foreach (LayoutGroup layout in layouts)
					{
						layout.CalculateLayoutInputHorizontal();
						layout.CalculateLayoutInputVertical();
						layout.SetLayoutHorizontal();
						layout.SetLayoutVertical();
					}
				}).Forget();
			}).Forget();
		}
	}
}

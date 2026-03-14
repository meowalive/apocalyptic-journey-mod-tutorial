using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using Witch.UI;

// Token: 0x02000040 RID: 64
public class SettingTable
{
	// Token: 0x060001B7 RID: 439 RVA: 0x0000F98C File Offset: 0x0000DB8C
	public SettingTable()
	{
		this.dic = new Dictionary<string, string>
		{
			{
				"分辨率",
				"1920*1080"
			},
			{
				"窗口设置",
				"窗口"
			},
			{
				"画面质量",
				"普通"
			},
			{
				"全局音量",
				"100"
			},
			{
				"音乐音量",
				"100"
			},
			{
				"效果音量",
				"100"
			},
			{
				"语言",
				"简体中文"
			},
			{
				"镜头移动动画",
				"开启"
			},
			{
				"字体",
				"SourceHanSerif"
			},
			{
				"显示伤害数字",
				"开启"
			}
		};
		Dictionary<string, Action<string>> dictionary = new Dictionary<string, Action<string>>();
		dictionary.Add("分辨率", delegate(string value)
		{
			SettingTable.<>c.<<-ctor>b__2_0>d <<-ctor>b__2_0>d = new SettingTable.<>c.<<-ctor>b__2_0>d();
			<<-ctor>b__2_0>d.<>t__builder = AsyncVoidMethodBuilder.Create();
			<<-ctor>b__2_0>d.<>4__this = SettingTable.<>c.<>9;
			<<-ctor>b__2_0>d.value = value;
			<<-ctor>b__2_0>d.<>1__state = -1;
			<<-ctor>b__2_0>d.<>t__builder.Start<SettingTable.<>c.<<-ctor>b__2_0>d>(ref <<-ctor>b__2_0>d);
		});
		dictionary.Add("窗口设置", delegate(string value)
		{
		});
		dictionary.Add("画面质量", delegate(string value)
		{
		});
		dictionary.Add("全局音量", delegate(string value)
		{
		});
		dictionary.Add("音乐音量", delegate(string value)
		{
		});
		dictionary.Add("效果音量", delegate(string value)
		{
		});
		dictionary.Add("语言", delegate(string value)
		{
			this.ChangeLanguage(value);
		});
		dictionary.Add("镜头移动动画", delegate(string value)
		{
		});
		dictionary.Add("字体", delegate(string value)
		{
			UIManager.Instance.ShowModalWindow("prompt", "Restart to apply font settings?".Localize("SettingUI"), delegate
			{
				EditorApplication.isPlaying = false;
			}, 0f, null, true, true, "Yes", "No", true);
		});
		this.onValueChanged = dictionary;
	}

	/// <summary>
	/// 设定键值对
	/// </summary>
	/// <param name="key"></param>
	/// <param name="value"></param>
	// Token: 0x060001B8 RID: 440 RVA: 0x0000FBDC File Offset: 0x0000DDDC
	public void SetValue(string key, string value)
	{
		this.dic[key] = value;
		bool flag = this.onValueChanged.ContainsKey(key);
		if (flag)
		{
			Action<string> action = this.onValueChanged[key];
			if (action != null)
			{
				action(value);
			}
		}
	}

	/// <summary>
	/// 获取值
	/// </summary>
	/// <param name="key"></param>
	/// <returns></returns>
	// Token: 0x060001B9 RID: 441 RVA: 0x0000FC24 File Offset: 0x0000DE24
	public string GetValue(string key)
	{
		bool flag = this.dic.ContainsKey(key);
		string result;
		if (flag)
		{
			result = this.dic[key];
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0000FC58 File Offset: 0x0000DE58
	public void Apply()
	{
		string resolution = this.GetValue("分辨率");
		string ScreenType = this.GetValue("窗口设置");
		bool flag = ScreenType == "窗口";
		if (flag)
		{
			Screen.SetResolution(int.Parse(resolution.Split('*', StringSplitOptions.None)[0]), int.Parse(resolution.Split('*', StringSplitOptions.None)[1]), FullScreenMode.Windowed);
		}
		else
		{
			bool flag2 = ScreenType == "全屏窗口";
			if (flag2)
			{
				Resolution nativeRes = Screen.currentResolution;
				Screen.SetResolution(nativeRes.width, nativeRes.height, FullScreenMode.FullScreenWindow);
			}
		}
		string quality = this.GetValue("画面质量");
		bool flag3 = quality != null;
		if (flag3)
		{
			bool flag4 = quality == "流畅";
			if (flag4)
			{
				QualitySettings.SetQualityLevel(0);
			}
			else
			{
				bool flag5 = quality == "普通";
				if (flag5)
				{
					QualitySettings.SetQualityLevel(2);
				}
				else
				{
					bool flag6 = quality == "较高";
					if (flag6)
					{
						QualitySettings.SetQualityLevel(4);
					}
				}
			}
		}
		string volume = this.GetValue("全局音量");
		string bgm = this.GetValue("音乐音量");
		string effect = this.GetValue("效果音量");
		AudioListener.volume = float.Parse(volume) / 100f;
		AudioManager instance = AudioManager.Instance;
		if (instance != null)
		{
			instance.ChangeBgmVolume(float.Parse(bgm) / 100f);
		}
		AudioManager instance2 = AudioManager.Instance;
		if (instance2 != null)
		{
			instance2.ChangeEffectVolume(float.Parse(effect) / 100f);
		}
		this.ChangeLanguage(this.GetValue("语言"));
	}

	// Token: 0x060001BB RID: 443 RVA: 0x0000FDDC File Offset: 0x0000DFDC
	public void ChangeLanguage(string language)
	{
		bool flag = language != null;
		if (flag)
		{
			bool flag2 = this.LastLanguage == language;
			if (!flag2)
			{
				this.LastLanguage = language;
				bool flag3 = language == "简体中文";
				if (flag3)
				{
					int index = LocalizationSettings.AvailableLocales.Locales.FindIndex((Locale locale) => locale.LocaleName == "Chinese (Simplified) (zh-CN)");
					LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
					Globals.Language = LocalizationSettings.AvailableLocales.Locales[index].Identifier.Code;
				}
				else
				{
					bool flag4 = language == "English";
					if (flag4)
					{
						int index = LocalizationSettings.AvailableLocales.Locales.FindIndex((Locale locale) => locale.LocaleName == "English (en)");
						LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
						Globals.Language = LocalizationSettings.AvailableLocales.Locales[index].Identifier.Code;
					}
					else
					{
						bool flag5 = language == "繁体中文";
						if (flag5)
						{
							int index = LocalizationSettings.AvailableLocales.Locales.FindIndex((Locale locale) => locale.LocaleName == "Chinese (Traditional) (zh-Hant)");
							LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
							Globals.Language = LocalizationSettings.AvailableLocales.Locales[index].Identifier.Code;
						}
						else
						{
							bool flag6 = language == "Japanese";
							if (flag6)
							{
								int index = LocalizationSettings.AvailableLocales.Locales.FindIndex((Locale locale) => locale.LocaleName == "Japanese (ja)");
								LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
								Globals.Language = LocalizationSettings.AvailableLocales.Locales[index].Identifier.Code;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04000100 RID: 256
	[JsonProperty]
	public readonly Dictionary<string, string> dic;

	// Token: 0x04000101 RID: 257
	[JsonIgnore]
	public readonly Dictionary<string, Action<string>> onValueChanged;

	// Token: 0x04000102 RID: 258
	private string LastLanguage = "";
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using ZLinq;

// Token: 0x0200006D RID: 109
public class TempDataManager : Singleton<TempDataManager>
{
	// Token: 0x0600038C RID: 908 RVA: 0x0001D8EC File Offset: 0x0001BAEC
	public TempDataManager()
	{
		List<Locale> langs = LocalizationSettings.AvailableLocales.Locales;
		foreach (Locale lang in langs)
		{
			this.keyWordsDic.Add(lang.Identifier.Code, new Dictionary<string, string>());
		}
		this.keyWordsDic.Add("Default", new Dictionary<string, string>());
		foreach (Dictionary<string, string> item in Singleton<GameConfigManager>.Instance.GetTable(DataType.KeyWords).Getlines())
		{
			bool flag = !item.ContainsKey("Keywords");
			if (flag)
			{
				Debug.LogError("KeyWords表缺少Keywords列" + item["Id"]);
			}
			else
			{
				this.keyWordsDic["Default"].TryAdd(item["Keywords"], item["Description"]);
				this.keyWordIds.TryAdd(item["Keywords"], item["Id"]);
				for (int i = 0; i < langs.Count; i++)
				{
					string key = langs[i].Identifier.Code;
					bool flag2 = !item.ContainsKey("Keywords_" + key) || item["Keywords_" + key] == "";
					if (!flag2)
					{
						this.keyWordsDic[key].TryAdd(item["Keywords_" + key], item["Description_" + key]);
						this.keyWordIds.TryAdd(item["Keywords_" + key], item["Id"]);
					}
				}
			}
		}
		Singleton<EventCenter>.Instance.AddEventListener("LanguageChange", delegate()
		{
			Singleton<TextTranslator>.Instance.Init((from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.KeyWords).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			select x.ContainsKey("Keywords_" + Globals.Language) ? x["Keywords_" + Globals.Language] : x["Keywords"]).ToList<Dictionary<string, string>, string>());
		}, this, EventDispose.None);
		this.rareColorMap.Add("一阶", Color.grey);
		this.rareColorMap.Add("二阶", new Color(0.5f, 0.8f, 1f));
		this.rareColorMap.Add("三阶", new Color(1f, 0.8f, 0f));
		this.rareColorMap.Add("四阶", new Color(1f, 0.8f, 0f));
		this.rareColorMap.Add("五阶", new Color(1f, 0.8f, 0f));
		foreach (KeyValuePair<string, string> item2 in this.RarityMap)
		{
			this.rareColorMap1.TryAdd(item2.Value, "#" + ColorUtility.ToHtmlStringRGB(this.rareColorMap[item2.Value]));
			this.rareColorMap1.TryAdd(item2.Key, "#" + ColorUtility.ToHtmlStringRGB(this.rareColorMap[item2.Value]));
			this.rareColorMap.TryAdd(item2.Key, this.rareColorMap[item2.Value]);
		}
	}

	// Token: 0x0600038D RID: 909 RVA: 0x0001DDD0 File Offset: 0x0001BFD0
	[DebuggerStepThrough]
	public void Random(int seed)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(TempDataManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TempDataManager.Random(int)).MethodHandle, typeof(TempDataManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			seed
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
						seed = 0;
					}
					else
					{
						seed = (int)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_Random(seed);
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
							goto IL_105;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_105:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x0600038E RID: 910 RVA: 0x0001DF0C File Offset: 0x0001C10C
	[DebuggerStepThrough]
	private void ShuffleArray(float[] array)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(TempDataManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TempDataManager.ShuffleArray(float[])).MethodHandle, typeof(TempDataManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			array
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
						array = null;
					}
					else
					{
						array = (float[])arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_ShuffleArray(array);
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

	// Token: 0x0600038F RID: 911 RVA: 0x0001E040 File Offset: 0x0001C240
	[DebuggerStepThrough]
	private int EnhanceSeed(int originalSeed)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(TempDataManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(TempDataManager.EnhanceSeed(int)).MethodHandle, typeof(TempDataManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			originalSeed
		};
		int num;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				num = (int)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						originalSeed = 0;
					}
					else
					{
						originalSeed = (int)arguments[0];
					}
				}
				do
				{
					try
					{
						num = this.$Rougamo_EnhanceSeed(originalSeed);
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
							num = (int)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_148;
						}
						throw;
					}
					methodContext.ReturnValue = num;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					num = (int)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_148:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return num;
	}

	// Token: 0x06000390 RID: 912 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
	private void $Rougamo_Random(int seed)
	{
		int enhancedSeed = this.EnhanceSeed(seed);
		TempDataManager.secureRandom = new System.Random(enhancedSeed);
		UnityEngine.Random.InitState(seed);
		TempDataManager.seeds = new float[1000000];
		for (int i = 0; i < TempDataManager.seeds.Length; i++)
		{
			TempDataManager.seeds[i] = (float)TempDataManager.secureRandom.NextDouble();
		}
		this.ShuffleArray(TempDataManager.seeds);
	}

	// Token: 0x06000391 RID: 913 RVA: 0x0001E230 File Offset: 0x0001C430
	private void $Rougamo_ShuffleArray(float[] array)
	{
		for (int i = array.Length - 1; i > 0; i--)
		{
			int j = TempDataManager.secureRandom.Next(0, i + 1);
			ref float ptr = ref array[i];
			int num = j;
			float num2 = array[j];
			float num3 = array[i];
			ptr = num2;
			array[num] = num3;
		}
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0001E284 File Offset: 0x0001C484
	private int $Rougamo_EnhanceSeed(int originalSeed)
	{
		uint hash = (uint)(originalSeed ^ (int)((uint)originalSeed >> 16));
		hash *= 2246822507U;
		hash ^= hash >> 13;
		hash *= 3266489909U;
		return (int)(hash ^ hash >> 16);
	}

	// Token: 0x0400095F RID: 2399
	public Dictionary<string, Transform> SettingTransformMap = new Dictionary<string, Transform>();

	// Token: 0x04000960 RID: 2400
	public Dictionary<string, string> rareColorMap1 = new Dictionary<string, string>();

	// Token: 0x04000961 RID: 2401
	public bool GameOver;

	// Token: 0x04000962 RID: 2402
	public Dictionary<string, List<string>> RoleStatusMap = new Dictionary<string, List<string>>();

	// Token: 0x04000963 RID: 2403
	public static float[] seeds;

	// Token: 0x04000964 RID: 2404
	public Dictionary<string, string> RarityMap = new Dictionary<string, string>
	{
		{
			"1",
			"一阶"
		},
		{
			"2",
			"二阶"
		},
		{
			"3",
			"三阶"
		},
		{
			"4",
			"四阶"
		},
		{
			"5",
			"五阶"
		}
	};

	// Token: 0x04000965 RID: 2405
	public Dictionary<string, Dictionary<string, string>> keyWordsDic = new Dictionary<string, Dictionary<string, string>>();

	// Token: 0x04000966 RID: 2406
	public Dictionary<string, string> keyWordIds = new Dictionary<string, string>();

	// Token: 0x04000967 RID: 2407
	public Dictionary<string, Color> rareColorMap = new Dictionary<string, Color>();

	// Token: 0x04000968 RID: 2408
	public Dictionary<string, Vector2> UIWorldPosMap = new Dictionary<string, Vector2>
	{
		{
			"Backpack",
			new Vector2(7f, 4.7f)
		}
	};

	// Token: 0x04000969 RID: 2409
	private static System.Random secureRandom;
}

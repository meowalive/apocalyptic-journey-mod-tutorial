using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;
using XLua;

// Token: 0x02000117 RID: 279
public static class ExampleGenConfig
{
	// Token: 0x060008D8 RID: 2264 RVA: 0x000468D0 File Offset: 0x00044AD0
	private static bool IsBlacklistedGenericType(Type type)
	{
		bool flag = !type.IsGenericType;
		return !flag && ExampleGenConfig.BlackGenericTypeList.Contains(type.GetGenericTypeDefinition());
	}

	// Token: 0x04000C14 RID: 3092
	[LuaCallCSharp(GenFlag.No)]
	public static List<Type> LuaCallCSharp = new List<Type>
	{
		typeof(object),
		typeof(UnityEngine.Object),
		typeof(Vector2),
		typeof(Vector3),
		typeof(Vector4),
		typeof(Quaternion),
		typeof(Color),
		typeof(GameObject),
		typeof(StringValue),
		typeof(Component),
		typeof(Behaviour),
		typeof(Transform),
		typeof(MonoBehaviour),
		typeof(Mathf),
		typeof(List<int>),
		typeof(Action<string>),
		typeof(Action<int>),
		typeof(Dictionary<string, string>),
		typeof(Debug)
	};

	// Token: 0x04000C15 RID: 3093
	[CSharpCallLua]
	public static List<Type> CSharpCallLua = new List<Type>
	{
		typeof(Action),
		typeof(Func<double, double, double>),
		typeof(Action<string>),
		typeof(Action<double>),
		typeof(UnityAction),
		typeof(IEnumerator)
	};

	// Token: 0x04000C16 RID: 3094
	[BlackList]
	public static List<List<string>> BlackList = new List<List<string>>
	{
		new List<string>
		{
			"System.Xml.XmlNodeList",
			"ItemOf"
		},
		new List<string>
		{
			"UnityEngine.WWW",
			"movie"
		},
		new List<string>
		{
			"UnityEngine.Texture2D",
			"alphaIsTransparency"
		},
		new List<string>
		{
			"UnityEngine.Security",
			"GetChainOfTrustValue"
		},
		new List<string>
		{
			"UnityEngine.CanvasRenderer",
			"onRequestRebuild"
		},
		new List<string>
		{
			"UnityEngine.Light",
			"areaSize"
		},
		new List<string>
		{
			"UnityEngine.Light",
			"lightmapBakeType"
		},
		new List<string>
		{
			"UnityEngine.Light",
			"SetLightDirty"
		},
		new List<string>
		{
			"UnityEngine.Light",
			"shadowRadius"
		},
		new List<string>
		{
			"UnityEngine.Light",
			"shadowAngle"
		},
		new List<string>
		{
			"UnityEngine.WWW",
			"MovieTexture"
		},
		new List<string>
		{
			"UnityEngine.WWW",
			"GetMovieTexture"
		},
		new List<string>
		{
			"UnityEngine.AnimatorOverrideController",
			"PerformOverrideClipListCleanup"
		},
		new List<string>
		{
			"UnityEngine.Application",
			"ExternalEval"
		},
		new List<string>
		{
			"UnityEngine.GameObject",
			"networkView"
		},
		new List<string>
		{
			"UnityEngine.Component",
			"networkView"
		},
		new List<string>
		{
			"System.IO.FileInfo",
			"GetAccessControl",
			"System.Security.AccessControl.AccessControlSections"
		},
		new List<string>
		{
			"System.IO.FileInfo",
			"SetAccessControl",
			"System.Security.AccessControl.FileSecurity"
		},
		new List<string>
		{
			"System.IO.DirectoryInfo",
			"GetAccessControl",
			"System.Security.AccessControl.AccessControlSections"
		},
		new List<string>
		{
			"System.IO.DirectoryInfo",
			"SetAccessControl",
			"System.Security.AccessControl.DirectorySecurity"
		},
		new List<string>
		{
			"System.IO.DirectoryInfo",
			"CreateSubdirectory",
			"System.String",
			"System.Security.AccessControl.DirectorySecurity"
		},
		new List<string>
		{
			"System.IO.DirectoryInfo",
			"Create",
			"System.Security.AccessControl.DirectorySecurity"
		},
		new List<string>
		{
			"UnityEngine.MonoBehaviour",
			"runInEditMode"
		}
	};

	// Token: 0x04000C17 RID: 3095
	public static List<Type> BlackGenericTypeList = new List<Type>
	{
		typeof(Span<>),
		typeof(ReadOnlySpan<>)
	};

	// Token: 0x04000C18 RID: 3096
	[BlackList]
	public static Func<MemberInfo, bool> GenericTypeFilter = delegate(MemberInfo memberInfo)
	{
		PropertyInfo propertyInfo = memberInfo as PropertyInfo;
		bool result;
		if (propertyInfo == null)
		{
			ConstructorInfo constructorInfo = memberInfo as ConstructorInfo;
			if (constructorInfo == null)
			{
				MethodInfo methodInfo = memberInfo as MethodInfo;
				if (methodInfo == null)
				{
					result = false;
				}
				else
				{
					result = methodInfo.GetParameters().Any((ParameterInfo p) => ExampleGenConfig.IsBlacklistedGenericType(p.ParameterType));
				}
			}
			else
			{
				result = constructorInfo.GetParameters().Any((ParameterInfo p) => ExampleGenConfig.IsBlacklistedGenericType(p.ParameterType));
			}
		}
		else
		{
			result = ExampleGenConfig.IsBlacklistedGenericType(propertyInfo.PropertyType);
		}
		return result;
	};
}

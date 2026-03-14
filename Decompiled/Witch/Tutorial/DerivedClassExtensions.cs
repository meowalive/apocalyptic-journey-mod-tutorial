using System;
using UnityEngine;
using XLua;

namespace Tutorial
{
	// Token: 0x0200012E RID: 302
	[LuaCallCSharp(GenFlag.No)]
	public static class DerivedClassExtensions
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x00047A04 File Offset: 0x00045C04
		public static int GetSomeData(this DerivedClass obj)
		{
			Debug.Log("GetSomeData ret = " + obj.DMF.ToString());
			return obj.DMF;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00047A3C File Offset: 0x00045C3C
		public static int GetSomeBaseData(this BaseClass obj)
		{
			Debug.Log("GetSomeBaseData ret = " + obj.BMF.ToString());
			return obj.BMF;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00047A72 File Offset: 0x00045C72
		public static void GenericMethodOfString(this DerivedClass obj)
		{
			obj.GenericMethod<string>();
		}
	}
}

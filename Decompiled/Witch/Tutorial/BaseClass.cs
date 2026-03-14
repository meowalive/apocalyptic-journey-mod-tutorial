using System;
using UnityEngine;
using XLua;

namespace Tutorial
{
	// Token: 0x02000126 RID: 294
	[LuaCallCSharp(GenFlag.No)]
	public class BaseClass
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x0004764C File Offset: 0x0004584C
		public static void BSFunc()
		{
			Debug.Log("Derived Static Func, BSF = " + BaseClass.BSF.ToString());
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0004766C File Offset: 0x0004586C
		public void BMFunc()
		{
			Debug.Log("Derived Member Func, BMF = " + this.BMF.ToString());
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00047698 File Offset: 0x00045898
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x000476A0 File Offset: 0x000458A0
		public int BMF { get; set; }

		// Token: 0x04000C2C RID: 3116
		public static int BSF = 1;
	}
}

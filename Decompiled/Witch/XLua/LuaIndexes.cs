using System;

namespace XLua
{
	// Token: 0x0200017C RID: 380
	internal sealed class LuaIndexes
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0005A920 File Offset: 0x00058B20
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0005A939 File Offset: 0x00058B39
		public static int LUA_REGISTRYINDEX
		{
			get
			{
				return InternalGlobals.LUA_REGISTRYINDEX;
			}
			set
			{
				InternalGlobals.LUA_REGISTRYINDEX = value;
			}
		}
	}
}

using System;
using XLua;

namespace Tutorial
{
	// Token: 0x0200012D RID: 301
	[LuaCallCSharp(GenFlag.No)]
	public interface ICalc
	{
		// Token: 0x06000924 RID: 2340
		int add(int a, int b);
	}
}

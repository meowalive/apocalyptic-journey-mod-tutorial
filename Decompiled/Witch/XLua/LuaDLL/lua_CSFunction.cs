using System;
using System.Runtime.InteropServices;

namespace XLua.LuaDLL
{
	// Token: 0x020001A0 RID: 416
	// (Invoke) Token: 0x06000BED RID: 3053
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_CSFunction(IntPtr L);
}

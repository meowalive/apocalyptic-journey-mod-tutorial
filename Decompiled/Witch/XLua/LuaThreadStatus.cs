using System;

namespace XLua
{
	// Token: 0x0200017B RID: 379
	public enum LuaThreadStatus
	{
		// Token: 0x04000D99 RID: 3481
		LUA_RESUME_ERROR = -1,
		// Token: 0x04000D9A RID: 3482
		LUA_OK,
		// Token: 0x04000D9B RID: 3483
		LUA_YIELD,
		// Token: 0x04000D9C RID: 3484
		LUA_ERRRUN,
		// Token: 0x04000D9D RID: 3485
		LUA_ERRSYNTAX,
		// Token: 0x04000D9E RID: 3486
		LUA_ERRMEM,
		// Token: 0x04000D9F RID: 3487
		LUA_ERRERR
	}
}

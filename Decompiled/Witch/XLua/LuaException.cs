using System;

namespace XLua
{
	// Token: 0x0200015F RID: 351
	[Serializable]
	public class LuaException : Exception
	{
		// Token: 0x06000AC1 RID: 2753 RVA: 0x0000D97C File Offset: 0x0000BB7C
		public LuaException(string message) : base(message)
		{
		}
	}
}

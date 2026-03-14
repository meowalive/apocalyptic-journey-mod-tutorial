using System;
using System.Collections.Generic;
using System.Reflection;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000165 RID: 357
	public class MethodWrap
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x00057EB8 File Offset: 0x000560B8
		public MethodWrap(string methodName, List<OverloadMethodWrap> overloads, bool forceCheck)
		{
			this.methodName = methodName;
			this.overloads = overloads;
			this.forceCheck = forceCheck;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00057EE4 File Offset: 0x000560E4
		public int Call(IntPtr L)
		{
			int result;
			try
			{
				bool flag = this.overloads.Count == 1 && !this.overloads[0].HasDefalutValue && !this.forceCheck;
				if (flag)
				{
					result = this.overloads[0].Call(L);
				}
				else
				{
					for (int i = 0; i < this.overloads.Count; i++)
					{
						OverloadMethodWrap overload = this.overloads[i];
						bool flag2 = overload.Check(L);
						if (flag2)
						{
							return overload.Call(L);
						}
					}
					result = Lua.luaL_error(L, "invalid arguments to " + this.methodName);
				}
			}
			catch (TargetInvocationException e)
			{
				result = Lua.luaL_error(L, "c# exception:" + e.InnerException.Message + ",stack:" + e.InnerException.StackTrace);
			}
			catch (Exception e2)
			{
				result = Lua.luaL_error(L, "c# exception:" + e2.Message + ",stack:" + e2.StackTrace);
			}
			return result;
		}

		// Token: 0x04000D52 RID: 3410
		private string methodName;

		// Token: 0x04000D53 RID: 3411
		private List<OverloadMethodWrap> overloads = new List<OverloadMethodWrap>();

		// Token: 0x04000D54 RID: 3412
		private bool forceCheck;
	}
}

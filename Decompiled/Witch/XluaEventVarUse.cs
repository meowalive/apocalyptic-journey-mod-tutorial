using System;
using System.Collections.Generic;
using XLua;

// Token: 0x02000116 RID: 278
public static class XluaEventVarUse
{
	// Token: 0x04000C13 RID: 3091
	[CSharpCallLua]
	public static readonly List<Type> XLua_CSharpCallLua_Delegates = new List<Type>
	{
		typeof(Action<ActionData>),
		typeof(Action<HurtData>),
		typeof(Action<DamageData>),
		typeof(Action<NewEnemyData>),
		typeof(Action<ScriptExecuteData>)
	};
}

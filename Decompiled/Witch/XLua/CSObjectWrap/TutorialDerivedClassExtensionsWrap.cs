using System;
using Tutorial;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001AE RID: 430
	public class TutorialDerivedClassExtensionsWrap
	{
		// Token: 0x06000DD3 RID: 3539 RVA: 0x0006C0E0 File Offset: 0x0006A2E0
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(DerivedClassExtensions);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0, -1);
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(TutorialDerivedClassExtensionsWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0006C144 File Offset: 0x0006A344
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return Lua.luaL_error(L, "Tutorial.DerivedClassExtensions does not have a constructor!");
		}
	}
}

using System;
using System.Collections.Generic;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001A4 RID: 420
	public class ModConfigWrap
	{
		// Token: 0x06000C7F RID: 3199 RVA: 0x0005EEB0 File Offset: 0x0005D0B0
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(ModConfig);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 9, 8, -1);
			Utils.RegisterFunc(L, -3, "SetDataConfig", new lua_CSFunction(ModConfigWrap._m_SetDataConfig));
			Utils.RegisterFunc(L, -3, "ModifyDataConfig", new lua_CSFunction(ModConfigWrap._m_ModifyDataConfig));
			Utils.RegisterFunc(L, -3, "RedirectSourcePath", new lua_CSFunction(ModConfigWrap._m_RedirectSourcePath));
			Utils.RegisterFunc(L, -3, "AddDynamicMethod", new lua_CSFunction(ModConfigWrap._m_AddDynamicMethod));
			Utils.RegisterFunc(L, -3, "AddMethodHookBefore", new lua_CSFunction(ModConfigWrap._m_AddMethodHookBefore));
			Utils.RegisterFunc(L, -3, "AddMethodHookAfter", new lua_CSFunction(ModConfigWrap._m_AddMethodHookAfter));
			Utils.RegisterFunc(L, -2, "ModId", new lua_CSFunction(ModConfigWrap._g_get_ModId));
			Utils.RegisterFunc(L, -2, "DirectoryName", new lua_CSFunction(ModConfigWrap._g_get_DirectoryName));
			Utils.RegisterFunc(L, -2, "ModName", new lua_CSFunction(ModConfigWrap._g_get_ModName));
			Utils.RegisterFunc(L, -2, "ModVersion", new lua_CSFunction(ModConfigWrap._g_get_ModVersion));
			Utils.RegisterFunc(L, -2, "ModAuthor", new lua_CSFunction(ModConfigWrap._g_get_ModAuthor));
			Utils.RegisterFunc(L, -2, "ModDescription", new lua_CSFunction(ModConfigWrap._g_get_ModDescription));
			Utils.RegisterFunc(L, -2, "IconPath", new lua_CSFunction(ModConfigWrap._g_get_IconPath));
			Utils.RegisterFunc(L, -2, "Enabled", new lua_CSFunction(ModConfigWrap._g_get_Enabled));
			Utils.RegisterFunc(L, -2, "Dependencies", new lua_CSFunction(ModConfigWrap._g_get_Dependencies));
			Utils.RegisterFunc(L, -1, "DirectoryName", new lua_CSFunction(ModConfigWrap._s_set_DirectoryName));
			Utils.RegisterFunc(L, -1, "ModName", new lua_CSFunction(ModConfigWrap._s_set_ModName));
			Utils.RegisterFunc(L, -1, "ModVersion", new lua_CSFunction(ModConfigWrap._s_set_ModVersion));
			Utils.RegisterFunc(L, -1, "ModAuthor", new lua_CSFunction(ModConfigWrap._s_set_ModAuthor));
			Utils.RegisterFunc(L, -1, "ModDescription", new lua_CSFunction(ModConfigWrap._s_set_ModDescription));
			Utils.RegisterFunc(L, -1, "IconPath", new lua_CSFunction(ModConfigWrap._s_set_IconPath));
			Utils.RegisterFunc(L, -1, "Enabled", new lua_CSFunction(ModConfigWrap._s_set_Enabled));
			Utils.RegisterFunc(L, -1, "Dependencies", new lua_CSFunction(ModConfigWrap._s_set_Dependencies));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(ModConfigWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0005F160 File Offset: 0x0005D360
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					ModConfig gen_ret = new ModConfig();
					translator.Push(L, gen_ret);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ModConfig constructor!");
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0005F1E4 File Offset: 0x0005D3E4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetDataConfig(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				string _id = Lua.lua_tostring(L, 2);
				Dictionary<string, string> _newData = (Dictionary<string, string>)translator.GetObject(L, 3, typeof(Dictionary<string, string>));
				gen_to_be_invoked.SetDataConfig(_id, _newData);
				result = 0;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0005F274 File Offset: 0x0005D474
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ModifyDataConfig(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				string _id = Lua.lua_tostring(L, 2);
				string _key = Lua.lua_tostring(L, 3);
				string _value = Lua.lua_tostring(L, 4);
				gen_to_be_invoked.ModifyDataConfig(_id, _key, _value);
				result = 0;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0005F300 File Offset: 0x0005D500
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RedirectSourcePath(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				string _originalPath = Lua.lua_tostring(L, 2);
				string _newPath = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.RedirectSourcePath(_originalPath, _newPath);
				result = 0;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0005F380 File Offset: 0x0005D580
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddDynamicMethod(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				string _methodName = Lua.lua_tostring(L, 2);
				LuaFunction _function = (LuaFunction)translator.GetObject(L, 3, typeof(LuaFunction));
				gen_to_be_invoked.AddDynamicMethod(_methodName, _function);
				result = 0;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0005F410 File Offset: 0x0005D610
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddMethodHookBefore(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				string _typeDotMethod = Lua.lua_tostring(L, 2);
				LuaFunction _function = (LuaFunction)translator.GetObject(L, 3, typeof(LuaFunction));
				gen_to_be_invoked.AddMethodHookBefore(_typeDotMethod, _function);
				result = 0;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0005F4A0 File Offset: 0x0005D6A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddMethodHookAfter(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				string _typeDotMethod = Lua.lua_tostring(L, 2);
				LuaFunction _function = (LuaFunction)translator.GetObject(L, 3, typeof(LuaFunction));
				gen_to_be_invoked.AddMethodHookAfter(_typeDotMethod, _function);
				result = 0;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0005F530 File Offset: 0x0005D730
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ModId(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.ModId);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0005F5A0 File Offset: 0x0005D7A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_DirectoryName(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.DirectoryName);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0005F610 File Offset: 0x0005D810
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ModName(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.ModName);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0005F680 File Offset: 0x0005D880
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ModVersion(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.ModVersion);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0005F6F0 File Offset: 0x0005D8F0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ModAuthor(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.ModAuthor);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0005F760 File Offset: 0x0005D960
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ModDescription(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.ModDescription);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0005F7D0 File Offset: 0x0005D9D0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_IconPath(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.IconPath);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0005F840 File Offset: 0x0005DA40
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Enabled(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.Enabled);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0005F8B0 File Offset: 0x0005DAB0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Dependencies(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.Dependencies);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0005F924 File Offset: 0x0005DB24
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_DirectoryName(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.DirectoryName = Lua.lua_tostring(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0005F994 File Offset: 0x0005DB94
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_ModName(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ModName = Lua.lua_tostring(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0005FA04 File Offset: 0x0005DC04
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_ModVersion(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ModVersion = Lua.lua_tostring(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0005FA74 File Offset: 0x0005DC74
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_ModAuthor(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ModAuthor = Lua.lua_tostring(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0005FAE4 File Offset: 0x0005DCE4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_ModDescription(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ModDescription = Lua.lua_tostring(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0005FB54 File Offset: 0x0005DD54
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_IconPath(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.IconPath = Lua.lua_tostring(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0005FBC4 File Offset: 0x0005DDC4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Enabled(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Enabled = Lua.lua_toboolean(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0005FC34 File Offset: 0x0005DE34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Dependencies(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ModConfig gen_to_be_invoked = (ModConfig)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Dependencies = (List<string>)translator.GetObject(L, 2, typeof(List<string>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}
	}
}

using System;
using System.Collections;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B7 RID: 439
	public class UnityEngineMonoBehaviourWrap
	{
		// Token: 0x06000EA5 RID: 3749 RVA: 0x00075BB0 File Offset: 0x00073DB0
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(MonoBehaviour);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 4, 1, -1);
			Utils.RegisterFunc(L, -3, "IsInvoking", new lua_CSFunction(UnityEngineMonoBehaviourWrap._m_IsInvoking));
			Utils.RegisterFunc(L, -3, "CancelInvoke", new lua_CSFunction(UnityEngineMonoBehaviourWrap._m_CancelInvoke));
			Utils.RegisterFunc(L, -3, "Invoke", new lua_CSFunction(UnityEngineMonoBehaviourWrap._m_Invoke));
			Utils.RegisterFunc(L, -3, "InvokeRepeating", new lua_CSFunction(UnityEngineMonoBehaviourWrap._m_InvokeRepeating));
			Utils.RegisterFunc(L, -3, "StartCoroutine", new lua_CSFunction(UnityEngineMonoBehaviourWrap._m_StartCoroutine));
			Utils.RegisterFunc(L, -3, "StopCoroutine", new lua_CSFunction(UnityEngineMonoBehaviourWrap._m_StopCoroutine));
			Utils.RegisterFunc(L, -3, "StopAllCoroutines", new lua_CSFunction(UnityEngineMonoBehaviourWrap._m_StopAllCoroutines));
			Utils.RegisterFunc(L, -2, "destroyCancellationToken", new lua_CSFunction(UnityEngineMonoBehaviourWrap._g_get_destroyCancellationToken));
			Utils.RegisterFunc(L, -2, "useGUILayout", new lua_CSFunction(UnityEngineMonoBehaviourWrap._g_get_useGUILayout));
			Utils.RegisterFunc(L, -2, "didStart", new lua_CSFunction(UnityEngineMonoBehaviourWrap._g_get_didStart));
			Utils.RegisterFunc(L, -2, "didAwake", new lua_CSFunction(UnityEngineMonoBehaviourWrap._g_get_didAwake));
			Utils.RegisterFunc(L, -1, "useGUILayout", new lua_CSFunction(UnityEngineMonoBehaviourWrap._s_set_useGUILayout));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineMonoBehaviourWrap.__CreateInstance), 2, 0, 0);
			Utils.RegisterFunc(L, -4, "print", new lua_CSFunction(UnityEngineMonoBehaviourWrap._m_print_xlua_st_));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00075D64 File Offset: 0x00073F64
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					MonoBehaviour gen_ret = new MonoBehaviour();
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
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour constructor!");
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00075DE8 File Offset: 0x00073FE8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_IsInvoking(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					bool gen_ret = gen_to_be_invoked.IsInvoking();
					Lua.lua_pushboolean(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					bool gen_ret2 = gen_to_be_invoked.IsInvoking(_methodName);
					Lua.lua_pushboolean(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour.IsInvoking!");
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00075EC8 File Offset: 0x000740C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CancelInvoke(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1;
				if (flag)
				{
					gen_to_be_invoked.CancelInvoke();
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.CancelInvoke(_methodName);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour.CancelInvoke!");
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00075F94 File Offset: 0x00074194
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Invoke(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				string _methodName = Lua.lua_tostring(L, 2);
				float _time = (float)Lua.lua_tonumber(L, 3);
				gen_to_be_invoked.Invoke(_methodName, _time);
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

		// Token: 0x06000EAA RID: 3754 RVA: 0x00076014 File Offset: 0x00074214
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InvokeRepeating(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				string _methodName = Lua.lua_tostring(L, 2);
				float _time = (float)Lua.lua_tonumber(L, 3);
				float _repeatRate = (float)Lua.lua_tonumber(L, 4);
				gen_to_be_invoked.InvokeRepeating(_methodName, _time, _repeatRate);
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

		// Token: 0x06000EAB RID: 3755 RVA: 0x000760A0 File Offset: 0x000742A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_StartCoroutine(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					Coroutine gen_ret = gen_to_be_invoked.StartCoroutine(_methodName);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<IEnumerator>(L, 2);
				if (flag2)
				{
					IEnumerator _routine = (IEnumerator)translator.GetObject(L, 2, typeof(IEnumerator));
					Coroutine gen_ret2 = gen_to_be_invoked.StartCoroutine(_routine);
					translator.Push(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<object>(L, 3);
				if (flag3)
				{
					string _methodName2 = Lua.lua_tostring(L, 2);
					object _value = translator.GetObject(L, 3, typeof(object));
					Coroutine gen_ret3 = gen_to_be_invoked.StartCoroutine(_methodName2, _value);
					translator.Push(L, gen_ret3);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour.StartCoroutine!");
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00076218 File Offset: 0x00074418
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_StopCoroutine(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<IEnumerator>(L, 2);
				if (flag)
				{
					IEnumerator _routine = (IEnumerator)translator.GetObject(L, 2, typeof(IEnumerator));
					gen_to_be_invoked.StopCoroutine(_routine);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Coroutine>(L, 2);
				if (flag2)
				{
					Coroutine _routine2 = (Coroutine)translator.GetObject(L, 2, typeof(Coroutine));
					gen_to_be_invoked.StopCoroutine(_routine2);
					return 0;
				}
				bool flag3 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag3)
				{
					string _methodName = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.StopCoroutine(_methodName);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.MonoBehaviour.StopCoroutine!");
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00076348 File Offset: 0x00074548
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_StopAllCoroutines(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.StopAllCoroutines();
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

		// Token: 0x06000EAE RID: 3758 RVA: 0x000763B0 File Offset: 0x000745B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_print_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				object _message = translator.GetObject(L, 1, typeof(object));
				MonoBehaviour.print(_message);
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

		// Token: 0x06000EAF RID: 3759 RVA: 0x00076420 File Offset: 0x00074620
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_destroyCancellationToken(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.destroyCancellationToken);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00076498 File Offset: 0x00074698
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_useGUILayout(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.useGUILayout);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00076508 File Offset: 0x00074708
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_didStart(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.didStart);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00076578 File Offset: 0x00074778
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_didAwake(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.didAwake);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000765E8 File Offset: 0x000747E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_useGUILayout(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				MonoBehaviour gen_to_be_invoked = (MonoBehaviour)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.useGUILayout = Lua.lua_toboolean(L, 2);
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

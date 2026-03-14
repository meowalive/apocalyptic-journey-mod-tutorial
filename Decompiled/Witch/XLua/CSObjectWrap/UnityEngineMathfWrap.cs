using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001B6 RID: 438
	public class UnityEngineMathfWrap
	{
		// Token: 0x06000E72 RID: 3698 RVA: 0x00073A08 File Offset: 0x00071C08
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Mathf);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0, -1);
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineMathfWrap.__CreateInstance), 55, 0, 0);
			Utils.RegisterFunc(L, -4, "GammaToLinearSpace", new lua_CSFunction(UnityEngineMathfWrap._m_GammaToLinearSpace_xlua_st_));
			Utils.RegisterFunc(L, -4, "LinearToGammaSpace", new lua_CSFunction(UnityEngineMathfWrap._m_LinearToGammaSpace_xlua_st_));
			Utils.RegisterFunc(L, -4, "CorrelatedColorTemperatureToRGB", new lua_CSFunction(UnityEngineMathfWrap._m_CorrelatedColorTemperatureToRGB_xlua_st_));
			Utils.RegisterFunc(L, -4, "FloatToHalf", new lua_CSFunction(UnityEngineMathfWrap._m_FloatToHalf_xlua_st_));
			Utils.RegisterFunc(L, -4, "HalfToFloat", new lua_CSFunction(UnityEngineMathfWrap._m_HalfToFloat_xlua_st_));
			Utils.RegisterFunc(L, -4, "PerlinNoise", new lua_CSFunction(UnityEngineMathfWrap._m_PerlinNoise_xlua_st_));
			Utils.RegisterFunc(L, -4, "PerlinNoise1D", new lua_CSFunction(UnityEngineMathfWrap._m_PerlinNoise1D_xlua_st_));
			Utils.RegisterFunc(L, -4, "Sin", new lua_CSFunction(UnityEngineMathfWrap._m_Sin_xlua_st_));
			Utils.RegisterFunc(L, -4, "Cos", new lua_CSFunction(UnityEngineMathfWrap._m_Cos_xlua_st_));
			Utils.RegisterFunc(L, -4, "Tan", new lua_CSFunction(UnityEngineMathfWrap._m_Tan_xlua_st_));
			Utils.RegisterFunc(L, -4, "Asin", new lua_CSFunction(UnityEngineMathfWrap._m_Asin_xlua_st_));
			Utils.RegisterFunc(L, -4, "Acos", new lua_CSFunction(UnityEngineMathfWrap._m_Acos_xlua_st_));
			Utils.RegisterFunc(L, -4, "Atan", new lua_CSFunction(UnityEngineMathfWrap._m_Atan_xlua_st_));
			Utils.RegisterFunc(L, -4, "Atan2", new lua_CSFunction(UnityEngineMathfWrap._m_Atan2_xlua_st_));
			Utils.RegisterFunc(L, -4, "Sqrt", new lua_CSFunction(UnityEngineMathfWrap._m_Sqrt_xlua_st_));
			Utils.RegisterFunc(L, -4, "Abs", new lua_CSFunction(UnityEngineMathfWrap._m_Abs_xlua_st_));
			Utils.RegisterFunc(L, -4, "Min", new lua_CSFunction(UnityEngineMathfWrap._m_Min_xlua_st_));
			Utils.RegisterFunc(L, -4, "Max", new lua_CSFunction(UnityEngineMathfWrap._m_Max_xlua_st_));
			Utils.RegisterFunc(L, -4, "Pow", new lua_CSFunction(UnityEngineMathfWrap._m_Pow_xlua_st_));
			Utils.RegisterFunc(L, -4, "Exp", new lua_CSFunction(UnityEngineMathfWrap._m_Exp_xlua_st_));
			Utils.RegisterFunc(L, -4, "Log", new lua_CSFunction(UnityEngineMathfWrap._m_Log_xlua_st_));
			Utils.RegisterFunc(L, -4, "Log10", new lua_CSFunction(UnityEngineMathfWrap._m_Log10_xlua_st_));
			Utils.RegisterFunc(L, -4, "Ceil", new lua_CSFunction(UnityEngineMathfWrap._m_Ceil_xlua_st_));
			Utils.RegisterFunc(L, -4, "Floor", new lua_CSFunction(UnityEngineMathfWrap._m_Floor_xlua_st_));
			Utils.RegisterFunc(L, -4, "Round", new lua_CSFunction(UnityEngineMathfWrap._m_Round_xlua_st_));
			Utils.RegisterFunc(L, -4, "CeilToInt", new lua_CSFunction(UnityEngineMathfWrap._m_CeilToInt_xlua_st_));
			Utils.RegisterFunc(L, -4, "FloorToInt", new lua_CSFunction(UnityEngineMathfWrap._m_FloorToInt_xlua_st_));
			Utils.RegisterFunc(L, -4, "RoundToInt", new lua_CSFunction(UnityEngineMathfWrap._m_RoundToInt_xlua_st_));
			Utils.RegisterFunc(L, -4, "Sign", new lua_CSFunction(UnityEngineMathfWrap._m_Sign_xlua_st_));
			Utils.RegisterFunc(L, -4, "Clamp", new lua_CSFunction(UnityEngineMathfWrap._m_Clamp_xlua_st_));
			Utils.RegisterFunc(L, -4, "Clamp01", new lua_CSFunction(UnityEngineMathfWrap._m_Clamp01_xlua_st_));
			Utils.RegisterFunc(L, -4, "Lerp", new lua_CSFunction(UnityEngineMathfWrap._m_Lerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "LerpUnclamped", new lua_CSFunction(UnityEngineMathfWrap._m_LerpUnclamped_xlua_st_));
			Utils.RegisterFunc(L, -4, "LerpAngle", new lua_CSFunction(UnityEngineMathfWrap._m_LerpAngle_xlua_st_));
			Utils.RegisterFunc(L, -4, "MoveTowards", new lua_CSFunction(UnityEngineMathfWrap._m_MoveTowards_xlua_st_));
			Utils.RegisterFunc(L, -4, "MoveTowardsAngle", new lua_CSFunction(UnityEngineMathfWrap._m_MoveTowardsAngle_xlua_st_));
			Utils.RegisterFunc(L, -4, "SmoothStep", new lua_CSFunction(UnityEngineMathfWrap._m_SmoothStep_xlua_st_));
			Utils.RegisterFunc(L, -4, "Gamma", new lua_CSFunction(UnityEngineMathfWrap._m_Gamma_xlua_st_));
			Utils.RegisterFunc(L, -4, "Approximately", new lua_CSFunction(UnityEngineMathfWrap._m_Approximately_xlua_st_));
			Utils.RegisterFunc(L, -4, "SmoothDamp", new lua_CSFunction(UnityEngineMathfWrap._m_SmoothDamp_xlua_st_));
			Utils.RegisterFunc(L, -4, "SmoothDampAngle", new lua_CSFunction(UnityEngineMathfWrap._m_SmoothDampAngle_xlua_st_));
			Utils.RegisterFunc(L, -4, "Repeat", new lua_CSFunction(UnityEngineMathfWrap._m_Repeat_xlua_st_));
			Utils.RegisterFunc(L, -4, "PingPong", new lua_CSFunction(UnityEngineMathfWrap._m_PingPong_xlua_st_));
			Utils.RegisterFunc(L, -4, "InverseLerp", new lua_CSFunction(UnityEngineMathfWrap._m_InverseLerp_xlua_st_));
			Utils.RegisterFunc(L, -4, "DeltaAngle", new lua_CSFunction(UnityEngineMathfWrap._m_DeltaAngle_xlua_st_));
			Utils.RegisterFunc(L, -4, "NextPowerOfTwo", new lua_CSFunction(UnityEngineMathfWrap._m_NextPowerOfTwo_xlua_st_));
			Utils.RegisterFunc(L, -4, "ClosestPowerOfTwo", new lua_CSFunction(UnityEngineMathfWrap._m_ClosestPowerOfTwo_xlua_st_));
			Utils.RegisterFunc(L, -4, "IsPowerOfTwo", new lua_CSFunction(UnityEngineMathfWrap._m_IsPowerOfTwo_xlua_st_));
			Utils.RegisterObject(L, translator, -4, "PI", 3.1415927f);
			Utils.RegisterObject(L, translator, -4, "Infinity", float.PositiveInfinity);
			Utils.RegisterObject(L, translator, -4, "NegativeInfinity", float.NegativeInfinity);
			Utils.RegisterObject(L, translator, -4, "Deg2Rad", 0.017453292f);
			Utils.RegisterObject(L, translator, -4, "Rad2Deg", 57.29578f);
			Utils.RegisterObject(L, translator, -4, "Epsilon", Mathf.Epsilon);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00073FE0 File Offset: 0x000721E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					translator.Push(L, default(Mathf));
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Mathf constructor!");
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0007406C File Offset: 0x0007226C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GammaToLinearSpace_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _value = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.GammaToLinearSpace(_value);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000740CC File Offset: 0x000722CC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LinearToGammaSpace_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _value = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.LinearToGammaSpace(_value);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0007412C File Offset: 0x0007232C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CorrelatedColorTemperatureToRGB_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				float _kelvin = (float)Lua.lua_tonumber(L, 1);
				Color gen_ret = Mathf.CorrelatedColorTemperatureToRGB(_kelvin);
				translator.PushUnityEngineColor(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0007419C File Offset: 0x0007239C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FloatToHalf_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _val = (float)Lua.lua_tonumber(L, 1);
				ushort gen_ret = Mathf.FloatToHalf(_val);
				Lua.xlua_pushinteger(L, (int)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000741FC File Offset: 0x000723FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_HalfToFloat_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				ushort _val = (ushort)Lua.xlua_tointeger(L, 1);
				float gen_ret = Mathf.HalfToFloat(_val);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0007425C File Offset: 0x0007245C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PerlinNoise_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _x = (float)Lua.lua_tonumber(L, 1);
				float _y = (float)Lua.lua_tonumber(L, 2);
				float gen_ret = Mathf.PerlinNoise(_x, _y);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x000742C8 File Offset: 0x000724C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PerlinNoise1D_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _x = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.PerlinNoise1D(_x);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00074328 File Offset: 0x00072528
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Sin_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Sin(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00074388 File Offset: 0x00072588
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Cos_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Cos(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000743E8 File Offset: 0x000725E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Tan_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Tan(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00074448 File Offset: 0x00072648
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Asin_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Asin(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x000744A8 File Offset: 0x000726A8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Acos_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Acos(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00074508 File Offset: 0x00072708
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Atan_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Atan(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00074568 File Offset: 0x00072768
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Atan2_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _y = (float)Lua.lua_tonumber(L, 1);
				float _x = (float)Lua.lua_tonumber(L, 2);
				float gen_ret = Mathf.Atan2(_y, _x);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000745D4 File Offset: 0x000727D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Sqrt_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Sqrt(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00074634 File Offset: 0x00072834
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Abs_xlua_st_(IntPtr L)
		{
			try
			{
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1);
				if (flag)
				{
					float _f = (float)Lua.lua_tonumber(L, 1);
					float gen_ret = Mathf.Abs(_f);
					Lua.lua_pushnumber(L, (double)gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 1 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1);
				if (flag2)
				{
					int _value = Lua.xlua_tointeger(L, 1);
					int gen_ret2 = Mathf.Abs(_value);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Abs!");
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00074700 File Offset: 0x00072900
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Min_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					float _a = (float)Lua.lua_tonumber(L, 1);
					float _b = (float)Lua.lua_tonumber(L, 2);
					float gen_ret = Mathf.Min(_a, _b);
					Lua.lua_pushnumber(L, (double)gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					int _a2 = Lua.xlua_tointeger(L, 1);
					int _b2 = Lua.xlua_tointeger(L, 2);
					int gen_ret2 = Mathf.Min(_a2, _b2);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count >= 0 && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 1) || LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1));
				if (flag3)
				{
					float[] _values = translator.GetParams<float>(L, 1);
					float gen_ret3 = Mathf.Min(_values);
					Lua.lua_pushnumber(L, (double)gen_ret3);
					return 1;
				}
				bool flag4 = gen_param_count >= 0 && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 1) || LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1));
				if (flag4)
				{
					int[] _values2 = translator.GetParams<int>(L, 1);
					int gen_ret4 = Mathf.Min(_values2);
					Lua.xlua_pushinteger(L, gen_ret4);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Min!");
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000748A4 File Offset: 0x00072AA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Max_xlua_st_(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					float _a = (float)Lua.lua_tonumber(L, 1);
					float _b = (float)Lua.lua_tonumber(L, 2);
					float gen_ret = Mathf.Max(_a, _b);
					Lua.lua_pushnumber(L, (double)gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					int _a2 = Lua.xlua_tointeger(L, 1);
					int _b2 = Lua.xlua_tointeger(L, 2);
					int gen_ret2 = Mathf.Max(_a2, _b2);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count >= 0 && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 1) || LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1));
				if (flag3)
				{
					float[] _values = translator.GetParams<float>(L, 1);
					float gen_ret3 = Mathf.Max(_values);
					Lua.lua_pushnumber(L, (double)gen_ret3);
					return 1;
				}
				bool flag4 = gen_param_count >= 0 && (LuaTypes.LUA_TNONE == Lua.lua_type(L, 1) || LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1));
				if (flag4)
				{
					int[] _values2 = translator.GetParams<int>(L, 1);
					int gen_ret4 = Mathf.Max(_values2);
					Lua.xlua_pushinteger(L, gen_ret4);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Max!");
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00074A48 File Offset: 0x00072C48
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Pow_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float _p = (float)Lua.lua_tonumber(L, 2);
				float gen_ret = Mathf.Pow(_f, _p);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00074AB4 File Offset: 0x00072CB4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Exp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _power = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Exp(_power);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00074B14 File Offset: 0x00072D14
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Log_xlua_st_(IntPtr L)
		{
			try
			{
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 1 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1);
				if (flag)
				{
					float _f = (float)Lua.lua_tonumber(L, 1);
					float gen_ret = Mathf.Log(_f);
					Lua.lua_pushnumber(L, (double)gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag2)
				{
					float _f2 = (float)Lua.lua_tonumber(L, 1);
					float _p = (float)Lua.lua_tonumber(L, 2);
					float gen_ret2 = Mathf.Log(_f2, _p);
					Lua.lua_pushnumber(L, (double)gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Log!");
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00074BFC File Offset: 0x00072DFC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Log10_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Log10(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00074C5C File Offset: 0x00072E5C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Ceil_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Ceil(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00074CBC File Offset: 0x00072EBC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Floor_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Floor(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00074D1C File Offset: 0x00072F1C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Round_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Round(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00074D7C File Offset: 0x00072F7C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CeilToInt_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				int gen_ret = Mathf.CeilToInt(_f);
				Lua.xlua_pushinteger(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00074DDC File Offset: 0x00072FDC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_FloorToInt_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				int gen_ret = Mathf.FloorToInt(_f);
				Lua.xlua_pushinteger(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00074E3C File Offset: 0x0007303C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RoundToInt_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				int gen_ret = Mathf.RoundToInt(_f);
				Lua.xlua_pushinteger(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00074E9C File Offset: 0x0007309C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Sign_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _f = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Sign(_f);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00074EFC File Offset: 0x000730FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Clamp_xlua_st_(IntPtr L)
		{
			try
			{
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag)
				{
					float _value = (float)Lua.lua_tonumber(L, 1);
					float _min = (float)Lua.lua_tonumber(L, 2);
					float _max = (float)Lua.lua_tonumber(L, 3);
					float gen_ret = Mathf.Clamp(_value, _min, _max);
					Lua.lua_pushnumber(L, (double)gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag2)
				{
					int _value2 = Lua.xlua_tointeger(L, 1);
					int _min2 = Lua.xlua_tointeger(L, 2);
					int _max2 = Lua.xlua_tointeger(L, 3);
					int gen_ret2 = Mathf.Clamp(_value2, _min2, _max2);
					Lua.xlua_pushinteger(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Mathf.Clamp!");
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00075020 File Offset: 0x00073220
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Clamp01_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _value = (float)Lua.lua_tonumber(L, 1);
				float gen_ret = Mathf.Clamp01(_value);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00075080 File Offset: 0x00073280
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Lerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _a = (float)Lua.lua_tonumber(L, 1);
				float _b = (float)Lua.lua_tonumber(L, 2);
				float _t = (float)Lua.lua_tonumber(L, 3);
				float gen_ret = Mathf.Lerp(_a, _b, _t);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000750FC File Offset: 0x000732FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LerpUnclamped_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _a = (float)Lua.lua_tonumber(L, 1);
				float _b = (float)Lua.lua_tonumber(L, 2);
				float _t = (float)Lua.lua_tonumber(L, 3);
				float gen_ret = Mathf.LerpUnclamped(_a, _b, _t);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00075178 File Offset: 0x00073378
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LerpAngle_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _a = (float)Lua.lua_tonumber(L, 1);
				float _b = (float)Lua.lua_tonumber(L, 2);
				float _t = (float)Lua.lua_tonumber(L, 3);
				float gen_ret = Mathf.LerpAngle(_a, _b, _t);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000751F4 File Offset: 0x000733F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_MoveTowards_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _current = (float)Lua.lua_tonumber(L, 1);
				float _target = (float)Lua.lua_tonumber(L, 2);
				float _maxDelta = (float)Lua.lua_tonumber(L, 3);
				float gen_ret = Mathf.MoveTowards(_current, _target, _maxDelta);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00075270 File Offset: 0x00073470
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_MoveTowardsAngle_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _current = (float)Lua.lua_tonumber(L, 1);
				float _target = (float)Lua.lua_tonumber(L, 2);
				float _maxDelta = (float)Lua.lua_tonumber(L, 3);
				float gen_ret = Mathf.MoveTowardsAngle(_current, _target, _maxDelta);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x000752EC File Offset: 0x000734EC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SmoothStep_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _from = (float)Lua.lua_tonumber(L, 1);
				float _to = (float)Lua.lua_tonumber(L, 2);
				float _t = (float)Lua.lua_tonumber(L, 3);
				float gen_ret = Mathf.SmoothStep(_from, _to, _t);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00075368 File Offset: 0x00073568
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Gamma_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _value = (float)Lua.lua_tonumber(L, 1);
				float _absmax = (float)Lua.lua_tonumber(L, 2);
				float _gamma = (float)Lua.lua_tonumber(L, 3);
				float gen_ret = Mathf.Gamma(_value, _absmax, _gamma);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x000753E4 File Offset: 0x000735E4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Approximately_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _a = (float)Lua.lua_tonumber(L, 1);
				float _b = (float)Lua.lua_tonumber(L, 2);
				bool gen_ret = Mathf.Approximately(_a, _b);
				Lua.lua_pushboolean(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00075450 File Offset: 0x00073650
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SmoothDamp_xlua_st_(IntPtr L)
		{
			try
			{
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _current = (float)Lua.lua_tonumber(L, 1);
					float _target = (float)Lua.lua_tonumber(L, 2);
					float _currentVelocity = (float)Lua.lua_tonumber(L, 3);
					float _smoothTime = (float)Lua.lua_tonumber(L, 4);
					float gen_ret = Mathf.SmoothDamp(_current, _target, ref _currentVelocity, _smoothTime);
					Lua.lua_pushnumber(L, (double)gen_ret);
					Lua.lua_pushnumber(L, (double)_currentVelocity);
					return 2;
				}
				bool flag2 = gen_param_count == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5);
				if (flag2)
				{
					float _current2 = (float)Lua.lua_tonumber(L, 1);
					float _target2 = (float)Lua.lua_tonumber(L, 2);
					float _currentVelocity2 = (float)Lua.lua_tonumber(L, 3);
					float _smoothTime2 = (float)Lua.lua_tonumber(L, 4);
					float _maxSpeed = (float)Lua.lua_tonumber(L, 5);
					float gen_ret2 = Mathf.SmoothDamp(_current2, _target2, ref _currentVelocity2, _smoothTime2, _maxSpeed);
					Lua.lua_pushnumber(L, (double)gen_ret2);
					Lua.lua_pushnumber(L, (double)_currentVelocity2);
					return 2;
				}
				bool flag3 = gen_param_count == 6 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 6);
				if (flag3)
				{
					float _current3 = (float)Lua.lua_tonumber(L, 1);
					float _target3 = (float)Lua.lua_tonumber(L, 2);
					float _currentVelocity3 = (float)Lua.lua_tonumber(L, 3);
					float _smoothTime3 = (float)Lua.lua_tonumber(L, 4);
					float _maxSpeed2 = (float)Lua.lua_tonumber(L, 5);
					float _deltaTime = (float)Lua.lua_tonumber(L, 6);
					float gen_ret3 = Mathf.SmoothDamp(_current3, _target3, ref _currentVelocity3, _smoothTime3, _maxSpeed2, _deltaTime);
					Lua.lua_pushnumber(L, (double)gen_ret3);
					Lua.lua_pushnumber(L, (double)_currentVelocity3);
					return 2;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Mathf.SmoothDamp!");
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00075690 File Offset: 0x00073890
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SmoothDampAngle_xlua_st_(IntPtr L)
		{
			try
			{
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _current = (float)Lua.lua_tonumber(L, 1);
					float _target = (float)Lua.lua_tonumber(L, 2);
					float _currentVelocity = (float)Lua.lua_tonumber(L, 3);
					float _smoothTime = (float)Lua.lua_tonumber(L, 4);
					float gen_ret = Mathf.SmoothDampAngle(_current, _target, ref _currentVelocity, _smoothTime);
					Lua.lua_pushnumber(L, (double)gen_ret);
					Lua.lua_pushnumber(L, (double)_currentVelocity);
					return 2;
				}
				bool flag2 = gen_param_count == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5);
				if (flag2)
				{
					float _current2 = (float)Lua.lua_tonumber(L, 1);
					float _target2 = (float)Lua.lua_tonumber(L, 2);
					float _currentVelocity2 = (float)Lua.lua_tonumber(L, 3);
					float _smoothTime2 = (float)Lua.lua_tonumber(L, 4);
					float _maxSpeed = (float)Lua.lua_tonumber(L, 5);
					float gen_ret2 = Mathf.SmoothDampAngle(_current2, _target2, ref _currentVelocity2, _smoothTime2, _maxSpeed);
					Lua.lua_pushnumber(L, (double)gen_ret2);
					Lua.lua_pushnumber(L, (double)_currentVelocity2);
					return 2;
				}
				bool flag3 = gen_param_count == 6 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 1) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 5) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 6);
				if (flag3)
				{
					float _current3 = (float)Lua.lua_tonumber(L, 1);
					float _target3 = (float)Lua.lua_tonumber(L, 2);
					float _currentVelocity3 = (float)Lua.lua_tonumber(L, 3);
					float _smoothTime3 = (float)Lua.lua_tonumber(L, 4);
					float _maxSpeed2 = (float)Lua.lua_tonumber(L, 5);
					float _deltaTime = (float)Lua.lua_tonumber(L, 6);
					float gen_ret3 = Mathf.SmoothDampAngle(_current3, _target3, ref _currentVelocity3, _smoothTime3, _maxSpeed2, _deltaTime);
					Lua.lua_pushnumber(L, (double)gen_ret3);
					Lua.lua_pushnumber(L, (double)_currentVelocity3);
					return 2;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Mathf.SmoothDampAngle!");
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000758D0 File Offset: 0x00073AD0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Repeat_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _t = (float)Lua.lua_tonumber(L, 1);
				float _length = (float)Lua.lua_tonumber(L, 2);
				float gen_ret = Mathf.Repeat(_t, _length);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0007593C File Offset: 0x00073B3C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PingPong_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _t = (float)Lua.lua_tonumber(L, 1);
				float _length = (float)Lua.lua_tonumber(L, 2);
				float gen_ret = Mathf.PingPong(_t, _length);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000759A8 File Offset: 0x00073BA8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InverseLerp_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _a = (float)Lua.lua_tonumber(L, 1);
				float _b = (float)Lua.lua_tonumber(L, 2);
				float _value = (float)Lua.lua_tonumber(L, 3);
				float gen_ret = Mathf.InverseLerp(_a, _b, _value);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00075A24 File Offset: 0x00073C24
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DeltaAngle_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				float _current = (float)Lua.lua_tonumber(L, 1);
				float _target = (float)Lua.lua_tonumber(L, 2);
				float gen_ret = Mathf.DeltaAngle(_current, _target);
				Lua.lua_pushnumber(L, (double)gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00075A90 File Offset: 0x00073C90
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_NextPowerOfTwo_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				int _value = Lua.xlua_tointeger(L, 1);
				int gen_ret = Mathf.NextPowerOfTwo(_value);
				Lua.xlua_pushinteger(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00075AF0 File Offset: 0x00073CF0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ClosestPowerOfTwo_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				int _value = Lua.xlua_tointeger(L, 1);
				int gen_ret = Mathf.ClosestPowerOfTwo(_value);
				Lua.xlua_pushinteger(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00075B50 File Offset: 0x00073D50
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_IsPowerOfTwo_xlua_st_(IntPtr L)
		{
			int result;
			try
			{
				int _value = Lua.xlua_tointeger(L, 1);
				bool gen_ret = Mathf.IsPowerOfTwo(_value);
				Lua.lua_pushboolean(L, gen_ret);
				result = 1;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}
	}
}

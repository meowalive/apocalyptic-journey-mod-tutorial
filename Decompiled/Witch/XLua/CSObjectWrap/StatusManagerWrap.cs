using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Witch.Core;
using Witch.UI;
using Witch.UI.Window;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001A6 RID: 422
	public class StatusManagerWrap
	{
		// Token: 0x06000D0D RID: 3341 RVA: 0x000647C4 File Offset: 0x000629C4
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(StatusManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 36, 32, 28, -1);
			Utils.RegisterFunc(L, -3, "SetSprite", new lua_CSFunction(StatusManagerWrap._m_SetSprite));
			Utils.RegisterFunc(L, -3, "AddSummon", new lua_CSFunction(StatusManagerWrap._m_AddSummon));
			Utils.RegisterFunc(L, -3, "RemoveSummon", new lua_CSFunction(StatusManagerWrap._m_RemoveSummon));
			Utils.RegisterFunc(L, -3, "OnSelect", new lua_CSFunction(StatusManagerWrap._m_OnSelect));
			Utils.RegisterFunc(L, -3, "OnUnSelect", new lua_CSFunction(StatusManagerWrap._m_OnUnSelect));
			Utils.RegisterFunc(L, -3, "ResetAnimator", new lua_CSFunction(StatusManagerWrap._m_ResetAnimator));
			Utils.RegisterFunc(L, -3, "InitAnimator", new lua_CSFunction(StatusManagerWrap._m_InitAnimator));
			Utils.RegisterFunc(L, -3, "InitVocal", new lua_CSFunction(StatusManagerWrap._m_InitVocal));
			Utils.RegisterFunc(L, -3, "ResetVocal", new lua_CSFunction(StatusManagerWrap._m_ResetVocal));
			Utils.RegisterFunc(L, -3, "Init", new lua_CSFunction(StatusManagerWrap._m_Init));
			Utils.RegisterFunc(L, -3, "SetPosition", new lua_CSFunction(StatusManagerWrap._m_SetPosition));
			Utils.RegisterFunc(L, -3, "UpdateDisplay", new lua_CSFunction(StatusManagerWrap._m_UpdateDisplay));
			Utils.RegisterFunc(L, -3, "UpdateObjPos", new lua_CSFunction(StatusManagerWrap._m_UpdateObjPos));
			Utils.RegisterFunc(L, -3, "UpdateStatus", new lua_CSFunction(StatusManagerWrap._m_UpdateStatus));
			Utils.RegisterFunc(L, -3, "ResetDamageStatus", new lua_CSFunction(StatusManagerWrap._m_ResetDamageStatus));
			Utils.RegisterFunc(L, -3, "Hit", new lua_CSFunction(StatusManagerWrap._m_Hit));
			Utils.RegisterFunc(L, -3, "Heal", new lua_CSFunction(StatusManagerWrap._m_Heal));
			Utils.RegisterFunc(L, -3, "PlayVocal", new lua_CSFunction(StatusManagerWrap._m_PlayVocal));
			Utils.RegisterFunc(L, -3, "EnemyDead", new lua_CSFunction(StatusManagerWrap._m_EnemyDead));
			Utils.RegisterFunc(L, -3, "UpdateEffectList", new lua_CSFunction(StatusManagerWrap._m_UpdateEffectList));
			Utils.RegisterFunc(L, -3, "UpdateTough", new lua_CSFunction(StatusManagerWrap._m_UpdateTough));
			Utils.RegisterFunc(L, -3, "ChangeState", new lua_CSFunction(StatusManagerWrap._m_ChangeState));
			Utils.RegisterFunc(L, -3, "DamageCalculate", new lua_CSFunction(StatusManagerWrap._m_DamageCalculate));
			Utils.RegisterFunc(L, -3, "DefenceCalculate", new lua_CSFunction(StatusManagerWrap._m_DefenceCalculate));
			Utils.RegisterFunc(L, -3, "UnDamageCalucate", new lua_CSFunction(StatusManagerWrap._m_UnDamageCalucate));
			Utils.RegisterFunc(L, -3, "Resurrection", new lua_CSFunction(StatusManagerWrap._m_Resurrection));
			Utils.RegisterFunc(L, -3, "CheckDead", new lua_CSFunction(StatusManagerWrap._m_CheckDead));
			Utils.RegisterFunc(L, -3, "CheckAllBuff", new lua_CSFunction(StatusManagerWrap._m_CheckAllBuff));
			Utils.RegisterFunc(L, -3, "UpdateBuff", new lua_CSFunction(StatusManagerWrap._m_UpdateBuff));
			Utils.RegisterFunc(L, -3, "ClearAllBuff", new lua_CSFunction(StatusManagerWrap._m_ClearAllBuff));
			Utils.RegisterFunc(L, -3, "RemoveBuff", new lua_CSFunction(StatusManagerWrap._m_RemoveBuff));
			Utils.RegisterFunc(L, -3, "AddBuff", new lua_CSFunction(StatusManagerWrap._m_AddBuff));
			Utils.RegisterFunc(L, -3, "GetBuff", new lua_CSFunction(StatusManagerWrap._m_GetBuff));
			Utils.RegisterFunc(L, -3, "GetBuffs", new lua_CSFunction(StatusManagerWrap._m_GetBuffs));
			Utils.RegisterFunc(L, -3, "OnPointerEnter", new lua_CSFunction(StatusManagerWrap._m_OnPointerEnter));
			Utils.RegisterFunc(L, -3, "OnPointerExit", new lua_CSFunction(StatusManagerWrap._m_OnPointerExit));
			Utils.RegisterFunc(L, -2, "animatedState", new lua_CSFunction(StatusManagerWrap._g_get_animatedState));
			Utils.RegisterFunc(L, -2, "state", new lua_CSFunction(StatusManagerWrap._g_get_state));
			Utils.RegisterFunc(L, -2, "Name", new lua_CSFunction(StatusManagerWrap._g_get_Name));
			Utils.RegisterFunc(L, -2, "fatherObject", new lua_CSFunction(StatusManagerWrap._g_get_fatherObject));
			Utils.RegisterFunc(L, -2, "actionObj", new lua_CSFunction(StatusManagerWrap._g_get_actionObj));
			Utils.RegisterFunc(L, -2, "DamageFilter", new lua_CSFunction(StatusManagerWrap._g_get_DamageFilter));
			Utils.RegisterFunc(L, -2, "effectList", new lua_CSFunction(StatusManagerWrap._g_get_effectList));
			Utils.RegisterFunc(L, -2, "InstanceId", new lua_CSFunction(StatusManagerWrap._g_get_InstanceId));
			Utils.RegisterFunc(L, -2, "MirrorSc", new lua_CSFunction(StatusManagerWrap._g_get_MirrorSc));
			Utils.RegisterFunc(L, -2, "MaxHp", new lua_CSFunction(StatusManagerWrap._g_get_MaxHp));
			Utils.RegisterFunc(L, -2, "ToughOrigin", new lua_CSFunction(StatusManagerWrap._g_get_ToughOrigin));
			Utils.RegisterFunc(L, -2, "ToughCount", new lua_CSFunction(StatusManagerWrap._g_get_ToughCount));
			Utils.RegisterFunc(L, -2, "CurHp", new lua_CSFunction(StatusManagerWrap._g_get_CurHp));
			Utils.RegisterFunc(L, -2, "Defend", new lua_CSFunction(StatusManagerWrap._g_get_Defend));
			Utils.RegisterFunc(L, -2, "dynamicVariables", new lua_CSFunction(StatusManagerWrap._g_get_dynamicVariables));
			Utils.RegisterFunc(L, -2, "dynamicVariablesLog", new lua_CSFunction(StatusManagerWrap._g_get_dynamicVariablesLog));
			Utils.RegisterFunc(L, -2, "_animatedState", new lua_CSFunction(StatusManagerWrap._g_get__animatedState));
			Utils.RegisterFunc(L, -2, "Summon", new lua_CSFunction(StatusManagerWrap._g_get_Summon));
			Utils.RegisterFunc(L, -2, "_NetEnqueue", new lua_CSFunction(StatusManagerWrap._g_get__NetEnqueue));
			Utils.RegisterFunc(L, -2, "selfUI", new lua_CSFunction(StatusManagerWrap._g_get_selfUI));
			Utils.RegisterFunc(L, -2, "statusBarObj", new lua_CSFunction(StatusManagerWrap._g_get_statusBarObj));
			Utils.RegisterFunc(L, -2, "actionText", new lua_CSFunction(StatusManagerWrap._g_get_actionText));
			Utils.RegisterFunc(L, -2, "statusBarUI", new lua_CSFunction(StatusManagerWrap._g_get_statusBarUI));
			Utils.RegisterFunc(L, -2, "actionContent", new lua_CSFunction(StatusManagerWrap._g_get_actionContent));
			Utils.RegisterFunc(L, -2, "effectListObj", new lua_CSFunction(StatusManagerWrap._g_get_effectListObj));
			Utils.RegisterFunc(L, -2, "initPos", new lua_CSFunction(StatusManagerWrap._g_get_initPos));
			Utils.RegisterFunc(L, -2, "MiDataConfig", new lua_CSFunction(StatusManagerWrap._g_get_MiDataConfig));
			Utils.RegisterFunc(L, -2, "maxHp", new lua_CSFunction(StatusManagerWrap._g_get_maxHp));
			Utils.RegisterFunc(L, -2, "_toughCount", new lua_CSFunction(StatusManagerWrap._g_get__toughCount));
			Utils.RegisterFunc(L, -2, "curHp", new lua_CSFunction(StatusManagerWrap._g_get_curHp));
			Utils.RegisterFunc(L, -2, "defend", new lua_CSFunction(StatusManagerWrap._g_get_defend));
			Utils.RegisterFunc(L, -2, "isResurrecting", new lua_CSFunction(StatusManagerWrap._g_get_isResurrecting));
			Utils.RegisterFunc(L, -1, "animatedState", new lua_CSFunction(StatusManagerWrap._s_set_animatedState));
			Utils.RegisterFunc(L, -1, "state", new lua_CSFunction(StatusManagerWrap._s_set_state));
			Utils.RegisterFunc(L, -1, "fatherObject", new lua_CSFunction(StatusManagerWrap._s_set_fatherObject));
			Utils.RegisterFunc(L, -1, "actionObj", new lua_CSFunction(StatusManagerWrap._s_set_actionObj));
			Utils.RegisterFunc(L, -1, "DamageFilter", new lua_CSFunction(StatusManagerWrap._s_set_DamageFilter));
			Utils.RegisterFunc(L, -1, "effectList", new lua_CSFunction(StatusManagerWrap._s_set_effectList));
			Utils.RegisterFunc(L, -1, "MaxHp", new lua_CSFunction(StatusManagerWrap._s_set_MaxHp));
			Utils.RegisterFunc(L, -1, "ToughOrigin", new lua_CSFunction(StatusManagerWrap._s_set_ToughOrigin));
			Utils.RegisterFunc(L, -1, "ToughCount", new lua_CSFunction(StatusManagerWrap._s_set_ToughCount));
			Utils.RegisterFunc(L, -1, "CurHp", new lua_CSFunction(StatusManagerWrap._s_set_CurHp));
			Utils.RegisterFunc(L, -1, "Defend", new lua_CSFunction(StatusManagerWrap._s_set_Defend));
			Utils.RegisterFunc(L, -1, "dynamicVariables", new lua_CSFunction(StatusManagerWrap._s_set_dynamicVariables));
			Utils.RegisterFunc(L, -1, "_animatedState", new lua_CSFunction(StatusManagerWrap._s_set__animatedState));
			Utils.RegisterFunc(L, -1, "Summon", new lua_CSFunction(StatusManagerWrap._s_set_Summon));
			Utils.RegisterFunc(L, -1, "_NetEnqueue", new lua_CSFunction(StatusManagerWrap._s_set__NetEnqueue));
			Utils.RegisterFunc(L, -1, "selfUI", new lua_CSFunction(StatusManagerWrap._s_set_selfUI));
			Utils.RegisterFunc(L, -1, "statusBarObj", new lua_CSFunction(StatusManagerWrap._s_set_statusBarObj));
			Utils.RegisterFunc(L, -1, "actionText", new lua_CSFunction(StatusManagerWrap._s_set_actionText));
			Utils.RegisterFunc(L, -1, "statusBarUI", new lua_CSFunction(StatusManagerWrap._s_set_statusBarUI));
			Utils.RegisterFunc(L, -1, "actionContent", new lua_CSFunction(StatusManagerWrap._s_set_actionContent));
			Utils.RegisterFunc(L, -1, "effectListObj", new lua_CSFunction(StatusManagerWrap._s_set_effectListObj));
			Utils.RegisterFunc(L, -1, "initPos", new lua_CSFunction(StatusManagerWrap._s_set_initPos));
			Utils.RegisterFunc(L, -1, "MiDataConfig", new lua_CSFunction(StatusManagerWrap._s_set_MiDataConfig));
			Utils.RegisterFunc(L, -1, "maxHp", new lua_CSFunction(StatusManagerWrap._s_set_maxHp));
			Utils.RegisterFunc(L, -1, "_toughCount", new lua_CSFunction(StatusManagerWrap._s_set__toughCount));
			Utils.RegisterFunc(L, -1, "curHp", new lua_CSFunction(StatusManagerWrap._s_set_curHp));
			Utils.RegisterFunc(L, -1, "defend", new lua_CSFunction(StatusManagerWrap._s_set_defend));
			Utils.RegisterFunc(L, -1, "isResurrecting", new lua_CSFunction(StatusManagerWrap._s_set_isResurrecting));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(StatusManagerWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000651CC File Offset: 0x000633CC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				bool flag = Lua.lua_gettop(L) == 1;
				if (flag)
				{
					StatusManager gen_ret = new StatusManager();
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
			return Lua.luaL_error(L, "invalid arguments to StatusManager constructor!");
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00065250 File Offset: 0x00063450
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetSprite(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Sprite _sprite = (Sprite)translator.GetObject(L, 2, typeof(Sprite));
				gen_to_be_invoked.SetSprite(_sprite);
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

		// Token: 0x06000D10 RID: 3344 RVA: 0x000652D4 File Offset: 0x000634D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddSummon(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				string _path = Lua.lua_tostring(L, 2);
				string _name = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.AddSummon(_path, _name);
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

		// Token: 0x06000D11 RID: 3345 RVA: 0x00065354 File Offset: 0x00063554
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveSummon(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				string _name = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.RemoveSummon(_name);
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

		// Token: 0x06000D12 RID: 3346 RVA: 0x000653C8 File Offset: 0x000635C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnSelect(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.OnSelect();
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

		// Token: 0x06000D13 RID: 3347 RVA: 0x00065430 File Offset: 0x00063630
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnUnSelect(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.OnUnSelect();
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

		// Token: 0x06000D14 RID: 3348 RVA: 0x00065498 File Offset: 0x00063698
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ResetAnimator(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 2);
				if (flag)
				{
					bool _replaceImmediate = Lua.lua_toboolean(L, 2);
					gen_to_be_invoked.ResetAnimator(_replaceImmediate);
					return 0;
				}
				bool flag2 = gen_param_count == 1;
				if (flag2)
				{
					gen_to_be_invoked.ResetAnimator(true);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to StatusManager.ResetAnimator!");
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00065558 File Offset: 0x00063758
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InitAnimator(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 2);
				if (flag)
				{
					bool _replaceImmediate = Lua.lua_toboolean(L, 2);
					Sprite gen_ret = gen_to_be_invoked.InitAnimator(_replaceImmediate);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 1;
				if (flag2)
				{
					Sprite gen_ret2 = gen_to_be_invoked.InitAnimator(true);
					translator.Push(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to StatusManager.InitAnimator!");
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0006562C File Offset: 0x0006382C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InitVocal(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.InitVocal();
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

		// Token: 0x06000D17 RID: 3351 RVA: 0x00065694 File Offset: 0x00063894
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ResetVocal(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ResetVocal();
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

		// Token: 0x06000D18 RID: 3352 RVA: 0x000656FC File Offset: 0x000638FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Init(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				FightObject _father = (FightObject)translator.GetObject(L, 2, typeof(FightObject));
				IStatusManager gen_ret = gen_to_be_invoked.Init(_father);
				translator.PushAny(L, gen_ret);
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

		// Token: 0x06000D19 RID: 3353 RVA: 0x0006578C File Offset: 0x0006398C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetPosition(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Vector3 _pos;
				translator.Get(L, 2, out _pos);
				gen_to_be_invoked.SetPosition(_pos);
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

		// Token: 0x06000D1A RID: 3354 RVA: 0x00065804 File Offset: 0x00063A04
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateDisplay(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.UpdateDisplay();
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

		// Token: 0x06000D1B RID: 3355 RVA: 0x0006586C File Offset: 0x00063A6C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateObjPos(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.UpdateObjPos();
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

		// Token: 0x06000D1C RID: 3356 RVA: 0x000658D4 File Offset: 0x00063AD4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateStatus(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 2);
				if (flag)
				{
					bool _NeedEffect = Lua.lua_toboolean(L, 2);
					gen_to_be_invoked.UpdateStatus(_NeedEffect);
					return 0;
				}
				bool flag2 = gen_param_count == 1;
				if (flag2)
				{
					gen_to_be_invoked.UpdateStatus(true);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to StatusManager.UpdateStatus!");
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00065994 File Offset: 0x00063B94
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ResetDamageStatus(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ResetDamageStatus();
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

		// Token: 0x06000D1E RID: 3358 RVA: 0x000659FC File Offset: 0x00063BFC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Hit(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int _val = Lua.xlua_tointeger(L, 2);
				string _damageType = Lua.lua_tostring(L, 3);
				string _fromDataId = Lua.lua_tostring(L, 4);
				string _fromInstanceId = Lua.lua_tostring(L, 5);
				gen_to_be_invoked.Hit(_val, _damageType, _fromDataId, _fromInstanceId);
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

		// Token: 0x06000D1F RID: 3359 RVA: 0x00065A94 File Offset: 0x00063C94
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Heal(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int _val = Lua.xlua_tointeger(L, 2);
				string _damageType = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.Heal(_val, _damageType);
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

		// Token: 0x06000D20 RID: 3360 RVA: 0x00065B14 File Offset: 0x00063D14
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PlayVocal(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				IStatusManager.VocalState _state;
				translator.Get<IStatusManager.VocalState>(L, 2, out _state);
				gen_to_be_invoked.PlayVocal(_state);
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

		// Token: 0x06000D21 RID: 3361 RVA: 0x00065B8C File Offset: 0x00063D8C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_EnemyDead(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					float _Delay = (float)Lua.lua_tonumber(L, 2);
					gen_to_be_invoked.EnemyDead(_Delay);
					return 0;
				}
				bool flag2 = gen_param_count == 1;
				if (flag2)
				{
					gen_to_be_invoked.EnemyDead(0f);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to StatusManager.EnemyDead!");
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00065C50 File Offset: 0x00063E50
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateEffectList(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.UpdateEffectList();
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

		// Token: 0x06000D23 RID: 3363 RVA: 0x00065CB8 File Offset: 0x00063EB8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateTough(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.UpdateTough();
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

		// Token: 0x06000D24 RID: 3364 RVA: 0x00065D20 File Offset: 0x00063F20
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeState(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				IStatusManager.State _state;
				translator.Get<IStatusManager.State>(L, 2, out _state);
				gen_to_be_invoked.ChangeState(_state);
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

		// Token: 0x06000D25 RID: 3365 RVA: 0x00065D98 File Offset: 0x00063F98
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DamageCalculate(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int _BaseDamage = Lua.xlua_tointeger(L, 2);
				int gen_ret = gen_to_be_invoked.DamageCalculate(_BaseDamage);
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

		// Token: 0x06000D26 RID: 3366 RVA: 0x00065E18 File Offset: 0x00064018
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DefenceCalculate(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int _BaseDefence = Lua.xlua_tointeger(L, 2);
				int gen_ret = gen_to_be_invoked.DefenceCalculate(_BaseDefence);
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

		// Token: 0x06000D27 RID: 3367 RVA: 0x00065E98 File Offset: 0x00064098
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UnDamageCalucate(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int _BaseDamage = Lua.xlua_tointeger(L, 2);
				int gen_ret = gen_to_be_invoked.UnDamageCalucate(_BaseDamage);
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

		// Token: 0x06000D28 RID: 3368 RVA: 0x00065F18 File Offset: 0x00064118
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Resurrection(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2);
				if (flag)
				{
					int _value = Lua.xlua_tointeger(L, 2);
					gen_to_be_invoked.Resurrection(_value);
					return 0;
				}
				bool flag2 = gen_param_count == 1;
				if (flag2)
				{
					gen_to_be_invoked.Resurrection(100);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to StatusManager.Resurrection!");
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00065FD8 File Offset: 0x000641D8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CheckDead(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.CheckDead();
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

		// Token: 0x06000D2A RID: 3370 RVA: 0x00066040 File Offset: 0x00064240
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CheckAllBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				string _way = Lua.lua_tostring(L, 2);
				IStatusManager gen_ret = gen_to_be_invoked.CheckAllBuff(_way);
				translator.PushAny(L, gen_ret);
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

		// Token: 0x06000D2B RID: 3371 RVA: 0x000660C0 File Offset: 0x000642C0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				IStatusManager gen_ret = gen_to_be_invoked.UpdateBuff();
				translator.PushAny(L, gen_ret);
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

		// Token: 0x06000D2C RID: 3372 RVA: 0x00066134 File Offset: 0x00064334
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ClearAllBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				IStatusManager gen_ret = gen_to_be_invoked.ClearAllBuff();
				translator.PushAny(L, gen_ret);
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

		// Token: 0x06000D2D RID: 3373 RVA: 0x000661A8 File Offset: 0x000643A8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				string _buffId = Lua.lua_tostring(L, 2);
				IStatusManager gen_ret = gen_to_be_invoked.RemoveBuff(_buffId);
				translator.PushAny(L, gen_ret);
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

		// Token: 0x06000D2E RID: 3374 RVA: 0x00066228 File Offset: 0x00064428
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddBuff(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<IBuffItemConfig>(L, 2);
				if (flag)
				{
					IBuffItemConfig _buffConfig = (IBuffItemConfig)translator.GetObject(L, 2, typeof(IBuffItemConfig));
					IStatusManager gen_ret = gen_to_be_invoked.AddBuff(_buffConfig);
					translator.PushAny(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag2)
				{
					string _buffId = Lua.lua_tostring(L, 2);
					int _level = Lua.xlua_tointeger(L, 3);
					IStatusManager gen_ret2 = gen_to_be_invoked.AddBuff(_buffId, _level);
					translator.PushAny(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to StatusManager.AddBuff!");
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00066344 File Offset: 0x00064544
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				string _buffId = Lua.lua_tostring(L, 2);
				IBuffItem gen_ret = gen_to_be_invoked.GetBuff(_buffId);
				translator.PushAny(L, gen_ret);
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

		// Token: 0x06000D30 RID: 3376 RVA: 0x000663C4 File Offset: 0x000645C4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetBuffs(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				IBuffItem[] gen_ret = gen_to_be_invoked.GetBuffs();
				translator.Push(L, gen_ret);
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

		// Token: 0x06000D31 RID: 3377 RVA: 0x00066438 File Offset: 0x00064638
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnPointerEnter(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				PointerEventData _eventData = (PointerEventData)translator.GetObject(L, 2, typeof(PointerEventData));
				gen_to_be_invoked.OnPointerEnter(_eventData);
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

		// Token: 0x06000D32 RID: 3378 RVA: 0x000664BC File Offset: 0x000646BC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnPointerExit(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				PointerEventData _eventData = (PointerEventData)translator.GetObject(L, 2, typeof(PointerEventData));
				gen_to_be_invoked.OnPointerExit(_eventData);
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

		// Token: 0x06000D33 RID: 3379 RVA: 0x00066540 File Offset: 0x00064740
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_animatedState(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.animatedState);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000665B8 File Offset: 0x000647B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_state(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.state);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00066630 File Offset: 0x00064830
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Name(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.Name);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000666A0 File Offset: 0x000648A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_fatherObject(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.fatherObject);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00066714 File Offset: 0x00064914
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_actionObj(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.actionObj);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00066788 File Offset: 0x00064988
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_DamageFilter(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.DamageFilter);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000667FC File Offset: 0x000649FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_effectList(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.effectList);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00066870 File Offset: 0x00064A70
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_InstanceId(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.InstanceId);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000668E0 File Offset: 0x00064AE0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_MirrorSc(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.PushAny(L, gen_to_be_invoked.MirrorSc);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00066954 File Offset: 0x00064B54
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_MaxHp(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.MaxHp);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x000669C4 File Offset: 0x00064BC4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ToughOrigin(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.ToughOrigin);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00066A34 File Offset: 0x00064C34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ToughCount(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.ToughCount);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00066AA4 File Offset: 0x00064CA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_CurHp(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.CurHp);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00066B14 File Offset: 0x00064D14
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Defend(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.Defend);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00066B84 File Offset: 0x00064D84
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_dynamicVariables(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.dynamicVariables);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00066BF8 File Offset: 0x00064DF8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_dynamicVariablesLog(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.dynamicVariablesLog);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00066C6C File Offset: 0x00064E6C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get__animatedState(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked._animatedState);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00066CE4 File Offset: 0x00064EE4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Summon(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.Summon);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00066D58 File Offset: 0x00064F58
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get__NetEnqueue(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked._NetEnqueue);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00066DC8 File Offset: 0x00064FC8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_selfUI(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.selfUI);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00066E3C File Offset: 0x0006503C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_statusBarObj(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.statusBarObj);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00066EB0 File Offset: 0x000650B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_actionText(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.actionText);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00066F24 File Offset: 0x00065124
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_statusBarUI(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.statusBarUI);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00066F98 File Offset: 0x00065198
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_actionContent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.actionContent);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0006700C File Offset: 0x0006520C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_effectListObj(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.effectListObj);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00067080 File Offset: 0x00065280
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_initPos(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.initPos);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000670F4 File Offset: 0x000652F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_MiDataConfig(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.MiDataConfig);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00067168 File Offset: 0x00065368
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_maxHp(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.maxHp);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000671D8 File Offset: 0x000653D8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get__toughCount(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked._toughCount);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00067248 File Offset: 0x00065448
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_curHp(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.curHp);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000672B8 File Offset: 0x000654B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_defend(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.defend);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00067328 File Offset: 0x00065528
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_isResurrecting(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.isResurrecting);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00067398 File Offset: 0x00065598
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_animatedState(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				IStatusManager.AnimatedState gen_value;
				translator.Get<IStatusManager.AnimatedState>(L, 2, out gen_value);
				gen_to_be_invoked.animatedState = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00067414 File Offset: 0x00065614
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_state(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				IStatusManager.State gen_value;
				translator.Get<IStatusManager.State>(L, 2, out gen_value);
				gen_to_be_invoked.state = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00067490 File Offset: 0x00065690
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_fatherObject(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.fatherObject = (FightObject)translator.GetObject(L, 2, typeof(FightObject));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00067514 File Offset: 0x00065714
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_actionObj(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.actionObj = (GameObject[])translator.GetObject(L, 2, typeof(GameObject[]));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00067598 File Offset: 0x00065798
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_DamageFilter(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.DamageFilter = (Dictionary<string, float>)translator.GetObject(L, 2, typeof(Dictionary<string, float>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0006761C File Offset: 0x0006581C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_effectList(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.effectList = (List<IDataConfig>)translator.GetObject(L, 2, typeof(List<IDataConfig>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000676A0 File Offset: 0x000658A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_MaxHp(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.MaxHp = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00067714 File Offset: 0x00065914
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_ToughOrigin(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ToughOrigin = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00067788 File Offset: 0x00065988
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_ToughCount(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ToughCount = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000677FC File Offset: 0x000659FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_CurHp(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.CurHp = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00067870 File Offset: 0x00065A70
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Defend(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Defend = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000678E4 File Offset: 0x00065AE4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_dynamicVariables(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.dynamicVariables = (Dictionary<string, float>)translator.GetObject(L, 2, typeof(Dictionary<string, float>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00067968 File Offset: 0x00065B68
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set__animatedState(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				IStatusManager.AnimatedState gen_value;
				translator.Get<IStatusManager.AnimatedState>(L, 2, out gen_value);
				gen_to_be_invoked._animatedState = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000679E0 File Offset: 0x00065BE0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Summon(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Summon = (List<SummonObject>)translator.GetObject(L, 2, typeof(List<SummonObject>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00067A60 File Offset: 0x00065C60
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set__NetEnqueue(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked._NetEnqueue = Lua.lua_toboolean(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00067AD0 File Offset: 0x00065CD0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_selfUI(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.selfUI = (GameObject)translator.GetObject(L, 2, typeof(GameObject));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00067B50 File Offset: 0x00065D50
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_statusBarObj(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.statusBarObj = (GameObject)translator.GetObject(L, 2, typeof(GameObject));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00067BD0 File Offset: 0x00065DD0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_actionText(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.actionText = (KeywordDisplay[])translator.GetObject(L, 2, typeof(KeywordDisplay[]));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00067C50 File Offset: 0x00065E50
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_statusBarUI(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.statusBarUI = (StatusBarUI)translator.GetObject(L, 2, typeof(StatusBarUI));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00067CD0 File Offset: 0x00065ED0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_actionContent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.actionContent = (GameObject)translator.GetObject(L, 2, typeof(GameObject));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00067D50 File Offset: 0x00065F50
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_effectListObj(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.effectListObj = (GameObject)translator.GetObject(L, 2, typeof(GameObject));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00067DD0 File Offset: 0x00065FD0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_initPos(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.initPos = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00067E48 File Offset: 0x00066048
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_MiDataConfig(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.MiDataConfig = (DataConfig)translator.GetObject(L, 2, typeof(DataConfig));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00067EC8 File Offset: 0x000660C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_maxHp(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.maxHp = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00067F38 File Offset: 0x00066138
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set__toughCount(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked._toughCount = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00067FA8 File Offset: 0x000661A8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_curHp(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.curHp = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00068018 File Offset: 0x00066218
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_defend(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.defend = Lua.xlua_tointeger(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00068088 File Offset: 0x00066288
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_isResurrecting(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				StatusManager gen_to_be_invoked = (StatusManager)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.isResurrecting = Lua.lua_toboolean(L, 2);
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

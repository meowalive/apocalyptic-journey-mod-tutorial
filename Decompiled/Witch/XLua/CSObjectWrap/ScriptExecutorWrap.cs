using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cysharp.Threading.Tasks;
using Microsoft.CodeAnalysis.Scripting;
using XLua.LuaDLL;
using ZLinq;
using ZLinq.Linq;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001A5 RID: 421
	public class ScriptExecutorWrap
	{
		// Token: 0x06000C99 RID: 3225 RVA: 0x0005FCB4 File Offset: 0x0005DEB4
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(ScriptExecutor);
			Utils.BeginObjectRegister(type, L, translator, 0, 86, 15, 8, -1);
			Utils.RegisterFunc(L, -3, "SetHp", new lua_CSFunction(ScriptExecutorWrap._m_SetHp));
			Utils.RegisterFunc(L, -3, "SetMaxHp", new lua_CSFunction(ScriptExecutorWrap._m_SetMaxHp));
			Utils.RegisterFunc(L, -3, "ChangeHp", new lua_CSFunction(ScriptExecutorWrap._m_ChangeHp));
			Utils.RegisterFunc(L, -3, "ChangeMaxHp", new lua_CSFunction(ScriptExecutorWrap._m_ChangeMaxHp));
			Utils.RegisterFunc(L, -3, "AddBuff", new lua_CSFunction(ScriptExecutorWrap._m_AddBuff));
			Utils.RegisterFunc(L, -3, "RemoveBuff", new lua_CSFunction(ScriptExecutorWrap._m_RemoveBuff));
			Utils.RegisterFunc(L, -3, "RunImmediately", new lua_CSFunction(ScriptExecutorWrap._m_RunImmediately));
			Utils.RegisterFunc(L, -3, "Resurrection", new lua_CSFunction(ScriptExecutorWrap._m_Resurrection));
			Utils.RegisterFunc(L, -3, "ChangeDefence", new lua_CSFunction(ScriptExecutorWrap._m_ChangeDefence));
			Utils.RegisterFunc(L, -3, "SetPower", new lua_CSFunction(ScriptExecutorWrap._m_SetPower));
			Utils.RegisterFunc(L, -3, "ChangeMaxPower", new lua_CSFunction(ScriptExecutorWrap._m_ChangeMaxPower));
			Utils.RegisterFunc(L, -3, "ChangeRound", new lua_CSFunction(ScriptExecutorWrap._m_ChangeRound));
			Utils.RegisterFunc(L, -3, "DoAction", new lua_CSFunction(ScriptExecutorWrap._m_DoAction));
			Utils.RegisterFunc(L, -3, "RemoveBadBuff", new lua_CSFunction(ScriptExecutorWrap._m_RemoveBadBuff));
			Utils.RegisterFunc(L, -3, "RemoveAllBadBuff", new lua_CSFunction(ScriptExecutorWrap._m_RemoveAllBadBuff));
			Utils.RegisterFunc(L, -3, "RemoveAllBuff", new lua_CSFunction(ScriptExecutorWrap._m_RemoveAllBuff));
			Utils.RegisterFunc(L, -3, "AddCardByCardList", new lua_CSFunction(ScriptExecutorWrap._m_AddCardByCardList));
			Utils.RegisterFunc(L, -3, "AddCardByUsedCardList", new lua_CSFunction(ScriptExecutorWrap._m_AddCardByUsedCardList));
			Utils.RegisterFunc(L, -3, "RandomAddCard", new lua_CSFunction(ScriptExecutorWrap._m_RandomAddCard));
			Utils.RegisterFunc(L, -3, "ChangeMoney", new lua_CSFunction(ScriptExecutorWrap._m_ChangeMoney));
			Utils.RegisterFunc(L, -3, "AddAction", new lua_CSFunction(ScriptExecutorWrap._m_AddAction));
			Utils.RegisterFunc(L, -3, "ShuffleDeck", new lua_CSFunction(ScriptExecutorWrap._m_ShuffleDeck));
			Utils.RegisterFunc(L, -3, "ChangeCardTop", new lua_CSFunction(ScriptExecutorWrap._m_ChangeCardTop));
			Utils.RegisterFunc(L, -3, "GetCardByTag", new lua_CSFunction(ScriptExecutorWrap._m_GetCardByTag));
			Utils.RegisterFunc(L, -3, "AddCard", new lua_CSFunction(ScriptExecutorWrap._m_AddCard));
			Utils.RegisterFunc(L, -3, "ChangeCareer", new lua_CSFunction(ScriptExecutorWrap._m_ChangeCareer));
			Utils.RegisterFunc(L, -3, "AddEvent", new lua_CSFunction(ScriptExecutorWrap._m_AddEvent));
			Utils.RegisterFunc(L, -3, "AddTempEvent", new lua_CSFunction(ScriptExecutorWrap._m_AddTempEvent));
			Utils.RegisterFunc(L, -3, "ChangeDynamicVar", new lua_CSFunction(ScriptExecutorWrap._m_ChangeDynamicVar));
			Utils.RegisterFunc(L, -3, "ChangeDynamicVarPercent", new lua_CSFunction(ScriptExecutorWrap._m_ChangeDynamicVarPercent));
			Utils.RegisterFunc(L, -3, "Undone", new lua_CSFunction(ScriptExecutorWrap._m_Undone));
			Utils.RegisterFunc(L, -3, "DesEnemyAction", new lua_CSFunction(ScriptExecutorWrap._m_DesEnemyAction));
			Utils.RegisterFunc(L, -3, "returnFightType", new lua_CSFunction(ScriptExecutorWrap._m_returnFightType));
			Utils.RegisterFunc(L, -3, "BurnCardByData", new lua_CSFunction(ScriptExecutorWrap._m_BurnCardByData));
			Utils.RegisterFunc(L, -3, "UpdateRelicShow", new lua_CSFunction(ScriptExecutorWrap._m_UpdateRelicShow));
			Utils.RegisterFunc(L, -3, "ComboCheck", new lua_CSFunction(ScriptExecutorWrap._m_ComboCheck));
			Utils.RegisterFunc(L, -3, "EndTheGame", new lua_CSFunction(ScriptExecutorWrap._m_EndTheGame));
			Utils.RegisterFunc(L, -3, "EscapeFight", new lua_CSFunction(ScriptExecutorWrap._m_EscapeFight));
			Utils.RegisterFunc(L, -3, "WinTheFight", new lua_CSFunction(ScriptExecutorWrap._m_WinTheFight));
			Utils.RegisterFunc(L, -3, "ChangeType", new lua_CSFunction(ScriptExecutorWrap._m_ChangeType));
			Utils.RegisterFunc(L, -3, "RandomAddBuff", new lua_CSFunction(ScriptExecutorWrap._m_RandomAddBuff));
			Utils.RegisterFunc(L, -3, "RandomAddBuffAndAbility", new lua_CSFunction(ScriptExecutorWrap._m_RandomAddBuffAndAbility));
			Utils.RegisterFunc(L, -3, "RandomAddGoodBuff", new lua_CSFunction(ScriptExecutorWrap._m_RandomAddGoodBuff));
			Utils.RegisterFunc(L, -3, "AddEnemy", new lua_CSFunction(ScriptExecutorWrap._m_AddEnemy));
			Utils.RegisterFunc(L, -3, "atk", new lua_CSFunction(ScriptExecutorWrap._m_atk));
			Utils.RegisterFunc(L, -3, "AddBaseEvent", new lua_CSFunction(ScriptExecutorWrap._m_AddBaseEvent));
			Utils.RegisterFunc(L, -3, "GetEnemy", new lua_CSFunction(ScriptExecutorWrap._m_GetEnemy));
			Utils.RegisterFunc(L, -3, "def", new lua_CSFunction(ScriptExecutorWrap._m_def));
			Utils.RegisterFunc(L, -3, "CallEffect", new lua_CSFunction(ScriptExecutorWrap._m_CallEffect));
			Utils.RegisterFunc(L, -3, "OnlineDamage", new lua_CSFunction(ScriptExecutorWrap._m_OnlineDamage));
			Utils.RegisterFunc(L, -3, "Damage", new lua_CSFunction(ScriptExecutorWrap._m_Damage));
			Utils.RegisterFunc(L, -3, "ChangeVars", new lua_CSFunction(ScriptExecutorWrap._m_ChangeVars));
			Utils.RegisterFunc(L, -3, "DrawCount", new lua_CSFunction(ScriptExecutorWrap._m_DrawCount));
			Utils.RegisterFunc(L, -3, "ChangePower", new lua_CSFunction(ScriptExecutorWrap._m_ChangePower));
			Utils.RegisterFunc(L, -3, "ThrowCard", new lua_CSFunction(ScriptExecutorWrap._m_ThrowCard));
			Utils.RegisterFunc(L, -3, "BurnCard", new lua_CSFunction(ScriptExecutorWrap._m_BurnCard));
			Utils.RegisterFunc(L, -3, "GetcardsByRarity", new lua_CSFunction(ScriptExecutorWrap._m_GetcardsByRarity));
			Utils.RegisterFunc(L, -3, "EnchGetCard", new lua_CSFunction(ScriptExecutorWrap._m_EnchGetCard));
			Utils.RegisterFunc(L, -3, "CardGetEnch", new lua_CSFunction(ScriptExecutorWrap._m_CardGetEnch));
			Utils.RegisterFunc(L, -3, "AddCardByDeck", new lua_CSFunction(ScriptExecutorWrap._m_AddCardByDeck));
			Utils.RegisterFunc(L, -3, "SelectCardAndAddTag", new lua_CSFunction(ScriptExecutorWrap._m_SelectCardAndAddTag));
			Utils.RegisterFunc(L, -3, "AddCardById", new lua_CSFunction(ScriptExecutorWrap._m_AddCardById));
			Utils.RegisterFunc(L, -3, "SetStatusById", new lua_CSFunction(ScriptExecutorWrap._m_SetStatusById));
			Utils.RegisterFunc(L, -3, "SetStatus", new lua_CSFunction(ScriptExecutorWrap._m_SetStatus));
			Utils.RegisterFunc(L, -3, "ProcessEffect", new lua_CSFunction(ScriptExecutorWrap._m_ProcessEffect));
			Utils.RegisterFunc(L, -3, "DiceCheck", new lua_CSFunction(ScriptExecutorWrap._m_DiceCheck));
			Utils.RegisterFunc(L, -3, "ForAllStatus", new lua_CSFunction(ScriptExecutorWrap._m_ForAllStatus));
			Utils.RegisterFunc(L, -3, "Log", new lua_CSFunction(ScriptExecutorWrap._m_Log));
			Utils.RegisterFunc(L, -3, "WatchRoleTable", new lua_CSFunction(ScriptExecutorWrap._m_WatchRoleTable));
			Utils.RegisterFunc(L, -3, "AddDescription", new lua_CSFunction(ScriptExecutorWrap._m_AddDescription));
			Utils.RegisterFunc(L, -3, "GetDesValue", new lua_CSFunction(ScriptExecutorWrap._m_GetDesValue));
			Utils.RegisterFunc(L, -3, "CallScript", new lua_CSFunction(ScriptExecutorWrap._m_CallScript));
			Utils.RegisterFunc(L, -3, "PreCompileScripts", new lua_CSFunction(ScriptExecutorWrap._m_PreCompileScripts));
			Utils.RegisterFunc(L, -3, "RunScript", new lua_CSFunction(ScriptExecutorWrap._m_RunScript));
			Utils.RegisterFunc(L, -3, "Clear", new lua_CSFunction(ScriptExecutorWrap._m_Clear));
			Utils.RegisterFunc(L, -3, "TrySendOnlineEvent", new lua_CSFunction(ScriptExecutorWrap._m_TrySendOnlineEvent));
			Utils.RegisterFunc(L, -3, "AddEvent_HurtData", new lua_CSFunction(ScriptExecutorWrap._m_AddEvent_HurtData));
			Utils.RegisterFunc(L, -3, "AddTempEvent_HurtData", new lua_CSFunction(ScriptExecutorWrap._m_AddTempEvent_HurtData));
			Utils.RegisterFunc(L, -3, "AddEvent_ActionData", new lua_CSFunction(ScriptExecutorWrap._m_AddEvent_ActionData));
			Utils.RegisterFunc(L, -3, "AddTempEvent_ActionData", new lua_CSFunction(ScriptExecutorWrap._m_AddTempEvent_ActionData));
			Utils.RegisterFunc(L, -3, "AddEvent_DamageData", new lua_CSFunction(ScriptExecutorWrap._m_AddEvent_DamageData));
			Utils.RegisterFunc(L, -3, "AddTempEvent_DamageData", new lua_CSFunction(ScriptExecutorWrap._m_AddTempEvent_DamageData));
			Utils.RegisterFunc(L, -3, "AddEvent_NewEnemyData", new lua_CSFunction(ScriptExecutorWrap._m_AddEvent_NewEnemyData));
			Utils.RegisterFunc(L, -3, "AddTempEvent_NewEnemyData", new lua_CSFunction(ScriptExecutorWrap._m_AddTempEvent_NewEnemyData));
			Utils.RegisterFunc(L, -3, "AddEvent_ScriptExecuteData", new lua_CSFunction(ScriptExecutorWrap._m_AddEvent_ScriptExecuteData));
			Utils.RegisterFunc(L, -3, "AddTempEvent_ScriptExecuteData", new lua_CSFunction(ScriptExecutorWrap._m_AddTempEvent_ScriptExecuteData));
			Utils.RegisterFunc(L, -2, "status", new lua_CSFunction(ScriptExecutorWrap._g_get_status));
			Utils.RegisterFunc(L, -2, "Self", new lua_CSFunction(ScriptExecutorWrap._g_get_Self));
			Utils.RegisterFunc(L, -2, "Object", new lua_CSFunction(ScriptExecutorWrap._g_get_Object));
			Utils.RegisterFunc(L, -2, "dataConfig", new lua_CSFunction(ScriptExecutorWrap._g_get_dataConfig));
			Utils.RegisterFunc(L, -2, "Target", new lua_CSFunction(ScriptExecutorWrap._g_get_Target));
			Utils.RegisterFunc(L, -2, "ScriptDict", new lua_CSFunction(ScriptExecutorWrap._g_get_ScriptDict));
			Utils.RegisterFunc(L, -2, "Id", new lua_CSFunction(ScriptExecutorWrap._g_get_Id));
			Utils.RegisterFunc(L, -2, "ValueDice", new lua_CSFunction(ScriptExecutorWrap._g_get_ValueDice));
			Utils.RegisterFunc(L, -2, "CheckDice", new lua_CSFunction(ScriptExecutorWrap._g_get_CheckDice));
			Utils.RegisterFunc(L, -2, "DefaultDice", new lua_CSFunction(ScriptExecutorWrap._g_get_DefaultDice));
			Utils.RegisterFunc(L, -2, "Vars", new lua_CSFunction(ScriptExecutorWrap._g_get_Vars));
			Utils.RegisterFunc(L, -2, "HandCard", new lua_CSFunction(ScriptExecutorWrap._g_get_HandCard));
			Utils.RegisterFunc(L, -2, "CompiledSuccessfully", new lua_CSFunction(ScriptExecutorWrap._g_get_CompiledSuccessfully));
			Utils.RegisterFunc(L, -2, "GetStatus", new lua_CSFunction(ScriptExecutorWrap._g_get_GetStatus));
			Utils.RegisterFunc(L, -2, "handlers", new lua_CSFunction(ScriptExecutorWrap._g_get_handlers));
			Utils.RegisterFunc(L, -1, "status", new lua_CSFunction(ScriptExecutorWrap._s_set_status));
			Utils.RegisterFunc(L, -1, "Self", new lua_CSFunction(ScriptExecutorWrap._s_set_Self));
			Utils.RegisterFunc(L, -1, "Object", new lua_CSFunction(ScriptExecutorWrap._s_set_Object));
			Utils.RegisterFunc(L, -1, "dataConfig", new lua_CSFunction(ScriptExecutorWrap._s_set_dataConfig));
			Utils.RegisterFunc(L, -1, "Target", new lua_CSFunction(ScriptExecutorWrap._s_set_Target));
			Utils.RegisterFunc(L, -1, "ScriptDict", new lua_CSFunction(ScriptExecutorWrap._s_set_ScriptDict));
			Utils.RegisterFunc(L, -1, "GetStatus", new lua_CSFunction(ScriptExecutorWrap._s_set_GetStatus));
			Utils.RegisterFunc(L, -1, "handlers", new lua_CSFunction(ScriptExecutorWrap._s_set_handlers));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(ScriptExecutorWrap.__CreateInstance), 1, 2, 2);
			Utils.RegisterFunc(L, -2, "luaEnv", new lua_CSFunction(ScriptExecutorWrap._g_get_luaEnv));
			Utils.RegisterFunc(L, -2, "luaTable", new lua_CSFunction(ScriptExecutorWrap._g_get_luaTable));
			Utils.RegisterFunc(L, -1, "luaEnv", new lua_CSFunction(ScriptExecutorWrap._s_set_luaEnv));
			Utils.RegisterFunc(L, -1, "luaTable", new lua_CSFunction(ScriptExecutorWrap._s_set_luaTable));
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00060888 File Offset: 0x0005EA88
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return Lua.luaL_error(L, "ScriptExecutor does not have a constructor!");
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000608A8 File Offset: 0x0005EAA8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetHp(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.SetHp(_val);
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

		// Token: 0x06000C9C RID: 3228 RVA: 0x0006091C File Offset: 0x0005EB1C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetMaxHp(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.SetMaxHp(_val);
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

		// Token: 0x06000C9D RID: 3229 RVA: 0x00060990 File Offset: 0x0005EB90
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeHp(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.ChangeHp(_val);
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

		// Token: 0x06000C9E RID: 3230 RVA: 0x00060A04 File Offset: 0x0005EC04
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeMaxHp(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.ChangeMaxHp(_val);
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

		// Token: 0x06000C9F RID: 3231 RVA: 0x00060A78 File Offset: 0x0005EC78
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _buffId = Lua.lua_tostring(L, 2);
				string _level = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.AddBuff(_buffId, _level);
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

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00060AF8 File Offset: 0x0005ECF8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _buffId = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.RemoveBuff(_buffId);
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

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00060B6C File Offset: 0x0005ED6C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RunImmediately(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _buffId = Lua.lua_tostring(L, 2);
				string _eventName = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.RunImmediately(_buffId, _eventName);
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

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00060BEC File Offset: 0x0005EDEC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Resurrection(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _value = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.Resurrection(_value);
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

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00060C60 File Offset: 0x0005EE60
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeDefence(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.ChangeDefence(_val);
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

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00060CD4 File Offset: 0x0005EED4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetPower(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.SetPower(_val);
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

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00060D48 File Offset: 0x0005EF48
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeMaxPower(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.ChangeMaxPower(_val);
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

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00060DBC File Offset: 0x0005EFBC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeRound(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ChangeRound();
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

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00060E24 File Offset: 0x0005F024
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DoAction(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _index = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.DoAction(_index);
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

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00060E98 File Offset: 0x0005F098
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveBadBuff(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _val = Lua.lua_tostring(L, 2);
					string _good = Lua.lua_tostring(L, 3);
					gen_to_be_invoked.RemoveBadBuff(_val, _good);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _val2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.RemoveBadBuff(_val2, "false");
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.RemoveBadBuff!");
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00060FA8 File Offset: 0x0005F1A8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveAllBadBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _obj = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.RemoveAllBadBuff(_obj);
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

		// Token: 0x06000CAA RID: 3242 RVA: 0x0006101C File Offset: 0x0005F21C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RemoveAllBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.RemoveAllBuff();
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

		// Token: 0x06000CAB RID: 3243 RVA: 0x00061084 File Offset: 0x0005F284
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddCardByCardList(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _count = Lua.lua_tostring(L, 2);
					string _tag = Lua.lua_tostring(L, 3);
					gen_to_be_invoked.AddCardByCardList(_count, _tag);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _count2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.AddCardByCardList(_count2, "all");
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.AddCardByCardList!");
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00061194 File Offset: 0x0005F394
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddCardByUsedCardList(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _count = Lua.lua_tostring(L, 2);
					string _tag = Lua.lua_tostring(L, 3);
					gen_to_be_invoked.AddCardByUsedCardList(_count, _tag);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _count2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.AddCardByUsedCardList(_count2, "all");
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.AddCardByUsedCardList!");
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000612A4 File Offset: 0x0005F4A4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RandomAddCard(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _id = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.RandomAddCard(_id);
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

		// Token: 0x06000CAE RID: 3246 RVA: 0x00061318 File Offset: 0x0005F518
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeMoney(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.ChangeMoney(_val);
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

		// Token: 0x06000CAF RID: 3247 RVA: 0x0006138C File Offset: 0x0005F58C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddAction(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _count = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.AddAction(_count);
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

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00061400 File Offset: 0x0005F600
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ShuffleDeck(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ShuffleDeck();
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

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00061468 File Offset: 0x0005F668
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeCardTop(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.ChangeCardTop(_val);
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

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000614DC File Offset: 0x0005F6DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetCardByTag(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _count = Lua.lua_tostring(L, 2);
					string _tag = Lua.lua_tostring(L, 3);
					gen_to_be_invoked.GetCardByTag(_count, _tag);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _count2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.GetCardByTag(_count2, "all");
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.GetCardByTag!");
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000615EC File Offset: 0x0005F7EC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddCard(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _id = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.AddCard(_id);
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

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00061660 File Offset: 0x0005F860
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeCareer(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _Id = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.ChangeCareer(_Id);
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

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000616D4 File Offset: 0x0005F8D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddEvent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action _script = translator.GetDelegate<Action>(L, 3);
				gen_to_be_invoked.AddEvent(_eventName, _script);
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

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00061754 File Offset: 0x0005F954
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddTempEvent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action _script = translator.GetDelegate<Action>(L, 3);
				gen_to_be_invoked.AddTempEvent(_eventName, _script);
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

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000617D4 File Offset: 0x0005F9D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeDynamicVar(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _varName = Lua.lua_tostring(L, 2);
				string _value = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.ChangeDynamicVar(_varName, _value);
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

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00061854 File Offset: 0x0005FA54
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeDynamicVarPercent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _varName = Lua.lua_tostring(L, 2);
				string _value = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.ChangeDynamicVarPercent(_varName, _value);
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

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000618D4 File Offset: 0x0005FAD4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Undone(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				object[] _args = translator.GetParams<object>(L, 2);
				gen_to_be_invoked.Undone(_args);
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

		// Token: 0x06000CBA RID: 3258 RVA: 0x00061948 File Offset: 0x0005FB48
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DesEnemyAction(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.DesEnemyAction();
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

		// Token: 0x06000CBB RID: 3259 RVA: 0x000619B0 File Offset: 0x0005FBB0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_returnFightType(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				FightType gen_ret = gen_to_be_invoked.returnFightType();
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

		// Token: 0x06000CBC RID: 3260 RVA: 0x00061A28 File Offset: 0x0005FC28
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_BurnCardByData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				IDataConfig _fromdata = (IDataConfig)translator.GetObject(L, 2, typeof(IDataConfig));
				gen_to_be_invoked.BurnCardByData(_fromdata);
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

		// Token: 0x06000CBD RID: 3261 RVA: 0x00061AAC File Offset: 0x0005FCAC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateRelicShow(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.UpdateRelicShow();
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

		// Token: 0x06000CBE RID: 3262 RVA: 0x00061B14 File Offset: 0x0005FD14
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ComboCheck(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				bool gen_ret = gen_to_be_invoked.ComboCheck();
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

		// Token: 0x06000CBF RID: 3263 RVA: 0x00061B88 File Offset: 0x0005FD88
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_EndTheGame(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.EndTheGame();
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

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00061BF0 File Offset: 0x0005FDF0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_EscapeFight(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.EscapeFight();
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

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00061C58 File Offset: 0x0005FE58
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_WinTheFight(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.WinTheFight();
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

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00061CC0 File Offset: 0x0005FEC0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeType(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				FightType _type;
				translator.Get<FightType>(L, 2, out _type);
				gen_to_be_invoked.ChangeType(_type);
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

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00061D38 File Offset: 0x0005FF38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RandomAddBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _count = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.RandomAddBuff(_count);
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

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00061DAC File Offset: 0x0005FFAC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RandomAddBuffAndAbility(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _count = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.RandomAddBuffAndAbility(_count);
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

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00061E20 File Offset: 0x00060020
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RandomAddGoodBuff(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.RandomAddGoodBuff();
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

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00061E88 File Offset: 0x00060088
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddEnemy(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _id = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.AddEnemy(_id);
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

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00061EFC File Offset: 0x000600FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_atk(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string gen_ret = gen_to_be_invoked.atk();
				Lua.lua_pushstring(L, gen_ret);
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

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00061F70 File Offset: 0x00060170
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddBaseEvent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action _action = translator.GetDelegate<Action>(L, 3);
				gen_to_be_invoked.AddBaseEvent(_eventName, _action);
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

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00061FF0 File Offset: 0x000601F0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetEnemy(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				IStatusManager _status = (IStatusManager)translator.GetObject(L, 2, typeof(IStatusManager));
				Enemy gen_ret = gen_to_be_invoked.GetEnemy(_status);
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

		// Token: 0x06000CCA RID: 3274 RVA: 0x00062080 File Offset: 0x00060280
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_def(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string gen_ret = gen_to_be_invoked.def();
				Lua.lua_pushstring(L, gen_ret);
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

		// Token: 0x06000CCB RID: 3275 RVA: 0x000620F4 File Offset: 0x000602F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CallEffect(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.CallEffect();
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

		// Token: 0x06000CCC RID: 3276 RVA: 0x0006215C File Offset: 0x0006035C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnlineDamage(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 5 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 4) || Lua.lua_type(L, 4) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 5) || Lua.lua_type(L, 5) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _val = Lua.lua_tostring(L, 2);
					string _fromDataId = Lua.lua_tostring(L, 3);
					string _fromId = Lua.lua_tostring(L, 4);
					string _damagetype = Lua.lua_tostring(L, 5);
					gen_to_be_invoked.OnlineDamage(_val, _fromDataId, _fromId, _damagetype);
					return 0;
				}
				bool flag2 = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 4) || Lua.lua_type(L, 4) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _val2 = Lua.lua_tostring(L, 2);
					string _fromDataId2 = Lua.lua_tostring(L, 3);
					string _fromId2 = Lua.lua_tostring(L, 4);
					gen_to_be_invoked.OnlineDamage(_val2, _fromDataId2, _fromId2, "Normal");
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.OnlineDamage!");
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000622F4 File Offset: 0x000604F4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Damage(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _val = Lua.lua_tostring(L, 2);
					string _damagetype = Lua.lua_tostring(L, 3);
					gen_to_be_invoked.Damage(_val, _damagetype);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _val2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.Damage(_val2, "Normal");
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.Damage!");
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00062404 File Offset: 0x00060604
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangeVars(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _type = Lua.lua_tostring(L, 2);
				string _val = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.ChangeVars(_type, _val);
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

		// Token: 0x06000CCF RID: 3279 RVA: 0x00062484 File Offset: 0x00060684
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DrawCount(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.DrawCount(_val);
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

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000624F8 File Offset: 0x000606F8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ChangePower(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _val = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.ChangePower(_val);
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

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0006256C File Offset: 0x0006076C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ThrowCard(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _val = Lua.lua_tostring(L, 2);
					string _type = Lua.lua_tostring(L, 3);
					gen_to_be_invoked.ThrowCard(_val, _type);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _val2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.ThrowCard(_val2, "1");
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.ThrowCard!");
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0006267C File Offset: 0x0006087C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_BurnCard(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _val = Lua.lua_tostring(L, 2);
					string _type = Lua.lua_tostring(L, 3);
					gen_to_be_invoked.BurnCard(_val, _type);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _val2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.BurnCard(_val2, "1");
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.BurnCard!");
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0006278C File Offset: 0x0006098C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetcardsByRarity(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _Minrarity = Lua.lua_tostring(L, 2);
				string _Maxrairty = Lua.lua_tostring(L, 3);
				List<Dictionary<string, string>> gen_ret = gen_to_be_invoked.GetcardsByRarity(_Minrarity, _Maxrairty);
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

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00062818 File Offset: 0x00060A18
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_EnchGetCard(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				DataConfig gen_ret = gen_to_be_invoked.EnchGetCard();
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

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0006288C File Offset: 0x00060A8C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CardGetEnch(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				IDataConfig _card = (IDataConfig)translator.GetObject(L, 2, typeof(IDataConfig));
				DataConfig gen_ret = gen_to_be_invoked.CardGetEnch(_card);
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

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0006291C File Offset: 0x00060B1C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddCardByDeck(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<List<IDataConfig>>(L, 3) && (Lua.lua_isnil(L, 4) || Lua.lua_type(L, 4) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _count = Lua.lua_tostring(L, 2);
					List<IDataConfig> _source = (List<IDataConfig>)translator.GetObject(L, 3, typeof(List<IDataConfig>));
					string _tag = Lua.lua_tostring(L, 4);
					UniTask gen_ret = gen_to_be_invoked.AddCardByDeck(_count, _source, _tag);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<List<IDataConfig>>(L, 3);
				if (flag2)
				{
					string _count2 = Lua.lua_tostring(L, 2);
					List<IDataConfig> _source2 = (List<IDataConfig>)translator.GetObject(L, 3, typeof(List<IDataConfig>));
					UniTask gen_ret2 = gen_to_be_invoked.AddCardByDeck(_count2, _source2, "all");
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
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.AddCardByDeck!");
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00062AA0 File Offset: 0x00060CA0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SelectCardAndAddTag(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _count = Lua.lua_tostring(L, 2);
				List<IDataConfig> _source = (List<IDataConfig>)translator.GetObject(L, 3, typeof(List<IDataConfig>));
				gen_to_be_invoked.SelectCardAndAddTag(_count, _source);
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

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00062B30 File Offset: 0x00060D30
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddCardById(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _id = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.AddCardById(_id);
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

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00062BA4 File Offset: 0x00060DA4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetStatusById(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _searchId = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.SetStatusById(_searchId);
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

		// Token: 0x06000CDA RID: 3290 RVA: 0x00062C18 File Offset: 0x00060E18
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetStatus(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag)
				{
					string _filter = Lua.lua_tostring(L, 2);
					List<IStatusManager> gen_ret = gen_to_be_invoked.SetStatus(_filter);
					translator.Push(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<IEnumerable<IStatusManager>>(L, 2);
				if (flag2)
				{
					IEnumerable<IStatusManager> _statuses = (IEnumerable<IStatusManager>)translator.GetObject(L, 2, typeof(IEnumerable<IStatusManager>));
					List<IStatusManager> gen_ret2 = gen_to_be_invoked.SetStatus(_statuses);
					translator.Push(L, gen_ret2);
					return 1;
				}
				bool flag3 = gen_param_count == 2 && translator.Assignable<ValueEnumerable<FromEnumerable<IStatusManager>, IStatusManager>>(L, 2);
				if (flag3)
				{
					ValueEnumerable<FromEnumerable<IStatusManager>, IStatusManager> _statuses2;
					translator.Get<ValueEnumerable<FromEnumerable<IStatusManager>, IStatusManager>>(L, 2, out _statuses2);
					List<IStatusManager> gen_ret3 = gen_to_be_invoked.SetStatus(_statuses2);
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
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.SetStatus!");
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00062D5C File Offset: 0x00060F5C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ProcessEffect(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				IStatusManager _status = (IStatusManager)translator.GetObject(L, 2, typeof(IStatusManager));
				string _effectName = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.ProcessEffect(_status, _effectName);
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

		// Token: 0x06000CDC RID: 3292 RVA: 0x00062DEC File Offset: 0x00060FEC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DiceCheck(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int _percent = Lua.xlua_tointeger(L, 2);
				Action<bool> _action = translator.GetDelegate<Action<bool>>(L, 3);
				gen_to_be_invoked.DiceCheck(_percent, _action);
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

		// Token: 0x06000CDD RID: 3293 RVA: 0x00062E6C File Offset: 0x0006106C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ForAllStatus(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				Action<IStatusManager> _action = translator.GetDelegate<Action<IStatusManager>>(L, 2);
				gen_to_be_invoked.ForAllStatus(_action);
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

		// Token: 0x06000CDE RID: 3294 RVA: 0x00062EE0 File Offset: 0x000610E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Log(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _content = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.Log(_content);
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

		// Token: 0x06000CDF RID: 3295 RVA: 0x00062F54 File Offset: 0x00061154
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_WatchRoleTable(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<Action>(L, 3);
				if (flag)
				{
					string _propertyName = Lua.lua_tostring(L, 2);
					Action _action = translator.GetDelegate<Action>(L, 3);
					gen_to_be_invoked.WatchRoleTable(_propertyName, _action);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<Action<int>>(L, 3);
				if (flag2)
				{
					string _propertyName2 = Lua.lua_tostring(L, 2);
					Action<int> _action2 = translator.GetDelegate<Action<int>>(L, 3);
					gen_to_be_invoked.WatchRoleTable(_propertyName2, _action2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.WatchRoleTable!");
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00063068 File Offset: 0x00061268
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddDescription(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					string _index = Lua.lua_tostring(L, 2);
					string _type = Lua.lua_tostring(L, 3);
					int _value = Lua.xlua_tointeger(L, 4);
					gen_to_be_invoked.AddDescription(_index, _type, _value);
					return 0;
				}
				bool flag2 = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag2)
				{
					string _index2 = Lua.lua_tostring(L, 2);
					string _type2 = Lua.lua_tostring(L, 3);
					float _value2 = (float)Lua.lua_tonumber(L, 4);
					gen_to_be_invoked.AddDescription(_index2, _type2, _value2);
					return 0;
				}
				bool flag3 = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag3)
				{
					string _index3 = Lua.lua_tostring(L, 2);
					string _type3 = Lua.lua_tostring(L, 3);
					double _value3 = Lua.lua_tonumber(L, 4);
					gen_to_be_invoked.AddDescription(_index3, _type3, _value3);
					return 0;
				}
				bool flag4 = gen_param_count == 4 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 3) || Lua.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && (Lua.lua_isnil(L, 4) || Lua.lua_type(L, 4) == LuaTypes.LUA_TSTRING);
				if (flag4)
				{
					string _index4 = Lua.lua_tostring(L, 2);
					string _type4 = Lua.lua_tostring(L, 3);
					string _value4 = Lua.lua_tostring(L, 4);
					gen_to_be_invoked.AddDescription(_index4, _type4, _value4);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.AddDescription!");
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000632B0 File Offset: 0x000614B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetDesValue(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _index = Lua.lua_tostring(L, 2);
				string gen_ret = gen_to_be_invoked.GetDesValue(_index);
				Lua.lua_pushstring(L, gen_ret);
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

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00063330 File Offset: 0x00061530
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CallScript(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _scriptId = Lua.lua_tostring(L, 2);
				string _scriptName = Lua.lua_tostring(L, 3);
				gen_to_be_invoked.CallScript(_scriptId, _scriptName);
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

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000633B0 File Offset: 0x000615B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PreCompileScripts(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 3 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<ScriptOptions>(L, 3);
				if (flag)
				{
					string _ScriptName = Lua.lua_tostring(L, 2);
					ScriptOptions _options = (ScriptOptions)translator.GetObject(L, 3, typeof(ScriptOptions));
					gen_to_be_invoked.PreCompileScripts(_ScriptName, _options);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && (Lua.lua_isnil(L, 2) || Lua.lua_type(L, 2) == LuaTypes.LUA_TSTRING);
				if (flag2)
				{
					string _ScriptName2 = Lua.lua_tostring(L, 2);
					gen_to_be_invoked.PreCompileScripts(_ScriptName2, null);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to ScriptExecutor.PreCompileScripts!");
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000634C0 File Offset: 0x000616C0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RunScript(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _ScriptsName = Lua.lua_tostring(L, 2);
				gen_to_be_invoked.RunScript(_ScriptsName);
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

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00063534 File Offset: 0x00061734
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Clear(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Clear();
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

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0006359C File Offset: 0x0006179C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TrySendOnlineEvent(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				string[] _parameters = (string[])translator.GetObject(L, 3, typeof(string[]));
				bool gen_ret = gen_to_be_invoked.TrySendOnlineEvent(_eventName, _parameters);
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

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00063638 File Offset: 0x00061838
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddEvent_HurtData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<HurtData> _datafrom = translator.GetDelegate<Action<HurtData>>(L, 3);
				gen_to_be_invoked.AddEvent_HurtData(_eventName, _datafrom);
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

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000636B8 File Offset: 0x000618B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddTempEvent_HurtData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<HurtData> _datafrom = translator.GetDelegate<Action<HurtData>>(L, 3);
				gen_to_be_invoked.AddTempEvent_HurtData(_eventName, _datafrom);
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

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00063738 File Offset: 0x00061938
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddEvent_ActionData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<ActionData> _datafrom = translator.GetDelegate<Action<ActionData>>(L, 3);
				gen_to_be_invoked.AddEvent_ActionData(_eventName, _datafrom);
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

		// Token: 0x06000CEA RID: 3306 RVA: 0x000637B8 File Offset: 0x000619B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddTempEvent_ActionData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<ActionData> _datafrom = translator.GetDelegate<Action<ActionData>>(L, 3);
				gen_to_be_invoked.AddTempEvent_ActionData(_eventName, _datafrom);
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

		// Token: 0x06000CEB RID: 3307 RVA: 0x00063838 File Offset: 0x00061A38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddEvent_DamageData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<DamageData> _datafrom = translator.GetDelegate<Action<DamageData>>(L, 3);
				gen_to_be_invoked.AddEvent_DamageData(_eventName, _datafrom);
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

		// Token: 0x06000CEC RID: 3308 RVA: 0x000638B8 File Offset: 0x00061AB8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddTempEvent_DamageData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<DamageData> _datafrom = translator.GetDelegate<Action<DamageData>>(L, 3);
				gen_to_be_invoked.AddTempEvent_DamageData(_eventName, _datafrom);
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

		// Token: 0x06000CED RID: 3309 RVA: 0x00063938 File Offset: 0x00061B38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddEvent_NewEnemyData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<NewEnemyData> _datafrom = translator.GetDelegate<Action<NewEnemyData>>(L, 3);
				gen_to_be_invoked.AddEvent_NewEnemyData(_eventName, _datafrom);
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

		// Token: 0x06000CEE RID: 3310 RVA: 0x000639B8 File Offset: 0x00061BB8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddTempEvent_NewEnemyData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<NewEnemyData> _datafrom = translator.GetDelegate<Action<NewEnemyData>>(L, 3);
				gen_to_be_invoked.AddTempEvent_NewEnemyData(_eventName, _datafrom);
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

		// Token: 0x06000CEF RID: 3311 RVA: 0x00063A38 File Offset: 0x00061C38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddEvent_ScriptExecuteData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<ScriptExecuteData> _datafrom = translator.GetDelegate<Action<ScriptExecuteData>>(L, 3);
				gen_to_be_invoked.AddEvent_ScriptExecuteData(_eventName, _datafrom);
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

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00063AB8 File Offset: 0x00061CB8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_AddTempEvent_ScriptExecuteData(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				string _eventName = Lua.lua_tostring(L, 2);
				Action<ScriptExecuteData> _datafrom = translator.GetDelegate<Action<ScriptExecuteData>>(L, 3);
				gen_to_be_invoked.AddTempEvent_ScriptExecuteData(_eventName, _datafrom);
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

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00063B38 File Offset: 0x00061D38
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_status(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.PushAny(L, gen_to_be_invoked.status);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00063BAC File Offset: 0x00061DAC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Self(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.PushAny(L, gen_to_be_invoked.Self);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00063C20 File Offset: 0x00061E20
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Object(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.Object);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00063C94 File Offset: 0x00061E94
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_dataConfig(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.PushAny(L, gen_to_be_invoked.dataConfig);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00063D08 File Offset: 0x00061F08
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Target(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.PushAny(L, gen_to_be_invoked.Target);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00063D7C File Offset: 0x00061F7C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ScriptDict(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.ScriptDict);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00063DF0 File Offset: 0x00061FF0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Id(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				Lua.lua_pushstring(L, gen_to_be_invoked.Id);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00063E60 File Offset: 0x00062060
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_ValueDice(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.ValueDice);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00063ED4 File Offset: 0x000620D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_CheckDice(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.CheckDice);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00063F48 File Offset: 0x00062148
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_DefaultDice(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.DefaultDice);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00063FBC File Offset: 0x000621BC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_Vars(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.PushAny(L, gen_to_be_invoked.Vars);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00064030 File Offset: 0x00062230
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_HandCard(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.HandCard);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000640A4 File Offset: 0x000622A4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_CompiledSuccessfully(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.CompiledSuccessfully);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00064114 File Offset: 0x00062314
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_GetStatus(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.GetStatus);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00064188 File Offset: 0x00062388
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_handlers(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.handlers);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000641FC File Offset: 0x000623FC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_luaEnv(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.Push(L, ScriptExecutor.luaEnv);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00064260 File Offset: 0x00062460
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_luaTable(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				translator.Push(L, ScriptExecutor.luaTable);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000642C4 File Offset: 0x000624C4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_status(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.status = (IStatusManager)translator.GetObject(L, 2, typeof(IStatusManager));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00064348 File Offset: 0x00062548
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Self(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Self = (IStatusManager)translator.GetObject(L, 2, typeof(IStatusManager));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000643CC File Offset: 0x000625CC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Object(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Object = (List<IStatusManager>)translator.GetObject(L, 2, typeof(List<IStatusManager>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00064450 File Offset: 0x00062650
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_dataConfig(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.dataConfig = (IDataConfig)translator.GetObject(L, 2, typeof(IDataConfig));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000644D4 File Offset: 0x000626D4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_Target(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.Target = (IStatusManager)translator.GetObject(L, 2, typeof(IStatusManager));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00064558 File Offset: 0x00062758
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_ScriptDict(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.ScriptDict = (Dictionary<string, Delegate>)translator.GetObject(L, 2, typeof(Dictionary<string, Delegate>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x000645DC File Offset: 0x000627DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_GetStatus(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.GetStatus = (Dictionary<IStatusManager, Dictionary<string, int>>)translator.GetObject(L, 2, typeof(Dictionary<IStatusManager, Dictionary<string, int>>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0006465C File Offset: 0x0006285C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_handlers(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor gen_to_be_invoked = (ScriptExecutor)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.handlers = (List<PropertyChangedEventHandler>)translator.GetObject(L, 2, typeof(List<PropertyChangedEventHandler>));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x000646DC File Offset: 0x000628DC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_luaEnv(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor.luaEnv = (LuaEnv)translator.GetObject(L, 1, typeof(LuaEnv));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00064750 File Offset: 0x00062950
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_luaTable(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				ScriptExecutor.luaTable = (LuaTable)translator.GetObject(L, 1, typeof(LuaTable));
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

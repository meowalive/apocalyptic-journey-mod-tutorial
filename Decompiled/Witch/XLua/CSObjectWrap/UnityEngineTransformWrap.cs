using System;
using System.Collections;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001BA RID: 442
	public class UnityEngineTransformWrap
	{
		// Token: 0x06000EF1 RID: 3825 RVA: 0x00079EF0 File Offset: 0x000780F0
		public static void __Register(IntPtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Type type = typeof(Transform);
			Utils.BeginObjectRegister(type, L, translator, 0, 24, 19, 13, -1);
			Utils.RegisterFunc(L, -3, "SetParent", new lua_CSFunction(UnityEngineTransformWrap._m_SetParent));
			Utils.RegisterFunc(L, -3, "SetPositionAndRotation", new lua_CSFunction(UnityEngineTransformWrap._m_SetPositionAndRotation));
			Utils.RegisterFunc(L, -3, "SetLocalPositionAndRotation", new lua_CSFunction(UnityEngineTransformWrap._m_SetLocalPositionAndRotation));
			Utils.RegisterFunc(L, -3, "GetPositionAndRotation", new lua_CSFunction(UnityEngineTransformWrap._m_GetPositionAndRotation));
			Utils.RegisterFunc(L, -3, "GetLocalPositionAndRotation", new lua_CSFunction(UnityEngineTransformWrap._m_GetLocalPositionAndRotation));
			Utils.RegisterFunc(L, -3, "Translate", new lua_CSFunction(UnityEngineTransformWrap._m_Translate));
			Utils.RegisterFunc(L, -3, "Rotate", new lua_CSFunction(UnityEngineTransformWrap._m_Rotate));
			Utils.RegisterFunc(L, -3, "RotateAround", new lua_CSFunction(UnityEngineTransformWrap._m_RotateAround));
			Utils.RegisterFunc(L, -3, "LookAt", new lua_CSFunction(UnityEngineTransformWrap._m_LookAt));
			Utils.RegisterFunc(L, -3, "TransformDirection", new lua_CSFunction(UnityEngineTransformWrap._m_TransformDirection));
			Utils.RegisterFunc(L, -3, "InverseTransformDirection", new lua_CSFunction(UnityEngineTransformWrap._m_InverseTransformDirection));
			Utils.RegisterFunc(L, -3, "TransformVector", new lua_CSFunction(UnityEngineTransformWrap._m_TransformVector));
			Utils.RegisterFunc(L, -3, "InverseTransformVector", new lua_CSFunction(UnityEngineTransformWrap._m_InverseTransformVector));
			Utils.RegisterFunc(L, -3, "TransformPoint", new lua_CSFunction(UnityEngineTransformWrap._m_TransformPoint));
			Utils.RegisterFunc(L, -3, "InverseTransformPoint", new lua_CSFunction(UnityEngineTransformWrap._m_InverseTransformPoint));
			Utils.RegisterFunc(L, -3, "DetachChildren", new lua_CSFunction(UnityEngineTransformWrap._m_DetachChildren));
			Utils.RegisterFunc(L, -3, "SetAsFirstSibling", new lua_CSFunction(UnityEngineTransformWrap._m_SetAsFirstSibling));
			Utils.RegisterFunc(L, -3, "SetAsLastSibling", new lua_CSFunction(UnityEngineTransformWrap._m_SetAsLastSibling));
			Utils.RegisterFunc(L, -3, "SetSiblingIndex", new lua_CSFunction(UnityEngineTransformWrap._m_SetSiblingIndex));
			Utils.RegisterFunc(L, -3, "GetSiblingIndex", new lua_CSFunction(UnityEngineTransformWrap._m_GetSiblingIndex));
			Utils.RegisterFunc(L, -3, "Find", new lua_CSFunction(UnityEngineTransformWrap._m_Find));
			Utils.RegisterFunc(L, -3, "IsChildOf", new lua_CSFunction(UnityEngineTransformWrap._m_IsChildOf));
			Utils.RegisterFunc(L, -3, "GetEnumerator", new lua_CSFunction(UnityEngineTransformWrap._m_GetEnumerator));
			Utils.RegisterFunc(L, -3, "GetChild", new lua_CSFunction(UnityEngineTransformWrap._m_GetChild));
			Utils.RegisterFunc(L, -2, "position", new lua_CSFunction(UnityEngineTransformWrap._g_get_position));
			Utils.RegisterFunc(L, -2, "localPosition", new lua_CSFunction(UnityEngineTransformWrap._g_get_localPosition));
			Utils.RegisterFunc(L, -2, "eulerAngles", new lua_CSFunction(UnityEngineTransformWrap._g_get_eulerAngles));
			Utils.RegisterFunc(L, -2, "localEulerAngles", new lua_CSFunction(UnityEngineTransformWrap._g_get_localEulerAngles));
			Utils.RegisterFunc(L, -2, "right", new lua_CSFunction(UnityEngineTransformWrap._g_get_right));
			Utils.RegisterFunc(L, -2, "up", new lua_CSFunction(UnityEngineTransformWrap._g_get_up));
			Utils.RegisterFunc(L, -2, "forward", new lua_CSFunction(UnityEngineTransformWrap._g_get_forward));
			Utils.RegisterFunc(L, -2, "rotation", new lua_CSFunction(UnityEngineTransformWrap._g_get_rotation));
			Utils.RegisterFunc(L, -2, "localRotation", new lua_CSFunction(UnityEngineTransformWrap._g_get_localRotation));
			Utils.RegisterFunc(L, -2, "localScale", new lua_CSFunction(UnityEngineTransformWrap._g_get_localScale));
			Utils.RegisterFunc(L, -2, "parent", new lua_CSFunction(UnityEngineTransformWrap._g_get_parent));
			Utils.RegisterFunc(L, -2, "worldToLocalMatrix", new lua_CSFunction(UnityEngineTransformWrap._g_get_worldToLocalMatrix));
			Utils.RegisterFunc(L, -2, "localToWorldMatrix", new lua_CSFunction(UnityEngineTransformWrap._g_get_localToWorldMatrix));
			Utils.RegisterFunc(L, -2, "root", new lua_CSFunction(UnityEngineTransformWrap._g_get_root));
			Utils.RegisterFunc(L, -2, "childCount", new lua_CSFunction(UnityEngineTransformWrap._g_get_childCount));
			Utils.RegisterFunc(L, -2, "lossyScale", new lua_CSFunction(UnityEngineTransformWrap._g_get_lossyScale));
			Utils.RegisterFunc(L, -2, "hasChanged", new lua_CSFunction(UnityEngineTransformWrap._g_get_hasChanged));
			Utils.RegisterFunc(L, -2, "hierarchyCapacity", new lua_CSFunction(UnityEngineTransformWrap._g_get_hierarchyCapacity));
			Utils.RegisterFunc(L, -2, "hierarchyCount", new lua_CSFunction(UnityEngineTransformWrap._g_get_hierarchyCount));
			Utils.RegisterFunc(L, -1, "position", new lua_CSFunction(UnityEngineTransformWrap._s_set_position));
			Utils.RegisterFunc(L, -1, "localPosition", new lua_CSFunction(UnityEngineTransformWrap._s_set_localPosition));
			Utils.RegisterFunc(L, -1, "eulerAngles", new lua_CSFunction(UnityEngineTransformWrap._s_set_eulerAngles));
			Utils.RegisterFunc(L, -1, "localEulerAngles", new lua_CSFunction(UnityEngineTransformWrap._s_set_localEulerAngles));
			Utils.RegisterFunc(L, -1, "right", new lua_CSFunction(UnityEngineTransformWrap._s_set_right));
			Utils.RegisterFunc(L, -1, "up", new lua_CSFunction(UnityEngineTransformWrap._s_set_up));
			Utils.RegisterFunc(L, -1, "forward", new lua_CSFunction(UnityEngineTransformWrap._s_set_forward));
			Utils.RegisterFunc(L, -1, "rotation", new lua_CSFunction(UnityEngineTransformWrap._s_set_rotation));
			Utils.RegisterFunc(L, -1, "localRotation", new lua_CSFunction(UnityEngineTransformWrap._s_set_localRotation));
			Utils.RegisterFunc(L, -1, "localScale", new lua_CSFunction(UnityEngineTransformWrap._s_set_localScale));
			Utils.RegisterFunc(L, -1, "parent", new lua_CSFunction(UnityEngineTransformWrap._s_set_parent));
			Utils.RegisterFunc(L, -1, "hasChanged", new lua_CSFunction(UnityEngineTransformWrap._s_set_hasChanged));
			Utils.RegisterFunc(L, -1, "hierarchyCapacity", new lua_CSFunction(UnityEngineTransformWrap._s_set_hierarchyCapacity));
			Utils.EndObjectRegister(type, L, translator, null, null, null, null, null);
			Utils.BeginClassRegister(type, L, new lua_CSFunction(UnityEngineTransformWrap.__CreateInstance), 1, 0, 0);
			Utils.EndClassRegister(type, L, translator);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0007A4F8 File Offset: 0x000786F8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return Lua.luaL_error(L, "UnityEngine.Transform does not have a constructor!");
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0007A518 File Offset: 0x00078718
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetParent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Transform>(L, 2);
				if (flag)
				{
					Transform _p = (Transform)translator.GetObject(L, 2, typeof(Transform));
					gen_to_be_invoked.SetParent(_p);
					return 0;
				}
				bool flag2 = gen_param_count == 3 && translator.Assignable<Transform>(L, 2) && LuaTypes.LUA_TBOOLEAN == Lua.lua_type(L, 3);
				if (flag2)
				{
					Transform _parent = (Transform)translator.GetObject(L, 2, typeof(Transform));
					bool _worldPositionStays = Lua.lua_toboolean(L, 3);
					gen_to_be_invoked.SetParent(_parent, _worldPositionStays);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.SetParent!");
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0007A624 File Offset: 0x00078824
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetPositionAndRotation(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 _position;
				translator.Get(L, 2, out _position);
				Quaternion _rotation;
				translator.Get(L, 3, out _rotation);
				gen_to_be_invoked.SetPositionAndRotation(_position, _rotation);
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

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0007A6AC File Offset: 0x000788AC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetLocalPositionAndRotation(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 _localPosition;
				translator.Get(L, 2, out _localPosition);
				Quaternion _localRotation;
				translator.Get(L, 3, out _localRotation);
				gen_to_be_invoked.SetLocalPositionAndRotation(_localPosition, _localRotation);
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

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0007A734 File Offset: 0x00078934
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetPositionAndRotation(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 _position;
				Quaternion _rotation;
				gen_to_be_invoked.GetPositionAndRotation(out _position, out _rotation);
				translator.PushUnityEngineVector3(L, _position);
				translator.PushUnityEngineQuaternion(L, _rotation);
				result = 2;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0007A7B8 File Offset: 0x000789B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetLocalPositionAndRotation(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 _localPosition;
				Quaternion _localRotation;
				gen_to_be_invoked.GetLocalPositionAndRotation(out _localPosition, out _localRotation);
				translator.PushUnityEngineVector3(L, _localPosition);
				translator.PushUnityEngineQuaternion(L, _localRotation);
				result = 2;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				result = Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0007A83C File Offset: 0x00078A3C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Translate(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					gen_to_be_invoked.Translate(_x, _y, _z);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _translation;
					translator.Get(L, 2, out _translation);
					gen_to_be_invoked.Translate(_translation);
					return 0;
				}
				bool flag3 = gen_param_count == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && translator.Assignable<Space>(L, 5);
				if (flag3)
				{
					float _x2 = (float)Lua.lua_tonumber(L, 2);
					float _y2 = (float)Lua.lua_tonumber(L, 3);
					float _z2 = (float)Lua.lua_tonumber(L, 4);
					Space _relativeTo;
					translator.Get<Space>(L, 5, out _relativeTo);
					gen_to_be_invoked.Translate(_x2, _y2, _z2, _relativeTo);
					return 0;
				}
				bool flag4 = gen_param_count == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && translator.Assignable<Transform>(L, 5);
				if (flag4)
				{
					float _x3 = (float)Lua.lua_tonumber(L, 2);
					float _y3 = (float)Lua.lua_tonumber(L, 3);
					float _z3 = (float)Lua.lua_tonumber(L, 4);
					Transform _relativeTo2 = (Transform)translator.GetObject(L, 5, typeof(Transform));
					gen_to_be_invoked.Translate(_x3, _y3, _z3, _relativeTo2);
					return 0;
				}
				bool flag5 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Space>(L, 3);
				if (flag5)
				{
					Vector3 _translation2;
					translator.Get(L, 2, out _translation2);
					Space _relativeTo3;
					translator.Get<Space>(L, 3, out _relativeTo3);
					gen_to_be_invoked.Translate(_translation2, _relativeTo3);
					return 0;
				}
				bool flag6 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Transform>(L, 3);
				if (flag6)
				{
					Vector3 _translation3;
					translator.Get(L, 2, out _translation3);
					Transform _relativeTo4 = (Transform)translator.GetObject(L, 3, typeof(Transform));
					gen_to_be_invoked.Translate(_translation3, _relativeTo4);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.Translate!");
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0007AAE4 File Offset: 0x00078CE4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Rotate(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _xAngle = (float)Lua.lua_tonumber(L, 2);
					float _yAngle = (float)Lua.lua_tonumber(L, 3);
					float _zAngle = (float)Lua.lua_tonumber(L, 4);
					gen_to_be_invoked.Rotate(_xAngle, _yAngle, _zAngle);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _eulers;
					translator.Get(L, 2, out _eulers);
					gen_to_be_invoked.Rotate(_eulers);
					return 0;
				}
				bool flag3 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3);
				if (flag3)
				{
					Vector3 _axis;
					translator.Get(L, 2, out _axis);
					float _angle = (float)Lua.lua_tonumber(L, 3);
					gen_to_be_invoked.Rotate(_axis, _angle);
					return 0;
				}
				bool flag4 = gen_param_count == 5 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4) && translator.Assignable<Space>(L, 5);
				if (flag4)
				{
					float _xAngle2 = (float)Lua.lua_tonumber(L, 2);
					float _yAngle2 = (float)Lua.lua_tonumber(L, 3);
					float _zAngle2 = (float)Lua.lua_tonumber(L, 4);
					Space _relativeTo;
					translator.Get<Space>(L, 5, out _relativeTo);
					gen_to_be_invoked.Rotate(_xAngle2, _yAngle2, _zAngle2, _relativeTo);
					return 0;
				}
				bool flag5 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Space>(L, 3);
				if (flag5)
				{
					Vector3 _eulers2;
					translator.Get(L, 2, out _eulers2);
					Space _relativeTo2;
					translator.Get<Space>(L, 3, out _relativeTo2);
					gen_to_be_invoked.Rotate(_eulers2, _relativeTo2);
					return 0;
				}
				bool flag6 = gen_param_count == 4 && translator.Assignable<Vector3>(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && translator.Assignable<Space>(L, 4);
				if (flag6)
				{
					Vector3 _axis2;
					translator.Get(L, 2, out _axis2);
					float _angle2 = (float)Lua.lua_tonumber(L, 3);
					Space _relativeTo3;
					translator.Get<Space>(L, 4, out _relativeTo3);
					gen_to_be_invoked.Rotate(_axis2, _angle2, _relativeTo3);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.Rotate!");
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0007AD5C File Offset: 0x00078F5C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RotateAround(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 _point;
				translator.Get(L, 2, out _point);
				Vector3 _axis;
				translator.Get(L, 3, out _axis);
				float _angle = (float)Lua.lua_tonumber(L, 4);
				gen_to_be_invoked.RotateAround(_point, _axis, _angle);
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

		// Token: 0x06000EFB RID: 3835 RVA: 0x0007ADF0 File Offset: 0x00078FF0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_LookAt(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 2 && translator.Assignable<Transform>(L, 2);
				if (flag)
				{
					Transform _target = (Transform)translator.GetObject(L, 2, typeof(Transform));
					gen_to_be_invoked.LookAt(_target);
					return 0;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _worldPosition;
					translator.Get(L, 2, out _worldPosition);
					gen_to_be_invoked.LookAt(_worldPosition);
					return 0;
				}
				bool flag3 = gen_param_count == 3 && translator.Assignable<Transform>(L, 2) && translator.Assignable<Vector3>(L, 3);
				if (flag3)
				{
					Transform _target2 = (Transform)translator.GetObject(L, 2, typeof(Transform));
					Vector3 _worldUp;
					translator.Get(L, 3, out _worldUp);
					gen_to_be_invoked.LookAt(_target2, _worldUp);
					return 0;
				}
				bool flag4 = gen_param_count == 3 && translator.Assignable<Vector3>(L, 2) && translator.Assignable<Vector3>(L, 3);
				if (flag4)
				{
					Vector3 _worldPosition2;
					translator.Get(L, 2, out _worldPosition2);
					Vector3 _worldUp2;
					translator.Get(L, 3, out _worldUp2);
					gen_to_be_invoked.LookAt(_worldPosition2, _worldUp2);
					return 0;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.LookAt!");
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0007AF80 File Offset: 0x00079180
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TransformDirection(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					Vector3 gen_ret = gen_to_be_invoked.TransformDirection(_x, _y, _z);
					translator.PushUnityEngineVector3(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _direction;
					translator.Get(L, 2, out _direction);
					Vector3 gen_ret2 = gen_to_be_invoked.TransformDirection(_direction);
					translator.PushUnityEngineVector3(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformDirection!");
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0007B098 File Offset: 0x00079298
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InverseTransformDirection(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					Vector3 gen_ret = gen_to_be_invoked.InverseTransformDirection(_x, _y, _z);
					translator.PushUnityEngineVector3(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _direction;
					translator.Get(L, 2, out _direction);
					Vector3 gen_ret2 = gen_to_be_invoked.InverseTransformDirection(_direction);
					translator.PushUnityEngineVector3(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformDirection!");
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0007B1B0 File Offset: 0x000793B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TransformVector(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					Vector3 gen_ret = gen_to_be_invoked.TransformVector(_x, _y, _z);
					translator.PushUnityEngineVector3(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _vector;
					translator.Get(L, 2, out _vector);
					Vector3 gen_ret2 = gen_to_be_invoked.TransformVector(_vector);
					translator.PushUnityEngineVector3(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformVector!");
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0007B2C8 File Offset: 0x000794C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InverseTransformVector(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					Vector3 gen_ret = gen_to_be_invoked.InverseTransformVector(_x, _y, _z);
					translator.PushUnityEngineVector3(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _vector;
					translator.Get(L, 2, out _vector);
					Vector3 gen_ret2 = gen_to_be_invoked.InverseTransformVector(_vector);
					translator.PushUnityEngineVector3(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformVector!");
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0007B3E0 File Offset: 0x000795E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TransformPoint(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					Vector3 gen_ret = gen_to_be_invoked.TransformPoint(_x, _y, _z);
					translator.PushUnityEngineVector3(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _position;
					translator.Get(L, 2, out _position);
					Vector3 gen_ret2 = gen_to_be_invoked.TransformPoint(_position);
					translator.PushUnityEngineVector3(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformPoint!");
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0007B4F8 File Offset: 0x000796F8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_InverseTransformPoint(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_param_count = Lua.lua_gettop(L);
				bool flag = gen_param_count == 4 && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == Lua.lua_type(L, 4);
				if (flag)
				{
					float _x = (float)Lua.lua_tonumber(L, 2);
					float _y = (float)Lua.lua_tonumber(L, 3);
					float _z = (float)Lua.lua_tonumber(L, 4);
					Vector3 gen_ret = gen_to_be_invoked.InverseTransformPoint(_x, _y, _z);
					translator.PushUnityEngineVector3(L, gen_ret);
					return 1;
				}
				bool flag2 = gen_param_count == 2 && translator.Assignable<Vector3>(L, 2);
				if (flag2)
				{
					Vector3 _position;
					translator.Get(L, 2, out _position);
					Vector3 gen_ret2 = gen_to_be_invoked.InverseTransformPoint(_position);
					translator.PushUnityEngineVector3(L, gen_ret2);
					return 1;
				}
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return Lua.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformPoint!");
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0007B610 File Offset: 0x00079810
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_DetachChildren(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.DetachChildren();
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

		// Token: 0x06000F03 RID: 3843 RVA: 0x0007B678 File Offset: 0x00079878
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetAsFirstSibling(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.SetAsFirstSibling();
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

		// Token: 0x06000F04 RID: 3844 RVA: 0x0007B6E0 File Offset: 0x000798E0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetAsLastSibling(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.SetAsLastSibling();
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

		// Token: 0x06000F05 RID: 3845 RVA: 0x0007B748 File Offset: 0x00079948
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SetSiblingIndex(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int _index = Lua.xlua_tointeger(L, 2);
				gen_to_be_invoked.SetSiblingIndex(_index);
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

		// Token: 0x06000F06 RID: 3846 RVA: 0x0007B7BC File Offset: 0x000799BC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetSiblingIndex(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int gen_ret = gen_to_be_invoked.GetSiblingIndex();
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

		// Token: 0x06000F07 RID: 3847 RVA: 0x0007B830 File Offset: 0x00079A30
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Find(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				string _n = Lua.lua_tostring(L, 2);
				Transform gen_ret = gen_to_be_invoked.Find(_n);
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

		// Token: 0x06000F08 RID: 3848 RVA: 0x0007B8B0 File Offset: 0x00079AB0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_IsChildOf(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Transform _parent = (Transform)translator.GetObject(L, 2, typeof(Transform));
				bool gen_ret = gen_to_be_invoked.IsChildOf(_parent);
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

		// Token: 0x06000F09 RID: 3849 RVA: 0x0007B940 File Offset: 0x00079B40
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetEnumerator(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				IEnumerator gen_ret = gen_to_be_invoked.GetEnumerator();
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

		// Token: 0x06000F0A RID: 3850 RVA: 0x0007B9B4 File Offset: 0x00079BB4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetChild(IntPtr L)
		{
			int result;
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				int _index = Lua.xlua_tointeger(L, 2);
				Transform gen_ret = gen_to_be_invoked.GetChild(_index);
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

		// Token: 0x06000F0B RID: 3851 RVA: 0x0007BA34 File Offset: 0x00079C34
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_position(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.position);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0007BAA8 File Offset: 0x00079CA8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_localPosition(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.localPosition);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0007BB1C File Offset: 0x00079D1C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_eulerAngles(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.eulerAngles);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0007BB90 File Offset: 0x00079D90
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_localEulerAngles(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.localEulerAngles);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0007BC04 File Offset: 0x00079E04
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_right(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.right);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0007BC78 File Offset: 0x00079E78
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_up(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.up);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0007BCEC File Offset: 0x00079EEC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_forward(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.forward);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0007BD60 File Offset: 0x00079F60
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_rotation(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.rotation);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0007BDD4 File Offset: 0x00079FD4
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_localRotation(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.localRotation);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0007BE48 File Offset: 0x0007A048
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_localScale(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.localScale);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0007BEBC File Offset: 0x0007A0BC
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_parent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.parent);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0007BF30 File Offset: 0x0007A130
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_worldToLocalMatrix(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.worldToLocalMatrix);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0007BFA8 File Offset: 0x0007A1A8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_localToWorldMatrix(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.localToWorldMatrix);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0007C020 File Offset: 0x0007A220
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_root(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.Push(L, gen_to_be_invoked.root);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0007C094 File Offset: 0x0007A294
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_childCount(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.childCount);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0007C104 File Offset: 0x0007A304
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_lossyScale(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				translator.PushUnityEngineVector3(L, gen_to_be_invoked.lossyScale);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0007C178 File Offset: 0x0007A378
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_hasChanged(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Lua.lua_pushboolean(L, gen_to_be_invoked.hasChanged);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0007C1E8 File Offset: 0x0007A3E8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_hierarchyCapacity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.hierarchyCapacity);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0007C258 File Offset: 0x0007A458
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_hierarchyCount(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Lua.xlua_pushinteger(L, gen_to_be_invoked.hierarchyCount);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 1;
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0007C2C8 File Offset: 0x0007A4C8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_position(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.position = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0007C344 File Offset: 0x0007A544
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_localPosition(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.localPosition = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0007C3C0 File Offset: 0x0007A5C0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_eulerAngles(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.eulerAngles = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0007C43C File Offset: 0x0007A63C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_localEulerAngles(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.localEulerAngles = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0007C4B8 File Offset: 0x0007A6B8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_right(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.right = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0007C534 File Offset: 0x0007A734
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_up(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.up = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0007C5B0 File Offset: 0x0007A7B0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_forward(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.forward = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0007C62C File Offset: 0x0007A82C
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_rotation(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Quaternion gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.rotation = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0007C6A8 File Offset: 0x0007A8A8
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_localRotation(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Quaternion gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.localRotation = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0007C724 File Offset: 0x0007A924
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_localScale(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				Vector3 gen_value;
				translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.localScale = gen_value;
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0007C7A0 File Offset: 0x0007A9A0
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_parent(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.parent = (Transform)translator.GetObject(L, 2, typeof(Transform));
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0007C824 File Offset: 0x0007AA24
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_hasChanged(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.hasChanged = Lua.lua_toboolean(L, 2);
			}
			catch (Exception gen_e)
			{
				string str = "c# exception:";
				Exception ex = gen_e;
				return Lua.luaL_error(L, str + ((ex != null) ? ex.ToString() : null));
			}
			return 0;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0007C898 File Offset: 0x0007AA98
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_hierarchyCapacity(IntPtr L)
		{
			try
			{
				ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				Transform gen_to_be_invoked = (Transform)translator.FastGetCSObj(L, 1);
				gen_to_be_invoked.hierarchyCapacity = Lua.xlua_tointeger(L, 2);
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

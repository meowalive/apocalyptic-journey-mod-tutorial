using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tutorial;
using UnityEngine;
using XLua.CSObjectWrap;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000131 RID: 305
	public class ObjectTranslator
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x000494A4 File Offset: 0x000476A4
		private static ObjectTranslator.IniterAdderUnityEngineVector2 IniterAdderUnityEngineVector2_dumb_obj
		{
			get
			{
				return ObjectTranslator.s_IniterAdderUnityEngineVector2_dumb_obj;
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000494BC File Offset: 0x000476BC
		public void PushUnityEngineVector2(IntPtr L, Vector2 val)
		{
			bool flag = this.UnityEngineVector2_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.UnityEngineVector2_TypeID = this.getTypeId(L, typeof(Vector2), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 8U, this.UnityEngineVector2_TypeID);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				string str = "pack fail fail for UnityEngine.Vector2 ,value=";
				Vector2 vector = val;
				throw new Exception(str + vector.ToString());
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00049534 File Offset: 0x00047734
		public void Get(IntPtr L, int index, out Vector2 val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineVector2_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for UnityEngine.Vector2");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack fail for UnityEngine.Vector2");
				}
			}
			else
			{
				bool flag4 = type == LuaTypes.LUA_TTABLE;
				if (flag4)
				{
					CopyByValue.UnPack(this, L, index, out val);
				}
				else
				{
					val = (Vector2)this.objectCasters.GetCaster(typeof(Vector2))(L, index, null);
				}
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000495E0 File Offset: 0x000477E0
		public void UpdateUnityEngineVector2(IntPtr L, int index, Vector2 val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineVector2_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for UnityEngine.Vector2");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, val);
			if (flag3)
			{
				string str = "pack fail for UnityEngine.Vector2 ,value=";
				Vector2 vector = val;
				throw new Exception(str + vector.ToString());
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00049684 File Offset: 0x00047884
		public void PushUnityEngineVector3(IntPtr L, Vector3 val)
		{
			bool flag = this.UnityEngineVector3_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.UnityEngineVector3_TypeID = this.getTypeId(L, typeof(Vector3), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 12U, this.UnityEngineVector3_TypeID);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				string str = "pack fail fail for UnityEngine.Vector3 ,value=";
				Vector3 vector = val;
				throw new Exception(str + vector.ToString());
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000496FC File Offset: 0x000478FC
		public void Get(IntPtr L, int index, out Vector3 val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineVector3_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for UnityEngine.Vector3");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack fail for UnityEngine.Vector3");
				}
			}
			else
			{
				bool flag4 = type == LuaTypes.LUA_TTABLE;
				if (flag4)
				{
					CopyByValue.UnPack(this, L, index, out val);
				}
				else
				{
					val = (Vector3)this.objectCasters.GetCaster(typeof(Vector3))(L, index, null);
				}
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000497A8 File Offset: 0x000479A8
		public void UpdateUnityEngineVector3(IntPtr L, int index, Vector3 val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineVector3_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for UnityEngine.Vector3");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, val);
			if (flag3)
			{
				string str = "pack fail for UnityEngine.Vector3 ,value=";
				Vector3 vector = val;
				throw new Exception(str + vector.ToString());
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0004984C File Offset: 0x00047A4C
		public void PushUnityEngineVector4(IntPtr L, Vector4 val)
		{
			bool flag = this.UnityEngineVector4_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.UnityEngineVector4_TypeID = this.getTypeId(L, typeof(Vector4), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 16U, this.UnityEngineVector4_TypeID);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				string str = "pack fail fail for UnityEngine.Vector4 ,value=";
				Vector4 vector = val;
				throw new Exception(str + vector.ToString());
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000498C4 File Offset: 0x00047AC4
		public void Get(IntPtr L, int index, out Vector4 val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineVector4_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for UnityEngine.Vector4");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack fail for UnityEngine.Vector4");
				}
			}
			else
			{
				bool flag4 = type == LuaTypes.LUA_TTABLE;
				if (flag4)
				{
					CopyByValue.UnPack(this, L, index, out val);
				}
				else
				{
					val = (Vector4)this.objectCasters.GetCaster(typeof(Vector4))(L, index, null);
				}
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00049970 File Offset: 0x00047B70
		public void UpdateUnityEngineVector4(IntPtr L, int index, Vector4 val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineVector4_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for UnityEngine.Vector4");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, val);
			if (flag3)
			{
				string str = "pack fail for UnityEngine.Vector4 ,value=";
				Vector4 vector = val;
				throw new Exception(str + vector.ToString());
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00049A14 File Offset: 0x00047C14
		public void PushUnityEngineColor(IntPtr L, Color val)
		{
			bool flag = this.UnityEngineColor_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.UnityEngineColor_TypeID = this.getTypeId(L, typeof(Color), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 16U, this.UnityEngineColor_TypeID);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				string str = "pack fail fail for UnityEngine.Color ,value=";
				Color color = val;
				throw new Exception(str + color.ToString());
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00049A8C File Offset: 0x00047C8C
		public void Get(IntPtr L, int index, out Color val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineColor_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for UnityEngine.Color");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack fail for UnityEngine.Color");
				}
			}
			else
			{
				bool flag4 = type == LuaTypes.LUA_TTABLE;
				if (flag4)
				{
					CopyByValue.UnPack(this, L, index, out val);
				}
				else
				{
					val = (Color)this.objectCasters.GetCaster(typeof(Color))(L, index, null);
				}
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00049B38 File Offset: 0x00047D38
		public void UpdateUnityEngineColor(IntPtr L, int index, Color val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineColor_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for UnityEngine.Color");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, val);
			if (flag3)
			{
				string str = "pack fail for UnityEngine.Color ,value=";
				Color color = val;
				throw new Exception(str + color.ToString());
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00049BDC File Offset: 0x00047DDC
		public void PushUnityEngineQuaternion(IntPtr L, Quaternion val)
		{
			bool flag = this.UnityEngineQuaternion_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.UnityEngineQuaternion_TypeID = this.getTypeId(L, typeof(Quaternion), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 16U, this.UnityEngineQuaternion_TypeID);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				string str = "pack fail fail for UnityEngine.Quaternion ,value=";
				Quaternion quaternion = val;
				throw new Exception(str + quaternion.ToString());
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00049C54 File Offset: 0x00047E54
		public void Get(IntPtr L, int index, out Quaternion val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineQuaternion_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for UnityEngine.Quaternion");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack fail for UnityEngine.Quaternion");
				}
			}
			else
			{
				bool flag4 = type == LuaTypes.LUA_TTABLE;
				if (flag4)
				{
					CopyByValue.UnPack(this, L, index, out val);
				}
				else
				{
					val = (Quaternion)this.objectCasters.GetCaster(typeof(Quaternion))(L, index, null);
				}
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00049D00 File Offset: 0x00047F00
		public void UpdateUnityEngineQuaternion(IntPtr L, int index, Quaternion val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineQuaternion_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for UnityEngine.Quaternion");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, val);
			if (flag3)
			{
				string str = "pack fail for UnityEngine.Quaternion ,value=";
				Quaternion quaternion = val;
				throw new Exception(str + quaternion.ToString());
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00049DA4 File Offset: 0x00047FA4
		public void PushUnityEngineRay(IntPtr L, Ray val)
		{
			bool flag = this.UnityEngineRay_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.UnityEngineRay_TypeID = this.getTypeId(L, typeof(Ray), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 24U, this.UnityEngineRay_TypeID);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				string str = "pack fail fail for UnityEngine.Ray ,value=";
				Ray ray = val;
				throw new Exception(str + ray.ToString());
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00049E1C File Offset: 0x0004801C
		public void Get(IntPtr L, int index, out Ray val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineRay_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for UnityEngine.Ray");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack fail for UnityEngine.Ray");
				}
			}
			else
			{
				bool flag4 = type == LuaTypes.LUA_TTABLE;
				if (flag4)
				{
					CopyByValue.UnPack(this, L, index, out val);
				}
				else
				{
					val = (Ray)this.objectCasters.GetCaster(typeof(Ray))(L, index, null);
				}
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00049EC8 File Offset: 0x000480C8
		public void UpdateUnityEngineRay(IntPtr L, int index, Ray val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineRay_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for UnityEngine.Ray");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, val);
			if (flag3)
			{
				string str = "pack fail for UnityEngine.Ray ,value=";
				Ray ray = val;
				throw new Exception(str + ray.ToString());
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00049F6C File Offset: 0x0004816C
		public void PushUnityEngineBounds(IntPtr L, Bounds val)
		{
			bool flag = this.UnityEngineBounds_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.UnityEngineBounds_TypeID = this.getTypeId(L, typeof(Bounds), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 24U, this.UnityEngineBounds_TypeID);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				string str = "pack fail fail for UnityEngine.Bounds ,value=";
				Bounds bounds = val;
				throw new Exception(str + bounds.ToString());
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00049FE4 File Offset: 0x000481E4
		public void Get(IntPtr L, int index, out Bounds val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineBounds_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for UnityEngine.Bounds");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack fail for UnityEngine.Bounds");
				}
			}
			else
			{
				bool flag4 = type == LuaTypes.LUA_TTABLE;
				if (flag4)
				{
					CopyByValue.UnPack(this, L, index, out val);
				}
				else
				{
					val = (Bounds)this.objectCasters.GetCaster(typeof(Bounds))(L, index, null);
				}
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0004A090 File Offset: 0x00048290
		public void UpdateUnityEngineBounds(IntPtr L, int index, Bounds val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineBounds_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for UnityEngine.Bounds");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, val);
			if (flag3)
			{
				string str = "pack fail for UnityEngine.Bounds ,value=";
				Bounds bounds = val;
				throw new Exception(str + bounds.ToString());
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0004A134 File Offset: 0x00048334
		public void PushUnityEngineRay2D(IntPtr L, Ray2D val)
		{
			bool flag = this.UnityEngineRay2D_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.UnityEngineRay2D_TypeID = this.getTypeId(L, typeof(Ray2D), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 16U, this.UnityEngineRay2D_TypeID);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				string str = "pack fail fail for UnityEngine.Ray2D ,value=";
				Ray2D ray2D = val;
				throw new Exception(str + ray2D.ToString());
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0004A1AC File Offset: 0x000483AC
		public void Get(IntPtr L, int index, out Ray2D val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineRay2D_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for UnityEngine.Ray2D");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack fail for UnityEngine.Ray2D");
				}
			}
			else
			{
				bool flag4 = type == LuaTypes.LUA_TTABLE;
				if (flag4)
				{
					CopyByValue.UnPack(this, L, index, out val);
				}
				else
				{
					val = (Ray2D)this.objectCasters.GetCaster(typeof(Ray2D))(L, index, null);
				}
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0004A258 File Offset: 0x00048458
		public void UpdateUnityEngineRay2D(IntPtr L, int index, Ray2D val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.UnityEngineRay2D_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for UnityEngine.Ray2D");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, val);
			if (flag3)
			{
				string str = "pack fail for UnityEngine.Ray2D ,value=";
				Ray2D ray2D = val;
				throw new Exception(str + ray2D.ToString());
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0004A2FC File Offset: 0x000484FC
		public void PushTutorialTestEnum(IntPtr L, TestEnum val)
		{
			bool flag = this.TutorialTestEnum_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.TutorialTestEnum_TypeID = this.getTypeId(L, typeof(TestEnum), out is_first, ObjectTranslator.LOGLEVEL.WARN);
				bool flag2 = this.TutorialTestEnum_EnumRef == -1;
				if (flag2)
				{
					Utils.LoadCSTable(L, typeof(TestEnum));
					this.TutorialTestEnum_EnumRef = Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
			}
			bool flag3 = Lua.xlua_tryget_cachedud(L, (int)val, this.TutorialTestEnum_EnumRef) == 1;
			if (!flag3)
			{
				IntPtr buff = Lua.xlua_pushstruct(L, 4U, this.TutorialTestEnum_TypeID);
				bool flag4 = !CopyByValue.Pack(buff, 0, (int)val);
				if (flag4)
				{
					throw new Exception("pack fail fail for Tutorial.TestEnum ,value=" + val.ToString());
				}
				Lua.lua_getref(L, this.TutorialTestEnum_EnumRef);
				Lua.lua_pushvalue(L, -2);
				Lua.xlua_rawseti(L, -2, (long)val);
				Lua.lua_pop(L, 1);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0004A3E4 File Offset: 0x000485E4
		public void Get(IntPtr L, int index, out TestEnum val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.TutorialTestEnum_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for Tutorial.TestEnum");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				int e;
				bool flag3 = !CopyByValue.UnPack(buff, 0, out e);
				if (flag3)
				{
					throw new Exception("unpack fail for Tutorial.TestEnum");
				}
				val = (TestEnum)e;
			}
			else
			{
				val = (TestEnum)this.objectCasters.GetCaster(typeof(TestEnum))(L, index, null);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0004A47C File Offset: 0x0004867C
		public void UpdateTutorialTestEnum(IntPtr L, int index, TestEnum val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.TutorialTestEnum_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for Tutorial.TestEnum");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, (int)val);
			if (flag3)
			{
				throw new Exception("pack fail for Tutorial.TestEnum ,value=" + val.ToString());
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0004A51C File Offset: 0x0004871C
		public void PushTutorialDerivedClassTestEnumInner(IntPtr L, DerivedClass.TestEnumInner val)
		{
			bool flag = this.TutorialDerivedClassTestEnumInner_TypeID == -1;
			if (flag)
			{
				bool is_first;
				this.TutorialDerivedClassTestEnumInner_TypeID = this.getTypeId(L, typeof(DerivedClass.TestEnumInner), out is_first, ObjectTranslator.LOGLEVEL.WARN);
				bool flag2 = this.TutorialDerivedClassTestEnumInner_EnumRef == -1;
				if (flag2)
				{
					Utils.LoadCSTable(L, typeof(DerivedClass.TestEnumInner));
					this.TutorialDerivedClassTestEnumInner_EnumRef = Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
				}
			}
			bool flag3 = Lua.xlua_tryget_cachedud(L, (int)val, this.TutorialDerivedClassTestEnumInner_EnumRef) == 1;
			if (!flag3)
			{
				IntPtr buff = Lua.xlua_pushstruct(L, 4U, this.TutorialDerivedClassTestEnumInner_TypeID);
				bool flag4 = !CopyByValue.Pack(buff, 0, (int)val);
				if (flag4)
				{
					throw new Exception("pack fail fail for Tutorial.DerivedClass.TestEnumInner ,value=" + val.ToString());
				}
				Lua.lua_getref(L, this.TutorialDerivedClassTestEnumInner_EnumRef);
				Lua.lua_pushvalue(L, -2);
				Lua.xlua_rawseti(L, -2, (long)val);
				Lua.lua_pop(L, 1);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0004A604 File Offset: 0x00048804
		public void Get(IntPtr L, int index, out DerivedClass.TestEnumInner val)
		{
			LuaTypes type = Lua.lua_type(L, index);
			bool flag = type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.TutorialDerivedClassTestEnumInner_TypeID;
				if (flag2)
				{
					throw new Exception("invalid userdata for Tutorial.DerivedClass.TestEnumInner");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				int e;
				bool flag3 = !CopyByValue.UnPack(buff, 0, out e);
				if (flag3)
				{
					throw new Exception("unpack fail for Tutorial.DerivedClass.TestEnumInner");
				}
				val = (DerivedClass.TestEnumInner)e;
			}
			else
			{
				val = (DerivedClass.TestEnumInner)this.objectCasters.GetCaster(typeof(DerivedClass.TestEnumInner))(L, index, null);
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0004A69C File Offset: 0x0004889C
		public void UpdateTutorialDerivedClassTestEnumInner(IntPtr L, int index, DerivedClass.TestEnumInner val)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (!flag)
			{
				throw new Exception("try to update a data with lua type:" + Lua.lua_type(L, index).ToString());
			}
			bool flag2 = Lua.xlua_gettypeid(L, index) != this.TutorialDerivedClassTestEnumInner_TypeID;
			if (flag2)
			{
				throw new Exception("invalid userdata for Tutorial.DerivedClass.TestEnumInner");
			}
			IntPtr buff = Lua.lua_touserdata(L, index);
			bool flag3 = !CopyByValue.Pack(buff, 0, (int)val);
			if (flag3)
			{
				throw new Exception("pack fail for Tutorial.DerivedClass.TestEnumInner ,value=" + val.ToString());
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0004A73C File Offset: 0x0004893C
		private static XLua_Gen_Initer_Register__ gen_reg_dumb_obj
		{
			get
			{
				return ObjectTranslator.s_gen_reg_dumb_obj;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0004A753 File Offset: 0x00048953
		public void DelayWrapLoader(Type type, Action<IntPtr> loader)
		{
			this.delayWrap[type] = loader;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0004A764 File Offset: 0x00048964
		public void AddInterfaceBridgeCreator(Type type, Func<int, LuaEnv, LuaBase> creator)
		{
			this.interfaceBridgeCreators.Add(type, creator);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0004A778 File Offset: 0x00048978
		public bool TryDelayWrapLoader(IntPtr L, Type type)
		{
			bool flag = this.loaded_types.ContainsKey(type);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				this.loaded_types.Add(type, true);
				Lua.luaL_newmetatable(L, type.FullName);
				Lua.lua_pop(L, 1);
				int top = Lua.lua_gettop(L);
				Action<IntPtr> loader;
				bool flag2 = this.delayWrap.TryGetValue(type, out loader);
				if (flag2)
				{
					this.delayWrap.Remove(type);
					loader(L);
				}
				else
				{
					bool flag3 = !DelegateBridge.Gen_Flag && !type.IsEnum() && !typeof(Delegate).IsAssignableFrom(type) && Utils.IsPublic(type);
					if (flag3)
					{
						Type wrap = this.ce.EmitTypeWrap(type);
						MethodInfo method = wrap.GetMethod("__Register", BindingFlags.Static | BindingFlags.Public);
						method.Invoke(null, new object[]
						{
							L
						});
					}
					else
					{
						Utils.ReflectionWrap(L, type, this.privateAccessibleFlags.Contains(type));
					}
				}
				bool flag4 = top != Lua.lua_gettop(L);
				if (flag4)
				{
					throw new Exception("top change, before:" + top.ToString() + ", after:" + Lua.lua_gettop(L).ToString());
				}
				foreach (Type nested_type in type.GetNestedTypes(BindingFlags.Public))
				{
					bool flag5 = nested_type.IsGenericTypeDefinition();
					if (!flag5)
					{
						this.GetTypeId(L, nested_type);
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0004A900 File Offset: 0x00048B00
		public void Alias(Type type, string alias)
		{
			Type alias_type = this.FindType(alias, false);
			bool flag = alias_type == null;
			if (flag)
			{
				throw new ArgumentException("Can not find " + alias);
			}
			this.aliasCfg[alias_type] = type;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0004A944 File Offset: 0x00048B44
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name)
		{
			foreach (Assembly assemblie in assemblies_usorted)
			{
				bool flag = assemblie.FullName.StartsWith(name) && !this.assemblies.Contains(assemblie);
				if (flag)
				{
					this.assemblies.Add(assemblie);
					break;
				}
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0004A9C0 File Offset: 0x00048BC0
		public ObjectTranslator(LuaEnv luaenv, IntPtr L)
		{
			this.assemblies = new List<Assembly>();
			this.assemblies.Add(Assembly.GetExecutingAssembly());
			Assembly[] assemblies_usorted = AppDomain.CurrentDomain.GetAssemblies();
			this.addAssemblieByName(assemblies_usorted, "mscorlib,");
			this.addAssemblieByName(assemblies_usorted, "System,");
			this.addAssemblieByName(assemblies_usorted, "System.Core,");
			foreach (Assembly assembly in assemblies_usorted)
			{
				bool flag = !this.assemblies.Contains(assembly);
				if (flag)
				{
					this.assemblies.Add(assembly);
				}
			}
			this.luaEnv = luaenv;
			this.objectCasters = new ObjectCasters(this);
			this.objectCheckers = new ObjectCheckers(this);
			this.methodWrapsCache = new MethodWrapsCache(this, this.objectCheckers, this.objectCasters);
			this.metaFunctions = new StaticLuaCallbacks();
			this.importTypeFunction = new lua_CSFunction(StaticLuaCallbacks.ImportType);
			this.loadAssemblyFunction = new lua_CSFunction(StaticLuaCallbacks.LoadAssembly);
			this.castFunction = new lua_CSFunction(StaticLuaCallbacks.Cast);
			Lua.lua_newtable(L);
			Lua.lua_newtable(L);
			Lua.xlua_pushasciistring(L, "__mode");
			Lua.xlua_pushasciistring(L, "v");
			Lua.lua_rawset(L, -3);
			Lua.lua_setmetatable(L, -2);
			this.cacheRef = Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
			this.initCSharpCallLua();
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0004AC74 File Offset: 0x00048E74
		private void initCSharpCallLua()
		{
			this.delegate_birdge_type = typeof(DelegateBridge);
			bool flag = !DelegateBridge.Gen_Flag;
			if (flag)
			{
				List<Type> cs_call_lua = new List<Type>();
				foreach (Type type2 in Utils.GetAllTypes(true))
				{
					bool flag2 = type2.IsDefined(typeof(CSharpCallLuaAttribute), false);
					if (flag2)
					{
						cs_call_lua.Add(type2);
					}
					bool flag3 = !type2.IsAbstract || !type2.IsSealed;
					if (!flag3)
					{
						foreach (FieldInfo field in type2.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
						{
							bool flag4 = field.IsDefined(typeof(CSharpCallLuaAttribute), false) && typeof(IEnumerable<Type>).IsAssignableFrom(field.FieldType);
							if (flag4)
							{
								cs_call_lua.AddRange(field.GetValue(null) as IEnumerable<Type>);
							}
						}
						foreach (PropertyInfo prop in type2.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
						{
							bool flag5 = prop.IsDefined(typeof(CSharpCallLuaAttribute), false) && typeof(IEnumerable<Type>).IsAssignableFrom(prop.PropertyType);
							if (flag5)
							{
								cs_call_lua.AddRange(prop.GetValue(null, null) as IEnumerable<Type>);
							}
						}
					}
				}
				IEnumerable<IGrouping<MethodInfo, Type>> groups = Enumerable.GroupBy<Type, MethodInfo>(from type in cs_call_lua
				where typeof(Delegate).IsAssignableFrom(type) && type != typeof(Delegate) && type != typeof(MulticastDelegate)
				where !type.GetMethod("Invoke").GetParameters().Any((ParameterInfo paramInfo) => paramInfo.ParameterType.IsGenericParameter)
				select type, (Type t) => t.GetMethod("Invoke"), new ObjectTranslator.CompareByArgRet());
				this.ce.SetGenInterfaces((from type in cs_call_lua
				where type.IsInterface()
				select type).ToList<Type>());
				this.delegate_birdge_type = this.ce.EmitDelegateImpl(groups);
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0004AEEC File Offset: 0x000490EC
		private Func<DelegateBridgeBase, Delegate> getCreatorUsingGeneric(DelegateBridgeBase bridge, Type delegateType, MethodInfo delegateMethod)
		{
			Func<DelegateBridgeBase, Delegate> genericDelegateCreator = null;
			bool flag = this.genericAction == null;
			if (flag)
			{
				MethodInfo[] methods = typeof(DelegateBridge).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
				this.genericAction = (from m in methods
				where m.Name == "Action"
				orderby m.GetParameters().Length
				select m).ToArray<MethodInfo>();
				this.genericFunc = (from m in methods
				where m.Name == "Func"
				orderby m.GetParameters().Length
				select m).ToArray<MethodInfo>();
			}
			bool flag2 = this.genericAction.Length != 5 || this.genericFunc.Length != 5;
			Func<DelegateBridgeBase, Delegate> result;
			if (flag2)
			{
				result = null;
			}
			else
			{
				ParameterInfo[] parameters = delegateMethod.GetParameters();
				bool flag3 = (delegateMethod.ReturnType.IsValueType() && delegateMethod.ReturnType != typeof(void)) || parameters.Length > 4;
				if (flag3)
				{
					genericDelegateCreator = ((DelegateBridgeBase x) => null);
				}
				else
				{
					foreach (ParameterInfo pinfo2 in parameters)
					{
						bool flag4 = pinfo2.ParameterType.IsValueType() || pinfo2.IsOut || pinfo2.ParameterType.IsByRef;
						if (flag4)
						{
							genericDelegateCreator = ((DelegateBridgeBase x) => null);
							break;
						}
					}
					bool flag5 = genericDelegateCreator == null;
					if (flag5)
					{
						IEnumerable<Type> typeArgs = from pinfo in parameters
						select pinfo.ParameterType;
						MethodInfo genericMethodInfo = null;
						bool flag6 = delegateMethod.ReturnType == typeof(void);
						if (flag6)
						{
							genericMethodInfo = this.genericAction[parameters.Length];
						}
						else
						{
							genericMethodInfo = this.genericFunc[parameters.Length];
							typeArgs = typeArgs.Concat(new Type[]
							{
								delegateMethod.ReturnType
							});
						}
						bool isGenericMethodDefinition = genericMethodInfo.IsGenericMethodDefinition;
						if (isGenericMethodDefinition)
						{
							MethodInfo methodInfo = genericMethodInfo.MakeGenericMethod(typeArgs.ToArray<Type>());
							genericDelegateCreator = ((DelegateBridgeBase o) => Delegate.CreateDelegate(delegateType, o, methodInfo));
						}
						else
						{
							genericDelegateCreator = ((DelegateBridgeBase o) => Delegate.CreateDelegate(delegateType, o, genericMethodInfo));
						}
					}
				}
				result = genericDelegateCreator;
			}
			return result;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0004B1E8 File Offset: 0x000493E8
		private Delegate getDelegate(DelegateBridgeBase bridge, Type delegateType)
		{
			Delegate ret = bridge.GetDelegateByType(delegateType);
			bool flag = ret != null;
			Delegate result;
			if (flag)
			{
				result = ret;
			}
			else
			{
				bool flag2 = delegateType == typeof(Delegate) || delegateType == typeof(MulticastDelegate);
				if (flag2)
				{
					result = null;
				}
				else
				{
					Func<DelegateBridgeBase, Delegate> delegateCreator;
					bool flag3 = !this.delegateCreatorCache.TryGetValue(delegateType, out delegateCreator);
					if (flag3)
					{
						MethodInfo delegateMethod = delegateType.GetMethod("Invoke");
						MethodInfo[] methods = (from m in bridge.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public)
						where !m.IsGenericMethodDefinition && (m.Name.StartsWith("__Gen_Delegate_Imp") || m.Name == "Action")
						select m).ToArray<MethodInfo>();
						for (int i = 0; i < methods.Length; i++)
						{
							bool flag4 = !methods[i].IsConstructor && Utils.IsParamsMatch(delegateMethod, methods[i]);
							if (flag4)
							{
								MethodInfo foundMethod = methods[i];
								delegateCreator = ((DelegateBridgeBase o) => Delegate.CreateDelegate(delegateType, o, foundMethod));
								break;
							}
						}
						bool flag5 = delegateCreator == null;
						if (flag5)
						{
							delegateCreator = this.getCreatorUsingGeneric(bridge, delegateType, delegateMethod);
						}
						this.delegateCreatorCache.Add(delegateType, delegateCreator);
					}
					ret = delegateCreator(bridge);
					bool flag6 = ret != null;
					if (!flag6)
					{
						throw new InvalidCastException("This type must add to CSharpCallLua: " + delegateType.GetFriendlyName());
					}
					result = ret;
				}
			}
			return result;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0004B398 File Offset: 0x00049598
		public object CreateDelegateBridge(IntPtr L, Type delegateType, int idx)
		{
			Lua.lua_pushvalue(L, idx);
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
			bool flag = !Lua.lua_isnil(L, -1);
			if (flag)
			{
				int referenced = Lua.xlua_tointeger(L, -1);
				Lua.lua_pop(L, 1);
				bool isAlive = this.delegate_bridges[referenced].IsAlive;
				if (isAlive)
				{
					bool flag2 = delegateType == null;
					if (flag2)
					{
						return this.delegate_bridges[referenced].Target;
					}
					DelegateBridgeBase exist_bridge = this.delegate_bridges[referenced].Target as DelegateBridgeBase;
					Delegate exist_delegate;
					bool flag3 = exist_bridge.TryGetDelegate(delegateType, out exist_delegate);
					if (flag3)
					{
						return exist_delegate;
					}
					exist_delegate = this.getDelegate(exist_bridge, delegateType);
					exist_bridge.AddDelegate(delegateType, exist_delegate);
					return exist_delegate;
				}
			}
			else
			{
				Lua.lua_pop(L, 1);
			}
			Lua.lua_pushvalue(L, idx);
			int reference = Lua.luaL_ref(L);
			Lua.lua_pushvalue(L, idx);
			Lua.lua_pushnumber(L, (double)reference);
			Lua.lua_rawset(L, LuaIndexes.LUA_REGISTRYINDEX);
			DelegateBridgeBase bridge;
			try
			{
				bool flag4 = !DelegateBridge.Gen_Flag;
				if (flag4)
				{
					bridge = (Activator.CreateInstance(this.delegate_birdge_type, new object[]
					{
						reference,
						this.luaEnv
					}) as DelegateBridgeBase);
				}
				else
				{
					bridge = new DelegateBridge(reference, this.luaEnv);
				}
			}
			catch (Exception e)
			{
				Lua.lua_pushvalue(L, idx);
				Lua.lua_pushnil(L);
				Lua.lua_rawset(L, LuaIndexes.LUA_REGISTRYINDEX);
				Lua.lua_pushnil(L);
				Lua.xlua_rawseti(L, LuaIndexes.LUA_REGISTRYINDEX, (long)reference);
				throw e;
			}
			bool flag5 = delegateType == null;
			object result;
			if (flag5)
			{
				this.delegate_bridges[reference] = new WeakReference(bridge);
				result = bridge;
			}
			else
			{
				try
				{
					Delegate ret = this.getDelegate(bridge, delegateType);
					bridge.AddDelegate(delegateType, ret);
					this.delegate_bridges[reference] = new WeakReference(bridge);
					result = ret;
				}
				catch (Exception e2)
				{
					bridge.Dispose();
					throw e2;
				}
			}
			return result;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0004B5AC File Offset: 0x000497AC
		public bool AllDelegateBridgeReleased()
		{
			foreach (KeyValuePair<int, WeakReference> kv in this.delegate_bridges)
			{
				bool isAlive = kv.Value.IsAlive;
				if (isAlive)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0004B618 File Offset: 0x00049818
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate)
		{
			if (is_delegate)
			{
				Lua.xlua_rawgeti(L, LuaIndexes.LUA_REGISTRYINDEX, (long)reference);
				bool flag = Lua.lua_isnil(L, -1);
				if (flag)
				{
					Lua.lua_pop(L, 1);
				}
				else
				{
					Lua.lua_pushvalue(L, -1);
					Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
					bool flag2 = Lua.lua_type(L, -1) == LuaTypes.LUA_TNUMBER && Lua.xlua_tointeger(L, -1) == reference;
					if (flag2)
					{
						Lua.lua_pop(L, 1);
						Lua.lua_pushnil(L);
						Lua.lua_rawset(L, LuaIndexes.LUA_REGISTRYINDEX);
					}
					else
					{
						Lua.lua_pop(L, 2);
					}
				}
				Lua.lua_unref(L, reference);
				this.delegate_bridges.Remove(reference);
			}
			else
			{
				Lua.lua_unref(L, reference);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0004B6D0 File Offset: 0x000498D0
		public object CreateInterfaceBridge(IntPtr L, Type interfaceType, int idx)
		{
			Func<int, LuaEnv, LuaBase> creator;
			bool flag = !this.interfaceBridgeCreators.TryGetValue(interfaceType, out creator);
			if (flag)
			{
				Type bridgeType = this.ce.EmitInterfaceImpl(interfaceType);
				creator = ((int reference, LuaEnv luaenv) => Activator.CreateInstance(bridgeType, new object[]
				{
					reference,
					this.luaEnv
				}) as LuaBase);
				this.interfaceBridgeCreators.Add(interfaceType, creator);
			}
			Lua.lua_pushvalue(L, idx);
			return creator(Lua.luaL_ref(L), this.luaEnv);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0004B750 File Offset: 0x00049950
		public void CreateArrayMetatable(IntPtr L)
		{
			Utils.BeginObjectRegister(null, L, this, 0, 0, 1, 0, this.common_array_meta);
			Utils.RegisterFunc(L, -2, "Length", new lua_CSFunction(StaticLuaCallbacks.ArrayLength));
			Utils.EndObjectRegister(null, L, this, null, null, typeof(Array), new lua_CSFunction(StaticLuaCallbacks.ArrayIndexer), new lua_CSFunction(StaticLuaCallbacks.ArrayNewIndexer));
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0004B7B8 File Offset: 0x000499B8
		public void CreateDelegateMetatable(IntPtr L)
		{
			Utils.BeginObjectRegister(null, L, this, 3, 0, 0, 0, this.common_delegate_meta);
			Utils.RegisterFunc(L, -4, "__call", new lua_CSFunction(StaticLuaCallbacks.DelegateCall));
			Utils.RegisterFunc(L, -4, "__add", new lua_CSFunction(StaticLuaCallbacks.DelegateCombine));
			Utils.RegisterFunc(L, -4, "__sub", new lua_CSFunction(StaticLuaCallbacks.DelegateRemove));
			Utils.EndObjectRegister(null, L, this, null, null, typeof(MulticastDelegate), null, null);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0004B840 File Offset: 0x00049A40
		internal void CreateEnumerablePairs(IntPtr L)
		{
			LuaFunction func = this.luaEnv.DoString("\r\n                return function(obj)\r\n                    local isKeyValuePair\r\n                    local function lua_iter(cs_iter, k)\r\n                        if cs_iter:MoveNext() then\r\n                            local current = cs_iter.Current\r\n                            if isKeyValuePair == nil then\r\n                                if type(current) == 'userdata' then\r\n                                    local t = current:GetType()\r\n                                    isKeyValuePair = t.Name == 'KeyValuePair`2' and t.Namespace == 'System.Collections.Generic'\r\n                                 else\r\n                                    isKeyValuePair = false\r\n                                 end\r\n                                 --print(current, isKeyValuePair)\r\n                            end\r\n                            if isKeyValuePair then\r\n                                return current.Key, current.Value\r\n                            else\r\n                                return k + 1, current\r\n                            end\r\n                        end\r\n                    end\r\n                    return lua_iter, obj:GetEnumerator(), -1\r\n                end\r\n            ", "chunk", null)[0] as LuaFunction;
			func.push(L);
			this.enumerable_pairs_func = Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
			func.Dispose();
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0004B88C File Offset: 0x00049A8C
		public void OpenLib(IntPtr L)
		{
			bool flag = Lua.xlua_getglobal(L, "xlua") != 0;
			if (flag)
			{
				throw new Exception("call xlua_getglobal fail!" + Lua.lua_tostring(L, -1));
			}
			Lua.xlua_pushasciistring(L, "import_type");
			Lua.lua_pushstdcallcfunction(L, this.importTypeFunction, 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "import_generic_type");
			Lua.lua_pushstdcallcfunction(L, new lua_CSFunction(StaticLuaCallbacks.ImportGenericType), 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "cast");
			Lua.lua_pushstdcallcfunction(L, this.castFunction, 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "load_assembly");
			Lua.lua_pushstdcallcfunction(L, this.loadAssemblyFunction, 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "access");
			Lua.lua_pushstdcallcfunction(L, new lua_CSFunction(StaticLuaCallbacks.XLuaAccess), 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "private_accessible");
			Lua.lua_pushstdcallcfunction(L, new lua_CSFunction(StaticLuaCallbacks.XLuaPrivateAccessible), 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "metatable_operation");
			Lua.lua_pushstdcallcfunction(L, new lua_CSFunction(StaticLuaCallbacks.XLuaMetatableOperation), 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "tofunction");
			Lua.lua_pushstdcallcfunction(L, new lua_CSFunction(StaticLuaCallbacks.ToFunction), 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "get_generic_method");
			Lua.lua_pushstdcallcfunction(L, new lua_CSFunction(StaticLuaCallbacks.GetGenericMethod), 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "release");
			Lua.lua_pushstdcallcfunction(L, new lua_CSFunction(StaticLuaCallbacks.ReleaseCsObject), 0);
			Lua.lua_rawset(L, -3);
			Lua.lua_pop(L, 1);
			Lua.lua_createtable(L, 1, 4);
			this.common_array_meta = Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.lua_createtable(L, 1, 4);
			this.common_delegate_meta = Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0004BA88 File Offset: 0x00049C88
		internal void createFunctionMetatable(IntPtr L)
		{
			Lua.lua_newtable(L);
			Lua.xlua_pushasciistring(L, "__gc");
			Lua.lua_pushstdcallcfunction(L, this.metaFunctions.GcMeta, 0);
			Lua.lua_rawset(L, -3);
			Lua.lua_pushlightuserdata(L, Lua.xlua_tag());
			Lua.lua_pushnumber(L, 1.0);
			Lua.lua_rawset(L, -3);
			Lua.lua_pushvalue(L, -1);
			int type_id = Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.lua_pushnumber(L, (double)type_id);
			Lua.xlua_rawseti(L, -2, 1L);
			Lua.lua_pop(L, 1);
			this.typeIdMap.Add(typeof(lua_CSFunction), type_id);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0004BB34 File Offset: 0x00049D34
		internal Type FindType(string className, bool isQualifiedName = false)
		{
			foreach (Assembly assembly in this.assemblies)
			{
				Type klass = assembly.GetType(className);
				bool flag = klass != null;
				if (flag)
				{
					return klass;
				}
			}
			int p = className.IndexOf('[');
			bool flag2 = p > 0 && !isQualifiedName;
			Type result;
			if (flag2)
			{
				string qualified_name = className.Substring(0, p + 1);
				string[] generic_params = className.Substring(p + 1, className.Length - qualified_name.Length - 1).Split(',', StringSplitOptions.None);
				for (int i = 0; i < generic_params.Length; i++)
				{
					Type generic_param = this.FindType(generic_params[i].Trim(), false);
					bool flag3 = generic_param == null;
					if (flag3)
					{
						return null;
					}
					bool flag4 = i != 0;
					if (flag4)
					{
						qualified_name += ", ";
					}
					qualified_name = qualified_name + "[" + generic_param.AssemblyQualifiedName + "]";
				}
				qualified_name += "]";
				result = this.FindType(qualified_name, true);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0004BC8C File Offset: 0x00049E8C
		private bool hasMethod(Type type, string methodName)
		{
			foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public))
			{
				bool flag = method.Name == methodName;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0004BCD8 File Offset: 0x00049ED8
		internal void collectObject(int obj_index_to_collect)
		{
			object o;
			bool flag = this.objects.TryGetValue(obj_index_to_collect, out o);
			if (flag)
			{
				this.objects.Remove(obj_index_to_collect);
				bool flag2 = o != null;
				if (flag2)
				{
					bool is_enum = o.GetType().IsEnum();
					int obj_index;
					bool flag3 = (is_enum ? this.enumMap.TryGetValue(o, out obj_index) : this.reverseMap.TryGetValue(o, out obj_index)) && obj_index == obj_index_to_collect;
					if (flag3)
					{
						bool flag4 = is_enum;
						if (flag4)
						{
							this.enumMap.Remove(o);
						}
						else
						{
							this.reverseMap.Remove(o);
						}
					}
				}
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0004BD7C File Offset: 0x00049F7C
		private int addObject(object obj, bool is_valuetype, bool is_enum)
		{
			int index = this.objects.Add(obj);
			if (is_enum)
			{
				this.enumMap[obj] = index;
			}
			else
			{
				bool flag = !is_valuetype;
				if (flag)
				{
					this.reverseMap[obj] = index;
				}
			}
			return index;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0004BDCC File Offset: 0x00049FCC
		internal object GetObject(IntPtr L, int index)
		{
			return this.objectCasters.GetCaster(typeof(object))(L, index, null);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0004BDFC File Offset: 0x00049FFC
		public Type GetTypeOf(IntPtr L, int idx)
		{
			Type type = null;
			int type_id = Lua.xlua_gettypeid(L, idx);
			bool flag = type_id != -1;
			if (flag)
			{
				this.typeMap.TryGetValue(type_id, out type);
			}
			return type;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0004BE38 File Offset: 0x0004A038
		public bool Assignable<T>(IntPtr L, int index)
		{
			return this.Assignable(L, index, typeof(T));
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0004BE5C File Offset: 0x0004A05C
		public bool Assignable(IntPtr L, int index, Type type)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				int udata = Lua.xlua_tocsobj_safe(L, index);
				object obj;
				bool flag2 = udata != -1 && this.objects.TryGetValue(udata, out obj);
				if (flag2)
				{
					RawObject rawObject = obj as RawObject;
					bool flag3 = rawObject != null;
					if (flag3)
					{
						obj = rawObject.Target;
					}
					bool flag4 = obj == null;
					if (flag4)
					{
						return !type.IsValueType();
					}
					return type.IsAssignableFrom(obj.GetType());
				}
				else
				{
					int type_id = Lua.xlua_gettypeid(L, index);
					Type type_of_struct;
					bool flag5 = type_id != -1 && this.typeMap.TryGetValue(type_id, out type_of_struct);
					if (flag5)
					{
						return type.IsAssignableFrom(type_of_struct);
					}
				}
			}
			return this.objectCheckers.GetChecker(type)(L, index);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0004BF30 File Offset: 0x0004A130
		public object GetObject(IntPtr L, int index, Type type)
		{
			int udata = Lua.xlua_tocsobj_safe(L, index);
			bool flag = udata != -1;
			object result;
			if (flag)
			{
				object obj = this.objects.Get(udata);
				RawObject rawObject = obj as RawObject;
				result = ((rawObject == null) ? obj : rawObject.Target);
			}
			else
			{
				bool flag2 = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
				if (flag2)
				{
					int type_id = Lua.xlua_gettypeid(L, index);
					bool flag3 = type_id != -1 && type_id == this.decimal_type_id;
					if (flag3)
					{
						decimal d;
						this.Get(L, index, out d);
						return d;
					}
					Type type_of_struct;
					ObjectTranslator.GetCSObject get;
					bool flag4 = type_id != -1 && this.typeMap.TryGetValue(type_id, out type_of_struct) && type.IsAssignableFrom(type_of_struct) && this.custom_get_funcs.TryGetValue(type, out get);
					if (flag4)
					{
						return get(L, index);
					}
				}
				result = this.objectCasters.GetCaster(type)(L, index, null);
			}
			return result;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0004C024 File Offset: 0x0004A224
		public void Get<T>(IntPtr L, int index, out T v)
		{
			Func<IntPtr, int, T> get_func;
			bool flag = this.tryGetGetFuncByType<Func<IntPtr, int, T>>(typeof(T), out get_func);
			if (flag)
			{
				v = get_func(L, index);
			}
			else
			{
				v = (T)((object)this.GetObject(L, index, typeof(T)));
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0004C07C File Offset: 0x0004A27C
		public void PushByType<T>(IntPtr L, T v)
		{
			Action<IntPtr, T> push_func;
			bool flag = this.tryGetPushFuncByType<Action<IntPtr, T>>(typeof(T), out push_func);
			if (flag)
			{
				push_func(L, v);
			}
			else
			{
				this.PushAny(L, v);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0004C0C0 File Offset: 0x0004A2C0
		public T[] GetParams<T>(IntPtr L, int index)
		{
			T[] ret = new T[Math.Max(Lua.lua_gettop(L) - index + 1, 0)];
			for (int i = 0; i < ret.Length; i++)
			{
				this.Get<T>(L, index + i, out ret[i]);
			}
			return ret;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0004C110 File Offset: 0x0004A310
		public Array GetParams(IntPtr L, int index, Type type)
		{
			Array ret = Array.CreateInstance(type, Math.Max(Lua.lua_gettop(L) - index + 1, 0));
			for (int i = 0; i < ret.Length; i++)
			{
				ret.SetValue(this.GetObject(L, index + i, type), i);
			}
			return ret;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0004C164 File Offset: 0x0004A364
		public void PushParams(IntPtr L, Array ary)
		{
			bool flag = ary != null;
			if (flag)
			{
				for (int i = 0; i < ary.Length; i++)
				{
					this.PushAny(L, ary.GetValue(i));
				}
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0004C1A4 File Offset: 0x0004A3A4
		public T GetDelegate<T>(IntPtr L, int index) where T : class
		{
			bool flag = Lua.lua_isfunction(L, index);
			T result;
			if (flag)
			{
				result = (this.CreateDelegateBridge(L, typeof(T), index) as T);
			}
			else
			{
				bool flag2 = Lua.lua_type(L, index) == LuaTypes.LUA_TUSERDATA;
				if (flag2)
				{
					result = (T)((object)this.SafeGetCSObj(L, index));
				}
				else
				{
					result = default(T);
				}
			}
			return result;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0004C20C File Offset: 0x0004A40C
		public int GetTypeId(IntPtr L, Type type)
		{
			bool isFirst;
			return this.getTypeId(L, type, out isFirst, ObjectTranslator.LOGLEVEL.WARN);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0004C22C File Offset: 0x0004A42C
		public void PrivateAccessible(IntPtr L, Type type)
		{
			bool flag = !this.privateAccessibleFlags.Contains(type);
			if (flag)
			{
				this.privateAccessibleFlags.Add(type);
				bool flag2 = this.typeIdMap.ContainsKey(type);
				if (flag2)
				{
					Utils.MakePrivateAccessible(L, type);
				}
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0004C278 File Offset: 0x0004A478
		internal int getTypeId(IntPtr L, Type type, out bool is_first, ObjectTranslator.LOGLEVEL log_level = ObjectTranslator.LOGLEVEL.WARN)
		{
			is_first = false;
			int type_id;
			bool flag = !this.typeIdMap.TryGetValue(type, out type_id);
			if (flag)
			{
				bool isArray = type.IsArray;
				if (isArray)
				{
					bool flag2 = this.common_array_meta == -1;
					if (flag2)
					{
						throw new Exception("Fatal Exception! Array Metatable not inited!");
					}
					return this.common_array_meta;
				}
				else
				{
					bool flag3 = typeof(MulticastDelegate).IsAssignableFrom(type);
					if (flag3)
					{
						bool flag4 = this.common_delegate_meta == -1;
						if (flag4)
						{
							throw new Exception("Fatal Exception! Delegate Metatable not inited!");
						}
						this.TryDelayWrapLoader(L, type);
						return this.common_delegate_meta;
					}
					else
					{
						is_first = true;
						Type alias_type = null;
						this.aliasCfg.TryGetValue(type, out alias_type);
						Lua.luaL_getmetatable(L, (alias_type == null) ? type.FullName : alias_type.FullName);
						bool flag5 = Lua.lua_isnil(L, -1);
						if (flag5)
						{
							Lua.lua_pop(L, 1);
							bool flag6 = this.TryDelayWrapLoader(L, (alias_type == null) ? type : alias_type);
							if (!flag6)
							{
								throw new Exception("Fatal: can not load metatable of type:" + ((type != null) ? type.ToString() : null));
							}
							Lua.luaL_getmetatable(L, (alias_type == null) ? type.FullName : alias_type.FullName);
						}
						bool flag7 = this.typeIdMap.TryGetValue(type, out type_id);
						if (flag7)
						{
							Lua.lua_pop(L, 1);
						}
						else
						{
							bool flag8 = type.IsEnum();
							if (flag8)
							{
								Lua.xlua_pushasciistring(L, "__band");
								Lua.lua_pushstdcallcfunction(L, this.metaFunctions.EnumAndMeta, 0);
								Lua.lua_rawset(L, -3);
								Lua.xlua_pushasciistring(L, "__bor");
								Lua.lua_pushstdcallcfunction(L, this.metaFunctions.EnumOrMeta, 0);
								Lua.lua_rawset(L, -3);
							}
							bool flag9 = typeof(IEnumerable).IsAssignableFrom(type);
							if (flag9)
							{
								Lua.xlua_pushasciistring(L, "__pairs");
								Lua.lua_getref(L, this.enumerable_pairs_func);
								Lua.lua_rawset(L, -3);
							}
							Lua.lua_pushvalue(L, -1);
							type_id = Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
							Lua.lua_pushnumber(L, (double)type_id);
							Lua.xlua_rawseti(L, -2, 1L);
							Lua.lua_pop(L, 1);
							bool flag10 = type.IsValueType();
							if (flag10)
							{
								this.typeMap.Add(type_id, type);
							}
							this.typeIdMap.Add(type, type_id);
						}
					}
				}
			}
			return type_id;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0004C4E0 File Offset: 0x0004A6E0
		private void pushPrimitive(IntPtr L, object o)
		{
			bool flag = o is sbyte || o is byte || o is short || o is ushort || o is int;
			if (flag)
			{
				int i = Convert.ToInt32(o);
				Lua.xlua_pushinteger(L, i);
			}
			else
			{
				bool flag2 = o is uint;
				if (flag2)
				{
					Lua.xlua_pushuint(L, (uint)o);
				}
				else
				{
					bool flag3 = o is float || o is double;
					if (flag3)
					{
						double d = Convert.ToDouble(o);
						Lua.lua_pushnumber(L, d);
					}
					else
					{
						bool flag4 = o is IntPtr;
						if (flag4)
						{
							Lua.lua_pushlightuserdata(L, (IntPtr)o);
						}
						else
						{
							bool flag5 = o is char;
							if (flag5)
							{
								Lua.xlua_pushinteger(L, (int)((char)o));
							}
							else
							{
								bool flag6 = o is long;
								if (flag6)
								{
									Lua.lua_pushint64(L, Convert.ToInt64(o));
								}
								else
								{
									bool flag7 = o is ulong;
									if (flag7)
									{
										Lua.lua_pushuint64(L, Convert.ToUInt64(o));
									}
									else
									{
										bool flag8 = o is bool;
										if (!flag8)
										{
											string str = "No support type ";
											Type type = o.GetType();
											throw new Exception(str + ((type != null) ? type.ToString() : null));
										}
										bool b = (bool)o;
										Lua.lua_pushboolean(L, b);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0004C654 File Offset: 0x0004A854
		public void PushAny(IntPtr L, object o)
		{
			bool flag = o == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Type type = o.GetType();
				bool flag2 = type.IsPrimitive();
				if (flag2)
				{
					this.pushPrimitive(L, o);
				}
				else
				{
					bool flag3 = o is string;
					if (flag3)
					{
						Lua.lua_pushstring(L, o as string);
					}
					else
					{
						bool flag4 = type == typeof(byte[]);
						if (flag4)
						{
							Lua.lua_pushstring(L, o as byte[]);
						}
						else
						{
							bool flag5 = o is decimal;
							if (flag5)
							{
								this.PushDecimal(L, (decimal)o);
							}
							else
							{
								bool flag6 = o is LuaBase;
								if (flag6)
								{
									((LuaBase)o).push(L);
								}
								else
								{
									bool flag7 = o is lua_CSFunction;
									if (flag7)
									{
										this.Push(L, o as lua_CSFunction);
									}
									else
									{
										bool flag8 = o is ValueType;
										if (flag8)
										{
											ObjectTranslator.PushCSObject push;
											bool flag9 = this.custom_push_funcs.TryGetValue(o.GetType(), out push);
											if (flag9)
											{
												push(L, o);
											}
											else
											{
												this.Push(L, o);
											}
										}
										else
										{
											this.Push(L, o);
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0004C798 File Offset: 0x0004A998
		public int TranslateToEnumToTop(IntPtr L, Type type, int idx)
		{
			LuaTypes lt = Lua.lua_type(L, idx);
			bool flag = lt == LuaTypes.LUA_TNUMBER;
			object res;
			if (flag)
			{
				int ival = (int)Lua.lua_tonumber(L, idx);
				res = Enum.ToObject(type, ival);
			}
			else
			{
				bool flag2 = lt == LuaTypes.LUA_TSTRING;
				if (!flag2)
				{
					return Lua.luaL_error(L, "#1 argument must be a integer or a string");
				}
				string sflags = Lua.lua_tostring(L, idx);
				res = Enum.Parse(type, sflags);
			}
			this.PushAny(L, res);
			return 1;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0004C810 File Offset: 0x0004AA10
		public void Push(IntPtr L, lua_CSFunction o)
		{
			bool flag = Utils.IsStaticPInvokeCSFunction(o);
			if (flag)
			{
				Lua.lua_pushstdcallcfunction(L, o, 0);
			}
			else
			{
				this.Push(L, o);
				Lua.lua_pushstdcallcfunction(L, this.metaFunctions.StaticCSFunctionWraper, 1);
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0004C854 File Offset: 0x0004AA54
		public void Push(IntPtr L, LuaBase o)
		{
			bool flag = o == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				o.push(L);
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0004C880 File Offset: 0x0004AA80
		public void Push(IntPtr L, object o)
		{
			bool flag = o == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				int index = -1;
				Type type = o.GetType();
				bool is_enum = type.IsEnum;
				bool is_valuetype = type.IsValueType;
				bool needcache = !is_valuetype || is_enum;
				bool flag2 = needcache && (is_enum ? this.enumMap.TryGetValue(o, out index) : this.reverseMap.TryGetValue(o, out index));
				if (flag2)
				{
					bool flag3 = Lua.xlua_tryget_cachedud(L, index, this.cacheRef) == 1;
					if (flag3)
					{
						return;
					}
				}
				bool is_first;
				int type_id = this.getTypeId(L, type, out is_first, ObjectTranslator.LOGLEVEL.WARN);
				bool flag4 = is_first && needcache && (is_enum ? this.enumMap.TryGetValue(o, out index) : this.reverseMap.TryGetValue(o, out index));
				if (flag4)
				{
					bool flag5 = Lua.xlua_tryget_cachedud(L, index, this.cacheRef) == 1;
					if (flag5)
					{
						return;
					}
				}
				index = this.addObject(o, is_valuetype, is_enum);
				Lua.xlua_pushcsobj(L, index, type_id, needcache, this.cacheRef);
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0004C984 File Offset: 0x0004AB84
		public void PushObject(IntPtr L, object o, int type_id)
		{
			bool flag = o == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				int index = -1;
				bool flag2 = this.reverseMap.TryGetValue(o, out index);
				if (flag2)
				{
					bool flag3 = Lua.xlua_tryget_cachedud(L, index, this.cacheRef) == 1;
					if (flag3)
					{
						return;
					}
				}
				index = this.addObject(o, false, false);
				Lua.xlua_pushcsobj(L, index, type_id, true, this.cacheRef);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0004C9EC File Offset: 0x0004ABEC
		public void Update(IntPtr L, int index, object obj)
		{
			int udata = Lua.xlua_tocsobj_fast(L, index);
			bool flag = udata != -1;
			if (flag)
			{
				this.objects.Replace(udata, obj);
			}
			else
			{
				ObjectTranslator.UpdateCSObject update;
				bool flag2 = this.custom_update_funcs.TryGetValue(obj.GetType(), out update);
				if (!flag2)
				{
					throw new Exception("can not update [" + ((obj != null) ? obj.ToString() : null) + "]");
				}
				update(L, index, obj);
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0004CA68 File Offset: 0x0004AC68
		private object getCsObj(IntPtr L, int index, int udata)
		{
			bool flag = udata == -1;
			object result;
			if (flag)
			{
				bool flag2 = Lua.lua_type(L, index) != LuaTypes.LUA_TUSERDATA;
				if (flag2)
				{
					result = null;
				}
				else
				{
					Type type = this.GetTypeOf(L, index);
					bool flag3 = type == typeof(decimal);
					if (flag3)
					{
						decimal v;
						this.Get(L, index, out v);
						result = v;
					}
					else
					{
						ObjectTranslator.GetCSObject get;
						bool flag4 = type != null && this.custom_get_funcs.TryGetValue(type, out get);
						if (flag4)
						{
							result = get(L, index);
						}
						else
						{
							result = null;
						}
					}
				}
			}
			else
			{
				object obj;
				bool flag5 = this.objects.TryGetValue(udata, out obj);
				if (flag5)
				{
					result = obj;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0004CB28 File Offset: 0x0004AD28
		internal object SafeGetCSObj(IntPtr L, int index)
		{
			return this.getCsObj(L, index, Lua.xlua_tocsobj_safe(L, index));
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0004CB4C File Offset: 0x0004AD4C
		internal object FastGetCSObj(IntPtr L, int index)
		{
			return this.getCsObj(L, index, Lua.xlua_tocsobj_fast(L, index));
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0004CB70 File Offset: 0x0004AD70
		internal void ReleaseCSObj(IntPtr L, int index)
		{
			int udata = Lua.xlua_tocsobj_safe(L, index);
			bool flag = udata != -1;
			if (flag)
			{
				object o = this.objects.Replace(udata, null);
				bool flag2 = o != null && this.reverseMap.ContainsKey(o);
				if (flag2)
				{
					this.reverseMap.Remove(o);
				}
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		internal lua_CSFunction GetFixCSFunction(int index)
		{
			return this.fix_cs_functions[index];
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0004CBE8 File Offset: 0x0004ADE8
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func)
		{
			bool flag = func == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.xlua_pushinteger(L, this.fix_cs_functions.Count);
				this.fix_cs_functions.Add(func);
				Lua.lua_pushstdcallcfunction(L, this.metaFunctions.FixCSFunctionWraper, 1);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0004CC40 File Offset: 0x0004AE40
		internal object[] popValues(IntPtr L, int oldTop)
		{
			int newTop = Lua.lua_gettop(L);
			bool flag = oldTop == newTop;
			object[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				ArrayList returnValues = new ArrayList();
				for (int i = oldTop + 1; i <= newTop; i++)
				{
					returnValues.Add(this.GetObject(L, i));
				}
				Lua.lua_settop(L, oldTop);
				result = returnValues.ToArray();
			}
			return result;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0004CCA8 File Offset: 0x0004AEA8
		internal object[] popValues(IntPtr L, int oldTop, Type[] popTypes)
		{
			int newTop = Lua.lua_gettop(L);
			bool flag = oldTop == newTop;
			object[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				ArrayList returnValues = new ArrayList();
				bool flag2 = popTypes[0] == typeof(void);
				int iTypes;
				if (flag2)
				{
					iTypes = 1;
				}
				else
				{
					iTypes = 0;
				}
				for (int i = oldTop + 1; i <= newTop; i++)
				{
					returnValues.Add(this.GetObject(L, i, popTypes[iTypes]));
					iTypes++;
				}
				Lua.lua_settop(L, oldTop);
				result = returnValues.ToArray();
			}
			return result;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0004CD38 File Offset: 0x0004AF38
		private void registerCustomOp(Type type, ObjectTranslator.PushCSObject push, ObjectTranslator.GetCSObject get, ObjectTranslator.UpdateCSObject update)
		{
			bool flag = push != null;
			if (flag)
			{
				this.custom_push_funcs.Add(type, push);
			}
			bool flag2 = get != null;
			if (flag2)
			{
				this.custom_get_funcs.Add(type, get);
			}
			bool flag3 = update != null;
			if (flag3)
			{
				this.custom_update_funcs.Add(type, update);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0004CD8C File Offset: 0x0004AF8C
		public bool HasCustomOp(Type type)
		{
			return this.custom_push_funcs.ContainsKey(type);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0004CDAC File Offset: 0x0004AFAC
		private bool tryGetPushFuncByType<T>(Type type, out T func) where T : class
		{
			bool flag = this.push_func_with_type == null;
			if (flag)
			{
				Dictionary<Type, Delegate> dictionary = new Dictionary<Type, Delegate>();
				dictionary.Add(typeof(int), new Action<IntPtr, int>(Lua.xlua_pushinteger));
				dictionary.Add(typeof(double), new Action<IntPtr, double>(Lua.lua_pushnumber));
				dictionary.Add(typeof(string), new Action<IntPtr, string>(Lua.lua_pushstring));
				dictionary.Add(typeof(byte[]), new Action<IntPtr, byte[]>(Lua.lua_pushstring));
				dictionary.Add(typeof(bool), new Action<IntPtr, bool>(Lua.lua_pushboolean));
				dictionary.Add(typeof(long), new Action<IntPtr, long>(Lua.lua_pushint64));
				dictionary.Add(typeof(ulong), new Action<IntPtr, ulong>(Lua.lua_pushuint64));
				dictionary.Add(typeof(IntPtr), new Action<IntPtr, IntPtr>(Lua.lua_pushlightuserdata));
				dictionary.Add(typeof(decimal), new Action<IntPtr, decimal>(this.PushDecimal));
				dictionary.Add(typeof(byte), new Action<IntPtr, byte>(delegate(IntPtr L, byte v)
				{
					Lua.xlua_pushinteger(L, (int)v);
				}));
				dictionary.Add(typeof(sbyte), new Action<IntPtr, sbyte>(delegate(IntPtr L, sbyte v)
				{
					Lua.xlua_pushinteger(L, (int)v);
				}));
				dictionary.Add(typeof(char), new Action<IntPtr, char>(delegate(IntPtr L, char v)
				{
					Lua.xlua_pushinteger(L, (int)v);
				}));
				dictionary.Add(typeof(short), new Action<IntPtr, short>(delegate(IntPtr L, short v)
				{
					Lua.xlua_pushinteger(L, (int)v);
				}));
				dictionary.Add(typeof(ushort), new Action<IntPtr, ushort>(delegate(IntPtr L, ushort v)
				{
					Lua.xlua_pushinteger(L, (int)v);
				}));
				dictionary.Add(typeof(uint), new Action<IntPtr, uint>(Lua.xlua_pushuint));
				dictionary.Add(typeof(float), new Action<IntPtr, float>(delegate(IntPtr L, float v)
				{
					Lua.lua_pushnumber(L, (double)v);
				}));
				this.push_func_with_type = dictionary;
			}
			Delegate obj;
			bool flag2 = this.push_func_with_type.TryGetValue(type, out obj);
			bool result;
			if (flag2)
			{
				func = (obj as T);
				result = true;
			}
			else
			{
				func = default(T);
				result = false;
			}
			return result;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0004D054 File Offset: 0x0004B254
		private bool tryGetGetFuncByType<T>(Type type, out T func) where T : class
		{
			bool flag = this.get_func_with_type == null;
			if (flag)
			{
				Dictionary<Type, Delegate> dictionary = new Dictionary<Type, Delegate>();
				dictionary.Add(typeof(int), new Func<IntPtr, int, int>(Lua.xlua_tointeger));
				dictionary.Add(typeof(double), new Func<IntPtr, int, double>(Lua.lua_tonumber));
				dictionary.Add(typeof(string), new Func<IntPtr, int, string>(Lua.lua_tostring));
				dictionary.Add(typeof(byte[]), new Func<IntPtr, int, byte[]>(Lua.lua_tobytes));
				dictionary.Add(typeof(bool), new Func<IntPtr, int, bool>(Lua.lua_toboolean));
				dictionary.Add(typeof(long), new Func<IntPtr, int, long>(Lua.lua_toint64));
				dictionary.Add(typeof(ulong), new Func<IntPtr, int, ulong>(Lua.lua_touint64));
				dictionary.Add(typeof(IntPtr), new Func<IntPtr, int, IntPtr>(Lua.lua_touserdata));
				dictionary.Add(typeof(decimal), new Func<IntPtr, int, decimal>(delegate(IntPtr L, int idx)
				{
					decimal ret;
					this.Get(L, idx, out ret);
					return ret;
				}));
				dictionary.Add(typeof(byte), new Func<IntPtr, int, byte>((IntPtr L, int idx) => (byte)Lua.xlua_tointeger(L, idx)));
				dictionary.Add(typeof(sbyte), new Func<IntPtr, int, sbyte>((IntPtr L, int idx) => (sbyte)Lua.xlua_tointeger(L, idx)));
				dictionary.Add(typeof(char), new Func<IntPtr, int, char>((IntPtr L, int idx) => (char)Lua.xlua_tointeger(L, idx)));
				dictionary.Add(typeof(short), new Func<IntPtr, int, short>((IntPtr L, int idx) => (short)Lua.xlua_tointeger(L, idx)));
				dictionary.Add(typeof(ushort), new Func<IntPtr, int, ushort>((IntPtr L, int idx) => (ushort)Lua.xlua_tointeger(L, idx)));
				dictionary.Add(typeof(uint), new Func<IntPtr, int, uint>(Lua.xlua_touint));
				dictionary.Add(typeof(float), new Func<IntPtr, int, float>((IntPtr L, int idx) => (float)Lua.lua_tonumber(L, idx)));
				this.get_func_with_type = dictionary;
			}
			Delegate obj;
			bool flag2 = this.get_func_with_type.TryGetValue(type, out obj);
			bool result;
			if (flag2)
			{
				func = (obj as T);
				result = true;
			}
			else
			{
				func = default(T);
				result = false;
			}
			return result;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0004D2FC File Offset: 0x0004B4FC
		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, ObjectTranslator.GetFunc<T> get, Action<IntPtr, int, T> update)
		{
			Type type = typeof(T);
			Action<IntPtr, T> org_push;
			Func<IntPtr, int, T> org_get;
			bool flag = this.tryGetPushFuncByType<Action<IntPtr, T>>(type, out org_push) || this.tryGetGetFuncByType<Func<IntPtr, int, T>>(type, out org_get);
			if (flag)
			{
				string str = "push or get of ";
				Type type2 = type;
				throw new InvalidOperationException(str + ((type2 != null) ? type2.ToString() : null) + " has register!");
			}
			this.push_func_with_type.Add(type, push);
			this.get_func_with_type.Add(type, new Func<IntPtr, int, T>(delegate(IntPtr L, int idx)
			{
				T ret;
				get(L, idx, out ret);
				return ret;
			}));
			this.registerCustomOp(type, delegate(IntPtr L, object obj)
			{
				push(L, (T)((object)obj));
			}, delegate(IntPtr L, int idx)
			{
				T val;
				get(L, idx, out val);
				return val;
			}, delegate(IntPtr L, int idx, object obj)
			{
				update(L, idx, (T)((object)obj));
			});
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0004D3C8 File Offset: 0x0004B5C8
		public void RegisterChecker<T>(ObjectTranslator.CheckFunc<T> check)
		{
			this.objectCheckers.AddChecker(typeof(T), (IntPtr L, int idx) => check(L, idx));
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0004D408 File Offset: 0x0004B608
		public void RegisterCaster<T>(ObjectTranslator.GetFunc<T> get)
		{
			this.objectCasters.AddCaster(typeof(T), delegate(IntPtr L, int idx, object o)
			{
				T obj;
				get(L, idx, out obj);
				return obj;
			});
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0004D448 File Offset: 0x0004B648
		public void PushDecimal(IntPtr L, decimal val)
		{
			bool flag = this.decimal_type_id == -1;
			if (flag)
			{
				bool is_first;
				this.decimal_type_id = this.getTypeId(L, typeof(decimal), out is_first, ObjectTranslator.LOGLEVEL.WARN);
			}
			IntPtr buff = Lua.xlua_pushstruct(L, 16U, this.decimal_type_id);
			bool flag2 = !CopyByValue.Pack(buff, 0, val);
			if (flag2)
			{
				throw new Exception("pack fail for decimal ,value=" + val.ToString());
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0004D4B8 File Offset: 0x0004B6B8
		public bool IsDecimal(IntPtr L, int index)
		{
			bool flag = this.decimal_type_id == -1;
			return !flag && Lua.xlua_gettypeid(L, index) == this.decimal_type_id;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0004D4EC File Offset: 0x0004B6EC
		public decimal GetDecimal(IntPtr L, int index)
		{
			decimal ret;
			this.Get(L, index, out ret);
			return ret;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0004D50C File Offset: 0x0004B70C
		public void Get(IntPtr L, int index, out decimal val)
		{
			LuaTypes lua_type = Lua.lua_type(L, index);
			bool flag = lua_type == LuaTypes.LUA_TUSERDATA;
			if (flag)
			{
				bool flag2 = Lua.xlua_gettypeid(L, index) != this.decimal_type_id;
				if (flag2)
				{
					throw new Exception("invalid userdata for decimal!");
				}
				IntPtr buff = Lua.lua_touserdata(L, index);
				bool flag3 = !CopyByValue.UnPack(buff, 0, out val);
				if (flag3)
				{
					throw new Exception("unpack decimal fail!");
				}
			}
			else
			{
				bool flag4 = lua_type == LuaTypes.LUA_TNUMBER;
				if (!flag4)
				{
					throw new Exception("invalid lua value for decimal, LuaType=" + lua_type.ToString());
				}
				bool flag5 = Lua.lua_isint64(L, index);
				if (flag5)
				{
					val = Lua.lua_toint64(L, index);
				}
				else
				{
					val = (decimal)Lua.lua_tonumber(L, index);
				}
			}
		}

		// Token: 0x04000C3F RID: 3135
		private static ObjectTranslator.IniterAdderUnityEngineVector2 s_IniterAdderUnityEngineVector2_dumb_obj = new ObjectTranslator.IniterAdderUnityEngineVector2();

		// Token: 0x04000C40 RID: 3136
		private int UnityEngineVector2_TypeID = -1;

		// Token: 0x04000C41 RID: 3137
		private int UnityEngineVector3_TypeID = -1;

		// Token: 0x04000C42 RID: 3138
		private int UnityEngineVector4_TypeID = -1;

		// Token: 0x04000C43 RID: 3139
		private int UnityEngineColor_TypeID = -1;

		// Token: 0x04000C44 RID: 3140
		private int UnityEngineQuaternion_TypeID = -1;

		// Token: 0x04000C45 RID: 3141
		private int UnityEngineRay_TypeID = -1;

		// Token: 0x04000C46 RID: 3142
		private int UnityEngineBounds_TypeID = -1;

		// Token: 0x04000C47 RID: 3143
		private int UnityEngineRay2D_TypeID = -1;

		// Token: 0x04000C48 RID: 3144
		private int TutorialTestEnum_TypeID = -1;

		// Token: 0x04000C49 RID: 3145
		private int TutorialTestEnum_EnumRef = -1;

		// Token: 0x04000C4A RID: 3146
		private int TutorialDerivedClassTestEnumInner_TypeID = -1;

		// Token: 0x04000C4B RID: 3147
		private int TutorialDerivedClassTestEnumInner_EnumRef = -1;

		// Token: 0x04000C4C RID: 3148
		private static XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua_Gen_Initer_Register__();

		// Token: 0x04000C4D RID: 3149
		internal MethodWrapsCache methodWrapsCache;

		// Token: 0x04000C4E RID: 3150
		internal ObjectCheckers objectCheckers;

		// Token: 0x04000C4F RID: 3151
		internal ObjectCasters objectCasters;

		// Token: 0x04000C50 RID: 3152
		internal readonly ObjectPool objects = new ObjectPool();

		// Token: 0x04000C51 RID: 3153
		internal readonly Dictionary<object, int> reverseMap = new Dictionary<object, int>(new ReferenceEqualsComparer());

		// Token: 0x04000C52 RID: 3154
		internal LuaEnv luaEnv;

		// Token: 0x04000C53 RID: 3155
		internal StaticLuaCallbacks metaFunctions;

		// Token: 0x04000C54 RID: 3156
		internal List<Assembly> assemblies;

		// Token: 0x04000C55 RID: 3157
		private lua_CSFunction importTypeFunction;

		// Token: 0x04000C56 RID: 3158
		private lua_CSFunction loadAssemblyFunction;

		// Token: 0x04000C57 RID: 3159
		private lua_CSFunction castFunction;

		// Token: 0x04000C58 RID: 3160
		private readonly Dictionary<Type, Action<IntPtr>> delayWrap = new Dictionary<Type, Action<IntPtr>>();

		// Token: 0x04000C59 RID: 3161
		private readonly Dictionary<Type, Func<int, LuaEnv, LuaBase>> interfaceBridgeCreators = new Dictionary<Type, Func<int, LuaEnv, LuaBase>>();

		// Token: 0x04000C5A RID: 3162
		private readonly Dictionary<Type, Type> aliasCfg = new Dictionary<Type, Type>();

		// Token: 0x04000C5B RID: 3163
		private Dictionary<Type, bool> loaded_types = new Dictionary<Type, bool>();

		// Token: 0x04000C5C RID: 3164
		public int cacheRef;

		// Token: 0x04000C5D RID: 3165
		private Type delegate_birdge_type;

		// Token: 0x04000C5E RID: 3166
		private CodeEmit ce = new CodeEmit();

		// Token: 0x04000C5F RID: 3167
		private MethodInfo[] genericAction = null;

		// Token: 0x04000C60 RID: 3168
		private MethodInfo[] genericFunc = null;

		// Token: 0x04000C61 RID: 3169
		private Dictionary<Type, Func<DelegateBridgeBase, Delegate>> delegateCreatorCache = new Dictionary<Type, Func<DelegateBridgeBase, Delegate>>();

		// Token: 0x04000C62 RID: 3170
		private Dictionary<int, WeakReference> delegate_bridges = new Dictionary<int, WeakReference>();

		// Token: 0x04000C63 RID: 3171
		private int common_array_meta = -1;

		// Token: 0x04000C64 RID: 3172
		private int common_delegate_meta = -1;

		// Token: 0x04000C65 RID: 3173
		private int enumerable_pairs_func = -1;

		// Token: 0x04000C66 RID: 3174
		private Dictionary<Type, int> typeIdMap = new Dictionary<Type, int>();

		// Token: 0x04000C67 RID: 3175
		private Dictionary<int, Type> typeMap = new Dictionary<int, Type>();

		// Token: 0x04000C68 RID: 3176
		private HashSet<Type> privateAccessibleFlags = new HashSet<Type>();

		// Token: 0x04000C69 RID: 3177
		private Dictionary<object, int> enumMap = new Dictionary<object, int>();

		// Token: 0x04000C6A RID: 3178
		private List<lua_CSFunction> fix_cs_functions = new List<lua_CSFunction>();

		// Token: 0x04000C6B RID: 3179
		private Dictionary<Type, ObjectTranslator.PushCSObject> custom_push_funcs = new Dictionary<Type, ObjectTranslator.PushCSObject>();

		// Token: 0x04000C6C RID: 3180
		private Dictionary<Type, ObjectTranslator.GetCSObject> custom_get_funcs = new Dictionary<Type, ObjectTranslator.GetCSObject>();

		// Token: 0x04000C6D RID: 3181
		private Dictionary<Type, ObjectTranslator.UpdateCSObject> custom_update_funcs = new Dictionary<Type, ObjectTranslator.UpdateCSObject>();

		// Token: 0x04000C6E RID: 3182
		private Dictionary<Type, Delegate> push_func_with_type = null;

		// Token: 0x04000C6F RID: 3183
		private Dictionary<Type, Delegate> get_func_with_type = null;

		// Token: 0x04000C70 RID: 3184
		private int decimal_type_id = -1;

		// Token: 0x02000132 RID: 306
		private class IniterAdderUnityEngineVector2
		{
			// Token: 0x060009D1 RID: 2513 RVA: 0x0004D60E File Offset: 0x0004B80E
			static IniterAdderUnityEngineVector2()
			{
				LuaEnv.AddIniter(new Action<LuaEnv, ObjectTranslator>(ObjectTranslator.IniterAdderUnityEngineVector2.Init));
			}

			// Token: 0x060009D2 RID: 2514 RVA: 0x0004D624 File Offset: 0x0004B824
			private static void Init(LuaEnv luaenv, ObjectTranslator translator)
			{
				translator.RegisterPushAndGetAndUpdate<Vector2>(new Action<IntPtr, Vector2>(translator.PushUnityEngineVector2), new ObjectTranslator.GetFunc<Vector2>(translator.Get), new Action<IntPtr, int, Vector2>(translator.UpdateUnityEngineVector2));
				translator.RegisterPushAndGetAndUpdate<Vector3>(new Action<IntPtr, Vector3>(translator.PushUnityEngineVector3), new ObjectTranslator.GetFunc<Vector3>(translator.Get), new Action<IntPtr, int, Vector3>(translator.UpdateUnityEngineVector3));
				translator.RegisterPushAndGetAndUpdate<Vector4>(new Action<IntPtr, Vector4>(translator.PushUnityEngineVector4), new ObjectTranslator.GetFunc<Vector4>(translator.Get), new Action<IntPtr, int, Vector4>(translator.UpdateUnityEngineVector4));
				translator.RegisterPushAndGetAndUpdate<Color>(new Action<IntPtr, Color>(translator.PushUnityEngineColor), new ObjectTranslator.GetFunc<Color>(translator.Get), new Action<IntPtr, int, Color>(translator.UpdateUnityEngineColor));
				translator.RegisterPushAndGetAndUpdate<Quaternion>(new Action<IntPtr, Quaternion>(translator.PushUnityEngineQuaternion), new ObjectTranslator.GetFunc<Quaternion>(translator.Get), new Action<IntPtr, int, Quaternion>(translator.UpdateUnityEngineQuaternion));
				translator.RegisterPushAndGetAndUpdate<Ray>(new Action<IntPtr, Ray>(translator.PushUnityEngineRay), new ObjectTranslator.GetFunc<Ray>(translator.Get), new Action<IntPtr, int, Ray>(translator.UpdateUnityEngineRay));
				translator.RegisterPushAndGetAndUpdate<Bounds>(new Action<IntPtr, Bounds>(translator.PushUnityEngineBounds), new ObjectTranslator.GetFunc<Bounds>(translator.Get), new Action<IntPtr, int, Bounds>(translator.UpdateUnityEngineBounds));
				translator.RegisterPushAndGetAndUpdate<Ray2D>(new Action<IntPtr, Ray2D>(translator.PushUnityEngineRay2D), new ObjectTranslator.GetFunc<Ray2D>(translator.Get), new Action<IntPtr, int, Ray2D>(translator.UpdateUnityEngineRay2D));
				translator.RegisterPushAndGetAndUpdate<TestEnum>(new Action<IntPtr, TestEnum>(translator.PushTutorialTestEnum), new ObjectTranslator.GetFunc<TestEnum>(translator.Get), new Action<IntPtr, int, TestEnum>(translator.UpdateTutorialTestEnum));
				translator.RegisterPushAndGetAndUpdate<DerivedClass.TestEnumInner>(new Action<IntPtr, DerivedClass.TestEnumInner>(translator.PushTutorialDerivedClassTestEnumInner), new ObjectTranslator.GetFunc<DerivedClass.TestEnumInner>(translator.Get), new Action<IntPtr, int, DerivedClass.TestEnumInner>(translator.UpdateTutorialDerivedClassTestEnumInner));
			}
		}

		// Token: 0x02000133 RID: 307
		internal enum LOGLEVEL
		{
			// Token: 0x04000C72 RID: 3186
			NO,
			// Token: 0x04000C73 RID: 3187
			INFO,
			// Token: 0x04000C74 RID: 3188
			WARN,
			// Token: 0x04000C75 RID: 3189
			ERROR
		}

		// Token: 0x02000134 RID: 308
		private class CompareByArgRet : IEqualityComparer<MethodInfo>
		{
			// Token: 0x060009D4 RID: 2516 RVA: 0x0004D7E0 File Offset: 0x0004B9E0
			public bool Equals(MethodInfo x, MethodInfo y)
			{
				return Utils.IsParamsMatch(x, y);
			}

			// Token: 0x060009D5 RID: 2517 RVA: 0x0004D7FC File Offset: 0x0004B9FC
			public int GetHashCode(MethodInfo method)
			{
				int hc = 0;
				hc += method.ReturnType.GetHashCode();
				foreach (ParameterInfo pi in method.GetParameters())
				{
					hc += pi.ParameterType.GetHashCode();
				}
				return hc;
			}
		}

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x060009D8 RID: 2520
		public delegate void PushCSObject(IntPtr L, object obj);

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x060009DC RID: 2524
		public delegate object GetCSObject(IntPtr L, int idx);

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x060009E0 RID: 2528
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x060009E4 RID: 2532
		public delegate bool CheckFunc<T>(IntPtr L, int idx);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x060009E8 RID: 2536
		public delegate void GetFunc<T>(IntPtr L, int idx, out T val);
	}
}

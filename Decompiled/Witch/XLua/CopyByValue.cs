using System;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000130 RID: 304
	public static class CopyByValue
	{
		// Token: 0x06000941 RID: 2369 RVA: 0x00048754 File Offset: 0x00046954
		public static void UnPack(ObjectTranslator translator, IntPtr L, int idx, out Vector2 val)
		{
			val = default(Vector2);
			int top = Lua.lua_gettop(L);
			bool flag = Utils.LoadField(L, idx, "x");
			if (flag)
			{
				translator.Get<float>(L, top + 1, out val.x);
			}
			Lua.lua_pop(L, 1);
			bool flag2 = Utils.LoadField(L, idx, "y");
			if (flag2)
			{
				translator.Get<float>(L, top + 1, out val.y);
			}
			Lua.lua_pop(L, 1);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000487C8 File Offset: 0x000469C8
		public static bool Pack(IntPtr buff, int offset, Vector2 field)
		{
			bool flag = !Lua.xlua_pack_float2(buff, offset, field.x, field.y);
			return !flag;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000487FC File Offset: 0x000469FC
		public static bool UnPack(IntPtr buff, int offset, out Vector2 field)
		{
			field = default(Vector2);
			float x = 0f;
			float y = 0f;
			bool flag = !Lua.xlua_unpack_float2(buff, offset, out x, out y);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				field.x = x;
				field.y = y;
				result = true;
			}
			return result;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00048848 File Offset: 0x00046A48
		public static void UnPack(ObjectTranslator translator, IntPtr L, int idx, out Vector3 val)
		{
			val = default(Vector3);
			int top = Lua.lua_gettop(L);
			bool flag = Utils.LoadField(L, idx, "x");
			if (flag)
			{
				translator.Get<float>(L, top + 1, out val.x);
			}
			Lua.lua_pop(L, 1);
			bool flag2 = Utils.LoadField(L, idx, "y");
			if (flag2)
			{
				translator.Get<float>(L, top + 1, out val.y);
			}
			Lua.lua_pop(L, 1);
			bool flag3 = Utils.LoadField(L, idx, "z");
			if (flag3)
			{
				translator.Get<float>(L, top + 1, out val.z);
			}
			Lua.lua_pop(L, 1);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000488E8 File Offset: 0x00046AE8
		public static bool Pack(IntPtr buff, int offset, Vector3 field)
		{
			bool flag = !Lua.xlua_pack_float3(buff, offset, field.x, field.y, field.z);
			return !flag;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00048920 File Offset: 0x00046B20
		public static bool UnPack(IntPtr buff, int offset, out Vector3 field)
		{
			field = default(Vector3);
			float x = 0f;
			float y = 0f;
			float z = 0f;
			bool flag = !Lua.xlua_unpack_float3(buff, offset, out x, out y, out z);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				field.x = x;
				field.y = y;
				field.z = z;
				result = true;
			}
			return result;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00048980 File Offset: 0x00046B80
		public static void UnPack(ObjectTranslator translator, IntPtr L, int idx, out Vector4 val)
		{
			val = default(Vector4);
			int top = Lua.lua_gettop(L);
			bool flag = Utils.LoadField(L, idx, "x");
			if (flag)
			{
				translator.Get<float>(L, top + 1, out val.x);
			}
			Lua.lua_pop(L, 1);
			bool flag2 = Utils.LoadField(L, idx, "y");
			if (flag2)
			{
				translator.Get<float>(L, top + 1, out val.y);
			}
			Lua.lua_pop(L, 1);
			bool flag3 = Utils.LoadField(L, idx, "z");
			if (flag3)
			{
				translator.Get<float>(L, top + 1, out val.z);
			}
			Lua.lua_pop(L, 1);
			bool flag4 = Utils.LoadField(L, idx, "w");
			if (flag4)
			{
				translator.Get<float>(L, top + 1, out val.w);
			}
			Lua.lua_pop(L, 1);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00048A4C File Offset: 0x00046C4C
		public static bool Pack(IntPtr buff, int offset, Vector4 field)
		{
			bool flag = !Lua.xlua_pack_float4(buff, offset, field.x, field.y, field.z, field.w);
			return !flag;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00048A8C File Offset: 0x00046C8C
		public static bool UnPack(IntPtr buff, int offset, out Vector4 field)
		{
			field = default(Vector4);
			float x = 0f;
			float y = 0f;
			float z = 0f;
			float w = 0f;
			bool flag = !Lua.xlua_unpack_float4(buff, offset, out x, out y, out z, out w);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				field.x = x;
				field.y = y;
				field.z = z;
				field.w = w;
				result = true;
			}
			return result;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00048AFC File Offset: 0x00046CFC
		public static void UnPack(ObjectTranslator translator, IntPtr L, int idx, out Color val)
		{
			val = default(Color);
			int top = Lua.lua_gettop(L);
			bool flag = Utils.LoadField(L, idx, "r");
			if (flag)
			{
				translator.Get<float>(L, top + 1, out val.r);
			}
			Lua.lua_pop(L, 1);
			bool flag2 = Utils.LoadField(L, idx, "g");
			if (flag2)
			{
				translator.Get<float>(L, top + 1, out val.g);
			}
			Lua.lua_pop(L, 1);
			bool flag3 = Utils.LoadField(L, idx, "b");
			if (flag3)
			{
				translator.Get<float>(L, top + 1, out val.b);
			}
			Lua.lua_pop(L, 1);
			bool flag4 = Utils.LoadField(L, idx, "a");
			if (flag4)
			{
				translator.Get<float>(L, top + 1, out val.a);
			}
			Lua.lua_pop(L, 1);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00048BC8 File Offset: 0x00046DC8
		public static bool Pack(IntPtr buff, int offset, Color field)
		{
			bool flag = !Lua.xlua_pack_float4(buff, offset, field.r, field.g, field.b, field.a);
			return !flag;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00048C08 File Offset: 0x00046E08
		public static bool UnPack(IntPtr buff, int offset, out Color field)
		{
			field = default(Color);
			float r = 0f;
			float g = 0f;
			float b = 0f;
			float a = 0f;
			bool flag = !Lua.xlua_unpack_float4(buff, offset, out r, out g, out b, out a);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				field.r = r;
				field.g = g;
				field.b = b;
				field.a = a;
				result = true;
			}
			return result;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00048C78 File Offset: 0x00046E78
		public static void UnPack(ObjectTranslator translator, IntPtr L, int idx, out Quaternion val)
		{
			val = default(Quaternion);
			int top = Lua.lua_gettop(L);
			bool flag = Utils.LoadField(L, idx, "x");
			if (flag)
			{
				translator.Get<float>(L, top + 1, out val.x);
			}
			Lua.lua_pop(L, 1);
			bool flag2 = Utils.LoadField(L, idx, "y");
			if (flag2)
			{
				translator.Get<float>(L, top + 1, out val.y);
			}
			Lua.lua_pop(L, 1);
			bool flag3 = Utils.LoadField(L, idx, "z");
			if (flag3)
			{
				translator.Get<float>(L, top + 1, out val.z);
			}
			Lua.lua_pop(L, 1);
			bool flag4 = Utils.LoadField(L, idx, "w");
			if (flag4)
			{
				translator.Get<float>(L, top + 1, out val.w);
			}
			Lua.lua_pop(L, 1);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00048D44 File Offset: 0x00046F44
		public static bool Pack(IntPtr buff, int offset, Quaternion field)
		{
			bool flag = !Lua.xlua_pack_float4(buff, offset, field.x, field.y, field.z, field.w);
			return !flag;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00048D84 File Offset: 0x00046F84
		public static bool UnPack(IntPtr buff, int offset, out Quaternion field)
		{
			field = default(Quaternion);
			float x = 0f;
			float y = 0f;
			float z = 0f;
			float w = 0f;
			bool flag = !Lua.xlua_unpack_float4(buff, offset, out x, out y, out z, out w);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				field.x = x;
				field.y = y;
				field.z = z;
				field.w = w;
				result = true;
			}
			return result;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00048DF4 File Offset: 0x00046FF4
		public static void UnPack(ObjectTranslator translator, IntPtr L, int idx, out Ray val)
		{
			val = default(Ray);
			int top = Lua.lua_gettop(L);
			bool flag = Utils.LoadField(L, idx, "origin");
			if (flag)
			{
				Vector3 origin = val.origin;
				translator.Get(L, top + 1, out origin);
				val.origin = origin;
			}
			Lua.lua_pop(L, 1);
			bool flag2 = Utils.LoadField(L, idx, "direction");
			if (flag2)
			{
				Vector3 direction = val.direction;
				translator.Get(L, top + 1, out direction);
				val.direction = direction;
			}
			Lua.lua_pop(L, 1);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00048E80 File Offset: 0x00047080
		public static bool Pack(IntPtr buff, int offset, Ray field)
		{
			bool flag = !CopyByValue.Pack(buff, offset, field.origin);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = !CopyByValue.Pack(buff, offset + 12, field.direction);
				result = !flag2;
			}
			return result;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00048ECC File Offset: 0x000470CC
		public static bool UnPack(IntPtr buff, int offset, out Ray field)
		{
			field = default(Ray);
			Vector3 origin = field.origin;
			bool flag = !CopyByValue.UnPack(buff, offset, out origin);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				field.origin = origin;
				Vector3 direction = field.direction;
				bool flag2 = !CopyByValue.UnPack(buff, offset + 12, out direction);
				if (flag2)
				{
					result = false;
				}
				else
				{
					field.direction = direction;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00048F34 File Offset: 0x00047134
		public static void UnPack(ObjectTranslator translator, IntPtr L, int idx, out Bounds val)
		{
			val = default(Bounds);
			int top = Lua.lua_gettop(L);
			bool flag = Utils.LoadField(L, idx, "center");
			if (flag)
			{
				Vector3 center = val.center;
				translator.Get(L, top + 1, out center);
				val.center = center;
			}
			Lua.lua_pop(L, 1);
			bool flag2 = Utils.LoadField(L, idx, "extents");
			if (flag2)
			{
				Vector3 extents = val.extents;
				translator.Get(L, top + 1, out extents);
				val.extents = extents;
			}
			Lua.lua_pop(L, 1);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00048FC0 File Offset: 0x000471C0
		public static bool Pack(IntPtr buff, int offset, Bounds field)
		{
			bool flag = !CopyByValue.Pack(buff, offset, field.center);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = !CopyByValue.Pack(buff, offset + 12, field.extents);
				result = !flag2;
			}
			return result;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0004900C File Offset: 0x0004720C
		public static bool UnPack(IntPtr buff, int offset, out Bounds field)
		{
			field = default(Bounds);
			Vector3 center = field.center;
			bool flag = !CopyByValue.UnPack(buff, offset, out center);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				field.center = center;
				Vector3 extents = field.extents;
				bool flag2 = !CopyByValue.UnPack(buff, offset + 12, out extents);
				if (flag2)
				{
					result = false;
				}
				else
				{
					field.extents = extents;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00049074 File Offset: 0x00047274
		public static void UnPack(ObjectTranslator translator, IntPtr L, int idx, out Ray2D val)
		{
			val = default(Ray2D);
			int top = Lua.lua_gettop(L);
			bool flag = Utils.LoadField(L, idx, "origin");
			if (flag)
			{
				Vector2 origin = val.origin;
				translator.Get(L, top + 1, out origin);
				val.origin = origin;
			}
			Lua.lua_pop(L, 1);
			bool flag2 = Utils.LoadField(L, idx, "direction");
			if (flag2)
			{
				Vector2 direction = val.direction;
				translator.Get(L, top + 1, out direction);
				val.direction = direction;
			}
			Lua.lua_pop(L, 1);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00049100 File Offset: 0x00047300
		public static bool Pack(IntPtr buff, int offset, Ray2D field)
		{
			bool flag = !CopyByValue.Pack(buff, offset, field.origin);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = !CopyByValue.Pack(buff, offset + 8, field.direction);
				result = !flag2;
			}
			return result;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0004914C File Offset: 0x0004734C
		public static bool UnPack(IntPtr buff, int offset, out Ray2D field)
		{
			field = default(Ray2D);
			Vector2 origin = field.origin;
			bool flag = !CopyByValue.UnPack(buff, offset, out origin);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				field.origin = origin;
				Vector2 direction = field.direction;
				bool flag2 = !CopyByValue.UnPack(buff, offset + 8, out direction);
				if (flag2)
				{
					result = false;
				}
				else
				{
					field.direction = direction;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000491B4 File Offset: 0x000473B4
		public static bool Pack(IntPtr buff, int offset, byte field)
		{
			return Lua.xlua_pack_int8_t(buff, offset, field);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000491D0 File Offset: 0x000473D0
		public static bool UnPack(IntPtr buff, int offset, out byte field)
		{
			return Lua.xlua_unpack_int8_t(buff, offset, out field);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000491EC File Offset: 0x000473EC
		public static bool Pack(IntPtr buff, int offset, sbyte field)
		{
			return Lua.xlua_pack_int8_t(buff, offset, (byte)field);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00049208 File Offset: 0x00047408
		public static bool UnPack(IntPtr buff, int offset, out sbyte field)
		{
			byte tfield;
			bool ret = Lua.xlua_unpack_int8_t(buff, offset, out tfield);
			field = (sbyte)tfield;
			return ret;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0004922C File Offset: 0x0004742C
		public static bool Pack(IntPtr buff, int offset, short field)
		{
			return Lua.xlua_pack_int16_t(buff, offset, field);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00049248 File Offset: 0x00047448
		public static bool UnPack(IntPtr buff, int offset, out short field)
		{
			return Lua.xlua_unpack_int16_t(buff, offset, out field);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00049264 File Offset: 0x00047464
		public static bool Pack(IntPtr buff, int offset, ushort field)
		{
			return Lua.xlua_pack_int16_t(buff, offset, (short)field);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00049280 File Offset: 0x00047480
		public static bool UnPack(IntPtr buff, int offset, out ushort field)
		{
			short tfield;
			bool ret = Lua.xlua_unpack_int16_t(buff, offset, out tfield);
			field = (ushort)tfield;
			return ret;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000492A4 File Offset: 0x000474A4
		public static bool Pack(IntPtr buff, int offset, int field)
		{
			return Lua.xlua_pack_int32_t(buff, offset, field);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000492C0 File Offset: 0x000474C0
		public static bool UnPack(IntPtr buff, int offset, out int field)
		{
			return Lua.xlua_unpack_int32_t(buff, offset, out field);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000492DC File Offset: 0x000474DC
		public static bool Pack(IntPtr buff, int offset, uint field)
		{
			return Lua.xlua_pack_int32_t(buff, offset, (int)field);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000492F8 File Offset: 0x000474F8
		public static bool UnPack(IntPtr buff, int offset, out uint field)
		{
			int tfield;
			bool ret = Lua.xlua_unpack_int32_t(buff, offset, out tfield);
			field = (uint)tfield;
			return ret;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00049318 File Offset: 0x00047518
		public static bool Pack(IntPtr buff, int offset, long field)
		{
			return Lua.xlua_pack_int64_t(buff, offset, field);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00049334 File Offset: 0x00047534
		public static bool UnPack(IntPtr buff, int offset, out long field)
		{
			return Lua.xlua_unpack_int64_t(buff, offset, out field);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00049350 File Offset: 0x00047550
		public static bool Pack(IntPtr buff, int offset, ulong field)
		{
			return Lua.xlua_pack_int64_t(buff, offset, (long)field);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0004936C File Offset: 0x0004756C
		public static bool UnPack(IntPtr buff, int offset, out ulong field)
		{
			long tfield;
			bool ret = Lua.xlua_unpack_int64_t(buff, offset, out tfield);
			field = (ulong)tfield;
			return ret;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0004938C File Offset: 0x0004758C
		public static bool Pack(IntPtr buff, int offset, float field)
		{
			return Lua.xlua_pack_float(buff, offset, field);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000493A8 File Offset: 0x000475A8
		public static bool UnPack(IntPtr buff, int offset, out float field)
		{
			return Lua.xlua_unpack_float(buff, offset, out field);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000493C4 File Offset: 0x000475C4
		public static bool Pack(IntPtr buff, int offset, double field)
		{
			return Lua.xlua_pack_double(buff, offset, field);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000493E0 File Offset: 0x000475E0
		public static bool UnPack(IntPtr buff, int offset, out double field)
		{
			return Lua.xlua_unpack_double(buff, offset, out field);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000493FC File Offset: 0x000475FC
		public static bool Pack(IntPtr buff, int offset, decimal field)
		{
			return Lua.xlua_pack_decimal(buff, offset, ref field);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00049418 File Offset: 0x00047618
		public static bool UnPack(IntPtr buff, int offset, out decimal field)
		{
			byte scale;
			byte sign;
			int hi32;
			ulong lo64;
			bool flag = !Lua.xlua_unpack_decimal(buff, offset, out scale, out sign, out hi32, out lo64);
			bool result;
			if (flag)
			{
				field = 0m;
				result = false;
			}
			else
			{
				field = new decimal((int)(lo64 & (ulong)-1), (int)(lo64 >> 32), hi32, (sign & 128) > 0, scale);
				result = true;
			}
			return result;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00049474 File Offset: 0x00047674
		public static bool IsStruct(Type type)
		{
			return type.IsValueType() && !type.IsEnum() && !type.IsPrimitive();
		}
	}
}

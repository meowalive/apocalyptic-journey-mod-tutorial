using System;
using System.Runtime.InteropServices;
using System.Text;

namespace XLua.LuaDLL
{
	// Token: 0x020001A1 RID: 417
	public class Lua
	{
		// Token: 0x06000BF0 RID: 3056
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lua_tothread(IntPtr L, int index);

		// Token: 0x06000BF1 RID: 3057
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_get_lib_version();

		// Token: 0x06000BF2 RID: 3058
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_gc(IntPtr L, LuaGCOptions what, int data);

		// Token: 0x06000BF3 RID: 3059
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n);

		// Token: 0x06000BF4 RID: 3060
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n);

		// Token: 0x06000BF5 RID: 3061
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_pushthread(IntPtr L);

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0005E810 File Offset: 0x0005CA10
		public static bool lua_isfunction(IntPtr L, int stackPos)
		{
			return Lua.lua_type(L, stackPos) == LuaTypes.LUA_TFUNCTION;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0005E82C File Offset: 0x0005CA2C
		public static bool lua_islightuserdata(IntPtr L, int stackPos)
		{
			return Lua.lua_type(L, stackPos) == LuaTypes.LUA_TLIGHTUSERDATA;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0005E848 File Offset: 0x0005CA48
		public static bool lua_istable(IntPtr L, int stackPos)
		{
			return Lua.lua_type(L, stackPos) == LuaTypes.LUA_TTABLE;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0005E864 File Offset: 0x0005CA64
		public static bool lua_isthread(IntPtr L, int stackPos)
		{
			return Lua.lua_type(L, stackPos) == LuaTypes.LUA_TTHREAD;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0005E880 File Offset: 0x0005CA80
		public static int luaL_error(IntPtr L, string message)
		{
			Lua.xlua_csharp_str_error(L, message);
			return 0;
		}

		// Token: 0x06000BFB RID: 3067
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_setfenv(IntPtr L, int stackPos);

		// Token: 0x06000BFC RID: 3068
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr luaL_newstate();

		// Token: 0x06000BFD RID: 3069
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_close(IntPtr L);

		// Token: 0x06000BFE RID: 3070
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void luaopen_xlua(IntPtr L);

		// Token: 0x06000BFF RID: 3071
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void luaL_openlibs(IntPtr L);

		// Token: 0x06000C00 RID: 3072
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint xlua_objlen(IntPtr L, int stackPos);

		// Token: 0x06000C01 RID: 3073
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_createtable(IntPtr L, int narr, int nrec);

		// Token: 0x06000C02 RID: 3074 RVA: 0x0005E89B File Offset: 0x0005CA9B
		public static void lua_newtable(IntPtr L)
		{
			Lua.lua_createtable(L, 0, 0);
		}

		// Token: 0x06000C03 RID: 3075
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_getglobal(IntPtr L, string name);

		// Token: 0x06000C04 RID: 3076
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_setglobal(IntPtr L, string name);

		// Token: 0x06000C05 RID: 3077
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_getloaders(IntPtr L);

		// Token: 0x06000C06 RID: 3078
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_settop(IntPtr L, int newTop);

		// Token: 0x06000C07 RID: 3079 RVA: 0x0005E8A7 File Offset: 0x0005CAA7
		public static void lua_pop(IntPtr L, int amount)
		{
			Lua.lua_settop(L, -amount - 1);
		}

		// Token: 0x06000C08 RID: 3080
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_insert(IntPtr L, int newTop);

		// Token: 0x06000C09 RID: 3081
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_remove(IntPtr L, int index);

		// Token: 0x06000C0A RID: 3082
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_rawget(IntPtr L, int index);

		// Token: 0x06000C0B RID: 3083
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_rawset(IntPtr L, int index);

		// Token: 0x06000C0C RID: 3084
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_setmetatable(IntPtr L, int objIndex);

		// Token: 0x06000C0D RID: 3085
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_rawequal(IntPtr L, int index1, int index2);

		// Token: 0x06000C0E RID: 3086
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_pushvalue(IntPtr L, int index);

		// Token: 0x06000C0F RID: 3087
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n);

		// Token: 0x06000C10 RID: 3088
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_replace(IntPtr L, int index);

		// Token: 0x06000C11 RID: 3089
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_gettop(IntPtr L);

		// Token: 0x06000C12 RID: 3090
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern LuaTypes lua_type(IntPtr L, int index);

		// Token: 0x06000C13 RID: 3091 RVA: 0x0005E8B8 File Offset: 0x0005CAB8
		public static bool lua_isnil(IntPtr L, int index)
		{
			return Lua.lua_type(L, index) == LuaTypes.LUA_TNIL;
		}

		// Token: 0x06000C14 RID: 3092
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool lua_isnumber(IntPtr L, int index);

		// Token: 0x06000C15 RID: 3093 RVA: 0x0005E8D4 File Offset: 0x0005CAD4
		public static bool lua_isboolean(IntPtr L, int index)
		{
			return Lua.lua_type(L, index) == LuaTypes.LUA_TBOOLEAN;
		}

		// Token: 0x06000C16 RID: 3094
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int luaL_ref(IntPtr L, int registryIndex);

		// Token: 0x06000C17 RID: 3095 RVA: 0x0005E8F0 File Offset: 0x0005CAF0
		public static int luaL_ref(IntPtr L)
		{
			return Lua.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
		}

		// Token: 0x06000C18 RID: 3096
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index);

		// Token: 0x06000C19 RID: 3097
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index);

		// Token: 0x06000C1A RID: 3098 RVA: 0x0005E90D File Offset: 0x0005CB0D
		public static void lua_getref(IntPtr L, int reference)
		{
			Lua.xlua_rawgeti(L, LuaIndexes.LUA_REGISTRYINDEX, (long)reference);
		}

		// Token: 0x06000C1B RID: 3099
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref);

		// Token: 0x06000C1C RID: 3100
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference);

		// Token: 0x06000C1D RID: 3101 RVA: 0x0005E91E File Offset: 0x0005CB1E
		public static void lua_unref(IntPtr L, int reference)
		{
			Lua.luaL_unref(L, LuaIndexes.LUA_REGISTRYINDEX, reference);
		}

		// Token: 0x06000C1E RID: 3102
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool lua_isstring(IntPtr L, int index);

		// Token: 0x06000C1F RID: 3103
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool lua_isinteger(IntPtr L, int index);

		// Token: 0x06000C20 RID: 3104
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_pushnil(IntPtr L);

		// Token: 0x06000C21 RID: 3105 RVA: 0x0005E930 File Offset: 0x0005CB30
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0)
		{
			IntPtr fn = Marshal.GetFunctionPointerForDelegate<lua_CSFunction>(function);
			Lua.xlua_push_csharp_function(L, fn, n);
		}

		// Token: 0x06000C22 RID: 3106
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_upvalueindex(int n);

		// Token: 0x06000C23 RID: 3107
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc);

		// Token: 0x06000C24 RID: 3108
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern double lua_tonumber(IntPtr L, int index);

		// Token: 0x06000C25 RID: 3109
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_tointeger(IntPtr L, int index);

		// Token: 0x06000C26 RID: 3110
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint xlua_touint(IntPtr L, int index);

		// Token: 0x06000C27 RID: 3111
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool lua_toboolean(IntPtr L, int index);

		// Token: 0x06000C28 RID: 3112
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lua_topointer(IntPtr L, int index);

		// Token: 0x06000C29 RID: 3113
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen);

		// Token: 0x06000C2A RID: 3114 RVA: 0x0005E950 File Offset: 0x0005CB50
		public static string lua_tostring(IntPtr L, int index)
		{
			IntPtr strlen;
			IntPtr str = Lua.lua_tolstring(L, index, out strlen);
			bool flag = str != IntPtr.Zero;
			string result;
			if (flag)
			{
				string ret = Marshal.PtrToStringAnsi(str, strlen.ToInt32());
				bool flag2 = ret == null;
				if (flag2)
				{
					int len = strlen.ToInt32();
					byte[] buffer = new byte[len];
					Marshal.Copy(str, buffer, 0, len);
					result = Encoding.UTF8.GetString(buffer);
				}
				else
				{
					result = ret;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000C2B RID: 3115
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf);

		// Token: 0x06000C2C RID: 3116
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_pushnumber(IntPtr L, double number);

		// Token: 0x06000C2D RID: 3117
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_pushboolean(IntPtr L, bool value);

		// Token: 0x06000C2E RID: 3118
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_pushinteger(IntPtr L, int value);

		// Token: 0x06000C2F RID: 3119
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_pushuint(IntPtr L, uint value);

		// Token: 0x06000C30 RID: 3120 RVA: 0x0005E9CC File Offset: 0x0005CBCC
		public static void lua_pushstring(IntPtr L, string str)
		{
			bool flag = str == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				bool flag2 = Encoding.UTF8.GetByteCount(str) > InternalGlobals.strBuff.Length;
				if (flag2)
				{
					byte[] bytes = Encoding.UTF8.GetBytes(str);
					Lua.xlua_pushlstring(L, bytes, bytes.Length);
				}
				else
				{
					int bytes_len = Encoding.UTF8.GetBytes(str, 0, str.Length, InternalGlobals.strBuff, 0);
					Lua.xlua_pushlstring(L, InternalGlobals.strBuff, bytes_len);
				}
			}
		}

		// Token: 0x06000C31 RID: 3121
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size);

		// Token: 0x06000C32 RID: 3122 RVA: 0x0005EA4C File Offset: 0x0005CC4C
		public static void xlua_pushasciistring(IntPtr L, string str)
		{
			bool flag = str == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				int str_len = str.Length;
				bool flag2 = InternalGlobals.strBuff.Length < str_len;
				if (flag2)
				{
					InternalGlobals.strBuff = new byte[str_len];
				}
				int bytes_len = Encoding.UTF8.GetBytes(str, 0, str_len, InternalGlobals.strBuff, 0);
				Lua.xlua_pushlstring(L, InternalGlobals.strBuff, bytes_len);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0005EAB4 File Offset: 0x0005CCB4
		public static void lua_pushstring(IntPtr L, byte[] str)
		{
			bool flag = str == null;
			if (flag)
			{
				Lua.lua_pushnil(L);
			}
			else
			{
				Lua.xlua_pushlstring(L, str, str.Length);
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0005EAE4 File Offset: 0x0005CCE4
		public static byte[] lua_tobytes(IntPtr L, int index)
		{
			bool flag = Lua.lua_type(L, index) == LuaTypes.LUA_TSTRING;
			if (flag)
			{
				IntPtr strlen;
				IntPtr str = Lua.lua_tolstring(L, index, out strlen);
				bool flag2 = str != IntPtr.Zero;
				if (flag2)
				{
					int buff_len = strlen.ToInt32();
					byte[] buffer = new byte[buff_len];
					Marshal.Copy(str, buffer, 0, buff_len);
					return buffer;
				}
			}
			return null;
		}

		// Token: 0x06000C35 RID: 3125
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int luaL_newmetatable(IntPtr L, string meta);

		// Token: 0x06000C36 RID: 3126
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_pgettable(IntPtr L, int idx);

		// Token: 0x06000C37 RID: 3127
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_psettable(IntPtr L, int idx);

		// Token: 0x06000C38 RID: 3128 RVA: 0x0005EB47 File Offset: 0x0005CD47
		public static void luaL_getmetatable(IntPtr L, string meta)
		{
			Lua.xlua_pushasciistring(L, meta);
			Lua.lua_rawget(L, LuaIndexes.LUA_REGISTRYINDEX);
		}

		// Token: 0x06000C39 RID: 3129
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name);

		// Token: 0x06000C3A RID: 3130 RVA: 0x0005EB60 File Offset: 0x0005CD60
		public static int luaL_loadbuffer(IntPtr L, string buff, string name)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(buff);
			return Lua.xluaL_loadbuffer(L, bytes, bytes.Length, name);
		}

		// Token: 0x06000C3B RID: 3131
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj);

		// Token: 0x06000C3C RID: 3132
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj);

		// Token: 0x06000C3D RID: 3133 RVA: 0x0005EB8C File Offset: 0x0005CD8C
		public static int lua_error(IntPtr L)
		{
			Lua.xlua_csharp_error(L);
			return 0;
		}

		// Token: 0x06000C3E RID: 3134
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool lua_checkstack(IntPtr L, int extra);

		// Token: 0x06000C3F RID: 3135
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int lua_next(IntPtr L, int index);

		// Token: 0x06000C40 RID: 3136
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata);

		// Token: 0x06000C41 RID: 3137
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr xlua_tag();

		// Token: 0x06000C42 RID: 3138
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void luaL_where(IntPtr L, int level);

		// Token: 0x06000C43 RID: 3139
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref);

		// Token: 0x06000C44 RID: 3140
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref);

		// Token: 0x06000C45 RID: 3141
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int gen_obj_indexer(IntPtr L);

		// Token: 0x06000C46 RID: 3142
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int gen_obj_newindexer(IntPtr L);

		// Token: 0x06000C47 RID: 3143
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int gen_cls_indexer(IntPtr L);

		// Token: 0x06000C48 RID: 3144
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int gen_cls_newindexer(IntPtr L);

		// Token: 0x06000C49 RID: 3145
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int get_error_func_ref(IntPtr L);

		// Token: 0x06000C4A RID: 3146
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int load_error_func(IntPtr L, int Ref);

		// Token: 0x06000C4B RID: 3147
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int luaopen_i64lib(IntPtr L);

		// Token: 0x06000C4C RID: 3148
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int luaopen_socket_core(IntPtr L);

		// Token: 0x06000C4D RID: 3149
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_pushint64(IntPtr L, long n);

		// Token: 0x06000C4E RID: 3150
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void lua_pushuint64(IntPtr L, ulong n);

		// Token: 0x06000C4F RID: 3151
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool lua_isint64(IntPtr L, int idx);

		// Token: 0x06000C50 RID: 3152
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool lua_isuint64(IntPtr L, int idx);

		// Token: 0x06000C51 RID: 3153
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern long lua_toint64(IntPtr L, int idx);

		// Token: 0x06000C52 RID: 3154
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong lua_touint64(IntPtr L, int idx);

		// Token: 0x06000C53 RID: 3155
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n);

		// Token: 0x06000C54 RID: 3156
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_csharp_str_error(IntPtr L, string message);

		// Token: 0x06000C55 RID: 3157
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_csharp_error(IntPtr L);

		// Token: 0x06000C56 RID: 3158
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field);

		// Token: 0x06000C57 RID: 3159
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field);

		// Token: 0x06000C58 RID: 3160
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field);

		// Token: 0x06000C59 RID: 3161
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field);

		// Token: 0x06000C5A RID: 3162
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field);

		// Token: 0x06000C5B RID: 3163
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field);

		// Token: 0x06000C5C RID: 3164
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field);

		// Token: 0x06000C5D RID: 3165
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field);

		// Token: 0x06000C5E RID: 3166
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field);

		// Token: 0x06000C5F RID: 3167
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field);

		// Token: 0x06000C60 RID: 3168
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field);

		// Token: 0x06000C61 RID: 3169
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field);

		// Token: 0x06000C62 RID: 3170
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref);

		// Token: 0x06000C63 RID: 3171
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref);

		// Token: 0x06000C64 RID: 3172
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr lua_touserdata(IntPtr L, int idx);

		// Token: 0x06000C65 RID: 3173
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_gettypeid(IntPtr L, int idx);

		// Token: 0x06000C66 RID: 3174
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_get_registry_index();

		// Token: 0x06000C67 RID: 3175
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path);

		// Token: 0x06000C68 RID: 3176
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path);

		// Token: 0x06000C69 RID: 3177
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2);

		// Token: 0x06000C6A RID: 3178
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2);

		// Token: 0x06000C6B RID: 3179
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3);

		// Token: 0x06000C6C RID: 3180
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3);

		// Token: 0x06000C6D RID: 3181
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4);

		// Token: 0x06000C6E RID: 3182
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4);

		// Token: 0x06000C6F RID: 3183
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5);

		// Token: 0x06000C70 RID: 3184
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5);

		// Token: 0x06000C71 RID: 3185
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6);

		// Token: 0x06000C72 RID: 3186
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6);

		// Token: 0x06000C73 RID: 3187
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec);

		// Token: 0x06000C74 RID: 3188
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64);

		// Token: 0x06000C75 RID: 3189 RVA: 0x0005EBA8 File Offset: 0x0005CDA8
		public static bool xlua_is_eq_str(IntPtr L, int index, string str)
		{
			return Lua.xlua_is_eq_str(L, index, str, str.Length);
		}

		// Token: 0x06000C76 RID: 3190
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len);

		// Token: 0x06000C77 RID: 3191
		[DllImport("xlua", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr xlua_gl(IntPtr L);

		// Token: 0x04000DEE RID: 3566
		private const string LUADLL = "xlua";
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using XLua.LuaDLL;
using XLua.TemplateEngine;

namespace XLua
{
	// Token: 0x0200015C RID: 348
	public class LuaEnv : IDisposable
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00055B34 File Offset: 0x00053D34
		internal IntPtr L
		{
			get
			{
				bool flag = this.rawL == IntPtr.Zero;
				if (flag)
				{
					throw new InvalidOperationException("this lua env had disposed!");
				}
				return this.rawL;
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00055B6C File Offset: 0x00053D6C
		public LuaEnv()
		{
			bool flag = Lua.xlua_get_lib_version() != 105;
			if (flag)
			{
				throw new InvalidProgramException("wrong lib version expect:" + 105.ToString() + " but got:" + Lua.xlua_get_lib_version().ToString());
			}
			LuaIndexes.LUA_REGISTRYINDEX = Lua.xlua_get_registry_index();
			this.rawL = Lua.luaL_newstate();
			Lua.luaopen_xlua(this.rawL);
			Lua.luaopen_i64lib(this.rawL);
			this.translator = new ObjectTranslator(this, this.rawL);
			this.translator.createFunctionMetatable(this.rawL);
			this.translator.OpenLib(this.rawL);
			ObjectTranslatorPool.Instance.Add(this.rawL, this.translator);
			Lua.lua_atpanic(this.rawL, new lua_CSFunction(StaticLuaCallbacks.Panic));
			Lua.lua_pushstdcallcfunction(this.rawL, new lua_CSFunction(StaticLuaCallbacks.Print), 0);
			bool flag2 = Lua.xlua_setglobal(this.rawL, "print") != 0;
			if (flag2)
			{
				throw new Exception("call xlua_setglobal fail!");
			}
			LuaTemplate.OpenLib(this.rawL);
			this.AddSearcher(new lua_CSFunction(StaticLuaCallbacks.LoadBuiltinLib), 2);
			this.AddSearcher(new lua_CSFunction(StaticLuaCallbacks.LoadFromCustomLoaders), 3);
			this.AddSearcher(new lua_CSFunction(StaticLuaCallbacks.LoadFromResource), 4);
			this.AddSearcher(new lua_CSFunction(StaticLuaCallbacks.LoadFromStreamingAssetsPath), -1);
			this.DoString(this.init_xlua, "Init", null);
			this.init_xlua = null;
			this.AddBuildin("socket.core", new lua_CSFunction(StaticLuaCallbacks.LoadSocketCore));
			this.AddBuildin("socket", new lua_CSFunction(StaticLuaCallbacks.LoadSocketCore));
			this.AddBuildin("CS", new lua_CSFunction(StaticLuaCallbacks.LoadCS));
			Lua.lua_newtable(this.rawL);
			Lua.xlua_pushasciistring(this.rawL, "__index");
			Lua.lua_pushstdcallcfunction(this.rawL, new lua_CSFunction(StaticLuaCallbacks.MetaFuncIndex), 0);
			Lua.lua_rawset(this.rawL, -3);
			Lua.xlua_pushasciistring(this.rawL, "LuaIndexs");
			Lua.lua_newtable(this.rawL);
			Lua.lua_pushvalue(this.rawL, -3);
			Lua.lua_setmetatable(this.rawL, -2);
			Lua.lua_rawset(this.rawL, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.xlua_pushasciistring(this.rawL, "LuaNewIndexs");
			Lua.lua_newtable(this.rawL);
			Lua.lua_pushvalue(this.rawL, -3);
			Lua.lua_setmetatable(this.rawL, -2);
			Lua.lua_rawset(this.rawL, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.xlua_pushasciistring(this.rawL, "LuaClassIndexs");
			Lua.lua_newtable(this.rawL);
			Lua.lua_pushvalue(this.rawL, -3);
			Lua.lua_setmetatable(this.rawL, -2);
			Lua.lua_rawset(this.rawL, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.xlua_pushasciistring(this.rawL, "LuaClassNewIndexs");
			Lua.lua_newtable(this.rawL);
			Lua.lua_pushvalue(this.rawL, -3);
			Lua.lua_setmetatable(this.rawL, -2);
			Lua.lua_rawset(this.rawL, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.lua_pop(this.rawL, 1);
			Lua.xlua_pushasciistring(this.rawL, "xlua_main_thread");
			Lua.lua_pushthread(this.rawL);
			Lua.lua_rawset(this.rawL, LuaIndexes.LUA_REGISTRYINDEX);
			Lua.xlua_pushasciistring(this.rawL, "xlua_csharp_namespace");
			bool flag3 = Lua.xlua_getglobal(this.rawL, "CS") != 0;
			if (flag3)
			{
				throw new Exception("get CS fail!");
			}
			Lua.lua_rawset(this.rawL, LuaIndexes.LUA_REGISTRYINDEX);
			this.translator.Alias(typeof(Type), "System.MonoType");
			bool flag4 = Lua.xlua_getglobal(this.rawL, "_G") != 0;
			if (flag4)
			{
				throw new Exception("get _G fail!");
			}
			this.translator.Get<LuaTable>(this.rawL, -1, out this._G);
			Lua.lua_pop(this.rawL, 1);
			this.errorFuncRef = Lua.get_error_func_ref(this.rawL);
			bool flag5 = LuaEnv.initers != null;
			if (flag5)
			{
				for (int i = 0; i < LuaEnv.initers.Count; i++)
				{
					LuaEnv.initers[i](this, this.translator);
				}
			}
			this.translator.CreateArrayMetatable(this.rawL);
			this.translator.CreateDelegateMetatable(this.rawL);
			this.translator.CreateEnumerablePairs(this.rawL);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0005608C File Offset: 0x0005428C
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer)
		{
			bool flag = LuaEnv.initers == null;
			if (flag)
			{
				LuaEnv.initers = new List<Action<LuaEnv, ObjectTranslator>>();
			}
			LuaEnv.initers.Add(initer);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x000560C0 File Offset: 0x000542C0
		public LuaTable Global
		{
			get
			{
				return this._G;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000560D8 File Offset: 0x000542D8
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk", LuaTable env = null)
		{
			bool flag = typeof(T) != typeof(LuaFunction) && !typeof(T).IsSubclassOf(typeof(Delegate));
			if (flag)
			{
				throw new InvalidOperationException(typeof(T).Name + " is not a delegate type nor LuaFunction");
			}
			IntPtr _L = this.L;
			int oldTop = Lua.lua_gettop(_L);
			bool flag2 = Lua.xluaL_loadbuffer(_L, chunk, chunk.Length, chunkName) != 0;
			if (flag2)
			{
				this.ThrowExceptionFromError(oldTop);
			}
			bool flag3 = env != null;
			if (flag3)
			{
				env.push(_L);
				Lua.lua_setfenv(_L, -2);
			}
			T result = (T)((object)this.translator.GetObject(_L, -1, typeof(T)));
			Lua.lua_settop(_L, oldTop);
			return result;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000561B8 File Offset: 0x000543B8
		public T LoadString<T>(string chunk, string chunkName = "chunk", LuaTable env = null)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(chunk);
			return this.LoadString<T>(bytes, chunkName, env);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000561E0 File Offset: 0x000543E0
		public LuaFunction LoadString(string chunk, string chunkName = "chunk", LuaTable env = null)
		{
			return this.LoadString<LuaFunction>(chunk, chunkName, env);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000561FC File Offset: 0x000543FC
		public object[] DoString(byte[] chunk, string chunkName = "chunk", LuaTable env = null)
		{
			IntPtr _L = this.L;
			int oldTop = Lua.lua_gettop(_L);
			int errFunc = Lua.load_error_func(_L, this.errorFuncRef);
			bool flag = Lua.xluaL_loadbuffer(_L, chunk, chunk.Length, chunkName) == 0;
			if (flag)
			{
				bool flag2 = env != null;
				if (flag2)
				{
					env.push(_L);
					Lua.lua_setfenv(_L, -2);
				}
				bool flag3 = Lua.lua_pcall(_L, 0, -1, errFunc) == 0;
				if (flag3)
				{
					Lua.lua_remove(_L, errFunc);
					return this.translator.popValues(_L, oldTop);
				}
				this.ThrowExceptionFromError(oldTop);
			}
			else
			{
				this.ThrowExceptionFromError(oldTop);
			}
			return null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0005629C File Offset: 0x0005449C
		public object[] DoString(string chunk, string chunkName = "chunk", LuaTable env = null)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(chunk);
			return this.DoString(bytes, chunkName, env);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000562C4 File Offset: 0x000544C4
		private void AddSearcher(lua_CSFunction searcher, int index)
		{
			IntPtr _L = this.L;
			Lua.xlua_getloaders(_L);
			bool flag = !Lua.lua_istable(_L, -1);
			if (flag)
			{
				throw new Exception("Can not set searcher!");
			}
			uint len = Lua.xlua_objlen(_L, -1);
			index = ((index < 0) ? ((int)((ulong)len + (ulong)((long)index) + 2UL)) : index);
			for (int e = (int)(len + 1U); e > index; e--)
			{
				Lua.xlua_rawgeti(_L, -1, (long)(e - 1));
				Lua.xlua_rawseti(_L, -2, (long)e);
			}
			Lua.lua_pushstdcallcfunction(_L, searcher, 0);
			Lua.xlua_rawseti(_L, -2, (long)index);
			Lua.lua_pop(_L, 1);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0005635D File Offset: 0x0005455D
		public void Alias(Type type, string alias)
		{
			this.translator.Alias(type, alias);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00056370 File Offset: 0x00054570
		private static bool ObjectValidCheck(object obj)
		{
			return !(obj is UnityEngine.Object) || obj as UnityEngine.Object != null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0005639C File Offset: 0x0005459C
		public void Tick()
		{
			IntPtr _L = this.L;
			Queue<LuaEnv.GCAction> obj = this.refQueue;
			lock (obj)
			{
				while (this.refQueue.Count > 0)
				{
					LuaEnv.GCAction gca = this.refQueue.Dequeue();
					this.translator.ReleaseLuaBase(_L, gca.Reference, gca.IsDelegate);
				}
			}
			this.last_check_point = this.translator.objects.Check(this.last_check_point, this.max_check_per_tick, this.object_valid_checker, this.translator.reverseMap);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00056454 File Offset: 0x00054654
		public void GC()
		{
			this.Tick();
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00056460 File Offset: 0x00054660
		public LuaTable NewTable()
		{
			IntPtr _L = this.L;
			int oldTop = Lua.lua_gettop(_L);
			Lua.lua_newtable(_L);
			LuaTable returnVal = (LuaTable)this.translator.GetObject(_L, -1, typeof(LuaTable));
			Lua.lua_settop(_L, oldTop);
			return returnVal;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000564AD File Offset: 0x000546AD
		public void Dispose()
		{
			this.FullGc();
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
			this.Dispose(true);
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000564D8 File Offset: 0x000546D8
		public virtual void Dispose(bool dispose)
		{
			bool flag = this.disposed;
			if (!flag)
			{
				this.Tick();
				bool flag2 = !this.translator.AllDelegateBridgeReleased();
				if (flag2)
				{
					throw new InvalidOperationException("try to dispose a LuaEnv with C# callback!");
				}
				ObjectTranslatorPool.Instance.Remove(this.L);
				Lua.lua_close(this.L);
				this.translator = null;
				this.rawL = IntPtr.Zero;
				this.disposed = true;
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00056550 File Offset: 0x00054750
		public void ThrowExceptionFromError(int oldTop)
		{
			object err = this.translator.GetObject(this.L, -1);
			Lua.lua_settop(this.L, oldTop);
			Exception ex = err as Exception;
			bool flag = ex != null;
			if (flag)
			{
				throw ex;
			}
			bool flag2 = err == null;
			if (flag2)
			{
				err = "Unknown Lua Error";
			}
			throw new LuaException(err.ToString());
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x000565A8 File Offset: 0x000547A8
		internal void equeueGCAction(LuaEnv.GCAction action)
		{
			Queue<LuaEnv.GCAction> obj = this.refQueue;
			lock (obj)
			{
				this.refQueue.Enqueue(action);
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000565F4 File Offset: 0x000547F4
		public void AddLoader(LuaEnv.CustomLoader loader)
		{
			this.customLoaders.Add(loader);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00056604 File Offset: 0x00054804
		public void AddBuildin(string name, lua_CSFunction initer)
		{
			bool flag = !Utils.IsStaticPInvokeCSFunction(initer);
			if (flag)
			{
				throw new Exception("initer must be static and has MonoPInvokeCallback Attribute!");
			}
			this.buildin_initer.Add(name, initer);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0005663C File Offset: 0x0005483C
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x0005666F File Offset: 0x0005486F
		public int GcPause
		{
			get
			{
				int val = Lua.lua_gc(this.L, LuaGCOptions.LUA_GCSETPAUSE, 200);
				Lua.lua_gc(this.L, LuaGCOptions.LUA_GCSETPAUSE, val);
				return val;
			}
			set
			{
				Lua.lua_gc(this.L, LuaGCOptions.LUA_GCSETPAUSE, value);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00056680 File Offset: 0x00054880
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x000566B3 File Offset: 0x000548B3
		public int GcStepmul
		{
			get
			{
				int val = Lua.lua_gc(this.L, LuaGCOptions.LUA_GCSETSTEPMUL, 200);
				Lua.lua_gc(this.L, LuaGCOptions.LUA_GCSETSTEPMUL, val);
				return val;
			}
			set
			{
				Lua.lua_gc(this.L, LuaGCOptions.LUA_GCSETSTEPMUL, value);
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000566C4 File Offset: 0x000548C4
		public void FullGc()
		{
			Lua.lua_gc(this.L, LuaGCOptions.LUA_GCCOLLECT, 0);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000566D5 File Offset: 0x000548D5
		public void StopGc()
		{
			Lua.lua_gc(this.L, LuaGCOptions.LUA_GCSTOP, 0);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x000566E6 File Offset: 0x000548E6
		public void RestartGc()
		{
			Lua.lua_gc(this.L, LuaGCOptions.LUA_GCRESTART, 0);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x000566F8 File Offset: 0x000548F8
		public bool GcStep(int data)
		{
			return Lua.lua_gc(this.L, LuaGCOptions.LUA_GCSTEP, data) != 0;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0005671C File Offset: 0x0005491C
		public int Memroy
		{
			get
			{
				return Lua.lua_gc(this.L, LuaGCOptions.LUA_GCCOUNT, 0);
			}
		}

		// Token: 0x04000D21 RID: 3361
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace";

		// Token: 0x04000D22 RID: 3362
		public const string MAIN_SHREAD = "xlua_main_thread";

		// Token: 0x04000D23 RID: 3363
		internal IntPtr rawL;

		// Token: 0x04000D24 RID: 3364
		private LuaTable _G;

		// Token: 0x04000D25 RID: 3365
		internal ObjectTranslator translator;

		// Token: 0x04000D26 RID: 3366
		internal int errorFuncRef = -1;

		// Token: 0x04000D27 RID: 3367
		private const int LIB_VERSION_EXPECT = 105;

		// Token: 0x04000D28 RID: 3368
		private static List<Action<LuaEnv, ObjectTranslator>> initers;

		// Token: 0x04000D29 RID: 3369
		private int last_check_point = 0;

		// Token: 0x04000D2A RID: 3370
		private int max_check_per_tick = 20;

		// Token: 0x04000D2B RID: 3371
		private Func<object, bool> object_valid_checker = new Func<object, bool>(LuaEnv.ObjectValidCheck);

		// Token: 0x04000D2C RID: 3372
		private bool disposed = false;

		// Token: 0x04000D2D RID: 3373
		private Queue<LuaEnv.GCAction> refQueue = new Queue<LuaEnv.GCAction>();

		// Token: 0x04000D2E RID: 3374
		private string init_xlua = " \r\n            local metatable = {}\r\n            local rawget = rawget\r\n            local setmetatable = setmetatable\r\n            local import_type = xlua.import_type\r\n            local import_generic_type = xlua.import_generic_type\r\n            local load_assembly = xlua.load_assembly\r\n\r\n            function metatable:__index(key) \r\n                local fqn = rawget(self,'.fqn')\r\n                fqn = ((fqn and fqn .. '.') or '') .. key\r\n\r\n                local obj = import_type(fqn)\r\n\r\n                if obj == nil then\r\n                    -- It might be an assembly, so we load it too.\r\n                    obj = { ['.fqn'] = fqn }\r\n                    setmetatable(obj, metatable)\r\n                elseif obj == true then\r\n                    return rawget(self, key)\r\n                end\r\n\r\n                -- Cache this lookup\r\n                rawset(self, key, obj)\r\n                return obj\r\n            end\r\n\r\n            function metatable:__newindex()\r\n                error('No such type: ' .. rawget(self,'.fqn'), 2)\r\n            end\r\n\r\n            -- A non-type has been called; e.g. foo = System.Foo()\r\n            function metatable:__call(...)\r\n                local n = select('#', ...)\r\n                local fqn = rawget(self,'.fqn')\r\n                if n > 0 then\r\n                    local gt = import_generic_type(fqn, ...)\r\n                    if gt then\r\n                        return rawget(CS, gt)\r\n                    end\r\n                end\r\n                error('No such type: ' .. fqn, 2)\r\n            end\r\n\r\n            CS = CS or {}\r\n            setmetatable(CS, metatable)\r\n\r\n            typeof = function(t) return t.UnderlyingSystemType end\r\n            cast = xlua.cast\r\n            if not setfenv or not getfenv then\r\n                local function getfunction(level)\r\n                    local info = debug.getinfo(level + 1, 'f')\r\n                    return info and info.func\r\n                end\r\n\r\n                function setfenv(fn, env)\r\n                  if type(fn) == 'number' then fn = getfunction(fn + 1) end\r\n                  local i = 1\r\n                  while true do\r\n                    local name = debug.getupvalue(fn, i)\r\n                    if name == '_ENV' then\r\n                      debug.upvaluejoin(fn, i, (function()\r\n                        return env\r\n                      end), 1)\r\n                      break\r\n                    elseif not name then\r\n                      break\r\n                    end\r\n\r\n                    i = i + 1\r\n                  end\r\n\r\n                  return fn\r\n                end\r\n\r\n                function getfenv(fn)\r\n                  if type(fn) == 'number' then fn = getfunction(fn + 1) end\r\n                  local i = 1\r\n                  while true do\r\n                    local name, val = debug.getupvalue(fn, i)\r\n                    if name == '_ENV' then\r\n                      return val\r\n                    elseif not name then\r\n                      break\r\n                    end\r\n                    i = i + 1\r\n                  end\r\n                end\r\n            end\r\n\r\n            xlua.hotfix = function(cs, field, func)\r\n                if func == nil then func = false end\r\n                local tbl = (type(field) == 'table') and field or {[field] = func}\r\n                for k, v in pairs(tbl) do\r\n                    local cflag = ''\r\n                    if k == '.ctor' then\r\n                        cflag = '_c'\r\n                        k = 'ctor'\r\n                    end\r\n                    local f = type(v) == 'function' and v or nil\r\n                    xlua.access(cs, cflag .. '__Hotfix0_'..k, f) -- at least one\r\n                    pcall(function()\r\n                        for i = 1, 99 do\r\n                            xlua.access(cs, cflag .. '__Hotfix'..i..'_'..k, f)\r\n                        end\r\n                    end)\r\n                end\r\n                xlua.private_accessible(cs)\r\n            end\r\n            xlua.getmetatable = function(cs)\r\n                return xlua.metatable_operation(cs)\r\n            end\r\n            xlua.setmetatable = function(cs, mt)\r\n                return xlua.metatable_operation(cs, mt)\r\n            end\r\n            xlua.setclass = function(parent, name, impl)\r\n                impl.UnderlyingSystemType = parent[name].UnderlyingSystemType\r\n                rawset(parent, name, impl)\r\n            end\r\n            \r\n            local base_mt = {\r\n                __index = function(t, k)\r\n                    local csobj = t['__csobj']\r\n                    local func = csobj['<>xLuaBaseProxy_'..k]\r\n                    return function(_, ...)\r\n                         return func(csobj, ...)\r\n                    end\r\n                end\r\n            }\r\n            base = function(csobj)\r\n                return setmetatable({__csobj = csobj}, base_mt)\r\n            end\r\n            ";

		// Token: 0x04000D2F RID: 3375
		internal List<LuaEnv.CustomLoader> customLoaders = new List<LuaEnv.CustomLoader>();

		// Token: 0x04000D30 RID: 3376
		internal Dictionary<string, lua_CSFunction> buildin_initer = new Dictionary<string, lua_CSFunction>();

		// Token: 0x0200015D RID: 349
		internal struct GCAction
		{
			// Token: 0x04000D31 RID: 3377
			public int Reference;

			// Token: 0x04000D32 RID: 3378
			public bool IsDelegate;
		}

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x06000ABE RID: 2750
		public delegate byte[] CustomLoader(ref string filepath);
	}
}

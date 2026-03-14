using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Cysharp.Text;
using XLua.LuaDLL;

namespace XLua.TemplateEngine
{
	// Token: 0x02000194 RID: 404
	public class LuaTemplate
	{
		// Token: 0x06000BD7 RID: 3031 RVA: 0x0005E484 File Offset: 0x0005C684
		public static string ComposeCode(List<Chunk> chunks)
		{
			StringBuilder code = new StringBuilder();
			code.Append("local __text_gen = {}\r\n");
			foreach (Chunk chunk in chunks)
			{
				switch (chunk.Type)
				{
				case TokenType.Code:
					code.Append(chunk.Text + "\r\n");
					break;
				case TokenType.Eval:
					code.Append("table.insert(__text_gen, tostring(" + chunk.Text + "))\r\n");
					break;
				case TokenType.Text:
					code.Append("table.insert(__text_gen, \"" + chunk.Text + "\")\r\n");
					break;
				}
			}
			code.Append("return table.concat(__text_gen)\r\n");
			return code.ToString();
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0005E574 File Offset: 0x0005C774
		public static LuaFunction Compile(LuaEnv luaenv, string snippet)
		{
			return luaenv.LoadString(LuaTemplate.ComposeCode(Parser.Parse(snippet)), "luatemplate", null);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0005E5A0 File Offset: 0x0005C7A0
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters)
		{
			compiledTemplate.SetEnv(parameters);
			object[] result = compiledTemplate.Call(Array.Empty<object>());
			Debug.Assert(result.Length == 1);
			return result[0].ToString();
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0005E5DC File Offset: 0x0005C7DC
		public static string Execute(LuaFunction compiledTemplate)
		{
			object[] result = compiledTemplate.Call(Array.Empty<object>());
			Debug.Assert(result.Length == 1);
			return result[0].ToString();
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0005E610 File Offset: 0x0005C810
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Compile(IntPtr L)
		{
			string snippet = Lua.lua_tostring(L, 1);
			string code;
			try
			{
				code = LuaTemplate.ComposeCode(Parser.Parse(snippet));
			}
			catch (Exception e)
			{
				return Lua.luaL_error(L, ZString.Format<object>("template compile error:{0}\r\n", e.Message));
			}
			bool flag = Lua.luaL_loadbuffer(L, code, "luatemplate") != 0;
			int result;
			if (flag)
			{
				result = Lua.lua_error(L);
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0005E688 File Offset: 0x0005C888
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Execute(IntPtr L)
		{
			bool flag = !Lua.lua_isfunction(L, 1);
			int result;
			if (flag)
			{
				result = Lua.luaL_error(L, "invalid compiled template, function needed!\r\n");
			}
			else
			{
				bool flag2 = Lua.lua_istable(L, 2);
				if (flag2)
				{
					Lua.lua_setfenv(L, 1);
				}
				Lua.lua_pcall(L, 0, 1, 0);
				result = 1;
			}
			return result;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0005E6D8 File Offset: 0x0005C8D8
		public static void OpenLib(IntPtr L)
		{
			Lua.lua_newtable(L);
			Lua.xlua_pushasciistring(L, "compile");
			Lua.lua_pushstdcallcfunction(L, LuaTemplate.templateCompileFunction, 0);
			Lua.lua_rawset(L, -3);
			Lua.xlua_pushasciistring(L, "execute");
			Lua.lua_pushstdcallcfunction(L, LuaTemplate.templateExecuteFunction, 0);
			Lua.lua_rawset(L, -3);
			bool flag = Lua.xlua_setglobal(L, "template") != 0;
			if (flag)
			{
				throw new Exception("call xlua_setglobal fail!");
			}
		}

		// Token: 0x04000DEB RID: 3563
		private static lua_CSFunction templateCompileFunction = new lua_CSFunction(LuaTemplate.Compile);

		// Token: 0x04000DEC RID: 3564
		private static lua_CSFunction templateExecuteFunction = new lua_CSFunction(LuaTemplate.Execute);
	}
}

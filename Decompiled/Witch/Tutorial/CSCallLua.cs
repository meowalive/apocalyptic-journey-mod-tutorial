using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Tutorial
{
	// Token: 0x0200011D RID: 285
	public class CSCallLua : MonoBehaviour
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x0004708C File Offset: 0x0004528C
		private void Start()
		{
			this.luaenv = new LuaEnv();
			this.luaenv.DoString(this.script, "chunk", null);
			Debug.Log("_G.a = " + this.luaenv.Global.Get<int>("a").ToString());
			Debug.Log("_G.b = " + this.luaenv.Global.Get<string>("b"));
			Debug.Log("_G.c = " + this.luaenv.Global.Get<bool>("c").ToString());
			CSCallLua.DClass d = this.luaenv.Global.Get<CSCallLua.DClass>("d");
			Debug.Log(string.Concat(new string[]
			{
				"_G.d = {f1=",
				d.f1.ToString(),
				", f2=",
				d.f2.ToString(),
				"}"
			}));
			Dictionary<string, double> d2 = this.luaenv.Global.Get<Dictionary<string, double>>("d");
			Debug.Log(string.Concat(new string[]
			{
				"_G.d = {f1=",
				d2["f1"].ToString(),
				", f2=",
				d2["f2"].ToString(),
				"}, d.Count=",
				d2.Count.ToString()
			}));
			List<double> d3 = this.luaenv.Global.Get<List<double>>("d");
			Debug.Log("_G.d.len = " + d3.Count.ToString());
			CSCallLua.ItfD d4 = this.luaenv.Global.Get<CSCallLua.ItfD>("d");
			d4.f2 = 1000;
			Debug.Log(string.Concat(new string[]
			{
				"_G.d = {f1=",
				d4.f1.ToString(),
				", f2=",
				d4.f2.ToString(),
				"}"
			}));
			Debug.Log("_G.d:add(1, 2)=" + d4.add(1, 2).ToString());
			LuaTable d5 = this.luaenv.Global.Get<LuaTable>("d");
			Debug.Log(string.Concat(new string[]
			{
				"_G.d = {f1=",
				d5.Get<int>("f1").ToString(),
				", f2=",
				d5.Get<int>("f2").ToString(),
				"}"
			}));
			Action e = this.luaenv.Global.Get<Action>("e");
			e();
			CSCallLua.FDelegate f = this.luaenv.Global.Get<CSCallLua.FDelegate>("f");
			CSCallLua.DClass d_ret;
			int f_ret = f(100, "John", out d_ret);
			Debug.Log(string.Concat(new string[]
			{
				"ret.d = {f1=",
				d_ret.f1.ToString(),
				", f2=",
				d_ret.f2.ToString(),
				"}, ret=",
				f_ret.ToString()
			}));
			CSCallLua.GetE ret_e = this.luaenv.Global.Get<CSCallLua.GetE>("ret_e");
			e = ret_e();
			e();
			LuaFunction d_e = this.luaenv.Global.Get<LuaFunction>("e");
			d_e.Call(Array.Empty<object>());
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00047434 File Offset: 0x00045634
		private void Update()
		{
			bool flag = this.luaenv != null;
			if (flag)
			{
				this.luaenv.Tick();
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0004745D File Offset: 0x0004565D
		private void OnDestroy()
		{
			this.luaenv.Dispose();
		}

		// Token: 0x04000C23 RID: 3107
		private LuaEnv luaenv = null;

		// Token: 0x04000C24 RID: 3108
		private string script = "\r\n        a = 1\r\n        b = 'hello world'\r\n        c = true\r\n\r\n        d = {\r\n           f1 = 12, f2 = 34, \r\n           1, 2, 3,\r\n           add = function(self, a, b) \r\n              print('d.add called')\r\n              return a + b \r\n           end\r\n        }\r\n\r\n        function e()\r\n            print('i am e')\r\n        end\r\n\r\n        function f(a, b)\r\n            print('a', a, 'b', b)\r\n            return 1, {f1 = 1024}\r\n        end\r\n        \r\n        function ret_e()\r\n            print('ret_e called')\r\n            return e\r\n        end\r\n    ";

		// Token: 0x0200011E RID: 286
		public class DClass
		{
			// Token: 0x04000C25 RID: 3109
			public int f1;

			// Token: 0x04000C26 RID: 3110
			public int f2;
		}

		// Token: 0x0200011F RID: 287
		[CSharpCallLua]
		public interface ItfD
		{
			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060008EB RID: 2283
			// (set) Token: 0x060008EC RID: 2284
			int f1 { get; set; }

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060008ED RID: 2285
			// (set) Token: 0x060008EE RID: 2286
			int f2 { get; set; }

			// Token: 0x060008EF RID: 2287
			int add(int a, int b);
		}

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x060008F1 RID: 2289
		[CSharpCallLua]
		public delegate int FDelegate(int a, string b, out CSCallLua.DClass c);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x060008F5 RID: 2293
		[CSharpCallLua]
		public delegate Action GetE();
	}
}

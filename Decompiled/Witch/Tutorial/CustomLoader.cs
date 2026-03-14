using System;
using System.Text;
using UnityEngine;
using XLua;

namespace Tutorial
{
	// Token: 0x02000124 RID: 292
	public class CustomLoader : MonoBehaviour
	{
		// Token: 0x06000900 RID: 2304 RVA: 0x00047564 File Offset: 0x00045764
		private void Start()
		{
			this.luaenv = new LuaEnv();
			this.luaenv.AddLoader(delegate(ref string filename)
			{
				bool flag = filename == "InMemory";
				byte[] result;
				if (flag)
				{
					string script = "return {ccc = 9999}";
					result = Encoding.UTF8.GetBytes(script);
				}
				else
				{
					result = null;
				}
				return result;
			});
			this.luaenv.DoString("print('InMemory.ccc=', require('InMemory').ccc)", "chunk", null);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000475C0 File Offset: 0x000457C0
		private void Update()
		{
			bool flag = this.luaenv != null;
			if (flag)
			{
				this.luaenv.Tick();
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000475E9 File Offset: 0x000457E9
		private void OnDestroy()
		{
			this.luaenv.Dispose();
		}

		// Token: 0x04000C29 RID: 3113
		private LuaEnv luaenv = null;
	}
}

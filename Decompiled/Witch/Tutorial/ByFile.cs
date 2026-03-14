using System;
using UnityEngine;
using XLua;

namespace Tutorial
{
	// Token: 0x02000122 RID: 290
	public class ByFile : MonoBehaviour
	{
		// Token: 0x060008F8 RID: 2296 RVA: 0x00047487 File Offset: 0x00045687
		private void Start()
		{
			this.luaenv = new LuaEnv();
			this.luaenv.DoString("require 'byfile'", "chunk", null);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000474AC File Offset: 0x000456AC
		private void Update()
		{
			bool flag = this.luaenv != null;
			if (flag)
			{
				this.luaenv.Tick();
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000474D5 File Offset: 0x000456D5
		private void OnDestroy()
		{
			this.luaenv.Dispose();
		}

		// Token: 0x04000C27 RID: 3111
		private LuaEnv luaenv = null;
	}
}

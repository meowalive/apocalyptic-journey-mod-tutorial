using System;
using UnityEngine;
using XLua;

namespace Tutorial
{
	// Token: 0x02000123 RID: 291
	public class ByString : MonoBehaviour
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x000474F4 File Offset: 0x000456F4
		private void Start()
		{
			this.luaenv = new LuaEnv();
			this.luaenv.DoString("print('hello world')", "chunk", null);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0004751C File Offset: 0x0004571C
		private void Update()
		{
			bool flag = this.luaenv != null;
			if (flag)
			{
				this.luaenv.Tick();
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00047545 File Offset: 0x00045745
		private void OnDestroy()
		{
			this.luaenv.Dispose();
		}

		// Token: 0x04000C28 RID: 3112
		private LuaEnv luaenv = null;
	}
}

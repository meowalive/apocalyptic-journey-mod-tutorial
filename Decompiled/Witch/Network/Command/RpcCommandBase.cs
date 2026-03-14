using System;
using Newtonsoft.Json;

namespace Network.Command
{
	// Token: 0x020001D3 RID: 467
	public abstract class RpcCommandBase
	{
		// Token: 0x06001053 RID: 4179 RVA: 0x000026D9 File Offset: 0x000008D9
		public virtual void CmdExecute()
		{
		}

		// Token: 0x06001054 RID: 4180
		public abstract void RpcExecute();

		// Token: 0x06001055 RID: 4181 RVA: 0x00002540 File Offset: 0x00000740
		[JsonConstructor]
		public RpcCommandBase()
		{
		}
	}
}

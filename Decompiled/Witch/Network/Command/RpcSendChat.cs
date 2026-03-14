using System;
using Witch.UI.Window;

namespace Network.Command
{
	// Token: 0x020001D8 RID: 472
	public class RpcSendChat : RpcCommandBase
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x000861D6 File Offset: 0x000843D6
		public RpcSendChat(string name, string message)
		{
			this.name = name;
			this.message = message;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x000861F0 File Offset: 0x000843F0
		public override void RpcExecute()
		{
			string hhmmss = DateTime.Now.ToString("HH:mm:ss");
			string msg = string.Concat(new string[]
			{
				hhmmss,
				" [玩家",
				this.name,
				"] : ",
				this.message
			});
			ChatUI.Instance.AddMessage(msg);
		}

		// Token: 0x04000E43 RID: 3651
		public string name;

		// Token: 0x04000E44 RID: 3652
		public string message;
	}
}

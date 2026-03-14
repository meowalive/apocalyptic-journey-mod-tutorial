using System;

namespace Network.Command
{
	// Token: 0x020001D9 RID: 473
	public sealed class RpcSendEmoji : RpcCommandBase
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x0008624F File Offset: 0x0008444F
		public RpcSendEmoji(string instanceid, GifAsset emoji)
		{
			this.instanceid = instanceid;
			this.emoji = emoji;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00086267 File Offset: 0x00084467
		public override void RpcExecute()
		{
			Singleton<DialogueManager>.Instance.ShowEmoji(this.instanceid, this.emoji);
		}

		// Token: 0x04000E45 RID: 3653
		public string instanceid;

		// Token: 0x04000E46 RID: 3654
		public GifAsset emoji;
	}
}

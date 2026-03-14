using System;
using Mirror;

namespace Witch
{
	// Token: 0x0200024E RID: 590
	public class ModeManager : NetworkBehaviour
	{
		// Token: 0x06001315 RID: 4885 RVA: 0x00022CFE File Offset: 0x00020EFE
		public override bool Weaved()
		{
			return true;
		}

		// Token: 0x04000F7B RID: 3963
		public IModeManager ModeMapManager;
	}
}

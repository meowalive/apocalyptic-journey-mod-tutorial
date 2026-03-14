using System;
using System.Collections.Generic;

namespace Witch.UI.Window
{
	// Token: 0x02000345 RID: 837
	internal sealed class SteamWorkshopQueryPage
	{
		// Token: 0x0400140F RID: 5135
		public List<SteamWorkshopModInfo> Items = new List<SteamWorkshopModInfo>();

		// Token: 0x04001410 RID: 5136
		public uint TotalMatchingResults;

		// Token: 0x04001411 RID: 5137
		public string ErrorMessage;
	}
}

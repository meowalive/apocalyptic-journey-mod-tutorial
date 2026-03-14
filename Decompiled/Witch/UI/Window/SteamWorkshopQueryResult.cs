using System;
using System.Collections.Generic;

namespace Witch.UI.Window
{
	// Token: 0x02000344 RID: 836
	[Serializable]
	public sealed class SteamWorkshopQueryResult
	{
		// Token: 0x0400140C RID: 5132
		public List<SteamWorkshopModInfo> Items = new List<SteamWorkshopModInfo>();

		// Token: 0x0400140D RID: 5133
		public uint TotalMatchingResults;

		// Token: 0x0400140E RID: 5134
		public string ErrorMessage;
	}
}

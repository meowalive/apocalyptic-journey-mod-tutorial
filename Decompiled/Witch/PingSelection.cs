using System;
using Newtonsoft.Json;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

// Token: 0x020000D3 RID: 211
[Table("ping_selection")]
internal class PingSelection : BaseModel
{
	// Token: 0x170000CB RID: 203
	// (get) Token: 0x0600070F RID: 1807 RVA: 0x0003AFB4 File Offset: 0x000391B4
	// (set) Token: 0x06000710 RID: 1808 RVA: 0x0003AFBC File Offset: 0x000391BC
	[Column("max_ping", NullValueHandling.Include, false, false)]
	public double max_ping { get; set; }

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000711 RID: 1809 RVA: 0x0003AFC5 File Offset: 0x000391C5
	// (set) Token: 0x06000712 RID: 1810 RVA: 0x0003AFCD File Offset: 0x000391CD
	[Column("average_ping", NullValueHandling.Include, false, false)]
	public double average_ping { get; set; }

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000713 RID: 1811 RVA: 0x0003AFD6 File Offset: 0x000391D6
	// (set) Token: 0x06000714 RID: 1812 RVA: 0x0003AFDE File Offset: 0x000391DE
	[Column("min_ping", NullValueHandling.Include, false, false)]
	public double min_ping { get; set; }
}

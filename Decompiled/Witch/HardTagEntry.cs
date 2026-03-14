using System;
using System.Collections.Generic;

// Token: 0x02000058 RID: 88
public class HardTagEntry
{
	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000240 RID: 576 RVA: 0x00014CF5 File Offset: 0x00012EF5
	public Dictionary<string, string> Data { get; }

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000241 RID: 577 RVA: 0x00014CFD File Offset: 0x00012EFD
	// (set) Token: 0x06000242 RID: 578 RVA: 0x00014D05 File Offset: 0x00012F05
	public int DynamicValue { get; set; }

	// Token: 0x06000243 RID: 579 RVA: 0x00014D0E File Offset: 0x00012F0E
	public HardTagEntry(Dictionary<string, string> data, int dynamicValue)
	{
		this.Data = data;
		this.DynamicValue = dynamicValue;
	}
}

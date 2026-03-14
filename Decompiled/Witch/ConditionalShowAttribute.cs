using System;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class ConditionalShowAttribute : PropertyAttribute
{
	// Token: 0x06000012 RID: 18 RVA: 0x00002338 File Offset: 0x00000538
	public ConditionalShowAttribute(string conditionalSourceField, object compareValue = null)
	{
		this.conditionalSourceField = conditionalSourceField;
		this.compareValue = compareValue;
	}

	// Token: 0x04000008 RID: 8
	public string conditionalSourceField;

	// Token: 0x04000009 RID: 9
	public object compareValue;
}

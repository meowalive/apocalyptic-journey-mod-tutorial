using System;
using UnityEngine;

// Token: 0x020000E4 RID: 228
[ExecuteInEditMode]
public class RorationFix : MonoBehaviour
{
	// Token: 0x060007CE RID: 1998 RVA: 0x0003E770 File Offset: 0x0003C970
	private void Update()
	{
		bool flag = !base.gameObject.activeSelf || this.source == null;
		if (!flag)
		{
			base.transform.eulerAngles = this.source.eulerAngles;
		}
	}

	// Token: 0x04000B44 RID: 2884
	[SerializeField]
	private Transform source;
}

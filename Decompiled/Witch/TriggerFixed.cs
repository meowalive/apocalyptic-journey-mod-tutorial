using System;
using UnityEngine;

// Token: 0x02000020 RID: 32
public class TriggerFixed : MonoBehaviour
{
	// Token: 0x060000D8 RID: 216 RVA: 0x000080C8 File Offset: 0x000062C8
	private void Update()
	{
		Vector3 angle = base.transform.parent.localEulerAngles;
		base.transform.localEulerAngles = new Vector3(-angle.x, -angle.y, -angle.z);
	}
}

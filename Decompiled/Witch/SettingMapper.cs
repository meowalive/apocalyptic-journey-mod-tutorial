using System;
using UnityEngine;

// Token: 0x02000107 RID: 263
public class SettingMapper : MonoBehaviour
{
	// Token: 0x06000888 RID: 2184 RVA: 0x00043B1B File Offset: 0x00041D1B
	private void Awake()
	{
		Singleton<TempDataManager>.Instance.SettingTransformMap[base.name] = base.transform;
	}
}

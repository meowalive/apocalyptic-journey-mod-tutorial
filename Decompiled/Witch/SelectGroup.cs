using System;
using UnityEngine;

/// <summary>
/// 同一父对象下只允许一个物体为选中状态
/// </summary>
// Token: 0x020000EB RID: 235
public class SelectGroup : SwitchButton
{
	// Token: 0x060007F2 RID: 2034 RVA: 0x0003F5D4 File Offset: 0x0003D7D4
	private void Start()
	{
		this.onValueChanged.AddListener(delegate(bool value)
		{
			if (value)
			{
				foreach (object obj in base.transform.parent)
				{
					Transform child = (Transform)obj;
					bool flag = child != base.transform && child.gameObject.activeSelf;
					if (flag)
					{
						SelectGroup switchButton = child.GetComponent<SelectGroup>();
						bool flag2 = switchButton != null;
						if (flag2)
						{
							switchButton.isOn = false;
						}
					}
				}
			}
		});
	}
}

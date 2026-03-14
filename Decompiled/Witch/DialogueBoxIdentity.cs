using System;
using UnityEngine;

// Token: 0x0200010A RID: 266
public class DialogueBoxIdentity : MonoBehaviour
{
	// Token: 0x06000899 RID: 2201 RVA: 0x00044278 File Offset: 0x00042478
	public void Start()
	{
		bool flag = string.IsNullOrEmpty(this.Name) || this.isSet;
		if (!flag)
		{
			bool flag2 = !string.IsNullOrEmpty(this.Name);
			if (flag2)
			{
				Singleton<DialogueManager>.Instance.Identity.TryAdd(this.Name, base.gameObject);
			}
		}
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x000442D4 File Offset: 0x000424D4
	public void OnDestroy()
	{
		bool flag = string.IsNullOrEmpty(this.Name);
		if (!flag)
		{
			Singleton<DialogueManager>.Instance.Identity.Remove(this.Name);
		}
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x0004430C File Offset: 0x0004250C
	public void SetInstanceId(string id)
	{
		bool flag = !string.IsNullOrEmpty(this.Name) && Singleton<DialogueManager>.Instance.Identity.ContainsKey(this.Name);
		if (flag)
		{
			Singleton<DialogueManager>.Instance.Identity.Remove(this.Name);
		}
		bool flag2 = !string.IsNullOrEmpty(id);
		if (flag2)
		{
			this.Name = id;
			Singleton<DialogueManager>.Instance.Identity[this.Name] = base.gameObject;
			this.isSet = true;
		}
	}

	// Token: 0x04000BDC RID: 3036
	public string Name;

	// Token: 0x04000BDD RID: 3037
	private bool isSet;
}

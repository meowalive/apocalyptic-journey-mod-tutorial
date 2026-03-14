using System;
using UnityEngine;

// Token: 0x02000078 RID: 120
public class Bullet : MonoBehaviour
{
	// Token: 0x060003B9 RID: 953 RVA: 0x0001F2A0 File Offset: 0x0001D4A0
	private void Awake()
	{
		base.gameObject.AddComponent<Rigidbody>();
		base.gameObject.GetComponent<Rigidbody>().useGravity = false;
		base.gameObject.GetComponent<Rigidbody>().isKinematic = true;
		base.gameObject.AddComponent<BoxCollider>();
		base.transform.localScale = Vector3.one * 0.2f;
	}

	// Token: 0x060003BA RID: 954 RVA: 0x0001F308 File Offset: 0x0001D508
	private void Start()
	{
		GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.cast, base.transform.parent);
		obj.transform.position = base.transform.position;
		obj.transform.localScale = Vector3.one * 0.2f;
		UnityEngine.Object.Destroy(obj, 1f);
	}

	// Token: 0x060003BB RID: 955 RVA: 0x0001F36C File Offset: 0x0001D56C
	private void OnTriggerEnter(Collider other)
	{
		GameObject obj = UnityEngine.Object.Instantiate<GameObject>(this.hit, base.transform.parent);
		obj.transform.position = other.transform.position;
		obj.transform.localScale = Vector3.one * 0.2f;
		UnityEngine.Object.Destroy(obj, 1f);
	}

	// Token: 0x04000981 RID: 2433
	public GameObject cast;

	// Token: 0x04000982 RID: 2434
	public GameObject hit;
}

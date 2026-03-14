using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000021 RID: 33
public class EffectSound : MonoBehaviour
{
	// Token: 0x060000DA RID: 218 RVA: 0x00008118 File Offset: 0x00006318
	[DebuggerStepThrough]
	private void Start()
	{
		EffectSound.<Start>d__2 <Start>d__ = new EffectSound.<Start>d__2();
		<Start>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		<Start>d__.<>4__this = this;
		<Start>d__.<>1__state = -1;
		<Start>d__.<>t__builder.Start<EffectSound.<Start>d__2>(ref <Start>d__);
	}

	// Token: 0x04000072 RID: 114
	public float delay;

	// Token: 0x04000073 RID: 115
	public AudioClip clip;
}

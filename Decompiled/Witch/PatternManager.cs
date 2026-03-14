using System;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

// Token: 0x020000A7 RID: 167
public class PatternManager
{
	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0002A2F8 File Offset: 0x000284F8
	public static PatternManager Instance
	{
		get
		{
			return FightManager.Instance.patternManager;
		}
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x000026D9 File Offset: 0x000008D9
	public void InitPattern()
	{
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x0002A304 File Offset: 0x00028504
	[Server]
	public void ResPat()
	{
		if (!NetworkServer.active)
		{
			Debug.LogWarning("[Server] function 'System.Void PatternManager::ResPat()' called when server was not active");
			return;
		}
		GameServer.Instance.PatDone = true;
		GameServer.Instance.RoleRes();
	}

	// Token: 0x040009FE RID: 2558
	public List<Partner> PatternList = new List<Partner>();
}

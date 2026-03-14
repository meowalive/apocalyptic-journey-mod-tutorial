using System;

namespace XLua
{
	// Token: 0x0200014D RID: 333
	public static class HotfixDelegateBridge
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x00055668 File Offset: 0x00053868
		public static bool xlua_get_hotfix_flag(int idx)
		{
			return idx < DelegateBridge.DelegateBridgeList.Length && DelegateBridge.DelegateBridgeList[idx] != null;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00055694 File Offset: 0x00053894
		public static DelegateBridge Get(int idx)
		{
			return DelegateBridge.DelegateBridgeList[idx];
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000556B0 File Offset: 0x000538B0
		public static void Set(int idx, DelegateBridge val)
		{
			bool flag = idx >= DelegateBridge.DelegateBridgeList.Length;
			if (flag)
			{
				DelegateBridge[] newList = new DelegateBridge[idx + 1];
				for (int i = 0; i < DelegateBridge.DelegateBridgeList.Length; i++)
				{
					newList[i] = DelegateBridge.DelegateBridgeList[i];
				}
				DelegateBridge.DelegateBridgeList = newList;
			}
			DelegateBridge.DelegateBridgeList[idx] = val;
		}
	}
}

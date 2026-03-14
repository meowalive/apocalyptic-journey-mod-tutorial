using System;

namespace Network.Query
{
	// Token: 0x020001CC RID: 460
	public abstract class QueryBase<T> : QueryBase
	{
		// Token: 0x06001042 RID: 4162 RVA: 0x00085A14 File Offset: 0x00083C14
		public override void OnResponse(QueryBase response)
		{
			QueryBase<T> typedResponse = response as QueryBase<T>;
			bool flag = typedResponse != null;
			if (flag)
			{
				this.Result = typedResponse.Result;
				Action<T> callback = this.Callback;
				if (callback != null)
				{
					callback(this.Result);
				}
			}
		}

		// Token: 0x04000E33 RID: 3635
		public T Result;

		// Token: 0x04000E34 RID: 3636
		[NonSerialized]
		public Action<T> Callback;
	}
}

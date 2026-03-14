using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace BugReporter
{
	// Token: 0x02000373 RID: 883
	public static class BugReporter
	{
		// Token: 0x06001BEC RID: 7148 RVA: 0x000EF138 File Offset: 0x000ED338
		public static void ShowError(Exception error)
		{
			bool flag = GameApp.OFFLINE || !GameApp.STEAMBUILD;
			if (!flag)
			{
				bool flag2 = error != null && error.Message != null && (error.Message.Contains("Request rate limit reached") || error.Message.Contains("over_request_rate_limit") || error.Message.Contains("\"code\":429") || error.Message.Contains("An error occurred while sending the request") || error.Message.Contains("Found no receiver") || error.Message.Contains("A task was canceled") || error.Message.Contains("More than one global light") || error.Message.Contains("Skipped Data message handling because connection is null") || error.Message.Contains("k_EResultLimitExceeded") || error.Message.Contains("The connection attempt was cancelled"));
				if (!flag2)
				{
					string key = ((error != null) ? error.Message : null) ?? "";
					bool flag3 = BugReporter.ReportedKeys.Contains(key);
					if (!flag3)
					{
						BugReporter.ReportedKeys.Add(key);
						BugReporter.UpdateToSupabase(new BugReporter.ErrorMessage(error)).Forget();
						Commands.LogError("Exception", error.Message + "\n堆栈：" + error.StackTrace);
					}
				}
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000EF29C File Offset: 0x000ED49C
		[DebuggerStepThrough]
		public static UniTask<Client> InitSupabase()
		{
			BugReporter.<InitSupabase>d__4 <InitSupabase>d__ = new BugReporter.<InitSupabase>d__4();
			<InitSupabase>d__.<>t__builder = AsyncUniTaskMethodBuilder<Client>.Create();
			<InitSupabase>d__.<>1__state = -1;
			<InitSupabase>d__.<>t__builder.Start<BugReporter.<InitSupabase>d__4>(ref <InitSupabase>d__);
			return <InitSupabase>d__.<>t__builder.Task;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x000EF2DC File Offset: 0x000ED4DC
		[DebuggerStepThrough]
		private static UniTask UpdateToSupabase(BugReporter.ErrorMessage errorSelection)
		{
			BugReporter.<UpdateToSupabase>d__5 <UpdateToSupabase>d__ = new BugReporter.<UpdateToSupabase>d__5();
			<UpdateToSupabase>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateToSupabase>d__.errorSelection = errorSelection;
			<UpdateToSupabase>d__.<>1__state = -1;
			<UpdateToSupabase>d__.<>t__builder.Start<BugReporter.<UpdateToSupabase>d__5>(ref <UpdateToSupabase>d__);
			return <UpdateToSupabase>d__.<>t__builder.Task;
		}

		// Token: 0x040014E3 RID: 5347
		private static readonly HashSet<string> ReportedKeys = new HashSet<string>();

		// Token: 0x02000374 RID: 884
		public class ErrorMessage
		{
			// Token: 0x06001BF0 RID: 7152 RVA: 0x000EF32C File Offset: 0x000ED52C
			public ErrorMessage(Exception error)
			{
				this.playerid = (Singleton<GameConfigManager>.Instance.PlayerId ?? "UnknownPlayer");
				this.message = "[Version:" + GameConfigManager.Version + "] " + error.Message;
				this.stackTrace = error.StackTrace;
				this.isSolved = false;
				this.note = "";
			}

			// Token: 0x06001BF1 RID: 7153 RVA: 0x00002540 File Offset: 0x00000740
			public ErrorMessage()
			{
			}

			// Token: 0x040014E4 RID: 5348
			public string playerid;

			// Token: 0x040014E5 RID: 5349
			public string message;

			// Token: 0x040014E6 RID: 5350
			public string stackTrace;

			// Token: 0x040014E7 RID: 5351
			public bool isSolved;

			// Token: 0x040014E8 RID: 5352
			public string note;
		}

		// Token: 0x02000375 RID: 885
		[Table("error_selection")]
		private class ErrorSelection : BaseModel
		{
			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000EF398 File Offset: 0x000ED598
			// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x000EF3A0 File Offset: 0x000ED5A0
			[Column("data", NullValueHandling.Include, false, false)]
			public string data { get; set; }
		}
	}
}

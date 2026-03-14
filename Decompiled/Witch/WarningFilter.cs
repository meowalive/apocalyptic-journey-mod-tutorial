using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

// Token: 0x02000070 RID: 112
[ExecuteAlways]
public class WarningFilter : MonoBehaviour
{
	// Token: 0x0600039B RID: 923 RVA: 0x0001E3F7 File Offset: 0x0001C5F7
	private void Awake()
	{
		this.handler = new WarningFilter.BlockingLogHandler(Debug.unityLogger.logHandler);
		Debug.unityLogger.logHandler = this.handler;
		Debug.LogWarning("CanvasRenderer is not Necessary");
	}

	// Token: 0x0600039C RID: 924 RVA: 0x0001E42B File Offset: 0x0001C62B
	[DidReloadScripts]
	private static void EditorMethod()
	{
		EditorApplication.delayCall = (EditorApplication.CallbackFunction)Delegate.Combine(EditorApplication.delayCall, new EditorApplication.CallbackFunction(delegate()
		{
			GameObject go = GameObject.Find("debug");
			bool flag = go == null;
			if (!flag)
			{
				WarningFilter wf = go.GetComponent<WarningFilter>();
				bool flag2 = wf == null;
				if (!flag2)
				{
					wf.Awake();
				}
			}
		}));
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0001E464 File Offset: 0x0001C664
	private void OnDestroy()
	{
		bool flag = Debug.unityLogger != null && this.handler != null;
		if (flag)
		{
			Debug.unityLogger.logHandler = this.handler._originalHandler;
		}
	}

	// Token: 0x04000971 RID: 2417
	private WarningFilter.BlockingLogHandler handler;

	// Token: 0x04000972 RID: 2418
	private static readonly HashSet<string> BlockedKeywords = new HashSet<string>
	{
		"CanvasRenderer",
		"The operation was canceled.",
		"called on Network Game Manager without an active client",
		"called when client was not active",
		"The assembly has already been processed by Fody."
	};

	// Token: 0x02000071 RID: 113
	private class BlockingLogHandler : ILogHandler
	{
		// Token: 0x060003A0 RID: 928 RVA: 0x0001E4F7 File Offset: 0x0001C6F7
		public BlockingLogHandler(ILogHandler originalHandler)
		{
			this._originalHandler = originalHandler;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0001E508 File Offset: 0x0001C708
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
			string message = string.Format(format, args);
			foreach (string keyword in WarningFilter.BlockedKeywords)
			{
				bool flag = message.Contains(keyword);
				if (flag)
				{
					return;
				}
			}
			this._originalHandler.LogFormat(logType, context, format, args);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001E580 File Offset: 0x0001C780
		public void LogException(Exception exception, UnityEngine.Object context)
		{
			foreach (string keyword in WarningFilter.BlockedKeywords)
			{
				bool flag = exception.Message.Contains(keyword);
				if (flag)
				{
					return;
				}
			}
			this._originalHandler.LogException(exception, context);
		}

		// Token: 0x04000973 RID: 2419
		public readonly ILogHandler _originalHandler;
	}
}

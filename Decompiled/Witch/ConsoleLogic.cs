using System;
using System.Collections.Generic;
using System.Reflection;
using Data.Save;
using UnityEngine;

// Token: 0x02000031 RID: 49
public class ConsoleLogic : MonoBehaviour
{
	// Token: 0x0600013D RID: 317 RVA: 0x0000C854 File Offset: 0x0000AA54
	public static string Input(string command)
	{
		bool flag = command == "999112";
		string result;
		if (flag)
		{
			ConsoleLogic.canCheat = true;
			result = "<color=green>作弊权限已开启！</color>";
		}
		else
		{
			bool flag2 = !Application.isEditor && !ConsoleLogic.canCheat;
			if (flag2)
			{
				bool flag3 = (PlayerManager.Instance != null && !PlayerManager.Instance.isServer) || !GameSaveManager.CheckCheat();
				if (flag3)
				{
					return "<color=red>权限不足！</color>";
				}
			}
			List<string> args = new List<string>(command.Split(' ', StringSplitOptions.None));
			ConsoleLogic.commandHistory.Add(command);
			ConsoleLogic.pos = ConsoleLogic.commandHistory.Count;
			MethodInfo method = typeof(Commands).GetMethod(args[0]);
			bool flag4 = method == null;
			if (flag4)
			{
				result = "<color=red>命令不存在。</color>";
			}
			else
			{
				object[] argsArray = new object[method.GetParameters().Length];
				bool flag5 = argsArray.Length < args.Count - 1;
				if (flag5)
				{
					result = "<color=red>参数过多！</color>";
				}
				else
				{
					for (int i = 1; i < args.Count; i++)
					{
						argsArray[i - 1] = args[i];
					}
					bool flag6 = method.GetParameters().Length > args.Count - 1;
					if (flag6)
					{
						result = "<color=red>参数缺失！</color>";
					}
					else
					{
						object outputString = method.Invoke(typeof(Commands), argsArray);
						result = ((outputString != null) ? outputString.ToString() : null);
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0000C9CC File Offset: 0x0000ABCC
	public static string LastCommand()
	{
		bool flag = ConsoleLogic.pos == -1;
		string result;
		if (flag)
		{
			result = null;
		}
		else
		{
			ConsoleLogic.pos--;
			bool flag2 = ConsoleLogic.pos < 0;
			if (flag2)
			{
				ConsoleLogic.pos = 0;
			}
			result = ConsoleLogic.commandHistory[ConsoleLogic.pos];
		}
		return result;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x0000CA1C File Offset: 0x0000AC1C
	public static string NextCommand()
	{
		bool flag = ConsoleLogic.pos == -1;
		string result;
		if (flag)
		{
			result = null;
		}
		else
		{
			ConsoleLogic.pos++;
			bool flag2 = ConsoleLogic.pos >= ConsoleLogic.commandHistory.Count;
			if (flag2)
			{
				ConsoleLogic.pos = ConsoleLogic.commandHistory.Count - 1;
			}
			result = ConsoleLogic.commandHistory[ConsoleLogic.pos];
		}
		return result;
	}

	// Token: 0x040000BE RID: 190
	private static List<string> commandHistory = new List<string>();

	// Token: 0x040000BF RID: 191
	private static int pos = -1;

	// Token: 0x040000C0 RID: 192
	private static bool canCheat = false;
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x020000B8 RID: 184
public class DialogueManager : Singleton<DialogueManager>
{
	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060005D6 RID: 1494 RVA: 0x000347EC File Offset: 0x000329EC
	public bool IsChat
	{
		[DebuggerStepThrough]
		get
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DialogueManager);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.get_IsChat()).MethodHandle, typeof(DialogueManager).TypeHandle);
			methodContext.Arguments = new object[0];
			bool flag;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					flag = (bool)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							flag = this.$Rougamo_get_IsChat();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							if (exceptionHandled)
							{
								flag = (bool)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_10D;
							}
							throw;
						}
						methodContext.ReturnValue = flag;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						flag = (bool)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_10D:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return flag;
		}
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00034930 File Offset: 0x00032B30
	public void Init()
	{
		using (List<Dictionary<string, string>>.Enumerator enumerator = Singleton<GameConfigManager>.Instance.GetTable(DataType.Dialogue).Getlines().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Dictionary<string, string> item = enumerator.Current;
				bool flag = !string.IsNullOrEmpty(item["EventName"]);
				if (flag)
				{
					Singleton<EventCenter>.Instance.AddEventListener(item["EventName"], delegate()
					{
						this.ShowDialogue(item["Id"]);
					}, this, EventDispose.None);
				}
			}
		}
		using (List<Dictionary<string, string>>.Enumerator enumerator2 = Singleton<GameConfigManager>.Instance.GetTable(DataType.DialogueBox).Getlines().GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				Dictionary<string, string> item = enumerator2.Current;
				bool flag2 = !string.IsNullOrEmpty(item["EventName"]);
				if (flag2)
				{
					Singleton<EventCenter>.Instance.AddEventListener(item["EventName"], delegate()
					{
						this.ShowDialogueBox(item["Id"]);
					}, this, EventDispose.None);
				}
			}
		}
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00034A90 File Offset: 0x00032C90
	[DebuggerStepThrough]
	public void ShowDialogue(string id)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.ShowDialogue(string)).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			id
		};
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						id = null;
					}
					else
					{
						id = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_ShowDialogue(id);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_FD;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_FD:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00034BC4 File Offset: 0x00032DC4
	[DebuggerStepThrough]
	public void ShowDialogueBox(string id)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.ShowDialogueBox(string)).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			id
		};
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						id = null;
					}
					else
					{
						id = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_ShowDialogueBox(id);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_FD;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_FD:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00034CF8 File Offset: 0x00032EF8
	[DebuggerStepThrough]
	public void ShowEmoji(string instanceId, GifAsset emoji)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.ShowEmoji(string, GifAsset)).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			instanceId,
			emoji
		};
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						instanceId = null;
					}
					else
					{
						instanceId = (string)arguments[0];
					}
					if (arguments[1] == null)
					{
						emoji = null;
					}
					else
					{
						emoji = (GifAsset)arguments[1];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_ShowEmoji(instanceId, emoji);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_11D;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_11D:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00034E4C File Offset: 0x0003304C
	[DebuggerStepThrough]
	private void InternalShowDialogue(string id)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.InternalShowDialogue(string)).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			id
		};
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						id = null;
					}
					else
					{
						id = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_InternalShowDialogue(id);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_FD;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_FD:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00034F80 File Offset: 0x00033180
	[DebuggerStepThrough]
	private void InternalShowDialogueBox(string id)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.InternalShowDialogueBox(string)).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			id
		};
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						id = null;
					}
					else
					{
						id = (string)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_InternalShowDialogueBox(id);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_FD;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_FD:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x000350B4 File Offset: 0x000332B4
	[DebuggerStepThrough]
	public void NextDialogue()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.NextDialogue()).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						this.$Rougamo_NextDialogue();
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_C8;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_C8:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x000351B0 File Offset: 0x000333B0
	[DebuggerStepThrough]
	public void NextDialogueBox()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.NextDialogueBox()).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						this.$Rougamo_NextDialogueBox();
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_C8;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_C8:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x000352AC File Offset: 0x000334AC
	[DebuggerStepThrough]
	public void ShowOptions([TupleElementNames(new string[]
	{
		"text",
		"action"
	})] params ValueTuple<string, Action>[] options)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.ShowOptions(ValueTuple<string, Action>[])).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[]
		{
			options
		};
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						options = null;
					}
					else
					{
						options = (ValueTuple<string, Action>[])arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_ShowOptions(options);
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_FD;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_FD:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x000353E0 File Offset: 0x000335E0
	[DebuggerStepThrough]
	public void EndDialogue()
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(DialogueManager);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DialogueManager.EndDialogue()).MethodHandle, typeof(DialogueManager).TypeHandle);
		methodContext.Arguments = new object[0];
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				modifiable.OnExit(methodContext);
			}
			else
			{
				do
				{
					try
					{
						this.$Rougamo_EndDialogue();
					}
					catch (Exception exception)
					{
						methodContext.Exception = exception;
						modifiable.OnException(methodContext);
						if (methodContext.RetryCount > 0)
						{
							continue;
						}
						bool exceptionHandled = methodContext.ExceptionHandled;
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_C8;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_C8:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00035502 File Offset: 0x00033702
	private bool $Rougamo_get_IsChat()
	{
		return this.nowDialogue != null;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0003550D File Offset: 0x0003370D
	private void $Rougamo_ShowDialogue(string id)
	{
		this.InternalShowDialogue(id);
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00035518 File Offset: 0x00033718
	private void $Rougamo_ShowDialogueBox(string id)
	{
		this.InternalShowDialogueBox(id);
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00035524 File Offset: 0x00033724
	private void $Rougamo_ShowEmoji(string instanceId, GifAsset emoji)
	{
		bool flag = string.IsNullOrEmpty(instanceId) || emoji == null;
		if (!flag)
		{
			bool flag2 = !this.Identity.ContainsKey(instanceId);
			if (!flag2)
			{
				DialogueBox value;
				bool flag3 = this.dialogueBoxCache.TryGetValue(instanceId, out value) && value != null;
				if (flag3)
				{
					value.Close();
				}
				this.dialogueBoxCache[instanceId] = UIManager.Instance.CreateDialogueBox();
				this.dialogueBoxCache[instanceId].gameObject.SetActive(false);
				UniTask.WaitForSeconds(0.3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
				{
					bool flag4 = !this.Identity.ContainsKey(instanceId);
					if (flag4)
					{
						UnityEngine.Object.Destroy(this.dialogueBoxCache[instanceId].gameObject);
						this.dialogueBoxCache[instanceId] = null;
					}
					else
					{
						this.dialogueBoxCache[instanceId].gameObject.SetActive(true);
						this.dialogueBoxCache[instanceId].ShowEmoji(instanceId, emoji);
					}
				});
			}
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00035620 File Offset: 0x00033820
	private void $Rougamo_InternalShowDialogue(string id)
	{
		this.nowDialogue = id;
		DataConfig dataConfig = new DataConfig(id, DataType.Dialogue);
		DialogueUI ui = UIManager.Instance.GetUI<DialogueUI>("DialogueUI") ?? UIManager.Instance.ShowUI<DialogueUI>("DialogueUI", true);
		ui.ShowDialogue(dataConfig);
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0003566C File Offset: 0x0003386C
	private void $Rougamo_InternalShowDialogueBox(string id)
	{
		DataConfig dataconfig = new DataConfig(id, DataType.DialogueBox);
		DialogueBox value;
		bool flag = this.dialogueBoxCache.TryGetValue(dataconfig.data["RoleId"], out value) && value != null;
		if (flag)
		{
			value.Close();
		}
		this.nowDialogue = id;
		bool flag2 = !this.Identity.ContainsKey(dataconfig.data["RoleId"]);
		if (!flag2)
		{
			UniTask.WaitForSeconds(0.3f, false, PlayerLoopTiming.Update, default(CancellationToken), false).ContinueWith(delegate()
			{
				bool flag3 = !this.Identity.ContainsKey(dataconfig.data["RoleId"]);
				if (!flag3)
				{
					DataConfig dataConfig = new DataConfig(id, DataType.DialogueBox);
					this.dialogueBoxCache[dataconfig.data["RoleId"]] = UIManager.Instance.CreateDialogueBox();
					this.dialogueBoxCache[dataconfig.data["RoleId"]].ShowDialogue(dataConfig);
				}
			});
		}
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00035738 File Offset: 0x00033938
	private void $Rougamo_NextDialogue()
	{
		bool flag = this.nowDialogue == null;
		if (!flag)
		{
			GameConfigManager instance = Singleton<GameConfigManager>.Instance;
			List<Dictionary<string, string>> list = Singleton<GameConfigManager>.Instance.GetTable(DataType.Dialogue).Getlines();
			string text = this.nowDialogue;
			int length = this.nowDialogue.Length;
			string[] array = this.nowDialogue.Split("_", StringSplitOptions.None);
			Dictionary<string, Dictionary<string, string>> data = instance.GetDataByPrefix(list, text.Remove(length - array[array.Length - 1].Length));
			string[] array2 = this.nowDialogue.Split("_", StringSplitOptions.None);
			int index = array2[array2.Length - 1].ToInt();
			bool flag2;
			if (index + 1 <= data.Count)
			{
				Dictionary<string, Dictionary<string, string>> dictionary = data;
				string text2 = this.nowDialogue;
				int length2 = this.nowDialogue.Length;
				string[] array3 = this.nowDialogue.Split("_", StringSplitOptions.None);
				flag2 = !dictionary.ContainsKey(text2.Remove(length2 - array3[array3.Length - 1].Length) + (index + 1).ToString());
			}
			else
			{
				flag2 = true;
			}
			bool flag3 = flag2;
			if (flag3)
			{
				Dictionary<string, bool> isTutorialCompleted = Singleton<GameRuntimeData>.Instance.IsTutorialCompleted;
				string text3 = this.nowDialogue;
				string[] array4 = this.nowDialogue.Split("_", StringSplitOptions.None);
				int num = array4[array4.Length - 1].Length + 1;
				bool flag4 = !isTutorialCompleted.ContainsKey(text3.Substring(0, text3.Length - num));
				if (flag4)
				{
					Dictionary<string, bool> isTutorialCompleted2 = Singleton<GameRuntimeData>.Instance.IsTutorialCompleted;
					text3 = this.nowDialogue;
					string[] array5 = this.nowDialogue.Split("_", StringSplitOptions.None);
					num = array5[array5.Length - 1].Length + 1;
					isTutorialCompleted2[text3.Substring(0, text3.Length - num)] = true;
					Singleton<GameRuntimeData>.Instance.Save();
				}
				this.nowDialogue = null;
				this.EndDialogue();
			}
			else
			{
				string text4 = this.nowDialogue;
				int length3 = this.nowDialogue.Length;
				string[] array6 = this.nowDialogue.Split("_", StringSplitOptions.None);
				this.InternalShowDialogue(text4.Remove(length3 - array6[array6.Length - 1].Length) + (index + 1).ToString());
			}
		}
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0003592C File Offset: 0x00033B2C
	private void $Rougamo_NextDialogueBox()
	{
		bool flag = this.nowDialogue == null;
		if (!flag)
		{
			GameConfigManager instance = Singleton<GameConfigManager>.Instance;
			List<Dictionary<string, string>> list = Singleton<GameConfigManager>.Instance.GetTable(DataType.DialogueBox).Getlines();
			string text = this.nowDialogue;
			int length = this.nowDialogue.Length;
			string[] array = this.nowDialogue.Split("_", StringSplitOptions.None);
			Dictionary<string, Dictionary<string, string>> data = instance.GetDataByPrefix(list, text.Remove(length - array[array.Length - 1].Length));
			string[] array2 = this.nowDialogue.Split("_", StringSplitOptions.None);
			int index = array2[array2.Length - 1].ToInt();
			bool flag2;
			if (index + 1 <= data.Count)
			{
				Dictionary<string, Dictionary<string, string>> dictionary = data;
				string text2 = this.nowDialogue;
				int length2 = this.nowDialogue.Length;
				string[] array3 = this.nowDialogue.Split("_", StringSplitOptions.None);
				flag2 = !dictionary.ContainsKey(text2.Remove(length2 - array3[array3.Length - 1].Length) + (index + 1).ToString());
			}
			else
			{
				flag2 = true;
			}
			bool flag3 = flag2;
			if (flag3)
			{
				this.nowDialogue = null;
			}
			else
			{
				string text3 = this.nowDialogue;
				int length3 = this.nowDialogue.Length;
				string[] array4 = this.nowDialogue.Split("_", StringSplitOptions.None);
				this.InternalShowDialogueBox(text3.Remove(length3 - array4[array4.Length - 1].Length) + (index + 1).ToString());
			}
		}
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00035A6C File Offset: 0x00033C6C
	private void $Rougamo_ShowOptions(ValueTuple<string, Action>[] options)
	{
		OptionsUI ui = UIManager.Instance.ShowUI<OptionsUI>("OptionsUI", true);
		foreach (ValueTuple<string, Action> option in options)
		{
			ui.AddOption(option.Item1, option.Item2);
		}
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00035ABC File Offset: 0x00033CBC
	private void $Rougamo_EndDialogue()
	{
		bool flag;
		if (this.nowDialogue != null)
		{
			Dictionary<string, bool> isTutorialCompleted = Singleton<GameRuntimeData>.Instance.IsTutorialCompleted;
			string text = this.nowDialogue;
			string[] array = this.nowDialogue.Split("_", StringSplitOptions.None);
			int num = array[array.Length - 1].Length + 1;
			flag = !isTutorialCompleted.ContainsKey(text.Substring(0, text.Length - num));
		}
		else
		{
			flag = false;
		}
		bool flag2 = flag;
		if (flag2)
		{
			Dictionary<string, bool> isTutorialCompleted2 = Singleton<GameRuntimeData>.Instance.IsTutorialCompleted;
			string text = this.nowDialogue;
			string[] array2 = this.nowDialogue.Split("_", StringSplitOptions.None);
			int num = array2[array2.Length - 1].Length + 1;
			isTutorialCompleted2[text.Substring(0, text.Length - num)] = true;
			Singleton<GameRuntimeData>.Instance.Save();
		}
		this.nowDialogue = null;
		UIManager.Instance.CloseUI("DialogueUI");
	}

	// Token: 0x04000A6A RID: 2666
	public Dictionary<string, GameObject> Identity = new Dictionary<string, GameObject>();

	// Token: 0x04000A6B RID: 2667
	private string nowDialogue = null;

	// Token: 0x04000A6C RID: 2668
	private Dictionary<string, DialogueBox> dialogueBoxCache = new Dictionary<string, DialogueBox>();
}

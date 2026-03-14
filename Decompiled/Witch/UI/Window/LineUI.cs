using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Rougamo;
using Rougamo.Context;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Witch.UI.Window
{
	// Token: 0x020002F5 RID: 757
	public class LineUI : UIBase
	{
		// Token: 0x060017AF RID: 6063 RVA: 0x000C4CE0 File Offset: 0x000C2EE0
		[DebuggerStepThrough]
		private void Awake()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.Awake()).MethodHandle, typeof(LineUI).TypeHandle);
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
							this.$Rougamo_Awake();
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

		// Token: 0x060017B0 RID: 6064 RVA: 0x000C4DDC File Offset: 0x000C2FDC
		[DebuggerStepThrough]
		private void OnTransformChildrenChanged()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.OnTransformChildrenChanged()).MethodHandle, typeof(LineUI).TypeHandle);
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
							this.$Rougamo_OnTransformChildrenChanged();
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

		// Token: 0x060017B1 RID: 6065 RVA: 0x000C4ED8 File Offset: 0x000C30D8
		[DebuggerStepThrough]
		private void CacheChildren()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.CacheChildren()).MethodHandle, typeof(LineUI).TypeHandle);
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
							this.$Rougamo_CacheChildren();
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

		// Token: 0x060017B2 RID: 6066 RVA: 0x000C4FD4 File Offset: 0x000C31D4
		[DebuggerStepThrough]
		private void EnsureTable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.EnsureTable()).MethodHandle, typeof(LineUI).TypeHandle);
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
							this.$Rougamo_EnsureTable();
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

		// Token: 0x060017B3 RID: 6067 RVA: 0x000C50D0 File Offset: 0x000C32D0
		[DebuggerStepThrough]
		public void SetStartPos(Vector3 pos)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.SetStartPos(Vector3)).MethodHandle, typeof(LineUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				pos
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
							pos = default(Vector3);
						}
						else
						{
							pos = (Vector3)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetStartPos(pos);
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
								goto IL_105;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_105:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000C520C File Offset: 0x000C340C
		[DebuggerStepThrough]
		public void SetEndPos(Vector2? pos = null)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.SetEndPos(Vector2?)).MethodHandle, typeof(LineUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				pos
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
							pos = null;
						}
						else
						{
							pos = (Vector2?)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetEndPos(pos);
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
								goto IL_105;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_105:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000C5348 File Offset: 0x000C3548
		[DebuggerStepThrough]
		private Vector3 GetBezierTangent(Vector3 start, Vector3 mid, Vector3 end, float t)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.GetBezierTangent(Vector3, Vector3, Vector3, float)).MethodHandle, typeof(LineUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				start,
				mid,
				end,
				t
			};
			Vector3 vector;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					vector = (Vector3)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							start = default(Vector3);
						}
						else
						{
							start = (Vector3)arguments[0];
						}
						if (arguments[1] == null)
						{
							mid = default(Vector3);
						}
						else
						{
							mid = (Vector3)arguments[1];
						}
						if (arguments[2] == null)
						{
							end = default(Vector3);
						}
						else
						{
							end = (Vector3)arguments[2];
						}
						if (arguments[3] == null)
						{
							t = 0f;
						}
						else
						{
							t = (float)arguments[3];
						}
					}
					do
					{
						try
						{
							vector = this.$Rougamo_GetBezierTangent(start, mid, end, t);
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
								vector = (Vector3)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_1CB;
							}
							throw;
						}
						methodContext.ReturnValue = vector;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						vector = (Vector3)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_1CB:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return vector;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000C5560 File Offset: 0x000C3760
		[DebuggerStepThrough]
		private void BuildArcLengthTable(Vector3 start, Vector3 mid, Vector3 end, float[] table)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.BuildArcLengthTable(Vector3, Vector3, Vector3, float[])).MethodHandle, typeof(LineUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				start,
				mid,
				end,
				table
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
							start = default(Vector3);
						}
						else
						{
							start = (Vector3)arguments[0];
						}
						if (arguments[1] == null)
						{
							mid = default(Vector3);
						}
						else
						{
							mid = (Vector3)arguments[1];
						}
						if (arguments[2] == null)
						{
							end = default(Vector3);
						}
						else
						{
							end = (Vector3)arguments[2];
						}
						if (arguments[3] == null)
						{
							table = null;
						}
						else
						{
							table = (float[])arguments[3];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_BuildArcLengthTable(start, mid, end, table);
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
								goto IL_17A;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_17A:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000C5728 File Offset: 0x000C3928
		[DebuggerStepThrough]
		private float GetParameterByArcLength(float[] table, float targetLength)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.GetParameterByArcLength(float[], float)).MethodHandle, typeof(LineUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				table,
				targetLength
			};
			float num;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					num = (float)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							table = null;
						}
						else
						{
							table = (float[])arguments[0];
						}
						if (arguments[1] == null)
						{
							targetLength = 0f;
						}
						else
						{
							targetLength = (float)arguments[1];
						}
					}
					do
					{
						try
						{
							num = this.$Rougamo_GetParameterByArcLength(table, targetLength);
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
								num = (float)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_16A;
							}
							throw;
						}
						methodContext.ReturnValue = num;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						num = (float)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_16A:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return num;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000C58E0 File Offset: 0x000C3AE0
		[DebuggerStepThrough]
		public Vector3 GetBezier(Vector3 start, Vector3 mid, Vector3 end, float t)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.GetBezier(Vector3, Vector3, Vector3, float)).MethodHandle, typeof(LineUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				start,
				mid,
				end,
				t
			};
			Vector3 vector;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					vector = (Vector3)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							start = default(Vector3);
						}
						else
						{
							start = (Vector3)arguments[0];
						}
						if (arguments[1] == null)
						{
							mid = default(Vector3);
						}
						else
						{
							mid = (Vector3)arguments[1];
						}
						if (arguments[2] == null)
						{
							end = default(Vector3);
						}
						else
						{
							end = (Vector3)arguments[2];
						}
						if (arguments[3] == null)
						{
							t = 0f;
						}
						else
						{
							t = (float)arguments[3];
						}
					}
					do
					{
						try
						{
							vector = this.$Rougamo_GetBezier(start, mid, end, t);
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
								vector = (Vector3)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_1CB;
							}
							throw;
						}
						methodContext.ReturnValue = vector;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						vector = (Vector3)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_1CB:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return vector;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000C5AF8 File Offset: 0x000C3CF8
		[DebuggerStepThrough]
		public override void FadeIn()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.FadeIn()).MethodHandle, typeof(LineUI).TypeHandle);
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
							this.$Rougamo_FadeIn();
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

		// Token: 0x060017BA RID: 6074 RVA: 0x000C5BF4 File Offset: 0x000C3DF4
		[DebuggerStepThrough]
		public override void FadeOut(Action callback)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.FadeOut(Action)).MethodHandle, typeof(LineUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				callback
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
							callback = null;
						}
						else
						{
							callback = (Action)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_FadeOut(callback);
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

		// Token: 0x060017BB RID: 6075 RVA: 0x000C5D28 File Offset: 0x000C3F28
		[DebuggerStepThrough]
		public override void OnDestroy()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(LineUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(LineUI.OnDestroy()).MethodHandle, typeof(LineUI).TypeHandle);
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
							this.$Rougamo_OnDestroy();
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

		// Token: 0x060017BD RID: 6077 RVA: 0x000C5E35 File Offset: 0x000C4035
		private void $Rougamo_Awake()
		{
			this.canvasRect = base.transform.root.GetComponent<RectTransform>();
			this.uiCam = Camera.main;
			this.CacheChildren();
			this.EnsureTable();
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000C5E67 File Offset: 0x000C4067
		private void $Rougamo_OnTransformChildrenChanged()
		{
			this.CacheChildren();
			this.EnsureTable();
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x000C5E78 File Offset: 0x000C4078
		private void $Rougamo_CacheChildren()
		{
			int i = base.transform.childCount;
			this.points = new RectTransform[i];
			for (int j = 0; j < i; j++)
			{
				this.points[j] = base.transform.GetChild(j).GetComponent<RectTransform>();
			}
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000C5EC8 File Offset: 0x000C40C8
		private void $Rougamo_EnsureTable()
		{
			int len = Mathf.Max(2, this.arcLengthSamples + 1);
			bool flag = this.arcLengthTable == null || this.arcLengthTable.Length != len;
			if (flag)
			{
				this.arcLengthTable = new float[len];
			}
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000C5F10 File Offset: 0x000C4110
		private void $Rougamo_SetStartPos(Vector3 pos)
		{
			bool flag = this.points == null || this.points.Length == 0;
			if (!flag)
			{
				this.points[0].position = pos;
			}
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000C5F48 File Offset: 0x000C4148
		private void $Rougamo_SetEndPos([Optional] Vector2? pos)
		{
			bool flag = this.points == null || this.points.Length == 0;
			if (!flag)
			{
				Vector2 mousePos = KeyManager.playerAction.Main.Point.ReadValue<Vector2>();
				bool flag2 = pos != null;
				if (flag2)
				{
					mousePos = pos.Value;
				}
				Vector2 localPoint;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(this.canvasRect, mousePos, this.uiCam, out localPoint);
				bool flag3 = (localPoint - this.lastMouseLocal).sqrMagnitude < 0.0625f;
				if (!flag3)
				{
					this.lastMouseLocal = localPoint;
					Vector3 startPos = this.points[0].localPosition;
					Vector3 endPos = new Vector3(localPoint.x, localPoint.y, startPos.z);
					Vector3 midPos = new Vector3(startPos.x, (startPos.y + endPos.y) * 0.5f, startPos.z);
					this.BuildArcLengthTable(startPos, midPos, endPos, this.arcLengthTable);
					float totalLength = this.arcLengthTable[this.arcLengthTable.Length - 1];
					int last = this.points.Length - 1;
					for (int i = last; i >= 0; i--)
					{
						float targetLength = (float)i / (float)last * totalLength;
						float t = this.GetParameterByArcLength(this.arcLengthTable, targetLength);
						Vector3 p = this.GetBezier(startPos, midPos, endPos, t);
						bool flag4 = i == last;
						Vector3 dir;
						if (flag4)
						{
							dir = this.GetBezierTangent(startPos, midPos, endPos, t);
						}
						else
						{
							dir = this.points[i + 1].anchoredPosition - this.points[i].anchoredPosition;
						}
						float angleZ = Mathf.Atan2(dir.y, dir.x) * 57.29578f - 90f;
						this.points[i].SetLocalPositionAndRotation(p, Quaternion.Euler(0f, 0f, angleZ));
					}
				}
			}
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000C6140 File Offset: 0x000C4340
		private Vector3 $Rougamo_GetBezierTangent(Vector3 start, Vector3 mid, Vector3 end, float t)
		{
			return 2f * (1f - t) * (mid - start) + 2f * t * (end - mid);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x000C6188 File Offset: 0x000C4388
		private void $Rougamo_BuildArcLengthTable(Vector3 start, Vector3 mid, Vector3 end, float[] table)
		{
			table[0] = 0f;
			Vector3 prevPoint = start;
			float acc = 0f;
			int samples = table.Length - 1;
			for (int i = 1; i <= samples; i++)
			{
				float t = (float)i / (float)samples;
				Vector3 cur = this.GetBezier(start, mid, end, t);
				acc += Vector3.Distance(prevPoint, cur);
				table[i] = acc;
				prevPoint = cur;
			}
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x000C61EC File Offset: 0x000C43EC
		private float $Rougamo_GetParameterByArcLength(float[] table, float targetLength)
		{
			int samples = table.Length - 1;
			for (int i = 0; i < samples; i++)
			{
				bool flag = targetLength >= table[i] && targetLength <= table[i + 1];
				if (flag)
				{
					float ratio = (targetLength - table[i]) / (table[i + 1] - table[i]);
					return ((float)i + ratio) / (float)samples;
				}
			}
			return 1f;
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x000C6254 File Offset: 0x000C4454
		private Vector3 $Rougamo_GetBezier(Vector3 start, Vector3 mid, Vector3 end, float t)
		{
			return (1f - t) * (1f - t) * start + 2f * t * (1f - t) * mid + t * t * end;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000026D9 File Offset: 0x000008D9
		private void $Rougamo_FadeIn()
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x000C62A9 File Offset: 0x000C44A9
		private void $Rougamo_FadeOut(Action callback)
		{
			callback();
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000C62B4 File Offset: 0x000C44B4
		private void $Rougamo_OnDestroy()
		{
			EventSystem currentSystem = EventSystem.current;
			bool flag = currentSystem != null;
			if (flag)
			{
				currentSystem.enabled = true;
			}
			Cursor.visible = true;
		}

		// Token: 0x0400127B RID: 4731
		[Header("弧长采样精度")]
		public int arcLengthSamples = 50;

		// Token: 0x0400127C RID: 4732
		private RectTransform canvasRect;

		// Token: 0x0400127D RID: 4733
		private Camera uiCam;

		// Token: 0x0400127E RID: 4734
		private RectTransform[] points;

		// Token: 0x0400127F RID: 4735
		private float[] arcLengthTable;

		// Token: 0x04001280 RID: 4736
		private Vector2 lastMouseLocal;

		// Token: 0x04001281 RID: 4737
		private const float moveThreshold = 0.25f;
	}
}

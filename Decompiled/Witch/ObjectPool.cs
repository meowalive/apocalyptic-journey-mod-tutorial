using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

// Token: 0x0200004C RID: 76
public class ObjectPool : Singleton<ObjectPool>
{
	/// <summary>
	/// 从对象池中获取一个对象
	/// </summary>
	/// <param name="prefab"></param>
	/// <param name="parent">父物体</param>
	/// <returns></returns>
	// Token: 0x06000202 RID: 514 RVA: 0x00012790 File Offset: 0x00010990
	[DebuggerStepThrough]
	public GameObject Get(GameObject prefab, Transform parent = null)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ObjectPool);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ObjectPool.Get(GameObject, Transform)).MethodHandle, typeof(ObjectPool).TypeHandle);
		methodContext.Arguments = new object[]
		{
			prefab,
			parent
		};
		GameObject gameObject;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				gameObject = (GameObject)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						prefab = null;
					}
					else
					{
						prefab = (GameObject)arguments[0];
					}
					if (arguments[1] == null)
					{
						parent = null;
					}
					else
					{
						parent = (Transform)arguments[1];
					}
				}
				do
				{
					try
					{
						gameObject = this.$Rougamo_Get(prefab, parent);
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
							gameObject = (GameObject)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_15D;
						}
						throw;
					}
					methodContext.ReturnValue = gameObject;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					gameObject = (GameObject)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_15D:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return gameObject;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00012924 File Offset: 0x00010B24
	[DebuggerStepThrough]
	public UniTask PreloadAsync(GameObject prefab, int count, int batchSize, CancellationToken cancellationToken)
	{
		ObjectPool.<PreloadAsync>d__3 <PreloadAsync>d__ = new ObjectPool.<PreloadAsync>d__3();
		<PreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadAsync>d__.<>4__this = this;
		<PreloadAsync>d__.prefab = prefab;
		<PreloadAsync>d__.count = count;
		<PreloadAsync>d__.batchSize = batchSize;
		<PreloadAsync>d__.cancellationToken = cancellationToken;
		<PreloadAsync>d__.<>1__state = -1;
		<PreloadAsync>d__.<>t__builder.Start<ObjectPool.<PreloadAsync>d__3>(ref <PreloadAsync>d__);
		return <PreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00012988 File Offset: 0x00010B88
	[DebuggerStepThrough]
	private UniTask InstantiateAndPoolAsync(GameObject prefab, CancellationToken cancellationToken)
	{
		ObjectPool.<InstantiateAndPoolAsync>d__4 <InstantiateAndPoolAsync>d__ = new ObjectPool.<InstantiateAndPoolAsync>d__4();
		<InstantiateAndPoolAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InstantiateAndPoolAsync>d__.<>4__this = this;
		<InstantiateAndPoolAsync>d__.prefab = prefab;
		<InstantiateAndPoolAsync>d__.cancellationToken = cancellationToken;
		<InstantiateAndPoolAsync>d__.<>1__state = -1;
		<InstantiateAndPoolAsync>d__.<>t__builder.Start<ObjectPool.<InstantiateAndPoolAsync>d__4>(ref <InstantiateAndPoolAsync>d__);
		return <InstantiateAndPoolAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06000205 RID: 517 RVA: 0x000129DC File Offset: 0x00010BDC
	[DebuggerStepThrough]
	public void Release(GameObject obj)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(ObjectPool);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(ObjectPool.Release(GameObject)).MethodHandle, typeof(ObjectPool).TypeHandle);
		methodContext.Arguments = new object[]
		{
			obj
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
						obj = null;
					}
					else
					{
						obj = (GameObject)arguments[0];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_Release(obj);
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

	// Token: 0x06000206 RID: 518 RVA: 0x00012B10 File Offset: 0x00010D10
	public void Clear()
	{
		foreach (GameObject obj in this.ObjDic.Keys)
		{
			UnityEngine.Object.Destroy(obj);
		}
		this.Pool.Clear();
		this.ObjDic.Clear();
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00012B80 File Offset: 0x00010D80
	~ObjectPool()
	{
		this.Clear();
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00012BD0 File Offset: 0x00010DD0
	private GameObject $Rougamo_Get(GameObject prefab, [Optional] Transform parent)
	{
		GameObject result = null;
		Queue<GameObject> queue;
		bool flag = !this.Pool.TryGetValue(prefab, out queue);
		if (flag)
		{
			queue = new Queue<GameObject>();
			this.Pool[prefab] = queue;
		}
		bool flag2 = queue.Count > 0;
		if (flag2)
		{
			while (result == null && queue.Count > 0)
			{
				result = queue.Dequeue();
			}
			bool flag3 = result == null;
			if (flag3)
			{
				result = UnityEngine.Object.Instantiate<GameObject>(prefab);
			}
		}
		else
		{
			result = UnityEngine.Object.Instantiate<GameObject>(prefab);
		}
		this.ObjDic.TryAdd(result, prefab);
		result.transform.SetParent(parent ?? prefab.transform.parent);
		result.transform.localScale = prefab.transform.localScale;
		result.transform.localPosition = prefab.transform.localPosition;
		result.SetActive(true);
		return result;
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00012CC8 File Offset: 0x00010EC8
	private UniTask $Rougamo_PreloadAsync(GameObject prefab, int count, int batchSize, CancellationToken cancellationToken)
	{
		ObjectPool.<$Rougamo_PreloadAsync>d__8 <$Rougamo_PreloadAsync>d__ = new ObjectPool.<$Rougamo_PreloadAsync>d__8();
		<$Rougamo_PreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<$Rougamo_PreloadAsync>d__.<>4__this = this;
		<$Rougamo_PreloadAsync>d__.prefab = prefab;
		<$Rougamo_PreloadAsync>d__.count = count;
		<$Rougamo_PreloadAsync>d__.batchSize = batchSize;
		<$Rougamo_PreloadAsync>d__.cancellationToken = cancellationToken;
		<$Rougamo_PreloadAsync>d__.<>1__state = -1;
		<$Rougamo_PreloadAsync>d__.<>t__builder.Start<ObjectPool.<$Rougamo_PreloadAsync>d__8>(ref <$Rougamo_PreloadAsync>d__);
		return <$Rougamo_PreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00012D2C File Offset: 0x00010F2C
	private UniTask $Rougamo_InstantiateAndPoolAsync(GameObject prefab, CancellationToken cancellationToken)
	{
		ObjectPool.<$Rougamo_InstantiateAndPoolAsync>d__9 <$Rougamo_InstantiateAndPoolAsync>d__ = new ObjectPool.<$Rougamo_InstantiateAndPoolAsync>d__9();
		<$Rougamo_InstantiateAndPoolAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<$Rougamo_InstantiateAndPoolAsync>d__.<>4__this = this;
		<$Rougamo_InstantiateAndPoolAsync>d__.prefab = prefab;
		<$Rougamo_InstantiateAndPoolAsync>d__.cancellationToken = cancellationToken;
		<$Rougamo_InstantiateAndPoolAsync>d__.<>1__state = -1;
		<$Rougamo_InstantiateAndPoolAsync>d__.<>t__builder.Start<ObjectPool.<$Rougamo_InstantiateAndPoolAsync>d__9>(ref <$Rougamo_InstantiateAndPoolAsync>d__);
		return <$Rougamo_InstantiateAndPoolAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00012D80 File Offset: 0x00010F80
	private void $Rougamo_Release(GameObject obj)
	{
		bool flag = this.ObjDic.ContainsKey(obj);
		if (flag)
		{
			this.Pool[this.ObjDic[obj]].Enqueue(obj);
			UnityEngine.Object @object;
			this.ObjDic.TryRemove(obj, out @object);
			obj.SetActive(false);
			Singleton<EventCenter>.Instance.Clear(obj);
		}
	}

	// Token: 0x040008BD RID: 2237
	private readonly ConcurrentDictionary<UnityEngine.Object, Queue<GameObject>> Pool = new ConcurrentDictionary<UnityEngine.Object, Queue<GameObject>>();

	// Token: 0x040008BE RID: 2238
	private readonly ConcurrentDictionary<GameObject, UnityEngine.Object> ObjDic = new ConcurrentDictionary<GameObject, UnityEngine.Object>();
}

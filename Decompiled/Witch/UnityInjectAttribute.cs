using System;
using UnityEngine;

/// <summary>
/// 标记字段必须从Unity Inspector中获取，会尝试自动获取组件。
/// 用法：[UnityInject] public Animation anim; 会根据字段类型自动获取组件
/// [UnityInject(true)] 当组件不存在时自动 AddComponent（默认不创建）
/// </summary>
// Token: 0x02000008 RID: 8
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class UnityInjectAttribute : PropertyAttribute
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000013 RID: 19 RVA: 0x00002350 File Offset: 0x00000550
	public bool AutoCreate { get; }

	// Token: 0x06000014 RID: 20 RVA: 0x00002358 File Offset: 0x00000558
	public UnityInjectAttribute(bool autoCreate = false)
	{
		this.AutoCreate = autoCreate;
	}
}

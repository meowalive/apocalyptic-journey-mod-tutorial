using System;
using System.Collections.Generic;
using UnityEngine;

namespace XLua
{
	// Token: 0x0200015A RID: 346
	public static class SysGenConfig
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00055790 File Offset: 0x00053990
		[GCOptimize(OptimizeFlag.Default)]
		private static List<Type> GCOptimize
		{
			get
			{
				return new List<Type>
				{
					typeof(Vector2),
					typeof(Vector3),
					typeof(Vector4),
					typeof(Color),
					typeof(Quaternion),
					typeof(Ray),
					typeof(Bounds),
					typeof(Ray2D)
				};
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00055834 File Offset: 0x00053A34
		[AdditionalProperties]
		private static Dictionary<Type, List<string>> AdditionalProperties
		{
			get
			{
				return new Dictionary<Type, List<string>>
				{
					{
						typeof(Ray),
						new List<string>
						{
							"origin",
							"direction"
						}
					},
					{
						typeof(Ray2D),
						new List<string>
						{
							"origin",
							"direction"
						}
					},
					{
						typeof(Bounds),
						new List<string>
						{
							"center",
							"extents"
						}
					}
				};
			}
		}
	}
}

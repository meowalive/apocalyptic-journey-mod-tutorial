using System;
using System.Collections.Generic;
using System.Reflection;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000147 RID: 327
	internal class InternalGlobals
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x0005010C File Offset: 0x0004E30C
		static InternalGlobals()
		{
			InternalGlobals.extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>();
			InternalGlobals.genTryArrayGetPtr = new InternalGlobals.TryArrayGet(StaticLuaCallbacks.__tryArrayGet);
			InternalGlobals.genTryArraySetPtr = new InternalGlobals.TryArraySet(StaticLuaCallbacks.__tryArraySet);
		}

		// Token: 0x04000CA8 RID: 3240
		internal static byte[] strBuff = new byte[256];

		// Token: 0x04000CA9 RID: 3241
		internal static volatile InternalGlobals.TryArrayGet genTryArrayGetPtr = null;

		// Token: 0x04000CAA RID: 3242
		internal static volatile InternalGlobals.TryArraySet genTryArraySetPtr = null;

		// Token: 0x04000CAB RID: 3243
		internal static volatile ObjectTranslatorPool objectTranslatorPool = new ObjectTranslatorPool();

		// Token: 0x04000CAC RID: 3244
		internal static volatile int LUA_REGISTRYINDEX = -10000;

		// Token: 0x04000CAD RID: 3245
		internal static volatile Dictionary<string, string> supportOp = new Dictionary<string, string>
		{
			{
				"op_Addition",
				"__add"
			},
			{
				"op_Subtraction",
				"__sub"
			},
			{
				"op_Multiply",
				"__mul"
			},
			{
				"op_Division",
				"__div"
			},
			{
				"op_Equality",
				"__eq"
			},
			{
				"op_UnaryNegation",
				"__unm"
			},
			{
				"op_LessThan",
				"__lt"
			},
			{
				"op_LessThanOrEqual",
				"__le"
			},
			{
				"op_Modulus",
				"__mod"
			},
			{
				"op_BitwiseAnd",
				"__band"
			},
			{
				"op_BitwiseOr",
				"__bor"
			},
			{
				"op_ExclusiveOr",
				"__bxor"
			},
			{
				"op_OnesComplement",
				"__bnot"
			},
			{
				"op_LeftShift",
				"__shl"
			},
			{
				"op_RightShift",
				"__shr"
			}
		};

		// Token: 0x04000CAE RID: 3246
		internal static volatile Dictionary<Type, IEnumerable<MethodInfo>> extensionMethodMap = null;

		// Token: 0x04000CAF RID: 3247
		internal static volatile lua_CSFunction LazyReflectionWrap = new lua_CSFunction(Utils.LazyReflectionCall);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x06000A47 RID: 2631
		internal delegate bool TryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x06000A4B RID: 2635
		internal delegate bool TryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);
	}
}

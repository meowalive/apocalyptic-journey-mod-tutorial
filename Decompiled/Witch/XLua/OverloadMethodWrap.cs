using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x02000164 RID: 356
	public class OverloadMethodWrap
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0005762B File Offset: 0x0005582B
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x00057633 File Offset: 0x00055833
		public bool HasDefalutValue { get; private set; }

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0005763C File Offset: 0x0005583C
		public OverloadMethodWrap(ObjectTranslator translator, Type targetType, MethodBase method)
		{
			this.translator = translator;
			this.targetType = targetType;
			this.method = method;
			this.HasDefalutValue = false;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0005768C File Offset: 0x0005588C
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters)
		{
			bool flag = (typeof(Delegate) != this.targetType && typeof(Delegate).IsAssignableFrom(this.targetType)) || !this.method.IsStatic || this.method.IsConstructor;
			if (flag)
			{
				this.luaStackPosStart = 2;
				bool flag2 = !this.method.IsConstructor;
				if (flag2)
				{
					this.targetNeeded = true;
				}
			}
			ParameterInfo[] paramInfos = this.method.GetParameters();
			this.refPos = new int[paramInfos.Length];
			List<int> inPosList = new List<int>();
			List<int> outPosList = new List<int>();
			List<ObjectCheck> paramsChecks = new List<ObjectCheck>();
			List<ObjectCast> paramsCasts = new List<ObjectCast>();
			List<bool> isOptionalList = new List<bool>();
			List<object> defaultValueList = new List<object>();
			for (int i = 0; i < paramInfos.Length; i++)
			{
				this.refPos[i] = -1;
				bool flag3 = !paramInfos[i].IsIn && paramInfos[i].IsOut;
				if (flag3)
				{
					outPosList.Add(i);
				}
				else
				{
					bool isByRef = paramInfos[i].ParameterType.IsByRef;
					if (isByRef)
					{
						Type ttype = paramInfos[i].ParameterType.GetElementType();
						bool flag4 = CopyByValue.IsStruct(ttype) && ttype != typeof(decimal);
						if (flag4)
						{
							this.refPos[i] = inPosList.Count;
						}
						outPosList.Add(i);
					}
					inPosList.Add(i);
					Type paramType = (paramInfos[i].IsDefined(typeof(ParamArrayAttribute), false) || (!paramInfos[i].ParameterType.IsArray && paramInfos[i].ParameterType.IsByRef)) ? paramInfos[i].ParameterType.GetElementType() : paramInfos[i].ParameterType;
					paramsChecks.Add(objCheckers.GetChecker(paramType));
					paramsCasts.Add(objCasters.GetCaster(paramType));
					isOptionalList.Add(paramInfos[i].IsOptional);
					object defalutValue = paramInfos[i].DefaultValue;
					bool isOptional = paramInfos[i].IsOptional;
					if (isOptional)
					{
						bool flag5 = defalutValue != null && defalutValue.GetType() != paramInfos[i].ParameterType;
						if (flag5)
						{
							defalutValue = ((defalutValue.GetType() == typeof(Missing)) ? (paramInfos[i].ParameterType.IsValueType() ? Activator.CreateInstance(paramInfos[i].ParameterType) : Missing.Value) : Convert.ChangeType(defalutValue, paramInfos[i].ParameterType));
						}
						this.HasDefalutValue = true;
					}
					defaultValueList.Add(paramInfos[i].IsOptional ? defalutValue : null);
				}
			}
			this.checkArray = paramsChecks.ToArray();
			this.castArray = paramsCasts.ToArray();
			this.inPosArray = inPosList.ToArray();
			this.outPosArray = outPosList.ToArray();
			this.isOptionalArray = isOptionalList.ToArray();
			this.defaultValueArray = defaultValueList.ToArray();
			bool flag6 = paramInfos.Length != 0 && paramInfos[paramInfos.Length - 1].IsDefined(typeof(ParamArrayAttribute), false);
			if (flag6)
			{
				this.paramsType = paramInfos[paramInfos.Length - 1].ParameterType.GetElementType();
			}
			this.args = new object[paramInfos.Length];
			bool flag7 = this.method is MethodInfo;
			if (flag7)
			{
				this.isVoid = ((this.method as MethodInfo).ReturnType == typeof(void));
			}
			else
			{
				bool flag8 = this.method is ConstructorInfo;
				if (flag8)
				{
					this.isVoid = false;
				}
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00057A38 File Offset: 0x00055C38
		public bool Check(IntPtr L)
		{
			int luaTop = Lua.lua_gettop(L);
			int luaStackPos = this.luaStackPosStart;
			int i = 0;
			while (i < this.checkArray.Length)
			{
				bool flag = i == this.checkArray.Length - 1 && this.paramsType != null;
				if (flag)
				{
					break;
				}
				bool flag2 = luaStackPos > luaTop && !this.isOptionalArray[i];
				bool result;
				if (flag2)
				{
					result = false;
				}
				else
				{
					bool flag3 = luaStackPos <= luaTop && !this.checkArray[i](L, luaStackPos);
					if (!flag3)
					{
						bool flag4 = luaStackPos <= luaTop || !this.isOptionalArray[i];
						if (flag4)
						{
							luaStackPos++;
						}
						i++;
						continue;
					}
					result = false;
				}
				return result;
			}
			return (this.paramsType != null) ? (luaStackPos >= luaTop + 1 || this.checkArray[this.checkArray.Length - 1](L, luaStackPos)) : (luaStackPos == luaTop + 1);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00057B3C File Offset: 0x00055D3C
		public int Call(IntPtr L)
		{
			int result;
			try
			{
				bool flag = this.method.IsDefined(typeof(ObsoleteAttribute), true);
				if (flag)
				{
					ObsoleteAttribute info = Attribute.GetCustomAttribute(this.method, typeof(ObsoleteAttribute)) as ObsoleteAttribute;
					Debug.LogWarning(string.Concat(new string[]
					{
						"Obsolete Method [",
						this.method.DeclaringType.ToString(),
						".",
						this.method.Name,
						"]: ",
						info.Message
					}));
				}
				object target = null;
				MethodBase toInvoke = this.method;
				bool flag2 = this.luaStackPosStart > 1;
				if (flag2)
				{
					target = this.translator.FastGetCSObj(L, 1);
					bool flag3 = target is Delegate;
					if (flag3)
					{
						Delegate delegateInvoke = (Delegate)target;
						toInvoke = delegateInvoke.Method;
					}
				}
				int luaTop = Lua.lua_gettop(L);
				int luaStackPos = this.luaStackPosStart;
				for (int i = 0; i < this.castArray.Length; i++)
				{
					bool flag4 = luaStackPos > luaTop;
					if (flag4)
					{
						bool flag5 = this.paramsType != null && i == this.castArray.Length - 1;
						if (flag5)
						{
							this.args[this.inPosArray[i]] = Array.CreateInstance(this.paramsType, 0);
						}
						else
						{
							this.args[this.inPosArray[i]] = this.defaultValueArray[i];
						}
					}
					else
					{
						bool flag6 = this.paramsType != null && i == this.castArray.Length - 1;
						if (flag6)
						{
							this.args[this.inPosArray[i]] = this.translator.GetParams(L, luaStackPos, this.paramsType);
						}
						else
						{
							this.args[this.inPosArray[i]] = this.castArray[i](L, luaStackPos, null);
						}
						luaStackPos++;
					}
				}
				object ret = toInvoke.IsConstructor ? ((ConstructorInfo)this.method).Invoke(this.args) : this.method.Invoke(this.targetNeeded ? target : null, this.args);
				bool flag7 = this.targetNeeded && this.targetType.IsValueType();
				if (flag7)
				{
					this.translator.Update(L, 1, target);
				}
				int nRet = 0;
				bool flag8 = !this.isVoid;
				if (flag8)
				{
					this.translator.PushAny(L, ret);
					nRet++;
				}
				for (int j = 0; j < this.outPosArray.Length; j++)
				{
					bool flag9 = this.refPos[this.outPosArray[j]] != -1;
					if (flag9)
					{
						this.translator.Update(L, this.luaStackPosStart + this.refPos[this.outPosArray[j]], this.args[this.outPosArray[j]]);
					}
					this.translator.PushAny(L, this.args[this.outPosArray[j]]);
					nRet++;
				}
				result = nRet;
			}
			finally
			{
				for (int k = 0; k < this.args.Length; k++)
				{
					this.args[k] = null;
				}
			}
			return result;
		}

		// Token: 0x04000D42 RID: 3394
		private ObjectTranslator translator;

		// Token: 0x04000D43 RID: 3395
		private Type targetType;

		// Token: 0x04000D44 RID: 3396
		private MethodBase method;

		// Token: 0x04000D45 RID: 3397
		private ObjectCheck[] checkArray;

		// Token: 0x04000D46 RID: 3398
		private ObjectCast[] castArray;

		// Token: 0x04000D47 RID: 3399
		private int[] inPosArray;

		// Token: 0x04000D48 RID: 3400
		private int[] outPosArray;

		// Token: 0x04000D49 RID: 3401
		private bool[] isOptionalArray;

		// Token: 0x04000D4A RID: 3402
		private object[] defaultValueArray;

		// Token: 0x04000D4B RID: 3403
		private bool isVoid = true;

		// Token: 0x04000D4C RID: 3404
		private int luaStackPosStart = 1;

		// Token: 0x04000D4D RID: 3405
		private bool targetNeeded = false;

		// Token: 0x04000D4E RID: 3406
		private object[] args;

		// Token: 0x04000D4F RID: 3407
		private int[] refPos;

		// Token: 0x04000D50 RID: 3408
		private Type paramsType = null;
	}
}

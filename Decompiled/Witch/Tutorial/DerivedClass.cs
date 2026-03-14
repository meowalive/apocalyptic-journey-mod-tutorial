using System;
using System.Diagnostics;
using UnityEngine;
using XLua;

namespace Tutorial
{
	// Token: 0x02000129 RID: 297
	[LuaCallCSharp(GenFlag.No)]
	public class DerivedClass : BaseClass
	{
		// Token: 0x0600090D RID: 2317 RVA: 0x000476B4 File Offset: 0x000458B4
		public void DMFunc()
		{
			Debug.Log("Derived Member Func, DMF = " + this.DMF.ToString());
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x000476E0 File Offset: 0x000458E0
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x000476E8 File Offset: 0x000458E8
		public int DMF { get; set; }

		// Token: 0x06000910 RID: 2320 RVA: 0x000476F4 File Offset: 0x000458F4
		public double ComplexFunc(Param1 p1, ref int p2, out string p3, Action luafunc, out Action csfunc)
		{
			Debug.Log(string.Concat(new string[]
			{
				"P1 = {x=",
				p1.x.ToString(),
				",y=",
				p1.y,
				"},p2 = ",
				p2.ToString()
			}));
			luafunc();
			p2 *= p1.x;
			p3 = "hello " + p1.y;
			csfunc = delegate()
			{
				Debug.Log("csharp callback invoked!");
			};
			return 1.23;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000477A0 File Offset: 0x000459A0
		public void TestFunc(int i)
		{
			Debug.Log("TestFunc(int i)");
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000477AE File Offset: 0x000459AE
		public void TestFunc(string i)
		{
			Debug.Log("TestFunc(string i)");
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000477BC File Offset: 0x000459BC
		public static DerivedClass operator +(DerivedClass a, DerivedClass b)
		{
			return new DerivedClass
			{
				DMF = a.DMF + b.DMF
			};
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000477E9 File Offset: 0x000459E9
		public void DefaultValueFunc(int a = 100, string b = "cccc", string c = null)
		{
			Debug.Log(string.Concat(new string[]
			{
				"DefaultValueFunc: a=",
				a.ToString(),
				",b=",
				b,
				",c=",
				c
			}));
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00047828 File Offset: 0x00045A28
		public void VariableParamsFunc(int a, params string[] strs)
		{
			Debug.Log("VariableParamsFunc: a =" + a.ToString());
			foreach (string str in strs)
			{
				Debug.Log("str:" + str);
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00047878 File Offset: 0x00045A78
		public TestEnum EnumTestFunc(TestEnum e)
		{
			Debug.Log("EnumTestFunc: e=" + e.ToString());
			return TestEnum.E2;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000917 RID: 2327 RVA: 0x000478A8 File Offset: 0x00045AA8
		// (remove) Token: 0x06000918 RID: 2328 RVA: 0x000478E0 File Offset: 0x00045AE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action TestEvent;

		// Token: 0x06000919 RID: 2329 RVA: 0x00047915 File Offset: 0x00045B15
		public void CallEvent()
		{
			this.TestEvent();
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00047924 File Offset: 0x00045B24
		public ulong TestLong(long n)
		{
			return (ulong)(n + 1L);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0004793C File Offset: 0x00045B3C
		public ICalc GetCalc()
		{
			return new DerivedClass.InnerCalc();
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00047953 File Offset: 0x00045B53
		public void GenericMethod<T>()
		{
			string str = "GenericMethod<";
			Type typeFromHandle = typeof(T);
			Debug.Log(str + ((typeFromHandle != null) ? typeFromHandle.ToString() : null) + ">");
		}

		// Token: 0x04000C34 RID: 3124
		public Action<string> TestDelegate = delegate(string param)
		{
			Debug.Log("TestDelegate in c#:" + param);
		};

		// Token: 0x0200012A RID: 298
		[LuaCallCSharp(GenFlag.No)]
		public enum TestEnumInner
		{
			// Token: 0x04000C37 RID: 3127
			E3,
			// Token: 0x04000C38 RID: 3128
			E4
		}

		// Token: 0x0200012B RID: 299
		private class InnerCalc : ICalc
		{
			// Token: 0x0600091E RID: 2334 RVA: 0x000479B0 File Offset: 0x00045BB0
			public int add(int a, int b)
			{
				return a + b;
			}

			// Token: 0x04000C39 RID: 3129
			public int id = 100;
		}
	}
}

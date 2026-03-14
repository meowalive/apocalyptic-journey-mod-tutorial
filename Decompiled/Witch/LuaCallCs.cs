using System;
using UnityEngine;
using XLua;

// Token: 0x02000119 RID: 281
public class LuaCallCs : MonoBehaviour
{
	// Token: 0x060008DF RID: 2271 RVA: 0x00046F75 File Offset: 0x00045175
	private void Start()
	{
		this.luaenv = new LuaEnv();
		this.luaenv.DoString(this.script, "chunk", null);
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00046F9C File Offset: 0x0004519C
	private void Update()
	{
		bool flag = this.luaenv != null;
		if (flag)
		{
			this.luaenv.Tick();
		}
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00046FC5 File Offset: 0x000451C5
	private void OnDestroy()
	{
		this.luaenv.Dispose();
	}

	// Token: 0x04000C1C RID: 3100
	private LuaEnv luaenv = null;

	// Token: 0x04000C1D RID: 3101
	private string script = "\r\n        function demo()\r\n            --new C#对象\r\n            local newGameObj = CS.UnityEngine.GameObject()\r\n            local newGameObj2 = CS.UnityEngine.GameObject('helloworld')\r\n            print(newGameObj, newGameObj2)\r\n        \r\n            --访问静态属性，方法\r\n            local GameObject = CS.UnityEngine.GameObject\r\n            print('UnityEngine.Time.deltaTime:', CS.UnityEngine.Time.deltaTime) --读静态属性\r\n            CS.UnityEngine.Time.timeScale = 0.5 --写静态属性\r\n            print('helloworld', GameObject.Find('helloworld')) --静态方法调用\r\n\r\n            --访问成员属性，方法\r\n            local DerivedClass = CS.Tutorial.DerivedClass\r\n            local testobj = DerivedClass()\r\n            testobj.DMF = 1024--设置成员属性\r\n            print(testobj.DMF)--读取成员属性\r\n            testobj:DMFunc()--成员方法\r\n\r\n            --基类属性，方法\r\n            print(DerivedClass.BSF)--读基类静态属性\r\n            DerivedClass.BSF = 2048--写基类静态属性\r\n            DerivedClass.BSFunc();--基类静态方法\r\n            print(testobj.BMF)--读基类成员属性\r\n            testobj.BMF = 4096--写基类成员属性\r\n            testobj:BMFunc()--基类方法调用\r\n\r\n            --复杂方法调用\r\n            local ret, p2, p3, csfunc = testobj:ComplexFunc({x=3, y = 'john'}, 100, function()\r\n               print('i am lua callback')\r\n            end)\r\n            print('ComplexFunc ret:', ret, p2, p3, csfunc)\r\n            csfunc()\r\n\r\n            --重载方法调用\r\n            testobj:TestFunc(100)\r\n            testobj:TestFunc('hello')\r\n\r\n            --操作符\r\n            local testobj2 = DerivedClass()\r\n            testobj2.DMF = 2048\r\n            print('(testobj + testobj2).DMF = ', (testobj + testobj2).DMF)\r\n\r\n            --默认值\r\n            testobj:DefaultValueFunc(1)\r\n            testobj:DefaultValueFunc(3, 'hello', 'john')\r\n\r\n            --可变参数\r\n            testobj:VariableParamsFunc(5, 'hello', 'john')\r\n\r\n            --Extension methods\r\n            print(testobj:GetSomeData()) \r\n            print(testobj:GetSomeBaseData()) --访问基类的Extension methods\r\n            testobj:GenericMethodOfString()  --通过Extension methods实现访问泛化方法\r\n\r\n            --枚举类型\r\n            local e = testobj:EnumTestFunc(CS.Tutorial.TestEnum.E1)\r\n            print(e, e == CS.Tutorial.TestEnum.E2)\r\n            print(CS.Tutorial.TestEnum.__CastFrom(1), CS.Tutorial.TestEnum.__CastFrom('E1'))\r\n            print(CS.Tutorial.DerivedClass.TestEnumInner.E3)\r\n            assert(CS.Tutorial.BaseClass.TestEnumInner == nil)\r\n\r\n            --Delegate\r\n            testobj.TestDelegate('hello') --直接调用\r\n            local function lua_delegate(str)\r\n                print('TestDelegate in lua:', str)\r\n            end\r\n            testobj.TestDelegate = lua_delegate + testobj.TestDelegate --combine，这里演示的是C#delegate作为右值，左值也支持\r\n            testobj.TestDelegate('hello')\r\n            testobj.TestDelegate = testobj.TestDelegate - lua_delegate --remove\r\n            testobj.TestDelegate('hello')\r\n\r\n            --事件\r\n            local function lua_event_callback1() print('lua_event_callback1') end\r\n            local function lua_event_callback2() print('lua_event_callback2') end\r\n            testobj:TestEvent('+', lua_event_callback1)\r\n            testobj:CallEvent()\r\n            testobj:TestEvent('+', lua_event_callback2)\r\n            testobj:CallEvent()\r\n            testobj:TestEvent('-', lua_event_callback1)\r\n            testobj:CallEvent()\r\n            testobj:TestEvent('-', lua_event_callback2)\r\n\r\n            --64位支持\r\n            local l = testobj:TestLong(11)\r\n            print(type(l), l, l + 100, 10000 + l)\r\n\r\n            --typeof\r\n            newGameObj:AddComponent(typeof(CS.UnityEngine.ParticleSystem))\r\n\r\n            --cast\r\n            local calc = testobj:GetCalc()\r\n            print('assess instance of InnerCalc via reflection', calc:add(1, 2))\r\n            assert(calc.id == 100)\r\n            cast(calc, typeof(CS.Tutorial.ICalc))\r\n            print('cast to interface ICalc', calc:add(1, 2))\r\n            assert(calc.id == nil)\r\n       end\r\n\r\n       demo()\r\n\r\n       --协程下使用\r\n       local co = coroutine.create(function()\r\n           print('------------------------------------------------------')\r\n           demo()\r\n       end)\r\n       assert(coroutine.resume(co))\r\n    ";
}

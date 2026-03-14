using System;
using System.Collections;
using System.Collections.Generic;
using Tutorial;
using UnityEngine;
using Witch.Mod;

namespace XLua.CSObjectWrap
{
	// Token: 0x020001BF RID: 447
	public class XLua_Gen_Initer_Register__
	{
		// Token: 0x06000FC9 RID: 4041 RVA: 0x000830F4 File Offset: 0x000812F4
		private static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
		{
			translator.DelayWrapLoader(typeof(ModConfig), new Action<IntPtr>(ModConfigWrap.__Register));
			translator.DelayWrapLoader(typeof(ScriptExecutor), new Action<IntPtr>(ScriptExecutorWrap.__Register));
			translator.DelayWrapLoader(typeof(StatusManager), new Action<IntPtr>(StatusManagerWrap.__Register));
			translator.DelayWrapLoader(typeof(object), new Action<IntPtr>(SystemObjectWrap.__Register));
			translator.DelayWrapLoader(typeof(UnityEngine.Object), new Action<IntPtr>(UnityEngineObjectWrap.__Register));
			translator.DelayWrapLoader(typeof(Vector2), new Action<IntPtr>(UnityEngineVector2Wrap.__Register));
			translator.DelayWrapLoader(typeof(Vector3), new Action<IntPtr>(UnityEngineVector3Wrap.__Register));
			translator.DelayWrapLoader(typeof(Vector4), new Action<IntPtr>(UnityEngineVector4Wrap.__Register));
			translator.DelayWrapLoader(typeof(Quaternion), new Action<IntPtr>(UnityEngineQuaternionWrap.__Register));
			translator.DelayWrapLoader(typeof(Color), new Action<IntPtr>(UnityEngineColorWrap.__Register));
			translator.DelayWrapLoader(typeof(GameObject), new Action<IntPtr>(UnityEngineGameObjectWrap.__Register));
			translator.DelayWrapLoader(typeof(StringValue), new Action<IntPtr>(StringValueWrap.__Register));
			translator.DelayWrapLoader(typeof(Component), new Action<IntPtr>(UnityEngineComponentWrap.__Register));
			translator.DelayWrapLoader(typeof(Behaviour), new Action<IntPtr>(UnityEngineBehaviourWrap.__Register));
			translator.DelayWrapLoader(typeof(Transform), new Action<IntPtr>(UnityEngineTransformWrap.__Register));
			translator.DelayWrapLoader(typeof(MonoBehaviour), new Action<IntPtr>(UnityEngineMonoBehaviourWrap.__Register));
			translator.DelayWrapLoader(typeof(Mathf), new Action<IntPtr>(UnityEngineMathfWrap.__Register));
			translator.DelayWrapLoader(typeof(List<int>), new Action<IntPtr>(SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register));
			translator.DelayWrapLoader(typeof(Dictionary<string, string>), new Action<IntPtr>(SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap.__Register));
			translator.DelayWrapLoader(typeof(Debug), new Action<IntPtr>(UnityEngineDebugWrap.__Register));
			translator.DelayWrapLoader(typeof(BaseClass), new Action<IntPtr>(TutorialBaseClassWrap.__Register));
			translator.DelayWrapLoader(typeof(TestEnum), new Action<IntPtr>(TutorialTestEnumWrap.__Register));
			translator.DelayWrapLoader(typeof(DerivedClass), new Action<IntPtr>(TutorialDerivedClassWrap.__Register));
			translator.DelayWrapLoader(typeof(DerivedClass.TestEnumInner), new Action<IntPtr>(TutorialDerivedClassTestEnumInnerWrap.__Register));
			translator.DelayWrapLoader(typeof(ICalc), new Action<IntPtr>(TutorialICalcWrap.__Register));
			translator.DelayWrapLoader(typeof(DerivedClassExtensions), new Action<IntPtr>(TutorialDerivedClassExtensionsWrap.__Register));
			translator.DelayWrapLoader(typeof(LuaModHookAdapter), new Action<IntPtr>(WitchModLuaModHookAdapterWrap.__Register));
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00083414 File Offset: 0x00081614
		private static void Init(LuaEnv luaenv, ObjectTranslator translator)
		{
			XLua_Gen_Initer_Register__.wrapInit0(luaenv, translator);
			translator.AddInterfaceBridgeCreator(typeof(IEnumerator), new Func<int, LuaEnv, LuaBase>(SystemCollectionsIEnumeratorBridge.__Create));
			translator.AddInterfaceBridgeCreator(typeof(CSCallLua.ItfD), new Func<int, LuaEnv, LuaBase>(TutorialCSCallLuaItfDBridge.__Create));
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00083464 File Offset: 0x00081664
		static XLua_Gen_Initer_Register__()
		{
			LuaEnv.AddIniter(new Action<LuaEnv, ObjectTranslator>(XLua_Gen_Initer_Register__.Init));
		}
	}
}

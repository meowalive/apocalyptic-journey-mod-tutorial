---@meta

---@meta CSharp

---@class NotExportType @表明该类型未导出

---@class NotExportEnum @表明该枚举未导出

---@class CS
CS = {}

---@param obj any
---@return System.Type
function typeof(obj) end

---@class BugReporter
BugReporter = {}
---@alias CS.BugReporter BugReporter
CS.BugReporter = {}

---@class Component.UI.Animation
Component.UI.Animation = {}
---@alias CS.Component.UI.Animation Component.UI.Animation
CS.Component.UI.Animation = {}

---@class Data.Save
Data.Save = {}
---@alias CS.Data.Save Data.Save
CS.Data.Save = {}

---@class DataEditor.CardEditor
DataEditor.CardEditor = {}
---@alias CS.DataEditor.CardEditor DataEditor.CardEditor
CS.DataEditor.CardEditor = {}

---@class Fight.ActionCommand
Fight.ActionCommand = {}
---@alias CS.Fight.ActionCommand Fight.ActionCommand
CS.Fight.ActionCommand = {}

---@class Fight.ObjTarget
Fight.ObjTarget = {}
---@alias CS.Fight.ObjTarget Fight.ObjTarget
CS.Fight.ObjTarget = {}

---@class Fight.StatusCommand
Fight.StatusCommand = {}
---@alias CS.Fight.StatusCommand Fight.StatusCommand
CS.Fight.StatusCommand = {}

---@class Microsoft.CodeAnalysis
Microsoft.CodeAnalysis = {}
---@alias CS.Microsoft.CodeAnalysis Microsoft.CodeAnalysis
CS.Microsoft.CodeAnalysis = {}

---@class Microsoft.CodeAnalysis.Scripting
Microsoft.CodeAnalysis.Scripting = {}
---@alias CS.Microsoft.CodeAnalysis.Scripting Microsoft.CodeAnalysis.Scripting
CS.Microsoft.CodeAnalysis.Scripting = {}

---@class Network.Command
Network.Command = {}
---@alias CS.Network.Command Network.Command
CS.Network.Command = {}

---@class Network.Query
Network.Query = {}
---@alias CS.Network.Query Network.Query
CS.Network.Query = {}

---@class System.Runtime.CompilerServices
System.Runtime.CompilerServices = {}
---@alias CS.System.Runtime.CompilerServices System.Runtime.CompilerServices
CS.System.Runtime.CompilerServices = {}

---@class Tutorial
Tutorial = {}
---@alias CS.Tutorial Tutorial
CS.Tutorial = {}

---@class UI.ScreenEffect
UI.ScreenEffect = {}
---@alias CS.UI.ScreenEffect UI.ScreenEffect
CS.UI.ScreenEffect = {}

---@class UnityEngine.InputSystem
UnityEngine.InputSystem = {}
---@alias CS.UnityEngine.InputSystem UnityEngine.InputSystem
CS.UnityEngine.InputSystem = {}

---@class UnityEngine.UI
UnityEngine.UI = {}
---@alias CS.UnityEngine.UI UnityEngine.UI
CS.UnityEngine.UI = {}

---@class Witch
Witch = {}
---@alias CS.Witch Witch
CS.Witch = {}

---@class Witch.Core
Witch.Core = {}
---@alias CS.Witch.Core Witch.Core
CS.Witch.Core = {}

---@class Witch.Core.Event
Witch.Core.Event = {}
---@alias CS.Witch.Core.Event Witch.Core.Event
CS.Witch.Core.Event = {}

---@class Witch.Mod
Witch.Mod = {}
---@alias CS.Witch.Mod Witch.Mod
CS.Witch.Mod = {}

---@class Witch.UI
Witch.UI = {}
---@alias CS.Witch.UI Witch.UI
CS.Witch.UI = {}

---@class Witch.UI.Component
Witch.UI.Component = {}
---@alias CS.Witch.UI.Component Witch.UI.Component
CS.Witch.UI.Component = {}

---@class Witch.UI.Window
Witch.UI.Window = {}
---@alias CS.Witch.UI.Window Witch.UI.Window
CS.Witch.UI.Window = {}

---@class XLua
XLua = {}
---@alias CS.XLua XLua
CS.XLua = {}

---@class XLua.Cast
XLua.Cast = {}
---@alias CS.XLua.Cast XLua.Cast
CS.XLua.Cast = {}

---@class XLua.CSObjectWrap
XLua.CSObjectWrap = {}
---@alias CS.XLua.CSObjectWrap XLua.CSObjectWrap
CS.XLua.CSObjectWrap = {}

---@class XLua.LuaDLL
XLua.LuaDLL = {}
---@alias CS.XLua.LuaDLL XLua.LuaDLL
CS.XLua.LuaDLL = {}

---@class XLua.TemplateEngine
XLua.TemplateEngine = {}
---@alias CS.XLua.TemplateEngine XLua.TemplateEngine
CS.XLua.TemplateEngine = {}

---@class Modifiable : Rougamo.MoAttribute
Modifiable = {}
---@alias CS.Modifiable Modifiable
CS.Modifiable = Modifiable

---@return Modifiable
function Modifiable.New() end
---@param context Rougamo.Context.MethodContext
function Modifiable:OnEntry(context) end
---@param context Rougamo.Context.MethodContext
function Modifiable:OnException(context) end
---@param context Rougamo.Context.MethodContext
function Modifiable:OnSuccess(context) end
---@param context Rougamo.Context.MethodContext
function Modifiable:OnExit(context) end

---@class BGMList : UnityEngine.ScriptableObject
---@field list System.Collections.Generic.List
BGMList = {}
---@alias CS.BGMList BGMList
CS.BGMList = BGMList

---@return BGMList
function BGMList.New() end

---@class GifAsset : UnityEngine.ScriptableObject
---@field frames System.Collections.Generic.List
---@field frameDelays System.Collections.Generic.List
---@field gifPath string
---@field FrameCount number
GifAsset = {}
---@alias CS.GifAsset GifAsset
CS.GifAsset = GifAsset

---@return GifAsset
function GifAsset.New() end

---@class GifAssetSerializer : System.Object
GifAssetSerializer = {}
---@alias CS.GifAssetSerializer GifAssetSerializer
CS.GifAssetSerializer = GifAssetSerializer

---@param writer Mirror.NetworkWriter
---@param gifAsset GifAsset
function GifAssetSerializer.Write(writer, gifAsset) end
---@param reader Mirror.NetworkReader
---@return GifAsset
function GifAssetSerializer.Read(reader) end

---@class GifAssetJsonConverter : Newtonsoft.Json.JsonConverter
GifAssetJsonConverter = {}
---@alias CS.GifAssetJsonConverter GifAssetJsonConverter
CS.GifAssetJsonConverter = GifAssetJsonConverter

---@return GifAssetJsonConverter
function GifAssetJsonConverter.New() end
---@param writer Newtonsoft.Json.JsonWriter
---@param value GifAsset
---@param serializer Newtonsoft.Json.JsonSerializer
function GifAssetJsonConverter:WriteJson(writer, value, serializer) end
---@param reader Newtonsoft.Json.JsonReader
---@param objectType System.Type
---@param existingValue GifAsset
---@param hasExistingValue boolean
---@param serializer Newtonsoft.Json.JsonSerializer
---@return GifAsset
function GifAssetJsonConverter:ReadJson(reader, objectType, existingValue, hasExistingValue, serializer) end

---@class Priority_Queue : System.Object
---@field Data System.Collections.Generic.List[T]
Priority_Queue = {}
---@alias CS.Priority_Queue Priority_Queue
CS.Priority_Queue = Priority_Queue

---@param compare System.Func[T,T,System.Int32]
---@return Priority_Queue
function Priority_Queue.New(compare) end
---@param item T
function Priority_Queue:Push(item) end
---@return T
function Priority_Queue:Pop() end
---@return T
function Priority_Queue:Top() end
---@return number
function Priority_Queue:Count() end
---@return boolean
function Priority_Queue:IsEmpty() end

---@class StringValue : System.ValueType
StringValue = {}
---@alias CS.StringValue StringValue
CS.StringValue = StringValue

---@overload fun(v: number) : StringValue
---@overload fun(v: number) : StringValue
---@param s string
---@return StringValue
function StringValue.New(s) end
---@return string
function StringValue:ToString() end
---@return string
function StringValue:GetString() end
---@param out_v number
---@return boolean,number
function StringValue:TryGetInt(out_v) end
---@param out_v number
---@return boolean,number
function StringValue:TryGetFloat(out_v) end
---@param out_v string
---@return boolean,string
function StringValue:TryGetString(out_v) end
---@return number
function StringValue:ToInt() end
---@return number
function StringValue:ToFloat() end

---@class StringValue.ValueType
---@field None StringValue.ValueType
---@field Int StringValue.ValueType
---@field Float StringValue.ValueType
---@field String StringValue.ValueType
StringValue.ValueType = {}
---@alias CS.StringValue.ValueType StringValue.ValueType
CS.StringValue.ValueType = StringValue.ValueType


---@class TextTagData : UnityEngine.ScriptableObject
---@field fontSize string
---@field textColor UnityEngine.Color
---@field isDescrible boolean
TextTagData = {}
---@alias CS.TextTagData TextTagData
CS.TextTagData = TextTagData

---@return TextTagData
function TextTagData.New() end

---@class DataType
---@field Card DataType
---@field Enemy DataType
---@field EnemyCard DataType
---@field KeyWords DataType
---@field EnchTag DataType
---@field Level DataType
---@field Partner DataType
---@field PartnerCard DataType
---@field Map DataType
---@field Item DataType
---@field Buff DataType
---@field Career DataType
---@field Relic DataType
---@field Bless DataType
---@field Food DataType
---@field Coin DataType
---@field IllustraedBook DataType
---@field DesList DataType
---@field BuyItems DataType
---@field Hard DataType
---@field Event DataType
---@field Tutorial DataType
---@field Announcement DataType
---@field Dialogue DataType
---@field DialogueBox DataType
---@field Effect DataType
---@field RoleData DataType
---@field Task DataType
---@field Affection DataType
DataType = {}
---@alias CS.DataType DataType
CS.DataType = DataType


---@class FightType
---@field None FightType
---@field Init FightType
---@field Start FightType
---@field Player FightType
---@field OtherTurn FightType
---@field Partner FightType
---@field Enemy FightType
---@field Win FightType
---@field Loss FightType
FightType = {}
---@alias CS.FightType FightType
CS.FightType = FightType


---@class EventCenter : Singleton
---@field Instance EventCenter -- infered from Singleton`1[EventCenter]
---@field GetInstance EventCenter -- infered from Singleton`1[EventCenter]
EventCenter = {}
---@alias CS.EventCenter EventCenter
CS.EventCenter = EventCenter

---@return EventCenter
function EventCenter.New() end
---@overload fun(self: EventCenter, eventName: string, action: System.Action | function, obj: System.Object, dispose: EventDispose)
---@param eventName string
---@param action System.Action | function
---@param obj System.Object
---@param dispose EventDispose
function EventCenter:AddEventListener(eventName, action, obj, dispose) end
---@param eventName string
---@param obj System.Object
function EventCenter:RemoveEventListener(eventName, obj) end
---@overload fun(self: EventCenter, obj: System.Object)
---@param disposeType EventDispose[]
function EventCenter:Clear(disposeType) end
---@param obj System.Object
---@return System.String[]
function EventCenter:GetAllEvents(obj) end
---@overload fun(self: EventCenter, eventName: string)
---@param eventName string
---@param obj System.Object
function EventCenter:EventTrigger(eventName, obj) end

---@class EventDispose
---@field None EventDispose
---@field OnTrigger EventDispose
---@field OnFightEnd EventDispose
EventDispose = {}
---@alias CS.EventDispose EventDispose
CS.EventDispose = EventDispose


---@class EventType
---@field Attack EventType
---@field RelicAdd EventType
---@field AddEnemy EventType
---@field AttackDone EventType
---@field CostPower EventType
---@field NoPower EventType
---@field AddPower EventType
---@field Dead EventType
---@field ToughCountZero EventType
---@field OnEnemyDead EventType
---@field Resurrection EventType
---@field EndRound EventType
---@field ICreateCardItem EventType
---@field CreateCardItem EventType
---@field EndCreateCardItem EventType
---@field NoPowerWhenTry EventType
---@field Action EventType
---@field BurnCard EventType
---@field Init EventType
---@field UIOpen EventType
---@field UIHelp EventType
---@field UIClose EventType
---@field OnDiceCheck EventType
---@field OnDiceValue EventType
---@field Win EventType
---@field Escape EventType
---@field HouseUIOpen EventType
---@field FirstTalk EventType
---@field StartRound EventType
---@field Shuffle EventType
---@field OnCameraMove EventType
---@field BreaksUIOpen EventType
---@field FightStart EventType
---@field Hurt EventType
---@field Heal EventType
---@field ResolutionChanged EventType
---@field SelectCardEnd EventType
---@field LanguageChange EventType
---@field OnTriggerEffect EventType
---@field ScriptExecute EventType
EventType = {}
---@alias CS.EventType EventType
CS.EventType = EventType


---@class ActionData : System.ValueType
---@field data IDataConfig
---@field Id string
ActionData = {}
---@alias CS.ActionData ActionData
CS.ActionData = ActionData

---@param data IDataConfig
---@param Id string
---@return ActionData
function ActionData.New(data, Id) end

---@class DamageData : System.ValueType
---@field data IDataConfig
DamageData = {}
---@alias CS.DamageData DamageData
CS.DamageData = DamageData

---@param data IDataConfig
---@return DamageData
function DamageData.New(data) end

---@class HurtData : System.ValueType
---@field damageType string
---@field val string
---@field SourceId string
---@field fromDataId string
HurtData = {}
---@alias CS.HurtData HurtData
CS.HurtData = HurtData

---@param DamType string
---@param val string
---@param sourceId string
---@param fromDataId string
---@return HurtData
function HurtData.New(DamType, val, sourceId, fromDataId) end

---@class ISourceData
ISourceData = {}
---@alias CS.ISourceData ISourceData
CS.ISourceData = ISourceData


---@class NewEnemyData : System.ValueType
---@field Id string
NewEnemyData = {}
---@alias CS.NewEnemyData NewEnemyData
CS.NewEnemyData = NewEnemyData

---@param Id string
---@return NewEnemyData
function NewEnemyData.New(Id) end

---@class ScriptExecuteData : System.ValueType
---@field MethodName string
---@field Executor IScriptExecutor
---@field Arguments System.Object[]
ScriptExecuteData = {}
---@alias CS.ScriptExecuteData ScriptExecuteData
CS.ScriptExecuteData = ScriptExecuteData


---@class CustomConverter : System.Object
CustomConverter = {}
---@alias CS.CustomConverter CustomConverter
CS.CustomConverter = CustomConverter

---@overload fun(s: string) : number
---@param s System.Object
---@return number
function CustomConverter.ToInt(s) end

---@class IsNullExtension : System.Object
IsNullExtension = {}
---@alias CS.IsNullExtension IsNullExtension
CS.IsNullExtension = IsNullExtension

---@param obj IStatusManager
---@return boolean
function IsNullExtension.IsNull(obj) end

---@class LocalizeEx : System.Object
LocalizeEx = {}
---@alias CS.LocalizeEx LocalizeEx
CS.LocalizeEx = LocalizeEx

---@param text string
---@param keyword System.Collections.Generic.List
---@return string
function LocalizeEx.Highlight(text, keyword) end
---@overload fun(dataConfig: IDataConfig) : string
---@param text string
---@return string
function LocalizeEx.Description(text) end
---@overload fun(dic: System.Collections.Generic.IDictionary, key: string) : string
---@overload fun(path: string) : UnityEngine.Sprite
---@param text string
---@param type string
---@return string
function LocalizeEx.Localize(text, type) end
---@overload fun(textComponent: TMPro.TMP_Text, localized: System.Func)
---@param button Michsky.MUIP.ButtonManager
---@param localized System.Func
function LocalizeEx.SetLocalizedText(button, localized) end
---@param dic System.Collections.Generic.IDictionary
---@param key string
---@param defaultValue string
---@return string
function LocalizeEx.GetValueOrDefault(dic, key, defaultValue) end

---@class MonoBehaviourEx : System.Object
MonoBehaviourEx = {}
---@alias CS.MonoBehaviourEx MonoBehaviourEx
CS.MonoBehaviourEx = MonoBehaviourEx

---@param mono UnityEngine.MonoBehaviour
---@param eventName string
---@param action System.Action | function
function MonoBehaviourEx.ListenEvent(mono, eventName, action) end
---@param mono UnityEngine.MonoBehaviour
---@param from string
---@return boolean
function MonoBehaviourEx.IsNull(mono, from) end

---@class FightObject : Mirror.NetworkBehaviour
---@field InstanceId string
---@field Type string
---@field Id string
---@field Status IStatusManager
---@field Name string
---@field CurHp number
---@field MaxHp number
---@field BottomDistance number
---@field TopDistance number
---@field AnimatedStateSprites System.Collections.Generic.Dictionary
---@field animationPerFrame number
---@field animationTimeCounter number
---@field AnimationLocation string
---@field AnimationData System.ValueTuple
---@field AnimationConfigs System.Collections.Generic.Dictionary
---@field VocalLocation string
---@field VocalClipsCache System.Collections.Generic.Dictionary
FightObject = {}
---@alias CS.FightObject FightObject
CS.FightObject = FightObject

---@return System.Collections.IEnumerator
function FightObject:DoAction() end
---@param state IStatusManager.AnimatedState
function FightObject:OnAnimatedStateChange(state) end
function FightObject:PlayAnimatedPerFrame() end
---@param sprite UnityEngine.Sprite
---@param replaceImmediate boolean
function FightObject:InitBound(sprite, replaceImmediate) end
function FightObject:EndRound() end
function FightObject:OnDestroy() end
---@return boolean
function FightObject:Weaved() end

---@class GameConfigData : System.Object
---@field dataDic System.Collections.Generic.Dictionary
---@field LockedIds System.Collections.Generic.HashSet
GameConfigData = {}
---@alias CS.GameConfigData GameConfigData
CS.GameConfigData = GameConfigData

---@param table System.Data.DataTable
---@param prefix string
---@return GameConfigData
function GameConfigData.New(table, prefix) end
---@param data1 GameConfigData
---@param data2 GameConfigData
---@return GameConfigData
function GameConfigData.Concat(data1, data2) end
---@return System.Collections.Generic.List
function GameConfigData:Getlines() end
---@param id string
---@return System.Collections.Generic.Dictionary
function GameConfigData:GetOneById(id) end

---@class Globals : System.Object
---@field SavePath string
---@field ModsPath string
---@field VRam number
---@field Language string
---@field VersionMajor number
---@field VersionMinor number
---@field BuildVersion number
---@field VersionString string
---@field DataConfigCache System.Collections.Concurrent.ConcurrentDictionary
---@field GetDataBydId System.Func
---@field MapEnemyPositiveFunc System.Func
Globals = {}
---@alias CS.Globals Globals
CS.Globals = Globals


---@class KeyManager : UnityEngine.MonoBehaviour
---@field playerAction UnityEngine.InputSystem.PlayerAction
KeyManager = {}
---@alias CS.KeyManager KeyManager
CS.KeyManager = KeyManager


---@class mouse : UnityEngine.MonoBehaviour
---@field Texture2D UnityEngine.Texture2D
---@field hotSpot UnityEngine.Vector2
---@field vfx UnityEngine.GameObject
mouse = {}
---@alias CS.mouse mouse
CS.mouse = mouse

function mouse:Start() end

---@class IBuffItem
---@field scriptExecutor IScriptExecutor
---@field transform UnityEngine.Transform
---@field buffConfig IBuffItemConfig
---@field effectList System.Collections.ObjectModel.ObservableCollection
---@field status IStatusManager
IBuffItem = {}
---@alias CS.IBuffItem IBuffItem
CS.IBuffItem = IBuffItem

function IBuffItem:ApplyBuff() end
---@param isacting boolean
function IBuffItem:BuffProcess(isacting) end
function IBuffItem:ClearBuff() end
---@param fromId string
function IBuffItem:ClearDynamicVar(fromId) end
---@param way string
function IBuffItem:DurationCheck(way) end
function IBuffItem:EffectAnimation() end
function IBuffItem:UpdateMsg() end

---@class IBuffItemConfig
---@field Level number
---@field buffItem IBuffItem
---@field status IStatusManager
---@field BuffId string
---@field BuffName string
---@field Description string
---@field dataConfig IDataConfig
---@field Type string
---@field UpperBound number
---@field ReducePerTurn number
---@field ReducePerUse number
---@field ReducePerAttacked number
IBuffItemConfig = {}
---@alias CS.IBuffItemConfig IBuffItemConfig
CS.IBuffItemConfig = IBuffItemConfig

---@param way string
---@return boolean
function IBuffItemConfig:DurationCheck(way) end

---@class IDataConfig
---@field data System.Collections.Generic.IDictionary
---@field Vars System.Collections.Generic.IDictionary
---@field InstanceID string
---@field Type DataType
---@field scriptExecutor IScriptExecutor
---@field isCompiling boolean
IDataConfig = {}
---@alias CS.IDataConfig IDataConfig
CS.IDataConfig = IDataConfig

---@return string
function IDataConfig:Description() end

---@class IEffectManager
IEffectManager = {}
---@alias CS.IEffectManager IEffectManager
CS.IEffectManager = IEffectManager

---@overload fun(self: IEffectManager, scriptExecutor: IScriptExecutor, effectName: string)
---@param Self IStatusManager
---@param effectName string
function IEffectManager:PlayEffect(Self, effectName) end
---@param Self IStatusManager
---@param Object System.Collections.Generic.List
---@param effectName string
function IEffectManager:InternalPlayEffect(Self, Object, effectName) end
---@param scriptExecutor IScriptExecutor
---@param effectName string
---@param delay number
function IEffectManager:PlayActionEffect(scriptExecutor, effectName, delay) end

---@class ILocalize
ILocalize = {}
---@alias CS.ILocalize ILocalize
CS.ILocalize = ILocalize

function ILocalize:DataUpdate() end
function ILocalize:RegisterEvent() end
function ILocalize:ClearEvent() end

---@class LanguageEvent
---@field LanguageChange LanguageEvent
LanguageEvent = {}
---@alias CS.LanguageEvent LanguageEvent
CS.LanguageEvent = LanguageEvent


---@class IRole
---@field Name string
---@field Id string
---@field InstanceId string
---@field AnimatedStateSprites System.Collections.Generic.Dictionary
---@field animationPerFrame number
---@field animationTimeCounter number
---@field AnimationLocation string
---@field AnimationData System.ValueTuple
---@field AnimationConfigs System.Collections.Generic.Dictionary
---@field VocalLocation string
---@field VocalClipsCache System.Collections.Generic.Dictionary
IRole = {}
---@alias CS.IRole IRole
CS.IRole = IRole

---@overload fun(animationLocation: string, state: IStatusManager.AnimatedState) : IRole.AnimationConfig
---@param state IStatusManager.AnimatedState
---@return IRole.AnimationConfig
function IRole:TryGetAnimationConfig(state) end
---@overload fun(vocalLocation: string, state: IStatusManager.VocalState) : UnityEngine.AudioClip[]
---@param state IStatusManager.VocalState
---@return UnityEngine.AudioClip[]
function IRole:TryGetVocalClips(state) end
---@param state IStatusManager.AnimatedState
function IRole:OnAnimatedStateChange(state) end
function IRole:PlayAnimatedPerFrame() end
---@param state IStatusManager.AnimatedState
---@return number
function IRole:GetAnimationPerFrame(state) end
---@param state IStatusManager.AnimatedState
---@return string
function IRole:GetAnimationDirection(state) end
---@param state IStatusManager.AnimatedState
---@return string
function IRole:GetAnimationSize(state) end
---@param state IStatusManager.AnimatedState
---@return number
function IRole:GetAnimationLayer(state) end
---@param state IStatusManager.AnimatedState
---@return boolean
function IRole:IsAnimationLoop(state) end
---@param state IStatusManager.VocalState
---@return UnityEngine.AudioClip
function IRole:TryGetRandomVocalClip(state) end

---@class IRole.AnimationConfig : System.Object
---@field AnimationPerFrame number
---@field Direction string
---@field isLoop boolean
---@field Size string
IRole.AnimationConfig = {}
---@alias CS.IRole.AnimationConfig IRole.AnimationConfig
CS.IRole.AnimationConfig = IRole.AnimationConfig

---@return IRole.AnimationConfig
function IRole.AnimationConfig.New() end

---@class IScriptExecutor
---@field status IStatusManager
---@field CompiledSuccessfully boolean
---@field dataConfig IDataConfig
---@field Vars System.Collections.Generic.IDictionary
---@field Self IStatusManager
---@field Object System.Collections.Generic.List
---@field Target IStatusManager
---@field ScriptDict System.Collections.Generic.Dictionary
IScriptExecutor = {}
---@alias CS.IScriptExecutor IScriptExecutor
CS.IScriptExecutor = IScriptExecutor

---@param scriptName string
function IScriptExecutor:RunScript(scriptName) end
---@param scriptName string
---@param options Microsoft.CodeAnalysis.Scripting.ScriptOptions
function IScriptExecutor:PreCompileScripts(scriptName, options) end
---@overload fun(self: IScriptExecutor, filter: string) : System.Collections.Generic.List
---@overload fun(self: IScriptExecutor, statuses: System.Collections.Generic.IEnumerable) : System.Collections.Generic.List
---@param statuses ZLinq.ValueEnumerable
---@return System.Collections.Generic.List
function IScriptExecutor:SetStatus(statuses) end
---@param eventName string
---@param parameters System.String[]
---@return boolean
function IScriptExecutor:TrySendOnlineEvent(eventName, parameters) end
---@param eventName string
---@param action System.Action | function
function IScriptExecutor:AddEvent(eventName, action) end
function IScriptExecutor:Clear() end

---@class ISingleton
---@field Instance T
---@field GetInstance T
ISingleton = {}
---@alias CS.ISingleton ISingleton
CS.ISingleton = ISingleton


---@class IStatusCommand
---@field From string
IStatusCommand = {}
---@alias CS.IStatusCommand IStatusCommand
CS.IStatusCommand = IStatusCommand

function IStatusCommand:Execute() end

---@class IStatusManager
---@field fatherObject FightObject
---@field animatedState IStatusManager.AnimatedState
---@field state IStatusManager.State
---@field Name string
---@field InstanceId string
---@field MirrorSc IScriptExecutor
---@field MaxHp number
---@field ToughCount number
---@field CurHp number
---@field Defend number
---@field dynamicVariables System.Collections.Generic.Dictionary
---@field dynamicVariablesLog System.Collections.Generic.Dictionary
---@field ToughOrigin number
---@field effectList System.Collections.Generic.List
---@field transform UnityEngine.Transform
---@field actionObj UnityEngine.GameObject[]
---@field DamageFilter System.Collections.Generic.Dictionary
IStatusManager = {}
---@alias CS.IStatusManager IStatusManager
CS.IStatusManager = IStatusManager

---@overload fun(self: IStatusManager, buffId: string, level: number) : IStatusManager
---@param buffConfig IBuffItemConfig
---@return IStatusManager
function IStatusManager:AddBuff(buffConfig) end
---@param state IStatusManager.State
function IStatusManager:ChangeState(state) end
---@param way string
---@return IStatusManager
function IStatusManager:CheckAllBuff(way) end
---@return IStatusManager
function IStatusManager:UpdateBuff() end
function IStatusManager:CheckDead() end
---@return IStatusManager
function IStatusManager:ClearAllBuff() end
---@param BaseDamage number
---@return number
function IStatusManager:DamageCalculate(BaseDamage) end
---@param BaseDefence number
---@return number
function IStatusManager:DefenceCalculate(BaseDefence) end
---@param Delay number
function IStatusManager:EnemyDead(Delay) end
---@param buffId string
---@return IBuffItem
function IStatusManager:GetBuff(buffId) end
---@return IBuffItem[]
function IStatusManager:GetBuffs() end
---@param val number
---@param damageType string
function IStatusManager:Heal(val, damageType) end
---@param val number
---@param damageType string
---@param fromDataId string
---@param fromInstanceId string
function IStatusManager:Hit(val, damageType, fromDataId, fromInstanceId) end
---@param father FightObject
---@return IStatusManager
function IStatusManager:Init(father) end
---@param replaceImmediate boolean
---@return UnityEngine.Sprite
function IStatusManager:InitAnimator(replaceImmediate) end
function IStatusManager:InitVocal() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function IStatusManager:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function IStatusManager:OnPointerExit(eventData) end
function IStatusManager:OnSelect() end
function IStatusManager:OnUnSelect() end
---@param buffId string
---@return IStatusManager
function IStatusManager:RemoveBuff(buffId) end
---@param replaceImmediate boolean
function IStatusManager:ResetAnimator(replaceImmediate) end
function IStatusManager:ResetVocal() end
function IStatusManager:ResetDamageStatus() end
---@param value number
function IStatusManager:Resurrection(value) end
---@param pos UnityEngine.Vector3
function IStatusManager:SetPosition(pos) end
---@param sprite UnityEngine.Sprite
function IStatusManager:SetSprite(sprite) end
---@param BaseDamage number
---@return number
function IStatusManager:UnDamageCalucate(BaseDamage) end
function IStatusManager:UpdateDisplay() end
function IStatusManager:UpdateEffectList() end
---@param NeedEffect boolean
function IStatusManager:UpdateStatus(NeedEffect) end
---@param state IStatusManager.VocalState
function IStatusManager:PlayVocal(state) end
function IStatusManager:UpdateTough() end
---@param path string
---@param name string
function IStatusManager:AddSummon(path, name) end
---@param name string
function IStatusManager:RemoveSummon(name) end
---@return boolean
function IStatusManager:IsNull() end

---@class IStatusManager.State
---@field Default IStatusManager.State
---@field NoAction IStatusManager.State
---@field Dead IStatusManager.State
IStatusManager.State = {}
---@alias CS.IStatusManager.State IStatusManager.State
CS.IStatusManager.State = IStatusManager.State


---@class IStatusManager.AnimatedState
---@field Idle IStatusManager.AnimatedState
---@field Attack IStatusManager.AnimatedState
---@field Hit IStatusManager.AnimatedState
---@field Buff IStatusManager.AnimatedState
---@field Debuff IStatusManager.AnimatedState
---@field Skill IStatusManager.AnimatedState
---@field Special IStatusManager.AnimatedState
---@field Special1 IStatusManager.AnimatedState
---@field Special2 IStatusManager.AnimatedState
IStatusManager.AnimatedState = {}
---@alias CS.IStatusManager.AnimatedState IStatusManager.AnimatedState
CS.IStatusManager.AnimatedState = IStatusManager.AnimatedState


---@class IStatusManager.VocalState
---@field FightStart IStatusManager.VocalState
---@field Focus IStatusManager.VocalState
---@field Skill IStatusManager.VocalState
---@field Defend IStatusManager.VocalState
---@field Hurt IStatusManager.VocalState
---@field Dying IStatusManager.VocalState
---@field Dead IStatusManager.VocalState
---@field Bored IStatusManager.VocalState
---@field Kill IStatusManager.VocalState
---@field Win IStatusManager.VocalState
---@field Chat IStatusManager.VocalState
---@field AffectionUp IStatusManager.VocalState
IStatusManager.VocalState = {}
---@alias CS.IStatusManager.VocalState IStatusManager.VocalState
CS.IStatusManager.VocalState = IStatusManager.VocalState


---@class ForEachObject : System.ValueType
ForEachObject = {}
---@alias CS.ForEachObject ForEachObject
CS.ForEachObject = ForEachObject

---@param context Rougamo.Context.MethodContext
function ForEachObject:OnEntry(context) end
---@param context Rougamo.Context.MethodContext
function ForEachObject:OnSuccess(context) end
---@param context Rougamo.Context.MethodContext
function ForEachObject:OnException(context) end
---@param context Rougamo.Context.MethodContext
function ForEachObject:OnExit(context) end
---@param context Rougamo.Context.MethodContext
---@return System.Threading.Tasks.ValueTask
function ForEachObject:OnEntryAsync(context) end
---@param context Rougamo.Context.MethodContext
---@return System.Threading.Tasks.ValueTask
function ForEachObject:OnSuccessAsync(context) end
---@param context Rougamo.Context.MethodContext
---@return System.Threading.Tasks.ValueTask
function ForEachObject:OnExceptionAsync(context) end
---@param context Rougamo.Context.MethodContext
---@return System.Threading.Tasks.ValueTask
function ForEachObject:OnExitAsync(context) end

---@class ForEachObjectNative : System.ValueType
ForEachObjectNative = {}
---@alias CS.ForEachObjectNative ForEachObjectNative
CS.ForEachObjectNative = ForEachObjectNative

---@param context Rougamo.Context.MethodContext
function ForEachObjectNative:OnEntry(context) end
---@param context Rougamo.Context.MethodContext
function ForEachObjectNative:OnSuccess(context) end
---@param context Rougamo.Context.MethodContext
function ForEachObjectNative:OnException(context) end
---@param context Rougamo.Context.MethodContext
function ForEachObjectNative:OnExit(context) end
---@param context Rougamo.Context.MethodContext
---@return System.Threading.Tasks.ValueTask
function ForEachObjectNative:OnEntryAsync(context) end
---@param context Rougamo.Context.MethodContext
---@return System.Threading.Tasks.ValueTask
function ForEachObjectNative:OnSuccessAsync(context) end
---@param context Rougamo.Context.MethodContext
---@return System.Threading.Tasks.ValueTask
function ForEachObjectNative:OnExceptionAsync(context) end
---@param context Rougamo.Context.MethodContext
---@return System.Threading.Tasks.ValueTask
function ForEachObjectNative:OnExitAsync(context) end

---@class AAReleaseSetting : UnityEngine.ScriptableObject
AAReleaseSetting = {}
---@alias CS.AAReleaseSetting AAReleaseSetting
CS.AAReleaseSetting = AAReleaseSetting

---@return AAReleaseSetting
function AAReleaseSetting.New() end
function AAReleaseSetting.ClearPathMapper() end
---@param groupName string
---@param path string
function AAReleaseSetting.TryCombinePrefix(groupName, path) end
---@param groupName string
---@return ResourceLoader.AALoadPolicy
function AAReleaseSetting.GetPolicy(groupName) end
---@param path string
---@return string
function AAReleaseSetting.GetGroupNameByPath(path) end

---@class AAReleaseSetting.GroupReleaseSettingEditor : System.ValueType
---@field Group UnityEditor.AddressableAssets.Settings.AddressableAssetGroup
---@field LoadPolicy ResourceLoader.AALoadPolicy
AAReleaseSetting.GroupReleaseSettingEditor = {}
---@alias CS.AAReleaseSetting.GroupReleaseSettingEditor AAReleaseSetting.GroupReleaseSettingEditor
CS.AAReleaseSetting.GroupReleaseSettingEditor = AAReleaseSetting.GroupReleaseSettingEditor


---@class AAReleaseSetting.GroupReleaseSetting : System.ValueType
---@field GroupName string
---@field LoadPolicy ResourceLoader.AALoadPolicy
AAReleaseSetting.GroupReleaseSetting = {}
---@alias CS.AAReleaseSetting.GroupReleaseSetting AAReleaseSetting.GroupReleaseSetting
CS.AAReleaseSetting.GroupReleaseSetting = AAReleaseSetting.GroupReleaseSetting


---@class AddressableReference : System.ValueType
---@field Asset T
AddressableReference = {}
---@alias CS.AddressableReference AddressableReference
CS.AddressableReference = AddressableReference

---@param asset T
---@return AddressableReference
function AddressableReference.New(asset) end
function AddressableReference:OnBeforeSerialize() end
function AddressableReference:OnAfterDeserialize() end

---@class ExcelTableReader : Singleton
---@field Instance ExcelTableReader -- infered from Singleton`1[ExcelTableReader]
---@field GetInstance ExcelTableReader -- infered from Singleton`1[ExcelTableReader]
ExcelTableReader = {}
---@alias CS.ExcelTableReader ExcelTableReader
CS.ExcelTableReader = ExcelTableReader

---@return ExcelTableReader
function ExcelTableReader.New() end
---@param path string
---@return GameConfigData
function ExcelTableReader:ReadByFolder(path) end
---@param path string
---@return System.Data.DataTable
function ExcelTableReader:ReadExcel(path) end
---@param path string
---@return System.Data.DataTable
function ExcelTableReader:ReadCsvWindows(path) end

---@class ResourceLoader : System.Object
ResourceLoader = {}
---@alias CS.ResourceLoader ResourceLoader
CS.ResourceLoader = ResourceLoader

---@param originalPath string
---@param newPath string
function ResourceLoader.RedirectPath(originalPath, newPath) end
---@param path string
---@param needAa boolean
---@return boolean
function ResourceLoader.Exists(path, needAa) end
---@param path string
---@return UnityEngine.Object
function ResourceLoader.Load(path) end
---@param path string
---@param token System.Threading.CancellationToken
---@return Cysharp.Threading.Tasks.UniTask
function ResourceLoader.LoadAsync(path, token) end
function ResourceLoader.ReleaseAllCachedAAHandles() end
function ResourceLoader.ResetForTests() end

---@class ResourceLoader.AALoadPolicy
---@field AlwaysResident ResourceLoader.AALoadPolicy
---@field Temporary ResourceLoader.AALoadPolicy
ResourceLoader.AALoadPolicy = {}
---@alias CS.ResourceLoader.AALoadPolicy ResourceLoader.AALoadPolicy
CS.ResourceLoader.AALoadPolicy = ResourceLoader.AALoadPolicy


---@class Singleton : System.Object
---@field Instance T
---@field GetInstance T
Singleton = {}
---@alias CS.Singleton Singleton
CS.Singleton = Singleton


---@class SingletonResolver : System.Object
SingletonResolver = {}
---@alias CS.SingletonResolver SingletonResolver
CS.SingletonResolver = SingletonResolver


---@class SteamManager : UnityEngine.MonoBehaviour
---@field Initialized boolean
SteamManager = {}
---@alias CS.SteamManager SteamManager
CS.SteamManager = SteamManager


---@class DeepCopyUtility : System.Object
DeepCopyUtility = {}
---@alias CS.DeepCopyUtility DeepCopyUtility
CS.DeepCopyUtility = DeepCopyUtility


---@class ExprInterpreter : System.Object
---@field Vars System.Collections.Generic.IDictionary
ExprInterpreter = {}
---@alias CS.ExprInterpreter ExprInterpreter
CS.ExprInterpreter = ExprInterpreter

---@return ExprInterpreter
function ExprInterpreter.New() end
---@param expr string
---@return string
function ExprInterpreter:Evaluate(expr) end

---@class ExprInterpreter.TokenType
---@field Number ExprInterpreter.TokenType
---@field Variable ExprInterpreter.TokenType
---@field Operator ExprInterpreter.TokenType
---@field LeftParen ExprInterpreter.TokenType
---@field RightParen ExprInterpreter.TokenType
ExprInterpreter.TokenType = {}
---@alias CS.ExprInterpreter.TokenType ExprInterpreter.TokenType
CS.ExprInterpreter.TokenType = ExprInterpreter.TokenType


---@class ExprInterpreter.Token : System.ValueType
---@field Type ExprInterpreter.TokenType
---@field Text string
---@field Number number
---@field Op System.Char
ExprInterpreter.Token = {}
---@alias CS.ExprInterpreter.Token ExprInterpreter.Token
CS.ExprInterpreter.Token = ExprInterpreter.Token


---@class GenericHelper : System.Object
GenericHelper = {}
---@alias CS.GenericHelper GenericHelper
CS.GenericHelper = GenericHelper

---@return GenericHelper
function GenericHelper.New() end
---@param methodBase System.Reflection.MethodBase
---@param target System.Object
---@param arguments System.Object[]
---@return System.Object
function GenericHelper.InvokeGeneric(methodBase, target, arguments) end

---@class GZip : System.Object
GZip = {}
---@alias CS.GZip GZip
CS.GZip = GZip

---@param data System.Byte[]
---@return System.Byte[]
function GZip.Compress(data) end
---@param data System.Byte[]
---@return System.Byte[]
function GZip.Decompress(data) end
---@param data System.Byte[]
---@return string
function GZip.DecompressToString(data) end
---@param str string
---@return System.Byte[]
function GZip.CompressString(str) end

---@class NaturalStringComparer : System.Object
NaturalStringComparer = {}
---@alias CS.NaturalStringComparer NaturalStringComparer
CS.NaturalStringComparer = NaturalStringComparer

---@return NaturalStringComparer
function NaturalStringComparer.New() end
---@param x string
---@param y string
---@return number
function NaturalStringComparer:Compare(x, y) end

---@class PositionUtility : System.Object
PositionUtility = {}
---@alias CS.PositionUtility PositionUtility
CS.PositionUtility = PositionUtility

---@param canvas UnityEngine.RectTransform
---@param screenPoint UnityEngine.Vector2
---@return UnityEngine.Vector2
function PositionUtility.ScreenPointToCanvasPoint(canvas, screenPoint) end
---@param rectTransform UnityEngine.RectTransform
---@param canvas UnityEngine.Canvas
---@return UnityEngine.Vector3
function PositionUtility.CameraSpaceToZeroPlane(rectTransform, canvas) end

---@class TextureTransparencyAnalyzer : System.Object
TextureTransparencyAnalyzer = {}
---@alias CS.TextureTransparencyAnalyzer TextureTransparencyAnalyzer
CS.TextureTransparencyAnalyzer = TextureTransparencyAnalyzer

---@param texture UnityEngine.Texture2D
---@param alphaThreshold number
---@return TextureTransparencyAnalyzer.TransparencyData
function TextureTransparencyAnalyzer.AnalyzeAllEdges(texture, alphaThreshold) end
---@param texture UnityEngine.Texture2D
---@param alphaThreshold number
---@return number
function TextureTransparencyAnalyzer.CalculateBottomTransparentHeight(texture, alphaThreshold) end
---@param texture UnityEngine.Texture2D
---@param pixelsPerUnit number
---@param alphaThreshold number
---@return number
function TextureTransparencyAnalyzer.CalculateBottomTransparentHeightInUnits(texture, pixelsPerUnit, alphaThreshold) end

---@class TextureTransparencyAnalyzer.TransparencyData : System.ValueType
---@field bottomTransparentHeight number
---@field topTransparentHeight number
---@field leftTransparentWidth number
---@field rightTransparentWidth number
TextureTransparencyAnalyzer.TransparencyData = {}
---@alias CS.TextureTransparencyAnalyzer.TransparencyData TextureTransparencyAnalyzer.TransparencyData
CS.TextureTransparencyAnalyzer.TransparencyData = TextureTransparencyAnalyzer.TransparencyData

---@return string
function TextureTransparencyAnalyzer.TransparencyData:ToString() end

---@class TextTranslator : Singleton
---@field Instance TextTranslator -- infered from Singleton`1[TextTranslator]
---@field GetInstance TextTranslator -- infered from Singleton`1[TextTranslator]
TextTranslator = {}
---@alias CS.TextTranslator TextTranslator
CS.TextTranslator = TextTranslator

---@return TextTranslator
function TextTranslator.New() end
---@param keyWords System.Collections.Generic.List
function TextTranslator:Init(keyWords) end
---@param text string
---@param outputArgs System.Collections.Generic.List
---@return string
function TextTranslator:Translate(text, outputArgs) end

---@class AhoCorasick : System.Object
AhoCorasick = {}
---@alias CS.AhoCorasick AhoCorasick
CS.AhoCorasick = AhoCorasick

---@return AhoCorasick
function AhoCorasick.New() end
---@param patterns System.Collections.Generic.IEnumerable
function AhoCorasick:Build(patterns) end
---@param text string
---@return System.Collections.Generic.IEnumerable
function AhoCorasick:Search(text) end
---@param text string
---@return System.Collections.Generic.IEnumerable
function AhoCorasick:SearchLongestPerPosition(text) end

---@class AhoCorasick.TrieNode : System.Object
---@field Children System.Collections.Generic.Dictionary
---@field Fail AhoCorasick.TrieNode
---@field Outputs System.Collections.Generic.List
AhoCorasick.TrieNode = {}
---@alias CS.AhoCorasick.TrieNode AhoCorasick.TrieNode
CS.AhoCorasick.TrieNode = AhoCorasick.TrieNode

---@return AhoCorasick.TrieNode
function AhoCorasick.TrieNode.New() end

---@class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : System.Object
UnitySourceGeneratedAssemblyMonoScriptTypes_v1 = {}
---@alias CS.UnitySourceGeneratedAssemblyMonoScriptTypes_v1 UnitySourceGeneratedAssemblyMonoScriptTypes_v1
CS.UnitySourceGeneratedAssemblyMonoScriptTypes_v1 = UnitySourceGeneratedAssemblyMonoScriptTypes_v1

---@return UnitySourceGeneratedAssemblyMonoScriptTypes_v1
function UnitySourceGeneratedAssemblyMonoScriptTypes_v1.New() end

---@class UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData : System.ValueType
---@field FilePathsData System.Byte[]
---@field TypesData System.Byte[]
---@field TotalTypes number
---@field TotalFiles number
---@field IsEditorOnly boolean
UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData = {}
---@alias CS.UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData
CS.UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData = UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData


---@class UnityEngine.InputSystem.PlayerAction : System.Object
---@field asset UnityEngine.InputSystem.InputActionAsset
---@field bindingMask System.Nullable
---@field devices System.Nullable
---@field controlSchemes UnityEngine.InputSystem.Utilities.ReadOnlyArray
---@field bindings System.Collections.Generic.IEnumerable
---@field Main UnityEngine.InputSystem.PlayerAction.MainActions
---@field Movement UnityEngine.InputSystem.PlayerAction.MovementActions
---@field KeyboardMouseScheme UnityEngine.InputSystem.InputControlScheme
---@field GamepadScheme UnityEngine.InputSystem.InputControlScheme
---@field TouchScheme UnityEngine.InputSystem.InputControlScheme
---@field JoystickScheme UnityEngine.InputSystem.InputControlScheme
---@field XRScheme UnityEngine.InputSystem.InputControlScheme
UnityEngine.InputSystem.PlayerAction = {}
---@alias CS.UnityEngine.InputSystem.PlayerAction UnityEngine.InputSystem.PlayerAction
CS.UnityEngine.InputSystem.PlayerAction = UnityEngine.InputSystem.PlayerAction

---@return UnityEngine.InputSystem.PlayerAction
function UnityEngine.InputSystem.PlayerAction.New() end
function UnityEngine.InputSystem.PlayerAction:Dispose() end
---@param action UnityEngine.InputSystem.InputAction
---@return boolean
function UnityEngine.InputSystem.PlayerAction:Contains(action) end
---@return System.Collections.Generic.IEnumerator
function UnityEngine.InputSystem.PlayerAction:GetEnumerator() end
function UnityEngine.InputSystem.PlayerAction:Enable() end
function UnityEngine.InputSystem.PlayerAction:Disable() end
---@param actionNameOrId string
---@param throwIfNotFound boolean
---@return UnityEngine.InputSystem.InputAction
function UnityEngine.InputSystem.PlayerAction:FindAction(actionNameOrId, throwIfNotFound) end
---@param bindingMask UnityEngine.InputSystem.InputBinding
---@param out_action UnityEngine.InputSystem.InputAction
---@return number,UnityEngine.InputSystem.InputAction
function UnityEngine.InputSystem.PlayerAction:FindBinding(bindingMask, out_action) end

---@class UnityEngine.InputSystem.PlayerAction.MainActions : System.ValueType
---@field Debug UnityEngine.InputSystem.InputAction
---@field Cancel UnityEngine.InputSystem.InputAction
---@field Point UnityEngine.InputSystem.InputAction
---@field RightClick UnityEngine.InputSystem.InputAction
---@field Click UnityEngine.InputSystem.InputAction
---@field ScrollWheel UnityEngine.InputSystem.InputAction
---@field MiddleClick UnityEngine.InputSystem.InputAction
---@field Chat UnityEngine.InputSystem.InputAction
---@field Submit UnityEngine.InputSystem.InputAction
---@field enabled boolean
UnityEngine.InputSystem.PlayerAction.MainActions = {}
---@alias CS.UnityEngine.InputSystem.PlayerAction.MainActions UnityEngine.InputSystem.PlayerAction.MainActions
CS.UnityEngine.InputSystem.PlayerAction.MainActions = UnityEngine.InputSystem.PlayerAction.MainActions

---@param wrapper UnityEngine.InputSystem.PlayerAction
---@return UnityEngine.InputSystem.PlayerAction.MainActions
function UnityEngine.InputSystem.PlayerAction.MainActions.New(wrapper) end
---@return UnityEngine.InputSystem.InputActionMap
function UnityEngine.InputSystem.PlayerAction.MainActions:Get() end
function UnityEngine.InputSystem.PlayerAction.MainActions:Enable() end
function UnityEngine.InputSystem.PlayerAction.MainActions:Disable() end
---@param instance UnityEngine.InputSystem.PlayerAction.IMainActions
function UnityEngine.InputSystem.PlayerAction.MainActions:AddCallbacks(instance) end
---@param instance UnityEngine.InputSystem.PlayerAction.IMainActions
function UnityEngine.InputSystem.PlayerAction.MainActions:RemoveCallbacks(instance) end
---@param instance UnityEngine.InputSystem.PlayerAction.IMainActions
function UnityEngine.InputSystem.PlayerAction.MainActions:SetCallbacks(instance) end

---@class UnityEngine.InputSystem.PlayerAction.MovementActions : System.ValueType
---@field Jump UnityEngine.InputSystem.InputAction
---@field Dash UnityEngine.InputSystem.InputAction
---@field Move UnityEngine.InputSystem.InputAction
---@field enabled boolean
UnityEngine.InputSystem.PlayerAction.MovementActions = {}
---@alias CS.UnityEngine.InputSystem.PlayerAction.MovementActions UnityEngine.InputSystem.PlayerAction.MovementActions
CS.UnityEngine.InputSystem.PlayerAction.MovementActions = UnityEngine.InputSystem.PlayerAction.MovementActions

---@param wrapper UnityEngine.InputSystem.PlayerAction
---@return UnityEngine.InputSystem.PlayerAction.MovementActions
function UnityEngine.InputSystem.PlayerAction.MovementActions.New(wrapper) end
---@return UnityEngine.InputSystem.InputActionMap
function UnityEngine.InputSystem.PlayerAction.MovementActions:Get() end
function UnityEngine.InputSystem.PlayerAction.MovementActions:Enable() end
function UnityEngine.InputSystem.PlayerAction.MovementActions:Disable() end
---@param instance UnityEngine.InputSystem.PlayerAction.IMovementActions
function UnityEngine.InputSystem.PlayerAction.MovementActions:AddCallbacks(instance) end
---@param instance UnityEngine.InputSystem.PlayerAction.IMovementActions
function UnityEngine.InputSystem.PlayerAction.MovementActions:RemoveCallbacks(instance) end
---@param instance UnityEngine.InputSystem.PlayerAction.IMovementActions
function UnityEngine.InputSystem.PlayerAction.MovementActions:SetCallbacks(instance) end

---@class UnityEngine.InputSystem.PlayerAction.IMainActions
UnityEngine.InputSystem.PlayerAction.IMainActions = {}
---@alias CS.UnityEngine.InputSystem.PlayerAction.IMainActions UnityEngine.InputSystem.PlayerAction.IMainActions
CS.UnityEngine.InputSystem.PlayerAction.IMainActions = UnityEngine.InputSystem.PlayerAction.IMainActions

---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnDebug(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnCancel(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnPoint(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnRightClick(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnClick(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnScrollWheel(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnMiddleClick(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnChat(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMainActions:OnSubmit(context) end

---@class UnityEngine.InputSystem.PlayerAction.IMovementActions
UnityEngine.InputSystem.PlayerAction.IMovementActions = {}
---@alias CS.UnityEngine.InputSystem.PlayerAction.IMovementActions UnityEngine.InputSystem.PlayerAction.IMovementActions
CS.UnityEngine.InputSystem.PlayerAction.IMovementActions = UnityEngine.InputSystem.PlayerAction.IMovementActions

---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMovementActions:OnJump(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMovementActions:OnDash(context) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function UnityEngine.InputSystem.PlayerAction.IMovementActions:OnMove(context) end

---@class Witch.Core.ModHookContext : System.Object
---@field Arguments System.Object[]
Witch.Core.ModHookContext = {}
---@alias CS.Witch.Core.ModHookContext Witch.Core.ModHookContext
CS.Witch.Core.ModHookContext = Witch.Core.ModHookContext

---@return Witch.Core.ModHookContext
function Witch.Core.ModHookContext.New() end

---@class Witch.Core.ModHookRegistry : System.Object
Witch.Core.ModHookRegistry = {}
---@alias CS.Witch.Core.ModHookRegistry Witch.Core.ModHookRegistry
CS.Witch.Core.ModHookRegistry = Witch.Core.ModHookRegistry

---@param typeFullName string
---@param methodName string
---@return string
function Witch.Core.ModHookRegistry.Key(typeFullName, methodName) end
---@param key string
---@param callback System.Action | function
function Witch.Core.ModHookRegistry.AddBefore(key, callback) end
---@param key string
---@param callback System.Action | function
function Witch.Core.ModHookRegistry.AddAfter(key, callback) end
---@param key string
---@return System.Collections.Generic.IReadOnlyList
function Witch.Core.ModHookRegistry.GetBefore(key) end
---@param key string
---@return System.Collections.Generic.IReadOnlyList
function Witch.Core.ModHookRegistry.GetAfter(key) end

---@class Witch.Core.ModifiableValue : System.ValueType
---@field Modifier System.Func[T,T]
---@field Value T
Witch.Core.ModifiableValue = {}
---@alias CS.Witch.Core.ModifiableValue Witch.Core.ModifiableValue
CS.Witch.Core.ModifiableValue = Witch.Core.ModifiableValue


---@class Witch.Core.SummonObject : FightObject
---@field fatherObject FightObject
---@field Name string
---@field Type string
---@field Id string
---@field InstanceId string
---@field AnimatedStateSprites System.Collections.Generic.Dictionary
---@field animationPerFrame number
---@field animationTimeCounter number
---@field AnimationLocation string
---@field AnimationData System.ValueTuple
---@field AnimationConfigs System.Collections.Generic.Dictionary
---@field VocalLocation string
---@field VocalClipsCache System.Collections.Generic.Dictionary
Witch.Core.SummonObject = {}
---@alias CS.Witch.Core.SummonObject Witch.Core.SummonObject
CS.Witch.Core.SummonObject = Witch.Core.SummonObject

---@param path string
---@param name string
function Witch.Core.SummonObject:Init(path, name) end
---@return System.Collections.IEnumerator
function Witch.Core.SummonObject:DoAction() end
function Witch.Core.SummonObject:PlayAnimatedPerFrame() end
---@return boolean
function Witch.Core.SummonObject:Weaved() end

---@class Witch.Core.Event.EventBody : System.Object
---@field Action System.Delegate
---@field Dispose EventDispose
---@field isDisposed boolean
Witch.Core.Event.EventBody = {}
---@alias CS.Witch.Core.Event.EventBody Witch.Core.Event.EventBody
CS.Witch.Core.Event.EventBody = Witch.Core.Event.EventBody

---@return Witch.Core.Event.EventBody
function Witch.Core.Event.EventBody.New() end
function Witch.Core.Event.EventBody:Invoke() end

---@class Witch.Core.Event.EventList : System.Object
Witch.Core.Event.EventList = {}
---@alias CS.Witch.Core.Event.EventList Witch.Core.Event.EventList
CS.Witch.Core.Event.EventList = Witch.Core.Event.EventList

---@return Witch.Core.Event.EventList
function Witch.Core.Event.EventList.New() end
---@param action System.Delegate
---@param dispose EventDispose
function Witch.Core.Event.EventList:Add(action, dispose) end
function Witch.Core.Event.EventList:Invoke() end
---@param dispose EventDispose
function Witch.Core.Event.EventList:RemoveBy(dispose) end

---@class Witch.Core.Event.EventInfo : System.Object
---@field Owner System.Object
---@field EventName string
---@field IsExecuting boolean
Witch.Core.Event.EventInfo = {}
---@alias CS.Witch.Core.Event.EventInfo Witch.Core.Event.EventInfo
CS.Witch.Core.Event.EventInfo = Witch.Core.Event.EventInfo

---@param owner System.Object
---@param eventName string
---@param action Witch.Core.Event.EventBody
---@return Witch.Core.Event.EventInfo
function Witch.Core.Event.EventInfo.New(owner, eventName, action) end
function Witch.Core.Event.EventInfo:Execute() end
---@param action System.Delegate
---@param dispose EventDispose
function Witch.Core.Event.EventInfo:AddAction(action, dispose) end
---@param disposeType EventDispose
function Witch.Core.Event.EventInfo:RemoveByDisposeType(disposeType) end

---@class WitchCore_ProcessedByFody : System.Object
WitchCore_ProcessedByFody = {}
---@alias CS.WitchCore_ProcessedByFody WitchCore_ProcessedByFody
CS.WitchCore_ProcessedByFody = WitchCore_ProcessedByFody


---@class Microsoft.CodeAnalysis.EmbeddedAttribute : System.Attribute
Microsoft.CodeAnalysis.EmbeddedAttribute = {}
---@alias CS.Microsoft.CodeAnalysis.EmbeddedAttribute Microsoft.CodeAnalysis.EmbeddedAttribute
CS.Microsoft.CodeAnalysis.EmbeddedAttribute = Microsoft.CodeAnalysis.EmbeddedAttribute

---@return Microsoft.CodeAnalysis.EmbeddedAttribute
function Microsoft.CodeAnalysis.EmbeddedAttribute.New() end

---@class System.Runtime.CompilerServices.NullableAttribute : System.Attribute
---@field NullableFlags System.Byte[]
System.Runtime.CompilerServices.NullableAttribute = {}
---@alias CS.System.Runtime.CompilerServices.NullableAttribute System.Runtime.CompilerServices.NullableAttribute
CS.System.Runtime.CompilerServices.NullableAttribute = System.Runtime.CompilerServices.NullableAttribute

---@overload fun(: number) : System.Runtime.CompilerServices.NullableAttribute
---@param  System.Byte[]
---@return System.Runtime.CompilerServices.NullableAttribute
function System.Runtime.CompilerServices.NullableAttribute.New() end

---@class System.Runtime.CompilerServices.NullableContextAttribute : System.Attribute
---@field Flag number
System.Runtime.CompilerServices.NullableContextAttribute = {}
---@alias CS.System.Runtime.CompilerServices.NullableContextAttribute System.Runtime.CompilerServices.NullableContextAttribute
CS.System.Runtime.CompilerServices.NullableContextAttribute = System.Runtime.CompilerServices.NullableContextAttribute

---@param  number
---@return System.Runtime.CompilerServices.NullableContextAttribute
function System.Runtime.CompilerServices.NullableContextAttribute.New() end

---@class ConditionalShowAttribute : UnityEngine.PropertyAttribute
---@field conditionalSourceField string
---@field compareValue System.Object
ConditionalShowAttribute = {}
---@alias CS.ConditionalShowAttribute ConditionalShowAttribute
CS.ConditionalShowAttribute = ConditionalShowAttribute

---@param conditionalSourceField string
---@param compareValue System.Object
---@return ConditionalShowAttribute
function ConditionalShowAttribute.New(conditionalSourceField, compareValue) end

---@class UnityInjectAttribute : UnityEngine.PropertyAttribute
---@field AutoCreate boolean
UnityInjectAttribute = {}
---@alias CS.UnityInjectAttribute UnityInjectAttribute
CS.UnityInjectAttribute = UnityInjectAttribute

---@param autoCreate boolean
---@return UnityInjectAttribute
function UnityInjectAttribute.New(autoCreate) end

---@class BuffItemConfig : System.Object
---@field Icon string
---@field level number
---@field buffBarUI Witch.UI.Window.BuffBarUI
---@field Level number
---@field UpperBound number
---@field ReducePerTurn number
---@field ReducePerUse number
---@field ReducePerAttacked number
---@field buffItem IBuffItem
---@field status IStatusManager
---@field BuffId string
---@field BuffName string
---@field Description string
---@field Type string
---@field dataConfig IDataConfig
BuffItemConfig = {}
---@alias CS.BuffItemConfig BuffItemConfig
CS.BuffItemConfig = BuffItemConfig

---@overload fun() : BuffItemConfig
---@param dataConfig DataConfig
---@param Status StatusManager
---@param buffBarUI Witch.UI.Window.BuffBarUI
---@return BuffItemConfig
function BuffItemConfig.New(dataConfig, Status, buffBarUI) end
---@param way string
---@return boolean
function BuffItemConfig:DurationCheck(way) end

---@class AttackCardItem : CommonCardItem
---@field isLine boolean
AttackCardItem = {}
---@alias CS.AttackCardItem AttackCardItem
CS.AttackCardItem = AttackCardItem

---@param eventData UnityEngine.EventSystems.PointerEventData
function AttackCardItem:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function AttackCardItem:OnDrag(eventData) end
---@param dataConfig DataConfig
function AttackCardItem:Init(dataConfig) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function AttackCardItem:OnEndDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function AttackCardItem:OnPointerDown(eventData) end
function AttackCardItem:BeginLineMode() end
function AttackCardItem:CancelLineMode() end
function AttackCardItem:CommitOrCancelFromKeyboard() end
function AttackCardItem:DrawEffect() end

---@class CardAnimationController : System.Object
---@field maxAngle number
---@field moveTween DG.Tweening.Tween
---@field scaleTween DG.Tweening.Tween
---@field card ICard
---@field isSelect boolean
CardAnimationController = {}
---@alias CS.CardAnimationController CardAnimationController
CS.CardAnimationController = CardAnimationController

---@return CardAnimationController
function CardAnimationController.New() end
---@param trans UnityEngine.Transform
---@param component ICard
function CardAnimationController:Initialize(trans, component) end
---@param newPosition UnityEngine.Vector2
---@param scale number
function CardAnimationController:PlayEnterAnimation(newPosition, scale) end
---@param initPosition UnityEngine.Vector2
---@param scale number
---@return DG.Tweening.Tween
function CardAnimationController:PlayExitAnimation(initPosition, scale) end
---@return Cysharp.Threading.Tasks.UniTaskVoid
function CardAnimationController:RotateWithMouse() end
---@return UnityEngine.Vector2
function CardAnimationController:GetMousePos() end
function CardAnimationController:StartRandomRotation() end
function CardAnimationController:enddrag() end
function CardAnimationController:StopRotation() end
function CardAnimationController:StopMove() end

---@class CardContainer : UnityEngine.MonoBehaviour
---@field AFKAnimation boolean
---@field anim UnityEngine.AnimationCurve
---@field cardTweenDict System.Collections.Generic.Dictionary
CardContainer = {}
---@alias CS.CardContainer CardContainer
CS.CardContainer = CardContainer

function CardContainer:ResetTimer() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CardContainer:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CardContainer:OnPointerExit(eventData) end

---@class CardItem : UnityEngine.MonoBehaviour
---@field canUse boolean
---@field UseCount number
---@field cardcontainer CardContainer
---@field hasUse boolean
---@field selectContainer CardContainer
---@field dataConfig DataConfig
---@field data System.Collections.Generic.IDictionary
---@field Vars System.Collections.Generic.IDictionary
---@field status StatusManager
---@field hasDone boolean
---@field _mainThreadContext System.Threading.SynchronizationContext
---@field enchScriptExecutor IScriptExecutor
---@field animationController CardAnimationController
---@field uiElement UnityEngine.RectTransform
---@field initAngle UnityEngine.Vector3
---@field initPosition UnityEngine.Vector2
---@field draging boolean
---@field ignore boolean
---@field initScale number
---@field selectScale number
---@field isReverse boolean
---@field scriptExecutor IScriptExecutor
---@field Tags System.Collections.Generic.HashSet
---@field index number
CardItem = {}
---@alias CS.CardItem CardItem
CS.CardItem = CardItem

---@param ScriptName string
function CardItem:RunScript(ScriptName) end
---@param dataConfig DataConfig
function CardItem:Init(dataConfig) end
---@param Index number
function CardItem:SetIndex(Index) end
function CardItem:DrawEffect() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CardItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CardItem:OnPointerExit(eventData) end
function CardItem:Awake() end
function CardItem:Start() end
function CardItem:ClearEvent() end
function CardItem:RegisterEvent() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CardItem:OnRightClick(eventData) end
function CardItem:DataUpdate() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CardItem:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
---@return UnityEngine.Vector2
function CardItem:GetMousePos(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CardItem:OnDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CardItem:OnEndDrag(eventData) end
---@param animationDelay number
function CardItem:Burning(animationDelay) end
---@param animationDelay number
function CardItem:InternalBurning(animationDelay) end
function CardItem:Reverse() end
function CardItem:EffectOfBurnCard() end
function CardItem:ThrowCard() end
function CardItem:InternalThrow() end
---@param targetPath string
function CardItem:EffectOfThrowCard(targetPath) end

---@class CommonCardItem : CardItem
---@field UseChecker System.Collections.Generic.List
---@field ExUseCount number
---@field UseCallback System.Collections.Generic.List
---@field lasttime number
CommonCardItem = {}
---@alias CS.CommonCardItem CommonCardItem
CS.CommonCardItem = CommonCardItem

---@param eventData UnityEngine.EventSystems.PointerEventData
function CommonCardItem:OnEndDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CommonCardItem:OnBeginDrag(eventData) end
function CommonCardItem:UseCardDirectly() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function CommonCardItem:OnPointerDown(eventData) end
function CommonCardItem:DrawEffect() end

---@class ICard
---@field index number
---@field initPosition UnityEngine.Vector2
---@field initAngle UnityEngine.Vector3
---@field draging boolean
---@field initScale number
---@field selectScale number
---@field isReverse boolean
---@field ignore boolean
ICard = {}
---@alias CS.ICard ICard
CS.ICard = ICard

---@param transform UnityEngine.Transform
---@param dataConfig DataConfig
function ICard.SetCardStyle(transform, dataConfig) end
---@param transform UnityEngine.Transform
---@param dataConfig DataConfig
---@param status StatusManager
function ICard.SetCardMsg(transform, dataConfig, status) end
---@param transform UnityEngine.Transform
---@param dataConfig DataConfig
function ICard.SetPureMsg(transform, dataConfig) end
---@param index number
function ICard:SetIndex(index) end

---@class TriggerFixed : UnityEngine.MonoBehaviour
TriggerFixed = {}
---@alias CS.TriggerFixed TriggerFixed
CS.TriggerFixed = TriggerFixed


---@class EffectSound : UnityEngine.MonoBehaviour
---@field delay number
---@field clip UnityEngine.AudioClip
EffectSound = {}
---@alias CS.EffectSound EffectSound
CS.EffectSound = EffectSound


---@class MusicEffect : UnityEngine.MonoBehaviour
---@field delay number
MusicEffect = {}
---@alias CS.MusicEffect MusicEffect
CS.MusicEffect = MusicEffect


---@class OuterGlowController : UnityEngine.MonoBehaviour
---@field Range UnityEngine.Vector2
---@field LoopTime number
---@field Enabled boolean
OuterGlowController = {}
---@alias CS.OuterGlowController OuterGlowController
CS.OuterGlowController = OuterGlowController


---@class DOTweenCurvedTracker : UnityEngine.MonoBehaviour
---@field TargetPosition UnityEngine.Vector3
---@field SpiralTurns number
---@field OrbitRadius number
---@field MinOrbitRadius number
---@field PathResolution number
---@field RadiusDecayCurve UnityEngine.AnimationCurve
---@field MoveDuration number
---@field MoveEase DG.Tweening.Ease
---@field PathType DG.Tweening.PathType
---@field ShowPath boolean
---@field PathColor UnityEngine.Color
---@field CircleSegments number
DOTweenCurvedTracker = {}
---@alias CS.DOTweenCurvedTracker DOTweenCurvedTracker
CS.DOTweenCurvedTracker = DOTweenCurvedTracker

---@return DOTweenCurvedTracker
function DOTweenCurvedTracker:Play() end
---@param callback System.Action | function
---@return DOTweenCurvedTracker
function DOTweenCurvedTracker:OnCompletePathGeneration(callback) end
function DOTweenCurvedTracker:StartCurvedMovement() end
function DOTweenCurvedTracker:StartPreviewAnimation() end
function DOTweenCurvedTracker:ResetToOriginalPosition() end
function DOTweenCurvedTracker:StopMovement() end
function DOTweenCurvedTracker:RestartMovement() end
function DOTweenCurvedTracker:ForceUpdatePath() end

---@class DOTweenCurvedTrackerEditor : UnityEditor.Editor
DOTweenCurvedTrackerEditor = {}
---@alias CS.DOTweenCurvedTrackerEditor DOTweenCurvedTrackerEditor
CS.DOTweenCurvedTrackerEditor = DOTweenCurvedTrackerEditor

---@return DOTweenCurvedTrackerEditor
function DOTweenCurvedTrackerEditor.New() end
function DOTweenCurvedTrackerEditor:OnInspectorGUI() end

---@class ObjectGroup : UnityEngine.MonoBehaviour
---@field alpha number
---@field blocksRaycasts boolean
ObjectGroup = {}
---@alias CS.ObjectGroup ObjectGroup
CS.ObjectGroup = ObjectGroup

---@param alpha number
function ObjectGroup:SetAlpha(alpha) end
---@param endValue number
---@param duration number
---@return DG.Tweening.Core.TweenerCore
function ObjectGroup:DOFade(endValue, duration) end

---@class SceneInfo : UnityEngine.MonoBehaviour
---@field ground_y number
---@field bgmList BGMList
---@field backgroundPlaneZ number
---@field boundaryX UnityEngine.Vector2
---@field boundaryY UnityEngine.Vector2
SceneInfo = {}
---@alias CS.SceneInfo SceneInfo
CS.SceneInfo = SceneInfo


---@class SceneItem : UnityEngine.MonoBehaviour
---@field parallaxFactor number
---@field initWorldPosition UnityEngine.Vector3
SceneItem = {}
---@alias CS.SceneItem SceneItem
CS.SceneItem = SceneItem


---@class HelpText : System.Attribute
---@field text string
HelpText = {}
---@alias CS.HelpText HelpText
CS.HelpText = HelpText

---@param description string
---@return HelpText
function HelpText.New(description) end

---@class Commands : System.Object
Commands = {}
---@alias CS.Commands Commands
CS.Commands = Commands

---@param arg string
---@return string
function Commands.help(arg) end
---@return string
function Commands.cls() end
---@param arg1 string
---@param arg2 string
---@return string
function Commands.give(arg1, arg2) end
---@param arg1 string
---@param arg2 string
---@return string
function Commands.copy(arg1, arg2) end
---@param arg1 string
---@param arg2 string
---@return string
function Commands.remove(arg1, arg2) end
---@param type string
---@param id2 string
---@return string
function Commands.load(type, id2) end
---@param arg1 string
---@param arg2 string
---@return string
function Commands.dialogue(arg1, arg2) end
---@param arg1 string
---@return string
function Commands.setId(arg1) end
---@param arg1 string
---@return string
function Commands.check(arg1) end
---@param arg1 string
---@param arg2 string
function Commands.Log(arg1, arg2) end
---@param arg1 string
---@param arg2 string
function Commands.LogWarning(arg1, arg2) end
---@param arg1 string
---@param arg2 string
function Commands.LogError(arg1, arg2) end
---@param arg1 string
---@param arg2 string
function Commands.ShowReward(arg1, arg2) end
---@param arg1 string
function Commands.connect(arg1) end
---@param arg1 string
function Commands.lockitem(arg1) end
---@param arg1 string
function Commands.unlock(arg1) end
---@param arg1 string
function Commands.eventtrigger(arg1) end
---@param arg1 string
function Commands.auto(arg1) end

---@class ConsoleLogic : UnityEngine.MonoBehaviour
ConsoleLogic = {}
---@alias CS.ConsoleLogic ConsoleLogic
CS.ConsoleLogic = ConsoleLogic

---@param command string
---@return string
function ConsoleLogic.Input(command) end
---@return string
function ConsoleLogic.LastCommand() end
---@return string
function ConsoleLogic.NextCommand() end

---@class Dice : System.Object
---@field Default Dice
---@field Value Dice
---@field Check Dice
---@field Type string
---@field Range System.ValueTuple
Dice = {}
---@alias CS.Dice Dice
CS.Dice = Dice

---@param type string
---@return Dice
function Dice:WithType(type) end
---@param min number
---@param max number
---@return Dice
function Dice:WithRange(min, max) end
---@return Dice.State
function Dice:Roll() end

---@class Dice.State : System.Object
---@field Value number
---@field Bonus number
Dice.State = {}
---@alias CS.Dice.State Dice.State
CS.Dice.State = Dice.State

---@param value number
---@param bonus number
---@return Dice.State
function Dice.State.New(value, bonus) end
---@param state Dice.State
function Dice.State:CopyTo(state) end

---@class Dice.RandomCursor : System.Object
---@field val number
Dice.RandomCursor = {}
---@alias CS.Dice.RandomCursor Dice.RandomCursor
CS.Dice.RandomCursor = Dice.RandomCursor

---@param val number
---@return Dice.RandomCursor
function Dice.RandomCursor.New(val) end

---@class DataConfig : System.Object
---@field Type DataType
---@field data System.Collections.Generic.IDictionary
---@field Vars System.Collections.Generic.IDictionary
---@field IsNative boolean
---@field InstanceID string
---@field scriptExecutor IScriptExecutor
---@field isCompiling boolean
DataConfig = {}
---@alias CS.DataConfig DataConfig
CS.DataConfig = DataConfig

---@overload fun(id: string, type: DataType) : DataConfig
---@overload fun(data: System.Collections.Generic.IDictionary, Vars: System.Collections.Generic.IDictionary, ifPreCompile: boolean) : DataConfig
---@return DataConfig
function DataConfig.New() end
function DataConfig.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value DataConfig
---@return ,MemoryPack.MemoryPackReader,DataConfig
function DataConfig.Deserialize(ref_reader, ref_value) end
function DataConfig:PreCompileScripts() end
function DataConfig:ReSetVars() end
---@return System.Object
function DataConfig:Clone() end

---@class DataConfig.DataConfigFormatter : MemoryPack.MemoryPackFormatter
DataConfig.DataConfigFormatter = {}
---@alias CS.DataConfig.DataConfigFormatter DataConfig.DataConfigFormatter
CS.DataConfig.DataConfigFormatter = DataConfig.DataConfigFormatter

---@return DataConfig.DataConfigFormatter
function DataConfig.DataConfigFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value DataConfig
---@return ,MemoryPack.MemoryPackReader,DataConfig
function DataConfig.DataConfigFormatter:Deserialize(ref_reader, ref_value) end

---@class DataConfigException : System.Exception
DataConfigException = {}
---@alias CS.DataConfigException DataConfigException
CS.DataConfigException = DataConfigException

---@overload fun(message: string) : DataConfigException
---@param message string
---@param innerException System.Exception
---@return DataConfigException
function DataConfigException.New(message, innerException) end

---@class DataConfigIdNotFoundException : DataConfigException
---@field Id string
DataConfigIdNotFoundException = {}
---@alias CS.DataConfigIdNotFoundException DataConfigIdNotFoundException
CS.DataConfigIdNotFoundException = DataConfigIdNotFoundException

---@param id string
---@return DataConfigIdNotFoundException
function DataConfigIdNotFoundException.New(id) end

---@class DataConfigSerializer : System.Object
DataConfigSerializer = {}
---@alias CS.DataConfigSerializer DataConfigSerializer
CS.DataConfigSerializer = DataConfigSerializer

---@param writer Mirror.NetworkWriter
---@param dataConfig DataConfig
function DataConfigSerializer.WriteDataConfig(writer, dataConfig) end
---@param reader Mirror.NetworkReader
---@return DataConfig
function DataConfigSerializer.ReadDataConfig(reader) end

---@class DataConfigFormatter : MemoryPack.MemoryPackFormatter
DataConfigFormatter = {}
---@alias CS.DataConfigFormatter DataConfigFormatter
CS.DataConfigFormatter = DataConfigFormatter

---@return DataConfigFormatter
function DataConfigFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value IDataConfig
---@return ,MemoryPack.MemoryPackReader,IDataConfig
function DataConfigFormatter:Deserialize(ref_reader, ref_value) end

---@class RoleTable : System.Object
---@field cardList System.Collections.ObjectModel.ObservableCollection
---@field UnCardList System.Collections.ObjectModel.ObservableCollection
---@field relicList System.Collections.ObjectModel.ObservableCollection
---@field enchasedDict System.Collections.Generic.Dictionary
---@field GetCardReward System.Collections.Generic.Dictionary
---@field GetCard System.Collections.Generic.Dictionary
---@field MoneyMultiplier number
---@field WithoutArmedRelicList System.Collections.ObjectModel.ObservableCollection
---@field blessingConfigs System.Collections.ObjectModel.ObservableCollection
---@field relicGets System.Collections.Generic.Dictionary
---@field SkillTime System.Collections.Generic.Dictionary
---@field BuyBlessCount number
---@field SpecialVarMap System.Collections.Generic.Dictionary
---@field san number
---@field isDead boolean
---@field IsMoveOn boolean
---@field Id string
---@field SafeBoxRelicCount number
---@field SafeBoxCardCount number
---@field SafeBoxGetMoneyCount number
---@field SafeBoxSaveMoneyCount number
---@field GetRelic boolean
---@field GetCardInBack boolean
---@field IsStarted boolean
---@field maxSan number
---@field Career DataConfig
---@field ExtraordinaryBlessings System.Collections.ObjectModel.ObservableCollection
---@field ChooseVars System.Collections.Generic.List
---@field money Loxodon.Framework.Obfuscation.ObfuscatedInt
---@field VarsMap System.Collections.Generic.Dictionary
---@field SpecialCount number
---@field Instance RoleTable
---@field InHighTide boolean
---@field Reward number
---@field sumFeat number
---@field CardCount number
---@field CardBottomCount number
---@field CardTopCount number
---@field MaxAlCardCount number
---@field MainVarUpperBound number
---@field SecondaryVarUpperBound number
---@field OtherVarUpperBound number
---@field San number
---@field MaxSan number
---@field Money Loxodon.Framework.Obfuscation.ObfuscatedInt
---@field MoneyCal number
RoleTable = {}
---@alias CS.RoleTable RoleTable
CS.RoleTable = RoleTable

---@return RoleTable
function RoleTable.New() end
---@param baseMoney number
---@return number
function RoleTable:ReturnMoneyCal(baseMoney) end
function RoleTable:Listen() end
---@param role RoleTable
function RoleTable:ResetFight(role) end
---@param blessid string
function RoleTable:TryAddBless(blessid) end
---@param key string
function RoleTable:VarsCheck(key) end
---@param key string
---@param value number
function RoleTable:UseVarsChanges(key, value) end
function RoleTable:LevelCount() end
function RoleTable:Init() end

---@class CustomRoleTableReaderWriter : System.Object
CustomRoleTableReaderWriter = {}
---@alias CS.CustomRoleTableReaderWriter CustomRoleTableReaderWriter
CS.CustomRoleTableReaderWriter = CustomRoleTableReaderWriter

---@param writer Mirror.NetworkWriter
---@param roleTable RoleTable
function CustomRoleTableReaderWriter.WriteRoleTable(writer, roleTable) end
---@param reader Mirror.NetworkReader
---@return RoleTable
function CustomRoleTableReaderWriter.ReadRoleTable(reader) end

---@class SettingTable : System.Object
---@field dic System.Collections.Generic.Dictionary
---@field onValueChanged System.Collections.Generic.Dictionary
SettingTable = {}
---@alias CS.SettingTable SettingTable
CS.SettingTable = SettingTable

---@return SettingTable
function SettingTable.New() end
---@param key string
---@param value string
function SettingTable:SetValue(key, value) end
---@param key string
---@return string
function SettingTable:GetValue(key) end
function SettingTable:Apply() end
---@param language string
function SettingTable:ChangeLanguage(language) end

---@class GameConfigManager : Singleton
---@field PlayerId string
---@field PlayerName string
---@field modConfigs System.Collections.Generic.List
---@field OnAppicationQuit System.Action | function
---@field ifCompileImmidiate boolean
---@field cts System.Threading.CancellationTokenSource
---@field NativeIds System.Collections.Generic.HashSet
---@field LockedIds System.Collections.Generic.HashSet
---@field isFontWarmup boolean
---@field totalCount number
---@field current number
---@field Version string
---@field DataConfigCache System.Collections.Concurrent.ConcurrentDictionary
---@field isLoading boolean
---@field Instance GameConfigManager -- infered from Singleton`1[GameConfigManager]
---@field GetInstance GameConfigManager -- infered from Singleton`1[GameConfigManager]
GameConfigManager = {}
---@alias CS.GameConfigManager GameConfigManager
CS.GameConfigManager = GameConfigManager

---@return GameConfigManager
function GameConfigManager.New() end
---@param type DataType
---@return GameConfigData
function GameConfigManager:GetTable(type) end
function GameConfigManager:Init() end
---@param path string
function GameConfigManager:LoadResource(path) end
function GameConfigManager:AddNativeIds() end
function GameConfigManager:BuySave() end
---@param item System.Collections.Generic.IDictionary
function GameConfigManager:BuySaveByName(item) end
---@param TheList System.Collections.Generic.List
---@return System.Collections.Generic.List
function GameConfigManager:GetByNote(TheList) end
---@param list System.Collections.Generic.List
---@param prefix string
---@return System.Collections.Generic.Dictionary
function GameConfigManager:GetDataByPrefix(list, prefix) end
---@overload fun(self: GameConfigManager, type: DataType, id: string) : System.Collections.Generic.Dictionary
---@param data GameConfigData
---@param id string
---@return System.Collections.Generic.Dictionary
function GameConfigManager:GetOne(data, id) end
---@param id string
---@return System.Collections.Generic.Dictionary
function GameConfigManager:GetOneById(id) end

---@class DataId : System.Object
---@field Id_2Fight_1 string
---@field Id_2Fight_2 string
---@field Id_2Fight_3 string
---@field Id_2Fight_4 string
---@field Id_2Fight_5 string
---@field Id_2Fight_6 string
---@field Id_2Fight_7 string
---@field Id_2Fight_8 string
---@field Id_2Fight_9 string
---@field Id_3Fight_1 string
---@field Id_3Fight_2 string
---@field Id_3Fight_3 string
---@field Id_3Fight_4 string
---@field Id_3Fight_5 string
---@field Id_3Fight_6 string
---@field Id_3Fight_7 string
---@field Id_3Fight_8 string
---@field Id_3Fight_9 string
---@field Id_4Fight_1 string
---@field Id_4Fight_2 string
---@field Id_4Fight_3 string
---@field Id_4Fight_4 string
---@field Id_4Fight_5 string
---@field Id_7Node_1 string
---@field Id_7Node_2 string
---@field Id_7Node_3 string
---@field Amelia_1 string
---@field FirstBless_1 string
---@field FirstBless_2 string
---@field FirstBless_3 string
---@field FirstBless_4 string
---@field FirstFight_1 string
---@field FirstFight_10 string
---@field FirstFight_11 string
---@field FirstFight_12 string
---@field FirstFight_13 string
---@field FirstFight_14 string
---@field FirstFight_2 string
---@field FirstFight_3 string
---@field FirstFight_4 string
---@field FirstFight_5 string
---@field FirstFight_6 string
---@field FirstFight_7 string
---@field FirstFight_8 string
---@field FirstFight_9 string
---@field FirstShop_1 string
---@field FirstShop_2 string
---@field FirstShop_3 string
---@field FirstShop_4 string
---@field FirstShop_5 string
---@field FirstShop_6 string
---@field FirstShop_7 string
---@field FirstShop_8 string
---@field FirstTalk_1 string
---@field FirstTalk_10 string
---@field FirstTalk_11 string
---@field FirstTalk_12 string
---@field FirstTalk_2 string
---@field FirstTalk_3 string
---@field FirstTalk_4 string
---@field FirstTalk_5 string
---@field FirstTalk_6 string
---@field FirstTalk_7 string
---@field FirstTalk_8 string
---@field FirstTalk_9 string
---@field Hard_1 string
---@field Hard_10 string
---@field Hard_11 string
---@field Hard_12 string
---@field Hard_13 string
---@field Hard_14 string
---@field Hard_15 string
---@field Hard_16 string
---@field Hard_17 string
---@field Hard_18 string
---@field Hard_19 string
---@field Hard_2 string
---@field Hard_3 string
---@field Hard_4 string
---@field Hard_5 string
---@field Hard_6 string
---@field Hard_7 string
---@field Hard_8 string
---@field Hard_9 string
---@field Mapselect_1 string
---@field Mapselect_10 string
---@field Mapselect_11 string
---@field Mapselect_12 string
---@field Mapselect_13 string
---@field Mapselect_14 string
---@field Mapselect_2 string
---@field Mapselect_3 string
---@field Mapselect_4 string
---@field Mapselect_5 string
---@field Mapselect_6 string
---@field Mapselect_7 string
---@field Mapselect_8 string
---@field Mapselect_9 string
---@field PartnerCard_AswiftBlow string
---@field PartnerCard_Combing string
---@field PartnerCard_DeepGrows string
---@field PartnerCard_FuneralBell string
---@field PartnerCard_Hah string
---@field PartnerCard_QuadrupleHits string
---@field PartnerCard_attack string
---@field PartnerCard_defence string
---@field Partner_10001 string
---@field Partner_10002 string
---@field SecondAD_1 string
---@field SecondAD_2 string
---@field SecondAD_3 string
---@field SecondAD_4 string
---@field SecondAD_5 string
---@field SpecialBuff_AdvancedWoodenStakes string
---@field SpecialBuff_AllogeneicConcentric string
---@field SpecialBuff_BackToBasics string
---@field SpecialBuff_BlessedByHeaven string
---@field SpecialBuff_CalamityIncarnates string
---@field SpecialBuff_Crow string
---@field SpecialBuff_Demigod_sBody string
---@field SpecialBuff_DragonScaleArmor string
---@field SpecialBuff_EndlessDesire string
---@field SpecialBuff_FortuneBoy string
---@field SpecialBuff_GiantDollBear string
---@field SpecialBuff_Hysteresis string
---@field SpecialBuff_ImmortalGodhead string
---@field SpecialBuff_Irritable string
---@field SpecialBuff_Law_Death string
---@field SpecialBuff_Law_Judgment string
---@field SpecialBuff_Law_Supreme string
---@field SpecialBuff_ManInTheMirror string
---@field SpecialBuff_Mimics string
---@field SpecialBuff_Musician string
---@field SpecialBuff_OriginalSin string
---@field SpecialBuff_Phoenix string
---@field SpecialBuff_Priest string
---@field SpecialBuff_Restrain string
---@field SpecialBuff_Snitch string
---@field SpecialBuff_SwordOfTheDemonKing string
---@field SpecialBuff_ThievesKing string
---@field SpecialBuff_ThirstForBlood string
---@field SpecialBuff_Transcendent string
---@field SpecialBuff_TrialsOfStrength string
---@field SpecialBuff_TrialsOfTenacity string
---@field SpecialBuff_TrialsOfWisdom string
---@field SpecialBuff_Twins string
---@field SpecialBuff_UnparalleledPower string
---@field SpecialBuff_WitchCultists string
---@field SpecialBuff_believer string
---@field SpecialBuff_biologicalInstinct string
---@field SpecialBuff_expiation string
---@field SpecialBuff_fluster string
---@field SpecialBuff_guiltless string
---@field SpecialBuff_hunting string
---@field SpecialBuff_meow string
---@field StartTutorial_1 string
---@field StartTutorial_10 string
---@field StartTutorial_11 string
---@field StartTutorial_12 string
---@field StartTutorial_13 string
---@field StartTutorial_14 string
---@field StartTutorial_15 string
---@field StartTutorial_16 string
---@field StartTutorial_17 string
---@field StartTutorial_18 string
---@field StartTutorial_19 string
---@field StartTutorial_2 string
---@field StartTutorial_20 string
---@field StartTutorial_21 string
---@field StartTutorial_22 string
---@field StartTutorial_23 string
---@field StartTutorial_24 string
---@field StartTutorial_25 string
---@field StartTutorial_26 string
---@field StartTutorial_27 string
---@field StartTutorial_28 string
---@field StartTutorial_281 string
---@field StartTutorial_282 string
---@field StartTutorial_283 string
---@field StartTutorial_284 string
---@field StartTutorial_29 string
---@field StartTutorial_291 string
---@field StartTutorial_3 string
---@field StartTutorial_30 string
---@field StartTutorial_31 string
---@field StartTutorial_32 string
---@field StartTutorial_33 string
---@field StartTutorial_34 string
---@field StartTutorial_35 string
---@field StartTutorial_36 string
---@field StartTutorial_37 string
---@field StartTutorial_38 string
---@field StartTutorial_39 string
---@field StartTutorial_4 string
---@field StartTutorial_40 string
---@field StartTutorial_41 string
---@field StartTutorial_42 string
---@field StartTutorial_43 string
---@field StartTutorial_44 string
---@field StartTutorial_45 string
---@field StartTutorial_46 string
---@field StartTutorial_47 string
---@field StartTutorial_48 string
---@field StartTutorial_49 string
---@field StartTutorial_5 string
---@field StartTutorial_50 string
---@field StartTutorial_51 string
---@field StartTutorial_52 string
---@field StartTutorial_53 string
---@field StartTutorial_54 string
---@field StartTutorial_55 string
---@field StartTutorial_56 string
---@field StartTutorial_6 string
---@field StartTutorial_7 string
---@field StartTutorial_8 string
---@field StartTutorial_9 string
---@field blessing_1 string
---@field blessing_10 string
---@field blessing_101 string
---@field blessing_102 string
---@field blessing_103 string
---@field blessing_104 string
---@field blessing_105 string
---@field blessing_106 string
---@field blessing_107 string
---@field blessing_108 string
---@field blessing_109 string
---@field blessing_11 string
---@field blessing_110 string
---@field blessing_111 string
---@field blessing_112 string
---@field blessing_113 string
---@field blessing_114 string
---@field blessing_115 string
---@field blessing_116 string
---@field blessing_12 string
---@field blessing_14 string
---@field blessing_15 string
---@field blessing_19 string
---@field blessing_2 string
---@field blessing_20 string
---@field blessing_21 string
---@field blessing_22 string
---@field blessing_23 string
---@field blessing_24 string
---@field blessing_3 string
---@field blessing_32 string
---@field blessing_33 string
---@field blessing_34 string
---@field blessing_35 string
---@field blessing_36 string
---@field blessing_37 string
---@field blessing_38 string
---@field blessing_39 string
---@field blessing_4 string
---@field blessing_5 string
---@field blessing_6 string
---@field blessing_7 string
---@field blessing_8 string
---@field blessing_9 string
---@field blood_1 string
---@field blood_10 string
---@field blood_11 string
---@field blood_12 string
---@field blood_13 string
---@field blood_2 string
---@field blood_3 string
---@field blood_4 string
---@field blood_5 string
---@field blood_6 string
---@field blood_7 string
---@field blood_8 string
---@field blood_9 string
---@field buff_BonePiercingSpike string
---@field buff_ChaosMark string
---@field buff_DoomPower string
---@field buff_EnergyStorage string
---@field buff_GuleiSummoningArt string
---@field buff_Lilith_s_Pact string
---@field buff_RegenerationPrayer string
---@field buff_WailingWall string
---@field buff_barkhide string
---@field buff_biologicalArmor string
---@field buff_bleeding string
---@field buff_bloodriver string
---@field buff_bloodsea string
---@field buff_bloodwall string
---@field buff_burn string
---@field buff_chaos string
---@field buff_chrysalis string
---@field buff_contagion string
---@field buff_counterattack string
---@field buff_cripple string
---@field buff_cycle string
---@field buff_degrade string
---@field buff_eclipse string
---@field buff_elementalBody string
---@field buff_elements string
---@field buff_epiphany string
---@field buff_evergreen string
---@field buff_extraordinary string
---@field buff_fast string
---@field buff_fate string
---@field buff_frenzy string
---@field buff_immortal string
---@field buff_impregnable string
---@field buff_keenedge string
---@field buff_lifelink string
---@field buff_limitdamage string
---@field buff_oblivion string
---@field buff_obsidianKnight string
---@field buff_obsidianQueen string
---@field buff_obsidianSoldier string
---@field buff_oniblood string
---@field buff_poised string
---@field buff_resilient string
---@field buff_revelation string
---@field buff_reverie string
---@field buff_rotten string
---@field buff_sourcecast string
---@field buff_swordIntent string
---@field buff_synergies string
---@field buff_thorns string
---@field buff_timelock string
---@field buff_timestop string
---@field buff_toxin string
---@field buff_unyielding string
---@field buff_vitality string
---@field buff_vulnerability string
---@field buff_weak string
---@field buff_weakness string
---@field burningcard_1 string
---@field burningcard_2 string
---@field burningcard_3 string
---@field burningcard_4 string
---@field card_1 string
---@field card_10 string
---@field card_11 string
---@field card_12 string
---@field card_13 string
---@field card_14 string
---@field card_15 string
---@field card_16 string
---@field card_17 string
---@field card_18 string
---@field card_2 string
---@field card_3 string
---@field card_4 string
---@field card_5 string
---@field card_6 string
---@field card_7 string
---@field card_8 string
---@field card_9 string
---@field career_1 string
---@field career_2 string
---@field career_3 string
---@field career_4 string
---@field career_5 string
---@field career_6 string
---@field careercard_1 string
---@field careercard_2 string
---@field careercard_3 string
---@field careercard_4 string
---@field careercard_5 string
---@field careercard_6 string
---@field careercard_7 string
---@field coin_1 string
---@field coin_2 string
---@field coin_3 string
---@field combo_1 string
---@field combo_10 string
---@field combo_11 string
---@field combo_12 string
---@field combo_13 string
---@field combo_14 string
---@field combo_15 string
---@field combo_2 string
---@field combo_3 string
---@field combo_4 string
---@field combo_5 string
---@field combo_6 string
---@field combo_7 string
---@field combo_8 string
---@field combo_9 string
---@field counterattackcard_1 string
---@field counterattackcard_10 string
---@field counterattackcard_11 string
---@field counterattackcard_12 string
---@field counterattackcard_13 string
---@field counterattackcard_2 string
---@field counterattackcard_3 string
---@field counterattackcard_4 string
---@field counterattackcard_5 string
---@field counterattackcard_6 string
---@field counterattackcard_7 string
---@field counterattackcard_8 string
---@field counterattackcard_9 string
---@field cursecard_1 string
---@field cursecard_10 string
---@field cursecard_11 string
---@field cursecard_12 string
---@field cursecard_13 string
---@field cursecard_2 string
---@field cursecard_3 string
---@field cursecard_4 string
---@field cursecard_5 string
---@field cursecard_6 string
---@field cursecard_7 string
---@field cursecard_8 string
---@field cursecard_9 string
---@field effect_damage string
---@field elementscard_1 string
---@field elementscard_10 string
---@field elementscard_11 string
---@field elementscard_12 string
---@field elementscard_13 string
---@field elementscard_2 string
---@field elementscard_3 string
---@field elementscard_4 string
---@field elementscard_5 string
---@field elementscard_6 string
---@field elementscard_7 string
---@field elementscard_8 string
---@field elementscard_9 string
---@field enchtag_1 string
---@field enchtag_10 string
---@field enchtag_11 string
---@field enchtag_12 string
---@field enchtag_13 string
---@field enchtag_14 string
---@field enchtag_15 string
---@field enchtag_2 string
---@field enchtag_3 string
---@field enchtag_4 string
---@field enchtag_5 string
---@field enchtag_6 string
---@field enchtag_7 string
---@field enchtag_8 string
---@field enchtag_9 string
---@field ending_1 string
---@field ending_2 string
---@field ending_3 string
---@field ending_4 string
---@field ending_5 string
---@field enemy_10001 string
---@field enemy_10002 string
---@field enemy_10003 string
---@field enemy_10004 string
---@field enemy_10005 string
---@field enemy_10007 string
---@field enemy_10008 string
---@field enemy_10009 string
---@field enemy_10010 string
---@field enemy_10014 string
---@field enemy_10015 string
---@field enemy_10016 string
---@field enemy_10017 string
---@field enemy_10018 string
---@field enemy_10019 string
---@field enemy_10020 string
---@field enemy_10021 string
---@field enemy_10022 string
---@field enemy_10023 string
---@field enemy_10024 string
---@field enemy_10025 string
---@field enemy_10026 string
---@field enemy_10027 string
---@field enemy_10028 string
---@field enemy_10029 string
---@field enemy_10030 string
---@field enemy_10031 string
---@field enemy_10032 string
---@field enemy_10033 string
---@field enemy_10034 string
---@field enemy_10035 string
---@field enemy_10036 string
---@field enemy_10037 string
---@field enemy_10038 string
---@field enemy_10039 string
---@field enemy_10040 string
---@field enemy_10041 string
---@field enemy_10042 string
---@field enemy_10043 string
---@field enemy_10044 string
---@field enemy_10045 string
---@field enemy_10046 string
---@field enemy_10047 string
---@field enemy_10048 string
---@field enemy_10049 string
---@field enemy_10050 string
---@field enemy_10051 string
---@field enemy_10052 string
---@field enemy_10053 string
---@field enemy_99999 string
---@field enemycard_Charge1 string
---@field enemycard_Charge2 string
---@field enemycard_Come string
---@field enemycard_Despair string
---@field enemycard_Dragon_sMajesty string
---@field enemycard_EvilCurse string
---@field enemycard_FallenDragon string
---@field enemycard_FiveHit string
---@field enemycard_FullSupport string
---@field enemycard_GiantClawStrike string
---@field enemycard_HighFly string
---@field enemycard_IceShield string
---@field enemycard_Licking string
---@field enemycard_LimePowder string
---@field enemycard_MT1 string
---@field enemycard_MT2 string
---@field enemycard_MakeIneffectiveRays1 string
---@field enemycard_MakeIneffectiveRays2 string
---@field enemycard_NerveReflexes string
---@field enemycard_NeverDead string
---@field enemycard_Observe string
---@field enemycard_OrdinaryFiveHit string
---@field enemycard_OrdinaryHit string
---@field enemycard_OriginalSinCard string
---@field enemycard_OverrunWorkouts string
---@field enemycard_PlugCards1 string
---@field enemycard_PlugCards2 string
---@field enemycard_PlugCards3 string
---@field enemycard_PoisonThrowing string
---@field enemycard_PowerlessCurse string
---@field enemycard_QuadrupleHits string
---@field enemycard_RoyalBarrier string
---@field enemycard_SpreadWings string
---@field enemycard_SuperFireBall string
---@field enemycard_Thieves string
---@field enemycard_Toxin1 string
---@field enemycard_Toxin2 string
---@field enemycard_Toxin3 string
---@field enemycard_Toxin4 string
---@field enemycard_VenomSpray string
---@field enemycard_Wake string
---@field enemycard_Weak string
---@field enemycard_WeakLight string
---@field enemycard_WhereverYouGo string
---@field enemycard_Witness string
---@field enemycard_burn string
---@field enemycard_burn1 string
---@field enemycard_burn2 string
---@field enemycard_charmed string
---@field enemycard_defence string
---@field enemycard_fearless string
---@field enemycard_foraging string
---@field enemycard_obtainMoney string
---@field enemycard_psychologicalShock string
---@field enemycard_rejuvenation string
---@field enemycard_specialAttack string
---@field enemycard_thief string
---@field enemycard_vulnerabilityLight string
---@field event_1 string
---@field event_10 string
---@field event_1000 string
---@field event_1001 string
---@field event_1002 string
---@field event_11 string
---@field event_12 string
---@field event_13 string
---@field event_14 string
---@field event_15 string
---@field event_16 string
---@field event_17 string
---@field event_18 string
---@field event_19 string
---@field event_2 string
---@field event_20 string
---@field event_21 string
---@field event_3 string
---@field event_4 string
---@field event_7 string
---@field event_8 string
---@field event_9 string
---@field event_999 string
---@field event_Sub_1000_2 string
---@field event_Sub_999_2 string
---@field event_Sub_9_2 string
---@field food_1 string
---@field food_10 string
---@field food_11 string
---@field food_12 string
---@field food_13 string
---@field food_14 string
---@field food_15 string
---@field food_16 string
---@field food_2 string
---@field food_3 string
---@field food_4 string
---@field food_5 string
---@field food_6 string
---@field food_7 string
---@field food_8 string
---@field food_9 string
---@field healcard_1 string
---@field healcard_2 string
---@field healcard_3 string
---@field healcard_4 string
---@field healcard_5 string
---@field healcard_6 string
---@field healcard_7 string
---@field healcard_8 string
---@field healcard_9 string
---@field level_0 string
---@field level_10001 string
---@field level_10002 string
---@field level_10003 string
---@field level_10004 string
---@field level_10005 string
---@field level_10006 string
---@field level_10007 string
---@field level_10008 string
---@field level_10009 string
---@field level_10010 string
---@field level_10011 string
---@field level_10013 string
---@field level_10014 string
---@field level_10015 string
---@field level_10016 string
---@field level_10017 string
---@field level_10018 string
---@field level_10019 string
---@field level_10020 string
---@field level_10021 string
---@field level_10022 string
---@field level_10024 string
---@field level_10025 string
---@field level_10026 string
---@field level_10027 string
---@field level_10028 string
---@field level_10029 string
---@field level_10030 string
---@field level_10031 string
---@field level_10032 string
---@field level_10033 string
---@field level_10034 string
---@field level_10035 string
---@field level_10036 string
---@field level_10037 string
---@field level_10038 string
---@field level_10039 string
---@field level_10040 string
---@field level_10041 string
---@field level_10042 string
---@field level_10043 string
---@field level_10044 string
---@field level_10045 string
---@field level_10046 string
---@field level_10047 string
---@field level_99999 string
---@field luckycard_1 string
---@field luckycard_10 string
---@field luckycard_11 string
---@field luckycard_12 string
---@field luckycard_2 string
---@field luckycard_3 string
---@field luckycard_4 string
---@field luckycard_5 string
---@field luckycard_6 string
---@field luckycard_7 string
---@field luckycard_8 string
---@field luckycard_9 string
---@field map_0 string
---@field map_1 string
---@field map_10 string
---@field map_1000 string
---@field map_11 string
---@field map_12 string
---@field map_13 string
---@field map_15 string
---@field map_16 string
---@field map_17 string
---@field map_18 string
---@field map_19 string
---@field map_2 string
---@field map_20 string
---@field map_21 string
---@field map_22 string
---@field map_23 string
---@field map_24 string
---@field map_25 string
---@field map_26 string
---@field map_27 string
---@field map_28 string
---@field map_29 string
---@field map_3 string
---@field map_30 string
---@field map_31 string
---@field map_32 string
---@field map_33 string
---@field map_34 string
---@field map_35 string
---@field map_36 string
---@field map_37 string
---@field map_38 string
---@field map_39 string
---@field map_4 string
---@field map_40 string
---@field map_41 string
---@field map_42 string
---@field map_43 string
---@field map_44 string
---@field map_45 string
---@field map_46 string
---@field map_47 string
---@field map_48 string
---@field map_49 string
---@field map_5 string
---@field map_50 string
---@field map_6 string
---@field map_7 string
---@field map_8 string
---@field map_9 string
---@field map_999 string
---@field materials_1 string
---@field materials_10 string
---@field materials_11 string
---@field materials_12 string
---@field materials_13 string
---@field materials_14 string
---@field materials_15 string
---@field materials_16 string
---@field materials_17 string
---@field materials_18 string
---@field materials_19 string
---@field materials_2 string
---@field materials_20 string
---@field materials_21 string
---@field materials_22 string
---@field materials_23 string
---@field materials_24 string
---@field materials_25 string
---@field materials_26 string
---@field materials_27 string
---@field materials_28 string
---@field materials_29 string
---@field materials_3 string
---@field materials_30 string
---@field materials_4 string
---@field materials_5 string
---@field materials_6 string
---@field materials_7 string
---@field materials_8 string
---@field materials_9 string
---@field nocard_1 string
---@field nocard_2 string
---@field nocard_3 string
---@field nocard_4 string
---@field onlinecard_1 string
---@field onlinecard_2 string
---@field onlinecard_3 string
---@field onlinecard_4 string
---@field onlinecard_5 string
---@field outsideshop_1 string
---@field outsideshop_10 string
---@field outsideshop_11 string
---@field outsideshop_12 string
---@field outsideshop_13 string
---@field outsideshop_14 string
---@field outsideshop_15 string
---@field outsideshop_16 string
---@field outsideshop_2 string
---@field outsideshop_3 string
---@field outsideshop_4 string
---@field outsideshop_5 string
---@field outsideshop_6 string
---@field outsideshop_7 string
---@field outsideshop_8 string
---@field outsideshop_9 string
---@field perceivecard_1 string
---@field perceivecard_3 string
---@field perceivecard_5 string
---@field perceivecard_6 string
---@field relic_1 string
---@field relic_10 string
---@field relic_11 string
---@field relic_12 string
---@field relic_13 string
---@field relic_14 string
---@field relic_15 string
---@field relic_16 string
---@field relic_17 string
---@field relic_18 string
---@field relic_19 string
---@field relic_2 string
---@field relic_20 string
---@field relic_21 string
---@field relic_22 string
---@field relic_23 string
---@field relic_24 string
---@field relic_25 string
---@field relic_26 string
---@field relic_27 string
---@field relic_28 string
---@field relic_29 string
---@field relic_3 string
---@field relic_30 string
---@field relic_31 string
---@field relic_32 string
---@field relic_33 string
---@field relic_34 string
---@field relic_35 string
---@field relic_36 string
---@field relic_37 string
---@field relic_38 string
---@field relic_39 string
---@field relic_4 string
---@field relic_40 string
---@field relic_41 string
---@field relic_42 string
---@field relic_43 string
---@field relic_44 string
---@field relic_45 string
---@field relic_46 string
---@field relic_47 string
---@field relic_48 string
---@field relic_49 string
---@field relic_5 string
---@field relic_50 string
---@field relic_51 string
---@field relic_52 string
---@field relic_53 string
---@field relic_54 string
---@field relic_55 string
---@field relic_56 string
---@field relic_57 string
---@field relic_58 string
---@field relic_59 string
---@field relic_6 string
---@field relic_60 string
---@field relic_61 string
---@field relic_62 string
---@field relic_63 string
---@field relic_64 string
---@field relic_65 string
---@field relic_66 string
---@field relic_67 string
---@field relic_68 string
---@field relic_69 string
---@field relic_7 string
---@field relic_70 string
---@field relic_71 string
---@field relic_72 string
---@field relic_73 string
---@field relic_74 string
---@field relic_75 string
---@field relic_76 string
---@field relic_77 string
---@field relic_78 string
---@field relic_79 string
---@field relic_8 string
---@field relic_80 string
---@field relic_9 string
---@field role_Adele string
---@field role_Krisna string
---@field role_amelia string
---@field role_narrator string
---@field shadowchat1_1 string
---@field shadowchat1_10 string
---@field shadowchat1_2 string
---@field shadowchat1_3 string
---@field shadowchat1_4 string
---@field shadowchat1_5 string
---@field shadowchat1_6 string
---@field shadowchat1_7 string
---@field shadowchat1_8 string
---@field shadowchat1_9 string
---@field testTask_1 string
---@field timekeeper_1 string
---@field timekeeper_10 string
---@field timekeeper_11 string
---@field timekeeper_12 string
---@field timekeeper_13 string
---@field timekeeper_14 string
---@field timekeeper_15 string
---@field timekeeper_16 string
---@field timekeeper_17 string
---@field timekeeper_18 string
---@field timekeeper_2 string
---@field timekeeper_3 string
---@field timekeeper_4 string
---@field timekeeper_5 string
---@field timekeeper_6 string
---@field timekeeper_7 string
---@field timekeeper_8 string
---@field timekeeper_9 string
---@field tutorial_Action string
---@field tutorial_Action_card string
---@field tutorial_Announcement string
---@field tutorial_Base_attributes string
---@field tutorial_Break string
---@field tutorial_Buff string
---@field tutorial_CardEditor string
---@field tutorial_Defence string
---@field tutorial_DesChoice string
---@field tutorial_DesType string
---@field tutorial_Difficulty_selection string
---@field tutorial_Disaster string
---@field tutorial_Event string
---@field tutorial_Function_bar string
---@field tutorial_Hp string
---@field tutorial_Illustrated_book string
---@field tutorial_Magic_power string
---@field tutorial_Monetary_resources string
---@field tutorial_Outside_upgrades string
---@field tutorial_Piles_fold_piles string
---@field tutorial_Relic string
---@field tutorial_Round string
---@field tutorial_SafeBox string
---@field tutorial_Shop string
---@field tutorial_Test1 string
---@field tutorial_Test2 string
---@field tutorial_Toughness string
---@field universalcard_1 string
---@field universalcard_10 string
---@field universalcard_11 string
---@field universalcard_12 string
---@field universalcard_13 string
---@field universalcard_14 string
---@field universalcard_15 string
---@field universalcard_16 string
---@field universalcard_17 string
---@field universalcard_18 string
---@field universalcard_19 string
---@field universalcard_2 string
---@field universalcard_20 string
---@field universalcard_3 string
---@field universalcard_4 string
---@field universalcard_5 string
---@field universalcard_6 string
---@field universalcard_7 string
---@field universalcard_8 string
---@field universalcard_9 string
DataId = {}
---@alias CS.DataId DataId
CS.DataId = DataId


---@class DataIds : System.Object
---@field Id_2Fight_1 string
---@field Id_2Fight_2 string
---@field Id_2Fight_3 string
---@field Id_2Fight_4 string
---@field Id_2Fight_5 string
---@field Id_2Fight_6 string
---@field Id_2Fight_7 string
---@field Id_2Fight_8 string
---@field Id_2Fight_9 string
---@field Id_3Fight_1 string
---@field Id_3Fight_2 string
---@field Id_3Fight_3 string
---@field Id_3Fight_4 string
---@field Id_3Fight_5 string
---@field Id_3Fight_6 string
---@field Id_3Fight_7 string
---@field Id_3Fight_8 string
---@field Id_3Fight_9 string
---@field Id_4Fight_1 string
---@field Id_4Fight_2 string
---@field Id_4Fight_3 string
---@field Id_4Fight_4 string
---@field Id_4Fight_5 string
---@field Id_7Node_1 string
---@field Id_7Node_2 string
---@field Id_7Node_3 string
---@field Amelia_1 string
---@field BuffKeyword_SpecialBuff_AdvancedWoodenStakes string
---@field BuffKeyword_SpecialBuff_AllogeneicConcentric string
---@field BuffKeyword_SpecialBuff_BackToBasics string
---@field BuffKeyword_SpecialBuff_BlessedByHeaven string
---@field BuffKeyword_SpecialBuff_CalamityIncarnates string
---@field BuffKeyword_SpecialBuff_Crow string
---@field BuffKeyword_SpecialBuff_FortuneBoy string
---@field BuffKeyword_SpecialBuff_GiantDollBear string
---@field BuffKeyword_SpecialBuff_Hysteresis string
---@field BuffKeyword_SpecialBuff_ImmortalGodhead string
---@field BuffKeyword_SpecialBuff_Irritable string
---@field BuffKeyword_SpecialBuff_Law_Death string
---@field BuffKeyword_SpecialBuff_Law_Judgment string
---@field BuffKeyword_SpecialBuff_Law_Supreme string
---@field BuffKeyword_SpecialBuff_ManInTheMirror string
---@field BuffKeyword_SpecialBuff_Mimics string
---@field BuffKeyword_SpecialBuff_Musician string
---@field BuffKeyword_SpecialBuff_Phoenix string
---@field BuffKeyword_SpecialBuff_Priest string
---@field BuffKeyword_SpecialBuff_Restrain string
---@field BuffKeyword_SpecialBuff_Snitch string
---@field BuffKeyword_SpecialBuff_ThievesKing string
---@field BuffKeyword_SpecialBuff_ThirstForBlood string
---@field BuffKeyword_SpecialBuff_Transcendent string
---@field BuffKeyword_SpecialBuff_TrialsOfStrength string
---@field BuffKeyword_SpecialBuff_TrialsOfTenacity string
---@field BuffKeyword_SpecialBuff_TrialsOfWisdom string
---@field BuffKeyword_SpecialBuff_Twins string
---@field BuffKeyword_SpecialBuff_UnparalleledPower string
---@field BuffKeyword_SpecialBuff_WitchCultists string
---@field BuffKeyword_SpecialBuff_believer string
---@field BuffKeyword_SpecialBuff_biologicalInstinct string
---@field BuffKeyword_SpecialBuff_expiation string
---@field BuffKeyword_SpecialBuff_fluster string
---@field BuffKeyword_SpecialBuff_guiltless string
---@field BuffKeyword_SpecialBuff_hunting string
---@field BuffKeyword_SpecialBuff_meow string
---@field BuffKeyword_buff_BonePiercingSpike string
---@field BuffKeyword_buff_ChaosMark string
---@field BuffKeyword_buff_DoomPower string
---@field BuffKeyword_buff_EnergyStorage string
---@field BuffKeyword_buff_GuleiSummoningArt string
---@field BuffKeyword_buff_Lilith_s_Pact string
---@field BuffKeyword_buff_RegenerationPrayer string
---@field BuffKeyword_buff_WailingWall string
---@field BuffKeyword_buff_barkhide string
---@field BuffKeyword_buff_biologicalArmor string
---@field BuffKeyword_buff_bleeding string
---@field BuffKeyword_buff_bloodriver string
---@field BuffKeyword_buff_bloodsea string
---@field BuffKeyword_buff_bloodwall string
---@field BuffKeyword_buff_burn string
---@field BuffKeyword_buff_chaos string
---@field BuffKeyword_buff_chrysalis string
---@field BuffKeyword_buff_contagion string
---@field BuffKeyword_buff_counterattack string
---@field BuffKeyword_buff_cripple string
---@field BuffKeyword_buff_cycle string
---@field BuffKeyword_buff_degrade string
---@field BuffKeyword_buff_eclipse string
---@field BuffKeyword_buff_elementalBody string
---@field BuffKeyword_buff_elements string
---@field BuffKeyword_buff_epiphany string
---@field BuffKeyword_buff_evergreen string
---@field BuffKeyword_buff_extraordinary string
---@field BuffKeyword_buff_fast string
---@field BuffKeyword_buff_fate string
---@field BuffKeyword_buff_frenzy string
---@field BuffKeyword_buff_immortal string
---@field BuffKeyword_buff_impregnable string
---@field BuffKeyword_buff_keenedge string
---@field BuffKeyword_buff_lifelink string
---@field BuffKeyword_buff_limitdamage string
---@field BuffKeyword_buff_oblivion string
---@field BuffKeyword_buff_obsidianKnight string
---@field BuffKeyword_buff_obsidianQueen string
---@field BuffKeyword_buff_obsidianSoldier string
---@field BuffKeyword_buff_oniblood string
---@field BuffKeyword_buff_poised string
---@field BuffKeyword_buff_resilient string
---@field BuffKeyword_buff_revelation string
---@field BuffKeyword_buff_reverie string
---@field BuffKeyword_buff_rotten string
---@field BuffKeyword_buff_sourcecast string
---@field BuffKeyword_buff_swordIntent string
---@field BuffKeyword_buff_synergies string
---@field BuffKeyword_buff_thorns string
---@field BuffKeyword_buff_timelock string
---@field BuffKeyword_buff_timestop string
---@field BuffKeyword_buff_toxin string
---@field BuffKeyword_buff_unyielding string
---@field BuffKeyword_buff_vitality string
---@field BuffKeyword_buff_vulnerability string
---@field BuffKeyword_buff_weak string
---@field BuffKeyword_buff_weakness string
---@field EnchTag_enchtag_1 string
---@field EnchTag_enchtag_10 string
---@field EnchTag_enchtag_11 string
---@field EnchTag_enchtag_12 string
---@field EnchTag_enchtag_13 string
---@field EnchTag_enchtag_14 string
---@field EnchTag_enchtag_15 string
---@field EnchTag_enchtag_2 string
---@field EnchTag_enchtag_3 string
---@field EnchTag_enchtag_4 string
---@field EnchTag_enchtag_5 string
---@field EnchTag_enchtag_6 string
---@field EnchTag_enchtag_7 string
---@field EnchTag_enchtag_8 string
---@field EnchTag_enchtag_9 string
---@field FirstBless_1 string
---@field FirstBless_2 string
---@field FirstBless_3 string
---@field FirstBless_4 string
---@field FirstFight_1 string
---@field FirstFight_2 string
---@field FirstFight_3 string
---@field FirstFight_4 string
---@field FirstFight_5 string
---@field FirstFight_6 string
---@field FirstFight_7 string
---@field FirstFight_8 string
---@field FirstFight_9 string
---@field FirstShop_1 string
---@field FirstShop_2 string
---@field FirstShop_3 string
---@field FirstShop_4 string
---@field FirstShop_5 string
---@field FirstShop_6 string
---@field FirstShop_7 string
---@field FirstShop_8 string
---@field FirstTalk_1 string
---@field FirstTalk_10 string
---@field FirstTalk_11 string
---@field FirstTalk_12 string
---@field FirstTalk_2 string
---@field FirstTalk_3 string
---@field FirstTalk_4 string
---@field FirstTalk_5 string
---@field FirstTalk_6 string
---@field FirstTalk_7 string
---@field FirstTalk_8 string
---@field FirstTalk_9 string
---@field Hard_1 string
---@field Hard_10 string
---@field Hard_11 string
---@field Hard_12 string
---@field Hard_13 string
---@field Hard_14 string
---@field Hard_15 string
---@field Hard_16 string
---@field Hard_17 string
---@field Hard_18 string
---@field Hard_19 string
---@field Hard_2 string
---@field Hard_3 string
---@field Hard_4 string
---@field Hard_5 string
---@field Hard_6 string
---@field Hard_7 string
---@field Hard_8 string
---@field Hard_9 string
---@field Mapselect_1 string
---@field Mapselect_10 string
---@field Mapselect_11 string
---@field Mapselect_12 string
---@field Mapselect_13 string
---@field Mapselect_14 string
---@field Mapselect_2 string
---@field Mapselect_3 string
---@field Mapselect_4 string
---@field Mapselect_5 string
---@field Mapselect_6 string
---@field Mapselect_7 string
---@field Mapselect_8 string
---@field Mapselect_9 string
---@field PartnerCard_AswiftBlow string
---@field PartnerCard_Combing string
---@field PartnerCard_DeepGrows string
---@field PartnerCard_FuneralBell string
---@field PartnerCard_Hah string
---@field PartnerCard_QuadrupleHits string
---@field PartnerCard_attack string
---@field PartnerCard_defence string
---@field Partner_10001 string
---@field Partner_10002 string
---@field SecondAD_1 string
---@field SecondAD_2 string
---@field SecondAD_3 string
---@field SecondAD_4 string
---@field SecondAD_5 string
---@field SpecialBuff_AdvancedWoodenStakes string
---@field SpecialBuff_AllogeneicConcentric string
---@field SpecialBuff_BackToBasics string
---@field SpecialBuff_BlessedByHeaven string
---@field SpecialBuff_CalamityIncarnates string
---@field SpecialBuff_Crow string
---@field SpecialBuff_FortuneBoy string
---@field SpecialBuff_GiantDollBear string
---@field SpecialBuff_Hysteresis string
---@field SpecialBuff_ImmortalGodhead string
---@field SpecialBuff_Irritable string
---@field SpecialBuff_Law_Death string
---@field SpecialBuff_Law_Judgment string
---@field SpecialBuff_Law_Supreme string
---@field SpecialBuff_ManInTheMirror string
---@field SpecialBuff_Mimics string
---@field SpecialBuff_Musician string
---@field SpecialBuff_Phoenix string
---@field SpecialBuff_Priest string
---@field SpecialBuff_Restrain string
---@field SpecialBuff_Snitch string
---@field SpecialBuff_ThievesKing string
---@field SpecialBuff_ThirstForBlood string
---@field SpecialBuff_Transcendent string
---@field SpecialBuff_TrialsOfStrength string
---@field SpecialBuff_TrialsOfTenacity string
---@field SpecialBuff_TrialsOfWisdom string
---@field SpecialBuff_Twins string
---@field SpecialBuff_UnparalleledPower string
---@field SpecialBuff_WitchCultists string
---@field SpecialBuff_believer string
---@field SpecialBuff_biologicalInstinct string
---@field SpecialBuff_expiation string
---@field SpecialBuff_fluster string
---@field SpecialBuff_guiltless string
---@field SpecialBuff_hunting string
---@field SpecialBuff_meow string
---@field StartTutorial_1 string
---@field StartTutorial_2 string
---@field StartTutorial_3 string
---@field StartTutorial_4 string
---@field StartTutorial_5 string
---@field StartTutorial_6 string
---@field Blessing_1 string
---@field Blessing_10 string
---@field Blessing_101 string
---@field Blessing_102 string
---@field Blessing_103 string
---@field Blessing_104 string
---@field Blessing_105 string
---@field Blessing_106 string
---@field Blessing_107 string
---@field Blessing_108 string
---@field Blessing_109 string
---@field Blessing_11 string
---@field Blessing_110 string
---@field Blessing_111 string
---@field Blessing_112 string
---@field Blessing_113 string
---@field Blessing_114 string
---@field Blessing_115 string
---@field Blessing_116 string
---@field Blessing_12 string
---@field Blessing_14 string
---@field Blessing_15 string
---@field Blessing_19 string
---@field Blessing_2 string
---@field Blessing_20 string
---@field Blessing_21 string
---@field Blessing_22 string
---@field Blessing_23 string
---@field Blessing_24 string
---@field Blessing_3 string
---@field Blessing_32 string
---@field Blessing_33 string
---@field Blessing_34 string
---@field Blessing_35 string
---@field Blessing_36 string
---@field Blessing_37 string
---@field Blessing_4 string
---@field Blessing_5 string
---@field Blessing_6 string
---@field Blessing_7 string
---@field Blessing_8 string
---@field Blessing_9 string
---@field Blood_1 string
---@field Blood_10 string
---@field Blood_11 string
---@field Blood_12 string
---@field Blood_13 string
---@field Blood_2 string
---@field Blood_3 string
---@field Blood_4 string
---@field Blood_5 string
---@field Blood_6 string
---@field Blood_7 string
---@field Blood_8 string
---@field Blood_9 string
---@field Buff_BonePiercingSpike string
---@field Buff_ChaosMark string
---@field Buff_DoomPower string
---@field Buff_EnergyStorage string
---@field Buff_GuleiSummoningArt string
---@field Buff_Lilith_s_Pact string
---@field Buff_RegenerationPrayer string
---@field Buff_WailingWall string
---@field Buff_barkhide string
---@field Buff_biologicalArmor string
---@field Buff_bleeding string
---@field Buff_bloodriver string
---@field Buff_bloodsea string
---@field Buff_bloodwall string
---@field Buff_burn string
---@field Buff_chaos string
---@field Buff_chrysalis string
---@field Buff_contagion string
---@field Buff_counterattack string
---@field Buff_cripple string
---@field Buff_cycle string
---@field Buff_degrade string
---@field Buff_eclipse string
---@field Buff_elementalBody string
---@field Buff_elements string
---@field Buff_epiphany string
---@field Buff_evergreen string
---@field Buff_extraordinary string
---@field Buff_fast string
---@field Buff_fate string
---@field Buff_frenzy string
---@field Buff_immortal string
---@field Buff_impregnable string
---@field Buff_keenedge string
---@field Buff_lifelink string
---@field Buff_limitdamage string
---@field Buff_oblivion string
---@field Buff_obsidianKnight string
---@field Buff_obsidianQueen string
---@field Buff_obsidianSoldier string
---@field Buff_oniblood string
---@field Buff_poised string
---@field Buff_resilient string
---@field Buff_revelation string
---@field Buff_reverie string
---@field Buff_rotten string
---@field Buff_sourcecast string
---@field Buff_swordIntent string
---@field Buff_synergies string
---@field Buff_thorns string
---@field Buff_timelock string
---@field Buff_timestop string
---@field Buff_toxin string
---@field Buff_unyielding string
---@field Buff_vitality string
---@field Buff_vulnerability string
---@field Buff_weak string
---@field Buff_weakness string
---@field Burningcard_1 string
---@field Burningcard_2 string
---@field Burningcard_3 string
---@field Burningcard_4 string
---@field Card_1 string
---@field Card_10 string
---@field Card_11 string
---@field Card_12 string
---@field Card_13 string
---@field Card_14 string
---@field Card_15 string
---@field Card_16 string
---@field Card_17 string
---@field Card_18 string
---@field Card_2 string
---@field Card_3 string
---@field Card_4 string
---@field Card_5 string
---@field Card_6 string
---@field Card_7 string
---@field Card_8 string
---@field Card_9 string
---@field Career_1 string
---@field Career_2 string
---@field Career_3 string
---@field Career_4 string
---@field Career_5 string
---@field Career_6 string
---@field Careercard_1 string
---@field Careercard_2 string
---@field Careercard_3 string
---@field Careercard_4 string
---@field Careercard_5 string
---@field Careercard_6 string
---@field Careercard_7 string
---@field Coin_1 string
---@field Coin_2 string
---@field Coin_3 string
---@field Combo_1 string
---@field Combo_10 string
---@field Combo_11 string
---@field Combo_12 string
---@field Combo_13 string
---@field Combo_14 string
---@field Combo_15 string
---@field Combo_2 string
---@field Combo_3 string
---@field Combo_4 string
---@field Combo_5 string
---@field Combo_6 string
---@field Combo_7 string
---@field Combo_8 string
---@field Combo_9 string
---@field Counterattackcard_1 string
---@field Counterattackcard_10 string
---@field Counterattackcard_11 string
---@field Counterattackcard_12 string
---@field Counterattackcard_13 string
---@field Counterattackcard_2 string
---@field Counterattackcard_3 string
---@field Counterattackcard_4 string
---@field Counterattackcard_5 string
---@field Counterattackcard_6 string
---@field Counterattackcard_7 string
---@field Counterattackcard_8 string
---@field Counterattackcard_9 string
---@field Cursecard_1 string
---@field Cursecard_10 string
---@field Cursecard_11 string
---@field Cursecard_12 string
---@field Cursecard_2 string
---@field Cursecard_3 string
---@field Cursecard_4 string
---@field Cursecard_5 string
---@field Cursecard_6 string
---@field Cursecard_7 string
---@field Cursecard_8 string
---@field Cursecard_9 string
---@field Effect_damage string
---@field Elementscard_1 string
---@field Elementscard_10 string
---@field Elementscard_11 string
---@field Elementscard_12 string
---@field Elementscard_13 string
---@field Elementscard_2 string
---@field Elementscard_3 string
---@field Elementscard_4 string
---@field Elementscard_5 string
---@field Elementscard_6 string
---@field Elementscard_7 string
---@field Elementscard_8 string
---@field Elementscard_9 string
---@field Enchtag_1 string
---@field Enchtag_10 string
---@field Enchtag_11 string
---@field Enchtag_12 string
---@field Enchtag_13 string
---@field Enchtag_14 string
---@field Enchtag_15 string
---@field Enchtag_2 string
---@field Enchtag_3 string
---@field Enchtag_4 string
---@field Enchtag_5 string
---@field Enchtag_6 string
---@field Enchtag_7 string
---@field Enchtag_8 string
---@field Enchtag_9 string
---@field Ending_1 string
---@field Ending_2 string
---@field Ending_3 string
---@field Ending_4 string
---@field Ending_5 string
---@field Enemy_10001 string
---@field Enemy_10002 string
---@field Enemy_10003 string
---@field Enemy_10004 string
---@field Enemy_10005 string
---@field Enemy_10006 string
---@field Enemy_10007 string
---@field Enemy_10008 string
---@field Enemy_10009 string
---@field Enemy_10010 string
---@field Enemy_10011 string
---@field Enemy_10013 string
---@field Enemy_10014 string
---@field Enemy_10015 string
---@field Enemy_10016 string
---@field Enemy_10017 string
---@field Enemy_10018 string
---@field Enemy_10019 string
---@field Enemy_10020 string
---@field Enemy_10021 string
---@field Enemy_10022 string
---@field Enemy_10023 string
---@field Enemy_10024 string
---@field Enemy_10025 string
---@field Enemy_10026 string
---@field Enemy_10027 string
---@field Enemy_10028 string
---@field Enemy_10029 string
---@field Enemy_10030 string
---@field Enemy_10031 string
---@field Enemy_10032 string
---@field Enemy_10033 string
---@field Enemy_10034 string
---@field Enemy_10035 string
---@field Enemy_10036 string
---@field Enemy_10037 string
---@field Enemy_10038 string
---@field Enemy_10039 string
---@field Enemy_10040 string
---@field Enemy_10041 string
---@field Enemy_10042 string
---@field Enemy_10043 string
---@field Enemy_10044 string
---@field Enemy_10045 string
---@field Enemy_10046 string
---@field Enemy_10047 string
---@field Enemy_99999 string
---@field Enemycard_AddWisdom string
---@field Enemycard_Charge1 string
---@field Enemycard_Charge2 string
---@field Enemycard_Come string
---@field Enemycard_Dragon_sMajesty string
---@field Enemycard_EvilCurse string
---@field Enemycard_FallenDragon string
---@field Enemycard_FiveHit string
---@field Enemycard_FullSupport string
---@field Enemycard_GiantClawStrike string
---@field Enemycard_HighFly string
---@field Enemycard_IceShield string
---@field Enemycard_Licking string
---@field Enemycard_LimePowder string
---@field Enemycard_MT1 string
---@field Enemycard_MT2 string
---@field Enemycard_MakeIneffectiveRays1 string
---@field Enemycard_MakeIneffectiveRays2 string
---@field Enemycard_NerveReflexes string
---@field Enemycard_NeverDead string
---@field Enemycard_Observe string
---@field Enemycard_OrdinaryFiveHit string
---@field Enemycard_OrdinaryHit string
---@field Enemycard_OverrunWorkouts string
---@field Enemycard_PlugCards1 string
---@field Enemycard_PlugCards2 string
---@field Enemycard_PlugCards3 string
---@field Enemycard_PoisonThrowing string
---@field Enemycard_PowerlessCurse string
---@field Enemycard_QuadrupleHits string
---@field Enemycard_SpreadWings string
---@field Enemycard_SuperFireBall string
---@field Enemycard_Thieves string
---@field Enemycard_Toxin1 string
---@field Enemycard_Toxin2 string
---@field Enemycard_Toxin3 string
---@field Enemycard_Toxin4 string
---@field Enemycard_VenomSpray string
---@field Enemycard_Wake string
---@field Enemycard_Weak string
---@field Enemycard_WeakLight string
---@field Enemycard_WhereverYouGo string
---@field Enemycard_Witness string
---@field Enemycard_burn string
---@field Enemycard_burn1 string
---@field Enemycard_burn2 string
---@field Enemycard_charmed string
---@field Enemycard_defence string
---@field Enemycard_fearless string
---@field Enemycard_foraging string
---@field Enemycard_obtainMoney string
---@field Enemycard_psychologicalShock string
---@field Enemycard_rejuvenation string
---@field Enemycard_specialAttack string
---@field Enemycard_thief string
---@field Enemycard_vulnerabilityLight string
---@field Event_1 string
---@field Event_10 string
---@field Event_1000 string
---@field Event_1001 string
---@field Event_11 string
---@field Event_12 string
---@field Event_13 string
---@field Event_14 string
---@field Event_15 string
---@field Event_16 string
---@field Event_17 string
---@field Event_18 string
---@field Event_19 string
---@field Event_2 string
---@field Event_20 string
---@field Event_21 string
---@field Event_3 string
---@field Event_4 string
---@field Event_6 string
---@field Event_7 string
---@field Event_8 string
---@field Event_9 string
---@field Event_999 string
---@field Event_Sub_1000_2 string
---@field Event_Sub_6_2 string
---@field Event_Sub_999_2 string
---@field Event_Sub_9_2 string
---@field Food_1 string
---@field Food_10 string
---@field Food_11 string
---@field Food_12 string
---@field Food_13 string
---@field Food_14 string
---@field Food_15 string
---@field Food_16 string
---@field Food_2 string
---@field Food_3 string
---@field Food_4 string
---@field Food_5 string
---@field Food_6 string
---@field Food_7 string
---@field Food_8 string
---@field Food_9 string
---@field Healcard_1 string
---@field Healcard_2 string
---@field Healcard_3 string
---@field Healcard_4 string
---@field Healcard_5 string
---@field Healcard_6 string
---@field Healcard_7 string
---@field Healcard_8 string
---@field Healcard_9 string
---@field Level_0 string
---@field Level_10001 string
---@field Level_10002 string
---@field Level_10003 string
---@field Level_10004 string
---@field Level_10005 string
---@field Level_10006 string
---@field Level_10007 string
---@field Level_10008 string
---@field Level_10009 string
---@field Level_10010 string
---@field Level_10011 string
---@field Level_10013 string
---@field Level_10014 string
---@field Level_10015 string
---@field Level_10016 string
---@field Level_10017 string
---@field Level_10018 string
---@field Level_10019 string
---@field Level_10020 string
---@field Level_10021 string
---@field Level_10022 string
---@field Level_10024 string
---@field Level_10025 string
---@field Level_10026 string
---@field Level_10027 string
---@field Level_10028 string
---@field Level_10029 string
---@field Level_10030 string
---@field Level_10031 string
---@field Level_10032 string
---@field Level_10033 string
---@field Level_10034 string
---@field Level_10035 string
---@field Level_10036 string
---@field Level_10037 string
---@field Level_10038 string
---@field Level_10039 string
---@field Level_10040 string
---@field Level_10041 string
---@field Level_10042 string
---@field Level_10043 string
---@field Level_10044 string
---@field Level_10045 string
---@field Level_10046 string
---@field Level_99999 string
---@field Luckycard_1 string
---@field Luckycard_10 string
---@field Luckycard_11 string
---@field Luckycard_12 string
---@field Luckycard_2 string
---@field Luckycard_3 string
---@field Luckycard_4 string
---@field Luckycard_5 string
---@field Luckycard_6 string
---@field Luckycard_7 string
---@field Luckycard_8 string
---@field Luckycard_9 string
---@field Map_0 string
---@field Map_1 string
---@field Map_10 string
---@field Map_11 string
---@field Map_12 string
---@field Map_13 string
---@field Map_15 string
---@field Map_16 string
---@field Map_17 string
---@field Map_18 string
---@field Map_19 string
---@field Map_2 string
---@field Map_20 string
---@field Map_21 string
---@field Map_22 string
---@field Map_23 string
---@field Map_24 string
---@field Map_25 string
---@field Map_26 string
---@field Map_27 string
---@field Map_28 string
---@field Map_29 string
---@field Map_3 string
---@field Map_30 string
---@field Map_31 string
---@field Map_32 string
---@field Map_33 string
---@field Map_34 string
---@field Map_35 string
---@field Map_36 string
---@field Map_37 string
---@field Map_38 string
---@field Map_39 string
---@field Map_4 string
---@field Map_40 string
---@field Map_41 string
---@field Map_42 string
---@field Map_43 string
---@field Map_44 string
---@field Map_45 string
---@field Map_46 string
---@field Map_47 string
---@field Map_48 string
---@field Map_49 string
---@field Map_5 string
---@field Map_50 string
---@field Map_51 string
---@field Map_6 string
---@field Map_7 string
---@field Map_8 string
---@field Map_9 string
---@field Materials_1 string
---@field Materials_10 string
---@field Materials_11 string
---@field Materials_12 string
---@field Materials_13 string
---@field Materials_14 string
---@field Materials_15 string
---@field Materials_16 string
---@field Materials_17 string
---@field Materials_18 string
---@field Materials_19 string
---@field Materials_2 string
---@field Materials_20 string
---@field Materials_21 string
---@field Materials_22 string
---@field Materials_23 string
---@field Materials_24 string
---@field Materials_25 string
---@field Materials_26 string
---@field Materials_27 string
---@field Materials_28 string
---@field Materials_29 string
---@field Materials_3 string
---@field Materials_30 string
---@field Materials_4 string
---@field Materials_5 string
---@field Materials_6 string
---@field Materials_7 string
---@field Materials_8 string
---@field Materials_9 string
---@field Nocard_1 string
---@field Nocard_2 string
---@field Nocard_3 string
---@field Nocard_4 string
---@field Onlinecard_1 string
---@field Onlinecard_2 string
---@field Onlinecard_3 string
---@field Onlinecard_4 string
---@field Onlinecard_5 string
---@field Outsideshop_1 string
---@field Outsideshop_10 string
---@field Outsideshop_11 string
---@field Outsideshop_12 string
---@field Outsideshop_13 string
---@field Outsideshop_14 string
---@field Outsideshop_15 string
---@field Outsideshop_16 string
---@field Outsideshop_2 string
---@field Outsideshop_3 string
---@field Outsideshop_4 string
---@field Outsideshop_5 string
---@field Outsideshop_6 string
---@field Outsideshop_7 string
---@field Outsideshop_8 string
---@field Outsideshop_9 string
---@field Perceivecard_1 string
---@field Perceivecard_3 string
---@field Perceivecard_5 string
---@field Perceivecard_6 string
---@field Relic_1 string
---@field Relic_10 string
---@field Relic_11 string
---@field Relic_12 string
---@field Relic_13 string
---@field Relic_14 string
---@field Relic_15 string
---@field Relic_16 string
---@field Relic_17 string
---@field Relic_18 string
---@field Relic_19 string
---@field Relic_2 string
---@field Relic_20 string
---@field Relic_21 string
---@field Relic_22 string
---@field Relic_23 string
---@field Relic_24 string
---@field Relic_25 string
---@field Relic_26 string
---@field Relic_27 string
---@field Relic_28 string
---@field Relic_29 string
---@field Relic_3 string
---@field Relic_30 string
---@field Relic_31 string
---@field Relic_32 string
---@field Relic_33 string
---@field Relic_34 string
---@field Relic_35 string
---@field Relic_36 string
---@field Relic_37 string
---@field Relic_38 string
---@field Relic_39 string
---@field Relic_4 string
---@field Relic_40 string
---@field Relic_41 string
---@field Relic_42 string
---@field Relic_43 string
---@field Relic_44 string
---@field Relic_45 string
---@field Relic_46 string
---@field Relic_47 string
---@field Relic_48 string
---@field Relic_49 string
---@field Relic_5 string
---@field Relic_50 string
---@field Relic_51 string
---@field Relic_52 string
---@field Relic_53 string
---@field Relic_54 string
---@field Relic_55 string
---@field Relic_56 string
---@field Relic_57 string
---@field Relic_58 string
---@field Relic_59 string
---@field Relic_6 string
---@field Relic_60 string
---@field Relic_61 string
---@field Relic_62 string
---@field Relic_63 string
---@field Relic_64 string
---@field Relic_65 string
---@field Relic_66 string
---@field Relic_67 string
---@field Relic_68 string
---@field Relic_69 string
---@field Relic_7 string
---@field Relic_70 string
---@field Relic_71 string
---@field Relic_72 string
---@field Relic_73 string
---@field Relic_74 string
---@field Relic_75 string
---@field Relic_76 string
---@field Relic_77 string
---@field Relic_78 string
---@field Relic_79 string
---@field Relic_8 string
---@field Relic_80 string
---@field Relic_9 string
---@field Role_Adele string
---@field Role_Krisna string
---@field Role_amelia string
---@field Role_narrator string
---@field Shadowchat1_1 string
---@field Shadowchat1_10 string
---@field Shadowchat1_2 string
---@field Shadowchat1_3 string
---@field Shadowchat1_4 string
---@field Shadowchat1_5 string
---@field Shadowchat1_6 string
---@field Shadowchat1_7 string
---@field Shadowchat1_8 string
---@field Shadowchat1_9 string
---@field TestTask_1 string
---@field Timekeeper_1 string
---@field Timekeeper_10 string
---@field Timekeeper_11 string
---@field Timekeeper_12 string
---@field Timekeeper_13 string
---@field Timekeeper_14 string
---@field Timekeeper_15 string
---@field Timekeeper_16 string
---@field Timekeeper_17 string
---@field Timekeeper_18 string
---@field Timekeeper_2 string
---@field Timekeeper_3 string
---@field Timekeeper_4 string
---@field Timekeeper_5 string
---@field Timekeeper_6 string
---@field Timekeeper_7 string
---@field Timekeeper_8 string
---@field Timekeeper_9 string
---@field Tutorial_Action string
---@field Tutorial_Action_card string
---@field Tutorial_Announcement string
---@field Tutorial_Base_attributes string
---@field Tutorial_Break string
---@field Tutorial_Buff string
---@field Tutorial_CardEditor string
---@field Tutorial_Defence string
---@field Tutorial_DesChoice string
---@field Tutorial_DesType string
---@field Tutorial_Difficulty_selection string
---@field Tutorial_Disaster string
---@field Tutorial_Event string
---@field Tutorial_Function_bar string
---@field Tutorial_Hp string
---@field Tutorial_Illustrated_book string
---@field Tutorial_Magic_power string
---@field Tutorial_Monetary_resources string
---@field Tutorial_Outside_upgrades string
---@field Tutorial_Piles_fold_piles string
---@field Tutorial_Relic string
---@field Tutorial_Round string
---@field Tutorial_SafeBox string
---@field Tutorial_Shop string
---@field Tutorial_Test1 string
---@field Tutorial_Test2 string
---@field Tutorial_Toughness string
---@field Universalcard_1 string
---@field Universalcard_10 string
---@field Universalcard_11 string
---@field Universalcard_12 string
---@field Universalcard_13 string
---@field Universalcard_14 string
---@field Universalcard_15 string
---@field Universalcard_16 string
---@field Universalcard_17 string
---@field Universalcard_18 string
---@field Universalcard_19 string
---@field Universalcard_2 string
---@field Universalcard_20 string
---@field Universalcard_3 string
---@field Universalcard_4 string
---@field Universalcard_5 string
---@field Universalcard_6 string
---@field Universalcard_7 string
---@field Universalcard_8 string
---@field Universalcard_9 string
DataIds = {}
---@alias CS.DataIds DataIds
CS.DataIds = DataIds


---@class ModConfig : System.Object
---@field DirectoryName string
---@field ModName string
---@field ModVersion string
---@field ModAuthor string
---@field ModDescription string
---@field IconPath string
---@field Enabled boolean
---@field Dependencies System.Collections.Generic.List
---@field ModId string
ModConfig = {}
---@alias CS.ModConfig ModConfig
CS.ModConfig = ModConfig

---@return ModConfig
function ModConfig.New() end
---@param id string
---@param newData System.Collections.Generic.Dictionary
function ModConfig:SetDataConfig(id, newData) end
---@param id string
---@param key string
---@param value string
function ModConfig:ModifyDataConfig(id, key, value) end
---@param originalPath string
---@param newPath string
function ModConfig:RedirectSourcePath(originalPath, newPath) end
---@param methodName string
---@param _function XLua.LuaFunction
function ModConfig:AddDynamicMethod(methodName, _function) end
---@param typeDotMethod string
---@param _function XLua.LuaFunction
function ModConfig:AddMethodHookBefore(typeDotMethod, _function) end
---@param typeDotMethod string
---@param _function XLua.LuaFunction
function ModConfig:AddMethodHookAfter(typeDotMethod, _function) end

---@class ObjectPool : Singleton
---@field Instance ObjectPool -- infered from Singleton`1[ObjectPool]
---@field GetInstance ObjectPool -- infered from Singleton`1[ObjectPool]
ObjectPool = {}
---@alias CS.ObjectPool ObjectPool
CS.ObjectPool = ObjectPool

---@return ObjectPool
function ObjectPool.New() end
---@param prefab UnityEngine.GameObject
---@param parent UnityEngine.Transform
---@return UnityEngine.GameObject
function ObjectPool:Get(prefab, parent) end
---@param prefab UnityEngine.GameObject
---@param count number
---@param batchSize number
---@param cancellationToken System.Threading.CancellationToken
---@return Cysharp.Threading.Tasks.UniTask
function ObjectPool:PreloadAsync(prefab, count, batchSize, cancellationToken) end
---@param obj UnityEngine.GameObject
function ObjectPool:Release(obj) end
function ObjectPool:Clear() end

---@class RandomPool : System.Object
RandomPool = {}
---@alias CS.RandomPool RandomPool
CS.RandomPool = RandomPool

---@param datas System.Collections.Generic.List
---@param fromDice Dice
---@return RandomPool
function RandomPool.New(datas, fromDice) end
---@param property string
---@param count number
---@param propertyWeightDic System.Collections.Generic.Dictionary
---@return System.Collections.Generic.List
function RandomPool:DrawByProperty(property, count, propertyWeightDic) end
---@param count number
---@param typeWeightDic System.Collections.Generic.Dictionary
---@return System.Collections.Generic.List
function RandomPool:DrawByType(count, typeWeightDic) end
---@param count number
---@param typeWeightDic System.Collections.Generic.Dictionary
---@return System.Collections.Generic.List
function RandomPool:DrawByNote(count, typeWeightDic) end
---@param count number
---@return System.Collections.Generic.List
function RandomPool:DrawByCount(count) end
---@param count number
---@return System.Collections.Generic.List
function RandomPool:DrawByRarity(count) end
---@param count number
---@param tagWeightDic System.Collections.Generic.Dictionary
---@return System.Collections.Generic.List
function RandomPool:DrawByTag(count, tagWeightDic) end

---@class GameRuntimeData : Singleton
---@field savePath string
---@field key string
---@field iv string
---@field isEncrypted boolean
---@field MaxExp number
---@field md5 string
---@field playCount number
---@field Level Loxodon.Framework.Obfuscation.ObfuscatedInt
---@field Exp Loxodon.Framework.Obfuscation.ObfuscatedInt
---@field Gain System.Collections.Generic.Dictionary
---@field roleTable RoleTable
---@field TutorialData System.Collections.Generic.Dictionary
---@field IsTutorialCompleted System.Collections.Generic.Dictionary
---@field truth Loxodon.Framework.Obfuscation.ObfuscatedInt
---@field PlayerId string
---@field Money number
---@field UseSc System.Collections.Generic.List
---@field UnLockDataConfigs System.Collections.Generic.HashSet
---@field achivementTable AchivementTable
---@field BuyedItems System.Collections.Generic.Dictionary
---@field Items System.Collections.ObjectModel.ObservableCollection
---@field CardData System.Collections.Generic.List
---@field RelicData System.Collections.Generic.List
---@field MeetEvents System.Collections.Generic.Dictionary
---@field settingTable SettingTable
---@field Saves System.Collections.Generic.List
---@field Truth Loxodon.Framework.Obfuscation.ObfuscatedInt
---@field Instance GameRuntimeData -- infered from Singleton`1[GameRuntimeData]
---@field GetInstance GameRuntimeData -- infered from Singleton`1[GameRuntimeData]
GameRuntimeData = {}
---@alias CS.GameRuntimeData GameRuntimeData
CS.GameRuntimeData = GameRuntimeData

---@return GameRuntimeData
function GameRuntimeData.New() end
---@overload fun(path: string) : GameRuntimeData
function GameRuntimeData:Load() end
---@param str string
---@return string
function GameRuntimeData.Md5(str) end
function GameRuntimeData:Init() end
---@param id string
---@param type string
function GameRuntimeData:AddItem(id, type) end
function GameRuntimeData:Save() end
---@param data GameRuntimeData
---@return boolean
function GameRuntimeData:SaveDataCheck(data) end
---@param Id string
---@return boolean
function GameRuntimeData:IsLocked(Id) end

---@class ObfuscateIntConverter : Newtonsoft.Json.JsonConverter
ObfuscateIntConverter = {}
---@alias CS.ObfuscateIntConverter ObfuscateIntConverter
CS.ObfuscateIntConverter = ObfuscateIntConverter

---@return ObfuscateIntConverter
function ObfuscateIntConverter.New() end
---@param writer Newtonsoft.Json.JsonWriter
---@param value Loxodon.Framework.Obfuscation.ObfuscatedInt
---@param serializer Newtonsoft.Json.JsonSerializer
function ObfuscateIntConverter:WriteJson(writer, value, serializer) end
---@param reader Newtonsoft.Json.JsonReader
---@param objectType System.Type
---@param existingValue Loxodon.Framework.Obfuscation.ObfuscatedInt
---@param hasExistingValue boolean
---@param serializer Newtonsoft.Json.JsonSerializer
---@return Loxodon.Framework.Obfuscation.ObfuscatedInt
function ObfuscateIntConverter:ReadJson(reader, objectType, existingValue, hasExistingValue, serializer) end

---@class ScriptExecutor : System.Object
---@field luaEnv XLua.LuaEnv
---@field luaTable XLua.LuaTable
---@field GetStatus System.Collections.Generic.Dictionary
---@field handlers System.Collections.Generic.List
---@field status IStatusManager
---@field Self IStatusManager
---@field Object System.Collections.Generic.List
---@field dataConfig IDataConfig
---@field Target IStatusManager
---@field ScriptDict System.Collections.Generic.Dictionary
---@field Id string
---@field ValueDice ScriptExecutor.DiceWrapper
---@field CheckDice ScriptExecutor.DiceWrapper
---@field DefaultDice ScriptExecutor.DiceWrapper
---@field Vars System.Collections.Generic.IDictionary
---@field HandCard System.Collections.Generic.List
---@field CompiledSuccessfully boolean
ScriptExecutor = {}
---@alias CS.ScriptExecutor ScriptExecutor
CS.ScriptExecutor = ScriptExecutor

---@param val string
function ScriptExecutor:SetHp(val) end
---@param val string
function ScriptExecutor:SetMaxHp(val) end
---@param val string
function ScriptExecutor:ChangeHp(val) end
---@param val string
function ScriptExecutor:ChangeMaxHp(val) end
---@param buffId string
---@param level string
function ScriptExecutor:AddBuff(buffId, level) end
---@param buffId string
function ScriptExecutor:RemoveBuff(buffId) end
---@param buffId string
---@param eventName string
function ScriptExecutor:RunImmediately(buffId, eventName) end
---@param value string
function ScriptExecutor:Resurrection(value) end
---@param val string
function ScriptExecutor:ChangeDefence(val) end
---@param val string
function ScriptExecutor:SetPower(val) end
---@param val string
function ScriptExecutor:ChangeMaxPower(val) end
function ScriptExecutor:ChangeRound() end
---@param index string
function ScriptExecutor:DoAction(index) end
---@param val string
---@param good string
function ScriptExecutor:RemoveBadBuff(val, good) end
---@param obj string
function ScriptExecutor:RemoveAllBadBuff(obj) end
function ScriptExecutor:RemoveAllBuff() end
---@param count string
---@param tag string
function ScriptExecutor:AddCardByCardList(count, tag) end
---@param count string
---@param tag string
function ScriptExecutor:AddCardByUsedCardList(count, tag) end
---@param id string
function ScriptExecutor:RandomAddCard(id) end
---@param val string
function ScriptExecutor:ChangeMoney(val) end
---@param count string
function ScriptExecutor:AddAction(count) end
function ScriptExecutor:ShuffleDeck() end
---@param val string
function ScriptExecutor:ChangeCardTop(val) end
---@param count string
---@param tag string
function ScriptExecutor:GetCardByTag(count, tag) end
---@param id string
function ScriptExecutor:AddCard(id) end
---@param Id string
function ScriptExecutor:ChangeCareer(Id) end
---@param eventName string
---@param script System.Action | function
function ScriptExecutor:AddEvent(eventName, script) end
---@param eventName string
---@param script System.Action | function
function ScriptExecutor:AddTempEvent(eventName, script) end
---@param varName string
---@param value string
function ScriptExecutor:ChangeDynamicVar(varName, value) end
---@param varName string
---@param value string
function ScriptExecutor:ChangeDynamicVarPercent(varName, value) end
---@param args System.Object[]
function ScriptExecutor:Undone(args) end
function ScriptExecutor:DesEnemyAction() end
---@return FightType
function ScriptExecutor:returnFightType() end
---@param fromdata IDataConfig
function ScriptExecutor:BurnCardByData(fromdata) end
function ScriptExecutor:UpdateRelicShow() end
---@return boolean
function ScriptExecutor:ComboCheck() end
function ScriptExecutor:EndTheGame() end
function ScriptExecutor:EscapeFight() end
function ScriptExecutor:WinTheFight() end
---@param type FightType
function ScriptExecutor:ChangeType(type) end
---@param count string
function ScriptExecutor:RandomAddBuff(count) end
---@param count string
function ScriptExecutor:RandomAddBuffAndAbility(count) end
function ScriptExecutor:RandomAddGoodBuff() end
---@param id string
function ScriptExecutor:AddEnemy(id) end
---@return string
function ScriptExecutor:atk() end
---@param eventName string
---@param action System.Action | function
function ScriptExecutor:AddBaseEvent(eventName, action) end
---@param status IStatusManager
---@return Enemy
function ScriptExecutor:GetEnemy(status) end
---@return string
function ScriptExecutor:def() end
function ScriptExecutor:CallEffect() end
---@param val string
---@param fromDataId string
---@param fromId string
---@param damagetype string
function ScriptExecutor:OnlineDamage(val, fromDataId, fromId, damagetype) end
---@param val string
---@param damagetype string
function ScriptExecutor:Damage(val, damagetype) end
---@param type string
---@param val string
function ScriptExecutor:ChangeVars(type, val) end
---@param val string
function ScriptExecutor:DrawCount(val) end
---@param val string
function ScriptExecutor:ChangePower(val) end
---@param val string
---@param type string
function ScriptExecutor:ThrowCard(val, type) end
---@param val string
---@param type string
function ScriptExecutor:BurnCard(val, type) end
---@param Minrarity string
---@param Maxrairty string
---@return System.Collections.Generic.List
function ScriptExecutor:GetcardsByRarity(Minrarity, Maxrairty) end
---@return DataConfig
function ScriptExecutor:EnchGetCard() end
---@param card IDataConfig
---@return DataConfig
function ScriptExecutor:CardGetEnch(card) end
---@param count string
---@param source System.Collections.Generic.List
---@param tag string
---@return Cysharp.Threading.Tasks.UniTask
function ScriptExecutor:AddCardByDeck(count, source, tag) end
---@param count string
---@param source System.Collections.Generic.List
function ScriptExecutor:SelectCardAndAddTag(count, source) end
---@param id string
function ScriptExecutor:AddCardById(id) end
---@param searchId string
function ScriptExecutor:SetStatusById(searchId) end
---@overload fun(self: ScriptExecutor, filter: string) : System.Collections.Generic.List
---@overload fun(self: ScriptExecutor, statuses: System.Collections.Generic.IEnumerable) : System.Collections.Generic.List
---@param statuses ZLinq.ValueEnumerable
---@return System.Collections.Generic.List
function ScriptExecutor:SetStatus(statuses) end
---@param status IStatusManager
---@param effectName string
function ScriptExecutor:ProcessEffect(status, effectName) end
---@param percent number
---@param action System.Action | function
function ScriptExecutor:DiceCheck(percent, action) end
---@param action System.Action | function
function ScriptExecutor:ForAllStatus(action) end
---@param content string
function ScriptExecutor:Log(content) end
---@overload fun(self: ScriptExecutor, propertyName: string, action: System.Action | function)
---@param propertyName string
---@param action System.Action | function
function ScriptExecutor:WatchRoleTable(propertyName, action) end
---@overload fun(self: ScriptExecutor, index: string, type: string, value: string)
---@overload fun(self: ScriptExecutor, index: string, type: string, value: number)
---@overload fun(self: ScriptExecutor, index: string, type: string, value: number)
---@param index string
---@param type string
---@param value number
function ScriptExecutor:AddDescription(index, type, value) end
---@param index string
---@return string
function ScriptExecutor:GetDesValue(index) end
---@param scriptId string
---@param scriptName string
function ScriptExecutor:CallScript(scriptId, scriptName) end
---@param ScriptName string
---@param options Microsoft.CodeAnalysis.Scripting.ScriptOptions
function ScriptExecutor:PreCompileScripts(ScriptName, options) end
---@param ScriptsName string
function ScriptExecutor:RunScript(ScriptsName) end
function ScriptExecutor:Clear() end
---@param eventName string
---@param parameters System.String[]
---@return boolean
function ScriptExecutor:TrySendOnlineEvent(eventName, parameters) end
---@param eventName string
---@param datafrom System.Action | function
function ScriptExecutor:AddEvent_HurtData(eventName, datafrom) end
---@param eventName string
---@param datafrom System.Action | function
function ScriptExecutor:AddTempEvent_HurtData(eventName, datafrom) end
---@param eventName string
---@param datafrom System.Action | function
function ScriptExecutor:AddEvent_ActionData(eventName, datafrom) end
---@param eventName string
---@param datafrom System.Action | function
function ScriptExecutor:AddTempEvent_ActionData(eventName, datafrom) end
---@param eventName string
---@param datafrom System.Action | function
function ScriptExecutor:AddEvent_DamageData(eventName, datafrom) end
---@param eventName string
---@param datafrom System.Action | function
function ScriptExecutor:AddTempEvent_DamageData(eventName, datafrom) end
---@param eventName string
---@param datafrom System.Action | function
function ScriptExecutor:AddEvent_NewEnemyData(eventName, datafrom) end
---@param eventName string
---@param datafrom System.Action | function
function ScriptExecutor:AddTempEvent_NewEnemyData(eventName, datafrom) end

---@class ScriptExecutor.DiceWrapper : System.Object
---@field OnRoll System.Action | function
---@field result Dice.State
ScriptExecutor.DiceWrapper = {}
---@alias CS.ScriptExecutor.DiceWrapper ScriptExecutor.DiceWrapper
CS.ScriptExecutor.DiceWrapper = ScriptExecutor.DiceWrapper

---@param dice Dice
---@return ScriptExecutor.DiceWrapper
function ScriptExecutor.DiceWrapper.New(dice) end
---@param Target System.Nullable
---@return Dice.State
function ScriptExecutor.DiceWrapper:InternalRoll(Target) end
---@param Target System.Nullable
---@return Dice.State
function ScriptExecutor.DiceWrapper:Roll(Target) end
---@param min number
---@param max number
---@return Dice
function ScriptExecutor.DiceWrapper:WithRange(min, max) end

---@class ScriptExecutor.PlayerInfo : System.Object
---@field TrueCount number
---@field MaxHp number
---@field Hp number
---@field Power number
---@field MaxPower number
---@field RelicCount number
---@field CardTopCount number
---@field enemylevel number
---@field enemyCount number
---@field usedCardListCount number
---@field CardTotalCount number
---@field CardCount number
---@field BlessingCount number
---@field Money number
---@field MoneyMultiplier number
---@field Level number
---@field LastCard IDataConfig
---@field Win FightType
---@field Loss FightType
---@field Enemy FightType
---@field Pattern FightType
---@field Player FightType
---@field CardList System.Collections.Generic.List
---@field BlessingList System.Collections.Generic.List
---@field RelicList System.Collections.Generic.List
---@field Reward number
---@field Strength number
---@field DefaultRoll number
---@field Lucky number
---@field Wisdom number
---@field Perceive number
---@field TempStrength number
---@field TempLucky number
---@field TempWisdom number
---@field SkillTime System.Collections.Generic.Dictionary
---@field TempPerceive number
---@field PlayerName string
---@field SpecialVars System.Collections.Generic.Dictionary
ScriptExecutor.PlayerInfo = {}
---@alias CS.ScriptExecutor.PlayerInfo ScriptExecutor.PlayerInfo
CS.ScriptExecutor.PlayerInfo = ScriptExecutor.PlayerInfo

---@return string
function ScriptExecutor.PlayerInfo.GetTagDiff() end
---@param text string
function ScriptExecutor.PlayerInfo.ChangeEventSubtip(text) end
function ScriptExecutor.PlayerInfo.GiveWin() end
---@param instanceId string
function ScriptExecutor.PlayerInfo.CopyCard(instanceId) end
---@param instanceId string
function ScriptExecutor.PlayerInfo.CopyBless(instanceId) end
---@param instanceId string
function ScriptExecutor.PlayerInfo.CopyRelic(instanceId) end
---@param id string
function ScriptExecutor.PlayerInfo.AddCard(id) end
---@param id string
function ScriptExecutor.PlayerInfo.RemoveCard(id) end
---@param id string
function ScriptExecutor.PlayerInfo.AddRelic(id) end
---@param id string
function ScriptExecutor.PlayerInfo.RemoveRelic(id) end
---@param id string
function ScriptExecutor.PlayerInfo.AddBless(id) end
---@param id string
function ScriptExecutor.PlayerInfo.RemoveBless(id) end
---@param count string
function ScriptExecutor.PlayerInfo.RandomAddBless(count) end
---@param count string
function ScriptExecutor.PlayerInfo.RandomAddRelic(count) end
---@param count string
function ScriptExecutor.PlayerInfo.Goodbless(count) end
---@param count string
function ScriptExecutor.PlayerInfo.RandomAddCard(count) end
---@param count string
function ScriptExecutor.PlayerInfo.RandomAddCardByDeck(count) end
---@param count string
function ScriptExecutor.PlayerInfo.RandomRemoveCard(count) end
---@param count string
function ScriptExecutor.PlayerInfo.RandomRemoveBless(count) end
---@param count string
function ScriptExecutor.PlayerInfo.RandomRemoveRelic(count) end
---@param type string
---@param id2 string
function ScriptExecutor.PlayerInfo.StartLevel(type, id2) end
function ScriptExecutor.PlayerInfo.ShowReward() end
---@param key string
---@param value string
---@return string
function ScriptExecutor.PlayerInfo.SetGameVar(key, value) end
---@param key string
---@return string
function ScriptExecutor.PlayerInfo.GetGameVar(key) end
---@param id string
function ScriptExecutor.PlayerInfo.ContinueEvent(id) end
function ScriptExecutor.PlayerInfo.GameOver() end
---@param id string
function ScriptExecutor.PlayerInfo.ShowDialogue(id) end
---@param name string
---@param action System.Action | function
---@param obj System.Object
function ScriptExecutor.PlayerInfo.AddEvent(name, action, obj) end
function ScriptExecutor.PlayerInfo.EndDialogue() end
---@param id string
function ScriptExecutor.PlayerInfo.ShowDialogueBox(id) end
---@param options System.ValueTuple
function ScriptExecutor.PlayerInfo.ShowOptions(options) end
---@param name string
function ScriptExecutor.PlayerInfo.EventTrigger(name) end
---@param lists System.String[]
---@return string
function ScriptExecutor.PlayerInfo.RandomSelect(lists) end
function ScriptExecutor.PlayerInfo.EventTryChangeMap() end
function ScriptExecutor.PlayerInfo.AnnounceEventDone() end
---@return GameRuntimeData
function ScriptExecutor.PlayerInfo.Getsave() end
---@param itemId string
---@param type string
function ScriptExecutor.PlayerInfo.AddItem(itemId, type) end
function ScriptExecutor.PlayerInfo.EndEvent() end
---@param index string
function ScriptExecutor.PlayerInfo.LockChoice(index) end
---@return System.Collections.Generic.IDictionary
function ScriptExecutor.PlayerInfo.GetCareer() end
---@param value string
function ScriptExecutor.PlayerInfo.ChangeSelected(value) end
---@param value string
function ScriptExecutor.PlayerInfo.ChangeAllVars(value) end
---@param id string
function ScriptExecutor.PlayerInfo.UnlockItem(id) end
---@param text string
function ScriptExecutor.PlayerInfo.ShowCaption(text) end
function ScriptExecutor.PlayerInfo.QuitAndDeleteSave() end

---@class TempDataManager : Singleton
---@field seeds System.Single[]
---@field SettingTransformMap System.Collections.Generic.Dictionary
---@field rareColorMap1 System.Collections.Generic.Dictionary
---@field GameOver boolean
---@field RoleStatusMap System.Collections.Generic.Dictionary
---@field RarityMap System.Collections.Generic.Dictionary
---@field keyWordsDic System.Collections.Generic.Dictionary
---@field keyWordIds System.Collections.Generic.Dictionary
---@field rareColorMap System.Collections.Generic.Dictionary
---@field UIWorldPosMap System.Collections.Generic.Dictionary
---@field Instance TempDataManager -- infered from Singleton`1[TempDataManager]
---@field GetInstance TempDataManager -- infered from Singleton`1[TempDataManager]
TempDataManager = {}
---@alias CS.TempDataManager TempDataManager
CS.TempDataManager = TempDataManager

---@return TempDataManager
function TempDataManager.New() end
---@param seed number
function TempDataManager:Random(seed) end

---@class EffectData : System.Object
---@field InitScript string
---@field Timepoint string
---@field Cost number
---@field Name string
---@field Description string
EffectData = {}
---@alias CS.EffectData EffectData
CS.EffectData = EffectData

---@return EffectData
function EffectData.New() end
---@param dataconfig DataConfig
function EffectData:Init(dataconfig) end

---@class WarningFilter : UnityEngine.MonoBehaviour
WarningFilter = {}
---@alias CS.WarningFilter WarningFilter
CS.WarningFilter = WarningFilter


---@class WarningFilter.BlockingLogHandler : System.Object
---@field _originalHandler UnityEngine.ILogHandler
WarningFilter.BlockingLogHandler = {}
---@alias CS.WarningFilter.BlockingLogHandler WarningFilter.BlockingLogHandler
CS.WarningFilter.BlockingLogHandler = WarningFilter.BlockingLogHandler

---@param originalHandler UnityEngine.ILogHandler
---@return WarningFilter.BlockingLogHandler
function WarningFilter.BlockingLogHandler.New(originalHandler) end
---@param logType UnityEngine.LogType
---@param context UnityEngine.Object
---@param format string
---@param args System.Object[]
function WarningFilter.BlockingLogHandler:LogFormat(logType, context, format, args) end
---@param exception System.Exception
---@param context UnityEngine.Object
function WarningFilter.BlockingLogHandler:LogException(exception, context) end

---@class PropertyWatcher : Singleton
---@field Instance PropertyWatcher -- infered from Singleton`1[PropertyWatcher]
---@field GetInstance PropertyWatcher -- infered from Singleton`1[PropertyWatcher]
PropertyWatcher = {}
---@alias CS.PropertyWatcher PropertyWatcher
CS.PropertyWatcher = PropertyWatcher

---@return PropertyWatcher
function PropertyWatcher.New() end
---@overload fun(self: PropertyWatcher, classBody: System.ComponentModel.INotifyPropertyChanged, propertyName: string, action: System.Action | function) : System.ComponentModel.PropertyChangedEventHandler
---@overload fun(self: PropertyWatcher, classBody: System.ComponentModel.INotifyPropertyChanged, propertyName: string, action: System.Action | function) : System.ComponentModel.PropertyChangedEventHandler
---@param classBody System.ComponentModel.INotifyPropertyChanged
---@param propertyName string
---@param action System.Action | function
---@return System.ComponentModel.PropertyChangedEventHandler
function PropertyWatcher:AddListener(classBody, propertyName, action) end
---@param classBody System.ComponentModel.INotifyPropertyChanged
---@param handler System.ComponentModel.PropertyChangedEventHandler
function PropertyWatcher:RemoveListener(classBody, handler) end

---@class CustomDamageType : UnityEngine.ScriptableObject
---@field popUpType string
---@field ignoreDefend boolean
---@field CanUseTough boolean
CustomDamageType = {}
---@alias CS.CustomDamageType CustomDamageType
CS.CustomDamageType = CustomDamageType

---@return CustomDamageType
function CustomDamageType.New() end
---@param status StatusManager
---@param damage number
---@param vector UnityEngine.Vector3
---@param from StatusManager
---@param originalVal number
---@param damageType string
---@param fromDataId string
---@return number
function CustomDamageType:ApplyDamage(status, damage, vector, from, originalVal, damageType, fromDataId) end
---@param status StatusManager
---@param damage number
---@param vector UnityEngine.Vector3
---@param from StatusManager
---@param originalVal number
function CustomDamageType:ShowDamage(status, damage, vector, from, originalVal) end
---@param status StatusManager
---@param heal number
function CustomDamageType:ApplyHeal(status, heal) end

---@class Bullet : UnityEngine.MonoBehaviour
---@field cast UnityEngine.GameObject
---@field hit UnityEngine.GameObject
Bullet = {}
---@alias CS.Bullet Bullet
CS.Bullet = Bullet


---@class BulletEffectInfo : EffectBase
---@field initAngle UnityEngine.Vector3
---@field speed number
BulletEffectInfo = {}
---@alias CS.BulletEffectInfo BulletEffectInfo
CS.BulletEffectInfo = BulletEffectInfo

---@return BulletEffectInfo
function BulletEffectInfo.New() end
---@param status IStatusManager
---@param isReverse boolean
function BulletEffectInfo:Play(status, isReverse) end

---@class CardEffectInfo : EffectBase
---@field type CardEffectInfo.Type
---@field initAngle UnityEngine.Vector3
CardEffectInfo = {}
---@alias CS.CardEffectInfo CardEffectInfo
CS.CardEffectInfo = CardEffectInfo

---@return CardEffectInfo
function CardEffectInfo.New() end
---@param status IStatusManager
---@param isReverse boolean
function CardEffectInfo:Play(status, isReverse) end

---@class CardEffectInfo.Type
---@field Default CardEffectInfo.Type
---@field Area CardEffectInfo.Type
CardEffectInfo.Type = {}
---@alias CS.CardEffectInfo.Type CardEffectInfo.Type
CS.CardEffectInfo.Type = CardEffectInfo.Type


---@class EffectBase : UnityEngine.ScriptableObject
---@field effectPrefab UnityEngine.GameObject
---@field duration number
---@field target EffectBase.Target
---@field effect UnityEngine.GameObject
---@field positionType EffectBase.PositionType
EffectBase = {}
---@alias CS.EffectBase EffectBase
CS.EffectBase = EffectBase

---@param status IStatusManager
---@param isReverse boolean
function EffectBase:Play(status, isReverse) end

---@class EffectBase.Target
---@field None EffectBase.Target
---@field Self EffectBase.Target
---@field Target EffectBase.Target
EffectBase.Target = {}
---@alias CS.EffectBase.Target EffectBase.Target
CS.EffectBase.Target = EffectBase.Target


---@class EffectBase.PositionType
---@field Center EffectBase.PositionType
---@field Top EffectBase.PositionType
---@field Bottom EffectBase.PositionType
EffectBase.PositionType = {}
---@alias CS.EffectBase.PositionType EffectBase.PositionType
CS.EffectBase.PositionType = EffectBase.PositionType


---@class EffectInfo : EffectBase
EffectInfo = {}
---@alias CS.EffectInfo EffectInfo
CS.EffectInfo = EffectInfo

---@return EffectInfo
function EffectInfo.New() end

---@class EffectManager : Singleton
---@field Instance EffectManager -- infered from Singleton`1[EffectManager]
---@field GetInstance EffectManager -- infered from Singleton`1[EffectManager]
EffectManager = {}
---@alias CS.EffectManager EffectManager
CS.EffectManager = EffectManager

---@return EffectManager
function EffectManager.New() end
function EffectManager:Init() end
---@overload fun(self: EffectManager, scriptExecutor: IScriptExecutor, effectName: string)
---@param Self IStatusManager
---@param effectName string
function EffectManager:PlayEffect(Self, effectName) end
---@param Self IStatusManager
---@param Object System.Collections.Generic.List
---@param effectName string
function EffectManager:InternalPlayEffect(Self, Object, effectName) end
---@param scriptExecutor IScriptExecutor
---@param effectName string
---@param delay number
function EffectManager:PlayActionEffect(scriptExecutor, effectName, delay) end
---@param effectName string
function EffectManager:PlayScreenEffect(effectName) end

---@class EnemyEffectInfo : EffectBase
---@field type EnemyEffectInfo.Type
---@field initAngle UnityEngine.Vector3
EnemyEffectInfo = {}
---@alias CS.EnemyEffectInfo EnemyEffectInfo
CS.EnemyEffectInfo = EnemyEffectInfo

---@return EnemyEffectInfo
function EnemyEffectInfo.New() end
---@param status IStatusManager
---@param isReverse boolean
function EnemyEffectInfo:Play(status, isReverse) end

---@class EnemyEffectInfo.Type
---@field Default EnemyEffectInfo.Type
---@field Area EnemyEffectInfo.Type
EnemyEffectInfo.Type = {}
---@alias CS.EnemyEffectInfo.Type EnemyEffectInfo.Type
CS.EnemyEffectInfo.Type = EnemyEffectInfo.Type


---@class FightInit : FightUnit
FightInit = {}
---@alias CS.FightInit FightInit
CS.FightInit = FightInit

---@return FightInit
function FightInit.New() end
function FightInit:Init() end
function FightInit:ApplyBlessingRelic() end
function FightInit:RpcLoadRoles() end

---@class FightPlayer : FightObject
---@field diceIconList UnityEngine.Transform
---@field isEnd boolean
---@field Instance FightPlayer
---@field Type string
---@field Id string
---@field AnimationLocation string
---@field VocalLocation string
---@field Name string
---@field Status IStatusManager
---@field MaxPowerCount number
---@field CurPowerCount number
---@field diceIcon DiceIcon
FightPlayer = {}
---@alias CS.FightPlayer FightPlayer
CS.FightPlayer = FightPlayer

function FightPlayer:StartBoredTimer() end
function FightPlayer:ResetBoredTimer() end
function FightPlayer:StopBoredTimer() end
---@param instanceId string
function FightPlayer:Init(instanceId) end
---@return System.Collections.IEnumerator
function FightPlayer:DoAction() end
function FightPlayer:OnDestroy() end
function FightPlayer:EndRound() end
function FightPlayer:DeadEffect() end
---@return boolean
function FightPlayer:Weaved() end

---@class FightUnit : System.Object
FightUnit = {}
---@alias CS.FightUnit FightUnit
CS.FightUnit = FightUnit

---@return FightUnit
function FightUnit.New() end
function FightUnit:Init() end
function FightUnit:OnUpdate() end

---@class Fight_EnemyTurn : FightUnit
Fight_EnemyTurn = {}
---@alias CS.Fight_EnemyTurn Fight_EnemyTurn
CS.Fight_EnemyTurn = Fight_EnemyTurn

---@return Fight_EnemyTurn
function Fight_EnemyTurn.New() end
function Fight_EnemyTurn:Init() end

---@class Fight_Loss : FightUnit
Fight_Loss = {}
---@alias CS.Fight_Loss Fight_Loss
CS.Fight_Loss = Fight_Loss

---@return Fight_Loss
function Fight_Loss.New() end
function Fight_Loss:Init() end

---@class Fight_OtherTurn : FightUnit
Fight_OtherTurn = {}
---@alias CS.Fight_OtherTurn Fight_OtherTurn
CS.Fight_OtherTurn = Fight_OtherTurn

---@return Fight_OtherTurn
function Fight_OtherTurn.New() end
function Fight_OtherTurn:Init() end

---@class Fight_Partner : FightUnit
Fight_Partner = {}
---@alias CS.Fight_Partner Fight_Partner
CS.Fight_Partner = Fight_Partner

---@return Fight_Partner
function Fight_Partner.New() end
function Fight_Partner:Init() end

---@class Fight_PlayerTurn : FightUnit
---@field ShouldCard number
---@field NowActionId string
Fight_PlayerTurn = {}
---@alias CS.Fight_PlayerTurn Fight_PlayerTurn
CS.Fight_PlayerTurn = Fight_PlayerTurn

---@return Fight_PlayerTurn
function Fight_PlayerTurn.New() end
function Fight_PlayerTurn:Init() end
function Fight_PlayerTurn:OnUpdate() end

---@class Fight_Start : FightUnit
Fight_Start = {}
---@alias CS.Fight_Start Fight_Start
CS.Fight_Start = Fight_Start

---@return Fight_Start
function Fight_Start.New() end
function Fight_Start:Init() end

---@class Fight_Win : FightUnit
---@field RewardMul number
---@field IsWin boolean
Fight_Win = {}
---@alias CS.Fight_Win Fight_Win
CS.Fight_Win = Fight_Win

---@return Fight_Win
function Fight_Win.New() end
function Fight_Win:Init() end

---@class OtherPlayer : FightObject
---@field isEnd boolean
---@field Type string
---@field Id string
---@field AnimationLocation string
---@field VocalLocation string
---@field Name string
OtherPlayer = {}
---@alias CS.OtherPlayer OtherPlayer
CS.OtherPlayer = OtherPlayer

---@param Index string
function OtherPlayer:Init(Index) end
---@return System.Collections.IEnumerator
function OtherPlayer:DoAction() end
function OtherPlayer:EndRound() end
---@return boolean
function OtherPlayer:Weaved() end

---@class Enemy : OtherObj
---@field Type string
Enemy = {}
---@alias CS.Enemy Enemy
CS.Enemy = Enemy

---@param dataConfig DataConfig
---@param SumOfEnemyPositive number
---@param index number
function Enemy:Init(dataConfig, SumOfEnemyPositive, index) end
function Enemy:AddCardList() end
---@return System.Collections.IEnumerator
function Enemy:DoAction() end
---@return boolean
function Enemy:Weaved() end

---@class EnemyManager : System.Object
---@field SettlementMultiplier number
---@field levelData System.Collections.Generic.Dictionary
---@field enemyCount number
---@field enemyList System.Collections.Generic.List
---@field LevelId string
---@field IndexCount number
---@field Instance EnemyManager
EnemyManager = {}
---@alias CS.EnemyManager EnemyManager
CS.EnemyManager = EnemyManager

---@return EnemyManager
function EnemyManager.New() end
---@param id string
function EnemyManager:LoadRes(id) end
---@param id string
---@return string
function EnemyManager:AddEnemy(id) end
function EnemyManager:UpdatePos() end
function EnemyManager:ResPat() end

---@class ObjectAction : System.Object
ObjectAction = {}
---@alias CS.ObjectAction ObjectAction
CS.ObjectAction = ObjectAction

---@param father OtherObj
---@return ObjectAction
function ObjectAction.New(father) end
---@param enemyCard ObjectCard
function ObjectAction:AddCard(enemyCard) end
function ObjectAction:ActionExecute() end
---@param index number
function ObjectAction:DesActionCard(index) end
---@return ObjectCard
function ObjectAction:TryGetCard() end
---@param count number
---@return System.Collections.Generic.List
function ObjectAction:ActionShow(count) end
function ObjectAction:CardUpdate() end

---@class ObjectCard : System.Object
---@field nowCD number
---@field isIgnored boolean
---@field status StatusManager
---@field dataConfig DataConfig
---@field keyWords System.Collections.Generic.List
ObjectCard = {}
---@alias CS.ObjectCard ObjectCard
CS.ObjectCard = ObjectCard

---@return ObjectCard
function ObjectCard.New() end
---@param dataConfig DataConfig
function ObjectCard:Init(dataConfig) end
function ObjectCard:DataUpdate() end
---@param target StatusManager
function ObjectCard:UseCard(target) end
function ObjectCard:SetStatus() end
---@return number
function ObjectCard:GetPriority() end
function ObjectCard:UpdateMsg() end

---@class OtherObj : FightObject
---@field dataConfig DataConfig
---@field FightAction ObjectAction
---@field ActionCards System.Collections.Generic.List
---@field data System.Collections.Generic.IDictionary
---@field Type string
---@field Attack number
---@field Defend number
---@field ActionCount number
---@field MaxActionCount number
---@field Id string
---@field Name string
---@field AnimationLocation string
---@field VocalLocation string
OtherObj = {}
---@alias CS.OtherObj OtherObj
CS.OtherObj = OtherObj

---@param fromdata DataConfig
---@param SumOfEnemyPositive number
---@param index number
function OtherObj:Init(fromdata, SumOfEnemyPositive, index) end
---@return System.Collections.IEnumerator
function OtherObj:DoAction() end
function OtherObj:EndRound() end
---@param index number
function OtherObj:AnnounceDesAction(index) end
---@param index number
function OtherObj:DesActionCard(index) end
function OtherObj:ResetActionObj() end
function OtherObj:SetAction() end
function OtherObj:UpdataActionShow() end
---@param tempPar UnityEngine.Transform
---@param text string
function OtherObj:UpdateText(tempPar, text) end
---@param i number
---@param isSingle boolean
---@return boolean
function OtherObj:DoOneAction(i, isSingle) end
function OtherObj:HideAction() end
function OtherObj:ShowAction() end
---@return boolean
function OtherObj:ActionJudge() end
function OtherObj:AddCardList() end
function OtherObj:DeadEffect() end
---@return boolean
function OtherObj:Weaved() end

---@class Partner : OtherObj
---@field Type string
Partner = {}
---@alias CS.Partner Partner
CS.Partner = Partner

---@param fromdata DataConfig
---@param SumOfEnemyPositive number
---@param index number
function Partner:Init(fromdata, SumOfEnemyPositive, index) end
---@return System.Collections.IEnumerator
function Partner:DoAction() end
function Partner:AddCardList() end
---@return boolean
function Partner:Weaved() end

---@class PatternManager : System.Object
---@field PatternList System.Collections.Generic.List
---@field Instance PatternManager
PatternManager = {}
---@alias CS.PatternManager PatternManager
CS.PatternManager = PatternManager

---@return PatternManager
function PatternManager.New() end
function PatternManager:InitPattern() end
function PatternManager:ResPat() end

---@class SkillItem : UnityEngine.MonoBehaviour
---@field dataConfig IDataConfig
---@field data System.Collections.Generic.IDictionary
---@field Vars System.Collections.Generic.IDictionary
---@field status IStatusManager
---@field lasttime number
---@field scriptExecutor IScriptExecutor
SkillItem = {}
---@alias CS.SkillItem SkillItem
CS.SkillItem = SkillItem

---@param ScriptName string
function SkillItem:RunScript(ScriptName) end
---@param dataConfig IDataConfig
function SkillItem:Init(dataConfig) end
function SkillItem:Awake() end
function SkillItem:DataUpdate() end
function SkillItem:RegisterEvent() end
function SkillItem:OnDisable() end
---@return boolean
function SkillItem:TryUse() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SkillItem:OnPointerDown(eventData) end
function SkillItem:TrueUse() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SkillItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SkillItem:OnPointerExit(eventData) end

---@class StatusManager : UnityEngine.MonoBehaviour
---@field _animatedState IStatusManager.AnimatedState
---@field Summon System.Collections.Generic.List
---@field _NetEnqueue boolean
---@field selfUI UnityEngine.GameObject
---@field statusBarObj UnityEngine.GameObject
---@field actionText Witch.UI.KeywordDisplay[]
---@field statusBarUI Witch.UI.Window.StatusBarUI
---@field actionContent UnityEngine.GameObject
---@field effectListObj UnityEngine.GameObject
---@field initPos UnityEngine.Vector3
---@field MiDataConfig DataConfig
---@field maxHp number
---@field _toughCount number
---@field curHp number
---@field defend number
---@field isResurrecting boolean
---@field animatedState IStatusManager.AnimatedState
---@field state IStatusManager.State
---@field Name string
---@field fatherObject FightObject
---@field actionObj UnityEngine.GameObject[]
---@field DamageFilter System.Collections.Generic.Dictionary
---@field effectList System.Collections.Generic.List
---@field InstanceId string
---@field MirrorSc IScriptExecutor
---@field MaxHp number
---@field ToughOrigin number
---@field ToughCount number
---@field CurHp number
---@field Defend number
---@field dynamicVariables System.Collections.Generic.Dictionary
---@field dynamicVariablesLog System.Collections.Generic.Dictionary
StatusManager = {}
---@alias CS.StatusManager StatusManager
CS.StatusManager = StatusManager

---@param sprite UnityEngine.Sprite
function StatusManager:SetSprite(sprite) end
---@param path string
---@param name string
function StatusManager:AddSummon(path, name) end
---@param name string
function StatusManager:RemoveSummon(name) end
function StatusManager:OnSelect() end
function StatusManager:OnUnSelect() end
---@param replaceImmediate boolean
function StatusManager:ResetAnimator(replaceImmediate) end
---@param replaceImmediate boolean
---@return UnityEngine.Sprite
function StatusManager:InitAnimator(replaceImmediate) end
function StatusManager:InitVocal() end
function StatusManager:ResetVocal() end
---@param father FightObject
---@return IStatusManager
function StatusManager:Init(father) end
---@param pos UnityEngine.Vector3
function StatusManager:SetPosition(pos) end
function StatusManager:UpdateDisplay() end
function StatusManager:UpdateObjPos() end
---@param NeedEffect boolean
function StatusManager:UpdateStatus(NeedEffect) end
function StatusManager:ResetDamageStatus() end
---@param val number
---@param damageType string
---@param fromDataId string
---@param fromInstanceId string
function StatusManager:Hit(val, damageType, fromDataId, fromInstanceId) end
---@param val number
---@param damageType string
function StatusManager:Heal(val, damageType) end
---@param state IStatusManager.VocalState
function StatusManager:PlayVocal(state) end
---@param Delay number
function StatusManager:EnemyDead(Delay) end
function StatusManager:UpdateEffectList() end
function StatusManager:UpdateTough() end
---@param state IStatusManager.State
function StatusManager:ChangeState(state) end
---@param BaseDamage number
---@return number
function StatusManager:DamageCalculate(BaseDamage) end
---@param BaseDefence number
---@return number
function StatusManager:DefenceCalculate(BaseDefence) end
---@param BaseDamage number
---@return number
function StatusManager:UnDamageCalucate(BaseDamage) end
---@param value number
function StatusManager:Resurrection(value) end
function StatusManager:CheckDead() end
---@param way string
---@return IStatusManager
function StatusManager:CheckAllBuff(way) end
---@return IStatusManager
function StatusManager:UpdateBuff() end
---@return IStatusManager
function StatusManager:ClearAllBuff() end
---@param buffId string
---@return IStatusManager
function StatusManager:RemoveBuff(buffId) end
---@overload fun(self: StatusManager, buffId: string, level: number) : IStatusManager
---@param buffConfig IBuffItemConfig
---@return IStatusManager
function StatusManager:AddBuff(buffConfig) end
---@param buffId string
---@return IBuffItem
function StatusManager:GetBuff(buffId) end
---@return IBuffItem[]
function StatusManager:GetBuffs() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function StatusManager:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function StatusManager:OnPointerExit(eventData) end

---@class StatusDataTransfer : System.Object
---@field maxHp number
---@field curHp number
---@field defend number
---@field _toughCount number
---@field ToughOrigin number
---@field InstanceId string
StatusDataTransfer = {}
---@alias CS.StatusDataTransfer StatusDataTransfer
CS.StatusDataTransfer = StatusDataTransfer

---@overload fun(status: StatusManager) : StatusDataTransfer
---@overload fun(status: StatusDataTransfer) : StatusDataTransfer
---@return StatusDataTransfer
function StatusDataTransfer.New() end
---@param propertyName string
---@param value System.Object
---@return StatusDataTransfer
function StatusDataTransfer:WithPropertys(propertyName, value) end
---@param status StatusManager
function StatusDataTransfer:Populate(status) end

---@class StatusManagerConverter : Newtonsoft.Json.JsonConverter
StatusManagerConverter = {}
---@alias CS.StatusManagerConverter StatusManagerConverter
CS.StatusManagerConverter = StatusManagerConverter

---@return StatusManagerConverter
function StatusManagerConverter.New() end
---@param writer Newtonsoft.Json.JsonWriter
---@param value StatusManager
---@param serializer Newtonsoft.Json.JsonSerializer
function StatusManagerConverter:WriteJson(writer, value, serializer) end
---@param reader Newtonsoft.Json.JsonReader
---@param objectType System.Type
---@param existingValue StatusManager
---@param hasExistingValue boolean
---@param serializer Newtonsoft.Json.JsonSerializer
---@return StatusManager
function StatusManagerConverter:ReadJson(reader, objectType, existingValue, hasExistingValue, serializer) end

---@class GameApp : UnityEngine.MonoBehaviour
---@field Instance GameApp
---@field STEAMBUILD boolean
---@field OFFLINE boolean
---@field debugText TMPro.TMP_Text
---@field NowBackground UnityEngine.GameObject
---@field WarmupFontAssets System.Collections.Generic.List
---@field MainFontAsset TMPro.TMP_FontAsset
GameApp = {}
---@alias CS.GameApp GameApp
CS.GameApp = GameApp

function GameApp:ChangeTransportToSteam() end
function GameApp:ChangeTransportToKCP() end
function GameApp:StartMenu() end
function GameApp:StartHouse() end
function GameApp:StartBreaks() end
function GameApp:StartGame() end
---@param roleTable RoleTable
function GameApp:ContinueGame(roleTable) end
---@param belong Witch.UI.SceneType
function GameApp:UpdateBack(belong) end
function GameApp:GameOver() end
---@param level string
---@return Cysharp.Threading.Tasks.UniTask
function GameApp:StartFight(level) end
---@param level string
---@return Cysharp.Threading.Tasks.UniTask
function GameApp:StartFakeFight(level) end
---@param context UnityEngine.InputSystem.InputAction.CallbackContext
function GameApp:OpenBackpack(context) end
function GameApp:ReturnToMenu() end
---@param state string
function GameApp:SetSteamRichState(state) end

---@class AudioManager : UnityEngine.MonoBehaviour
---@field Instance AudioManager
---@field EffectVolume number
---@field bgmVolume number
---@field NowBGMName string
---@field masterVolume number
---@field bgmSource UnityEngine.AudioSource
AudioManager = {}
---@alias CS.AudioManager AudioManager
CS.AudioManager = AudioManager

---@param volume number
function AudioManager:ChangeMasterVolume(volume) end
---@param volume number
function AudioManager:ChangeBgmVolume(volume) end
---@param volume number
function AudioManager:ChangeEffectVolume(volume) end
---@overload fun(self: AudioManager, name: string, next: boolean)
---@overload fun(self: AudioManager, bgmList: BGMList, next: boolean)
---@param bgmList System.Collections.Generic.List
---@param bgmListName string
---@param next boolean
function AudioManager:PlayBGMList(bgmList, bgmListName, next) end
---@overload fun(self: AudioManager, name: string)
---@param clip UnityEngine.AudioClip
function AudioManager:PlayEffect(clip) end
---@param roleId string
---@param clip UnityEngine.AudioClip
function AudioManager:PlayVocal(roleId, clip) end

---@class DialogueManager : Singleton
---@field Identity System.Collections.Generic.Dictionary
---@field IsChat boolean
---@field Instance DialogueManager -- infered from Singleton`1[DialogueManager]
---@field GetInstance DialogueManager -- infered from Singleton`1[DialogueManager]
DialogueManager = {}
---@alias CS.DialogueManager DialogueManager
CS.DialogueManager = DialogueManager

---@return DialogueManager
function DialogueManager.New() end
function DialogueManager:Init() end
---@param id string
function DialogueManager:ShowDialogue(id) end
---@param id string
function DialogueManager:ShowDialogueBox(id) end
---@param instanceId string
---@param emoji GifAsset
function DialogueManager:ShowEmoji(instanceId, emoji) end
function DialogueManager:NextDialogue() end
function DialogueManager:NextDialogueBox() end
---@param options System.ValueTuple
function DialogueManager:ShowOptions(options) end
function DialogueManager:EndDialogue() end

---@class FightCardManager : System.Object
---@field cardList System.Collections.ObjectModel.ObservableCollection
---@field tempList System.Collections.Generic.List
---@field usedCardList System.Collections.ObjectModel.ObservableCollection
---@field FightcardList System.Collections.Generic.List
---@field CardTags System.Collections.Generic.Dictionary
---@field Instance FightCardManager
FightCardManager = {}
---@alias CS.FightCardManager FightCardManager
CS.FightCardManager = FightCardManager

---@return FightCardManager
function FightCardManager.New() end
function FightCardManager:Init() end
function FightCardManager:RandomIndex() end
---@return boolean
function FightCardManager:HasCard() end
---@return DataConfig
function FightCardManager:DrawCard() end

---@class FightManager : Mirror.NetworkBehaviour
---@field Instance FightManager
---@field IsFake boolean
---@field fightType FightType
---@field level string
---@field ValueDice ScriptExecutor.DiceWrapper
---@field CheckDice ScriptExecutor.DiceWrapper
---@field DefaultDice ScriptExecutor.DiceWrapper
---@field roleQueue System.Collections.Generic.List
---@field ActionQueue System.Collections.Generic.List
---@field statuses System.Collections.Generic.Dictionary
---@field statusData System.Collections.Generic.Dictionary
---@field TempVarsMap System.Collections.Generic.Dictionary
---@field eventList System.Collections.Generic.Queue
---@field targetList System.Collections.Generic.Queue
---@field enemyManager EnemyManager
---@field patternManager PatternManager
---@field SumOfEnemyPositive number
---@field NowActionRole string
---@field waitCount number
---@field wantLevel string
---@field ReSetCount number
---@field TempRoleList System.Collections.Generic.Dictionary
---@field IsRet boolean
---@field selfIndex string
---@field NetworkNowActionRole string
FightManager = {}
---@alias CS.FightManager FightManager
CS.FightManager = FightManager

function FightManager:ResetWaitCount() end
---@param level string
function FightManager:ReadyToInit(level) end
function FightManager:RpcFightCheck() end
function FightManager:ReadyToStart() end
---@param level string
function FightManager:ReSetFight(level) end
function FightManager:ClearFightui() end
---@param action string
---@param Id string
---@param fromId string
---@param theData string
---@param Vars System.String[]
function FightManager:CmdSendEvent(action, Id, fromId, theData, Vars) end
---@param level string
---@param roleQueueStream System.Byte[]
---@param fromtempRoleListStream System.Byte[]
---@param positive number
function FightManager:Init(level, roleQueueStream, fromtempRoleListStream, positive) end
---@param enemyId string
function FightManager:CmdAddEnemy(enemyId) end
---@param enemyId string
function FightManager:RpcAddEnemy(enemyId) end
---@param statusData StatusDataTransfer
function FightManager:SyncStatus(statusData) end
---@param type FightType
function FightManager:CmdChangeType(type) end
---@param instanceId string
function FightManager:CmdPlayChange(instanceId) end
---@param instanceId string
---@param isDead boolean
function FightManager:CmdAnnounceDone(instanceId, isDead) end
function FightManager:EndPlayerturn() end
function FightManager:TurnEnd() end
---@param conn Mirror.NetworkConnection
---@param newType FightType
---@param nowAction string
function FightManager:TargetChangeUnit(conn, newType, nowAction) end
---@param newType FightType
function FightManager:ChangeUnit(newType) end
---@overload fun(self: FightManager, statusCommand: IStatusCommand)
---@param statusCommand IStatusCommand
---@param conn Mirror.NetworkConnection
function FightManager:EnqueueEvent(statusCommand, conn) end
---@param target Mirror.NetworkConnection
---@param objCommand Fight.ObjTarget.ObjTargetBase
function FightManager:TargetEnqueueEvent(target, objCommand) end
---@param statusCommand Fight.StatusCommand.ClientCommandBase
function FightManager:CmdEnqueueEvent(statusCommand) end
---@param conn Mirror.NetworkConnectionToClient
function FightManager:CmdCheckDead(conn) end
---@return System.Collections.IEnumerator
function FightManager:DOAllAction() end
---@param CareerId string
---@param playerIdentity string
function FightManager:CmdChangeCareer(CareerId, playerIdentity) end
---@param CareerId string
---@param playerIdentity string
function FightManager:RpcChangeCareer(CareerId, playerIdentity) end
---@param instanceId string
---@param index string
function FightManager:CmdActionChange(instanceId, index) end
---@param instanceId string
---@param index string
function FightManager:RpcActionChange(instanceId, index) end
---@param fightObject FightObject
---@return System.Collections.IEnumerator
function FightManager:DoAction(fightObject) end
---@return boolean
function FightManager:Weaved() end
---@param writer Mirror.NetworkWriter
---@param forceAll boolean
function FightManager:SerializeSyncVars(writer, forceAll) end
---@param reader Mirror.NetworkReader
---@param initialState boolean
function FightManager:DeserializeSyncVars(reader, initialState) end

---@class FightManager.RoleData : System.Object
---@field InstanceId string
---@field MaxHp number
---@field CurHp number
---@field Defend number
---@field State IStatusManager.State
---@field career DataConfig
FightManager.RoleData = {}
---@alias CS.FightManager.RoleData FightManager.RoleData
CS.FightManager.RoleData = FightManager.RoleData

---@overload fun() : FightManager.RoleData
---@param instanceId string
---@return FightManager.RoleData
function FightManager.RoleData.New(instanceId) end

---@class MapManager : Mirror.NetworkBehaviour
---@field ModeMapManager Witch.IModeManager
---@field CurrentMode string
---@field mapList System.String[]
---@field mapData System.String[]
---@field SumOfEnemyPositive number
---@field eventWait number
---@field eventDone number
---@field Instance MapManager
---@field MapTree MapTree
---@field Level number
---@field NowDice Dice
---@field NetworkSumOfEnemyPositive number
MapManager = {}
---@alias CS.MapManager MapManager
CS.MapManager = MapManager

function MapManager:Awake() end
function MapManager:RpcTryChange() end
---@param mapManager string
function MapManager:SetMap(mapManager) end
function MapManager:TryChange() end
---@param conn Mirror.NetworkConnectionToClient
function MapManager:ReadyToChangeMap(conn) end
---@param conn Mirror.NetworkConnectionToClient
function MapManager:CmdReadyToNextMap(conn) end
function MapManager:CmdNextMap() end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function MapManager:MapUIStart(mapSelectUI) end
function MapManager:RpcNextMap() end
function MapManager:ResetEvent() end
function MapManager:CmdAnnounceEventWait() end
function MapManager:CmdEventWait() end
---@param type string
---@param id string
function MapManager:RpcLoadMap(type, id) end
function MapManager:CloseMapUI() end
---@param diceJSON string
function MapManager:RpcSyncDice(diceJSON) end
---@param level number
function MapManager:SetLevel(level) end
---@param seed number
function MapManager:RpcSyncRandom(seed) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function MapManager:MapItemInit(mapSelectUI) end
---@param maps System.String[]
---@param mapdata System.String[]
---@param conn Mirror.NetworkConnectionToClient
function MapManager:CmdSelectMap(maps, mapdata, conn) end
---@param conn Mirror.NetworkConnection
---@param maps System.String[]
---@param mapdata System.String[]
function MapManager:TargetUpdateMap(conn, maps, mapdata) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function MapManager:SetReward(battleRewardsUI) end
---@param identity Mirror.NetworkIdentity
function MapManager:RemoveReady(identity) end
---@return boolean
function MapManager:WinTheGame() end
---@return boolean
function MapManager:Weaved() end
---@param writer Mirror.NetworkWriter
---@param forceAll boolean
function MapManager:SerializeSyncVars(writer, forceAll) end
---@param reader Mirror.NetworkReader
---@param initialState boolean
function MapManager:DeserializeSyncVars(reader, initialState) end

---@class TutorialManager : Singleton
---@field Instance TutorialManager -- infered from Singleton`1[TutorialManager]
---@field GetInstance TutorialManager -- infered from Singleton`1[TutorialManager]
TutorialManager = {}
---@alias CS.TutorialManager TutorialManager
CS.TutorialManager = TutorialManager

---@return TutorialManager
function TutorialManager.New() end
function TutorialManager:Init() end

---@class GameServer : Mirror.NetworkBehaviour
---@field EndCommit boolean
---@field LobbyInfo LobbyInfo
---@field RoleTables System.Collections.Generic.Dictionary
---@field isAcceptJoin boolean
---@field IsRoleTableSynced boolean
---@field EnemyDone boolean
---@field PatDone boolean
---@field Instance GameServer
GameServer = {}
---@alias CS.GameServer GameServer
CS.GameServer = GameServer

---@param roleTables System.Collections.Generic.Dictionary
function GameServer:StartRole(roleTables) end
function GameServer:StartGame() end
function GameServer:RoleRes() end
---@param tomap System.Collections.Generic.Dictionary
function GameServer:GetRoles(tomap) end
---@param roleTable RoleTable
function GameServer:ReceiveRoleTable(roleTable) end
---@param onAllReceived System.Action | function
function GameServer:CollectRoleTables(onAllReceived) end
function GameServer:SaveGame() end
function GameServer:EndGame() end
---@param playerId string
---@return boolean
function GameServer:CheckOnline(playerId) end
---@return boolean
function GameServer:Weaved() end

---@class PingSelection : Supabase.Postgrest.Models.BaseModel
---@field max_ping number
---@field average_ping number
---@field min_ping number
PingSelection = {}
---@alias CS.PingSelection PingSelection
CS.PingSelection = PingSelection

---@return PingSelection
function PingSelection.New() end

---@class LatencyRecorder : UnityEngine.MonoBehaviour
---@field Instance LatencyRecorder
---@field AvgMs number
---@field MaxMs number
---@field MinMs number
---@field SampleCount number
LatencyRecorder = {}
---@alias CS.LatencyRecorder LatencyRecorder
CS.LatencyRecorder = LatencyRecorder

function LatencyRecorder:StopAndReport() end

---@class LobbyInfo : System.Object
---@field AddedPlayers System.Collections.Generic.List
LobbyInfo = {}
---@alias CS.LobbyInfo LobbyInfo
CS.LobbyInfo = LobbyInfo

---@return LobbyInfo
function LobbyInfo.New() end

---@class LobbyInfo.PlayerInfo : System.Object
---@field Name string
---@field Id string
---@field IsSyncedRole boolean
---@field Version string
---@field Mods ModConfig[]
---@field Connection Mirror.NetworkConnectionToClient
LobbyInfo.PlayerInfo = {}
---@alias CS.LobbyInfo.PlayerInfo LobbyInfo.PlayerInfo
CS.LobbyInfo.PlayerInfo = LobbyInfo.PlayerInfo

---@return LobbyInfo.PlayerInfo
function LobbyInfo.PlayerInfo.New() end

---@class LobbyManager : Mirror.NetworkManager
---@field lobbyId number
---@field Instance LobbyManager
LobbyManager = {}
---@alias CS.LobbyManager LobbyManager
CS.LobbyManager = LobbyManager

function LobbyManager:Awake() end
---@param conn Mirror.NetworkConnectionToClient
function LobbyManager:OnServerDisconnect(conn) end
function LobbyManager:OnClientDisconnect() end
---@param joined boolean
function LobbyManager:UpdateSteamLobyState(joined) end
function LobbyManager:QuitLobby() end
function LobbyManager:OnApplicationQuit() end
---@param conn Mirror.NetworkConnectionToClient
function LobbyManager:OnServerConnect(conn) end

---@class PlayerManager : Mirror.NetworkBehaviour
---@field playerInfo LobbyInfo.PlayerInfo
---@field LobbyInfos LobbyInfo
---@field ShareCards Mirror.SyncList
---@field ShareRelics Mirror.SyncList
---@field ShareFood Mirror.SyncList
---@field Instance PlayerManager
---@field PlayerId string
---@field NetworkplayerInfo LobbyInfo.PlayerInfo
---@field NetworkLobbyInfos LobbyInfo
PlayerManager = {}
---@alias CS.PlayerManager PlayerManager
CS.PlayerManager = PlayerManager

function PlayerManager:StartGame() end
---@param conn Mirror.NetworkConnectionToClient
---@param message string
function PlayerManager:ShowMessage(conn, message) end
---@param conn Mirror.NetworkConnectionToClient
---@param roleTable RoleTable
function PlayerManager:RpcContinueToGame(conn, roleTable) end
---@param info LobbyInfo.PlayerInfo
---@param conn Mirror.NetworkConnectionToClient
function PlayerManager:CmdJoinLobby(info, conn) end
---@param info LobbyInfo.PlayerInfo
function PlayerManager:LeaveLobby(info) end
---@param players System.Collections.Generic.List
function PlayerManager:RpcUpdateLobby(players) end
---@param ready boolean
---@param playerId string
function PlayerManager:CmdReady(ready, playerId) end
---@param ready boolean
---@param playerId string
function PlayerManager:RpcReady(ready, playerId) end
function PlayerManager:RpcSyncRoleTables() end
function PlayerManager:CmdChangeHide() end
---@param target Mirror.NetworkConnection
---@param roleTable RoleTable
---@param GetSaveType string
function PlayerManager:RpcNewGameInit(target, roleTable, GetSaveType) end
function PlayerManager:ChangeHide() end
---@param roleTable RoleTable
function PlayerManager:CmdSyncRoleTable(roleTable) end
function PlayerManager:CmdSendSave() end
function PlayerManager:GameOver() end
---@param dataConfig string
---@param fromId string
function PlayerManager:CmdSendCareer(dataConfig, fromId) end
---@param dataConfig string
---@param fromId string
function PlayerManager:RpcSendCareer(dataConfig, fromId) end
---@param mapMode string
function PlayerManager:RpcSetMapMode(mapMode) end
function PlayerManager:OnStartClient() end
function PlayerManager:CreateChatPanel() end
---@param value string
---@param fromId string
---@param type string
function PlayerManager:CmdSendRoleTable(value, fromId, type) end
---@param value string
---@param fromId string
---@param type string
function PlayerManager:RpcSendRoleTable(value, fromId, type) end
function PlayerManager:RpcGameOver() end
---@param saveJson System.Byte[]
function PlayerManager:CmdSyncHostSave(saveJson) end
---@param compressed System.Byte[]
function PlayerManager:RpcHostSave(compressed) end
function PlayerManager:OnPlayerDisconnected() end
---@param command Network.Command.RpcCommandBase
function PlayerManager:SendRpcCommand(command) end
---@param command Network.Command.RpcCommandBase
function PlayerManager:SendRpcCommandExcludeOwner(command) end
---@return boolean
function PlayerManager:Weaved() end
---@param writer Mirror.NetworkWriter
---@param forceAll boolean
function PlayerManager:SerializeSyncVars(writer, forceAll) end
---@param reader Mirror.NetworkReader
---@param initialState boolean
function PlayerManager:DeserializeSyncVars(reader, initialState) end

---@class BlessingRelic : Singleton
---@field Instance BlessingRelic -- infered from Singleton`1[BlessingRelic]
---@field GetInstance BlessingRelic -- infered from Singleton`1[BlessingRelic]
BlessingRelic = {}
---@alias CS.BlessingRelic BlessingRelic
CS.BlessingRelic = BlessingRelic

---@return BlessingRelic
function BlessingRelic.New() end
---@return BlessingRelic
function BlessingRelic:Init() end
---@param status StatusManager
---@return BlessingRelic
function BlessingRelic:Apply(status) end
---@return BlessingRelic
function BlessingRelic:Clear() end

---@class AnimatorRole : UnityEngine.MonoBehaviour
---@field animationPerFrame number
---@field dataConfig DataConfig
---@field SpecialScale boolean
---@field OriPos UnityEngine.Vector2
---@field InstanceId string
---@field animationTimeCounter number
---@field BottomDistance number
---@field TopDistance number
AnimatorRole = {}
---@alias CS.AnimatorRole AnimatorRole
CS.AnimatorRole = AnimatorRole

---@param fromData DataConfig
---@param instanceId string
---@param needDialogueBox boolean
function AnimatorRole:Init(fromData, instanceId, needDialogueBox) end
---@param path string
---@return string
function AnimatorRole:TryGetAnimationConfig(path) end
---@param sprite UnityEngine.Sprite
---@param instanceId string
function AnimatorRole:InitSprite(sprite, instanceId) end
function AnimatorRole:GetConfig() end

---@class RandomMove : UnityEngine.MonoBehaviour
RandomMove = {}
---@alias CS.RandomMove RandomMove
CS.RandomMove = RandomMove


---@class RorationFix : UnityEngine.MonoBehaviour
RorationFix = {}
---@alias CS.RorationFix RorationFix
CS.RorationFix = RorationFix


---@class UIAnimation : UnityEngine.MonoBehaviour
---@field FPS number
---@field SpriteFrames System.Collections.Generic.List
---@field FrameDurations System.Collections.Generic.List
---@field GifAsset GifAsset
---@field IsPlaying boolean
---@field Foward boolean
---@field AutoPlay boolean
---@field Loop boolean
---@field OnComplete System.Action | function
---@field SourceSize boolean
---@field SliceImage boolean
---@field FrameCount number
UIAnimation = {}
---@alias CS.UIAnimation UIAnimation
CS.UIAnimation = UIAnimation

---@param idx number
function UIAnimation:SetSprite(idx) end
---@param gif GifAsset
function UIAnimation:SetGif(gif) end
function UIAnimation:Play() end
function UIAnimation:PlayReverse() end
function UIAnimation:Pause() end
function UIAnimation:Resume() end
function UIAnimation:Stop() end
function UIAnimation:Rewind() end

---@class UIParallax : UnityEngine.MonoBehaviour
---@field uiElements UnityEngine.RectTransform[]
---@field parallaxSpeeds System.Single[]
---@field minPositions UnityEngine.Vector2[]
---@field maxPositions UnityEngine.Vector2[]
UIParallax = {}
---@alias CS.UIParallax UIParallax
CS.UIParallax = UIParallax


---@class AnimationManager : System.Object
---@field Instance AnimationManager
AnimationManager = {}
---@alias CS.AnimationManager AnimationManager
CS.AnimationManager = AnimationManager

---@return AnimationManager
function AnimationManager.New() end
---@param obj UnityEngine.GameObject
function AnimationManager:AnimationPlay(obj) end
---@param obj UnityEngine.Transform
function AnimationManager:Tailing(obj) end

---@class ProgressButton : UnityEngine.MonoBehaviour
---@field isLongPress boolean
---@field OnPress System.Action | function
---@field progress number
---@field pressTime number
---@field maxA number
---@field acc number
---@field text TMPro.TMP_Text
ProgressButton = {}
---@alias CS.ProgressButton ProgressButton
CS.ProgressButton = ProgressButton

function ProgressButton:Awake() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function ProgressButton:OnPointerDown(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function ProgressButton:OnPointerUp(eventData) end

---@class SelectGroup : SwitchButton
SelectGroup = {}
---@alias CS.SelectGroup SelectGroup
CS.SelectGroup = SelectGroup


---@class SwitchButton : UnityEngine.MonoBehaviour
---@field Normal UnityEngine.CanvasGroup
---@field Pressed UnityEngine.CanvasGroup
---@field Highlighted UnityEngine.CanvasGroup
---@field isSingle boolean
---@field allowSwitchOff boolean
---@field animationType SwitchButton.AnimationType
---@field transitionTime number
---@field isAnimated boolean
---@field interactable boolean
---@field onValueChanged UnityEngine.Events.UnityEvent
---@field onClick UnityEngine.Events.UnityEvent
---@field isOn boolean
SwitchButton = {}
---@alias CS.SwitchButton SwitchButton
CS.SwitchButton = SwitchButton

function SwitchButton:Awake() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SwitchButton:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SwitchButton:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SwitchButton:OnPointerClick(eventData) end
---@param action System.Action | function
function SwitchButton:SetElement(action) end

---@class SwitchButton.AnimationType
---@field None SwitchButton.AnimationType
---@field Fade SwitchButton.AnimationType
SwitchButton.AnimationType = {}
---@alias CS.SwitchButton.AnimationType SwitchButton.AnimationType
CS.SwitchButton.AnimationType = SwitchButton.AnimationType


---@class SwitchButtonGroup : UnityEngine.MonoBehaviour
SwitchButtonGroup = {}
---@alias CS.SwitchButtonGroup SwitchButtonGroup
CS.SwitchButtonGroup = SwitchButtonGroup


---@class AnimatedHorizontalLayout : AnimatedLayout
AnimatedHorizontalLayout = {}
---@alias CS.AnimatedHorizontalLayout AnimatedHorizontalLayout
CS.AnimatedHorizontalLayout = AnimatedHorizontalLayout

---@param rectTransform UnityEngine.RectTransform
---@param pos number
---@param duration number
function AnimatedHorizontalLayout:SetLayout(rectTransform, pos, duration) end

---@class AnimatedLayout : UnityEngine.MonoBehaviour
---@field duration number
---@field ease DG.Tweening.Ease
---@field spacing number
---@field useScaleX boolean
---@field useScaleY boolean
AnimatedLayout = {}
---@alias CS.AnimatedLayout AnimatedLayout
CS.AnimatedLayout = AnimatedLayout

function AnimatedLayout:Start() end
function AnimatedLayout:OnTransformChildrenChanged() end
---@param duration number
function AnimatedLayout:LayoutChildren(duration) end
---@param rectTransform UnityEngine.RectTransform
---@param pos number
---@param duration number
function AnimatedLayout:SetLayout(rectTransform, pos, duration) end
function AnimatedLayout:Update() end

---@class AnimatedLayout.EnableListener : UnityEngine.MonoBehaviour
---@field layout AnimatedLayout
AnimatedLayout.EnableListener = {}
---@alias CS.AnimatedLayout.EnableListener AnimatedLayout.EnableListener
CS.AnimatedLayout.EnableListener = AnimatedLayout.EnableListener

function AnimatedLayout.EnableListener:OnEnable() end
function AnimatedLayout.EnableListener:OnDisable() end
function AnimatedLayout.EnableListener:OnDestroy() end

---@class TextWithKeyword : UnityEngine.MonoBehaviour
---@field maxDistance number
TextWithKeyword = {}
---@alias CS.TextWithKeyword TextWithKeyword
CS.TextWithKeyword = TextWithKeyword

function TextWithKeyword:Init() end
---@param pos UnityEngine.Vector2
---@param text string
function TextWithKeyword:ShowTooltip(pos, text) end
function TextWithKeyword:HideTooltip() end

---@class AchievementBase : System.Object
---@field info AchievementBase.AchievementInfo
AchievementBase = {}
---@alias CS.AchievementBase AchievementBase
CS.AchievementBase = AchievementBase

---@overload fun() : AchievementBase
---@param info AchievementBase.AchievementInfo
---@return AchievementBase
function AchievementBase.New(info) end
---@param status string
function AchievementBase:SetStatus(status) end

---@class AchievementBase.AchievementInfo : System.ValueType
---@field name string
---@field description string
---@field tip string
---@field level string
---@field status string
AchievementBase.AchievementInfo = {}
---@alias CS.AchievementBase.AchievementInfo AchievementBase.AchievementInfo
CS.AchievementBase.AchievementInfo = AchievementBase.AchievementInfo

---@param name string
---@param description string
---@param tip string
---@param level string
---@param status string
---@return AchievementBase.AchievementInfo
function AchievementBase.AchievementInfo.New(name, description, tip, level, status) end

---@class AchivementTable : System.Object
---@field table System.Collections.Generic.Dictionary
---@field ItemDic System.Collections.Generic.Dictionary
---@field count System.Collections.Generic.Dictionary
AchivementTable = {}
---@alias CS.AchivementTable AchivementTable
CS.AchivementTable = AchivementTable

---@return AchivementTable
function AchivementTable.New() end
function AchivementTable:Init() end
---@param type string
---@param achievement AchievementBase
---@return AchivementTable
function AchivementTable:Add(type, achievement) end
---@param type string
---@param name string
---@return AchivementTable
function AchivementTable:Del(type, name) end
---@param type string
---@param name string
---@param status string
---@return AchivementTable
function AchivementTable:SetAchievementStatus(type, name, status) end
---@param type string
---@return AchivementTable
function AchivementTable:SortByStatus(type) end
---@return AchivementTable
function AchivementTable:CountCalculate() end

---@class BuffItem : UnityEngine.MonoBehaviour
---@field buffBarUI Witch.UI.Window.BuffBarUI
---@field keywordDisplay Witch.UI.KeywordDisplay
---@field HasClear boolean
---@field buffConfig IBuffItemConfig
---@field status IStatusManager
---@field effectList System.Collections.ObjectModel.ObservableCollection
---@field scriptExecutor IScriptExecutor
BuffItem = {}
---@alias CS.BuffItem BuffItem
CS.BuffItem = BuffItem

---@param config BuffItemConfig
---@param Status StatusManager
---@param buffBarUI Witch.UI.Window.BuffBarUI
function BuffItem:Init(config, Status, buffBarUI) end
---@param isacting boolean
function BuffItem:BuffProcess(isacting) end
function BuffItem:EffectAnimation() end
function BuffItem:UpdateMsg() end
---@param index number
function BuffItem:UpdateSorting(index) end
function BuffItem:UpdateTooltip() end
function BuffItem:ApplyBuff() end
---@param way string
function BuffItem:DurationCheck(way) end
function BuffItem:ClearBuff() end
---@param fromId string
function BuffItem:ClearDynamicVar(fromId) end

---@class HouseItem : UnityEngine.MonoBehaviour
---@field houseUI Witch.UI.Window.HouseUI
---@field TargetCount number
---@field oriStr string
---@field houseItemType HouseItem.HouseItemType
HouseItem = {}
---@alias CS.HouseItem HouseItem
CS.HouseItem = HouseItem

function HouseItem:RegisterEvent() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function HouseItem:OnPointerClick(eventData) end

---@class HouseItem.HouseItemType
---@field CardEditor HouseItem.HouseItemType
---@field OutsiderShop HouseItem.HouseItemType
---@field ModManager HouseItem.HouseItemType
---@field GameMenu HouseItem.HouseItemType
---@field crystalBall HouseItem.HouseItemType
---@field store HouseItem.HouseItemType
---@field Dictionary HouseItem.HouseItemType
---@field shadow HouseItem.HouseItemType
---@field announcement HouseItem.HouseItemType
---@field task HouseItem.HouseItemType
HouseItem.HouseItemType = {}
---@alias CS.HouseItem.HouseItemType HouseItem.HouseItemType
CS.HouseItem.HouseItemType = HouseItem.HouseItemType


---@class MapFrame : UnityEngine.MonoBehaviour
MapFrame = {}
---@alias CS.MapFrame MapFrame
CS.MapFrame = MapFrame

---@param eventData UnityEngine.EventSystems.PointerEventData
function MapFrame:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function MapFrame:OnPointerExit(eventData) end

---@class MapItem : Witch.UI.Window.Item
---@field node MapTree.Node
---@field animationController CardAnimationController
---@field hasSelected boolean
---@field des boolean
---@field ignore boolean
---@field isReverse boolean
---@field initPosition UnityEngine.Vector2
---@field initAngle UnityEngine.Vector3
---@field draging boolean
---@field index number
---@field initScale number
---@field selectScale number
MapItem = {}
---@alias CS.MapItem MapItem
CS.MapItem = MapItem

function MapItem:Awake() end
---@param node1 MapTree.Node
function MapItem:Init(node1) end
function MapItem:DataUpdate() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function MapItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function MapItem:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function MapItem:OnPointerClick(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function MapItem:OnPointerDown(eventData) end
---@return Cysharp.Threading.Tasks.UniTask
function MapItem:StartLine() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function MapItem:OnEndDrag(eventData) end
function MapItem:OnDestroy() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function MapItem:OnDrag(eventData) end
function MapItem:RayCheck() end
function MapItem:RemoveFromParent() end
function MapItem:OnTransformParentChanged() end
---@param item SwapContentIdentity
function MapItem:AddToList(item) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function MapItem:OnBeginDrag(eventData) end
---@param Index number
function MapItem:SetIndex(Index) end

---@class MapTree : System.Object
---@field root MapTree.Node
---@field currentNode MapTree.Node
---@field treedice Dice
---@field SelectNode System.Collections.Generic.List
---@field DefaultNode System.Collections.Generic.List
---@field hasUsed System.Collections.Generic.List
MapTree = {}
---@alias CS.MapTree MapTree
CS.MapTree = MapTree

---@return MapTree
function MapTree.New() end
---@param type string
---@return MapTree.Node
function MapTree:TypeGenerate(type) end
---@param nodeId string
---@return MapTree.Node
function MapTree:GetNodeByNodeId(nodeId) end

---@class MapTree.Node : System.Object
---@field depth number
---@field type string
---@field data System.Collections.Generic.Dictionary
---@field NodeDice Dice
---@field childrens MapTree.Node[]
MapTree.Node = {}
---@alias CS.MapTree.Node MapTree.Node
CS.MapTree.Node = MapTree.Node

---@param type string
---@return MapTree.Node
function MapTree.Node.New(type) end
---@param index number
---@param child MapTree.Node
---@return MapTree.Node
function MapTree.Node:SetChild(index, child) end
---@param index number
---@return MapTree.Node
function MapTree.Node:GetChild(index) end

---@class SettingMapper : UnityEngine.MonoBehaviour
SettingMapper = {}
---@alias CS.SettingMapper SettingMapper
CS.SettingMapper = SettingMapper


---@class DialogueBox : UnityEngine.MonoBehaviour
DialogueBox = {}
---@alias CS.DialogueBox DialogueBox
CS.DialogueBox = DialogueBox

---@param dataConfig DataConfig
function DialogueBox:ShowDialogue(dataConfig) end
---@param id string
---@param emoji GifAsset
function DialogueBox:ShowEmoji(id, emoji) end
function DialogueBox:Close() end
function DialogueBox:PlayTalkEffect() end

---@class DialogueBoxIdentity : UnityEngine.MonoBehaviour
---@field Name string
DialogueBoxIdentity = {}
---@alias CS.DialogueBoxIdentity DialogueBoxIdentity
CS.DialogueBoxIdentity = DialogueBoxIdentity

function DialogueBoxIdentity:Start() end
function DialogueBoxIdentity:OnDestroy() end
---@param id string
function DialogueBoxIdentity:SetInstanceId(id) end

---@class DiceIcon : UnityEngine.MonoBehaviour
---@field result TMPro.TextMeshProUGUI
---@field bonusText TMPro.TextMeshProUGUI
---@field range TMPro.TextMeshProUGUI
---@field Target string
---@field canvasGroup UnityEngine.CanvasGroup
---@field rollDuration number
---@field value number
---@field bonus number
---@field rangeValue System.Nullable
DiceIcon = {}
---@alias CS.DiceIcon DiceIcon
CS.DiceIcon = DiceIcon

---@param title string
function DiceIcon:Roll(title) end

---@class FightLine : UnityEngine.MonoBehaviour
---@field curvature number
---@field arrowLength number
---@field show boolean
FightLine = {}
---@alias CS.FightLine FightLine
CS.FightLine = FightLine

---@param localPos UnityEngine.Vector3
function FightLine:SetStartPos(localPos) end
function FightLine:OnEnable() end
---@param uiObject UnityEngine.Transform
function FightLine:Combine(uiObject) end
---@param uiWorldPos UnityEngine.Vector3
function FightLine:SetEndPos(uiWorldPos) end
---@param start UnityEngine.Vector3
---@param control UnityEngine.Vector3
---@param _end UnityEngine.Vector3
---@param t number
---@return UnityEngine.Vector3
function FightLine:GetBezier(start, control, _end, t) end

---@class FloatingWindow : UnityEngine.MonoBehaviour
---@field buttons System.Collections.Generic.List
---@field showItem UnityEngine.Transform
---@field subitemContent UnityEngine.Transform
FloatingWindow = {}
---@alias CS.FloatingWindow FloatingWindow
CS.FloatingWindow = FloatingWindow

---@overload fun(self: FloatingWindow, obj: UnityEngine.Transform)
---@param pos UnityEngine.Vector3
function FloatingWindow:Show(pos) end
function FloatingWindow:Hide() end
---@overload fun(self: FloatingWindow, basename: string, action: UnityEngine.Events.UnityAction, subItems: System.Collections.Generic.List) : FloatingWindow
---@param button1 FloatingWindow.button
function FloatingWindow:AddButton(button1) end
---@return FloatingWindow
function FloatingWindow:Clear() end
---@return FloatingWindow
function FloatingWindow:ResetWindow() end

---@class FloatingWindow.button : System.Object
---@field name string
---@field action UnityEngine.Events.UnityAction
---@field subButtons System.Collections.Generic.List
FloatingWindow.button = {}
---@alias CS.FloatingWindow.button FloatingWindow.button
CS.FloatingWindow.button = FloatingWindow.button

---@return FloatingWindow.button
function FloatingWindow.button.New() end

---@class SelectMessage : UnityEngine.MonoBehaviour
---@field msg string
---@field ClickAction System.Action | function
SelectMessage = {}
---@alias CS.SelectMessage SelectMessage
CS.SelectMessage = SelectMessage

---@param eventData UnityEngine.EventSystems.PointerEventData
function SelectMessage:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SelectMessage:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SelectMessage:OnPointerClick(eventData) end

---@class SelectOutline : UnityEngine.MonoBehaviour
SelectOutline = {}
---@alias CS.SelectOutline SelectOutline
CS.SelectOutline = SelectOutline

---@param eventData UnityEngine.EventSystems.PointerEventData
function SelectOutline:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SelectOutline:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function SelectOutline:OnPointerClick(eventData) end

---@class SwapContentIdentity : UnityEngine.MonoBehaviour
---@field ItemName string
---@field Content UnityEngine.Transform
---@field CheckType boolean
SwapContentIdentity = {}
---@alias CS.SwapContentIdentity SwapContentIdentity
CS.SwapContentIdentity = SwapContentIdentity


---@class Tooltip : UnityEngine.MonoBehaviour
---@field spacingX number
---@field spacingY number
---@field subWidth number
---@field subHeight number
---@field transitionTime number
Tooltip = {}
---@alias CS.Tooltip Tooltip
CS.Tooltip = Tooltip

---@param obj UnityEngine.Transform
---@param title string
---@param text string
---@param keywords System.Collections.Generic.List
---@param msg string
---@param icon UnityEngine.Sprite
---@param type string
---@param Main boolean
---@param Sub boolean
function Tooltip:Show(obj, title, text, keywords, msg, icon, type, Main, Sub) end
function Tooltip:Hide() end

---@class XluaEventVarUse : System.Object
---@field XLua_CSharpCallLua_Delegates System.Collections.Generic.List
XluaEventVarUse = {}
---@alias CS.XluaEventVarUse XluaEventVarUse
CS.XluaEventVarUse = XluaEventVarUse


---@class ExampleGenConfig : System.Object
---@field LuaCallCSharp System.Collections.Generic.List
---@field CSharpCallLua System.Collections.Generic.List
---@field BlackList System.Collections.Generic.List
---@field BlackGenericTypeList System.Collections.Generic.List
---@field GenericTypeFilter System.Func
ExampleGenConfig = {}
---@alias CS.ExampleGenConfig ExampleGenConfig
CS.ExampleGenConfig = ExampleGenConfig


---@class LuaCallCs : UnityEngine.MonoBehaviour
LuaCallCs = {}
---@alias CS.LuaCallCs LuaCallCs
CS.LuaCallCs = LuaCallCs


---@class DataConfigFormatterInitializer : System.Object
DataConfigFormatterInitializer = {}
---@alias CS.DataConfigFormatterInitializer DataConfigFormatterInitializer
CS.DataConfigFormatterInitializer = DataConfigFormatterInitializer

function DataConfigFormatterInitializer.RegisterFormatter() end

---@class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : System.Object
UnitySourceGeneratedAssemblyMonoScriptTypes_v1 = {}
---@alias CS.UnitySourceGeneratedAssemblyMonoScriptTypes_v1 UnitySourceGeneratedAssemblyMonoScriptTypes_v1
CS.UnitySourceGeneratedAssemblyMonoScriptTypes_v1 = UnitySourceGeneratedAssemblyMonoScriptTypes_v1

---@return UnitySourceGeneratedAssemblyMonoScriptTypes_v1
function UnitySourceGeneratedAssemblyMonoScriptTypes_v1.New() end

---@class UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData : System.ValueType
---@field FilePathsData System.Byte[]
---@field TypesData System.Byte[]
---@field TotalTypes number
---@field TotalFiles number
---@field IsEditorOnly boolean
UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData = {}
---@alias CS.UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData
CS.UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData = UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData


---@class Tutorial.CSCallLua : UnityEngine.MonoBehaviour
Tutorial.CSCallLua = {}
---@alias CS.Tutorial.CSCallLua Tutorial.CSCallLua
CS.Tutorial.CSCallLua = Tutorial.CSCallLua


---@class Tutorial.CSCallLua.DClass : System.Object
---@field f1 number
---@field f2 number
Tutorial.CSCallLua.DClass = {}
---@alias CS.Tutorial.CSCallLua.DClass Tutorial.CSCallLua.DClass
CS.Tutorial.CSCallLua.DClass = Tutorial.CSCallLua.DClass

---@return Tutorial.CSCallLua.DClass
function Tutorial.CSCallLua.DClass.New() end

---@class Tutorial.CSCallLua.ItfD
---@field f1 number
---@field f2 number
Tutorial.CSCallLua.ItfD = {}
---@alias CS.Tutorial.CSCallLua.ItfD Tutorial.CSCallLua.ItfD
CS.Tutorial.CSCallLua.ItfD = Tutorial.CSCallLua.ItfD

---@param a number
---@param b number
---@return number
function Tutorial.CSCallLua.ItfD:add(a, b) end

---@class Tutorial.CSCallLua.FDelegate : System.MulticastDelegate
Tutorial.CSCallLua.FDelegate = {}
---@alias CS.Tutorial.CSCallLua.FDelegate Tutorial.CSCallLua.FDelegate
CS.Tutorial.CSCallLua.FDelegate = Tutorial.CSCallLua.FDelegate

---@param object System.Object
---@param method System.IntPtr
---@return Tutorial.CSCallLua.FDelegate
function Tutorial.CSCallLua.FDelegate.New(object, method) end
---@param a number
---@param b string
---@param out_c Tutorial.CSCallLua.DClass
---@return number,Tutorial.CSCallLua.DClass
function Tutorial.CSCallLua.FDelegate:Invoke(a, b, out_c) end
---@param a number
---@param b string
---@param out_c Tutorial.CSCallLua.DClass
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult,Tutorial.CSCallLua.DClass
function Tutorial.CSCallLua.FDelegate:BeginInvoke(a, b, out_c, callback, object) end
---@param out_c Tutorial.CSCallLua.DClass
---@param result System.IAsyncResult
---@return number,Tutorial.CSCallLua.DClass
function Tutorial.CSCallLua.FDelegate:EndInvoke(out_c, result) end

---@class Tutorial.CSCallLua.GetE : System.MulticastDelegate
Tutorial.CSCallLua.GetE = {}
---@alias CS.Tutorial.CSCallLua.GetE Tutorial.CSCallLua.GetE
CS.Tutorial.CSCallLua.GetE = Tutorial.CSCallLua.GetE

---@param object System.Object
---@param method System.IntPtr
---@return Tutorial.CSCallLua.GetE
function Tutorial.CSCallLua.GetE.New(object, method) end
---@return System.Action | function
function Tutorial.CSCallLua.GetE:Invoke() end
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function Tutorial.CSCallLua.GetE:BeginInvoke(callback, object) end
---@param result System.IAsyncResult
---@return System.Action | function
function Tutorial.CSCallLua.GetE:EndInvoke(result) end

---@class Tutorial.ByFile : UnityEngine.MonoBehaviour
Tutorial.ByFile = {}
---@alias CS.Tutorial.ByFile Tutorial.ByFile
CS.Tutorial.ByFile = Tutorial.ByFile


---@class Tutorial.ByString : UnityEngine.MonoBehaviour
Tutorial.ByString = {}
---@alias CS.Tutorial.ByString Tutorial.ByString
CS.Tutorial.ByString = Tutorial.ByString


---@class Tutorial.CustomLoader : UnityEngine.MonoBehaviour
Tutorial.CustomLoader = {}
---@alias CS.Tutorial.CustomLoader Tutorial.CustomLoader
CS.Tutorial.CustomLoader = Tutorial.CustomLoader


---@class Tutorial.BaseClass : System.Object
---@field BSF number
---@field BMF number
Tutorial.BaseClass = {}
---@alias CS.Tutorial.BaseClass Tutorial.BaseClass
CS.Tutorial.BaseClass = Tutorial.BaseClass

---@return Tutorial.BaseClass
function Tutorial.BaseClass.New() end
function Tutorial.BaseClass.BSFunc() end
function Tutorial.BaseClass:BMFunc() end
---@return number
function Tutorial.BaseClass:GetSomeBaseData() end

---@class Tutorial.Param1 : System.ValueType
---@field x number
---@field y string
Tutorial.Param1 = {}
---@alias CS.Tutorial.Param1 Tutorial.Param1
CS.Tutorial.Param1 = Tutorial.Param1


---@class Tutorial.TestEnum
---@field E1 Tutorial.TestEnum
---@field E2 Tutorial.TestEnum
Tutorial.TestEnum = {}
---@alias CS.Tutorial.TestEnum Tutorial.TestEnum
CS.Tutorial.TestEnum = Tutorial.TestEnum


---@class Tutorial.DerivedClass : Tutorial.BaseClass
---@field TestDelegate System.Action | function
---@field DMF number
Tutorial.DerivedClass = {}
---@alias CS.Tutorial.DerivedClass Tutorial.DerivedClass
CS.Tutorial.DerivedClass = Tutorial.DerivedClass

---@return Tutorial.DerivedClass
function Tutorial.DerivedClass.New() end
function Tutorial.DerivedClass:DMFunc() end
---@param p1 Tutorial.Param1
---@param ref_p2 number
---@param out_p3 string
---@param luafunc System.Action | function
---@param out_csfunc System.Action | function
---@return number,number,string,System.Action
function Tutorial.DerivedClass:ComplexFunc(p1, ref_p2, out_p3, luafunc, out_csfunc) end
---@overload fun(self: Tutorial.DerivedClass, i: number)
---@param i string
function Tutorial.DerivedClass:TestFunc(i) end
---@param a number
---@param b string
---@param c string
function Tutorial.DerivedClass:DefaultValueFunc(a, b, c) end
---@param a number
---@param strs System.String[]
function Tutorial.DerivedClass:VariableParamsFunc(a, strs) end
---@param e Tutorial.TestEnum
---@return Tutorial.TestEnum
function Tutorial.DerivedClass:EnumTestFunc(e) end
function Tutorial.DerivedClass:CallEvent() end
---@param n number
---@return number
function Tutorial.DerivedClass:TestLong(n) end
---@return Tutorial.ICalc
function Tutorial.DerivedClass:GetCalc() end
---@return number
function Tutorial.DerivedClass:GetSomeData() end
function Tutorial.DerivedClass:GenericMethodOfString() end

---@class Tutorial.DerivedClass.TestEnumInner
---@field E3 Tutorial.DerivedClass.TestEnumInner
---@field E4 Tutorial.DerivedClass.TestEnumInner
Tutorial.DerivedClass.TestEnumInner = {}
---@alias CS.Tutorial.DerivedClass.TestEnumInner Tutorial.DerivedClass.TestEnumInner
CS.Tutorial.DerivedClass.TestEnumInner = Tutorial.DerivedClass.TestEnumInner


---@class Tutorial.DerivedClass.InnerCalc : System.Object
---@field id number
Tutorial.DerivedClass.InnerCalc = {}
---@alias CS.Tutorial.DerivedClass.InnerCalc Tutorial.DerivedClass.InnerCalc
CS.Tutorial.DerivedClass.InnerCalc = Tutorial.DerivedClass.InnerCalc

---@return Tutorial.DerivedClass.InnerCalc
function Tutorial.DerivedClass.InnerCalc.New() end
---@param a number
---@param b number
---@return number
function Tutorial.DerivedClass.InnerCalc:add(a, b) end

---@class Tutorial.ICalc
Tutorial.ICalc = {}
---@alias CS.Tutorial.ICalc Tutorial.ICalc
CS.Tutorial.ICalc = Tutorial.ICalc

---@param a number
---@param b number
---@return number
function Tutorial.ICalc:add(a, b) end

---@class Tutorial.DerivedClassExtensions : System.Object
Tutorial.DerivedClassExtensions = {}
---@alias CS.Tutorial.DerivedClassExtensions Tutorial.DerivedClassExtensions
CS.Tutorial.DerivedClassExtensions = Tutorial.DerivedClassExtensions

---@param obj Tutorial.DerivedClass
---@return number
function Tutorial.DerivedClassExtensions.GetSomeData(obj) end
---@param obj Tutorial.BaseClass
---@return number
function Tutorial.DerivedClassExtensions.GetSomeBaseData(obj) end
---@param obj Tutorial.DerivedClass
function Tutorial.DerivedClassExtensions.GenericMethodOfString(obj) end

---@class XLua.DelegateBridge : XLua.DelegateBridgeBase
---@field Gen_Flag boolean
XLua.DelegateBridge = {}
---@alias CS.XLua.DelegateBridge XLua.DelegateBridge
CS.XLua.DelegateBridge = XLua.DelegateBridge

---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.DelegateBridge
function XLua.DelegateBridge.New(reference, luaenv) end
---@param p0 ActionData
function XLua.DelegateBridge:__Gen_Delegate_Imp0(p0) end
---@param p0 HurtData
function XLua.DelegateBridge:__Gen_Delegate_Imp1(p0) end
---@param p0 DamageData
function XLua.DelegateBridge:__Gen_Delegate_Imp2(p0) end
---@param p0 NewEnemyData
function XLua.DelegateBridge:__Gen_Delegate_Imp3(p0) end
function XLua.DelegateBridge:__Gen_Delegate_Imp4() end
---@param p0 number
---@param p1 number
---@return number
function XLua.DelegateBridge:__Gen_Delegate_Imp5(p0, p1) end
---@param p0 string
function XLua.DelegateBridge:__Gen_Delegate_Imp6(p0) end
---@param p0 number
function XLua.DelegateBridge:__Gen_Delegate_Imp7(p0) end
---@param p0 number
---@param p1 string
---@param out_p2 Tutorial.CSCallLua.DClass
---@return number,Tutorial.CSCallLua.DClass
function XLua.DelegateBridge:__Gen_Delegate_Imp8(p0, p1, out_p2) end
---@return System.Action | function
function XLua.DelegateBridge:__Gen_Delegate_Imp9() end
---@param type System.Type
---@return System.Delegate
function XLua.DelegateBridge:GetDelegateByType(type) end
---@param L System.IntPtr
---@param nArgs number
---@param nResults number
---@param errFunc number
function XLua.DelegateBridge:PCall(L, nArgs, nResults, errFunc) end
function XLua.DelegateBridge:Action() end

---@class XLua.CopyByValue : System.Object
XLua.CopyByValue = {}
---@alias CS.XLua.CopyByValue XLua.CopyByValue
CS.XLua.CopyByValue = XLua.CopyByValue

---@overload fun(translator: XLua.ObjectTranslator, L: System.IntPtr, idx: number, out_val: UnityEngine.Vector2) : UnityEngine.Vector2
---@overload fun(buff: System.IntPtr, offset: number, out_field: UnityEngine.Vector2) : boolean, UnityEngine.Vector2
---@overload fun(translator: XLua.ObjectTranslator, L: System.IntPtr, idx: number, out_val: UnityEngine.Vector3) : UnityEngine.Vector3
---@overload fun(buff: System.IntPtr, offset: number, out_field: UnityEngine.Vector3) : boolean, UnityEngine.Vector3
---@overload fun(translator: XLua.ObjectTranslator, L: System.IntPtr, idx: number, out_val: UnityEngine.Vector4) : UnityEngine.Vector4
---@overload fun(buff: System.IntPtr, offset: number, out_field: UnityEngine.Vector4) : boolean, UnityEngine.Vector4
---@overload fun(translator: XLua.ObjectTranslator, L: System.IntPtr, idx: number, out_val: UnityEngine.Color) : UnityEngine.Color
---@overload fun(buff: System.IntPtr, offset: number, out_field: UnityEngine.Color) : boolean, UnityEngine.Color
---@overload fun(translator: XLua.ObjectTranslator, L: System.IntPtr, idx: number, out_val: UnityEngine.Quaternion) : UnityEngine.Quaternion
---@overload fun(buff: System.IntPtr, offset: number, out_field: UnityEngine.Quaternion) : boolean, UnityEngine.Quaternion
---@overload fun(translator: XLua.ObjectTranslator, L: System.IntPtr, idx: number, out_val: UnityEngine.Ray) : UnityEngine.Ray
---@overload fun(buff: System.IntPtr, offset: number, out_field: UnityEngine.Ray) : boolean, UnityEngine.Ray
---@overload fun(translator: XLua.ObjectTranslator, L: System.IntPtr, idx: number, out_val: UnityEngine.Bounds) : UnityEngine.Bounds
---@overload fun(buff: System.IntPtr, offset: number, out_field: UnityEngine.Bounds) : boolean, UnityEngine.Bounds
---@overload fun(translator: XLua.ObjectTranslator, L: System.IntPtr, idx: number, out_val: UnityEngine.Ray2D) : UnityEngine.Ray2D
---@overload fun(buff: System.IntPtr, offset: number, out_field: UnityEngine.Ray2D) : boolean, UnityEngine.Ray2D
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@overload fun(buff: System.IntPtr, offset: number, out_field: number) : boolean, number
---@param buff System.IntPtr
---@param offset number
---@param out_field System.Decimal
---@return boolean,System.Decimal
function XLua.CopyByValue.UnPack(buff, offset, out_field) end
---@overload fun(buff: System.IntPtr, offset: number, field: UnityEngine.Vector2) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: UnityEngine.Vector3) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: UnityEngine.Vector4) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: UnityEngine.Color) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: UnityEngine.Quaternion) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: UnityEngine.Ray) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: UnityEngine.Bounds) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: UnityEngine.Ray2D) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@overload fun(buff: System.IntPtr, offset: number, field: number) : boolean
---@param buff System.IntPtr
---@param offset number
---@param field System.Decimal
---@return boolean
function XLua.CopyByValue.Pack(buff, offset, field) end
---@param type System.Type
---@return boolean
function XLua.CopyByValue.IsStruct(type) end

---@class XLua.ObjectTranslator : System.Object
---@field cacheRef number
XLua.ObjectTranslator = {}
---@alias CS.XLua.ObjectTranslator XLua.ObjectTranslator
CS.XLua.ObjectTranslator = XLua.ObjectTranslator

---@param luaenv XLua.LuaEnv
---@param L System.IntPtr
---@return XLua.ObjectTranslator
function XLua.ObjectTranslator.New(luaenv, L) end
---@param L System.IntPtr
---@param val UnityEngine.Vector2
function XLua.ObjectTranslator:PushUnityEngineVector2(L, val) end
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: UnityEngine.Vector2) : UnityEngine.Vector2
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: UnityEngine.Vector3) : UnityEngine.Vector3
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: UnityEngine.Vector4) : UnityEngine.Vector4
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: UnityEngine.Color) : UnityEngine.Color
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: UnityEngine.Quaternion) : UnityEngine.Quaternion
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: UnityEngine.Ray) : UnityEngine.Ray
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: UnityEngine.Bounds) : UnityEngine.Bounds
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: UnityEngine.Ray2D) : UnityEngine.Ray2D
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: Tutorial.TestEnum) : Tutorial.TestEnum
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, index: number, out_val: Tutorial.DerivedClass.TestEnumInner) : Tutorial.DerivedClass.TestEnumInner
---@param L System.IntPtr
---@param index number
---@param out_val System.Decimal
---@return ,System.Decimal
function XLua.ObjectTranslator:Get(L, index, out_val) end
---@param L System.IntPtr
---@param index number
---@param val UnityEngine.Vector2
function XLua.ObjectTranslator:UpdateUnityEngineVector2(L, index, val) end
---@param L System.IntPtr
---@param val UnityEngine.Vector3
function XLua.ObjectTranslator:PushUnityEngineVector3(L, val) end
---@param L System.IntPtr
---@param index number
---@param val UnityEngine.Vector3
function XLua.ObjectTranslator:UpdateUnityEngineVector3(L, index, val) end
---@param L System.IntPtr
---@param val UnityEngine.Vector4
function XLua.ObjectTranslator:PushUnityEngineVector4(L, val) end
---@param L System.IntPtr
---@param index number
---@param val UnityEngine.Vector4
function XLua.ObjectTranslator:UpdateUnityEngineVector4(L, index, val) end
---@param L System.IntPtr
---@param val UnityEngine.Color
function XLua.ObjectTranslator:PushUnityEngineColor(L, val) end
---@param L System.IntPtr
---@param index number
---@param val UnityEngine.Color
function XLua.ObjectTranslator:UpdateUnityEngineColor(L, index, val) end
---@param L System.IntPtr
---@param val UnityEngine.Quaternion
function XLua.ObjectTranslator:PushUnityEngineQuaternion(L, val) end
---@param L System.IntPtr
---@param index number
---@param val UnityEngine.Quaternion
function XLua.ObjectTranslator:UpdateUnityEngineQuaternion(L, index, val) end
---@param L System.IntPtr
---@param val UnityEngine.Ray
function XLua.ObjectTranslator:PushUnityEngineRay(L, val) end
---@param L System.IntPtr
---@param index number
---@param val UnityEngine.Ray
function XLua.ObjectTranslator:UpdateUnityEngineRay(L, index, val) end
---@param L System.IntPtr
---@param val UnityEngine.Bounds
function XLua.ObjectTranslator:PushUnityEngineBounds(L, val) end
---@param L System.IntPtr
---@param index number
---@param val UnityEngine.Bounds
function XLua.ObjectTranslator:UpdateUnityEngineBounds(L, index, val) end
---@param L System.IntPtr
---@param val UnityEngine.Ray2D
function XLua.ObjectTranslator:PushUnityEngineRay2D(L, val) end
---@param L System.IntPtr
---@param index number
---@param val UnityEngine.Ray2D
function XLua.ObjectTranslator:UpdateUnityEngineRay2D(L, index, val) end
---@param L System.IntPtr
---@param val Tutorial.TestEnum
function XLua.ObjectTranslator:PushTutorialTestEnum(L, val) end
---@param L System.IntPtr
---@param index number
---@param val Tutorial.TestEnum
function XLua.ObjectTranslator:UpdateTutorialTestEnum(L, index, val) end
---@param L System.IntPtr
---@param val Tutorial.DerivedClass.TestEnumInner
function XLua.ObjectTranslator:PushTutorialDerivedClassTestEnumInner(L, val) end
---@param L System.IntPtr
---@param index number
---@param val Tutorial.DerivedClass.TestEnumInner
function XLua.ObjectTranslator:UpdateTutorialDerivedClassTestEnumInner(L, index, val) end
---@param type System.Type
---@param loader System.Action | function
function XLua.ObjectTranslator:DelayWrapLoader(type, loader) end
---@param type System.Type
---@param creator System.Func
function XLua.ObjectTranslator:AddInterfaceBridgeCreator(type, creator) end
---@param L System.IntPtr
---@param type System.Type
---@return boolean
function XLua.ObjectTranslator:TryDelayWrapLoader(L, type) end
---@param type System.Type
---@param alias string
function XLua.ObjectTranslator:Alias(type, alias) end
---@param L System.IntPtr
---@param delegateType System.Type
---@param idx number
---@return System.Object
function XLua.ObjectTranslator:CreateDelegateBridge(L, delegateType, idx) end
---@return boolean
function XLua.ObjectTranslator:AllDelegateBridgeReleased() end
---@param L System.IntPtr
---@param reference number
---@param is_delegate boolean
function XLua.ObjectTranslator:ReleaseLuaBase(L, reference, is_delegate) end
---@param L System.IntPtr
---@param interfaceType System.Type
---@param idx number
---@return System.Object
function XLua.ObjectTranslator:CreateInterfaceBridge(L, interfaceType, idx) end
---@param L System.IntPtr
function XLua.ObjectTranslator:CreateArrayMetatable(L) end
---@param L System.IntPtr
function XLua.ObjectTranslator:CreateDelegateMetatable(L) end
---@param L System.IntPtr
function XLua.ObjectTranslator:OpenLib(L) end
---@param L System.IntPtr
---@param idx number
---@return System.Type
function XLua.ObjectTranslator:GetTypeOf(L, idx) end
---@param L System.IntPtr
---@param index number
---@param type System.Type
---@return boolean
function XLua.ObjectTranslator:Assignable(L, index, type) end
---@param L System.IntPtr
---@param index number
---@param type System.Type
---@return System.Object
function XLua.ObjectTranslator:GetObject(L, index, type) end
---@param L System.IntPtr
---@param index number
---@param type System.Type
---@return System.Array
function XLua.ObjectTranslator:GetParams(L, index, type) end
---@param L System.IntPtr
---@param ary System.Array
function XLua.ObjectTranslator:PushParams(L, ary) end
---@param L System.IntPtr
---@param type System.Type
---@return number
function XLua.ObjectTranslator:GetTypeId(L, type) end
---@param L System.IntPtr
---@param type System.Type
function XLua.ObjectTranslator:PrivateAccessible(L, type) end
---@param L System.IntPtr
---@param o System.Object
function XLua.ObjectTranslator:PushAny(L, o) end
---@param L System.IntPtr
---@param type System.Type
---@param idx number
---@return number
function XLua.ObjectTranslator:TranslateToEnumToTop(L, type, idx) end
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, o: XLua.LuaDLL.lua_CSFunction)
---@overload fun(self: XLua.ObjectTranslator, L: System.IntPtr, o: XLua.LuaBase)
---@param L System.IntPtr
---@param o System.Object
function XLua.ObjectTranslator:Push(L, o) end
---@param L System.IntPtr
---@param o System.Object
---@param type_id number
function XLua.ObjectTranslator:PushObject(L, o, type_id) end
---@param L System.IntPtr
---@param index number
---@param obj System.Object
function XLua.ObjectTranslator:Update(L, index, obj) end
---@param type System.Type
---@return boolean
function XLua.ObjectTranslator:HasCustomOp(type) end
---@param L System.IntPtr
---@param val System.Decimal
function XLua.ObjectTranslator:PushDecimal(L, val) end
---@param L System.IntPtr
---@param index number
---@return boolean
function XLua.ObjectTranslator:IsDecimal(L, index) end
---@param L System.IntPtr
---@param index number
---@return System.Decimal
function XLua.ObjectTranslator:GetDecimal(L, index) end

---@class XLua.ObjectTranslator.IniterAdderUnityEngineVector2 : System.Object
XLua.ObjectTranslator.IniterAdderUnityEngineVector2 = {}
---@alias CS.XLua.ObjectTranslator.IniterAdderUnityEngineVector2 XLua.ObjectTranslator.IniterAdderUnityEngineVector2
CS.XLua.ObjectTranslator.IniterAdderUnityEngineVector2 = XLua.ObjectTranslator.IniterAdderUnityEngineVector2

---@return XLua.ObjectTranslator.IniterAdderUnityEngineVector2
function XLua.ObjectTranslator.IniterAdderUnityEngineVector2.New() end

---@class XLua.ObjectTranslator.LOGLEVEL
---@field NO XLua.ObjectTranslator.LOGLEVEL
---@field INFO XLua.ObjectTranslator.LOGLEVEL
---@field WARN XLua.ObjectTranslator.LOGLEVEL
---@field ERROR XLua.ObjectTranslator.LOGLEVEL
XLua.ObjectTranslator.LOGLEVEL = {}
---@alias CS.XLua.ObjectTranslator.LOGLEVEL XLua.ObjectTranslator.LOGLEVEL
CS.XLua.ObjectTranslator.LOGLEVEL = XLua.ObjectTranslator.LOGLEVEL


---@class XLua.ObjectTranslator.CompareByArgRet : System.Object
XLua.ObjectTranslator.CompareByArgRet = {}
---@alias CS.XLua.ObjectTranslator.CompareByArgRet XLua.ObjectTranslator.CompareByArgRet
CS.XLua.ObjectTranslator.CompareByArgRet = XLua.ObjectTranslator.CompareByArgRet

---@return XLua.ObjectTranslator.CompareByArgRet
function XLua.ObjectTranslator.CompareByArgRet.New() end
---@param x System.Reflection.MethodInfo
---@param y System.Reflection.MethodInfo
---@return boolean
function XLua.ObjectTranslator.CompareByArgRet:Equals(x, y) end
---@param method System.Reflection.MethodInfo
---@return number
function XLua.ObjectTranslator.CompareByArgRet:GetHashCode(method) end

---@class XLua.ObjectTranslator.PushCSObject : System.MulticastDelegate
XLua.ObjectTranslator.PushCSObject = {}
---@alias CS.XLua.ObjectTranslator.PushCSObject XLua.ObjectTranslator.PushCSObject
CS.XLua.ObjectTranslator.PushCSObject = XLua.ObjectTranslator.PushCSObject

---@param object System.Object
---@param method System.IntPtr
---@return XLua.ObjectTranslator.PushCSObject
function XLua.ObjectTranslator.PushCSObject.New(object, method) end
---@param L System.IntPtr
---@param obj System.Object
function XLua.ObjectTranslator.PushCSObject:Invoke(L, obj) end
---@param L System.IntPtr
---@param obj System.Object
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.ObjectTranslator.PushCSObject:BeginInvoke(L, obj, callback, object) end
---@param result System.IAsyncResult
function XLua.ObjectTranslator.PushCSObject:EndInvoke(result) end

---@class XLua.ObjectTranslator.GetCSObject : System.MulticastDelegate
XLua.ObjectTranslator.GetCSObject = {}
---@alias CS.XLua.ObjectTranslator.GetCSObject XLua.ObjectTranslator.GetCSObject
CS.XLua.ObjectTranslator.GetCSObject = XLua.ObjectTranslator.GetCSObject

---@param object System.Object
---@param method System.IntPtr
---@return XLua.ObjectTranslator.GetCSObject
function XLua.ObjectTranslator.GetCSObject.New(object, method) end
---@param L System.IntPtr
---@param idx number
---@return System.Object
function XLua.ObjectTranslator.GetCSObject:Invoke(L, idx) end
---@param L System.IntPtr
---@param idx number
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.ObjectTranslator.GetCSObject:BeginInvoke(L, idx, callback, object) end
---@param result System.IAsyncResult
---@return System.Object
function XLua.ObjectTranslator.GetCSObject:EndInvoke(result) end

---@class XLua.ObjectTranslator.UpdateCSObject : System.MulticastDelegate
XLua.ObjectTranslator.UpdateCSObject = {}
---@alias CS.XLua.ObjectTranslator.UpdateCSObject XLua.ObjectTranslator.UpdateCSObject
CS.XLua.ObjectTranslator.UpdateCSObject = XLua.ObjectTranslator.UpdateCSObject

---@param object System.Object
---@param method System.IntPtr
---@return XLua.ObjectTranslator.UpdateCSObject
function XLua.ObjectTranslator.UpdateCSObject.New(object, method) end
---@param L System.IntPtr
---@param idx number
---@param obj System.Object
function XLua.ObjectTranslator.UpdateCSObject:Invoke(L, idx, obj) end
---@param L System.IntPtr
---@param idx number
---@param obj System.Object
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.ObjectTranslator.UpdateCSObject:BeginInvoke(L, idx, obj, callback, object) end
---@param result System.IAsyncResult
function XLua.ObjectTranslator.UpdateCSObject:EndInvoke(result) end

---@class XLua.ObjectTranslator.CheckFunc : System.MulticastDelegate
XLua.ObjectTranslator.CheckFunc = {}
---@alias CS.XLua.ObjectTranslator.CheckFunc XLua.ObjectTranslator.CheckFunc
CS.XLua.ObjectTranslator.CheckFunc = XLua.ObjectTranslator.CheckFunc

---@param object System.Object
---@param method System.IntPtr
---@return XLua.ObjectTranslator.CheckFunc
function XLua.ObjectTranslator.CheckFunc.New(object, method) end
---@param L System.IntPtr
---@param idx number
---@return boolean
function XLua.ObjectTranslator.CheckFunc:Invoke(L, idx) end
---@param L System.IntPtr
---@param idx number
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.ObjectTranslator.CheckFunc:BeginInvoke(L, idx, callback, object) end
---@param result System.IAsyncResult
---@return boolean
function XLua.ObjectTranslator.CheckFunc:EndInvoke(result) end

---@class XLua.ObjectTranslator.GetFunc : System.MulticastDelegate
XLua.ObjectTranslator.GetFunc = {}
---@alias CS.XLua.ObjectTranslator.GetFunc XLua.ObjectTranslator.GetFunc
CS.XLua.ObjectTranslator.GetFunc = XLua.ObjectTranslator.GetFunc

---@param object System.Object
---@param method System.IntPtr
---@return XLua.ObjectTranslator.GetFunc
function XLua.ObjectTranslator.GetFunc.New(object, method) end
---@param L System.IntPtr
---@param idx number
---@param out_val T
---@return ,T
function XLua.ObjectTranslator.GetFunc:Invoke(L, idx, out_val) end
---@param L System.IntPtr
---@param idx number
---@param out_val T
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult,T
function XLua.ObjectTranslator.GetFunc:BeginInvoke(L, idx, out_val, callback, object) end
---@param out_val T
---@param result System.IAsyncResult
---@return ,T
function XLua.ObjectTranslator.GetFunc:EndInvoke(out_val, result) end

---@class XLua.StaticLuaCallbacks : System.Object
XLua.StaticLuaCallbacks = {}
---@alias CS.XLua.StaticLuaCallbacks XLua.StaticLuaCallbacks
CS.XLua.StaticLuaCallbacks = XLua.StaticLuaCallbacks

---@return XLua.StaticLuaCallbacks
function XLua.StaticLuaCallbacks.New() end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.EnumAnd(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.EnumOr(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.DelegateCall(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.LuaGC(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.ToString(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.DelegateCombine(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.DelegateRemove(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.ArrayIndexer(L) end
---@param type System.Type
---@param L System.IntPtr
---@param obj System.Object
---@param array_idx number
---@param obj_idx number
---@return boolean
function XLua.StaticLuaCallbacks.TryPrimitiveArraySet(type, L, obj, array_idx, obj_idx) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.ArrayNewIndexer(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.ArrayLength(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.MetaFuncIndex(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.LoadAssembly(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.ImportType(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.ImportGenericType(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.Cast(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.XLuaAccess(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.XLuaPrivateAccessible(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.XLuaMetatableOperation(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.DelegateConstructor(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.ToFunction(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.GenericMethodWraper(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.GetGenericMethod(L) end
---@param L System.IntPtr
---@return number
function XLua.StaticLuaCallbacks.ReleaseCsObject(L) end

---@class XLua.InternalGlobals : System.Object
XLua.InternalGlobals = {}
---@alias CS.XLua.InternalGlobals XLua.InternalGlobals
CS.XLua.InternalGlobals = XLua.InternalGlobals

---@return XLua.InternalGlobals
function XLua.InternalGlobals.New() end

---@class XLua.InternalGlobals.TryArrayGet : System.MulticastDelegate
XLua.InternalGlobals.TryArrayGet = {}
---@alias CS.XLua.InternalGlobals.TryArrayGet XLua.InternalGlobals.TryArrayGet
CS.XLua.InternalGlobals.TryArrayGet = XLua.InternalGlobals.TryArrayGet

---@param object System.Object
---@param method System.IntPtr
---@return XLua.InternalGlobals.TryArrayGet
function XLua.InternalGlobals.TryArrayGet.New(object, method) end
---@param type System.Type
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
---@param obj System.Object
---@param index number
---@return boolean
function XLua.InternalGlobals.TryArrayGet:Invoke(type, L, translator, obj, index) end
---@param type System.Type
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
---@param obj System.Object
---@param index number
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.InternalGlobals.TryArrayGet:BeginInvoke(type, L, translator, obj, index, callback, object) end
---@param result System.IAsyncResult
---@return boolean
function XLua.InternalGlobals.TryArrayGet:EndInvoke(result) end

---@class XLua.InternalGlobals.TryArraySet : System.MulticastDelegate
XLua.InternalGlobals.TryArraySet = {}
---@alias CS.XLua.InternalGlobals.TryArraySet XLua.InternalGlobals.TryArraySet
CS.XLua.InternalGlobals.TryArraySet = XLua.InternalGlobals.TryArraySet

---@param object System.Object
---@param method System.IntPtr
---@return XLua.InternalGlobals.TryArraySet
function XLua.InternalGlobals.TryArraySet.New(object, method) end
---@param type System.Type
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
---@param obj System.Object
---@param array_idx number
---@param obj_idx number
---@return boolean
function XLua.InternalGlobals.TryArraySet:Invoke(type, L, translator, obj, array_idx, obj_idx) end
---@param type System.Type
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
---@param obj System.Object
---@param array_idx number
---@param obj_idx number
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.InternalGlobals.TryArraySet:BeginInvoke(type, L, translator, obj, array_idx, obj_idx, callback, object) end
---@param result System.IAsyncResult
---@return boolean
function XLua.InternalGlobals.TryArraySet:EndInvoke(result) end

---@class XLua.CodeEmit : System.Object
XLua.CodeEmit = {}
---@alias CS.XLua.CodeEmit XLua.CodeEmit
CS.XLua.CodeEmit = XLua.CodeEmit

---@return XLua.CodeEmit
function XLua.CodeEmit.New() end
---@param groups System.Collections.Generic.IEnumerable
---@return System.Type
function XLua.CodeEmit:EmitDelegateImpl(groups) end
---@param gen_interfaces System.Collections.Generic.List
function XLua.CodeEmit:SetGenInterfaces(gen_interfaces) end
---@param to_be_impl System.Type
---@return System.Type
function XLua.CodeEmit:EmitInterfaceImpl(to_be_impl) end
---@param typeBuilder System.Reflection.Emit.TypeBuilder
---@param field System.Reflection.FieldInfo
---@param genGetter boolean
---@return System.Reflection.Emit.MethodBuilder
function XLua.CodeEmit:emitFieldWrap(typeBuilder, field, genGetter) end
---@param typeBuilder System.Reflection.Emit.TypeBuilder
---@param prop System.Reflection.PropertyInfo
---@param op System.Reflection.MethodInfo
---@param genGetter boolean
---@return System.Reflection.Emit.MethodBuilder
function XLua.CodeEmit:emitPropertyWrap(typeBuilder, prop, op, genGetter) end
---@param toBeWrap System.Type
---@return System.Type
function XLua.CodeEmit:EmitTypeWrap(toBeWrap) end

---@class XLua.DelegateBridgeBase : XLua.LuaBase
XLua.DelegateBridgeBase = {}
---@alias CS.XLua.DelegateBridgeBase XLua.DelegateBridgeBase
CS.XLua.DelegateBridgeBase = XLua.DelegateBridgeBase

---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.DelegateBridgeBase
function XLua.DelegateBridgeBase.New(reference, luaenv) end
---@param key System.Type
---@param out_value System.Delegate
---@return boolean,System.Delegate
function XLua.DelegateBridgeBase:TryGetDelegate(key, out_value) end
---@param key System.Type
---@param value System.Delegate
function XLua.DelegateBridgeBase:AddDelegate(key, value) end
---@param type System.Type
---@return System.Delegate
function XLua.DelegateBridgeBase:GetDelegateByType(type) end

---@class XLua.HotfixDelegateBridge : System.Object
XLua.HotfixDelegateBridge = {}
---@alias CS.XLua.HotfixDelegateBridge XLua.HotfixDelegateBridge
CS.XLua.HotfixDelegateBridge = XLua.HotfixDelegateBridge

---@param idx number
---@return boolean
function XLua.HotfixDelegateBridge.xlua_get_hotfix_flag(idx) end
---@param idx number
---@return XLua.DelegateBridge
function XLua.HotfixDelegateBridge.Get(idx) end
---@param idx number
---@param val XLua.DelegateBridge
function XLua.HotfixDelegateBridge.Set(idx, val) end

---@class XLua.GenFlag
---@field No XLua.GenFlag
XLua.GenFlag = {}
---@alias CS.XLua.GenFlag XLua.GenFlag
CS.XLua.GenFlag = XLua.GenFlag


---@class XLua.LuaCallCSharpAttribute : System.Attribute
---@field Flag XLua.GenFlag
XLua.LuaCallCSharpAttribute = {}
---@alias CS.XLua.LuaCallCSharpAttribute XLua.LuaCallCSharpAttribute
CS.XLua.LuaCallCSharpAttribute = XLua.LuaCallCSharpAttribute

---@param flag XLua.GenFlag
---@return XLua.LuaCallCSharpAttribute
function XLua.LuaCallCSharpAttribute.New(flag) end

---@class XLua.CSharpCallLuaAttribute : System.Attribute
XLua.CSharpCallLuaAttribute = {}
---@alias CS.XLua.CSharpCallLuaAttribute XLua.CSharpCallLuaAttribute
CS.XLua.CSharpCallLuaAttribute = XLua.CSharpCallLuaAttribute

---@return XLua.CSharpCallLuaAttribute
function XLua.CSharpCallLuaAttribute.New() end

---@class XLua.BlackListAttribute : System.Attribute
XLua.BlackListAttribute = {}
---@alias CS.XLua.BlackListAttribute XLua.BlackListAttribute
CS.XLua.BlackListAttribute = XLua.BlackListAttribute

---@return XLua.BlackListAttribute
function XLua.BlackListAttribute.New() end

---@class XLua.OptimizeFlag
---@field Default XLua.OptimizeFlag
---@field PackAsTable XLua.OptimizeFlag
XLua.OptimizeFlag = {}
---@alias CS.XLua.OptimizeFlag XLua.OptimizeFlag
CS.XLua.OptimizeFlag = XLua.OptimizeFlag


---@class XLua.GCOptimizeAttribute : System.Attribute
---@field Flag XLua.OptimizeFlag
XLua.GCOptimizeAttribute = {}
---@alias CS.XLua.GCOptimizeAttribute XLua.GCOptimizeAttribute
CS.XLua.GCOptimizeAttribute = XLua.GCOptimizeAttribute

---@param flag XLua.OptimizeFlag
---@return XLua.GCOptimizeAttribute
function XLua.GCOptimizeAttribute.New(flag) end

---@class XLua.ReflectionUseAttribute : System.Attribute
XLua.ReflectionUseAttribute = {}
---@alias CS.XLua.ReflectionUseAttribute XLua.ReflectionUseAttribute
CS.XLua.ReflectionUseAttribute = XLua.ReflectionUseAttribute

---@return XLua.ReflectionUseAttribute
function XLua.ReflectionUseAttribute.New() end

---@class XLua.DoNotGenAttribute : System.Attribute
XLua.DoNotGenAttribute = {}
---@alias CS.XLua.DoNotGenAttribute XLua.DoNotGenAttribute
CS.XLua.DoNotGenAttribute = XLua.DoNotGenAttribute

---@return XLua.DoNotGenAttribute
function XLua.DoNotGenAttribute.New() end

---@class XLua.AdditionalPropertiesAttribute : System.Attribute
XLua.AdditionalPropertiesAttribute = {}
---@alias CS.XLua.AdditionalPropertiesAttribute XLua.AdditionalPropertiesAttribute
CS.XLua.AdditionalPropertiesAttribute = XLua.AdditionalPropertiesAttribute

---@return XLua.AdditionalPropertiesAttribute
function XLua.AdditionalPropertiesAttribute.New() end

---@class XLua.HotfixFlag
---@field Stateless XLua.HotfixFlag
---@field ValueTypeBoxing XLua.HotfixFlag
---@field IgnoreProperty XLua.HotfixFlag
---@field IgnoreNotPublic XLua.HotfixFlag
---@field Inline XLua.HotfixFlag
---@field IntKey XLua.HotfixFlag
---@field AdaptByDelegate XLua.HotfixFlag
---@field IgnoreCompilerGenerated XLua.HotfixFlag
---@field NoBaseProxy XLua.HotfixFlag
XLua.HotfixFlag = {}
---@alias CS.XLua.HotfixFlag XLua.HotfixFlag
CS.XLua.HotfixFlag = XLua.HotfixFlag


---@class XLua.HotfixAttribute : System.Attribute
---@field Flag XLua.HotfixFlag
XLua.HotfixAttribute = {}
---@alias CS.XLua.HotfixAttribute XLua.HotfixAttribute
CS.XLua.HotfixAttribute = XLua.HotfixAttribute

---@param e XLua.HotfixFlag
---@return XLua.HotfixAttribute
function XLua.HotfixAttribute.New(e) end

---@class XLua.HotfixDelegateAttribute : System.Attribute
XLua.HotfixDelegateAttribute = {}
---@alias CS.XLua.HotfixDelegateAttribute XLua.HotfixDelegateAttribute
CS.XLua.HotfixDelegateAttribute = XLua.HotfixDelegateAttribute

---@return XLua.HotfixDelegateAttribute
function XLua.HotfixDelegateAttribute.New() end

---@class XLua.SysGenConfig : System.Object
XLua.SysGenConfig = {}
---@alias CS.XLua.SysGenConfig XLua.SysGenConfig
CS.XLua.SysGenConfig = XLua.SysGenConfig


---@class XLua.LuaBase : System.Object
XLua.LuaBase = {}
---@alias CS.XLua.LuaBase XLua.LuaBase
CS.XLua.LuaBase = XLua.LuaBase

---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.LuaBase
function XLua.LuaBase.New(reference, luaenv) end
---@overload fun()
---@param disposeManagedResources boolean
function XLua.LuaBase:Dispose(disposeManagedResources) end
---@param o System.Object
---@return boolean
function XLua.LuaBase:Equals(o) end
---@return number
function XLua.LuaBase:GetHashCode() end

---@class XLua.LuaEnv : System.Object
---@field CSHARP_NAMESPACE string
---@field MAIN_SHREAD string
---@field Global XLua.LuaTable
---@field GcPause number
---@field GcStepmul number
---@field Memroy number
XLua.LuaEnv = {}
---@alias CS.XLua.LuaEnv XLua.LuaEnv
CS.XLua.LuaEnv = XLua.LuaEnv

---@return XLua.LuaEnv
function XLua.LuaEnv.New() end
---@param initer System.Action | function
function XLua.LuaEnv.AddIniter(initer) end
---@param chunk string
---@param chunkName string
---@param env XLua.LuaTable
---@return XLua.LuaFunction
function XLua.LuaEnv:LoadString(chunk, chunkName, env) end
---@overload fun(self: XLua.LuaEnv, chunk: System.Byte[], chunkName: string, env: XLua.LuaTable) : System.Object[]
---@param chunk string
---@param chunkName string
---@param env XLua.LuaTable
---@return System.Object[]
function XLua.LuaEnv:DoString(chunk, chunkName, env) end
---@param type System.Type
---@param alias string
function XLua.LuaEnv:Alias(type, alias) end
function XLua.LuaEnv:Tick() end
function XLua.LuaEnv:GC() end
---@return XLua.LuaTable
function XLua.LuaEnv:NewTable() end
---@overload fun()
---@param dispose boolean
function XLua.LuaEnv:Dispose(dispose) end
---@param oldTop number
function XLua.LuaEnv:ThrowExceptionFromError(oldTop) end
---@param loader XLua.LuaEnv.CustomLoader
function XLua.LuaEnv:AddLoader(loader) end
---@param name string
---@param initer XLua.LuaDLL.lua_CSFunction
function XLua.LuaEnv:AddBuildin(name, initer) end
function XLua.LuaEnv:FullGc() end
function XLua.LuaEnv:StopGc() end
function XLua.LuaEnv:RestartGc() end
---@param data number
---@return boolean
function XLua.LuaEnv:GcStep(data) end

---@class XLua.LuaEnv.GCAction : System.ValueType
---@field Reference number
---@field IsDelegate boolean
XLua.LuaEnv.GCAction = {}
---@alias CS.XLua.LuaEnv.GCAction XLua.LuaEnv.GCAction
CS.XLua.LuaEnv.GCAction = XLua.LuaEnv.GCAction


---@class XLua.LuaEnv.CustomLoader : System.MulticastDelegate
XLua.LuaEnv.CustomLoader = {}
---@alias CS.XLua.LuaEnv.CustomLoader XLua.LuaEnv.CustomLoader
CS.XLua.LuaEnv.CustomLoader = XLua.LuaEnv.CustomLoader

---@param object System.Object
---@param method System.IntPtr
---@return XLua.LuaEnv.CustomLoader
function XLua.LuaEnv.CustomLoader.New(object, method) end
---@param ref_filepath string
---@return System.Byte[],string
function XLua.LuaEnv.CustomLoader:Invoke(ref_filepath) end
---@param ref_filepath string
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult,string
function XLua.LuaEnv.CustomLoader:BeginInvoke(ref_filepath, callback, object) end
---@param ref_filepath string
---@param result System.IAsyncResult
---@return System.Byte[],string
function XLua.LuaEnv.CustomLoader:EndInvoke(ref_filepath, result) end

---@class XLua.LuaException : System.Exception
XLua.LuaException = {}
---@alias CS.XLua.LuaException XLua.LuaException
CS.XLua.LuaException = XLua.LuaException

---@param message string
---@return XLua.LuaException
function XLua.LuaException.New(message) end

---@class XLua.LuaFunction : XLua.LuaBase
XLua.LuaFunction = {}
---@alias CS.XLua.LuaFunction XLua.LuaFunction
CS.XLua.LuaFunction = XLua.LuaFunction

---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.LuaFunction
function XLua.LuaFunction.New(reference, luaenv) end
---@overload fun(self: XLua.LuaFunction, args: System.Object[], returnTypes: System.Type[]) : System.Object[]
---@param args System.Object[]
---@return System.Object[]
function XLua.LuaFunction:Call(args) end
---@param env XLua.LuaTable
function XLua.LuaFunction:SetEnv(env) end
---@return string
function XLua.LuaFunction:ToString() end

---@class XLua.LuaTable : XLua.LuaBase
---@field Length number
XLua.LuaTable = {}
---@alias CS.XLua.LuaTable XLua.LuaTable
CS.XLua.LuaTable = XLua.LuaTable

---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.LuaTable
function XLua.LuaTable.New(reference, luaenv) end
---@return System.Collections.IEnumerable
function XLua.LuaTable:GetKeys() end
---@param metaTable XLua.LuaTable
function XLua.LuaTable:SetMetaTable(metaTable) end
---@return string
function XLua.LuaTable:ToString() end

---@class XLua.OverloadMethodWrap : System.Object
---@field HasDefalutValue boolean
XLua.OverloadMethodWrap = {}
---@alias CS.XLua.OverloadMethodWrap XLua.OverloadMethodWrap
CS.XLua.OverloadMethodWrap = XLua.OverloadMethodWrap

---@param translator XLua.ObjectTranslator
---@param targetType System.Type
---@param method System.Reflection.MethodBase
---@return XLua.OverloadMethodWrap
function XLua.OverloadMethodWrap.New(translator, targetType, method) end
---@param objCheckers XLua.ObjectCheckers
---@param objCasters XLua.ObjectCasters
function XLua.OverloadMethodWrap:Init(objCheckers, objCasters) end
---@param L System.IntPtr
---@return boolean
function XLua.OverloadMethodWrap:Check(L) end
---@param L System.IntPtr
---@return number
function XLua.OverloadMethodWrap:Call(L) end

---@class XLua.MethodWrap : System.Object
XLua.MethodWrap = {}
---@alias CS.XLua.MethodWrap XLua.MethodWrap
CS.XLua.MethodWrap = XLua.MethodWrap

---@param methodName string
---@param overloads System.Collections.Generic.List
---@param forceCheck boolean
---@return XLua.MethodWrap
function XLua.MethodWrap.New(methodName, overloads, forceCheck) end
---@param L System.IntPtr
---@return number
function XLua.MethodWrap:Call(L) end

---@class XLua.MethodWrapsCache : System.Object
XLua.MethodWrapsCache = {}
---@alias CS.XLua.MethodWrapsCache XLua.MethodWrapsCache
CS.XLua.MethodWrapsCache = XLua.MethodWrapsCache

---@param translator XLua.ObjectTranslator
---@param objCheckers XLua.ObjectCheckers
---@param objCasters XLua.ObjectCasters
---@return XLua.MethodWrapsCache
function XLua.MethodWrapsCache.New(translator, objCheckers, objCasters) end
---@param type System.Type
---@return XLua.LuaDLL.lua_CSFunction
function XLua.MethodWrapsCache:GetConstructorWrap(type) end
---@param type System.Type
---@param methodName string
---@return XLua.LuaDLL.lua_CSFunction
function XLua.MethodWrapsCache:GetMethodWrap(type, methodName) end
---@param type System.Type
---@param methodName string
---@return XLua.LuaDLL.lua_CSFunction
function XLua.MethodWrapsCache:GetMethodWrapInCache(type, methodName) end
---@param type System.Type
---@return XLua.LuaDLL.lua_CSFunction
function XLua.MethodWrapsCache:GetDelegateWrap(type) end
---@param type System.Type
---@param eventName string
---@return XLua.LuaDLL.lua_CSFunction
function XLua.MethodWrapsCache:GetEventWrap(type, eventName) end
---@param type System.Type
---@param methodName string
---@param methodBases System.Collections.Generic.IEnumerable
---@param forceCheck boolean
---@return XLua.MethodWrap
function XLua.MethodWrapsCache:_GenMethodWrap(type, methodName, methodBases, forceCheck) end

---@class XLua.ObjectCheck : System.MulticastDelegate
XLua.ObjectCheck = {}
---@alias CS.XLua.ObjectCheck XLua.ObjectCheck
CS.XLua.ObjectCheck = XLua.ObjectCheck

---@param object System.Object
---@param method System.IntPtr
---@return XLua.ObjectCheck
function XLua.ObjectCheck.New(object, method) end
---@param L System.IntPtr
---@param idx number
---@return boolean
function XLua.ObjectCheck:Invoke(L, idx) end
---@param L System.IntPtr
---@param idx number
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.ObjectCheck:BeginInvoke(L, idx, callback, object) end
---@param result System.IAsyncResult
---@return boolean
function XLua.ObjectCheck:EndInvoke(result) end

---@class XLua.ObjectCast : System.MulticastDelegate
XLua.ObjectCast = {}
---@alias CS.XLua.ObjectCast XLua.ObjectCast
CS.XLua.ObjectCast = XLua.ObjectCast

---@param object System.Object
---@param method System.IntPtr
---@return XLua.ObjectCast
function XLua.ObjectCast.New(object, method) end
---@param L System.IntPtr
---@param idx number
---@param target System.Object
---@return System.Object
function XLua.ObjectCast:Invoke(L, idx, target) end
---@param L System.IntPtr
---@param idx number
---@param target System.Object
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.ObjectCast:BeginInvoke(L, idx, target, callback, object) end
---@param result System.IAsyncResult
---@return System.Object
function XLua.ObjectCast:EndInvoke(result) end

---@class XLua.ObjectCheckers : System.Object
XLua.ObjectCheckers = {}
---@alias CS.XLua.ObjectCheckers XLua.ObjectCheckers
CS.XLua.ObjectCheckers = XLua.ObjectCheckers

---@param translator XLua.ObjectTranslator
---@return XLua.ObjectCheckers
function XLua.ObjectCheckers.New(translator) end
---@param oc XLua.ObjectCheck
---@return XLua.ObjectCheck
function XLua.ObjectCheckers:genNullableChecker(oc) end
---@param type System.Type
---@param oc XLua.ObjectCheck
function XLua.ObjectCheckers:AddChecker(type, oc) end
---@param type System.Type
---@return XLua.ObjectCheck
function XLua.ObjectCheckers:GetChecker(type) end

---@class XLua.ObjectCasters : System.Object
XLua.ObjectCasters = {}
---@alias CS.XLua.ObjectCasters XLua.ObjectCasters
CS.XLua.ObjectCasters = XLua.ObjectCasters

---@param translator XLua.ObjectTranslator
---@return XLua.ObjectCasters
function XLua.ObjectCasters.New(translator) end
---@param type System.Type
---@param oc XLua.ObjectCast
function XLua.ObjectCasters:AddCaster(type, oc) end
---@param type System.Type
---@return XLua.ObjectCast
function XLua.ObjectCasters:GetCaster(type) end

---@class XLua.ObjectPool : System.Object
---@field Item System.Object
XLua.ObjectPool = {}
---@alias CS.XLua.ObjectPool XLua.ObjectPool
CS.XLua.ObjectPool = XLua.ObjectPool

---@return XLua.ObjectPool
function XLua.ObjectPool.New() end
function XLua.ObjectPool:Clear() end
---@param obj System.Object
---@return number
function XLua.ObjectPool:Add(obj) end
---@param index number
---@param out_obj System.Object
---@return boolean,System.Object
function XLua.ObjectPool:TryGetValue(index, out_obj) end
---@param index number
---@return System.Object
function XLua.ObjectPool:Get(index) end
---@param index number
---@return System.Object
function XLua.ObjectPool:Remove(index) end
---@param index number
---@param o System.Object
---@return System.Object
function XLua.ObjectPool:Replace(index, o) end
---@param check_pos number
---@param max_check number
---@param checker System.Func
---@param reverse_map System.Collections.Generic.Dictionary
---@return number
function XLua.ObjectPool:Check(check_pos, max_check, checker, reverse_map) end

---@class XLua.ObjectPool.Slot : System.ValueType
---@field next number
---@field obj System.Object
XLua.ObjectPool.Slot = {}
---@alias CS.XLua.ObjectPool.Slot XLua.ObjectPool.Slot
CS.XLua.ObjectPool.Slot = XLua.ObjectPool.Slot

---@param next number
---@param obj System.Object
---@return XLua.ObjectPool.Slot
function XLua.ObjectPool.Slot.New(next, obj) end

---@class XLua.ReferenceEqualsComparer : System.Object
XLua.ReferenceEqualsComparer = {}
---@alias CS.XLua.ReferenceEqualsComparer XLua.ReferenceEqualsComparer
CS.XLua.ReferenceEqualsComparer = XLua.ReferenceEqualsComparer

---@return XLua.ReferenceEqualsComparer
function XLua.ReferenceEqualsComparer.New() end
---@param o1 System.Object
---@param o2 System.Object
---@return boolean
function XLua.ReferenceEqualsComparer:Equals(o1, o2) end
---@param obj System.Object
---@return number
function XLua.ReferenceEqualsComparer:GetHashCode(obj) end

---@class XLua.MonoPInvokeCallbackAttribute : System.Attribute
XLua.MonoPInvokeCallbackAttribute = {}
---@alias CS.XLua.MonoPInvokeCallbackAttribute XLua.MonoPInvokeCallbackAttribute
CS.XLua.MonoPInvokeCallbackAttribute = XLua.MonoPInvokeCallbackAttribute

---@param t System.Type
---@return XLua.MonoPInvokeCallbackAttribute
function XLua.MonoPInvokeCallbackAttribute.New(t) end

---@class XLua.LuaTypes
---@field LUA_TNONE XLua.LuaTypes
---@field LUA_TNIL XLua.LuaTypes
---@field LUA_TNUMBER XLua.LuaTypes
---@field LUA_TSTRING XLua.LuaTypes
---@field LUA_TBOOLEAN XLua.LuaTypes
---@field LUA_TTABLE XLua.LuaTypes
---@field LUA_TFUNCTION XLua.LuaTypes
---@field LUA_TUSERDATA XLua.LuaTypes
---@field LUA_TTHREAD XLua.LuaTypes
---@field LUA_TLIGHTUSERDATA XLua.LuaTypes
XLua.LuaTypes = {}
---@alias CS.XLua.LuaTypes XLua.LuaTypes
CS.XLua.LuaTypes = XLua.LuaTypes


---@class XLua.LuaGCOptions
---@field LUA_GCSTOP XLua.LuaGCOptions
---@field LUA_GCRESTART XLua.LuaGCOptions
---@field LUA_GCCOLLECT XLua.LuaGCOptions
---@field LUA_GCCOUNT XLua.LuaGCOptions
---@field LUA_GCCOUNTB XLua.LuaGCOptions
---@field LUA_GCSTEP XLua.LuaGCOptions
---@field LUA_GCSETPAUSE XLua.LuaGCOptions
---@field LUA_GCSETSTEPMUL XLua.LuaGCOptions
XLua.LuaGCOptions = {}
---@alias CS.XLua.LuaGCOptions XLua.LuaGCOptions
CS.XLua.LuaGCOptions = XLua.LuaGCOptions


---@class XLua.LuaThreadStatus
---@field LUA_RESUME_ERROR XLua.LuaThreadStatus
---@field LUA_OK XLua.LuaThreadStatus
---@field LUA_YIELD XLua.LuaThreadStatus
---@field LUA_ERRRUN XLua.LuaThreadStatus
---@field LUA_ERRSYNTAX XLua.LuaThreadStatus
---@field LUA_ERRMEM XLua.LuaThreadStatus
---@field LUA_ERRERR XLua.LuaThreadStatus
XLua.LuaThreadStatus = {}
---@alias CS.XLua.LuaThreadStatus XLua.LuaThreadStatus
CS.XLua.LuaThreadStatus = XLua.LuaThreadStatus


---@class XLua.LuaIndexes : System.Object
---@field LUA_REGISTRYINDEX number
XLua.LuaIndexes = {}
---@alias CS.XLua.LuaIndexes XLua.LuaIndexes
CS.XLua.LuaIndexes = XLua.LuaIndexes

---@return XLua.LuaIndexes
function XLua.LuaIndexes.New() end

---@class XLua.ObjectTranslatorPool : System.Object
---@field Instance XLua.ObjectTranslatorPool
XLua.ObjectTranslatorPool = {}
---@alias CS.XLua.ObjectTranslatorPool XLua.ObjectTranslatorPool
CS.XLua.ObjectTranslatorPool = XLua.ObjectTranslatorPool

---@return XLua.ObjectTranslatorPool
function XLua.ObjectTranslatorPool.New() end
---@param L System.IntPtr
---@return XLua.ObjectTranslator
function XLua.ObjectTranslatorPool.FindTranslator(L) end
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
function XLua.ObjectTranslatorPool:Add(L, translator) end
---@param L System.IntPtr
---@return XLua.ObjectTranslator
function XLua.ObjectTranslatorPool:Find(L) end
---@param L System.IntPtr
function XLua.ObjectTranslatorPool:Remove(L) end

---@class XLua.RawObject
---@field Target System.Object
XLua.RawObject = {}
---@alias CS.XLua.RawObject XLua.RawObject
CS.XLua.RawObject = XLua.RawObject


---@class XLua.SignatureLoader : System.Object
XLua.SignatureLoader = {}
---@alias CS.XLua.SignatureLoader XLua.SignatureLoader
CS.XLua.SignatureLoader = XLua.SignatureLoader

---@param publicKey string
---@param loader XLua.LuaEnv.CustomLoader
---@return XLua.SignatureLoader
function XLua.SignatureLoader.New(publicKey, loader) end

---@class XLua.TypeExtensions : System.Object
XLua.TypeExtensions = {}
---@alias CS.XLua.TypeExtensions XLua.TypeExtensions
CS.XLua.TypeExtensions = XLua.TypeExtensions

---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsValueType(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsEnum(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsPrimitive(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsAbstract(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsSealed(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsInterface(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsClass(type) end
---@param type System.Type
---@return System.Type
function XLua.TypeExtensions.BaseType(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsGenericType(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsGenericTypeDefinition(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsNestedPublic(type) end
---@param type System.Type
---@return boolean
function XLua.TypeExtensions.IsPublic(type) end
---@param type System.Type
---@return string
function XLua.TypeExtensions.GetFriendlyName(type) end

---@class XLua.LazyMemberTypes
---@field Method XLua.LazyMemberTypes
---@field FieldGet XLua.LazyMemberTypes
---@field FieldSet XLua.LazyMemberTypes
---@field PropertyGet XLua.LazyMemberTypes
---@field PropertySet XLua.LazyMemberTypes
---@field Event XLua.LazyMemberTypes
XLua.LazyMemberTypes = {}
---@alias CS.XLua.LazyMemberTypes XLua.LazyMemberTypes
CS.XLua.LazyMemberTypes = XLua.LazyMemberTypes


---@class XLua.Utils : System.Object
---@field OBJ_META_IDX number
---@field METHOD_IDX number
---@field GETTER_IDX number
---@field SETTER_IDX number
---@field CLS_IDX number
---@field CLS_META_IDX number
---@field CLS_GETTER_IDX number
---@field CLS_SETTER_IDX number
---@field LuaIndexsFieldName string
---@field LuaNewIndexsFieldName string
---@field LuaClassIndexsFieldName string
---@field LuaClassNewIndexsFieldName string
XLua.Utils = {}
---@alias CS.XLua.Utils XLua.Utils
CS.XLua.Utils = XLua.Utils

---@param L System.IntPtr
---@param idx number
---@param field_name string
---@return boolean
function XLua.Utils.LoadField(L, idx, field_name) end
---@param L System.IntPtr
---@return System.IntPtr
function XLua.Utils.GetMainState(L) end
---@param exclude_generic_definition boolean
---@return System.Collections.Generic.List
function XLua.Utils.GetAllTypes(exclude_generic_definition) end
---@param L System.IntPtr
---@param type System.Type
---@param metafunc string
---@param index number
function XLua.Utils.loadUpvalue(L, type, metafunc, index) end
---@param L System.IntPtr
---@param type System.Type
function XLua.Utils.RegisterEnumType(L, type) end
---@param L System.IntPtr
---@param type System.Type
function XLua.Utils.MakePrivateAccessible(L, type) end
---@param L System.IntPtr
---@param type System.Type
---@param privateAccessible boolean
function XLua.Utils.ReflectionWrap(L, type, privateAccessible) end
---@param type System.Type
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
---@param meta_count number
---@param method_count number
---@param getter_count number
---@param setter_count number
---@param type_id number
function XLua.Utils.BeginObjectRegister(type, L, translator, meta_count, method_count, getter_count, setter_count, type_id) end
---@param type System.Type
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
---@param csIndexer XLua.LuaDLL.lua_CSFunction
---@param csNewIndexer XLua.LuaDLL.lua_CSFunction
---@param base_type System.Type
---@param arrayIndexer XLua.LuaDLL.lua_CSFunction
---@param arrayNewIndexer XLua.LuaDLL.lua_CSFunction
function XLua.Utils.EndObjectRegister(type, L, translator, csIndexer, csNewIndexer, base_type, arrayIndexer, arrayNewIndexer) end
---@param L System.IntPtr
---@param idx number
---@param name string
---@param func XLua.LuaDLL.lua_CSFunction
function XLua.Utils.RegisterFunc(L, idx, name, func) end
---@param L System.IntPtr
---@param idx number
---@param name string
---@param type System.Type
---@param memberType XLua.LazyMemberTypes
---@param isStatic boolean
function XLua.Utils.RegisterLazyFunc(L, idx, name, type, memberType, isStatic) end
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
---@param idx number
---@param name string
---@param obj System.Object
function XLua.Utils.RegisterObject(L, translator, idx, name, obj) end
---@param type System.Type
---@param L System.IntPtr
---@param creator XLua.LuaDLL.lua_CSFunction
---@param class_field_count number
---@param static_getter_count number
---@param static_setter_count number
function XLua.Utils.BeginClassRegister(type, L, creator, class_field_count, static_getter_count, static_setter_count) end
---@param type System.Type
---@param L System.IntPtr
---@param translator XLua.ObjectTranslator
function XLua.Utils.EndClassRegister(type, L, translator) end
---@param L System.IntPtr
---@param type System.Type
function XLua.Utils.LoadCSTable(L, type) end
---@param L System.IntPtr
---@param type System.Type
---@param cls_table number
function XLua.Utils.SetCSTable(L, type, cls_table) end
---@param delegateMethod System.Reflection.MethodInfo
---@param bridgeMethod System.Reflection.MethodInfo
---@return boolean
function XLua.Utils.IsParamsMatch(delegateMethod, bridgeMethod) end
---@param method System.Reflection.MethodInfo
---@return boolean
function XLua.Utils.IsSupportedMethod(method) end
---@param method System.Reflection.MethodInfo
---@return System.Reflection.MethodInfo
function XLua.Utils.MakeGenericMethodWithConstraints(method) end
---@param csFunction XLua.LuaDLL.lua_CSFunction
---@return boolean
function XLua.Utils.IsStaticPInvokeCSFunction(csFunction) end
---@param type System.Type
---@return boolean
function XLua.Utils.IsPublic(type) end

---@class XLua.Utils.MethodKey : System.ValueType
---@field Name string
---@field IsStatic boolean
XLua.Utils.MethodKey = {}
---@alias CS.XLua.Utils.MethodKey XLua.Utils.MethodKey
CS.XLua.Utils.MethodKey = XLua.Utils.MethodKey


---@class XLua.TemplateEngine.TokenType
---@field Code XLua.TemplateEngine.TokenType
---@field Eval XLua.TemplateEngine.TokenType
---@field Text XLua.TemplateEngine.TokenType
XLua.TemplateEngine.TokenType = {}
---@alias CS.XLua.TemplateEngine.TokenType XLua.TemplateEngine.TokenType
CS.XLua.TemplateEngine.TokenType = XLua.TemplateEngine.TokenType


---@class XLua.TemplateEngine.Chunk : System.Object
---@field Type XLua.TemplateEngine.TokenType
---@field Text string
XLua.TemplateEngine.Chunk = {}
---@alias CS.XLua.TemplateEngine.Chunk XLua.TemplateEngine.Chunk
CS.XLua.TemplateEngine.Chunk = XLua.TemplateEngine.Chunk

---@param type XLua.TemplateEngine.TokenType
---@param text string
---@return XLua.TemplateEngine.Chunk
function XLua.TemplateEngine.Chunk.New(type, text) end

---@class XLua.TemplateEngine.TemplateFormatException : System.Exception
XLua.TemplateEngine.TemplateFormatException = {}
---@alias CS.XLua.TemplateEngine.TemplateFormatException XLua.TemplateEngine.TemplateFormatException
CS.XLua.TemplateEngine.TemplateFormatException = XLua.TemplateEngine.TemplateFormatException

---@param message string
---@return XLua.TemplateEngine.TemplateFormatException
function XLua.TemplateEngine.TemplateFormatException.New(message) end

---@class XLua.TemplateEngine.Parser : System.Object
---@field RegexString string
XLua.TemplateEngine.Parser = {}
---@alias CS.XLua.TemplateEngine.Parser XLua.TemplateEngine.Parser
CS.XLua.TemplateEngine.Parser = XLua.TemplateEngine.Parser

---@return XLua.TemplateEngine.Parser
function XLua.TemplateEngine.Parser.New() end
---@param snippet string
---@return System.Collections.Generic.List
function XLua.TemplateEngine.Parser.Parse(snippet) end

---@class XLua.TemplateEngine.LuaTemplate : System.Object
XLua.TemplateEngine.LuaTemplate = {}
---@alias CS.XLua.TemplateEngine.LuaTemplate XLua.TemplateEngine.LuaTemplate
CS.XLua.TemplateEngine.LuaTemplate = XLua.TemplateEngine.LuaTemplate

---@return XLua.TemplateEngine.LuaTemplate
function XLua.TemplateEngine.LuaTemplate.New() end
---@param chunks System.Collections.Generic.List
---@return string
function XLua.TemplateEngine.LuaTemplate.ComposeCode(chunks) end
---@overload fun(luaenv: XLua.LuaEnv, snippet: string) : XLua.LuaFunction
---@param L System.IntPtr
---@return number
function XLua.TemplateEngine.LuaTemplate.Compile(L) end
---@overload fun(compiledTemplate: XLua.LuaFunction, parameters: XLua.LuaTable) : string
---@overload fun(compiledTemplate: XLua.LuaFunction) : string
---@param L System.IntPtr
---@return number
function XLua.TemplateEngine.LuaTemplate.Execute(L) end
---@param L System.IntPtr
function XLua.TemplateEngine.LuaTemplate.OpenLib(L) end

---@class XLua.Cast.Any : System.Object
---@field Target System.Object
XLua.Cast.Any = {}
---@alias CS.XLua.Cast.Any XLua.Cast.Any
CS.XLua.Cast.Any = XLua.Cast.Any

---@param i T
---@return XLua.Cast.Any
function XLua.Cast.Any.New(i) end

---@class XLua.Cast.Byte : XLua.Cast.Any
XLua.Cast.Byte = {}
---@alias CS.XLua.Cast.Byte XLua.Cast.Byte
CS.XLua.Cast.Byte = XLua.Cast.Byte

---@param i number
---@return XLua.Cast.Byte
function XLua.Cast.Byte.New(i) end

---@class XLua.Cast.SByte : XLua.Cast.Any
XLua.Cast.SByte = {}
---@alias CS.XLua.Cast.SByte XLua.Cast.SByte
CS.XLua.Cast.SByte = XLua.Cast.SByte

---@param i number
---@return XLua.Cast.SByte
function XLua.Cast.SByte.New(i) end

---@class XLua.Cast.Char : XLua.Cast.Any
XLua.Cast.Char = {}
---@alias CS.XLua.Cast.Char XLua.Cast.Char
CS.XLua.Cast.Char = XLua.Cast.Char

---@param i System.Char
---@return XLua.Cast.Char
function XLua.Cast.Char.New(i) end

---@class XLua.Cast.Int16 : XLua.Cast.Any
XLua.Cast.Int16 = {}
---@alias CS.XLua.Cast.Int16 XLua.Cast.Int16
CS.XLua.Cast.Int16 = XLua.Cast.Int16

---@param i number
---@return XLua.Cast.Int16
function XLua.Cast.Int16.New(i) end

---@class XLua.Cast.UInt16 : XLua.Cast.Any
XLua.Cast.UInt16 = {}
---@alias CS.XLua.Cast.UInt16 XLua.Cast.UInt16
CS.XLua.Cast.UInt16 = XLua.Cast.UInt16

---@param i number
---@return XLua.Cast.UInt16
function XLua.Cast.UInt16.New(i) end

---@class XLua.Cast.Int32 : XLua.Cast.Any
XLua.Cast.Int32 = {}
---@alias CS.XLua.Cast.Int32 XLua.Cast.Int32
CS.XLua.Cast.Int32 = XLua.Cast.Int32

---@param i number
---@return XLua.Cast.Int32
function XLua.Cast.Int32.New(i) end

---@class XLua.Cast.UInt32 : XLua.Cast.Any
XLua.Cast.UInt32 = {}
---@alias CS.XLua.Cast.UInt32 XLua.Cast.UInt32
CS.XLua.Cast.UInt32 = XLua.Cast.UInt32

---@param i number
---@return XLua.Cast.UInt32
function XLua.Cast.UInt32.New(i) end

---@class XLua.Cast.Int64 : XLua.Cast.Any
XLua.Cast.Int64 = {}
---@alias CS.XLua.Cast.Int64 XLua.Cast.Int64
CS.XLua.Cast.Int64 = XLua.Cast.Int64

---@param i number
---@return XLua.Cast.Int64
function XLua.Cast.Int64.New(i) end

---@class XLua.Cast.UInt64 : XLua.Cast.Any
XLua.Cast.UInt64 = {}
---@alias CS.XLua.Cast.UInt64 XLua.Cast.UInt64
CS.XLua.Cast.UInt64 = XLua.Cast.UInt64

---@param i number
---@return XLua.Cast.UInt64
function XLua.Cast.UInt64.New(i) end

---@class XLua.Cast.Float : XLua.Cast.Any
XLua.Cast.Float = {}
---@alias CS.XLua.Cast.Float XLua.Cast.Float
CS.XLua.Cast.Float = XLua.Cast.Float

---@param i number
---@return XLua.Cast.Float
function XLua.Cast.Float.New(i) end

---@class XLua.LuaDLL.lua_CSFunction : System.MulticastDelegate
XLua.LuaDLL.lua_CSFunction = {}
---@alias CS.XLua.LuaDLL.lua_CSFunction XLua.LuaDLL.lua_CSFunction
CS.XLua.LuaDLL.lua_CSFunction = XLua.LuaDLL.lua_CSFunction

---@param object System.Object
---@param method System.IntPtr
---@return XLua.LuaDLL.lua_CSFunction
function XLua.LuaDLL.lua_CSFunction.New(object, method) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.lua_CSFunction:Invoke(L) end
---@param L System.IntPtr
---@param callback System.AsyncCallback
---@param object System.Object
---@return System.IAsyncResult
function XLua.LuaDLL.lua_CSFunction:BeginInvoke(L, callback, object) end
---@param result System.IAsyncResult
---@return number
function XLua.LuaDLL.lua_CSFunction:EndInvoke(result) end

---@class XLua.LuaDLL.Lua : System.Object
XLua.LuaDLL.Lua = {}
---@alias CS.XLua.LuaDLL.Lua XLua.LuaDLL.Lua
CS.XLua.LuaDLL.Lua = XLua.LuaDLL.Lua

---@return XLua.LuaDLL.Lua
function XLua.LuaDLL.Lua.New() end
---@param L System.IntPtr
---@param index number
---@return System.IntPtr
function XLua.LuaDLL.Lua.lua_tothread(L, index) end
---@return number
function XLua.LuaDLL.Lua.xlua_get_lib_version() end
---@param L System.IntPtr
---@param what XLua.LuaGCOptions
---@param data number
---@return number
function XLua.LuaDLL.Lua.lua_gc(L, what, data) end
---@param L System.IntPtr
---@param funcindex number
---@param n number
---@return System.IntPtr
function XLua.LuaDLL.Lua.lua_getupvalue(L, funcindex, n) end
---@param L System.IntPtr
---@param funcindex number
---@param n number
---@return System.IntPtr
function XLua.LuaDLL.Lua.lua_setupvalue(L, funcindex, n) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.lua_pushthread(L) end
---@param L System.IntPtr
---@param stackPos number
---@return boolean
function XLua.LuaDLL.Lua.lua_isfunction(L, stackPos) end
---@param L System.IntPtr
---@param stackPos number
---@return boolean
function XLua.LuaDLL.Lua.lua_islightuserdata(L, stackPos) end
---@param L System.IntPtr
---@param stackPos number
---@return boolean
function XLua.LuaDLL.Lua.lua_istable(L, stackPos) end
---@param L System.IntPtr
---@param stackPos number
---@return boolean
function XLua.LuaDLL.Lua.lua_isthread(L, stackPos) end
---@param L System.IntPtr
---@param message string
---@return number
function XLua.LuaDLL.Lua.luaL_error(L, message) end
---@param L System.IntPtr
---@param stackPos number
---@return number
function XLua.LuaDLL.Lua.lua_setfenv(L, stackPos) end
---@return System.IntPtr
function XLua.LuaDLL.Lua.luaL_newstate() end
---@param L System.IntPtr
function XLua.LuaDLL.Lua.lua_close(L) end
---@param L System.IntPtr
function XLua.LuaDLL.Lua.luaopen_xlua(L) end
---@param L System.IntPtr
function XLua.LuaDLL.Lua.luaL_openlibs(L) end
---@param L System.IntPtr
---@param stackPos number
---@return number
function XLua.LuaDLL.Lua.xlua_objlen(L, stackPos) end
---@param L System.IntPtr
---@param narr number
---@param nrec number
function XLua.LuaDLL.Lua.lua_createtable(L, narr, nrec) end
---@param L System.IntPtr
function XLua.LuaDLL.Lua.lua_newtable(L) end
---@param L System.IntPtr
---@param name string
---@return number
function XLua.LuaDLL.Lua.xlua_getglobal(L, name) end
---@param L System.IntPtr
---@param name string
---@return number
function XLua.LuaDLL.Lua.xlua_setglobal(L, name) end
---@param L System.IntPtr
function XLua.LuaDLL.Lua.xlua_getloaders(L) end
---@param L System.IntPtr
---@param newTop number
function XLua.LuaDLL.Lua.lua_settop(L, newTop) end
---@param L System.IntPtr
---@param amount number
function XLua.LuaDLL.Lua.lua_pop(L, amount) end
---@param L System.IntPtr
---@param newTop number
function XLua.LuaDLL.Lua.lua_insert(L, newTop) end
---@param L System.IntPtr
---@param index number
function XLua.LuaDLL.Lua.lua_remove(L, index) end
---@param L System.IntPtr
---@param index number
---@return number
function XLua.LuaDLL.Lua.lua_rawget(L, index) end
---@param L System.IntPtr
---@param index number
function XLua.LuaDLL.Lua.lua_rawset(L, index) end
---@param L System.IntPtr
---@param objIndex number
---@return number
function XLua.LuaDLL.Lua.lua_setmetatable(L, objIndex) end
---@param L System.IntPtr
---@param index1 number
---@param index2 number
---@return number
function XLua.LuaDLL.Lua.lua_rawequal(L, index1, index2) end
---@param L System.IntPtr
---@param index number
function XLua.LuaDLL.Lua.lua_pushvalue(L, index) end
---@param L System.IntPtr
---@param fn System.IntPtr
---@param n number
function XLua.LuaDLL.Lua.lua_pushcclosure(L, fn, n) end
---@param L System.IntPtr
---@param index number
function XLua.LuaDLL.Lua.lua_replace(L, index) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.lua_gettop(L) end
---@param L System.IntPtr
---@param index number
---@return XLua.LuaTypes
function XLua.LuaDLL.Lua.lua_type(L, index) end
---@param L System.IntPtr
---@param index number
---@return boolean
function XLua.LuaDLL.Lua.lua_isnil(L, index) end
---@param L System.IntPtr
---@param index number
---@return boolean
function XLua.LuaDLL.Lua.lua_isnumber(L, index) end
---@param L System.IntPtr
---@param index number
---@return boolean
function XLua.LuaDLL.Lua.lua_isboolean(L, index) end
---@overload fun(L: System.IntPtr, registryIndex: number) : number
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.luaL_ref(L) end
---@param L System.IntPtr
---@param tableIndex number
---@param index number
function XLua.LuaDLL.Lua.xlua_rawgeti(L, tableIndex, index) end
---@param L System.IntPtr
---@param tableIndex number
---@param index number
function XLua.LuaDLL.Lua.xlua_rawseti(L, tableIndex, index) end
---@param L System.IntPtr
---@param reference number
function XLua.LuaDLL.Lua.lua_getref(L, reference) end
---@param L System.IntPtr
---@param error_func_ref number
---@param func_ref number
---@return number
function XLua.LuaDLL.Lua.pcall_prepare(L, error_func_ref, func_ref) end
---@param L System.IntPtr
---@param registryIndex number
---@param reference number
function XLua.LuaDLL.Lua.luaL_unref(L, registryIndex, reference) end
---@param L System.IntPtr
---@param reference number
function XLua.LuaDLL.Lua.lua_unref(L, reference) end
---@param L System.IntPtr
---@param index number
---@return boolean
function XLua.LuaDLL.Lua.lua_isstring(L, index) end
---@param L System.IntPtr
---@param index number
---@return boolean
function XLua.LuaDLL.Lua.lua_isinteger(L, index) end
---@param L System.IntPtr
function XLua.LuaDLL.Lua.lua_pushnil(L) end
---@param L System.IntPtr
---@param _function XLua.LuaDLL.lua_CSFunction
---@param n number
function XLua.LuaDLL.Lua.lua_pushstdcallcfunction(L, _function, n) end
---@param n number
---@return number
function XLua.LuaDLL.Lua.xlua_upvalueindex(n) end
---@param L System.IntPtr
---@param nArgs number
---@param nResults number
---@param errfunc number
---@return number
function XLua.LuaDLL.Lua.lua_pcall(L, nArgs, nResults, errfunc) end
---@param L System.IntPtr
---@param index number
---@return number
function XLua.LuaDLL.Lua.lua_tonumber(L, index) end
---@param L System.IntPtr
---@param index number
---@return number
function XLua.LuaDLL.Lua.xlua_tointeger(L, index) end
---@param L System.IntPtr
---@param index number
---@return number
function XLua.LuaDLL.Lua.xlua_touint(L, index) end
---@param L System.IntPtr
---@param index number
---@return boolean
function XLua.LuaDLL.Lua.lua_toboolean(L, index) end
---@param L System.IntPtr
---@param index number
---@return System.IntPtr
function XLua.LuaDLL.Lua.lua_topointer(L, index) end
---@param L System.IntPtr
---@param index number
---@param out_strLen System.IntPtr
---@return System.IntPtr,System.IntPtr
function XLua.LuaDLL.Lua.lua_tolstring(L, index, out_strLen) end
---@param L System.IntPtr
---@param index number
---@return string
function XLua.LuaDLL.Lua.lua_tostring(L, index) end
---@param L System.IntPtr
---@param panicf XLua.LuaDLL.lua_CSFunction
---@return System.IntPtr
function XLua.LuaDLL.Lua.lua_atpanic(L, panicf) end
---@param L System.IntPtr
---@param number number
function XLua.LuaDLL.Lua.lua_pushnumber(L, number) end
---@param L System.IntPtr
---@param value boolean
function XLua.LuaDLL.Lua.lua_pushboolean(L, value) end
---@param L System.IntPtr
---@param value number
function XLua.LuaDLL.Lua.xlua_pushinteger(L, value) end
---@param L System.IntPtr
---@param value number
function XLua.LuaDLL.Lua.xlua_pushuint(L, value) end
---@overload fun(L: System.IntPtr, str: string)
---@param L System.IntPtr
---@param str System.Byte[]
function XLua.LuaDLL.Lua.lua_pushstring(L, str) end
---@param L System.IntPtr
---@param str System.Byte[]
---@param size number
function XLua.LuaDLL.Lua.xlua_pushlstring(L, str, size) end
---@param L System.IntPtr
---@param str string
function XLua.LuaDLL.Lua.xlua_pushasciistring(L, str) end
---@param L System.IntPtr
---@param index number
---@return System.Byte[]
function XLua.LuaDLL.Lua.lua_tobytes(L, index) end
---@param L System.IntPtr
---@param meta string
---@return number
function XLua.LuaDLL.Lua.luaL_newmetatable(L, meta) end
---@param L System.IntPtr
---@param idx number
---@return number
function XLua.LuaDLL.Lua.xlua_pgettable(L, idx) end
---@param L System.IntPtr
---@param idx number
---@return number
function XLua.LuaDLL.Lua.xlua_psettable(L, idx) end
---@param L System.IntPtr
---@param meta string
function XLua.LuaDLL.Lua.luaL_getmetatable(L, meta) end
---@param L System.IntPtr
---@param buff System.Byte[]
---@param size number
---@param name string
---@return number
function XLua.LuaDLL.Lua.xluaL_loadbuffer(L, buff, size, name) end
---@param L System.IntPtr
---@param buff string
---@param name string
---@return number
function XLua.LuaDLL.Lua.luaL_loadbuffer(L, buff, name) end
---@param L System.IntPtr
---@param obj number
---@return number
function XLua.LuaDLL.Lua.xlua_tocsobj_safe(L, obj) end
---@param L System.IntPtr
---@param obj number
---@return number
function XLua.LuaDLL.Lua.xlua_tocsobj_fast(L, obj) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.lua_error(L) end
---@param L System.IntPtr
---@param extra number
---@return boolean
function XLua.LuaDLL.Lua.lua_checkstack(L, extra) end
---@param L System.IntPtr
---@param index number
---@return number
function XLua.LuaDLL.Lua.lua_next(L, index) end
---@param L System.IntPtr
---@param udata System.IntPtr
function XLua.LuaDLL.Lua.lua_pushlightuserdata(L, udata) end
---@return System.IntPtr
function XLua.LuaDLL.Lua.xlua_tag() end
---@param L System.IntPtr
---@param level number
function XLua.LuaDLL.Lua.luaL_where(L, level) end
---@param L System.IntPtr
---@param key number
---@param cache_ref number
---@return number
function XLua.LuaDLL.Lua.xlua_tryget_cachedud(L, key, cache_ref) end
---@param L System.IntPtr
---@param key number
---@param meta_ref number
---@param need_cache boolean
---@param cache_ref number
function XLua.LuaDLL.Lua.xlua_pushcsobj(L, key, meta_ref, need_cache, cache_ref) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.gen_obj_indexer(L) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.gen_obj_newindexer(L) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.gen_cls_indexer(L) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.gen_cls_newindexer(L) end
---@param L System.IntPtr
---@param Ref number
---@return number
function XLua.LuaDLL.Lua.load_error_func(L, Ref) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.luaopen_i64lib(L) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.luaopen_socket_core(L) end
---@param L System.IntPtr
---@param n number
function XLua.LuaDLL.Lua.lua_pushint64(L, n) end
---@param L System.IntPtr
---@param n number
function XLua.LuaDLL.Lua.lua_pushuint64(L, n) end
---@param L System.IntPtr
---@param idx number
---@return boolean
function XLua.LuaDLL.Lua.lua_isint64(L, idx) end
---@param L System.IntPtr
---@param idx number
---@return boolean
function XLua.LuaDLL.Lua.lua_isuint64(L, idx) end
---@param L System.IntPtr
---@param idx number
---@return number
function XLua.LuaDLL.Lua.lua_toint64(L, idx) end
---@param L System.IntPtr
---@param idx number
---@return number
function XLua.LuaDLL.Lua.lua_touint64(L, idx) end
---@param L System.IntPtr
---@param fn System.IntPtr
---@param n number
function XLua.LuaDLL.Lua.xlua_push_csharp_function(L, fn, n) end
---@param L System.IntPtr
---@param message string
---@return number
function XLua.LuaDLL.Lua.xlua_csharp_str_error(L, message) end
---@param L System.IntPtr
---@return number
function XLua.LuaDLL.Lua.xlua_csharp_error(L) end
---@param buff System.IntPtr
---@param offset number
---@param field number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_int8_t(buff, offset, field) end
---@param buff System.IntPtr
---@param offset number
---@param out_field number
---@return boolean,number
function XLua.LuaDLL.Lua.xlua_unpack_int8_t(buff, offset, out_field) end
---@param buff System.IntPtr
---@param offset number
---@param field number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_int16_t(buff, offset, field) end
---@param buff System.IntPtr
---@param offset number
---@param out_field number
---@return boolean,number
function XLua.LuaDLL.Lua.xlua_unpack_int16_t(buff, offset, out_field) end
---@param buff System.IntPtr
---@param offset number
---@param field number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_int32_t(buff, offset, field) end
---@param buff System.IntPtr
---@param offset number
---@param out_field number
---@return boolean,number
function XLua.LuaDLL.Lua.xlua_unpack_int32_t(buff, offset, out_field) end
---@param buff System.IntPtr
---@param offset number
---@param field number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_int64_t(buff, offset, field) end
---@param buff System.IntPtr
---@param offset number
---@param out_field number
---@return boolean,number
function XLua.LuaDLL.Lua.xlua_unpack_int64_t(buff, offset, out_field) end
---@param buff System.IntPtr
---@param offset number
---@param field number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_float(buff, offset, field) end
---@param buff System.IntPtr
---@param offset number
---@param out_field number
---@return boolean,number
function XLua.LuaDLL.Lua.xlua_unpack_float(buff, offset, out_field) end
---@param buff System.IntPtr
---@param offset number
---@param field number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_double(buff, offset, field) end
---@param buff System.IntPtr
---@param offset number
---@param out_field number
---@return boolean,number
function XLua.LuaDLL.Lua.xlua_unpack_double(buff, offset, out_field) end
---@param L System.IntPtr
---@param size number
---@param meta_ref number
---@return System.IntPtr
function XLua.LuaDLL.Lua.xlua_pushstruct(L, size, meta_ref) end
---@param L System.IntPtr
---@param field_count number
---@param meta_ref number
function XLua.LuaDLL.Lua.xlua_pushcstable(L, field_count, meta_ref) end
---@param L System.IntPtr
---@param idx number
---@return System.IntPtr
function XLua.LuaDLL.Lua.lua_touserdata(L, idx) end
---@param L System.IntPtr
---@param idx number
---@return number
function XLua.LuaDLL.Lua.xlua_gettypeid(L, idx) end
---@return number
function XLua.LuaDLL.Lua.xlua_get_registry_index() end
---@param L System.IntPtr
---@param idx number
---@param path string
---@return number
function XLua.LuaDLL.Lua.xlua_pgettable_bypath(L, idx, path) end
---@param L System.IntPtr
---@param idx number
---@param path string
---@return number
function XLua.LuaDLL.Lua.xlua_psettable_bypath(L, idx, path) end
---@param buff System.IntPtr
---@param offset number
---@param f1 number
---@param f2 number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_float2(buff, offset, f1, f2) end
---@param buff System.IntPtr
---@param offset number
---@param out_f1 number
---@param out_f2 number
---@return boolean,number,number
function XLua.LuaDLL.Lua.xlua_unpack_float2(buff, offset, out_f1, out_f2) end
---@param buff System.IntPtr
---@param offset number
---@param f1 number
---@param f2 number
---@param f3 number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_float3(buff, offset, f1, f2, f3) end
---@param buff System.IntPtr
---@param offset number
---@param out_f1 number
---@param out_f2 number
---@param out_f3 number
---@return boolean,number,number,number
function XLua.LuaDLL.Lua.xlua_unpack_float3(buff, offset, out_f1, out_f2, out_f3) end
---@param buff System.IntPtr
---@param offset number
---@param f1 number
---@param f2 number
---@param f3 number
---@param f4 number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_float4(buff, offset, f1, f2, f3, f4) end
---@param buff System.IntPtr
---@param offset number
---@param out_f1 number
---@param out_f2 number
---@param out_f3 number
---@param out_f4 number
---@return boolean,number,number,number,number
function XLua.LuaDLL.Lua.xlua_unpack_float4(buff, offset, out_f1, out_f2, out_f3, out_f4) end
---@param buff System.IntPtr
---@param offset number
---@param f1 number
---@param f2 number
---@param f3 number
---@param f4 number
---@param f5 number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_float5(buff, offset, f1, f2, f3, f4, f5) end
---@param buff System.IntPtr
---@param offset number
---@param out_f1 number
---@param out_f2 number
---@param out_f3 number
---@param out_f4 number
---@param out_f5 number
---@return boolean,number,number,number,number,number
function XLua.LuaDLL.Lua.xlua_unpack_float5(buff, offset, out_f1, out_f2, out_f3, out_f4, out_f5) end
---@param buff System.IntPtr
---@param offset number
---@param f1 number
---@param f2 number
---@param f3 number
---@param f4 number
---@param f5 number
---@param f6 number
---@return boolean
function XLua.LuaDLL.Lua.xlua_pack_float6(buff, offset, f1, f2, f3, f4, f5, f6) end
---@param buff System.IntPtr
---@param offset number
---@param out_f1 number
---@param out_f2 number
---@param out_f3 number
---@param out_f4 number
---@param out_f5 number
---@param out_f6 number
---@return boolean,number,number,number,number,number,number
function XLua.LuaDLL.Lua.xlua_unpack_float6(buff, offset, out_f1, out_f2, out_f3, out_f4, out_f5, out_f6) end
---@param buff System.IntPtr
---@param offset number
---@param ref_dec System.Decimal
---@return boolean,System.Decimal
function XLua.LuaDLL.Lua.xlua_pack_decimal(buff, offset, ref_dec) end
---@param buff System.IntPtr
---@param offset number
---@param out_scale number
---@param out_sign number
---@param out_hi32 number
---@param out_lo64 number
---@return boolean,number,number,number,number
function XLua.LuaDLL.Lua.xlua_unpack_decimal(buff, offset, out_scale, out_sign, out_hi32, out_lo64) end
---@overload fun(L: System.IntPtr, index: number, str: string) : boolean
---@param L System.IntPtr
---@param index number
---@param str string
---@param str_len number
---@return boolean
function XLua.LuaDLL.Lua.xlua_is_eq_str(L, index, str, str_len) end
---@param L System.IntPtr
---@return System.IntPtr
function XLua.LuaDLL.Lua.xlua_gl(L) end

---@class XLua.CSObjectWrap.TutorialTestEnumWrap : System.Object
XLua.CSObjectWrap.TutorialTestEnumWrap = {}
---@alias CS.XLua.CSObjectWrap.TutorialTestEnumWrap XLua.CSObjectWrap.TutorialTestEnumWrap
CS.XLua.CSObjectWrap.TutorialTestEnumWrap = XLua.CSObjectWrap.TutorialTestEnumWrap

---@return XLua.CSObjectWrap.TutorialTestEnumWrap
function XLua.CSObjectWrap.TutorialTestEnumWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.TutorialTestEnumWrap.__Register(L) end

---@class XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap : System.Object
XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap = {}
---@alias CS.XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap
CS.XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap = XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap

---@return XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap
function XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.TutorialDerivedClassTestEnumInnerWrap.__Register(L) end

---@class XLua.CSObjectWrap.ModConfigWrap : System.Object
XLua.CSObjectWrap.ModConfigWrap = {}
---@alias CS.XLua.CSObjectWrap.ModConfigWrap XLua.CSObjectWrap.ModConfigWrap
CS.XLua.CSObjectWrap.ModConfigWrap = XLua.CSObjectWrap.ModConfigWrap

---@return XLua.CSObjectWrap.ModConfigWrap
function XLua.CSObjectWrap.ModConfigWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.ModConfigWrap.__Register(L) end

---@class XLua.CSObjectWrap.ScriptExecutorWrap : System.Object
XLua.CSObjectWrap.ScriptExecutorWrap = {}
---@alias CS.XLua.CSObjectWrap.ScriptExecutorWrap XLua.CSObjectWrap.ScriptExecutorWrap
CS.XLua.CSObjectWrap.ScriptExecutorWrap = XLua.CSObjectWrap.ScriptExecutorWrap

---@return XLua.CSObjectWrap.ScriptExecutorWrap
function XLua.CSObjectWrap.ScriptExecutorWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.ScriptExecutorWrap.__Register(L) end

---@class XLua.CSObjectWrap.StatusManagerWrap : System.Object
XLua.CSObjectWrap.StatusManagerWrap = {}
---@alias CS.XLua.CSObjectWrap.StatusManagerWrap XLua.CSObjectWrap.StatusManagerWrap
CS.XLua.CSObjectWrap.StatusManagerWrap = XLua.CSObjectWrap.StatusManagerWrap

---@return XLua.CSObjectWrap.StatusManagerWrap
function XLua.CSObjectWrap.StatusManagerWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.StatusManagerWrap.__Register(L) end

---@class XLua.CSObjectWrap.StringValueWrap : System.Object
XLua.CSObjectWrap.StringValueWrap = {}
---@alias CS.XLua.CSObjectWrap.StringValueWrap XLua.CSObjectWrap.StringValueWrap
CS.XLua.CSObjectWrap.StringValueWrap = XLua.CSObjectWrap.StringValueWrap

---@return XLua.CSObjectWrap.StringValueWrap
function XLua.CSObjectWrap.StringValueWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.StringValueWrap.__Register(L) end

---@class XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap : System.Object
XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap = {}
---@alias CS.XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap
CS.XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap = XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap

---@return XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap
function XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.SystemCollectionsGenericDictionary_2_SystemStringSystemString_Wrap.__Register(L) end

---@class XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap : System.Object
XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap = {}
---@alias CS.XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap
CS.XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap = XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap

---@return XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap
function XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap.__CSIndexer(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.SystemCollectionsGenericList_1_SystemInt32_Wrap.__NewIndexer(L) end

---@class XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge : XLua.LuaBase
XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge = {}
---@alias CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge
CS.XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge = XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge

---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge
function XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge.New(reference, luaenv) end
---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.LuaBase
function XLua.CSObjectWrap.SystemCollectionsIEnumeratorBridge.__Create(reference, luaenv) end

---@class XLua.CSObjectWrap.SystemObjectWrap : System.Object
XLua.CSObjectWrap.SystemObjectWrap = {}
---@alias CS.XLua.CSObjectWrap.SystemObjectWrap XLua.CSObjectWrap.SystemObjectWrap
CS.XLua.CSObjectWrap.SystemObjectWrap = XLua.CSObjectWrap.SystemObjectWrap

---@return XLua.CSObjectWrap.SystemObjectWrap
function XLua.CSObjectWrap.SystemObjectWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.SystemObjectWrap.__Register(L) end

---@class XLua.CSObjectWrap.TutorialBaseClassWrap : System.Object
XLua.CSObjectWrap.TutorialBaseClassWrap = {}
---@alias CS.XLua.CSObjectWrap.TutorialBaseClassWrap XLua.CSObjectWrap.TutorialBaseClassWrap
CS.XLua.CSObjectWrap.TutorialBaseClassWrap = XLua.CSObjectWrap.TutorialBaseClassWrap

---@return XLua.CSObjectWrap.TutorialBaseClassWrap
function XLua.CSObjectWrap.TutorialBaseClassWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.TutorialBaseClassWrap.__Register(L) end

---@class XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge : XLua.LuaBase
XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge = {}
---@alias CS.XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge
CS.XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge = XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge

---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge
function XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge.New(reference, luaenv) end
---@param reference number
---@param luaenv XLua.LuaEnv
---@return XLua.LuaBase
function XLua.CSObjectWrap.TutorialCSCallLuaItfDBridge.__Create(reference, luaenv) end

---@class XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap : System.Object
XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap = {}
---@alias CS.XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap
CS.XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap = XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap

---@return XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap
function XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.TutorialDerivedClassExtensionsWrap.__Register(L) end

---@class XLua.CSObjectWrap.TutorialDerivedClassWrap : System.Object
XLua.CSObjectWrap.TutorialDerivedClassWrap = {}
---@alias CS.XLua.CSObjectWrap.TutorialDerivedClassWrap XLua.CSObjectWrap.TutorialDerivedClassWrap
CS.XLua.CSObjectWrap.TutorialDerivedClassWrap = XLua.CSObjectWrap.TutorialDerivedClassWrap

---@return XLua.CSObjectWrap.TutorialDerivedClassWrap
function XLua.CSObjectWrap.TutorialDerivedClassWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.TutorialDerivedClassWrap.__Register(L) end

---@class XLua.CSObjectWrap.TutorialICalcWrap : System.Object
XLua.CSObjectWrap.TutorialICalcWrap = {}
---@alias CS.XLua.CSObjectWrap.TutorialICalcWrap XLua.CSObjectWrap.TutorialICalcWrap
CS.XLua.CSObjectWrap.TutorialICalcWrap = XLua.CSObjectWrap.TutorialICalcWrap

---@return XLua.CSObjectWrap.TutorialICalcWrap
function XLua.CSObjectWrap.TutorialICalcWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.TutorialICalcWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineBehaviourWrap : System.Object
XLua.CSObjectWrap.UnityEngineBehaviourWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineBehaviourWrap XLua.CSObjectWrap.UnityEngineBehaviourWrap
CS.XLua.CSObjectWrap.UnityEngineBehaviourWrap = XLua.CSObjectWrap.UnityEngineBehaviourWrap

---@return XLua.CSObjectWrap.UnityEngineBehaviourWrap
function XLua.CSObjectWrap.UnityEngineBehaviourWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineBehaviourWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineColorWrap : System.Object
XLua.CSObjectWrap.UnityEngineColorWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineColorWrap XLua.CSObjectWrap.UnityEngineColorWrap
CS.XLua.CSObjectWrap.UnityEngineColorWrap = XLua.CSObjectWrap.UnityEngineColorWrap

---@return XLua.CSObjectWrap.UnityEngineColorWrap
function XLua.CSObjectWrap.UnityEngineColorWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineColorWrap.__Register(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineColorWrap.__CSIndexer(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineColorWrap.__NewIndexer(L) end

---@class XLua.CSObjectWrap.UnityEngineComponentWrap : System.Object
XLua.CSObjectWrap.UnityEngineComponentWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineComponentWrap XLua.CSObjectWrap.UnityEngineComponentWrap
CS.XLua.CSObjectWrap.UnityEngineComponentWrap = XLua.CSObjectWrap.UnityEngineComponentWrap

---@return XLua.CSObjectWrap.UnityEngineComponentWrap
function XLua.CSObjectWrap.UnityEngineComponentWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineComponentWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineDebugWrap : System.Object
XLua.CSObjectWrap.UnityEngineDebugWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineDebugWrap XLua.CSObjectWrap.UnityEngineDebugWrap
CS.XLua.CSObjectWrap.UnityEngineDebugWrap = XLua.CSObjectWrap.UnityEngineDebugWrap

---@return XLua.CSObjectWrap.UnityEngineDebugWrap
function XLua.CSObjectWrap.UnityEngineDebugWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineDebugWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineGameObjectWrap : System.Object
XLua.CSObjectWrap.UnityEngineGameObjectWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineGameObjectWrap XLua.CSObjectWrap.UnityEngineGameObjectWrap
CS.XLua.CSObjectWrap.UnityEngineGameObjectWrap = XLua.CSObjectWrap.UnityEngineGameObjectWrap

---@return XLua.CSObjectWrap.UnityEngineGameObjectWrap
function XLua.CSObjectWrap.UnityEngineGameObjectWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineGameObjectWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineMathfWrap : System.Object
XLua.CSObjectWrap.UnityEngineMathfWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineMathfWrap XLua.CSObjectWrap.UnityEngineMathfWrap
CS.XLua.CSObjectWrap.UnityEngineMathfWrap = XLua.CSObjectWrap.UnityEngineMathfWrap

---@return XLua.CSObjectWrap.UnityEngineMathfWrap
function XLua.CSObjectWrap.UnityEngineMathfWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineMathfWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap : System.Object
XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap
CS.XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap = XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap

---@return XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap
function XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineMonoBehaviourWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineObjectWrap : System.Object
XLua.CSObjectWrap.UnityEngineObjectWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineObjectWrap XLua.CSObjectWrap.UnityEngineObjectWrap
CS.XLua.CSObjectWrap.UnityEngineObjectWrap = XLua.CSObjectWrap.UnityEngineObjectWrap

---@return XLua.CSObjectWrap.UnityEngineObjectWrap
function XLua.CSObjectWrap.UnityEngineObjectWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineObjectWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineQuaternionWrap : System.Object
XLua.CSObjectWrap.UnityEngineQuaternionWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineQuaternionWrap XLua.CSObjectWrap.UnityEngineQuaternionWrap
CS.XLua.CSObjectWrap.UnityEngineQuaternionWrap = XLua.CSObjectWrap.UnityEngineQuaternionWrap

---@return XLua.CSObjectWrap.UnityEngineQuaternionWrap
function XLua.CSObjectWrap.UnityEngineQuaternionWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineQuaternionWrap.__Register(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineQuaternionWrap.__CSIndexer(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineQuaternionWrap.__NewIndexer(L) end

---@class XLua.CSObjectWrap.UnityEngineTransformWrap : System.Object
XLua.CSObjectWrap.UnityEngineTransformWrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineTransformWrap XLua.CSObjectWrap.UnityEngineTransformWrap
CS.XLua.CSObjectWrap.UnityEngineTransformWrap = XLua.CSObjectWrap.UnityEngineTransformWrap

---@return XLua.CSObjectWrap.UnityEngineTransformWrap
function XLua.CSObjectWrap.UnityEngineTransformWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineTransformWrap.__Register(L) end

---@class XLua.CSObjectWrap.UnityEngineVector2Wrap : System.Object
XLua.CSObjectWrap.UnityEngineVector2Wrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineVector2Wrap XLua.CSObjectWrap.UnityEngineVector2Wrap
CS.XLua.CSObjectWrap.UnityEngineVector2Wrap = XLua.CSObjectWrap.UnityEngineVector2Wrap

---@return XLua.CSObjectWrap.UnityEngineVector2Wrap
function XLua.CSObjectWrap.UnityEngineVector2Wrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineVector2Wrap.__Register(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineVector2Wrap.__CSIndexer(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineVector2Wrap.__NewIndexer(L) end

---@class XLua.CSObjectWrap.UnityEngineVector3Wrap : System.Object
XLua.CSObjectWrap.UnityEngineVector3Wrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineVector3Wrap XLua.CSObjectWrap.UnityEngineVector3Wrap
CS.XLua.CSObjectWrap.UnityEngineVector3Wrap = XLua.CSObjectWrap.UnityEngineVector3Wrap

---@return XLua.CSObjectWrap.UnityEngineVector3Wrap
function XLua.CSObjectWrap.UnityEngineVector3Wrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineVector3Wrap.__Register(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineVector3Wrap.__CSIndexer(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineVector3Wrap.__NewIndexer(L) end

---@class XLua.CSObjectWrap.UnityEngineVector4Wrap : System.Object
XLua.CSObjectWrap.UnityEngineVector4Wrap = {}
---@alias CS.XLua.CSObjectWrap.UnityEngineVector4Wrap XLua.CSObjectWrap.UnityEngineVector4Wrap
CS.XLua.CSObjectWrap.UnityEngineVector4Wrap = XLua.CSObjectWrap.UnityEngineVector4Wrap

---@return XLua.CSObjectWrap.UnityEngineVector4Wrap
function XLua.CSObjectWrap.UnityEngineVector4Wrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.UnityEngineVector4Wrap.__Register(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineVector4Wrap.__CSIndexer(L) end
---@param L System.IntPtr
---@return number
function XLua.CSObjectWrap.UnityEngineVector4Wrap.__NewIndexer(L) end

---@class XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap : System.Object
XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap = {}
---@alias CS.XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap
CS.XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap = XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap

---@return XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap
function XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap.New() end
---@param L System.IntPtr
function XLua.CSObjectWrap.WitchModLuaModHookAdapterWrap.__Register(L) end

---@class XLua.CSObjectWrap.XLua_Gen_Initer_Register__ : System.Object
XLua.CSObjectWrap.XLua_Gen_Initer_Register__ = {}
---@alias CS.XLua.CSObjectWrap.XLua_Gen_Initer_Register__ XLua.CSObjectWrap.XLua_Gen_Initer_Register__
CS.XLua.CSObjectWrap.XLua_Gen_Initer_Register__ = XLua.CSObjectWrap.XLua_Gen_Initer_Register__

---@return XLua.CSObjectWrap.XLua_Gen_Initer_Register__
function XLua.CSObjectWrap.XLua_Gen_Initer_Register__.New() end

---@class UI.ScreenEffect.ScreenEffectBase : UnityEngine.MonoBehaviour
---@field delay number
UI.ScreenEffect.ScreenEffectBase = {}
---@alias CS.UI.ScreenEffect.ScreenEffectBase UI.ScreenEffect.ScreenEffectBase
CS.UI.ScreenEffect.ScreenEffectBase = UI.ScreenEffect.ScreenEffectBase

function UI.ScreenEffect.ScreenEffectBase:Play() end

---@class UI.ScreenEffect.ShakeScreenEffect : UI.ScreenEffect.ScreenEffectBase
---@field count number
---@field duration number
---@field intensity number
UI.ScreenEffect.ShakeScreenEffect = {}
---@alias CS.UI.ScreenEffect.ShakeScreenEffect UI.ScreenEffect.ShakeScreenEffect
CS.UI.ScreenEffect.ShakeScreenEffect = UI.ScreenEffect.ShakeScreenEffect

function UI.ScreenEffect.ShakeScreenEffect:Play() end

---@class UnityEngine.UI.ScrollRectNonDrag : UnityEngine.EventSystems.UIBehaviour
---@field content UnityEngine.RectTransform
---@field horizontal boolean
---@field vertical boolean
---@field movementType UnityEngine.UI.ScrollRectNonDrag.MovementType
---@field elasticity number
---@field inertia boolean
---@field decelerationRate number
---@field scrollSensitivity number
---@field viewport UnityEngine.RectTransform
---@field horizontalScrollbar UnityEngine.UI.Scrollbar
---@field verticalScrollbar UnityEngine.UI.Scrollbar
---@field horizontalScrollbarVisibility UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility
---@field verticalScrollbarVisibility UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility
---@field horizontalScrollbarSpacing number
---@field verticalScrollbarSpacing number
---@field onValueChanged UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent
---@field velocity UnityEngine.Vector2
---@field normalizedPosition UnityEngine.Vector2
---@field horizontalNormalizedPosition number
---@field verticalNormalizedPosition number
---@field minWidth number
---@field preferredWidth number
---@field flexibleWidth number
---@field minHeight number
---@field preferredHeight number
---@field flexibleHeight number
---@field layoutPriority number
UnityEngine.UI.ScrollRectNonDrag = {}
---@alias CS.UnityEngine.UI.ScrollRectNonDrag UnityEngine.UI.ScrollRectNonDrag
CS.UnityEngine.UI.ScrollRectNonDrag = UnityEngine.UI.ScrollRectNonDrag

---@param executing UnityEngine.UI.CanvasUpdate
function UnityEngine.UI.ScrollRectNonDrag:Rebuild(executing) end
function UnityEngine.UI.ScrollRectNonDrag:LayoutComplete() end
function UnityEngine.UI.ScrollRectNonDrag:GraphicUpdateComplete() end
---@return boolean
function UnityEngine.UI.ScrollRectNonDrag:IsActive() end
function UnityEngine.UI.ScrollRectNonDrag:StopMovement() end
---@param data UnityEngine.EventSystems.PointerEventData
function UnityEngine.UI.ScrollRectNonDrag:OnScroll(data) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function UnityEngine.UI.ScrollRectNonDrag:OnInitializePotentialDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function UnityEngine.UI.ScrollRectNonDrag:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function UnityEngine.UI.ScrollRectNonDrag:OnEndDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function UnityEngine.UI.ScrollRectNonDrag:OnDrag(eventData) end
function UnityEngine.UI.ScrollRectNonDrag:CalculateLayoutInputHorizontal() end
function UnityEngine.UI.ScrollRectNonDrag:CalculateLayoutInputVertical() end
function UnityEngine.UI.ScrollRectNonDrag:SetLayoutHorizontal() end
function UnityEngine.UI.ScrollRectNonDrag:SetLayoutVertical() end

---@class UnityEngine.UI.ScrollRectNonDrag.MovementType
---@field Unrestricted UnityEngine.UI.ScrollRectNonDrag.MovementType
---@field Elastic UnityEngine.UI.ScrollRectNonDrag.MovementType
---@field Clamped UnityEngine.UI.ScrollRectNonDrag.MovementType
UnityEngine.UI.ScrollRectNonDrag.MovementType = {}
---@alias CS.UnityEngine.UI.ScrollRectNonDrag.MovementType UnityEngine.UI.ScrollRectNonDrag.MovementType
CS.UnityEngine.UI.ScrollRectNonDrag.MovementType = UnityEngine.UI.ScrollRectNonDrag.MovementType


---@class UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility
---@field Permanent UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility
---@field AutoHide UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility
---@field AutoHideAndExpandViewport UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility
UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility = {}
---@alias CS.UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility
CS.UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility = UnityEngine.UI.ScrollRectNonDrag.ScrollbarVisibility


---@class UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent : UnityEngine.Events.UnityEvent
UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent = {}
---@alias CS.UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent
CS.UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent = UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent

---@return UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent
function UnityEngine.UI.ScrollRectNonDrag.ScrollRectEvent.New() end

---@class Component.UI.Animation.ClockAnimator : UnityEngine.MonoBehaviour
---@field clockHand UnityEngine.Transform
---@field clockBoard UnityEngine.Transform
---@field rotateSound UnityEngine.AudioClip
---@field rotationDuration number
---@field fullRotationEase DG.Tweening.Ease
---@field rotateCount number
Component.UI.Animation.ClockAnimator = {}
---@alias CS.Component.UI.Animation.ClockAnimator Component.UI.Animation.ClockAnimator
CS.Component.UI.Animation.ClockAnimator = Component.UI.Animation.ClockAnimator

function Component.UI.Animation.ClockAnimator:Awake() end
---@param rotateType Component.UI.Animation.ClockAnimator.RotatePos
function Component.UI.Animation.ClockAnimator:RotateToAngle(rotateType) end
function Component.UI.Animation.ClockAnimator:RotateToSelf() end
function Component.UI.Animation.ClockAnimator:RotateToFriend() end
function Component.UI.Animation.ClockAnimator:RotateToEnemy() end
function Component.UI.Animation.ClockAnimator:RotateToNeutral() end

---@class Component.UI.Animation.ClockAnimator.RotatePos
---@field Default Component.UI.Animation.ClockAnimator.RotatePos
---@field Self Component.UI.Animation.ClockAnimator.RotatePos
---@field Enemy Component.UI.Animation.ClockAnimator.RotatePos
---@field Friend Component.UI.Animation.ClockAnimator.RotatePos
---@field Neutral Component.UI.Animation.ClockAnimator.RotatePos
Component.UI.Animation.ClockAnimator.RotatePos = {}
---@alias CS.Component.UI.Animation.ClockAnimator.RotatePos Component.UI.Animation.ClockAnimator.RotatePos
CS.Component.UI.Animation.ClockAnimator.RotatePos = Component.UI.Animation.ClockAnimator.RotatePos


---@class Network.Query.QueryBase : System.Object
---@field QueryId number
Network.Query.QueryBase = {}
---@alias CS.Network.Query.QueryBase Network.Query.QueryBase
CS.Network.Query.QueryBase = Network.Query.QueryBase

function Network.Query.QueryBase:CmdExecute() end
---@param response Network.Query.QueryBase
function Network.Query.QueryBase:OnResponse(response) end

---@class Network.Query.QueryBase : Network.Query.QueryBase
---@field Result T
---@field Callback System.Action[T]
Network.Query.QueryBase = {}
---@alias CS.Network.Query.QueryBase Network.Query.QueryBase
CS.Network.Query.QueryBase = Network.Query.QueryBase

---@param response Network.Query.QueryBase
function Network.Query.QueryBase:OnResponse(response) end

---@class Network.Query.QueryBaseSerializer : System.Object
Network.Query.QueryBaseSerializer = {}
---@alias CS.Network.Query.QueryBaseSerializer Network.Query.QueryBaseSerializer
CS.Network.Query.QueryBaseSerializer = Network.Query.QueryBaseSerializer

---@param writer Mirror.NetworkWriter
---@param value Network.Query.QueryBase
function Network.Query.QueryBaseSerializer.Write(writer, value) end
---@param reader Mirror.NetworkReader
---@return Network.Query.QueryBase
function Network.Query.QueryBaseSerializer.Read(reader) end

---@class Network.Query.QueryCareers : Network.Query.QueryBase
---@field Result Network.Query.QueryCareers -- infered from Network.Query.QueryBase`1[System.ValueTuple`2[System.String,DataConfig][]]
Network.Query.QueryCareers = {}
---@alias CS.Network.Query.QueryCareers Network.Query.QueryCareers
CS.Network.Query.QueryCareers = Network.Query.QueryCareers

---@return Network.Query.QueryCareers
function Network.Query.QueryCareers.New() end
function Network.Query.QueryCareers:CmdExecute() end

---@class Network.Query.QueryDeck : Network.Query.QueryBase
---@field instanceId string
---@field Result Network.Query.QueryDeck -- infered from Network.Query.QueryBase`1[Witch.UI.Window.OutDeckUIData]
Network.Query.QueryDeck = {}
---@alias CS.Network.Query.QueryDeck Network.Query.QueryDeck
CS.Network.Query.QueryDeck = Network.Query.QueryDeck

---@param instanceId string
---@return Network.Query.QueryDeck
function Network.Query.QueryDeck.New(instanceId) end
function Network.Query.QueryDeck:CmdExecute() end

---@class Network.Query.QueryFood : Network.Query.QueryBase
---@field Result Network.Query.QueryFood -- infered from Network.Query.QueryBase`1[System.Collections.Generic.List`1[DataConfig]]
Network.Query.QueryFood = {}
---@alias CS.Network.Query.QueryFood Network.Query.QueryFood
CS.Network.Query.QueryFood = Network.Query.QueryFood

---@return Network.Query.QueryFood
function Network.Query.QueryFood.New() end
function Network.Query.QueryFood:CmdExecute() end

---@class Network.Query.QueryStatus : Network.Query.QueryBase
---@field instanceId string
---@field Result Network.Query.QueryStatus -- infered from Network.Query.QueryBase`1[Witch.UI.Window.StatusUIData]
Network.Query.QueryStatus = {}
---@alias CS.Network.Query.QueryStatus Network.Query.QueryStatus
CS.Network.Query.QueryStatus = Network.Query.QueryStatus

---@param instanceId string
---@return Network.Query.QueryStatus
function Network.Query.QueryStatus.New(instanceId) end
function Network.Query.QueryStatus:CmdExecute() end

---@class Network.Command.RpcCommandBase : System.Object
Network.Command.RpcCommandBase = {}
---@alias CS.Network.Command.RpcCommandBase Network.Command.RpcCommandBase
CS.Network.Command.RpcCommandBase = Network.Command.RpcCommandBase

---@return Network.Command.RpcCommandBase
function Network.Command.RpcCommandBase.New() end
function Network.Command.RpcCommandBase:CmdExecute() end
function Network.Command.RpcCommandBase:RpcExecute() end

---@class Network.Command.RpcCommandBaseSerializer : System.Object
Network.Command.RpcCommandBaseSerializer = {}
---@alias CS.Network.Command.RpcCommandBaseSerializer Network.Command.RpcCommandBaseSerializer
CS.Network.Command.RpcCommandBaseSerializer = Network.Command.RpcCommandBaseSerializer

---@param writer Mirror.NetworkWriter
---@param value Network.Command.RpcCommandBase
function Network.Command.RpcCommandBaseSerializer.Write(writer, value) end
---@param reader Mirror.NetworkReader
---@return Network.Command.RpcCommandBase
function Network.Command.RpcCommandBaseSerializer.Read(reader) end

---@class Network.Command.RpcEatFood : Network.Command.RpcCommandBase
---@field dataConfig DataConfig
---@field getId string
---@field isEat boolean
Network.Command.RpcEatFood = {}
---@alias CS.Network.Command.RpcEatFood Network.Command.RpcEatFood
CS.Network.Command.RpcEatFood = Network.Command.RpcEatFood

---@param dataConfig DataConfig
---@param getId string
---@return Network.Command.RpcEatFood
function Network.Command.RpcEatFood.New(dataConfig, getId) end
function Network.Command.RpcEatFood:CmdExecute() end
function Network.Command.RpcEatFood:RpcExecute() end

---@class Network.Command.RpcGetItem : Network.Command.RpcCommandBase
---@field itemType string
---@field dataConfig DataConfig
---@field getId string
---@field isGet boolean
Network.Command.RpcGetItem = {}
---@alias CS.Network.Command.RpcGetItem Network.Command.RpcGetItem
CS.Network.Command.RpcGetItem = Network.Command.RpcGetItem

---@param itemType string
---@param dataConfig DataConfig
---@param getId string
---@return Network.Command.RpcGetItem
function Network.Command.RpcGetItem.New(itemType, dataConfig, getId) end
function Network.Command.RpcGetItem:CmdExecute() end
function Network.Command.RpcGetItem:RpcExecute() end

---@class Network.Command.RpcSendChat : Network.Command.RpcCommandBase
---@field name string
---@field message string
Network.Command.RpcSendChat = {}
---@alias CS.Network.Command.RpcSendChat Network.Command.RpcSendChat
CS.Network.Command.RpcSendChat = Network.Command.RpcSendChat

---@param name string
---@param message string
---@return Network.Command.RpcSendChat
function Network.Command.RpcSendChat.New(name, message) end
function Network.Command.RpcSendChat:RpcExecute() end

---@class Network.Command.RpcSendEmoji : Network.Command.RpcCommandBase
---@field instanceid string
---@field emoji GifAsset
Network.Command.RpcSendEmoji = {}
---@alias CS.Network.Command.RpcSendEmoji Network.Command.RpcSendEmoji
CS.Network.Command.RpcSendEmoji = Network.Command.RpcSendEmoji

---@param instanceid string
---@param emoji GifAsset
---@return Network.Command.RpcSendEmoji
function Network.Command.RpcSendEmoji.New(instanceid, emoji) end
function Network.Command.RpcSendEmoji:RpcExecute() end

---@class Network.Command.RpcSendItem : Network.Command.RpcCommandBase
---@field dataConfig DataConfig
---@field itemType string
Network.Command.RpcSendItem = {}
---@alias CS.Network.Command.RpcSendItem Network.Command.RpcSendItem
CS.Network.Command.RpcSendItem = Network.Command.RpcSendItem

---@param itemType string
---@param dataConfig DataConfig
---@return Network.Command.RpcSendItem
function Network.Command.RpcSendItem.New(itemType, dataConfig) end
function Network.Command.RpcSendItem:CmdExecute() end
function Network.Command.RpcSendItem:RpcExecute() end

---@class Network.Command.RpcUpdateWareShow : Network.Command.RpcCommandBase
Network.Command.RpcUpdateWareShow = {}
---@alias CS.Network.Command.RpcUpdateWareShow Network.Command.RpcUpdateWareShow
CS.Network.Command.RpcUpdateWareShow = Network.Command.RpcUpdateWareShow

---@return Network.Command.RpcUpdateWareShow
function Network.Command.RpcUpdateWareShow.New() end
function Network.Command.RpcUpdateWareShow:RpcExecute() end

---@class Fight.StatusCommand.ClientCommandBase : System.Object
---@field Type string
---@field Value number
---@field InstanceId string
---@field From string
Fight.StatusCommand.ClientCommandBase = {}
---@alias CS.Fight.StatusCommand.ClientCommandBase Fight.StatusCommand.ClientCommandBase
CS.Fight.StatusCommand.ClientCommandBase = Fight.StatusCommand.ClientCommandBase

function Fight.StatusCommand.ClientCommandBase.RegisterFormatter() end
function Fight.StatusCommand.ClientCommandBase:Validate() end
---@param value number
---@param instanceId string
---@return Fight.StatusCommand.ClientCommandBase
function Fight.StatusCommand.ClientCommandBase:Create(value, instanceId) end
function Fight.StatusCommand.ClientCommandBase:Execute() end
---@param origin Fight.StatusCommand.ClientCommandBase
---@return Fight.StatusCommand.ClientCommandBase
function Fight.StatusCommand.ClientCommandBase:CopyFrom(origin) end

---@class Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter : MemoryPack.MemoryPackFormatter
Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter = {}
---@alias CS.Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter
CS.Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter = Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter

---@return Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter
function Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.ClientCommandBase
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.ClientCommandBase
function Fight.StatusCommand.ClientCommandBase.ClientCommandBaseFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.StatusCommand.ClientCommandBaseReaderWriter : System.Object
Fight.StatusCommand.ClientCommandBaseReaderWriter = {}
---@alias CS.Fight.StatusCommand.ClientCommandBaseReaderWriter Fight.StatusCommand.ClientCommandBaseReaderWriter
CS.Fight.StatusCommand.ClientCommandBaseReaderWriter = Fight.StatusCommand.ClientCommandBaseReaderWriter

---@param writer Mirror.NetworkWriter
---@param command Fight.StatusCommand.ClientCommandBase
function Fight.StatusCommand.ClientCommandBaseReaderWriter.Write(writer, command) end
---@param reader Mirror.NetworkReader
---@return Fight.StatusCommand.ClientCommandBase
function Fight.StatusCommand.ClientCommandBaseReaderWriter.Read(reader) end

---@class Fight.StatusCommand.CurHp : Fight.StatusCommand.ClientCommandBase
Fight.StatusCommand.CurHp = {}
---@alias CS.Fight.StatusCommand.CurHp Fight.StatusCommand.CurHp
CS.Fight.StatusCommand.CurHp = Fight.StatusCommand.CurHp

---@return Fight.StatusCommand.CurHp
function Fight.StatusCommand.CurHp.New() end
function Fight.StatusCommand.CurHp.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.CurHp
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.CurHp
function Fight.StatusCommand.CurHp.Deserialize(ref_reader, ref_value) end

---@class Fight.StatusCommand.CurHp.CurHpFormatter : MemoryPack.MemoryPackFormatter
Fight.StatusCommand.CurHp.CurHpFormatter = {}
---@alias CS.Fight.StatusCommand.CurHp.CurHpFormatter Fight.StatusCommand.CurHp.CurHpFormatter
CS.Fight.StatusCommand.CurHp.CurHpFormatter = Fight.StatusCommand.CurHp.CurHpFormatter

---@return Fight.StatusCommand.CurHp.CurHpFormatter
function Fight.StatusCommand.CurHp.CurHpFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.CurHp
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.CurHp
function Fight.StatusCommand.CurHp.CurHpFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.StatusCommand.Defend : Fight.StatusCommand.ClientCommandBase
Fight.StatusCommand.Defend = {}
---@alias CS.Fight.StatusCommand.Defend Fight.StatusCommand.Defend
CS.Fight.StatusCommand.Defend = Fight.StatusCommand.Defend

---@return Fight.StatusCommand.Defend
function Fight.StatusCommand.Defend.New() end
function Fight.StatusCommand.Defend.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.Defend
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.Defend
function Fight.StatusCommand.Defend.Deserialize(ref_reader, ref_value) end

---@class Fight.StatusCommand.Defend.DefendFormatter : MemoryPack.MemoryPackFormatter
Fight.StatusCommand.Defend.DefendFormatter = {}
---@alias CS.Fight.StatusCommand.Defend.DefendFormatter Fight.StatusCommand.Defend.DefendFormatter
CS.Fight.StatusCommand.Defend.DefendFormatter = Fight.StatusCommand.Defend.DefendFormatter

---@return Fight.StatusCommand.Defend.DefendFormatter
function Fight.StatusCommand.Defend.DefendFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.Defend
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.Defend
function Fight.StatusCommand.Defend.DefendFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.StatusCommand.MaxHp : Fight.StatusCommand.ClientCommandBase
Fight.StatusCommand.MaxHp = {}
---@alias CS.Fight.StatusCommand.MaxHp Fight.StatusCommand.MaxHp
CS.Fight.StatusCommand.MaxHp = Fight.StatusCommand.MaxHp

---@return Fight.StatusCommand.MaxHp
function Fight.StatusCommand.MaxHp.New() end
function Fight.StatusCommand.MaxHp.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.MaxHp
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.MaxHp
function Fight.StatusCommand.MaxHp.Deserialize(ref_reader, ref_value) end

---@class Fight.StatusCommand.MaxHp.MaxHpFormatter : MemoryPack.MemoryPackFormatter
Fight.StatusCommand.MaxHp.MaxHpFormatter = {}
---@alias CS.Fight.StatusCommand.MaxHp.MaxHpFormatter Fight.StatusCommand.MaxHp.MaxHpFormatter
CS.Fight.StatusCommand.MaxHp.MaxHpFormatter = Fight.StatusCommand.MaxHp.MaxHpFormatter

---@return Fight.StatusCommand.MaxHp.MaxHpFormatter
function Fight.StatusCommand.MaxHp.MaxHpFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.MaxHp
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.MaxHp
function Fight.StatusCommand.MaxHp.MaxHpFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.StatusCommand.ToughCount : Fight.StatusCommand.ClientCommandBase
Fight.StatusCommand.ToughCount = {}
---@alias CS.Fight.StatusCommand.ToughCount Fight.StatusCommand.ToughCount
CS.Fight.StatusCommand.ToughCount = Fight.StatusCommand.ToughCount

---@return Fight.StatusCommand.ToughCount
function Fight.StatusCommand.ToughCount.New() end
function Fight.StatusCommand.ToughCount.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.ToughCount
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.ToughCount
function Fight.StatusCommand.ToughCount.Deserialize(ref_reader, ref_value) end

---@class Fight.StatusCommand.ToughCount.ToughCountFormatter : MemoryPack.MemoryPackFormatter
Fight.StatusCommand.ToughCount.ToughCountFormatter = {}
---@alias CS.Fight.StatusCommand.ToughCount.ToughCountFormatter Fight.StatusCommand.ToughCount.ToughCountFormatter
CS.Fight.StatusCommand.ToughCount.ToughCountFormatter = Fight.StatusCommand.ToughCount.ToughCountFormatter

---@return Fight.StatusCommand.ToughCount.ToughCountFormatter
function Fight.StatusCommand.ToughCount.ToughCountFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.StatusCommand.ToughCount
---@return ,MemoryPack.MemoryPackReader,Fight.StatusCommand.ToughCount
function Fight.StatusCommand.ToughCount.ToughCountFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ObjTarget.ObjTargetAction : Fight.ObjTarget.ObjTargetBase
Fight.ObjTarget.ObjTargetAction = {}
---@alias CS.Fight.ObjTarget.ObjTargetAction Fight.ObjTarget.ObjTargetAction
CS.Fight.ObjTarget.ObjTargetAction = Fight.ObjTarget.ObjTargetAction

---@return Fight.ObjTarget.ObjTargetAction
function Fight.ObjTarget.ObjTargetAction.New() end
function Fight.ObjTarget.ObjTargetAction.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ObjTarget.ObjTargetAction
---@return ,MemoryPack.MemoryPackReader,Fight.ObjTarget.ObjTargetAction
function Fight.ObjTarget.ObjTargetAction.Deserialize(ref_reader, ref_value) end

---@class Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter : MemoryPack.MemoryPackFormatter
Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter = {}
---@alias CS.Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter
CS.Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter = Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter

---@return Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter
function Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ObjTarget.ObjTargetAction
---@return ,MemoryPack.MemoryPackReader,Fight.ObjTarget.ObjTargetAction
function Fight.ObjTarget.ObjTargetAction.ObjTargetActionFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ObjTarget.ObjTargetBase : System.Object
---@field Type string
---@field FromDataConfigId string
---@field ToAction string
---@field theData string
---@field ThisVars System.String[]
---@field Value string
---@field InstanceId string
---@field From string
Fight.ObjTarget.ObjTargetBase = {}
---@alias CS.Fight.ObjTarget.ObjTargetBase Fight.ObjTarget.ObjTargetBase
CS.Fight.ObjTarget.ObjTargetBase = Fight.ObjTarget.ObjTargetBase

function Fight.ObjTarget.ObjTargetBase.RegisterFormatter() end
function Fight.ObjTarget.ObjTargetBase:Validate() end
---@param instanceId string
---@param ObjAction string
---@param fromId string
---@param theData string
---@param Vars System.String[]
---@return Fight.ObjTarget.ObjTargetBase
function Fight.ObjTarget.ObjTargetBase:Create(instanceId, ObjAction, fromId, theData, Vars) end
function Fight.ObjTarget.ObjTargetBase:Execute() end
---@param origin Fight.ObjTarget.ObjTargetBase
---@return Fight.ObjTarget.ObjTargetBase
function Fight.ObjTarget.ObjTargetBase:CopyFrom(origin) end

---@class Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter : MemoryPack.MemoryPackFormatter
Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter = {}
---@alias CS.Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter
CS.Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter = Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter

---@return Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter
function Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ObjTarget.ObjTargetBase
---@return ,MemoryPack.MemoryPackReader,Fight.ObjTarget.ObjTargetBase
function Fight.ObjTarget.ObjTargetBase.ObjTargetBaseFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ObjTarget.ObjTargetBaseReaderWriter : System.Object
Fight.ObjTarget.ObjTargetBaseReaderWriter = {}
---@alias CS.Fight.ObjTarget.ObjTargetBaseReaderWriter Fight.ObjTarget.ObjTargetBaseReaderWriter
CS.Fight.ObjTarget.ObjTargetBaseReaderWriter = Fight.ObjTarget.ObjTargetBaseReaderWriter

---@param writer Mirror.NetworkWriter
---@param command Fight.ObjTarget.ObjTargetBase
function Fight.ObjTarget.ObjTargetBaseReaderWriter.Write(writer, command) end
---@param reader Mirror.NetworkReader
---@return Fight.ObjTarget.ObjTargetBase
function Fight.ObjTarget.ObjTargetBaseReaderWriter.Read(reader) end

---@class Fight.ActionCommand.ActionAnimation : Fight.ActionCommand.ActionCommandBase
Fight.ActionCommand.ActionAnimation = {}
---@alias CS.Fight.ActionCommand.ActionAnimation Fight.ActionCommand.ActionAnimation
CS.Fight.ActionCommand.ActionAnimation = Fight.ActionCommand.ActionAnimation

---@return Fight.ActionCommand.ActionAnimation
function Fight.ActionCommand.ActionAnimation.New() end
function Fight.ActionCommand.ActionAnimation.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.ActionAnimation
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.ActionAnimation
function Fight.ActionCommand.ActionAnimation.Deserialize(ref_reader, ref_value) end
---@param State Witch.UI.Window.FightUI.AnimationData
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.ActionAnimation:Create(State) end

---@class Fight.ActionCommand.ActionAnimation.AnimationData : System.ValueType
---@field status System.String[]
---@field animationState IStatusManager.AnimatedState[]
---@field effectName string
Fight.ActionCommand.ActionAnimation.AnimationData = {}
---@alias CS.Fight.ActionCommand.ActionAnimation.AnimationData Fight.ActionCommand.ActionAnimation.AnimationData
CS.Fight.ActionCommand.ActionAnimation.AnimationData = Fight.ActionCommand.ActionAnimation.AnimationData

function Fight.ActionCommand.ActionAnimation.AnimationData.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.ActionAnimation.AnimationData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.ActionAnimation.AnimationData
function Fight.ActionCommand.ActionAnimation.AnimationData.Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter = {}
---@alias CS.Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter
CS.Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter = Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter

---@return Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter
function Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.ActionAnimation.AnimationData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.ActionAnimation.AnimationData
function Fight.ActionCommand.ActionAnimation.AnimationData.AnimationDataFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter = {}
---@alias CS.Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter
CS.Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter = Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter

---@return Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter
function Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.ActionAnimation
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.ActionAnimation
function Fight.ActionCommand.ActionAnimation.ActionAnimationFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.ActionCommandBase : System.Object
---@field Type string
---@field Value System.Byte[]
---@field From string
---@field Reliable boolean
Fight.ActionCommand.ActionCommandBase = {}
---@alias CS.Fight.ActionCommand.ActionCommandBase Fight.ActionCommand.ActionCommandBase
CS.Fight.ActionCommand.ActionCommandBase = Fight.ActionCommand.ActionCommandBase

function Fight.ActionCommand.ActionCommandBase.RegisterFormatter() end
function Fight.ActionCommand.ActionCommandBase:Execute() end
---@param origin Fight.ActionCommand.ActionCommandBase
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.ActionCommandBase:CopyFrom(origin) end

---@class Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter = {}
---@alias CS.Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter
CS.Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter = Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter

---@return Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter
function Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.ActionCommandBase
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.ActionCommandBase.ActionCommandBaseFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.ActionCommandBaseReaderWriter : System.Object
Fight.ActionCommand.ActionCommandBaseReaderWriter = {}
---@alias CS.Fight.ActionCommand.ActionCommandBaseReaderWriter Fight.ActionCommand.ActionCommandBaseReaderWriter
CS.Fight.ActionCommand.ActionCommandBaseReaderWriter = Fight.ActionCommand.ActionCommandBaseReaderWriter

---@param writer Mirror.NetworkWriter
---@param command Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.ActionCommandBaseReaderWriter.Write(writer, command) end
---@param reader Mirror.NetworkReader
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.ActionCommandBaseReaderWriter.Read(reader) end

---@class Fight.ActionCommand.DamageText : Fight.ActionCommand.ActionCommandBase
Fight.ActionCommand.DamageText = {}
---@alias CS.Fight.ActionCommand.DamageText Fight.ActionCommand.DamageText
CS.Fight.ActionCommand.DamageText = Fight.ActionCommand.DamageText

---@return Fight.ActionCommand.DamageText
function Fight.ActionCommand.DamageText.New() end
function Fight.ActionCommand.DamageText.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.DamageText
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.DamageText
function Fight.ActionCommand.DamageText.Deserialize(ref_reader, ref_value) end
---@param value Fight.ActionCommand.DamageText.DamageTextData
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.DamageText:Create(value) end

---@class Fight.ActionCommand.DamageText.DamageTextData : System.ValueType
---@field from string
---@field to string
---@field hit number
---@field originalVal number
---@field x number
---@field y number
---@field damageType string
Fight.ActionCommand.DamageText.DamageTextData = {}
---@alias CS.Fight.ActionCommand.DamageText.DamageTextData Fight.ActionCommand.DamageText.DamageTextData
CS.Fight.ActionCommand.DamageText.DamageTextData = Fight.ActionCommand.DamageText.DamageTextData

function Fight.ActionCommand.DamageText.DamageTextData.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.DamageText.DamageTextData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.DamageText.DamageTextData
function Fight.ActionCommand.DamageText.DamageTextData.Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter = {}
---@alias CS.Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter
CS.Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter = Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter

---@return Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter
function Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.DamageText.DamageTextData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.DamageText.DamageTextData
function Fight.ActionCommand.DamageText.DamageTextData.DamageTextDataFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.DamageText.DamageTextFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.DamageText.DamageTextFormatter = {}
---@alias CS.Fight.ActionCommand.DamageText.DamageTextFormatter Fight.ActionCommand.DamageText.DamageTextFormatter
CS.Fight.ActionCommand.DamageText.DamageTextFormatter = Fight.ActionCommand.DamageText.DamageTextFormatter

---@return Fight.ActionCommand.DamageText.DamageTextFormatter
function Fight.ActionCommand.DamageText.DamageTextFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.DamageText
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.DamageText
function Fight.ActionCommand.DamageText.DamageTextFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.Effect : Fight.ActionCommand.ActionCommandBase
Fight.ActionCommand.Effect = {}
---@alias CS.Fight.ActionCommand.Effect Fight.ActionCommand.Effect
CS.Fight.ActionCommand.Effect = Fight.ActionCommand.Effect

---@return Fight.ActionCommand.Effect
function Fight.ActionCommand.Effect.New() end
function Fight.ActionCommand.Effect.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.Effect
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.Effect
function Fight.ActionCommand.Effect.Deserialize(ref_reader, ref_value) end
---@param value Fight.ActionCommand.Effect.EffectData
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.Effect:Create(value) end

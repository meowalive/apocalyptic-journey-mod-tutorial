---@meta

---@class Fight.ActionCommand.Effect.EffectData : System.ValueType
---@field effectName string
---@field Self string
---@field Object System.Collections.Generic.List
Fight.ActionCommand.Effect.EffectData = {}
---@alias CS.Fight.ActionCommand.Effect.EffectData Fight.ActionCommand.Effect.EffectData
CS.Fight.ActionCommand.Effect.EffectData = Fight.ActionCommand.Effect.EffectData

function Fight.ActionCommand.Effect.EffectData.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.Effect.EffectData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.Effect.EffectData
function Fight.ActionCommand.Effect.EffectData.Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.Effect.EffectData.EffectDataFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.Effect.EffectData.EffectDataFormatter = {}
---@alias CS.Fight.ActionCommand.Effect.EffectData.EffectDataFormatter Fight.ActionCommand.Effect.EffectData.EffectDataFormatter
CS.Fight.ActionCommand.Effect.EffectData.EffectDataFormatter = Fight.ActionCommand.Effect.EffectData.EffectDataFormatter

---@return Fight.ActionCommand.Effect.EffectData.EffectDataFormatter
function Fight.ActionCommand.Effect.EffectData.EffectDataFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.Effect.EffectData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.Effect.EffectData
function Fight.ActionCommand.Effect.EffectData.EffectDataFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.Effect.EffectFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.Effect.EffectFormatter = {}
---@alias CS.Fight.ActionCommand.Effect.EffectFormatter Fight.ActionCommand.Effect.EffectFormatter
CS.Fight.ActionCommand.Effect.EffectFormatter = Fight.ActionCommand.Effect.EffectFormatter

---@return Fight.ActionCommand.Effect.EffectFormatter
function Fight.ActionCommand.Effect.EffectFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.Effect
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.Effect
function Fight.ActionCommand.Effect.EffectFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.RemoveBuff : Fight.ActionCommand.ActionCommandBase
---@field Reliable boolean
Fight.ActionCommand.RemoveBuff = {}
---@alias CS.Fight.ActionCommand.RemoveBuff Fight.ActionCommand.RemoveBuff
CS.Fight.ActionCommand.RemoveBuff = Fight.ActionCommand.RemoveBuff

---@return Fight.ActionCommand.RemoveBuff
function Fight.ActionCommand.RemoveBuff.New() end
function Fight.ActionCommand.RemoveBuff.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.RemoveBuff
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.RemoveBuff
function Fight.ActionCommand.RemoveBuff.Deserialize(ref_reader, ref_value) end
---@param buffItemConfig BuffItemConfig
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.RemoveBuff:Create(buffItemConfig) end

---@class Fight.ActionCommand.RemoveBuff.RemoveBuffData : System.ValueType
---@field InstanceId string
---@field BuffId string
Fight.ActionCommand.RemoveBuff.RemoveBuffData = {}
---@alias CS.Fight.ActionCommand.RemoveBuff.RemoveBuffData Fight.ActionCommand.RemoveBuff.RemoveBuffData
CS.Fight.ActionCommand.RemoveBuff.RemoveBuffData = Fight.ActionCommand.RemoveBuff.RemoveBuffData

function Fight.ActionCommand.RemoveBuff.RemoveBuffData.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.RemoveBuff.RemoveBuffData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.RemoveBuff.RemoveBuffData
function Fight.ActionCommand.RemoveBuff.RemoveBuffData.Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter = {}
---@alias CS.Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter
CS.Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter = Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter

---@return Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter
function Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.RemoveBuff.RemoveBuffData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.RemoveBuff.RemoveBuffData
function Fight.ActionCommand.RemoveBuff.RemoveBuffData.RemoveBuffDataFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter = {}
---@alias CS.Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter
CS.Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter = Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter

---@return Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter
function Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.RemoveBuff
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.RemoveBuff
function Fight.ActionCommand.RemoveBuff.RemoveBuffFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.State : Fight.ActionCommand.ActionCommandBase
Fight.ActionCommand.State = {}
---@alias CS.Fight.ActionCommand.State Fight.ActionCommand.State
CS.Fight.ActionCommand.State = Fight.ActionCommand.State

---@return Fight.ActionCommand.State
function Fight.ActionCommand.State.New() end
function Fight.ActionCommand.State.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.State
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.State
function Fight.ActionCommand.State.Deserialize(ref_reader, ref_value) end
---@param InstanceId string
---@param State IStatusManager.State
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.State:Create(InstanceId, State) end

---@class Fight.ActionCommand.State.StateData : System.ValueType
---@field To string
---@field Value string
Fight.ActionCommand.State.StateData = {}
---@alias CS.Fight.ActionCommand.State.StateData Fight.ActionCommand.State.StateData
CS.Fight.ActionCommand.State.StateData = Fight.ActionCommand.State.StateData

function Fight.ActionCommand.State.StateData.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.State.StateData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.State.StateData
function Fight.ActionCommand.State.StateData.Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.State.StateData.StateDataFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.State.StateData.StateDataFormatter = {}
---@alias CS.Fight.ActionCommand.State.StateData.StateDataFormatter Fight.ActionCommand.State.StateData.StateDataFormatter
CS.Fight.ActionCommand.State.StateData.StateDataFormatter = Fight.ActionCommand.State.StateData.StateDataFormatter

---@return Fight.ActionCommand.State.StateData.StateDataFormatter
function Fight.ActionCommand.State.StateData.StateDataFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.State.StateData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.State.StateData
function Fight.ActionCommand.State.StateData.StateDataFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.State.StateFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.State.StateFormatter = {}
---@alias CS.Fight.ActionCommand.State.StateFormatter Fight.ActionCommand.State.StateFormatter
CS.Fight.ActionCommand.State.StateFormatter = Fight.ActionCommand.State.StateFormatter

---@return Fight.ActionCommand.State.StateFormatter
function Fight.ActionCommand.State.StateFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.State
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.State
function Fight.ActionCommand.State.StateFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.UpdateBuff : Fight.ActionCommand.ActionCommandBase
---@field Reliable boolean
Fight.ActionCommand.UpdateBuff = {}
---@alias CS.Fight.ActionCommand.UpdateBuff Fight.ActionCommand.UpdateBuff
CS.Fight.ActionCommand.UpdateBuff = Fight.ActionCommand.UpdateBuff

---@return Fight.ActionCommand.UpdateBuff
function Fight.ActionCommand.UpdateBuff.New() end
function Fight.ActionCommand.UpdateBuff.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.UpdateBuff
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.UpdateBuff
function Fight.ActionCommand.UpdateBuff.Deserialize(ref_reader, ref_value) end
---@param buffItemConfig BuffItemConfig
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.UpdateBuff:Create(buffItemConfig) end

---@class Fight.ActionCommand.UpdateBuff.UpdateBuffData : System.ValueType
---@field InstanceId string
---@field Level number
---@field BuffId string
Fight.ActionCommand.UpdateBuff.UpdateBuffData = {}
---@alias CS.Fight.ActionCommand.UpdateBuff.UpdateBuffData Fight.ActionCommand.UpdateBuff.UpdateBuffData
CS.Fight.ActionCommand.UpdateBuff.UpdateBuffData = Fight.ActionCommand.UpdateBuff.UpdateBuffData

function Fight.ActionCommand.UpdateBuff.UpdateBuffData.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.UpdateBuff.UpdateBuffData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.UpdateBuff.UpdateBuffData
function Fight.ActionCommand.UpdateBuff.UpdateBuffData.Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter = {}
---@alias CS.Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter
CS.Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter = Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter

---@return Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter
function Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.UpdateBuff.UpdateBuffData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.UpdateBuff.UpdateBuffData
function Fight.ActionCommand.UpdateBuff.UpdateBuffData.UpdateBuffDataFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter = {}
---@alias CS.Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter
CS.Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter = Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter

---@return Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter
function Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.UpdateBuff
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.UpdateBuff
function Fight.ActionCommand.UpdateBuff.UpdateBuffFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.UseCard : Fight.ActionCommand.ActionCommandBase
Fight.ActionCommand.UseCard = {}
---@alias CS.Fight.ActionCommand.UseCard Fight.ActionCommand.UseCard
CS.Fight.ActionCommand.UseCard = Fight.ActionCommand.UseCard

---@return Fight.ActionCommand.UseCard
function Fight.ActionCommand.UseCard.New() end
function Fight.ActionCommand.UseCard.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.UseCard
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.UseCard
function Fight.ActionCommand.UseCard.Deserialize(ref_reader, ref_value) end
---@param cardData Fight.ActionCommand.UseCard.CardUseData
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.UseCard:Create(cardData) end

---@class Fight.ActionCommand.UseCard.CardUseData : System.ValueType
---@field cardData DataConfig
---@field isBurning boolean
Fight.ActionCommand.UseCard.CardUseData = {}
---@alias CS.Fight.ActionCommand.UseCard.CardUseData Fight.ActionCommand.UseCard.CardUseData
CS.Fight.ActionCommand.UseCard.CardUseData = Fight.ActionCommand.UseCard.CardUseData

function Fight.ActionCommand.UseCard.CardUseData.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.UseCard.CardUseData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.UseCard.CardUseData
function Fight.ActionCommand.UseCard.CardUseData.Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter = {}
---@alias CS.Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter
CS.Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter = Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter

---@return Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter
function Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.UseCard.CardUseData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.UseCard.CardUseData
function Fight.ActionCommand.UseCard.CardUseData.CardUseDataFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.UseCard.UseCardFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.UseCard.UseCardFormatter = {}
---@alias CS.Fight.ActionCommand.UseCard.UseCardFormatter Fight.ActionCommand.UseCard.UseCardFormatter
CS.Fight.ActionCommand.UseCard.UseCardFormatter = Fight.ActionCommand.UseCard.UseCardFormatter

---@return Fight.ActionCommand.UseCard.UseCardFormatter
function Fight.ActionCommand.UseCard.UseCardFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.UseCard
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.UseCard
function Fight.ActionCommand.UseCard.UseCardFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.Vocal : Fight.ActionCommand.ActionCommandBase
Fight.ActionCommand.Vocal = {}
---@alias CS.Fight.ActionCommand.Vocal Fight.ActionCommand.Vocal
CS.Fight.ActionCommand.Vocal = Fight.ActionCommand.Vocal

---@return Fight.ActionCommand.Vocal
function Fight.ActionCommand.Vocal.New() end
function Fight.ActionCommand.Vocal.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.Vocal
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.Vocal
function Fight.ActionCommand.Vocal.Deserialize(ref_reader, ref_value) end
---@param instanceId string
---@param state IStatusManager.VocalState
---@return Fight.ActionCommand.ActionCommandBase
function Fight.ActionCommand.Vocal:Create(instanceId, state) end

---@class Fight.ActionCommand.Vocal.VocalData : System.ValueType
---@field To string
---@field State number
Fight.ActionCommand.Vocal.VocalData = {}
---@alias CS.Fight.ActionCommand.Vocal.VocalData Fight.ActionCommand.Vocal.VocalData
CS.Fight.ActionCommand.Vocal.VocalData = Fight.ActionCommand.Vocal.VocalData

function Fight.ActionCommand.Vocal.VocalData.RegisterFormatter() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.Vocal.VocalData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.Vocal.VocalData
function Fight.ActionCommand.Vocal.VocalData.Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter = {}
---@alias CS.Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter
CS.Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter = Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter

---@return Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter
function Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.Vocal.VocalData
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.Vocal.VocalData
function Fight.ActionCommand.Vocal.VocalData.VocalDataFormatter:Deserialize(ref_reader, ref_value) end

---@class Fight.ActionCommand.Vocal.VocalFormatter : MemoryPack.MemoryPackFormatter
Fight.ActionCommand.Vocal.VocalFormatter = {}
---@alias CS.Fight.ActionCommand.Vocal.VocalFormatter Fight.ActionCommand.Vocal.VocalFormatter
CS.Fight.ActionCommand.Vocal.VocalFormatter = Fight.ActionCommand.Vocal.VocalFormatter

---@return Fight.ActionCommand.Vocal.VocalFormatter
function Fight.ActionCommand.Vocal.VocalFormatter.New() end
---@param ref_reader MemoryPack.MemoryPackReader
---@param ref_value Fight.ActionCommand.Vocal
---@return ,MemoryPack.MemoryPackReader,Fight.ActionCommand.Vocal
function Fight.ActionCommand.Vocal.VocalFormatter:Deserialize(ref_reader, ref_value) end

---@class DataEditor.CardEditor.EffectName : System.Attribute
---@field text string
DataEditor.CardEditor.EffectName = {}
---@alias CS.DataEditor.CardEditor.EffectName DataEditor.CardEditor.EffectName
CS.DataEditor.CardEditor.EffectName = DataEditor.CardEditor.EffectName

---@param name string
---@return DataEditor.CardEditor.EffectName
function DataEditor.CardEditor.EffectName.New(name) end

---@class DataEditor.CardEditor.EffectDes : System.Attribute
---@field text string
DataEditor.CardEditor.EffectDes = {}
---@alias CS.DataEditor.CardEditor.EffectDes DataEditor.CardEditor.EffectDes
CS.DataEditor.CardEditor.EffectDes = DataEditor.CardEditor.EffectDes

---@param des string
---@return DataEditor.CardEditor.EffectDes
function DataEditor.CardEditor.EffectDes.New(des) end

---@class DataEditor.CardEditor.EffectLimit : System.Attribute
---@field limit number
DataEditor.CardEditor.EffectLimit = {}
---@alias CS.DataEditor.CardEditor.EffectLimit DataEditor.CardEditor.EffectLimit
CS.DataEditor.CardEditor.EffectLimit = DataEditor.CardEditor.EffectLimit

---@param limit number
---@return DataEditor.CardEditor.EffectLimit
function DataEditor.CardEditor.EffectLimit.New(limit) end

---@class DataEditor.CardEditor.EffectTarget : System.Attribute
---@field weight number
DataEditor.CardEditor.EffectTarget = {}
---@alias CS.DataEditor.CardEditor.EffectTarget DataEditor.CardEditor.EffectTarget
CS.DataEditor.CardEditor.EffectTarget = DataEditor.CardEditor.EffectTarget

---@param target number
---@return DataEditor.CardEditor.EffectTarget
function DataEditor.CardEditor.EffectTarget.New(target) end

---@class DataEditor.CardEditor.EffectCardDes : System.Attribute
---@field text string
DataEditor.CardEditor.EffectCardDes = {}
---@alias CS.DataEditor.CardEditor.EffectCardDes DataEditor.CardEditor.EffectCardDes
CS.DataEditor.CardEditor.EffectCardDes = DataEditor.CardEditor.EffectCardDes

---@param des string
---@return DataEditor.CardEditor.EffectCardDes
function DataEditor.CardEditor.EffectCardDes.New(des) end

---@class DataEditor.CardEditor.AddDesVal : System.Attribute
---@field text string
DataEditor.CardEditor.AddDesVal = {}
---@alias CS.DataEditor.CardEditor.AddDesVal DataEditor.CardEditor.AddDesVal
CS.DataEditor.CardEditor.AddDesVal = DataEditor.CardEditor.AddDesVal

---@param des string
---@return DataEditor.CardEditor.AddDesVal
function DataEditor.CardEditor.AddDesVal.New(des) end

---@class DataEditor.CardEditor.ScriptData : System.Object
---@field Id string
---@field Name string
DataEditor.CardEditor.ScriptData = {}
---@alias CS.DataEditor.CardEditor.ScriptData DataEditor.CardEditor.ScriptData
CS.DataEditor.CardEditor.ScriptData = DataEditor.CardEditor.ScriptData

---@return DataEditor.CardEditor.ScriptData
function DataEditor.CardEditor.ScriptData.New() end
---@return System.Collections.Generic.List
function DataEditor.CardEditor.ScriptData.GetValues() end

---@class DataEditor.CardEditor.BuffData : DataEditor.CardEditor.ScriptData
DataEditor.CardEditor.BuffData = {}
---@alias CS.DataEditor.CardEditor.BuffData DataEditor.CardEditor.BuffData
CS.DataEditor.CardEditor.BuffData = DataEditor.CardEditor.BuffData

---@return DataEditor.CardEditor.BuffData
function DataEditor.CardEditor.BuffData.New() end
---@return System.Collections.Generic.List
function DataEditor.CardEditor.BuffData.GetValues() end

---@class DataEditor.CardEditor.CardEditorBase : System.Object
DataEditor.CardEditor.CardEditorBase = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase DataEditor.CardEditor.CardEditorBase
CS.DataEditor.CardEditor.CardEditorBase = DataEditor.CardEditor.CardEditorBase

---@return DataEditor.CardEditor.CardEditorBase
function DataEditor.CardEditor.CardEditorBase.New() end
---@param type DataEditor.CardEditor.CardEditorBase.CardTypeDes
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.SetCardType(type) end
---@param type DataEditor.CardEditor.CardEditorBase.TimeType
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.GetTime(type) end
---@param val number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.Change(val) end
---@param val number
---@param damagetype DataEditor.CardEditor.CardEditorBase.DamageTypeDes
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.Damage(val, damagetype) end
---@param val number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.ChangePower(val) end
---@param val number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.DrawCount(val) end
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.ChangeRound() end
---@param val number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.ThrowCard(val) end
---@param val number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.BurnCard(val) end
---@param data DataEditor.CardEditor.BuffData
---@param level number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.AddBuff(data, level) end
---@param data DataEditor.CardEditor.BuffData
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.RemoveBuff(data) end
---@param val number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.ChangeHp(val) end
---@param val number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.ChangeMaxHp(val) end
---@param count number
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.AddCardByCardList(count) end
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.ShuffleDeck() end
---@param filter DataEditor.CardEditor.CardEditorBase.TargetTypeDes
---@return System.ValueTuple
function DataEditor.CardEditor.CardEditorBase.SetStatus(filter) end

---@class DataEditor.CardEditor.CardEditorBase.CardType
---@field AttackCardItem DataEditor.CardEditor.CardEditorBase.CardType
---@field CommonCardItem DataEditor.CardEditor.CardEditorBase.CardType
DataEditor.CardEditor.CardEditorBase.CardType = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.CardType DataEditor.CardEditor.CardEditorBase.CardType
CS.DataEditor.CardEditor.CardEditorBase.CardType = DataEditor.CardEditor.CardEditorBase.CardType


---@class DataEditor.CardEditor.CardEditorBase.CardTypeDes
---@field 选中目标 DataEditor.CardEditor.CardEditorBase.CardTypeDes
---@field 非选目标 DataEditor.CardEditor.CardEditorBase.CardTypeDes
DataEditor.CardEditor.CardEditorBase.CardTypeDes = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.CardTypeDes DataEditor.CardEditor.CardEditorBase.CardTypeDes
CS.DataEditor.CardEditor.CardEditorBase.CardTypeDes = DataEditor.CardEditor.CardEditorBase.CardTypeDes


---@class DataEditor.CardEditor.CardEditorBase.ValueSelect
---@field DesVal1 DataEditor.CardEditor.CardEditorBase.ValueSelect
---@field DesVal2 DataEditor.CardEditor.CardEditorBase.ValueSelect
---@field DesVal3 DataEditor.CardEditor.CardEditorBase.ValueSelect
---@field DesVal4 DataEditor.CardEditor.CardEditorBase.ValueSelect
DataEditor.CardEditor.CardEditorBase.ValueSelect = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.ValueSelect DataEditor.CardEditor.CardEditorBase.ValueSelect
CS.DataEditor.CardEditor.CardEditorBase.ValueSelect = DataEditor.CardEditor.CardEditorBase.ValueSelect


---@class DataEditor.CardEditor.CardEditorBase.ValueSelectDes
---@field 数值1 DataEditor.CardEditor.CardEditorBase.ValueSelectDes
---@field 数值2 DataEditor.CardEditor.CardEditorBase.ValueSelectDes
---@field 数值3 DataEditor.CardEditor.CardEditorBase.ValueSelectDes
---@field 数值4 DataEditor.CardEditor.CardEditorBase.ValueSelectDes
DataEditor.CardEditor.CardEditorBase.ValueSelectDes = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.ValueSelectDes DataEditor.CardEditor.CardEditorBase.ValueSelectDes
CS.DataEditor.CardEditor.CardEditorBase.ValueSelectDes = DataEditor.CardEditor.CardEditorBase.ValueSelectDes


---@class DataEditor.CardEditor.CardEditorBase.TimeType
---@field 抽到时 DataEditor.CardEditor.CardEditorBase.TimeType
---@field 使用时 DataEditor.CardEditor.CardEditorBase.TimeType
---@field 丢弃时 DataEditor.CardEditor.CardEditorBase.TimeType
DataEditor.CardEditor.CardEditorBase.TimeType = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.TimeType DataEditor.CardEditor.CardEditorBase.TimeType
CS.DataEditor.CardEditor.CardEditorBase.TimeType = DataEditor.CardEditor.CardEditorBase.TimeType


---@class DataEditor.CardEditor.CardEditorBase.TargetType
---@field Self DataEditor.CardEditor.CardEditorBase.TargetType
---@field Target DataEditor.CardEditor.CardEditorBase.TargetType
---@field All DataEditor.CardEditor.CardEditorBase.TargetType
---@field AllTarget DataEditor.CardEditor.CardEditorBase.TargetType
DataEditor.CardEditor.CardEditorBase.TargetType = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.TargetType DataEditor.CardEditor.CardEditorBase.TargetType
CS.DataEditor.CardEditor.CardEditorBase.TargetType = DataEditor.CardEditor.CardEditorBase.TargetType


---@class DataEditor.CardEditor.CardEditorBase.TargetTypeDes
---@field 自己 DataEditor.CardEditor.CardEditorBase.TargetTypeDes
---@field 目标 DataEditor.CardEditor.CardEditorBase.TargetTypeDes
---@field 所有 DataEditor.CardEditor.CardEditorBase.TargetTypeDes
---@field 所有敌人 DataEditor.CardEditor.CardEditorBase.TargetTypeDes
DataEditor.CardEditor.CardEditorBase.TargetTypeDes = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.TargetTypeDes DataEditor.CardEditor.CardEditorBase.TargetTypeDes
CS.DataEditor.CardEditor.CardEditorBase.TargetTypeDes = DataEditor.CardEditor.CardEditorBase.TargetTypeDes


---@class DataEditor.CardEditor.CardEditorBase.DamageType
---@field Normal DataEditor.CardEditor.CardEditorBase.DamageType
---@field True DataEditor.CardEditor.CardEditorBase.DamageType
DataEditor.CardEditor.CardEditorBase.DamageType = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.DamageType DataEditor.CardEditor.CardEditorBase.DamageType
CS.DataEditor.CardEditor.CardEditorBase.DamageType = DataEditor.CardEditor.CardEditorBase.DamageType


---@class DataEditor.CardEditor.CardEditorBase.DamageTypeDes
---@field 普通 DataEditor.CardEditor.CardEditorBase.DamageTypeDes
---@field 真实 DataEditor.CardEditor.CardEditorBase.DamageTypeDes
DataEditor.CardEditor.CardEditorBase.DamageTypeDes = {}
---@alias CS.DataEditor.CardEditor.CardEditorBase.DamageTypeDes DataEditor.CardEditor.CardEditorBase.DamageTypeDes
CS.DataEditor.CardEditor.CardEditorBase.DamageTypeDes = DataEditor.CardEditor.CardEditorBase.DamageTypeDes


---@class Data.Save.GameOperInfo : System.Object
---@field PlayerId string
---@field HardTags Data.Save.GameOperInfo.ItemsInfo
---@field Cards Data.Save.GameOperInfo.ItemsInfo
---@field Relics Data.Save.GameOperInfo.ItemsInfo
---@field Blessings Data.Save.GameOperInfo.ItemsInfo
Data.Save.GameOperInfo = {}
---@alias CS.Data.Save.GameOperInfo Data.Save.GameOperInfo
CS.Data.Save.GameOperInfo = Data.Save.GameOperInfo

---@return Data.Save.GameOperInfo
function Data.Save.GameOperInfo.New() end

---@class Data.Save.GameOperInfo.ItemsInfo : System.Object
---@field RewardShow System.Collections.Generic.List
---@field Select System.Collections.Generic.List
---@field Delete System.Collections.Generic.List
---@field ShopShow System.Collections.Generic.List
---@field Buy System.Collections.Generic.List
Data.Save.GameOperInfo.ItemsInfo = {}
---@alias CS.Data.Save.GameOperInfo.ItemsInfo Data.Save.GameOperInfo.ItemsInfo
CS.Data.Save.GameOperInfo.ItemsInfo = Data.Save.GameOperInfo.ItemsInfo

---@return Data.Save.GameOperInfo.ItemsInfo
function Data.Save.GameOperInfo.ItemsInfo.New() end

---@class Data.Save.GameOperInfo.ItemsInfo.Info : System.Object
---@field Name string
---@field Level string
Data.Save.GameOperInfo.ItemsInfo.Info = {}
---@alias CS.Data.Save.GameOperInfo.ItemsInfo.Info Data.Save.GameOperInfo.ItemsInfo.Info
CS.Data.Save.GameOperInfo.ItemsInfo.Info = Data.Save.GameOperInfo.ItemsInfo.Info

---@overload fun() : Data.Save.GameOperInfo.ItemsInfo.Info
---@param name string
---@return Data.Save.GameOperInfo.ItemsInfo.Info
function Data.Save.GameOperInfo.ItemsInfo.Info.New(name) end

---@class Data.Save.OperType
---@field RewardShow Data.Save.OperType
---@field ShopShow Data.Save.OperType
---@field Select Data.Save.OperType
---@field Buy Data.Save.OperType
---@field Delete Data.Save.OperType
Data.Save.OperType = {}
---@alias CS.Data.Save.OperType Data.Save.OperType
CS.Data.Save.OperType = Data.Save.OperType


---@class Data.Save.OperObj
---@field Cards Data.Save.OperObj
---@field Relics Data.Save.OperObj
---@field Blessings Data.Save.OperObj
---@field HardTags Data.Save.OperObj
Data.Save.OperObj = {}
---@alias CS.Data.Save.OperObj Data.Save.OperObj
CS.Data.Save.OperObj = Data.Save.OperObj


---@class Data.Save.GameSaveAnalyser : System.Object
---@field Instance Data.Save.GameSaveAnalyser
---@field ItemInfos Data.Save.GameOperInfo
Data.Save.GameSaveAnalyser = {}
---@alias CS.Data.Save.GameSaveAnalyser Data.Save.GameSaveAnalyser
CS.Data.Save.GameSaveAnalyser = Data.Save.GameSaveAnalyser

---@return Data.Save.GameSaveAnalyser
function Data.Save.GameSaveAnalyser.New() end
---@param name string
---@param itemType Data.Save.OperObj
---@param operType Data.Save.OperType
function Data.Save.GameSaveAnalyser:TryPush(name, itemType, operType) end
---@return Cysharp.Threading.Tasks.UniTask
function Data.Save.GameSaveAnalyser:UpdateToSupabase() end

---@class Data.Save.GameSaveAnalyser.SaveSelection : Supabase.Postgrest.Models.BaseModel
---@field data string
Data.Save.GameSaveAnalyser.SaveSelection = {}
---@alias CS.Data.Save.GameSaveAnalyser.SaveSelection Data.Save.GameSaveAnalyser.SaveSelection
CS.Data.Save.GameSaveAnalyser.SaveSelection = Data.Save.GameSaveAnalyser.SaveSelection

---@return Data.Save.GameSaveAnalyser.SaveSelection
function Data.Save.GameSaveAnalyser.SaveSelection.New() end

---@class Data.Save.GameSaveManager : System.Object
---@field MapTree MapTree
Data.Save.GameSaveManager = {}
---@alias CS.Data.Save.GameSaveManager Data.Save.GameSaveManager
CS.Data.Save.GameSaveManager = Data.Save.GameSaveManager

---@return System.Collections.Generic.List
function Data.Save.GameSaveManager.LoadAll() end
---@return Data.Save.SaveInfo
function Data.Save.GameSaveManager.GetNowSave() end
---@param saveInfo Data.Save.SaveInfo
function Data.Save.GameSaveManager.Select(saveInfo) end
function Data.Save.GameSaveManager.Save() end
function Data.Save.GameSaveManager.Delete() end
---@return boolean
function Data.Save.GameSaveManager.IsSave() end
---@return string
function Data.Save.GameSaveManager.GetSaveType() end
---@param roleTable RoleTable
function Data.Save.GameSaveManager.UpdateRoles(roleTable) end
---@return System.Collections.Generic.List
function Data.Save.GameSaveManager.GetHardTags() end
---@param eventId string
function Data.Save.GameSaveManager.AddEventRecord(eventId) end
---@return number
function Data.Save.GameSaveManager.GetEventRecordCount() end
---@return System.Collections.Generic.List
function Data.Save.GameSaveManager.GetEventRecord() end
---@param node MapTree.Node
function Data.Save.GameSaveManager.UpdateNode(node) end
---@return MapTree.Node
function Data.Save.GameSaveManager.GetNode() end
function Data.Save.GameSaveManager.ApplySaveSc() end
---@return System.Collections.Generic.Dictionary
function Data.Save.GameSaveManager.GetRoleTables() end
---@return boolean
function Data.Save.GameSaveManager.CheckCheat() end
---@return number
function Data.Save.GameSaveManager.GetHardLevel() end
---@return number
function Data.Save.GameSaveManager.GetEXHard() end
---@return number
function Data.Save.GameSaveManager.GetLevel() end
---@param value number
function Data.Save.GameSaveManager.SetLevel(value) end
---@return number
function Data.Save.GameSaveManager.GetSeed() end
---@return Data.Save.GameOperInfo
function Data.Save.GameSaveManager.GetItemOpers() end
---@overload fun(key: string, value: System.Object) : string
---@param key Data.Save.GameVar
---@param value System.Object
function Data.Save.GameSaveManager.SetValue(key, value) end

---@class Data.Save.GameVar
---@field ExDeleteCard Data.Save.GameVar
---@field ExLockDes Data.Save.GameVar
---@field ExDeleteDes Data.Save.GameVar
---@field ExTough Data.Save.GameVar
---@field RefreshCount Data.Save.GameVar
---@field PriceMul Data.Save.GameVar
---@field EXEnemyHp Data.Save.GameVar
---@field EXEnemyAtk Data.Save.GameVar
---@field LimitTime Data.Save.GameVar
---@field ToughMul Data.Save.GameVar
---@field Difficulty Data.Save.GameVar
---@field MapScene1 Data.Save.GameVar
---@field MapScene2 Data.Save.GameVar
---@field MapScene3 Data.Save.GameVar
---@field IsKing Data.Save.GameVar
Data.Save.GameVar = {}
---@alias CS.Data.Save.GameVar Data.Save.GameVar
CS.Data.Save.GameVar = Data.Save.GameVar


---@class Data.Save.SaveInfo : System.Object
---@field Name string
---@field CreatedTime string
---@field Version string
---@field HardLevel number
---@field isCheat boolean
---@field mapTree MapTree
---@field modeType string
---@field roleTable System.Collections.Generic.Dictionary
---@field LastNode MapTree.Node
---@field Level number
---@field Seed string
---@field GameVars System.Collections.Generic.Dictionary
---@field startTime System.DateTime
---@field endTime System.DateTime
---@field EventRecord System.Collections.Generic.List
---@field ItemOpers Data.Save.GameOperInfo
---@field HardTags System.Collections.Generic.List
---@field ShareCards System.Collections.Generic.List
---@field ShareRelics System.Collections.Generic.List
---@field SavePath string
---@field EXHard number
Data.Save.SaveInfo = {}
---@alias CS.Data.Save.SaveInfo Data.Save.SaveInfo
CS.Data.Save.SaveInfo = Data.Save.SaveInfo

---@return Data.Save.SaveInfo
function Data.Save.SaveInfo.New() end
---@param name string
---@return Data.Save.SaveInfo
function Data.Save.SaveInfo.Load(name) end
function Data.Save.SaveInfo:Save() end
function Data.Save.SaveInfo:Delete() end
---@param key string
---@param value string
function Data.Save.SaveInfo:SetValue(key, value) end

---@class Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver : Microsoft.CodeAnalysis.MetadataReferenceResolver
---@field ResolveMissingAssemblies boolean
Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver = {}
---@alias CS.Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver
CS.Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver = Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver

---@param innerResolver Microsoft.CodeAnalysis.Scripting.ScriptMetadataResolver
---@return Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver
function Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver.New(innerResolver) end
---@overload fun(self: Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver, searchPaths: System.String[]) : Microsoft.CodeAnalysis.Scripting.ScriptMetadataResolver
---@overload fun(self: Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver, searchPaths: System.Collections.Generic.IEnumerable) : Microsoft.CodeAnalysis.Scripting.ScriptMetadataResolver
---@param searchPaths System.Collections.Immutable.ImmutableArray
---@return Microsoft.CodeAnalysis.Scripting.ScriptMetadataResolver
function Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver:WithSearchPaths(searchPaths) end
---@param baseDirectory string
---@return Microsoft.CodeAnalysis.Scripting.ScriptMetadataResolver
function Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver:WithBaseDirectory(baseDirectory) end
---@param definition Microsoft.CodeAnalysis.MetadataReference
---@param referenceIdentity Microsoft.CodeAnalysis.AssemblyIdentity
---@return Microsoft.CodeAnalysis.PortableExecutableReference
function Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver:ResolveMissingAssembly(definition, referenceIdentity) end
---@overload fun(self: Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver, other: Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver) : boolean
---@param other System.Object
---@return boolean
function Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver:Equals(other) end
---@return number
function Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver:GetHashCode() end
---@param reference string
---@param baseFilePath string
---@param properties Microsoft.CodeAnalysis.MetadataReferenceProperties
---@return System.Collections.Immutable.ImmutableArray
function Microsoft.CodeAnalysis.Scripting.LockedMetadataResolver:ResolveReference(reference, baseFilePath, properties) end

---@class Witch.PointUse : Witch.UI.Window.ItemNonDrag
---@field RewardType string
---@field DesList string
Witch.PointUse = {}
---@alias CS.Witch.PointUse Witch.PointUse
CS.Witch.PointUse = Witch.PointUse

---@overload fun(self: Witch.PointUse, dataConfig1: DataConfig)
---@param Name string
---@param Description string
---@param Icon UnityEngine.Sprite
function Witch.PointUse:Init(Name, Description, Icon) end

---@class Witch.IModeManager
---@field lazyLoad boolean
---@field NowDice Dice
---@field Level number
---@field MapTree MapTree
Witch.IModeManager = {}
---@alias CS.Witch.IModeManager Witch.IModeManager
CS.Witch.IModeManager = Witch.IModeManager

function Witch.IModeManager.ResetCount() end
function Witch.IModeManager:ReadyToChangeMap() end
function Witch.IModeManager:GeneratrMap() end
function Witch.IModeManager:ShowMapSelect() end
---@param type string
---@param id string
function Witch.IModeManager:RpcLoadMap(type, id) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function Witch.IModeManager:MapItemInit(mapSelectUI) end
---@return boolean
function Witch.IModeManager:WinTheGame() end
---@param roleTable RoleTable
---@return RoleTable
function Witch.IModeManager:InitRoleTable(roleTable) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.IModeManager:SetReward(battleRewardsUI) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function Witch.IModeManager:MapUIStart(mapSelectUI) end
function Witch.IModeManager:CloseMapUI() end
---@param rewardType string
function Witch.IModeManager:SetRewardType(rewardType) end
---@param roleTable RoleTable
function Witch.IModeManager:CardCountSet(roleTable) end

---@class Witch.NormalMapManager : Mirror.NetworkBehaviour
---@field lazyLoad boolean
---@field NowDice Dice
---@field Level number
---@field MapTree MapTree
---@field Network_level number
Witch.NormalMapManager = {}
---@alias CS.Witch.NormalMapManager Witch.NormalMapManager
CS.Witch.NormalMapManager = Witch.NormalMapManager

function Witch.NormalMapManager:ReadyToChangeMap() end
function Witch.NormalMapManager:GeneratrMap() end
function Witch.NormalMapManager:RandomGenerate() end
function Witch.NormalMapManager:CloseMapUI() end
function Witch.NormalMapManager:ShowMapSelect() end
---@param type string
---@param id string
function Witch.NormalMapManager:RpcLoadMap(type, id) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function Witch.NormalMapManager:MapItemInit(mapSelectUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.NormalMapManager:SetReward(battleRewardsUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.NormalMapManager:RandomSetReward(battleRewardsUI) end
---@return boolean
function Witch.NormalMapManager:CanResetSafeBox() end
---@return boolean
function Witch.NormalMapManager:WinTheGame() end
---@param roleTable RoleTable
---@return RoleTable
function Witch.NormalMapManager:InitRoleTable(roleTable) end
---@param roleTable RoleTable
function Witch.NormalMapManager:CardCountSet(roleTable) end
---@return boolean
function Witch.NormalMapManager:Weaved() end
---@param writer Mirror.NetworkWriter
---@param forceAll boolean
function Witch.NormalMapManager:SerializeSyncVars(writer, forceAll) end
---@param reader Mirror.NetworkReader
---@param initialState boolean
function Witch.NormalMapManager:DeserializeSyncVars(reader, initialState) end

---@class Witch.SlotMachineManager : Mirror.NetworkBehaviour
---@field canuse boolean
---@field LuckyCoin number
---@field MisfortuneCoin number
---@field NormalCoin number
---@field CoinUseCount number
---@field nowRewardType string
---@field lazyLoad boolean
---@field NowDice Dice
---@field Level number
---@field MapTree MapTree
Witch.SlotMachineManager = {}
---@alias CS.Witch.SlotMachineManager Witch.SlotMachineManager
CS.Witch.SlotMachineManager = Witch.SlotMachineManager

---@param rewardType string
function Witch.SlotMachineManager:SetRewardType(rewardType) end
function Witch.SlotMachineManager:ReadyToChangeMap() end
---@return System.Collections.Generic.List
function Witch.SlotMachineManager:GeneratrMap() end
---@return System.Collections.Generic.List
function Witch.SlotMachineManager:RandomGenerate() end
function Witch.SlotMachineManager:ShowMapSelect() end
---@param type string
---@param id string
function Witch.SlotMachineManager:RpcLoadMap(type, id) end
---@param slotMachUI Witch.SlotMachUI
function Witch.SlotMachineManager:MapItemInit(slotMachUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.SlotMachineManager:SetReward(battleRewardsUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.SlotMachineManager:RandomSetReward(battleRewardsUI) end
function Witch.SlotMachineManager:CloseMapUI() end
---@param result System.Collections.Generic.List
---@param count number
function Witch.SlotMachineManager:ResultUse(result, count) end
---@param result System.Collections.Generic.List
---@param count number
function Witch.SlotMachineManager:RpcUse(result, count) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.SlotMachineManager:LowReward(battleRewardsUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.SlotMachineManager:NormalReward(battleRewardsUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.SlotMachineManager:HighReward(battleRewardsUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.SlotMachineManager:relicReward(battleRewardsUI) end
---@return boolean
function Witch.SlotMachineManager:CanResetSafeBox() end
---@return boolean
function Witch.SlotMachineManager:WinTheGame() end
---@param type string
---@param id string
function Witch.SlotMachineManager:CmdLoadMap(type, id) end
---@param roleTable RoleTable
---@return RoleTable
function Witch.SlotMachineManager:InitRoleTable(roleTable) end
---@param roleTable RoleTable
function Witch.SlotMachineManager:CardCountSet(roleTable) end
---@return boolean
function Witch.SlotMachineManager:Weaved() end

---@class Witch.SublimationManager : Mirror.NetworkBehaviour
---@field lazyLoad boolean
---@field NowDice Dice
---@field Level number
---@field MapTree MapTree
Witch.SublimationManager = {}
---@alias CS.Witch.SublimationManager Witch.SublimationManager
CS.Witch.SublimationManager = Witch.SublimationManager

function Witch.SublimationManager.ResetCount() end
function Witch.SublimationManager:ReadyToChangeMap() end
function Witch.SublimationManager:GeneratrMap() end
function Witch.SublimationManager:RandomGenerate() end
function Witch.SublimationManager:CloseMapUI() end
function Witch.SublimationManager:ShowMapSelect() end
---@param type string
---@param id string
function Witch.SublimationManager:RpcLoadMap(type, id) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function Witch.SublimationManager:MapItemInit(mapSelectUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.SublimationManager:SetReward(battleRewardsUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.SublimationManager:RandomSetReward(battleRewardsUI) end
---@return boolean
function Witch.SublimationManager:CanResetSafeBox() end
---@return boolean
function Witch.SublimationManager:WinTheGame() end
---@param roleTable RoleTable
---@return RoleTable
function Witch.SublimationManager:InitRoleTable(roleTable) end
---@param roleTable RoleTable
function Witch.SublimationManager:CardCountSet(roleTable) end
---@return boolean
function Witch.SublimationManager:Weaved() end

---@class Witch.TeachMapManager : Mirror.NetworkBehaviour
---@field lazyLoad boolean
---@field NowDice Dice
---@field Level number
---@field MapTree MapTree
Witch.TeachMapManager = {}
---@alias CS.Witch.TeachMapManager Witch.TeachMapManager
CS.Witch.TeachMapManager = Witch.TeachMapManager

function Witch.TeachMapManager:ReadyToChangeMap() end
function Witch.TeachMapManager:GeneratrMap() end
function Witch.TeachMapManager:ShowMapSelect() end
function Witch.TeachMapManager:RandomGenerate() end
function Witch.TeachMapManager:CloseMapUI() end
---@param type string
---@param id string
function Witch.TeachMapManager:RpcLoadMap(type, id) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function Witch.TeachMapManager:MapUIStart(mapSelectUI) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function Witch.TeachMapManager:MapItemInit(mapSelectUI) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function Witch.TeachMapManager:SetTeachMap(mapSelectUI) end
---@param mapSelectUI Witch.UI.Window.MapSelectUI
function Witch.TeachMapManager:SetNormalMap(mapSelectUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.TeachMapManager:SetReward(battleRewardsUI) end
---@param battleRewardsUI Witch.UI.Window.BattleRewardsUI
function Witch.TeachMapManager:RandomSetReward(battleRewardsUI) end
---@param roleTable RoleTable
---@return RoleTable
function Witch.TeachMapManager:InitRoleTable(roleTable) end
---@param roleTable RoleTable
function Witch.TeachMapManager:CardCountSet(roleTable) end
---@return boolean
function Witch.TeachMapManager:Weaved() end

---@class Witch.QueryCareer : Network.Query.QueryBase
---@field instanceId string
---@field Result Witch.QueryCareer -- infered from Network.Query.QueryBase`1[Witch.UI.Window.CareerData]
Witch.QueryCareer = {}
---@alias CS.Witch.QueryCareer Witch.QueryCareer
CS.Witch.QueryCareer = Witch.QueryCareer

---@param instanceId string
---@return Witch.QueryCareer
function Witch.QueryCareer.New(instanceId) end
function Witch.QueryCareer:CmdExecute() end

---@class Witch.AffectionItem : UnityEngine.MonoBehaviour
---@field dataConfig DataConfig
---@field affectionUI Witch.UI.Window.AffectionUI
Witch.AffectionItem = {}
---@alias CS.Witch.AffectionItem Witch.AffectionItem
CS.Witch.AffectionItem = Witch.AffectionItem

---@param dataConfig DataConfig
function Witch.AffectionItem:Init(dataConfig) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.AffectionItem:OnPointerClick(eventData) end
function Witch.AffectionItem:DataUpdate() end

---@class Witch.TopStatusItem : UnityEngine.MonoBehaviour
---@field roleTable RoleTable
Witch.TopStatusItem = {}
---@alias CS.Witch.TopStatusItem Witch.TopStatusItem
CS.Witch.TopStatusItem = Witch.TopStatusItem

---@param roleTable RoleTable
function Witch.TopStatusItem:Init(roleTable) end
function Witch.TopStatusItem:ShowCareer() end
function Witch.TopStatusItem:UpdateStatus() end
---@param Defend string
function Witch.TopStatusItem:UpdateDefend(Defend) end
function Witch.TopStatusItem:OpenBack() end
---@param careerData Witch.UI.Window.StatusUIData
function Witch.TopStatusItem:CareerInit(careerData) end
function Witch.TopStatusItem:OpenDeck() end
function Witch.TopStatusItem:HideDefend() end
---@param value string
---@param type string
function Witch.TopStatusItem:OtherChangeShow(value, type) end

---@class Witch.DollItem : UnityEngine.MonoBehaviour
---@field waitTime number
---@field mul number
---@field isRight boolean
Witch.DollItem = {}
---@alias CS.Witch.DollItem Witch.DollItem
CS.Witch.DollItem = Witch.DollItem

function Witch.DollItem:Running() end
function Witch.DollItem:EndRunning() end

---@class Witch.KeyItem : UnityEngine.MonoBehaviour
---@field msg string
---@field islow boolean
Witch.KeyItem = {}
---@alias CS.Witch.KeyItem Witch.KeyItem
CS.Witch.KeyItem = Witch.KeyItem

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.KeyItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.KeyItem:OnPointerExit(eventData) end

---@class Witch.CoinItem : MapItem
Witch.CoinItem = {}
---@alias CS.Witch.CoinItem Witch.CoinItem
CS.Witch.CoinItem = Witch.CoinItem

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.CoinItem:OnPointerDown(eventData) end
---@return Cysharp.Threading.Tasks.UniTask
function Witch.CoinItem:StartLine() end
---@param node1 MapTree.Node
function Witch.CoinItem:Init(node1) end
function Witch.CoinItem:DataUpdate() end
function Witch.CoinItem:RayCheck() end

---@class Witch.SlotMachUI : Witch.UI.Window.MapSelectUI
Witch.SlotMachUI = {}
---@alias CS.Witch.SlotMachUI Witch.SlotMachUI
CS.Witch.SlotMachUI = Witch.SlotMachUI

function Witch.SlotMachUI:FadeIn() end
function Witch.SlotMachUI:DataUpdate() end
function Witch.SlotMachUI:ReadyToSelect() end
---@param nodes System.Collections.Generic.List
function Witch.SlotMachUI:CreateMapItem(nodes) end
function Witch.SlotMachUI:RandomAgain() end
function Witch.SlotMachUI:GenerateCoinItem() end
function Witch.SlotMachUI:MapAnimation() end
function Witch.SlotMachUI:SendNode() end
function Witch.SlotMachUI:SaveMap() end
---@param useCard MapTree.Node
function Witch.SlotMachUI:CoinUse(useCard) end
---@param useCard MapTree.Node
function Witch.SlotMachUI:SlotUse(useCard) end

---@class Witch.SlotRod : UnityEngine.MonoBehaviour
---@field slotMachUI Witch.SlotMachUI
Witch.SlotRod = {}
---@alias CS.Witch.SlotRod Witch.SlotRod
CS.Witch.SlotRod = Witch.SlotRod

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.SlotRod:OnPointerClick(eventData) end

---@class Witch.ModeManager : Mirror.NetworkBehaviour
---@field ModeMapManager Witch.IModeManager
Witch.ModeManager = {}
---@alias CS.Witch.ModeManager Witch.ModeManager
CS.Witch.ModeManager = Witch.ModeManager

---@return boolean
function Witch.ModeManager:Weaved() end

---@class Witch.ModeUseButton : UnityEngine.MonoBehaviour
---@field whiteBack UnityEngine.Transform
---@field Hlight UnityEngine.Transform
---@field Normal UnityEngine.Transform
Witch.ModeUseButton = {}
---@alias CS.Witch.ModeUseButton Witch.ModeUseButton
CS.Witch.ModeUseButton = Witch.ModeUseButton

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.ModeUseButton:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.ModeUseButton:OnPointerExit(eventData) end

---@class Witch.FoodItem : UnityEngine.MonoBehaviour
---@field spriteRenderer UnityEngine.SpriteRenderer
---@field button UnityEngine.UI.Button
---@field SceneItem UnityEngine.GameObject
---@field dataConfig DataConfig
Witch.FoodItem = {}
---@alias CS.Witch.FoodItem Witch.FoodItem
CS.Witch.FoodItem = Witch.FoodItem

---@param fromData DataConfig
function Witch.FoodItem:Init(fromData) end
---@param pos UnityEngine.Vector3
function Witch.FoodItem:Setposition(pos) end
function Witch.FoodItem:EatFood() end

---@class Witch.MapRole : AnimatorRole
---@field SceneItem UnityEngine.GameObject
Witch.MapRole = {}
---@alias CS.Witch.MapRole Witch.MapRole
CS.Witch.MapRole = Witch.MapRole

---@param index number
---@param fromData DataConfig
---@param instanceId string
---@param needDialogueBox boolean
function Witch.MapRole:Init(index, fromData, instanceId, needDialogueBox) end
---@param pos UnityEngine.Vector3
function Witch.MapRole:Setposition(pos) end

---@class Witch.SceneRole : AnimatorRole
---@field SceneItem UnityEngine.GameObject
Witch.SceneRole = {}
---@alias CS.Witch.SceneRole Witch.SceneRole
CS.Witch.SceneRole = Witch.SceneRole

---@param index number
---@param fromData DataConfig
---@param instanceId string
---@param needDialogueBox boolean
function Witch.SceneRole:Init(index, fromData, instanceId, needDialogueBox) end
---@param pos UnityEngine.Vector3
function Witch.SceneRole:Setposition(pos) end

---@class Witch.ImageSelectorWindow : UnityEngine.MonoBehaviour
---@field prefabItem UnityEngine.GameObject
---@field gridParent UnityEngine.Transform
---@field closeButton UnityEngine.UI.Button
Witch.ImageSelectorWindow = {}
---@alias CS.Witch.ImageSelectorWindow Witch.ImageSelectorWindow
CS.Witch.ImageSelectorWindow = Witch.ImageSelectorWindow

---@param callback System.Action | function
function Witch.ImageSelectorWindow.Show(callback) end
function Witch.ImageSelectorWindow:Hide() end

---@class Witch.StoryDetailPanel : UnityEngine.MonoBehaviour
---@field panelRoot UnityEngine.GameObject
---@field actorField UnityEngine.UI.InputField
---@field textField UnityEngine.UI.InputField
---@field backgroundField UnityEngine.UI.InputField
---@field sfxField UnityEngine.UI.InputField
---@field closeButton UnityEngine.UI.Button
---@field applyButton UnityEngine.UI.Button
Witch.StoryDetailPanel = {}
---@alias CS.Witch.StoryDetailPanel Witch.StoryDetailPanel
CS.Witch.StoryDetailPanel = Witch.StoryDetailPanel

---@param line Witch.StoryLine
function Witch.StoryDetailPanel:Show(line) end
function Witch.StoryDetailPanel:Hide() end

---@class Witch.StoryEditorManager : UnityEngine.MonoBehaviour
---@field contentParent UnityEngine.RectTransform
---@field rowPrefab UnityEngine.GameObject
---@field addButton UnityEngine.UI.Button
---@field saveButton UnityEngine.UI.Button
---@field nameInputField TMPro.TMP_InputField
Witch.StoryEditorManager = {}
---@alias CS.Witch.StoryEditorManager Witch.StoryEditorManager
CS.Witch.StoryEditorManager = Witch.StoryEditorManager

function Witch.StoryEditorManager:OnAddClicked() end
function Witch.StoryEditorManager:AddLine() end
---@param line Witch.StoryLine
function Witch.StoryEditorManager:RemoveLine(line) end
---@param line Witch.StoryLine
function Witch.StoryEditorManager:MoveLineUp(line) end
---@param line Witch.StoryLine
function Witch.StoryEditorManager:MoveLineDown(line) end

---@class Witch.StoryLine : System.Object
---@field id number
---@field actor string
---@field text string
---@field endTime string
---@field triTime string
Witch.StoryLine = {}
---@alias CS.Witch.StoryLine Witch.StoryLine
CS.Witch.StoryLine = Witch.StoryLine

---@return Witch.StoryLine
function Witch.StoryLine.New() end

---@class Witch.StoryEditorUI : Witch.UI.UIBase
---@field characterImage UnityEngine.UI.Image
---@field changeImageButton UnityEngine.UI.Button
---@field ImagePrefab UnityEngine.GameObject
---@field ImageParent UnityEngine.Transform
---@field LanguageCode string
Witch.StoryEditorUI = {}
---@alias CS.Witch.StoryEditorUI Witch.StoryEditorUI
CS.Witch.StoryEditorUI = Witch.StoryEditorUI

function Witch.StoryEditorUI:ChangeImageShow() end
---@param image UnityEngine.UI.Image
function Witch.StoryEditorUI:SetImage(image) end

---@class Witch.StoryRowUI : UnityEngine.MonoBehaviour
---@field indexText TMPro.TMP_Text
---@field actorField TMPro.TMP_InputField
---@field textField TMPro.TMP_InputField
---@field upButton UnityEngine.UI.Button
---@field downButton UnityEngine.UI.Button
---@field deleteButton UnityEngine.UI.Button
---@field enableToggle UnityEngine.UI.Toggle
---@field storyEditorUI Witch.StoryEditorUI
Witch.StoryRowUI = {}
---@alias CS.Witch.StoryRowUI Witch.StoryRowUI
CS.Witch.StoryRowUI = Witch.StoryRowUI

---@param line Witch.StoryLine
---@param mgr Witch.StoryEditorManager
function Witch.StoryRowUI:Initialize(line, mgr) end

---@class Witch.TaskItem : Witch.UI.Window.ItemNonDrag
---@field taskUI Witch.TaskUI
Witch.TaskItem = {}
---@alias CS.Witch.TaskItem Witch.TaskItem
CS.Witch.TaskItem = Witch.TaskItem

---@param dataConfig DataConfig
function Witch.TaskItem:Init(dataConfig) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.TaskItem:OnPointerClick(eventData) end
function Witch.TaskItem:DataUpdate() end

---@class Witch.TaskUI : Witch.UI.UIBase
---@field firstShow boolean
Witch.TaskUI = {}
---@alias CS.Witch.TaskUI Witch.TaskUI
CS.Witch.TaskUI = Witch.TaskUI

function Witch.TaskUI:OnEnable() end
function Witch.TaskUI:Init() end
function Witch.TaskUI:DataUpdate() end
---@param dataConfig DataConfig
function Witch.TaskUI:ShowTaskDetail(dataConfig) end
function Witch.TaskUI:ClaimReward() end

---@class Witch.TypeItem : UnityEngine.MonoBehaviour
---@field IsOpen boolean
---@field TypeName string
Witch.TypeItem = {}
---@alias CS.Witch.TypeItem Witch.TypeItem
CS.Witch.TypeItem = Witch.TypeItem

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.TypeItem:OnPointerClick(eventData) end

---@class Witch.Mod.IModifiable
Witch.Mod.IModifiable = {}
---@alias CS.Witch.Mod.IModifiable Witch.Mod.IModifiable
CS.Witch.Mod.IModifiable = Witch.Mod.IModifiable


---@class Witch.Mod.LuaModHookAdapter : System.Object
Witch.Mod.LuaModHookAdapter = {}
---@alias CS.Witch.Mod.LuaModHookAdapter Witch.Mod.LuaModHookAdapter
CS.Witch.Mod.LuaModHookAdapter = Witch.Mod.LuaModHookAdapter

---@param fn XLua.LuaFunction
---@return System.Action | function
function Witch.Mod.LuaModHookAdapter.ToBeforeAction(fn) end
---@param fn XLua.LuaFunction
---@return System.Action | function
function Witch.Mod.LuaModHookAdapter.ToAfterAction(fn) end

---@class Witch.UI.ConsoleUI : Witch.UI.UIBase
---@field Instance Witch.UI.ConsoleUI
Witch.UI.ConsoleUI = {}
---@alias CS.Witch.UI.ConsoleUI Witch.UI.ConsoleUI
CS.Witch.UI.ConsoleUI = Witch.UI.ConsoleUI

function Witch.UI.ConsoleUI:OnEnable() end
function Witch.UI.ConsoleUI:OnDisable() end
---@param outputer string
---@param output string
function Witch.UI.ConsoleUI:Output(outputer, output) end

---@class Witch.UI.UIManager : UnityEngine.MonoBehaviour
---@field Instance Witch.UI.UIManager
---@field canvasTf UnityEngine.Transform
---@field upperCanvasTf UnityEngine.Transform
---@field effectContent UnityEngine.Transform
---@field WindowObj UnityEngine.GameObject
Witch.UI.UIManager = {}
---@alias CS.Witch.UI.UIManager Witch.UI.UIManager
CS.Witch.UI.UIManager = Witch.UI.UIManager

function Witch.UI.UIManager:Awake() end
---@param uiName string
function Witch.UI.UIManager:HideUI(uiName) end
function Witch.UI.UIManager:CloseAllUI() end
---@param uiName string
function Witch.UI.UIManager:CloseUI(uiName) end
---@param uiName string
---@return Witch.UI.UIBase
function Witch.UI.UIManager:Find(uiName) end
---@param uiName string
function Witch.UI.UIManager:RemoveUI(uiName) end
---@return System.Collections.Generic.IEnumerable
function Witch.UI.UIManager:GetAllUI() end
---@param button Witch.UI.ExitButton
function Witch.UI.UIManager:RegisterExitButton(button) end
---@param button Witch.UI.ExitButton
function Witch.UI.UIManager:UnregisterExitButton(button) end
---@return System.Collections.Generic.List
function Witch.UI.UIManager:GetAllExitButtons() end
---@return UnityEngine.GameObject
function Witch.UI.UIManager:CreateActionIcon() end
---@return UnityEngine.GameObject
function Witch.UI.UIManager:CreateActionContent() end
---@return UnityEngine.GameObject
function Witch.UI.UIManager:CreateEffectList() end
---@return UnityEngine.GameObject
function Witch.UI.UIManager:CreateHPItem() end
---@return UnityEngine.GameObject
function Witch.UI.UIManager:CreateBuffBarItem() end
---@return UnityEngine.GameObject
function Witch.UI.UIManager:CreateStatusBarItem() end
---@return DialogueBox
function Witch.UI.UIManager:CreateDialogueBox() end
function Witch.UI.UIManager:CheckUI() end
---@param msg string
---@param callback System.Action | function
function Witch.UI.UIManager:ShowTip(msg, callback) end
function Witch.UI.UIManager:PopUpTextInit() end
---@param TextType string
---@param val string
---@param pos UnityEngine.Vector2
---@return Cysharp.Threading.Tasks.UniTask
function Witch.UI.UIManager:ShowPopUpText(TextType, val, pos) end
---@param TextType string
---@param baseDamage string
---@param status StatusManager
---@param pos UnityEngine.Vector2
---@param realDamage string
---@return Cysharp.Threading.Tasks.UniTask
function Witch.UI.UIManager:ShowPopUpDamage(TextType, baseDamage, status, pos, realDamage) end
---@param id string
function Witch.UI.UIManager:ShowEventUI(id) end
---@param action System.Action | function
function Witch.UI.UIManager:DoWithTurn(action) end
---@param title string
---@param text string
---@param onConfirm UnityEngine.Events.UnityAction
---@param typeSpeed number
---@param onCancel UnityEngine.Events.UnityAction
---@param hasConfirm boolean
---@param hasCancel boolean
---@param confirmText string
---@param cancelText string
---@param mustChoose boolean
---@return Michsky.MUIP.ModalWindowManager
function Witch.UI.UIManager:ShowModalWindow(title, text, onConfirm, typeSpeed, onCancel, hasConfirm, hasCancel, confirmText, cancelText, mustChoose) end
---@param title string
---@param text string
---@param cancelCondition System.Func
---@return Cysharp.Threading.Tasks.UniTask
function Witch.UI.UIManager:ShowWaitingUI(title, text, cancelCondition) end
---@param icon UnityEngine.Sprite
---@param title string
---@param description string
---@param tips string
function Witch.UI.UIManager:ShowItemShowUI(icon, title, description, tips) end
---@return Tooltip
function Witch.UI.UIManager:GetTooltip() end
---@return Michsky.MUIP.ProgressBar
function Witch.UI.UIManager:GetProgressBar() end
---@param Title string
---@param Description string
---@param delay number
function Witch.UI.UIManager:ShowNotification(Title, Description, delay) end
function Witch.UI.UIManager:EndNotification() end
function Witch.UI.UIManager:HideFloatingWindow() end
---@return FloatingWindow
function Witch.UI.UIManager:GetFloatingWindow() end
---@return AnimationManager
function Witch.UI.UIManager:GetAnimationManage() end

---@class Witch.UI.ButtonSound : UnityEngine.MonoBehaviour
---@field metal boolean
---@field useDownSound boolean
Witch.UI.ButtonSound = {}
---@alias CS.Witch.UI.ButtonSound Witch.UI.ButtonSound
CS.Witch.UI.ButtonSound = Witch.UI.ButtonSound

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.ButtonSound:OnPointerDown(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.ButtonSound:OnPointerEnter(eventData) end

---@class Witch.UI.ExitButton : UnityEngine.MonoBehaviour
Witch.UI.ExitButton = {}
---@alias CS.Witch.UI.ExitButton Witch.UI.ExitButton
CS.Witch.UI.ExitButton = Witch.UI.ExitButton

---@return boolean
function Witch.UI.ExitButton:OnCancelKey() end

---@class Witch.UI.KeywordDisplay : UnityEngine.MonoBehaviour
---@field keyWords System.Collections.Generic.List
---@field text string
---@field title string
---@field msg string
---@field icon UnityEngine.Sprite
---@field type string
---@field isHover boolean
Witch.UI.KeywordDisplay = {}
---@alias CS.Witch.UI.KeywordDisplay Witch.UI.KeywordDisplay
CS.Witch.UI.KeywordDisplay = Witch.UI.KeywordDisplay

---@param title string
---@param text string
---@param keyWords System.Collections.Generic.List
---@param msg string
---@param icon UnityEngine.Sprite
---@param type string
function Witch.UI.KeywordDisplay:SetText(title, text, keyWords, msg, icon, type) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.KeywordDisplay:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.KeywordDisplay:OnPointerExit(eventData) end
function Witch.UI.KeywordDisplay:OnDestroy() end
---@param localiedTitle System.Func
---@param localizedContent System.Func
---@param keywords System.Collections.Generic.List
function Witch.UI.KeywordDisplay:SetLocalizedText(localiedTitle, localizedContent, keywords) end

---@class Witch.UI.UIBase : UnityEngine.MonoBehaviour
---@field animationType Witch.UI.UIBase.AnimationType
---@field fadeInAnim UnityEngine.AnimationClip
---@field fadeOutAnim UnityEngine.AnimationClip
---@field IsUpperUI boolean
---@field isScene boolean
---@field NeedVideo boolean
---@field videoPlayer UnityEngine.Video.VideoPlayer
---@field backgroundRawImage UnityEngine.UI.RawImage
---@field videoPlayer2 UnityEngine.Video.VideoPlayer
Witch.UI.UIBase = {}
---@alias CS.Witch.UI.UIBase Witch.UI.UIBase
CS.Witch.UI.UIBase = Witch.UI.UIBase

function Witch.UI.UIBase:Show() end
function Witch.UI.UIBase:CheckVideo() end
function Witch.UI.UIBase:UpperBlock() end
function Witch.UI.UIBase:CancelUpperBlock() end
function Witch.UI.UIBase:FadeIn() end
---@param callback System.Action | function
function Witch.UI.UIBase:FadeOut(callback) end
function Witch.UI.UIBase:Hide() end
function Witch.UI.UIBase:Close() end
---@param callback System.Action | function
function Witch.UI.UIBase:CloseWithCallback(callback) end
function Witch.UI.UIBase:OnEnable() end
function Witch.UI.UIBase:Help() end
function Witch.UI.UIBase:DataUpdate() end
function Witch.UI.UIBase:RegisterEvent() end
function Witch.UI.UIBase:ClearEvent() end
function Witch.UI.UIBase:OnDisable() end
function Witch.UI.UIBase:OnDestroy() end

---@class Witch.UI.UIBase.AnimationType
---@field Fade Witch.UI.UIBase.AnimationType
---@field None Witch.UI.UIBase.AnimationType
---@field WaitCurtain Witch.UI.UIBase.AnimationType
---@field Custom Witch.UI.UIBase.AnimationType
Witch.UI.UIBase.AnimationType = {}
---@alias CS.Witch.UI.UIBase.AnimationType Witch.UI.UIBase.AnimationType
CS.Witch.UI.UIBase.AnimationType = Witch.UI.UIBase.AnimationType


---@class Witch.UI.UIEventTrigger : UnityEngine.MonoBehaviour
---@field onClick System.Action | function
---@field EnterPoint System.Action | function
---@field ExitPoint System.Action | function
Witch.UI.UIEventTrigger = {}
---@alias CS.Witch.UI.UIEventTrigger Witch.UI.UIEventTrigger
CS.Witch.UI.UIEventTrigger = Witch.UI.UIEventTrigger

---@param obj UnityEngine.GameObject
---@return Witch.UI.UIEventTrigger
function Witch.UI.UIEventTrigger.Get(obj) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.UIEventTrigger:OnPointerClick(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.UIEventTrigger:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.UIEventTrigger:OnPointerExit(eventData) end

---@class Witch.UI.UpperCanvasController : UnityEngine.MonoBehaviour
Witch.UI.UpperCanvasController = {}
---@alias CS.Witch.UI.UpperCanvasController Witch.UI.UpperCanvasController
CS.Witch.UI.UpperCanvasController = Witch.UI.UpperCanvasController


---@class Witch.UI.UpperCanvasController.ChildMonitor : UnityEngine.MonoBehaviour
Witch.UI.UpperCanvasController.ChildMonitor = {}
---@alias CS.Witch.UI.UpperCanvasController.ChildMonitor Witch.UI.UpperCanvasController.ChildMonitor
CS.Witch.UI.UpperCanvasController.ChildMonitor = Witch.UI.UpperCanvasController.ChildMonitor

---@param controller Witch.UI.UpperCanvasController
function Witch.UI.UpperCanvasController.ChildMonitor:Init(controller) end

---@class Witch.UI.SceneType
---@field Road Witch.UI.SceneType
---@field Castle Witch.UI.SceneType
---@field PuppetTheater Witch.UI.SceneType
---@field Forest Witch.UI.SceneType
---@field Chessboard Witch.UI.SceneType
---@field Courtyard Witch.UI.SceneType
Witch.UI.SceneType = {}
---@alias CS.Witch.UI.SceneType Witch.UI.SceneType
CS.Witch.UI.SceneType = Witch.UI.SceneType


---@class Witch.UI.Component.TMPNumberToSprite : System.Object
Witch.UI.Component.TMPNumberToSprite = {}
---@alias CS.Witch.UI.Component.TMPNumberToSprite Witch.UI.Component.TMPNumberToSprite
CS.Witch.UI.Component.TMPNumberToSprite = Witch.UI.Component.TMPNumberToSprite

---@param tmp TMPro.TMP_Text
---@param text string
function Witch.UI.Component.TMPNumberToSprite.SetDigitText(tmp, text) end

---@class Witch.UI.Window.DisplayCard : CardItem
---@field CurrentScale number
---@field NormalScale number
---@field isSelect boolean
---@field onClick UnityEngine.Events.UnityEvent
Witch.UI.Window.DisplayCard = {}
---@alias CS.Witch.UI.Window.DisplayCard Witch.UI.Window.DisplayCard
CS.Witch.UI.Window.DisplayCard = Witch.UI.Window.DisplayCard

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DisplayCard:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DisplayCard:OnEndDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DisplayCard:OnDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DisplayCard:OnPointerEnter(eventData) end
---@param dataConfig DataConfig
function Witch.UI.Window.DisplayCard:Init(dataConfig) end
function Witch.UI.Window.DisplayCard:DataUpdate() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DisplayCard:OnPointerExit(eventData) end
function Witch.UI.Window.DisplayCard:OnHover() end
function Witch.UI.Window.DisplayCard:OnExit() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DisplayCard:OnPointerClick(eventData) end
function Witch.UI.Window.DisplayCard:OnSelect() end
function Witch.UI.Window.DisplayCard:OnUnSelect() end

---@class Witch.UI.Window.BattleRewardsUI : Witch.UI.UIBase
---@field itemList UnityEngine.Transform
---@field RelicRewardList System.Collections.Generic.List
---@field cardIcon UnityEngine.Sprite
---@field moneyIcon UnityEngine.Sprite
---@field blessIcon UnityEngine.Sprite
---@field relicIcon UnityEngine.Sprite
---@field CardCount number
---@field item1 UnityEngine.GameObject
Witch.UI.Window.BattleRewardsUI = {}
---@alias CS.Witch.UI.Window.BattleRewardsUI Witch.UI.Window.BattleRewardsUI
CS.Witch.UI.Window.BattleRewardsUI = Witch.UI.Window.BattleRewardsUI

function Witch.UI.Window.BattleRewardsUI:DataUpdate() end
function Witch.UI.Window.BattleRewardsUI:ModeSetReward() end
---@param count number
function Witch.UI.Window.BattleRewardsUI:SetMoney(count) end
function Witch.UI.Window.BattleRewardsUI:OnDestroy() end
---@param lists System.Collections.Generic.List
function Witch.UI.Window.BattleRewardsUI:RandomSetRelic(lists) end
function Witch.UI.Window.BattleRewardsUI:RandomSetCard() end
function Witch.UI.Window.BattleRewardsUI:RandomAddBless() end
function Witch.UI.Window.BattleRewardsUI:GenerBlessing() end
---@param obj UnityEngine.GameObject
function Witch.UI.Window.BattleRewardsUI:AnimationPlay(obj) end

---@class Witch.UI.Window.AchievementUI : Witch.UI.UIBase
---@field levelColor System.Collections.Generic.Dictionary
---@field statusMap System.Collections.Generic.Dictionary
Witch.UI.Window.AchievementUI = {}
---@alias CS.Witch.UI.Window.AchievementUI Witch.UI.Window.AchievementUI
CS.Witch.UI.Window.AchievementUI = Witch.UI.Window.AchievementUI

function Witch.UI.Window.AchievementUI:Close() end
---@param type string
function Witch.UI.Window.AchievementUI:SelectWindow(type) end
---@param type string
function Witch.UI.Window.AchievementUI:UpdateCount(type) end

---@class Witch.UI.Window.AcknowledgmentsUI : Witch.UI.UIBase
Witch.UI.Window.AcknowledgmentsUI = {}
---@alias CS.Witch.UI.Window.AcknowledgmentsUI Witch.UI.Window.AcknowledgmentsUI
CS.Witch.UI.Window.AcknowledgmentsUI = Witch.UI.Window.AcknowledgmentsUI


---@class Witch.UI.Window.AffectionUI : Witch.UI.UIBase
---@field firstShow boolean
Witch.UI.Window.AffectionUI = {}
---@alias CS.Witch.UI.Window.AffectionUI Witch.UI.Window.AffectionUI
CS.Witch.UI.Window.AffectionUI = Witch.UI.Window.AffectionUI

function Witch.UI.Window.AffectionUI:OnEnable() end
---@param dataConfig DataConfig
function Witch.UI.Window.AffectionUI:AddReward(dataConfig) end
function Witch.UI.Window.AffectionUI:ShowNowLevel() end

---@class Witch.UI.Window.AnnouncementUI : Witch.UI.Window.TutorialUI
Witch.UI.Window.AnnouncementUI = {}
---@alias CS.Witch.UI.Window.AnnouncementUI Witch.UI.Window.AnnouncementUI
CS.Witch.UI.Window.AnnouncementUI = Witch.UI.Window.AnnouncementUI

function Witch.UI.Window.AnnouncementUI:ShowAnnouncement() end

---@class Witch.UI.Window.BackpackUI : Witch.UI.UIBase
---@field statusUI Witch.UI.Window.StatusUI
Witch.UI.Window.BackpackUI = {}
---@alias CS.Witch.UI.Window.BackpackUI Witch.UI.Window.BackpackUI
CS.Witch.UI.Window.BackpackUI = Witch.UI.Window.BackpackUI

---@param statusUIData Witch.UI.Window.StatusUIData
function Witch.UI.Window.BackpackUI:ShowStatus(statusUIData) end
function Witch.UI.Window.BackpackUI:DataUpdate() end
function Witch.UI.Window.BackpackUI:Init() end
function Witch.UI.Window.BackpackUI:OnEnable() end
function Witch.UI.Window.BackpackUI:Close() end

---@class Witch.UI.Window.OutDeckUIData : System.ValueType
---@field Id string
---@field cardList System.Collections.Generic.ICollection
---@field UnCardList System.Collections.Generic.ICollection
---@field CardBottomCount number
---@field CardTopCount number
---@field MaxAlCardCount number
Witch.UI.Window.OutDeckUIData = {}
---@alias CS.Witch.UI.Window.OutDeckUIData Witch.UI.Window.OutDeckUIData
CS.Witch.UI.Window.OutDeckUIData = Witch.UI.Window.OutDeckUIData

---@param roleTable RoleTable
---@return Witch.UI.Window.OutDeckUIData
function Witch.UI.Window.OutDeckUIData.New(roleTable) end

---@class Witch.UI.Window.OutDeckUI : Witch.UI.UIBase
---@field OutDeckUIData Witch.UI.Window.OutDeckUIData
---@field equipCardTransform UnityEngine.Transform
---@field unequipCardTransform UnityEngine.Transform
---@field shouldButton UnityEngine.GameObject
Witch.UI.Window.OutDeckUI = {}
---@alias CS.Witch.UI.Window.OutDeckUI Witch.UI.Window.OutDeckUI
CS.Witch.UI.Window.OutDeckUI = Witch.UI.Window.OutDeckUI

function Witch.UI.Window.OutDeckUI:OnEnable() end
---@param data Witch.UI.Window.OutDeckUIData
function Witch.UI.Window.OutDeckUI:SetRole(data) end
function Witch.UI.Window.OutDeckUI:DataUpdate() end
function Witch.UI.Window.OutDeckUI:ShowMsg() end
function Witch.UI.Window.OutDeckUI:ChangeCardShow() end
---@param cardData DataConfig
---@param ifequipped boolean
function Witch.UI.Window.OutDeckUI:CreateItem(cardData, ifequipped) end

---@class Witch.UI.Window.RelicSelectUI : Witch.UI.UIBase
---@field List2 UnityEngine.Transform
---@field UnArmeditem UnityEngine.GameObject
---@field relicList System.Collections.Generic.List
---@field List1 UnityEngine.Transform
---@field roleTable RoleTable
Witch.UI.Window.RelicSelectUI = {}
---@alias CS.Witch.UI.Window.RelicSelectUI Witch.UI.Window.RelicSelectUI
CS.Witch.UI.Window.RelicSelectUI = Witch.UI.Window.RelicSelectUI

function Witch.UI.Window.RelicSelectUI:Init() end
function Witch.UI.Window.RelicSelectUI:OnEnable() end

---@class Witch.UI.Window.StatusUIData : System.ValueType
---@field instanceId string
---@field VarsMap System.Collections.Generic.Dictionary
---@field blessingConfigs System.Collections.Generic.List
---@field career DataConfig
---@field San number
---@field MaxSan number
---@field Money number
---@field ChooseVars System.Collections.Generic.List
Witch.UI.Window.StatusUIData = {}
---@alias CS.Witch.UI.Window.StatusUIData Witch.UI.Window.StatusUIData
CS.Witch.UI.Window.StatusUIData = Witch.UI.Window.StatusUIData

---@param roleTable RoleTable
---@return Witch.UI.Window.StatusUIData
function Witch.UI.Window.StatusUIData.New(roleTable) end

---@class Witch.UI.Window.StatusUI : UnityEngine.MonoBehaviour
---@field statusUIData Witch.UI.Window.StatusUIData
Witch.UI.Window.StatusUI = {}
---@alias CS.Witch.UI.Window.StatusUI Witch.UI.Window.StatusUI
CS.Witch.UI.Window.StatusUI = Witch.UI.Window.StatusUI

---@param backpackUI Witch.UI.Window.BackpackUI
function Witch.UI.Window.StatusUI:Init(backpackUI) end
function Witch.UI.Window.StatusUI:DataUpdate() end
---@param statusUIData Witch.UI.Window.StatusUIData
function Witch.UI.Window.StatusUI:ShowMsg(statusUIData) end
function Witch.UI.Window.StatusUI:ShowSan() end
function Witch.UI.Window.StatusUI:ShowMoney() end
function Witch.UI.Window.StatusUI:ShowVar() end
function Witch.UI.Window.StatusUI:ShowBuff() end
function Witch.UI.Window.StatusUI:ReleaseBuff() end
function Witch.UI.Window.StatusUI:ShowBless() end
function Witch.UI.Window.StatusUI:ShowRoleMsg() end
---@return System.Collections.Generic.List
function Witch.UI.Window.StatusUI:GenerateThreeOptions() end
---@param blessings System.Collections.Generic.List
function Witch.UI.Window.StatusUI:RewardGenerator(blessings) end
---@return System.Collections.Generic.List
function Witch.UI.Window.StatusUI:GenerateHighOptions() end

---@class Witch.UI.Window.BuffShowItem : Witch.UI.Window.ItemNonDrag
Witch.UI.Window.BuffShowItem = {}
---@alias CS.Witch.UI.Window.BuffShowItem Witch.UI.Window.BuffShowItem
CS.Witch.UI.Window.BuffShowItem = Witch.UI.Window.BuffShowItem

---@param dataConfig DataConfig
function Witch.UI.Window.BuffShowItem:Init(dataConfig) end

---@class Witch.UI.Window.CareerData : System.ValueType
---@field instanceId string
---@field career DataConfig
---@field San number
---@field MaxSan number
Witch.UI.Window.CareerData = {}
---@alias CS.Witch.UI.Window.CareerData Witch.UI.Window.CareerData
CS.Witch.UI.Window.CareerData = Witch.UI.Window.CareerData

---@param roleTable RoleTable
---@return Witch.UI.Window.CareerData
function Witch.UI.Window.CareerData.New(roleTable) end

---@class Witch.UI.Window.TopBarUI : Witch.UI.UIBase
---@field RelicList UnityEngine.Transform
---@field varList UnityEngine.Transform
---@field relicSelectUI Witch.UI.Window.RelicSelectUI
---@field ConnectMode boolean
---@field statusPrefab UnityEngine.GameObject
---@field mainStatus UnityEngine.GameObject
---@field IdToStatusItem System.Collections.Generic.Dictionary
---@field roleTable RoleTable
Witch.UI.Window.TopBarUI = {}
---@alias CS.Witch.UI.Window.TopBarUI Witch.UI.Window.TopBarUI
CS.Witch.UI.Window.TopBarUI = Witch.UI.Window.TopBarUI

---@param players System.Collections.Generic.List
function Witch.UI.Window.TopBarUI:CreateConnectPlayerStatus(players) end
function Witch.UI.Window.TopBarUI:ChangeCareerAvator() end
function Witch.UI.Window.TopBarUI:OnDestroy() end
function Witch.UI.Window.TopBarUI:FadeIn() end
function Witch.UI.Window.TopBarUI:FightHide() end
function Witch.UI.Window.TopBarUI:HideLeftUp() end
function Witch.UI.Window.TopBarUI:ShowLeftUp() end
---@param sender System.Object
---@param args System.ComponentModel.PropertyChangedEventArgs
function Witch.UI.Window.TopBarUI:OnGameRuntimeDataChanged(sender, args) end
---@param sender System.Object
---@param args System.ComponentModel.PropertyChangedEventArgs
function Witch.UI.Window.TopBarUI:OnRoleTableChanged(sender, args) end
function Witch.UI.Window.TopBarUI:ChangeVar() end
function Witch.UI.Window.TopBarUI:ShowSetting() end
function Witch.UI.Window.TopBarUI:ShowDict() end
---@param value string
---@param fromId string
---@param type string
function Witch.UI.Window.TopBarUI:OtherChangeShow(value, fromId, type) end
function Witch.UI.Window.TopBarUI:TryReturn() end
function Witch.UI.Window.TopBarUI:ReturnToMenu() end
function Witch.UI.Window.TopBarUI:OpenBackpack() end
function Witch.UI.Window.TopBarUI:ChangeCareer() end
---@param roleid string
function Witch.UI.Window.TopBarUI:ChangeSan(roleid) end
---@param Defend string
function Witch.UI.Window.TopBarUI:UpdateDefend(Defend) end
function Witch.UI.Window.TopBarUI:HideDefend() end
function Witch.UI.Window.TopBarUI:ChangeMoney() end
function Witch.UI.Window.TopBarUI:ChangeTrue() end
function Witch.UI.Window.TopBarUI:UpdateRelics() end
function Witch.UI.Window.TopBarUI:SetRelicGlowEvent() end
function Witch.UI.Window.TopBarUI:UpdateRelicCountShow() end
function Witch.UI.Window.TopBarUI:ListenVars() end

---@class Witch.UI.Window.CardChoiceUI : Witch.UI.UIBase
Witch.UI.Window.CardChoiceUI = {}
---@alias CS.Witch.UI.Window.CardChoiceUI Witch.UI.Window.CardChoiceUI
CS.Witch.UI.Window.CardChoiceUI = Witch.UI.Window.CardChoiceUI

---@param obj UnityEngine.GameObject
---@param dataConfig DataConfig
function Witch.UI.Window.CardChoiceUI:Select(obj, dataConfig) end
function Witch.UI.Window.CardChoiceUI:Close() end

---@class Witch.UI.Window.BreaksUI : UnityEngine.MonoBehaviour
---@field startTime number
---@field foodList System.Collections.Generic.List
Witch.UI.Window.BreaksUI = {}
---@alias CS.Witch.UI.Window.BreaksUI Witch.UI.Window.BreaksUI
CS.Witch.UI.Window.BreaksUI = Witch.UI.Window.BreaksUI

---@param roleList System.ValueTuple
function Witch.UI.Window.BreaksUI:CreateRole(roleList) end
function Witch.UI.Window.BreaksUI:Close() end
function Witch.UI.Window.BreaksUI:ShowWarehouse() end
function Witch.UI.Window.BreaksUI:RelicBackPoint() end
function Witch.UI.Window.BreaksUI:ReturnHome() end
function Witch.UI.Window.BreaksUI:CreateFood() end
---@param foods System.Collections.Generic.List
function Witch.UI.Window.BreaksUI:CreateFoodItem(foods) end

---@class Witch.UI.Window.CaptionStyle
---@field Bottom Witch.UI.Window.CaptionStyle
---@field Top Witch.UI.Window.CaptionStyle
---@field Center Witch.UI.Window.CaptionStyle
Witch.UI.Window.CaptionStyle = {}
---@alias CS.Witch.UI.Window.CaptionStyle Witch.UI.Window.CaptionStyle
CS.Witch.UI.Window.CaptionStyle = Witch.UI.Window.CaptionStyle


---@class Witch.UI.Window.CaptionUI : Witch.UI.UIBase
Witch.UI.Window.CaptionUI = {}
---@alias CS.Witch.UI.Window.CaptionUI Witch.UI.Window.CaptionUI
CS.Witch.UI.Window.CaptionUI = Witch.UI.Window.CaptionUI

---@param text string
---@param style Witch.UI.Window.CaptionStyle
---@param animationTime number
---@param delay number
---@param animatonType number
function Witch.UI.Window.CaptionUI:ShowCaption(text, style, animationTime, delay, animatonType) end

---@class Witch.UI.Window.CardEditorUI : Witch.UI.UIBase
---@field IndexSprite System.Collections.Generic.Dictionary
---@field MethodCount System.Collections.Generic.Dictionary
---@field onEdited System.Action | function
---@field onepageCount number
---@field thisRatity number
---@field collection System.Collections.Generic.List
---@field itemPrefab1 UnityEngine.GameObject
---@field buttons System.Collections.Generic.List
---@field rarity string
---@field cost number
---@field total number
Witch.UI.Window.CardEditorUI = {}
---@alias CS.Witch.UI.Window.CardEditorUI Witch.UI.Window.CardEditorUI
CS.Witch.UI.Window.CardEditorUI = Witch.UI.Window.CardEditorUI

function Witch.UI.Window.CardEditorUI:UpdateTotal() end
function Witch.UI.Window.CardEditorUI:UpdateSprite() end
function Witch.UI.Window.CardEditorUI:OnEnable() end
function Witch.UI.Window.CardEditorUI:UpdateBuff() end
function Witch.UI.Window.CardEditorUI:InitTime() end
function Witch.UI.Window.CardEditorUI:InitTimeAgain() end
---@param InitTime string
function Witch.UI.Window.CardEditorUI:CreateTimeItem(InitTime) end
function Witch.UI.Window.CardEditorUI:OnDestroy() end

---@class Witch.UI.Window.ChangeFloatWindow : UnityEngine.MonoBehaviour
Witch.UI.Window.ChangeFloatWindow = {}
---@alias CS.Witch.UI.Window.ChangeFloatWindow Witch.UI.Window.ChangeFloatWindow
CS.Witch.UI.Window.ChangeFloatWindow = Witch.UI.Window.ChangeFloatWindow

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ChangeFloatWindow:OnPointerClick(eventData) end

---@class Witch.UI.Window.CardEffectBuff : UnityEngine.MonoBehaviour
---@field NowItem Witch.UI.Window.CardEffectItem
---@field data System.Collections.Generic.Dictionary
---@field buffdata DataEditor.CardEditor.BuffData
Witch.UI.Window.CardEffectBuff = {}
---@alias CS.Witch.UI.Window.CardEffectBuff Witch.UI.Window.CardEffectBuff
CS.Witch.UI.Window.CardEffectBuff = Witch.UI.Window.CardEffectBuff

function Witch.UI.Window.CardEffectBuff:SetData() end

---@class Witch.UI.Window.CardEffectItem : UnityEngine.MonoBehaviour
---@field effectName string
---@field effectDes string
---@field isBuff boolean
---@field followEffectName string
---@field sourceName string
---@field methodName string
---@field effectCost number
---@field costMultiplier number
---@field cardEditorUI Witch.UI.Window.CardEditorUI
---@field vars System.Collections.Generic.Dictionary
---@field desValIndex number
---@field isMarkedForDestruction boolean
Witch.UI.Window.CardEffectItem = {}
---@alias CS.Witch.UI.Window.CardEffectItem Witch.UI.Window.CardEffectItem
CS.Witch.UI.Window.CardEffectItem = Witch.UI.Window.CardEffectItem

function Witch.UI.Window.CardEffectItem:IsBuff() end
function Witch.UI.Window.CardEffectItem:CalculateCost() end
function Witch.UI.Window.CardEffectItem:CreateDescription() end
function Witch.UI.Window.CardEffectItem:CreateTimeDes() end
---@return System.ValueTuple
function Witch.UI.Window.CardEffectItem:RunMethod() end
function Witch.UI.Window.CardEffectItem:UpdateAll() end
function Witch.UI.Window.CardEffectItem:ShowChangeBuff() end
function Witch.UI.Window.CardEffectItem:HideBuffList() end
---@param buffName string
function Witch.UI.Window.CardEffectItem:ChangeBuff(buffName) end

---@class Witch.UI.Window.CareerChoiceUI : Witch.UI.UIBase
---@field career DataConfig
---@field Partner DataConfig
---@field houseUI Witch.UI.Window.HouseUI
---@field choiceWay string
Witch.UI.Window.CareerChoiceUI = {}
---@alias CS.Witch.UI.Window.CareerChoiceUI Witch.UI.Window.CareerChoiceUI
CS.Witch.UI.Window.CareerChoiceUI = Witch.UI.Window.CareerChoiceUI

---@param way string
function Witch.UI.Window.CareerChoiceUI:Init(way) end
function Witch.UI.Window.CareerChoiceUI:ChangeShow() end
function Witch.UI.Window.CareerChoiceUI:UpdateCareer() end
function Witch.UI.Window.CareerChoiceUI:ShowCareer() end
function Witch.UI.Window.CareerChoiceUI:Hide() end
function Witch.UI.Window.CareerChoiceUI:OnDisable() end
function Witch.UI.Window.CareerChoiceUI:CancelCareer() end
---@param career Witch.UI.Window.ShowCareer
function Witch.UI.Window.CareerChoiceUI:ShowDetail(career) end

---@class Witch.UI.Window.ShowCareer : Witch.UI.Window.ItemNonDrag
---@field isSelected boolean
---@field belong string
---@field gameEntryUI Witch.UI.Window.GameEntryUI
Witch.UI.Window.ShowCareer = {}
---@alias CS.Witch.UI.Window.ShowCareer Witch.UI.Window.ShowCareer
CS.Witch.UI.Window.ShowCareer = Witch.UI.Window.ShowCareer

---@param dataConfig DataConfig
function Witch.UI.Window.ShowCareer:Init(dataConfig) end
function Witch.UI.Window.ShowCareer:DataUpdate() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowCareer:OnPointerClick(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowCareer:OnPointerEnter(eventData) end

---@class Witch.UI.Window.ChatUI : Witch.UI.UIBase
---@field Instance Witch.UI.Window.ChatUI
---@field isOpen boolean
Witch.UI.Window.ChatUI = {}
---@alias CS.Witch.UI.Window.ChatUI Witch.UI.Window.ChatUI
CS.Witch.UI.Window.ChatUI = Witch.UI.Window.ChatUI

---@param text string
function Witch.UI.Window.ChatUI:SendChatMessage(text) end
---@param text string
function Witch.UI.Window.ChatUI:AddMessage(text) end

---@class Witch.UI.Window.DeckUI : Witch.UI.UIBase
Witch.UI.Window.DeckUI = {}
---@alias CS.Witch.UI.Window.DeckUI Witch.UI.Window.DeckUI
CS.Witch.UI.Window.DeckUI = Witch.UI.Window.DeckUI

function Witch.UI.Window.DeckUI:OnEnable() end
function Witch.UI.Window.DeckUI:CreateDeckMenu() end
function Witch.UI.Window.DeckUI:CreateUsedDeckMenu() end
---@param count number
---@param DataConfigList System.Collections.Generic.List
---@param SourceList System.Collections.Generic.List
function Witch.UI.Window.DeckUI:CreateDeckMenuForSelect(count, DataConfigList, SourceList) end

---@class Witch.UI.Window.DesItem : Witch.UI.Window.ItemNonDrag
---@field Claimed boolean
Witch.UI.Window.DesItem = {}
---@alias CS.Witch.UI.Window.DesItem Witch.UI.Window.DesItem
CS.Witch.UI.Window.DesItem = Witch.UI.Window.DesItem

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DesItem:OnPointerClick(eventData) end

---@class Witch.UI.Window.DestinyTreeUI : Witch.UI.Window.ShopUI
---@field InitCost number
---@field Cost number
Witch.UI.Window.DestinyTreeUI = {}
---@alias CS.Witch.UI.Window.DestinyTreeUI Witch.UI.Window.DestinyTreeUI
CS.Witch.UI.Window.DestinyTreeUI = Witch.UI.Window.DestinyTreeUI

function Witch.UI.Window.DestinyTreeUI:DataUpdate() end
function Witch.UI.Window.DestinyTreeUI:Divination() end
function Witch.UI.Window.DestinyTreeUI:GenerateBless() end
function Witch.UI.Window.DestinyTreeUI:SetShopItems() end

---@class Witch.UI.Window.DialogueUI : Witch.UI.UIBase
---@field waitTime number
Witch.UI.Window.DialogueUI = {}
---@alias CS.Witch.UI.Window.DialogueUI Witch.UI.Window.DialogueUI
CS.Witch.UI.Window.DialogueUI = Witch.UI.Window.DialogueUI

function Witch.UI.Window.DialogueUI:Awake() end
---@param dataConfig DataConfig
function Witch.UI.Window.DialogueUI:ShowDialogue(dataConfig) end
function Witch.UI.Window.DialogueUI:ShowChoice() end
---@param thisData DataConfig
---@return string
function Witch.UI.Window.DialogueUI:GetText(thisData) end
function Witch.UI.Window.DialogueUI:EndDialogue() end
---@return System.Collections.IEnumerator
function Witch.UI.Window.DialogueUI:StartDia() end
---@return System.Collections.IEnumerator
function Witch.UI.Window.DialogueUI:Skip() end
function Witch.UI.Window.DialogueUI:ShowHistory() end
function Witch.UI.Window.DialogueUI:OnDestroy() end

---@class Witch.UI.Window.OptionsUI : Witch.UI.UIBase
Witch.UI.Window.OptionsUI = {}
---@alias CS.Witch.UI.Window.OptionsUI Witch.UI.Window.OptionsUI
CS.Witch.UI.Window.OptionsUI = Witch.UI.Window.OptionsUI

function Witch.UI.Window.OptionsUI:FadeIn() end
---@param text string
---@param action System.Action | function
function Witch.UI.Window.OptionsUI:AddOption(text, action) end
function Witch.UI.Window.OptionsUI:Close() end

---@class Witch.UI.Window.ButtonUse : UnityEngine.MonoBehaviour
---@field dictionaryUI Witch.UI.Window.DictionaryUI
---@field ItemType string
---@field belongs string
Witch.UI.Window.ButtonUse = {}
---@alias CS.Witch.UI.Window.ButtonUse Witch.UI.Window.ButtonUse
CS.Witch.UI.Window.ButtonUse = Witch.UI.Window.ButtonUse

function Witch.UI.Window.ButtonUse:Awake() end
function Witch.UI.Window.ButtonUse:ButtonUseSc() end
function Witch.UI.Window.ButtonUse:DataUpdate() end

---@class Witch.UI.Window.DictionaryUI : Witch.UI.UIBase
---@field BlessList UnityEngine.Transform
---@field RelicList UnityEngine.Transform
---@field CardList UnityEngine.Transform
---@field EnemyList UnityEngine.Transform
---@field nowIndex number
---@field page number
---@field ChooseTags System.Collections.Generic.Dictionary
---@field CardItems System.Collections.Generic.List
---@field ChooseCardItems System.Collections.Generic.List
---@field BlessItems System.Collections.Generic.List
---@field RelicItems System.Collections.Generic.List
---@field EnemyItems System.Collections.Generic.List
---@field TypeNowRarity System.Collections.Generic.Dictionary
Witch.UI.Window.DictionaryUI = {}
---@alias CS.Witch.UI.Window.DictionaryUI Witch.UI.Window.DictionaryUI
CS.Witch.UI.Window.DictionaryUI = Witch.UI.Window.DictionaryUI

function Witch.UI.Window.DictionaryUI:DataUpdate() end
function Witch.UI.Window.DictionaryUI:Retrieve() end
function Witch.UI.Window.DictionaryUI:ReturnList() end
---@return string
function Witch.UI.Window.DictionaryUI:LastCommand() end
---@return string
function Witch.UI.Window.DictionaryUI:NextCommand() end
function Witch.UI.Window.DictionaryUI:Selected() end
---@param formList UnityEngine.Transform
function Witch.UI.Window.DictionaryUI:ReleaseCardItem(formList) end
---@return Cysharp.Threading.Tasks.UniTask
function Witch.UI.Window.DictionaryUI:PreLoad() end
---@param datas System.Collections.Generic.List
function Witch.UI.Window.DictionaryUI:ResetPage(datas) end
function Witch.UI.Window.DictionaryUI:Init() end
function Witch.UI.Window.DictionaryUI:OnEnable() end
function Witch.UI.Window.DictionaryUI:Hide() end
function Witch.UI.Window.DictionaryUI:Close() end
function Witch.UI.Window.DictionaryUI:ReleaseItem() end
function Witch.UI.Window.DictionaryUI:SortingBydefault() end
function Witch.UI.Window.DictionaryUI:SelectCardByPage() end
function Witch.UI.Window.DictionaryUI:TotalCreateItem() end
---@param dictionaryItem Witch.UI.Window.DictionaryItem
function Witch.UI.Window.DictionaryUI:ShowInfo(dictionaryItem) end
function Witch.UI.Window.DictionaryUI:CloseInfo() end
---@param datas System.Collections.Generic.List
---@param temp UnityEngine.Transform
function Witch.UI.Window.DictionaryUI:MoveItem(datas, temp) end
---@param item Witch.UI.Window.BlessItem
---@param type string
function Witch.UI.Window.DictionaryUI:SetRelicDes(item, type) end
---@param item Witch.UI.Window.EnemyItem
function Witch.UI.Window.DictionaryUI:SetEnemyDes(item) end
function Witch.UI.Window.DictionaryUI:CreateCardTag() end
function Witch.UI.Window.DictionaryUI:ResetTag() end
function Witch.UI.Window.DictionaryUI:OnDisable() end

---@class Witch.UI.Window.EnchCardItem : Witch.UI.Window.ItemNonDrag
---@field CardEnchUI Witch.UI.Window.CardEnchUI
Witch.UI.Window.EnchCardItem = {}
---@alias CS.Witch.UI.Window.EnchCardItem Witch.UI.Window.EnchCardItem
CS.Witch.UI.Window.EnchCardItem = Witch.UI.Window.EnchCardItem

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.EnchCardItem:OnPointerClick(eventData) end
function Witch.UI.Window.EnchCardItem:ShowFloatingWindow() end
---@param dataConfig DataConfig
function Witch.UI.Window.EnchCardItem:Init(dataConfig) end
function Witch.UI.Window.EnchCardItem:Unload() end

---@class Witch.UI.Window.EventUI : Witch.UI.UIBase
---@field ClickClip UnityEngine.AudioClip
---@field ShowClip UnityEngine.AudioClip
Witch.UI.Window.EventUI = {}
---@alias CS.Witch.UI.Window.EventUI Witch.UI.Window.EventUI
CS.Witch.UI.Window.EventUI = Witch.UI.Window.EventUI

function Witch.UI.Window.EventUI:FadeIn() end
---@param id string
function Witch.UI.Window.EventUI:Init(id) end
---@param id string
function Witch.UI.Window.EventUI:ContinueEvent(id) end
function Witch.UI.Window.EventUI:Entry() end
function Witch.UI.Window.EventUI:TryChangeMap() end
function Witch.UI.Window.EventUI:AnnounceEventDone() end
---@param index string
function Witch.UI.Window.EventUI:LockChoice(index) end
function Witch.UI.Window.EventUI:EndEvent() end
---@param subtip string
function Witch.UI.Window.EventUI:ChangeSubtip(subtip) end
function Witch.UI.Window.EventUI:DataUpdate() end
function Witch.UI.Window.EventUI:RegisterEvent() end
function Witch.UI.Window.EventUI:ClearEvent() end
function Witch.UI.Window.EventUI:OnDestroy() end

---@class Witch.UI.Window.BuffBarUI : Witch.UI.UIBase
---@field content UnityEngine.Transform
---@field status StatusManager
---@field BuffDic System.Collections.Generic.Dictionary
---@field isDirty boolean
---@field isDisplay boolean
Witch.UI.Window.BuffBarUI = {}
---@alias CS.Witch.UI.Window.BuffBarUI Witch.UI.Window.BuffBarUI
CS.Witch.UI.Window.BuffBarUI = Witch.UI.Window.BuffBarUI

---@param buffId string
---@param level number
function Witch.UI.Window.BuffBarUI:CreateNewBuff(buffId, level) end
---@param buffId string
---@return Witch.UI.Window.BuffBarUI
function Witch.UI.Window.BuffBarUI:RemoveBuff(buffId) end
---@overload fun(self: Witch.UI.Window.BuffBarUI, buffId: string, level: number) : Witch.UI.Window.BuffBarUI
---@param buffConfig IBuffItemConfig
---@return Witch.UI.Window.BuffBarUI
function Witch.UI.Window.BuffBarUI:AddBuff(buffConfig) end
---@param buffId string
---@return BuffItem
function Witch.UI.Window.BuffBarUI:GetBuff(buffId) end
---@return BuffItem[]
function Witch.UI.Window.BuffBarUI:GetBuffs() end
---@param way string
---@return Witch.UI.Window.BuffBarUI
function Witch.UI.Window.BuffBarUI:CheckAllBuff(way) end
function Witch.UI.Window.BuffBarUI:UpdateAllBuff() end
function Witch.UI.Window.BuffBarUI:ClearAllBuff() end

---@class Witch.UI.Window.FightUI : Witch.UI.UIBase
---@field LastCard DataConfig
---@field cardItemList System.Collections.Generic.List
---@field SelectedCard System.Collections.Generic.List
---@field IsReset boolean
---@field SpecialCount number
---@field InIEn boolean
---@field SelectType string
---@field Card_y_position number
---@field started boolean
---@field chest UnityEngine.GameObject
---@field ShouldCard number
---@field cardContainer CardContainer
---@field selectCardContainer CardContainer
---@field StatusList System.Collections.Generic.List
---@field totalDamageText System.Collections.Generic.Dictionary
---@field hasTime number
---@field autoCard boolean
---@field transform1 UnityEngine.Transform
---@field endfight UnityEngine.Transform
---@field FightAgain UnityEngine.Transform
---@field UsedCardList UnityEngine.Transform
---@field turnButton Michsky.MUIP.ButtonManager
---@field instance UnityEngine.GameObject
---@field animationQueue System.Collections.Generic.Queue
---@field blurReturn boolean
---@field NowAnimation boolean
---@field CardTopCount number
Witch.UI.Window.FightUI = {}
---@alias CS.Witch.UI.Window.FightUI Witch.UI.Window.FightUI
CS.Witch.UI.Window.FightUI = Witch.UI.Window.FightUI

function Witch.UI.Window.FightUI:OnDestroy() end
function Witch.UI.Window.FightUI:Close() end
---@param text string
---@param position UnityEngine.Vector3
---@param popUpType1 string
---@param status StatusManager
---@param to StatusManager
---@param realDamage string
function Witch.UI.Window.FightUI:EnqueueDamageText(text, position, popUpType1, status, to, realDamage) end
function Witch.UI.Window.FightUI:StartClock() end
function Witch.UI.Window.FightUI:StopClock() end
---@param obj FightObject
---@param index number
---@param count number
function Witch.UI.Window.FightUI:SetTurn(obj, index, count) end
function Witch.UI.Window.FightUI:ShowChest() end
function Witch.UI.Window.FightUI:AutoUseCard() end
function Witch.UI.Window.FightUI:ShowTitle() end
function Witch.UI.Window.FightUI:Init() end
function Witch.UI.Window.FightUI:InitSkill() end
---@param tempItem UnityEngine.Transform
---@param index number
function Witch.UI.Window.FightUI:CreateSkillItem(tempItem, index) end
function Witch.UI.Window.FightUI:CreateDeckMenu() end
function Witch.UI.Window.FightUI:CreateUsedCardList() end
function Witch.UI.Window.FightUI:UpdatePower() end
function Witch.UI.Window.FightUI:FightAgainBtn() end
function Witch.UI.Window.FightUI:Reset() end
function Witch.UI.Window.FightUI:onChangeTurnBtn() end
---@overload fun(self: Witch.UI.Window.FightUI, Count: number)
---@param dataConfig DataConfig
function Witch.UI.Window.FightUI:CreateCardItem(dataConfig) end
---@param OnComplete DG.Tweening.TweenCallback
---@param from CardContainer
function Witch.UI.Window.FightUI:UpdateCardItemPos(OnComplete, from) end
function Witch.UI.Window.FightUI:ShuffleCardItems() end
function Witch.UI.Window.FightUI:UpdateCardMsg() end
function Witch.UI.Window.FightUI:UpdateCardsShow() end
---@return number
function Witch.UI.Window.FightUI:RemoveAllCards() end
---@param val string
---@param Type string
function Witch.UI.Window.FightUI:ThrowCardScript(val, Type) end
---@param val string
---@param Type string
function Witch.UI.Window.FightUI:Burning(val, Type) end
---@return number
function Witch.UI.Window.FightUI:BurnAndThrowCheck() end
---@param cardItem CardItem
function Witch.UI.Window.FightUI:BurnCard(cardItem) end
---@param uitype string
function Witch.UI.Window.FightUI:SelectInit(uitype) end
function Witch.UI.Window.FightUI:ShowBattleReward() end
function Witch.UI.Window.FightUI:CanWin() end
function Witch.UI.Window.FightUI:EndInstance() end
function Witch.UI.Window.FightUI:Yes() end
---@return boolean
function Witch.UI.Window.FightUI:AllCannotUse() end
---@param scriptExecutor IScriptExecutor
function Witch.UI.Window.FightUI:CallActionAnimation(scriptExecutor) end
function Witch.UI.Window.FightUI:DOActionAnimation() end
---@param cardUseData Fight.ActionCommand.UseCard.CardUseData
function Witch.UI.Window.FightUI:DoCardUseAnimation(cardUseData) end

---@class Witch.UI.Window.FightUI.DamageTextInfo : System.Object
---@field text string
---@field position UnityEngine.Vector2
---@field popUpType string
---@field status StatusManager
---@field to StatusManager
---@field realDamage string
Witch.UI.Window.FightUI.DamageTextInfo = {}
---@alias CS.Witch.UI.Window.FightUI.DamageTextInfo Witch.UI.Window.FightUI.DamageTextInfo
CS.Witch.UI.Window.FightUI.DamageTextInfo = Witch.UI.Window.FightUI.DamageTextInfo

---@return Witch.UI.Window.FightUI.DamageTextInfo
function Witch.UI.Window.FightUI.DamageTextInfo.New() end

---@class Witch.UI.Window.FightUI.AnimationData : System.ValueType
---@field status StatusManager[]
---@field animationState IStatusManager.AnimatedState[]
---@field effectName string
Witch.UI.Window.FightUI.AnimationData = {}
---@alias CS.Witch.UI.Window.FightUI.AnimationData Witch.UI.Window.FightUI.AnimationData
CS.Witch.UI.Window.FightUI.AnimationData = Witch.UI.Window.FightUI.AnimationData

---@param data Fight.ActionCommand.ActionAnimation.AnimationData
---@return Witch.UI.Window.FightUI.AnimationData
function Witch.UI.Window.FightUI.AnimationData.New(data) end

---@class Witch.UI.Window.LineUI : Witch.UI.UIBase
---@field arcLengthSamples number
Witch.UI.Window.LineUI = {}
---@alias CS.Witch.UI.Window.LineUI Witch.UI.Window.LineUI
CS.Witch.UI.Window.LineUI = Witch.UI.Window.LineUI

---@param pos UnityEngine.Vector3
function Witch.UI.Window.LineUI:SetStartPos(pos) end
---@param pos System.Nullable
function Witch.UI.Window.LineUI:SetEndPos(pos) end
---@param start UnityEngine.Vector3
---@param mid UnityEngine.Vector3
---@param _end UnityEngine.Vector3
---@param t number
---@return UnityEngine.Vector3
function Witch.UI.Window.LineUI:GetBezier(start, mid, _end, t) end
function Witch.UI.Window.LineUI:FadeIn() end
---@param callback System.Action | function
function Witch.UI.Window.LineUI:FadeOut(callback) end
function Witch.UI.Window.LineUI:OnDestroy() end

---@class Witch.UI.Window.PopUpTextUI : UnityEngine.MonoBehaviour
---@field x_position_curve UnityEngine.AnimationCurve
---@field y_position_curve UnityEngine.AnimationCurve
---@field fontsize_curve UnityEngine.AnimationCurve
---@field colors UnityEngine.Gradient
---@field val string
---@field isDestroy boolean
---@field TotalTime number
---@field maxHeight number
---@field maxLength number
---@field maxFontSize number
---@field nowPos UnityEngine.Vector2
---@field start_position UnityEngine.Vector2
---@field time number
---@field existTime number
---@field target string
---@field pause boolean
Witch.UI.Window.PopUpTextUI = {}
---@alias CS.Witch.UI.Window.PopUpTextUI Witch.UI.Window.PopUpTextUI
CS.Witch.UI.Window.PopUpTextUI = Witch.UI.Window.PopUpTextUI

---@param value number
function Witch.UI.Window.PopUpTextUI:SetDisplayInt(value) end
---@return number
function Witch.UI.Window.PopUpTextUI:GetDisplayInt() end
function Witch.UI.Window.PopUpTextUI:InitChange() end
---@param val number
function Witch.UI.Window.PopUpTextUI:SetTextFont(val) end
function Witch.UI.Window.PopUpTextUI:Update() end

---@class Witch.UI.Window.StatusBarUI : UnityEngine.MonoBehaviour
---@field Status StatusManager
---@field hpItemObj UnityEngine.GameObject
---@field buffBarObj UnityEngine.GameObject
---@field hpTxt TMPro.TMP_Text
---@field hpRedImg UnityEngine.SpriteRenderer
---@field hpImg UnityEngine.SpriteRenderer
---@field defendImg UnityEngine.SpriteRenderer
---@field nameObj UnityEngine.GameObject
---@field toughObj UnityEngine.GameObject
---@field backgroundObj UnityEngine.GameObject
Witch.UI.Window.StatusBarUI = {}
---@alias CS.Witch.UI.Window.StatusBarUI Witch.UI.Window.StatusBarUI
CS.Witch.UI.Window.StatusBarUI = Witch.UI.Window.StatusBarUI

---@param status StatusManager
function Witch.UI.Window.StatusBarUI:Init(status) end
---@param Defend number
---@param CurHp number
---@param MaxHp number
---@param NeedEffect boolean
function Witch.UI.Window.StatusBarUI:UpdateHealthBar(Defend, CurHp, MaxHp, NeedEffect) end
function Witch.UI.Window.StatusBarUI:UpdateTough() end
function Witch.UI.Window.StatusBarUI:OnSelected() end
function Witch.UI.Window.StatusBarUI:OnUnSelected() end

---@class Witch.UI.Window.GameEntryUI : Witch.UI.UIBase
---@field selectedSave Data.Save.SaveInfo
---@field playerCount number
---@field partner DataConfig
---@field MainParent UnityEngine.Transform
---@field SecondParent UnityEngine.Transform
---@field selectHardUI Witch.UI.Window.SelectHardUI
---@field careerChoiceParent UnityEngine.Transform
---@field waitCount number
---@field careerIndex number
---@field partnerIndex number
---@field showCareers System.Collections.Generic.List
---@field showPartners System.Collections.Generic.List
---@field lastcareer DataConfig
---@field career DataConfig
---@field isHost boolean
Witch.UI.Window.GameEntryUI = {}
---@alias CS.Witch.UI.Window.GameEntryUI Witch.UI.Window.GameEntryUI
CS.Witch.UI.Window.GameEntryUI = Witch.UI.Window.GameEntryUI

function Witch.UI.Window.GameEntryUI:Init() end
function Witch.UI.Window.GameEntryUI:CloseAllWindows() end
function Witch.UI.Window.GameEntryUI:DataUpdate() end
function Witch.UI.Window.GameEntryUI:Outlobby() end
function Witch.UI.Window.GameEntryUI:ReturnHouse() end
function Witch.UI.Window.GameEntryUI:Close() end
---@param ready boolean
function Witch.UI.Window.GameEntryUI:ChangeReady(ready) end
---@param ready boolean
---@param playerId string
function Witch.UI.Window.GameEntryUI:SetReady(ready, playerId) end
function Witch.UI.Window.GameEntryUI:StartGame() end
function Witch.UI.Window.GameEntryUI:NormalGame() end
function Witch.UI.Window.GameEntryUI:OpenChoice() end
function Witch.UI.Window.GameEntryUI:OpenWindow() end
function Witch.UI.Window.GameEntryUI:CloseWindow() end
function Witch.UI.Window.GameEntryUI:OpenSelectHard() end
---@param players System.Collections.Generic.List
function Witch.UI.Window.GameEntryUI:UpdateLobby(players) end
function Witch.UI.Window.GameEntryUI:ShowCareer() end
---@param thiscareer Witch.UI.Window.ShowCareer
---@param way string
---@param ischangeRole boolean
function Witch.UI.Window.GameEntryUI:ShowDetail(thiscareer, way, ischangeRole) end
---@param thiscareer DataConfig
---@param tempParent UnityEngine.Transform
function Witch.UI.Window.GameEntryUI:ChangeCareerDesShow(thiscareer, tempParent) end
---@param dataConfig DataConfig
---@param fromId string
function Witch.UI.Window.GameEntryUI:ChangeRole(dataConfig, fromId) end

---@class Witch.UI.Window.GameExitUI : Witch.UI.UIBase
---@field loss boolean
---@field BlackMask UnityEngine.UI.Image
---@field MainContent UnityEngine.Transform
---@field sr UnityEngine.SpriteRenderer
---@field ExpLevel TMPro.TMP_Text
---@field BaseTran UnityEngine.Transform
---@field MulTran UnityEngine.Transform
---@field TrueCount number
---@field gameRuntimeData GameRuntimeData
Witch.UI.Window.GameExitUI = {}
---@alias CS.Witch.UI.Window.GameExitUI Witch.UI.Window.GameExitUI
CS.Witch.UI.Window.GameExitUI = Witch.UI.Window.GameExitUI

function Witch.UI.Window.GameExitUI:NextShow() end
function Witch.UI.Window.GameExitUI:OnDestroy() end
function Witch.UI.Window.GameExitUI:ReturnAsync() end

---@class Witch.UI.Window.HouseUI : UnityEngine.MonoBehaviour
---@field CanScroll boolean
---@field storehouseUI Witch.UI.Window.StorehouseUI
---@field houseRect UnityEngine.RectTransform
---@field targetCamera UnityEngine.Camera
---@field minScale number
Witch.UI.Window.HouseUI = {}
---@alias CS.Witch.UI.Window.HouseUI Witch.UI.Window.HouseUI
CS.Witch.UI.Window.HouseUI = Witch.UI.Window.HouseUI

function Witch.UI.Window.HouseUI:ShadowChat() end
function Witch.UI.Window.HouseUI:StartShop() end
function Witch.UI.Window.HouseUI:OnClickCardEditor() end
function Witch.UI.Window.HouseUI:OpenStorehouse() end
function Witch.UI.Window.HouseUI:OpenDictionary() end
function Witch.UI.Window.HouseUI:OnClickMod() end
function Witch.UI.Window.HouseUI:ReturnMenu() end
---@param houseItemType HouseItem.HouseItemType
function Witch.UI.Window.HouseUI:ClickItem(houseItemType) end
function Witch.UI.Window.HouseUI:OpenAnnouncement() end
function Witch.UI.Window.HouseUI:OnDestroy() end

---@class Witch.UI.Window.IllustratedBookUI : Witch.UI.UIBase
---@field MsgContent UnityEngine.RectTransform
Witch.UI.Window.IllustratedBookUI = {}
---@alias CS.Witch.UI.Window.IllustratedBookUI Witch.UI.Window.IllustratedBookUI
CS.Witch.UI.Window.IllustratedBookUI = Witch.UI.Window.IllustratedBookUI


---@class Witch.UI.Window.BlessItem : Witch.UI.Window.DictionaryItem
Witch.UI.Window.BlessItem = {}
---@alias CS.Witch.UI.Window.BlessItem Witch.UI.Window.BlessItem
CS.Witch.UI.Window.BlessItem = Witch.UI.Window.BlessItem

function Witch.UI.Window.BlessItem:DataUpdate() end
---@param dataConfig DataConfig
function Witch.UI.Window.BlessItem:Init(dataConfig) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.BlessItem:OnPointerClick(eventData) end
function Witch.UI.Window.BlessItem:SetName() end

---@class Witch.UI.Window.CardChoiceItem : UnityEngine.MonoBehaviour
---@field objectGroup ObjectGroup
Witch.UI.Window.CardChoiceItem = {}
---@alias CS.Witch.UI.Window.CardChoiceItem Witch.UI.Window.CardChoiceItem
CS.Witch.UI.Window.CardChoiceItem = Witch.UI.Window.CardChoiceItem

---@param UI Witch.UI.Window.CardChoiceUI
---@param fromId string
function Witch.UI.Window.CardChoiceItem:Initialize(UI, fromId) end
---@param delay number
function Witch.UI.Window.CardChoiceItem:FadeIn(delay) end
function Witch.UI.Window.CardChoiceItem:DataUpdate() end
---@param delay number
function Witch.UI.Window.CardChoiceItem:FadeOut(delay) end
function Witch.UI.Window.CardChoiceItem:MoveToDeck() end

---@class Witch.UI.Window.CardEnchUI : Witch.UI.Window.ShopUI
Witch.UI.Window.CardEnchUI = {}
---@alias CS.Witch.UI.Window.CardEnchUI Witch.UI.Window.CardEnchUI
CS.Witch.UI.Window.CardEnchUI = Witch.UI.Window.CardEnchUI

function Witch.UI.Window.CardEnchUI:SetShopItems() end
function Witch.UI.Window.CardEnchUI:UpdateEnchShow() end
---@param enchItem Witch.UI.Window.ShopItem
function Witch.UI.Window.CardEnchUI:ShowCardToEnch(enchItem) end

---@class Witch.UI.Window.DictionaryItem : Witch.UI.Window.ItemNonDrag
---@field dictionaryUI Witch.UI.Window.DictionaryUI
Witch.UI.Window.DictionaryItem = {}
---@alias CS.Witch.UI.Window.DictionaryItem Witch.UI.Window.DictionaryItem
CS.Witch.UI.Window.DictionaryItem = Witch.UI.Window.DictionaryItem

---@param dataConfig DataConfig
function Witch.UI.Window.DictionaryItem:Init(dataConfig) end
function Witch.UI.Window.DictionaryItem:Awake() end
function Witch.UI.Window.DictionaryItem:DataUpdate() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DictionaryItem:OnPointerClick(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DictionaryItem:OnPointerEnter(eventData) end

---@class Witch.UI.Window.DictionaryShowItem : Witch.UI.Window.ItemNonDrag
---@field dictionaryUI Witch.UI.Window.DictionaryUI
---@field defaultCount number
Witch.UI.Window.DictionaryShowItem = {}
---@alias CS.Witch.UI.Window.DictionaryShowItem Witch.UI.Window.DictionaryShowItem
CS.Witch.UI.Window.DictionaryShowItem = Witch.UI.Window.DictionaryShowItem

---@param dataConfig DataConfig
function Witch.UI.Window.DictionaryShowItem:Init(dataConfig) end
function Witch.UI.Window.DictionaryShowItem:DataUpdate() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DictionaryShowItem:OnPointerEnter(eventData) end
function Witch.UI.Window.DictionaryShowItem:ShowFloatingWindow() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DictionaryShowItem:OnPointerClick(eventData) end

---@class Witch.UI.Window.DictItem : Witch.UI.Window.DictionaryItem
Witch.UI.Window.DictItem = {}
---@alias CS.Witch.UI.Window.DictItem Witch.UI.Window.DictItem
CS.Witch.UI.Window.DictItem = Witch.UI.Window.DictItem

---@param dataConfig DataConfig
function Witch.UI.Window.DictItem:Init(dataConfig) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DictItem:OnPointerEnter(eventData) end
---@param newTransform UnityEngine.Transform
function Witch.UI.Window.DictItem:SetCardMsg(newTransform) end
function Witch.UI.Window.DictItem:DataUpdate() end

---@class Witch.UI.Window.DictTagItem : UnityEngine.MonoBehaviour
---@field TagType string
---@field tagName string
Witch.UI.Window.DictTagItem = {}
---@alias CS.Witch.UI.Window.DictTagItem Witch.UI.Window.DictTagItem
CS.Witch.UI.Window.DictTagItem = Witch.UI.Window.DictTagItem

---@overload fun(self: Witch.UI.Window.DictTagItem, name: string, dictionaryUI: Witch.UI.Window.DictionaryUI)
---@param dictionaryUI Witch.UI.Window.DictionaryUI
function Witch.UI.Window.DictTagItem:Init(dictionaryUI) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.DictTagItem:OnPointerClick(eventData) end
function Witch.UI.Window.DictTagItem:ReturnNormal() end
function Witch.UI.Window.DictTagItem:RegisterEvent() end
function Witch.UI.Window.DictTagItem:DataUpdate() end
function Witch.UI.Window.DictTagItem:ClearEvent() end

---@class Witch.UI.Window.EnchItem : Witch.UI.Window.Item
---@field CardEnchUI Witch.UI.Window.CardEnchUI
Witch.UI.Window.EnchItem = {}
---@alias CS.Witch.UI.Window.EnchItem Witch.UI.Window.EnchItem
CS.Witch.UI.Window.EnchItem = Witch.UI.Window.EnchItem

---@param dataConfig DataConfig
function Witch.UI.Window.EnchItem:Init(dataConfig) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.EnchItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.EnchItem:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.EnchItem:OnPointerClick(eventData) end
---@return string
function Witch.UI.Window.EnchItem:CreateTooltipText() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.EnchItem:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.EnchItem:OnEndDrag(eventData) end
function Witch.UI.Window.EnchItem:AddToParent() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.EnchItem:InsertCard(eventData) end

---@class Witch.UI.Window.EnemyItem : Witch.UI.Window.DictionaryItem
---@field MapName System.Collections.Generic.Dictionary
Witch.UI.Window.EnemyItem = {}
---@alias CS.Witch.UI.Window.EnemyItem Witch.UI.Window.EnemyItem
CS.Witch.UI.Window.EnemyItem = Witch.UI.Window.EnemyItem

function Witch.UI.Window.EnemyItem:DataUpdate() end
---@param dataConfig DataConfig
function Witch.UI.Window.EnemyItem:Init(dataConfig) end
function Witch.UI.Window.EnemyItem:SetName() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.EnemyItem:OnPointerClick(eventData) end

---@class Witch.UI.Window.Item : UnityEngine.MonoBehaviour
---@field rareLevel string
---@field itemId string
---@field Rarity string
---@field ifEquipped boolean
---@field color string
---@field keywords System.Collections.Generic.List
---@field dataConfig DataConfig
---@field ItemType string
---@field itemIcon UnityEngine.Sprite
---@field itemPrice number
---@field lastPos UnityEngine.Vector2
---@field canClick boolean
---@field lastParent UnityEngine.Transform
---@field isHover boolean
---@field isDrag boolean
---@field keywordDisplay Witch.UI.KeywordDisplay
---@field floatingWindow FloatingWindow
---@field itemName string
---@field itemDescription string
---@field itemTip string
Witch.UI.Window.Item = {}
---@alias CS.Witch.UI.Window.Item Witch.UI.Window.Item
CS.Witch.UI.Window.Item = Witch.UI.Window.Item

function Witch.UI.Window.Item:Awake() end
---@param dataConfig DataConfig
function Witch.UI.Window.Item:Init(dataConfig) end
function Witch.UI.Window.Item:DataUpdate() end
function Witch.UI.Window.Item:RegisterEvent() end
function Witch.UI.Window.Item:ClearEvent() end
---@return string
function Witch.UI.Window.Item:CreateTooltipText() end
function Witch.UI.Window.Item:ShowFloatingWindow() end
function Witch.UI.Window.Item:HideFloatingWindow() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.Item:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.Item:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.Item:OnDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.Item:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.Item:OnEndDrag(eventData) end
---@param item SwapContentIdentity
function Witch.UI.Window.Item:AddToList(item) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.Item:OnPointerClick(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
---@return UnityEngine.Vector2
function Witch.UI.Window.Item:GetMousePos(eventData) end
function Witch.UI.Window.Item:OnDestroy() end
function Witch.UI.Window.Item:OnTransformParentChanged() end
function Witch.UI.Window.Item:RemoveFromParent() end
function Witch.UI.Window.Item:AddToParent() end

---@class Witch.UI.Window.ItemNonDrag : Witch.UI.Window.Item
Witch.UI.Window.ItemNonDrag = {}
---@alias CS.Witch.UI.Window.ItemNonDrag Witch.UI.Window.ItemNonDrag
CS.Witch.UI.Window.ItemNonDrag = Witch.UI.Window.ItemNonDrag

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ItemNonDrag:OnDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ItemNonDrag:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ItemNonDrag:OnEndDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ItemNonDrag:OnPointerClick(eventData) end
function Witch.UI.Window.ItemNonDrag:OnDestroy() end

---@class Witch.UI.Window.PageItem : UnityEngine.MonoBehaviour
---@field dictionaryUI Witch.UI.Window.DictionaryUI
Witch.UI.Window.PageItem = {}
---@alias CS.Witch.UI.Window.PageItem Witch.UI.Window.PageItem
CS.Witch.UI.Window.PageItem = Witch.UI.Window.PageItem

---@param pointerEvent UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.PageItem:OnPointerClick(pointerEvent) end

---@class Witch.UI.Window.RelicItemConfig : Witch.UI.Window.Item
---@field relicSelectUI Witch.UI.Window.RelicSelectUI
---@field glowMaterial UnityEngine.Material
Witch.UI.Window.RelicItemConfig = {}
---@alias CS.Witch.UI.Window.RelicItemConfig Witch.UI.Window.RelicItemConfig
CS.Witch.UI.Window.RelicItemConfig = Witch.UI.Window.RelicItemConfig

function Witch.UI.Window.RelicItemConfig:ShowFloatingWindow() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.RelicItemConfig:OnBeginDrag(eventData) end
---@param dataConfig DataConfig
function Witch.UI.Window.RelicItemConfig:Init(dataConfig) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.RelicItemConfig:OnDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.RelicItemConfig:OnEndDrag(eventData) end
function Witch.UI.Window.RelicItemConfig:OnTransformParentChanged() end
---@param enable boolean
function Witch.UI.Window.RelicItemConfig:SetGlowEvent(enable) end
function Witch.UI.Window.RelicItemConfig:EffectAnimation() end

---@class Witch.UI.Window.ResultItem : Witch.UI.Window.ItemNonDrag
---@field canright boolean
---@field outside boolean
Witch.UI.Window.ResultItem = {}
---@alias CS.Witch.UI.Window.ResultItem Witch.UI.Window.ResultItem
CS.Witch.UI.Window.ResultItem = Witch.UI.Window.ResultItem

---@param dataConfig DataConfig
function Witch.UI.Window.ResultItem:Init(dataConfig) end
function Witch.UI.Window.ResultItem:KeyworsDis() end
function Witch.UI.Window.ResultItem:HideFloatingWindow() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ResultItem:OnPointerClick(eventData) end
---@return string
function Witch.UI.Window.ResultItem:CreateTooltipText() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ResultItem:OnBeginDrag(eventData) end

---@class Witch.UI.Window.ShowCard : Witch.UI.Window.Item
---@field cardShowUI Witch.UI.Window.OutDeckUI
---@field DestroyCost number
Witch.UI.Window.ShowCard = {}
---@alias CS.Witch.UI.Window.ShowCard Witch.UI.Window.ShowCard
CS.Witch.UI.Window.ShowCard = Witch.UI.Window.ShowCard

---@param dataConfig DataConfig
---@param ifequipped boolean
---@param fromSelf boolean
function Witch.UI.Window.ShowCard:Init(dataConfig, ifequipped, fromSelf) end
function Witch.UI.Window.ShowCard:DataUpdate() end
function Witch.UI.Window.ShowCard:MoveItem() end
function Witch.UI.Window.ShowCard:ShowFloatingWindow() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowCard:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowCard:OnPointerClick(eventData) end
function Witch.UI.Window.ShowCard:DecomposeItem() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowCard:OnDrag(eventData) end
function Witch.UI.Window.ShowCard:ItemCheck() end
function Witch.UI.Window.ShowCard:SellItem() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowCard:OnEndDrag(eventData) end
---@param content SwapContentIdentity
function Witch.UI.Window.ShowCard:AddToList(content) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowCard:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowCard:OnPointerExit(eventData) end

---@class Witch.UI.Window.ShowVarItem : UnityEngine.MonoBehaviour
---@field text string
Witch.UI.Window.ShowVarItem = {}
---@alias CS.Witch.UI.Window.ShowVarItem Witch.UI.Window.ShowVarItem
CS.Witch.UI.Window.ShowVarItem = Witch.UI.Window.ShowVarItem

function Witch.UI.Window.ShowVarItem:Start() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowVarItem:OnPointerClick(eventData) end
function Witch.UI.Window.ShowVarItem:Show() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShowVarItem:OnPointerExit(eventData) end

---@class Witch.UI.Window.StorehouseItem : Witch.UI.Window.ItemNonDrag
---@field storehouseUI Witch.UI.Window.StorehouseUI
Witch.UI.Window.StorehouseItem = {}
---@alias CS.Witch.UI.Window.StorehouseItem Witch.UI.Window.StorehouseItem
CS.Witch.UI.Window.StorehouseItem = Witch.UI.Window.StorehouseItem

function Witch.UI.Window.StorehouseItem:Start() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.StorehouseItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.StorehouseItem:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.StorehouseItem:OnPointerClick(eventData) end

---@class Witch.UI.Window.MainMenuUI : Witch.UI.UIBase
Witch.UI.Window.MainMenuUI = {}
---@alias CS.Witch.UI.Window.MainMenuUI Witch.UI.Window.MainMenuUI
CS.Witch.UI.Window.MainMenuUI = Witch.UI.Window.MainMenuUI

function Witch.UI.Window.MainMenuUI:DataUpdate() end
function Witch.UI.Window.MainMenuUI:StartGame() end
function Witch.UI.Window.MainMenuUI:CloseTheGame() end
---@param url string
function Witch.UI.Window.MainMenuUI:OpenWebsite(url) end
function Witch.UI.Window.MainMenuUI:OpenSettings() end
function Witch.UI.Window.MainMenuUI:OnDisable() end

---@class Witch.UI.Window.MapSelectUI : Witch.UI.UIBase
---@field cardContainer CardContainer
---@field ground_y number
---@field groundPos UnityEngine.Transform
---@field IsAnimating boolean
Witch.UI.Window.MapSelectUI = {}
---@alias CS.Witch.UI.Window.MapSelectUI Witch.UI.Window.MapSelectUI
CS.Witch.UI.Window.MapSelectUI = Witch.UI.Window.MapSelectUI

function Witch.UI.Window.MapSelectUI:FadeIn() end
function Witch.UI.Window.MapSelectUI:DataUpdate() end
function Witch.UI.Window.MapSelectUI:UpdateCardItemPos() end
function Witch.UI.Window.MapSelectUI:ReadyToSelect() end
---@param nodes System.Collections.Generic.List
function Witch.UI.Window.MapSelectUI:CreateMapItem(nodes) end
function Witch.UI.Window.MapSelectUI:MapAnimation() end
function Witch.UI.Window.MapSelectUI:SendNode() end
function Witch.UI.Window.MapSelectUI:ShowMap() end
---@param count number
function Witch.UI.Window.MapSelectUI:CreateNodes(count) end
---@return MapTree.Node[]
function Witch.UI.Window.MapSelectUI:GetNodes() end
function Witch.UI.Window.MapSelectUI:SetNodes() end
function Witch.UI.Window.MapSelectUI:OnDestroy() end

---@class Witch.UI.Window.ItemShowUI : Witch.UI.UIBase
Witch.UI.Window.ItemShowUI = {}
---@alias CS.Witch.UI.Window.ItemShowUI Witch.UI.Window.ItemShowUI
CS.Witch.UI.Window.ItemShowUI = Witch.UI.Window.ItemShowUI

---@overload fun(self: Witch.UI.Window.ItemShowUI, dataConfig: DataConfig)
---@param icon UnityEngine.Sprite
---@param title string
---@param description string
---@param tips string
function Witch.UI.Window.ItemShowUI:ShowItem(icon, title, description, tips) end

---@class Witch.UI.Window.TitleUI : Witch.UI.UIBase
Witch.UI.Window.TitleUI = {}
---@alias CS.Witch.UI.Window.TitleUI Witch.UI.Window.TitleUI
CS.Witch.UI.Window.TitleUI = Witch.UI.Window.TitleUI

---@param main string
---@param sub string
function Witch.UI.Window.TitleUI:ShowTitle(main, sub) end

---@class Witch.UI.Window.TutorialUI : Witch.UI.UIBase
---@field ItemPrefab UnityEngine.GameObject
---@field SelectSprite UnityEngine.Sprite
---@field UnselectSprite UnityEngine.Sprite
Witch.UI.Window.TutorialUI = {}
---@alias CS.Witch.UI.Window.TutorialUI Witch.UI.Window.TutorialUI
CS.Witch.UI.Window.TutorialUI = Witch.UI.Window.TutorialUI

function Witch.UI.Window.TutorialUI:Awake() end
---@param id string
function Witch.UI.Window.TutorialUI:ShowTutorial(id) end

---@class Witch.UI.Window.ModeChoiceUI : Witch.UI.UIBase
---@field beforeSave System.Collections.Generic.Dictionary
---@field gameEntryUI Witch.UI.Window.GameEntryUI
---@field canClick boolean
Witch.UI.Window.ModeChoiceUI = {}
---@alias CS.Witch.UI.Window.ModeChoiceUI Witch.UI.Window.ModeChoiceUI
CS.Witch.UI.Window.ModeChoiceUI = Witch.UI.Window.ModeChoiceUI

function Witch.UI.Window.ModeChoiceUI:DataUpdate() end
function Witch.UI.Window.ModeChoiceUI:Init() end
---@param modeType string
function Witch.UI.Window.ModeChoiceUI:CreateNewSave(modeType) end
function Witch.UI.Window.ModeChoiceUI:TeachMode() end
---@param saveInfo Data.Save.SaveInfo
---@return boolean
function Witch.UI.Window.ModeChoiceUI:CheckSave(saveInfo) end
function Witch.UI.Window.ModeChoiceUI:NormalMode() end
function Witch.UI.Window.ModeChoiceUI:SlotMode() end
function Witch.UI.Window.ModeChoiceUI:SublimationMode() end
function Witch.UI.Window.ModeChoiceUI:ShowUnDone() end
---@param modeType string
function Witch.UI.Window.ModeChoiceUI:ReturnGame(modeType) end
function Witch.UI.Window.ModeChoiceUI:Close() end
function Witch.UI.Window.ModeChoiceUI:OnDisable() end

---@class Witch.UI.Window.ModManagerUI : Witch.UI.UIBase
---@field progressBar Michsky.MUIP.ProgressBar
Witch.UI.Window.ModManagerUI = {}
---@alias CS.Witch.UI.Window.ModManagerUI Witch.UI.Window.ModManagerUI
CS.Witch.UI.Window.ModManagerUI = Witch.UI.Window.ModManagerUI

function Witch.UI.Window.ModManagerUI:Close() end

---@class Witch.UI.Window.OutSideItem : Witch.UI.Window.ItemNonDrag
---@field isgoods boolean
---@field outsiderShopUI Witch.UI.Window.OutsiderShopUI
Witch.UI.Window.OutSideItem = {}
---@alias CS.Witch.UI.Window.OutSideItem Witch.UI.Window.OutSideItem
CS.Witch.UI.Window.OutSideItem = Witch.UI.Window.OutSideItem

---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.OutSideItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.OutSideItem:OnPointerExit(eventData) end

---@class Witch.UI.Window.OutsiderShopUI : Witch.UI.Window.ShopUI
---@field thiscurrentItem Witch.UI.Window.OutsideShopItem
---@field fadeTransforms System.Collections.Generic.List
---@field transitionTime number
---@field TypeMap System.Collections.Generic.Dictionary
---@field ShopItems System.Collections.Generic.List
Witch.UI.Window.OutsiderShopUI = {}
---@alias CS.Witch.UI.Window.OutsiderShopUI Witch.UI.Window.OutsiderShopUI
CS.Witch.UI.Window.OutsiderShopUI = Witch.UI.Window.OutsiderShopUI

function Witch.UI.Window.OutsiderShopUI:Awake() end
function Witch.UI.Window.OutsiderShopUI:DataUpdate() end
function Witch.UI.Window.OutsiderShopUI:Init() end
function Witch.UI.Window.OutsiderShopUI:Hide() end
---@param item Witch.UI.Window.OutsideShopItem
function Witch.UI.Window.OutsiderShopUI:SetCurrentItem(item) end
function Witch.UI.Window.OutsiderShopUI:SetShopItems() end
function Witch.UI.Window.OutsiderShopUI:OnEnable() end
function Witch.UI.Window.OutsiderShopUI:TryBuy() end
function Witch.UI.Window.OutsiderShopUI:ChangeTrue() end
function Witch.UI.Window.OutsiderShopUI:UpdateAllItems() end
function Witch.UI.Window.OutsiderShopUI:UpdateItemDes() end
function Witch.UI.Window.OutsiderShopUI:TriggerCalled() end
function Witch.UI.Window.OutsiderShopUI:OnDisable() end

---@class Witch.UI.Window.ResultUI : Witch.UI.UIBase
---@field GetItemList UnityEngine.Transform
Witch.UI.Window.ResultUI = {}
---@alias CS.Witch.UI.Window.ResultUI Witch.UI.Window.ResultUI
CS.Witch.UI.Window.ResultUI = Witch.UI.Window.ResultUI

---@param datas System.Collections.Generic.List
function Witch.UI.Window.ResultUI:CreateResultItem(datas) end

---@class Witch.UI.Window.SafeBoxItem : Witch.UI.Window.Item
---@field safeBoxUI Witch.UI.Window.SafeBoxUI
---@field InBackPack boolean
---@field hasInBack boolean
---@field tooltip Tooltip
---@field normalCanvasGroup UnityEngine.CanvasGroup
---@field highlightCanvasGroup UnityEngine.CanvasGroup
Witch.UI.Window.SafeBoxItem = {}
---@alias CS.Witch.UI.Window.SafeBoxItem Witch.UI.Window.SafeBoxItem
CS.Witch.UI.Window.SafeBoxItem = Witch.UI.Window.SafeBoxItem

---@param dataConfig DataConfig
function Witch.UI.Window.SafeBoxItem:Init(dataConfig) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SafeBoxItem:OnPointerEnter(eventData) end
function Witch.UI.Window.SafeBoxItem:DataUpdate() end
---@return string
function Witch.UI.Window.SafeBoxItem:CreateTooltipText() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SafeBoxItem:OnPointerClick(eventData) end
function Witch.UI.Window.SafeBoxItem:OnDestroy() end
---@param item SwapContentIdentity
function Witch.UI.Window.SafeBoxItem:AddToList(item) end
function Witch.UI.Window.SafeBoxItem:OnTransformParentChanged() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SafeBoxItem:OnPointerExit(eventData) end

---@class Witch.UI.Window.SafeBoxUI : Witch.UI.UIBase
---@field cardBack UnityEngine.Transform
---@field cardBox UnityEngine.Transform
---@field relicBox UnityEngine.Transform
---@field TopRelicPrefab UnityEngine.GameObject
---@field BottomRelicPrefab UnityEngine.GameObject
---@field tooltip Tooltip
---@field floatingWindow FloatingWindow
Witch.UI.Window.SafeBoxUI = {}
---@alias CS.Witch.UI.Window.SafeBoxUI Witch.UI.Window.SafeBoxUI
CS.Witch.UI.Window.SafeBoxUI = Witch.UI.Window.SafeBoxUI

function Witch.UI.Window.SafeBoxUI.SafeboxSave() end
function Witch.UI.Window.SafeBoxUI.ClearList() end
function Witch.UI.Window.SafeBoxUI.ResetCount() end
function Witch.UI.Window.SafeBoxUI:DataUpdate() end
function Witch.UI.Window.SafeBoxUI:RetainMoney() end
function Witch.UI.Window.SafeBoxUI:ChangeMoney() end
function Witch.UI.Window.SafeBoxUI:ChangeMoneyShow() end
function Witch.UI.Window.SafeBoxUI:ChangeCountShow() end
function Witch.UI.Window.SafeBoxUI:ShowBackItem() end
function Witch.UI.Window.SafeBoxUI:UpdateBackCard() end
function Witch.UI.Window.SafeBoxUI:UpdateBackRelic() end
function Witch.UI.Window.SafeBoxUI:ShowHadItems() end
---@param item Witch.UI.Window.SafeBoxItem
function Witch.UI.Window.SafeBoxUI:LoseItem(item) end
---@param obj UnityEngine.GameObject
function Witch.UI.Window.SafeBoxUI:PutIntoStore(obj) end
function Witch.UI.Window.SafeBoxUI:HideTooltip() end
---@param item Witch.UI.Window.SafeBoxItem
function Witch.UI.Window.SafeBoxUI:ShowFloatingWindow(item) end
---@param obj UnityEngine.GameObject
function Witch.UI.Window.SafeBoxUI:PutItBack(obj) end

---@class Witch.UI.Window.CurtainTurnUI : Witch.UI.UIBase
---@field CloseAnimation UIAnimation
---@field OpenAnimation UIAnimation
Witch.UI.Window.CurtainTurnUI = {}
---@alias CS.Witch.UI.Window.CurtainTurnUI Witch.UI.Window.CurtainTurnUI
CS.Witch.UI.Window.CurtainTurnUI = Witch.UI.Window.CurtainTurnUI

---@param action System.Action | function
function Witch.UI.Window.CurtainTurnUI:Play(action) end
function Witch.UI.Window.CurtainTurnUI:OnDestroy() end

---@class Witch.UI.Window.InkTurnUI : Witch.UI.UIBase
---@field SceneTurnMaterial UnityEngine.Material
---@field textures System.Collections.Generic.List
Witch.UI.Window.InkTurnUI = {}
---@alias CS.Witch.UI.Window.InkTurnUI Witch.UI.Window.InkTurnUI
CS.Witch.UI.Window.InkTurnUI = Witch.UI.Window.InkTurnUI

---@overload fun()
---@param firstUI System.Action | function
---@param secondUI System.Action | function
function Witch.UI.Window.InkTurnUI:Play(firstUI, secondUI) end
---@param firstUI System.Action | function
---@param secondUI System.Action | function
function Witch.UI.Window.InkTurnUI:FastPlay(firstUI, secondUI) end
function Witch.UI.Window.InkTurnUI:OnDestroy() end

---@class Witch.UI.Window.LoadingUI : Witch.UI.UIBase
Witch.UI.Window.LoadingUI = {}
---@alias CS.Witch.UI.Window.LoadingUI Witch.UI.Window.LoadingUI
CS.Witch.UI.Window.LoadingUI = Witch.UI.Window.LoadingUI

function Witch.UI.Window.LoadingUI:OnEnable() end
function Witch.UI.Window.LoadingUI:Close() end

---@class Witch.UI.Window.SceneTurnUI : Witch.UI.UIBase
Witch.UI.Window.SceneTurnUI = {}
---@alias CS.Witch.UI.Window.SceneTurnUI Witch.UI.Window.SceneTurnUI
CS.Witch.UI.Window.SceneTurnUI = Witch.UI.Window.SceneTurnUI

function Witch.UI.Window.SceneTurnUI:FadeIn() end
function Witch.UI.Window.SceneTurnUI:Close() end

---@class Witch.UI.Window.HardItem : UnityEngine.MonoBehaviour
---@field selectHardUI Witch.UI.Window.SelectHardUI
Witch.UI.Window.HardItem = {}
---@alias CS.Witch.UI.Window.HardItem Witch.UI.Window.HardItem
CS.Witch.UI.Window.HardItem = Witch.UI.Window.HardItem

---@param hardData System.Collections.Generic.Dictionary
function Witch.UI.Window.HardItem:Init(hardData) end

---@class Witch.UI.Window.SelectHardUI : Witch.UI.UIBase
---@field UseSc System.Collections.Generic.List
---@field AddReward number
---@field Level1Item UnityEngine.GameObject
---@field Level2Item UnityEngine.GameObject
---@field Level3Item UnityEngine.GameObject
Witch.UI.Window.SelectHardUI = {}
---@alias CS.Witch.UI.Window.SelectHardUI Witch.UI.Window.SelectHardUI
CS.Witch.UI.Window.SelectHardUI = Witch.UI.Window.SelectHardUI

function Witch.UI.Window.SelectHardUI:Init() end
function Witch.UI.Window.SelectHardUI:UpdataReward() end
function Witch.UI.Window.SelectHardUI:Hide() end
function Witch.UI.Window.SelectHardUI:OnDisable() end
function Witch.UI.Window.SelectHardUI:OnEnable() end
function Witch.UI.Window.SelectHardUI:CalCulateReward() end
---@param data System.Collections.Generic.Dictionary
function Witch.UI.Window.SelectHardUI:AddSc(data) end
---@param Id string
function Witch.UI.Window.SelectHardUI:RemoveSc(Id) end
function Witch.UI.Window.SelectHardUI:ReSetHard() end
function Witch.UI.Window.SelectHardUI:CreateItem() end

---@class Witch.UI.Window.SettingUI : Witch.UI.UIBase
---@field Active boolean
Witch.UI.Window.SettingUI = {}
---@alias CS.Witch.UI.Window.SettingUI Witch.UI.Window.SettingUI
CS.Witch.UI.Window.SettingUI = Witch.UI.Window.SettingUI

function Witch.UI.Window.SettingUI:Close() end
function Witch.UI.Window.SettingUI:DataUpdate() end
function Witch.UI.Window.SettingUI:Hide() end
function Witch.UI.Window.SettingUI:OnEnable() end
function Witch.UI.Window.SettingUI:CloseTheGame() end
function Witch.UI.Window.SettingUI:Save() end
function Witch.UI.Window.SettingUI:Apply() end

---@class Witch.UI.Window.OutsideShopItem : Witch.UI.Window.ItemNonDrag
---@field theData System.Collections.Generic.Dictionary
---@field selfType string
---@field outsiderShopUI Witch.UI.Window.OutsiderShopUI
Witch.UI.Window.OutsideShopItem = {}
---@alias CS.Witch.UI.Window.OutsideShopItem Witch.UI.Window.OutsideShopItem
CS.Witch.UI.Window.OutsideShopItem = Witch.UI.Window.OutsideShopItem

function Witch.UI.Window.OutsideShopItem:ShowTypeChange() end
function Witch.UI.Window.OutsideShopItem:DataUpdate() end
function Witch.UI.Window.OutsideShopItem:Init() end
function Witch.UI.Window.OutsideShopItem:TryBuy() end
function Witch.UI.Window.OutsideShopItem:UpdateItem() end

---@class Witch.UI.Window.SellItem : Witch.UI.Window.Item
---@field shop Witch.UI.Window.ShopUI
Witch.UI.Window.SellItem = {}
---@alias CS.Witch.UI.Window.SellItem Witch.UI.Window.SellItem
CS.Witch.UI.Window.SellItem = Witch.UI.Window.SellItem

---@param equipped boolean
---@param dataConfig DataConfig
function Witch.UI.Window.SellItem:Init(equipped, dataConfig) end
function Witch.UI.Window.SellItem:CheckEnch() end
---@return boolean
function Witch.UI.Window.SellItem:CanSell() end
function Witch.UI.Window.SellItem:TrySell() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SellItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SellItem:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SellItem:OnDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SellItem:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SellItem:OnEndDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.SellItem:OnPointerClick(eventData) end
function Witch.UI.Window.SellItem:ShowFloatingWindow() end
function Witch.UI.Window.SellItem:DataUpdate() end

---@class Witch.UI.Window.ShopItem : Witch.UI.Window.ItemNonDrag
---@field shop Witch.UI.Window.ShopUI
---@field dice Dice
Witch.UI.Window.ShopItem = {}
---@alias CS.Witch.UI.Window.ShopItem Witch.UI.Window.ShopItem
CS.Witch.UI.Window.ShopItem = Witch.UI.Window.ShopItem

---@overload fun(self: Witch.UI.Window.ShopItem, dataConfig: DataConfig)
function Witch.UI.Window.ShopItem:Init() end
function Witch.UI.Window.ShopItem:DataUpdate() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShopItem:OnPointerClick(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShopItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShopItem:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShopItem:OnDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShopItem:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.ShopItem:OnEndDrag(eventData) end
function Witch.UI.Window.ShopItem:TryBuy() end
function Witch.UI.Window.ShopItem:UpdateItem() end

---@class Witch.UI.Window.ShopUI : Witch.UI.UIBase
---@field currentItem Witch.UI.Window.ShopItem
---@field SellCardPrefab UnityEngine.GameObject
---@field TopRelicPrefab UnityEngine.GameObject
---@field flushedCount number
---@field maxFlushedCount number
---@field ShopTran UnityEngine.Transform
---@field flushmoneychange number
---@field ItemPrefab UnityEngine.GameObject
Witch.UI.Window.ShopUI = {}
---@alias CS.Witch.UI.Window.ShopUI Witch.UI.Window.ShopUI
CS.Witch.UI.Window.ShopUI = Witch.UI.Window.ShopUI

function Witch.UI.Window.ShopUI:DataUpdate() end
function Witch.UI.Window.ShopUI:CreateSellCard() end
function Witch.UI.Window.ShopUI:UpdateSellRelic() end
function Witch.UI.Window.ShopUI:Flushed() end
function Witch.UI.Window.ShopUI:ChangeFlushShow() end
function Witch.UI.Window.ShopUI:SetShopItems() end
---@param sender System.Object
---@param args System.ComponentModel.PropertyChangedEventArgs
function Witch.UI.Window.ShopUI:OnRoleTableChanged(sender, args) end
function Witch.UI.Window.ShopUI:UpdateSellCard() end
---@param obj UnityEngine.GameObject
function Witch.UI.Window.ShopUI:AnimationPlay(obj) end
function Witch.UI.Window.ShopUI:OnDestroy() end
function Witch.UI.Window.ShopUI:UpdateAllItems() end

---@class Witch.UI.Window.StorehouseUI : Witch.UI.UIBase
---@field TempItem UnityEngine.GameObject
---@field ListTransform UnityEngine.Transform
---@field thiscurrentItem Witch.UI.Window.StorehouseItem
---@field TypeMap System.Collections.Generic.Dictionary
Witch.UI.Window.StorehouseUI = {}
---@alias CS.Witch.UI.Window.StorehouseUI Witch.UI.Window.StorehouseUI
CS.Witch.UI.Window.StorehouseUI = Witch.UI.Window.StorehouseUI

function Witch.UI.Window.StorehouseUI:OnEnable() end
function Witch.UI.Window.StorehouseUI:CreateCardList() end
---@param Data DataConfig
---@param isCard boolean
function Witch.UI.Window.StorehouseUI:CreateItem(Data, isCard) end
---@param item Witch.UI.Window.StorehouseItem
function Witch.UI.Window.StorehouseUI:SetCurrentItem(item) end
function Witch.UI.Window.StorehouseUI:ExitCureentItem() end
function Witch.UI.Window.StorehouseUI:SetDescription() end
function Witch.UI.Window.StorehouseUI:HideDescription() end

---@class Witch.UI.Window.WarehouseItem : Witch.UI.Window.Item
---@field Inwarehouse boolean
---@field warehouseUI Witch.UI.Window.WarehouseUI
Witch.UI.Window.WarehouseItem = {}
---@alias CS.Witch.UI.Window.WarehouseItem Witch.UI.Window.WarehouseItem
CS.Witch.UI.Window.WarehouseItem = Witch.UI.Window.WarehouseItem

---@param isware boolean
---@param equipped boolean
---@param dataConfig DataConfig
function Witch.UI.Window.WarehouseItem:Init(isware, equipped, dataConfig) end
function Witch.UI.Window.WarehouseItem:DataUpdate() end
function Witch.UI.Window.WarehouseItem:TryMove() end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.WarehouseItem:OnPointerEnter(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.WarehouseItem:OnPointerExit(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.WarehouseItem:OnDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.WarehouseItem:OnBeginDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.WarehouseItem:OnEndDrag(eventData) end
---@param eventData UnityEngine.EventSystems.PointerEventData
function Witch.UI.Window.WarehouseItem:OnPointerClick(eventData) end

---@class Witch.UI.Window.WarehouseUI : Witch.UI.UIBase
---@field withCardParent UnityEngine.Transform
---@field warehouseParent UnityEngine.Transform
---@field withRelicParent UnityEngine.Transform
Witch.UI.Window.WarehouseUI = {}
---@alias CS.Witch.UI.Window.WarehouseUI Witch.UI.Window.WarehouseUI
CS.Witch.UI.Window.WarehouseUI = Witch.UI.Window.WarehouseUI

function Witch.UI.Window.WarehouseUI.ResetCount() end
function Witch.UI.Window.WarehouseUI:OnEnable() end
function Witch.UI.Window.WarehouseUI:ShowCard() end
---@param itemType string
---@param isGet boolean
---@return boolean
function Witch.UI.Window.WarehouseUI:MoveCheck(itemType, isGet) end
function Witch.UI.Window.WarehouseUI:ShowRelic() end

---@class Witch.UI.Window.EmojiPanelUI : Witch.UI.UIBase
---@field EmojiPrefab UnityEngine.Transform
Witch.UI.Window.EmojiPanelUI = {}
---@alias CS.Witch.UI.Window.EmojiPanelUI Witch.UI.Window.EmojiPanelUI
CS.Witch.UI.Window.EmojiPanelUI = Witch.UI.Window.EmojiPanelUI

function Witch.UI.Window.EmojiPanelUI:CreateEmoji() end
function Witch.UI.Window.EmojiPanelUI:Start() end
---@overload fun(self: Witch.UI.Window.EmojiPanelUI, gifAsset: GifAsset)
---@param uiAnimation UIAnimation
function Witch.UI.Window.EmojiPanelUI:ShowEmoji(uiAnimation) end

---@class BugReporter.BugReporter : System.Object
BugReporter.BugReporter = {}
---@alias CS.BugReporter.BugReporter BugReporter.BugReporter
CS.BugReporter.BugReporter = BugReporter.BugReporter

---@param error System.Exception
function BugReporter.BugReporter.ShowError(error) end
---@return Cysharp.Threading.Tasks.UniTask
function BugReporter.BugReporter.InitSupabase() end

---@class BugReporter.BugReporter.ErrorMessage : System.Object
---@field playerid string
---@field message string
---@field stackTrace string
---@field isSolved boolean
---@field note string
BugReporter.BugReporter.ErrorMessage = {}
---@alias CS.BugReporter.BugReporter.ErrorMessage BugReporter.BugReporter.ErrorMessage
CS.BugReporter.BugReporter.ErrorMessage = BugReporter.BugReporter.ErrorMessage

---@overload fun(error: System.Exception) : BugReporter.BugReporter.ErrorMessage
---@return BugReporter.BugReporter.ErrorMessage
function BugReporter.BugReporter.ErrorMessage.New() end

---@class BugReporter.BugReporter.ErrorSelection : Supabase.Postgrest.Models.BaseModel
---@field data string
BugReporter.BugReporter.ErrorSelection = {}
---@alias CS.BugReporter.BugReporter.ErrorSelection BugReporter.BugReporter.ErrorSelection
CS.BugReporter.BugReporter.ErrorSelection = BugReporter.BugReporter.ErrorSelection

---@return BugReporter.BugReporter.ErrorSelection
function BugReporter.BugReporter.ErrorSelection.New() end

---@class Witch_ProcessedByFody : System.Object
Witch_ProcessedByFody = {}
---@alias CS.Witch_ProcessedByFody Witch_ProcessedByFody
CS.Witch_ProcessedByFody = Witch_ProcessedByFody




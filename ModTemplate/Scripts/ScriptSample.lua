-- Playground
---@type CS.ScriptExecutor
self = self; -- 仅用于类型提示

-- SetStatus 规则为：[范围][类型]
-- 类型：
-- Self:自身
-- Target:目标
-- Friend:友军

-- 范围：
-- All:所有
-- AllRandom[count]:随机count个

-- 例子：
-- AllFriend:所有友军
-- All:所有
-- AllRandom[count]:随机count个
-- AllRandomEnemy[count]:随机count个敌人
-- AllRandomFriend[count]:随机count个友军
-- AllRandom[count]:随机count个
-- AllRandomFriend[count]:随机count个友军

self:SetStatus("Self") -- 设置效果对象为自身

self:SetStatus("Target") -- 设置效果对象为目标

self:SetStatus("All") -- 设置效果对象为所有


self:SetStatus("AllRandomEnemy2") -- 设置效果对象为随机两名敌人


self:AddBuff(DataId.buff_bleeding, "10"); -- 获得十层流血

self:RemoveBuff(DataId.buff_bleeding); -- 移除流血

self:RunImmediately(DataId.buff_bleeding, "OnLevelChange"); -- 立即触发流血层数变化事件

self:AddCardByCardList("1", "Burnout"); -- 从牌库中检索一张焚毁牌到手牌

self:AddEvent("Action", function ()
    self:AddBuff(DataId.buff_bleeding, "10"); -- 每次行动时获得十层流血
end);
for i = 1, 10 do
    self:DoAction(i); -- 执行第i次行动
end

self:EventTrigger("Action"); -- 触发Action事件

ScriptExecutor.PlayerInfo.AddBless(DataId.blessing_1); -- 玩家获得祝福

self:AddEvent("Action", function(fromdata) fromdata.data.scriptExecutor:RunScript("UseScript") end)
self:AddEvent("Hurt", function(fromdata) self:ChangeMoney(fromdata.val) end)

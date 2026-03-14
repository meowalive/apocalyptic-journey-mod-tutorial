-- 模组加载入口
function ModConfig:Setup()
    --self:RplaceCareer() -- 替换职业资源
    self:AddMethodHookBefore("SettingUI.OnEnable", Test) -- 添加方法钩子
end

function ModConfig:RplaceCareer()
    local Debug = CS.UnityEngine.Debug;
    Debug.Log("[Slay-Defect]资源已替换。") -- 替换职业资源
    self:ReplaceAnimationLib("Idle", "Idle") -- 替换职业待机动画
    self:ReplaceAnimationLib("Attack", "Attack") -- 替换职业攻击动画
    self:ReplaceAnimationLib("Skill", "Skill") -- 替换职业技能动画
    self:ReplaceAnimationLib("Hit", "Hit") -- 替换职业受击动画
    self:ModifyDataConfig("career_3", "Name", "故障机器人") -- 修改职业名称
end

function ModConfig:ReplaceAnimationLib(name)
    self:RedirectSourcePath("AnimationLib/支配魔女/"..name, "Mods/ModTemplate/ModResource/AnimationLib/Defect/"..name)
end

function Test()
    local Debug = CS.UnityEngine.Debug;
    Debug.Log("[ModTemplate]测试方法被调用了！检测到设置菜单开启")
end
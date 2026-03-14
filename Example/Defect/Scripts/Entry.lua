-- 模组加载入口
function ModConfig:Setup()
    self:AddMethodHookBefore("SettingUI.OnEnable", function ()
        CS.Commands.Log("Defect", "测试SettingUI.OnEnable")
    end)
end
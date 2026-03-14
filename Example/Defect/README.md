# Mod 编写手册

## 1. 快速开始
- 复制 `ModTemplate`，重命名为你的 Mod 目录（目录名必须与 `ModName` 一致）。
- 修改 `ModConfig.json`：
  - `ModName`：模组名
  - `ModAuthor`：作者名
  - `ModVersion`：版本
  - `ModDescription`：描述
  - `IconPath`：图标路径（通常 `Icon.png`）
  - `Enabled`：是否启用
  - `Dependencies`（可选）：依赖列表，格式 `ModName.ModAuthor`

## 2. 目录约定
- `Scripts/Entry.lua`：入口脚本，加载时执行。
- `Data/`：新增的数值配置表。
- `Text/`：新增的文本配置表。
- `ModResource/`：资源文件（图片、动画等）。

## 3. 入口脚本写法
- 推荐入口：`function ModConfig:Setup() ... end`
- 你可以在 `Setup` 内进行三类操作：
  - 改表：`ModifyDataConfig` / `SetDataConfig`
  - 资源重定向：`RedirectSourcePath`
  - 方法 Hook：`AddMethodHookBefore` / `AddMethodHookAfter`

示例：
```lua
function ModConfig:Setup()
  self:ModifyDataConfig("career_3", "Name", "故障机器人")
  self:RedirectSourcePath("AnimationLib/支配魔女/Idle", "Mods/YourMod/ModResource/AnimationLib/Defect/Idle")
  self:AddMethodHookBefore("SettingUI.OnEnable", function(ctx)
    CS.UnityEngine.Debug.Log("[YourMod] SettingUI.OnEnable")
  end)
end
```

## 4. 可用 Lua API（self/ModConfig）
- `SetDataConfig(id, table)`：批量改一行（不会改 `Id` 字段）。
- `ModifyDataConfig(id, key, value)`：改单个字段。
- `RedirectSourcePath(originalPath, newPath)`：重定向资源路径。
- `AddDynamicMethod(methodName, fn)`：注册全局 Lua 方法。
- `AddMethodHookBefore(typeDotMethod, fn)`：前置 Hook。
- `AddMethodHookAfter(typeDotMethod, fn)`：后置 Hook。

## 5. Data/Text CSV 规则
- 表头（第 1 行）必须与主工程对应 CSV 一致。
- 注释（第 2 行）用于字段说明，建议保留。
- *Data*中是物体效果配置，*Text*中是文本及其本地化配置
- 带*Script*后缀的是脚本列，需要填写*lua*逻辑，self为ScriptExecutor类型。
- 带*_en*等后缀的是本地化列，目前游戏支持*_en,_zh_hant,_jp*


## 6. 物品编纂规则
- 游戏加载时，会读取根目录*Data*和*Text*下的表，并将同名表进行合并处理。
- 物品在游戏内的Id组成规则为：`ModName_FileName_Id`，因此，在Data和Text中无法进行覆盖操作，只能进行新增。
- 若Id带`*`，则不会进入游戏随机池中，否则将正常进入池子。
- 效果编纂教程规则令见-> [C#版效果编纂教程](https://www.cnblogs.com/DLSinnocence/articles/18948776)
- 注意，Mod只能识别lua脚本，需要将其中的C#语法改为Lua版本。如调用`AddBuff(buffId, level)`时改为`self:AddBuff(buffId, level)`
- 更多的Lua语法详见->[Lua教程](https://www.runoob.com/lua/lua-basic-syntax.html)
- 完整的游戏配置请见-> [网页版](https://dlsinnocence.github.io/gamewiki/) [本地版](Scripts/Lib/DataConfigs)
- 原版效果示例->Scripts/Lib/DataConfigs（是C#语言的，仅供参考，mod必须用lua编纂）
- 脚本里引用原版Id使用DataId.Id,引用ModId直接写字面量。
- 卡牌必须设定BaseScript是AttackCard还是CommonCard（是否选目标）。
- 卡牌的持续性效果需要写成Buff。

## 7. 常见问题
- Mod 未生效
  - 检查 `ModConfig.json` 的 `Enabled` 是否为 `true`，以及依赖是否正确。
- 无法设置字典
  - 字符串字典不能用[]访问，必须用dict:get_Item  dict:set_Item等，详情参考Xlua。
- 资源路径是什么？
  - Mod路径为Mods/<你的Mod名>/……
  - 原版路径请参考游戏配置表。
- Id为什么有的带星号有的没有？
  - 区别于是否进池子，有些绝对不会随机获得到的（如职业卡）要加星号。

## 8. 快速开始
1. 删掉*Data*和*Text*中的文件夹，只留下`Card`
2. 打开`Data`和`Text`下的表格，尝试参照ScriptExecutor类编写效果。


更多请参见本例子，尝试编写你的第一个Mod吧！
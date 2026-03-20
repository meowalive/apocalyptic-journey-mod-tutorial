# DllTemplate

基于C#的的Hook

## 使用说明

- 项目文件在Dev文件夹下，发布时不需要

- 编译时，修改.csproj，将**GamePath**改为你的游戏目录

![alt text](/Assets/image.png)

- 建议使用Rider或者VSCODE进行编译

- 使用方式：**dotnet build**后将编译出的dll改名为Entry.dll拖入Scripts文件夹下

## 特性

- 基于属性的**Hook**：支持**HookBefore**与**HookAfer**

- 完整的代码补全

- 更好的C#语言特性支持

- **不支持跨平台**
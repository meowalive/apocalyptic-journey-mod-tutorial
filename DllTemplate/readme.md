# DllTemplate

基于C#的的Hook

## 环境配置

- 项目文件在Dev文件夹下，发布时不需要留

- 编译时，修改.csproj，将**GamePath**改为你的游戏目录

![alt text](/Assets/image.png)

- 建议使用Rider或者VSCODE进行编译



## 特性

- 基于属性的**Hook**：支持**HookBefore**与**HookAfter**

- 完整的代码补全

- 更好的C#语言特性支持

- **不支持跨平台**

## 开始使用

- 在mod的入口处方法标记**ModInitialize**

- 在你想要作为Hook的方法上加上属性**HookBefore**或**HookAfter**

- Patch的方法必须为静态，若要Patch实例方法，第一个参数默认为其实例。

- Patch的方法参数可以不全，但必须保证顺序

- 使用方式：**dotnet build**后将编译出的dll改名为Entry.dll拖入Scripts文件夹下
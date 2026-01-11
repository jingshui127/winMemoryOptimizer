# winMemoryOptimizer

[![Release (latest)](https://img.shields.io/github/v/release/sergiye/winMemoryOptimizer)](https://github.com/sergiye/winMemoryOptimizer/releases/latest)
[![Downloads](https://img.shields.io/github/downloads/sergiye/winMemoryOptimizer/total?color=ff4f42)](https://github.com/sergiye/winMemoryOptimizer/releases)
[![GitHub last commit](https://img.shields.io/github/last-commit/sergiye/winMemoryOptimizer?color=00AD00)](https://github.com/sergiye/winMemoryOptimizer/commits/master)
[![](https://img.shields.io/badge/WINDOWS-7%20%E2%80%93%2011-blue)](https://endoflife.date/windows) 
[![](https://img.shields.io/badge/SERVER-2012%20%E2%80%93%202025-blue)](https://endoflife.date/windows-server) 

winMemoryOptimizer 使用Windows原生功能来清理和优化内存区域。有时，程序不会释放分配的内存，导致计算机变慢。这时你需要优化内存，这样你就可以继续工作而不必浪费时间重启系统。

这个工具的灵感来自 [Igor Mundstein 的 WinMemoryCleaner 项目](https://github.com/IgorMundstein/WinMemoryCleaner)。
主要想法是创建一个超级简约、便携且功能齐全的应用程序。

该应用没有UI，只有通知图标。
它是便携式的，不需要安装，但需要管理员权限才能运行。点击下面的下载按钮并运行可执行文件即可开始使用。


## 它看起来是什么样的？

以下是应用程序在Windows 10（浅色/深色主题）上运行的示例：

[<img src="https://github.com/sergiye/winMemoryOptimizer/raw/master/preview.png" alt="preview"/>](https://github.com/sergiye/winMemoryOptimizer/raw/master/preview.png)

以及优化完成后应用通知的预览：

[<img src="https://github.com/sergiye/winMemoryOptimizer/raw/master/preview_notification.png" alt="preview_notification"/>](https://github.com/sergiye/winMemoryOptimizer/raw/master/preview_notification.png)

## 下载最新版本

已发布的版本可以从 [releases](https://github.com/sergiye/winMemoryOptimizer/releases) 页面获取，或直接从以下链接获取更新版本：
[最新版本](https://github.com/sergiye/winMemoryOptimizer/releases/latest)

## 功能特性

### 自动优化

- `每 X 小时` 按周期运行优化
- `当可用内存低于 X% 时` 当可用内存低于指定百分比时运行优化

### 设置选项

- `开机自启动` 系统启动后运行应用。它会在Windows **任务计划程序**中创建一个条目
- `显示优化通知` 优化后向通知区域发送消息，包括释放的大约内存量
- `显示虚拟内存` 同时监控虚拟内存使用情况
- `以低优先级运行` 通过降低进程优先级来限制应用资源使用，确保高效运行。这可能会增加优化时间，但如果Windows在优化过程中冻结，这会有所帮助
- `自动更新应用` 保持应用程序更新到最新版本

### 内存区域

- `合并页列表` 仅在启用页面合并时有效刷新合并页列表中的块
- `修改页列表` 从修改页列表中刷新内存，将未保存的数据写入磁盘并将页面移至备用列表
- `进程工作集` 从所有用户模式和系统工作集中移除内存，并将其移至备用或修改页列表
- `备用列表` 将所有备用列表中的页面刷新到可用列表
- `备用列表（低优先级）` 将最低优先级备用列表中的页面刷新到可用列表
- `系统工作集` 从系统缓存工作集中移除内存
- `修改的文件缓存` 为所有固定驱动器将卷文件缓存刷新到磁盘，确保所有挂起的写入都已提交
- `系统文件缓存` 刷新Windows用于系统文件的缓存，对其进行剪裁以释放内存。在启动内存密集型应用程序之前刷新系统状态很有用
- `注册表缓存` 从内存中刷新注册表配置单元。配置单元是在OS启动或用户登录时加载到内存中的键和值的逻辑组

<!-- ### 排除优化的进程
- 您可以构建一个在优化内存时忽略的进程列表 -->

### 托盘图标类型

- `图像` 显示应用图标
- `内存使用率` 显示物理内存使用率（百分比）
- `可用内存` 显示可用物理内存（GB）
- `已用内存` 显示已用物理内存（GB）

托盘图标提示也取决于所选的`图标类型`，但如果勾选了`显示虚拟内存`选项，则可以包含虚拟内存值。

## 日志

应用程序在Windows事件中生成日志

1. 按 **Win + R** 打开运行命令对话框
2. 输入 **eventvwr** 并按 **Enter** 打开事件查看器
3. 打开 `Windows 日志` -> `应用程序`


## 常见问题 (FAQ)

### 为什么应用程序被标记为恶意软件/病毒并被Windows Defender、SmartScreen或防病毒软件阻止？

这种**误报**的原因之一是应用程序向注册表和任务计划程序添加条目，以便在启动时运行应用程序。Windows不"喜欢"具有管理员权限的应用程序在启动时运行。抱歉，但应用程序无法在没有管理员权限的情况下深度清理内存。

这是一个常见问题，每次发布新版本时都会出现。
每个人都可以将可执行文件提交给Microsoft，通常Microsoft需要最多72小时来移除检测。
如果更多用户 [提交应用程序进行恶意软件分析](https://www.microsoft.com/zh-cn/wdsi/filesubmission)，会有所帮助

同时，您可以 [向Windows安全中心添加排除项](https://support.microsoft.com/zh-cn/windows/add-an-exclusion-to-windows-security-811816c0-4dfd-af4a-47e4-c301afe13b26) 作为解决方法

## 我如何帮助改进它？
winMemoryOptimizer团队欢迎反馈和贡献！<br/>
您可以检查它在您的PC上是否正常工作。如果您发现任何不准确之处，请发送拉取请求。如果您有任何建议或改进，请随时创建问题。

另外，不要忘记 ★ star ★ 该存储库，以帮助其他人找到它。

<!-- [![Star History Chart](https://api.star-history.com/svg?repos=sergiye/winMemoryOptimizer&type=Date)](https://star-history.com/#sergiye/winMemoryOptimizer&Date) -->

<!-- [//]: # ([![Stargazers over time]&#40;https://starchart.cc/sergiye/winMemoryOptimizer.svg?variant=adaptive&#41;]&#40;https://starchart.cc/sergiye/winMemoryOptimizer&#41;) -->

[![Stargazers](https://reporoster.com/stars/sergiye/winMemoryOptimizer)](https://star-history.com/#sergiye/winMemoryOptimizer&Date)

<!-- [![Forkers](https://reporoster.com/forks/sergiye/winMemoryOptimizer)](https://github.com/sergiye/winMemoryOptimizer/network/members) -->

## 捐赠！
您捐赠的每一杯 [咖啡](https://patreon.com/SergiyE) 都将帮助这个应用变得更好，并让我知道这个项目有需求。

## 许可证
本程序是自由软件：您可以根据自由软件基金会发布的GNU通用公共许可证第3版或（根据您的选择）任何更高版本的条款重新分发和/或修改它。

本程序的分发是希望它能有用，但不提供任何保证；甚至没有适销性或特定用途适用性的暗示保证。有关更多详细信息，请参阅GNU通用公共许可证。

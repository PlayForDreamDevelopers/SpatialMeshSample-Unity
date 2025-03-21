[![en](https://img.shields.io/badge/lang-en-red.svg)](./README.md)

<!--
请先阅读此文档！！！！
将以下占位符替换为实际值：
    - {{PROJECT_REPO_URL}}: 项目仓库的URL
    - {{DocumentationURL}}: 项目文档的URL，尽可能使用docfx生成的GitHub Pages
    - {{BriefDescription}}: 项目简介
    - {SampleURL}: 示例项目的URL，对于包项目，应为示例仓库的URL。如果包项目有多个示例，请链接到“关于项目”部分的“示例”标题。
    - {BugIssueURL}: 报告错误问题的URL
      - 例如：https://github.com/PlayForDreamDevelopers/unity-template/issues/new?template=bug_report.yml
    - {FeatureIssueURL}: 请求功能问题的URL
      - 例如：https://github.com/PlayForDreamDevelopers/unity-template/issues/new?template=feature_request.yml
    - {DocumentationIssueURL}: 文档问题的URL
      - 例如：https://github.com/PlayForDreamDevelopers/unity-template/issues/new?template=documentation_update.yml
-->

<br />
<div align="center">
    <a href="{{PROJECT_REPO_URL}}">
        <img src="https://www.pfdm.cn/en/static/img/logo.2b1b07e.png" alt="Logo" width="20%">
    </a>
    <h1 align="center">Mesh 使用示例</h1>
    <p align="center">
        包含一些 Mesh 功能的示例
        <br />
        <a href="https://github.com/PlayForDreamDevelopers/SpatialMeshSample-Unity/blob/main/README.md"><strong>查看文档 »</strong></a>
        <br />
        <br />
        <a href="https://github.com/PlayForDreamDevelopers/SpatialMeshSample-Unity">查看示例</a>
        &middot;
        <a href="https://github.com/PlayForDreamDevelopers/SpatialMeshSample-Unity/issues/new?labels=bug">报告错误</a>
        &middot;
        <a href="https://github.com/PlayForDreamDevelopers/SpatialMeshSample-Unity/issues/new?labels=enhancemen">请求功能</a>
    </p>

</div>

> [!tip]
> 
> Mesh Minimal Sample 依赖 Geometry Shader，需要将渲染模式修改为 Multi Passes。
>
> 请确保你使用的 Tracking Mode 是 Floor。如果你使用的是 Device Tracking Mode，你需要为生成的 Mesh 手动增加与 Device Tracking Mode 下相同的 Y Offset。

## 关于项目

包含一些 Mesh 功能的示例

### 示例

包含以下关于 Mesh 功能的示例：
<!-- 链接到第一个示例项目 -->
### 线框方式实时绘制
[Mesh Minimal Sample](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/tree/main/Assets/MeshMinimalSample)：以线框方式实时绘制 Mesh

![2025 03 04_142114528](https://github.com/user-attachments/assets/26b63e4f-bb91-4e28-8406-f665c7bad031)
<!-- 链接到第二个示例项目 -->

## 要求

<!-- 项目要求：
    Unity版本，依赖的 Unity Package 等，如果 Unity Package 有 Mirror 仓库的话，需要链接到该仓库的地址。
-->
- Unity 2022.3.52f1 或者更新的版本
- Unity 包：
  - [YVR Core](https://github.com/PlayForDreamDevelopers/com.yvr.core-mirror)
  - [YVR Utilities](https://github.com/PlayForDreamDevelopers/com.yvr.Utilities-mirror)
# Mesh 示例

[![us](https://img.shields.io/badge/lang-us-red.svg)](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/blob/main/README.md)

包含以下关于 Mesh 功能的示例：

1. [Mesh Minimal Sample](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/tree/main/Assets/MeshMinimalSample)：以线框方式实时绘制 Mesh

    ![2025 03 04_142114528](https://github.com/user-attachments/assets/26b63e4f-bb91-4e28-8406-f665c7bad031)

## 注意事项

1. Mesh Minimal Sample 依赖 Geometry Shader，需要将渲染模式修改为 Multi Passes。

## FAQ

### 为何我看到的 Mesh 与真实环境存在偏移量

请确保你使用的 Tracking Mode 是 Floor。如果你使用的是 Device Tracking Mode，你需要为生成的 Mesh 手动增加与 Device Tracking Mode 下相同的 Y Offset。

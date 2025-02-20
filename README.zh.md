# Mesh 示例

包含以下关于 Mesh 功能的示例：

1. Mesh Minimal Sample：以线框方式实时绘制 Mesh

注意事项：

1. 目前 Mesh 坐标的获取始终处于 Floor Tracking Space 下，因此需保证 XR Origin `Tracking Origin Mode` 为 Floor。
   - 该限制在后续版本会移除。
2. Mesh Minimal Sample 依赖 Geometry Shader，需要将渲染模式修改为 Multi Passes。
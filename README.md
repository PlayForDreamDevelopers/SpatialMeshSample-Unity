# Mesh Sample

[![zh]](https://img.shields.io/badge/%E4%B8%AD%E6%96%87%E6%96%87%E6%A1%A3-%E7%82%B9%E5%87%BB%E6%9F%A5%E7%9C%8B-blue.svg)(https://github.com/PlayForDreamDevelopers/MeshSample-Unity/README.zh.md)

Includes the following examples of Mesh functionality:

1. [Mesh Minimal Sample](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/tree/main/Assets/MeshMinimalSample):
   Real-time wireframe rendering of Mesh

Notes:

1. Currently, the coordinates of the Mesh are always obtained in Floor Tracking Space, so ensure that the XR
   Origin `Tracking Origin Mode` is set to Floor.
    - This limitation will be removed in future versions.
2. Mesh Minimal Sample relies on Geometry Shader, so the rendering mode needs to be set to Multi Passes.
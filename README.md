# Mesh Sample

[![zh](https://img.shields.io/badge/lang-zh-blue.svg)](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/blob/main/README.zh.md)

Includes the following examples of Mesh functionality:

1. [Mesh Minimal Sample](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/tree/main/Assets/MeshMinimalSample):
   Real-time wireframe rendering of Mesh

Notes:

1. Currently, the coordinates of the Mesh are always obtained in Floor Tracking Space, so ensure that the XR
   Origin `Tracking Origin Mode` is set to Floor.
    - This limitation will be removed in future versions.
2. Mesh Minimal Sample relies on Geometry Shader, so the rendering mode needs to be set to Multi Passes.
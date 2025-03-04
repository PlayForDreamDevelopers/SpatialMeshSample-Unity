# Mesh Sample

[![zh](https://img.shields.io/badge/lang-zh-blue.svg)](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/blob/main/README.zh.md)

Includes the following examples of Mesh functionality:

1. [Mesh Minimal Sample](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/tree/main/Assets/MeshMinimalSample):
   Real-time wireframe rendering of Mesh

    ![2025 03 04_142114528](https://github.com/user-attachments/assets/26b63e4f-bb91-4e28-8406-f665c7bad031)

## Notes

1. Mesh Minimal Sample relies on Geometry Shader, so the rendering mode needs to be set to Multi Passes.

## FAQ

### Why does the Mesh I see have an offset from the real environment?

Make sure you are using the Floor Tracking Mode. If you are using the Device Tracking Mode, you need to manually add the same Y Offset as the Device Tracking Mode to the generated Mesh.

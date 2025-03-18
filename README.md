[![zh](https://img.shields.io/badge/lang-zh-blue.svg)](./README.zh.md)

<!--
READ ME FIRST !!!!!!
Replace the following placeholders with the actual values:
    - {{PROJECT_REPO_URL}}: URL of the project repository
    - {{Project Name}}: Name of the project
    - {{DocumentationURL}}: URL of the project documentation, Use github pages with docfx if possible
    - {{BriefDescription}}: Brief description about the project
    - {SampleURL}: URL of the sample project, for package projects, it should be sample repository URL. If a package projects has multiple samples, then link to `Samples` header of the `About The Project` section.
    - {BugIssueURL}: URL of the bug reporting issue template
      - i.e.  https://github.com/PlayForDreamDevelopers/unity-template/issues/new?template=bug_report.yml
    - {FeatureIssueURL}: URL of the feature request issue template
      - i.e. https://github.com/PlayForDreamDevelopers/unity-template/issues/new?template=feature_request.yml
    - {DocumentationIssueURL}: URL of the documentation issue template
      - i.e. https://github.com/PlayForDreamDevelopers/unity-template/issues/new?template=documentation_update.yml
-->

<br />
<div align="center">
    <a href="">
        <img src="https://www.pfdm.cn/en/static/img/logo.2b1b07e.png" alt="Logo" width="20%">
    </a>
    <h1 align="center"> Mesh Sample </h1>
    <p align="center">
        Contains examples of some Mesh features
        <br />
        <a href="https://github.com/PlayForDreamDevelopers/SpatialMeshSample-Unity/blob/main/README.md"><strong>View Documentation »</strong></a>
        <br />
        <br />
        <a href="https://github.com/PlayForDreamDevelopers/SpatialMeshSample-Unity">View Samples</a>
        &middot;
        <a href="https://github.com/PlayForDreamDevelopers/SpatialMeshSample-Unity/issues/new?labels=bug">Report Bug</a>
        &middot;
        <a href="https://github.com/PlayForDreamDevelopers/SpatialMeshSample-Unity/issues/new?labels=enhancemen">Request Feature</a>
    </p>

</div>

<!-- Add callouts here if required-->
> [!tip]
> 
> Mesh Minimal Sample Depend on Geometry Shader, you need to change the rendering mode to Multi Passes.
>
> Make sure you are using Floor for your Tracking Mode.  If you are using Device Tracking Mode, you need to manually add the same Y Offset to the generated Mesh as you do for Device Tracking Mode.


## About The Project

Contains examples of some Mesh features

### Samples

Include the following examples of Mesh functionality:
<!-- Link to first sample project -->
1. [Mesh Minimal Sample](https://github.com/PlayForDreamDevelopers/MeshSample-Unity/tree/main/Assets/MeshMinimalSample)：Draw the Mesh in real time in wireframe mode

    ![2025 03 04_142114528](https://github.com/user-attachments/assets/26b63e4f-bb91-4e28-8406-f665c7bad031)
<!-- Link to second sample project -->

## Requirements

<!-- Requirements about the project:
    Unity version, Unity packages, etc.
    If the Unity package has a mirror repository, link to that repository.
    -->

- Unity 2022.3.52f1 or an updated version
- Unity Package:
  - [YVR Core](https://github.com/PlayForDreamDevelopers/com.yvr.core-mirror)
  - [YVR Utilities](https://github.com/PlayForDreamDevelopers/com.yvr.Utilities-mirror)
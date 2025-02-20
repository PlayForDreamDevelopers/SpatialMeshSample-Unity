using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.XR;
using YVR.Core;

namespace YVR.Samples.Mesh.Minimal
{
    public class MeshMinimalSample : MonoBehaviour
    {
        public GameObject meshPrefab;
        public Transform meshesParent;
        private static XRMeshSubsystem s_MeshSubsystem;
        private static List<MeshInfo> s_MeshInfos = new();
        private Dictionary<MeshId, MeshFilter> m_MeshId2GODict = new();

        private void Start()
        {
            PermissionRequest.instance.ScenePermissionRequest();
            YVRMeshTracking.instance.CreateMeshDetector();
            YVRPlugin.Instance.SetPassthrough(true);
            var meshSubsystems = new List<XRMeshSubsystem>();
            SubsystemManager.GetInstances(meshSubsystems);

            if (meshSubsystems.Count >= 1)
                s_MeshSubsystem = meshSubsystems[0];
            else
                Debug.LogError("Can not find any XRMeshSubsystem");
        }

        private void Update()
        {
            if (s_MeshSubsystem == null)
            {
                Debug.LogError("s_MeshSubsystem is null");
                return;
            }

            if (!s_MeshSubsystem.TryGetMeshInfos(s_MeshInfos)) return;

            int count = s_MeshInfos.Count;
            for (int i = 0; i != count; ++i)
            {
                MeshInfo info = s_MeshInfos[i];
                MeshChangeState state = info.ChangeState;
                if (state is MeshChangeState.Added or MeshChangeState.Updated)
                    HandleMeshAddedorUpdated(ref info);
                else if (state is MeshChangeState.Removed)
                    HandleMeshRemoved(ref info);
            }

            UpdateMeshTransform();
        }

        private void HandleMeshRemoved(ref MeshInfo meshInfo)
        {
            if (!m_MeshId2GODict.TryGetValue(meshInfo.MeshId, out MeshFilter meshGo)) return;
            Destroy(meshGo);
            m_MeshId2GODict.Remove(meshInfo.MeshId);
        }


        private void HandleMeshAddedorUpdated(ref MeshInfo meshInfo)
        {
            if (!m_MeshId2GODict.TryGetValue(meshInfo.MeshId, out MeshFilter meshFilter))
            {
                meshFilter = Instantiate(meshPrefab, meshesParent, false).AddComponent<MeshFilter>();
                m_MeshId2GODict[meshInfo.MeshId] = meshFilter;
            }

            UnityEngine.Mesh mesh = meshFilter.mesh;
            s_MeshSubsystem.GenerateMeshAsync(meshInfo.MeshId, mesh, null, MeshVertexAttributes.None, result =>
            {
                if (result.Status != MeshGenerationStatus.Success) return;
                Transform meshTrans = meshFilter.transform;
                if (meshTrans.position == result.Position) return;

                meshTrans.SetPositionAndRotation(result.Position, result.Rotation);
            }, MeshGenerationOptions.ConsumeTransform);
        }

        private void UpdateMeshTransform()
        {
            NativeArray<MeshTransform> meshTransforms = s_MeshSubsystem.GetUpdatedMeshTransforms(Allocator.Temp);
            foreach (MeshTransform item in meshTransforms)
            {
                if (!m_MeshId2GODict.TryGetValue(item.MeshId, out MeshFilter meshFilter)) continue;
                Transform meshTransform = meshFilter.transform;
                if (meshTransform.position == item.Position) continue;

                meshTransform.SetPositionAndRotation(item.Position, item.Rotation);
            }
        }
    }
}
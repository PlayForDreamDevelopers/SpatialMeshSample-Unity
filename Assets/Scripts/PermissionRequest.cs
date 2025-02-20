using UnityEngine;
using YVR.Utilities;

namespace YVR.Samples.Mesh
{
    public class PermissionRequest : Singleton<PermissionRequest>
    {
        public void ScenePermissionRequest()
        {
            const string spatialPermission = "com.yvr.permission.USE_SCENE";
            if (UnityEngine.Android.Permission.HasUserAuthorizedPermission(spatialPermission)) return;

            var callbacks = new UnityEngine.Android.PermissionCallbacks();
            callbacks.PermissionDenied += Denied;
            callbacks.PermissionGranted += Granted;
            UnityEngine.Android.Permission.RequestUserPermission(spatialPermission, callbacks);

            void Denied(string permission) => Debug.Log($"{permission} Denied");
            void Granted(string permission) => Debug.Log($"{permission} Granted");
        }
    }
}
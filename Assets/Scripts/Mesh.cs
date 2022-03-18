using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using Microsoft.MixedReality.Toolkit.XRSDK.OpenXR;
using UnityEngine;

public class Mesh : MonoBehaviour
{
    public void HideMesh()
    {
        //var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<OpenXRSpatialAwarenessMeshObserver>();

        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;
    }

    public void ShowMesh()
    {
        //var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<OpenXRSpatialAwarenessMeshObserver>();

        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
    }
}

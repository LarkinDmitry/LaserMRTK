using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using UnityEngine;

public class Mesh : MonoBehaviour
{
    public void HideMesh()
    {
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;
    }

    public void ShowMesh()
    {
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
    }
}

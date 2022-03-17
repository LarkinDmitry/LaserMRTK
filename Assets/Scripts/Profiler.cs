using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profiler : MonoBehaviour
{
    public void SetProfilerState(bool state)
    {
        CoreServices.DiagnosticsSystem.ShowProfiler = state;
    }
}

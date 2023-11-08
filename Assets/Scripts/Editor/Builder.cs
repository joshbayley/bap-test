using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Builder : MonoBehaviour
{
    public static void BuildWebGL()
    {
        var optionsWebGL = new BuildPlayerOptions
        {
            locationPathName = "/home/ubuntu/bap-test-webgl/",
            options = BuildOptions.None,
            target = BuildTarget.WebGL,
            scenes = new[] { "Assets/SampleScene.unity" }
        };

        BuildPipeline.BuildPlayer(optionsWebGL);
    }
}
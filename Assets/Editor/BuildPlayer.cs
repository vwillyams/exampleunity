#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;

namespace Editor
{

// Output the build size or a failure depending on BuildPlayer.

    public class BuildPlayer : MonoBehaviour
    {
        [MenuItem("Build/Build Android")]
        public static void MyBuild()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.locationPathName = "androidBuild";
            buildPlayerOptions.target = BuildTarget.Android;
            buildPlayerOptions.options = BuildOptions.None;
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.test");

            BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
            BuildSummary summary = report.summary;

            if (summary.result == BuildResult.Succeeded)
            {
                Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
            }

            if (summary.result == BuildResult.Failed)
            {
                Debug.Log("Build failed");
            }
        }
    }
}

#endif
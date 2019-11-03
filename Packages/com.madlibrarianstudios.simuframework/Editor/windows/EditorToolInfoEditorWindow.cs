using UnityEngine;
using UnityEditor;

public class EditorToolInfoEditorWindow : EditorWindow {



    private void OnGUI() {
                EditorGUILayout.Space();
        EditorGUILayout.LabelField("Time since start: ", EditorApplication.timeSinceStartup.ToString());
        EditorGUILayout.LabelField("application contents path: ", EditorApplication.applicationContentsPath.ToString());
        EditorGUILayout.LabelField("application path: ", EditorApplication.applicationPath.ToString());
        EditorGUILayout.LabelField("scripting runtime verision: ", EditorApplication.scriptingRuntimeVersion.ToString());
        EditorGUILayout.Separator();
    }
}
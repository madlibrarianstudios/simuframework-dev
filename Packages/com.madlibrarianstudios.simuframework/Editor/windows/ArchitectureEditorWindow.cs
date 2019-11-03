using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ArchitectureEditorWindow : EditorWindow {

    // [MenuItem("simuframework/ArchitectureWindow")]
    public static void ShowWindow() {
        var window = GetWindow<ArchitectureEditorWindow>();
        window.titleContent = new GUIContent("ArchitectureWindow");
        window.Show();
    }

    private void OnGUI() {
        GUILayout.Label("Architecture Working List", EditorStyles.boldLabel);
        GUILayout.Label("Singleton", EditorStyles.label);
        GUILayout.Label("ECS", EditorStyles.label);
        GUILayout.Label("Observer Pattern", EditorStyles.label);
        GUILayout.Label("MVC", EditorStyles.label);
       
  
    }
}


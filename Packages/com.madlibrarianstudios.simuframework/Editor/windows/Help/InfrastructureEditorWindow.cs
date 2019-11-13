using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;




public class InfrastructureEditorWindow : EditorWindow {

    // [MenuItem("simuframework/InfrastructureWindow")]


    private void OnGUI() {
                GUILayout.Label("Infrastructure-Systems", EditorStyles.boldLabel);
        GUILayout.Label("Game Manager System", EditorStyles.label);
        GUILayout.Label("Level Manager System", EditorStyles.label);
        GUILayout.Label("Questing System", EditorStyles.label);
        GUILayout.Label("Dialogue System", EditorStyles.label);
        GUILayout.Label("Inventory System", EditorStyles.label);
    }
}


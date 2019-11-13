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


// A. Assets
//         -creating folders
//         -creating scenes
//         -adding prefabs
        

// B. GameObject
//         -add runtime gameobjects
//             -game manager
//             -level manager
//             -audio manager
//         -Player
//         -Level

// C. Component
//         -menu building



// D. Unity, File, Edit, Window, and Help

// E. New Menu Item

//         All of the built in menus across the top (A,B,C, and D)
//         Right Click context menu for Hierachy window (B)
//         Right Click context menu for Project window (A)
//         Add Component Menu in Inspector when inspecting a GameObject (C)
//         New custom menus (E)
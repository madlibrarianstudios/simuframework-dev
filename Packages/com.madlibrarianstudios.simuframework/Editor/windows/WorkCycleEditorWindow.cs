using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WorkCycleEditorWindow : EditorWindow
{

    // [MenuItem("simuframework/WorkCycleWindow")]
    public static void ShowWindow()
    {
        var window = GetWindow<WorkCycleEditorWindow>();
        window.titleContent = new GUIContent("WorkCycleWindow");
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Work Cycle", EditorStyles.boldLabel);
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        GUILayout.Label("architecture", EditorStyles.boldLabel);
        GUILayout.Label("---create project folder structure ASSET", EditorStyles.label);
        GUILayout.Label("---add scene ASSET and game manager GAMEOBJECT", EditorStyles.label);
        GUILayout.Label("---(more) number of players", EditorStyles.label);
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        GUILayout.Label("infrastructure", EditorStyles.boldLabel);
            EditorGUILayout.Space();
        EditorGUILayout.Space();
        GUILayout.Label("level and gameplay management", EditorStyles.label);
        GUILayout.Label("---creating titlemaps", EditorStyles.label);
        GUILayout.Label("---constructing the level", EditorStyles.label);
        GUILayout.Label("---procedural generatle level ", EditorStyles.label);
        GUILayout.Label("---painting prefabs - prefab brush", EditorStyles.label);
        GUILayout.Label("---gameplay logic and timer for winning and losing level", EditorStyles.label);

      EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        GUILayout.Label("building the player ", EditorStyles.label);
        GUILayout.Label("---selecting player type", EditorStyles.label);
        GUILayout.Label("---animating player", EditorStyles.label);

      EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        GUILayout.Label("configuring camera, ui, lights", EditorStyles.label);
        GUILayout.Label("---creating the camera rig", EditorStyles.label);
        GUILayout.Label("---adding lights", EditorStyles.label);
        GUILayout.Label("---adding post processing", EditorStyles.label);
        GUILayout.Label("---adding camera shake", EditorStyles.label);
      EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        GUILayout.Label("Mix Audio Manager", EditorStyles.label);
        GUILayout.Label("---gameplay audio ", EditorStyles.label);
        GUILayout.Label("---Music, etc ", EditorStyles.label);
      EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        GUILayout.Label("polish and deployment ", EditorStyles.label);
        GUILayout.Label("---/build and stroage/ ", EditorStyles.label);
        GUILayout.Label("---/ops", EditorStyles.label);
        GUILayout.Label("---/analytics", EditorStyles.label);
        GUILayout.Label("---/advertisement", EditorStyles.label);

    }






}

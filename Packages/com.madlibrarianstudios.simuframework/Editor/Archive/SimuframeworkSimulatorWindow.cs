using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SimuframeworkSimulatorWindow : EditorWindow
{



    Texture2D headerSectionTexture;
    Texture2D ProjectTypeSectionTexture;
    Texture2D ArchitectureSelectSectionTexture;

    Color headerSectionColor = new Color(13f / 255f, 32f / 255f, 44f / 255f, 1f);
    Color ProjectTypeSectionColor = new Color(13f / 255f, 32f / 255f, 100f / 255f, 1f);
    Color ArchitectureSelectSectionColor = new Color(13f / 255f, 200f / 255f, 44f / 255f, 1f);

    Rect headerSection;
    Rect configurProjectTypeSection;
    Rect configureArchitectureTypeSection;

    /// <summary>
    /// initialize texture2d values
    /// </summary>
    void InitTextures()
    {
        headerSectionTexture = new Texture2D(1, 1);
        headerSectionTexture.SetPixel(0, 0, headerSectionColor);
        headerSectionTexture.Apply();

        ProjectTypeSectionTexture = new Texture2D(1, 1);
        ProjectTypeSectionTexture.SetPixel(0, 0, ProjectTypeSectionColor);
        ProjectTypeSectionTexture.Apply();

        ArchitectureSelectSectionTexture = new Texture2D(1, 1);
        ArchitectureSelectSectionTexture.SetPixel(0, 0, ArchitectureSelectSectionColor);
        ArchitectureSelectSectionTexture.Apply();
    }
    private void OnEnable()
    {
        InitTextures();
    }


    bool purposeSimulatorTypeGroupEnabled = false;
    private void OnGUI()
    {
        //    GUILayout.BeginArea(configurProjectTypeSection);
        ///////////////////////////////////////
        DrawLayout();
        DrawHeader();

GUILayout.BeginArea(configurProjectTypeSection);
        purposeSimulatorTypeGroupEnabled = EditorGUILayout.BeginToggleGroup("3d Simulator", purposeSimulatorTypeGroupEnabled);




        GUILayout.Label("?", EditorStyles.label);
        GUILayout.Label("RPG questing and style?", EditorStyles.label);

        GUILayout.Label("multi-scene?", EditorStyles.label);
        GUILayout.Label("networked?", EditorStyles.label);
        GUILayout.Label("machine learning training?", EditorStyles.label);
        GUILayout.Label("drone caputred reality?", EditorStyles.label);
        EditorGUILayout.EndToggleGroup();

            GUILayout.EndArea();
        //   EditorGUILayout.EndToggleGroup();

    }


    private void DrawHeader() { }
    private void DrawLayout()
    {



        headerSection.x = 0;
        headerSection.y = 0;
        headerSection.width = Screen.width;
        headerSection.height = 50;



        configurProjectTypeSection.x = 0;
        configurProjectTypeSection.y = 50;
        configurProjectTypeSection.width = Screen.width / 2f;
        configurProjectTypeSection.height = Screen.width - 50;


        configureArchitectureTypeSection.x = Screen.width / 2f;
        configureArchitectureTypeSection.y = 50;
        configureArchitectureTypeSection.width = Screen.width - 50;
        configureArchitectureTypeSection.height = Screen.width - 50;



        GUI.DrawTexture(headerSection, headerSectionTexture);
        GUI.DrawTexture(configurProjectTypeSection, ProjectTypeSectionTexture);
        GUI.DrawTexture(configureArchitectureTypeSection, ArchitectureSelectSectionTexture);
    }

}

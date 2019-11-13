using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class SimuframeworkWindow : EditorWindow
{
    /*
    ways to define texture2d
    drawing teactures and defining areas
    onenable & onGUI
    rect maniuplation
     */

    bool[] purposeType = new bool[3] { false, false, false };
    // bool purposeGameTypeGroupEnabled = true;
    // bool purposeSimulatorTypeGroupEnabled = false;
    bool purposeAppTypeGroupEnabled = false;





    Texture2D headerSectionTexture;
    Texture2D ProjectTypeSectionTexture;
    Texture2D ArchitectureSelectSectionTexture;

    Color headerSectionColor =             new Color(133f / 255f, 32f  / 255f,  44f / 255f, 1f); //navy
    Color ProjectTypeSectionColor =        new Color(133f / 255f, 132f / 255f, 100f / 255f, 1f); //blue
    Color ArchitectureSelectSectionColor = new Color(133f / 255f, 200f / 255f,  44f / 255f, 1f); //green

    Rect headerSection;
    Rect configurProjectTypeSection;
    Rect configureArchitectureTypeSection;


    private void OnEnable()
    {
        InitTextures();
    }
    /// <summary>
    /// defines rect values and paints textures based on Rect
    /// </summary>
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
    private void OnGUI()
    {


        DrawLayout();
        DrawHeader();


        DrawProjectMetadataSettings();
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        DrawArchitecturalInfrastructureSettings();
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        if (GUILayout.Button("create starter scene"))
        {

            Debug.Log("Initiating New Starter project");

            if (true)
            // if (purposeGameTypeGroupEnabled)
            {
                var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
                // string path = "MainScene.unity";
                //bool saveOK = EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene(), string.Join("/Assets/Scenes", path));
                // bool saveOK = EditorSceneManager.SaveScene(newScene, string.Join("Assets/", path));
                
                string nameforscene = "Assets/" + stringForGameName +".unity";
                
                // bool saveOK = EditorSceneManager.SaveScene(newScene, "Assets/MaiScen.unity");
               bool saveOK = EditorSceneManager.SaveScene(newScene,nameforscene);
                Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));


            }//esle simulatultor or learning environment 3d/ or else app
        }

    }

    private void DrawHeader() { }





string stringForGameName;// = null;
    private void DrawProjectMetadataSettings()
    {

        GUILayout.BeginArea(configurProjectTypeSection);
// EditorGUILayout.BeginHorizontal();
// EditorGUILayout.LabelField("test");
// EditorGUILayout.LabelField("test33");
// EditorGUILayout.EndHorizontal();

        GUILayout.Label("Configure Project Starter Type", EditorStyles.boldLabel);

EditorGUILayout.Separator();
        
        EditorGUILayout.TextField("Game Name", stringForGameName);
EditorGUILayout.Space();


        // purposeGameTypeGroupEnabled = EditorGUILayout.BeginToggleGroup("Game or App", purposeGameTypeGroupEnabled);





        GUILayout.Label("2d?", EditorStyles.label);
        GUILayout.Label("3d?", EditorStyles.label);
        GUILayout.Label("Include Title Scene?", EditorStyles.label);
        GUILayout.Label("Include Menu scene?", EditorStyles.label);


        GUILayout.Label("######");
        GUILayout.Label("MixedReality/AR?", EditorStyles.label);//design and visualization
        GUILayout.Label("Networked?", EditorStyles.label);//design and visualization


        // EditorGUILayout.EndToggleGroup();

 GUILayout.EndArea();






    }


    //groups
    bool isSingletonPatternGroup = true; //default
    bool isECSGroup = false; //default
    bool isObserverPatternGroup = false; //default
    bool isMVCGroup = false; //default



    //infrastructurecomponenets
    // bool singletonQuestingSystem;




    bool singletonGameManager = true;
    bool singletonLevelManager = true;
    private void DrawArchitecturalInfrastructureSettings()
    {
        GUILayout.BeginArea(configureArchitectureTypeSection);
        GUILayout.Label("Archtecture-Design Pattern", EditorStyles.boldLabel);


        // Singleton
        isSingletonPatternGroup = EditorGUILayout.BeginToggleGroup("Singleton", isSingletonPatternGroup);
        // questing system
        // dialogue system
        // level manager
        // inventory system
        //networking system
        //reward system
        // game manager
        singletonGameManager = EditorGUILayout.Toggle("Game Manager", singletonGameManager);
        singletonLevelManager = EditorGUILayout.Toggle("Level manager", singletonLevelManager);


        EditorGUILayout.EndToggleGroup();

        // ECS

        isECSGroup = EditorGUILayout.BeginToggleGroup("ECS", isECSGroup);
        // questing system
        // dialogue system
        // level manager
        // inventory system
        //networking system
        //reward system
        // game manager
        // singletonGameManager = EditorGUILayout.Toggle("Game Manager", singletonGameManager);
        // singletonGameManager = EditorGUILayout.Toggle("Level manager", singletonLevelManager);


        EditorGUILayout.EndToggleGroup();

        // Observer Pattern
        isObserverPatternGroup = EditorGUILayout.BeginToggleGroup("Observer Pattern", isObserverPatternGroup);
        // questing system
        // dialogue system
        // level manager
        // inventory system
        //networking system
        //reward system
        // game manager
        // singletonGameManager = EditorGUILayout.Toggle("Game Manager", singletonGameManager);
        // singletonGameManager = EditorGUILayout.Toggle("Level manager", singletonLevelManager);


        EditorGUILayout.EndToggleGroup();


        // MVC
        isMVCGroup = EditorGUILayout.BeginToggleGroup("MVC", isMVCGroup);
        // questing system
        // dialogue system
        // level manager
        // inventory system
        //networking system
        //reward system
        // game manager
        // singletonGameManager = EditorGUILayout.Toggle("Game Manager", singletonGameManager);
        // singletonGameManager = EditorGUILayout.Toggle("Level manager", singletonLevelManager);


        EditorGUILayout.EndToggleGroup();













        // questing system
        // dialogue system
        // level manager
        // inventory system
        //networking system
        //reward system
        // game manager
        GUILayout.EndArea();



    }

}
// purposeType[0] = EditorGUILayout.Toggle("Game", purposeType[0]);
// purposeType[1] = EditorGUILayout.Toggle("Simulator", purposeType[1]);
// purposeType[2] = EditorGUILayout.Toggle("App", purposeType[2]);      

// purposeType[0] = EditorGUILayout.Toggle("Game", purposeType[0]);
// purposeType[1] = EditorGUILayout.Toggle("Simulator", purposeType[1]);
// purposeType[2] = EditorGUILayout.Toggle("App", purposeType[2]);
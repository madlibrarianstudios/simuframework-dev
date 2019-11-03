using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// using com.madlibrarianstudios.simuframework.runtime;

public class CreateSceneEditorWindow : EditorWindow
{

    bool includeWebScene = true;
    bool includeMainScene = false;
    bool includeTitleScene = false;
    bool includeMenuScene = false;
    private string stringForGameName;



    bool includeGameManager = true;
    ///

    bool includeSingletonGM = true;
    bool includeECSGM = false;
    bool includeObserverPatternGM = false;
    bool includeMVCGM = false;



    private void OnGUI()
    {
        EditorGUILayout.LabelField("Create Scene with Game Manager");


        stringForGameName = EditorGUILayout.TextField("Game Name", stringForGameName);
        EditorGUILayout.Space();
        includeWebScene = EditorGUILayout.Toggle("include Web scene?", includeWebScene);
        includeMainScene = EditorGUILayout.Toggle("include main scene?", includeMainScene);
        includeTitleScene = EditorGUILayout.Toggle("include title scene", includeTitleScene);
        includeMenuScene = EditorGUILayout.Toggle("include menu scene?", includeMenuScene);








            //////////////////////////////////////

            includeGameManager = EditorGUILayout.BeginToggleGroup("Include Game Manager", includeGameManager);




            includeSingletonGM = EditorGUILayout.Toggle("Singleton", includeSingletonGM);
            includeECSGM = EditorGUILayout.Toggle("ECS", includeECSGM);
            includeObserverPatternGM = EditorGUILayout.Toggle("Observer Pattern", includeObserverPatternGM);

            includeMVCGM = EditorGUILayout.Toggle("MVC", includeMVCGM);
            EditorGUILayout.EndToggleGroup();







        // includeMainScene = EditorGUILayout.Toggle();
        if (GUILayout.Button("create scene and game manager"))
        {

            Debug.Log("Initiating New Starter project");

            // string guid = AssetDatabase.CreateFolder("Assets", "Scenes");
            // AssetDatabase.Refresh();

            if (includeWebScene)
            {
                var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
                string nameforscene = "Assets/Scenes/Web-" + stringForGameName + ".unity";
                bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
                Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
            }
            if (includeMainScene)
            {
                var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
                string nameforscene = "Assets/Scenes/Main-" + stringForGameName + ".unity";
                bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
                Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
            }
            if (includeTitleScene)
            {
                var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
                string nameforscene = "Assets/Scenes/Title-" + stringForGameName + ".unity";
                bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
                Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
            }
            if (includeMenuScene)
            {
                var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
                string nameforscene = "Assets/Scenes/Menu-" + stringForGameName + ".unity";
                bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
                Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
            }




            ////////////////////////////////////////

            if (includeGameManager)
            {
                if (includeSingletonGM)
                {
                    Debug.Log("creating game manager for singleton pattern");

                    GameObject singletonGameManager = new GameObject("Singleton GameManager");
                    singletonGameManager.AddComponent<SingletonGameManager>();

                    // Instantiate(singletonGameManager, Vector3.zero, Quaternion.identity);
// 
                    // WorkCycleEditorWindow.ShowWindow();
                    // Texture2D texture = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.unity.images-library/Example/Images/image.png", typeof(Texture2D));
                    // GameObject prefabToLoad = (GameObject)AssetDatabase.LoadAssetAtPath("Packages/com.madlibrarianstudios.simuframework/Runtime/Prefabs/prefbtest.prefab", typeof(GameObject));
                    // SingletonGameManager
                    // GameObject myobject = PrefabUtility.InstantiatePrefab(prefabToLoad) as GameObject;
                }
                if (includeECSGM)
                {

                }
                if (includeObserverPatternGM)
                {

                }
                if (includeMVCGM)
                {

                }
            }
        }











    }





}

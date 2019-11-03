using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using UnityEditor.SceneManagement;

public class SingletonApp2dGameEditorWindow : EditorWindow
{
//sa

    #region menu items
    [MenuItem("Window/Simuframwork Workflows/Singleton App/2d Game", false, 1)]
    private static void ShowWindow()
    {
        var window = GetWindow<SingletonApp2dGameEditorWindow>();
        window.titleContent = new GUIContent("SingletonApp2dGameWindow");
        window.Show();
    }
    [MenuItem("Window/Simuframwork Workflows/Singleton App/2d Game", true)]
    private static void ShowWindow2d()
    {
        // return true;
    }
    [MenuItem("Window/Simuframwork Workflows/Singleton App/Simulator", true, 3)]
    private static void ShowWindowSimulator()
    {
        // return false;
    }


    //validators
        [MenuItem("Window/Simuframwork Workflows/Singleton App/2d Game", true)]
    private static void ShowWindow2dValidator()
    {
        // return true;
    }

    [MenuItem("Window/Simuframwork Workflows/Singleton App/Simulator", true, 3)]
    private static bool ShowWindowSimulatorValidator()
    {
        return false;
    }
    [MenuItem("Window/Simuframwork Workflows/Singleton App/3d Game", true, 2)]
    private static bool ShowWindow3dValidator()
    {
        return false;
    }




    #endregion
























    #region 1. create folder structure
    public bool IncludeResourceFolder = false;
    public bool UseNamespace = false;
    private string SFGUID;
    public List<string> nsFolders = new List<string>();
    public List<string> folders = new List<string>() { "Scenes", "Scripts", "Animation", "Audio", "Materials", "Meshes", "Prefabs", "Artwork", "Textures", "Sprites" };
    //Called when the window first appears
    public void OnWizardCreate()
    {

        //create all the folders required in a project
        //primary and sub folders
        foreach (string folder in folders)
        {
            string guid = AssetDatabase.CreateFolder("Assets", folder);
            string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            if (folder == "Scripts")
                SFGUID = newFolderPath;
        }

        AssetDatabase.Refresh();
        if (UseNamespace == true)
        {
            foreach (string nsf in nsFolders)
            {
                //AssetDatabase.Contain
                string guid = AssetDatabase.CreateFolder("Assets/Scripts", nsf);
                string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

            }
        }
    }



    #endregion


    #region 2. create scene(s) and add game manager

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





    #endregion
    #region 3. Create Level manager and level type// 2d style game

    // bool includeWebScene = true;
    // bool includeMainScene = false;
    // bool includeTitleScene = false;
    // bool includeMenuScene = false;
    // private string stringForGameName;



    // bool includeGameManager = true;
    // ///

    // bool includeSingletonGM = true;
    // bool includeECSGM = false;
    // bool includeObserverPatternGM = false;
    // bool includeMVCGM = false;

    // [Header("to be implemneted 2d game framework contracts ideas")]


    public bool isSingleScreen;// frogger, pac-man, dig dug
    public bool isScroller;//gun smoke or heavy barrel. background scrolls - top down or side

    public bool isSideScroller;//pitfall  original super mario bros
                               //shooter or walker



    public bool isPlatformGame;//donkey kong, bubble bobble, burger time
    public bool isAdventure;// rouge like - zed

    #endregion
    #region 4 player stuff

    #endregion

    #region 5 camera and ui

    #endregion

    #region 6 audio

    #endregion

    #region 7 plolish and deployment

    #endregion



    void OnEnable()
    {

    }
    private void OnGUI()
    {

        //header
        EditorGUILayout.LabelField("Create 2d Game or App with Singleton Pattern", EditorStyles.boldLabel);
        EditorGUILayout.Space();




        #region 1 gui create folders
        EditorGUILayout.LabelField("1. create starter project structure", EditorStyles.boldLabel);
        if (GUILayout.Button("1. create starter project struture"))
        {

            OnWizardCreate();

        }
        #endregion




        #region 2 gui-add scene(s) and architecture singleton
        EditorGUILayout.LabelField("2. add scene(s), and game manager for singleton app", EditorStyles.boldLabel);
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





        #endregion

        #region 3 player stuff
        EditorGUILayout.LabelField("3 add player for level type");

        //  stringForGameName = EditorGUILayout.TextField("Game Name", stringForGameName);
        EditorGUILayout.Space();
        isSingleScreen = EditorGUILayout.Toggle("is single screen?", isSingleScreen);
        isScroller = EditorGUILayout.Toggle("is scroller?", isScroller);
        isSideScroller = EditorGUILayout.Toggle("is side scroller?", isSideScroller);
        isPlatformGame = EditorGUILayout.Toggle("is platformer?", isPlatformGame);
        isAdventure = EditorGUILayout.Toggle("is adventure rpg?", isAdventure);



        EditorGUILayout.Space();
        EditorGUILayout.LabelField("");
        EditorGUILayout.Space();
        #endregion
        #region 4 add gameplay level assets
        EditorGUILayout.LabelField("4. add level content for gameplay (SEPERATE WORKFLOW)");
        EditorGUILayout.Space();






        // includeMainScene = EditorGUILayout.Toggle();
        if (GUILayout.Button("4. Start Level Creating"))
        {

            Debug.Log("creating 2d level manager for  project");


        }


        #endregion


        #region 5 camera and ui
        EditorGUILayout.LabelField("configure camera and ui");
        EditorGUILayout.Space();
        #endregion

        #region 6 audio
        EditorGUILayout.LabelField("mix in aduio");
        EditorGUILayout.Space();
        #endregion

        #region 7 plolish and deployment
        EditorGUILayout.LabelField("polish and deployment");
        EditorGUILayout.Space();
        #endregion


    }


}





//////////////////////////////////////


// includeGameManager = EditorGUILayout.BeginToggleGroup("Include Game Manager", includeGameManager);



// includeSingletonGM = EditorGUILayout.Toggle("Singleton", includeSingletonGM);
// includeECSGM = EditorGUILayout.Toggle("ECS", includeECSGM);
// includeObserverPatternGM = EditorGUILayout.Toggle("Observer Pattern", includeObserverPatternGM);

// includeMVCGM = EditorGUILayout.Toggle("MVC", includeMVCGM);
// EditorGUILayout.EndToggleGroup();



// string guid = AssetDatabase.CreateFolder("Assets", "Scenes");
// AssetDatabase.Refresh();

// if (includeWebScene)
// {
//     var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
//     string nameforscene = "Assets/Scenes/Web-" + stringForGameName + ".unity";
//     bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
//     Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
// }
// if (includeMainScene)
// {
//     var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
//     string nameforscene = "Assets/Scenes/Main-" + stringForGameName + ".unity";
//     bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
//     Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
// }
// if (includeTitleScene)
// {
//     var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
//     string nameforscene = "Assets/Scenes/Title-" + stringForGameName + ".unity";
//     bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
//     Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
// }
// if (includeMenuScene)
// {
//     var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
//     string nameforscene = "Assets/Scenes/Menu-" + stringForGameName + ".unity";
//     bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
//     Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
// }



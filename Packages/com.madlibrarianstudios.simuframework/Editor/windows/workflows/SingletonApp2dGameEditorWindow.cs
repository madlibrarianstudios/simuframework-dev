using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using System;

public class SingletonApp2dGameEditorWindow : EditorWindow
{

    #region 1. create folder structure
    // public bool IncludeResourceFolder = false;
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
    private string shortNameGameName;
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
    #region 4. player stuff

    #endregion
    #region 5. camera and ui

    #endregion
    #region 6. audio

    #endregion
    #region 7. plolish and deployment

    #endregion

    #region texture and layout
    Texture2D headerSectionTexture;
    Texture2D ProjectTypeSectionTexture;
    Texture2D MiddleSectionTexture;
    Texture2D ArchitectureSelectSectionTexture;

    Color headerSectionColor = new Color(133f / 255f, 32f / 255f, 44f / 255f, 1f); //navy
    Color ProjectTypeSectionColor = new Color(133f / 255f, 132f / 255f, 100f / 255f, 1f); //blue
    Color MiddleSectionColor = new Color(133f / 255f, 132f / 255f, 100f / 255f, 1f); //blue
    Color ArchitectureSelectSectionColor = new Color(133f / 255f, 200f / 255f, 44f / 255f, 1f); //green

    Rect headerSection;
    Rect architectureSectionRect;
    Rect MiddleSectionRect;
    Rect infrastructureSectionRect;
    #endregion

    private void DrawHeader()
    {
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        //header
        EditorGUILayout.LabelField("Create 2d Game or App with Singleton Pattern", EditorStyles.boldLabel);
        EditorGUILayout.Space();
    }


    private void OnGUI()
    {


        // DrawLayout();
        Draw3ColumnLayout();
        DrawHeader();


        Draw2dSingletonInfrastructureOptions();
        DrawMiddleColumnOptions();
        Draw2dSingletonArchitectureOptions();
        InitTextures();

    }

    private void DrawMiddleColumnOptions()
    {
        GUILayout.BeginArea(MiddleSectionRect);
        #region 3 player stuff
        EditorGUILayout.LabelField("3. Configure Level, Player and Camera", EditorStyles.boldLabel);


        EditorGUILayout.LabelField("Include Level Manager");
        EditorGUILayout.LabelField("Include Player");
        EditorGUILayout.LabelField("Include Camera");

        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.BeginVertical();
        EditorGUILayout.Space();
        isPlatformGame = EditorGUILayout.Toggle("is platformer?", isPlatformGame);
        
        EditorGUILayout.LabelField("---Camera Follows Player");
        EditorGUILayout.LabelField("---Camera Side");
        EditorGUILayout.LabelField("---Backgroud Fixed");
        EditorGUILayout.LabelField("---Player moves");
        EditorGUILayout.LabelField("---Level includes platforms (tilemaps)");
        EditorGUILayout.Space();
        isSingleScreen = EditorGUILayout.Toggle("is single screen?", isSingleScreen);
        EditorGUILayout.LabelField("---ex. card game");
        EditorGUILayout.LabelField("---Camera Side or top down");
        EditorGUILayout.LabelField("---Camera Fixed");
        EditorGUILayout.LabelField("---Backgroud Fixed");
        EditorGUILayout.LabelField("---Player moves within screen?");

        EditorGUILayout.Space();
        EditorGUILayout.EndVertical();
        EditorGUILayout.BeginVertical();
        isScroller = EditorGUILayout.Toggle("is scroller?", isScroller);
        EditorGUILayout.LabelField("---ex. pixel space");
        EditorGUILayout.LabelField("---Camera Top-Down");
        EditorGUILayout.LabelField("---Camera Fixed");
        EditorGUILayout.LabelField("---Backgroud Moves");
        EditorGUILayout.LabelField("---Player Moves with in the camera");
        EditorGUILayout.Space();
        isSideScroller = EditorGUILayout.Toggle("is side scroller?", isSideScroller);
        EditorGUILayout.LabelField("---infinite runner");
        EditorGUILayout.LabelField("---Camera Side");
        EditorGUILayout.LabelField("---Camera Fixed");
        EditorGUILayout.LabelField("---Backgroud Moves");
        EditorGUILayout.LabelField("---Player Fixed Camera?");
        EditorGUILayout.Space();
        isAdventure = EditorGUILayout.Toggle("is adventure rpg?", isAdventure);
        EditorGUILayout.LabelField("---zelda; rouge-like");
        EditorGUILayout.LabelField("---Camera Top-Down");
        EditorGUILayout.LabelField("---Camera follows player");
        EditorGUILayout.LabelField("---Backgroud fixed");
        EditorGUILayout.LabelField("---Player Moves");
        EditorGUILayout.Space();
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();

        if (GUILayout.Button("3. Add level manager, player, and camera for 2D game"))
        {

            if (isPlatformGame)
            {

            }


        }
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();


        GUILayout.EndArea();
    }


    private void Draw2dSingletonArchitectureOptions()
    {

        #region 1 gui create folders
        GUILayout.BeginArea(architectureSectionRect);
        EditorGUILayout.LabelField("1. create starter project structure", EditorStyles.boldLabel);
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical();


        EditorGUILayout.LabelField("-Scenes");
        EditorGUILayout.LabelField("-Scripts");
        EditorGUILayout.LabelField("-Animation");
        EditorGUILayout.LabelField("-Audio");
        EditorGUILayout.LabelField("-Materials");
        EditorGUILayout.EndVertical();
        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("-Meshes");
        EditorGUILayout.LabelField("-Prefabs");
        EditorGUILayout.LabelField("-Artwork");
        EditorGUILayout.LabelField("-Textures");
        EditorGUILayout.LabelField("-Sprites");
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();
        if (GUILayout.Button("1. create starter project struture"))
        {

            OnWizardCreate();

        }

        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        #endregion
        #region 2 gui-add scene(s) and architecture singleton
        EditorGUILayout.LabelField("2. add scene(s), and game manager for singleton app", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Create Scene with Game Manager");


        stringForGameName = EditorGUILayout.TextField("Game Name", stringForGameName);
        shortNameGameName = EditorGUILayout.TextField("Short Name", shortNameGameName);
        EditorGUILayout.Space();

        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.BeginVertical();
        // includeWebScene = EditorGUILayout.Toggle("include preload scene?", includeWebScene);
        includeWebScene = EditorGUILayout.Toggle("include Web scene?", includeWebScene);
        includeMainScene = EditorGUILayout.Toggle("include main scene?", includeMainScene);
        includeTitleScene = EditorGUILayout.Toggle("include title scene", includeTitleScene);
        includeMenuScene = EditorGUILayout.Toggle("include menu scene?", includeMenuScene);
        EditorGUILayout.EndVertical();




        EditorGUILayout.BeginVertical();
        includeSingletonGM = EditorGUILayout.Toggle("Include GameManager", includeSingletonGM);
        EditorGUILayout.EndVertical();

        EditorGUILayout.EndHorizontal();
        //////////////////////////////////////

        // includeGameManager = EditorGUILayout.BeginToggleGroup("Include Game Manager", includeGameManager);





        // includeECSGM = EditorGUILayout.Toggle("ECS", includeECSGM);
        // includeObserverPatternGM = EditorGUILayout.Toggle("Observer Pattern", includeObserverPatternGM);

        // includeMVCGM = EditorGUILayout.Toggle("MVC", includeMVCGM);
        // EditorGUILayout.EndToggleGroup();







        // includeMainScene = EditorGUILayout.Toggle();
        if (GUILayout.Button("2. create scene(s) and game manager"))
        {

            Debug.Log("Initiating New Starter project");

            var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            string nameforscene = "";

            if (includeWebScene)
            {
                nameforscene = "Assets/Scenes/Web-" + stringForGameName + ".unity";

            }
            if (includeMainScene)
            {
                nameforscene = "Assets/Scenes/Main-" + stringForGameName + ".unity";

            }
            if (includeTitleScene)
            {
                nameforscene = "Assets/Scenes/Title-" + stringForGameName + ".unity";

            }
            if (includeMenuScene)
            {
                nameforscene = "Assets/Scenes/Menu-" + stringForGameName + ".unity";
            }
            bool saveOK = EditorSceneManager.SaveScene(newScene, nameforscene);
            Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
            AssetDatabase.Refresh();



            ////////////////////////////////////////

            if (includeGameManager)
            {




                Debug.Log("creating game manager for singleton pattern");

                GameObject singletonGameManager = new GameObject("Singleton GameManager");
                singletonGameManager.AddComponent<SingletonGameManager>();

                SingletonGameManager sgm = singletonGameManager.GetComponent<SingletonGameManager>();
                sgm.gameName = stringForGameName;
                sgm.Version = "0.0.1";


                bool saveOKagain = EditorSceneManager.SaveScene(newScene, nameforscene);
                Debug.Log("Saved Scene " + (saveOK ? "OK" : "Error!"));
                AssetDatabase.Refresh();
                // Instantiate(singletonGameManager, Vector3.zero, Quaternion.identity);
                // 
                // WorkCycleEditorWindow.ShowWindow();
                // Texture2D texture = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.unity.images-library/Example/Images/image.png", typeof(Texture2D));
                // GameObject prefabToLoad = (GameObject)AssetDatabase.LoadAssetAtPath("Packages/com.madlibrarianstudios.simuframework/Runtime/Prefabs/prefbtest.prefab", typeof(GameObject));
                // SingletonGameManager
                // GameObject myobject = PrefabUtility.InstantiatePrefab(prefabToLoad) as GameObject;
                // AssetDatabase.Refresh();

            }
            InitTextures();
        }

        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();



        #endregion






        GUILayout.EndArea();
        #endregion


    }

    private void Draw2dSingletonInfrastructureOptions()
    {
        GUILayout.BeginArea(infrastructureSectionRect);

        #region 4 add gameplay level assets
        EditorGUILayout.LabelField("4. Create Levels)", EditorStyles.boldLabel);

        EditorGUILayout.LabelField("platformer");
        EditorGUILayout.LabelField("-add tilemapp");
        EditorGUILayout.LabelField("-add procedurally generated levels");
        EditorGUILayout.Space();


        if (GUILayout.Button("4. Start Level Creating"))
        {

            Debug.Log("debug: mocking creating 2d levels for manager of different game types. for  project");


        }
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();


        #endregion
        #region 5 camera and ui
        EditorGUILayout.LabelField("5. add UI Manager", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("-add UI Manager");
        EditorGUILayout.LabelField("-add Text based components");
        EditorGUILayout.LabelField("-add Menu Prefabs");
        EditorGUILayout.LabelField("-Data Visualtison Components");
        EditorGUILayout.Space();
        if (GUILayout.Button("5. Set up UI"))
        {

            Debug.Log("adding ui manager and cinemachine");


        }
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        #endregion
        #region 6 audio
        EditorGUILayout.LabelField("6. mix in audio", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("-add audio manager");
        EditorGUILayout.Space();
        if (GUILayout.Button("6. Add audio manager"))
        {

            Debug.Log("adding audio manager");


        }
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        #endregion
        #region 7 plolish and deployment
        EditorGUILayout.LabelField("7. polish and deployment", EditorStyles.boldLabel);
        EditorGUILayout.LabelField("-post processing");
        EditorGUILayout.LabelField("-ads");
        EditorGUILayout.LabelField("-analytics");
        EditorGUILayout.LabelField("-dev/ops - data engineering");
        EditorGUILayout.LabelField("-Testing - Quality Assurance");
        EditorGUILayout.Space();
        if (GUILayout.Button("7. Deploy Ops"))
        {

            Debug.Log("finizing game for publishing");


        }
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        #endregion

        GUILayout.EndArea();
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



        architectureSectionRect.x = 0;
        architectureSectionRect.y = 50;
        architectureSectionRect.width = Screen.width / 2f;
        // architectureSectionRect.width = Screen.width - 50;
        architectureSectionRect.height = Screen.width - 50;


        infrastructureSectionRect.x = Screen.width / 2f;
        infrastructureSectionRect.y = 50;
        // infrastructureSectionRect.width = Screen.width - 50;
        infrastructureSectionRect.width = Screen.width / 2f;
        infrastructureSectionRect.height = Screen.width - 50;



        GUI.DrawTexture(headerSection, headerSectionTexture);
        GUI.DrawTexture(architectureSectionRect, ProjectTypeSectionTexture);
        GUI.DrawTexture(infrastructureSectionRect, ArchitectureSelectSectionTexture);
    }






    private void Draw3ColumnLayout()
    {



        headerSection.x = 0;
        headerSection.y = 0;
        headerSection.width = Screen.width;
        headerSection.height = 50;



        architectureSectionRect.x = 0;
        architectureSectionRect.y = 50;
        architectureSectionRect.width = Screen.width / 3f;
        architectureSectionRect.height = Screen.width - 50;


        MiddleSectionRect.x = Screen.width / 3f;
        MiddleSectionRect.y = 50;
        MiddleSectionRect.width = Screen.width / 3f;
        MiddleSectionRect.height = Screen.width - 50;



        infrastructureSectionRect.x = (Screen.width / 3f) * 2;
        infrastructureSectionRect.y = 50;
        infrastructureSectionRect.width = Screen.width / 3f;
        infrastructureSectionRect.height = Screen.width - 50;



        GUI.DrawTexture(headerSection, headerSectionTexture);
        GUI.DrawTexture(architectureSectionRect, ProjectTypeSectionTexture);
        GUI.DrawTexture(infrastructureSectionRect, ArchitectureSelectSectionTexture);
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



// if (includeECSGM)
// {

// }
// if (includeObserverPatternGM)
// {

// }
// if (includeMVCGM)
// {

// }
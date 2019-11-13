using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;




public class SimuframeworkMenuItems
{



    #region other

    // private string baseMenuItemLocation = "simuframework";



    // [MenuItem("simuframework/Workflow/Game or App/1. Create Starter Scene and Game Manager", false, 2)]
    // private static void Init()
    // {
    //     CreateSceneEditorWindow window = (CreateSceneEditorWindow)EditorWindow.GetWindow<CreateSceneEditorWindow>();
    //     window.titleContent = new GUIContent("Simuframework Game or App Window");
    //     window.Show();
    // }

    //     [MenuItem("simuframework/Workflow/Game or App/2. Add Infrastructure", false, 1)]
    //     private static void InitAddInfrasturctureMainspace()
    //     {
    //   Debug.Log("ok");      
    //         // CreateLevel2dEditorWindow window = (CreateLevel2dEditorWindow)EditorWindow.GetWindow<CreateLevel2dEditorWindow>();
    //         // window.titleContent = new GUIContent("Create 2D Level");
    //         // window.Show();
    //     }






    // [MenuItem("simuframework/Workflow/Game or App/2. Add Infrastructure/Create 2d Level Assets", false, 3)]
    // private static void InitAddInfrasturcture()
    // {

    //     CreateLevel2dEditorWindow window = (CreateLevel2dEditorWindow)EditorWindow.GetWindow<CreateLevel2dEditorWindow>();
    //     window.titleContent = new GUIContent("Create 2D Level");
    //     window.Show();
    // }

    // [MenuItem("simuframework/Tool Kit/Tools/Dev Test Command")]
    // private static void testcommandmethod()
    // {

    //     Debug.Log("testing command");


    //     // WorkCycleEditorWindow.ShowWindow();
    //     // Texture2D texture = (Texture2D)AssetDatabase.LoadAssetAtPath("Packages/com.unity.images-library/Example/Images/image.png", typeof(Texture2D));
    //     GameObject prefabToLoad = (GameObject)AssetDatabase.LoadAssetAtPath("Packages/com.madlibrarianstudios.simuframework/Runtime/Prefabs/prefbtest.prefab", typeof(GameObject));

    //     GameObject myobject = PrefabUtility.InstantiatePrefab(prefabToLoad) as GameObject;
    // }








    //internall unity, file, edit, window, and help
    //component
    //gameobject/
    //assest


    //     [MenuItem("simuframework/Workflow/Game or App/2. Add Infrastructure/Create 2d Player", false, 4)]
    //     private static void InitAddInfrasturcturePlayer()
    //     {
    //         Debug.Log("intiate window for creating 2d player");
    //         // CreateLevel2dEditorWindow window = (CreateLevel2dEditorWindow)EditorWindow.GetWindow<CreateLevel2dEditorWindow>();
    //         // window.titleContent = new GUIContent("Create 2D Level");
    //         // window.Show();
    //     }
    //     [MenuItem("simuframework/Workflow/Game or App/2. Add Infrastructure/Create 2d Player", true, 4)]
    //     private static bool InitAddInfrasturcturePlayerValidation()
    //     {
    //         Debug.Log("intiate window for creating 2d player");

    // return false;

    //         // CreateLevel2dEditorWindow window = (CreateLevel2dEditorWindow)EditorWindow.GetWindow<CreateLevel2dEditorWindow>();
    //         // window.titleContent = new GUIContent("Create 2D Level");
    //         // window.Show();
    //     }




    // [MenuItem("simuframework/Workflow/Simulator/1. Create Starter Scene", false, 101)]
    // private static void initatiateSimulatorWorkflowOne()
    // {
    //     Debug.Log("place holder");
    //     SimuframeworkSimulatorWindow window = (SimuframeworkSimulatorWindow)EditorWindow.GetWindow<SimuframeworkSimulatorWindow>();
    //     window.titleContent = new GUIContent("Simuframework Simulator Window");
    //     window.Show();
    // }



    #endregion




    #region singleton app


    [MenuItem("simuframework/Window/Simuframwork Workflows/Singleton App/2d Game", false, 1)]
    private static void ShowWindowSingleton2DGameApp()
    {
        var window = EditorWindow.GetWindow<SingletonApp2dGameEditorWindow>();
        window.titleContent = new GUIContent("SingletonApp2dGameWindow");
        window.Show();
    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/Singleton App/Simulator", false, 2)]
    private static void ShowWindow2d()
    {
        // return true;
    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/Singleton App/3d Game", false, 3)]
    private static void ShowWindowSimulator()
    {
        // return false;
    }


    //validators
    [MenuItem("simuframework/Window/Simuframwork Workflows/Singleton App/2d Game", true)]
    private static bool ShowWindow2dValidatorfor2d()
    {
        return true;
    }

    [MenuItem("simuframework/Window/Simuframwork Workflows/Singleton App/Simulator", true)]
    private static bool ShowWindowSimulatorValidator()
    {
        return false;
    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/Singleton App/3d Game", true)]
    private static bool ShowWindow3dValidator()
    {
        return false;
    }






    #endregion
    #region mvc app

    [MenuItem("simuframework/Window/Simuframwork Workflows/MVC/2d Game", false, 1)]
    private static void ShowWindowMVC2DGameApp()
    {

    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/MVC/Simulator", false, 2)]
    private static void ShowWindowMVCSimulator()
    {

    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/MVC/3d Game", false, 3)]
    private static void ShowWindowMVC3DGame()
    {

    }


    //validators
    [MenuItem("simuframework/Window/Simuframwork Workflows/MVC/2d Game", true)]
    private static bool ShowWindowMVC2DGameAppValidator()
    {
        return false;
    }

    [MenuItem("simuframework/Window/Simuframwork Workflows/MVC/Simulator", true)]
    private static bool ShowWindowMVCSimulatorValidator()
    {
        return false;
    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/MVC/3d Game", true)]
    private static bool ShowWindowMVC3DGameValidator()
    {
        return false;
    }

    #endregion
    #region ecs app

    [MenuItem("simuframework/Window/Simuframwork Workflows/ECS/2d Game", false, 1)]
    private static void ShowWindowECS2DGameApp()
    {

    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/ECS/Simulator", false, 2)]
    private static void ShowWindowECSSimulator()
    {

    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/ECS/3d Game", false, 3)]
    private static void ShowWindowECS3DGame()
    {

    }


    //validators
    [MenuItem("simuframework/Window/Simuframwork Workflows/ECS/2d Game", true)]
    private static bool ShowWindowECS2DGameAppValidator()
    {
        return false;
    }

    [MenuItem("simuframework/Window/Simuframwork Workflows/ECS/Simulator", true)]
    private static bool ShowWindowECSSimulatorValidator()
    {
        return false;
    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/ECS/3d Game", true)]
    private static bool ShowWindowECS3DGameValidator()
    {
        return false;
    }
    #endregion
    #region observerpattern app

    [MenuItem("simuframework/Window/Simuframwork Workflows/ObserverPattern/2d Game", false, 1)]
    private static void ShowWindowObserverPattern2DGameApp()
    {

    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/ObserverPattern/Simulator", false, 2)]
    private static void ShowWindowObserverPatternSimulator()
    {

    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/ObserverPattern/3d Game", false, 3)]
    private static void ShowWindowObserverPattern3DGame()
    {

    }


    //validators
    [MenuItem("simuframework/Window/Simuframwork Workflows/ObserverPattern/2d Game", true)]
    private static bool ShowWindowObserverPattern2DGameAppValidator()
    {
        return false;
    }

    [MenuItem("simuframework/Window/Simuframwork Workflows/ObserverPattern/Simulator", true)]
    private static bool ShowWindowObserverPatternSimulatorValidator()
    {
        return false;
    }
    [MenuItem("simuframework/Window/Simuframwork Workflows/ObserverPattern/3d Game", true)]
    private static bool ShowWindowObserverPattern3DGameValidator()
    {
        return false;
    }
    #endregion
    #region toolkit 
    [MenuItem("simuframework/Tool Kit/Tools/ApplicationEditor Window Tool Info", false, 200)]
    private static void ShowWindow()
    {
        var window = EditorWindow.GetWindow<EditorToolInfoEditorWindow>();
        window.titleContent = new GUIContent("EditorToolInfoWindow");
        window.Show();
    }

    // [MenuItem("simuframework/Tool Kit/3d")]
    // private static void Init3dtool()
    // {
    //     Debug.Log("placeholder for ");
    // }
    // [MenuItem("simuframework/Tool Kit/2d/ProcedureMap")]
    // private static void InitProcedureMapwindow()
    // {
    //     Debug.Log("placeholder for implementting proceduramap ");

    // }
    [MenuItem("simuframework/Tool Kit/Tools/Open Create Project Folder Structure", false, 1)]
    private static void ShowWindowCreateProjectFoldersEditorWindow()
    {
        var window = EditorWindow.GetWindow<CreateProjectFoldersEditorWindow>();
        window.titleContent = new GUIContent("Create Folder Structures");

        window.Show();

        //  window.OnWizardCreate();

    }
    #endregion


















    #region help

    //windows from help
    [MenuItem("simuframework/Help/Infrastructure Documentation")]
    private static void ShowInfrastructureEditorWindow()
    {
        Debug.Log("displaying help about infrastructure ");
        InfrastructureEditorWindow window = (InfrastructureEditorWindow)EditorWindow.GetWindow<InfrastructureEditorWindow>();
        window.titleContent = new GUIContent("InfrastructureWindow");
        window.Show();
    }
    [MenuItem("simuframework/Help/Architecture Documentation")]
    private static void ShowAcrhitectureEditorWindow()
    {
        ArchitectureEditorWindow.ShowWindow();
    }
    [MenuItem("simuframework/Help/Workcycle Documentation")]
    private static void ShowWorkCycleEditorWindow()
    {
        WorkCycleEditorWindow.ShowWindow();
    }

    #endregion










}




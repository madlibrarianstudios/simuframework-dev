using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;




public class SimuframeworkMenuItems
{

    // private string baseMenuItemLocation = "simuframework";


    [MenuItem("simuframework/Workflow/Game or App/0. Create Project Structure", false, 1)]
    private static void ShowWindowCreateProjectFoldersEditorWindow()
    {
        var window = EditorWindow.GetWindow<CreateProjectFoldersEditorWindow>();
        window.titleContent = new GUIContent("Create Folder Structures");

         window.Show();

      //  window.OnWizardCreate();

    }


    [MenuItem("simuframework/Workflow/Game or App/1. Create Starter Scene and Game Manager", false, 2)]
    private static void Init()
    {
        CreateSceneEditorWindow window = (CreateSceneEditorWindow)EditorWindow.GetWindow<CreateSceneEditorWindow>();
        window.titleContent = new GUIContent("Simuframework Game or App Window");
        window.Show();
    }
    
//     [MenuItem("simuframework/Workflow/Game or App/2. Add Infrastructure", false, 1)]
//     private static void InitAddInfrasturctureMainspace()
//     {
//   Debug.Log("ok");      
//         // CreateLevel2dEditorWindow window = (CreateLevel2dEditorWindow)EditorWindow.GetWindow<CreateLevel2dEditorWindow>();
//         // window.titleContent = new GUIContent("Create 2D Level");
//         // window.Show();
//     }
    [MenuItem("simuframework/Workflow/Game or App/2. Add Infrastructure/Create 2d Level Assets", false, 3)]
    private static void InitAddInfrasturcture()
    {
        
        CreateLevel2dEditorWindow window = (CreateLevel2dEditorWindow)EditorWindow.GetWindow<CreateLevel2dEditorWindow>();
        window.titleContent = new GUIContent("Create 2D Level");
        window.Show();
    }
    [MenuItem("simuframework/Workflow/Game or App/2. Add Infrastructure/Create 2d Player", false, 4)]
    private static void InitAddInfrasturcturePlayer()
    {
        Debug.Log("intiate window for creating 2d player");
        // CreateLevel2dEditorWindow window = (CreateLevel2dEditorWindow)EditorWindow.GetWindow<CreateLevel2dEditorWindow>();
        // window.titleContent = new GUIContent("Create 2D Level");
        // window.Show();
    }
    [MenuItem("simuframework/Workflow/Game or App/2. Add Infrastructure/Create 2d Player", true, 4)]
    private static bool InitAddInfrasturcturePlayerValidation()
    {
        Debug.Log("intiate window for creating 2d player");

return false;

        // CreateLevel2dEditorWindow window = (CreateLevel2dEditorWindow)EditorWindow.GetWindow<CreateLevel2dEditorWindow>();
        // window.titleContent = new GUIContent("Create 2D Level");
        // window.Show();
    }


    [MenuItem("simuframework/Workflow/Simulator/1. Create Starter Scene", false, 101)]
    private static void initatiateSimulatorWorkflowOne()
    {
        Debug.Log("place holder");
        SimuframeworkSimulatorWindow window = (SimuframeworkSimulatorWindow)EditorWindow.GetWindow<SimuframeworkSimulatorWindow>();
        window.titleContent = new GUIContent("Simuframework Simulator Window");
        window.Show();
    }


    [MenuItem("simuframework/Tool Kit/Tools/EditorWindow Tool Info",false, 200)]
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




}




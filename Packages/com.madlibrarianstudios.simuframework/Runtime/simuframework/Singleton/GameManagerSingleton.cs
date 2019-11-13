using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerSingleton : Singleton<GameManagerSingleton>
{

    #region fields and properties

    // (Optional) Prevent non-singleton constructor use.
    protected GameManagerSingleton() { }

    // Then add whatever code to the class you need as you normally would.

    public string gameName;// = "Pixel Space";
    public string Version;// = "1.0.1";


    // public LevelManager levelManager;
    // public UIManager uIManager;
    // public AudioManager audioManager;
    //public Player2d player2d


    public bool paused;
    public GameObject PauseText;

    float totalGameTime;                        //Length of the total game time
    bool isGameOver;                            //Is the game currently over?

    #endregion


    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        // Ensure that the gameOver variable is false
        isGameOver = false;
        paused = false;
    }



    private void OnEnable()
    {
        // levelManager.currentlevelNumber = 1;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);

        if (paused)
        {
            paused = !paused;
        }

        if (scene.name == "MyTitle")
        {

            RestartGame();
            // UIManager.fadein();
        }
        else if (isGameOver && scene.name == "MyMain")
        {
            RestartGame();
            LoadMainScene();
            //   UIManager.fadeout();
        }
        else if (isGameOver)
        {
            return;

        }
        else if (!isGameOver && scene.name == "MyMain")
        {

            //update ui
            // UIManager.UpdateLevelNumberUI(current.levelManager.currentlevelNumber);
            // UIManager.fadeout();
            // UIManager.UnDisplayLevelWonGameOverText();


            //load level from level manager
            // levelManager.loadlevel();
            //spawn player 1 
            // SpawnSpacePlebePlayer();
        }




    }
    // Update is called once per frame
    void Update()
    {





        if (Input.GetKeyDown("p") && SceneManager.GetActiveScene().name == "MyMain")
        {
            paused = !paused;

        }

        if (paused)
        {
            PauseText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            PauseText.gameObject.SetActive(false);
            Time.timeScale = 1;
        }



        if (Input.GetKey("escape") && SceneManager.GetActiveScene().name == "MyTitle")
        {
            Application.Quit();

        }
        else if (Input.GetKey("escape"))
        {
            // RestartGame();

            LoadTitleScene();
        }
        // If the game has ended, skip the Update() function
        //If the game is over, exit
        if (isGameOver)
        {
            if (Input.GetKeyDown("r"))
            {
                // RestartGame();

                // MyFunctions.LoadWinScene();
                // Invoke("LoadMainScene", 2.0f);

                LoadMainScene();
            }
            return;
        }







        //Update the total game time and tell the UI Manager to update
        totalGameTime += Time.deltaTime;
        // UIManager.UpdateTimeUI(totalGameTime);
        // UIManager.UpdateTimeUI(Time.timeSinceLevelLoad);


        if (Application.platform == RuntimePlatform.WindowsEditor && Input.GetKeyDown("t"))
        {
            // PlayerWonLevel(levelManager.currentlevelNumber);


        }



        // if (Input.GetKey("escape") && SceneManager.GetActiveScene().name == "MyTitle")
        // {
        //     Application.Quit();

        // }






    }





    public void LoadWinScene()
    {
        SceneManager.LoadScene("MyWin");
    }
    public void LoadTitleScene()
    {
        SceneManager.LoadScene("MyTitle");
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MyMain");
    }
    public void RestartGame()
    {
       // Destroy(_player1);
        // foreach (var item in collectedOrbs)
        // {

        //     item.gameObject.SetActive(true);
        // }

        // collectedOrbs.Clear();
        // orbs.Clear();
        // levelManager.currentlevelNumber = 1;
        // levelManager.unloadalllevels();
        isGameOver = !isGameOver;
    }


    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


}












//example class implementation for accessing public fields, properties, and methods from the class anywhere using <ClassName>.Instance

public class MyClass : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log(GameManagerSingleton.Instance.gameName);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using Cinemachine;


//singleton

// namespace SpacePlebeGame{
public class SingletonGameManager : MonoBehaviour
{

    public string gameName;// = "Pixel Space";
    public string Version;// = "1.0.1";


    // public LevelManager levelManager;
    // public UIManager uIManager;
    // public AudioManager audioManager;
    
    
    
    public GameObject _player1;
    Vector3 startingPlayerPosition;

    public static SingletonGameManager current;


    public float deathSequenceDuration = 1.5f;  //How long player death takes before restarting



    //int currentlevelNumber;
    // List<Orb> orbs;                             //The collection of scene orbs
    // List<Orb> collectedOrbs;

    public bool paused;
    public GameObject PauseText;


    // Door lockedDoor;                            //The scene door
    // SceneFader sceneFader;                      //The scene fader
    // int numberOfDeaths;                         //Number of times player has died
    float totalGameTime;                        //Length of the total game time
    bool isGameOver;                            //Is the game currently over?

    // private GameObject player1;


    // LevelManager levelManager;
    void Awake()
    {
        //here is the beginning of the singleton pattern
        //If a Game Manager exists and this isn't it...
        if (current != null && current != this)
        {
            //...destroy this and exit. There can only be one Game Manager
            Destroy(gameObject);
            return;
        }

        //Set this as the current game manager
        current = this;

        //Create out collection to hold the orbs
        // orbs = new List<Orb>();
        // collectedOrbs = new List<Orb>();
        // startingPlayerPosition = new Vector3(3.66f, 17, 0);



        //Persis this object between scene reloads
        DontDestroyOnLoad(gameObject);



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



    // void SpawnSpacePlebePlayer()
    // {

    //     CinemachineVirtualCamera camobject = (CinemachineVirtualCamera)gameObject.transform.Find("Cameras/CM vcam1").gameObject.GetComponent<CinemachineVirtualCamera>();

    //     if (_player1 != null)
    //     {
    //         Destroy(_player1);
    //     }

    //     _player1 = Instantiate(Resources.Load("SpacePlebePlayer", typeof(GameObject))) as GameObject;


    //     _player1.transform.position = startingPlayerPosition;
    //     // _player.transform.Rotate()
    //     _player1.transform.rotation = Quaternion.identity;

    //     camobject.Follow = _player1.transform;

    //     // _player1.gameObject.SetActive(true);


    // }


    // public void PlayerWonLevel(int levelnum)
    // {

    //     if (current == null) //If there is no current Game Manager, exit
    //     {
    //         return;
    //     }

    //     Destroy(_player1);
    //     UIManager.DisplayLevelWonGameOverText();//display "You Won!:

    //     //AudioManager.PlayWonAudio();
    //     UIManager.fadein();



    //     if (levelnum == 6)//you beat the last level, go to win game scene
    //     {


    //         current.isGameOver = true;//then maybe restartgame()?



    //         //RestartGame();
    //         levelManager.unloadalllevels();


    //         UIManager.UnDisplayLevelWonGameOverText();


    //         Invoke("LoadWinScene", 2.0f);

    //     }
    //     else if (levelnum <= 5)
    //     {
    //         levelManager.currentlevelNumber++;
    //         Invoke("LoadMainScene", 2.0f);

    //     }


    // }

    public static bool IsGameOver()
    {
        //If there is no current Game Manager, return false
        if (current == null)
            return false;

        //Return the state of the game
        return current.isGameOver;
    }

    // public static void PlayerGrabbedOrb(Orb orb)
    // {
    //     //If there is no current Game Manager, exit
    //     if (current == null)
    //         return;

    //     //If the orbs collection doesn't have this orb, exit
    //     if (!current.orbs.Contains(orb))
    //         return;

    //     //Remove the collected orb
    //     current.collectedOrbs.Add(orb);
    //     current.orbs.Remove(orb);

    //     //If there are no more orbs, tell the door to open
    //     // if (current.orbs.Count == 0)
    //     //     current.lockedDoor.Open();

    //     //Tell the UIManager to update the orb text
    //     UIManager.UpdateOrbUI(current.orbs.Count);
    // }
    // public static void RegisterOrb(Orb orb)
    // {
    //     //If there is no current Game Manager, exit
    //     if (current == null)
    //         return;

    //     //If the orb collection doesn't already contain this orb, add it
    //     if (!current.orbs.Contains(orb))
    //         current.orbs.Add(orb);

    //     //Tell the UIManager to update the orb text
    //     UIManager.UpdateOrbUI(current.orbs.Count);
    // }


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
        Destroy(_player1);
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

// }


// Invoke("LoadMainScene", 2.0f);
// Vector3 temp = new Vector3(3.66f, 20, 0);
// _player.transform.position = temp;
// Invoke("playerContinueToNext", 2.0f);
//  SceneManager.LoadScene("MyMain");
// StartCoroutine(Functions.FadeIn());
// if (!isGameOver && current.levelManager.currentlevelNumber != 1)
// {


// ResetPlayer();
// }
// else if (!isGameOver)
// {
// levelManager.loadlevel();

// ResetPlayer();
// }


// UIManager.gameOverText.gameObject.SetActive(true);
//all game won
//   StartCoroutine(Functions.LoadLevel("MyWin", 2.0f));
//StartCoroutine(Functions.LoadLevel("MyMain", 49.0f));
//load level with

// called when the game is terminated
// void ResetPlayer()
// {
// GameObject player = current.transform.Find("Basic Player Controller").gameObject;
// _player.transform.position = temp;



// Vector3 tempforcam = new Vector3(333,0,0);
// gameObject.transform.Find("CM vcam1").gameObject.transform.position = temp + tempforcam;
// Camera.main.transform.position = temp;

// }
//get, load, or active level
//levelManager = (LevelManager)FindObjectOfType(typeof(LevelManager));
//  currentlevelNumber = 1;
//----------------------------------------
// Game Over
//----------------------------------------

// IEnumerator GameOver () {

// 	// Set GameOver to true to skip the Update() function
// 	// Show the GameOver GameObject
// 	// Hide the UI GameObject where scores, health, bullet counters etc. would be parented

// 	isGameOver = true;
// 	transform.Find("GameOver").gameObject.SetActive(true);
// 	transform.Find("UI").gameObject.SetActive(false);

// 	// Wait for 3 seconds

// 	yield return new WaitForSeconds(3.0f);

// 	// Load the Title scene

// 	
// }

// switch (currentlevelNumber)
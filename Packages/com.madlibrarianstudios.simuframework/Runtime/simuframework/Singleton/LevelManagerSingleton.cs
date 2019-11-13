using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace mygamemanager
{
    public class LevelManagerSingleton : MonoBehaviour
    {


        public static LevelManagerSingleton currentLevelManagerSingleton;


        // FHIR_Level ileve;


        private IDictionary<int, IMyLevelSingleton> levels;

        [Header("LevelManagerSingleton Core")]
        public int currentlevelNumber;
        public bool useResourceLevel;
        public int numberOfLevelsInResources;


        [Header("To Implement")]
        public bool isLevelRunning;


        //start of the game
        void Awake()
        {

            if (currentLevelManagerSingleton != null && currentLevelManagerSingleton != this)
            {
                Destroy(gameObject);
                return;
            }

            currentLevelManagerSingleton = this;
            currentLevelManagerSingleton.currentlevelNumber = 1;

            //inthefuture should I initiate from prefab or scriptable object. depends on if single scene game. 

            if (useResourceLevel)
            {
                levels = InitiateGameLevelsFromResources();
            }

            DontDestroyOnLoad(gameObject);
        }



        public Dictionary<int, IMyLevelSingleton> InitiateGameLevelsFromResources()
        {
            Dictionary<int, IMyLevelSingleton> tempdict = new Dictionary<int, IMyLevelSingleton>();

            for (int i = 1; i <= numberOfLevelsInResources; i++)
            {

                string prepthestring = string.Concat("0", i.ToString());
                //  GameObject gb = gameObject.transform.Find(prepthestring).gameObject;
                GameObject gb = Instantiate(Resources.Load("Levels/" + prepthestring, typeof(GameObject))) as GameObject;
                gb.transform.parent = currentLevelManagerSingleton.transform;
                gb.SetActive(false);
                tempdict.Add(i, (IMyLevelSingleton)gb.GetComponent<IMyLevelSingleton>());

                // Debug.Log(gb.name + " is preparing to upload to MyLevel manager from resources");

            }


            return tempdict;
        }


        //thinking adding parameter of level number here, maybe?
        public void ActivateCurrentLevel()
        {
            if (useResourceLevel)
            {
                if (currentlevelNumber == 1)
                {
                    levels[1].LoadLevel(currentlevelNumber);
                }
                else
                {
                    int previousInt = currentlevelNumber - 1;
                    levels[currentlevelNumber].LoadLevel(currentlevelNumber);
                }
            }
            else
            {
                // ileve = (FHIR_Level)FindObjectOfType<FHIR_Level>();
                // ileve.LoadLevel(currentlevelNumber);
            }
        }


        public void ContinueToNextLevel(int levelnum)
        {
            //this is where I shold add up everything for game stats 
            // if (levelnum == LevelManagerSingleton.numberOfLevelsInResources)//you beat the last level, go to win game scene
            // {

            //     if (isLevelWon)
            //     {
            //         isLevelWon = !isLevelWon;
            //     }
            //     GameManager.MakeGameOver();


            //     LevelManagerSingleton.deactivateAllLevels();

            //     UIManager.DisplayLevelWonGameOverText(false);


            //     gameManager.Invoke("LoadWinScene", 2.0f);

            // }
            // else if (levelnum < LevelManagerSingleton.numberOfLevelsInResources)
            // {
            //     LevelManagerSingleton.currentlevelNumber++;

            //     RestartLevel();

            // }
        }
        public void deactivateAllLevels()
        {

            if (useResourceLevel)
            {
                foreach (var item in levels)
                {
                    // item.Value.gameObject.SetActive(false);
                }
            }

        }

        public void StartLevelFromButtonPush()
        {
            if (useResourceLevel)
            {
                levels[currentlevelNumber].StartLevel();
            }
            else
            {
                
                // ileve.StartLevel();
            }

        }

    }
}





// Start is called before the first frame update
// public Dictionary<int, UBS_Level> InitiateGameLevelsFromScene()
// {
//     Dictionary<int, UBS_Level> tempdict = new Dictionary<int, UBS_Level>();

//     for (int i = 1; i < totalNumberLevels; i++)
//     {

//         string prepthestring = string.Concat("0", i.ToString());
//         GameObject gb = gameObject.transform.Find(prepthestring).gameObject;
//         tempdict.Add(i, (UBS_Level)gb.GetComponent<UBS_Level>());
//         // Debug.Log(gb.name + " is preparing to upload to level manager");

//     }

//     // i need to get all the MyLevels
//     return tempdict;
// }


// switch (currentlevelNumber)
// {
//     case 1:
//         levels[1].gameObject.SetActive(true);
//         break;
//     case 2:
//         levels[1].gameObject.SetActive(false);
//         levels[2].gameObject.SetActive(true);
//         break;
//     case 3:
//         levels[2].gameObject.SetActive(false);
//         levels[3].gameObject.SetActive(true);
//         break;
//     case 4:
//         levels[3].gameObject.SetActive(false);
//         levels[4].gameObject.SetActive(true);
//         break;
//     case 5:
//         levels[4].gameObject.SetActive(false);
//         levels[5].gameObject.SetActive(true);
//         break;
//     case 6:
//         levels[5].gameObject.SetActive(false);
//         levels[6].gameObject.SetActive(true);
//         break;
//     default:
//         Debug.Log("break");
//         break;
// }

// foreach (var item in levels)
// {
//     item.Value.gameObject.SetActive(false);
// }
// levels[currentlevelNumber].gameObject.SetActive(true);

// if (level == 1)
// {
//     levels[level].gameObject.SetActive(true);

// }
// else
// {
//     levels[level--].gameObject.SetActive(false);
//     levels[level].gameObject.SetActive(true);

// }
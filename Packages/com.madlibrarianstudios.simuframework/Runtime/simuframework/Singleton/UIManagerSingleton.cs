using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;
public class UIManagerSingleton : MonoBehaviour
{   //This class holds a static reference to itself to ensure that there will only be
    //one in existence. This is often referred to as a "singleton" design pattern. Other
    //scripts access this one through its public static methods
    static UIManagerSingleton current;


    [Header("Common UI")]
    public TextMeshProUGUI timeText;
    public GameObject gameOverTextObject;   //Text element showing the Game Over message
    public GameObject playerHasDiedText;   //Text element showing the Game Over message
    public Image blackFadeImage;
    public TextMeshProUGUI levelNumberText;         //Text element showing number of orbs
    public GameObject PauseText;


    [Header("Game Specific UI")]
    public TextMeshProUGUI coinsObjectiveForLevel;
    public TextMeshProUGUI highScoreForGame;
    public TextMeshProUGUI coinsCollectedForLevel;
    public TextMeshProUGUI totalCoinCollectedGame;
    public TextMeshProUGUI distanceTraveledForLevel;
    // public TextMeshProUGUI totalLogsDestoriedForGame;
    public GameObject buttonGameobject;


    public static void ShowGameStartButton(bool isEnabled)
    {
        //If there is no current UIManagerSingleton, exit
        if (current == null)
            return;


        current.buttonGameobject.SetActive(isEnabled);
    }
    public static void UpdateTotalCoinsCollectedUI(int totalCoinCollected)
    {
        //If there is no current UIManagerSingleton, exit
        if (current == null)
            return;

        //Update the text orb element
        current.totalCoinCollectedGame.text = totalCoinCollected.ToString();
    }


    public static void UpdateTotalLogsDectoriedUI(int totalLogsDetoryed)
    {
        //If there is no current UIManagerSingleton, exit
        if (current == null)
            return;

        //Update the text orb element
        current.distanceTraveledForLevel.text = totalLogsDetoryed.ToString();
    }


    void Awake()
    {
        //If an UIManager exists and it is not this...
        if (current != null && current != this)
        {
            //...destroy this and exit. There can be only one UIManagerSingleton
            Destroy(gameObject);
            return;
        }

        //This is the current UIManager and it should persist between scene loads
        current = this;



        Color blackwithalpha = new Color(0.0f, 0.0f, 0.0f, 1.0f);

        current.blackFadeImage.color = blackwithalpha;
        // current.blackFadeImage.canvasRenderer.SetAlpha(0.0f);
        DontDestroyOnLoad(gameObject);
    }

    public static void setalphafadein()
    {
        current.blackFadeImage.canvasRenderer.SetAlpha(0.0f);
    }
    public static void setalphafadeout()
    {
        current.blackFadeImage.canvasRenderer.SetAlpha(1.0f);
        Debug.Log("setting alpha out");
    }

    public static void fadein()
    {
        current.blackFadeImage.canvasRenderer.SetAlpha(0.0f);
        current.blackFadeImage.CrossFadeAlpha(1, 1, false);
        Debug.Log("fade in now");
    }
    public static void fadeout()
    {
        current.blackFadeImage.canvasRenderer.SetAlpha(1.0f);
        current.blackFadeImage.CrossFadeAlpha(0, 2, false);

        Debug.Log("fadeout now");
    }


    public static void UpdateCoinsObjectiveUIText(int coinToGo)
    {
        //If there is no current UIManagerSingleton, exit
        if (current == null)
            return;

        //Update the text orb element
        current.coinsObjectiveForLevel.text = coinToGo.ToString();
    }

    public static void DisplayHighScoreUIText(float highScore)
    {
        //If there is no current UIManager, exit
        if (current == null)
            return;

        //Update the text orb element
        current.highScoreForGame.text = highScore.ToString();
    }
    public static void UpdateDistanceTraveledUIText(float distance)
    {
        //If there is no current UIManagerSingleton, exit
        if (current == null)
            return;
            // Debug.Log(distance.ToString());
        current.distanceTraveledForLevel.text = distance.ToString();
    }
    public static void UpdateCoinsCollectedUIText(int numOfCoins)
    {

        //If there is no current UIManager, exit
        if (current == null)
            return;

        current.coinsCollectedForLevel.text = numOfCoins.ToString();

    }




    public static void UpdateTimeUI(float time)
    {
        //If there is no current UIManagerSingleton, exit
        if (current == null)
            return;

        //Take the time and convert it into the number of minutes and seconds
        int minutes = (int)(time / 60);
        float seconds = time % 60f;

        //Create the string in the appropriate format for the time
        current.timeText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    public static void UpdateLevelNumberUI(int levelNumber)
    {
        //If there is no current UIManager, exit
        if (current == null)
            return;

        //Update the text orb element
        current.levelNumberText.text = levelNumber.ToString();
    }




    public static void DisplayPlayerHasDiedText(bool isActive)
    {
        //If there is no current UIManagerSingleton, exit
        if (current == null)
            return;
        //Show the game over text
        if (isActive)
        {
            current.playerHasDiedText.gameObject.SetActive(true);
        }
        else
        {
            current.playerHasDiedText.gameObject.SetActive(false);
        }

    }
    public static void DisplayLevelWonGameOverText(bool isActive)
    {
        //If there is no current UIManager, exit
        if (current == null)
            return;
        //Show the game over text
        if (isActive)
        {
            current.gameOverTextObject.gameObject.SetActive(true);
        }
        else
        {
            current.gameOverTextObject.gameObject.SetActive(false);
        }

    }

    public static void UnDisplayTimeDuration()
    {
        if (current == null)
            return;


        current.timeText.gameObject.SetActive(false);

    }


    public static void ReDisplayTimeDuration()
    {
        if (current == null)
            return;


        current.timeText.gameObject.SetActive(true);

    }



    public static void DisplayPauseText(bool isActive)
    {
        if (isActive)
        {
            current.PauseText.gameObject.SetActive(true);
        }
        else
        {
            current.PauseText.gameObject.SetActive(false);
        }
    }
}


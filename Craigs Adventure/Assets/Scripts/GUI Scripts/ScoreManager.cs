using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    #region Variable List
    public GameObject startPos;
    public GameObject player;

    private float increaseSpeed = 700;
    public PlayerController p;

    public GameObject scoreDisplay;
    public static bool showDisplay;
    public Text activeScore, highScore, deathScore;

    public float s;
    public int activeScoreInt;
    public int highScoreInt = 0;
    #endregion

    private void Start()
    {
        scoreDisplay.SetActive(true);
        showDisplay = true;
    }
    private void Awake()
    {
        highScoreInt = PlayerPrefs.GetInt("HighScore");
        highScore.text = highScoreInt.ToString();

    }

    void Update()
    {
        CalculateDistance();

        //if the boolean variable showDisplay is equal to true, the gameobject attached to the variable scoreDisplay (Score Canvas) is set active, 
        //if else the gameobject attached to scoreDisplay (Score Canvas) is set inactive
        if (showDisplay == true)
        {
            scoreDisplay.SetActive(true);
        }
        else
        {
            scoreDisplay.SetActive(false);
        }

        if (s >= 500f) // if the score reaches 500
        {
            p.playerSpeed = increaseSpeed; //this will speed up the player
        }
    }

    private void CalculateDistance()
    {
        //the float variabble score is equal to the distance between the gameobjects assigned to the startPos
        //and player variables.
        s = Vector2.Distance(startPos.transform.position, player.transform.position);
        //converts the int variable called s to a string Text variable called activeScore
        activeScore.text = ((int)s).ToString();
        //converts the int variable called s to a string Text variable called deathScore
        deathScore.text = ((int)s).ToString();

        activeScoreInt = ((int)s);

        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if(activeScoreInt > highScoreInt)
        {
            highScoreInt = activeScoreInt;

            highScore.text = highScoreInt.ToString();

            PlayerPrefs.SetInt("HighScore", highScoreInt);
        }
    }
}

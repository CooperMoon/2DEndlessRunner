using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    #region Variable List
    public GameObject startPos;
    public GameObject player;

    float score;
    string currentScoreText;

    Text currentScore;
    #endregion

    private void Start()
    {
        //the variable currentScore become equal to text component attached to this Gameobject
        currentScore = this.GetComponent<Text>();
    }

    void Update()
    {
        //the float variabble score is equal to the distance between the gameobjects assigned to the startPos
        //and player variables.
        score = Vector2.Distance(startPos.transform.position, player.transform.position);
        //converts the float variable called score to a string variable called currentScoreText
        string currentScoreText = score.ToString();
        //the text component attached to the variable currentScore becomes equal to the string variable currentScoreText
        currentScore.text = currentScoreText;
    }
}

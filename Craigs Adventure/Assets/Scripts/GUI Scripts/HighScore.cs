using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public int highScoreInt;
    public Text highScore;
    private void Awake()
    {
        highScoreInt = PlayerPrefs.GetInt("HighScore");
        highScore.text = highScoreInt.ToString();
    }
}

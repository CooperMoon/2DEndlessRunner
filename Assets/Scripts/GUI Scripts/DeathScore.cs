using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScore : MonoBehaviour
{

    #region Variable List
    Text scoreOnDeath;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        scoreOnDeath = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreOnDeath.text = Score.currentScoreText;
    }

}
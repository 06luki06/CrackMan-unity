using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text displayScore;

    void Start()
    {
        int score = PlayerPrefs.GetInt("currentscore");
        int highscore = PlayerPrefs.GetInt("highscore");
        displayScore.text = "Score: " + score + "\n" + "Highscore: " + highscore;
    }
}
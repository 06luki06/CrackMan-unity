using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour
{
    public Text displayhighscore;

    void Start()
    {
        int currentHighscore = PlayerPrefs.GetInt("highscore");
        displayhighscore.text = "Highscore: " + currentHighscore;
    }
}
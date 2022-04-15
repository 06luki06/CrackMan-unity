using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour{
    public CrackManController crackman;
    public Text score;

    // Update is called once per frame
    void Update(){
        score.text = "SCORE: " + crackman.coinsCollected;
    }
}

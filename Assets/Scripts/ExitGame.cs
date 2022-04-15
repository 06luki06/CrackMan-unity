using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour{

    public Button exit;
    void Start(){
        exit.onClick.AddListener(doExitGame);
    }
    
    void doExitGame(){
        Application.Quit();
        Debug.Log("Application will no be closed");
    }
}
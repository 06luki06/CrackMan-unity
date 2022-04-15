using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartController : MonoBehaviour

{
    public Button start;
    public Button info;

    void Start(){
        start.onClick.AddListener(SwitchToGame);
        info.onClick.AddListener(SwitchToInfo);
    }
    
    void SwitchToGame(){
        SceneManager.LoadScene(1);
    }

    void SwitchToInfo(){
        SceneManager.LoadScene(3);
    }
}

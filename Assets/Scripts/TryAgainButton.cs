using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
    public Button tryAgain;
    void Start(){
        tryAgain.onClick.AddListener(RestartLevel);
    }
    
    void RestartLevel(){
        SceneManager.LoadScene(1);
    }
}

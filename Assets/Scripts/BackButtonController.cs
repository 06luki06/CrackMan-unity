using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButtonController : MonoBehaviour
{
    public Button back;
    void Start(){
        back.onClick.AddListener(BackToMenu);
    }
    
    void BackToMenu(){
        SceneManager.LoadScene(0);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
    public AudioSource gameOver;
    void Start()
    {
        gameOver.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CrackManController : MonoBehaviour{

    public CharacterController controller;
    public Transform cam;
    public float speed = 50f;
    public float turnTime = 0.1f;
    float turnSpped;
    public CoinSpawner coinSum;
    public EnemySpawner ghosts;
    public AudioSource collectCoinAudio;
    public AudioSource movement;

    public int coinsCollected;

    void Start(){
        coinsCollected = 0;
    }

    void FixedUpdate(){
        

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)){
            movement.Play();
        }

        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)){
            movement.Pause();
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f){
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; //Atan2 = x/y --> angle
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSpped, turnTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Coin"){
            Destroy(hit.gameObject);
            collectCoinAudio.Play();
            coinSum.coinSum--;
            coinsCollected++;

            if(coinsCollected % 3 == 0){
                ghosts.SpawnGhost();
            }

            calcHighScore(coinsCollected);
        }

        if(hit.gameObject.tag == "Enemy"){
            Result(coinsCollected);
            
        }
    }

    void Result(int currentScore){
        PlayerPrefs.SetInt("currentscore", currentScore);
        SceneManager.LoadScene(2);
    }

    void calcHighScore(int currentScore){
        int currentHighscore = PlayerPrefs.GetInt("highscore");
        if(currentScore > currentHighscore){
            PlayerPrefs.SetInt("highscore", currentScore);
            PlayerPrefs.Save();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrackManController : MonoBehaviour{
    public Rigidbody rb;
    public float speed = 50f;
    public float angle;
    public CoinSpawner coinSum;
    public EnemySpawner ghosts;
    public AudioSource collectCoinAudio;
    public int coinsCollected;

    void Start(){
        coinsCollected = 0;
    }

    void FixedUpdate(){
        rb.velocity = new Vector3(0, 0, 0);
        
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        /*
        if (Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }


        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(transform.position.x + 1, 0, -speed);
            //rb.AddForce(speed * Time.deltaTime, 0, 0);
             //this.transform.TransformDirection(new Vector3(inputHorizontal, 0, inputVertical) * speed * Time.deltaTime).normalized;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(transform.position.x -1, 0, speed);
        }*/


        float mouse = Input.GetAxis("Mouse X");
        //transform.Rotate(0, mouse, 0);
        //rb.velocity = new Vector3(inputVertical, 0, 0) * speed;
        //TODO: change the type of movement
        this.transform.Translate(new Vector3(0, 0, inputVertical) * speed * Time.deltaTime);
        this.transform.Rotate(new Vector3(0, inputHorizontal, 0) * angle * Time.deltaTime);
        //this.transform.Rotate(new Vector3(-mouse * 10, 0, 0));
    }

    void OnTriggerEnter(Collider hit){
        if (hit.gameObject.tag == "Coin")
        {
            Destroy(hit.gameObject);
            collectCoinAudio.Play();
            coinSum.coinSum--;
            coinsCollected++;

            if(coinsCollected % 3 == 0){
                ghosts.SpawnGhost();
            }
        }

        if(hit.gameObject.tag == "Enemy"){
            Respawn();
        }
    }

    void Respawn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
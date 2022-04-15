using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackManController : MonoBehaviour{
    public Rigidbody rb;
    public float speed = 50f;
    public float angle;
    public CoinSpawner coinSum;
    public AudioSource collectCoinAudio;
   

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void FixedUpdate(){
        rb.velocity = new Vector3(0, 0, 0);

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
            rb.velocity = new Vector3(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, speed);
        }*/

        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        float mouse = Input.GetAxis("Mouse X");
        //transform.Rotate(0, mouse, 0);
        //rb.velocity = new Vector3(inputVertical, 0, 0) * speed;
        //TODO: change the type of movement
        this.transform.Translate(new Vector3(0, 0, inputVertical) * speed * Time.deltaTime);
        this.transform.Rotate(new Vector3(0, inputHorizontal, 0) * angle * Time.deltaTime);
        //this.transform.Rotate(new Vector3(-mouse * 10, 0, 0));


    }


    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Coin")
        {
            Destroy(hit.gameObject);
            collectCoinAudio.Play();
            coinSum.coinSum--;
        }

        if(hit.gameObject.tag == "Terrain"){
            Debug.Log("hit");
        }
    }
}

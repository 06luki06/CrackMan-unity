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
    void Update(){
        /*if (Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(speed * -1, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0, 0, speed * -1);
        }*/

        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        this.transform.Translate(new Vector3(0, 0, inputVertical) * speed * Time.deltaTime);
        this.transform.Rotate(new Vector3(0, inputHorizontal, 0) * angle * Time.deltaTime);

    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Coin")
        {
            Destroy(hit.gameObject);
            collectCoinAudio.Play();
            coinSum.coinSum--;
        }
    }
}

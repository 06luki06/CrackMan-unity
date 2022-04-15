using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour{
    public float speed = 30f;
    private Transform target;
    void Start(){
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update(){
        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}

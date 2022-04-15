using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour{
    public GameObject ghostBluePF;

    void Start(){
        SpawnGhost();
    }

    public void SpawnGhost(){
        float randomX = Random.Range(130, 640);
        float randomZ = Random.Range(230, 900);

        GameObject ghost = Instantiate(ghostBluePF);
        ghost.transform.position = new Vector3(randomX, 5, randomZ);
    }
}
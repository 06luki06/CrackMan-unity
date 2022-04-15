using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour{
    public GameObject coinPF;
    public int coinSum;

    void Start(){
        coinSum = 0;
    }
    void Update(){
        if(coinSum == 0)
        {
            SpawnCoin();
        }
    }

    public void SpawnCoin(){
        float randomX = Random.Range(130, 640);
        float randomZ = Random.Range(230, 900);

        GameObject coin = Instantiate(coinPF);
        coin.transform.position = new Vector3(randomX, 15, randomZ);
        coinSum++;
    }
}
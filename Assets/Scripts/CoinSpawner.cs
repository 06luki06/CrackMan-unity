using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPF;
    public int coinSum = 0;

    // Start is called before the first frame update
    void Update()
    {
        if(coinSum == 0)
        {
            SpawnCoin();
        }
        
    }

    public void SpawnCoin()
    {
        float randomX = Random.Range(130, 640);
        float randomZ = Random.Range(230, 900);

        GameObject coin = Instantiate(coinPF);
        coin.transform.position = new Vector3(randomX, 15, randomZ);
        coinSum++;
    }

    /*void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject.tag == "Player")
        {
            SpawnCoin();
            Debug.Log("hit");
        }
    }*/
}

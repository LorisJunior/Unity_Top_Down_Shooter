using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]private GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 1, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {
        float xRange = 15f;
        float xPosition = Random.Range(-xRange, xRange);
        int enemyIndex = Random.Range(0, 2);
        Vector3 spawnPosition = new Vector3(xPosition, 1, 6);

        Instantiate(enemies[enemyIndex], spawnPosition, enemies[enemyIndex].transform.rotation);
    }
}

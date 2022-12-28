using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]private GameObject[] enemies;
    private int enemyIndex = 0;
    private float xPosition = 0f;
    private float xRange = 17f;
    private Vector3 spawnPosition;

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
        xPosition = Random.Range(-xRange, xRange);
        enemyIndex = Random.Range(0, 2);
        spawnPosition = new Vector3(xPosition, 0, 10);

        Instantiate(enemies[enemyIndex], spawnPosition, enemies[enemyIndex].transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float zPosition = 16f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyEnemy();
        DestroyProjectile();
        
    }

    private void DestroyEnemy()
    {
        if (transform.position.z < -zPosition)
        {
            int enemyPoint = gameObject.GetComponent<EnemySetup>().point;

            gameManager.UpdateScore(-enemyPoint);
            Destroy(gameObject);
        }
    }

    private void DestroyProjectile()
    {
        if (transform.position.z > zPosition)
        {
            Destroy(gameObject);
        }
    }
}

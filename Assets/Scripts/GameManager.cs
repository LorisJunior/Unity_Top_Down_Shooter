using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private TextMeshProUGUI scoreText;
    public float spawnRate;
    private int score;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        spawnRate = 1.5f;
        StartCoroutine("SpawnManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int addToScore)
    {
        score += addToScore;
        scoreText.text = $"Score: {score}";
    }

    IEnumerator SpawnManager()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(spawnRate);
            SpawnEnemies();
            GameState();
        }
    }

    void SpawnEnemies()
    {
        float xRange = 15f;
        float xPosition = Random.Range(-xRange, xRange);
        int enemyIndex = Random.Range(0, enemies.Length);
        Vector3 spawnPosition = new Vector3(xPosition, 1, 5);

        Instantiate(enemies[enemyIndex], spawnPosition, enemies[enemyIndex].transform.rotation);
    }

    private void GameState()
    {
        if (score < 0)
        {
            isGameOver = true;
        }
    }
}

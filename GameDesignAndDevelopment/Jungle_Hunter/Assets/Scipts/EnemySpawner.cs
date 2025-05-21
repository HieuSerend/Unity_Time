using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1.5f;
    public float spawnSpeedDecrease = 0.01f;
    public float minSpawnInterval = 0.5f;
    public float spawnRangeX = 24.0f;
    public float spawnZ = 50.0f;

    public float currentEnemySpeed = 10f;
    public float speedIncrease = 1.0f;
    public float maxSpeed = 40f;
    public float increaseInterval = 5.0f;
    private float speedTimer = 0f;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void Update()
    {
        speedTimer += Time.deltaTime;
        if (speedTimer >= increaseInterval)
        {
            currentEnemySpeed = Mathf.Min(currentEnemySpeed + speedIncrease, maxSpeed);
            speedTimer = 0f;
        }
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnZ);
            GameObject enemy = new GameObject();
            // Gán tốc độ hiện tại cho enemy mới
            for (int i = 0; i < 2; i++)
            {
                enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
                spawnPosition.x = Random.Range(-10, 10);
            }
            enemy.GetComponent<Enemy_Controller>().speed = currentEnemySpeed;
            spawnInterval = Mathf.Max(spawnInterval - spawnSpeedDecrease, minSpawnInterval);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

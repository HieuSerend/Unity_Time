using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    public float spawnRangeX = 24.0f;
    public float spawnZ = 50.0f;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private void Update()
    {
        
    }

    protected override IEnumerator SpawnObjects()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnZ);
            // Spawn a random number of objects between minSpawnQuantity and maxSpawnQuantity
            int spawnQuantity = Random.Range(minSpawnQuantity, maxSpawnQuantity + 1);
            for (int i = 0; i < spawnQuantity; i++)
            {
                Instantiate(spawnPrefab, spawnPosition, Quaternion.identity);
                spawnPosition.x = Random.Range(-10, 10);
            }
            spawnInterval = Mathf.Max(spawnInterval - spawnSpeedDecrease, minSpawnInterval);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

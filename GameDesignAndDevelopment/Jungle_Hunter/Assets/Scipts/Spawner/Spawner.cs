using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float spawnInterval = 1.5f;
    public float spawnSpeedDecrease = 0.01f;
    public float minSpawnInterval = 0.5f;

    public int minSpawnQuantity = 1;
    public int maxSpawnQuantity = 2;

    protected float currentSpawnInterval;
    protected virtual void Start()
    {
        currentSpawnInterval = spawnInterval;
        StartCoroutine(SpawnObjects());
    }

    protected abstract IEnumerator SpawnObjects();
}

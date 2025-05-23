using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{

    public Transform firePoint;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullet();
        }
    }

    private void SpawnBullet()
    {
        Vector3 spawnPos = new Vector3(firePoint.position.x, 3, 5);
        Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
    }

    protected override IEnumerator SpawnObjects()
    {
        yield return null;
    }
}

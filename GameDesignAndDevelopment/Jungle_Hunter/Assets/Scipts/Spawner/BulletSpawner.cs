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
        Vector3 spawnPos = firePoint != null ? firePoint.position : transform.position;
        GameObject bullet = Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
        Destroy(bullet, 6f);
    }

    protected override IEnumerator SpawnObjects()
    {
        yield return null;
    }
}

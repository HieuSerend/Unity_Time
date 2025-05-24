using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private bool isLimited = false;
    private int count = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isLimited)
        {
            SpawnBullet();
            count++;
            if (count >= 3)
            {
                isLimited = true;
                count = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isLimited)
        {
            StartCoroutine(SpawnObjects());
            isLimited = false;
        }

    }

    private void SpawnBullet()
    {
        if (spawnPrefab != null && firePoint != null)
        {
            Vector3 spawnPos = new Vector3(firePoint.position.x, -2, 5);
            Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
        }
    }

    protected override IEnumerator SpawnObjects()
    {
        yield return new WaitForSeconds(spawnInterval); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Enemies
{


    private void Update()
    {
        StartCoroutine(SpawnEnemy(spawnDelay,enemyPrefab));
    }


    private IEnumerator SpawnEnemy(float delay, GameObject Enemy)
    {
        yield return new WaitForSeconds(delay);
        GameObject newEnemy = Instantiate(Enemy);
        StartCoroutine(SpawnEnemy(delay, Enemy));
    }
}
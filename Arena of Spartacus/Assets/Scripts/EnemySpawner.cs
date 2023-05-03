using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float enemyInterval = 3.5f;

    public EnemyAi enmeyAi;

    float x;
    float y;
    float z;

    private void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
        
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        x = Random.Range(-35, 35);
        y = .5f;
        z = Random.Range(-35, 40);

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(x, y, z), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
        enmeyAi.agent1.Warp(transform.position);
        enmeyAi.agent1.enabled = true;
        //enmeyAi.ChasePlayer();
        
    }
}

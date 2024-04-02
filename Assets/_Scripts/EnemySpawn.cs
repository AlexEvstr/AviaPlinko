using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemies;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            int randomEnemy = Random.Range(0, _enemies.Length);
            GameObject newEnemy = Instantiate(_enemies[randomEnemy]);
            yield return new WaitForSeconds(Random.Range(1, 3));
        }
    }


}

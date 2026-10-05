using System.Collections;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public float minRandom = 0.2f;
    public float maxRandom = 1f;
    public GameObject enemy1;
    public GameObject enemy2;
    private GameObject player;
    private GameObject enemy;

    void Start()
    {
        if (player == null) 
            player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(RandomTimerLoop());
    }
    IEnumerator RandomTimerLoop()
    {
        yield return new WaitForSeconds(Random.Range(minRandom, maxRandom));
        SpawnEnemy();
        StartCoroutine(RandomTimerLoop());
    }
    void SpawnEnemy()
    {
        int random = Random.Range(1, 3);
        if (random == 1)
            enemy = enemy1;
        if (random == 2)
            enemy = enemy2;
        Vector2 spawnArea = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
        float dist = Vector2.Distance(spawnArea, player.transform.position);
        if (dist >= 2f)
            Instantiate(enemy, spawnArea, Quaternion.identity);
    }
}

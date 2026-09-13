using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float baseSpawnRate = 3f;
    public float minSpawnRate = 0.5f; // Lo más rápido que pueden aparecer
    public float spawnDistance = 15f;
    
    private float nextSpawnTime;

    void Update()
    {
        if (GameManager.instance == null || GameManager.instance.timeRemaining <= 0) return;

        // DIFICULTAD PROGRESIVA:
        // Por cada 50 puntos, bajamos el tiempo de espera en 0.2 segundos
        float currentDifficultyBonus = (GameManager.instance.score / 50) * 0.2f;
        float currentSpawnRate = Mathf.Max(minSpawnRate, baseSpawnRate - currentDifficultyBonus);

        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + currentSpawnRate;
        }
    }

    void SpawnEnemy()
    {
        Vector2 randomPos = Random.insideUnitCircle.normalized * spawnDistance;
        Vector3 finalPos = Camera.main.transform.position + new Vector3(randomPos.x, 0.5f, randomPos.y);
        Instantiate(enemyPrefab, finalPos, Quaternion.identity);
    }
}
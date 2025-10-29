using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnInterval = 2f;
    public float spawnXRange = 2.5f;

    private void Start()
    {
        InvokeRepeating("SpawnBall", 1f, spawnInterval);
    }

    void SpawnBall()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnXRange, spawnXRange), 5f, 0f);
        Instantiate(ballPrefab, spawnPos, Quaternion.identity);
    }
}


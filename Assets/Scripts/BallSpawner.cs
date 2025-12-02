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

        // yangi sharni yaratamiz
        GameObject newBall = Instantiate(ballPrefab, spawnPos, Quaternion.identity);

        // Sharni Sprite Renderer'ini topamiz
        SpriteRenderer sr = newBall.GetComponent<SpriteRenderer>();

        // Tasodifiy ranglar ro'yxati
        Color[] colors = new Color[]
        {
            Color.red,
            Color.blue,
            Color.green,
            Color.yellow,
            Color.magenta,
            Color.cyan
        };

        // Random rang beramiz
        sr.color = colors[Random.Range(0, colors.Length)];
    }
}



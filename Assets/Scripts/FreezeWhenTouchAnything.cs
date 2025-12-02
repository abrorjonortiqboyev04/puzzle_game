using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Yerga yoki boshqa shar ustiga tushsa
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Ball"))
        {
            rb.velocity = Vector2.zero; // harakatni to‘xtatadi
            rb.bodyType = RigidbodyType2D.Static; // sharni muzlatadi
        }
    }
}

using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 3f;

    private bool isFrozen = false; // shar qotganini tekshiramiz

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isFrozen) return; // Agar shar qotgan bo‘lsa boshqarmaymiz

        float move = Input.GetAxisRaw("Horizontal"); // A/D yoki ←/→
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Agar yer yoki boshqa shar bilan urilsa qotadi
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Ball"))
        {
            FreezeBall();
        }
    }

    void FreezeBall()
    {
        isFrozen = true;
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Static; // sharni muzlatamiz
    }
}

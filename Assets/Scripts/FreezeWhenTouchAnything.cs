
using UnityEngine;

public class FreezeWhenTouchAnything : MonoBehaviour
{
    Rigidbody2D rb;
    bool frozen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Faqat bir marta muzlatish
        if (frozen) return;

        // Har qanday obyektga tegsa (yer yoki boshqa shar)
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Ball"))
        {
            FreezeBall();
        }
    }

    void FreezeBall()
    {
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        rb.bodyType = RigidbodyType2D.Static; // endi harakatlanmaydi
        frozen = true;
    }
}

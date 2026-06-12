using UnityEngine;

public class FruitLauncher : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = new Vector2(
            Random.Range(-3f, 3f),
            Random.Range(8f, 12f)
        );
    }
}
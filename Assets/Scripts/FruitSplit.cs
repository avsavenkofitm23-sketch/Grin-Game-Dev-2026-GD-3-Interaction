using UnityEngine;

public class FruitSplit : MonoBehaviour
{
    public GameObject leftHalf;
    public GameObject rightHalf;

    public float splitForce = 4f;
    public float upwardForce = 2f;

    private void OnMouseDown()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore();
        }

        CreateHalf(leftHalf, new Vector2(-1f, 1f));
        CreateHalf(rightHalf, new Vector2(1f, 1f));

        Destroy(gameObject);
    }

    private void CreateHalf(GameObject halfPrefab, Vector2 direction)
    {
        if (halfPrefab == null)
        {
            Debug.LogWarning("Half prefab is not assigned!");
            return;
        }

        GameObject half = Instantiate(
            halfPrefab,
            transform.position,
            Quaternion.identity
        );

        half.transform.localScale = transform.localScale;

        SpriteRenderer sr = half.GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            sr.sortingOrder = 20;
        }

        Rigidbody2D rb = half.GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            rb = half.AddComponent<Rigidbody2D>();
        }

        rb.gravityScale = 1f;
        rb.linearVelocity = new Vector2(
            direction.x * splitForce,
            direction.y * upwardForce
        );

        rb.angularVelocity = direction.x * -200f;

        Destroy(half, 3f);
    }
}
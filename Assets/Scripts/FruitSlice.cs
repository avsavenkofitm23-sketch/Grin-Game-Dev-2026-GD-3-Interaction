using UnityEngine;

public class FruitSlice : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore();
        }

        Destroy(gameObject);
    }
}
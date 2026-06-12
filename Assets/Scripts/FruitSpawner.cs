using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject grapesPrefab;

    void Start()
    {
        InvokeRepeating(nameof(SpawnFruit), 1f, 2f);
    }

    void SpawnFruit()
    {
        GameObject fruit;

        if (Random.Range(0, 2) == 0)
        {
            fruit = applePrefab;
        }
        else
        {
            fruit = grapesPrefab;
        }

        Instantiate(
            fruit,
            transform.position,
            Quaternion.identity
        );
    }
}
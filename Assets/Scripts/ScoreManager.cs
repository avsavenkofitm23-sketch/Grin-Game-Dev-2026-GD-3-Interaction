using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public static int score = 0;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        score = 0;
        scoreText.text = "Score: 0";
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
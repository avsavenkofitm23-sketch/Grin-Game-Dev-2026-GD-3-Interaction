using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitMissed : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -6f)
        {
            Time.timeScale = 0f;
        }

        if (Time.timeScale == 0f && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnGUI()
    {
        if (Time.timeScale == 0f)
        {
            GUIStyle style = new GUIStyle();

            style.fontSize = 50;
            style.normal.textColor = Color.white;
            style.alignment = TextAnchor.MiddleCenter;

            GUI.Label(
                new Rect(Screen.width / 2 - 250, Screen.height / 2 - 100, 500, 100),
                "GAME OVER",
                style
            );

            style.fontSize = 30;

            GUI.Label(
                new Rect(Screen.width / 2 - 250, Screen.height / 2 - 20, 500, 80),
                "Final Score: " + ScoreManager.score,
                style
            );

            GUI.Label(
                new Rect(Screen.width / 2 - 250, Screen.height / 2 + 40, 500, 80),
                "Press R to Restart",
                style
            );
        }
    }
}
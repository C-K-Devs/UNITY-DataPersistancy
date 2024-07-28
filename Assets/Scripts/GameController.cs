using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text timerText;
    public TMP_Text clickCountText;

    public float timeRemaining = 60f;
    private int clickCount = 0;

    private void Start()
    {
        clickCountText.text = "No. of clicks: " + clickCount;
    }

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time Left: " + Mathf.Round(timeRemaining).ToString();

            if (Input.GetMouseButtonDown(0)) // Detects left mouse button click
            {
                clickCount++;
                clickCountText.text = "No. of clicks: " + clickCount;
            }
        }
        else
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        int previousClicks = PlayerPrefs.GetInt("TotalClicks", 0);
        PlayerPrefs.SetInt("SessionClicks", clickCount);
        PlayerPrefs.SetInt("TotalClicks", previousClicks);
        SceneManager.LoadScene("GameOverScene");
    }
}

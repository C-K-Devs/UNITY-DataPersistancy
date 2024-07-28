using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text timerText;
    public TMP_Text clickCountText;

    private float timeRemaining = 60f;
    private int clickCount = 0;

    private void Start()
    {
        clickCountText.text = "Clicks: " + clickCount;
    }

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Round(timeRemaining).ToString();

            if (Input.GetMouseButtonDown(0)) // Detects left mouse button click
            {
                clickCount++;
                clickCountText.text = "Clicks: " + clickCount;
            }
        }
        else
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        int previousGameClicks = PlayerPrefs.GetInt("LastGameClicks", 0);
        PlayerPrefs.SetInt("PreviousGameClicks", previousGameClicks);
        PlayerPrefs.SetInt("LastGameClicks", clickCount);
        SceneManager.LoadScene("GameOverScene");
    }
}

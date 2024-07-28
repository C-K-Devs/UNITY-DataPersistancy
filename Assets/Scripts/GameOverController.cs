using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public TMP_Text gameOverText;
    public TMP_Text sessionClicksText;
    public TMP_Text totalClicksText;
    public Button backButton;

    private void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        int lastGameClicks = PlayerPrefs.GetInt("LastGameClicks", 0);
        int previousGameClicks = PlayerPrefs.GetInt("PreviousGameClicks", 0);

        gameOverText.text = "GAME OVER";
        sessionClicksText.text = playerName + "'s current clicks: " + lastGameClicks;
        totalClicksText.text = playerName + "'s last game clicks: " + previousGameClicks;

        backButton.onClick.AddListener(BackToMainMenu);
    }

    private void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}

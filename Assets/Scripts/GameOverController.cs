using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverController : MonoBehaviour
{
    
    public TMP_Text sessionClicksText;
    public TMP_Text totalClicksText;
    public Button backButton;

    private void Start()
    {
        sessionClicksText.text = PlayerPrefs.GetString("PlayerName", "Player") + "'s Total Clicks: " + PlayerPrefs.GetInt("SessionClicks", 0);
        totalClicksText.text = PlayerPrefs.GetString("PlayerName", "Player") + "'s Last Game Clicks: " + PlayerPrefs.GetInt("TotalClicks", 0);
        backButton.onClick.AddListener(BackToMainMenu);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private string playerName = ""; // Store the player name

    // Update is called once per frame
    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Store the player name from the input field
            GameObject inputFieldObj = GameObject.FindWithTag("PlayerNameInput");
            if (inputFieldObj != null)
            {
                InputField inputField = inputFieldObj.GetComponent<InputField>();
                if (inputField != null)
                {
                    playerName = inputField.text;
                }
            }

            SceneManager.LoadScene(1);
        }
    }

    // Getter method for accessing the player name
    public string GetPlayerName()
    {
        return playerName;
    }
}

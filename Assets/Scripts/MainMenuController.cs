using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuController : MonoBehaviour
{
    private Button playButton;
    private Button quitButton;

    private void OnEnable()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();

        playButton = uiDocument.rootVisualElement.Q<Button>("play-button");
        quitButton = uiDocument.rootVisualElement.Q<Button>("quit-button");

        playButton.clicked += PlayGame;
        quitButton.clicked += QuitGame;
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
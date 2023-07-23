using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    public void PlayVsAI()
    {
        SceneManager.LoadScene("Scenes/PickAIDifficulty");
    }

    public void PlayVsPlayer()
    {
        SceneManager.LoadScene("Scenes/GameVsPlayer");
    }

    public void Keybinds()
    {
        SceneManager.LoadScene("Scenes/Keybinds");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Scenes/Settings");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

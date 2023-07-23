using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    public void PlayVsAI()
    {
        SceneTracker.instance.prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Scenes/PickAIDifficulty");
    }

    public void PlayVsPlayer()
    {
        SceneTracker.instance.prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Scenes/GameVsPlayer");
    }

    public void Keybinds()
    {
        SceneTracker.instance.prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Scenes/Keybinds");
    }

    public void Settings()
    {
        SceneTracker.instance.prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Scenes/Settings");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class PickAIDifficultyNavigation : MonoBehaviour
{
    public static void LoadGameVsAIScene()
    {
        SceneTracker.instance.prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Scenes/GameVsAI");
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneTracker.instance.prevScene);
    }
}

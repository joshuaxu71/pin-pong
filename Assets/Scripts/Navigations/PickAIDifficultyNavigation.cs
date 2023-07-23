using UnityEngine;
using UnityEngine.SceneManagement;

public class PickAIDifficultyNavigation : MonoBehaviour
{
    public static void LoadGameVsAIScene()
    {
        SceneManager.LoadScene("Scenes/GameVsAI");
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneTracker.instance.prevScene);
    }
}

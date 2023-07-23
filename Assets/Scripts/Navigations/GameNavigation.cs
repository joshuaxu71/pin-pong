using UnityEngine;
using UnityEngine.SceneManagement;

public class GameNavigation : MonoBehaviour
{
    public static void LoadEndScreenScene()
    {
        SceneTracker.instance.prevScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Scenes/EndScreen");
    }
}

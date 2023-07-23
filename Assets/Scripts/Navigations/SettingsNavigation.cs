using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsNavigation : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(SceneTracker.instance.prevScene);
    }
}

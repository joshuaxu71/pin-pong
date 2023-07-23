using UnityEngine;
using UnityEngine.SceneManagement;

public class KeybindsNavigation : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(SceneTracker.instance.prevScene);
    }
}

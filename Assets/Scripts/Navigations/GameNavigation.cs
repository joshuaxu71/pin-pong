using UnityEngine;
using UnityEngine.SceneManagement;

public class GameNavigation : MonoBehaviour
{
    public static void LoadEndScreenScene()
    {
        SceneManager.LoadScene("Scenes/EndScreen");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTracker : MonoBehaviour
{
    public static SceneTracker instance = null;

    public int prevScene;

    void Awake()
    {
        try
        {
            Debug.Log(instance.gameObject.name);
            Debug.Log(instance.prevScene);
            Debug.Log(!instance);

        } catch { }
        if (!instance)
            instance = this;
        else
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
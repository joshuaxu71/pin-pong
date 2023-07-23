using System.IO;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    public static Entities.Keybinds keybinds;

    void Start()
    {
        try
        {
            // load keybinds from file
            string jsonPath = Application.streamingAssetsPath + "/keybinds.json";
            string jsonStr = File.ReadAllText(jsonPath);

            keybinds = JsonUtility.FromJson<Entities.Keybinds>(jsonStr);
        }
        catch
        {
            // use default keybindings
            keybinds = new Entities.Keybinds((int)KeyCode.UpArrow, (int)KeyCode.DownArrow, (int)KeyCode.W, (int)KeyCode.S);
        }
    }
}

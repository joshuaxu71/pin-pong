using System;
using System.IO;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    public static Entities.Keybinds keybinds;
    public static Entities.Settings settings;

    void Start()
    {
        try
        {
            // load keybinds from file
            string jsonPath = Application.streamingAssetsPath + "/keybinds.json";
            string jsonStr = File.ReadAllText(jsonPath);

            if (jsonStr == null || jsonStr == "") throw new Exception();

            keybinds = JsonUtility.FromJson<Entities.Keybinds>(jsonStr);
        }
        catch
        {
            // use default keybindings
            keybinds = new Entities.Keybinds((int)KeyCode.UpArrow, (int)KeyCode.DownArrow, (int)KeyCode.W, (int)KeyCode.S);
        }

        try
        {
            // load settings from file
            string jsonPath = Application.streamingAssetsPath + "/settings.json";
            string jsonStr = File.ReadAllText(jsonPath);

            if (jsonStr == null || jsonStr == "") throw new Exception();

            settings = JsonUtility.FromJson<Entities.Settings>(jsonStr);
        }
        catch
        {
            // use default settings
            settings = new Entities.Settings(5);
        }
    }
}

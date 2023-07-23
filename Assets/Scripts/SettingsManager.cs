using System.IO;
using TMPro;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public TMP_InputField scoreToWinInput;


    void OnDestroy()
    {
        // persist settings into file
        string settingsJson = JsonUtility.ToJson(Initializer.settings);
        File.WriteAllText(Application.streamingAssetsPath + "/settings.json", settingsJson);
    }

    public void AddToScoreToWin(int addedValue)
    {
        int scoreToWin = int.Parse(scoreToWinInput.text) + addedValue;
        scoreToWinInput.text = scoreToWin.ToString();
        Initializer.settings.scoreToWin = scoreToWin;
    }
}

using TMPro;
using UnityEngine;

public class SettingsInitializer : MonoBehaviour
{
    public TMP_InputField scoreToWinInput;

    void Start()
    {
        scoreToWinInput.text = Initializer.settings.scoreToWin.ToString();
    }
}

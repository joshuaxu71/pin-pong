using System;
using System.IO;
using TMPro;
using UnityEngine;

public class KeybindsInitializer : MonoBehaviour
{
    public TMP_Text player1UpInput;
    public TMP_Text player1DownInput;
    public TMP_Text player2UpInput;
    public TMP_Text player2DownInput;

    private bool inputShouldBeReset;
    private TMP_Text inputToReset;

    void Start()
    {
        player1UpInput.SetText(((KeyCode)Initializer.keybinds.player1Up).ToString());
        player1DownInput.SetText(((KeyCode)Initializer.keybinds.player1Down).ToString());
        player2UpInput.SetText(((KeyCode)Initializer.keybinds.player2Up).ToString());
        player2DownInput.SetText(((KeyCode)Initializer.keybinds.player2Down).ToString());

        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(OnTextChange);
    }

    void OnDestroy()
    {
        // persist keybinds into file
        string keybindsJson = JsonUtility.ToJson(Initializer.keybinds);
        File.WriteAllText(Application.streamingAssetsPath + "/keybinds.json", keybindsJson);

        TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(OnTextChange);
    }

    private void FixedUpdate()
    {
        if (inputShouldBeReset)
        {
            inputToReset.SetText(KeyCode.None.ToString());
            inputShouldBeReset = false;
        }
    }

    void OnTextChange(UnityEngine.Object obj)
    {
        TMP_Text tmp = (TMP_Text)obj;
        if (tmp == player1UpInput)
        {
            if (tmp.text.Equals(player1DownInput.text))
            {
                Initializer.keybinds.player1Down = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player1DownInput;
            }

            if (tmp.text.Equals(player2UpInput.text))
            {
                Initializer.keybinds.player2Up = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player2UpInput;
            }

            if (tmp.text.Equals(player2DownInput.text))
            {
                Initializer.keybinds.player2Down = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player2DownInput;
            }

            Initializer.keybinds.player1Up = (int)Enum.Parse(typeof(KeyCode), tmp.text);
        }
        else if (tmp == player1DownInput)
        {
            if (tmp.text.Equals(player1UpInput.text))
            {
                Initializer.keybinds.player1Up = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player1UpInput;
                player1UpInput.SetText(KeyCode.None.ToString());
            }

            if (tmp.text.Equals(player2UpInput.text))
            {
                Initializer.keybinds.player2Up = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player2UpInput;
                player2UpInput.SetText(KeyCode.None.ToString());
            }

            if (tmp.text.Equals(player2DownInput.text))
            {
                Initializer.keybinds.player2Down = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player2DownInput;
                player2DownInput.SetText(KeyCode.None.ToString());
            }

            Initializer.keybinds.player1Down = (int)Enum.Parse(typeof(KeyCode), tmp.text);
        }
        else if (tmp == player2UpInput)
        {
            if (tmp.text.Equals(player1UpInput.text))
            {
                Initializer.keybinds.player1Up = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player1UpInput;
                player1UpInput.SetText(KeyCode.None.ToString());
            }

            if (tmp.text.Equals(player1DownInput.text))
            {
                Initializer.keybinds.player1Down = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player1DownInput;
                player1DownInput.SetText(KeyCode.None.ToString());
            }

            if (tmp.text.Equals(player2DownInput.text))
            {
                Initializer.keybinds.player2Down = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player2DownInput;
                player2DownInput.SetText(KeyCode.None.ToString());
            }

            Initializer.keybinds.player2Up = (int)Enum.Parse(typeof(KeyCode), tmp.text);
        }
        else if (tmp == player2DownInput)
        {
            if (tmp.text.Equals(player1UpInput.text))
            {
                Initializer.keybinds.player1Up = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player1UpInput;
                player1UpInput.SetText(KeyCode.None.ToString());
            }

            if (tmp.text.Equals(player1DownInput.text))
            {
                Initializer.keybinds.player1Down = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player1DownInput;
                player1DownInput.SetText(KeyCode.None.ToString());
            }

            if (tmp.text.Equals(player2UpInput.text))
            {
                Initializer.keybinds.player2Up = (int)KeyCode.None;
                inputShouldBeReset = true;
                inputToReset = player2UpInput;
                player2UpInput.SetText(KeyCode.None.ToString());
            }

            Initializer.keybinds.player2Down = (int)Enum.Parse(typeof(KeyCode), tmp.text);
        }
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeybindsManager : MonoBehaviour
{
    private GameObject selectedInput;

    void OnGUI()
    {
        if (selectedInput != null && gameObject.Equals(EventSystem.current.currentSelectedGameObject))
        {
            Event e = Event.current;
            if (e.isKey)
            {
                if (e.keyCode != KeyCode.Escape)
                {
                    gameObject.GetComponent<TMP_Text>().SetText(e.keyCode.ToString());
                }
            }
            else if (e.isMouse)
            {
                gameObject.GetComponent<TMP_Text>().SetText(((KeyCode)((int)KeyCode.Mouse0 + e.button)).ToString());
            }
            else
            {
                return;
            }

            selectedInput = null;
            EventSystem.current.SetSelectedGameObject(null);
        }
        selectedInput = null;
    }

    public void SelectInput(GameObject selectedInput)
    {
        this.selectedInput = selectedInput;
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenNavigation : MonoBehaviour
{
    public void PlayAgain()
	{
		SceneManager.LoadScene(SceneTracker.instance.prevScene);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("Scenes/MainMenu");
	}

	public void Exit()
	{
		Application.Quit();
	}
}

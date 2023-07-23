using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static string winner;

    public bool againstAI;
    public int scoreToWin = 2;
    public TMP_Text scoreLeft;
    public TMP_Text scoreRight;

    public void Score(Rigidbody2D ball, string goalName)
    {
        if (goalName.Equals("Left"))
        {
            scoreRight.text = (int.Parse(scoreRight.text) + 1).ToString();
            if (scoreRight.text.Equals(scoreToWin.ToString()))
            {
                winner = "Player 1";
            }
        }
        else
        {
            scoreLeft.text = (int.Parse(scoreLeft.text) + 1).ToString();
            if (scoreLeft.text.Equals(scoreToWin.ToString()))
            {
                if (againstAI)
                {
                    winner = "The AI";
                }
                else
                {
                    winner = "Player 2";
                }
            }

        }

        if (scoreRight.text.Equals(scoreToWin.ToString()) || scoreLeft.text.Equals(scoreToWin.ToString()))
        {
            SceneTracker.instance.prevScene = SceneManager.GetActiveScene().buildIndex;
            GameNavigation.LoadEndScreenScene();
        }

        GameInitializer.PlayBall(ball);
    }
}

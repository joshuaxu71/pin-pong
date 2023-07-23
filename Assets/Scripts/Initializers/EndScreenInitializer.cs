using UnityEngine;
using TMPro;

public class EndScreenInitializer : MonoBehaviour
{
    public TMP_Text gameResultMessage;
    public TMP_Text gameResultDetails;

    private void Start()
    {
        gameResultMessage.SetText(ScoreManager.winner.Contains("Player") ? "Congratulations" : "Game Over");
        gameResultDetails.SetText($"{ScoreManager.winner} has won the game");
    }
}

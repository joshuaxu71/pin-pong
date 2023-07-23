using UnityEngine;

using Entities;

public class PickAIDifficulty : MonoBehaviour
{
    public static AIDifficulty selectedAIDifficulty;

    public void Easy()
    {
        selectedAIDifficulty = AIDifficulty.easyDifficulty;
        PickAIDifficultyNavigation.LoadGameVsAIScene();
    }

    public void Normal()
    {
        selectedAIDifficulty = AIDifficulty.normalDifficulty;
        PickAIDifficultyNavigation.LoadGameVsAIScene();
    }

    public void Hard()
    {
        selectedAIDifficulty = AIDifficulty.hardDifficulty;
        PickAIDifficultyNavigation.LoadGameVsAIScene();
    }

    public void Impossible()
    {
        selectedAIDifficulty = AIDifficulty.impossibleDifficulty;
        PickAIDifficultyNavigation.LoadGameVsAIScene();
    }
}

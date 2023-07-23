namespace Entities
{
    [System.Serializable]
    public class Settings
    {
        public int scoreToWin;

        public Settings(int scoreToWin)
        {
            this.scoreToWin = scoreToWin;
        }
    }
}
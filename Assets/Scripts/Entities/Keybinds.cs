namespace Entities
{
    [System.Serializable]
    public class Keybinds
    {
        public int player1Up;
        public int player1Down;
        public int player2Up;
        public int player2Down;

        public Keybinds(int player1Up, int player1Down, int player2Up, int player2Down)
        {
            this.player1Up = player1Up;
            this.player1Down = player1Down;
            this.player2Up = player2Up;
            this.player2Down = player2Down;
        }
    }
}
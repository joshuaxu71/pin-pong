namespace Entities
{
    public class AIDifficulty
    {
        public static AIDifficulty easyDifficulty = new AIDifficulty(25f, 0.25f);
        public static AIDifficulty normalDifficulty = new AIDifficulty(40f, 0.25f);
        public static AIDifficulty hardDifficulty = new AIDifficulty(50f, 0.25f);
        public static AIDifficulty impossibleDifficulty = new AIDifficulty(70f, 0.25f);

        // The amount of force to apply to the AI paddle on the y-axis
        public float movementForce { get; set; }

        // The percentage of deviation from the ball's x-axis towards the AI paddle's x-axis before the paddle starts chasing the ball
        public float alignmentDeviation { get; set; }

        public AIDifficulty(float movementForce, float alignmentDeviation)
        {
            this.movementForce = movementForce;
            this.alignmentDeviation = alignmentDeviation;
        }
    }
}
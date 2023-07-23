using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    public static Vector2 force;
    public int traverseDuration = 2;
    public int baseForceY = 75;

    public SpriteRenderer arena;
    public Rigidbody2D ball;

    void Start() {
        force = new Vector2(arena.bounds.size.x / traverseDuration / Time.fixedDeltaTime, baseForceY / Time.fixedDeltaTime);
        PlayBall(ball);
    }

    public static void PlayBall(Rigidbody2D ball)
    {
        ball.position = Vector2.zero;
        ball.velocity = Vector2.zero;
        ball.AddForce(force / 2, ForceMode2D.Force);
    }
}

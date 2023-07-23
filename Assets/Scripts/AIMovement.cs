using UnityEngine;

using Entities;

public class AIMovement : MonoBehaviour
{
    public Rigidbody2D paddle;
    public Rigidbody2D ball;

    // Set value in case we haven't gone through the PickAIDifficulty scene, which logically shouldn't happen
    public float movementForce = AIDifficulty.impossibleDifficulty.movementForce;
    public float alignmentDeviation = AIDifficulty.impossibleDifficulty.alignmentDeviation;

    private void Start()
    {
        if (PickAIDifficulty.selectedAIDifficulty != null)
        {
            movementForce = PickAIDifficulty.selectedAIDifficulty.movementForce;
            alignmentDeviation = PickAIDifficulty.selectedAIDifficulty.alignmentDeviation;
        }
    }

    void FixedUpdate()
    {
        Vector2 paddlePosition = paddle.position;
        Vector2 ballPosition = ball.position;
        float disposition = movementForce * Time.deltaTime;

        // If ball is within the allowed deviation of paddle's center in either direction, don't move
        float range = paddle.gameObject.GetComponent<SpriteRenderer>().bounds.size.y * alignmentDeviation;
        if (ballPosition.y <= paddlePosition.y + range && ballPosition.y >= paddlePosition.y - range)
        {
            return;
        }

        if (ballPosition.y > paddlePosition.y)
        {
            paddlePosition.y += disposition;
            paddle.MovePosition(paddlePosition);
        }
        else
        {
            paddlePosition.y -= disposition;
            paddle.MovePosition(paddlePosition);
        }
    }
}

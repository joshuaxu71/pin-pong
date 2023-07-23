using UnityEngine;

public class CollisionPaddle : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Paddle"))
        {
            // Reset paddle's velocity so that ball's velocity does not get transferred to the paddle.
            collision.rigidbody.velocity = Vector2.zero;

            float centerOfContactY = Vector2.zero.y;

            for (int i = 0; i < collision.contactCount; i++) 
            {
                centerOfContactY += collision.GetContact(i).point.y;
            }

            centerOfContactY /= collision.contactCount;

            float paddlePositionY = collision.collider.attachedRigidbody.position.y;
            float paddleSizeY = collision.gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

            /*
             * Get percentage of distance from the center of contact to the center of the paddle.
             * If the center of contact is equal to the center of the paddle, the percentage is 0.
             * If it's on the top edge, it's 100, and if it's on the bottom edge, it's -100.
             */
            float percentageDistance = (centerOfContactY - paddlePositionY) / (paddleSizeY / 2);

            /*
             * Calculate the amount of Y force we want to use. If the percentage distance is abs(100),
             * we want to send the ball flying at a 45 degrees angle. If the percentage distance is 0,
             * we want to send the ball flying at a 0 degrees angle.
             */
            float forceY = GameInitializer.force.x * percentageDistance;

            /*
             * Determine whether the x-axis force should be positive or negative. Alternatively,
             * we could also check which paddle it is (right of left) to determine the direction of force.
             */
            float forceX = collision.relativeVelocity.x >= 0 ? Mathf.Abs(GameInitializer.force.x) : -Mathf.Abs(GameInitializer.force.x);
            collision.otherCollider.attachedRigidbody.velocity = Vector2.zero;
            collision.otherCollider.attachedRigidbody.AddForce(new Vector2(forceX, forceY), ForceMode2D.Force);
        }
    }
}

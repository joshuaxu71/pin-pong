using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public ScoreManager scoreManager;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("Ball"))
        {
            scoreManager.Score(collider.gameObject.GetComponent<Rigidbody2D>(), this.name);
        }
    }
}

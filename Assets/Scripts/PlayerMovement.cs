using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D paddle;
    public int movement = 500;
    public float movementSpeed = 0.1f;

    void FixedUpdate()
    {
        if (paddle.name.Equals("PaddlePlayer2"))
        {
            if (Input.GetKey((KeyCode)Initializer.keybinds.player2Up))
            {
                Vector2 position = paddle.position;
                position.y += movement * movementSpeed * Time.deltaTime;
                paddle.MovePosition(position);
            }

            if (Input.GetKey((KeyCode)Initializer.keybinds.player2Down))
            {
                Vector2 position = paddle.position;
                position.y -= movement * movementSpeed * Time.deltaTime;
                paddle.MovePosition(position);
            }
        }
        else
        {
            if (Input.GetKey((KeyCode)Initializer.keybinds.player1Up))
            {
                Vector2 position = paddle.position;
                position.y += movement * movementSpeed * Time.deltaTime;
                paddle.MovePosition(position);
            }

            if (Input.GetKey((KeyCode)Initializer.keybinds.player1Down))
            {
                Vector2 position = paddle.position;
                position.y -= movement * movementSpeed * Time.deltaTime;
                paddle.MovePosition(position);
            }
        }
    }
}

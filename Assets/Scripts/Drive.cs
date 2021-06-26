using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{
    // By multiplying the vectors with the moveSpeed var, we can make it longer or shorter and the distance calculation will be added 
    // to the current point. Lower vector values means smaller distance and high vector values means high distance
    float moveSpeed = 0.02f;
    Vector2 upDirection = new Vector2(0f, 1f);
    Vector2 rightDirection = new Vector2(1f, 0f);
    

    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x += -rightDirection.x * moveSpeed;  // -> -rightDirection.x means - (-1) * rightDirection.x = -1
            position.y += -rightDirection.y * moveSpeed; 
            transform.position = position;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += rightDirection.x * moveSpeed;
            position.y += rightDirection.y * moveSpeed; 
            transform.position = position;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            position.x += upDirection.x * moveSpeed;
            position.y += upDirection.y * moveSpeed; 
            transform.position = position;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            position.x += -upDirection.x * moveSpeed;
            position.y += -upDirection.y * moveSpeed;
            transform.position = position;
        }

    }
}
using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{
    Vector2 direction = new Vector2(0.1f, 0.1f);

    void Update()
    {
        Vector3 position = transform.position;
        position.x += direction.x;
        position.y += direction.y;
        transform.position = position;
    }
}
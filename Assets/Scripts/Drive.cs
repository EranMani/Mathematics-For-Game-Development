using UnityEngine;
using System.Collections;

public class Drive : MonoBehaviour
{
    public float speed = 0.01f;
    public GameObject fuel;
    Vector3 direction;
    float stoppingDistance = 0.1f;

    private void Start()
    {
        // Declare the vector direction from the object to the destination
        direction = fuel.transform.position - transform.position;
    }

    void Update()
    {
        // Check for distance and update position with vector while in distance
        if (Vector3.Distance(transform.position, fuel.transform.position) > stoppingDistance)
        {
            transform.position += direction * speed;
        }

        // -- By calculating direction vector each frame, its magnitude will be reduced each frame and that will create
        // -- the slow in and slow out effect - when the object is close to the destination point it will move slower
        // -- and slower and he reached it
        // Vector3 direction = fuel.transform.position - transform.position;
        // transform.position += direction * speed;
    }
}
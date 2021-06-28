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
        Coords dirNormal = HolisticMath.GetNormal(new Coords(direction));
        direction = dirNormal.ToVector();
        // vector (0,1,0) is the up vector. Check by gizmos
        float angle = HolisticMath.Angle(new Coords(0, 1, 0), new Coords(direction)) * 180.0f/Mathf.PI;
    }

    void Update()
    {
        // Check for distance and update position with vector while in distance
        if (HolisticMath.Distance(new Coords(transform.position), new Coords(fuel.transform.position)) > stoppingDistance)
        {
            transform.position += direction * speed * Time.deltaTime;
        }

        /*if (Vector3.Distance(transform.position, fuel.transform.position) > stoppingDistance)
        {
            transform.position += direction * speed;
        }*/

        // -- By calculating direction vector each frame, its magnitude will be reduced each frame and that will create
        // -- the slow in and slow out effect - when the object is close to the destination point it will move slower
        // -- and slower and he reached it
        // Vector3 direction = fuel.transform.position - transform.position;
        // transform.position += direction * speed;
    }
}
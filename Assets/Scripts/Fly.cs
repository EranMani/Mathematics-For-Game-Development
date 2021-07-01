using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float speed = .5f;

    // Update is called once per frame
    void Update()
    {
        //MoveObject();
        float translateZ = Input.GetAxis("VerticalY") * speed;
        transform.Translate(0, 0, translateZ);
        RotateObject();


    }

    void MoveObject()
    {
        float translateX = Input.GetAxis("Horizontal") * speed;
        float translateY = Input.GetAxis("VerticalY") * speed;
        float translateZ = Input.GetAxis("Vertical") * speed;

        // transform.Translate(translateX, 0, 0);
        // transform.Translate(0, translateY, 0);
        // transform.Translate(0, 0, translateZ);
        transform.Translate(translateX, translateY, translateZ);

        // Doing the same thing as the translate method above
        /*
        transform.position = new Vector3(transform.position.x + translateX,
                                         transform.position.y + translateY,
                                         transform.position.z + translateZ);*/

        // At the moment, when rotating the object and using the translate methods, the object will follow
        // the world coordinates system instead of its local's. If the object local coord system is the same 
        // as the world coord system then it will move OK, but if it is rotated a bit, it will still follow
        // the world coord system and the movement will not work correctly
        // To solve that we need to do a mapping from the world coords into the object local coords
    }

    void RotateObject()
    {
        float rotationX = Input.GetAxis("Vertical") * rotationSpeed;
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed;
        float rotationZ = Input.GetAxis("HorizontalZ") * rotationSpeed;

        // transform.Rotate(rotationX, 0, 0);
        // transform.Rotate(0, rotationY, 0);
        // transform.Rotate(0, 0, rotationZ);

        transform.Rotate(rotationX, rotationY, rotationZ);
    }
}

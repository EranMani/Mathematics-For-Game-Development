using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLines : MonoBehaviour
{
    Line L1;
    Line L2;

    // Start is called before the first frame update
    void Start()
    {
        // Create 2 lines with start point and a vector, and draw them
        L1 = new Line(new Coords(-100, 0, 0), new Coords(200, 150, 0));
        L1.Draw(1, Color.green);
        L2 = new Line(new Coords(0, -100, 0), new Coords(0, 200, 0));
        L2.Draw(1, Color.red);

        // Found the intersection, which is the time along L1, where L2 intersects at it
        float intersectT = L1.IntersectAt(L2);
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        // Put the Time value into a lerp to find the intersection spot along the line
        sphere.transform.position = L1.Lerp(intersectT).ToVector();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

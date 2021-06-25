using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public int size = 20;

    Coords xStartPoint = new Coords(160, 0);
    Coords xEndPoint = new Coords(-160, 0);

    Coords yStartPoint = new Coords(0, 100);
    Coords yEndPoint = new Coords(0, -100);

    // Start is called before the first frame update
    void Start()
    {
        // X axis
        Coords.DrawLine(xStartPoint, xEndPoint, 1, Color.red);
        // Y axis
        Coords.DrawLine(yStartPoint, yEndPoint, 1, Color.green);

        float yMax = Camera.main.orthographicSize;
        float xMax = (Camera.main.orthographicSize * 16 / 10);

        for (float x = -xMax; x <= xMax; x+= size)
        {
            Coords pointA = new Coords(x, yMax * -1);
            Coords pointB = new Coords(x, yMax);
            Coords.DrawLine(pointA, pointB, 0.5f, Color.white);
        }

        for (float y = -yMax; y <= yMax; y += size)
        {
            Coords pointA = new Coords(xMax * -1, y);
            Coords pointB = new Coords(xMax, y);
            Coords.DrawLine(pointA, pointB, 0.5f, Color.white);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

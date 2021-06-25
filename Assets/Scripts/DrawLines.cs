using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    // Coords point = new Coords(10, 20);

    Coords xStartPoint = new Coords(160, 0);
    Coords xEndPoint = new Coords(-160, 0);

    Coords yStartPoint = new Coords(0, 100);
    Coords yEndPoint = new Coords(0, -100);

    Coords[] leo = {new Coords(0,20), new Coords(20, 30), new Coords(80, 30), new Coords(30, 50), new Coords(80, 50),
                    new Coords(70,60), new Coords(70,80), new Coords(80,90), new Coords(95,80)};


    RaycastHit hit;
    Ray ray;
    Coords firstCoord;
    Coords secondCoord;

    // Start is called before the first frame update
    void Start()
    {
        // X axis
        Coords.DrawLine(xStartPoint, xEndPoint, 1, Color.red);
        // Y axis
        Coords.DrawLine(yStartPoint, yEndPoint, 1, Color.green);

        // DrawPointsAndLinesManual();
    }

    // Update is called once per frame
    void Update()
    {
        // DrawLineByMouseClicks();
    }

    private void DrawLineByMouseClicks()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                firstCoord = new Coords(hit.point.x, hit.point.y);
                if (secondCoord != null)
                {
                    print("^^^^^^^^^^^^^^^^^^");
                    Coords.DrawPoint(firstCoord, 1.0f, Color.white);
                    Coords.DrawLine(firstCoord, secondCoord, 0.5f, Color.yellow);
                    secondCoord = firstCoord;
                    return;
                }
                if (secondCoord == null)
                {
                    print("#############");
                    secondCoord = firstCoord;
                    Coords.DrawLine(firstCoord, secondCoord, 0.5f, Color.yellow);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            secondCoord = null;
        }
    }

    void DrawPointsAndLinesManual()
    {
        foreach (Coords c in leo)
        {
            Coords.DrawPoint(c, 2, Color.yellow);
        }

        Coords.DrawLine(leo[0], leo[1], .4f, Color.white);
        Coords.DrawLine(leo[1], leo[2], .4f, Color.white);
        Coords.DrawLine(leo[0], leo[3], .4f, Color.white);
        Coords.DrawLine(leo[3], leo[5], .4f, Color.white);
        Coords.DrawLine(leo[2], leo[4], .4f, Color.white);
        Coords.DrawLine(leo[4], leo[5], .4f, Color.white);
        Coords.DrawLine(leo[5], leo[6], .4f, Color.white);
        Coords.DrawLine(leo[6], leo[7], .4f, Color.white);
        Coords.DrawLine(leo[7], leo[8], .4f, Color.white);
    }



    //Debug.Log(point.ToString());

    // Origin
    // Coords.DrawPoint(new Coords(0,0), 2, Color.red);
    //Coords.DrawPoint(point, 2, Color.green);
}

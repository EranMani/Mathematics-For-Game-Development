﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// L(t) = A + v*t
public class Line
{
    Coords A;
    Coords B;
    Coords v;

    public enum LINETYPE {LINE, SEGMENT, RAY };
    LINETYPE type;


    public Line(Coords _A, Coords _B, LINETYPE _type)
    {
        A = _A;
        B = _B;
        type = _type;
        // Find the vector between two points
        v = new Coords(B.x - A.x, B.y - A.y, B.z - A.z);
    }

    public Line(Coords _A, Coords _v)
    {
        A = _A;
        B = _A + _v;
        v = _v;
    }

    public Coords Lerp(float t)
    {
        if (type == LINETYPE.SEGMENT)
        {
            t = Mathf.Clamp(t, 0, 1);
        }
        else if (type == LINETYPE.RAY && t < 0)
        {
            t = 0;
        }

        // The base should be the coords of point A, adding the vector coords to it
        // Add the t (time) value to get the new point along the line
        float xt = A.x + v.x * t;
        float yt = A.y + v.y * t;
        float zt = A.z + v.z * t;

        return new Coords(xt, yt, zt);
    }
}

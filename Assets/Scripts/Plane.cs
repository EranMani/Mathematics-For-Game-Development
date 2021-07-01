using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane
{
    Coords A;
    Coords B;
    Coords C;
    Coords v;
    Coords u;

    public Plane(Coords _A, Coords _B, Coords _C)
    {
        A = _A;
        B = _B;
        C = _C;
        v = B - A;
        u = C - A;
    }

    public Plane(Coords _A, Vector3 V, Vector3 U)
    {
        A = _A;
        v = new Coords(V.x, V.y, V.z);
        u = new Coords(U.x, U.y, U.z);
    }

    public Coords Lerp(float t, float s)
    {
        float xst = A.x + v.x * t + u.x * s;
        float yst = A.y + v.y * t + u.y * s;
        float zst = A.z + v.z * t + u.z * s;

        return new Coords(xst, yst, zst);
    }
}

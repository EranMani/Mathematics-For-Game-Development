using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolisticMath
{
    static public Coords GetNormal(Coords vector)
    {
        float length = Distance(new Coords(0,0,0), vector);
        vector.x /= length;
        vector.y /= length;
        vector.z /= length;

        return vector;
    }

    static public float Distance(Coords point1, Coords point2)
    {
        float diffSquared = Square(point1.x - point2.x) +
                            Square(point1.y - point2.y) +
                            Square(point1.z - point2.z);

        float squareRoot = Mathf.Sqrt(diffSquared);
        return squareRoot;
    }

    static public float Square(float value)
    {
        return value * value;
    }


    static public float Dot(Coords vector1, Coords vector2)
    {
        return vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
    }

    static public float Angle(Coords vector1, Coords vector2)
    {
        float firstVectorLength = Distance(new Coords(0, 0, 0), vector1);
        float secondVectorLength = Distance(new Coords(0, 0, 0), vector2);
        float dotDivide = Dot(vector1, vector2) / (firstVectorLength * secondVectorLength);
        return Mathf.Acos(dotDivide); // current result is in radians. For degrees * 180/Mathf.PI;
    }

    static public Coords Rotate(Coords vector, float angle, bool turnClockwise) // In radians
    {
        if (turnClockwise)
        {
            angle = 2 * Mathf.PI - angle;

        }
        float xVal = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);
        float yVal = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);
        return new Coords(xVal, yVal, 0);
    }

    static public Coords Cross(Coords vector1, Coords vector2)
    {
        // Big note: the first input vector should be the direction the object is currently facing,
        // and the second input vector should be the direction that the object wants to be facing to

        // Note: the X value of the cross vector depends on the Y and Z axis
        float xCross = vector1.y * vector2.z - vector1.z * vector2.y;
        float yCross = vector1.z * vector2.x - vector1.x * vector2.z;
        float zCross = vector1.x * vector2.y - vector1.y * vector2.x;
        return new Coords(xCross, yCross, zCross);
    }

    static public Coords LookAt2D(Coords destination, Coords forwardVector, Coords position)
    {
        // Declare the vector direction from the object to the destination
        Coords direction = new Coords(destination.x - position.x, destination.y - position.y, position.z);
  
        float angle = Angle(forwardVector, direction); // Stay in radians

        bool turnClockwise = false;
        if (HolisticMath.Cross(forwardVector, direction).z < 0)
        {
            turnClockwise = true;
        }

        Coords newDir = Rotate(forwardVector, angle, turnClockwise);
        return newDir;
    }
}

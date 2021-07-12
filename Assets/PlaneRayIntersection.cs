using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRayIntersection : MonoBehaviour
{
    public GameObject sphere;
    public GameObject quad;
    //public Transform corner1;
    //public Transform corner2;
    //public Transform corner3;
    public GameObject[] fences;
    Vector3[] fenceNormals;

    Plane mPlane;

    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vertices = quad.GetComponent<MeshFilter>().mesh.vertices;
        // TransformPoint = transforms position from local to world space
        mPlane = new Plane(quad.transform.TransformPoint(vertices[0]) + new Vector3(0,0.3f,0),
                           quad.transform.TransformPoint(vertices[1] + new Vector3(0, 0.3f, 0)),
                           quad.transform.TransformPoint(vertices[2]) + new Vector3(0, 0.3f, 0));
        fenceNormals = new Vector3[fences.Length];
        for (int i = 0; i < fences.Length; i++)
        {
            Vector3 normal = fences[i].GetComponent<MeshFilter>().mesh.normals[0];
            fenceNormals[i] = fences[i].transform.TransformVector(normal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Take the coordinate clicked on the screen and make it a world coordinate. Project it into the world
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float t = 0.0f;

            if (mPlane.Raycast(ray, out t))
            {
                // Get the point where the ray intersect with the plane by using the output 't' value (consider it 't' time)
                // We are working out the time along the ray from the screen click point to when it actually hits the plane
                Vector3 hitPoint = ray.GetPoint(t);
                // float hitPointX = hitPoint.x;
                // float hitPointZ = hitPoint.z;

                bool inside = true;
                for (int i = 0; i < fences.Length; i++)
                {
                    Vector3 hitPointToFence = fences[i].transform.position - hitPoint;
                    inside = inside && Vector3.Dot(hitPointToFence, fenceNormals[i]) <= 0;
                }

                if(inside)
                    sphere.transform.position = hitPoint;

                /*if (hitPointX >= -5.12 && hitPointX <= 5.12 && hitPointZ >= -5.12 && hitPointZ <= 5.12)
                {
                    sphere.transform.position = hitPoint;
                }*/

            }
        }
    }
}

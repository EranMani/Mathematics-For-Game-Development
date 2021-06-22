using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRay : MonoBehaviour
{
    void Update()
    {
        // Since layers are stored as binary, start from 1 and shift to another layer
        // Bit shift to left to reach the desired layer
        //int layerMask = 1 << 9;

        // Combine two bit sequences for further filtering
        // In this case, mask only the cube and sphere layers
        int layerMask = (1 << 8 | 1 << 9);

        // Search for all layers instead of the current indexed layer by negate the binary values
        // layerMask = ~layerMask;
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),
            out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("HIT");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            Debug.Log("MISSED");
        }
    }
}

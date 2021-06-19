using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SetBit : MonoBehaviour
{
    //int bitSequence = 16;
    //int bitSequence = 8 + 1 + 2;
    int bitSequence = 1 + 2 + 32;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Convert.ToString(bitSequence, 2));

        // If sequence == 8 then the binary sequence will be 0 0 0 1 0 0 0 0
        // If sequence == 1 then the binary sequence will be 1 0 0 0 0 0 0 0
        // And so on..
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

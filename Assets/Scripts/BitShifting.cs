using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BitShifting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Test()
    {
        // Pack A B C from left to right into PACKED binary of 32 bits
        string A = "110111";
        string B = "10001";
        string C = "1101";
        int aBits = Convert.ToInt32(A, 2);
        int bBits = Convert.ToInt32(B, 2);
        int cBits = Convert.ToInt32(C, 2);

        int packed = 0;

        packed |= (aBits << 26);
        packed |= (bBits << 21);
        packed |= (cBits << 17);

        Debug.Log(Convert.ToString(packed, 2).PadLeft(32, '0'));
    }
}

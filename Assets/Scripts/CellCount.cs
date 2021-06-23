using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CellCount : MonoBehaviour
{
    private void Start()
    {
        print(GetCellCount(30));
    }

    int GetCellCount(long bitboard)
    {
        int count = 0;
        long bb = bitboard;

        while (bb != 0)
        {

            Debug.Log(bb + ": " + Convert.ToString(bb, 2).PadLeft(8, '0'));

            Debug.Log((bb - 1) + ": " + Convert.ToString((bb - 1), 2).PadLeft(8, '0'));

            Debug.Log((bb & (bb - 1)) + ": " + Convert.ToString((bb & (bb - 1)), 2).PadLeft(8, '0'));

            Debug.Log("---");


            bb &= bb - 1;

            count++;

        }
        return count;


    }
}

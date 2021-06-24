using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CreateBoard : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public GameObject housePrefab;
    public GameObject treePrefab;
    public Text score;
    GameObject[] tiles;
    long dirtBB;
    long desertBB;
    long treeBB;
    long playerBB;

    // Start is called before the first frame update
    void Start()
    {
        tiles = new GameObject[64];

        for (int r = 0; r < 8; r++)
        {
            for (int c = 0; c < 8; c++)
            {
                int randomTile = UnityEngine.Random.Range(0, tilePrefabs.Length);
                Vector3 pos = new Vector3(c, 0, r);
                GameObject tile = Instantiate(tilePrefabs[randomTile], pos, Quaternion.identity);
                tile.name = tile.tag + "_" + r + "_" + c;
                tiles[r * 8 + c] = tile;
                if (tile.tag == "Dirt")
                {
                    dirtBB = SetCellState(dirtBB, r, c);
                    // PrintBB("Dirt", dirtBB);
                }
                else if(tile.tag == "Desert")
                {
                    desertBB = SetCellState(desertBB, r, c);
                }
            }
        }

        Debug.Log("Dirt cells = " + CellCount(dirtBB));
        Debug.Log("Desert cells = " + CellCount(desertBB));
        InvokeRepeating("PlantTree", 1, 1);
    }

    void PlantTree()
    {
        int rr = UnityEngine.Random.Range(0, 8);
        int rc = UnityEngine.Random.Range(0, 8);
        if (GetCellState(dirtBB &~ playerBB, rr, rc))
        {
            GameObject tree = Instantiate(treePrefab);
            tree.transform.parent = tiles[rr * 8 + rc].transform;
            tree.transform.localPosition = Vector3.zero;
            treeBB = SetCellState(treeBB, rr, rc);
        }
    }

    void PrintBB(string name, long bitBoard)
    {
        Debug.Log(name + ": " + Convert.ToString(bitBoard, 2).PadLeft(64, '0'));
    }

    long SetCellState(long bitBoard, int row, int col)
    {
        long newBit = 1L << (row * 8 + col);
        return (bitBoard |= newBit);
    }

    bool GetCellState(long bitBoard, int row, int col)
    {
        long mask = 1L << (row * 8 + col);
        return ((bitBoard &= mask) != 0);
    }

    int CellCount(long bitBoard)
    {
        int count = 0;
        while (bitBoard != 0)
        {
            bitBoard &= bitBoard - 1;
            count++; 
        }

        return count;
    }

    void CalculateScore()
    {
        score.text = "Score: " + (CellCount(dirtBB & playerBB) * 10 + CellCount(desertBB & playerBB) * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                int r = (int)hit.transform.position.z;
                int c = (int)hit.transform.position.x;
                //if (GetCellState(dirtBB &~ treeBB, r, c))
                if(GetCellState((dirtBB & ~treeBB) | desertBB, r, c))
                {
                    GameObject house = Instantiate(housePrefab);
                    house.transform.parent = hit.transform;
                    house.transform.localPosition = Vector3.zero;
                    playerBB = SetCellState(playerBB, r, c);
                    CalculateScore();
                }
                
            }
        }
    }
}

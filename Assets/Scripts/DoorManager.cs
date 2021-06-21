using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorManager : MonoBehaviour
{
    public enum DoorType { MAGIC_DOOR, INVISIBLE_DOOR, FLY_DOOR, INTELLIGENCE_DOOR, CHARISMA_DOOR, FINAL_DOOR};

    // The current state of enemy
    public DoorType currentDoor = DoorType.MAGIC_DOOR;
    int doorAttr = 0;

    private void Start()
    {
        switch (currentDoor)
        {
            case DoorType.MAGIC_DOOR:
                doorAttr = AttributeManager.MAGIC_KEY;
                break;
            case DoorType.INVISIBLE_DOOR:
                doorAttr = AttributeManager.INVISIBLE_KEY;
                break;
            case DoorType.FLY_DOOR:
                doorAttr = AttributeManager.FLY_KEY;
                break;
            case DoorType.INTELLIGENCE_DOOR:
                doorAttr = AttributeManager.INTELLIGENCE_KEY;
                break;
            case DoorType.CHARISMA_DOOR:
                doorAttr = AttributeManager.CHARISMA_KEY;
                break;
            case DoorType.FINAL_DOOR:
                doorAttr = AttributeManager.INTELLIGENCE_KEY | AttributeManager.CHARISMA_KEY;
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        int keys = collision.gameObject.GetComponent<AttributeManager>().keys;
        print(Convert.ToString(keys, 2).PadLeft(8, '0'));
        print(Convert.ToString(doorAttr, 2).PadLeft(8, '0'));
        print(Convert.ToString(keys & doorAttr, 2).PadLeft(8, '0'));

        // Check if the keys binary is the exact binary as the bit mask doorAttr
        if ((keys & doorAttr) == doorAttr)
        {
            gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<AttributeManager>().keys &= ~doorAttr;
        gameObject.GetComponent<BoxCollider>().isTrigger = false;
    }

}

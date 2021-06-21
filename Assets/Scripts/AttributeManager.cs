using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AttributeManager : MonoBehaviour
{
    static public int MAGIC_KEY = 16;
    static public int INTELLIGENCE_KEY = 8;
    static public int CHARISMA_KEY = 4;
    static public int FLY_KEY = 2;
    static public int INVISIBLE_KEY = 1;

    public Text keysDisplay;
    public int keys = 0;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "MAGIC":
                keys |= MAGIC_KEY;
                Destroy(other.gameObject);
                break;
            case "INTELLIGENCE":
                keys |= INTELLIGENCE_KEY;
                Destroy(other.gameObject);
                break;
            case "CHARISMA":
                keys |= CHARISMA_KEY;
                Destroy(other.gameObject);
                break;
            case "FLY":
                keys |= FLY_KEY;
                Destroy(other.gameObject);
                break;
            case "INVISIBLE":
                keys |= INVISIBLE_KEY;
                Destroy(other.gameObject);
                break;
            case "GOLD":
                keys |= (MAGIC_KEY | INTELLIGENCE_KEY | CHARISMA_KEY | FLY_KEY | INVISIBLE_KEY);
                Destroy(other.gameObject);
                break;
        }      
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        keysDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        keysDisplay.text = Convert.ToString(keys, 2).PadLeft(8, '0');
    }

 


  

    /*
       else if (other.gameObject.tag == "ANTIMAGIC")
       {
           attributes &= ~MAGIC;
       }
       else if (other.gameObject.tag == "MULTADD")
       {
           attributes |= (INTELLIGENCE | MAGIC | CHARISMA);
       }
       else if (other.gameObject.tag == "MULTREMOVE")
       {
           attributes &= ~(INTELLIGENCE | MAGIC);
       }
       else if (other.gameObject.tag == "RESET")
       {
           attributes = 0;
       }
       */

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLCTOR : MonoBehaviour
{
    public GameObject Outline; 
   public void toggleselection()
    

    {
        print("Toggle button");
        //If enabled, disable
        if(Outline.activeSelf)
        {
            Outline.SetActive(false);
        }

        else
        {
            GameObject[] SLC = GameObject.FindGameObjectsWithTag("Selector");
            foreach(GameObject selector in SLC)
            {
                selector.SetActive(false);
            }

            Outline.SetActive(true);
        }
    }  
}
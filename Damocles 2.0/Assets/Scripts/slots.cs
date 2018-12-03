using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slots : MonoBehaviour 
{
    public void DropItem()
    {
        print(transform.gameObject.name);
        foreach (Transform child in transform)
        {
            print(child);
            if (child.gameObject.tag == "pickup")
            {

            Destroy(child.gameObject);
             }
        }
    }
}
	
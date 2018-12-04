using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slots : MonoBehaviour 
{


    private Inventory inventory;
    public int clicker;

    private void Start()
   {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
   {
        if(transform.childCount <= 0)
       {
            inventory.isFull[clicker] = false;
       }
    }



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
	
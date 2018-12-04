using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{


    private Inventory inventory;
    public GameObject itemButton;
    public bool Intrigger;
    public GameObject the_canvas;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
         
    }

    private void Update()
    {
        //print("YOUR IN KID!");
        if (Input.GetKeyDown(KeyCode.E) && Intrigger)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    // ITEM CAN BE ADDED TO INVENTORY
                    inventory.isFull[i] = true;
                    GameObject item = Instantiate(itemButton, inventory.slots[i].transform, false);
                    //item.transform.SetParent(the_canvas.gameObject.transform);
                    Destroy(gameObject);

                    break;
                }
            }
        }
    }

    
    
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            print(Intrigger);
            Intrigger = true;
        }
    }
        
 void OnTriggerExit2D(Collider2D other)
{

    if (other.CompareTag("Player"))
    {
            print(Intrigger);
            Intrigger = false;
    }
}

}





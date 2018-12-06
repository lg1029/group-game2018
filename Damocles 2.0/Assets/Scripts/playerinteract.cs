using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinteract : MonoBehaviour
{

    public GameObject currentInterObj = null;




    void Update()
    {
        if (Input.GetButtonDown("interact") && currentInterObj)
        {
            //do something with object
            currentInterObj.SendMessage("DoInteraction");
        }
    }




    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("interactable")){
            //Debug.Log(other.name);
            currentInterObj = other.gameObject;


        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interactable"))
            if (other.gameObject == currentInterObj)
            {

                currentInterObj = null;
            }
    }
}


        
    

   

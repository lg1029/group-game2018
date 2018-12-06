using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyunlock : MonoBehaviour {

    public GameObject doorky;
    public string itemname;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Need to find out how to use if key is selected
        if (collision.gameObject.CompareTag("Player")) 
        {
           GameObject[] SLC = GameObject.FindGameObjectsWithTag("Selector");
            foreach (GameObject selector in SLC)
            {
                if(selector.activeSelf )
                {
                    print(selector.gameObject.name);
                    print(selector.transform.parent.gameObject.name);
                    foreach (Transform child in selector.transform.parent)
                    {
                        print(child.gameObject.name);
                        if(child.gameObject.name == itemname)
                        {
                            doorky.SetActive(false);
                            Destroy(child.gameObject);
                        }
                    }

                       
                }

            }


        }

    }

    //Check if slot key is in is selected

    //Check tag if the tag is player

    //set door to inactive
}

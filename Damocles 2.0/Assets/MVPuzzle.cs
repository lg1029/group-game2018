using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVPuzzle : MonoBehaviour
{
    public GameObject key;
    public GameObject door2;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (transform.gameObject.name == "Green Circle")
        {
            if (coll.CompareTag("Green"))
            {
                key.SetActive(true);
            }
        }


        if (transform.gameObject.name == "Blue Circle (1)")
        {
            print("Blue Circle(1)");
            if (coll.CompareTag("Green"))
            {
                door2.SetActive(false);
            }

        }

        if (transform.gameObject.name == "Blue Circle (2)")
        {
            print("Blue Circle(2)");
            if (coll.CompareTag("Green"))
            {
                door2.SetActive(false);
            }

        }

        if (transform.gameObject.name == "Red Circle (1)")
        {

            if (coll.CompareTag("Green"))
            {
                door2.SetActive(false);
            }

        }



            // else if(coll.CompareTag("Green"))
            // {
            //     Mvscore = Mvscore + 2;
            //    print(Mvscore);
            //}


            //  else if(coll.CompareTag("White"))
            // {
            //    Mvscore = Mvscore + 3;
            //   print(Mvscore);

            //}



            //else if(coll.CompareTag("Blue"))
            // {
            //    Mvscore = Mvscore + 4;
            //   print(Mvscore);
            // }
            // }
        }
}   
   



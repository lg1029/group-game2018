using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVPuzzle : MonoBehaviour
{
    private int Mvscore = 0;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Point"))
        {
            Mvscore = Mvscore + 1;
            print(Mvscore);
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
   



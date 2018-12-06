using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activateportal : MonoBehaviour {

    public GameObject portal;
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Teleport");
        portal.SetActive(true);
    }
}

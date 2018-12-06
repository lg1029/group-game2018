using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChsngeInter : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Teleport");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

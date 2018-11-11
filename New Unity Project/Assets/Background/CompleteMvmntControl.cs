using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class CompleteMvmntControl : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb2d;
    private Vector2 moveVelocity;


	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

	}
     void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }
         
   

    // Update is called once per frame
    void FixedUpdate () {
        rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime); 

      
	}
}

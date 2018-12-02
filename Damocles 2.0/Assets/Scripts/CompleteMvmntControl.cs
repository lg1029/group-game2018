using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class CompleteMvmntControl : MonoBehaviour {

    public float speed;
    public GameObject followcam;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    private Rigidbody2D rb2d;
    private Vector2 moveVelocity;


	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

	}
    void Update()
    {
        //Variables
        float xpos = transform.position.x;
        float ypos = transform.position.y;

      



        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        //Camera following Portion X values
        if (transform.position.x > maxX||transform.position.x < minX)
        {

            xpos = followcam.transform.position.x;
        }
       

        //Camera following Portion Y values
        if (transform.position.y > maxY|| transform.position.y < minY)
        {
            ypos = followcam.transform.position.y;

        }

        followcam.transform.position = new Vector3(xpos, ypos, -10f);
    }

         
   

    // Update is called once per frame
    void FixedUpdate () {
        rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime); 

      
	}
}

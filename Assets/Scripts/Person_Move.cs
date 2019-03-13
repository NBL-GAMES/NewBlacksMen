using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person_Move : MonoBehaviour {


    private Rigidbody2D rb;
    public float speedMove;
	// Use this for initialization
	void Start () {
        this.rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speedMove);
        /*
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("WALK TO RIGHT");
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            print("WALK TO LEFT");
        }*/
	}
}

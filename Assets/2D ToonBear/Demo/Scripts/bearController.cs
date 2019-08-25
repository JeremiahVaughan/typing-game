using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Pathfinding;
//This Script is intended for demoing and testing animations only.


public class bearController : MonoBehaviour {

    //private float HSpeed = 3f;
    ////private float maxVertHSpeed = 20f;
    //private bool facingRight = true;
    //private float moveXInput;
    //   private float moveYInput;

    //Used for flipping Character Direction
    //public static Vector3 theScale;
    public AIPath aiPath;

	private Animator anim;
    private Vector3 lastFrameTransformPosition;

    // Use this for initialization
    void Awake ()
	{
//		startTime = Time.time;
		anim = GetComponent<Animator> ();
        lastFrameTransformPosition = transform.parent.transform.position;
    }

	void FixedUpdate ()
	{

		//grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		//anim.SetBool ("ground", grounded);


	}

	void Update()
	{
        
        //float magnitude = GetComponent<Rigidbody2D>().velocity.sqrMagnitude;
        if (transformIsMoving())
        {
            anim.SetFloat("HSpeed", 1);
            anim.SetFloat("vSpeed", 1);
        } else
        {
            anim.SetFloat("HSpeed", 0);
            anim.SetFloat("vSpeed", 0);
        }

        
        
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        } else if(aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        //        moveXInput = Input.GetAxis("Horizontal");
        //        moveYInput = Input.GetAxis("Vertical");

        //        //if ((grounded) && Input.GetButtonDown("Jump"))
        //        //{
        //        //    anim.SetBool("ground", false);

        //        //    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.y, jumpForce);
        //        //}


        //        anim.SetFloat("HSpeed", Mathf.Abs(moveXInput));
        //        anim.SetFloat("vSpeed", Mathf.Abs(moveYInput));
        //        //anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);


        //        GetComponent<Rigidbody2D>().velocity = new Vector2((moveYInput * HSpeed), GetComponent<Rigidbody2D>().velocity.y);
        //        GetComponent<Rigidbody2D>().velocity = new Vector2((moveXInput * HSpeed), GetComponent<Rigidbody2D>().velocity.x);

        //        if (Input.GetButtonDown("Fire1")) { anim.SetTrigger("Punch"); }

        //        if (Input.GetButton("Fire2"))
        //        {
        //            anim.SetBool("Sprint", true);
        //            HSpeed = 14f;
        //}
        //        else
        //        {
        //            anim.SetBool("Sprint", false);
        //            HSpeed = 10f;
        //        }

        //        //Flipping direction character is facing based on players Input
        //        if (moveXInput > 0 && !facingRight)
        //            Flip();
        //        else if (moveXInput < 0 && facingRight)
        //            Flip();
        //    }
        //    ////Flipping direction of character
        //    void Flip()
        //	{
        //		facingRight = !facingRight;
        //		theScale = transform.localScale;
        //		theScale.x *= -1;
        //		transform.localScale = theScale;
    }
    private bool transformIsMoving()
    {
        bool result = true;
        Vector3 currentFrameTransformPosition = transform.parent.transform.position;
        if (currentFrameTransformPosition == lastFrameTransformPosition)
        {
            result = false;
        }
        lastFrameTransformPosition = currentFrameTransformPosition;

        return result;
    }

}

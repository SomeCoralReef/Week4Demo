using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayformerCharacter : MonoBehaviour
{
    //PURPOSE: Character controller with basic movement and jumping
    // USAGE: Put this on an object with a 2D collider and 2D rigidbody

    Rigidbody2D myRigidbody;
    float inputHorizontal; 
    bool isJumping;
    public bool coffeeDoubleJump;
    public float numberOfJumps = 1; 
    public float HorizontalMovementSpeed = 10f;
    public float jumpingPower = 8;
    public bool isGrounded; // set by platformerGroundedTrigger
    
    void Start() 
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        coffeeDoubleJump = false;
    }

    // happens every RENDERING frame, this is wwhere input happens
    void Update()
    {
        // get left and right arrow keys to move left and right
        // press SPACE to jump
        inputHorizontal = Input.GetAxis("Horizontal");
        Debug.Log(numberOfJumps);

        // we will jump but only if we are grounded
        if(Input.GetButtonDown("Jump") && numberOfJumps >= 1){
            isJumping = true;
            numberOfJumps -=1;
        }
    }

    //happens every PHYSICS frame, at a fixed timestep
    void FixedUpdate() {
        // we ened to put the Y value back into itself to preserve vertucal velocity like falling 
        myRigidbody.velocity = new Vector2 ( inputHorizontal * HorizontalMovementSpeed, myRigidbody.velocity.y);

        // if we need to do the jump, then add Y velocity

        if( isJumping ){
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x , jumpingPower);
            isJumping = false;
        }  


    }
}

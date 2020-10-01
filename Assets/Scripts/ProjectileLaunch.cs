using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLaunch : MonoBehaviour
{
    
    public float rotationSpeed = 90f;
    public float shootForce = 1000f;
    //PURPOSE : Let me use the mouse to aim the cannon and left click to shoot projectile
    //Usage : Put this script on a pivot point parent at the top of a long sprite child pointing downwards
    
    public Rigidbody2D myProjectilePrefab;

    
    void Update()
    {
        //move the mouse to aim the cannon
        // -1f if moving left, 0f if not moving horizontally, 1f if moving mouse right 
        float horizontalMouseSpeed = Input.GetAxis("Mouse X");
        //transform.Rotate(0,0, horizontalMouseSpeed); //this is FRAMERATE DEPENDENT
        transform.Rotate(0,0, horizontalMouseSpeed * Time.deltaTime * rotationSpeed); // FRAMERATE INDEPENDANT because we use Time.deltaTime

        // left click to shoot a projectile out of the cannon
        // how to instantiate clone an object
        //1. make a prefab
        //2. declaare and assign a public var to referaence that prefab
        //3. use the Instantiate function

        if(Input.GetMouseButtonDown(0)){ //0 = left click, 1 = right-click, 2= middle-click
            Rigidbody2D myNewClone = Instantiate(myProjectilePrefab, transform.position - transform.up * 2, Quaternion.identity );
            //add force in the direction of this cannons current "down" vector
            myNewClone.AddForce( -transform.up * shootForce );
        }
    }
}

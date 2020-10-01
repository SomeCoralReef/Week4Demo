using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformerGroundedTrigger : MonoBehaviour
{
    public PlayformerCharacter myCharacter; // public: assign in Inspector/

    //all frames
    void OnTriggerStay2D (Collider2D activator){
        myCharacter.isGrounded = true;
        if(myCharacter.coffeeDoubleJump == false){
        myCharacter.numberOfJumps = 1;
        } else {
            myCharacter.numberOfJumps = 2;
        }

    }

    //first frame an obejct leaves the trigger
    void OnTriggerExit2D(Collider2D activator){
        myCharacter.isGrounded = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpTrigger : MonoBehaviour
{
    public PlayformerCharacter myCharacter;

    void OnTriggerEnter2D(Collider2D activator){
        Destroy(gameObject);
        myCharacter.coffeeDoubleJump = true;
    }
}

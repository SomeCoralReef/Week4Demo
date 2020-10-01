using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
  public GameObject myCharacter;
  public float cameraSpeed;
    
    void Update () {
        float interpolation = cameraSpeed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, myCharacter.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, myCharacter.transform.position.x, interpolation);

        this.transform.position = position;
    }
}

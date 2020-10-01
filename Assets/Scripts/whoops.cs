using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class whoops : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D activator){
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
}

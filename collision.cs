using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class collision : MonoBehaviour
{
  
  void OnCollisionEnter(Collision other) 
  {
     switch (other.gameObject.tag)
     {
       case "friendly":
        Debug.Log("Frend");
       break;
       case "Finish":
        Debug.Log("Finish");
       break;
       case "Fuel":
        Debug.Log("FUEL");
       break;
       default:
        Debug.Log("You recreated the challenger");
       respawn();
       break;


     }
   }
   void respawn()
   {
     int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
     SceneManager.LoadScene(currentSceneIndex);
   }
}


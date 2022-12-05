using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour 

{
  public GameObject player;

    void OnTriggerEnter(Collider collison)
    {
       if (collison.gameObject.tag == "Player" )
      {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0); 
      }
    }
}

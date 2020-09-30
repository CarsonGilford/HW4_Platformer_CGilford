using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyDoor : MonoBehaviour
{
    //public BoxCollider2D trapdoor;
     void OnTriggerEnter2D(Collider2D activator){
   Debug.Log(activator.name +"Something eneter this trigger");
   //Release balls
   Destroy(gameObject);
  }
}

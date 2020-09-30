using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformerGrooundedTrigger : MonoBehaviour
{
    public PlatformerCharecter myCharacter; //public: assign in Ispector
    void OnTriggerStay2D(Collider2D activator){
        myCharacter.isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D activator){
        myCharacter.isGrounded = false;
   }

   
}

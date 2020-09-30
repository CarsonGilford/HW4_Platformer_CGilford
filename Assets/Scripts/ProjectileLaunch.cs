using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Purpose: let me use mouse to aim cannon and left click to shoot projectile ball
//Usage: Put script on Pivot pint parent with long sprite child point down
public class ProjectileLaunch : MonoBehaviour
{
    public float rotationSpeed = 90f; //PUBLIC MEANS EXPOSE FDOT UNITY INSPECTOR
    public float shootForce = 1000f;

    public Rigidbody2D myProjectilePreFab;

    void Update()
    {
        // move mouse to Aim cannon
        //-1f: Moving mouse left,0f: mouse not moving horizontal,+1.0f: Moving Mouse Right
        //float horizontalMouseSpeed = Input.GetAxis("Mouse X");
        //transform.Rotate(0, 0, horizontalMouseSpeed);  //this is frame depedent
        //transform.Rotate(0, 0, horizontalMouseSpeed * Time.deltaTime* rotationSpeed);//Framerate Idependent because we use time.deltaTime
        

        //How to instatiate ("clone") an Object
        //1. Make a Prfab Object
        //2. declare a public var to refrence he prefab
        //3. Ise the Instantiate funtion

        // left-clock to shoot projectile out of cannon
        if(Input.GetKeyDown(KeyCode.Space)){ //0 means left click,1 -right click, 2 = middle click
            Rigidbody2D myNewClone = Instantiate(myProjectilePreFab, transform.position - transform.up * 2,Quaternion.identity); 
            // add force int he direction of cannon current down vector
            myNewClone.AddForce(-transform.up * shootForce);
        }

    }
}

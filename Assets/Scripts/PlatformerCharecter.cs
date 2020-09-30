using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: Charecter controller. Basic movemnt and jumping
// on obj with 2D colidder and rigid body
public class PlatformerCharecter : MonoBehaviour
{
    Rigidbody2D myRigidBody;// stores refrence to rigidbody

    float inputHorizontal;
    bool isJumping;

    public bool isGrounded; //ste by PlatformerGrounded Trigger

    public float moveSpeed = 15f;
    public float jumpPower = 25f;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();//cache the refrence
    }

    //happens every Rendering frame, this is also where input
    void Update()
    {
        //Get Left and right arrow keys to move left and right
        inputHorizontal = Input.GetAxis("Horizontal");

        //press Sapce to Jump
        //only want to jump if grounded
        if (Input.GetButtonDown("Jump") && isGrounded == true){
            isJumping = true;
        }
    }

    void FixedUpdate(){
        // we need to put y value back into itelf to preserve vertical velocity.
        myRigidBody.velocity = new Vector2(inputHorizontal * moveSpeed, myRigidBody.velocity.y);

        // if we need to jump add 7 velocity
        if (isJumping){
            myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, jumpPower);
            isJumping = false;
        }
    }
}

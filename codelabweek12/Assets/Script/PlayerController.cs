using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2f;

    Rigidbody myRb;

    private void Start()
    {
        myRb = gameObject.GetComponent<Rigidbody>();                                                            //finds and sets he rigidbody to a variable
    }

    private void FixedUpdate()
    {
        Vector3 getInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));        //recieves the playerinput
        Vector3 dir = getInput.normalized;                                                                      //normalises the input and saves it

        //Debug.Log(myRb.velocity);
        myRb.velocity = dir * moveSpeed;                                                                        //manipulates the player object's velocity to move the player object 

        Vector3 lookPos = new Vector3(
                transform.position.x + myRb.velocity.x,
                transform.position.y,
                transform.position.z + myRb.velocity.z
            );                                                                                                  //updates character movement
        transform.LookAt(lookPos);                                                                              //ses the direction for the player object to look at
    }
}
